using Task_1.Models;

namespace Task_1.ModelView
{
    public class DepartmentEdit
    {
        public int Id { get; set; }
        public string Name { get; set; }    
        public int? ManagerId { get; set; }

        public string ManagerName { get; set; }

        public List<EmployeeBasicInfo> employeeBasicInfos { get; set; }


    }
}
