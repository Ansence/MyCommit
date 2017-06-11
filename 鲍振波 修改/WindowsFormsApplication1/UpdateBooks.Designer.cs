namespace WindowsFormsApplication1
{
    partial class UpdateBooks
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
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.txt_bkName = new System.Windows.Forms.TextBox();
            this.txt_bkNum = new System.Windows.Forms.TextBox();
            this.txtbkAuther = new System.Windows.Forms.TextBox();
            this.btn_tj = new System.Windows.Forms.Button();
            this.btn_return = new System.Windows.Forms.Button();
            this.cbbox_bkBuff = new System.Windows.Forms.ComboBox();
            this.cbb_bkKind = new System.Windows.Forms.ComboBox();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("宋体", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.label1.Location = new System.Drawing.Point(67, 62);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(69, 20);
            this.label1.TabIndex = 0;
            this.label1.Text = "书名：";
            this.label1.Click += new System.EventHandler(this.label1_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("宋体", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.label2.Location = new System.Drawing.Point(67, 239);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(69, 20);
            this.label2.TabIndex = 1;
            this.label2.Text = "作者：";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("宋体", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.label3.Location = new System.Drawing.Point(67, 121);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(69, 20);
            this.label3.TabIndex = 2;
            this.label3.Text = "书号：";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("宋体", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.label4.Location = new System.Drawing.Point(67, 298);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(69, 20);
            this.label4.TabIndex = 3;
            this.label4.Text = "状态：";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("宋体", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.label5.Location = new System.Drawing.Point(67, 180);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(69, 20);
            this.label5.TabIndex = 4;
            this.label5.Text = "种类：";
            this.label5.Click += new System.EventHandler(this.label5_Click);
            // 
            // txt_bkName
            // 
            this.txt_bkName.Location = new System.Drawing.Point(142, 62);
            this.txt_bkName.Name = "txt_bkName";
            this.txt_bkName.Size = new System.Drawing.Size(189, 25);
            this.txt_bkName.TabIndex = 5;
            // 
            // txt_bkNum
            // 
            this.txt_bkNum.Location = new System.Drawing.Point(142, 122);
            this.txt_bkNum.Name = "txt_bkNum";
            this.txt_bkNum.Size = new System.Drawing.Size(189, 25);
            this.txt_bkNum.TabIndex = 6;
            // 
            // txtbkAuther
            // 
            this.txtbkAuther.Location = new System.Drawing.Point(142, 240);
            this.txtbkAuther.Name = "txtbkAuther";
            this.txtbkAuther.Size = new System.Drawing.Size(189, 25);
            this.txtbkAuther.TabIndex = 8;
            // 
            // btn_tj
            // 
            this.btn_tj.Location = new System.Drawing.Point(81, 360);
            this.btn_tj.Name = "btn_tj";
            this.btn_tj.Size = new System.Drawing.Size(101, 59);
            this.btn_tj.TabIndex = 10;
            this.btn_tj.Text = "提交";
            this.btn_tj.UseVisualStyleBackColor = true;
            this.btn_tj.Click += new System.EventHandler(this.btn_tj_Click);
            // 
            // btn_return
            // 
            this.btn_return.Location = new System.Drawing.Point(230, 360);
            this.btn_return.Name = "btn_return";
            this.btn_return.Size = new System.Drawing.Size(101, 59);
            this.btn_return.TabIndex = 11;
            this.btn_return.Text = "返回";
            this.btn_return.UseVisualStyleBackColor = true;
            this.btn_return.Click += new System.EventHandler(this.btn_return_Click);
            // 
            // cbbox_bkBuff
            // 
            this.cbbox_bkBuff.FormattingEnabled = true;
            this.cbbox_bkBuff.Items.AddRange(new object[] {
            "借出",
            "未借出"});
            this.cbbox_bkBuff.Location = new System.Drawing.Point(142, 300);
            this.cbbox_bkBuff.Name = "cbbox_bkBuff";
            this.cbbox_bkBuff.Size = new System.Drawing.Size(188, 23);
            this.cbbox_bkBuff.TabIndex = 12;
            // 
            // cbb_bkKind
            // 
            this.cbb_bkKind.FormattingEnabled = true;
            this.cbb_bkKind.Items.AddRange(new object[] {
            "人文",
            "自然科学",
            "数学",
            "物理",
            "小说"});
            this.cbb_bkKind.Location = new System.Drawing.Point(142, 182);
            this.cbb_bkKind.Name = "cbb_bkKind";
            this.cbb_bkKind.Size = new System.Drawing.Size(187, 23);
            this.cbb_bkKind.TabIndex = 13;
            // 
            // UpdateBooks
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(415, 471);
            this.Controls.Add(this.cbb_bkKind);
            this.Controls.Add(this.cbbox_bkBuff);
            this.Controls.Add(this.btn_return);
            this.Controls.Add(this.btn_tj);
            this.Controls.Add(this.txtbkAuther);
            this.Controls.Add(this.txt_bkNum);
            this.Controls.Add(this.txt_bkName);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "UpdateBooks";
            this.Text = "图书信息更新";
            this.Load += new System.EventHandler(this.UpdateBooks_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox txt_bkName;
        private System.Windows.Forms.TextBox txt_bkNum;
        private System.Windows.Forms.TextBox txtbkAuther;
        private System.Windows.Forms.Button btn_tj;
        private System.Windows.Forms.Button btn_return;
        private System.Windows.Forms.ComboBox cbbox_bkBuff;
        private System.Windows.Forms.ComboBox cbb_bkKind;
    }
}