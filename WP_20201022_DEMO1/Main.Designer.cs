namespace WP_20201022_DEMO1
{
    partial class Main
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
            this.components = new System.ComponentModel.Container();
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.ts_mainMenu = new System.Windows.Forms.ToolStripMenuItem();
            this.ts_register = new System.Windows.Forms.ToolStripMenuItem();
            this.ts_login = new System.Windows.Forms.ToolStripMenuItem();
            this.ts_startGame = new System.Windows.Forms.ToolStripMenuItem();
            this.contextMenuStrip1 = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // menuStrip1
            // 
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.ts_mainMenu,
            this.ts_startGame});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(1316, 25);
            this.menuStrip1.TabIndex = 0;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // ts_mainMenu
            // 
            this.ts_mainMenu.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.ts_register,
            this.ts_login});
            this.ts_mainMenu.Name = "ts_mainMenu";
            this.ts_mainMenu.Size = new System.Drawing.Size(44, 21);
            this.ts_mainMenu.Text = "选单";
            // 
            // ts_register
            // 
            this.ts_register.Name = "ts_register";
            this.ts_register.Size = new System.Drawing.Size(180, 22);
            this.ts_register.Text = "注册";
            // 
            // ts_login
            // 
            this.ts_login.Name = "ts_login";
            this.ts_login.Size = new System.Drawing.Size(180, 22);
            this.ts_login.Text = "登入";
            // 
            // ts_startGame
            // 
            this.ts_startGame.Name = "ts_startGame";
            this.ts_startGame.Size = new System.Drawing.Size(68, 21);
            this.ts_startGame.Text = "开始游戏";
            this.ts_startGame.Click += new System.EventHandler(this.ts_startGame_Click);
            // 
            // contextMenuStrip1
            // 
            this.contextMenuStrip1.Name = "contextMenuStrip1";
            this.contextMenuStrip1.Size = new System.Drawing.Size(61, 4);
            // 
            // Main
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1316, 726);
            this.Controls.Add(this.menuStrip1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.IsMdiContainer = true;
            this.Name = "Main";
            this.Text = "Main";
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem ts_mainMenu;
        private System.Windows.Forms.ToolStripMenuItem ts_register;
        private System.Windows.Forms.ToolStripMenuItem ts_login;
        private System.Windows.Forms.ToolStripMenuItem ts_startGame;
        private System.Windows.Forms.ContextMenuStrip contextMenuStrip1;
    }
}