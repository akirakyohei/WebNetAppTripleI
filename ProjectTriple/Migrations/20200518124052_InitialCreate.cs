using Microsoft.EntityFrameworkCore.Migrations;

namespace ProjectTriple.Migrations
{
    public partial class InitialCreate : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "users",
                columns: table => new
                {
                    UserID = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    name = table.Column<string>(type: "NVARCHAR(100)", nullable: true),
                    nationality = table.Column<string>(type: "NVARCHAR(50)", nullable: true),
                    quote = table.Column<string>(type: "NVARCHAR(300)", nullable: true),
                    department = table.Column<string>(type: "NVARCHAR(300)", nullable: true),
                    image1 = table.Column<string>(type: "NVARCHAR(300)", nullable: true),
                    image2 = table.Column<string>(type: "NVARCHAR(300)", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_users", x => x.UserID);
                });

            migrationBuilder.CreateTable(
                name: "achievements",
                columns: table => new
                {
                    AchievementID = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    achieve = table.Column<string>(type: "NVARCHAR(300)", nullable: true),
                    UserId = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_achievements", x => x.AchievementID);
                    table.ForeignKey(
                        name: "FK_achievements_users_UserId",
                        column: x => x.UserId,
                        principalTable: "users",
                        principalColumn: "UserID",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateIndex(
                name: "IX_achievements_UserId",
                table: "achievements",
                column: "UserId");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "achievements");

            migrationBuilder.DropTable(
                name: "users");
        }
    }
}
