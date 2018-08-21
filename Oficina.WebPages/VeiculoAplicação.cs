using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using Oficina.Dominio;
using Oficina.Repositorios.SistemaArquivos;

namespace Oficina.WebPages
{
    public class VeiculoAplicacao
    {
        private MarcaRepositorio _MarcaRepositorio = new MarcaRepositorio();
        private ModeloRepositorio _modeloRepositorio = new ModeloRepositorio();
        private CorRepositorio corRepositorio = new CorRepositorio();
        private VeiculoRepositorio veiculoRepositorio = new VeiculoRepositorio();

        public VeiculoAplicacao()
        {
            PopularControles();
        }

          


        public List<Marca> Marcas { get; set; }
        public string MarcaSelecionada { get; set; }
        public List<Modelo> Modelos { get; set; } = new List<Modelo>();
        public List <Cor> Cores { get; set; }
        public List <Combustivel> Combustiveis { get; set; }
        public List<Cambio> Cambios { get; set; }



        private void PopularControles()
        {
            Marcas = _MarcaRepositorio.Selecionar();
            MarcaSelecionada = HttpContext.Current.Request.QueryString["MarcaId"];

            if (MarcaSelecionada != string.Empty)
            {
                Modelos = _modeloRepositorio.SelecionarPorMarca(Convert.ToInt32(MarcaSelecionada));
            }

            Cores = corRepositorio.Selecionar();
            Combustiveis = Enum.GetValues(typeof(Combustivel)).Cast<Combustivel>().ToList();
            Cambios = Enum.GetValues(typeof(Cambio)).Cast<Cambio>().ToList();

        }

        public void Inserir()
        {
            var veiculo = new Veiculo();
            var formulario = HttpContext.Current.Request.Form;


            veiculo.Ano = Convert.ToInt32(formulario["Ano"]);
            veiculo.Cambio = (Cambio)Convert.ToInt32(formulario["Cambio"]);
            veiculo.Combustivel = (Combustivel)Convert.ToInt32(formulario["Combustivel"]);
            veiculo.Cor = corRepositorio.Selecionar(Convert.ToInt32(formulario["Cor"]));
            veiculo.Modelo = _modeloRepositorio.Selecionar(Convert.ToInt32(formulario["Modelo"]));
            veiculo.Placa = formulario["Placa"];

            veiculoRepositorio.inserir(veiculo);

        }


    }
}