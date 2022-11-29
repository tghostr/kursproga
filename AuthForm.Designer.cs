namespace kursproga
{
    partial class AuthForm
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.btAuth = new System.Windows.Forms.Button();
            this.txtLog = new System.Windows.Forms.TextBox();
            this.txtPass = new System.Windows.Forms.TextBox();
            this.lbAuth = new System.Windows.Forms.Label();
            this.cbPass = new System.Windows.Forms.CheckBox();
            this.btExit = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // btAuth
            // 
            this.btAuth.Location = new System.Drawing.Point(50, 161);
            this.btAuth.Name = "btAuth";
            this.btAuth.Size = new System.Drawing.Size(156, 23);
            this.btAuth.TabIndex = 0;
            this.btAuth.Text = "Вход";
            this.btAuth.UseVisualStyleBackColor = true;
            this.btAuth.Click += new System.EventHandler(this.btAuth_Click);
            // 
            // txtLog
            // 
            this.txtLog.Location = new System.Drawing.Point(50, 73);
            this.txtLog.Name = "txtLog";
            this.txtLog.PlaceholderText = "Логин";
            this.txtLog.Size = new System.Drawing.Size(156, 23);
            this.txtLog.TabIndex = 2;
            this.txtLog.TextChanged += new System.EventHandler(this.txtLog_TextChanged);
            // 
            // txtPass
            // 
            this.txtPass.Location = new System.Drawing.Point(50, 114);
            this.txtPass.Name = "txtPass";
            this.txtPass.PlaceholderText = "Пароль";
            this.txtPass.Size = new System.Drawing.Size(156, 23);
            this.txtPass.TabIndex = 2;
            this.txtPass.UseSystemPasswordChar = true;
            // 
            // lbAuth
            // 
            this.lbAuth.AutoSize = true;
            this.lbAuth.Location = new System.Drawing.Point(89, 38);
            this.lbAuth.Name = "lbAuth";
            this.lbAuth.Size = new System.Drawing.Size(78, 15);
            this.lbAuth.TabIndex = 3;
            this.lbAuth.Text = "Авторизация";
            // 
            // cbPass
            // 
            this.cbPass.AutoSize = true;
            this.cbPass.Location = new System.Drawing.Point(189, 119);
            this.cbPass.Name = "cbPass";
            this.cbPass.Size = new System.Drawing.Size(15, 14);
            this.cbPass.TabIndex = 4;
            this.cbPass.UseVisualStyleBackColor = true;
            this.cbPass.CheckedChanged += new System.EventHandler(this.cbPass_CheckedChanged);
            // 
            // btExit
            // 
            this.btExit.Location = new System.Drawing.Point(50, 190);
            this.btExit.Name = "btExit";
            this.btExit.Size = new System.Drawing.Size(156, 23);
            this.btExit.TabIndex = 0;
            this.btExit.Text = "Выход";
            this.btExit.UseVisualStyleBackColor = true;
            this.btExit.Click += new System.EventHandler(this.btExit_Click);
            // 
            // AuthForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.ClientSize = new System.Drawing.Size(244, 261);
            this.Controls.Add(this.cbPass);
            this.Controls.Add(this.lbAuth);
            this.Controls.Add(this.txtPass);
            this.Controls.Add(this.txtLog);
            this.Controls.Add(this.btExit);
            this.Controls.Add(this.btAuth);
            this.MaximizeBox = false;
            this.MaximumSize = new System.Drawing.Size(260, 300);
            this.MinimumSize = new System.Drawing.Size(260, 300);
            this.Name = "AuthForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "AuthForm";
            this.Load += new System.EventHandler(this.AuthForm_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Button btAuth;
        private TextBox txtLog;
        private TextBox txtPass;
        private Label lbAuth;
        private CheckBox cbPass;
        private Button btExit;
    }
}