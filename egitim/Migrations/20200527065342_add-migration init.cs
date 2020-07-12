using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;

namespace egitim.Migrations
{
    public partial class addmigrationinit : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "admin_table",
                columns: table => new
                {
                    id = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn),
                    kul = table.Column<string>(nullable: true),
                    sifre = table.Column<string>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_admin_table", x => x.id);
                });

            migrationBuilder.CreateTable(
                name: "cevaplar_table",
                columns: table => new
                {
                    id = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn),
                    ogrenci_id = table.Column<int>(nullable: false),
                    konu_id = table.Column<int>(nullable: false),
                    test_id = table.Column<int>(nullable: false),
                    soru_sira = table.Column<int>(nullable: false),
                    a = table.Column<string>(nullable: true),
                    b = table.Column<string>(nullable: true),
                    c = table.Column<string>(nullable: true),
                    d = table.Column<string>(nullable: true),
                    e = table.Column<string>(nullable: true),
                    sonuc = table.Column<string>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_cevaplar_table", x => x.id);
                });

            migrationBuilder.CreateTable(
                name: "dersler_table",
                columns: table => new
                {
                    id = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn),
                    ders = table.Column<string>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_dersler_table", x => x.id);
                });

            migrationBuilder.CreateTable(
                name: "ogrenci_table",
                columns: table => new
                {
                    id = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn),
                    tcno = table.Column<string>(nullable: true),
                    ad = table.Column<string>(nullable: true),
                    soyad = table.Column<string>(nullable: true),
                    telefon = table.Column<string>(nullable: true),
                    dtarih = table.Column<string>(nullable: true),
                    egitim = table.Column<string>(nullable: true),
                    burs = table.Column<string>(nullable: true),
                    onay = table.Column<string>(nullable: true),
                    kayit = table.Column<string>(nullable: true),
                    sube = table.Column<string>(nullable: true),
                    ders_id = table.Column<int>(nullable: false),
                    kul = table.Column<string>(nullable: true),
                    sifre = table.Column<string>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_ogrenci_table", x => x.id);
                });

            migrationBuilder.CreateTable(
                name: "canli_table",
                columns: table => new
                {
                    id = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn),
                    ders_id = table.Column<int>(nullable: false),
                    link = table.Column<string>(nullable: true),
                    tarih = table.Column<string>(nullable: false),
                    derslerid = table.Column<int>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_canli_table", x => x.id);
                    table.ForeignKey(
                        name: "FK_canli_table_dersler_table_derslerid",
                        column: x => x.derslerid,
                        principalTable: "dersler_table",
                        principalColumn: "id",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateTable(
                name: "konular_table",
                columns: table => new
                {
                    id = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn),
                    ders_id = table.Column<int>(nullable: false),
                    konu = table.Column<string>(nullable: true),
                    youtube = table.Column<string>(nullable: true),
                    video = table.Column<string>(nullable: true),
                    dokuman = table.Column<string>(nullable: true),
                    sinav = table.Column<int>(nullable: false),
                    sira = table.Column<int>(nullable: false),
                    derslerid = table.Column<int>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_konular_table", x => x.id);
                    table.ForeignKey(
                        name: "FK_konular_table_dersler_table_derslerid",
                        column: x => x.derslerid,
                        principalTable: "dersler_table",
                        principalColumn: "id",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateTable(
                name: "odev_table",
                columns: table => new
                {
                    id = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn),
                    ders_id = table.Column<int>(nullable: false),
                    konu_id = table.Column<int>(nullable: false),
                    odevs = table.Column<string>(nullable: true),
                    derslerid = table.Column<int>(nullable: true),
                    ogrenciid = table.Column<int>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_odev_table", x => x.id);
                    table.ForeignKey(
                        name: "FK_odev_table_dersler_table_derslerid",
                        column: x => x.derslerid,
                        principalTable: "dersler_table",
                        principalColumn: "id",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_odev_table_ogrenci_table_ogrenciid",
                        column: x => x.ogrenciid,
                        principalTable: "ogrenci_table",
                        principalColumn: "id",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateTable(
                name: "sinav_table",
                columns: table => new
                {
                    id = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn),
                    ders_id = table.Column<int>(nullable: false),
                    konu_id = table.Column<int>(nullable: false),
                    test_id = table.Column<int>(nullable: false),
                    soru_sira = table.Column<int>(nullable: false),
                    soru = table.Column<string>(nullable: true),
                    a = table.Column<string>(nullable: true),
                    b = table.Column<string>(nullable: true),
                    c = table.Column<string>(nullable: true),
                    d = table.Column<string>(nullable: true),
                    e = table.Column<string>(nullable: true),
                    cevap = table.Column<string>(nullable: true),
                    ogrenciid = table.Column<int>(nullable: true),
                    konularid = table.Column<int>(nullable: true),
                    derslerid = table.Column<int>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_sinav_table", x => x.id);
                    table.ForeignKey(
                        name: "FK_sinav_table_dersler_table_derslerid",
                        column: x => x.derslerid,
                        principalTable: "dersler_table",
                        principalColumn: "id",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_sinav_table_konular_table_konularid",
                        column: x => x.konularid,
                        principalTable: "konular_table",
                        principalColumn: "id",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_sinav_table_ogrenci_table_ogrenciid",
                        column: x => x.ogrenciid,
                        principalTable: "ogrenci_table",
                        principalColumn: "id",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateIndex(
                name: "IX_canli_table_derslerid",
                table: "canli_table",
                column: "derslerid");

            migrationBuilder.CreateIndex(
                name: "IX_konular_table_derslerid",
                table: "konular_table",
                column: "derslerid");

            migrationBuilder.CreateIndex(
                name: "IX_odev_table_derslerid",
                table: "odev_table",
                column: "derslerid");

            migrationBuilder.CreateIndex(
                name: "IX_odev_table_ogrenciid",
                table: "odev_table",
                column: "ogrenciid");

            migrationBuilder.CreateIndex(
                name: "IX_sinav_table_derslerid",
                table: "sinav_table",
                column: "derslerid");

            migrationBuilder.CreateIndex(
                name: "IX_sinav_table_konularid",
                table: "sinav_table",
                column: "konularid");

            migrationBuilder.CreateIndex(
                name: "IX_sinav_table_ogrenciid",
                table: "sinav_table",
                column: "ogrenciid");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "admin_table");

            migrationBuilder.DropTable(
                name: "canli_table");

            migrationBuilder.DropTable(
                name: "cevaplar_table");

            migrationBuilder.DropTable(
                name: "odev_table");

            migrationBuilder.DropTable(
                name: "sinav_table");

            migrationBuilder.DropTable(
                name: "konular_table");

            migrationBuilder.DropTable(
                name: "ogrenci_table");

            migrationBuilder.DropTable(
                name: "dersler_table");
        }
    }
}
