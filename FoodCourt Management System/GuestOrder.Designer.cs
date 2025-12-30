namespace FoodCourt_Management_System
{
    partial class GuestOrder
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
            DataGridViewCellStyle dataGridViewCellStyle4 = new DataGridViewCellStyle();
            DataGridViewCellStyle dataGridViewCellStyle5 = new DataGridViewCellStyle();
            DataGridViewCellStyle dataGridViewCellStyle6 = new DataGridViewCellStyle();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(GuestOrder));
            panel1 = new Panel();
            Datelbl = new Label();
            button4 = new Button();
            PlaceOrderBtn = new Button();
            QtyTb = new TextBox();
            label2 = new Label();
            button1 = new Button();
            OrderGV = new DataGridView();
            OrderAmtlbl = new Label();
            SellerNameTb = new TextBox();
            OrderNumTb = new TextBox();
            ItemGV = new DataGridView();
            CatCb = new ComboBox();
            label1 = new Label();
            label4 = new Label();
            button2 = new Button();
            pictureBox1 = new PictureBox();
            panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)OrderGV).BeginInit();
            ((System.ComponentModel.ISupportInitialize)ItemGV).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            SuspendLayout();
            // 
            // panel1
            // 
            panel1.BackColor = Color.White;
            panel1.Controls.Add(Datelbl);
            panel1.Controls.Add(button4);
            panel1.Controls.Add(PlaceOrderBtn);
            panel1.Controls.Add(QtyTb);
            panel1.Controls.Add(label2);
            panel1.Controls.Add(button1);
            panel1.Controls.Add(OrderGV);
            panel1.Controls.Add(OrderAmtlbl);
            panel1.Controls.Add(SellerNameTb);
            panel1.Controls.Add(OrderNumTb);
            panel1.Controls.Add(ItemGV);
            panel1.Controls.Add(CatCb);
            panel1.Controls.Add(label1);
            panel1.Location = new Point(170, 38);
            panel1.Name = "panel1";
            panel1.Size = new Size(1201, 606);
            panel1.TabIndex = 13;
            // 
            // Datelbl
            // 
            Datelbl.AutoSize = true;
            Datelbl.BackColor = Color.LightYellow;
            Datelbl.Font = new Font("Berlin Sans FB", 13.8F, FontStyle.Regular, GraphicsUnit.Point, 0);
            Datelbl.ForeColor = Color.Green;
            Datelbl.Location = new Point(971, 9);
            Datelbl.Name = "Datelbl";
            Datelbl.Size = new Size(60, 26);
            Datelbl.TabIndex = 13;
            Datelbl.Text = "Date";
            // 
            // button4
            // 
            button4.BackColor = Color.SpringGreen;
            button4.Font = new Font("Berlin Sans FB", 10.8F);
            button4.ForeColor = Color.DarkGreen;
            button4.Location = new Point(12, 96);
            button4.Name = "button4";
            button4.Size = new Size(186, 47);
            button4.TabIndex = 12;
            button4.Text = "Refresh";
            button4.UseVisualStyleBackColor = false;
            button4.Click += button4_Click;
            // 
            // PlaceOrderBtn
            // 
            PlaceOrderBtn.BackColor = Color.SpringGreen;
            PlaceOrderBtn.Font = new Font("Berlin Sans FB", 10.8F);
            PlaceOrderBtn.ForeColor = Color.DarkGreen;
            PlaceOrderBtn.Location = new Point(580, 553);
            PlaceOrderBtn.Name = "PlaceOrderBtn";
            PlaceOrderBtn.Size = new Size(221, 45);
            PlaceOrderBtn.TabIndex = 11;
            PlaceOrderBtn.Text = "Place order to the table";
            PlaceOrderBtn.UseVisualStyleBackColor = false;
            PlaceOrderBtn.Click += button3_Click;
            // 
            // QtyTb
            // 
            QtyTb.Font = new Font("Berlin Sans FB", 10.8F);
            QtyTb.ForeColor = Color.Green;
            QtyTb.Location = new Point(590, 276);
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
            label2.Font = new Font("Viner Hand ITC", 16.2F, FontStyle.Bold);
            label2.ForeColor = Color.Green;
            label2.Location = new Point(604, 347);
            label2.Name = "label2";
            label2.Size = new Size(161, 45);
            label2.TabIndex = 9;
            label2.Text = "Your Order";
            // 
            // button1
            // 
            button1.BackColor = Color.SpringGreen;
            button1.Font = new Font("Berlin Sans FB", 10.8F);
            button1.ForeColor = Color.DarkGreen;
            button1.Location = new Point(590, 308);
            button1.Name = "button1";
            button1.Size = new Size(186, 36);
            button1.TabIndex = 8;
            button1.Text = "Add to order";
            button1.UseVisualStyleBackColor = false;
            button1.Click += button1_Click;
            // 
            // OrderGV
            // 
            OrderGV.BackgroundColor = SystemColors.Control;
            OrderGV.BorderStyle = BorderStyle.None;
            OrderGV.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            OrderGV.Location = new Point(212, 395);
            OrderGV.Name = "OrderGV";
            OrderGV.RowHeadersWidth = 51;
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
            OrderAmtlbl.Location = new Point(1036, 562);
            OrderAmtlbl.Name = "OrderAmtlbl";
            OrderAmtlbl.Size = new Size(154, 26);
            OrderAmtlbl.TabIndex = 6;
            OrderAmtlbl.Text = "Order Amount";
            // 
            // SellerNameTb
            // 
            SellerNameTb.Enabled = false;
            SellerNameTb.Font = new Font("Berlin Sans FB", 10.8F);
            SellerNameTb.ForeColor = Color.Green;
            SellerNameTb.Location = new Point(12, 201);
            SellerNameTb.Multiline = true;
            SellerNameTb.Name = "SellerNameTb";
            SellerNameTb.Size = new Size(186, 28);
            SellerNameTb.TabIndex = 5;
            SellerNameTb.Text = "Guest";
            // 
            // OrderNumTb
            // 
            OrderNumTb.Font = new Font("Berlin Sans FB", 10.8F);
            OrderNumTb.ForeColor = Color.Green;
            OrderNumTb.Location = new Point(12, 149);
            OrderNumTb.Multiline = true;
            OrderNumTb.Name = "OrderNumTb";
            OrderNumTb.Size = new Size(186, 30);
            OrderNumTb.TabIndex = 4;
            OrderNumTb.Text = "Order Number";
            // 
            // ItemGV
            // 
            ItemGV.BackgroundColor = SystemColors.Control;
            ItemGV.BorderStyle = BorderStyle.None;
            dataGridViewCellStyle4.Alignment = DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle4.BackColor = SystemColors.Control;
            dataGridViewCellStyle4.Font = new Font("Segoe UI", 9F);
            dataGridViewCellStyle4.ForeColor = SystemColors.WindowText;
            dataGridViewCellStyle4.SelectionBackColor = Color.SpringGreen;
            dataGridViewCellStyle4.SelectionForeColor = SystemColors.HighlightText;
            dataGridViewCellStyle4.WrapMode = DataGridViewTriState.True;
            ItemGV.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle4;
            ItemGV.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            ItemGV.Location = new Point(210, 59);
            ItemGV.Name = "ItemGV";
            dataGridViewCellStyle5.Alignment = DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle5.BackColor = SystemColors.Control;
            dataGridViewCellStyle5.Font = new Font("Segoe UI", 9F);
            dataGridViewCellStyle5.ForeColor = SystemColors.WindowText;
            dataGridViewCellStyle5.SelectionBackColor = Color.SpringGreen;
            dataGridViewCellStyle5.SelectionForeColor = SystemColors.HighlightText;
            dataGridViewCellStyle5.WrapMode = DataGridViewTriState.True;
            ItemGV.RowHeadersDefaultCellStyle = dataGridViewCellStyle5;
            ItemGV.RowHeadersVisible = false;
            ItemGV.RowHeadersWidth = 51;
            dataGridViewCellStyle6.ForeColor = Color.Black;
            dataGridViewCellStyle6.SelectionBackColor = Color.DeepSkyBlue;
            ItemGV.RowsDefaultCellStyle = dataGridViewCellStyle6;
            ItemGV.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            ItemGV.Size = new Size(981, 211);
            ItemGV.TabIndex = 3;
            ItemGV.CellContentClick += ItemGV_CellContentClick;
            // 
            // CatCb
            // 
            CatCb.BackColor = SystemColors.Control;
            CatCb.Font = new Font("Berlin Sans FB", 10.8F);
            CatCb.ForeColor = Color.Green;
            CatCb.FormattingEnabled = true;
            CatCb.Items.AddRange(new object[] { "Rice Box", "Burger", "Wrap", "Cold Drink", "Desserts" });
            CatCb.Location = new Point(12, 59);
            CatCb.Name = "CatCb";
            CatCb.Size = new Size(186, 28);
            CatCb.TabIndex = 2;
            CatCb.Text = "Categories";
            CatCb.SystemColorsChanged += CatCb_SystemColorsChanged;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.BackColor = Color.LightYellow;
            label1.Font = new Font("Viner Hand ITC", 16.2F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label1.ForeColor = Color.Green;
            label1.Location = new Point(604, 3);
            label1.Name = "label1";
            label1.Size = new Size(172, 45);
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
            label4.TabIndex = 12;
            label4.Text = "X";
            label4.Click += label4_Click;
            // 
            // button2
            // 
            button2.BackColor = Color.Honeydew;
            button2.Font = new Font("Berlin Sans FB", 10.8F);
            button2.ForeColor = Color.Red;
            button2.Location = new Point(15, 572);
            button2.Name = "button2";
            button2.Size = new Size(123, 45);
            button2.TabIndex = 14;
            button2.Text = "Logout";
            button2.UseVisualStyleBackColor = false;
            button2.Click += button2_Click;
            // 
            // pictureBox1
            // 
            pictureBox1.Image = (Image)resources.GetObject("pictureBox1.Image");
            pictureBox1.Location = new Point(15, 38);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(139, 110);
            pictureBox1.SizeMode = PictureBoxSizeMode.StretchImage;
            pictureBox1.TabIndex = 15;
            pictureBox1.TabStop = false;
            // 
            // GuestOrder
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.SpringGreen;
            ClientSize = new Size(1387, 649);
            Controls.Add(pictureBox1);
            Controls.Add(panel1);
            Controls.Add(label4);
            Controls.Add(button2);
            FormBorderStyle = FormBorderStyle.None;
            Name = "GuestOrder";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "GuestOrder";
            Load += GuestOrder_Load;
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
        private Button button1;
        private DataGridView OrderGV;
        private Label OrderAmtlbl;
        private TextBox SellerNameTb;
        private TextBox OrderNumTb;
        private DataGridView ItemGV;
        private ComboBox CatCb;
        private Label label1;
        private Label label4;
        private Button button2;
        private PictureBox pictureBox1;
        private Button button4;
        private Label Datelbl;
    }
}