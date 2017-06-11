namespace WindowsFormsApplication1
{
    partial class Denglu
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.lab_Zhanghao = new System.Windows.Forms.Label();
            this.txtbox_Zhanghao = new System.Windows.Forms.TextBox();
            this.txtbox_Mima = new System.Windows.Forms.TextBox();
            this.lab_Mima = new System.Windows.Forms.Label();
            this.txtbox_Xuehao = new System.Windows.Forms.TextBox();
            this.lab_Xuehao = new System.Windows.Forms.Label();
            this.rbtn_Yonghu = new System.Windows.Forms.RadioButton();
            this.rbtn_Guanliyuan = new System.Windows.Forms.RadioButton();
            this.btn_Denglu = new System.Windows.Forms.Button();
            this.btn_Fanhui = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // lab_Zhanghao
            // 
            this.lab_Zhanghao.AutoSize = true;
            this.lab_Zhanghao.Font = new System.Drawing.Font("宋体", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.lab_Zhanghao.Location = new System.Drawing.Point(166, 95);
            this.lab_Zhanghao.Name = "lab_Zhanghao";
            this.lab_Zhanghao.Size = new System.Drawing.Size(106, 19);
            this.lab_Zhanghao.TabIndex = 0;
            this.lab_Zhanghao.Text = "账    号：";
            this.lab_Zhanghao.Click += new System.EventHandler(this.lab_Zhanghao_Click);
            // 
            // txtbox_Zhanghao
            // 
            this.txtbox_Zhanghao.Location = new System.Drawing.Point(276, 92);
            this.txtbox_Zhanghao.Name = "txtbox_Zhanghao";
            this.txtbox_Zhanghao.Size = new System.Drawing.Size(176, 25);
            this.txtbox_Zhanghao.TabIndex = 1;
            // 
            // txtbox_Mima
            // 
            this.txtbox_Mima.Location = new System.Drawing.Point(276, 142);
            this.txtbox_Mima.Name = "txtbox_Mima";
            this.txtbox_Mima.Size = new System.Drawing.Size(176, 25);
            this.txtbox_Mima.TabIndex = 2;
            this.txtbox_Mima.UseSystemPasswordChar = true;
            // 
            // lab_Mima
            // 
            this.lab_Mima.AutoSize = true;
            this.lab_Mima.Font = new System.Drawing.Font("宋体", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.lab_Mima.Location = new System.Drawing.Point(166, 145);
            this.lab_Mima.Name = "lab_Mima";
            this.lab_Mima.Size = new System.Drawing.Size(106, 19);
            this.lab_Mima.TabIndex = 2;
            this.lab_Mima.Text = "密    码：";
            // 
            // txtbox_Xuehao
            // 
            this.txtbox_Xuehao.Location = new System.Drawing.Point(276, 195);
            this.txtbox_Xuehao.Name = "txtbox_Xuehao";
            this.txtbox_Xuehao.Size = new System.Drawing.Size(176, 25);
            this.txtbox_Xuehao.TabIndex = 3;
            // 
            // lab_Xuehao
            // 
            this.lab_Xuehao.AutoSize = true;
            this.lab_Xuehao.Font = new System.Drawing.Font("宋体", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.lab_Xuehao.Location = new System.Drawing.Point(166, 198);
            this.lab_Xuehao.Name = "lab_Xuehao";
            this.lab_Xuehao.Size = new System.Drawing.Size(106, 19);
            this.lab_Xuehao.TabIndex = 4;
            this.lab_Xuehao.Text = "学    号：";
            // 
            // rbtn_Yonghu
            // 
            this.rbtn_Yonghu.AutoSize = true;
            this.rbtn_Yonghu.Location = new System.Drawing.Point(204, 255);
            this.rbtn_Yonghu.Name = "rbtn_Yonghu";
            this.rbtn_Yonghu.Size = new System.Drawing.Size(58, 19);
            this.rbtn_Yonghu.TabIndex = 4;
            this.rbtn_Yonghu.Text = "用户";
            this.rbtn_Yonghu.UseVisualStyleBackColor = true;
            this.rbtn_Yonghu.CheckedChanged += new System.EventHandler(this.rbtn_Yonghu_CheckedChanged);
            // 
            // rbtn_Guanliyuan
            // 
            this.rbtn_Guanliyuan.AutoSize = true;
            this.rbtn_Guanliyuan.Checked = true;
            this.rbtn_Guanliyuan.Location = new System.Drawing.Point(303, 255);
            this.rbtn_Guanliyuan.Name = "rbtn_Guanliyuan";
            this.rbtn_Guanliyuan.Size = new System.Drawing.Size(73, 19);
            this.rbtn_Guanliyuan.TabIndex = 5;
            this.rbtn_Guanliyuan.TabStop = true;
            this.rbtn_Guanliyuan.Text = "管理员";
            this.rbtn_Guanliyuan.UseVisualStyleBackColor = true;
            this.rbtn_Guanliyuan.CheckedChanged += new System.EventHandler(this.rbtn_Guanliyuan_CheckedChanged);
            // 
            // btn_Denglu
            // 
            this.btn_Denglu.Location = new System.Drawing.Point(166, 298);
            this.btn_Denglu.Name = "btn_Denglu";
            this.btn_Denglu.Size = new System.Drawing.Size(96, 47);
            this.btn_Denglu.TabIndex = 6;
            this.btn_Denglu.Text = "登陆";
            this.btn_Denglu.UseVisualStyleBackColor = true;
            this.btn_Denglu.Click += new System.EventHandler(this.btn_Denglu_Click);
            // 
            // btn_Fanhui
            // 
            this.btn_Fanhui.Location = new System.Drawing.Point(346, 298);
            this.btn_Fanhui.Name = "btn_Fanhui";
            this.btn_Fanhui.Size = new System.Drawing.Size(96, 47);
            this.btn_Fanhui.TabIndex = 7;
            this.btn_Fanhui.Text = "返回";
            this.btn_Fanhui.UseVisualStyleBackColor = true;
            this.btn_Fanhui.Click += new System.EventHandler(this.btn_Fanhui_Click);
            // 
            // Denglu
            // 
            this.AcceptButton = this.btn_Denglu;
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(583, 431);
            this.Controls.Add(this.btn_Fanhui);
            this.Controls.Add(this.btn_Denglu);
            this.Controls.Add(this.rbtn_Guanliyuan);
            this.Controls.Add(this.rbtn_Yonghu);
            this.Controls.Add(this.txtbox_Xuehao);
            this.Controls.Add(this.lab_Xuehao);
            this.Controls.Add(this.txtbox_Mima);
            this.Controls.Add(this.lab_Mima);
            this.Controls.Add(this.txtbox_Zhanghao);
            this.Controls.Add(this.lab_Zhanghao);
            this.Name = "Denglu";
            this.Text = "登录";
            this.Load += new System.EventHandler(this.Denglu_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lab_Zhanghao;
        private System.Windows.Forms.TextBox txtbox_Zhanghao;
        private System.Windows.Forms.TextBox txtbox_Mima;
        private System.Windows.Forms.Label lab_Mima;
        private System.Windows.Forms.TextBox txtbox_Xuehao;
        private System.Windows.Forms.Label lab_Xuehao;
        private System.Windows.Forms.RadioButton rbtn_Yonghu;
        private System.Windows.Forms.RadioButton rbtn_Guanliyuan;
        private System.Windows.Forms.Button btn_Denglu;
        private System.Windows.Forms.Button btn_Fanhui;
    }
}