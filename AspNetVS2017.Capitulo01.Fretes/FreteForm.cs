using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace AspNetVS2017.Capitulo01.Fretes
{
    public partial class FreteForm : Form
    {
        public FreteForm()
        {
            InitializeComponent();
        }

        
        private void calcularButton_Click(object sender, EventArgs e)
        {

            var erros = ValidarFormulario();

            if (erros.Count == 0)
            {
                Calcular();
            }
            else
            {
                MessageBox.Show(string.Join(Environment.NewLine, erros), 
                    "Validação",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Error); // faz a validção dos campos
            }
        }

        private void Calcular()
        {
            var frete = 0m;
            var valor = Convert.ToDecimal(valorTextBox.Text); // convert variavel string em decimal
            var nordeste = new List<string> {"BA","PE","AL","RN","CE"};

            switch (ufComboBox.Text)
            {
                case "SP": frete = 0.2m;
                    break;
                case "RJ": frete = 0.3m;
                    break;
                case "MG": frete = 0.35m;
                    break;
                case "AM": frete = 0.6m;
                    break;
                case var uf when nordeste.Contains(uf): frete = 0.5m;
                    break;


                default  : frete = 0.75m;
                    break;
                case null: throw new NullReferenceException("Combo UF não pode ser null"); // o app para o processamento  e e fecha o app
                   
            }
            //if (ufComboBox.Text == "SP")
           // {
                //frete = 0.2m
            //}

            freteTextBox.Text = frete.ToString("P2"); 
            totalTextBox.Text = ((1 + frete) * valor).ToString("c");

        }

        private List<string> ValidarFormulario()
        {
           var erros = new List <string>();

            if (nameTextBox.Text == string.Empty)
            {
                erros.Add("O Campo Nome é Obrigatório");
            }
            if (string.IsNullOrEmpty(valorTextBox.Text))
            {
                erros.Add("O Campo Valor é Obrigatório");
            }
            else
            {
                if (!decimal.TryParse(valorTextBox.Text, out decimal valor))
                {
                    erros.Add("O Campo Valor está com formato invalido.");

                }
                else
                {
                    if (valor < 100)
                    {
                        erros.Add("O Valor informado abaixo do mínimo (100)");
                    }
                }
            }
            if (ufComboBox.SelectedIndex == -1)
            {
                erros.Add("Slecione a UF ");
            }
            return erros;
        }

        private void limparButton_Click(object sender, EventArgs e)
        {
            nameTextBox.Text = "";
            nameTextBox.Text = string.Empty;

            ufComboBox.SelectedIndex = -1;

            freteTextBox.Clear();
            valorTextBox.Clear();
            totalTextBox.Text = null;

        }
    }
}
