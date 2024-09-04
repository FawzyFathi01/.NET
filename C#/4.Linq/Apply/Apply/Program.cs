using Shared;
namespace Apply
{
    internal class Program
    {
        static List<Employee> emps = (List<Employee>) Repository.LoadEmployees();
        static List<Department> deprts = (List<Department>)Repository.LoadDepartment();

        static void Main(string[] args)
        {
            Group_by_Department();



        }
    

        static void Group_by_Department()
        {
            var res = emps.GroupBy(d => d.DepartmentId);

            foreach (var item in res)
            {
                //Console.WriteLine(item.Key);
                //foreach (var item1 in item)
                //{
                //    Console.WriteLine(item1.FullName);
                //}

                item.Print($"Depart ({item.Key})");

            }

        }







    }
}
