namespace FoodCourt_Management_System
{
    partial class UserForm
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
            DataGridViewCellStyle dataGridViewCellStyle4 = new DataGridViewCellStyle();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(UserForm));
            button2 = new Button();
            DeleteBtn = new Button();
            EditBtn = new Button();
            upassTb = new TextBox();
            label6 = new Label();
            uphoneTb = new TextBox();
            label5 = new Label();
            label2 = new Label();
            button5 = new Button();
            button4 = new Button();
            AddBtn = new Button();
            label3 = new Label();
            UsersGV = new DataGridView();
            label1 = new Label();
            label4 = new Label();
            unameTb = new TextBox();
            panel1 = new Panel();
            pictureBox1 = new PictureBox();
            ((System.ComponentModel.ISupportInitialize)UsersGV).BeginInit();
            panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            SuspendLayout();
            // 
            // button2
            // 
            button2.BackColor = Color.Honeydew;
            button2.Font = new Font("Berlin Sans FB", 10.8F);
            button2.ForeColor = Color.Red;
            button2.Location = new Point(15, 572);
            button2.Name = "button2";
            button2.Size = new Size(123, 45);
            button2.TabIndex = 19;
            button2.Text = "Logout";
            button2.UseVisualStyleBackColor = false;
            button2.Click += button2_Click;
            // 
            // DeleteBtn
            // 
            DeleteBtn.BackColor = Color.SpringGreen;
            DeleteBtn.Font = new Font("Berlin Sans FB Demi", 10.8F, FontStyle.Bold);
            DeleteBtn.ForeColor = Color.DarkGreen;
            DeleteBtn.Location = new Point(8, 444);
            DeleteBtn.Name = "DeleteBtn";
            DeleteBtn.Size = new Size(281, 45);
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
            EditBtn.Location = new Point(8, 393);
            EditBtn.Name = "EditBtn";
            EditBtn.Size = new Size(281, 45);
            EditBtn.TabIndex = 17;
            EditBtn.Text = "Edit";
            EditBtn.UseVisualStyleBackColor = false;
            EditBtn.Click += EditBtn_Click;
            // 
            // upassTb
            // 
            upassTb.Font = new Font("Berlin Sans FB", 10.8F);
            upassTb.ForeColor = Color.Green;
            upassTb.Location = new Point(8, 308);
            upassTb.Multiline = true;
            upassTb.Name = "upassTb";
            upassTb.Size = new Size(281, 28);
            upassTb.TabIndex = 16;
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Font = new Font("Berlin Sans FB", 10.8F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label6.ForeColor = Color.Green;
            label6.Location = new Point(8, 285);
            label6.Name = "label6";
            label6.Size = new Size(68, 20);
            label6.TabIndex = 15;
            label6.Text = "Passkey";
            // 
            // uphoneTb
            // 
            uphoneTb.Font = new Font("Berlin Sans FB", 10.8F);
            uphoneTb.ForeColor = Color.Green;
            uphoneTb.Location = new Point(8, 227);
            uphoneTb.Multiline = true;
            uphoneTb.Name = "uphoneTb";
            uphoneTb.Size = new Size(281, 28);
            uphoneTb.TabIndex = 14;
            uphoneTb.TextChanged += textBox3_TextChanged;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Font = new Font("Berlin Sans FB", 10.8F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label5.ForeColor = Color.Green;
            label5.Location = new Point(8, 204);
            label5.Name = "label5";
            label5.Size = new Size(125, 20);
            label5.TabIndex = 13;
            label5.Text = "Phone Number";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Berlin Sans FB", 10.8F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label2.ForeColor = Color.Green;
            label2.Location = new Point(8, 119);
            label2.Name = "label2";
            label2.Size = new Size(94, 20);
            label2.TabIndex = 12;
            label2.Text = "User Name";
            // 
            // button5
            // 
            button5.BackColor = Color.Honeydew;
            button5.Font = new Font("Berlin Sans FB Demi", 10.8F, FontStyle.Bold);
            button5.ForeColor = Color.Green;
            button5.Location = new Point(15, 109);
            button5.Name = "button5";
            button5.Size = new Size(123, 45);
            button5.TabIndex = 21;
            button5.Text = "Items";
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
            button4.TabIndex = 20;
            button4.Text = "Order ";
            button4.UseVisualStyleBackColor = false;
            button4.Click += button4_Click;
            // 
            // AddBtn
            // 
            AddBtn.BackColor = Color.SpringGreen;
            AddBtn.Font = new Font("Berlin Sans FB Demi", 10.8F, FontStyle.Bold);
            AddBtn.ForeColor = Color.DarkGreen;
            AddBtn.Location = new Point(8, 342);
            AddBtn.Name = "AddBtn";
            AddBtn.Size = new Size(281, 45);
            AddBtn.TabIndex = 8;
            AddBtn.Text = "Add ";
            AddBtn.UseVisualStyleBackColor = false;
            AddBtn.Click += AddBtn_Click;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.BackColor = Color.Ivory;
            label3.Font = new Font("Berlin Sans FB", 13.8F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label3.ForeColor = Color.Green;
            label3.Location = new Point(685, 66);
            label3.Name = "label3";
            label3.Size = new Size(98, 26);
            label3.TabIndex = 6;
            label3.Text = "Users List";
            // 
            // UsersGV
            // 
            UsersGV.BackgroundColor = SystemColors.Control;
            UsersGV.BorderStyle = BorderStyle.None;
            dataGridViewCellStyle1.Alignment = DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle1.BackColor = SystemColors.Control;
            dataGridViewCellStyle1.Font = new Font("Segoe UI", 9F);
            dataGridViewCellStyle1.ForeColor = Color.Black;
            dataGridViewCellStyle1.SelectionBackColor = Color.SpringGreen;
            dataGridViewCellStyle1.SelectionForeColor = SystemColors.HighlightText;
            dataGridViewCellStyle1.WrapMode = DataGridViewTriState.True;
            UsersGV.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            UsersGV.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridViewCellStyle2.Alignment = DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = SystemColors.Window;
            dataGridViewCellStyle2.Font = new Font("Segoe UI", 9F);
            dataGridViewCellStyle2.ForeColor = Color.Black;
            dataGridViewCellStyle2.SelectionBackColor = Color.DeepSkyBlue;
            dataGridViewCellStyle2.SelectionForeColor = SystemColors.HighlightText;
            dataGridViewCellStyle2.WrapMode = DataGridViewTriState.False;
            UsersGV.DefaultCellStyle = dataGridViewCellStyle2;
            UsersGV.Location = new Point(295, 106);
            UsersGV.Name = "UsersGV";
            dataGridViewCellStyle3.Alignment = DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle3.BackColor = SystemColors.Control;
            dataGridViewCellStyle3.Font = new Font("Segoe UI", 9F);
            dataGridViewCellStyle3.ForeColor = Color.Gainsboro;
            dataGridViewCellStyle3.SelectionBackColor = Color.SpringGreen;
            dataGridViewCellStyle3.SelectionForeColor = SystemColors.HighlightText;
            dataGridViewCellStyle3.WrapMode = DataGridViewTriState.True;
            UsersGV.RowHeadersDefaultCellStyle = dataGridViewCellStyle3;
            UsersGV.RowHeadersVisible = false;
            UsersGV.RowHeadersWidth = 51;
            dataGridViewCellStyle4.SelectionBackColor = Color.DeepSkyBlue;
            UsersGV.RowsDefaultCellStyle = dataGridViewCellStyle4;
            UsersGV.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            UsersGV.Size = new Size(892, 383);
            UsersGV.TabIndex = 3;
            UsersGV.CellContentClick += UsersGV_CellContentClick;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.BackColor = Color.LightYellow;
            label1.Font = new Font("Viner Hand ITC", 16.2F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label1.ForeColor = Color.Green;
            label1.Location = new Point(633, 0);
            label1.Name = "label1";
            label1.Size = new Size(204, 45);
            label1.TabIndex = 1;
            label1.Text = "Manage Users";
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
            label4.TabIndex = 17;
            label4.Text = "X";
            label4.Click += label4_Click;
            // 
            // unameTb
            // 
            unameTb.Font = new Font("Berlin Sans FB", 10.8F);
            unameTb.ForeColor = Color.Green;
            unameTb.Location = new Point(8, 142);
            unameTb.Multiline = true;
            unameTb.Name = "unameTb";
            unameTb.Size = new Size(281, 28);
            unameTb.TabIndex = 4;
            // 
            // panel1
            // 
            panel1.BackColor = Color.White;
            panel1.Controls.Add(DeleteBtn);
            panel1.Controls.Add(EditBtn);
            panel1.Controls.Add(upassTb);
            panel1.Controls.Add(label6);
            panel1.Controls.Add(uphoneTb);
            panel1.Controls.Add(label5);
            panel1.Controls.Add(label2);
            panel1.Controls.Add(AddBtn);
            panel1.Controls.Add(label3);
            panel1.Controls.Add(unameTb);
            panel1.Controls.Add(UsersGV);
            panel1.Controls.Add(label1);
            panel1.Location = new Point(173, 38);
            panel1.Name = "panel1";
            panel1.Size = new Size(1198, 606);
            panel1.TabIndex = 18;
            // 
            // pictureBox1
            // 
            pictureBox1.Image = (Image)resources.GetObject("pictureBox1.Image");
            pictureBox1.Location = new Point(12, 256);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(139, 87);
            pictureBox1.SizeMode = PictureBoxSizeMode.StretchImage;
            pictureBox1.TabIndex = 22;
            pictureBox1.TabStop = false;
            // 
            // UserForm
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.SpringGreen;
            ClientSize = new Size(1387, 649);
            Controls.Add(pictureBox1);
            Controls.Add(button2);
            Controls.Add(button5);
            Controls.Add(button4);
            Controls.Add(label4);
            Controls.Add(panel1);
            FormBorderStyle = FormBorderStyle.None;
            Name = "UserForm";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "UserForm";
            Load += UserForm_Load;
            ((System.ComponentModel.ISupportInitialize)UsersGV).EndInit();
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button button2;
        private Button DeleteBtn;
        private Button EditBtn;
        private TextBox upassTb;
        private Label label6;
        private TextBox uphoneTb;
        private Label label5;
        private Label label2;
        private Button button5;
        private Button button4;
        private Button AddBtn;
        private Label label3;
        private DataGridView UsersGV;
        private Label label1;
        private Label label4;
        private TextBox unameTb;
        private Panel panel1;
        private PictureBox pictureBox1;
    }
}