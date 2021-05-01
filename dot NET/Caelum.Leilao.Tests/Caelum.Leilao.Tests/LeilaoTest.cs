using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using NUnit.Framework;

namespace Caelum.Leilao.Tests
{
    [TestFixture]
    public class LeilaoTest
    {
        private Usuario stevejobs;
        private Usuario billgates;
        private Usuario steveWoz;

        [SetUp]
        public void CriaAvaliador()
        {
            this.stevejobs = new Usuario("Steve Jobs");
            this.billgates = new Usuario("Bill Gates");
            this.steveWoz = new Usuario("Steve Wozniak");
        }

        [Test]
        public void DeveReceberUmLance()
        {
            Leilao leilao = new Leilao("Macbook Pro 15");
            Assert.AreEqual(0, leilao.Lances.Count);

            leilao.Propoe(new Lance(stevejobs, 2000));

            Assert.AreEqual(1, leilao.Lances.Count);
            Assert.AreEqual(2000, leilao.Lances[0].Valor, 0.00001);
        }

        [Test]
        public void DeveReceberVariosLances()
        {
            Leilao leilao = new Leilao("Macbook Pro 15");
            leilao.Propoe(new Lance(stevejobs, 2000));
            leilao.Propoe(new Lance(steveWoz, 3000));

            Assert.AreEqual(2, leilao.Lances.Count);
            Assert.AreEqual(2000, leilao.Lances[0].Valor, 0.00001);
            Assert.AreEqual(3000, leilao.Lances[1].Valor, 0.00001);
        }

        [Test]
        public void NaoDeveAceitarDoisLancesSeguidosDoMesmoUsuario()
        {
            Leilao leilao = new Leilao("Macbook Pro 15");

            leilao.Propoe(new Lance(stevejobs, 2000));
            leilao.Propoe(new Lance(stevejobs, 3000));

            Assert.AreEqual(1, leilao.Lances.Count);
            Assert.AreEqual(2000, leilao.Lances[0].Valor, 0.00001);
        }

        [Test]
        public void NaoDeveAceitarMaisDoQue5LancesDeUmMesmoUsuario()
        {
            Leilao leilao = new Leilao("Macbook Pro 15");
            
            leilao.Propoe(new Lance(stevejobs, 2000));
            leilao.Propoe(new Lance(billgates, 3000));
            leilao.Propoe(new Lance(stevejobs, 4000));
            leilao.Propoe(new Lance(billgates, 5000));
            leilao.Propoe(new Lance(stevejobs, 6000));
            leilao.Propoe(new Lance(billgates, 7000));
            leilao.Propoe(new Lance(stevejobs, 8000));
            leilao.Propoe(new Lance(billgates, 9000));
            leilao.Propoe(new Lance(stevejobs, 10000));
            leilao.Propoe(new Lance(billgates, 11000));

            // deve ser ignorado
            leilao.Propoe(new Lance(stevejobs, 12000));

            Assert.AreEqual(10, leilao.Lances.Count);
            int ultimo = leilao.Lances.Count - 1;
            Lance ultimoLance = leilao.Lances[ultimo];
            Assert.AreEqual(11000.0, ultimoLance.Valor, 0.00001);
        }

        [Test]
        public void UsuarioDobraOLance()
        {
            Leilao leilao = new Leilao("Macbook Pro 15");
            
            leilao.Propoe(new Lance(stevejobs, 2000));
            leilao.Propoe(new Lance(billgates, 3000));

            leilao.DobraLance(stevejobs);

            Assert.AreEqual(3, leilao.Lances.Count);
            int ultimo = leilao.Lances.Count - 1;
            Lance ultimoLance = leilao.Lances[ultimo];
            Assert.AreEqual(4000.0, ultimoLance.Valor, 0.00001);
            Assert.AreEqual(stevejobs, ultimoLance.Usuario);
        }

        [Test]
        public void UsuarioDobraOLanceEmSeguida()
        {
            Leilao leilao = new Leilao("Macbook Pro 15");

            leilao.Propoe(new Lance(stevejobs, 2000));
            leilao.Propoe(new Lance(billgates, 3000));

            leilao.DobraLance(billgates);

            Assert.AreEqual(2, leilao.Lances.Count);
            int ultimo = leilao.Lances.Count - 1;
            Lance ultimoLance = leilao.Lances[ultimo];
            Assert.AreEqual(3000.0, ultimoLance.Valor, 0.00001);
            Assert.AreEqual(billgates, ultimoLance.Usuario);
        }

        [Test]
        public void UsuarioCom5LancesDobraOLance()
        {
            Leilao leilao = new Leilao("Macbook Pro 15");

            leilao.Propoe(new Lance(stevejobs, 2000));
            leilao.Propoe(new Lance(billgates, 3000));
            leilao.Propoe(new Lance(stevejobs, 4000));
            leilao.Propoe(new Lance(billgates, 5000));
            leilao.Propoe(new Lance(stevejobs, 6000));
            leilao.Propoe(new Lance(billgates, 7000));
            leilao.Propoe(new Lance(stevejobs, 8000));
            leilao.Propoe(new Lance(billgates, 9000));
            leilao.Propoe(new Lance(stevejobs, 10000));
            leilao.Propoe(new Lance(billgates, 11000));

            // deve ser ignorado
            leilao.DobraLance(stevejobs);

            Assert.AreEqual(10, leilao.Lances.Count);
            int ultimo = leilao.Lances.Count - 1;
            Lance ultimoLance = leilao.Lances[ultimo];
            Assert.AreEqual(11000.0, ultimoLance.Valor, 0.00001);
        }

        [Test]
        public void NaoDeveDobrarCasoNaoHajaLanceAnterior()
        {
            Leilao leilao = new Leilao("Macbook Pro 15");

            leilao.DobraLance(stevejobs);

            Assert.AreEqual(0, leilao.Lances.Count);
        }
    }
}
