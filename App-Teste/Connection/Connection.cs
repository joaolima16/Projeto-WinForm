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
using static System.ComponentModel.Design.ObjectSelectorEditor;

namespace App_Teste.Connection
{
    public class Connection
    {

        public long Id { get; set; }


        public static SQLiteConnection connectionSLite()
        {
            string url = "Data source=C:\\Users\\joão vitor\\source\\repos\\App-Teste\\App-Teste\\Db\\Dbflange.db";
            SQLiteConnection conn = new SQLiteConnection(url);
            try
            {

                conn.Open();
                return conn;
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
                return conn;
            }

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
            SQLiteDataReader reader = null;
            try
            {
                using var cmd = connectionSLite().CreateCommand();
                cmd.CommandText = "select * from norma where nome=@nome";
                cmd.Parameters.AddWithValue("@nome", parameter);
                reader = cmd.ExecuteReader();

                return reader;
            }
            catch (Exception ex)
            {
                MessageBox.Show("Ocorreu um erro: " + ex.Message);
                return reader;
            }

        }


        public static SQLiteDataReader GetDatas(String parameter)
        {
            using (var cmd = connectionSLite().CreateCommand())
            {
                cmd.CommandText = "SELECT diametro_furacao,diametro_furo FROM dimensoes WHERE DN=@dn";
                cmd.Parameters.AddWithValue("@dn", parameter);
                SQLiteDataReader reader = cmd.ExecuteReader();
                return reader;
            }




        }

        public static List<string> readerDN(string nome, string classe_pressao)
        {
            SQLiteDataReader reader = null;
            List<string> data = new List<string>();
            using (var cmd = connectionSLite().CreateCommand())
            {
                cmd.CommandText = "SELECT id FROM NORMA WHERE NOME=@nome and CLASSE_PRESSAO=@classe_pressao";
                cmd.Parameters.AddWithValue("@nome", nome);
                cmd.Parameters.AddWithValue("@classe_pressao", classe_pressao);
                reader = cmd.ExecuteReader();

            }
            if (reader.Read())
            {
                SQLiteDataReader readerTickness = null;
                Connection id = new Connection();
                id.Id = reader.GetInt64(0);
                reader.Close();
                using (var cmd = connectionSLite().CreateCommand())
                {
                    cmd.CommandText = "SELECT DN FROM DIMENSOES WHERE ID_NORMA=@id";
                    cmd.Parameters.AddWithValue("@id", id.Id);
                    readerTickness = cmd.ExecuteReader();
                    while (readerTickness.Read())
                    {
                        data.Add(readerTickness.GetInt64(0).ToString());

                    }
                }
            }
            return data;
        }
    }
}
