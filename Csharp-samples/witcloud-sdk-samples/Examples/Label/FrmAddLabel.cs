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
using Wit.TestTool.ServerApi.Modular.Cloud.V1EquipLableApi;
using Wit.TestTool.ServerApi.Modular.Cloud.V1EquipLableApi.Entity;
using Wit.TestTool.ServerApi.Modular.Cloud.V1EquipLableApi.Param;

namespace witcloud_sdk_samples.Examples.Label
{
    /// <summary>
    /// 添加设备标签
    /// </summary>
    public partial class FrmAddLabel : Form
    {
        public FrmAddLabel()
        {
            InitializeComponent();
        }

        /// <summary>
        /// 添加设备标签
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void AddLabelBtn_Click(object sender, EventArgs e)
        {
            EquipLabelParam equipLabelParam = new EquipLabelParam();
            if(EquipLabelTextBox.Text == null || EquipLabelTextBox.Text.Equals(""))
            {
                FeedbackRich.Text += "请输入设备标签名称！\r\n";
                return;
            }
            equipLabelParam.label = EquipLabelTextBox.Text;
            ResponseResult<EquipLabelResult> result =  EquipLabelApiHelper.add(equipLabelParam);
            if (result.success)
            {
                FeedbackRich.Text += "添加设备标签成功！\r\n";
            }
            else
            {
                FeedbackRich.Text += result.message + "\r\n";
            }
        }
    }
}
