using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using System.Collections.Generic;
using System.Linq;

namespace AspNetVS2017.Capitulo01.VetoresColecoes.Testes
{
    [TestClass]
    public class ColecoesTeste
    {
        [TestMethod]
        public void ListTeste()
        {
            var inteiros = new List <int>();

            inteiros.Add(2);
            inteiros.Add(0);
            inteiros.Add(4);
            inteiros.Add(8);

            // inteiros[10] = 51;

            var maisInteiros = new List<int> {2,1,0,20 };

            inteiros.AddRange(maisInteiros); // ganha o conteudo da outra lista

            inteiros.Insert(0, 21);// primeiro parametro onde, segundo o valor

            inteiros.Remove(5);// Linq

            inteiros.RemoveAt(0);

            inteiros.Sort();

            var primeiro = inteiros.First(); //inteiros[0];
            var ultimo = inteiros.Last();//[inteiros.Count - 1];

            foreach (var inteiro in inteiros)
            {
                Console.WriteLine($"{inteiros.IndexOf(inteiro)}:{inteiro}");
            }
        }

        [TestMethod]
        public void DictionaryTeste()
        {
             var feriados = new Dictionary<DateTime,string>();

            feriados.Add(new DateTime(2018,12,25), "natal");
            feriados.Add(new DateTime(2019,1,1), "Ano novo");
            feriados.Add(new DateTime(2019,1,25), "Aniversario de São Paulo");


            var natal = feriados [Convert.ToDateTime("25/12/2018")];

            foreach (var feriado in feriados)
            {
               // Console.WriteLine($"{feriado.Key.ToShortDateString()}:{feriado.Value}");

                Console.WriteLine($"{feriado.Key.ToString("dd/MM/yyyy")}:{feriado.Value}"); // chega no mesmo resultado acima.

            }
            Console.WriteLine(feriados.ContainsKey(Convert.ToDateTime("25/12/2018")));

            Console.WriteLine(feriados.ContainsValue("Ano novo"));

        }
    }
}
