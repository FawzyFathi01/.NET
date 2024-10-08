using Day_2_MVC_App01.Models;
using Microsoft.AspNetCore.Mvc;

namespace Day_2_MVC_App01.Controllers
{
    // /Bind/Test?id=12&name=Fawzy
    public class BindController : Controller
    {
        // [ /Bind/TestPrimtive?age=23&id=1&name=fawzy ] 
        public IActionResult TestPrimtive(int id, string name,int age)
        {
            return Content($"Id : {id}, Name : {name}, Age : {age}");
        }

        // [ /Bind/TestClass?id=4&name=fawzy ] 
        public IActionResult TestClass(Department department)
        {
            return Content($"Department!!\n" +
                $"Id : {department.Id}, Name : {department.Name}");
        }

        // [  /Bind/TestDic/dic[1]=fawzy&dic[2]=mostafa  ]
        public IActionResult TestDic(Dictionary<int,string> dic)
        {
            return Content($"OK");
        }

    }
}
