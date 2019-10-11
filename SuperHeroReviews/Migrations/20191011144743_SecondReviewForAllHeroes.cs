using Microsoft.EntityFrameworkCore.Migrations;

namespace SuperHeroReviews.Migrations
{
    public partial class SecondReviewForAllHeroes : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.UpdateData(
                table: "Review",
                keyColumn: "ID",
                keyValue: 22,
                column: "HeroModelID",
                value: 1);

            migrationBuilder.InsertData(
                table: "Review",
                columns: new[] { "ID", "HeroModelID", "Rating", "Review", "ReviewDate", "ReviewerName" },
                values: new object[,]
                {
                    { 40, 19, 5, "This character is awesome.", "10/10/2019", "Steve" },
                    { 39, 18, 5, "This character is awesome as heck.", "10/10/2019", "Steve" },
                    { 38, 17, 5, "This character is awesome as heck.", "10/10/2019", "Steve" },
                    { 37, 16, 5, "This character is awesome as heck.", "10/10/2019", "Steve" },
                    { 36, 15, 5, "This character is awesome as heck.", "10/10/2019", "Steve" },
                    { 35, 14, 5, "This character is awesome as heck.", "10/10/2019", "Steve" },
                    { 34, 13, 5, "This character is awesome as heck.", "10/10/2019", "Steve" },
                    { 33, 12, 5, "This character is awesome as heck.", "10/10/2019", "Steve" },
                    { 41, 20, 5, "This character is awesome as heck.", "10/10/2019", "Steve" },
                    { 32, 11, 5, "This character is awesome as heck.", "10/10/2019", "Steve" },
                    { 30, 9, 5, "This character is awesome as heck.", "10/10/2019", "Steve" },
                    { 29, 8, 5, "This character is awesome as heck.", "10/10/2019", "Steve" },
                    { 28, 7, 5, "This character is awesome as heck.", "10/10/2019", "Steve" },
                    { 27, 6, 5, "This character is awesome as heck.", "10/10/2019", "Steve" },
                    { 26, 5, 5, "This character is awesome as heck.", "10/10/2019", "Steve" },
                    { 25, 4, 5, "This character is awesome as heck.", "10/10/2019", "Steve" },
                    { 24, 3, 5, "This character is awesome as heck.", "10/10/2019", "Steve" },
                    { 23, 2, 5, "This character is awesome for real.", "10/10/2019", "Steve" },
                    { 31, 10, 5, "This character is awesome as heck.", "10/10/2019", "Steve" },
                    { 42, 21, 5, "This character is awesome as heck.", "10/10/2019", "Steve" }
                });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "Review",
                keyColumn: "ID",
                keyValue: 23);

            migrationBuilder.DeleteData(
                table: "Review",
                keyColumn: "ID",
                keyValue: 24);

            migrationBuilder.DeleteData(
                table: "Review",
                keyColumn: "ID",
                keyValue: 25);

            migrationBuilder.DeleteData(
                table: "Review",
                keyColumn: "ID",
                keyValue: 26);

            migrationBuilder.DeleteData(
                table: "Review",
                keyColumn: "ID",
                keyValue: 27);

            migrationBuilder.DeleteData(
                table: "Review",
                keyColumn: "ID",
                keyValue: 28);

            migrationBuilder.DeleteData(
                table: "Review",
                keyColumn: "ID",
                keyValue: 29);

            migrationBuilder.DeleteData(
                table: "Review",
                keyColumn: "ID",
                keyValue: 30);

            migrationBuilder.DeleteData(
                table: "Review",
                keyColumn: "ID",
                keyValue: 31);

            migrationBuilder.DeleteData(
                table: "Review",
                keyColumn: "ID",
                keyValue: 32);

            migrationBuilder.DeleteData(
                table: "Review",
                keyColumn: "ID",
                keyValue: 33);

            migrationBuilder.DeleteData(
                table: "Review",
                keyColumn: "ID",
                keyValue: 34);

            migrationBuilder.DeleteData(
                table: "Review",
                keyColumn: "ID",
                keyValue: 35);

            migrationBuilder.DeleteData(
                table: "Review",
                keyColumn: "ID",
                keyValue: 36);

            migrationBuilder.DeleteData(
                table: "Review",
                keyColumn: "ID",
                keyValue: 37);

            migrationBuilder.DeleteData(
                table: "Review",
                keyColumn: "ID",
                keyValue: 38);

            migrationBuilder.DeleteData(
                table: "Review",
                keyColumn: "ID",
                keyValue: 39);

            migrationBuilder.DeleteData(
                table: "Review",
                keyColumn: "ID",
                keyValue: 40);

            migrationBuilder.DeleteData(
                table: "Review",
                keyColumn: "ID",
                keyValue: 41);

            migrationBuilder.DeleteData(
                table: "Review",
                keyColumn: "ID",
                keyValue: 42);

            migrationBuilder.UpdateData(
                table: "Review",
                keyColumn: "ID",
                keyValue: 22,
                column: "HeroModelID",
                value: 4);
        }
    }
}
