using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace diseño
{
    public partial class Interbloqueo : Form
    {
        public Interbloqueo()
        {
            InitializeComponent();
        }

        private void pictureBox22_Click(object sender, EventArgs e)
        {
            this.Hide();
            Form Conc = new Concurrencia();
            Conc.Show();
        }
        #region // VARIABLES GLOBALES 
        // VARIABLES PARA LOCATION X DE VEHICULOS DEL LADO DERECHO
        int xi1;

  
        // VARIABLES PARA LOCATION X DE VEHICULOS DEL LADO IZQUIERDO
        int x1;

        // VARIABLE DE MESSAGEBOX
        int Val1=0;
        int Val2=0;
        int ValTotal;

        #endregion
        private void timerPipaRojo_Tick(object sender, EventArgs e)
        {          
            xi1 = PipaRojo.Location.X;
            int y = PipaRojo.Location.Y;

            xi1 = xi1 - 5/2;

            if (xi1 == 435)
            {
                timerPipaRojo2.Enabled = false;
                Val1 = 1;
            }
       
           

            Point punto = new Point(xi1, y);
            PipaRojo.Location = punto;
        }
        private void timerTrailerBlanco2_Tick(object sender, EventArgs e)
        {
            x1 = TrailerBlanco.Location.X;
            int y = TrailerBlanco.Location.Y;
            
            x1 = x1 + 5 / 2;

            if (x1 == 314)
            {
                timerTrailerBlanco2.Enabled = false;
                Val2 = 1;
            }
          

            Point punto = new Point(x1, y);
            TrailerBlanco.Location = punto;
        }

        private void btPlay_Click(object sender, EventArgs e) 
        {
            

            btPausa.BringToFront();
            if (xi1 != 435 && x1 != 314)
            {
                timerPipaRojo2.Start();
                timerTrailerBlanco2.Start();
              
            }
            else
            {
                timerPipaRojo2.Enabled = false;
                timerTrailerBlanco2.Enabled = false;
            }


            ValTotal = Val1 + Val2;


            if (ValTotal==2)
            {
                MessageBox.Show("Se ha producido un interbloqueo", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btPausa_Click(object sender, EventArgs e)
        {
            btPlay.BringToFront();
            timerPipaRojo2.Stop();
            timerTrailerBlanco2.Stop();         
        }

        private void PBcarretera_Click(object sender, EventArgs e)
        {

        }

        private void Interbloqueo_Load(object sender, EventArgs e)
        {

        }

        private void btSalir_Click(object sender, EventArgs e)
        {
            //Application.Exit();
            this.Close();
        }

        private void btStop_Click(object sender, EventArgs e)
        {

            //Application.Restart();
        }
        int info = 0;
        private void btSiguiente_Click(object sender, EventArgs e)
        {
            info++;

            if (info == 0 )
            {
                TxtPregunta.Visible = true;
            }
            else
            {
                TxtPregunta.Visible = false;
                if (info == 1)
                {
                    TxtRespuesta.Visible = true;
                    TxtRespuesta.Text = "Es el bloqueo permanente de un conjunto de procesos \n o hilos de ejecución en un sistema concurrente";
                }
                else if (info == 2)
                {
                    TxtRespuesta.Text = "   A diferencia de otros problemas de concurrencia de   \n     procesos, no existe una solución general     ";
                }
                else if (info == 3)
                {
                    TxtRespuesta.Text = "        Todos los interbloqueos surgen de necesidades";
                }
                else if (info == 4)
                {
                    TxtRespuesta.Text = "      que no pueden ser satisfechas por parte de dos       \n                      o más procesos.                  ";
                }
                else if (info == 5)
                {
                    TxtRespuesta.Text = "              En este ejemplo simula un puente roto,              \n           que dispone de un solo carril.           ";
                }
                else if (info == 6)
                {
                    TxtRespuesta.Text = "cuando los dos vehículos se topan uno en frente del otro";
                }
                else if (info == 7)
                {
                    TxtRespuesta.Text = "      se produce un interbloqueo porque uno bloquea          \n                    el paso del otro.                   ";
                }
                else if (info == 8)
                {
                    TxtRespuesta.Text = "Esto en informática es el congelamiento total del       \n   programa en ejecución y carece de solución alguna.            ";
                }               
                else if (info >8)
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
           // TxtPregunta.Visible = false;
            if (info == 2)
            {
                TxtRespuesta.Text = "   A diferencia de otros problemas de concurrencia de   \n     procesos, no existe una solución general     ";
            }
            else if (info == 3)
            {
                TxtRespuesta.Text = "        Todos los interbloqueos surgen de necesidades";
            }
            else if (info == 4)
            {
                TxtRespuesta.Text = "      que no pueden ser satisfechas por parte de dos       \n                      o más procesos.                  ";
            }
            else if (info == 5)
            {
                TxtRespuesta.Text = "              En este ejemplo simula un puente roto,              \n           que dispone de un solo carril.           ";
            }
            else if (info == 6)
            {
                TxtRespuesta.Text = "cuando los dos vehículos se topan uno en frente del otro";
            }
            else if (info == 7)
            {
                TxtRespuesta.Text = "      se produce un interbloqueo porque uno bloquea          \n                    el paso del otro.                   ";
            }
            else if (info == 8)
            {
                TxtRespuesta.Text = "Esto en informática es el congelamiento total del  \n   programa en ejecución y carece de solución alguna.            ";
            }
            else if (info == 1)
            {
              
                TxtRespuesta.Text = "Es el bloqueo permanente de un conjunto de procesos \n o hilos de ejecución en un sistema concurrente";
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
            ////////////////////////////////////////
            
            
        }
    }
}
