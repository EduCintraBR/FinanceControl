using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace FinanceControl.Api.Migrations
{
    /// <inheritdoc />
    public partial class AddFKToControleForCustosAndGanhos : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Custos_Categorias_CategoriaOrigemId",
                table: "Custos");

            migrationBuilder.DropForeignKey(
                name: "FK_Custos_Parcela_ParcelaId",
                table: "Custos");

            migrationBuilder.DropForeignKey(
                name: "FK_Ganhos_Categorias_CategoriaOrigemId",
                table: "Ganhos");

            migrationBuilder.DropIndex(
                name: "IX_Ganhos_CategoriaOrigemId",
                table: "Ganhos");

            migrationBuilder.DropIndex(
                name: "IX_Custos_CategoriaOrigemId",
                table: "Custos");

            migrationBuilder.DropColumn(
                name: "CategoriaOrigemId",
                table: "Ganhos");

            migrationBuilder.DropColumn(
                name: "CategoriaOrigemId",
                table: "Custos");

            migrationBuilder.RenameColumn(
                name: "ParcelaId",
                table: "Custos",
                newName: "CodParcela");

            migrationBuilder.RenameIndex(
                name: "IX_Custos_ParcelaId",
                table: "Custos",
                newName: "IX_Custos_CodParcela");

            migrationBuilder.AddColumn<string>(
                name: "CategoriaOrigem",
                table: "Ganhos",
                type: "nvarchar(max)",
                nullable: false,
                defaultValue: "");

            migrationBuilder.AddColumn<string>(
                name: "CategoriaOrigem",
                table: "Custos",
                type: "nvarchar(max)",
                nullable: false,
                defaultValue: "");

            migrationBuilder.AddColumn<int>(
                name: "CodCusto",
                table: "Controles",
                type: "int",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.AddColumn<int>(
                name: "CodGanho",
                table: "Controles",
                type: "int",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.AddForeignKey(
                name: "FK_Custos_Parcela_CodParcela",
                table: "Custos",
                column: "CodParcela",
                principalTable: "Parcela",
                principalColumn: "Id");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Custos_Parcela_CodParcela",
                table: "Custos");

            migrationBuilder.DropColumn(
                name: "CategoriaOrigem",
                table: "Ganhos");

            migrationBuilder.DropColumn(
                name: "CategoriaOrigem",
                table: "Custos");

            migrationBuilder.DropColumn(
                name: "CodCusto",
                table: "Controles");

            migrationBuilder.DropColumn(
                name: "CodGanho",
                table: "Controles");

            migrationBuilder.RenameColumn(
                name: "CodParcela",
                table: "Custos",
                newName: "ParcelaId");

            migrationBuilder.RenameIndex(
                name: "IX_Custos_CodParcela",
                table: "Custos",
                newName: "IX_Custos_ParcelaId");

            migrationBuilder.AddColumn<int>(
                name: "CategoriaOrigemId",
                table: "Ganhos",
                type: "int",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.AddColumn<int>(
                name: "CategoriaOrigemId",
                table: "Custos",
                type: "int",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.CreateIndex(
                name: "IX_Ganhos_CategoriaOrigemId",
                table: "Ganhos",
                column: "CategoriaOrigemId");

            migrationBuilder.CreateIndex(
                name: "IX_Custos_CategoriaOrigemId",
                table: "Custos",
                column: "CategoriaOrigemId");

            migrationBuilder.AddForeignKey(
                name: "FK_Custos_Categorias_CategoriaOrigemId",
                table: "Custos",
                column: "CategoriaOrigemId",
                principalTable: "Categorias",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_Custos_Parcela_ParcelaId",
                table: "Custos",
                column: "ParcelaId",
                principalTable: "Parcela",
                principalColumn: "Id");

            migrationBuilder.AddForeignKey(
                name: "FK_Ganhos_Categorias_CategoriaOrigemId",
                table: "Ganhos",
                column: "CategoriaOrigemId",
                principalTable: "Categorias",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);
        }
    }
}
