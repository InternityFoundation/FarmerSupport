using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;

namespace FarmerSupport.Migrations
{
    public partial class myfirststep : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "FarmerModel",
                columns: table => new
                {
                    FarmerId = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn),
                    Sunlight = table.Column<int>(nullable: false),
                    Temperature = table.Column<int>(nullable: false),
                    Humidity = table.Column<int>(nullable: false),
                    ElectricalConducitvity = table.Column<int>(nullable: false),
                    Rainfall = table.Column<int>(nullable: false),
                    Past3Months = table.Column<string>(nullable: true),
                    Next3Months = table.Column<string>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_FarmerModel", x => x.FarmerId);
                });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "FarmerModel");
        }
    }
}
