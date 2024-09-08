using Microsoft.Data.SqlClient;
using Microsoft.Extensions.Configuration;
using System.Data;

namespace Day_1_ADO
{
    internal class Program
    {
        static void Main(string[] args)
        {

            #region Configure Connection String 
            var configuration = new ConfigurationBuilder().AddJsonFile("appsettings.json").Build();
            var constr = configuration.GetSection("constr").Value;
            #endregion

            #region Execute Raw SQL

            // Connection 
            // Command 
            // Reader 

            SqlConnection conn = new SqlConnection(constr);

            string sql = "SELECT * FROM Wallets";
            SqlCommand command = new SqlCommand(sql, conn);
            command.CommandType = CommandType.Text;

            conn.Open();

            SqlDataReader reader = command.ExecuteReader();

            Wallet wallet;

            while (reader.Read())
            {
                wallet = new Wallet
                {
                    Id = reader.GetInt32("Id"),
                    Holder = reader.GetString("Holder"),
                    Balance = reader.GetDecimal("Balance")
                };
                Console.WriteLine(wallet);
            }

            conn.Close();

            #endregion





            Console.ReadKey();
        }
    }
}
