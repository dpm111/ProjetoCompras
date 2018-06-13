namespace ProjetoCompras.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class ProjetoCompra : DbMigration
    {
        public override void Up()
        {          
            
            CreateTable(
                "dbo.CabecalhoOrdemDeCompras",
                c => new
                    {
                        PedidoDaCompraID = c.Int(nullable: false, identity: true),
                        NumeroRevisao = c.Byte(nullable: false),
                        Status = c.Byte(nullable: false),
                        EmpregadoId = c.Int(nullable: false),
                        DataEnvio = c.DateTime(nullable: false),
                        SubTotal = c.Decimal(nullable: false, precision: 18, scale: 2),
                        TaxAmt = c.Decimal(nullable: false, precision: 18, scale: 2),
                        Frete = c.Decimal(nullable: false, precision: 18, scale: 2),
                        TotalDevido = c.Decimal(nullable: false, precision: 18, scale: 2),
                        DataModificacao = c.DateTime(nullable: false),
                        DataDespachada = c.DateTime(),
                        CodigoFornecedor = c.Int(nullable: false),
                        Fornecedor_UnidadeDeNegocioID = c.Int(),
                        MetodoDeEnvio_MetodoEnvioID = c.Int(),
                    })
                .PrimaryKey(t => t.PedidoDaCompraID)
                .ForeignKey("dbo.Fornecedors", t => t.Fornecedor_UnidadeDeNegocioID)
                .ForeignKey("dbo.MetodoDeEnvios", t => t.MetodoDeEnvio_MetodoEnvioID)
                .Index(t => t.Fornecedor_UnidadeDeNegocioID)
                .Index(t => t.MetodoDeEnvio_MetodoEnvioID);
            
            CreateTable(
                "dbo.DetalhesDoPedidoes",
                c => new
                    {
                        DetalhesPedidoID = c.Int(nullable: false, identity: true),
                        DataVencimento = c.DateTime(nullable: false),
                        QtdOrdem = c.Short(nullable: false),
                        ProdutoID = c.Int(nullable: false),
                        PrecoUnidade = c.Decimal(nullable: false, precision: 18, scale: 2),
                        LinhaTotal = c.Decimal(nullable: false, precision: 18, scale: 2),
                        QtdRecebido = c.Decimal(nullable: false, precision: 18, scale: 2),
                        QtdRejeitado = c.Decimal(nullable: false, precision: 18, scale: 2),
                        StockedQty = c.Decimal(nullable: false, precision: 18, scale: 2),
                        DataModificacao = c.DateTime(nullable: false),
                        CabecalhoOrdemCompra_PedidoDaCompraID = c.Int(),
                    })
                .PrimaryKey(t => t.DetalhesPedidoID)
                .ForeignKey("dbo.CabecalhoOrdemDeCompras", t => t.CabecalhoOrdemCompra_PedidoDaCompraID)
                .Index(t => t.CabecalhoOrdemCompra_PedidoDaCompraID);
            
            CreateTable(
                "dbo.Fornecedors",
                c => new
                    {
                        UnidadeDeNegocioID = c.Int(nullable: false, identity: true),
                        CodigoUnidadeDeNegocio = c.Int(nullable: false),
                        NumeroDaConta = c.String(maxLength: 15),
                        Name = c.String(maxLength: 50),
                        ClasseCredito = c.Byte(nullable: false),
                        PreferidoFornecedorStatus = c.Boolean(nullable: false),
                        FlagAtivo = c.Boolean(nullable: false),
                        DataModificacao = c.DateTime(nullable: false),
                        ComprasWebServiceURL = c.String(),
                    })
                .PrimaryKey(t => t.UnidadeDeNegocioID);
            
            CreateTable(
                "dbo.MetodoDeEnvios",
                c => new
                    {
                        MetodoEnvioID = c.Int(nullable: false, identity: true),
                        Nome = c.String(nullable: false, maxLength: 50),
                        MetodoBase = c.Decimal(nullable: false, precision: 18, scale: 2),
                        MetodoRate = c.Decimal(nullable: false, precision: 18, scale: 2),
                        rowguid = c.Guid(nullable: false),
                        DataModificacao = c.DateTime(nullable: false),
                    })
                .PrimaryKey(t => t.MetodoEnvioID);
            
            CreateTable(
                "dbo.ProdutoFornecedors",
                c => new
                    {
                        ProdutoID = c.Int(nullable: false, identity: true),
                        UnidadeDeNegocioID = c.Int(nullable: false),
                        TempoMedio = c.Int(nullable: false),
                        PrecoMedio = c.Decimal(nullable: false, precision: 18, scale: 2),
                        QtdOrdemMin = c.Int(nullable: false),
                        QtdOrdemMax = c.Int(nullable: false),
                        MediaUnitaria = c.String(maxLength: 3),
                        DataModificacao = c.DateTime(nullable: false),
                        CustoRecebimento = c.Decimal(precision: 18, scale: 2),
                        DataUltimoRecebimento = c.DateTime(),
                        OnOrderQuantidade = c.Int(),
                    })
                .PrimaryKey(t => t.ProdutoID);
            
        }
        
        public override void Down()
        {
            DropForeignKey("dbo.CabecalhoOrdemDeCompras", "MetodoDeEnvio_MetodoEnvioID", "dbo.MetodoDeEnvios");
            DropForeignKey("dbo.CabecalhoOrdemDeCompras", "Fornecedor_UnidadeDeNegocioID", "dbo.Fornecedors");
            DropForeignKey("dbo.DetalhesDoPedidoes", "CabecalhoOrdemCompra_PedidoDaCompraID", "dbo.CabecalhoOrdemDeCompras");
            DropIndex("dbo.DetalhesDoPedidoes", new[] { "CabecalhoOrdemCompra_PedidoDaCompraID" });
            DropIndex("dbo.CabecalhoOrdemDeCompras", new[] { "MetodoDeEnvio_MetodoEnvioID" });
            DropIndex("dbo.CabecalhoOrdemDeCompras", new[] { "Fornecedor_UnidadeDeNegocioID" });
            DropTable("dbo.ProdutoFornecedors");
            DropTable("dbo.MetodoDeEnvios");
            DropTable("dbo.Fornecedors");
            DropTable("dbo.DetalhesDoPedidoes");
            DropTable("dbo.CabecalhoOrdemDeCompras");
            DropTable("dbo.__MigrationHistory");
        }
    }
}
