namespace WindowsFormsApplication1
{
    partial class huanShu
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
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.label1 = new System.Windows.Forms.Label();
            this.btn_backBook = new System.Windows.Forms.Button();
            this.btn_Longdata = new System.Windows.Forms.Button();
            this.btn_return = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // dataGridView1
            // 
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(267, 52);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.RowTemplate.Height = 27;
            this.dataGridView1.Size = new System.Drawing.Size(630, 402);
            this.dataGridView1.TabIndex = 0;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("宋体", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.label1.Location = new System.Drawing.Point(502, 13);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(154, 24);
            this.label1.TabIndex = 1;
            this.label1.Text = "我的借书记录";
            // 
            // btn_backBook
            // 
            this.btn_backBook.Location = new System.Drawing.Point(46, 72);
            this.btn_backBook.Name = "btn_backBook";
            this.btn_backBook.Size = new System.Drawing.Size(146, 64);
            this.btn_backBook.TabIndex = 2;
            this.btn_backBook.Text = "还书";
            this.btn_backBook.UseVisualStyleBackColor = true;
            this.btn_backBook.Click += new System.EventHandler(this.btn_backBook_Click);
            // 
            // btn_Longdata
            // 
            this.btn_Longdata.Location = new System.Drawing.Point(46, 184);
            this.btn_Longdata.Name = "btn_Longdata";
            this.btn_Longdata.Size = new System.Drawing.Size(146, 64);
            this.btn_Longdata.TabIndex = 3;
            this.btn_Longdata.Text = "重借（延长日期）";
            this.btn_Longdata.UseVisualStyleBackColor = true;
            this.btn_Longdata.Click += new System.EventHandler(this.btn_Longdata_Click);
            // 
            // btn_return
            // 
            this.btn_return.Location = new System.Drawing.Point(46, 297);
            this.btn_return.Name = "btn_return";
            this.btn_return.Size = new System.Drawing.Size(146, 64);
            this.btn_return.TabIndex = 4;
            this.btn_return.Text = "返回";
            this.btn_return.UseVisualStyleBackColor = true;
            this.btn_return.Click += new System.EventHandler(this.btn_return_Click);
            // 
            // huanShu
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(909, 466);
            this.Controls.Add(this.btn_return);
            this.Controls.Add(this.btn_Longdata);
            this.Controls.Add(this.btn_backBook);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.dataGridView1);
            this.Name = "huanShu";
            this.Text = "我要还书";
            this.Load += new System.EventHandler(this.huanShu_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btn_backBook;
        private System.Windows.Forms.Button btn_Longdata;
        private System.Windows.Forms.Button btn_return;
    }
}