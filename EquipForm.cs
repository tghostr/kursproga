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
            int id = Convert.ToInt32(dataGridView1.CurrentRow.Cells[0].Value.ToString());
            if (gbUpd.Visible == false)
            {
                showgb(gbUpd);
                gbUpd.Visible = true;
                textBox5.Focus();
                foreach (Control c in gbUpd.Controls)
                {
                    if (c is TextBox)
                    {
                        c.Text = null;
                    }
                }
            }
            if (gbUpd.Visible == true && !string.IsNullOrEmpty(textBox5.Text))
            {
                int emprice = Convert.ToInt32(textBox7.Text);
                int emnumber = Convert.ToInt32(textBox8.Text);
                int emcost = emprice * emnumber;
                DB db = new DB();
                MySqlCommand command = new MySqlCommand("UPDATE `equipment` SET emname='" + textBox5.Text + "', emunit='" + textBox6.Text + "', emprice='"+textBox7.Text+"', emnumber='"+textBox8.Text+"', emcost='"+emcost+ "' WHERE idequipment='"+id+"' ;", db.getConnection());
                db.openConnection();
                try
                {
                    if (command.ExecuteNonQuery() == 1)
                    {
                        MessageBox.Show("Данные обновлены");
                    }
                    else
                    {
                        MessageBox.Show("Данные не обновлены");
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message);
                }
                foreach (Control c in gbUpd.Controls)
                {
                    if (c is TextBox)
                    {
                        c.Text = null;
                    }
                }
                EquipForm_Load(sender, e);
                hidegb();
            }
        }
        private void btIns_Click(object sender, EventArgs e)
        {
            if (gbIns.Visible == false)
            {
                showgb(gbIns);
                textBox1.Focus();
                foreach (Control c in gbIns.Controls)
                {
                    if (c is TextBox)
                    {
                        c.Text = null;
                    }
                }
            }
            if (gbIns.Visible == true && !string.IsNullOrEmpty(textBox1.Text))
            {
                int emprice = Convert.ToInt32(textBox3.Text);
                int emnumber = Convert.ToInt32(textBox4.Text);
                int emcost = emprice * emnumber;
                DB db = new DB();
                MySqlCommand command = new MySqlCommand("INSERT INTO `equipment`(`emname`, `emunit`, `emprice`, `emnumber`, `emcost`) VALUES('" + textBox1.Text + "', '" + textBox2.Text + "', '" + textBox3.Text + "', '" + textBox4.Text + "', '" + emcost + "');", db.getConnection());
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
                    if (c is TextBox)
                    {
                        c.Text = null;
                    }
                }
                EquipForm_Load(sender, e);
                hidegb();
            }
        }

        private void btDel_Click(object sender, EventArgs e)
        {
            if (gbDel.Visible == false)
            {
                showgb(gbDel);
                tbDel.Focus();
            }
            if (gbDel.Visible == true && !string.IsNullOrEmpty(tbDel.Text))
            {
                DB db = new DB();
                MySqlCommand command = new MySqlCommand("DELETE FROM equipment WHERE idequipment = '" + tbDel.Text + "'", db.getConnection());
                db.openConnection();
                if (command.ExecuteNonQuery() == 1)
                {
                    MessageBox.Show("Данные удалены");
                }
                else
                {
                    MessageBox.Show("Данные не удалены");
                }
                tbDel.Text = null;
                EquipForm_Load(sender, e);
                hidegb();
            }
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            int id = Convert.ToInt32(dataGridView1.CurrentRow.Cells[0].Value.ToString());
            tbDel.Text = id.ToString();
            textBox1.Text = textBox5.Text = dataGridView1.CurrentRow.Cells[1].Value.ToString();
            textBox2.Text = textBox6.Text = dataGridView1.CurrentRow.Cells[2].Value.ToString();
            textBox3.Text = textBox7.Text = dataGridView1.CurrentRow.Cells[3].Value.ToString();
            textBox4.Text = textBox8.Text = dataGridView1.CurrentRow.Cells[4].Value.ToString();
        }
        private void hidegb()
        {
            if (gbIns.Visible == true)
                gbIns.Visible = false;
            if (gbUpd.Visible == true)
                gbUpd.Visible = false;
            if (gbDel.Visible == true)
                gbDel.Visible = false;
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
    }
}
