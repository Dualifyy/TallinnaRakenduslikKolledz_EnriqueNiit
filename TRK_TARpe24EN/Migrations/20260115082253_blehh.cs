using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace TRK_TARpe24EN.Migrations
{
    /// <inheritdoc />
    public partial class blehh : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.RenameColumn(
                name: "Violation",
                table: "Delinquents",
                newName: "Description");

            migrationBuilder.AddColumn<bool>(
                name: "isStudent",
                table: "Delinquents",
                type: "bit",
                nullable: false,
                defaultValue: false);
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "isStudent",
                table: "Delinquents");

            migrationBuilder.RenameColumn(
                name: "Description",
                table: "Delinquents",
                newName: "Violation");
        }
    }
}
