using Microsoft.EntityFrameworkCore.Migrations;

namespace Service.Data.Migrations
{
    public partial class Data : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AlterColumn<decimal>(
                name: "Rayon",
                table: "Centrale_Beton",
                nullable: true,
                oldClrType: typeof(decimal));

            migrationBuilder.AlterColumn<double>(
                name: "Tarif",
                table: "Article",
                nullable: true,
                oldClrType: typeof(double));

            migrationBuilder.InsertData(
                table: "Article",
                columns: new[] { "Article_ID", "Designation", "Tarif" },
                values: new object[,]
                {
                    { 1, "Beton1", 50.0 },
                    { 2, "Beton2", 60.0 },
                    { 3, "Beton Spécial", null }
                });

            migrationBuilder.InsertData(
                table: "AspNetRoles",
                columns: new[] { "Id", "ConcurrencyStamp", "Name", "NormalizedName" },
                values: new object[,]
                {
                    { "7b8ab704-463e-4074-8c19-a62905f62e11", "cc9a1463-ee36-4682-a236-932519762db8", "Controle crédit", "CONTROLE CREDIT" },
                    { "a7846740-cb77-4d25-8da6-d5c68dfb590d", "16be869b-3380-422f-9e39-ca899024b371", "Responsable logistique", "RESPONSABLE LOGISTIQUE" },
                    { "126a635b-d763-48bf-ab0e-f5599cffb4fe", "9e88d6c0-09c4-4377-b2d2-73505d32814e", "Prescripteur technique", "PRESCRIPTEUR TECHNIQUE" },
                    { "9be024db-d122-4cd2-8329-2afd0d259e77", "7d574cf3-51a9-4b38-b991-35cec774bdef", "DA BPE", "DA BPE" },
                    { "6eafdfbe-ed07-4687-9d2c-0b767b15a305", "25ff01c0-e487-4c9a-a847-d689c7f1f74a", "Responsable commercial", "RESPONSABLE COMMERCIAL" },
                    { "1588b3b9-37bc-4f58-acf9-e42fd47f1c28", "93e927fa-b10f-44b6-81db-49518e0f2a04", "Chef de ventes", "CHEF DE VENTES" },
                    { "48e33a01-bd1f-4739-a27f-126e8e8b2d1c", "476bb31e-242d-4adf-9d30-8ce4afc99363", "Admin", "ADMIN" },
                    { "3e130fc1-981e-4183-a12d-fa5f73d13bb2", "9e7a40b9-de27-47a9-84ae-c42a06dc92cb", "Administration des ventes", "ADMINISTRATION DES VENTES" }
                });

            migrationBuilder.InsertData(
                table: "AspNetUsers",
                columns: new[] { "Id", "AccessFailedCount", "ConcurrencyStamp", "Email", "EmailConfirmed", "LockoutEnabled", "LockoutEnd", "NormalizedEmail", "NormalizedUserName", "PasswordHash", "PhoneNumber", "PhoneNumberConfirmed", "SecurityStamp", "TwoFactorEnabled", "UserName" },
                values: new object[,]
                {
                    { "3375dc1e-b359-403e-9f13-5e2b395ffafc", 0, "929355b3-1a68-4eef-9480-b45920e9931c", "t.abdelmajid@Alexsys.solutions", true, false, null, "T.ABDELMAJID@ALEXSYS.SOLUTIONS", "ADMIN", "AQAAAAEAACcQAAAAEDHIp8JRZc2QHIxxVEr3VG6KbgKbOOyY2+r/3uyJNm5R3bWm0w9v/kKSdqORscQjMQ==", null, false, "78806f6d-7f1f-4d2f-9a13-ce06383ed217", false, "admin" },
                    { "48e50810-f7fc-45c8-8d13-0a03a6a8b1de", 0, "3816814a-7022-42b5-8196-92d4f4735d62", null, false, false, null, null, "CONTROLECREDIT", "AQAAAAEAACcQAAAAEHhOwU0EJZTgzP/2N0gX17iQC8XRY1Syh2gS9s7HZ7cnLJgppfdbtYDE+GG2iU0qaQ==", null, false, "8e031d55-7c1e-4a55-896b-288a6f628ecd", false, "controlecredit" },
                    { "7167d11d-9358-4262-b7a4-77372e1c121d", 0, "aa08231c-f15f-4864-9ab1-b6fb3e68690a", null, false, false, null, null, "CHEFDEVENTE", "AQAAAAEAACcQAAAAEF/hCYAaYMm1uUeeAmXgdHgn/vyG51oPYV9lV0ULGBprF0fx6TdHI/hk+hTDgDuU9A==", null, false, "45a41cea-397f-4837-9706-945073586524", false, "chefdevente" },
                    { "2e142fe7-a372-4b98-ab9d-dcc4e4966b88", 0, "01af92f8-34ed-4627-9cf4-cecdd7dae4c8", null, false, false, null, null, "RESPONSABLECOMMERCIAL", "AQAAAAEAACcQAAAAEAhRLyowQqHstfGf3TvxtRiWGPTSN4k9LdGj2jlt07Se0nTHgQQveH6zmQdN+uqVlg==", null, false, "925b8781-e141-4f60-9dfc-293d3e24b78f", false, "responsablecommercial" },
                    { "b8888a0f-ebcf-4b0a-815a-83ccc0a4c349", 0, "99e0036f-c07e-4d58-bdf1-6e15581006f7", null, false, false, null, null, "DABPE", "AQAAAAEAACcQAAAAEAT33LCGvQimY78+VI/klIcfRFxFhW+XxfnmutksbotA1vQEHw732yq9jzwUfXnKsg==", null, false, "54227a7c-67ee-4ebb-b9d0-272ccb30e483", false, "dabpe" },
                    { "3e45b10c-0d15-49f2-903b-7de4bbc62f98", 0, "54a46574-f4f4-422f-a363-06bd9323d8fa", null, false, false, null, null, "PRESCRIPTEURTECHNIQUE", "AQAAAAEAACcQAAAAEDQkU0FqLoQiuMbznt3mo0YX8C95vm5bPNZ90yvPm1TqJN0hKMGNI4kGKpRiwm/TUw==", null, false, "58053aac-a438-4e44-acce-4f967d8df300", false, "prescripteurtechnique" },
                    { "d19f9bc1-13b4-42b3-881a-a847f4c0684e", 0, "43629672-f562-4a1d-8b15-35c5cd2b69f0", null, false, false, null, null, "RESPONSABLELOGISTIQUE", "AQAAAAEAACcQAAAAEJX/dZrtvar34YEoUOEu6tN5eTYdrKrmcgZYD3FQBXD1gxGpG1m3XHxqI0kErkOABw==", null, false, "adf0467d-bf4f-4bf5-a576-078dac83af6b", false, "responsablelogistique" },
                    { "fe1300d0-ecf8-4bb5-afaf-5030b27959bd", 0, "bfa71934-88cf-43a4-97ca-924386d26dc4", null, false, false, null, null, "ADMINISTRATIONDESVENTES", "AQAAAAEAACcQAAAAEGjIhcvfuqdM0tBmo1y1247gttLYPD423q9BKpwLBoWJHsfBP0l6caM9+acptnRI4A==", null, false, "02d7a2a5-9486-4980-b031-b1728f9125f1", false, "administration des ventes" }
                });

            migrationBuilder.InsertData(
                table: "Forme_Juridique",
                columns: new[] { "FormeJuridique_Id", "FormeJuridique_Libelle" },
                values: new object[,]
                {
                    { 2, null },
                    { 1, null }
                });

            migrationBuilder.InsertData(
                table: "Pays",
                columns: new[] { "IdPays", "CodePaysSap", "NomPays" },
                values: new object[] { 1, "MA", "Maroc" });

            migrationBuilder.InsertData(
                table: "Statut",
                columns: new[] { "IdStatut", "CodeStatutSap", "Libelle" },
                values: new object[,]
                {
                    { 1, "1", "Validation de l'offre de prix" },
                    { 2, "2", "Validé" }
                });

            migrationBuilder.InsertData(
                table: "Tarif_Pompe",
                columns: new[] { "Tpr_Id", "LongFleche_Libelle", "LongFleche_Prix" },
                values: new object[,]
                {
                    { 1, "48", 50m },
                    { 3, "52", 70m },
                    { 2, "50", 60m }
                });

            migrationBuilder.InsertData(
                table: "Type_Chantier",
                columns: new[] { "Tc_Id", "Tc_Libelle" },
                values: new object[,]
                {
                    { 3, "Type 3" },
                    { 2, "Type 2" },
                    { 1, "Type 1" }
                });

            migrationBuilder.InsertData(
                table: "Unite",
                columns: new[] { "IdUnite", "Libelle" },
                values: new object[] { 1, "m3" });

            migrationBuilder.InsertData(
                table: "Zone",
                columns: new[] { "Zone_Id", "Zone_Libelle", "Zone_Prix" },
                values: new object[,]
                {
                    { 3, "Zone 3", 70m },
                    { 1, "Zone 1", 50m },
                    { 2, "Zone 2", 60m }
                });

            migrationBuilder.InsertData(
                table: "AspNetUserRoles",
                columns: new[] { "UserId", "RoleId" },
                values: new object[,]
                {
                    { "3375dc1e-b359-403e-9f13-5e2b395ffafc", "48e33a01-bd1f-4739-a27f-126e8e8b2d1c" },
                    { "7167d11d-9358-4262-b7a4-77372e1c121d", "1588b3b9-37bc-4f58-acf9-e42fd47f1c28" },
                    { "2e142fe7-a372-4b98-ab9d-dcc4e4966b88", "6eafdfbe-ed07-4687-9d2c-0b767b15a305" },
                    { "b8888a0f-ebcf-4b0a-815a-83ccc0a4c349", "9be024db-d122-4cd2-8329-2afd0d259e77" },
                    { "3e45b10c-0d15-49f2-903b-7de4bbc62f98", "126a635b-d763-48bf-ab0e-f5599cffb4fe" },
                    { "d19f9bc1-13b4-42b3-881a-a847f4c0684e", "a7846740-cb77-4d25-8da6-d5c68dfb590d" },
                    { "fe1300d0-ecf8-4bb5-afaf-5030b27959bd", "3e130fc1-981e-4183-a12d-fa5f73d13bb2" },
                    { "48e50810-f7fc-45c8-8d13-0a03a6a8b1de", "7b8ab704-463e-4074-8c19-a62905f62e11" }
                });

            migrationBuilder.InsertData(
                table: "Ville",
                columns: new[] { "IdVille", "CodePaysSap", "CodeVilleSap", "IdPays", "NomVille" },
                values: new object[,]
                {
                    { 1, "MA", "R", 1, "Rabat" },
                    { 2, "MA", "C", 1, "Casablanca" }
                });

            migrationBuilder.InsertData(
                table: "Centrale_Beton",
                columns: new[] { "Ctr_ID", "Ctr_Adresse", "Ctr_CodePostal", "Ctr_Email", "Ctr_Gsm", "Ctr_Latiture", "Ctr_Longitude", "Ctr_Nom", "Ctr_Responsable", "Ctr_Responsable_Gsm", "Ctr_Ville_Id", "Rayon" },
                values: new object[] { 1, "Adresse 1", 20250, "Centrale1@gmail.com", "0620055784", null, "-7.618710247586268", "Centrale 1", "Test", "0620055784", 2, null });

            migrationBuilder.InsertData(
                table: "Centrale_Beton",
                columns: new[] { "Ctr_ID", "Ctr_Adresse", "Ctr_CodePostal", "Ctr_Email", "Ctr_Gsm", "Ctr_Latiture", "Ctr_Longitude", "Ctr_Nom", "Ctr_Responsable", "Ctr_Responsable_Gsm", "Ctr_Ville_Id", "Rayon" },
                values: new object[] { 2, "Adresse 2", 20250, "Centrale2@gmail.com", "0520055784", null, "-7.533456", "Centrale 2", "Test 2", "0625255784", 2, null });

            migrationBuilder.InsertData(
                table: "Centrale_Beton",
                columns: new[] { "Ctr_ID", "Ctr_Adresse", "Ctr_CodePostal", "Ctr_Email", "Ctr_Gsm", "Ctr_Latiture", "Ctr_Longitude", "Ctr_Nom", "Ctr_Responsable", "Ctr_Responsable_Gsm", "Ctr_Ville_Id", "Rayon" },
                values: new object[] { 3, "Adresse 3", 20256, "Centrale3@gmail.com", "0525055784", null, "-7,6738", "Centrale 3", "Test 3", "0625285784", 2, null });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "Article",
                keyColumn: "Article_ID",
                keyValue: 1);

            migrationBuilder.DeleteData(
                table: "Article",
                keyColumn: "Article_ID",
                keyValue: 2);

            migrationBuilder.DeleteData(
                table: "Article",
                keyColumn: "Article_ID",
                keyValue: 3);

            migrationBuilder.DeleteData(
                table: "AspNetUserRoles",
                keyColumns: new[] { "UserId", "RoleId" },
                keyValues: new object[] { "2e142fe7-a372-4b98-ab9d-dcc4e4966b88", "6eafdfbe-ed07-4687-9d2c-0b767b15a305" });

            migrationBuilder.DeleteData(
                table: "AspNetUserRoles",
                keyColumns: new[] { "UserId", "RoleId" },
                keyValues: new object[] { "3375dc1e-b359-403e-9f13-5e2b395ffafc", "48e33a01-bd1f-4739-a27f-126e8e8b2d1c" });

            migrationBuilder.DeleteData(
                table: "AspNetUserRoles",
                keyColumns: new[] { "UserId", "RoleId" },
                keyValues: new object[] { "3e45b10c-0d15-49f2-903b-7de4bbc62f98", "126a635b-d763-48bf-ab0e-f5599cffb4fe" });

            migrationBuilder.DeleteData(
                table: "AspNetUserRoles",
                keyColumns: new[] { "UserId", "RoleId" },
                keyValues: new object[] { "48e50810-f7fc-45c8-8d13-0a03a6a8b1de", "7b8ab704-463e-4074-8c19-a62905f62e11" });

            migrationBuilder.DeleteData(
                table: "AspNetUserRoles",
                keyColumns: new[] { "UserId", "RoleId" },
                keyValues: new object[] { "7167d11d-9358-4262-b7a4-77372e1c121d", "1588b3b9-37bc-4f58-acf9-e42fd47f1c28" });

            migrationBuilder.DeleteData(
                table: "AspNetUserRoles",
                keyColumns: new[] { "UserId", "RoleId" },
                keyValues: new object[] { "b8888a0f-ebcf-4b0a-815a-83ccc0a4c349", "9be024db-d122-4cd2-8329-2afd0d259e77" });

            migrationBuilder.DeleteData(
                table: "AspNetUserRoles",
                keyColumns: new[] { "UserId", "RoleId" },
                keyValues: new object[] { "d19f9bc1-13b4-42b3-881a-a847f4c0684e", "a7846740-cb77-4d25-8da6-d5c68dfb590d" });

            migrationBuilder.DeleteData(
                table: "AspNetUserRoles",
                keyColumns: new[] { "UserId", "RoleId" },
                keyValues: new object[] { "fe1300d0-ecf8-4bb5-afaf-5030b27959bd", "3e130fc1-981e-4183-a12d-fa5f73d13bb2" });

            migrationBuilder.DeleteData(
                table: "Centrale_Beton",
                keyColumn: "Ctr_ID",
                keyValue: 1);

            migrationBuilder.DeleteData(
                table: "Centrale_Beton",
                keyColumn: "Ctr_ID",
                keyValue: 2);

            migrationBuilder.DeleteData(
                table: "Centrale_Beton",
                keyColumn: "Ctr_ID",
                keyValue: 3);

            migrationBuilder.DeleteData(
                table: "Forme_Juridique",
                keyColumn: "FormeJuridique_Id",
                keyValue: 1);

            migrationBuilder.DeleteData(
                table: "Forme_Juridique",
                keyColumn: "FormeJuridique_Id",
                keyValue: 2);

            migrationBuilder.DeleteData(
                table: "Statut",
                keyColumn: "IdStatut",
                keyValue: 1);

            migrationBuilder.DeleteData(
                table: "Statut",
                keyColumn: "IdStatut",
                keyValue: 2);

            migrationBuilder.DeleteData(
                table: "Tarif_Pompe",
                keyColumn: "Tpr_Id",
                keyValue: 1);

            migrationBuilder.DeleteData(
                table: "Tarif_Pompe",
                keyColumn: "Tpr_Id",
                keyValue: 2);

            migrationBuilder.DeleteData(
                table: "Tarif_Pompe",
                keyColumn: "Tpr_Id",
                keyValue: 3);

            migrationBuilder.DeleteData(
                table: "Type_Chantier",
                keyColumn: "Tc_Id",
                keyValue: 1);

            migrationBuilder.DeleteData(
                table: "Type_Chantier",
                keyColumn: "Tc_Id",
                keyValue: 2);

            migrationBuilder.DeleteData(
                table: "Type_Chantier",
                keyColumn: "Tc_Id",
                keyValue: 3);

            migrationBuilder.DeleteData(
                table: "Unite",
                keyColumn: "IdUnite",
                keyValue: 1);

            migrationBuilder.DeleteData(
                table: "Ville",
                keyColumn: "IdVille",
                keyValue: 1);

            migrationBuilder.DeleteData(
                table: "Zone",
                keyColumn: "Zone_Id",
                keyValue: 1);

            migrationBuilder.DeleteData(
                table: "Zone",
                keyColumn: "Zone_Id",
                keyValue: 2);

            migrationBuilder.DeleteData(
                table: "Zone",
                keyColumn: "Zone_Id",
                keyValue: 3);

            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumns: new[] { "Id", "ConcurrencyStamp" },
                keyValues: new object[] { "126a635b-d763-48bf-ab0e-f5599cffb4fe", "9e88d6c0-09c4-4377-b2d2-73505d32814e" });

            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumns: new[] { "Id", "ConcurrencyStamp" },
                keyValues: new object[] { "1588b3b9-37bc-4f58-acf9-e42fd47f1c28", "93e927fa-b10f-44b6-81db-49518e0f2a04" });

            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumns: new[] { "Id", "ConcurrencyStamp" },
                keyValues: new object[] { "3e130fc1-981e-4183-a12d-fa5f73d13bb2", "9e7a40b9-de27-47a9-84ae-c42a06dc92cb" });

            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumns: new[] { "Id", "ConcurrencyStamp" },
                keyValues: new object[] { "48e33a01-bd1f-4739-a27f-126e8e8b2d1c", "476bb31e-242d-4adf-9d30-8ce4afc99363" });

            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumns: new[] { "Id", "ConcurrencyStamp" },
                keyValues: new object[] { "6eafdfbe-ed07-4687-9d2c-0b767b15a305", "25ff01c0-e487-4c9a-a847-d689c7f1f74a" });

            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumns: new[] { "Id", "ConcurrencyStamp" },
                keyValues: new object[] { "7b8ab704-463e-4074-8c19-a62905f62e11", "cc9a1463-ee36-4682-a236-932519762db8" });

            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumns: new[] { "Id", "ConcurrencyStamp" },
                keyValues: new object[] { "9be024db-d122-4cd2-8329-2afd0d259e77", "7d574cf3-51a9-4b38-b991-35cec774bdef" });

            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumns: new[] { "Id", "ConcurrencyStamp" },
                keyValues: new object[] { "a7846740-cb77-4d25-8da6-d5c68dfb590d", "16be869b-3380-422f-9e39-ca899024b371" });

            migrationBuilder.DeleteData(
                table: "AspNetUsers",
                keyColumns: new[] { "Id", "ConcurrencyStamp" },
                keyValues: new object[] { "2e142fe7-a372-4b98-ab9d-dcc4e4966b88", "01af92f8-34ed-4627-9cf4-cecdd7dae4c8" });

            migrationBuilder.DeleteData(
                table: "AspNetUsers",
                keyColumns: new[] { "Id", "ConcurrencyStamp" },
                keyValues: new object[] { "3375dc1e-b359-403e-9f13-5e2b395ffafc", "929355b3-1a68-4eef-9480-b45920e9931c" });

            migrationBuilder.DeleteData(
                table: "AspNetUsers",
                keyColumns: new[] { "Id", "ConcurrencyStamp" },
                keyValues: new object[] { "3e45b10c-0d15-49f2-903b-7de4bbc62f98", "54a46574-f4f4-422f-a363-06bd9323d8fa" });

            migrationBuilder.DeleteData(
                table: "AspNetUsers",
                keyColumns: new[] { "Id", "ConcurrencyStamp" },
                keyValues: new object[] { "48e50810-f7fc-45c8-8d13-0a03a6a8b1de", "3816814a-7022-42b5-8196-92d4f4735d62" });

            migrationBuilder.DeleteData(
                table: "AspNetUsers",
                keyColumns: new[] { "Id", "ConcurrencyStamp" },
                keyValues: new object[] { "7167d11d-9358-4262-b7a4-77372e1c121d", "aa08231c-f15f-4864-9ab1-b6fb3e68690a" });

            migrationBuilder.DeleteData(
                table: "AspNetUsers",
                keyColumns: new[] { "Id", "ConcurrencyStamp" },
                keyValues: new object[] { "b8888a0f-ebcf-4b0a-815a-83ccc0a4c349", "99e0036f-c07e-4d58-bdf1-6e15581006f7" });

            migrationBuilder.DeleteData(
                table: "AspNetUsers",
                keyColumns: new[] { "Id", "ConcurrencyStamp" },
                keyValues: new object[] { "d19f9bc1-13b4-42b3-881a-a847f4c0684e", "43629672-f562-4a1d-8b15-35c5cd2b69f0" });

            migrationBuilder.DeleteData(
                table: "AspNetUsers",
                keyColumns: new[] { "Id", "ConcurrencyStamp" },
                keyValues: new object[] { "fe1300d0-ecf8-4bb5-afaf-5030b27959bd", "bfa71934-88cf-43a4-97ca-924386d26dc4" });

            migrationBuilder.DeleteData(
                table: "Ville",
                keyColumn: "IdVille",
                keyValue: 2);

            migrationBuilder.DeleteData(
                table: "Pays",
                keyColumn: "IdPays",
                keyValue: 1);

            migrationBuilder.AlterColumn<decimal>(
                name: "Rayon",
                table: "Centrale_Beton",
                nullable: false,
                oldClrType: typeof(decimal),
                oldNullable: true);

            migrationBuilder.AlterColumn<double>(
                name: "Tarif",
                table: "Article",
                nullable: false,
                oldClrType: typeof(double),
                oldNullable: true);
        }
    }
}
