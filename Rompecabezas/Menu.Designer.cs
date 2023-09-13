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
            pictureBox3 = new PictureBox();
            pictureBox2 = new PictureBox();
            pictureBox1 = new PictureBox();
            Rp1 = new Button();
            Rp2 = new Button();
            Rp3 = new Button();
            pictureBox4 = new PictureBox();
            Close = new Button();
            ((System.ComponentModel.ISupportInitialize)pictureBox3).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox2).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox4).BeginInit();
            SuspendLayout();
            // 
            // pictureBox3
            // 
            pictureBox3.BorderStyle = BorderStyle.Fixed3D;
            pictureBox3.Image = (Image)resources.GetObject("pictureBox3.Image");
            pictureBox3.Location = new Point(347, 141);
            pictureBox3.Name = "pictureBox3";
            pictureBox3.Size = new Size(139, 120);
            pictureBox3.SizeMode = PictureBoxSizeMode.StretchImage;
            pictureBox3.TabIndex = 5;
            pictureBox3.TabStop = false;
            // 
            // pictureBox2
            // 
            pictureBox2.BorderStyle = BorderStyle.Fixed3D;
            pictureBox2.Image = (Image)resources.GetObject("pictureBox2.Image");
            pictureBox2.Location = new Point(177, 141);
            pictureBox2.Name = "pictureBox2";
            pictureBox2.Size = new Size(139, 120);
            pictureBox2.SizeMode = PictureBoxSizeMode.StretchImage;
            pictureBox2.TabIndex = 4;
            pictureBox2.TabStop = false;
            // 
            // pictureBox1
            // 
            pictureBox1.BorderStyle = BorderStyle.Fixed3D;
            pictureBox1.Image = (Image)resources.GetObject("pictureBox1.Image");
            pictureBox1.Location = new Point(0, 141);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(139, 120);
            pictureBox1.SizeMode = PictureBoxSizeMode.StretchImage;
            pictureBox1.TabIndex = 3;
            pictureBox1.TabStop = false;
            // 
            // Rp1
            // 
            Rp1.Location = new Point(23, 307);
            Rp1.Name = "Rp1";
            Rp1.Size = new Size(79, 26);
            Rp1.TabIndex = 6;
            Rp1.Text = "Fácil";
            Rp1.UseVisualStyleBackColor = true;
            // 
            // Rp2
            // 
            Rp2.Location = new Point(195, 307);
            Rp2.Name = "Rp2";
            Rp2.Size = new Size(91, 26);
            Rp2.TabIndex = 7;
            Rp2.Text = "Medio";
            Rp2.UseVisualStyleBackColor = true;
            // 
            // Rp3
            // 
            Rp3.Location = new Point(375, 307);
            Rp3.Name = "Rp3";
            Rp3.Size = new Size(96, 26);
            Rp3.TabIndex = 8;
            Rp3.Text = "Difícil";
            Rp3.UseVisualStyleBackColor = true;
            // 
            // pictureBox4
            // 
            pictureBox4.BackgroundImageLayout = ImageLayout.Stretch;
            pictureBox4.Dock = DockStyle.Fill;
            pictureBox4.Image = (Image)resources.GetObject("pictureBox4.Image");
            pictureBox4.Location = new Point(0, 0);
            pictureBox4.Name = "pictureBox4";
            pictureBox4.Size = new Size(496, 450);
            pictureBox4.TabIndex = 10;
            pictureBox4.TabStop = false;
            pictureBox4.Click += pictureBox4_Click;
            // 
            // Close
            // 
            Close.Location = new Point(396, 415);
            Close.Name = "Close";
            Close.Size = new Size(75, 23);
            Close.TabIndex = 12;
            Close.Text = "Cerrar";
            Close.UseVisualStyleBackColor = true;
            // 
            // Menu
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(496, 450);
            ControlBox = false;
            Controls.Add(Close);
            Controls.Add(Rp3);
            Controls.Add(Rp2);
            Controls.Add(Rp1);
            Controls.Add(pictureBox3);
            Controls.Add(pictureBox2);
            Controls.Add(pictureBox1);
            Controls.Add(pictureBox4);
            IsMdiContainer = true;
            Name = "Menu";
            Text = "Menu";
            Load += Menu_Load;
            ((System.ComponentModel.ISupportInitialize)pictureBox3).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox2).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox4).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private PictureBox pictureBox3;
        private PictureBox pictureBox2;
        private PictureBox pictureBox1;
        private Button Rp1;
        private Button Rp2;
        private Button Rp3;
        private PictureBox pictureBox4;
        private Button Close;
    }
}