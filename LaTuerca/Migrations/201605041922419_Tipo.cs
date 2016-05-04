namespace LaTuerca.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class Tipo : DbMigration
    {
        public override void Up()
        {
            CreateTable(
                "dbo.Tipoes",
                c => new
                    {
                        Id = c.Int(nullable: false, identity: true),
                        Referencia = c.String(nullable: false),
                        Nombre = c.String(nullable: false),
                        Unidad = c.String(nullable: false),
                        Cilindrada = c.String(nullable: false),
                        TipoMotor = c.String(nullable: false),
                        Estado = c.Boolean(nullable: false),
                    })
                .PrimaryKey(t => t.Id);
            
        }
        
        public override void Down()
        {
            DropTable("dbo.Tipoes");
        }
    }
}
