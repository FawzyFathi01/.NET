using System.Collections;

namespace DAY_1
{
    internal class Program
    {


        static void Main(string[] args)
        {

            List<Emp> emps = new List<Emp>() {
             new Emp(){Name = "Fawzy" , Id = 1 , Salary = 16000},
             new Emp(){Name = "Mohamed" , Id = 2 , Salary = 12000},
             new Emp(){Name = "Ali" , Id = 3 , Salary = 8000},
             new Emp(){Name = "Hany" , Id = 4 , Salary = 10000},
             new Emp(){Name = "Shrouk" , Id = 5 , Salary = 14000},
             new Emp(){Name = "Sohaila" , Id = 6 , Salary = 7000},
             };

            emps.Filter(e => e.Salary > 10000);

        }

        #region Pure Vs. Impure Function

        static List<int> nums = new List<int>() { 1, 2, 3, 4, 5 };
        static void Add_1(int x)
        {
            nums.Add(x);
        }

        static void Add_2()
        {
            nums.Add(new Random().Next());
        }

        static List<int> Add_3(List<int> numbers, int x)
        {
            var res = new List<int>(numbers);
            res.Add(x);
            return res;
        }

        #endregion

    }

    #region IEnumerable _ IEnumerator


    public class MyCOllection : IEnumerable
    {

        private int[] Ints = new int[] { 1, 2, 3, 4, 5, 6, 7, 8, 9 };

        public IEnumerator GetEnumerator()
        {
            return new MyCollectionIEnumerator(Ints);
        }

    }

    public class MyCollectionIEnumerator : IEnumerator
    {

        private int pos = -1;
        private int[] list;

        public MyCollectionIEnumerator(int[] items)
        {
            list = items;
        }
        public object Current => list[pos];

        public bool MoveNext()
        {
            pos++;
            return (pos < list.Length);
        }

        public void Reset()
        {
            pos = -1;
        }
    }

    #endregion

    #region Extension Methods

    public static class UpgradeString
    {
        public static void PrintFawzy(this string str)
        {
            Console.WriteLine($"Welcom Fawzy, {str}");
        }
    }



    #endregion


    #region Review Delegate Filter 

    public class Emp
    {
        public string Name { get; set; }
        public int Salary { get; set; }
        public int Id {  get; set; }
    }

    public static class Ex_IEnumerable
    {
        public static void Filter(this IEnumerable<Emp> emps , Func<Emp,bool> predicate )
        {
            foreach (var item in emps)
            {
                if (predicate(item))
                {
                    Console.WriteLine($"Name : {item.Name}\tID : {item.Id}\tSalary : {item.Salary}");
                }
            }
        }
    }




    #endregion


}

