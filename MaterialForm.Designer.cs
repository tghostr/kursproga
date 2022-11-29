namespace kursproga
{
    partial class MaterialForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MaterialForm));
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
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
            this.dataGridView1.TabIndex = 17;
            this.dataGridView1.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellClick);
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
            this.panel1.TabIndex = 21;
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
            this.tbDel.PlaceholderText = "Код Материала";
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
            this.textBox8.PlaceholderText = "Количество";
            this.textBox8.Size = new System.Drawing.Size(180, 22);
            this.textBox8.TabIndex = 0;
            // 
            // textBox7
            // 
            this.textBox7.Location = new System.Drawing.Point(10, 62);
            this.textBox7.Multiline = true;
            this.textBox7.Name = "textBox7";
            this.textBox7.PlaceholderText = "Цена";
            this.textBox7.Size = new System.Drawing.Size(180, 22);
            this.textBox7.TabIndex = 0;
            // 
            // textBox6
            // 
            this.textBox6.Location = new System.Drawing.Point(10, 34);
            this.textBox6.Multiline = true;
            this.textBox6.Name = "textBox6";
            this.textBox6.PlaceholderText = "Единица измерения";
            this.textBox6.Size = new System.Drawing.Size(180, 22);
            this.textBox6.TabIndex = 0;
            // 
            // textBox5
            // 
            this.textBox5.Location = new System.Drawing.Point(10, 6);
            this.textBox5.Multiline = true;
            this.textBox5.Name = "textBox5";
            this.textBox5.PlaceholderText = "Название";
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
            this.textBox4.PlaceholderText = "Количество";
            this.textBox4.Size = new System.Drawing.Size(180, 22);
            this.textBox4.TabIndex = 0;
            // 
            // textBox3
            // 
            this.textBox3.Location = new System.Drawing.Point(10, 62);
            this.textBox3.Multiline = true;
            this.textBox3.Name = "textBox3";
            this.textBox3.PlaceholderText = "Цена";
            this.textBox3.Size = new System.Drawing.Size(180, 22);
            this.textBox3.TabIndex = 0;
            // 
            // textBox2
            // 
            this.textBox2.Location = new System.Drawing.Point(10, 34);
            this.textBox2.Multiline = true;
            this.textBox2.Name = "textBox2";
            this.textBox2.PlaceholderText = "Единица измерения";
            this.textBox2.Size = new System.Drawing.Size(180, 22);
            this.textBox2.TabIndex = 0;
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(10, 6);
            this.textBox1.Multiline = true;
            this.textBox1.Name = "textBox1";
            this.textBox1.PlaceholderText = "Название";
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
            this.btSearch.Click += new System.EventHandler(this.btSearch_Click);
            // 
            // tbSearch
            // 
            this.tbSearch.Location = new System.Drawing.Point(10, 14);
            this.tbSearch.Multiline = true;
            this.tbSearch.Name = "tbSearch";
            this.tbSearch.PlaceholderText = "Поиск";
            this.tbSearch.Size = new System.Drawing.Size(180, 22);
            this.tbSearch.TabIndex = 21;
            this.tbSearch.Click += new System.EventHandler(this.tbSearch_TextChanged);
            // 
            // MaterialForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.dataGridView1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "MaterialForm";
            this.Text = "MaterialForm";
            this.Load += new System.EventHandler(this.MaterialForm_Load);
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
        private Panel panel1;
        private GroupBox gbDel;
        private TextBox tbDel;
        private Button btDel;
        private GroupBox gbUpd;
        private TextBox textBox8;
        private TextBox textBox7;
        private TextBox textBox6;
        private TextBox textBox5;
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
    }
}