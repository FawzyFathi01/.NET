//Goal ===>  {✔,X}

// Notes 
// - KeyWord event to solve 1- Direct Invoke outside class 2- Not use = but use += or -= 
// - EventHandler --> Generic , Non Generic 
//      - Non Generic --> (object , EventArgs )
//      - Generic --> (object , T) :- T : anyTypes 
// Event :- enable a class or object to notify other Classes or objects when somthing of interest occurs 




namespace Events
{
    internal class Program
    {
        static void Main(string[] args)
        {
            AppStock app = new AppStock();
            app.StartApp();
        }
    }



    #region Review_Delegate 

    /**
     * 
     * ## Improve Delegate
     *    
     *    #1
     *    - (Define Delegate same Signature method to point it)
     *    - Poining to Method 
     *    - Invoke Delegate 
     *              
     *    #2 
     *    - Delegate InLine Anonmys Mathod (delegate) (int a, int b) {return a+b;}
     *    - Lampda Expretion => , (a,b) => a+b;
     *              
     *    #3 
     *    - Multicasting 
     *    Del del = Add , del += Subtract
     *              
     *    #4
     *    Generic Delegate 
     *    - delegate void DelCal<T>(T a, T b); , DelCal<int> del = (a, b) => Console.WriteLine(a + b);
     *    - Func <in,in,..,out> / Action <in,in,...> return void / Predicate <in , in ,..> return bool
     * 
     */

    #endregion

    #region Observer_Pattern


    class AppYouTube()
    {
        public void StartApp()
        {
            Console.WriteLine("this is Example 1 ");
            YouTube_Channel ch = new YouTube_Channel();
            Subscriber s1 = new Subscriber();
            Subscriber s2 = new Subscriber();
            Subscriber s3 = new Subscriber();

            s1.Subscribe(ch);
            s2.Subscribe(ch);
            s3.Subscribe(ch);
            Console.Write("Enter Title Video : ");
            ch.UploadVideo(Console.ReadLine());


            Console.WriteLine("this is Example 2 ");
            YouTube_Channel y = new YouTube_Channel();
            Subscriber s_1 = new Subscriber();
            Subscriber s_2 = new Subscriber();
            Subscriber s_3 = new Subscriber();

            s_1.Subscribe(y);
            s_2.Subscribe(y);
            s_3.Subscribe(y);

            // Notes 
            /*
            // InVoke Direct this is ( X )
            //y.del.Invoke("fawzy");

            //this is Problem (unSubscrib for old SubScriber !!) Not use = , but use += 
            //y.del = (s) => Console.WriteLine("Happy");

            // To Solve this is Problem Add keyWord for Delegate (event) to issue 
            */
        }
    }
    class YouTube_Channel
    { 
        // Method to Uploud Video , Delegate to poining Subscriber 
        // public event DelSub del;
        public event Action<string> del;
        // To Solve 2 Problem 1- Not Invok Direct out Class , Not = , but += 
        
        public void UploadVideo (string title) {
            Console.WriteLine($"Upload Video ( {title} )");
            del.Invoke(title);
        } 
    }

    class Subscriber
    {
        // Method to Watch Video upload 

        public int Id { get;}
        static int count = 0;

        public Subscriber() { count++; Id = count; }

        public void Subscribe(YouTube_Channel chanel) {
            chanel.del += this.WatchVideo;
        }
        public void WatchVideo (string title) {
            Console.WriteLine($"Id {Id}, Iam Watch Video ( {title} ) ");
        }

    }

    #endregion


    //Event_handeler 

    #region Example_1_Review 
    class Vedio_Infos : EventArgs
    {
        public string Name { set; get; }
        public int dcuration { set; get; }
    }

    class YoutubeChannel
    {
        public string Name { set; get; }
        public event EventHandler<Vedio_Infos> Action;
     
        // Event To Solve 1-invoke outSide class 2-Not = but use += or -= 
        
        
        public void UploadVideo(Vedio_Infos vd)
        {
            vd.Name = "Fawzy";
            vd.dcuration = 30;
            Console.WriteLine("Upload Video !!");
            Action(this, vd);
        }


    }

    class SubscriberX
    {
        public void Subscribe(YoutubeChannel y)
        {
            y.Action += this.WatchVedio;   
        }

        public void WatchVedio(object ob , Vedio_Infos vd)
        {
            YoutubeChannel y = (YoutubeChannel)ob;  
            Console.WriteLine($"i am Watch : {vd.Name}\t,{vd.dcuration}");
        }
    }
    #endregion

    #region Example_2_Stock 

    class AppStock
    {
        public void StartApp()
        {
            Stock st = new Stock("Google");
            HandelStock hs = new HandelStock();
            hs.Subscribe(st);

            Console.Write("Enter Price of Stock : ");
            st.Price = decimal.Parse(Console.ReadLine());

            int t = 4;
            while (t > 0)
            {
                Console.Write("Enter percent to change StockPrice : ");
                decimal a = decimal.Parse(Console.ReadLine());
                st.ChangePrice(a);
                t--;
                Console.WriteLine();
            }
            Console.WriteLine("Finished");

            Console.ReadKey();
        }

    }

    class HandelStock
    {

        public void Subscribe (Stock st)
        {
            st.EventHandelerChangeStockPrice += HandelChangePrice;
        }
        public void HandelChangePrice(object st, decimal oldPrice)
        {
            Stock stock = (Stock)st;
            Console.WriteLine($"Welecom To Stock {stock.Name}");
            Console.WriteLine($"Price of Stock Before Change :- ${oldPrice}");
            Console.Write($"Price of Stock After Change :- $");


            if (stock.Price > oldPrice) Console.ForegroundColor = ConsoleColor.Green;
            else if (stock.Price < oldPrice) Console.ForegroundColor = ConsoleColor.Red;
            else Console.ForegroundColor = ConsoleColor.Gray;


            Console.WriteLine(stock.Price);
            Console.ForegroundColor = ConsoleColor.White;

        }
    }

    class Stock
    {
        private string name;
        private decimal price;

        public event EventHandler<decimal> EventHandelerChangeStockPrice;
        public decimal Price { set { price = value; } get { return price; } }
        public string Name { get => name; }

        public Stock (string name)
        {
            this.name=name;
        }



        public void ChangePrice(decimal percent)
        {
            decimal oldprice = price;
            Console.WriteLine($"old : {oldprice}");
            this.price += (this.Price * percent);
            EventHandelerChangeStockPrice(this, oldprice);
        }


    }

    #endregion




}
