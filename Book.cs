using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LibraryManagementSystem
{
    public class Book
    {
        public string name;
        public string authorName;
        public int quantity;
        public int barcodeNo;
        public int renewedCount;
        public string publicationDate;
        public DateTime dueDate;
        public DateTime checkedOutDate;

        public static List<Book> books = new List<Book>();

        public void AddBook()
        {
            books.Add(new Book()
            { name = "R.J.", authorName = "Wonder", barcodeNo = 001135226, quantity = 3, publicationDate = "February 2012" });
        }
    }
}
