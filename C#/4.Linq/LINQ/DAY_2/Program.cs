using DAY_1;

namespace DAY_2
{
    internal class Program
    {
        static void Main(string[] args)
        {
            
            List<Emp> emps = new List<Emp>() {
             new Emp(){Name = "Fawzy" , Id = 1 , Salary = 16000},
             new Emp(){Name = "Mohamed" , Id = 2 , Salary = 12000},
             new Emp(){Name = "Ali" , Id = 2 , Salary = 8000},
             new Emp(){Name = "Hany" , Id = 3 , Salary = 10000},
             new Emp(){Name = "Shrouk" , Id = 3 , Salary = 14000},
             new Emp(){Name = "Sohaila" , Id = 3 , Salary = 7000},
             new Emp(){Name = "mona" , Id = 4 , Salary = 7000},
             new Emp(){Name = "Eman" , Id = 4 , Salary = 8000},
             };


            var res = emps.Where(e => e.Salary > 1000);
            var res01 = emps.OrderBy(e => e.Salary ).ThenByDescending( e => e.Id );
            emps.Reverse();
            var res02 = emps.Skip(2).OrderBy(e => e.Salary);
            var res03 = emps.OrderBy(e => e.Salary).Chunk(3);
            var res04 = emps.OrderBy(e => e.Id).ThenBy(e => e.Salary).GroupBy(e => e.Id);

            foreach (var item in res04)
            {
                Console.WriteLine($"Id : {item.Key}");

                foreach (var item1 in item)
                {
                    Console.WriteLine($"Name : {item1.Name}\tID : {item1.Id}\tSalary : {item1.Salary}");
                }
            }







            //int cnt = 1;
            //foreach (var item in res03)
            //{
            //    Console.WriteLine($"Chunk ({cnt++})");
            //    foreach (var item1 in item)
            //    {
            //        Console.WriteLine($"Name : {item1.Name}\tID : {item1.Id}\tSalary : {item1.Salary}");
            //    }
            //}




            /*
            List<int> Ints = new List<int>() { 1,2,3,4,5,6,7,8,9,10};

            var evenNumber = Ints.Where(i => i % 2 == 0);

            Ints.Add(11);
            Ints.Add(12);
            Ints.Add(13);
            Ints.Remove(4);
            Ints.Add(14);
            Ints.Add(15);
            Ints.Add(16);

            foreach (var item in evenNumber)
            {
                Console.Write($"{item}, ");
            }
            */







        }
    }
}
