namespace _02_DelegateTask_1
{
    public class Program
    {

        public delegate string DelBook(Book book);
        static void Main(string[] args)
        {


            Book book = new Book("123", "Title_ABC", new string[] { "fawzy", "mohamed", "Ali", "mona" }, DateTime.Now, 200);

            // Title 
            Console.WriteLine(BookFunction.GetTitle(book) + "\n");

            // Authors 
            Console.WriteLine(BookFunction.GetAuthor(book));

            // Price 
            Console.WriteLine(BookFunction.GetPrice(book));


            // ----------------------------------------------------------------------------------------

            // 1- GetISBN Anonymous Method
            DelBook del = delegate (Book book) { return $"ISBN : {book.ISBN}"; };
            Console.WriteLine(del.Invoke(book));


            //2- PublicationDate [ Lambda Expression ] 
            DelBook Del = (b) => $"PublicationDate : {b.PublicationDate}";
            Console.WriteLine(Del.Invoke(book));


            // -----------------------------------------------------------------------------------------

            // # Filter Book , Price > 300 , use Generic delegate [Predicate]
            List<Book> Books = new List<Book>()
            {
                new Book("101", "Title_1", new string[] { "fawzy", "mohamed"}, DateTime.Now, 200),
                new Book("102", "Title_2", new string[] { "mostafa", "fawzy"}, DateTime.Now, 250),
                new Book("103", "Title_3", new string[] { "ahmed", "ali"}, DateTime.Now, 300),
                new Book("104", "Title_4", new string[] { "eman", "alaa"}, DateTime.Now, 350),
                new Book("105", "Title_5", new string[] { "sohaila", "emad"}, DateTime.Now, 400),
                new Book("106", "Title_6", new string[] { "shrouk", "fathi" }, DateTime.Now, 450),
                new Book("107", "Title_7", new string[] { "maged", "amged"}, DateTime.Now, 500),
                new Book("108", "Title_8", new string[] { "mahmoud", "khaled"}, DateTime.Now, 200),
            };


            Predicate<Book> PreBook = (b) => b.Price > 300;
            LibraryEngine.ProcessBooks(Books, PreBook);





        }
    }


    public class Book
    {
        public string ISBN { get; set; }
        public string Title { get; set; }
        public string[] Authors { get; set; }

        public DateTime PublicationDate { get; set; }

        public decimal Price { get; set; }



        public Book(string ISBN, string Title, string[] Authors, DateTime PubDate, decimal Price)
        {
            this.ISBN = ISBN;
            this.Title = Title;
            this.Authors = Authors;
            this.PublicationDate = PubDate;
            this.Price = Price;
        }

        public override string ToString()
        {
            string authors = "";
            foreach (var item in this.Authors)
            {
                authors += (item + " ");
            }
            return $"ISBN : {this.ISBN} \nTitle : {this.Title}\nAuthors : " +
           $"{authors} \nPublicationDate : {this.PublicationDate} \nPrice : {this.Price}\n";
        }
    }

    public class BookFunction
    {
        public static string GetTitle(Book book)
        {

            return $"Title : {book.Title}";

        }

        public static string GetAuthor(Book book)
        {
            string authors = "Authors : \n";
            foreach (var item in book.Authors)
            {
                authors += (item + "\n");
            }

            return authors;
        }


        public static string GetPrice(Book book)
        {
            return $"Price : {book.Price}";
        }
    }

    public class LibraryEngine
    {
        public static void ProcessBooks(List<Book> books, Predicate<Book> Pre)
        {
            foreach (var item in books)
            {
                if (Pre(item))
                {
                    Console.WriteLine($"ISBN : {item.ISBN} \nTitle : {item.Title}\nAuthors : " +
           $"{item.Authors[0]} , {item.Authors[1]} \nPublicationDate : {item.PublicationDate} \nPrice : {item.Price}\n");
                }
            }
        }

    }
}
