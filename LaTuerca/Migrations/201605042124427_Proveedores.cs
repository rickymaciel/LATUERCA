namespace LaTuerca.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class Proveedores : DbMigration
    {
        public override void Up()
        {
            CreateTable(
                "dbo.Proveedores",
                c => new
                    {
                        Id = c.Int(nullable: false, identity: true),
                        RazonSocial = c.String(nullable: false),
                        Ruc = c.String(nullable: false),
                        Ciudad = c.String(),
                        Departamento = c.String(),
                        Pais = c.String(),
                        Direccion = c.String(),
                        Telefono = c.String(),
                        FormaPago = c.String(),
                        FechaAlta = c.DateTime(nullable: false),
                        FechaBaja = c.DateTime(nullable: false),
                        estado = c.Boolean(nullable: false),
                        esAcreedor = c.Boolean(nullable: false),
                    })
                .PrimaryKey(t => t.Id);
            
        }
        
        public override void Down()
        {
            DropTable("dbo.Proveedores");
        }
    }
}
