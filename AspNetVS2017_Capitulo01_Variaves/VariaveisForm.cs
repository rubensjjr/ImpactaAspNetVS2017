using System;
using System.Windows.Forms;

namespace AspNetVS2017_Capitulo01_Variaves
{
    public partial class VariaveisForm : Form
    {
        // abaixo os campos (fields) da classe

        private int x = 32;
        private int w = 45;
        private int y = 16;
        private int z = 32;

        public VariaveisForm()
        {
            InitializeComponent();
        }

        private void aritmeticasToolStripMenuItem_Click(object sender, EventArgs e)
        {
            int a = 2;
            int b = 6;
            int c = 10;
            int d = 13;

            resultadoListBox.Items.Add("a = " + a);
            resultadoListBox.Items.Add("b = " + b);
            resultadoListBox.Items.Add("c = " + c);
            resultadoListBox.Items.Add("d = " + d);
            resultadoListBox.Items.Add("======================");
            resultadoListBox.Items.Add("c * d  = " + (c * d));
            resultadoListBox.Items.Add("c / d  = " + (c / d));
            resultadoListBox.Items.Add("d % a  = " + (d % a));




            //int e = 12;
            /*long quantidadeHabitantes = 7000000000;
            string nome = "Rubens";
            var valor = 19.57m;
            var aprovado = true;
            var @class = "noturno";
            var nascimento = new DateTime(1970,12,25);
            var agora = DateTime.Now;*/


            //if (aprovado)
            // {

            //  }
        }

        private void reduzidasToolStripMenuItem_Click(object sender, EventArgs e)
        {
            var x = 5;
            //x = x - 3;
            x -= 3;

            resultadoListBox.Items.Add("valor de x = " + x);
            resultadoListBox.Items.Add("x -= 3 =" + (x -= 3));

        }

        private void incrementaisDecrementaisToolStripMenuItem_Click(object sender, EventArgs e)
        {
            int a;

            a = 5;
            resultadoListBox.Items.Add("Exemplo de Pré-Incremental");
            resultadoListBox.Items.Add("a= " + a);
            resultadoListBox.Items.Add("2+ ++a = " + (2 + ++a));
            resultadoListBox.Items.Add("a = " + a);

            resultadoListBox.Items.Add(new string('-', 50));

            a = 5;
            resultadoListBox.Items.Add("Exemplo de Pós-Incremental");
            resultadoListBox.Items.Add("a= " + a);
            resultadoListBox.Items.Add("2+ a++ = " + (2 + a++));
            resultadoListBox.Items.Add("a = " + a);

            resultadoListBox.Items.Add(new string('-', 50));

        }

        private void booleanasToolStripMenuItem_Click(object sender, EventArgs e)
        {


            resultadoListBox.Items.Add("Exemplo de Booleanas");
            resultadoListBox.Items.Add(new string('-', 50));

            ExibirValoresVariaveis();

            resultadoListBox.Items.Add("w <= x =" + (w <= x));
            resultadoListBox.Items.Add("x == z " + (x == z));
            resultadoListBox.Items.Add("x != z " + (x != z)); // diferente

            resultadoListBox.Items.Add(new string('-', 50));

        }

        private void ExibirValoresVariaveis() //ctrl + r + m > cria o metodo
        {
            resultadoListBox.Items.Add("x =" + x);
            resultadoListBox.Items.Add("w =" + w);
            resultadoListBox.Items.Add("y =" + y);
            resultadoListBox.Items.Add("z =" + z);
        }

        private void logicasToolStripMenuItem_Click(object sender, EventArgs e)
        {


            resultadoListBox.Items.Add("Exemplo de Lógicas");
            resultadoListBox.Items.Add(new string('-', 50));

            ExibirValoresVariaveis(); // chama o metodo

            resultadoListBox.Items.Add(new string('-', 50));

            resultadoListBox.Items.Add("w <= x || y == 16 = " + (w <= x || y == 16));  // || significa ou 
            resultadoListBox.Items.Add("x == z && z != x = " + (x == z && z != x));   // &&  ''       E
            resultadoListBox.Items.Add("( y > w) = " + (!(y > w)));
                    

        }

        private void ternariasToolStripMenuItem_Click(object sender, EventArgs e)
        {
            int ano;

            ano = 2018;

            resultadoListBox.Items.Add(string.Format("O ano {0} é bissexto? {1}",ano, ano % 4 ==0 ?"Sim" : "Não")); // ? operador ternario, fazendo uma pergunta 


            ano = 2020;

            resultadoListBox.Items.Add($"O ano {ano} é bissexto? {(DateTime.IsLeapYear(ano) ? "Sim" : "Não")}");

            // exemplo usando if e else
            //var resposta = "";
            //if (ano % 4 ==0) // dividido por 4 e restar 0  
            //{
            //    resposta = "Sim";            para comentar o codigo selecionar ctrl + k + c
            //}
            //else
            //{
            //    resposta = "Não";
            //}


        }
    }
}