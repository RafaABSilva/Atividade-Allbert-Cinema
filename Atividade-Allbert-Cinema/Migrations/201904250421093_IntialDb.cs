namespace Atividade_Allbert_Cinema.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class IntialDb : DbMigration
    {
        public override void Up()
        {
            AlterColumn("dbo.Salas", "TamanhoDaTela", c => c.String(nullable: false, unicode: false));
        }
        
        public override void Down()
        {
            AlterColumn("dbo.Salas", "TamanhoDaTela", c => c.Single(nullable: false));
        }
    }
}
