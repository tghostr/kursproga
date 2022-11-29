namespace kursproga
{
    partial class RequestForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(RequestForm));
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.panel1 = new System.Windows.Forms.Panel();
            this.gbDel = new System.Windows.Forms.GroupBox();
            this.tbDel = new System.Windows.Forms.TextBox();
            this.btDel = new System.Windows.Forms.Button();
            this.gbUpd = new System.Windows.Forms.GroupBox();
            this.dateTimePicker1 = new System.Windows.Forms.DateTimePicker();
            this.textBox8 = new System.Windows.Forms.TextBox();
            this.textBox7 = new System.Windows.Forms.TextBox();
            this.textBox6 = new System.Windows.Forms.TextBox();
            this.textBox5 = new System.Windows.Forms.TextBox();
            this.btUpd = new System.Windows.Forms.Button();
            this.btIns = new System.Windows.Forms.Button();
            this.panel2 = new System.Windows.Forms.Panel();
            this.btSearch = new System.Windows.Forms.PictureBox();
            this.tbSearch = new System.Windows.Forms.TextBox();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.panel1.SuspendLayout();
            this.gbDel.SuspendLayout();
            this.gbUpd.SuspendLayout();
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
            this.gbDel.Location = new System.Drawing.Point(0, 262);
            this.gbDel.Name = "gbDel";
            this.gbDel.Size = new System.Drawing.Size(200, 35);
            this.gbDel.TabIndex = 25;
            this.gbDel.TabStop = false;
            this.gbDel.Visible = false;
            // 
            // tbDel
            // 
            this.tbDel.Location = new System.Drawing.Point(10, 6);
            this.tbDel.Name = "tbDel";
            this.tbDel.PlaceholderText = "Код Заявки";
            this.tbDel.Size = new System.Drawing.Size(180, 23);
            this.tbDel.TabIndex = 22;
            // 
            // btDel
            // 
            this.btDel.Dock = System.Windows.Forms.DockStyle.Top;
            this.btDel.Location = new System.Drawing.Point(0, 240);
            this.btDel.Name = "btDel";
            this.btDel.Size = new System.Drawing.Size(200, 22);
            this.btDel.TabIndex = 24;
            this.btDel.Text = "Удалить";
            this.btDel.UseVisualStyleBackColor = true;
            this.btDel.Click += new System.EventHandler(this.btDel_Click);
            // 
            // gbUpd
            // 
            this.gbUpd.Controls.Add(this.dateTimePicker1);
            this.gbUpd.Controls.Add(this.textBox8);
            this.gbUpd.Controls.Add(this.textBox7);
            this.gbUpd.Controls.Add(this.textBox6);
            this.gbUpd.Controls.Add(this.textBox5);
            this.gbUpd.Dock = System.Windows.Forms.DockStyle.Top;
            this.gbUpd.Location = new System.Drawing.Point(0, 94);
            this.gbUpd.Name = "gbUpd";
            this.gbUpd.Size = new System.Drawing.Size(200, 146);
            this.gbUpd.TabIndex = 23;
            this.gbUpd.TabStop = false;
            this.gbUpd.Visible = false;
            // 
            // dateTimePicker1
            // 
            this.dateTimePicker1.Location = new System.Drawing.Point(10, 34);
            this.dateTimePicker1.Name = "dateTimePicker1";
            this.dateTimePicker1.Size = new System.Drawing.Size(180, 23);
            this.dateTimePicker1.TabIndex = 1;
            // 
            // textBox8
            // 
            this.textBox8.Location = new System.Drawing.Point(10, 119);
            this.textBox8.Multiline = true;
            this.textBox8.Name = "textBox8";
            this.textBox8.PlaceholderText = "Количество";
            this.textBox8.Size = new System.Drawing.Size(180, 22);
            this.textBox8.TabIndex = 0;
            // 
            // textBox7
            // 
            this.textBox7.Enabled = false;
            this.textBox7.Location = new System.Drawing.Point(10, 91);
            this.textBox7.Multiline = true;
            this.textBox7.Name = "textBox7";
            this.textBox7.PlaceholderText = "Материал";
            this.textBox7.Size = new System.Drawing.Size(180, 22);
            this.textBox7.TabIndex = 0;
            // 
            // textBox6
            // 
            this.textBox6.Enabled = false;
            this.textBox6.Location = new System.Drawing.Point(10, 63);
            this.textBox6.Multiline = true;
            this.textBox6.Name = "textBox6";
            this.textBox6.PlaceholderText = "Оборудование";
            this.textBox6.Size = new System.Drawing.Size(180, 22);
            this.textBox6.TabIndex = 0;
            // 
            // textBox5
            // 
            this.textBox5.Enabled = false;
            this.textBox5.Location = new System.Drawing.Point(10, 6);
            this.textBox5.Multiline = true;
            this.textBox5.Name = "textBox5";
            this.textBox5.PlaceholderText = "Код Сотрудника";
            this.textBox5.Size = new System.Drawing.Size(180, 22);
            this.textBox5.TabIndex = 0;
            // 
            // btUpd
            // 
            this.btUpd.Dock = System.Windows.Forms.DockStyle.Top;
            this.btUpd.Location = new System.Drawing.Point(0, 72);
            this.btUpd.Name = "btUpd";
            this.btUpd.Size = new System.Drawing.Size(200, 22);
            this.btUpd.TabIndex = 20;
            this.btUpd.Text = "Редактировать";
            this.btUpd.UseVisualStyleBackColor = true;
            this.btUpd.Click += new System.EventHandler(this.btUpd_Click);
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
            this.tbSearch.TextChanged += new System.EventHandler(this.tbSearch_TextChanged);
            // 
            // RequestForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.dataGridView1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "RequestForm";
            this.Text = "RequestForm";
            this.Load += new System.EventHandler(this.RequestForm_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.panel1.ResumeLayout(false);
            this.gbDel.ResumeLayout(false);
            this.gbDel.PerformLayout();
            this.gbUpd.ResumeLayout(false);
            this.gbUpd.PerformLayout();
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.btSearch)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion
        private DataGridView dataGridView1;
        private Panel panel1;
        private Button btUpd;
        private Button btIns;
        private Panel panel2;
        private PictureBox btSearch;
        private TextBox tbSearch;
        private GroupBox gbDel;
        private TextBox tbDel;
        private Button btDel;
        private GroupBox gbUpd;
        private TextBox textBox8;
        private TextBox textBox7;
        private TextBox textBox6;
        private TextBox textBox5;
        private DateTimePicker dateTimePicker1;
    }
}