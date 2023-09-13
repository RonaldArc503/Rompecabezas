using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Rompecabezas
{
    public partial class Resolucion : Form
    {
        public Resolucion()
        {
            InitializeComponent();
        }

        private void Back_Click(object sender, EventArgs e)
        { //Volver al menu principal//
            Menu Mn = new Menu();
            Mn.Show();
            Hide();
        }
    }
}
