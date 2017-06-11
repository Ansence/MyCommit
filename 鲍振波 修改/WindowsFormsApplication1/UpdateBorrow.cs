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
    public partial class UpdateBorrow : Form
    {
        public UpdateBorrow()
        {
            this.MaximizeBox = false;
            InitializeComponent();
        }

        private void btn_return_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void UpdateBorrow_Load(object sender, EventArgs e)
        {
            txtbox_bkName.Text = Guanliyuan.Updatename;
            txtbox_bkNum.Text = Guanliyuan.Updatenum;
            txtbox_Data.Text = Guanliyuan.BorrowData;
            txtbox_usrName.Text = Guanliyuan.UsrName;
        }

        /*
         * 提交修改
         */
        private void btn_Update_Click(object sender, EventArgs e)
        {
            string bkName = txtbox_bkName.Text.Trim().ToString();
            string bkNum = txtbox_bkNum.Text.Trim().ToString();
            string usrName = txtbox_usrName.Text.Trim().ToString();
            string data = txtbox_Data.Text.Trim().ToString();

            Opertion bean = new Opertion();
            Boolean ok = bean.BorrowUpdate(bkName, bkNum, data, usrName);
            if (ok)
            {
                MessageBox.Show("update success!~");
                this.Close();
            }
            else
                MessageBox.Show("error");
        }

        private void MainForm_FormClosing(object sender, FormClosingEventArgs e)
        {

        }
    }
}
