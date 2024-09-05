using Shared;
namespace Apply
{
    internal class Program
    {
        static List<Employee> emps = (List<Employee>) Repository.LoadEmployees();
        static List<Department> deprts = (List<Department>)Repository.LoadDepartment();

        static void Main(string[] args)
        {
            //Group_by_Department();
            Basic_Inner_Join();


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
                (e, d) => new EmpDeprtInfo { FullName = e.FullName, DpartName = d.Name });

            foreach (var item in res)
            {
                Console.WriteLine($"FullName : {item.FullName}\tDepartName : {item.DpartName}");
            }

        }










    }
}
