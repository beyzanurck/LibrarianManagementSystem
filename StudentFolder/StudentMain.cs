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

        private void btnStudentAccount_Click(object sender, EventArgs e)
        {
            ((Panel)Application.OpenForms["frmStudentMain"].Controls["pnlStudentMain"]).Controls.Clear();

            frmStudentAccountInfo frmStudentAccountInfo = new frmStudentAccountInfo()
            { Dock = DockStyle.Fill, TopLevel = false, TopMost = true };

            this.pnlStudentMain.Controls.Add(frmStudentAccountInfo);
            frmStudentAccountInfo.Show();    
        }
    }
}
