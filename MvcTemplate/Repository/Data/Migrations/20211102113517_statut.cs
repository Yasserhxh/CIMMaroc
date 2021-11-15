using Microsoft.EntityFrameworkCore.Migrations;

namespace Service.Data.Migrations
{
    public partial class statut : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_DetailCommande_Unite_UniteIdUnite",
                table: "DetailCommande");

            migrationBuilder.RenameColumn(
                name: "UniteIdUnite",
                table: "DetailCommande",
                newName: "IdStatut");

            migrationBuilder.RenameIndex(
                name: "IX_DetailCommande_UniteIdUnite",
                table: "DetailCommande",
                newName: "IX_DetailCommande_IdStatut");

            migrationBuilder.AddColumn<int>(
                name: "Unite_Id",
                table: "DetailCommande",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.UpdateData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "126a635b-d763-48bf-ab0e-f5599cffb4fe",
                column: "ConcurrencyStamp",
                value: "4210cc40-aeb4-46f2-a00d-a5329a77cd21");

            migrationBuilder.UpdateData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "1588b3b9-37bc-4f58-acf9-e42fd47f1c28",
                column: "ConcurrencyStamp",
                value: "13149a47-0234-4431-ba47-466e332d0e48");

            migrationBuilder.UpdateData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "3e130fc1-981e-4183-a12d-fa5f73d13bb2",
                column: "ConcurrencyStamp",
                value: "e1adb76f-847d-4ae6-b939-72914a17a50f");

            migrationBuilder.UpdateData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "48e33a01-bd1f-4739-a27f-126e8e8b2d1c",
                column: "ConcurrencyStamp",
                value: "7e3c2fd2-bc20-481a-85dd-1c6c044d693f");

            migrationBuilder.UpdateData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "6eafdfbe-ed07-4687-9d2c-0b767b15a305",
                column: "ConcurrencyStamp",
                value: "4a0b80f7-7d04-4a02-8f93-c856136ed5de");

            migrationBuilder.UpdateData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "7b8ab704-463e-4074-8c19-a62905f62e11",
                column: "ConcurrencyStamp",
                value: "2db036a2-091c-458b-bcd8-710a41592ca7");

            migrationBuilder.UpdateData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "9be024db-d122-4cd2-8329-2afd0d259e77",
                column: "ConcurrencyStamp",
                value: "9fd82702-5d76-4b99-81b2-f27b0a958a39");

            migrationBuilder.UpdateData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "a7846740-cb77-4d25-8da6-d5c68dfb590d",
                column: "ConcurrencyStamp",
                value: "3cfd0de0-d935-4924-be29-b5b962956001");

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "2e142fe7-a372-4b98-ab9d-dcc4e4966b88",
                columns: new[] { "ConcurrencyStamp", "PasswordHash" },
                values: new object[] { "fa3fa5dc-5c60-46ee-a25c-72b250f4f554", "AQAAAAEAACcQAAAAECB/3M5foaB+tebpqJwdEHGGSbtnpcfT4YOy6u7tRTCoUihEtQ6yQOaWjO42RgC3DQ==" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "3375dc1e-b359-403e-9f13-5e2b395ffafc",
                columns: new[] { "ConcurrencyStamp", "PasswordHash" },
                values: new object[] { "07f5e055-f8ea-4e8e-83fd-1827c066c486", "AQAAAAEAACcQAAAAEDHhVOG+JXM626AtcquC3JPpwKyibocD8OG5Zz19bOp4dxTc8gvpctwROMuOI/rDMA==" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "3e45b10c-0d15-49f2-903b-7de4bbc62f98",
                columns: new[] { "ConcurrencyStamp", "PasswordHash" },
                values: new object[] { "921980d9-3c91-49c8-b09d-59984a182a8d", "AQAAAAEAACcQAAAAEFfCTRMJ7iGsrxN+FOyViARZcXxp/LlSFuKexX/jf//+RXR+xvwJqPgRtvIr0gIJhg==" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "48e50810-f7fc-45c8-8d13-0a03a6a8b1de",
                columns: new[] { "ConcurrencyStamp", "PasswordHash" },
                values: new object[] { "13808a36-4210-4b26-8b3d-34ffacb8da05", "AQAAAAEAACcQAAAAEFccZTnApSSVvtyepIb13STqMMqzemNXorXHOpHSbxyWH3mQ9xMUPJaa5OzSTM7wgg==" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "7167d11d-9358-4262-b7a4-77372e1c121d",
                columns: new[] { "ConcurrencyStamp", "PasswordHash" },
                values: new object[] { "4ef49209-1b43-4cdd-be80-6a376fb599f4", "AQAAAAEAACcQAAAAEGRrrnKH1VeWBfuXITcV4M1raibLTurHl2au46E7ol+IrskFVr08VrhVwqF/vDV6sQ==" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "b8888a0f-ebcf-4b0a-815a-83ccc0a4c349",
                columns: new[] { "ConcurrencyStamp", "PasswordHash" },
                values: new object[] { "d76d19d5-421c-4ade-8073-d51d9d4fe388", "AQAAAAEAACcQAAAAELqSS2/eAHWJFc2R3jl0mi0e2MUHR2vwzVDikjcm7L1yZtjXn4t6ocM3x+hrHrxPVA==" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "d19f9bc1-13b4-42b3-881a-a847f4c0684e",
                columns: new[] { "ConcurrencyStamp", "PasswordHash" },
                values: new object[] { "70b50946-22e6-487a-86ad-b980a92dcf16", "AQAAAAEAACcQAAAAEO2CFpvYklYG3RxJovK01qexV3V7FOCBJy0YfuCzj+t3foGHuV2g570Q9lRSN1rItg==" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "fe1300d0-ecf8-4bb5-afaf-5030b27959bd",
                columns: new[] { "ConcurrencyStamp", "PasswordHash" },
                values: new object[] { "63f9b0f0-fe06-422f-a693-cda16e043e62", "AQAAAAEAACcQAAAAEOZx0jHSo3i9i4n4EELfyVxWM1E5lDVNT3EcOZZm7FF3N8O7HgObcDFfSudTCv5Zaw==" });

            migrationBuilder.InsertData(
                table: "Statut",
                columns: new[] { "IdStatut", "CodeStatutSap", "Libelle" },
                values: new object[] { 7, "7", "En cours de traitement" });

            migrationBuilder.CreateIndex(
                name: "IX_DetailCommande_Unite_Id",
                table: "DetailCommande",
                column: "Unite_Id");

            migrationBuilder.AddForeignKey(
                name: "FK_DetailCommande_Statut_IdStatut",
                table: "DetailCommande",
                column: "IdStatut",
                principalTable: "Statut",
                principalColumn: "IdStatut",
                onDelete: ReferentialAction.Restrict);

            migrationBuilder.AddForeignKey(
                name: "FK_DetailCommande_Unite_Unite_Id",
                table: "DetailCommande",
                column: "Unite_Id",
                principalTable: "Unite",
                principalColumn: "IdUnite",
                onDelete: ReferentialAction.Cascade);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_DetailCommande_Statut_IdStatut",
                table: "DetailCommande");

            migrationBuilder.DropForeignKey(
                name: "FK_DetailCommande_Unite_Unite_Id",
                table: "DetailCommande");

            migrationBuilder.DropIndex(
                name: "IX_DetailCommande_Unite_Id",
                table: "DetailCommande");

            migrationBuilder.DeleteData(
                table: "Statut",
                keyColumn: "IdStatut",
                keyValue: 7);

            migrationBuilder.DropColumn(
                name: "Unite_Id",
                table: "DetailCommande");

            migrationBuilder.RenameColumn(
                name: "IdStatut",
                table: "DetailCommande",
                newName: "UniteIdUnite");

            migrationBuilder.RenameIndex(
                name: "IX_DetailCommande_IdStatut",
                table: "DetailCommande",
                newName: "IX_DetailCommande_UniteIdUnite");

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

            migrationBuilder.AddForeignKey(
                name: "FK_DetailCommande_Unite_UniteIdUnite",
                table: "DetailCommande",
                column: "UniteIdUnite",
                principalTable: "Unite",
                principalColumn: "IdUnite",
                onDelete: ReferentialAction.Restrict);
        }
    }
}
