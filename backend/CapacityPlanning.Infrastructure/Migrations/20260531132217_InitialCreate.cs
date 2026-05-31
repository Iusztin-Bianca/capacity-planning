using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace CapacityPlanning.Infrastructure.Migrations
{
    public partial class InitialCreate : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Initiatives",
                columns: table => new
                {
                    Id = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    Name = table.Column<string>(type: "nvarchar(200)", maxLength: 200, nullable: false),
                    Description = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Status = table.Column<int>(type: "int", nullable: false),
                    Priority = table.Column<int>(type: "int", nullable: false),
                    TargetDate = table.Column<DateTime>(type: "datetime2", nullable: false),
                    CreatedAt = table.Column<DateTime>(type: "datetime2", nullable: false),
                    UpdatedAt = table.Column<DateTime>(type: "datetime2", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Initiatives", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "Teams",
                columns: table => new
                {
                    Id = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    Name = table.Column<string>(type: "nvarchar(100)", maxLength: 100, nullable: false),
                    OverheadPercentage = table.Column<int>(type: "int", nullable: false),
                    CreatedAt = table.Column<DateTime>(type: "datetime2", nullable: false),
                    UpdatedAt = table.Column<DateTime>(type: "datetime2", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Teams", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "Epics",
                columns: table => new
                {
                    Id = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    Name = table.Column<string>(type: "nvarchar(200)", maxLength: 200, nullable: false),
                    Description = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    InitiativeId = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    TeamId = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    EstimatedDays = table.Column<int>(type: "int", nullable: false),
                    StartDate = table.Column<DateTime>(type: "datetime2", nullable: false),
                    DueDate = table.Column<DateTime>(type: "datetime2", nullable: false),
                    Status = table.Column<int>(type: "int", nullable: false),
                    CreatedAt = table.Column<DateTime>(type: "datetime2", nullable: false),
                    UpdatedAt = table.Column<DateTime>(type: "datetime2", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Epics", x => x.Id);
                    table.ForeignKey(
                        name: "FK_Epics_Initiatives_InitiativeId",
                        column: x => x.InitiativeId,
                        principalTable: "Initiatives",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_Epics_Teams_TeamId",
                        column: x => x.TeamId,
                        principalTable: "Teams",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "Persons",
                columns: table => new
                {
                    Id = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    TeamId = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    Name = table.Column<string>(type: "nvarchar(100)", maxLength: 100, nullable: false),
                    Role = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    AvailabilityPercentage = table.Column<int>(type: "int", nullable: false),
                    CreatedAt = table.Column<DateTime>(type: "datetime2", nullable: false),
                    UpdatedAt = table.Column<DateTime>(type: "datetime2", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Persons", x => x.Id);
                    table.ForeignKey(
                        name: "FK_Persons_Teams_TeamId",
                        column: x => x.TeamId,
                        principalTable: "Teams",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.InsertData(
                table: "Initiatives",
                columns: new[] { "Id", "CreatedAt", "Description", "Name", "Priority", "Status", "TargetDate", "UpdatedAt" },
                values: new object[,]
                {
                    { new Guid("22222222-0000-0000-0000-000000000001"), new DateTime(2026, 5, 31, 13, 22, 16, 933, DateTimeKind.Utc).AddTicks(1040), "Rebuild customer-facing portal", "New Customer Portal", 2, 1, new DateTime(2025, 12, 31, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2026, 5, 31, 13, 22, 16, 933, DateTimeKind.Utc).AddTicks(1040) },
                    { new Guid("22222222-0000-0000-0000-000000000002"), new DateTime(2026, 5, 31, 13, 22, 16, 933, DateTimeKind.Utc).AddTicks(1043), "Reduce p99 latency by 50%", "Performance Overhaul", 3, 0, new DateTime(2025, 9, 30, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2026, 5, 31, 13, 22, 16, 933, DateTimeKind.Utc).AddTicks(1043) },
                    { new Guid("22222222-0000-0000-0000-000000000003"), new DateTime(2026, 5, 31, 13, 22, 16, 933, DateTimeKind.Utc).AddTicks(1046), "First native mobile app", "Mobile App Launch", 1, 0, new DateTime(2026, 3, 31, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2026, 5, 31, 13, 22, 16, 933, DateTimeKind.Utc).AddTicks(1046) }
                });

            migrationBuilder.InsertData(
                table: "Teams",
                columns: new[] { "Id", "CreatedAt", "Name", "OverheadPercentage", "UpdatedAt" },
                values: new object[,]
                {
                    { new Guid("11111111-0000-0000-0000-000000000001"), new DateTime(2026, 5, 31, 13, 22, 16, 933, DateTimeKind.Utc).AddTicks(3327), "Platform", 25, new DateTime(2026, 5, 31, 13, 22, 16, 933, DateTimeKind.Utc).AddTicks(3327) },
                    { new Guid("11111111-0000-0000-0000-000000000002"), new DateTime(2026, 5, 31, 13, 22, 16, 933, DateTimeKind.Utc).AddTicks(3330), "Frontend", 20, new DateTime(2026, 5, 31, 13, 22, 16, 933, DateTimeKind.Utc).AddTicks(3330) },
                    { new Guid("11111111-0000-0000-0000-000000000003"), new DateTime(2026, 5, 31, 13, 22, 16, 933, DateTimeKind.Utc).AddTicks(3332), "Backend", 20, new DateTime(2026, 5, 31, 13, 22, 16, 933, DateTimeKind.Utc).AddTicks(3332) },
                    { new Guid("11111111-0000-0000-0000-000000000004"), new DateTime(2026, 5, 31, 13, 22, 16, 933, DateTimeKind.Utc).AddTicks(3334), "Mobile", 15, new DateTime(2026, 5, 31, 13, 22, 16, 933, DateTimeKind.Utc).AddTicks(3335) }
                });

            migrationBuilder.InsertData(
                table: "Epics",
                columns: new[] { "Id", "CreatedAt", "Description", "DueDate", "EstimatedDays", "InitiativeId", "Name", "StartDate", "Status", "TeamId", "UpdatedAt" },
                values: new object[,]
                {
                    { new Guid("1bc1c608-4b3f-4923-a50e-839544fc3367"), new DateTime(2026, 5, 31, 13, 22, 16, 932, DateTimeKind.Utc).AddTicks(9556), null, new DateTime(2025, 12, 31, 0, 0, 0, 0, DateTimeKind.Unspecified), 60, new Guid("22222222-0000-0000-0000-000000000003"), "iOS App MVP", new DateTime(2025, 6, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), 0, new Guid("11111111-0000-0000-0000-000000000004"), new DateTime(2026, 5, 31, 13, 22, 16, 932, DateTimeKind.Utc).AddTicks(9556) },
                    { new Guid("335641b8-369f-4b2d-b2ce-e2885a564a4b"), new DateTime(2026, 5, 31, 13, 22, 16, 932, DateTimeKind.Utc).AddTicks(9561), null, new DateTime(2025, 11, 30, 0, 0, 0, 0, DateTimeKind.Unspecified), 15, new Guid("22222222-0000-0000-0000-000000000003"), "Push Notifications", new DateTime(2025, 9, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), 0, new Guid("11111111-0000-0000-0000-000000000001"), new DateTime(2026, 5, 31, 13, 22, 16, 932, DateTimeKind.Utc).AddTicks(9561) },
                    { new Guid("3e586e3d-b8ac-4f85-a422-93d5037bc243"), new DateTime(2026, 5, 31, 13, 22, 16, 932, DateTimeKind.Utc).AddTicks(9550), null, new DateTime(2025, 2, 28, 0, 0, 0, 0, DateTimeKind.Unspecified), 20, new Guid("22222222-0000-0000-0000-000000000002"), "API Gateway Setup", new DateTime(2025, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), 1, new Guid("11111111-0000-0000-0000-000000000001"), new DateTime(2026, 5, 31, 13, 22, 16, 932, DateTimeKind.Utc).AddTicks(9550) },
                    { new Guid("5bb4d4e1-39f5-4e36-8863-ab73d196dc7d"), new DateTime(2026, 5, 31, 13, 22, 16, 932, DateTimeKind.Utc).AddTicks(9546), null, new DateTime(2025, 5, 31, 0, 0, 0, 0, DateTimeKind.Unspecified), 40, new Guid("22222222-0000-0000-0000-000000000001"), "Portal UI Redesign", new DateTime(2025, 2, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), 0, new Guid("11111111-0000-0000-0000-000000000002"), new DateTime(2026, 5, 31, 13, 22, 16, 932, DateTimeKind.Utc).AddTicks(9546) },
                    { new Guid("d6cc8a42-3f3f-4a7f-9f56-759cd9bb2f0d"), new DateTime(2026, 5, 31, 13, 22, 16, 932, DateTimeKind.Utc).AddTicks(9531), null, new DateTime(2025, 3, 31, 0, 0, 0, 0, DateTimeKind.Unspecified), 30, new Guid("22222222-0000-0000-0000-000000000001"), "Auth Service Rewrite", new DateTime(2025, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), 1, new Guid("11111111-0000-0000-0000-000000000003"), new DateTime(2026, 5, 31, 13, 22, 16, 932, DateTimeKind.Utc).AddTicks(9531) },
                    { new Guid("eeabf2a7-a267-40de-b8c2-98f5ff310121"), new DateTime(2026, 5, 31, 13, 22, 16, 932, DateTimeKind.Utc).AddTicks(9553), null, new DateTime(2025, 4, 30, 0, 0, 0, 0, DateTimeKind.Unspecified), 25, new Guid("22222222-0000-0000-0000-000000000002"), "DB Query Optimization", new DateTime(2025, 3, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), 0, new Guid("11111111-0000-0000-0000-000000000003"), new DateTime(2026, 5, 31, 13, 22, 16, 932, DateTimeKind.Utc).AddTicks(9553) }
                });

            migrationBuilder.InsertData(
                table: "Persons",
                columns: new[] { "Id", "AvailabilityPercentage", "CreatedAt", "Name", "Role", "TeamId", "UpdatedAt" },
                values: new object[,]
                {
                    { new Guid("24301970-e765-41cc-a410-0c856e2c02c8"), 100, new DateTime(2026, 5, 31, 13, 22, 16, 933, DateTimeKind.Utc).AddTicks(1380), "Alice", "Tech Lead", new Guid("11111111-0000-0000-0000-000000000001"), new DateTime(2026, 5, 31, 13, 22, 16, 933, DateTimeKind.Utc).AddTicks(1380) },
                    { new Guid("3e66925e-ee36-446c-a5b4-b69de52fae65"), 100, new DateTime(2026, 5, 31, 13, 22, 16, 933, DateTimeKind.Utc).AddTicks(1398), "Frank", "Tech Lead", new Guid("11111111-0000-0000-0000-000000000003"), new DateTime(2026, 5, 31, 13, 22, 16, 933, DateTimeKind.Utc).AddTicks(1398) },
                    { new Guid("4a4042da-4b6f-41f6-8431-1a5fca22d8a5"), 100, new DateTime(2026, 5, 31, 13, 22, 16, 933, DateTimeKind.Utc).AddTicks(1393), "Dan", "Tech Lead", new Guid("11111111-0000-0000-0000-000000000002"), new DateTime(2026, 5, 31, 13, 22, 16, 933, DateTimeKind.Utc).AddTicks(1393) },
                    { new Guid("64bd88cf-329f-4914-9f66-d8675051249b"), 100, new DateTime(2026, 5, 31, 13, 22, 16, 933, DateTimeKind.Utc).AddTicks(1405), "Henry", "Engineer", new Guid("11111111-0000-0000-0000-000000000003"), new DateTime(2026, 5, 31, 13, 22, 16, 933, DateTimeKind.Utc).AddTicks(1405) },
                    { new Guid("6c4e4d13-16d6-422c-a46f-00dd876847cd"), 50, new DateTime(2026, 5, 31, 13, 22, 16, 933, DateTimeKind.Utc).AddTicks(1390), "Carol", "Engineer", new Guid("11111111-0000-0000-0000-000000000001"), new DateTime(2026, 5, 31, 13, 22, 16, 933, DateTimeKind.Utc).AddTicks(1391) },
                    { new Guid("771e46ff-c7df-4a8a-9570-59849d6fe26f"), 100, new DateTime(2026, 5, 31, 13, 22, 16, 933, DateTimeKind.Utc).AddTicks(1383), "Bob", "Senior Engineer", new Guid("11111111-0000-0000-0000-000000000001"), new DateTime(2026, 5, 31, 13, 22, 16, 933, DateTimeKind.Utc).AddTicks(1384) },
                    { new Guid("a0288db3-8923-457c-a2b6-85302f3dc156"), 50, new DateTime(2026, 5, 31, 13, 22, 16, 933, DateTimeKind.Utc).AddTicks(1410), "Jack", "Engineer", new Guid("11111111-0000-0000-0000-000000000004"), new DateTime(2026, 5, 31, 13, 22, 16, 933, DateTimeKind.Utc).AddTicks(1410) },
                    { new Guid("a0ee4a96-f88d-46fb-974c-92ad09360a70"), 100, new DateTime(2026, 5, 31, 13, 22, 16, 933, DateTimeKind.Utc).AddTicks(1402), "Grace", "Senior Engineer", new Guid("11111111-0000-0000-0000-000000000003"), new DateTime(2026, 5, 31, 13, 22, 16, 933, DateTimeKind.Utc).AddTicks(1403) },
                    { new Guid("cfa69d8c-cf8d-4a04-99de-1966b4853a65"), 100, new DateTime(2026, 5, 31, 13, 22, 16, 933, DateTimeKind.Utc).AddTicks(1407), "Iris", "Tech Lead", new Guid("11111111-0000-0000-0000-000000000004"), new DateTime(2026, 5, 31, 13, 22, 16, 933, DateTimeKind.Utc).AddTicks(1407) },
                    { new Guid("e04017ff-c575-4d5f-ae59-ab4a5b557e49"), 100, new DateTime(2026, 5, 31, 13, 22, 16, 933, DateTimeKind.Utc).AddTicks(1396), "Eva", "Engineer", new Guid("11111111-0000-0000-0000-000000000002"), new DateTime(2026, 5, 31, 13, 22, 16, 933, DateTimeKind.Utc).AddTicks(1396) }
                });

            migrationBuilder.CreateIndex(
                name: "IX_Epics_InitiativeId",
                table: "Epics",
                column: "InitiativeId");

            migrationBuilder.CreateIndex(
                name: "IX_Epics_TeamId",
                table: "Epics",
                column: "TeamId");

            migrationBuilder.CreateIndex(
                name: "IX_Persons_TeamId",
                table: "Persons",
                column: "TeamId");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Epics");

            migrationBuilder.DropTable(
                name: "Persons");

            migrationBuilder.DropTable(
                name: "Initiatives");

            migrationBuilder.DropTable(
                name: "Teams");
        }
    }
}
