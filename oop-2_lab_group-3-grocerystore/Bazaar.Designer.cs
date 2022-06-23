
namespace TH_5_Group_3
{
    partial class Bazaar
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.ProductsTab = new System.Windows.Forms.TabControl();
            this.addtocartBtn = new System.Windows.Forms.TabPage();
            this.pictureBox3 = new System.Windows.Forms.PictureBox();
            this.button6 = new System.Windows.Forms.Button();
            this.listView1 = new System.Windows.Forms.ListView();
            this.pieceLbl = new System.Windows.Forms.TabPage();
            this.label15 = new System.Windows.Forms.Label();
            this.priceLabel = new System.Windows.Forms.Label();
            this.label13 = new System.Windows.Forms.Label();
            this.button5 = new System.Windows.Forms.Button();
            this.button3 = new System.Windows.Forms.Button();
            this.button4 = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.label10 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.idLbl = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.priceLbl = new System.Windows.Forms.Label();
            this.nameLbl = new System.Windows.Forms.Label();
            this.label11 = new System.Windows.Forms.Label();
            this.label12 = new System.Windows.Forms.Label();
            this.pictureBox4 = new System.Windows.Forms.PictureBox();
            this.label7 = new System.Windows.Forms.Label();
            this.listView2 = new System.Windows.Forms.ListView();
            this.tabPage3 = new System.Windows.Forms.TabPage();
            this.listView3 = new System.Windows.Forms.ListView();
            this.idLabel = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.path = new System.Windows.Forms.Label();
            this.linkLabel1 = new System.Windows.Forms.LinkLabel();
            this.deleteButton = new System.Windows.Forms.Button();
            this.descriptionTextBox = new System.Windows.Forms.RichTextBox();
            this.updateButton = new System.Windows.Forms.Button();
            this.addButton = new System.Windows.Forms.Button();
            this.nametextBox = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.priceTextBox = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.openFileDialog1 = new System.Windows.Forms.OpenFileDialog();
            this.button1 = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            this.infolbl = new System.Windows.Forms.Label();
            this.infopricelbl = new System.Windows.Forms.Label();
            this.ProductsTab.SuspendLayout();
            this.addtocartBtn.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox3)).BeginInit();
            this.pieceLbl.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox4)).BeginInit();
            this.tabPage3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            this.SuspendLayout();
            // 
            // ProductsTab
            // 
            this.ProductsTab.Controls.Add(this.addtocartBtn);
            this.ProductsTab.Controls.Add(this.pieceLbl);
            this.ProductsTab.Controls.Add(this.tabPage3);
            this.ProductsTab.Location = new System.Drawing.Point(322, 12);
            this.ProductsTab.Name = "ProductsTab";
            this.ProductsTab.SelectedIndex = 0;
            this.ProductsTab.Size = new System.Drawing.Size(833, 510);
            this.ProductsTab.TabIndex = 11;
            // 
            // addtocartBtn
            // 
            this.addtocartBtn.BackColor = System.Drawing.Color.Sienna;
            this.addtocartBtn.Controls.Add(this.infopricelbl);
            this.addtocartBtn.Controls.Add(this.infolbl);
            this.addtocartBtn.Controls.Add(this.pictureBox3);
            this.addtocartBtn.Controls.Add(this.button6);
            this.addtocartBtn.Controls.Add(this.listView1);
            this.addtocartBtn.Location = new System.Drawing.Point(4, 34);
            this.addtocartBtn.Name = "addtocartBtn";
            this.addtocartBtn.Padding = new System.Windows.Forms.Padding(3);
            this.addtocartBtn.Size = new System.Drawing.Size(825, 472);
            this.addtocartBtn.TabIndex = 0;
            this.addtocartBtn.Text = "tabPage1";
            // 
            // pictureBox3
            // 
            this.pictureBox3.Location = new System.Drawing.Point(535, 97);
            this.pictureBox3.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.pictureBox3.Name = "pictureBox3";
            this.pictureBox3.Size = new System.Drawing.Size(150, 121);
            this.pictureBox3.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox3.TabIndex = 12;
            this.pictureBox3.TabStop = false;
            // 
            // button6
            // 
            this.button6.Location = new System.Drawing.Point(521, 363);
            this.button6.Name = "button6";
            this.button6.Size = new System.Drawing.Size(187, 42);
            this.button6.TabIndex = 16;
            this.button6.Text = "Add to Cart";
            this.button6.UseVisualStyleBackColor = true;
            this.button6.Click += new System.EventHandler(this.addToShoppingCard);
            // 
            // listView1
            // 
            this.listView1.HideSelection = false;
            this.listView1.Location = new System.Drawing.Point(6, 6);
            this.listView1.Name = "listView1";
            this.listView1.Size = new System.Drawing.Size(409, 463);
            this.listView1.TabIndex = 0;
            this.listView1.UseCompatibleStateImageBehavior = false;
            this.listView1.MouseClick += new System.Windows.Forms.MouseEventHandler(this.listView1_MouseClick);
            this.listView1.MouseDoubleClick += new System.Windows.Forms.MouseEventHandler(this.listView1_MouseDoubleClick);
            // 
            // pieceLbl
            // 
            this.pieceLbl.BackColor = System.Drawing.Color.Sienna;
            this.pieceLbl.Controls.Add(this.label15);
            this.pieceLbl.Controls.Add(this.priceLabel);
            this.pieceLbl.Controls.Add(this.label13);
            this.pieceLbl.Controls.Add(this.button5);
            this.pieceLbl.Controls.Add(this.button3);
            this.pieceLbl.Controls.Add(this.button4);
            this.pieceLbl.Controls.Add(this.button2);
            this.pieceLbl.Controls.Add(this.label10);
            this.pieceLbl.Controls.Add(this.label8);
            this.pieceLbl.Controls.Add(this.idLbl);
            this.pieceLbl.Controls.Add(this.label9);
            this.pieceLbl.Controls.Add(this.priceLbl);
            this.pieceLbl.Controls.Add(this.nameLbl);
            this.pieceLbl.Controls.Add(this.label11);
            this.pieceLbl.Controls.Add(this.label12);
            this.pieceLbl.Controls.Add(this.pictureBox4);
            this.pieceLbl.Controls.Add(this.label7);
            this.pieceLbl.Controls.Add(this.listView2);
            this.pieceLbl.Location = new System.Drawing.Point(4, 34);
            this.pieceLbl.Name = "pieceLbl";
            this.pieceLbl.Padding = new System.Windows.Forms.Padding(3);
            this.pieceLbl.Size = new System.Drawing.Size(825, 472);
            this.pieceLbl.TabIndex = 1;
            this.pieceLbl.Text = "tabPage2";
            // 
            // label15
            // 
            this.label15.AutoSize = true;
            this.label15.Location = new System.Drawing.Point(248, 363);
            this.label15.Name = "label15";
            this.label15.Size = new System.Drawing.Size(36, 25);
            this.label15.TabIndex = 42;
            this.label15.Text = "TL";
            // 
            // priceLabel
            // 
            this.priceLabel.AutoSize = true;
            this.priceLabel.Location = new System.Drawing.Point(222, 363);
            this.priceLabel.Name = "priceLabel";
            this.priceLabel.Size = new System.Drawing.Size(23, 25);
            this.priceLabel.TabIndex = 41;
            this.priceLabel.Text = "0";
            // 
            // label13
            // 
            this.label13.AutoSize = true;
            this.label13.Location = new System.Drawing.Point(97, 363);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(116, 25);
            this.label13.TabIndex = 40;
            this.label13.Text = "Total Price :";
            // 
            // button5
            // 
            this.button5.Location = new System.Drawing.Point(62, 316);
            this.button5.Name = "button5";
            this.button5.Size = new System.Drawing.Size(297, 32);
            this.button5.TabIndex = 39;
            this.button5.Text = "Clear Card";
            this.button5.UseVisualStyleBackColor = true;
            // 
            // button3
            // 
            this.button3.Location = new System.Drawing.Point(147, 407);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(137, 33);
            this.button3.TabIndex = 38;
            this.button3.Text = "Pay";
            this.button3.UseVisualStyleBackColor = true;
            // 
            // button4
            // 
            this.button4.Location = new System.Drawing.Point(64, 211);
            this.button4.Name = "button4";
            this.button4.Size = new System.Drawing.Size(295, 40);
            this.button4.TabIndex = 37;
            this.button4.Text = "Update The Number of Pieces";
            this.button4.UseVisualStyleBackColor = true;
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(62, 269);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(297, 30);
            this.button2.TabIndex = 35;
            this.button2.Text = "Remove From Card";
            this.button2.UseVisualStyleBackColor = true;
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label10.Location = new System.Drawing.Point(292, 156);
            this.label10.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(67, 25);
            this.label10.TabIndex = 34;
            this.label10.Text = "_____";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label8.Location = new System.Drawing.Point(217, 156);
            this.label8.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(67, 25);
            this.label8.TabIndex = 33;
            this.label8.Text = "Piece:";
            // 
            // idLbl
            // 
            this.idLbl.AutoSize = true;
            this.idLbl.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.idLbl.Location = new System.Drawing.Point(292, 51);
            this.idLbl.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.idLbl.Name = "idLbl";
            this.idLbl.Size = new System.Drawing.Size(67, 25);
            this.idLbl.TabIndex = 32;
            this.idLbl.Text = "_____";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label9.Location = new System.Drawing.Point(178, 51);
            this.label9.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(106, 25);
            this.label9.TabIndex = 31;
            this.label9.Text = "Product Id:";
            // 
            // priceLbl
            // 
            this.priceLbl.AutoSize = true;
            this.priceLbl.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.priceLbl.Location = new System.Drawing.Point(292, 121);
            this.priceLbl.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.priceLbl.Name = "priceLbl";
            this.priceLbl.Size = new System.Drawing.Size(67, 25);
            this.priceLbl.TabIndex = 29;
            this.priceLbl.Text = "_____";
            // 
            // nameLbl
            // 
            this.nameLbl.AutoSize = true;
            this.nameLbl.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.nameLbl.Location = new System.Drawing.Point(292, 86);
            this.nameLbl.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.nameLbl.Name = "nameLbl";
            this.nameLbl.Size = new System.Drawing.Size(67, 25);
            this.nameLbl.TabIndex = 28;
            this.nameLbl.Text = "_____";
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label11.Location = new System.Drawing.Point(222, 121);
            this.label11.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(62, 25);
            this.label11.TabIndex = 26;
            this.label11.Text = "Price:";
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label12.Location = new System.Drawing.Point(214, 86);
            this.label12.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(70, 25);
            this.label12.TabIndex = 25;
            this.label12.Text = "Name:";
            // 
            // pictureBox4
            // 
            this.pictureBox4.Location = new System.Drawing.Point(26, 62);
            this.pictureBox4.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.pictureBox4.Name = "pictureBox4";
            this.pictureBox4.Size = new System.Drawing.Size(126, 108);
            this.pictureBox4.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox4.TabIndex = 24;
            this.pictureBox4.TabStop = false;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label7.Location = new System.Drawing.Point(566, 3);
            this.label7.Margin = new System.Windows.Forms.Padding(6, 0, 6, 0);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(102, 29);
            this.label7.TabIndex = 16;
            this.label7.Text = "My Card";
            // 
            // listView2
            // 
            this.listView2.HideSelection = false;
            this.listView2.Location = new System.Drawing.Point(449, 51);
            this.listView2.Name = "listView2";
            this.listView2.Size = new System.Drawing.Size(358, 415);
            this.listView2.TabIndex = 1;
            this.listView2.UseCompatibleStateImageBehavior = false;
            this.listView2.MouseClick += new System.Windows.Forms.MouseEventHandler(this.listView2_MouseClick);
            // 
            // tabPage3
            // 
            this.tabPage3.BackColor = System.Drawing.Color.Sienna;
            this.tabPage3.Controls.Add(this.listView3);
            this.tabPage3.Controls.Add(this.idLabel);
            this.tabPage3.Controls.Add(this.label4);
            this.tabPage3.Controls.Add(this.path);
            this.tabPage3.Controls.Add(this.linkLabel1);
            this.tabPage3.Controls.Add(this.deleteButton);
            this.tabPage3.Controls.Add(this.descriptionTextBox);
            this.tabPage3.Controls.Add(this.updateButton);
            this.tabPage3.Controls.Add(this.addButton);
            this.tabPage3.Controls.Add(this.nametextBox);
            this.tabPage3.Controls.Add(this.label2);
            this.tabPage3.Controls.Add(this.label5);
            this.tabPage3.Controls.Add(this.priceTextBox);
            this.tabPage3.Controls.Add(this.label6);
            this.tabPage3.Controls.Add(this.pictureBox1);
            this.tabPage3.Location = new System.Drawing.Point(4, 34);
            this.tabPage3.Name = "tabPage3";
            this.tabPage3.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage3.Size = new System.Drawing.Size(825, 472);
            this.tabPage3.TabIndex = 2;
            this.tabPage3.Text = "tabPage3";
            // 
            // listView3
            // 
            this.listView3.HideSelection = false;
            this.listView3.Location = new System.Drawing.Point(420, 0);
            this.listView3.Name = "listView3";
            this.listView3.Size = new System.Drawing.Size(409, 463);
            this.listView3.TabIndex = 31;
            this.listView3.UseCompatibleStateImageBehavior = false;
            this.listView3.MouseDoubleClick += new System.Windows.Forms.MouseEventHandler(this.listView3_MouseDoubleClick);
            // 
            // idLabel
            // 
            this.idLabel.AutoSize = true;
            this.idLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.idLabel.Location = new System.Drawing.Point(193, 10);
            this.idLabel.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.idLabel.Name = "idLabel";
            this.idLabel.Size = new System.Drawing.Size(39, 29);
            this.idLabel.TabIndex = 30;
            this.idLabel.Text = "__";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label4.Location = new System.Drawing.Point(160, 10);
            this.label4.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(39, 29);
            this.label4.TabIndex = 29;
            this.label4.Text = "Id:";
            // 
            // path
            // 
            this.path.AutoSize = true;
            this.path.Location = new System.Drawing.Point(340, 421);
            this.path.Name = "path";
            this.path.Size = new System.Drawing.Size(50, 25);
            this.path.TabIndex = 28;
            this.path.Text = "path";
            this.path.Visible = false;
            // 
            // linkLabel1
            // 
            this.linkLabel1.AutoSize = true;
            this.linkLabel1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.linkLabel1.LinkColor = System.Drawing.Color.SaddleBrown;
            this.linkLabel1.Location = new System.Drawing.Point(38, 123);
            this.linkLabel1.Name = "linkLabel1";
            this.linkLabel1.Size = new System.Drawing.Size(105, 18);
            this.linkLabel1.TabIndex = 27;
            this.linkLabel1.TabStop = true;
            this.linkLabel1.Text = "ChangePicture";
            this.linkLabel1.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.linkLabel1_LinkClicked);
            // 
            // deleteButton
            // 
            this.deleteButton.Location = new System.Drawing.Point(120, 410);
            this.deleteButton.Name = "deleteButton";
            this.deleteButton.Size = new System.Drawing.Size(165, 47);
            this.deleteButton.TabIndex = 26;
            this.deleteButton.Text = "Delete Product";
            this.deleteButton.UseVisualStyleBackColor = true;
            this.deleteButton.Click += new System.EventHandler(this.deleteButton_Click);
            // 
            // descriptionTextBox
            // 
            this.descriptionTextBox.Location = new System.Drawing.Point(134, 224);
            this.descriptionTextBox.Name = "descriptionTextBox";
            this.descriptionTextBox.Size = new System.Drawing.Size(233, 96);
            this.descriptionTextBox.TabIndex = 25;
            this.descriptionTextBox.Text = "";
            // 
            // updateButton
            // 
            this.updateButton.Location = new System.Drawing.Point(225, 350);
            this.updateButton.Name = "updateButton";
            this.updateButton.Size = new System.Drawing.Size(165, 47);
            this.updateButton.TabIndex = 24;
            this.updateButton.Text = "Update Product";
            this.updateButton.UseVisualStyleBackColor = true;
            this.updateButton.Click += new System.EventHandler(this.updateButton_Click);
            // 
            // addButton
            // 
            this.addButton.Location = new System.Drawing.Point(9, 350);
            this.addButton.Name = "addButton";
            this.addButton.Size = new System.Drawing.Size(153, 47);
            this.addButton.TabIndex = 23;
            this.addButton.Text = "Add Product";
            this.addButton.UseVisualStyleBackColor = true;
            this.addButton.Click += new System.EventHandler(this.addButton_Click);
            // 
            // nametextBox
            // 
            this.nametextBox.Location = new System.Drawing.Point(165, 88);
            this.nametextBox.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.nametextBox.Name = "nametextBox";
            this.nametextBox.Size = new System.Drawing.Size(225, 30);
            this.nametextBox.TabIndex = 22;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label2.Location = new System.Drawing.Point(160, 45);
            this.label2.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(230, 29);
            this.label2.TabIndex = 21;
            this.label2.Text = "Name of the product";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(12, 224);
            this.label5.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(115, 25);
            this.label5.TabIndex = 20;
            this.label5.Text = "Description:";
            // 
            // priceTextBox
            // 
            this.priceTextBox.Location = new System.Drawing.Point(134, 165);
            this.priceTextBox.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.priceTextBox.Name = "priceTextBox";
            this.priceTextBox.Size = new System.Drawing.Size(233, 30);
            this.priceTextBox.TabIndex = 19;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(65, 168);
            this.label6.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(62, 25);
            this.label6.TabIndex = 18;
            this.label6.Text = "Price:";
            // 
            // pictureBox1
            // 
            this.pictureBox1.Location = new System.Drawing.Point(17, 10);
            this.pictureBox1.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(126, 108);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 17;
            this.pictureBox1.TabStop = false;
            // 
            // openFileDialog1
            // 
            this.openFileDialog1.FileName = "openFileDialog1";
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(141, 409);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(93, 42);
            this.button1.TabIndex = 15;
            this.button1.Text = "LogOut";
            this.button1.UseVisualStyleBackColor = true;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label1.Location = new System.Drawing.Point(163, 46);
            this.label1.Margin = new System.Windows.Forms.Padding(6, 0, 6, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(129, 29);
            this.label1.TabIndex = 14;
            this.label1.Text = "UserName";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label3.Location = new System.Drawing.Point(28, 46);
            this.label3.Margin = new System.Windows.Forms.Padding(6, 0, 6, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(141, 29);
            this.label3.TabIndex = 13;
            this.label3.Text = "Welcome to";
            // 
            // pictureBox2
            // 
            this.pictureBox2.Location = new System.Drawing.Point(55, 100);
            this.pictureBox2.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.pictureBox2.Name = "pictureBox2";
            this.pictureBox2.Size = new System.Drawing.Size(200, 164);
            this.pictureBox2.TabIndex = 16;
            this.pictureBox2.TabStop = false;
            // 
            // infolbl
            // 
            this.infolbl.AutoSize = true;
            this.infolbl.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.infolbl.Location = new System.Drawing.Point(530, 242);
            this.infolbl.Margin = new System.Windows.Forms.Padding(6, 0, 6, 0);
            this.infolbl.Name = "infolbl";
            this.infolbl.Size = new System.Drawing.Size(132, 29);
            this.infolbl.TabIndex = 17;
            this.infolbl.Text = "PRODUCT";
            // 
            // infopricelbl
            // 
            this.infopricelbl.AutoSize = true;
            this.infopricelbl.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.infopricelbl.Location = new System.Drawing.Point(530, 271);
            this.infopricelbl.Margin = new System.Windows.Forms.Padding(6, 0, 6, 0);
            this.infopricelbl.Name = "infopricelbl";
            this.infopricelbl.Size = new System.Drawing.Size(210, 29);
            this.infopricelbl.TabIndex = 18;
            this.infopricelbl.Text = "PRODUCT PRİCE";
            // 
            // Bazaar
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(12F, 25F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Sienna;
            this.ClientSize = new System.Drawing.Size(1178, 551);
            this.Controls.Add(this.pictureBox2);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.ProductsTab);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.Name = "Bazaar";
            this.Text = "Bazaar";
            this.Load += new System.EventHandler(this.Bazaar_Load);
            this.ProductsTab.ResumeLayout(false);
            this.addtocartBtn.ResumeLayout(false);
            this.addtocartBtn.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox3)).EndInit();
            this.pieceLbl.ResumeLayout(false);
            this.pieceLbl.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox4)).EndInit();
            this.tabPage3.ResumeLayout(false);
            this.tabPage3.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.TabControl ProductsTab;
        private System.Windows.Forms.TabPage addtocartBtn;
        private System.Windows.Forms.TabPage pieceLbl;
        private System.Windows.Forms.TabPage tabPage3;
        private System.Windows.Forms.Label idLabel;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label path;
        private System.Windows.Forms.LinkLabel linkLabel1;
        private System.Windows.Forms.Button deleteButton;
        private System.Windows.Forms.RichTextBox descriptionTextBox;
        private System.Windows.Forms.Button updateButton;
        private System.Windows.Forms.Button addButton;
        private System.Windows.Forms.TextBox nametextBox;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox priceTextBox;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.OpenFileDialog openFileDialog1;
        private System.Windows.Forms.ListView listView1;
        private System.Windows.Forms.PictureBox pictureBox3;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.ListView listView2;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label idLbl;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label priceLbl;
        private System.Windows.Forms.Label nameLbl;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.PictureBox pictureBox4;
        private System.Windows.Forms.Button button5;
        private System.Windows.Forms.Button button3;
        private System.Windows.Forms.Button button4;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Button button6;
        private System.Windows.Forms.Label label15;
        private System.Windows.Forms.Label priceLabel;
        private System.Windows.Forms.Label label13;
        private System.Windows.Forms.ListView listView3;
        private System.Windows.Forms.PictureBox pictureBox2;
        private System.Windows.Forms.Label infolbl;
        private System.Windows.Forms.Label infopricelbl;
    }
}