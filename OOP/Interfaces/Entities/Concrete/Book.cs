using Interfaces.Entities.Interface;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Interfaces.Entities.Concrete
{
    public class Book : IBook
    {
        public string BookName { get ; set ; }
        public string BookAuthor { get ; set ; }
        public string BookGenre { get ; set ; }
        public string BookDescription { get ; set ; }
        public string BookFirstPublishDate { get ; set ; }
        public int BookPage { get ; set ; }
    }
}
