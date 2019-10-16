using Microsoft.EntityFrameworkCore.Migrations;

namespace SuperHeroReviews.Migrations
{
    public partial class RenamedTables : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Heroes_Universe_UniverseModelID",
                table: "Heroes");

            migrationBuilder.DropForeignKey(
                name: "FK_Review_Heroes_HeroModelID",
                table: "Review");

            migrationBuilder.DropPrimaryKey(
                name: "PK_Universe",
                table: "Universe");

            migrationBuilder.DropPrimaryKey(
                name: "PK_Review",
                table: "Review");

            migrationBuilder.RenameTable(
                name: "Universe",
                newName: "Universes");

            migrationBuilder.RenameTable(
                name: "Review",
                newName: "Reviews");

            migrationBuilder.RenameIndex(
                name: "IX_Review_HeroModelID",
                table: "Reviews",
                newName: "IX_Reviews_HeroModelID");

            migrationBuilder.AddPrimaryKey(
                name: "PK_Universes",
                table: "Universes",
                column: "ID");

            migrationBuilder.AddPrimaryKey(
                name: "PK_Reviews",
                table: "Reviews",
                column: "ID");

            migrationBuilder.AddForeignKey(
                name: "FK_Heroes_Universes_UniverseModelID",
                table: "Heroes",
                column: "UniverseModelID",
                principalTable: "Universes",
                principalColumn: "ID",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_Reviews_Heroes_HeroModelID",
                table: "Reviews",
                column: "HeroModelID",
                principalTable: "Heroes",
                principalColumn: "ID",
                onDelete: ReferentialAction.Cascade);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Heroes_Universes_UniverseModelID",
                table: "Heroes");

            migrationBuilder.DropForeignKey(
                name: "FK_Reviews_Heroes_HeroModelID",
                table: "Reviews");

            migrationBuilder.DropPrimaryKey(
                name: "PK_Universes",
                table: "Universes");

            migrationBuilder.DropPrimaryKey(
                name: "PK_Reviews",
                table: "Reviews");

            migrationBuilder.RenameTable(
                name: "Universes",
                newName: "Universe");

            migrationBuilder.RenameTable(
                name: "Reviews",
                newName: "Review");

            migrationBuilder.RenameIndex(
                name: "IX_Reviews_HeroModelID",
                table: "Review",
                newName: "IX_Review_HeroModelID");

            migrationBuilder.AddPrimaryKey(
                name: "PK_Universe",
                table: "Universe",
                column: "ID");

            migrationBuilder.AddPrimaryKey(
                name: "PK_Review",
                table: "Review",
                column: "ID");

            migrationBuilder.AddForeignKey(
                name: "FK_Heroes_Universe_UniverseModelID",
                table: "Heroes",
                column: "UniverseModelID",
                principalTable: "Universe",
                principalColumn: "ID",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_Review_Heroes_HeroModelID",
                table: "Review",
                column: "HeroModelID",
                principalTable: "Heroes",
                principalColumn: "ID",
                onDelete: ReferentialAction.Cascade);
        }
    }
}
