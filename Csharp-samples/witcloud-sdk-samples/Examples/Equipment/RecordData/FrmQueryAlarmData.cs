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
using Wit.TestTool.ServerApi.Modular.Cloud.V1EquipAlarmApi;
using Wit.TestTool.ServerApi.Modular.Cloud.V1EquipAlarmApi.Entity;
using Wit.TestTool.ServerApi.Modular.Cloud.V1EquipAlarmApi.Param;

namespace witcloud_sdk_samples.Examples.Equipment.RecordData
{
    /// <summary>
    /// 查询历史报警记录示例
    /// </summary>
    public partial class FrmQueryAlarmData : Form
    {
        public FrmQueryAlarmData()
        {
            InitializeComponent();
        }

        /// <summary>
        /// 列表查询设备历史报警记录
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void ListQueryBtn_Click(object sender, EventArgs e)
        {
            EquipAlarmParam equipAlarmParam = new EquipAlarmParam();
            equipAlarmParam.equipment = 1551489042042724353; // 您的设备id
            ResponseResult<List<EquipAlarmResult>> result = EquipAlarmHelper.list(equipAlarmParam);
            if (result.success)
            {
                if (result.data.Count == 0)
                {
                    FeedbackRich.Text += "查询成功，无历史报警记录！\r\n";
                    return;
                }
                FeedbackRich.Text += "列表查询历史报警记录成功！\r\n";
                FeedbackRich.Text += "历史报警记录第一行报警信息如下：\r\n";
                FeedbackRich.Text += "报警的设备：" + result.data[0].Equipment + "\r\n";
                FeedbackRich.Text += "报警摘要：" + result.data[0].Summary + "\r\n";
                FeedbackRich.Text += "报警详细信息：" + result.data[0].Content + "\r\n";
                FeedbackRich.Text += "创建时间：" + result.data[0].CreateTime + "\r\n";
                FeedbackRich.Text += "查看状态：" + result.data[0].Status + "\r\n\r\n";
            }
            else
            {
                FeedbackRich.Text += result.message + "\r\n";
            }
        }

        /// <summary>
        /// 分页查询设备历史报警记录
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void PageQueryBtn_Click(object sender, EventArgs e)
        {
            PageParam pageParam = new PageParam();
            pageParam.pageSize = 100; // 设置页大小(范围 1 - 100000)
            EquipAlarmParam equipAlarmParam = new EquipAlarmParam();
            equipAlarmParam.equipment = 1551489042042724353; // 您的设备id
            ResponseResult<PageResult<EquipAlarmResult>> result = EquipAlarmHelper.page(pageParam, equipAlarmParam);
            if (result.success)
            {
                if (result.data.Rows.Count == 0)
                {
                    FeedbackRich.Text += "查询成功，无历史报警记录！\r\n";
                    return;
                }
                FeedbackRich.Text += "分页查询历史报警记录成功！\r\n";
                FeedbackRich.Text += "历史报警记录第一行报警信息如下：\r\n";
                FeedbackRich.Text += "报警的设备：" + result.data.Rows[0].Equipment + "\r\n";
                FeedbackRich.Text += "报警摘要：" + result.data.Rows[0].Summary + "\r\n";
                FeedbackRich.Text += "报警详细信息：" + result.data.Rows[0].Content + "\r\n";
                FeedbackRich.Text += "创建时间：" + result.data.Rows[0].CreateTime + "\r\n";
                FeedbackRich.Text += "查看状态：" + result.data.Rows[0].Status + "\r\n\r\n";
            }
            else
            {
                FeedbackRich.Text += result.message + "\r\n";
            }
        }
    }
}
