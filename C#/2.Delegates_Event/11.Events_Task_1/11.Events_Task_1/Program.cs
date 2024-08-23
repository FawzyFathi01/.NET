namespace _11.Events_Task_1
{
    internal class Program
    {
        public static int cnt = 1;
        public static List<Car> Cars = new List<Car>() {
            new Car(){Name = "Bentley", Num = 1001},
            new Car(){Name = "Lamborghini", Num = 1002},
            new Car(){Name = "Ferrari", Num = 1003},
            new Car(){Name = "Mercedes", Num = 1004}
        };
        static void Main(string[] args)
        {
            Console.WriteLine("Enter Num of Sacend");
            int s = int.Parse(Console.ReadLine());
            TimerCallback timerCallback = HandelerEvent;
            Timers.StartTime(s, timerCallback);

           
        }

        public static void HandelerEvent(object state)
        {
            
            switch (cnt)
            {
                case 1:
                    Console.ForegroundColor = ConsoleColor.Red;
                    Screen.Light();
                    foreach (var item in Cars)
                    {
                        item.Stop();
                    }
                    break;

                case 2:
                    Console.ForegroundColor = ConsoleColor.Yellow;
                    Screen.Light();
                    foreach (var item in Cars)
                    {
                        item.Ready();
                    }
                    break;

                case 3:
                    Console.ForegroundColor = ConsoleColor.Green;
                    Screen.Light();
                    foreach (var item in Cars)
                    {
                        item.Move();
                    }
                    break;
            }
            Console.ResetColor();
            cnt++;
            if (cnt == 4) cnt = 1;
        }


    }

    public class Timers
    {
        public static void StartTime(int s , TimerCallback callback)
        {
            s = s * 1000;
            Timer time = new Timer(callback,null, 0, s);
            Console.ReadLine();
        }
    }

    public class Screen
    {
        public static void Light()
        {
            Console.WriteLine("■■■■\n■■■■");
        }
    } 


    public class Car
    {
        public string Name { get; set; }
        public int Num { get; set; }
        public  void Move()
        {
            Console.WriteLine($"{Name}, {Num} .....Moving!!");
        }
        public void Ready()
        {
            Console.WriteLine($"{Name}, {Num} .....Ready!!");
        }
        public void Stop()
        {
            Console.WriteLine($"{Name}, {Num} .....Stop!!");
        }
    }







}
