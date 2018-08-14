using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace AspNetVS2017.Capitulo01.VetoresColecoes.Testes
{
    [TestClass]
    public class VetoresTeste
    {
        [TestMethod]
        public void InicializacaoTeste()
        {
            var strings = new string[10];

            var inteiros = new int[5];
            inteiros[0] = 9;
            inteiros[5] = 2;

            var decimais = new decimal[3]
            {0.3m,0.2m,7 };

            decimal[] outroVetor = { 0.5m, 8.6m, 12 };

            foreach (var @decimal in decimais)
            {
                Console.WriteLine(@decimal);
            }

            Console.WriteLine("Tamanho do Vetor" + decimais.Length);
        }
    }
}
