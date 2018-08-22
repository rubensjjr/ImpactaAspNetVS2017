using Microsoft.VisualStudio.TestTools.UnitTesting;
using Oficina.Dominio;
using Oficina.Repositorios.SistemaArquivos;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Oficina.Repositorios.SistemaArquivos.Tests
{
    [TestClass()]
    public class VeiculoRepositorioTests
    {
        [TestMethod()]
        public void inserirTest()
        {
            var veiculo = new VeiculoPasseio();

            veiculo.Ano = 2014;
            veiculo.Cambio = Cambio.Manual;
            veiculo.Combustivel = Combustivel.Flex;
            veiculo.Cor = new CorRepositorio().Selecionar(2);
            veiculo.Modelo = new ModeloRepositorio().Selecionar(3);
            veiculo.Observacao = "Observação";
            veiculo.Placa = "ABC1234";
            veiculo.TipoCarroceria = TipoCarroceria.Hatch;


            new VeiculoRepositorio().inserir(veiculo);
        }
    }
}