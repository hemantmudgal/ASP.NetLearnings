namespace Dummy.Migrations
{
    using System.Data.Entity.Migrations;

    public partial class AddValuesInBrithDate : DbMigration
    {
        public override void Up()
        {
            Sql("UPDATE Customers SET Birthdate = '12/30/22' WHERE Id = 1");
        }

        public override void Down()
        {
        }
    }
}
