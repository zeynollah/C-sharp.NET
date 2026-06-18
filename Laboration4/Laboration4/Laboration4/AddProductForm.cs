    using System;
    using System.Collections.Generic;
    using System.ComponentModel;
    using System.Data;
    using System.Drawing;
    using System.Linq;
    using System.Text;
    using System.Threading.Tasks;
    using System.Windows.Forms;

    namespace Laboration4
    {
        public partial class AddProductForm : Form
        {
            public BindingSource ProductListSource { get; set; }
            public Lager lager { get; set; }
            public Product Product { get; private set; }  


        public AddProductForm()
            {
                InitializeComponent();

            }

        private void AddButton_Click(object sender, EventArgs e)
        {

            try {
            


                string newID = IDbox.Text.Trim();
                string playtimeText = PlayetimeBox.Text.Trim();

                if (string.IsNullOrEmpty(newID))
                {
                    MessageBox.Show("Product ID shoud not be empty.");
                    return;
                }

                if (!int.TryParse(newID, out _))
                {
                    MessageBox.Show("Product ID must be a number (no letters or symbols).");
                    return;
                }

                if (string.IsNullOrWhiteSpace(Namebox.Text))
                {
                    MessageBox.Show("You have to give a name to the product!");
                    return;
                }

                if (string.IsNullOrWhiteSpace(Pricebox.Text))
                {
                    MessageBox.Show("You have to give a Price to the product!");
                    return;
                }

                if (!int.TryParse(Pricebox.Text.Trim(), out int price) || price < 0)
                {
                    MessageBox.Show("Please enter a valid, non-negative number for price.");
                    return;
                }

                if (ProductListSource.List.OfType<Product>().Any(p => p.ID == newID))
                {
                    MessageBox.Show("Product ID already exists!");
                    return;
                }

                if (!int.TryParse(Amountbox.Text.Trim(), out int amount) || amount < 0)
                {
                    MessageBox.Show("Please enter a valid, non-negative number for Amount.");
                    return;
                }


                if (!string.IsNullOrEmpty(playtimeText)) 
                {
                    if (!int.TryParse(playtimeText, out int playtime) || playtime < 0)
                    {
                        MessageBox.Show("Please enter a valid, non-negative number for playtime.");
                        return;
                    }
                }

                Product = new Product
                {

                    ID = IDbox.Text,
                    Name = Namebox.Text,
                    Price = Pricebox.Text,
                    Author = AuthorBox.Text,
                    Amount = Amountbox.Text,
                    Format = FormatBox.Text,
                    Platform = Platformbox.Text,
                    Language = LanguageBox.Text,
                    Playtime = PlayetimeBox.Text
                };



                lager.SaveProductsToCSV("products.csv");
                MessageBox.Show("You have added a new product!");
                DialogResult = DialogResult.OK;
                Close();

            }
            catch (Exception ex)
            {
                MessageBox.Show($"An error occurred: {ex.Message}");
            }
            }

            private void CancelButton_Click(object sender, EventArgs e)
            {
                DialogResult = DialogResult.Cancel; 
               Close();
            }

        private void AddProductForm_Load(object sender, EventArgs e)
        {

        }
    }
    }
