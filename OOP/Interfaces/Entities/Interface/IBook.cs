using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Interfaces.Entities.Interface
{
    public interface IBook
    {
        string BookName { get; set; }
        string BookAuthor { get; set; }
        string BookGenre { get; set; }
        string BookDescription { get; set; }
        string BookFirstPublishDate { get; set; }
        int BookPage { get; set; }

    }
}
