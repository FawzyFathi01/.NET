using System.ComponentModel.DataAnnotations;

namespace Day_2_MVC_App01.Models
{
    public class Department
    {
        [Key]
        public int Id { get; set; }
        public string Name { get; set; }

        public List<Employee> Employees { get; set; }
    }
}
