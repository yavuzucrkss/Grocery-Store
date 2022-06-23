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

namespace TH_5_Group_3
{   
    public partial class Bazaar : Form
    {

        public int id;
        public int TotalAmount = 0;
        Listing listing = new Listing();
        ProductList productFactory = new ProductList();
        List<Product> shoppingCard = new List<Product>();
       
        public Bazaar()
        {
            InitializeComponent();
        }
       
   
        private void Bazaar_Load(object sender, EventArgs e)
        {
            string cardPAth = Path.Combine(Environment.CurrentDirectory, @"Data\", "card.png");
            pictureBox3.ImageLocation = cardPAth;

            addtocartBtn.Text = "Products";
            pieceLbl.Text = "Card";
            tabPage3.Text = "Admin";


            listing.producttoListVİew(listView1, productFactory.getList());
            listing.producttoListVİew(listView3, productFactory.getList());
  
        }

        private void addButton_Click(object sender, EventArgs e)
        {
            Product newProduct = new Product(nametextBox.Text, priceTextBox.Text, descriptionTextBox.Text, pictureBox1.ImageLocation);
            productFactory.getList().Add(newProduct);
            listing.producttoListVİew(listView1, productFactory.getList());
            listing.producttoListVİew(listView3, productFactory.getList());
        }

        private void updateButton_Click(object sender, EventArgs e)
        {
            try
            {
                int id = Convert.ToInt32(idLabel.Text);
                productFactory.getList()[id].setName(nametextBox.Text);
                productFactory.getList()[id].setPrice(priceTextBox.Text);
                productFactory.getList()[id].setDescription(descriptionTextBox.Text);
                productFactory.getList()[id].setImagePath(pictureBox1.ImageLocation);
                listing.producttoListVİew(listView1, productFactory.getList());
                listing.producttoListVİew(listView3, productFactory.getList());
                MessageBox.Show("Updated!");
            }
            catch (Exception)
            {

                MessageBox.Show("No product selected");
            }
        }

        private void deleteButton_Click(object sender, EventArgs e)
        {
            try
            {
                int id = Convert.ToInt32(idLabel.Text);
                productFactory.getList().Remove(productFactory.getList()[id]);
                MessageBox.Show("Deleted!");
                listing.producttoListVİew(listView1, productFactory.getList());
                listing.producttoListVİew(listView3, productFactory.getList());

            }
            catch (Exception)
            {
                MessageBox.Show("No product selected");
            }
        }

        private void linkLabel1_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
           try
            {
                openFileDialog1.ShowDialog();
                pictureBox3.ImageLocation = openFileDialog1.FileName;
                path.Text = openFileDialog1.FileName;

            }
            catch (Exception)
            {
                MessageBox.Show("Please select an image");
            }
        }


        private void listView1_MouseDoubleClick(object sender, MouseEventArgs e)
        {
            ProductsDetail fr = new ProductsDetail();
            fr.id = listView1.FocusedItem.Index;
            fr.Show();
            id = listView1.FocusedItem.Index;
        }

        private void addToShoppingCard(object sender, EventArgs e) //Add to Card
        {
            try
            {
                shoppingCard.Add(productFactory.getList()[id]);
                listing.producttoListVİew(listView2, shoppingCard);

                TotalAmount += Convert.ToInt32(productFactory.getList()[id].getPrice().Substring(0, 2));
                priceLabel.Text = TotalAmount.ToString();
                idLbl.Text = id.ToString();
                nameLbl.Text = productFactory.getList()[id].getName();
                priceLbl.Text = productFactory.getList()[id].getPrice();
                pictureBox4.ImageLocation = productFactory.getList()[id].getImagePath();
                MessageBox.Show("The product has been added to cart");
            }
            catch (Exception)
            {

                MessageBox.Show("You did not choose any product!");
            }
        }

        private void listView1_MouseClick(object sender, MouseEventArgs e)
        {
            id = listView1.FocusedItem.Index;
            pictureBox3.ImageLocation = productFactory.getList()[id].getImagePath();
            infolbl.Text = productFactory.getList()[id].getName().ToUpper();
            infopricelbl.Text = productFactory.getList()[id].getPrice().ToUpper();
        }

        private void listView3_MouseDoubleClick(object sender, MouseEventArgs e)
        {
            int count = listView3.FocusedItem.Index;
            idLabel.Text = count.ToString();
            nametextBox.Text = productFactory.getList()[count].getName();
            priceTextBox.Text = productFactory.getList()[count].getPrice();
            descriptionTextBox.Text = productFactory.getList()[count].getDescription();
            pictureBox1.ImageLocation = productFactory.getList()[count].getImagePath();
        }

        private void listView2_MouseClick(object sender, MouseEventArgs e)
        {
            int count = listView2.FocusedItem.Index;
            idLbl.Text = count.ToString();
            nameLbl.Text = productFactory.getList()[count].getName();
            priceLbl.Text = productFactory.getList()[count].getPrice();
            pictureBox4.ImageLocation = productFactory.getList()[count].getImagePath();
        }
    }
}
