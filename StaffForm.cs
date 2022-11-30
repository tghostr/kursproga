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
    public partial class StaffForm : Form
    {
        int id = 0;
        public StaffForm()
        {
            InitializeComponent();
            tbSearch.MaxLength = 32;
        }

        private void StaffForm_Load(object sender, EventArgs e)
        {
            DB db = new DB();
            DataTable table = new DataTable();
            MySqlDataAdapter adapter = new MySqlDataAdapter();

            MySqlCommand command = new MySqlCommand("Select * from `staff`", db.getConnection());

            adapter.SelectCommand = command;
            adapter.Fill(table);

            dataGridView1.DataSource = table;
            dataGridView1.Columns[0].HeaderText = "Код Сотрудника";
            dataGridView1.Columns[1].HeaderText = "Имя";
            dataGridView1.Columns[2].HeaderText = "Фамилия";
            dataGridView1.Columns[3].HeaderText = "Дата рождения";
        }
        private void btSearch_Click(object sender, EventArgs e)
        {
            DB db = new DB();
            DataTable table = new DataTable();
            MySqlDataAdapter adapter = new MySqlDataAdapter();
            MySqlCommand command = new MySqlCommand("SELECT * FROM staff WHERE CONCAT(`idStaff`, `name`, `surname`, `birthdate`) like '%" + tbSearch.Text + "%'", db.getConnection());

            adapter.SelectCommand = command;
            adapter.Fill(table);
            dataGridView1.DataSource = table;

            dataGridView1.Columns[0].HeaderText = "Код Сотрудника";
            dataGridView1.Columns[1].HeaderText = "Имя";
            dataGridView1.Columns[2].HeaderText = "Фамилия";
            dataGridView1.Columns[3].HeaderText = "Дата рождения";

        }

        private void tbSearch_TextChanged(object sender, EventArgs e)
        {
            btSearch_Click(sender, e);
        }

        private void btUpd_Click(object sender, EventArgs e)
        {
            if (gbUpd.Visible == false)
            {
                try
                {
                    showgb(gbUpd);
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
            if (gbUpd.Visible == true)
            {
                String DateB = dateTimePicker2.Text;
                if (!string.IsNullOrEmpty(textBox5.Text) && !string.IsNullOrEmpty(textBox6.Text) && !string.IsNullOrEmpty(dateTimePicker2.Text))
                {
                    if (dataGridView1.Rows.Count > 0) { id = Convert.ToInt32(dataGridView1.CurrentRow.Cells[0].Value.ToString()); }
                    DB db = new DB();
                    MySqlCommand command = new MySqlCommand("UPDATE `staff` SET name='" + textBox5.Text + "', surname='" + textBox6.Text + "', birthdate=@DateB WHERE idStaff='" + id + "' ;", db.getConnection());
                    command.Parameters.Add("@DateB", MySqlDbType.Date).Value = DateB;
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
                    StaffForm_Load(sender, e);
                    hidegb();
                }
                else if (string.IsNullOrEmpty(textBox5.Text) || string.IsNullOrEmpty(textBox6.Text) || string.IsNullOrEmpty(dateTimePicker2.Text))
                {
                    MessageBox.Show("Все поля должны быть заполнены!", "Внимание", MessageBoxButtons.OK, MessageBoxIcon.Information, MessageBoxDefaultButton.Button1);
                    return;
                }
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
            if (gbIns.Visible == true)
            {
                String DateB = dateTimePicker1.Text;
                if (!string.IsNullOrEmpty(textBox1.Text) && !string.IsNullOrEmpty(textBox2.Text) && !string.IsNullOrEmpty(dateTimePicker1.Text))
                {
                    DB db = new DB();
                    MySqlCommand command = new MySqlCommand("INSERT INTO `staff`(`name`, `surname`, `birthdate`) VALUES('" + textBox1.Text + "', '" + textBox2.Text + "', @DateB);", db.getConnection());
                    db.openConnection();
                    command.Parameters.Add("@DateB", MySqlDbType.Date).Value = DateB;
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
                    StaffForm_Load(sender, e);
                    hidegb();
                }
                else if (string.IsNullOrEmpty(textBox5.Text) || string.IsNullOrEmpty(textBox6.Text) || string.IsNullOrEmpty(dateTimePicker2.Text))
                {
                    MessageBox.Show("Все поля должны быть заполнены!", "Внимание", MessageBoxButtons.OK, MessageBoxIcon.Information, MessageBoxDefaultButton.Button1);
                    return;
                }
            }
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
                    MySqlCommand command = new MySqlCommand("DELETE FROM staff WHERE idStaff = '" + tbDel.Text + "'", db.getConnection());
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
                    StaffForm_Load(sender, e);
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
                textBox1.Text = textBox5.Text = dataGridView1.CurrentRow.Cells[1].Value.ToString();
                textBox2.Text = textBox6.Text = dataGridView1.CurrentRow.Cells[2].Value.ToString();
                dateTimePicker1.Text = dateTimePicker2.Text = dataGridView1.CurrentRow.Cells[3].Value.ToString();
            }
            catch
            {
                MessageBox.Show("Выберите другую ячейку!", "Внимание", MessageBoxButtons.OK, MessageBoxIcon.Exclamation, MessageBoxDefaultButton.Button1);
            }
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
