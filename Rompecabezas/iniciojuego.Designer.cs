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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(iniciojuego));
            timerTime = new System.Windows.Forms.Timer(components);
            lblCarga = new Label();
            lblLinkContinuar = new LinkLabel();
            lbTexto = new Label();
            SuspendLayout();
            // 
            // timerTime
            // 
            timerTime.Interval = 1500;
            timerTime.Tick += timerTime_Tick;
            // 
            // lblCarga
            // 
            lblCarga.AutoSize = true;
            lblCarga.Font = new Font("Segoe UI", 11F, FontStyle.Bold, GraphicsUnit.Point);
            lblCarga.ForeColor = SystemColors.ButtonHighlight;
            lblCarga.Location = new Point(596, 693);
            lblCarga.Name = "lblCarga";
            lblCarga.Size = new Size(182, 30);
            lblCarga.TabIndex = 0;
            lblCarga.Text = "Cargando al 0 %";
            lblCarga.Click += lblCarga_Click;
            // 
            // lblLinkContinuar
            // 
            lblLinkContinuar.AutoSize = true;
            lblLinkContinuar.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point);
            lblLinkContinuar.ForeColor = SystemColors.ButtonHighlight;
            lblLinkContinuar.LinkColor = Color.White;
            lblLinkContinuar.Location = new Point(612, 743);
            lblLinkContinuar.Name = "lblLinkContinuar";
            lblLinkContinuar.Size = new Size(156, 32);
            lblLinkContinuar.TabIndex = 1;
            lblLinkContinuar.TabStop = true;
            lblLinkContinuar.Text = "CONTINUAR";
            lblLinkContinuar.Visible = false;
            lblLinkContinuar.LinkClicked += lblLinkContinuar_LinkClicked;
            // 
            // lbTexto
            // 
            lbTexto.AutoSize = true;
            lbTexto.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point);
            lbTexto.ForeColor = SystemColors.ButtonHighlight;
            lbTexto.Location = new Point(856, 693);
            lbTexto.Name = "lbTexto";
            lbTexto.Size = new Size(0, 32);
            lbTexto.TabIndex = 2;
            // 
            // iniciojuego
            // 
            AutoScaleDimensions = new SizeF(10F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = SystemColors.ActiveBorder;
            BackgroundImage = (Image)resources.GetObject("$this.BackgroundImage");
            BackgroundImageLayout = ImageLayout.Stretch;
            ClientSize = new Size(1359, 813);
            ControlBox = false;
            Controls.Add(lbTexto);
            Controls.Add(lblLinkContinuar);
            Controls.Add(lblCarga);
            Icon = (Icon)resources.GetObject("$this.Icon");
            Name = "iniciojuego";
            StartPosition = FormStartPosition.CenterScreen;
            Load += iniciojuego_Load;
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