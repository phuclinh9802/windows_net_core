using Microsoft.EntityFrameworkCore.Migrations;
using Pomelo.EntityFrameworkCore.MySql;
namespace practice.Migrations
{
    public partial class Populate : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.Sql("INSERT INTO Movie(Id, Name, Genre, Director) values (uuid(), \"Cars\", \"Cartoon\", \"John Alan Lasseter\")");
            migrationBuilder.Sql("INSERT INTO Movie(Id, Name, Genre, Director) values (uuid(), \"Avengers\", \"Superhero\", \" Joss Whedon\")");


        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {

        }
    }
}
