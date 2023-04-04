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
    /// 添加设备项目
    /// </summary>
    public partial class FrmAddProject : Form
    {
        public FrmAddProject()
        {
            InitializeComponent();
        }

        /// <summary>
        /// 添加设备项目
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void AddProjectBtn_Click(object sender, EventArgs e)
        {
            EquipProjectParam equipProjectParam = new EquipProjectParam();
            if (EquipProjectTextBox.Text == null || EquipProjectTextBox.Text.Equals(""))
            {
                FeedbackRich.Text += "请输入设备项目名称！\r\n";
                return;
            }
            equipProjectParam.name = EquipProjectTextBox.Text;
            ResponseResult<EquipProjectResult> result = EquipProjectApiHelper.add(equipProjectParam);
            if (result.success)
            {
                FeedbackRich.Text += "添加设备项目成功！\r\n";
            }
            else
            {
                FeedbackRich.Text += result.message + "\r\n";
            }
        }
    }
}
