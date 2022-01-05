namespace DataGridView
{
    partial class MesovitaRoba
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
            this.dataGridView = new System.Windows.Forms.DataGridView();
            this.idDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.numberReceivedDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.purchaseDateDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.productDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewComboBoxColumn();
            this.productBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.supplierDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewComboBoxColumn();
            this.supplierBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.purchaseBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.ProductCombobox = new System.Windows.Forms.ComboBox();
            this.SupplierCombobox = new System.Windows.Forms.ComboBox();
            this.NumberRecievedTextbox = new System.Windows.Forms.TextBox();
            this.PurchaseDateDatetimePicker = new System.Windows.Forms.DateTimePicker();
            this.AddButton = new System.Windows.Forms.Button();
            this.NumberRecievedLabel = new System.Windows.Forms.Label();
            this.PurchaseDateLabel = new System.Windows.Forms.Label();
            this.ProductLabel = new System.Windows.Forms.Label();
            this.SupplierLabel = new System.Windows.Forms.Label();
            this.DeleteButton = new System.Windows.Forms.Button();
            this.CancelButton = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.productBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.supplierBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.purchaseBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // dataGridView
            // 
            this.dataGridView.AllowUserToAddRows = false;
            this.dataGridView.AllowUserToDeleteRows = false;
            this.dataGridView.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.dataGridView.AutoGenerateColumns = false;
            this.dataGridView.BackgroundColor = System.Drawing.SystemColors.Menu;
            this.dataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.DisableResizing;
            this.dataGridView.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.idDataGridViewTextBoxColumn,
            this.numberReceivedDataGridViewTextBoxColumn,
            this.purchaseDateDataGridViewTextBoxColumn,
            this.productDataGridViewTextBoxColumn,
            this.supplierDataGridViewTextBoxColumn});
            this.dataGridView.DataSource = this.purchaseBindingSource;
            this.dataGridView.Location = new System.Drawing.Point(12, 233);
            this.dataGridView.Name = "dataGridView";
            this.dataGridView.ReadOnly = true;
            this.dataGridView.Size = new System.Drawing.Size(776, 205);
            this.dataGridView.TabIndex = 0;
            this.dataGridView.DoubleClick += DataGridView_DoubleClick;
            // 
            // idDataGridViewTextBoxColumn
            // 
            this.idDataGridViewTextBoxColumn.DataPropertyName = "id";
            this.idDataGridViewTextBoxColumn.HeaderText = "ID";
            this.idDataGridViewTextBoxColumn.Name = "idDataGridViewTextBoxColumn";
            this.idDataGridViewTextBoxColumn.ReadOnly = true;
            this.idDataGridViewTextBoxColumn.Visible = false;
            // 
            // numberReceivedDataGridViewTextBoxColumn
            // 
            this.numberReceivedDataGridViewTextBoxColumn.DataPropertyName = "NumberReceived";
            this.numberReceivedDataGridViewTextBoxColumn.HeaderText = "Number Received";
            this.numberReceivedDataGridViewTextBoxColumn.Name = "numberReceivedDataGridViewTextBoxColumn";
            this.numberReceivedDataGridViewTextBoxColumn.ReadOnly = true;
            this.numberReceivedDataGridViewTextBoxColumn.Width = 183;
            // 
            // purchaseDateDataGridViewTextBoxColumn
            // 
            this.purchaseDateDataGridViewTextBoxColumn.DataPropertyName = "PurchaseDate";
            this.purchaseDateDataGridViewTextBoxColumn.HeaderText = "Purchase Date";
            this.purchaseDateDataGridViewTextBoxColumn.Name = "purchaseDateDataGridViewTextBoxColumn";
            this.purchaseDateDataGridViewTextBoxColumn.ReadOnly = true;
            this.purchaseDateDataGridViewTextBoxColumn.Width = 184;
            // 
            // productDataGridViewTextBoxColumn
            // 
            this.productDataGridViewTextBoxColumn.DataPropertyName = "ProductId";
            this.productDataGridViewTextBoxColumn.DataSource = this.productBindingSource;
            this.productDataGridViewTextBoxColumn.DisplayMember = "ProductName";
            this.productDataGridViewTextBoxColumn.HeaderText = "Product";
            this.productDataGridViewTextBoxColumn.Name = "productDataGridViewTextBoxColumn";
            this.productDataGridViewTextBoxColumn.ReadOnly = true;
            this.productDataGridViewTextBoxColumn.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            this.productDataGridViewTextBoxColumn.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.Automatic;
            this.productDataGridViewTextBoxColumn.ValueMember = "id";
            this.productDataGridViewTextBoxColumn.Width = 183;
            // 
            // productBindingSource
            // 
            this.productBindingSource.DataSource = typeof(DataGridView.product);
            // 
            // supplierDataGridViewTextBoxColumn
            // 
            this.supplierDataGridViewTextBoxColumn.DataPropertyName = "SupplierId";
            this.supplierDataGridViewTextBoxColumn.DataSource = this.supplierBindingSource;
            this.supplierDataGridViewTextBoxColumn.DisplayMember = "supplier1";
            this.supplierDataGridViewTextBoxColumn.HeaderText = "Supplier";
            this.supplierDataGridViewTextBoxColumn.Name = "supplierDataGridViewTextBoxColumn";
            this.supplierDataGridViewTextBoxColumn.ReadOnly = true;
            this.supplierDataGridViewTextBoxColumn.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            this.supplierDataGridViewTextBoxColumn.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.Automatic;
            this.supplierDataGridViewTextBoxColumn.ValueMember = "id";
            this.supplierDataGridViewTextBoxColumn.Width = 183;
            // 
            // supplierBindingSource
            // 
            this.supplierBindingSource.DataSource = typeof(DataGridView.supplier);
            // 
            // purchaseBindingSource
            // 
            this.purchaseBindingSource.DataSource = typeof(DataGridView.purchase);
            // 
            // ProductCombobox
            // 
            this.ProductCombobox.DataSource = this.productBindingSource;
            this.ProductCombobox.DisplayMember = "ProductName";
            this.ProductCombobox.FormattingEnabled = true;
            this.ProductCombobox.Location = new System.Drawing.Point(111, 127);
            this.ProductCombobox.Name = "ProductCombobox";
            this.ProductCombobox.Size = new System.Drawing.Size(121, 21);
            this.ProductCombobox.TabIndex = 1;
            this.ProductCombobox.ValueMember = "id";
            // 
            // SupplierCombobox
            // 
            this.SupplierCombobox.DataSource = this.supplierBindingSource;
            this.SupplierCombobox.DisplayMember = "supplier1";
            this.SupplierCombobox.FormattingEnabled = true;
            this.SupplierCombobox.Location = new System.Drawing.Point(111, 154);
            this.SupplierCombobox.Name = "SupplierCombobox";
            this.SupplierCombobox.Size = new System.Drawing.Size(121, 21);
            this.SupplierCombobox.TabIndex = 2;
            this.SupplierCombobox.ValueMember = "id";
            // 
            // NumberRecievedTextbox
            // 
            this.NumberRecievedTextbox.Location = new System.Drawing.Point(111, 75);
            this.NumberRecievedTextbox.Name = "NumberRecievedTextbox";
            this.NumberRecievedTextbox.Size = new System.Drawing.Size(50, 20);
            this.NumberRecievedTextbox.TabIndex = 3;
            // 
            // PurchaseDateDatetimePicker
            // 
            this.PurchaseDateDatetimePicker.Location = new System.Drawing.Point(111, 101);
            this.PurchaseDateDatetimePicker.Name = "PurchaseDateDatetimePicker";
            this.PurchaseDateDatetimePicker.Size = new System.Drawing.Size(200, 20);
            this.PurchaseDateDatetimePicker.TabIndex = 4;
            // 
            // AddButton
            // 
            this.AddButton.Location = new System.Drawing.Point(12, 193);
            this.AddButton.Name = "AddButton";
            this.AddButton.Size = new System.Drawing.Size(75, 23);
            this.AddButton.TabIndex = 5;
            this.AddButton.Text = "Add";
            this.AddButton.UseVisualStyleBackColor = true;
            this.AddButton.Click += AddButton_Click;
            // 
            // NumberRecievedLabel
            // 
            this.NumberRecievedLabel.AutoSize = true;
            this.NumberRecievedLabel.Location = new System.Drawing.Point(12, 75);
            this.NumberRecievedLabel.Name = "NumberRecievedLabel";
            this.NumberRecievedLabel.Size = new System.Drawing.Size(93, 13);
            this.NumberRecievedLabel.TabIndex = 6;
            this.NumberRecievedLabel.Text = "Number Recieved";
            // 
            // PurchaseDateLabel
            // 
            this.PurchaseDateLabel.AutoSize = true;
            this.PurchaseDateLabel.Location = new System.Drawing.Point(12, 101);
            this.PurchaseDateLabel.Name = "PurchaseDateLabel";
            this.PurchaseDateLabel.Size = new System.Drawing.Size(78, 13);
            this.PurchaseDateLabel.TabIndex = 7;
            this.PurchaseDateLabel.Text = "Purchase Date";
            // 
            // ProductLabel
            // 
            this.ProductLabel.AutoSize = true;
            this.ProductLabel.Location = new System.Drawing.Point(12, 127);
            this.ProductLabel.Name = "ProductLabel";
            this.ProductLabel.Size = new System.Drawing.Size(44, 13);
            this.ProductLabel.TabIndex = 8;
            this.ProductLabel.Text = "Product";
            // 
            // SupplierLabel
            // 
            this.SupplierLabel.AutoSize = true;
            this.SupplierLabel.Location = new System.Drawing.Point(12, 154);
            this.SupplierLabel.Name = "SupplierLabel";
            this.SupplierLabel.Size = new System.Drawing.Size(45, 13);
            this.SupplierLabel.TabIndex = 9;
            this.SupplierLabel.Text = "Supplier";
            // 
            // DeleteButton
            // 
            this.DeleteButton.Enabled = false;
            this.DeleteButton.Location = new System.Drawing.Point(111, 193);
            this.DeleteButton.Name = "DeleteButton";
            this.DeleteButton.Size = new System.Drawing.Size(75, 23);
            this.DeleteButton.TabIndex = 10;
            this.DeleteButton.Text = "Delete";
            this.DeleteButton.UseVisualStyleBackColor = true;
            this.DeleteButton.Click += DeleteButton_Click;
            // 
            // CancelButton
            // 
            this.CancelButton.Location = new System.Drawing.Point(201, 193);
            this.CancelButton.Name = "CancelButton";
            this.CancelButton.Size = new System.Drawing.Size(75, 23);
            this.CancelButton.TabIndex = 11;
            this.CancelButton.Text = "Cancel";
            this.CancelButton.UseVisualStyleBackColor = true;
            this.CancelButton.Enabled = false;
            this.CancelButton.Click += CancelButton_Click;
            // 
            // MesovitaRoba
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.CancelButton);
            this.Controls.Add(this.DeleteButton);
            this.Controls.Add(this.SupplierLabel);
            this.Controls.Add(this.ProductLabel);
            this.Controls.Add(this.PurchaseDateLabel);
            this.Controls.Add(this.NumberRecievedLabel);
            this.Controls.Add(this.AddButton);
            this.Controls.Add(this.PurchaseDateDatetimePicker);
            this.Controls.Add(this.NumberRecievedTextbox);
            this.Controls.Add(this.SupplierCombobox);
            this.Controls.Add(this.ProductCombobox);
            this.Controls.Add(this.dataGridView);
            this.Name = "MesovitaRoba";
            this.Text = "Mesovita roba";
            this.Load += new System.EventHandler(this.MesovitaRoba_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.productBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.supplierBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.purchaseBindingSource)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dataGridView;
        private System.Windows.Forms.BindingSource productBindingSource;
        private System.Windows.Forms.BindingSource supplierBindingSource;
        private System.Windows.Forms.BindingSource purchaseBindingSource;
        private System.Windows.Forms.ComboBox ProductCombobox;
        private System.Windows.Forms.ComboBox SupplierCombobox;
        private System.Windows.Forms.TextBox NumberRecievedTextbox;
        private System.Windows.Forms.DateTimePicker PurchaseDateDatetimePicker;
        private System.Windows.Forms.Button AddButton;
        private System.Windows.Forms.DataGridViewTextBoxColumn idDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn numberReceivedDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn purchaseDateDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewComboBoxColumn productDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewComboBoxColumn supplierDataGridViewTextBoxColumn;
        private System.Windows.Forms.Label NumberRecievedLabel;
        private System.Windows.Forms.Label PurchaseDateLabel;
        private System.Windows.Forms.Label ProductLabel;
        private System.Windows.Forms.Label SupplierLabel;
        private System.Windows.Forms.Button DeleteButton;
        private System.Windows.Forms.Button CancelButton;
    }
}

