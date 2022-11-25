using MySqlConnector;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace kursproga
{
    public partial class EquipForm : Form
    {
        public EquipForm()
        {
            InitializeComponent();
        }
        
        
        private void EquipForm_Load(object sender, EventArgs e)
        {
            DB db = new DB();
            DataTable table = new DataTable();
            MySqlDataAdapter adapter = new MySqlDataAdapter();
            MySqlCommand command = new MySqlCommand("Select * from `equipment`", db.getConnection());
            adapter.SelectCommand = command;
            adapter.Fill(table);
            dataGridView1.DataSource = table;

            dataGridView1.Columns[0].HeaderText = "Код Оборудования";
            dataGridView1.Columns[1].HeaderText = "Название";
            dataGridView1.Columns[2].HeaderText = "Единица измерения";
            dataGridView1.Columns[3].HeaderText = "Цена";
            dataGridView1.Columns[4].HeaderText = "Количество";
            dataGridView1.Columns[5].HeaderText = "Стоимость";
        }

        private void btSearch_Click(object sender, EventArgs e)
        {
            DB db = new DB();
            DataTable table = new DataTable();
            MySqlDataAdapter adapter = new MySqlDataAdapter();
            MySqlCommand command = new MySqlCommand("SELECT * FROM equipment WHERE CONCAT(`idequipment`, `emname`, `emunit`, `emprice`, `emnumber`, `emcost`) like '%"+tbSearch.Text+"%'", db.getConnection());

            adapter.SelectCommand = command;
            adapter.Fill(table);
            dataGridView1.DataSource = table;

            dataGridView1.Columns[0].HeaderText = "Код Оборудования";
            dataGridView1.Columns[1].HeaderText = "Название";
            dataGridView1.Columns[2].HeaderText = "Единица измерения";
            dataGridView1.Columns[3].HeaderText = "Цена";
            dataGridView1.Columns[4].HeaderText = "Количество";
            dataGridView1.Columns[5].HeaderText = "Стоимость";

        }

        private void tbSearch_TextChanged(object sender, EventArgs e)
        {
            btSearch_Click(sender, e);
        }

        private void btUpd_Click(object sender, EventArgs e)
        {
            btSearch_Click(sender, e);
        }

        private void btIns_Click(object sender, EventArgs e)
        {
            if(gbIns.Visible == false)
            {
                gbIns.Visible = true;
                textBox1.Focus();
            }
            if (gbIns.Visible == true && !string.IsNullOrEmpty(textBox1.Text))
            {
                int emprice = Convert.ToInt32(textBox3.Text);
                int emnumber = Convert.ToInt32(textBox4.Text);
                int emcost = emprice * emnumber;
                DB db = new DB();
                MySqlCommand command = new MySqlCommand("INSERT INTO `equipment`(`emname`, `emunit`, `emprice`, `emnumber`, `emcost`) VALUES('"+textBox1.Text+"', '"+textBox2.Text+"', '" + textBox3.Text + "', '" + textBox4.Text + "', '" + emcost + "');", db.getConnection());
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
                }catch(Exception ex)
                {
                    MessageBox.Show(ex.Message);
                }
                foreach(Control c in gbIns.Controls)
                {
                    if(c is TextBox)
                    {
                        c.Text = null;
                    }
                }
                EquipForm_Load(sender,e);
                gbIns.Visible = false;
            }
        }
    }
}
