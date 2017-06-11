namespace WindowsFormsApplication1
{
    partial class Main
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Main));
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.btn_huanShu = new System.Windows.Forms.Button();
            this.btn_Sousuo = new System.Windows.Forms.Button();
            this.btn_tuiChu = new System.Windows.Forms.Button();
            this.btn_UpdateUsr = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(-2, 0);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(700, 196);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox1.TabIndex = 0;
            this.pictureBox1.TabStop = false;
            this.pictureBox1.Click += new System.EventHandler(this.pictureBox1_Click);
            // 
            // btn_huanShu
            // 
            this.btn_huanShu.Location = new System.Drawing.Point(202, 276);
            this.btn_huanShu.Name = "btn_huanShu";
            this.btn_huanShu.Size = new System.Drawing.Size(144, 60);
            this.btn_huanShu.TabIndex = 1;
            this.btn_huanShu.Text = "我要还书";
            this.btn_huanShu.UseVisualStyleBackColor = true;
            this.btn_huanShu.Click += new System.EventHandler(this.btn_huanShu_Click);
            // 
            // btn_Sousuo
            // 
            this.btn_Sousuo.Location = new System.Drawing.Point(40, 276);
            this.btn_Sousuo.Name = "btn_Sousuo";
            this.btn_Sousuo.Size = new System.Drawing.Size(144, 60);
            this.btn_Sousuo.TabIndex = 3;
            this.btn_Sousuo.Text = "我要借书";
            this.btn_Sousuo.UseVisualStyleBackColor = true;
            this.btn_Sousuo.Click += new System.EventHandler(this.btn_Sousuo_Click);
            // 
            // btn_tuiChu
            // 
            this.btn_tuiChu.Location = new System.Drawing.Point(526, 276);
            this.btn_tuiChu.Name = "btn_tuiChu";
            this.btn_tuiChu.Size = new System.Drawing.Size(144, 60);
            this.btn_tuiChu.TabIndex = 4;
            this.btn_tuiChu.Text = "退出登录";
            this.btn_tuiChu.UseVisualStyleBackColor = true;
            this.btn_tuiChu.Click += new System.EventHandler(this.btn_tuiChu_Click);
            // 
            // btn_UpdateUsr
            // 
            this.btn_UpdateUsr.Location = new System.Drawing.Point(364, 276);
            this.btn_UpdateUsr.Name = "btn_UpdateUsr";
            this.btn_UpdateUsr.Size = new System.Drawing.Size(144, 60);
            this.btn_UpdateUsr.TabIndex = 5;
            this.btn_UpdateUsr.Text = "修改个人信息";
            this.btn_UpdateUsr.UseVisualStyleBackColor = true;
            this.btn_UpdateUsr.Click += new System.EventHandler(this.btn_UpdateUsr_Click);
            // 
            // Main
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(698, 423);
            this.Controls.Add(this.btn_UpdateUsr);
            this.Controls.Add(this.btn_tuiChu);
            this.Controls.Add(this.btn_Sousuo);
            this.Controls.Add(this.btn_huanShu);
            this.Controls.Add(this.pictureBox1);
            this.Name = "Main";
            this.Text = "我的主页";
            this.Load += new System.EventHandler(this.Main_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Button btn_huanShu;
        private System.Windows.Forms.Button btn_Sousuo;
        private System.Windows.Forms.Button btn_tuiChu;
        private System.Windows.Forms.Button btn_UpdateUsr;
    }
}