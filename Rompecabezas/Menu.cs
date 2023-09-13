using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
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
        }

        private void Menu_Load(object sender, EventArgs e)
        {

        }

        private void pictureBox4_Click(object sender, EventArgs e)
        {

        }

        private void Rp1_Click(object sender, EventArgs e)
        {
            Prueba1 Rp1 = new Prueba1();
            Rp1.Show();
            Hide();
        }

        private void Rp2_Click(object sender, EventArgs e)
        {
            Resolucion Rp2 = new Resolucion();
            Rp2.Show();
            Hide();
        }

        private void Rp3_Click(object sender, EventArgs e)
        {
            Resolucion_2 Rp3 = new Resolucion_2();
            Rp3.Show();
            Hide();
        }

        private void Close_Click(object sender, EventArgs e)
        {
          Application.Exit();
        }
    }
}
