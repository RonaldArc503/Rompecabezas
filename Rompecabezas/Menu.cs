﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Media;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace Rompecabezas
{
    public partial class Menu : Form
    {
        public Menu()
        {
            InitializeComponent();
            // gbgrupo.BackColor = System.Drawing.Color.Transparent;
            SoundPlayer sonido = new SoundPlayer();
        }

        private void Menu_Load(object sender, EventArgs e)
        {

        }

        private void pictureBox4_Click(object sender, EventArgs e)
        {

        }

        private void Rp1_Click(object sender, EventArgs e)
        {
            Resolucion Rp1 = new Resolucion();
            Rp1.Show();
            Hide();
        }

        private void Rp2_Click(object sender, EventArgs e)
        {
            Resolucion_2 Rp2 = new Resolucion_2();
            Rp2.Show();
            Hide();
        }

        private void Rp3_Click(object sender, EventArgs e)
        {
            Prueba1 Rp3 = new Prueba1();
            Rp3.Show();
            Hide();
        }

        private void Close_Click(object sender, EventArgs e)
        {

        }

        private void gbgrupo_Enter(object sender, EventArgs e)
        {

        }

        private void pictureBox4_Click_1(object sender, EventArgs e)
        {
            // Boton para cerrar la aplicación desde el menú//
            if (MessageBox.Show("¿Desea abandonar la aplicación?", "puzzle play", MessageBoxButtons.YesNo, MessageBoxIcon.Hand) == DialogResult.Yes)
            {
                Application.ExitThread();
            }
        }

        private void Rp1_Click_1(object sender, EventArgs e)
        {
            Resolucion Rp1 = new Resolucion();
            Rp1.Show();
            Hide();
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {
            Resolucion Rp1 = new Resolucion();
            Rp1.Show();
            Hide();
        }

        private void pictureBox2_Click(object sender, EventArgs e)
        {
            Resolucion_2 Rp2 = new Resolucion_2();
            Rp2.Show();
            Hide();
        }

        private void pictureBox3_Click(object sender, EventArgs e)
        {
            Prueba1 Rp3 = new Prueba1();
            Rp3.Show();
            Hide();


        }

        private void Rp2_Click_1(object sender, EventArgs e)
        {
            Resolucion_2 Rp2 = new Resolucion_2();
            this.Close();
            Rp2.Show();
          
        }

        private void Rp3_Click_1(object sender, EventArgs e)
        {
            Prueba1 Rp3 = new Prueba1();
           
            this.Close();
            Rp3.Show();
        }
    }
}
