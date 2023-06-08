using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace MiniStore.Infra.Data.Migrations
{
    public partial class InitialCreate : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Categorias",
                columns: table => new
                {
                    Id = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    Nome = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: false),
                    Status = table.Column<bool>(type: "bit", nullable: false),
                    DataCadastro = table.Column<DateTimeOffset>(type: "datetimeoffset", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Categorias", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "Produtos",
                columns: table => new
                {
                    Id = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    Nome = table.Column<string>(type: "nvarchar(100)", maxLength: 100, nullable: false),
                    Preco = table.Column<decimal>(type: "decimal(18,2)", precision: 18, scale: 2, nullable: false),
                    CategoriaId = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    Status = table.Column<bool>(type: "bit", nullable: false),
                    DataCadastro = table.Column<DateTimeOffset>(type: "datetimeoffset", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Produtos", x => x.Id);
                    table.ForeignKey(
                        name: "FK_Produtos_Categorias_CategoriaId",
                        column: x => x.CategoriaId,
                        principalTable: "Categorias",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.InsertData(
                table: "Categorias",
                columns: new[] { "Id", "DataCadastro", "Nome", "Status" },
                values: new object[,]
                {
                    { new Guid("0492a3fd-30d8-451a-909d-c22641403aea"), new DateTimeOffset(new DateTime(2023, 6, 8, 13, 51, 38, 493, DateTimeKind.Unspecified).AddTicks(7444), new TimeSpan(0, -3, 0, 0, 0)), "Acessórios", true },
                    { new Guid("0a0cf76c-8b09-4709-9fde-d23c1ea2e36f"), new DateTimeOffset(new DateTime(2023, 6, 8, 13, 51, 38, 493, DateTimeKind.Unspecified).AddTicks(7522), new TimeSpan(0, -3, 0, 0, 0)), "Joias e Acessórios", true },
                    { new Guid("0ba2ff4b-6da9-464e-a7ee-d710289adeb2"), new DateTimeOffset(new DateTime(2023, 6, 8, 13, 51, 38, 493, DateTimeKind.Unspecified).AddTicks(7446), new TimeSpan(0, -3, 0, 0, 0)), "Roupas e Moda", true },
                    { new Guid("1be3b858-5403-4152-8585-b0d885cc97b0"), new DateTimeOffset(new DateTime(2023, 6, 8, 13, 51, 38, 493, DateTimeKind.Unspecified).AddTicks(7450), new TimeSpan(0, -3, 0, 0, 0)), "Alimentos e Bebidas", true },
                    { new Guid("1fd695c7-538b-469a-ab60-977fad4bfabd"), new DateTimeOffset(new DateTime(2023, 6, 8, 13, 51, 38, 493, DateTimeKind.Unspecified).AddTicks(7513), new TimeSpan(0, -3, 0, 0, 0)), "Brinquedos e Jogos", true },
                    { new Guid("5de8b1aa-f39c-4366-ad44-194a15eaa2b5"), new DateTimeOffset(new DateTime(2023, 6, 8, 13, 51, 38, 493, DateTimeKind.Unspecified).AddTicks(7521), new TimeSpan(0, -3, 0, 0, 0)), "Móveis", true },
                    { new Guid("672bf0e7-7989-4785-9525-e04db092fdbb"), new DateTimeOffset(new DateTime(2023, 6, 8, 13, 51, 38, 493, DateTimeKind.Unspecified).AddTicks(7517), new TimeSpan(0, -3, 0, 0, 0)), "Saúde e Bem-Estar", true },
                    { new Guid("791007c1-a2ac-480c-a317-fcacd75abea5"), new DateTimeOffset(new DateTime(2023, 6, 8, 13, 51, 38, 493, DateTimeKind.Unspecified).AddTicks(7528), new TimeSpan(0, -3, 0, 0, 0)), "Pet Shop e Animais de Estimação", true },
                    { new Guid("7a8937be-89e5-4570-be15-e2c3a78b5784"), new DateTimeOffset(new DateTime(2023, 6, 8, 13, 51, 38, 493, DateTimeKind.Unspecified).AddTicks(7411), new TimeSpan(0, -3, 0, 0, 0)), "Material Escolar", true },
                    { new Guid("81c2cd72-e135-4c55-8bbf-6dfeb31771d8"), new DateTimeOffset(new DateTime(2023, 6, 8, 13, 51, 38, 493, DateTimeKind.Unspecified).AddTicks(7515), new TimeSpan(0, -3, 0, 0, 0)), "Livros e Mídia", true },
                    { new Guid("8f9c3a30-f260-43f5-a593-f79b111da4cd"), new DateTimeOffset(new DateTime(2023, 6, 8, 13, 51, 38, 493, DateTimeKind.Unspecified).AddTicks(7524), new TimeSpan(0, -3, 0, 0, 0)), "Instrumentos Musicais", true },
                    { new Guid("90cf3b67-ecdc-46fc-b928-a3c5b172517f"), new DateTimeOffset(new DateTime(2023, 6, 8, 13, 51, 38, 493, DateTimeKind.Unspecified).AddTicks(7442), new TimeSpan(0, -3, 0, 0, 0)), "Eletrônicos", true },
                    { new Guid("ab2cfa62-d057-4102-a742-85e5de808059"), new DateTimeOffset(new DateTime(2023, 6, 8, 13, 51, 38, 493, DateTimeKind.Unspecified).AddTicks(7506), new TimeSpan(0, -3, 0, 0, 0)), "Automotivo", true },
                    { new Guid("aca3fe74-533d-442f-92f8-7891c1b33cf1"), new DateTimeOffset(new DateTime(2023, 6, 8, 13, 51, 38, 493, DateTimeKind.Unspecified).AddTicks(7510), new TimeSpan(0, -3, 0, 0, 0)), "Esportes e Atividades ao Ar Livre", true },
                    { new Guid("bae87c48-0df0-472f-bc09-f032230985c4"), new DateTimeOffset(new DateTime(2023, 6, 8, 13, 51, 38, 493, DateTimeKind.Unspecified).AddTicks(7518), new TimeSpan(0, -3, 0, 0, 0)), "Ferramentas e Equipamentos", true },
                    { new Guid("d1d16f75-5c55-49b6-a991-31073d6e975f"), new DateTimeOffset(new DateTime(2023, 6, 8, 13, 51, 38, 493, DateTimeKind.Unspecified).AddTicks(7504), new TimeSpan(0, -3, 0, 0, 0)), "Beleza e Cuidados Pessoais", true },
                    { new Guid("fad8f66a-b503-41bc-b88d-cf1930abff50"), new DateTimeOffset(new DateTime(2023, 6, 8, 13, 51, 38, 493, DateTimeKind.Unspecified).AddTicks(7448), new TimeSpan(0, -3, 0, 0, 0)), "Casa e Decoração", true }
                });

            migrationBuilder.CreateIndex(
                name: "IX_Produtos_CategoriaId",
                table: "Produtos",
                column: "CategoriaId");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Produtos");

            migrationBuilder.DropTable(
                name: "Categorias");
        }
    }
}
