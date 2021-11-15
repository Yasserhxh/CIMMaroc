using Microsoft.EntityFrameworkCore.Migrations;

namespace Service.Data.Migrations
{
    public partial class Chantier : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Client_Pays_IdPays",
                table: "Client");

            migrationBuilder.DropForeignKey(
                name: "FK_Client_Ville_IdVille",
                table: "Client");

            migrationBuilder.AddColumn<int>(
                name: "IdChantier",
                table: "Commande",
                nullable: true);

            migrationBuilder.AlterColumn<int>(
                name: "IdVille",
                table: "Client",
                nullable: true,
                oldClrType: typeof(int));

            migrationBuilder.AlterColumn<int>(
                name: "IdPays",
                table: "Client",
                nullable: true,
                oldClrType: typeof(int));

            migrationBuilder.UpdateData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "126a635b-d763-48bf-ab0e-f5599cffb4fe",
                column: "ConcurrencyStamp",
                value: "a00ebb55-0192-4f9c-81dd-7d1a296f0d67");

            migrationBuilder.UpdateData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "1588b3b9-37bc-4f58-acf9-e42fd47f1c28",
                column: "ConcurrencyStamp",
                value: "4a9e2ec9-7332-4cb8-b343-96e730bbbdae");

            migrationBuilder.UpdateData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "3e130fc1-981e-4183-a12d-fa5f73d13bb2",
                column: "ConcurrencyStamp",
                value: "4b19da17-edbc-47f4-bbdf-1cd73b39db50");

            migrationBuilder.UpdateData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "48e33a01-bd1f-4739-a27f-126e8e8b2d1c",
                column: "ConcurrencyStamp",
                value: "052219e6-ba77-4d0e-bfc1-cc3cb646cded");

            migrationBuilder.UpdateData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "6eafdfbe-ed07-4687-9d2c-0b767b15a305",
                column: "ConcurrencyStamp",
                value: "d13a58a9-907e-41ce-a6b3-7b2ff2e546b0");

            migrationBuilder.UpdateData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "7b8ab704-463e-4074-8c19-a62905f62e11",
                column: "ConcurrencyStamp",
                value: "90de6d75-74f7-49ff-b66c-76b12b18bb89");

            migrationBuilder.UpdateData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "9be024db-d122-4cd2-8329-2afd0d259e77",
                column: "ConcurrencyStamp",
                value: "3345dc43-6abc-463b-97df-212c60704e8a");

            migrationBuilder.UpdateData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "a7846740-cb77-4d25-8da6-d5c68dfb590d",
                column: "ConcurrencyStamp",
                value: "796ca83d-5909-4428-964e-48b48f9b320a");

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "2e142fe7-a372-4b98-ab9d-dcc4e4966b88",
                columns: new[] { "ConcurrencyStamp", "PasswordHash" },
                values: new object[] { "7461c977-8ed6-422c-92d3-c6764bdf38f1", "AQAAAAEAACcQAAAAEOsRJdL1lNtuN+J6lMQL4E0XKhnOnyGOLJCLVt7hwSCryjST2NXApHgntrtalXnycw==" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "3375dc1e-b359-403e-9f13-5e2b395ffafc",
                columns: new[] { "ConcurrencyStamp", "PasswordHash" },
                values: new object[] { "e36ba7ac-c1a5-49fc-8a61-122454a4f68a", "AQAAAAEAACcQAAAAECIdO3+VfA+5khqhEBEznVwU10qdOSGMloC8eUB+MRumgMw98YQMBKI4zSYj9eHIyg==" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "3e45b10c-0d15-49f2-903b-7de4bbc62f98",
                columns: new[] { "ConcurrencyStamp", "PasswordHash" },
                values: new object[] { "79db0805-6cc0-43af-bae6-c9e261a32ae6", "AQAAAAEAACcQAAAAEF1GQ5wJZHAEVgzIb7y6fwdUHzSwygitATg4EGL7isOhNiEu50n2sEZ0MSQxQq8bag==" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "48e50810-f7fc-45c8-8d13-0a03a6a8b1de",
                columns: new[] { "ConcurrencyStamp", "PasswordHash" },
                values: new object[] { "1617d29a-bf6c-49e1-8611-058e8f1673ca", "AQAAAAEAACcQAAAAEM2lllU4FUjFE3ohNF/4INVnETQBhqeSNhzJIeZkszlYhNCWYO/FWHjbU+X5rvv+ZA==" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "7167d11d-9358-4262-b7a4-77372e1c121d",
                columns: new[] { "ConcurrencyStamp", "PasswordHash" },
                values: new object[] { "85e82f41-486f-4db6-b04e-da5b18484002", "AQAAAAEAACcQAAAAEDhukPqvAYcxwtnq6GgMAdrfiXRZZsfFITpuuuqZJoAUbGcVE42thN4q7NFTgZbqfg==" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "b8888a0f-ebcf-4b0a-815a-83ccc0a4c349",
                columns: new[] { "ConcurrencyStamp", "PasswordHash" },
                values: new object[] { "b8554823-9840-465b-af98-4b56128b43ec", "AQAAAAEAACcQAAAAEPeQxQys6kIqiZRI/MUVE/Xvl03NCiDxwcaxLR9gmYj8xrntJ3cxtL4j36gpW3UzCQ==" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "d19f9bc1-13b4-42b3-881a-a847f4c0684e",
                columns: new[] { "ConcurrencyStamp", "PasswordHash" },
                values: new object[] { "f9377392-2f3f-4b8a-8533-81c9d87d3ea2", "AQAAAAEAACcQAAAAEJlJNSkPcAS+yVwt9Vns6cvYK2GmOslJ87fWRn1ivQT9GRW2xqHpmRqwfrlwd7YryA==" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "fe1300d0-ecf8-4bb5-afaf-5030b27959bd",
                columns: new[] { "ConcurrencyStamp", "PasswordHash" },
                values: new object[] { "331f0338-8040-45f7-8870-cdd0be6a3126", "AQAAAAEAACcQAAAAEB9GzHKIMEqtdmF99dbDJVraGd2lXaQG5iu9RJ6WsyCsQ0j28AdXUFWpZO6nEos8xQ==" });

            migrationBuilder.UpdateData(
                table: "Statut",
                keyColumn: "IdStatut",
                keyValue: 2,
                column: "Libelle",
                value: "Parametrage des prix PBE");

            migrationBuilder.UpdateData(
                table: "Statut",
                keyColumn: "IdStatut",
                keyValue: 5,
                column: "Libelle",
                value: "Parametrage des prix de services");

            migrationBuilder.CreateIndex(
                name: "IX_Commande_IdChantier",
                table: "Commande",
                column: "IdChantier");

            migrationBuilder.AddForeignKey(
                name: "FK_Client_Pays_IdPays",
                table: "Client",
                column: "IdPays",
                principalTable: "Pays",
                principalColumn: "IdPays",
                onDelete: ReferentialAction.Restrict);

            migrationBuilder.AddForeignKey(
                name: "FK_Client_Ville_IdVille",
                table: "Client",
                column: "IdVille",
                principalTable: "Ville",
                principalColumn: "IdVille",
                onDelete: ReferentialAction.Restrict);

            migrationBuilder.AddForeignKey(
                name: "FK_Commande_Chantier_IdChantier",
                table: "Commande",
                column: "IdChantier",
                principalTable: "Chantier",
                principalColumn: "Ctn_Id",
                onDelete: ReferentialAction.Restrict);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Client_Pays_IdPays",
                table: "Client");

            migrationBuilder.DropForeignKey(
                name: "FK_Client_Ville_IdVille",
                table: "Client");

            migrationBuilder.DropForeignKey(
                name: "FK_Commande_Chantier_IdChantier",
                table: "Commande");

            migrationBuilder.DropIndex(
                name: "IX_Commande_IdChantier",
                table: "Commande");

            migrationBuilder.DropColumn(
                name: "IdChantier",
                table: "Commande");

            migrationBuilder.AlterColumn<int>(
                name: "IdVille",
                table: "Client",
                nullable: false,
                oldClrType: typeof(int),
                oldNullable: true);

            migrationBuilder.AlterColumn<int>(
                name: "IdPays",
                table: "Client",
                nullable: false,
                oldClrType: typeof(int),
                oldNullable: true);

            migrationBuilder.UpdateData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "126a635b-d763-48bf-ab0e-f5599cffb4fe",
                column: "ConcurrencyStamp",
                value: "ff39679d-fabd-4461-a219-f2902168e44d");

            migrationBuilder.UpdateData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "1588b3b9-37bc-4f58-acf9-e42fd47f1c28",
                column: "ConcurrencyStamp",
                value: "44db181a-8512-4397-9df1-d7ea6e59f327");

            migrationBuilder.UpdateData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "3e130fc1-981e-4183-a12d-fa5f73d13bb2",
                column: "ConcurrencyStamp",
                value: "6e662914-0071-412d-b7d0-fc35493e2ca9");

            migrationBuilder.UpdateData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "48e33a01-bd1f-4739-a27f-126e8e8b2d1c",
                column: "ConcurrencyStamp",
                value: "94e2b3f0-01ce-4ffb-825f-83999d545710");

            migrationBuilder.UpdateData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "6eafdfbe-ed07-4687-9d2c-0b767b15a305",
                column: "ConcurrencyStamp",
                value: "9fe3e243-09fa-46ae-87e6-6ad64a7f42a7");

            migrationBuilder.UpdateData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "7b8ab704-463e-4074-8c19-a62905f62e11",
                column: "ConcurrencyStamp",
                value: "958b4d79-5adc-4dcd-b603-676084a943e0");

            migrationBuilder.UpdateData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "9be024db-d122-4cd2-8329-2afd0d259e77",
                column: "ConcurrencyStamp",
                value: "d4bf5c2c-211e-4ad5-a814-8979d0ca6e73");

            migrationBuilder.UpdateData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "a7846740-cb77-4d25-8da6-d5c68dfb590d",
                column: "ConcurrencyStamp",
                value: "84e339ab-501c-4488-9de0-e3060713242b");

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "2e142fe7-a372-4b98-ab9d-dcc4e4966b88",
                columns: new[] { "ConcurrencyStamp", "PasswordHash" },
                values: new object[] { "32169fa4-3fe9-4a1b-b91a-f148b8081a61", "AQAAAAEAACcQAAAAEPfDqpr+jX25875kgOdSopdMaYp5DodoLQTT8Re7IBvOiUORahKPyoym76an+kdZzA==" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "3375dc1e-b359-403e-9f13-5e2b395ffafc",
                columns: new[] { "ConcurrencyStamp", "PasswordHash" },
                values: new object[] { "fe018546-6d7c-491e-9c0b-5bb679802938", "AQAAAAEAACcQAAAAEO13XWUytLAZkPcOsbxDmZ0Hx+oSg8wJFx2DnBpNyRbBHnwh6rWX3PyqV1uYjoHAww==" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "3e45b10c-0d15-49f2-903b-7de4bbc62f98",
                columns: new[] { "ConcurrencyStamp", "PasswordHash" },
                values: new object[] { "29fc8502-1839-49af-b5d2-495481062299", "AQAAAAEAACcQAAAAEJKfYZi8N/k2chhl0jWeSVIMA+kSyrle2BKqoqYT3G1vWCm2NwRIntf7TvF0cyMrZQ==" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "48e50810-f7fc-45c8-8d13-0a03a6a8b1de",
                columns: new[] { "ConcurrencyStamp", "PasswordHash" },
                values: new object[] { "172b2f69-1e02-4b82-961b-a26cab036feb", "AQAAAAEAACcQAAAAEDx3aJBmP0pkcfkJ3JVs4uRLYL2ttFvXqtg7znGi+En4hepXIQbgqvsBt/3ZRyS7TA==" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "7167d11d-9358-4262-b7a4-77372e1c121d",
                columns: new[] { "ConcurrencyStamp", "PasswordHash" },
                values: new object[] { "1385faf2-70c9-430d-8344-1706c8f487af", "AQAAAAEAACcQAAAAEKDdGjT92ZG9WxGnm+TXiQM2xd3OXpeLgMKOX9AdBy3+1uaJDeBztj6rxlSJk6QgKw==" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "b8888a0f-ebcf-4b0a-815a-83ccc0a4c349",
                columns: new[] { "ConcurrencyStamp", "PasswordHash" },
                values: new object[] { "aaa3d5a1-f757-4435-bd0d-559df9d60736", "AQAAAAEAACcQAAAAEGTPw0H25iDSjuV6uk/sc8ZBRRRGstTMvekTJIzfSukk8EQjuCfOhuKavs3Jis9Pnw==" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "d19f9bc1-13b4-42b3-881a-a847f4c0684e",
                columns: new[] { "ConcurrencyStamp", "PasswordHash" },
                values: new object[] { "7e9d9342-a33d-42d8-a879-f28c4a682cfd", "AQAAAAEAACcQAAAAECXGf+nQZFJw6ubsCIb5AT5jfFNP8ey94PXWMM562chvM/1T+5RpE5dVVa4k569CDw==" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "fe1300d0-ecf8-4bb5-afaf-5030b27959bd",
                columns: new[] { "ConcurrencyStamp", "PasswordHash" },
                values: new object[] { "5535e97b-1091-4438-8f76-fd8b37b7e9c6", "AQAAAAEAACcQAAAAEDWK5FNH1N8yZzDF7kZwMQXvPHKIDMEqFvMRpknG/7yveQoUlBfU8xZJRQBB12Gzew==" });

            migrationBuilder.UpdateData(
                table: "Statut",
                keyColumn: "IdStatut",
                keyValue: 2,
                column: "Libelle",
                value: "Parametrgage des prix PBE");

            migrationBuilder.UpdateData(
                table: "Statut",
                keyColumn: "IdStatut",
                keyValue: 5,
                column: "Libelle",
                value: "Parametrgage des prix de services");

            migrationBuilder.AddForeignKey(
                name: "FK_Client_Pays_IdPays",
                table: "Client",
                column: "IdPays",
                principalTable: "Pays",
                principalColumn: "IdPays",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_Client_Ville_IdVille",
                table: "Client",
                column: "IdVille",
                principalTable: "Ville",
                principalColumn: "IdVille",
                onDelete: ReferentialAction.Cascade);
        }
    }
}
