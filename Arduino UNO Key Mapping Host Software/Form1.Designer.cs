namespace Arduino_UNO_Key_Mapping_Host_Software
{
    partial class Form1
    {
        /// <summary>
        /// 필수 디자이너 변수입니다.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// 사용 중인 모든 리소스를 정리합니다.
        /// </summary>
        /// <param name="disposing">관리되는 리소스를 삭제해야 하면 true이고, 그렇지 않으면 false입니다.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form 디자이너에서 생성한 코드

        /// <summary>
        /// 디자이너 지원에 필요한 메서드입니다. 
        /// 이 메서드의 내용을 코드 편집기로 수정하지 마세요.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.refresh = new System.Windows.Forms.Button();
            this.connectArdoino = new System.Windows.Forms.Button();
            this.hideForm = new System.Windows.Forms.Button();
            this.portlist = new System.Windows.Forms.ComboBox();
            this.ABport = new System.Windows.Forms.Label();
            this.ABss = new System.Windows.Forms.Label();
            this.sslist = new System.Windows.Forms.ComboBox();
            this.ArduinoSP = new System.IO.Ports.SerialPort(this.components);
            this.MSG_RECV = new System.Windows.Forms.Label();
            this.Datain = new System.Windows.Forms.Label();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.notifyIcon1 = new System.Windows.Forms.NotifyIcon(this.components);
            this.RXmsg = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // refresh
            // 
            this.refresh.Location = new System.Drawing.Point(303, 131);
            this.refresh.Name = "refresh";
            this.refresh.Size = new System.Drawing.Size(121, 28);
            this.refresh.TabIndex = 3;
            this.refresh.Text = "Update port list";
            this.refresh.UseVisualStyleBackColor = true;
            this.refresh.Click += new System.EventHandler(this.refresh_Click);
            // 
            // connectArdoino
            // 
            this.connectArdoino.Location = new System.Drawing.Point(303, 97);
            this.connectArdoino.Name = "connectArdoino";
            this.connectArdoino.Size = new System.Drawing.Size(121, 32);
            this.connectArdoino.TabIndex = 2;
            this.connectArdoino.Text = "Connect";
            this.connectArdoino.UseVisualStyleBackColor = true;
            this.connectArdoino.Click += new System.EventHandler(this.connectArdoino_Click);
            // 
            // hideForm
            // 
            this.hideForm.Location = new System.Drawing.Point(303, 180);
            this.hideForm.Name = "hideForm";
            this.hideForm.Size = new System.Drawing.Size(121, 41);
            this.hideForm.TabIndex = 4;
            this.hideForm.Text = "Hide";
            this.hideForm.UseVisualStyleBackColor = true;
            this.hideForm.Click += new System.EventHandler(this.hideForm_Click);
            // 
            // portlist
            // 
            this.portlist.FormattingEnabled = true;
            this.portlist.Location = new System.Drawing.Point(303, 25);
            this.portlist.Name = "portlist";
            this.portlist.Size = new System.Drawing.Size(121, 20);
            this.portlist.TabIndex = 0;
            // 
            // ABport
            // 
            this.ABport.AutoSize = true;
            this.ABport.Location = new System.Drawing.Point(302, 10);
            this.ABport.Name = "ABport";
            this.ABport.Size = new System.Drawing.Size(74, 12);
            this.ABport.TabIndex = 4;
            this.ABport.Text = "Arduino Port";
            // 
            // ABss
            // 
            this.ABss.AutoSize = true;
            this.ABss.Location = new System.Drawing.Point(304, 55);
            this.ABss.Name = "ABss";
            this.ABss.Size = new System.Drawing.Size(77, 12);
            this.ABss.TabIndex = 5;
            this.ABss.Text = "Serial Speed";
            // 
            // sslist
            // 
            this.sslist.Enabled = false;
            this.sslist.FormattingEnabled = true;
            this.sslist.Items.AddRange(new object[] {
            "9600"});
            this.sslist.Location = new System.Drawing.Point(303, 70);
            this.sslist.Name = "sslist";
            this.sslist.Size = new System.Drawing.Size(121, 20);
            this.sslist.TabIndex = 1;
            this.sslist.Text = "9600";
            // 
            // ArduinoSP
            // 
            this.ArduinoSP.PortName = "COM3";
            this.ArduinoSP.DataReceived += new System.IO.Ports.SerialDataReceivedEventHandler(this.ArduinoSP_DataReceived);
            // 
            // MSG_RECV
            // 
            this.MSG_RECV.AutoSize = true;
            this.MSG_RECV.Location = new System.Drawing.Point(304, 165);
            this.MSG_RECV.Name = "MSG_RECV";
            this.MSG_RECV.Size = new System.Drawing.Size(25, 12);
            this.MSG_RECV.TabIndex = 7;
            this.MSG_RECV.Text = "RX:";
            // 
            // Datain
            // 
            this.Datain.AutoSize = true;
            this.Datain.Location = new System.Drawing.Point(76, 243);
            this.Datain.Name = "Datain";
            this.Datain.Size = new System.Drawing.Size(0, 12);
            this.Datain.TabIndex = 8;
            // 
            // pictureBox1
            // 
            this.pictureBox1.BackgroundImage = global::Arduino_UNO_Key_Mapping_Host_Software.Properties.Resources.참새_로고_버전_1_min;
            this.pictureBox1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.pictureBox1.Cursor = System.Windows.Forms.Cursors.Hand;
            this.pictureBox1.Location = new System.Drawing.Point(0, 0);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(297, 228);
            this.pictureBox1.TabIndex = 9;
            this.pictureBox1.TabStop = false;
            this.pictureBox1.Click += new System.EventHandler(this.pictureBox1_Click);
            // 
            // notifyIcon1
            // 
            this.notifyIcon1.BalloonTipIcon = System.Windows.Forms.ToolTipIcon.Info;
            this.notifyIcon1.BalloonTipText = "Clike to show SPARROW\r\nArduino Button S/W";
            this.notifyIcon1.BalloonTipTitle = "Sparrow boutton UNO";
            this.notifyIcon1.Icon = ((System.Drawing.Icon)(resources.GetObject("notifyIcon1.Icon")));
            this.notifyIcon1.Text = "Sparrow boutton UNO";
            this.notifyIcon1.BalloonTipClicked += new System.EventHandler(this.notifyIcon1_BalloonTipClicked);
            this.notifyIcon1.Click += new System.EventHandler(this.notifyIcon1_MouseClick);
            // 
            // RXmsg
            // 
            this.RXmsg.AutoSize = true;
            this.RXmsg.Font = new System.Drawing.Font("굴림", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.RXmsg.Location = new System.Drawing.Point(329, 165);
            this.RXmsg.Name = "RXmsg";
            this.RXmsg.Size = new System.Drawing.Size(0, 12);
            this.RXmsg.TabIndex = 10;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(430, 227);
            this.Controls.Add(this.RXmsg);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.Datain);
            this.Controls.Add(this.MSG_RECV);
            this.Controls.Add(this.sslist);
            this.Controls.Add(this.ABss);
            this.Controls.Add(this.ABport);
            this.Controls.Add(this.portlist);
            this.Controls.Add(this.hideForm);
            this.Controls.Add(this.connectArdoino);
            this.Controls.Add(this.refresh);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "Form1";
            this.Text = "[C#] Arduino UNO Key Mapping Host Software";
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.Form1_FormClosed);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button refresh;
        private System.Windows.Forms.Button connectArdoino;
        private System.Windows.Forms.Button hideForm;
        private System.Windows.Forms.ComboBox portlist;
        private System.Windows.Forms.Label ABport;
        private System.Windows.Forms.Label ABss;
        private System.Windows.Forms.ComboBox sslist;
        private System.IO.Ports.SerialPort serialPort1;
        private System.Windows.Forms.Label MSG_RECV;
        private System.Windows.Forms.Label Datain;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.NotifyIcon notifyIcon1;
        private System.Windows.Forms.Label RXmsg;
    }
}

