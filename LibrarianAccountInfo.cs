using System;
using System.Windows.Forms;

namespace LibraryManagementSystem
{
    public partial class frmLibAccount : Form
    {
        public frmLibAccount()
        {
            InitializeComponent();
        }

        private void btnLibAccountEdit_Click(object sender, EventArgs e)
        {
            ((Panel)Application.OpenForms["frmLibrarianMain"].Controls["pnlLibMain"]).Controls.Clear();

            frmLibAccountEdit frmLibAccountEdit = new frmLibAccountEdit()
            { Dock = DockStyle.Fill, TopLevel = false, TopMost = true };

            ((Panel)Application.OpenForms["frmLibrarianMain"].Controls["pnlLibMain"]).Controls.Add(frmLibAccountEdit);
            frmLibAccountEdit.Show();

        }

    }
}
