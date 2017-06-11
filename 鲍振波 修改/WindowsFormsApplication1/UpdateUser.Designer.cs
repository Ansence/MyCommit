namespace WindowsFormsApplication1
{
    partial class UpdateUser
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
            this.btn_Fanhui.Location = new System.Drawing.Point(253, 272);
            this.btn_Fanhui.Name = "btn_Fanhui";
            this.btn_Fanhui.Size = new System.Drawing.Size(95, 42);
            this.btn_Fanhui.TabIndex = 23;
            this.btn_Fanhui.Text = "返回";
            this.btn_Fanhui.UseVisualStyleBackColor = true;
            this.btn_Fanhui.Click += new System.EventHandler(this.btn_Fanhui_Click);
            // 
            // btn_Zhuce
            // 
            this.btn_Zhuce.Location = new System.Drawing.Point(104, 272);
            this.btn_Zhuce.Name = "btn_Zhuce";
            this.btn_Zhuce.Size = new System.Drawing.Size(95, 42);
            this.btn_Zhuce.TabIndex = 22;
            this.btn_Zhuce.Text = "修改";
            this.btn_Zhuce.UseVisualStyleBackColor = true;
            this.btn_Zhuce.Click += new System.EventHandler(this.btn_Zhuce_Click);
            // 
            // lab_Xingming
            // 
            this.lab_Xingming.AutoSize = true;
            this.lab_Xingming.Font = new System.Drawing.Font("宋体", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.lab_Xingming.Location = new System.Drawing.Point(93, 217);
            this.lab_Xingming.Name = "lab_Xingming";
            this.lab_Xingming.Size = new System.Drawing.Size(106, 19);
            this.lab_Xingming.TabIndex = 21;
            this.lab_Xingming.Text = "姓    名：";
            // 
            // txtbox_Name
            // 
            this.txtbox_Name.Location = new System.Drawing.Point(201, 216);
            this.txtbox_Name.Name = "txtbox_Name";
            this.txtbox_Name.Size = new System.Drawing.Size(161, 25);
            this.txtbox_Name.TabIndex = 20;
            this.txtbox_Name.TextChanged += new System.EventHandler(this.txtbox_Name_TextChanged);
            // 
            // lab_Xuehao
            // 
            this.lab_Xuehao.AutoSize = true;
            this.lab_Xuehao.Font = new System.Drawing.Font("宋体", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.lab_Xuehao.Location = new System.Drawing.Point(93, 171);
            this.lab_Xuehao.Name = "lab_Xuehao";
            this.lab_Xuehao.Size = new System.Drawing.Size(106, 19);
            this.lab_Xuehao.TabIndex = 19;
            this.lab_Xuehao.Text = "学    号：";
            // 
            // txtbox_Xuehao
            // 
            this.txtbox_Xuehao.Location = new System.Drawing.Point(201, 171);
            this.txtbox_Xuehao.Name = "txtbox_Xuehao";
            this.txtbox_Xuehao.Size = new System.Drawing.Size(161, 25);
            this.txtbox_Xuehao.TabIndex = 18;
            // 
            // lab_Mima
            // 
            this.lab_Mima.AutoSize = true;
            this.lab_Mima.Font = new System.Drawing.Font("宋体", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.lab_Mima.Location = new System.Drawing.Point(93, 129);
            this.lab_Mima.Name = "lab_Mima";
            this.lab_Mima.Size = new System.Drawing.Size(106, 19);
            this.lab_Mima.TabIndex = 15;
            this.lab_Mima.Text = "密    码：";
            // 
            // txtbox_Mima
            // 
            this.txtbox_Mima.Location = new System.Drawing.Point(201, 126);
            this.txtbox_Mima.Name = "txtbox_Mima";
            this.txtbox_Mima.Size = new System.Drawing.Size(161, 25);
            this.txtbox_Mima.TabIndex = 14;
            this.txtbox_Mima.UseSystemPasswordChar = true;
            // 
            // lab_Zhanghao
            // 
            this.lab_Zhanghao.AutoSize = true;
            this.lab_Zhanghao.Font = new System.Drawing.Font("宋体", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.lab_Zhanghao.Location = new System.Drawing.Point(93, 83);
            this.lab_Zhanghao.Name = "lab_Zhanghao";
            this.lab_Zhanghao.Size = new System.Drawing.Size(106, 19);
            this.lab_Zhanghao.TabIndex = 13;
            this.lab_Zhanghao.Text = "账    号：";
            // 
            // txtbox_Zhanghao
            // 
            this.txtbox_Zhanghao.Location = new System.Drawing.Point(201, 80);
            this.txtbox_Zhanghao.Name = "txtbox_Zhanghao";
            this.txtbox_Zhanghao.Size = new System.Drawing.Size(161, 25);
            this.txtbox_Zhanghao.TabIndex = 12;
            // 
            // UpdateUser
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(455, 360);
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
            this.Name = "UpdateUser";
            this.Text = "用户信息更新";
            this.Load += new System.EventHandler(this.UpdateUser_Load);
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