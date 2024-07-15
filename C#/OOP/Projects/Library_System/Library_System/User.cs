using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LibraryBook
{
    internal class User
    {
        public string Id { get; set; }
        public string PassWord { get; set; }

        public void DisplayAllBookInLibrary(List<Book> books)
        {
            if (books.Count == 0)
            {
                Console.WriteLine("Empty BookS !!");
                return;
            }
            foreach (var item in books)
            {
                if (item.IsAvialble)
                    Console.WriteLine($"Id  : {item.Id}\tTitel : {item.Title}\tAuther : {item.Auther}\tYear : {item.Year}");
            }
        }

        public User(string id, string passWord)
        {
            this.Id = id;
            this.PassWord = passWord;
        }

    }
}
