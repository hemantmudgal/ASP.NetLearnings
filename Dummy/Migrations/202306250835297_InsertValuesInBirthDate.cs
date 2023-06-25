namespace Dummy.Migrations
{
    using System.Data.Entity.Migrations;

    public partial class InsertValuesInBirthDate : DbMigration
    {
        public override void Up()
        {
            Sql("UPDATE Customers SET BirthDate = '14Jan' where id = 1");
        }

        public override void Down()
        {
        }
    }
}
