namespace ProjetoControleStock.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class Riquerednoscampos : DbMigration
    {
        public override void Up()
        {
            AlterColumn("dbo.Cliente", "Cod_Cliente", c => c.String(nullable: false, maxLength: 45, storeType: "nvarchar"));
            AlterColumn("dbo.Cliente", "Nome", c => c.String(nullable: false, maxLength: 45, storeType: "nvarchar"));
            AlterColumn("dbo.Cliente", "RazaoSocial", c => c.String(nullable: false, maxLength: 45, storeType: "nvarchar"));
            AlterColumn("dbo.Cliente", "CpforCnpj", c => c.String(nullable: false, maxLength: 45, storeType: "nvarchar"));
            AlterColumn("dbo.Fornecedor", "Cod_Fornecedor", c => c.String(nullable: false, maxLength: 45, storeType: "nvarchar"));
            AlterColumn("dbo.Fornecedor", "Nome", c => c.String(nullable: false, maxLength: 45, storeType: "nvarchar"));
            AlterColumn("dbo.Fornecedor", "RazaoSocial", c => c.String(nullable: false, maxLength: 45, storeType: "nvarchar"));
            AlterColumn("dbo.Fornecedor", "CpforCnpj", c => c.String(nullable: false, maxLength: 45, storeType: "nvarchar"));
        }
        
        public override void Down()
        {
            AlterColumn("dbo.Fornecedor", "CpforCnpj", c => c.String(maxLength: 45, storeType: "nvarchar"));
            AlterColumn("dbo.Fornecedor", "RazaoSocial", c => c.String(maxLength: 45, storeType: "nvarchar"));
            AlterColumn("dbo.Fornecedor", "Nome", c => c.String(maxLength: 45, storeType: "nvarchar"));
            AlterColumn("dbo.Fornecedor", "Cod_Fornecedor", c => c.String(maxLength: 45, storeType: "nvarchar"));
            AlterColumn("dbo.Cliente", "CpforCnpj", c => c.String(maxLength: 45, storeType: "nvarchar"));
            AlterColumn("dbo.Cliente", "RazaoSocial", c => c.String(maxLength: 45, storeType: "nvarchar"));
            AlterColumn("dbo.Cliente", "Nome", c => c.String(maxLength: 45, storeType: "nvarchar"));
            AlterColumn("dbo.Cliente", "Cod_Cliente", c => c.String(maxLength: 45, storeType: "nvarchar"));
        }
    }
}
