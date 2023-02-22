using MySql.Data.MySqlClient;
using App_Teste.Connection;
using System.Data;

namespace App_Teste
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void StandardOne_SelectedIndexChanged(object sender, EventArgs e)
        {
            comboBox1.Enabled = true;
            textBox2.Enabled = true;
            comboBox3.Enabled = true;
            comboBox3.Items.Clear();
            var read = Connection.Connection.reader((string)StandardOne.SelectedItem);

            while (read.Read())
            {
                string[] collection = {
                    read.GetString(2)

                };
                comboBox3.Items.Add(collection[0]);
            }

        }
        private void StandardTwo_SelectedIndexChanged(object sender, EventArgs e)
        {
            textBox3.Enabled = true;
            textBox4.Enabled = true;
            comboBox4.Enabled = true;
            comboBox4.Items.Clear();
            var read = Connection.Connection.reader((string)StandardTwo.SelectedItem);
            while (read.Read())
            {
                string[] collection =
                {
                    read.GetString(2)
                };
                comboBox4.Items.Add(collection[0]);
            }
        }

        private void comboBox3_SelectedIndexChanged(object sender, EventArgs e)
        {
            var read = Connection.Connection.reader((string)comboBox3.SelectedItem);
            while (read.Read())
            {
                string[] collection =
                {
                    read.GetString(2)
                };
                comboBox4.Items.Add(collection[0]);
            }
        }

    }


    }
