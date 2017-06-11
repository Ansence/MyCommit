using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace WindowsFormsApplication1
{
    public partial class MyUsr : Form
    {
        public MyUsr()
        {
            this.MaximizeBox = false;
            InitializeComponent();
        }

        private void btn_Zhuce_Click(object sender, EventArgs e)
        {
           string zhanghao = txtbox_Zhanghao.Text.Trim().ToString();
            string mima = txtbox_Mima.Text.Trim().ToString();
            string name = txtbox_Name.Text.Trim().ToString();
            string xuehao = txtbox_Name.Text.Trim().ToString();

            Opertion bean = new Opertion();
            Boolean ok = bean.UserChanges(zhanghao, mima, name, xuehao);
            if (ok)
                MessageBox.Show("success");
            else
                MessageBox.Show("error");
        }

        private void MyUsr_Load(object sender, EventArgs e)
        {
            txtbox_Zhanghao.Text = Main.UsrZhanghao;
            txtbox_Mima.Text = Main.UsrMima;
            txtbox_Name.Text = Main.UsrName;
            txtbox_Xuehao.Text = Main.UsrXuehao;
            txtbox_Zhanghao.ReadOnly = true;
        }

        private void btn_Fanhui_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void MainForm_FormClosing(object sender, FormClosingEventArgs e)
        {

        }
    }
}
