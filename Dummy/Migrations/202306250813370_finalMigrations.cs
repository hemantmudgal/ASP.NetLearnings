namespace Dummy.Migrations
{
    using System.Data.Entity.Migrations;

    public partial class finalMigrations : DbMigration
    {
        public override void Up()
        {
            DropColumn("dbo.MembershipTypes", "Name");
        }

        public override void Down()
        {
            DropColumn("dbo.MembershipTypes", "Name");
        }
    }
}
