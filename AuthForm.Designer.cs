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
            this.lbLog = new System.Windows.Forms.Label();
            this.lbPass = new System.Windows.Forms.Label();
            this.txtLog = new System.Windows.Forms.TextBox();
            this.txtPass = new System.Windows.Forms.TextBox();
            this.lbAuth = new System.Windows.Forms.Label();
            this.cbPass = new System.Windows.Forms.CheckBox();
            this.SuspendLayout();
            // 
            // btAuth
            // 
            this.btAuth.Location = new System.Drawing.Point(224, 290);
            this.btAuth.Name = "btAuth";
            this.btAuth.Size = new System.Drawing.Size(156, 23);
            this.btAuth.TabIndex = 0;
            this.btAuth.Text = "Вход";
            this.btAuth.UseVisualStyleBackColor = true;
            this.btAuth.Click += new System.EventHandler(this.btAuth_Click);
            // 
            // lbLog
            // 
            this.lbLog.AutoSize = true;
            this.lbLog.Location = new System.Drawing.Point(166, 186);
            this.lbLog.Name = "lbLog";
            this.lbLog.Size = new System.Drawing.Size(44, 15);
            this.lbLog.TabIndex = 1;
            this.lbLog.Text = "Логин:";
            // 
            // lbPass
            // 
            this.lbPass.AutoSize = true;
            this.lbPass.Location = new System.Drawing.Point(166, 227);
            this.lbPass.Name = "lbPass";
            this.lbPass.Size = new System.Drawing.Size(52, 15);
            this.lbPass.TabIndex = 1;
            this.lbPass.Text = "Пароль:";
            // 
            // txtLog
            // 
            this.txtLog.Location = new System.Drawing.Point(224, 183);
            this.txtLog.Name = "txtLog";
            this.txtLog.Size = new System.Drawing.Size(156, 23);
            this.txtLog.TabIndex = 2;
            // 
            // txtPass
            // 
            this.txtPass.Location = new System.Drawing.Point(224, 224);
            this.txtPass.Name = "txtPass";
            this.txtPass.PasswordChar = '○';
            this.txtPass.Size = new System.Drawing.Size(156, 23);
            this.txtPass.TabIndex = 2;
            // 
            // lbAuth
            // 
            this.lbAuth.AutoSize = true;
            this.lbAuth.Location = new System.Drawing.Point(242, 126);
            this.lbAuth.Name = "lbAuth";
            this.lbAuth.Size = new System.Drawing.Size(78, 15);
            this.lbAuth.TabIndex = 3;
            this.lbAuth.Text = "Авторизация";
            // 
            // cbPass
            // 
            this.cbPass.AutoSize = true;
            this.cbPass.Location = new System.Drawing.Point(362, 229);
            this.cbPass.Name = "cbPass";
            this.cbPass.Size = new System.Drawing.Size(15, 14);
            this.cbPass.TabIndex = 4;
            this.cbPass.UseVisualStyleBackColor = true;
            this.cbPass.CheckedChanged += new System.EventHandler(this.cbPass_CheckedChanged);
            // 
            // AuthForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.cbPass);
            this.Controls.Add(this.lbAuth);
            this.Controls.Add(this.txtPass);
            this.Controls.Add(this.txtLog);
            this.Controls.Add(this.lbPass);
            this.Controls.Add(this.lbLog);
            this.Controls.Add(this.btAuth);
            this.Name = "AuthForm";
            this.Text = "AuthForm";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Button btAuth;
        private Label lbLog;
        private Label lbPass;
        private TextBox txtLog;
        private TextBox txtPass;
        private Label lbAuth;
        private CheckBox cbPass;
    }
}