namespace MyEntityTest.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class newperson : DbMigration
    {
        public override void Up()
        {
            AddColumn("dbo.People", "Telefone", c => c.String(unicode: false));
            AddColumn("dbo.People", "Email", c => c.String(unicode: false));
            AddColumn("dbo.People", "Cpf", c => c.String(unicode: false));
        }
        
        public override void Down()
        {
            DropColumn("dbo.People", "Cpf");
            DropColumn("dbo.People", "Email");
            DropColumn("dbo.People", "Telefone");
        }
    }
}
