using MySqlConnector;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace kursproga
{
    public partial class NewRequestForm : Form
    {
        public NewRequestForm()
        {
            InitializeComponent();
        }

        private void NewRequestForm_Load(object sender, EventArgs e)
        {
            DB db = new DB();
            DataTable table = new DataTable();
            MySqlDataAdapter adapter = new MySqlDataAdapter();
            MySqlCommand command = new MySqlCommand("Select `idequipment`, `emname`, `emunit`, `emnumber` from `equipment`", db.getConnection());
            adapter.SelectCommand = command;
            adapter.Fill(table);
            dataGridView1.DataSource = table;

            dataGridView1.Columns[0].HeaderText = "Код Оборудования";
            dataGridView1.Columns[1].HeaderText = "Название";
            dataGridView1.Columns[2].HeaderText = "Единица измерения";
            dataGridView1.Columns[3].HeaderText = "Количество";

            DB db1 = new DB();
            DataTable table1 = new DataTable();
            MySqlDataAdapter adapter1 = new MySqlDataAdapter();
            MySqlCommand command1 = new MySqlCommand("Select `idmaterial`, `maname`, `maunit`, `manumber` from `material`", db1.getConnection());
            adapter1.SelectCommand = command1;
            adapter1.Fill(table1);
            dataGridView3.DataSource = table1;

            dataGridView3.Columns[0].HeaderText = "Код Материала";
            dataGridView3.Columns[1].HeaderText = "Название";
            dataGridView3.Columns[2].HeaderText = "Единица измерения";
            dataGridView3.Columns[3].HeaderText = "Количество";

            dataGridView2.ColumnCount= 5;
            dataGridView2.Columns[0].HeaderText = "Код";
            dataGridView2.Columns[1].HeaderText = "Название";
            dataGridView2.Columns[2].HeaderText = "Единица измерения";
            dataGridView2.Columns[3].HeaderText = "Количество";
            dataGridView2.Columns[4].HeaderText = "Тип";
            
        }

        private void radioButton1_CheckedChanged(object sender, EventArgs e)
        {
            dataGridView3.Visible = false;
            dataGridView1.Visible = true;
        }

        private void radioButton2_CheckedChanged(object sender, EventArgs e)
        {
            dataGridView1.Visible = false;
            dataGridView3.Visible = true;
        }

        private void dataGridView2_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            try
            {
                int idk = Convert.ToInt32(dataGridView2.CurrentRow.Cells[0].Value.ToString());
            }
            catch
            {
                MessageBox.Show("Выберите другую ячейку!", "Внимание", MessageBoxButtons.OK, MessageBoxIcon.Exclamation, MessageBoxDefaultButton.Button1);
            }
        }

        private void dataGridView1_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            try
            {
                int id = Convert.ToInt32(dataGridView1.CurrentRow.Cells[0].Value.ToString());
                textBox1.Text = dataGridView1.CurrentRow.Cells[0].Value.ToString();
                textBox2.Text = dataGridView1.CurrentRow.Cells[1].Value.ToString();
                textBox3.Text = dataGridView1.CurrentRow.Cells[2].Value.ToString();
                textBox4.Text = dataGridView1.CurrentRow.Cells[3].Value.ToString();
            }
            catch
            {
                MessageBox.Show("Выберите другую ячейку!", "Внимание", MessageBoxButtons.OK, MessageBoxIcon.Exclamation, MessageBoxDefaultButton.Button1);
            }
        }

        private void dataGridView3_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            try
            {
                int id = Convert.ToInt32(dataGridView1.CurrentRow.Cells[0].Value.ToString());
                textBox1.Text = dataGridView3.CurrentRow.Cells[0].Value.ToString();
                textBox2.Text = dataGridView3.CurrentRow.Cells[1].Value.ToString();
                textBox3.Text = dataGridView3.CurrentRow.Cells[2].Value.ToString();
                textBox4.Text = dataGridView3.CurrentRow.Cells[3].Value.ToString();
            }
            catch
            {
                MessageBox.Show("Выберите другую ячейку!", "Внимание", MessageBoxButtons.OK, MessageBoxIcon.Exclamation, MessageBoxDefaultButton.Button1);
            }
        }

        private void btDel_Click(object sender, EventArgs e)
        {
            int a = dataGridView2.CurrentRow.Index;
            dataGridView2.Rows.Remove(dataGridView2.Rows[a]);
            NewRequestForm_Load(sender, e);
            hidegb();
        }

        private void btIns_Click(object sender, EventArgs e)
        {
            if (gbIns.Visible == false)
            {
                showgb(gbIns);
                textBox1.Focus();
                foreach(Control c in gbIns.Controls)
                {
                    if(c is System.Windows.Forms.TextBox)
                    {
                        c.Text = null;
                    }
                }
            }
            if (gbIns.Visible == true && !string.IsNullOrEmpty(textBox1.Text))
            {
                string type = null;
                if (radioButton1.Checked == true) { type = "O"; }
                if (radioButton2.Checked == true) { type = "M"; }
                addRow(textBox1.Text, textBox2.Text, textBox3.Text, textBox4.Text, type);
                NewRequestForm_Load(sender, e);
                hidegb();
            }
        }
        private void addRow(string id, string name, string unit, string number, string type)
        {
            String[] row = { id, name, unit, number, type };
            dataGridView2.Rows.Add(row);
        }
        private void hidegb()
        {
            if (gbIns.Visible == true)
                gbIns.Visible = false;
        }
        private void showgb(GroupBox actMenu)
        {
            if (actMenu.Visible == false)
            {
                hidegb();
                actMenu.Visible = true;
            }
            else
                actMenu.Visible = false;
        }

        private void btSave_Click(object sender, EventArgs e)
        {
            string date = DateTime.Now.ToShortDateString();
            DB db = new DB();
            MySqlCommand command = new MySqlCommand("INSERT INTO `request`(`emname`, `emunit`, `emprice`, `emnumber`, `emcost`) VALUES('" + textBox1.Text + "', '" + textBox2.Text + "', '" + "', authorization='" + "', '" + "' WHERE idstaff='" + "');", db.getConnection());
            db.openConnection();
            try
            {
                if (command.ExecuteNonQuery() == 1)
                {
                    MessageBox.Show("Данные добавлены");
                }
                else
                {
                    MessageBox.Show("Данные не добавлены");
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
            foreach (Control c in gbIns.Controls)
            {
                if (c is System.Windows.Forms.TextBox)
                {
                    c.Text = null;
                }
            }
            NewRequestForm_Load(sender, e);
        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.Close();
            AuthForm authForm = new AuthForm();
            authForm.Show();
        }
    }
}
