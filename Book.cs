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
            { name = "Wonder", authorName = "R.J.", barcodeNo = 001135226, quantity = 3, publicationDate = " January 2012" });

            books.Add(new Book()
            { name = "Digital Minimalism", authorName = "Cal Newport", barcodeNo = 001135227, quantity = 5, publicationDate = " February 2016" });

            books.Add(new Book()
            { name = "Presence", authorName = "Amy Cuddy", barcodeNo = 001135228, quantity = 4, publicationDate = "March 2015" });

            books.Add(new Book()
            { name = "Time management", authorName = "Brian Tracy", barcodeNo = 001135229, quantity = 2, publicationDate = "April 2013" }); 

            books.Add(new Book()
            { name = "Harry Potter 1", authorName = "J.K. Rowling", barcodeNo = 001135229, quantity = 10, publicationDate = "May 2000" });

            books.Add(new Book()
            { name = "Harry Potter 2", authorName = "J.K. Rowling", barcodeNo = 001135229, quantity = 10, publicationDate = "Jun 2000" });
        }
    }
}
