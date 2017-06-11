namespace WindowsFormsApplication1
{
    partial class UpdateBorrow
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
            this.txtbox_bkName = new System.Windows.Forms.TextBox();
            this.txtbox_bkNum = new System.Windows.Forms.TextBox();
            this.txtbox_usrName = new System.Windows.Forms.TextBox();
            this.txtbox_Data = new System.Windows.Forms.TextBox();
            this.btn_Update = new System.Windows.Forms.Button();
            this.btn_return = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("宋体", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.label1.Location = new System.Drawing.Point(72, 71);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(109, 20);
            this.label1.TabIndex = 0;
            this.label1.Text = "书    名：";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("宋体", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.label2.Location = new System.Drawing.Point(72, 123);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(109, 20);
            this.label2.TabIndex = 1;
            this.label2.Text = "书    号：";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("宋体", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.label3.Location = new System.Drawing.Point(72, 175);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(109, 20);
            this.label3.TabIndex = 2;
            this.label3.Text = "借 阅 人：";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("宋体", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.label4.Location = new System.Drawing.Point(72, 227);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(109, 20);
            this.label4.TabIndex = 3;
            this.label4.Text = "借阅日期：";
            // 
            // txtbox_bkName
            // 
            this.txtbox_bkName.Location = new System.Drawing.Point(187, 71);
            this.txtbox_bkName.Name = "txtbox_bkName";
            this.txtbox_bkName.Size = new System.Drawing.Size(142, 25);
            this.txtbox_bkName.TabIndex = 4;
            // 
            // txtbox_bkNum
            // 
            this.txtbox_bkNum.Location = new System.Drawing.Point(187, 123);
            this.txtbox_bkNum.Name = "txtbox_bkNum";
            this.txtbox_bkNum.Size = new System.Drawing.Size(142, 25);
            this.txtbox_bkNum.TabIndex = 5;
            // 
            // txtbox_usrName
            // 
            this.txtbox_usrName.Location = new System.Drawing.Point(187, 175);
            this.txtbox_usrName.Name = "txtbox_usrName";
            this.txtbox_usrName.Size = new System.Drawing.Size(142, 25);
            this.txtbox_usrName.TabIndex = 6;
            // 
            // txtbox_Data
            // 
            this.txtbox_Data.Location = new System.Drawing.Point(187, 227);
            this.txtbox_Data.Name = "txtbox_Data";
            this.txtbox_Data.Size = new System.Drawing.Size(142, 25);
            this.txtbox_Data.TabIndex = 7;
            // 
            // btn_Update
            // 
            this.btn_Update.Location = new System.Drawing.Point(76, 293);
            this.btn_Update.Name = "btn_Update";
            this.btn_Update.Size = new System.Drawing.Size(94, 42);
            this.btn_Update.TabIndex = 8;
            this.btn_Update.Text = "提交";
            this.btn_Update.UseVisualStyleBackColor = true;
            this.btn_Update.Click += new System.EventHandler(this.btn_Update_Click);
            // 
            // btn_return
            // 
            this.btn_return.Location = new System.Drawing.Point(235, 293);
            this.btn_return.Name = "btn_return";
            this.btn_return.Size = new System.Drawing.Size(94, 42);
            this.btn_return.TabIndex = 9;
            this.btn_return.Text = "返回";
            this.btn_return.UseVisualStyleBackColor = true;
            this.btn_return.Click += new System.EventHandler(this.btn_return_Click);
            // 
            // UpdateBorrow
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(402, 376);
            this.Controls.Add(this.btn_return);
            this.Controls.Add(this.btn_Update);
            this.Controls.Add(this.txtbox_Data);
            this.Controls.Add(this.txtbox_usrName);
            this.Controls.Add(this.txtbox_bkNum);
            this.Controls.Add(this.txtbox_bkName);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "UpdateBorrow";
            this.Text = "借书信息更新";
            this.Load += new System.EventHandler(this.UpdateBorrow_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox txtbox_bkName;
        private System.Windows.Forms.TextBox txtbox_bkNum;
        private System.Windows.Forms.TextBox txtbox_usrName;
        private System.Windows.Forms.TextBox txtbox_Data;
        private System.Windows.Forms.Button btn_Update;
        private System.Windows.Forms.Button btn_return;
    }
}