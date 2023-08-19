using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Threading;
using System.Windows.Forms;

namespace diseño
{
    public partial class Concurrencia : Form
    {
        public Concurrencia()
        {
            InitializeComponent();
        }

        #region //BOTONES DE CONTROL
        private void iconPictureBox2_Click(object sender, EventArgs e) //BOTON PLAY
        {
            btPausa.BringToFront();
            timerCarroRojo1.Start();
            timerCarroRojo2.Start();
            timerPipaRojo.Start();
            timerCarroBlanco.Start();
            timerTreailerBlanco.Start();
            timerCarroAzul.Start();
            timerCNaranjaInvertido.Start();
            timerCarroAzulInvertido.Start();
            timerCarroRojoInvertido.Start();
        }
        private void btPausa_Click(object sender, EventArgs e) // BOTON PAUSA
        {
            btPlay.BringToFront();// traer el boton de play al frente
            timerCarroRojo1.Stop();
            timerCarroRojo2.Stop();
            timerPipaRojo.Stop();
            timerCarroBlanco.Stop();
            timerTreailerBlanco.Stop();
            timerCarroAzul.Stop();
            timerCNaranjaInvertido.Stop();
            timerCarroRojoInvertido.Stop();
            timerCarroAzulInvertido.Stop();
        }
        private void iconPictureBox4_Click(object sender, EventArgs e)
        {
            //Application.Restart();
            // this.Refresh();
        }
        private void btSalir_Click(object sender, EventArgs e)
        {
            //Application.Exit();
        }
        private void pictureBox22_Click(object sender, EventArgs e)
        {
            this.Hide();
            Form Inter = new Interbloqueo();
            Inter.Show();
        }
        #endregion

        #region // TIMER'S
        //CARRO ROJO
        private void timerCarroRojo1_Tick(object sender, EventArgs e)
        {
            int x = CarroRojo1.Location.X;
            int y = CarroRojo1.Location.Y;
            x = x + 5;

            if (x > 900 * 8)
            {
                x = -60;
            }

            Point punto = new Point(x, y);
            CarroRojo1.Location = punto;

        }
        //CARRO NARANJA 
        private void timerCarroRojo2_Tick(object sender, EventArgs e)
        {

            int a = CarroRojo2.Location.X;
            int b = CarroRojo2.Location.Y;
            a = a + 5;

            if (a > 900 * 4)
            {
                a = -60;
            }

            Point punto = new Point(a, b);
            CarroRojo2.Location = punto;
        }

        //PIPA ROJO
        private void timerPipaRojo_Tick(object sender, EventArgs e)
        {

            int x = PipaRojo.Location.X;
            int y = PipaRojo.Location.Y;
            x = x - 5 / 2;


            if (x < -60)
            {
                x = 900;
            }

            Point punto = new Point(x, y);
            PipaRojo.Location = punto;
        }
        // CARRO BLANCO
        private void timerCarroBlanco_Tick(object sender, EventArgs e)
        {
            int x = CarroBlanco.Location.X;
            int y = CarroBlanco.Location.Y;
            x = x + 5;

            if (x > 900 * 4)
            {
                x = -60;
            }

            Point punto = new Point(x, y);
            CarroBlanco.Location = punto;


        }
        //TRAILER BLANCO
        private void timerTreailerBlanco_Tick(object sender, EventArgs e)
        {
            int x = TrailerBlanco.Location.X;
            int y = TrailerBlanco.Location.Y;
            x = x + 10 / 3;

            if (x > 950 * 2)
            {
                x = -120;
            }

            Point punto = new Point(x, y);
            TrailerBlanco.Location = punto;
        }
        //CARRO AZUL
        private void timerCarroAzul_Tick(object sender, EventArgs e)
        {
            int x = CarroAzul.Location.X;
            int y = CarroAzul.Location.Y;
            x = x + 5;

            if (x > 950 * 2)
            {
                x = -120;
            }

            Point punto = new Point(x, y);
            CarroAzul.Location = punto;
        }
        // CARRO NARANJA INVERTIDO
        private void timerCNaranjaInvertido_Tick(object sender, EventArgs e)
        {
            int x = CarroNaranjaInvertido.Location.X;
            int y = CarroNaranjaInvertido.Location.Y;
            x = x - 5;


            if (x < -60)
            {
                x = 1850;
            }

            Point punto = new Point(x, y);
            CarroNaranjaInvertido.Location = punto;
        }
        // CARRO ROJO INVERTIDO
        private void timerCarroRojoInvertido_Tick(object sender, EventArgs e)
        {

            int x = CarroRojoInvertido.Location.X;
            int y = CarroRojoInvertido.Location.Y;
            x = x - 5;


            if (x < -60)
            {
                x = 900;
            }

            Point punto = new Point(x, y);
            CarroRojoInvertido.Location = punto;

        }
        // CARRO AZUL INVERTIDO
        private void timerCarroAzulInvertido_Tick(object sender, EventArgs e)
        {

            int x = CarroAzulInvertido.Location.X;
            int y = CarroAzulInvertido.Location.Y;
            x = x - 5 / 2;


            if (x < -60)
            {
                x = 900;
            }

            Point punto = new Point(x, y);
            CarroAzulInvertido.Location = punto;
        }


        #endregion


        private void Concurrencia_Load(object sender, EventArgs e)
        {
        }
        int info = 0;

        private void btSiguiente_Click(object sender, EventArgs e)// BOTON SIGUIENTE MUESTRA LOS LABELS QUE TIENEN LA DEFINICION DE CONCURRENCIA
        {
            info++;
            if (info == 0)
            {
                TxtPregunta.Visible = true;
            }
            else
            {
                TxtPregunta.Visible = false;
                if (info == 1)
                {
                    TxtRespuesta.Visible = true;
                    TxtRespuesta.Text = "              Es la tendencia de las cosas a producirse \n             al mismo tiempo en un sistema.";
                }
                else if (info == 2)
                {
                    TxtRespuesta.Text = "             La concurrencia es un fenómeno natural.   \n          En el mundo real, en un momento dado, ";
                }
                else if (info == 3)
                {
                    TxtRespuesta.Text = "           suceden muchas cosas de forma simultánea.  ";
                }
                else if (info == 4)
                {
                    TxtRespuesta.Text = " En esta simulación, los carriles de la utopista representan   \n                    los hilos de un procesador                  ";
                }
                else if (info == 5)
                {
                    TxtRespuesta.Text = "       y los vehículos los datos que se están procesando.  ";
                }
                else if (info == 6)
                {
                    TxtRespuesta.Text = "  Hoy en día los procesadores cuentan con varios núcleos \n             e hilos para un mejor procesamiento ";
                }
                else if (info == 7)
                {
                    TxtRespuesta.Text = "    de concurrencia de datos en el menor tiempo posible.   ";
                }
                else if (info > 7)
                {
                    info = 0;
                    TxtRespuesta.Visible = false;
                    TxtPregunta.Visible = true;
                }
                else

                {
                    TxtPregunta.Visible = true;
                }

            }
        }

        private void btAnterior_Click(object sender, EventArgs e)
        {
            info--;
            TxtRespuesta.Visible = true;

            if (info == 2)
            {
                TxtRespuesta.Text = "             La concurrencia es un fenómeno natural.   \n          En el mundo real, en un momento dado, ";
            }
            else if (info == 3)
            {
                TxtRespuesta.Text = "           suceden muchas cosas de forma simultánea.  ";
            }
            else if (info == 4)
            {
                TxtRespuesta.Text = " En esta simulación, los carriles de la utopista representan   \n                    los hilos de un procesador                  ";
            }
            else if (info == 5)
            {
                TxtRespuesta.Text = "       y los vehículos los datos que se están procesando.  ";
            }
            else if (info == 6)
            {
                TxtRespuesta.Text = "  Hoy en día los procesadores cuentan con varios núcleos \n             e hilos para un mejor procesamiento ";
            }
            else if (info == 7)
            {
                TxtRespuesta.Text = "    de concurrencia de datos en el menor tiempo posible.   ";
            }
            else if (info == 1)
            {                
                TxtRespuesta.Text = "              Es la tendencia de las cosas a producirse \n             al mismo tiempo en un sistema.";
            }

            else if (info == 0)
            {
                TxtRespuesta.Visible = false;
                TxtPregunta.Visible = true;
            }
            else if (info < 0)
            {
                info = 0;
                TxtRespuesta.Visible = false;
                TxtPregunta.Visible = true;
            }
            else

            {
                TxtPregunta.Visible = false;
                if (info == 0)
                {
                    TxtPregunta.Visible = true;
                }
            }
         
        }
    }
}
