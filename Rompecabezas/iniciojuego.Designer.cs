namespace Rompecabezas
{
    partial class iniciojuego
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
            components = new System.ComponentModel.Container();
            timerTime = new System.Windows.Forms.Timer(components);
            lblCarga = new Label();
            lblLinkContinuar = new LinkLabel();
            lbTexto = new Label();
            SuspendLayout();
            // 
            // lblCarga
            // 
            lblCarga.AutoSize = true;
            lblCarga.Font = new Font("Segoe UI", 11F, FontStyle.Bold, GraphicsUnit.Point);
            lblCarga.Location = new Point(515, 582);
            lblCarga.Name = "lblCarga";
            lblCarga.Size = new Size(182, 30);
            lblCarga.TabIndex = 0;
            lblCarga.Text = "Cargando al 0 %";
            // 
            // lblLinkContinuar
            // 
            lblLinkContinuar.AutoSize = true;
            lblLinkContinuar.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point);
            lblLinkContinuar.LinkColor = Color.Black;
            lblLinkContinuar.Location = new Point(530, 631);
            lblLinkContinuar.Name = "lblLinkContinuar";
            lblLinkContinuar.Size = new Size(156, 32);
            lblLinkContinuar.TabIndex = 1;
            lblLinkContinuar.TabStop = true;
            lblLinkContinuar.Text = "CONTINUAR";
            // 
            // lbTexto
            // 
            lbTexto.AutoSize = true;
            lbTexto.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point);
            lbTexto.Location = new Point(775, 582);
            lbTexto.Name = "lbTexto";
            lbTexto.Size = new Size(0, 32);
            lbTexto.TabIndex = 2;
            // 
            // iniciojuego
            // 
            AutoScaleDimensions = new SizeF(10F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = SystemColors.ActiveBorder;
            BackgroundImageLayout = ImageLayout.Stretch;
            ClientSize = new Size(1256, 703);
            Controls.Add(lbTexto);
            Controls.Add(lblLinkContinuar);
            Controls.Add(lblCarga);
            Name = "iniciojuego";
            Text = "inicio";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private System.Windows.Forms.Timer timerTime;
        private Label lblCarga;
        private LinkLabel lblLinkContinuar;
        private Label lbTexto;
    }
}