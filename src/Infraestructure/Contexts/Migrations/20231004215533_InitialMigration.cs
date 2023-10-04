using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace GoldenPaths.Infraestructure.Contexts.Migrations
{
    /// <inheritdoc />
    public partial class InitialMigration : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Address",
                columns: table => new
                {
                    Id = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    PostalCode = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    StreetName = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    StreetNumber = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Neighborhood = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    City = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Region = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Country = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Phone = table.Column<string>(type: "nvarchar(max)", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Address", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "DemandStatus",
                columns: table => new
                {
                    Id = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    Description = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Name = table.Column<string>(type: "nvarchar(max)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_DemandStatus", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "DemandType",
                columns: table => new
                {
                    Id = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    Description = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Name = table.Column<string>(type: "nvarchar(max)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_DemandType", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "User",
                columns: table => new
                {
                    Id = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    Name = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Email = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Password = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    BirthDay = table.Column<DateTime>(type: "datetime2", nullable: false),
                    RegisterDate = table.Column<DateTime>(type: "datetime2", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_User", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "Place",
                columns: table => new
                {
                    Id = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    Name = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Description = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Latitude = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Longitude = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    AddressId = table.Column<Guid>(type: "uniqueidentifier", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Place", x => x.Id);
                    table.ForeignKey(
                        name: "FK_Place_Address_AddressId",
                        column: x => x.AddressId,
                        principalTable: "Address",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "Demand",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Descrption = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    MyProperty = table.Column<int>(type: "int", nullable: false),
                    RegisterDate = table.Column<DateTime>(type: "datetime2", nullable: false),
                    SolutionDate = table.Column<DateTime>(type: "datetime2", nullable: true),
                    PlaceId = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    DemandTypeId = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    DemandStatusId = table.Column<Guid>(type: "uniqueidentifier", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Demand", x => x.Id);
                    table.ForeignKey(
                        name: "FK_Demand_DemandStatus_DemandStatusId",
                        column: x => x.DemandStatusId,
                        principalTable: "DemandStatus",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_Demand_DemandType_DemandTypeId",
                        column: x => x.DemandTypeId,
                        principalTable: "DemandType",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_Demand_Place_PlaceId",
                        column: x => x.PlaceId,
                        principalTable: "Place",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "DemandUser",
                columns: table => new
                {
                    DemandsId = table.Column<int>(type: "int", nullable: false),
                    UsersId = table.Column<Guid>(type: "uniqueidentifier", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_DemandUser", x => new { x.DemandsId, x.UsersId });
                    table.ForeignKey(
                        name: "FK_DemandUser_Demand_DemandsId",
                        column: x => x.DemandsId,
                        principalTable: "Demand",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_DemandUser_User_UsersId",
                        column: x => x.UsersId,
                        principalTable: "User",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateIndex(
                name: "IX_Demand_DemandStatusId",
                table: "Demand",
                column: "DemandStatusId");

            migrationBuilder.CreateIndex(
                name: "IX_Demand_DemandTypeId",
                table: "Demand",
                column: "DemandTypeId");

            migrationBuilder.CreateIndex(
                name: "IX_Demand_PlaceId",
                table: "Demand",
                column: "PlaceId",
                unique: true);

            migrationBuilder.CreateIndex(
                name: "IX_DemandUser_UsersId",
                table: "DemandUser",
                column: "UsersId");

            migrationBuilder.CreateIndex(
                name: "IX_Place_AddressId",
                table: "Place",
                column: "AddressId",
                unique: true);
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "DemandUser");

            migrationBuilder.DropTable(
                name: "Demand");

            migrationBuilder.DropTable(
                name: "User");

            migrationBuilder.DropTable(
                name: "DemandStatus");

            migrationBuilder.DropTable(
                name: "DemandType");

            migrationBuilder.DropTable(
                name: "Place");

            migrationBuilder.DropTable(
                name: "Address");
        }
    }
}
