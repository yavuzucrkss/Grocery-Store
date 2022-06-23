using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace TH_5_Group_3
{
    class Listing
    {
       
      

        public void producttoListVİew(ListView listView , List<Product> products)
        {
            listView.Clear();
            ImageList imageList = new ImageList();
            imageList.ImageSize = new Size(100, 100);
            int count = 0;
            String[] imagePaths = { };
          


            listView.View = View.Details;
            listView.Columns.Add("Products", 150);
            listView.AutoResizeColumn(0, ColumnHeaderAutoResizeStyle.HeaderSize);

            foreach (Product item in products)
            {
                if (item.getImagePath() != null)
                {
                    imageList.Images.Add(Image.FromFile(item.getImagePath()));
                }
              
            }
            listView.SmallImageList = imageList;

            foreach (Product item in products)
            {

                listView.Items.Add("  -->" + item.getName() + "  " + item.getPrice(), count);

                count++;
            }
        }

    }
}
