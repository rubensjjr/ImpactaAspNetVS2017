using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Oficina.Dominio
{
    //todo: OO- Herança.
    public class VeiculoPasseio: Veiculo
    {
        public TipoCarroceria TipoCarroceria { get; set; }

        //todo: OO - polimorfismo por substituição (override).

        public override List<string> Validar()
        {
            var erros = base.ValidarBase();

            //Trace.WriteLine(erros);

            if (!Enum.IsDefined(typeof(TipoCarroceria), TipoCarroceria))
            {
                erros.Add($"A Carroceria Informada ({TipoCarroceria})não é Valida");
            }
            return erros;
        }
    }
}
