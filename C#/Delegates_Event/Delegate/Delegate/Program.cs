﻿//Goal ===>  {✔,X}

// حدد الاجزاء اللى هتذاكرها 
// حدد مصادر التعلم و مكان الملاحظات
// ذاكر فترات قصيرة و قست من الراحة 
// ابتعد عن المشتتات تذكر اهمية الوقت 


//#1 
//  1 - [✔] Review Delegate + PlayCode 
//  2 - [] IMprove Delegate 
//  3 - [] Event 
//  4 - [] توثيق الملاحظات على GITHUB 


//#2 مصادر التعلم 
// 1- عصام - المهدى - Piece - ChatGpt 

namespace Delegate
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // AppDelegate.FilterEmp();

            Action<int, int> del = (a, b) => Console.WriteLine($"RES : {a + b}");
            del(10, 4);

        }
        #region Delegate
        //#introDaction Delegate 
        // delegate :- Object than points to Method ai changed at run time  
        // 1- Defenation 
        // 2- poining to Method
        // 3- Invoking

        //# Delegate inLine Anonmys Method ====> delegate (int a ,int b) {return a+b;} 
        //# Lampda Expration               ====> (int a,int b) => a+b

        // Delegate chains (MultiCasting)

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
                //CheckEvenOdd ch = (a) => a % 2 != 0;
                Func<int, bool> CheckEvenOdd = (a) => a % 2 == 0;
                // Invoking
                FilterList(list, CheckEvenOdd);
                Console.WriteLine("#######################");
                // DelegateMultiCasting
                CheckEvenOdd += (a) => a % 2 == 0;
                FilterList(list, CheckEvenOdd);
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



        static void FilterList(List<int> list, Func<int, bool> ch)
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
}
