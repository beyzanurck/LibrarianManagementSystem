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
    public partial class frmLibrarianNewBook : Form
    {
        public frmLibrarianNewBook()
        {
            InitializeComponent();
        }

        private void btnNewBookSave_Click(object sender, EventArgs e)
        {
            Book.books.Add(new Book()
            {
                name = txtAddNewName.Text,
                authorName = txtAddNewAuthorName.Text,
                quantity = Convert.ToInt32(txtAddNewQuantity.Text),
                barcodeNo = Convert.ToInt32(txtAddNewBarcodeNo.Text),
                publicationDate = dateTimePicker1.Text
            });

            ((Panel)Application.OpenForms["frmLibrarianMain"].Controls["pnlLibMain"]).Controls.Clear();

            frmLibBookInfo bookInfo = new frmLibBookInfo()
            { Dock = DockStyle.Fill, TopLevel = false, TopMost = true };

            ((Panel)Application.OpenForms["frmLibrarianMain"].Controls["pnlLibMain"]).Controls.Add(bookInfo);
            bookInfo.Show();

            this.Close();
        }
    }
}
