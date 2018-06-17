namespace ProjetoCompras.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class adicionadoCodigoProdutoemProdutoFornecedor : DbMigration
    {
        public override void Up()
        {
            AddColumn("dbo.ProdutoFornecedors", "CodigoProduto", c => c.Int(nullable: false));
        }
        
        public override void Down()
        {
            DropColumn("dbo.ProdutoFornecedors", "CodigoProduto");
        }
    }
}
