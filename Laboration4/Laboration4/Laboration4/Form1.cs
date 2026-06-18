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
    public partial class Form1 : Form
    {

        Lagerhantering lagerhantering;
        Kassa kassa;


        Lager lager;
        BindingSource ProductListSource; 

        public Form1()
        {
            InitializeComponent();
            ProductListSource = new BindingSource();
            lager = new Lager();
            lager.LoadProductsFromCSV("products.csv");
            ProductListSource.DataSource = lager.ProductList;
        }

        private void Lagerknapp_Click(object sender, EventArgs e)
        {
            if(lagerhantering == null || lagerhantering.IsDisposed)
            {
                lagerhantering = new Lagerhantering(lager, ProductListSource);

            }
            lagerhantering.Show();
        }

        private void Kassaknapp_Click(object sender, EventArgs e)
        {

            if(kassa == null || kassa.IsDisposed)
            {
             kassa = new Kassa(lager, ProductListSource);

            }
            kassa.Show();

        }

        private void Avsluta_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }
    }
}
