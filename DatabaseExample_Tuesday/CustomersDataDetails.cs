using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace DatabaseExample_Tuesday
{
    public partial class CustomersDataDetails : Form
    {
        public CustomersDataDetails()
        {
            InitializeComponent();
        }

        private void customersBindingNavigatorSaveItem_Click(object sender, EventArgs e)
        {
            this.Validate();
            try
            {
                this.customersBindingSource.EndEdit();
                this.tableAdapterManager.UpdateAll(this.mMABooksDataSet);
            }
            //catch exceptions when you try to go beyond length of the field/column
            catch(ArgumentException ex)
            {
                MessageBox.Show(ex.Message, "Argument Exception", MessageBoxButtons.OK, MessageBoxIcon.Error);
                this.customersBindingSource.CancelEdit();

            }
            //ADO.net concurrency exception
            catch(DBConcurrencyException)
            {
                MessageBox.Show("A concurrency error occured", "Date not updated: Concurrency Exception",
                    MessageBoxButtons.OK, MessageBoxIcon.Error);
                this.customersTableAdapter.Fill(this.mMABooksDataSet.Customers);
            }
            //for alll other ADO.net exceptions
            catch(DataException ex)
            {

                MessageBox.Show(ex.Message, "Argument Exception", MessageBoxButtons.OK, MessageBoxIcon.Error);
                this.customersBindingSource.CancelEdit();
            }
            catch (SqlException ex)
            {
                MessageBox.Show("Database Error# " + ex.Number + " :" + ex.Message,
                    ex.GetType().ToString(),
                    MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

        }

        private void CustomersDataDetails_Load(object sender, EventArgs e)
        {
            try
            {
                this.customersTableAdapter.Fill(this.mMABooksDataSet.Customers);
            }
            catch(SqlException ex)
            {
                MessageBox.Show("Database Error# " + ex.Number + " :" + ex.Message,
                    ex.GetType().ToString(),
                    MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

        }

        private void toolStripButton1_Click(object sender, EventArgs e)
        {
            this.customersBindingSource.CancelEdit();
        }
    }
}
