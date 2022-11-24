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

            MySqlCommand command = new MySqlCommand("Select * from `material`", db.getConnection());

            adapter.SelectCommand = command;
            adapter.Fill(table);
            dataGridView1.DataSource = table;

            dataGridView1.Columns[0].HeaderText = "Код Заявки";
            dataGridView1.Columns[1].HeaderText = "Сотрудник";
            dataGridView1.Columns[2].HeaderText = "Дата";
        }
    }
}
