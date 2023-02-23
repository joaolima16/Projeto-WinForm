using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;

namespace App_Teste.Connection
{
    public class Connection
    {
        
        public string Id { get; set; }
     
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
            string comando = "SELECT * FROM NORMA WHERE NOME=@nome";
            MySqlCommand command = new MySqlCommand(comando,conn);
            command.CommandType = System.Data.CommandType.Text;
            command.Parameters.AddWithValue("@nome", parameter);
            MySqlDataReader reader = command.ExecuteReader();
            return reader;
            }

        public static MySqlDataReader GetDatas(String parameter)
        {
            var conn = connection();
            conn.Open();
            string command_text = "SELECT diametro_furacao,diametro_furo FROM dimensoes WHERE DN=@dn";
            MySqlCommand comando = new MySqlCommand(command_text, conn);
            comando.Parameters.AddWithValue("@dn", parameter);
            MySqlDataReader reader = comando.ExecuteReader();
            return reader;
            
        }

        public static List<string> readerDN(string nome, string espessura)
        {
            Connection id = new Connection();
            var conn = connection();
            conn.Open();
            string comando = "SELECT id FROM NORMA WHERE NOME=@nome and ESPESSURA=@espessura";
            List<string> data = new List<string>();
            MySqlCommand command = new MySqlCommand( comando,conn);
            command.Parameters.AddWithValue("@nome", nome);
            command.Parameters.AddWithValue("@espessura", espessura);

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
