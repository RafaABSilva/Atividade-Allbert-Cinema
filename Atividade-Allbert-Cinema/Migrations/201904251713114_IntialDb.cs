namespace Atividade_Allbert_Cinema.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class IntialDb : DbMigration
    {
        public override void Up()
        {
            CreateTable(
                "dbo.Categorias",
                c => new
                    {
                        Id = c.Int(nullable: false, identity: true),
                        Descricao = c.String(nullable: false, maxLength: 240, storeType: "nvarchar"),
                    })
                .PrimaryKey(t => t.Id);
            
            CreateTable(
                "dbo.Exibicoes",
                c => new
                    {
                        Id = c.Int(nullable: false, identity: true),
                        FilmeID = c.Int(nullable: false),
                        SalaID = c.Int(nullable: false),
                    })
                .PrimaryKey(t => t.Id)
                .ForeignKey("dbo.Filmes", t => t.FilmeID, cascadeDelete: true)
                .ForeignKey("dbo.Salas", t => t.SalaID, cascadeDelete: true)
                .Index(t => t.FilmeID)
                .Index(t => t.SalaID);
            
            CreateTable(
                "dbo.Filmes",
                c => new
                    {
                        Id = c.Int(nullable: false, identity: true),
                        Nome = c.String(nullable: false, maxLength: 120, storeType: "nvarchar"),
                        Duracao = c.Int(nullable: false),
                        DataLancamento = c.DateTime(nullable: false, precision: 0),
                        CategoriaID = c.Int(nullable: false),
                    })
                .PrimaryKey(t => t.Id)
                .ForeignKey("dbo.Categorias", t => t.CategoriaID, cascadeDelete: true)
                .Index(t => t.CategoriaID);
            
            CreateTable(
                "dbo.Salas",
                c => new
                    {
                        Id = c.Int(nullable: false, identity: true),
                        Nome = c.String(nullable: false, maxLength: 120, storeType: "nvarchar"),
                        Capacidade = c.Int(nullable: false),
                        TamanhoDaTela = c.String(nullable: false, unicode: false),
                    })
                .PrimaryKey(t => t.Id);
            
        }
        
        public override void Down()
        {
            DropForeignKey("dbo.Exibicoes", "SalaID", "dbo.Salas");
            DropForeignKey("dbo.Exibicoes", "FilmeID", "dbo.Filmes");
            DropForeignKey("dbo.Filmes", "CategoriaID", "dbo.Categorias");
            DropIndex("dbo.Filmes", new[] { "CategoriaID" });
            DropIndex("dbo.Exibicoes", new[] { "SalaID" });
            DropIndex("dbo.Exibicoes", new[] { "FilmeID" });
            DropTable("dbo.Salas");
            DropTable("dbo.Filmes");
            DropTable("dbo.Exibicoes");
            DropTable("dbo.Categorias");
        }
    }
}
