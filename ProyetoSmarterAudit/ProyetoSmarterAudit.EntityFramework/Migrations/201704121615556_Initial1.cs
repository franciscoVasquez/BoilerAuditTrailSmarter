namespace ProyetoSmarterAudit.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class Initial1 : DbMigration
    {
        public override void Up()
        {
            RenameTable(name: "dbo.cAuditorias", newName: "TblAuditorias");
        }
        
        public override void Down()
        {
            RenameTable(name: "dbo.TblAuditorias", newName: "cAuditorias");
        }
    }
}
