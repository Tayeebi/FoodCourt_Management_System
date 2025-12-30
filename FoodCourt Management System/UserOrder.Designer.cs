namespace FoodCourt_Management_System
{
    partial class UserOrder
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
            DataGridViewCellStyle dataGridViewCellStyle7 = new DataGridViewCellStyle();
            DataGridViewCellStyle dataGridViewCellStyle8 = new DataGridViewCellStyle();
            DataGridViewCellStyle dataGridViewCellStyle9 = new DataGridViewCellStyle();
            DataGridViewCellStyle dataGridViewCellStyle10 = new DataGridViewCellStyle();
            DataGridViewCellStyle dataGridViewCellStyle11 = new DataGridViewCellStyle();
            DataGridViewCellStyle dataGridViewCellStyle12 = new DataGridViewCellStyle();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(UserOrder));
            panel1 = new Panel();
            Datelbl = new Label();
            button1 = new Button();
            PlaceOrderBtn = new Button();
            QtyTb = new TextBox();
            label2 = new Label();
            AddToCartbtn = new Button();
            OrderGV = new DataGridView();
            OrderAmtlbl = new Label();
            SellerNameTb = new TextBox();
            OrderNumTb = new TextBox();
            ItemGV = new DataGridView();
            CatCb = new ComboBox();
            label1 = new Label();
            label4 = new Label();
            button2 = new Button();
            button4 = new Button();
            button5 = new Button();
            pictureBox1 = new PictureBox();
            button3 = new Button();
            panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)OrderGV).BeginInit();
            ((System.ComponentModel.ISupportInitialize)ItemGV).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            SuspendLayout();
            // 
            // panel1
            // 
            panel1.BackColor = Color.White;
            panel1.Controls.Add(button3);
            panel1.Controls.Add(Datelbl);
            panel1.Controls.Add(button1);
            panel1.Controls.Add(PlaceOrderBtn);
            panel1.Controls.Add(QtyTb);
            panel1.Controls.Add(label2);
            panel1.Controls.Add(AddToCartbtn);
            panel1.Controls.Add(OrderGV);
            panel1.Controls.Add(OrderAmtlbl);
            panel1.Controls.Add(SellerNameTb);
            panel1.Controls.Add(OrderNumTb);
            panel1.Controls.Add(ItemGV);
            panel1.Controls.Add(CatCb);
            panel1.Controls.Add(label1);
            panel1.Location = new Point(173, 38);
            panel1.Name = "panel1";
            panel1.Size = new Size(1198, 606);
            panel1.TabIndex = 8;
            // 
            // Datelbl
            // 
            Datelbl.AutoSize = true;
            Datelbl.BackColor = Color.LightYellow;
            Datelbl.Font = new Font("Berlin Sans FB", 13.8F, FontStyle.Regular, GraphicsUnit.Point, 0);
            Datelbl.ForeColor = Color.Green;
            Datelbl.Location = new Point(950, 4);
            Datelbl.Name = "Datelbl";
            Datelbl.Size = new Size(60, 26);
            Datelbl.TabIndex = 15;
            Datelbl.Text = "Date";
            // 
            // button1
            // 
            button1.BackColor = Color.SpringGreen;
            button1.Font = new Font("Berlin Sans FB Demi", 10.8F, FontStyle.Bold);
            button1.ForeColor = Color.DarkGreen;
            button1.Location = new Point(18, 211);
            button1.Name = "button1";
            button1.Size = new Size(186, 45);
            button1.TabIndex = 14;
            button1.Text = "Refresh";
            button1.UseVisualStyleBackColor = false;
            button1.Click += button1_Click;
            // 
            // PlaceOrderBtn
            // 
            PlaceOrderBtn.BackColor = Color.SpringGreen;
            PlaceOrderBtn.Font = new Font("Berlin Sans FB Demi", 10.8F, FontStyle.Bold);
            PlaceOrderBtn.ForeColor = Color.DarkGreen;
            PlaceOrderBtn.Location = new Point(354, 553);
            PlaceOrderBtn.Name = "PlaceOrderBtn";
            PlaceOrderBtn.Size = new Size(221, 45);
            PlaceOrderBtn.TabIndex = 11;
            PlaceOrderBtn.Text = "Place order to the table";
            PlaceOrderBtn.UseVisualStyleBackColor = false;
            PlaceOrderBtn.Click += PlaceOrderBtn_Click;
            // 
            // QtyTb
            // 
            QtyTb.Font = new Font("Berlin Sans FB", 10.8F);
            QtyTb.ForeColor = Color.Green;
            QtyTb.Location = new Point(606, 266);
            QtyTb.Multiline = true;
            QtyTb.Name = "QtyTb";
            QtyTb.Size = new Size(186, 30);
            QtyTb.TabIndex = 10;
            QtyTb.Text = "Quantity";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.BackColor = Color.LightYellow;
            label2.Font = new Font("Viner Hand ITC", 13.8F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label2.ForeColor = Color.Green;
            label2.Location = new Point(627, 349);
            label2.Name = "label2";
            label2.Size = new Size(134, 37);
            label2.TabIndex = 9;
            label2.Text = "Your Order";
            // 
            // AddToCartbtn
            // 
            AddToCartbtn.BackColor = Color.SpringGreen;
            AddToCartbtn.Font = new Font("Berlin Sans FB Demi", 10.8F, FontStyle.Bold);
            AddToCartbtn.ForeColor = Color.DarkGreen;
            AddToCartbtn.Location = new Point(606, 300);
            AddToCartbtn.Name = "AddToCartbtn";
            AddToCartbtn.Size = new Size(186, 45);
            AddToCartbtn.TabIndex = 8;
            AddToCartbtn.Text = "Add to order";
            AddToCartbtn.UseVisualStyleBackColor = false;
            AddToCartbtn.Click += AddToCartbtn_Click;
            // 
            // OrderGV
            // 
            OrderGV.BackgroundColor = SystemColors.Control;
            OrderGV.BorderStyle = BorderStyle.None;
            dataGridViewCellStyle7.Alignment = DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle7.BackColor = SystemColors.Control;
            dataGridViewCellStyle7.Font = new Font("Segoe UI", 9F);
            dataGridViewCellStyle7.ForeColor = SystemColors.WindowText;
            dataGridViewCellStyle7.SelectionBackColor = Color.SpringGreen;
            dataGridViewCellStyle7.SelectionForeColor = SystemColors.HighlightText;
            dataGridViewCellStyle7.WrapMode = DataGridViewTriState.True;
            OrderGV.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle7;
            OrderGV.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            OrderGV.EnableHeadersVisualStyles = false;
            OrderGV.Location = new Point(212, 395);
            OrderGV.Name = "OrderGV";
            dataGridViewCellStyle8.Alignment = DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle8.BackColor = SystemColors.Control;
            dataGridViewCellStyle8.Font = new Font("Segoe UI", 9F);
            dataGridViewCellStyle8.ForeColor = SystemColors.WindowText;
            dataGridViewCellStyle8.SelectionBackColor = Color.DeepSkyBlue;
            dataGridViewCellStyle8.SelectionForeColor = SystemColors.HighlightText;
            dataGridViewCellStyle8.WrapMode = DataGridViewTriState.True;
            OrderGV.RowHeadersDefaultCellStyle = dataGridViewCellStyle8;
            OrderGV.RowHeadersWidth = 51;
            dataGridViewCellStyle9.SelectionBackColor = Color.DeepSkyBlue;
            OrderGV.RowsDefaultCellStyle = dataGridViewCellStyle9;
            OrderGV.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            OrderGV.Size = new Size(981, 143);
            OrderGV.TabIndex = 7;
            // 
            // OrderAmtlbl
            // 
            OrderAmtlbl.AutoSize = true;
            OrderAmtlbl.BackColor = Color.PaleGreen;
            OrderAmtlbl.Font = new Font("Berlin Sans FB", 13.8F, FontStyle.Regular, GraphicsUnit.Point, 0);
            OrderAmtlbl.ForeColor = Color.Green;
            OrderAmtlbl.Location = new Point(631, 560);
            OrderAmtlbl.Name = "OrderAmtlbl";
            OrderAmtlbl.Size = new Size(154, 26);
            OrderAmtlbl.TabIndex = 6;
            OrderAmtlbl.Text = "Order Amount";
            OrderAmtlbl.Click += OrderAmtlbl_Click;
            // 
            // SellerNameTb
            // 
            SellerNameTb.Font = new Font("Berlin Sans FB", 10.8F);
            SellerNameTb.ForeColor = Color.Green;
            SellerNameTb.Location = new Point(18, 153);
            SellerNameTb.Multiline = true;
            SellerNameTb.Name = "SellerNameTb";
            SellerNameTb.Size = new Size(186, 45);
            SellerNameTb.TabIndex = 5;
            SellerNameTb.Text = "Seller Name";
            // 
            // OrderNumTb
            // 
            OrderNumTb.Font = new Font("Berlin Sans FB", 10.8F);
            OrderNumTb.ForeColor = Color.Green;
            OrderNumTb.Location = new Point(18, 102);
            OrderNumTb.Multiline = true;
            OrderNumTb.Name = "OrderNumTb";
            OrderNumTb.Size = new Size(186, 45);
            OrderNumTb.TabIndex = 4;
            OrderNumTb.Text = "Order Number";
            // 
            // ItemGV
            // 
            ItemGV.BackgroundColor = SystemColors.Control;
            ItemGV.BorderStyle = BorderStyle.None;
            dataGridViewCellStyle10.Alignment = DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle10.BackColor = SystemColors.Control;
            dataGridViewCellStyle10.Font = new Font("Segoe UI", 9F);
            dataGridViewCellStyle10.ForeColor = SystemColors.WindowText;
            dataGridViewCellStyle10.SelectionBackColor = Color.SpringGreen;
            dataGridViewCellStyle10.SelectionForeColor = SystemColors.HighlightText;
            dataGridViewCellStyle10.WrapMode = DataGridViewTriState.True;
            ItemGV.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle10;
            ItemGV.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            ItemGV.EnableHeadersVisualStyles = false;
            ItemGV.Location = new Point(210, 59);
            ItemGV.Name = "ItemGV";
            dataGridViewCellStyle11.Alignment = DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle11.BackColor = SystemColors.Control;
            dataGridViewCellStyle11.Font = new Font("Segoe UI", 9F);
            dataGridViewCellStyle11.ForeColor = SystemColors.WindowText;
            dataGridViewCellStyle11.SelectionBackColor = Color.SpringGreen;
            dataGridViewCellStyle11.SelectionForeColor = SystemColors.HighlightText;
            dataGridViewCellStyle11.WrapMode = DataGridViewTriState.True;
            ItemGV.RowHeadersDefaultCellStyle = dataGridViewCellStyle11;
            ItemGV.RowHeadersVisible = false;
            ItemGV.RowHeadersWidth = 51;
            dataGridViewCellStyle12.Font = new Font("Microsoft Sans Serif", 7.8F, FontStyle.Regular, GraphicsUnit.Point, 0);
            dataGridViewCellStyle12.ForeColor = Color.Black;
            dataGridViewCellStyle12.SelectionBackColor = Color.DeepSkyBlue;
            ItemGV.RowsDefaultCellStyle = dataGridViewCellStyle12;
            ItemGV.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            ItemGV.Size = new Size(981, 204);
            ItemGV.TabIndex = 13;
            ItemGV.CellContentClick += ItemGV_CellContentClick;
            // 
            // CatCb
            // 
            CatCb.BackColor = SystemColors.Control;
            CatCb.Font = new Font("Berlin Sans FB", 10.8F);
            CatCb.ForeColor = Color.Green;
            CatCb.FormattingEnabled = true;
            CatCb.Items.AddRange(new object[] { "Rice Box", "Burger", "Wrap", "Cold Drink", "Desserts" });
            CatCb.Location = new Point(18, 59);
            CatCb.Name = "CatCb";
            CatCb.Size = new Size(186, 28);
            CatCb.TabIndex = 2;
            CatCb.Text = "Categories";
            CatCb.SelectionChangeCommitted += CatCb_SelectionChangeCommitted;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.BackColor = Color.LightYellow;
            label1.Font = new Font("Viner Hand ITC", 13.8F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label1.ForeColor = Color.Green;
            label1.Location = new Point(624, 6);
            label1.Name = "label1";
            label1.Size = new Size(144, 37);
            label1.TabIndex = 1;
            label1.Text = "Place Order";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.BackColor = Color.White;
            label4.Font = new Font("Berlin Sans FB", 10.8F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label4.ForeColor = Color.Red;
            label4.Location = new Point(1352, 4);
            label4.Name = "label4";
            label4.Size = new Size(19, 20);
            label4.TabIndex = 7;
            label4.Text = "X";
            label4.Click += label4_Click_1;
            // 
            // button2
            // 
            button2.BackColor = Color.Honeydew;
            button2.Font = new Font("Berlin Sans FB", 10.8F);
            button2.ForeColor = Color.Red;
            button2.Location = new Point(15, 572);
            button2.Name = "button2";
            button2.Size = new Size(123, 45);
            button2.TabIndex = 9;
            button2.Text = "Logout";
            button2.UseVisualStyleBackColor = false;
            button2.Click += button2_Click;
            // 
            // button4
            // 
            button4.BackColor = Color.Honeydew;
            button4.Font = new Font("Berlin Sans FB Demi", 10.8F, FontStyle.Bold);
            button4.ForeColor = Color.Green;
            button4.Location = new Point(15, 38);
            button4.Name = "button4";
            button4.Size = new Size(123, 45);
            button4.TabIndex = 10;
            button4.Text = "Item";
            button4.UseVisualStyleBackColor = false;
            button4.Click += button4_Click;
            // 
            // button5
            // 
            button5.BackColor = Color.Honeydew;
            button5.Font = new Font("Berlin Sans FB Demi", 10.8F, FontStyle.Bold);
            button5.ForeColor = Color.Green;
            button5.Location = new Point(15, 109);
            button5.Name = "button5";
            button5.Size = new Size(123, 45);
            button5.TabIndex = 11;
            button5.Text = "Users";
            button5.UseVisualStyleBackColor = false;
            button5.Click += button5_Click;
            // 
            // pictureBox1
            // 
            pictureBox1.Image = (Image)resources.GetObject("pictureBox1.Image");
            pictureBox1.Location = new Point(12, 249);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(139, 107);
            pictureBox1.SizeMode = PictureBoxSizeMode.StretchImage;
            pictureBox1.TabIndex = 16;
            pictureBox1.TabStop = false;
            // 
            // button3
            // 
            button3.BackColor = Color.SpringGreen;
            button3.Font = new Font("Berlin Sans FB Demi", 10.8F, FontStyle.Bold);
            button3.ForeColor = Color.DarkGreen;
            button3.Location = new Point(857, 553);
            button3.Name = "button3";
            button3.Size = new Size(221, 45);
            button3.TabIndex = 16;
            button3.Text = "View Orders";
            button3.UseVisualStyleBackColor = false;
            button3.Click += button3_Click;
            // 
            // UserOrder
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.SpringGreen;
            ClientSize = new Size(1387, 649);
            Controls.Add(pictureBox1);
            Controls.Add(button5);
            Controls.Add(button4);
            Controls.Add(panel1);
            Controls.Add(label4);
            Controls.Add(button2);
            FormBorderStyle = FormBorderStyle.None;
            Name = "UserOrder";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "UserOrder";
            Load += UserOrder_Load;
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)OrderGV).EndInit();
            ((System.ComponentModel.ISupportInitialize)ItemGV).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Panel panel1;
        private Button PlaceOrderBtn;
        private TextBox QtyTb;
        private Label label2;
        private Button AddToCartbtn;
        private DataGridView OrderGV;
        private Label OrderAmtlbl;
        private TextBox SellerNameTb;
        private TextBox OrderNumTb;
        private DataGridView ItemGV;
        private ComboBox CatCb;
        private Label label1;
        private Label label4;
        private Button button2;
        private Button button4;
        private Button button5;
        private PictureBox pictureBox1;
        private Button button1;
        private Label Datelbl;
        private Button button3;
    }
}