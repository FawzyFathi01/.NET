/*
 * 
 * What is a Delegate?
 * A delegate is a type that defines a method signature, and it can hold a reference to a method 
 * with that signature. Delegates are similar to function pointers in C and C++, but they are type-safe and secure.
 *
 * Key Characteristics of Delegates
 * Type Safety: Delegates are type-safe, meaning the method signature must match the delegate signature.
 * Flexibility: Delegates can point to both static and instance methods.
 * Chainable: Multiple methods can be assigned to a delegate, creating a chain of methods.
 * 
 * delegate :- Object than points to Method ai changed at run time  
 *     1- Identfied Delegate  
 *     2- poining to Method
 *     3- Invoking Delegate 
 *
 *   # Delegate inLine Anonmys Method ====> delegate (int a ,int b) {return a+b;} 
 *   # Lampda Expration               ====> (int a,int b) => a+b
 *
 *   # Delegate chains (MultiCasting)
 *   # Generic Delegate 
 *   - Func <in,in...,out> return any data type  , Action<in,in....>return void , Predicate <in,in,....> return bool
 *
 */

namespace Delegate
{

   

    internal class Program
    {

        public delegate bool DPredicate(Emp e);
        

        static void Main(string[] args)
        {

            List<Emp> emps = new List<Emp>() { 
            new Emp(){Id =  1, Name = "mohamed", Age = 32, Salary = 9000},
            new Emp(){Id =  2, Name = "fawzy", Age = 24, Salary = 6000},
            new Emp(){Id =  3, Name = "Ali", Age = 20, Salary = 3000},
            new Emp(){Id =  4, Name = "Mosatafa", Age = 29, Salary = 7000},
            new Emp(){Id =  5, Name = "yasser", Age = 28, Salary = 7000},
            new Emp(){Id =  6, Name = "khaled", Age = 22, Salary = 3000},
            new Emp(){Id =  7, Name = "mona", Age = 25, Salary = 6000},
            new Emp(){Id =  8, Name = "nada", Age = 30, Salary = 8000},
            };

            // =>> emp.salary > 6000  --- return bool Predicate 
            // =>> emp.age > 25       --- return bool Predicate 
            //  FilterEmp(emps, (e) => e.Salary > 7000);

            Predicate<Emp> Pre = (e) => e.Salary > 6000;
            //Pre += (e) => e.Salary > 7000;
            FilterEmp(emps, Pre);



        }
     
     
        public static void FilterEmp (List<Emp> emps ,Predicate<Emp> pre)
        {
            foreach (var item in emps)
            {
                if ( pre(item) ) {
                    Console.WriteLine($"Id : {item.Id}\tName : {item.Name}\tAge : {item.Age}\tSalary : {item.Salary}");
                }
            }
        }












        #region Delegate
        class AppDelegate
        {
            public static void BasicDelegate()
            {
                // poining 
                Del del = (a, b) => Console.WriteLine($"RES : {a + b}");
                // Invoking 
                del(1, 2);
            }
            public static void AppFilterBasic()
            {
                List<int> list = new List<int>() { 1, 10, 15, 40, 30, 70, 35, 20, 55, 80, 12, 100 };

                // Delegate poining
                //CheckEvenOdd ch = (a) => a % 2 != 0;                // Require Define Delegate 
                //Func<int, bool> CheckEvenOdd = (a) => a % 2 == 0;  // Return any Data type 
                Predicate<int> PredicateCheck = (a) => a % 2 == 0;  // Return Bool only 
                // Invoking
                FilterList(list, PredicateCheck);
                Console.WriteLine("#######################");
                // DelegateMultiCasting
                PredicateCheck += (a) => a % 2 == 0;
                FilterList(list, PredicateCheck);
            }

            public static void FilterEmp()
            {
                List<Employee> employees = new List<Employee>() {
                     new Employee(1,"fawzy1",20,2000),
                     new Employee(2,"fawzy2",21,4000),
                     new Employee(3,"fawzy3",22,8000),
                     new Employee(4,"fawzy4",23,12000),
                     new Employee(5,"fawzy5",24,14000),
                     new Employee(6,"fawzy6",25,20000),
                     new Employee(7,"fawzy7",26,25000),
                };

                FilterEmpolyee(employees, e => e.Age >= 24);
                Console.WriteLine("############################");
                FilterEmpolyee(employees, e => e.Salary >= 12000);
                Console.WriteLine("############################");
                FilterEmpolyee(employees, e => e.Id >= 5);
            }

            public static void GnericDelebate()
            {
                DelCal<int> del = (a, b) => Console.WriteLine($"RES : {a + b}");
                del.Invoke(10, 7);
            }

        }

        // Defintion Delegate 
        delegate void Del(int a, int b);

        // Delegate Defintion
        delegate bool CheckEvenOdd(int a);

        // Delegate Defintion
        delegate bool CheckEmp(Employee emp);

        // Generic Delegate 
        delegate void DelCal<T>(T a, T b);



        static void FilterList(List<int> list, Predicate<int> ch)
        {
            foreach (var item in list)
            {
                if (ch(item))
                {
                    Console.WriteLine(item);
                }
            }
        }



        static void FilterEmpolyee(List<Employee> emp, CheckEmp chemp)
        {
            foreach (var item in emp)
            {
                if (chemp(item))
                {
                    Console.WriteLine($"ID : {item.Id}, Name : {item.Name}, Age : {item.Age}, Salary : {item.Salary}");
                }
            }
        }

        class Employee
        {
            public int Id { get; set; }
            public string Name { get; set; }

            public int Age { get; set; }

            public int Salary { get; set; }

            public Employee(int id, string name, int age, int salary)
            {
                Id = id;
                Name = name;
                Age = age;
                Salary = salary;
            }

        }

        #endregion

    }



    // class emp 


    public class Emp
    {
        public int Id { get; set; }
        public string Name { get; set; }

        public int Age { get; set; }
        public int Salary { get; set;}
    }


}
