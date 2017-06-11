namespace WindowsFormsApplication1
{
    partial class Guanliyuan
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
            this.btn_ReadAllUser = new System.Windows.Forms.Button();
            this.btn_ReadAllBook = new System.Windows.Forms.Button();
            this.btn_ReadAllBorrow = new System.Windows.Forms.Button();
            this.btn_DelUser = new System.Windows.Forms.Button();
            this.btn_UpUsr = new System.Windows.Forms.Button();
            this.btn_BkDelete = new System.Windows.Forms.Button();
            this.btn_AddBk = new System.Windows.Forms.Button();
            this.btn_updateBk = new System.Windows.Forms.Button();
            this.btn_DelBorr = new System.Windows.Forms.Button();
            this.btn_UpdateBor = new System.Windows.Forms.Button();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.返回ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.lab_code = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // btn_ReadAllUser
            // 
            this.btn_ReadAllUser.Location = new System.Drawing.Point(21, 32);
            this.btn_ReadAllUser.Name = "btn_ReadAllUser";
            this.btn_ReadAllUser.Size = new System.Drawing.Size(205, 50);
            this.btn_ReadAllUser.TabIndex = 0;
            this.btn_ReadAllUser.Text = "查看全部用户";
            this.btn_ReadAllUser.UseVisualStyleBackColor = true;
            this.btn_ReadAllUser.Click += new System.EventHandler(this.btn_ReadAllUser_Click);
            // 
            // btn_ReadAllBook
            // 
            this.btn_ReadAllBook.Location = new System.Drawing.Point(21, 200);
            this.btn_ReadAllBook.Name = "btn_ReadAllBook";
            this.btn_ReadAllBook.Size = new System.Drawing.Size(205, 50);
            this.btn_ReadAllBook.TabIndex = 1;
            this.btn_ReadAllBook.Text = "查看全部图书";
            this.btn_ReadAllBook.UseVisualStyleBackColor = true;
            this.btn_ReadAllBook.Click += new System.EventHandler(this.btn_ReadAllBook_Click);
            // 
            // btn_ReadAllBorrow
            // 
            this.btn_ReadAllBorrow.Location = new System.Drawing.Point(21, 424);
            this.btn_ReadAllBorrow.Name = "btn_ReadAllBorrow";
            this.btn_ReadAllBorrow.Size = new System.Drawing.Size(205, 50);
            this.btn_ReadAllBorrow.TabIndex = 2;
            this.btn_ReadAllBorrow.Text = "查看全部借阅信息";
            this.btn_ReadAllBorrow.UseVisualStyleBackColor = true;
            this.btn_ReadAllBorrow.Click += new System.EventHandler(this.btn_ReadAllBorrow_Click);
            // 
            // btn_DelUser
            // 
            this.btn_DelUser.Location = new System.Drawing.Point(21, 88);
            this.btn_DelUser.Name = "btn_DelUser";
            this.btn_DelUser.Size = new System.Drawing.Size(205, 50);
            this.btn_DelUser.TabIndex = 3;
            this.btn_DelUser.Text = "删除用户信息";
            this.btn_DelUser.UseVisualStyleBackColor = true;
            this.btn_DelUser.Click += new System.EventHandler(this.btn_DelUser_Click);
            // 
            // btn_UpUsr
            // 
            this.btn_UpUsr.Location = new System.Drawing.Point(21, 145);
            this.btn_UpUsr.Name = "btn_UpUsr";
            this.btn_UpUsr.Size = new System.Drawing.Size(205, 50);
            this.btn_UpUsr.TabIndex = 4;
            this.btn_UpUsr.Text = "修改用户信息";
            this.btn_UpUsr.UseVisualStyleBackColor = true;
            this.btn_UpUsr.Click += new System.EventHandler(this.btn_UpUsr_Click);
            // 
            // btn_BkDelete
            // 
            this.btn_BkDelete.Location = new System.Drawing.Point(21, 256);
            this.btn_BkDelete.Name = "btn_BkDelete";
            this.btn_BkDelete.Size = new System.Drawing.Size(205, 50);
            this.btn_BkDelete.TabIndex = 6;
            this.btn_BkDelete.Text = "删除图书信息";
            this.btn_BkDelete.UseVisualStyleBackColor = true;
            this.btn_BkDelete.Click += new System.EventHandler(this.btn_BkDelete_Click);
            // 
            // btn_AddBk
            // 
            this.btn_AddBk.Location = new System.Drawing.Point(21, 312);
            this.btn_AddBk.Name = "btn_AddBk";
            this.btn_AddBk.Size = new System.Drawing.Size(205, 50);
            this.btn_AddBk.TabIndex = 7;
            this.btn_AddBk.Text = "增加图书信息";
            this.btn_AddBk.UseVisualStyleBackColor = true;
            this.btn_AddBk.Click += new System.EventHandler(this.btn_AddBk_Click);
            // 
            // btn_updateBk
            // 
            this.btn_updateBk.Location = new System.Drawing.Point(21, 368);
            this.btn_updateBk.Name = "btn_updateBk";
            this.btn_updateBk.Size = new System.Drawing.Size(205, 50);
            this.btn_updateBk.TabIndex = 8;
            this.btn_updateBk.Text = "修改图书信息";
            this.btn_updateBk.UseVisualStyleBackColor = true;
            this.btn_updateBk.Click += new System.EventHandler(this.btn_updateBk_Click);
            // 
            // btn_DelBorr
            // 
            this.btn_DelBorr.Location = new System.Drawing.Point(21, 480);
            this.btn_DelBorr.Name = "btn_DelBorr";
            this.btn_DelBorr.Size = new System.Drawing.Size(205, 50);
            this.btn_DelBorr.TabIndex = 9;
            this.btn_DelBorr.Text = "删除借阅信息";
            this.btn_DelBorr.UseVisualStyleBackColor = true;
            this.btn_DelBorr.Click += new System.EventHandler(this.btn_DelBorr_Click);
            // 
            // btn_UpdateBor
            // 
            this.btn_UpdateBor.Location = new System.Drawing.Point(21, 536);
            this.btn_UpdateBor.Name = "btn_UpdateBor";
            this.btn_UpdateBor.Size = new System.Drawing.Size(205, 50);
            this.btn_UpdateBor.TabIndex = 11;
            this.btn_UpdateBor.Text = "修改借阅信息";
            this.btn_UpdateBor.UseVisualStyleBackColor = true;
            this.btn_UpdateBor.Click += new System.EventHandler(this.btn_UpdateBor_Click);
            // 
            // dataGridView1
            // 
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(247, 32);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.RowTemplate.Height = 27;
            this.dataGridView1.Size = new System.Drawing.Size(650, 554);
            this.dataGridView1.TabIndex = 12;
            // 
            // menuStrip1
            // 
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.返回ToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(909, 28);
            this.menuStrip1.TabIndex = 13;
            this.menuStrip1.Text = "menuStrip1";
            this.menuStrip1.ItemClicked += new System.Windows.Forms.ToolStripItemClickedEventHandler(this.menuStrip1_ItemClicked);
            // 
            // 返回ToolStripMenuItem
            // 
            this.返回ToolStripMenuItem.Name = "返回ToolStripMenuItem";
            this.返回ToolStripMenuItem.Size = new System.Drawing.Size(81, 24);
            this.返回ToolStripMenuItem.Text = "退出登录";
            this.返回ToolStripMenuItem.Click += new System.EventHandler(this.返回ToolStripMenuItem_Click);
            // 
            // lab_code
            // 
            this.lab_code.AutoSize = true;
            this.lab_code.Location = new System.Drawing.Point(259, 13);
            this.lab_code.Name = "lab_code";
            this.lab_code.Size = new System.Drawing.Size(129, 15);
            this.lab_code.TabIndex = 14;
            this.lab_code.Text = "共有    条记录。";
            // 
            // Guanliyuan
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(909, 601);
            this.Controls.Add(this.lab_code);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.btn_UpdateBor);
            this.Controls.Add(this.btn_DelBorr);
            this.Controls.Add(this.btn_updateBk);
            this.Controls.Add(this.btn_AddBk);
            this.Controls.Add(this.btn_BkDelete);
            this.Controls.Add(this.btn_UpUsr);
            this.Controls.Add(this.btn_DelUser);
            this.Controls.Add(this.btn_ReadAllBorrow);
            this.Controls.Add(this.btn_ReadAllBook);
            this.Controls.Add(this.btn_ReadAllUser);
            this.Controls.Add(this.menuStrip1);
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "Guanliyuan";
            this.Text = "信息管理";
            this.Load += new System.EventHandler(this.Guanliyuan_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btn_ReadAllUser;
        private System.Windows.Forms.Button btn_ReadAllBook;
        private System.Windows.Forms.Button btn_ReadAllBorrow;
        private System.Windows.Forms.Button btn_DelUser;
        private System.Windows.Forms.Button btn_UpUsr;
        private System.Windows.Forms.Button btn_BkDelete;
        private System.Windows.Forms.Button btn_AddBk;
        private System.Windows.Forms.Button btn_updateBk;
        private System.Windows.Forms.Button btn_DelBorr;
        private System.Windows.Forms.Button btn_UpdateBor;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem 返回ToolStripMenuItem;
        private System.Windows.Forms.Label lab_code;
    }
}