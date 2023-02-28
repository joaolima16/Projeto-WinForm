using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Data.SQLite;
using System.Linq;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;

namespace App_Teste.Connection
{
    public class Connection
    {
        
        public string Id { get; set; }


        public static SQLiteConnection connectionSLite()
        {
            string url = "Data source=C:\\Users\\joão vitor\\source\\repos\\App-Teste\\App-Teste\\Db\\Dbflange";
            SQLiteConnection conn = new SQLiteConnection(url);
            conn.Open();
            MessageBox.Show("Conectado");
            return conn;
        }
       
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
        public static SQLiteDataReader reader(String parameter)
        {
            SQLiteDataReader reader;
            using (var cmd = connectionSLite().CreateCommand())
            {
                cmd.CommandText = "SELECT * FROM norma WHERE NOME=@nome";
                cmd.Parameters.AddWithValue("@nome", parameter);
                reader = cmd.ExecuteReader();
                if (reader.Read())
                {
                    MessageBox.Show(reader.Read().ToString());
                }

            }
            var conn = connectionSLite();
            conn.Open();
            string comando = "SELECT * FROM NORMA WHERE NOME=@nome";
            SQLiteCommand command = new SQLiteCommand(comando, conn);
            command.Parameters.AddWithValue("@nome", parameter);
            if(reader.Read())
            {
                MessageBox.Show(reader.Read().ToString());
            }
            return reader;
            }

        public static SQLiteDataReader GetDatas(String parameter)
        {
            var conn = connectionSLite();
            conn.Open();
            string command_text = "SELECT diametro_furacao,diametro_furo FROM dimensoes WHERE DN=@dn";
            SQLiteCommand comando = new SQLiteCommand(command_text, conn);
            comando.Parameters.AddWithValue("@dn", parameter);
            SQLiteDataReader reader = comando.ExecuteReader();
            return reader;
            
        }

        public static List<string> readerDN(string nome, string classe_pressao)
        {
            Connection id = new Connection();
            var conn = connection();
            conn.Open();
            string comando = "SELECT id FROM NORMA WHERE NOME=@nome and ESPESSURA=@espessura";
            List<string> data = new List<string>();
            MySqlCommand command = new MySqlCommand( comando,conn);
            command.Parameters.AddWithValue("@nome", nome);
            command.Parameters.AddWithValue("@espessura", classe_pressao);

            MySqlDataReader reader = command.ExecuteReader();
            if(reader.Read())
            {


                MessageBox.Show(reader.GetString(0));
                id.Id = reader.GetString(0);
                reader.Close();
                string data_command = "SELECT DN FROM DIMENSOES WHERE ID_NORMA=@id";
                command = new MySqlCommand(data_command, conn);
                command.Parameters.AddWithValue("@id", id.Id);
                MySqlDataReader readerTickness = command.ExecuteReader();
                

                while (readerTickness.Read())
                {
                    data.Add(readerTickness.GetString(0));
                    
                }     
            }         
            conn.Close();
            return data;

        }
    }
        
    }
