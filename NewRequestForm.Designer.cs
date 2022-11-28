namespace kursproga
{
    partial class NewRequestForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(NewRequestForm));
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.panel1 = new System.Windows.Forms.Panel();
            this.radioButton2 = new System.Windows.Forms.RadioButton();
            this.radioButton1 = new System.Windows.Forms.RadioButton();
            this.gbDel = new System.Windows.Forms.GroupBox();
            this.tbDel = new System.Windows.Forms.TextBox();
            this.btDel = new System.Windows.Forms.Button();
            this.gbIns = new System.Windows.Forms.GroupBox();
            this.textBox4 = new System.Windows.Forms.TextBox();
            this.textBox3 = new System.Windows.Forms.TextBox();
            this.textBox2 = new System.Windows.Forms.TextBox();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.btIns = new System.Windows.Forms.Button();
            this.panel2 = new System.Windows.Forms.Panel();
            this.btSearch = new System.Windows.Forms.PictureBox();
            this.tbSearch = new System.Windows.Forms.TextBox();
            this.dataGridView2 = new System.Windows.Forms.DataGridView();
            this.dataGridView3 = new System.Windows.Forms.DataGridView();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.panel1.SuspendLayout();
            this.gbDel.SuspendLayout();
            this.gbIns.SuspendLayout();
            this.panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.btSearch)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView3)).BeginInit();
            this.SuspendLayout();
            // 
            // dataGridView1
            // 
            this.dataGridView1.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(0, 0);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.RowTemplate.Height = 25;
            this.dataGridView1.Size = new System.Drawing.Size(300, 450);
            this.dataGridView1.TabIndex = 4;
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.radioButton2);
            this.panel1.Controls.Add(this.radioButton1);
            this.panel1.Controls.Add(this.gbDel);
            this.panel1.Controls.Add(this.btDel);
            this.panel1.Controls.Add(this.gbIns);
            this.panel1.Controls.Add(this.btIns);
            this.panel1.Controls.Add(this.panel2);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Right;
            this.panel1.Location = new System.Drawing.Point(600, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(200, 450);
            this.panel1.TabIndex = 21;
            // 
            // radioButton2
            // 
            this.radioButton2.AutoSize = true;
            this.radioButton2.Location = new System.Drawing.Point(21, 327);
            this.radioButton2.Name = "radioButton2";
            this.radioButton2.Size = new System.Drawing.Size(80, 19);
            this.radioButton2.TabIndex = 23;
            this.radioButton2.Text = "Материал";
            this.radioButton2.UseVisualStyleBackColor = true;
            this.radioButton2.CheckedChanged += new System.EventHandler(this.radioButton2_CheckedChanged);
            // 
            // radioButton1
            // 
            this.radioButton1.AutoSize = true;
            this.radioButton1.Location = new System.Drawing.Point(21, 302);
            this.radioButton1.Name = "radioButton1";
            this.radioButton1.Size = new System.Drawing.Size(100, 19);
            this.radioButton1.TabIndex = 23;
            this.radioButton1.Text = "Оборудовние";
            this.radioButton1.UseVisualStyleBackColor = true;
            this.radioButton1.CheckedChanged += new System.EventHandler(this.radioButton1_CheckedChanged);
            // 
            // gbDel
            // 
            this.gbDel.Controls.Add(this.tbDel);
            this.gbDel.Dock = System.Windows.Forms.DockStyle.Top;
            this.gbDel.Location = new System.Drawing.Point(0, 212);
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
            this.btDel.Location = new System.Drawing.Point(0, 190);
            this.btDel.Name = "btDel";
            this.btDel.Size = new System.Drawing.Size(200, 22);
            this.btDel.TabIndex = 4;
            this.btDel.Text = "Удалить";
            this.btDel.UseVisualStyleBackColor = true;
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
            // 
            // dataGridView2
            // 
            this.dataGridView2.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView2.Location = new System.Drawing.Point(300, 0);
            this.dataGridView2.Name = "dataGridView2";
            this.dataGridView2.RowTemplate.Height = 25;
            this.dataGridView2.Size = new System.Drawing.Size(300, 450);
            this.dataGridView2.TabIndex = 22;
            // 
            // dataGridView3
            // 
            this.dataGridView3.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dataGridView3.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView3.Location = new System.Drawing.Point(0, 0);
            this.dataGridView3.Name = "dataGridView3";
            this.dataGridView3.RowTemplate.Height = 25;
            this.dataGridView3.Size = new System.Drawing.Size(300, 450);
            this.dataGridView3.TabIndex = 23;
            // 
            // NewRequestForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.dataGridView2);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.dataGridView3);
            this.Name = "NewRequestForm";
            this.Text = "NewReq";
            this.Load += new System.EventHandler(this.NewRequestForm_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.gbDel.ResumeLayout(false);
            this.gbDel.PerformLayout();
            this.gbIns.ResumeLayout(false);
            this.gbIns.PerformLayout();
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.btSearch)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView3)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion
        private DataGridView dataGridView1;
        private Panel panel1;
        private GroupBox gbDel;
        private TextBox tbDel;
        private Button btDel;
        private GroupBox gbIns;
        private TextBox textBox4;
        private TextBox textBox3;
        private TextBox textBox2;
        private TextBox textBox1;
        private Button btIns;
        private Panel panel2;
        private PictureBox btSearch;
        private TextBox tbSearch;
        private DataGridView dataGridView2;
        private RadioButton radioButton2;
        private RadioButton radioButton1;
        private DataGridView dataGridView3;
    }
}