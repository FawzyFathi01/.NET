using Day_1_mvc.Models;
using Microsoft.AspNetCore.Mvc;

namespace Day_1_mvc.Controllers
{

    public class StudentController : Controller
    {
        public IActionResult ShowAll()
        {
            StudentBL students = new StudentBL();
            List<Student> studentsList = students.GetAll();
            return View("ShowAllStudent",studentsList);
        }
    }

}
