using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace TH_5_Group_3
{
    static class Program
    {
        /// <summary>
        /// The main entry point for the application.
        /// </summary>
       
        [STAThread]
        static void Main()
        {
            ProductList productFactory = new ProductList();
            string tomatoPath = Path.Combine(Environment.CurrentDirectory, @"Data\", "tomato.png");
            string potatoPath = Path.Combine(Environment.CurrentDirectory, @"Data\", "potato.png");
            string sugarPath = Path.Combine(Environment.CurrentDirectory, @"Data\", "sugar.png");
            string saltPath = Path.Combine(Environment.CurrentDirectory, @"Data\", "salt.png");
            string olivePath = Path.Combine(Environment.CurrentDirectory, @"Data\", "olive.png");
            string breadPath = Path.Combine(Environment.CurrentDirectory, @"Data\", "bread.png");
            string gumPath = Path.Combine(Environment.CurrentDirectory, @"Data\", "gum.png");
            string sausagePath = Path.Combine(Environment.CurrentDirectory, @"Data\", "sausage.png");
            string cucumberPath = Path.Combine(Environment.CurrentDirectory, @"Data\", "cucumber.png");
            string pepperPath = Path.Combine(Environment.CurrentDirectory, @"Data\", "pepper.png");






            productFactory.ProductFactory("Tomato", "5 TL", "Organic Red Tomatoes From The Farm", tomatoPath);
            productFactory.ProductFactory("Potato", "5 TL", "Fresh ripe potatoes", potatoPath);
            productFactory.ProductFactory("Sugar", "3 TL", "Turkish made beet sugar", sugarPath);
            productFactory.ProductFactory("Salt", "3 TL", "Rock salt, very cheap !!", saltPath);
            productFactory.ProductFactory("Olive", "5 TL", "Organic green olives from the gardens of the Aegean", olivePath);
            productFactory.ProductFactory("Bread", "2 TL", "Stone oven bread, regret not taking it!!", breadPath);
            productFactory.ProductFactory("Gum", "1 TL", "Homemade mint flavored chewing gum", gumPath);
            productFactory.ProductFactory("Sausage", "30 TL", "Halis mulis sauage from Kayseri", sausagePath);
            productFactory.ProductFactory("Cucumber", "6 TL", "Organic well nourished cucumber", cucumberPath);
            productFactory.ProductFactory("Pepper", "4 TL", "Hot pepper, very hot !!", pepperPath);

            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            Application.Run(new Bazaar());
        }
    }
}
