namespace LaTuerca.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class Empresa : DbMigration
    {
        public override void Up()
        {
            CreateTable(
                "dbo.Empresas",
                c => new
                    {
                        Id = c.Int(nullable: false, identity: true),
                        Nombre = c.String(nullable: false),
                        NombreCorto = c.String(nullable: false),
                        Ruc = c.Int(nullable: false),
                        Departamento = c.String(),
                        Ciudad = c.String(),
                        Pais = c.String(),
                        Email = c.String(),
                        Direccion = c.String(),
                        Telefono = c.String(),
                        Web = c.String(),
                    })
                .PrimaryKey(t => t.Id);
            
        }
        
        public override void Down()
        {
            DropTable("dbo.Empresas");
        }
    }
}
