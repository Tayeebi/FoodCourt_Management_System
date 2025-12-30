namespace FoodCourt_Management_System
{
    partial class ViewOrders
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
            OrdersGV = new DataGridView();
            label1 = new Label();
            label2 = new Label();
            CloseBtn = new Button();
            button5 = new Button();
            ((System.ComponentModel.ISupportInitialize)OrdersGV).BeginInit();
            SuspendLayout();
            // 
            // OrdersGV
            // 
            OrdersGV.BackgroundColor = SystemColors.Control;
            OrdersGV.BorderStyle = BorderStyle.None;
            dataGridViewCellStyle4.Alignment = DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle4.BackColor = SystemColors.Control;
            dataGridViewCellStyle4.Font = new Font("Segoe UI", 9F);
            dataGridViewCellStyle4.ForeColor = SystemColors.WindowText;
            dataGridViewCellStyle4.SelectionBackColor = Color.SpringGreen;
            dataGridViewCellStyle4.SelectionForeColor = SystemColors.HighlightText;
            dataGridViewCellStyle4.WrapMode = DataGridViewTriState.True;
            OrdersGV.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle4;
            OrdersGV.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            OrdersGV.EnableHeadersVisualStyles = false;
            OrdersGV.Location = new Point(13, 113);
            OrdersGV.Name = "OrdersGV";
            dataGridViewCellStyle5.Alignment = DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle5.BackColor = SystemColors.Control;
            dataGridViewCellStyle5.Font = new Font("Segoe UI", 9F);
            dataGridViewCellStyle5.ForeColor = SystemColors.WindowText;
            dataGridViewCellStyle5.SelectionBackColor = Color.SpringGreen;
            dataGridViewCellStyle5.SelectionForeColor = SystemColors.HighlightText;
            dataGridViewCellStyle5.WrapMode = DataGridViewTriState.True;
            OrdersGV.RowHeadersDefaultCellStyle = dataGridViewCellStyle5;
            OrdersGV.RowHeadersVisible = false;
            OrdersGV.RowHeadersWidth = 51;
            dataGridViewCellStyle6.Font = new Font("Microsoft Sans Serif", 7.8F, FontStyle.Regular, GraphicsUnit.Point, 0);
            dataGridViewCellStyle6.ForeColor = Color.Black;
            dataGridViewCellStyle6.SelectionBackColor = Color.DeepSkyBlue;
            OrdersGV.RowsDefaultCellStyle = dataGridViewCellStyle6;
            OrdersGV.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            OrdersGV.Size = new Size(1074, 375);
            OrdersGV.TabIndex = 15;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.BackColor = Color.White;
            label1.Font = new Font("Berlin Sans FB Demi", 13.8F, FontStyle.Bold);
            label1.ForeColor = Color.Green;
            label1.Location = new Point(460, 76);
            label1.Name = "label1";
            label1.Size = new Size(185, 27);
            label1.TabIndex = 14;
            label1.Text = "LIST OF ORDERS:";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.BackColor = Color.Linen;
            label2.Font = new Font("Berlin Sans FB Demi", 16.2F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label2.ForeColor = Color.Red;
            label2.Location = new Point(12, 9);
            label2.Name = "label2";
            label2.Size = new Size(191, 33);
            label2.TabIndex = 16;
            label2.Text = "My Foodcourt";
            // 
            // CloseBtn
            // 
            CloseBtn.BackColor = Color.Honeydew;
            CloseBtn.Font = new Font("Berlin Sans FB Demi", 10.8F, FontStyle.Bold);
            CloseBtn.ForeColor = Color.DarkGreen;
            CloseBtn.Location = new Point(459, 502);
            CloseBtn.Name = "CloseBtn";
            CloseBtn.Size = new Size(186, 45);
            CloseBtn.TabIndex = 17;
            CloseBtn.Text = "CLOSED";
            CloseBtn.UseVisualStyleBackColor = false;
            CloseBtn.Click += AddToCartbtn_Click;
            // 
            // button5
            // 
            button5.BackColor = Color.Honeydew;
            button5.Font = new Font("Berlin Sans FB Demi", 10.8F, FontStyle.Bold);
            button5.ForeColor = Color.Green;
            button5.Location = new Point(864, 511);
            button5.Name = "button5";
            button5.Size = new Size(222, 27);
            button5.TabIndex = 18;
            button5.Text = "Print Document Here >>";
            button5.UseVisualStyleBackColor = false;
            button5.Click += button5_Click;
            // 
            // ViewOrders
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.SpringGreen;
            ClientSize = new Size(1098, 559);
            Controls.Add(button5);
            Controls.Add(CloseBtn);
            Controls.Add(label2);
            Controls.Add(OrdersGV);
            Controls.Add(label1);
            FormBorderStyle = FormBorderStyle.None;
            Name = "ViewOrders";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "ViewOrders";
            Load += ViewOrders_Load;
            ((System.ComponentModel.ISupportInitialize)OrdersGV).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private DataGridView OrdersGV;
        private Label label1;
        private Label label2;
        private Button CloseBtn;
        private Button button5;
    }
}