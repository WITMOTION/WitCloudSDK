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
    /// 编辑设备标签
    /// </summary>
    public partial class FrmEditLabel : Form
    {
        public FrmEditLabel()
        {
            InitializeComponent();
        }

        /// <summary>
        /// 编辑设备标签
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void EditLabelBtn_Click(object sender, EventArgs e)
        {
            EquipLabelParam equipLabelParam = new EquipLabelParam();
            long labelId;
            if (long.TryParse(EquipLabelTextBox.Text, out labelId) == false)
            {
                FeedbackRich.Text += "请输入正确的设备标签id！\r\n";
                return;
            }
            
            if(LabelNameTextBox.Text == null || LabelNameTextBox.Text.Equals(""))
            {
                FeedbackRich.Text += "请输入更改之后的设备标签名称！\r\n";
                return;
            }
            equipLabelParam.id = labelId;
            equipLabelParam.label = LabelNameTextBox.Text;
            ResponseResult<EquipLabelResult> result = EquipLabelApiHelper.edit(equipLabelParam);
            if (result.success)
            {
                FeedbackRich.Text += "编辑设备标签成功！\r\n";
            }
            else
            {
                FeedbackRich.Text += "编辑设备标签失败！\r\n";
            }
        }
    }
}
