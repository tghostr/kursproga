namespace kursproga
{
    partial class EquipForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(EquipForm));
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.BottomToolStripPanel = new System.Windows.Forms.ToolStripPanel();
            this.TopToolStripPanel = new System.Windows.Forms.ToolStripPanel();
            this.RightToolStripPanel = new System.Windows.Forms.ToolStripPanel();
            this.LeftToolStripPanel = new System.Windows.Forms.ToolStripPanel();
            this.ContentPanel = new System.Windows.Forms.ToolStripContentPanel();
            this.panel1 = new System.Windows.Forms.Panel();
            this.gbDel = new System.Windows.Forms.GroupBox();
            this.tbDel = new System.Windows.Forms.TextBox();
            this.btDel = new System.Windows.Forms.Button();
            this.gbUpd = new System.Windows.Forms.GroupBox();
            this.textBox8 = new System.Windows.Forms.TextBox();
            this.textBox7 = new System.Windows.Forms.TextBox();
            this.textBox6 = new System.Windows.Forms.TextBox();
            this.textBox5 = new System.Windows.Forms.TextBox();
            this.btUpd = new System.Windows.Forms.Button();
            this.gbIns = new System.Windows.Forms.GroupBox();
            this.textBox4 = new System.Windows.Forms.TextBox();
            this.textBox3 = new System.Windows.Forms.TextBox();
            this.textBox2 = new System.Windows.Forms.TextBox();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.btIns = new System.Windows.Forms.Button();
            this.panel2 = new System.Windows.Forms.Panel();
            this.btSearch = new System.Windows.Forms.PictureBox();
            this.tbSearch = new System.Windows.Forms.TextBox();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.panel1.SuspendLayout();
            this.gbDel.SuspendLayout();
            this.gbUpd.SuspendLayout();
            this.gbIns.SuspendLayout();
            this.panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.btSearch)).BeginInit();
            this.SuspendLayout();
            // 
            // dataGridView1
            // 
            this.dataGridView1.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(0, 0);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.RowTemplate.Height = 25;
            this.dataGridView1.Size = new System.Drawing.Size(600, 450);
            this.dataGridView1.TabIndex = 0;
            this.dataGridView1.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellClick);
            // 
            // BottomToolStripPanel
            // 
            this.BottomToolStripPanel.Location = new System.Drawing.Point(0, 0);
            this.BottomToolStripPanel.Name = "BottomToolStripPanel";
            this.BottomToolStripPanel.Orientation = System.Windows.Forms.Orientation.Horizontal;
            this.BottomToolStripPanel.RowMargin = new System.Windows.Forms.Padding(3, 0, 0, 0);
            this.BottomToolStripPanel.Size = new System.Drawing.Size(0, 0);
            // 
            // TopToolStripPanel
            // 
            this.TopToolStripPanel.Location = new System.Drawing.Point(0, 0);
            this.TopToolStripPanel.Name = "TopToolStripPanel";
            this.TopToolStripPanel.Orientation = System.Windows.Forms.Orientation.Horizontal;
            this.TopToolStripPanel.RowMargin = new System.Windows.Forms.Padding(3, 0, 0, 0);
            this.TopToolStripPanel.Size = new System.Drawing.Size(0, 0);
            // 
            // RightToolStripPanel
            // 
            this.RightToolStripPanel.Location = new System.Drawing.Point(0, 0);
            this.RightToolStripPanel.Name = "RightToolStripPanel";
            this.RightToolStripPanel.Orientation = System.Windows.Forms.Orientation.Horizontal;
            this.RightToolStripPanel.RowMargin = new System.Windows.Forms.Padding(3, 0, 0, 0);
            this.RightToolStripPanel.Size = new System.Drawing.Size(0, 0);
            // 
            // LeftToolStripPanel
            // 
            this.LeftToolStripPanel.Location = new System.Drawing.Point(0, 0);
            this.LeftToolStripPanel.Name = "LeftToolStripPanel";
            this.LeftToolStripPanel.Orientation = System.Windows.Forms.Orientation.Horizontal;
            this.LeftToolStripPanel.RowMargin = new System.Windows.Forms.Padding(3, 0, 0, 0);
            this.LeftToolStripPanel.Size = new System.Drawing.Size(0, 0);
            // 
            // ContentPanel
            // 
            this.ContentPanel.Size = new System.Drawing.Size(150, 150);
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.gbDel);
            this.panel1.Controls.Add(this.btDel);
            this.panel1.Controls.Add(this.gbUpd);
            this.panel1.Controls.Add(this.btUpd);
            this.panel1.Controls.Add(this.gbIns);
            this.panel1.Controls.Add(this.btIns);
            this.panel1.Controls.Add(this.panel2);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Right;
            this.panel1.Location = new System.Drawing.Point(600, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(200, 450);
            this.panel1.TabIndex = 20;
            // 
            // gbDel
            // 
            this.gbDel.Controls.Add(this.tbDel);
            this.gbDel.Dock = System.Windows.Forms.DockStyle.Top;
            this.gbDel.Location = new System.Drawing.Point(0, 352);
            this.gbDel.Name = "gbDel";
            this.gbDel.Size = new System.Drawing.Size(200, 35);
            this.gbDel.TabIndex = 22;
            this.gbDel.TabStop = false;
            this.gbDel.Visible = false;
            // 
            // tbDel
            // 
            this.tbDel.Location = new System.Drawing.Point(10, 6);
            this.tbDel.Name = "tbDel";
            this.tbDel.Size = new System.Drawing.Size(180, 23);
            this.tbDel.TabIndex = 22;
            // 
            // btDel
            // 
            this.btDel.Dock = System.Windows.Forms.DockStyle.Top;
            this.btDel.Location = new System.Drawing.Point(0, 330);
            this.btDel.Name = "btDel";
            this.btDel.Size = new System.Drawing.Size(200, 22);
            this.btDel.TabIndex = 4;
            this.btDel.Text = "Удалить";
            this.btDel.UseVisualStyleBackColor = true;
            this.btDel.Click += new System.EventHandler(this.btDel_Click);
            // 
            // gbUpd
            // 
            this.gbUpd.Controls.Add(this.textBox8);
            this.gbUpd.Controls.Add(this.textBox7);
            this.gbUpd.Controls.Add(this.textBox6);
            this.gbUpd.Controls.Add(this.textBox5);
            this.gbUpd.Dock = System.Windows.Forms.DockStyle.Top;
            this.gbUpd.Location = new System.Drawing.Point(0, 212);
            this.gbUpd.Name = "gbUpd";
            this.gbUpd.Size = new System.Drawing.Size(200, 118);
            this.gbUpd.TabIndex = 21;
            this.gbUpd.TabStop = false;
            this.gbUpd.Visible = false;
            // 
            // textBox8
            // 
            this.textBox8.Location = new System.Drawing.Point(10, 90);
            this.textBox8.Multiline = true;
            this.textBox8.Name = "textBox8";
            this.textBox8.Size = new System.Drawing.Size(180, 22);
            this.textBox8.TabIndex = 0;
            // 
            // textBox7
            // 
            this.textBox7.Location = new System.Drawing.Point(10, 62);
            this.textBox7.Multiline = true;
            this.textBox7.Name = "textBox7";
            this.textBox7.Size = new System.Drawing.Size(180, 22);
            this.textBox7.TabIndex = 0;
            // 
            // textBox6
            // 
            this.textBox6.Location = new System.Drawing.Point(10, 34);
            this.textBox6.Multiline = true;
            this.textBox6.Name = "textBox6";
            this.textBox6.Size = new System.Drawing.Size(180, 22);
            this.textBox6.TabIndex = 0;
            // 
            // textBox5
            // 
            this.textBox5.Location = new System.Drawing.Point(10, 6);
            this.textBox5.Multiline = true;
            this.textBox5.Name = "textBox5";
            this.textBox5.Size = new System.Drawing.Size(180, 22);
            this.textBox5.TabIndex = 0;
            // 
            // btUpd
            // 
            this.btUpd.Dock = System.Windows.Forms.DockStyle.Top;
            this.btUpd.Location = new System.Drawing.Point(0, 190);
            this.btUpd.Name = "btUpd";
            this.btUpd.Size = new System.Drawing.Size(200, 22);
            this.btUpd.TabIndex = 20;
            this.btUpd.Text = "Редактировать";
            this.btUpd.UseVisualStyleBackColor = true;
            this.btUpd.Click += new System.EventHandler(this.btUpd_Click);
            // 
            // gbIns
            // 
            this.gbIns.Controls.Add(this.textBox4);
            this.gbIns.Controls.Add(this.textBox3);
            this.gbIns.Controls.Add(this.textBox2);
            this.gbIns.Controls.Add(this.textBox1);
            this.gbIns.Dock = System.Windows.Forms.DockStyle.Top;
            this.gbIns.Location = new System.Drawing.Point(0, 72);
            this.gbIns.Name = "gbIns";
            this.gbIns.Size = new System.Drawing.Size(200, 118);
            this.gbIns.TabIndex = 19;
            this.gbIns.TabStop = false;
            this.gbIns.Visible = false;
            // 
            // textBox4
            // 
            this.textBox4.Location = new System.Drawing.Point(10, 90);
            this.textBox4.Multiline = true;
            this.textBox4.Name = "textBox4";
            this.textBox4.Size = new System.Drawing.Size(180, 22);
            this.textBox4.TabIndex = 0;
            // 
            // textBox3
            // 
            this.textBox3.Location = new System.Drawing.Point(10, 62);
            this.textBox3.Multiline = true;
            this.textBox3.Name = "textBox3";
            this.textBox3.Size = new System.Drawing.Size(180, 22);
            this.textBox3.TabIndex = 0;
            // 
            // textBox2
            // 
            this.textBox2.Location = new System.Drawing.Point(10, 34);
            this.textBox2.Multiline = true;
            this.textBox2.Name = "textBox2";
            this.textBox2.Size = new System.Drawing.Size(180, 22);
            this.textBox2.TabIndex = 0;
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(10, 6);
            this.textBox1.Multiline = true;
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(180, 22);
            this.textBox1.TabIndex = 0;
            // 
            // btIns
            // 
            this.btIns.Dock = System.Windows.Forms.DockStyle.Top;
            this.btIns.Location = new System.Drawing.Point(0, 50);
            this.btIns.Name = "btIns";
            this.btIns.Size = new System.Drawing.Size(200, 22);
            this.btIns.TabIndex = 3;
            this.btIns.Text = "Добавить";
            this.btIns.UseVisualStyleBackColor = true;
            this.btIns.Click += new System.EventHandler(this.btIns_Click);
            // 
            // panel2
            // 
            this.panel2.Controls.Add(this.btSearch);
            this.panel2.Controls.Add(this.tbSearch);
            this.panel2.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel2.Location = new System.Drawing.Point(0, 0);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(200, 50);
            this.panel2.TabIndex = 0;
            // 
            // btSearch
            // 
            this.btSearch.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btSearch.BackgroundImage")));
            this.btSearch.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.btSearch.Location = new System.Drawing.Point(171, 17);
            this.btSearch.Name = "btSearch";
            this.btSearch.Size = new System.Drawing.Size(16, 16);
            this.btSearch.TabIndex = 22;
            this.btSearch.TabStop = false;
            // 
            // tbSearch
            // 
            this.tbSearch.Location = new System.Drawing.Point(10, 14);
            this.tbSearch.Multiline = true;
            this.tbSearch.Name = "tbSearch";
            this.tbSearch.PlaceholderText = "Search";
            this.tbSearch.Size = new System.Drawing.Size(180, 22);
            this.tbSearch.TabIndex = 21;
            this.tbSearch.TextChanged += new System.EventHandler(this.tbSearch_TextChanged);
            // 
            // EquipForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.panel1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "EquipForm";
            this.Text = "EquipForm";
            this.Load += new System.EventHandler(this.EquipForm_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.panel1.ResumeLayout(false);
            this.gbDel.ResumeLayout(false);
            this.gbDel.PerformLayout();
            this.gbUpd.ResumeLayout(false);
            this.gbUpd.PerformLayout();
            this.gbIns.ResumeLayout(false);
            this.gbIns.PerformLayout();
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.btSearch)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private DataGridView dataGridView1;
        private ToolStripPanel BottomToolStripPanel;
        private ToolStripPanel TopToolStripPanel;
        private ToolStripPanel RightToolStripPanel;
        private ToolStripPanel LeftToolStripPanel;
        private ToolStripContentPanel ContentPanel;
        private Panel panel1;
        private Button btUpd;
        private GroupBox gbIns;
        private TextBox textBox4;
        private TextBox textBox3;
        private TextBox textBox2;
        private TextBox textBox1;
        private Button btIns;
        private Panel panel2;
        private PictureBox btSearch;
        private TextBox tbSearch;
        private TextBox tbDel;
        private Button btDel;
        private GroupBox gbUpd;
        private TextBox textBox8;
        private TextBox textBox7;
        private TextBox textBox6;
        private TextBox textBox5;
        private GroupBox gbDel;
    }
}