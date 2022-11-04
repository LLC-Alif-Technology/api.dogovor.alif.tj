using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace ConnectionProvider.Migrations
{
    public partial class init : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "ActVariationsOfCompletions",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Variation = table.Column<string>(type: "nvarchar(max)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_ActVariationsOfCompletions", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "Agents",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    AgentLocation = table.Column<string>(type: "nvarchar(max)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Agents", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "AgreementConcluders",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    ConcluderName = table.Column<string>(type: "nvarchar(max)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_AgreementConcluders", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "AgreementEntities",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    EntityName = table.Column<string>(type: "nvarchar(max)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_AgreementEntities", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "Archives",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Date = table.Column<DateTime>(type: "datetime2", nullable: false),
                    ContractName = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    ExecutorsEmail = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    ExecutorsFullName = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    DocumentType = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    FilePath = table.Column<string>(type: "nvarchar(max)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Archives", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "Categories",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    CategoryName = table.Column<string>(type: "nvarchar(max)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Categories", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "Citizenships",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    CitizenshipName = table.Column<string>(type: "nvarchar(max)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Citizenships", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "City",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    CityName = table.Column<string>(type: "nvarchar(max)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_City", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "PartialPaymentOrderNames",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    PartialPaymentName = table.Column<string>(type: "nvarchar(max)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_PartialPaymentOrderNames", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "PassportTypes",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    PassportTypeName = table.Column<string>(type: "nvarchar(max)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_PassportTypes", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "PaymentOrders",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    PaymentOrderName = table.Column<string>(type: "nvarchar(max)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_PaymentOrders", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "PaymentTerms",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    TermText = table.Column<string>(type: "nvarchar(max)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_PaymentTerms", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "RendedServicesVariations",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    RendedServiceName = table.Column<string>(type: "nvarchar(max)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_RendedServicesVariations", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "Roles",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    RoleName = table.Column<string>(type: "nvarchar(max)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Roles", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "Services",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    ServiceName = table.Column<string>(type: "nvarchar(max)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Services", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "StructuralSubdivisions",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    SubdivisionName = table.Column<string>(type: "nvarchar(max)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_StructuralSubdivisions", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "TrustieFoundations",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    FoundationName = table.Column<string>(type: "nvarchar(max)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_TrustieFoundations", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "SubCategories",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    SubCategoryName = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    SampleInstance = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    CategoryId = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_SubCategories", x => x.Id);
                    table.ForeignKey(
                        name: "FK_SubCategories_Categories_CategoryId",
                        column: x => x.CategoryId,
                        principalTable: "Categories",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "Users",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    FirstName = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    LastName = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    EmailAddress = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Password = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    RoleId = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Users", x => x.Id);
                    table.ForeignKey(
                        name: "FK_Users_Roles_RoleId",
                        column: x => x.RoleId,
                        principalTable: "Roles",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "UserCodes",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    RandomNumber = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    ValidDate = table.Column<DateTime>(type: "datetime2", nullable: true),
                    UserId = table.Column<int>(type: "int", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_UserCodes", x => x.Id);
                    table.ForeignKey(
                        name: "FK_UserCodes_Users_UserId",
                        column: x => x.UserId,
                        principalTable: "Users",
                        principalColumn: "Id");
                });

            migrationBuilder.InsertData(
                table: "ActVariationsOfCompletions",
                columns: new[] { "Id", "Variation" },
                values: new object[,]
                {
                    { 1, "Качество оказанных Услуг соответствует предъявленным требованиям" },
                    { 2, "В результате осмотра результата оказанных Услуг недостатки не выявлены" },
                    { 3, "В результате осмотра выявлены следующие недостатки" }
                });

            migrationBuilder.InsertData(
                table: "Agents",
                columns: new[] { "Id", "AgentLocation" },
                values: new object[,]
                {
                    { 1, "Aгент находится в Душанбе " },
                    { 2, "Агент находится в Худжанде" }
                });

            migrationBuilder.InsertData(
                table: "AgreementConcluders",
                columns: new[] { "Id", "ConcluderName" },
                values: new object[,]
                {
                    { 1, "Договор заключает головной офис" },
                    { 2, "Договор заключает филиал Банка в г. Душанбе" },
                    { 3, "Договор заключает филиал Банка в г. Худжанде" }
                });

            migrationBuilder.InsertData(
                table: "AgreementEntities",
                columns: new[] { "Id", "EntityName" },
                values: new object[,]
                {
                    { 1, "Юридическое лицо" },
                    { 2, "Индивидуальный предприниматель" },
                    { 3, "Физическое лицо" }
                });

            migrationBuilder.InsertData(
                table: "Citizenships",
                columns: new[] { "Id", "CitizenshipName" },
                values: new object[] { 1, "Шахрванди Чумхурии Точикистон" });

            migrationBuilder.InsertData(
                table: "City",
                columns: new[] { "Id", "CityName" },
                values: new object[] { 1, "г. Душанбе" });

            migrationBuilder.InsertData(
                table: "PartialPaymentOrderNames",
                columns: new[] { "Id", "PartialPaymentName" },
                values: new object[,]
                {
                    { 1, "Первый платеж в сомони" },
                    { 2, "Первый платеж в процентах" },
                    { 3, "Второй платеж в сомони" },
                    { 4, "Второй платеж в процентах" }
                });

            migrationBuilder.InsertData(
                table: "PassportTypes",
                columns: new[] { "Id", "PassportTypeName" },
                values: new object[] { 1, "Шиноснома" });

            migrationBuilder.InsertData(
                table: "PaymentOrders",
                columns: new[] { "Id", "PaymentOrderName" },
                values: new object[,]
                {
                    { 1, "Налично" },
                    { 2, "Безналично" }
                });

            migrationBuilder.InsertData(
                table: "PaymentTerms",
                columns: new[] { "Id", "TermText" },
                values: new object[,]
                {
                    { 1, "Агар дар гуфтушунидҳо ба ҳамфикрӣ ноил нашаванд, баҳс бояд дар суди иқтисодии ш. Душанбе аз рӯи маҳалли воқеъ гардидани Исполнитель баррасӣ карда шавад." },
                    { 2, "Агар дар гуфтушунидҳо ба ҳамфикрӣ ноил нашаванд, баҳс бояд дар суди иқтисодии ш. Хучанд аз рӯи маҳалли воқеъ гардидани Исполнитель баррасӣ карда шавад." },
                    { 3, "Агар дар гуфтушунидҳо ба ҳамфикрӣ ноил нашаванд, баҳс бояд дар суди ш. Душанбе аз рӯи маҳалли воқеъ гардидани Исполнитель баррасӣ карда шавад." },
                    { 4, "Агар дар гуфтушунидҳо ба ҳамфикрӣ ноил нашаванд, баҳс бояд дар суди ш. Хучанд аз рӯи маҳалли воқеъ гардидани Исполнитель баррасӣ карда шавад." }
                });

            migrationBuilder.InsertData(
                table: "RendedServicesVariations",
                columns: new[] { "Id", "RendedServiceName" },
                values: new object[,]
                {
                    { 1, "Головной - улица Багауддинова" },
                    { 2, "Филиал в Душанбе - улица Ниёзи" },
                    { 3, "Филиал в Худжанде - улицу не помню" }
                });

            migrationBuilder.InsertData(
                table: "Roles",
                columns: new[] { "Id", "RoleName" },
                values: new object[,]
                {
                    { 1, "User" },
                    { 2, "Editor" },
                    { 3, "Admin" }
                });

            migrationBuilder.InsertData(
                table: "Services",
                columns: new[] { "Id", "ServiceName" },
                values: new object[,]
                {
                    { 1, "Услуга указывается в самом договоре" },
                    { 2, "Услуга указывается в приложении к Договору" }
                });

            migrationBuilder.InsertData(
                table: "StructuralSubdivisions",
                columns: new[] { "Id", "SubdivisionName" },
                values: new object[] { 1, "Филиали Ҷамъияти саҳомии кушодаи..." });

            migrationBuilder.InsertData(
                table: "TrustieFoundations",
                columns: new[] { "Id", "FoundationName" },
                values: new object[,]
                {
                    { 1, "Доверенность" },
                    { 2, "Устав" }
                });

            migrationBuilder.CreateIndex(
                name: "IX_SubCategories_CategoryId",
                table: "SubCategories",
                column: "CategoryId");

            migrationBuilder.CreateIndex(
                name: "IX_UserCodes_UserId",
                table: "UserCodes",
                column: "UserId");

            migrationBuilder.CreateIndex(
                name: "IX_Users_RoleId",
                table: "Users",
                column: "RoleId");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "ActVariationsOfCompletions");

            migrationBuilder.DropTable(
                name: "Agents");

            migrationBuilder.DropTable(
                name: "AgreementConcluders");

            migrationBuilder.DropTable(
                name: "AgreementEntities");

            migrationBuilder.DropTable(
                name: "Archives");

            migrationBuilder.DropTable(
                name: "Citizenships");

            migrationBuilder.DropTable(
                name: "City");

            migrationBuilder.DropTable(
                name: "PartialPaymentOrderNames");

            migrationBuilder.DropTable(
                name: "PassportTypes");

            migrationBuilder.DropTable(
                name: "PaymentOrders");

            migrationBuilder.DropTable(
                name: "PaymentTerms");

            migrationBuilder.DropTable(
                name: "RendedServicesVariations");

            migrationBuilder.DropTable(
                name: "Services");

            migrationBuilder.DropTable(
                name: "StructuralSubdivisions");

            migrationBuilder.DropTable(
                name: "SubCategories");

            migrationBuilder.DropTable(
                name: "TrustieFoundations");

            migrationBuilder.DropTable(
                name: "UserCodes");

            migrationBuilder.DropTable(
                name: "Categories");

            migrationBuilder.DropTable(
                name: "Users");

            migrationBuilder.DropTable(
                name: "Roles");
        }
    }
}
