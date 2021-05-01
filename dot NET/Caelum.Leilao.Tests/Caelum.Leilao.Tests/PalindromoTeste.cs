using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Caelum.Leilao;
using NUnit.Framework;

namespace Caelum.Leilao.Tests
{
    [TestFixture]
    public class PalindromoTeste
    {
        [Test]
        public void TesteFeliz1PalavraPalindromo()
        {
            Palindromo pal = new Palindromo();

            Assert.True(pal.EhPalindromo("Hannah"));
        }

        [Test]
        public void Teste1PalavraNaoPalindromo()
        {
            Palindromo pal = new Palindromo();

            Assert.False(pal.EhPalindromo("Tiago"));
        }

        [Test]
        public void Teste1FraseNaoPalindromo()
        {
            Palindromo pal = new Palindromo();

            Assert.False(pal.EhPalindromo("Eu não fiz isso"));
            
        }
    }
}
