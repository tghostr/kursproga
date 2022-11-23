using MySqlConnector;
using System.Data;

namespace kursproga
{
    public partial class AuthForm : Form
    {
        public AuthForm()
        {
            InitializeComponent();
        }

        private void btAuth_Click(object sender, EventArgs e)
        {
            String loginUser = txtLog.Text;
            String passUser = txtPass.Text;

            DB db = new DB();

            DataTable table = new DataTable();

            MySqlDataAdapter adapter = new MySqlDataAdapter();

            MySqlCommand command = new MySqlCommand("Select * from `authorization` where `login` = @uL AND `pass` = @uP AND `perms` = 1", db.getConnection());
            command.Parameters.Add("@uL", MySqlDbType.VarChar).Value = loginUser;
            command.Parameters.Add("@uP", MySqlDbType.VarChar).Value = passUser;

            adapter.SelectCommand = command;
            adapter.Fill(table);

            if (table.Rows.Count > 0)
            {
                this.Hide();
                MainForm mainForm = new MainForm();
                mainForm.Show();
            }
            else
            {
                command = new MySqlCommand("Select * from `authorization` where `login` = @uL AND `pass` = @uP AND `perms` = 0", db.getConnection());
                command.Parameters.Add("@uL", MySqlDbType.VarChar).Value = loginUser;
                command.Parameters.Add("@uP", MySqlDbType.VarChar).Value = passUser;

                adapter.SelectCommand = command;
                adapter.Fill(table);

                if (table.Rows.Count > 0)
                {
                    this.Hide();
                    EquipForm equipForm = new EquipForm();
                    equipForm.Show();
                }
                else
                    MessageBox.Show("Failed!");
            }
        }

        private void cbPass_CheckedChanged(object sender, EventArgs e)
        {
            if (cbPass.Checked) { txtPass.PasswordChar = (char)0; }
            else { txtPass.PasswordChar = (char)1; }
        }
    }
}