using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LibraryBook
{
    internal class LibrarySystem
    {

        private List<Book> books = new List<Book>();
        private List<Customer> customers = new List<Customer>();
        private List<Librarian> librarians = new List<Librarian>();
        
        public void StartApp()
        {
            this.WelComeApp();
        }
        private void WelComeApp()
        {

            bool inputTrue = true;
            while (inputTrue)
            {
                Console.Write("Home \nWelCome In Library\n\n1- Sin in\n2- Sin Up\n3- ExitApp \nEnter : ");
                int input = int.Parse(Console.ReadLine());
                if (input == 1)
                {
                    SinIn();
                    inputTrue = false;
                }
                else if (input == 2)
                {
                    SinUP();
                    inputTrue = false;
                }
                else if (input == 3)
                {
                    Console.WriteLine("Exit App Thank You");
                    inputTrue = false;
                }
                else
                {
                    Console.WriteLine("Invalid Input");
                }
            }

        }

        private void SinIn()
        {
            string id, pass;
            Console.Write("SinIn Page \n\nEnter Id : ");
            id = Console.ReadLine();
            Console.Write("Enter Pass : ");
            pass = Console.ReadLine();

            id.Contains("cust");

            if (id.Contains("cust"))
            {
                foreach (var item in customers)
                {
                    if (item.Id == id && item.PassWord == pass)
                    {

                        ModeCustomer(item);
                    }
                }
            }
            else if (id.Contains("lib"))
            {
                foreach (var item in librarians)
                {
                    if (item.Id == id && item.PassWord == pass)
                    {
                        ModeLibrarian(item);
                    }
                }
            }
            Console.WriteLine("InValid Input ");
            this.WelComeApp();
        }

        private void SinUP()
        {
            string id, pass;
            string hash = "test";
            string type;
            bool inputTrue = true;

            while (inputTrue)
            {
                Console.Write("you SinUP As (Customer {cust} Or Librarian {lib}) : ");
                type = Console.ReadLine();
                if (type == "cust") { hash = "cust"; inputTrue = false; }
                else if (type == "lib") { hash = "lib"; inputTrue = false; }
                else { Console.WriteLine("Invalid Input "); }
            }

            Console.Write("\nSinUP Page \nEnter Id : ");
            id = Console.ReadLine();
            Console.Write("Enter Pass : ");
            pass = Console.ReadLine();

            Console.WriteLine($"Dear !!\nId : {hash + id}\nPass : {pass}");
            if (hash == "cust")
            {
                Customer Cust = new Customer(hash + id, pass);
                customers.Add(Cust);
                ModeCustomer(Cust);
            }
            else
            {
                Librarian Lib = new Librarian(hash + id, pass);
                librarians.Add(Lib);
                ModeLibrarian(Lib);
            }
        }

        private void ModeCustomer(Customer cust)
        {
            Console.Write("WelCome this is Page Customer !!\n");
            bool flag = true;
            int input = 0;
            while (flag)
            {
                Console.Write("1-DisplayBooksBorrow\t2-BorrowBook\t3-ReturnBook\t4-ExitSystem\nPlese Enter 1 or 2 or 3 or 4 : ");
                input = int.Parse(Console.ReadLine());
                if (input == 1 || input == 2 || input == 3 || input == 4) flag = false;
            }

            if (input == 1)
            {
                cust.DisplayBooksBorrow();
                this.ModeCustomer(cust);
            }
            else if (input == 2)
            {
                cust.BorrowBook(books);
                this.ModeCustomer(cust);
            }
            else if (input == 3)
            {
                cust.ReturnBook(books);
                this.ModeCustomer(cust);
            }
            else
            {
                this.WelComeApp();
            }

        }













        private void ModeLibrarian(Librarian lib)
        {
            Console.WriteLine("WelCome this is Page Librarian !!\n\n");
            bool flag = true;
            int input = 0;
            while (flag)
            {
                Console.WriteLine("1-DisplayBook\t2-AddBook\t3-RemoveBook\t4-DisPlayCustomers\t5-ExitSystem\nPlese Enter 1 or 2 or 3 or 4 or 5 : ");
                input = int.Parse(Console.ReadLine());
                if (input == 1 || input == 2 || input == 3 || input == 4 || input == 5) flag = false;
                else Console.WriteLine("Invalid input");
            }

            if (input == 1)
            {
                lib.DisplayAllBookInLibrary(books);
                this.ModeLibrarian(lib);
            }
            else if (input == 2)
            {
                books.Add(lib.AddBook());
                lib.DisplayAllBookInLibrary(books);
                this.ModeLibrarian(lib);
            }
            else if (input == 3)
            {

                lib.RemoveBook(books);
                this.ModeLibrarian(lib);
            }
            else if (input == 4)
            {
                lib.DispayCustomer(customers);
                Console.WriteLine();
                this.ModeLibrarian(lib);
            }
            else
            {
                this.WelComeApp();
            }




        }


    }
}
