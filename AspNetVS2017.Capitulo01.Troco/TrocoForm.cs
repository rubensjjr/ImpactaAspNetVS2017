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




        }
    }
}
