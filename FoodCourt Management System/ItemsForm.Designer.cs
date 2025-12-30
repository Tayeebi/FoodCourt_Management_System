namespace FoodCourt_Management_System
{
    partial class ItemsForm
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
            DataGridViewCellStyle dataGridViewCellStyle1 = new DataGridViewCellStyle();
            DataGridViewCellStyle dataGridViewCellStyle2 = new DataGridViewCellStyle();
            DataGridViewCellStyle dataGridViewCellStyle3 = new DataGridViewCellStyle();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(ItemsForm));
            panel1 = new Panel();
            DeleteBtn = new Button();
            EditBtn = new Button();
            ItemPriceTb = new TextBox();
            label6 = new Label();
            ItemNumTb = new TextBox();
            label5 = new Label();
            label2 = new Label();
            AddBtn = new Button();
            label3 = new Label();
            ItemNameTb = new TextBox();
            ItemGV = new DataGridView();
            CatCb = new ComboBox();
            label1 = new Label();
            button5 = new Button();
            button4 = new Button();
            label4 = new Label();
            button2 = new Button();
            pictureBox1 = new PictureBox();
            panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)ItemGV).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            SuspendLayout();
            // 
            // panel1
            // 
            panel1.BackColor = Color.White;
            panel1.Controls.Add(DeleteBtn);
            panel1.Controls.Add(EditBtn);
            panel1.Controls.Add(ItemPriceTb);
            panel1.Controls.Add(label6);
            panel1.Controls.Add(ItemNumTb);
            panel1.Controls.Add(label5);
            panel1.Controls.Add(label2);
            panel1.Controls.Add(AddBtn);
            panel1.Controls.Add(label3);
            panel1.Controls.Add(ItemNameTb);
            panel1.Controls.Add(ItemGV);
            panel1.Controls.Add(CatCb);
            panel1.Controls.Add(label1);
            panel1.Location = new Point(173, 38);
            panel1.Name = "panel1";
            panel1.Size = new Size(1198, 606);
            panel1.TabIndex = 13;
            // 
            // DeleteBtn
            // 
            DeleteBtn.BackColor = Color.SpringGreen;
            DeleteBtn.Font = new Font("Berlin Sans FB Demi", 10.8F, FontStyle.Bold);
            DeleteBtn.ForeColor = Color.DarkGreen;
            DeleteBtn.Location = new Point(10, 444);
            DeleteBtn.Name = "DeleteBtn";
            DeleteBtn.Size = new Size(304, 45);
            DeleteBtn.TabIndex = 18;
            DeleteBtn.Text = "Delete";
            DeleteBtn.UseVisualStyleBackColor = false;
            DeleteBtn.Click += DeleteBtn_Click;
            // 
            // EditBtn
            // 
            EditBtn.BackColor = Color.SpringGreen;
            EditBtn.Font = new Font("Berlin Sans FB Demi", 10.8F, FontStyle.Bold);
            EditBtn.ForeColor = Color.DarkGreen;
            EditBtn.Location = new Point(10, 384);
            EditBtn.Name = "EditBtn";
            EditBtn.Size = new Size(304, 45);
            EditBtn.TabIndex = 17;
            EditBtn.Text = "Edit";
            EditBtn.UseVisualStyleBackColor = false;
            EditBtn.Click += EditBtn_Click;
            // 
            // ItemPriceTb
            // 
            ItemPriceTb.Font = new Font("Berlin Sans FB", 10.8F);
            ItemPriceTb.ForeColor = Color.Green;
            ItemPriceTb.Location = new Point(121, 220);
            ItemPriceTb.Multiline = true;
            ItemPriceTb.Name = "ItemPriceTb";
            ItemPriceTb.Size = new Size(186, 28);
            ItemPriceTb.TabIndex = 16;
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Font = new Font("Berlin Sans FB", 10.8F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label6.ForeColor = Color.Green;
            label6.Location = new Point(3, 228);
            label6.Name = "label6";
            label6.Size = new Size(86, 20);
            label6.TabIndex = 15;
            label6.Text = "Item Price";
            // 
            // ItemNumTb
            // 
            ItemNumTb.Font = new Font("Berlin Sans FB", 10.8F);
            ItemNumTb.ForeColor = Color.Green;
            ItemNumTb.Location = new Point(121, 106);
            ItemNumTb.Multiline = true;
            ItemNumTb.Name = "ItemNumTb";
            ItemNumTb.Size = new Size(186, 28);
            ItemNumTb.TabIndex = 14;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Font = new Font("Berlin Sans FB", 10.8F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label5.ForeColor = Color.Green;
            label5.Location = new Point(3, 114);
            label5.Name = "label5";
            label5.Size = new Size(113, 20);
            label5.TabIndex = 13;
            label5.Text = "Item Number";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Berlin Sans FB", 10.8F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label2.ForeColor = Color.Green;
            label2.Location = new Point(3, 152);
            label2.Name = "label2";
            label2.Size = new Size(97, 20);
            label2.TabIndex = 12;
            label2.Text = "Item Name";
            // 
            // AddBtn
            // 
            AddBtn.BackColor = Color.SpringGreen;
            AddBtn.Font = new Font("Berlin Sans FB Demi", 10.8F, FontStyle.Bold);
            AddBtn.ForeColor = Color.DarkGreen;
            AddBtn.Location = new Point(10, 323);
            AddBtn.Name = "AddBtn";
            AddBtn.Size = new Size(304, 45);
            AddBtn.TabIndex = 8;
            AddBtn.Text = "Add ";
            AddBtn.UseVisualStyleBackColor = false;
            AddBtn.Click += button1_Click;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.BackColor = Color.Ivory;
            label3.Font = new Font("Berlin Sans FB", 13.8F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label3.ForeColor = Color.Green;
            label3.Location = new Point(679, 66);
            label3.Name = "label3";
            label3.Size = new Size(93, 26);
            label3.TabIndex = 6;
            label3.Text = "Item List";
            // 
            // ItemNameTb
            // 
            ItemNameTb.Font = new Font("Berlin Sans FB", 10.8F);
            ItemNameTb.ForeColor = Color.Green;
            ItemNameTb.Location = new Point(121, 149);
            ItemNameTb.Multiline = true;
            ItemNameTb.Name = "ItemNameTb";
            ItemNameTb.Size = new Size(186, 28);
            ItemNameTb.TabIndex = 4;
            // 
            // ItemGV
            // 
            ItemGV.BackgroundColor = SystemColors.Control;
            dataGridViewCellStyle1.Alignment = DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle1.BackColor = SystemColors.HighlightText;
            dataGridViewCellStyle1.Font = new Font("Segoe UI", 9F);
            dataGridViewCellStyle1.ForeColor = Color.Black;
            dataGridViewCellStyle1.SelectionBackColor = Color.SpringGreen;
            dataGridViewCellStyle1.SelectionForeColor = SystemColors.HighlightText;
            dataGridViewCellStyle1.WrapMode = DataGridViewTriState.True;
            ItemGV.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            ItemGV.ColumnHeadersHeight = 40;
            dataGridViewCellStyle2.Alignment = DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle2.BackColor = SystemColors.Window;
            dataGridViewCellStyle2.Font = new Font("Segoe UI", 9F);
            dataGridViewCellStyle2.ForeColor = Color.Black;
            dataGridViewCellStyle2.SelectionBackColor = Color.DeepSkyBlue;
            dataGridViewCellStyle2.SelectionForeColor = SystemColors.HighlightText;
            dataGridViewCellStyle2.WrapMode = DataGridViewTriState.False;
            ItemGV.DefaultCellStyle = dataGridViewCellStyle2;
            ItemGV.Location = new Point(320, 106);
            ItemGV.Name = "ItemGV";
            ItemGV.RowHeadersVisible = false;
            ItemGV.RowHeadersWidth = 51;
            dataGridViewCellStyle3.SelectionBackColor = Color.DeepSkyBlue;
            ItemGV.RowsDefaultCellStyle = dataGridViewCellStyle3;
            ItemGV.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            ItemGV.Size = new Size(863, 383);
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
            CatCb.Location = new Point(3, 186);
            CatCb.Name = "CatCb";
            CatCb.Size = new Size(304, 28);
            CatCb.TabIndex = 2;
            CatCb.Text = "Categories";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.BackColor = Color.LightYellow;
            label1.Font = new Font("Viner Hand ITC", 16.2F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label1.ForeColor = Color.Green;
            label1.Location = new Point(621, 0);
            label1.Name = "label1";
            label1.Size = new Size(201, 45);
            label1.TabIndex = 1;
            label1.Text = "Manage Item";
            // 
            // button5
            // 
            button5.BackColor = Color.Honeydew;
            button5.Font = new Font("Berlin Sans FB Demi", 10.8F, FontStyle.Bold);
            button5.ForeColor = Color.Green;
            button5.Location = new Point(15, 109);
            button5.Name = "button5";
            button5.Size = new Size(123, 45);
            button5.TabIndex = 16;
            button5.Text = "Users";
            button5.UseVisualStyleBackColor = false;
            button5.Click += button5_Click;
            // 
            // button4
            // 
            button4.BackColor = Color.Honeydew;
            button4.Font = new Font("Berlin Sans FB Demi", 10.8F, FontStyle.Bold);
            button4.ForeColor = Color.Green;
            button4.Location = new Point(15, 38);
            button4.Name = "button4";
            button4.Size = new Size(123, 45);
            button4.TabIndex = 15;
            button4.Text = "Order ";
            button4.UseVisualStyleBackColor = false;
            button4.Click += button4_Click;
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
            pictureBox1.Location = new Point(15, 309);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(139, 87);
            pictureBox1.SizeMode = PictureBoxSizeMode.StretchImage;
            pictureBox1.TabIndex = 17;
            pictureBox1.TabStop = false;
            // 
            // ItemsForm
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.SpringGreen;
            ClientSize = new Size(1387, 649);
            Controls.Add(pictureBox1);
            Controls.Add(panel1);
            Controls.Add(button5);
            Controls.Add(button4);
            Controls.Add(label4);
            Controls.Add(button2);
            FormBorderStyle = FormBorderStyle.None;
            Name = "ItemsForm";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "ItemsForm";
            Load += ItemsForm_Load;
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)ItemGV).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Panel panel1;
        private Button AddBtn;
        private Label label3;
        private TextBox ItemNameTb;
        private DataGridView ItemGV;
        private ComboBox CatCb;
        private Label label1;
        private Button button5;
        private Button button4;
        private Label label4;
        private Button button2;
        private Label label2;
        private TextBox ItemPriceTb;
        private Label label6;
        private TextBox ItemNumTb;
        private Label label5;
        private Button DeleteBtn;
        private Button EditBtn;
        private PictureBox pictureBox1;
    }
}