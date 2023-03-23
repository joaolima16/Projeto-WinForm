using App_Teste.Connection;
using System.Data;

using System.Text.Json.Nodes;
using Google.Protobuf;
using System.Windows.Forms;
using Org.BouncyCastle.Crypto.Engines;

namespace App_Teste
{
    public partial class Flanges : Form
    {
        List<string> norma = new List<string>();
        List<double> DfuracaoN1 = new List<double>();
        List<double> DfuroN1 = new List<double>();
        List<double> DfuracaoN2 = new List<double>();
        List<double> DfuroN2 = new List<double>();
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
            var reader = Connection.Connection.readerDN((string)Norma1.SelectedItem, (string)classe_pressao1.SelectedItem);
            Dfuracao1.Items.Clear();
            for (int i = 0; i < reader.Count; i++)
            {
                Dfuracao1.Items.Add(reader[i]);
            }
        }

        private void comboBox4_SelectedIndexChanged(object sender, EventArgs e)
        {
            Dfuracao2.Enabled = true;
            var reader = Connection.Connection.readerDN((string)Norma2.SelectedItem, (string)classe_pressao2.SelectedItem);
            
            Dfuracao2.Items.Clear();
            for (int i = 0; i < reader.Count; i++)
            {
                Dfuracao2.Items.Add(reader[i]);
            }
        }

        private void Dfuracao2_SelectedIndexChanged(object sender, EventArgs e)
        {
            DfuracaoN2.Clear();
            DfuroN2.Clear();
            var reader = Connection.Connection.GetDatas((string)Dfuracao2.SelectedItem, (string)Norma2.SelectedItem, (string)classe_pressao2.SelectedItem);
            if (reader.Read())
            {
                DfuracaoN2.Add(reader.GetDouble(0));
                DfuroN2.Add(reader.GetDouble(1));
            }

        }
        private void Dfuracao1_SelectedIndexChanged(object sender, EventArgs e)
        {
            DfuracaoN1.Clear();
            DfuroN1.Clear();
            var reader = Connection.Connection.GetDatas((string)Dfuracao1.SelectedItem, (string)Norma1.SelectedItem, (string)classe_pressao1.SelectedItem);
            if (reader.Read())
            {
                DfuracaoN1.Add(reader.GetDouble(0));
                DfuroN1.Add(reader.GetDouble(1));

            }
        }
        private void ClearAll()
        {
            classe_pressao1.Items.Clear();
            classe_pressao2.Items.Clear();
            classe_pressao2.Text = "";
            classe_pressao1.Text = "";
            Dfuracao1.Items.Clear();
            Dfuracao2.Items.Clear();
            Dfuracao1.Text = "";
            Dfuracao2.Text = "";
            Dfuracao1.Enabled = false;
            Dfuracao2.Enabled = false;
            classe_pressao1.Enabled = false;
            classe_pressao2.Enabled  = false;
            DfuracaoN1.Clear();
            DfuroN1.Clear();
            DfuracaoN2.Clear();
            DfuroN2.Clear();

        }
        private void Button1_Click(object sender, EventArgs e)
        {
            double DmaiorFuracao;
            double DmenorFuracao;
            double DmaiorFuro;
            double DmenorFuro;
            double resultado;

            DmaiorFuracao = DfuracaoN1.Max() > DfuracaoN2.Max() ? DfuracaoN1.Max() : DfuracaoN2.Max();
            DmenorFuracao = DfuracaoN1.Min() < DfuracaoN2.Min() ? DfuracaoN1.Min() : DfuracaoN2.Min();
            DmaiorFuro = DfuroN1.Max() > DfuroN2.Max() ? DfuroN1.Max() : DfuroN2.Max();
            DmenorFuro = DfuroN1.Min() < DfuroN2.Min() ? DfuroN1.Min() : DfuroN2.Min();

            resultado = (DmenorFuracao + DmenorFuro - (DmaiorFuracao - DmaiorFuro)) / 2;
    
            if (resultado >= 6)
            {
                pictureBox1.Visible = true;
                Result.Text = "Flange com Folga de: " + resultado.ToString("N2") + "MM";
            }
            else if (resultado < 6.5)
            {
                Result.Text = "Flange com folga incompativel";
                pictureBox1.Visible = false;

            }
            ClearAll();

        }
    }

}


