using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Task_1.Models
{
    public class Department
    {
        [Key]
        public int Id { get; set; }
        public string Name { get; set; }
        [ForeignKey("Manager")]
        public int? ManagerId { get; set; }
        public Employee Manager { get; set; }
        public List<Employee> Employees {  get; set; }
    }
}
