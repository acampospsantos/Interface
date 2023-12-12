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

namespace Interface_SMARQ
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void ConnectionTittle_Click(object sender, EventArgs e)
        {

        }

        private void ButtonScanPort_Click(object sender, EventArgs e)
        {

        }

        private void LabelBaudeRate_Click(object sender, EventArgs e)
        {

        }

        private void ButtonClose_Click(object sender, EventArgs e)
        {
            Close(); //Fecha o programa
        }

        private void ButtonConnect_Click(object sender, EventArgs e)
        {

        }

        private void ConnectionPanel_Paint(object sender, PaintEventArgs e)
        {
            PortaCom();
        }

        private void PortaCom()
        {
            ComboBoxPort.Items.Clear();
            foreach (String Portas in SerialPort.GetPortNames())
            {
                ComboBoxPort.Items.Add(Portas);
            }
            ComboBoxPort.SelectedIndex = 0; //Começa com a primeira porta que estiver disponível
        }

        private void tabPage1_Click(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void labelLed_Click(object sender, EventArgs e)
        {

        }

        private void label1_Click_1(object sender, EventArgs e)
        {

        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void label12_Click(object sender, EventArgs e)
        {

        }

        private void label17_Click(object sender, EventArgs e)
        {

        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void ComboBoxBaudRate_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void ComboBoxPort_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void comboBox20_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void comboBox5_SelectedIndexChanged(object sender, EventArgs e)
        {

        }
    }
}
