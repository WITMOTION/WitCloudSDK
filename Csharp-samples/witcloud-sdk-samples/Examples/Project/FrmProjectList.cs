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
using Wit.TestTool.ServerApi.Core.Request;
using Wit.TestTool.ServerApi.Core.Request.Result;
using Wit.TestTool.ServerApi.Modular.Cloud.V1EquipProjectApi;
using Wit.TestTool.ServerApi.Modular.Cloud.V1EquipProjectApi.Entity;
using Wit.TestTool.ServerApi.Modular.Cloud.V1EquipProjectApi.Param;

namespace witcloud_sdk_samples.Examples.Project
{
    /// <summary>
    /// 查询设备项目列表
    /// </summary>
    public partial class FrmProjectList : Form
    {
        public FrmProjectList()
        {
            InitializeComponent();
        }

        /// <summary>
        /// 分页查询设备项目
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void ListQueryBtn_Click(object sender, EventArgs e)
        {
            ResponseResult<List<EquipProjectResult>> result = EquipProjectApiHelper.list(new EquipProjectParam());
            if (result.success)
            {
                if (result.data.Count == 0)
                {
                    FeedbackRich.Text += "查询成功，无设备项目！\r\n";
                    return;
                }
                FeedbackRich.Text += "分页查询设备项目列表成功！\r\n";
                FeedbackRich.Text += "设备项目列表第一个项目信息如下：\r\n";
                FeedbackRich.Text += "项目id：" + result.data[0].Id + "\r\n";
                FeedbackRich.Text += "项目名称：" + result.data[0].Name + "\r\n";
                FeedbackRich.Text += "拥有者：" + result.data[0].OwnerUser + "\r\n";
                FeedbackRich.Text += "创建时间：" + result.data[0].CreateTime + "\r\n";
                FeedbackRich.Text += "更新时间：" + result.data[0].UpdateTime + "\r\n";
            }
            else
            {
                FeedbackRich.Text += result.message + "\r\n";
            }
        }

        /// <summary>
        /// 分页查询设备项目
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void PageQueryBtn_Click(object sender, EventArgs e)
        {
            PageParam pageParam = new PageParam();
            pageParam.pageSize = 100; // 设置页大小(范围 1 - 100000)
            ResponseResult<PageResult<EquipProjectResult>> result = EquipProjectApiHelper.page(pageParam, new EquipProjectParam());
            if (result.success)
            {
                if (result.data.Rows.Count == 0)
                {
                    FeedbackRich.Text += "查询成功，无设备项目！\r\n";
                    return;
                }
                FeedbackRich.Text += "分页查询设备项目列表成功！\r\n";
                FeedbackRich.Text += "设备项目列表第一个项目信息如下：\r\n";
                FeedbackRich.Text += "项目id：" + result.data.Rows[0].Id + "\r\n";
                FeedbackRich.Text += "项目名称：" + result.data.Rows[0].Name + "\r\n";
                FeedbackRich.Text += "拥有者：" + result.data.Rows[0].OwnerUser + "\r\n";
                FeedbackRich.Text += "创建时间：" + result.data.Rows[0].CreateTime + "\r\n";
                FeedbackRich.Text += "更新时间：" + result.data.Rows[0].UpdateTime + "\r\n";
            }
            else
            {
                FeedbackRich.Text += result.message + "\r\n";
            }
        }
    }
}
