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
            this.button_登录 = new System.Windows.Forms.Button();
            this.button_退出 = new System.Windows.Forms.Button();
            this.label_目标IP = new System.Windows.Forms.Label();
            this.label_账号 = new System.Windows.Forms.Label();
            this.label_密码 = new System.Windows.Forms.Label();
            this.textBox_ip = new System.Windows.Forms.TextBox();
            this.textBox_账号 = new System.Windows.Forms.TextBox();
            this.textBox_密码 = new System.Windows.Forms.TextBox();
            this.richTextBox1 = new System.Windows.Forms.RichTextBox();
            this.button_发送认证信息 = new System.Windows.Forms.Button();
            this.label_状态 = new System.Windows.Forms.Label();
            this.richTextBox2 = new System.Windows.Forms.RichTextBox();
            this.button_获取IP地址 = new System.Windows.Forms.Button();
            this.button_初始化模板 = new System.Windows.Forms.Button();
            this.label_提示 = new System.Windows.Forms.Label();
            this.button_使用说明 = new System.Windows.Forms.Button();
            this.button_发送自定义消息 = new System.Windows.Forms.Button();
            this.notifyIcon1 = new System.Windows.Forms.NotifyIcon(this.components);
            this.contextMenuStrip1 = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.显示窗口ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.隐藏窗口ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.退出ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.textBox_session_id = new System.Windows.Forms.TextBox();
            this.label_session_id = new System.Windows.Forms.Label();
            this.button_下线该ID = new System.Windows.Forms.Button();
            this.label_last_session_id = new System.Windows.Forms.Label();
            this.label_session_id_success = new System.Windows.Forms.Label();
            this.button9 = new System.Windows.Forms.Button();
            this.button_rich2清空 = new System.Windows.Forms.Button();
            this.label_last_ip = new System.Windows.Forms.Label();
            this.label_成功IP = new System.Windows.Forms.Label();
            this.button_rich1清空 = new System.Windows.Forms.Button();
            this.checkBox_保存账号 = new System.Windows.Forms.CheckBox();
            this.button_加载上次成功id = new System.Windows.Forms.Button();
            this.radioButton_密码登录 = new System.Windows.Forms.RadioButton();
            this.radioButton_短信登录 = new System.Windows.Forms.RadioButton();
            this.linkLabel_联系方式 = new System.Windows.Forms.LinkLabel();
            this.button_获取短信验证码 = new System.Windows.Forms.Button();
            this.richTextBox3 = new System.Windows.Forms.RichTextBox();
            this.label_验证短信 = new System.Windows.Forms.Label();
            this.button_查询学校 = new System.Windows.Forms.Button();
            this.button_rich3清空 = new System.Windows.Forms.Button();
            this.button_查询在线状态 = new System.Windows.Forms.Button();
            this.button_清空缓存 = new System.Windows.Forms.Button();
            this.checkBox_保存密码 = new System.Windows.Forms.CheckBox();
            this.button1 = new System.Windows.Forms.Button();
            this.contextMenuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // button_登录
            // 
            this.button_登录.Location = new System.Drawing.Point(12, 440);
            this.button_登录.Name = "button_登录";
            this.button_登录.Size = new System.Drawing.Size(85, 46);
            this.button_登录.TabIndex = 0;
            this.button_登录.Text = "登录";
            this.button_登录.UseVisualStyleBackColor = true;
            this.button_登录.Click += new System.EventHandler(this.button_登录_Click);
            // 
            // button_退出
            // 
            this.button_退出.Location = new System.Drawing.Point(173, 440);
            this.button_退出.Name = "button_退出";
            this.button_退出.Size = new System.Drawing.Size(85, 46);
            this.button_退出.TabIndex = 1;
            this.button_退出.Text = "退出";
            this.button_退出.UseVisualStyleBackColor = true;
            this.button_退出.Click += new System.EventHandler(this.button_退出_Click);
            // 
            // label_目标IP
            // 
            this.label_目标IP.AutoSize = true;
            this.label_目标IP.Font = new System.Drawing.Font("微软雅黑", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.label_目标IP.Location = new System.Drawing.Point(13, 217);
            this.label_目标IP.Name = "label_目标IP";
            this.label_目标IP.Size = new System.Drawing.Size(58, 22);
            this.label_目标IP.TabIndex = 2;
            this.label_目标IP.Text = "目标IP";
            // 
            // label_账号
            // 
            this.label_账号.AutoSize = true;
            this.label_账号.Font = new System.Drawing.Font("微软雅黑", 12F, System.Drawing.FontStyle.Bold);
            this.label_账号.Location = new System.Drawing.Point(14, 277);
            this.label_账号.Name = "label_账号";
            this.label_账号.Size = new System.Drawing.Size(42, 22);
            this.label_账号.TabIndex = 3;
            this.label_账号.Text = "账号";
            // 
            // label_密码
            // 
            this.label_密码.AutoSize = true;
            this.label_密码.Font = new System.Drawing.Font("微软雅黑", 12F, System.Drawing.FontStyle.Bold);
            this.label_密码.Location = new System.Drawing.Point(12, 326);
            this.label_密码.Name = "label_密码";
            this.label_密码.Size = new System.Drawing.Size(47, 22);
            this.label_密码.TabIndex = 4;
            this.label_密码.Text = "密码:";
            // 
            // textBox_ip
            // 
            this.textBox_ip.Location = new System.Drawing.Point(113, 221);
            this.textBox_ip.Name = "textBox_ip";
            this.textBox_ip.Size = new System.Drawing.Size(145, 21);
            this.textBox_ip.TabIndex = 5;
            // 
            // textBox_账号
            // 
            this.textBox_账号.Location = new System.Drawing.Point(113, 277);
            this.textBox_账号.Name = "textBox_账号";
            this.textBox_账号.Size = new System.Drawing.Size(145, 21);
            this.textBox_账号.TabIndex = 6;
            // 
            // textBox_密码
            // 
            this.textBox_密码.Location = new System.Drawing.Point(113, 326);
            this.textBox_密码.Name = "textBox_密码";
            this.textBox_密码.PasswordChar = '*';
            this.textBox_密码.Size = new System.Drawing.Size(145, 21);
            this.textBox_密码.TabIndex = 7;
            // 
            // richTextBox1
            // 
            this.richTextBox1.BackColor = System.Drawing.Color.MintCream;
            this.richTextBox1.Font = new System.Drawing.Font("微软雅黑", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.richTextBox1.Location = new System.Drawing.Point(12, 41);
            this.richTextBox1.Name = "richTextBox1";
            this.richTextBox1.Size = new System.Drawing.Size(834, 137);
            this.richTextBox1.TabIndex = 8;
            this.richTextBox1.Text = "";
            this.richTextBox1.TextChanged += new System.EventHandler(this.richTextBox1_TextChanged);
            // 
            // button_发送认证信息
            // 
            this.button_发送认证信息.Location = new System.Drawing.Point(566, 184);
            this.button_发送认证信息.Name = "button_发送认证信息";
            this.button_发送认证信息.Size = new System.Drawing.Size(100, 46);
            this.button_发送认证信息.TabIndex = 9;
            this.button_发送认证信息.Text = "发送认证消息";
            this.button_发送认证信息.UseVisualStyleBackColor = true;
            this.button_发送认证信息.Click += new System.EventHandler(this.button_发送认证消息_Click);
            // 
            // label_状态
            // 
            this.label_状态.AutoSize = true;
            this.label_状态.Font = new System.Drawing.Font("微软雅黑", 10F, System.Drawing.FontStyle.Bold);
            this.label_状态.Location = new System.Drawing.Point(286, 217);
            this.label_状态.Name = "label_状态";
            this.label_状态.Size = new System.Drawing.Size(51, 19);
            this.label_状态.TabIndex = 10;
            this.label_状态.Text = "状态：";
            // 
            // richTextBox2
            // 
            this.richTextBox2.BackColor = System.Drawing.Color.GhostWhite;
            this.richTextBox2.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.richTextBox2.Font = new System.Drawing.Font("微软雅黑", 10F);
            this.richTextBox2.Location = new System.Drawing.Point(290, 248);
            this.richTextBox2.Name = "richTextBox2";
            this.richTextBox2.ReadOnly = true;
            this.richTextBox2.Size = new System.Drawing.Size(555, 140);
            this.richTextBox2.TabIndex = 11;
            this.richTextBox2.Text = "";
            this.richTextBox2.MouseDown += new System.Windows.Forms.MouseEventHandler(this.richTextBox2_MouseDown);
            // 
            // button_获取IP地址
            // 
            this.button_获取IP地址.Location = new System.Drawing.Point(152, 248);
            this.button_获取IP地址.Name = "button_获取IP地址";
            this.button_获取IP地址.Size = new System.Drawing.Size(106, 23);
            this.button_获取IP地址.TabIndex = 12;
            this.button_获取IP地址.Text = "获取本机地址";
            this.button_获取IP地址.UseVisualStyleBackColor = true;
            this.button_获取IP地址.Click += new System.EventHandler(this.button_获取IP地址_Click);
            // 
            // button_初始化模板
            // 
            this.button_初始化模板.Location = new System.Drawing.Point(387, 184);
            this.button_初始化模板.Name = "button_初始化模板";
            this.button_初始化模板.Size = new System.Drawing.Size(100, 46);
            this.button_初始化模板.TabIndex = 13;
            this.button_初始化模板.Text = "初始化\r\n为认证信息模板";
            this.button_初始化模板.UseVisualStyleBackColor = true;
            this.button_初始化模板.Click += new System.EventHandler(this.button_初始化认证模板_Click);
            // 
            // label_提示
            // 
            this.label_提示.AutoSize = true;
            this.label_提示.Font = new System.Drawing.Font("宋体", 15F);
            this.label_提示.Location = new System.Drawing.Point(8, 9);
            this.label_提示.Name = "label_提示";
            this.label_提示.Size = new System.Drawing.Size(539, 20);
            this.label_提示.TabIndex = 14;
            this.label_提示.Text = "发送自定义认证信息时请确保命令和格式正确,否则会卡加载";
            // 
            // button_使用说明
            // 
            this.button_使用说明.Location = new System.Drawing.Point(771, 12);
            this.button_使用说明.Name = "button_使用说明";
            this.button_使用说明.Size = new System.Drawing.Size(75, 23);
            this.button_使用说明.TabIndex = 15;
            this.button_使用说明.Text = "使用说明";
            this.button_使用说明.UseVisualStyleBackColor = true;
            this.button_使用说明.Click += new System.EventHandler(this.button_使用说明_Click);
            // 
            // button_发送自定义消息
            // 
            this.button_发送自定义消息.Location = new System.Drawing.Point(745, 184);
            this.button_发送自定义消息.Name = "button_发送自定义消息";
            this.button_发送自定义消息.Size = new System.Drawing.Size(100, 46);
            this.button_发送自定义消息.TabIndex = 16;
            this.button_发送自定义消息.Text = "发送自定义消息（CMD）";
            this.button_发送自定义消息.UseVisualStyleBackColor = true;
            this.button_发送自定义消息.Click += new System.EventHandler(this.button_发送自定义消息_Click);
            // 
            // notifyIcon1
            // 
            this.notifyIcon1.ContextMenuStrip = this.contextMenuStrip1;
            this.notifyIcon1.Icon = ((System.Drawing.Icon)(resources.GetObject("notifyIcon1.Icon")));
            this.notifyIcon1.Text = "爱校园第三方登录";
            this.notifyIcon1.Visible = true;
            this.notifyIcon1.MouseDoubleClick += new System.Windows.Forms.MouseEventHandler(this.notifyIcon1_MouseDoubleClick);
            // 
            // contextMenuStrip1
            // 
            this.contextMenuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.显示窗口ToolStripMenuItem,
            this.隐藏窗口ToolStripMenuItem,
            this.退出ToolStripMenuItem});
            this.contextMenuStrip1.Name = "contextMenuStrip1";
            this.contextMenuStrip1.Size = new System.Drawing.Size(125, 70);
            // 
            // 显示窗口ToolStripMenuItem
            // 
            this.显示窗口ToolStripMenuItem.Name = "显示窗口ToolStripMenuItem";
            this.显示窗口ToolStripMenuItem.Size = new System.Drawing.Size(124, 22);
            this.显示窗口ToolStripMenuItem.Text = "显示窗口";
            this.显示窗口ToolStripMenuItem.Click += new System.EventHandler(this.显示窗口ToolStripMenuItem_Click);
            // 
            // 隐藏窗口ToolStripMenuItem
            // 
            this.隐藏窗口ToolStripMenuItem.Name = "隐藏窗口ToolStripMenuItem";
            this.隐藏窗口ToolStripMenuItem.Size = new System.Drawing.Size(124, 22);
            this.隐藏窗口ToolStripMenuItem.Text = "隐藏窗口";
            this.隐藏窗口ToolStripMenuItem.Click += new System.EventHandler(this.隐藏窗口ToolStripMenuItem_Click);
            // 
            // 退出ToolStripMenuItem
            // 
            this.退出ToolStripMenuItem.Name = "退出ToolStripMenuItem";
            this.退出ToolStripMenuItem.Size = new System.Drawing.Size(124, 22);
            this.退出ToolStripMenuItem.Text = "退出";
            this.退出ToolStripMenuItem.Click += new System.EventHandler(this.退出ToolStripMenuItem_Click);
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
            // button_下线该ID
            // 
            this.button_下线该ID.Location = new System.Drawing.Point(496, 523);
            this.button_下线该ID.Name = "button_下线该ID";
            this.button_下线该ID.Size = new System.Drawing.Size(75, 23);
            this.button_下线该ID.TabIndex = 20;
            this.button_下线该ID.Text = "下线该ID";
            this.button_下线该ID.UseVisualStyleBackColor = true;
            this.button_下线该ID.Click += new System.EventHandler(this.button_下线该ID_Click);
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
            // button9
            // 
            this.button9.Location = new System.Drawing.Point(496, 487);
            this.button9.Name = "button9";
            this.button9.Size = new System.Drawing.Size(75, 23);
            this.button9.TabIndex = 23;
            this.button9.Text = "下线";
            this.button9.UseVisualStyleBackColor = true;
            this.button9.Click += new System.EventHandler(this.button_下线_Click);
            // 
            // button_rich2清空
            // 
            this.button_rich2清空.Location = new System.Drawing.Point(771, 359);
            this.button_rich2清空.Name = "button_rich2清空";
            this.button_rich2清空.Size = new System.Drawing.Size(76, 29);
            this.button_rich2清空.TabIndex = 24;
            this.button_rich2清空.Text = "清空";
            this.button_rich2清空.UseVisualStyleBackColor = true;
            this.button_rich2清空.Click += new System.EventHandler(this.button_清空rich2_Click);
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
            // label_成功IP
            // 
            this.label_成功IP.AutoSize = true;
            this.label_成功IP.Font = new System.Drawing.Font("微软雅黑", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.label_成功IP.Location = new System.Drawing.Point(129, 201);
            this.label_成功IP.Name = "label_成功IP";
            this.label_成功IP.Size = new System.Drawing.Size(0, 17);
            this.label_成功IP.TabIndex = 26;
            // 
            // button_rich1清空
            // 
            this.button_rich1清空.Location = new System.Drawing.Point(771, 148);
            this.button_rich1清空.Name = "button_rich1清空";
            this.button_rich1清空.Size = new System.Drawing.Size(75, 30);
            this.button_rich1清空.TabIndex = 27;
            this.button_rich1清空.Text = "清空";
            this.button_rich1清空.UseVisualStyleBackColor = true;
            this.button_rich1清空.Click += new System.EventHandler(this.button_清空rich1_Click);
            // 
            // checkBox_保存账号
            // 
            this.checkBox_保存账号.AutoSize = true;
            this.checkBox_保存账号.Location = new System.Drawing.Point(186, 304);
            this.checkBox_保存账号.Name = "checkBox_保存账号";
            this.checkBox_保存账号.Size = new System.Drawing.Size(72, 16);
            this.checkBox_保存账号.TabIndex = 28;
            this.checkBox_保存账号.Text = "保存账号";
            this.checkBox_保存账号.UseVisualStyleBackColor = true;
            // 
            // button_加载上次成功id
            // 
            this.button_加载上次成功id.Location = new System.Drawing.Point(12, 492);
            this.button_加载上次成功id.Name = "button_加载上次成功id";
            this.button_加载上次成功id.Size = new System.Drawing.Size(85, 50);
            this.button_加载上次成功id.TabIndex = 29;
            this.button_加载上次成功id.Text = "加载上次成功登录的IP和ID";
            this.button_加载上次成功id.UseVisualStyleBackColor = true;
            this.button_加载上次成功id.Click += new System.EventHandler(this.button_加载上次成功ID_Click);
            // 
            // radioButton_密码登录
            // 
            this.radioButton_密码登录.AutoSize = true;
            this.radioButton_密码登录.Location = new System.Drawing.Point(12, 372);
            this.radioButton_密码登录.Name = "radioButton_密码登录";
            this.radioButton_密码登录.Size = new System.Drawing.Size(71, 16);
            this.radioButton_密码登录.TabIndex = 32;
            this.radioButton_密码登录.TabStop = true;
            this.radioButton_密码登录.Text = "密码登录";
            this.radioButton_密码登录.UseVisualStyleBackColor = true;
            this.radioButton_密码登录.CheckedChanged += new System.EventHandler(this.radioButton1_CheckedChanged);
            // 
            // radioButton_短信登录
            // 
            this.radioButton_短信登录.AutoSize = true;
            this.radioButton_短信登录.Location = new System.Drawing.Point(151, 372);
            this.radioButton_短信登录.Name = "radioButton_短信登录";
            this.radioButton_短信登录.Size = new System.Drawing.Size(107, 16);
            this.radioButton_短信登录.TabIndex = 33;
            this.radioButton_短信登录.TabStop = true;
            this.radioButton_短信登录.Text = "短信验证码登录";
            this.radioButton_短信登录.UseVisualStyleBackColor = true;
            this.radioButton_短信登录.CheckedChanged += new System.EventHandler(this.radioButton2_CheckedChanged);
            // 
            // linkLabel_联系方式
            // 
            this.linkLabel_联系方式.AutoSize = true;
            this.linkLabel_联系方式.Font = new System.Drawing.Font("微软雅黑", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.linkLabel_联系方式.Location = new System.Drawing.Point(729, 524);
            this.linkLabel_联系方式.Name = "linkLabel_联系方式";
            this.linkLabel_联系方式.Size = new System.Drawing.Size(117, 22);
            this.linkLabel_联系方式.TabIndex = 34;
            this.linkLabel_联系方式.TabStop = true;
            this.linkLabel_联系方式.Text = " 联系作者(QQ)";
            this.linkLabel_联系方式.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.linkLabel1_LinkClicked);
            // 
            // button_获取短信验证码
            // 
            this.button_获取短信验证码.Location = new System.Drawing.Point(173, 394);
            this.button_获取短信验证码.Name = "button_获取短信验证码";
            this.button_获取短信验证码.Size = new System.Drawing.Size(85, 40);
            this.button_获取短信验证码.TabIndex = 35;
            this.button_获取短信验证码.Text = "获取短信验证码";
            this.button_获取短信验证码.UseVisualStyleBackColor = true;
            this.button_获取短信验证码.Visible = false;
            this.button_获取短信验证码.Click += new System.EventHandler(this.button_获取短信验证码_Click);
            // 
            // richTextBox3
            // 
            this.richTextBox3.BackColor = System.Drawing.Color.GhostWhite;
            this.richTextBox3.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.richTextBox3.Location = new System.Drawing.Point(290, 395);
            this.richTextBox3.Name = "richTextBox3";
            this.richTextBox3.ReadOnly = true;
            this.richTextBox3.Size = new System.Drawing.Size(556, 48);
            this.richTextBox3.TabIndex = 36;
            this.richTextBox3.Text = "";
            this.richTextBox3.MouseDown += new System.Windows.Forms.MouseEventHandler(this.richTextBox3_MouseDown);
            // 
            // label_验证短信
            // 
            this.label_验证短信.AutoSize = true;
            this.label_验证短信.Location = new System.Drawing.Point(264, 466);
            this.label_验证短信.Name = "label_验证短信";
            this.label_验证短信.Size = new System.Drawing.Size(0, 12);
            this.label_验证短信.TabIndex = 37;
            this.label_验证短信.Visible = false;
            // 
            // button_查询学校
            // 
            this.button_查询学校.Location = new System.Drawing.Point(12, 394);
            this.button_查询学校.Name = "button_查询学校";
            this.button_查询学校.Size = new System.Drawing.Size(85, 40);
            this.button_查询学校.TabIndex = 38;
            this.button_查询学校.Text = "查询用户所在学校";
            this.button_查询学校.UseVisualStyleBackColor = true;
            this.button_查询学校.Click += new System.EventHandler(this.button_查询学校_Click);
            // 
            // button_rich3清空
            // 
            this.button_rich3清空.Location = new System.Drawing.Point(769, 449);
            this.button_rich3清空.Name = "button_rich3清空";
            this.button_rich3清空.Size = new System.Drawing.Size(76, 29);
            this.button_rich3清空.TabIndex = 39;
            this.button_rich3清空.Text = "清空";
            this.button_rich3清空.UseVisualStyleBackColor = true;
            this.button_rich3清空.Click += new System.EventHandler(this.button_清空rich3_Click);
            // 
            // button_查询在线状态
            // 
            this.button_查询在线状态.Location = new System.Drawing.Point(577, 487);
            this.button_查询在线状态.Name = "button_查询在线状态";
            this.button_查询在线状态.Size = new System.Drawing.Size(98, 23);
            this.button_查询在线状态.TabIndex = 40;
            this.button_查询在线状态.Text = " 查询是否在线";
            this.button_查询在线状态.UseVisualStyleBackColor = true;
            this.button_查询在线状态.Click += new System.EventHandler(this.button_查询在线_Click);
            // 
            // button_清空缓存
            // 
            this.button_清空缓存.Location = new System.Drawing.Point(668, 12);
            this.button_清空缓存.Name = "button_清空缓存";
            this.button_清空缓存.Size = new System.Drawing.Size(97, 23);
            this.button_清空缓存.TabIndex = 41;
            this.button_清空缓存.Text = "清空账号信息";
            this.button_清空缓存.UseVisualStyleBackColor = true;
            this.button_清空缓存.Click += new System.EventHandler(this.button_清空缓存_Click);
            // 
            // checkBox_保存密码
            // 
            this.checkBox_保存密码.AutoSize = true;
            this.checkBox_保存密码.Location = new System.Drawing.Point(186, 350);
            this.checkBox_保存密码.Name = "checkBox_保存密码";
            this.checkBox_保存密码.Size = new System.Drawing.Size(72, 16);
            this.checkBox_保存密码.TabIndex = 42;
            this.checkBox_保存密码.Text = "保存密码";
            this.checkBox_保存密码.UseVisualStyleBackColor = true;
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(577, 12);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(85, 23);
            this.button1.TabIndex = 43;
            this.button1.Text = "重置认证状态";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // Form_main
            // 
            this.AcceptButton = this.button_登录;
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.GhostWhite;
            this.ClientSize = new System.Drawing.Size(853, 552);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.checkBox_保存密码);
            this.Controls.Add(this.button_清空缓存);
            this.Controls.Add(this.button_查询在线状态);
            this.Controls.Add(this.button_rich3清空);
            this.Controls.Add(this.button_查询学校);
            this.Controls.Add(this.label_验证短信);
            this.Controls.Add(this.richTextBox3);
            this.Controls.Add(this.button_获取短信验证码);
            this.Controls.Add(this.linkLabel_联系方式);
            this.Controls.Add(this.radioButton_短信登录);
            this.Controls.Add(this.radioButton_密码登录);
            this.Controls.Add(this.button_加载上次成功id);
            this.Controls.Add(this.checkBox_保存账号);
            this.Controls.Add(this.button_rich1清空);
            this.Controls.Add(this.label_成功IP);
            this.Controls.Add(this.label_last_ip);
            this.Controls.Add(this.button_rich2清空);
            this.Controls.Add(this.button9);
            this.Controls.Add(this.label_session_id_success);
            this.Controls.Add(this.label_last_session_id);
            this.Controls.Add(this.button_下线该ID);
            this.Controls.Add(this.label_session_id);
            this.Controls.Add(this.textBox_session_id);
            this.Controls.Add(this.button_发送自定义消息);
            this.Controls.Add(this.button_使用说明);
            this.Controls.Add(this.label_提示);
            this.Controls.Add(this.button_初始化模板);
            this.Controls.Add(this.button_获取IP地址);
            this.Controls.Add(this.label_状态);
            this.Controls.Add(this.button_发送认证信息);
            this.Controls.Add(this.richTextBox1);
            this.Controls.Add(this.textBox_密码);
            this.Controls.Add(this.textBox_账号);
            this.Controls.Add(this.textBox_ip);
            this.Controls.Add(this.label_密码);
            this.Controls.Add(this.label_账号);
            this.Controls.Add(this.label_目标IP);
            this.Controls.Add(this.button_退出);
            this.Controls.Add(this.button_登录);
            this.Controls.Add(this.richTextBox2);
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

        private System.Windows.Forms.Button button_退出;
        private System.Windows.Forms.Label label_目标IP;
        private System.Windows.Forms.Label label_账号;
        private System.Windows.Forms.Label label_密码;
        private System.Windows.Forms.TextBox textBox_ip;
        private System.Windows.Forms.TextBox textBox_账号;
        private System.Windows.Forms.TextBox textBox_密码;
        private System.Windows.Forms.RichTextBox richTextBox1;
        private System.Windows.Forms.Button button_发送认证信息;
        private System.Windows.Forms.Label label_状态;
        private System.Windows.Forms.RichTextBox richTextBox2;
        private System.Windows.Forms.Button button_获取IP地址;
        private System.Windows.Forms.Button button_初始化模板;
        private System.Windows.Forms.Label label_提示;
        private System.Windows.Forms.Button button_使用说明;
        public System.Windows.Forms.Button button_登录;
        private System.Windows.Forms.Button button_发送自定义消息;
        private System.Windows.Forms.NotifyIcon notifyIcon1;
        private System.Windows.Forms.ContextMenuStrip contextMenuStrip1;
        private System.Windows.Forms.ToolStripMenuItem 显示窗口ToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem 隐藏窗口ToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem 退出ToolStripMenuItem;
        private System.Windows.Forms.TextBox textBox_session_id;
        private System.Windows.Forms.Label label_session_id;
        private System.Windows.Forms.Button button_下线该ID;
        private System.Windows.Forms.Label label_last_session_id;
        private System.Windows.Forms.Label label_session_id_success;
        private System.Windows.Forms.Button button9;
        private System.Windows.Forms.Button button_rich2清空;
        private System.Windows.Forms.Label label_last_ip;
        private System.Windows.Forms.Label label_成功IP;
        private System.Windows.Forms.Button button_rich1清空;
        private System.Windows.Forms.CheckBox checkBox_保存账号;
        private System.Windows.Forms.Button button_加载上次成功id;
        private System.Windows.Forms.RadioButton radioButton_密码登录;
        private System.Windows.Forms.RadioButton radioButton_短信登录;
        private System.Windows.Forms.LinkLabel linkLabel_联系方式;
        private System.Windows.Forms.Button button_获取短信验证码;
        private System.Windows.Forms.RichTextBox richTextBox3;
        private System.Windows.Forms.Label label_验证短信;
        private System.Windows.Forms.Button button_查询学校;
        private System.Windows.Forms.Button button_rich3清空;
        private System.Windows.Forms.Button button_查询在线状态;
        private System.Windows.Forms.Button button_清空缓存;
        private System.Windows.Forms.CheckBox checkBox_保存密码;
        private System.Windows.Forms.Button button1;

        public System.EventHandler Form1_Load { get; set; }
    }
}

