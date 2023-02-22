using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace App_Teste.Connection
{
    internal class Connection
    {
        public static MySqlConnection connection()
        {
            string data_source = "datasource=localhost;user=root;database=flange";
            MySqlConnection connection = new MySqlConnection(data_source);
            try
            {
                connection.Open();
                return connection;
            }
            catch (Exception ex)
            {
                MessageBox.Show("Conexão não realizada!" + ex.Message);
                return connection;
            }
            finally
            {
                connection.Close();
            }

        }
        public static MySqlDataReader reader(String parameter)
        {
            var conn = connection();
            conn.Open();
            MessageBox.Show(parameter);
            string comando = "SELECT * FROM NORMA WHERE NOME=@nome";
            MySqlCommand command = new MySqlCommand(comando,conn);
            command.CommandType = System.Data.CommandType.Text;
            command.Parameters.AddWithValue("@nome", parameter);
            MySqlDataReader reader = command.ExecuteReader();
            return reader;
            }
        }
    }
