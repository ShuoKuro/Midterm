namespace WP_20201022_DEMO1
{
    partial class Register
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
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.textBox2 = new System.Windows.Forms.TextBox();
            this.textBox3 = new System.Windows.Forms.TextBox();
            this.btn_check = new System.Windows.Forms.Button();
            this.tb_validCode = new System.Windows.Forms.TextBox();
            this.lab_loginName = new System.Windows.Forms.Label();
            this.lab_password = new System.Windows.Forms.Label();
            this.lab_passwordCheck = new System.Windows.Forms.Label();
            this.backgroundWorker1 = new System.ComponentModel.BackgroundWorker();
            this.pb_checkCode = new System.Windows.Forms.PictureBox();
            this.lab_upDateValidCode = new System.Windows.Forms.LinkLabel();
            ((System.ComponentModel.ISupportInitialize)(this.pb_checkCode)).BeginInit();
            this.SuspendLayout();
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(12, 39);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(119, 22);
            this.textBox1.TabIndex = 0;
            // 
            // textBox2
            // 
            this.textBox2.Location = new System.Drawing.Point(12, 94);
            this.textBox2.Name = "textBox2";
            this.textBox2.Size = new System.Drawing.Size(119, 22);
            this.textBox2.TabIndex = 1;
            // 
            // textBox3
            // 
            this.textBox3.Location = new System.Drawing.Point(12, 145);
            this.textBox3.Name = "textBox3";
            this.textBox3.Size = new System.Drawing.Size(119, 22);
            this.textBox3.TabIndex = 2;
            // 
            // btn_check
            // 
            this.btn_check.Location = new System.Drawing.Point(79, 244);
            this.btn_check.Name = "btn_check";
            this.btn_check.Size = new System.Drawing.Size(125, 34);
            this.btn_check.TabIndex = 3;
            this.btn_check.Text = "送出";
            this.btn_check.UseVisualStyleBackColor = true;
            this.btn_check.Click += new System.EventHandler(this.btn_check_Click);
            // 
            // tb_validCode
            // 
            this.tb_validCode.Location = new System.Drawing.Point(12, 216);
            this.tb_validCode.Name = "tb_validCode";
            this.tb_validCode.Size = new System.Drawing.Size(94, 22);
            this.tb_validCode.TabIndex = 4;
            // 
            // lab_loginName
            // 
            this.lab_loginName.AutoSize = true;
            this.lab_loginName.Location = new System.Drawing.Point(12, 21);
            this.lab_loginName.Name = "lab_loginName";
            this.lab_loginName.Size = new System.Drawing.Size(65, 12);
            this.lab_loginName.TabIndex = 5;
            this.lab_loginName.Text = "用户名称：";
            // 
            // lab_password
            // 
            this.lab_password.AutoSize = true;
            this.lab_password.Location = new System.Drawing.Point(10, 79);
            this.lab_password.Name = "lab_password";
            this.lab_password.Size = new System.Drawing.Size(41, 12);
            this.lab_password.TabIndex = 6;
            this.lab_password.Text = "密码：";
            // 
            // lab_passwordCheck
            // 
            this.lab_passwordCheck.AutoSize = true;
            this.lab_passwordCheck.Location = new System.Drawing.Point(10, 130);
            this.lab_passwordCheck.Name = "lab_passwordCheck";
            this.lab_passwordCheck.Size = new System.Drawing.Size(65, 12);
            this.lab_passwordCheck.TabIndex = 7;
            this.lab_passwordCheck.Text = "确认密码：";
            // 
            // pb_checkCode
            // 
            this.pb_checkCode.Location = new System.Drawing.Point(12, 173);
            this.pb_checkCode.Name = "pb_checkCode";
            this.pb_checkCode.Size = new System.Drawing.Size(94, 37);
            this.pb_checkCode.TabIndex = 8;
            this.pb_checkCode.TabStop = false;
            // 
            // lab_upDateValidCode
            // 
            this.lab_upDateValidCode.AutoSize = true;
            this.lab_upDateValidCode.Location = new System.Drawing.Point(112, 198);
            this.lab_upDateValidCode.Name = "lab_upDateValidCode";
            this.lab_upDateValidCode.Size = new System.Drawing.Size(65, 12);
            this.lab_upDateValidCode.TabIndex = 9;
            this.lab_upDateValidCode.TabStop = true;
            this.lab_upDateValidCode.Text = "刷新验证码";
            this.lab_upDateValidCode.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.lab_upDateValidCode_LinkClicked);
            // 
            // Register
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(232, 293);
            this.Controls.Add(this.lab_upDateValidCode);
            this.Controls.Add(this.pb_checkCode);
            this.Controls.Add(this.lab_passwordCheck);
            this.Controls.Add(this.lab_password);
            this.Controls.Add(this.lab_loginName);
            this.Controls.Add(this.tb_validCode);
            this.Controls.Add(this.btn_check);
            this.Controls.Add(this.textBox3);
            this.Controls.Add(this.textBox2);
            this.Controls.Add(this.textBox1);
            this.Name = "Register";
            this.Text = "Register";
            this.Load += new System.EventHandler(this.Register_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pb_checkCode)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.TextBox textBox2;
        private System.Windows.Forms.TextBox textBox3;
        private System.Windows.Forms.Button btn_check;
        private System.Windows.Forms.TextBox tb_validCode;
        private System.Windows.Forms.Label lab_loginName;
        private System.Windows.Forms.Label lab_password;
        private System.Windows.Forms.Label lab_passwordCheck;
        private System.ComponentModel.BackgroundWorker backgroundWorker1;
        private System.Windows.Forms.PictureBox pb_checkCode;
        private System.Windows.Forms.LinkLabel lab_upDateValidCode;
    }
}