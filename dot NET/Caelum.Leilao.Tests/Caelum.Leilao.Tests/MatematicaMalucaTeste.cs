using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using NUnit.Framework;

namespace Caelum.Leilao.Tests
{
    [TestFixture]
    public class MatematicaMalucaTeste
    {
        [Test]
        public void TesteMathMalucaMenor10()
        {
            MatematicaMaluca mt = new MatematicaMaluca();
            Assert.AreEqual(10, mt.ContaMaluca(5));
        }

        [Test]
        public void TesteMathMalucaMaior10Menor30()
        {
            MatematicaMaluca mt = new MatematicaMaluca();
            Assert.AreEqual(60, mt.ContaMaluca(20));
        }

        [Test]
        public void TesteMathMalucaMaior30()
        {
            MatematicaMaluca mt = new MatematicaMaluca();
            Assert.AreEqual(200, mt.ContaMaluca(50));
        }
    }
}
