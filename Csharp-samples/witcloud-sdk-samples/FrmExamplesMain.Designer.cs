
namespace witcloud_sdk_samples
{
    partial class FrmExamplesMain
    {
        /// <summary>
        /// 必需的设计器变量。
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// 清理所有正在使用的资源。
        /// </summary>
        /// <param name="disposing">如果应释放托管资源，为 true；否则为 false。</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows 窗体设计器生成的代码

        /// <summary>
        /// 设计器支持所需的方法 - 不要修改
        /// 使用代码编辑器修改此方法的内容。
        /// </summary>
        private void InitializeComponent()
        {
            this.QueryListBtn = new System.Windows.Forms.Button();
            this.QueryDetailBtn = new System.Windows.Forms.Button();
            this.EditEquipmentBtn = new System.Windows.Forms.Button();
            this.ControlEquipmentBtn = new System.Windows.Forms.Button();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.QueryRealTimeBtn = new System.Windows.Forms.Button();
            this.QueryOperationBtn = new System.Windows.Forms.Button();
            this.QueryAlarmBtn = new System.Windows.Forms.Button();
            this.QueryHistoryBtn = new System.Windows.Forms.Button();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.AddLabelBtn = new System.Windows.Forms.Button();
            this.LabelListBtn = new System.Windows.Forms.Button();
            this.DeleteLabelBtn = new System.Windows.Forms.Button();
            this.EditLabelBtn = new System.Windows.Forms.Button();
            this.groupBox4 = new System.Windows.Forms.GroupBox();
            this.AddProjectBtn = new System.Windows.Forms.Button();
            this.ProjectListBtn = new System.Windows.Forms.Button();
            this.DeleteProjectBtn = new System.Windows.Forms.Button();
            this.EditProjectBtn = new System.Windows.Forms.Button();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.groupBox3.SuspendLayout();
            this.groupBox4.SuspendLayout();
            this.SuspendLayout();
            // 
            // QueryListBtn
            // 
            this.QueryListBtn.Location = new System.Drawing.Point(33, 37);
            this.QueryListBtn.Name = "QueryListBtn";
            this.QueryListBtn.Size = new System.Drawing.Size(167, 23);
            this.QueryListBtn.TabIndex = 1;
            this.QueryListBtn.Text = "查询设备列表示例";
            this.QueryListBtn.UseVisualStyleBackColor = true;
            this.QueryListBtn.Click += new System.EventHandler(this.QueryListBtn_Click);
            // 
            // QueryDetailBtn
            // 
            this.QueryDetailBtn.Location = new System.Drawing.Point(33, 80);
            this.QueryDetailBtn.Name = "QueryDetailBtn";
            this.QueryDetailBtn.Size = new System.Drawing.Size(167, 23);
            this.QueryDetailBtn.TabIndex = 2;
            this.QueryDetailBtn.Text = "查询设备详细示例";
            this.QueryDetailBtn.UseVisualStyleBackColor = true;
            this.QueryDetailBtn.Click += new System.EventHandler(this.QueryDetailBtn_Click);
            // 
            // EditEquipmentBtn
            // 
            this.EditEquipmentBtn.Location = new System.Drawing.Point(33, 119);
            this.EditEquipmentBtn.Name = "EditEquipmentBtn";
            this.EditEquipmentBtn.Size = new System.Drawing.Size(167, 23);
            this.EditEquipmentBtn.TabIndex = 4;
            this.EditEquipmentBtn.Text = "编辑设备信息示例";
            this.EditEquipmentBtn.UseVisualStyleBackColor = true;
            this.EditEquipmentBtn.Click += new System.EventHandler(this.EditEquipmentBtn_Click);
            // 
            // ControlEquipmentBtn
            // 
            this.ControlEquipmentBtn.Location = new System.Drawing.Point(33, 159);
            this.ControlEquipmentBtn.Name = "ControlEquipmentBtn";
            this.ControlEquipmentBtn.Size = new System.Drawing.Size(167, 23);
            this.ControlEquipmentBtn.TabIndex = 5;
            this.ControlEquipmentBtn.Text = "控制设备信息示例";
            this.ControlEquipmentBtn.UseVisualStyleBackColor = true;
            this.ControlEquipmentBtn.Click += new System.EventHandler(this.ControlEquipmentBtn_Click);
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.QueryListBtn);
            this.groupBox1.Controls.Add(this.ControlEquipmentBtn);
            this.groupBox1.Controls.Add(this.QueryDetailBtn);
            this.groupBox1.Controls.Add(this.EditEquipmentBtn);
            this.groupBox1.Location = new System.Drawing.Point(24, 12);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(249, 211);
            this.groupBox1.TabIndex = 6;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "设备操作";
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.QueryRealTimeBtn);
            this.groupBox2.Controls.Add(this.QueryOperationBtn);
            this.groupBox2.Controls.Add(this.QueryAlarmBtn);
            this.groupBox2.Controls.Add(this.QueryHistoryBtn);
            this.groupBox2.Location = new System.Drawing.Point(296, 12);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(249, 211);
            this.groupBox2.TabIndex = 7;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "设备数据";
            // 
            // QueryRealTimeBtn
            // 
            this.QueryRealTimeBtn.Location = new System.Drawing.Point(33, 159);
            this.QueryRealTimeBtn.Name = "QueryRealTimeBtn";
            this.QueryRealTimeBtn.Size = new System.Drawing.Size(167, 23);
            this.QueryRealTimeBtn.TabIndex = 4;
            this.QueryRealTimeBtn.Text = "查询实时数据示例";
            this.QueryRealTimeBtn.UseVisualStyleBackColor = true;
            this.QueryRealTimeBtn.Click += new System.EventHandler(this.QueryRealTimeBtn_Click);
            // 
            // QueryOperationBtn
            // 
            this.QueryOperationBtn.Location = new System.Drawing.Point(33, 119);
            this.QueryOperationBtn.Name = "QueryOperationBtn";
            this.QueryOperationBtn.Size = new System.Drawing.Size(167, 23);
            this.QueryOperationBtn.TabIndex = 3;
            this.QueryOperationBtn.Text = "查询操作数据示例";
            this.QueryOperationBtn.UseVisualStyleBackColor = true;
            this.QueryOperationBtn.Click += new System.EventHandler(this.QueryOperationBtn_Click);
            // 
            // QueryAlarmBtn
            // 
            this.QueryAlarmBtn.Location = new System.Drawing.Point(33, 80);
            this.QueryAlarmBtn.Name = "QueryAlarmBtn";
            this.QueryAlarmBtn.Size = new System.Drawing.Size(167, 23);
            this.QueryAlarmBtn.TabIndex = 2;
            this.QueryAlarmBtn.Text = "查询报警数据示例";
            this.QueryAlarmBtn.UseVisualStyleBackColor = true;
            this.QueryAlarmBtn.Click += new System.EventHandler(this.QueryAlarmBtn_Click);
            // 
            // QueryHistoryBtn
            // 
            this.QueryHistoryBtn.Location = new System.Drawing.Point(33, 37);
            this.QueryHistoryBtn.Name = "QueryHistoryBtn";
            this.QueryHistoryBtn.Size = new System.Drawing.Size(167, 23);
            this.QueryHistoryBtn.TabIndex = 1;
            this.QueryHistoryBtn.Text = "查询历史数据示例";
            this.QueryHistoryBtn.UseVisualStyleBackColor = true;
            this.QueryHistoryBtn.Click += new System.EventHandler(this.QueryHistoryBtn_Click);
            // 
            // groupBox3
            // 
            this.groupBox3.Controls.Add(this.AddLabelBtn);
            this.groupBox3.Controls.Add(this.LabelListBtn);
            this.groupBox3.Controls.Add(this.DeleteLabelBtn);
            this.groupBox3.Controls.Add(this.EditLabelBtn);
            this.groupBox3.Location = new System.Drawing.Point(24, 239);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(249, 211);
            this.groupBox3.TabIndex = 8;
            this.groupBox3.TabStop = false;
            this.groupBox3.Text = "设备标签";
            // 
            // AddLabelBtn
            // 
            this.AddLabelBtn.Location = new System.Drawing.Point(33, 37);
            this.AddLabelBtn.Name = "AddLabelBtn";
            this.AddLabelBtn.Size = new System.Drawing.Size(167, 23);
            this.AddLabelBtn.TabIndex = 1;
            this.AddLabelBtn.Text = "添加标签示例";
            this.AddLabelBtn.UseVisualStyleBackColor = true;
            this.AddLabelBtn.Click += new System.EventHandler(this.AddLabelBtn_Click);
            // 
            // LabelListBtn
            // 
            this.LabelListBtn.Location = new System.Drawing.Point(33, 159);
            this.LabelListBtn.Name = "LabelListBtn";
            this.LabelListBtn.Size = new System.Drawing.Size(167, 23);
            this.LabelListBtn.TabIndex = 5;
            this.LabelListBtn.Text = "查询标签列表示例";
            this.LabelListBtn.UseVisualStyleBackColor = true;
            this.LabelListBtn.Click += new System.EventHandler(this.LabelListBtn_Click);
            // 
            // DeleteLabelBtn
            // 
            this.DeleteLabelBtn.Location = new System.Drawing.Point(33, 80);
            this.DeleteLabelBtn.Name = "DeleteLabelBtn";
            this.DeleteLabelBtn.Size = new System.Drawing.Size(167, 23);
            this.DeleteLabelBtn.TabIndex = 2;
            this.DeleteLabelBtn.Text = "删除标签示例";
            this.DeleteLabelBtn.UseVisualStyleBackColor = true;
            this.DeleteLabelBtn.Click += new System.EventHandler(this.DeleteLabelBtn_Click);
            // 
            // EditLabelBtn
            // 
            this.EditLabelBtn.Location = new System.Drawing.Point(33, 119);
            this.EditLabelBtn.Name = "EditLabelBtn";
            this.EditLabelBtn.Size = new System.Drawing.Size(167, 23);
            this.EditLabelBtn.TabIndex = 4;
            this.EditLabelBtn.Text = "编辑标签示例";
            this.EditLabelBtn.UseVisualStyleBackColor = true;
            this.EditLabelBtn.Click += new System.EventHandler(this.EditLabelBtn_Click);
            // 
            // groupBox4
            // 
            this.groupBox4.Controls.Add(this.AddProjectBtn);
            this.groupBox4.Controls.Add(this.ProjectListBtn);
            this.groupBox4.Controls.Add(this.DeleteProjectBtn);
            this.groupBox4.Controls.Add(this.EditProjectBtn);
            this.groupBox4.Location = new System.Drawing.Point(296, 239);
            this.groupBox4.Name = "groupBox4";
            this.groupBox4.Size = new System.Drawing.Size(249, 211);
            this.groupBox4.TabIndex = 9;
            this.groupBox4.TabStop = false;
            this.groupBox4.Text = "设备项目";
            // 
            // AddProjectBtn
            // 
            this.AddProjectBtn.Location = new System.Drawing.Point(33, 37);
            this.AddProjectBtn.Name = "AddProjectBtn";
            this.AddProjectBtn.Size = new System.Drawing.Size(167, 23);
            this.AddProjectBtn.TabIndex = 1;
            this.AddProjectBtn.Text = "添加项目示例";
            this.AddProjectBtn.UseVisualStyleBackColor = true;
            this.AddProjectBtn.Click += new System.EventHandler(this.AddProjectBtn_Click);
            // 
            // ProjectListBtn
            // 
            this.ProjectListBtn.Location = new System.Drawing.Point(33, 159);
            this.ProjectListBtn.Name = "ProjectListBtn";
            this.ProjectListBtn.Size = new System.Drawing.Size(167, 23);
            this.ProjectListBtn.TabIndex = 5;
            this.ProjectListBtn.Text = "查询项目列表示例";
            this.ProjectListBtn.UseVisualStyleBackColor = true;
            this.ProjectListBtn.Click += new System.EventHandler(this.ProjectListBtn_Click);
            // 
            // DeleteProjectBtn
            // 
            this.DeleteProjectBtn.Location = new System.Drawing.Point(33, 80);
            this.DeleteProjectBtn.Name = "DeleteProjectBtn";
            this.DeleteProjectBtn.Size = new System.Drawing.Size(167, 23);
            this.DeleteProjectBtn.TabIndex = 2;
            this.DeleteProjectBtn.Text = "删除项目示例";
            this.DeleteProjectBtn.UseVisualStyleBackColor = true;
            this.DeleteProjectBtn.Click += new System.EventHandler(this.DeleteProjectBtn_Click);
            // 
            // EditProjectBtn
            // 
            this.EditProjectBtn.Location = new System.Drawing.Point(33, 119);
            this.EditProjectBtn.Name = "EditProjectBtn";
            this.EditProjectBtn.Size = new System.Drawing.Size(167, 23);
            this.EditProjectBtn.TabIndex = 4;
            this.EditProjectBtn.Text = "编辑项目示例";
            this.EditProjectBtn.UseVisualStyleBackColor = true;
            this.EditProjectBtn.Click += new System.EventHandler(this.EditProjectBtn_Click);
            // 
            // FrmExamplesMain
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(567, 464);
            this.Controls.Add(this.groupBox4);
            this.Controls.Add(this.groupBox3);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Name = "FrmExamplesMain";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "示例主窗口";
            this.groupBox1.ResumeLayout(false);
            this.groupBox2.ResumeLayout(false);
            this.groupBox3.ResumeLayout(false);
            this.groupBox4.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.Button QueryListBtn;
        private System.Windows.Forms.Button QueryDetailBtn;
        private System.Windows.Forms.Button EditEquipmentBtn;
        private System.Windows.Forms.Button ControlEquipmentBtn;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.Button QueryHistoryBtn;
        private System.Windows.Forms.GroupBox groupBox3;
        private System.Windows.Forms.Button AddLabelBtn;
        private System.Windows.Forms.Button LabelListBtn;
        private System.Windows.Forms.Button DeleteLabelBtn;
        private System.Windows.Forms.Button EditLabelBtn;
        private System.Windows.Forms.GroupBox groupBox4;
        private System.Windows.Forms.Button AddProjectBtn;
        private System.Windows.Forms.Button ProjectListBtn;
        private System.Windows.Forms.Button DeleteProjectBtn;
        private System.Windows.Forms.Button EditProjectBtn;
        private System.Windows.Forms.Button QueryRealTimeBtn;
        private System.Windows.Forms.Button QueryOperationBtn;
        private System.Windows.Forms.Button QueryAlarmBtn;
    }
}

