using System;
using Happytech.Properties;
using System.Data.SqlClient;

namespace Happytech.Classes
{
    class Database
    {
        private SqlDataReader Reader;

        public static SqlConnection connection = new SqlConnection(Settings.Default.connectionString);
        
        private SqlCommand _findEmployee = new SqlCommand("SELECT EmployeeID, Name, Role FROM Employee INNER JOIN Role ON Employee.RoleID = Role.RoleID WHERE Name = @Name", connection);
        private SqlCommand _newApplications = new SqlCommand("SELECT ApplicationID, Name, Email, Position FROM Application INNER JOIN Role ON PositionID = RoleID WHERE NOT EXISTS (SELECT ApplicationID FROM TemplateIP)", connection);
        private SqlCommand _numberNewApplications = new SqlCommand("SELECT COUNT(ApplicationID) FROM Application WHERE NOT EXISTS (SELECT ApplicationID FROM TemplateIP)", connection);

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

            //Checks if has found any employee matching the criteria
            if (!Reader.HasRows)
            {
                CloseDb();
                return false;
            }
            else
            {
                Reader.Read(); //Reads the first line
                //Adds the employee to the global variables
                new Employee().SetEmployee(int.Parse(Reader["EmployeeID"].ToString()), Reader["Name"].ToString(),
                    Reader["Role"].ToString());

                CloseDb();
                return true;
            }
        }

        /// <summary>
        /// Gets how many new applications exists.
        /// </summary>
        /// <returns>Number of new applications</returns>
        public int QuantityNewApplications()
        {
            OpenDb();

            Reader = _numberNewApplications.ExecuteReader();

            Reader.Read();

            int quant = int.Parse(Reader[0].ToString());

            CloseDb();
            return quant;
        } 

        /// <summary>
        /// Opens a database connection
        /// </summary>
        private void OpenDb() => connection.Open();

            //Closes Reader and database connection
        private void CloseDb()
        {
            Reader.Close();
            connection.Close();
        }
    }
}
