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

namespace kursproga
{
    public partial class RequestForm : Form
    {
        public RequestForm()
        {
            InitializeComponent();
        }

        private void RequestForm_Load(object sender, EventArgs e)
        {
            DB db = new DB();
            DataTable table = new DataTable();
            MySqlDataAdapter adapter = new MySqlDataAdapter();

            MySqlCommand command = new MySqlCommand("Select * from `request`", db.getConnection());

            adapter.SelectCommand = command;
            adapter.Fill(table);
            dataGridView1.DataSource = table;

            dataGridView1.Columns[0].HeaderText = "Код Заявки";
            dataGridView1.Columns[1].HeaderText = "Сотрудник";
            dataGridView1.Columns[2].HeaderText = "Дата";
            dataGridView1.Columns[3].HeaderText = "Оборудование";
            dataGridView1.Columns[4].HeaderText = "Материал";
            dataGridView1.Columns[5].HeaderText = "Количество";
        }

        private void btIns_Click(object sender, EventArgs e)
        {
            NewRequestForm nrform = new NewRequestForm();
            nrform.Show();
        }
        private void btSearch_Click(object sender, EventArgs e)
        {
            DB db = new DB();
            DataTable table = new DataTable();
            MySqlDataAdapter adapter = new MySqlDataAdapter();
            MySqlCommand command = new MySqlCommand("SELECT * FROM request WHERE CONCAT(`idrequest`, `staff_idStaff`, `reqdata`, `equipment_idequipment`, `material_idmaterial`, `reqnumber`) like '%" + tbSearch.Text + "%'", db.getConnection());

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

        private void btDel_Click(object sender, EventArgs e)
        {
            if (gbDel.Visible == false)
            {
                tbDel.Text = null;
                showgb(gbDel);
                tbDel.Focus();
            }
            if (gbDel.Visible == true && !string.IsNullOrEmpty(tbDel.Text))
            {
                DB db = new DB();
                MySqlCommand command = new MySqlCommand("DELETE FROM request WHERE idrequest = '" + tbDel.Text + "'", db.getConnection());
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
                RequestForm_Load(sender, e);
                hidegb();
            }
        }
        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            int id = Convert.ToInt32(dataGridView1.CurrentRow.Cells[0].Value.ToString());
            tbDel.Text = id.ToString();
            textBox5.Text = dataGridView1.CurrentRow.Cells[1].Value.ToString();
            textBox6.Text = dataGridView1.CurrentRow.Cells[2].Value.ToString();
            textBox7.Text = dataGridView1.CurrentRow.Cells[3].Value.ToString();
            textBox8.Text = dataGridView1.CurrentRow.Cells[4].Value.ToString();
        }
        private void hidegb()
        {
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
                MySqlCommand command = new MySqlCommand("UPDATE `request` SET emname='" + textBox5.Text + "', emunit='" + textBox6.Text + "', emprice='" + textBox7.Text + "', emnumber='" + textBox8.Text + "', emcost='" + emcost + "' WHERE idrequest='" + id + "' ;", db.getConnection());
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
                RequestForm_Load(sender, e);
                hidegb();
            }
        }
    }
}
