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
    public partial class UpdateBooks : Form
    {
        public UpdateBooks()
        {
            this.MaximizeBox = false;
            InitializeComponent();
        }

        private void label5_Click(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        /*
         * 提交修改
         */
        private void btn_tj_Click(object sender, EventArgs e)
        {
            int flag = Guanliyuan.UpdateFlag;
            if (flag == 1)//增加
            {
                string name = txt_bkName.Text.Trim().ToString();
                string number = txt_bkNum.Text.Trim().ToString();
                string kind = cbb_bkKind.Text.Trim().ToString();
                string auther = txtbkAuther.Text.Trim().ToString();
                string buff = cbbox_bkBuff.Text.ToString();

                Console.WriteLine("name = " + name + ",number =" + number + ",kind = " + kind + ",auther = " + auther + ".buff = " + buff);

                Opertion bean = new Opertion();
                Boolean ok = bean.BookAdd(name, number, kind, buff, auther);
                if (ok)
                {
                    MessageBox.Show("添加成功！");
                }
                else
                    MessageBox.Show("error!");
            }
            else if(2 == flag)//修改
            {
                string name = txt_bkName.Text.Trim().ToString();
                string number = txt_bkNum.Text.Trim().ToString();
                string kind = cbb_bkKind.Text.Trim().ToString();
                string auther = txtbkAuther.Text.Trim().ToString();
                string buff = cbbox_bkBuff.Text.ToString();

                Console.WriteLine("name = " + name + ",number =" + number + ",kind = " + kind + ",auther = " + auther + ".buff = " + buff);
                
                Opertion bean = new Opertion();
                Boolean ok = bean.BookUpdateByNumber(name,number, kind, buff, auther);
                if (ok)
                {
                    MessageBox.Show("修改成功！");
                }
                else
                    MessageBox.Show("error!");
            }
        }

        /*
         * 关闭当前窗口
         */
        private void btn_return_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        /*
         * 加载文本信息
         */
        private void UpdateBooks_Load(object sender, EventArgs e)
        {
            if (2 == Guanliyuan.UpdateFlag)
            {
                txt_bkName.Text = Guanliyuan.Updatename;
                txt_bkNum.Text = Guanliyuan.Updatenum;
                txtbkAuther.Text = Guanliyuan.Updateauther;
                string kind = Guanliyuan.Updatekind;
                string buff = Guanliyuan.Updatebuff;
                int index = 0;
                for (int i = 0; i < cbb_bkKind.Items.Count; ++i)
                {
                    if (kind == cbb_bkKind.Items[i].ToString())
                        index = i;
                }
                cbb_bkKind.Text = cbb_bkKind.Items[index].ToString();
                for (int i = 0; i < cbbox_bkBuff.Items.Count; ++i)
                {
                    if (kind == cbbox_bkBuff.Items[i].ToString())
                        index = i;
                }
                cbbox_bkBuff.Text = cbbox_bkBuff.Items[index].ToString();
            }
        }

        private void MainForm_FormClosing(object sender, FormClosingEventArgs e)
        {

        }
    }
}
