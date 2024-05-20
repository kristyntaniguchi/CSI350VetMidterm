using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace CSI350VetMidterm.Migrations
{
    /// <inheritdoc />
    public partial class addPatientSeedImages : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.UpdateData(
                table: "Patients",
                keyColumn: "Id",
                keyValue: 1,
                column: "ImgURL",
                value: "https://pbs.twimg.com/media/GOAF_fSa8AAF6yl?format=jpg&name=large");

            migrationBuilder.UpdateData(
                table: "Patients",
                keyColumn: "Id",
                keyValue: 2,
                column: "ImgURL",
                value: "https://pbs.twimg.com/media/GOAF_fObQAE7eTW?format=jpg&name=large");

            migrationBuilder.UpdateData(
                table: "Patients",
                keyColumn: "Id",
                keyValue: 3,
                column: "ImgURL",
                value: "https://pbs.twimg.com/media/GOAGL3DaQAAfWPz?format=jpg&name=large");

            migrationBuilder.UpdateData(
                table: "Patients",
                keyColumn: "Id",
                keyValue: 4,
                column: "ImgURL",
                value: "https://pbs.twimg.com/media/GOAHgqwbMAA3ODl?format=jpg&name=large");

            migrationBuilder.UpdateData(
                table: "Patients",
                keyColumn: "Id",
                keyValue: 5,
                column: "ImgURL",
                value: "https://pbs.twimg.com/media/GOAGL3CasAAl78A?format=jpg&name=large");

            migrationBuilder.UpdateData(
                table: "Patients",
                keyColumn: "Id",
                keyValue: 6,
                column: "ImgURL",
                value: "https://pbs.twimg.com/media/GOAGj4tagAEcvkL?format=jpg&name=large");

            migrationBuilder.UpdateData(
                table: "Patients",
                keyColumn: "Id",
                keyValue: 7,
                column: "ImgURL",
                value: "https://pbs.twimg.com/media/GOAF_fTaoAAsKtp?format=jpg&name=large");

            migrationBuilder.UpdateData(
                table: "Patients",
                keyColumn: "Id",
                keyValue: 8,
                column: "ImgURL",
                value: "https://pbs.twimg.com/media/GOAF_fTbcAANpk9?format=jpg&name=large");

            migrationBuilder.UpdateData(
                table: "Patients",
                keyColumn: "Id",
                keyValue: 9,
                column: "ImgURL",
                value: "https://pbs.twimg.com/media/GOAGL3CbUAAhgRf?format=jpg&name=large");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.UpdateData(
                table: "Patients",
                keyColumn: "Id",
                keyValue: 1,
                column: "ImgURL",
                value: "maxlayingdown");

            migrationBuilder.UpdateData(
                table: "Patients",
                keyColumn: "Id",
                keyValue: 2,
                column: "ImgURL",
                value: "elsiecoat");

            migrationBuilder.UpdateData(
                table: "Patients",
                keyColumn: "Id",
                keyValue: 3,
                column: "ImgURL",
                value: "lila");

            migrationBuilder.UpdateData(
                table: "Patients",
                keyColumn: "Id",
                keyValue: 4,
                column: "ImgURL",
                value: "lucypool");

            migrationBuilder.UpdateData(
                table: "Patients",
                keyColumn: "Id",
                keyValue: 5,
                column: "ImgURL",
                value: "gusbeach");

            migrationBuilder.UpdateData(
                table: "Patients",
                keyColumn: "Id",
                keyValue: 6,
                column: "ImgURL",
                value: "Ellie");

            migrationBuilder.UpdateData(
                table: "Patients",
                keyColumn: "Id",
                keyValue: 7,
                column: "ImgURL",
                value: "lennypizaz");

            migrationBuilder.UpdateData(
                table: "Patients",
                keyColumn: "Id",
                keyValue: 8,
                column: "ImgURL",
                value: "rudy");

            migrationBuilder.UpdateData(
                table: "Patients",
                keyColumn: "Id",
                keyValue: 9,
                column: "ImgURL",
                value: "leo");
        }
    }
}
