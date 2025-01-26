namespace OnlineShoppingApp
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(ItemsForm));
            btnEditItem = new Button();
            btnDeleteItem = new Button();
            dgvItemsForSale = new DataGridView();
            pictureBoxBack = new PictureBox();
            label7 = new Label();
            pictureBox1 = new PictureBox();
            ((System.ComponentModel.ISupportInitialize)dgvItemsForSale).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBoxBack).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            SuspendLayout();
            // 
            // btnEditItem
            // 
            btnEditItem.Location = new Point(407, 402);
            btnEditItem.Margin = new Padding(5);
            btnEditItem.Name = "btnEditItem";
            btnEditItem.Size = new Size(161, 52);
            btnEditItem.TabIndex = 44;
            btnEditItem.Text = "Edit Item";
            btnEditItem.UseVisualStyleBackColor = true;
            btnEditItem.Click += btnEditItem_Click;
            // 
            // btnDeleteItem
            // 
            btnDeleteItem.Location = new Point(578, 402);
            btnDeleteItem.Margin = new Padding(5);
            btnDeleteItem.Name = "btnDeleteItem";
            btnDeleteItem.Size = new Size(161, 52);
            btnDeleteItem.TabIndex = 43;
            btnDeleteItem.Text = "Delete Item";
            btnDeleteItem.UseVisualStyleBackColor = true;
            btnDeleteItem.Click += btnDeleteItem_Click;
            // 
            // dgvItemsForSale
            // 
            dgvItemsForSale.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.AllCells;
            dgvItemsForSale.BackgroundColor = SystemColors.ScrollBar;
            dgvItemsForSale.BorderStyle = BorderStyle.None;
            dgvItemsForSale.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvItemsForSale.Location = new Point(182, 15);
            dgvItemsForSale.Margin = new Padding(5);
            dgvItemsForSale.Name = "dgvItemsForSale";
            dgvItemsForSale.RowHeadersWidth = 62;
            dgvItemsForSale.Size = new Size(807, 362);
            dgvItemsForSale.TabIndex = 42;
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
            pictureBoxBack.Size = new Size(44, 37);
            pictureBoxBack.SizeMode = PictureBoxSizeMode.StretchImage;
            pictureBoxBack.TabIndex = 57;
            pictureBoxBack.TabStop = false;
            pictureBoxBack.Click += pictureBoxBack_Click;
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Location = new Point(56, 21);
            label7.Margin = new Padding(4, 0, 4, 0);
            label7.Name = "label7";
            label7.Size = new Size(67, 31);
            label7.TabIndex = 58;
            label7.Text = "Home";
            // 
            // pictureBox1
            // 
            pictureBox1.Image = (Image)resources.GetObject("pictureBox1.Image");
            pictureBox1.Location = new Point(-40, 387);
            pictureBox1.Margin = new Padding(5);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(278, 302);
            pictureBox1.SizeMode = PictureBoxSizeMode.Zoom;
            pictureBox1.TabIndex = 59;
            pictureBox1.TabStop = false;
            // 
            // ItemsForm
            // 
            AutoScaleDimensions = new SizeF(12F, 31F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = SystemColors.ScrollBar;
            ClientSize = new Size(1063, 645);
            Controls.Add(btnDeleteItem);
            Controls.Add(btnEditItem);
            Controls.Add(pictureBox1);
            Controls.Add(label7);
            Controls.Add(dgvItemsForSale);
            Controls.Add(pictureBoxBack);
            Font = new Font("Andalus", 10F, FontStyle.Bold);
            ForeColor = Color.FromArgb(192, 0, 0);
            FormBorderStyle = FormBorderStyle.FixedSingle;
            Margin = new Padding(4);
            MaximizeBox = false;
            Name = "ItemsForm";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Online Shopping & Selling App";
            ((System.ComponentModel.ISupportInitialize)dgvItemsForSale).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBoxBack).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion
        private Button btnEditItem;
        private Button btnDeleteItem;
        private DataGridView dgvItemsForSale;
        private PictureBox pictureBoxBack;
        private Label label7;
        private PictureBox pictureBox1;
    }
}