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
using MaterialSkin;
using MaterialSkin.Controls;

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
        public void ShowForm(object form)
        {
            panelForm.Controls.Clear();
            Form sform = form as Form;
            sform.TopLevel= false;
            panelForm.Controls.Add(sform);
            panelForm.Tag = sform;
            sform.Show();
        }
        private void tsbtEquip_Click(object sender, EventArgs e)
        {
            ShowForm(new EquipForm());
        }
        private void tsbtStaff_Click(object sender, EventArgs e)
        {
            ShowForm(new StaffForm());
        }
        private void tsbtExit_Click(object sender, EventArgs e)
        {
            this.Close();
            AuthForm authForm = new AuthForm();
            authForm.Show();
        }
        private void tsbtMaterial_Click(object sender, EventArgs e)
        {
            ShowForm(new MaterialForm());
        }
        private void tsbtReq_Click(object sender, EventArgs e)
        {
            ShowForm(new RequestForm());
        }
        private void tsbtAuth_Click(object sender, EventArgs e)
        {
            ShowForm(new TableAuthForm());
        }


        private void MainForm_Load(object sender, EventArgs e)
        {

        }
    }
}
