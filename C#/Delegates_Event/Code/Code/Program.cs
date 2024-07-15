namespace Code
{
    internal class Program
    {
        
        static void Main(string[] args)
        {
            AppDelegate.App();
           
        }

        #region Delegate
        //#introDaction Delegate 
        // delegate 
        // 1- Defenation 
        // 2- poining to Method
        // 3- Invoking

        //# Delegate inLine Anonmys Method ====> delegate (int a ,int b) {return a+b;} 
        //# Lampda Expration               ====> (int a,int b) => a+b

        // Delegate chains (MultiCasting)

        class AppDelegate
        {
            public static void App()
            {
                List<int> list = new List<int>() { 1, 10, 15, 40, 30, 70, 35, 20, 55, 80, 12, 100 };

                // Delegate poining & Invoking
                CheckEvenOdd ch = (a) => a % 2 != 0;
                Filter(list, ch);
                Console.WriteLine("#######################");
                // DelegateMultiCasting
                ch += (a) => a % 2 == 0;
                Filter(list, ch);
            }
        }



        // Delegate Defintion
        delegate bool CheckEvenOdd(int a);
        static void Filter (List<int> list , CheckEvenOdd ch)
        {
            foreach (var item in list)
            {
                if (ch(item))
                {
                    Console.WriteLine(item);
                }
            }
        }
        #endregion

    }
}
