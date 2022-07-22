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
    public partial class frmStudentAccountInfo : Form
    {
        public frmStudentAccountInfo()
        {
            InitializeComponent();
        }

        private void frmStudentAccountInfo_Load(object sender, EventArgs e)
        {
            foreach (var item in Student.students)
            {
                if (frmLogin.currentUserID == item.id)
                {
                    lblStudentFirst.Text = item.firstName;
                    lblStudentLast.Text = item.lastName;
                    lblStudentEmail.Text = item.email;
                    lblStuAccAddress.Text = item.adress;
                    lblStuAccountPassword.Text = item.password.ToString();
                    lblStudentId.Text = item.id.ToString();
                    break;
                }
            }
        }

        private void btnStuAccountEdit_Click(object sender, EventArgs e)
        {
            ((Panel)Application.OpenForms["frmStudentMain"].Controls["pnlStudentMain"]).Controls.Clear();

            frmStudentEditing frmStudentEditing = new frmStudentEditing()
            { Dock = DockStyle.Fill, TopLevel = false, TopMost = true };

            ((Panel)Application.OpenForms["frmStudentMain"].Controls["pnlStudentMain"]).Controls.Add(frmStudentEditing);
            frmStudentEditing.Show();
        }
    }
}
