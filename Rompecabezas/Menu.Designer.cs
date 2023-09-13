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
            label1 = new Label();
            pictureBox4 = new PictureBox();
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
            pictureBox3.Location = new Point(524, 93);
            pictureBox3.Name = "pictureBox3";
            pictureBox3.Size = new Size(215, 176);
            pictureBox3.SizeMode = PictureBoxSizeMode.StretchImage;
            pictureBox3.TabIndex = 5;
            pictureBox3.TabStop = false;
            // 
            // pictureBox2
            // 
            pictureBox2.BorderStyle = BorderStyle.Fixed3D;
            pictureBox2.Image = (Image)resources.GetObject("pictureBox2.Image");
            pictureBox2.Location = new Point(288, 93);
            pictureBox2.Name = "pictureBox2";
            pictureBox2.Size = new Size(215, 176);
            pictureBox2.SizeMode = PictureBoxSizeMode.StretchImage;
            pictureBox2.TabIndex = 4;
            pictureBox2.TabStop = false;
            // 
            // pictureBox1
            // 
            pictureBox1.BorderStyle = BorderStyle.Fixed3D;
            pictureBox1.Image = (Image)resources.GetObject("pictureBox1.Image");
            pictureBox1.Location = new Point(50, 93);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(215, 176);
            pictureBox1.SizeMode = PictureBoxSizeMode.StretchImage;
            pictureBox1.TabIndex = 3;
            pictureBox1.TabStop = false;
            // 
            // Rp1
            // 
            Rp1.Location = new Point(105, 291);
            Rp1.Name = "Rp1";
            Rp1.Size = new Size(99, 39);
            Rp1.TabIndex = 6;
            Rp1.Text = "Fácil";
            Rp1.UseVisualStyleBackColor = true;
            // 
            // Rp2
            // 
            Rp2.Location = new Point(348, 291);
            Rp2.Name = "Rp2";
            Rp2.Size = new Size(99, 39);
            Rp2.TabIndex = 7;
            Rp2.Text = "Medio";
            Rp2.UseVisualStyleBackColor = true;
            // 
            // Rp3
            // 
            Rp3.Location = new Point(581, 291);
            Rp3.Name = "Rp3";
            Rp3.Size = new Size(99, 39);
            Rp3.TabIndex = 8;
            Rp3.Text = "Difícil";
            Rp3.UseVisualStyleBackColor = true;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Showcard Gothic", 36F, FontStyle.Italic, GraphicsUnit.Point);
            label1.Location = new Point(209, 9);
            label1.Name = "label1";
            label1.Size = new Size(394, 60);
            label1.TabIndex = 9;
            label1.Text = "ROMPECABEZAS";
            // 
            // pictureBox4
            // 
            pictureBox4.Dock = DockStyle.Fill;
            pictureBox4.Image = (Image)resources.GetObject("pictureBox4.Image");
            pictureBox4.Location = new Point(0, 0);
            pictureBox4.Name = "pictureBox4";
            pictureBox4.Size = new Size(800, 450);
            pictureBox4.SizeMode = PictureBoxSizeMode.StretchImage;
            pictureBox4.TabIndex = 10;
            pictureBox4.TabStop = false;
            // 
            // Menu
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(label1);
            Controls.Add(Rp3);
            Controls.Add(Rp2);
            Controls.Add(Rp1);
            Controls.Add(pictureBox3);
            Controls.Add(pictureBox2);
            Controls.Add(pictureBox1);
            Controls.Add(pictureBox4);
            Name = "Menu";
            Text = "Menu";
            Load += Menu_Load;
            ((System.ComponentModel.ISupportInitialize)pictureBox3).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox2).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox4).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private PictureBox pictureBox3;
        private PictureBox pictureBox2;
        private PictureBox pictureBox1;
        private Button Rp1;
        private Button Rp2;
        private Button Rp3;
        private Label label1;
        private PictureBox pictureBox4;
    }
}