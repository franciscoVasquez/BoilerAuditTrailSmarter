namespace ProyetoSmarterAudit.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class Secondcreate : DbMigration
    {
        public override void Up()
        {
            CreateTable(
                "dbo.cCuentaBancarias",
                c => new
                    {
                        Id = c.Int(nullable: false, identity: true),
                        NroCuenta = c.String(),
                        Banco = c.String(),
                        TipoCuenta = c.String(),
                    })
                .PrimaryKey(t => t.Id);
            
        }
        
        public override void Down()
        {
            DropTable("dbo.cCuentaBancarias");
        }
    }
}
