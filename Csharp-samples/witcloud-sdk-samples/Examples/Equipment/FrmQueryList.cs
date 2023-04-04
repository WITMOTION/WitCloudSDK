using System;
using System.Collections.Generic;
using System.Windows.Forms;
using Wit.TestTool.ServerApi.Core;
using Wit.TestTool.ServerApi.Core.Request;
using Wit.TestTool.ServerApi.Core.Request.Result;
using Wit.TestTool.ServerApi.Modular.Cloud.V1EquipmentApi;
using Wit.TestTool.ServerApi.Modular.Cloud.V1EquipmentApi.Entity;
using Wit.TestTool.ServerApi.Modular.Cloud.V1EquipmentApi.Param;

namespace witcloud_sdk_samples.Examples.Equipment
{
    /// <summary>
    /// 查询设备列表示例
    /// </summary>
    public partial class FrmQueryList : Form
    {
        public FrmQueryList()
        {
            InitializeComponent();
        }

        /// <summary>
        /// 列表查询设备列表
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void ListQueryBtn_Click(object sender, EventArgs e)
        {
            ResponseResult<List<EquipmentResult>> result = EquipmentApiHelper.list(new EquipmentParam());
            if (result.success)
            {
                if (result.data.Count == 0)
                {
                    FeedbackRich.Text += "查询成功，无设备绑定！\r\n";
                    return;
                }
                FeedbackRich.Text += "列表查询设备列表成功！\r\n";
                FeedbackRich.Text += "设备列表第一个设备信息如下：\r\n";
                FeedbackRich.Text += "设备id：" + result.data[0].Id + "\r\n";
                FeedbackRich.Text += "在线状态：" + result.data[0].OnlineStatus + "\r\n";
                FeedbackRich.Text += "最后在线时间：" + result.data[0].LastOnlineTime + "\r\n";
                FeedbackRich.Text += "设备号：" + result.data[0].No + "\r\n";
                FeedbackRich.Text += "设备类型：" + result.data[0].Type + "\r\n";
                FeedbackRich.Text += "数据存储数量：" + result.data[0].CurrentDataStorage + "\r\n";
                FeedbackRich.Text += "设备标签：" + result.data[0].Labels + "\r\n";
                FeedbackRich.Text += "设备项目：" + result.data[0].ProjectId + "\r\n";
                FeedbackRich.Text += "设备状态：" + result.data[0].Status + "\r\n\r\n";
            }
            else
            {
                FeedbackRich.Text += result.message + "\r\n";
            }
        }

        /// <summary>
        /// 分页查询设备列表
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void PageQueryBtn_Click(object sender, EventArgs e)
        {
            PageParam pageParam = new PageParam();
            pageParam.pageSize = 100; // 设置页大小(范围 1 - 100000)
            ResponseResult<PageResult<EquipmentResult>> result = EquipmentApiHelper.page(pageParam,new EquipmentParam());
            if (result.success)
            {
                if (result.data.Rows.Count == 0)
                {
                    FeedbackRich.Text += "查询成功，无设备绑定！\r\n";
                    return;
                }
                FeedbackRich.Text += "分页查询设备列表成功！\r\n";
                FeedbackRich.Text += "设备列表第一个设备信息如下：\r\n";
                FeedbackRich.Text += "设备id：" + result.data.Rows[0].Id + "\r\n";
                FeedbackRich.Text += "在线状态：" + result.data.Rows[0].OnlineStatus + "\r\n";
                FeedbackRich.Text += "最后在线时间：" + result.data.Rows[0].LastOnlineTime + "\r\n";
                FeedbackRich.Text += "设备号：" + result.data.Rows[0].No + "\r\n";
                FeedbackRich.Text += "设备类型：" + result.data.Rows[0].Type + "\r\n";
                FeedbackRich.Text += "数据存储数量：" + result.data.Rows[0].CurrentDataStorage + "\r\n";
                FeedbackRich.Text += "设备标签：" + result.data.Rows[0].Labels + "\r\n";
                FeedbackRich.Text += "设备项目：" + result.data.Rows[0].ProjectId + "\r\n";
                FeedbackRich.Text += "设备状态：" + result.data.Rows[0].Status + "\r\n\r\n";
            }
            else
            {
                FeedbackRich.Text += result.message + "\r\n";
            }
        }
    }
}
