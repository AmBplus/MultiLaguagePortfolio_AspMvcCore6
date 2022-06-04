using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace Server.Migrations
{
    public partial class init_2 : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Clients",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Name = table.Column<string>(type: "nvarchar(150)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Clients", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "EnglishArticles",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Title = table.Column<string>(type: "nvarchar(80)", maxLength: 80, nullable: false),
                    Description = table.Column<string>(type: "varchar(450)", nullable: false),
                    Image = table.Column<string>(type: "nvarchar(150)", nullable: false),
                    DateTime = table.Column<DateTime>(type: "datetime2", nullable: false),
                    ClientId = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_EnglishArticles", x => x.Id);
                    table.ForeignKey(
                        name: "FK_EnglishArticles_Clients_ClientId",
                        column: x => x.ClientId,
                        principalTable: "Clients",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "EnglishProjects",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Title = table.Column<string>(type: "nvarchar(80)", maxLength: 80, nullable: false),
                    Description = table.Column<string>(type: "varchar(450)", nullable: false),
                    Image = table.Column<string>(type: "nvarchar(150)", nullable: false),
                    IsSpecial = table.Column<bool>(type: "bit", nullable: false),
                    ClientId = table.Column<int>(type: "int", nullable: false),
                    DateTime = table.Column<DateTime>(type: "datetime2", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_EnglishProjects", x => x.Id);
                    table.ForeignKey(
                        name: "FK_EnglishProjects_Clients_ClientId",
                        column: x => x.ClientId,
                        principalTable: "Clients",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "PersianAticles",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Title = table.Column<string>(type: "nvarchar(80)", maxLength: 80, nullable: false),
                    Description = table.Column<string>(type: "nvarchar(450)", nullable: false),
                    Image = table.Column<string>(type: "nvarchar(150)", nullable: false),
                    ClientId = table.Column<int>(type: "int", nullable: false),
                    DateTime = table.Column<DateTime>(type: "datetime2", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_PersianAticles", x => x.Id);
                    table.ForeignKey(
                        name: "FK_PersianAticles_Clients_ClientId",
                        column: x => x.ClientId,
                        principalTable: "Clients",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "PersianProjects",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Title = table.Column<string>(type: "nvarchar(80)", maxLength: 80, nullable: false),
                    Description = table.Column<string>(type: "nvarchar(450)", nullable: false),
                    Image = table.Column<string>(type: "nvarchar(150)", nullable: false),
                    IsSpecial = table.Column<bool>(type: "bit", nullable: false),
                    ClientId = table.Column<int>(type: "int", nullable: false),
                    DateTime = table.Column<DateTime>(type: "datetime2", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_PersianProjects", x => x.Id);
                    table.ForeignKey(
                        name: "FK_PersianProjects_Clients_ClientId",
                        column: x => x.ClientId,
                        principalTable: "Clients",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateIndex(
                name: "IX_EnglishArticles_ClientId",
                table: "EnglishArticles",
                column: "ClientId",
                unique: true);

            migrationBuilder.CreateIndex(
                name: "IX_EnglishProjects_ClientId",
                table: "EnglishProjects",
                column: "ClientId",
                unique: true);

            migrationBuilder.CreateIndex(
                name: "IX_PersianAticles_ClientId",
                table: "PersianAticles",
                column: "ClientId",
                unique: true);

            migrationBuilder.CreateIndex(
                name: "IX_PersianProjects_ClientId",
                table: "PersianProjects",
                column: "ClientId",
                unique: true);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "EnglishArticles");

            migrationBuilder.DropTable(
                name: "EnglishProjects");

            migrationBuilder.DropTable(
                name: "PersianAticles");

            migrationBuilder.DropTable(
                name: "PersianProjects");

            migrationBuilder.DropTable(
                name: "Clients");
        }
    }
}
