using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Wit.TestTool.ServerApi.Core;
using Wit.TestTool.ServerApi.Modular.Cloud.V1EquipmentApi;
using Wit.TestTool.ServerApi.Modular.Cloud.V1EquipmentApi.Entity;
using Wit.TestTool.ServerApi.Modular.Cloud.V1EquipmentApi.Param;

namespace witcloud_sdk_samples.Examples.Equipment
{
    /// <summary>
    /// 控制设备示例
    /// </summary>
    public partial class FrmControlEquipment : Form
    {
        public FrmControlEquipment()
        {
            InitializeComponent();
        }

        /// <summary>
        /// 发送命令控制设备
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void SandCommandBtn_Click(object sender, EventArgs e)
        {
            SendDataParam sendDataParam = new SendDataParam();
            long EquipmentId;
            if (long.TryParse(IdTextBox.Text, out EquipmentId))
            {
                sendDataParam.equipmentId = EquipmentId; // 设备id
            }
            else
            {
                FeedbackRich.Text += "请输入正确的设备id！\r\n";
                return;
            }
            sendDataParam.name = NameTextBox.Text;       // 操作名称
            sendDataParam.cmd = CommandTextBox.Text;     // 发送的命令
            sendDataParam.isHex = IsHexCheck.Checked;    // 是否十六进制
            ResponseResult<EquipmentResult> result = EquipmentApiHelper.sendData(sendDataParam);
            if (result.success)
            {
                FeedbackRich.Text += "发送命令成功！\r\n";
            }
            else
            {
                FeedbackRich.Text += result.message + "\r\n";
            }
        }

    }
}
