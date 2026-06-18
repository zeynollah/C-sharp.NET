using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;

namespace Laboration3
{
    public partial class Form1 : Form
    {
        private string aktuellFil = "namnlöst.txt";
        private bool ändrad = false;

        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void Spara(object sender, EventArgs e)
        {
            try
            {
                if (aktuellFil == "namnlöst.txt")
                {
                    SparaSom(sender, e);
                }
                else
                {
                    File.WriteAllText(aktuellFil, textBox1.Text);
                    ändrad = false;
                    UppdateraTitle();
                }
            }
            catch (Exception)
            {
                MessageBox.Show("Något har gått när du försökte spara!");
            }

        }

        private void SparaSom(object sender, EventArgs e)
        {
            try
            {
                SaveFileDialog sfd = new SaveFileDialog();
                sfd.Filter = "Text File|*.txt";
                sfd.FileName = "namnlöst.txt";
                sfd.RestoreDirectory = true;
                if (sfd.ShowDialog() == System.Windows.Forms.DialogResult.OK)
                {
                    string path = sfd.FileName;
                    File.WriteAllText(path, textBox1.Text);
                    ändrad = false;
                    UppdateraTitle();
                }
            }
            catch (Exception)
            {
                MessageBox.Show("Fel vi sparning av fil!");

            }

        }

        private void Rensa(object sender, EventArgs e)
        {
            try
            {

                if (ändrad)
                {
                    DialogResult result = MessageBox.Show(
                        "Vill du spara?",
                        "Spara ändringar",
                        MessageBoxButtons.YesNoCancel,
                        MessageBoxIcon.Warning);

                    if (result == DialogResult.Cancel)
                    {
                        return;
                    }
                    if (result == DialogResult.Yes)
                    {
                        Spara(sender, e);
                    }

                }
                textBox1.Clear();
                aktuellFil = "namnlös.txt";
                ändrad = false;
                UppdateraTitle();
            }
            catch (Exception)
            {
                MessageBox.Show("Fel har fångats i catch-blocket!");
            }
        }
        private void UppdateraTitle()
        {
            this.Text = (ändrad ? "*" : "") + aktuellFil;
        }


        private void textBox1_TextChanged(object sender, EventArgs e)
        {
            ändrad = true;
            UppdateraTitle();
        }
        private void Öpnna(object sender, EventArgs e)
        {
            try
            {
                if (ändrad)
                {

                    DialogResult result = MessageBox.Show(
                      "Vill du spara ändringar innan du öppnar en ny fil?",
                      "Spara ändringar",
                      MessageBoxButtons.YesNoCancel,
                      MessageBoxIcon.Warning);

                    if (result == DialogResult.Cancel)
                    {
                        return;
                    }
                    if (result == DialogResult.Yes)
                    {
                        Spara(sender, e);
                    }

                }

                OpenFileDialog ofd = new OpenFileDialog();
                ofd.FileName = "My Text file";
                ofd.RestoreDirectory = true;
                if (ofd.ShowDialog() == System.Windows.Forms.DialogResult.OK)
                {
                    textBox1.Text = File.ReadAllText(ofd.FileName);
                    aktuellFil = ofd.SafeFileName;
                    ändrad = false;
                    UppdateraTitle();
                }

            }
            catch (Exception)
            {
                MessageBox.Show("Något har gått fel vid öpning av en fil!");
            }
        }

        private void Avsluta(object sender, EventArgs e)
        {
            try
            {
                if (ändrad)
                {
                    DialogResult result = MessageBox.Show(
                   "Vill du spara ändringar innan du avslutar?",
                   "Spara ändringar",
                   MessageBoxButtons.YesNoCancel,
                   MessageBoxIcon.Warning);

                    if (result == DialogResult.Cancel)
                    {
                        return;
                    }
                    if (result == DialogResult.Yes)
                    {
                        Spara(sender, e);
                    }

                }
            }
            catch (Exception)
            {
                MessageBox.Show("Något gick fel ");
            }
            Application.Exit();
        }
    }
}
