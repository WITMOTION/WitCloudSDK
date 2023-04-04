
namespace witcloud_sdk_samples.Examples.Equipment
{
    partial class FrmControlEquipment
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
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.FeedbackRich = new System.Windows.Forms.RichTextBox();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.label3 = new System.Windows.Forms.Label();
            this.NameTextBox = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.IdTextBox = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.CommandTextBox = new System.Windows.Forms.TextBox();
            this.SandCommandBtn = new System.Windows.Forms.Button();
            this.IsHexCheck = new System.Windows.Forms.CheckBox();
            this.label4 = new System.Windows.Forms.Label();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.FeedbackRich);
            this.groupBox1.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.groupBox1.Location = new System.Drawing.Point(0, 203);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(457, 210);
            this.groupBox1.TabIndex = 5;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "反馈信息";
            // 
            // FeedbackRich
            // 
            this.FeedbackRich.Dock = System.Windows.Forms.DockStyle.Fill;
            this.FeedbackRich.Location = new System.Drawing.Point(3, 21);
            this.FeedbackRich.Name = "FeedbackRich";
            this.FeedbackRich.Size = new System.Drawing.Size(451, 186);
            this.FeedbackRich.TabIndex = 0;
            this.FeedbackRich.Text = "";
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.IsHexCheck);
            this.groupBox2.Controls.Add(this.label4);
            this.groupBox2.Controls.Add(this.label3);
            this.groupBox2.Controls.Add(this.NameTextBox);
            this.groupBox2.Controls.Add(this.label2);
            this.groupBox2.Controls.Add(this.IdTextBox);
            this.groupBox2.Controls.Add(this.label1);
            this.groupBox2.Controls.Add(this.CommandTextBox);
            this.groupBox2.Controls.Add(this.SandCommandBtn);
            this.groupBox2.Dock = System.Windows.Forms.DockStyle.Top;
            this.groupBox2.Location = new System.Drawing.Point(0, 0);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(457, 197);
            this.groupBox2.TabIndex = 6;
            this.groupBox2.TabStop = false;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(129, 89);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(75, 15);
            this.label3.TabIndex = 8;
            this.label3.Text = "操作名称:";
            // 
            // NameTextBox
            // 
            this.NameTextBox.Location = new System.Drawing.Point(210, 86);
            this.NameTextBox.Name = "NameTextBox";
            this.NameTextBox.Size = new System.Drawing.Size(144, 25);
            this.NameTextBox.TabIndex = 7;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(143, 27);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(61, 15);
            this.label2.TabIndex = 6;
            this.label2.Text = "设备id:";
            // 
            // IdTextBox
            // 
            this.IdTextBox.Location = new System.Drawing.Point(210, 24);
            this.IdTextBox.Name = "IdTextBox";
            this.IdTextBox.Size = new System.Drawing.Size(144, 25);
            this.IdTextBox.TabIndex = 5;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(115, 58);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(90, 15);
            this.label1.TabIndex = 4;
            this.label1.Text = "发送的命令:";
            // 
            // CommandTextBox
            // 
            this.CommandTextBox.Location = new System.Drawing.Point(210, 55);
            this.CommandTextBox.Name = "CommandTextBox";
            this.CommandTextBox.Size = new System.Drawing.Size(144, 25);
            this.CommandTextBox.TabIndex = 2;
            // 
            // SandCommandBtn
            // 
            this.SandCommandBtn.Location = new System.Drawing.Point(166, 162);
            this.SandCommandBtn.Name = "SandCommandBtn";
            this.SandCommandBtn.Size = new System.Drawing.Size(126, 29);
            this.SandCommandBtn.TabIndex = 0;
            this.SandCommandBtn.Text = "发送命令";
            this.SandCommandBtn.UseVisualStyleBackColor = true;
            this.SandCommandBtn.Click += new System.EventHandler(this.SandCommandBtn_Click);
            // 
            // IsHexCheck
            // 
            this.IsHexCheck.AutoSize = true;
            this.IsHexCheck.Location = new System.Drawing.Point(210, 119);
            this.IsHexCheck.Name = "IsHexCheck";
            this.IsHexCheck.Size = new System.Drawing.Size(23, 21);
            this.IsHexCheck.TabIndex = 11;
            this.IsHexCheck.UseVisualStyleBackColor = true;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(98, 120);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(106, 15);
            this.label4.TabIndex = 10;
            this.label4.Text = "是否为16进制:";
            // 
            // FrmControlEquipment
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(457, 413);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.groupBox2);
            this.Name = "FrmControlEquipment";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "控制设备示例";
            this.groupBox1.ResumeLayout(false);
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.RichTextBox FeedbackRich;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox NameTextBox;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox IdTextBox;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox CommandTextBox;
        private System.Windows.Forms.Button SandCommandBtn;
        private System.Windows.Forms.CheckBox IsHexCheck;
        private System.Windows.Forms.Label label4;
    }
}