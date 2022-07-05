using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LibraryManagementSystem
{
    class Student: User
    {
        public int id;
        public List<Book> myItems;
    }
}
