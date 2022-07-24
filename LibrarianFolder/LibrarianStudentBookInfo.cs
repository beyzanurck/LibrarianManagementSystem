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
    public partial class frmLibrarianStudentBookInfo : Form
    {
        public frmLibrarianStudentBookInfo()
        {
            InitializeComponent();
        }
        DataTable table;

        private void frmLibrarianStudentBookInfo_Load(object sender, EventArgs e)
        {
            table = new DataTable();

            table.Columns.Add("Name", typeof(String));
            table.Columns.Add("Author Name", typeof(String));           
            table.Columns.Add("Barcode No", typeof(String));
            table.Columns.Add("CheckOut Date", typeof(DateTime));
            table.Columns.Add("Due Date", typeof(DateTime));

            foreach (var item in Student.myItems)
            {
                table.Rows.Add(new object[] { item.name, item.authorName, item.barcodeNo, item.checkedOutDate, item.dueDate });
            }

            dgvBookInfoOfStudent.DataSource = table;
        }
    }    
}
