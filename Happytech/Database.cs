using System;
using System.Collections.Generic;
using Happytech.Properties;
using System.Data.SqlClient;
using Happytech.Classes;

namespace Happytech
{
    class Database
    {
        private SqlDataReader Reader; //It's a reader...

        public static SqlConnection connection = new SqlConnection(Settings.Default.connectionString); //Connection to database, to change the string go to: Properties>Settings and change connectionString
        
        //Can be identified as the login
        //The employee needs to be added to the system by the administrator which is identified with the "EmployeeID" = 0
        private SqlCommand _findEmployee = new SqlCommand("SELECT EmployeeID, Name, Role FROM Employee INNER JOIN Role ON Employee.RoleID = Role.RoleID WHERE Name = @Name", connection);
        //Lists every employee excluding the admin account
        private SqlCommand _listEmployees = new SqlCommand("SELECT EmployeeID, Name, Role FROM Employee INNER JOIN Role ON Employee.RoleID = Role.RoleID", connection);
        //Removes employee from database
        private SqlCommand _removeEmployee = new SqlCommand("DELETE FROM Employee WHERE EmployeeID = @EmployeeID", connection);
        //Number of new applications (not replied yet)
        private SqlCommand _numberNewApplications = new SqlCommand("SELECT COUNT(ApplicationID) FROM Application WHERE NOT EXISTS (SELECT ApplicationID FROM Reply)", connection);
        //Returns data from new applications
        private SqlCommand _newApplications = new SqlCommand("SELECT ApplicationID, Name, Email, Role, Curriculum FROM Application INNER JOIN Role ON PositionID = RoleID WHERE NOT EXISTS (SELECT ApplicationID FROM Reply)", connection);
        //Number of replied applications by current user
        private SqlCommand _numberRepliedApplications = new SqlCommand("SELECT COUNT(ReplyID) FROM Reply WHERE Sent = 0 AND EmployeeID = @EmployeeID", connection);

        /// <summary>
        /// Finds if the current windows employee is registered
        /// </summary>
        /// <returns>true if registered or false if is not registered.</returns>
        public bool FindEmployee()
        {
            OpenDb();

            //Setting query to find current windows user
            _findEmployee.Parameters.AddWithValue("@Name", Environment.UserName);
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
                    (string)Reader["Role"]);
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

        public bool RemoveEmployee(int employeeId)
        {
            OpenDb();

            bool success = false;
            int rows = 0;
            try
            {
                _removeEmployee.Parameters.AddWithValue("@EmployeeID", employeeId);
                rows = _removeEmployee.ExecuteNonQuery();
                _removeEmployee.Parameters.Clear();

                success = true;
            }
            catch (Exception e) { Console.WriteLine(e);}

            Console.WriteLine(rows);

            CloseDb();
            return success;
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
        /// Returns every new application
        /// </summary>
        /// <returns></returns>
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
                    Curriculum = Reader["Curriculum"]
                });
            }

            CloseDb();
            return currentApplications;
        }

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
