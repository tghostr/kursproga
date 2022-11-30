namespace kursproga
{
    partial class MainForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MainForm));
            this.toolStrip1 = new System.Windows.Forms.ToolStrip();
            this.tsbtEquip = new System.Windows.Forms.ToolStripButton();
            this.tsbtMaterial = new System.Windows.Forms.ToolStripButton();
            this.tsbtStaff = new System.Windows.Forms.ToolStripButton();
            this.tsbtAuth = new System.Windows.Forms.ToolStripButton();
            this.tsbtReq = new System.Windows.Forms.ToolStripButton();
            this.tsbtExit = new System.Windows.Forms.ToolStripButton();
            this.panelForm = new System.Windows.Forms.Panel();
            this.toolStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // toolStrip1
            // 
            this.toolStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.tsbtEquip,
            this.tsbtMaterial,
            this.tsbtStaff,
            this.tsbtAuth,
            this.tsbtReq,
            this.tsbtExit});
            this.toolStrip1.Location = new System.Drawing.Point(0, 0);
            this.toolStrip1.Name = "toolStrip1";
            this.toolStrip1.Size = new System.Drawing.Size(800, 25);
            this.toolStrip1.TabIndex = 1;
            this.toolStrip1.Text = "toolStrip1";
            // 
            // tsbtEquip
            // 
            this.tsbtEquip.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Text;
            this.tsbtEquip.Image = ((System.Drawing.Image)(resources.GetObject("tsbtEquip.Image")));
            this.tsbtEquip.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.tsbtEquip.Name = "tsbtEquip";
            this.tsbtEquip.Size = new System.Drawing.Size(92, 22);
            this.tsbtEquip.Tag = "";
            this.tsbtEquip.Text = "Оборудование";
            this.tsbtEquip.Click += new System.EventHandler(this.tsbtEquip_Click);
            // 
            // tsbtMaterial
            // 
            this.tsbtMaterial.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Text;
            this.tsbtMaterial.Image = ((System.Drawing.Image)(resources.GetObject("tsbtMaterial.Image")));
            this.tsbtMaterial.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.tsbtMaterial.Name = "tsbtMaterial";
            this.tsbtMaterial.Size = new System.Drawing.Size(75, 22);
            this.tsbtMaterial.Tag = "";
            this.tsbtMaterial.Text = "Материалы";
            this.tsbtMaterial.Click += new System.EventHandler(this.tsbtMaterial_Click);
            // 
            // tsbtStaff
            // 
            this.tsbtStaff.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Text;
            this.tsbtStaff.Image = ((System.Drawing.Image)(resources.GetObject("tsbtStaff.Image")));
            this.tsbtStaff.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.tsbtStaff.Name = "tsbtStaff";
            this.tsbtStaff.Size = new System.Drawing.Size(66, 22);
            this.tsbtStaff.Tag = "";
            this.tsbtStaff.Text = "Персонал";
            this.tsbtStaff.Click += new System.EventHandler(this.tsbtStaff_Click);
            // 
            // tsbtAuth
            // 
            this.tsbtAuth.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Text;
            this.tsbtAuth.Image = ((System.Drawing.Image)(resources.GetObject("tsbtAuth.Image")));
            this.tsbtAuth.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.tsbtAuth.Name = "tsbtAuth";
            this.tsbtAuth.Size = new System.Drawing.Size(82, 22);
            this.tsbtAuth.Text = "Авторизация";
            this.tsbtAuth.Click += new System.EventHandler(this.tsbtAuth_Click);
            // 
            // tsbtReq
            // 
            this.tsbtReq.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Text;
            this.tsbtReq.Image = ((System.Drawing.Image)(resources.GetObject("tsbtReq.Image")));
            this.tsbtReq.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.tsbtReq.Name = "tsbtReq";
            this.tsbtReq.Size = new System.Drawing.Size(49, 22);
            this.tsbtReq.Tag = "";
            this.tsbtReq.Text = "Заявки";
            this.tsbtReq.Click += new System.EventHandler(this.tsbtReq_Click);
            // 
            // tsbtExit
            // 
            this.tsbtExit.Alignment = System.Windows.Forms.ToolStripItemAlignment.Right;
            this.tsbtExit.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Text;
            this.tsbtExit.Image = ((System.Drawing.Image)(resources.GetObject("tsbtExit.Image")));
            this.tsbtExit.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.tsbtExit.Name = "tsbtExit";
            this.tsbtExit.Size = new System.Drawing.Size(46, 22);
            this.tsbtExit.Tag = "";
            this.tsbtExit.Text = "Выход";
            this.tsbtExit.Click += new System.EventHandler(this.tsbtExit_Click);
            // 
            // panelForm
            // 
            this.panelForm.Location = new System.Drawing.Point(0, 25);
            this.panelForm.Name = "panelForm";
            this.panelForm.Size = new System.Drawing.Size(800, 475);
            this.panelForm.TabIndex = 2;
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.ClientSize = new System.Drawing.Size(800, 475);
            this.Controls.Add(this.panelForm);
            this.Controls.Add(this.toolStrip1);
            this.MaximizeBox = false;
            this.MaximumSize = new System.Drawing.Size(816, 514);
            this.MinimumSize = new System.Drawing.Size(816, 514);
            this.Name = "MainForm";
            this.ShowIcon = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Меню навигации";
            this.Load += new System.EventHandler(this.MainForm_Load);
            this.toolStrip1.ResumeLayout(false);
            this.toolStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private ToolStrip toolStrip1;
        private ToolStripButton tsbtEquip;
        private ToolStripButton tsbtStaff;
        private ToolStripButton tsbtMaterial;
        private ToolStripButton tsbtReq;
        private ToolStripButton tsbtExit;
        private Panel panelForm;
        private ToolStripButton tsbtAuth;
    }
}