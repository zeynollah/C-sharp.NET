using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Microsoft.VisualBasic;

namespace Laboration4
{
    public partial class Lagerhantering : Form
    {
        BindingSource ProductListSource;
        private Lager lager;



        public Lagerhantering(Lager lager, BindingSource productListSource)
        {
            InitializeComponent();
            this.ProductListSource = productListSource;
            this.lager = lager;
            ProductDataGrid.DataSource = ProductListSource;
           
        }

        private void Removebutton_Click(object sender, EventArgs e)
        {
            if (ProductDataGrid.SelectedRows.Count < 1)
            {
                MessageBox.Show("Select a product to remove!");
                return;
            }

            var product = (Product)ProductDataGrid.SelectedRows[0].DataBoundItem;

            try
            {
                //eftersome Amount är en sträng i min klass så måste jag konvertera den till int  

                if (int.TryParse(product.Amount, out int amount))
                {

                    if (amount > 0)
                    {
                        var result = MessageBox.Show("The amount of product is greater than 0. Are you sure you want to remove it?",
                                                      "Confirm Remove",
                                                      MessageBoxButtons.YesNo,
                                                      MessageBoxIcon.Warning);


                        if (result == DialogResult.Yes)
                        {
                            ProductListSource.Remove(product);
                            lager.SaveProductsToCSV("products.csv");
                            MessageBox.Show("Product removed successfully!");
                        }
                        else
                        {
                            MessageBox.Show("Product removal canceled.");
                        }
                    }
                    else
                    {
                        ProductListSource.Remove(product);
                        lager.SaveProductsToCSV("products.csv");
                        MessageBox.Show("Product removed successfully!");
                    }
                }
                else
                {
                    MessageBox.Show("Invalid amount entered! Please enter a valid number.");
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Error: Invalid amount format. {ex.Message}");
            }
        }

        
        private void Addbutton_Click(object sender, EventArgs e)
        {
            
            var addProductForm = new AddProductForm
            {
                ProductListSource = this.ProductListSource,
                lager = this.lager
            };
            

            addProductForm.StartPosition = FormStartPosition.CenterParent;

            if (addProductForm.ShowDialog() == DialogResult.OK)
            {
                Product newProduct = addProductForm.Product;

                ProductListSource.Add(newProduct);
                lager.SaveProductsToCSV("products.csv");
                MessageBox.Show("Product added successfully!");
            }
        }


        private void Lagerhantering_Load(object sender, EventArgs e)
        {
            ProductListSource.Clear();
            lager.LoadProductsFromCSV("products.csv");
            ProductDataGrid.ClearSelection();

        }

        private void UpdateButton_Click(object sender, EventArgs e)
        {
            try
            {
                if (ProductDataGrid.SelectedRows.Count < 1)
                {
                    MessageBox.Show("No product selected. Please select a product to update.");
                    return;
                }

                var product = (Product)ProductDataGrid.SelectedRows[0].DataBoundItem;

                string newAmountString = Microsoft.VisualBasic.Interaction.InputBox("Enter new amount:", "Update Amount", product.Amount);

                if (string.IsNullOrEmpty(newAmountString))
                {
                    MessageBox.Show("Amount cannot be empty.");
                    return;
                }

                if (int.TryParse(newAmountString, out int newAmount) && newAmount >= 0)
                {
                    product.Amount = newAmount.ToString();

                    ProductListSource.ResetBindings(false);
                    lager.SaveProductsToCSV("products.csv");

                    MessageBox.Show("Amount updated successfully!");
                }
                else
                {
                    MessageBox.Show("Invalid amount entered! Please enter a positive number.");
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Error: Invalid amount format. {ex.Message}");
            }


        }
    }

}