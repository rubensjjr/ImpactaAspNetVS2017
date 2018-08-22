using Oficina.Dominio;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace Oficina.WebPages
{
    public class motocicleta: Veiculo
    {
        public EstiloMotocicleta Estilo { get; set; }

        public override List<string> Validar()
        {
            throw new NotImplementedException();
        }
    }
}