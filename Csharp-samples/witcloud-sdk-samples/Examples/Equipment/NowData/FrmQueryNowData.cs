using SuperSocket.ClientEngine;
using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Threading;
using System.Windows.Forms;
using Wit.TestTool.ServerApi.Core;
using Wit.TestTool.ServerApi.Modular.Cloud.V1NowDateApi;
using Wit.TestTool.ServerApi.Modular.Cloud.V1NowDateApi.Entity;
using Wit.TestTool.ServerApi.Modular.Cloud.V1NowDateApi.Param;

namespace witcloud_sdk_samples.Examples.Equipment.NowData
{
    /// <summary>
    /// 查询设备实时数据
    /// </summary>
    public partial class FrmQueryNowData : Form
    {
        /// <summary>
        /// 实时数据帮助类
        /// </summary>
        public NowDataApiHelper wSocketClient = new NowDataApiHelper();


        public FrmQueryNowData()
        {
            InitializeComponent();
        }

        /// <summary>
        /// 查询设备实时数据
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void QueryNowDateBtn_Click(object sender, EventArgs e)
        {
            NowDataSocketParam newDataParam = new NowDataSocketParam();
            List<string> deviceNoList = new List<string>();
            deviceNoList.Add("WT5400000117"); // 您的设备编号
            newDataParam.equipmentNoList = deviceNoList;

            NowDataSocketMessage nowDataMessage = new NowDataSocketMessage();
            nowDataMessage.token = ServerConstant.TOKEN;
            nowDataMessage.method = "needNowData"; // 请求获取实时数据
            nowDataMessage.param = newDataParam;

            // 开启websocket获取实时数据
            OpenWebSocket(nowDataMessage);
        }


        /// <summary>
        /// 开启Websocket连接
        /// </summary>
        /// <param name="nowDataMessage"></param>
        public void OpenWebSocket(NowDataSocketMessage nowDataMessage)
        {
            wSocketClient.OnOpen -= WSocketClient_OnOpen;
            wSocketClient.OnMessage -= WSocketClient_OnMessage;
            wSocketClient.OnClose -= WSocketClient_OnClose;
            wSocketClient.OnError -= WSocketClient_OnError;

            wSocketClient.OnOpen += WSocketClient_OnOpen;
            wSocketClient.OnMessage += WSocketClient_OnMessage;
            wSocketClient.OnClose += WSocketClient_OnClose;
            wSocketClient.OnError += WSocketClient_OnError;
            wSocketClient.Open(nowDataMessage);
        }

        /// <summary>
        /// Websocket连接成功时
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void WSocketClient_OnOpen(object sender, EventArgs e)
        {
            this.Invoke(new Action<int>((input) =>
            {
                FeedbackRich.Text += "连接成功" + "\r\n";
            }), 1);
        }

        /// <summary>
        /// Websocket异常时
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="ex"></param>
        private void WSocketClient_OnError(object sender, Exception ex)
        {
            this.Invoke(new Action<int>((input) =>
            {
                FeedbackRich.Text += ex.Message + "\r\n";
            }), 1);
        }

        /// <summary>
        /// Websocket关闭时
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void WSocketClient_OnClose(object sender, EventArgs e)
        {
            this.Invoke(new Action<int>((input) =>
            {
                FeedbackRich.Text += "连接已关闭" + "\r\n";
            }), 1);
        }

        /// <summary>
        /// Websocket接收到数据时
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="data"></param>
        private void WSocketClient_OnMessage(object sender, NowDataSocketResult result)
        {
            //处理的消息错误将会忽略
            try
            {
                this.Invoke(new Action<int>((input) =>
                {
                    if (result.Method.Equals("deviceData"))
                    {
                        FeedbackRich.Text += "接收到设备实时数据\r\n";
                    }
                    else if(result.Method.Equals("alarmData"))
                    {
                        FeedbackRich.Text += "接收到报警实时数据\r\n";
                    }
                    FeedbackRich.Text += result.Data + "\r\n";
                }), 1);
            }
            catch (Exception ex)
            {
                Debug.WriteLine(ex.Message);
                Debug.WriteLine(ex.StackTrace);
            }
        }

    }
}
