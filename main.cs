using System;
using System.Collections.Generic;

namespace Aula14
{
    class Program
    {
        static void Main(string[] args)
        {
            Licensa rwindols = new Licensa("Michaelsóft Rwildols", 699.90, "SUAA-HE52-W6WG-B8Y9");
            Assinatura alface123 = new Assinatura("Michaelsóft Alface", 39.90, 12, "5GNX-VM6Y-L6W8-SCPC");
            Assinatura cottonshopi = new Assinatura("Aldobo Cottonshopi", 89.90, 12, "H84A-8QDF-4XPT-A2WZ");
            Assinatura premillere = new Assinatura("Aldobo Premillere",89.90, 12, "RLBD-YTRZ-UPH7-VQGM");
            Licensa corehul = new Licensa("Corehul Dreus", 2999.90, "XZLT-CXL9-SLHV-99UM");

            ProdutoFisico mausi = new ProdutoFisico("Mausi Michaelsóft", 89.90, 12.99);
            ProdutoFisico lepetope = new ProdutoFisico("Lepetope Dehul", 3499.90, 123.45);

            Carrinho carrinho = new Carrinho();
            
            carrinho.Adicionar(rwindols);
            carrinho.Adicionar(alface123, 3);
            carrinho.Adicionar(cottonshopi);
            carrinho.Adicionar(premillere);
            carrinho.Adicionar(corehul);
            carrinho.Adicionar(mausi, 3);
            carrinho.Adicionar(lepetope);
            carrinho.ImprimirCarrinho();

            Relatorio relatorioArtistico = new Relatorio("Relatorio Artístico",
                "Este relatório apresenta todos os softwares artisticos vendidos na loja.");
            relatorioArtistico.AdicionarItem(cottonshopi);
            relatorioArtistico.AdicionarItem(premillere);
            relatorioArtistico.AdicionarItem(corehul);
            relatorioArtistico.ImprimirRelatorio();

            Cliente hermenegildo = new Cliente("Hermenegildo Benevides", "123.456.789-10");
            Cliente zoroastra = new Cliente("Zoroastra Muad'dib", "109.876.543-21");
            
            Relatorio relatorioClientes = new Relatorio("Relatório de Clientes",
                "Este relatório apresenta uma lista de todos os clientes que compraram no mês de abril");
            relatorioClientes.AdicionarItem(hermenegildo);
            relatorioClientes.AdicionarItem(zoroastra);
            relatorioClientes.ImprimirRelatorio();

            Relatorio relatorioCompra = new Relatorio("Relatório da Compra  dos clientes");
            relatorioCompra.AdicionarItem(hermenegildo);
            relatorioCompra.AdicionarItem(zoroastra);
            relatorioCompra.ImprimirRelatorio();
            
          list<Produto> produtos = new list<Produto>();
          list.Add(rwindols);
          list.Add(alface123);
          list.Add(cottonshopi);
          Fornecedor Caius = new Fornecedor("Caiu´s",produtos,"123654789");
          Fornecedor Lohans  = new Fornecedor("Lohan´s",produtos,"987456321");
         
           Relatorio relatorioFornecedores = new Relatorio("Relatório de Fornecedores","Este relatório apresenta uma lista de todos os Fornecedores");
            relatorioFornecedores.AdicionarItem(Caius);
            relatorioFornecedores.AdicionarItem(Lohans);
            relatorioFornecedores.ImprimirRelatorio();

          Dictionary<Produto, int> p = new Dictionary<Produto, int>();
            p.Add(rwindols,500);
            p.Add(alface123,500);
            p.Add(cottonshopi,500);
            p.Add(premillere,500);
            p.Add(mausi,500);
            p.Add(lepetope,500);
            Estoque estoque = new Estoque(p);
            estoque.Atz_Estoque(carrinho);
            estoque.Atz_Estoque(carrinho);

            Relatorio armazem = new Relatorio("Estoque de Produtos", " Este relatório apresenta as coisa do seu armazém");
            armazem.AdicionarItem(estoque);
            armazem.ImprimirRelatorio();

            


        }
    }
}