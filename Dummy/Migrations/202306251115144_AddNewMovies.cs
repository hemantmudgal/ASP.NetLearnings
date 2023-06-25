namespace Dummy.Migrations
{
    using System.Data.Entity.Migrations;

    public partial class AddNewMovies : DbMigration
    {
        public override void Up()
        {
            Sql("INSERT INTO Movies (Name, GenreId, DateAdded, ReleaseDate, NumberInStock) VALUES ('Movie 2',2,'09-14-01','09-15-01',10)");
            Sql("INSERT INTO Movies (Name, GenreId, DateAdded, ReleaseDate, NumberInStock) VALUES ('Movie 3',3,'09-14-01','09-15-01',10)");
            Sql("INSERT INTO Movies (Name, GenreId, DateAdded, ReleaseDate, NumberInStock) VALUES ('Movie 4',5,'09-14-01','09-15-01',10)");
        }

        public override void Down()
        {
        }
    }
}
