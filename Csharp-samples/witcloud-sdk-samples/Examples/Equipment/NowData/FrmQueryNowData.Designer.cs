
namespace witcloud_sdk_samples.Examples.Equipment.NowData
{
    partial class FrmQueryNowData
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
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.QueryNowDateBtn = new System.Windows.Forms.Button();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.FeedbackRich = new System.Windows.Forms.RichTextBox();
            this.groupBox2.SuspendLayout();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.QueryNowDateBtn);
            this.groupBox2.Dock = System.Windows.Forms.DockStyle.Top;
            this.groupBox2.Location = new System.Drawing.Point(0, 0);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(403, 67);
            this.groupBox2.TabIndex = 8;
            this.groupBox2.TabStop = false;
            // 
            // QueryNowDateBtn
            // 
            this.QueryNowDateBtn.Location = new System.Drawing.Point(139, 24);
            this.QueryNowDateBtn.Name = "QueryNowDateBtn";
            this.QueryNowDateBtn.Size = new System.Drawing.Size(126, 29);
            this.QueryNowDateBtn.TabIndex = 2;
            this.QueryNowDateBtn.Text = "查询实时数据";
            this.QueryNowDateBtn.UseVisualStyleBackColor = true;
            this.QueryNowDateBtn.Click += new System.EventHandler(this.QueryNowDateBtn_Click);
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.FeedbackRich);
            this.groupBox1.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.groupBox1.Location = new System.Drawing.Point(0, 73);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(403, 242);
            this.groupBox1.TabIndex = 7;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "反馈信息";
            // 
            // FeedbackRich
            // 
            this.FeedbackRich.Dock = System.Windows.Forms.DockStyle.Fill;
            this.FeedbackRich.Location = new System.Drawing.Point(3, 21);
            this.FeedbackRich.Name = "FeedbackRich";
            this.FeedbackRich.Size = new System.Drawing.Size(397, 218);
            this.FeedbackRich.TabIndex = 0;
            this.FeedbackRich.Text = "";
            // 
            // FrmQueryNowData
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(403, 315);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Name = "FrmQueryNowData";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "查询设备实时数据";
            this.groupBox2.ResumeLayout(false);
            this.groupBox1.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.Button QueryNowDateBtn;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.RichTextBox FeedbackRich;
    }
}