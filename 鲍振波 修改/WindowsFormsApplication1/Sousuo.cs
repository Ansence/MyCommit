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
    public partial class Sousuo : Form
    {
        private static string constr = "server=.\\sqlexpress;database=MyLibrary;Integrated Security=SSPI";
     
        Opertion bean = new Opertion();
        SqlConnection conn = new SqlConnection(constr);
        string usrName = Main.UsrName;

        public Sousuo()
        {
            this.MaximizeBox = false;
            InitializeComponent();

        }

        private void btn_ReadAll_Click(object sender, EventArgs e)
        {
            conn.Open();
            string sqlstr = "select * from Books";
            SqlDataAdapter da = new SqlDataAdapter(sqlstr, conn);
            DataSet ds = new DataSet();
            da.Fill(ds);
            dataGridView1.DataSource = ds.Tables[0];
            dataGridView1.Columns[0].HeaderCell.Value = "书名";
            dataGridView1.Columns[1].HeaderCell.Value = "书号";
            dataGridView1.Columns[2].HeaderCell.Value = "状态";
            dataGridView1.Columns[3].HeaderCell.Value = "类型";
            dataGridView1.Columns[4].HeaderCell.Value = "作者";
            conn.Close();
        }

        private void listBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        /*
         * 类型搜索图书
         */
        private void btn_ssLX_Click(object sender, EventArgs e)
        {
            if (cbox_lx.SelectedItem != null)
            {
                string lx = cbox_lx.SelectedItem.ToString();
                Console.WriteLine("点击了" + lx);
                conn.Open();
                string sqlstr = "select * from Books where Bkinds = '" + lx + "'";
                SqlDataAdapter da = new SqlDataAdapter(sqlstr, conn);
                DataSet ds = new DataSet();
                da.Fill(ds);
                dataGridView1.DataSource = ds.Tables[0];
                dataGridView1.Columns[0].HeaderCell.Value = "书名";
                dataGridView1.Columns[1].HeaderCell.Value = "书号";
                dataGridView1.Columns[2].HeaderCell.Value = "状态";
                dataGridView1.Columns[3].HeaderCell.Value = "类型";
                dataGridView1.Columns[4].HeaderCell.Value = "作者";
                conn.Close();
            }
            else 
            {
                MessageBox.Show("请选择类型");
                cbox_lx.Focus();
            }

        }


        /*
         * 书名搜索
         */
        private void btn_ssSM_Click(object sender, EventArgs e)
        {
            if (txtbox_SM.Text.Trim() != string.Empty)
            {
                string sm = txtbox_SM.Text.ToString();
                conn.Open();
                string sqlstr = "select * from Books where Bname = '" + sm + "'";
                SqlDataAdapter da = new SqlDataAdapter(sqlstr, conn);
                DataSet ds = new DataSet();
                da.Fill(ds);
                dataGridView1.DataSource = ds.Tables[0];
                dataGridView1.Columns[0].HeaderCell.Value = "书名";
                dataGridView1.Columns[1].HeaderCell.Value = "书号";
                dataGridView1.Columns[2].HeaderCell.Value = "状态";
                dataGridView1.Columns[3].HeaderCell.Value = "类型";
                dataGridView1.Columns[4].HeaderCell.Value = "作者";
                conn.Close();
            }
            else
            {
                MessageBox.Show("书名不能为空");
                txtbox_SM.Focus();
            }

        }


        /*
         * 根据书号借书
         */
        private void btn_js_Click(object sender, EventArgs e)
        {
            if (txtbox_bkNum.Text.Trim() != string.Empty)
            {
                int flag = -1;
                string sh = txtbox_bkNum.Text.ToString();
                Opertion bean = new Opertion();
                Boolean ok1 = bean.Borrows(sh);
                if (ok1)
                {
                    flag = 1;
                    string bkName = bean.GetBkName(sh);
                    Console.WriteLine("bkName = " + bkName);
                    Boolean ok2 = bean.BorrowRecord(sh, bkName, DateTime.Now.ToString("yyyy-MM-dd"), usrName);
                    if (ok2)
                    {
                        flag = 1;
                        if (bean.BkBuffChange(sh))
                            flag = 1;
                        else
                            flag = -1;
                    }
                    else
                        flag = -1;
                }
                else
                    flag = -1;

                if (flag == 1)
                    MessageBox.Show("success");
                else
                    MessageBox.Show("error");
            }
            else
            {
                MessageBox.Show("书号不能为空");
                txtbox_SM.Focus();
            }
        }

        private void txtbox_sh_TextChanged(object sender, EventArgs e)
        {

        }


        /*
         * 按作者搜索
         */
        private void btn_Zz_Click(object sender, EventArgs e)
        {
            if (txtB_Zz.Text.Trim() != string.Empty)
            {
                string zz = txtB_Zz.Text.Trim().ToString();
                conn.Open();
                string sqlstr = "select * from Books where Bauther = '" + zz + "'";
                SqlDataAdapter da = new SqlDataAdapter(sqlstr, conn);
                DataSet ds = new DataSet();
                da.Fill(ds);
                dataGridView1.DataSource = ds.Tables[0];
                dataGridView1.Columns[0].HeaderCell.Value = "书名";
                dataGridView1.Columns[1].HeaderCell.Value = "书号";
                dataGridView1.Columns[2].HeaderCell.Value = "状态";
                dataGridView1.Columns[3].HeaderCell.Value = "类型";
                dataGridView1.Columns[4].HeaderCell.Value = "作者";
                conn.Close();
            }
            else
            {
                MessageBox.Show("请输入作者名!");
                txtB_Zz.Focus();
            }

        }

        private void Sousuo_Load(object sender, EventArgs e)
        {

        }

        private void 返回ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Close();
            Main.f_m.Show();
        }

        private void menuStrip1_ItemClicked(object sender, ToolStripItemClickedEventArgs e)
        {

        }

        private void MainForm_FormClosing(object sender, FormClosingEventArgs e)
        {

        }
    }
}
