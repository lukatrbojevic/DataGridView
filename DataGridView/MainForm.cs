using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.Entity;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace DataGridView
{
    public partial class MesovitaRoba : Form
    {
        readonly MesovitaRobaEntities db = new MesovitaRobaEntities();

        int EmpId = 0;

        purchase Purchase = new purchase();

        public MesovitaRoba()
        {
            InitializeComponent();
        }

        private void FillDataSource()
        {
            productBindingSource.DataSource = db.products.ToList();
            purchaseBindingSource.DataSource = db.purchases.ToList();
            supplierBindingSource.DataSource = db.suppliers.ToList();

        }

        private void MesovitaRoba_Load(object sender, EventArgs e)
        {
            dataGridView.AutoGenerateColumns = false;
            FillDataSource();
        }

        public void ClearData()
        {

            SupplierCombobox.SelectedValue = string.Empty;
            ProductCombobox.SelectedValue = string.Empty;
            NumberRecievedTextbox.Text = string.Empty;
            PurchaseDateDatetimePicker.Value = DateTime.Now;

            CancelButton.Enabled = false;
            DeleteButton.Enabled = false;
            AddButton.Text = "Add";
            EmpId = 0;
        }

        private void AddButton_Click(object sender, EventArgs e)
        {

            if (SupplierCombobox.SelectedValue != string.Empty  && ProductCombobox.SelectedValue != string.Empty && NumberRecievedTextbox.Text != string.Empty)
            {
                Purchase.SupplierId = (int)SupplierCombobox.SelectedValue;
                Purchase.ProductId = (int)ProductCombobox.SelectedValue;
                Purchase.NumberReceived = Convert.ToInt32(NumberRecievedTextbox.Text);
                Purchase.PurchaseDate = PurchaseDateDatetimePicker.Value;

                if (EmpId > 0)
                    db.Entry(Purchase).State = EntityState.Modified;
                else
                {
                    db.purchases.Add(Purchase);
                }
                db.SaveChanges();
                FillDataSource();
                ClearData();
            }
            else
            {
                MessageBox.Show("Molim vas unesite podatke");
            }
        
        }
        private void DataGridView_DoubleClick(object sender, EventArgs e)
        {
            if (dataGridView.CurrentCell.RowIndex != -1)
            {
                
                    EmpId = Convert.ToInt32(dataGridView.CurrentRow.Cells[0].Value);
                    Purchase = db.purchases.Where(x => x.id == EmpId).FirstOrDefault();
                    SupplierCombobox.SelectedValue = Purchase.SupplierId;
                    ProductCombobox.SelectedValue = Purchase.ProductId;
                    NumberRecievedTextbox.Text = Purchase.NumberReceived.ToString();
                    PurchaseDateDatetimePicker.Value = Purchase.PurchaseDate;
                
                
            }
            AddButton.Text = "Update";
            DeleteButton.Enabled = true;
            CancelButton.Enabled = true;
        }


        private void DeleteButton_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Are you sure you want to delete this record ?", "Delete ?", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
            {
               
                    db.purchases.Remove(Purchase);
                    db.SaveChanges();
                    FillDataSource();
                    ClearData();
                
            }
        }

        private void CancelButton_Click(object sender, EventArgs e)
        {
           ClearData(); 
        }
    }

}
