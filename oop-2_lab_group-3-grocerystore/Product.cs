using System;
using System.Collections.Generic;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TH_5_Group_3
{
    class Product
    {
        private string name;
        private string price;
        private string description;
        private string imagePath;
     
        public Product()
        {
        }

        public Product(string name, string price, string description, string imagePath)
        {
            this.name = name;
            this.price = price;
            this.description = description;
            this.imagePath = imagePath;
          
        }
        public string getName()
        {
            return this.name;
        }
        public void setName(String name)
        {
            this.name = name;
        }
        public string getPrice()
        {
            return this.price;
        }
        public void setPrice(string price)
        {
            this.price = price;
        }
        public string getDescription()
        {
            return this.description;
        }
        public void setDescription(string description)
        {
            this.description = description;
        }
        public string getImagePath()
        {
            return this.imagePath;
        }
        public void setImagePath(string imagePath)
        {
            this.imagePath = imagePath;
        }

        public override string ToString()
        {
            String viewforList = "-" + this.getName() + "  ------> Price of Pruduct:" + this.getPrice();
            return viewforList;
        }
    }
}
