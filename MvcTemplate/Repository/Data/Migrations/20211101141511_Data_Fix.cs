using Microsoft.EntityFrameworkCore.Migrations;

namespace Service.Data.Migrations
{
    public partial class Data_Fix : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
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

            migrationBuilder.UpdateData(
                table: "Forme_Juridique",
                keyColumn: "FormeJuridique_Id",
                keyValue: 1,
                column: "FormeJuridique_Libelle",
                value: "SA");

            migrationBuilder.UpdateData(
                table: "Forme_Juridique",
                keyColumn: "FormeJuridique_Id",
                keyValue: 2,
                column: "FormeJuridique_Libelle",
                value: "SARL");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.UpdateData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "126a635b-d763-48bf-ab0e-f5599cffb4fe",
                column: "ConcurrencyStamp",
                value: "9e88d6c0-09c4-4377-b2d2-73505d32814e");

            migrationBuilder.UpdateData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "1588b3b9-37bc-4f58-acf9-e42fd47f1c28",
                column: "ConcurrencyStamp",
                value: "93e927fa-b10f-44b6-81db-49518e0f2a04");

            migrationBuilder.UpdateData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "3e130fc1-981e-4183-a12d-fa5f73d13bb2",
                column: "ConcurrencyStamp",
                value: "9e7a40b9-de27-47a9-84ae-c42a06dc92cb");

            migrationBuilder.UpdateData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "48e33a01-bd1f-4739-a27f-126e8e8b2d1c",
                column: "ConcurrencyStamp",
                value: "476bb31e-242d-4adf-9d30-8ce4afc99363");

            migrationBuilder.UpdateData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "6eafdfbe-ed07-4687-9d2c-0b767b15a305",
                column: "ConcurrencyStamp",
                value: "25ff01c0-e487-4c9a-a847-d689c7f1f74a");

            migrationBuilder.UpdateData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "7b8ab704-463e-4074-8c19-a62905f62e11",
                column: "ConcurrencyStamp",
                value: "cc9a1463-ee36-4682-a236-932519762db8");

            migrationBuilder.UpdateData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "9be024db-d122-4cd2-8329-2afd0d259e77",
                column: "ConcurrencyStamp",
                value: "7d574cf3-51a9-4b38-b991-35cec774bdef");

            migrationBuilder.UpdateData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "a7846740-cb77-4d25-8da6-d5c68dfb590d",
                column: "ConcurrencyStamp",
                value: "16be869b-3380-422f-9e39-ca899024b371");

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "2e142fe7-a372-4b98-ab9d-dcc4e4966b88",
                columns: new[] { "ConcurrencyStamp", "PasswordHash" },
                values: new object[] { "01af92f8-34ed-4627-9cf4-cecdd7dae4c8", "AQAAAAEAACcQAAAAEAhRLyowQqHstfGf3TvxtRiWGPTSN4k9LdGj2jlt07Se0nTHgQQveH6zmQdN+uqVlg==" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "3375dc1e-b359-403e-9f13-5e2b395ffafc",
                columns: new[] { "ConcurrencyStamp", "PasswordHash" },
                values: new object[] { "929355b3-1a68-4eef-9480-b45920e9931c", "AQAAAAEAACcQAAAAEDHIp8JRZc2QHIxxVEr3VG6KbgKbOOyY2+r/3uyJNm5R3bWm0w9v/kKSdqORscQjMQ==" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "3e45b10c-0d15-49f2-903b-7de4bbc62f98",
                columns: new[] { "ConcurrencyStamp", "PasswordHash" },
                values: new object[] { "54a46574-f4f4-422f-a363-06bd9323d8fa", "AQAAAAEAACcQAAAAEDQkU0FqLoQiuMbznt3mo0YX8C95vm5bPNZ90yvPm1TqJN0hKMGNI4kGKpRiwm/TUw==" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "48e50810-f7fc-45c8-8d13-0a03a6a8b1de",
                columns: new[] { "ConcurrencyStamp", "PasswordHash" },
                values: new object[] { "3816814a-7022-42b5-8196-92d4f4735d62", "AQAAAAEAACcQAAAAEHhOwU0EJZTgzP/2N0gX17iQC8XRY1Syh2gS9s7HZ7cnLJgppfdbtYDE+GG2iU0qaQ==" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "7167d11d-9358-4262-b7a4-77372e1c121d",
                columns: new[] { "ConcurrencyStamp", "PasswordHash" },
                values: new object[] { "aa08231c-f15f-4864-9ab1-b6fb3e68690a", "AQAAAAEAACcQAAAAEF/hCYAaYMm1uUeeAmXgdHgn/vyG51oPYV9lV0ULGBprF0fx6TdHI/hk+hTDgDuU9A==" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "b8888a0f-ebcf-4b0a-815a-83ccc0a4c349",
                columns: new[] { "ConcurrencyStamp", "PasswordHash" },
                values: new object[] { "99e0036f-c07e-4d58-bdf1-6e15581006f7", "AQAAAAEAACcQAAAAEAT33LCGvQimY78+VI/klIcfRFxFhW+XxfnmutksbotA1vQEHw732yq9jzwUfXnKsg==" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "d19f9bc1-13b4-42b3-881a-a847f4c0684e",
                columns: new[] { "ConcurrencyStamp", "PasswordHash" },
                values: new object[] { "43629672-f562-4a1d-8b15-35c5cd2b69f0", "AQAAAAEAACcQAAAAEJX/dZrtvar34YEoUOEu6tN5eTYdrKrmcgZYD3FQBXD1gxGpG1m3XHxqI0kErkOABw==" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "fe1300d0-ecf8-4bb5-afaf-5030b27959bd",
                columns: new[] { "ConcurrencyStamp", "PasswordHash" },
                values: new object[] { "bfa71934-88cf-43a4-97ca-924386d26dc4", "AQAAAAEAACcQAAAAEGjIhcvfuqdM0tBmo1y1247gttLYPD423q9BKpwLBoWJHsfBP0l6caM9+acptnRI4A==" });

            migrationBuilder.UpdateData(
                table: "Forme_Juridique",
                keyColumn: "FormeJuridique_Id",
                keyValue: 1,
                column: "FormeJuridique_Libelle",
                value: null);

            migrationBuilder.UpdateData(
                table: "Forme_Juridique",
                keyColumn: "FormeJuridique_Id",
                keyValue: 2,
                column: "FormeJuridique_Libelle",
                value: null);
        }
    }
}
