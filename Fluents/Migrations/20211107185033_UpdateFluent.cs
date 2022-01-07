using Microsoft.EntityFrameworkCore.Migrations;

namespace Fluents.Migrations
{
    public partial class UpdateFluent : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Students_Grades_GradeId",
                table: "Students");

            migrationBuilder.DropIndex(
                name: "IX_Students_GradeId",
                table: "Students");

            migrationBuilder.DropColumn(
                name: "GradeId",
                table: "Students");

            migrationBuilder.CreateIndex(
                name: "IX_Students_CurrentGradeId",
                table: "Students",
                column: "CurrentGradeId");

            migrationBuilder.AddForeignKey(
                name: "FK_Students_Grades_CurrentGradeId",
                table: "Students",
                column: "CurrentGradeId",
                principalTable: "Grades",
                principalColumn: "GradeId",
                onDelete: ReferentialAction.Cascade);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Students_Grades_CurrentGradeId",
                table: "Students");

            migrationBuilder.DropIndex(
                name: "IX_Students_CurrentGradeId",
                table: "Students");

            migrationBuilder.AddColumn<int>(
                name: "GradeId",
                table: "Students",
                type: "int",
                nullable: true);

            migrationBuilder.CreateIndex(
                name: "IX_Students_GradeId",
                table: "Students",
                column: "GradeId");

            migrationBuilder.AddForeignKey(
                name: "FK_Students_Grades_GradeId",
                table: "Students",
                column: "GradeId",
                principalTable: "Grades",
                principalColumn: "GradeId",
                onDelete: ReferentialAction.Restrict);
        }
    }
}
