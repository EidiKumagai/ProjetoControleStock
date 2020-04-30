namespace ProjetoControleStock.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class staragain : DbMigration
    {
        public override void Up()
        {
           
            
            CreateTable(
                "dbo.Entrada",
                c => new
                    {
                        Id = c.Int(nullable: false, identity: true, storeType: "mediumint"),
                        Cod_Entrada = c.String(nullable: false, maxLength: 45, storeType: "nvarchar"),
                        qtde_Entrada = c.Int(nullable: false),
                        fornecedor_id = c.Int(nullable: false, storeType: "mediumint"),
                        produto_id = c.Int(nullable: false, storeType: "mediumint"),
                        Estoque_Id = c.Int(storeType: "mediumint"),
                    })
                .PrimaryKey(t => t.Id)
                .ForeignKey("dbo.Fornecedor", t => t.fornecedor_id, cascadeDelete: true)
                .ForeignKey("dbo.Produto", t => t.produto_id, cascadeDelete: true)
                .ForeignKey("dbo.Estoque", t => t.Estoque_Id)
                .Index(t => t.fornecedor_id)
                .Index(t => t.produto_id)
                .Index(t => t.Estoque_Id);

            CreateTable(
                "dbo.Saida",
                c => new
                    {
                        Id = c.Int(nullable: false, identity: true, storeType: "mediumint"),
                        Cod_Saida = c.String(nullable: false, maxLength: 45, storeType: "nvarchar"),
                        Qtde_Saida = c.Int(nullable: false),
                        Cliente_id = c.Int(storeType: "mediumint"),
                        Produto_id = c.Int(storeType: "mediumint"),
                        Estoque_Id = c.Int(storeType: "mediumint"),
                    })
                .PrimaryKey(t => t.Id)
                .ForeignKey("dbo.Cliente", t => t.Cliente_id)
                .ForeignKey("dbo.Produto", t => t.Produto_id)
                .ForeignKey("dbo.Estoque", t => t.Estoque_Id)
                .Index(t => t.Cliente_id)
                .Index(t => t.Produto_id)
                .Index(t => t.Estoque_Id);
            
        }
        
        public override void Down()
        {
            DropForeignKey("dbo.Saida", "Estoque_Id", "dbo.Estoque");
            DropForeignKey("dbo.Saida", "Produto_id", "dbo.Produto");
            DropForeignKey("dbo.Saida", "Cliente_id", "dbo.Cliente");
            DropForeignKey("dbo.Entrada", "Estoque_Id", "dbo.Estoque");
            DropForeignKey("dbo.Entrada", "produto_id", "dbo.Produto");
            DropForeignKey("dbo.Entrada", "fornecedor_id", "dbo.Fornecedor");
            DropIndex("dbo.Saida", new[] { "Estoque_Id" });
            DropIndex("dbo.Saida", new[] { "Produto_id" });
            DropIndex("dbo.Saida", new[] { "Cliente_id" });
            DropIndex("dbo.Entrada", new[] { "Estoque_Id" });
            DropIndex("dbo.Entrada", new[] { "produto_id" });
            DropIndex("dbo.Entrada", new[] { "fornecedor_id" });
            DropTable("dbo.Saida");
            DropTable("dbo.Estoque");
            DropTable("dbo.Produto");
            DropTable("dbo.Fornecedor");
            DropTable("dbo.Entrada");
            DropTable("dbo.Cliente");
        }
    }
}
