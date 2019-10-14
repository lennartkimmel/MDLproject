using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;

namespace MDLproject.Data.Migrations
{
    public partial class TestTest : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Deck_Format_FormatID",
                table: "Deck");

            migrationBuilder.DropForeignKey(
                name: "FK_Deck_User_UserID",
                table: "Deck");

            migrationBuilder.DropPrimaryKey(
                name: "PK_User",
                table: "User");

            migrationBuilder.DropPrimaryKey(
                name: "PK_Format",
                table: "Format");

            migrationBuilder.DropPrimaryKey(
                name: "PK_Deck",
                table: "Deck");

            migrationBuilder.RenameTable(
                name: "User",
                newName: "Users");

            migrationBuilder.RenameTable(
                name: "Format",
                newName: "Formats");

            migrationBuilder.RenameTable(
                name: "Deck",
                newName: "Decks");

            migrationBuilder.RenameIndex(
                name: "IX_Deck_UserID",
                table: "Decks",
                newName: "IX_Decks_UserID");

            migrationBuilder.RenameIndex(
                name: "IX_Deck_FormatID",
                table: "Decks",
                newName: "IX_Decks_FormatID");

            migrationBuilder.AddPrimaryKey(
                name: "PK_Users",
                table: "Users",
                column: "UserID");

            migrationBuilder.AddPrimaryKey(
                name: "PK_Formats",
                table: "Formats",
                column: "FormatID");

            migrationBuilder.AddPrimaryKey(
                name: "PK_Decks",
                table: "Decks",
                column: "DeckID");

            migrationBuilder.CreateTable(
                name: "Standard",
                columns: table => new
                {
                    StandardID = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Standard", x => x.StandardID);
                });

            migrationBuilder.CreateIndex(
                name: "IX_Formats_StandardID",
                table: "Formats",
                column: "StandardID");

            migrationBuilder.AddForeignKey(
                name: "FK_Decks_Formats_FormatID",
                table: "Decks",
                column: "FormatID",
                principalTable: "Formats",
                principalColumn: "FormatID",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_Decks_Users_UserID",
                table: "Decks",
                column: "UserID",
                principalTable: "Users",
                principalColumn: "UserID",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_Formats_Standard_StandardID",
                table: "Formats",
                column: "StandardID",
                principalTable: "Standard",
                principalColumn: "StandardID",
                onDelete: ReferentialAction.Cascade);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Decks_Formats_FormatID",
                table: "Decks");

            migrationBuilder.DropForeignKey(
                name: "FK_Decks_Users_UserID",
                table: "Decks");

            migrationBuilder.DropForeignKey(
                name: "FK_Formats_Standard_StandardID",
                table: "Formats");

            migrationBuilder.DropTable(
                name: "Standard");

            migrationBuilder.DropPrimaryKey(
                name: "PK_Users",
                table: "Users");

            migrationBuilder.DropPrimaryKey(
                name: "PK_Formats",
                table: "Formats");

            migrationBuilder.DropIndex(
                name: "IX_Formats_StandardID",
                table: "Formats");

            migrationBuilder.DropPrimaryKey(
                name: "PK_Decks",
                table: "Decks");

            migrationBuilder.RenameTable(
                name: "Users",
                newName: "User");

            migrationBuilder.RenameTable(
                name: "Formats",
                newName: "Format");

            migrationBuilder.RenameTable(
                name: "Decks",
                newName: "Deck");

            migrationBuilder.RenameIndex(
                name: "IX_Decks_UserID",
                table: "Deck",
                newName: "IX_Deck_UserID");

            migrationBuilder.RenameIndex(
                name: "IX_Decks_FormatID",
                table: "Deck",
                newName: "IX_Deck_FormatID");

            migrationBuilder.AddPrimaryKey(
                name: "PK_User",
                table: "User",
                column: "UserID");

            migrationBuilder.AddPrimaryKey(
                name: "PK_Format",
                table: "Format",
                column: "FormatID");

            migrationBuilder.AddPrimaryKey(
                name: "PK_Deck",
                table: "Deck",
                column: "DeckID");

            migrationBuilder.AddForeignKey(
                name: "FK_Deck_Format_FormatID",
                table: "Deck",
                column: "FormatID",
                principalTable: "Format",
                principalColumn: "FormatID",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_Deck_User_UserID",
                table: "Deck",
                column: "UserID",
                principalTable: "User",
                principalColumn: "UserID",
                onDelete: ReferentialAction.Cascade);
        }
    }
}
