using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO.Ports;

namespace Ejercicio_Redes
{
    public partial class foquitos : Form
    {
        SerialPort arduinoPort;
        public foquitos()
        {
            InitializeComponent();
            arduinoPort = new SerialPort("COM3", 9600); // Asegurarse de que "COM3" coincida con el puerto al que está conectado el Arduino

        }

        private void checkBox1_CheckedChanged(object sender, EventArgs e)
        {
            if (checkBox1.Checked)
            {
                arduinoPort.WriteLine("rojo_on");
                lblSwitchRojo.Text = "Encendido";
                txtRojo.BackColor = Color.Red;

            }
            else
            {
                arduinoPort.WriteLine("rojo_off");
                lblSwitchRojo.Text = "Apagado";
                txtRojo.BackColor = Color.White;
            }
        }

        private void checkBox2_CheckedChanged(object sender, EventArgs e)
        {
            if (checkBox2.Checked)
            {
                arduinoPort.WriteLine("verde_on");
                lblSwitchVerde.Text = "Encendido";
                txtVerde.BackColor = Color.LimeGreen;
            }
            else
            {
                arduinoPort.WriteLine("verde_off");
                lblSwitchVerde.Text = "Apagado";
                txtVerde.BackColor = Color.White;
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            arduinoPort.Open();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            arduinoPort.WriteLine("verde_off");
            arduinoPort.WriteLine("rojo_off");
            arduinoPort.Close();
            
        }

        private void foquitos_FormClosing(object sender, FormClosingEventArgs e)
        {
            arduinoPort.WriteLine("verde_off");
            arduinoPort.WriteLine("rojo_off");
            if (arduinoPort.IsOpen)
            {
                arduinoPort.Close();
                
            }
            
        }
    }
}
