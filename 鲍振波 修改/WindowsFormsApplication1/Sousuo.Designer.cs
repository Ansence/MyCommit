namespace WindowsFormsApplication1
{
    partial class Sousuo
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
            this.btn_ReadAll = new System.Windows.Forms.Button();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.btn_ssLX = new System.Windows.Forms.Button();
            this.txtbox_SM = new System.Windows.Forms.TextBox();
            this.btn_ssSM = new System.Windows.Forms.Button();
            this.txtbox_bkNum = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.btn_js = new System.Windows.Forms.Button();
            this.txtB_Zz = new System.Windows.Forms.TextBox();
            this.btn_Zz = new System.Windows.Forms.Button();
            this.cbox_lx = new System.Windows.Forms.ComboBox();
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.返回ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // btn_ReadAll
            // 
            this.btn_ReadAll.Location = new System.Drawing.Point(22, 64);
            this.btn_ReadAll.Name = "btn_ReadAll";
            this.btn_ReadAll.Size = new System.Drawing.Size(226, 42);
            this.btn_ReadAll.TabIndex = 0;
            this.btn_ReadAll.Text = "查看全部";
            this.btn_ReadAll.UseVisualStyleBackColor = true;
            this.btn_ReadAll.Click += new System.EventHandler(this.btn_ReadAll_Click);
            // 
            // dataGridView1
            // 
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(271, 30);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.RowTemplate.Height = 27;
            this.dataGridView1.Size = new System.Drawing.Size(702, 349);
            this.dataGridView1.TabIndex = 1;
            // 
            // btn_ssLX
            // 
            this.btn_ssLX.Font = new System.Drawing.Font("宋体", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.btn_ssLX.Location = new System.Drawing.Point(142, 132);
            this.btn_ssLX.Name = "btn_ssLX";
            this.btn_ssLX.Size = new System.Drawing.Size(106, 26);
            this.btn_ssLX.TabIndex = 3;
            this.btn_ssLX.Text = "按类型搜索";
            this.btn_ssLX.UseVisualStyleBackColor = true;
            this.btn_ssLX.Click += new System.EventHandler(this.btn_ssLX_Click);
            // 
            // txtbox_SM
            // 
            this.txtbox_SM.Location = new System.Drawing.Point(23, 184);
            this.txtbox_SM.Name = "txtbox_SM";
            this.txtbox_SM.Size = new System.Drawing.Size(98, 25);
            this.txtbox_SM.TabIndex = 4;
            // 
            // btn_ssSM
            // 
            this.btn_ssSM.Location = new System.Drawing.Point(142, 187);
            this.btn_ssSM.Name = "btn_ssSM";
            this.btn_ssSM.Size = new System.Drawing.Size(104, 26);
            this.btn_ssSM.TabIndex = 5;
            this.btn_ssSM.Text = "按书名搜索";
            this.btn_ssSM.UseVisualStyleBackColor = true;
            this.btn_ssSM.Click += new System.EventHandler(this.btn_ssSM_Click);
            // 
            // txtbox_bkNum
            // 
            this.txtbox_bkNum.Location = new System.Drawing.Point(126, 287);
            this.txtbox_bkNum.Name = "txtbox_bkNum";
            this.txtbox_bkNum.Size = new System.Drawing.Size(119, 25);
            this.txtbox_bkNum.TabIndex = 6;
            this.txtbox_bkNum.TextChanged += new System.EventHandler(this.txtbox_sh_TextChanged);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(22, 291);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(97, 15);
            this.label1.TabIndex = 7;
            this.label1.Text = "请输入书号：";
            // 
            // btn_js
            // 
            this.btn_js.Location = new System.Drawing.Point(37, 331);
            this.btn_js.Name = "btn_js";
            this.btn_js.Size = new System.Drawing.Size(207, 28);
            this.btn_js.TabIndex = 8;
            this.btn_js.Text = "我要借书";
            this.btn_js.UseVisualStyleBackColor = true;
            this.btn_js.Click += new System.EventHandler(this.btn_js_Click);
            // 
            // txtB_Zz
            // 
            this.txtB_Zz.Location = new System.Drawing.Point(22, 235);
            this.txtB_Zz.Name = "txtB_Zz";
            this.txtB_Zz.Size = new System.Drawing.Size(98, 25);
            this.txtB_Zz.TabIndex = 9;
            // 
            // btn_Zz
            // 
            this.btn_Zz.Location = new System.Drawing.Point(142, 238);
            this.btn_Zz.Name = "btn_Zz";
            this.btn_Zz.Size = new System.Drawing.Size(104, 26);
            this.btn_Zz.TabIndex = 10;
            this.btn_Zz.Text = "按作者搜索";
            this.btn_Zz.UseVisualStyleBackColor = true;
            this.btn_Zz.Click += new System.EventHandler(this.btn_Zz_Click);
            // 
            // cbox_lx
            // 
            this.cbox_lx.FormattingEnabled = true;
            this.cbox_lx.Items.AddRange(new object[] {
            "计算机",
            "自然科学",
            "人文",
            "历史",
            "物理",
            "小说"});
            this.cbox_lx.Location = new System.Drawing.Point(23, 135);
            this.cbox_lx.Name = "cbox_lx";
            this.cbox_lx.Size = new System.Drawing.Size(99, 23);
            this.cbox_lx.TabIndex = 11;
            // 
            // menuStrip1
            // 
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.返回ToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(985, 28);
            this.menuStrip1.TabIndex = 12;
            this.menuStrip1.Text = "menuStrip1";
            this.menuStrip1.ItemClicked += new System.Windows.Forms.ToolStripItemClickedEventHandler(this.menuStrip1_ItemClicked);
            // 
            // 返回ToolStripMenuItem
            // 
            this.返回ToolStripMenuItem.Name = "返回ToolStripMenuItem";
            this.返回ToolStripMenuItem.Size = new System.Drawing.Size(51, 24);
            this.返回ToolStripMenuItem.Text = "返回";
            this.返回ToolStripMenuItem.Click += new System.EventHandler(this.返回ToolStripMenuItem_Click);
            // 
            // Sousuo
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(985, 391);
            this.Controls.Add(this.cbox_lx);
            this.Controls.Add(this.btn_Zz);
            this.Controls.Add(this.txtB_Zz);
            this.Controls.Add(this.btn_js);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.txtbox_bkNum);
            this.Controls.Add(this.btn_ssSM);
            this.Controls.Add(this.txtbox_SM);
            this.Controls.Add(this.btn_ssLX);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.btn_ReadAll);
            this.Controls.Add(this.menuStrip1);
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "Sousuo";
            this.Text = "我要借书";
            this.Load += new System.EventHandler(this.Sousuo_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btn_ReadAll;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.Button btn_ssLX;
        private System.Windows.Forms.TextBox txtbox_SM;
        private System.Windows.Forms.Button btn_ssSM;
        private System.Windows.Forms.TextBox txtbox_bkNum;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btn_js;
        private System.Windows.Forms.TextBox txtB_Zz;
        private System.Windows.Forms.Button btn_Zz;
        private System.Windows.Forms.ComboBox cbox_lx;
        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem 返回ToolStripMenuItem;
    }
}