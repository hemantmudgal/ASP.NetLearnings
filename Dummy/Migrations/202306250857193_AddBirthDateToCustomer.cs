namespace Dummy.Migrations
{
    using System.Data.Entity.Migrations;

    public partial class AddBirthDateToCustomer : DbMigration
    {
        public override void Up()
        {
            DropColumn("dbo.Customers", "Birthdate");
        }

        public override void Down()
        {
        }
    }
}
