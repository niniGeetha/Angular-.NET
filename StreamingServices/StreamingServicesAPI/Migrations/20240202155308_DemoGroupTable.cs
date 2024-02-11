using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace StreamingServicesAPI.Migrations
{
    /// <inheritdoc />
    public partial class DemoGroupTable : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "DemographicGroup",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    ShortName = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    LongName = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    AccountNum = table.Column<int>(type: "int", nullable: false),
                    CurrentSpending = table.Column<double>(type: "float", nullable: false),
                    PreviousSpending = table.Column<double>(type: "float", nullable: false),
                    TotalSpending = table.Column<double>(type: "float", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_DemographicGroup", x => x.Id);
                });
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "DemographicGroup");
        }
    }
}
