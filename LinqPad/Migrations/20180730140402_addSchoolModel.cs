using Microsoft.EntityFrameworkCore.Migrations;

namespace LinqPad.Migrations
{
    public partial class addSchoolModel : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_SectionStudent_Sections_SectionId",
                table: "SectionStudent");

            migrationBuilder.DropForeignKey(
                name: "FK_SectionStudent_Students_StudentId",
                table: "SectionStudent");

            migrationBuilder.DropPrimaryKey(
                name: "PK_SectionStudent",
                table: "SectionStudent");

            migrationBuilder.RenameTable(
                name: "SectionStudent",
                newName: "SectionStudents");

            migrationBuilder.RenameIndex(
                name: "IX_SectionStudent_StudentId",
                table: "SectionStudents",
                newName: "IX_SectionStudents_StudentId");

            migrationBuilder.AddPrimaryKey(
                name: "PK_SectionStudents",
                table: "SectionStudents",
                columns: new[] { "SectionId", "StudentId" });

            migrationBuilder.AddForeignKey(
                name: "FK_SectionStudents_Sections_SectionId",
                table: "SectionStudents",
                column: "SectionId",
                principalTable: "Sections",
                principalColumn: "SectionId",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_SectionStudents_Students_StudentId",
                table: "SectionStudents",
                column: "StudentId",
                principalTable: "Students",
                principalColumn: "StudentId",
                onDelete: ReferentialAction.Cascade);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_SectionStudents_Sections_SectionId",
                table: "SectionStudents");

            migrationBuilder.DropForeignKey(
                name: "FK_SectionStudents_Students_StudentId",
                table: "SectionStudents");

            migrationBuilder.DropPrimaryKey(
                name: "PK_SectionStudents",
                table: "SectionStudents");

            migrationBuilder.RenameTable(
                name: "SectionStudents",
                newName: "SectionStudent");

            migrationBuilder.RenameIndex(
                name: "IX_SectionStudents_StudentId",
                table: "SectionStudent",
                newName: "IX_SectionStudent_StudentId");

            migrationBuilder.AddPrimaryKey(
                name: "PK_SectionStudent",
                table: "SectionStudent",
                columns: new[] { "SectionId", "StudentId" });

            migrationBuilder.AddForeignKey(
                name: "FK_SectionStudent_Sections_SectionId",
                table: "SectionStudent",
                column: "SectionId",
                principalTable: "Sections",
                principalColumn: "SectionId",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_SectionStudent_Students_StudentId",
                table: "SectionStudent",
                column: "StudentId",
                principalTable: "Students",
                principalColumn: "StudentId",
                onDelete: ReferentialAction.Cascade);
        }
    }
}
