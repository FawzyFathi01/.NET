using Day_2_MVC_App01.Models;
using Microsoft.AspNetCore.Mvc;

namespace Day_2_MVC_App01.Controllers
{
    public class DepartmentController : Controller
    {
        ITIMVCContext context = new ITIMVCContext();
        public IActionResult Index()
        {
            List<Department> Departmentlist = context.Department.ToList();
            return View("Index", Departmentlist);
        }

        public IActionResult Add()
        {
            return View("Add");
        }

        // /Department/SaveAdd/name=??

        public IActionResult SaveAdd(Department department)
        {
            if(department.Name != null)
            {
                context.Department.Add(department);
                context.SaveChanges();
            }
            return View("Add");
        }
    }
}
