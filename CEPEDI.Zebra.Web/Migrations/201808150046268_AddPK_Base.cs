namespace CEPEDI.Zebra.Web.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class AddPK_Base : DbMigration
    {
        public override void Up()
        {
            AddColumn("dbo.Relatorios", "Arquivo", c => c.String());
            DropColumn("dbo.Relatorios", "Arquivo");
        }
        
        public override void Down()
        {
            AddColumn("dbo.Relatorios", "Arquivo", c => c.String());
            DropColumn("dbo.Relatorios", "Arquivo");
        }
    }
}
