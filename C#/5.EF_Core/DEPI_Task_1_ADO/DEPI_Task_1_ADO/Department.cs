using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DEPI_Task_1_ADO
{
    internal class Department
    {
        public int Dnum {  get; set; }
        public string Dname { get; set; }
        public int? MGRSSN { get; set; }
        public DateTime? MGRStart_Date { get; set; }


        public override string ToString()
        {
            return $"ID :- {Dnum}\t Name :- {Dname}\t MGRSSN :- {MGRSSN}\t StartDate :- {MGRStart_Date}";
        }
    }
}
