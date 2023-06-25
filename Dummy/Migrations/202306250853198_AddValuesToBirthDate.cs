namespace Dummy.Migrations
{
    using System.Data.Entity.Migrations;

    public partial class AddValuesToBirthDate : DbMigration
    {
        public override void Up()
        {
            Sql("UPDATE Customers SET BirthDate = '14/09/2001' WHERE Id = 1");
        }

        public override void Down()
        {
        }
    }
}
