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
    public partial class CustomerInvoicesForm : Form
    {
        public CustomerInvoicesForm()
        {
            InitializeComponent();
        }

        private void customersBindingNavigatorSaveItem_Click(object sender, EventArgs e)
        {
            this.Validate();
            this.customersBindingSource.EndEdit();
            this.tableAdapterManager.UpdateAll(this.mMABooksDataSet);

        }

        private void CustomerInvoicesForm_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'mMABooksDataSet.Invoices' table. You can move, or remove it, as needed.
           // this.invoicesTableAdapter.Fill(this.mMABooksDataSet.Invoices);
            // TODO: This line of code loads data into the 'mMABooksDataSet.Customers' table. You can move, or remove it, as needed.
           // this.customersTableAdapter.Fill(this.mMABooksDataSet.Customers);

        }

        private void fillByCustomerIDToolStripButton_Click(object sender, EventArgs e)
        {
            try
            {
                this.customersTableAdapter.FillByCustomerID
                    (this.mMABooksDataSet.Customers, ((int)(System.Convert.ChangeType(customerIDToolStripTextBox.Text, typeof(int)))));
                this.invoicesTableAdapter.Fill(this.mMABooksDataSet.Invoices);
            }
            catch (System.Exception ex)
            {
                System.Windows.Forms.MessageBox.Show(ex.Message);
            }

        }

        private void GetAllCustomerstoolStripButton_Click(object sender, EventArgs e)
        {
            this.invoicesTableAdapter.Fill(this.mMABooksDataSet.Invoices);
           this.customersTableAdapter.Fill(this.mMABooksDataSet.Customers);
        }
    }
}
