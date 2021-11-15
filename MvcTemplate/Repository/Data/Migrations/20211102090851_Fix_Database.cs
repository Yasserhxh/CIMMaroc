using Microsoft.EntityFrameworkCore.Migrations;

namespace Service.Data.Migrations
{
    public partial class Fix_Database : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Chantier_Centrale_Beton_CentraleBetonCtr_ID",
                table: "Chantier");

            migrationBuilder.DropForeignKey(
                name: "FK_DetailCommande_Unite_IdUniteQuantite",
                table: "DetailCommande");

            migrationBuilder.DropForeignKey(
                name: "FK_Paiement_Chantier_Ctn_Id",
                table: "Paiement");

            migrationBuilder.DropForeignKey(
                name: "FK_Paiement_Delai_Paiement_DelaiPaiementDelai_ID",
                table: "Paiement");

            migrationBuilder.DropForeignKey(
                name: "FK_Tarif_Service_Chantier_Ts_Ctn_Id",
                table: "Tarif_Service");

            migrationBuilder.DropIndex(
                name: "IX_Tarif_Service_Ts_Ctn_Id",
                table: "Tarif_Service");

            migrationBuilder.DropIndex(
                name: "IX_Paiement_Ctn_Id",
                table: "Paiement");

            migrationBuilder.DropIndex(
                name: "IX_Paiement_DelaiPaiementDelai_ID",
                table: "Paiement");

            migrationBuilder.DropColumn(
                name: "Ts_Ctn_Id",
                table: "Tarif_Service");

            migrationBuilder.DropColumn(
                name: "Ctn_Id",
                table: "Paiement");

            migrationBuilder.DropColumn(
                name: "DelaiPaiementDelai_ID",
                table: "Paiement");

            migrationBuilder.DropColumn(
                name: "Delai_Paiement_Id",
                table: "Paiement");

            migrationBuilder.DropColumn(
                name: "PoidsNet",
                table: "DetailCommande");

            migrationBuilder.DropColumn(
                name: "PrixNet",
                table: "DetailCommande");

            migrationBuilder.DropColumn(
                name: "Quantite",
                table: "DetailCommande");

            migrationBuilder.DropColumn(
                name: "ValeurNette",
                table: "DetailCommande");

            migrationBuilder.RenameColumn(
                name: "IdUniteQuantite",
                table: "DetailCommande",
                newName: "UniteIdUnite");

            migrationBuilder.RenameIndex(
                name: "IX_DetailCommande_IdUniteQuantite",
                table: "DetailCommande",
                newName: "IX_DetailCommande_UniteIdUnite");

            migrationBuilder.RenameColumn(
                name: "Delai_ID",
                table: "Delai_Paiement",
                newName: "Delai_Id");

            migrationBuilder.RenameColumn(
                name: "CentraleBetonCtr_ID",
                table: "Chantier",
                newName: "CentraleBetonCtr_Id");

            migrationBuilder.RenameIndex(
                name: "IX_Chantier_CentraleBetonCtr_ID",
                table: "Chantier",
                newName: "IX_Chantier_CentraleBetonCtr_Id");

            migrationBuilder.RenameColumn(
                name: "Ctr_ID",
                table: "Centrale_Beton",
                newName: "Ctr_Id");

            migrationBuilder.RenameColumn(
                name: "Article_ID",
                table: "Article",
                newName: "Article_Id");

            migrationBuilder.AddColumn<string>(
                name: "Conditions",
                table: "Commande",
                nullable: true);

            migrationBuilder.AddColumn<int>(
                name: "DelaiPaiementDelai_Id",
                table: "Commande",
                nullable: true);

            migrationBuilder.AddColumn<int>(
                name: "Delai_Paiement_Id",
                table: "Commande",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.AddColumn<double>(
                name: "TarifPompage",
                table: "Commande",
                nullable: false,
                defaultValue: 0.0);

            migrationBuilder.AddColumn<double>(
                name: "TarifTransport",
                table: "Commande",
                nullable: false,
                defaultValue: 0.0);

            migrationBuilder.UpdateData(
                table: "Article",
                keyColumn: "Article_Id",
                keyValue: 1,
                column: "Designation",
                value: "Beton 1");

            migrationBuilder.UpdateData(
                table: "Article",
                keyColumn: "Article_Id",
                keyValue: 2,
                column: "Designation",
                value: "Beton 2");

            migrationBuilder.UpdateData(
                table: "Article",
                keyColumn: "Article_Id",
                keyValue: 3,
                columns: new[] { "Designation", "Tarif" },
                values: new object[] { "Beton 3", 70.0 });

            migrationBuilder.InsertData(
                table: "Article",
                columns: new[] { "Article_Id", "Designation", "Tarif" },
                values: new object[] { 4, "Beton Spécial", null });

            migrationBuilder.UpdateData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "126a635b-d763-48bf-ab0e-f5599cffb4fe",
                column: "ConcurrencyStamp",
                value: "8af2f4d4-73bc-4574-98c9-36f33507a593");

            migrationBuilder.UpdateData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "1588b3b9-37bc-4f58-acf9-e42fd47f1c28",
                column: "ConcurrencyStamp",
                value: "adfa6540-cc06-46f5-9dde-969e07bd64e3");

            migrationBuilder.UpdateData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "3e130fc1-981e-4183-a12d-fa5f73d13bb2",
                column: "ConcurrencyStamp",
                value: "2e664718-fe8c-44a8-baa2-887a648a5d2f");

            migrationBuilder.UpdateData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "48e33a01-bd1f-4739-a27f-126e8e8b2d1c",
                column: "ConcurrencyStamp",
                value: "cbfbd6f2-2af0-4767-996e-6b49beabfc32");

            migrationBuilder.UpdateData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "6eafdfbe-ed07-4687-9d2c-0b767b15a305",
                column: "ConcurrencyStamp",
                value: "80fc5fb6-7a7a-4339-b327-e757c735f4ad");

            migrationBuilder.UpdateData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "7b8ab704-463e-4074-8c19-a62905f62e11",
                column: "ConcurrencyStamp",
                value: "3930d8a4-2b4f-4868-b869-8bac5ed74664");

            migrationBuilder.UpdateData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "9be024db-d122-4cd2-8329-2afd0d259e77",
                column: "ConcurrencyStamp",
                value: "c38b1735-dd2b-451c-a5c1-6a633784d5b7");

            migrationBuilder.UpdateData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "a7846740-cb77-4d25-8da6-d5c68dfb590d",
                column: "ConcurrencyStamp",
                value: "9e938259-b411-4d9b-8056-0f2086febbb9");

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "2e142fe7-a372-4b98-ab9d-dcc4e4966b88",
                columns: new[] { "ConcurrencyStamp", "PasswordHash" },
                values: new object[] { "4d1df2f9-25e8-491e-8b6e-e098c2afcc04", "AQAAAAEAACcQAAAAEONybaAB/MPYjd3jhNUi8KNag0rCY+/Uiyw2LSJMry9yduDAo1jXFNPY8X25HTIyuw==" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "3375dc1e-b359-403e-9f13-5e2b395ffafc",
                columns: new[] { "ConcurrencyStamp", "PasswordHash" },
                values: new object[] { "87a8044e-e993-4612-ac7f-9eee8e76ee1a", "AQAAAAEAACcQAAAAEJuAbu9pIbJpG1L/r6AHUH82tdxF/v1IfUlUT9RgmQkdi52M6dF9JzMR1vSmH9b/DA==" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "3e45b10c-0d15-49f2-903b-7de4bbc62f98",
                columns: new[] { "ConcurrencyStamp", "PasswordHash" },
                values: new object[] { "e00a4ca0-83d7-4bb9-a0d8-e6a36441ae3f", "AQAAAAEAACcQAAAAEMnp5hcVUDCwkS3GLZXhXUDV2rZRwxdn0J/W0ISaOZpAEJgCmsohQLO0NU48HtH28w==" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "48e50810-f7fc-45c8-8d13-0a03a6a8b1de",
                columns: new[] { "ConcurrencyStamp", "PasswordHash" },
                values: new object[] { "29711267-34e0-4439-9f5a-f190442fea29", "AQAAAAEAACcQAAAAENUW8UgSsdMKer1Tl2uWXyr6zToTk1snLlX0y6gPPtpFvV40mwDdkWDHBhw4UZpLKg==" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "7167d11d-9358-4262-b7a4-77372e1c121d",
                columns: new[] { "ConcurrencyStamp", "PasswordHash" },
                values: new object[] { "e21db10e-ba02-40f5-9fc3-c23606f022fc", "AQAAAAEAACcQAAAAEO6g7Yr/lKYYAvFPnN3zvHXi8Ox29kkMqo7mDkxjmtmCcZ4sjlrCpg/6ZPp41jiPVw==" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "b8888a0f-ebcf-4b0a-815a-83ccc0a4c349",
                columns: new[] { "ConcurrencyStamp", "PasswordHash" },
                values: new object[] { "315fd0d5-1791-4493-8420-5995cd05a046", "AQAAAAEAACcQAAAAEK1rtoh1Af549r9yFGRWgPOWWJgdN92QvOgWXYeoc/d/fm7naOn+B39RIT8mqjVVyQ==" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "d19f9bc1-13b4-42b3-881a-a847f4c0684e",
                columns: new[] { "ConcurrencyStamp", "PasswordHash" },
                values: new object[] { "cfbc54c7-1003-4cb2-9f4a-c02d8259d99c", "AQAAAAEAACcQAAAAEISw5jXHRnAXTXe2C1Sqc2u/ejnDBVXydinPa08FFOdAjnivU8sAK+bAI/tklzMQ8A==" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "fe1300d0-ecf8-4bb5-afaf-5030b27959bd",
                columns: new[] { "ConcurrencyStamp", "PasswordHash" },
                values: new object[] { "575d3efd-7888-48eb-8fb8-1e08b2e25fe9", "AQAAAAEAACcQAAAAEHgT3YPKaoXR2y2E3u+sjcfkQ/2u/CTkOJkY28Q2YUOO1glXU6Yvkn060GMzgfucJA==" });

            migrationBuilder.CreateIndex(
                name: "IX_Commande_DelaiPaiementDelai_Id",
                table: "Commande",
                column: "DelaiPaiementDelai_Id");

            migrationBuilder.AddForeignKey(
                name: "FK_Chantier_Centrale_Beton_CentraleBetonCtr_Id",
                table: "Chantier",
                column: "CentraleBetonCtr_Id",
                principalTable: "Centrale_Beton",
                principalColumn: "Ctr_Id",
                onDelete: ReferentialAction.Restrict);

            migrationBuilder.AddForeignKey(
                name: "FK_Commande_Delai_Paiement_DelaiPaiementDelai_Id",
                table: "Commande",
                column: "DelaiPaiementDelai_Id",
                principalTable: "Delai_Paiement",
                principalColumn: "Delai_Id",
                onDelete: ReferentialAction.Restrict);

            migrationBuilder.AddForeignKey(
                name: "FK_DetailCommande_Unite_UniteIdUnite",
                table: "DetailCommande",
                column: "UniteIdUnite",
                principalTable: "Unite",
                principalColumn: "IdUnite",
                onDelete: ReferentialAction.Restrict);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Chantier_Centrale_Beton_CentraleBetonCtr_Id",
                table: "Chantier");

            migrationBuilder.DropForeignKey(
                name: "FK_Commande_Delai_Paiement_DelaiPaiementDelai_Id",
                table: "Commande");

            migrationBuilder.DropForeignKey(
                name: "FK_DetailCommande_Unite_UniteIdUnite",
                table: "DetailCommande");

            migrationBuilder.DropIndex(
                name: "IX_Commande_DelaiPaiementDelai_Id",
                table: "Commande");

            migrationBuilder.DeleteData(
                table: "Article",
                keyColumn: "Article_Id",
                keyValue: 4);

            migrationBuilder.DropColumn(
                name: "Conditions",
                table: "Commande");

            migrationBuilder.DropColumn(
                name: "DelaiPaiementDelai_Id",
                table: "Commande");

            migrationBuilder.DropColumn(
                name: "Delai_Paiement_Id",
                table: "Commande");

            migrationBuilder.DropColumn(
                name: "TarifPompage",
                table: "Commande");

            migrationBuilder.DropColumn(
                name: "TarifTransport",
                table: "Commande");

            migrationBuilder.RenameColumn(
                name: "UniteIdUnite",
                table: "DetailCommande",
                newName: "IdUniteQuantite");

            migrationBuilder.RenameIndex(
                name: "IX_DetailCommande_UniteIdUnite",
                table: "DetailCommande",
                newName: "IX_DetailCommande_IdUniteQuantite");

            migrationBuilder.RenameColumn(
                name: "Delai_Id",
                table: "Delai_Paiement",
                newName: "Delai_ID");

            migrationBuilder.RenameColumn(
                name: "CentraleBetonCtr_Id",
                table: "Chantier",
                newName: "CentraleBetonCtr_ID");

            migrationBuilder.RenameIndex(
                name: "IX_Chantier_CentraleBetonCtr_Id",
                table: "Chantier",
                newName: "IX_Chantier_CentraleBetonCtr_ID");

            migrationBuilder.RenameColumn(
                name: "Ctr_Id",
                table: "Centrale_Beton",
                newName: "Ctr_ID");

            migrationBuilder.RenameColumn(
                name: "Article_Id",
                table: "Article",
                newName: "Article_ID");

            migrationBuilder.AddColumn<int>(
                name: "Ts_Ctn_Id",
                table: "Tarif_Service",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.AddColumn<int>(
                name: "Ctn_Id",
                table: "Paiement",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.AddColumn<int>(
                name: "DelaiPaiementDelai_ID",
                table: "Paiement",
                nullable: true);

            migrationBuilder.AddColumn<int>(
                name: "Delai_Paiement_Id",
                table: "Paiement",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.AddColumn<decimal>(
                name: "PoidsNet",
                table: "DetailCommande",
                type: "decimal(10,2)",
                nullable: true);

            migrationBuilder.AddColumn<decimal>(
                name: "PrixNet",
                table: "DetailCommande",
                type: "decimal(10,2)",
                nullable: true);

            migrationBuilder.AddColumn<decimal>(
                name: "Quantite",
                table: "DetailCommande",
                type: "decimal(10,2)",
                nullable: true);

            migrationBuilder.AddColumn<decimal>(
                name: "ValeurNette",
                table: "DetailCommande",
                type: "decimal(10,2)",
                nullable: true);

            migrationBuilder.UpdateData(
                table: "Article",
                keyColumn: "Article_ID",
                keyValue: 1,
                column: "Designation",
                value: "Beton1");

            migrationBuilder.UpdateData(
                table: "Article",
                keyColumn: "Article_ID",
                keyValue: 2,
                column: "Designation",
                value: "Beton2");

            migrationBuilder.UpdateData(
                table: "Article",
                keyColumn: "Article_ID",
                keyValue: 3,
                columns: new[] { "Designation", "Tarif" },
                values: new object[] { "Beton Spécial", null });

            migrationBuilder.UpdateData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "126a635b-d763-48bf-ab0e-f5599cffb4fe",
                column: "ConcurrencyStamp",
                value: "96245120-947a-4bf1-a0dc-253ec457cdff");

            migrationBuilder.UpdateData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "1588b3b9-37bc-4f58-acf9-e42fd47f1c28",
                column: "ConcurrencyStamp",
                value: "a3cc2d92-e4f9-4235-805f-6f7b0d24f931");

            migrationBuilder.UpdateData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "3e130fc1-981e-4183-a12d-fa5f73d13bb2",
                column: "ConcurrencyStamp",
                value: "58ec72a1-2b30-45ae-b926-613a316ba8af");

            migrationBuilder.UpdateData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "48e33a01-bd1f-4739-a27f-126e8e8b2d1c",
                column: "ConcurrencyStamp",
                value: "b9876449-c98d-43ec-b0ea-235b71bb6edd");

            migrationBuilder.UpdateData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "6eafdfbe-ed07-4687-9d2c-0b767b15a305",
                column: "ConcurrencyStamp",
                value: "f862280c-63af-46e9-8435-63a6b8aa3f55");

            migrationBuilder.UpdateData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "7b8ab704-463e-4074-8c19-a62905f62e11",
                column: "ConcurrencyStamp",
                value: "3ab98be7-119d-429c-9d47-a88d18c62570");

            migrationBuilder.UpdateData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "9be024db-d122-4cd2-8329-2afd0d259e77",
                column: "ConcurrencyStamp",
                value: "54c6a9b0-3d14-470f-8fe3-11da5bd26311");

            migrationBuilder.UpdateData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "a7846740-cb77-4d25-8da6-d5c68dfb590d",
                column: "ConcurrencyStamp",
                value: "1371f708-8447-4312-9163-368ecbbfb818");

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "2e142fe7-a372-4b98-ab9d-dcc4e4966b88",
                columns: new[] { "ConcurrencyStamp", "PasswordHash" },
                values: new object[] { "daadfed7-fe25-41c5-bc87-299a8291f22e", "AQAAAAEAACcQAAAAEGeX5Bit9FXlvOok9eaI7VtrsNDd3j3LCPwOhv/M6XQ5AAOKm58xaYJEI3wD9EsjnQ==" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "3375dc1e-b359-403e-9f13-5e2b395ffafc",
                columns: new[] { "ConcurrencyStamp", "PasswordHash" },
                values: new object[] { "2a691ac2-c890-489d-91c6-9be2b55f27ea", "AQAAAAEAACcQAAAAEGC6Ez6kRtNgB/HNKMymnzNVfchYWNDkOlFIpUd4aZRQ9JsS48Y1Pr2CoDPXzAgb3g==" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "3e45b10c-0d15-49f2-903b-7de4bbc62f98",
                columns: new[] { "ConcurrencyStamp", "PasswordHash" },
                values: new object[] { "59d2453e-2509-4cc9-851e-3feea178a58b", "AQAAAAEAACcQAAAAEHpqqWvnTa/4X3in2Pgokr3yR7GwDpRayFf1RNzSzJoHKxxBhqUtrSWXQgcgjpNiqw==" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "48e50810-f7fc-45c8-8d13-0a03a6a8b1de",
                columns: new[] { "ConcurrencyStamp", "PasswordHash" },
                values: new object[] { "4f11ef7f-983a-4d6b-b6bc-8a3f1d1877f3", "AQAAAAEAACcQAAAAEO7dCEKlntHzo+IipXCp+uk9Id8GVC5hQ2E0jUHYHg87Dn3pCEA2RNgFFDpMyxN0zw==" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "7167d11d-9358-4262-b7a4-77372e1c121d",
                columns: new[] { "ConcurrencyStamp", "PasswordHash" },
                values: new object[] { "bb6e7e79-6b53-455c-a4f7-0a9bddb1959b", "AQAAAAEAACcQAAAAEDr/oNoH+oiDSoEmlOaCflRSifett3atkX4okUPMGhfNQqmyz9wYgkeoiJzf830vAg==" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "b8888a0f-ebcf-4b0a-815a-83ccc0a4c349",
                columns: new[] { "ConcurrencyStamp", "PasswordHash" },
                values: new object[] { "1af20869-25ad-4675-8cdc-3c5764dbc80d", "AQAAAAEAACcQAAAAEFAOkmBtal4oOScJmY+K/hZ3HtJaB1h7JJmevqSZvczdmObkyIANUZhtwytgeneHNw==" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "d19f9bc1-13b4-42b3-881a-a847f4c0684e",
                columns: new[] { "ConcurrencyStamp", "PasswordHash" },
                values: new object[] { "bf73c2eb-d672-49af-9444-47a070072c42", "AQAAAAEAACcQAAAAEFKt/6ikkccY0aMeDhqmpPNIDySOCDqHF7sA5xoKgpgfvnAIvW4Nyty/6G7zdBosXQ==" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "fe1300d0-ecf8-4bb5-afaf-5030b27959bd",
                columns: new[] { "ConcurrencyStamp", "PasswordHash" },
                values: new object[] { "1c4c45cc-c57e-4773-aa69-1630da5464a6", "AQAAAAEAACcQAAAAEEcvSBhwPeqBJxRVLukUeESVjIuNP5rWEYm0fAWqppTPL8jy97KAjvMAyvWRZWkDVg==" });

            migrationBuilder.CreateIndex(
                name: "IX_Tarif_Service_Ts_Ctn_Id",
                table: "Tarif_Service",
                column: "Ts_Ctn_Id");

            migrationBuilder.CreateIndex(
                name: "IX_Paiement_Ctn_Id",
                table: "Paiement",
                column: "Ctn_Id");

            migrationBuilder.CreateIndex(
                name: "IX_Paiement_DelaiPaiementDelai_ID",
                table: "Paiement",
                column: "DelaiPaiementDelai_ID");

            migrationBuilder.AddForeignKey(
                name: "FK_Chantier_Centrale_Beton_CentraleBetonCtr_ID",
                table: "Chantier",
                column: "CentraleBetonCtr_ID",
                principalTable: "Centrale_Beton",
                principalColumn: "Ctr_ID",
                onDelete: ReferentialAction.Restrict);

            migrationBuilder.AddForeignKey(
                name: "FK_DetailCommande_Unite_IdUniteQuantite",
                table: "DetailCommande",
                column: "IdUniteQuantite",
                principalTable: "Unite",
                principalColumn: "IdUnite",
                onDelete: ReferentialAction.Restrict);

            migrationBuilder.AddForeignKey(
                name: "FK_Paiement_Chantier_Ctn_Id",
                table: "Paiement",
                column: "Ctn_Id",
                principalTable: "Chantier",
                principalColumn: "Ctn_Id",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_Paiement_Delai_Paiement_DelaiPaiementDelai_ID",
                table: "Paiement",
                column: "DelaiPaiementDelai_ID",
                principalTable: "Delai_Paiement",
                principalColumn: "Delai_ID",
                onDelete: ReferentialAction.Restrict);

            migrationBuilder.AddForeignKey(
                name: "FK_Tarif_Service_Chantier_Ts_Ctn_Id",
                table: "Tarif_Service",
                column: "Ts_Ctn_Id",
                principalTable: "Chantier",
                principalColumn: "Ctn_Id",
                onDelete: ReferentialAction.Cascade);
        }
    }
}
