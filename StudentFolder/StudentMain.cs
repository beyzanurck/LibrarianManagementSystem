using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace LibraryManagementSystem.StudentFolder
{
    public partial class frmStudentMain : Form
    {
        public frmStudentMain()
        {
            InitializeComponent();
        }

        Book book = new Book();

        private void btnStudentAccount_Click(object sender, EventArgs e)
        {
            ((Panel)Application.OpenForms["frmStudentMain"].Controls["pnlStudentMain"]).Controls.Clear();

            frmStudentAccountInfo frmStudentAccountInfo = new frmStudentAccountInfo()
            { Dock = DockStyle.Fill, TopLevel = false, TopMost = true };

            this.pnlStudentMain.Controls.Add(frmStudentAccountInfo);
            frmStudentAccountInfo.Show();    
        }

        private void btnStudentBooks_Click(object sender, EventArgs e)
        {
            ((Panel)Application.OpenForms["frmStudentMain"].Controls["pnlStudentMain"]).Controls.Clear();

            frmStudentBooksList frmStudentBooksList = new frmStudentBooksList
            { Dock = DockStyle.Fill, TopLevel = false, TopMost = true };

            this.pnlStudentMain.Controls.Add(frmStudentBooksList);
            frmStudentBooksList.Show();
        }

        private void frmStudentMain_Load(object sender, EventArgs e)
        {
            Book.books.Clear();
            book.AddBook();
        }

        private void btnStuMyIteims_Click(object sender, EventArgs e)
        {
            ((Panel)Application.OpenForms["frmStudentMain"].Controls["pnlStudentMain"]).Controls.Clear();

            frmStudentMyItemsPage frmStudentMyItemsPage = new frmStudentMyItemsPage()
            { Dock = DockStyle.Fill, TopLevel = false, TopMost = true };

            this.pnlStudentMain.Controls.Add(frmStudentMyItemsPage);
            frmStudentMyItemsPage.Show();
        }

        private void btnStudentLogOut_Click(object sender, EventArgs e)
        {
            this.Close();

            foreach (Form frm in Application.OpenForms)
            {
                if (frm.Visible == false && frm.Name == "frmLogin")
                {
                    frm.Visible = true;
                }
            }
        }
    }
}
