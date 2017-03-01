using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Sample1
{
    class ReadColumn
    {
        static void Main(string[] args)
        {
            string connectionString =
            "Data Source=(local);Initial Catalog=Student;"
            + "Integrated Security=true";

            string queryString =
            "SELECT StudentID from Student.dbo.Students ";

            // Create and open the connection in a using block.This
        // ensures that all resources will be closed and disposed
        // when the code exits.
            using (SqlConnection connection = new SqlConnection(connectionString))
            {
                // Create the Command and Parameter objects.
                SqlCommand command = new SqlCommand(queryString, connection);
                try
                {
                    connection.Open();
                    SqlDataReader reader = command.ExecuteReader();
                    while (reader.Read())
                    {
                        Console.WriteLine("{0}", reader[0]);
                    }
                    reader.Close();
                }
                catch (Exception ex)
                {
                    Console.WriteLine(ex.Message);
                }
                Console.ReadLine();
            }
        }
    }
}
