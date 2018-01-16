namespace WOW
{
    partial class FrmLogin
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
            this.lblAddress = new System.Windows.Forms.Label();
            this.lblpwd = new System.Windows.Forms.Label();
            this.txtAddress = new System.Windows.Forms.TextBox();
            this.txtpwd = new System.Windows.Forms.TextBox();
            this.btnLogin = new System.Windows.Forms.Button();
            this.lblNo = new System.Windows.Forms.Label();
            this.lblzc = new System.Windows.Forms.Label();
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // lblAddress
            // 
            this.lblAddress.AutoSize = true;
            this.lblAddress.Font = new System.Drawing.Font("宋体", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.lblAddress.ForeColor = System.Drawing.SystemColors.ButtonShadow;
            this.lblAddress.Location = new System.Drawing.Point(107, 161);
            this.lblAddress.Name = "lblAddress";
            this.lblAddress.Size = new System.Drawing.Size(129, 20);
            this.lblAddress.TabIndex = 1;
            this.lblAddress.Text = "电子邮件地址";
            // 
            // lblpwd
            // 
            this.lblpwd.AutoSize = true;
            this.lblpwd.Font = new System.Drawing.Font("宋体", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.lblpwd.ForeColor = System.Drawing.SystemColors.ButtonShadow;
            this.lblpwd.Location = new System.Drawing.Point(107, 253);
            this.lblpwd.Name = "lblpwd";
            this.lblpwd.Size = new System.Drawing.Size(49, 20);
            this.lblpwd.TabIndex = 2;
            this.lblpwd.Text = "密码";
            // 
            // txtAddress
            // 
            this.txtAddress.Location = new System.Drawing.Point(111, 195);
            this.txtAddress.Name = "txtAddress";
            this.txtAddress.Size = new System.Drawing.Size(558, 25);
            this.txtAddress.TabIndex = 3;
            // 
            // txtpwd
            // 
            this.txtpwd.Location = new System.Drawing.Point(111, 294);
            this.txtpwd.Name = "txtpwd";
            this.txtpwd.Size = new System.Drawing.Size(558, 25);
            this.txtpwd.TabIndex = 4;
            // 
            // btnLogin
            // 
            this.btnLogin.Location = new System.Drawing.Point(137, 371);
            this.btnLogin.Name = "btnLogin";
            this.btnLogin.Size = new System.Drawing.Size(142, 48);
            this.btnLogin.TabIndex = 5;
            this.btnLogin.Text = "登录";
            this.btnLogin.UseVisualStyleBackColor = true;
            this.btnLogin.Click += new System.EventHandler(this.btnLogin_Click);
            // 
            // lblNo
            // 
            this.lblNo.AutoSize = true;
            this.lblNo.Font = new System.Drawing.Font("宋体", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.lblNo.ForeColor = System.Drawing.SystemColors.ButtonShadow;
            this.lblNo.Location = new System.Drawing.Point(107, 471);
            this.lblNo.Name = "lblNo";
            this.lblNo.Size = new System.Drawing.Size(209, 20);
            this.lblNo.TabIndex = 6;
            this.lblNo.Text = "还没有通行证？现在就";
            // 
            // lblzc
            // 
            this.lblzc.AutoSize = true;
            this.lblzc.Cursor = System.Windows.Forms.Cursors.Hand;
            this.lblzc.Font = new System.Drawing.Font("宋体", 12F, System.Drawing.FontStyle.Underline, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.lblzc.ForeColor = System.Drawing.SystemColors.ButtonShadow;
            this.lblzc.Location = new System.Drawing.Point(312, 471);
            this.lblzc.Name = "lblzc";
            this.lblzc.Size = new System.Drawing.Size(49, 20);
            this.lblzc.TabIndex = 7;
            this.lblzc.Text = "注册";
            this.lblzc.Click += new System.EventHandler(this.lblzc_Click);
            // 
            // pictureBox2
            // 
            this.pictureBox2.Image = global::WOW.Properties.Resources.TIM图片20171228142729;
            this.pictureBox2.Location = new System.Drawing.Point(857, -1);
            this.pictureBox2.Name = "pictureBox2";
            this.pictureBox2.Size = new System.Drawing.Size(35, 39);
            this.pictureBox2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox2.TabIndex = 8;
            this.pictureBox2.TabStop = false;
            this.pictureBox2.Click += new System.EventHandler(this.pictureBox2_Click);
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = global::WOW.Properties.Resources.TIM图片20171228142707;
            this.pictureBox1.Location = new System.Drawing.Point(1, -1);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(891, 119);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 0;
            this.pictureBox1.TabStop = false;
            // 
            // FrmLogin
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.ClientSize = new System.Drawing.Size(892, 584);
            this.Controls.Add(this.pictureBox2);
            this.Controls.Add(this.lblzc);
            this.Controls.Add(this.lblNo);
            this.Controls.Add(this.btnLogin);
            this.Controls.Add(this.txtpwd);
            this.Controls.Add(this.txtAddress);
            this.Controls.Add(this.lblpwd);
            this.Controls.Add(this.lblAddress);
            this.Controls.Add(this.pictureBox1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "FrmLogin";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.FrmLogin_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Label lblAddress;
        private System.Windows.Forms.Label lblpwd;
        private System.Windows.Forms.TextBox txtAddress;
        private System.Windows.Forms.TextBox txtpwd;
        private System.Windows.Forms.Button btnLogin;
        private System.Windows.Forms.Label lblNo;
        private System.Windows.Forms.Label lblzc;
        private System.Windows.Forms.PictureBox pictureBox2;
    }
}

