using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

#pragma warning disable CA1814 // Prefer jagged arrays over multidimensional

namespace ChallengeTest.Migrations
{
    /// <inheritdoc />
    public partial class init2 : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Account",
                columns: table => new
                {
                    Id = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    UserName = table.Column<string>(type: "nvarchar(256)", maxLength: 256, nullable: false),
                    AccountNumber = table.Column<string>(type: "nvarchar(20)", maxLength: 20, nullable: false),
                    Balance = table.Column<decimal>(type: "decimal(18,2)", nullable: false),
                    LastWithdrawalDate = table.Column<DateTime>(type: "datetime2", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Account", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "Card",
                columns: table => new
                {
                    Id = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    CardNumber = table.Column<string>(type: "nvarchar(16)", maxLength: 16, nullable: false),
                    PlaceHolderName = table.Column<string>(type: "nvarchar(100)", maxLength: 100, nullable: false),
                    Pin = table.Column<string>(type: "nvarchar(4)", maxLength: 4, nullable: false),
                    IsLocked = table.Column<bool>(type: "bit", nullable: false),
                    FailedAttempts = table.Column<int>(type: "int", nullable: false),
                    AccountId = table.Column<Guid>(type: "uniqueidentifier", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Card", x => x.Id);
                    table.ForeignKey(
                        name: "FK_Card_Account_AccountId",
                        column: x => x.AccountId,
                        principalTable: "Account",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "Transaction",
                columns: table => new
                {
                    Id = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    Amount = table.Column<decimal>(type: "decimal(18,2)", nullable: false),
                    Date = table.Column<DateTime>(type: "datetime2", nullable: false),
                    Description = table.Column<string>(type: "nvarchar(500)", maxLength: 500, nullable: false),
                    AccountId = table.Column<Guid>(type: "uniqueidentifier", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Transaction", x => x.Id);
                    table.ForeignKey(
                        name: "FK_Transaction_Account_AccountId",
                        column: x => x.AccountId,
                        principalTable: "Account",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.InsertData(
                table: "Account",
                columns: new[] { "Id", "AccountNumber", "Balance", "LastWithdrawalDate", "UserName" },
                values: new object[,]
                {
                    { new Guid("3d3f5a9d-1e4e-4eae-a1c0-daa84edb50ef"), "ACC123456789", 1000.00m, new DateTime(2024, 8, 29, 13, 47, 25, 142, DateTimeKind.Local).AddTicks(3244), "John Doe" },
                    { new Guid("6e1b2284-7460-4f5b-8c6b-e6f9d249e7c1"), "ACC987654321", 2000.00m, new DateTime(2024, 8, 29, 13, 47, 25, 142, DateTimeKind.Local).AddTicks(3256), "Jane Smith" },
                    { new Guid("8b8c7b85-11f1-4a6b-9a8b-7b593d7de8c2"), "ACC112233445", 1500.00m, new DateTime(2024, 8, 29, 13, 47, 25, 142, DateTimeKind.Local).AddTicks(3258), "Alice Johnson" },
                    { new Guid("a0d8e517-5e2c-4ecb-8a3f-5e550c9c485d"), "ACC556677889", 500.00m, new DateTime(2024, 8, 29, 13, 47, 25, 142, DateTimeKind.Local).AddTicks(3260), "Bob Brown" },
                    { new Guid("b1e4f70b-29a2-4d52-99c3-e0c09246d839"), "ACC998877665", 750.00m, new DateTime(2024, 8, 29, 13, 47, 25, 142, DateTimeKind.Local).AddTicks(3263), "Charlie Davis" }
                });

            migrationBuilder.InsertData(
                table: "Card",
                columns: new[] { "Id", "AccountId", "CardNumber", "FailedAttempts", "IsLocked", "Pin", "PlaceHolderName" },
                values: new object[,]
                {
                    { new Guid("311339e9-4058-4064-825b-19009a329634"), new Guid("3d3f5a9d-1e4e-4eae-a1c0-daa84edb50ef"), "1111222233334444", 0, false, "1234", "John Doe" },
                    { new Guid("c1d6c314-5566-4ae2-9868-ed397acde6ad"), new Guid("6e1b2284-7460-4f5b-8c6b-e6f9d249e7c1"), "5555666677778888", 0, false, "5678", "Jane Smith" },
                    { new Guid("d298f60a-e835-4869-ab77-5f55f4d90bd1"), new Guid("b1e4f70b-29a2-4d52-99c3-e0c09246d839"), "7777888899990000", 0, false, "1111", "Charlie Davis" },
                    { new Guid("f3b337ad-d825-406a-8bda-7891433f9624"), new Guid("a0d8e517-5e2c-4ecb-8a3f-5e550c9c485d"), "3333444455556666", 0, false, "5432", "Bob Brown" },
                    { new Guid("fa1b4f36-830a-445b-bac8-a455b7d47a15"), new Guid("8b8c7b85-11f1-4a6b-9a8b-7b593d7de8c2"), "9999000011112222", 0, false, "9876", "Alice Johnson" }
                });

            migrationBuilder.InsertData(
                table: "Transaction",
                columns: new[] { "Id", "AccountId", "Amount", "Date", "Description" },
                values: new object[,]
                {
                    { new Guid("3046e730-654f-4460-86fe-d59b050a6bbf"), new Guid("b1e4f70b-29a2-4d52-99c3-e0c09246d839"), 125.00m, new DateTime(2024, 8, 7, 13, 47, 25, 142, DateTimeKind.Local).AddTicks(9149), "Withdrawal" },
                    { new Guid("9843c13f-e3bf-4bfd-9ab5-070b3b98ce50"), new Guid("b1e4f70b-29a2-4d52-99c3-e0c09246d839"), 250.00m, new DateTime(2024, 8, 4, 13, 47, 25, 142, DateTimeKind.Local).AddTicks(9147), "Deposit" },
                    { new Guid("a64a8c70-65b7-44d2-a399-68a75aa306b4"), new Guid("a0d8e517-5e2c-4ecb-8a3f-5e550c9c485d"), 200.00m, new DateTime(2024, 8, 9, 13, 47, 25, 142, DateTimeKind.Local).AddTicks(9142), "Deposit" },
                    { new Guid("ba9a2f03-7b93-4ea5-91f8-fb8a7372e395"), new Guid("6e1b2284-7460-4f5b-8c6b-e6f9d249e7c1"), 200.00m, new DateTime(2024, 8, 19, 13, 47, 25, 142, DateTimeKind.Local).AddTicks(9131), "Deposit" },
                    { new Guid("c776db29-65a4-4764-9fda-b91424e7bf66"), new Guid("a0d8e517-5e2c-4ecb-8a3f-5e550c9c485d"), 100.00m, new DateTime(2024, 8, 11, 13, 47, 25, 142, DateTimeKind.Local).AddTicks(9144), "Withdrawal" },
                    { new Guid("d87402fb-c955-4687-aa5f-464db6c03280"), new Guid("8b8c7b85-11f1-4a6b-9a8b-7b593d7de8c2"), 150.00m, new DateTime(2024, 8, 14, 13, 47, 25, 142, DateTimeKind.Local).AddTicks(9138), "Deposit" },
                    { new Guid("df4fdff9-6086-4ab9-8c74-12ee7c4abebd"), new Guid("3d3f5a9d-1e4e-4eae-a1c0-daa84edb50ef"), 100.00m, new DateTime(2024, 8, 24, 13, 47, 25, 142, DateTimeKind.Local).AddTicks(9099), "Deposit" },
                    { new Guid("e77754aa-bf57-47e6-b71b-b9c74dc3aad5"), new Guid("6e1b2284-7460-4f5b-8c6b-e6f9d249e7c1"), 30.00m, new DateTime(2024, 8, 22, 13, 47, 25, 142, DateTimeKind.Local).AddTicks(9135), "Withdrawal" },
                    { new Guid("ea272780-5a92-4b35-a1f4-ae1acb3348d1"), new Guid("8b8c7b85-11f1-4a6b-9a8b-7b593d7de8c2"), 75.00m, new DateTime(2024, 8, 17, 13, 47, 25, 142, DateTimeKind.Local).AddTicks(9140), "Withdrawal" },
                    { new Guid("f6c94311-e10e-4e2b-9bbf-c9f93608c420"), new Guid("3d3f5a9d-1e4e-4eae-a1c0-daa84edb50ef"), 50.00m, new DateTime(2024, 8, 26, 13, 47, 25, 142, DateTimeKind.Local).AddTicks(9115), "Withdrawal" }
                });

            migrationBuilder.CreateIndex(
                name: "IX_Card_AccountId",
                table: "Card",
                column: "AccountId");

            migrationBuilder.CreateIndex(
                name: "IX_Transaction_AccountId",
                table: "Transaction",
                column: "AccountId");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Card");

            migrationBuilder.DropTable(
                name: "Transaction");

            migrationBuilder.DropTable(
                name: "Account");
        }
    }
}
