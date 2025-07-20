using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

#pragma warning disable CA1814 // Prefer jagged arrays over multidimensional

namespace YmypMovieProject.DataAccess.Migrations
{
    /// <inheritdoc />
    public partial class statusNowableOnUser : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: new Guid("5b486422-a807-4691-9559-ef40b4b3a2bf"));

            migrationBuilder.DeleteData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: new Guid("86cfa488-3aa9-49a6-8a36-da861a109093"));

            migrationBuilder.DeleteData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: new Guid("88ace8d5-eaab-49b9-b6dc-2667fd98f877"));

            migrationBuilder.DeleteData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: new Guid("953429a4-3107-40a6-8c12-cd29b9009cde"));

            migrationBuilder.DeleteData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: new Guid("9db15b1e-545c-4e5d-829f-76fd98c03da5"));

            migrationBuilder.DeleteData(
                table: "Directors",
                keyColumn: "Id",
                keyValue: new Guid("559599d6-361c-4c62-ad0e-a99a0efc8deb"));

            migrationBuilder.DeleteData(
                table: "Directors",
                keyColumn: "Id",
                keyValue: new Guid("ad213a55-1d1b-4b19-977c-5d08a41b3e95"));

            migrationBuilder.DeleteData(
                table: "Directors",
                keyColumn: "Id",
                keyValue: new Guid("c8488697-5726-4327-8339-2c5c88246778"));

            migrationBuilder.DeleteData(
                table: "Directors",
                keyColumn: "Id",
                keyValue: new Guid("e8cb2ba3-b11c-41db-9782-863519978373"));

            migrationBuilder.DeleteData(
                table: "Movies",
                keyColumn: "Id",
                keyValue: new Guid("1ba8b297-3d2f-47a3-b228-dbb501a03eaa"));

            migrationBuilder.DeleteData(
                table: "Movies",
                keyColumn: "Id",
                keyValue: new Guid("4bc98310-e074-479a-922a-ac7515bd029e"));

            migrationBuilder.DeleteData(
                table: "Movies",
                keyColumn: "Id",
                keyValue: new Guid("ce27e651-eecc-4dc3-9638-3a1533574a49"));

            migrationBuilder.AlterColumn<string>(
                name: "Status",
                table: "Users",
                type: "nvarchar(max)",
                nullable: true,
                oldClrType: typeof(string),
                oldType: "nvarchar(max)");

            migrationBuilder.UpdateData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: new Guid("7fe0ac2b-fa60-4004-a579-c5967a1746a1"),
                column: "CreateAt",
                value: new DateTime(2025, 7, 20, 15, 9, 20, 286, DateTimeKind.Utc).AddTicks(3443));

            migrationBuilder.InsertData(
                table: "Categories",
                columns: new[] { "Id", "CreateAt", "Description", "IsActive", "IsDeleted", "Name", "UpdateAt" },
                values: new object[,]
                {
                    { new Guid("16e36642-5a79-4892-8a90-3a7bc8c6c7e3"), new DateTime(2025, 7, 20, 15, 9, 20, 286, DateTimeKind.Utc).AddTicks(3480), null, true, false, "Korku", null },
                    { new Guid("53b9e674-fb67-4d06-a76f-fbff082ef00c"), new DateTime(2025, 7, 20, 15, 9, 20, 286, DateTimeKind.Utc).AddTicks(3462), null, true, false, "Bilim Kurgu", null },
                    { new Guid("62ad7cd3-5fa4-4d45-9a14-2242f24e8198"), new DateTime(2025, 7, 20, 15, 9, 20, 286, DateTimeKind.Utc).AddTicks(3471), null, true, false, "Fantastik", null },
                    { new Guid("67afdf6b-8cab-4818-848d-d3445a655f52"), new DateTime(2025, 7, 20, 15, 9, 20, 286, DateTimeKind.Utc).AddTicks(3466), null, true, false, "Belgesel", null },
                    { new Guid("fe36c782-7ceb-4bb1-8078-e95d6d803eb3"), new DateTime(2025, 7, 20, 15, 9, 20, 286, DateTimeKind.Utc).AddTicks(3456), null, true, false, "Komedi", null }
                });

            migrationBuilder.UpdateData(
                table: "Directors",
                keyColumn: "Id",
                keyValue: new Guid("2950d635-d293-4c82-a9fb-f23f8cfa5956"),
                column: "CreateAt",
                value: new DateTime(2025, 7, 20, 15, 9, 20, 286, DateTimeKind.Utc).AddTicks(3744));

            migrationBuilder.InsertData(
                table: "Directors",
                columns: new[] { "Id", "BirthDate", "CreateAt", "Description", "FirstName", "ImageUrl", "IsActive", "IsDeleted", "LastName", "UpdateAt" },
                values: new object[,]
                {
                    { new Guid("96f6b758-0d8b-47b0-90fc-1862f8d8c4ae"), new DateTime(1946, 12, 18, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2025, 7, 20, 15, 9, 20, 286, DateTimeKind.Utc).AddTicks(3815), "American film director, producer, and screenwriter.", "Steven", null, true, false, "Spielberg", null },
                    { new Guid("a3e6db84-e7f6-423d-b800-d97c188c753b"), new DateTime(1963, 3, 27, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2025, 7, 20, 15, 9, 20, 286, DateTimeKind.Utc).AddTicks(3832), "American filmmaker, actor, and screenwriter.", "Quentin", null, true, false, "Tarantino", null },
                    { new Guid("de2f43d0-46fe-40b4-bb9e-1e9454cec98d"), new DateTime(1942, 11, 17, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2025, 7, 20, 15, 9, 20, 286, DateTimeKind.Utc).AddTicks(3822), "American film director, producer, screenwriter, and actor.", "Martin", null, true, false, "Scorsese", null },
                    { new Guid("fc83371f-c77c-4ada-b3f8-2e92f38db95f"), new DateTime(1954, 8, 16, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2025, 7, 20, 15, 9, 20, 286, DateTimeKind.Utc).AddTicks(3837), "Canadian filmmaker and environmental advocate.", "James", null, true, false, "Cameron", null }
                });

            migrationBuilder.InsertData(
                table: "Movies",
                columns: new[] { "Id", "CategoryId", "CreateAt", "Description", "DirectorId", "IMDB", "ImageUrl", "IsActive", "IsDeleted", "Name", "PublishDate", "UpdateAt" },
                values: new object[,]
                {
                    { new Guid("2b25dd5c-7a1d-4844-ade0-251a24bd3aa6"), new Guid("7fe0ac2b-fa60-4004-a579-c5967a1746a1"), new DateTime(2025, 7, 20, 15, 9, 20, 286, DateTimeKind.Utc).AddTicks(3908), "A team of explorers travel through a wormhole in space in an attempt to ensure humanity's survival.", new Guid("2950d635-d293-4c82-a9fb-f23f8cfa5956"), 8.6m, null, true, false, "Interstellar", new DateTime(2014, 11, 7, 0, 0, 0, 0, DateTimeKind.Unspecified), null },
                    { new Guid("3285ccd4-7572-42a0-85b2-8db2907d2526"), new Guid("7fe0ac2b-fa60-4004-a579-c5967a1746a1"), new DateTime(2025, 7, 20, 15, 9, 20, 286, DateTimeKind.Utc).AddTicks(3897), "When the menace known as the Joker emerges from his mysterious past, he wreaks havoc and chaos on the people of Gotham.", new Guid("2950d635-d293-4c82-a9fb-f23f8cfa5956"), 9.0m, null, true, false, "The Dark Knight", new DateTime(2008, 7, 18, 0, 0, 0, 0, DateTimeKind.Unspecified), null },
                    { new Guid("ca51bb32-c888-4427-9af2-38abdd7e0ae1"), new Guid("7fe0ac2b-fa60-4004-a579-c5967a1746a1"), new DateTime(2025, 7, 20, 15, 9, 20, 286, DateTimeKind.Utc).AddTicks(3880), "A thief who steals corporate secrets through the use of dream-sharing technology is given the inverse task of planting an idea into the mind of a CEO.", new Guid("2950d635-d293-4c82-a9fb-f23f8cfa5956"), 8.8m, null, true, false, "Inception", new DateTime(2010, 7, 16, 0, 0, 0, 0, DateTimeKind.Unspecified), null }
                });
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: new Guid("16e36642-5a79-4892-8a90-3a7bc8c6c7e3"));

            migrationBuilder.DeleteData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: new Guid("53b9e674-fb67-4d06-a76f-fbff082ef00c"));

            migrationBuilder.DeleteData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: new Guid("62ad7cd3-5fa4-4d45-9a14-2242f24e8198"));

            migrationBuilder.DeleteData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: new Guid("67afdf6b-8cab-4818-848d-d3445a655f52"));

            migrationBuilder.DeleteData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: new Guid("fe36c782-7ceb-4bb1-8078-e95d6d803eb3"));

            migrationBuilder.DeleteData(
                table: "Directors",
                keyColumn: "Id",
                keyValue: new Guid("96f6b758-0d8b-47b0-90fc-1862f8d8c4ae"));

            migrationBuilder.DeleteData(
                table: "Directors",
                keyColumn: "Id",
                keyValue: new Guid("a3e6db84-e7f6-423d-b800-d97c188c753b"));

            migrationBuilder.DeleteData(
                table: "Directors",
                keyColumn: "Id",
                keyValue: new Guid("de2f43d0-46fe-40b4-bb9e-1e9454cec98d"));

            migrationBuilder.DeleteData(
                table: "Directors",
                keyColumn: "Id",
                keyValue: new Guid("fc83371f-c77c-4ada-b3f8-2e92f38db95f"));

            migrationBuilder.DeleteData(
                table: "Movies",
                keyColumn: "Id",
                keyValue: new Guid("2b25dd5c-7a1d-4844-ade0-251a24bd3aa6"));

            migrationBuilder.DeleteData(
                table: "Movies",
                keyColumn: "Id",
                keyValue: new Guid("3285ccd4-7572-42a0-85b2-8db2907d2526"));

            migrationBuilder.DeleteData(
                table: "Movies",
                keyColumn: "Id",
                keyValue: new Guid("ca51bb32-c888-4427-9af2-38abdd7e0ae1"));

            migrationBuilder.AlterColumn<string>(
                name: "Status",
                table: "Users",
                type: "nvarchar(max)",
                nullable: false,
                defaultValue: "",
                oldClrType: typeof(string),
                oldType: "nvarchar(max)",
                oldNullable: true);

            migrationBuilder.UpdateData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: new Guid("7fe0ac2b-fa60-4004-a579-c5967a1746a1"),
                column: "CreateAt",
                value: new DateTime(2025, 7, 13, 19, 14, 48, 274, DateTimeKind.Utc).AddTicks(2363));

            migrationBuilder.InsertData(
                table: "Categories",
                columns: new[] { "Id", "CreateAt", "Description", "IsActive", "IsDeleted", "Name", "UpdateAt" },
                values: new object[,]
                {
                    { new Guid("5b486422-a807-4691-9559-ef40b4b3a2bf"), new DateTime(2025, 7, 13, 19, 14, 48, 274, DateTimeKind.Utc).AddTicks(2384), null, true, false, "Belgesel", null },
                    { new Guid("86cfa488-3aa9-49a6-8a36-da861a109093"), new DateTime(2025, 7, 13, 19, 14, 48, 274, DateTimeKind.Utc).AddTicks(2412), null, true, false, "Korku", null },
                    { new Guid("88ace8d5-eaab-49b9-b6dc-2667fd98f877"), new DateTime(2025, 7, 13, 19, 14, 48, 274, DateTimeKind.Utc).AddTicks(2380), null, true, false, "Bilim Kurgu", null },
                    { new Guid("953429a4-3107-40a6-8c12-cd29b9009cde"), new DateTime(2025, 7, 13, 19, 14, 48, 274, DateTimeKind.Utc).AddTicks(2375), null, true, false, "Komedi", null },
                    { new Guid("9db15b1e-545c-4e5d-829f-76fd98c03da5"), new DateTime(2025, 7, 13, 19, 14, 48, 274, DateTimeKind.Utc).AddTicks(2407), null, true, false, "Fantastik", null }
                });

            migrationBuilder.UpdateData(
                table: "Directors",
                keyColumn: "Id",
                keyValue: new Guid("2950d635-d293-4c82-a9fb-f23f8cfa5956"),
                column: "CreateAt",
                value: new DateTime(2025, 7, 13, 19, 14, 48, 274, DateTimeKind.Utc).AddTicks(2704));

            migrationBuilder.InsertData(
                table: "Directors",
                columns: new[] { "Id", "BirthDate", "CreateAt", "Description", "FirstName", "ImageUrl", "IsActive", "IsDeleted", "LastName", "UpdateAt" },
                values: new object[,]
                {
                    { new Guid("559599d6-361c-4c62-ad0e-a99a0efc8deb"), new DateTime(1954, 8, 16, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2025, 7, 13, 19, 14, 48, 274, DateTimeKind.Utc).AddTicks(2739), "Canadian filmmaker and environmental advocate.", "James", null, true, false, "Cameron", null },
                    { new Guid("ad213a55-1d1b-4b19-977c-5d08a41b3e95"), new DateTime(1946, 12, 18, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2025, 7, 13, 19, 14, 48, 274, DateTimeKind.Utc).AddTicks(2719), "American film director, producer, and screenwriter.", "Steven", null, true, false, "Spielberg", null },
                    { new Guid("c8488697-5726-4327-8339-2c5c88246778"), new DateTime(1963, 3, 27, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2025, 7, 13, 19, 14, 48, 274, DateTimeKind.Utc).AddTicks(2734), "American filmmaker, actor, and screenwriter.", "Quentin", null, true, false, "Tarantino", null },
                    { new Guid("e8cb2ba3-b11c-41db-9782-863519978373"), new DateTime(1942, 11, 17, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2025, 7, 13, 19, 14, 48, 274, DateTimeKind.Utc).AddTicks(2725), "American film director, producer, screenwriter, and actor.", "Martin", null, true, false, "Scorsese", null }
                });

            migrationBuilder.InsertData(
                table: "Movies",
                columns: new[] { "Id", "CategoryId", "CreateAt", "Description", "DirectorId", "IMDB", "ImageUrl", "IsActive", "IsDeleted", "Name", "PublishDate", "UpdateAt" },
                values: new object[,]
                {
                    { new Guid("1ba8b297-3d2f-47a3-b228-dbb501a03eaa"), new Guid("7fe0ac2b-fa60-4004-a579-c5967a1746a1"), new DateTime(2025, 7, 13, 19, 14, 48, 274, DateTimeKind.Utc).AddTicks(2786), "A thief who steals corporate secrets through the use of dream-sharing technology is given the inverse task of planting an idea into the mind of a CEO.", new Guid("2950d635-d293-4c82-a9fb-f23f8cfa5956"), 8.8m, null, true, false, "Inception", new DateTime(2010, 7, 16, 0, 0, 0, 0, DateTimeKind.Unspecified), null },
                    { new Guid("4bc98310-e074-479a-922a-ac7515bd029e"), new Guid("7fe0ac2b-fa60-4004-a579-c5967a1746a1"), new DateTime(2025, 7, 13, 19, 14, 48, 274, DateTimeKind.Utc).AddTicks(2814), "A team of explorers travel through a wormhole in space in an attempt to ensure humanity's survival.", new Guid("2950d635-d293-4c82-a9fb-f23f8cfa5956"), 8.6m, null, true, false, "Interstellar", new DateTime(2014, 11, 7, 0, 0, 0, 0, DateTimeKind.Unspecified), null },
                    { new Guid("ce27e651-eecc-4dc3-9638-3a1533574a49"), new Guid("7fe0ac2b-fa60-4004-a579-c5967a1746a1"), new DateTime(2025, 7, 13, 19, 14, 48, 274, DateTimeKind.Utc).AddTicks(2802), "When the menace known as the Joker emerges from his mysterious past, he wreaks havoc and chaos on the people of Gotham.", new Guid("2950d635-d293-4c82-a9fb-f23f8cfa5956"), 9.0m, null, true, false, "The Dark Knight", new DateTime(2008, 7, 18, 0, 0, 0, 0, DateTimeKind.Unspecified), null }
                });
        }
    }
}
