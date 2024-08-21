using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Channels;
using System.Threading.Tasks;

namespace LibraryBook
{
    internal class Librarian : User
    {

        public Librarian(string id, string pass) : base(id, pass) { }
        public void DisplayBooksBorrowIN(List<Book> books)
        {

            Console.WriteLine("This is List BookS Borrow :- ");
            foreach (var item in books)
            {
                if (item.IsAvialble == false)
                {
                    Console.WriteLine($"Id  : {item.Id}\tTitel : {item.Title}\tAuther : {item.Auther}\tYear : {item.Year}");
                }
            }

        }

        public Book AddBook()
        {
            Console.Write("Enter Id Book : ");
            int id = int.Parse(Console.ReadLine());
            Console.Write("Enter Titel Book : ");
            string Title = Console.ReadLine();
            Console.Write("Enter Auther Book : ");
            string Auther = Console.ReadLine();
            Console.Write("Enter Year Book : ");
            int year = int.Parse(Console.ReadLine());
            bool IsAvialble = true;
            Book newbook = new Book()
            {
                Id = id,
                Title = Title,
                Year = year,
                IsAvialble = IsAvialble,
                Auther = Auther,
            };
            Console.WriteLine("Successed Add Book ");
            return newbook;
        }

        public void RemoveBook(List<Book> books)
        {
            if (books.Count == 0)
            {
                Console.WriteLine("Empty Book ");
                return;
            }

            this.DisplayAllBookInLibrary(books);
            Console.Write("Enter ID Book : ");
            int idCheck = int.Parse(Console.ReadLine());
            int idx = 0;
            foreach (var item in books)
            {

                if (item.Id == idCheck)
                {
                    break;
                }
                idx++;
            }
            books.RemoveAt(idx);

            Console.WriteLine("Successed Remove");
            this.DisplayAllBookInLibrary(books);

        }

        public void DispayCustomer(List<Customer> customers)
        {
            Console.WriteLine("this is list of Customer :- ");
            if (customers.Count == 0)
            {
                Console.WriteLine("Empty List");
                return;
            }
            int cnt = 1;
            foreach (var item in customers)
            {
                Console.WriteLine($"customer ( {cnt++} ) : ID - {item.Id} , Pass - {item.PassWord}");
                if (item.BookBorrow.Count == 0) Console.WriteLine($"Not Borrow Book For Customer :- {item.Id}");
                else
                {
                    Console.WriteLine($"this is List of Borrow Book for Customer :- {item.Id}");
                    foreach (var j in item.BookBorrow)
                    {
                        Console.WriteLine($"Id  : {j.Id}\tTitel : {j.Title}\tAuther : {j.Auther}\tYear : {j.Year}");
                    }
                }
            }
        }

    }
}
