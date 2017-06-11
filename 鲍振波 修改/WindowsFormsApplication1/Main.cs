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


    public partial class Main : Form
    {
        public static Main f_m = null;

        Sousuo f_ss = null;
        public static string UsrName = null;
        public static string UsrMima = null;
        public static string UsrZhanghao = null;
        public static string UsrXuehao = null;
        static Users usr;

        public Main()
        {
            f_m = this;
            this.MaximizeBox = false;
            InitializeComponent();   
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {

        }

        private void btn_Sousuo_Click(object sender, EventArgs e)
        {
            string zhanghao = Denglu.UsrZhanghao;
            string xuehao = Denglu.UsrXuehao;

            usr = new Users();
            Opertion bean = new Opertion();
            Boolean ok = bean.ReadUsr(zhanghao, xuehao, usr);

            if (ok)
            {
                UsrZhanghao = usr.GetZhanghao();
                UsrMima = usr.GetMima();
                UsrName = usr.GetName();
                UsrXuehao = usr.GetXuehao();
            }

            this.Hide();
            f_ss = new Sousuo();
            f_ss.Show();
        }

        private void Main_Load(object sender, EventArgs e)
        {

        }

        /*
         * 还书跳转
         */
        private void btn_huanShu_Click(object sender, EventArgs e)
        {
            huanShu f_fs = new huanShu();
            f_fs.ShowDialog();
        }

        private void btn_tuiChu_Click(object sender, EventArgs e)
        {
            this.Close();
            Form1.pForm1.Show();
        }

        private void btn_UpdateUsr_Click(object sender, EventArgs e)
        {
            string zhanghao = Denglu.UsrZhanghao;
            string xuehao = Denglu.UsrXuehao;

            usr = new Users();
            Opertion bean = new Opertion();
            Boolean ok = bean.ReadUsr(zhanghao, xuehao, usr);

            if (ok)
            {
                UsrZhanghao = usr.GetZhanghao();
                UsrMima = usr.GetMima();
                UsrName = usr.GetName();
                UsrXuehao = usr.GetXuehao();
            }

            MyUsr f_mus = new MyUsr();
            f_mus.ShowDialog();


        }

        private void MainForm_FormClosing(object sender, FormClosingEventArgs e)
        {

        }
    }
}
