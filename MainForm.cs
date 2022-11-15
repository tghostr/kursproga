using MySqlConnector;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.Common;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace kursproga
{
    public partial class MainForm : Form
    {
        DB db = new DB();
        DataTable table = new DataTable();
        MySqlDataAdapter adapter = new MySqlDataAdapter();

        DataSet ds = new DataSet();

        public MainForm()
        {
            InitializeComponent();
        }

        private void toolStripButton6_Click(object sender, EventArgs e)
        {
            ds.Clear();
            table.Clear();
            MySqlCommand command = new MySqlCommand("Select * from `equipment`", db.getConnection());

            adapter.SelectCommand = command;
            adapter.Fill(ds);
            dataGridView1.DataSource = ds.Tables[0];

            dataGridView1.Columns[0].HeaderText = "Код Оборудования";
            dataGridView1.Columns[1].HeaderText = "Название";
            dataGridView1.Columns[2].HeaderText = "Единица измерения";
            dataGridView1.Columns[3].HeaderText = "Цена";
            dataGridView1.Columns[4].HeaderText = "Количество";
            dataGridView1.Columns[5].HeaderText = "Стоимость";
        }

        private void toolStripButton5_Click(object sender, EventArgs e)
        {
            ds.Clear();
            table.Clear();
            MySqlCommand command = new MySqlCommand("Select * from `staff`", db.getConnection());
            adapter.SelectCommand = command;
            adapter.Fill(ds);

            dataGridView1.DataSource = ds.Tables[0];
            dataGridView1.Columns[0].HeaderText = "Код Сотрудника";
            dataGridView1.Columns[1].HeaderText = "Имя";
            dataGridView1.Columns[2].HeaderText = "Фамилияя";
            dataGridView1.Columns[3].HeaderText = "Дата рождения";
            dataGridView1.Columns[4].HeaderText = "Авторизация";
        }

        private void toolStripButton2_Click(object sender, EventArgs e)
        {
            ds.Clear();
        }
    }
}
