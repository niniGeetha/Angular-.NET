using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace StreamingServicesAPI.Migrations
{
    /// <inheritdoc />
    public partial class streaming_service_studio_new : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "StreamingService",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    ShortName = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    LongName = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    SubscriptionPrice = table.Column<float>(type: "real", nullable: false),
                    CurrentRevenue = table.Column<double>(type: "float", nullable: false),
                    PreviousRevenue = table.Column<double>(type: "float", nullable: false),
                    TotalRevenue = table.Column<double>(type: "float", nullable: false),
                    LicensingCost = table.Column<double>(type: "float", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_StreamingService", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "Studio",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    ShortName = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    LongName = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    CurrentRevenue = table.Column<double>(type: "float", nullable: false),
                    PreviousRevenue = table.Column<double>(type: "float", nullable: false),
                    TotalRevenue = table.Column<double>(type: "float", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Studio", x => x.Id);
                });
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "StreamingService");

            migrationBuilder.DropTable(
                name: "Studio");
        }
    }
}
