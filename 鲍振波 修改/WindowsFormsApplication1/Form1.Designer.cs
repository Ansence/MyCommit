namespace WindowsFormsApplication1
{
    partial class Form1
    {
        /// <summary>
        /// 必需的设计器变量。
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// 清理所有正在使用的资源。
        /// </summary>
        /// <param name="disposing">如果应释放托管资源，为 true；否则为 false。</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows 窗体设计器生成的代码

        /// <summary>
        /// 设计器支持所需的方法 - 不要
        /// 使用代码编辑器修改此方法的内容。
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.btn_Zhuce = new System.Windows.Forms.Button();
            this.picture_Shouye = new System.Windows.Forms.PictureBox();
            this.btn_denglu = new System.Windows.Forms.Button();
            this.btn_Tuichu = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.picture_Shouye)).BeginInit();
            this.SuspendLayout();
            // 
            // btn_Zhuce
            // 
            this.btn_Zhuce.Location = new System.Drawing.Point(113, 328);
            this.btn_Zhuce.Name = "btn_Zhuce";
            this.btn_Zhuce.Size = new System.Drawing.Size(183, 68);
            this.btn_Zhuce.TabIndex = 0;
            this.btn_Zhuce.Text = "注册";
            this.btn_Zhuce.UseVisualStyleBackColor = true;
            this.btn_Zhuce.Click += new System.EventHandler(this.btn_Zhuce_Click);
            // 
            // picture_Shouye
            // 
            this.picture_Shouye.Dock = System.Windows.Forms.DockStyle.Top;
            this.picture_Shouye.Image = ((System.Drawing.Image)(resources.GetObject("picture_Shouye.Image")));
            this.picture_Shouye.Location = new System.Drawing.Point(0, 0);
            this.picture_Shouye.Name = "picture_Shouye";
            this.picture_Shouye.Size = new System.Drawing.Size(925, 196);
            this.picture_Shouye.SizeMode = System.Windows.Forms.PictureBoxSizeMode.CenterImage;
            this.picture_Shouye.TabIndex = 1;
            this.picture_Shouye.TabStop = false;
            // 
            // btn_denglu
            // 
            this.btn_denglu.Location = new System.Drawing.Point(371, 328);
            this.btn_denglu.Name = "btn_denglu";
            this.btn_denglu.Size = new System.Drawing.Size(183, 68);
            this.btn_denglu.TabIndex = 2;
            this.btn_denglu.Text = "登录";
            this.btn_denglu.UseVisualStyleBackColor = true;
            this.btn_denglu.Click += new System.EventHandler(this.btn_denglu_Click);
            // 
            // btn_Tuichu
            // 
            this.btn_Tuichu.Cursor = System.Windows.Forms.Cursors.Default;
            this.btn_Tuichu.Location = new System.Drawing.Point(629, 328);
            this.btn_Tuichu.Name = "btn_Tuichu";
            this.btn_Tuichu.Size = new System.Drawing.Size(183, 68);
            this.btn_Tuichu.TabIndex = 3;
            this.btn_Tuichu.Text = "退出";
            this.btn_Tuichu.UseVisualStyleBackColor = true;
            this.btn_Tuichu.Click += new System.EventHandler(this.btn_Tuichu_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(925, 522);
            this.Controls.Add(this.btn_Tuichu);
            this.Controls.Add(this.btn_denglu);
            this.Controls.Add(this.picture_Shouye);
            this.Controls.Add(this.btn_Zhuce);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.Name = "Form1";
            this.Text = "欢迎使用aaa图书管理系统";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.Form1_FormClosing);
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.picture_Shouye)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button btn_Zhuce;
        private System.Windows.Forms.PictureBox picture_Shouye;
        private System.Windows.Forms.Button btn_denglu;
        private System.Windows.Forms.Button btn_Tuichu;
    }
}

