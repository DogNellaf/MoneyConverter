using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace App
{
    class DB
    {
        MySqlConnection connection = new MySqlConnection("server=localhost;port=3306;username=root;password=root;database=обменный пункт");

        public void openConnection()
        {
            if (connection.State == System.Data.ConnectionState.Closed)
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

        //запрос к базе данных
        public DataTable QueryToBase(string query)
        {
            connection.Open();
            DataTable dataTable = new DataTable();

            MySqlCommand command = connection.CreateCommand();
            command.CommandText = query;

            MySqlDataAdapter adapter = new MySqlDataAdapter(command);

            adapter.AcceptChangesDuringFill = false;
            adapter.Fill(dataTable);
            connection.Close();
            return dataTable;
        }
    }
}
