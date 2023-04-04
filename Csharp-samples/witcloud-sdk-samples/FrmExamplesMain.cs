using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using witcloud_sdk_samples.Examples;
using witcloud_sdk_samples.Examples.Equipment;
using witcloud_sdk_samples.Examples.Equipment.NowData;
using witcloud_sdk_samples.Examples.Equipment.RecordData;
using witcloud_sdk_samples.Examples.Label;
using witcloud_sdk_samples.Examples.Project;

namespace witcloud_sdk_samples
{
    public partial class FrmExamplesMain : Form
    {
        public FrmExamplesMain()
        {
            InitializeComponent();
        }

        /// <summary>
        /// 进入查询设备列表示例
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void QueryListBtn_Click(object sender, EventArgs e)
        {
            FrmQueryList frmQueryList = new FrmQueryList();
            frmQueryList.Show();
        }

        /// <summary>
        /// 进入查询设备详细示例
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void QueryDetailBtn_Click(object sender, EventArgs e)
        {
            FrmQueryDetail frmQueryDetail = new FrmQueryDetail();
            frmQueryDetail.Show();
        }

        /// <summary>
        /// 进入编辑设备信息示例
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void EditEquipmentBtn_Click(object sender, EventArgs e)
        {
            FrmEditEquipment frmEditEquipment = new FrmEditEquipment();
            frmEditEquipment.Show();
        }

        /// <summary>
        /// 进入控制设备信息示例
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void ControlEquipmentBtn_Click(object sender, EventArgs e)
        {
            FrmControlEquipment frmControlEquipment = new FrmControlEquipment();
            frmControlEquipment.Show();
        }

        /// <summary>
        /// 进入查询设备历史数据示例
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void QueryHistoryBtn_Click(object sender, EventArgs e)
        {
            FrmQueryHistoryData frmQueryHistoryData = new FrmQueryHistoryData();
            frmQueryHistoryData.Show();
        }

        /// <summary>
        /// 进入查询设备历史报警数据示例
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void QueryAlarmBtn_Click(object sender, EventArgs e)
        {
            FrmQueryAlarmData frmQueryAlarmData = new FrmQueryAlarmData();
            frmQueryAlarmData.Show();
        }

        /// <summary>
        /// 进入查询设备历史操作数据示例
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void QueryOperationBtn_Click(object sender, EventArgs e)
        {
            FrmQueryOperationData frmQueryOperationData = new FrmQueryOperationData();
            frmQueryOperationData.Show();
        }

        /// <summary>
        /// 进入查询设备实时数据示例
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void QueryRealTimeBtn_Click(object sender, EventArgs e)
        {
            FrmQueryNowData frmQueryNowData = new FrmQueryNowData();
            frmQueryNowData.Show();
        }

        /// <summary>
        /// 进入添加设备标签示例
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void AddLabelBtn_Click(object sender, EventArgs e)
        {
            FrmAddLabel frmAddLabel = new FrmAddLabel();
            frmAddLabel.Show();
        }

        /// <summary>
        /// 进入删除设备标签示例
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void DeleteLabelBtn_Click(object sender, EventArgs e)
        {
            FrmDeleteLabel frmDeleteLabel = new FrmDeleteLabel();
            frmDeleteLabel.Show();
        }

        /// <summary>
        /// 进入编辑设备标签示例
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void EditLabelBtn_Click(object sender, EventArgs e)
        {
            FrmEditLabel frmEditLabel = new FrmEditLabel();
            frmEditLabel.Show();
        }

        /// <summary>
        /// 进入查询设备标签列表示例
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void LabelListBtn_Click(object sender, EventArgs e)
        {
            FrmLabelList frmLabelList = new FrmLabelList();
            frmLabelList.Show();
        }

        /// <summary>
        /// 进入添加设备项目示例
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void AddProjectBtn_Click(object sender, EventArgs e)
        {
            FrmAddProject frmAddProject = new FrmAddProject();
            frmAddProject.Show();
        }

        /// <summary>
        /// 进入删除设备项目示例
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void DeleteProjectBtn_Click(object sender, EventArgs e)
        {
            FrmDeleteProject frmDeleteProject = new FrmDeleteProject();
            frmDeleteProject.Show();
        }

        /// <summary>
        /// 进入编辑设备项目示例
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void EditProjectBtn_Click(object sender, EventArgs e)
        {
            FrmEditProject frmEditProject = new FrmEditProject();
            frmEditProject.Show();
        }

        /// <summary>
        /// 进入查询设备项目列表示例
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void ProjectListBtn_Click(object sender, EventArgs e)
        {
            FrmProjectList frmProjectList = new FrmProjectList();
            frmProjectList.Show();
        }
    }
}
