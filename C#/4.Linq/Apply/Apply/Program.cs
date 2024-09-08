using Shared;
namespace Apply
{
    internal class Program
    {
        static List<Employee> emps = (List<Employee>) Repository.LoadEmployees();
        static List<Department> deprts = (List<Department>)Repository.LoadDepartment();

        static void Main(string[] args)
        {
            // Group_by_Department();
            //Basic_Inner_Join();
            // Group_and_Count();
            //Join_with_Filtering();
            // Group_and_Sum();
            Join_Multiple_Conditions();

        

        }


        static void Group_by_Department()
        {
            var res = emps.GroupBy(d => d.DepartmentId);
            foreach (var item in res)
            {
                item.Print($"Depart ({item.Key})");
            }
        }


        static void Basic_Inner_Join()
        {
            var res = emps.Join(deprts, e => e.DepartmentId, d => d.Id,
                (e, d) => new InfoFullEmp_NameDepartment { FullName = e.FullName, DpartName = d.Name });

            foreach (var item in res)
            {
                Console.WriteLine($"FullName : {item.FullName}\tDepartName : {item.DpartName}");
            }

        }

        static void Group_and_Count ()
        {
            var res = emps.GroupBy(d => d.DepartmentId);
            foreach (var item in res)
            {
                Console.WriteLine($"{item.Key} : {item.Count()}");
            }
        }

        static void Join_with_Filtering()
        {
            // Quary Syntax 
            //var res = from e in emps
            //          join d in deprts
            //          on e.DepartmentId equals d.Id
            //          where e.HasHealthInsurance == true
            //          select new
            //          {
            //              EmpFullName = e.FullName,
            //              DepartName = d.Name
            //          };

            //foreach (var item in res)
            //{
            //    Console.WriteLine($"FullNameEmp : {item.EmpFullName}\t Department : {item.DepartName}");
            //}


            // Method Syntax 
            var res02 = emps.Where(e => e.HasHealthInsurance)
                .Join(deprts, e => e.DepartmentId, d => d.Id, (e, d) => new
                {
                    FullName = e.FullName,
                    DepartName = d.Name
                });

            foreach (var item in res02)
            {
                Console.WriteLine($"FullNameEmp : {item.FullName}\t Department : {item.DepartName}");
            }

        }

        static void Group_and_Sum()
        {
            // Method 
            var res = emps.GroupBy(d => d.DepartmentId).Join(deprts,e => e.Key,d => d.Id,( e, d ) => new
                {
                totalSalary = e.Sum( e => e.Salary),
                DepartName = d.Name,
                DepartId = d.Id
                });


            foreach (var item in res)
            {
                Console.WriteLine($"DepartmentId : ( {item.DepartId} ) Have Total Salary : " +
                    $"({item.totalSalary}), DepartName : ({item.DepartName})");
            }

            // Quary 
            //var res01 = from e in emps
            //            group e by e.DepartmentId into empgroup
            //            join d in deprts
            //            on empgroup.Key equals d.Id
            //            select new
            //            {
            //                TotalSalary = empgroup.Sum(e => e.Salary),
            //                DepartmentName = d.Name
            //            };

            //foreach (var item in res01)
            //{
            //    Console.WriteLine($"TotalSalary : ({item.TotalSalary}) " +
            //        $"DepartName : ({item.DepartmentName})");
            //}

        }

        static void Join_Multiple_Conditions()
        {
            var res = emps.Join(deprts, e => e.DepartmentId, d => d.Id,(e , d) => new
            {
                FullNameEmp = e.FullName,
                HasPensionPlan01 = e.HasPensionPlan,
                DepartmentName = d.Name
            }).Where( (ed) => ed.HasPensionPlan01 == true && ed.DepartmentName == "FINANCE");

            foreach (var item in res)
            {
                Console.WriteLine($"EmpName : ( {item.FullNameEmp} ), DepartName : ( {item.DepartmentName} )");
            }



        }






    }
}
