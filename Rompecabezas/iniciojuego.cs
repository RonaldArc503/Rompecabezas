using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Reflection.Emit;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Rompecabezas
{
    public partial class iniciojuego : Form
    {
        int count = 0;  //variable global de conteo 

        public iniciojuego()
        {
            InitializeComponent();
            lblCarga.BackColor = System.Drawing.Color.Transparent;
            lblLinkContinuar.BackColor = System.Drawing.Color.Transparent;
            lbTexto.BackColor = System.Drawing.Color.Transparent;
        }
        private void iniciojuego_Load(object sender, EventArgs e)
        {
            {
                timerTime.Enabled = true;

            }
        }

        private void lblLinkContinuar_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            this.Hide();
            Menu frm = new Menu();
            frm.Show();
        }

        private void timerTime_Tick(object sender, EventArgs e)
        {
            switch (count)
            {
                case 0:
                    lbTexto.Text = "Verificando imagenes...";
                    lblCarga.Text = "Cargando un " + (count + 10) + " %";
                    break;
                case 1:
                    lbTexto.Text = "Aplicando configuraciones...";
                    lblCarga.Text = "Cargando un " + (count + 29) + " %";
                    break;
                case 2:
                    lbTexto.Text = "Cargando imagenes...";
                    lblCarga.Text = "Cargando un " + (count + 48) + " %";
                    break;
                case 3:
                    lbTexto.Text = "Cargando formularios...";
                    lblCarga.Text = "Cargando un " + (count + 67) + " %";
                    break;
                case 4:
                    lbTexto.Text = "Accediendo al juego...";
                    lblCarga.Text = "Cargando un " + (count + 96) + " %";
                    break;
                case 6:
                    timerTime.Enabled = false;
                    lbTexto.Visible = false;
                    lblLinkContinuar.Visible = true;
                    break;
            }

            count++;

        }


    }
}

