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
    /// 删除设备标签
    /// </summary>
    public partial class FrmDeleteLabel : Form
    {
        public FrmDeleteLabel()
        {
            InitializeComponent();
        }

        /// <summary>
        /// 删除设备标签
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void DeleteLabelBtn_Click(object sender, EventArgs e)
        {
            EquipLabelParam equipLabelParam = new EquipLabelParam();
            long labelId;
            if(long.TryParse(EquipLabelTextBox.Text,out labelId) == false)
            {
                FeedbackRich.Text += "请输入正确的设备标签id！\r\n";
                return;
            }
            equipLabelParam.id = labelId;
            ResponseResult<EquipLabelResult> result = EquipLabelApiHelper.delete(equipLabelParam);
            if (result.success)
            {
                FeedbackRich.Text += "删除设备标签成功！\r\n";
            }
            else
            {
                FeedbackRich.Text += "删除设备标签失败！\r\n";
            }
        }
    }
}
