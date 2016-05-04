namespace LaTuerca.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class Producto : DbMigration
    {
        public override void Up()
        {
            CreateTable(
                "dbo.Productoes",
                c => new
                    {
                        Id = c.Int(nullable: false, identity: true),
                        Referencia = c.String(),
                        Nombre = c.String(nullable: false),
                        Descripcion = c.String(),
                        Img = c.String(),
                        CategoriaID = c.Int(nullable: false),
                        MarcaID = c.Int(nullable: false),
                        ModeloID = c.Int(nullable: false),
                        Stock = c.Int(nullable: false),
                        StockMinimo = c.Int(nullable: false),
                        StockMaximo = c.Int(nullable: false),
                        PrecioCosto = c.Single(nullable: false),
                        PrecioVenta1 = c.Single(nullable: false),
                        PrecioVenta2 = c.Single(nullable: false),
                        PrecioVenta3 = c.Single(nullable: false),
                    })
                .PrimaryKey(t => t.Id);
            
        }
        
        public override void Down()
        {
            DropTable("dbo.Productoes");
        }
    }
}
