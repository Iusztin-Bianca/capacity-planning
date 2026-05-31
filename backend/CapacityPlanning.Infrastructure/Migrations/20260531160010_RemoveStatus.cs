using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace CapacityPlanning.Infrastructure.Migrations
{
    public partial class RemoveStatus : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "Epics",
                keyColumn: "Id",
                keyValue: new Guid("1bc1c608-4b3f-4923-a50e-839544fc3367"));

            migrationBuilder.DeleteData(
                table: "Epics",
                keyColumn: "Id",
                keyValue: new Guid("335641b8-369f-4b2d-b2ce-e2885a564a4b"));

            migrationBuilder.DeleteData(
                table: "Epics",
                keyColumn: "Id",
                keyValue: new Guid("3e586e3d-b8ac-4f85-a422-93d5037bc243"));

            migrationBuilder.DeleteData(
                table: "Epics",
                keyColumn: "Id",
                keyValue: new Guid("5bb4d4e1-39f5-4e36-8863-ab73d196dc7d"));

            migrationBuilder.DeleteData(
                table: "Epics",
                keyColumn: "Id",
                keyValue: new Guid("d6cc8a42-3f3f-4a7f-9f56-759cd9bb2f0d"));

            migrationBuilder.DeleteData(
                table: "Epics",
                keyColumn: "Id",
                keyValue: new Guid("eeabf2a7-a267-40de-b8c2-98f5ff310121"));

            migrationBuilder.DeleteData(
                table: "Persons",
                keyColumn: "Id",
                keyValue: new Guid("24301970-e765-41cc-a410-0c856e2c02c8"));

            migrationBuilder.DeleteData(
                table: "Persons",
                keyColumn: "Id",
                keyValue: new Guid("3e66925e-ee36-446c-a5b4-b69de52fae65"));

            migrationBuilder.DeleteData(
                table: "Persons",
                keyColumn: "Id",
                keyValue: new Guid("4a4042da-4b6f-41f6-8431-1a5fca22d8a5"));

            migrationBuilder.DeleteData(
                table: "Persons",
                keyColumn: "Id",
                keyValue: new Guid("64bd88cf-329f-4914-9f66-d8675051249b"));

            migrationBuilder.DeleteData(
                table: "Persons",
                keyColumn: "Id",
                keyValue: new Guid("6c4e4d13-16d6-422c-a46f-00dd876847cd"));

            migrationBuilder.DeleteData(
                table: "Persons",
                keyColumn: "Id",
                keyValue: new Guid("771e46ff-c7df-4a8a-9570-59849d6fe26f"));

            migrationBuilder.DeleteData(
                table: "Persons",
                keyColumn: "Id",
                keyValue: new Guid("a0288db3-8923-457c-a2b6-85302f3dc156"));

            migrationBuilder.DeleteData(
                table: "Persons",
                keyColumn: "Id",
                keyValue: new Guid("a0ee4a96-f88d-46fb-974c-92ad09360a70"));

            migrationBuilder.DeleteData(
                table: "Persons",
                keyColumn: "Id",
                keyValue: new Guid("cfa69d8c-cf8d-4a04-99de-1966b4853a65"));

            migrationBuilder.DeleteData(
                table: "Persons",
                keyColumn: "Id",
                keyValue: new Guid("e04017ff-c575-4d5f-ae59-ab4a5b557e49"));

            migrationBuilder.DropColumn(
                name: "Status",
                table: "Initiatives");

            migrationBuilder.DropColumn(
                name: "Status",
                table: "Epics");

            migrationBuilder.InsertData(
                table: "Epics",
                columns: new[] { "Id", "CreatedAt", "Description", "DueDate", "EstimatedDays", "InitiativeId", "Name", "StartDate", "TeamId", "UpdatedAt" },
                values: new object[,]
                {
                    { new Guid("09bb960a-9bea-4cee-96cb-96083ccd8ed5"), new DateTime(2026, 5, 31, 16, 0, 10, 360, DateTimeKind.Utc).AddTicks(9978), null, new DateTime(2025, 5, 31, 0, 0, 0, 0, DateTimeKind.Unspecified), 40, new Guid("22222222-0000-0000-0000-000000000001"), "Portal UI Redesign", new DateTime(2025, 2, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new Guid("11111111-0000-0000-0000-000000000002"), new DateTime(2026, 5, 31, 16, 0, 10, 360, DateTimeKind.Utc).AddTicks(9979) },
                    { new Guid("113db9ac-bd73-4700-87db-f4bd1d9f746f"), new DateTime(2026, 5, 31, 16, 0, 10, 361, DateTimeKind.Utc).AddTicks(11), null, new DateTime(2025, 12, 31, 0, 0, 0, 0, DateTimeKind.Unspecified), 60, new Guid("22222222-0000-0000-0000-000000000003"), "iOS App MVP", new DateTime(2025, 6, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new Guid("11111111-0000-0000-0000-000000000004"), new DateTime(2026, 5, 31, 16, 0, 10, 361, DateTimeKind.Utc).AddTicks(12) },
                    { new Guid("163c4b6b-7d32-4297-ba4e-895441907ca7"), new DateTime(2026, 5, 31, 16, 0, 10, 361, DateTimeKind.Utc).AddTicks(15), null, new DateTime(2025, 11, 30, 0, 0, 0, 0, DateTimeKind.Unspecified), 15, new Guid("22222222-0000-0000-0000-000000000003"), "Push Notifications", new DateTime(2025, 9, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new Guid("11111111-0000-0000-0000-000000000001"), new DateTime(2026, 5, 31, 16, 0, 10, 361, DateTimeKind.Utc).AddTicks(15) },
                    { new Guid("19b5901a-764f-42ed-8375-8f0e0f97ed2e"), new DateTime(2026, 5, 31, 16, 0, 10, 360, DateTimeKind.Utc).AddTicks(9972), null, new DateTime(2025, 3, 31, 0, 0, 0, 0, DateTimeKind.Unspecified), 30, new Guid("22222222-0000-0000-0000-000000000001"), "Auth Service Rewrite", new DateTime(2025, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new Guid("11111111-0000-0000-0000-000000000003"), new DateTime(2026, 5, 31, 16, 0, 10, 360, DateTimeKind.Utc).AddTicks(9973) },
                    { new Guid("9566c70d-9cff-41ef-b1ab-795558f2101f"), new DateTime(2026, 5, 31, 16, 0, 10, 361, DateTimeKind.Utc).AddTicks(6), null, new DateTime(2025, 4, 30, 0, 0, 0, 0, DateTimeKind.Unspecified), 25, new Guid("22222222-0000-0000-0000-000000000002"), "DB Query Optimization", new DateTime(2025, 3, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new Guid("11111111-0000-0000-0000-000000000003"), new DateTime(2026, 5, 31, 16, 0, 10, 361, DateTimeKind.Utc).AddTicks(6) },
                    { new Guid("9fc43a39-c3f0-443a-8597-ad9cfa8bbe67"), new DateTime(2026, 5, 31, 16, 0, 10, 360, DateTimeKind.Utc).AddTicks(9984), null, new DateTime(2025, 2, 28, 0, 0, 0, 0, DateTimeKind.Unspecified), 20, new Guid("22222222-0000-0000-0000-000000000002"), "API Gateway Setup", new DateTime(2025, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new Guid("11111111-0000-0000-0000-000000000001"), new DateTime(2026, 5, 31, 16, 0, 10, 360, DateTimeKind.Utc).AddTicks(9984) }
                });

            migrationBuilder.UpdateData(
                table: "Initiatives",
                keyColumn: "Id",
                keyValue: new Guid("22222222-0000-0000-0000-000000000001"),
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2026, 5, 31, 16, 0, 10, 361, DateTimeKind.Utc).AddTicks(5287), new DateTime(2026, 5, 31, 16, 0, 10, 361, DateTimeKind.Utc).AddTicks(5287) });

            migrationBuilder.UpdateData(
                table: "Initiatives",
                keyColumn: "Id",
                keyValue: new Guid("22222222-0000-0000-0000-000000000002"),
                columns: new[] { "CreatedAt", "Name", "UpdatedAt" },
                values: new object[] { new DateTime(2026, 5, 31, 16, 0, 10, 361, DateTimeKind.Utc).AddTicks(5294), "Performance Rework", new DateTime(2026, 5, 31, 16, 0, 10, 361, DateTimeKind.Utc).AddTicks(5294) });

            migrationBuilder.UpdateData(
                table: "Initiatives",
                keyColumn: "Id",
                keyValue: new Guid("22222222-0000-0000-0000-000000000003"),
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2026, 5, 31, 16, 0, 10, 361, DateTimeKind.Utc).AddTicks(5298), new DateTime(2026, 5, 31, 16, 0, 10, 361, DateTimeKind.Utc).AddTicks(5298) });

            migrationBuilder.InsertData(
                table: "Persons",
                columns: new[] { "Id", "AvailabilityPercentage", "CreatedAt", "Name", "Role", "TeamId", "UpdatedAt" },
                values: new object[,]
                {
                    { new Guid("0cf0336f-551a-4488-b656-f04c15b57c07"), 50, new DateTime(2026, 5, 31, 16, 0, 10, 361, DateTimeKind.Utc).AddTicks(6030), "Carol", "Engineer", new Guid("11111111-0000-0000-0000-000000000001"), new DateTime(2026, 5, 31, 16, 0, 10, 361, DateTimeKind.Utc).AddTicks(6031) },
                    { new Guid("2f437a50-01c9-4f17-bc5a-6bec957ef985"), 100, new DateTime(2026, 5, 31, 16, 0, 10, 361, DateTimeKind.Utc).AddTicks(6012), "Alice", "Tech Lead", new Guid("11111111-0000-0000-0000-000000000001"), new DateTime(2026, 5, 31, 16, 0, 10, 361, DateTimeKind.Utc).AddTicks(6013) },
                    { new Guid("46f8c18f-5be1-4184-976e-6334b2d6233b"), 50, new DateTime(2026, 5, 31, 16, 0, 10, 361, DateTimeKind.Utc).AddTicks(6074), "Jack", "Engineer", new Guid("11111111-0000-0000-0000-000000000004"), new DateTime(2026, 5, 31, 16, 0, 10, 361, DateTimeKind.Utc).AddTicks(6074) },
                    { new Guid("5e55e482-43e6-42f0-8186-364f9ff04005"), 100, new DateTime(2026, 5, 31, 16, 0, 10, 361, DateTimeKind.Utc).AddTicks(6068), "Iris", "Tech Lead", new Guid("11111111-0000-0000-0000-000000000004"), new DateTime(2026, 5, 31, 16, 0, 10, 361, DateTimeKind.Utc).AddTicks(6069) },
                    { new Guid("690e20b1-09c5-440d-ab38-8729533c85a3"), 100, new DateTime(2026, 5, 31, 16, 0, 10, 361, DateTimeKind.Utc).AddTicks(6063), "Henry", "Engineer", new Guid("11111111-0000-0000-0000-000000000003"), new DateTime(2026, 5, 31, 16, 0, 10, 361, DateTimeKind.Utc).AddTicks(6063) },
                    { new Guid("7a810005-0e06-474b-bdf7-2f632f8b9272"), 100, new DateTime(2026, 5, 31, 16, 0, 10, 361, DateTimeKind.Utc).AddTicks(6019), "Bob", "Senior Engineer", new Guid("11111111-0000-0000-0000-000000000001"), new DateTime(2026, 5, 31, 16, 0, 10, 361, DateTimeKind.Utc).AddTicks(6020) },
                    { new Guid("7bc5a130-e358-4542-b7cc-d96e430747f9"), 100, new DateTime(2026, 5, 31, 16, 0, 10, 361, DateTimeKind.Utc).AddTicks(6057), "Grace", "Senior Engineer", new Guid("11111111-0000-0000-0000-000000000003"), new DateTime(2026, 5, 31, 16, 0, 10, 361, DateTimeKind.Utc).AddTicks(6058) },
                    { new Guid("addd033d-00d6-4614-98e5-ecea9e00e145"), 100, new DateTime(2026, 5, 31, 16, 0, 10, 361, DateTimeKind.Utc).AddTicks(6042), "Eva", "Engineer", new Guid("11111111-0000-0000-0000-000000000002"), new DateTime(2026, 5, 31, 16, 0, 10, 361, DateTimeKind.Utc).AddTicks(6043) },
                    { new Guid("b1295501-5de7-4f0d-b1af-0359c0dc9b57"), 100, new DateTime(2026, 5, 31, 16, 0, 10, 361, DateTimeKind.Utc).AddTicks(6049), "Frank", "Tech Lead", new Guid("11111111-0000-0000-0000-000000000003"), new DateTime(2026, 5, 31, 16, 0, 10, 361, DateTimeKind.Utc).AddTicks(6049) },
                    { new Guid("f6d85bb0-1a64-40ba-b433-882d54af9ca7"), 100, new DateTime(2026, 5, 31, 16, 0, 10, 361, DateTimeKind.Utc).AddTicks(6036), "Dan", "Tech Lead", new Guid("11111111-0000-0000-0000-000000000002"), new DateTime(2026, 5, 31, 16, 0, 10, 361, DateTimeKind.Utc).AddTicks(6037) }
                });

            migrationBuilder.UpdateData(
                table: "Teams",
                keyColumn: "Id",
                keyValue: new Guid("11111111-0000-0000-0000-000000000001"),
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2026, 5, 31, 16, 0, 10, 361, DateTimeKind.Utc).AddTicks(9938), new DateTime(2026, 5, 31, 16, 0, 10, 361, DateTimeKind.Utc).AddTicks(9939) });

            migrationBuilder.UpdateData(
                table: "Teams",
                keyColumn: "Id",
                keyValue: new Guid("11111111-0000-0000-0000-000000000002"),
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2026, 5, 31, 16, 0, 10, 361, DateTimeKind.Utc).AddTicks(9950), new DateTime(2026, 5, 31, 16, 0, 10, 361, DateTimeKind.Utc).AddTicks(9951) });

            migrationBuilder.UpdateData(
                table: "Teams",
                keyColumn: "Id",
                keyValue: new Guid("11111111-0000-0000-0000-000000000003"),
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2026, 5, 31, 16, 0, 10, 361, DateTimeKind.Utc).AddTicks(9955), new DateTime(2026, 5, 31, 16, 0, 10, 361, DateTimeKind.Utc).AddTicks(9956) });

            migrationBuilder.UpdateData(
                table: "Teams",
                keyColumn: "Id",
                keyValue: new Guid("11111111-0000-0000-0000-000000000004"),
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2026, 5, 31, 16, 0, 10, 361, DateTimeKind.Utc).AddTicks(9960), new DateTime(2026, 5, 31, 16, 0, 10, 361, DateTimeKind.Utc).AddTicks(9960) });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "Epics",
                keyColumn: "Id",
                keyValue: new Guid("09bb960a-9bea-4cee-96cb-96083ccd8ed5"));

            migrationBuilder.DeleteData(
                table: "Epics",
                keyColumn: "Id",
                keyValue: new Guid("113db9ac-bd73-4700-87db-f4bd1d9f746f"));

            migrationBuilder.DeleteData(
                table: "Epics",
                keyColumn: "Id",
                keyValue: new Guid("163c4b6b-7d32-4297-ba4e-895441907ca7"));

            migrationBuilder.DeleteData(
                table: "Epics",
                keyColumn: "Id",
                keyValue: new Guid("19b5901a-764f-42ed-8375-8f0e0f97ed2e"));

            migrationBuilder.DeleteData(
                table: "Epics",
                keyColumn: "Id",
                keyValue: new Guid("9566c70d-9cff-41ef-b1ab-795558f2101f"));

            migrationBuilder.DeleteData(
                table: "Epics",
                keyColumn: "Id",
                keyValue: new Guid("9fc43a39-c3f0-443a-8597-ad9cfa8bbe67"));

            migrationBuilder.DeleteData(
                table: "Persons",
                keyColumn: "Id",
                keyValue: new Guid("0cf0336f-551a-4488-b656-f04c15b57c07"));

            migrationBuilder.DeleteData(
                table: "Persons",
                keyColumn: "Id",
                keyValue: new Guid("2f437a50-01c9-4f17-bc5a-6bec957ef985"));

            migrationBuilder.DeleteData(
                table: "Persons",
                keyColumn: "Id",
                keyValue: new Guid("46f8c18f-5be1-4184-976e-6334b2d6233b"));

            migrationBuilder.DeleteData(
                table: "Persons",
                keyColumn: "Id",
                keyValue: new Guid("5e55e482-43e6-42f0-8186-364f9ff04005"));

            migrationBuilder.DeleteData(
                table: "Persons",
                keyColumn: "Id",
                keyValue: new Guid("690e20b1-09c5-440d-ab38-8729533c85a3"));

            migrationBuilder.DeleteData(
                table: "Persons",
                keyColumn: "Id",
                keyValue: new Guid("7a810005-0e06-474b-bdf7-2f632f8b9272"));

            migrationBuilder.DeleteData(
                table: "Persons",
                keyColumn: "Id",
                keyValue: new Guid("7bc5a130-e358-4542-b7cc-d96e430747f9"));

            migrationBuilder.DeleteData(
                table: "Persons",
                keyColumn: "Id",
                keyValue: new Guid("addd033d-00d6-4614-98e5-ecea9e00e145"));

            migrationBuilder.DeleteData(
                table: "Persons",
                keyColumn: "Id",
                keyValue: new Guid("b1295501-5de7-4f0d-b1af-0359c0dc9b57"));

            migrationBuilder.DeleteData(
                table: "Persons",
                keyColumn: "Id",
                keyValue: new Guid("f6d85bb0-1a64-40ba-b433-882d54af9ca7"));

            migrationBuilder.AddColumn<int>(
                name: "Status",
                table: "Initiatives",
                type: "int",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.AddColumn<int>(
                name: "Status",
                table: "Epics",
                type: "int",
                nullable: false,
                defaultValue: 0);

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

            migrationBuilder.UpdateData(
                table: "Initiatives",
                keyColumn: "Id",
                keyValue: new Guid("22222222-0000-0000-0000-000000000001"),
                columns: new[] { "CreatedAt", "Status", "UpdatedAt" },
                values: new object[] { new DateTime(2026, 5, 31, 13, 22, 16, 933, DateTimeKind.Utc).AddTicks(1040), 1, new DateTime(2026, 5, 31, 13, 22, 16, 933, DateTimeKind.Utc).AddTicks(1040) });

            migrationBuilder.UpdateData(
                table: "Initiatives",
                keyColumn: "Id",
                keyValue: new Guid("22222222-0000-0000-0000-000000000002"),
                columns: new[] { "CreatedAt", "Name", "UpdatedAt" },
                values: new object[] { new DateTime(2026, 5, 31, 13, 22, 16, 933, DateTimeKind.Utc).AddTicks(1043), "Performance Overhaul", new DateTime(2026, 5, 31, 13, 22, 16, 933, DateTimeKind.Utc).AddTicks(1043) });

            migrationBuilder.UpdateData(
                table: "Initiatives",
                keyColumn: "Id",
                keyValue: new Guid("22222222-0000-0000-0000-000000000003"),
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2026, 5, 31, 13, 22, 16, 933, DateTimeKind.Utc).AddTicks(1046), new DateTime(2026, 5, 31, 13, 22, 16, 933, DateTimeKind.Utc).AddTicks(1046) });

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

            migrationBuilder.UpdateData(
                table: "Teams",
                keyColumn: "Id",
                keyValue: new Guid("11111111-0000-0000-0000-000000000001"),
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2026, 5, 31, 13, 22, 16, 933, DateTimeKind.Utc).AddTicks(3327), new DateTime(2026, 5, 31, 13, 22, 16, 933, DateTimeKind.Utc).AddTicks(3327) });

            migrationBuilder.UpdateData(
                table: "Teams",
                keyColumn: "Id",
                keyValue: new Guid("11111111-0000-0000-0000-000000000002"),
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2026, 5, 31, 13, 22, 16, 933, DateTimeKind.Utc).AddTicks(3330), new DateTime(2026, 5, 31, 13, 22, 16, 933, DateTimeKind.Utc).AddTicks(3330) });

            migrationBuilder.UpdateData(
                table: "Teams",
                keyColumn: "Id",
                keyValue: new Guid("11111111-0000-0000-0000-000000000003"),
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2026, 5, 31, 13, 22, 16, 933, DateTimeKind.Utc).AddTicks(3332), new DateTime(2026, 5, 31, 13, 22, 16, 933, DateTimeKind.Utc).AddTicks(3332) });

            migrationBuilder.UpdateData(
                table: "Teams",
                keyColumn: "Id",
                keyValue: new Guid("11111111-0000-0000-0000-000000000004"),
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2026, 5, 31, 13, 22, 16, 933, DateTimeKind.Utc).AddTicks(3334), new DateTime(2026, 5, 31, 13, 22, 16, 933, DateTimeKind.Utc).AddTicks(3335) });
        }
    }
}
