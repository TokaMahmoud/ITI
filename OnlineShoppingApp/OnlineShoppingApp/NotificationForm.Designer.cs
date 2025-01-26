namespace OnlineShoppingApp
{
    partial class NotificationForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(NotificationForm));
            dgvNotifications = new DataGridView();
            pictureBoxBack = new PictureBox();
            pictureBox1 = new PictureBox();
            label7 = new Label();
            ((System.ComponentModel.ISupportInitialize)dgvNotifications).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBoxBack).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            SuspendLayout();
            // 
            // dgvNotifications
            // 
            dgvNotifications.AllowUserToOrderColumns = true;
            dgvNotifications.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.AllCells;
            dgvNotifications.AutoSizeRowsMode = DataGridViewAutoSizeRowsMode.AllCells;
            dgvNotifications.BackgroundColor = SystemColors.ScrollBar;
            dgvNotifications.BorderStyle = BorderStyle.None;
            dgvNotifications.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridViewCellStyle1.Alignment = DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle1.BackColor = SystemColors.Window;
            dataGridViewCellStyle1.Font = new Font("Andalus", 10F, FontStyle.Bold);
            dataGridViewCellStyle1.ForeColor = Color.FromArgb(192, 0, 0);
            dataGridViewCellStyle1.SelectionBackColor = SystemColors.Highlight;
            dataGridViewCellStyle1.SelectionForeColor = SystemColors.HighlightText;
            dataGridViewCellStyle1.WrapMode = DataGridViewTriState.True;
            dgvNotifications.DefaultCellStyle = dataGridViewCellStyle1;
            dgvNotifications.Location = new Point(208, 15);
            dgvNotifications.Margin = new Padding(4);
            dgvNotifications.Name = "dgvNotifications";
            dgvNotifications.RowHeadersWidth = 62;
            dgvNotifications.Size = new Size(828, 438);
            dgvNotifications.TabIndex = 0;
            // 
            // pictureBoxBack
            // 
            pictureBoxBack.BackColor = SystemColors.ScrollBar;
            pictureBoxBack.BackgroundImageLayout = ImageLayout.None;
            pictureBoxBack.BorderStyle = BorderStyle.Fixed3D;
            pictureBoxBack.Image = (Image)resources.GetObject("pictureBoxBack.Image");
            pictureBoxBack.Location = new Point(13, 13);
            pictureBoxBack.Margin = new Padding(4);
            pictureBoxBack.Name = "pictureBoxBack";
            pictureBoxBack.Size = new Size(44, 37);
            pictureBoxBack.SizeMode = PictureBoxSizeMode.StretchImage;
            pictureBoxBack.TabIndex = 57;
            pictureBoxBack.TabStop = false;
            pictureBoxBack.Click += pictureBoxBack_Click;
            // 
            // pictureBox1
            // 
            pictureBox1.Image = (Image)resources.GetObject("pictureBox1.Image");
            pictureBox1.Location = new Point(-35, 363);
            pictureBox1.Margin = new Padding(6);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(247, 206);
            pictureBox1.SizeMode = PictureBoxSizeMode.Zoom;
            pictureBox1.TabIndex = 58;
            pictureBox1.TabStop = false;
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Location = new Point(65, 19);
            label7.Margin = new Padding(4, 0, 4, 0);
            label7.Name = "label7";
            label7.Size = new Size(67, 31);
            label7.TabIndex = 59;
            label7.Text = "Home";
            // 
            // NotificationForm
            // 
            AutoScaleDimensions = new SizeF(12F, 31F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = SystemColors.ScrollBar;
            ClientSize = new Size(1050, 558);
            Controls.Add(label7);
            Controls.Add(pictureBox1);
            Controls.Add(pictureBoxBack);
            Controls.Add(dgvNotifications);
            Font = new Font("Andalus", 10F, FontStyle.Bold);
            ForeColor = Color.FromArgb(192, 0, 0);
            FormBorderStyle = FormBorderStyle.FixedSingle;
            Margin = new Padding(4);
            MaximizeBox = false;
            Name = "NotificationForm";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Online Shopping & Selling App";
            Load += NotificationForm_Load;
            ((System.ComponentModel.ISupportInitialize)dgvNotifications).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBoxBack).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private DataGridView dgvNotifications;
        private PictureBox pictureBoxBack;
        private PictureBox pictureBox1;
        private Label label7;
    }
}