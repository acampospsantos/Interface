
namespace Interface_SMARQ
{
    partial class Form1
    {
        /// <summary>
        /// Variável de designer necessária.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Limpar os recursos que estão sendo usados.
        /// </summary>
        /// <param name="disposing">true se for necessário descartar os recursos gerenciados; caso contrário, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Código gerado pelo Windows Form Designer

        /// <summary>
        /// Método necessário para suporte ao Designer - não modifique 
        /// o conteúdo deste método com o editor de código.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.ConnectionPanel = new System.Windows.Forms.Panel();
            this.ButtonClose = new System.Windows.Forms.Button();
            this.ComboBoxBaudRate = new System.Windows.Forms.ComboBox();
            this.LabelBaudeRate = new System.Windows.Forms.Label();
            this.ComboBoxPort = new System.Windows.Forms.ComboBox();
            this.ButtonScanPort = new System.Windows.Forms.Button();
            this.ConnectionTittle = new System.Windows.Forms.Label();
            this.ButtonDisconnect = new System.Windows.Forms.Button();
            this.ButtonConnect = new System.Windows.Forms.Button();
            this.serialPort1 = new System.IO.Ports.SerialPort(this.components);
            this.tbMenus = new System.Windows.Forms.TabControl();
            this.tabPageLED = new System.Windows.Forms.TabPage();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.comboBox2 = new System.Windows.Forms.ComboBox();
            this.comboBox1 = new System.Windows.Forms.ComboBox();
            this.comboBoxLed1 = new System.Windows.Forms.ComboBox();
            this.labelLed = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.labelPinoLed3 = new System.Windows.Forms.Label();
            this.labelPinoLed2 = new System.Windows.Forms.Label();
            this.labelPinoLed1 = new System.Windows.Forms.Label();
            this.tabPageLDR = new System.Windows.Forms.TabPage();
            this.pictureBox3 = new System.Windows.Forms.PictureBox();
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            this.comboBox6 = new System.Windows.Forms.ComboBox();
            this.comboBox7 = new System.Windows.Forms.ComboBox();
            this.comboBox8 = new System.Windows.Forms.ComboBox();
            this.label8 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.comboBox3 = new System.Windows.Forms.ComboBox();
            this.comboBox4 = new System.Windows.Forms.ComboBox();
            this.comboBox5 = new System.Windows.Forms.ComboBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.tabPagLM35 = new System.Windows.Forms.TabPage();
            this.pictureBox4 = new System.Windows.Forms.PictureBox();
            this.pictureBox5 = new System.Windows.Forms.PictureBox();
            this.comboBox9 = new System.Windows.Forms.ComboBox();
            this.comboBox10 = new System.Windows.Forms.ComboBox();
            this.comboBox11 = new System.Windows.Forms.ComboBox();
            this.label10 = new System.Windows.Forms.Label();
            this.label11 = new System.Windows.Forms.Label();
            this.comboBox12 = new System.Windows.Forms.ComboBox();
            this.comboBox13 = new System.Windows.Forms.ComboBox();
            this.comboBox14 = new System.Windows.Forms.ComboBox();
            this.label12 = new System.Windows.Forms.Label();
            this.label13 = new System.Windows.Forms.Label();
            this.label14 = new System.Windows.Forms.Label();
            this.label15 = new System.Windows.Forms.Label();
            this.label16 = new System.Windows.Forms.Label();
            this.tabPageULTRASSONICO = new System.Windows.Forms.TabPage();
            this.pictureBox8 = new System.Windows.Forms.PictureBox();
            this.comboBox15 = new System.Windows.Forms.ComboBox();
            this.comboBox16 = new System.Windows.Forms.ComboBox();
            this.comboBox17 = new System.Windows.Forms.ComboBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label18 = new System.Windows.Forms.Label();
            this.comboBox18 = new System.Windows.Forms.ComboBox();
            this.comboBox19 = new System.Windows.Forms.ComboBox();
            this.comboBox20 = new System.Windows.Forms.ComboBox();
            this.label19 = new System.Windows.Forms.Label();
            this.label20 = new System.Windows.Forms.Label();
            this.label21 = new System.Windows.Forms.Label();
            this.label22 = new System.Windows.Forms.Label();
            this.label23 = new System.Windows.Forms.Label();
            this.pictureBox6 = new System.Windows.Forms.PictureBox();
            this.label17 = new System.Windows.Forms.Label();
            this.ConnectionPanel.SuspendLayout();
            this.tbMenus.SuspendLayout();
            this.tabPageLED.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.tabPageLDR.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox3)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            this.tabPagLM35.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox4)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox5)).BeginInit();
            this.tabPageULTRASSONICO.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox8)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox6)).BeginInit();
            this.SuspendLayout();
            // 
            // ConnectionPanel
            // 
            this.ConnectionPanel.BackColor = System.Drawing.Color.White;
            this.ConnectionPanel.Controls.Add(this.ButtonClose);
            this.ConnectionPanel.Controls.Add(this.ComboBoxBaudRate);
            this.ConnectionPanel.Controls.Add(this.LabelBaudeRate);
            this.ConnectionPanel.Controls.Add(this.ComboBoxPort);
            this.ConnectionPanel.Controls.Add(this.ButtonScanPort);
            this.ConnectionPanel.Controls.Add(this.ConnectionTittle);
            this.ConnectionPanel.Controls.Add(this.ButtonDisconnect);
            this.ConnectionPanel.Controls.Add(this.ButtonConnect);
            this.ConnectionPanel.Location = new System.Drawing.Point(12, 69);
            this.ConnectionPanel.Name = "ConnectionPanel";
            this.ConnectionPanel.Size = new System.Drawing.Size(220, 218);
            this.ConnectionPanel.TabIndex = 0;
            this.ConnectionPanel.Paint += new System.Windows.Forms.PaintEventHandler(this.ConnectionPanel_Paint);
            // 
            // ButtonClose
            // 
            this.ButtonClose.BackColor = System.Drawing.Color.Black;
            this.ButtonClose.FlatAppearance.BorderColor = System.Drawing.Color.White;
            this.ButtonClose.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(200)))), ((int)(((byte)(80)))), ((int)(((byte)(80)))));
            this.ButtonClose.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(228)))), ((int)(((byte)(90)))), ((int)(((byte)(90)))));
            this.ButtonClose.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.ButtonClose.Location = new System.Drawing.Point(36, 182);
            this.ButtonClose.Name = "ButtonClose";
            this.ButtonClose.Size = new System.Drawing.Size(143, 23);
            this.ButtonClose.TabIndex = 7;
            this.ButtonClose.Text = "Close Program";
            this.ButtonClose.UseVisualStyleBackColor = false;
            this.ButtonClose.Click += new System.EventHandler(this.ButtonClose_Click);
            // 
            // ComboBoxBaudRate
            // 
            this.ComboBoxBaudRate.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(155)))), ((int)(((byte)(89)))), ((int)(((byte)(182)))));
            this.ComboBoxBaudRate.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.ComboBoxBaudRate.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.ComboBoxBaudRate.ForeColor = System.Drawing.Color.White;
            this.ComboBoxBaudRate.FormattingEnabled = true;
            this.ComboBoxBaudRate.Items.AddRange(new object[] {
            "9600",
            "14400",
            "19200",
            "38400",
            "57600",
            "115200"});
            this.ComboBoxBaudRate.Location = new System.Drawing.Point(92, 90);
            this.ComboBoxBaudRate.Name = "ComboBoxBaudRate";
            this.ComboBoxBaudRate.Size = new System.Drawing.Size(121, 21);
            this.ComboBoxBaudRate.TabIndex = 4;
            this.ComboBoxBaudRate.SelectedIndexChanged += new System.EventHandler(this.ComboBoxBaudRate_SelectedIndexChanged);
            // 
            // LabelBaudeRate
            // 
            this.LabelBaudeRate.AutoSize = true;
            this.LabelBaudeRate.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(155)))), ((int)(((byte)(89)))), ((int)(((byte)(182)))));
            this.LabelBaudeRate.Location = new System.Drawing.Point(11, 93);
            this.LabelBaudeRate.Name = "LabelBaudeRate";
            this.LabelBaudeRate.Size = new System.Drawing.Size(75, 13);
            this.LabelBaudeRate.TabIndex = 3;
            this.LabelBaudeRate.Text = "Baud Rate :";
            this.LabelBaudeRate.Click += new System.EventHandler(this.LabelBaudeRate_Click);
            // 
            // ComboBoxPort
            // 
            this.ComboBoxPort.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(155)))), ((int)(((byte)(89)))), ((int)(((byte)(182)))));
            this.ComboBoxPort.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.ComboBoxPort.ForeColor = System.Drawing.Color.White;
            this.ComboBoxPort.FormattingEnabled = true;
            this.ComboBoxPort.Location = new System.Drawing.Point(92, 55);
            this.ComboBoxPort.Name = "ComboBoxPort";
            this.ComboBoxPort.Size = new System.Drawing.Size(121, 21);
            this.ComboBoxPort.TabIndex = 2;
            this.ComboBoxPort.SelectedIndexChanged += new System.EventHandler(this.ComboBoxPort_SelectedIndexChanged);
            // 
            // ButtonScanPort
            // 
            this.ButtonScanPort.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(165)))), ((int)(((byte)(89)))), ((int)(((byte)(182)))));
            this.ButtonScanPort.FlatAppearance.BorderColor = System.Drawing.Color.White;
            this.ButtonScanPort.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(207)))), ((int)(((byte)(38)))), ((int)(((byte)(138)))));
            this.ButtonScanPort.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(107)))), ((int)(((byte)(7)))), ((int)(((byte)(114)))));
            this.ButtonScanPort.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.ButtonScanPort.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ButtonScanPort.Location = new System.Drawing.Point(11, 54);
            this.ButtonScanPort.Name = "ButtonScanPort";
            this.ButtonScanPort.Size = new System.Drawing.Size(75, 23);
            this.ButtonScanPort.TabIndex = 1;
            this.ButtonScanPort.Text = "Scan Port";
            this.ButtonScanPort.UseVisualStyleBackColor = false;
            this.ButtonScanPort.Click += new System.EventHandler(this.ButtonScanPort_Click);
            // 
            // ConnectionTittle
            // 
            this.ConnectionTittle.AutoSize = true;
            this.ConnectionTittle.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ConnectionTittle.ForeColor = System.Drawing.Color.DarkViolet;
            this.ConnectionTittle.Location = new System.Drawing.Point(36, 14);
            this.ConnectionTittle.Name = "ConnectionTittle";
            this.ConnectionTittle.Size = new System.Drawing.Size(150, 20);
            this.ConnectionTittle.TabIndex = 0;
            this.ConnectionTittle.Text = "Connection Panel";
            this.ConnectionTittle.Click += new System.EventHandler(this.ConnectionTittle_Click);
            // 
            // ButtonDisconnect
            // 
            this.ButtonDisconnect.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(250)))), ((int)(((byte)(100)))), ((int)(((byte)(100)))));
            this.ButtonDisconnect.FlatAppearance.BorderColor = System.Drawing.Color.White;
            this.ButtonDisconnect.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(200)))), ((int)(((byte)(80)))), ((int)(((byte)(80)))));
            this.ButtonDisconnect.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(228)))), ((int)(((byte)(90)))), ((int)(((byte)(90)))));
            this.ButtonDisconnect.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.ButtonDisconnect.Location = new System.Drawing.Point(36, 153);
            this.ButtonDisconnect.Name = "ButtonDisconnect";
            this.ButtonDisconnect.Size = new System.Drawing.Size(143, 23);
            this.ButtonDisconnect.TabIndex = 6;
            this.ButtonDisconnect.Text = "Disconnect";
            this.ButtonDisconnect.UseVisualStyleBackColor = false;
            // 
            // ButtonConnect
            // 
            this.ButtonConnect.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(80)))), ((int)(((byte)(180)))), ((int)(((byte)(120)))));
            this.ButtonConnect.FlatAppearance.BorderColor = System.Drawing.Color.White;
            this.ButtonConnect.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(65)))), ((int)(((byte)(155)))), ((int)(((byte)(95)))));
            this.ButtonConnect.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(70)))), ((int)(((byte)(175)))), ((int)(((byte)(105)))));
            this.ButtonConnect.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.ButtonConnect.Location = new System.Drawing.Point(36, 124);
            this.ButtonConnect.Name = "ButtonConnect";
            this.ButtonConnect.Size = new System.Drawing.Size(143, 23);
            this.ButtonConnect.TabIndex = 5;
            this.ButtonConnect.Text = "Connect";
            this.ButtonConnect.UseVisualStyleBackColor = false;
            this.ButtonConnect.Click += new System.EventHandler(this.ButtonConnect_Click);
            // 
            // tbMenus
            // 
            this.tbMenus.Controls.Add(this.tabPageLED);
            this.tbMenus.Controls.Add(this.tabPageLDR);
            this.tbMenus.Controls.Add(this.tabPagLM35);
            this.tbMenus.Controls.Add(this.tabPageULTRASSONICO);
            this.tbMenus.Location = new System.Drawing.Point(252, 69);
            this.tbMenus.Name = "tbMenus";
            this.tbMenus.SelectedIndex = 0;
            this.tbMenus.Size = new System.Drawing.Size(489, 218);
            this.tbMenus.TabIndex = 2;
            // 
            // tabPageLED
            // 
            this.tabPageLED.Controls.Add(this.pictureBox1);
            this.tabPageLED.Controls.Add(this.comboBox2);
            this.tabPageLED.Controls.Add(this.comboBox1);
            this.tabPageLED.Controls.Add(this.comboBoxLed1);
            this.tabPageLED.Controls.Add(this.labelLed);
            this.tabPageLED.Controls.Add(this.label2);
            this.tabPageLED.Controls.Add(this.labelPinoLed3);
            this.tabPageLED.Controls.Add(this.labelPinoLed2);
            this.tabPageLED.Controls.Add(this.labelPinoLed1);
            this.tabPageLED.Location = new System.Drawing.Point(4, 22);
            this.tabPageLED.Name = "tabPageLED";
            this.tabPageLED.Size = new System.Drawing.Size(481, 192);
            this.tabPageLED.TabIndex = 3;
            this.tabPageLED.Text = "Led";
            this.tabPageLED.UseVisualStyleBackColor = true;
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(258, 62);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(100, 100);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.AutoSize;
            this.pictureBox1.TabIndex = 9;
            this.pictureBox1.TabStop = false;
            // 
            // comboBox2
            // 
            this.comboBox2.FormattingEnabled = true;
            this.comboBox2.Items.AddRange(new object[] {
            "2",
            "3",
            "4",
            "5",
            "6",
            "7",
            "8",
            "9",
            "10",
            "11",
            "12",
            "13"});
            this.comboBox2.Location = new System.Drawing.Point(122, 147);
            this.comboBox2.Name = "comboBox2";
            this.comboBox2.Size = new System.Drawing.Size(50, 21);
            this.comboBox2.TabIndex = 7;
            // 
            // comboBox1
            // 
            this.comboBox1.FormattingEnabled = true;
            this.comboBox1.Items.AddRange(new object[] {
            "2",
            "3",
            "4",
            "5",
            "6",
            "7",
            "8",
            "9",
            "10",
            "11",
            "12",
            "13"});
            this.comboBox1.Location = new System.Drawing.Point(122, 107);
            this.comboBox1.Name = "comboBox1";
            this.comboBox1.Size = new System.Drawing.Size(50, 21);
            this.comboBox1.TabIndex = 6;
            // 
            // comboBoxLed1
            // 
            this.comboBoxLed1.FormattingEnabled = true;
            this.comboBoxLed1.Items.AddRange(new object[] {
            "2",
            "3",
            "4",
            "5",
            "6",
            "7",
            "8",
            "9",
            "10",
            "11",
            "12",
            "13"});
            this.comboBoxLed1.Location = new System.Drawing.Point(122, 67);
            this.comboBoxLed1.Name = "comboBoxLed1";
            this.comboBoxLed1.Size = new System.Drawing.Size(50, 21);
            this.comboBoxLed1.TabIndex = 5;
            // 
            // labelLed
            // 
            this.labelLed.AutoSize = true;
            this.labelLed.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelLed.ForeColor = System.Drawing.Color.Red;
            this.labelLed.Location = new System.Drawing.Point(125, 31);
            this.labelLed.Name = "labelLed";
            this.labelLed.Size = new System.Drawing.Size(39, 20);
            this.labelLed.TabIndex = 4;
            this.labelLed.Text = "Led";
            this.labelLed.Click += new System.EventHandler(this.labelLed_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(119, 38);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(41, 13);
            this.label2.TabIndex = 3;
            this.label2.Text = "label2";
            // 
            // labelPinoLed3
            // 
            this.labelPinoLed3.AutoSize = true;
            this.labelPinoLed3.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelPinoLed3.ForeColor = System.Drawing.Color.Blue;
            this.labelPinoLed3.Location = new System.Drawing.Point(18, 147);
            this.labelPinoLed3.Name = "labelPinoLed3";
            this.labelPinoLed3.Size = new System.Drawing.Size(36, 15);
            this.labelPinoLed3.TabIndex = 2;
            this.labelPinoLed3.Text = "Pino";
            // 
            // labelPinoLed2
            // 
            this.labelPinoLed2.AutoSize = true;
            this.labelPinoLed2.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelPinoLed2.ForeColor = System.Drawing.Color.Blue;
            this.labelPinoLed2.Location = new System.Drawing.Point(18, 107);
            this.labelPinoLed2.Name = "labelPinoLed2";
            this.labelPinoLed2.Size = new System.Drawing.Size(36, 15);
            this.labelPinoLed2.TabIndex = 1;
            this.labelPinoLed2.Text = "Pino";
            // 
            // labelPinoLed1
            // 
            this.labelPinoLed1.AutoSize = true;
            this.labelPinoLed1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelPinoLed1.ForeColor = System.Drawing.Color.Blue;
            this.labelPinoLed1.Location = new System.Drawing.Point(18, 67);
            this.labelPinoLed1.Name = "labelPinoLed1";
            this.labelPinoLed1.Size = new System.Drawing.Size(36, 15);
            this.labelPinoLed1.TabIndex = 0;
            this.labelPinoLed1.Text = "Pino";
            this.labelPinoLed1.Click += new System.EventHandler(this.label1_Click);
            // 
            // tabPageLDR
            // 
            this.tabPageLDR.Controls.Add(this.pictureBox3);
            this.tabPageLDR.Controls.Add(this.pictureBox2);
            this.tabPageLDR.Controls.Add(this.comboBox6);
            this.tabPageLDR.Controls.Add(this.comboBox7);
            this.tabPageLDR.Controls.Add(this.comboBox8);
            this.tabPageLDR.Controls.Add(this.label8);
            this.tabPageLDR.Controls.Add(this.label9);
            this.tabPageLDR.Controls.Add(this.comboBox3);
            this.tabPageLDR.Controls.Add(this.comboBox4);
            this.tabPageLDR.Controls.Add(this.comboBox5);
            this.tabPageLDR.Controls.Add(this.label3);
            this.tabPageLDR.Controls.Add(this.label4);
            this.tabPageLDR.Controls.Add(this.label5);
            this.tabPageLDR.Controls.Add(this.label6);
            this.tabPageLDR.Controls.Add(this.label7);
            this.tabPageLDR.Location = new System.Drawing.Point(4, 22);
            this.tabPageLDR.Name = "tabPageLDR";
            this.tabPageLDR.Padding = new System.Windows.Forms.Padding(3);
            this.tabPageLDR.Size = new System.Drawing.Size(481, 192);
            this.tabPageLDR.TabIndex = 1;
            this.tabPageLDR.Text = "Luminosidade";
            this.tabPageLDR.UseVisualStyleBackColor = true;
            // 
            // pictureBox3
            // 
            this.pictureBox3.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox3.Image")));
            this.pictureBox3.Location = new System.Drawing.Point(375, 75);
            this.pictureBox3.Name = "pictureBox3";
            this.pictureBox3.Size = new System.Drawing.Size(100, 94);
            this.pictureBox3.SizeMode = System.Windows.Forms.PictureBoxSizeMode.AutoSize;
            this.pictureBox3.TabIndex = 22;
            this.pictureBox3.TabStop = false;
            // 
            // pictureBox2
            // 
            this.pictureBox2.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox2.Image")));
            this.pictureBox2.Location = new System.Drawing.Point(180, 66);
            this.pictureBox2.Name = "pictureBox2";
            this.pictureBox2.Size = new System.Drawing.Size(100, 100);
            this.pictureBox2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.AutoSize;
            this.pictureBox2.TabIndex = 21;
            this.pictureBox2.TabStop = false;
            // 
            // comboBox6
            // 
            this.comboBox6.FormattingEnabled = true;
            this.comboBox6.Items.AddRange(new object[] {
            "2",
            "3",
            "4",
            "5",
            "6",
            "7",
            "8",
            "9",
            "10",
            "11",
            "12",
            "13"});
            this.comboBox6.Location = new System.Drawing.Point(299, 148);
            this.comboBox6.Name = "comboBox6";
            this.comboBox6.Size = new System.Drawing.Size(50, 21);
            this.comboBox6.TabIndex = 20;
            // 
            // comboBox7
            // 
            this.comboBox7.FormattingEnabled = true;
            this.comboBox7.Items.AddRange(new object[] {
            "2",
            "3",
            "4",
            "5",
            "6",
            "7",
            "8",
            "9",
            "10",
            "11",
            "12",
            "13"});
            this.comboBox7.Location = new System.Drawing.Point(299, 108);
            this.comboBox7.Name = "comboBox7";
            this.comboBox7.Size = new System.Drawing.Size(50, 21);
            this.comboBox7.TabIndex = 19;
            // 
            // comboBox8
            // 
            this.comboBox8.FormattingEnabled = true;
            this.comboBox8.Items.AddRange(new object[] {
            "2",
            "3",
            "4",
            "5",
            "6",
            "7",
            "8",
            "9",
            "10",
            "11",
            "12",
            "13"});
            this.comboBox8.Location = new System.Drawing.Point(299, 68);
            this.comboBox8.Name = "comboBox8";
            this.comboBox8.Size = new System.Drawing.Size(50, 21);
            this.comboBox8.TabIndex = 18;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.ForeColor = System.Drawing.Color.Red;
            this.label8.Location = new System.Drawing.Point(302, 32);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(39, 20);
            this.label8.TabIndex = 17;
            this.label8.Text = "Led";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(296, 39);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(41, 13);
            this.label9.TabIndex = 16;
            this.label9.Text = "label9";
            // 
            // comboBox3
            // 
            this.comboBox3.FormattingEnabled = true;
            this.comboBox3.Items.AddRange(new object[] {
            "A0",
            "A1",
            "A2",
            "A3",
            "A4",
            "A5"});
            this.comboBox3.Location = new System.Drawing.Point(124, 146);
            this.comboBox3.Name = "comboBox3";
            this.comboBox3.Size = new System.Drawing.Size(50, 21);
            this.comboBox3.TabIndex = 15;
            // 
            // comboBox4
            // 
            this.comboBox4.FormattingEnabled = true;
            this.comboBox4.Items.AddRange(new object[] {
            "A0",
            "A1",
            "A2",
            "A3",
            "A4",
            "A5"});
            this.comboBox4.Location = new System.Drawing.Point(124, 106);
            this.comboBox4.Name = "comboBox4";
            this.comboBox4.Size = new System.Drawing.Size(50, 21);
            this.comboBox4.TabIndex = 14;
            // 
            // comboBox5
            // 
            this.comboBox5.FormattingEnabled = true;
            this.comboBox5.Items.AddRange(new object[] {
            "A0",
            "A1",
            "A2",
            "A3",
            "A4",
            "A5"});
            this.comboBox5.Location = new System.Drawing.Point(124, 66);
            this.comboBox5.Name = "comboBox5";
            this.comboBox5.Size = new System.Drawing.Size(50, 21);
            this.comboBox5.TabIndex = 13;
            this.comboBox5.SelectedIndexChanged += new System.EventHandler(this.comboBox5_SelectedIndexChanged);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.Color.Red;
            this.label3.Location = new System.Drawing.Point(99, 30);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(107, 20);
            this.label3.TabIndex = 12;
            this.label3.Text = "Sensor LDR";
            this.label3.Click += new System.EventHandler(this.label3_Click);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(121, 37);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(41, 13);
            this.label4.TabIndex = 11;
            this.label4.Text = "label4";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.ForeColor = System.Drawing.Color.Blue;
            this.label5.Location = new System.Drawing.Point(20, 146);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(36, 15);
            this.label5.TabIndex = 10;
            this.label5.Text = "Pino";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.ForeColor = System.Drawing.Color.Blue;
            this.label6.Location = new System.Drawing.Point(20, 106);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(36, 15);
            this.label6.TabIndex = 9;
            this.label6.Text = "Pino";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.ForeColor = System.Drawing.Color.Blue;
            this.label7.Location = new System.Drawing.Point(20, 66);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(36, 15);
            this.label7.TabIndex = 8;
            this.label7.Text = "Pino";
            // 
            // tabPagLM35
            // 
            this.tabPagLM35.Controls.Add(this.pictureBox4);
            this.tabPagLM35.Controls.Add(this.pictureBox5);
            this.tabPagLM35.Controls.Add(this.comboBox9);
            this.tabPagLM35.Controls.Add(this.comboBox10);
            this.tabPagLM35.Controls.Add(this.comboBox11);
            this.tabPagLM35.Controls.Add(this.label10);
            this.tabPagLM35.Controls.Add(this.label11);
            this.tabPagLM35.Controls.Add(this.comboBox12);
            this.tabPagLM35.Controls.Add(this.comboBox13);
            this.tabPagLM35.Controls.Add(this.comboBox14);
            this.tabPagLM35.Controls.Add(this.label12);
            this.tabPagLM35.Controls.Add(this.label13);
            this.tabPagLM35.Controls.Add(this.label14);
            this.tabPagLM35.Controls.Add(this.label15);
            this.tabPagLM35.Controls.Add(this.label16);
            this.tabPagLM35.Location = new System.Drawing.Point(4, 22);
            this.tabPagLM35.Name = "tabPagLM35";
            this.tabPagLM35.Padding = new System.Windows.Forms.Padding(3);
            this.tabPagLM35.Size = new System.Drawing.Size(481, 192);
            this.tabPagLM35.TabIndex = 0;
            this.tabPagLM35.Text = "Temperatura";
            this.tabPagLM35.UseVisualStyleBackColor = true;
            this.tabPagLM35.Click += new System.EventHandler(this.tabPage1_Click);
            // 
            // pictureBox4
            // 
            this.pictureBox4.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox4.Image")));
            this.pictureBox4.Location = new System.Drawing.Point(182, 92);
            this.pictureBox4.Name = "pictureBox4";
            this.pictureBox4.Size = new System.Drawing.Size(101, 62);
            this.pictureBox4.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox4.TabIndex = 36;
            this.pictureBox4.TabStop = false;
            // 
            // pictureBox5
            // 
            this.pictureBox5.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox5.Image")));
            this.pictureBox5.Location = new System.Drawing.Point(373, 81);
            this.pictureBox5.Name = "pictureBox5";
            this.pictureBox5.Size = new System.Drawing.Size(87, 83);
            this.pictureBox5.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox5.TabIndex = 35;
            this.pictureBox5.TabStop = false;
            // 
            // comboBox9
            // 
            this.comboBox9.FormattingEnabled = true;
            this.comboBox9.Items.AddRange(new object[] {
            "2",
            "3",
            "4",
            "5",
            "6",
            "7",
            "8",
            "9",
            "10",
            "11",
            "12",
            "13"});
            this.comboBox9.Location = new System.Drawing.Point(301, 151);
            this.comboBox9.Name = "comboBox9";
            this.comboBox9.Size = new System.Drawing.Size(50, 21);
            this.comboBox9.TabIndex = 33;
            // 
            // comboBox10
            // 
            this.comboBox10.FormattingEnabled = true;
            this.comboBox10.Items.AddRange(new object[] {
            "2",
            "3",
            "4",
            "5",
            "6",
            "7",
            "8",
            "9",
            "10",
            "11",
            "12",
            "13"});
            this.comboBox10.Location = new System.Drawing.Point(301, 111);
            this.comboBox10.Name = "comboBox10";
            this.comboBox10.Size = new System.Drawing.Size(50, 21);
            this.comboBox10.TabIndex = 32;
            // 
            // comboBox11
            // 
            this.comboBox11.FormattingEnabled = true;
            this.comboBox11.Items.AddRange(new object[] {
            "2",
            "3",
            "4",
            "5",
            "6",
            "7",
            "8",
            "9",
            "10",
            "11",
            "12",
            "13"});
            this.comboBox11.Location = new System.Drawing.Point(301, 71);
            this.comboBox11.Name = "comboBox11";
            this.comboBox11.Size = new System.Drawing.Size(50, 21);
            this.comboBox11.TabIndex = 31;
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label10.ForeColor = System.Drawing.Color.Red;
            this.label10.Location = new System.Drawing.Point(304, 35);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(65, 20);
            this.label10.TabIndex = 30;
            this.label10.Text = "Buzzer";
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Location = new System.Drawing.Point(298, 42);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(48, 13);
            this.label11.TabIndex = 29;
            this.label11.Text = "label11";
            // 
            // comboBox12
            // 
            this.comboBox12.FormattingEnabled = true;
            this.comboBox12.Items.AddRange(new object[] {
            "A0",
            "A1",
            "A2",
            "A3",
            "A4",
            "A5"});
            this.comboBox12.Location = new System.Drawing.Point(126, 149);
            this.comboBox12.Name = "comboBox12";
            this.comboBox12.Size = new System.Drawing.Size(50, 21);
            this.comboBox12.TabIndex = 28;
            // 
            // comboBox13
            // 
            this.comboBox13.FormattingEnabled = true;
            this.comboBox13.Items.AddRange(new object[] {
            "A0",
            "A1",
            "A2",
            "A3",
            "A4",
            "A5"});
            this.comboBox13.Location = new System.Drawing.Point(126, 109);
            this.comboBox13.Name = "comboBox13";
            this.comboBox13.Size = new System.Drawing.Size(50, 21);
            this.comboBox13.TabIndex = 27;
            // 
            // comboBox14
            // 
            this.comboBox14.FormattingEnabled = true;
            this.comboBox14.Items.AddRange(new object[] {
            "A0",
            "A1",
            "A2",
            "A3",
            "A4",
            "A5"});
            this.comboBox14.Location = new System.Drawing.Point(126, 69);
            this.comboBox14.Name = "comboBox14";
            this.comboBox14.Size = new System.Drawing.Size(50, 21);
            this.comboBox14.TabIndex = 26;
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label12.ForeColor = System.Drawing.Color.Red;
            this.label12.Location = new System.Drawing.Point(96, 31);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(115, 20);
            this.label12.TabIndex = 25;
            this.label12.Text = "Sensor LM35";
            this.label12.Click += new System.EventHandler(this.label12_Click);
            // 
            // label13
            // 
            this.label13.AutoSize = true;
            this.label13.Location = new System.Drawing.Point(123, 40);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(48, 13);
            this.label13.TabIndex = 24;
            this.label13.Text = "label13";
            // 
            // label14
            // 
            this.label14.AutoSize = true;
            this.label14.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label14.ForeColor = System.Drawing.Color.Blue;
            this.label14.Location = new System.Drawing.Point(22, 149);
            this.label14.Name = "label14";
            this.label14.Size = new System.Drawing.Size(36, 15);
            this.label14.TabIndex = 23;
            this.label14.Text = "Pino";
            // 
            // label15
            // 
            this.label15.AutoSize = true;
            this.label15.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label15.ForeColor = System.Drawing.Color.Blue;
            this.label15.Location = new System.Drawing.Point(22, 109);
            this.label15.Name = "label15";
            this.label15.Size = new System.Drawing.Size(36, 15);
            this.label15.TabIndex = 22;
            this.label15.Text = "Pino";
            // 
            // label16
            // 
            this.label16.AutoSize = true;
            this.label16.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label16.ForeColor = System.Drawing.Color.Blue;
            this.label16.Location = new System.Drawing.Point(22, 69);
            this.label16.Name = "label16";
            this.label16.Size = new System.Drawing.Size(36, 15);
            this.label16.TabIndex = 21;
            this.label16.Text = "Pino";
            // 
            // tabPageULTRASSONICO
            // 
            this.tabPageULTRASSONICO.Controls.Add(this.pictureBox8);
            this.tabPageULTRASSONICO.Controls.Add(this.comboBox15);
            this.tabPageULTRASSONICO.Controls.Add(this.comboBox16);
            this.tabPageULTRASSONICO.Controls.Add(this.comboBox17);
            this.tabPageULTRASSONICO.Controls.Add(this.label1);
            this.tabPageULTRASSONICO.Controls.Add(this.label18);
            this.tabPageULTRASSONICO.Controls.Add(this.comboBox18);
            this.tabPageULTRASSONICO.Controls.Add(this.comboBox19);
            this.tabPageULTRASSONICO.Controls.Add(this.comboBox20);
            this.tabPageULTRASSONICO.Controls.Add(this.label19);
            this.tabPageULTRASSONICO.Controls.Add(this.label20);
            this.tabPageULTRASSONICO.Controls.Add(this.label21);
            this.tabPageULTRASSONICO.Controls.Add(this.label22);
            this.tabPageULTRASSONICO.Controls.Add(this.label23);
            this.tabPageULTRASSONICO.Controls.Add(this.pictureBox6);
            this.tabPageULTRASSONICO.Location = new System.Drawing.Point(4, 22);
            this.tabPageULTRASSONICO.Name = "tabPageULTRASSONICO";
            this.tabPageULTRASSONICO.Size = new System.Drawing.Size(481, 192);
            this.tabPageULTRASSONICO.TabIndex = 2;
            this.tabPageULTRASSONICO.Text = "Distância";
            this.tabPageULTRASSONICO.UseVisualStyleBackColor = true;
            // 
            // pictureBox8
            // 
            this.pictureBox8.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox8.Image")));
            this.pictureBox8.Location = new System.Drawing.Point(367, 66);
            this.pictureBox8.Name = "pictureBox8";
            this.pictureBox8.Size = new System.Drawing.Size(100, 94);
            this.pictureBox8.SizeMode = System.Windows.Forms.PictureBoxSizeMode.AutoSize;
            this.pictureBox8.TabIndex = 50;
            this.pictureBox8.TabStop = false;
            // 
            // comboBox15
            // 
            this.comboBox15.FormattingEnabled = true;
            this.comboBox15.Items.AddRange(new object[] {
            "2",
            "3",
            "4",
            "5",
            "6",
            "7",
            "8",
            "9",
            "10",
            "11",
            "12",
            "13"});
            this.comboBox15.Location = new System.Drawing.Point(293, 146);
            this.comboBox15.Name = "comboBox15";
            this.comboBox15.Size = new System.Drawing.Size(50, 21);
            this.comboBox15.TabIndex = 49;
            // 
            // comboBox16
            // 
            this.comboBox16.FormattingEnabled = true;
            this.comboBox16.Items.AddRange(new object[] {
            "2",
            "3",
            "4",
            "5",
            "6",
            "7",
            "8",
            "9",
            "10",
            "11",
            "12",
            "13"});
            this.comboBox16.Location = new System.Drawing.Point(293, 106);
            this.comboBox16.Name = "comboBox16";
            this.comboBox16.Size = new System.Drawing.Size(50, 21);
            this.comboBox16.TabIndex = 48;
            // 
            // comboBox17
            // 
            this.comboBox17.FormattingEnabled = true;
            this.comboBox17.Items.AddRange(new object[] {
            "2",
            "3",
            "4",
            "5",
            "6",
            "7",
            "8",
            "9",
            "10",
            "11",
            "12",
            "13"});
            this.comboBox17.Location = new System.Drawing.Point(293, 66);
            this.comboBox17.Name = "comboBox17";
            this.comboBox17.Size = new System.Drawing.Size(50, 21);
            this.comboBox17.TabIndex = 47;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.Red;
            this.label1.Location = new System.Drawing.Point(299, 28);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(39, 20);
            this.label1.TabIndex = 46;
            this.label1.Text = "Led";
            // 
            // label18
            // 
            this.label18.AutoSize = true;
            this.label18.Location = new System.Drawing.Point(290, 37);
            this.label18.Name = "label18";
            this.label18.Size = new System.Drawing.Size(48, 13);
            this.label18.TabIndex = 45;
            this.label18.Text = "label18";
            // 
            // comboBox18
            // 
            this.comboBox18.FormattingEnabled = true;
            this.comboBox18.Items.AddRange(new object[] {
            "A0",
            "A1",
            "A2",
            "A3",
            "A4",
            "A5"});
            this.comboBox18.Location = new System.Drawing.Point(113, 144);
            this.comboBox18.Name = "comboBox18";
            this.comboBox18.Size = new System.Drawing.Size(50, 21);
            this.comboBox18.TabIndex = 44;
            // 
            // comboBox19
            // 
            this.comboBox19.FormattingEnabled = true;
            this.comboBox19.Items.AddRange(new object[] {
            "A0",
            "A1",
            "A2",
            "A3",
            "A4",
            "A5"});
            this.comboBox19.Location = new System.Drawing.Point(113, 104);
            this.comboBox19.Name = "comboBox19";
            this.comboBox19.Size = new System.Drawing.Size(50, 21);
            this.comboBox19.TabIndex = 43;
            // 
            // comboBox20
            // 
            this.comboBox20.FormattingEnabled = true;
            this.comboBox20.Items.AddRange(new object[] {
            "A0",
            "A1",
            "A2",
            "A3",
            "A4",
            "A5"});
            this.comboBox20.Location = new System.Drawing.Point(113, 64);
            this.comboBox20.Name = "comboBox20";
            this.comboBox20.Size = new System.Drawing.Size(50, 21);
            this.comboBox20.TabIndex = 42;
            this.comboBox20.SelectedIndexChanged += new System.EventHandler(this.comboBox20_SelectedIndexChanged);
            // 
            // label19
            // 
            this.label19.AutoSize = true;
            this.label19.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label19.ForeColor = System.Drawing.Color.Red;
            this.label19.Location = new System.Drawing.Point(72, 28);
            this.label19.Name = "label19";
            this.label19.Size = new System.Drawing.Size(171, 20);
            this.label19.TabIndex = 41;
            this.label19.Text = "Sensor Ultrassônico";
            // 
            // label20
            // 
            this.label20.AutoSize = true;
            this.label20.Location = new System.Drawing.Point(115, 35);
            this.label20.Name = "label20";
            this.label20.Size = new System.Drawing.Size(48, 13);
            this.label20.TabIndex = 40;
            this.label20.Text = "label20";
            // 
            // label21
            // 
            this.label21.AutoSize = true;
            this.label21.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label21.ForeColor = System.Drawing.Color.Blue;
            this.label21.Location = new System.Drawing.Point(14, 144);
            this.label21.Name = "label21";
            this.label21.Size = new System.Drawing.Size(36, 15);
            this.label21.TabIndex = 39;
            this.label21.Text = "Pino";
            // 
            // label22
            // 
            this.label22.AutoSize = true;
            this.label22.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label22.ForeColor = System.Drawing.Color.Blue;
            this.label22.Location = new System.Drawing.Point(14, 104);
            this.label22.Name = "label22";
            this.label22.Size = new System.Drawing.Size(36, 15);
            this.label22.TabIndex = 38;
            this.label22.Text = "Pino";
            // 
            // label23
            // 
            this.label23.AutoSize = true;
            this.label23.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label23.ForeColor = System.Drawing.Color.Blue;
            this.label23.Location = new System.Drawing.Point(14, 64);
            this.label23.Name = "label23";
            this.label23.Size = new System.Drawing.Size(36, 15);
            this.label23.TabIndex = 37;
            this.label23.Text = "Pino";
            // 
            // pictureBox6
            // 
            this.pictureBox6.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox6.Image")));
            this.pictureBox6.Location = new System.Drawing.Point(174, 72);
            this.pictureBox6.Name = "pictureBox6";
            this.pictureBox6.Size = new System.Drawing.Size(97, 88);
            this.pictureBox6.SizeMode = System.Windows.Forms.PictureBoxSizeMode.CenterImage;
            this.pictureBox6.TabIndex = 0;
            this.pictureBox6.TabStop = false;
            // 
            // label17
            // 
            this.label17.AutoSize = true;
            this.label17.BackColor = System.Drawing.Color.Transparent;
            this.label17.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label17.ForeColor = System.Drawing.Color.Black;
            this.label17.Location = new System.Drawing.Point(246, 9);
            this.label17.Name = "label17";
            this.label17.Size = new System.Drawing.Size(309, 31);
            this.label17.TabIndex = 3;
            this.label17.Text = "INTERFACE - SMARQ";
            this.label17.Click += new System.EventHandler(this.label17_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(766, 314);
            this.Controls.Add(this.label17);
            this.Controls.Add(this.tbMenus);
            this.Controls.Add(this.ConnectionPanel);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ForeColor = System.Drawing.Color.White;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "Form1";
            this.Text = "INTERFACE SMARQ";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ConnectionPanel.ResumeLayout(false);
            this.ConnectionPanel.PerformLayout();
            this.tbMenus.ResumeLayout(false);
            this.tabPageLED.ResumeLayout(false);
            this.tabPageLED.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.tabPageLDR.ResumeLayout(false);
            this.tabPageLDR.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox3)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
            this.tabPagLM35.ResumeLayout(false);
            this.tabPagLM35.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox4)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox5)).EndInit();
            this.tabPageULTRASSONICO.ResumeLayout(false);
            this.tabPageULTRASSONICO.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox8)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox6)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Panel ConnectionPanel;
        private System.Windows.Forms.Label ConnectionTittle;
        private System.Windows.Forms.Button ButtonScanPort;
        private System.Windows.Forms.Label LabelBaudeRate;
        private System.Windows.Forms.ComboBox ComboBoxPort;
        private System.Windows.Forms.Button ButtonDisconnect;
        private System.Windows.Forms.Button ButtonConnect;
        private System.Windows.Forms.ComboBox ComboBoxBaudRate;
        private System.Windows.Forms.Button ButtonClose;
        private System.IO.Ports.SerialPort serialPort1;
        private System.Windows.Forms.TabControl tbMenus;
        private System.Windows.Forms.TabPage tabPagLM35;
        private System.Windows.Forms.TabPage tabPageLDR;
        private System.Windows.Forms.TabPage tabPageLED;
        private System.Windows.Forms.TabPage tabPageULTRASSONICO;
        private System.Windows.Forms.Label labelPinoLed1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label labelPinoLed3;
        private System.Windows.Forms.Label labelPinoLed2;
        private System.Windows.Forms.ComboBox comboBoxLed1;
        private System.Windows.Forms.Label labelLed;
        private System.Windows.Forms.ComboBox comboBox2;
        private System.Windows.Forms.ComboBox comboBox1;
        private System.Windows.Forms.ComboBox comboBox6;
        private System.Windows.Forms.ComboBox comboBox7;
        private System.Windows.Forms.ComboBox comboBox8;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.ComboBox comboBox3;
        private System.Windows.Forms.ComboBox comboBox4;
        private System.Windows.Forms.ComboBox comboBox5;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.ComboBox comboBox9;
        private System.Windows.Forms.ComboBox comboBox10;
        private System.Windows.Forms.ComboBox comboBox11;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.ComboBox comboBox12;
        private System.Windows.Forms.ComboBox comboBox13;
        private System.Windows.Forms.ComboBox comboBox14;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.Label label13;
        private System.Windows.Forms.Label label14;
        private System.Windows.Forms.Label label15;
        private System.Windows.Forms.Label label16;
        private System.Windows.Forms.Label label17;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.PictureBox pictureBox3;
        private System.Windows.Forms.PictureBox pictureBox2;
        private System.Windows.Forms.PictureBox pictureBox6;
        private System.Windows.Forms.PictureBox pictureBox5;
        private System.Windows.Forms.PictureBox pictureBox4;
        private System.Windows.Forms.PictureBox pictureBox8;
        private System.Windows.Forms.ComboBox comboBox15;
        private System.Windows.Forms.ComboBox comboBox16;
        private System.Windows.Forms.ComboBox comboBox17;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label18;
        private System.Windows.Forms.ComboBox comboBox18;
        private System.Windows.Forms.ComboBox comboBox19;
        private System.Windows.Forms.ComboBox comboBox20;
        private System.Windows.Forms.Label label19;
        private System.Windows.Forms.Label label20;
        private System.Windows.Forms.Label label21;
        private System.Windows.Forms.Label label22;
        private System.Windows.Forms.Label label23;
    }
}

