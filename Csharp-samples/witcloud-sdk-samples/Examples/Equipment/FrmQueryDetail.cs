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
    /// 查询设备详细示例
    /// </summary>
    public partial class FrmQueryDetail : Form
    {
        public FrmQueryDetail()
        {
            InitializeComponent();
        }

        /// <summary>
        /// 查询设备详细
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void QueryDetailBtn_Click(object sender, EventArgs e)
        {
            EquipmentParam equipmentParam = new EquipmentParam();
            long deviceId;
            if(long.TryParse(DeviceIdTextBox.Text,out deviceId))
            {
                equipmentParam.id = deviceId; // 您的设备id
            }else
            {
                FeedbackRich.Text += "请输入正确的设备id!\r\n";
                return;
            }

            ResponseResult<EquipmentResult> result = EquipmentApiHelper.detail(equipmentParam);
            if (result.success)
            {
                FeedbackRich.Text += "分页查询设备列表成功！\r\n";
                FeedbackRich.Text += "设备列表第一个设备信息如下：\r\n";
                FeedbackRich.Text += "设备id：" + result.data.Id + "\r\n";
                FeedbackRich.Text += "在线状态：" + result.data.OnlineStatus + "\r\n";
                FeedbackRich.Text += "最后在线时间：" + result.data.LastOnlineTime + "\r\n";
                FeedbackRich.Text += "设备号：" + result.data.No + "\r\n";
                FeedbackRich.Text += "设备类型：" + result.data.Type + "\r\n";
                FeedbackRich.Text += "数据存储数量：" + result.data.CurrentDataStorage + "\r\n";
                FeedbackRich.Text += "设备标签：" + result.data.Labels + "\r\n";
                FeedbackRich.Text += "设备项目：" + result.data.ProjectId + "\r\n";
                FeedbackRich.Text += "设备状态：" + result.data.Status + "\r\n\r\n";
            }
            else
            {
                FeedbackRich.Text += result.message + "\r\n";
            }
        }
    }
}
