using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.Threading;


namespace WindowsFormsApplication1
{
    public partial class Form1 : Form
    {
        private Zhuce f_zc = null;
        public static Form1 pForm1 = null;
        Denglu f_dl = null;
        public Form1()
        {
            pForm1 = this;
            this.MaximizeBox = false;
          InitializeComponent();
        }


        private void Form1_Load(object sender, EventArgs e)
        {

        }


        private void btn_Zhuce_Click(object sender, EventArgs e)
        {
            

            f_zc = new Zhuce();
            this.Hide();
            f_zc.Show();
            
        }

        private void btn_Tuichu_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btn_denglu_Click(object sender, EventArgs e)
        {
            f_dl = new Denglu();
            this.Hide();
            f_dl.Show();
        }

        private void Form1_FormClosing(object sender, FormClosingEventArgs e)
        {
            if (e.CloseReason == CloseReason.UserClosing)
            {
                DialogResult r = MessageBox.Show("确定要退出程序?", "操作提示", MessageBoxButtons.OKCancel, MessageBoxIcon.Question);
                if (r != DialogResult.OK)
                {
                    e.Cancel = true;
                }
                else
                {
                    MessageBox.Show("谢谢使用aaa图书管理系统！");
                    Application.Exit();
                }
            }
        }

    }
}
