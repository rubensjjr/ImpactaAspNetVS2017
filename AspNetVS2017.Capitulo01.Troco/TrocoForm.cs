using System;
using System.Windows.Forms;

namespace AspNetVS2017.Capitulo01.Troco
{
    public partial class TrocoForm : Form
    {
        public TrocoForm()
        {
            InitializeComponent();
        }

        
        private void calcularButton_Click(object sender, EventArgs e)
        {

            var valorCompra= Convert.ToDecimal(valorCompratextBox.Text);
            var valorPago = Convert.ToDecimal(valorPagotextBox.Text);
            var Troco = valorPago - valorCompra;

            //          valorTrocotextBox.Text = Convert.ToString(Troco);
            valorTrocotextBox.Text = Troco.ToString("C"); // C = Currency - para trocar a moeda usar ("C", new CultureInfo("en-US"));
                                                          // Ctrl + .  / adiciona dll na nameSpace               
            
            //ToDo: Refatorar para usar vetor e FOR.

            //var moedas1 = Convert.ToInt32 (Troco /1); 

            var moedas1 =(int)Troco;
            //Troco = Troco - moedas1;  primeiro modo de fazer
            Troco = Troco % 1;

            var moedas050 = (int)(Troco / 0.5M);

            Troco = Troco % 0.5m;

            var moedas025 = (int)(Troco / 0.25M);

            Troco = Troco % 0.25m;

            var moedas010 = (int)(Troco / 0.1M);

            Troco = Troco % 0.1m;

            var moedas005 = (int)(Troco / 0.05M);

            Troco = Troco % 0.05m;

            var moedas001 = (int)(Troco / 0.01M);

            Troco = Troco % 0.01m;

            moedasListView.Items[0]. Text = moedas1.ToString();
            moedasListView.Items[1].Text = moedas050.ToString();
            moedasListView.Items[2].Text = moedas025.ToString();
            moedasListView.Items[3].Text = moedas010.ToString();
            moedasListView.Items[4].Text = moedas005.ToString();
            moedasListView.Items[5].Text = moedas001.ToString();







        }
    }
}
