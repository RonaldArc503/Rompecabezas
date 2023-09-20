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
                timerTime.Enabled = true; // habilitamos la funcion de timer 
            }
        }
        private void lblLinkContinuar_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            this.Hide(); // esconde este formulario 
            Menu frm = new Menu(); // creamos el objeto frm para abrir el menu 
            frm.Show();
        }
        private void timerTime_Tick(object sender, EventArgs e)
        {
            switch (count) // usamos switch para iniciar el contador 
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
                    timerTime.Enabled = false; //finaliza el contador 
                    lbTexto.Visible = false;
                    lblLinkContinuar.Visible = true;
                    break;
            }
            count++; // incrementa el contador 
        }

        private void lblCarga_Click(object sender, EventArgs e)
        {

        }
    }
}

