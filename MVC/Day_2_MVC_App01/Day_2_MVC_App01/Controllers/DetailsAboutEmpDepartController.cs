using Day_2_MVC_App01.Models;
using Day_2_MVC_App01.ViewModel;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;

namespace Day_2_MVC_App01.Controllers
{
    public class DetailsAboutEmpDepartController : Controller
    {
        ITIMVCContext context = new ITIMVCContext();
        public IActionResult Details(int id )
        {
            Employee employee = context.Employee.Include(e => e.Department)
                .Single(e => e.Id == id);
            
            DetailsDepartmentEmployee detailsDepartmentEmployee = new DetailsDepartmentEmployee();
            detailsDepartmentEmployee.EmployeeID = employee.Id;
            detailsDepartmentEmployee.Salary = employee.Salary;
            detailsDepartmentEmployee.DepartName = employee.Department.Name;
            detailsDepartmentEmployee.EmployeeName = employee.Name;
            detailsDepartmentEmployee.EmployeeAge = employee.Age;

            return View("Details",detailsDepartmentEmployee);
        }
    }
}
