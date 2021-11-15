using Microsoft.EntityFrameworkCore.Migrations;

namespace Service.Data.Migrations
{
    public partial class centrale : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Chantier_Centrale_Beton_CentraleBetonCtr_Id",
                table: "Chantier");

            migrationBuilder.DropForeignKey(
                name: "FK_Chantier_Type_Chantier_TypeChantierTc_Id",
                table: "Chantier");

            migrationBuilder.DropIndex(
                name: "IX_Chantier_CentraleBetonCtr_Id",
                table: "Chantier");

            migrationBuilder.DropIndex(
                name: "IX_Chantier_TypeChantierTc_Id",
                table: "Chantier");

            migrationBuilder.DropColumn(
                name: "CentraleBetonCtr_Id",
                table: "Chantier");

            migrationBuilder.DropColumn(
                name: "TypeChantierTc_Id",
                table: "Chantier");

            migrationBuilder.DropColumn(
                name: "Ctr_Nom",
                table: "Centrale_Beton");

            migrationBuilder.AlterColumn<string>(
                name: "Ctr_Adresse",
                table: "Centrale_Beton",
                type: "nvarchar(100)",
                nullable: true,
                oldClrType: typeof(string),
                oldNullable: true);

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

            migrationBuilder.CreateIndex(
                name: "IX_Chantier_Ctn_Ctr_Id",
                table: "Chantier",
                column: "Ctn_Ctr_Id");

            migrationBuilder.CreateIndex(
                name: "IX_Chantier_Ctn_Tc_Id",
                table: "Chantier",
                column: "Ctn_Tc_Id");

            migrationBuilder.AddForeignKey(
                name: "FK_Chantier_Centrale_Beton_Ctn_Ctr_Id",
                table: "Chantier",
                column: "Ctn_Ctr_Id",
                principalTable: "Centrale_Beton",
                principalColumn: "Ctr_Id",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_Chantier_Type_Chantier_Ctn_Tc_Id",
                table: "Chantier",
                column: "Ctn_Tc_Id",
                principalTable: "Type_Chantier",
                principalColumn: "Tc_Id",
                onDelete: ReferentialAction.Cascade);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Chantier_Centrale_Beton_Ctn_Ctr_Id",
                table: "Chantier");

            migrationBuilder.DropForeignKey(
                name: "FK_Chantier_Type_Chantier_Ctn_Tc_Id",
                table: "Chantier");

            migrationBuilder.DropIndex(
                name: "IX_Chantier_Ctn_Ctr_Id",
                table: "Chantier");

            migrationBuilder.DropIndex(
                name: "IX_Chantier_Ctn_Tc_Id",
                table: "Chantier");

            migrationBuilder.AddColumn<int>(
                name: "CentraleBetonCtr_Id",
                table: "Chantier",
                nullable: true);

            migrationBuilder.AddColumn<int>(
                name: "TypeChantierTc_Id",
                table: "Chantier",
                nullable: true);

            migrationBuilder.AlterColumn<string>(
                name: "Ctr_Adresse",
                table: "Centrale_Beton",
                nullable: true,
                oldClrType: typeof(string),
                oldType: "nvarchar(100)",
                oldNullable: true);

            migrationBuilder.AddColumn<string>(
                name: "Ctr_Nom",
                table: "Centrale_Beton",
                type: "nvarchar(100)",
                nullable: true);

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

            migrationBuilder.CreateIndex(
                name: "IX_Chantier_CentraleBetonCtr_Id",
                table: "Chantier",
                column: "CentraleBetonCtr_Id");

            migrationBuilder.CreateIndex(
                name: "IX_Chantier_TypeChantierTc_Id",
                table: "Chantier",
                column: "TypeChantierTc_Id");

            migrationBuilder.AddForeignKey(
                name: "FK_Chantier_Centrale_Beton_CentraleBetonCtr_Id",
                table: "Chantier",
                column: "CentraleBetonCtr_Id",
                principalTable: "Centrale_Beton",
                principalColumn: "Ctr_Id",
                onDelete: ReferentialAction.Restrict);

            migrationBuilder.AddForeignKey(
                name: "FK_Chantier_Type_Chantier_TypeChantierTc_Id",
                table: "Chantier",
                column: "TypeChantierTc_Id",
                principalTable: "Type_Chantier",
                principalColumn: "Tc_Id",
                onDelete: ReferentialAction.Restrict);
        }
    }
}
