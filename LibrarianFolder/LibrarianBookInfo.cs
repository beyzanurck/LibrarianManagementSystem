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
                table.Rows.Add(new object[] { item.authorName, item.name, item.publicationDate, item.quantity, item.barcodeNo });
            }

            dgwBookInfo.DataSource = table;            
        }

        private void btnNewBook_Click(object sender, EventArgs e)
        {
            frmLibrarianNewBook newBook = new frmLibrarianNewBook();
            newBook.Show();
        }
    }
}
