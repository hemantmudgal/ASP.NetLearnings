namespace Dummy.Migrations
{
    using System.Data.Entity.Migrations;

    public partial class AddBirthDateToCustomer1 : DbMigration
    {
        public override void Up()
        {
            AddColumn("dbo.Customers", "Birthdate", c => c.DateTime());
        }

        public override void Down()
        {
            DropColumn("dbo.Customers", "Birthdate");
        }
    }
}
