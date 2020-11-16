namespace WP_20201022_DEMO1
{
    partial class Login
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
            this.tb_loginName = new System.Windows.Forms.TextBox();
            this.tb_password = new System.Windows.Forms.TextBox();
            this.btn_loginCheck = new System.Windows.Forms.Button();
            this.lab_loginName = new System.Windows.Forms.Label();
            this.lab_password = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // tb_loginName
            // 
            this.tb_loginName.Location = new System.Drawing.Point(48, 37);
            this.tb_loginName.Name = "tb_loginName";
            this.tb_loginName.Size = new System.Drawing.Size(133, 22);
            this.tb_loginName.TabIndex = 0;
            this.tb_loginName.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.tb_loginName_KeyPress);
            // 
            // tb_password
            // 
            this.tb_password.Location = new System.Drawing.Point(48, 101);
            this.tb_password.Name = "tb_password";
            this.tb_password.Size = new System.Drawing.Size(133, 22);
            this.tb_password.TabIndex = 1;
            this.tb_password.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.tb_password_KeyPress);
            // 
            // btn_loginCheck
            // 
            this.btn_loginCheck.Location = new System.Drawing.Point(227, 62);
            this.btn_loginCheck.Name = "btn_loginCheck";
            this.btn_loginCheck.Size = new System.Drawing.Size(75, 61);
            this.btn_loginCheck.TabIndex = 2;
            this.btn_loginCheck.Text = "确认";
            this.btn_loginCheck.UseVisualStyleBackColor = true;
            this.btn_loginCheck.Click += new System.EventHandler(this.btn_loginCheck_Click);
            // 
            // lab_loginName
            // 
            this.lab_loginName.AutoSize = true;
            this.lab_loginName.Location = new System.Drawing.Point(12, 22);
            this.lab_loginName.Name = "lab_loginName";
            this.lab_loginName.Size = new System.Drawing.Size(65, 12);
            this.lab_loginName.TabIndex = 3;
            this.lab_loginName.Text = "用户名称：";
            // 
            // lab_password
            // 
            this.lab_password.AutoSize = true;
            this.lab_password.Location = new System.Drawing.Point(12, 86);
            this.lab_password.Name = "lab_password";
            this.lab_password.Size = new System.Drawing.Size(41, 12);
            this.lab_password.TabIndex = 4;
            this.lab_password.Text = "密码：";
            // 
            // Login
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(309, 229);
            this.Controls.Add(this.lab_password);
            this.Controls.Add(this.lab_loginName);
            this.Controls.Add(this.btn_loginCheck);
            this.Controls.Add(this.tb_password);
            this.Controls.Add(this.tb_loginName);
            this.Name = "Login";
            this.Text = "Login";
            this.Load += new System.EventHandler(this.Login_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox tb_loginName;
        private System.Windows.Forms.TextBox tb_password;
        private System.Windows.Forms.Button btn_loginCheck;
        private System.Windows.Forms.Label lab_loginName;
        private System.Windows.Forms.Label lab_password;
    }
}