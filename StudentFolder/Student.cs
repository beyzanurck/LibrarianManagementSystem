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
            { firstName = "Beyza", lastName = "Kilinc", email = "beyza@gmail.com", adress = "Ames", password = 1234, id = 001 });

            students.Add(new Student()
            { firstName = "Sooyoung", lastName = "Kwak", email = "sooyoung@gmail.com", adress = "Ames", password = 1235, id = 002 });
        }
    }
}
