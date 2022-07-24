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
    public partial class frmStudentMyItemsPage : Form
    {
        public frmStudentMyItemsPage()
        {
            InitializeComponent();
        }

        DataTable table;
        private void frmStudentMyItemsPage_Load(object sender, EventArgs e)
        {
            table = new DataTable();

            table.Columns.Add("Name", typeof(String));
            table.Columns.Add("Author Name", typeof(String));
            table.Columns.Add("Check-Out Date", typeof(DateTime));
            table.Columns.Add("Due Date", typeof(DateTime));
            table.Columns.Add("Renew", typeof(int));
            table.Columns.Add("Barcode No", typeof(int));

            foreach (var item in Student.myItems)
            {
                table.Rows.Add(new object[] 
                { item.name, item.authorName, item.checkedOutDate, item.dueDate, item.renewedCount, item.barcodeNo});
            }

            dgvMyItemsList.DataSource = table;
        }

        private void btnRenew_Click(object sender, EventArgs e)
        {
            if (dgvMyItemsList.SelectedRows.Count == 1)
            {
                int id = Convert.ToInt32(dgvMyItemsList.SelectedRows[0].Cells[5].Value);

                foreach (var item in Student.myItems)
                {
                    if (item.barcodeNo == id)
                    {
                        if (item.renewedCount != 3)
                        {
                            item.renewedCount++;
                        }
                        else
                        {
                            MessageBox.Show("You already renewed it three times. Please retrun it!");
                        }

                        break;
                    }
                }

                ((Panel)Application.OpenForms["frmStudentMain"].Controls["pnlStudentMain"]).Controls.Clear();

                frmStudentMyItemsPage frmStudentMyItemsPage = new frmStudentMyItemsPage()
                { Dock = DockStyle.Fill, TopLevel = false, TopMost = true };

                ((Panel)Application.OpenForms["frmStudentMain"].Controls["pnlStudentMain"]).Controls.Add(frmStudentMyItemsPage);
                frmStudentMyItemsPage.Show();

            }
            else
            {
                MessageBox.Show("Please select an item");
            }
        }

        private void btnReturn_Click(object sender, EventArgs e)
        {
            if (dgvMyItemsList.SelectedRows.Count == 1)
            {
                int id = Convert.ToInt32(dgvMyItemsList.SelectedRows[0].Cells[5].Value);

                foreach (var item in Student.myItems)
                {
                    if (item.barcodeNo == id)
                    {
                        Student.myItems.Remove(item);                  

                        break;
                    }
                }

                ((Panel)Application.OpenForms["frmStudentMain"].Controls["pnlStudentMain"]).Controls.Clear();

                frmStudentMyItemsPage frmStudentMyItemsPage = new frmStudentMyItemsPage()
                { Dock = DockStyle.Fill, TopLevel = false, TopMost = true };

                ((Panel)Application.OpenForms["frmStudentMain"].Controls["pnlStudentMain"]).Controls.Add(frmStudentMyItemsPage);
                frmStudentMyItemsPage.Show();

            }
            else
            {
                MessageBox.Show("Please select an item");
            }
        }
    }
}
