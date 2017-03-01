using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Sample1
{
    class DisconnectedExample
    {
        static void main()
        {
            string connectionString =
            "Data Source=(local);Initial Catalog=Student;"
            + "Integrated Security=true";

            string queryString =
            "SELECT * from Student.dbo.Students ";

            SqlConnection connection = new SqlConnection(connectionString);
            connection.Open();
            SqlCommand cmdQuery = new SqlCommand(queryString, connection);
            SqlDataAdapter sda = new SqlDataAdapter(cmdQuery);
            DataSet dsData = new DataSet();
            sda.Fill(dsData);
        }
    }
}
