using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using Task_1.Models;
using Task_1.ModelView;


namespace Task_1.Controllers
{
    public class DepartmentController : Controller
    {
        AppDbContext context = new AppDbContext();

        List<Department> departments()
        {
            return context.Department.Include(d => d.Employees).Include(d => d.Manager).ToList();
        }

        List<EmployeeBasicInfo> EmpNoSelectManager()
        {
            var employeesWithoutManagerRole = context.Employee
           .Where(e => !context.Department.Any(d => d.ManagerId == e.Id))
           .Select(e => new EmployeeBasicInfo
           {
               Id = e.Id,
               Name = e.Name
           })
           .ToList();

            return employeesWithoutManagerRole;
        }


        public IActionResult Index()
        {
            return View("Index", departments());
        }

        public IActionResult Add()
        {
            return View(EmpNoSelectManager());
        }

        public IActionResult SavaAdd(EmployeeBasicInfo emp) {
            
            if (emp.Name != null)
            {
                Department department = new Department();
                department.Name = emp.Name;
                department.ManagerId = emp.Id;
                context.Department.Add(department);
                context.SaveChanges();
            }
            return RedirectToAction("Index");
        }

        public IActionResult Delete(int id)
        {
            Department department = context.Department.Single(d => d.Id == id);
            context.Department.Remove(department);
            context.SaveChanges();
            return RedirectToAction("Index");
        }
       
        public IActionResult Edit(int id)
        {
            DepartmentEdit departmentEdit = new DepartmentEdit();
            Department department = context.Department.Include(d=>d.Employees)
                .Include(d=>d.Manager).Single(d => d.Id == id);

            departmentEdit.Name = department.Name;
            departmentEdit.ManagerName = department.Manager.Name;
            departmentEdit.ManagerId = department.ManagerId;
            departmentEdit.employeeBasicInfos = EmpNoSelectManager();
            departmentEdit.Id = id;

            return View(departmentEdit);
        }


        public IActionResult SavaEdit(DepartmentEdit department)
        {
            Department department1 = context.Department.FirstOrDefault(d => d.Id == department.Id );
            department1.Name = department.Name;
            department1.ManagerId = department.ManagerId;
            context.SaveChanges();
            return RedirectToAction("Index");  
        }

        public IActionResult Employees (int id)
        {

            var DepartmentWithEmployees = context.Department.Include(d => d.Employees).Single(d => d.Id == id);
            return View(DepartmentWithEmployees);
        }




    }
}
