﻿using MySqlConnector;
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
    public partial class TableAuthForm : Form
    {
        int st = Convert.ToInt32(Global.GlobalVar);
        int id = 0;
        public TableAuthForm()
        {
            InitializeComponent();
            tbSearch.MaxLength = 32;
        }

        private void TableAuthForm_Load(object sender, EventArgs e)
        {
            DB db = new DB();
            DataTable table = new DataTable();
            MySqlDataAdapter adapter = new MySqlDataAdapter();
            MySqlCommand command = new MySqlCommand("Select * from `authorization`", db.getConnection());
            adapter.SelectCommand = command;
            adapter.Fill(table);
            dataGridView1.DataSource = table;

            dataGridView1.Columns[0].HeaderText = "Код Авторизации";
            dataGridView1.Columns[1].HeaderText = "Логин";
            dataGridView1.Columns[2].HeaderText = "Пароль";
            dataGridView1.Columns[3].HeaderText = "Уровень доступа";
        }
        private void btSearch_Click(object sender, EventArgs e)
        {
            DB db = new DB();
            DataTable table = new DataTable();
            MySqlDataAdapter adapter = new MySqlDataAdapter();
            MySqlCommand command = new MySqlCommand("SELECT * FROM authorization WHERE CONCAT(`idAuthorization`,`idstaff`, `login`, `pass`, `perms`) like '%" + tbSearch.Text + "%'", db.getConnection());

            adapter.SelectCommand = command;
            adapter.Fill(table);
            dataGridView1.DataSource = table;
            dataGridView1.Columns[0].HeaderText = "Код Авторизации";
            dataGridView1.Columns[1].HeaderText = "Код Сотрудника";
            dataGridView1.Columns[2].HeaderText = "Логин";
            dataGridView1.Columns[3].HeaderText = "Пароль";
            dataGridView1.Columns[4].HeaderText = "Уровень доступа";

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
                    gbUpd.Visible = true;
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
            if (gbUpd.Visible == true && !string.IsNullOrEmpty(textBox5.Text) && !string.IsNullOrEmpty(textBox6.Text) && !string.IsNullOrEmpty(textBox7.Text))
            {
                if (dataGridView1.Rows.Count > 0) { id = Convert.ToInt32(dataGridView1.CurrentRow.Cells[0].Value.ToString()); }
                DB db = new DB();
                MySqlCommand command = new MySqlCommand("UPDATE `authorization` SET login='" + textBox5.Text + "', pass='" + textBox6.Text + "', perms='" + textBox7.Text + "' WHERE idAuthorization='"+id+"';", db.getConnection());
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
                TableAuthForm_Load(sender, e);
                hidegb();
            }
            else if (string.IsNullOrEmpty(textBox1.Text) || string.IsNullOrEmpty(textBox2.Text) || string.IsNullOrEmpty(textBox3.Text))
            {
                MessageBox.Show("Все поля должны быть заполнены!", "Внимание", MessageBoxButtons.OK, MessageBoxIcon.Information, MessageBoxDefaultButton.Button1);
                return;
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

                if (!string.IsNullOrEmpty(textBox1.Text) && !string.IsNullOrEmpty(textBox2.Text) && !string.IsNullOrEmpty(textBox3.Text))
                {
                    DB db = new DB();
                    MySqlCommand command = new MySqlCommand("INSERT INTO `authorization`( `idstaff`, `login`, `pass`, `perms`) VALUES('" + st + "', '" + textBox1.Text + "', '" + textBox2.Text + "', '" + textBox3.Text + "');", db.getConnection());
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
                    TableAuthForm_Load(sender, e);
                    hidegb();
                }
                else if (string.IsNullOrEmpty(textBox1.Text) || string.IsNullOrEmpty(textBox2.Text) || string.IsNullOrEmpty(textBox3.Text))
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
                    MySqlCommand command = new MySqlCommand("DELETE FROM authorization WHERE idAuthorization = '" + tbDel.Text + "'", db.getConnection());
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
                    TableAuthForm_Load(sender, e);
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
                textBox3.Text = textBox7.Text = dataGridView1.CurrentRow.Cells[3].Value.ToString();
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
