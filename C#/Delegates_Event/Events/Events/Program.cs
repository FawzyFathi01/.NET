//Goal ===>  {✔,X}

//#1 DeterMaine Topics  
// [✔] Review Delegate  
// [✔] Events _ Observer Pattern
// [✔] EventHandler _ EventArgs

//#2 DeterMaine Resources (Piece of Cake Dev) + Chat Gpt 

//#3[]  توثيق على Github 


namespace Events
{
    internal class Program
    {
        static void Main(string[] args)
        {
            
           A_Sender.StartApp();

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

    delegate void DelSub(string title);
    class YouTube_Channel
    {

        public static void StartApp()
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

            // InVoke Direct this is ( X )
            y.del.Invoke("fawzy");

            // this is Problem (unSubscrib for old SubScriber !!) Not use = , but use += 
            y.del = (s) => Console.WriteLine("Happy");

            // To Solve this is Problem Add keyWord for Delegate (event) to issue 

        }

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

    #region Eevent_Handler

    // Review obServer Pattern 

    class VedioINFO : EventArgs
    {
        public string Title { set; get; }
        public int decuration { set; get; }
    }

    class A_Sender
    {

        public static void StartApp()
        {
            A_Sender sender = new A_Sender();
            B_Resever b_Resever = new B_Resever();
            B_Resever b_Resever1 = new B_Resever();

            b_Resever.subscribe(sender);
            b_Resever1.subscribe(sender);

            VedioINFO vd = new VedioINFO();

            Console.WriteLine("this is First Exampl ");
            Console.Write("Enter Name Sender : ");
            sender.Name = Console.ReadLine();

            Console.Write("Enter Title Vedio : ");
            vd.Title = Console.ReadLine();

            Console.Write("Enter decuration : ");
            vd.decuration = int.Parse(Console.ReadLine());

            sender.UploadVedio(vd);

        }

        // Methode to Invok Event 
        public string Name { set; get; }
        //public event Action<string> action;
        public event EventHandler<VedioINFO> handelUploadVedio; 

        public void UploadVedio (VedioINFO vd) {
            Console.WriteLine("Upload Vedio");
            //  action.Invoke(title);
           // vd.Title = "Fawzy"; vd.decuration = 30; this.Name = "Fawzy";
            handelUploadVedio(this,vd);
        }


    }

    class B_Resever
    {
        // To Receve Event 1-subscribe  2- hendelEvent  


        public void subscribe(A_Sender a)
        {
            // a.action += this.wathchVedio;
            a.handelUploadVedio += wathchVedio;
        }
        public void wathchVedio(object oj , VedioINFO vd)
        {
            A_Sender a = (A_Sender)oj;
            Console.WriteLine($"Watch this {vd.Title}\t , decuration {vd.decuration} from {a.Name}");
        }

    }


    #endregion

}
