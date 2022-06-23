using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace TH_5_Group_3
{
    public partial class ProductsDetail : Form
    {
        public int id;
        public ProductsDetail()
        {
            InitializeComponent();
        }
        ProductList productList = new ProductList();
        private void ProductsDetail_Load(object sender, EventArgs e)
        {
            idLbl.Text = id.ToString();
            nameLbl.Text = productList.getList()[id].getName();
            priceLbl.Text = productList.getList()[id].getPrice();
            detailsLbl.Text = productList.getList()[id].getDescription();
            pictureBox1.ImageLocation = (productList.getList()[id].getImagePath());
        }

        
    }
}
