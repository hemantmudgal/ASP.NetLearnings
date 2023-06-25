namespace Dummy.Migrations
{
    using System.Data.Entity.Migrations;

    public partial class AddMovies : DbMigration
    {
        public override void Up()
        {
            Sql("INSERT INTO Movies (Name, GenreId, DateAdded, ReleaseDate, NumberInStock) VALUES ('Movie 1',4,'09-14-01','09-15-01',10)");
        }

        public override void Down()
        {
        }
    }
}
