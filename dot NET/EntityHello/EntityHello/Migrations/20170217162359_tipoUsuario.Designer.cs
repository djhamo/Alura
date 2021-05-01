using System;
using Microsoft.Data.Entity;
using Microsoft.Data.Entity.Infrastructure;
using Microsoft.Data.Entity.Metadata;
using Microsoft.Data.Entity.Migrations;
using EntityHello;

namespace EntityHello.Migrations
{
    [DbContext(typeof(EntidadesContexto))]
    [Migration("20170217162359_tipoUsuario")]
    partial class tipoUsuario
    {
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
            modelBuilder
                .HasAnnotation("ProductVersion", "7.0.0-rc1-16348")
                .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

            modelBuilder.Entity("EntityHello.Entidades.Categoria", b =>
                {
                    b.Property<int>("ID")
                        .ValueGeneratedOnAdd();

                    b.Property<string>("Nome");

                    b.HasKey("ID");
                });

            modelBuilder.Entity("EntityHello.Entidades.Produto", b =>
                {
                    b.Property<int>("ID")
                        .ValueGeneratedOnAdd();

                    b.Property<int>("CategoriaID");

                    b.Property<string>("Nome");

                    b.Property<decimal>("Preco");

                    b.HasKey("ID");
                });

            modelBuilder.Entity("EntityHello.Entidades.ProdutoVenda", b =>
                {
                    b.Property<int>("VendaID");

                    b.Property<int>("ProdutoID");

                    b.HasKey("VendaID", "ProdutoID");
                });

            modelBuilder.Entity("EntityHello.Entidades.Usuario", b =>
                {
                    b.Property<int>("ID")
                        .ValueGeneratedOnAdd();

                    b.Property<string>("Discriminator")
                        .IsRequired();

                    b.Property<string>("Nome");

                    b.Property<string>("Senha");

                    b.HasKey("ID");

                    b.HasAnnotation("Relational:DiscriminatorProperty", "Discriminator");

                    b.HasAnnotation("Relational:DiscriminatorValue", "Usuario");
                });

            modelBuilder.Entity("EntityHello.Entidades.Venda", b =>
                {
                    b.Property<int>("ID")
                        .ValueGeneratedOnAdd();

                    b.Property<int>("ClienteID");

                    b.HasKey("ID");
                });

            modelBuilder.Entity("EntityHello.Entidades.PessoaFisica", b =>
                {
                    b.HasBaseType("EntityHello.Entidades.Usuario");

                    b.Property<string>("CPF");

                    b.HasAnnotation("Relational:DiscriminatorValue", "PessoaFisica");
                });

            modelBuilder.Entity("EntityHello.Entidades.PessoaJuridica", b =>
                {
                    b.HasBaseType("EntityHello.Entidades.Usuario");

                    b.Property<string>("CNPJ");

                    b.HasAnnotation("Relational:DiscriminatorValue", "PessoaJuridica");
                });

            modelBuilder.Entity("EntityHello.Entidades.Produto", b =>
                {
                    b.HasOne("EntityHello.Entidades.Categoria")
                        .WithMany()
                        .HasForeignKey("CategoriaID");
                });

            modelBuilder.Entity("EntityHello.Entidades.ProdutoVenda", b =>
                {
                    b.HasOne("EntityHello.Entidades.Produto")
                        .WithMany()
                        .HasForeignKey("ProdutoID");

                    b.HasOne("EntityHello.Entidades.Venda")
                        .WithMany()
                        .HasForeignKey("VendaID");
                });

            modelBuilder.Entity("EntityHello.Entidades.Venda", b =>
                {
                    b.HasOne("EntityHello.Entidades.Usuario")
                        .WithMany()
                        .HasForeignKey("ClienteID");
                });
        }
    }
}
