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

/**
 * 
 * 2018/04/21
 * 
 * HM-11 HMSoft V549
 * AT-09 MLT-BT05-V4.2
 * HM-10 DSD TECH V551
 * 
 * */

namespace BLEConfigurator
{
    public partial class FormMain : Form
    {
        private Boolean isOpen; //  未使用
        private String receiveData;

        public FormMain()
        {
            InitializeComponent();
        }

        private void FormMain_Load(object sender, EventArgs e)
        {
            // Splash
            //BLESerial.Test();

            //  シリアルの選択肢の初期化を行う
            InitPorts();

            //  ボーレートの選択肢の初期化を行う
            InitBaud();

            // デバイスリストの初期化を行う
            InitDevice();

            // 送信パワーリストの初期化を行う
            InitPower();

            toolStripStatusLabel.Text = "Hello.";
            this.isOpen = false;

        }

        /**
         * シリアルポートのポート番号の選択肢を初期化する
         * https://qiita.com/mag2/items/d15bc3c9d66ce0c8f6b1
         */
        public void InitPorts()
        {
            string[] ports = SerialPort.GetPortNames();

            listBoxPort.Items.Clear();

            foreach (string port in ports)
            {
                listBoxPort.Items.Add(port);
            }
            if (listBoxPort.Items.Count > 0)    listBoxPort.SelectedIndex = 0;
        }

        /**
         * ボーレートの選択肢を初期化する
         * */
        public void InitBaud()
        {
            listBoxBaudRate.Items.Add("9600");
            listBoxBaudRate.SelectedIndex = 0;
        }

        /**
         * デバイスの選択肢を初期化する
         * */
        public void InitDevice()
        {
            listBoxDevice.Items.Add("HM-11");
            listBoxDevice.Items.Add("AT-09");
            listBoxDevice.Items.Add("HM-10");

            listBoxDevice.SelectedIndex = 0;
        }

        /**
         * 出力パワーの選択肢を初期化する
         * */
        public void InitPower()
        {
            listBoxTxPower.Items.Add("0:-23dbm");
            listBoxTxPower.Items.Add("1:-6dbm");
            listBoxTxPower.Items.Add("2:0dbm");
            listBoxTxPower.Items.Add("3:6dbm");

            listBoxTxPower.SelectedIndex = 0;
        }

        /**
         * シリアルポートをオープンする
         * */
        public void buttonOpen_Click(object sender, EventArgs e)
        {
            if (serialPort.IsOpen )
            {
                //  Closeする
                serialPort.Close();
                this.isOpen = false;
                buttonOpen.Text = "Open";
                toolStripStatusLabel.Text = listBoxPort.SelectedItem.ToString() + " is closed.";

            }
            else
            {
                //  Openする
                serialPort.BaudRate = int.Parse(listBoxBaudRate.SelectedItem.ToString());
                serialPort.Parity = Parity.None;
                serialPort.DataBits = 8;
                serialPort.StopBits = StopBits.One;
                serialPort.Handshake = Handshake.None;
                serialPort.PortName = listBoxPort.SelectedItem.ToString();

                try
                {
                    serialPort.Open();
                    //System.Threading.Thread.Sleep(2000);

                    this.isOpen = true;
                    buttonOpen.Text = "Close";
                    toolStripStatusLabel.Text = listBoxPort.SelectedItem.ToString() + " is opened.";

                    // 現状のモジュール名を取得する
                    textBoxTagName.Text = GetModuleName();
                    //richTextBoxReceive.AppendText("\n");

                    // 現状の送信パワーを取得する
                    listBoxTxPower.SelectedIndex = GetTxPower();

                }
                catch (Exception)
                {
                    //toolStripStatusLabel.Text = e.ToString();
                    toolStripStatusLabel.Text = "Can't open " + listBoxPort.SelectedItem.ToString();
                }
            }
        }

        /**
         *  シリアルにコマンドを送信し、レスポンスを取得する
         *  レスポンスは別に取得
         */
        private void serialSend(String cmd)
        {
            receiveData = "\0";

            int deviceType = listBoxDevice.SelectedIndex;

            try {
                richTextBoxSend.AppendText(cmd);
                richTextBoxSend.AppendText("\n");

                //serialPort.Write(cmd);  //  デバイスによってCRLFを付けてはいけない場合がある

                switch (deviceType)
                {
                    case 0: // HM-11    no crlf
                        serialPort.Write(cmd);
                        break;
                    case 1: // AT-09    add crlf
                        serialPort.Write(cmd + "\r\n");
                        break;
                    case 2: // HM-10    add crlf
                        serialPort.Write(cmd);
                        break;
                    default:
                        serialPort.Write(cmd);
                        break;
                }

                System.Threading.Thread.Sleep(1000);
                //res = serialPort.ReadLine();
            }
            catch (Exception e)
            {
                toolStripStatusLabel.Text = e.ToString();
            }

        }

        private void FormMain_FormClosed(object sender, FormClosedEventArgs e)
        {
            serialPort.Close();
        }

        private void buttonDetect_Click(object sender, EventArgs e)
        {
            InitPorts();
            toolStripStatusLabel.Text = "Ports detected.";
        }

        private void buttonClearSend_Click(object sender, EventArgs e)
        {
            richTextBoxSend.Clear();
            toolStripStatusLabel.Text = "Sendlog clear.";
        }

        private void buttonClearReceive_Click(object sender, EventArgs e)
        {
            richTextBoxReceive.Clear();
            toolStripStatusLabel.Text = "Receivelog clear.";
        }

        /**
         * 
         * */
        delegate void SetTextCallback(string text);
        private void Response(string text)
        {
            if (richTextBoxReceive.InvokeRequired)
            {
                SetTextCallback d = new SetTextCallback(Response);
                BeginInvoke(d, new object[] { text });
            }
            else
            {
                richTextBoxReceive.AppendText(text);
                //richTextBoxReceive.AppendText("\n");
                //richTextBoxReceive.AppendText("debug2\n");
            }
        }

        /*
         * 受信したデータをreceiveDataに格納する
         * */
        private void SerialPort_DataReceived(object sender, SerialDataReceivedEventArgs e)
        {
            //richTextBoxReceive.AppendText("debug1\n");   ここでは設定できない

            try
            {
                String str = serialPort.ReadExisting(); //  ReadLine()では受信できない
                receiveData = receiveData + str;
                Response(str);
            }
            catch (Exception)
            {
                //
            }
        }

        /**
         *  デバイスの設定をする
         * */
        private void buttonSend_Click(object sender, EventArgs e)
        {
            //  デバイス名の設定
            SetModuleName(textBoxTagName.Text);

            //  出力パワーの設定
            SetTxPower(listBoxTxPower.SelectedIndex);

            //  デバイスをリセット
            ResetDevice();

        }

        /**
         *  モジュール名を取得する 
         */
        private String GetModuleName()
        {
            String cmd;
            String[] res;
            int deviceType = listBoxDevice.SelectedIndex;

            switch (deviceType)
            {
                case 0: // HM-11    no crlf
                    cmd = "AT+NAME?";
                    break;
                case 1: // AT-09    add crlf
                    cmd = "AT+NAME";
                    break;
                case 2: // HM-10    add crlf
                    cmd = "AT+NAME?";
                    break;
                default:
                    cmd = "AT+NAME?";
                    break;
            }

            serialSend(cmd);
            while (receiveData == "\0")
            {
                System.Threading.Thread.Sleep(500);
            }

            switch (deviceType)
            {
                case 0: // HM-11    no crlf
                    res = receiveData.Split(':');
                    break;
                case 1: // AT-09    add crlf
                    res = receiveData.Split('=');
                    break;
                case 2: // HM-10    add crlf
                    res = receiveData.Split(':');
                    break;
                default:
                    res = receiveData.Split(':');
                    break;
            }

            //richTextBoxReceive.AppendText("\n");

            return res[1];
        }

        /**
         *  モジュール名を設定する 
         */
        private void SetModuleName(String name)
        {
            String cmd = "AT+NAME" + name;
            serialSend(cmd);

            while (receiveData == "\0")
            {
                System.Threading.Thread.Sleep(500);
            }

        }

        /**
         *  送信パワーを取得する 
         */
        private int GetTxPower()
        {
            String cmd;
            String[] res;

            int deviceType = listBoxDevice.SelectedIndex;

            switch (deviceType)
            {
                case 0: // HM-11    no crlf
                    cmd = "AT+POWE?";
                    break;
                case 1: // AT-09    add crlf
                    cmd = "AT+POWE";
                    break;
                case 2: // HM-10    add crlf
                    cmd = "AT+POWE?";
                    break;
                default:
                    cmd = "AT+POWE?";
                    break;
            }

            serialSend(cmd);

            while (receiveData == "\0")
            {
                System.Threading.Thread.Sleep(500);
            }

            switch (deviceType)
            {
                case 0: // HM-11    no crlf
                    res = receiveData.Split(':');
                    break;
                case 1: // AT-09    add crlf
                    res = receiveData.Split('=');
                    break;
                case 2: // HM-10    add crlf
                    res = receiveData.Split(':');
                    break;
                default:
                    res = receiveData.Split(':');
                    break;
            }

            return int.Parse(res[1]);
        }


        /**
         *  送信パワーを設定する 
         */
        private void SetTxPower(int power)
        {
            String cmd = "AT+POWE" + power;
            serialSend(cmd);

            while (receiveData == "\0")
            {
                System.Threading.Thread.Sleep(500);
            }

        }

        /**
         *  デバイスをリセットする
         */
        private void ResetDevice()
        {
            String cmd = "AT+RESET";
            serialSend(cmd);

            while (receiveData == "\0")
            {
                System.Threading.Thread.Sleep(500);
            }

        }

    }
}
