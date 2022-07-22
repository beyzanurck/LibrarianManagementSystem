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
    public partial class frmLibAccountEdit : Form
    {
        public frmLibAccountEdit()
        {
            InitializeComponent();
        }

        int id;
        private void frmLibAccountEdit_Load(object sender, EventArgs e)
        {
            foreach (var item in Librarian.librarians)
            {
                if (frmLogin.currentUserID == item.id)
                {
                    txtFirstEdit.Text = item.firstName;
                    txtLastEdit.Text = item.lastName;
                    txtAddEdit.Text = item.adress;
                    txtEmailEdit.Text = item.email;
                    txtPassEdit.Text = item.password.ToString();
                    id = item.id;
                    break;
                }               
            }
        }

        private void btnLibEdit_Click(object sender, EventArgs e)
        {
            foreach (var item in Librarian.librarians)
            {
                if (item.id == id)
                {
                    item.firstName = txtFirstEdit.Text;
                    item.lastName = txtLastEdit.Text;
                    item.adress = txtAddEdit.Text;
                    item.email = txtEmailEdit.Text;
                    item.password = Convert.ToInt32(txtPassEdit.Text);
                    break;
                }
            }

            ((Panel)Application.OpenForms["frmLibrarianMain"].Controls["pnlLibMain"]).Controls.Clear();

            frmLibAccount info = new frmLibAccount()
            { Dock = DockStyle.Fill, TopLevel = false, TopMost = true };

            ((Panel)Application.OpenForms["frmLibrarianMain"].Controls["pnlLibMain"]).Controls.Add(info);
            info.Show();
        }
    }
}
