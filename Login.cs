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
        public static int currentUserID;
        private void frmLogin_Load(object sender, EventArgs e)
        {
            librarian.AddLibrarian();
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
        }
    }
}
