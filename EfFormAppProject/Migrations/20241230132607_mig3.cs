using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace EfFormAppProject.Migrations
{
    /// <inheritdoc />
    public partial class mig3 : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Students_Classrooms_ClassId",
                table: "Students");

            migrationBuilder.AlterColumn<int>(
                name: "ClassId",
                table: "Students",
                type: "int",
                nullable: true,
                oldClrType: typeof(int),
                oldType: "int");

            migrationBuilder.AddColumn<int>(
                name: "Quota",
                table: "Lessons",
                type: "int",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.AddForeignKey(
                name: "FK_Students_Classrooms_ClassId",
                table: "Students",
                column: "ClassId",
                principalTable: "Classrooms",
                principalColumn: "ClassId");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Students_Classrooms_ClassId",
                table: "Students");

            migrationBuilder.DropColumn(
                name: "Quota",
                table: "Lessons");

            migrationBuilder.AlterColumn<int>(
                name: "ClassId",
                table: "Students",
                type: "int",
                nullable: false,
                defaultValue: 0,
                oldClrType: typeof(int),
                oldType: "int",
                oldNullable: true);

            migrationBuilder.AddForeignKey(
                name: "FK_Students_Classrooms_ClassId",
                table: "Students",
                column: "ClassId",
                principalTable: "Classrooms",
                principalColumn: "ClassId",
                onDelete: ReferentialAction.Cascade);
        }
    }
}
