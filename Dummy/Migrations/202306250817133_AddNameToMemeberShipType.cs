﻿namespace Dummy.Migrations
{
    using System.Data.Entity.Migrations;

    public partial class AddNameToMemeberShipType : DbMigration
    {
        public override void Up()
        {
            AddColumn("dbo.MembershipTypes", "Name", c => c.String(nullable: false));
        }

        public override void Down()
        {
            DropColumn("dbo.MembershipTypes", "Name");
        }
    }
}
