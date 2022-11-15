using MySqlConnector;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace kursproga
{
    internal class DB
    {
        MySqlConnection connection = new MySqlConnection("Server=cfif31.ru;Port=3306;Username=ISPr23-35_TazetdinovRR;Password=ISPr23-35_TazetdinovRR;Database=ISPr23-35_TazetdinovRR_kurs");

        public void openConnection()
        {
            if(connection.State == System.Data.ConnectionState.Closed)
                connection.Open();
        }
        public void closeConnection()
        {
            if (connection.State == System.Data.ConnectionState.Open)
                connection.Close();
        }
        public MySqlConnection getConnection()
        {
            return connection;
        }
    }
}
