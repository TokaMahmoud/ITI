namespace OnlineShoppingApp
{
    partial class OrdersForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(OrdersForm));
            dgvOrderItems = new DataGridView();
            btnViewDetails = new Button();
            dgvUserOrders = new DataGridView();
            btnCancelOrder = new Button();
            pictureBox1 = new PictureBox();
            label9 = new Label();
            pictureBoxBack = new PictureBox();
            label7 = new Label();
            ((System.ComponentModel.ISupportInitialize)dgvOrderItems).BeginInit();
            ((System.ComponentModel.ISupportInitialize)dgvUserOrders).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBoxBack).BeginInit();
            SuspendLayout();
            // 
            // dgvOrderItems
            // 
            dgvOrderItems.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.AllCells;
            dgvOrderItems.BackgroundColor = SystemColors.ScrollBar;
            dgvOrderItems.BorderStyle = BorderStyle.None;
            dgvOrderItems.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvOrderItems.Location = new Point(297, 456);
            dgvOrderItems.Margin = new Padding(4);
            dgvOrderItems.Name = "dgvOrderItems";
            dgvOrderItems.RowHeadersWidth = 62;
            dgvOrderItems.Size = new Size(881, 408);
            dgvOrderItems.TabIndex = 59;
            // 
            // btnViewDetails
            // 
            btnViewDetails.Location = new Point(1143, 211);
            btnViewDetails.Margin = new Padding(4);
            btnViewDetails.Name = "btnViewDetails";
            btnViewDetails.Size = new Size(188, 78);
            btnViewDetails.TabIndex = 46;
            btnViewDetails.Text = "View Details";
            btnViewDetails.UseVisualStyleBackColor = true;
            btnViewDetails.Click += btnViewDetails_Click;
            // 
            // dgvUserOrders
            // 
            dgvUserOrders.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.AllCells;
            dgvUserOrders.BackgroundColor = SystemColors.ScrollBar;
            dgvUserOrders.BorderStyle = BorderStyle.None;
            dgvUserOrders.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvUserOrders.Location = new Point(200, 7);
            dgvUserOrders.Margin = new Padding(5);
            dgvUserOrders.Name = "dgvUserOrders";
            dgvUserOrders.RowHeadersWidth = 62;
            dgvUserOrders.Size = new Size(872, 394);
            dgvUserOrders.TabIndex = 44;
            // 
            // btnCancelOrder
            // 
            btnCancelOrder.Location = new Point(1143, 91);
            btnCancelOrder.Margin = new Padding(5);
            btnCancelOrder.Name = "btnCancelOrder";
            btnCancelOrder.Size = new Size(188, 78);
            btnCancelOrder.TabIndex = 45;
            btnCancelOrder.Text = "Cancel Order";
            btnCancelOrder.UseVisualStyleBackColor = true;
            btnCancelOrder.Click += btnCancelOrder_Click;
            // 
            // pictureBox1
            // 
            pictureBox1.Image = (Image)resources.GetObject("pictureBox1.Image");
            pictureBox1.Location = new Point(-45, 631);
            pictureBox1.Margin = new Padding(5);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(316, 311);
            pictureBox1.SizeMode = PictureBoxSizeMode.Zoom;
            pictureBox1.TabIndex = 60;
            pictureBox1.TabStop = false;
            // 
            // label9
            // 
            label9.AutoSize = true;
            label9.Font = new Font("Andalus", 15F, FontStyle.Bold);
            label9.Location = new Point(297, 406);
            label9.Margin = new Padding(4, 0, 4, 0);
            label9.Name = "label9";
            label9.Size = new Size(199, 46);
            label9.TabIndex = 61;
            label9.Text = "Order Details";
            label9.Click += label9_Click;
            // 
            // pictureBoxBack
            // 
            pictureBoxBack.BackColor = SystemColors.ScrollBar;
            pictureBoxBack.BackgroundImageLayout = ImageLayout.None;
            pictureBoxBack.BorderStyle = BorderStyle.Fixed3D;
            pictureBoxBack.Image = (Image)resources.GetObject("pictureBoxBack.Image");
            pictureBoxBack.Location = new Point(14, 15);
            pictureBoxBack.Margin = new Padding(4);
            pictureBoxBack.Name = "pictureBoxBack";
            pictureBoxBack.Size = new Size(52, 45);
            pictureBoxBack.SizeMode = PictureBoxSizeMode.StretchImage;
            pictureBoxBack.TabIndex = 62;
            pictureBoxBack.TabStop = false;
            pictureBoxBack.Click += pictureBoxBack_Click;
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Location = new Point(74, 15);
            label7.Margin = new Padding(4, 0, 4, 0);
            label7.Name = "label7";
            label7.Size = new Size(67, 31);
            label7.TabIndex = 63;
            label7.Text = "Home";
            // 
            // OrdersForm
            // 
            AutoScaleDimensions = new SizeF(12F, 31F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = SystemColors.ScrollBar;
            ClientSize = new Size(1370, 907);
            Controls.Add(label7);
            Controls.Add(pictureBoxBack);
            Controls.Add(label9);
            Controls.Add(pictureBox1);
            Controls.Add(dgvOrderItems);
            Controls.Add(btnViewDetails);
            Controls.Add(dgvUserOrders);
            Controls.Add(btnCancelOrder);
            Font = new Font("Andalus", 10F, FontStyle.Bold);
            ForeColor = Color.FromArgb(192, 0, 0);
            FormBorderStyle = FormBorderStyle.FixedSingle;
            Margin = new Padding(4);
            MaximizeBox = false;
            Name = "OrdersForm";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Online Shopping & Selling App";
            Load += OrdersForm_Load;
            ((System.ComponentModel.ISupportInitialize)dgvOrderItems).EndInit();
            ((System.ComponentModel.ISupportInitialize)dgvUserOrders).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBoxBack).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private DataGridView dgvOrderItems;
        private Button btnViewDetails;
        private DataGridView dgvUserOrders;
        private Button btnCancelOrder;
        private PictureBox pictureBox1;
        private Label label9;
        private PictureBox pictureBoxBack;
        private Label label7;
    }
}