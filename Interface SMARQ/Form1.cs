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
using System.Linq.Expressions;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace Interface_SMARQ
{
    public partial class Form1 : Form
    {
        //Variáveis 
        //Boolean loop;

        public Form1()
        {
            InitializeComponent();
            tabPageULTRASSONICO.Enabled = false; //Em fase de testes - Tab do Sensor Ultrassônico
        }

        //Botão: Fechar programa
        private void ButtonClose_Click(object sender, EventArgs e)
        {
            Close(); //Fecha o programa
        }

        //Botão: Conectar
        private void ButtonConnect_Click(object sender, EventArgs e)
        {
            //Tratamento de Erro: 
            try
            { //Vai verificar se a porta tá aberta
                if (serialPort1.IsOpen)
                {
                    serialPort1.Close(); //Se a Porta Serial está aberta... --> então fecha a porta!
                }
                else
                { //Se a Porta Serial estiver fechada... --> então abre a porta e manda comandos para a Serial - Informações estão em texto(String)
                    serialPort1.PortName = ComboBoxPort.Text;
                    serialPort1.BaudRate = Int16.Parse(ComboBoxBaudRate.Text);
                    //Ou seja, será enviado para minha porta Serial: a porta COM e o BaudRate
                }
                serialPort1.Open(); //Abre a porta para a comunicação serial

                ButtonConnect.Enabled = false; //Desabilita o botão conectar: Pra o usuário não poder alterar mais o botão, uma vez que a comunicação já foi estabelecida

                ButtonClose.Enabled = false; //Desabilita o botão fechar programa: Pra o usuário não poder alterar mais o botão, uma vez que a comunicação foi estabelecida

                ButtonDisconnect.Enabled = true; //O botão desconectar fica Habilitado: Pra o usuário poder desligar a comunicação serial

                //Uma vez a porta serial conectada...Não está habilitada fazer alterações no BaudRate e na Porta COM
                ComboBoxPort.Enabled = false;
                ComboBoxBaudRate.Enabled = false;

                //Altera a label do Status:
                lbMsg.Text = "STATUS: CONECTADO";
                lbMsg.ForeColor = Color.Green;

                ConectaTabs(); //Habilita botões de conexão dos sensores
            }
            catch
            {
                //Envia mensagem de Erro
                MessageBox.Show("# ERRO NA INSERÇÃO DOS PARÂMETROS #");

                ButtonConnect.Enabled = true;

                ButtonClose.Enabled = true;

                ButtonDisconnect.Enabled = false;

                ComboBoxPort.Enabled = true;
                ComboBoxBaudRate.Enabled = true;

                DesconectaTabs(); //Desabilita botões de conexão dos sensores
            }
        }

        private void Form1_Load(object sender, EventArgs e)
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
            //ComboBoxPort.SelectedIndex = 0; //Começa com a primeira porta COM que estiver disponível
            ComboBoxBaudRate.SelectedIndex = 0; //Começa com a opção do BaudRate ser 9600 (deixei como valor fixo)
        }

        //Botão: Desconectar
        private void ButtonDisconnect_Click(object sender, EventArgs e)
        {
            try
            {
                serialPort1.Write("Z");
                serialPort1.Close(); //Fecha a porta para comunicação
                ButtonConnect.Enabled = true;

                ButtonClose.Enabled = true;

                ButtonDisconnect.Enabled = false;

                ComboBoxPort.Enabled = true;
                ComboBoxBaudRate.Enabled = true;

                //Altera a label do Status:
                lbMsg.Text = "STATUS: DESCONECTADO";
                lbMsg.ForeColor = Color.Red;

                DesconectaTabs(); //Desabilita botões de conexão dos sensores
            }
            catch {
                ButtonConnect.Enabled = false; //Desliga o botão conectar: Pra o usuário não poder alterar mais o botão, uma vez que a comunicação já foi estabelecida

                ButtonClose.Enabled = false; //Desliga o botão fechar programa: Pra o usuário não poder alterar mais o botão, uma vez que a comunicação foi estabelecida

                ButtonDisconnect.Enabled = true; //Desliga o botão desconectar: Pra o usuário não poder alterar mais o botão, uma vez que a comunicação foi estabelecida

                //Também não permitir fazer alterações no BaudRate e na Porta COM
                ComboBoxPort.Enabled = false;
                ComboBoxBaudRate.Enabled = false;

                lbMsg.Text = "STATUS: CONECTADO";
                lbMsg.ForeColor = Color.Green;

                ConectaTabs(); //Habilita botões de conexão dos sensores
            }
        }

        //Função: Habilita todos os botões de conexão dos sensores
        private void ConectaTabs()
        {
            //Essa função habilita todas as comboBox + Botões de Conexão
            ButtonConnectLed1.Enabled = true;
            comboBoxLed1.Enabled = true;

            ButtonConnectLed2.Enabled = true;
            comboBoxLed2.Enabled = true;

            ButtonConnectLed3.Enabled = true;
            comboBoxLed3.Enabled = true;


            ButtonConnectLDR1.Enabled = true;
            comboBoxLdr1.Enabled = true;
            comboBoxLdrLed1.Enabled = true;

            ButtonConnectLDR2.Enabled = true;
            comboBoxLdr2.Enabled = true;
            comboBoxLdrLed2.Enabled = true;

            ButtonConnectLDR3.Enabled = true;
            comboBoxLdr3.Enabled = true;
            comboBoxLdrLed3.Enabled = true;


            ButtonConnectLm1.Enabled = true;
            comboBoxLm1.Enabled = true;
            comboBoxLmBuzzer1.Enabled = true;

            ButtonConnectLm2.Enabled = true;
            comboBoxLm2.Enabled = true;
            comboBoxLmBuzzer2.Enabled = true;

            ButtonConnectLm3.Enabled = true;
            comboBoxLm3.Enabled = true;
            comboBoxLmBuzzer3.Enabled = true;
        }

        //Função: Desabilita todos os botões de conexão dos sensores
        private void DesconectaTabs()
        {
            //Essa função debabilita todas as comboBox + Botões de Conexão + Status(todos) fica obrigatoriamento desativado
            ButtonConnectLed1.Enabled = false;
            comboBoxLed1.Enabled = false;
            labelLed1.Text = "STATUS: DESCONECTADO";
            labelLed1.ForeColor = Color.Red;

            ButtonConnectLed2.Enabled = false;
            comboBoxLed2.Enabled = false;
            labelLed2.Text = "STATUS: DESCONECTADO";
            labelLed2.ForeColor = Color.Red;

            ButtonConnectLed3.Enabled = false;
            comboBoxLed3.Enabled = false;
            labelLed3.Text = "STATUS: DESCONECTADO";
            labelLed3.ForeColor = Color.Red;


            ButtonConnectLDR1.Enabled = false;
            comboBoxLdr1.Enabled = false;
            comboBoxLdrLed1.Enabled = false;
            labelLDR1.Text = "STATUS: DESCONECTADO";
            labelLDR1.ForeColor = Color.Red;

            ButtonConnectLDR2.Enabled = false;
            comboBoxLdr2.Enabled = false;
            comboBoxLdrLed2.Enabled = false;
            labelLDR2.Text = "STATUS: DESCONECTADO";
            labelLDR2.ForeColor = Color.Red;

            ButtonConnectLDR3.Enabled = false;
            comboBoxLdr3.Enabled = false;
            comboBoxLdrLed3.Enabled = false;
            labelLDR3.Text = "STATUS: DESCONECTADO";
            labelLDR3.ForeColor = Color.Red;


            ButtonConnectLm1.Enabled = false;
            comboBoxLm1.Enabled = false;
            comboBoxLmBuzzer1.Enabled = false;
            labelLM1.Text = "STATUS: DESCONECTADO";
            labelLM1.ForeColor = Color.Red;

            ButtonConnectLm2.Enabled = false;
            comboBoxLm2.Enabled = false;
            comboBoxLmBuzzer2.Enabled = false;
            labelLM2.Text = "STATUS: DESCONECTADO";
            labelLM2.ForeColor = Color.Red;

            ButtonConnectLm3.Enabled = false;
            comboBoxLm3.Enabled = false;
            comboBoxLmBuzzer3.Enabled = false;
            labelLM3.Text = "STATUS: DESCONECTADO";
            labelLM3.ForeColor = Color.Red;
        }


        //Botões: Conectar LED's
        private void ButtonConnectLed1_Click(object sender, EventArgs e)
        {
            if (comboBoxLed1.Text == "2")
            {
                labelLed1.Text = "STATUS: CONECTADO";
                labelLed1.ForeColor = Color.Green;
                serialPort1.Write("A");
            } else
            { //Caso não tenha selecionado o pino 2 ao tentar conectar...
                MessageBox.Show("# Selecione o pino do Led #");
                //labelLed1.Text = "STATUS: DESCONECTADO";
                //labelLed1.ForeColor = Color.Red;
            }
        }

        private void ButtonConnectLed2_Click(object sender, EventArgs e)
        {
            if (comboBoxLed2.Text == "3")
            {
                labelLed2.Text = "STATUS: CONECTADO";
                labelLed2.ForeColor = Color.Green;
                serialPort1.Write("B");
            }
            else
            { //Caso não tenha selecionado o pino 3 ao tentar conectar...
                MessageBox.Show("# Selecione o pino do Led #");
                //labelLed2.Text = "STATUS: DESCONECTADO";
                //labelLed2.ForeColor = Color.Red;
            }
        }

        private void ButtonConnectLed3_Click(object sender, EventArgs e)
        {
            if (comboBoxLed3.Text == "4")
            {
                labelLed3.Text = "STATUS: CONECTADO";
                labelLed3.ForeColor = Color.Green;
                serialPort1.Write("C");
            }
            else
            { //Caso não tenha selecionado o pino 4 ao tentar conectar...
                MessageBox.Show("# Selecione o pino do Led #");
                //labelLed3.Text = "STATUS: DESCONECTADO";
                //labelLed3.ForeColor = Color.Red;
            }
        }

        //Botões: Conectar LDR's
        private void ButtonConnectLDR1_Click(object sender, EventArgs e)
        {
            if (comboBoxLdr1.Text == "A0" && comboBoxLdrLed1.Text == "5")
            {
                labelLDR1.Text = "STATUS: CONECTADO";
                labelLDR1.ForeColor = Color.Green;
                serialPort1.Write("D");
            }
            else
            {
                MessageBox.Show("# Selecione o pino! #");
                //labelLDR1.Text = "STATUS DESCONECTADO";
                //labelLDR1.ForeColor = Color.Red;
            }
        }

        private void ButtonConnectLDR2_Click(object sender, EventArgs e)
        { 
            if (comboBoxLdr2.Text == "A1" && comboBoxLdrLed2.Text == "6")
            {
                labelLDR2.Text = "STATUS: CONECTADO";
                labelLDR2.ForeColor = Color.Green;
                serialPort1.Write("E");
            }
            else
            {
                MessageBox.Show("# Selecione o pino! #");
                //labelLDR2.Text = "STATUS DESCONECTADO";
                //labelLDR2.ForeColor = Color.Red;
            }
        }

        private void ButtonConnectLDR3_Click(object sender, EventArgs e)
        {
            if (comboBoxLdr3.Text == "A2" && comboBoxLdrLed3.Text == "7")
            {
                labelLDR3.Text = "STATUS: CONECTADO";
                labelLDR3.ForeColor = Color.Green;
                serialPort1.Write("F");
            }
            else
            {
                MessageBox.Show("# Selecione o pino! #");
                //labelLDR3.Text = "STATUS DESCONECTADO";
                //labelLDR3.ForeColor = Color.Red;
            }
        }


        //Botões: Conectar LM35's
        private void ButtonConnectLm1_Click(object sender, EventArgs e)
        {
            if (comboBoxLm1.Text == "A3" && comboBoxLmBuzzer1.Text == "8")
            {
                labelLM1.Text = "STATUS: CONECTADO";
                labelLM1.ForeColor = Color.Green;
                serialPort1.Write("G");
            }
            else
            {
                MessageBox.Show("# Selecione o pino! #");
                //labelLM1.Text = "STATUS DESCONECTADO";
                //labelLM1.ForeColor = Color.Red;
            }
        }

        private void ButtonConnectLm2_Click(object sender, EventArgs e)
        {
            if (comboBoxLm2.Text == "A4" && comboBoxLmBuzzer2.Text == "9")
            {
                labelLM2.Text = "STATUS: CONECTADO";
                labelLM2.ForeColor = Color.Green;
                serialPort1.Write("H");
            }
            else
            {
                MessageBox.Show("# Selecione o pino! #");
                //labelLM2.Text = "STATUS DESCONECTADO";
                //labelLM2.ForeColor = Color.Red;
            }
        }

        private void ButtonConnectLm3_Click(object sender, EventArgs e)
        {
            if (comboBoxLm3.Text == "A5" && comboBoxLmBuzzer3.Text == "10")
            {
                labelLM3.Text = "STATUS: CONECTADO";
                labelLM3.ForeColor = Color.Green;
                serialPort1.Write("I");
            }
            else
            {
                MessageBox.Show("# Selecione o pino! #");
                //labelLM3.Text = "STATUS DESCONECTADO";
                //labelLM3.ForeColor = Color.Red;
            }
        }

        //LinkLabel que Redireciona o Usuário para o Manual de Uso da SMARQ
        private void linkLabelManualInterface_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            System.Diagnostics.Process.Start("https://github.com/acampospsantos");
        }
    }
}
