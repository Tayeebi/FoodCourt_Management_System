namespace FoodCourt_Management_System
{
    partial class Form1
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            panel1 = new Panel();
            pictureBox1 = new PictureBox();
            label5 = new Label();
            label4 = new Label();
            label1 = new Label();
            label2 = new Label();
            label3 = new Label();
            unameTb = new TextBox();
            PasswordTb = new TextBox();
            LoginBtn = new Button();
            GuestBtn = new Button();
            SignupBtn = new Button();
            label6 = new Label();
            panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            SuspendLayout();
            // 
            // panel1
            // 
            panel1.BackColor = Color.SpringGreen;
            panel1.Controls.Add(pictureBox1);
            panel1.Controls.Add(label5);
            panel1.Controls.Add(label4);
            panel1.Dock = DockStyle.Right;
            panel1.Location = new Point(366, 0);
            panel1.Name = "panel1";
            panel1.Size = new Size(454, 463);
            panel1.TabIndex = 0;
            // 
            // pictureBox1
            // 
            pictureBox1.Image = (Image)resources.GetObject("pictureBox1.Image");
            pictureBox1.Location = new Point(3, 76);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(448, 384);
            pictureBox1.SizeMode = PictureBoxSizeMode.StretchImage;
            pictureBox1.TabIndex = 7;
            pictureBox1.TabStop = false;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.BackColor = Color.SpringGreen;
            label5.Font = new Font("Viner Hand ITC", 16.2F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label5.ForeColor = Color.Green;
            label5.Location = new Point(3, 28);
            label5.Name = "label5";
            label5.Size = new Size(446, 45);
            label5.TabIndex = 6;
            label5.Text = "Foodcourt Management System";
            label5.Click += label5_Click;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.BackColor = Color.White;
            label4.Font = new Font("Berlin Sans FB", 10.8F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label4.ForeColor = Color.Red;
            label4.Location = new Point(432, 4);
            label4.Name = "label4";
            label4.Size = new Size(19, 20);
            label4.TabIndex = 3;
            label4.Text = "X";
            label4.Click += label4_Click;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Viner Hand ITC", 16.2F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label1.ForeColor = Color.Green;
            label1.Location = new Point(96, 9);
            label1.Name = "label1";
            label1.Size = new Size(202, 45);
            label1.TabIndex = 0;
            label1.Text = "My Foodcourt";
            label1.Click += label1_Click;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Berlin Sans FB", 10.8F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label2.ForeColor = Color.Green;
            label2.Location = new Point(1, 105);
            label2.Name = "label2";
            label2.Size = new Size(85, 20);
            label2.TabIndex = 0;
            label2.Text = "Username";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Berlin Sans FB", 10.8F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label3.ForeColor = Color.Green;
            label3.Location = new Point(6, 197);
            label3.Name = "label3";
            label3.Size = new Size(78, 20);
            label3.TabIndex = 1;
            label3.Text = "Password";
            // 
            // unameTb
            // 
            unameTb.Font = new Font("Times New Roman", 10.2F, FontStyle.Bold);
            unameTb.ForeColor = Color.FromArgb(64, 64, 64);
            unameTb.Location = new Point(3, 128);
            unameTb.Multiline = true;
            unameTb.Name = "unameTb";
            unameTb.Size = new Size(305, 39);
            unameTb.TabIndex = 0;
            unameTb.TextChanged += unameTb_TextChanged;
            // 
            // PasswordTb
            // 
            PasswordTb.Font = new Font("Times New Roman", 10.2F, FontStyle.Bold);
            PasswordTb.ForeColor = Color.FromArgb(64, 64, 64);
            PasswordTb.Location = new Point(4, 220);
            PasswordTb.Multiline = true;
            PasswordTb.Name = "PasswordTb";
            PasswordTb.Size = new Size(305, 39);
            PasswordTb.TabIndex = 2;
            // 
            // LoginBtn
            // 
            LoginBtn.BackColor = Color.SpringGreen;
            LoginBtn.Font = new Font("Berlin Sans FB", 10.8F);
            LoginBtn.ForeColor = Color.DarkGreen;
            LoginBtn.Location = new Point(6, 317);
            LoginBtn.Name = "LoginBtn";
            LoginBtn.Size = new Size(123, 45);
            LoginBtn.TabIndex = 4;
            LoginBtn.Text = "Login";
            LoginBtn.UseVisualStyleBackColor = false;
            LoginBtn.Click += button1_Click;
            // 
            // GuestBtn
            // 
            GuestBtn.BackColor = Color.SpringGreen;
            GuestBtn.Font = new Font("Berlin Sans FB", 10.8F);
            GuestBtn.ForeColor = Color.DarkGreen;
            GuestBtn.Location = new Point(190, 317);
            GuestBtn.Name = "GuestBtn";
            GuestBtn.Size = new Size(123, 45);
            GuestBtn.TabIndex = 5;
            GuestBtn.Text = "Guest";
            GuestBtn.UseVisualStyleBackColor = false;
            GuestBtn.Click += button2_Click;
            // 
            // SignupBtn
            // 
            SignupBtn.BackColor = Color.SpringGreen;
            SignupBtn.Font = new Font("Berlin Sans FB", 10.8F);
            SignupBtn.ForeColor = Color.DarkGreen;
            SignupBtn.Location = new Point(87, 415);
            SignupBtn.Name = "SignupBtn";
            SignupBtn.Size = new Size(153, 36);
            SignupBtn.TabIndex = 6;
            SignupBtn.Text = "Go to Sign-Up";
            SignupBtn.UseVisualStyleBackColor = false;
            SignupBtn.Click += SignupBtn_Click;
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Font = new Font("Berlin Sans FB", 10.8F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label6.ForeColor = Color.Green;
            label6.Location = new Point(109, 392);
            label6.Name = "label6";
            label6.Size = new Size(101, 20);
            label6.TabIndex = 7;
            label6.Text = "No account?";
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = SystemColors.ControlLight;
            ClientSize = new Size(820, 463);
            Controls.Add(label6);
            Controls.Add(SignupBtn);
            Controls.Add(GuestBtn);
            Controls.Add(LoginBtn);
            Controls.Add(PasswordTb);
            Controls.Add(unameTb);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(label1);
            Controls.Add(panel1);
            FormBorderStyle = FormBorderStyle.None;
            Name = "Form1";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Form1";
            Load += Form1_Load;
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Panel panel1;
        private Label label1;
        private Label label2;
        private Label label3;
        private TextBox unameTb;
        private TextBox PasswordTb;
        private Label label4;
        private Button LoginBtn;
        private Button GuestBtn;
        private Label label5;
        private PictureBox pictureBox1;
        private Button SignupBtn;
        private Label label6;
    }
}
