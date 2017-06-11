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
    public partial class UpdateUser : Form
    {
        public UpdateUser()
        {
            this.MaximizeBox = false;
            InitializeComponent();

        }

        private void txtbox_Name_TextChanged(object sender, EventArgs e)
        {

        }

        private void UpdateUser_Load(object sender, EventArgs e)
        {


            txtbox_Name.Text = Guanliyuan.Updatename;
            txtbox_Zhanghao.Text = Guanliyuan.Updatezhanghao;
            txtbox_Mima.Text = Guanliyuan.Updatemima;
            txtbox_Xuehao.Text = Guanliyuan.Updatenum;

            txtbox_Zhanghao.ReadOnly = true;
            txtbox_Mima.ReadOnly = true;
        }

        private void btn_Zhuce_Click(object sender, EventArgs e)
        {
            string zhanghao = txtbox_Zhanghao.Text.Trim().ToString();
            string mima = txtbox_Mima.Text.Trim().ToString();
            string xuehao = txtbox_Xuehao.Text.Trim().ToString();
            string name = txtbox_Name.Text.Trim().ToString();

            Opertion bean = new Opertion();
            Boolean ok = bean.UserChanges(zhanghao, mima, name, xuehao);
            if (ok)
            {
                MessageBox.Show("Update success!");
                this.Close();
            }
            else
                MessageBox.Show("error");
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
