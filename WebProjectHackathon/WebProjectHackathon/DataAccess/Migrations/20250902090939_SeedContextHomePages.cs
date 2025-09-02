using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

#pragma warning disable CA1814 // Prefer jagged arrays over multidimensional

namespace WebProjectHackathon.DataAccess.Migrations
{
    /// <inheritdoc />
    public partial class SeedContextHomePages : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "CircleContextPagesInfos",
                columns: table => new
                {
                    Id = table.Column<int>(type: "INTEGER", nullable: false)
                        .Annotation("Sqlite:Autoincrement", true),
                    Title = table.Column<string>(type: "TEXT", nullable: false),
                    Description = table.Column<string>(type: "TEXT", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_CircleContextPagesInfos", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "ContextHomePages",
                columns: table => new
                {
                    Id = table.Column<int>(type: "INTEGER", nullable: false)
                        .Annotation("Sqlite:Autoincrement", true),
                    Title = table.Column<string>(type: "TEXT", nullable: false),
                    Description = table.Column<string>(type: "TEXT", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_ContextHomePages", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "MainPanelContexts",
                columns: table => new
                {
                    Id = table.Column<int>(type: "INTEGER", nullable: false)
                        .Annotation("Sqlite:Autoincrement", true),
                    Title = table.Column<string>(type: "TEXT", nullable: false),
                    Context = table.Column<string>(type: "TEXT", nullable: false),
                    CircleContextPagesInfoEntityId = table.Column<int>(type: "INTEGER", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_MainPanelContexts", x => x.Id);
                    table.ForeignKey(
                        name: "FK_MainPanelContexts_CircleContextPagesInfos_CircleContextPagesInfoEntityId",
                        column: x => x.CircleContextPagesInfoEntityId,
                        principalTable: "CircleContextPagesInfos",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.InsertData(
                table: "ContextHomePages",
                columns: new[] { "Id", "Description", "Title" },
                values: new object[,]
                {
                    { 1, "Створює зовнішній інтерфейс сайтів та веб-додатків. Відповідає за вигляд, інтерактивність та коректну роботу веб-сторінок на різних пристроях. Використовує HTML, CSS, JavaScript та сучасні фреймворки.", "Frontend-розробник" },
                    { 2, "Розробляє логіку роботи сервера, баз даних та API, які забезпечують функціонування сайту. Працює з мовами програмування, такими як Python, PHP, Java, та базами даних MySQL або PostgreSQL.", "Backend-розробник" },
                    { 3, "Шукає та адаптує нових спеціалістів, створює комфортну атмосферу у команді, проводить співбесіди та допомагає з розвитком персоналу. Відповідає за побудову сильної корпоративної культури.", "HR Manager" },
                    { 4, "Проектує інтерфейси, роблячи їх зручними, доступними та привабливими для користувачів. Використовує інструменти дизайну, такі як Figma, Adobe XD, та аналізує поведінку користувачів для покращення взаємодії.", "UX/UI Дизайнер" }
                });

            migrationBuilder.CreateIndex(
                name: "IX_MainPanelContexts_CircleContextPagesInfoEntityId",
                table: "MainPanelContexts",
                column: "CircleContextPagesInfoEntityId");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "ContextHomePages");

            migrationBuilder.DropTable(
                name: "MainPanelContexts");

            migrationBuilder.DropTable(
                name: "CircleContextPagesInfos");
        }
    }
}
