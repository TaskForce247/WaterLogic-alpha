namespace AuctionProject
{
    partial class Form1
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
            this.components = new System.ComponentModel.Container();
            this.loggedname = new System.Windows.Forms.Label();
            this.LinkLabelLogin = new System.Windows.Forms.LinkLabel();
            this.LinkLabelAboutus = new System.Windows.Forms.LinkLabel();
            this.AccountLinkedLabel = new System.Windows.Forms.LinkLabel();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.tabPage6 = new System.Windows.Forms.TabPage();
            this.label4 = new System.Windows.Forms.Label();
            this.button2 = new System.Windows.Forms.Button();
            this.textBox2 = new System.Windows.Forms.TextBox();
            this.LoadFromDB = new System.Windows.Forms.Button();
            this.dataGridView3 = new System.Windows.Forms.DataGridView();
            this.SearchB = new System.Windows.Forms.Button();
            this.tabPage5 = new System.Windows.Forms.TabPage();
            this.label5 = new System.Windows.Forms.Label();
            this.button3 = new System.Windows.Forms.Button();
            this.textBox3 = new System.Windows.Forms.TextBox();
            this.productSearchbtn = new System.Windows.Forms.Button();
            this.productLoadbtn = new System.Windows.Forms.Button();
            this.dataGridView5 = new System.Windows.Forms.DataGridView();
            this.pictureBox4 = new System.Windows.Forms.PictureBox();
            this.dataGridView4 = new System.Windows.Forms.DataGridView();
            this.label9 = new System.Windows.Forms.Label();
            this.BrowseButton = new System.Windows.Forms.Button();
            this.label10 = new System.Windows.Forms.Label();
            this.label11 = new System.Windows.Forms.Label();
            this.AddButton = new System.Windows.Forms.Button();
            this.CategoryLabel = new System.Windows.Forms.Label();
            this.itemnametext4 = new System.Windows.Forms.TextBox();
            this.StartingPriceTextbox = new System.Windows.Forms.TextBox();
            this.RichtextboxDescr = new System.Windows.Forms.RichTextBox();
            this.CategoryTextBox = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.panel1 = new System.Windows.Forms.Panel();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.StartingPriceLabel = new System.Windows.Forms.Label();
            this.ItemNameLabel = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.tabControl1 = new System.Windows.Forms.TabControl();
            this.tabPage4 = new System.Windows.Forms.TabPage();
            this.button8 = new System.Windows.Forms.Button();
            this.button7 = new System.Windows.Forms.Button();
            this.button6 = new System.Windows.Forms.Button();
            this.label6 = new System.Windows.Forms.Label();
            this.CategoryNameBox = new System.Windows.Forms.TextBox();
            this.dataGridView6 = new System.Windows.Forms.DataGridView();
            this.button5 = new System.Windows.Forms.Button();
            this.accountBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.tabPage6.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView3)).BeginInit();
            this.tabPage5.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView5)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox4)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView4)).BeginInit();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.tabControl1.SuspendLayout();
            this.tabPage4.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView6)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.accountBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // loggedname
            // 
            this.loggedname.AutoSize = true;
            this.loggedname.Location = new System.Drawing.Point(34, 29);
            this.loggedname.Name = "loggedname";
            this.loggedname.Size = new System.Drawing.Size(0, 13);
            this.loggedname.TabIndex = 6;
            // 
            // LinkLabelLogin
            // 
            this.LinkLabelLogin.AutoSize = true;
            this.LinkLabelLogin.Location = new System.Drawing.Point(970, 41);
            this.LinkLabelLogin.Name = "LinkLabelLogin";
            this.LinkLabelLogin.Size = new System.Drawing.Size(43, 13);
            this.LinkLabelLogin.TabIndex = 9;
            this.LinkLabelLogin.TabStop = true;
            this.LinkLabelLogin.Text = "Log out";
            this.LinkLabelLogin.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.linkLabel1_LinkClicked);
            // 
            // LinkLabelAboutus
            // 
            this.LinkLabelAboutus.AutoSize = true;
            this.LinkLabelAboutus.Location = new System.Drawing.Point(877, 41);
            this.LinkLabelAboutus.Name = "LinkLabelAboutus";
            this.LinkLabelAboutus.Size = new System.Drawing.Size(49, 13);
            this.LinkLabelAboutus.TabIndex = 10;
            this.LinkLabelAboutus.TabStop = true;
            this.LinkLabelAboutus.Text = "About us";
            this.LinkLabelAboutus.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.LinkLabelAboutus_LinkClicked);
            // 
            // AccountLinkedLabel
            // 
            this.AccountLinkedLabel.AutoSize = true;
            this.AccountLinkedLabel.Location = new System.Drawing.Point(814, 41);
            this.AccountLinkedLabel.Name = "AccountLinkedLabel";
            this.AccountLinkedLabel.Size = new System.Drawing.Size(47, 13);
            this.AccountLinkedLabel.TabIndex = 11;
            this.AccountLinkedLabel.TabStop = true;
            this.AccountLinkedLabel.Text = "Account";
            this.AccountLinkedLabel.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.AccountLinkedLabel_LinkClicked);
            // 
            // tabPage6
            // 
            this.tabPage6.Controls.Add(this.label4);
            this.tabPage6.Controls.Add(this.button2);
            this.tabPage6.Controls.Add(this.textBox2);
            this.tabPage6.Controls.Add(this.LoadFromDB);
            this.tabPage6.Controls.Add(this.dataGridView3);
            this.tabPage6.Controls.Add(this.SearchB);
            this.tabPage6.Location = new System.Drawing.Point(4, 25);
            this.tabPage6.Name = "tabPage6";
            this.tabPage6.Padding = new System.Windows.Forms.Padding(3, 3, 3, 3);
            this.tabPage6.Size = new System.Drawing.Size(1035, 409);
            this.tabPage6.TabIndex = 5;
            this.tabPage6.Text = "All Acounts";
            this.tabPage6.UseVisualStyleBackColor = true;
            this.tabPage6.Click += new System.EventHandler(this.tabPage6_Click);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Times New Roman", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(18, 28);
            this.label4.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(134, 21);
            this.label4.TabIndex = 5;
            this.label4.Text = "Search account :";
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(507, 28);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(131, 24);
            this.button2.TabIndex = 4;
            this.button2.Text = "Search by ID";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click_1);
            // 
            // textBox2
            // 
            this.textBox2.Location = new System.Drawing.Point(164, 28);
            this.textBox2.Name = "textBox2";
            this.textBox2.Size = new System.Drawing.Size(183, 24);
            this.textBox2.TabIndex = 3;
            this.textBox2.TextChanged += new System.EventHandler(this.textBox2_TextChanged_1);
            // 
            // LoadFromDB
            // 
            this.LoadFromDB.Location = new System.Drawing.Point(937, 27);
            this.LoadFromDB.Name = "LoadFromDB";
            this.LoadFromDB.Size = new System.Drawing.Size(82, 24);
            this.LoadFromDB.TabIndex = 2;
            this.LoadFromDB.Text = "Refresh";
            this.LoadFromDB.UseVisualStyleBackColor = true;
            this.LoadFromDB.Click += new System.EventHandler(this.LoadFromDB_Click_1);
            // 
            // dataGridView3
            // 
            this.dataGridView3.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView3.Location = new System.Drawing.Point(17, 69);
            this.dataGridView3.Name = "dataGridView3";
            this.dataGridView3.Size = new System.Drawing.Size(1002, 321);
            this.dataGridView3.TabIndex = 0;
            this.dataGridView3.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView3_CellContentClick);
            // 
            // SearchB
            // 
            this.SearchB.Location = new System.Drawing.Point(367, 28);
            this.SearchB.Name = "SearchB";
            this.SearchB.Size = new System.Drawing.Size(128, 23);
            this.SearchB.TabIndex = 1;
            this.SearchB.Text = "Search by E-mail";
            this.SearchB.UseVisualStyleBackColor = true;
            this.SearchB.Click += new System.EventHandler(this.SearchB_Click_1);
            // 
            // tabPage5
            // 
            this.tabPage5.Controls.Add(this.label5);
            this.tabPage5.Controls.Add(this.button3);
            this.tabPage5.Controls.Add(this.textBox3);
            this.tabPage5.Controls.Add(this.productSearchbtn);
            this.tabPage5.Controls.Add(this.productLoadbtn);
            this.tabPage5.Controls.Add(this.dataGridView5);
            this.tabPage5.Location = new System.Drawing.Point(4, 25);
            this.tabPage5.Name = "tabPage5";
            this.tabPage5.Size = new System.Drawing.Size(1035, 409);
            this.tabPage5.TabIndex = 4;
            this.tabPage5.Text = "All Products";
            this.tabPage5.UseVisualStyleBackColor = true;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Times New Roman", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(17, 19);
            this.label5.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(134, 21);
            this.label5.TabIndex = 6;
            this.label5.Text = "Search product :";
            // 
            // button3
            // 
            this.button3.Location = new System.Drawing.Point(454, 16);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(112, 24);
            this.button3.TabIndex = 4;
            this.button3.Text = "Remove by ID";
            this.button3.UseVisualStyleBackColor = true;
            this.button3.Click += new System.EventHandler(this.button3_Click);
            // 
            // textBox3
            // 
            this.textBox3.Location = new System.Drawing.Point(162, 18);
            this.textBox3.Name = "textBox3";
            this.textBox3.Size = new System.Drawing.Size(140, 24);
            this.textBox3.TabIndex = 3;
            // 
            // productSearchbtn
            // 
            this.productSearchbtn.Location = new System.Drawing.Point(322, 17);
            this.productSearchbtn.Name = "productSearchbtn";
            this.productSearchbtn.Size = new System.Drawing.Size(108, 23);
            this.productSearchbtn.TabIndex = 2;
            this.productSearchbtn.Text = "Search by ID";
            this.productSearchbtn.UseVisualStyleBackColor = true;
            this.productSearchbtn.Click += new System.EventHandler(this.productSearchbtn_Click);
            // 
            // productLoadbtn
            // 
            this.productLoadbtn.Location = new System.Drawing.Point(922, 16);
            this.productLoadbtn.Name = "productLoadbtn";
            this.productLoadbtn.Size = new System.Drawing.Size(90, 23);
            this.productLoadbtn.TabIndex = 1;
            this.productLoadbtn.Text = "Refresh";
            this.productLoadbtn.UseVisualStyleBackColor = true;
            this.productLoadbtn.Click += new System.EventHandler(this.productLoadbtn_Click);
            // 
            // dataGridView5
            // 
            this.dataGridView5.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView5.Location = new System.Drawing.Point(17, 54);
            this.dataGridView5.Name = "dataGridView5";
            this.dataGridView5.Size = new System.Drawing.Size(995, 334);
            this.dataGridView5.TabIndex = 0;
            this.dataGridView5.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView5_CellContentClick);
            // 
            // pictureBox4
            // 
            this.pictureBox4.Location = new System.Drawing.Point(19, 57);
            this.pictureBox4.Name = "pictureBox4";
            this.pictureBox4.Size = new System.Drawing.Size(124, 121);
            this.pictureBox4.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox4.TabIndex = 3;
            this.pictureBox4.TabStop = false;
            // 
            // dataGridView4
            // 
            this.dataGridView4.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView4.Location = new System.Drawing.Point(6, 213);
            this.dataGridView4.Name = "dataGridView4";
            this.dataGridView4.Size = new System.Drawing.Size(904, 290);
            this.dataGridView4.TabIndex = 0;
            this.dataGridView4.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView4_CellContentClick);
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(16, 23);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(27, 13);
            this.label9.TabIndex = 1;
            this.label9.Text = "Item";
            // 
            // BrowseButton
            // 
            this.BrowseButton.Location = new System.Drawing.Point(19, 184);
            this.BrowseButton.Name = "BrowseButton";
            this.BrowseButton.Size = new System.Drawing.Size(50, 23);
            this.BrowseButton.TabIndex = 2;
            this.BrowseButton.Text = "Browse";
            this.BrowseButton.UseVisualStyleBackColor = true;
            this.BrowseButton.Click += new System.EventHandler(this.button5_Click);
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(208, 22);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(69, 13);
            this.label10.TabIndex = 6;
            this.label10.Text = "Starting price";
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Location = new System.Drawing.Point(208, 108);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(60, 13);
            this.label11.TabIndex = 8;
            this.label11.Text = "Description";
            // 
            // AddButton
            // 
            this.AddButton.Location = new System.Drawing.Point(92, 184);
            this.AddButton.Name = "AddButton";
            this.AddButton.Size = new System.Drawing.Size(51, 23);
            this.AddButton.TabIndex = 9;
            this.AddButton.Text = "Add";
            this.AddButton.UseVisualStyleBackColor = true;
            this.AddButton.Click += new System.EventHandler(this.button6_Click);
            // 
            // CategoryLabel
            // 
            this.CategoryLabel.AutoSize = true;
            this.CategoryLabel.Location = new System.Drawing.Point(208, 69);
            this.CategoryLabel.Name = "CategoryLabel";
            this.CategoryLabel.Size = new System.Drawing.Size(49, 13);
            this.CategoryLabel.TabIndex = 10;
            this.CategoryLabel.Text = "Category";
            // 
            // itemnametext4
            // 
            this.itemnametext4.Location = new System.Drawing.Point(49, 16);
            this.itemnametext4.Name = "itemnametext4";
            this.itemnametext4.Size = new System.Drawing.Size(94, 20);
            this.itemnametext4.TabIndex = 4;
            this.itemnametext4.TextChanged += new System.EventHandler(this.itemnametext4_TextChanged);
            // 
            // StartingPriceTextbox
            // 
            this.StartingPriceTextbox.Location = new System.Drawing.Point(294, 19);
            this.StartingPriceTextbox.Name = "StartingPriceTextbox";
            this.StartingPriceTextbox.Size = new System.Drawing.Size(149, 20);
            this.StartingPriceTextbox.TabIndex = 5;
            // 
            // RichtextboxDescr
            // 
            this.RichtextboxDescr.Location = new System.Drawing.Point(294, 108);
            this.RichtextboxDescr.Name = "RichtextboxDescr";
            this.RichtextboxDescr.Size = new System.Drawing.Size(149, 87);
            this.RichtextboxDescr.TabIndex = 7;
            this.RichtextboxDescr.Text = "";
            // 
            // CategoryTextBox
            // 
            this.CategoryTextBox.Location = new System.Drawing.Point(294, 61);
            this.CategoryTextBox.Name = "CategoryTextBox";
            this.CategoryTextBox.Size = new System.Drawing.Size(149, 20);
            this.CategoryTextBox.TabIndex = 11;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(487, 19);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(35, 13);
            this.label2.TabIndex = 12;
            this.label2.Text = "label2";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(490, 68);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(35, 13);
            this.label3.TabIndex = 13;
            this.label3.Text = "label3";
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.dataGridView1);
            this.panel1.Controls.Add(this.StartingPriceLabel);
            this.panel1.Controls.Add(this.ItemNameLabel);
            this.panel1.Controls.Add(this.label1);
            this.panel1.Controls.Add(this.pictureBox1);
            this.panel1.Location = new System.Drawing.Point(3, 24);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(911, 302);
            this.panel1.TabIndex = 6;
            // 
            // dataGridView1
            // 
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Cursor = System.Windows.Forms.Cursors.Default;
            this.dataGridView1.Location = new System.Drawing.Point(15, 208);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.Size = new System.Drawing.Size(638, 82);
            this.dataGridView1.TabIndex = 9;
            // 
            // StartingPriceLabel
            // 
            this.StartingPriceLabel.AutoSize = true;
            this.StartingPriceLabel.Location = new System.Drawing.Point(205, 60);
            this.StartingPriceLabel.Name = "StartingPriceLabel";
            this.StartingPriceLabel.Size = new System.Drawing.Size(69, 13);
            this.StartingPriceLabel.TabIndex = 7;
            this.StartingPriceLabel.Text = "Starting price";
            // 
            // ItemNameLabel
            // 
            this.ItemNameLabel.AutoSize = true;
            this.ItemNameLabel.Location = new System.Drawing.Point(205, 20);
            this.ItemNameLabel.Name = "ItemNameLabel";
            this.ItemNameLabel.Size = new System.Drawing.Size(27, 13);
            this.ItemNameLabel.TabIndex = 4;
            this.ItemNameLabel.Text = "Item";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(205, 98);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(66, 13);
            this.label1.TabIndex = 1;
            this.label1.Text = "Description :";
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = global::AuctionProject.Properties.Resources.lenovo_laptop_ideapad_y410p_front_1;
            this.pictureBox1.Location = new System.Drawing.Point(15, 20);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(156, 150);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 0;
            this.pictureBox1.TabStop = false;
            this.pictureBox1.Click += new System.EventHandler(this.pictureBox1_Click);
            // 
            // tabControl1
            // 
            this.tabControl1.Controls.Add(this.tabPage5);
            this.tabControl1.Controls.Add(this.tabPage6);
            this.tabControl1.Controls.Add(this.tabPage4);
            this.tabControl1.Font = new System.Drawing.Font("Times New Roman", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tabControl1.Location = new System.Drawing.Point(10, 58);
            this.tabControl1.Name = "tabControl1";
            this.tabControl1.SelectedIndex = 0;
            this.tabControl1.Size = new System.Drawing.Size(1043, 438);
            this.tabControl1.TabIndex = 7;
            this.tabControl1.SelectedIndexChanged += new System.EventHandler(this.tabControl1_SelectedIndexChanged);
            this.tabControl1.TabIndexChanged += new System.EventHandler(this.tabControl1_TabIndexChanged);
            // 
            // tabPage4
            // 
            this.tabPage4.Controls.Add(this.button8);
            this.tabPage4.Controls.Add(this.button7);
            this.tabPage4.Controls.Add(this.button6);
            this.tabPage4.Controls.Add(this.label6);
            this.tabPage4.Controls.Add(this.CategoryNameBox);
            this.tabPage4.Controls.Add(this.dataGridView6);
            this.tabPage4.Controls.Add(this.button5);
            this.tabPage4.Font = new System.Drawing.Font("Times New Roman", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tabPage4.Location = new System.Drawing.Point(4, 25);
            this.tabPage4.Name = "tabPage4";
            this.tabPage4.Padding = new System.Windows.Forms.Padding(3, 3, 3, 3);
            this.tabPage4.Size = new System.Drawing.Size(1035, 409);
            this.tabPage4.TabIndex = 6;
            this.tabPage4.Text = "Category";
            this.tabPage4.UseVisualStyleBackColor = true;
            // 
            // button8
            // 
            this.button8.Font = new System.Drawing.Font("Times New Roman", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button8.Location = new System.Drawing.Point(118, 137);
            this.button8.Name = "button8";
            this.button8.Size = new System.Drawing.Size(315, 37);
            this.button8.TabIndex = 10;
            this.button8.Text = "Remove category";
            this.button8.UseVisualStyleBackColor = true;
            this.button8.Click += new System.EventHandler(this.button8_Click);
            // 
            // button7
            // 
            this.button7.Font = new System.Drawing.Font("Times New Roman", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button7.Location = new System.Drawing.Point(118, 193);
            this.button7.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.button7.Name = "button7";
            this.button7.Size = new System.Drawing.Size(313, 34);
            this.button7.TabIndex = 9;
            this.button7.Text = "Update category";
            this.button7.UseVisualStyleBackColor = true;
            this.button7.Click += new System.EventHandler(this.button7_Click_1);
            // 
            // button6
            // 
            this.button6.Font = new System.Drawing.Font("Times New Roman", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button6.Location = new System.Drawing.Point(118, 302);
            this.button6.Name = "button6";
            this.button6.Size = new System.Drawing.Size(313, 33);
            this.button6.TabIndex = 8;
            this.button6.Text = "Refresh table content";
            this.button6.UseVisualStyleBackColor = true;
            this.button6.Click += new System.EventHandler(this.button6_Click_1);
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(22, 48);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(169, 19);
            this.label6.TabIndex = 6;
            this.label6.Text = "Enter new category name :";
            // 
            // CategoryNameBox
            // 
            this.CategoryNameBox.Font = new System.Drawing.Font("Times New Roman", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.CategoryNameBox.Location = new System.Drawing.Point(211, 46);
            this.CategoryNameBox.Name = "CategoryNameBox";
            this.CategoryNameBox.Size = new System.Drawing.Size(160, 24);
            this.CategoryNameBox.TabIndex = 3;
            this.CategoryNameBox.TextChanged += new System.EventHandler(this.CategoryNameBox_TextChanged);
            // 
            // dataGridView6
            // 
            this.dataGridView6.AllowUserToAddRows = false;
            this.dataGridView6.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView6.Location = new System.Drawing.Point(539, 34);
            this.dataGridView6.MultiSelect = false;
            this.dataGridView6.Name = "dataGridView6";
            this.dataGridView6.Size = new System.Drawing.Size(472, 349);
            this.dataGridView6.TabIndex = 0;
            this.dataGridView6.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView6_CellClick);
            // 
            // button5
            // 
            this.button5.Font = new System.Drawing.Font("Times New Roman", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button5.Location = new System.Drawing.Point(388, 43);
            this.button5.Name = "button5";
            this.button5.Size = new System.Drawing.Size(114, 25);
            this.button5.TabIndex = 1;
            this.button5.Text = "Add category";
            this.button5.UseVisualStyleBackColor = true;
            this.button5.Click += new System.EventHandler(this.button5_Click_1);
            // 
            // accountBindingSource
            // 
            this.accountBindingSource.DataSource = typeof(AuctionProject.ServiceReference1.Account);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1073, 509);
            this.Controls.Add(this.AccountLinkedLabel);
            this.Controls.Add(this.LinkLabelAboutus);
            this.Controls.Add(this.LinkLabelLogin);
            this.Controls.Add(this.tabControl1);
            this.Controls.Add(this.loggedname);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.Fixed3D;
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.tabPage6.ResumeLayout(false);
            this.tabPage6.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView3)).EndInit();
            this.tabPage5.ResumeLayout(false);
            this.tabPage5.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView5)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox4)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView4)).EndInit();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.tabControl1.ResumeLayout(false);
            this.tabPage4.ResumeLayout(false);
            this.tabPage4.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView6)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.accountBindingSource)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Label loggedname;
        private System.Windows.Forms.LinkLabel LinkLabelLogin;
        private System.Windows.Forms.LinkLabel LinkLabelAboutus;
        private System.Windows.Forms.LinkLabel AccountLinkedLabel;
        private System.Windows.Forms.Timer timer1;
        private System.Windows.Forms.BindingSource accountBindingSource;
        private System.Windows.Forms.TabPage tabPage6;
        private System.Windows.Forms.TextBox textBox2;
        private System.Windows.Forms.Button LoadFromDB;
        public System.Windows.Forms.DataGridView dataGridView3;
        private System.Windows.Forms.Button SearchB;
        private System.Windows.Forms.TabPage tabPage5;
        private System.Windows.Forms.TabPage tabPage3;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox CategoryTextBox;
        private System.Windows.Forms.RichTextBox RichtextboxDescr;
        private System.Windows.Forms.TextBox StartingPriceTextbox;
        private System.Windows.Forms.TextBox itemnametext4;
        private System.Windows.Forms.Label CategoryLabel;
        private System.Windows.Forms.Button AddButton;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Button BrowseButton;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.DataGridView dataGridView4;
        private System.Windows.Forms.PictureBox pictureBox4;
        private System.Windows.Forms.TabPage tabPage1;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.Label StartingPriceLabel;
        private System.Windows.Forms.Label ItemNameLabel;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.TabControl tabControl1;
        private System.Windows.Forms.DataGridView dataGridView5;
        private System.Windows.Forms.Button productLoadbtn;
        private System.Windows.Forms.TextBox textBox3;
        private System.Windows.Forms.Button productSearchbtn;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Button button3;
        private System.Windows.Forms.TabPage tabPage4;
        private System.Windows.Forms.Button button7;
        private System.Windows.Forms.Button button6;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox CategoryNameBox;
        private System.Windows.Forms.Button button5;
        private System.Windows.Forms.DataGridView dataGridView6;
        private System.Windows.Forms.Button button8;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
    }
}

