using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using NUnit.Framework;

namespace Caelum.Leilao.Tests
{
    [TestFixture]
    public class FiltroDeLancesTest
    {
        [Test]
        public void DeveSelecionarLancesEntre1000E3000()
        {
            Usuario joao = new Usuario("Joao");

            FiltroDeLances filtro = new FiltroDeLances();
            IList<Lance> resultado = filtro.Filtra(new List<Lance>() {
            new Lance(joao,2000),
            new Lance(joao,1000),
            new Lance(joao,3000),
            new Lance(joao, 800)});

            Assert.AreEqual(1, resultado.Count);
            Assert.AreEqual(2000, resultado[0].Valor, 0.00001);
        }

        [Test]
        public void DeveSelecionarLancesEntre500E700()
        {
            Usuario joao = new Usuario("Joao");

            FiltroDeLances filtro = new FiltroDeLances();
            IList<Lance> resultado = filtro.Filtra(new List<Lance>() {
            new Lance(joao,600),
            new Lance(joao,500),
            new Lance(joao,700),
            new Lance(joao, 800)});

            Assert.AreEqual(1, resultado.Count);
            Assert.AreEqual(600, resultado[0].Valor, 0.00001);
        }

        [Test]
        public void DeveSelecionarLancesMaior5000()
        {
            Usuario joao = new Usuario("Joao");

            FiltroDeLances filtro = new FiltroDeLances();
            IList<Lance> resultado = filtro.Filtra(new List<Lance>() {
            new Lance(joao,900),
            new Lance(joao,5500),
            new Lance(joao,7000),
            new Lance(joao, 800)});

            Assert.AreEqual(2, resultado.Count);
            Assert.AreEqual(5500, resultado[0].Valor, 0.00001);
            Assert.AreEqual(7000, resultado[1].Valor, 0.00001);
        }

        [Test]
        public void NaoDeveSelecionarLances()
        {
            Usuario joao = new Usuario("Joao");

            FiltroDeLances filtro = new FiltroDeLances();
            IList<Lance> resultado = filtro.Filtra(new List<Lance>() {
            new Lance(joao,800),
            new Lance(joao,900),
            new Lance(joao,4000),
            new Lance(joao, 4800)});

            Assert.AreEqual(0, resultado.Count);
        }

        [Test]
        public void DeveSelecionarUmLanceDeCadaTipo()
        {
            Usuario joao = new Usuario("Joao");

            FiltroDeLances filtro = new FiltroDeLances();
            IList<Lance> resultado = filtro.Filtra(new List<Lance>() {
            new Lance(joao,800),
            new Lance(joao,600),
            new Lance(joao,2000),
            new Lance(joao, 6800)});

            Assert.AreEqual(3, resultado.Count);
            Assert.AreEqual(600, resultado[0].Valor, 0.00001);
            Assert.AreEqual(2000, resultado[1].Valor, 0.00001);
            Assert.AreEqual(6800, resultado[2].Valor, 0.00001);
        }


    }
}
