using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LibraryManagementSystem
{
    public class Student: User
    {
        public List<Book> myItems;

        public static List<Student> students = new List<Student>();

        public void AddStudent()
        {
            students.Add(new Student()
            { firstName = "Beyza", lastName = "Kilinc", email = "beyza@gmail.com", adress = "Suv 27", password = 1234, id = 112250 });

            students.Add(new Student()
            { firstName = "Sooyoung", lastName = "Kwak", email = "sooyoung@gmail.com", adress = "Suv 46", password = 1235, id = 113254 });
        }
    }
}
