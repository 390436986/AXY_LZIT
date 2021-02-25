using Ischool;
using System;
using System.Collections;
using System.Windows.Forms;

namespace 爱校园
{
    public partial class Form_IDcheck : Form
    {
        public Form_IDcheck()
        {
            InitializeComponent();
        }

        private void Form_IDcheck_Load(object sender, EventArgs e)
        {
            if (Settings1.Default.IDcheck == true)
            {
                this.Visible = false;
                new Form_main().ShowDialog();
            }
        }
        private void button1_Click(object sender, EventArgs e)
        {
            string[] ID = {"18394096016","Bystander","Bystander9527","bystander","bystander9527",
                            "3276735002","lzit","LZIT","sbischool","ID","id","419611","946991","9527","zyp" };
            bool exist = ((IList)ID).Contains(textBox_ID.Text);
            if (exist == true)
            {
                this.Visible = false;
                new Form_main().ShowDialog();
                Settings1.Default.IDcheck = true;
                Settings1.Default.Save();
                
            }
            /* if (textBox_ID.Text != "")
            {
                for (int i = 0; i <= ID.Length; i++)
                {
                    if (textBox_ID.Text == ID[i])
                    {
                        this.Close();
                        new Form_main().ShowDialog();
                        Settings1.Default.IDcheck = true;
                        Settings1.Default.Save();
                    }
                }
            }
            else
                MessageBox.Show("请输入ID！");*/
        }

        private void Form_IDcheck_FormClosing(object sender, FormClosingEventArgs e)
        {
            Application.Exit();
        }
    }
}
