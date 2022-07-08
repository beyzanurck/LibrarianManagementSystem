
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
    public partial class frmLibrarianMain : Form
    {
        public frmLibrarianMain()
        {
            InitializeComponent();
        }

        private void btnLibAccount_Click(object sender, EventArgs e)
        {
            ((Panel)Application.OpenForms["frmLibrarianMain"].Controls["pnlLibMain"]).Controls.Clear();

            frmLibAccount frmLibAccount = new frmLibAccount() 
            { Dock = DockStyle.Fill, TopLevel = false, TopMost = true };

            this.pnlLibMain.Controls.Add(frmLibAccount);
            frmLibAccount.Show();
        }

        private void btnLibBook_Click(object sender, EventArgs e)
        {
            ((Panel)Application.OpenForms["frmLibrarianMain"].Controls["pnlLibMain"]).Controls.Clear();

            LibrarianFolder.frmLibBookInfo bookInfoFrm = new LibrarianFolder.frmLibBookInfo()
            { Dock = DockStyle.Fill, TopLevel = false, TopMost = true };

            this.pnlLibMain.Controls.Add(bookInfoFrm);
            bookInfoFrm.Show();
        }
    }
}
