using Microsoft.EntityFrameworkCore.Migrations;

namespace ACME.Services.DAL.Migrations
{
    public partial class addition : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AlterColumn<string>(
                name: "State",
                table: "Posts",
                nullable: true,
                oldClrType: typeof(int));

            migrationBuilder.InsertData(
                table: "Posts",
                columns: new[] { "ID", "BSPName", "Category", "Comments", "DeliveryOffice", "Locality", "ParcelZone", "Pcode", "PreSortIndicator", "State" },
                values: new object[,]
                {
                    { 50, null, "DeliveryArea", null, null, "ACACIA HILLS", null, "0822", null, "NT" },
                    { 55, null, "DeliveryArea", null, null, "ACTON", null, "2601", null, "ACT" },
                    { 60, null, "DeliveryArea", null, null, "AARONS PASS", null, "2850", null, "NSW" },
                    { 65, null, "DeliveryArea", null, null, "ABBEYARD", null, "3737", null, "VIC" }
                });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "Posts",
                keyColumn: "ID",
                keyValue: 50);

            migrationBuilder.DeleteData(
                table: "Posts",
                keyColumn: "ID",
                keyValue: 55);

            migrationBuilder.DeleteData(
                table: "Posts",
                keyColumn: "ID",
                keyValue: 60);

            migrationBuilder.DeleteData(
                table: "Posts",
                keyColumn: "ID",
                keyValue: 65);

            migrationBuilder.AlterColumn<int>(
                name: "State",
                table: "Posts",
                nullable: false,
                oldClrType: typeof(string),
                oldNullable: true);
        }
    }
}
