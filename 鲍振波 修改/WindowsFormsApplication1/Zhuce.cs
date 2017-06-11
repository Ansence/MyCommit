using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.Data.SqlClient;
using WindowsFormsApplication1.Properties;

namespace WindowsFormsApplication1
{
    public partial class Zhuce : Form
    {
        public Zhuce()
        {
            this.MaximizeBox = false;
            InitializeComponent();
        }

        private void lab_Zhanghao_Click(object sender, EventArgs e)
        {

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void Zhuce_Load(object sender, EventArgs e)
        {

        }

        private void btn_Zhuce_Click(object sender, EventArgs e)
        {

            //判定各种是否为空
            if (txtbox_Zhanghao.Text.Trim() == string.Empty)
            {
                MessageBox.Show("账号不能为空!");
                txtbox_Zhanghao.Focus();
            }
            else
            {
                if (txtbox_Mima.Text.Trim() == string.Empty)
                {
                    MessageBox.Show("密码不能为空！");
                    txtbox_Mima.Focus();
                }
                else 
                {
                    if (txtbox_Mima2.Text.Trim() == string.Empty)
                    {
                        MessageBox.Show("请再次输入密码");
                        txtbox_Mima2.Focus();
                    }
                    else
                    {
                        if (txtbox_Xuehao.Text.Trim() == string.Empty)
                        {
                            MessageBox.Show("学号不能为空!");
                            txtbox_Xuehao.Focus();
                        }
                        else
                        {
                            if (txtbox_Name.Text.Trim() == string.Empty)
                            {
                                MessageBox.Show("姓名不能为空！");
                                txtbox_Name.Focus();
                            }
                            else
                            {
                                string zhanghao = txtbox_Zhanghao.Text.Trim();
                                string mima1 = txtbox_Mima.Text.Trim();
                                string mima2 = txtbox_Mima2.Text.Trim();
                                string name = txtbox_Name.Text.Trim();
                                string xuehao = txtbox_Xuehao.Text.Trim();
                                if (mima1 != mima2)
                                {
                                    MessageBox.Show("两次输入的密码不相等，请重输!");
                                    txtbox_Mima2.Focus();
                                }
                                else
                                {
                                    Opertion bean = new Opertion();
                                    if (bean.UserAdd(zhanghao, mima1, name, xuehao))
                                    {
                                        MessageBox.Show("注册成功");
                                    }
                                    else
                                        MessageBox.Show("error注册失败!");    
                                }
                            }
                        }
                    }
                }  
            }
        }
        private void btn_Fanhui_Click(object sender, EventArgs e)
        {
            //thi
            this.Close();
            Form1.pForm1.Show();
        }

        private void MainForm_FormClosing(object sender, FormClosingEventArgs e)
        {
            if (e.CloseReason == CloseReason.UserClosing)
            {
                DialogResult r = MessageBox.Show("确定要退出?", "操作提示", MessageBoxButtons.OKCancel, MessageBoxIcon.Question);
                if (r != DialogResult.OK)
                {
                    e.Cancel = true;
                }
                else
                {
                    Form1.pForm1.Show();

                }
            }
        }

    }
}
