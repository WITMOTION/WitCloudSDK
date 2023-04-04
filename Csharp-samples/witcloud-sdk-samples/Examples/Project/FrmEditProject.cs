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
    /// 编辑设备项目
    /// </summary>
    public partial class FrmEditProject : Form
    {
        public FrmEditProject()
        {
            InitializeComponent();
        }

        /// <summary>
        /// 编辑设备项目
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void EditProjectBtn_Click(object sender, EventArgs e)
        {
            EquipProjectParam equipProjectParam = new EquipProjectParam();
            long projectId;
            if (long.TryParse(ProjectIdTextBox.Text, out projectId) == false)
            {
                FeedbackRich.Text += "请输入正确的设备项目id！\r\n";
                return;
            }

            if (ProjectNameTextBox.Text == null || ProjectNameTextBox.Text.Equals(""))
            {
                FeedbackRich.Text += "请输入更改之后的设备项目名称！\r\n";
                return;
            }
            equipProjectParam.id = projectId;
            equipProjectParam.name = ProjectNameTextBox.Text;
            ResponseResult<EquipProjectResult> result = EquipProjectApiHelper.edit(equipProjectParam);
            if (result.success)
            {
                FeedbackRich.Text += "编辑设备项目成功！\r\n";
            }
            else
            {
                FeedbackRich.Text += "编辑设备项目失败！\r\n";
            }
        }
    }
}
