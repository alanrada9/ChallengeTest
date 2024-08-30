using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

#pragma warning disable CA1814 // Prefer jagged arrays over multidimensional

namespace ChallengeTest.Migrations
{
    /// <inheritdoc />
    public partial class init : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "Card",
                keyColumn: "Id",
                keyValue: new Guid("311339e9-4058-4064-825b-19009a329634"));

            migrationBuilder.DeleteData(
                table: "Card",
                keyColumn: "Id",
                keyValue: new Guid("c1d6c314-5566-4ae2-9868-ed397acde6ad"));

            migrationBuilder.DeleteData(
                table: "Card",
                keyColumn: "Id",
                keyValue: new Guid("d298f60a-e835-4869-ab77-5f55f4d90bd1"));

            migrationBuilder.DeleteData(
                table: "Card",
                keyColumn: "Id",
                keyValue: new Guid("f3b337ad-d825-406a-8bda-7891433f9624"));

            migrationBuilder.DeleteData(
                table: "Card",
                keyColumn: "Id",
                keyValue: new Guid("fa1b4f36-830a-445b-bac8-a455b7d47a15"));

            migrationBuilder.DeleteData(
                table: "Transaction",
                keyColumn: "Id",
                keyValue: new Guid("3046e730-654f-4460-86fe-d59b050a6bbf"));

            migrationBuilder.DeleteData(
                table: "Transaction",
                keyColumn: "Id",
                keyValue: new Guid("9843c13f-e3bf-4bfd-9ab5-070b3b98ce50"));

            migrationBuilder.DeleteData(
                table: "Transaction",
                keyColumn: "Id",
                keyValue: new Guid("a64a8c70-65b7-44d2-a399-68a75aa306b4"));

            migrationBuilder.DeleteData(
                table: "Transaction",
                keyColumn: "Id",
                keyValue: new Guid("ba9a2f03-7b93-4ea5-91f8-fb8a7372e395"));

            migrationBuilder.DeleteData(
                table: "Transaction",
                keyColumn: "Id",
                keyValue: new Guid("c776db29-65a4-4764-9fda-b91424e7bf66"));

            migrationBuilder.DeleteData(
                table: "Transaction",
                keyColumn: "Id",
                keyValue: new Guid("d87402fb-c955-4687-aa5f-464db6c03280"));

            migrationBuilder.DeleteData(
                table: "Transaction",
                keyColumn: "Id",
                keyValue: new Guid("df4fdff9-6086-4ab9-8c74-12ee7c4abebd"));

            migrationBuilder.DeleteData(
                table: "Transaction",
                keyColumn: "Id",
                keyValue: new Guid("e77754aa-bf57-47e6-b71b-b9c74dc3aad5"));

            migrationBuilder.DeleteData(
                table: "Transaction",
                keyColumn: "Id",
                keyValue: new Guid("ea272780-5a92-4b35-a1f4-ae1acb3348d1"));

            migrationBuilder.DeleteData(
                table: "Transaction",
                keyColumn: "Id",
                keyValue: new Guid("f6c94311-e10e-4e2b-9bbf-c9f93608c420"));

            migrationBuilder.UpdateData(
                table: "Account",
                keyColumn: "Id",
                keyValue: new Guid("3d3f5a9d-1e4e-4eae-a1c0-daa84edb50ef"),
                column: "LastWithdrawalDate",
                value: new DateTime(2024, 8, 30, 11, 58, 48, 349, DateTimeKind.Local).AddTicks(4958));

            migrationBuilder.UpdateData(
                table: "Account",
                keyColumn: "Id",
                keyValue: new Guid("6e1b2284-7460-4f5b-8c6b-e6f9d249e7c1"),
                column: "LastWithdrawalDate",
                value: new DateTime(2024, 8, 30, 11, 58, 48, 349, DateTimeKind.Local).AddTicks(4974));

            migrationBuilder.UpdateData(
                table: "Account",
                keyColumn: "Id",
                keyValue: new Guid("8b8c7b85-11f1-4a6b-9a8b-7b593d7de8c2"),
                column: "LastWithdrawalDate",
                value: new DateTime(2024, 8, 30, 11, 58, 48, 349, DateTimeKind.Local).AddTicks(4976));

            migrationBuilder.UpdateData(
                table: "Account",
                keyColumn: "Id",
                keyValue: new Guid("a0d8e517-5e2c-4ecb-8a3f-5e550c9c485d"),
                column: "LastWithdrawalDate",
                value: new DateTime(2024, 8, 30, 11, 58, 48, 349, DateTimeKind.Local).AddTicks(4978));

            migrationBuilder.UpdateData(
                table: "Account",
                keyColumn: "Id",
                keyValue: new Guid("b1e4f70b-29a2-4d52-99c3-e0c09246d839"),
                column: "LastWithdrawalDate",
                value: new DateTime(2024, 8, 30, 11, 58, 48, 349, DateTimeKind.Local).AddTicks(4979));

            migrationBuilder.InsertData(
                table: "Card",
                columns: new[] { "Id", "AccountId", "CardNumber", "FailedAttempts", "IsLocked", "Pin", "PlaceHolderName" },
                values: new object[,]
                {
                    { new Guid("052896b8-2502-4cba-a15a-eea16e084133"), new Guid("8b8c7b85-11f1-4a6b-9a8b-7b593d7de8c2"), "9999000011112222", 0, false, "9876", "Alice Johnson" },
                    { new Guid("3931ad9f-3b36-440a-bbb6-8ad76663d4ce"), new Guid("a0d8e517-5e2c-4ecb-8a3f-5e550c9c485d"), "3333444455556666", 0, false, "5432", "Bob Brown" },
                    { new Guid("457b3fa9-a7af-4d25-91d0-fb5a6b199c54"), new Guid("b1e4f70b-29a2-4d52-99c3-e0c09246d839"), "7777888899990000", 0, false, "1111", "Charlie Davis" },
                    { new Guid("8a5a5a46-2cf4-48a1-8f19-49ebb6f6a02f"), new Guid("6e1b2284-7460-4f5b-8c6b-e6f9d249e7c1"), "5555666677778888", 0, false, "5678", "Jane Smith" },
                    { new Guid("c3758c15-cee4-4c2e-b0e3-c3b1edc0bb7f"), new Guid("3d3f5a9d-1e4e-4eae-a1c0-daa84edb50ef"), "1111222233334444", 0, false, "1234", "John Doe" }
                });

            migrationBuilder.InsertData(
                table: "Transaction",
                columns: new[] { "Id", "AccountId", "Amount", "Date", "Description" },
                values: new object[,]
                {
                    { new Guid("25f74cc9-695c-4579-bfdd-d4653cbf1c56"), new Guid("a0d8e517-5e2c-4ecb-8a3f-5e550c9c485d"), 100.00m, new DateTime(2024, 8, 12, 11, 58, 48, 350, DateTimeKind.Local).AddTicks(1), "Withdrawal" },
                    { new Guid("45b8720d-5996-4fe1-937b-6e70afb45bf6"), new Guid("a0d8e517-5e2c-4ecb-8a3f-5e550c9c485d"), 200.00m, new DateTime(2024, 8, 10, 11, 58, 48, 349, DateTimeKind.Local).AddTicks(9994), "Deposit" },
                    { new Guid("4edb9f1e-3ada-44ac-8ef3-59aa152a9145"), new Guid("3d3f5a9d-1e4e-4eae-a1c0-daa84edb50ef"), 50.00m, new DateTime(2024, 8, 27, 11, 58, 48, 349, DateTimeKind.Local).AddTicks(9982), "Withdrawal" },
                    { new Guid("78b7f991-5c52-4888-a36d-08298a6e388f"), new Guid("b1e4f70b-29a2-4d52-99c3-e0c09246d839"), 125.00m, new DateTime(2024, 8, 8, 11, 58, 48, 350, DateTimeKind.Local).AddTicks(6), "Withdrawal" },
                    { new Guid("7af5aee4-fd0b-44d6-b181-507c038a3b02"), new Guid("3d3f5a9d-1e4e-4eae-a1c0-daa84edb50ef"), 100.00m, new DateTime(2024, 8, 25, 11, 58, 48, 349, DateTimeKind.Local).AddTicks(9961), "Deposit" },
                    { new Guid("87e31e8b-d66d-4efe-b2ef-be68bb3a655f"), new Guid("6e1b2284-7460-4f5b-8c6b-e6f9d249e7c1"), 30.00m, new DateTime(2024, 8, 23, 11, 58, 48, 349, DateTimeKind.Local).AddTicks(9987), "Withdrawal" },
                    { new Guid("90a3a976-fde8-4690-9e63-af6437d71cac"), new Guid("b1e4f70b-29a2-4d52-99c3-e0c09246d839"), 250.00m, new DateTime(2024, 8, 5, 11, 58, 48, 350, DateTimeKind.Local).AddTicks(4), "Deposit" },
                    { new Guid("a2cd0a5e-fe71-4e23-b4cc-4f52217510e3"), new Guid("8b8c7b85-11f1-4a6b-9a8b-7b593d7de8c2"), 75.00m, new DateTime(2024, 8, 18, 11, 58, 48, 349, DateTimeKind.Local).AddTicks(9992), "Withdrawal" },
                    { new Guid("af123844-f3e9-40f6-8c70-69aa9ea3828b"), new Guid("8b8c7b85-11f1-4a6b-9a8b-7b593d7de8c2"), 150.00m, new DateTime(2024, 8, 15, 11, 58, 48, 349, DateTimeKind.Local).AddTicks(9990), "Deposit" },
                    { new Guid("eb2d53e1-894a-4d44-9a41-f5ae694e6f7b"), new Guid("6e1b2284-7460-4f5b-8c6b-e6f9d249e7c1"), 200.00m, new DateTime(2024, 8, 20, 11, 58, 48, 349, DateTimeKind.Local).AddTicks(9984), "Deposit" }
                });
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "Card",
                keyColumn: "Id",
                keyValue: new Guid("052896b8-2502-4cba-a15a-eea16e084133"));

            migrationBuilder.DeleteData(
                table: "Card",
                keyColumn: "Id",
                keyValue: new Guid("3931ad9f-3b36-440a-bbb6-8ad76663d4ce"));

            migrationBuilder.DeleteData(
                table: "Card",
                keyColumn: "Id",
                keyValue: new Guid("457b3fa9-a7af-4d25-91d0-fb5a6b199c54"));

            migrationBuilder.DeleteData(
                table: "Card",
                keyColumn: "Id",
                keyValue: new Guid("8a5a5a46-2cf4-48a1-8f19-49ebb6f6a02f"));

            migrationBuilder.DeleteData(
                table: "Card",
                keyColumn: "Id",
                keyValue: new Guid("c3758c15-cee4-4c2e-b0e3-c3b1edc0bb7f"));

            migrationBuilder.DeleteData(
                table: "Transaction",
                keyColumn: "Id",
                keyValue: new Guid("25f74cc9-695c-4579-bfdd-d4653cbf1c56"));

            migrationBuilder.DeleteData(
                table: "Transaction",
                keyColumn: "Id",
                keyValue: new Guid("45b8720d-5996-4fe1-937b-6e70afb45bf6"));

            migrationBuilder.DeleteData(
                table: "Transaction",
                keyColumn: "Id",
                keyValue: new Guid("4edb9f1e-3ada-44ac-8ef3-59aa152a9145"));

            migrationBuilder.DeleteData(
                table: "Transaction",
                keyColumn: "Id",
                keyValue: new Guid("78b7f991-5c52-4888-a36d-08298a6e388f"));

            migrationBuilder.DeleteData(
                table: "Transaction",
                keyColumn: "Id",
                keyValue: new Guid("7af5aee4-fd0b-44d6-b181-507c038a3b02"));

            migrationBuilder.DeleteData(
                table: "Transaction",
                keyColumn: "Id",
                keyValue: new Guid("87e31e8b-d66d-4efe-b2ef-be68bb3a655f"));

            migrationBuilder.DeleteData(
                table: "Transaction",
                keyColumn: "Id",
                keyValue: new Guid("90a3a976-fde8-4690-9e63-af6437d71cac"));

            migrationBuilder.DeleteData(
                table: "Transaction",
                keyColumn: "Id",
                keyValue: new Guid("a2cd0a5e-fe71-4e23-b4cc-4f52217510e3"));

            migrationBuilder.DeleteData(
                table: "Transaction",
                keyColumn: "Id",
                keyValue: new Guid("af123844-f3e9-40f6-8c70-69aa9ea3828b"));

            migrationBuilder.DeleteData(
                table: "Transaction",
                keyColumn: "Id",
                keyValue: new Guid("eb2d53e1-894a-4d44-9a41-f5ae694e6f7b"));

            migrationBuilder.UpdateData(
                table: "Account",
                keyColumn: "Id",
                keyValue: new Guid("3d3f5a9d-1e4e-4eae-a1c0-daa84edb50ef"),
                column: "LastWithdrawalDate",
                value: new DateTime(2024, 8, 29, 13, 47, 25, 142, DateTimeKind.Local).AddTicks(3244));

            migrationBuilder.UpdateData(
                table: "Account",
                keyColumn: "Id",
                keyValue: new Guid("6e1b2284-7460-4f5b-8c6b-e6f9d249e7c1"),
                column: "LastWithdrawalDate",
                value: new DateTime(2024, 8, 29, 13, 47, 25, 142, DateTimeKind.Local).AddTicks(3256));

            migrationBuilder.UpdateData(
                table: "Account",
                keyColumn: "Id",
                keyValue: new Guid("8b8c7b85-11f1-4a6b-9a8b-7b593d7de8c2"),
                column: "LastWithdrawalDate",
                value: new DateTime(2024, 8, 29, 13, 47, 25, 142, DateTimeKind.Local).AddTicks(3258));

            migrationBuilder.UpdateData(
                table: "Account",
                keyColumn: "Id",
                keyValue: new Guid("a0d8e517-5e2c-4ecb-8a3f-5e550c9c485d"),
                column: "LastWithdrawalDate",
                value: new DateTime(2024, 8, 29, 13, 47, 25, 142, DateTimeKind.Local).AddTicks(3260));

            migrationBuilder.UpdateData(
                table: "Account",
                keyColumn: "Id",
                keyValue: new Guid("b1e4f70b-29a2-4d52-99c3-e0c09246d839"),
                column: "LastWithdrawalDate",
                value: new DateTime(2024, 8, 29, 13, 47, 25, 142, DateTimeKind.Local).AddTicks(3263));

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
        }
    }
}
