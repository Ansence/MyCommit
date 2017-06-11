using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.Data.SqlClient;

namespace WindowsFormsApplication1
{
    public partial class huanShu : Form
    {
        private string constr = "server=.\\sqlexpress;database=MyLibrary;Integrated Security=SSPI";

        public huanShu()
        {
            this.MaximizeBox = false;
            InitializeComponent();
        }


        /*
         * 根据用户信息直接显示已有的借书记录
         */
        private void huanShu_Load(object sender, EventArgs e)
        {
            SqlConnection conn = new SqlConnection(constr);
            conn.Open();
            string sqlstr = "select * from Borrow";
            SqlDataAdapter da = new SqlDataAdapter(sqlstr, conn);
            DataSet ds = new DataSet();
            da.Fill(ds);
            dataGridView1.DataSource = ds.Tables[0];
            conn.Close();
        }

        private void btn_return_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        /*
         * 首先获取图书的信息，然后还书就是删除借书表的记录（这里需要书号，借阅人），然后改变图书的借出状态（书号）
         */
        private void btn_backBook_Click(object sender, EventArgs e)
        {
            int flag = 0;
            string bkNum = null;
            string usrName = null;
            //获取图书的信息
            for (int i = 0; i < dataGridView1.Rows.Count; i++)
            {
                if (dataGridView1.Rows[i].Selected == true)
                {
                    bkNum = dataGridView1.Rows[i].Cells[1].Value.ToString();
                    usrName = dataGridView1.Rows[i].Cells[2].Value.ToString();
                }
            }

            Opertion bean = new Opertion();
            Boolean ok1 = bean.BorrowDelete(bkNum, usrName);
            if (ok1)//如果记录删除成功
            {
                flag = 1;
                Boolean ok2 = bean.BkBuffUpdate(bkNum);
                if (ok2)
                    flag = 1;
                else
                    flag = 0;
            }
            else
            {
                flag = 0;
            }
            if (1 == flag)
                MessageBox.Show("还书成功");
            else
                MessageBox.Show("failed!");

            SqlConnection conn = new SqlConnection(constr);
            conn.Open();
            string sqlstr = "select * from Borrow";
            SqlDataAdapter da = new SqlDataAdapter(sqlstr, conn);
            DataSet ds = new DataSet();
            da.Fill(ds);
            dataGridView1.DataSource = ds.Tables[0];
            conn.Close();
        }

        /*
         * 延长还书日期
         */
        private void btn_Longdata_Click(object sender, EventArgs e)
        {
            string bkNum = null;
            //图书的信息
            for (int i = 0; i < dataGridView1.Rows.Count; i++)
            {
                if (dataGridView1.Rows[i].Selected == true)
                {
                    bkNum = dataGridView1.Rows[i].Cells[1].Value.ToString();
                }
            }
            if (bkNum != null)
            {
                Opertion bean = new Opertion();
                Boolean ok = bean.LongerData(bkNum);
                if (ok)
                {
                    MessageBox.Show("重借成功！");

                    SqlConnection conn = new SqlConnection(constr);
                    conn.Open();
                    string sqlstr = "select * from Borrow";
                    SqlDataAdapter da = new SqlDataAdapter(sqlstr, conn);
                    DataSet ds = new DataSet();
                    da.Fill(ds);
                    dataGridView1.DataSource = ds.Tables[0];
                    conn.Close();
                }
            }
            else
                MessageBox.Show("未选中！");
        }

        private void MainForm_FormClosing(object sender, FormClosingEventArgs e)
        {

        }
    }
}
