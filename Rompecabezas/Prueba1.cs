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
    public partial class Prueba1 : Form
    {
        public Prueba1()
        {
            InitializeComponent();
        }



        private void Prueba1_Load(object sender, EventArgs e)
        {
            picture0.AllowDrop = true;
            picture1.AllowDrop = true;
            picture2.AllowDrop = true;
            // picture3.AllowDrop = false;
            //  picture4.AllowDrop = false;

           
        }


        // Efecto a entrar a Picture x
        private void picture0_DragEnter(object sender, DragEventArgs e)
        {
            e.Effect = DragDropEffects.Move;
        }

        private void picture0_DragDrop(object sender, DragEventArgs e)
        {
            picture0.Image = (Bitmap)e.Data.GetData(DataFormats.Bitmap);


        }





        private void picture2_DragDrop(object sender, DragEventArgs e)
        {
            picture2.Image = (Bitmap)e.Data.GetData(DataFormats.Bitmap);
            e.Effect = DragDropEffects.Move;// <>
        }

        private void picture2_DragEnter(object sender, DragEventArgs e) // <>
        {
            e.Effect = e.AllowedEffect;
        }

        private void picture1_DragDrop(object sender, DragEventArgs e)
        {
            picture1.Image = (Bitmap)e.Data.GetData(DataFormats.Bitmap);  // <>

        }

        private void picture1_DragEnter(object sender, DragEventArgs e) // <>
        {
            e.Effect = e.AllowedEffect;

        }


        // regresar foto e eliminar 
        private void picture0_MouseDown(object sender, MouseEventArgs e)
        {
            picture0.DoDragDrop(picture0.Image, DragDropEffects.Move);
            picture0.Image = null;
        }
        private void picture1_MouseDown(object sender, MouseEventArgs e)
        {
            picture1.DoDragDrop(picture1.Image, DragDropEffects.Move);
            picture1.Image = null; // quita imagen del picture 1 al pasarlo a picture 0 "la grande foto"

        }

        private void picture2_MouseDown(object sender, MouseEventArgs e)
        {
            picture2.DoDragDrop(picture2.Image, DragDropEffects.Move);
            picture2.Image = null;
        }

        private void picture3_MouseDown(object sender, MouseEventArgs e)
        {
            // picture3.DoDragDrop(picture3.Image, DragDropEffects.Move);
            //   picture3.Image = null;
        }

        private void picture4_MouseDown(object sender, MouseEventArgs e)
        {
            // picture4.DoDragDrop(picture4.Image, DragDropEffects.Move);
            //   picture4.Image = null;
        }

        private void picture2_Click(object sender, EventArgs e)
        {

        }

        private void picture1_Click(object sender, EventArgs e)
        {
            
        }



        //termina eliminar y pasar


    }
}


