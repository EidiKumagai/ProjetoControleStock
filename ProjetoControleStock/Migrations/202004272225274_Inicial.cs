namespace ProjetoControleStock.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class Inicial : DbMigration
    {
        public override void Up()
        {
            CreateTable(
                "dbo.Cliente",
                c => new
                    {
                        id = c.Int(nullable: false, identity: true, storeType: "mediumint"),
                        Cod_Cliente = c.String(maxLength: 45, storeType: "nvarchar"),
                        Nome = c.String(maxLength: 45, storeType: "nvarchar"),
                        RazaoSocial = c.String(maxLength: 45, storeType: "nvarchar"),
                        CpforCnpj = c.String(maxLength: 45, storeType: "nvarchar"),
                        Telefone = c.String(maxLength: 45, storeType: "nvarchar"),
                    })
                .PrimaryKey(t => t.id);
            
            CreateTable(
                "dbo.Fornecedor",
                c => new
                    {
                        id = c.Int(nullable: false, identity: true, storeType: "mediumint"),
                        Cod_Fornecedor = c.String(maxLength: 45, storeType: "nvarchar"),
                        Nome = c.String(maxLength: 45, storeType: "nvarchar"),
                        RazaoSocial = c.String(maxLength: 45, storeType: "nvarchar"),
                        CpforCnpj = c.String(maxLength: 45, storeType: "nvarchar"),
                        Telefone = c.String(maxLength: 45, storeType: "nvarchar"),
                        Email = c.String(maxLength: 45, storeType: "nvarchar"),
                    })
                .PrimaryKey(t => t.id);
            
        }
        
        public override void Down()
        {
            DropTable("dbo.Fornecedor");
            DropTable("dbo.Cliente");
        }
    }
}
