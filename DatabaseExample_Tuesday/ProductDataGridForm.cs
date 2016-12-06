using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace DatabaseExample_Tuesday
{
    public partial class ProductDataGridForm : Form
    {
        public ProductDataGridForm()
        {
            InitializeComponent();
        }

        private void productsBindingNavigatorSaveItem_Click(object sender, EventArgs e)
        {
            this.Validate();
            this.productsBindingSource.EndEdit();
            this.tableAdapterManager.UpdateAll(this.mMABooksDataSet);

        }

        private void ProductDataGridForm_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'mMABooksDataSet.Products' table. You can move, or remove it, as needed.
            this.productsTableAdapter.Fill(this.mMABooksDataSet.Products);

        }
    }
}
