namespace Rompecabezas
{
    partial class Prueba1
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
            picture0 = new PictureBox();
            picture1 = new PictureBox();
            picture2 = new PictureBox();
            ((System.ComponentModel.ISupportInitialize)picture0).BeginInit();
            ((System.ComponentModel.ISupportInitialize)picture1).BeginInit();
            ((System.ComponentModel.ISupportInitialize)picture2).BeginInit();
            SuspendLayout();
            // 
            // picture0
            // 
            picture0.BorderStyle = BorderStyle.Fixed3D;
            picture0.Location = new Point(428, 46);
            picture0.Name = "picture0";
            picture0.Size = new Size(340, 233);
            picture0.SizeMode = PictureBoxSizeMode.StretchImage;
            picture0.TabIndex = 0;
            picture0.TabStop = false;
            picture0.DragDrop += picture0_DragDrop;
            picture0.DragEnter += picture0_DragEnter;
            picture0.MouseDown += picture0_MouseDown;
            // 
            // picture1
            // 
            picture1.BorderStyle = BorderStyle.Fixed3D;
            picture1.Image = Properties.Resources._01_Visit_Juayua_Affordability_shutterstock_468064517;
            picture1.Location = new Point(12, 12);
            picture1.Name = "picture1";
            picture1.Size = new Size(129, 106);
            picture1.SizeMode = PictureBoxSizeMode.StretchImage;
            picture1.TabIndex = 1;
            picture1.TabStop = false;
            picture1.Click += picture1_Click;
            picture1.DragDrop += picture1_DragDrop;
            picture1.DragEnter += picture1_DragEnter;
            picture1.MouseDown += picture1_MouseDown;
            // 
            // picture2
            // 
            picture2.BorderStyle = BorderStyle.Fixed3D;
            picture2.Location = new Point(165, 12);
            picture2.Name = "picture2";
            picture2.Size = new Size(129, 106);
            picture2.SizeMode = PictureBoxSizeMode.StretchImage;
            picture2.TabIndex = 2;
            picture2.TabStop = false;
            picture2.Click += picture2_Click;
            picture2.DragDrop += picture2_DragDrop;
            picture2.DragEnter += picture2_DragEnter;
            picture2.MouseDown += picture2_MouseDown;
            // 
            // Prueba1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(picture2);
            Controls.Add(picture1);
            Controls.Add(picture0);
            Name = "Prueba1";
            Text = "Prueba1";
            Load += Prueba1_Load;
            ((System.ComponentModel.ISupportInitialize)picture0).EndInit();
            ((System.ComponentModel.ISupportInitialize)picture1).EndInit();
            ((System.ComponentModel.ISupportInitialize)picture2).EndInit();
            ResumeLayout(false);
        }

        #endregion
        private Panel panel1;
        private PictureBox picture0;
        private PictureBox picture1;
        private PictureBox picture2;
        private Panel panel2;
        private Panel panel3;
        private Panel panel4;
    }
}