namespace WindowsFormsApplication1
{
    partial class MyUsr
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
            this.btn_Fanhui = new System.Windows.Forms.Button();
            this.btn_Zhuce = new System.Windows.Forms.Button();
            this.lab_Xingming = new System.Windows.Forms.Label();
            this.txtbox_Name = new System.Windows.Forms.TextBox();
            this.lab_Xuehao = new System.Windows.Forms.Label();
            this.txtbox_Xuehao = new System.Windows.Forms.TextBox();
            this.lab_Mima = new System.Windows.Forms.Label();
            this.txtbox_Mima = new System.Windows.Forms.TextBox();
            this.lab_Zhanghao = new System.Windows.Forms.Label();
            this.txtbox_Zhanghao = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // btn_Fanhui
            // 
            this.btn_Fanhui.Location = new System.Drawing.Point(266, 293);
            this.btn_Fanhui.Name = "btn_Fanhui";
            this.btn_Fanhui.Size = new System.Drawing.Size(95, 42);
            this.btn_Fanhui.TabIndex = 33;
            this.btn_Fanhui.Text = "返回";
            this.btn_Fanhui.UseVisualStyleBackColor = true;
            this.btn_Fanhui.Click += new System.EventHandler(this.btn_Fanhui_Click);
            // 
            // btn_Zhuce
            // 
            this.btn_Zhuce.Location = new System.Drawing.Point(117, 293);
            this.btn_Zhuce.Name = "btn_Zhuce";
            this.btn_Zhuce.Size = new System.Drawing.Size(95, 42);
            this.btn_Zhuce.TabIndex = 32;
            this.btn_Zhuce.Text = "修改";
            this.btn_Zhuce.UseVisualStyleBackColor = true;
            this.btn_Zhuce.Click += new System.EventHandler(this.btn_Zhuce_Click);
            // 
            // lab_Xingming
            // 
            this.lab_Xingming.AutoSize = true;
            this.lab_Xingming.Font = new System.Drawing.Font("宋体", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.lab_Xingming.Location = new System.Drawing.Point(106, 238);
            this.lab_Xingming.Name = "lab_Xingming";
            this.lab_Xingming.Size = new System.Drawing.Size(106, 19);
            this.lab_Xingming.TabIndex = 31;
            this.lab_Xingming.Text = "姓    名：";
            // 
            // txtbox_Name
            // 
            this.txtbox_Name.Location = new System.Drawing.Point(214, 237);
            this.txtbox_Name.Name = "txtbox_Name";
            this.txtbox_Name.Size = new System.Drawing.Size(161, 25);
            this.txtbox_Name.TabIndex = 30;
            // 
            // lab_Xuehao
            // 
            this.lab_Xuehao.AutoSize = true;
            this.lab_Xuehao.Font = new System.Drawing.Font("宋体", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.lab_Xuehao.Location = new System.Drawing.Point(106, 192);
            this.lab_Xuehao.Name = "lab_Xuehao";
            this.lab_Xuehao.Size = new System.Drawing.Size(106, 19);
            this.lab_Xuehao.TabIndex = 29;
            this.lab_Xuehao.Text = "学    号：";
            // 
            // txtbox_Xuehao
            // 
            this.txtbox_Xuehao.Location = new System.Drawing.Point(214, 192);
            this.txtbox_Xuehao.Name = "txtbox_Xuehao";
            this.txtbox_Xuehao.Size = new System.Drawing.Size(161, 25);
            this.txtbox_Xuehao.TabIndex = 28;
            // 
            // lab_Mima
            // 
            this.lab_Mima.AutoSize = true;
            this.lab_Mima.Font = new System.Drawing.Font("宋体", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.lab_Mima.Location = new System.Drawing.Point(106, 150);
            this.lab_Mima.Name = "lab_Mima";
            this.lab_Mima.Size = new System.Drawing.Size(106, 19);
            this.lab_Mima.TabIndex = 27;
            this.lab_Mima.Text = "密    码：";
            // 
            // txtbox_Mima
            // 
            this.txtbox_Mima.Location = new System.Drawing.Point(214, 147);
            this.txtbox_Mima.Name = "txtbox_Mima";
            this.txtbox_Mima.Size = new System.Drawing.Size(161, 25);
            this.txtbox_Mima.TabIndex = 26;
            this.txtbox_Mima.UseSystemPasswordChar = true;
            // 
            // lab_Zhanghao
            // 
            this.lab_Zhanghao.AutoSize = true;
            this.lab_Zhanghao.Font = new System.Drawing.Font("宋体", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.lab_Zhanghao.Location = new System.Drawing.Point(106, 104);
            this.lab_Zhanghao.Name = "lab_Zhanghao";
            this.lab_Zhanghao.Size = new System.Drawing.Size(106, 19);
            this.lab_Zhanghao.TabIndex = 25;
            this.lab_Zhanghao.Text = "账    号：";
            // 
            // txtbox_Zhanghao
            // 
            this.txtbox_Zhanghao.Location = new System.Drawing.Point(214, 101);
            this.txtbox_Zhanghao.Name = "txtbox_Zhanghao";
            this.txtbox_Zhanghao.Size = new System.Drawing.Size(161, 25);
            this.txtbox_Zhanghao.TabIndex = 24;
            // 
            // MyUsr
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(480, 437);
            this.Controls.Add(this.btn_Fanhui);
            this.Controls.Add(this.btn_Zhuce);
            this.Controls.Add(this.lab_Xingming);
            this.Controls.Add(this.txtbox_Name);
            this.Controls.Add(this.lab_Xuehao);
            this.Controls.Add(this.txtbox_Xuehao);
            this.Controls.Add(this.lab_Mima);
            this.Controls.Add(this.txtbox_Mima);
            this.Controls.Add(this.lab_Zhanghao);
            this.Controls.Add(this.txtbox_Zhanghao);
            this.Name = "MyUsr";
            this.Text = "修改我的信息";
            this.Load += new System.EventHandler(this.MyUsr_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btn_Fanhui;
        private System.Windows.Forms.Button btn_Zhuce;
        private System.Windows.Forms.Label lab_Xingming;
        private System.Windows.Forms.TextBox txtbox_Name;
        private System.Windows.Forms.Label lab_Xuehao;
        private System.Windows.Forms.TextBox txtbox_Xuehao;
        private System.Windows.Forms.Label lab_Mima;
        private System.Windows.Forms.TextBox txtbox_Mima;
        private System.Windows.Forms.Label lab_Zhanghao;
        private System.Windows.Forms.TextBox txtbox_Zhanghao;
    }
}