using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using NUnit.Framework;

namespace Caelum.Leilao.Tests
{
    [TestFixture]
    public class AnoBissextoTest
    {
        [Test]
        public void NaoEhAnoBisexto()
        {
            AnoBissexto ano = new AnoBissexto();
            Assert.IsFalse(ano.EhBissexto(2017));
        }

        [Test]
        public void AnoBisextoDe4em4Anos()
        {
            AnoBissexto ano = new AnoBissexto();
            Assert.IsTrue(ano.EhBissexto(2016));
        }
        [Test]
        public void AnoBisextoDe100em100Anos()
        {
            //Não é bisexto
            AnoBissexto ano = new AnoBissexto();
            Assert.IsFalse(ano.EhBissexto(1900));
        }
        [Test]
        public void AnoBisextoDe400em400Anos()
        {
            AnoBissexto ano = new AnoBissexto();
            Assert.IsTrue(ano.EhBissexto(2000));
        }
    }
}
