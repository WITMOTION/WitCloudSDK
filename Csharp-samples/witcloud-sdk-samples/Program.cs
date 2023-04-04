using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.InteropServices;
using System.Threading.Tasks;
using System.Windows.Forms;
using Wit.TestTool.ServerApi.Core;
using witcloud_sdk_samples.Examples;

namespace witcloud_sdk_samples
{
    static class Program
    {
        /// <summary>
        /// 应用程序的主入口点。
        /// </summary>
        [STAThread]
        static void Main()
        {
            int i;
            //检查能不能联网
            if (!(InternetGetConnectedState(out i, 0) == true))
            {
                MessageBox.Show("您的设备不能联网，请联网后再打开");
                Application.Exit();
                return;
            }
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            // 如果没登陆就要求登录
            while (ServerConstant.TOKEN.Equals(""))
            {
                new FrmLogin().ShowDialog();
            }

            Application.Run(new FrmExamplesMain());
        }

        [DllImport("wininet")]
        //判断网络状况的方法,返回值true为连接，false为未连接  
        public extern static bool InternetGetConnectedState(out int conState, int reder);
    }
}
