using System;
using System.Data.SqlClient;

namespace ReadDataByADO
{
    class Program
    {
        static void Main(string[] args)
        {
            var ConnectionString = "Server = DESKTOP-EA380EP\\SQLEXPRESS;Database = Assignment3; Trusted_Connection=true;";
            var selectSQL = "Select * from products ;";

            SqlConnection con = new SqlConnection(ConnectionString);
            SqlCommand command = new SqlCommand(selectSQL, con);
            con.Open();


            SqlDataReader reader = command.ExecuteReader();
            Console.WriteLine("ID, Title, " + "   Price,   IsAvailable ,  CreatedOn     Avalable Q");
            Console.WriteLine("==============================================================");
          
            while (reader.Read())
            {
                Console.Write(reader["Id"].ToString() + ", ");
                Console.Write(reader["Title"].ToString() + ", ");
                Console.Write(reader["Price"].ToString() + ", ");
                Console.Write(reader["IsAvailable"].ToString() + ", ");
                Console.Write(reader["CreatedOn"].ToString() + ", ");
                Console.Write(reader["AvailableQuantity"].ToString());
                Console.WriteLine("");
            }

            //Release resources  
            reader.Close();
            con.Close();
        }
    }
}
