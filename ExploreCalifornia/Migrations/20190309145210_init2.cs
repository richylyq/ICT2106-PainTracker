using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;

namespace ExploreCalifornia.Migrations
{
    public partial class init2 : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Area_Entry_EntryID",
                table: "Area");

            migrationBuilder.DropTable(
                name: "Tour");

            migrationBuilder.RenameColumn(
                name: "AreaID",
                table: "Area",
                newName: "PainDetailsID");

            migrationBuilder.AlterColumn<int>(
                name: "EntryID",
                table: "Area",
                nullable: false,
                oldClrType: typeof(int),
                oldNullable: true);

            migrationBuilder.AddForeignKey(
                name: "FK_Area_Entry_EntryID",
                table: "Area",
                column: "EntryID",
                principalTable: "Entry",
                principalColumn: "EntryID",
                onDelete: ReferentialAction.Cascade);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Area_Entry_EntryID",
                table: "Area");

            migrationBuilder.RenameColumn(
                name: "PainDetailsID",
                table: "Area",
                newName: "AreaID");

            migrationBuilder.AlterColumn<int>(
                name: "EntryID",
                table: "Area",
                nullable: true,
                oldClrType: typeof(int));

            migrationBuilder.CreateTable(
                name: "Tour",
                columns: table => new
                {
                    Id = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn),
                    Description = table.Column<string>(nullable: true),
                    IncludesMeals = table.Column<bool>(nullable: false),
                    Length = table.Column<int>(nullable: false),
                    Name = table.Column<string>(nullable: false),
                    Price = table.Column<decimal>(nullable: false),
                    Rating = table.Column<string>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Tour", x => x.Id);
                });

            migrationBuilder.AddForeignKey(
                name: "FK_Area_Entry_EntryID",
                table: "Area",
                column: "EntryID",
                principalTable: "Entry",
                principalColumn: "EntryID",
                onDelete: ReferentialAction.Restrict);
        }
    }
}
