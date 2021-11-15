using Microsoft.EntityFrameworkCore.Migrations;

namespace Service.Data.Migrations
{
    public partial class Centrale_Fix : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "Ctr_Nom",
                table: "Chantier");

            migrationBuilder.AddColumn<string>(
                name: "Ctr_Nom",
                table: "Centrale_Beton",
                type: "nvarchar(80)",
                nullable: true);

            migrationBuilder.UpdateData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "126a635b-d763-48bf-ab0e-f5599cffb4fe",
                column: "ConcurrencyStamp",
                value: "223fc2e2-8a6a-442d-8c75-9b7a2d3dd0b8");

            migrationBuilder.UpdateData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "1588b3b9-37bc-4f58-acf9-e42fd47f1c28",
                column: "ConcurrencyStamp",
                value: "b73abfd0-2838-435b-a905-b5e64a7707dc");

            migrationBuilder.UpdateData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "3e130fc1-981e-4183-a12d-fa5f73d13bb2",
                column: "ConcurrencyStamp",
                value: "3b162312-3ec6-446c-adcd-42177acb74d0");

            migrationBuilder.UpdateData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "48e33a01-bd1f-4739-a27f-126e8e8b2d1c",
                column: "ConcurrencyStamp",
                value: "3f98d6d8-7ff1-44f2-add3-6b34f43bea71");

            migrationBuilder.UpdateData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "6eafdfbe-ed07-4687-9d2c-0b767b15a305",
                column: "ConcurrencyStamp",
                value: "b966c6e4-2b50-493a-b7b9-9f21da669710");

            migrationBuilder.UpdateData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "7b8ab704-463e-4074-8c19-a62905f62e11",
                column: "ConcurrencyStamp",
                value: "e081d97d-5151-4cf3-9bea-edd8eee730d6");

            migrationBuilder.UpdateData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "9be024db-d122-4cd2-8329-2afd0d259e77",
                column: "ConcurrencyStamp",
                value: "0d127e73-6274-486e-aae6-74a39db7202e");

            migrationBuilder.UpdateData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "a7846740-cb77-4d25-8da6-d5c68dfb590d",
                column: "ConcurrencyStamp",
                value: "31e126dc-8add-46b9-ab5c-754231b316a2");

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "2e142fe7-a372-4b98-ab9d-dcc4e4966b88",
                columns: new[] { "ConcurrencyStamp", "PasswordHash" },
                values: new object[] { "7cd6822f-3e9e-4d71-97eb-55e6122b8405", "AQAAAAEAACcQAAAAEEi/2ZUQdojkLm7quFC2G/8vQHg/RxdAulh7W/+r0sxTnuq4x50YhpvGRf7j3QC/Ug==" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "3375dc1e-b359-403e-9f13-5e2b395ffafc",
                columns: new[] { "ConcurrencyStamp", "PasswordHash" },
                values: new object[] { "c1802024-6249-4e65-9d37-8a73464d5ae0", "AQAAAAEAACcQAAAAEBUqmKJcVA8c+JManRXu33VtyDTPYww3d3tRw7r/4UUTL9ztnk2EGAAt5taCWgj9yg==" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "3e45b10c-0d15-49f2-903b-7de4bbc62f98",
                columns: new[] { "ConcurrencyStamp", "PasswordHash" },
                values: new object[] { "f991a328-bf5e-487a-a3d0-e0e680f6c415", "AQAAAAEAACcQAAAAEMJ9ngZ0x5+SRJFdpB8Gg8JSb1OfjzUT6SKsjwo7GfmSP26xv/QJVskGNKdZ989TFQ==" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "48e50810-f7fc-45c8-8d13-0a03a6a8b1de",
                columns: new[] { "ConcurrencyStamp", "PasswordHash" },
                values: new object[] { "24f2abe8-6a8d-408b-aa0f-c01690095444", "AQAAAAEAACcQAAAAEHZnDWLA3oxOThh1J3+sFgx13PcZEoXlPs005PNxUYwKNx12FHfN/u8RMDQ4ljorHA==" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "7167d11d-9358-4262-b7a4-77372e1c121d",
                columns: new[] { "ConcurrencyStamp", "PasswordHash" },
                values: new object[] { "5b4ebdad-8f9f-48de-b75f-161a173be444", "AQAAAAEAACcQAAAAEJb95KKWMvuB+NzUkTvwh8Mp1PpM6WGPbUJ+XBV77IhfZqIqgjwDtBQeI/w7BwPY4g==" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "b8888a0f-ebcf-4b0a-815a-83ccc0a4c349",
                columns: new[] { "ConcurrencyStamp", "PasswordHash" },
                values: new object[] { "6a57fae1-16fa-4904-ba78-e4ffd1ea080c", "AQAAAAEAACcQAAAAEA+VY1bZSEinVNaNliMpQjCKoBnH4wcOCNF204tfuue7iLOtLjPTZWq1UY9oZgYzhA==" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "d19f9bc1-13b4-42b3-881a-a847f4c0684e",
                columns: new[] { "ConcurrencyStamp", "PasswordHash" },
                values: new object[] { "d6f064da-69c8-4596-a9c2-b6d8586e6c36", "AQAAAAEAACcQAAAAEKkgS9fjnZeqhN8B7Ba87gfzneb433zjImQTSyzygmR1NCggwSxiCB4huP5PsHZpUg==" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "fe1300d0-ecf8-4bb5-afaf-5030b27959bd",
                columns: new[] { "ConcurrencyStamp", "PasswordHash" },
                values: new object[] { "6fd8073d-e7db-4a04-8618-1ed2fa7493c4", "AQAAAAEAACcQAAAAEIZzxaWUcLyjJD/ZT6srhQ2bbAUjJcqtoUw4PgpUIWrXCczp35AwX7eK20Cu+9PvjQ==" });

            migrationBuilder.UpdateData(
                table: "Centrale_Beton",
                keyColumn: "Ctr_Id",
                keyValue: 1,
                column: "Ctr_Nom",
                value: "Centrale 1");

            migrationBuilder.UpdateData(
                table: "Centrale_Beton",
                keyColumn: "Ctr_Id",
                keyValue: 2,
                column: "Ctr_Nom",
                value: "Centrale 2");

            migrationBuilder.UpdateData(
                table: "Centrale_Beton",
                keyColumn: "Ctr_Id",
                keyValue: 3,
                column: "Ctr_Nom",
                value: "Centrale 3");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "Ctr_Nom",
                table: "Centrale_Beton");

            migrationBuilder.AddColumn<string>(
                name: "Ctr_Nom",
                table: "Chantier",
                nullable: true);

            migrationBuilder.UpdateData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "126a635b-d763-48bf-ab0e-f5599cffb4fe",
                column: "ConcurrencyStamp",
                value: "b2096985-8522-422d-bac5-32e2781e8808");

            migrationBuilder.UpdateData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "1588b3b9-37bc-4f58-acf9-e42fd47f1c28",
                column: "ConcurrencyStamp",
                value: "736d916f-13ea-404c-b967-eddabb9b0e65");

            migrationBuilder.UpdateData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "3e130fc1-981e-4183-a12d-fa5f73d13bb2",
                column: "ConcurrencyStamp",
                value: "0c6f9534-c2a7-432a-887d-2b9551f2ce81");

            migrationBuilder.UpdateData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "48e33a01-bd1f-4739-a27f-126e8e8b2d1c",
                column: "ConcurrencyStamp",
                value: "9fbe78b1-096b-46dd-805f-beee260384e1");

            migrationBuilder.UpdateData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "6eafdfbe-ed07-4687-9d2c-0b767b15a305",
                column: "ConcurrencyStamp",
                value: "fd5bfc02-e596-46e0-b0a2-3a8e592a2c92");

            migrationBuilder.UpdateData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "7b8ab704-463e-4074-8c19-a62905f62e11",
                column: "ConcurrencyStamp",
                value: "f393de5a-13d2-469f-b862-5dac405c2675");

            migrationBuilder.UpdateData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "9be024db-d122-4cd2-8329-2afd0d259e77",
                column: "ConcurrencyStamp",
                value: "484c29d1-2795-43ea-8fc4-35360234e681");

            migrationBuilder.UpdateData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "a7846740-cb77-4d25-8da6-d5c68dfb590d",
                column: "ConcurrencyStamp",
                value: "528f5546-a07f-45d7-92b1-8b413e62dc14");

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "2e142fe7-a372-4b98-ab9d-dcc4e4966b88",
                columns: new[] { "ConcurrencyStamp", "PasswordHash" },
                values: new object[] { "47cf3fe0-9693-4cd8-852e-886824156592", "AQAAAAEAACcQAAAAEDGb/AHkerrcncJ1f5RNI6GG+paKO8ku/cKhplhMH+TR01ILCyGwKQJ/9j3KzaqAng==" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "3375dc1e-b359-403e-9f13-5e2b395ffafc",
                columns: new[] { "ConcurrencyStamp", "PasswordHash" },
                values: new object[] { "10a98e77-4f61-4929-868f-e69d46fc81e9", "AQAAAAEAACcQAAAAEMSqn+cOL5t9zLm94ANNjrge88malTsOq1WHmDZOSnVVlw2dL2KD0TjW122RmpkOsQ==" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "3e45b10c-0d15-49f2-903b-7de4bbc62f98",
                columns: new[] { "ConcurrencyStamp", "PasswordHash" },
                values: new object[] { "bfbd7d45-274d-4e2f-86ac-056afeeae244", "AQAAAAEAACcQAAAAEA7IUrXz/14Ylbueft1/++zZkkIlrbjDc5IHtm4tvS48UwGFFrXc3035QrmMIAw6Lg==" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "48e50810-f7fc-45c8-8d13-0a03a6a8b1de",
                columns: new[] { "ConcurrencyStamp", "PasswordHash" },
                values: new object[] { "2ae1e077-3c3b-462c-ba02-6f0d5a1fe7b9", "AQAAAAEAACcQAAAAEB/mKC/sug5MFldpwHe1JxzikAM5G2OBiv7uhsACTYbqLQfQ8v/z6f2Z4Bb4AokFgQ==" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "7167d11d-9358-4262-b7a4-77372e1c121d",
                columns: new[] { "ConcurrencyStamp", "PasswordHash" },
                values: new object[] { "51f294bc-ae2d-47eb-bd43-fae3185774e1", "AQAAAAEAACcQAAAAEPmjywMnxqckB3SsNY3oiJaQJSKzjMVhWKVxPZD4ojVEaDWlKLecW0GQJdL+RmW6Uw==" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "b8888a0f-ebcf-4b0a-815a-83ccc0a4c349",
                columns: new[] { "ConcurrencyStamp", "PasswordHash" },
                values: new object[] { "1dfda60e-8dc9-4e9a-839b-e58ddbda5198", "AQAAAAEAACcQAAAAECrnuFUvaPc/d12gGDfwNADCTvZX843jWC1mCWX2VJUfj2HP7wdLY9//x2wC+mSZPw==" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "d19f9bc1-13b4-42b3-881a-a847f4c0684e",
                columns: new[] { "ConcurrencyStamp", "PasswordHash" },
                values: new object[] { "e1e1394d-b7f7-49b3-b710-332c7e90c620", "AQAAAAEAACcQAAAAENKnfHZmCGL4FqSBB78pegkyNLo9iwGdyOTrDjUHNucEmiw6eU3Yf37fpKinPrvpLQ==" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "fe1300d0-ecf8-4bb5-afaf-5030b27959bd",
                columns: new[] { "ConcurrencyStamp", "PasswordHash" },
                values: new object[] { "cd1451e7-5992-468e-9df3-266f4c06a91b", "AQAAAAEAACcQAAAAEIU6cJdUs0SRcU3VQtHcaFM6j8XEtoq3JMR90yh91Jh4YhK2YCLDpXRVSApt1y4nWg==" });
        }
    }
}
