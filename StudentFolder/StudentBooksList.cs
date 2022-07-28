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
    public partial class frmStudentBooksList : Form
    {
        public frmStudentBooksList()
        {
            InitializeComponent();
        }

        DataTable table;

        private void frmStudentBooksList_Load(object sender, EventArgs e)
        {
            table = new DataTable();

            table.Columns.Add("Name", typeof(String));
            table.Columns.Add("Author Name", typeof(String));
            table.Columns.Add("Publication Date", typeof(DateTime));
            table.Columns.Add("Quantity", typeof(int));
            table.Columns.Add("Barcode No", typeof(String));

            foreach (var item in Book.books)
            {
                table.Rows.Add(new object[] { item.name, item.authorName, item.publicationDate, item.quantity, item.barcodeNo });
            }

            dgvStudentBookList.DataSource = table;
        }


        private void dgvStudentBookList_CellDoubleClick_1(object sender, DataGridViewCellEventArgs e)
        {
            Student.myItems.Add(new Book()
            {
                name = dgvStudentBookList.Rows[e.RowIndex].Cells[0].Value.ToString(),
                authorName = dgvStudentBookList.Rows[e.RowIndex].Cells[1].Value.ToString(),
                barcodeNo = Convert.ToInt32(dgvStudentBookList.Rows[e.RowIndex].Cells[4].Value),
                checkedOutDate = DateTime.Today,
                dueDate = DateTime.Today.AddDays(21),
                renewedCount = 0
            });

            MessageBox.Show("The book has been added in your account");
        }
    }
}
