using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LibraryManagementSystem
{
    public class Librarian: User
    {
        public List<Book> books;
        public List<Student> students;
        public static List<Librarian> librarians = new List<Librarian>();

        public void AddLibrarian()
        {
            librarians.Add(new Librarian()
            { firstName = "Sarah", lastName = "Content", email = "sarah@apl.com", adress = "Ames", password = 1234, id = 01 });

            librarians.Add(new Librarian()
            { firstName = "Mesih", lastName = "Content", email = "sarah@apl.com", adress = "Ames", password = 1235, id = 02 });
        }
    }

  


}
