using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using NUnit.Framework;

namespace Caelum.Leilao.Tests
{
    [TestFixture]
    public class LanceTest
    {
        private Usuario joao;

        [SetUp]
        public void inicio()
        {
            joao = new Usuario("João");
        }

        [Test]
        public void LanceOK()
        {
            Lance lance = new Lance(joao, 100);
            Assert.AreEqual(100.0, lance.Valor, 0.0001);
        }

        [Test]
        [ExpectedException(typeof(ArgumentException))]
        public void LanceMenorZero()
        {
            Lance lance = new Lance(joao, - 100);
        }
    }
}
