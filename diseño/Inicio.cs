using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Management;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace diseño
{
    public partial class Inicio : Form
    {
        public Inicio()
        {
            InitializeComponent();
        }

        private void Inicio_Load(object sender, EventArgs e)
        {
            Obtener_registroWin32("Win32_UserAccount");
            timer1.Start();
            
        }

        private void Obtener_registroWin32(string clave)
        {
            ManagementObjectSearcher searcher = new ManagementObjectSearcher("select * from " + clave);
            listView1.Items.Clear();
            ListViewGroup lstvg;
            try
            {
                foreach (ManagementObject objeto in searcher.Get())
                {
                    try
                    {
                        lstvg = listView1.Groups.Add(objeto["Name"].ToString(), objeto["Name"].ToString());
                    }
                    catch
                    {

                        lstvg = listView1.Groups.Add(objeto["Name"].ToString(), objeto["Name"].ToString());

                    }
                    if (objeto.Properties.Count <= 0)
                    {
                        MessageBox.Show("La Información No Está Disponible", "No Info", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        return;
                    }

                    foreach (PropertyData PropiedadObjeto in objeto.Properties)
                    {
                        ListViewItem listViewItem1 = new ListViewItem(lstvg);
                        listViewItem1.Text = PropiedadObjeto.Name;

                        if (PropiedadObjeto.Value != null && PropiedadObjeto.Value.ToString() != "")
                        {
                            listViewItem1.SubItems.Add(PropiedadObjeto.Value.ToString());
                            listView1.Items.Add(listViewItem1);
                        }
                        else
                        {
                            // Informacion nula
                        }

                    }
                }
            }

            catch (Exception exp)
            {
                MessageBox.Show("No se pueden obtener datos \n" + exp.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            float cpu = CPU.NextValue();
            float ram = RAM.NextValue();

            circularProgressBar1.Value = (int)cpu;
            circularProgressBar2.Value = (int)ram;

            circularProgressBar1.Text = string.Format("{0:0.00}%", cpu);
            circularProgressBar2.Text = string.Format("{0:0.00}%", ram);

            if(circularProgressBar1.Value >= 70 && circularProgressBar1.Value <= 90)
            {
                circularProgressBar1.ProgressColor = Color.DarkOrange;
            }else if(circularProgressBar1.Value > 90)
            {
                circularProgressBar1.ProgressColor = Color.Red;
            }
            else
            {
                circularProgressBar1.ProgressColor = Color.Green;
            }


            if (circularProgressBar2.Value >= 70 && circularProgressBar2.Value <= 90)
            {
                circularProgressBar2.ProgressColor = Color.DarkOrange;
            }
            else if (circularProgressBar2.Value > 90)
            {
                circularProgressBar2.ProgressColor = Color.Red;
            }
            else
            {
                circularProgressBar2.ProgressColor = Color.Green;
            }
        }
    }
}
