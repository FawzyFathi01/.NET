using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LibraryBook
{
    internal class Customer : User
    {
        public List<Book> BookBorrow = new List<Book>();
        public Customer(string id, string pass) : base(id, pass)
        {

        }

        public void DisplayBooksBorrow()
        {
            Console.WriteLine("This is List Book Borrow :- ");
            if (BookBorrow.Count == 0) Console.WriteLine("Empty\n");
            foreach (var item in BookBorrow)
            {
                Console.WriteLine($"Id  : {item.Id}\tTitel : {item.Title}\tAuther : {item.Auther}\tYear : {item.Year}");
            }
        }


        public void BorrowBook(List<Book> books)
        {
            this.DisplayAllBookInLibrary(books);
            if (books.Count == 0)
            {
                return;
            }


            // may input is valied 

            Console.Write("Enter Id Book : ");
            int id = int.Parse(Console.ReadLine());

            foreach (var item in books)
            {
                if (item.Id == id)
                {
                    item.IsAvialble = false;
                    BookBorrow.Add(item);
                }

            }
            Console.WriteLine($"Successed Done Borrow Book with id ({id})");
        }

        public void ReturnBook(List<Book> books)
        {
            // Determine Book Return 
            this.DisplayBooksBorrow();
            if (BookBorrow.Count == 0) return;
            Console.Write("Enter ID Book To Return : ");
            int id = int.Parse(Console.ReadLine());


            // Handel find id in BorrowBook , Books 
            foreach (var item in BookBorrow)
            {
                if (item.Id == id)
                {
                    BookBorrow.Remove(item);
                    foreach (var item1 in books)
                    {
                        if (item1.Id == id)
                        {
                            item1.IsAvialble = true;
                            return;
                        }
                    }
                }
            }

            Console.WriteLine("InValid Input id Book !!");

        }





    }
}
