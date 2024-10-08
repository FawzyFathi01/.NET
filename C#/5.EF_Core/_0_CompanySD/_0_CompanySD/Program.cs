namespace _0_CompanySD
{
    internal class Program
    {
        static void Main(string[] args)
        {
            using (var context = new AppDpContext())
            {
                foreach (var item in context.Departments)
                {
                    Console.WriteLine(item);
                }
            }
        }
    }
}
