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

namespace Rompecabezas
{
    public partial class Resolucion : Form
    { //private Image temporalImage;
        private PictureBox origenPictureBox; // PictureBox de origen o el que seleccionamos primero para el arrastre
        System.Diagnostics.Stopwatch timer = new System.Diagnostics.Stopwatch();

        SoundPlayer sonido = new SoundPlayer(Properties.Resources.MusicaJuegos);

        public Resolucion()
        {
            InitializeComponent();
            lblTiempoTranscurrido.Text = "00:00";
            sonido.Play();

        }
        private void Prueba1_Load(object sender, EventArgs e)
        {

        }

        private void iniciarjuego()
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

            // Se hace el intercambio de origen a donde la mandaremos
            Image imagentemporal = laimgPictureBox.Image;
            laimgPictureBox.Image = origenPictureBox.Image;
            origenPictureBox.Image = imagentemporal;
        }

        private void PictureBox_MouseDown(object sender, MouseEventArgs e)
        {
            origenPictureBox = (PictureBox)sender;

            if (origenPictureBox.Image != null) //hacemos la condicion si origende la imagen no esta vacio osea si esta vacio no lo hara porque no hay nada
            {
                // Inicia el arraste de la imgg
                origenPictureBox.DoDragDrop(origenPictureBox.Image, DragDropEffects.Move);
            }
        }

        private void img15_MouseDown(object sender, MouseEventArgs e)
        {

        }

        private int vecesprecionado = 0;

        private void button1_Click(object sender, EventArgs e)
        {

            // Mostrar la imagen de fondo como pista pero solamente se mostrara en movimiento par//

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
            else // Si el movimiento es impar se ocultara, y al llegar al maximo de 7 clicks se ocultara el boton y no dejara dar mas pistas//
            {
                pista1.Visible = false;
            }


            if (vecesprecionado == 7)
            {
                pista1.Visible = false;
                button1.Enabled = false;
            }
        }


        private void BlockGame() // Permitimos que todas las imagenes se puedan arrastrar y soltar//
        {
            img1.AllowDrop = false;
            img2.AllowDrop = false;
            img3.AllowDrop = false;
            img4.AllowDrop = false;
            img5.AllowDrop = false;
            img6.AllowDrop = false;
            img7.AllowDrop = false;
            img8.AllowDrop = false;
            img9.AllowDrop = false;
            img10.AllowDrop = false;
            img11.AllowDrop = false;
            img12.AllowDrop = false;
            img13.AllowDrop = false;
            img14.AllowDrop = false;
            img15.AllowDrop = false;
            img16.AllowDrop = false;
            img17.AllowDrop = false;
            img18.AllowDrop = false;
            img19.AllowDrop = false;
            picture0.AllowDrop = false;
            picture1.AllowDrop = false;
            picture2.AllowDrop = false;
            picture3.AllowDrop = false;
            picture4.AllowDrop = false;
            picture5.AllowDrop = false;
            picture6.AllowDrop = false;
            picture7.AllowDrop = false;
            picture8.AllowDrop = false;
            picture9.AllowDrop = false;
            picture10.AllowDrop = false;
            picture11.AllowDrop = false;
            picture12.AllowDrop = false;
            picture13.AllowDrop = false;
            picture14.AllowDrop = false;
            picture15.AllowDrop = false;
            picture16.AllowDrop = false;
            picture17.AllowDrop = false;
            picture18.AllowDrop = false;
            picture19.AllowDrop = false;
            picture20.AllowDrop = false;

        }


        private int segundosTranscurridos = 0;

        private void timer1_Tick(object sender, EventArgs e)
        {
            //configuracion del tiempo para poder resolver el puzzle//
            segundosTranscurridos++;
            actualizartiempo();
            if (segundosTranscurridos >= 180)
            {
                timerControl.Enabled = false;
                actualizartiempo();
                BlockGame();
                MessageBox.Show("se acabo el tiempo \n regresar al menu ", "puzzle play");
                this.Hide();
                Menu menuPrincipal = new Menu();
                menuPrincipal.Show();
                sonido.Stop();
            }
        }
        private void actualizartiempo()
        {
            int minutos = segundosTranscurridos / 60;
            int segundos = segundosTranscurridos % 60;
            lblTiempoTranscurrido.Text = string.Format("{0:00}:{1:00}", minutos, segundos);

        }

        private void Back_Click(object sender, EventArgs e)
        { //Volver al menu principal//
            Menu Mn = new Menu();
            Mn.Show();
            this.Close();
        }

        private void Resolucion_2_Load(object sender, EventArgs e)
        {

        }


        private void Resolucion_Load(object sender, EventArgs e)
        {

        }

        private void btnReorganizar_Click(object sender, EventArgs e)
        {
            iniciarjuego();
            timerControl.Enabled = true;
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

        private void fin_Click(object sender, EventArgs e)
        {
            timerControl.Enabled = false;
            actualizartiempo();
            pista1.Visible = true;
            BlockGame();
            MessageBox.Show("¡¡¡¡FELICIDADES HAS TERMINADO EL ROMPECABEZAS!!!! \n", "puzzle play");
            this.Hide();
            Menu menuPrincipal = new Menu();
            menuPrincipal.Show();
        }
    }
}
