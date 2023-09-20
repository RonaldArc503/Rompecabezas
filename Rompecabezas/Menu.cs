using System;
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

        // esta es una prueba para nuestra precentacion 

        SoundPlayer sonido = new SoundPlayer(Properties.Resources.MusicaMenu);


        public Menu()
        {
            InitializeComponent();
            // gbgrupo.BackColor = System.Drawing.Color.Transparent;
            sonido.Play();
        }


        private void pictureBox4_Click_1(object sender, EventArgs e)
        {
            // Boton para cerrar la aplicación desde el menú//
            if (MessageBox.Show("¿Desea abandonar la aplicación?", "puzzle play", MessageBoxButtons.YesNo, MessageBoxIcon.Hand) == DialogResult.Yes)
            {
                Application.ExitThread();
            }
        }

        private void Rp1_Click_1(object sender, EventArgs e) //1
        {
            Resolucion Rp1 = new Resolucion();
            iniciojuego R = new iniciojuego();
            this.Close();
            Rp1.Show();
            R.Close();
            sonido.Stop();  
        }

        private void pictureBox1_Click(object sender, EventArgs e)  //1 img
        {
            Resolucion Rp1 = new Resolucion();
            iniciojuego R = new iniciojuego();
            this.Close();
            Rp1.Show();
            R.Close();
            sonido.Stop();
        }

        private void pictureBox2_Click(object sender, EventArgs e)//2 img
        {
            Resolucion_2 Rp2 = new Resolucion_2();
            iniciojuego R = new iniciojuego();
            this.Close();
            Rp2.Show();
            R.Close();
            sonido.Stop();
        }

        private void pictureBox3_Click(object sender, EventArgs e) //3 img
        {
            Prueba1 Rp3 = new Prueba1();
            iniciojuego R = new iniciojuego();
            this.Close();
            Rp3.Show();
            R.Close();

        }

        private void Rp2_Click_1(object sender, EventArgs e) //2
        {
            Resolucion_2 Rp2 = new Resolucion_2();
            iniciojuego R = new iniciojuego();
            this.Close();
            Rp2.Show();
            R.Close();

        }

        private void Rp3_Click_1(object sender, EventArgs e) //3
        {
            Prueba1 Rp3 = new Prueba1();
            iniciojuego R = new iniciojuego();

            this.Close();
            Rp3.Show();
            R.Close();
        }
    }
}
