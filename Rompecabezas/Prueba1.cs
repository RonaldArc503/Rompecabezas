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
            picture3.AllowDrop = true;
            picture4.AllowDrop = true;
            picture5.AllowDrop = true;
            picture6.AllowDrop = true;
            picture7.AllowDrop = true;
            picture8.AllowDrop = true;
            picture9.AllowDrop = true;
            picture10.AllowDrop = true;
            picture11.AllowDrop = true;
            picture12.AllowDrop = true;
            picture13.AllowDrop = true;
            picture14.AllowDrop = true;
            picture15.AllowDrop = true;
            picture16.AllowDrop = true;
            picture17.AllowDrop = true;
            picture18.AllowDrop = true;
            picture19.AllowDrop = true;
            picture20.AllowDrop = true;


        }


        // Efecto a entrar a Picture x
        private void all_img_DragEnter(object sender, DragEventArgs e)
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

        }

        private void picture3_DragDrop(object sender, DragEventArgs e)
        {
            picture3.Image = (Bitmap)e.Data.GetData(DataFormats.Bitmap);
            // e.Effect = DragDropEffects.Move;// <>
        }
        private void picture4_DragDrop(object sender, DragEventArgs e)
        {
            picture4.Image = (Bitmap)e.Data.GetData(DataFormats.Bitmap);
            //e.Effect = DragDropEffects.Move;// <>
        }








        private void picture1_DragDrop(object sender, DragEventArgs e)
        {
            picture1.Image = (Bitmap)e.Data.GetData(DataFormats.Bitmap);  // <>

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
            picture3.DoDragDrop(picture3.Image, DragDropEffects.Move);
            picture3.Image = null;
        }

        private void picture4_MouseDown(object sender, MouseEventArgs e)
        {
            picture4.DoDragDrop(picture4.Image, DragDropEffects.Move);
            picture4.Image = null;
        }

        private void picture5_MouseDown(object sender, MouseEventArgs e)
        {
            picture5.DoDragDrop(picture5.Image, DragDropEffects.Move);
            picture5.Image = null;
        }

        private void picture6_MouseDown(object sender, MouseEventArgs e)
        {
            picture6.DoDragDrop(picture6.Image, DragDropEffects.Move);
            picture6.Image = null;
        }

        private void picture7_MouseDown(object sender, MouseEventArgs e)
        {
            picture7.DoDragDrop(picture7.Image, DragDropEffects.Move);
            picture7.Image = null;
        }

        private void picture8_MouseDown(object sender, MouseEventArgs e)
        {
            picture8.DoDragDrop(picture8.Image, DragDropEffects.Move);
            picture8.Image = null;
        }
        //DragDrop part
        private void picture5_DragDrop(object sender, DragEventArgs e)
        {
            picture5.Image = (Bitmap)e.Data.GetData(DataFormats.Bitmap);
        }
        private void picture6_DragDrop(object sender, DragEventArgs e)
        {
            picture6.Image = (Bitmap)e.Data.GetData(DataFormats.Bitmap);
        }
        private void picture7_DragDrop(object sender, DragEventArgs e)
        {
            picture7.Image = (Bitmap)e.Data.GetData(DataFormats.Bitmap);
        }
        private void picture8_DragDrop(object sender, DragEventArgs e)
        {
            picture8.Image = (Bitmap)e.Data.GetData(DataFormats.Bitmap);
        }
        private void picture9_DragDrop(object sender, DragEventArgs e)
        {
            picture9.Image = (Bitmap)e.Data.GetData(DataFormats.Bitmap);
        }
        private void picture10_DragDrop(object sender, DragEventArgs e)
        {
            picture10.Image = (Bitmap)e.Data.GetData(DataFormats.Bitmap);
        }
        private void picture11_DragDrop(object sender, DragEventArgs e)
        {
            picture11.Image = (Bitmap)e.Data.GetData(DataFormats.Bitmap);
        }
        private void picture12_DragDrop(object sender, DragEventArgs e)
        {
            picture12.Image = (Bitmap)e.Data.GetData(DataFormats.Bitmap);
        }
        private void picture13_DragDrop(object sender, DragEventArgs e)
        {
            picture13.Image = (Bitmap)e.Data.GetData(DataFormats.Bitmap);
        }
        private void picture14_DragDrop(object sender, DragEventArgs e)
        {
            picture14.Image = (Bitmap)e.Data.GetData(DataFormats.Bitmap);
        }
        private void picture15_DragDrop(object sender, DragEventArgs e)
        {
            picture15.Image = (Bitmap)e.Data.GetData(DataFormats.Bitmap);
        }
        private void picture16_DragDrop(object sender, DragEventArgs e)
        {
            picture16.Image = (Bitmap)e.Data.GetData(DataFormats.Bitmap);
        }
        private void picture17_DragDrop(object sender, DragEventArgs e)
        {
            picture17.Image = (Bitmap)e.Data.GetData(DataFormats.Bitmap);
        }
        private void picture18_DragDrop(object sender, DragEventArgs e)
        {
            picture18.Image = (Bitmap)e.Data.GetData(DataFormats.Bitmap);
        }
        private void picture19_DragDrop(object sender, DragEventArgs e)
        {
            picture19.Image = (Bitmap)e.Data.GetData(DataFormats.Bitmap);
        }
        private void picture20_DragDrop(object sender, DragEventArgs e)
        {
            picture20.Image = (Bitmap)e.Data.GetData(DataFormats.Bitmap);
        }

        //termina




    }
}


