using Microsoft.EntityFrameworkCore.Migrations;

namespace Service.Data.Migrations
{
    public partial class DetailCommande : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Commande_Delai_Paiement_DelaiPaiementDelai_Id",
                table: "Commande");

            migrationBuilder.DropIndex(
                name: "IX_Commande_DelaiPaiementDelai_Id",
                table: "Commande");

            migrationBuilder.DropColumn(
                name: "DelaiPaiementDelai_Id",
                table: "Commande");

            migrationBuilder.DropColumn(
                name: "Delai_Paiement_Id",
                table: "Commande");

            migrationBuilder.AddColumn<string>(
                name: "Delai_Paiement",
                table: "Commande",
                nullable: true);

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
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "Delai_Paiement",
                table: "Commande");

            migrationBuilder.AddColumn<int>(
                name: "DelaiPaiementDelai_Id",
                table: "Commande",
                nullable: true);

            migrationBuilder.AddColumn<int>(
                name: "Delai_Paiement_Id",
                table: "Commande",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.UpdateData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "126a635b-d763-48bf-ab0e-f5599cffb4fe",
                column: "ConcurrencyStamp",
                value: "b985ee2a-7a8c-4184-94aa-fff30148f79d");

            migrationBuilder.UpdateData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "1588b3b9-37bc-4f58-acf9-e42fd47f1c28",
                column: "ConcurrencyStamp",
                value: "a43a78bd-3054-4fb8-98eb-83ebdda5d13e");

            migrationBuilder.UpdateData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "3e130fc1-981e-4183-a12d-fa5f73d13bb2",
                column: "ConcurrencyStamp",
                value: "eeeb4552-2567-4c4b-aad5-ec43dc1ea4dd");

            migrationBuilder.UpdateData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "48e33a01-bd1f-4739-a27f-126e8e8b2d1c",
                column: "ConcurrencyStamp",
                value: "babf6afe-6eeb-47ee-aa48-748ff73e9aa3");

            migrationBuilder.UpdateData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "6eafdfbe-ed07-4687-9d2c-0b767b15a305",
                column: "ConcurrencyStamp",
                value: "4b1336b9-8f33-4e82-8d61-fd3964922d73");

            migrationBuilder.UpdateData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "7b8ab704-463e-4074-8c19-a62905f62e11",
                column: "ConcurrencyStamp",
                value: "c328c361-882f-4b4f-b3bc-49fee26bc301");

            migrationBuilder.UpdateData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "9be024db-d122-4cd2-8329-2afd0d259e77",
                column: "ConcurrencyStamp",
                value: "6cc72c9f-281c-4ee7-a6dd-776c74110356");

            migrationBuilder.UpdateData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "a7846740-cb77-4d25-8da6-d5c68dfb590d",
                column: "ConcurrencyStamp",
                value: "8bb223ab-33fd-45b2-a3e0-58887f4d3ef2");

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "2e142fe7-a372-4b98-ab9d-dcc4e4966b88",
                columns: new[] { "ConcurrencyStamp", "PasswordHash" },
                values: new object[] { "d3e54aa6-9687-40a5-b6f2-a1c55b59915f", "AQAAAAEAACcQAAAAECZ8DzIQ3GGyokJdu6sC9AwftKgSmurmPPt3NpzhD80I74EPcRudufgJuTMSOdkIKQ==" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "3375dc1e-b359-403e-9f13-5e2b395ffafc",
                columns: new[] { "ConcurrencyStamp", "PasswordHash" },
                values: new object[] { "8d38efea-1743-4521-b922-6cfc27fcea30", "AQAAAAEAACcQAAAAEK3afvPJrA7GC8vXZ1skkNcStydDeumR2BB0UWC+/lBe2J484rI9hkyP3SJn98s7vg==" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "3e45b10c-0d15-49f2-903b-7de4bbc62f98",
                columns: new[] { "ConcurrencyStamp", "PasswordHash" },
                values: new object[] { "d60dbadf-4597-44d7-990f-7f9af346a414", "AQAAAAEAACcQAAAAEM8VzG10a+2j/y+7Yij+maUogIOVsoCq6bwYa+wKSTcPbfXSSDUyjvHVx6dGvhyPyA==" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "48e50810-f7fc-45c8-8d13-0a03a6a8b1de",
                columns: new[] { "ConcurrencyStamp", "PasswordHash" },
                values: new object[] { "62d6ff72-8268-4bd2-a469-36e61d929e46", "AQAAAAEAACcQAAAAEIZa6x+g2oj0her2UiADtyyosdh4ngrBj2BG5hr8I8JKirphPpfVZ3/vNPFJsI4MLg==" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "7167d11d-9358-4262-b7a4-77372e1c121d",
                columns: new[] { "ConcurrencyStamp", "PasswordHash" },
                values: new object[] { "dca68ed5-3781-43ad-9e82-dfa965ec284e", "AQAAAAEAACcQAAAAEGkYARWyxgAlpS4axLU7YUksdUCjY5RnW+rrIynUzwxxK97Bv2Zzc6lppqV1lGnGfQ==" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "b8888a0f-ebcf-4b0a-815a-83ccc0a4c349",
                columns: new[] { "ConcurrencyStamp", "PasswordHash" },
                values: new object[] { "828d3b25-aff1-41e0-ae2e-e65cb3884199", "AQAAAAEAACcQAAAAEJg+9SYoyjUbN72cR8nd4/6W0x862uHiPeHWaLrfWm0t7XCUsEuF1rP0Sl6/Zr4yVg==" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "d19f9bc1-13b4-42b3-881a-a847f4c0684e",
                columns: new[] { "ConcurrencyStamp", "PasswordHash" },
                values: new object[] { "d163921a-d6ba-41eb-a925-602dfbad1e52", "AQAAAAEAACcQAAAAEGuEjF/ETf7BzTngq/VFjlj7Rn/WhGQPcF7H7r2jgygNxvclO3yo+SXGB0i2PUsjnQ==" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "fe1300d0-ecf8-4bb5-afaf-5030b27959bd",
                columns: new[] { "ConcurrencyStamp", "PasswordHash" },
                values: new object[] { "9fb15432-698f-43b3-ac7f-e50bf0021bac", "AQAAAAEAACcQAAAAEKynR0WoYeYhJWUkKiWKTyexKYtKRk6GtmYF2x/zoPpQs5PWK41mNHO11Hf0EWjQtg==" });

            migrationBuilder.CreateIndex(
                name: "IX_Commande_DelaiPaiementDelai_Id",
                table: "Commande",
                column: "DelaiPaiementDelai_Id");

            migrationBuilder.AddForeignKey(
                name: "FK_Commande_Delai_Paiement_DelaiPaiementDelai_Id",
                table: "Commande",
                column: "DelaiPaiementDelai_Id",
                principalTable: "Delai_Paiement",
                principalColumn: "Delai_Id",
                onDelete: ReferentialAction.Restrict);
        }
    }
}
