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
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        ProductList productFactory = new ProductList();
        private void Form1_Load(object sender, EventArgs e)
        {
             
            



           
            foreach (Product item in productFactory.getList())
            {
                ProductsListBox.Items.Add(item);
            }



        }




        private void linkLabel1_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            try
            {
                openFileDialog1.ShowDialog();
                pictureBox1.ImageLocation = openFileDialog1.FileName;
                path.Text = openFileDialog1.FileName;

            }
            catch (Exception)
            {
                MessageBox.Show("Please select an image");
            }
          
        }

        private void ProductsList_DoubleClick(object sender, EventArgs e)
        {

            int count = ProductsListBox.SelectedIndex;
            idLabel.Text = count.ToString();
            nametextBox.Text = productFactory.getList()[count].getName();
            priceTextBox.Text = productFactory.getList()[count].getPrice();
            descriptionTextBox.Text = productFactory.getList()[count].getDescription();
            pictureBox1.ImageLocation = productFactory.getList()[count].getImagePath();
            
            
         

        }

        private void addButton_Click(object sender, EventArgs e)
        {
            Product newProduct = new Product(nametextBox.Text, priceTextBox.Text, descriptionTextBox.Text, pictureBox1.ImageLocation);
            productFactory.getList().Add(newProduct);
            ProductsListBox.Items.Add(newProduct);

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
                ProductsListBox.Items.RemoveAt(id);
                ProductsListBox.Items.Insert(id, productFactory.getList()[id]);
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
                ProductsListBox.Items.RemoveAt(id);
               
            }
            catch (Exception)
            {
                MessageBox.Show("No product selected");
            }
        }
    }
}
