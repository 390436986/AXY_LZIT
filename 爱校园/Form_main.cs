using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.Threading.Tasks;
using System.Diagnostics;
using System.Text.RegularExpressions;
using System.Runtime.InteropServices;
using System.IO;
using System.Threading;
using System.Net.NetworkInformation;

namespace 爱校园
{
    public partial class Form_main : Form
    {
        [DllImport("user32")]
        private static extern bool HideCaret(IntPtr hWnd);
        public void HideCaret() { }//调用系统API，隐藏闪烁指针


        [DllImport("user32.dll", SetLastError = true)]
        static extern IntPtr FindWindow(string lpClassName, string lpWindowName);//查找对话框

        [DllImport("user32.dll")]
        static extern bool EndDialog(IntPtr hDlg, out IntPtr nResult);//关闭对话框



        public Form_main()
        {
            InitializeComponent();
        }

        private void start_load(object sender, EventArgs e)
        {
            label_auth_sms.Text = "";
            radioButton_login_pwd.Checked = Settings1.Default.login_type_PWD;
            radioButton_login_sms.Checked = Settings1.Default.login_type_SMS;
            checkBox_save_account.Checked = Settings1.Default.bczh;
            textBox_account.Text = Settings1.Default.user_name;
            acheckBox_save_pwd.Checked = Settings1.Default.bcmm;
            textBox_pwd.Text = Settings1.Default.password;
        }

        private void button_exit_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void button_login_Click(object sender, EventArgs e)
        {
            System.Diagnostics.Process cmd = new System.Diagnostics.Process();
            cmd.StartInfo.FileName = "cmd.exe";
            cmd.StartInfo.UseShellExecute = false;//是否使用系统shell启动
            cmd.StartInfo.RedirectStandardInput = true;//接受来自调用程序的输入信息
            cmd.StartInfo.RedirectStandardOutput = true;//允许调用程序获取输出信息
            cmd.StartInfo.RedirectStandardError = true;//重定向标准错误输出
            cmd.StartInfo.CreateNoWindow = true;//是否隐藏程序窗口
            cmd.Start();//启动程序

            string ip = textBox_ip.Text;//目标IP地址
            string user = textBox_account.Text;//账号
            string password = textBox_pwd.Text;//密码
            string sms_code = textBox_pwd.Text;//短信验证码
            string token_id = label_auth_sms.Text;//token_id
            string code_curl = "curl -d \"req=";//命令字符串
            string code_user_name = "%7B%22user_name%22%3A%22";//用户名前字符
            string code_username_sms = "%22%2C%22user_name%22%3A%22";//短信登录用户名
            string code_ip_sms = "%7B%22user_ip%22%3A%22";//短信登录ip前缀
            string code_password = "%22%2C%22password%22%3A%22";//密码前字符
            string code_token_id = "%22%2C%22token_id%22%3A%22";//tokenid,可不填
            string token_id_end = "%3D%3D";//token_id后==
            string code_user_ip = "%22%2C%22user_ip%22%3A%22";//user_ip前缀
            string code_bas_name = "%22%2C%22bas_name%22%3A%22LZ-QLH-YJQ-BAS-1.MAN.ME60-X16";//运营商信息，可不填
            string code_bas_name_end = "%22%7D\" ";//短信登录用户名后缀
            string code_school_name = "%22%2C%22school_name%22%3A%22%E5%85%B0%E5%B7%9E%E5%B7%A5%E4%B8%9A%E5%AD%A6%E9%99%A2";//学校名称,可不填
            string code_client_type = "%22%2C%22client_type%22%3A%22" + "PC";//设备类型
            string code_device_name = "%22%2C%22device_name%22%3A%22" + "SBischool";//设备名
            string code_client_version = "%22%2C%22client_version%22%3A%22";//客户端版本
            string client_version = "9.9.9%22%7D\" ";//客户端版本
            string client_version_sms = "9.9.9";
            string server_ip = " " + "http://61.178.5.73/rasPortal/userAuth.do";//认证服务器地址


            if (textBox_pwd.Text == "")//未输入密码时自动使用默认密码
            {
                password = "lz123456";
            }

            //密码登录
            StringBuilder mm = new StringBuilder();
            mm.Append(code_curl);
            mm.Append(code_user_name);
            mm.Append(user);
            mm.Append(code_password);
            mm.Append(password);
            mm.Append(code_token_id);
            mm.Append(code_user_ip);
            mm.Append(ip);
            mm.Append(code_bas_name);
            mm.Append(code_client_type);
            mm.Append(code_device_name);
            mm.Append(code_client_version);
            mm.Append(client_version);
            mm.Append(server_ip);
            string mm_result = mm.ToString();

            //短信验证码登录
            StringBuilder sms = new StringBuilder();
            sms.Append(code_curl);
            sms.Append(code_ip_sms);
            sms.Append(ip);
            sms.Append(code_password);
            sms.Append(sms_code);
            sms.Append(code_device_name);
            sms.Append(code_token_id);
            sms.Append(token_id);
            sms.Append(token_id_end);
            sms.Append(code_username_sms);
            sms.Append(user);
            sms.Append(code_school_name);
            sms.Append(code_client_type);
            sms.Append(code_client_version);
            sms.Append(client_version_sms);
            sms.Append(code_bas_name);
            sms.Append(code_bas_name_end);
            sms.Append(server_ip);




            if (radioButton_login_pwd.Checked == true)//使用密码登录
            {
                if (textBox_ip.Text == "" || textBox_account.Text == "")
                {
                    MessageBox.Show("请输入正确信息");

                }
                cmd.StandardInput.WriteLine(mm_result + "&exit");//向CMD发送指令
                cmd.StandardInput.AutoFlush = true;//提交
                string output = cmd.StandardOutput.ReadToEnd();//获取CMD窗口输出信息
                StreamReader output_stream = cmd.StandardOutput;
                string utf_output = Encoding.UTF8.GetString(Encoding.Default.GetBytes(output));//将获取到的字符转码
                Regex rex = new Regex(@"\{(.*)\}");//正则取返回结果
                Match result = rex.Match(utf_output);//取值后赋值
                richTextBox_status_info.Text = result.ToString();

                string session_id = result.ToString();
                string[] xx = session_id.Split('\"');
                if (xx[11] == "成功�?}")
                {

                    label_session_id_success.Text = xx[3];
                    label_success_ip.Text = ip;
                    Settings1.Default.last_success_ip = ip;
                    Settings1.Default.last_success_session_id = xx[3];
                    Settings1.Default.Save();
                }

                cmd.WaitForExit();//等待程序退出
                cmd.Close();//程序结束后退出

                richTextBox_authinfo.Text = "";
            }
            if (radioButton_login_sms.Checked == true)//短信验证码登录
            {
                if (textBox_pwd.Text == "")
                {
                    MessageBox.Show("请输入短信验证码！", "警告",
                      System.Windows.Forms.MessageBoxButtons.OK,
                     System.Windows.Forms.MessageBoxIcon.Warning);
                }
                else
                {
                    if (label_auth_sms.Text == "")
                    {
                        MessageBox.Show("请先确认已经成功获取了验证码!");
                    }
                    cmd.StandardInput.WriteLine(sms.ToString() + "&exit");//向CMD发送指令
                    cmd.StandardInput.AutoFlush = true;//提交
                    string output = cmd.StandardOutput.ReadToEnd();//获取CMD窗口输出信息
                    StreamReader output_stream = cmd.StandardOutput;
                    string utf_output = Encoding.UTF8.GetString(Encoding.Default.GetBytes(output));//将获取到的字符转码
                    Regex rex = new Regex(@"\{(.*)\}");//正则取返回结果
                    Match result = rex.Match(utf_output);//取值后赋值
                    richTextBox_status_info.Text = result.ToString();


                    string session_id = result.ToString();
                    string[] xx = session_id.Split('\"');
                    if (xx[11] == "成功�?}")
                    {

                        label_session_id_success.Text = xx[3];
                        label_success_ip.Text = ip;
                        Settings1.Default.last_success_ip = ip;
                        Settings1.Default.last_success_session_id = xx[3];
                        Settings1.Default.Save();
                    }
                    //string session_result = xx[3];
                    //textBox4.Text = session_result;


                    cmd.WaitForExit();//等待程序退出
                    cmd.Close();//程序结束后退出

                    //richTextBox1.Text = sms_result;
                }
            }
        }

        private void button_get_ip_Click(object sender, EventArgs e)
        {
            //获取IP地址
            string result = ("route");
            Match m = Regex.Match(result, @"0.0.0.0\s+0.0.0.0\s+(\d+.\d+.\d+.\d+)\s+(\d+.\d+.\d+.\d+)");
            if (m.Success)
            {
                richTextBox_authinfo.Text = m.Groups[2].Value;
            }
            else
            {
                try
                {
                    System.Net.Sockets.TcpClient c = new System.Net.Sockets.TcpClient();
                    c.Connect("www.baidu.com", 80);
                    string ip = ((System.Net.IPEndPoint)c.Client.LocalEndPoint).Address.ToString();
                    c.Close();
                    textBox_ip.Text = ip;
                }
                catch (Exception)
                {
                    textBox_ip.Text = "请检查网络连接";
                }
            }
        }

        private void button_reset_template_Click(object sender, EventArgs e)
        {
            string ip = textBox_ip.Text;//目标IP地址
            string user = textBox_account.Text;//账号
            string password = textBox_pwd.Text;//密码
            string code_user_ip = "%7B%22user_name%22%3A%22";//用户名前字符
            string code_session_ip = "%22%2C%22password%22%3A%22";//密码前字符
            string code_quit_type = "%22%2C%22token_id%22%3A%22";//tokenid,可不填
            string fifth = "%22%2C%22user_ip%22%3A%22";//user_ip前缀
            string sixth = "%22%2C%22bas_name%22%3A%22LZ-QLH-YJQ-BAS-1.MAN.ME60-X16";//运营商信息，可不填
            //string seventh = "%22%2C%22school_name%22%3A%22";//学校名称,可不填
            string eighth = "%22%2C%22client_type%22%3A%22" + "PC";//设备类型
            string ninth = "%22%2C%22device_name%22%3A%22" + "SBischool";//设备名
            string tenth = "%22%2C%22client_version%22%3A%22";//客户端版本
            string client_version = "9.9.9%22%7D";//客户端版本


            //拼接多个参数
            StringBuilder mb = new StringBuilder();
            mb.Append(code_user_ip);
            //mb.Append("账号");
            mb.Append(code_session_ip);
            //mb.Append("密码");
            mb.Append(code_quit_type);
            mb.Append(fifth);
            //mb.Append("设备IP");
            mb.Append(sixth);
            mb.Append(eighth);
            mb.Append(ninth);
            mb.Append(tenth);
            mb.Append(client_version);
            richTextBox_authinfo.Text = System.Web.HttpUtility.UrlDecode(mb.ToString());
        }

        private void button_send_authinfo_Click(object sender, EventArgs e)
        {
            //确认是否发送自定义认证信息
            MessageBox.Show("确定发送自定义认证信息？（如果信息填写有误，程序将会一段时间无法响应）", "提示",
            System.Windows.Forms.MessageBoxButtons.OK,
            System.Windows.Forms.MessageBoxIcon.Warning);
            System.Diagnostics.Process cmd = new System.Diagnostics.Process();
            cmd.StartInfo.FileName = "cmd.exe";
            cmd.StartInfo.UseShellExecute = false;//是否使用系统shell启动
            cmd.StartInfo.RedirectStandardInput = true;//接受来自调用程序的输入信息
            cmd.StartInfo.RedirectStandardOutput = true;//允许调用程序获取输出信息
            cmd.StartInfo.RedirectStandardError = true;//重定向标准错误输出
            cmd.StartInfo.CreateNoWindow = true;//是否隐藏程序窗口
            cmd.Start();//启动程序
            if (richTextBox_authinfo.Text == "")
            {
                MessageBox.Show("请不要提交空信息！");
                cmd.Close();
            }
            else
            {
                string code_result = System.Web.HttpUtility.UrlEncode(richTextBox_authinfo.Text);
                cmd.StandardInput.WriteLine("curl -d \"req=" + code_result + "\"+" + " " + "http://61.178.5.73/rasPortal/userAuth.do" + "&exit");//向CMD发送指令
                cmd.StandardInput.AutoFlush = true;//提交

                string output = cmd.StandardOutput.ReadToEnd();//获取CMD窗口输出信息
                string utf_output = Encoding.UTF8.GetString(Encoding.Default.GetBytes(output));//转码输出信息
                Regex rex = new Regex(@"\{(.*)\}");
                Match result = rex.Match(utf_output);
                richTextBox_status_info.Text = result.ToString();

                cmd.WaitForExit();//等待程序退出
                cmd.Close();//程序结束后退出
            }

        }

        private void button_tip_Click(object sender, EventArgs e)
        {
            new Form_tip().ShowDialog();
        }

        private void button_send_cmd_Click(object sender, EventArgs e)
        {
            MessageBox.Show("确定发送自定义CMD命令？（如果输入的是持续性命令，程序需要命令完成后才能显示结果，推荐使用系统自带的cmd）", "提示",
            System.Windows.Forms.MessageBoxButtons.OK,
            System.Windows.Forms.MessageBoxIcon.Warning);
            System.Diagnostics.Process cmd = new System.Diagnostics.Process();
            cmd.StartInfo.FileName = "cmd.exe";
            cmd.StartInfo.UseShellExecute = false;//是否使用系统shell启动
            cmd.StartInfo.RedirectStandardInput = true;//接受来自调用程序的输入信息
            cmd.StartInfo.RedirectStandardOutput = true;//允许调用程序获取输出信息
            cmd.StartInfo.RedirectStandardError = true;//重定向标准错误输出
            cmd.StartInfo.CreateNoWindow = true;//是否隐藏程序窗口
            cmd.Start();//启动程序
            if (richTextBox_authinfo.Text == "")
            {
                MessageBox.Show("请不要提交空命令！");
                cmd.Close();
            }
            else
            {

                cmd.StandardInput.WriteLine(richTextBox_authinfo.Text + "&exit");//向CMD发送指令
                cmd.StandardInput.AutoFlush = true;//提交

                string output = cmd.StandardOutput.ReadToEnd();//获取CMD窗口输出信息
                richTextBox_status_info.Text = output;

                cmd.WaitForExit();//等待程序退出
                cmd.Close();//程序结束后退出

            }
        }

        private void 退出ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Dispose();
            Application.Exit();
        }

        private void ToolStripMenuItem_show_window_Click(object sender, EventArgs e)
        {
            this.Show();                                //窗口显示
            this.WindowState = FormWindowState.Normal;  //窗口状态默认大小
            this.Activate();                            //激活窗口给予焦点
        }

        private void Form1_FormClosing(object sender, FormClosingEventArgs e)
        {
            if (checkBox_save_account.Checked == true)
            {
                Settings1.Default.user_name = textBox_account.Text;
                Settings1.Default.bczh = checkBox_save_account.Checked;
                Settings1.Default.Save();
            }
            if (checkBox_save_account.Checked == false)
            {
                Settings1.Default.user_name = "";
                Settings1.Default.bczh = false;
                Settings1.Default.Save();
            }
            if (acheckBox_save_pwd.Checked == true)
            {
                Settings1.Default.password = textBox_pwd.Text;
                Settings1.Default.bcmm = acheckBox_save_pwd.Checked;
                Settings1.Default.Save();
            }
            if (acheckBox_save_pwd.Checked == false)
            {
                Settings1.Default.password = "";
                Settings1.Default.bcmm = false;
                Settings1.Default.Save();
            }
            if (radioButton_login_pwd.Checked == true)
            {
                Settings1.Default.login_type_PWD = true;
                Settings1.Default.login_type_SMS = false;
                Settings1.Default.Save();
            }
            if (radioButton_login_sms.Checked == true)
            {
                Settings1.Default.login_type_SMS = true;
                Settings1.Default.login_type_PWD = false;
                Settings1.Default.Save();
            }
            this.Dispose();                //释放资源
            Application.Exit();

        }
        private void ToolStripMenuItem_hide_window_Click(object sender, EventArgs e)
        {
            this.Hide();                      //隐藏窗口
        }

        private void notifyIcon1_MouseDoubleClick(object sender, MouseEventArgs e)
        {
            //点击鼠标"左键"调出程序
            if (e.Button == MouseButtons.Left)
            {
                this.Visible = true;                        //窗体可见
                this.WindowState = FormWindowState.Normal;  //窗体默认大小
                this.notifyIcon.Visible = true;            //设置图标可见
            }

        }

        private void Form1_SizeChanged(object sender, EventArgs e)
        {
            if (this.WindowState == FormWindowState.Minimized)
            {
                this.Hide();
                this.notifyIcon.Visible = true;
            }
        }

        private void button_offline_thisid_Click(object sender, EventArgs e)
        {
            System.Diagnostics.Process cmd = new System.Diagnostics.Process();
            cmd.StartInfo.FileName = "cmd.exe";
            cmd.StartInfo.UseShellExecute = false;//是否使用系统shell启动
            cmd.StartInfo.RedirectStandardInput = true;//接受来自调用程序的输入信息
            cmd.StartInfo.RedirectStandardOutput = true;//允许调用程序获取输出信息
            cmd.StartInfo.RedirectStandardError = true;//重定向标准错误输出
            cmd.StartInfo.CreateNoWindow = true;//是否隐藏程序窗口
            cmd.Start();//启动程序
            if (textBox_session_id.Text == "")
            {
                MessageBox.Show("请输入session_id!");
                cmd.Close();
            }
            else
            {
                string session_id = textBox_session_id.Text;
                string user_ip = textBox_ip.Text;
                string code_curl = "curl -d \"req=";//命令字符串
                string code_user_ip = "%7B%22user_ip%22%3A%22";//user_ip前缀
                string code_session_ip = "%22%2C%22session_id%22%3A%22";//session_id前缀
                string code_quit_type = "%22%2C%22quit_type%22%3A%22" + "0" + "%22%7D\"";//quit_type:0
                string server_ip = " " + "http://61.178.5.73/rasPortal/quit.do";//认证服务器地址

                StringBuilder pj = new StringBuilder();
                pj.Append(code_curl);
                pj.Append(code_user_ip);
                pj.Append(user_ip);
                pj.Append(code_session_ip);
                pj.Append(session_id);
                pj.Append(code_quit_type);
                pj.Append(server_ip);

                richTextBox_authinfo.Text = textBox_session_id.Text;

                cmd.StandardInput.WriteLine(pj.ToString() + "&exit");//向CMD发送指令
                cmd.StandardInput.AutoFlush = true;//提交
                string output = cmd.StandardOutput.ReadToEnd();//获取CMD窗口输出信息
                string utf_output = Encoding.UTF8.GetString(Encoding.Default.GetBytes(output));//转码输出信息
                Regex rex = new Regex(@"\{(.*)\}");//正则取返回值
                Match result = rex.Match(utf_output);//赋值
                richTextBox_status_info.Text = result.ToString();
                richTextBox_authinfo.Text = "已向服务器发送下线session_id为" + textBox_session_id.Text + "，" + "IP地址为" + user_ip + "的设备的命令，请查看状态栏信息";

                cmd.WaitForExit();//等待程序退出
                cmd.Close();//程序结束后退出
            }
        }

        private void button_offline_Click(object sender, EventArgs e)
        {
            System.Diagnostics.Process cmd = new System.Diagnostics.Process();
            cmd.StartInfo.FileName = "cmd.exe";
            cmd.StartInfo.UseShellExecute = false;//是否使用系统shell启动
            cmd.StartInfo.RedirectStandardInput = true;//接受来自调用程序的输入信息
            cmd.StartInfo.RedirectStandardOutput = true;//允许调用程序获取输出信息
            cmd.StartInfo.RedirectStandardError = true;//重定向标准错误输出
            cmd.StartInfo.CreateNoWindow = true;//是否隐藏程序窗口
            cmd.Start();//启动程序
            if (label_session_id_success.Text == "")
            {
                MessageBox.Show("请先使用本程序成功登录获取ID！", "警告");
                cmd.Close();
            }
            else
            {
                string session_id = label_session_id_success.Text;
                string user_ip = textBox_ip.Text;
                string code_curl = "curl -d \"req=";//命令字符串
                string code_user_ip = "%7B%22user_ip%22%3A%22";//user_ip前缀
                string code_session_ip = "%22%2C%22session_id%22%3A%22";//session_id前缀
                string code_quit_type = "%22%2C%22quit_type%22%3A%22" + "0" + "%22%7D\"";//quit_type:0
                string server_ip = " " + "http://61.178.5.73/rasPortal/quit.do";//认证服务器地址

                StringBuilder pj = new StringBuilder();
                pj.Append(code_curl);
                pj.Append(code_user_ip);
                pj.Append(user_ip);
                pj.Append(code_session_ip);
                pj.Append(session_id);
                pj.Append(code_quit_type);
                pj.Append(server_ip);


                cmd.StandardInput.WriteLine(pj.ToString() + "&exit");//向CMD发送指令
                cmd.StandardInput.AutoFlush = true;//提交
                string output = cmd.StandardOutput.ReadToEnd();//获取CMD窗口输出信息
                string utf_output = Encoding.UTF8.GetString(Encoding.Default.GetBytes(output));//转码输出信息
                Regex rex = new Regex(@"\{(.*)\}");//正则取返回值
                Match result = rex.Match(utf_output);//赋值
                richTextBox_status_info.Text = result.ToString();
                richTextBox_authinfo.Text = "已向服务器发送下线session_id为" + label_session_id_success.Text + "，" + "IP地址为" + label_success_ip.Text + "的设备的命令，请查看状态栏信息";

                cmd.WaitForExit();//等待程序退出
                cmd.Close();//程序结束后退出
            }
        }

        private void button_rich2_clear_Click(object sender, EventArgs e)
        {
            richTextBox_status_info.Text = "";
        }

        private void button_rich1_clear_Click(object sender, EventArgs e)
        {
            richTextBox_authinfo.Text = "";
        }

        private void richTextBox2_MouseDown(object sender, MouseEventArgs e)
        {
            HideCaret(richTextBox_status_info.Handle);
        }

        private void button_load_last_success_id_Click(object sender, EventArgs e)
        {
            label_session_id_success.Text = Settings1.Default.last_success_session_id;
            label_success_ip.Text = Settings1.Default.last_success_ip;
        }


        internal CloseState state { get; set; }

        public WaitCallback CloseMessageBox { get; set; }

        private void radioButton1_CheckedChanged(object sender, EventArgs e)
        {
            label_pwd.Text = "密码:";
            button_get_sms_code.Visible = false;
        }

        private void radioButton2_CheckedChanged(object sender, EventArgs e)
        {
            button_get_sms_code.Visible = true;
            label_pwd.Text = "短信验证码：";
        }

        private void linkLabel1_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            System.Diagnostics.Process.Start("http://sighttp.qq.com/authd?IDKEY=9d06d24f0892f56c126090934e8f9e2dcca11d8748c040fa");
        }

        private void button_get_sms_code_Click(object sender, EventArgs e)
        {
            if (textBox_account.Text == "")
            {
                MessageBox.Show("请输入正确的手机号！");
            }
            else
            {
                DialogResult result = MessageBox.Show("确认获取短信验证码吗", "提示",
                            System.Windows.Forms.MessageBoxButtons.OKCancel);
                if (result == DialogResult.OK)
                {
                    System.Diagnostics.Process cmd = new System.Diagnostics.Process();
                    cmd.StartInfo.FileName = "cmd.exe";
                    cmd.StartInfo.UseShellExecute = false;//是否使用系统shell启动
                    cmd.StartInfo.RedirectStandardInput = true;//接受来自调用程序的输入信息
                    cmd.StartInfo.RedirectStandardOutput = true;//允许调用程序获取输出信息
                    cmd.StartInfo.RedirectStandardError = true;//重定向标准错误输出
                    cmd.StartInfo.CreateNoWindow = true;//是否隐藏程序窗口
                    cmd.Start();//启动程序

                    string user = textBox_account.Text;
                    string code_req = "curl -d \"req=";//命令字符串
                    string code_mobile = "%7B%22mobile%22%3A%22";//手机号前缀
                    string code_mobile_end = "%22%7D\"";
                    string server_ip = " " + "http://61.178.5.73/rasPortal/getSms.do";//短信服务器地址

                    StringBuilder getsms = new StringBuilder();
                    getsms.Append(code_req);
                    getsms.Append(code_mobile);
                    getsms.Append(user);
                    getsms.Append(code_mobile_end);
                    getsms.Append(server_ip);

                    cmd.StandardInput.WriteLine(getsms.ToString() + "&exit");//向CMD发送指令
                    cmd.StandardInput.AutoFlush = true;//提交
                    string output = cmd.StandardOutput.ReadToEnd();//获取CMD窗口输出信息
                    string utf_output = Encoding.UTF8.GetString(Encoding.Default.GetBytes(output));//转码输出信息
                    Regex rex = new Regex(@"\{(.*)\}");//正则取返回值
                    Match sms_response = rex.Match(utf_output);//赋值

                    richTextBox_status_info2.Text = sms_response.ToString();
                    string token_response = sms_response.ToString();
                    string[] xx = token_response.Split('\"');
                    if (xx[15] == "短信密码下发成功�?}")
                    {
                        string token_id = xx[11];
                        string token_id_result = token_id.Substring(0, token_id.Length - 2);
                        label_auth_sms.Text = System.Web.HttpUtility.UrlEncode(token_id_result, System.Text.Encoding.GetEncoding("utf-8"));//token_idURL转码
                    }

                    cmd.WaitForExit();//等待程序退出
                    cmd.Close();//程序结束后退出

                }
            }

        }

        private void richTextBox3_MouseDown(object sender, MouseEventArgs e)
        {
            HideCaret(richTextBox_status_info2.Handle);
        }

        private void button_inquire_school_Click(object sender, EventArgs e)
        {
            if (textBox_account.Text == "" || textBox_account.Text.Length < 11)
            {
                MessageBox.Show("请输入正确的手机号！");
            }
            System.Diagnostics.Process cmd = new System.Diagnostics.Process();
            cmd.StartInfo.FileName = "cmd.exe";
            cmd.StartInfo.UseShellExecute = false;//是否使用系统shell启动
            cmd.StartInfo.RedirectStandardInput = true;//接受来自调用程序的输入信息
            cmd.StartInfo.RedirectStandardOutput = true;//允许调用程序获取输出信息
            cmd.StartInfo.RedirectStandardError = true;//重定向标准错误输出
            cmd.StartInfo.CreateNoWindow = true;//是否隐藏程序窗口
            cmd.Start();//启动程序

            string user = textBox_account.Text;
            string code_start = "curl -d \"req=";//命令字符串
            string code_mobile = "%7B%22user_name%22%3A%22";//手机号前缀
            string code_mobile_end = "%22%7D\"";
            string server_ip = " " + "http://61.178.5.73/rasPortal/getUserSchool.do";//查询服务器地址

            StringBuilder getschool = new StringBuilder();
            getschool.Append(code_start);
            getschool.Append(code_mobile);
            getschool.Append(user);
            getschool.Append(code_mobile_end);
            getschool.Append(server_ip);

            cmd.StandardInput.WriteLine(getschool.ToString() + "&exit");//向CMD发送指令
            cmd.StandardInput.AutoFlush = true;//提交
            string output = cmd.StandardOutput.ReadToEnd();//获取CMD窗口输出信息
            string utf_output = Encoding.UTF8.GetString(Encoding.Default.GetBytes(output));//转码输出信息
            Regex rex = new Regex(@"\{(.*)\}");//正则取返回值
            Match getschool_result = rex.Match(utf_output);//赋值
            richTextBox_status_info2.Text = getschool_result.ToString();




        }

        private void button_rich3_clear_Click(object sender, EventArgs e)
        {
            richTextBox_status_info2.Text = "";
        }

        private void button_checkonline_Click(object sender, EventArgs e)
        {
            if (label_session_id_success.Text == "")
            { MessageBox.Show("请先加载上次成功登陆的ID", "提示", System.Windows.Forms.MessageBoxButtons.OK); }
            else
            {
                System.Diagnostics.Process cmd = new System.Diagnostics.Process();
                cmd.StartInfo.FileName = "cmd.exe";
                cmd.StartInfo.UseShellExecute = false;//是否使用系统shell启动
                cmd.StartInfo.RedirectStandardInput = true;//接受来自调用程序的输入信息
                cmd.StartInfo.RedirectStandardOutput = true;//允许调用程序获取输出信息
                cmd.StartInfo.RedirectStandardError = true;//重定向标准错误输出
                cmd.StartInfo.CreateNoWindow = true;//是否隐藏程序窗口
                cmd.Start();//启动程序

                string code_start = "curl -d \"req=";//命令字符串
                string code_session_id_start = "%7B%22session_id%22%3A%22";
                string session_id = label_session_id_success.Text;//session_id
                string session_id_end = "%22%7D\"";
                string server_ip = " " + "http://61.178.5.73/rasPortal/check.do";//查询服务器地址

                StringBuilder id = new StringBuilder();
                id.Append(code_start);
                id.Append(code_session_id_start);
                id.Append(session_id);
                id.Append(session_id_end);
                id.Append(server_ip);

                richTextBox_status_info.Text = "已向服务器查询session_id为" + label_session_id_success.Text + "的设备是否下线，具体请看下方返回信息";
                cmd.StandardInput.WriteLine(id.ToString() + "&exit");//向CMD发送命令
                cmd.StandardInput.AutoFlush = true;//提交
                string output = cmd.StandardOutput.ReadToEnd();//获取CMD窗口输出信息
                string utf_output = Encoding.UTF8.GetString(Encoding.Default.GetBytes(output));//转码输出信息
                Regex rex = new Regex(@"\{(.*)\}");//正则取返回值
                Match check_result = rex.Match(utf_output);//赋值
                richTextBox_status_info2.Text = check_result.ToString();

                cmd.WaitForExit();//等待程序退出
                cmd.Close();//程序结束后退出
            }
        }

        private void richTextBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void button_clear_cache_Click(object sender, EventArgs e)
        {
            textBox_ip.Text = "";
            textBox_account.Text = "";
            textBox_pwd.Text = "";
            Settings1.Default.last_success_ip = "";
            Settings1.Default.last_success_session_id = "";
            Settings1.Default.user_name = "";
            Settings1.Default.password = "";
            richTextBox_authinfo.Text = "";
            richTextBox_status_info.Text = "";
            richTextBox_status_info2.Text = "";
        }

        private void button_reset_auth_status_Click(object sender, EventArgs e)
        {
            MessageBox.Show("确认要清除认证信息吗？下次打开软件时将要求验证", "警告", System.Windows.Forms.MessageBoxButtons.OKCancel);
            Settings1.Default.IDcheck = false;
            Settings1.Default.Save();
            MessageBox.Show("认证信息已清除！", "提示", System.Windows.Forms.MessageBoxButtons.OK);
        }

        private void button_test_Click(object sender, EventArgs e)
        {

            string url = "61.178.5.73";
            Ping ping = new Ping();
            try
            {
                PingReply reply = ping.Send(url);
                if (reply.Status == IPStatus.Success)
                {
                    MessageBox.Show("连接正常，可以进行登录了!", "提示", System.Windows.Forms.MessageBoxButtons.OK);
                    this.button_send_authinfo.Enabled = true;
                }
                if (reply.Status == IPStatus.TimedOut)
                {
                    MessageBox.Show("连接异常！可能无法正常登录！", "提示", System.Windows.Forms.MessageBoxButtons.OK);
                    this.button_send_authinfo.Enabled = false;

                }
            }
            catch (Exception ex)
            {
                string exceptions = ex.Message.ToString();

                throw new ApplicationException(exceptions);

            }
        }

    }
}