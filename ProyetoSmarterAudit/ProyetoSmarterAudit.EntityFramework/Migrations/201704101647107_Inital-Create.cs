namespace ProyetoSmarterAudit.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class InitalCreate : DbMigration
    {
        public override void Up()
        {
            CreateTable(
                "dbo.TblAuditoria",
                c => new
                {
                    Id = c.Long(nullable: false, identity: true),
                    UserID = c.String(nullable: false, maxLength: 150),
                    FechaCambio = c.DateTime(nullable: false),
                    NombreTabla = c.String(nullable: false, maxLength: 200),
                    TipoEvento = c.String(nullable: false, maxLength: 50),
                    NombreColumnas = c.String(nullable: false, maxLength: 500),
                    ValorAnterior = c.String(maxLength: 500),
                    ValorActual = c.String(maxLength: 500)
                },
                annotations: null)
                .PrimaryKey(t => t.Id)
                .Index(t => t.UserID);
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
            DropTable("dbo.TblAuditoria");
            DropTable("dbo.cCuentaBancarias");
        }

    }
        
        
}
