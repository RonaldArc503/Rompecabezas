namespace Rompecabezas
{
    partial class Resolucion
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Resolucion));
            Back = new Button();
            SuspendLayout();
            // 
            // Back
            // 
            Back.Location = new Point(0, 0);
            Back.Name = "Back";
            Back.Size = new Size(75, 23);
            Back.TabIndex = 0;
            Back.Text = "Atrás";
            Back.UseVisualStyleBackColor = true;
            Back.Click += Back_Click;
            // 
            // Resolucion
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackgroundImage = (Image)resources.GetObject("$this.BackgroundImage");
            ClientSize = new Size(1364, 749);
            Controls.Add(Back);
            Name = "Resolucion";
            Text = "Resolucion";
            ResumeLayout(false);
        }

        #endregion

        private Button Back;
    }
}