using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using NUnit.Framework;
using Caelum.Leilao;

namespace Caelum.Leilao.Tests
{
    [TestFixture]
    class AvaliadorTest
    {
        private Avaliador leiloeiro;
        private Usuario joao;
        private Usuario jose;
        private Usuario maria;

        [SetUp]
        public void CriaAvaliador()
        {
            this.leiloeiro = new Avaliador();
            this.joao = new Usuario("João");
            this.jose = new Usuario("José");
            this.maria = new Usuario("Maria");
            Console.WriteLine("inicializando teste!");
        }

        [Test]
        public void DeveEntenderLancesEmOrdemCrescente()
        {
            // cenario: 3 lances em ordem crescente
            Leilao leilao = new CriadorDeLeilao().Para("Playstation 3 Novo")
                .Lance(maria, 250.0)
                .Lance(joao, 300.0)
                .Lance(jose, 400.0)
                .Constroi();

            // executando a acao
            leiloeiro.Avalia(leilao);

            // comparando a saida com o esperado
            double maiorEsperado = 400;
            double menorEsperado = 250;

            Assert.AreEqual(maiorEsperado, leiloeiro.MaiorLance, 0.0001);
            Assert.AreEqual(menorEsperado, leiloeiro.MenorLance, 0.0001);
        }

        [Test]
        public void DeveDevolverMediaDosLances()
        {

            Leilao leilao = new CriadorDeLeilao().Para("Playstation 3 Novo")
                .Lance(maria, 250.0)
                .Lance(joao, 300.0)
                .Lance(jose, 400.0)
                .Constroi();

            // executando a acao
            leiloeiro.Avalia(leilao);

            // comparando a saida com o esperado
            double mediaEsperado = 316.666667;

            Assert.AreEqual(mediaEsperado, leiloeiro.ValorMedioLance(leilao), 0.0001);
            Assert.AreEqual(mediaEsperado, leiloeiro.Media, 0.0001);

        }

        [Test]
        public void DeveEncontrarOsTresMaioresLances()
        {
            Leilao leilao = new CriadorDeLeilao().Para("Playstation 3 Novo")
                .Lance(joao, 100.0)
                .Lance(maria, 200.0)
                .Lance(joao, 300.0)
                .Lance(maria, 400.0)
                .Constroi();

            leiloeiro.Avalia(leilao);

            IList<Lance> maiores = leiloeiro.TresMaiores;

            Assert.AreEqual(3, maiores.Count);
            Assert.AreEqual(400, maiores[0].Valor, 0.00001);
            Assert.AreEqual(300, maiores[1].Valor, 0.00001);
            Assert.AreEqual(200, maiores[2].Valor, 0.00001);
        }

        [Test]
        public void LeilaoComApenas1Lance()
        {
            Leilao leilao = new CriadorDeLeilao().Para("Playstation 3 Novo")
                .Lance(joao, 100.0)
                .Constroi();

            leiloeiro.Avalia(leilao);

            IList<Lance> maiores = leiloeiro.TresMaiores;

            Assert.AreEqual(1, maiores.Count);
            Assert.AreEqual(100, maiores[0].Valor, 0.00001);

            Assert.AreEqual(100, leiloeiro.Media, 0.00001);
            Assert.AreEqual(100, leiloeiro.MaiorLance, 0.00001);
            Assert.AreEqual(100, leiloeiro.MenorLance, 0.00001);
        }

        [Test]
        public void LancesForaDeOrdem()
        {
            Leilao leilao = new CriadorDeLeilao().Para("Playstation 3 Novo")
                .Lance(joao, 200.0)
                .Lance(maria, 450.0)
                .Lance(jose, 120.0)
                .Lance(maria, 700.0)
                .Lance(joao, 630.0)
                .Lance(jose, 230.0)
                .Constroi();

            leiloeiro.Avalia(leilao);

            Assert.AreEqual(700, leiloeiro.MaiorLance, 0.00001);
            Assert.AreEqual(120, leiloeiro.MenorLance, 0.00001);
        }

        [Test]
        public void LancesEmOrdemDecrescente()
        {
            Usuario major = new Usuario("Major");
            Leilao leilao = new CriadorDeLeilao().Para("Playstation 3 Novo")
                .Lance(joao, 400.0)
                .Lance(maria, 300.0)
                .Lance(jose, 200.0)
                .Lance(major, 100.0)
                .Constroi();

            leiloeiro.Avalia(leilao);

            Assert.AreEqual(400, leiloeiro.MaiorLance, 0.00001);
            Assert.AreEqual(100, leiloeiro.MenorLance, 0.00001);
        }

        [Test]
        public void Teste5LancesEObtem3Maiores()
        {
            Usuario major = new Usuario("Major");
            Leilao leilao = new CriadorDeLeilao().Para("Playstation 3 Novo")
                .Lance(joao, 400.0)
                .Lance(maria, 300.0)
                .Lance(jose, 200.0)
                .Lance(major, 100.0)
                .Lance(jose, 500.0)
                .Constroi();

            leiloeiro.Avalia(leilao);

            IList<Lance> maiores = leiloeiro.TresMaiores;

            Assert.AreEqual(3, maiores.Count);
            Assert.AreEqual(500, maiores[0].Valor, 0.00001);
            Assert.AreEqual(400, maiores[1].Valor, 0.00001);
            Assert.AreEqual(300, maiores[2].Valor, 0.00001);
        }

        [Test]
        public void Teste2LancesEObtem3Maiores()
        {
            Leilao leilao = new CriadorDeLeilao().Para("Playstation 3 Novo")
                .Lance(joao, 400.0)
                .Lance(maria, 300.0)
                .Constroi();
            
            leiloeiro.Avalia(leilao);

            IList<Lance> maiores = leiloeiro.TresMaiores;

            Assert.AreEqual(2, maiores.Count);
            Assert.AreEqual(400, maiores[0].Valor, 0.00001);
            Assert.AreEqual(300, maiores[1].Valor, 0.00001);
            //Assert.AreEqual(0, maiores[2].Valor, 0.00001);
        }

        [Test, ExpectedException(typeof(Exception))]
        public void Teste0LancesEObtem3Maiores()
        {
            Leilao leilao = new CriadorDeLeilao().Para("Playstation 3 Novo")
                .Constroi();

            leiloeiro.Avalia(leilao);

            IList<Lance> maiores = leiloeiro.TresMaiores;

            Assert.AreEqual(0, maiores.Count);
        }

        [TearDown]
        public void Finaliza()
        {
            Console.WriteLine("fim");
        }

        [TestFixtureSetUp]
        public void TestandoBeforeClass()
        {
            Console.WriteLine("test fixture setup");
        }

        [TestFixtureTearDown]
        public void TestandoAfterClass()
        {
            Console.WriteLine("test fixture tear down");
        }
    }
}
