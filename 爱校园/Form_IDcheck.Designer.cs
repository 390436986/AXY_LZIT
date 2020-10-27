namespace 爱校园
{
    partial class Form_IDcheck
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
            this.textBox_ID = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.button_check = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // textBox_ID
            // 
            this.textBox_ID.Location = new System.Drawing.Point(12, 41);
            this.textBox_ID.Name = "textBox_ID";
            this.textBox_ID.PasswordChar = '*';
            this.textBox_ID.Size = new System.Drawing.Size(238, 21);
            this.textBox_ID.TabIndex = 0;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(12, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(161, 24);
            this.label1.TabIndex = 1;
            this.label1.Text = "未检测到认证信息，请验证ID\r\n该验证仅用于防止软件传播";
            // 
            // button_check
            // 
            this.button_check.AllowDrop = true;
            this.button_check.Location = new System.Drawing.Point(175, 9);
            this.button_check.Name = "button_check";
            this.button_check.Size = new System.Drawing.Size(75, 23);
            this.button_check.TabIndex = 2;
            this.button_check.Text = "验证";
            this.button_check.UseVisualStyleBackColor = true;
            this.button_check.Click += new System.EventHandler(this.button1_Click);
            // 
            // Form_IDcheck
            // 
            this.AcceptButton = this.button_check;
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(262, 78);
            this.Controls.Add(this.button_check);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.textBox_ID);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.SizableToolWindow;
            this.Name = "Form_IDcheck";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "ID验证";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.Form_IDcheck_FormClosing);
            this.Load += new System.EventHandler(this.Form_IDcheck_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox textBox_ID;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button button_check;
    }
}