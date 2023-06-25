namespace Dummy.Migrations
{
    using System.Data.Entity.Migrations;

    public partial class AddNewTables : DbMigration
    {
        public override void Up()
        {
            Sql("INSERT INTO Movies (Id, Name, GenreId, DateAdded, ReleaseDate, NumberInStock) VALUES (10,'Movie 5',5, '2008-11-11','2008-11-11',7)");
        }

        public override void Down()
        {
        }
    }
}
