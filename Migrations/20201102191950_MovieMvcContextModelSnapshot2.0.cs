using Microsoft.EntityFrameworkCore.Migrations;

namespace MovieMVC.Migrations
{
    public partial class MovieMvcContextModelSnapshot20 : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {

            migrationBuilder.Sql(
                "CREATE TABLE New_Movie (" +
                "PK_Movie INTEGER PRIMARY KEY, " +
                "MovieId INTEGER DEFAULT 0, " +
                "Title TEXT, " +
                "Genre TEXT, " +
                "ReleaseDate TEXT, " +
                "MovieTheaters TEXT)");

            migrationBuilder.Sql("INSERT INTO New_Movie (PK_Movie, Title, Genre, ReleaseDate, MovieId) SELECT * FROM Movie");

            migrationBuilder.Sql("DROP TABLE MOVIE");
            migrationBuilder.Sql("ALTER TABLE New_Movie RENAME TO Movie");

            //migrationBuilder.DropPrimaryKey(
            //    name: "PK_Movie",
            //    table: "Movie");

            //migrationBuilder.DropColumn(
            //    name: "Id",
            //    table: "Movie");

            //migrationBuilder.DropColumn(
            //    name: "Price",
            //    table: "Movie");

            //migrationBuilder.AddColumn<int>(
            //    name: "MovieId",
            //    table: "Movie",
            //    nullable: false,
            //    defaultValue: 0)
            //    .Annotation("Sqlite:Autoincrement", true);

            //migrationBuilder.AddPrimaryKey(
            //    name: "PK_Movie",
            //    table: "Movie",
            //    column: "MovieId");

            migrationBuilder.CreateTable(
                name: "Theaters",
                columns: table => new
                {
                    TheaterId = table.Column<int>(nullable: false)
                        .Annotation("Sqlite:Autoincrement", true),
                    Title = table.Column<string>(nullable: true),
                    Location = table.Column<string>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Theaters", x => x.TheaterId);
                });

            migrationBuilder.CreateTable(
                name: "MovieTheaters",
                columns: table => new
                {
                    MovieId = table.Column<int>(nullable: false),
                    TheaterId = table.Column<int>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_MovieTheaters", x => new { x.MovieId, x.TheaterId });
                    table.ForeignKey(
                        name: "FK_MovieTheaters_Movie_MovieId",
                        column: x => x.MovieId,
                        principalTable: "Movie",
                        principalColumn: "MovieId",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_MovieTheaters_Theaters_TheaterId",
                        column: x => x.TheaterId,
                        principalTable: "Theaters",
                        principalColumn: "TheaterId",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateIndex(
                name: "IX_MovieTheaters_TheaterId",
                table: "MovieTheaters",
                column: "TheaterId");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {

            migrationBuilder.Sql(
                "CREATE TABLE New_Movie (" +
                "Id INTEGER DEFAULT 0, " +
                "Title TEXT, " +
                "Genre TEXT, " +
                "ReleaseDate NUMERIC, " +
                "Price TEXT NOT NULL DEFAULT 0)");

            migrationBuilder.Sql("INSERT INTO New_Movie SELECT * FROM Movie");
            migrationBuilder.Sql("DROP MOVIE");
            migrationBuilder.Sql("ALTER TABLE New_Movie RENAME_TO Movie");

            migrationBuilder.DropTable(
                name: "MovieTheaters");

            migrationBuilder.DropTable(
                name: "Theaters");

            //migrationBuilder.DropPrimaryKey(
            //    name: "PK_Movie",
            //    table: "Movie");

            //migrationBuilder.DropColumn(
            //    name: "MovieId",
            //    table: "Movie");

            //migrationBuilder.AddColumn<int>(
            //    name: "Id",
            //    table: "Movie",
            //    type: "INTEGER",
            //    nullable: false,
            //    defaultValue: 0)
            //    .Annotation("Sqlite:Autoincrement", true);

            //migrationBuilder.AddColumn<decimal>(
            //    name: "Price",
            //    table: "Movie",
            //    type: "TEXT",
            //    nullable: false,
            //    defaultValue: 0m);

            migrationBuilder.AddPrimaryKey(
                name: "PK_Movie",
                table: "Movie",
                column: "Id");
        }
    }
}
