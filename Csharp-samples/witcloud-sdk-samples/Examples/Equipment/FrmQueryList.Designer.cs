
namespace witcloud_sdk_samples.Examples.Equipment
{
    partial class FrmQueryList
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.ListQueryBtn = new System.Windows.Forms.Button();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.FeedbackRich = new System.Windows.Forms.RichTextBox();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.PageQueryBtn = new System.Windows.Forms.Button();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.SuspendLayout();
            // 
            // ListQueryBtn
            // 
            this.ListQueryBtn.Location = new System.Drawing.Point(74, 24);
            this.ListQueryBtn.Name = "ListQueryBtn";
            this.ListQueryBtn.Size = new System.Drawing.Size(126, 29);
            this.ListQueryBtn.TabIndex = 0;
            this.ListQueryBtn.Text = "列表查询";
            this.ListQueryBtn.UseVisualStyleBackColor = true;
            this.ListQueryBtn.Click += new System.EventHandler(this.ListQueryBtn_Click);
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.FeedbackRich);
            this.groupBox1.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.groupBox1.Location = new System.Drawing.Point(10, 83);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(467, 210);
            this.groupBox1.TabIndex = 1;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "反馈信息";
            // 
            // FeedbackRich
            // 
            this.FeedbackRich.Dock = System.Windows.Forms.DockStyle.Fill;
            this.FeedbackRich.Location = new System.Drawing.Point(3, 21);
            this.FeedbackRich.Name = "FeedbackRich";
            this.FeedbackRich.Size = new System.Drawing.Size(461, 186);
            this.FeedbackRich.TabIndex = 0;
            this.FeedbackRich.Text = "";
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.PageQueryBtn);
            this.groupBox2.Controls.Add(this.ListQueryBtn);
            this.groupBox2.Dock = System.Windows.Forms.DockStyle.Top;
            this.groupBox2.Location = new System.Drawing.Point(10, 10);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(467, 67);
            this.groupBox2.TabIndex = 2;
            this.groupBox2.TabStop = false;
            // 
            // PageQueryBtn
            // 
            this.PageQueryBtn.Location = new System.Drawing.Point(262, 24);
            this.PageQueryBtn.Name = "PageQueryBtn";
            this.PageQueryBtn.Size = new System.Drawing.Size(126, 29);
            this.PageQueryBtn.TabIndex = 2;
            this.PageQueryBtn.Text = "分页查询";
            this.PageQueryBtn.UseVisualStyleBackColor = true;
            this.PageQueryBtn.Click += new System.EventHandler(this.PageQueryBtn_Click);
            // 
            // FrmQueryList
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(487, 303);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Name = "FrmQueryList";
            this.Padding = new System.Windows.Forms.Padding(10);
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "查询设备列表示例";
            this.groupBox1.ResumeLayout(false);
            this.groupBox2.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button ListQueryBtn;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.RichTextBox FeedbackRich;
        private System.Windows.Forms.Button PageQueryBtn;
    }
}