using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace CodecoolAPI.Data.Migrations
{
    public partial class ChangeReviewFieldName : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.RenameColumn(
                name: "RewievTExt",
                table: "Reviews",
                newName: "RewievText");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.RenameColumn(
                name: "RewievText",
                table: "Reviews",
                newName: "RewievTExt");
        }
    }
}
