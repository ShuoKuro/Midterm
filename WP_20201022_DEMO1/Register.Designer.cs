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
            this.tb_userName = new System.Windows.Forms.TextBox();
            this.tb_userPw = new System.Windows.Forms.TextBox();
            this.tb_confirmPw = new System.Windows.Forms.TextBox();
            this.btn_check = new System.Windows.Forms.Button();
            this.tb_validCode = new System.Windows.Forms.TextBox();
            this.lab_loginName = new System.Windows.Forms.Label();
            this.lab_password = new System.Windows.Forms.Label();
            this.lab_passwordCheck = new System.Windows.Forms.Label();
            this.pb_checkCode = new System.Windows.Forms.PictureBox();
            this.lab_upDateValidCode = new System.Windows.Forms.LinkLabel();
            this.lb_checkUserName = new System.Windows.Forms.Label();
            this.lb_checkPw = new System.Windows.Forms.Label();
            this.lb_checkConfirm = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.pb_checkCode)).BeginInit();
            this.SuspendLayout();
            // 
            // tb_userName
            // 
            this.tb_userName.Location = new System.Drawing.Point(12, 24);
            this.tb_userName.Name = "tb_userName";
            this.tb_userName.Size = new System.Drawing.Size(119, 22);
            this.tb_userName.TabIndex = 0;
            this.tb_userName.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.tb_userName_KeyPress);
            // 
            // tb_userPw
            // 
            this.tb_userPw.Location = new System.Drawing.Point(12, 90);
            this.tb_userPw.Name = "tb_userPw";
            this.tb_userPw.Size = new System.Drawing.Size(119, 22);
            this.tb_userPw.TabIndex = 1;
            this.tb_userPw.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.tb_userPw_KeyPress);
            // 
            // tb_confirmPw
            // 
            this.tb_confirmPw.Location = new System.Drawing.Point(12, 155);
            this.tb_confirmPw.Name = "tb_confirmPw";
            this.tb_confirmPw.Size = new System.Drawing.Size(119, 22);
            this.tb_confirmPw.TabIndex = 2;
            // 
            // btn_check
            // 
            this.btn_check.Location = new System.Drawing.Point(52, 266);
            this.btn_check.Name = "btn_check";
            this.btn_check.Size = new System.Drawing.Size(125, 34);
            this.btn_check.TabIndex = 3;
            this.btn_check.Text = "送出";
            this.btn_check.UseVisualStyleBackColor = true;
            this.btn_check.Click += new System.EventHandler(this.btn_check_Click);
            // 
            // tb_validCode
            // 
            this.tb_validCode.Location = new System.Drawing.Point(12, 238);
            this.tb_validCode.Name = "tb_validCode";
            this.tb_validCode.Size = new System.Drawing.Size(94, 22);
            this.tb_validCode.TabIndex = 4;
            // 
            // lab_loginName
            // 
            this.lab_loginName.AutoSize = true;
            this.lab_loginName.Location = new System.Drawing.Point(10, 9);
            this.lab_loginName.Name = "lab_loginName";
            this.lab_loginName.Size = new System.Drawing.Size(65, 12);
            this.lab_loginName.TabIndex = 5;
            this.lab_loginName.Text = "用户名称：";
            // 
            // lab_password
            // 
            this.lab_password.AutoSize = true;
            this.lab_password.Location = new System.Drawing.Point(10, 75);
            this.lab_password.Name = "lab_password";
            this.lab_password.Size = new System.Drawing.Size(41, 12);
            this.lab_password.TabIndex = 6;
            this.lab_password.Text = "密码：";
            // 
            // lab_passwordCheck
            // 
            this.lab_passwordCheck.AutoSize = true;
            this.lab_passwordCheck.Location = new System.Drawing.Point(10, 140);
            this.lab_passwordCheck.Name = "lab_passwordCheck";
            this.lab_passwordCheck.Size = new System.Drawing.Size(65, 12);
            this.lab_passwordCheck.TabIndex = 7;
            this.lab_passwordCheck.Text = "确认密码：";
            // 
            // pb_checkCode
            // 
            this.pb_checkCode.Location = new System.Drawing.Point(12, 195);
            this.pb_checkCode.Name = "pb_checkCode";
            this.pb_checkCode.Size = new System.Drawing.Size(94, 37);
            this.pb_checkCode.TabIndex = 8;
            this.pb_checkCode.TabStop = false;
            // 
            // lab_upDateValidCode
            // 
            this.lab_upDateValidCode.AutoSize = true;
            this.lab_upDateValidCode.Location = new System.Drawing.Point(112, 220);
            this.lab_upDateValidCode.Name = "lab_upDateValidCode";
            this.lab_upDateValidCode.Size = new System.Drawing.Size(65, 12);
            this.lab_upDateValidCode.TabIndex = 9;
            this.lab_upDateValidCode.TabStop = true;
            this.lab_upDateValidCode.Text = "刷新验证码";
            this.lab_upDateValidCode.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.lab_upDateValidCode_LinkClicked);
            // 
            // lb_checkUserName
            // 
            this.lb_checkUserName.AutoSize = true;
            this.lb_checkUserName.Location = new System.Drawing.Point(10, 49);
            this.lb_checkUserName.Name = "lb_checkUserName";
            this.lb_checkUserName.Size = new System.Drawing.Size(33, 12);
            this.lb_checkUserName.TabIndex = 10;
            this.lb_checkUserName.Text = "label1";
            // 
            // lb_checkPw
            // 
            this.lb_checkPw.AutoSize = true;
            this.lb_checkPw.Location = new System.Drawing.Point(10, 115);
            this.lb_checkPw.Name = "lb_checkPw";
            this.lb_checkPw.Size = new System.Drawing.Size(33, 12);
            this.lb_checkPw.TabIndex = 11;
            this.lb_checkPw.Text = "label1";
            // 
            // lb_checkConfirm
            // 
            this.lb_checkConfirm.AutoSize = true;
            this.lb_checkConfirm.Location = new System.Drawing.Point(10, 180);
            this.lb_checkConfirm.Name = "lb_checkConfirm";
            this.lb_checkConfirm.Size = new System.Drawing.Size(33, 12);
            this.lb_checkConfirm.TabIndex = 12;
            this.lb_checkConfirm.Text = "label1";
            // 
            // Register
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(234, 327);
            this.Controls.Add(this.lb_checkConfirm);
            this.Controls.Add(this.lb_checkPw);
            this.Controls.Add(this.lb_checkUserName);
            this.Controls.Add(this.lab_upDateValidCode);
            this.Controls.Add(this.pb_checkCode);
            this.Controls.Add(this.lab_passwordCheck);
            this.Controls.Add(this.lab_password);
            this.Controls.Add(this.lab_loginName);
            this.Controls.Add(this.tb_validCode);
            this.Controls.Add(this.btn_check);
            this.Controls.Add(this.tb_confirmPw);
            this.Controls.Add(this.tb_userPw);
            this.Controls.Add(this.tb_userName);
            this.Name = "Register";
            this.Text = "注册";
            this.Load += new System.EventHandler(this.Register_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pb_checkCode)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox tb_userName;
        private System.Windows.Forms.TextBox tb_userPw;
        private System.Windows.Forms.TextBox tb_confirmPw;
        private System.Windows.Forms.Button btn_check;
        private System.Windows.Forms.TextBox tb_validCode;
        private System.Windows.Forms.Label lab_loginName;
        private System.Windows.Forms.Label lab_password;
        private System.Windows.Forms.Label lab_passwordCheck;
        private System.Windows.Forms.PictureBox pb_checkCode;
        private System.Windows.Forms.LinkLabel lab_upDateValidCode;
        private System.Windows.Forms.Label lb_checkUserName;
        private System.Windows.Forms.Label lb_checkPw;
        private System.Windows.Forms.Label lb_checkConfirm;
    }
}