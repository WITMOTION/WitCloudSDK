using System;
using System.Threading;
using System.Windows.Forms;
using Wit.TestTool.ServerApi.Core;
using Wit.TestTool.ServerApi.Modular.Cloud.Login;
using Wit.TestTool.ServerApi.Modular.Cloud.Login.Param;

namespace witcloud_sdk_samples.Examples
{
    /// <summary>
    /// api账号登录示例
    /// </summary>
    public partial class FrmLogin : Form
    {
        public FrmLogin()
        {
            InitializeComponent();
        }


        /// <summary>
        /// api账号登录
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void LoginBtn_Click(object sender, EventArgs e)
        {
            LoginParam loginParam = new LoginParam();
            loginParam.appId = AccountTextBox.Text;       // 您的api账号
            loginParam.appSecret = PasswordTextBox.Text;  // 您的api密码
            ResponseResult<string> result = LoginApiHelper.login(loginParam);
            if (result.success)
            {
                FeedbackRich.Text += "登录成功！\r\n";
                FeedbackRich.Text += "登录身份 data=>：" + result.data + "\r\n";
            }
            else
            {
                FeedbackRich.Text += result.message + "\r\n";
            }
        }
    }
}
