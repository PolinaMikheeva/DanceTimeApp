using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace DanceTimeApp.Migrations
{
    /// <inheritdoc />
    public partial class AppMigration : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Directions",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Name = table.Column<string>(type: "nvarchar(450)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Directions", x => x.Id);
                    table.UniqueConstraint("AK_Directions_Name", x => x.Name);
                });

            migrationBuilder.CreateTable(
                name: "Users",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Name = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Nickname = table.Column<string>(type: "nvarchar(450)", nullable: false),
                    Password = table.Column<string>(type: "nvarchar(max)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Users", x => x.Id);
                    table.UniqueConstraint("AK_Users_Nickname", x => x.Nickname);
                });

            migrationBuilder.CreateTable(
                name: "Trainers",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Name = table.Column<string>(type: "nvarchar(450)", nullable: false),
                    DirectionName = table.Column<string>(type: "nvarchar(450)", nullable: false),
                    Experience = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Trainers", x => x.Id);
                    table.UniqueConstraint("AK_Trainers_Name", x => x.Name);
                    table.ForeignKey(
                        name: "FK_Trainers_Directions_DirectionName",
                        column: x => x.DirectionName,
                        principalTable: "Directions",
                        principalColumn: "Name",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "Comments",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    UserNickname = table.Column<string>(type: "nvarchar(450)", nullable: false),
                    TrainerName = table.Column<string>(type: "nvarchar(450)", nullable: false),
                    Description = table.Column<string>(type: "nvarchar(max)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Comments", x => x.Id);
                    table.ForeignKey(
                        name: "FK_Comments_Trainers_TrainerName",
                        column: x => x.TrainerName,
                        principalTable: "Trainers",
                        principalColumn: "Name",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_Comments_Users_UserNickname",
                        column: x => x.UserNickname,
                        principalTable: "Users",
                        principalColumn: "Nickname",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "Schedules",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    DirectionName = table.Column<string>(type: "nvarchar(450)", nullable: false),
                    Day = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Time = table.Column<TimeSpan>(type: "time", nullable: false),
                    TrainerName = table.Column<string>(type: "nvarchar(450)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Schedules", x => x.Id);
                    table.ForeignKey(
                        name: "FK_Schedules_Directions_DirectionName",
                        column: x => x.DirectionName,
                        principalTable: "Directions",
                        principalColumn: "Name",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_Schedules_Trainers_TrainerName",
                        column: x => x.TrainerName,
                        principalTable: "Trainers",
                        principalColumn: "Name",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateTable(
                name: "Records",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    UserNickname = table.Column<string>(type: "nvarchar(450)", nullable: false),
                    ScheduleName = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    ScheduleId = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Records", x => x.Id);
                    table.ForeignKey(
                        name: "FK_Records_Schedules_ScheduleId",
                        column: x => x.ScheduleId,
                        principalTable: "Schedules",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_Records_Users_UserNickname",
                        column: x => x.UserNickname,
                        principalTable: "Users",
                        principalColumn: "Nickname",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateIndex(
                name: "IX_Comments_TrainerName",
                table: "Comments",
                column: "TrainerName");

            migrationBuilder.CreateIndex(
                name: "IX_Comments_UserNickname",
                table: "Comments",
                column: "UserNickname");

            migrationBuilder.CreateIndex(
                name: "IX_Records_ScheduleId",
                table: "Records",
                column: "ScheduleId");

            migrationBuilder.CreateIndex(
                name: "IX_Records_UserNickname",
                table: "Records",
                column: "UserNickname");

            migrationBuilder.CreateIndex(
                name: "IX_Schedules_DirectionName",
                table: "Schedules",
                column: "DirectionName");

            migrationBuilder.CreateIndex(
                name: "IX_Schedules_TrainerName",
                table: "Schedules",
                column: "TrainerName");

            migrationBuilder.CreateIndex(
                name: "IX_Trainers_DirectionName",
                table: "Trainers",
                column: "DirectionName");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Comments");

            migrationBuilder.DropTable(
                name: "Records");

            migrationBuilder.DropTable(
                name: "Schedules");

            migrationBuilder.DropTable(
                name: "Users");

            migrationBuilder.DropTable(
                name: "Trainers");

            migrationBuilder.DropTable(
                name: "Directions");
        }
    }
}
