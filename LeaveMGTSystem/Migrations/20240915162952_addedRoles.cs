using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace LeaveMGTSystem.Migrations
{
    /// <inheritdoc />
    public partial class addedRoles : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "408aa945-3d84-4421-8342-7269ec64d949",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "f1699031-00e0-49e4-a8ea-b378b69821eb", "AQAAAAIAAYagAAAAEHXj28mQdy4oj1YXPwcrfahYRptZAHEdfFp1Y54eX0nTHVixbIphsf8KRUqT3c91+A==", "34962997-8b49-448a-93ed-6e38a3db9a79" });
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "408aa945-3d84-4421-8342-7269ec64d949",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "64eb5396-cf40-49ee-bbb0-23818ecee2ac", "AQAAAAIAAYagAAAAELBtMc153QmTxOsxrTIGIUFc81QgaHznPycUhfHS/FjwvMuXBJbzWCvQz1h5+ZDmAA==", "300b0d02-797c-4977-8fcc-ff10267c2868" });
        }
    }
}
