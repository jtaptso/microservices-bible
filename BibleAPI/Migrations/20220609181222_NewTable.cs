using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace BibleAPI.Migrations
{
    public partial class NewTable : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Livre_Bible_BibleId",
                table: "Livre");

            migrationBuilder.DropIndex(
                name: "IX_Livre_BibleId",
                table: "Livre");

            migrationBuilder.DropColumn(
                name: "Text",
                table: "Verset");

            migrationBuilder.DropColumn(
                name: "Titre",
                table: "Verset");

            migrationBuilder.DropColumn(
                name: "BibleId",
                table: "Livre");

            migrationBuilder.DropColumn(
                name: "Auteur",
                table: "Bible");

            migrationBuilder.DropColumn(
                name: "Version",
                table: "Bible");

            migrationBuilder.RenameColumn(
                name: "Testament",
                table: "Livre",
                newName: "TestamentId");

            migrationBuilder.AlterColumn<string>(
                name: "correspondances",
                table: "Verset",
                type: "nvarchar(max)",
                nullable: true,
                oldClrType: typeof(string),
                oldType: "nvarchar(max)",
                oldNullable: true)
                .OldAnnotation("Relational:ColumnOrder", 3);

            migrationBuilder.AlterColumn<int>(
                name: "VersetId",
                table: "Verset",
                type: "int",
                nullable: false,
                oldClrType: typeof(int),
                oldType: "int")
                .Annotation("SqlServer:Identity", "1, 1")
                .OldAnnotation("Relational:ColumnOrder", 0)
                .OldAnnotation("SqlServer:Identity", "1, 1");

            migrationBuilder.AlterColumn<int>(
                name: "LivreId",
                table: "Livre",
                type: "int",
                nullable: false,
                oldClrType: typeof(int),
                oldType: "int")
                .Annotation("SqlServer:Identity", "1, 1")
                .OldAnnotation("Relational:ColumnOrder", 0)
                .OldAnnotation("SqlServer:Identity", "1, 1");

            migrationBuilder.AddColumn<string>(
                name: "Comment",
                table: "Livre",
                type: "nvarchar(max)",
                nullable: true);

            migrationBuilder.AlterColumn<int>(
                name: "ChapitreId",
                table: "Chapitre",
                type: "int",
                nullable: false,
                oldClrType: typeof(int),
                oldType: "int")
                .Annotation("SqlServer:Identity", "1, 1")
                .OldAnnotation("Relational:ColumnOrder", 0)
                .OldAnnotation("SqlServer:Identity", "1, 1");

            migrationBuilder.AlterColumn<int>(
                name: "BibleId",
                table: "Bible",
                type: "int",
                nullable: false,
                oldClrType: typeof(int),
                oldType: "int")
                .Annotation("SqlServer:Identity", "1, 1")
                .OldAnnotation("Relational:ColumnOrder", 0)
                .OldAnnotation("SqlServer:Identity", "1, 1");

            migrationBuilder.CreateTable(
                name: "Languages",
                columns: table => new
                {
                    LanguageId = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Name = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    BibleId = table.Column<int>(type: "int", nullable: false),
                    Comments = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Image = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Songs = table.Column<string>(type: "nvarchar(max)", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Languages", x => x.LanguageId);
                    table.ForeignKey(
                        name: "FK_Languages_Bible_BibleId",
                        column: x => x.BibleId,
                        principalTable: "Bible",
                        principalColumn: "BibleId",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "Versions",
                columns: table => new
                {
                    Name = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Number = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    VersionId = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    VersetId = table.Column<int>(type: "int", nullable: false),
                    Comments = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Image = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Songs = table.Column<string>(type: "nvarchar(max)", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Versions", x => x.VersionId);
                    table.ForeignKey(
                        name: "FK_Versions_Verset_VersetId",
                        column: x => x.VersetId,
                        principalTable: "Verset",
                        principalColumn: "VersetId",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "Testament",
                columns: table => new
                {
                    TestamentId = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Name = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    LanguageId = table.Column<int>(type: "int", nullable: false),
                    Comments = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Image = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Songs = table.Column<string>(type: "nvarchar(max)", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Testament", x => x.TestamentId);
                    table.ForeignKey(
                        name: "FK_Testament_Languages_LanguageId",
                        column: x => x.LanguageId,
                        principalTable: "Languages",
                        principalColumn: "LanguageId",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateIndex(
                name: "IX_Livre_TestamentId",
                table: "Livre",
                column: "TestamentId");

            migrationBuilder.CreateIndex(
                name: "IX_Languages_BibleId",
                table: "Languages",
                column: "BibleId");

            migrationBuilder.CreateIndex(
                name: "IX_Testament_LanguageId",
                table: "Testament",
                column: "LanguageId");

            migrationBuilder.CreateIndex(
                name: "IX_Versions_VersetId",
                table: "Versions",
                column: "VersetId");

            migrationBuilder.AddForeignKey(
                name: "FK_Livre_Testament_TestamentId",
                table: "Livre",
                column: "TestamentId",
                principalTable: "Testament",
                principalColumn: "TestamentId",
                onDelete: ReferentialAction.Cascade);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Livre_Testament_TestamentId",
                table: "Livre");

            migrationBuilder.DropTable(
                name: "Testament");

            migrationBuilder.DropTable(
                name: "Versions");

            migrationBuilder.DropTable(
                name: "Languages");

            migrationBuilder.DropIndex(
                name: "IX_Livre_TestamentId",
                table: "Livre");

            migrationBuilder.DropColumn(
                name: "Comment",
                table: "Livre");

            migrationBuilder.RenameColumn(
                name: "TestamentId",
                table: "Livre",
                newName: "Testament");

            migrationBuilder.AlterColumn<string>(
                name: "correspondances",
                table: "Verset",
                type: "nvarchar(max)",
                nullable: true,
                oldClrType: typeof(string),
                oldType: "nvarchar(max)",
                oldNullable: true)
                .Annotation("Relational:ColumnOrder", 3);

            migrationBuilder.AlterColumn<int>(
                name: "VersetId",
                table: "Verset",
                type: "int",
                nullable: false,
                oldClrType: typeof(int),
                oldType: "int")
                .Annotation("Relational:ColumnOrder", 0)
                .Annotation("SqlServer:Identity", "1, 1")
                .OldAnnotation("SqlServer:Identity", "1, 1");

            migrationBuilder.AddColumn<string>(
                name: "Text",
                table: "Verset",
                type: "nvarchar(max)",
                nullable: false,
                defaultValue: "")
                .Annotation("Relational:ColumnOrder", 2);

            migrationBuilder.AddColumn<string>(
                name: "Titre",
                table: "Verset",
                type: "nvarchar(max)",
                nullable: true);

            migrationBuilder.AlterColumn<int>(
                name: "LivreId",
                table: "Livre",
                type: "int",
                nullable: false,
                oldClrType: typeof(int),
                oldType: "int")
                .Annotation("Relational:ColumnOrder", 0)
                .Annotation("SqlServer:Identity", "1, 1")
                .OldAnnotation("SqlServer:Identity", "1, 1");

            migrationBuilder.AddColumn<int>(
                name: "BibleId",
                table: "Livre",
                type: "int",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.AlterColumn<int>(
                name: "ChapitreId",
                table: "Chapitre",
                type: "int",
                nullable: false,
                oldClrType: typeof(int),
                oldType: "int")
                .Annotation("Relational:ColumnOrder", 0)
                .Annotation("SqlServer:Identity", "1, 1")
                .OldAnnotation("SqlServer:Identity", "1, 1");

            migrationBuilder.AlterColumn<int>(
                name: "BibleId",
                table: "Bible",
                type: "int",
                nullable: false,
                oldClrType: typeof(int),
                oldType: "int")
                .Annotation("Relational:ColumnOrder", 0)
                .Annotation("SqlServer:Identity", "1, 1")
                .OldAnnotation("SqlServer:Identity", "1, 1");

            migrationBuilder.AddColumn<string>(
                name: "Auteur",
                table: "Bible",
                type: "nvarchar(max)",
                nullable: true)
                .Annotation("Relational:ColumnOrder", 1);

            migrationBuilder.AddColumn<string>(
                name: "Version",
                table: "Bible",
                type: "nvarchar(max)",
                nullable: true)
                .Annotation("Relational:ColumnOrder", 2);

            migrationBuilder.CreateIndex(
                name: "IX_Livre_BibleId",
                table: "Livre",
                column: "BibleId");

            migrationBuilder.AddForeignKey(
                name: "FK_Livre_Bible_BibleId",
                table: "Livre",
                column: "BibleId",
                principalTable: "Bible",
                principalColumn: "BibleId",
                onDelete: ReferentialAction.Cascade);
        }
    }
}
