using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;

/*

This code creates a new `SqlConnection` object and sets the connection string to connect to a SQL Server database. 
The `using` statement ensures that the connection is properly closed and disposed when the code exits the block. 
Once the connection is open, you can perform various database operations such as inserting, updating, and deleting data.

In this example, we use `SqlCommand` objects to execute SQL commands against the database. 
We use parameterized queries to insert, update, and delete data in the `Customers` table. 
Parameterized queries help prevent SQL injection attacks 
by ensuring that user input is properly sanitized before being used in a SQL statement.

*/


namespace Connecting_Database_drill
{
    public class DatabaseOperations
    {
        public void PerformDatabaseOperations()
        {
            // Set the connection string 
            string connectionString = "Data Source=ServerName;Initial Catalog=DatabaseName;Integrated Security=True";

            // Create a new SqlConnection object
            using (SqlConnection connection = new SqlConnection(connectionString))
            {
                // Open the connection
                connection.Open();

                // Insert a new record into the database
                using (SqlCommand command = new SqlCommand("INSERT INTO Customers (FirstName, LastName) VALUES (@FirstName, @LastName)", connection))
                {
                    // Set the values for the parameters
                    command.Parameters.AddWithValue("@FirstName", "John");
                    command.Parameters.AddWithValue("@LastName", "Doe");

                    // Execute the command
                    command.ExecuteNonQuery();
                }

                // Update an existing record in the database
                using (SqlCommand command = new SqlCommand("UPDATE Customers SET FirstName = @FirstName WHERE LastName = @LastName", connection))
                {
                    // Set the values for the parameters
                    command.Parameters.AddWithValue("@FirstName", "Jane");
                    command.Parameters.AddWithValue("@LastName", "Doe");

                    // Execute the command
                    command.ExecuteNonQuery();
                }

                // Delete a record from the database
                using (SqlCommand command = new SqlCommand("DELETE FROM Customers WHERE LastName = @LastName", connection))
                {
                    // Set the value for the parameter
                    command.Parameters.AddWithValue("@LastName", "Doe");

                    // Execute the command
                    command.ExecuteNonQuery();
                }
            }
        }
    }
}



