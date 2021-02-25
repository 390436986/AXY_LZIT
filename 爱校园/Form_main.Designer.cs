namespace 爱校园
{
    partial class Form_main
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
        /// 设计器支持所需的方法 - 不要
        /// 使用代码编辑器修改此方法的内容。
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form_main));
            this.button_login = new System.Windows.Forms.Button();
            this.button_exit = new System.Windows.Forms.Button();
            this.label_destination_ip = new System.Windows.Forms.Label();
            this.label_account = new System.Windows.Forms.Label();
            this.label_pwd = new System.Windows.Forms.Label();
            this.textBox_ip = new System.Windows.Forms.TextBox();
            this.textBox_account = new System.Windows.Forms.TextBox();
            this.textBox_pwd = new System.Windows.Forms.TextBox();
            this.richTextBox_authinfo = new System.Windows.Forms.RichTextBox();
            this.button_send_authinfo = new System.Windows.Forms.Button();
            this.label_status = new System.Windows.Forms.Label();
            this.richTextBox_status_info = new System.Windows.Forms.RichTextBox();
            this.button_get_ip = new System.Windows.Forms.Button();
            this.button_reset_template = new System.Windows.Forms.Button();
            this.label_tip = new System.Windows.Forms.Label();
            this.button_tip = new System.Windows.Forms.Button();
            this.button_send_cmd = new System.Windows.Forms.Button();
            this.notifyIcon = new System.Windows.Forms.NotifyIcon(this.components);
            this.contextMenuStrip1 = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.ToolStripMenuItem_show_window = new System.Windows.Forms.ToolStripMenuItem();
            this.ToolStripMenuItem_hide_window = new System.Windows.Forms.ToolStripMenuItem();
            this.ToolStripMenuItem_Exit = new System.Windows.Forms.ToolStripMenuItem();
            this.textBox_session_id = new System.Windows.Forms.TextBox();
            this.label_session_id = new System.Windows.Forms.Label();
            this.button_offline_thisid = new System.Windows.Forms.Button();
            this.label_last_session_id = new System.Windows.Forms.Label();
            this.label_session_id_success = new System.Windows.Forms.Label();
            this.button_offline = new System.Windows.Forms.Button();
            this.button_rich2_clear = new System.Windows.Forms.Button();
            this.label_last_ip = new System.Windows.Forms.Label();
            this.label_success_ip = new System.Windows.Forms.Label();
            this.button_rich1_clear = new System.Windows.Forms.Button();
            this.checkBox_save_account = new System.Windows.Forms.CheckBox();
            this.button_load_last_success_id = new System.Windows.Forms.Button();
            this.radioButton_login_pwd = new System.Windows.Forms.RadioButton();
            this.radioButton_login_sms = new System.Windows.Forms.RadioButton();
            this.linkLabel_contact = new System.Windows.Forms.LinkLabel();
            this.button_get_sms_code = new System.Windows.Forms.Button();
            this.richTextBox_status_info2 = new System.Windows.Forms.RichTextBox();
            this.label_auth_sms = new System.Windows.Forms.Label();
            this.button_inquire_school = new System.Windows.Forms.Button();
            this.button_rich3_clear = new System.Windows.Forms.Button();
            this.button_check_lastid_online = new System.Windows.Forms.Button();
            this.button_clear_cache = new System.Windows.Forms.Button();
            this.acheckBox_save_pwd = new System.Windows.Forms.CheckBox();
            this.button_reset_auth_status = new System.Windows.Forms.Button();
            this.button_connect_test = new System.Windows.Forms.Button();
            this.button_checkidonline = new System.Windows.Forms.Button();
            this.contextMenuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // button_login
            // 
            this.button_login.Location = new System.Drawing.Point(12, 440);
            this.button_login.Name = "button_login";
            this.button_login.Size = new System.Drawing.Size(85, 46);
            this.button_login.TabIndex = 0;
            this.button_login.Text = "登录";
            this.button_login.UseVisualStyleBackColor = true;
            this.button_login.Click += new System.EventHandler(this.button_login_Click);
            // 
            // button_exit
            // 
            this.button_exit.Location = new System.Drawing.Point(173, 440);
            this.button_exit.Name = "button_exit";
            this.button_exit.Size = new System.Drawing.Size(85, 46);
            this.button_exit.TabIndex = 1;
            this.button_exit.Text = "退出";
            this.button_exit.UseVisualStyleBackColor = true;
            this.button_exit.Click += new System.EventHandler(this.button_exit_Click);
            // 
            // label_destination_ip
            // 
            this.label_destination_ip.AutoSize = true;
            this.label_destination_ip.Font = new System.Drawing.Font("微软雅黑", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.label_destination_ip.Location = new System.Drawing.Point(13, 217);
            this.label_destination_ip.Name = "label_destination_ip";
            this.label_destination_ip.Size = new System.Drawing.Size(58, 22);
            this.label_destination_ip.TabIndex = 2;
            this.label_destination_ip.Text = "目标IP";
            // 
            // label_account
            // 
            this.label_account.AutoSize = true;
            this.label_account.Font = new System.Drawing.Font("微软雅黑", 12F, System.Drawing.FontStyle.Bold);
            this.label_account.Location = new System.Drawing.Point(14, 277);
            this.label_account.Name = "label_account";
            this.label_account.Size = new System.Drawing.Size(42, 22);
            this.label_account.TabIndex = 3;
            this.label_account.Text = "账号";
            // 
            // label_pwd
            // 
            this.label_pwd.AutoSize = true;
            this.label_pwd.Font = new System.Drawing.Font("微软雅黑", 12F, System.Drawing.FontStyle.Bold);
            this.label_pwd.Location = new System.Drawing.Point(12, 326);
            this.label_pwd.Name = "label_pwd";
            this.label_pwd.Size = new System.Drawing.Size(47, 22);
            this.label_pwd.TabIndex = 4;
            this.label_pwd.Text = "密码:";
            // 
            // textBox_ip
            // 
            this.textBox_ip.Location = new System.Drawing.Point(113, 221);
            this.textBox_ip.Name = "textBox_ip";
            this.textBox_ip.Size = new System.Drawing.Size(145, 21);
            this.textBox_ip.TabIndex = 5;
            // 
            // textBox_account
            // 
            this.textBox_account.Location = new System.Drawing.Point(113, 277);
            this.textBox_account.Name = "textBox_account";
            this.textBox_account.Size = new System.Drawing.Size(145, 21);
            this.textBox_account.TabIndex = 6;
            // 
            // textBox_pwd
            // 
            this.textBox_pwd.Location = new System.Drawing.Point(113, 326);
            this.textBox_pwd.Name = "textBox_pwd";
            this.textBox_pwd.PasswordChar = '*';
            this.textBox_pwd.Size = new System.Drawing.Size(145, 21);
            this.textBox_pwd.TabIndex = 7;
            // 
            // richTextBox_authinfo
            // 
            this.richTextBox_authinfo.BackColor = System.Drawing.Color.MintCream;
            this.richTextBox_authinfo.Font = new System.Drawing.Font("微软雅黑", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.richTextBox_authinfo.Location = new System.Drawing.Point(12, 41);
            this.richTextBox_authinfo.Name = "richTextBox_authinfo";
            this.richTextBox_authinfo.Size = new System.Drawing.Size(834, 137);
            this.richTextBox_authinfo.TabIndex = 8;
            this.richTextBox_authinfo.Text = "";
            this.richTextBox_authinfo.TextChanged += new System.EventHandler(this.richTextBox1_TextChanged);
            // 
            // button_send_authinfo
            // 
            this.button_send_authinfo.Enabled = false;
            this.button_send_authinfo.Location = new System.Drawing.Point(532, 184);
            this.button_send_authinfo.Name = "button_send_authinfo";
            this.button_send_authinfo.Size = new System.Drawing.Size(179, 46);
            this.button_send_authinfo.TabIndex = 9;
            this.button_send_authinfo.Text = "发送认证消息\r\n（仅连通性测试成功时可用）";
            this.button_send_authinfo.UseVisualStyleBackColor = true;
            this.button_send_authinfo.Click += new System.EventHandler(this.button_send_authinfo_Click);
            // 
            // label_status
            // 
            this.label_status.AutoSize = true;
            this.label_status.Font = new System.Drawing.Font("微软雅黑", 10F, System.Drawing.FontStyle.Bold);
            this.label_status.Location = new System.Drawing.Point(286, 217);
            this.label_status.Name = "label_status";
            this.label_status.Size = new System.Drawing.Size(51, 19);
            this.label_status.TabIndex = 10;
            this.label_status.Text = "状态：";
            // 
            // richTextBox_status_info
            // 
            this.richTextBox_status_info.BackColor = System.Drawing.Color.GhostWhite;
            this.richTextBox_status_info.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.richTextBox_status_info.Font = new System.Drawing.Font("微软雅黑", 10F);
            this.richTextBox_status_info.Location = new System.Drawing.Point(290, 248);
            this.richTextBox_status_info.Name = "richTextBox_status_info";
            this.richTextBox_status_info.ReadOnly = true;
            this.richTextBox_status_info.Size = new System.Drawing.Size(555, 140);
            this.richTextBox_status_info.TabIndex = 11;
            this.richTextBox_status_info.Text = "";
            this.richTextBox_status_info.MouseDown += new System.Windows.Forms.MouseEventHandler(this.richTextBox2_MouseDown);
            // 
            // button_get_ip
            // 
            this.button_get_ip.Location = new System.Drawing.Point(152, 248);
            this.button_get_ip.Name = "button_get_ip";
            this.button_get_ip.Size = new System.Drawing.Size(106, 23);
            this.button_get_ip.TabIndex = 12;
            this.button_get_ip.Text = "获取本机地址";
            this.button_get_ip.UseVisualStyleBackColor = true;
            this.button_get_ip.Click += new System.EventHandler(this.button_get_ip_Click);
            // 
            // button_reset_template
            // 
            this.button_reset_template.Location = new System.Drawing.Point(387, 184);
            this.button_reset_template.Name = "button_reset_template";
            this.button_reset_template.Size = new System.Drawing.Size(100, 46);
            this.button_reset_template.TabIndex = 13;
            this.button_reset_template.Text = "初始化\r\n为认证信息模板";
            this.button_reset_template.UseVisualStyleBackColor = true;
            this.button_reset_template.Click += new System.EventHandler(this.button_reset_template_Click);
            // 
            // label_tip
            // 
            this.label_tip.AutoSize = true;
            this.label_tip.Font = new System.Drawing.Font("宋体", 15F);
            this.label_tip.Location = new System.Drawing.Point(8, 9);
            this.label_tip.Name = "label_tip";
            this.label_tip.Size = new System.Drawing.Size(539, 20);
            this.label_tip.TabIndex = 14;
            this.label_tip.Text = "发送自定义认证信息时请确保命令和格式正确,否则会卡加载";
            // 
            // button_tip
            // 
            this.button_tip.Location = new System.Drawing.Point(771, 12);
            this.button_tip.Name = "button_tip";
            this.button_tip.Size = new System.Drawing.Size(75, 23);
            this.button_tip.TabIndex = 15;
            this.button_tip.Text = "使用说明";
            this.button_tip.UseVisualStyleBackColor = true;
            this.button_tip.Click += new System.EventHandler(this.button_tip_Click);
            // 
            // button_send_cmd
            // 
            this.button_send_cmd.Enabled = false;
            this.button_send_cmd.Location = new System.Drawing.Point(745, 184);
            this.button_send_cmd.Name = "button_send_cmd";
            this.button_send_cmd.Size = new System.Drawing.Size(100, 46);
            this.button_send_cmd.TabIndex = 16;
            this.button_send_cmd.Text = "发送自定义消息（CMD）";
            this.button_send_cmd.UseVisualStyleBackColor = true;
            this.button_send_cmd.Click += new System.EventHandler(this.button_send_cmd_Click);
            // 
            // notifyIcon
            // 
            this.notifyIcon.ContextMenuStrip = this.contextMenuStrip1;
            this.notifyIcon.Icon = ((System.Drawing.Icon)(resources.GetObject("notifyIcon.Icon")));
            this.notifyIcon.Text = "爱校园第三方登录";
            this.notifyIcon.Visible = true;
            this.notifyIcon.MouseDoubleClick += new System.Windows.Forms.MouseEventHandler(this.notifyIcon1_MouseDoubleClick);
            // 
            // contextMenuStrip1
            // 
            this.contextMenuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.ToolStripMenuItem_show_window,
            this.ToolStripMenuItem_hide_window,
            this.ToolStripMenuItem_Exit});
            this.contextMenuStrip1.Name = "contextMenuStrip1";
            this.contextMenuStrip1.Size = new System.Drawing.Size(125, 70);
            // 
            // ToolStripMenuItem_show_window
            // 
            this.ToolStripMenuItem_show_window.Name = "ToolStripMenuItem_show_window";
            this.ToolStripMenuItem_show_window.Size = new System.Drawing.Size(124, 22);
            this.ToolStripMenuItem_show_window.Text = "显示窗口";
            this.ToolStripMenuItem_show_window.Click += new System.EventHandler(this.ToolStripMenuItem_show_window_Click);
            // 
            // ToolStripMenuItem_hide_window
            // 
            this.ToolStripMenuItem_hide_window.Name = "ToolStripMenuItem_hide_window";
            this.ToolStripMenuItem_hide_window.Size = new System.Drawing.Size(124, 22);
            this.ToolStripMenuItem_hide_window.Text = "隐藏窗口";
            this.ToolStripMenuItem_hide_window.Click += new System.EventHandler(this.ToolStripMenuItem_hide_window_Click);
            // 
            // ToolStripMenuItem_Exit
            // 
            this.ToolStripMenuItem_Exit.Name = "ToolStripMenuItem_Exit";
            this.ToolStripMenuItem_Exit.Size = new System.Drawing.Size(124, 22);
            this.ToolStripMenuItem_Exit.Text = "退出";
            this.ToolStripMenuItem_Exit.Click += new System.EventHandler(this.退出ToolStripMenuItem_Click);
            // 
            // textBox_session_id
            // 
            this.textBox_session_id.Location = new System.Drawing.Point(186, 523);
            this.textBox_session_id.Name = "textBox_session_id";
            this.textBox_session_id.Size = new System.Drawing.Size(277, 21);
            this.textBox_session_id.TabIndex = 18;
            // 
            // label_session_id
            // 
            this.label_session_id.AutoSize = true;
            this.label_session_id.Font = new System.Drawing.Font("微软雅黑", 10.5F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.label_session_id.Location = new System.Drawing.Point(101, 520);
            this.label_session_id.Name = "label_session_id";
            this.label_session_id.Size = new System.Drawing.Size(79, 20);
            this.label_session_id.TabIndex = 19;
            this.label_session_id.Text = "session_id:";
            // 
            // button_offline_thisid
            // 
            this.button_offline_thisid.Location = new System.Drawing.Point(496, 523);
            this.button_offline_thisid.Name = "button_offline_thisid";
            this.button_offline_thisid.Size = new System.Drawing.Size(75, 23);
            this.button_offline_thisid.TabIndex = 20;
            this.button_offline_thisid.Text = "下线该ID";
            this.button_offline_thisid.UseVisualStyleBackColor = true;
            this.button_offline_thisid.Click += new System.EventHandler(this.button_offline_thisid_Click);
            // 
            // label_last_session_id
            // 
            this.label_last_session_id.AutoSize = true;
            this.label_last_session_id.Location = new System.Drawing.Point(103, 500);
            this.label_last_session_id.Name = "label_last_session_id";
            this.label_last_session_id.Size = new System.Drawing.Size(155, 12);
            this.label_last_session_id.TabIndex = 21;
            this.label_last_session_id.Text = "上次成功登录的session_id:";
            // 
            // label_session_id_success
            // 
            this.label_session_id_success.AutoSize = true;
            this.label_session_id_success.Font = new System.Drawing.Font("微软雅黑", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.label_session_id_success.Location = new System.Drawing.Point(258, 498);
            this.label_session_id_success.Name = "label_session_id_success";
            this.label_session_id_success.Size = new System.Drawing.Size(0, 17);
            this.label_session_id_success.TabIndex = 22;
            // 
            // button_offline
            // 
            this.button_offline.Location = new System.Drawing.Point(496, 487);
            this.button_offline.Name = "button_offline";
            this.button_offline.Size = new System.Drawing.Size(75, 23);
            this.button_offline.TabIndex = 23;
            this.button_offline.Text = "下线";
            this.button_offline.UseVisualStyleBackColor = true;
            this.button_offline.Click += new System.EventHandler(this.button_offline_Click);
            // 
            // button_rich2_clear
            // 
            this.button_rich2_clear.Location = new System.Drawing.Point(745, 350);
            this.button_rich2_clear.Name = "button_rich2_clear";
            this.button_rich2_clear.Size = new System.Drawing.Size(76, 29);
            this.button_rich2_clear.TabIndex = 24;
            this.button_rich2_clear.Text = "清空";
            this.button_rich2_clear.UseVisualStyleBackColor = true;
            this.button_rich2_clear.Click += new System.EventHandler(this.button_rich2_clear_Click);
            // 
            // label_last_ip
            // 
            this.label_last_ip.AutoSize = true;
            this.label_last_ip.Location = new System.Drawing.Point(10, 203);
            this.label_last_ip.Name = "label_last_ip";
            this.label_last_ip.Size = new System.Drawing.Size(113, 12);
            this.label_last_ip.TabIndex = 25;
            this.label_last_ip.Text = "上次成功登陆的ip：";
            // 
            // label_success_ip
            // 
            this.label_success_ip.AutoSize = true;
            this.label_success_ip.Font = new System.Drawing.Font("微软雅黑", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.label_success_ip.Location = new System.Drawing.Point(129, 201);
            this.label_success_ip.Name = "label_success_ip";
            this.label_success_ip.Size = new System.Drawing.Size(0, 17);
            this.label_success_ip.TabIndex = 26;
            // 
            // button_rich1_clear
            // 
            this.button_rich1_clear.Location = new System.Drawing.Point(771, 148);
            this.button_rich1_clear.Name = "button_rich1_clear";
            this.button_rich1_clear.Size = new System.Drawing.Size(75, 30);
            this.button_rich1_clear.TabIndex = 27;
            this.button_rich1_clear.Text = "清空";
            this.button_rich1_clear.UseVisualStyleBackColor = true;
            this.button_rich1_clear.Click += new System.EventHandler(this.button_rich1_clear_Click);
            // 
            // checkBox_save_account
            // 
            this.checkBox_save_account.AutoSize = true;
            this.checkBox_save_account.Location = new System.Drawing.Point(186, 304);
            this.checkBox_save_account.Name = "checkBox_save_account";
            this.checkBox_save_account.Size = new System.Drawing.Size(72, 16);
            this.checkBox_save_account.TabIndex = 28;
            this.checkBox_save_account.Text = "保存账号";
            this.checkBox_save_account.UseVisualStyleBackColor = true;
            // 
            // button_load_last_success_id
            // 
            this.button_load_last_success_id.Location = new System.Drawing.Point(12, 492);
            this.button_load_last_success_id.Name = "button_load_last_success_id";
            this.button_load_last_success_id.Size = new System.Drawing.Size(85, 50);
            this.button_load_last_success_id.TabIndex = 29;
            this.button_load_last_success_id.Text = "加载上次成功登录的IP和ID";
            this.button_load_last_success_id.UseVisualStyleBackColor = true;
            this.button_load_last_success_id.Click += new System.EventHandler(this.button_load_last_success_id_Click);
            // 
            // radioButton_login_pwd
            // 
            this.radioButton_login_pwd.AutoSize = true;
            this.radioButton_login_pwd.Location = new System.Drawing.Point(12, 372);
            this.radioButton_login_pwd.Name = "radioButton_login_pwd";
            this.radioButton_login_pwd.Size = new System.Drawing.Size(71, 16);
            this.radioButton_login_pwd.TabIndex = 32;
            this.radioButton_login_pwd.TabStop = true;
            this.radioButton_login_pwd.Text = "密码登录";
            this.radioButton_login_pwd.UseVisualStyleBackColor = true;
            this.radioButton_login_pwd.CheckedChanged += new System.EventHandler(this.radioButton1_CheckedChanged);
            // 
            // radioButton_login_sms
            // 
            this.radioButton_login_sms.AutoSize = true;
            this.radioButton_login_sms.Location = new System.Drawing.Point(151, 372);
            this.radioButton_login_sms.Name = "radioButton_login_sms";
            this.radioButton_login_sms.Size = new System.Drawing.Size(107, 16);
            this.radioButton_login_sms.TabIndex = 33;
            this.radioButton_login_sms.TabStop = true;
            this.radioButton_login_sms.Text = "短信验证码登录";
            this.radioButton_login_sms.UseVisualStyleBackColor = true;
            this.radioButton_login_sms.CheckedChanged += new System.EventHandler(this.radioButton2_CheckedChanged);
            // 
            // linkLabel_contact
            // 
            this.linkLabel_contact.AutoSize = true;
            this.linkLabel_contact.Font = new System.Drawing.Font("微软雅黑", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.linkLabel_contact.Location = new System.Drawing.Point(729, 524);
            this.linkLabel_contact.Name = "linkLabel_contact";
            this.linkLabel_contact.Size = new System.Drawing.Size(117, 22);
            this.linkLabel_contact.TabIndex = 34;
            this.linkLabel_contact.TabStop = true;
            this.linkLabel_contact.Text = " 联系作者(QQ)";
            this.linkLabel_contact.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.linkLabel_contact_LinkClicked);
            // 
            // button_get_sms_code
            // 
            this.button_get_sms_code.Location = new System.Drawing.Point(173, 394);
            this.button_get_sms_code.Name = "button_get_sms_code";
            this.button_get_sms_code.Size = new System.Drawing.Size(85, 40);
            this.button_get_sms_code.TabIndex = 35;
            this.button_get_sms_code.Text = "获取短信验证码";
            this.button_get_sms_code.UseVisualStyleBackColor = true;
            this.button_get_sms_code.Visible = false;
            this.button_get_sms_code.Click += new System.EventHandler(this.button_get_sms_code_Click);
            // 
            // richTextBox_status_info2
            // 
            this.richTextBox_status_info2.BackColor = System.Drawing.Color.GhostWhite;
            this.richTextBox_status_info2.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.richTextBox_status_info2.Location = new System.Drawing.Point(290, 395);
            this.richTextBox_status_info2.Name = "richTextBox_status_info2";
            this.richTextBox_status_info2.ReadOnly = true;
            this.richTextBox_status_info2.Size = new System.Drawing.Size(556, 48);
            this.richTextBox_status_info2.TabIndex = 36;
            this.richTextBox_status_info2.Text = "";
            this.richTextBox_status_info2.MouseDown += new System.Windows.Forms.MouseEventHandler(this.richTextBox3_MouseDown);
            // 
            // label_auth_sms
            // 
            this.label_auth_sms.AutoSize = true;
            this.label_auth_sms.Location = new System.Drawing.Point(264, 466);
            this.label_auth_sms.Name = "label_auth_sms";
            this.label_auth_sms.Size = new System.Drawing.Size(0, 12);
            this.label_auth_sms.TabIndex = 37;
            this.label_auth_sms.Visible = false;
            // 
            // button_inquire_school
            // 
            this.button_inquire_school.Location = new System.Drawing.Point(12, 394);
            this.button_inquire_school.Name = "button_inquire_school";
            this.button_inquire_school.Size = new System.Drawing.Size(85, 40);
            this.button_inquire_school.TabIndex = 38;
            this.button_inquire_school.Text = "查询用户所在学校";
            this.button_inquire_school.UseVisualStyleBackColor = true;
            this.button_inquire_school.Click += new System.EventHandler(this.button_inquire_school_Click);
            // 
            // button_rich3_clear
            // 
            this.button_rich3_clear.Location = new System.Drawing.Point(745, 449);
            this.button_rich3_clear.Name = "button_rich3_clear";
            this.button_rich3_clear.Size = new System.Drawing.Size(76, 29);
            this.button_rich3_clear.TabIndex = 39;
            this.button_rich3_clear.Text = "清空";
            this.button_rich3_clear.UseVisualStyleBackColor = true;
            this.button_rich3_clear.Click += new System.EventHandler(this.button_rich3_clear_Click);
            // 
            // button_check_lastid_online
            // 
            this.button_check_lastid_online.Location = new System.Drawing.Point(577, 487);
            this.button_check_lastid_online.Name = "button_check_lastid_online";
            this.button_check_lastid_online.Size = new System.Drawing.Size(110, 23);
            this.button_check_lastid_online.TabIndex = 40;
            this.button_check_lastid_online.Text = " 查询是否在线";
            this.button_check_lastid_online.UseVisualStyleBackColor = true;
            this.button_check_lastid_online.Click += new System.EventHandler(this.button_checkonline_Click);
            // 
            // button_clear_cache
            // 
            this.button_clear_cache.Location = new System.Drawing.Point(668, 12);
            this.button_clear_cache.Name = "button_clear_cache";
            this.button_clear_cache.Size = new System.Drawing.Size(97, 23);
            this.button_clear_cache.TabIndex = 41;
            this.button_clear_cache.Text = "清空账号信息";
            this.button_clear_cache.UseVisualStyleBackColor = true;
            this.button_clear_cache.Click += new System.EventHandler(this.button_clear_cache_Click);
            // 
            // acheckBox_save_pwd
            // 
            this.acheckBox_save_pwd.AutoSize = true;
            this.acheckBox_save_pwd.Location = new System.Drawing.Point(186, 350);
            this.acheckBox_save_pwd.Name = "acheckBox_save_pwd";
            this.acheckBox_save_pwd.Size = new System.Drawing.Size(72, 16);
            this.acheckBox_save_pwd.TabIndex = 42;
            this.acheckBox_save_pwd.Text = "保存密码";
            this.acheckBox_save_pwd.UseVisualStyleBackColor = true;
            // 
            // button_reset_auth_status
            // 
            this.button_reset_auth_status.Enabled = false;
            this.button_reset_auth_status.Location = new System.Drawing.Point(577, 12);
            this.button_reset_auth_status.Name = "button_reset_auth_status";
            this.button_reset_auth_status.Size = new System.Drawing.Size(85, 23);
            this.button_reset_auth_status.TabIndex = 43;
            this.button_reset_auth_status.Text = "重置认证状态";
            this.button_reset_auth_status.UseVisualStyleBackColor = true;
            this.button_reset_auth_status.Click += new System.EventHandler(this.button_reset_auth_status_Click);
            // 
            // button_connect_test
            // 
            this.button_connect_test.Location = new System.Drawing.Point(12, 248);
            this.button_connect_test.Name = "button_connect_test";
            this.button_connect_test.Size = new System.Drawing.Size(75, 23);
            this.button_connect_test.TabIndex = 44;
            this.button_connect_test.Text = "连通性测试";
            this.button_connect_test.UseVisualStyleBackColor = true;
            this.button_connect_test.Click += new System.EventHandler(this.button_test_Click);
            // 
            // button_checkidonline
            // 
            this.button_checkidonline.Location = new System.Drawing.Point(577, 524);
            this.button_checkidonline.Name = "button_checkidonline";
            this.button_checkidonline.Size = new System.Drawing.Size(110, 23);
            this.button_checkidonline.TabIndex = 45;
            this.button_checkidonline.Text = "查询该ID是否在线";
            this.button_checkidonline.UseVisualStyleBackColor = true;
            this.button_checkidonline.Click += new System.EventHandler(this.button_checkidonline_Click);
            // 
            // Form_main
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.GhostWhite;
            this.ClientSize = new System.Drawing.Size(853, 552);
            this.Controls.Add(this.button_checkidonline);
            this.Controls.Add(this.button_connect_test);
            this.Controls.Add(this.button_reset_auth_status);
            this.Controls.Add(this.acheckBox_save_pwd);
            this.Controls.Add(this.button_clear_cache);
            this.Controls.Add(this.button_check_lastid_online);
            this.Controls.Add(this.button_rich3_clear);
            this.Controls.Add(this.button_inquire_school);
            this.Controls.Add(this.label_auth_sms);
            this.Controls.Add(this.richTextBox_status_info2);
            this.Controls.Add(this.button_get_sms_code);
            this.Controls.Add(this.linkLabel_contact);
            this.Controls.Add(this.radioButton_login_sms);
            this.Controls.Add(this.radioButton_login_pwd);
            this.Controls.Add(this.button_load_last_success_id);
            this.Controls.Add(this.checkBox_save_account);
            this.Controls.Add(this.button_rich1_clear);
            this.Controls.Add(this.label_success_ip);
            this.Controls.Add(this.label_last_ip);
            this.Controls.Add(this.button_rich2_clear);
            this.Controls.Add(this.button_offline);
            this.Controls.Add(this.label_session_id_success);
            this.Controls.Add(this.label_last_session_id);
            this.Controls.Add(this.button_offline_thisid);
            this.Controls.Add(this.label_session_id);
            this.Controls.Add(this.textBox_session_id);
            this.Controls.Add(this.button_send_cmd);
            this.Controls.Add(this.button_tip);
            this.Controls.Add(this.label_tip);
            this.Controls.Add(this.button_reset_template);
            this.Controls.Add(this.button_get_ip);
            this.Controls.Add(this.label_status);
            this.Controls.Add(this.button_send_authinfo);
            this.Controls.Add(this.richTextBox_authinfo);
            this.Controls.Add(this.textBox_pwd);
            this.Controls.Add(this.textBox_account);
            this.Controls.Add(this.textBox_ip);
            this.Controls.Add(this.label_pwd);
            this.Controls.Add(this.label_account);
            this.Controls.Add(this.label_destination_ip);
            this.Controls.Add(this.button_exit);
            this.Controls.Add(this.button_login);
            this.Controls.Add(this.richTextBox_status_info);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.KeyPreview = true;
            this.MaximizeBox = false;
            this.Name = "Form_main";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "爱校园V1.0.8";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.Form1_FormClosing);
            this.Load += new System.EventHandler(this.start_load);
            this.SizeChanged += new System.EventHandler(this.Form1_SizeChanged);
            this.contextMenuStrip1.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button button_exit;
        private System.Windows.Forms.Label label_destination_ip;
        private System.Windows.Forms.Label label_account;
        private System.Windows.Forms.Label label_pwd;
        private System.Windows.Forms.TextBox textBox_ip;
        private System.Windows.Forms.TextBox textBox_account;
        private System.Windows.Forms.TextBox textBox_pwd;
        private System.Windows.Forms.RichTextBox richTextBox_authinfo;
        private System.Windows.Forms.Button button_send_authinfo;
        private System.Windows.Forms.Label label_status;
        private System.Windows.Forms.RichTextBox richTextBox_status_info;
        private System.Windows.Forms.Button button_get_ip;
        private System.Windows.Forms.Button button_reset_template;
        private System.Windows.Forms.Label label_tip;
        private System.Windows.Forms.Button button_tip;
        public System.Windows.Forms.Button button_login;
        private System.Windows.Forms.Button button_send_cmd;
        private System.Windows.Forms.NotifyIcon notifyIcon;
        private System.Windows.Forms.ContextMenuStrip contextMenuStrip1;
        private System.Windows.Forms.ToolStripMenuItem ToolStripMenuItem_show_window;
        private System.Windows.Forms.ToolStripMenuItem ToolStripMenuItem_hide_window;
        private System.Windows.Forms.ToolStripMenuItem ToolStripMenuItem_Exit;
        private System.Windows.Forms.TextBox textBox_session_id;
        private System.Windows.Forms.Label label_session_id;
        private System.Windows.Forms.Button button_offline_thisid;
        private System.Windows.Forms.Label label_last_session_id;
        private System.Windows.Forms.Label label_session_id_success;
        private System.Windows.Forms.Button button_offline;
        private System.Windows.Forms.Button button_rich2_clear;
        private System.Windows.Forms.Label label_last_ip;
        private System.Windows.Forms.Label label_success_ip;
        private System.Windows.Forms.Button button_rich1_clear;
        private System.Windows.Forms.CheckBox checkBox_save_account;
        private System.Windows.Forms.Button button_load_last_success_id;
        private System.Windows.Forms.RadioButton radioButton_login_pwd;
        private System.Windows.Forms.RadioButton radioButton_login_sms;
        private System.Windows.Forms.LinkLabel linkLabel_contact;
        private System.Windows.Forms.Button button_get_sms_code;
        private System.Windows.Forms.RichTextBox richTextBox_status_info2;
        private System.Windows.Forms.Label label_auth_sms;
        private System.Windows.Forms.Button button_inquire_school;
        private System.Windows.Forms.Button button_rich3_clear;
        private System.Windows.Forms.Button button_check_lastid_online;
        private System.Windows.Forms.Button button_clear_cache;
        private System.Windows.Forms.CheckBox acheckBox_save_pwd;
        private System.Windows.Forms.Button button_reset_auth_status;
        private System.Windows.Forms.Button button_connect_test;
        private System.Windows.Forms.Button button_checkidonline;

        public System.EventHandler Form1_Load { get; set; }
    }
}

