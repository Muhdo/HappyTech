using System;
using System.Collections.Generic;
using Happytech.Properties;
using System.Data.SqlClient;
using Happytech.Classes;
using System.Windows;
using System.Data;
using System.Windows.Navigation;

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
        private SqlCommand _addEmployee = new SqlCommand("INSERT INTO Employee (Name, RoleID) VALUES (@Name, @RoleID)", connection);
        //Removes employee from database
        private SqlCommand _removeEmployee = new SqlCommand("DELETE FROM Employee WHERE EmployeeID = @EmployeeID", connection);
        //Lists every role available
        private SqlCommand _listRoles = new SqlCommand("SELECT RoleID, Role FROM Role", connection);
        //Checks if the role is in use by any employee
        private SqlCommand _isRoleInUse = new SqlCommand("SELECT EmployeeID FROM Employee WHERE RoleID = @RoleID", connection);
        //Removes a role from database
        private SqlCommand _removeRole = new SqlCommand("DELETE FROM Role WHERE RoleID = @RoleID", connection);
        //Adds a new role
        private SqlCommand _addRole = new SqlCommand("INSERT INTO Role (Role) VALUES (@Role)", connection);
        //Number of new applications (not replied yet)
        private SqlCommand _numberNewApplications = new SqlCommand("SELECT COUNT(ApplicationID) FROM Application WHERE NOT EXISTS (SELECT ApplicationID FROM Reply)", connection);
        //Returns data from new applications
        private SqlCommand _newApplications = new SqlCommand("SELECT ApplicationID, Name, Email, Role, Curriculum FROM Application INNER JOIN Role ON PositionID = RoleID WHERE NOT EXISTS (SELECT ApplicationID FROM Reply)", connection);
        //Number of replied applications by current user
        private SqlCommand _numberRepliedApplications = new SqlCommand("SELECT COUNT(ReplyID) FROM Reply WHERE Sent = 0 AND EmployeeID = @EmployeeID", connection);
        //Adds a new application
        private SqlCommand _applyToPosition = new SqlCommand("INSERT INTO Application (Name, Email, RoleID, Curriculum) VALUES (@Name, @Email, @RoleID, @Curriculum)", connection);
        // Adds a new template
        private SqlCommand _addTemplate = new SqlCommand("INSERT INTO Template (Name) VALUES (@Name)", connection);
        //Finds applicant by applicationID
        private SqlCommand _findApplicantByID = new SqlCommand("SELECT Name FROM Application WHERE ApplicationID = @ApplicationID", connection);
        //Finds curriculum by applicationID
        private SqlCommand _findCVNameByID = new SqlCommand("SELECT Curriculum FROM Application WHERE ApplicationID = @ApplicationID", connection);

        // REMOVE COMMANDS

        // Delete replied application
        private SqlCommand _removeReply = new SqlCommand("DELETE FROM Reply WHERE ReplyID = @ReplyID", connection);

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

        public bool RemoveReply(int ReplyID)
        {
            _removeReply.Parameters.Clear();
            _removeReply.Parameters.AddWithValue("@ReplyID", ReplyID);

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
                if(connection.State != ConnectionState.Open)
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
        /// Finds if the current windows employee is registered
        /// </summary>
        /// <param name="name">Name to search.</param>
        /// <returns>True if registered or false if is not registered.</returns>
        public bool FindEmployee(string name = null)
        {
            OpenDb();

            //Setting query to find current windows user
            _findEmployee.Parameters.AddWithValue("@Name", name ?? Environment.UserName); //Uses name variable if it's not null, otherwise uses Environment.UserName
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
                    Id = (int)Reader["EmployeeID"],
                    Name = (string)Reader["Name"],
                    Role = (string)Reader["Role"]
                });
            }

            CloseDb();
            return employees.ToArray();
        }

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
        public bool AddEmployee(string name, int roleId)
        {
            OpenDb();

            bool success = false;

            try
            {
                _addEmployee.Parameters.AddWithValue("@Name", name.Trim());
                _addEmployee.Parameters.AddWithValue("@RoleID", roleId);
                _addEmployee.ExecuteNonQuery();
                _addEmployee.Parameters.Clear();

                success = true;
            }
            catch (Exception) { }

            CloseDb();
            return success;
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
                    Id = (int)Reader["RoleID"],
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
        /// <returns>True if was inserted, false in any error.</returns>
        public bool AddRole(string role)
        {
            OpenDb();

            bool success = false;

            try
            {
                _addRole.Parameters.AddWithValue("@Role", role.Trim());
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

            int quant = (int)Reader[0]; //Saves data

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

            int quant = (int)Reader[0]; //Saves data

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
