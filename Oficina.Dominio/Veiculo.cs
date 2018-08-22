using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Oficina.Dominio
{
    //ToDo: OO - classe ou abstração
    //abstract - não pode ser instanciada.
    public abstract class Veiculo
    {
        public Guid Id { get; set; } = Guid.NewGuid();
    //toDo: OO = encapsulamento
        private string _Placa;
        public string Placa
        {
            get { return _Placa.ToUpper().Replace("-", string.Empty); ; }
            set { _Placa = value.ToUpper().Replace("-", string.Empty); ; }
        }
        //public string Placa
        //{
        //    get
        //    {

        //        return Placa.ToUpper().Replace("-", string.Empty);
        //    }
        //    set
        //    {

        //    }
        //}


        public Modelo Modelo { get; set; }
        public int Ano { get; set; }
        public Cor Cor { get; set; }
        public Combustivel Combustivel { get; set; }
        public Cambio Cambio { get; set; }
        public String Observacao { get; set; }

        public abstract List<string> Validar();

        protected List<string> ValidarBase() // ´protected so é usado com herança
        {
            var erros = new List<string>();
            if (Ano <= 1960 || Ano - DateTime.Now.Year > 1)
            {
                erros.Add($"O ano Informado({Ano}) não é Valido");
            }
            return erros;
        }
    }
}
