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
    public partial class frmStudentEditing : Form
    {
        public frmStudentEditing()
        {
            InitializeComponent();
        }

        int id = frmLogin.currentUserID;
        private void frmStudentEditing_Load(object sender, EventArgs e)
        {
            foreach (var item in Student.students)
            {
                if (item.id == id)
                {
                    txtStuEditingFirstName.Text = item.firstName;
                    txtStuEdiLastNa.Text = item.lastName;
                    txtStuEditEmail.Text = item.email;
                    txtStuEditAdress.Text = item.adress;
                    txtStuEditPassword.Text = item.password.ToString();
                    break;
                }                
            }
        }

        private void btnStudentEditingSave_Click(object sender, EventArgs e)
        {
            foreach (var item in Student.students)
            {
                if (item.id == id)
                {
                    item.firstName = txtStuEditingFirstName.Text;
                    item.lastName = txtStuEdiLastNa.Text;
                    item.email = txtStuEditEmail.Text;
                    item.adress = txtStuEditAdress.Text;
                    item.password = Convert.ToInt32(txtStuEditPassword.Text);
                    break;
                }
            }

            ((Panel)Application.OpenForms["frmStudentMain"].Controls["pnlStudentMain"]).Controls.Clear();

            frmStudentAccountInfo frmStudentAccountInfo = new frmStudentAccountInfo()
            { Dock = DockStyle.Fill, TopLevel = false, TopMost = true };

            ((Panel)Application.OpenForms["frmStudentMain"].Controls["pnlStudentMain"]).Controls.Add(frmStudentAccountInfo);
            frmStudentAccountInfo.Show();
        }
    }
}
