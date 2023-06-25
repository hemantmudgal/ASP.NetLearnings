namespace Dummy.Migrations
{
    using System.Data.Entity.Migrations;

    public partial class UpdateBirthDateValue : DbMigration
    {
        public override void Up()
        {
            Sql("UPDATE Customers SET Birthdate = '09/14/01' WHERE Id = 1");
        }

        public override void Down()
        {
        }
    }
}
