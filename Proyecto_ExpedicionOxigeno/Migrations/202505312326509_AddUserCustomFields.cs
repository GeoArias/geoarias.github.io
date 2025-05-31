namespace Proyecto_ExpedicionOxigeno.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class AddUserCustomFields : DbMigration
    {
        public override void Up()
        {
            AddColumn("dbo.AspNetUsers", "Nombre", c => c.String(nullable: false));
            AddColumn("dbo.AspNetUsers", "Apellidos", c => c.String(nullable: false));
            AddColumn("dbo.AspNetUsers", "Edad", c => c.Int(nullable: false));
            AddColumn("dbo.AspNetUsers", "Direccion", c => c.String(nullable: false));
            AddColumn("dbo.AspNetUsers", "Telefono", c => c.String(nullable: false));
        }
        
        public override void Down()
        {
            DropColumn("dbo.AspNetUsers", "Telefono");
            DropColumn("dbo.AspNetUsers", "Direccion");
            DropColumn("dbo.AspNetUsers", "Edad");
            DropColumn("dbo.AspNetUsers", "Apellidos");
            DropColumn("dbo.AspNetUsers", "Nombre");
        }
    }
}
