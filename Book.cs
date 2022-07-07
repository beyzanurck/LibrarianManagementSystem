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
    }
}
