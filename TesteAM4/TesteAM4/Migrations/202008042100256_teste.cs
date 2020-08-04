namespace TesteAM4.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class teste : DbMigration
    {
        public override void Up()
        {
            CreateTable(
                "dbo.Noticias",
                c => new
                    {
                        ID = c.Int(nullable: false, identity: true),
                        titulo = c.String(nullable: false),
                        chamada = c.String(nullable: false),
                        texto = c.String(nullable: false),
                        imagem = c.String(),
                        autor = c.String(nullable: false),
                        data = c.DateTime(nullable: false),
                    })
                .PrimaryKey(t => t.ID);
            
        }
        
        public override void Down()
        {
            DropTable("dbo.Noticias");
        }
    }
}
