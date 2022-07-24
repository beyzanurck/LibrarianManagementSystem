using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace LibraryManagementSystem.LibrarianFolder
{
    public partial class frmLibrarianStudentInfo : Form
    {
        public frmLibrarianStudentInfo()
        {
            InitializeComponent();
        }

        DataTable table;
        private void frmLibrarianStudentInfo_Load(object sender, EventArgs e)
        {
            table = new DataTable();

            table.Columns.Add("Firt Name", typeof(String));
            table.Columns.Add("Last Name", typeof(String));
            table.Columns.Add("Email", typeof(String));
            table.Columns.Add("Adress", typeof(String));
            table.Columns.Add("Password", typeof(String));
            table.Columns.Add("ID", typeof(int));


            foreach (var item in Student.students)
            {
                table.Rows.Add(new object[] { item.firstName, item.lastName, item.email, item.adress, item.password, item.id });
            }

            dgvStudentList.DataSource = table;
        }

        private void btnNewStudent_Click(object sender, EventArgs e)
        {
            ((Panel)Application.OpenForms["frmLibrarianMain"].Controls["pnlLibMain"]).Controls.Clear();

            frmLibrarianNewStudent frmNewStudent = new frmLibrarianNewStudent()
            { Dock = DockStyle.Fill, TopLevel = false, TopMost = true };

            ((Panel)Application.OpenForms["frmLibrarianMain"].Controls["pnlLibMain"]).Controls.Add(frmNewStudent);
            frmNewStudent.Show();
        }

        private void dgvStudentList_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            frmLibrarianStudentBookInfo bookInfo = new frmLibrarianStudentBookInfo();
            bookInfo.Show();
        }
    }
}
