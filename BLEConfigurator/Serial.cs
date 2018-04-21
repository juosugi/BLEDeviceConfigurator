using System;
using System.Collections.Generic;
using System.IO.Ports;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace BLEConfigurator
{
    static class BLESerial
    {
        static public void Test()
        {
            MessageBox.Show("test");
        }

        ///**
        // * シリアルポートのポート番号を初期化する
        // * https://qiita.com/mag2/items/d15bc3c9d66ce0c8f6b1
        // * */
        //public static void InitPorts()
        //{
        //    string[] ports = SerialPort.GetPortNames();
        //    foreach (string port in ports)
        //    {
        //        FormMain.listBoxPort.Items.Add(port);
        //    }
        //    //if (listBoxPort.Items.Count > 0)
        //    //    listBoxPort.SelectedIndex = 0;


        //}

    }
}
