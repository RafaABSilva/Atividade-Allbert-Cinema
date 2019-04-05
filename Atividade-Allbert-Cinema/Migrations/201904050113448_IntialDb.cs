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
                        Filme_Id = c.Int(nullable: false),
                        Sala_Id = c.Int(nullable: false),
                    })
                .PrimaryKey(t => t.Id)
                .ForeignKey("dbo.Filmes", t => t.Filme_Id, cascadeDelete: true)
                .ForeignKey("dbo.Salas", t => t.Sala_Id, cascadeDelete: true)
                .Index(t => t.Filme_Id)
                .Index(t => t.Sala_Id);
            
            CreateTable(
                "dbo.Filmes",
                c => new
                    {
                        Id = c.Int(nullable: false, identity: true),
                        Nome = c.String(nullable: false, maxLength: 120, storeType: "nvarchar"),
                        Duracao = c.Int(nullable: false),
                        DataLancamento = c.Int(nullable: false),
                        Categoria_Id = c.Int(nullable: false),
                    })
                .PrimaryKey(t => t.Id)
                .ForeignKey("dbo.Categorias", t => t.Categoria_Id, cascadeDelete: true)
                .Index(t => t.Categoria_Id);
            
            CreateTable(
                "dbo.Salas",
                c => new
                    {
                        Id = c.Int(nullable: false, identity: true),
                        Nome = c.String(nullable: false, maxLength: 120, storeType: "nvarchar"),
                        Capacidade = c.Int(nullable: false),
                        TamanhoDaTela = c.Single(nullable: false),
                    })
                .PrimaryKey(t => t.Id);
            
        }
        
        public override void Down()
        {
            DropForeignKey("dbo.Exibicoes", "Sala_Id", "dbo.Salas");
            DropForeignKey("dbo.Exibicoes", "Filme_Id", "dbo.Filmes");
            DropForeignKey("dbo.Filmes", "Categoria_Id", "dbo.Categorias");
            DropIndex("dbo.Filmes", new[] { "Categoria_Id" });
            DropIndex("dbo.Exibicoes", new[] { "Sala_Id" });
            DropIndex("dbo.Exibicoes", new[] { "Filme_Id" });
            DropTable("dbo.Salas");
            DropTable("dbo.Filmes");
            DropTable("dbo.Exibicoes");
            DropTable("dbo.Categorias");
        }
    }
}
