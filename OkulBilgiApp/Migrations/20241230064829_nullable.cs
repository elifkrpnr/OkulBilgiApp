using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace OkulBilgiApp.Migrations
{
    /// <inheritdoc />
    public partial class nullable : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Ogrenciler_TblSiniflar_SinifId",
                table: "Ogrenciler");

            migrationBuilder.AlterColumn<int>(
                name: "SinifId",
                table: "Ogrenciler",
                type: "int",
                nullable: true,
                oldClrType: typeof(int),
                oldType: "int");

            migrationBuilder.AddForeignKey(
                name: "FK_Ogrenciler_TblSiniflar_SinifId",
                table: "Ogrenciler",
                column: "SinifId",
                principalTable: "TblSiniflar",
                principalColumn: "SinifId");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Ogrenciler_TblSiniflar_SinifId",
                table: "Ogrenciler");

            migrationBuilder.AlterColumn<int>(
                name: "SinifId",
                table: "Ogrenciler",
                type: "int",
                nullable: false,
                defaultValue: 0,
                oldClrType: typeof(int),
                oldType: "int",
                oldNullable: true);

            migrationBuilder.AddForeignKey(
                name: "FK_Ogrenciler_TblSiniflar_SinifId",
                table: "Ogrenciler",
                column: "SinifId",
                principalTable: "TblSiniflar",
                principalColumn: "SinifId",
                onDelete: ReferentialAction.Cascade);
        }
    }
}
