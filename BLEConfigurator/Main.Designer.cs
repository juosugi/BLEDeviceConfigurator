namespace BLEConfigurator
{
    partial class FormMain
    {
        /// <summary>
        /// 必要なデザイナー変数です。
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// 使用中のリソースをすべてクリーンアップします。
        /// </summary>
        /// <param name="disposing">マネージ リソースを破棄する場合は true を指定し、その他の場合は false を指定します。</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows フォーム デザイナーで生成されたコード

        /// <summary>
        /// デザイナー サポートに必要なメソッドです。このメソッドの内容を
        /// コード エディターで変更しないでください。
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.buttonDetect = new System.Windows.Forms.Button();
            this.buttonOpen = new System.Windows.Forms.Button();
            this.listBoxDevice = new System.Windows.Forms.ListBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.listBoxBaudRate = new System.Windows.Forms.ListBox();
            this.label1 = new System.Windows.Forms.Label();
            this.listBoxPort = new System.Windows.Forms.ListBox();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.textBoxTagName = new System.Windows.Forms.TextBox();
            this.buttonSend = new System.Windows.Forms.Button();
            this.label5 = new System.Windows.Forms.Label();
            this.listBoxTxPower = new System.Windows.Forms.ListBox();
            this.label4 = new System.Windows.Forms.Label();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.richTextBoxSend = new System.Windows.Forms.RichTextBox();
            this.groupBox4 = new System.Windows.Forms.GroupBox();
            this.buttonClearReceive = new System.Windows.Forms.Button();
            this.richTextBoxReceive = new System.Windows.Forms.RichTextBox();
            this.serialPort = new System.IO.Ports.SerialPort(this.components);
            this.buttonClearSend = new System.Windows.Forms.Button();
            this.statusStrip = new System.Windows.Forms.StatusStrip();
            this.toolStripStatusLabel = new System.Windows.Forms.ToolStripStatusLabel();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.groupBox3.SuspendLayout();
            this.groupBox4.SuspendLayout();
            this.statusStrip.SuspendLayout();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.buttonDetect);
            this.groupBox1.Controls.Add(this.buttonOpen);
            this.groupBox1.Controls.Add(this.listBoxDevice);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.listBoxBaudRate);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Controls.Add(this.listBoxPort);
            this.groupBox1.Location = new System.Drawing.Point(10, 10);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(230, 225);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Settings";
            // 
            // buttonDetect
            // 
            this.buttonDetect.Location = new System.Drawing.Point(90, 140);
            this.buttonDetect.Name = "buttonDetect";
            this.buttonDetect.Size = new System.Drawing.Size(101, 30);
            this.buttonDetect.TabIndex = 8;
            this.buttonDetect.Text = "Detect";
            this.buttonDetect.UseVisualStyleBackColor = true;
            this.buttonDetect.Click += new System.EventHandler(this.buttonDetect_Click);
            // 
            // buttonOpen
            // 
            this.buttonOpen.Location = new System.Drawing.Point(90, 180);
            this.buttonOpen.Name = "buttonOpen";
            this.buttonOpen.Size = new System.Drawing.Size(101, 30);
            this.buttonOpen.TabIndex = 7;
            this.buttonOpen.Text = "Open";
            this.buttonOpen.UseVisualStyleBackColor = true;
            this.buttonOpen.Click += new System.EventHandler(this.buttonOpen_Click);
            // 
            // listBoxDevice
            // 
            this.listBoxDevice.FormattingEnabled = true;
            this.listBoxDevice.ItemHeight = 12;
            this.listBoxDevice.Location = new System.Drawing.Point(91, 99);
            this.listBoxDevice.Name = "listBoxDevice";
            this.listBoxDevice.Size = new System.Drawing.Size(101, 28);
            this.listBoxDevice.TabIndex = 5;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(18, 103);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(40, 12);
            this.label3.TabIndex = 4;
            this.label3.Text = "Device";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(18, 68);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(55, 12);
            this.label2.TabIndex = 3;
            this.label2.Text = "Baud rate";
            // 
            // listBoxBaudRate
            // 
            this.listBoxBaudRate.FormattingEnabled = true;
            this.listBoxBaudRate.ItemHeight = 12;
            this.listBoxBaudRate.Location = new System.Drawing.Point(91, 64);
            this.listBoxBaudRate.Name = "listBoxBaudRate";
            this.listBoxBaudRate.Size = new System.Drawing.Size(101, 28);
            this.listBoxBaudRate.TabIndex = 2;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(18, 34);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(26, 12);
            this.label1.TabIndex = 1;
            this.label1.Text = "Port";
            // 
            // listBoxPort
            // 
            this.listBoxPort.FormattingEnabled = true;
            this.listBoxPort.ItemHeight = 12;
            this.listBoxPort.Location = new System.Drawing.Point(91, 30);
            this.listBoxPort.Name = "listBoxPort";
            this.listBoxPort.Size = new System.Drawing.Size(101, 28);
            this.listBoxPort.TabIndex = 0;
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.textBoxTagName);
            this.groupBox2.Controls.Add(this.buttonSend);
            this.groupBox2.Controls.Add(this.label5);
            this.groupBox2.Controls.Add(this.listBoxTxPower);
            this.groupBox2.Controls.Add(this.label4);
            this.groupBox2.Location = new System.Drawing.Point(13, 241);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(227, 222);
            this.groupBox2.TabIndex = 1;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Parameter";
            // 
            // textBoxTagName
            // 
            this.textBoxTagName.Location = new System.Drawing.Point(88, 32);
            this.textBoxTagName.Name = "textBoxTagName";
            this.textBoxTagName.Size = new System.Drawing.Size(100, 19);
            this.textBoxTagName.TabIndex = 7;
            // 
            // buttonSend
            // 
            this.buttonSend.Location = new System.Drawing.Point(88, 134);
            this.buttonSend.Name = "buttonSend";
            this.buttonSend.Size = new System.Drawing.Size(101, 30);
            this.buttonSend.TabIndex = 6;
            this.buttonSend.Text = "Send";
            this.buttonSend.UseVisualStyleBackColor = true;
            this.buttonSend.Click += new System.EventHandler(this.buttonSend_Click);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.CausesValidation = false;
            this.label5.Location = new System.Drawing.Point(20, 67);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(54, 12);
            this.label5.TabIndex = 5;
            this.label5.Text = "TX Power";
            // 
            // listBoxTxPower
            // 
            this.listBoxTxPower.FormattingEnabled = true;
            this.listBoxTxPower.ItemHeight = 12;
            this.listBoxTxPower.Location = new System.Drawing.Point(88, 63);
            this.listBoxTxPower.Name = "listBoxTxPower";
            this.listBoxTxPower.Size = new System.Drawing.Size(101, 52);
            this.listBoxTxPower.TabIndex = 4;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(20, 35);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(34, 12);
            this.label4.TabIndex = 3;
            this.label4.Text = "Name";
            // 
            // groupBox3
            // 
            this.groupBox3.Controls.Add(this.richTextBoxSend);
            this.groupBox3.Location = new System.Drawing.Point(249, 10);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(356, 170);
            this.groupBox3.TabIndex = 2;
            this.groupBox3.TabStop = false;
            this.groupBox3.Text = "Send";
            // 
            // richTextBoxSend
            // 
            this.richTextBoxSend.Font = new System.Drawing.Font("MS UI Gothic", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
            this.richTextBoxSend.Location = new System.Drawing.Point(14, 31);
            this.richTextBoxSend.Name = "richTextBoxSend";
            this.richTextBoxSend.Size = new System.Drawing.Size(329, 132);
            this.richTextBoxSend.TabIndex = 0;
            this.richTextBoxSend.Text = "";
            // 
            // groupBox4
            // 
            this.groupBox4.Controls.Add(this.buttonClearReceive);
            this.groupBox4.Controls.Add(this.richTextBoxReceive);
            this.groupBox4.Location = new System.Drawing.Point(249, 242);
            this.groupBox4.Name = "groupBox4";
            this.groupBox4.Size = new System.Drawing.Size(357, 221);
            this.groupBox4.TabIndex = 3;
            this.groupBox4.TabStop = false;
            this.groupBox4.Text = "Receive";
            // 
            // buttonClearReceive
            // 
            this.buttonClearReceive.Location = new System.Drawing.Point(242, 176);
            this.buttonClearReceive.Name = "buttonClearReceive";
            this.buttonClearReceive.Size = new System.Drawing.Size(101, 30);
            this.buttonClearReceive.TabIndex = 10;
            this.buttonClearReceive.Text = "Clear";
            this.buttonClearReceive.UseVisualStyleBackColor = true;
            this.buttonClearReceive.Click += new System.EventHandler(this.buttonClearReceive_Click);
            // 
            // richTextBoxReceive
            // 
            this.richTextBoxReceive.Font = new System.Drawing.Font("MS UI Gothic", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
            this.richTextBoxReceive.Location = new System.Drawing.Point(14, 27);
            this.richTextBoxReceive.Name = "richTextBoxReceive";
            this.richTextBoxReceive.Size = new System.Drawing.Size(329, 138);
            this.richTextBoxReceive.TabIndex = 1;
            this.richTextBoxReceive.Text = "";
            // 
            // serialPort
            // 
            this.serialPort.DataReceived += new System.IO.Ports.SerialDataReceivedEventHandler(this.SerialPort_DataReceived);
            // 
            // buttonClearSend
            // 
            this.buttonClearSend.Location = new System.Drawing.Point(491, 190);
            this.buttonClearSend.Name = "buttonClearSend";
            this.buttonClearSend.Size = new System.Drawing.Size(101, 30);
            this.buttonClearSend.TabIndex = 9;
            this.buttonClearSend.Text = "Clear";
            this.buttonClearSend.UseVisualStyleBackColor = true;
            this.buttonClearSend.Click += new System.EventHandler(this.buttonClearSend_Click);
            // 
            // statusStrip
            // 
            this.statusStrip.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.toolStripStatusLabel});
            this.statusStrip.Location = new System.Drawing.Point(0, 470);
            this.statusStrip.Name = "statusStrip";
            this.statusStrip.Size = new System.Drawing.Size(625, 22);
            this.statusStrip.TabIndex = 10;
            this.statusStrip.Text = "statusStrip1";
            // 
            // toolStripStatusLabel
            // 
            this.toolStripStatusLabel.Name = "toolStripStatusLabel";
            this.toolStripStatusLabel.Size = new System.Drawing.Size(112, 17);
            this.toolStripStatusLabel.Text = "toolStripStatusLabel";
            // 
            // FormMain
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(625, 492);
            this.Controls.Add(this.statusStrip);
            this.Controls.Add(this.buttonClearSend);
            this.Controls.Add(this.groupBox4);
            this.Controls.Add(this.groupBox3);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Name = "FormMain";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "BLE TAG Configurator 1.0 (c)tarokun 2018";
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.FormMain_FormClosed);
            this.Load += new System.EventHandler(this.FormMain_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.groupBox3.ResumeLayout(false);
            this.groupBox4.ResumeLayout(false);
            this.statusStrip.ResumeLayout(false);
            this.statusStrip.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.ListBox listBoxDevice;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.ListBox listBoxBaudRate;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ListBox listBoxPort;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.ListBox listBoxTxPower;
        private System.Windows.Forms.Button buttonOpen;
        private System.Windows.Forms.Button buttonSend;
        private System.Windows.Forms.GroupBox groupBox3;
        private System.Windows.Forms.RichTextBox richTextBoxSend;
        private System.Windows.Forms.GroupBox groupBox4;
        private System.Windows.Forms.RichTextBox richTextBoxReceive;
        private System.Windows.Forms.TextBox textBoxTagName;
        private System.IO.Ports.SerialPort serialPort;
        private System.Windows.Forms.Button buttonDetect;
        private System.Windows.Forms.Button buttonClearReceive;
        private System.Windows.Forms.Button buttonClearSend;
        private System.Windows.Forms.StatusStrip statusStrip;
        private System.Windows.Forms.ToolStripStatusLabel toolStripStatusLabel;
    }
}

