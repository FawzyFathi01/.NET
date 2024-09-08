using Microsoft.Data.SqlClient;
using Microsoft.Extensions.Configuration;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DEPI_Task_1_ADO
{
    internal class Menu
    {
        
        public string Configration()
        {
            var configuration = new ConfigurationBuilder().AddJsonFile("appsettings.json").Build();
            var constr = configuration.GetSection("constr").Value;
            return constr;
        }

        public DataTable DisconnectedMode(string constr)
        {
            SqlConnection conn = new SqlConnection(constr);
           
            SqlDataAdapter adapter = new SqlDataAdapter("SELECT * FROM Departments;", conn);
            DataTable dataTable = new DataTable();
            adapter.Fill(dataTable);
          

            return dataTable;
        }
        public void DisplayAllDepartment()
        {
            var constr = Configration();
            DataTable dataTable = DisconnectedMode(constr);

            Console.WriteLine("Dnum\tDname\tMGRSSN");
            Console.WriteLine("-----------------------------------------");
            foreach (DataRow item in dataTable.Rows)
            {
                Console.WriteLine($"{item["Dnum"]}\t{item["Dname"]}\t{item["MGRSSN"]}");
            }
        }

    

        public void DisplayDepartmentByNum(int num)
        {

            var constr = Configration();       
            DataTable dataTable = DisconnectedMode(constr);

            Console.WriteLine("Dnum\tDname\tMGRSSN\tMGRStart_Date");
            Console.WriteLine("-----------------------------------------");

            foreach (DataRow item in dataTable.Rows)
            {
                if ((int)item["Dnum"] == num)
                {
                    Console.WriteLine($"{item["Dnum"]}\t{item["Dname"]}\t{item["MGRSSN"]}\t{item["MGRStart Date"]}");
                }
            }
        }


    }
}
