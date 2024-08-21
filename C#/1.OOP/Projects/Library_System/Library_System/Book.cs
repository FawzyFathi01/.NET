using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LibraryBook
{
    internal class Book
    {
        public int Id { get; set; }
        public string Title { get; set; }
        public string Auther { get; set; }
        public int Year { get; set; }
        public bool IsAvialble { get; set; }
    }
}
