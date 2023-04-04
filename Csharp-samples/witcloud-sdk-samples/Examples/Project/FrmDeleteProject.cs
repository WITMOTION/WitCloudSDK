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
using Wit.TestTool.ServerApi.Modular.Cloud.V1EquipProjectApi;
using Wit.TestTool.ServerApi.Modular.Cloud.V1EquipProjectApi.Entity;
using Wit.TestTool.ServerApi.Modular.Cloud.V1EquipProjectApi.Param;

namespace witcloud_sdk_samples.Examples.Project
{
    /// <summary>
    /// 删除设备项目
    /// </summary>
    public partial class FrmDeleteProject : Form
    {
        public FrmDeleteProject()
        {
            InitializeComponent();
        }

        /// <summary>
        /// 删除设备项目
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void DeleteProjectBtn_Click(object sender, EventArgs e)
        {
            EquipProjectParam equipProjectParam = new EquipProjectParam();
            long projectId;
            if (long.TryParse(EquipProjectTextBox.Text, out projectId) == false)
            {
                FeedbackRich.Text += "请输入正确的设备项目id！\r\n";
                return;
            }
            equipProjectParam.id = projectId;
            ResponseResult<EquipProjectResult> result = EquipProjectApiHelper.delete(equipProjectParam);
            if (result.success)
            {
                FeedbackRich.Text += "删除设备项目成功！\r\n";
            }
            else
            {
                FeedbackRich.Text += result.message + "\r\n";
            }
        }
    }
}
