using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace HabitsHacked.Migrations
{
    public partial class update : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.InsertData(
                table: "Categories",
                columns: new[] { "CategoryID", "CategoryName" },
                values: new object[] { 1, "Home" });

            migrationBuilder.InsertData(
                table: "Categories",
                columns: new[] { "CategoryID", "CategoryName" },
                values: new object[] { 2, "School" });

            migrationBuilder.InsertData(
                table: "Categories",
                columns: new[] { "CategoryID", "CategoryName" },
                values: new object[] { 3, "Work" });

            migrationBuilder.InsertData(
                table: "Categories",
                columns: new[] { "CategoryID", "CategoryName" },
                values: new object[] { 4, "Church" });

            migrationBuilder.InsertData(
                table: "TaskResponses",
                columns: new[] { "TaskID", "CategoryID", "Completed", "DueDate", "Quadrant", "TaskName" },
                values: new object[] { 2, 1, false, new DateTime(2022, 2, 10, 0, 0, 0, 0, DateTimeKind.Unspecified), "Quadrant 2", "Feed the Dog" });

            migrationBuilder.InsertData(
                table: "TaskResponses",
                columns: new[] { "TaskID", "CategoryID", "Completed", "DueDate", "Quadrant", "TaskName" },
                values: new object[] { 4, 1, true, new DateTime(2022, 2, 10, 0, 0, 0, 0, DateTimeKind.Unspecified), "Quadrant 4", "Watch New Girl" });

            migrationBuilder.InsertData(
                table: "TaskResponses",
                columns: new[] { "TaskID", "CategoryID", "Completed", "DueDate", "Quadrant", "TaskName" },
                values: new object[] { 1, 2, true, new DateTime(2022, 2, 9, 0, 0, 0, 0, DateTimeKind.Unspecified), "Quadrant 1", "Mission 6" });

            migrationBuilder.InsertData(
                table: "TaskResponses",
                columns: new[] { "TaskID", "CategoryID", "Completed", "DueDate", "Quadrant", "TaskName" },
                values: new object[] { 5, 3, true, new DateTime(2022, 2, 11, 0, 0, 0, 0, DateTimeKind.Unspecified), "Quadrant 2", "Weekly Work Meeting" });

            migrationBuilder.InsertData(
                table: "TaskResponses",
                columns: new[] { "TaskID", "CategoryID", "Completed", "DueDate", "Quadrant", "TaskName" },
                values: new object[] { 3, 4, false, new DateTime(2022, 2, 12, 0, 0, 0, 0, DateTimeKind.Unspecified), "Quadrant 3", "Call Stake President" });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "TaskResponses",
                keyColumn: "TaskID",
                keyValue: 1);

            migrationBuilder.DeleteData(
                table: "TaskResponses",
                keyColumn: "TaskID",
                keyValue: 2);

            migrationBuilder.DeleteData(
                table: "TaskResponses",
                keyColumn: "TaskID",
                keyValue: 3);

            migrationBuilder.DeleteData(
                table: "TaskResponses",
                keyColumn: "TaskID",
                keyValue: 4);

            migrationBuilder.DeleteData(
                table: "TaskResponses",
                keyColumn: "TaskID",
                keyValue: 5);

            migrationBuilder.DeleteData(
                table: "Categories",
                keyColumn: "CategoryID",
                keyValue: 1);

            migrationBuilder.DeleteData(
                table: "Categories",
                keyColumn: "CategoryID",
                keyValue: 2);

            migrationBuilder.DeleteData(
                table: "Categories",
                keyColumn: "CategoryID",
                keyValue: 3);

            migrationBuilder.DeleteData(
                table: "Categories",
                keyColumn: "CategoryID",
                keyValue: 4);
        }
    }
}
