using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace FinanceControl.Api.Migrations
{
    /// <inheritdoc />
    public partial class AddForeignKeyParcelamentoCartao : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Parcelamento_Cartoes_CartaoId",
                table: "Parcelamento");

            migrationBuilder.RenameColumn(
                name: "CartaoId",
                table: "Parcelamento",
                newName: "CodCartao");

            migrationBuilder.RenameIndex(
                name: "IX_Parcelamento_CartaoId",
                table: "Parcelamento",
                newName: "IX_Parcelamento_CodCartao");

            migrationBuilder.AddForeignKey(
                name: "FK_Parcelamento_Cartoes_CodCartao",
                table: "Parcelamento",
                column: "CodCartao",
                principalTable: "Cartoes",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Parcelamento_Cartoes_CodCartao",
                table: "Parcelamento");

            migrationBuilder.RenameColumn(
                name: "CodCartao",
                table: "Parcelamento",
                newName: "CartaoId");

            migrationBuilder.RenameIndex(
                name: "IX_Parcelamento_CodCartao",
                table: "Parcelamento",
                newName: "IX_Parcelamento_CartaoId");

            migrationBuilder.AddForeignKey(
                name: "FK_Parcelamento_Cartoes_CartaoId",
                table: "Parcelamento",
                column: "CartaoId",
                principalTable: "Cartoes",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);
        }
    }
}
