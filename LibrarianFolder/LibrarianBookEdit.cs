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
    public partial class frmLibBookEdit : Form
    {
        public frmLibBookEdit()
        {
            InitializeComponent();
        }

        private void btnSaveEditing_Click(object sender, EventArgs e)
        {
            Book.books[frmLibBookInfo.selectedRow].name = txtEditName.Text;
            Book.books[frmLibBookInfo.selectedRow].authorName = txtEditAuthorNa.Text;
            Book.books[frmLibBookInfo.selectedRow].quantity = Convert.ToInt32(txtQuantityEdit.Text);
            Book.books[frmLibBookInfo.selectedRow].barcodeNo = Convert.ToInt32(txtEditBarcode.Text);
            Book.books[frmLibBookInfo.selectedRow].publicationDate = dateTimeEdit.Text;

            ((Panel)Application.OpenForms["frmLibrarianMain"].Controls["pnlLibMain"]).Controls.Clear();

            frmLibBookInfo bookInfo = new frmLibBookInfo()
            { Dock = DockStyle.Fill, TopLevel = false, TopMost = true };

            ((Panel)Application.OpenForms["frmLibrarianMain"].Controls["pnlLibMain"]).Controls.Add(bookInfo);
            bookInfo.Show();
            
            this.Close();
        }
    }
}
