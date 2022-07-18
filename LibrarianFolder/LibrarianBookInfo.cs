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
    public partial class frmLibBookInfo : Form
    {
        public frmLibBookInfo()
        {
            InitializeComponent();            
        }

        DataTable table;
        public static int selectedRow = 0;

        private void frmLibBookInfo_Load(object sender, EventArgs e)
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

            dgwBookInfo.DataSource = table;            
        }

        private void btnNewBook_Click(object sender, EventArgs e)
        {
            frmLibrarianNewBook newBook = new frmLibrarianNewBook();
            newBook.Show();
        }

        private void dgwBookInfo_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            frmLibBookEdit bookEditing = new frmLibBookEdit();

            selectedRow = e.RowIndex;

            bookEditing.txtEditName.Text = dgwBookInfo.Rows[e.RowIndex].Cells[0].Value.ToString();
            bookEditing.txtEditAuthorNa.Text = dgwBookInfo.Rows[e.RowIndex].Cells[1].Value.ToString();
            bookEditing.dateTimeEdit.Value = (DateTime)dgwBookInfo.Rows[e.RowIndex].Cells[2].Value;
            bookEditing.txtQuantityEdit.Text = dgwBookInfo.Rows[e.RowIndex].Cells[3].Value.ToString();
            bookEditing.txtEditBarcode.Text = dgwBookInfo.Rows[e.RowIndex].Cells[4].Value.ToString();
            bookEditing.Show();
        }
    }
}
