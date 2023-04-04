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
using Wit.TestTool.ServerApi.Modular.Cloud.V1EquipRecordApi;
using Wit.TestTool.ServerApi.Modular.Cloud.V1EquipRecordApi.Param;

namespace witcloud_sdk_samples.Examples.Equipment.RecordData
{
    /// <summary>
    /// 查看设备历史数据示例
    /// </summary>
    public partial class FrmQueryHistoryData : Form
    {
        public FrmQueryHistoryData()
        {
            InitializeComponent();
        }

        /// <summary>
        /// 列表查询设备历史数据
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void ListQueryBtn_Click(object sender, EventArgs e)
        {
            EquipRecordParam equipRecordParam = new EquipRecordParam();
            equipRecordParam.equipmentId = 1551489042042724353; // 您的设备id
            ResponseResult<List<Dictionary<string, string>>> result = EquipRecordApiHelper.clientList(equipRecordParam);
            if (result.success)
            {
                if(result.data.Count == 0)
                {
                    FeedbackRich.Text += "查询成功，无设备历史数据！\r\n";
                    return;
                }
                Dictionary<string, string> keyValuePairs = result.data[0];
                FeedbackRich.Text += "列表查询设备历史数据成功！\r\n";
                FeedbackRich.Text += "设备历史数据第一行如下：\r\n";
                for(int i = 0;i < keyValuePairs.Count; i++)
                {
                    var item =  keyValuePairs.ElementAt(i);
                    var itemKey = item.Key;
                    var itemValue = item.Value;
                    FeedbackRich.Text += itemKey + ":" + itemValue + "\r\n";
                }
            }
            else
            {
                FeedbackRich.Text += result.message + "\r\n";
            }
        }

        /// <summary>
        /// 分页查询设备历史数据
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void PageQueryBtn_Click(object sender, EventArgs e)
        {
            PageParam pageParam = new PageParam();
            pageParam.pageSize = 100; // 设置页大小(范围 1 - 100000)
            EquipRecordParam equipRecordParam = new EquipRecordParam();
            equipRecordParam.equipmentId = 1551489042042724353; // 您的设备id
            ResponseResult<PageResult<Dictionary<string, string>>> result = EquipRecordApiHelper.clientPage(pageParam,equipRecordParam);
            if (result.success)
            {
                if (result.data.Rows.Count == 0)
                {
                    FeedbackRich.Text += "查询成功，无设备历史数据！\r\n";
                    return;
                }
                Dictionary<string, string> keyValuePairs = result.data.Rows[0];
                FeedbackRich.Text += "分页查询设备历史数据成功！\r\n";
                FeedbackRich.Text += "设备历史数据第一行如下：\r\n";
                for (int i = 0; i < keyValuePairs.Count; i++)
                {
                    var item = keyValuePairs.ElementAt(i);
                    var itemKey = item.Key;
                    var itemValue = item.Value;
                    FeedbackRich.Text += itemKey + ":" + itemValue + "\r\n";
                }
            }
            else
            {
                FeedbackRich.Text += result.message + "\r\n";
            }
        }
    }
}
