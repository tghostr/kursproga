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
        int id = 0;
        public RequestForm()
        {
            InitializeComponent();
            tbSearch.MaxLength = 32;
        }

        private void RequestForm_Load(object sender, EventArgs e)
        {
            DB db = new DB();
            DataTable table = new DataTable();
            MySqlDataAdapter adapter = new MySqlDataAdapter();

            MySqlCommand command = new MySqlCommand("select * from `request`", db.getConnection());

            adapter.SelectCommand = command;
            adapter.Fill(table);
            dataGridView1.DataSource = table;

            dataGridView1.Columns[0].HeaderText = "Код Заявки";
            dataGridView1.Columns[1].HeaderText = "Код Сотрудника";
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
            MySqlCommand command = new MySqlCommand("select * from request WHERE CONCAT(`idrequest`, `staff_idStaff`, `reqdata`, `equipment_idequipment`, `material_idmaterial`, `reqnumber`) like '%" + tbSearch.Text+"%'", db.getConnection());

            adapter.SelectCommand = command;
            adapter.Fill(table);
            dataGridView1.DataSource = table;

            dataGridView1.Columns[0].HeaderText = "Код Заявки";
            dataGridView1.Columns[1].HeaderText = "Код Сотрудника";
            dataGridView1.Columns[2].HeaderText = "Дата";
            dataGridView1.Columns[3].HeaderText = "Оборудование";
            dataGridView1.Columns[4].HeaderText = "Материал";
            dataGridView1.Columns[5].HeaderText = "Количество";

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
            if (gbDel.Visible == true)
            {
                if (!string.IsNullOrEmpty(tbDel.Text))
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
                else if (string.IsNullOrEmpty(tbDel.Text))
                {
                    MessageBox.Show("Заполните поле", "Внимание", MessageBoxButtons.OK, MessageBoxIcon.Information, MessageBoxDefaultButton.Button1);
                    return;
                }
            }
        }
        private void dataGridView1_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            try
            {
                int id = Convert.ToInt32(dataGridView1.CurrentRow.Cells[0].Value.ToString());
                tbDel.Text = id.ToString();
                textBox5.Text = dataGridView1.CurrentRow.Cells[1].Value.ToString();
                textBox6.Text = dataGridView1.CurrentRow.Cells[2].Value.ToString();
                textBox7.Text = dataGridView1.CurrentRow.Cells[3].Value.ToString();
                textBox8.Text = dataGridView1.CurrentRow.Cells[4].Value.ToString();
            }
            catch
            {
                MessageBox.Show("Выберите другую ячейку!", "Внимание", MessageBoxButtons.OK, MessageBoxIcon.Exclamation, MessageBoxDefaultButton.Button1);
            }
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
            if (gbUpd.Visible == false)
            {
                try
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
                catch
                {
                    MessageBox.Show("В таблице отсутствуют записи!", "Внимание", MessageBoxButtons.OK, MessageBoxIcon.Exclamation, MessageBoxDefaultButton.Button1);
                }
            }
            if (gbUpd.Visible == true && !string.IsNullOrEmpty(textBox5.Text))
            {
                if(!string.IsNullOrEmpty(textBox5.Text) && !string.IsNullOrEmpty(textBox6.Text) && !string.IsNullOrEmpty(dateTimePicker1.Text) && !string.IsNullOrEmpty(textBox7.Text) && !string.IsNullOrEmpty(textBox8.Text))
                {
                    if (dataGridView1.Rows.Count > 0) { id = Convert.ToInt32(dataGridView1.CurrentRow.Cells[0].Value.ToString()); }
                    DB db = new DB();
                    MySqlCommand command = new MySqlCommand("UPDATE `request` SET staff_idStaff='" + textBox5.Text + "', reqdata='" + dateTimePicker1.Text + "', equipment_idequipment='" + textBox6.Text + "', material_idmaterial='" + textBox7.Text + "', reqnumber='" + textBox8.Text + "' WHERE idrequest='" + id + "' ;", db.getConnection());
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
                else if (string.IsNullOrEmpty(textBox5.Text) || string.IsNullOrEmpty(textBox6.Text) || string.IsNullOrEmpty(dateTimePicker1.Text) || string.IsNullOrEmpty(textBox7.Text) || string.IsNullOrEmpty(textBox8.Text))
                {
                    MessageBox.Show("Все поля должны быть заполнены!", "Внимание", MessageBoxButtons.OK, MessageBoxIcon.Information, MessageBoxDefaultButton.Button1);
                    return;
                }
            }
        }
    }
}
