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
using Wit.TestTool.ServerApi.Modular.Cloud.V1EquipmentApi;
using Wit.TestTool.ServerApi.Modular.Cloud.V1EquipmentApi.Entity;
using Wit.TestTool.ServerApi.Modular.Cloud.V1EquipmentApi.Param;

namespace witcloud_sdk_samples.Examples.Equipment
{
    /// <summary>
    /// 编辑设备信息示例
    /// </summary>
    public partial class FrmEditEquipment : Form
    {
        public FrmEditEquipment()
        {
            InitializeComponent();
        }

        /// <summary>
        /// 编辑设备信息
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void EditEquipmentBtn_Click(object sender, EventArgs e)
        {
            EquipmentParam equipmentParam = new EquipmentParam();
            long EquipmentId;
            if (long.TryParse(IdTextBox.Text, out EquipmentId))
            {
                equipmentParam.id = EquipmentId;         // 设备id
            }
            else
            {
                FeedbackRich.Text += "请输入正确的设备id！\r\n";
                return;
            }
            equipmentParam.name = NameTextBox.Text;       // 设备名称
            equipmentParam.address = AddressTextBox.Text; // 设备地址
            equipmentParam.remark = RemarkTextBox.Text;   // 设备备注信息
            ResponseResult<EquipmentResult> result = EquipmentApiHelper.edit(equipmentParam);
            if (result.success)
            {
                FeedbackRich.Text += "编辑设备信息成功！\r\n";
            }
            else
            {
                FeedbackRich.Text += result.message + "\r\n";
            }

        }
    }
}
