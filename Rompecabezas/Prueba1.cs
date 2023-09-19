﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;


using System;
using System.Windows.Forms;

namespace Rompecabezas
{
    public partial class Prueba1 : Form
    {
        //private Image temporalImage;
        private PictureBox origenPictureBox; // PictureBox de origen o el que seleccionamos primero para el arrastre

        public Prueba1()
        {
            InitializeComponent();
        }

        private void Prueba1_Load(object sender, EventArgs e)
        {


            // AllowDrop con eso habilitamos lo de poder arrastrar y soltar lo de las picture
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

            //img es de donde se arrastraran

            img1.AllowDrop = true;
            img2.AllowDrop = true;
            img3.AllowDrop = true;
            img4.AllowDrop = true;
            img5.AllowDrop = true;
            img6.AllowDrop = true;
            img7.AllowDrop = true;
            img8.AllowDrop = true;
            img9.AllowDrop = true;
            img10.AllowDrop = true;
            img11.AllowDrop = true;
            img12.AllowDrop = true;
            img13.AllowDrop = true;
            img14.AllowDrop = true;
            img15.AllowDrop = true;
            img16.AllowDrop = true;
            img17.AllowDrop = true;
            img18.AllowDrop = true;
            img19.AllowDrop = true;

        }

        private void PictureBox(PictureBox pictureBox)  //se crea un metodo PictureBox en donde configuraremos
        {

            pictureBox.AllowDrop = true;
            //aqui los eventos
            pictureBox.DragEnter += PictureBox_DragEnter;
            pictureBox.DragDrop += PictureBox_DragDrop;
            pictureBox.MouseDown += PictureBox_MouseDown;
        }

        private void PictureBox_DragEnter(object sender, DragEventArgs e)
        {
            e.Effect = DragDropEffects.Move;    //creamos el efecto de mover 
        }

        private void PictureBox_DragDrop(object sender, DragEventArgs e)
        {
            PictureBox laimgPictureBox = (PictureBox)sender;

            // Se hace elintercambio de origen a donde la mandaremos
            Image imagentemporal = laimgPictureBox.Image;
            laimgPictureBox.Image = origenPictureBox.Image;
            origenPictureBox.Image = imagentemporal;
        }

        private void PictureBox_MouseDown(object sender, MouseEventArgs e)
        {
            origenPictureBox = (PictureBox)sender;

            if (origenPictureBox.Image != null) //hacemos la condicion si origendelaimagen no esta vacio osea si esta vacio no lo hara porq no hay nada
            {
                // Inicia el arraste de la imgg
                origenPictureBox.DoDragDrop(origenPictureBox.Image, DragDropEffects.Move);
            }
        }

        private void img15_MouseDown(object sender, MouseEventArgs e)
        {

        }

        private void btnReorganizar_Click(object sender, EventArgs e)
        {
            timer1.Start();

            // Lista de PictureBox con las img a arrastrar o
            List<PictureBox> pictureBoxes = new List<PictureBox>
    {
        picture0,img1, img2, img3, img4, img5, img6, img7, img8, img9, img10,
        img11, img12, img13, img14, img15, img16, img17, img18, img19
    };


            List<Image> imagenesAleatorias = pictureBoxes
                .Select(pb => pb.Image)
                .OrderBy(_ => Guid.NewGuid()) // Aqui  aleatoriamente se ponen
                .ToList();


            for (int i = 0; i < pictureBoxes.Count; i++)
            {
                pictureBoxes[i].Image = imagenesAleatorias[i];

            }

        }
        private int vecesprecionado = 0;

        private void button1_Click(object sender, EventArgs e)
        {



            vecesprecionado++;
            if (vecesprecionado % 2 == 0)
            {
                pista1.Visible = true;

                if (vecesprecionado == 2)
                {
                    button1.Text = "Quedan 2 pistas";
                }
                if (vecesprecionado == 4)
                {
                    button1.Text = "Queda 1 pista";
                }
                if (vecesprecionado == 6)
                {
                    button1.Text = "Quedan 0 pistas";
                }
            }
            else
            {
                pista1.Visible = false;
            }


            if (vecesprecionado == 7)
            {
                pista1.Visible = false;
                button1.Enabled = false;
            }
        }
        private int segundosTranscurridos = 0;
        private void timer1_Tick(object sender, EventArgs e)
        {

            segundosTranscurridos++;
            lblTiempoTranscurrido.Text = TimeSpan.FromSeconds(segundosTranscurridos).ToString(@"hh\:mm\:ss");

        }
    }
}


