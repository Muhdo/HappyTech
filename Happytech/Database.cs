using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using Happytech.Classes;
using System.Windows;
using System.Data;
using System.Windows.Navigation;
using HappyTech.Classes;
using HappyTech.Properties;

namespace Happytech
{
    class Database
    {
        private SqlDataReader Reader; //It's a reader...

        private static SqlConnection connection = new SqlConnection(Settings.Default.connectionString); //Connection to database, to change the string go to: Properties>Settings and change connectionString

        //Can be identified as the login
        //The employee needs to be added to the system by the administrator which is identified with the "EmployeeID" = 0
        private SqlCommand _findEmployee = new SqlCommand("SELECT EmployeeID, Name, Role, IsAdmin FROM Employee INNER JOIN Role ON Employee.RoleID = Role.RoleID WHERE Name = @Name", connection);
        //Lists every employee excluding the admin account
        private SqlCommand _listEmployees = new SqlCommand("SELECT EmployeeID, Name, Role FROM Employee INNER JOIN Role ON Employee.RoleID = Role.RoleID WHERE EmployeeID <> 0", connection);
        //Adds a new employee
        private SqlCommand _addEmployee = new SqlCommand("INSERT INTO Employee (Name, RoleID, Password) VALUES (@Name, @RoleID, @Password)", connection);
        //Removes employee from database
        private SqlCommand _removeEmployee = new SqlCommand("DELETE FROM Employee WHERE EmployeeID = @EmployeeID", connection);
        //Lists every role available
        private SqlCommand _listRoles = new SqlCommand("SELECT RoleID, Role FROM Role", connection);
        //Checks if the role is in use by any employee
        private SqlCommand _isRoleInUse = new SqlCommand("SELECT EmployeeID FROM Employee WHERE RoleID = @RoleID", connection);
        //Removes a role from database
        private SqlCommand _removeRole = new SqlCommand("DELETE FROM Role WHERE RoleID = @RoleID", connection);
        //Adds a new role
        private SqlCommand _addRole = new SqlCommand("INSERT INTO Role (Role, IsAdmin) VALUES (@Role, @IsAdmin)", connection);
        //Number of new applications (not replied yet)
        private SqlCommand _numberNewApplications = new SqlCommand("SELECT COUNT(ApplicationID) AS 'Count' FROM Application WHERE NOT EXISTS (SELECT ApplicationID FROM Reply)", connection);
        //Returns data from new applications
        private SqlCommand _newApplications = new SqlCommand("SELECT ApplicationID, Name, Email, Role, Curriculum FROM Application INNER JOIN Role ON Application.RoleID = Role.RoleID WHERE NOT EXISTS (SELECT ApplicationID FROM Reply)", connection);
        //Number of replied applications by current user
        private SqlCommand _numberRepliedApplications = new SqlCommand("SELECT COUNT(ReplyID) AS 'Count' FROM Reply WHERE Sent = 0 AND EmployeeID = @EmployeeID", connection);
        //Adds a new application
        private SqlCommand _applyToPosition = new SqlCommand("INSERT INTO Application (Name, Email, RoleID, Curriculum) VALUES (@Name, @Email, @RoleID, @Curriculum)", connection);
        // Adds a new template
        private SqlCommand _addTemplate = new SqlCommand("INSERT INTO Template (Name) VALUES (@Name)", connection);
        //Finds applicant by applicationID
        private SqlCommand _findApplicantByID = new SqlCommand("SELECT Name FROM Application WHERE ApplicationID = @ApplicationID", connection);
        //Finds curriculum by applicationID
        private SqlCommand _findCVNameByID = new SqlCommand("SELECT Curriculum FROM Application WHERE ApplicationID = @ApplicationID", connection);
        //Login
        private SqlCommand _login = new SqlCommand("SELECT * FROM Employee WHERE Name = @Username AND Password = @Password", connection);
        //Find Role
        private SqlCommand _FindRole = new SqlCommand("SELECT * FROM Role WHERE RoleID = @RoleID", connection);
        //Get every template
        private SqlCommand _listTemplates = new SqlCommand("SELECT * FROM Template", connection);
        //Get Applicant info
        private SqlCommand _getApplicant = new SqlCommand("SELECT ApplicationID, Name, Email, Role, Curriculum FROM Application INNER JOIN Role ON Application.RoleID = Role.RoleID WHERE ApplicationID = @ApplicationID", connection);
        //Get specific comment
        private SqlCommand _getComment = new SqlCommand("SELECT Comment FROM Comment WHERE CommentID = @CommentID", connection);

        // REMOVE COMMANDS
        // Delete application
        private SqlCommand _removeApplication = new SqlCommand("DELETE FROM Application WHERE ApplicationID = @ApplicationID", connection);
        private SqlCommand _removeReply = new SqlCommand("DELETE FROM Reply WHERE ApplicationID = @ApplicationID", connection);

        //INSERT COMMANDS
        //Add section
        private SqlCommand _addSection = new SqlCommand("INSERT INTO Section (Title) VALUES (@Title)", connection);
        //Add comment
        private SqlCommand _addComment = new SqlCommand("INSERT INTO Comment (Comment, ShortName) VALUES (@Comment, @ShortName)", connection);
        //Link a section to a template
        private SqlCommand _linkTemplateSection = new SqlCommand("INSERT INTO Template_Section (SectionID, TemplateID) VALUES (@SectionID, @TemplateID)", connection);
        //Link a comment to a section
        private SqlCommand _linkCommentSection = new SqlCommand("INSERT INTO Comment_Section (CommentID, SectionID) VALUES (@CommentID, @SectionID)", connection);

        //SELECT COMMANDS
        //Get templateID
        private SqlCommand _getTemplateID = new SqlCommand("SELECT TemplateID FROM Template WHERE Name = @Name", connection);
        //Get sectionID
        private SqlCommand _getSectionID = new SqlCommand("SELECT SectionID FROM Section WHERE Title = @Title", connection);
        //Get commentID
        private SqlCommand _getCommentID = new SqlCommand("SELECT CommentId FROM Comment WHERE ShortName = @ShortName AND Comment = @Comment", connection);


        //Get sections from template
        private SqlCommand _getDataFromTemplateID = new SqlCommand("SELECT Template.TemplateID, Name, DesignedPositionID, Section.SectionID, Title, Comment.CommentID, Comment, ShortName FROM Template INNER JOIN Template_Section ON Template.TemplateID = Template_Section.TemplateID INNER JOIN Section ON Template_Section.SectionID = Section.SectionID INNER JOIN Comment_Section ON Section.SectionID = Comment_Section.SectionID INNER JOIN Comment ON Comment_Section.CommentID = Comment.CommentId WHERE Template.TemplateID = @TemplateID", connection);

        /// <summary>
        /// Inserts template name to Template
        /// Inserts section names to Section
        /// Inserts code-comment pairs to Comment
        /// Links sections to template 
        /// Links code-comment pairs to section
        /// </summary>
        /// <param name="templateName">The name of the template to be added</param>
        /// <param name="sectionNames">The names of the sections to be added</param>
        /// <param name="codeComments">2d array where for each code-comment pair y [x, y] x = 0 is the code and x = 1 is the comment</param>
        public void CreateTemplate(string templateName, string[] sectionNames, List<string>[,] codeComments)
        {
            AddTemplate(templateName);
            //get templateID
            OpenDb();
            _getTemplateID.Parameters.Clear();
            _getTemplateID.Parameters.AddWithValue("@Name", templateName);
            int templateID = 0;
            using(var reader = _getTemplateID.ExecuteReader())
            {
                while (reader.Read())
                {
                    templateID = (int)reader[0];
                }
            }
            //add sections
            foreach (string sectionName in sectionNames)
            {
                _addSection.Parameters.Clear();
                _addSection.Parameters.AddWithValue("@Title", sectionName);
                _addSection.ExecuteNonQuery();
                //get sectionID
                int sectionID = 0;
                _getSectionID.Parameters.Clear();
                _getSectionID.Parameters.AddWithValue("@Title", sectionName);
                using(var reader = _getSectionID.ExecuteReader())
                {
                    while (reader.Read())
                    {
                        sectionID = (int)reader[0];
                    }
                }
                //link section and template
                _linkTemplateSection.Parameters.Clear();
                _linkTemplateSection.Parameters.AddWithValue("@SectionID", sectionID);
                _linkTemplateSection.Parameters.AddWithValue("@TemplateID", templateID);
                _linkTemplateSection.ExecuteNonQuery();
            }

            //add comments
            for (int i = 0; i < sectionNames.Length; i++)
            {
                //get sectionID
                _getSectionID.Parameters.Clear();
                _getSectionID.Parameters.AddWithValue("@Title", sectionNames[i]);
                int sectionID = 0;
                using (var reader = _getSectionID.ExecuteReader())
                {
                    while (reader.Read())
                    {
                        sectionID = (int)reader[0];
                    }
                }
                //extract codes and comments for this section
                List<string> sectionCodes = codeComments[0, i];
                List<string> sectionComments = codeComments[1, i];
                //for each code in the section
                foreach (string code in sectionCodes)
                {
                    //get the matching comment
                    int commentNo = sectionCodes.IndexOf(code);
                    string comment = sectionComments[commentNo];
                    //insert the code-comment pair
                    _addComment.Parameters.Clear();
                    _addComment.Parameters.AddWithValue("@ShortName", code);
                    _addComment.Parameters.AddWithValue("@Comment", comment);
                    _addComment.ExecuteNonQuery();
                    //get commentID
                    _getCommentID.Parameters.Clear();
                    _getCommentID.Parameters.AddWithValue("@ShortName", code);
                    _getCommentID.Parameters.AddWithValue("@Comment", comment);
                    int commentID = 0;
                    using (var reader = _getCommentID.ExecuteReader())
                    {
                        while (reader.Read())
                        {
                            commentID = (int)reader[0];
                        }
                    }
                    //link comment and section
                    _linkCommentSection.Parameters.Clear();
                    _linkCommentSection.Parameters.AddWithValue("@CommentID", commentID);
                    _linkCommentSection.Parameters.AddWithValue("@SectionID", sectionID);
                    _linkCommentSection.ExecuteNonQuery();
                }
            }
            CloseDb();
        }



        public bool Login(string username, string password)
        {
            _login.Parameters.Clear();
            _login.Parameters.AddWithValue("@Username", username);
            _login.Parameters.AddWithValue("@Password", password);

            try
            {
                if (connection.State != ConnectionState.Open)
                    OpenDb();

                using (var reader = _login.ExecuteReader())
                {
                    while (reader.Read())
                        if (reader.HasRows)
                        {
                            // Get role information
                            var role = Role((int)reader["RoleID"]);

                            // Set new employee
                            new CurrentEmployee().SetEmployee(
                                (int)reader["EmployeeID"],
                                (string)reader["Name"],
                                (string)role[0],
                                (bool)role[1]);

                            CloseDb();
                            return true;
                        }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
                CloseDb();
                return false;
            }

            CloseDb();
            return false;
        }

        public object[] Role(int RoleID)
        {
            _FindRole.Parameters.Clear();
            _FindRole.Parameters.AddWithValue("@RoleID", RoleID);

            try
            {
                if (connection.State != ConnectionState.Open)
                    OpenDb();

                using(var reader = _FindRole.ExecuteReader())
                {
                    while(reader.Read())
                        if (reader.HasRows)
                        {
                            object[] Role = new object[] { reader["Role"].ToString(), (bool)reader["IsAdmin"] };
                            return Role;
                        }
                }
            }
            catch(Exception ex)
            {
                MessageBox.Show("xe " + ex.Message);
                return null;
            }

            return null;
        }

        public DataTable FetchNewApplications()
        {
            try
            {
                OpenDb();
                var dataAdapter = new SqlDataAdapter("SELECT * FROM Application WHERE ApplicationID NOT IN (SELECT ApplicationID FROM Reply)", connection);
                var dataTable = new DataTable();
                dataAdapter.Fill(dataTable);
                CloseDb();
                return dataTable;
            }
            // TODO: Specific exception
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }

            CloseDb();
            return null;
        }

        public DataTable FetchRepliedApplications()
        {
            try
            {
                OpenDb();
                var dataAdapter = new SqlDataAdapter("SELECT * FROM Application WHERE ApplicationID IN (SELECT ApplicationID FROM Reply)", connection);
                var dataTable = new DataTable();
                dataAdapter.Fill(dataTable);
                CloseDb();
                return dataTable;
            }
            // TODO: Specific exception
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }

            CloseDb();
            return null;
        }

        public DataTable FetchApplications()
        {
            try
            {
                OpenDb();
                var dataAdapter = new SqlDataAdapter("SELECT * FROM Application", connection);
                var dataTable = new DataTable();
                dataAdapter.Fill(dataTable);
                CloseDb();
                return dataTable;
            }
            // TODO: Specific exception
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }

            CloseDb();
            return null;
        }

        public bool RemoveApplication(int ApplicationID)
        {
            _removeApplication.Parameters.Clear();
            _removeApplication.Parameters.AddWithValue("@ApplicationID", ApplicationID);

            try
            {
                // Open connection
                OpenDb();

                // Delete reply
                if (_removeApplication.ExecuteNonQuery() > 0)
                {
                    CloseDb();
                    return true;
                }

            }
            // TODO: Specific exception handling
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }

            // Close database connection
            CloseDb();
            return false;
        }

        public bool RemoveReply(int ApplicationID)
        {
            _removeReply.Parameters.Clear();
            _removeReply.Parameters.AddWithValue("@ApplicationID", ApplicationID);

            try
            {
                // Open connection
                OpenDb();

                // Delete reply
                if (_removeReply.ExecuteNonQuery() > 0)
                {
                    CloseDb();
                    return true;
                }

            }
            // TODO: Specific exception handling
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }

            // Close database connection
            CloseDb();
            return false;
        }

        public DataTable GetAllReplies()
        {
            try
            {
                OpenDb();
                var dataAdapter = new SqlDataAdapter("SELECT * FROM Reply", connection);
                var dataTable = new DataTable();
                dataAdapter.Fill(dataTable);
                CloseDb();

                return dataTable;
            }
            // TODO: Specific exception
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }

            CloseDb();
            return null;
        }

        public string FindCurriculumName(int ApplicationID)
        {
            _findCVNameByID.Parameters.Clear();
            _findCVNameByID.Parameters.AddWithValue("@ApplicationID", ApplicationID);

            try
            {
                // Open connection
                if (connection.State != ConnectionState.Open)
                    OpenDb();

                // Tries to find a name with an application id
                using (var reader = _findCVNameByID.ExecuteReader())
                {
                    while (reader.Read())
                        if (reader.HasRows)
                        {
                            var cv = (string)reader["Curriculum"];
                            CloseDb();
                            return cv;
                        }
                }
            }
            // TODO: Specific exception handling
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }

            CloseDb();
            return null;
        }

        public string FindApplicantName(int ApplicationID)
        {
            _findApplicantByID.Parameters.Clear();
            _findApplicantByID.Parameters.AddWithValue("@ApplicationID", ApplicationID);

            try
            {
                // Open connection
                if (connection.State != ConnectionState.Open)
                    OpenDb();

                // Tries to find a name with an application id
                using (var reader = _findApplicantByID.ExecuteReader())
                {
                    while (reader.Read())
                        if (reader.HasRows)
                        {
                            var name = (string)reader["Name"];
                            CloseDb();
                            return name;
                        }
                }
            }
            // TODO: Specific exception handling
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }

            CloseDb();
            return null;
        }

        /// <summary>
        /// Finds if the current employee is registered
        /// </summary>
        /// <param name="name">Name to search.</param>
        /// <returns>True if registered or false if is not registered.</returns>
        public bool FindEmployee(string name)
        {
            OpenDb();

            //Setting query to find current windows user
            _findEmployee.Parameters.AddWithValue("@Name", name);
            Reader = _findEmployee.ExecuteReader();
            _findEmployee.Parameters.Clear();

            bool hasRows = false;

            //Checks if has found any employee matching the criteria
            if (Reader.HasRows)
            {
                hasRows = true;
                Reader.Read(); //Reads the first line
                //Adds the employee to the global variables
                new CurrentEmployee().SetEmployee(
                    (int)Reader["EmployeeID"],
                    (string)Reader["Name"],
                    (string)Reader["Role"],
                    (bool)Reader["IsAdmin"]);
            }

            CloseDb();
            return hasRows;
        }

        /// <summary>
        /// To get every employee saved excluding the admin.
        /// </summary>
        /// <returns>Array with employees.</returns>
        public Employee[] ListEmployees()
        {
            OpenDb();

            Reader = _listEmployees.ExecuteReader();

            List<Employee> employees = new List<Employee>();

            while (Reader.Read())
            {
                employees.Add(new Employee
                {
                    EmployeeId = (int)Reader["EmployeeID"],
                    Name = (string)Reader["Name"],
                    Role = (string)Reader["Role"]
                });
            }

            CloseDb();
            return employees.ToArray();
        }

        /// <summary>
        /// Adds a new template
        /// </summary>
        /// <param name="name">Template name</param>
        /// <returns></returns>
        public bool AddTemplate(string name)
        {
            try
            {
                OpenDb();
                _addTemplate.Parameters.AddWithValue("@Name", name);
                _addTemplate.ExecuteNonQuery();
                _addTemplate.Parameters.Clear();
                CloseDb();
                return true;
            }
            catch (Exception ex)
            {
                // TODO: SPECIFIC EXCEPTIONS
                MessageBox.Show(ex.Message);
            }

            return false;
        }

        /// <summary>
        /// Adds a new Employee.
        /// </summary>
        /// <param name="name">Windows Username for the employee.</param>
        /// <param name="roleId">Id of the role.</param>
        /// <returns>True if was inserted, false in any error.</returns>
        public bool AddEmployee(string name, int roleId, string password)
        {
            if (connection.State != ConnectionState.Open)
                OpenDb();

            try
            {
                _addEmployee.Parameters.Clear();
                _addEmployee.Parameters.AddWithValue("@Name", name.Trim());
                _addEmployee.Parameters.AddWithValue("@RoleID", roleId);
                _addEmployee.Parameters.AddWithValue("@Password", password);
                _addEmployee.ExecuteNonQuery();

                CloseDb();
                return true;
            }
            catch (Exception ex) 
            {
                MessageBox.Show(ex.Message);
            }

            CloseDb();
            return false;
        }

        /// <summary>
        /// Removes a specific employee.
        /// </summary>
        /// <param name="employeeId">Id of the Employee.</param>
        /// <returns>True is it was removed, false is it wasn't.</returns>
        public bool RemoveEmployee(int employeeId)
        {
            OpenDb();

            bool success = false;
            try
            {
                _removeEmployee.Parameters.AddWithValue("@EmployeeID", employeeId);
                _removeEmployee.ExecuteNonQuery();
                _removeEmployee.Parameters.Clear();

                success = true;
            }
            catch (Exception) { }

            CloseDb();
            return success;
        }

        /// <summary>
        /// To get every role possible
        /// </summary>
        /// <returns>Array with roles.</returns>
        public Role[] ListRoles()
        {
            OpenDb();

            Reader = _listRoles.ExecuteReader();

            List<Role> roles = new List<Role>();

            while (Reader.Read())
            {
                roles.Add(new Role()
                {
                    RoleId = (int)Reader["RoleID"],
                    RoleName = (string)Reader["Role"]
                });
            }

            CloseDb();
            return roles.ToArray();
        }

        /// <summary>
        /// Adds a new role.
        /// </summary>
        /// <param name="role">New role available.</param>
        /// <param name="isAdmin">If the role is admin.</param>
        /// <returns>True if was inserted, false in any error.</returns>
        public bool AddRole(string role, bool isAdmin)
        {
            OpenDb();

            bool success = false;

            try
            {
                _addRole.Parameters.AddWithValue("@Role", role.Trim());
                _addRole.Parameters.AddWithValue("@IsAdmin", isAdmin);
                _addRole.ExecuteNonQuery();
                _addRole.Parameters.Clear();

                success = true;
            }
            catch (Exception) { }

            CloseDb();
            return success;
        }

        /// <summary>
        /// Removes a specific role.
        /// </summary>
        /// <param name="roleId">Id of the role.</param>
        /// <returns>True is it was removed, false is it wasn't.</returns>
        public bool RemoveRole(int roleId)
        {
            OpenDb();

            bool success = false;
            try
            {
                _removeRole.Parameters.AddWithValue("@RoleID", roleId);
                _removeRole.ExecuteNonQuery();
                _removeRole.Parameters.Clear();

                success = true;
            }
            catch (Exception) { }

            CloseDb();
            return success;
        }

        /// <summary>
        /// Searches if the role is in use by any Employee.
        /// </summary>
        /// <param name="roleID">Id of the role to look.</param>
        /// <returns>True if is in use, false if it isn't.</returns>
        public bool IsRoleInUse(int roleID)
        {
            OpenDb();

            _isRoleInUse.Parameters.AddWithValue("@RoleID", roleID);
            Reader = _isRoleInUse.ExecuteReader();
            _isRoleInUse.Parameters.Clear();

            bool isInUse = Reader.HasRows;

            CloseDb();
            return isInUse;
        }

        /// <summary>
        /// Gets how many new applications exists.
        /// </summary>
        /// <returns>Number of new applications.</returns>
        public int QuantityNewApplications()
        {
            OpenDb();

            Reader = _numberNewApplications.ExecuteReader(); //Executes query

            Reader.Read(); //Moves reader to first result

            int quant = (int)Reader["Count"]; //Saves data

            CloseDb();
            return quant;
        }

        /// <summary>
        /// Returns every new application.
        /// </summary>
        /// <returns>Every New Application.</returns>
        public List<Applications> NewApplications()
        {
            OpenDb();

            Reader = _newApplications.ExecuteReader(); //Executes query

            List<Applications> currentApplications = new List<Applications>(); //New list for the applications

            //While there is data it will loop through it
            while (Reader.Read())
            {
                //Adds current line of data to the list
                currentApplications.Add(new Applications
                {
                    ApplicationId = (int)Reader["ApplicationID"],
                    Name = (string)Reader["Name"],
                    Email = (string)Reader["Email"],
                    Position = (string)Reader["Role"],
                    Curriculum = (string)Reader["Curriculum"]
                });
            }

            CloseDb();
            return currentApplications;
        }

        /// <summary>
        /// Returns the quantity of replied applications.
        /// </summary>
        /// <returns>Number of replied applications.</returns>
        public int QuantityRepliedApplications()
        {
            OpenDb();

            _numberRepliedApplications.Parameters.AddWithValue("@EmployeeID", CurrentEmployee.Id);
            Reader = _numberRepliedApplications.ExecuteReader(); //Executes query
            _numberRepliedApplications.Parameters.Clear();

            Reader.Read(); //Moves reader to first result

            int quant = (int)Reader["Count"]; //Saves data

            CloseDb();
            return quant;
        }

        /// <summary>
        /// Apply to an available position.
        /// </summary>
        /// <param name="name">Name of the applicant.</param>
        /// <param name="email">Email of the applicant.</param>
        /// <param name="roleID">Role Id of the applying role.</param>
        /// <param name="curriculum">Location of the curriculum file.</param>
        /// <returns>True if it was submitted, False if it wasn't.</returns>
        public bool ApplyToPosition(string name, string email, int roleID, string curriculum)
        {
            OpenDb();

            bool success = false;
            try
            {
                _applyToPosition.Parameters.AddWithValue("@Name", name.Trim());
                _applyToPosition.Parameters.AddWithValue("@Email", email.Trim());
                _applyToPosition.Parameters.AddWithValue("@RoleID", roleID);
                _applyToPosition.Parameters.AddWithValue("@Curriculum", curriculum);
                _applyToPosition.ExecuteNonQuery();
                _applyToPosition.Parameters.Clear();

                success = true;
            }
            catch (Exception) { }


            CloseDb();
            return success;
        }

        public List<Template> GetTemplateNames()
        {
            List<Template> tempTemplates = new List<Template>();
            OpenDb();

            Reader = _listTemplates.ExecuteReader();

            while (Reader.Read())
            {
                tempTemplates.Add(new Template()
                {
                    TemplateId = (int)Reader["TemplateID"],
                    Name = (string)Reader["Name"],
                    DesignedPositionId = (int)Reader["DesignedPositionID"],
                    Sections = null
                });
            }

            CloseDb();
            return tempTemplates;
        }

        public Applications GetApplication(int id)
        {
            OpenDb();

            _getApplicant.Parameters.AddWithValue("@ApplicationID", id);
            Reader = _getApplicant.ExecuteReader();
            _getApplicant.Parameters.Clear();

            Reader.Read();

            Applications application = new Applications()
            {
                ApplicationId = (int)Reader["ApplicationID"],
                Name = (string)Reader["Name"],
                Email = (string)Reader["Email"],
                Position = (string)Reader["Role"],
                Curriculum = (string)Reader["Curriculum"],
            };

            CloseDb();
            return application;
        }

        public Template GetTemplateData(int templateId)
        {
            Template template = new Template();
            OpenDb();

            //Gets the data for the template
            _getDataFromTemplateID.Parameters.AddWithValue("@TemplateID", templateId);
            Reader = _getDataFromTemplateID.ExecuteReader();
            _getDataFromTemplateID.Parameters.Clear();

            //Checks if there is any template
            if (Reader.HasRows)
            {
                //The first read will set the base data
                Reader.Read();

                template.TemplateId = (int)Reader["TemplateID"];
                template.Name = (string)Reader["Name"];
                template.DesignedPositionId = (int)Reader["DesignedPositionID"];
                //Goes through the data and adds the comments to their corresponding section and adds the new sections
                do
                {
                    //Gets the index of the section if exists (-1 if not) 
                    int sectionIndex = template.Sections.FindIndex(s => s.SectionId == (int) Reader["SectionID"]);

                    //If exists
                    if (sectionIndex != -1)
                    {
                        //Adds comment to the section
                        template.Sections[sectionIndex].Comments.Add(new Comment()
                        {
                            CommentId = (int) Reader["CommentID"],
                            ShortName = (string) Reader["ShortName"],
                            CommentText = (string) Reader["Comment"],
                        });
                    }
                    else //if doesn't exist
                    {
                        //Adds a new section
                        template.Sections.Add(new Section()
                        {
                            SectionId = (int) Reader["SectionID"],
                            Title = (string) Reader["Title"],
                            //Adds the first comment
                            Comments = new List<Comment>
                            {
                                new Comment()
                                {
                                    CommentId = (int) Reader["CommentID"],
                                    ShortName = (string) Reader["ShortName"],
                                    CommentText = (string) Reader["Comment"],
                                }
                            },
                        });
                    }
                } while (Reader.Read());
            }

            CloseDb();
            return template;
        }

        public string GetComment(int commentId)
        {
            OpenDb();
            _getComment.Parameters.AddWithValue("@CommentID", commentId);
            Reader = _getComment.ExecuteReader();
            _getComment.Parameters.Clear();

            Reader.Read();
            string comment = (string)Reader["Comment"];

            CloseDb();
            return comment;
        }

        /// <summary>
        /// Opens a database connection.
        /// </summary>
        private void OpenDb() => connection.Open();

        /// <summary>
        /// Closes Reader and database connection.
        /// </summary>
        private void CloseDb()
        {
            Reader?.Close();
            connection.Close();
        }
    }
}
