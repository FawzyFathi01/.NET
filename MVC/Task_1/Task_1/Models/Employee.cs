using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Task_1.Models
{
    // Add Proparty Image , DataNow 
    public class Employee
    {
        [Key]
        public int Id { get; set; } 
        public string Name { get; set; }    
        public int Age { get; set; }
        public int Salary { get; set; }
        public string JobTitle { get; set; }
        public string City { get; set; }
        
        [ForeignKey("Department")]        
        public int? DeptID { get; set; }
        public Department Department { get; set; }

    }
}
