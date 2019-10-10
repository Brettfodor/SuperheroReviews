using Microsoft.EntityFrameworkCore.Migrations;

namespace SuperHeroReviews.Migrations
{
    public partial class addingMultipleReviews : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.InsertData(
                table: "Review",
                columns: new[] { "ID", "HeroModelID", "Rating", "Review", "ReviewDate", "ReviewerName" },
                values: new object[] { 22, 4, 5, "This character is awesome as heck.", "10/10/2019", "Steve" });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "Review",
                keyColumn: "ID",
                keyValue: 22);
        }
    }
}
