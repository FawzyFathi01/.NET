using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _0_CompanySD
{
    internal class Departments
    {
        [Key]
        public int DNum {  get; set; }
        public string? DName { get; set; }

        public int? MGRSSN { get; set; }

        [Column("MGRStart Date")]
        public DateTime? MGRStart_Date { get; set; }


        public override string ToString()
        {
            return $"{DNum}, {DName ?? "No Name"}, " +
                $"Manager ID: {(MGRSSN.HasValue ? MGRSSN : "No manager assigned")}, " +
                $"StartDate : {(MGRStart_Date.HasValue? MGRStart_Date : "No Data")}";
        }

    }
}
