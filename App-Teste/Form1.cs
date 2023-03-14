using App_Teste.Connection;
using System.Data;

using System.Text.Json.Nodes;
using Google.Protobuf;
using System.Windows.Forms;

namespace App_Teste
{
    public partial class Flanges : Form
    {
        List<string> norma = new List<string>();
        List<double> Dfuracao = new List<double>();
        List<double> Dfuro = new List<double>();
        public string user { get; set; }
        public Flanges()
        {

            InitializeComponent();
        }

        private void StandardOne_SelectedIndexChanged(object sender, EventArgs e)
        {

            classe_pressao1.Enabled = true;
            classe_pressao1.Items.Clear();

            var read = Connection.Connection.reader((string)Norma1.SelectedItem, user);

            while (read.Read())
            {
                string[] collection = {
                    read.GetString(2)

                };
                classe_pressao1.Items.Add(collection[0]);

            }

        }
        private void StandardTwo_SelectedIndexChanged(object sender, EventArgs e)
        {
            classe_pressao2.Enabled = true;

            classe_pressao2.Items.Clear();
            var read = Connection.Connection.reader((string)Norma2.SelectedItem, user);
            while (read.Read())
            {
                string[] collection =
                {
                    read.GetString(2)
                };
                classe_pressao2.Items.Add(collection[0]);
            }
        }

        private void comboBox3_SelectedIndexChanged(object sender, EventArgs e)
        {
            var read = Connection.Connection.reader((string)classe_pressao1.SelectedItem, user);
            while (read.Read())
            {
                string[] collection =
                {
                    read.GetString(1)
                };
                classe_pressao2.Items.Add(collection[0]);
            }
        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            Dfuracao1.Enabled = true;
            var reader = Connection.Connection.readerDN((string)Norma1.SelectedItem, (string)classe_pressao1.SelectedItem, user);
            Dfuracao1.Items.Clear();
            for (int i = 0; i < reader.Count; i++)
            {
                Dfuracao1.Items.Add(reader[i]);
            }
        }

        private void comboBox4_SelectedIndexChanged(object sender, EventArgs e)
        {
            Dfuracao2.Enabled = true;
            var reader = Connection.Connection.readerDN((string)Norma2.SelectedItem, (string)classe_pressao2.SelectedItem, user);
            Dfuracao2.Items.Clear();
            for (int i = 0; i < reader.Count; i++)
            {
                Dfuracao2.Items.Add(reader[i]);
            }
        }

        private void Dfuracao2_SelectedIndexChanged(object sender, EventArgs e)
        {
            var reader = Connection.Connection.GetDatas((string)Dfuracao2.SelectedItem, user);
            if (reader.Read())
            {
                Dfuracao.Add(reader.GetDouble(0));
                Dfuro.Add(reader.GetDouble(1));
            }

        }
        private void Dfuracao1_SelectedIndexChanged(object sender, EventArgs e)
        {
            var reader = Connection.Connection.GetDatas((string)Dfuracao1.SelectedItem, user);
            Dfuracao.Clear();
            if (reader.Read())
            {
                Dfuracao.Add(reader.GetDouble(0));
                Dfuro.Add(reader.GetDouble(1));

            }
        }

        private void Button1_Click(object sender, EventArgs e)
        {
            double DmaiorFuracao;
            double DmenorFuracao;
            double DmaiorFuro;
            double DmenorFuro;
            double resultado;

            DmaiorFuracao = Dfuracao.Max();
            DmenorFuracao = Dfuracao.Min();
            DmaiorFuro = Dfuro.Max();
            DmenorFuro = Dfuro.Min();


            resultado = (DmenorFuracao + DmenorFuro - (DmaiorFuracao - DmaiorFuro)) / 2;
            if (resultado >= 6)
            {
                pictureBox1.Visible = true;
                Result.Text = "Flange com Folga de: " + resultado + "MM";
            }
            else if (resultado < 6.5)
            {
                Result.Text = "Flange com folga incompativel";
                pictureBox1.Visible = false;

            }
        }
    }

}


