using EntityHello.Entidades;
using Microsoft.Data.Entity;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EntityHello
{
    class Program
    {
        static void Main(string[] args)
        {

            /*
            Categoria c = new Categoria()
            {
                Nome = "Informática"
            };

            contexto.Categorias.Add(c);
            contexto.SaveChanges();

            Produto p = new Produto()
            {
                Nome = "Teclado",
                Preco = 30M,
                Categoria = c

            };

            contexto.Produtos.Add(p);
            contexto.SaveChanges();
            */

            /*
            Produto p = contexto.Produtos.Include(produto => produto.Categoria).FirstOrDefault(produto => produto.ID == 1);
            Console.WriteLine("Produto {0}, Categoria {1}", p.Nome, p.Categoria.Nome);

            var categoria = contexto.Categorias.Include(c => c.Produtos).FirstOrDefault(c => c.ID == 1);

            foreach(var p1 in categoria.Produtos)
            {
                Console.WriteLine("Produto {0} = {1}", p1.ID, p1.Nome);
            }

                        decimal precoMinimo = 20;
            var busca = from p in ctx.Produtos
                        where p.Preco >= precoMinimo && p.Categoria.Nome == "Roupas"
                        orderby p.Nome, p.Preco
                        select p;

            var busca = from p in ctx.Produtos
                        where p.Preco >= 100
                        orderby p.Nome
                        select p;
                IList<Produto> resultado = busca.ToList();

            var resultado = dao.BuscaPorNomePrecoNomeCategoria(null, 0, "informática");
            foreach (var produto in resultado)
            {
                Console.WriteLine("{0} => {1} R$ {2}", produto.ID, produto.Nome, produto.Preco);
            }

                        UsuarioDAO dao = new UsuarioDAO();
            Usuario renan = dao.BuscaPorId(1);

            Produto p1 = ctx.Produtos.FirstOrDefault(p => p.ID == 1);
            Produto p2 = ctx.Produtos.FirstOrDefault(p => p.ID == 2);

            Venda v = new Venda()
            {
                Cliente = renan
            };

            ProdutoVenda pv1 = new ProdutoVenda()
            {
                Venda = v,
                Produto = p1
            };

            ProdutoVenda pv2 = new ProdutoVenda()
            {
                Venda = v,
                Produto = p2
            };
            //v.ProdutoVenda.Add(pv1);
            //v.ProdutoVenda.Add(pv2);

            ctx.Vendas.Add(v);
            ctx.ProdutoVenda.Add(pv1);
            ctx.ProdutoVenda.Add(pv2);

                        //ctx.SaveChanges();

            
           



            Venda venda = ctx.Vendas.Include(v => v.Cliente).Include(v => v.ProdutoVenda).ThenInclude(pv => pv.Produto).FirstOrDefault(v => v.ID == 1);
            Console.WriteLine("Venda Usuario {0}", venda.Cliente.Nome);
            foreach (var pvl in venda.ProdutoVenda)
            {
                Console.WriteLine("{0} => {1} R$ {2}", pvl.Produto.ID, pvl.Produto.Nome, pvl.Produto.Preco);
            }
            Console.ReadLine();

            */

            EntidadesContexto ctx = new EntidadesContexto();

            PessoaFisica pf = new PessoaFisica()
            {
                Nome = "Guilherme2",
                CPF = "123456",
                Senha = "123"
            };

            PessoaJuridica pj = new PessoaJuridica()
            {
                Nome = "Alura2",
                CNPJ = "789/1000",
                Senha = "123"
            };

            UsuarioDAO uu = new UsuarioDAO();

            uu.Salva(pf);
            uu.Salva(pj);
            ctx.SaveChanges();

        }
    }
}
