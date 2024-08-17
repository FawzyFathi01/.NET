namespace Collection
{
    internal class Program
    {
        static void Main(string[] args)
        {







        }
    }

    public interface IABC <T,U>
    {
        public void print(T str);
    }

    public class DEF<T,U> : IABC<T,U>
    {
        public U data { set; get; }
        public void print(T str)
        {
            Console.WriteLine($"{data}\t{str}");
        }
    }





}
