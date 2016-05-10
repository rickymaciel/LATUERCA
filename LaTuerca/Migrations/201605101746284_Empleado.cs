namespace LaTuerca.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class Empleado : DbMigration
    {
        public override void Up()
        {
            AddColumn("dbo.Empleadoes", "Documento", c => c.Int(nullable: false));
        }
        
        public override void Down()
        {
            DropColumn("dbo.Empleadoes", "Documento");
        }
    }
}
