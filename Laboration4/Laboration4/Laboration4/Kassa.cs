using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Laboration4
{
    public partial class Kassa : Form
    {



        private BindingSource ProductListSource;


        public Kassa(Lager lager, BindingSource productListSource)
        {
            InitializeComponent();

            ProductListSource = productListSource;

            ProductDataGrid.DataSource = productListSource;

        }

        public Kassa(BindingSource productListSource)
        {
            ProductListSource = productListSource;
        }


        private void Addbutton_Click(object sender, EventArgs e)
        {

          if(ProductDataGrid.SelectedRows.Count == 0)
            {
                MessageBox.Show("You have to select a product");
                return;
            }
            var product = (Product)ProductDataGrid.SelectedRows[0].DataBoundItem;
            

            var selectedrow = ProductDataGrid.SelectedRows[0];
            

            try
            {


                string productname = selectedrow.Cells["Name"].Value.ToString();
                string price = selectedrow.Cells["Price"].Value.ToString();
                
                if(int.TryParse(selectedrow.Cells["Amount"].Value.ToString(), out int amount))
                {
                    if(amount == 0)
                    {
                        MessageBox.Show("This product is not available right now!");
                        return;
                    }
                }
                
                if (decimal.TryParse(price, out decimal productPrice))
                {
                    
                    Cartlist.Items.Add($"{productname} - {productPrice} kr");
                    int tempt = int.Parse(product.Amount);
                    tempt -= 1;
                    product.Amount = tempt.ToString();
                }

                else
                {
                    MessageBox.Show("Could not read the price from the product!");
                }

            }
            catch (Exception ex)
            {
                MessageBox.Show("Error to add product: " + ex.Message);

            }

        }

        private void ConfirmButton_Click(object sender, EventArgs e)
        {
            if(Cartlist.Items.Count == 0)
            {
                MessageBox.Show("Cart is empty!");
                return;
            }

            Cartlist.Items.Clear();
            MessageBox.Show("Purchase completed!");
           
        }

        private void Kassa_Load_1(object sender, EventArgs e)
        {
            
            ProductDataGrid.ClearSelection();

        }

        private void CancelButton_Click(object sender, EventArgs e)
        {
            if(Cartlist.SelectedIndex != -1)
            {
                Cartlist.Items.RemoveAt(Cartlist.SelectedIndex);
            }else
            {
                MessageBox.Show("You have to select a product!");
            }
        }
    }
}
