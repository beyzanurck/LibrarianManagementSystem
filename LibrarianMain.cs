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

            frmLibAccount frmLibAccount = new frmLibAccount() 
            { Dock = DockStyle.Fill, TopLevel = false, TopMost = true };

            frmLibAccount.MdiParent = this;

            this.pnlLibMain.Controls.Add(frmLibAccount);
            frmLibAccount.Show();
        }
    }
}
