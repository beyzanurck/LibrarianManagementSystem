using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace LibraryManagementSystem
{
    public partial class frmLogin : Form
    {
        public frmLogin()
        {
            InitializeComponent();
        }

        Librarian librarian = new Librarian();
        Student student = new Student();

        public static int currentUserID;
        private void frmLogin_Load(object sender, EventArgs e)
        {
            librarian.AddLibrarian();
            student.AddStudent();
        }

        private void btnLogin_Click(object sender, EventArgs e)
        {
            foreach (var item in Librarian.librarians)
            {
                if ((txtUsername.Text == item.firstName) && (txtPassword.Text == item.password.ToString()))
                {
                    currentUserID = item.id;

                    frmLibrarianMain frmLibrarianMain = new frmLibrarianMain();
                    frmLibrarianMain.Show();
                    this.Hide();

                    break;
                }
            }

            foreach (var item in Student.students)
            {
                if ((txtUsername.Text == item.firstName) && (txtPassword.Text == item.password.ToString()))
                {
                    currentUserID = item.id;

                    StudentFolder.frmStudentMain studentMain = new StudentFolder.frmStudentMain();
                    studentMain.Show();
                    this.Hide();

                    break;
                }
            }
        }
    }
}
