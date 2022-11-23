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
        public StaffForm()
        {
            InitializeComponent();
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
            dataGridView1.Columns[2].HeaderText = "Фамилияя";
            dataGridView1.Columns[3].HeaderText = "Дата рождения";
            dataGridView1.Columns[4].HeaderText = "Авторизация";
        }
    }
}
