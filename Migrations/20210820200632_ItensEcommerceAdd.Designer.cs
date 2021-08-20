﻿// <auto-generated />
using EntityFrameWork.Servicos;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;

namespace EntityFrameWork.Migrations
{
    [DbContext(typeof(DbContexto))]
    [Migration("20210820200632_ItensEcommerceAdd")]
    partial class ItensEcommerceAdd
    {
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("Relational:MaxIdentifierLength", 64)
                .HasAnnotation("ProductVersion", "5.0.8");

            modelBuilder.Entity("EntityFrameWork.Models.Cliente", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasColumnName("id");

                    b.Property<int>("EnderecoId")
                        .HasColumnType("int")
                        .HasColumnName("endereco_id");

                    b.Property<string>("Nome")
                        .IsRequired()
                        .HasMaxLength(150)
                        .HasColumnType("varchar(150)")
                        .HasColumnName("nome");

                    b.Property<string>("Observacao")
                        .IsRequired()
                        .HasColumnType("text")
                        .HasColumnName("observacao");

                    b.HasKey("Id");

                    b.HasIndex("EnderecoId");

                    b.ToTable("clientes");
                });

            modelBuilder.Entity("EntityFrameWork.Models.Endereco", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasColumnName("id");

                    b.Property<string>("Bairro")
                        .IsRequired()
                        .HasMaxLength(150)
                        .HasColumnType("varchar(150)")
                        .HasColumnName("bairro");

                    b.Property<string>("Cep")
                        .IsRequired()
                        .HasMaxLength(10)
                        .HasColumnType("varchar(10)")
                        .HasColumnName("cep");

                    b.Property<string>("Cidade")
                        .IsRequired()
                        .HasMaxLength(150)
                        .HasColumnType("varchar(150)")
                        .HasColumnName("cidade");

                    b.Property<string>("Complemento")
                        .IsRequired()
                        .HasMaxLength(255)
                        .HasColumnType("varchar(255)")
                        .HasColumnName("complemento");

                    b.Property<string>("Estado")
                        .IsRequired()
                        .HasMaxLength(2)
                        .HasColumnType("varchar(2)")
                        .HasColumnName("estado");

                    b.Property<string>("Logradouro")
                        .IsRequired()
                        .HasMaxLength(255)
                        .HasColumnType("varchar(255)")
                        .HasColumnName("logradouro");

                    b.Property<string>("Numero")
                        .IsRequired()
                        .HasMaxLength(30)
                        .HasColumnType("varchar(30)")
                        .HasColumnName("numero");

                    b.HasKey("Id");

                    b.ToTable("enderecos");
                });

            modelBuilder.Entity("EntityFrameWork.Models.Pedido", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasColumnName("id");

                    b.Property<int>("ClienteId")
                        .HasColumnType("int")
                        .HasColumnName("cliente_id");

                    b.Property<double>("Data")
                        .HasColumnType("double")
                        .HasColumnName("data");

                    b.Property<int>("EnderecoId")
                        .HasColumnType("int")
                        .HasColumnName("endereco_id");

                    b.Property<double>("ValorTotal")
                        .HasColumnType("double")
                        .HasColumnName("valor_total");

                    b.HasKey("Id");

                    b.HasIndex("ClienteId");

                    b.HasIndex("EnderecoId");

                    b.ToTable("pedidos");
                });

            modelBuilder.Entity("EntityFrameWork.Models.PedidoProduto", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasColumnName("id");

                    b.Property<int>("PedidoId")
                        .HasColumnType("int")
                        .HasColumnName("pedido_id");

                    b.Property<int>("ProdutoId")
                        .HasColumnType("int")
                        .HasColumnName("produto_id");

                    b.Property<int>("Quantidade")
                        .HasColumnType("int")
                        .HasColumnName("Quantidade");

                    b.Property<double>("Valor")
                        .HasColumnType("double")
                        .HasColumnName("valor");

                    b.HasKey("Id");

                    b.HasIndex("PedidoId");

                    b.HasIndex("ProdutoId");

                    b.ToTable("pedidos_produtos");
                });

            modelBuilder.Entity("EntityFrameWork.Models.Produto", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasColumnName("id");

                    b.Property<string>("Descricao")
                        .HasColumnType("text")
                        .HasColumnName("descricao");

                    b.Property<string>("Nome")
                        .IsRequired()
                        .HasMaxLength(150)
                        .HasColumnType("varchar(150)")
                        .HasColumnName("nome");

                    b.Property<string>("UrlImagem")
                        .HasMaxLength(255)
                        .HasColumnType("varchar(255)")
                        .HasColumnName("imagem");

                    b.Property<double>("Valor")
                        .HasColumnType("double")
                        .HasColumnName("valor");

                    b.HasKey("Id");

                    b.ToTable("produtos");
                });

            modelBuilder.Entity("EntityFrameWork.Models.Cliente", b =>
                {
                    b.HasOne("EntityFrameWork.Models.Endereco", "Endereco")
                        .WithMany()
                        .HasForeignKey("EnderecoId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("Endereco");
                });

            modelBuilder.Entity("EntityFrameWork.Models.Pedido", b =>
                {
                    b.HasOne("EntityFrameWork.Models.Cliente", "Cliente")
                        .WithMany()
                        .HasForeignKey("ClienteId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("EntityFrameWork.Models.Endereco", "Endereco")
                        .WithMany()
                        .HasForeignKey("EnderecoId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("Cliente");

                    b.Navigation("Endereco");
                });

            modelBuilder.Entity("EntityFrameWork.Models.PedidoProduto", b =>
                {
                    b.HasOne("EntityFrameWork.Models.Pedido", "Pedido")
                        .WithMany()
                        .HasForeignKey("PedidoId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("EntityFrameWork.Models.Produto", "Produto")
                        .WithMany()
                        .HasForeignKey("ProdutoId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("Pedido");

                    b.Navigation("Produto");
                });
#pragma warning restore 612, 618
        }
    }
}
