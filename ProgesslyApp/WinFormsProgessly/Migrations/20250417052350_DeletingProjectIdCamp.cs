using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace WinFormsProgessly.Migrations
{
    /// <inheritdoc />
    public partial class DeletingProjectIdCamp : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Tareas_Projects_ProjectId",
                table: "Tareas");

            migrationBuilder.DropIndex(
                name: "IX_Tareas_ProjectId",
                table: "Tareas");

            migrationBuilder.DropColumn(
                name: "ProjectId",
                table: "Tareas");

            migrationBuilder.CreateIndex(
                name: "IX_Tareas_idProject",
                table: "Tareas",
                column: "idProject");

            migrationBuilder.AddForeignKey(
                name: "FK_Tareas_Projects_idProject",
                table: "Tareas",
                column: "idProject",
                principalTable: "Projects",
                principalColumn: "Id");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Tareas_Projects_idProject",
                table: "Tareas");

            migrationBuilder.DropIndex(
                name: "IX_Tareas_idProject",
                table: "Tareas");

            migrationBuilder.AddColumn<int>(
                name: "ProjectId",
                table: "Tareas",
                type: "int",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.CreateIndex(
                name: "IX_Tareas_ProjectId",
                table: "Tareas",
                column: "ProjectId");

            migrationBuilder.AddForeignKey(
                name: "FK_Tareas_Projects_ProjectId",
                table: "Tareas",
                column: "ProjectId",
                principalTable: "Projects",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);
        }
    }
}
