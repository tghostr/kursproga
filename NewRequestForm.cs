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

            dataGridView3.Columns[0].HeaderText = "Код Оборудования";
            dataGridView3.Columns[1].HeaderText = "Название";
            dataGridView3.Columns[2].HeaderText = "Единица измерения";
            dataGridView3.Columns[3].HeaderText = "Количество";
            //if (radioButton1.Checked == true)
            //{

            //    dataGridView3.Visible = false;
            //    if (dataGridView1.Visible == false)
            //    {
            //        dataGridView1.Visible = true;
            //    }
            //}
            //else if (radioButton2.Checked == true)
            //{
            //    dataGridView1.Visible = false;
            //    if (dataGridView3.Visible == false)
            //    {
            //        dataGridView3.Visible = true;
            //    }
            //}
            if (radioButton1.Checked == true && radioButton2.Checked == false)
            {
                dataGridView3.Visible = false;
                dataGridView1.Visible = true;
                //DB db = new DB();
                //DataTable table = new DataTable();
                //MySqlDataAdapter adapter = new MySqlDataAdapter();
                //MySqlCommand command = new MySqlCommand("Select `idequipment`, `emname`, `emunit`, `emnumber` from `equipment`", db.getConnection());
                //adapter.SelectCommand = command;
                //adapter.Fill(table);
                //dataGridView1.DataSource = table;

                //dataGridView1.Columns[0].HeaderText = "Код Оборудования";
                //dataGridView1.Columns[1].HeaderText = "Название";
                //dataGridView1.Columns[2].HeaderText = "Единица измерения";
                //dataGridView1.Columns[3].HeaderText = "Количество";
                
            }
            else if (radioButton2.Checked == true && radioButton1.Checked == false)
            {
                dataGridView1.Visible = false;
                dataGridView3.Visible = true;
                //DB db1 = new DB();
                //DataTable table1 = new DataTable();
                //MySqlDataAdapter adapter1 = new MySqlDataAdapter();
                //MySqlCommand command1 = new MySqlCommand("Select `idmaterial`, `maname`, `maunit`, `manumber` from `material`", db1.getConnection());
                //adapter1.SelectCommand = command1;
                //adapter1.Fill(table1);
                //dataGridView3.DataSource = table1;

                //dataGridView3.Columns[0].HeaderText = "Код Материала";
                //dataGridView3.Columns[1].HeaderText = "Название";
                //dataGridView3.Columns[2].HeaderText = "Единица измерения";
                //dataGridView3.Columns[3].HeaderText = "Количество";
            }
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
        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            int id = Convert.ToInt32(dataGridView1.CurrentRow.Cells[0].Value.ToString());
            tbDel.Text = id.ToString();
            textBox5.Text = dataGridView1.CurrentRow.Cells[1].Value.ToString();
            textBox6.Text = dataGridView1.CurrentRow.Cells[2].Value.ToString();
            textBox7.Text = dataGridView1.CurrentRow.Cells[3].Value.ToString();
            textBox8.Text = dataGridView1.CurrentRow.Cells[4].Value.ToString();
        }
        private void dataGridView3_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            int id = Convert.ToInt32(dataGridView1.CurrentRow.Cells[0].Value.ToString());
            tbDel.Text = id.ToString();
            textBox5.Text = dataGridView1.CurrentRow.Cells[1].Value.ToString();
            textBox6.Text = dataGridView1.CurrentRow.Cells[2].Value.ToString();
            textBox7.Text = dataGridView1.CurrentRow.Cells[3].Value.ToString();
            textBox8.Text = dataGridView1.CurrentRow.Cells[4].Value.ToString();
        }
