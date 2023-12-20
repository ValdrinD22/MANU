using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace WebApi1.Migrations
{
    /// <inheritdoc />
    public partial class InitialCreate : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "AspNetRoles",
                columns: table => new
                {
                    Id = table.Column<string>(type: "nvarchar(450)", nullable: false),
                    Name = table.Column<string>(type: "nvarchar(256)", maxLength: 256, nullable: true),
                    NormalizedName = table.Column<string>(type: "nvarchar(256)", maxLength: 256, nullable: true),
                    ConcurrencyStamp = table.Column<string>(type: "nvarchar(max)", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_AspNetRoles", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "AspNetUsers",
                columns: table => new
                {
                    Id = table.Column<string>(type: "nvarchar(450)", nullable: false),
                    UserName = table.Column<string>(type: "nvarchar(256)", maxLength: 256, nullable: true),
                    NormalizedUserName = table.Column<string>(type: "nvarchar(256)", maxLength: 256, nullable: true),
                    Email = table.Column<string>(type: "nvarchar(256)", maxLength: 256, nullable: true),
                    NormalizedEmail = table.Column<string>(type: "nvarchar(256)", maxLength: 256, nullable: true),
                    EmailConfirmed = table.Column<bool>(type: "bit", nullable: false),
                    PasswordHash = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    SecurityStamp = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    ConcurrencyStamp = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    PhoneNumber = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    PhoneNumberConfirmed = table.Column<bool>(type: "bit", nullable: false),
                    TwoFactorEnabled = table.Column<bool>(type: "bit", nullable: false),
                    LockoutEnd = table.Column<DateTimeOffset>(type: "datetimeoffset", nullable: true),
                    LockoutEnabled = table.Column<bool>(type: "bit", nullable: false),
                    AccessFailedCount = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_AspNetUsers", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "KategoriaProduktit",
                columns: table => new
                {
                    KategoriaId = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    LlojiKategoris = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    PershkrimiKategoris = table.Column<string>(type: "nvarchar(max)", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_KategoriaProduktit", x => x.KategoriaId);
                });

            migrationBuilder.CreateTable(
                name: "Kompania",
                columns: table => new
                {
                    KompaniaId = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    EmriKompanis = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Logo = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Adresa = table.Column<string>(type: "nvarchar(max)", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Kompania", x => x.KompaniaId);
                });

            migrationBuilder.CreateTable(
                name: "TeDhenatBiznesit",
                columns: table => new
                {
                    IdteDhenatBiznesit = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    EmriIbiznesit = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    ShkurtesaEmritBiznesit = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Nui = table.Column<int>(type: "int", nullable: true),
                    Nf = table.Column<int>(type: "int", nullable: true),
                    Nrtvsh = table.Column<int>(type: "int", nullable: true),
                    Adresa = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    NrKontaktit = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Email = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Logo = table.Column<string>(type: "nvarchar(max)", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_TeDhenatBiznesit", x => x.IdteDhenatBiznesit);
                });

            migrationBuilder.CreateTable(
                name: "AspNetRoleClaims",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    RoleId = table.Column<string>(type: "nvarchar(450)", nullable: false),
                    ClaimType = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    ClaimValue = table.Column<string>(type: "nvarchar(max)", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_AspNetRoleClaims", x => x.Id);
                    table.ForeignKey(
                        name: "FK_AspNetRoleClaims_AspNetRoles_RoleId",
                        column: x => x.RoleId,
                        principalTable: "AspNetRoles",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "AspNetUserClaims",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    UserId = table.Column<string>(type: "nvarchar(450)", nullable: false),
                    ClaimType = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    ClaimValue = table.Column<string>(type: "nvarchar(max)", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_AspNetUserClaims", x => x.Id);
                    table.ForeignKey(
                        name: "FK_AspNetUserClaims_AspNetUsers_UserId",
                        column: x => x.UserId,
                        principalTable: "AspNetUsers",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "AspNetUserLogins",
                columns: table => new
                {
                    LoginProvider = table.Column<string>(type: "nvarchar(450)", nullable: false),
                    ProviderKey = table.Column<string>(type: "nvarchar(450)", nullable: false),
                    ProviderDisplayName = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    UserId = table.Column<string>(type: "nvarchar(450)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_AspNetUserLogins", x => new { x.LoginProvider, x.ProviderKey });
                    table.ForeignKey(
                        name: "FK_AspNetUserLogins_AspNetUsers_UserId",
                        column: x => x.UserId,
                        principalTable: "AspNetUsers",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "AspNetUserRoles",
                columns: table => new
                {
                    UserId = table.Column<string>(type: "nvarchar(450)", nullable: false),
                    RoleId = table.Column<string>(type: "nvarchar(450)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_AspNetUserRoles", x => new { x.UserId, x.RoleId });
                    table.ForeignKey(
                        name: "FK_AspNetUserRoles_AspNetRoles_RoleId",
                        column: x => x.RoleId,
                        principalTable: "AspNetRoles",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_AspNetUserRoles_AspNetUsers_UserId",
                        column: x => x.UserId,
                        principalTable: "AspNetUsers",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "AspNetUserTokens",
                columns: table => new
                {
                    UserId = table.Column<string>(type: "nvarchar(450)", nullable: false),
                    LoginProvider = table.Column<string>(type: "nvarchar(450)", nullable: false),
                    Name = table.Column<string>(type: "nvarchar(450)", nullable: false),
                    Value = table.Column<string>(type: "nvarchar(max)", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_AspNetUserTokens", x => new { x.UserId, x.LoginProvider, x.Name });
                    table.ForeignKey(
                        name: "FK_AspNetUserTokens_AspNetUsers_UserId",
                        column: x => x.UserId,
                        principalTable: "AspNetUsers",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "Perdoruesi",
                columns: table => new
                {
                    UserId = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Emri = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Mbiemri = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Email = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Username = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    AspNetUserId = table.Column<string>(type: "nvarchar(450)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Perdoruesi", x => x.UserId);
                    table.ForeignKey(
                        name: "FK_Perdoruesi_AspNetUsers_AspNetUserId",
                        column: x => x.AspNetUserId,
                        principalTable: "AspNetUsers",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "Produkti",
                columns: table => new
                {
                    ProduktiId = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    EmriProduktit = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Pershkrimi = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    FotoProduktit = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    KompaniaId = table.Column<int>(type: "int", nullable: true),
                    KategoriaId = table.Column<int>(type: "int", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Produkti", x => x.ProduktiId);
                    table.ForeignKey(
                        name: "FK_Produkti_KategoriaProduktit_KategoriaId",
                        column: x => x.KategoriaId,
                        principalTable: "KategoriaProduktit",
                        principalColumn: "KategoriaId");
                    table.ForeignKey(
                        name: "FK_Produkti_Kompania_KompaniaId",
                        column: x => x.KompaniaId,
                        principalTable: "Kompania",
                        principalColumn: "KompaniaId");
                });

            migrationBuilder.CreateTable(
                name: "ContactForm",
                columns: table => new
                {
                    MesazhiId = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    UserId = table.Column<int>(type: "int", nullable: true),
                    Mesazhi = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    DataDergeses = table.Column<DateTime>(type: "datetime2", nullable: true),
                    Statusi = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Emri = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Email = table.Column<string>(type: "nvarchar(max)", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_ContactForm", x => x.MesazhiId);
                    table.ForeignKey(
                        name: "FK_ContactForm_Perdoruesi_UserId",
                        column: x => x.UserId,
                        principalTable: "Perdoruesi",
                        principalColumn: "UserId");
                });

            migrationBuilder.CreateTable(
                name: "Porosit",
                columns: table => new
                {
                    IdPorosia = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    TotaliPorosis = table.Column<decimal>(type: "decimal(18,2)", nullable: true),
                    DataPorosis = table.Column<DateTime>(type: "datetime2", nullable: true),
                    StatusiPorosis = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    IdKlienti = table.Column<int>(type: "int", nullable: true),
                    Zbritja = table.Column<decimal>(type: "decimal(18,2)", nullable: true),
                    TotaliProdukteve = table.Column<int>(type: "int", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Porosit", x => x.IdPorosia);
                    table.ForeignKey(
                        name: "FK_Porosit_Perdoruesi_IdKlienti",
                        column: x => x.IdKlienti,
                        principalTable: "Perdoruesi",
                        principalColumn: "UserId");
                });

            migrationBuilder.CreateTable(
                name: "RegjistrimiStokut",
                columns: table => new
                {
                    IdRegjistrimit = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    DataRegjistrimit = table.Column<DateTime>(type: "datetime2", nullable: true),
                    StafiId = table.Column<int>(type: "int", nullable: true),
                    TotaliProdukteveRegjistruara = table.Column<int>(type: "int", nullable: true),
                    ShumaTotaleRegjistrimit = table.Column<decimal>(type: "decimal(18,2)", nullable: true),
                    ShumaTotaleBlerese = table.Column<decimal>(type: "decimal(18,2)", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_RegjistrimiStokut", x => x.IdRegjistrimit);
                    table.ForeignKey(
                        name: "FK_RegjistrimiStokut_Perdoruesi_StafiId",
                        column: x => x.StafiId,
                        principalTable: "Perdoruesi",
                        principalColumn: "UserId");
                });

            migrationBuilder.CreateTable(
                name: "TeDhenatPerdoruesit",
                columns: table => new
                {
                    TeDhenatId = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    UserId = table.Column<int>(type: "int", nullable: false),
                    NrKontaktit = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Qyteti = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    ZipKodi = table.Column<int>(type: "int", nullable: true),
                    Adresa = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Shteti = table.Column<string>(type: "nvarchar(max)", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_TeDhenatPerdoruesit", x => x.TeDhenatId);
                    table.ForeignKey(
                        name: "FK_TeDhenatPerdoruesit_Perdoruesi_UserId",
                        column: x => x.UserId,
                        principalTable: "Perdoruesi",
                        principalColumn: "UserId",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "KodiZbritjes",
                columns: table => new
                {
                    Kodi = table.Column<string>(type: "nvarchar(450)", nullable: false),
                    DataKrijimit = table.Column<DateTime>(type: "datetime2", nullable: true),
                    QmimiZbritjes = table.Column<decimal>(type: "decimal(18,2)", nullable: true),
                    IdProdukti = table.Column<int>(type: "int", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_KodiZbritjes", x => x.Kodi);
                    table.ForeignKey(
                        name: "FK_KodiZbritjes_Produkti_IdProdukti",
                        column: x => x.IdProdukti,
                        principalTable: "Produkti",
                        principalColumn: "ProduktiId");
                });

            migrationBuilder.CreateTable(
                name: "StokuQmimiProduktit",
                columns: table => new
                {
                    StokuID = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    ProduktiId = table.Column<int>(type: "int", nullable: false),
                    SasiaNeStok = table.Column<int>(type: "int", nullable: true),
                    QmimiBleres = table.Column<decimal>(type: "decimal(18,2)", nullable: true),
                    QmimiProduktit = table.Column<decimal>(type: "decimal(18,2)", nullable: true),
                    DataKrijimit = table.Column<DateTime>(type: "datetime2", nullable: true),
                    DataPerditsimit = table.Column<DateTime>(type: "datetime2", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_StokuQmimiProduktit", x => x.StokuID);
                    table.ForeignKey(
                        name: "FK_StokuQmimiProduktit_Produkti_ProduktiId",
                        column: x => x.ProduktiId,
                        principalTable: "Produkti",
                        principalColumn: "ProduktiId",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "ZbritjaQmimitProduktit",
                columns: table => new
                {
                    ZbritjaID = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    ProduktiId = table.Column<int>(type: "int", nullable: false),
                    QmimiPaZbritjeProduktit = table.Column<decimal>(type: "decimal(18,2)", nullable: true),
                    QmimiMeZbritjeProduktit = table.Column<decimal>(type: "decimal(18,2)", nullable: true),
                    DataZbritjes = table.Column<DateTime>(type: "datetime2", nullable: true),
                    DataSkadimit = table.Column<DateTime>(type: "datetime2", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_ZbritjaQmimitProduktit", x => x.ZbritjaID);
                    table.ForeignKey(
                        name: "FK_ZbritjaQmimitProduktit_Produkti_ProduktiId",
                        column: x => x.ProduktiId,
                        principalTable: "Produkti",
                        principalColumn: "ProduktiId",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "TeDhenatEPorosis",
                columns: table => new
                {
                    IdDetajet = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    QmimiTotal = table.Column<decimal>(type: "decimal(18,2)", nullable: true),
                    SasiaPorositur = table.Column<int>(type: "int", nullable: true),
                    IdPorosia = table.Column<int>(type: "int", nullable: true),
                    IdProdukti = table.Column<int>(type: "int", nullable: true),
                    QmimiProduktit = table.Column<decimal>(type: "decimal(18,2)", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_TeDhenatEPorosis", x => x.IdDetajet);
                    table.ForeignKey(
                        name: "FK_TeDhenatEPorosis_Porosit_IdPorosia",
                        column: x => x.IdPorosia,
                        principalTable: "Porosit",
                        principalColumn: "IdPorosia");
                    table.ForeignKey(
                        name: "FK_TeDhenatEPorosis_Produkti_IdProdukti",
                        column: x => x.IdProdukti,
                        principalTable: "Produkti",
                        principalColumn: "ProduktiId");
                });

            migrationBuilder.CreateTable(
                name: "TeDhenatRegjistrimit",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    IdRegjistrimit = table.Column<int>(type: "int", nullable: true),
                    IdProduktit = table.Column<int>(type: "int", nullable: true),
                    SasiaStokut = table.Column<int>(type: "int", nullable: true),
                    QmimiBleres = table.Column<decimal>(type: "decimal(18,2)", nullable: true),
                    QmimiShites = table.Column<decimal>(type: "decimal(18,2)", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_TeDhenatRegjistrimit", x => x.Id);
                    table.ForeignKey(
                        name: "FK_TeDhenatRegjistrimit_Produkti_IdProduktit",
                        column: x => x.IdProduktit,
                        principalTable: "Produkti",
                        principalColumn: "ProduktiId");
                    table.ForeignKey(
                        name: "FK_TeDhenatRegjistrimit_RegjistrimiStokut_IdRegjistrimit",
                        column: x => x.IdRegjistrimit,
                        principalTable: "RegjistrimiStokut",
                        principalColumn: "IdRegjistrimit");
                });

            migrationBuilder.CreateIndex(
                name: "IX_AspNetRoleClaims_RoleId",
                table: "AspNetRoleClaims",
                column: "RoleId");

            migrationBuilder.CreateIndex(
                name: "RoleNameIndex",
                table: "AspNetRoles",
                column: "NormalizedName",
                unique: true,
                filter: "[NormalizedName] IS NOT NULL");

            migrationBuilder.CreateIndex(
                name: "IX_AspNetUserClaims_UserId",
                table: "AspNetUserClaims",
                column: "UserId");

            migrationBuilder.CreateIndex(
                name: "IX_AspNetUserLogins_UserId",
                table: "AspNetUserLogins",
                column: "UserId");

            migrationBuilder.CreateIndex(
                name: "IX_AspNetUserRoles_RoleId",
                table: "AspNetUserRoles",
                column: "RoleId");

            migrationBuilder.CreateIndex(
                name: "EmailIndex",
                table: "AspNetUsers",
                column: "NormalizedEmail");

            migrationBuilder.CreateIndex(
                name: "UserNameIndex",
                table: "AspNetUsers",
                column: "NormalizedUserName",
                unique: true,
                filter: "[NormalizedUserName] IS NOT NULL");

            migrationBuilder.CreateIndex(
                name: "IX_ContactForm_UserId",
                table: "ContactForm",
                column: "UserId");

            migrationBuilder.CreateIndex(
                name: "IX_KodiZbritjes_IdProdukti",
                table: "KodiZbritjes",
                column: "IdProdukti");

            migrationBuilder.CreateIndex(
                name: "IX_Perdoruesi_AspNetUserId",
                table: "Perdoruesi",
                column: "AspNetUserId");

            migrationBuilder.CreateIndex(
                name: "IX_Porosit_IdKlienti",
                table: "Porosit",
                column: "IdKlienti");

            migrationBuilder.CreateIndex(
                name: "IX_Produkti_KategoriaId",
                table: "Produkti",
                column: "KategoriaId");

            migrationBuilder.CreateIndex(
                name: "IX_Produkti_KompaniaId",
                table: "Produkti",
                column: "KompaniaId");

            migrationBuilder.CreateIndex(
                name: "IX_RegjistrimiStokut_StafiId",
                table: "RegjistrimiStokut",
                column: "StafiId");

            migrationBuilder.CreateIndex(
                name: "IX_StokuQmimiProduktit_ProduktiId",
                table: "StokuQmimiProduktit",
                column: "ProduktiId",
                unique: true);

            migrationBuilder.CreateIndex(
                name: "IX_TeDhenatEPorosis_IdPorosia",
                table: "TeDhenatEPorosis",
                column: "IdPorosia");

            migrationBuilder.CreateIndex(
                name: "IX_TeDhenatEPorosis_IdProdukti",
                table: "TeDhenatEPorosis",
                column: "IdProdukti");

            migrationBuilder.CreateIndex(
                name: "IX_TeDhenatPerdoruesit_UserId",
                table: "TeDhenatPerdoruesit",
                column: "UserId",
                unique: true);

            migrationBuilder.CreateIndex(
                name: "IX_TeDhenatRegjistrimit_IdProduktit",
                table: "TeDhenatRegjistrimit",
                column: "IdProduktit");

            migrationBuilder.CreateIndex(
                name: "IX_TeDhenatRegjistrimit_IdRegjistrimit",
                table: "TeDhenatRegjistrimit",
                column: "IdRegjistrimit");

            migrationBuilder.CreateIndex(
                name: "IX_ZbritjaQmimitProduktit_ProduktiId",
                table: "ZbritjaQmimitProduktit",
                column: "ProduktiId",
                unique: true);
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "AspNetRoleClaims");

            migrationBuilder.DropTable(
                name: "AspNetUserClaims");

            migrationBuilder.DropTable(
                name: "AspNetUserLogins");

            migrationBuilder.DropTable(
                name: "AspNetUserRoles");

            migrationBuilder.DropTable(
                name: "AspNetUserTokens");

            migrationBuilder.DropTable(
                name: "ContactForm");

            migrationBuilder.DropTable(
                name: "KodiZbritjes");

            migrationBuilder.DropTable(
                name: "StokuQmimiProduktit");

            migrationBuilder.DropTable(
                name: "TeDhenatBiznesit");

            migrationBuilder.DropTable(
                name: "TeDhenatEPorosis");

            migrationBuilder.DropTable(
                name: "TeDhenatPerdoruesit");

            migrationBuilder.DropTable(
                name: "TeDhenatRegjistrimit");

            migrationBuilder.DropTable(
                name: "ZbritjaQmimitProduktit");

            migrationBuilder.DropTable(
                name: "AspNetRoles");

            migrationBuilder.DropTable(
                name: "Porosit");

            migrationBuilder.DropTable(
                name: "RegjistrimiStokut");

            migrationBuilder.DropTable(
                name: "Produkti");

            migrationBuilder.DropTable(
                name: "Perdoruesi");

            migrationBuilder.DropTable(
                name: "KategoriaProduktit");

            migrationBuilder.DropTable(
                name: "Kompania");

            migrationBuilder.DropTable(
                name: "AspNetUsers");
        }
    }
}
