using Microsoft.EntityFrameworkCore.Migrations;

namespace SuperHeroReviews.Migrations
{
    public partial class hopethisworks : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<int>(
                name: "HeroModelID",
                table: "Review",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.UpdateData(
                table: "Review",
                keyColumn: "ID",
                keyValue: 1,
                column: "HeroModelID",
                value: 1);

            migrationBuilder.UpdateData(
                table: "Review",
                keyColumn: "ID",
                keyValue: 2,
                column: "HeroModelID",
                value: 2);

            migrationBuilder.UpdateData(
                table: "Review",
                keyColumn: "ID",
                keyValue: 3,
                column: "HeroModelID",
                value: 3);

            migrationBuilder.UpdateData(
                table: "Review",
                keyColumn: "ID",
                keyValue: 4,
                column: "HeroModelID",
                value: 4);

            migrationBuilder.UpdateData(
                table: "Review",
                keyColumn: "ID",
                keyValue: 5,
                column: "HeroModelID",
                value: 5);

            migrationBuilder.UpdateData(
                table: "Review",
                keyColumn: "ID",
                keyValue: 6,
                column: "HeroModelID",
                value: 6);

            migrationBuilder.UpdateData(
                table: "Review",
                keyColumn: "ID",
                keyValue: 7,
                column: "HeroModelID",
                value: 7);

            migrationBuilder.UpdateData(
                table: "Review",
                keyColumn: "ID",
                keyValue: 8,
                column: "HeroModelID",
                value: 8);

            migrationBuilder.UpdateData(
                table: "Review",
                keyColumn: "ID",
                keyValue: 9,
                column: "HeroModelID",
                value: 9);

            migrationBuilder.UpdateData(
                table: "Review",
                keyColumn: "ID",
                keyValue: 10,
                column: "HeroModelID",
                value: 10);

            migrationBuilder.UpdateData(
                table: "Review",
                keyColumn: "ID",
                keyValue: 11,
                column: "HeroModelID",
                value: 11);

            migrationBuilder.UpdateData(
                table: "Review",
                keyColumn: "ID",
                keyValue: 12,
                column: "HeroModelID",
                value: 12);

            migrationBuilder.UpdateData(
                table: "Review",
                keyColumn: "ID",
                keyValue: 13,
                column: "HeroModelID",
                value: 13);

            migrationBuilder.UpdateData(
                table: "Review",
                keyColumn: "ID",
                keyValue: 14,
                column: "HeroModelID",
                value: 14);

            migrationBuilder.UpdateData(
                table: "Review",
                keyColumn: "ID",
                keyValue: 15,
                column: "HeroModelID",
                value: 15);

            migrationBuilder.UpdateData(
                table: "Review",
                keyColumn: "ID",
                keyValue: 16,
                column: "HeroModelID",
                value: 16);

            migrationBuilder.UpdateData(
                table: "Review",
                keyColumn: "ID",
                keyValue: 17,
                column: "HeroModelID",
                value: 17);

            migrationBuilder.UpdateData(
                table: "Review",
                keyColumn: "ID",
                keyValue: 18,
                column: "HeroModelID",
                value: 18);

            migrationBuilder.UpdateData(
                table: "Review",
                keyColumn: "ID",
                keyValue: 19,
                column: "HeroModelID",
                value: 19);

            migrationBuilder.UpdateData(
                table: "Review",
                keyColumn: "ID",
                keyValue: 20,
                column: "HeroModelID",
                value: 20);

            migrationBuilder.UpdateData(
                table: "Review",
                keyColumn: "ID",
                keyValue: 21,
                column: "HeroModelID",
                value: 21);

            migrationBuilder.CreateIndex(
                name: "IX_Review_HeroModelID",
                table: "Review",
                column: "HeroModelID");

            migrationBuilder.AddForeignKey(
                name: "FK_Review_Heroes_HeroModelID",
                table: "Review",
                column: "HeroModelID",
                principalTable: "Heroes",
                principalColumn: "ID",
                onDelete: ReferentialAction.Cascade);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Review_Heroes_HeroModelID",
                table: "Review");

            migrationBuilder.DropIndex(
                name: "IX_Review_HeroModelID",
                table: "Review");

            migrationBuilder.DropColumn(
                name: "HeroModelID",
                table: "Review");
        }
    }
}
