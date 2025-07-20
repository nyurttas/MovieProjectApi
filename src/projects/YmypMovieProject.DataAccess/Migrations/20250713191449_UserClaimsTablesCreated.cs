using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

#pragma warning disable CA1814 // Prefer jagged arrays over multidimensional

namespace YmypMovieProject.DataAccess.Migrations
{
    /// <inheritdoc />
    public partial class UserClaimsTablesCreated : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: new Guid("202f8985-4780-4b06-90b2-63e8b9709201"));

            migrationBuilder.DeleteData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: new Guid("307fdff0-0d73-4549-bd18-27719148db0d"));

            migrationBuilder.DeleteData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: new Guid("588cd130-ff5a-4722-b730-17747c25970b"));

            migrationBuilder.DeleteData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: new Guid("b3eb1edb-e1b6-4c09-832c-4822b03c929b"));

            migrationBuilder.DeleteData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: new Guid("f7e4fe8f-c5e2-4227-aa92-d8f839bf1e8b"));

            migrationBuilder.DeleteData(
                table: "Directors",
                keyColumn: "Id",
                keyValue: new Guid("2b4ea311-6c84-41a2-8b95-45fc0213bcff"));

            migrationBuilder.DeleteData(
                table: "Directors",
                keyColumn: "Id",
                keyValue: new Guid("3cbb8fab-b782-4886-8df1-f2ab18ebcfbf"));

            migrationBuilder.DeleteData(
                table: "Directors",
                keyColumn: "Id",
                keyValue: new Guid("d6e74065-96e6-4de2-aedb-87b3c7ab55f9"));

            migrationBuilder.DeleteData(
                table: "Directors",
                keyColumn: "Id",
                keyValue: new Guid("fd4ac625-4fc6-4560-a08a-bc22950dd61b"));

            migrationBuilder.DeleteData(
                table: "Movies",
                keyColumn: "Id",
                keyValue: new Guid("0ac626bd-a319-4e8d-b140-5efc0cb8c3f0"));

            migrationBuilder.DeleteData(
                table: "Movies",
                keyColumn: "Id",
                keyValue: new Guid("bba4f115-686c-435b-9cfd-4fdbee5ec285"));

            migrationBuilder.DeleteData(
                table: "Movies",
                keyColumn: "Id",
                keyValue: new Guid("cc37527a-3e0a-42f5-91e7-220cad83fa8e"));

            migrationBuilder.CreateTable(
                name: "OperationClaims",
                columns: table => new
                {
                    Id = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    Name = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    CreateAt = table.Column<DateTime>(type: "datetime2", nullable: false),
                    UpdateAt = table.Column<DateTime>(type: "datetime2", nullable: true),
                    IsActive = table.Column<bool>(type: "bit", nullable: false),
                    IsDeleted = table.Column<bool>(type: "bit", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_OperationClaims", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "UserOperationClaims",
                columns: table => new
                {
                    Id = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    UserId = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    OperationClaimId = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    CreateAt = table.Column<DateTime>(type: "datetime2", nullable: false),
                    UpdateAt = table.Column<DateTime>(type: "datetime2", nullable: true),
                    IsActive = table.Column<bool>(type: "bit", nullable: false),
                    IsDeleted = table.Column<bool>(type: "bit", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_UserOperationClaims", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "Users",
                columns: table => new
                {
                    Id = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    FirstName = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    LastName = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Email = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    PasswordHash = table.Column<byte[]>(type: "varbinary(max)", nullable: false),
                    PasswordSalt = table.Column<byte[]>(type: "varbinary(max)", nullable: false),
                    Status = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    CreateAt = table.Column<DateTime>(type: "datetime2", nullable: false),
                    UpdateAt = table.Column<DateTime>(type: "datetime2", nullable: true),
                    IsActive = table.Column<bool>(type: "bit", nullable: false),
                    IsDeleted = table.Column<bool>(type: "bit", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Users", x => x.Id);
                });

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

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "OperationClaims");

            migrationBuilder.DropTable(
                name: "UserOperationClaims");

            migrationBuilder.DropTable(
                name: "Users");

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

            migrationBuilder.UpdateData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: new Guid("7fe0ac2b-fa60-4004-a579-c5967a1746a1"),
                column: "CreateAt",
                value: new DateTime(2025, 6, 19, 18, 50, 1, 642, DateTimeKind.Utc).AddTicks(4666));

            migrationBuilder.InsertData(
                table: "Categories",
                columns: new[] { "Id", "CreateAt", "Description", "IsActive", "IsDeleted", "Name", "UpdateAt" },
                values: new object[,]
                {
                    { new Guid("202f8985-4780-4b06-90b2-63e8b9709201"), new DateTime(2025, 6, 19, 18, 50, 1, 642, DateTimeKind.Utc).AddTicks(4670), null, true, false, "Komedi", null },
                    { new Guid("307fdff0-0d73-4549-bd18-27719148db0d"), new DateTime(2025, 6, 19, 18, 50, 1, 642, DateTimeKind.Utc).AddTicks(4673), null, true, false, "Belgesel", null },
                    { new Guid("588cd130-ff5a-4722-b730-17747c25970b"), new DateTime(2025, 6, 19, 18, 50, 1, 642, DateTimeKind.Utc).AddTicks(4672), null, true, false, "Bilim Kurgu", null },
                    { new Guid("b3eb1edb-e1b6-4c09-832c-4822b03c929b"), new DateTime(2025, 6, 19, 18, 50, 1, 642, DateTimeKind.Utc).AddTicks(4682), null, true, false, "Fantastik", null },
                    { new Guid("f7e4fe8f-c5e2-4227-aa92-d8f839bf1e8b"), new DateTime(2025, 6, 19, 18, 50, 1, 642, DateTimeKind.Utc).AddTicks(4683), null, true, false, "Korku", null }
                });

            migrationBuilder.UpdateData(
                table: "Directors",
                keyColumn: "Id",
                keyValue: new Guid("2950d635-d293-4c82-a9fb-f23f8cfa5956"),
                column: "CreateAt",
                value: new DateTime(2025, 6, 19, 18, 50, 1, 642, DateTimeKind.Utc).AddTicks(4772));

            migrationBuilder.InsertData(
                table: "Directors",
                columns: new[] { "Id", "BirthDate", "CreateAt", "Description", "FirstName", "ImageUrl", "IsActive", "IsDeleted", "LastName", "UpdateAt" },
                values: new object[,]
                {
                    { new Guid("2b4ea311-6c84-41a2-8b95-45fc0213bcff"), new DateTime(1942, 11, 17, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2025, 6, 19, 18, 50, 1, 642, DateTimeKind.Utc).AddTicks(4782), "American film director, producer, screenwriter, and actor.", "Martin", null, true, false, "Scorsese", null },
                    { new Guid("3cbb8fab-b782-4886-8df1-f2ab18ebcfbf"), new DateTime(1946, 12, 18, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2025, 6, 19, 18, 50, 1, 642, DateTimeKind.Utc).AddTicks(4778), "American film director, producer, and screenwriter.", "Steven", null, true, false, "Spielberg", null },
                    { new Guid("d6e74065-96e6-4de2-aedb-87b3c7ab55f9"), new DateTime(1954, 8, 16, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2025, 6, 19, 18, 50, 1, 642, DateTimeKind.Utc).AddTicks(4787), "Canadian filmmaker and environmental advocate.", "James", null, true, false, "Cameron", null },
                    { new Guid("fd4ac625-4fc6-4560-a08a-bc22950dd61b"), new DateTime(1963, 3, 27, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2025, 6, 19, 18, 50, 1, 642, DateTimeKind.Utc).AddTicks(4783), "American filmmaker, actor, and screenwriter.", "Quentin", null, true, false, "Tarantino", null }
                });

            migrationBuilder.InsertData(
                table: "Movies",
                columns: new[] { "Id", "CategoryId", "CreateAt", "Description", "DirectorId", "IMDB", "ImageUrl", "IsActive", "IsDeleted", "Name", "PublishDate", "UpdateAt" },
                values: new object[,]
                {
                    { new Guid("0ac626bd-a319-4e8d-b140-5efc0cb8c3f0"), new Guid("7fe0ac2b-fa60-4004-a579-c5967a1746a1"), new DateTime(2025, 6, 19, 18, 50, 1, 642, DateTimeKind.Utc).AddTicks(4803), "A thief who steals corporate secrets through the use of dream-sharing technology is given the inverse task of planting an idea into the mind of a CEO.", new Guid("2950d635-d293-4c82-a9fb-f23f8cfa5956"), 8.8m, null, true, false, "Inception", new DateTime(2010, 7, 16, 0, 0, 0, 0, DateTimeKind.Unspecified), null },
                    { new Guid("bba4f115-686c-435b-9cfd-4fdbee5ec285"), new Guid("7fe0ac2b-fa60-4004-a579-c5967a1746a1"), new DateTime(2025, 6, 19, 18, 50, 1, 642, DateTimeKind.Utc).AddTicks(4814), "A team of explorers travel through a wormhole in space in an attempt to ensure humanity's survival.", new Guid("2950d635-d293-4c82-a9fb-f23f8cfa5956"), 8.6m, null, true, false, "Interstellar", new DateTime(2014, 11, 7, 0, 0, 0, 0, DateTimeKind.Unspecified), null },
                    { new Guid("cc37527a-3e0a-42f5-91e7-220cad83fa8e"), new Guid("7fe0ac2b-fa60-4004-a579-c5967a1746a1"), new DateTime(2025, 6, 19, 18, 50, 1, 642, DateTimeKind.Utc).AddTicks(4810), "When the menace known as the Joker emerges from his mysterious past, he wreaks havoc and chaos on the people of Gotham.", new Guid("2950d635-d293-4c82-a9fb-f23f8cfa5956"), 9.0m, null, true, false, "The Dark Knight", new DateTime(2008, 7, 18, 0, 0, 0, 0, DateTimeKind.Unspecified), null }
                });
        }
    }
}
