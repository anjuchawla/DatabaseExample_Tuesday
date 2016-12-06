namespace DatabaseExample_Tuesday
{
    partial class CustomerInvoicesForm
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            System.Windows.Forms.Label customerIDLabel;
            System.Windows.Forms.Label nameLabel;
            System.Windows.Forms.Label addressLabel;
            System.Windows.Forms.Label cityLabel;
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(CustomerInvoicesForm));
            this.mMABooksDataSet = new DatabaseExample_Tuesday.MMABooksDataSet();
            this.customersBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.customersTableAdapter = new DatabaseExample_Tuesday.MMABooksDataSetTableAdapters.CustomersTableAdapter();
            this.tableAdapterManager = new DatabaseExample_Tuesday.MMABooksDataSetTableAdapters.TableAdapterManager();
            this.invoicesTableAdapter = new DatabaseExample_Tuesday.MMABooksDataSetTableAdapters.InvoicesTableAdapter();
            this.customersBindingNavigator = new System.Windows.Forms.BindingNavigator(this.components);
            this.bindingNavigatorAddNewItem = new System.Windows.Forms.ToolStripButton();
            this.bindingNavigatorCountItem = new System.Windows.Forms.ToolStripLabel();
            this.bindingNavigatorDeleteItem = new System.Windows.Forms.ToolStripButton();
            this.bindingNavigatorMoveFirstItem = new System.Windows.Forms.ToolStripButton();
            this.bindingNavigatorMovePreviousItem = new System.Windows.Forms.ToolStripButton();
            this.bindingNavigatorSeparator = new System.Windows.Forms.ToolStripSeparator();
            this.bindingNavigatorPositionItem = new System.Windows.Forms.ToolStripTextBox();
            this.bindingNavigatorSeparator1 = new System.Windows.Forms.ToolStripSeparator();
            this.bindingNavigatorMoveNextItem = new System.Windows.Forms.ToolStripButton();
            this.bindingNavigatorMoveLastItem = new System.Windows.Forms.ToolStripButton();
            this.bindingNavigatorSeparator2 = new System.Windows.Forms.ToolStripSeparator();
            this.customersBindingNavigatorSaveItem = new System.Windows.Forms.ToolStripButton();
            this.nameTextBox = new System.Windows.Forms.TextBox();
            this.addressTextBox = new System.Windows.Forms.TextBox();
            this.cityTextBox = new System.Windows.Forms.TextBox();
            this.stateTextBox = new System.Windows.Forms.TextBox();
            this.zipCodeTextBox = new System.Windows.Forms.TextBox();
            this.invoicesBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.invoicesDataGridView = new System.Windows.Forms.DataGridView();
            this.dataGridViewTextBoxColumn1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn3 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn4 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn5 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn6 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn7 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.CustomerIDToolStrip = new System.Windows.Forms.ToolStrip();
            this.customerIDToolStripLabel = new System.Windows.Forms.ToolStripLabel();
            this.customerIDToolStripTextBox = new System.Windows.Forms.ToolStripTextBox();
            this.GetCustomerToolStripButton = new System.Windows.Forms.ToolStripButton();
            this.toolStripSeparator1 = new System.Windows.Forms.ToolStripSeparator();
            this.GetAllCustomerstoolStripButton = new System.Windows.Forms.ToolStripButton();
            this.customerIDTextBox = new System.Windows.Forms.TextBox();
            customerIDLabel = new System.Windows.Forms.Label();
            nameLabel = new System.Windows.Forms.Label();
            addressLabel = new System.Windows.Forms.Label();
            cityLabel = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.mMABooksDataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.customersBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.customersBindingNavigator)).BeginInit();
            this.customersBindingNavigator.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.invoicesBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.invoicesDataGridView)).BeginInit();
            this.CustomerIDToolStrip.SuspendLayout();
            this.SuspendLayout();
            // 
            // customerIDLabel
            // 
            customerIDLabel.AutoSize = true;
            customerIDLabel.Location = new System.Drawing.Point(218, 105);
            customerIDLabel.Name = "customerIDLabel";
            customerIDLabel.Size = new System.Drawing.Size(89, 17);
            customerIDLabel.TabIndex = 1;
            customerIDLabel.Text = "Customer ID:";
            // 
            // nameLabel
            // 
            nameLabel.AutoSize = true;
            nameLabel.Location = new System.Drawing.Point(218, 133);
            nameLabel.Name = "nameLabel";
            nameLabel.Size = new System.Drawing.Size(49, 17);
            nameLabel.TabIndex = 3;
            nameLabel.Text = "Name:";
            // 
            // addressLabel
            // 
            addressLabel.AutoSize = true;
            addressLabel.Location = new System.Drawing.Point(218, 161);
            addressLabel.Name = "addressLabel";
            addressLabel.Size = new System.Drawing.Size(64, 17);
            addressLabel.TabIndex = 5;
            addressLabel.Text = "Address:";
            // 
            // cityLabel
            // 
            cityLabel.AutoSize = true;
            cityLabel.Location = new System.Drawing.Point(218, 189);
            cityLabel.Name = "cityLabel";
            cityLabel.Size = new System.Drawing.Size(104, 17);
            cityLabel.TabIndex = 7;
            cityLabel.Text = "City, State, Zip:";
            // 
            // mMABooksDataSet
            // 
            this.mMABooksDataSet.DataSetName = "MMABooksDataSet";
            this.mMABooksDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // customersBindingSource
            // 
            this.customersBindingSource.DataMember = "Customers";
            this.customersBindingSource.DataSource = this.mMABooksDataSet;
            // 
            // customersTableAdapter
            // 
            this.customersTableAdapter.ClearBeforeFill = true;
            // 
            // tableAdapterManager
            // 
            this.tableAdapterManager.BackupDataSetBeforeUpdate = false;
            this.tableAdapterManager.CustomersTableAdapter = this.customersTableAdapter;
            this.tableAdapterManager.InvoicesTableAdapter = this.invoicesTableAdapter;
            this.tableAdapterManager.ProductsTableAdapter = null;
            this.tableAdapterManager.StatesTableAdapter = null;
            this.tableAdapterManager.UpdateOrder = DatabaseExample_Tuesday.MMABooksDataSetTableAdapters.TableAdapterManager.UpdateOrderOption.InsertUpdateDelete;
            // 
            // invoicesTableAdapter
            // 
            this.invoicesTableAdapter.ClearBeforeFill = true;
            // 
            // customersBindingNavigator
            // 
            this.customersBindingNavigator.AddNewItem = this.bindingNavigatorAddNewItem;
            this.customersBindingNavigator.BindingSource = this.customersBindingSource;
            this.customersBindingNavigator.CountItem = this.bindingNavigatorCountItem;
            this.customersBindingNavigator.DeleteItem = this.bindingNavigatorDeleteItem;
            this.customersBindingNavigator.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.customersBindingNavigator.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.bindingNavigatorMoveFirstItem,
            this.bindingNavigatorMovePreviousItem,
            this.bindingNavigatorSeparator,
            this.bindingNavigatorPositionItem,
            this.bindingNavigatorCountItem,
            this.bindingNavigatorSeparator1,
            this.bindingNavigatorMoveNextItem,
            this.bindingNavigatorMoveLastItem,
            this.bindingNavigatorSeparator2,
            this.bindingNavigatorAddNewItem,
            this.bindingNavigatorDeleteItem,
            this.customersBindingNavigatorSaveItem});
            this.customersBindingNavigator.Location = new System.Drawing.Point(0, 0);
            this.customersBindingNavigator.MoveFirstItem = this.bindingNavigatorMoveFirstItem;
            this.customersBindingNavigator.MoveLastItem = this.bindingNavigatorMoveLastItem;
            this.customersBindingNavigator.MoveNextItem = this.bindingNavigatorMoveNextItem;
            this.customersBindingNavigator.MovePreviousItem = this.bindingNavigatorMovePreviousItem;
            this.customersBindingNavigator.Name = "customersBindingNavigator";
            this.customersBindingNavigator.PositionItem = this.bindingNavigatorPositionItem;
            this.customersBindingNavigator.Size = new System.Drawing.Size(878, 27);
            this.customersBindingNavigator.TabIndex = 0;
            this.customersBindingNavigator.Text = "bindingNavigator1";
            // 
            // bindingNavigatorAddNewItem
            // 
            this.bindingNavigatorAddNewItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.bindingNavigatorAddNewItem.Image = ((System.Drawing.Image)(resources.GetObject("bindingNavigatorAddNewItem.Image")));
            this.bindingNavigatorAddNewItem.Name = "bindingNavigatorAddNewItem";
            this.bindingNavigatorAddNewItem.RightToLeftAutoMirrorImage = true;
            this.bindingNavigatorAddNewItem.Size = new System.Drawing.Size(24, 24);
            this.bindingNavigatorAddNewItem.Text = "Add new";
            // 
            // bindingNavigatorCountItem
            // 
            this.bindingNavigatorCountItem.Name = "bindingNavigatorCountItem";
            this.bindingNavigatorCountItem.Size = new System.Drawing.Size(45, 24);
            this.bindingNavigatorCountItem.Text = "of {0}";
            this.bindingNavigatorCountItem.ToolTipText = "Total number of items";
            // 
            // bindingNavigatorDeleteItem
            // 
            this.bindingNavigatorDeleteItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.bindingNavigatorDeleteItem.Image = ((System.Drawing.Image)(resources.GetObject("bindingNavigatorDeleteItem.Image")));
            this.bindingNavigatorDeleteItem.Name = "bindingNavigatorDeleteItem";
            this.bindingNavigatorDeleteItem.RightToLeftAutoMirrorImage = true;
            this.bindingNavigatorDeleteItem.Size = new System.Drawing.Size(24, 24);
            this.bindingNavigatorDeleteItem.Text = "Delete";
            // 
            // bindingNavigatorMoveFirstItem
            // 
            this.bindingNavigatorMoveFirstItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.bindingNavigatorMoveFirstItem.Image = ((System.Drawing.Image)(resources.GetObject("bindingNavigatorMoveFirstItem.Image")));
            this.bindingNavigatorMoveFirstItem.Name = "bindingNavigatorMoveFirstItem";
            this.bindingNavigatorMoveFirstItem.RightToLeftAutoMirrorImage = true;
            this.bindingNavigatorMoveFirstItem.Size = new System.Drawing.Size(24, 24);
            this.bindingNavigatorMoveFirstItem.Text = "Move first";
            // 
            // bindingNavigatorMovePreviousItem
            // 
            this.bindingNavigatorMovePreviousItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.bindingNavigatorMovePreviousItem.Image = ((System.Drawing.Image)(resources.GetObject("bindingNavigatorMovePreviousItem.Image")));
            this.bindingNavigatorMovePreviousItem.Name = "bindingNavigatorMovePreviousItem";
            this.bindingNavigatorMovePreviousItem.RightToLeftAutoMirrorImage = true;
            this.bindingNavigatorMovePreviousItem.Size = new System.Drawing.Size(24, 24);
            this.bindingNavigatorMovePreviousItem.Text = "Move previous";
            // 
            // bindingNavigatorSeparator
            // 
            this.bindingNavigatorSeparator.Name = "bindingNavigatorSeparator";
            this.bindingNavigatorSeparator.Size = new System.Drawing.Size(6, 27);
            // 
            // bindingNavigatorPositionItem
            // 
            this.bindingNavigatorPositionItem.AccessibleName = "Position";
            this.bindingNavigatorPositionItem.AutoSize = false;
            this.bindingNavigatorPositionItem.Name = "bindingNavigatorPositionItem";
            this.bindingNavigatorPositionItem.Size = new System.Drawing.Size(50, 27);
            this.bindingNavigatorPositionItem.Text = "0";
            this.bindingNavigatorPositionItem.ToolTipText = "Current position";
            // 
            // bindingNavigatorSeparator1
            // 
            this.bindingNavigatorSeparator1.Name = "bindingNavigatorSeparator1";
            this.bindingNavigatorSeparator1.Size = new System.Drawing.Size(6, 27);
            // 
            // bindingNavigatorMoveNextItem
            // 
            this.bindingNavigatorMoveNextItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.bindingNavigatorMoveNextItem.Image = ((System.Drawing.Image)(resources.GetObject("bindingNavigatorMoveNextItem.Image")));
            this.bindingNavigatorMoveNextItem.Name = "bindingNavigatorMoveNextItem";
            this.bindingNavigatorMoveNextItem.RightToLeftAutoMirrorImage = true;
            this.bindingNavigatorMoveNextItem.Size = new System.Drawing.Size(24, 24);
            this.bindingNavigatorMoveNextItem.Text = "Move next";
            // 
            // bindingNavigatorMoveLastItem
            // 
            this.bindingNavigatorMoveLastItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.bindingNavigatorMoveLastItem.Image = ((System.Drawing.Image)(resources.GetObject("bindingNavigatorMoveLastItem.Image")));
            this.bindingNavigatorMoveLastItem.Name = "bindingNavigatorMoveLastItem";
            this.bindingNavigatorMoveLastItem.RightToLeftAutoMirrorImage = true;
            this.bindingNavigatorMoveLastItem.Size = new System.Drawing.Size(24, 24);
            this.bindingNavigatorMoveLastItem.Text = "Move last";
            // 
            // bindingNavigatorSeparator2
            // 
            this.bindingNavigatorSeparator2.Name = "bindingNavigatorSeparator2";
            this.bindingNavigatorSeparator2.Size = new System.Drawing.Size(6, 27);
            // 
            // customersBindingNavigatorSaveItem
            // 
            this.customersBindingNavigatorSaveItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.customersBindingNavigatorSaveItem.Image = ((System.Drawing.Image)(resources.GetObject("customersBindingNavigatorSaveItem.Image")));
            this.customersBindingNavigatorSaveItem.Name = "customersBindingNavigatorSaveItem";
            this.customersBindingNavigatorSaveItem.Size = new System.Drawing.Size(24, 24);
            this.customersBindingNavigatorSaveItem.Text = "Save Data";
            this.customersBindingNavigatorSaveItem.Click += new System.EventHandler(this.customersBindingNavigatorSaveItem_Click);
            // 
            // nameTextBox
            // 
            this.nameTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.customersBindingSource, "Name", true));
            this.nameTextBox.Location = new System.Drawing.Point(362, 130);
            this.nameTextBox.Name = "nameTextBox";
            this.nameTextBox.ReadOnly = true;
            this.nameTextBox.Size = new System.Drawing.Size(326, 22);
            this.nameTextBox.TabIndex = 4;
            // 
            // addressTextBox
            // 
            this.addressTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.customersBindingSource, "Address", true));
            this.addressTextBox.Location = new System.Drawing.Point(362, 158);
            this.addressTextBox.Name = "addressTextBox";
            this.addressTextBox.ReadOnly = true;
            this.addressTextBox.Size = new System.Drawing.Size(326, 22);
            this.addressTextBox.TabIndex = 6;
            // 
            // cityTextBox
            // 
            this.cityTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.customersBindingSource, "City", true));
            this.cityTextBox.Location = new System.Drawing.Point(362, 189);
            this.cityTextBox.Name = "cityTextBox";
            this.cityTextBox.ReadOnly = true;
            this.cityTextBox.Size = new System.Drawing.Size(100, 22);
            this.cityTextBox.TabIndex = 8;
            // 
            // stateTextBox
            // 
            this.stateTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.customersBindingSource, "State", true));
            this.stateTextBox.Location = new System.Drawing.Point(468, 189);
            this.stateTextBox.Name = "stateTextBox";
            this.stateTextBox.ReadOnly = true;
            this.stateTextBox.Size = new System.Drawing.Size(61, 22);
            this.stateTextBox.TabIndex = 10;
            // 
            // zipCodeTextBox
            // 
            this.zipCodeTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.customersBindingSource, "ZipCode", true));
            this.zipCodeTextBox.Location = new System.Drawing.Point(535, 189);
            this.zipCodeTextBox.Name = "zipCodeTextBox";
            this.zipCodeTextBox.ReadOnly = true;
            this.zipCodeTextBox.Size = new System.Drawing.Size(153, 22);
            this.zipCodeTextBox.TabIndex = 12;
            // 
            // invoicesBindingSource
            // 
            this.invoicesBindingSource.DataMember = "FK_Invoices_Customers";
            this.invoicesBindingSource.DataSource = this.customersBindingSource;
            // 
            // invoicesDataGridView
            // 
            this.invoicesDataGridView.AutoGenerateColumns = false;
            this.invoicesDataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.invoicesDataGridView.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.dataGridViewTextBoxColumn1,
            this.dataGridViewTextBoxColumn3,
            this.dataGridViewTextBoxColumn4,
            this.dataGridViewTextBoxColumn5,
            this.dataGridViewTextBoxColumn6,
            this.dataGridViewTextBoxColumn7});
            this.invoicesDataGridView.DataSource = this.invoicesBindingSource;
            this.invoicesDataGridView.Location = new System.Drawing.Point(27, 245);
            this.invoicesDataGridView.Name = "invoicesDataGridView";
            this.invoicesDataGridView.RowTemplate.Height = 24;
            this.invoicesDataGridView.Size = new System.Drawing.Size(819, 220);
            this.invoicesDataGridView.TabIndex = 13;
            // 
            // dataGridViewTextBoxColumn1
            // 
            this.dataGridViewTextBoxColumn1.DataPropertyName = "InvoiceID";
            this.dataGridViewTextBoxColumn1.HeaderText = "InvoiceID";
            this.dataGridViewTextBoxColumn1.Name = "dataGridViewTextBoxColumn1";
            this.dataGridViewTextBoxColumn1.ReadOnly = true;
            // 
            // dataGridViewTextBoxColumn3
            // 
            this.dataGridViewTextBoxColumn3.DataPropertyName = "InvoiceDate";
            this.dataGridViewTextBoxColumn3.HeaderText = "InvoiceDate";
            this.dataGridViewTextBoxColumn3.Name = "dataGridViewTextBoxColumn3";
            // 
            // dataGridViewTextBoxColumn4
            // 
            this.dataGridViewTextBoxColumn4.DataPropertyName = "ProductTotal";
            this.dataGridViewTextBoxColumn4.HeaderText = "ProductTotal";
            this.dataGridViewTextBoxColumn4.Name = "dataGridViewTextBoxColumn4";
            // 
            // dataGridViewTextBoxColumn5
            // 
            this.dataGridViewTextBoxColumn5.DataPropertyName = "SalesTax";
            this.dataGridViewTextBoxColumn5.HeaderText = "SalesTax";
            this.dataGridViewTextBoxColumn5.Name = "dataGridViewTextBoxColumn5";
            // 
            // dataGridViewTextBoxColumn6
            // 
            this.dataGridViewTextBoxColumn6.DataPropertyName = "Shipping";
            this.dataGridViewTextBoxColumn6.HeaderText = "Shipping";
            this.dataGridViewTextBoxColumn6.Name = "dataGridViewTextBoxColumn6";
            // 
            // dataGridViewTextBoxColumn7
            // 
            this.dataGridViewTextBoxColumn7.DataPropertyName = "InvoiceTotal";
            this.dataGridViewTextBoxColumn7.HeaderText = "InvoiceTotal";
            this.dataGridViewTextBoxColumn7.Name = "dataGridViewTextBoxColumn7";
            // 
            // CustomerIDToolStrip
            // 
            this.CustomerIDToolStrip.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.CustomerIDToolStrip.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.customerIDToolStripLabel,
            this.customerIDToolStripTextBox,
            this.GetCustomerToolStripButton,
            this.toolStripSeparator1,
            this.GetAllCustomerstoolStripButton});
            this.CustomerIDToolStrip.Location = new System.Drawing.Point(0, 27);
            this.CustomerIDToolStrip.Name = "CustomerIDToolStrip";
            this.CustomerIDToolStrip.Size = new System.Drawing.Size(878, 27);
            this.CustomerIDToolStrip.TabIndex = 14;
            this.CustomerIDToolStrip.Text = "fillByCustomerIDToolStrip";
            // 
            // customerIDToolStripLabel
            // 
            this.customerIDToolStripLabel.Name = "customerIDToolStripLabel";
            this.customerIDToolStripLabel.Size = new System.Drawing.Size(94, 24);
            this.customerIDToolStripLabel.Text = "Customer ID:";
            // 
            // customerIDToolStripTextBox
            // 
            this.customerIDToolStripTextBox.Name = "customerIDToolStripTextBox";
            this.customerIDToolStripTextBox.Size = new System.Drawing.Size(100, 27);
            // 
            // GetCustomerToolStripButton
            // 
            this.GetCustomerToolStripButton.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Text;
            this.GetCustomerToolStripButton.Name = "GetCustomerToolStripButton";
            this.GetCustomerToolStripButton.Size = new System.Drawing.Size(103, 24);
            this.GetCustomerToolStripButton.Text = "Get Customer";
            this.GetCustomerToolStripButton.Click += new System.EventHandler(this.fillByCustomerIDToolStripButton_Click);
            // 
            // toolStripSeparator1
            // 
            this.toolStripSeparator1.Name = "toolStripSeparator1";
            this.toolStripSeparator1.Size = new System.Drawing.Size(6, 27);
            // 
            // GetAllCustomerstoolStripButton
            // 
            this.GetAllCustomerstoolStripButton.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Text;
            this.GetAllCustomerstoolStripButton.Image = ((System.Drawing.Image)(resources.GetObject("GetAllCustomerstoolStripButton.Image")));
            this.GetAllCustomerstoolStripButton.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.GetAllCustomerstoolStripButton.Name = "GetAllCustomerstoolStripButton";
            this.GetAllCustomerstoolStripButton.Size = new System.Drawing.Size(131, 24);
            this.GetAllCustomerstoolStripButton.Text = "Get All Customers";
            this.GetAllCustomerstoolStripButton.Click += new System.EventHandler(this.GetAllCustomerstoolStripButton_Click);
            // 
            // customerIDTextBox
            // 
            this.customerIDTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.customersBindingSource, "CustomerID", true));
            this.customerIDTextBox.Location = new System.Drawing.Point(362, 102);
            this.customerIDTextBox.Name = "customerIDTextBox";
            this.customerIDTextBox.ReadOnly = true;
            this.customerIDTextBox.Size = new System.Drawing.Size(100, 22);
            this.customerIDTextBox.TabIndex = 2;
            // 
            // CustomerInvoicesForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(878, 509);
            this.Controls.Add(this.CustomerIDToolStrip);
            this.Controls.Add(this.invoicesDataGridView);
            this.Controls.Add(customerIDLabel);
            this.Controls.Add(this.customerIDTextBox);
            this.Controls.Add(nameLabel);
            this.Controls.Add(this.nameTextBox);
            this.Controls.Add(addressLabel);
            this.Controls.Add(this.addressTextBox);
            this.Controls.Add(cityLabel);
            this.Controls.Add(this.cityTextBox);
            this.Controls.Add(this.stateTextBox);
            this.Controls.Add(this.zipCodeTextBox);
            this.Controls.Add(this.customersBindingNavigator);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            this.Name = "CustomerInvoicesForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Customer Invoices";
            this.Load += new System.EventHandler(this.CustomerInvoicesForm_Load);
            ((System.ComponentModel.ISupportInitialize)(this.mMABooksDataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.customersBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.customersBindingNavigator)).EndInit();
            this.customersBindingNavigator.ResumeLayout(false);
            this.customersBindingNavigator.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.invoicesBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.invoicesDataGridView)).EndInit();
            this.CustomerIDToolStrip.ResumeLayout(false);
            this.CustomerIDToolStrip.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private MMABooksDataSet mMABooksDataSet;
        private System.Windows.Forms.BindingSource customersBindingSource;
        private MMABooksDataSetTableAdapters.CustomersTableAdapter customersTableAdapter;
        private MMABooksDataSetTableAdapters.TableAdapterManager tableAdapterManager;
        private System.Windows.Forms.BindingNavigator customersBindingNavigator;
        private System.Windows.Forms.ToolStripButton bindingNavigatorAddNewItem;
        private System.Windows.Forms.ToolStripLabel bindingNavigatorCountItem;
        private System.Windows.Forms.ToolStripButton bindingNavigatorDeleteItem;
        private System.Windows.Forms.ToolStripButton bindingNavigatorMoveFirstItem;
        private System.Windows.Forms.ToolStripButton bindingNavigatorMovePreviousItem;
        private System.Windows.Forms.ToolStripSeparator bindingNavigatorSeparator;
        private System.Windows.Forms.ToolStripTextBox bindingNavigatorPositionItem;
        private System.Windows.Forms.ToolStripSeparator bindingNavigatorSeparator1;
        private System.Windows.Forms.ToolStripButton bindingNavigatorMoveNextItem;
        private System.Windows.Forms.ToolStripButton bindingNavigatorMoveLastItem;
        private System.Windows.Forms.ToolStripSeparator bindingNavigatorSeparator2;
        private System.Windows.Forms.ToolStripButton customersBindingNavigatorSaveItem;
        private System.Windows.Forms.TextBox nameTextBox;
        private System.Windows.Forms.TextBox addressTextBox;
        private System.Windows.Forms.TextBox cityTextBox;
        private System.Windows.Forms.TextBox stateTextBox;
        private System.Windows.Forms.TextBox zipCodeTextBox;
        private MMABooksDataSetTableAdapters.InvoicesTableAdapter invoicesTableAdapter;
        private System.Windows.Forms.BindingSource invoicesBindingSource;
        private System.Windows.Forms.DataGridView invoicesDataGridView;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn1;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn3;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn4;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn5;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn6;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn7;
        private System.Windows.Forms.ToolStrip CustomerIDToolStrip;
        private System.Windows.Forms.ToolStripLabel customerIDToolStripLabel;
        private System.Windows.Forms.ToolStripTextBox customerIDToolStripTextBox;
        private System.Windows.Forms.ToolStripButton GetCustomerToolStripButton;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator1;
        private System.Windows.Forms.ToolStripButton GetAllCustomerstoolStripButton;
        private System.Windows.Forms.TextBox customerIDTextBox;
    }
}