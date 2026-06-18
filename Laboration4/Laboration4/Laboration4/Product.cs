using System;

namespace Laboration4
{
    public class Product
    {
        public string ID { get; set; }
        public string Name { get; set;}
        public string Price { get; set;}
        public string Author { get; set; }
        public string Amount { get; set;}
        public string Format { get; set; }
        public string Platform { get; set; }
        public string Language { get; set; }
        public string Playtime { get; set; }
      


        public Product() { }
 
        public Product(string id, string name, string price, string author,
            string amount, string format,string platform, string language, string playtime)
        {

            ID = id;
            Name = name;
            Price = price;
            Author = author;
            Amount = amount;
            Format = format;
            Platform = platform;
            Language = language;
           Playtime = playtime;
        }

       
    }
}