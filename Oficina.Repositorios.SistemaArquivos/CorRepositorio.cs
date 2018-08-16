using Oficina.Dominio;
using System;
using System.Collections.Generic;
using System.Configuration;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Oficina.Repositorios.SistemaArquivos
{
    public class CorRepositorio
    {
        private string _CaminhoArquivo = ConfigurationManager.AppSettings["CaminhoArquivoCor"];

        public List<Cor> Selecionar()
        {
            var cores = new List<Cor>();


            foreach (var linha in File.ReadAllLines(_CaminhoArquivo))
            {
                var cor  = new Cor();
                cor.ID = Convert.ToInt32(linha.Substring(0,5)); 
                cor.Nome = linha.Substring(5);

                cores.Add(cor);
                
            }

            return cores;  
        }

    }

}
