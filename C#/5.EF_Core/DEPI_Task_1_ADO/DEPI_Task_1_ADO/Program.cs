using Microsoft.Extensions.Configuration;
using Microsoft.Data.SqlClient;
using System.Data;
using static System.Runtime.InteropServices.JavaScript.JSType;
using System.Reflection.Metadata;
namespace DEPI_Task_1_ADO
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // Configration 
            // Connection 
            // Command 
            // Reader 


            //var configuration = new ConfigurationBuilder().AddJsonFile("appsettings.json").Build();
            //var constr = configuration.GetSection("constr").Value;

            //SqlConnection conn = new SqlConnection(constr);


            // Connected mode 
            //SqlCommand command = new SqlCommand("SELECT * FROM Departments;", conn);
            //conn.Open();
            //Department department;
            //SqlDataReader reader = command.ExecuteReader();
            //while (reader.Read())
            //{
            //    department = new Department() {
            //    Dnum = reader.GetInt32("Dnum"),
            //    Dname = reader.GetString("Dname"),
            //    MGRSSN = reader.GetInt32("MGRSSN"),
            //    MGRStart_Date = reader.GetDateTime("MGRStart Date")
            //    };
            //    Console.WriteLine(department);
            //}
            //conn.Close();

            // DisConnected Mode 

            //conn.Open();

            //SqlDataAdapter adapter = new SqlDataAdapter("SELECT * FROM Departments;",conn);  
            //DataTable dataTable = new DataTable();
            //adapter.Fill(dataTable);

            //conn.Close();

            //Console.WriteLine("Dnum\tDname\tMGRSSN\tMGRStart_Date");
            //Console.WriteLine("-----------------------------------------");


            //foreach (DataRow item in dataTable.Rows)
            //{
            //    Console.WriteLine($"{item["Dnum"]}\t{item["Dname"]}\t{item["MGRSSN"]}\t{item["MGRStart Date"]}");
            //}

            //int dnum = 20;

            //foreach (DataRow item in dataTable.Rows )
            //{
            //    if ((int)item["Dnum"] == dnum)
            //    {
            //        Console.WriteLine($"{item["Dnum"]}\t{item["Dname"]}\t{item["MGRSSN"]}\t{item["MGRStart Date"]}");
            //    }
            //}

            Menu menu = new Menu(); 

            //menu.DisplayAllDepartment();

            // menu.DisplayDepartmentByNum(20);


            // -------------------------------------------------------------------------------


            // Add , Delete , Update

            var configuration = new ConfigurationBuilder()
               .AddJsonFile("appsettings.json")
               .Build();
            // read from user input
            var department = new Department
            {
               Dnum = 50,
               Dname = "DP5",
               MGRSSN = 102660,
            };

            SqlConnection conn = new SqlConnection(configuration.GetSection("constr").Value);

            var sql = "INSERT INTO Departments (Dnum,Dname,MGRSSN)" +
                "VALUES (@Dnum,@Dname,@MGRSSN);";

            SqlParameter DnumParameter = new SqlParameter
            {
                ParameterName = "@Dnum",
                SqlDbType = SqlDbType.Int,
                Direction = ParameterDirection.Input,
                Value = department.Dnum,
            };

            SqlParameter DnameParameter = new SqlParameter
            {
                ParameterName = "@Dname",
                SqlDbType = SqlDbType.VarChar,
                Direction = ParameterDirection.Input,
                Value = department.Dname,
            };

            SqlParameter MGRSSNParameter = new SqlParameter
            {
                ParameterName = "@MGRSSN",
                SqlDbType = SqlDbType.Int,
                Direction = ParameterDirection.Input,
                Value = department.MGRSSN,
            };


            SqlCommand command = new SqlCommand(sql, conn);

            command.Parameters.Add(DnumParameter);
            command.Parameters.Add(DnameParameter);
            command.Parameters.Add(MGRSSNParameter);
            command.CommandType = CommandType.Text;
            conn.Open();

            if (command.ExecuteNonQuery() > 0)
            {
                Console.WriteLine($"Department for {department.Dname} added successully");
            }
            else
            {
                Console.WriteLine($"ERROR: Department for {department.Dname} was not added");
            }
            conn.Close();

            menu.DisplayAllDepartment();

        }
    }
}
