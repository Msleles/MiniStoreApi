using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace MiniStore.Infra.Data.Migrations
{
    public partial class AddIdentityTables : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "Categorias",
                keyColumn: "Id",
                keyValue: new Guid("0492a3fd-30d8-451a-909d-c22641403aea"));

            migrationBuilder.DeleteData(
                table: "Categorias",
                keyColumn: "Id",
                keyValue: new Guid("0a0cf76c-8b09-4709-9fde-d23c1ea2e36f"));

            migrationBuilder.DeleteData(
                table: "Categorias",
                keyColumn: "Id",
                keyValue: new Guid("0ba2ff4b-6da9-464e-a7ee-d710289adeb2"));

            migrationBuilder.DeleteData(
                table: "Categorias",
                keyColumn: "Id",
                keyValue: new Guid("1be3b858-5403-4152-8585-b0d885cc97b0"));

            migrationBuilder.DeleteData(
                table: "Categorias",
                keyColumn: "Id",
                keyValue: new Guid("1fd695c7-538b-469a-ab60-977fad4bfabd"));

            migrationBuilder.DeleteData(
                table: "Categorias",
                keyColumn: "Id",
                keyValue: new Guid("5de8b1aa-f39c-4366-ad44-194a15eaa2b5"));

            migrationBuilder.DeleteData(
                table: "Categorias",
                keyColumn: "Id",
                keyValue: new Guid("672bf0e7-7989-4785-9525-e04db092fdbb"));

            migrationBuilder.DeleteData(
                table: "Categorias",
                keyColumn: "Id",
                keyValue: new Guid("791007c1-a2ac-480c-a317-fcacd75abea5"));

            migrationBuilder.DeleteData(
                table: "Categorias",
                keyColumn: "Id",
                keyValue: new Guid("7a8937be-89e5-4570-be15-e2c3a78b5784"));

            migrationBuilder.DeleteData(
                table: "Categorias",
                keyColumn: "Id",
                keyValue: new Guid("81c2cd72-e135-4c55-8bbf-6dfeb31771d8"));

            migrationBuilder.DeleteData(
                table: "Categorias",
                keyColumn: "Id",
                keyValue: new Guid("8f9c3a30-f260-43f5-a593-f79b111da4cd"));

            migrationBuilder.DeleteData(
                table: "Categorias",
                keyColumn: "Id",
                keyValue: new Guid("90cf3b67-ecdc-46fc-b928-a3c5b172517f"));

            migrationBuilder.DeleteData(
                table: "Categorias",
                keyColumn: "Id",
                keyValue: new Guid("ab2cfa62-d057-4102-a742-85e5de808059"));

            migrationBuilder.DeleteData(
                table: "Categorias",
                keyColumn: "Id",
                keyValue: new Guid("aca3fe74-533d-442f-92f8-7891c1b33cf1"));

            migrationBuilder.DeleteData(
                table: "Categorias",
                keyColumn: "Id",
                keyValue: new Guid("bae87c48-0df0-472f-bc09-f032230985c4"));

            migrationBuilder.DeleteData(
                table: "Categorias",
                keyColumn: "Id",
                keyValue: new Guid("d1d16f75-5c55-49b6-a991-31073d6e975f"));

            migrationBuilder.DeleteData(
                table: "Categorias",
                keyColumn: "Id",
                keyValue: new Guid("fad8f66a-b503-41bc-b88d-cf1930abff50"));

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

            migrationBuilder.InsertData(
                table: "Categorias",
                columns: new[] { "Id", "DataCadastro", "Nome", "Status" },
                values: new object[,]
                {
                    { new Guid("04de1232-e6fb-4412-93d4-ac1fad5e4d7e"), new DateTimeOffset(new DateTime(2023, 6, 10, 21, 0, 0, 413, DateTimeKind.Unspecified).AddTicks(7949), new TimeSpan(0, -3, 0, 0, 0)), "Brinquedos e Jogos", true },
                    { new Guid("0a267592-1a0a-4807-a94c-8e32a407ae98"), new DateTimeOffset(new DateTime(2023, 6, 10, 21, 0, 0, 413, DateTimeKind.Unspecified).AddTicks(7913), new TimeSpan(0, -3, 0, 0, 0)), "Casa e Decoração", true },
                    { new Guid("10162243-0a4c-47a6-b940-caf34c0b5950"), new DateTimeOffset(new DateTime(2023, 6, 10, 21, 0, 0, 413, DateTimeKind.Unspecified).AddTicks(7961), new TimeSpan(0, -3, 0, 0, 0)), "Móveis", true },
                    { new Guid("13a4d3cb-2b6e-42e5-bf44-ce2f7e07612d"), new DateTimeOffset(new DateTime(2023, 6, 10, 21, 0, 0, 413, DateTimeKind.Unspecified).AddTicks(7909), new TimeSpan(0, -3, 0, 0, 0)), "Roupas e Moda", true },
                    { new Guid("2169db18-8c7e-413f-86c4-db01e5e17725"), new DateTimeOffset(new DateTime(2023, 6, 10, 21, 0, 0, 413, DateTimeKind.Unspecified).AddTicks(7952), new TimeSpan(0, -3, 0, 0, 0)), "Livros e Mídia", true },
                    { new Guid("2f1bb71a-f70b-4d41-8cf0-8f2f4430f1fe"), new DateTimeOffset(new DateTime(2023, 6, 10, 21, 0, 0, 413, DateTimeKind.Unspecified).AddTicks(7965), new TimeSpan(0, -3, 0, 0, 0)), "Joias e Acessórios", true },
                    { new Guid("3e8dee24-055a-4501-bc00-db3de1bc0dc5"), new DateTimeOffset(new DateTime(2023, 6, 10, 21, 0, 0, 413, DateTimeKind.Unspecified).AddTicks(7973), new TimeSpan(0, -3, 0, 0, 0)), "Instrumentos Musicais", true },
                    { new Guid("678f429f-9f73-4f79-b926-abae47a8a6fa"), new DateTimeOffset(new DateTime(2023, 6, 10, 21, 0, 0, 413, DateTimeKind.Unspecified).AddTicks(7902), new TimeSpan(0, -3, 0, 0, 0)), "Eletrônicos", true },
                    { new Guid("8610348f-3da7-4354-b6f0-e24e332bf08f"), new DateTimeOffset(new DateTime(2023, 6, 10, 21, 0, 0, 413, DateTimeKind.Unspecified).AddTicks(7941), new TimeSpan(0, -3, 0, 0, 0)), "Automotivo", true },
                    { new Guid("92b38264-7c81-4dba-8b01-f7dbaf17391f"), new DateTimeOffset(new DateTime(2023, 6, 10, 21, 0, 0, 413, DateTimeKind.Unspecified).AddTicks(7976), new TimeSpan(0, -3, 0, 0, 0)), "Pet Shop e Animais de Estimação", true },
                    { new Guid("99b6adc5-f778-43a0-bf94-5a672821e9a9"), new DateTimeOffset(new DateTime(2023, 6, 10, 21, 0, 0, 413, DateTimeKind.Unspecified).AddTicks(7872), new TimeSpan(0, -3, 0, 0, 0)), "Material Escolar", true },
                    { new Guid("9d3c816f-63db-4ed9-a37e-3eb98db5fcf1"), new DateTimeOffset(new DateTime(2023, 6, 10, 21, 0, 0, 413, DateTimeKind.Unspecified).AddTicks(7955), new TimeSpan(0, -3, 0, 0, 0)), "Saúde e Bem-Estar", true },
                    { new Guid("9e5ed83a-5d48-4722-a9e3-527eb37380f9"), new DateTimeOffset(new DateTime(2023, 6, 10, 21, 0, 0, 413, DateTimeKind.Unspecified).AddTicks(7945), new TimeSpan(0, -3, 0, 0, 0)), "Esportes e Atividades ao Ar Livre", true },
                    { new Guid("b09d1ce6-26ec-4a2d-98c2-8fe2dbbd4b2a"), new DateTimeOffset(new DateTime(2023, 6, 10, 21, 0, 0, 413, DateTimeKind.Unspecified).AddTicks(7921), new TimeSpan(0, -3, 0, 0, 0)), "Beleza e Cuidados Pessoais", true },
                    { new Guid("bb59a24e-b47a-4bc2-b827-3944c9e4cc9d"), new DateTimeOffset(new DateTime(2023, 6, 10, 21, 0, 0, 413, DateTimeKind.Unspecified).AddTicks(7905), new TimeSpan(0, -3, 0, 0, 0)), "Acessórios", true },
                    { new Guid("ddc6d764-969c-453e-bdc4-26e2f8d6501e"), new DateTimeOffset(new DateTime(2023, 6, 10, 21, 0, 0, 413, DateTimeKind.Unspecified).AddTicks(7958), new TimeSpan(0, -3, 0, 0, 0)), "Ferramentas e Equipamentos", true },
                    { new Guid("ffc41ace-6138-4f57-839a-bb946b99715a"), new DateTimeOffset(new DateTime(2023, 6, 10, 21, 0, 0, 413, DateTimeKind.Unspecified).AddTicks(7918), new TimeSpan(0, -3, 0, 0, 0)), "Alimentos e Bebidas", true }
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
        }

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
                name: "AspNetRoles");

            migrationBuilder.DropTable(
                name: "AspNetUsers");

            migrationBuilder.DeleteData(
                table: "Categorias",
                keyColumn: "Id",
                keyValue: new Guid("04de1232-e6fb-4412-93d4-ac1fad5e4d7e"));

            migrationBuilder.DeleteData(
                table: "Categorias",
                keyColumn: "Id",
                keyValue: new Guid("0a267592-1a0a-4807-a94c-8e32a407ae98"));

            migrationBuilder.DeleteData(
                table: "Categorias",
                keyColumn: "Id",
                keyValue: new Guid("10162243-0a4c-47a6-b940-caf34c0b5950"));

            migrationBuilder.DeleteData(
                table: "Categorias",
                keyColumn: "Id",
                keyValue: new Guid("13a4d3cb-2b6e-42e5-bf44-ce2f7e07612d"));

            migrationBuilder.DeleteData(
                table: "Categorias",
                keyColumn: "Id",
                keyValue: new Guid("2169db18-8c7e-413f-86c4-db01e5e17725"));

            migrationBuilder.DeleteData(
                table: "Categorias",
                keyColumn: "Id",
                keyValue: new Guid("2f1bb71a-f70b-4d41-8cf0-8f2f4430f1fe"));

            migrationBuilder.DeleteData(
                table: "Categorias",
                keyColumn: "Id",
                keyValue: new Guid("3e8dee24-055a-4501-bc00-db3de1bc0dc5"));

            migrationBuilder.DeleteData(
                table: "Categorias",
                keyColumn: "Id",
                keyValue: new Guid("678f429f-9f73-4f79-b926-abae47a8a6fa"));

            migrationBuilder.DeleteData(
                table: "Categorias",
                keyColumn: "Id",
                keyValue: new Guid("8610348f-3da7-4354-b6f0-e24e332bf08f"));

            migrationBuilder.DeleteData(
                table: "Categorias",
                keyColumn: "Id",
                keyValue: new Guid("92b38264-7c81-4dba-8b01-f7dbaf17391f"));

            migrationBuilder.DeleteData(
                table: "Categorias",
                keyColumn: "Id",
                keyValue: new Guid("99b6adc5-f778-43a0-bf94-5a672821e9a9"));

            migrationBuilder.DeleteData(
                table: "Categorias",
                keyColumn: "Id",
                keyValue: new Guid("9d3c816f-63db-4ed9-a37e-3eb98db5fcf1"));

            migrationBuilder.DeleteData(
                table: "Categorias",
                keyColumn: "Id",
                keyValue: new Guid("9e5ed83a-5d48-4722-a9e3-527eb37380f9"));

            migrationBuilder.DeleteData(
                table: "Categorias",
                keyColumn: "Id",
                keyValue: new Guid("b09d1ce6-26ec-4a2d-98c2-8fe2dbbd4b2a"));

            migrationBuilder.DeleteData(
                table: "Categorias",
                keyColumn: "Id",
                keyValue: new Guid("bb59a24e-b47a-4bc2-b827-3944c9e4cc9d"));

            migrationBuilder.DeleteData(
                table: "Categorias",
                keyColumn: "Id",
                keyValue: new Guid("ddc6d764-969c-453e-bdc4-26e2f8d6501e"));

            migrationBuilder.DeleteData(
                table: "Categorias",
                keyColumn: "Id",
                keyValue: new Guid("ffc41ace-6138-4f57-839a-bb946b99715a"));

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
        }
    }
}
