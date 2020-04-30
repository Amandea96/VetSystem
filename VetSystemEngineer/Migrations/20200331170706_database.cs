using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace VetSystemEngineer.Migrations
{
    public partial class database : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Examination");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Examination",
                columns: table => new
                {
                    id_exam = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    date_exam = table.Column<DateTime>(type: "datetime", nullable: false),
                    id_visit = table.Column<int>(type: "int", nullable: false),
                    result = table.Column<string>(type: "nchar(10)", fixedLength: true, maxLength: 10, nullable: false),
                    type = table.Column<string>(type: "varchar(100)", unicode: false, maxLength: 100, nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Examination", x => x.id_exam);
                    table.ForeignKey(
                        name: "FK_Examination_Visit",
                        column: x => x.id_visit,
                        principalTable: "Visit",
                        principalColumn: "id_visit",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateIndex(
                name: "IX_Examination_id_visit",
                table: "Examination",
                column: "id_visit");
        }
    }
}
