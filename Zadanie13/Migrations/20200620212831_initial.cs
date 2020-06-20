using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace Zadanie13.Migrations
{
    public partial class initial : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Klienci",
                columns: table => new
                {
                    IdKlient = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Imie = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: false),
                    Nazwisko = table.Column<string>(type: "nvarchar(60)", maxLength: 60, nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Klienci", x => x.IdKlient);
                });

            migrationBuilder.CreateTable(
                name: "Pracownik",
                columns: table => new
                {
                    IdPracown = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Imie = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: false),
                    Nazwisko = table.Column<string>(type: "nvarchar(60)", maxLength: 60, nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Pracownik", x => x.IdPracown);
                });

            migrationBuilder.CreateTable(
                name: "WyrobCukierniczy",
                columns: table => new
                {
                    IdWyrobuCukierniczego = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Nazwa = table.Column<string>(type: "nvarchar(200)", maxLength: 200, nullable: false),
                    CenaZaSzt = table.Column<float>(type: "real", nullable: false),
                    Typ = table.Column<string>(type: "nvarchar(40)", maxLength: 40, nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_WyrobCukierniczy", x => x.IdWyrobuCukierniczego);
                });

            migrationBuilder.CreateTable(
                name: "Zamowienie",
                columns: table => new
                {
                    IdZamowienia = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    DataPrzyjecia = table.Column<DateTime>(type: "datetime2", nullable: false),
                    DataRealizacji = table.Column<DateTime>(type: "datetime2", nullable: false),
                    Uwagi = table.Column<string>(type: "nvarchar(300)", maxLength: 300, nullable: true),
                    IdKlient = table.Column<int>(type: "int", nullable: false),
                    IdPracownik = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Zamowienie", x => x.IdZamowienia);
                    table.ForeignKey(
                        name: "FK_Zamowienie_Klienci_IdKlient",
                        column: x => x.IdKlient,
                        principalTable: "Klienci",
                        principalColumn: "IdKlient",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_Zamowienie_Pracownik_IdPracownik",
                        column: x => x.IdPracownik,
                        principalTable: "Pracownik",
                        principalColumn: "IdPracown",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "Zamowienie_WyrobCukierniczy",
                columns: table => new
                {
                    IdWyrobuCukierniczego = table.Column<int>(type: "int", nullable: false),
                    IdZamowienia = table.Column<int>(type: "int", nullable: false),
                    Ilosc = table.Column<int>(type: "int", nullable: false),
                    Uwagi = table.Column<string>(type: "nvarchar(300)", maxLength: 300, nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Zamowienie_WyrobCukierniczy", x => new { x.IdZamowienia, x.IdWyrobuCukierniczego });
                    table.ForeignKey(
                        name: "FK_Zamowienie_WyrobCukierniczy_WyrobCukierniczy_IdWyrobuCukierniczego",
                        column: x => x.IdWyrobuCukierniczego,
                        principalTable: "WyrobCukierniczy",
                        principalColumn: "IdWyrobuCukierniczego",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_Zamowienie_WyrobCukierniczy_Zamowienie_IdZamowienia",
                        column: x => x.IdZamowienia,
                        principalTable: "Zamowienie",
                        principalColumn: "IdZamowienia",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateIndex(
                name: "IX_Zamowienie_IdKlient",
                table: "Zamowienie",
                column: "IdKlient");

            migrationBuilder.CreateIndex(
                name: "IX_Zamowienie_IdPracownik",
                table: "Zamowienie",
                column: "IdPracownik");

            migrationBuilder.CreateIndex(
                name: "IX_Zamowienie_WyrobCukierniczy_IdWyrobuCukierniczego",
                table: "Zamowienie_WyrobCukierniczy",
                column: "IdWyrobuCukierniczego");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Zamowienie_WyrobCukierniczy");

            migrationBuilder.DropTable(
                name: "WyrobCukierniczy");

            migrationBuilder.DropTable(
                name: "Zamowienie");

            migrationBuilder.DropTable(
                name: "Klienci");

            migrationBuilder.DropTable(
                name: "Pracownik");
        }
    }
}
