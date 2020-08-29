using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace ATDApp.WebSite.Migrations
{
    public partial class AddReqLocToDb : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Location",
                columns: table => new
                {
                    LocationID = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    LocationName = table.Column<string>(nullable: true),
                    Intersection = table.Column<string>(nullable: true),
                    Address = table.Column<string>(nullable: true),
                    City = table.Column<string>(nullable: true),
                    Zip = table.Column<double>(nullable: false),
                    CouncilDistrict = table.Column<double>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Location", x => x.LocationID);
                });

            migrationBuilder.CreateTable(
                name: "Request",
                columns: table => new
                {
                    RequestId = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Field1 = table.Column<int>(nullable: false),
                    LocationID = table.Column<int>(nullable: false),
                    RequestDate = table.Column<DateTime>(nullable: false),
                    RequestType = table.Column<string>(nullable: true),
                    FirstName = table.Column<string>(nullable: true),
                    LastName = table.Column<string>(nullable: true),
                    Phone = table.Column<string>(nullable: true),
                    Email = table.Column<string>(nullable: false),
                    NumberRacksRequested = table.Column<int>(nullable: false),
                    NumberRacksMarked = table.Column<int>(nullable: false),
                    Status = table.Column<string>(nullable: true),
                    PreliminaryCheck = table.Column<DateTime>(nullable: false),
                    Marked = table.Column<DateTime>(nullable: false),
                    Fulfilled = table.Column<DateTime>(nullable: false),
                    DeniedRequest = table.Column<DateTime>(nullable: false),
                    Comments = table.Column<string>(nullable: true),
                    Priority = table.Column<string>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Request", x => x.RequestId);
                });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Location");

            migrationBuilder.DropTable(
                name: "Request");
        }
    }
}
