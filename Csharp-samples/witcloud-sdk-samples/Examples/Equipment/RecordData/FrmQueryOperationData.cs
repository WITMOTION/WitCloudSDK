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
using Wit.TestTool.ServerApi.Modular.Cloud.V1EquipOperationApi;
using Wit.TestTool.ServerApi.Modular.Cloud.V1EquipOperationApi.Entity;
using Wit.TestTool.ServerApi.Modular.Cloud.V1EquipOperationApi.Param;

namespace witcloud_sdk_samples.Examples.Equipment.RecordData
{
    /// <summary>
    /// 查询设备历史操作记录示例
    /// </summary>
    public partial class FrmQueryOperationData : Form
    {
        public FrmQueryOperationData()
        {
            InitializeComponent();
        }

        /// <summary>
        /// 分页查询设备历史操作记录
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void PageQueryBtn_Click(object sender, EventArgs e)
        {
            PageParam pageParam = new PageParam();
            pageParam.pageSize = 100; // 设置页大小(范围 1 - 100000)
            ResponseResult<PageResult<EquipOperationResult>> result = EquipOperationApiHelper.page(pageParam,new EquipOperationParam());
            if (result.success)
            {
                if (result.data.Rows.Count == 0)
                {
                    FeedbackRich.Text += "查询成功，无历史操作记录！\r\n";
                    return;
                }
                FeedbackRich.Text += "列表查询历史操作记录成功！\r\n";
                FeedbackRich.Text += "历史操作记录第一行操作信息如下：\r\n";
                FeedbackRich.Text += "操作类型：" + result.data.Rows[0].Type + "\r\n";
                FeedbackRich.Text += "操作名称：" + result.data.Rows[0].Name + "\r\n";
                FeedbackRich.Text += "设备编号：" + result.data.Rows[0].EquipmentNo + "\r\n";
                FeedbackRich.Text += "被操作的设备：" + result.data.Rows[0].EquipmentId + "\r\n";
                FeedbackRich.Text += "到达时间：" + result.data.Rows[0].ArrivalTime + "\r\n\r\n";
                FeedbackRich.Text += "状态：" + result.data.Rows[0].Status + "\r\n\r\n";
                FeedbackRich.Text += "下发的命令：" + result.data.Rows[0].Command + "\r\n\r\n";
            }
            else
            {
                FeedbackRich.Text += result.message + "\r\n";
            }
        }
    }
}
