namespace Rompecabezas
{
    partial class Menu
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Menu));
            panel2 = new Panel();
            panel3 = new Panel();
            panel4 = new Panel();
            panel1 = new Panel();
            Rp2 = new Button();
            Rp3 = new Button();
            pictureBox2 = new PictureBox();
            Rp1 = new Button();
            pictureBox3 = new PictureBox();
            pictureBox1 = new PictureBox();
            pictureBox4 = new PictureBox();
            panel5 = new Panel();
            panel6 = new Panel();
            panel2.SuspendLayout();
            panel3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox2).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox3).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox4).BeginInit();
            panel5.SuspendLayout();
            SuspendLayout();
            // 
            // panel2
            // 
            panel2.BackColor = Color.FromArgb(0, 17, 35);
            panel2.Controls.Add(panel3);
            panel2.Controls.Add(panel1);
            panel2.Location = new Point(25, 270);
            panel2.Name = "panel2";
            panel2.Size = new Size(808, 10);
            panel2.TabIndex = 24;
            // 
            // panel3
            // 
            panel3.BackColor = Color.White;
            panel3.Controls.Add(panel4);
            panel3.Location = new Point(0, 0);
            panel3.Name = "panel3";
            panel3.Size = new Size(808, 10);
            panel3.TabIndex = 25;
            // 
            // panel4
            // 
            panel4.BackColor = Color.FromArgb(18, 26, 53);
            panel4.Location = new Point(15, 14);
            panel4.Name = "panel4";
            panel4.Size = new Size(807, 300);
            panel4.TabIndex = 22;
            // 
            // panel1
            // 
            panel1.BackColor = Color.FromArgb(18, 26, 53);
            panel1.Location = new Point(15, 14);
            panel1.Name = "panel1";
            panel1.Size = new Size(807, 300);
            panel1.TabIndex = 22;
            // 
            // Rp2
            // 
            Rp2.BackColor = Color.FromArgb(0, 0, 21);
            Rp2.FlatStyle = FlatStyle.Popup;
            Rp2.Font = new Font("Impact", 14.25F, FontStyle.Regular, GraphicsUnit.Point);
            Rp2.ForeColor = Color.White;
            Rp2.Location = new Point(377, 304);
            Rp2.Name = "Rp2";
            Rp2.Size = new Size(109, 40);
            Rp2.TabIndex = 20;
            Rp2.Text = "Medio";
            Rp2.UseVisualStyleBackColor = false;
            // 
            // Rp3
            // 
            Rp3.BackColor = Color.FromArgb(0, 0, 21);
            Rp3.FlatStyle = FlatStyle.Popup;
            Rp3.Font = new Font("Impact", 14.25F, FontStyle.Regular, GraphicsUnit.Point);
            Rp3.ForeColor = Color.White;
            Rp3.Location = new Point(588, 304);
            Rp3.Name = "Rp3";
            Rp3.Size = new Size(116, 40);
            Rp3.TabIndex = 21;
            Rp3.Text = "Difícil";
            Rp3.UseVisualStyleBackColor = false;
            // 
            // pictureBox2
            // 
            pictureBox2.BorderStyle = BorderStyle.Fixed3D;
            pictureBox2.Image = (Image)resources.GetObject("pictureBox2.Image");
            pictureBox2.Location = new Point(337, 108);
            pictureBox2.Name = "pictureBox2";
            pictureBox2.Size = new Size(190, 144);
            pictureBox2.SizeMode = PictureBoxSizeMode.StretchImage;
            pictureBox2.TabIndex = 17;
            pictureBox2.TabStop = false;
            pictureBox2.Click += pictureBox2_Click;
            // 
            // Rp1
            // 
            Rp1.AutoSizeMode = AutoSizeMode.GrowAndShrink;
            Rp1.BackColor = Color.FromArgb(0, 0, 21);
            Rp1.FlatStyle = FlatStyle.Popup;
            Rp1.Font = new Font("Impact", 14.25F, FontStyle.Regular, GraphicsUnit.Point);
            Rp1.ForeColor = Color.White;
            Rp1.Location = new Point(147, 304);
            Rp1.Name = "Rp1";
            Rp1.Size = new Size(109, 40);
            Rp1.TabIndex = 19;
            Rp1.Text = "Fácil";
            Rp1.UseVisualStyleBackColor = false;
            Rp1.Click += Rp1_Click_1;
            // 
            // pictureBox3
            // 
            pictureBox3.BorderStyle = BorderStyle.Fixed3D;
            pictureBox3.Image = (Image)resources.GetObject("pictureBox3.Image");
            pictureBox3.Location = new Point(563, 108);
            pictureBox3.Name = "pictureBox3";
            pictureBox3.Size = new Size(177, 144);
            pictureBox3.SizeMode = PictureBoxSizeMode.StretchImage;
            pictureBox3.TabIndex = 18;
            pictureBox3.TabStop = false;
            pictureBox3.Click += pictureBox3_Click;
            // 
            // pictureBox1
            // 
            pictureBox1.BorderStyle = BorderStyle.Fixed3D;
            pictureBox1.Image = (Image)resources.GetObject("pictureBox1.Image");
            pictureBox1.Location = new Point(111, 108);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(190, 144);
            pictureBox1.SizeMode = PictureBoxSizeMode.StretchImage;
            pictureBox1.TabIndex = 16;
            pictureBox1.TabStop = false;
            pictureBox1.Click += pictureBox1_Click;
            // 
            // pictureBox4
            // 
            pictureBox4.BackColor = Color.Transparent;
            pictureBox4.Image = (Image)resources.GetObject("pictureBox4.Image");
            pictureBox4.Location = new Point(824, 347);
            pictureBox4.Name = "pictureBox4";
            pictureBox4.Size = new Size(50, 50);
            pictureBox4.SizeMode = PictureBoxSizeMode.StretchImage;
            pictureBox4.TabIndex = 22;
            pictureBox4.TabStop = false;
            pictureBox4.Click += pictureBox4_Click_1;
            // 
            // panel5
            // 
            panel5.BackColor = Color.White;
            panel5.Controls.Add(panel6);
            panel5.Location = new Point(25, 68);
            panel5.Name = "panel5";
            panel5.Size = new Size(808, 10);
            panel5.TabIndex = 26;
            // 
            // panel6
            // 
            panel6.BackColor = Color.FromArgb(18, 26, 53);
            panel6.Location = new Point(15, 14);
            panel6.Name = "panel6";
            panel6.Size = new Size(807, 300);
            panel6.TabIndex = 22;
            // 
            // Menu
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackgroundImage = (Image)resources.GetObject("$this.BackgroundImage");
            BackgroundImageLayout = ImageLayout.Stretch;
            ClientSize = new Size(900, 409);
            ControlBox = false;
            Controls.Add(panel5);
            Controls.Add(pictureBox4);
            Controls.Add(panel2);
            Controls.Add(pictureBox1);
            Controls.Add(pictureBox3);
            Controls.Add(Rp2);
            Controls.Add(Rp1);
            Controls.Add(Rp3);
            Controls.Add(pictureBox2);
            IsMdiContainer = true;
            Name = "Menu";
            Text = "Menu";
            Load += Menu_Load;
            panel2.ResumeLayout(false);
            panel3.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)pictureBox2).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox3).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox4).EndInit();
            panel5.ResumeLayout(false);
            ResumeLayout(false);
        }

        #endregion
        private Panel panel2;
        private Panel panel3;
        private Panel panel4;
        private Panel panel1;
        private Button Rp2;
        private Button Rp3;
        private PictureBox pictureBox2;
        private Button Rp1;
        private PictureBox pictureBox3;
        private PictureBox pictureBox1;
        private PictureBox pictureBox4;
        private Panel panel5;
        private Panel panel6;
    }
}