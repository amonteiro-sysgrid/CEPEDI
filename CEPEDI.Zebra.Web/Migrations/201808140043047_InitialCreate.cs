namespace CEPEDI.Zebra.Web.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class InitialCreate : DbMigration
    {
        public override void Up()
        {
            CreateTable(
                "dbo.Impressoras",
                c => new
                    {
                        Guid = c.Guid(nullable: false),
                        Nome = c.String(),
                        Modelo = c.String(),
                        Path = c.String(),
                        Ribbon_Altura = c.Int(nullable: false),
                        Ribbon_Largura = c.Int(nullable: false),
                        Criacao = c.DateTime(nullable: false),
                        Atualizacao = c.DateTime(nullable: false),
                        Status = c.Boolean(nullable: false),
                    })
                .PrimaryKey(t => t.Guid);
            
            CreateTable(
                "dbo.Relatorios",
                c => new
                    {
                        Guid = c.Guid(nullable: false),
                        Codigo = c.String(),
                        Nome = c.String(),
                        Margens_Superior = c.Int(nullable: false),
                        Margens_Inferior = c.Int(nullable: false),
                        Margens_Direita = c.Int(nullable: false),
                        Margens_Esquerda = c.Int(nullable: false),
                        Dimensoes_Altura = c.Int(nullable: false),
                        Dimensoes_Largura = c.Int(nullable: false),
                        Colunas = c.Int(nullable: false),
                        Linhas = c.Int(nullable: false),
                        Arquivo = c.String(),
                        Layout = c.String(),
                        Parametros = c.String(),
                        Criacao = c.DateTime(nullable: false),
                        Atualizacao = c.DateTime(nullable: false),
                        Status = c.Boolean(nullable: false),
                        Impressora_Guid = c.Guid(),
                    })
                .PrimaryKey(t => t.Guid)
                .ForeignKey("dbo.Impressoras", t => t.Impressora_Guid)
                .Index(t => t.Impressora_Guid);
            
        }
        
        public override void Down()
        {
            DropForeignKey("dbo.Relatorios", "Impressora_Guid", "dbo.Impressoras");
            DropIndex("dbo.Relatorios", new[] { "Impressora_Guid" });
            DropTable("dbo.Relatorios");
            DropTable("dbo.Impressoras");
        }
    }
}
