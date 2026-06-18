using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Laboration4
{
   public class Lager
    {
        public BindingList<Product> ProductList { get; private set; }
        public void LoadProductsFromCSV(string filePath)
        {
            if (!File.Exists(filePath)) return;

            string[] lines = File.ReadAllLines(filePath);
            if (lines.Length <= 1) return;
            //hoppar över första raden och läser in resten
            foreach (string line in lines.Skip(1))
            {
                string[] values = line.Split(',');

                // om raden inte har 9 delar hoppa över den
                if (values.Length < 9)
                {
                    Console.WriteLine("Incorrect row in CSV" + line);
                    continue; 
                }

                Product product = new Product
                {
                    ID = values[0],
                    Name = values[1],
                    Price = values[2],
                    Author = values[3],
                    Amount = values[4],
                    Format = values[5],
                    Platform = values[6],
                    Language = values[7],
                    Playtime = values[8],
                };

                ProductList.Add(product);
            }
            
        }
        /*
         * skapas en tom lista sedan läggs till rubriker i listan,
         * loopar igenom alla produkter och formaterar varje produkt till en CSV-rad
         * raden läggs till i listan och skriver alla rader till filen
        */

        public void SaveProductsToCSV(string filePath)
        {
            List<string> lines = new List<string>();
            lines.Add("ID,Name,Price,Author,Amount,Format,Platform,Language,Playtime");

            foreach(var product in ProductList)
            {
                string line = $"{EscapeCsv(product.ID)}," +
                     $"{EscapeCsv(product.Name)}," +
                     $"{EscapeCsv(product.Price)}," +
                     $"{EscapeCsv(product.Author)}," +
                     $"{EscapeCsv(product.Amount)}," +
                     $"{EscapeCsv(product.Format)}," +
                     $"{EscapeCsv(product.Platform)}," +
                     $"{EscapeCsv(product.Language)}," +
                     $"{EscapeCsv(product.Playtime)}";
                lines.Add(line);
            }

            File.WriteAllLines(filePath, lines);
        }

        /*denna metod tar en sträng som argument, sedan kollar om strängen innehåller ett tomt fält,
         * om fältet innehåller , eller " value.Replace gör om det till dubbel-citat.
         
         */
        private string EscapeCsv(string value)
        {
            if (string.IsNullOrWhiteSpace(value))
                return ""; 

            
            if (value.Contains(",") || value.Contains("\""))
                return $"\"{value.Replace("\"", "\"\"")}\"";

            return value;
        }


        public Lager()
        {
            ProductList = new BindingList<Product>();

        }
    }
}
