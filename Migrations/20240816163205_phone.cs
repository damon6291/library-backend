using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace library_backend.Migrations
{
    /// <inheritdoc />
    public partial class phone : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "Phone",
                table: "User");

            migrationBuilder.UpdateData(
                table: "Book",
                keyColumn: "BookId",
                keyValue: 1001,
                columns: new[] { "CreatedDateTime", "PublicationDate" },
                values: new object[] { new DateTime(2024, 8, 16, 16, 32, 4, 671, DateTimeKind.Utc).AddTicks(7735), new DateTime(2024, 2, 28, 3, 29, 30, 285, DateTimeKind.Local).AddTicks(240) });

            migrationBuilder.UpdateData(
                table: "Book",
                keyColumn: "BookId",
                keyValue: 1002,
                columns: new[] { "CreatedDateTime", "PublicationDate" },
                values: new object[] { new DateTime(2024, 8, 16, 16, 32, 4, 671, DateTimeKind.Utc).AddTicks(8346), new DateTime(2024, 2, 16, 23, 4, 17, 878, DateTimeKind.Local).AddTicks(8721) });

            migrationBuilder.UpdateData(
                table: "Book",
                keyColumn: "BookId",
                keyValue: 1003,
                columns: new[] { "CreatedDateTime", "PublicationDate" },
                values: new object[] { new DateTime(2024, 8, 16, 16, 32, 4, 671, DateTimeKind.Utc).AddTicks(8558), new DateTime(2023, 11, 3, 7, 17, 3, 152, DateTimeKind.Local).AddTicks(8568) });

            migrationBuilder.UpdateData(
                table: "Book",
                keyColumn: "BookId",
                keyValue: 1004,
                columns: new[] { "CreatedDateTime", "PublicationDate" },
                values: new object[] { new DateTime(2024, 8, 16, 16, 32, 4, 671, DateTimeKind.Utc).AddTicks(8704), new DateTime(2023, 9, 13, 19, 11, 53, 681, DateTimeKind.Local).AddTicks(7498) });

            migrationBuilder.UpdateData(
                table: "Book",
                keyColumn: "BookId",
                keyValue: 1005,
                columns: new[] { "CreatedDateTime", "PublicationDate" },
                values: new object[] { new DateTime(2024, 8, 16, 16, 32, 4, 671, DateTimeKind.Utc).AddTicks(8872), new DateTime(2023, 10, 11, 0, 11, 52, 511, DateTimeKind.Local).AddTicks(7237) });

            migrationBuilder.UpdateData(
                table: "Book",
                keyColumn: "BookId",
                keyValue: 1006,
                columns: new[] { "CreatedDateTime", "PublicationDate" },
                values: new object[] { new DateTime(2024, 8, 16, 16, 32, 4, 671, DateTimeKind.Utc).AddTicks(8993), new DateTime(2023, 8, 20, 13, 7, 11, 783, DateTimeKind.Local).AddTicks(3172) });

            migrationBuilder.UpdateData(
                table: "Book",
                keyColumn: "BookId",
                keyValue: 1007,
                columns: new[] { "CreatedDateTime", "PublicationDate" },
                values: new object[] { new DateTime(2024, 8, 16, 16, 32, 4, 671, DateTimeKind.Utc).AddTicks(9157), new DateTime(2024, 3, 23, 6, 2, 59, 331, DateTimeKind.Local).AddTicks(1495) });

            migrationBuilder.UpdateData(
                table: "Book",
                keyColumn: "BookId",
                keyValue: 1008,
                columns: new[] { "CreatedDateTime", "PublicationDate" },
                values: new object[] { new DateTime(2024, 8, 16, 16, 32, 4, 671, DateTimeKind.Utc).AddTicks(9274), new DateTime(2024, 3, 4, 16, 30, 57, 578, DateTimeKind.Local).AddTicks(9950) });

            migrationBuilder.UpdateData(
                table: "Book",
                keyColumn: "BookId",
                keyValue: 1009,
                columns: new[] { "CreatedDateTime", "PublicationDate" },
                values: new object[] { new DateTime(2024, 8, 16, 16, 32, 4, 671, DateTimeKind.Utc).AddTicks(9418), new DateTime(2023, 9, 25, 23, 12, 50, 921, DateTimeKind.Local).AddTicks(4506) });

            migrationBuilder.UpdateData(
                table: "Book",
                keyColumn: "BookId",
                keyValue: 1010,
                columns: new[] { "CreatedDateTime", "PublicationDate" },
                values: new object[] { new DateTime(2024, 8, 16, 16, 32, 4, 671, DateTimeKind.Utc).AddTicks(9557), new DateTime(2024, 5, 7, 4, 15, 39, 656, DateTimeKind.Local).AddTicks(3993) });

            migrationBuilder.UpdateData(
                table: "Book",
                keyColumn: "BookId",
                keyValue: 1011,
                columns: new[] { "CreatedDateTime", "PublicationDate" },
                values: new object[] { new DateTime(2024, 8, 16, 16, 32, 4, 671, DateTimeKind.Utc).AddTicks(9678), new DateTime(2024, 6, 16, 2, 35, 36, 709, DateTimeKind.Local).AddTicks(6928) });

            migrationBuilder.UpdateData(
                table: "Book",
                keyColumn: "BookId",
                keyValue: 1012,
                columns: new[] { "CreatedDateTime", "PublicationDate" },
                values: new object[] { new DateTime(2024, 8, 16, 16, 32, 4, 671, DateTimeKind.Utc).AddTicks(9836), new DateTime(2023, 9, 3, 9, 23, 10, 457, DateTimeKind.Local).AddTicks(604) });

            migrationBuilder.UpdateData(
                table: "Book",
                keyColumn: "BookId",
                keyValue: 1013,
                columns: new[] { "CreatedDateTime", "PublicationDate" },
                values: new object[] { new DateTime(2024, 8, 16, 16, 32, 4, 671, DateTimeKind.Utc).AddTicks(9940), new DateTime(2024, 7, 9, 8, 8, 30, 141, DateTimeKind.Local).AddTicks(8049) });

            migrationBuilder.UpdateData(
                table: "Book",
                keyColumn: "BookId",
                keyValue: 1014,
                columns: new[] { "CreatedDateTime", "PublicationDate" },
                values: new object[] { new DateTime(2024, 8, 16, 16, 32, 4, 672, DateTimeKind.Utc).AddTicks(88), new DateTime(2024, 2, 16, 4, 41, 24, 966, DateTimeKind.Local).AddTicks(7213) });

            migrationBuilder.UpdateData(
                table: "Book",
                keyColumn: "BookId",
                keyValue: 1015,
                columns: new[] { "CreatedDateTime", "PublicationDate" },
                values: new object[] { new DateTime(2024, 8, 16, 16, 32, 4, 672, DateTimeKind.Utc).AddTicks(225), new DateTime(2023, 8, 16, 15, 20, 36, 952, DateTimeKind.Local).AddTicks(103) });

            migrationBuilder.UpdateData(
                table: "Book",
                keyColumn: "BookId",
                keyValue: 1016,
                columns: new[] { "CreatedDateTime", "PublicationDate" },
                values: new object[] { new DateTime(2024, 8, 16, 16, 32, 4, 672, DateTimeKind.Utc).AddTicks(358), new DateTime(2023, 9, 19, 22, 37, 11, 669, DateTimeKind.Local).AddTicks(4179) });

            migrationBuilder.UpdateData(
                table: "Book",
                keyColumn: "BookId",
                keyValue: 1017,
                columns: new[] { "CreatedDateTime", "PublicationDate" },
                values: new object[] { new DateTime(2024, 8, 16, 16, 32, 4, 672, DateTimeKind.Utc).AddTicks(478), new DateTime(2024, 7, 6, 23, 50, 8, 543, DateTimeKind.Local).AddTicks(990) });

            migrationBuilder.UpdateData(
                table: "Book",
                keyColumn: "BookId",
                keyValue: 1018,
                columns: new[] { "CreatedDateTime", "PublicationDate" },
                values: new object[] { new DateTime(2024, 8, 16, 16, 32, 4, 672, DateTimeKind.Utc).AddTicks(625), new DateTime(2023, 11, 14, 22, 16, 54, 784, DateTimeKind.Local).AddTicks(9552) });

            migrationBuilder.UpdateData(
                table: "Book",
                keyColumn: "BookId",
                keyValue: 1019,
                columns: new[] { "CreatedDateTime", "PublicationDate" },
                values: new object[] { new DateTime(2024, 8, 16, 16, 32, 4, 672, DateTimeKind.Utc).AddTicks(735), new DateTime(2024, 5, 10, 5, 27, 20, 56, DateTimeKind.Local).AddTicks(2505) });

            migrationBuilder.UpdateData(
                table: "Book",
                keyColumn: "BookId",
                keyValue: 1020,
                columns: new[] { "CreatedDateTime", "PublicationDate" },
                values: new object[] { new DateTime(2024, 8, 16, 16, 32, 4, 672, DateTimeKind.Utc).AddTicks(888), new DateTime(2024, 3, 11, 9, 23, 20, 188, DateTimeKind.Local).AddTicks(9979) });

            migrationBuilder.UpdateData(
                table: "Book",
                keyColumn: "BookId",
                keyValue: 1021,
                columns: new[] { "CreatedDateTime", "PublicationDate" },
                values: new object[] { new DateTime(2024, 8, 16, 16, 32, 4, 672, DateTimeKind.Utc).AddTicks(1022), new DateTime(2024, 4, 15, 21, 33, 26, 874, DateTimeKind.Local).AddTicks(3353) });

            migrationBuilder.UpdateData(
                table: "Book",
                keyColumn: "BookId",
                keyValue: 1022,
                columns: new[] { "CreatedDateTime", "PublicationDate" },
                values: new object[] { new DateTime(2024, 8, 16, 16, 32, 4, 672, DateTimeKind.Utc).AddTicks(1133), new DateTime(2024, 2, 7, 17, 58, 13, 185, DateTimeKind.Local).AddTicks(8658) });

            migrationBuilder.UpdateData(
                table: "Book",
                keyColumn: "BookId",
                keyValue: 1023,
                columns: new[] { "CreatedDateTime", "PublicationDate" },
                values: new object[] { new DateTime(2024, 8, 16, 16, 32, 4, 672, DateTimeKind.Utc).AddTicks(1270), new DateTime(2023, 12, 18, 6, 21, 38, 459, DateTimeKind.Local).AddTicks(3882) });

            migrationBuilder.UpdateData(
                table: "Book",
                keyColumn: "BookId",
                keyValue: 1024,
                columns: new[] { "CreatedDateTime", "PublicationDate" },
                values: new object[] { new DateTime(2024, 8, 16, 16, 32, 4, 672, DateTimeKind.Utc).AddTicks(1380), new DateTime(2023, 8, 27, 23, 21, 20, 949, DateTimeKind.Local).AddTicks(4978) });

            migrationBuilder.UpdateData(
                table: "Book",
                keyColumn: "BookId",
                keyValue: 1025,
                columns: new[] { "CreatedDateTime", "PublicationDate" },
                values: new object[] { new DateTime(2024, 8, 16, 16, 32, 4, 672, DateTimeKind.Utc).AddTicks(1516), new DateTime(2023, 10, 30, 17, 7, 14, 173, DateTimeKind.Local).AddTicks(5673) });

            migrationBuilder.UpdateData(
                table: "Book",
                keyColumn: "BookId",
                keyValue: 1026,
                columns: new[] { "CreatedDateTime", "PublicationDate" },
                values: new object[] { new DateTime(2024, 8, 16, 16, 32, 4, 672, DateTimeKind.Utc).AddTicks(1632), new DateTime(2023, 9, 25, 1, 47, 16, 460, DateTimeKind.Local).AddTicks(8403) });

            migrationBuilder.UpdateData(
                table: "Book",
                keyColumn: "BookId",
                keyValue: 1027,
                columns: new[] { "CreatedDateTime", "PublicationDate" },
                values: new object[] { new DateTime(2024, 8, 16, 16, 32, 4, 672, DateTimeKind.Utc).AddTicks(1771), new DateTime(2023, 8, 25, 12, 57, 11, 250, DateTimeKind.Local).AddTicks(9796) });

            migrationBuilder.UpdateData(
                table: "Book",
                keyColumn: "BookId",
                keyValue: 1028,
                columns: new[] { "CreatedDateTime", "PublicationDate" },
                values: new object[] { new DateTime(2024, 8, 16, 16, 32, 4, 672, DateTimeKind.Utc).AddTicks(1886), new DateTime(2023, 12, 13, 1, 40, 46, 533, DateTimeKind.Local).AddTicks(9122) });

            migrationBuilder.UpdateData(
                table: "Book",
                keyColumn: "BookId",
                keyValue: 1029,
                columns: new[] { "CreatedDateTime", "PublicationDate" },
                values: new object[] { new DateTime(2024, 8, 16, 16, 32, 4, 672, DateTimeKind.Utc).AddTicks(2026), new DateTime(2024, 4, 17, 16, 48, 16, 171, DateTimeKind.Local).AddTicks(7430) });

            migrationBuilder.UpdateData(
                table: "Book",
                keyColumn: "BookId",
                keyValue: 1030,
                columns: new[] { "CreatedDateTime", "PublicationDate" },
                values: new object[] { new DateTime(2024, 8, 16, 16, 32, 4, 672, DateTimeKind.Utc).AddTicks(2133), new DateTime(2024, 8, 10, 8, 34, 15, 328, DateTimeKind.Local).AddTicks(4927) });

            migrationBuilder.UpdateData(
                table: "Book",
                keyColumn: "BookId",
                keyValue: 1031,
                columns: new[] { "CreatedDateTime", "PublicationDate" },
                values: new object[] { new DateTime(2024, 8, 16, 16, 32, 4, 672, DateTimeKind.Utc).AddTicks(2271), new DateTime(2024, 8, 16, 9, 15, 54, 570, DateTimeKind.Local).AddTicks(7115) });

            migrationBuilder.UpdateData(
                table: "Book",
                keyColumn: "BookId",
                keyValue: 1032,
                columns: new[] { "CreatedDateTime", "PublicationDate" },
                values: new object[] { new DateTime(2024, 8, 16, 16, 32, 4, 672, DateTimeKind.Utc).AddTicks(2404), new DateTime(2023, 11, 16, 5, 45, 6, 168, DateTimeKind.Local).AddTicks(5149) });

            migrationBuilder.UpdateData(
                table: "Book",
                keyColumn: "BookId",
                keyValue: 1033,
                columns: new[] { "CreatedDateTime", "PublicationDate" },
                values: new object[] { new DateTime(2024, 8, 16, 16, 32, 4, 672, DateTimeKind.Utc).AddTicks(2515), new DateTime(2023, 8, 25, 14, 7, 24, 550, DateTimeKind.Local).AddTicks(1082) });

            migrationBuilder.UpdateData(
                table: "Book",
                keyColumn: "BookId",
                keyValue: 1034,
                columns: new[] { "CreatedDateTime", "PublicationDate" },
                values: new object[] { new DateTime(2024, 8, 16, 16, 32, 4, 672, DateTimeKind.Utc).AddTicks(2650), new DateTime(2024, 6, 29, 6, 7, 43, 419, DateTimeKind.Local).AddTicks(4367) });

            migrationBuilder.UpdateData(
                table: "Book",
                keyColumn: "BookId",
                keyValue: 1035,
                columns: new[] { "CreatedDateTime", "PublicationDate" },
                values: new object[] { new DateTime(2024, 8, 16, 16, 32, 4, 672, DateTimeKind.Utc).AddTicks(2764), new DateTime(2024, 6, 16, 13, 3, 35, 23, DateTimeKind.Local).AddTicks(9311) });

            migrationBuilder.UpdateData(
                table: "Book",
                keyColumn: "BookId",
                keyValue: 1036,
                columns: new[] { "CreatedDateTime", "PublicationDate" },
                values: new object[] { new DateTime(2024, 8, 16, 16, 32, 4, 672, DateTimeKind.Utc).AddTicks(2872), new DateTime(2023, 9, 23, 17, 40, 2, 793, DateTimeKind.Local).AddTicks(3639) });

            migrationBuilder.UpdateData(
                table: "Book",
                keyColumn: "BookId",
                keyValue: 1037,
                columns: new[] { "CreatedDateTime", "PublicationDate" },
                values: new object[] { new DateTime(2024, 8, 16, 16, 32, 4, 672, DateTimeKind.Utc).AddTicks(3009), new DateTime(2023, 12, 16, 8, 11, 12, 233, DateTimeKind.Local).AddTicks(2857) });

            migrationBuilder.UpdateData(
                table: "Book",
                keyColumn: "BookId",
                keyValue: 1038,
                columns: new[] { "CreatedDateTime", "PublicationDate" },
                values: new object[] { new DateTime(2024, 8, 16, 16, 32, 4, 672, DateTimeKind.Utc).AddTicks(3148), new DateTime(2023, 10, 30, 5, 26, 22, 378, DateTimeKind.Local).AddTicks(6260) });

            migrationBuilder.UpdateData(
                table: "Book",
                keyColumn: "BookId",
                keyValue: 1039,
                columns: new[] { "CreatedDateTime", "PublicationDate" },
                values: new object[] { new DateTime(2024, 8, 16, 16, 32, 4, 672, DateTimeKind.Utc).AddTicks(3248), new DateTime(2024, 5, 18, 4, 22, 54, 668, DateTimeKind.Local).AddTicks(8141) });

            migrationBuilder.UpdateData(
                table: "Book",
                keyColumn: "BookId",
                keyValue: 1040,
                columns: new[] { "CreatedDateTime", "PublicationDate" },
                values: new object[] { new DateTime(2024, 8, 16, 16, 32, 4, 672, DateTimeKind.Utc).AddTicks(3382), new DateTime(2023, 12, 24, 8, 34, 1, 243, DateTimeKind.Local).AddTicks(744) });

            migrationBuilder.UpdateData(
                table: "Book",
                keyColumn: "BookId",
                keyValue: 1041,
                columns: new[] { "CreatedDateTime", "PublicationDate" },
                values: new object[] { new DateTime(2024, 8, 16, 16, 32, 4, 672, DateTimeKind.Utc).AddTicks(3488), new DateTime(2023, 12, 25, 7, 26, 9, 341, DateTimeKind.Local).AddTicks(6554) });

            migrationBuilder.UpdateData(
                table: "Book",
                keyColumn: "BookId",
                keyValue: 1042,
                columns: new[] { "CreatedDateTime", "PublicationDate" },
                values: new object[] { new DateTime(2024, 8, 16, 16, 32, 4, 672, DateTimeKind.Utc).AddTicks(3620), new DateTime(2024, 2, 21, 10, 18, 44, 689, DateTimeKind.Local).AddTicks(8079) });

            migrationBuilder.UpdateData(
                table: "Book",
                keyColumn: "BookId",
                keyValue: 1043,
                columns: new[] { "CreatedDateTime", "PublicationDate" },
                values: new object[] { new DateTime(2024, 8, 16, 16, 32, 4, 672, DateTimeKind.Utc).AddTicks(3724), new DateTime(2024, 3, 28, 2, 8, 26, 817, DateTimeKind.Local).AddTicks(7485) });

            migrationBuilder.UpdateData(
                table: "Book",
                keyColumn: "BookId",
                keyValue: 1044,
                columns: new[] { "CreatedDateTime", "PublicationDate" },
                values: new object[] { new DateTime(2024, 8, 16, 16, 32, 4, 672, DateTimeKind.Utc).AddTicks(3861), new DateTime(2024, 2, 25, 22, 40, 49, 373, DateTimeKind.Local).AddTicks(4742) });

            migrationBuilder.UpdateData(
                table: "Book",
                keyColumn: "BookId",
                keyValue: 1045,
                columns: new[] { "CreatedDateTime", "PublicationDate" },
                values: new object[] { new DateTime(2024, 8, 16, 16, 32, 4, 672, DateTimeKind.Utc).AddTicks(3966), new DateTime(2023, 10, 28, 15, 30, 24, 315, DateTimeKind.Local).AddTicks(2397) });

            migrationBuilder.UpdateData(
                table: "Book",
                keyColumn: "BookId",
                keyValue: 1046,
                columns: new[] { "CreatedDateTime", "PublicationDate" },
                values: new object[] { new DateTime(2024, 8, 16, 16, 32, 4, 672, DateTimeKind.Utc).AddTicks(4077), new DateTime(2023, 9, 10, 9, 45, 31, 587, DateTimeKind.Local).AddTicks(1644) });

            migrationBuilder.UpdateData(
                table: "Book",
                keyColumn: "BookId",
                keyValue: 1047,
                columns: new[] { "CreatedDateTime", "PublicationDate" },
                values: new object[] { new DateTime(2024, 8, 16, 16, 32, 4, 672, DateTimeKind.Utc).AddTicks(4173), new DateTime(2023, 9, 2, 11, 18, 24, 376, DateTimeKind.Local).AddTicks(5885) });

            migrationBuilder.UpdateData(
                table: "Book",
                keyColumn: "BookId",
                keyValue: 1048,
                columns: new[] { "CreatedDateTime", "PublicationDate" },
                values: new object[] { new DateTime(2024, 8, 16, 16, 32, 4, 672, DateTimeKind.Utc).AddTicks(4325), new DateTime(2023, 11, 8, 13, 50, 30, 735, DateTimeKind.Local).AddTicks(2683) });

            migrationBuilder.UpdateData(
                table: "Book",
                keyColumn: "BookId",
                keyValue: 1049,
                columns: new[] { "CreatedDateTime", "PublicationDate" },
                values: new object[] { new DateTime(2024, 8, 16, 16, 32, 4, 672, DateTimeKind.Utc).AddTicks(4422), new DateTime(2023, 9, 8, 20, 43, 7, 650, DateTimeKind.Local).AddTicks(4186) });

            migrationBuilder.UpdateData(
                table: "Book",
                keyColumn: "BookId",
                keyValue: 1050,
                columns: new[] { "CreatedDateTime", "PublicationDate" },
                values: new object[] { new DateTime(2024, 8, 16, 16, 32, 4, 672, DateTimeKind.Utc).AddTicks(4573), new DateTime(2024, 6, 27, 13, 10, 38, 432, DateTimeKind.Local).AddTicks(5988) });

            migrationBuilder.UpdateData(
                table: "Book",
                keyColumn: "BookId",
                keyValue: 1051,
                columns: new[] { "CreatedDateTime", "PublicationDate" },
                values: new object[] { new DateTime(2024, 8, 16, 16, 32, 4, 672, DateTimeKind.Utc).AddTicks(4686), new DateTime(2024, 5, 7, 22, 5, 26, 829, DateTimeKind.Local).AddTicks(3687) });

            migrationBuilder.UpdateData(
                table: "Book",
                keyColumn: "BookId",
                keyValue: 1052,
                columns: new[] { "CreatedDateTime", "PublicationDate" },
                values: new object[] { new DateTime(2024, 8, 16, 16, 32, 4, 672, DateTimeKind.Utc).AddTicks(4821), new DateTime(2023, 11, 21, 11, 36, 4, 531, DateTimeKind.Local).AddTicks(3508) });

            migrationBuilder.UpdateData(
                table: "Book",
                keyColumn: "BookId",
                keyValue: 1053,
                columns: new[] { "CreatedDateTime", "PublicationDate" },
                values: new object[] { new DateTime(2024, 8, 16, 16, 32, 4, 672, DateTimeKind.Utc).AddTicks(4937), new DateTime(2024, 3, 14, 21, 23, 39, 997, DateTimeKind.Local).AddTicks(8493) });

            migrationBuilder.UpdateData(
                table: "Book",
                keyColumn: "BookId",
                keyValue: 1054,
                columns: new[] { "CreatedDateTime", "PublicationDate" },
                values: new object[] { new DateTime(2024, 8, 16, 16, 32, 4, 672, DateTimeKind.Utc).AddTicks(5085), new DateTime(2024, 5, 12, 5, 39, 7, 412, DateTimeKind.Local).AddTicks(5712) });

            migrationBuilder.UpdateData(
                table: "Book",
                keyColumn: "BookId",
                keyValue: 1055,
                columns: new[] { "CreatedDateTime", "PublicationDate" },
                values: new object[] { new DateTime(2024, 8, 16, 16, 32, 4, 672, DateTimeKind.Utc).AddTicks(5224), new DateTime(2024, 8, 11, 15, 33, 4, 340, DateTimeKind.Local).AddTicks(8090) });

            migrationBuilder.UpdateData(
                table: "Book",
                keyColumn: "BookId",
                keyValue: 1056,
                columns: new[] { "CreatedDateTime", "PublicationDate" },
                values: new object[] { new DateTime(2024, 8, 16, 16, 32, 4, 672, DateTimeKind.Utc).AddTicks(5323), new DateTime(2024, 7, 25, 11, 19, 53, 548, DateTimeKind.Local).AddTicks(5750) });

            migrationBuilder.UpdateData(
                table: "Book",
                keyColumn: "BookId",
                keyValue: 1057,
                columns: new[] { "CreatedDateTime", "PublicationDate" },
                values: new object[] { new DateTime(2024, 8, 16, 16, 32, 4, 672, DateTimeKind.Utc).AddTicks(5456), new DateTime(2023, 11, 11, 15, 49, 17, 882, DateTimeKind.Local).AddTicks(6058) });

            migrationBuilder.UpdateData(
                table: "Book",
                keyColumn: "BookId",
                keyValue: 1058,
                columns: new[] { "CreatedDateTime", "PublicationDate" },
                values: new object[] { new DateTime(2024, 8, 16, 16, 32, 4, 672, DateTimeKind.Utc).AddTicks(5564), new DateTime(2024, 4, 24, 0, 36, 45, 674, DateTimeKind.Local).AddTicks(4416) });

            migrationBuilder.UpdateData(
                table: "Book",
                keyColumn: "BookId",
                keyValue: 1059,
                columns: new[] { "CreatedDateTime", "PublicationDate" },
                values: new object[] { new DateTime(2024, 8, 16, 16, 32, 4, 672, DateTimeKind.Utc).AddTicks(5685), new DateTime(2024, 2, 19, 23, 0, 30, 20, DateTimeKind.Local).AddTicks(2409) });

            migrationBuilder.UpdateData(
                table: "Book",
                keyColumn: "BookId",
                keyValue: 1060,
                columns: new[] { "CreatedDateTime", "PublicationDate" },
                values: new object[] { new DateTime(2024, 8, 16, 16, 32, 4, 672, DateTimeKind.Utc).AddTicks(5793), new DateTime(2024, 4, 28, 4, 49, 54, 958, DateTimeKind.Local).AddTicks(2481) });

            migrationBuilder.UpdateData(
                table: "Book",
                keyColumn: "BookId",
                keyValue: 1061,
                columns: new[] { "CreatedDateTime", "PublicationDate" },
                values: new object[] { new DateTime(2024, 8, 16, 16, 32, 4, 672, DateTimeKind.Utc).AddTicks(5918), new DateTime(2024, 5, 1, 20, 10, 51, 131, DateTimeKind.Local).AddTicks(5955) });

            migrationBuilder.UpdateData(
                table: "Book",
                keyColumn: "BookId",
                keyValue: 1062,
                columns: new[] { "CreatedDateTime", "PublicationDate" },
                values: new object[] { new DateTime(2024, 8, 16, 16, 32, 4, 672, DateTimeKind.Utc).AddTicks(6020), new DateTime(2023, 8, 25, 11, 17, 11, 578, DateTimeKind.Local).AddTicks(6961) });

            migrationBuilder.UpdateData(
                table: "Book",
                keyColumn: "BookId",
                keyValue: 1063,
                columns: new[] { "CreatedDateTime", "PublicationDate" },
                values: new object[] { new DateTime(2024, 8, 16, 16, 32, 4, 672, DateTimeKind.Utc).AddTicks(6161), new DateTime(2024, 1, 14, 12, 29, 50, 386, DateTimeKind.Local).AddTicks(448) });

            migrationBuilder.UpdateData(
                table: "Book",
                keyColumn: "BookId",
                keyValue: 1064,
                columns: new[] { "CreatedDateTime", "PublicationDate" },
                values: new object[] { new DateTime(2024, 8, 16, 16, 32, 4, 672, DateTimeKind.Utc).AddTicks(6256), new DateTime(2023, 10, 12, 13, 35, 52, 233, DateTimeKind.Local).AddTicks(8935) });

            migrationBuilder.UpdateData(
                table: "Book",
                keyColumn: "BookId",
                keyValue: 1065,
                columns: new[] { "CreatedDateTime", "PublicationDate" },
                values: new object[] { new DateTime(2024, 8, 16, 16, 32, 4, 672, DateTimeKind.Utc).AddTicks(6397), new DateTime(2024, 5, 28, 3, 4, 23, 792, DateTimeKind.Local).AddTicks(6437) });

            migrationBuilder.UpdateData(
                table: "Book",
                keyColumn: "BookId",
                keyValue: 1066,
                columns: new[] { "CreatedDateTime", "PublicationDate" },
                values: new object[] { new DateTime(2024, 8, 16, 16, 32, 4, 672, DateTimeKind.Utc).AddTicks(6495), new DateTime(2023, 10, 14, 19, 2, 49, 281, DateTimeKind.Local).AddTicks(915) });

            migrationBuilder.UpdateData(
                table: "Book",
                keyColumn: "BookId",
                keyValue: 1067,
                columns: new[] { "CreatedDateTime", "PublicationDate" },
                values: new object[] { new DateTime(2024, 8, 16, 16, 32, 4, 672, DateTimeKind.Utc).AddTicks(6617), new DateTime(2023, 10, 13, 7, 2, 22, 532, DateTimeKind.Local).AddTicks(3639) });

            migrationBuilder.UpdateData(
                table: "Book",
                keyColumn: "BookId",
                keyValue: 1068,
                columns: new[] { "CreatedDateTime", "PublicationDate" },
                values: new object[] { new DateTime(2024, 8, 16, 16, 32, 4, 672, DateTimeKind.Utc).AddTicks(6724), new DateTime(2024, 6, 10, 17, 7, 56, 590, DateTimeKind.Local).AddTicks(4355) });

            migrationBuilder.UpdateData(
                table: "Book",
                keyColumn: "BookId",
                keyValue: 1069,
                columns: new[] { "CreatedDateTime", "PublicationDate" },
                values: new object[] { new DateTime(2024, 8, 16, 16, 32, 4, 672, DateTimeKind.Utc).AddTicks(6854), new DateTime(2024, 1, 30, 2, 3, 30, 193, DateTimeKind.Local).AddTicks(8780) });

            migrationBuilder.UpdateData(
                table: "Book",
                keyColumn: "BookId",
                keyValue: 1070,
                columns: new[] { "CreatedDateTime", "PublicationDate" },
                values: new object[] { new DateTime(2024, 8, 16, 16, 32, 4, 672, DateTimeKind.Utc).AddTicks(6962), new DateTime(2023, 10, 9, 18, 35, 25, 821, DateTimeKind.Local).AddTicks(924) });

            migrationBuilder.UpdateData(
                table: "Book",
                keyColumn: "BookId",
                keyValue: 1071,
                columns: new[] { "CreatedDateTime", "PublicationDate" },
                values: new object[] { new DateTime(2024, 8, 16, 16, 32, 4, 672, DateTimeKind.Utc).AddTicks(7090), new DateTime(2024, 2, 28, 14, 42, 47, 484, DateTimeKind.Local).AddTicks(3354) });

            migrationBuilder.UpdateData(
                table: "Book",
                keyColumn: "BookId",
                keyValue: 1072,
                columns: new[] { "CreatedDateTime", "PublicationDate" },
                values: new object[] { new DateTime(2024, 8, 16, 16, 32, 4, 672, DateTimeKind.Utc).AddTicks(7201), new DateTime(2024, 3, 21, 7, 29, 30, 647, DateTimeKind.Local).AddTicks(7543) });

            migrationBuilder.UpdateData(
                table: "Book",
                keyColumn: "BookId",
                keyValue: 1073,
                columns: new[] { "CreatedDateTime", "PublicationDate" },
                values: new object[] { new DateTime(2024, 8, 16, 16, 32, 4, 672, DateTimeKind.Utc).AddTicks(7329), new DateTime(2023, 10, 4, 7, 22, 50, 505, DateTimeKind.Local).AddTicks(8584) });

            migrationBuilder.UpdateData(
                table: "Book",
                keyColumn: "BookId",
                keyValue: 1074,
                columns: new[] { "CreatedDateTime", "PublicationDate" },
                values: new object[] { new DateTime(2024, 8, 16, 16, 32, 4, 672, DateTimeKind.Utc).AddTicks(7425), new DateTime(2023, 11, 29, 12, 1, 36, 550, DateTimeKind.Local).AddTicks(7425) });

            migrationBuilder.UpdateData(
                table: "Book",
                keyColumn: "BookId",
                keyValue: 1075,
                columns: new[] { "CreatedDateTime", "PublicationDate" },
                values: new object[] { new DateTime(2024, 8, 16, 16, 32, 4, 672, DateTimeKind.Utc).AddTicks(7554), new DateTime(2024, 5, 8, 0, 11, 33, 380, DateTimeKind.Local).AddTicks(2852) });

            migrationBuilder.UpdateData(
                table: "Book",
                keyColumn: "BookId",
                keyValue: 1076,
                columns: new[] { "CreatedDateTime", "PublicationDate" },
                values: new object[] { new DateTime(2024, 8, 16, 16, 32, 4, 672, DateTimeKind.Utc).AddTicks(7649), new DateTime(2024, 8, 11, 5, 5, 11, 269, DateTimeKind.Local).AddTicks(3349) });

            migrationBuilder.UpdateData(
                table: "Book",
                keyColumn: "BookId",
                keyValue: 1077,
                columns: new[] { "CreatedDateTime", "PublicationDate" },
                values: new object[] { new DateTime(2024, 8, 16, 16, 32, 4, 672, DateTimeKind.Utc).AddTicks(7760), new DateTime(2024, 3, 17, 10, 12, 10, 250, DateTimeKind.Local).AddTicks(7995) });

            migrationBuilder.UpdateData(
                table: "Book",
                keyColumn: "BookId",
                keyValue: 1078,
                columns: new[] { "CreatedDateTime", "PublicationDate" },
                values: new object[] { new DateTime(2024, 8, 16, 16, 32, 4, 672, DateTimeKind.Utc).AddTicks(7857), new DateTime(2024, 1, 15, 8, 6, 6, 613, DateTimeKind.Local).AddTicks(2187) });

            migrationBuilder.UpdateData(
                table: "Book",
                keyColumn: "BookId",
                keyValue: 1079,
                columns: new[] { "CreatedDateTime", "PublicationDate" },
                values: new object[] { new DateTime(2024, 8, 16, 16, 32, 4, 672, DateTimeKind.Utc).AddTicks(7990), new DateTime(2023, 12, 14, 23, 12, 2, 127, DateTimeKind.Local).AddTicks(3197) });

            migrationBuilder.UpdateData(
                table: "Book",
                keyColumn: "BookId",
                keyValue: 1080,
                columns: new[] { "CreatedDateTime", "PublicationDate" },
                values: new object[] { new DateTime(2024, 8, 16, 16, 32, 4, 672, DateTimeKind.Utc).AddTicks(8101), new DateTime(2024, 7, 26, 0, 15, 12, 478, DateTimeKind.Local).AddTicks(2102) });

            migrationBuilder.UpdateData(
                table: "Book",
                keyColumn: "BookId",
                keyValue: 1081,
                columns: new[] { "CreatedDateTime", "PublicationDate" },
                values: new object[] { new DateTime(2024, 8, 16, 16, 32, 4, 672, DateTimeKind.Utc).AddTicks(8238), new DateTime(2024, 1, 25, 10, 50, 51, 790, DateTimeKind.Local).AddTicks(6203) });

            migrationBuilder.UpdateData(
                table: "Book",
                keyColumn: "BookId",
                keyValue: 1082,
                columns: new[] { "CreatedDateTime", "PublicationDate" },
                values: new object[] { new DateTime(2024, 8, 16, 16, 32, 4, 672, DateTimeKind.Utc).AddTicks(8340), new DateTime(2024, 2, 16, 6, 39, 33, 460, DateTimeKind.Local).AddTicks(4221) });

            migrationBuilder.UpdateData(
                table: "Book",
                keyColumn: "BookId",
                keyValue: 1083,
                columns: new[] { "CreatedDateTime", "PublicationDate" },
                values: new object[] { new DateTime(2024, 8, 16, 16, 32, 4, 672, DateTimeKind.Utc).AddTicks(8469), new DateTime(2024, 7, 22, 18, 38, 50, 960, DateTimeKind.Local).AddTicks(585) });

            migrationBuilder.UpdateData(
                table: "Book",
                keyColumn: "BookId",
                keyValue: 1084,
                columns: new[] { "CreatedDateTime", "PublicationDate" },
                values: new object[] { new DateTime(2024, 8, 16, 16, 32, 4, 672, DateTimeKind.Utc).AddTicks(8562), new DateTime(2024, 3, 8, 23, 21, 0, 382, DateTimeKind.Local).AddTicks(7164) });

            migrationBuilder.UpdateData(
                table: "Book",
                keyColumn: "BookId",
                keyValue: 1085,
                columns: new[] { "CreatedDateTime", "PublicationDate" },
                values: new object[] { new DateTime(2024, 8, 16, 16, 32, 4, 672, DateTimeKind.Utc).AddTicks(8684), new DateTime(2023, 10, 21, 14, 37, 54, 753, DateTimeKind.Local).AddTicks(8345) });

            migrationBuilder.UpdateData(
                table: "Book",
                keyColumn: "BookId",
                keyValue: 1086,
                columns: new[] { "CreatedDateTime", "PublicationDate" },
                values: new object[] { new DateTime(2024, 8, 16, 16, 32, 4, 672, DateTimeKind.Utc).AddTicks(8785), new DateTime(2024, 4, 24, 12, 19, 42, 738, DateTimeKind.Local).AddTicks(2279) });

            migrationBuilder.UpdateData(
                table: "Book",
                keyColumn: "BookId",
                keyValue: 1087,
                columns: new[] { "CreatedDateTime", "PublicationDate" },
                values: new object[] { new DateTime(2024, 8, 16, 16, 32, 4, 672, DateTimeKind.Utc).AddTicks(8910), new DateTime(2024, 1, 31, 6, 54, 49, 840, DateTimeKind.Local).AddTicks(2186) });

            migrationBuilder.UpdateData(
                table: "Book",
                keyColumn: "BookId",
                keyValue: 1088,
                columns: new[] { "CreatedDateTime", "PublicationDate" },
                values: new object[] { new DateTime(2024, 8, 16, 16, 32, 4, 672, DateTimeKind.Utc).AddTicks(9019), new DateTime(2024, 6, 11, 0, 2, 32, 439, DateTimeKind.Local).AddTicks(8154) });

            migrationBuilder.UpdateData(
                table: "Book",
                keyColumn: "BookId",
                keyValue: 1089,
                columns: new[] { "CreatedDateTime", "PublicationDate" },
                values: new object[] { new DateTime(2024, 8, 16, 16, 32, 4, 672, DateTimeKind.Utc).AddTicks(9139), new DateTime(2024, 1, 29, 8, 50, 50, 65, DateTimeKind.Local).AddTicks(4579) });

            migrationBuilder.UpdateData(
                table: "Book",
                keyColumn: "BookId",
                keyValue: 1090,
                columns: new[] { "CreatedDateTime", "PublicationDate" },
                values: new object[] { new DateTime(2024, 8, 16, 16, 32, 4, 672, DateTimeKind.Utc).AddTicks(9254), new DateTime(2024, 8, 2, 8, 44, 22, 664, DateTimeKind.Local).AddTicks(5547) });

            migrationBuilder.UpdateData(
                table: "Book",
                keyColumn: "BookId",
                keyValue: 1091,
                columns: new[] { "CreatedDateTime", "PublicationDate" },
                values: new object[] { new DateTime(2024, 8, 16, 16, 32, 4, 672, DateTimeKind.Utc).AddTicks(9386), new DateTime(2023, 10, 20, 16, 8, 23, 240, DateTimeKind.Local).AddTicks(8578) });

            migrationBuilder.UpdateData(
                table: "Book",
                keyColumn: "BookId",
                keyValue: 1092,
                columns: new[] { "CreatedDateTime", "PublicationDate" },
                values: new object[] { new DateTime(2024, 8, 16, 16, 32, 4, 672, DateTimeKind.Utc).AddTicks(9485), new DateTime(2023, 12, 23, 18, 15, 59, 113, DateTimeKind.Local).AddTicks(2484) });

            migrationBuilder.UpdateData(
                table: "Book",
                keyColumn: "BookId",
                keyValue: 1093,
                columns: new[] { "CreatedDateTime", "PublicationDate" },
                values: new object[] { new DateTime(2024, 8, 16, 16, 32, 4, 672, DateTimeKind.Utc).AddTicks(9610), new DateTime(2024, 1, 5, 16, 48, 23, 2, DateTimeKind.Local).AddTicks(4414) });

            migrationBuilder.UpdateData(
                table: "Book",
                keyColumn: "BookId",
                keyValue: 1094,
                columns: new[] { "CreatedDateTime", "PublicationDate" },
                values: new object[] { new DateTime(2024, 8, 16, 16, 32, 4, 672, DateTimeKind.Utc).AddTicks(9751), new DateTime(2023, 9, 18, 18, 59, 47, 675, DateTimeKind.Local).AddTicks(7214) });

            migrationBuilder.UpdateData(
                table: "Book",
                keyColumn: "BookId",
                keyValue: 1095,
                columns: new[] { "CreatedDateTime", "PublicationDate" },
                values: new object[] { new DateTime(2024, 8, 16, 16, 32, 4, 672, DateTimeKind.Utc).AddTicks(9852), new DateTime(2024, 5, 20, 3, 21, 31, 536, DateTimeKind.Local).AddTicks(4427) });

            migrationBuilder.UpdateData(
                table: "Book",
                keyColumn: "BookId",
                keyValue: 1096,
                columns: new[] { "CreatedDateTime", "PublicationDate" },
                values: new object[] { new DateTime(2024, 8, 16, 16, 32, 4, 672, DateTimeKind.Utc).AddTicks(9985), new DateTime(2023, 11, 28, 13, 12, 45, 462, DateTimeKind.Local).AddTicks(5839) });

            migrationBuilder.UpdateData(
                table: "Book",
                keyColumn: "BookId",
                keyValue: 1097,
                columns: new[] { "CreatedDateTime", "PublicationDate" },
                values: new object[] { new DateTime(2024, 8, 16, 16, 32, 4, 673, DateTimeKind.Utc).AddTicks(79), new DateTime(2024, 5, 31, 20, 57, 14, 163, DateTimeKind.Local).AddTicks(6277) });

            migrationBuilder.UpdateData(
                table: "Book",
                keyColumn: "BookId",
                keyValue: 1098,
                columns: new[] { "CreatedDateTime", "PublicationDate" },
                values: new object[] { new DateTime(2024, 8, 16, 16, 32, 4, 673, DateTimeKind.Utc).AddTicks(175), new DateTime(2023, 11, 30, 5, 32, 7, 858, DateTimeKind.Local).AddTicks(8928) });

            migrationBuilder.UpdateData(
                table: "Book",
                keyColumn: "BookId",
                keyValue: 1099,
                columns: new[] { "CreatedDateTime", "PublicationDate" },
                values: new object[] { new DateTime(2024, 8, 16, 16, 32, 4, 673, DateTimeKind.Utc).AddTicks(330), new DateTime(2024, 5, 29, 2, 57, 1, 670, DateTimeKind.Local).AddTicks(1123) });

            migrationBuilder.UpdateData(
                table: "Book",
                keyColumn: "BookId",
                keyValue: 1100,
                columns: new[] { "CreatedDateTime", "PublicationDate" },
                values: new object[] { new DateTime(2024, 8, 16, 16, 32, 4, 673, DateTimeKind.Utc).AddTicks(472), new DateTime(2024, 5, 17, 19, 38, 55, 94, DateTimeKind.Local).AddTicks(14) });

            migrationBuilder.UpdateData(
                table: "Book",
                keyColumn: "BookId",
                keyValue: 1101,
                columns: new[] { "CreatedDateTime", "PublicationDate" },
                values: new object[] { new DateTime(2024, 8, 16, 16, 32, 4, 673, DateTimeKind.Utc).AddTicks(571), new DateTime(2024, 1, 18, 18, 24, 11, 600, DateTimeKind.Local).AddTicks(1654) });

            migrationBuilder.UpdateData(
                table: "Book",
                keyColumn: "BookId",
                keyValue: 1102,
                columns: new[] { "CreatedDateTime", "PublicationDate" },
                values: new object[] { new DateTime(2024, 8, 16, 16, 32, 4, 673, DateTimeKind.Utc).AddTicks(700), new DateTime(2024, 2, 20, 19, 51, 2, 72, DateTimeKind.Local).AddTicks(9421) });

            migrationBuilder.UpdateData(
                table: "Book",
                keyColumn: "BookId",
                keyValue: 1103,
                columns: new[] { "CreatedDateTime", "PublicationDate" },
                values: new object[] { new DateTime(2024, 8, 16, 16, 32, 4, 673, DateTimeKind.Utc).AddTicks(802), new DateTime(2024, 3, 9, 18, 48, 12, 464, DateTimeKind.Local).AddTicks(9158) });

            migrationBuilder.UpdateData(
                table: "Book",
                keyColumn: "BookId",
                keyValue: 1104,
                columns: new[] { "CreatedDateTime", "PublicationDate" },
                values: new object[] { new DateTime(2024, 8, 16, 16, 32, 4, 673, DateTimeKind.Utc).AddTicks(943), new DateTime(2023, 12, 9, 0, 39, 6, 481, DateTimeKind.Local).AddTicks(6569) });

            migrationBuilder.UpdateData(
                table: "Book",
                keyColumn: "BookId",
                keyValue: 1105,
                columns: new[] { "CreatedDateTime", "PublicationDate" },
                values: new object[] { new DateTime(2024, 8, 16, 16, 32, 4, 673, DateTimeKind.Utc).AddTicks(1042), new DateTime(2024, 2, 10, 3, 2, 20, 411, DateTimeKind.Local).AddTicks(2815) });

            migrationBuilder.UpdateData(
                table: "Book",
                keyColumn: "BookId",
                keyValue: 1106,
                columns: new[] { "CreatedDateTime", "PublicationDate" },
                values: new object[] { new DateTime(2024, 8, 16, 16, 32, 4, 673, DateTimeKind.Utc).AddTicks(1169), new DateTime(2024, 3, 10, 8, 7, 39, 556, DateTimeKind.Local).AddTicks(6357) });

            migrationBuilder.UpdateData(
                table: "Book",
                keyColumn: "BookId",
                keyValue: 1107,
                columns: new[] { "CreatedDateTime", "PublicationDate" },
                values: new object[] { new DateTime(2024, 8, 16, 16, 32, 4, 673, DateTimeKind.Utc).AddTicks(1270), new DateTime(2024, 7, 6, 12, 26, 34, 472, DateTimeKind.Local).AddTicks(3545) });

            migrationBuilder.UpdateData(
                table: "Book",
                keyColumn: "BookId",
                keyValue: 1108,
                columns: new[] { "CreatedDateTime", "PublicationDate" },
                values: new object[] { new DateTime(2024, 8, 16, 16, 32, 4, 673, DateTimeKind.Utc).AddTicks(1412), new DateTime(2024, 5, 14, 1, 53, 18, 222, DateTimeKind.Local).AddTicks(3953) });

            migrationBuilder.UpdateData(
                table: "Book",
                keyColumn: "BookId",
                keyValue: 1109,
                columns: new[] { "CreatedDateTime", "PublicationDate" },
                values: new object[] { new DateTime(2024, 8, 16, 16, 32, 4, 673, DateTimeKind.Utc).AddTicks(1512), new DateTime(2024, 5, 10, 7, 56, 46, 780, DateTimeKind.Local).AddTicks(4506) });

            migrationBuilder.UpdateData(
                table: "Book",
                keyColumn: "BookId",
                keyValue: 1110,
                columns: new[] { "CreatedDateTime", "PublicationDate" },
                values: new object[] { new DateTime(2024, 8, 16, 16, 32, 4, 673, DateTimeKind.Utc).AddTicks(1643), new DateTime(2023, 8, 22, 2, 0, 16, 880, DateTimeKind.Local).AddTicks(4567) });

            migrationBuilder.UpdateData(
                table: "Book",
                keyColumn: "BookId",
                keyValue: 1111,
                columns: new[] { "CreatedDateTime", "PublicationDate" },
                values: new object[] { new DateTime(2024, 8, 16, 16, 32, 4, 673, DateTimeKind.Utc).AddTicks(1731), new DateTime(2024, 7, 29, 0, 0, 47, 395, DateTimeKind.Local).AddTicks(3942) });

            migrationBuilder.UpdateData(
                table: "Book",
                keyColumn: "BookId",
                keyValue: 1112,
                columns: new[] { "CreatedDateTime", "PublicationDate" },
                values: new object[] { new DateTime(2024, 8, 16, 16, 32, 4, 673, DateTimeKind.Utc).AddTicks(1855), new DateTime(2024, 2, 14, 2, 9, 11, 352, DateTimeKind.Local).AddTicks(5753) });

            migrationBuilder.UpdateData(
                table: "Book",
                keyColumn: "BookId",
                keyValue: 1113,
                columns: new[] { "CreatedDateTime", "PublicationDate" },
                values: new object[] { new DateTime(2024, 8, 16, 16, 32, 4, 673, DateTimeKind.Utc).AddTicks(1956), new DateTime(2023, 8, 28, 20, 2, 24, 973, DateTimeKind.Local).AddTicks(2514) });

            migrationBuilder.UpdateData(
                table: "Book",
                keyColumn: "BookId",
                keyValue: 1114,
                columns: new[] { "CreatedDateTime", "PublicationDate" },
                values: new object[] { new DateTime(2024, 8, 16, 16, 32, 4, 673, DateTimeKind.Utc).AddTicks(2107), new DateTime(2023, 10, 26, 5, 14, 46, 941, DateTimeKind.Local).AddTicks(931) });

            migrationBuilder.UpdateData(
                table: "Book",
                keyColumn: "BookId",
                keyValue: 1115,
                columns: new[] { "CreatedDateTime", "PublicationDate" },
                values: new object[] { new DateTime(2024, 8, 16, 16, 32, 4, 673, DateTimeKind.Utc).AddTicks(2249), new DateTime(2023, 10, 1, 3, 42, 32, 845, DateTimeKind.Local).AddTicks(8712) });

            migrationBuilder.UpdateData(
                table: "Book",
                keyColumn: "BookId",
                keyValue: 1116,
                columns: new[] { "CreatedDateTime", "PublicationDate" },
                values: new object[] { new DateTime(2024, 8, 16, 16, 32, 4, 673, DateTimeKind.Utc).AddTicks(2347), new DateTime(2024, 1, 4, 1, 59, 13, 62, DateTimeKind.Local).AddTicks(5304) });

            migrationBuilder.UpdateData(
                table: "Book",
                keyColumn: "BookId",
                keyValue: 1117,
                columns: new[] { "CreatedDateTime", "PublicationDate" },
                values: new object[] { new DateTime(2024, 8, 16, 16, 32, 4, 673, DateTimeKind.Utc).AddTicks(2475), new DateTime(2024, 3, 5, 19, 49, 32, 466, DateTimeKind.Local).AddTicks(2832) });

            migrationBuilder.UpdateData(
                table: "Book",
                keyColumn: "BookId",
                keyValue: 1118,
                columns: new[] { "CreatedDateTime", "PublicationDate" },
                values: new object[] { new DateTime(2024, 8, 16, 16, 32, 4, 673, DateTimeKind.Utc).AddTicks(2577), new DateTime(2024, 2, 21, 20, 45, 53, 365, DateTimeKind.Local).AddTicks(5623) });

            migrationBuilder.UpdateData(
                table: "Book",
                keyColumn: "BookId",
                keyValue: 1119,
                columns: new[] { "CreatedDateTime", "PublicationDate" },
                values: new object[] { new DateTime(2024, 8, 16, 16, 32, 4, 673, DateTimeKind.Utc).AddTicks(2713), new DateTime(2024, 2, 24, 21, 41, 51, 447, DateTimeKind.Local).AddTicks(4202) });

            migrationBuilder.UpdateData(
                table: "Book",
                keyColumn: "BookId",
                keyValue: 1120,
                columns: new[] { "CreatedDateTime", "PublicationDate" },
                values: new object[] { new DateTime(2024, 8, 16, 16, 32, 4, 673, DateTimeKind.Utc).AddTicks(2818), new DateTime(2024, 1, 26, 16, 39, 21, 702, DateTimeKind.Local).AddTicks(2569) });

            migrationBuilder.UpdateData(
                table: "Book",
                keyColumn: "BookId",
                keyValue: 1121,
                columns: new[] { "CreatedDateTime", "PublicationDate" },
                values: new object[] { new DateTime(2024, 8, 16, 16, 32, 4, 673, DateTimeKind.Utc).AddTicks(2950), new DateTime(2024, 7, 11, 3, 9, 41, 168, DateTimeKind.Local).AddTicks(6860) });

            migrationBuilder.UpdateData(
                table: "Book",
                keyColumn: "BookId",
                keyValue: 1122,
                columns: new[] { "CreatedDateTime", "PublicationDate" },
                values: new object[] { new DateTime(2024, 8, 16, 16, 32, 4, 673, DateTimeKind.Utc).AddTicks(3059), new DateTime(2023, 12, 23, 12, 55, 18, 323, DateTimeKind.Local).AddTicks(3321) });

            migrationBuilder.UpdateData(
                table: "Book",
                keyColumn: "BookId",
                keyValue: 1123,
                columns: new[] { "CreatedDateTime", "PublicationDate" },
                values: new object[] { new DateTime(2024, 8, 16, 16, 32, 4, 673, DateTimeKind.Utc).AddTicks(3194), new DateTime(2023, 9, 13, 14, 14, 25, 422, DateTimeKind.Local).AddTicks(9645) });

            migrationBuilder.UpdateData(
                table: "Book",
                keyColumn: "BookId",
                keyValue: 1124,
                columns: new[] { "CreatedDateTime", "PublicationDate" },
                values: new object[] { new DateTime(2024, 8, 16, 16, 32, 4, 673, DateTimeKind.Utc).AddTicks(3336), new DateTime(2024, 5, 15, 19, 16, 26, 877, DateTimeKind.Local).AddTicks(4203) });

            migrationBuilder.UpdateData(
                table: "Book",
                keyColumn: "BookId",
                keyValue: 1125,
                columns: new[] { "CreatedDateTime", "PublicationDate" },
                values: new object[] { new DateTime(2024, 8, 16, 16, 32, 4, 673, DateTimeKind.Utc).AddTicks(3440), new DateTime(2024, 6, 15, 23, 41, 32, 522, DateTimeKind.Local).AddTicks(2048) });

            migrationBuilder.UpdateData(
                table: "Book",
                keyColumn: "BookId",
                keyValue: 1126,
                columns: new[] { "CreatedDateTime", "PublicationDate" },
                values: new object[] { new DateTime(2024, 8, 16, 16, 32, 4, 673, DateTimeKind.Utc).AddTicks(3556), new DateTime(2024, 7, 14, 3, 10, 37, 832, DateTimeKind.Local).AddTicks(1691) });

            migrationBuilder.UpdateData(
                table: "Book",
                keyColumn: "BookId",
                keyValue: 1127,
                columns: new[] { "CreatedDateTime", "PublicationDate" },
                values: new object[] { new DateTime(2024, 8, 16, 16, 32, 4, 673, DateTimeKind.Utc).AddTicks(3668), new DateTime(2024, 3, 28, 14, 31, 11, 859, DateTimeKind.Local).AddTicks(1133) });

            migrationBuilder.UpdateData(
                table: "Book",
                keyColumn: "BookId",
                keyValue: 1128,
                columns: new[] { "CreatedDateTime", "PublicationDate" },
                values: new object[] { new DateTime(2024, 8, 16, 16, 32, 4, 673, DateTimeKind.Utc).AddTicks(3802), new DateTime(2023, 10, 5, 2, 54, 35, 713, DateTimeKind.Local).AddTicks(8547) });

            migrationBuilder.UpdateData(
                table: "Book",
                keyColumn: "BookId",
                keyValue: 1129,
                columns: new[] { "CreatedDateTime", "PublicationDate" },
                values: new object[] { new DateTime(2024, 8, 16, 16, 32, 4, 673, DateTimeKind.Utc).AddTicks(3908), new DateTime(2023, 10, 7, 1, 49, 31, 848, DateTimeKind.Local).AddTicks(1770) });

            migrationBuilder.UpdateData(
                table: "Book",
                keyColumn: "BookId",
                keyValue: 1130,
                columns: new[] { "CreatedDateTime", "PublicationDate" },
                values: new object[] { new DateTime(2024, 8, 16, 16, 32, 4, 673, DateTimeKind.Utc).AddTicks(4042), new DateTime(2024, 2, 5, 7, 46, 28, 531, DateTimeKind.Local).AddTicks(2674) });

            migrationBuilder.UpdateData(
                table: "Book",
                keyColumn: "BookId",
                keyValue: 1131,
                columns: new[] { "CreatedDateTime", "PublicationDate" },
                values: new object[] { new DateTime(2024, 8, 16, 16, 32, 4, 673, DateTimeKind.Utc).AddTicks(4140), new DateTime(2024, 1, 6, 12, 55, 11, 104, DateTimeKind.Local).AddTicks(8100) });

            migrationBuilder.UpdateData(
                table: "Book",
                keyColumn: "BookId",
                keyValue: 1132,
                columns: new[] { "CreatedDateTime", "PublicationDate" },
                values: new object[] { new DateTime(2024, 8, 16, 16, 32, 4, 673, DateTimeKind.Utc).AddTicks(4263), new DateTime(2023, 9, 28, 10, 2, 3, 282, DateTimeKind.Local).AddTicks(2630) });

            migrationBuilder.UpdateData(
                table: "Book",
                keyColumn: "BookId",
                keyValue: 1133,
                columns: new[] { "CreatedDateTime", "PublicationDate" },
                values: new object[] { new DateTime(2024, 8, 16, 16, 32, 4, 673, DateTimeKind.Utc).AddTicks(4376), new DateTime(2024, 3, 3, 5, 38, 35, 991, DateTimeKind.Local).AddTicks(207) });

            migrationBuilder.UpdateData(
                table: "Book",
                keyColumn: "BookId",
                keyValue: 1134,
                columns: new[] { "CreatedDateTime", "PublicationDate" },
                values: new object[] { new DateTime(2024, 8, 16, 16, 32, 4, 673, DateTimeKind.Utc).AddTicks(4497), new DateTime(2024, 2, 6, 21, 23, 5, 60, DateTimeKind.Local).AddTicks(9502) });

            migrationBuilder.UpdateData(
                table: "Book",
                keyColumn: "BookId",
                keyValue: 1135,
                columns: new[] { "CreatedDateTime", "PublicationDate" },
                values: new object[] { new DateTime(2024, 8, 16, 16, 32, 4, 673, DateTimeKind.Utc).AddTicks(4606), new DateTime(2024, 2, 25, 4, 50, 16, 229, DateTimeKind.Local).AddTicks(6236) });

            migrationBuilder.UpdateData(
                table: "Book",
                keyColumn: "BookId",
                keyValue: 1136,
                columns: new[] { "CreatedDateTime", "PublicationDate" },
                values: new object[] { new DateTime(2024, 8, 16, 16, 32, 4, 673, DateTimeKind.Utc).AddTicks(4731), new DateTime(2024, 5, 31, 23, 20, 6, 263, DateTimeKind.Local).AddTicks(1657) });

            migrationBuilder.UpdateData(
                table: "Book",
                keyColumn: "BookId",
                keyValue: 1137,
                columns: new[] { "CreatedDateTime", "PublicationDate" },
                values: new object[] { new DateTime(2024, 8, 16, 16, 32, 4, 673, DateTimeKind.Utc).AddTicks(4830), new DateTime(2024, 1, 23, 6, 18, 3, 136, DateTimeKind.Local).AddTicks(6287) });

            migrationBuilder.UpdateData(
                table: "Book",
                keyColumn: "BookId",
                keyValue: 1138,
                columns: new[] { "CreatedDateTime", "PublicationDate" },
                values: new object[] { new DateTime(2024, 8, 16, 16, 32, 4, 673, DateTimeKind.Utc).AddTicks(4975), new DateTime(2024, 1, 23, 21, 1, 13, 744, DateTimeKind.Local).AddTicks(3516) });

            migrationBuilder.UpdateData(
                table: "Book",
                keyColumn: "BookId",
                keyValue: 1139,
                columns: new[] { "CreatedDateTime", "PublicationDate" },
                values: new object[] { new DateTime(2024, 8, 16, 16, 32, 4, 673, DateTimeKind.Utc).AddTicks(5078), new DateTime(2024, 1, 1, 16, 54, 32, 721, DateTimeKind.Local).AddTicks(1193) });

            migrationBuilder.UpdateData(
                table: "Book",
                keyColumn: "BookId",
                keyValue: 1140,
                columns: new[] { "CreatedDateTime", "PublicationDate" },
                values: new object[] { new DateTime(2024, 8, 16, 16, 32, 4, 673, DateTimeKind.Utc).AddTicks(5215), new DateTime(2024, 1, 29, 19, 42, 31, 965, DateTimeKind.Local).AddTicks(7605) });

            migrationBuilder.UpdateData(
                table: "Book",
                keyColumn: "BookId",
                keyValue: 1141,
                columns: new[] { "CreatedDateTime", "PublicationDate" },
                values: new object[] { new DateTime(2024, 8, 16, 16, 32, 4, 673, DateTimeKind.Utc).AddTicks(5322), new DateTime(2023, 8, 23, 18, 9, 8, 871, DateTimeKind.Local).AddTicks(1150) });

            migrationBuilder.UpdateData(
                table: "Book",
                keyColumn: "BookId",
                keyValue: 1142,
                columns: new[] { "CreatedDateTime", "PublicationDate" },
                values: new object[] { new DateTime(2024, 8, 16, 16, 32, 4, 673, DateTimeKind.Utc).AddTicks(5437), new DateTime(2024, 4, 13, 4, 37, 16, 573, DateTimeKind.Local).AddTicks(5822) });

            migrationBuilder.UpdateData(
                table: "Book",
                keyColumn: "BookId",
                keyValue: 1143,
                columns: new[] { "CreatedDateTime", "PublicationDate" },
                values: new object[] { new DateTime(2024, 8, 16, 16, 32, 4, 673, DateTimeKind.Utc).AddTicks(5530), new DateTime(2023, 12, 16, 22, 39, 42, 503, DateTimeKind.Local).AddTicks(2715) });

            migrationBuilder.UpdateData(
                table: "Book",
                keyColumn: "BookId",
                keyValue: 1144,
                columns: new[] { "CreatedDateTime", "PublicationDate" },
                values: new object[] { new DateTime(2024, 8, 16, 16, 32, 4, 673, DateTimeKind.Utc).AddTicks(5671), new DateTime(2024, 3, 27, 5, 56, 45, 476, DateTimeKind.Local).AddTicks(8508) });

            migrationBuilder.UpdateData(
                table: "Book",
                keyColumn: "BookId",
                keyValue: 1145,
                columns: new[] { "CreatedDateTime", "PublicationDate" },
                values: new object[] { new DateTime(2024, 8, 16, 16, 32, 4, 673, DateTimeKind.Utc).AddTicks(5771), new DateTime(2024, 6, 1, 20, 18, 15, 183, DateTimeKind.Local).AddTicks(4852) });

            migrationBuilder.UpdateData(
                table: "Book",
                keyColumn: "BookId",
                keyValue: 1146,
                columns: new[] { "CreatedDateTime", "PublicationDate" },
                values: new object[] { new DateTime(2024, 8, 16, 16, 32, 4, 673, DateTimeKind.Utc).AddTicks(5913), new DateTime(2023, 11, 9, 14, 32, 46, 310, DateTimeKind.Local).AddTicks(3240) });

            migrationBuilder.UpdateData(
                table: "Book",
                keyColumn: "BookId",
                keyValue: 1147,
                columns: new[] { "CreatedDateTime", "PublicationDate" },
                values: new object[] { new DateTime(2024, 8, 16, 16, 32, 4, 673, DateTimeKind.Utc).AddTicks(6014), new DateTime(2024, 4, 19, 20, 20, 45, 887, DateTimeKind.Local).AddTicks(1371) });

            migrationBuilder.UpdateData(
                table: "Book",
                keyColumn: "BookId",
                keyValue: 1148,
                columns: new[] { "CreatedDateTime", "PublicationDate" },
                values: new object[] { new DateTime(2024, 8, 16, 16, 32, 4, 673, DateTimeKind.Utc).AddTicks(6145), new DateTime(2024, 4, 1, 23, 7, 33, 556, DateTimeKind.Local).AddTicks(2259) });

            migrationBuilder.UpdateData(
                table: "Book",
                keyColumn: "BookId",
                keyValue: 1149,
                columns: new[] { "CreatedDateTime", "PublicationDate" },
                values: new object[] { new DateTime(2024, 8, 16, 16, 32, 4, 673, DateTimeKind.Utc).AddTicks(6252), new DateTime(2023, 12, 3, 6, 31, 38, 516, DateTimeKind.Local).AddTicks(1729) });

            migrationBuilder.UpdateData(
                table: "Book",
                keyColumn: "BookId",
                keyValue: 1150,
                columns: new[] { "CreatedDateTime", "PublicationDate" },
                values: new object[] { new DateTime(2024, 8, 16, 16, 32, 4, 673, DateTimeKind.Utc).AddTicks(6377), new DateTime(2024, 4, 23, 7, 10, 3, 140, DateTimeKind.Local).AddTicks(3354) });

            migrationBuilder.UpdateData(
                table: "Book",
                keyColumn: "BookId",
                keyValue: 1151,
                columns: new[] { "CreatedDateTime", "PublicationDate" },
                values: new object[] { new DateTime(2024, 8, 16, 16, 32, 4, 673, DateTimeKind.Utc).AddTicks(6469), new DateTime(2024, 4, 16, 23, 17, 28, 961, DateTimeKind.Local).AddTicks(9625) });

            migrationBuilder.UpdateData(
                table: "Book",
                keyColumn: "BookId",
                keyValue: 1152,
                columns: new[] { "CreatedDateTime", "PublicationDate" },
                values: new object[] { new DateTime(2024, 8, 16, 16, 32, 4, 673, DateTimeKind.Utc).AddTicks(6593), new DateTime(2024, 1, 2, 5, 42, 48, 223, DateTimeKind.Local).AddTicks(8293) });

            migrationBuilder.UpdateData(
                table: "Book",
                keyColumn: "BookId",
                keyValue: 1153,
                columns: new[] { "CreatedDateTime", "PublicationDate" },
                values: new object[] { new DateTime(2024, 8, 16, 16, 32, 4, 673, DateTimeKind.Utc).AddTicks(6716), new DateTime(2024, 7, 7, 2, 54, 52, 4, DateTimeKind.Local).AddTicks(2205) });

            migrationBuilder.UpdateData(
                table: "Book",
                keyColumn: "BookId",
                keyValue: 1154,
                columns: new[] { "CreatedDateTime", "PublicationDate" },
                values: new object[] { new DateTime(2024, 8, 16, 16, 32, 4, 673, DateTimeKind.Utc).AddTicks(6821), new DateTime(2023, 9, 7, 8, 4, 17, 537, DateTimeKind.Local).AddTicks(7376) });

            migrationBuilder.UpdateData(
                table: "Book",
                keyColumn: "BookId",
                keyValue: 1155,
                columns: new[] { "CreatedDateTime", "PublicationDate" },
                values: new object[] { new DateTime(2024, 8, 16, 16, 32, 4, 673, DateTimeKind.Utc).AddTicks(6957), new DateTime(2024, 1, 30, 0, 55, 49, 833, DateTimeKind.Local).AddTicks(824) });

            migrationBuilder.UpdateData(
                table: "Book",
                keyColumn: "BookId",
                keyValue: 1156,
                columns: new[] { "CreatedDateTime", "PublicationDate" },
                values: new object[] { new DateTime(2024, 8, 16, 16, 32, 4, 673, DateTimeKind.Utc).AddTicks(7052), new DateTime(2024, 6, 29, 17, 22, 48, 732, DateTimeKind.Local).AddTicks(6336) });

            migrationBuilder.UpdateData(
                table: "Book",
                keyColumn: "BookId",
                keyValue: 1157,
                columns: new[] { "CreatedDateTime", "PublicationDate" },
                values: new object[] { new DateTime(2024, 8, 16, 16, 32, 4, 673, DateTimeKind.Utc).AddTicks(7166), new DateTime(2024, 6, 22, 11, 32, 57, 522, DateTimeKind.Local).AddTicks(2109) });

            migrationBuilder.UpdateData(
                table: "Book",
                keyColumn: "BookId",
                keyValue: 1158,
                columns: new[] { "CreatedDateTime", "PublicationDate" },
                values: new object[] { new DateTime(2024, 8, 16, 16, 32, 4, 673, DateTimeKind.Utc).AddTicks(7255), new DateTime(2024, 8, 6, 22, 20, 38, 462, DateTimeKind.Local).AddTicks(884) });

            migrationBuilder.UpdateData(
                table: "Book",
                keyColumn: "BookId",
                keyValue: 1159,
                columns: new[] { "CreatedDateTime", "PublicationDate" },
                values: new object[] { new DateTime(2024, 8, 16, 16, 32, 4, 673, DateTimeKind.Utc).AddTicks(7389), new DateTime(2024, 4, 8, 15, 10, 38, 539, DateTimeKind.Local).AddTicks(9913) });

            migrationBuilder.UpdateData(
                table: "Book",
                keyColumn: "BookId",
                keyValue: 1160,
                columns: new[] { "CreatedDateTime", "PublicationDate" },
                values: new object[] { new DateTime(2024, 8, 16, 16, 32, 4, 673, DateTimeKind.Utc).AddTicks(7498), new DateTime(2023, 11, 14, 22, 14, 31, 347, DateTimeKind.Local).AddTicks(2252) });

            migrationBuilder.UpdateData(
                table: "Book",
                keyColumn: "BookId",
                keyValue: 1161,
                columns: new[] { "CreatedDateTime", "PublicationDate" },
                values: new object[] { new DateTime(2024, 8, 16, 16, 32, 4, 673, DateTimeKind.Utc).AddTicks(7602), new DateTime(2023, 10, 6, 15, 41, 26, 212, DateTimeKind.Local).AddTicks(5094) });

            migrationBuilder.UpdateData(
                table: "Book",
                keyColumn: "BookId",
                keyValue: 1162,
                columns: new[] { "CreatedDateTime", "PublicationDate" },
                values: new object[] { new DateTime(2024, 8, 16, 16, 32, 4, 673, DateTimeKind.Utc).AddTicks(7700), new DateTime(2024, 4, 25, 23, 1, 15, 103, DateTimeKind.Local).AddTicks(6384) });

            migrationBuilder.UpdateData(
                table: "Book",
                keyColumn: "BookId",
                keyValue: 1163,
                columns: new[] { "CreatedDateTime", "PublicationDate" },
                values: new object[] { new DateTime(2024, 8, 16, 16, 32, 4, 673, DateTimeKind.Utc).AddTicks(7830), new DateTime(2024, 8, 2, 11, 43, 25, 616, DateTimeKind.Local).AddTicks(4370) });

            migrationBuilder.UpdateData(
                table: "Book",
                keyColumn: "BookId",
                keyValue: 1164,
                columns: new[] { "CreatedDateTime", "PublicationDate" },
                values: new object[] { new DateTime(2024, 8, 16, 16, 32, 4, 673, DateTimeKind.Utc).AddTicks(7922), new DateTime(2023, 9, 1, 22, 9, 38, 544, DateTimeKind.Local).AddTicks(8327) });

            migrationBuilder.UpdateData(
                table: "Book",
                keyColumn: "BookId",
                keyValue: 1165,
                columns: new[] { "CreatedDateTime", "PublicationDate" },
                values: new object[] { new DateTime(2024, 8, 16, 16, 32, 4, 673, DateTimeKind.Utc).AddTicks(8053), new DateTime(2024, 4, 7, 3, 41, 12, 189, DateTimeKind.Local).AddTicks(1960) });

            migrationBuilder.UpdateData(
                table: "Book",
                keyColumn: "BookId",
                keyValue: 1166,
                columns: new[] { "CreatedDateTime", "PublicationDate" },
                values: new object[] { new DateTime(2024, 8, 16, 16, 32, 4, 673, DateTimeKind.Utc).AddTicks(8172), new DateTime(2023, 9, 13, 21, 9, 13, 730, DateTimeKind.Local).AddTicks(2426) });

            migrationBuilder.UpdateData(
                table: "Book",
                keyColumn: "BookId",
                keyValue: 1167,
                columns: new[] { "CreatedDateTime", "PublicationDate" },
                values: new object[] { new DateTime(2024, 8, 16, 16, 32, 4, 673, DateTimeKind.Utc).AddTicks(8308), new DateTime(2024, 1, 11, 6, 5, 35, 574, DateTimeKind.Local).AddTicks(8227) });

            migrationBuilder.UpdateData(
                table: "Book",
                keyColumn: "BookId",
                keyValue: 1168,
                columns: new[] { "CreatedDateTime", "PublicationDate" },
                values: new object[] { new DateTime(2024, 8, 16, 16, 32, 4, 673, DateTimeKind.Utc).AddTicks(8412), new DateTime(2023, 11, 24, 18, 57, 15, 370, DateTimeKind.Local).AddTicks(7983) });

            migrationBuilder.UpdateData(
                table: "Book",
                keyColumn: "BookId",
                keyValue: 1169,
                columns: new[] { "CreatedDateTime", "PublicationDate" },
                values: new object[] { new DateTime(2024, 8, 16, 16, 32, 4, 673, DateTimeKind.Utc).AddTicks(8545), new DateTime(2024, 5, 12, 16, 13, 13, 168, DateTimeKind.Local).AddTicks(9471) });

            migrationBuilder.UpdateData(
                table: "Book",
                keyColumn: "BookId",
                keyValue: 1170,
                columns: new[] { "CreatedDateTime", "PublicationDate" },
                values: new object[] { new DateTime(2024, 8, 16, 16, 32, 4, 673, DateTimeKind.Utc).AddTicks(8636), new DateTime(2024, 6, 6, 17, 7, 7, 35, DateTimeKind.Local).AddTicks(5077) });

            migrationBuilder.UpdateData(
                table: "Book",
                keyColumn: "BookId",
                keyValue: 1171,
                columns: new[] { "CreatedDateTime", "PublicationDate" },
                values: new object[] { new DateTime(2024, 8, 16, 16, 32, 4, 673, DateTimeKind.Utc).AddTicks(8756), new DateTime(2023, 11, 16, 16, 0, 17, 132, DateTimeKind.Local).AddTicks(5421) });

            migrationBuilder.UpdateData(
                table: "Book",
                keyColumn: "BookId",
                keyValue: 1172,
                columns: new[] { "CreatedDateTime", "PublicationDate" },
                values: new object[] { new DateTime(2024, 8, 16, 16, 32, 4, 673, DateTimeKind.Utc).AddTicks(8854), new DateTime(2023, 10, 4, 22, 23, 21, 621, DateTimeKind.Local).AddTicks(924) });

            migrationBuilder.UpdateData(
                table: "Book",
                keyColumn: "BookId",
                keyValue: 1173,
                columns: new[] { "CreatedDateTime", "PublicationDate" },
                values: new object[] { new DateTime(2024, 8, 16, 16, 32, 4, 673, DateTimeKind.Utc).AddTicks(8976), new DateTime(2023, 11, 14, 21, 4, 2, 233, DateTimeKind.Local).AddTicks(3172) });

            migrationBuilder.UpdateData(
                table: "Book",
                keyColumn: "BookId",
                keyValue: 1174,
                columns: new[] { "CreatedDateTime", "PublicationDate" },
                values: new object[] { new DateTime(2024, 8, 16, 16, 32, 4, 673, DateTimeKind.Utc).AddTicks(9083), new DateTime(2024, 1, 15, 7, 29, 20, 127, DateTimeKind.Local).AddTicks(924) });

            migrationBuilder.UpdateData(
                table: "Book",
                keyColumn: "BookId",
                keyValue: 1175,
                columns: new[] { "CreatedDateTime", "PublicationDate" },
                values: new object[] { new DateTime(2024, 8, 16, 16, 32, 4, 673, DateTimeKind.Utc).AddTicks(9211), new DateTime(2024, 6, 14, 11, 25, 14, 458, DateTimeKind.Local).AddTicks(9857) });

            migrationBuilder.UpdateData(
                table: "Book",
                keyColumn: "BookId",
                keyValue: 1176,
                columns: new[] { "CreatedDateTime", "PublicationDate" },
                values: new object[] { new DateTime(2024, 8, 16, 16, 32, 4, 673, DateTimeKind.Utc).AddTicks(9313), new DateTime(2023, 12, 26, 5, 32, 35, 541, DateTimeKind.Local).AddTicks(6497) });

            migrationBuilder.UpdateData(
                table: "Book",
                keyColumn: "BookId",
                keyValue: 1177,
                columns: new[] { "CreatedDateTime", "PublicationDate" },
                values: new object[] { new DateTime(2024, 8, 16, 16, 32, 4, 673, DateTimeKind.Utc).AddTicks(9445), new DateTime(2024, 3, 13, 21, 24, 8, 237, DateTimeKind.Local).AddTicks(4444) });

            migrationBuilder.UpdateData(
                table: "Book",
                keyColumn: "BookId",
                keyValue: 1178,
                columns: new[] { "CreatedDateTime", "PublicationDate" },
                values: new object[] { new DateTime(2024, 8, 16, 16, 32, 4, 673, DateTimeKind.Utc).AddTicks(9545), new DateTime(2024, 6, 19, 21, 48, 19, 764, DateTimeKind.Local).AddTicks(864) });

            migrationBuilder.UpdateData(
                table: "Book",
                keyColumn: "BookId",
                keyValue: 1179,
                columns: new[] { "CreatedDateTime", "PublicationDate" },
                values: new object[] { new DateTime(2024, 8, 16, 16, 32, 4, 673, DateTimeKind.Utc).AddTicks(9692), new DateTime(2024, 3, 1, 5, 56, 38, 572, DateTimeKind.Local).AddTicks(8453) });

            migrationBuilder.UpdateData(
                table: "Book",
                keyColumn: "BookId",
                keyValue: 1180,
                columns: new[] { "CreatedDateTime", "PublicationDate" },
                values: new object[] { new DateTime(2024, 8, 16, 16, 32, 4, 673, DateTimeKind.Utc).AddTicks(9846), new DateTime(2024, 8, 5, 12, 16, 2, 936, DateTimeKind.Local).AddTicks(9847) });

            migrationBuilder.UpdateData(
                table: "Book",
                keyColumn: "BookId",
                keyValue: 1181,
                columns: new[] { "CreatedDateTime", "PublicationDate" },
                values: new object[] { new DateTime(2024, 8, 16, 16, 32, 4, 673, DateTimeKind.Utc).AddTicks(9962), new DateTime(2024, 1, 21, 3, 59, 21, 491, DateTimeKind.Local).AddTicks(1045) });

            migrationBuilder.UpdateData(
                table: "Book",
                keyColumn: "BookId",
                keyValue: 1182,
                columns: new[] { "CreatedDateTime", "PublicationDate" },
                values: new object[] { new DateTime(2024, 8, 16, 16, 32, 4, 674, DateTimeKind.Utc).AddTicks(88), new DateTime(2024, 1, 7, 5, 43, 1, 266, DateTimeKind.Local).AddTicks(5139) });

            migrationBuilder.UpdateData(
                table: "Book",
                keyColumn: "BookId",
                keyValue: 1183,
                columns: new[] { "CreatedDateTime", "PublicationDate" },
                values: new object[] { new DateTime(2024, 8, 16, 16, 32, 4, 674, DateTimeKind.Utc).AddTicks(188), new DateTime(2024, 3, 3, 13, 6, 49, 873, DateTimeKind.Local).AddTicks(2612) });

            migrationBuilder.UpdateData(
                table: "Book",
                keyColumn: "BookId",
                keyValue: 1184,
                columns: new[] { "CreatedDateTime", "PublicationDate" },
                values: new object[] { new DateTime(2024, 8, 16, 16, 32, 4, 674, DateTimeKind.Utc).AddTicks(321), new DateTime(2024, 8, 16, 9, 52, 8, 295, DateTimeKind.Local).AddTicks(9107) });

            migrationBuilder.UpdateData(
                table: "Book",
                keyColumn: "BookId",
                keyValue: 1185,
                columns: new[] { "CreatedDateTime", "PublicationDate" },
                values: new object[] { new DateTime(2024, 8, 16, 16, 32, 4, 674, DateTimeKind.Utc).AddTicks(415), new DateTime(2024, 3, 29, 13, 8, 44, 891, DateTimeKind.Local).AddTicks(465) });

            migrationBuilder.UpdateData(
                table: "Book",
                keyColumn: "BookId",
                keyValue: 1186,
                columns: new[] { "CreatedDateTime", "PublicationDate" },
                values: new object[] { new DateTime(2024, 8, 16, 16, 32, 4, 674, DateTimeKind.Utc).AddTicks(545), new DateTime(2024, 7, 19, 17, 13, 48, 31, DateTimeKind.Local).AddTicks(1885) });

            migrationBuilder.UpdateData(
                table: "Book",
                keyColumn: "BookId",
                keyValue: 1187,
                columns: new[] { "CreatedDateTime", "PublicationDate" },
                values: new object[] { new DateTime(2024, 8, 16, 16, 32, 4, 674, DateTimeKind.Utc).AddTicks(648), new DateTime(2023, 8, 21, 6, 14, 32, 919, DateTimeKind.Local).AddTicks(3598) });

            migrationBuilder.UpdateData(
                table: "Book",
                keyColumn: "BookId",
                keyValue: 1188,
                columns: new[] { "CreatedDateTime", "PublicationDate" },
                values: new object[] { new DateTime(2024, 8, 16, 16, 32, 4, 674, DateTimeKind.Utc).AddTicks(786), new DateTime(2024, 4, 6, 10, 11, 13, 542, DateTimeKind.Local).AddTicks(3718) });

            migrationBuilder.UpdateData(
                table: "Book",
                keyColumn: "BookId",
                keyValue: 1189,
                columns: new[] { "CreatedDateTime", "PublicationDate" },
                values: new object[] { new DateTime(2024, 8, 16, 16, 32, 4, 674, DateTimeKind.Utc).AddTicks(888), new DateTime(2024, 7, 12, 19, 7, 20, 447, DateTimeKind.Local).AddTicks(9093) });

            migrationBuilder.UpdateData(
                table: "Book",
                keyColumn: "BookId",
                keyValue: 1190,
                columns: new[] { "CreatedDateTime", "PublicationDate" },
                values: new object[] { new DateTime(2024, 8, 16, 16, 32, 4, 674, DateTimeKind.Utc).AddTicks(1023), new DateTime(2024, 3, 29, 9, 55, 22, 128, DateTimeKind.Local).AddTicks(2047) });

            migrationBuilder.UpdateData(
                table: "Book",
                keyColumn: "BookId",
                keyValue: 1191,
                columns: new[] { "CreatedDateTime", "PublicationDate" },
                values: new object[] { new DateTime(2024, 8, 16, 16, 32, 4, 674, DateTimeKind.Utc).AddTicks(1137), new DateTime(2024, 6, 8, 23, 9, 44, 70, DateTimeKind.Local).AddTicks(6032) });

            migrationBuilder.UpdateData(
                table: "Book",
                keyColumn: "BookId",
                keyValue: 1192,
                columns: new[] { "CreatedDateTime", "PublicationDate" },
                values: new object[] { new DateTime(2024, 8, 16, 16, 32, 4, 674, DateTimeKind.Utc).AddTicks(1258), new DateTime(2023, 8, 19, 17, 26, 12, 243, DateTimeKind.Local).AddTicks(2360) });

            migrationBuilder.UpdateData(
                table: "Book",
                keyColumn: "BookId",
                keyValue: 1193,
                columns: new[] { "CreatedDateTime", "PublicationDate" },
                values: new object[] { new DateTime(2024, 8, 16, 16, 32, 4, 674, DateTimeKind.Utc).AddTicks(1387), new DateTime(2024, 7, 12, 23, 55, 3, 935, DateTimeKind.Local).AddTicks(9795) });

            migrationBuilder.UpdateData(
                table: "Book",
                keyColumn: "BookId",
                keyValue: 1194,
                columns: new[] { "CreatedDateTime", "PublicationDate" },
                values: new object[] { new DateTime(2024, 8, 16, 16, 32, 4, 674, DateTimeKind.Utc).AddTicks(1489), new DateTime(2023, 8, 25, 23, 39, 2, 475, DateTimeKind.Local).AddTicks(5826) });

            migrationBuilder.UpdateData(
                table: "Book",
                keyColumn: "BookId",
                keyValue: 1195,
                columns: new[] { "CreatedDateTime", "PublicationDate" },
                values: new object[] { new DateTime(2024, 8, 16, 16, 32, 4, 674, DateTimeKind.Utc).AddTicks(1581), new DateTime(2024, 2, 2, 20, 1, 25, 71, DateTimeKind.Local).AddTicks(176) });

            migrationBuilder.UpdateData(
                table: "Book",
                keyColumn: "BookId",
                keyValue: 1196,
                columns: new[] { "CreatedDateTime", "PublicationDate" },
                values: new object[] { new DateTime(2024, 8, 16, 16, 32, 4, 674, DateTimeKind.Utc).AddTicks(1725), new DateTime(2023, 12, 5, 22, 13, 26, 617, DateTimeKind.Local).AddTicks(6447) });

            migrationBuilder.UpdateData(
                table: "Book",
                keyColumn: "BookId",
                keyValue: 1197,
                columns: new[] { "CreatedDateTime", "PublicationDate" },
                values: new object[] { new DateTime(2024, 8, 16, 16, 32, 4, 674, DateTimeKind.Utc).AddTicks(1864), new DateTime(2024, 1, 6, 16, 10, 0, 409, DateTimeKind.Local).AddTicks(2313) });

            migrationBuilder.UpdateData(
                table: "Book",
                keyColumn: "BookId",
                keyValue: 1198,
                columns: new[] { "CreatedDateTime", "PublicationDate" },
                values: new object[] { new DateTime(2024, 8, 16, 16, 32, 4, 674, DateTimeKind.Utc).AddTicks(1967), new DateTime(2023, 12, 1, 5, 51, 8, 724, DateTimeKind.Local).AddTicks(5685) });

            migrationBuilder.UpdateData(
                table: "Book",
                keyColumn: "BookId",
                keyValue: 1199,
                columns: new[] { "CreatedDateTime", "PublicationDate" },
                values: new object[] { new DateTime(2024, 8, 16, 16, 32, 4, 674, DateTimeKind.Utc).AddTicks(2088), new DateTime(2024, 2, 27, 10, 0, 24, 975, DateTimeKind.Local).AddTicks(4689) });

            migrationBuilder.UpdateData(
                table: "Book",
                keyColumn: "BookId",
                keyValue: 1200,
                columns: new[] { "CreatedDateTime", "PublicationDate" },
                values: new object[] { new DateTime(2024, 8, 16, 16, 32, 4, 674, DateTimeKind.Utc).AddTicks(2175), new DateTime(2024, 8, 8, 15, 56, 21, 878, DateTimeKind.Local).AddTicks(7989) });

            migrationBuilder.UpdateData(
                table: "Book",
                keyColumn: "BookId",
                keyValue: 1201,
                columns: new[] { "CreatedDateTime", "PublicationDate" },
                values: new object[] { new DateTime(2024, 8, 16, 16, 32, 4, 674, DateTimeKind.Utc).AddTicks(2275), new DateTime(2024, 6, 23, 5, 31, 45, 482, DateTimeKind.Local).AddTicks(8330) });

            migrationBuilder.UpdateData(
                table: "Book",
                keyColumn: "BookId",
                keyValue: 1202,
                columns: new[] { "CreatedDateTime", "PublicationDate" },
                values: new object[] { new DateTime(2024, 8, 16, 16, 32, 4, 674, DateTimeKind.Utc).AddTicks(2406), new DateTime(2024, 5, 21, 7, 6, 57, 904, DateTimeKind.Local).AddTicks(6074) });

            migrationBuilder.UpdateData(
                table: "Book",
                keyColumn: "BookId",
                keyValue: 1203,
                columns: new[] { "CreatedDateTime", "PublicationDate" },
                values: new object[] { new DateTime(2024, 8, 16, 16, 32, 4, 674, DateTimeKind.Utc).AddTicks(2535), new DateTime(2024, 5, 12, 2, 35, 27, 273, DateTimeKind.Local).AddTicks(7213) });

            migrationBuilder.UpdateData(
                table: "Book",
                keyColumn: "BookId",
                keyValue: 1204,
                columns: new[] { "CreatedDateTime", "PublicationDate" },
                values: new object[] { new DateTime(2024, 8, 16, 16, 32, 4, 674, DateTimeKind.Utc).AddTicks(2626), new DateTime(2024, 3, 21, 21, 17, 5, 13, DateTimeKind.Local).AddTicks(1818) });

            migrationBuilder.UpdateData(
                table: "Book",
                keyColumn: "BookId",
                keyValue: 1205,
                columns: new[] { "CreatedDateTime", "PublicationDate" },
                values: new object[] { new DateTime(2024, 8, 16, 16, 32, 4, 674, DateTimeKind.Utc).AddTicks(2755), new DateTime(2024, 5, 6, 7, 30, 25, 276, DateTimeKind.Local).AddTicks(77) });

            migrationBuilder.UpdateData(
                table: "Book",
                keyColumn: "BookId",
                keyValue: 1206,
                columns: new[] { "CreatedDateTime", "PublicationDate" },
                values: new object[] { new DateTime(2024, 8, 16, 16, 32, 4, 674, DateTimeKind.Utc).AddTicks(2860), new DateTime(2024, 5, 11, 6, 27, 34, 498, DateTimeKind.Local).AddTicks(2010) });

            migrationBuilder.UpdateData(
                table: "Book",
                keyColumn: "BookId",
                keyValue: 1207,
                columns: new[] { "CreatedDateTime", "PublicationDate" },
                values: new object[] { new DateTime(2024, 8, 16, 16, 32, 4, 674, DateTimeKind.Utc).AddTicks(2983), new DateTime(2023, 12, 17, 4, 56, 50, 340, DateTimeKind.Local).AddTicks(4913) });

            migrationBuilder.UpdateData(
                table: "Book",
                keyColumn: "BookId",
                keyValue: 1208,
                columns: new[] { "CreatedDateTime", "PublicationDate" },
                values: new object[] { new DateTime(2024, 8, 16, 16, 32, 4, 674, DateTimeKind.Utc).AddTicks(3076), new DateTime(2024, 3, 21, 3, 1, 47, 69, DateTimeKind.Local).AddTicks(3547) });

            migrationBuilder.UpdateData(
                table: "Book",
                keyColumn: "BookId",
                keyValue: 1209,
                columns: new[] { "CreatedDateTime", "PublicationDate" },
                values: new object[] { new DateTime(2024, 8, 16, 16, 32, 4, 674, DateTimeKind.Utc).AddTicks(3204), new DateTime(2024, 3, 8, 8, 21, 5, 759, DateTimeKind.Local).AddTicks(4619) });

            migrationBuilder.UpdateData(
                table: "Book",
                keyColumn: "BookId",
                keyValue: 1210,
                columns: new[] { "CreatedDateTime", "PublicationDate" },
                values: new object[] { new DateTime(2024, 8, 16, 16, 32, 4, 674, DateTimeKind.Utc).AddTicks(3311), new DateTime(2023, 8, 21, 11, 39, 50, 604, DateTimeKind.Local).AddTicks(9595) });

            migrationBuilder.UpdateData(
                table: "Book",
                keyColumn: "BookId",
                keyValue: 1211,
                columns: new[] { "CreatedDateTime", "PublicationDate" },
                values: new object[] { new DateTime(2024, 8, 16, 16, 32, 4, 674, DateTimeKind.Utc).AddTicks(3453), new DateTime(2024, 3, 27, 15, 25, 6, 803, DateTimeKind.Local).AddTicks(3594) });

            migrationBuilder.UpdateData(
                table: "Book",
                keyColumn: "BookId",
                keyValue: 1212,
                columns: new[] { "CreatedDateTime", "PublicationDate" },
                values: new object[] { new DateTime(2024, 8, 16, 16, 32, 4, 674, DateTimeKind.Utc).AddTicks(3554), new DateTime(2024, 6, 2, 14, 45, 10, 873, DateTimeKind.Local).AddTicks(559) });

            migrationBuilder.UpdateData(
                table: "Book",
                keyColumn: "BookId",
                keyValue: 1213,
                columns: new[] { "CreatedDateTime", "PublicationDate" },
                values: new object[] { new DateTime(2024, 8, 16, 16, 32, 4, 674, DateTimeKind.Utc).AddTicks(3688), new DateTime(2023, 8, 16, 23, 55, 44, 444, DateTimeKind.Local).AddTicks(9020) });

            migrationBuilder.UpdateData(
                table: "Book",
                keyColumn: "BookId",
                keyValue: 1214,
                columns: new[] { "CreatedDateTime", "PublicationDate" },
                values: new object[] { new DateTime(2024, 8, 16, 16, 32, 4, 674, DateTimeKind.Utc).AddTicks(3829), new DateTime(2023, 10, 5, 17, 30, 8, 998, DateTimeKind.Local).AddTicks(729) });

            migrationBuilder.UpdateData(
                table: "Book",
                keyColumn: "BookId",
                keyValue: 1215,
                columns: new[] { "CreatedDateTime", "PublicationDate" },
                values: new object[] { new DateTime(2024, 8, 16, 16, 32, 4, 674, DateTimeKind.Utc).AddTicks(3929), new DateTime(2023, 10, 21, 5, 3, 52, 332, DateTimeKind.Local).AddTicks(1419) });

            migrationBuilder.UpdateData(
                table: "Book",
                keyColumn: "BookId",
                keyValue: 1216,
                columns: new[] { "CreatedDateTime", "PublicationDate" },
                values: new object[] { new DateTime(2024, 8, 16, 16, 32, 4, 674, DateTimeKind.Utc).AddTicks(4025), new DateTime(2024, 7, 4, 5, 47, 9, 81, DateTimeKind.Local).AddTicks(4184) });

            migrationBuilder.UpdateData(
                table: "Book",
                keyColumn: "BookId",
                keyValue: 1217,
                columns: new[] { "CreatedDateTime", "PublicationDate" },
                values: new object[] { new DateTime(2024, 8, 16, 16, 32, 4, 674, DateTimeKind.Utc).AddTicks(4157), new DateTime(2023, 12, 8, 11, 8, 9, 877, DateTimeKind.Local).AddTicks(8347) });

            migrationBuilder.UpdateData(
                table: "Book",
                keyColumn: "BookId",
                keyValue: 1218,
                columns: new[] { "CreatedDateTime", "PublicationDate" },
                values: new object[] { new DateTime(2024, 8, 16, 16, 32, 4, 674, DateTimeKind.Utc).AddTicks(4296), new DateTime(2023, 10, 22, 7, 43, 35, 919, DateTimeKind.Local).AddTicks(263) });

            migrationBuilder.UpdateData(
                table: "Book",
                keyColumn: "BookId",
                keyValue: 1219,
                columns: new[] { "CreatedDateTime", "PublicationDate" },
                values: new object[] { new DateTime(2024, 8, 16, 16, 32, 4, 674, DateTimeKind.Utc).AddTicks(4392), new DateTime(2024, 3, 14, 3, 24, 20, 983, DateTimeKind.Local).AddTicks(9719) });

            migrationBuilder.UpdateData(
                table: "Book",
                keyColumn: "BookId",
                keyValue: 1220,
                columns: new[] { "CreatedDateTime", "PublicationDate" },
                values: new object[] { new DateTime(2024, 8, 16, 16, 32, 4, 674, DateTimeKind.Utc).AddTicks(4540), new DateTime(2023, 12, 12, 22, 18, 36, 709, DateTimeKind.Local).AddTicks(6248) });

            migrationBuilder.UpdateData(
                table: "Book",
                keyColumn: "BookId",
                keyValue: 1221,
                columns: new[] { "CreatedDateTime", "PublicationDate" },
                values: new object[] { new DateTime(2024, 8, 16, 16, 32, 4, 674, DateTimeKind.Utc).AddTicks(4632), new DateTime(2023, 9, 13, 4, 1, 40, 890, DateTimeKind.Local).AddTicks(3727) });

            migrationBuilder.UpdateData(
                table: "Book",
                keyColumn: "BookId",
                keyValue: 1222,
                columns: new[] { "CreatedDateTime", "PublicationDate" },
                values: new object[] { new DateTime(2024, 8, 16, 16, 32, 4, 674, DateTimeKind.Utc).AddTicks(4758), new DateTime(2024, 5, 9, 6, 21, 14, 30, DateTimeKind.Local).AddTicks(443) });

            migrationBuilder.UpdateData(
                table: "Book",
                keyColumn: "BookId",
                keyValue: 1223,
                columns: new[] { "CreatedDateTime", "PublicationDate" },
                values: new object[] { new DateTime(2024, 8, 16, 16, 32, 4, 674, DateTimeKind.Utc).AddTicks(4863), new DateTime(2023, 9, 21, 2, 16, 5, 918, DateTimeKind.Local).AddTicks(350) });

            migrationBuilder.UpdateData(
                table: "Book",
                keyColumn: "BookId",
                keyValue: 1224,
                columns: new[] { "CreatedDateTime", "PublicationDate" },
                values: new object[] { new DateTime(2024, 8, 16, 16, 32, 4, 674, DateTimeKind.Utc).AddTicks(4987), new DateTime(2023, 11, 20, 12, 46, 26, 353, DateTimeKind.Local).AddTicks(3572) });

            migrationBuilder.UpdateData(
                table: "Book",
                keyColumn: "BookId",
                keyValue: 1225,
                columns: new[] { "CreatedDateTime", "PublicationDate" },
                values: new object[] { new DateTime(2024, 8, 16, 16, 32, 4, 674, DateTimeKind.Utc).AddTicks(5086), new DateTime(2024, 7, 10, 1, 52, 52, 976, DateTimeKind.Local).AddTicks(7095) });

            migrationBuilder.UpdateData(
                table: "Book",
                keyColumn: "BookId",
                keyValue: 1226,
                columns: new[] { "CreatedDateTime", "PublicationDate" },
                values: new object[] { new DateTime(2024, 8, 16, 16, 32, 4, 674, DateTimeKind.Utc).AddTicks(5223), new DateTime(2024, 3, 16, 6, 30, 18, 330, DateTimeKind.Local).AddTicks(5789) });

            migrationBuilder.UpdateData(
                table: "Book",
                keyColumn: "BookId",
                keyValue: 1227,
                columns: new[] { "CreatedDateTime", "PublicationDate" },
                values: new object[] { new DateTime(2024, 8, 16, 16, 32, 4, 674, DateTimeKind.Utc).AddTicks(5331), new DateTime(2024, 3, 14, 1, 44, 37, 185, DateTimeKind.Local).AddTicks(2575) });

            migrationBuilder.UpdateData(
                table: "Book",
                keyColumn: "BookId",
                keyValue: 1228,
                columns: new[] { "CreatedDateTime", "PublicationDate" },
                values: new object[] { new DateTime(2024, 8, 16, 16, 32, 4, 674, DateTimeKind.Utc).AddTicks(5473), new DateTime(2023, 12, 30, 19, 28, 18, 674, DateTimeKind.Local).AddTicks(6125) });

            migrationBuilder.UpdateData(
                table: "Book",
                keyColumn: "BookId",
                keyValue: 1229,
                columns: new[] { "CreatedDateTime", "PublicationDate" },
                values: new object[] { new DateTime(2024, 8, 16, 16, 32, 4, 674, DateTimeKind.Utc).AddTicks(5603), new DateTime(2023, 10, 8, 5, 30, 19, 436, DateTimeKind.Local).AddTicks(3559) });

            migrationBuilder.UpdateData(
                table: "Book",
                keyColumn: "BookId",
                keyValue: 1230,
                columns: new[] { "CreatedDateTime", "PublicationDate" },
                values: new object[] { new DateTime(2024, 8, 16, 16, 32, 4, 674, DateTimeKind.Utc).AddTicks(5711), new DateTime(2023, 9, 18, 6, 52, 19, 700, DateTimeKind.Local).AddTicks(8885) });

            migrationBuilder.UpdateData(
                table: "Book",
                keyColumn: "BookId",
                keyValue: 1231,
                columns: new[] { "CreatedDateTime", "PublicationDate" },
                values: new object[] { new DateTime(2024, 8, 16, 16, 32, 4, 674, DateTimeKind.Utc).AddTicks(5825), new DateTime(2024, 3, 22, 14, 24, 31, 271, DateTimeKind.Local).AddTicks(7950) });

            migrationBuilder.UpdateData(
                table: "Book",
                keyColumn: "BookId",
                keyValue: 1232,
                columns: new[] { "CreatedDateTime", "PublicationDate" },
                values: new object[] { new DateTime(2024, 8, 16, 16, 32, 4, 674, DateTimeKind.Utc).AddTicks(5925), new DateTime(2024, 4, 18, 21, 42, 15, 752, DateTimeKind.Local).AddTicks(494) });

            migrationBuilder.UpdateData(
                table: "Book",
                keyColumn: "BookId",
                keyValue: 1233,
                columns: new[] { "CreatedDateTime", "PublicationDate" },
                values: new object[] { new DateTime(2024, 8, 16, 16, 32, 4, 674, DateTimeKind.Utc).AddTicks(6058), new DateTime(2024, 4, 4, 4, 32, 15, 278, DateTimeKind.Local).AddTicks(6325) });

            migrationBuilder.UpdateData(
                table: "Book",
                keyColumn: "BookId",
                keyValue: 1234,
                columns: new[] { "CreatedDateTime", "PublicationDate" },
                values: new object[] { new DateTime(2024, 8, 16, 16, 32, 4, 674, DateTimeKind.Utc).AddTicks(6155), new DateTime(2024, 7, 28, 0, 32, 55, 393, DateTimeKind.Local).AddTicks(6626) });

            migrationBuilder.UpdateData(
                table: "Book",
                keyColumn: "BookId",
                keyValue: 1235,
                columns: new[] { "CreatedDateTime", "PublicationDate" },
                values: new object[] { new DateTime(2024, 8, 16, 16, 32, 4, 674, DateTimeKind.Utc).AddTicks(6282), new DateTime(2023, 9, 17, 9, 28, 43, 219, DateTimeKind.Local).AddTicks(4359) });

            migrationBuilder.UpdateData(
                table: "Book",
                keyColumn: "BookId",
                keyValue: 1236,
                columns: new[] { "CreatedDateTime", "PublicationDate" },
                values: new object[] { new DateTime(2024, 8, 16, 16, 32, 4, 674, DateTimeKind.Utc).AddTicks(6374), new DateTime(2023, 10, 5, 16, 13, 57, 976, DateTimeKind.Local).AddTicks(8899) });

            migrationBuilder.UpdateData(
                table: "Book",
                keyColumn: "BookId",
                keyValue: 1237,
                columns: new[] { "CreatedDateTime", "PublicationDate" },
                values: new object[] { new DateTime(2024, 8, 16, 16, 32, 4, 674, DateTimeKind.Utc).AddTicks(6489), new DateTime(2024, 5, 28, 19, 6, 30, 936, DateTimeKind.Local).AddTicks(4833) });

            migrationBuilder.UpdateData(
                table: "Book",
                keyColumn: "BookId",
                keyValue: 1238,
                columns: new[] { "CreatedDateTime", "PublicationDate" },
                values: new object[] { new DateTime(2024, 8, 16, 16, 32, 4, 674, DateTimeKind.Utc).AddTicks(6588), new DateTime(2024, 2, 8, 10, 49, 56, 952, DateTimeKind.Local).AddTicks(1163) });

            migrationBuilder.UpdateData(
                table: "Book",
                keyColumn: "BookId",
                keyValue: 1239,
                columns: new[] { "CreatedDateTime", "PublicationDate" },
                values: new object[] { new DateTime(2024, 8, 16, 16, 32, 4, 674, DateTimeKind.Utc).AddTicks(6718), new DateTime(2023, 10, 3, 17, 48, 19, 796, DateTimeKind.Local).AddTicks(3898) });

            migrationBuilder.UpdateData(
                table: "Book",
                keyColumn: "BookId",
                keyValue: 1240,
                columns: new[] { "CreatedDateTime", "PublicationDate" },
                values: new object[] { new DateTime(2024, 8, 16, 16, 32, 4, 674, DateTimeKind.Utc).AddTicks(6828), new DateTime(2024, 8, 14, 14, 54, 0, 601, DateTimeKind.Local).AddTicks(3090) });

            migrationBuilder.UpdateData(
                table: "Book",
                keyColumn: "BookId",
                keyValue: 1241,
                columns: new[] { "CreatedDateTime", "PublicationDate" },
                values: new object[] { new DateTime(2024, 8, 16, 16, 32, 4, 674, DateTimeKind.Utc).AddTicks(6963), new DateTime(2023, 10, 19, 14, 49, 4, 320, DateTimeKind.Local).AddTicks(9701) });

            migrationBuilder.UpdateData(
                table: "Book",
                keyColumn: "BookId",
                keyValue: 1242,
                columns: new[] { "CreatedDateTime", "PublicationDate" },
                values: new object[] { new DateTime(2024, 8, 16, 16, 32, 4, 674, DateTimeKind.Utc).AddTicks(7055), new DateTime(2024, 4, 27, 0, 18, 40, 464, DateTimeKind.Local).AddTicks(4932) });

            migrationBuilder.UpdateData(
                table: "Book",
                keyColumn: "BookId",
                keyValue: 1243,
                columns: new[] { "CreatedDateTime", "PublicationDate" },
                values: new object[] { new DateTime(2024, 8, 16, 16, 32, 4, 674, DateTimeKind.Utc).AddTicks(7188), new DateTime(2024, 7, 19, 13, 55, 24, 91, DateTimeKind.Local).AddTicks(8273) });

            migrationBuilder.UpdateData(
                table: "Book",
                keyColumn: "BookId",
                keyValue: 1244,
                columns: new[] { "CreatedDateTime", "PublicationDate" },
                values: new object[] { new DateTime(2024, 8, 16, 16, 32, 4, 674, DateTimeKind.Utc).AddTicks(7283), new DateTime(2024, 5, 20, 17, 19, 27, 458, DateTimeKind.Local).AddTicks(1464) });

            migrationBuilder.UpdateData(
                table: "Book",
                keyColumn: "BookId",
                keyValue: 1245,
                columns: new[] { "CreatedDateTime", "PublicationDate" },
                values: new object[] { new DateTime(2024, 8, 16, 16, 32, 4, 674, DateTimeKind.Utc).AddTicks(7408), new DateTime(2024, 8, 7, 16, 4, 19, 181, DateTimeKind.Local).AddTicks(578) });

            migrationBuilder.UpdateData(
                table: "Book",
                keyColumn: "BookId",
                keyValue: 1246,
                columns: new[] { "CreatedDateTime", "PublicationDate" },
                values: new object[] { new DateTime(2024, 8, 16, 16, 32, 4, 674, DateTimeKind.Utc).AddTicks(7497), new DateTime(2024, 1, 26, 3, 50, 28, 165, DateTimeKind.Local).AddTicks(6413) });

            migrationBuilder.UpdateData(
                table: "Book",
                keyColumn: "BookId",
                keyValue: 1247,
                columns: new[] { "CreatedDateTime", "PublicationDate" },
                values: new object[] { new DateTime(2024, 8, 16, 16, 32, 4, 674, DateTimeKind.Utc).AddTicks(7619), new DateTime(2024, 5, 7, 12, 39, 49, 516, DateTimeKind.Local).AddTicks(6257) });

            migrationBuilder.UpdateData(
                table: "Book",
                keyColumn: "BookId",
                keyValue: 1248,
                columns: new[] { "CreatedDateTime", "PublicationDate" },
                values: new object[] { new DateTime(2024, 8, 16, 16, 32, 4, 674, DateTimeKind.Utc).AddTicks(7720), new DateTime(2024, 5, 3, 20, 24, 43, 448, DateTimeKind.Local).AddTicks(7970) });

            migrationBuilder.UpdateData(
                table: "Book",
                keyColumn: "BookId",
                keyValue: 1249,
                columns: new[] { "CreatedDateTime", "PublicationDate" },
                values: new object[] { new DateTime(2024, 8, 16, 16, 32, 4, 674, DateTimeKind.Utc).AddTicks(7845), new DateTime(2023, 8, 18, 9, 27, 22, 373, DateTimeKind.Local).AddTicks(9238) });

            migrationBuilder.UpdateData(
                table: "Book",
                keyColumn: "BookId",
                keyValue: 1250,
                columns: new[] { "CreatedDateTime", "PublicationDate" },
                values: new object[] { new DateTime(2024, 8, 16, 16, 32, 4, 674, DateTimeKind.Utc).AddTicks(7941), new DateTime(2023, 12, 26, 5, 56, 3, 33, DateTimeKind.Local).AddTicks(4933) });

            migrationBuilder.UpdateData(
                table: "Book",
                keyColumn: "BookId",
                keyValue: 1251,
                columns: new[] { "CreatedDateTime", "PublicationDate" },
                values: new object[] { new DateTime(2024, 8, 16, 16, 32, 4, 674, DateTimeKind.Utc).AddTicks(8099), new DateTime(2023, 9, 11, 3, 52, 42, 714, DateTimeKind.Local).AddTicks(1139) });

            migrationBuilder.UpdateData(
                table: "Book",
                keyColumn: "BookId",
                keyValue: 1252,
                columns: new[] { "CreatedDateTime", "PublicationDate" },
                values: new object[] { new DateTime(2024, 8, 16, 16, 32, 4, 674, DateTimeKind.Utc).AddTicks(8192), new DateTime(2023, 12, 9, 22, 33, 56, 836, DateTimeKind.Local).AddTicks(4452) });

            migrationBuilder.UpdateData(
                table: "Book",
                keyColumn: "BookId",
                keyValue: 1253,
                columns: new[] { "CreatedDateTime", "PublicationDate" },
                values: new object[] { new DateTime(2024, 8, 16, 16, 32, 4, 674, DateTimeKind.Utc).AddTicks(8320), new DateTime(2023, 10, 6, 14, 2, 18, 329, DateTimeKind.Local).AddTicks(8463) });

            migrationBuilder.UpdateData(
                table: "Book",
                keyColumn: "BookId",
                keyValue: 1254,
                columns: new[] { "CreatedDateTime", "PublicationDate" },
                values: new object[] { new DateTime(2024, 8, 16, 16, 32, 4, 674, DateTimeKind.Utc).AddTicks(8409), new DateTime(2024, 3, 10, 10, 26, 55, 725, DateTimeKind.Local).AddTicks(2336) });

            migrationBuilder.UpdateData(
                table: "Book",
                keyColumn: "BookId",
                keyValue: 1255,
                columns: new[] { "CreatedDateTime", "PublicationDate" },
                values: new object[] { new DateTime(2024, 8, 16, 16, 32, 4, 674, DateTimeKind.Utc).AddTicks(8549), new DateTime(2023, 10, 22, 23, 2, 19, 505, DateTimeKind.Local).AddTicks(5779) });

            migrationBuilder.UpdateData(
                table: "Book",
                keyColumn: "BookId",
                keyValue: 1256,
                columns: new[] { "CreatedDateTime", "PublicationDate" },
                values: new object[] { new DateTime(2024, 8, 16, 16, 32, 4, 674, DateTimeKind.Utc).AddTicks(8647), new DateTime(2024, 6, 20, 6, 45, 33, 153, DateTimeKind.Local).AddTicks(4815) });

            migrationBuilder.UpdateData(
                table: "Book",
                keyColumn: "BookId",
                keyValue: 1257,
                columns: new[] { "CreatedDateTime", "PublicationDate" },
                values: new object[] { new DateTime(2024, 8, 16, 16, 32, 4, 674, DateTimeKind.Utc).AddTicks(8777), new DateTime(2023, 11, 13, 3, 23, 50, 581, DateTimeKind.Local).AddTicks(5176) });

            migrationBuilder.UpdateData(
                table: "Book",
                keyColumn: "BookId",
                keyValue: 1258,
                columns: new[] { "CreatedDateTime", "PublicationDate" },
                values: new object[] { new DateTime(2024, 8, 16, 16, 32, 4, 674, DateTimeKind.Utc).AddTicks(8926), new DateTime(2024, 8, 6, 3, 11, 16, 43, DateTimeKind.Local).AddTicks(7970) });

            migrationBuilder.UpdateData(
                table: "Book",
                keyColumn: "BookId",
                keyValue: 1259,
                columns: new[] { "CreatedDateTime", "PublicationDate" },
                values: new object[] { new DateTime(2024, 8, 16, 16, 32, 4, 674, DateTimeKind.Utc).AddTicks(9022), new DateTime(2024, 1, 22, 19, 32, 38, 942, DateTimeKind.Local).AddTicks(9977) });

            migrationBuilder.UpdateData(
                table: "Book",
                keyColumn: "BookId",
                keyValue: 1260,
                columns: new[] { "CreatedDateTime", "PublicationDate" },
                values: new object[] { new DateTime(2024, 8, 16, 16, 32, 4, 674, DateTimeKind.Utc).AddTicks(9142), new DateTime(2024, 4, 30, 7, 42, 4, 611, DateTimeKind.Local).AddTicks(1753) });

            migrationBuilder.UpdateData(
                table: "Book",
                keyColumn: "BookId",
                keyValue: 1261,
                columns: new[] { "CreatedDateTime", "PublicationDate" },
                values: new object[] { new DateTime(2024, 8, 16, 16, 32, 4, 674, DateTimeKind.Utc).AddTicks(9243), new DateTime(2024, 2, 6, 23, 56, 28, 524, DateTimeKind.Local).AddTicks(6388) });

            migrationBuilder.UpdateData(
                table: "Book",
                keyColumn: "BookId",
                keyValue: 1262,
                columns: new[] { "CreatedDateTime", "PublicationDate" },
                values: new object[] { new DateTime(2024, 8, 16, 16, 32, 4, 674, DateTimeKind.Utc).AddTicks(9363), new DateTime(2024, 6, 15, 21, 18, 56, 269, DateTimeKind.Local).AddTicks(1773) });

            migrationBuilder.UpdateData(
                table: "Book",
                keyColumn: "BookId",
                keyValue: 1263,
                columns: new[] { "CreatedDateTime", "PublicationDate" },
                values: new object[] { new DateTime(2024, 8, 16, 16, 32, 4, 674, DateTimeKind.Utc).AddTicks(9473), new DateTime(2023, 9, 14, 0, 48, 2, 126, DateTimeKind.Local).AddTicks(5541) });

            migrationBuilder.UpdateData(
                table: "Book",
                keyColumn: "BookId",
                keyValue: 1264,
                columns: new[] { "CreatedDateTime", "PublicationDate" },
                values: new object[] { new DateTime(2024, 8, 16, 16, 32, 4, 674, DateTimeKind.Utc).AddTicks(9601), new DateTime(2024, 2, 29, 19, 16, 56, 448, DateTimeKind.Local).AddTicks(1463) });

            migrationBuilder.UpdateData(
                table: "Book",
                keyColumn: "BookId",
                keyValue: 1265,
                columns: new[] { "CreatedDateTime", "PublicationDate" },
                values: new object[] { new DateTime(2024, 8, 16, 16, 32, 4, 674, DateTimeKind.Utc).AddTicks(9687), new DateTime(2024, 8, 10, 3, 46, 18, 590, DateTimeKind.Local).AddTicks(4297) });

            migrationBuilder.UpdateData(
                table: "Book",
                keyColumn: "BookId",
                keyValue: 1266,
                columns: new[] { "CreatedDateTime", "PublicationDate" },
                values: new object[] { new DateTime(2024, 8, 16, 16, 32, 4, 674, DateTimeKind.Utc).AddTicks(9820), new DateTime(2024, 6, 3, 0, 55, 26, 431, DateTimeKind.Local).AddTicks(2772) });

            migrationBuilder.UpdateData(
                table: "Book",
                keyColumn: "BookId",
                keyValue: 1267,
                columns: new[] { "CreatedDateTime", "PublicationDate" },
                values: new object[] { new DateTime(2024, 8, 16, 16, 32, 4, 674, DateTimeKind.Utc).AddTicks(9918), new DateTime(2024, 8, 5, 8, 51, 24, 989, DateTimeKind.Local).AddTicks(3753) });

            migrationBuilder.UpdateData(
                table: "Book",
                keyColumn: "BookId",
                keyValue: 1268,
                columns: new[] { "CreatedDateTime", "PublicationDate" },
                values: new object[] { new DateTime(2024, 8, 16, 16, 32, 4, 675, DateTimeKind.Utc).AddTicks(42), new DateTime(2024, 1, 12, 6, 51, 37, 566, DateTimeKind.Local).AddTicks(5275) });

            migrationBuilder.UpdateData(
                table: "Book",
                keyColumn: "BookId",
                keyValue: 1269,
                columns: new[] { "CreatedDateTime", "PublicationDate" },
                values: new object[] { new DateTime(2024, 8, 16, 16, 32, 4, 675, DateTimeKind.Utc).AddTicks(136), new DateTime(2024, 2, 20, 22, 18, 45, 867, DateTimeKind.Local).AddTicks(9733) });

            migrationBuilder.UpdateData(
                table: "Book",
                keyColumn: "BookId",
                keyValue: 1270,
                columns: new[] { "CreatedDateTime", "PublicationDate" },
                values: new object[] { new DateTime(2024, 8, 16, 16, 32, 4, 675, DateTimeKind.Utc).AddTicks(261), new DateTime(2024, 1, 2, 13, 14, 49, 672, DateTimeKind.Local).AddTicks(647) });

            migrationBuilder.UpdateData(
                table: "Book",
                keyColumn: "BookId",
                keyValue: 1271,
                columns: new[] { "CreatedDateTime", "PublicationDate" },
                values: new object[] { new DateTime(2024, 8, 16, 16, 32, 4, 675, DateTimeKind.Utc).AddTicks(352), new DateTime(2023, 10, 24, 14, 27, 42, 845, DateTimeKind.Local).AddTicks(3823) });

            migrationBuilder.UpdateData(
                table: "Book",
                keyColumn: "BookId",
                keyValue: 1272,
                columns: new[] { "CreatedDateTime", "PublicationDate" },
                values: new object[] { new DateTime(2024, 8, 16, 16, 32, 4, 675, DateTimeKind.Utc).AddTicks(486), new DateTime(2023, 11, 2, 0, 12, 6, 717, DateTimeKind.Local).AddTicks(6621) });

            migrationBuilder.UpdateData(
                table: "Book",
                keyColumn: "BookId",
                keyValue: 1273,
                columns: new[] { "CreatedDateTime", "PublicationDate" },
                values: new object[] { new DateTime(2024, 8, 16, 16, 32, 4, 675, DateTimeKind.Utc).AddTicks(580), new DateTime(2024, 1, 21, 4, 20, 5, 325, DateTimeKind.Local).AddTicks(8554) });

            migrationBuilder.UpdateData(
                table: "Book",
                keyColumn: "BookId",
                keyValue: 1274,
                columns: new[] { "CreatedDateTime", "PublicationDate" },
                values: new object[] { new DateTime(2024, 8, 16, 16, 32, 4, 675, DateTimeKind.Utc).AddTicks(713), new DateTime(2023, 10, 11, 5, 57, 3, 99, DateTimeKind.Local).AddTicks(184) });

            migrationBuilder.UpdateData(
                table: "Book",
                keyColumn: "BookId",
                keyValue: 1275,
                columns: new[] { "CreatedDateTime", "PublicationDate" },
                values: new object[] { new DateTime(2024, 8, 16, 16, 32, 4, 675, DateTimeKind.Utc).AddTicks(801), new DateTime(2024, 7, 27, 19, 0, 8, 497, DateTimeKind.Local).AddTicks(9531) });

            migrationBuilder.UpdateData(
                table: "Book",
                keyColumn: "BookId",
                keyValue: 1276,
                columns: new[] { "CreatedDateTime", "PublicationDate" },
                values: new object[] { new DateTime(2024, 8, 16, 16, 32, 4, 675, DateTimeKind.Utc).AddTicks(924), new DateTime(2024, 2, 7, 18, 0, 56, 271, DateTimeKind.Local).AddTicks(8470) });

            migrationBuilder.UpdateData(
                table: "Book",
                keyColumn: "BookId",
                keyValue: 1277,
                columns: new[] { "CreatedDateTime", "PublicationDate" },
                values: new object[] { new DateTime(2024, 8, 16, 16, 32, 4, 675, DateTimeKind.Utc).AddTicks(1037), new DateTime(2023, 12, 9, 9, 30, 25, 418, DateTimeKind.Local).AddTicks(7952) });

            migrationBuilder.UpdateData(
                table: "Book",
                keyColumn: "BookId",
                keyValue: 1278,
                columns: new[] { "CreatedDateTime", "PublicationDate" },
                values: new object[] { new DateTime(2024, 8, 16, 16, 32, 4, 675, DateTimeKind.Utc).AddTicks(1143), new DateTime(2024, 2, 4, 1, 33, 28, 474, DateTimeKind.Local).AddTicks(5544) });

            migrationBuilder.UpdateData(
                table: "Book",
                keyColumn: "BookId",
                keyValue: 1279,
                columns: new[] { "CreatedDateTime", "PublicationDate" },
                values: new object[] { new DateTime(2024, 8, 16, 16, 32, 4, 675, DateTimeKind.Utc).AddTicks(1239), new DateTime(2023, 10, 1, 20, 7, 36, 572, DateTimeKind.Local).AddTicks(1208) });

            migrationBuilder.UpdateData(
                table: "Book",
                keyColumn: "BookId",
                keyValue: 1280,
                columns: new[] { "CreatedDateTime", "PublicationDate" },
                values: new object[] { new DateTime(2024, 8, 16, 16, 32, 4, 675, DateTimeKind.Utc).AddTicks(1381), new DateTime(2023, 8, 24, 8, 35, 44, 313, DateTimeKind.Local).AddTicks(3494) });

            migrationBuilder.UpdateData(
                table: "Book",
                keyColumn: "BookId",
                keyValue: 1281,
                columns: new[] { "CreatedDateTime", "PublicationDate" },
                values: new object[] { new DateTime(2024, 8, 16, 16, 32, 4, 675, DateTimeKind.Utc).AddTicks(1480), new DateTime(2024, 5, 29, 16, 16, 56, 918, DateTimeKind.Local).AddTicks(7396) });

            migrationBuilder.UpdateData(
                table: "Book",
                keyColumn: "BookId",
                keyValue: 1282,
                columns: new[] { "CreatedDateTime", "PublicationDate" },
                values: new object[] { new DateTime(2024, 8, 16, 16, 32, 4, 675, DateTimeKind.Utc).AddTicks(1614), new DateTime(2024, 1, 30, 10, 26, 8, 800, DateTimeKind.Local).AddTicks(9204) });

            migrationBuilder.UpdateData(
                table: "Book",
                keyColumn: "BookId",
                keyValue: 1283,
                columns: new[] { "CreatedDateTime", "PublicationDate" },
                values: new object[] { new DateTime(2024, 8, 16, 16, 32, 4, 675, DateTimeKind.Utc).AddTicks(1714), new DateTime(2023, 11, 26, 4, 48, 54, 18, DateTimeKind.Local).AddTicks(6641) });

            migrationBuilder.UpdateData(
                table: "Book",
                keyColumn: "BookId",
                keyValue: 1284,
                columns: new[] { "CreatedDateTime", "PublicationDate" },
                values: new object[] { new DateTime(2024, 8, 16, 16, 32, 4, 675, DateTimeKind.Utc).AddTicks(1838), new DateTime(2023, 11, 1, 11, 26, 15, 714, DateTimeKind.Local).AddTicks(8751) });

            migrationBuilder.UpdateData(
                table: "Book",
                keyColumn: "BookId",
                keyValue: 1285,
                columns: new[] { "CreatedDateTime", "PublicationDate" },
                values: new object[] { new DateTime(2024, 8, 16, 16, 32, 4, 675, DateTimeKind.Utc).AddTicks(1972), new DateTime(2024, 4, 4, 17, 23, 28, 545, DateTimeKind.Local).AddTicks(9391) });

            migrationBuilder.UpdateData(
                table: "Book",
                keyColumn: "BookId",
                keyValue: 1286,
                columns: new[] { "CreatedDateTime", "PublicationDate" },
                values: new object[] { new DateTime(2024, 8, 16, 16, 32, 4, 675, DateTimeKind.Utc).AddTicks(2066), new DateTime(2024, 8, 14, 2, 43, 40, 456, DateTimeKind.Local).AddTicks(8727) });

            migrationBuilder.UpdateData(
                table: "Book",
                keyColumn: "BookId",
                keyValue: 1287,
                columns: new[] { "CreatedDateTime", "PublicationDate" },
                values: new object[] { new DateTime(2024, 8, 16, 16, 32, 4, 675, DateTimeKind.Utc).AddTicks(2195), new DateTime(2024, 4, 24, 3, 49, 39, 917, DateTimeKind.Local).AddTicks(436) });

            migrationBuilder.UpdateData(
                table: "Book",
                keyColumn: "BookId",
                keyValue: 1288,
                columns: new[] { "CreatedDateTime", "PublicationDate" },
                values: new object[] { new DateTime(2024, 8, 16, 16, 32, 4, 675, DateTimeKind.Utc).AddTicks(2286), new DateTime(2023, 9, 8, 3, 33, 12, 212, DateTimeKind.Local).AddTicks(6129) });

            migrationBuilder.UpdateData(
                table: "Book",
                keyColumn: "BookId",
                keyValue: 1289,
                columns: new[] { "CreatedDateTime", "PublicationDate" },
                values: new object[] { new DateTime(2024, 8, 16, 16, 32, 4, 675, DateTimeKind.Utc).AddTicks(2402), new DateTime(2023, 8, 20, 7, 19, 25, 968, DateTimeKind.Local).AddTicks(1350) });

            migrationBuilder.UpdateData(
                table: "Book",
                keyColumn: "BookId",
                keyValue: 1290,
                columns: new[] { "CreatedDateTime", "PublicationDate" },
                values: new object[] { new DateTime(2024, 8, 16, 16, 32, 4, 675, DateTimeKind.Utc).AddTicks(2495), new DateTime(2023, 9, 11, 4, 16, 56, 663, DateTimeKind.Local).AddTicks(9403) });

            migrationBuilder.UpdateData(
                table: "Book",
                keyColumn: "BookId",
                keyValue: 1291,
                columns: new[] { "CreatedDateTime", "PublicationDate" },
                values: new object[] { new DateTime(2024, 8, 16, 16, 32, 4, 675, DateTimeKind.Utc).AddTicks(2592), new DateTime(2024, 5, 23, 16, 32, 42, 372, DateTimeKind.Local).AddTicks(5030) });

            migrationBuilder.UpdateData(
                table: "Book",
                keyColumn: "BookId",
                keyValue: 1292,
                columns: new[] { "CreatedDateTime", "PublicationDate" },
                values: new object[] { new DateTime(2024, 8, 16, 16, 32, 4, 675, DateTimeKind.Utc).AddTicks(2717), new DateTime(2024, 3, 6, 9, 14, 38, 227, DateTimeKind.Local).AddTicks(8016) });

            migrationBuilder.UpdateData(
                table: "Book",
                keyColumn: "BookId",
                keyValue: 1293,
                columns: new[] { "CreatedDateTime", "PublicationDate" },
                values: new object[] { new DateTime(2024, 8, 16, 16, 32, 4, 675, DateTimeKind.Utc).AddTicks(2818), new DateTime(2024, 7, 9, 6, 45, 4, 903, DateTimeKind.Local).AddTicks(1954) });

            migrationBuilder.UpdateData(
                table: "Book",
                keyColumn: "BookId",
                keyValue: 1294,
                columns: new[] { "CreatedDateTime", "PublicationDate" },
                values: new object[] { new DateTime(2024, 8, 16, 16, 32, 4, 675, DateTimeKind.Utc).AddTicks(2932), new DateTime(2023, 11, 14, 3, 13, 3, 202, DateTimeKind.Local).AddTicks(6588) });

            migrationBuilder.UpdateData(
                table: "Book",
                keyColumn: "BookId",
                keyValue: 1295,
                columns: new[] { "CreatedDateTime", "PublicationDate" },
                values: new object[] { new DateTime(2024, 8, 16, 16, 32, 4, 675, DateTimeKind.Utc).AddTicks(3026), new DateTime(2023, 11, 2, 7, 50, 22, 55, DateTimeKind.Local).AddTicks(5795) });

            migrationBuilder.UpdateData(
                table: "Book",
                keyColumn: "BookId",
                keyValue: 1296,
                columns: new[] { "CreatedDateTime", "PublicationDate" },
                values: new object[] { new DateTime(2024, 8, 16, 16, 32, 4, 675, DateTimeKind.Utc).AddTicks(3153), new DateTime(2024, 6, 8, 1, 48, 9, 486, DateTimeKind.Local).AddTicks(5537) });

            migrationBuilder.UpdateData(
                table: "Book",
                keyColumn: "BookId",
                keyValue: 1297,
                columns: new[] { "CreatedDateTime", "PublicationDate" },
                values: new object[] { new DateTime(2024, 8, 16, 16, 32, 4, 675, DateTimeKind.Utc).AddTicks(3250), new DateTime(2023, 10, 8, 21, 34, 11, 717, DateTimeKind.Local).AddTicks(7938) });

            migrationBuilder.UpdateData(
                table: "Book",
                keyColumn: "BookId",
                keyValue: 1298,
                columns: new[] { "CreatedDateTime", "PublicationDate" },
                values: new object[] { new DateTime(2024, 8, 16, 16, 32, 4, 675, DateTimeKind.Utc).AddTicks(3403), new DateTime(2024, 4, 5, 20, 3, 44, 852, DateTimeKind.Local).AddTicks(6076) });

            migrationBuilder.UpdateData(
                table: "Book",
                keyColumn: "BookId",
                keyValue: 1299,
                columns: new[] { "CreatedDateTime", "PublicationDate" },
                values: new object[] { new DateTime(2024, 8, 16, 16, 32, 4, 675, DateTimeKind.Utc).AddTicks(3524), new DateTime(2024, 3, 14, 10, 18, 48, 278, DateTimeKind.Local).AddTicks(6165) });

            migrationBuilder.UpdateData(
                table: "Book",
                keyColumn: "BookId",
                keyValue: 1300,
                columns: new[] { "CreatedDateTime", "PublicationDate" },
                values: new object[] { new DateTime(2024, 8, 16, 16, 32, 4, 675, DateTimeKind.Utc).AddTicks(3625), new DateTime(2023, 10, 25, 11, 48, 16, 453, DateTimeKind.Local).AddTicks(3734) });

            migrationBuilder.UpdateData(
                table: "Book",
                keyColumn: "BookId",
                keyValue: 1301,
                columns: new[] { "CreatedDateTime", "PublicationDate" },
                values: new object[] { new DateTime(2024, 8, 16, 16, 32, 4, 675, DateTimeKind.Utc).AddTicks(3744), new DateTime(2024, 5, 9, 12, 10, 3, 168, DateTimeKind.Local).AddTicks(3664) });

            migrationBuilder.UpdateData(
                table: "Book",
                keyColumn: "BookId",
                keyValue: 1302,
                columns: new[] { "CreatedDateTime", "PublicationDate" },
                values: new object[] { new DateTime(2024, 8, 16, 16, 32, 4, 675, DateTimeKind.Utc).AddTicks(3837), new DateTime(2024, 5, 31, 3, 3, 8, 505, DateTimeKind.Local).AddTicks(1496) });

            migrationBuilder.UpdateData(
                table: "Book",
                keyColumn: "BookId",
                keyValue: 1303,
                columns: new[] { "CreatedDateTime", "PublicationDate" },
                values: new object[] { new DateTime(2024, 8, 16, 16, 32, 4, 675, DateTimeKind.Utc).AddTicks(3952), new DateTime(2023, 10, 2, 15, 53, 18, 178, DateTimeKind.Local).AddTicks(3370) });

            migrationBuilder.UpdateData(
                table: "Book",
                keyColumn: "BookId",
                keyValue: 1304,
                columns: new[] { "CreatedDateTime", "PublicationDate" },
                values: new object[] { new DateTime(2024, 8, 16, 16, 32, 4, 675, DateTimeKind.Utc).AddTicks(4045), new DateTime(2024, 4, 23, 17, 23, 4, 65, DateTimeKind.Local).AddTicks(1292) });

            migrationBuilder.UpdateData(
                table: "Book",
                keyColumn: "BookId",
                keyValue: 1305,
                columns: new[] { "CreatedDateTime", "PublicationDate" },
                values: new object[] { new DateTime(2024, 8, 16, 16, 32, 4, 675, DateTimeKind.Utc).AddTicks(4171), new DateTime(2024, 4, 11, 15, 26, 34, 142, DateTimeKind.Local).AddTicks(1575) });

            migrationBuilder.UpdateData(
                table: "Book",
                keyColumn: "BookId",
                keyValue: 1306,
                columns: new[] { "CreatedDateTime", "PublicationDate" },
                values: new object[] { new DateTime(2024, 8, 16, 16, 32, 4, 675, DateTimeKind.Utc).AddTicks(4258), new DateTime(2024, 6, 16, 9, 49, 27, 219, DateTimeKind.Local).AddTicks(4005) });

            migrationBuilder.UpdateData(
                table: "Book",
                keyColumn: "BookId",
                keyValue: 1307,
                columns: new[] { "CreatedDateTime", "PublicationDate" },
                values: new object[] { new DateTime(2024, 8, 16, 16, 32, 4, 675, DateTimeKind.Utc).AddTicks(4346), new DateTime(2024, 3, 12, 2, 12, 9, 372, DateTimeKind.Local).AddTicks(5698) });

            migrationBuilder.UpdateData(
                table: "Book",
                keyColumn: "BookId",
                keyValue: 1308,
                columns: new[] { "CreatedDateTime", "PublicationDate" },
                values: new object[] { new DateTime(2024, 8, 16, 16, 32, 4, 675, DateTimeKind.Utc).AddTicks(4472), new DateTime(2024, 3, 25, 0, 20, 46, 68, DateTimeKind.Local).AddTicks(2955) });

            migrationBuilder.UpdateData(
                table: "Book",
                keyColumn: "BookId",
                keyValue: 1309,
                columns: new[] { "CreatedDateTime", "PublicationDate" },
                values: new object[] { new DateTime(2024, 8, 16, 16, 32, 4, 675, DateTimeKind.Utc).AddTicks(4605), new DateTime(2023, 9, 1, 3, 35, 37, 870, DateTimeKind.Local).AddTicks(317) });

            migrationBuilder.UpdateData(
                table: "Book",
                keyColumn: "BookId",
                keyValue: 1310,
                columns: new[] { "CreatedDateTime", "PublicationDate" },
                values: new object[] { new DateTime(2024, 8, 16, 16, 32, 4, 675, DateTimeKind.Utc).AddTicks(4703), new DateTime(2024, 3, 17, 3, 14, 1, 4, DateTimeKind.Local).AddTicks(8989) });

            migrationBuilder.UpdateData(
                table: "Book",
                keyColumn: "BookId",
                keyValue: 1311,
                columns: new[] { "CreatedDateTime", "PublicationDate" },
                values: new object[] { new DateTime(2024, 8, 16, 16, 32, 4, 675, DateTimeKind.Utc).AddTicks(4826), new DateTime(2024, 1, 19, 4, 3, 27, 616, DateTimeKind.Local).AddTicks(3778) });

            migrationBuilder.UpdateData(
                table: "Book",
                keyColumn: "BookId",
                keyValue: 1312,
                columns: new[] { "CreatedDateTime", "PublicationDate" },
                values: new object[] { new DateTime(2024, 8, 16, 16, 32, 4, 675, DateTimeKind.Utc).AddTicks(4911), new DateTime(2024, 3, 13, 17, 30, 34, 468, DateTimeKind.Local).AddTicks(7730) });

            migrationBuilder.UpdateData(
                table: "Book",
                keyColumn: "BookId",
                keyValue: 1313,
                columns: new[] { "CreatedDateTime", "PublicationDate" },
                values: new object[] { new DateTime(2024, 8, 16, 16, 32, 4, 675, DateTimeKind.Utc).AddTicks(5066), new DateTime(2023, 9, 11, 8, 9, 41, 678, DateTimeKind.Local).AddTicks(8611) });

            migrationBuilder.UpdateData(
                table: "Book",
                keyColumn: "BookId",
                keyValue: 1314,
                columns: new[] { "CreatedDateTime", "PublicationDate" },
                values: new object[] { new DateTime(2024, 8, 16, 16, 32, 4, 675, DateTimeKind.Utc).AddTicks(5160), new DateTime(2024, 7, 30, 11, 16, 50, 702, DateTimeKind.Local).AddTicks(8648) });

            migrationBuilder.UpdateData(
                table: "Book",
                keyColumn: "BookId",
                keyValue: 1315,
                columns: new[] { "CreatedDateTime", "PublicationDate" },
                values: new object[] { new DateTime(2024, 8, 16, 16, 32, 4, 675, DateTimeKind.Utc).AddTicks(5290), new DateTime(2024, 4, 13, 22, 11, 0, 623, DateTimeKind.Local).AddTicks(2529) });

            migrationBuilder.UpdateData(
                table: "Book",
                keyColumn: "BookId",
                keyValue: 1316,
                columns: new[] { "CreatedDateTime", "PublicationDate" },
                values: new object[] { new DateTime(2024, 8, 16, 16, 32, 4, 675, DateTimeKind.Utc).AddTicks(5395), new DateTime(2023, 12, 20, 13, 51, 32, 74, DateTimeKind.Local).AddTicks(4372) });

            migrationBuilder.UpdateData(
                table: "Book",
                keyColumn: "BookId",
                keyValue: 1317,
                columns: new[] { "CreatedDateTime", "PublicationDate" },
                values: new object[] { new DateTime(2024, 8, 16, 16, 32, 4, 675, DateTimeKind.Utc).AddTicks(5528), new DateTime(2024, 1, 28, 20, 50, 8, 39, DateTimeKind.Local).AddTicks(4986) });

            migrationBuilder.UpdateData(
                table: "Book",
                keyColumn: "BookId",
                keyValue: 1318,
                columns: new[] { "CreatedDateTime", "PublicationDate" },
                values: new object[] { new DateTime(2024, 8, 16, 16, 32, 4, 675, DateTimeKind.Utc).AddTicks(5651), new DateTime(2024, 3, 2, 5, 41, 9, 705, DateTimeKind.Local).AddTicks(8103) });

            migrationBuilder.UpdateData(
                table: "Book",
                keyColumn: "BookId",
                keyValue: 1319,
                columns: new[] { "CreatedDateTime", "PublicationDate" },
                values: new object[] { new DateTime(2024, 8, 16, 16, 32, 4, 675, DateTimeKind.Utc).AddTicks(5746), new DateTime(2023, 8, 27, 5, 20, 33, 909, DateTimeKind.Local).AddTicks(1016) });

            migrationBuilder.UpdateData(
                table: "Book",
                keyColumn: "BookId",
                keyValue: 1320,
                columns: new[] { "CreatedDateTime", "PublicationDate" },
                values: new object[] { new DateTime(2024, 8, 16, 16, 32, 4, 675, DateTimeKind.Utc).AddTicks(5832), new DateTime(2024, 4, 4, 1, 6, 22, 761, DateTimeKind.Local).AddTicks(9363) });

            migrationBuilder.UpdateData(
                table: "Book",
                keyColumn: "BookId",
                keyValue: 1321,
                columns: new[] { "CreatedDateTime", "PublicationDate" },
                values: new object[] { new DateTime(2024, 8, 16, 16, 32, 4, 675, DateTimeKind.Utc).AddTicks(5956), new DateTime(2024, 1, 24, 7, 17, 7, 456, DateTimeKind.Local).AddTicks(4678) });

            migrationBuilder.UpdateData(
                table: "Book",
                keyColumn: "BookId",
                keyValue: 1322,
                columns: new[] { "CreatedDateTime", "PublicationDate" },
                values: new object[] { new DateTime(2024, 8, 16, 16, 32, 4, 675, DateTimeKind.Utc).AddTicks(6051), new DateTime(2024, 2, 15, 19, 54, 45, 551, DateTimeKind.Local).AddTicks(3547) });

            migrationBuilder.UpdateData(
                table: "Book",
                keyColumn: "BookId",
                keyValue: 1323,
                columns: new[] { "CreatedDateTime", "PublicationDate" },
                values: new object[] { new DateTime(2024, 8, 16, 16, 32, 4, 675, DateTimeKind.Utc).AddTicks(6177), new DateTime(2024, 7, 8, 8, 8, 7, 227, DateTimeKind.Local).AddTicks(7854) });

            migrationBuilder.UpdateData(
                table: "Book",
                keyColumn: "BookId",
                keyValue: 1324,
                columns: new[] { "CreatedDateTime", "PublicationDate" },
                values: new object[] { new DateTime(2024, 8, 16, 16, 32, 4, 675, DateTimeKind.Utc).AddTicks(6277), new DateTime(2023, 10, 10, 18, 32, 23, 382, DateTimeKind.Local).AddTicks(2460) });

            migrationBuilder.UpdateData(
                table: "Book",
                keyColumn: "BookId",
                keyValue: 1325,
                columns: new[] { "CreatedDateTime", "PublicationDate" },
                values: new object[] { new DateTime(2024, 8, 16, 16, 32, 4, 675, DateTimeKind.Utc).AddTicks(6410), new DateTime(2024, 1, 18, 9, 23, 4, 538, DateTimeKind.Local).AddTicks(415) });

            migrationBuilder.UpdateData(
                table: "Book",
                keyColumn: "BookId",
                keyValue: 1326,
                columns: new[] { "CreatedDateTime", "PublicationDate" },
                values: new object[] { new DateTime(2024, 8, 16, 16, 32, 4, 675, DateTimeKind.Utc).AddTicks(6546), new DateTime(2023, 11, 1, 6, 49, 28, 520, DateTimeKind.Local).AddTicks(4438) });

            migrationBuilder.UpdateData(
                table: "Book",
                keyColumn: "BookId",
                keyValue: 1327,
                columns: new[] { "CreatedDateTime", "PublicationDate" },
                values: new object[] { new DateTime(2024, 8, 16, 16, 32, 4, 675, DateTimeKind.Utc).AddTicks(6650), new DateTime(2024, 4, 24, 12, 55, 56, 596, DateTimeKind.Local).AddTicks(9379) });

            migrationBuilder.UpdateData(
                table: "Book",
                keyColumn: "BookId",
                keyValue: 1328,
                columns: new[] { "CreatedDateTime", "PublicationDate" },
                values: new object[] { new DateTime(2024, 8, 16, 16, 32, 4, 675, DateTimeKind.Utc).AddTicks(6784), new DateTime(2024, 1, 28, 4, 52, 16, 43, DateTimeKind.Local).AddTicks(5403) });

            migrationBuilder.UpdateData(
                table: "Book",
                keyColumn: "BookId",
                keyValue: 1329,
                columns: new[] { "CreatedDateTime", "PublicationDate" },
                values: new object[] { new DateTime(2024, 8, 16, 16, 32, 4, 675, DateTimeKind.Utc).AddTicks(6878), new DateTime(2024, 5, 11, 6, 27, 56, 234, DateTimeKind.Local).AddTicks(1880) });

            migrationBuilder.UpdateData(
                table: "Book",
                keyColumn: "BookId",
                keyValue: 1330,
                columns: new[] { "CreatedDateTime", "PublicationDate" },
                values: new object[] { new DateTime(2024, 8, 16, 16, 32, 4, 675, DateTimeKind.Utc).AddTicks(7016), new DateTime(2024, 8, 7, 6, 32, 45, 116, DateTimeKind.Local).AddTicks(4764) });

            migrationBuilder.UpdateData(
                table: "Book",
                keyColumn: "BookId",
                keyValue: 1331,
                columns: new[] { "CreatedDateTime", "PublicationDate" },
                values: new object[] { new DateTime(2024, 8, 16, 16, 32, 4, 675, DateTimeKind.Utc).AddTicks(7104), new DateTime(2024, 2, 21, 13, 11, 4, 553, DateTimeKind.Local).AddTicks(725) });

            migrationBuilder.UpdateData(
                table: "Book",
                keyColumn: "BookId",
                keyValue: 1332,
                columns: new[] { "CreatedDateTime", "PublicationDate" },
                values: new object[] { new DateTime(2024, 8, 16, 16, 32, 4, 675, DateTimeKind.Utc).AddTicks(7234), new DateTime(2024, 8, 11, 3, 29, 6, 527, DateTimeKind.Local).AddTicks(4553) });

            migrationBuilder.UpdateData(
                table: "Book",
                keyColumn: "BookId",
                keyValue: 1333,
                columns: new[] { "CreatedDateTime", "PublicationDate" },
                values: new object[] { new DateTime(2024, 8, 16, 16, 32, 4, 675, DateTimeKind.Utc).AddTicks(7321), new DateTime(2024, 6, 17, 19, 36, 47, 230, DateTimeKind.Local).AddTicks(5956) });

            migrationBuilder.UpdateData(
                table: "Book",
                keyColumn: "BookId",
                keyValue: 1334,
                columns: new[] { "CreatedDateTime", "PublicationDate" },
                values: new object[] { new DateTime(2024, 8, 16, 16, 32, 4, 675, DateTimeKind.Utc).AddTicks(7453), new DateTime(2024, 5, 21, 4, 30, 30, 495, DateTimeKind.Local).AddTicks(1060) });

            migrationBuilder.UpdateData(
                table: "Book",
                keyColumn: "BookId",
                keyValue: 1335,
                columns: new[] { "CreatedDateTime", "PublicationDate" },
                values: new object[] { new DateTime(2024, 8, 16, 16, 32, 4, 675, DateTimeKind.Utc).AddTicks(7550), new DateTime(2024, 6, 13, 11, 53, 12, 215, DateTimeKind.Local).AddTicks(4322) });

            migrationBuilder.UpdateData(
                table: "Book",
                keyColumn: "BookId",
                keyValue: 1336,
                columns: new[] { "CreatedDateTime", "PublicationDate" },
                values: new object[] { new DateTime(2024, 8, 16, 16, 32, 4, 675, DateTimeKind.Utc).AddTicks(7677), new DateTime(2024, 3, 1, 17, 38, 31, 214, DateTimeKind.Local).AddTicks(7986) });

            migrationBuilder.UpdateData(
                table: "Book",
                keyColumn: "BookId",
                keyValue: 1337,
                columns: new[] { "CreatedDateTime", "PublicationDate" },
                values: new object[] { new DateTime(2024, 8, 16, 16, 32, 4, 675, DateTimeKind.Utc).AddTicks(7774), new DateTime(2023, 9, 2, 5, 31, 46, 548, DateTimeKind.Local).AddTicks(2636) });

            migrationBuilder.UpdateData(
                table: "Book",
                keyColumn: "BookId",
                keyValue: 1338,
                columns: new[] { "CreatedDateTime", "PublicationDate" },
                values: new object[] { new DateTime(2024, 8, 16, 16, 32, 4, 675, DateTimeKind.Utc).AddTicks(7889), new DateTime(2024, 8, 7, 6, 18, 35, 524, DateTimeKind.Local).AddTicks(693) });

            migrationBuilder.UpdateData(
                table: "Book",
                keyColumn: "BookId",
                keyValue: 1339,
                columns: new[] { "CreatedDateTime", "PublicationDate" },
                values: new object[] { new DateTime(2024, 8, 16, 16, 32, 4, 675, DateTimeKind.Utc).AddTicks(7990), new DateTime(2023, 9, 11, 6, 4, 40, 803, DateTimeKind.Local).AddTicks(4805) });

            migrationBuilder.UpdateData(
                table: "Book",
                keyColumn: "BookId",
                keyValue: 1340,
                columns: new[] { "CreatedDateTime", "PublicationDate" },
                values: new object[] { new DateTime(2024, 8, 16, 16, 32, 4, 675, DateTimeKind.Utc).AddTicks(8099), new DateTime(2024, 3, 19, 22, 23, 32, 858, DateTimeKind.Local).AddTicks(9622) });

            migrationBuilder.UpdateData(
                table: "Book",
                keyColumn: "BookId",
                keyValue: 1341,
                columns: new[] { "CreatedDateTime", "PublicationDate" },
                values: new object[] { new DateTime(2024, 8, 16, 16, 32, 4, 675, DateTimeKind.Utc).AddTicks(8194), new DateTime(2024, 7, 8, 7, 8, 53, 520, DateTimeKind.Local).AddTicks(5295) });

            migrationBuilder.UpdateData(
                table: "Book",
                keyColumn: "BookId",
                keyValue: 1342,
                columns: new[] { "CreatedDateTime", "PublicationDate" },
                values: new object[] { new DateTime(2024, 8, 16, 16, 32, 4, 675, DateTimeKind.Utc).AddTicks(8333), new DateTime(2024, 6, 4, 4, 28, 8, 480, DateTimeKind.Local).AddTicks(9172) });

            migrationBuilder.UpdateData(
                table: "Book",
                keyColumn: "BookId",
                keyValue: 1343,
                columns: new[] { "CreatedDateTime", "PublicationDate" },
                values: new object[] { new DateTime(2024, 8, 16, 16, 32, 4, 675, DateTimeKind.Utc).AddTicks(8431), new DateTime(2024, 5, 23, 9, 23, 9, 265, DateTimeKind.Local).AddTicks(5574) });

            migrationBuilder.UpdateData(
                table: "Book",
                keyColumn: "BookId",
                keyValue: 1344,
                columns: new[] { "CreatedDateTime", "PublicationDate" },
                values: new object[] { new DateTime(2024, 8, 16, 16, 32, 4, 675, DateTimeKind.Utc).AddTicks(8578), new DateTime(2023, 9, 3, 19, 48, 55, 584, DateTimeKind.Local).AddTicks(2810) });

            migrationBuilder.UpdateData(
                table: "Book",
                keyColumn: "BookId",
                keyValue: 1345,
                columns: new[] { "CreatedDateTime", "PublicationDate" },
                values: new object[] { new DateTime(2024, 8, 16, 16, 32, 4, 675, DateTimeKind.Utc).AddTicks(8672), new DateTime(2023, 12, 18, 16, 34, 57, 100, DateTimeKind.Local).AddTicks(7242) });

            migrationBuilder.UpdateData(
                table: "Book",
                keyColumn: "BookId",
                keyValue: 1346,
                columns: new[] { "CreatedDateTime", "PublicationDate" },
                values: new object[] { new DateTime(2024, 8, 16, 16, 32, 4, 675, DateTimeKind.Utc).AddTicks(8791), new DateTime(2023, 9, 6, 20, 4, 47, 385, DateTimeKind.Local).AddTicks(6576) });

            migrationBuilder.UpdateData(
                table: "Book",
                keyColumn: "BookId",
                keyValue: 1347,
                columns: new[] { "CreatedDateTime", "PublicationDate" },
                values: new object[] { new DateTime(2024, 8, 16, 16, 32, 4, 675, DateTimeKind.Utc).AddTicks(8883), new DateTime(2023, 10, 20, 18, 35, 30, 488, DateTimeKind.Local).AddTicks(6327) });

            migrationBuilder.UpdateData(
                table: "Book",
                keyColumn: "BookId",
                keyValue: 1348,
                columns: new[] { "CreatedDateTime", "PublicationDate" },
                values: new object[] { new DateTime(2024, 8, 16, 16, 32, 4, 675, DateTimeKind.Utc).AddTicks(9012), new DateTime(2024, 1, 4, 3, 26, 23, 177, DateTimeKind.Local).AddTicks(5653) });

            migrationBuilder.UpdateData(
                table: "Book",
                keyColumn: "BookId",
                keyValue: 1349,
                columns: new[] { "CreatedDateTime", "PublicationDate" },
                values: new object[] { new DateTime(2024, 8, 16, 16, 32, 4, 675, DateTimeKind.Utc).AddTicks(9118), new DateTime(2024, 4, 20, 1, 37, 48, 671, DateTimeKind.Local).AddTicks(2478) });

            migrationBuilder.UpdateData(
                table: "Book",
                keyColumn: "BookId",
                keyValue: 1350,
                columns: new[] { "CreatedDateTime", "PublicationDate" },
                values: new object[] { new DateTime(2024, 8, 16, 16, 32, 4, 675, DateTimeKind.Utc).AddTicks(9240), new DateTime(2023, 10, 7, 15, 28, 20, 166, DateTimeKind.Local).AddTicks(9950) });

            migrationBuilder.UpdateData(
                table: "Book",
                keyColumn: "BookId",
                keyValue: 1351,
                columns: new[] { "CreatedDateTime", "PublicationDate" },
                values: new object[] { new DateTime(2024, 8, 16, 16, 32, 4, 675, DateTimeKind.Utc).AddTicks(9337), new DateTime(2024, 1, 2, 10, 18, 45, 192, DateTimeKind.Local).AddTicks(9168) });

            migrationBuilder.UpdateData(
                table: "Book",
                keyColumn: "BookId",
                keyValue: 1352,
                columns: new[] { "CreatedDateTime", "PublicationDate" },
                values: new object[] { new DateTime(2024, 8, 16, 16, 32, 4, 675, DateTimeKind.Utc).AddTicks(9467), new DateTime(2023, 10, 31, 4, 22, 6, 133, DateTimeKind.Local).AddTicks(2468) });

            migrationBuilder.UpdateData(
                table: "Book",
                keyColumn: "BookId",
                keyValue: 1353,
                columns: new[] { "CreatedDateTime", "PublicationDate" },
                values: new object[] { new DateTime(2024, 8, 16, 16, 32, 4, 675, DateTimeKind.Utc).AddTicks(9560), new DateTime(2024, 1, 23, 8, 8, 15, 812, DateTimeKind.Local).AddTicks(4695) });

            migrationBuilder.UpdateData(
                table: "Book",
                keyColumn: "BookId",
                keyValue: 1354,
                columns: new[] { "CreatedDateTime", "PublicationDate" },
                values: new object[] { new DateTime(2024, 8, 16, 16, 32, 4, 675, DateTimeKind.Utc).AddTicks(9690), new DateTime(2024, 2, 9, 7, 1, 36, 543, DateTimeKind.Local).AddTicks(2019) });

            migrationBuilder.UpdateData(
                table: "Book",
                keyColumn: "BookId",
                keyValue: 1355,
                columns: new[] { "CreatedDateTime", "PublicationDate" },
                values: new object[] { new DateTime(2024, 8, 16, 16, 32, 4, 675, DateTimeKind.Utc).AddTicks(9786), new DateTime(2023, 10, 21, 21, 45, 30, 400, DateTimeKind.Local).AddTicks(5407) });

            migrationBuilder.UpdateData(
                table: "Book",
                keyColumn: "BookId",
                keyValue: 1356,
                columns: new[] { "CreatedDateTime", "PublicationDate" },
                values: new object[] { new DateTime(2024, 8, 16, 16, 32, 4, 675, DateTimeKind.Utc).AddTicks(9905), new DateTime(2024, 3, 25, 1, 46, 18, 434, DateTimeKind.Local).AddTicks(4811) });

            migrationBuilder.UpdateData(
                table: "Book",
                keyColumn: "BookId",
                keyValue: 1357,
                columns: new[] { "CreatedDateTime", "PublicationDate" },
                values: new object[] { new DateTime(2024, 8, 16, 16, 32, 4, 675, DateTimeKind.Utc).AddTicks(9996), new DateTime(2023, 10, 5, 7, 59, 59, 899, DateTimeKind.Local).AddTicks(2902) });

            migrationBuilder.UpdateData(
                table: "Book",
                keyColumn: "BookId",
                keyValue: 1358,
                columns: new[] { "CreatedDateTime", "PublicationDate" },
                values: new object[] { new DateTime(2024, 8, 16, 16, 32, 4, 676, DateTimeKind.Utc).AddTicks(125), new DateTime(2023, 12, 31, 15, 31, 32, 936, DateTimeKind.Local).AddTicks(7925) });

            migrationBuilder.UpdateData(
                table: "Book",
                keyColumn: "BookId",
                keyValue: 1359,
                columns: new[] { "CreatedDateTime", "PublicationDate" },
                values: new object[] { new DateTime(2024, 8, 16, 16, 32, 4, 676, DateTimeKind.Utc).AddTicks(265), new DateTime(2023, 11, 20, 6, 49, 55, 48, DateTimeKind.Local).AddTicks(3314) });

            migrationBuilder.UpdateData(
                table: "Book",
                keyColumn: "BookId",
                keyValue: 1360,
                columns: new[] { "CreatedDateTime", "PublicationDate" },
                values: new object[] { new DateTime(2024, 8, 16, 16, 32, 4, 676, DateTimeKind.Utc).AddTicks(363), new DateTime(2023, 12, 14, 12, 45, 13, 40, DateTimeKind.Local).AddTicks(3886) });

            migrationBuilder.UpdateData(
                table: "Book",
                keyColumn: "BookId",
                keyValue: 1361,
                columns: new[] { "CreatedDateTime", "PublicationDate" },
                values: new object[] { new DateTime(2024, 8, 16, 16, 32, 4, 676, DateTimeKind.Utc).AddTicks(490), new DateTime(2024, 6, 13, 8, 15, 39, 979, DateTimeKind.Local).AddTicks(9350) });

            migrationBuilder.UpdateData(
                table: "Book",
                keyColumn: "BookId",
                keyValue: 1362,
                columns: new[] { "CreatedDateTime", "PublicationDate" },
                values: new object[] { new DateTime(2024, 8, 16, 16, 32, 4, 676, DateTimeKind.Utc).AddTicks(585), new DateTime(2024, 6, 15, 17, 46, 19, 233, DateTimeKind.Local).AddTicks(1544) });

            migrationBuilder.UpdateData(
                table: "Book",
                keyColumn: "BookId",
                keyValue: 1363,
                columns: new[] { "CreatedDateTime", "PublicationDate" },
                values: new object[] { new DateTime(2024, 8, 16, 16, 32, 4, 676, DateTimeKind.Utc).AddTicks(720), new DateTime(2024, 6, 11, 13, 7, 28, 840, DateTimeKind.Local).AddTicks(7810) });

            migrationBuilder.UpdateData(
                table: "Book",
                keyColumn: "BookId",
                keyValue: 1364,
                columns: new[] { "CreatedDateTime", "PublicationDate" },
                values: new object[] { new DateTime(2024, 8, 16, 16, 32, 4, 676, DateTimeKind.Utc).AddTicks(819), new DateTime(2023, 10, 9, 15, 27, 35, 795, DateTimeKind.Local).AddTicks(764) });

            migrationBuilder.UpdateData(
                table: "Book",
                keyColumn: "BookId",
                keyValue: 1365,
                columns: new[] { "CreatedDateTime", "PublicationDate" },
                values: new object[] { new DateTime(2024, 8, 16, 16, 32, 4, 676, DateTimeKind.Utc).AddTicks(941), new DateTime(2024, 4, 5, 7, 45, 46, 29, DateTimeKind.Local).AddTicks(1798) });

            migrationBuilder.UpdateData(
                table: "Book",
                keyColumn: "BookId",
                keyValue: 1366,
                columns: new[] { "CreatedDateTime", "PublicationDate" },
                values: new object[] { new DateTime(2024, 8, 16, 16, 32, 4, 676, DateTimeKind.Utc).AddTicks(1049), new DateTime(2024, 6, 16, 11, 8, 2, 284, DateTimeKind.Local).AddTicks(6739) });

            migrationBuilder.UpdateData(
                table: "Book",
                keyColumn: "BookId",
                keyValue: 1367,
                columns: new[] { "CreatedDateTime", "PublicationDate" },
                values: new object[] { new DateTime(2024, 8, 16, 16, 32, 4, 676, DateTimeKind.Utc).AddTicks(1176), new DateTime(2024, 1, 20, 0, 18, 43, 271, DateTimeKind.Local).AddTicks(5189) });

            migrationBuilder.UpdateData(
                table: "Book",
                keyColumn: "BookId",
                keyValue: 1368,
                columns: new[] { "CreatedDateTime", "PublicationDate" },
                values: new object[] { new DateTime(2024, 8, 16, 16, 32, 4, 676, DateTimeKind.Utc).AddTicks(1269), new DateTime(2024, 7, 6, 3, 5, 22, 702, DateTimeKind.Local).AddTicks(1509) });

            migrationBuilder.UpdateData(
                table: "Book",
                keyColumn: "BookId",
                keyValue: 1369,
                columns: new[] { "CreatedDateTime", "PublicationDate" },
                values: new object[] { new DateTime(2024, 8, 16, 16, 32, 4, 676, DateTimeKind.Utc).AddTicks(1398), new DateTime(2024, 3, 16, 3, 17, 50, 789, DateTimeKind.Local).AddTicks(2751) });

            migrationBuilder.UpdateData(
                table: "Book",
                keyColumn: "BookId",
                keyValue: 1370,
                columns: new[] { "CreatedDateTime", "PublicationDate" },
                values: new object[] { new DateTime(2024, 8, 16, 16, 32, 4, 676, DateTimeKind.Utc).AddTicks(1522), new DateTime(2024, 5, 21, 18, 9, 47, 658, DateTimeKind.Local).AddTicks(7190) });

            migrationBuilder.UpdateData(
                table: "Book",
                keyColumn: "BookId",
                keyValue: 1371,
                columns: new[] { "CreatedDateTime", "PublicationDate" },
                values: new object[] { new DateTime(2024, 8, 16, 16, 32, 4, 676, DateTimeKind.Utc).AddTicks(1634), new DateTime(2024, 4, 18, 8, 22, 23, 643, DateTimeKind.Local).AddTicks(6054) });

            migrationBuilder.UpdateData(
                table: "Book",
                keyColumn: "BookId",
                keyValue: 1372,
                columns: new[] { "CreatedDateTime", "PublicationDate" },
                values: new object[] { new DateTime(2024, 8, 16, 16, 32, 4, 676, DateTimeKind.Utc).AddTicks(1772), new DateTime(2024, 1, 7, 20, 47, 55, 377, DateTimeKind.Local).AddTicks(1110) });

            migrationBuilder.UpdateData(
                table: "Book",
                keyColumn: "BookId",
                keyValue: 1373,
                columns: new[] { "CreatedDateTime", "PublicationDate" },
                values: new object[] { new DateTime(2024, 8, 16, 16, 32, 4, 676, DateTimeKind.Utc).AddTicks(1918), new DateTime(2023, 11, 28, 10, 51, 54, 924, DateTimeKind.Local).AddTicks(2831) });

            migrationBuilder.UpdateData(
                table: "Book",
                keyColumn: "BookId",
                keyValue: 1374,
                columns: new[] { "CreatedDateTime", "PublicationDate" },
                values: new object[] { new DateTime(2024, 8, 16, 16, 32, 4, 676, DateTimeKind.Utc).AddTicks(2013), new DateTime(2024, 4, 20, 2, 17, 31, 568, DateTimeKind.Local).AddTicks(2106) });

            migrationBuilder.UpdateData(
                table: "Book",
                keyColumn: "BookId",
                keyValue: 1375,
                columns: new[] { "CreatedDateTime", "PublicationDate" },
                values: new object[] { new DateTime(2024, 8, 16, 16, 32, 4, 676, DateTimeKind.Utc).AddTicks(2150), new DateTime(2023, 8, 27, 0, 7, 46, 538, DateTimeKind.Local).AddTicks(7472) });

            migrationBuilder.UpdateData(
                table: "Book",
                keyColumn: "BookId",
                keyValue: 1376,
                columns: new[] { "CreatedDateTime", "PublicationDate" },
                values: new object[] { new DateTime(2024, 8, 16, 16, 32, 4, 676, DateTimeKind.Utc).AddTicks(2246), new DateTime(2023, 10, 8, 15, 13, 36, 549, DateTimeKind.Local).AddTicks(6004) });

            migrationBuilder.UpdateData(
                table: "Book",
                keyColumn: "BookId",
                keyValue: 1377,
                columns: new[] { "CreatedDateTime", "PublicationDate" },
                values: new object[] { new DateTime(2024, 8, 16, 16, 32, 4, 676, DateTimeKind.Utc).AddTicks(2373), new DateTime(2023, 11, 12, 12, 24, 36, 246, DateTimeKind.Local).AddTicks(6506) });

            migrationBuilder.UpdateData(
                table: "Book",
                keyColumn: "BookId",
                keyValue: 1378,
                columns: new[] { "CreatedDateTime", "PublicationDate" },
                values: new object[] { new DateTime(2024, 8, 16, 16, 32, 4, 676, DateTimeKind.Utc).AddTicks(2468), new DateTime(2024, 1, 21, 15, 24, 53, 426, DateTimeKind.Local).AddTicks(7000) });

            migrationBuilder.UpdateData(
                table: "Book",
                keyColumn: "BookId",
                keyValue: 1379,
                columns: new[] { "CreatedDateTime", "PublicationDate" },
                values: new object[] { new DateTime(2024, 8, 16, 16, 32, 4, 676, DateTimeKind.Utc).AddTicks(2596), new DateTime(2024, 6, 9, 16, 24, 8, 824, DateTimeKind.Local).AddTicks(8487) });

            migrationBuilder.UpdateData(
                table: "Book",
                keyColumn: "BookId",
                keyValue: 1380,
                columns: new[] { "CreatedDateTime", "PublicationDate" },
                values: new object[] { new DateTime(2024, 8, 16, 16, 32, 4, 676, DateTimeKind.Utc).AddTicks(2702), new DateTime(2023, 10, 10, 1, 44, 13, 475, DateTimeKind.Local).AddTicks(1116) });

            migrationBuilder.UpdateData(
                table: "Book",
                keyColumn: "BookId",
                keyValue: 1381,
                columns: new[] { "CreatedDateTime", "PublicationDate" },
                values: new object[] { new DateTime(2024, 8, 16, 16, 32, 4, 676, DateTimeKind.Utc).AddTicks(2822), new DateTime(2023, 10, 7, 14, 15, 26, 465, DateTimeKind.Local).AddTicks(3059) });

            migrationBuilder.UpdateData(
                table: "Book",
                keyColumn: "BookId",
                keyValue: 1382,
                columns: new[] { "CreatedDateTime", "PublicationDate" },
                values: new object[] { new DateTime(2024, 8, 16, 16, 32, 4, 676, DateTimeKind.Utc).AddTicks(2930), new DateTime(2023, 12, 27, 12, 26, 57, 659, DateTimeKind.Local).AddTicks(4591) });

            migrationBuilder.UpdateData(
                table: "Book",
                keyColumn: "BookId",
                keyValue: 1383,
                columns: new[] { "CreatedDateTime", "PublicationDate" },
                values: new object[] { new DateTime(2024, 8, 16, 16, 32, 4, 676, DateTimeKind.Utc).AddTicks(3037), new DateTime(2023, 12, 18, 10, 52, 48, 153, DateTimeKind.Local).AddTicks(9594) });

            migrationBuilder.UpdateData(
                table: "Book",
                keyColumn: "BookId",
                keyValue: 1384,
                columns: new[] { "CreatedDateTime", "PublicationDate" },
                values: new object[] { new DateTime(2024, 8, 16, 16, 32, 4, 676, DateTimeKind.Utc).AddTicks(3161), new DateTime(2024, 1, 28, 21, 38, 32, 684, DateTimeKind.Local).AddTicks(7353) });

            migrationBuilder.UpdateData(
                table: "Book",
                keyColumn: "BookId",
                keyValue: 1385,
                columns: new[] { "CreatedDateTime", "PublicationDate" },
                values: new object[] { new DateTime(2024, 8, 16, 16, 32, 4, 676, DateTimeKind.Utc).AddTicks(3263), new DateTime(2024, 1, 12, 19, 24, 25, 669, DateTimeKind.Local).AddTicks(2851) });

            migrationBuilder.UpdateData(
                table: "Book",
                keyColumn: "BookId",
                keyValue: 1386,
                columns: new[] { "CreatedDateTime", "PublicationDate" },
                values: new object[] { new DateTime(2024, 8, 16, 16, 32, 4, 676, DateTimeKind.Utc).AddTicks(3395), new DateTime(2024, 8, 14, 18, 44, 24, 4, DateTimeKind.Local).AddTicks(1521) });

            migrationBuilder.UpdateData(
                table: "Book",
                keyColumn: "BookId",
                keyValue: 1387,
                columns: new[] { "CreatedDateTime", "PublicationDate" },
                values: new object[] { new DateTime(2024, 8, 16, 16, 32, 4, 676, DateTimeKind.Utc).AddTicks(3498), new DateTime(2023, 12, 19, 11, 38, 59, 465, DateTimeKind.Local).AddTicks(6688) });

            migrationBuilder.UpdateData(
                table: "Book",
                keyColumn: "BookId",
                keyValue: 1388,
                columns: new[] { "CreatedDateTime", "PublicationDate" },
                values: new object[] { new DateTime(2024, 8, 16, 16, 32, 4, 676, DateTimeKind.Utc).AddTicks(3581), new DateTime(2024, 6, 16, 21, 31, 26, 766, DateTimeKind.Local).AddTicks(6722) });

            migrationBuilder.UpdateData(
                table: "Book",
                keyColumn: "BookId",
                keyValue: 1389,
                columns: new[] { "CreatedDateTime", "PublicationDate" },
                values: new object[] { new DateTime(2024, 8, 16, 16, 32, 4, 676, DateTimeKind.Utc).AddTicks(3716), new DateTime(2024, 4, 12, 22, 39, 46, 559, DateTimeKind.Local).AddTicks(9762) });

            migrationBuilder.UpdateData(
                table: "Book",
                keyColumn: "BookId",
                keyValue: 1390,
                columns: new[] { "CreatedDateTime", "PublicationDate" },
                values: new object[] { new DateTime(2024, 8, 16, 16, 32, 4, 676, DateTimeKind.Utc).AddTicks(3834), new DateTime(2023, 12, 1, 2, 20, 35, 721, DateTimeKind.Local).AddTicks(415) });

            migrationBuilder.UpdateData(
                table: "Book",
                keyColumn: "BookId",
                keyValue: 1391,
                columns: new[] { "CreatedDateTime", "PublicationDate" },
                values: new object[] { new DateTime(2024, 8, 16, 16, 32, 4, 676, DateTimeKind.Utc).AddTicks(3932), new DateTime(2024, 1, 24, 18, 26, 26, 75, DateTimeKind.Local).AddTicks(9132) });

            migrationBuilder.UpdateData(
                table: "Book",
                keyColumn: "BookId",
                keyValue: 1392,
                columns: new[] { "CreatedDateTime", "PublicationDate" },
                values: new object[] { new DateTime(2024, 8, 16, 16, 32, 4, 676, DateTimeKind.Utc).AddTicks(4052), new DateTime(2023, 11, 22, 1, 25, 28, 838, DateTimeKind.Local).AddTicks(4548) });

            migrationBuilder.UpdateData(
                table: "Book",
                keyColumn: "BookId",
                keyValue: 1393,
                columns: new[] { "CreatedDateTime", "PublicationDate" },
                values: new object[] { new DateTime(2024, 8, 16, 16, 32, 4, 676, DateTimeKind.Utc).AddTicks(4146), new DateTime(2024, 6, 19, 9, 50, 25, 665, DateTimeKind.Local).AddTicks(5795) });

            migrationBuilder.UpdateData(
                table: "Book",
                keyColumn: "BookId",
                keyValue: 1394,
                columns: new[] { "CreatedDateTime", "PublicationDate" },
                values: new object[] { new DateTime(2024, 8, 16, 16, 32, 4, 676, DateTimeKind.Utc).AddTicks(4267), new DateTime(2023, 11, 26, 21, 22, 57, 545, DateTimeKind.Local).AddTicks(3185) });

            migrationBuilder.UpdateData(
                table: "Book",
                keyColumn: "BookId",
                keyValue: 1395,
                columns: new[] { "CreatedDateTime", "PublicationDate" },
                values: new object[] { new DateTime(2024, 8, 16, 16, 32, 4, 676, DateTimeKind.Utc).AddTicks(4361), new DateTime(2024, 1, 23, 9, 57, 49, 582, DateTimeKind.Local).AddTicks(57) });

            migrationBuilder.UpdateData(
                table: "Book",
                keyColumn: "BookId",
                keyValue: 1396,
                columns: new[] { "CreatedDateTime", "PublicationDate" },
                values: new object[] { new DateTime(2024, 8, 16, 16, 32, 4, 676, DateTimeKind.Utc).AddTicks(4514), new DateTime(2023, 9, 6, 2, 18, 50, 179, DateTimeKind.Local).AddTicks(2147) });

            migrationBuilder.UpdateData(
                table: "Book",
                keyColumn: "BookId",
                keyValue: 1397,
                columns: new[] { "CreatedDateTime", "PublicationDate" },
                values: new object[] { new DateTime(2024, 8, 16, 16, 32, 4, 676, DateTimeKind.Utc).AddTicks(4605), new DateTime(2023, 10, 23, 0, 31, 25, 537, DateTimeKind.Local).AddTicks(3332) });

            migrationBuilder.UpdateData(
                table: "Book",
                keyColumn: "BookId",
                keyValue: 1398,
                columns: new[] { "CreatedDateTime", "PublicationDate" },
                values: new object[] { new DateTime(2024, 8, 16, 16, 32, 4, 676, DateTimeKind.Utc).AddTicks(4716), new DateTime(2024, 2, 20, 3, 36, 8, 922, DateTimeKind.Local).AddTicks(9765) });

            migrationBuilder.UpdateData(
                table: "Book",
                keyColumn: "BookId",
                keyValue: 1399,
                columns: new[] { "CreatedDateTime", "PublicationDate" },
                values: new object[] { new DateTime(2024, 8, 16, 16, 32, 4, 676, DateTimeKind.Utc).AddTicks(4813), new DateTime(2024, 5, 5, 9, 46, 27, 404, DateTimeKind.Local).AddTicks(4167) });

            migrationBuilder.UpdateData(
                table: "Book",
                keyColumn: "BookId",
                keyValue: 1400,
                columns: new[] { "CreatedDateTime", "PublicationDate" },
                values: new object[] { new DateTime(2024, 8, 16, 16, 32, 4, 676, DateTimeKind.Utc).AddTicks(4943), new DateTime(2023, 9, 8, 5, 52, 48, 510, DateTimeKind.Local).AddTicks(2723) });

            migrationBuilder.UpdateData(
                table: "Book",
                keyColumn: "BookId",
                keyValue: 1401,
                columns: new[] { "CreatedDateTime", "PublicationDate" },
                values: new object[] { new DateTime(2024, 8, 16, 16, 32, 4, 676, DateTimeKind.Utc).AddTicks(5042), new DateTime(2024, 3, 21, 21, 14, 3, 349, DateTimeKind.Local).AddTicks(622) });

            migrationBuilder.UpdateData(
                table: "Book",
                keyColumn: "BookId",
                keyValue: 1402,
                columns: new[] { "CreatedDateTime", "PublicationDate" },
                values: new object[] { new DateTime(2024, 8, 16, 16, 32, 4, 676, DateTimeKind.Utc).AddTicks(5185), new DateTime(2024, 7, 15, 10, 15, 59, 674, DateTimeKind.Local).AddTicks(9027) });

            migrationBuilder.UpdateData(
                table: "Book",
                keyColumn: "BookId",
                keyValue: 1403,
                columns: new[] { "CreatedDateTime", "PublicationDate" },
                values: new object[] { new DateTime(2024, 8, 16, 16, 32, 4, 676, DateTimeKind.Utc).AddTicks(5279), new DateTime(2024, 1, 14, 23, 30, 54, 75, DateTimeKind.Local).AddTicks(6258) });

            migrationBuilder.UpdateData(
                table: "Book",
                keyColumn: "BookId",
                keyValue: 1404,
                columns: new[] { "CreatedDateTime", "PublicationDate" },
                values: new object[] { new DateTime(2024, 8, 16, 16, 32, 4, 676, DateTimeKind.Utc).AddTicks(5414), new DateTime(2024, 1, 4, 23, 12, 13, 560, DateTimeKind.Local).AddTicks(4497) });

            migrationBuilder.UpdateData(
                table: "Book",
                keyColumn: "BookId",
                keyValue: 1405,
                columns: new[] { "CreatedDateTime", "PublicationDate" },
                values: new object[] { new DateTime(2024, 8, 16, 16, 32, 4, 676, DateTimeKind.Utc).AddTicks(5538), new DateTime(2024, 7, 3, 16, 48, 49, 444, DateTimeKind.Local).AddTicks(9929) });

            migrationBuilder.UpdateData(
                table: "Book",
                keyColumn: "BookId",
                keyValue: 1406,
                columns: new[] { "CreatedDateTime", "PublicationDate" },
                values: new object[] { new DateTime(2024, 8, 16, 16, 32, 4, 676, DateTimeKind.Utc).AddTicks(5631), new DateTime(2024, 3, 18, 14, 29, 5, 954, DateTimeKind.Local).AddTicks(6439) });

            migrationBuilder.UpdateData(
                table: "Book",
                keyColumn: "BookId",
                keyValue: 1407,
                columns: new[] { "CreatedDateTime", "PublicationDate" },
                values: new object[] { new DateTime(2024, 8, 16, 16, 32, 4, 676, DateTimeKind.Utc).AddTicks(5758), new DateTime(2024, 8, 12, 23, 20, 42, 828, DateTimeKind.Local).AddTicks(2516) });

            migrationBuilder.UpdateData(
                table: "Book",
                keyColumn: "BookId",
                keyValue: 1408,
                columns: new[] { "CreatedDateTime", "PublicationDate" },
                values: new object[] { new DateTime(2024, 8, 16, 16, 32, 4, 676, DateTimeKind.Utc).AddTicks(5861), new DateTime(2024, 1, 26, 22, 20, 10, 326, DateTimeKind.Local).AddTicks(958) });

            migrationBuilder.UpdateData(
                table: "Book",
                keyColumn: "BookId",
                keyValue: 1409,
                columns: new[] { "CreatedDateTime", "PublicationDate" },
                values: new object[] { new DateTime(2024, 8, 16, 16, 32, 4, 676, DateTimeKind.Utc).AddTicks(5985), new DateTime(2024, 1, 25, 14, 53, 4, 941, DateTimeKind.Local).AddTicks(6442) });

            migrationBuilder.UpdateData(
                table: "Book",
                keyColumn: "BookId",
                keyValue: 1410,
                columns: new[] { "CreatedDateTime", "PublicationDate" },
                values: new object[] { new DateTime(2024, 8, 16, 16, 32, 4, 676, DateTimeKind.Utc).AddTicks(6083), new DateTime(2024, 2, 7, 2, 0, 47, 788, DateTimeKind.Local).AddTicks(2197) });

            migrationBuilder.UpdateData(
                table: "Book",
                keyColumn: "BookId",
                keyValue: 1411,
                columns: new[] { "CreatedDateTime", "PublicationDate" },
                values: new object[] { new DateTime(2024, 8, 16, 16, 32, 4, 676, DateTimeKind.Utc).AddTicks(6210), new DateTime(2024, 4, 20, 21, 39, 9, 901, DateTimeKind.Local).AddTicks(519) });

            migrationBuilder.UpdateData(
                table: "Book",
                keyColumn: "BookId",
                keyValue: 1412,
                columns: new[] { "CreatedDateTime", "PublicationDate" },
                values: new object[] { new DateTime(2024, 8, 16, 16, 32, 4, 676, DateTimeKind.Utc).AddTicks(6306), new DateTime(2024, 7, 17, 13, 21, 43, 371, DateTimeKind.Local).AddTicks(1637) });

            migrationBuilder.UpdateData(
                table: "Book",
                keyColumn: "BookId",
                keyValue: 1413,
                columns: new[] { "CreatedDateTime", "PublicationDate" },
                values: new object[] { new DateTime(2024, 8, 16, 16, 32, 4, 676, DateTimeKind.Utc).AddTicks(6409), new DateTime(2024, 3, 17, 7, 24, 22, 91, DateTimeKind.Local).AddTicks(7684) });

            migrationBuilder.UpdateData(
                table: "Book",
                keyColumn: "BookId",
                keyValue: 1414,
                columns: new[] { "CreatedDateTime", "PublicationDate" },
                values: new object[] { new DateTime(2024, 8, 16, 16, 32, 4, 676, DateTimeKind.Utc).AddTicks(6506), new DateTime(2024, 1, 12, 5, 33, 1, 840, DateTimeKind.Local).AddTicks(9473) });

            migrationBuilder.UpdateData(
                table: "Book",
                keyColumn: "BookId",
                keyValue: 1415,
                columns: new[] { "CreatedDateTime", "PublicationDate" },
                values: new object[] { new DateTime(2024, 8, 16, 16, 32, 4, 676, DateTimeKind.Utc).AddTicks(6636), new DateTime(2024, 8, 8, 17, 24, 39, 155, DateTimeKind.Local).AddTicks(8333) });

            migrationBuilder.UpdateData(
                table: "Book",
                keyColumn: "BookId",
                keyValue: 1416,
                columns: new[] { "CreatedDateTime", "PublicationDate" },
                values: new object[] { new DateTime(2024, 8, 16, 16, 32, 4, 676, DateTimeKind.Utc).AddTicks(6725), new DateTime(2024, 1, 7, 17, 55, 57, 31, DateTimeKind.Local).AddTicks(3996) });

            migrationBuilder.UpdateData(
                table: "Book",
                keyColumn: "BookId",
                keyValue: 1417,
                columns: new[] { "CreatedDateTime", "PublicationDate" },
                values: new object[] { new DateTime(2024, 8, 16, 16, 32, 4, 676, DateTimeKind.Utc).AddTicks(6865), new DateTime(2023, 11, 18, 11, 36, 38, 786, DateTimeKind.Local).AddTicks(3044) });

            migrationBuilder.UpdateData(
                table: "Book",
                keyColumn: "BookId",
                keyValue: 1418,
                columns: new[] { "CreatedDateTime", "PublicationDate" },
                values: new object[] { new DateTime(2024, 8, 16, 16, 32, 4, 676, DateTimeKind.Utc).AddTicks(6974), new DateTime(2024, 4, 18, 16, 30, 27, 19, DateTimeKind.Local).AddTicks(4146) });

            migrationBuilder.UpdateData(
                table: "Book",
                keyColumn: "BookId",
                keyValue: 1419,
                columns: new[] { "CreatedDateTime", "PublicationDate" },
                values: new object[] { new DateTime(2024, 8, 16, 16, 32, 4, 676, DateTimeKind.Utc).AddTicks(7095), new DateTime(2024, 5, 10, 0, 41, 31, 739, DateTimeKind.Local).AddTicks(6442) });

            migrationBuilder.UpdateData(
                table: "Book",
                keyColumn: "BookId",
                keyValue: 1420,
                columns: new[] { "CreatedDateTime", "PublicationDate" },
                values: new object[] { new DateTime(2024, 8, 16, 16, 32, 4, 676, DateTimeKind.Utc).AddTicks(7194), new DateTime(2023, 9, 4, 3, 8, 56, 580, DateTimeKind.Local).AddTicks(6425) });

            migrationBuilder.UpdateData(
                table: "Book",
                keyColumn: "BookId",
                keyValue: 1421,
                columns: new[] { "CreatedDateTime", "PublicationDate" },
                values: new object[] { new DateTime(2024, 8, 16, 16, 32, 4, 676, DateTimeKind.Utc).AddTicks(7325), new DateTime(2023, 9, 2, 3, 41, 16, 293, DateTimeKind.Local).AddTicks(8082) });

            migrationBuilder.UpdateData(
                table: "Book",
                keyColumn: "BookId",
                keyValue: 1422,
                columns: new[] { "CreatedDateTime", "PublicationDate" },
                values: new object[] { new DateTime(2024, 8, 16, 16, 32, 4, 676, DateTimeKind.Utc).AddTicks(7410), new DateTime(2024, 7, 21, 22, 50, 50, 424, DateTimeKind.Local).AddTicks(5414) });

            migrationBuilder.UpdateData(
                table: "Book",
                keyColumn: "BookId",
                keyValue: 1423,
                columns: new[] { "CreatedDateTime", "PublicationDate" },
                values: new object[] { new DateTime(2024, 8, 16, 16, 32, 4, 676, DateTimeKind.Utc).AddTicks(7537), new DateTime(2024, 1, 11, 6, 25, 57, 897, DateTimeKind.Local).AddTicks(7295) });

            migrationBuilder.UpdateData(
                table: "Book",
                keyColumn: "BookId",
                keyValue: 1424,
                columns: new[] { "CreatedDateTime", "PublicationDate" },
                values: new object[] { new DateTime(2024, 8, 16, 16, 32, 4, 676, DateTimeKind.Utc).AddTicks(7626), new DateTime(2024, 2, 5, 6, 44, 15, 119, DateTimeKind.Local).AddTicks(2701) });

            migrationBuilder.UpdateData(
                table: "Book",
                keyColumn: "BookId",
                keyValue: 1425,
                columns: new[] { "CreatedDateTime", "PublicationDate" },
                values: new object[] { new DateTime(2024, 8, 16, 16, 32, 4, 676, DateTimeKind.Utc).AddTicks(7748), new DateTime(2024, 4, 28, 3, 4, 15, 443, DateTimeKind.Local).AddTicks(8965) });

            migrationBuilder.UpdateData(
                table: "Book",
                keyColumn: "BookId",
                keyValue: 1426,
                columns: new[] { "CreatedDateTime", "PublicationDate" },
                values: new object[] { new DateTime(2024, 8, 16, 16, 32, 4, 676, DateTimeKind.Utc).AddTicks(7840), new DateTime(2023, 12, 23, 16, 0, 5, 953, DateTimeKind.Local).AddTicks(5783) });

            migrationBuilder.UpdateData(
                table: "Book",
                keyColumn: "BookId",
                keyValue: 1427,
                columns: new[] { "CreatedDateTime", "PublicationDate" },
                values: new object[] { new DateTime(2024, 8, 16, 16, 32, 4, 676, DateTimeKind.Utc).AddTicks(7961), new DateTime(2024, 7, 5, 21, 57, 37, 201, DateTimeKind.Local).AddTicks(345) });

            migrationBuilder.UpdateData(
                table: "Book",
                keyColumn: "BookId",
                keyValue: 1428,
                columns: new[] { "CreatedDateTime", "PublicationDate" },
                values: new object[] { new DateTime(2024, 8, 16, 16, 32, 4, 676, DateTimeKind.Utc).AddTicks(8049), new DateTime(2024, 3, 21, 13, 33, 33, 937, DateTimeKind.Local).AddTicks(5928) });

            migrationBuilder.UpdateData(
                table: "Book",
                keyColumn: "BookId",
                keyValue: 1429,
                columns: new[] { "CreatedDateTime", "PublicationDate" },
                values: new object[] { new DateTime(2024, 8, 16, 16, 32, 4, 676, DateTimeKind.Utc).AddTicks(8159), new DateTime(2023, 9, 26, 20, 18, 37, 259, DateTimeKind.Local).AddTicks(3813) });

            migrationBuilder.UpdateData(
                table: "Book",
                keyColumn: "BookId",
                keyValue: 1430,
                columns: new[] { "CreatedDateTime", "PublicationDate" },
                values: new object[] { new DateTime(2024, 8, 16, 16, 32, 4, 676, DateTimeKind.Utc).AddTicks(8245), new DateTime(2024, 7, 25, 19, 16, 40, 417, DateTimeKind.Local).AddTicks(1496) });

            migrationBuilder.UpdateData(
                table: "Book",
                keyColumn: "BookId",
                keyValue: 1431,
                columns: new[] { "CreatedDateTime", "PublicationDate" },
                values: new object[] { new DateTime(2024, 8, 16, 16, 32, 4, 676, DateTimeKind.Utc).AddTicks(8363), new DateTime(2024, 3, 22, 23, 0, 53, 333, DateTimeKind.Local).AddTicks(6554) });

            migrationBuilder.UpdateData(
                table: "Book",
                keyColumn: "BookId",
                keyValue: 1432,
                columns: new[] { "CreatedDateTime", "PublicationDate" },
                values: new object[] { new DateTime(2024, 8, 16, 16, 32, 4, 676, DateTimeKind.Utc).AddTicks(8462), new DateTime(2024, 5, 28, 14, 58, 45, 102, DateTimeKind.Local).AddTicks(1128) });

            migrationBuilder.UpdateData(
                table: "Book",
                keyColumn: "BookId",
                keyValue: 1433,
                columns: new[] { "CreatedDateTime", "PublicationDate" },
                values: new object[] { new DateTime(2024, 8, 16, 16, 32, 4, 676, DateTimeKind.Utc).AddTicks(8619), new DateTime(2024, 4, 30, 22, 58, 37, 497, DateTimeKind.Local).AddTicks(2434) });

            migrationBuilder.UpdateData(
                table: "Book",
                keyColumn: "BookId",
                keyValue: 1434,
                columns: new[] { "CreatedDateTime", "PublicationDate" },
                values: new object[] { new DateTime(2024, 8, 16, 16, 32, 4, 676, DateTimeKind.Utc).AddTicks(8762), new DateTime(2024, 4, 19, 22, 38, 51, 699, DateTimeKind.Local).AddTicks(6637) });

            migrationBuilder.UpdateData(
                table: "Book",
                keyColumn: "BookId",
                keyValue: 1435,
                columns: new[] { "CreatedDateTime", "PublicationDate" },
                values: new object[] { new DateTime(2024, 8, 16, 16, 32, 4, 676, DateTimeKind.Utc).AddTicks(8855), new DateTime(2024, 8, 3, 19, 49, 38, 986, DateTimeKind.Local).AddTicks(9275) });

            migrationBuilder.UpdateData(
                table: "Book",
                keyColumn: "BookId",
                keyValue: 1436,
                columns: new[] { "CreatedDateTime", "PublicationDate" },
                values: new object[] { new DateTime(2024, 8, 16, 16, 32, 4, 676, DateTimeKind.Utc).AddTicks(8985), new DateTime(2024, 1, 19, 2, 16, 53, 26, DateTimeKind.Local).AddTicks(5265) });

            migrationBuilder.UpdateData(
                table: "Book",
                keyColumn: "BookId",
                keyValue: 1437,
                columns: new[] { "CreatedDateTime", "PublicationDate" },
                values: new object[] { new DateTime(2024, 8, 16, 16, 32, 4, 676, DateTimeKind.Utc).AddTicks(9087), new DateTime(2023, 8, 26, 18, 16, 15, 452, DateTimeKind.Local).AddTicks(8673) });

            migrationBuilder.UpdateData(
                table: "Book",
                keyColumn: "BookId",
                keyValue: 1438,
                columns: new[] { "CreatedDateTime", "PublicationDate" },
                values: new object[] { new DateTime(2024, 8, 16, 16, 32, 4, 676, DateTimeKind.Utc).AddTicks(9209), new DateTime(2023, 11, 15, 23, 42, 57, 317, DateTimeKind.Local).AddTicks(9579) });

            migrationBuilder.UpdateData(
                table: "Book",
                keyColumn: "BookId",
                keyValue: 1439,
                columns: new[] { "CreatedDateTime", "PublicationDate" },
                values: new object[] { new DateTime(2024, 8, 16, 16, 32, 4, 676, DateTimeKind.Utc).AddTicks(9298), new DateTime(2024, 3, 24, 12, 46, 45, 582, DateTimeKind.Local).AddTicks(5229) });

            migrationBuilder.UpdateData(
                table: "Book",
                keyColumn: "BookId",
                keyValue: 1440,
                columns: new[] { "CreatedDateTime", "PublicationDate" },
                values: new object[] { new DateTime(2024, 8, 16, 16, 32, 4, 676, DateTimeKind.Utc).AddTicks(9430), new DateTime(2024, 3, 3, 19, 11, 30, 770, DateTimeKind.Local).AddTicks(4237) });

            migrationBuilder.UpdateData(
                table: "Book",
                keyColumn: "BookId",
                keyValue: 1441,
                columns: new[] { "CreatedDateTime", "PublicationDate" },
                values: new object[] { new DateTime(2024, 8, 16, 16, 32, 4, 676, DateTimeKind.Utc).AddTicks(9522), new DateTime(2023, 9, 27, 18, 7, 22, 660, DateTimeKind.Local).AddTicks(620) });

            migrationBuilder.UpdateData(
                table: "Book",
                keyColumn: "BookId",
                keyValue: 1442,
                columns: new[] { "CreatedDateTime", "PublicationDate" },
                values: new object[] { new DateTime(2024, 8, 16, 16, 32, 4, 676, DateTimeKind.Utc).AddTicks(9643), new DateTime(2024, 3, 31, 7, 31, 2, 779, DateTimeKind.Local).AddTicks(7590) });

            migrationBuilder.UpdateData(
                table: "Book",
                keyColumn: "BookId",
                keyValue: 1443,
                columns: new[] { "CreatedDateTime", "PublicationDate" },
                values: new object[] { new DateTime(2024, 8, 16, 16, 32, 4, 676, DateTimeKind.Utc).AddTicks(9732), new DateTime(2024, 1, 16, 3, 47, 44, 224, DateTimeKind.Local).AddTicks(6760) });

            migrationBuilder.UpdateData(
                table: "Book",
                keyColumn: "BookId",
                keyValue: 1444,
                columns: new[] { "CreatedDateTime", "PublicationDate" },
                values: new object[] { new DateTime(2024, 8, 16, 16, 32, 4, 676, DateTimeKind.Utc).AddTicks(9846), new DateTime(2023, 10, 14, 4, 39, 19, 693, DateTimeKind.Local).AddTicks(1529) });

            migrationBuilder.UpdateData(
                table: "Book",
                keyColumn: "BookId",
                keyValue: 1445,
                columns: new[] { "CreatedDateTime", "PublicationDate" },
                values: new object[] { new DateTime(2024, 8, 16, 16, 32, 4, 676, DateTimeKind.Utc).AddTicks(9940), new DateTime(2024, 3, 20, 17, 8, 46, 542, DateTimeKind.Local).AddTicks(9842) });

            migrationBuilder.UpdateData(
                table: "Book",
                keyColumn: "BookId",
                keyValue: 1446,
                columns: new[] { "CreatedDateTime", "PublicationDate" },
                values: new object[] { new DateTime(2024, 8, 16, 16, 32, 4, 677, DateTimeKind.Utc).AddTicks(62), new DateTime(2024, 4, 30, 5, 51, 45, 166, DateTimeKind.Local).AddTicks(2469) });

            migrationBuilder.UpdateData(
                table: "Book",
                keyColumn: "BookId",
                keyValue: 1447,
                columns: new[] { "CreatedDateTime", "PublicationDate" },
                values: new object[] { new DateTime(2024, 8, 16, 16, 32, 4, 677, DateTimeKind.Utc).AddTicks(154), new DateTime(2023, 10, 10, 5, 38, 7, 802, DateTimeKind.Local).AddTicks(6345) });

            migrationBuilder.UpdateData(
                table: "Book",
                keyColumn: "BookId",
                keyValue: 1448,
                columns: new[] { "CreatedDateTime", "PublicationDate" },
                values: new object[] { new DateTime(2024, 8, 16, 16, 32, 4, 677, DateTimeKind.Utc).AddTicks(286), new DateTime(2023, 10, 17, 15, 31, 14, 890, DateTimeKind.Local).AddTicks(2257) });

            migrationBuilder.UpdateData(
                table: "Book",
                keyColumn: "BookId",
                keyValue: 1449,
                columns: new[] { "CreatedDateTime", "PublicationDate" },
                values: new object[] { new DateTime(2024, 8, 16, 16, 32, 4, 677, DateTimeKind.Utc).AddTicks(382), new DateTime(2024, 6, 28, 6, 2, 48, 529, DateTimeKind.Local).AddTicks(7699) });

            migrationBuilder.UpdateData(
                table: "Book",
                keyColumn: "BookId",
                keyValue: 1450,
                columns: new[] { "CreatedDateTime", "PublicationDate" },
                values: new object[] { new DateTime(2024, 8, 16, 16, 32, 4, 677, DateTimeKind.Utc).AddTicks(498), new DateTime(2024, 4, 29, 13, 30, 5, 343, DateTimeKind.Local).AddTicks(5548) });

            migrationBuilder.UpdateData(
                table: "Book",
                keyColumn: "BookId",
                keyValue: 1451,
                columns: new[] { "CreatedDateTime", "PublicationDate" },
                values: new object[] { new DateTime(2024, 8, 16, 16, 32, 4, 677, DateTimeKind.Utc).AddTicks(597), new DateTime(2024, 1, 31, 10, 34, 35, 889, DateTimeKind.Local).AddTicks(2243) });

            migrationBuilder.UpdateData(
                table: "Book",
                keyColumn: "BookId",
                keyValue: 1452,
                columns: new[] { "CreatedDateTime", "PublicationDate" },
                values: new object[] { new DateTime(2024, 8, 16, 16, 32, 4, 677, DateTimeKind.Utc).AddTicks(711), new DateTime(2024, 5, 15, 13, 16, 56, 676, DateTimeKind.Local).AddTicks(6010) });

            migrationBuilder.UpdateData(
                table: "Book",
                keyColumn: "BookId",
                keyValue: 1453,
                columns: new[] { "CreatedDateTime", "PublicationDate" },
                values: new object[] { new DateTime(2024, 8, 16, 16, 32, 4, 677, DateTimeKind.Utc).AddTicks(820), new DateTime(2024, 5, 30, 10, 38, 26, 252, DateTimeKind.Local).AddTicks(321) });

            migrationBuilder.UpdateData(
                table: "Book",
                keyColumn: "BookId",
                keyValue: 1454,
                columns: new[] { "CreatedDateTime", "PublicationDate" },
                values: new object[] { new DateTime(2024, 8, 16, 16, 32, 4, 677, DateTimeKind.Utc).AddTicks(943), new DateTime(2024, 6, 19, 10, 28, 40, 652, DateTimeKind.Local).AddTicks(7238) });

            migrationBuilder.UpdateData(
                table: "Book",
                keyColumn: "BookId",
                keyValue: 1455,
                columns: new[] { "CreatedDateTime", "PublicationDate" },
                values: new object[] { new DateTime(2024, 8, 16, 16, 32, 4, 677, DateTimeKind.Utc).AddTicks(1041), new DateTime(2024, 7, 3, 8, 32, 41, 901, DateTimeKind.Local).AddTicks(5007) });

            migrationBuilder.UpdateData(
                table: "Book",
                keyColumn: "BookId",
                keyValue: 1456,
                columns: new[] { "CreatedDateTime", "PublicationDate" },
                values: new object[] { new DateTime(2024, 8, 16, 16, 32, 4, 677, DateTimeKind.Utc).AddTicks(1160), new DateTime(2023, 11, 9, 10, 45, 22, 576, DateTimeKind.Local).AddTicks(3788) });

            migrationBuilder.UpdateData(
                table: "Book",
                keyColumn: "BookId",
                keyValue: 1457,
                columns: new[] { "CreatedDateTime", "PublicationDate" },
                values: new object[] { new DateTime(2024, 8, 16, 16, 32, 4, 677, DateTimeKind.Utc).AddTicks(1246), new DateTime(2024, 8, 16, 11, 44, 20, 924, DateTimeKind.Local).AddTicks(8899) });

            migrationBuilder.UpdateData(
                table: "Book",
                keyColumn: "BookId",
                keyValue: 1458,
                columns: new[] { "CreatedDateTime", "PublicationDate" },
                values: new object[] { new DateTime(2024, 8, 16, 16, 32, 4, 677, DateTimeKind.Utc).AddTicks(1367), new DateTime(2024, 2, 23, 5, 33, 9, 680, DateTimeKind.Local).AddTicks(3737) });

            migrationBuilder.UpdateData(
                table: "Book",
                keyColumn: "BookId",
                keyValue: 1459,
                columns: new[] { "CreatedDateTime", "PublicationDate" },
                values: new object[] { new DateTime(2024, 8, 16, 16, 32, 4, 677, DateTimeKind.Utc).AddTicks(1461), new DateTime(2024, 8, 3, 19, 58, 6, 466, DateTimeKind.Local).AddTicks(1460) });

            migrationBuilder.UpdateData(
                table: "Book",
                keyColumn: "BookId",
                keyValue: 1460,
                columns: new[] { "CreatedDateTime", "PublicationDate" },
                values: new object[] { new DateTime(2024, 8, 16, 16, 32, 4, 677, DateTimeKind.Utc).AddTicks(1573), new DateTime(2023, 12, 12, 21, 54, 24, 147, DateTimeKind.Local).AddTicks(1228) });

            migrationBuilder.UpdateData(
                table: "Book",
                keyColumn: "BookId",
                keyValue: 1461,
                columns: new[] { "CreatedDateTime", "PublicationDate" },
                values: new object[] { new DateTime(2024, 8, 16, 16, 32, 4, 677, DateTimeKind.Utc).AddTicks(1670), new DateTime(2024, 6, 11, 11, 51, 57, 976, DateTimeKind.Local).AddTicks(4099) });

            migrationBuilder.UpdateData(
                table: "Book",
                keyColumn: "BookId",
                keyValue: 1462,
                columns: new[] { "CreatedDateTime", "PublicationDate" },
                values: new object[] { new DateTime(2024, 8, 16, 16, 32, 4, 677, DateTimeKind.Utc).AddTicks(1796), new DateTime(2023, 8, 17, 12, 3, 46, 925, DateTimeKind.Local).AddTicks(5815) });

            migrationBuilder.UpdateData(
                table: "Book",
                keyColumn: "BookId",
                keyValue: 1463,
                columns: new[] { "CreatedDateTime", "PublicationDate" },
                values: new object[] { new DateTime(2024, 8, 16, 16, 32, 4, 677, DateTimeKind.Utc).AddTicks(1887), new DateTime(2023, 12, 22, 15, 46, 9, 358, DateTimeKind.Local).AddTicks(9236) });

            migrationBuilder.UpdateData(
                table: "Book",
                keyColumn: "BookId",
                keyValue: 1464,
                columns: new[] { "CreatedDateTime", "PublicationDate" },
                values: new object[] { new DateTime(2024, 8, 16, 16, 32, 4, 677, DateTimeKind.Utc).AddTicks(2017), new DateTime(2024, 7, 18, 18, 10, 27, 636, DateTimeKind.Local).AddTicks(2148) });

            migrationBuilder.UpdateData(
                table: "Book",
                keyColumn: "BookId",
                keyValue: 1465,
                columns: new[] { "CreatedDateTime", "PublicationDate" },
                values: new object[] { new DateTime(2024, 8, 16, 16, 32, 4, 677, DateTimeKind.Utc).AddTicks(2109), new DateTime(2023, 12, 27, 5, 39, 53, 613, DateTimeKind.Local).AddTicks(7248) });

            migrationBuilder.UpdateData(
                table: "Book",
                keyColumn: "BookId",
                keyValue: 1466,
                columns: new[] { "CreatedDateTime", "PublicationDate" },
                values: new object[] { new DateTime(2024, 8, 16, 16, 32, 4, 677, DateTimeKind.Utc).AddTicks(2224), new DateTime(2023, 11, 4, 4, 9, 46, 840, DateTimeKind.Local).AddTicks(1220) });

            migrationBuilder.UpdateData(
                table: "Book",
                keyColumn: "BookId",
                keyValue: 1467,
                columns: new[] { "CreatedDateTime", "PublicationDate" },
                values: new object[] { new DateTime(2024, 8, 16, 16, 32, 4, 677, DateTimeKind.Utc).AddTicks(2326), new DateTime(2024, 1, 28, 18, 54, 40, 83, DateTimeKind.Local).AddTicks(8233) });

            migrationBuilder.UpdateData(
                table: "Book",
                keyColumn: "BookId",
                keyValue: 1468,
                columns: new[] { "CreatedDateTime", "PublicationDate" },
                values: new object[] { new DateTime(2024, 8, 16, 16, 32, 4, 677, DateTimeKind.Utc).AddTicks(2463), new DateTime(2023, 12, 16, 11, 20, 25, 185, DateTimeKind.Local).AddTicks(9468) });

            migrationBuilder.UpdateData(
                table: "Book",
                keyColumn: "BookId",
                keyValue: 1469,
                columns: new[] { "CreatedDateTime", "PublicationDate" },
                values: new object[] { new DateTime(2024, 8, 16, 16, 32, 4, 677, DateTimeKind.Utc).AddTicks(2554), new DateTime(2024, 3, 9, 2, 29, 31, 382, DateTimeKind.Local).AddTicks(3798) });

            migrationBuilder.UpdateData(
                table: "Book",
                keyColumn: "BookId",
                keyValue: 1470,
                columns: new[] { "CreatedDateTime", "PublicationDate" },
                values: new object[] { new DateTime(2024, 8, 16, 16, 32, 4, 677, DateTimeKind.Utc).AddTicks(2694), new DateTime(2024, 7, 11, 7, 40, 50, 82, DateTimeKind.Local).AddTicks(6129) });

            migrationBuilder.UpdateData(
                table: "Book",
                keyColumn: "BookId",
                keyValue: 1471,
                columns: new[] { "CreatedDateTime", "PublicationDate" },
                values: new object[] { new DateTime(2024, 8, 16, 16, 32, 4, 677, DateTimeKind.Utc).AddTicks(2792), new DateTime(2024, 4, 26, 16, 13, 40, 407, DateTimeKind.Local).AddTicks(3900) });

            migrationBuilder.UpdateData(
                table: "Book",
                keyColumn: "BookId",
                keyValue: 1472,
                columns: new[] { "CreatedDateTime", "PublicationDate" },
                values: new object[] { new DateTime(2024, 8, 16, 16, 32, 4, 677, DateTimeKind.Utc).AddTicks(2903), new DateTime(2023, 12, 4, 7, 21, 7, 165, DateTimeKind.Local).AddTicks(6130) });

            migrationBuilder.UpdateData(
                table: "Book",
                keyColumn: "BookId",
                keyValue: 1473,
                columns: new[] { "CreatedDateTime", "PublicationDate" },
                values: new object[] { new DateTime(2024, 8, 16, 16, 32, 4, 677, DateTimeKind.Utc).AddTicks(2994), new DateTime(2024, 4, 27, 4, 45, 51, 960, DateTimeKind.Local).AddTicks(5855) });

            migrationBuilder.UpdateData(
                table: "Book",
                keyColumn: "BookId",
                keyValue: 1474,
                columns: new[] { "CreatedDateTime", "PublicationDate" },
                values: new object[] { new DateTime(2024, 8, 16, 16, 32, 4, 677, DateTimeKind.Utc).AddTicks(3126), new DateTime(2023, 9, 16, 10, 7, 8, 555, DateTimeKind.Local).AddTicks(4627) });

            migrationBuilder.UpdateData(
                table: "Book",
                keyColumn: "BookId",
                keyValue: 1475,
                columns: new[] { "CreatedDateTime", "PublicationDate" },
                values: new object[] { new DateTime(2024, 8, 16, 16, 32, 4, 677, DateTimeKind.Utc).AddTicks(3215), new DateTime(2023, 8, 23, 12, 6, 48, 990, DateTimeKind.Local).AddTicks(4003) });

            migrationBuilder.UpdateData(
                table: "Book",
                keyColumn: "BookId",
                keyValue: 1476,
                columns: new[] { "CreatedDateTime", "PublicationDate" },
                values: new object[] { new DateTime(2024, 8, 16, 16, 32, 4, 677, DateTimeKind.Utc).AddTicks(3341), new DateTime(2023, 11, 11, 5, 34, 47, 787, DateTimeKind.Local).AddTicks(7839) });

            migrationBuilder.UpdateData(
                table: "Book",
                keyColumn: "BookId",
                keyValue: 1477,
                columns: new[] { "CreatedDateTime", "PublicationDate" },
                values: new object[] { new DateTime(2024, 8, 16, 16, 32, 4, 677, DateTimeKind.Utc).AddTicks(3436), new DateTime(2024, 2, 20, 23, 33, 17, 716, DateTimeKind.Local).AddTicks(6585) });

            migrationBuilder.UpdateData(
                table: "Book",
                keyColumn: "BookId",
                keyValue: 1478,
                columns: new[] { "CreatedDateTime", "PublicationDate" },
                values: new object[] { new DateTime(2024, 8, 16, 16, 32, 4, 677, DateTimeKind.Utc).AddTicks(3552), new DateTime(2024, 5, 18, 3, 1, 13, 157, DateTimeKind.Local).AddTicks(1547) });

            migrationBuilder.UpdateData(
                table: "Book",
                keyColumn: "BookId",
                keyValue: 1479,
                columns: new[] { "CreatedDateTime", "PublicationDate" },
                values: new object[] { new DateTime(2024, 8, 16, 16, 32, 4, 677, DateTimeKind.Utc).AddTicks(3658), new DateTime(2023, 12, 3, 16, 35, 13, 769, DateTimeKind.Local).AddTicks(4835) });

            migrationBuilder.UpdateData(
                table: "Book",
                keyColumn: "BookId",
                keyValue: 1480,
                columns: new[] { "CreatedDateTime", "PublicationDate" },
                values: new object[] { new DateTime(2024, 8, 16, 16, 32, 4, 677, DateTimeKind.Utc).AddTicks(3782), new DateTime(2023, 12, 2, 3, 17, 52, 809, DateTimeKind.Local).AddTicks(9326) });

            migrationBuilder.UpdateData(
                table: "Book",
                keyColumn: "BookId",
                keyValue: 1481,
                columns: new[] { "CreatedDateTime", "PublicationDate" },
                values: new object[] { new DateTime(2024, 8, 16, 16, 32, 4, 677, DateTimeKind.Utc).AddTicks(3878), new DateTime(2024, 6, 14, 5, 8, 49, 874, DateTimeKind.Local).AddTicks(2606) });

            migrationBuilder.UpdateData(
                table: "Book",
                keyColumn: "BookId",
                keyValue: 1482,
                columns: new[] { "CreatedDateTime", "PublicationDate" },
                values: new object[] { new DateTime(2024, 8, 16, 16, 32, 4, 677, DateTimeKind.Utc).AddTicks(3988), new DateTime(2023, 12, 8, 5, 57, 2, 818, DateTimeKind.Local).AddTicks(7499) });

            migrationBuilder.UpdateData(
                table: "Book",
                keyColumn: "BookId",
                keyValue: 1483,
                columns: new[] { "CreatedDateTime", "PublicationDate" },
                values: new object[] { new DateTime(2024, 8, 16, 16, 32, 4, 677, DateTimeKind.Utc).AddTicks(4089), new DateTime(2024, 2, 16, 20, 26, 56, 136, DateTimeKind.Local).AddTicks(9761) });

            migrationBuilder.UpdateData(
                table: "Book",
                keyColumn: "BookId",
                keyValue: 1484,
                columns: new[] { "CreatedDateTime", "PublicationDate" },
                values: new object[] { new DateTime(2024, 8, 16, 16, 32, 4, 677, DateTimeKind.Utc).AddTicks(4229), new DateTime(2024, 1, 6, 1, 18, 25, 226, DateTimeKind.Local).AddTicks(6828) });

            migrationBuilder.UpdateData(
                table: "Book",
                keyColumn: "BookId",
                keyValue: 1485,
                columns: new[] { "CreatedDateTime", "PublicationDate" },
                values: new object[] { new DateTime(2024, 8, 16, 16, 32, 4, 677, DateTimeKind.Utc).AddTicks(4326), new DateTime(2023, 11, 25, 2, 56, 52, 375, DateTimeKind.Local).AddTicks(1037) });

            migrationBuilder.UpdateData(
                table: "Book",
                keyColumn: "BookId",
                keyValue: 1486,
                columns: new[] { "CreatedDateTime", "PublicationDate" },
                values: new object[] { new DateTime(2024, 8, 16, 16, 32, 4, 677, DateTimeKind.Utc).AddTicks(4450), new DateTime(2024, 4, 1, 15, 51, 40, 332, DateTimeKind.Local).AddTicks(9189) });

            migrationBuilder.UpdateData(
                table: "Book",
                keyColumn: "BookId",
                keyValue: 1487,
                columns: new[] { "CreatedDateTime", "PublicationDate" },
                values: new object[] { new DateTime(2024, 8, 16, 16, 32, 4, 677, DateTimeKind.Utc).AddTicks(4540), new DateTime(2024, 2, 26, 16, 47, 21, 981, DateTimeKind.Local).AddTicks(6359) });

            migrationBuilder.UpdateData(
                table: "Book",
                keyColumn: "BookId",
                keyValue: 1488,
                columns: new[] { "CreatedDateTime", "PublicationDate" },
                values: new object[] { new DateTime(2024, 8, 16, 16, 32, 4, 677, DateTimeKind.Utc).AddTicks(4672), new DateTime(2023, 11, 10, 6, 33, 39, 991, DateTimeKind.Local).AddTicks(3706) });

            migrationBuilder.UpdateData(
                table: "Book",
                keyColumn: "BookId",
                keyValue: 1489,
                columns: new[] { "CreatedDateTime", "PublicationDate" },
                values: new object[] { new DateTime(2024, 8, 16, 16, 32, 4, 677, DateTimeKind.Utc).AddTicks(4763), new DateTime(2024, 8, 2, 16, 57, 48, 322, DateTimeKind.Local).AddTicks(8995) });

            migrationBuilder.UpdateData(
                table: "Book",
                keyColumn: "BookId",
                keyValue: 1490,
                columns: new[] { "CreatedDateTime", "PublicationDate" },
                values: new object[] { new DateTime(2024, 8, 16, 16, 32, 4, 677, DateTimeKind.Utc).AddTicks(4888), new DateTime(2024, 7, 13, 1, 20, 21, 167, DateTimeKind.Local).AddTicks(3396) });

            migrationBuilder.UpdateData(
                table: "Book",
                keyColumn: "BookId",
                keyValue: 1491,
                columns: new[] { "CreatedDateTime", "PublicationDate" },
                values: new object[] { new DateTime(2024, 8, 16, 16, 32, 4, 677, DateTimeKind.Utc).AddTicks(4993), new DateTime(2024, 8, 12, 23, 20, 45, 700, DateTimeKind.Local).AddTicks(6158) });

            migrationBuilder.UpdateData(
                table: "Book",
                keyColumn: "BookId",
                keyValue: 1492,
                columns: new[] { "CreatedDateTime", "PublicationDate" },
                values: new object[] { new DateTime(2024, 8, 16, 16, 32, 4, 677, DateTimeKind.Utc).AddTicks(5116), new DateTime(2023, 10, 30, 8, 1, 26, 478, DateTimeKind.Local).AddTicks(9261) });

            migrationBuilder.UpdateData(
                table: "Book",
                keyColumn: "BookId",
                keyValue: 1493,
                columns: new[] { "CreatedDateTime", "PublicationDate" },
                values: new object[] { new DateTime(2024, 8, 16, 16, 32, 4, 677, DateTimeKind.Utc).AddTicks(5248), new DateTime(2023, 12, 26, 13, 52, 27, 2, DateTimeKind.Local).AddTicks(6144) });

            migrationBuilder.UpdateData(
                table: "Book",
                keyColumn: "BookId",
                keyValue: 1494,
                columns: new[] { "CreatedDateTime", "PublicationDate" },
                values: new object[] { new DateTime(2024, 8, 16, 16, 32, 4, 677, DateTimeKind.Utc).AddTicks(5341), new DateTime(2024, 1, 28, 10, 4, 47, 675, DateTimeKind.Local).AddTicks(157) });

            migrationBuilder.UpdateData(
                table: "Book",
                keyColumn: "BookId",
                keyValue: 1495,
                columns: new[] { "CreatedDateTime", "PublicationDate" },
                values: new object[] { new DateTime(2024, 8, 16, 16, 32, 4, 677, DateTimeKind.Utc).AddTicks(5425), new DateTime(2024, 1, 10, 6, 2, 37, 514, DateTimeKind.Local).AddTicks(8479) });

            migrationBuilder.UpdateData(
                table: "Book",
                keyColumn: "BookId",
                keyValue: 1496,
                columns: new[] { "CreatedDateTime", "PublicationDate" },
                values: new object[] { new DateTime(2024, 8, 16, 16, 32, 4, 677, DateTimeKind.Utc).AddTicks(5553), new DateTime(2024, 7, 18, 1, 4, 23, 972, DateTimeKind.Local).AddTicks(6359) });

            migrationBuilder.UpdateData(
                table: "Book",
                keyColumn: "BookId",
                keyValue: 1497,
                columns: new[] { "CreatedDateTime", "PublicationDate" },
                values: new object[] { new DateTime(2024, 8, 16, 16, 32, 4, 677, DateTimeKind.Utc).AddTicks(5640), new DateTime(2024, 5, 24, 13, 58, 32, 856, DateTimeKind.Local).AddTicks(7987) });

            migrationBuilder.UpdateData(
                table: "Book",
                keyColumn: "BookId",
                keyValue: 1498,
                columns: new[] { "CreatedDateTime", "PublicationDate" },
                values: new object[] { new DateTime(2024, 8, 16, 16, 32, 4, 677, DateTimeKind.Utc).AddTicks(5771), new DateTime(2024, 2, 14, 20, 32, 46, 368, DateTimeKind.Local).AddTicks(9991) });

            migrationBuilder.UpdateData(
                table: "Book",
                keyColumn: "BookId",
                keyValue: 1499,
                columns: new[] { "CreatedDateTime", "PublicationDate" },
                values: new object[] { new DateTime(2024, 8, 16, 16, 32, 4, 677, DateTimeKind.Utc).AddTicks(5895), new DateTime(2024, 6, 29, 11, 49, 24, 909, DateTimeKind.Local).AddTicks(2227) });

            migrationBuilder.UpdateData(
                table: "Book",
                keyColumn: "BookId",
                keyValue: 1500,
                columns: new[] { "CreatedDateTime", "PublicationDate" },
                values: new object[] { new DateTime(2024, 8, 16, 16, 32, 4, 677, DateTimeKind.Utc).AddTicks(5992), new DateTime(2024, 3, 12, 9, 45, 58, 949, DateTimeKind.Local).AddTicks(6837) });

            migrationBuilder.UpdateData(
                table: "Book",
                keyColumn: "BookId",
                keyValue: 1501,
                columns: new[] { "CreatedDateTime", "PublicationDate" },
                values: new object[] { new DateTime(2024, 8, 16, 16, 32, 4, 677, DateTimeKind.Utc).AddTicks(6117), new DateTime(2023, 9, 3, 7, 1, 27, 410, DateTimeKind.Local).AddTicks(6758) });

            migrationBuilder.UpdateData(
                table: "Book",
                keyColumn: "BookId",
                keyValue: 1502,
                columns: new[] { "CreatedDateTime", "PublicationDate" },
                values: new object[] { new DateTime(2024, 8, 16, 16, 32, 4, 677, DateTimeKind.Utc).AddTicks(6214), new DateTime(2023, 11, 1, 15, 32, 18, 299, DateTimeKind.Local).AddTicks(8918) });

            migrationBuilder.UpdateData(
                table: "Book",
                keyColumn: "BookId",
                keyValue: 1503,
                columns: new[] { "CreatedDateTime", "PublicationDate" },
                values: new object[] { new DateTime(2024, 8, 16, 16, 32, 4, 677, DateTimeKind.Utc).AddTicks(6336), new DateTime(2023, 9, 21, 11, 8, 35, 552, DateTimeKind.Local).AddTicks(6046) });

            migrationBuilder.UpdateData(
                table: "Book",
                keyColumn: "BookId",
                keyValue: 1504,
                columns: new[] { "CreatedDateTime", "PublicationDate" },
                values: new object[] { new DateTime(2024, 8, 16, 16, 32, 4, 677, DateTimeKind.Utc).AddTicks(6426), new DateTime(2023, 11, 28, 9, 38, 35, 248, DateTimeKind.Local).AddTicks(2098) });

            migrationBuilder.UpdateData(
                table: "Book",
                keyColumn: "BookId",
                keyValue: 1505,
                columns: new[] { "CreatedDateTime", "PublicationDate" },
                values: new object[] { new DateTime(2024, 8, 16, 16, 32, 4, 677, DateTimeKind.Utc).AddTicks(6541), new DateTime(2023, 12, 29, 3, 0, 35, 443, DateTimeKind.Local).AddTicks(5948) });

            migrationBuilder.UpdateData(
                table: "Book",
                keyColumn: "BookId",
                keyValue: 1506,
                columns: new[] { "CreatedDateTime", "PublicationDate" },
                values: new object[] { new DateTime(2024, 8, 16, 16, 32, 4, 677, DateTimeKind.Utc).AddTicks(6629), new DateTime(2024, 3, 18, 10, 17, 45, 350, DateTimeKind.Local).AddTicks(2717) });

            migrationBuilder.UpdateData(
                table: "Book",
                keyColumn: "BookId",
                keyValue: 1507,
                columns: new[] { "CreatedDateTime", "PublicationDate" },
                values: new object[] { new DateTime(2024, 8, 16, 16, 32, 4, 677, DateTimeKind.Utc).AddTicks(6763), new DateTime(2024, 2, 22, 19, 0, 22, 514, DateTimeKind.Local).AddTicks(9556) });

            migrationBuilder.UpdateData(
                table: "Book",
                keyColumn: "BookId",
                keyValue: 1508,
                columns: new[] { "CreatedDateTime", "PublicationDate" },
                values: new object[] { new DateTime(2024, 8, 16, 16, 32, 4, 677, DateTimeKind.Utc).AddTicks(6869), new DateTime(2023, 12, 21, 22, 54, 1, 505, DateTimeKind.Local).AddTicks(775) });

            migrationBuilder.UpdateData(
                table: "Book",
                keyColumn: "BookId",
                keyValue: 1509,
                columns: new[] { "CreatedDateTime", "PublicationDate" },
                values: new object[] { new DateTime(2024, 8, 16, 16, 32, 4, 677, DateTimeKind.Utc).AddTicks(6983), new DateTime(2023, 9, 20, 23, 24, 12, 537, DateTimeKind.Local).AddTicks(4691) });

            migrationBuilder.UpdateData(
                table: "Book",
                keyColumn: "BookId",
                keyValue: 1510,
                columns: new[] { "CreatedDateTime", "PublicationDate" },
                values: new object[] { new DateTime(2024, 8, 16, 16, 32, 4, 677, DateTimeKind.Utc).AddTicks(7075), new DateTime(2023, 8, 27, 0, 59, 52, 403, DateTimeKind.Local).AddTicks(3120) });

            migrationBuilder.UpdateData(
                table: "Book",
                keyColumn: "BookId",
                keyValue: 1511,
                columns: new[] { "CreatedDateTime", "PublicationDate" },
                values: new object[] { new DateTime(2024, 8, 16, 16, 32, 4, 677, DateTimeKind.Utc).AddTicks(7187), new DateTime(2024, 6, 3, 23, 55, 45, 47, DateTimeKind.Local).AddTicks(9657) });

            migrationBuilder.UpdateData(
                table: "Book",
                keyColumn: "BookId",
                keyValue: 1512,
                columns: new[] { "CreatedDateTime", "PublicationDate" },
                values: new object[] { new DateTime(2024, 8, 16, 16, 32, 4, 677, DateTimeKind.Utc).AddTicks(7280), new DateTime(2024, 5, 31, 2, 10, 42, 87, DateTimeKind.Local).AddTicks(8673) });

            migrationBuilder.UpdateData(
                table: "Book",
                keyColumn: "BookId",
                keyValue: 1513,
                columns: new[] { "CreatedDateTime", "PublicationDate" },
                values: new object[] { new DateTime(2024, 8, 16, 16, 32, 4, 677, DateTimeKind.Utc).AddTicks(7386), new DateTime(2023, 10, 14, 9, 27, 19, 114, DateTimeKind.Local).AddTicks(7352) });

            migrationBuilder.UpdateData(
                table: "Book",
                keyColumn: "BookId",
                keyValue: 1514,
                columns: new[] { "CreatedDateTime", "PublicationDate" },
                values: new object[] { new DateTime(2024, 8, 16, 16, 32, 4, 677, DateTimeKind.Utc).AddTicks(7483), new DateTime(2024, 3, 20, 11, 16, 44, 799, DateTimeKind.Local).AddTicks(344) });

            migrationBuilder.UpdateData(
                table: "Book",
                keyColumn: "BookId",
                keyValue: 1515,
                columns: new[] { "CreatedDateTime", "PublicationDate" },
                values: new object[] { new DateTime(2024, 8, 16, 16, 32, 4, 677, DateTimeKind.Utc).AddTicks(7617), new DateTime(2023, 12, 6, 3, 12, 5, 401, DateTimeKind.Local).AddTicks(557) });

            migrationBuilder.UpdateData(
                table: "Book",
                keyColumn: "BookId",
                keyValue: 1516,
                columns: new[] { "CreatedDateTime", "PublicationDate" },
                values: new object[] { new DateTime(2024, 8, 16, 16, 32, 4, 677, DateTimeKind.Utc).AddTicks(7715), new DateTime(2024, 4, 21, 20, 32, 52, 787, DateTimeKind.Local).AddTicks(7072) });

            migrationBuilder.UpdateData(
                table: "Book",
                keyColumn: "BookId",
                keyValue: 1517,
                columns: new[] { "CreatedDateTime", "PublicationDate" },
                values: new object[] { new DateTime(2024, 8, 16, 16, 32, 4, 677, DateTimeKind.Utc).AddTicks(7847), new DateTime(2024, 6, 14, 15, 38, 25, 905, DateTimeKind.Local).AddTicks(8637) });

            migrationBuilder.UpdateData(
                table: "Book",
                keyColumn: "BookId",
                keyValue: 1518,
                columns: new[] { "CreatedDateTime", "PublicationDate" },
                values: new object[] { new DateTime(2024, 8, 16, 16, 32, 4, 677, DateTimeKind.Utc).AddTicks(7940), new DateTime(2023, 11, 29, 14, 8, 59, 103, DateTimeKind.Local).AddTicks(8439) });

            migrationBuilder.UpdateData(
                table: "Book",
                keyColumn: "BookId",
                keyValue: 1519,
                columns: new[] { "CreatedDateTime", "PublicationDate" },
                values: new object[] { new DateTime(2024, 8, 16, 16, 32, 4, 677, DateTimeKind.Utc).AddTicks(8074), new DateTime(2023, 10, 17, 0, 10, 1, 356, DateTimeKind.Local).AddTicks(8686) });

            migrationBuilder.UpdateData(
                table: "Book",
                keyColumn: "BookId",
                keyValue: 1520,
                columns: new[] { "CreatedDateTime", "PublicationDate" },
                values: new object[] { new DateTime(2024, 8, 16, 16, 32, 4, 677, DateTimeKind.Utc).AddTicks(8171), new DateTime(2024, 1, 4, 1, 28, 33, 549, DateTimeKind.Local).AddTicks(7505) });

            migrationBuilder.UpdateData(
                table: "Book",
                keyColumn: "BookId",
                keyValue: 1521,
                columns: new[] { "CreatedDateTime", "PublicationDate" },
                values: new object[] { new DateTime(2024, 8, 16, 16, 32, 4, 677, DateTimeKind.Utc).AddTicks(8290), new DateTime(2024, 1, 17, 7, 22, 58, 431, DateTimeKind.Local).AddTicks(1298) });

            migrationBuilder.UpdateData(
                table: "Book",
                keyColumn: "BookId",
                keyValue: 1522,
                columns: new[] { "CreatedDateTime", "PublicationDate" },
                values: new object[] { new DateTime(2024, 8, 16, 16, 32, 4, 677, DateTimeKind.Utc).AddTicks(8419), new DateTime(2024, 6, 7, 1, 51, 35, 417, DateTimeKind.Local).AddTicks(7556) });

            migrationBuilder.UpdateData(
                table: "Book",
                keyColumn: "BookId",
                keyValue: 1523,
                columns: new[] { "CreatedDateTime", "PublicationDate" },
                values: new object[] { new DateTime(2024, 8, 16, 16, 32, 4, 677, DateTimeKind.Utc).AddTicks(8511), new DateTime(2024, 3, 27, 13, 37, 37, 908, DateTimeKind.Local).AddTicks(5921) });

            migrationBuilder.UpdateData(
                table: "Book",
                keyColumn: "BookId",
                keyValue: 1524,
                columns: new[] { "CreatedDateTime", "PublicationDate" },
                values: new object[] { new DateTime(2024, 8, 16, 16, 32, 4, 677, DateTimeKind.Utc).AddTicks(8650), new DateTime(2023, 10, 25, 4, 10, 43, 85, DateTimeKind.Local).AddTicks(3999) });

            migrationBuilder.UpdateData(
                table: "Book",
                keyColumn: "BookId",
                keyValue: 1525,
                columns: new[] { "CreatedDateTime", "PublicationDate" },
                values: new object[] { new DateTime(2024, 8, 16, 16, 32, 4, 677, DateTimeKind.Utc).AddTicks(8748), new DateTime(2024, 4, 25, 5, 13, 32, 246, DateTimeKind.Local).AddTicks(5032) });

            migrationBuilder.UpdateData(
                table: "Book",
                keyColumn: "BookId",
                keyValue: 1526,
                columns: new[] { "CreatedDateTime", "PublicationDate" },
                values: new object[] { new DateTime(2024, 8, 16, 16, 32, 4, 677, DateTimeKind.Utc).AddTicks(8876), new DateTime(2023, 12, 4, 17, 23, 15, 153, DateTimeKind.Local).AddTicks(4909) });

            migrationBuilder.UpdateData(
                table: "Book",
                keyColumn: "BookId",
                keyValue: 1527,
                columns: new[] { "CreatedDateTime", "PublicationDate" },
                values: new object[] { new DateTime(2024, 8, 16, 16, 32, 4, 677, DateTimeKind.Utc).AddTicks(8999), new DateTime(2024, 7, 29, 21, 5, 47, 451, DateTimeKind.Local).AddTicks(4735) });

            migrationBuilder.UpdateData(
                table: "Book",
                keyColumn: "BookId",
                keyValue: 1528,
                columns: new[] { "CreatedDateTime", "PublicationDate" },
                values: new object[] { new DateTime(2024, 8, 16, 16, 32, 4, 677, DateTimeKind.Utc).AddTicks(9098), new DateTime(2024, 6, 22, 10, 8, 41, 99, DateTimeKind.Local).AddTicks(2761) });

            migrationBuilder.UpdateData(
                table: "Book",
                keyColumn: "BookId",
                keyValue: 1529,
                columns: new[] { "CreatedDateTime", "PublicationDate" },
                values: new object[] { new DateTime(2024, 8, 16, 16, 32, 4, 677, DateTimeKind.Utc).AddTicks(9232), new DateTime(2024, 6, 13, 5, 4, 17, 745, DateTimeKind.Local).AddTicks(7128) });

            migrationBuilder.UpdateData(
                table: "Book",
                keyColumn: "BookId",
                keyValue: 1530,
                columns: new[] { "CreatedDateTime", "PublicationDate" },
                values: new object[] { new DateTime(2024, 8, 16, 16, 32, 4, 677, DateTimeKind.Utc).AddTicks(9321), new DateTime(2023, 11, 8, 0, 35, 34, 388, DateTimeKind.Local).AddTicks(9573) });

            migrationBuilder.UpdateData(
                table: "Book",
                keyColumn: "BookId",
                keyValue: 1531,
                columns: new[] { "CreatedDateTime", "PublicationDate" },
                values: new object[] { new DateTime(2024, 8, 16, 16, 32, 4, 677, DateTimeKind.Utc).AddTicks(9469), new DateTime(2024, 7, 22, 16, 21, 45, 58, DateTimeKind.Local).AddTicks(5352) });

            migrationBuilder.UpdateData(
                table: "Book",
                keyColumn: "BookId",
                keyValue: 1532,
                columns: new[] { "CreatedDateTime", "PublicationDate" },
                values: new object[] { new DateTime(2024, 8, 16, 16, 32, 4, 677, DateTimeKind.Utc).AddTicks(9559), new DateTime(2023, 8, 21, 11, 18, 52, 903, DateTimeKind.Local).AddTicks(6362) });

            migrationBuilder.UpdateData(
                table: "Book",
                keyColumn: "BookId",
                keyValue: 1533,
                columns: new[] { "CreatedDateTime", "PublicationDate" },
                values: new object[] { new DateTime(2024, 8, 16, 16, 32, 4, 677, DateTimeKind.Utc).AddTicks(9688), new DateTime(2024, 1, 19, 23, 0, 46, 936, DateTimeKind.Local).AddTicks(3908) });

            migrationBuilder.UpdateData(
                table: "Book",
                keyColumn: "BookId",
                keyValue: 1534,
                columns: new[] { "CreatedDateTime", "PublicationDate" },
                values: new object[] { new DateTime(2024, 8, 16, 16, 32, 4, 677, DateTimeKind.Utc).AddTicks(9778), new DateTime(2024, 4, 28, 16, 44, 20, 627, DateTimeKind.Local).AddTicks(6007) });

            migrationBuilder.UpdateData(
                table: "Book",
                keyColumn: "BookId",
                keyValue: 1535,
                columns: new[] { "CreatedDateTime", "PublicationDate" },
                values: new object[] { new DateTime(2024, 8, 16, 16, 32, 4, 677, DateTimeKind.Utc).AddTicks(9906), new DateTime(2023, 8, 23, 11, 9, 45, 808, DateTimeKind.Local).AddTicks(9084) });

            migrationBuilder.UpdateData(
                table: "Book",
                keyColumn: "BookId",
                keyValue: 1536,
                columns: new[] { "CreatedDateTime", "PublicationDate" },
                values: new object[] { new DateTime(2024, 8, 16, 16, 32, 4, 678, DateTimeKind.Utc).AddTicks(5), new DateTime(2024, 7, 5, 21, 23, 25, 168, DateTimeKind.Local).AddTicks(9532) });

            migrationBuilder.UpdateData(
                table: "Book",
                keyColumn: "BookId",
                keyValue: 1537,
                columns: new[] { "CreatedDateTime", "PublicationDate" },
                values: new object[] { new DateTime(2024, 8, 16, 16, 32, 4, 678, DateTimeKind.Utc).AddTicks(120), new DateTime(2024, 4, 29, 10, 42, 21, 393, DateTimeKind.Local).AddTicks(646) });

            migrationBuilder.UpdateData(
                table: "Book",
                keyColumn: "BookId",
                keyValue: 1538,
                columns: new[] { "CreatedDateTime", "PublicationDate" },
                values: new object[] { new DateTime(2024, 8, 16, 16, 32, 4, 678, DateTimeKind.Utc).AddTicks(218), new DateTime(2024, 6, 10, 21, 51, 29, 429, DateTimeKind.Local).AddTicks(2844) });

            migrationBuilder.UpdateData(
                table: "Book",
                keyColumn: "BookId",
                keyValue: 1539,
                columns: new[] { "CreatedDateTime", "PublicationDate" },
                values: new object[] { new DateTime(2024, 8, 16, 16, 32, 4, 678, DateTimeKind.Utc).AddTicks(352), new DateTime(2024, 8, 14, 22, 50, 26, 73, DateTimeKind.Local).AddTicks(380) });

            migrationBuilder.UpdateData(
                table: "Book",
                keyColumn: "BookId",
                keyValue: 1540,
                columns: new[] { "CreatedDateTime", "PublicationDate" },
                values: new object[] { new DateTime(2024, 8, 16, 16, 32, 4, 678, DateTimeKind.Utc).AddTicks(450), new DateTime(2023, 11, 17, 18, 13, 16, 148, DateTimeKind.Local).AddTicks(7997) });

            migrationBuilder.UpdateData(
                table: "Book",
                keyColumn: "BookId",
                keyValue: 1541,
                columns: new[] { "CreatedDateTime", "PublicationDate" },
                values: new object[] { new DateTime(2024, 8, 16, 16, 32, 4, 678, DateTimeKind.Utc).AddTicks(568), new DateTime(2023, 10, 4, 23, 18, 29, 670, DateTimeKind.Local).AddTicks(836) });

            migrationBuilder.UpdateData(
                table: "Book",
                keyColumn: "BookId",
                keyValue: 1542,
                columns: new[] { "CreatedDateTime", "PublicationDate" },
                values: new object[] { new DateTime(2024, 8, 16, 16, 32, 4, 678, DateTimeKind.Utc).AddTicks(660), new DateTime(2023, 12, 17, 6, 49, 44, 790, DateTimeKind.Local).AddTicks(779) });

            migrationBuilder.UpdateData(
                table: "Book",
                keyColumn: "BookId",
                keyValue: 1543,
                columns: new[] { "CreatedDateTime", "PublicationDate" },
                values: new object[] { new DateTime(2024, 8, 16, 16, 32, 4, 678, DateTimeKind.Utc).AddTicks(770), new DateTime(2023, 12, 26, 7, 33, 0, 262, DateTimeKind.Local).AddTicks(6778) });

            migrationBuilder.UpdateData(
                table: "Book",
                keyColumn: "BookId",
                keyValue: 1544,
                columns: new[] { "CreatedDateTime", "PublicationDate" },
                values: new object[] { new DateTime(2024, 8, 16, 16, 32, 4, 678, DateTimeKind.Utc).AddTicks(911), new DateTime(2024, 4, 28, 19, 51, 4, 186, DateTimeKind.Local).AddTicks(9842) });

            migrationBuilder.UpdateData(
                table: "Book",
                keyColumn: "BookId",
                keyValue: 1545,
                columns: new[] { "CreatedDateTime", "PublicationDate" },
                values: new object[] { new DateTime(2024, 8, 16, 16, 32, 4, 678, DateTimeKind.Utc).AddTicks(1011), new DateTime(2024, 7, 6, 20, 10, 42, 619, DateTimeKind.Local).AddTicks(1092) });

            migrationBuilder.UpdateData(
                table: "Book",
                keyColumn: "BookId",
                keyValue: 1546,
                columns: new[] { "CreatedDateTime", "PublicationDate" },
                values: new object[] { new DateTime(2024, 8, 16, 16, 32, 4, 678, DateTimeKind.Utc).AddTicks(1140), new DateTime(2023, 10, 20, 9, 34, 41, 523, DateTimeKind.Local).AddTicks(5746) });

            migrationBuilder.UpdateData(
                table: "Book",
                keyColumn: "BookId",
                keyValue: 1547,
                columns: new[] { "CreatedDateTime", "PublicationDate" },
                values: new object[] { new DateTime(2024, 8, 16, 16, 32, 4, 678, DateTimeKind.Utc).AddTicks(1240), new DateTime(2024, 3, 18, 7, 16, 53, 918, DateTimeKind.Local).AddTicks(2151) });

            migrationBuilder.UpdateData(
                table: "Book",
                keyColumn: "BookId",
                keyValue: 1548,
                columns: new[] { "CreatedDateTime", "PublicationDate" },
                values: new object[] { new DateTime(2024, 8, 16, 16, 32, 4, 678, DateTimeKind.Utc).AddTicks(1360), new DateTime(2024, 6, 2, 17, 51, 49, 149, DateTimeKind.Local).AddTicks(7136) });

            migrationBuilder.UpdateData(
                table: "Book",
                keyColumn: "BookId",
                keyValue: 1549,
                columns: new[] { "CreatedDateTime", "PublicationDate" },
                values: new object[] { new DateTime(2024, 8, 16, 16, 32, 4, 678, DateTimeKind.Utc).AddTicks(1461), new DateTime(2024, 1, 2, 20, 7, 54, 889, DateTimeKind.Local).AddTicks(9483) });

            migrationBuilder.UpdateData(
                table: "Book",
                keyColumn: "BookId",
                keyValue: 1550,
                columns: new[] { "CreatedDateTime", "PublicationDate" },
                values: new object[] { new DateTime(2024, 8, 16, 16, 32, 4, 678, DateTimeKind.Utc).AddTicks(1583), new DateTime(2023, 10, 28, 8, 34, 23, 889, DateTimeKind.Local).AddTicks(5674) });

            migrationBuilder.UpdateData(
                table: "Book",
                keyColumn: "BookId",
                keyValue: 1551,
                columns: new[] { "CreatedDateTime", "PublicationDate" },
                values: new object[] { new DateTime(2024, 8, 16, 16, 32, 4, 678, DateTimeKind.Utc).AddTicks(1675), new DateTime(2024, 3, 13, 12, 12, 51, 121, DateTimeKind.Local).AddTicks(3673) });

            migrationBuilder.UpdateData(
                table: "Book",
                keyColumn: "BookId",
                keyValue: 1552,
                columns: new[] { "CreatedDateTime", "PublicationDate" },
                values: new object[] { new DateTime(2024, 8, 16, 16, 32, 4, 678, DateTimeKind.Utc).AddTicks(1794), new DateTime(2023, 11, 3, 22, 27, 40, 838, DateTimeKind.Local).AddTicks(9448) });

            migrationBuilder.UpdateData(
                table: "Book",
                keyColumn: "BookId",
                keyValue: 1553,
                columns: new[] { "CreatedDateTime", "PublicationDate" },
                values: new object[] { new DateTime(2024, 8, 16, 16, 32, 4, 678, DateTimeKind.Utc).AddTicks(1890), new DateTime(2024, 7, 14, 16, 0, 54, 146, DateTimeKind.Local).AddTicks(1524) });

            migrationBuilder.UpdateData(
                table: "Book",
                keyColumn: "BookId",
                keyValue: 1554,
                columns: new[] { "CreatedDateTime", "PublicationDate" },
                values: new object[] { new DateTime(2024, 8, 16, 16, 32, 4, 678, DateTimeKind.Utc).AddTicks(2012), new DateTime(2024, 8, 4, 10, 47, 34, 87, DateTimeKind.Local).AddTicks(4745) });

            migrationBuilder.UpdateData(
                table: "Book",
                keyColumn: "BookId",
                keyValue: 1555,
                columns: new[] { "CreatedDateTime", "PublicationDate" },
                values: new object[] { new DateTime(2024, 8, 16, 16, 32, 4, 678, DateTimeKind.Utc).AddTicks(2111), new DateTime(2024, 5, 23, 21, 18, 42, 270, DateTimeKind.Local).AddTicks(7987) });

            migrationBuilder.UpdateData(
                table: "Book",
                keyColumn: "BookId",
                keyValue: 1556,
                columns: new[] { "CreatedDateTime", "PublicationDate" },
                values: new object[] { new DateTime(2024, 8, 16, 16, 32, 4, 678, DateTimeKind.Utc).AddTicks(2225), new DateTime(2024, 8, 10, 17, 44, 52, 166, DateTimeKind.Local).AddTicks(3027) });

            migrationBuilder.UpdateData(
                table: "Book",
                keyColumn: "BookId",
                keyValue: 1557,
                columns: new[] { "CreatedDateTime", "PublicationDate" },
                values: new object[] { new DateTime(2024, 8, 16, 16, 32, 4, 678, DateTimeKind.Utc).AddTicks(2311), new DateTime(2024, 7, 30, 15, 46, 23, 385, DateTimeKind.Local).AddTicks(5193) });

            migrationBuilder.UpdateData(
                table: "Book",
                keyColumn: "BookId",
                keyValue: 1558,
                columns: new[] { "CreatedDateTime", "PublicationDate" },
                values: new object[] { new DateTime(2024, 8, 16, 16, 32, 4, 678, DateTimeKind.Utc).AddTicks(2450), new DateTime(2024, 1, 6, 13, 52, 36, 718, DateTimeKind.Local).AddTicks(4697) });

            migrationBuilder.UpdateData(
                table: "Book",
                keyColumn: "BookId",
                keyValue: 1559,
                columns: new[] { "CreatedDateTime", "PublicationDate" },
                values: new object[] { new DateTime(2024, 8, 16, 16, 32, 4, 678, DateTimeKind.Utc).AddTicks(2540), new DateTime(2024, 2, 19, 21, 44, 19, 210, DateTimeKind.Local).AddTicks(6453) });

            migrationBuilder.UpdateData(
                table: "Book",
                keyColumn: "BookId",
                keyValue: 1560,
                columns: new[] { "CreatedDateTime", "PublicationDate" },
                values: new object[] { new DateTime(2024, 8, 16, 16, 32, 4, 678, DateTimeKind.Utc).AddTicks(2656), new DateTime(2024, 3, 2, 1, 59, 2, 653, DateTimeKind.Local).AddTicks(9353) });

            migrationBuilder.UpdateData(
                table: "Book",
                keyColumn: "BookId",
                keyValue: 1561,
                columns: new[] { "CreatedDateTime", "PublicationDate" },
                values: new object[] { new DateTime(2024, 8, 16, 16, 32, 4, 678, DateTimeKind.Utc).AddTicks(2750), new DateTime(2024, 5, 26, 1, 53, 56, 971, DateTimeKind.Local).AddTicks(3133) });

            migrationBuilder.UpdateData(
                table: "Book",
                keyColumn: "BookId",
                keyValue: 1562,
                columns: new[] { "CreatedDateTime", "PublicationDate" },
                values: new object[] { new DateTime(2024, 8, 16, 16, 32, 4, 678, DateTimeKind.Utc).AddTicks(2854), new DateTime(2023, 11, 4, 17, 14, 9, 370, DateTimeKind.Local).AddTicks(7292) });

            migrationBuilder.UpdateData(
                table: "Book",
                keyColumn: "BookId",
                keyValue: 1563,
                columns: new[] { "CreatedDateTime", "PublicationDate" },
                values: new object[] { new DateTime(2024, 8, 16, 16, 32, 4, 678, DateTimeKind.Utc).AddTicks(2958), new DateTime(2023, 10, 2, 9, 9, 38, 890, DateTimeKind.Local).AddTicks(2665) });

            migrationBuilder.UpdateData(
                table: "Book",
                keyColumn: "BookId",
                keyValue: 1564,
                columns: new[] { "CreatedDateTime", "PublicationDate" },
                values: new object[] { new DateTime(2024, 8, 16, 16, 32, 4, 678, DateTimeKind.Utc).AddTicks(3079), new DateTime(2024, 6, 26, 0, 7, 57, 125, DateTimeKind.Local).AddTicks(7764) });

            migrationBuilder.UpdateData(
                table: "Book",
                keyColumn: "BookId",
                keyValue: 1565,
                columns: new[] { "CreatedDateTime", "PublicationDate" },
                values: new object[] { new DateTime(2024, 8, 16, 16, 32, 4, 678, DateTimeKind.Utc).AddTicks(3182), new DateTime(2024, 7, 29, 7, 34, 54, 631, DateTimeKind.Local).AddTicks(1588) });

            migrationBuilder.UpdateData(
                table: "Book",
                keyColumn: "BookId",
                keyValue: 1566,
                columns: new[] { "CreatedDateTime", "PublicationDate" },
                values: new object[] { new DateTime(2024, 8, 16, 16, 32, 4, 678, DateTimeKind.Utc).AddTicks(3329), new DateTime(2023, 8, 21, 14, 39, 35, 851, DateTimeKind.Local).AddTicks(1257) });

            migrationBuilder.UpdateData(
                table: "Book",
                keyColumn: "BookId",
                keyValue: 1567,
                columns: new[] { "CreatedDateTime", "PublicationDate" },
                values: new object[] { new DateTime(2024, 8, 16, 16, 32, 4, 678, DateTimeKind.Utc).AddTicks(3421), new DateTime(2024, 5, 24, 15, 53, 9, 202, DateTimeKind.Local).AddTicks(6598) });

            migrationBuilder.UpdateData(
                table: "Book",
                keyColumn: "BookId",
                keyValue: 1568,
                columns: new[] { "CreatedDateTime", "PublicationDate" },
                values: new object[] { new DateTime(2024, 8, 16, 16, 32, 4, 678, DateTimeKind.Utc).AddTicks(3548), new DateTime(2023, 10, 5, 12, 6, 18, 991, DateTimeKind.Local).AddTicks(3123) });

            migrationBuilder.UpdateData(
                table: "Book",
                keyColumn: "BookId",
                keyValue: 1569,
                columns: new[] { "CreatedDateTime", "PublicationDate" },
                values: new object[] { new DateTime(2024, 8, 16, 16, 32, 4, 678, DateTimeKind.Utc).AddTicks(3673), new DateTime(2023, 10, 1, 11, 21, 51, 551, DateTimeKind.Local).AddTicks(7583) });

            migrationBuilder.UpdateData(
                table: "Book",
                keyColumn: "BookId",
                keyValue: 1570,
                columns: new[] { "CreatedDateTime", "PublicationDate" },
                values: new object[] { new DateTime(2024, 8, 16, 16, 32, 4, 678, DateTimeKind.Utc).AddTicks(3775), new DateTime(2024, 8, 14, 13, 12, 12, 966, DateTimeKind.Local).AddTicks(1879) });

            migrationBuilder.UpdateData(
                table: "Book",
                keyColumn: "BookId",
                keyValue: 1571,
                columns: new[] { "CreatedDateTime", "PublicationDate" },
                values: new object[] { new DateTime(2024, 8, 16, 16, 32, 4, 678, DateTimeKind.Utc).AddTicks(3894), new DateTime(2024, 6, 11, 16, 26, 20, 348, DateTimeKind.Local).AddTicks(9365) });

            migrationBuilder.UpdateData(
                table: "Book",
                keyColumn: "BookId",
                keyValue: 1572,
                columns: new[] { "CreatedDateTime", "PublicationDate" },
                values: new object[] { new DateTime(2024, 8, 16, 16, 32, 4, 678, DateTimeKind.Utc).AddTicks(3997), new DateTime(2023, 8, 30, 9, 30, 43, 335, DateTimeKind.Local).AddTicks(5348) });

            migrationBuilder.UpdateData(
                table: "Book",
                keyColumn: "BookId",
                keyValue: 1573,
                columns: new[] { "CreatedDateTime", "PublicationDate" },
                values: new object[] { new DateTime(2024, 8, 16, 16, 32, 4, 678, DateTimeKind.Utc).AddTicks(4125), new DateTime(2023, 11, 27, 20, 3, 38, 576, DateTimeKind.Local).AddTicks(8155) });

            migrationBuilder.UpdateData(
                table: "Book",
                keyColumn: "BookId",
                keyValue: 1574,
                columns: new[] { "CreatedDateTime", "PublicationDate" },
                values: new object[] { new DateTime(2024, 8, 16, 16, 32, 4, 678, DateTimeKind.Utc).AddTicks(4210), new DateTime(2023, 8, 25, 7, 1, 44, 256, DateTimeKind.Local).AddTicks(1732) });

            migrationBuilder.UpdateData(
                table: "Book",
                keyColumn: "BookId",
                keyValue: 1575,
                columns: new[] { "CreatedDateTime", "PublicationDate" },
                values: new object[] { new DateTime(2024, 8, 16, 16, 32, 4, 678, DateTimeKind.Utc).AddTicks(4330), new DateTime(2024, 1, 9, 14, 47, 18, 655, DateTimeKind.Local).AddTicks(8390) });

            migrationBuilder.UpdateData(
                table: "Book",
                keyColumn: "BookId",
                keyValue: 1576,
                columns: new[] { "CreatedDateTime", "PublicationDate" },
                values: new object[] { new DateTime(2024, 8, 16, 16, 32, 4, 678, DateTimeKind.Utc).AddTicks(4441), new DateTime(2023, 11, 9, 11, 53, 36, 483, DateTimeKind.Local).AddTicks(8107) });

            migrationBuilder.UpdateData(
                table: "Book",
                keyColumn: "BookId",
                keyValue: 1577,
                columns: new[] { "CreatedDateTime", "PublicationDate" },
                values: new object[] { new DateTime(2024, 8, 16, 16, 32, 4, 678, DateTimeKind.Utc).AddTicks(4560), new DateTime(2023, 10, 3, 14, 39, 29, 161, DateTimeKind.Local).AddTicks(3241) });

            migrationBuilder.UpdateData(
                table: "Book",
                keyColumn: "BookId",
                keyValue: 1578,
                columns: new[] { "CreatedDateTime", "PublicationDate" },
                values: new object[] { new DateTime(2024, 8, 16, 16, 32, 4, 678, DateTimeKind.Utc).AddTicks(4660), new DateTime(2023, 12, 22, 7, 46, 41, 327, DateTimeKind.Local).AddTicks(2097) });

            migrationBuilder.UpdateData(
                table: "Book",
                keyColumn: "BookId",
                keyValue: 1579,
                columns: new[] { "CreatedDateTime", "PublicationDate" },
                values: new object[] { new DateTime(2024, 8, 16, 16, 32, 4, 678, DateTimeKind.Utc).AddTicks(4783), new DateTime(2024, 1, 5, 20, 1, 17, 144, DateTimeKind.Local).AddTicks(8193) });

            migrationBuilder.UpdateData(
                table: "Book",
                keyColumn: "BookId",
                keyValue: 1580,
                columns: new[] { "CreatedDateTime", "PublicationDate" },
                values: new object[] { new DateTime(2024, 8, 16, 16, 32, 4, 678, DateTimeKind.Utc).AddTicks(4881), new DateTime(2023, 10, 3, 4, 16, 4, 547, DateTimeKind.Local).AddTicks(874) });

            migrationBuilder.UpdateData(
                table: "Book",
                keyColumn: "BookId",
                keyValue: 1581,
                columns: new[] { "CreatedDateTime", "PublicationDate" },
                values: new object[] { new DateTime(2024, 8, 16, 16, 32, 4, 678, DateTimeKind.Utc).AddTicks(5014), new DateTime(2024, 4, 21, 3, 1, 19, 413, DateTimeKind.Local).AddTicks(3055) });

            migrationBuilder.UpdateData(
                table: "Book",
                keyColumn: "BookId",
                keyValue: 1582,
                columns: new[] { "CreatedDateTime", "PublicationDate" },
                values: new object[] { new DateTime(2024, 8, 16, 16, 32, 4, 678, DateTimeKind.Utc).AddTicks(5111), new DateTime(2024, 7, 25, 22, 4, 39, 640, DateTimeKind.Local).AddTicks(4528) });

            migrationBuilder.UpdateData(
                table: "Book",
                keyColumn: "BookId",
                keyValue: 1583,
                columns: new[] { "CreatedDateTime", "PublicationDate" },
                values: new object[] { new DateTime(2024, 8, 16, 16, 32, 4, 678, DateTimeKind.Utc).AddTicks(5224), new DateTime(2024, 8, 13, 1, 4, 40, 758, DateTimeKind.Local).AddTicks(7068) });

            migrationBuilder.UpdateData(
                table: "Book",
                keyColumn: "BookId",
                keyValue: 1584,
                columns: new[] { "CreatedDateTime", "PublicationDate" },
                values: new object[] { new DateTime(2024, 8, 16, 16, 32, 4, 678, DateTimeKind.Utc).AddTicks(5316), new DateTime(2023, 8, 27, 23, 55, 27, 923, DateTimeKind.Local).AddTicks(6700) });

            migrationBuilder.UpdateData(
                table: "Book",
                keyColumn: "BookId",
                keyValue: 1585,
                columns: new[] { "CreatedDateTime", "PublicationDate" },
                values: new object[] { new DateTime(2024, 8, 16, 16, 32, 4, 678, DateTimeKind.Utc).AddTicks(5456), new DateTime(2024, 6, 18, 16, 33, 37, 814, DateTimeKind.Local).AddTicks(8743) });

            migrationBuilder.UpdateData(
                table: "Book",
                keyColumn: "BookId",
                keyValue: 1586,
                columns: new[] { "CreatedDateTime", "PublicationDate" },
                values: new object[] { new DateTime(2024, 8, 16, 16, 32, 4, 678, DateTimeKind.Utc).AddTicks(5579), new DateTime(2023, 12, 3, 13, 0, 1, 985, DateTimeKind.Local).AddTicks(588) });

            migrationBuilder.UpdateData(
                table: "Book",
                keyColumn: "BookId",
                keyValue: 1587,
                columns: new[] { "CreatedDateTime", "PublicationDate" },
                values: new object[] { new DateTime(2024, 8, 16, 16, 32, 4, 678, DateTimeKind.Utc).AddTicks(5678), new DateTime(2024, 3, 23, 20, 1, 19, 201, DateTimeKind.Local).AddTicks(1469) });

            migrationBuilder.UpdateData(
                table: "Book",
                keyColumn: "BookId",
                keyValue: 1588,
                columns: new[] { "CreatedDateTime", "PublicationDate" },
                values: new object[] { new DateTime(2024, 8, 16, 16, 32, 4, 678, DateTimeKind.Utc).AddTicks(5808), new DateTime(2023, 12, 19, 10, 19, 58, 472, DateTimeKind.Local).AddTicks(86) });

            migrationBuilder.UpdateData(
                table: "Book",
                keyColumn: "BookId",
                keyValue: 1589,
                columns: new[] { "CreatedDateTime", "PublicationDate" },
                values: new object[] { new DateTime(2024, 8, 16, 16, 32, 4, 678, DateTimeKind.Utc).AddTicks(5900), new DateTime(2024, 3, 11, 14, 56, 41, 872, DateTimeKind.Local).AddTicks(8982) });

            migrationBuilder.UpdateData(
                table: "Book",
                keyColumn: "BookId",
                keyValue: 1590,
                columns: new[] { "CreatedDateTime", "PublicationDate" },
                values: new object[] { new DateTime(2024, 8, 16, 16, 32, 4, 678, DateTimeKind.Utc).AddTicks(6023), new DateTime(2024, 1, 1, 18, 59, 36, 767, DateTimeKind.Local).AddTicks(8277) });

            migrationBuilder.UpdateData(
                table: "Book",
                keyColumn: "BookId",
                keyValue: 1591,
                columns: new[] { "CreatedDateTime", "PublicationDate" },
                values: new object[] { new DateTime(2024, 8, 16, 16, 32, 4, 678, DateTimeKind.Utc).AddTicks(6108), new DateTime(2024, 1, 16, 2, 45, 53, 591, DateTimeKind.Local).AddTicks(371) });

            migrationBuilder.UpdateData(
                table: "Book",
                keyColumn: "BookId",
                keyValue: 1592,
                columns: new[] { "CreatedDateTime", "PublicationDate" },
                values: new object[] { new DateTime(2024, 8, 16, 16, 32, 4, 678, DateTimeKind.Utc).AddTicks(6221), new DateTime(2024, 8, 15, 8, 48, 18, 841, DateTimeKind.Local).AddTicks(5274) });

            migrationBuilder.UpdateData(
                table: "Book",
                keyColumn: "BookId",
                keyValue: 1593,
                columns: new[] { "CreatedDateTime", "PublicationDate" },
                values: new object[] { new DateTime(2024, 8, 16, 16, 32, 4, 678, DateTimeKind.Utc).AddTicks(6312), new DateTime(2023, 11, 3, 14, 51, 9, 359, DateTimeKind.Local).AddTicks(4738) });

            migrationBuilder.UpdateData(
                table: "Book",
                keyColumn: "BookId",
                keyValue: 1594,
                columns: new[] { "CreatedDateTime", "PublicationDate" },
                values: new object[] { new DateTime(2024, 8, 16, 16, 32, 4, 678, DateTimeKind.Utc).AddTicks(6431), new DateTime(2023, 12, 9, 5, 9, 25, 551, DateTimeKind.Local).AddTicks(9251) });

            migrationBuilder.UpdateData(
                table: "Book",
                keyColumn: "BookId",
                keyValue: 1595,
                columns: new[] { "CreatedDateTime", "PublicationDate" },
                values: new object[] { new DateTime(2024, 8, 16, 16, 32, 4, 678, DateTimeKind.Utc).AddTicks(6521), new DateTime(2023, 10, 16, 10, 36, 15, 617, DateTimeKind.Local).AddTicks(4538) });

            migrationBuilder.UpdateData(
                table: "Book",
                keyColumn: "BookId",
                keyValue: 1596,
                columns: new[] { "CreatedDateTime", "PublicationDate" },
                values: new object[] { new DateTime(2024, 8, 16, 16, 32, 4, 678, DateTimeKind.Utc).AddTicks(6644), new DateTime(2023, 12, 15, 10, 40, 23, 996, DateTimeKind.Local).AddTicks(8078) });

            migrationBuilder.UpdateData(
                table: "Book",
                keyColumn: "BookId",
                keyValue: 1597,
                columns: new[] { "CreatedDateTime", "PublicationDate" },
                values: new object[] { new DateTime(2024, 8, 16, 16, 32, 4, 678, DateTimeKind.Utc).AddTicks(6741), new DateTime(2024, 2, 1, 18, 9, 17, 583, DateTimeKind.Local).AddTicks(7519) });

            migrationBuilder.UpdateData(
                table: "Book",
                keyColumn: "BookId",
                keyValue: 1598,
                columns: new[] { "CreatedDateTime", "PublicationDate" },
                values: new object[] { new DateTime(2024, 8, 16, 16, 32, 4, 678, DateTimeKind.Utc).AddTicks(6857), new DateTime(2024, 5, 9, 22, 2, 51, 22, DateTimeKind.Local).AddTicks(2252) });

            migrationBuilder.UpdateData(
                table: "Book",
                keyColumn: "BookId",
                keyValue: 1599,
                columns: new[] { "CreatedDateTime", "PublicationDate" },
                values: new object[] { new DateTime(2024, 8, 16, 16, 32, 4, 678, DateTimeKind.Utc).AddTicks(6960), new DateTime(2024, 2, 24, 5, 54, 0, 647, DateTimeKind.Local).AddTicks(7123) });

            migrationBuilder.UpdateData(
                table: "Book",
                keyColumn: "BookId",
                keyValue: 1600,
                columns: new[] { "CreatedDateTime", "PublicationDate" },
                values: new object[] { new DateTime(2024, 8, 16, 16, 32, 4, 678, DateTimeKind.Utc).AddTicks(7088), new DateTime(2024, 3, 9, 8, 56, 31, 119, DateTimeKind.Local).AddTicks(5715) });

            migrationBuilder.UpdateData(
                table: "Book",
                keyColumn: "BookId",
                keyValue: 1601,
                columns: new[] { "CreatedDateTime", "PublicationDate" },
                values: new object[] { new DateTime(2024, 8, 16, 16, 32, 4, 678, DateTimeKind.Utc).AddTicks(7175), new DateTime(2024, 6, 22, 1, 57, 33, 275, DateTimeKind.Local).AddTicks(3547) });

            migrationBuilder.UpdateData(
                table: "Book",
                keyColumn: "BookId",
                keyValue: 1602,
                columns: new[] { "CreatedDateTime", "PublicationDate" },
                values: new object[] { new DateTime(2024, 8, 16, 16, 32, 4, 678, DateTimeKind.Utc).AddTicks(7307), new DateTime(2024, 1, 31, 7, 49, 35, 184, DateTimeKind.Local).AddTicks(4246) });

            migrationBuilder.UpdateData(
                table: "Book",
                keyColumn: "BookId",
                keyValue: 1603,
                columns: new[] { "CreatedDateTime", "PublicationDate" },
                values: new object[] { new DateTime(2024, 8, 16, 16, 32, 4, 678, DateTimeKind.Utc).AddTicks(7401), new DateTime(2024, 8, 12, 10, 49, 39, 543, DateTimeKind.Local).AddTicks(8633) });

            migrationBuilder.UpdateData(
                table: "Book",
                keyColumn: "BookId",
                keyValue: 1604,
                columns: new[] { "CreatedDateTime", "PublicationDate" },
                values: new object[] { new DateTime(2024, 8, 16, 16, 32, 4, 678, DateTimeKind.Utc).AddTicks(7527), new DateTime(2024, 3, 25, 16, 28, 5, 596, DateTimeKind.Local).AddTicks(5251) });

            migrationBuilder.UpdateData(
                table: "Book",
                keyColumn: "BookId",
                keyValue: 1605,
                columns: new[] { "CreatedDateTime", "PublicationDate" },
                values: new object[] { new DateTime(2024, 8, 16, 16, 32, 4, 678, DateTimeKind.Utc).AddTicks(7620), new DateTime(2024, 7, 31, 6, 55, 34, 127, DateTimeKind.Local).AddTicks(4839) });

            migrationBuilder.UpdateData(
                table: "Book",
                keyColumn: "BookId",
                keyValue: 1606,
                columns: new[] { "CreatedDateTime", "PublicationDate" },
                values: new object[] { new DateTime(2024, 8, 16, 16, 32, 4, 678, DateTimeKind.Utc).AddTicks(7737), new DateTime(2024, 5, 19, 17, 48, 20, 701, DateTimeKind.Local).AddTicks(8326) });

            migrationBuilder.UpdateData(
                table: "Book",
                keyColumn: "BookId",
                keyValue: 1607,
                columns: new[] { "CreatedDateTime", "PublicationDate" },
                values: new object[] { new DateTime(2024, 8, 16, 16, 32, 4, 678, DateTimeKind.Utc).AddTicks(7825), new DateTime(2023, 11, 22, 1, 8, 22, 691, DateTimeKind.Local).AddTicks(6613) });

            migrationBuilder.UpdateData(
                table: "Book",
                keyColumn: "BookId",
                keyValue: 1608,
                columns: new[] { "CreatedDateTime", "PublicationDate" },
                values: new object[] { new DateTime(2024, 8, 16, 16, 32, 4, 678, DateTimeKind.Utc).AddTicks(7931), new DateTime(2023, 8, 16, 20, 2, 26, 81, DateTimeKind.Local).AddTicks(7955) });

            migrationBuilder.UpdateData(
                table: "Book",
                keyColumn: "BookId",
                keyValue: 1609,
                columns: new[] { "CreatedDateTime", "PublicationDate" },
                values: new object[] { new DateTime(2024, 8, 16, 16, 32, 4, 678, DateTimeKind.Utc).AddTicks(8034), new DateTime(2024, 3, 4, 5, 52, 43, 929, DateTimeKind.Local).AddTicks(9501) });

            migrationBuilder.UpdateData(
                table: "Book",
                keyColumn: "BookId",
                keyValue: 1610,
                columns: new[] { "CreatedDateTime", "PublicationDate" },
                values: new object[] { new DateTime(2024, 8, 16, 16, 32, 4, 678, DateTimeKind.Utc).AddTicks(8165), new DateTime(2023, 9, 4, 4, 23, 37, 558, DateTimeKind.Local).AddTicks(7951) });

            migrationBuilder.UpdateData(
                table: "Book",
                keyColumn: "BookId",
                keyValue: 1611,
                columns: new[] { "CreatedDateTime", "PublicationDate" },
                values: new object[] { new DateTime(2024, 8, 16, 16, 32, 4, 678, DateTimeKind.Utc).AddTicks(8259), new DateTime(2024, 8, 8, 22, 35, 1, 882, DateTimeKind.Local).AddTicks(1046) });

            migrationBuilder.UpdateData(
                table: "Book",
                keyColumn: "BookId",
                keyValue: 1612,
                columns: new[] { "CreatedDateTime", "PublicationDate" },
                values: new object[] { new DateTime(2024, 8, 16, 16, 32, 4, 678, DateTimeKind.Utc).AddTicks(8403), new DateTime(2023, 8, 29, 6, 50, 5, 471, DateTimeKind.Local).AddTicks(5667) });

            migrationBuilder.UpdateData(
                table: "Book",
                keyColumn: "BookId",
                keyValue: 1613,
                columns: new[] { "CreatedDateTime", "PublicationDate" },
                values: new object[] { new DateTime(2024, 8, 16, 16, 32, 4, 678, DateTimeKind.Utc).AddTicks(8491), new DateTime(2024, 1, 14, 10, 29, 56, 672, DateTimeKind.Local).AddTicks(2133) });

            migrationBuilder.UpdateData(
                table: "Book",
                keyColumn: "BookId",
                keyValue: 1614,
                columns: new[] { "CreatedDateTime", "PublicationDate" },
                values: new object[] { new DateTime(2024, 8, 16, 16, 32, 4, 678, DateTimeKind.Utc).AddTicks(8608), new DateTime(2024, 7, 1, 0, 36, 18, 353, DateTimeKind.Local).AddTicks(8344) });

            migrationBuilder.UpdateData(
                table: "Book",
                keyColumn: "BookId",
                keyValue: 1615,
                columns: new[] { "CreatedDateTime", "PublicationDate" },
                values: new object[] { new DateTime(2024, 8, 16, 16, 32, 4, 678, DateTimeKind.Utc).AddTicks(8697), new DateTime(2024, 2, 21, 2, 52, 29, 368, DateTimeKind.Local).AddTicks(2713) });

            migrationBuilder.UpdateData(
                table: "Book",
                keyColumn: "BookId",
                keyValue: 1616,
                columns: new[] { "CreatedDateTime", "PublicationDate" },
                values: new object[] { new DateTime(2024, 8, 16, 16, 32, 4, 678, DateTimeKind.Utc).AddTicks(8822), new DateTime(2024, 5, 17, 5, 25, 59, 859, DateTimeKind.Local).AddTicks(9483) });

            migrationBuilder.UpdateData(
                table: "Book",
                keyColumn: "BookId",
                keyValue: 1617,
                columns: new[] { "CreatedDateTime", "PublicationDate" },
                values: new object[] { new DateTime(2024, 8, 16, 16, 32, 4, 678, DateTimeKind.Utc).AddTicks(8917), new DateTime(2023, 11, 18, 4, 34, 58, 599, DateTimeKind.Local).AddTicks(5959) });

            migrationBuilder.UpdateData(
                table: "Book",
                keyColumn: "BookId",
                keyValue: 1618,
                columns: new[] { "CreatedDateTime", "PublicationDate" },
                values: new object[] { new DateTime(2024, 8, 16, 16, 32, 4, 678, DateTimeKind.Utc).AddTicks(9029), new DateTime(2023, 11, 12, 14, 1, 43, 341, DateTimeKind.Local).AddTicks(1895) });

            migrationBuilder.UpdateData(
                table: "Book",
                keyColumn: "BookId",
                keyValue: 1619,
                columns: new[] { "CreatedDateTime", "PublicationDate" },
                values: new object[] { new DateTime(2024, 8, 16, 16, 32, 4, 678, DateTimeKind.Utc).AddTicks(9133), new DateTime(2024, 2, 25, 16, 42, 10, 611, DateTimeKind.Local).AddTicks(153) });

            migrationBuilder.UpdateData(
                table: "Book",
                keyColumn: "BookId",
                keyValue: 1620,
                columns: new[] { "CreatedDateTime", "PublicationDate" },
                values: new object[] { new DateTime(2024, 8, 16, 16, 32, 4, 678, DateTimeKind.Utc).AddTicks(9257), new DateTime(2023, 10, 19, 17, 18, 26, 512, DateTimeKind.Local).AddTicks(9243) });

            migrationBuilder.UpdateData(
                table: "Book",
                keyColumn: "BookId",
                keyValue: 1621,
                columns: new[] { "CreatedDateTime", "PublicationDate" },
                values: new object[] { new DateTime(2024, 8, 16, 16, 32, 4, 678, DateTimeKind.Utc).AddTicks(9363), new DateTime(2024, 7, 19, 12, 43, 35, 980, DateTimeKind.Local).AddTicks(6079) });

            migrationBuilder.UpdateData(
                table: "Book",
                keyColumn: "BookId",
                keyValue: 1622,
                columns: new[] { "CreatedDateTime", "PublicationDate" },
                values: new object[] { new DateTime(2024, 8, 16, 16, 32, 4, 678, DateTimeKind.Utc).AddTicks(9484), new DateTime(2023, 8, 23, 21, 33, 12, 264, DateTimeKind.Local).AddTicks(8038) });

            migrationBuilder.UpdateData(
                table: "Book",
                keyColumn: "BookId",
                keyValue: 1623,
                columns: new[] { "CreatedDateTime", "PublicationDate" },
                values: new object[] { new DateTime(2024, 8, 16, 16, 32, 4, 678, DateTimeKind.Utc).AddTicks(9578), new DateTime(2024, 6, 9, 16, 27, 49, 133, DateTimeKind.Local).AddTicks(1724) });

            migrationBuilder.UpdateData(
                table: "Book",
                keyColumn: "BookId",
                keyValue: 1624,
                columns: new[] { "CreatedDateTime", "PublicationDate" },
                values: new object[] { new DateTime(2024, 8, 16, 16, 32, 4, 678, DateTimeKind.Utc).AddTicks(9692), new DateTime(2024, 6, 8, 14, 6, 40, 76, DateTimeKind.Local).AddTicks(9225) });

            migrationBuilder.UpdateData(
                table: "Book",
                keyColumn: "BookId",
                keyValue: 1625,
                columns: new[] { "CreatedDateTime", "PublicationDate" },
                values: new object[] { new DateTime(2024, 8, 16, 16, 32, 4, 678, DateTimeKind.Utc).AddTicks(9793), new DateTime(2023, 12, 7, 12, 49, 10, 262, DateTimeKind.Local).AddTicks(6038) });

            migrationBuilder.UpdateData(
                table: "Book",
                keyColumn: "BookId",
                keyValue: 1626,
                columns: new[] { "CreatedDateTime", "PublicationDate" },
                values: new object[] { new DateTime(2024, 8, 16, 16, 32, 4, 678, DateTimeKind.Utc).AddTicks(9915), new DateTime(2023, 10, 13, 8, 21, 31, 191, DateTimeKind.Local).AddTicks(7602) });

            migrationBuilder.UpdateData(
                table: "Book",
                keyColumn: "BookId",
                keyValue: 1627,
                columns: new[] { "CreatedDateTime", "PublicationDate" },
                values: new object[] { new DateTime(2024, 8, 16, 16, 32, 4, 679, DateTimeKind.Utc).AddTicks(63), new DateTime(2024, 4, 25, 4, 2, 0, 698, DateTimeKind.Local).AddTicks(1850) });

            migrationBuilder.UpdateData(
                table: "Book",
                keyColumn: "BookId",
                keyValue: 1628,
                columns: new[] { "CreatedDateTime", "PublicationDate" },
                values: new object[] { new DateTime(2024, 8, 16, 16, 32, 4, 679, DateTimeKind.Utc).AddTicks(156), new DateTime(2024, 5, 9, 21, 23, 29, 669, DateTimeKind.Local).AddTicks(398) });

            migrationBuilder.UpdateData(
                table: "Book",
                keyColumn: "BookId",
                keyValue: 1629,
                columns: new[] { "CreatedDateTime", "PublicationDate" },
                values: new object[] { new DateTime(2024, 8, 16, 16, 32, 4, 679, DateTimeKind.Utc).AddTicks(282), new DateTime(2024, 3, 3, 9, 17, 55, 256, DateTimeKind.Local).AddTicks(778) });

            migrationBuilder.UpdateData(
                table: "Book",
                keyColumn: "BookId",
                keyValue: 1630,
                columns: new[] { "CreatedDateTime", "PublicationDate" },
                values: new object[] { new DateTime(2024, 8, 16, 16, 32, 4, 679, DateTimeKind.Utc).AddTicks(383), new DateTime(2023, 9, 20, 6, 6, 0, 928, DateTimeKind.Local).AddTicks(3151) });

            migrationBuilder.UpdateData(
                table: "Book",
                keyColumn: "BookId",
                keyValue: 1631,
                columns: new[] { "CreatedDateTime", "PublicationDate" },
                values: new object[] { new DateTime(2024, 8, 16, 16, 32, 4, 679, DateTimeKind.Utc).AddTicks(501), new DateTime(2024, 6, 5, 19, 3, 55, 967, DateTimeKind.Local).AddTicks(5945) });

            migrationBuilder.UpdateData(
                table: "Book",
                keyColumn: "BookId",
                keyValue: 1632,
                columns: new[] { "CreatedDateTime", "PublicationDate" },
                values: new object[] { new DateTime(2024, 8, 16, 16, 32, 4, 679, DateTimeKind.Utc).AddTicks(594), new DateTime(2023, 11, 23, 16, 25, 58, 1, DateTimeKind.Local).AddTicks(7519) });

            migrationBuilder.UpdateData(
                table: "Book",
                keyColumn: "BookId",
                keyValue: 1633,
                columns: new[] { "CreatedDateTime", "PublicationDate" },
                values: new object[] { new DateTime(2024, 8, 16, 16, 32, 4, 679, DateTimeKind.Utc).AddTicks(725), new DateTime(2024, 7, 27, 14, 13, 45, 119, DateTimeKind.Local).AddTicks(7012) });

            migrationBuilder.UpdateData(
                table: "Book",
                keyColumn: "BookId",
                keyValue: 1634,
                columns: new[] { "CreatedDateTime", "PublicationDate" },
                values: new object[] { new DateTime(2024, 8, 16, 16, 32, 4, 679, DateTimeKind.Utc).AddTicks(824), new DateTime(2023, 12, 31, 14, 45, 4, 7, DateTimeKind.Local).AddTicks(76) });

            migrationBuilder.UpdateData(
                table: "Book",
                keyColumn: "BookId",
                keyValue: 1635,
                columns: new[] { "CreatedDateTime", "PublicationDate" },
                values: new object[] { new DateTime(2024, 8, 16, 16, 32, 4, 679, DateTimeKind.Utc).AddTicks(939), new DateTime(2023, 10, 10, 18, 42, 41, 304, DateTimeKind.Local).AddTicks(6260) });

            migrationBuilder.UpdateData(
                table: "Book",
                keyColumn: "BookId",
                keyValue: 1636,
                columns: new[] { "CreatedDateTime", "PublicationDate" },
                values: new object[] { new DateTime(2024, 8, 16, 16, 32, 4, 679, DateTimeKind.Utc).AddTicks(1033), new DateTime(2024, 8, 16, 2, 54, 53, 403, DateTimeKind.Local).AddTicks(5718) });

            migrationBuilder.UpdateData(
                table: "Book",
                keyColumn: "BookId",
                keyValue: 1637,
                columns: new[] { "CreatedDateTime", "PublicationDate" },
                values: new object[] { new DateTime(2024, 8, 16, 16, 32, 4, 679, DateTimeKind.Utc).AddTicks(1161), new DateTime(2023, 12, 27, 22, 0, 47, 97, DateTimeKind.Local).AddTicks(7596) });

            migrationBuilder.UpdateData(
                table: "Book",
                keyColumn: "BookId",
                keyValue: 1638,
                columns: new[] { "CreatedDateTime", "PublicationDate" },
                values: new object[] { new DateTime(2024, 8, 16, 16, 32, 4, 679, DateTimeKind.Utc).AddTicks(1286), new DateTime(2023, 8, 21, 1, 48, 23, 571, DateTimeKind.Local).AddTicks(8037) });

            migrationBuilder.UpdateData(
                table: "Book",
                keyColumn: "BookId",
                keyValue: 1639,
                columns: new[] { "CreatedDateTime", "PublicationDate" },
                values: new object[] { new DateTime(2024, 8, 16, 16, 32, 4, 679, DateTimeKind.Utc).AddTicks(1387), new DateTime(2024, 5, 22, 19, 25, 52, 547, DateTimeKind.Local).AddTicks(7127) });

            migrationBuilder.UpdateData(
                table: "Book",
                keyColumn: "BookId",
                keyValue: 1640,
                columns: new[] { "CreatedDateTime", "PublicationDate" },
                values: new object[] { new DateTime(2024, 8, 16, 16, 32, 4, 679, DateTimeKind.Utc).AddTicks(1527), new DateTime(2024, 1, 20, 1, 5, 15, 594, DateTimeKind.Local).AddTicks(2326) });

            migrationBuilder.UpdateData(
                table: "Book",
                keyColumn: "BookId",
                keyValue: 1641,
                columns: new[] { "CreatedDateTime", "PublicationDate" },
                values: new object[] { new DateTime(2024, 8, 16, 16, 32, 4, 679, DateTimeKind.Utc).AddTicks(1630), new DateTime(2023, 9, 25, 4, 30, 48, 439, DateTimeKind.Local).AddTicks(4882) });

            migrationBuilder.UpdateData(
                table: "Book",
                keyColumn: "BookId",
                keyValue: 1642,
                columns: new[] { "CreatedDateTime", "PublicationDate" },
                values: new object[] { new DateTime(2024, 8, 16, 16, 32, 4, 679, DateTimeKind.Utc).AddTicks(1764), new DateTime(2024, 5, 18, 12, 52, 33, 688, DateTimeKind.Local).AddTicks(3301) });

            migrationBuilder.UpdateData(
                table: "Book",
                keyColumn: "BookId",
                keyValue: 1643,
                columns: new[] { "CreatedDateTime", "PublicationDate" },
                values: new object[] { new DateTime(2024, 8, 16, 16, 32, 4, 679, DateTimeKind.Utc).AddTicks(1865), new DateTime(2024, 5, 18, 19, 40, 14, 253, DateTimeKind.Local).AddTicks(8071) });

            migrationBuilder.UpdateData(
                table: "Book",
                keyColumn: "BookId",
                keyValue: 1644,
                columns: new[] { "CreatedDateTime", "PublicationDate" },
                values: new object[] { new DateTime(2024, 8, 16, 16, 32, 4, 679, DateTimeKind.Utc).AddTicks(1984), new DateTime(2023, 11, 8, 16, 12, 1, 630, DateTimeKind.Local).AddTicks(9267) });

            migrationBuilder.UpdateData(
                table: "Book",
                keyColumn: "BookId",
                keyValue: 1645,
                columns: new[] { "CreatedDateTime", "PublicationDate" },
                values: new object[] { new DateTime(2024, 8, 16, 16, 32, 4, 679, DateTimeKind.Utc).AddTicks(2087), new DateTime(2024, 1, 27, 6, 47, 18, 671, DateTimeKind.Local).AddTicks(8368) });

            migrationBuilder.UpdateData(
                table: "Book",
                keyColumn: "BookId",
                keyValue: 1646,
                columns: new[] { "CreatedDateTime", "PublicationDate" },
                values: new object[] { new DateTime(2024, 8, 16, 16, 32, 4, 679, DateTimeKind.Utc).AddTicks(2204), new DateTime(2024, 2, 25, 9, 46, 31, 826, DateTimeKind.Local).AddTicks(1225) });

            migrationBuilder.UpdateData(
                table: "Book",
                keyColumn: "BookId",
                keyValue: 1647,
                columns: new[] { "CreatedDateTime", "PublicationDate" },
                values: new object[] { new DateTime(2024, 8, 16, 16, 32, 4, 679, DateTimeKind.Utc).AddTicks(2338), new DateTime(2024, 1, 9, 6, 47, 3, 414, DateTimeKind.Local).AddTicks(2473) });

            migrationBuilder.UpdateData(
                table: "Book",
                keyColumn: "BookId",
                keyValue: 1648,
                columns: new[] { "CreatedDateTime", "PublicationDate" },
                values: new object[] { new DateTime(2024, 8, 16, 16, 32, 4, 679, DateTimeKind.Utc).AddTicks(2427), new DateTime(2024, 7, 16, 20, 4, 30, 826, DateTimeKind.Local).AddTicks(5716) });

            migrationBuilder.UpdateData(
                table: "Book",
                keyColumn: "BookId",
                keyValue: 1649,
                columns: new[] { "CreatedDateTime", "PublicationDate" },
                values: new object[] { new DateTime(2024, 8, 16, 16, 32, 4, 679, DateTimeKind.Utc).AddTicks(2552), new DateTime(2024, 1, 28, 10, 35, 17, 166, DateTimeKind.Local).AddTicks(1510) });

            migrationBuilder.UpdateData(
                table: "Book",
                keyColumn: "BookId",
                keyValue: 1650,
                columns: new[] { "CreatedDateTime", "PublicationDate" },
                values: new object[] { new DateTime(2024, 8, 16, 16, 32, 4, 679, DateTimeKind.Utc).AddTicks(2639), new DateTime(2024, 5, 17, 15, 45, 45, 759, DateTimeKind.Local).AddTicks(3127) });

            migrationBuilder.UpdateData(
                table: "Book",
                keyColumn: "BookId",
                keyValue: 1651,
                columns: new[] { "CreatedDateTime", "PublicationDate" },
                values: new object[] { new DateTime(2024, 8, 16, 16, 32, 4, 679, DateTimeKind.Utc).AddTicks(2757), new DateTime(2024, 5, 15, 23, 39, 42, 977, DateTimeKind.Local).AddTicks(7743) });

            migrationBuilder.UpdateData(
                table: "Book",
                keyColumn: "BookId",
                keyValue: 1652,
                columns: new[] { "CreatedDateTime", "PublicationDate" },
                values: new object[] { new DateTime(2024, 8, 16, 16, 32, 4, 679, DateTimeKind.Utc).AddTicks(2850), new DateTime(2024, 7, 1, 0, 23, 27, 836, DateTimeKind.Local).AddTicks(7711) });

            migrationBuilder.UpdateData(
                table: "Book",
                keyColumn: "BookId",
                keyValue: 1653,
                columns: new[] { "CreatedDateTime", "PublicationDate" },
                values: new object[] { new DateTime(2024, 8, 16, 16, 32, 4, 679, DateTimeKind.Utc).AddTicks(2932), new DateTime(2024, 2, 24, 7, 35, 3, 713, DateTimeKind.Local).AddTicks(5535) });

            migrationBuilder.UpdateData(
                table: "Book",
                keyColumn: "BookId",
                keyValue: 1654,
                columns: new[] { "CreatedDateTime", "PublicationDate" },
                values: new object[] { new DateTime(2024, 8, 16, 16, 32, 4, 679, DateTimeKind.Utc).AddTicks(3044), new DateTime(2024, 2, 11, 0, 52, 31, 931, DateTimeKind.Local).AddTicks(7421) });

            migrationBuilder.UpdateData(
                table: "Book",
                keyColumn: "BookId",
                keyValue: 1655,
                columns: new[] { "CreatedDateTime", "PublicationDate" },
                values: new object[] { new DateTime(2024, 8, 16, 16, 32, 4, 679, DateTimeKind.Utc).AddTicks(3180), new DateTime(2024, 8, 14, 8, 18, 15, 205, DateTimeKind.Local).AddTicks(4557) });

            migrationBuilder.UpdateData(
                table: "Book",
                keyColumn: "BookId",
                keyValue: 1656,
                columns: new[] { "CreatedDateTime", "PublicationDate" },
                values: new object[] { new DateTime(2024, 8, 16, 16, 32, 4, 679, DateTimeKind.Utc).AddTicks(3272), new DateTime(2023, 9, 12, 13, 51, 32, 110, DateTimeKind.Local).AddTicks(4527) });

            migrationBuilder.UpdateData(
                table: "Book",
                keyColumn: "BookId",
                keyValue: 1657,
                columns: new[] { "CreatedDateTime", "PublicationDate" },
                values: new object[] { new DateTime(2024, 8, 16, 16, 32, 4, 679, DateTimeKind.Utc).AddTicks(3415), new DateTime(2024, 5, 10, 21, 35, 44, 394, DateTimeKind.Local).AddTicks(6073) });

            migrationBuilder.UpdateData(
                table: "Book",
                keyColumn: "BookId",
                keyValue: 1658,
                columns: new[] { "CreatedDateTime", "PublicationDate" },
                values: new object[] { new DateTime(2024, 8, 16, 16, 32, 4, 679, DateTimeKind.Utc).AddTicks(3509), new DateTime(2024, 1, 12, 8, 20, 49, 226, DateTimeKind.Local).AddTicks(1013) });

            migrationBuilder.UpdateData(
                table: "Book",
                keyColumn: "BookId",
                keyValue: 1659,
                columns: new[] { "CreatedDateTime", "PublicationDate" },
                values: new object[] { new DateTime(2024, 8, 16, 16, 32, 4, 679, DateTimeKind.Utc).AddTicks(3637), new DateTime(2024, 6, 28, 16, 32, 34, 797, DateTimeKind.Local).AddTicks(4057) });

            migrationBuilder.UpdateData(
                table: "Book",
                keyColumn: "BookId",
                keyValue: 1660,
                columns: new[] { "CreatedDateTime", "PublicationDate" },
                values: new object[] { new DateTime(2024, 8, 16, 16, 32, 4, 679, DateTimeKind.Utc).AddTicks(3726), new DateTime(2023, 9, 14, 15, 17, 52, 873, DateTimeKind.Local).AddTicks(6267) });

            migrationBuilder.UpdateData(
                table: "Book",
                keyColumn: "BookId",
                keyValue: 1661,
                columns: new[] { "CreatedDateTime", "PublicationDate" },
                values: new object[] { new DateTime(2024, 8, 16, 16, 32, 4, 679, DateTimeKind.Utc).AddTicks(3845), new DateTime(2024, 1, 3, 13, 36, 53, 208, DateTimeKind.Local).AddTicks(6137) });

            migrationBuilder.UpdateData(
                table: "Book",
                keyColumn: "BookId",
                keyValue: 1662,
                columns: new[] { "CreatedDateTime", "PublicationDate" },
                values: new object[] { new DateTime(2024, 8, 16, 16, 32, 4, 679, DateTimeKind.Utc).AddTicks(3940), new DateTime(2024, 7, 30, 15, 56, 24, 342, DateTimeKind.Local).AddTicks(217) });

            migrationBuilder.UpdateData(
                table: "Book",
                keyColumn: "BookId",
                keyValue: 1663,
                columns: new[] { "CreatedDateTime", "PublicationDate" },
                values: new object[] { new DateTime(2024, 8, 16, 16, 32, 4, 679, DateTimeKind.Utc).AddTicks(4068), new DateTime(2024, 4, 5, 7, 51, 49, 895, DateTimeKind.Local).AddTicks(3329) });

            migrationBuilder.UpdateData(
                table: "Book",
                keyColumn: "BookId",
                keyValue: 1664,
                columns: new[] { "CreatedDateTime", "PublicationDate" },
                values: new object[] { new DateTime(2024, 8, 16, 16, 32, 4, 679, DateTimeKind.Utc).AddTicks(4154), new DateTime(2023, 8, 24, 20, 45, 21, 302, DateTimeKind.Local).AddTicks(6507) });

            migrationBuilder.UpdateData(
                table: "Book",
                keyColumn: "BookId",
                keyValue: 1665,
                columns: new[] { "CreatedDateTime", "PublicationDate" },
                values: new object[] { new DateTime(2024, 8, 16, 16, 32, 4, 679, DateTimeKind.Utc).AddTicks(4275), new DateTime(2023, 12, 24, 10, 53, 21, 967, DateTimeKind.Local).AddTicks(1595) });

            migrationBuilder.UpdateData(
                table: "Book",
                keyColumn: "BookId",
                keyValue: 1666,
                columns: new[] { "CreatedDateTime", "PublicationDate" },
                values: new object[] { new DateTime(2024, 8, 16, 16, 32, 4, 679, DateTimeKind.Utc).AddTicks(4372), new DateTime(2024, 5, 6, 5, 0, 34, 423, DateTimeKind.Local).AddTicks(2347) });

            migrationBuilder.UpdateData(
                table: "Book",
                keyColumn: "BookId",
                keyValue: 1667,
                columns: new[] { "CreatedDateTime", "PublicationDate" },
                values: new object[] { new DateTime(2024, 8, 16, 16, 32, 4, 679, DateTimeKind.Utc).AddTicks(4492), new DateTime(2023, 8, 24, 16, 56, 39, 506, DateTimeKind.Local).AddTicks(2525) });

            migrationBuilder.UpdateData(
                table: "Book",
                keyColumn: "BookId",
                keyValue: 1668,
                columns: new[] { "CreatedDateTime", "PublicationDate" },
                values: new object[] { new DateTime(2024, 8, 16, 16, 32, 4, 679, DateTimeKind.Utc).AddTicks(4587), new DateTime(2023, 11, 25, 5, 11, 21, 149, DateTimeKind.Local).AddTicks(7813) });

            migrationBuilder.UpdateData(
                table: "Book",
                keyColumn: "BookId",
                keyValue: 1669,
                columns: new[] { "CreatedDateTime", "PublicationDate" },
                values: new object[] { new DateTime(2024, 8, 16, 16, 32, 4, 679, DateTimeKind.Utc).AddTicks(4690), new DateTime(2024, 4, 27, 22, 12, 15, 472, DateTimeKind.Local).AddTicks(8123) });

            migrationBuilder.UpdateData(
                table: "Book",
                keyColumn: "BookId",
                keyValue: 1670,
                columns: new[] { "CreatedDateTime", "PublicationDate" },
                values: new object[] { new DateTime(2024, 8, 16, 16, 32, 4, 679, DateTimeKind.Utc).AddTicks(4778), new DateTime(2024, 4, 1, 13, 27, 49, 467, DateTimeKind.Local).AddTicks(1006) });

            migrationBuilder.UpdateData(
                table: "Book",
                keyColumn: "BookId",
                keyValue: 1671,
                columns: new[] { "CreatedDateTime", "PublicationDate" },
                values: new object[] { new DateTime(2024, 8, 16, 16, 32, 4, 679, DateTimeKind.Utc).AddTicks(4906), new DateTime(2024, 5, 1, 12, 43, 17, 236, DateTimeKind.Local).AddTicks(987) });

            migrationBuilder.UpdateData(
                table: "Book",
                keyColumn: "BookId",
                keyValue: 1672,
                columns: new[] { "CreatedDateTime", "PublicationDate" },
                values: new object[] { new DateTime(2024, 8, 16, 16, 32, 4, 679, DateTimeKind.Utc).AddTicks(4992), new DateTime(2023, 8, 31, 0, 32, 53, 669, DateTimeKind.Local).AddTicks(9712) });

            migrationBuilder.UpdateData(
                table: "Book",
                keyColumn: "BookId",
                keyValue: 1673,
                columns: new[] { "CreatedDateTime", "PublicationDate" },
                values: new object[] { new DateTime(2024, 8, 16, 16, 32, 4, 679, DateTimeKind.Utc).AddTicks(5133), new DateTime(2024, 8, 11, 14, 4, 32, 936, DateTimeKind.Local).AddTicks(8965) });

            migrationBuilder.UpdateData(
                table: "Book",
                keyColumn: "BookId",
                keyValue: 1674,
                columns: new[] { "CreatedDateTime", "PublicationDate" },
                values: new object[] { new DateTime(2024, 8, 16, 16, 32, 4, 679, DateTimeKind.Utc).AddTicks(5232), new DateTime(2024, 4, 26, 20, 8, 53, 16, DateTimeKind.Local).AddTicks(2532) });

            migrationBuilder.UpdateData(
                table: "Book",
                keyColumn: "BookId",
                keyValue: 1675,
                columns: new[] { "CreatedDateTime", "PublicationDate" },
                values: new object[] { new DateTime(2024, 8, 16, 16, 32, 4, 679, DateTimeKind.Utc).AddTicks(5343), new DateTime(2024, 3, 6, 23, 59, 29, 148, DateTimeKind.Local).AddTicks(7057) });

            migrationBuilder.UpdateData(
                table: "Book",
                keyColumn: "BookId",
                keyValue: 1676,
                columns: new[] { "CreatedDateTime", "PublicationDate" },
                values: new object[] { new DateTime(2024, 8, 16, 16, 32, 4, 679, DateTimeKind.Utc).AddTicks(5425), new DateTime(2024, 4, 10, 17, 9, 25, 982, DateTimeKind.Local).AddTicks(4946) });

            migrationBuilder.UpdateData(
                table: "Book",
                keyColumn: "BookId",
                keyValue: 1677,
                columns: new[] { "CreatedDateTime", "PublicationDate" },
                values: new object[] { new DateTime(2024, 8, 16, 16, 32, 4, 679, DateTimeKind.Utc).AddTicks(5549), new DateTime(2024, 3, 20, 20, 11, 16, 652, DateTimeKind.Local).AddTicks(4817) });

            migrationBuilder.UpdateData(
                table: "Book",
                keyColumn: "BookId",
                keyValue: 1678,
                columns: new[] { "CreatedDateTime", "PublicationDate" },
                values: new object[] { new DateTime(2024, 8, 16, 16, 32, 4, 679, DateTimeKind.Utc).AddTicks(5650), new DateTime(2024, 1, 26, 7, 37, 30, 747, DateTimeKind.Local).AddTicks(6300) });

            migrationBuilder.UpdateData(
                table: "Book",
                keyColumn: "BookId",
                keyValue: 1679,
                columns: new[] { "CreatedDateTime", "PublicationDate" },
                values: new object[] { new DateTime(2024, 8, 16, 16, 32, 4, 679, DateTimeKind.Utc).AddTicks(5778), new DateTime(2023, 11, 15, 14, 50, 6, 308, DateTimeKind.Local).AddTicks(144) });

            migrationBuilder.UpdateData(
                table: "Book",
                keyColumn: "BookId",
                keyValue: 1680,
                columns: new[] { "CreatedDateTime", "PublicationDate" },
                values: new object[] { new DateTime(2024, 8, 16, 16, 32, 4, 679, DateTimeKind.Utc).AddTicks(5876), new DateTime(2023, 10, 14, 13, 25, 41, 311, DateTimeKind.Local).AddTicks(8006) });

            migrationBuilder.UpdateData(
                table: "Book",
                keyColumn: "BookId",
                keyValue: 1681,
                columns: new[] { "CreatedDateTime", "PublicationDate" },
                values: new object[] { new DateTime(2024, 8, 16, 16, 32, 4, 679, DateTimeKind.Utc).AddTicks(6008), new DateTime(2024, 6, 6, 4, 1, 43, 372, DateTimeKind.Local).AddTicks(1388) });

            migrationBuilder.UpdateData(
                table: "Book",
                keyColumn: "BookId",
                keyValue: 1682,
                columns: new[] { "CreatedDateTime", "PublicationDate" },
                values: new object[] { new DateTime(2024, 8, 16, 16, 32, 4, 679, DateTimeKind.Utc).AddTicks(6104), new DateTime(2023, 8, 26, 1, 6, 12, 328, DateTimeKind.Local).AddTicks(3599) });

            migrationBuilder.UpdateData(
                table: "Book",
                keyColumn: "BookId",
                keyValue: 1683,
                columns: new[] { "CreatedDateTime", "PublicationDate" },
                values: new object[] { new DateTime(2024, 8, 16, 16, 32, 4, 679, DateTimeKind.Utc).AddTicks(6208), new DateTime(2023, 11, 25, 7, 44, 13, 556, DateTimeKind.Local).AddTicks(4425) });

            migrationBuilder.UpdateData(
                table: "Book",
                keyColumn: "BookId",
                keyValue: 1684,
                columns: new[] { "CreatedDateTime", "PublicationDate" },
                values: new object[] { new DateTime(2024, 8, 16, 16, 32, 4, 679, DateTimeKind.Utc).AddTicks(6310), new DateTime(2024, 6, 4, 1, 21, 47, 838, DateTimeKind.Local).AddTicks(543) });

            migrationBuilder.UpdateData(
                table: "Book",
                keyColumn: "BookId",
                keyValue: 1685,
                columns: new[] { "CreatedDateTime", "PublicationDate" },
                values: new object[] { new DateTime(2024, 8, 16, 16, 32, 4, 679, DateTimeKind.Utc).AddTicks(6435), new DateTime(2023, 12, 13, 22, 2, 54, 210, DateTimeKind.Local).AddTicks(5312) });

            migrationBuilder.UpdateData(
                table: "Book",
                keyColumn: "BookId",
                keyValue: 1686,
                columns: new[] { "CreatedDateTime", "PublicationDate" },
                values: new object[] { new DateTime(2024, 8, 16, 16, 32, 4, 679, DateTimeKind.Utc).AddTicks(6523), new DateTime(2023, 11, 9, 21, 30, 59, 84, DateTimeKind.Local).AddTicks(3390) });

            migrationBuilder.UpdateData(
                table: "Book",
                keyColumn: "BookId",
                keyValue: 1687,
                columns: new[] { "CreatedDateTime", "PublicationDate" },
                values: new object[] { new DateTime(2024, 8, 16, 16, 32, 4, 679, DateTimeKind.Utc).AddTicks(6659), new DateTime(2023, 10, 2, 10, 10, 21, 510, DateTimeKind.Local).AddTicks(6238) });

            migrationBuilder.UpdateData(
                table: "Book",
                keyColumn: "BookId",
                keyValue: 1688,
                columns: new[] { "CreatedDateTime", "PublicationDate" },
                values: new object[] { new DateTime(2024, 8, 16, 16, 32, 4, 679, DateTimeKind.Utc).AddTicks(6766), new DateTime(2023, 12, 28, 3, 12, 42, 753, DateTimeKind.Local).AddTicks(9673) });

            migrationBuilder.UpdateData(
                table: "Book",
                keyColumn: "BookId",
                keyValue: 1689,
                columns: new[] { "CreatedDateTime", "PublicationDate" },
                values: new object[] { new DateTime(2024, 8, 16, 16, 32, 4, 679, DateTimeKind.Utc).AddTicks(6888), new DateTime(2023, 11, 20, 3, 58, 36, 316, DateTimeKind.Local).AddTicks(9146) });

            migrationBuilder.UpdateData(
                table: "Book",
                keyColumn: "BookId",
                keyValue: 1690,
                columns: new[] { "CreatedDateTime", "PublicationDate" },
                values: new object[] { new DateTime(2024, 8, 16, 16, 32, 4, 679, DateTimeKind.Utc).AddTicks(6984), new DateTime(2024, 7, 26, 8, 11, 48, 526, DateTimeKind.Local).AddTicks(2624) });

            migrationBuilder.UpdateData(
                table: "Book",
                keyColumn: "BookId",
                keyValue: 1691,
                columns: new[] { "CreatedDateTime", "PublicationDate" },
                values: new object[] { new DateTime(2024, 8, 16, 16, 32, 4, 679, DateTimeKind.Utc).AddTicks(7106), new DateTime(2024, 7, 27, 9, 5, 16, 826, DateTimeKind.Local).AddTicks(7550) });

            migrationBuilder.UpdateData(
                table: "Book",
                keyColumn: "BookId",
                keyValue: 1692,
                columns: new[] { "CreatedDateTime", "PublicationDate" },
                values: new object[] { new DateTime(2024, 8, 16, 16, 32, 4, 679, DateTimeKind.Utc).AddTicks(7198), new DateTime(2024, 6, 1, 23, 12, 6, 184, DateTimeKind.Local).AddTicks(5922) });

            migrationBuilder.UpdateData(
                table: "Book",
                keyColumn: "BookId",
                keyValue: 1693,
                columns: new[] { "CreatedDateTime", "PublicationDate" },
                values: new object[] { new DateTime(2024, 8, 16, 16, 32, 4, 679, DateTimeKind.Utc).AddTicks(7323), new DateTime(2023, 12, 7, 22, 45, 48, 300, DateTimeKind.Local).AddTicks(2203) });

            migrationBuilder.UpdateData(
                table: "Book",
                keyColumn: "BookId",
                keyValue: 1694,
                columns: new[] { "CreatedDateTime", "PublicationDate" },
                values: new object[] { new DateTime(2024, 8, 16, 16, 32, 4, 679, DateTimeKind.Utc).AddTicks(7442), new DateTime(2024, 4, 6, 19, 37, 43, 417, DateTimeKind.Local).AddTicks(7644) });

            migrationBuilder.UpdateData(
                table: "Book",
                keyColumn: "BookId",
                keyValue: 1695,
                columns: new[] { "CreatedDateTime", "PublicationDate" },
                values: new object[] { new DateTime(2024, 8, 16, 16, 32, 4, 679, DateTimeKind.Utc).AddTicks(7546), new DateTime(2024, 5, 30, 15, 14, 25, 739, DateTimeKind.Local).AddTicks(5454) });

            migrationBuilder.UpdateData(
                table: "Book",
                keyColumn: "BookId",
                keyValue: 1696,
                columns: new[] { "CreatedDateTime", "PublicationDate" },
                values: new object[] { new DateTime(2024, 8, 16, 16, 32, 4, 679, DateTimeKind.Utc).AddTicks(7664), new DateTime(2024, 5, 12, 11, 56, 17, 980, DateTimeKind.Local).AddTicks(4939) });

            migrationBuilder.UpdateData(
                table: "Book",
                keyColumn: "BookId",
                keyValue: 1697,
                columns: new[] { "CreatedDateTime", "PublicationDate" },
                values: new object[] { new DateTime(2024, 8, 16, 16, 32, 4, 679, DateTimeKind.Utc).AddTicks(7768), new DateTime(2023, 12, 7, 14, 40, 35, 429, DateTimeKind.Local).AddTicks(5570) });

            migrationBuilder.UpdateData(
                table: "Book",
                keyColumn: "BookId",
                keyValue: 1698,
                columns: new[] { "CreatedDateTime", "PublicationDate" },
                values: new object[] { new DateTime(2024, 8, 16, 16, 32, 4, 679, DateTimeKind.Utc).AddTicks(7882), new DateTime(2024, 5, 18, 20, 48, 23, 212, DateTimeKind.Local).AddTicks(7965) });

            migrationBuilder.UpdateData(
                table: "Book",
                keyColumn: "BookId",
                keyValue: 1699,
                columns: new[] { "CreatedDateTime", "PublicationDate" },
                values: new object[] { new DateTime(2024, 8, 16, 16, 32, 4, 679, DateTimeKind.Utc).AddTicks(7972), new DateTime(2023, 12, 31, 4, 29, 52, 14, DateTimeKind.Local).AddTicks(5573) });

            migrationBuilder.UpdateData(
                table: "Book",
                keyColumn: "BookId",
                keyValue: 1700,
                columns: new[] { "CreatedDateTime", "PublicationDate" },
                values: new object[] { new DateTime(2024, 8, 16, 16, 32, 4, 679, DateTimeKind.Utc).AddTicks(8097), new DateTime(2024, 3, 1, 8, 29, 23, 975, DateTimeKind.Local).AddTicks(9276) });

            migrationBuilder.UpdateData(
                table: "Book",
                keyColumn: "BookId",
                keyValue: 1701,
                columns: new[] { "CreatedDateTime", "PublicationDate" },
                values: new object[] { new DateTime(2024, 8, 16, 16, 32, 4, 679, DateTimeKind.Utc).AddTicks(8195), new DateTime(2023, 8, 18, 2, 46, 10, 974, DateTimeKind.Local).AddTicks(4525) });

            migrationBuilder.UpdateData(
                table: "Book",
                keyColumn: "BookId",
                keyValue: 1702,
                columns: new[] { "CreatedDateTime", "PublicationDate" },
                values: new object[] { new DateTime(2024, 8, 16, 16, 32, 4, 679, DateTimeKind.Utc).AddTicks(8329), new DateTime(2024, 2, 14, 4, 39, 57, 334, DateTimeKind.Local).AddTicks(598) });

            migrationBuilder.UpdateData(
                table: "Book",
                keyColumn: "BookId",
                keyValue: 1703,
                columns: new[] { "CreatedDateTime", "PublicationDate" },
                values: new object[] { new DateTime(2024, 8, 16, 16, 32, 4, 679, DateTimeKind.Utc).AddTicks(8460), new DateTime(2024, 6, 11, 1, 37, 58, 434, DateTimeKind.Local).AddTicks(5305) });

            migrationBuilder.UpdateData(
                table: "Book",
                keyColumn: "BookId",
                keyValue: 1704,
                columns: new[] { "CreatedDateTime", "PublicationDate" },
                values: new object[] { new DateTime(2024, 8, 16, 16, 32, 4, 679, DateTimeKind.Utc).AddTicks(8552), new DateTime(2023, 10, 7, 17, 30, 42, 233, DateTimeKind.Local).AddTicks(9431) });

            migrationBuilder.UpdateData(
                table: "Book",
                keyColumn: "BookId",
                keyValue: 1705,
                columns: new[] { "CreatedDateTime", "PublicationDate" },
                values: new object[] { new DateTime(2024, 8, 16, 16, 32, 4, 679, DateTimeKind.Utc).AddTicks(8684), new DateTime(2023, 11, 30, 18, 2, 1, 354, DateTimeKind.Local).AddTicks(2409) });

            migrationBuilder.UpdateData(
                table: "Book",
                keyColumn: "BookId",
                keyValue: 1706,
                columns: new[] { "CreatedDateTime", "PublicationDate" },
                values: new object[] { new DateTime(2024, 8, 16, 16, 32, 4, 679, DateTimeKind.Utc).AddTicks(8782), new DateTime(2024, 2, 18, 11, 49, 9, 772, DateTimeKind.Local).AddTicks(6705) });

            migrationBuilder.UpdateData(
                table: "Book",
                keyColumn: "BookId",
                keyValue: 1707,
                columns: new[] { "CreatedDateTime", "PublicationDate" },
                values: new object[] { new DateTime(2024, 8, 16, 16, 32, 4, 679, DateTimeKind.Utc).AddTicks(8905), new DateTime(2024, 4, 20, 8, 22, 48, 822, DateTimeKind.Local).AddTicks(9721) });

            migrationBuilder.UpdateData(
                table: "Book",
                keyColumn: "BookId",
                keyValue: 1708,
                columns: new[] { "CreatedDateTime", "PublicationDate" },
                values: new object[] { new DateTime(2024, 8, 16, 16, 32, 4, 679, DateTimeKind.Utc).AddTicks(9007), new DateTime(2024, 2, 5, 7, 2, 29, 390, DateTimeKind.Local).AddTicks(9456) });

            migrationBuilder.UpdateData(
                table: "Book",
                keyColumn: "BookId",
                keyValue: 1709,
                columns: new[] { "CreatedDateTime", "PublicationDate" },
                values: new object[] { new DateTime(2024, 8, 16, 16, 32, 4, 679, DateTimeKind.Utc).AddTicks(9133), new DateTime(2024, 2, 11, 17, 26, 46, 221, DateTimeKind.Local).AddTicks(9636) });

            migrationBuilder.UpdateData(
                table: "Book",
                keyColumn: "BookId",
                keyValue: 1710,
                columns: new[] { "CreatedDateTime", "PublicationDate" },
                values: new object[] { new DateTime(2024, 8, 16, 16, 32, 4, 679, DateTimeKind.Utc).AddTicks(9234), new DateTime(2024, 4, 20, 17, 2, 51, 865, DateTimeKind.Local).AddTicks(6034) });

            migrationBuilder.UpdateData(
                table: "Book",
                keyColumn: "BookId",
                keyValue: 1711,
                columns: new[] { "CreatedDateTime", "PublicationDate" },
                values: new object[] { new DateTime(2024, 8, 16, 16, 32, 4, 679, DateTimeKind.Utc).AddTicks(9360), new DateTime(2024, 6, 14, 5, 11, 14, 803, DateTimeKind.Local).AddTicks(4804) });

            migrationBuilder.UpdateData(
                table: "Book",
                keyColumn: "BookId",
                keyValue: 1712,
                columns: new[] { "CreatedDateTime", "PublicationDate" },
                values: new object[] { new DateTime(2024, 8, 16, 16, 32, 4, 679, DateTimeKind.Utc).AddTicks(9452), new DateTime(2024, 5, 23, 14, 14, 47, 391, DateTimeKind.Local).AddTicks(478) });

            migrationBuilder.UpdateData(
                table: "Book",
                keyColumn: "BookId",
                keyValue: 1713,
                columns: new[] { "CreatedDateTime", "PublicationDate" },
                values: new object[] { new DateTime(2024, 8, 16, 16, 32, 4, 679, DateTimeKind.Utc).AddTicks(9561), new DateTime(2024, 1, 15, 0, 52, 47, 361, DateTimeKind.Local).AddTicks(2738) });

            migrationBuilder.UpdateData(
                table: "Book",
                keyColumn: "BookId",
                keyValue: 1714,
                columns: new[] { "CreatedDateTime", "PublicationDate" },
                values: new object[] { new DateTime(2024, 8, 16, 16, 32, 4, 679, DateTimeKind.Utc).AddTicks(9653), new DateTime(2024, 6, 9, 7, 46, 14, 382, DateTimeKind.Local).AddTicks(2463) });

            migrationBuilder.UpdateData(
                table: "Book",
                keyColumn: "BookId",
                keyValue: 1715,
                columns: new[] { "CreatedDateTime", "PublicationDate" },
                values: new object[] { new DateTime(2024, 8, 16, 16, 32, 4, 679, DateTimeKind.Utc).AddTicks(9790), new DateTime(2024, 3, 28, 11, 58, 13, 97, DateTimeKind.Local).AddTicks(8856) });

            migrationBuilder.UpdateData(
                table: "Book",
                keyColumn: "BookId",
                keyValue: 1716,
                columns: new[] { "CreatedDateTime", "PublicationDate" },
                values: new object[] { new DateTime(2024, 8, 16, 16, 32, 4, 679, DateTimeKind.Utc).AddTicks(9929), new DateTime(2023, 8, 30, 23, 32, 33, 492, DateTimeKind.Local).AddTicks(8701) });

            migrationBuilder.UpdateData(
                table: "Book",
                keyColumn: "BookId",
                keyValue: 1717,
                columns: new[] { "CreatedDateTime", "PublicationDate" },
                values: new object[] { new DateTime(2024, 8, 16, 16, 32, 4, 680, DateTimeKind.Utc).AddTicks(17), new DateTime(2023, 12, 3, 0, 7, 24, 122, DateTimeKind.Local).AddTicks(7807) });

            migrationBuilder.UpdateData(
                table: "Book",
                keyColumn: "BookId",
                keyValue: 1718,
                columns: new[] { "CreatedDateTime", "PublicationDate" },
                values: new object[] { new DateTime(2024, 8, 16, 16, 32, 4, 680, DateTimeKind.Utc).AddTicks(148), new DateTime(2024, 4, 16, 18, 4, 13, 766, DateTimeKind.Local).AddTicks(4622) });

            migrationBuilder.UpdateData(
                table: "Book",
                keyColumn: "BookId",
                keyValue: 1719,
                columns: new[] { "CreatedDateTime", "PublicationDate" },
                values: new object[] { new DateTime(2024, 8, 16, 16, 32, 4, 680, DateTimeKind.Utc).AddTicks(235), new DateTime(2024, 4, 9, 17, 24, 44, 116, DateTimeKind.Local).AddTicks(8410) });

            migrationBuilder.UpdateData(
                table: "Book",
                keyColumn: "BookId",
                keyValue: 1720,
                columns: new[] { "CreatedDateTime", "PublicationDate" },
                values: new object[] { new DateTime(2024, 8, 16, 16, 32, 4, 680, DateTimeKind.Utc).AddTicks(327), new DateTime(2024, 8, 9, 23, 22, 12, 169, DateTimeKind.Local).AddTicks(9105) });

            migrationBuilder.UpdateData(
                table: "Book",
                keyColumn: "BookId",
                keyValue: 1721,
                columns: new[] { "CreatedDateTime", "PublicationDate" },
                values: new object[] { new DateTime(2024, 8, 16, 16, 32, 4, 680, DateTimeKind.Utc).AddTicks(452), new DateTime(2023, 9, 22, 3, 40, 57, 19, DateTimeKind.Local).AddTicks(1772) });

            migrationBuilder.UpdateData(
                table: "Book",
                keyColumn: "BookId",
                keyValue: 1722,
                columns: new[] { "CreatedDateTime", "PublicationDate" },
                values: new object[] { new DateTime(2024, 8, 16, 16, 32, 4, 680, DateTimeKind.Utc).AddTicks(581), new DateTime(2024, 6, 11, 22, 11, 8, 154, DateTimeKind.Local).AddTicks(6361) });

            migrationBuilder.UpdateData(
                table: "Book",
                keyColumn: "BookId",
                keyValue: 1723,
                columns: new[] { "CreatedDateTime", "PublicationDate" },
                values: new object[] { new DateTime(2024, 8, 16, 16, 32, 4, 680, DateTimeKind.Utc).AddTicks(674), new DateTime(2024, 3, 11, 6, 28, 5, 503, DateTimeKind.Local).AddTicks(2516) });

            migrationBuilder.UpdateData(
                table: "Book",
                keyColumn: "BookId",
                keyValue: 1724,
                columns: new[] { "CreatedDateTime", "PublicationDate" },
                values: new object[] { new DateTime(2024, 8, 16, 16, 32, 4, 680, DateTimeKind.Utc).AddTicks(800), new DateTime(2023, 12, 3, 7, 36, 47, 861, DateTimeKind.Local).AddTicks(4712) });

            migrationBuilder.UpdateData(
                table: "Book",
                keyColumn: "BookId",
                keyValue: 1725,
                columns: new[] { "CreatedDateTime", "PublicationDate" },
                values: new object[] { new DateTime(2024, 8, 16, 16, 32, 4, 680, DateTimeKind.Utc).AddTicks(902), new DateTime(2024, 3, 7, 17, 42, 13, 174, DateTimeKind.Local).AddTicks(7097) });

            migrationBuilder.UpdateData(
                table: "Book",
                keyColumn: "BookId",
                keyValue: 1726,
                columns: new[] { "CreatedDateTime", "PublicationDate" },
                values: new object[] { new DateTime(2024, 8, 16, 16, 32, 4, 680, DateTimeKind.Utc).AddTicks(1029), new DateTime(2023, 9, 27, 18, 35, 33, 513, DateTimeKind.Local).AddTicks(6675) });

            migrationBuilder.UpdateData(
                table: "Book",
                keyColumn: "BookId",
                keyValue: 1727,
                columns: new[] { "CreatedDateTime", "PublicationDate" },
                values: new object[] { new DateTime(2024, 8, 16, 16, 32, 4, 680, DateTimeKind.Utc).AddTicks(1114), new DateTime(2023, 8, 18, 20, 54, 46, 504, DateTimeKind.Local).AddTicks(8671) });

            migrationBuilder.UpdateData(
                table: "Book",
                keyColumn: "BookId",
                keyValue: 1728,
                columns: new[] { "CreatedDateTime", "PublicationDate" },
                values: new object[] { new DateTime(2024, 8, 16, 16, 32, 4, 680, DateTimeKind.Utc).AddTicks(1225), new DateTime(2024, 5, 21, 9, 32, 27, 55, DateTimeKind.Local).AddTicks(1785) });

            migrationBuilder.UpdateData(
                table: "Book",
                keyColumn: "BookId",
                keyValue: 1729,
                columns: new[] { "CreatedDateTime", "PublicationDate" },
                values: new object[] { new DateTime(2024, 8, 16, 16, 32, 4, 680, DateTimeKind.Utc).AddTicks(1314), new DateTime(2023, 12, 18, 12, 12, 6, 43, DateTimeKind.Local).AddTicks(6329) });

            migrationBuilder.UpdateData(
                table: "Book",
                keyColumn: "BookId",
                keyValue: 1730,
                columns: new[] { "CreatedDateTime", "PublicationDate" },
                values: new object[] { new DateTime(2024, 8, 16, 16, 32, 4, 680, DateTimeKind.Utc).AddTicks(1439), new DateTime(2024, 4, 21, 16, 17, 30, 85, DateTimeKind.Local).AddTicks(4904) });

            migrationBuilder.UpdateData(
                table: "Book",
                keyColumn: "BookId",
                keyValue: 1731,
                columns: new[] { "CreatedDateTime", "PublicationDate" },
                values: new object[] { new DateTime(2024, 8, 16, 16, 32, 4, 680, DateTimeKind.Utc).AddTicks(1527), new DateTime(2024, 4, 2, 7, 40, 34, 238, DateTimeKind.Local).AddTicks(7937) });

            migrationBuilder.UpdateData(
                table: "Book",
                keyColumn: "BookId",
                keyValue: 1732,
                columns: new[] { "CreatedDateTime", "PublicationDate" },
                values: new object[] { new DateTime(2024, 8, 16, 16, 32, 4, 680, DateTimeKind.Utc).AddTicks(1655), new DateTime(2024, 4, 2, 14, 13, 14, 203, DateTimeKind.Local).AddTicks(2393) });

            migrationBuilder.UpdateData(
                table: "Book",
                keyColumn: "BookId",
                keyValue: 1733,
                columns: new[] { "CreatedDateTime", "PublicationDate" },
                values: new object[] { new DateTime(2024, 8, 16, 16, 32, 4, 680, DateTimeKind.Utc).AddTicks(1757), new DateTime(2024, 2, 6, 1, 44, 58, 989, DateTimeKind.Local).AddTicks(7338) });

            migrationBuilder.UpdateData(
                table: "Book",
                keyColumn: "BookId",
                keyValue: 1734,
                columns: new[] { "CreatedDateTime", "PublicationDate" },
                values: new object[] { new DateTime(2024, 8, 16, 16, 32, 4, 680, DateTimeKind.Utc).AddTicks(1876), new DateTime(2024, 7, 9, 22, 25, 16, 592, DateTimeKind.Local).AddTicks(2479) });

            migrationBuilder.UpdateData(
                table: "Book",
                keyColumn: "BookId",
                keyValue: 1735,
                columns: new[] { "CreatedDateTime", "PublicationDate" },
                values: new object[] { new DateTime(2024, 8, 16, 16, 32, 4, 680, DateTimeKind.Utc).AddTicks(1966), new DateTime(2024, 3, 24, 13, 33, 52, 38, DateTimeKind.Local).AddTicks(7717) });

            migrationBuilder.UpdateData(
                table: "Book",
                keyColumn: "BookId",
                keyValue: 1736,
                columns: new[] { "CreatedDateTime", "PublicationDate" },
                values: new object[] { new DateTime(2024, 8, 16, 16, 32, 4, 680, DateTimeKind.Utc).AddTicks(2077), new DateTime(2024, 3, 27, 5, 19, 35, 288, DateTimeKind.Local).AddTicks(4652) });

            migrationBuilder.UpdateData(
                table: "Book",
                keyColumn: "BookId",
                keyValue: 1737,
                columns: new[] { "CreatedDateTime", "PublicationDate" },
                values: new object[] { new DateTime(2024, 8, 16, 16, 32, 4, 680, DateTimeKind.Utc).AddTicks(2173), new DateTime(2024, 8, 14, 14, 18, 27, 68, DateTimeKind.Local).AddTicks(8664) });

            migrationBuilder.UpdateData(
                table: "Book",
                keyColumn: "BookId",
                keyValue: 1738,
                columns: new[] { "CreatedDateTime", "PublicationDate" },
                values: new object[] { new DateTime(2024, 8, 16, 16, 32, 4, 680, DateTimeKind.Utc).AddTicks(2297), new DateTime(2023, 10, 11, 21, 3, 18, 658, DateTimeKind.Local).AddTicks(3921) });

            migrationBuilder.UpdateData(
                table: "Book",
                keyColumn: "BookId",
                keyValue: 1739,
                columns: new[] { "CreatedDateTime", "PublicationDate" },
                values: new object[] { new DateTime(2024, 8, 16, 16, 32, 4, 680, DateTimeKind.Utc).AddTicks(2392), new DateTime(2023, 8, 19, 19, 3, 54, 991, DateTimeKind.Local).AddTicks(2413) });

            migrationBuilder.UpdateData(
                table: "Book",
                keyColumn: "BookId",
                keyValue: 1740,
                columns: new[] { "CreatedDateTime", "PublicationDate" },
                values: new object[] { new DateTime(2024, 8, 16, 16, 32, 4, 680, DateTimeKind.Utc).AddTicks(2507), new DateTime(2023, 11, 1, 6, 47, 15, 511, DateTimeKind.Local).AddTicks(1549) });

            migrationBuilder.UpdateData(
                table: "Book",
                keyColumn: "BookId",
                keyValue: 1741,
                columns: new[] { "CreatedDateTime", "PublicationDate" },
                values: new object[] { new DateTime(2024, 8, 16, 16, 32, 4, 680, DateTimeKind.Utc).AddTicks(2593), new DateTime(2023, 11, 17, 10, 32, 33, 589, DateTimeKind.Local).AddTicks(5311) });

            migrationBuilder.UpdateData(
                table: "Book",
                keyColumn: "BookId",
                keyValue: 1742,
                columns: new[] { "CreatedDateTime", "PublicationDate" },
                values: new object[] { new DateTime(2024, 8, 16, 16, 32, 4, 680, DateTimeKind.Utc).AddTicks(2723), new DateTime(2023, 11, 19, 14, 58, 19, 833, DateTimeKind.Local).AddTicks(4514) });

            migrationBuilder.UpdateData(
                table: "Book",
                keyColumn: "BookId",
                keyValue: 1743,
                columns: new[] { "CreatedDateTime", "PublicationDate" },
                values: new object[] { new DateTime(2024, 8, 16, 16, 32, 4, 680, DateTimeKind.Utc).AddTicks(2822), new DateTime(2023, 12, 31, 20, 37, 37, 14, DateTimeKind.Local).AddTicks(7829) });

            migrationBuilder.UpdateData(
                table: "Book",
                keyColumn: "BookId",
                keyValue: 1744,
                columns: new[] { "CreatedDateTime", "PublicationDate" },
                values: new object[] { new DateTime(2024, 8, 16, 16, 32, 4, 680, DateTimeKind.Utc).AddTicks(2921), new DateTime(2023, 11, 9, 23, 43, 19, 600, DateTimeKind.Local).AddTicks(268) });

            migrationBuilder.UpdateData(
                table: "Book",
                keyColumn: "BookId",
                keyValue: 1745,
                columns: new[] { "CreatedDateTime", "PublicationDate" },
                values: new object[] { new DateTime(2024, 8, 16, 16, 32, 4, 680, DateTimeKind.Utc).AddTicks(3024), new DateTime(2024, 7, 14, 17, 10, 38, 129, DateTimeKind.Local).AddTicks(1951) });

            migrationBuilder.UpdateData(
                table: "Book",
                keyColumn: "BookId",
                keyValue: 1746,
                columns: new[] { "CreatedDateTime", "PublicationDate" },
                values: new object[] { new DateTime(2024, 8, 16, 16, 32, 4, 680, DateTimeKind.Utc).AddTicks(3151), new DateTime(2024, 6, 16, 11, 46, 21, 413, DateTimeKind.Local).AddTicks(1653) });

            migrationBuilder.UpdateData(
                table: "Book",
                keyColumn: "BookId",
                keyValue: 1747,
                columns: new[] { "CreatedDateTime", "PublicationDate" },
                values: new object[] { new DateTime(2024, 8, 16, 16, 32, 4, 680, DateTimeKind.Utc).AddTicks(3253), new DateTime(2023, 9, 24, 15, 40, 45, 384, DateTimeKind.Local).AddTicks(2958) });

            migrationBuilder.UpdateData(
                table: "Book",
                keyColumn: "BookId",
                keyValue: 1748,
                columns: new[] { "CreatedDateTime", "PublicationDate" },
                values: new object[] { new DateTime(2024, 8, 16, 16, 32, 4, 680, DateTimeKind.Utc).AddTicks(3379), new DateTime(2024, 7, 29, 22, 27, 55, 417, DateTimeKind.Local).AddTicks(2880) });

            migrationBuilder.UpdateData(
                table: "Book",
                keyColumn: "BookId",
                keyValue: 1749,
                columns: new[] { "CreatedDateTime", "PublicationDate" },
                values: new object[] { new DateTime(2024, 8, 16, 16, 32, 4, 680, DateTimeKind.Utc).AddTicks(3487), new DateTime(2024, 3, 16, 23, 46, 41, 112, DateTimeKind.Local).AddTicks(83) });

            migrationBuilder.UpdateData(
                table: "Book",
                keyColumn: "BookId",
                keyValue: 1750,
                columns: new[] { "CreatedDateTime", "PublicationDate" },
                values: new object[] { new DateTime(2024, 8, 16, 16, 32, 4, 680, DateTimeKind.Utc).AddTicks(3615), new DateTime(2024, 2, 16, 10, 16, 33, 676, DateTimeKind.Local).AddTicks(1483) });

            migrationBuilder.UpdateData(
                table: "Book",
                keyColumn: "BookId",
                keyValue: 1751,
                columns: new[] { "CreatedDateTime", "PublicationDate" },
                values: new object[] { new DateTime(2024, 8, 16, 16, 32, 4, 680, DateTimeKind.Utc).AddTicks(3718), new DateTime(2024, 6, 22, 2, 50, 40, 279, DateTimeKind.Local).AddTicks(6379) });

            migrationBuilder.UpdateData(
                table: "Book",
                keyColumn: "BookId",
                keyValue: 1752,
                columns: new[] { "CreatedDateTime", "PublicationDate" },
                values: new object[] { new DateTime(2024, 8, 16, 16, 32, 4, 680, DateTimeKind.Utc).AddTicks(3836), new DateTime(2024, 2, 4, 15, 51, 27, 61, DateTimeKind.Local).AddTicks(4581) });

            migrationBuilder.UpdateData(
                table: "Book",
                keyColumn: "BookId",
                keyValue: 1753,
                columns: new[] { "CreatedDateTime", "PublicationDate" },
                values: new object[] { new DateTime(2024, 8, 16, 16, 32, 4, 680, DateTimeKind.Utc).AddTicks(3931), new DateTime(2024, 6, 3, 6, 18, 38, 927, DateTimeKind.Local).AddTicks(2889) });

            migrationBuilder.UpdateData(
                table: "Book",
                keyColumn: "BookId",
                keyValue: 1754,
                columns: new[] { "CreatedDateTime", "PublicationDate" },
                values: new object[] { new DateTime(2024, 8, 16, 16, 32, 4, 680, DateTimeKind.Utc).AddTicks(4046), new DateTime(2024, 4, 30, 9, 45, 42, 323, DateTimeKind.Local).AddTicks(6885) });

            migrationBuilder.UpdateData(
                table: "Book",
                keyColumn: "BookId",
                keyValue: 1755,
                columns: new[] { "CreatedDateTime", "PublicationDate" },
                values: new object[] { new DateTime(2024, 8, 16, 16, 32, 4, 680, DateTimeKind.Utc).AddTicks(4160), new DateTime(2023, 12, 14, 14, 4, 4, 586, DateTimeKind.Local).AddTicks(9976) });

            migrationBuilder.UpdateData(
                table: "Book",
                keyColumn: "BookId",
                keyValue: 1756,
                columns: new[] { "CreatedDateTime", "PublicationDate" },
                values: new object[] { new DateTime(2024, 8, 16, 16, 32, 4, 680, DateTimeKind.Utc).AddTicks(4261), new DateTime(2024, 2, 16, 15, 21, 57, 211, DateTimeKind.Local).AddTicks(1146) });

            migrationBuilder.UpdateData(
                table: "Book",
                keyColumn: "BookId",
                keyValue: 1757,
                columns: new[] { "CreatedDateTime", "PublicationDate" },
                values: new object[] { new DateTime(2024, 8, 16, 16, 32, 4, 680, DateTimeKind.Utc).AddTicks(4386), new DateTime(2024, 1, 2, 23, 1, 31, 323, DateTimeKind.Local).AddTicks(8541) });

            migrationBuilder.UpdateData(
                table: "Book",
                keyColumn: "BookId",
                keyValue: 1758,
                columns: new[] { "CreatedDateTime", "PublicationDate" },
                values: new object[] { new DateTime(2024, 8, 16, 16, 32, 4, 680, DateTimeKind.Utc).AddTicks(4475), new DateTime(2023, 11, 14, 5, 4, 46, 648, DateTimeKind.Local).AddTicks(1001) });

            migrationBuilder.UpdateData(
                table: "Book",
                keyColumn: "BookId",
                keyValue: 1759,
                columns: new[] { "CreatedDateTime", "PublicationDate" },
                values: new object[] { new DateTime(2024, 8, 16, 16, 32, 4, 680, DateTimeKind.Utc).AddTicks(4561), new DateTime(2024, 4, 29, 15, 50, 14, 274, DateTimeKind.Local).AddTicks(6805) });

            migrationBuilder.UpdateData(
                table: "Book",
                keyColumn: "BookId",
                keyValue: 1760,
                columns: new[] { "CreatedDateTime", "PublicationDate" },
                values: new object[] { new DateTime(2024, 8, 16, 16, 32, 4, 680, DateTimeKind.Utc).AddTicks(4669), new DateTime(2024, 1, 2, 19, 54, 27, 163, DateTimeKind.Local).AddTicks(8770) });

            migrationBuilder.UpdateData(
                table: "Book",
                keyColumn: "BookId",
                keyValue: 1761,
                columns: new[] { "CreatedDateTime", "PublicationDate" },
                values: new object[] { new DateTime(2024, 8, 16, 16, 32, 4, 680, DateTimeKind.Utc).AddTicks(4763), new DateTime(2024, 6, 1, 18, 16, 26, 892, DateTimeKind.Local).AddTicks(5440) });

            migrationBuilder.UpdateData(
                table: "Book",
                keyColumn: "BookId",
                keyValue: 1762,
                columns: new[] { "CreatedDateTime", "PublicationDate" },
                values: new object[] { new DateTime(2024, 8, 16, 16, 32, 4, 680, DateTimeKind.Utc).AddTicks(4900), new DateTime(2024, 6, 14, 21, 51, 49, 861, DateTimeKind.Local).AddTicks(1694) });

            migrationBuilder.UpdateData(
                table: "Book",
                keyColumn: "BookId",
                keyValue: 1763,
                columns: new[] { "CreatedDateTime", "PublicationDate" },
                values: new object[] { new DateTime(2024, 8, 16, 16, 32, 4, 680, DateTimeKind.Utc).AddTicks(5029), new DateTime(2024, 6, 16, 2, 18, 54, 821, DateTimeKind.Local).AddTicks(6650) });

            migrationBuilder.UpdateData(
                table: "Book",
                keyColumn: "BookId",
                keyValue: 1764,
                columns: new[] { "CreatedDateTime", "PublicationDate" },
                values: new object[] { new DateTime(2024, 8, 16, 16, 32, 4, 680, DateTimeKind.Utc).AddTicks(5131), new DateTime(2024, 3, 14, 7, 25, 23, 175, DateTimeKind.Local).AddTicks(9366) });

            migrationBuilder.UpdateData(
                table: "Book",
                keyColumn: "BookId",
                keyValue: 1765,
                columns: new[] { "CreatedDateTime", "PublicationDate" },
                values: new object[] { new DateTime(2024, 8, 16, 16, 32, 4, 680, DateTimeKind.Utc).AddTicks(5249), new DateTime(2023, 9, 10, 14, 20, 51, 292, DateTimeKind.Local).AddTicks(2878) });

            migrationBuilder.UpdateData(
                table: "Book",
                keyColumn: "BookId",
                keyValue: 1766,
                columns: new[] { "CreatedDateTime", "PublicationDate" },
                values: new object[] { new DateTime(2024, 8, 16, 16, 32, 4, 680, DateTimeKind.Utc).AddTicks(5345), new DateTime(2024, 4, 28, 2, 28, 50, 715, DateTimeKind.Local).AddTicks(4254) });

            migrationBuilder.UpdateData(
                table: "Book",
                keyColumn: "BookId",
                keyValue: 1767,
                columns: new[] { "CreatedDateTime", "PublicationDate" },
                values: new object[] { new DateTime(2024, 8, 16, 16, 32, 4, 680, DateTimeKind.Utc).AddTicks(5430), new DateTime(2024, 1, 13, 23, 8, 54, 847, DateTimeKind.Local).AddTicks(2445) });

            migrationBuilder.UpdateData(
                table: "Book",
                keyColumn: "BookId",
                keyValue: 1768,
                columns: new[] { "CreatedDateTime", "PublicationDate" },
                values: new object[] { new DateTime(2024, 8, 16, 16, 32, 4, 680, DateTimeKind.Utc).AddTicks(5543), new DateTime(2023, 10, 2, 21, 42, 24, 917, DateTimeKind.Local).AddTicks(6872) });

            migrationBuilder.UpdateData(
                table: "Book",
                keyColumn: "BookId",
                keyValue: 1769,
                columns: new[] { "CreatedDateTime", "PublicationDate" },
                values: new object[] { new DateTime(2024, 8, 16, 16, 32, 4, 680, DateTimeKind.Utc).AddTicks(5637), new DateTime(2024, 7, 15, 11, 33, 22, 206, DateTimeKind.Local).AddTicks(5775) });

            migrationBuilder.UpdateData(
                table: "Book",
                keyColumn: "BookId",
                keyValue: 1770,
                columns: new[] { "CreatedDateTime", "PublicationDate" },
                values: new object[] { new DateTime(2024, 8, 16, 16, 32, 4, 680, DateTimeKind.Utc).AddTicks(5756), new DateTime(2023, 8, 28, 15, 34, 27, 13, DateTimeKind.Local).AddTicks(9935) });

            migrationBuilder.UpdateData(
                table: "Book",
                keyColumn: "BookId",
                keyValue: 1771,
                columns: new[] { "CreatedDateTime", "PublicationDate" },
                values: new object[] { new DateTime(2024, 8, 16, 16, 32, 4, 680, DateTimeKind.Utc).AddTicks(5848), new DateTime(2024, 2, 23, 17, 19, 26, 923, DateTimeKind.Local).AddTicks(3914) });

            migrationBuilder.UpdateData(
                table: "Book",
                keyColumn: "BookId",
                keyValue: 1772,
                columns: new[] { "CreatedDateTime", "PublicationDate" },
                values: new object[] { new DateTime(2024, 8, 16, 16, 32, 4, 680, DateTimeKind.Utc).AddTicks(5983), new DateTime(2024, 1, 29, 22, 33, 26, 425, DateTimeKind.Local).AddTicks(8495) });

            migrationBuilder.UpdateData(
                table: "Book",
                keyColumn: "BookId",
                keyValue: 1773,
                columns: new[] { "CreatedDateTime", "PublicationDate" },
                values: new object[] { new DateTime(2024, 8, 16, 16, 32, 4, 680, DateTimeKind.Utc).AddTicks(6069), new DateTime(2024, 1, 4, 23, 6, 54, 231, DateTimeKind.Local).AddTicks(655) });

            migrationBuilder.UpdateData(
                table: "Book",
                keyColumn: "BookId",
                keyValue: 1774,
                columns: new[] { "CreatedDateTime", "PublicationDate" },
                values: new object[] { new DateTime(2024, 8, 16, 16, 32, 4, 680, DateTimeKind.Utc).AddTicks(6192), new DateTime(2024, 8, 8, 10, 10, 14, 122, DateTimeKind.Local).AddTicks(6399) });

            migrationBuilder.UpdateData(
                table: "Book",
                keyColumn: "BookId",
                keyValue: 1775,
                columns: new[] { "CreatedDateTime", "PublicationDate" },
                values: new object[] { new DateTime(2024, 8, 16, 16, 32, 4, 680, DateTimeKind.Utc).AddTicks(6286), new DateTime(2024, 8, 13, 6, 46, 24, 969, DateTimeKind.Local).AddTicks(4631) });

            migrationBuilder.UpdateData(
                table: "Book",
                keyColumn: "BookId",
                keyValue: 1776,
                columns: new[] { "CreatedDateTime", "PublicationDate" },
                values: new object[] { new DateTime(2024, 8, 16, 16, 32, 4, 680, DateTimeKind.Utc).AddTicks(6392), new DateTime(2024, 1, 6, 8, 48, 14, 531, DateTimeKind.Local).AddTicks(6794) });

            migrationBuilder.UpdateData(
                table: "Book",
                keyColumn: "BookId",
                keyValue: 1777,
                columns: new[] { "CreatedDateTime", "PublicationDate" },
                values: new object[] { new DateTime(2024, 8, 16, 16, 32, 4, 680, DateTimeKind.Utc).AddTicks(6486), new DateTime(2024, 4, 30, 14, 16, 1, 624, DateTimeKind.Local).AddTicks(2615) });

            migrationBuilder.UpdateData(
                table: "Book",
                keyColumn: "BookId",
                keyValue: 1778,
                columns: new[] { "CreatedDateTime", "PublicationDate" },
                values: new object[] { new DateTime(2024, 8, 16, 16, 32, 4, 680, DateTimeKind.Utc).AddTicks(6616), new DateTime(2023, 11, 27, 5, 54, 17, 548, DateTimeKind.Local).AddTicks(5161) });

            migrationBuilder.UpdateData(
                table: "Book",
                keyColumn: "BookId",
                keyValue: 1779,
                columns: new[] { "CreatedDateTime", "PublicationDate" },
                values: new object[] { new DateTime(2024, 8, 16, 16, 32, 4, 680, DateTimeKind.Utc).AddTicks(6701), new DateTime(2024, 6, 4, 9, 17, 55, 357, DateTimeKind.Local).AddTicks(2999) });

            migrationBuilder.UpdateData(
                table: "Book",
                keyColumn: "BookId",
                keyValue: 1780,
                columns: new[] { "CreatedDateTime", "PublicationDate" },
                values: new object[] { new DateTime(2024, 8, 16, 16, 32, 4, 680, DateTimeKind.Utc).AddTicks(6833), new DateTime(2024, 2, 22, 23, 17, 14, 870, DateTimeKind.Local).AddTicks(3400) });

            migrationBuilder.UpdateData(
                table: "Book",
                keyColumn: "BookId",
                keyValue: 1781,
                columns: new[] { "CreatedDateTime", "PublicationDate" },
                values: new object[] { new DateTime(2024, 8, 16, 16, 32, 4, 680, DateTimeKind.Utc).AddTicks(6927), new DateTime(2024, 3, 31, 15, 9, 16, 118, DateTimeKind.Local).AddTicks(5067) });

            migrationBuilder.UpdateData(
                table: "Book",
                keyColumn: "BookId",
                keyValue: 1782,
                columns: new[] { "CreatedDateTime", "PublicationDate" },
                values: new object[] { new DateTime(2024, 8, 16, 16, 32, 4, 680, DateTimeKind.Utc).AddTicks(7055), new DateTime(2024, 4, 21, 8, 35, 29, 568, DateTimeKind.Local).AddTicks(6848) });

            migrationBuilder.UpdateData(
                table: "Book",
                keyColumn: "BookId",
                keyValue: 1783,
                columns: new[] { "CreatedDateTime", "PublicationDate" },
                values: new object[] { new DateTime(2024, 8, 16, 16, 32, 4, 680, DateTimeKind.Utc).AddTicks(7151), new DateTime(2024, 5, 26, 7, 25, 26, 208, DateTimeKind.Local).AddTicks(5524) });

            migrationBuilder.UpdateData(
                table: "Book",
                keyColumn: "BookId",
                keyValue: 1784,
                columns: new[] { "CreatedDateTime", "PublicationDate" },
                values: new object[] { new DateTime(2024, 8, 16, 16, 32, 4, 680, DateTimeKind.Utc).AddTicks(7264), new DateTime(2023, 12, 16, 0, 27, 53, 238, DateTimeKind.Local).AddTicks(3429) });

            migrationBuilder.UpdateData(
                table: "Book",
                keyColumn: "BookId",
                keyValue: 1785,
                columns: new[] { "CreatedDateTime", "PublicationDate" },
                values: new object[] { new DateTime(2024, 8, 16, 16, 32, 4, 680, DateTimeKind.Utc).AddTicks(7354), new DateTime(2023, 12, 17, 5, 11, 21, 983, DateTimeKind.Local).AddTicks(2422) });

            migrationBuilder.UpdateData(
                table: "Book",
                keyColumn: "BookId",
                keyValue: 1786,
                columns: new[] { "CreatedDateTime", "PublicationDate" },
                values: new object[] { new DateTime(2024, 8, 16, 16, 32, 4, 680, DateTimeKind.Utc).AddTicks(7479), new DateTime(2023, 9, 14, 2, 27, 58, 683, DateTimeKind.Local).AddTicks(2924) });

            migrationBuilder.UpdateData(
                table: "Book",
                keyColumn: "BookId",
                keyValue: 1787,
                columns: new[] { "CreatedDateTime", "PublicationDate" },
                values: new object[] { new DateTime(2024, 8, 16, 16, 32, 4, 680, DateTimeKind.Utc).AddTicks(7572), new DateTime(2023, 9, 20, 4, 54, 28, 497, DateTimeKind.Local).AddTicks(681) });

            migrationBuilder.UpdateData(
                table: "Book",
                keyColumn: "BookId",
                keyValue: 1788,
                columns: new[] { "CreatedDateTime", "PublicationDate" },
                values: new object[] { new DateTime(2024, 8, 16, 16, 32, 4, 680, DateTimeKind.Utc).AddTicks(7687), new DateTime(2024, 5, 19, 3, 6, 38, 536, DateTimeKind.Local).AddTicks(4332) });

            migrationBuilder.UpdateData(
                table: "Book",
                keyColumn: "BookId",
                keyValue: 1789,
                columns: new[] { "CreatedDateTime", "PublicationDate" },
                values: new object[] { new DateTime(2024, 8, 16, 16, 32, 4, 680, DateTimeKind.Utc).AddTicks(7788), new DateTime(2023, 9, 27, 2, 18, 48, 330, DateTimeKind.Local).AddTicks(6887) });

            migrationBuilder.UpdateData(
                table: "Book",
                keyColumn: "BookId",
                keyValue: 1790,
                columns: new[] { "CreatedDateTime", "PublicationDate" },
                values: new object[] { new DateTime(2024, 8, 16, 16, 32, 4, 680, DateTimeKind.Utc).AddTicks(7910), new DateTime(2024, 5, 30, 19, 10, 3, 453, DateTimeKind.Local).AddTicks(8851) });

            migrationBuilder.UpdateData(
                table: "Book",
                keyColumn: "BookId",
                keyValue: 1791,
                columns: new[] { "CreatedDateTime", "PublicationDate" },
                values: new object[] { new DateTime(2024, 8, 16, 16, 32, 4, 680, DateTimeKind.Utc).AddTicks(8011), new DateTime(2024, 5, 20, 0, 51, 1, 310, DateTimeKind.Local).AddTicks(7948) });

            migrationBuilder.UpdateData(
                table: "Book",
                keyColumn: "BookId",
                keyValue: 1792,
                columns: new[] { "CreatedDateTime", "PublicationDate" },
                values: new object[] { new DateTime(2024, 8, 16, 16, 32, 4, 680, DateTimeKind.Utc).AddTicks(8122), new DateTime(2024, 1, 18, 20, 57, 0, 995, DateTimeKind.Local).AddTicks(7239) });

            migrationBuilder.UpdateData(
                table: "Book",
                keyColumn: "BookId",
                keyValue: 1793,
                columns: new[] { "CreatedDateTime", "PublicationDate" },
                values: new object[] { new DateTime(2024, 8, 16, 16, 32, 4, 680, DateTimeKind.Utc).AddTicks(8216), new DateTime(2024, 2, 25, 7, 22, 40, 606, DateTimeKind.Local).AddTicks(4607) });

            migrationBuilder.UpdateData(
                table: "Book",
                keyColumn: "BookId",
                keyValue: 1794,
                columns: new[] { "CreatedDateTime", "PublicationDate" },
                values: new object[] { new DateTime(2024, 8, 16, 16, 32, 4, 680, DateTimeKind.Utc).AddTicks(8348), new DateTime(2023, 10, 6, 4, 10, 30, 697, DateTimeKind.Local).AddTicks(1665) });

            migrationBuilder.UpdateData(
                table: "Book",
                keyColumn: "BookId",
                keyValue: 1795,
                columns: new[] { "CreatedDateTime", "PublicationDate" },
                values: new object[] { new DateTime(2024, 8, 16, 16, 32, 4, 680, DateTimeKind.Utc).AddTicks(8436), new DateTime(2024, 3, 7, 0, 17, 50, 795, DateTimeKind.Local).AddTicks(9455) });

            migrationBuilder.UpdateData(
                table: "Book",
                keyColumn: "BookId",
                keyValue: 1796,
                columns: new[] { "CreatedDateTime", "PublicationDate" },
                values: new object[] { new DateTime(2024, 8, 16, 16, 32, 4, 680, DateTimeKind.Utc).AddTicks(8563), new DateTime(2024, 6, 22, 19, 50, 31, 614, DateTimeKind.Local).AddTicks(1451) });

            migrationBuilder.UpdateData(
                table: "Book",
                keyColumn: "BookId",
                keyValue: 1797,
                columns: new[] { "CreatedDateTime", "PublicationDate" },
                values: new object[] { new DateTime(2024, 8, 16, 16, 32, 4, 680, DateTimeKind.Utc).AddTicks(8647), new DateTime(2024, 3, 25, 11, 56, 55, 569, DateTimeKind.Local).AddTicks(5626) });

            migrationBuilder.UpdateData(
                table: "Book",
                keyColumn: "BookId",
                keyValue: 1798,
                columns: new[] { "CreatedDateTime", "PublicationDate" },
                values: new object[] { new DateTime(2024, 8, 16, 16, 32, 4, 680, DateTimeKind.Utc).AddTicks(8782), new DateTime(2024, 4, 11, 16, 0, 47, 741, DateTimeKind.Local).AddTicks(7923) });

            migrationBuilder.UpdateData(
                table: "Book",
                keyColumn: "BookId",
                keyValue: 1799,
                columns: new[] { "CreatedDateTime", "PublicationDate" },
                values: new object[] { new DateTime(2024, 8, 16, 16, 32, 4, 680, DateTimeKind.Utc).AddTicks(8902), new DateTime(2024, 4, 29, 7, 50, 1, 447, DateTimeKind.Local).AddTicks(6764) });

            migrationBuilder.UpdateData(
                table: "Book",
                keyColumn: "BookId",
                keyValue: 1800,
                columns: new[] { "CreatedDateTime", "PublicationDate" },
                values: new object[] { new DateTime(2024, 8, 16, 16, 32, 4, 680, DateTimeKind.Utc).AddTicks(8993), new DateTime(2023, 11, 26, 6, 12, 43, 607, DateTimeKind.Local).AddTicks(2499) });

            migrationBuilder.UpdateData(
                table: "Book",
                keyColumn: "BookId",
                keyValue: 1801,
                columns: new[] { "CreatedDateTime", "PublicationDate" },
                values: new object[] { new DateTime(2024, 8, 16, 16, 32, 4, 680, DateTimeKind.Utc).AddTicks(9116), new DateTime(2024, 7, 10, 22, 22, 40, 700, DateTimeKind.Local).AddTicks(9591) });

            migrationBuilder.UpdateData(
                table: "Book",
                keyColumn: "BookId",
                keyValue: 1802,
                columns: new[] { "CreatedDateTime", "PublicationDate" },
                values: new object[] { new DateTime(2024, 8, 16, 16, 32, 4, 680, DateTimeKind.Utc).AddTicks(9209), new DateTime(2023, 12, 20, 6, 48, 6, 531, DateTimeKind.Local).AddTicks(1856) });

            migrationBuilder.UpdateData(
                table: "Book",
                keyColumn: "BookId",
                keyValue: 1803,
                columns: new[] { "CreatedDateTime", "PublicationDate" },
                values: new object[] { new DateTime(2024, 8, 16, 16, 32, 4, 680, DateTimeKind.Utc).AddTicks(9331), new DateTime(2024, 6, 7, 6, 15, 5, 150, DateTimeKind.Local).AddTicks(9138) });

            migrationBuilder.UpdateData(
                table: "Book",
                keyColumn: "BookId",
                keyValue: 1804,
                columns: new[] { "CreatedDateTime", "PublicationDate" },
                values: new object[] { new DateTime(2024, 8, 16, 16, 32, 4, 680, DateTimeKind.Utc).AddTicks(9431), new DateTime(2023, 8, 24, 14, 23, 58, 498, DateTimeKind.Local).AddTicks(6538) });

            migrationBuilder.UpdateData(
                table: "Book",
                keyColumn: "BookId",
                keyValue: 1805,
                columns: new[] { "CreatedDateTime", "PublicationDate" },
                values: new object[] { new DateTime(2024, 8, 16, 16, 32, 4, 680, DateTimeKind.Utc).AddTicks(9553), new DateTime(2024, 6, 28, 22, 40, 22, 690, DateTimeKind.Local).AddTicks(1751) });

            migrationBuilder.UpdateData(
                table: "Book",
                keyColumn: "BookId",
                keyValue: 1806,
                columns: new[] { "CreatedDateTime", "PublicationDate" },
                values: new object[] { new DateTime(2024, 8, 16, 16, 32, 4, 680, DateTimeKind.Utc).AddTicks(9661), new DateTime(2024, 4, 18, 6, 10, 29, 167, DateTimeKind.Local).AddTicks(7351) });

            migrationBuilder.UpdateData(
                table: "Book",
                keyColumn: "BookId",
                keyValue: 1807,
                columns: new[] { "CreatedDateTime", "PublicationDate" },
                values: new object[] { new DateTime(2024, 8, 16, 16, 32, 4, 680, DateTimeKind.Utc).AddTicks(9786), new DateTime(2024, 5, 14, 21, 53, 37, 966, DateTimeKind.Local).AddTicks(3620) });

            migrationBuilder.UpdateData(
                table: "Book",
                keyColumn: "BookId",
                keyValue: 1808,
                columns: new[] { "CreatedDateTime", "PublicationDate" },
                values: new object[] { new DateTime(2024, 8, 16, 16, 32, 4, 680, DateTimeKind.Utc).AddTicks(9878), new DateTime(2023, 10, 2, 3, 30, 32, 745, DateTimeKind.Local).AddTicks(9746) });

            migrationBuilder.UpdateData(
                table: "Book",
                keyColumn: "BookId",
                keyValue: 1809,
                columns: new[] { "CreatedDateTime", "PublicationDate" },
                values: new object[] { new DateTime(2024, 8, 16, 16, 32, 4, 680, DateTimeKind.Utc).AddTicks(9995), new DateTime(2024, 2, 27, 4, 39, 40, 201, DateTimeKind.Local).AddTicks(4215) });

            migrationBuilder.UpdateData(
                table: "Book",
                keyColumn: "BookId",
                keyValue: 1810,
                columns: new[] { "CreatedDateTime", "PublicationDate" },
                values: new object[] { new DateTime(2024, 8, 16, 16, 32, 4, 681, DateTimeKind.Utc).AddTicks(83), new DateTime(2024, 4, 4, 10, 34, 24, 199, DateTimeKind.Local).AddTicks(1743) });

            migrationBuilder.UpdateData(
                table: "Book",
                keyColumn: "BookId",
                keyValue: 1811,
                columns: new[] { "CreatedDateTime", "PublicationDate" },
                values: new object[] { new DateTime(2024, 8, 16, 16, 32, 4, 681, DateTimeKind.Utc).AddTicks(205), new DateTime(2023, 11, 26, 21, 24, 59, 357, DateTimeKind.Local).AddTicks(8220) });

            migrationBuilder.UpdateData(
                table: "Book",
                keyColumn: "BookId",
                keyValue: 1812,
                columns: new[] { "CreatedDateTime", "PublicationDate" },
                values: new object[] { new DateTime(2024, 8, 16, 16, 32, 4, 681, DateTimeKind.Utc).AddTicks(305), new DateTime(2024, 3, 20, 14, 2, 48, 857, DateTimeKind.Local).AddTicks(1457) });

            migrationBuilder.UpdateData(
                table: "Book",
                keyColumn: "BookId",
                keyValue: 1813,
                columns: new[] { "CreatedDateTime", "PublicationDate" },
                values: new object[] { new DateTime(2024, 8, 16, 16, 32, 4, 681, DateTimeKind.Utc).AddTicks(426), new DateTime(2023, 12, 29, 17, 3, 12, 797, DateTimeKind.Local).AddTicks(4055) });

            migrationBuilder.UpdateData(
                table: "Book",
                keyColumn: "BookId",
                keyValue: 1814,
                columns: new[] { "CreatedDateTime", "PublicationDate" },
                values: new object[] { new DateTime(2024, 8, 16, 16, 32, 4, 681, DateTimeKind.Utc).AddTicks(551), new DateTime(2024, 2, 14, 20, 41, 0, 686, DateTimeKind.Local).AddTicks(9936) });

            migrationBuilder.UpdateData(
                table: "Book",
                keyColumn: "BookId",
                keyValue: 1815,
                columns: new[] { "CreatedDateTime", "PublicationDate" },
                values: new object[] { new DateTime(2024, 8, 16, 16, 32, 4, 681, DateTimeKind.Utc).AddTicks(653), new DateTime(2023, 8, 23, 8, 23, 23, 394, DateTimeKind.Local).AddTicks(6718) });

            migrationBuilder.UpdateData(
                table: "Book",
                keyColumn: "BookId",
                keyValue: 1816,
                columns: new[] { "CreatedDateTime", "PublicationDate" },
                values: new object[] { new DateTime(2024, 8, 16, 16, 32, 4, 681, DateTimeKind.Utc).AddTicks(779), new DateTime(2023, 8, 16, 19, 15, 27, 833, DateTimeKind.Local).AddTicks(996) });

            migrationBuilder.UpdateData(
                table: "Book",
                keyColumn: "BookId",
                keyValue: 1817,
                columns: new[] { "CreatedDateTime", "PublicationDate" },
                values: new object[] { new DateTime(2024, 8, 16, 16, 32, 4, 681, DateTimeKind.Utc).AddTicks(867), new DateTime(2024, 7, 12, 10, 22, 49, 381, DateTimeKind.Local).AddTicks(8980) });

            migrationBuilder.UpdateData(
                table: "Book",
                keyColumn: "BookId",
                keyValue: 1818,
                columns: new[] { "CreatedDateTime", "PublicationDate" },
                values: new object[] { new DateTime(2024, 8, 16, 16, 32, 4, 681, DateTimeKind.Utc).AddTicks(983), new DateTime(2024, 6, 12, 22, 10, 21, 378, DateTimeKind.Local).AddTicks(3396) });

            migrationBuilder.UpdateData(
                table: "Book",
                keyColumn: "BookId",
                keyValue: 1819,
                columns: new[] { "CreatedDateTime", "PublicationDate" },
                values: new object[] { new DateTime(2024, 8, 16, 16, 32, 4, 681, DateTimeKind.Utc).AddTicks(1070), new DateTime(2024, 4, 24, 15, 51, 33, 899, DateTimeKind.Local).AddTicks(4838) });

            migrationBuilder.UpdateData(
                table: "Book",
                keyColumn: "BookId",
                keyValue: 1820,
                columns: new[] { "CreatedDateTime", "PublicationDate" },
                values: new object[] { new DateTime(2024, 8, 16, 16, 32, 4, 681, DateTimeKind.Utc).AddTicks(1194), new DateTime(2023, 9, 22, 4, 41, 47, 517, DateTimeKind.Local).AddTicks(2862) });

            migrationBuilder.UpdateData(
                table: "Book",
                keyColumn: "BookId",
                keyValue: 1821,
                columns: new[] { "CreatedDateTime", "PublicationDate" },
                values: new object[] { new DateTime(2024, 8, 16, 16, 32, 4, 681, DateTimeKind.Utc).AddTicks(1283), new DateTime(2023, 9, 12, 21, 20, 19, 817, DateTimeKind.Local).AddTicks(9887) });

            migrationBuilder.UpdateData(
                table: "Book",
                keyColumn: "BookId",
                keyValue: 1822,
                columns: new[] { "CreatedDateTime", "PublicationDate" },
                values: new object[] { new DateTime(2024, 8, 16, 16, 32, 4, 681, DateTimeKind.Utc).AddTicks(1417), new DateTime(2024, 5, 3, 16, 53, 3, 213, DateTimeKind.Local).AddTicks(6032) });

            migrationBuilder.UpdateData(
                table: "Book",
                keyColumn: "BookId",
                keyValue: 1823,
                columns: new[] { "CreatedDateTime", "PublicationDate" },
                values: new object[] { new DateTime(2024, 8, 16, 16, 32, 4, 681, DateTimeKind.Utc).AddTicks(1501), new DateTime(2024, 5, 28, 20, 31, 52, 220, DateTimeKind.Local).AddTicks(4621) });

            migrationBuilder.UpdateData(
                table: "Book",
                keyColumn: "BookId",
                keyValue: 1824,
                columns: new[] { "CreatedDateTime", "PublicationDate" },
                values: new object[] { new DateTime(2024, 8, 16, 16, 32, 4, 681, DateTimeKind.Utc).AddTicks(1630), new DateTime(2024, 4, 13, 13, 59, 8, 436, DateTimeKind.Local).AddTicks(7446) });

            migrationBuilder.UpdateData(
                table: "Book",
                keyColumn: "BookId",
                keyValue: 1825,
                columns: new[] { "CreatedDateTime", "PublicationDate" },
                values: new object[] { new DateTime(2024, 8, 16, 16, 32, 4, 681, DateTimeKind.Utc).AddTicks(1717), new DateTime(2023, 11, 17, 19, 7, 48, 605, DateTimeKind.Local).AddTicks(6326) });

            migrationBuilder.UpdateData(
                table: "Book",
                keyColumn: "BookId",
                keyValue: 1826,
                columns: new[] { "CreatedDateTime", "PublicationDate" },
                values: new object[] { new DateTime(2024, 8, 16, 16, 32, 4, 681, DateTimeKind.Utc).AddTicks(1835), new DateTime(2023, 9, 28, 9, 26, 54, 254, DateTimeKind.Local).AddTicks(9868) });

            migrationBuilder.UpdateData(
                table: "Book",
                keyColumn: "BookId",
                keyValue: 1827,
                columns: new[] { "CreatedDateTime", "PublicationDate" },
                values: new object[] { new DateTime(2024, 8, 16, 16, 32, 4, 681, DateTimeKind.Utc).AddTicks(1923), new DateTime(2024, 3, 3, 21, 5, 12, 429, DateTimeKind.Local).AddTicks(8931) });

            migrationBuilder.UpdateData(
                table: "Book",
                keyColumn: "BookId",
                keyValue: 1828,
                columns: new[] { "CreatedDateTime", "PublicationDate" },
                values: new object[] { new DateTime(2024, 8, 16, 16, 32, 4, 681, DateTimeKind.Utc).AddTicks(2047), new DateTime(2024, 7, 2, 16, 57, 11, 607, DateTimeKind.Local).AddTicks(7330) });

            migrationBuilder.UpdateData(
                table: "Book",
                keyColumn: "BookId",
                keyValue: 1829,
                columns: new[] { "CreatedDateTime", "PublicationDate" },
                values: new object[] { new DateTime(2024, 8, 16, 16, 32, 4, 681, DateTimeKind.Utc).AddTicks(2140), new DateTime(2023, 10, 13, 15, 13, 45, 252, DateTimeKind.Local).AddTicks(9529) });

            migrationBuilder.UpdateData(
                table: "Book",
                keyColumn: "BookId",
                keyValue: 1830,
                columns: new[] { "CreatedDateTime", "PublicationDate" },
                values: new object[] { new DateTime(2024, 8, 16, 16, 32, 4, 681, DateTimeKind.Utc).AddTicks(2261), new DateTime(2024, 3, 19, 12, 15, 19, 541, DateTimeKind.Local).AddTicks(7242) });

            migrationBuilder.UpdateData(
                table: "Book",
                keyColumn: "BookId",
                keyValue: 1831,
                columns: new[] { "CreatedDateTime", "PublicationDate" },
                values: new object[] { new DateTime(2024, 8, 16, 16, 32, 4, 681, DateTimeKind.Utc).AddTicks(2360), new DateTime(2024, 8, 13, 2, 44, 47, 16, DateTimeKind.Local).AddTicks(3572) });

            migrationBuilder.UpdateData(
                table: "Book",
                keyColumn: "BookId",
                keyValue: 1832,
                columns: new[] { "CreatedDateTime", "PublicationDate" },
                values: new object[] { new DateTime(2024, 8, 16, 16, 32, 4, 681, DateTimeKind.Utc).AddTicks(2499), new DateTime(2024, 5, 11, 1, 16, 53, 904, DateTimeKind.Local).AddTicks(5134) });

            migrationBuilder.UpdateData(
                table: "Book",
                keyColumn: "BookId",
                keyValue: 1833,
                columns: new[] { "CreatedDateTime", "PublicationDate" },
                values: new object[] { new DateTime(2024, 8, 16, 16, 32, 4, 681, DateTimeKind.Utc).AddTicks(2617), new DateTime(2023, 10, 22, 5, 26, 14, 940, DateTimeKind.Local).AddTicks(5001) });

            migrationBuilder.UpdateData(
                table: "Book",
                keyColumn: "BookId",
                keyValue: 1834,
                columns: new[] { "CreatedDateTime", "PublicationDate" },
                values: new object[] { new DateTime(2024, 8, 16, 16, 32, 4, 681, DateTimeKind.Utc).AddTicks(2714), new DateTime(2023, 12, 16, 23, 21, 32, 737, DateTimeKind.Local).AddTicks(5685) });

            migrationBuilder.UpdateData(
                table: "Book",
                keyColumn: "BookId",
                keyValue: 1835,
                columns: new[] { "CreatedDateTime", "PublicationDate" },
                values: new object[] { new DateTime(2024, 8, 16, 16, 32, 4, 681, DateTimeKind.Utc).AddTicks(2853), new DateTime(2024, 1, 7, 14, 59, 59, 64, DateTimeKind.Local).AddTicks(5430) });

            migrationBuilder.UpdateData(
                table: "Book",
                keyColumn: "BookId",
                keyValue: 1836,
                columns: new[] { "CreatedDateTime", "PublicationDate" },
                values: new object[] { new DateTime(2024, 8, 16, 16, 32, 4, 681, DateTimeKind.Utc).AddTicks(2944), new DateTime(2024, 4, 6, 22, 41, 1, 530, DateTimeKind.Local).AddTicks(8206) });

            migrationBuilder.UpdateData(
                table: "Book",
                keyColumn: "BookId",
                keyValue: 1837,
                columns: new[] { "CreatedDateTime", "PublicationDate" },
                values: new object[] { new DateTime(2024, 8, 16, 16, 32, 4, 681, DateTimeKind.Utc).AddTicks(3072), new DateTime(2024, 7, 18, 8, 40, 14, 446, DateTimeKind.Local).AddTicks(2780) });

            migrationBuilder.UpdateData(
                table: "Book",
                keyColumn: "BookId",
                keyValue: 1838,
                columns: new[] { "CreatedDateTime", "PublicationDate" },
                values: new object[] { new DateTime(2024, 8, 16, 16, 32, 4, 681, DateTimeKind.Utc).AddTicks(3182), new DateTime(2023, 12, 1, 18, 48, 45, 710, DateTimeKind.Local).AddTicks(9925) });

            migrationBuilder.UpdateData(
                table: "Book",
                keyColumn: "BookId",
                keyValue: 1839,
                columns: new[] { "CreatedDateTime", "PublicationDate" },
                values: new object[] { new DateTime(2024, 8, 16, 16, 32, 4, 681, DateTimeKind.Utc).AddTicks(3307), new DateTime(2024, 4, 29, 14, 1, 23, 990, DateTimeKind.Local).AddTicks(3923) });

            migrationBuilder.UpdateData(
                table: "Book",
                keyColumn: "BookId",
                keyValue: 1840,
                columns: new[] { "CreatedDateTime", "PublicationDate" },
                values: new object[] { new DateTime(2024, 8, 16, 16, 32, 4, 681, DateTimeKind.Utc).AddTicks(3404), new DateTime(2024, 1, 9, 16, 55, 18, 447, DateTimeKind.Local).AddTicks(1489) });

            migrationBuilder.UpdateData(
                table: "Book",
                keyColumn: "BookId",
                keyValue: 1841,
                columns: new[] { "CreatedDateTime", "PublicationDate" },
                values: new object[] { new DateTime(2024, 8, 16, 16, 32, 4, 681, DateTimeKind.Utc).AddTicks(3517), new DateTime(2024, 8, 10, 5, 29, 33, 468, DateTimeKind.Local).AddTicks(4614) });

            migrationBuilder.UpdateData(
                table: "Book",
                keyColumn: "BookId",
                keyValue: 1842,
                columns: new[] { "CreatedDateTime", "PublicationDate" },
                values: new object[] { new DateTime(2024, 8, 16, 16, 32, 4, 681, DateTimeKind.Utc).AddTicks(3614), new DateTime(2024, 1, 27, 14, 11, 45, 564, DateTimeKind.Local).AddTicks(7244) });

            migrationBuilder.UpdateData(
                table: "Book",
                keyColumn: "BookId",
                keyValue: 1843,
                columns: new[] { "CreatedDateTime", "PublicationDate" },
                values: new object[] { new DateTime(2024, 8, 16, 16, 32, 4, 681, DateTimeKind.Utc).AddTicks(3731), new DateTime(2023, 10, 7, 3, 4, 48, 703, DateTimeKind.Local).AddTicks(1132) });

            migrationBuilder.UpdateData(
                table: "Book",
                keyColumn: "BookId",
                keyValue: 1844,
                columns: new[] { "CreatedDateTime", "PublicationDate" },
                values: new object[] { new DateTime(2024, 8, 16, 16, 32, 4, 681, DateTimeKind.Utc).AddTicks(3830), new DateTime(2024, 1, 17, 13, 3, 42, 181, DateTimeKind.Local).AddTicks(1390) });

            migrationBuilder.UpdateData(
                table: "Book",
                keyColumn: "BookId",
                keyValue: 1845,
                columns: new[] { "CreatedDateTime", "PublicationDate" },
                values: new object[] { new DateTime(2024, 8, 16, 16, 32, 4, 681, DateTimeKind.Utc).AddTicks(3946), new DateTime(2023, 12, 5, 0, 33, 1, 355, DateTimeKind.Local).AddTicks(3451) });

            migrationBuilder.UpdateData(
                table: "Book",
                keyColumn: "BookId",
                keyValue: 1846,
                columns: new[] { "CreatedDateTime", "PublicationDate" },
                values: new object[] { new DateTime(2024, 8, 16, 16, 32, 4, 681, DateTimeKind.Utc).AddTicks(4041), new DateTime(2024, 7, 12, 11, 32, 37, 221, DateTimeKind.Local).AddTicks(1800) });

            migrationBuilder.UpdateData(
                table: "Book",
                keyColumn: "BookId",
                keyValue: 1847,
                columns: new[] { "CreatedDateTime", "PublicationDate" },
                values: new object[] { new DateTime(2024, 8, 16, 16, 32, 4, 681, DateTimeKind.Utc).AddTicks(4154), new DateTime(2024, 5, 30, 15, 50, 21, 411, DateTimeKind.Local).AddTicks(3475) });

            migrationBuilder.UpdateData(
                table: "Book",
                keyColumn: "BookId",
                keyValue: 1848,
                columns: new[] { "CreatedDateTime", "PublicationDate" },
                values: new object[] { new DateTime(2024, 8, 16, 16, 32, 4, 681, DateTimeKind.Utc).AddTicks(4250), new DateTime(2024, 2, 12, 9, 34, 37, 834, DateTimeKind.Local).AddTicks(8919) });

            migrationBuilder.UpdateData(
                table: "Book",
                keyColumn: "BookId",
                keyValue: 1849,
                columns: new[] { "CreatedDateTime", "PublicationDate" },
                values: new object[] { new DateTime(2024, 8, 16, 16, 32, 4, 681, DateTimeKind.Utc).AddTicks(4353), new DateTime(2023, 10, 17, 1, 33, 58, 571, DateTimeKind.Local).AddTicks(755) });

            migrationBuilder.UpdateData(
                table: "Book",
                keyColumn: "BookId",
                keyValue: 1850,
                columns: new[] { "CreatedDateTime", "PublicationDate" },
                values: new object[] { new DateTime(2024, 8, 16, 16, 32, 4, 681, DateTimeKind.Utc).AddTicks(4440), new DateTime(2023, 12, 12, 2, 19, 24, 849, DateTimeKind.Local).AddTicks(5224) });

            migrationBuilder.UpdateData(
                table: "Book",
                keyColumn: "BookId",
                keyValue: 1851,
                columns: new[] { "CreatedDateTime", "PublicationDate" },
                values: new object[] { new DateTime(2024, 8, 16, 16, 32, 4, 681, DateTimeKind.Utc).AddTicks(4562), new DateTime(2023, 11, 28, 18, 10, 53, 519, DateTimeKind.Local).AddTicks(1057) });

            migrationBuilder.UpdateData(
                table: "Book",
                keyColumn: "BookId",
                keyValue: 1852,
                columns: new[] { "CreatedDateTime", "PublicationDate" },
                values: new object[] { new DateTime(2024, 8, 16, 16, 32, 4, 681, DateTimeKind.Utc).AddTicks(4655), new DateTime(2024, 5, 22, 23, 24, 6, 248, DateTimeKind.Local).AddTicks(7381) });

            migrationBuilder.UpdateData(
                table: "Book",
                keyColumn: "BookId",
                keyValue: 1853,
                columns: new[] { "CreatedDateTime", "PublicationDate" },
                values: new object[] { new DateTime(2024, 8, 16, 16, 32, 4, 681, DateTimeKind.Utc).AddTicks(4789), new DateTime(2023, 10, 1, 2, 36, 52, 474, DateTimeKind.Local).AddTicks(2883) });

            migrationBuilder.UpdateData(
                table: "Book",
                keyColumn: "BookId",
                keyValue: 1854,
                columns: new[] { "CreatedDateTime", "PublicationDate" },
                values: new object[] { new DateTime(2024, 8, 16, 16, 32, 4, 681, DateTimeKind.Utc).AddTicks(4877), new DateTime(2023, 10, 27, 10, 43, 13, 742, DateTimeKind.Local).AddTicks(3868) });

            migrationBuilder.UpdateData(
                table: "Book",
                keyColumn: "BookId",
                keyValue: 1855,
                columns: new[] { "CreatedDateTime", "PublicationDate" },
                values: new object[] { new DateTime(2024, 8, 16, 16, 32, 4, 681, DateTimeKind.Utc).AddTicks(5006), new DateTime(2024, 7, 1, 3, 19, 0, 41, DateTimeKind.Local).AddTicks(1296) });

            migrationBuilder.UpdateData(
                table: "Book",
                keyColumn: "BookId",
                keyValue: 1856,
                columns: new[] { "CreatedDateTime", "PublicationDate" },
                values: new object[] { new DateTime(2024, 8, 16, 16, 32, 4, 681, DateTimeKind.Utc).AddTicks(5103), new DateTime(2023, 10, 30, 6, 5, 59, 791, DateTimeKind.Local).AddTicks(9493) });

            migrationBuilder.UpdateData(
                table: "Book",
                keyColumn: "BookId",
                keyValue: 1857,
                columns: new[] { "CreatedDateTime", "PublicationDate" },
                values: new object[] { new DateTime(2024, 8, 16, 16, 32, 4, 681, DateTimeKind.Utc).AddTicks(5234), new DateTime(2024, 5, 22, 1, 40, 41, 624, DateTimeKind.Local).AddTicks(7824) });

            migrationBuilder.UpdateData(
                table: "Book",
                keyColumn: "BookId",
                keyValue: 1858,
                columns: new[] { "CreatedDateTime", "PublicationDate" },
                values: new object[] { new DateTime(2024, 8, 16, 16, 32, 4, 681, DateTimeKind.Utc).AddTicks(5357), new DateTime(2023, 11, 18, 2, 53, 6, 74, DateTimeKind.Local).AddTicks(6169) });

            migrationBuilder.UpdateData(
                table: "Book",
                keyColumn: "BookId",
                keyValue: 1859,
                columns: new[] { "CreatedDateTime", "PublicationDate" },
                values: new object[] { new DateTime(2024, 8, 16, 16, 32, 4, 681, DateTimeKind.Utc).AddTicks(5443), new DateTime(2024, 5, 12, 5, 6, 38, 922, DateTimeKind.Local).AddTicks(980) });

            migrationBuilder.UpdateData(
                table: "Book",
                keyColumn: "BookId",
                keyValue: 1860,
                columns: new[] { "CreatedDateTime", "PublicationDate" },
                values: new object[] { new DateTime(2024, 8, 16, 16, 32, 4, 681, DateTimeKind.Utc).AddTicks(5567), new DateTime(2024, 3, 5, 4, 11, 15, 736, DateTimeKind.Local).AddTicks(3492) });

            migrationBuilder.UpdateData(
                table: "Book",
                keyColumn: "BookId",
                keyValue: 1861,
                columns: new[] { "CreatedDateTime", "PublicationDate" },
                values: new object[] { new DateTime(2024, 8, 16, 16, 32, 4, 681, DateTimeKind.Utc).AddTicks(5659), new DateTime(2023, 10, 10, 4, 28, 52, 437, DateTimeKind.Local).AddTicks(5710) });

            migrationBuilder.UpdateData(
                table: "Book",
                keyColumn: "BookId",
                keyValue: 1862,
                columns: new[] { "CreatedDateTime", "PublicationDate" },
                values: new object[] { new DateTime(2024, 8, 16, 16, 32, 4, 681, DateTimeKind.Utc).AddTicks(5787), new DateTime(2023, 9, 25, 17, 28, 55, 195, DateTimeKind.Local).AddTicks(8113) });

            migrationBuilder.UpdateData(
                table: "Book",
                keyColumn: "BookId",
                keyValue: 1863,
                columns: new[] { "CreatedDateTime", "PublicationDate" },
                values: new object[] { new DateTime(2024, 8, 16, 16, 32, 4, 681, DateTimeKind.Utc).AddTicks(5878), new DateTime(2024, 7, 29, 14, 28, 34, 762, DateTimeKind.Local).AddTicks(9349) });

            migrationBuilder.UpdateData(
                table: "Book",
                keyColumn: "BookId",
                keyValue: 1864,
                columns: new[] { "CreatedDateTime", "PublicationDate" },
                values: new object[] { new DateTime(2024, 8, 16, 16, 32, 4, 681, DateTimeKind.Utc).AddTicks(5989), new DateTime(2024, 7, 1, 9, 20, 30, 522, DateTimeKind.Local).AddTicks(2590) });

            migrationBuilder.UpdateData(
                table: "Book",
                keyColumn: "BookId",
                keyValue: 1865,
                columns: new[] { "CreatedDateTime", "PublicationDate" },
                values: new object[] { new DateTime(2024, 8, 16, 16, 32, 4, 681, DateTimeKind.Utc).AddTicks(6076), new DateTime(2024, 6, 19, 15, 31, 13, 908, DateTimeKind.Local).AddTicks(4480) });

            migrationBuilder.UpdateData(
                table: "Book",
                keyColumn: "BookId",
                keyValue: 1866,
                columns: new[] { "CreatedDateTime", "PublicationDate" },
                values: new object[] { new DateTime(2024, 8, 16, 16, 32, 4, 681, DateTimeKind.Utc).AddTicks(6190), new DateTime(2024, 6, 25, 7, 32, 26, 179, DateTimeKind.Local).AddTicks(4152) });

            migrationBuilder.UpdateData(
                table: "Book",
                keyColumn: "BookId",
                keyValue: 1867,
                columns: new[] { "CreatedDateTime", "PublicationDate" },
                values: new object[] { new DateTime(2024, 8, 16, 16, 32, 4, 681, DateTimeKind.Utc).AddTicks(6280), new DateTime(2024, 3, 27, 7, 55, 17, 670, DateTimeKind.Local).AddTicks(8387) });

            migrationBuilder.UpdateData(
                table: "Book",
                keyColumn: "BookId",
                keyValue: 1868,
                columns: new[] { "CreatedDateTime", "PublicationDate" },
                values: new object[] { new DateTime(2024, 8, 16, 16, 32, 4, 681, DateTimeKind.Utc).AddTicks(6365), new DateTime(2023, 8, 20, 1, 21, 40, 393, DateTimeKind.Local).AddTicks(4297) });

            migrationBuilder.UpdateData(
                table: "Book",
                keyColumn: "BookId",
                keyValue: 1869,
                columns: new[] { "CreatedDateTime", "PublicationDate" },
                values: new object[] { new DateTime(2024, 8, 16, 16, 32, 4, 681, DateTimeKind.Utc).AddTicks(6493), new DateTime(2023, 11, 5, 11, 9, 54, 327, DateTimeKind.Local).AddTicks(8297) });

            migrationBuilder.UpdateData(
                table: "Book",
                keyColumn: "BookId",
                keyValue: 1870,
                columns: new[] { "CreatedDateTime", "PublicationDate" },
                values: new object[] { new DateTime(2024, 8, 16, 16, 32, 4, 681, DateTimeKind.Utc).AddTicks(6620), new DateTime(2024, 3, 9, 12, 40, 23, 816, DateTimeKind.Local).AddTicks(6005) });

            migrationBuilder.UpdateData(
                table: "Book",
                keyColumn: "BookId",
                keyValue: 1871,
                columns: new[] { "CreatedDateTime", "PublicationDate" },
                values: new object[] { new DateTime(2024, 8, 16, 16, 32, 4, 681, DateTimeKind.Utc).AddTicks(6718), new DateTime(2024, 7, 20, 15, 0, 2, 843, DateTimeKind.Local).AddTicks(4274) });

            migrationBuilder.UpdateData(
                table: "Book",
                keyColumn: "BookId",
                keyValue: 1872,
                columns: new[] { "CreatedDateTime", "PublicationDate" },
                values: new object[] { new DateTime(2024, 8, 16, 16, 32, 4, 681, DateTimeKind.Utc).AddTicks(6839), new DateTime(2024, 4, 4, 10, 3, 3, 98, DateTimeKind.Local).AddTicks(1598) });

            migrationBuilder.UpdateData(
                table: "Book",
                keyColumn: "BookId",
                keyValue: 1873,
                columns: new[] { "CreatedDateTime", "PublicationDate" },
                values: new object[] { new DateTime(2024, 8, 16, 16, 32, 4, 681, DateTimeKind.Utc).AddTicks(6925), new DateTime(2023, 11, 21, 23, 29, 52, 772, DateTimeKind.Local).AddTicks(7299) });

            migrationBuilder.UpdateData(
                table: "Book",
                keyColumn: "BookId",
                keyValue: 1874,
                columns: new[] { "CreatedDateTime", "PublicationDate" },
                values: new object[] { new DateTime(2024, 8, 16, 16, 32, 4, 681, DateTimeKind.Utc).AddTicks(7039), new DateTime(2024, 7, 9, 18, 58, 42, 403, DateTimeKind.Local).AddTicks(4123) });

            migrationBuilder.UpdateData(
                table: "Book",
                keyColumn: "BookId",
                keyValue: 1875,
                columns: new[] { "CreatedDateTime", "PublicationDate" },
                values: new object[] { new DateTime(2024, 8, 16, 16, 32, 4, 681, DateTimeKind.Utc).AddTicks(7141), new DateTime(2024, 8, 15, 15, 51, 34, 659, DateTimeKind.Local).AddTicks(8103) });

            migrationBuilder.UpdateData(
                table: "Book",
                keyColumn: "BookId",
                keyValue: 1876,
                columns: new[] { "CreatedDateTime", "PublicationDate" },
                values: new object[] { new DateTime(2024, 8, 16, 16, 32, 4, 681, DateTimeKind.Utc).AddTicks(7262), new DateTime(2024, 5, 14, 6, 36, 13, 235, DateTimeKind.Local).AddTicks(1130) });

            migrationBuilder.UpdateData(
                table: "Book",
                keyColumn: "BookId",
                keyValue: 1877,
                columns: new[] { "CreatedDateTime", "PublicationDate" },
                values: new object[] { new DateTime(2024, 8, 16, 16, 32, 4, 681, DateTimeKind.Utc).AddTicks(7361), new DateTime(2023, 8, 17, 3, 36, 18, 207, DateTimeKind.Local).AddTicks(1711) });

            migrationBuilder.UpdateData(
                table: "Book",
                keyColumn: "BookId",
                keyValue: 1878,
                columns: new[] { "CreatedDateTime", "PublicationDate" },
                values: new object[] { new DateTime(2024, 8, 16, 16, 32, 4, 681, DateTimeKind.Utc).AddTicks(7482), new DateTime(2024, 4, 19, 21, 28, 55, 648, DateTimeKind.Local).AddTicks(8392) });

            migrationBuilder.UpdateData(
                table: "Book",
                keyColumn: "BookId",
                keyValue: 1879,
                columns: new[] { "CreatedDateTime", "PublicationDate" },
                values: new object[] { new DateTime(2024, 8, 16, 16, 32, 4, 681, DateTimeKind.Utc).AddTicks(7582), new DateTime(2024, 7, 15, 5, 40, 10, 606, DateTimeKind.Local).AddTicks(1105) });

            migrationBuilder.UpdateData(
                table: "Book",
                keyColumn: "BookId",
                keyValue: 1880,
                columns: new[] { "CreatedDateTime", "PublicationDate" },
                values: new object[] { new DateTime(2024, 8, 16, 16, 32, 4, 681, DateTimeKind.Utc).AddTicks(7704), new DateTime(2024, 1, 2, 21, 17, 55, 911, DateTimeKind.Local).AddTicks(7024) });

            migrationBuilder.UpdateData(
                table: "Book",
                keyColumn: "BookId",
                keyValue: 1881,
                columns: new[] { "CreatedDateTime", "PublicationDate" },
                values: new object[] { new DateTime(2024, 8, 16, 16, 32, 4, 681, DateTimeKind.Utc).AddTicks(7796), new DateTime(2024, 2, 22, 1, 51, 46, 462, DateTimeKind.Local).AddTicks(7156) });

            migrationBuilder.UpdateData(
                table: "Book",
                keyColumn: "BookId",
                keyValue: 1882,
                columns: new[] { "CreatedDateTime", "PublicationDate" },
                values: new object[] { new DateTime(2024, 8, 16, 16, 32, 4, 681, DateTimeKind.Utc).AddTicks(7927), new DateTime(2024, 1, 29, 13, 51, 58, 757, DateTimeKind.Local).AddTicks(9908) });

            migrationBuilder.UpdateData(
                table: "Book",
                keyColumn: "BookId",
                keyValue: 1883,
                columns: new[] { "CreatedDateTime", "PublicationDate" },
                values: new object[] { new DateTime(2024, 8, 16, 16, 32, 4, 681, DateTimeKind.Utc).AddTicks(8016), new DateTime(2024, 3, 25, 22, 29, 49, 510, DateTimeKind.Local).AddTicks(1085) });

            migrationBuilder.UpdateData(
                table: "Book",
                keyColumn: "BookId",
                keyValue: 1884,
                columns: new[] { "CreatedDateTime", "PublicationDate" },
                values: new object[] { new DateTime(2024, 8, 16, 16, 32, 4, 681, DateTimeKind.Utc).AddTicks(8147), new DateTime(2023, 8, 16, 15, 44, 12, 183, DateTimeKind.Local).AddTicks(5743) });

            migrationBuilder.UpdateData(
                table: "Book",
                keyColumn: "BookId",
                keyValue: 1885,
                columns: new[] { "CreatedDateTime", "PublicationDate" },
                values: new object[] { new DateTime(2024, 8, 16, 16, 32, 4, 681, DateTimeKind.Utc).AddTicks(8241), new DateTime(2023, 11, 19, 23, 23, 51, 977, DateTimeKind.Local).AddTicks(5578) });

            migrationBuilder.UpdateData(
                table: "Book",
                keyColumn: "BookId",
                keyValue: 1886,
                columns: new[] { "CreatedDateTime", "PublicationDate" },
                values: new object[] { new DateTime(2024, 8, 16, 16, 32, 4, 681, DateTimeKind.Utc).AddTicks(8368), new DateTime(2023, 11, 1, 19, 31, 38, 134, DateTimeKind.Local).AddTicks(2482) });

            migrationBuilder.UpdateData(
                table: "Book",
                keyColumn: "BookId",
                keyValue: 1887,
                columns: new[] { "CreatedDateTime", "PublicationDate" },
                values: new object[] { new DateTime(2024, 8, 16, 16, 32, 4, 681, DateTimeKind.Utc).AddTicks(8453), new DateTime(2023, 10, 24, 12, 17, 49, 987, DateTimeKind.Local).AddTicks(9999) });

            migrationBuilder.UpdateData(
                table: "Book",
                keyColumn: "BookId",
                keyValue: 1888,
                columns: new[] { "CreatedDateTime", "PublicationDate" },
                values: new object[] { new DateTime(2024, 8, 16, 16, 32, 4, 681, DateTimeKind.Utc).AddTicks(8582), new DateTime(2023, 11, 21, 10, 40, 32, 302, DateTimeKind.Local).AddTicks(1902) });

            migrationBuilder.UpdateData(
                table: "Book",
                keyColumn: "BookId",
                keyValue: 1889,
                columns: new[] { "CreatedDateTime", "PublicationDate" },
                values: new object[] { new DateTime(2024, 8, 16, 16, 32, 4, 681, DateTimeKind.Utc).AddTicks(8684), new DateTime(2023, 10, 15, 3, 44, 54, 435, DateTimeKind.Local).AddTicks(3220) });

            migrationBuilder.UpdateData(
                table: "Book",
                keyColumn: "BookId",
                keyValue: 1890,
                columns: new[] { "CreatedDateTime", "PublicationDate" },
                values: new object[] { new DateTime(2024, 8, 16, 16, 32, 4, 681, DateTimeKind.Utc).AddTicks(8801), new DateTime(2024, 5, 3, 4, 16, 25, 839, DateTimeKind.Local).AddTicks(5569) });

            migrationBuilder.UpdateData(
                table: "Book",
                keyColumn: "BookId",
                keyValue: 1891,
                columns: new[] { "CreatedDateTime", "PublicationDate" },
                values: new object[] { new DateTime(2024, 8, 16, 16, 32, 4, 681, DateTimeKind.Utc).AddTicks(8892), new DateTime(2023, 9, 12, 6, 22, 54, 52, DateTimeKind.Local).AddTicks(3675) });

            migrationBuilder.UpdateData(
                table: "Book",
                keyColumn: "BookId",
                keyValue: 1892,
                columns: new[] { "CreatedDateTime", "PublicationDate" },
                values: new object[] { new DateTime(2024, 8, 16, 16, 32, 4, 681, DateTimeKind.Utc).AddTicks(9023), new DateTime(2023, 11, 29, 13, 23, 4, 926, DateTimeKind.Local).AddTicks(8695) });

            migrationBuilder.UpdateData(
                table: "Book",
                keyColumn: "BookId",
                keyValue: 1893,
                columns: new[] { "CreatedDateTime", "PublicationDate" },
                values: new object[] { new DateTime(2024, 8, 16, 16, 32, 4, 681, DateTimeKind.Utc).AddTicks(9125), new DateTime(2024, 7, 28, 9, 10, 7, 526, DateTimeKind.Local).AddTicks(6792) });

            migrationBuilder.UpdateData(
                table: "Book",
                keyColumn: "BookId",
                keyValue: 1894,
                columns: new[] { "CreatedDateTime", "PublicationDate" },
                values: new object[] { new DateTime(2024, 8, 16, 16, 32, 4, 681, DateTimeKind.Utc).AddTicks(9249), new DateTime(2023, 12, 24, 1, 22, 57, 98, DateTimeKind.Local).AddTicks(4278) });

            migrationBuilder.UpdateData(
                table: "Book",
                keyColumn: "BookId",
                keyValue: 1895,
                columns: new[] { "CreatedDateTime", "PublicationDate" },
                values: new object[] { new DateTime(2024, 8, 16, 16, 32, 4, 681, DateTimeKind.Utc).AddTicks(9335), new DateTime(2023, 9, 5, 6, 57, 25, 16, DateTimeKind.Local).AddTicks(7163) });

            migrationBuilder.UpdateData(
                table: "Book",
                keyColumn: "BookId",
                keyValue: 1896,
                columns: new[] { "CreatedDateTime", "PublicationDate" },
                values: new object[] { new DateTime(2024, 8, 16, 16, 32, 4, 681, DateTimeKind.Utc).AddTicks(9449), new DateTime(2023, 12, 7, 10, 57, 28, 3, DateTimeKind.Local).AddTicks(3052) });

            migrationBuilder.UpdateData(
                table: "Book",
                keyColumn: "BookId",
                keyValue: 1897,
                columns: new[] { "CreatedDateTime", "PublicationDate" },
                values: new object[] { new DateTime(2024, 8, 16, 16, 32, 4, 681, DateTimeKind.Utc).AddTicks(9575), new DateTime(2024, 8, 10, 1, 6, 25, 90, DateTimeKind.Local).AddTicks(7258) });

            migrationBuilder.UpdateData(
                table: "Book",
                keyColumn: "BookId",
                keyValue: 1898,
                columns: new[] { "CreatedDateTime", "PublicationDate" },
                values: new object[] { new DateTime(2024, 8, 16, 16, 32, 4, 681, DateTimeKind.Utc).AddTicks(9674), new DateTime(2023, 10, 9, 19, 35, 42, 194, DateTimeKind.Local).AddTicks(935) });

            migrationBuilder.UpdateData(
                table: "Book",
                keyColumn: "BookId",
                keyValue: 1899,
                columns: new[] { "CreatedDateTime", "PublicationDate" },
                values: new object[] { new DateTime(2024, 8, 16, 16, 32, 4, 681, DateTimeKind.Utc).AddTicks(9804), new DateTime(2024, 4, 25, 8, 13, 23, 795, DateTimeKind.Local).AddTicks(2144) });

            migrationBuilder.UpdateData(
                table: "Book",
                keyColumn: "BookId",
                keyValue: 1900,
                columns: new[] { "CreatedDateTime", "PublicationDate" },
                values: new object[] { new DateTime(2024, 8, 16, 16, 32, 4, 681, DateTimeKind.Utc).AddTicks(9895), new DateTime(2023, 11, 9, 3, 47, 9, 916, DateTimeKind.Local).AddTicks(3834) });

            migrationBuilder.UpdateData(
                table: "Book",
                keyColumn: "BookId",
                keyValue: 1901,
                columns: new[] { "CreatedDateTime", "PublicationDate" },
                values: new object[] { new DateTime(2024, 8, 16, 16, 32, 4, 682, DateTimeKind.Utc).AddTicks(27), new DateTime(2024, 2, 17, 22, 53, 39, 35, DateTimeKind.Local).AddTicks(7242) });

            migrationBuilder.UpdateData(
                table: "Book",
                keyColumn: "BookId",
                keyValue: 1902,
                columns: new[] { "CreatedDateTime", "PublicationDate" },
                values: new object[] { new DateTime(2024, 8, 16, 16, 32, 4, 682, DateTimeKind.Utc).AddTicks(110), new DateTime(2024, 7, 19, 6, 0, 13, 803, DateTimeKind.Local).AddTicks(5399) });

            migrationBuilder.UpdateData(
                table: "Book",
                keyColumn: "BookId",
                keyValue: 1903,
                columns: new[] { "CreatedDateTime", "PublicationDate" },
                values: new object[] { new DateTime(2024, 8, 16, 16, 32, 4, 682, DateTimeKind.Utc).AddTicks(241), new DateTime(2024, 7, 2, 20, 41, 37, 552, DateTimeKind.Local).AddTicks(4180) });

            migrationBuilder.UpdateData(
                table: "Book",
                keyColumn: "BookId",
                keyValue: 1904,
                columns: new[] { "CreatedDateTime", "PublicationDate" },
                values: new object[] { new DateTime(2024, 8, 16, 16, 32, 4, 682, DateTimeKind.Utc).AddTicks(344), new DateTime(2024, 2, 3, 11, 30, 3, 936, DateTimeKind.Local).AddTicks(3821) });

            migrationBuilder.UpdateData(
                table: "Book",
                keyColumn: "BookId",
                keyValue: 1905,
                columns: new[] { "CreatedDateTime", "PublicationDate" },
                values: new object[] { new DateTime(2024, 8, 16, 16, 32, 4, 682, DateTimeKind.Utc).AddTicks(467), new DateTime(2024, 1, 17, 12, 59, 48, 211, DateTimeKind.Local).AddTicks(724) });

            migrationBuilder.UpdateData(
                table: "Book",
                keyColumn: "BookId",
                keyValue: 1906,
                columns: new[] { "CreatedDateTime", "PublicationDate" },
                values: new object[] { new DateTime(2024, 8, 16, 16, 32, 4, 682, DateTimeKind.Utc).AddTicks(565), new DateTime(2024, 7, 12, 23, 28, 8, 398, DateTimeKind.Local).AddTicks(7695) });

            migrationBuilder.UpdateData(
                table: "Book",
                keyColumn: "BookId",
                keyValue: 1907,
                columns: new[] { "CreatedDateTime", "PublicationDate" },
                values: new object[] { new DateTime(2024, 8, 16, 16, 32, 4, 682, DateTimeKind.Utc).AddTicks(695), new DateTime(2023, 12, 22, 1, 25, 16, 684, DateTimeKind.Local).AddTicks(6196) });

            migrationBuilder.UpdateData(
                table: "Book",
                keyColumn: "BookId",
                keyValue: 1908,
                columns: new[] { "CreatedDateTime", "PublicationDate" },
                values: new object[] { new DateTime(2024, 8, 16, 16, 32, 4, 682, DateTimeKind.Utc).AddTicks(788), new DateTime(2023, 11, 23, 19, 13, 14, 464, DateTimeKind.Local).AddTicks(368) });

            migrationBuilder.UpdateData(
                table: "Book",
                keyColumn: "BookId",
                keyValue: 1909,
                columns: new[] { "CreatedDateTime", "PublicationDate" },
                values: new object[] { new DateTime(2024, 8, 16, 16, 32, 4, 682, DateTimeKind.Utc).AddTicks(914), new DateTime(2023, 9, 8, 19, 40, 12, 940, DateTimeKind.Local).AddTicks(1596) });

            migrationBuilder.UpdateData(
                table: "Book",
                keyColumn: "BookId",
                keyValue: 1910,
                columns: new[] { "CreatedDateTime", "PublicationDate" },
                values: new object[] { new DateTime(2024, 8, 16, 16, 32, 4, 682, DateTimeKind.Utc).AddTicks(996), new DateTime(2023, 12, 18, 6, 53, 40, 890, DateTimeKind.Local).AddTicks(3158) });

            migrationBuilder.UpdateData(
                table: "Book",
                keyColumn: "BookId",
                keyValue: 1911,
                columns: new[] { "CreatedDateTime", "PublicationDate" },
                values: new object[] { new DateTime(2024, 8, 16, 16, 32, 4, 682, DateTimeKind.Utc).AddTicks(1101), new DateTime(2024, 4, 27, 16, 2, 28, 795, DateTimeKind.Local).AddTicks(611) });

            migrationBuilder.UpdateData(
                table: "Book",
                keyColumn: "BookId",
                keyValue: 1912,
                columns: new[] { "CreatedDateTime", "PublicationDate" },
                values: new object[] { new DateTime(2024, 8, 16, 16, 32, 4, 682, DateTimeKind.Utc).AddTicks(1193), new DateTime(2024, 8, 12, 4, 52, 27, 436, DateTimeKind.Local).AddTicks(8066) });

            migrationBuilder.UpdateData(
                table: "Book",
                keyColumn: "BookId",
                keyValue: 1913,
                columns: new[] { "CreatedDateTime", "PublicationDate" },
                values: new object[] { new DateTime(2024, 8, 16, 16, 32, 4, 682, DateTimeKind.Utc).AddTicks(1319), new DateTime(2023, 12, 3, 8, 52, 38, 711, DateTimeKind.Local).AddTicks(2605) });

            migrationBuilder.UpdateData(
                table: "Book",
                keyColumn: "BookId",
                keyValue: 1914,
                columns: new[] { "CreatedDateTime", "PublicationDate" },
                values: new object[] { new DateTime(2024, 8, 16, 16, 32, 4, 682, DateTimeKind.Utc).AddTicks(1414), new DateTime(2024, 1, 24, 19, 37, 44, 820, DateTimeKind.Local).AddTicks(756) });

            migrationBuilder.UpdateData(
                table: "Book",
                keyColumn: "BookId",
                keyValue: 1915,
                columns: new[] { "CreatedDateTime", "PublicationDate" },
                values: new object[] { new DateTime(2024, 8, 16, 16, 32, 4, 682, DateTimeKind.Utc).AddTicks(1539), new DateTime(2023, 10, 9, 19, 10, 40, 961, DateTimeKind.Local).AddTicks(8627) });

            migrationBuilder.UpdateData(
                table: "Book",
                keyColumn: "BookId",
                keyValue: 1916,
                columns: new[] { "CreatedDateTime", "PublicationDate" },
                values: new object[] { new DateTime(2024, 8, 16, 16, 32, 4, 682, DateTimeKind.Utc).AddTicks(1624), new DateTime(2023, 12, 15, 1, 30, 14, 837, DateTimeKind.Local).AddTicks(3929) });

            migrationBuilder.UpdateData(
                table: "Book",
                keyColumn: "BookId",
                keyValue: 1917,
                columns: new[] { "CreatedDateTime", "PublicationDate" },
                values: new object[] { new DateTime(2024, 8, 16, 16, 32, 4, 682, DateTimeKind.Utc).AddTicks(1745), new DateTime(2024, 4, 16, 6, 52, 38, 867, DateTimeKind.Local).AddTicks(689) });

            migrationBuilder.UpdateData(
                table: "Book",
                keyColumn: "BookId",
                keyValue: 1918,
                columns: new[] { "CreatedDateTime", "PublicationDate" },
                values: new object[] { new DateTime(2024, 8, 16, 16, 32, 4, 682, DateTimeKind.Utc).AddTicks(1837), new DateTime(2024, 1, 19, 1, 13, 34, 339, DateTimeKind.Local).AddTicks(789) });

            migrationBuilder.UpdateData(
                table: "Book",
                keyColumn: "BookId",
                keyValue: 1919,
                columns: new[] { "CreatedDateTime", "PublicationDate" },
                values: new object[] { new DateTime(2024, 8, 16, 16, 32, 4, 682, DateTimeKind.Utc).AddTicks(1961), new DateTime(2023, 11, 2, 14, 7, 3, 761, DateTimeKind.Local).AddTicks(4963) });

            migrationBuilder.UpdateData(
                table: "Book",
                keyColumn: "BookId",
                keyValue: 1920,
                columns: new[] { "CreatedDateTime", "PublicationDate" },
                values: new object[] { new DateTime(2024, 8, 16, 16, 32, 4, 682, DateTimeKind.Utc).AddTicks(2091), new DateTime(2023, 9, 22, 13, 31, 51, 575, DateTimeKind.Local).AddTicks(2141) });

            migrationBuilder.UpdateData(
                table: "Book",
                keyColumn: "BookId",
                keyValue: 1921,
                columns: new[] { "CreatedDateTime", "PublicationDate" },
                values: new object[] { new DateTime(2024, 8, 16, 16, 32, 4, 682, DateTimeKind.Utc).AddTicks(2183), new DateTime(2024, 6, 13, 1, 44, 32, 143, DateTimeKind.Local).AddTicks(3208) });

            migrationBuilder.UpdateData(
                table: "Book",
                keyColumn: "BookId",
                keyValue: 1922,
                columns: new[] { "CreatedDateTime", "PublicationDate" },
                values: new object[] { new DateTime(2024, 8, 16, 16, 32, 4, 682, DateTimeKind.Utc).AddTicks(2311), new DateTime(2024, 3, 22, 12, 21, 44, 301, DateTimeKind.Local).AddTicks(1724) });

            migrationBuilder.UpdateData(
                table: "Book",
                keyColumn: "BookId",
                keyValue: 1923,
                columns: new[] { "CreatedDateTime", "PublicationDate" },
                values: new object[] { new DateTime(2024, 8, 16, 16, 32, 4, 682, DateTimeKind.Utc).AddTicks(2397), new DateTime(2023, 10, 4, 1, 59, 41, 676, DateTimeKind.Local).AddTicks(6505) });

            migrationBuilder.UpdateData(
                table: "Book",
                keyColumn: "BookId",
                keyValue: 1924,
                columns: new[] { "CreatedDateTime", "PublicationDate" },
                values: new object[] { new DateTime(2024, 8, 16, 16, 32, 4, 682, DateTimeKind.Utc).AddTicks(2518), new DateTime(2024, 8, 9, 22, 6, 24, 667, DateTimeKind.Local).AddTicks(372) });

            migrationBuilder.UpdateData(
                table: "Book",
                keyColumn: "BookId",
                keyValue: 1925,
                columns: new[] { "CreatedDateTime", "PublicationDate" },
                values: new object[] { new DateTime(2024, 8, 16, 16, 32, 4, 682, DateTimeKind.Utc).AddTicks(2605), new DateTime(2024, 3, 16, 6, 0, 20, 670, DateTimeKind.Local).AddTicks(3372) });

            migrationBuilder.UpdateData(
                table: "Book",
                keyColumn: "BookId",
                keyValue: 1926,
                columns: new[] { "CreatedDateTime", "PublicationDate" },
                values: new object[] { new DateTime(2024, 8, 16, 16, 32, 4, 682, DateTimeKind.Utc).AddTicks(2722), new DateTime(2024, 6, 7, 18, 16, 8, 989, DateTimeKind.Local).AddTicks(620) });

            migrationBuilder.UpdateData(
                table: "Book",
                keyColumn: "BookId",
                keyValue: 1927,
                columns: new[] { "CreatedDateTime", "PublicationDate" },
                values: new object[] { new DateTime(2024, 8, 16, 16, 32, 4, 682, DateTimeKind.Utc).AddTicks(2819), new DateTime(2024, 1, 16, 9, 41, 13, 163, DateTimeKind.Local).AddTicks(3606) });

            migrationBuilder.UpdateData(
                table: "Book",
                keyColumn: "BookId",
                keyValue: 1928,
                columns: new[] { "CreatedDateTime", "PublicationDate" },
                values: new object[] { new DateTime(2024, 8, 16, 16, 32, 4, 682, DateTimeKind.Utc).AddTicks(2954), new DateTime(2024, 4, 16, 22, 10, 16, 292, DateTimeKind.Local).AddTicks(4196) });

            migrationBuilder.UpdateData(
                table: "Book",
                keyColumn: "BookId",
                keyValue: 1929,
                columns: new[] { "CreatedDateTime", "PublicationDate" },
                values: new object[] { new DateTime(2024, 8, 16, 16, 32, 4, 682, DateTimeKind.Utc).AddTicks(3048), new DateTime(2023, 9, 9, 3, 4, 1, 589, DateTimeKind.Local).AddTicks(4381) });

            migrationBuilder.UpdateData(
                table: "Book",
                keyColumn: "BookId",
                keyValue: 1930,
                columns: new[] { "CreatedDateTime", "PublicationDate" },
                values: new object[] { new DateTime(2024, 8, 16, 16, 32, 4, 682, DateTimeKind.Utc).AddTicks(3188), new DateTime(2024, 3, 11, 20, 37, 42, 56, DateTimeKind.Local).AddTicks(5437) });

            migrationBuilder.UpdateData(
                table: "Book",
                keyColumn: "BookId",
                keyValue: 1931,
                columns: new[] { "CreatedDateTime", "PublicationDate" },
                values: new object[] { new DateTime(2024, 8, 16, 16, 32, 4, 682, DateTimeKind.Utc).AddTicks(3280), new DateTime(2024, 4, 21, 4, 17, 26, 418, DateTimeKind.Local).AddTicks(5568) });

            migrationBuilder.UpdateData(
                table: "Book",
                keyColumn: "BookId",
                keyValue: 1932,
                columns: new[] { "CreatedDateTime", "PublicationDate" },
                values: new object[] { new DateTime(2024, 8, 16, 16, 32, 4, 682, DateTimeKind.Utc).AddTicks(3402), new DateTime(2024, 4, 27, 4, 24, 34, 160, DateTimeKind.Local).AddTicks(6031) });

            migrationBuilder.UpdateData(
                table: "Book",
                keyColumn: "BookId",
                keyValue: 1933,
                columns: new[] { "CreatedDateTime", "PublicationDate" },
                values: new object[] { new DateTime(2024, 8, 16, 16, 32, 4, 682, DateTimeKind.Utc).AddTicks(3516), new DateTime(2024, 1, 14, 21, 41, 58, 436, DateTimeKind.Local).AddTicks(2646) });

            migrationBuilder.UpdateData(
                table: "Book",
                keyColumn: "BookId",
                keyValue: 1934,
                columns: new[] { "CreatedDateTime", "PublicationDate" },
                values: new object[] { new DateTime(2024, 8, 16, 16, 32, 4, 682, DateTimeKind.Utc).AddTicks(3610), new DateTime(2024, 3, 24, 17, 45, 7, 50, DateTimeKind.Local).AddTicks(7880) });

            migrationBuilder.UpdateData(
                table: "Book",
                keyColumn: "BookId",
                keyValue: 1935,
                columns: new[] { "CreatedDateTime", "PublicationDate" },
                values: new object[] { new DateTime(2024, 8, 16, 16, 32, 4, 682, DateTimeKind.Utc).AddTicks(3735), new DateTime(2024, 7, 27, 13, 15, 0, 851, DateTimeKind.Local).AddTicks(4705) });

            migrationBuilder.UpdateData(
                table: "Book",
                keyColumn: "BookId",
                keyValue: 1936,
                columns: new[] { "CreatedDateTime", "PublicationDate" },
                values: new object[] { new DateTime(2024, 8, 16, 16, 32, 4, 682, DateTimeKind.Utc).AddTicks(3832), new DateTime(2024, 7, 19, 13, 37, 10, 110, DateTimeKind.Local).AddTicks(7387) });

            migrationBuilder.UpdateData(
                table: "Book",
                keyColumn: "BookId",
                keyValue: 1937,
                columns: new[] { "CreatedDateTime", "PublicationDate" },
                values: new object[] { new DateTime(2024, 8, 16, 16, 32, 4, 682, DateTimeKind.Utc).AddTicks(3953), new DateTime(2023, 10, 11, 4, 55, 2, 708, DateTimeKind.Local).AddTicks(1737) });

            migrationBuilder.UpdateData(
                table: "Book",
                keyColumn: "BookId",
                keyValue: 1938,
                columns: new[] { "CreatedDateTime", "PublicationDate" },
                values: new object[] { new DateTime(2024, 8, 16, 16, 32, 4, 682, DateTimeKind.Utc).AddTicks(4038), new DateTime(2024, 5, 10, 11, 1, 34, 269, DateTimeKind.Local).AddTicks(2184) });

            migrationBuilder.UpdateData(
                table: "Book",
                keyColumn: "BookId",
                keyValue: 1939,
                columns: new[] { "CreatedDateTime", "PublicationDate" },
                values: new object[] { new DateTime(2024, 8, 16, 16, 32, 4, 682, DateTimeKind.Utc).AddTicks(4159), new DateTime(2024, 3, 28, 12, 14, 57, 838, DateTimeKind.Local).AddTicks(8681) });

            migrationBuilder.UpdateData(
                table: "Book",
                keyColumn: "BookId",
                keyValue: 1940,
                columns: new[] { "CreatedDateTime", "PublicationDate" },
                values: new object[] { new DateTime(2024, 8, 16, 16, 32, 4, 682, DateTimeKind.Utc).AddTicks(4264), new DateTime(2023, 11, 15, 9, 7, 45, 671, DateTimeKind.Local).AddTicks(7552) });

            migrationBuilder.UpdateData(
                table: "Book",
                keyColumn: "BookId",
                keyValue: 1941,
                columns: new[] { "CreatedDateTime", "PublicationDate" },
                values: new object[] { new DateTime(2024, 8, 16, 16, 32, 4, 682, DateTimeKind.Utc).AddTicks(4375), new DateTime(2024, 7, 6, 14, 45, 47, 909, DateTimeKind.Local).AddTicks(6204) });

            migrationBuilder.UpdateData(
                table: "Book",
                keyColumn: "BookId",
                keyValue: 1942,
                columns: new[] { "CreatedDateTime", "PublicationDate" },
                values: new object[] { new DateTime(2024, 8, 16, 16, 32, 4, 682, DateTimeKind.Utc).AddTicks(4476), new DateTime(2024, 3, 30, 3, 27, 28, 452, DateTimeKind.Local).AddTicks(2377) });

            migrationBuilder.UpdateData(
                table: "Book",
                keyColumn: "BookId",
                keyValue: 1943,
                columns: new[] { "CreatedDateTime", "PublicationDate" },
                values: new object[] { new DateTime(2024, 8, 16, 16, 32, 4, 682, DateTimeKind.Utc).AddTicks(4611), new DateTime(2023, 11, 26, 3, 41, 40, 199, DateTimeKind.Local).AddTicks(1864) });

            migrationBuilder.UpdateData(
                table: "Book",
                keyColumn: "BookId",
                keyValue: 1944,
                columns: new[] { "CreatedDateTime", "PublicationDate" },
                values: new object[] { new DateTime(2024, 8, 16, 16, 32, 4, 682, DateTimeKind.Utc).AddTicks(4702), new DateTime(2023, 12, 23, 18, 43, 49, 63, DateTimeKind.Local).AddTicks(2614) });

            migrationBuilder.UpdateData(
                table: "Book",
                keyColumn: "BookId",
                keyValue: 1945,
                columns: new[] { "CreatedDateTime", "PublicationDate" },
                values: new object[] { new DateTime(2024, 8, 16, 16, 32, 4, 682, DateTimeKind.Utc).AddTicks(4835), new DateTime(2023, 10, 5, 15, 47, 40, 62, DateTimeKind.Local).AddTicks(8177) });

            migrationBuilder.UpdateData(
                table: "Book",
                keyColumn: "BookId",
                keyValue: 1946,
                columns: new[] { "CreatedDateTime", "PublicationDate" },
                values: new object[] { new DateTime(2024, 8, 16, 16, 32, 4, 682, DateTimeKind.Utc).AddTicks(4928), new DateTime(2024, 2, 1, 22, 12, 29, 724, DateTimeKind.Local).AddTicks(4840) });

            migrationBuilder.UpdateData(
                table: "Book",
                keyColumn: "BookId",
                keyValue: 1947,
                columns: new[] { "CreatedDateTime", "PublicationDate" },
                values: new object[] { new DateTime(2024, 8, 16, 16, 32, 4, 682, DateTimeKind.Utc).AddTicks(5039), new DateTime(2023, 12, 28, 1, 36, 27, 556, DateTimeKind.Local).AddTicks(9745) });

            migrationBuilder.UpdateData(
                table: "Book",
                keyColumn: "BookId",
                keyValue: 1948,
                columns: new[] { "CreatedDateTime", "PublicationDate" },
                values: new object[] { new DateTime(2024, 8, 16, 16, 32, 4, 682, DateTimeKind.Utc).AddTicks(5141), new DateTime(2024, 6, 28, 15, 57, 51, 844, DateTimeKind.Local).AddTicks(827) });

            migrationBuilder.UpdateData(
                table: "Book",
                keyColumn: "BookId",
                keyValue: 1949,
                columns: new[] { "CreatedDateTime", "PublicationDate" },
                values: new object[] { new DateTime(2024, 8, 16, 16, 32, 4, 682, DateTimeKind.Utc).AddTicks(5256), new DateTime(2024, 5, 2, 23, 17, 20, 68, DateTimeKind.Local).AddTicks(8549) });

            migrationBuilder.UpdateData(
                table: "Book",
                keyColumn: "BookId",
                keyValue: 1950,
                columns: new[] { "CreatedDateTime", "PublicationDate" },
                values: new object[] { new DateTime(2024, 8, 16, 16, 32, 4, 682, DateTimeKind.Utc).AddTicks(5351), new DateTime(2023, 11, 21, 12, 15, 44, 934, DateTimeKind.Local).AddTicks(7696) });

            migrationBuilder.UpdateData(
                table: "Book",
                keyColumn: "BookId",
                keyValue: 1951,
                columns: new[] { "CreatedDateTime", "PublicationDate" },
                values: new object[] { new DateTime(2024, 8, 16, 16, 32, 4, 682, DateTimeKind.Utc).AddTicks(5463), new DateTime(2023, 12, 18, 2, 18, 47, 463, DateTimeKind.Local).AddTicks(7383) });

            migrationBuilder.UpdateData(
                table: "Book",
                keyColumn: "BookId",
                keyValue: 1952,
                columns: new[] { "CreatedDateTime", "PublicationDate" },
                values: new object[] { new DateTime(2024, 8, 16, 16, 32, 4, 682, DateTimeKind.Utc).AddTicks(5545), new DateTime(2024, 7, 8, 12, 59, 29, 349, DateTimeKind.Local).AddTicks(6857) });

            migrationBuilder.UpdateData(
                table: "Book",
                keyColumn: "BookId",
                keyValue: 1953,
                columns: new[] { "CreatedDateTime", "PublicationDate" },
                values: new object[] { new DateTime(2024, 8, 16, 16, 32, 4, 682, DateTimeKind.Utc).AddTicks(5672), new DateTime(2024, 7, 28, 11, 41, 11, 40, DateTimeKind.Local).AddTicks(326) });

            migrationBuilder.UpdateData(
                table: "Book",
                keyColumn: "BookId",
                keyValue: 1954,
                columns: new[] { "CreatedDateTime", "PublicationDate" },
                values: new object[] { new DateTime(2024, 8, 16, 16, 32, 4, 682, DateTimeKind.Utc).AddTicks(5760), new DateTime(2024, 6, 13, 14, 49, 5, 702, DateTimeKind.Local).AddTicks(4924) });

            migrationBuilder.UpdateData(
                table: "Book",
                keyColumn: "BookId",
                keyValue: 1955,
                columns: new[] { "CreatedDateTime", "PublicationDate" },
                values: new object[] { new DateTime(2024, 8, 16, 16, 32, 4, 682, DateTimeKind.Utc).AddTicks(5881), new DateTime(2024, 2, 7, 21, 35, 7, 352, DateTimeKind.Local).AddTicks(4303) });

            migrationBuilder.UpdateData(
                table: "Book",
                keyColumn: "BookId",
                keyValue: 1956,
                columns: new[] { "CreatedDateTime", "PublicationDate" },
                values: new object[] { new DateTime(2024, 8, 16, 16, 32, 4, 682, DateTimeKind.Utc).AddTicks(5974), new DateTime(2024, 3, 30, 15, 18, 31, 142, DateTimeKind.Local).AddTicks(4247) });

            migrationBuilder.UpdateData(
                table: "Book",
                keyColumn: "BookId",
                keyValue: 1957,
                columns: new[] { "CreatedDateTime", "PublicationDate" },
                values: new object[] { new DateTime(2024, 8, 16, 16, 32, 4, 682, DateTimeKind.Utc).AddTicks(6086), new DateTime(2023, 10, 23, 20, 38, 50, 31, DateTimeKind.Local).AddTicks(6820) });

            migrationBuilder.UpdateData(
                table: "Book",
                keyColumn: "BookId",
                keyValue: 1958,
                columns: new[] { "CreatedDateTime", "PublicationDate" },
                values: new object[] { new DateTime(2024, 8, 16, 16, 32, 4, 682, DateTimeKind.Utc).AddTicks(6188), new DateTime(2023, 10, 29, 3, 4, 42, 998, DateTimeKind.Local).AddTicks(5007) });

            migrationBuilder.UpdateData(
                table: "Book",
                keyColumn: "BookId",
                keyValue: 1959,
                columns: new[] { "CreatedDateTime", "PublicationDate" },
                values: new object[] { new DateTime(2024, 8, 16, 16, 32, 4, 682, DateTimeKind.Utc).AddTicks(6341), new DateTime(2024, 4, 26, 0, 43, 29, 6, DateTimeKind.Local).AddTicks(5741) });

            migrationBuilder.UpdateData(
                table: "Book",
                keyColumn: "BookId",
                keyValue: 1960,
                columns: new[] { "CreatedDateTime", "PublicationDate" },
                values: new object[] { new DateTime(2024, 8, 16, 16, 32, 4, 682, DateTimeKind.Utc).AddTicks(6479), new DateTime(2024, 5, 9, 6, 39, 57, 168, DateTimeKind.Local).AddTicks(3949) });

            migrationBuilder.UpdateData(
                table: "Book",
                keyColumn: "BookId",
                keyValue: 1961,
                columns: new[] { "CreatedDateTime", "PublicationDate" },
                values: new object[] { new DateTime(2024, 8, 16, 16, 32, 4, 682, DateTimeKind.Utc).AddTicks(6579), new DateTime(2024, 6, 10, 20, 41, 55, 495, DateTimeKind.Local).AddTicks(6636) });

            migrationBuilder.UpdateData(
                table: "Book",
                keyColumn: "BookId",
                keyValue: 1962,
                columns: new[] { "CreatedDateTime", "PublicationDate" },
                values: new object[] { new DateTime(2024, 8, 16, 16, 32, 4, 682, DateTimeKind.Utc).AddTicks(6697), new DateTime(2023, 12, 29, 7, 51, 22, 752, DateTimeKind.Local).AddTicks(8974) });

            migrationBuilder.UpdateData(
                table: "Book",
                keyColumn: "BookId",
                keyValue: 1963,
                columns: new[] { "CreatedDateTime", "PublicationDate" },
                values: new object[] { new DateTime(2024, 8, 16, 16, 32, 4, 682, DateTimeKind.Utc).AddTicks(6788), new DateTime(2024, 7, 19, 5, 37, 14, 409, DateTimeKind.Local).AddTicks(1533) });

            migrationBuilder.UpdateData(
                table: "Book",
                keyColumn: "BookId",
                keyValue: 1964,
                columns: new[] { "CreatedDateTime", "PublicationDate" },
                values: new object[] { new DateTime(2024, 8, 16, 16, 32, 4, 682, DateTimeKind.Utc).AddTicks(6907), new DateTime(2023, 11, 14, 3, 6, 19, 706, DateTimeKind.Local).AddTicks(6324) });

            migrationBuilder.UpdateData(
                table: "Book",
                keyColumn: "BookId",
                keyValue: 1965,
                columns: new[] { "CreatedDateTime", "PublicationDate" },
                values: new object[] { new DateTime(2024, 8, 16, 16, 32, 4, 682, DateTimeKind.Utc).AddTicks(7003), new DateTime(2023, 10, 20, 10, 20, 1, 708, DateTimeKind.Local).AddTicks(4615) });

            migrationBuilder.UpdateData(
                table: "Book",
                keyColumn: "BookId",
                keyValue: 1966,
                columns: new[] { "CreatedDateTime", "PublicationDate" },
                values: new object[] { new DateTime(2024, 8, 16, 16, 32, 4, 682, DateTimeKind.Utc).AddTicks(7130), new DateTime(2024, 3, 27, 12, 0, 41, 467, DateTimeKind.Local).AddTicks(9894) });

            migrationBuilder.UpdateData(
                table: "Book",
                keyColumn: "BookId",
                keyValue: 1967,
                columns: new[] { "CreatedDateTime", "PublicationDate" },
                values: new object[] { new DateTime(2024, 8, 16, 16, 32, 4, 682, DateTimeKind.Utc).AddTicks(7226), new DateTime(2024, 6, 19, 16, 15, 34, 805, DateTimeKind.Local).AddTicks(6956) });

            migrationBuilder.UpdateData(
                table: "Book",
                keyColumn: "BookId",
                keyValue: 1968,
                columns: new[] { "CreatedDateTime", "PublicationDate" },
                values: new object[] { new DateTime(2024, 8, 16, 16, 32, 4, 682, DateTimeKind.Utc).AddTicks(7341), new DateTime(2024, 2, 14, 22, 10, 9, 15, DateTimeKind.Local).AddTicks(9752) });

            migrationBuilder.UpdateData(
                table: "Book",
                keyColumn: "BookId",
                keyValue: 1969,
                columns: new[] { "CreatedDateTime", "PublicationDate" },
                values: new object[] { new DateTime(2024, 8, 16, 16, 32, 4, 682, DateTimeKind.Utc).AddTicks(7475), new DateTime(2024, 3, 21, 4, 51, 58, 911, DateTimeKind.Local).AddTicks(8168) });

            migrationBuilder.UpdateData(
                table: "Book",
                keyColumn: "BookId",
                keyValue: 1970,
                columns: new[] { "CreatedDateTime", "PublicationDate" },
                values: new object[] { new DateTime(2024, 8, 16, 16, 32, 4, 682, DateTimeKind.Utc).AddTicks(7568), new DateTime(2024, 3, 6, 22, 6, 36, 75, DateTimeKind.Local).AddTicks(5670) });

            migrationBuilder.UpdateData(
                table: "Book",
                keyColumn: "BookId",
                keyValue: 1971,
                columns: new[] { "CreatedDateTime", "PublicationDate" },
                values: new object[] { new DateTime(2024, 8, 16, 16, 32, 4, 682, DateTimeKind.Utc).AddTicks(7687), new DateTime(2023, 12, 3, 0, 32, 53, 291, DateTimeKind.Local).AddTicks(9064) });

            migrationBuilder.UpdateData(
                table: "Book",
                keyColumn: "BookId",
                keyValue: 1972,
                columns: new[] { "CreatedDateTime", "PublicationDate" },
                values: new object[] { new DateTime(2024, 8, 16, 16, 32, 4, 682, DateTimeKind.Utc).AddTicks(7779), new DateTime(2023, 11, 21, 22, 15, 28, 422, DateTimeKind.Local).AddTicks(6513) });

            migrationBuilder.UpdateData(
                table: "Book",
                keyColumn: "BookId",
                keyValue: 1973,
                columns: new[] { "CreatedDateTime", "PublicationDate" },
                values: new object[] { new DateTime(2024, 8, 16, 16, 32, 4, 682, DateTimeKind.Utc).AddTicks(7897), new DateTime(2024, 2, 2, 18, 48, 35, 323, DateTimeKind.Local).AddTicks(9843) });

            migrationBuilder.UpdateData(
                table: "Book",
                keyColumn: "BookId",
                keyValue: 1974,
                columns: new[] { "CreatedDateTime", "PublicationDate" },
                values: new object[] { new DateTime(2024, 8, 16, 16, 32, 4, 682, DateTimeKind.Utc).AddTicks(7996), new DateTime(2024, 6, 23, 23, 3, 58, 227, DateTimeKind.Local).AddTicks(3329) });

            migrationBuilder.UpdateData(
                table: "Book",
                keyColumn: "BookId",
                keyValue: 1975,
                columns: new[] { "CreatedDateTime", "PublicationDate" },
                values: new object[] { new DateTime(2024, 8, 16, 16, 32, 4, 682, DateTimeKind.Utc).AddTicks(8120), new DateTime(2024, 3, 12, 16, 24, 34, 594, DateTimeKind.Local).AddTicks(8889) });

            migrationBuilder.UpdateData(
                table: "Book",
                keyColumn: "BookId",
                keyValue: 1976,
                columns: new[] { "CreatedDateTime", "PublicationDate" },
                values: new object[] { new DateTime(2024, 8, 16, 16, 32, 4, 682, DateTimeKind.Utc).AddTicks(8210), new DateTime(2023, 10, 31, 21, 35, 45, 258, DateTimeKind.Local).AddTicks(4356) });

            migrationBuilder.UpdateData(
                table: "Book",
                keyColumn: "BookId",
                keyValue: 1977,
                columns: new[] { "CreatedDateTime", "PublicationDate" },
                values: new object[] { new DateTime(2024, 8, 16, 16, 32, 4, 682, DateTimeKind.Utc).AddTicks(8340), new DateTime(2024, 2, 19, 8, 42, 31, 169, DateTimeKind.Local).AddTicks(891) });

            migrationBuilder.UpdateData(
                table: "Book",
                keyColumn: "BookId",
                keyValue: 1978,
                columns: new[] { "CreatedDateTime", "PublicationDate" },
                values: new object[] { new DateTime(2024, 8, 16, 16, 32, 4, 682, DateTimeKind.Utc).AddTicks(8426), new DateTime(2023, 10, 18, 2, 44, 30, 872, DateTimeKind.Local).AddTicks(2441) });

            migrationBuilder.UpdateData(
                table: "Book",
                keyColumn: "BookId",
                keyValue: 1979,
                columns: new[] { "CreatedDateTime", "PublicationDate" },
                values: new object[] { new DateTime(2024, 8, 16, 16, 32, 4, 682, DateTimeKind.Utc).AddTicks(8550), new DateTime(2024, 1, 23, 3, 35, 59, 334, DateTimeKind.Local).AddTicks(8829) });

            migrationBuilder.UpdateData(
                table: "Book",
                keyColumn: "BookId",
                keyValue: 1980,
                columns: new[] { "CreatedDateTime", "PublicationDate" },
                values: new object[] { new DateTime(2024, 8, 16, 16, 32, 4, 682, DateTimeKind.Utc).AddTicks(8639), new DateTime(2024, 7, 5, 16, 22, 29, 507, DateTimeKind.Local).AddTicks(3502) });

            migrationBuilder.UpdateData(
                table: "Book",
                keyColumn: "BookId",
                keyValue: 1981,
                columns: new[] { "CreatedDateTime", "PublicationDate" },
                values: new object[] { new DateTime(2024, 8, 16, 16, 32, 4, 682, DateTimeKind.Utc).AddTicks(8760), new DateTime(2024, 6, 2, 2, 20, 2, 328, DateTimeKind.Local).AddTicks(1565) });

            migrationBuilder.UpdateData(
                table: "Book",
                keyColumn: "BookId",
                keyValue: 1982,
                columns: new[] { "CreatedDateTime", "PublicationDate" },
                values: new object[] { new DateTime(2024, 8, 16, 16, 32, 4, 682, DateTimeKind.Utc).AddTicks(8847), new DateTime(2023, 10, 12, 1, 49, 55, 163, DateTimeKind.Local).AddTicks(5572) });

            migrationBuilder.UpdateData(
                table: "Book",
                keyColumn: "BookId",
                keyValue: 1983,
                columns: new[] { "CreatedDateTime", "PublicationDate" },
                values: new object[] { new DateTime(2024, 8, 16, 16, 32, 4, 682, DateTimeKind.Utc).AddTicks(8958), new DateTime(2023, 11, 14, 3, 26, 14, 372, DateTimeKind.Local).AddTicks(6583) });

            migrationBuilder.UpdateData(
                table: "Book",
                keyColumn: "BookId",
                keyValue: 1984,
                columns: new[] { "CreatedDateTime", "PublicationDate" },
                values: new object[] { new DateTime(2024, 8, 16, 16, 32, 4, 682, DateTimeKind.Utc).AddTicks(9066), new DateTime(2023, 11, 16, 8, 43, 24, 910, DateTimeKind.Local).AddTicks(523) });

            migrationBuilder.UpdateData(
                table: "Book",
                keyColumn: "BookId",
                keyValue: 1985,
                columns: new[] { "CreatedDateTime", "PublicationDate" },
                values: new object[] { new DateTime(2024, 8, 16, 16, 32, 4, 682, DateTimeKind.Utc).AddTicks(9187), new DateTime(2024, 8, 4, 12, 45, 42, 261, DateTimeKind.Local).AddTicks(1107) });

            migrationBuilder.UpdateData(
                table: "Book",
                keyColumn: "BookId",
                keyValue: 1986,
                columns: new[] { "CreatedDateTime", "PublicationDate" },
                values: new object[] { new DateTime(2024, 8, 16, 16, 32, 4, 682, DateTimeKind.Utc).AddTicks(9281), new DateTime(2024, 1, 24, 21, 52, 59, 521, DateTimeKind.Local).AddTicks(8121) });

            migrationBuilder.UpdateData(
                table: "Book",
                keyColumn: "BookId",
                keyValue: 1987,
                columns: new[] { "CreatedDateTime", "PublicationDate" },
                values: new object[] { new DateTime(2024, 8, 16, 16, 32, 4, 682, DateTimeKind.Utc).AddTicks(9404), new DateTime(2024, 7, 11, 12, 23, 18, 41, DateTimeKind.Local).AddTicks(9897) });

            migrationBuilder.UpdateData(
                table: "Book",
                keyColumn: "BookId",
                keyValue: 1988,
                columns: new[] { "CreatedDateTime", "PublicationDate" },
                values: new object[] { new DateTime(2024, 8, 16, 16, 32, 4, 682, DateTimeKind.Utc).AddTicks(9499), new DateTime(2023, 9, 30, 14, 3, 45, 599, DateTimeKind.Local).AddTicks(5346) });

            migrationBuilder.UpdateData(
                table: "Book",
                keyColumn: "BookId",
                keyValue: 1989,
                columns: new[] { "CreatedDateTime", "PublicationDate" },
                values: new object[] { new DateTime(2024, 8, 16, 16, 32, 4, 682, DateTimeKind.Utc).AddTicks(9626), new DateTime(2024, 3, 7, 8, 31, 59, 538, DateTimeKind.Local).AddTicks(1640) });

            migrationBuilder.UpdateData(
                table: "Book",
                keyColumn: "BookId",
                keyValue: 1990,
                columns: new[] { "CreatedDateTime", "PublicationDate" },
                values: new object[] { new DateTime(2024, 8, 16, 16, 32, 4, 682, DateTimeKind.Utc).AddTicks(9748), new DateTime(2024, 1, 27, 0, 6, 45, 630, DateTimeKind.Local).AddTicks(5687) });

            migrationBuilder.UpdateData(
                table: "Book",
                keyColumn: "BookId",
                keyValue: 1991,
                columns: new[] { "CreatedDateTime", "PublicationDate" },
                values: new object[] { new DateTime(2024, 8, 16, 16, 32, 4, 682, DateTimeKind.Utc).AddTicks(9842), new DateTime(2024, 6, 18, 0, 46, 46, 710, DateTimeKind.Local).AddTicks(6554) });

            migrationBuilder.UpdateData(
                table: "Book",
                keyColumn: "BookId",
                keyValue: 1992,
                columns: new[] { "CreatedDateTime", "PublicationDate" },
                values: new object[] { new DateTime(2024, 8, 16, 16, 32, 4, 682, DateTimeKind.Utc).AddTicks(9961), new DateTime(2023, 11, 16, 4, 48, 45, 744, DateTimeKind.Local).AddTicks(7362) });

            migrationBuilder.UpdateData(
                table: "Book",
                keyColumn: "BookId",
                keyValue: 1993,
                columns: new[] { "CreatedDateTime", "PublicationDate" },
                values: new object[] { new DateTime(2024, 8, 16, 16, 32, 4, 683, DateTimeKind.Utc).AddTicks(52), new DateTime(2023, 11, 20, 9, 37, 42, 40, DateTimeKind.Local).AddTicks(1804) });

            migrationBuilder.UpdateData(
                table: "Book",
                keyColumn: "BookId",
                keyValue: 1994,
                columns: new[] { "CreatedDateTime", "PublicationDate" },
                values: new object[] { new DateTime(2024, 8, 16, 16, 32, 4, 683, DateTimeKind.Utc).AddTicks(180), new DateTime(2024, 3, 17, 14, 18, 21, 369, DateTimeKind.Local).AddTicks(5825) });

            migrationBuilder.UpdateData(
                table: "Book",
                keyColumn: "BookId",
                keyValue: 1995,
                columns: new[] { "CreatedDateTime", "PublicationDate" },
                values: new object[] { new DateTime(2024, 8, 16, 16, 32, 4, 683, DateTimeKind.Utc).AddTicks(268), new DateTime(2023, 12, 14, 15, 59, 4, 686, DateTimeKind.Local).AddTicks(6447) });

            migrationBuilder.UpdateData(
                table: "Book",
                keyColumn: "BookId",
                keyValue: 1996,
                columns: new[] { "CreatedDateTime", "PublicationDate" },
                values: new object[] { new DateTime(2024, 8, 16, 16, 32, 4, 683, DateTimeKind.Utc).AddTicks(394), new DateTime(2023, 10, 1, 11, 38, 28, 976, DateTimeKind.Local).AddTicks(4876) });

            migrationBuilder.UpdateData(
                table: "Book",
                keyColumn: "BookId",
                keyValue: 1997,
                columns: new[] { "CreatedDateTime", "PublicationDate" },
                values: new object[] { new DateTime(2024, 8, 16, 16, 32, 4, 683, DateTimeKind.Utc).AddTicks(484), new DateTime(2024, 4, 19, 12, 12, 40, 341, DateTimeKind.Local).AddTicks(9569) });

            migrationBuilder.UpdateData(
                table: "Book",
                keyColumn: "BookId",
                keyValue: 1998,
                columns: new[] { "CreatedDateTime", "PublicationDate" },
                values: new object[] { new DateTime(2024, 8, 16, 16, 32, 4, 683, DateTimeKind.Utc).AddTicks(595), new DateTime(2024, 3, 12, 5, 39, 4, 436, DateTimeKind.Local).AddTicks(3337) });

            migrationBuilder.UpdateData(
                table: "Book",
                keyColumn: "BookId",
                keyValue: 1999,
                columns: new[] { "CreatedDateTime", "PublicationDate" },
                values: new object[] { new DateTime(2024, 8, 16, 16, 32, 4, 683, DateTimeKind.Utc).AddTicks(688), new DateTime(2024, 6, 25, 14, 30, 27, 728, DateTimeKind.Local).AddTicks(1202) });

            migrationBuilder.UpdateData(
                table: "Book",
                keyColumn: "BookId",
                keyValue: 2000,
                columns: new[] { "CreatedDateTime", "PublicationDate" },
                values: new object[] { new DateTime(2024, 8, 16, 16, 32, 4, 683, DateTimeKind.Utc).AddTicks(820), new DateTime(2023, 8, 28, 18, 14, 55, 157, DateTimeKind.Local).AddTicks(1594) });
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<string>(
                name: "Phone",
                table: "User",
                type: "nvarchar(255)",
                maxLength: 255,
                nullable: true);

            migrationBuilder.UpdateData(
                table: "Book",
                keyColumn: "BookId",
                keyValue: 1001,
                columns: new[] { "CreatedDateTime", "PublicationDate" },
                values: new object[] { new DateTime(2024, 8, 16, 14, 36, 27, 263, DateTimeKind.Utc).AddTicks(9275), new DateTime(2024, 2, 28, 1, 33, 52, 877, DateTimeKind.Local).AddTicks(1834) });

            migrationBuilder.UpdateData(
                table: "Book",
                keyColumn: "BookId",
                keyValue: 1002,
                columns: new[] { "CreatedDateTime", "PublicationDate" },
                values: new object[] { new DateTime(2024, 8, 16, 14, 36, 27, 263, DateTimeKind.Utc).AddTicks(9949), new DateTime(2024, 2, 16, 21, 8, 40, 471, DateTimeKind.Local).AddTicks(331) });

            migrationBuilder.UpdateData(
                table: "Book",
                keyColumn: "BookId",
                keyValue: 1003,
                columns: new[] { "CreatedDateTime", "PublicationDate" },
                values: new object[] { new DateTime(2024, 8, 16, 14, 36, 27, 264, DateTimeKind.Utc).AddTicks(166), new DateTime(2023, 11, 3, 5, 21, 25, 745, DateTimeKind.Local).AddTicks(181) });

            migrationBuilder.UpdateData(
                table: "Book",
                keyColumn: "BookId",
                keyValue: 1004,
                columns: new[] { "CreatedDateTime", "PublicationDate" },
                values: new object[] { new DateTime(2024, 8, 16, 14, 36, 27, 264, DateTimeKind.Utc).AddTicks(317), new DateTime(2023, 9, 13, 17, 16, 16, 273, DateTimeKind.Local).AddTicks(9124) });

            migrationBuilder.UpdateData(
                table: "Book",
                keyColumn: "BookId",
                keyValue: 1005,
                columns: new[] { "CreatedDateTime", "PublicationDate" },
                values: new object[] { new DateTime(2024, 8, 16, 14, 36, 27, 264, DateTimeKind.Utc).AddTicks(500), new DateTime(2023, 10, 10, 22, 16, 15, 103, DateTimeKind.Local).AddTicks(8868) });

            migrationBuilder.UpdateData(
                table: "Book",
                keyColumn: "BookId",
                keyValue: 1006,
                columns: new[] { "CreatedDateTime", "PublicationDate" },
                values: new object[] { new DateTime(2024, 8, 16, 14, 36, 27, 264, DateTimeKind.Utc).AddTicks(625), new DateTime(2023, 8, 20, 11, 11, 34, 375, DateTimeKind.Local).AddTicks(4800) });

            migrationBuilder.UpdateData(
                table: "Book",
                keyColumn: "BookId",
                keyValue: 1007,
                columns: new[] { "CreatedDateTime", "PublicationDate" },
                values: new object[] { new DateTime(2024, 8, 16, 14, 36, 27, 264, DateTimeKind.Utc).AddTicks(783), new DateTime(2024, 3, 23, 4, 7, 21, 923, DateTimeKind.Local).AddTicks(3120) });

            migrationBuilder.UpdateData(
                table: "Book",
                keyColumn: "BookId",
                keyValue: 1008,
                columns: new[] { "CreatedDateTime", "PublicationDate" },
                values: new object[] { new DateTime(2024, 8, 16, 14, 36, 27, 264, DateTimeKind.Utc).AddTicks(900), new DateTime(2024, 3, 4, 14, 35, 20, 171, DateTimeKind.Local).AddTicks(1579) });

            migrationBuilder.UpdateData(
                table: "Book",
                keyColumn: "BookId",
                keyValue: 1009,
                columns: new[] { "CreatedDateTime", "PublicationDate" },
                values: new object[] { new DateTime(2024, 8, 16, 14, 36, 27, 264, DateTimeKind.Utc).AddTicks(1045), new DateTime(2023, 9, 25, 21, 17, 13, 513, DateTimeKind.Local).AddTicks(6148) });

            migrationBuilder.UpdateData(
                table: "Book",
                keyColumn: "BookId",
                keyValue: 1010,
                columns: new[] { "CreatedDateTime", "PublicationDate" },
                values: new object[] { new DateTime(2024, 8, 16, 14, 36, 27, 264, DateTimeKind.Utc).AddTicks(1175), new DateTime(2024, 5, 7, 2, 20, 2, 248, DateTimeKind.Local).AddTicks(5635) });

            migrationBuilder.UpdateData(
                table: "Book",
                keyColumn: "BookId",
                keyValue: 1011,
                columns: new[] { "CreatedDateTime", "PublicationDate" },
                values: new object[] { new DateTime(2024, 8, 16, 14, 36, 27, 264, DateTimeKind.Utc).AddTicks(1317), new DateTime(2024, 6, 16, 0, 39, 59, 301, DateTimeKind.Local).AddTicks(8541) });

            migrationBuilder.UpdateData(
                table: "Book",
                keyColumn: "BookId",
                keyValue: 1012,
                columns: new[] { "CreatedDateTime", "PublicationDate" },
                values: new object[] { new DateTime(2024, 8, 16, 14, 36, 27, 264, DateTimeKind.Utc).AddTicks(1447), new DateTime(2023, 9, 3, 7, 27, 33, 49, DateTimeKind.Local).AddTicks(2246) });

            migrationBuilder.UpdateData(
                table: "Book",
                keyColumn: "BookId",
                keyValue: 1013,
                columns: new[] { "CreatedDateTime", "PublicationDate" },
                values: new object[] { new DateTime(2024, 8, 16, 14, 36, 27, 264, DateTimeKind.Utc).AddTicks(1583), new DateTime(2024, 7, 9, 6, 12, 52, 733, DateTimeKind.Local).AddTicks(9663) });

            migrationBuilder.UpdateData(
                table: "Book",
                keyColumn: "BookId",
                keyValue: 1014,
                columns: new[] { "CreatedDateTime", "PublicationDate" },
                values: new object[] { new DateTime(2024, 8, 16, 14, 36, 27, 264, DateTimeKind.Utc).AddTicks(1702), new DateTime(2024, 2, 16, 2, 45, 47, 558, DateTimeKind.Local).AddTicks(8870) });

            migrationBuilder.UpdateData(
                table: "Book",
                keyColumn: "BookId",
                keyValue: 1015,
                columns: new[] { "CreatedDateTime", "PublicationDate" },
                values: new object[] { new DateTime(2024, 8, 16, 14, 36, 27, 264, DateTimeKind.Utc).AddTicks(1882), new DateTime(2023, 8, 16, 13, 24, 59, 544, DateTimeKind.Local).AddTicks(1747) });

            migrationBuilder.UpdateData(
                table: "Book",
                keyColumn: "BookId",
                keyValue: 1016,
                columns: new[] { "CreatedDateTime", "PublicationDate" },
                values: new object[] { new DateTime(2024, 8, 16, 14, 36, 27, 264, DateTimeKind.Utc).AddTicks(2001), new DateTime(2023, 9, 19, 20, 41, 34, 261, DateTimeKind.Local).AddTicks(5844) });

            migrationBuilder.UpdateData(
                table: "Book",
                keyColumn: "BookId",
                keyValue: 1017,
                columns: new[] { "CreatedDateTime", "PublicationDate" },
                values: new object[] { new DateTime(2024, 8, 16, 14, 36, 27, 264, DateTimeKind.Utc).AddTicks(2143), new DateTime(2024, 7, 6, 21, 54, 31, 135, DateTimeKind.Local).AddTicks(2619) });

            migrationBuilder.UpdateData(
                table: "Book",
                keyColumn: "BookId",
                keyValue: 1018,
                columns: new[] { "CreatedDateTime", "PublicationDate" },
                values: new object[] { new DateTime(2024, 8, 16, 14, 36, 27, 264, DateTimeKind.Utc).AddTicks(2286), new DateTime(2023, 11, 14, 20, 21, 17, 377, DateTimeKind.Local).AddTicks(1233) });

            migrationBuilder.UpdateData(
                table: "Book",
                keyColumn: "BookId",
                keyValue: 1019,
                columns: new[] { "CreatedDateTime", "PublicationDate" },
                values: new object[] { new DateTime(2024, 8, 16, 14, 36, 27, 264, DateTimeKind.Utc).AddTicks(2416), new DateTime(2024, 5, 10, 3, 31, 42, 648, DateTimeKind.Local).AddTicks(4182) });

            migrationBuilder.UpdateData(
                table: "Book",
                keyColumn: "BookId",
                keyValue: 1020,
                columns: new[] { "CreatedDateTime", "PublicationDate" },
                values: new object[] { new DateTime(2024, 8, 16, 14, 36, 27, 264, DateTimeKind.Utc).AddTicks(2563), new DateTime(2024, 3, 11, 7, 27, 42, 781, DateTimeKind.Local).AddTicks(1657) });

            migrationBuilder.UpdateData(
                table: "Book",
                keyColumn: "BookId",
                keyValue: 1021,
                columns: new[] { "CreatedDateTime", "PublicationDate" },
                values: new object[] { new DateTime(2024, 8, 16, 14, 36, 27, 264, DateTimeKind.Utc).AddTicks(2671), new DateTime(2024, 4, 15, 19, 37, 49, 466, DateTimeKind.Local).AddTicks(5038) });

            migrationBuilder.UpdateData(
                table: "Book",
                keyColumn: "BookId",
                keyValue: 1022,
                columns: new[] { "CreatedDateTime", "PublicationDate" },
                values: new object[] { new DateTime(2024, 8, 16, 14, 36, 27, 264, DateTimeKind.Utc).AddTicks(2817), new DateTime(2024, 2, 7, 16, 2, 35, 778, DateTimeKind.Local).AddTicks(348) });

            migrationBuilder.UpdateData(
                table: "Book",
                keyColumn: "BookId",
                keyValue: 1023,
                columns: new[] { "CreatedDateTime", "PublicationDate" },
                values: new object[] { new DateTime(2024, 8, 16, 14, 36, 27, 264, DateTimeKind.Utc).AddTicks(2935), new DateTime(2023, 12, 18, 4, 26, 1, 51, DateTimeKind.Local).AddTicks(5575) });

            migrationBuilder.UpdateData(
                table: "Book",
                keyColumn: "BookId",
                keyValue: 1024,
                columns: new[] { "CreatedDateTime", "PublicationDate" },
                values: new object[] { new DateTime(2024, 8, 16, 14, 36, 27, 264, DateTimeKind.Utc).AddTicks(3074), new DateTime(2023, 8, 27, 21, 25, 43, 541, DateTimeKind.Local).AddTicks(6681) });

            migrationBuilder.UpdateData(
                table: "Book",
                keyColumn: "BookId",
                keyValue: 1025,
                columns: new[] { "CreatedDateTime", "PublicationDate" },
                values: new object[] { new DateTime(2024, 8, 16, 14, 36, 27, 264, DateTimeKind.Utc).AddTicks(3193), new DateTime(2023, 10, 30, 15, 11, 36, 765, DateTimeKind.Local).AddTicks(7378) });

            migrationBuilder.UpdateData(
                table: "Book",
                keyColumn: "BookId",
                keyValue: 1026,
                columns: new[] { "CreatedDateTime", "PublicationDate" },
                values: new object[] { new DateTime(2024, 8, 16, 14, 36, 27, 264, DateTimeKind.Utc).AddTicks(3337), new DateTime(2023, 9, 24, 23, 51, 39, 53, DateTimeKind.Local).AddTicks(76) });

            migrationBuilder.UpdateData(
                table: "Book",
                keyColumn: "BookId",
                keyValue: 1027,
                columns: new[] { "CreatedDateTime", "PublicationDate" },
                values: new object[] { new DateTime(2024, 8, 16, 14, 36, 27, 264, DateTimeKind.Utc).AddTicks(3439), new DateTime(2023, 8, 25, 11, 1, 33, 843, DateTimeKind.Local).AddTicks(1493) });

            migrationBuilder.UpdateData(
                table: "Book",
                keyColumn: "BookId",
                keyValue: 1028,
                columns: new[] { "CreatedDateTime", "PublicationDate" },
                values: new object[] { new DateTime(2024, 8, 16, 14, 36, 27, 264, DateTimeKind.Utc).AddTicks(3587), new DateTime(2023, 12, 12, 23, 45, 9, 126, DateTimeKind.Local).AddTicks(799) });

            migrationBuilder.UpdateData(
                table: "Book",
                keyColumn: "BookId",
                keyValue: 1029,
                columns: new[] { "CreatedDateTime", "PublicationDate" },
                values: new object[] { new DateTime(2024, 8, 16, 14, 36, 27, 264, DateTimeKind.Utc).AddTicks(3702), new DateTime(2024, 4, 17, 14, 52, 38, 763, DateTimeKind.Local).AddTicks(9141) });

            migrationBuilder.UpdateData(
                table: "Book",
                keyColumn: "BookId",
                keyValue: 1030,
                columns: new[] { "CreatedDateTime", "PublicationDate" },
                values: new object[] { new DateTime(2024, 8, 16, 14, 36, 27, 264, DateTimeKind.Utc).AddTicks(3845), new DateTime(2024, 8, 10, 6, 38, 37, 920, DateTimeKind.Local).AddTicks(6638) });

            migrationBuilder.UpdateData(
                table: "Book",
                keyColumn: "BookId",
                keyValue: 1031,
                columns: new[] { "CreatedDateTime", "PublicationDate" },
                values: new object[] { new DateTime(2024, 8, 16, 14, 36, 27, 264, DateTimeKind.Utc).AddTicks(3979), new DateTime(2024, 8, 16, 7, 20, 17, 162, DateTimeKind.Local).AddTicks(8831) });

            migrationBuilder.UpdateData(
                table: "Book",
                keyColumn: "BookId",
                keyValue: 1032,
                columns: new[] { "CreatedDateTime", "PublicationDate" },
                values: new object[] { new DateTime(2024, 8, 16, 14, 36, 27, 264, DateTimeKind.Utc).AddTicks(4085), new DateTime(2023, 11, 16, 3, 49, 28, 760, DateTimeKind.Local).AddTicks(6866) });

            migrationBuilder.UpdateData(
                table: "Book",
                keyColumn: "BookId",
                keyValue: 1033,
                columns: new[] { "CreatedDateTime", "PublicationDate" },
                values: new object[] { new DateTime(2024, 8, 16, 14, 36, 27, 264, DateTimeKind.Utc).AddTicks(4231), new DateTime(2023, 8, 25, 12, 11, 47, 142, DateTimeKind.Local).AddTicks(2801) });

            migrationBuilder.UpdateData(
                table: "Book",
                keyColumn: "BookId",
                keyValue: 1034,
                columns: new[] { "CreatedDateTime", "PublicationDate" },
                values: new object[] { new DateTime(2024, 8, 16, 14, 36, 27, 264, DateTimeKind.Utc).AddTicks(4339), new DateTime(2024, 6, 29, 4, 12, 6, 11, DateTimeKind.Local).AddTicks(6092) });

            migrationBuilder.UpdateData(
                table: "Book",
                keyColumn: "BookId",
                keyValue: 1035,
                columns: new[] { "CreatedDateTime", "PublicationDate" },
                values: new object[] { new DateTime(2024, 8, 16, 14, 36, 27, 264, DateTimeKind.Utc).AddTicks(4490), new DateTime(2024, 6, 16, 11, 7, 57, 616, DateTimeKind.Local).AddTicks(1035) });

            migrationBuilder.UpdateData(
                table: "Book",
                keyColumn: "BookId",
                keyValue: 1036,
                columns: new[] { "CreatedDateTime", "PublicationDate" },
                values: new object[] { new DateTime(2024, 8, 16, 14, 36, 27, 264, DateTimeKind.Utc).AddTicks(4594), new DateTime(2023, 9, 23, 15, 44, 25, 385, DateTimeKind.Local).AddTicks(5372) });

            migrationBuilder.UpdateData(
                table: "Book",
                keyColumn: "BookId",
                keyValue: 1037,
                columns: new[] { "CreatedDateTime", "PublicationDate" },
                values: new object[] { new DateTime(2024, 8, 16, 14, 36, 27, 264, DateTimeKind.Utc).AddTicks(4755), new DateTime(2023, 12, 16, 6, 15, 34, 825, DateTimeKind.Local).AddTicks(4630) });

            migrationBuilder.UpdateData(
                table: "Book",
                keyColumn: "BookId",
                keyValue: 1038,
                columns: new[] { "CreatedDateTime", "PublicationDate" },
                values: new object[] { new DateTime(2024, 8, 16, 14, 36, 27, 264, DateTimeKind.Utc).AddTicks(4931), new DateTime(2023, 10, 30, 3, 30, 44, 970, DateTimeKind.Local).AddTicks(8343) });

            migrationBuilder.UpdateData(
                table: "Book",
                keyColumn: "BookId",
                keyValue: 1039,
                columns: new[] { "CreatedDateTime", "PublicationDate" },
                values: new object[] { new DateTime(2024, 8, 16, 14, 36, 27, 264, DateTimeKind.Utc).AddTicks(5677), new DateTime(2024, 5, 18, 2, 27, 17, 261, DateTimeKind.Local).AddTicks(773) });

            migrationBuilder.UpdateData(
                table: "Book",
                keyColumn: "BookId",
                keyValue: 1040,
                columns: new[] { "CreatedDateTime", "PublicationDate" },
                values: new object[] { new DateTime(2024, 8, 16, 14, 36, 27, 264, DateTimeKind.Utc).AddTicks(6079), new DateTime(2023, 12, 24, 6, 38, 23, 835, DateTimeKind.Local).AddTicks(3536) });

            migrationBuilder.UpdateData(
                table: "Book",
                keyColumn: "BookId",
                keyValue: 1041,
                columns: new[] { "CreatedDateTime", "PublicationDate" },
                values: new object[] { new DateTime(2024, 8, 16, 14, 36, 27, 264, DateTimeKind.Utc).AddTicks(6468), new DateTime(2023, 12, 25, 5, 30, 31, 933, DateTimeKind.Local).AddTicks(9721) });

            migrationBuilder.UpdateData(
                table: "Book",
                keyColumn: "BookId",
                keyValue: 1042,
                columns: new[] { "CreatedDateTime", "PublicationDate" },
                values: new object[] { new DateTime(2024, 8, 16, 14, 36, 27, 264, DateTimeKind.Utc).AddTicks(6856), new DateTime(2024, 2, 21, 8, 23, 7, 282, DateTimeKind.Local).AddTicks(1416) });

            migrationBuilder.UpdateData(
                table: "Book",
                keyColumn: "BookId",
                keyValue: 1043,
                columns: new[] { "CreatedDateTime", "PublicationDate" },
                values: new object[] { new DateTime(2024, 8, 16, 14, 36, 27, 264, DateTimeKind.Utc).AddTicks(7075), new DateTime(2024, 3, 28, 0, 12, 49, 410, DateTimeKind.Local).AddTicks(854) });

            migrationBuilder.UpdateData(
                table: "Book",
                keyColumn: "BookId",
                keyValue: 1044,
                columns: new[] { "CreatedDateTime", "PublicationDate" },
                values: new object[] { new DateTime(2024, 8, 16, 14, 36, 27, 264, DateTimeKind.Utc).AddTicks(7550), new DateTime(2024, 2, 25, 20, 45, 11, 965, DateTimeKind.Local).AddTicks(8878) });

            migrationBuilder.UpdateData(
                table: "Book",
                keyColumn: "BookId",
                keyValue: 1045,
                columns: new[] { "CreatedDateTime", "PublicationDate" },
                values: new object[] { new DateTime(2024, 8, 16, 14, 36, 27, 264, DateTimeKind.Utc).AddTicks(8208), new DateTime(2023, 10, 28, 13, 34, 46, 907, DateTimeKind.Local).AddTicks(6716) });

            migrationBuilder.UpdateData(
                table: "Book",
                keyColumn: "BookId",
                keyValue: 1046,
                columns: new[] { "CreatedDateTime", "PublicationDate" },
                values: new object[] { new DateTime(2024, 8, 16, 14, 36, 27, 264, DateTimeKind.Utc).AddTicks(8415), new DateTime(2023, 9, 10, 7, 49, 54, 179, DateTimeKind.Local).AddTicks(6060) });

            migrationBuilder.UpdateData(
                table: "Book",
                keyColumn: "BookId",
                keyValue: 1047,
                columns: new[] { "CreatedDateTime", "PublicationDate" },
                values: new object[] { new DateTime(2024, 8, 16, 14, 36, 27, 264, DateTimeKind.Utc).AddTicks(8593), new DateTime(2023, 9, 2, 9, 22, 46, 969, DateTimeKind.Local).AddTicks(297) });

            migrationBuilder.UpdateData(
                table: "Book",
                keyColumn: "BookId",
                keyValue: 1048,
                columns: new[] { "CreatedDateTime", "PublicationDate" },
                values: new object[] { new DateTime(2024, 8, 16, 14, 36, 27, 264, DateTimeKind.Utc).AddTicks(8734), new DateTime(2023, 11, 8, 11, 54, 53, 327, DateTimeKind.Local).AddTicks(7176) });

            migrationBuilder.UpdateData(
                table: "Book",
                keyColumn: "BookId",
                keyValue: 1049,
                columns: new[] { "CreatedDateTime", "PublicationDate" },
                values: new object[] { new DateTime(2024, 8, 16, 14, 36, 27, 264, DateTimeKind.Utc).AddTicks(8915), new DateTime(2023, 9, 8, 18, 47, 30, 242, DateTimeKind.Local).AddTicks(8640) });

            migrationBuilder.UpdateData(
                table: "Book",
                keyColumn: "BookId",
                keyValue: 1050,
                columns: new[] { "CreatedDateTime", "PublicationDate" },
                values: new object[] { new DateTime(2024, 8, 16, 14, 36, 27, 264, DateTimeKind.Utc).AddTicks(9026), new DateTime(2024, 6, 27, 11, 15, 1, 25, DateTimeKind.Local).AddTicks(490) });

            migrationBuilder.UpdateData(
                table: "Book",
                keyColumn: "BookId",
                keyValue: 1051,
                columns: new[] { "CreatedDateTime", "PublicationDate" },
                values: new object[] { new DateTime(2024, 8, 16, 14, 36, 27, 264, DateTimeKind.Utc).AddTicks(9189), new DateTime(2024, 5, 7, 20, 9, 49, 421, DateTimeKind.Local).AddTicks(8174) });

            migrationBuilder.UpdateData(
                table: "Book",
                keyColumn: "BookId",
                keyValue: 1052,
                columns: new[] { "CreatedDateTime", "PublicationDate" },
                values: new object[] { new DateTime(2024, 8, 16, 14, 36, 27, 264, DateTimeKind.Utc).AddTicks(9330), new DateTime(2023, 11, 21, 9, 40, 27, 123, DateTimeKind.Local).AddTicks(8026) });

            migrationBuilder.UpdateData(
                table: "Book",
                keyColumn: "BookId",
                keyValue: 1053,
                columns: new[] { "CreatedDateTime", "PublicationDate" },
                values: new object[] { new DateTime(2024, 8, 16, 14, 36, 27, 264, DateTimeKind.Utc).AddTicks(9455), new DateTime(2024, 3, 14, 19, 28, 2, 590, DateTimeKind.Local).AddTicks(3018) });

            migrationBuilder.UpdateData(
                table: "Book",
                keyColumn: "BookId",
                keyValue: 1054,
                columns: new[] { "CreatedDateTime", "PublicationDate" },
                values: new object[] { new DateTime(2024, 8, 16, 14, 36, 27, 264, DateTimeKind.Utc).AddTicks(9610), new DateTime(2024, 5, 12, 3, 43, 30, 5, DateTimeKind.Local).AddTicks(250) });

            migrationBuilder.UpdateData(
                table: "Book",
                keyColumn: "BookId",
                keyValue: 1055,
                columns: new[] { "CreatedDateTime", "PublicationDate" },
                values: new object[] { new DateTime(2024, 8, 16, 14, 36, 27, 264, DateTimeKind.Utc).AddTicks(9728), new DateTime(2024, 8, 11, 13, 37, 26, 933, DateTimeKind.Local).AddTicks(2637) });

            migrationBuilder.UpdateData(
                table: "Book",
                keyColumn: "BookId",
                keyValue: 1056,
                columns: new[] { "CreatedDateTime", "PublicationDate" },
                values: new object[] { new DateTime(2024, 8, 16, 14, 36, 27, 264, DateTimeKind.Utc).AddTicks(9871), new DateTime(2024, 7, 25, 9, 24, 16, 141, DateTimeKind.Local).AddTicks(298) });

            migrationBuilder.UpdateData(
                table: "Book",
                keyColumn: "BookId",
                keyValue: 1057,
                columns: new[] { "CreatedDateTime", "PublicationDate" },
                values: new object[] { new DateTime(2024, 8, 16, 14, 36, 27, 264, DateTimeKind.Utc).AddTicks(9974), new DateTime(2023, 11, 11, 13, 53, 40, 475, DateTimeKind.Local).AddTicks(619) });

            migrationBuilder.UpdateData(
                table: "Book",
                keyColumn: "BookId",
                keyValue: 1058,
                columns: new[] { "CreatedDateTime", "PublicationDate" },
                values: new object[] { new DateTime(2024, 8, 16, 14, 36, 27, 265, DateTimeKind.Utc).AddTicks(124), new DateTime(2024, 4, 23, 22, 41, 8, 266, DateTimeKind.Local).AddTicks(8963) });

            migrationBuilder.UpdateData(
                table: "Book",
                keyColumn: "BookId",
                keyValue: 1059,
                columns: new[] { "CreatedDateTime", "PublicationDate" },
                values: new object[] { new DateTime(2024, 8, 16, 14, 36, 27, 265, DateTimeKind.Utc).AddTicks(230), new DateTime(2024, 2, 19, 21, 4, 52, 612, DateTimeKind.Local).AddTicks(6991) });

            migrationBuilder.UpdateData(
                table: "Book",
                keyColumn: "BookId",
                keyValue: 1060,
                columns: new[] { "CreatedDateTime", "PublicationDate" },
                values: new object[] { new DateTime(2024, 8, 16, 14, 36, 27, 265, DateTimeKind.Utc).AddTicks(375), new DateTime(2024, 4, 28, 2, 54, 17, 550, DateTimeKind.Local).AddTicks(7054) });

            migrationBuilder.UpdateData(
                table: "Book",
                keyColumn: "BookId",
                keyValue: 1061,
                columns: new[] { "CreatedDateTime", "PublicationDate" },
                values: new object[] { new DateTime(2024, 8, 16, 14, 36, 27, 265, DateTimeKind.Utc).AddTicks(489), new DateTime(2024, 5, 1, 18, 15, 13, 724, DateTimeKind.Local).AddTicks(559) });

            migrationBuilder.UpdateData(
                table: "Book",
                keyColumn: "BookId",
                keyValue: 1062,
                columns: new[] { "CreatedDateTime", "PublicationDate" },
                values: new object[] { new DateTime(2024, 8, 16, 14, 36, 27, 265, DateTimeKind.Utc).AddTicks(626), new DateTime(2023, 8, 25, 9, 21, 34, 171, DateTimeKind.Local).AddTicks(1541) });

            migrationBuilder.UpdateData(
                table: "Book",
                keyColumn: "BookId",
                keyValue: 1063,
                columns: new[] { "CreatedDateTime", "PublicationDate" },
                values: new object[] { new DateTime(2024, 8, 16, 14, 36, 27, 265, DateTimeKind.Utc).AddTicks(738), new DateTime(2024, 1, 14, 10, 34, 12, 978, DateTimeKind.Local).AddTicks(5092) });

            migrationBuilder.UpdateData(
                table: "Book",
                keyColumn: "BookId",
                keyValue: 1064,
                columns: new[] { "CreatedDateTime", "PublicationDate" },
                values: new object[] { new DateTime(2024, 8, 16, 14, 36, 27, 265, DateTimeKind.Utc).AddTicks(909), new DateTime(2023, 10, 12, 11, 40, 14, 826, DateTimeKind.Local).AddTicks(3580) });

            migrationBuilder.UpdateData(
                table: "Book",
                keyColumn: "BookId",
                keyValue: 1065,
                columns: new[] { "CreatedDateTime", "PublicationDate" },
                values: new object[] { new DateTime(2024, 8, 16, 14, 36, 27, 265, DateTimeKind.Utc).AddTicks(1041), new DateTime(2024, 5, 28, 1, 8, 46, 385, DateTimeKind.Local).AddTicks(1169) });

            migrationBuilder.UpdateData(
                table: "Book",
                keyColumn: "BookId",
                keyValue: 1066,
                columns: new[] { "CreatedDateTime", "PublicationDate" },
                values: new object[] { new DateTime(2024, 8, 16, 14, 36, 27, 265, DateTimeKind.Utc).AddTicks(1231), new DateTime(2023, 10, 14, 17, 7, 11, 873, DateTimeKind.Local).AddTicks(5652) });

            migrationBuilder.UpdateData(
                table: "Book",
                keyColumn: "BookId",
                keyValue: 1067,
                columns: new[] { "CreatedDateTime", "PublicationDate" },
                values: new object[] { new DateTime(2024, 8, 16, 14, 36, 27, 265, DateTimeKind.Utc).AddTicks(1363), new DateTime(2023, 10, 13, 5, 6, 45, 124, DateTimeKind.Local).AddTicks(8438) });

            migrationBuilder.UpdateData(
                table: "Book",
                keyColumn: "BookId",
                keyValue: 1068,
                columns: new[] { "CreatedDateTime", "PublicationDate" },
                values: new object[] { new DateTime(2024, 8, 16, 14, 36, 27, 265, DateTimeKind.Utc).AddTicks(1523), new DateTime(2024, 6, 10, 15, 12, 19, 182, DateTimeKind.Local).AddTicks(9146) });

            migrationBuilder.UpdateData(
                table: "Book",
                keyColumn: "BookId",
                keyValue: 1069,
                columns: new[] { "CreatedDateTime", "PublicationDate" },
                values: new object[] { new DateTime(2024, 8, 16, 14, 36, 27, 265, DateTimeKind.Utc).AddTicks(1648), new DateTime(2024, 1, 30, 0, 7, 52, 786, DateTimeKind.Local).AddTicks(3627) });

            migrationBuilder.UpdateData(
                table: "Book",
                keyColumn: "BookId",
                keyValue: 1070,
                columns: new[] { "CreatedDateTime", "PublicationDate" },
                values: new object[] { new DateTime(2024, 8, 16, 14, 36, 27, 265, DateTimeKind.Utc).AddTicks(1822), new DateTime(2023, 10, 9, 16, 39, 48, 413, DateTimeKind.Local).AddTicks(5794) });

            migrationBuilder.UpdateData(
                table: "Book",
                keyColumn: "BookId",
                keyValue: 1071,
                columns: new[] { "CreatedDateTime", "PublicationDate" },
                values: new object[] { new DateTime(2024, 8, 16, 14, 36, 27, 265, DateTimeKind.Utc).AddTicks(1963), new DateTime(2024, 2, 28, 12, 47, 10, 76, DateTimeKind.Local).AddTicks(8262) });

            migrationBuilder.UpdateData(
                table: "Book",
                keyColumn: "BookId",
                keyValue: 1072,
                columns: new[] { "CreatedDateTime", "PublicationDate" },
                values: new object[] { new DateTime(2024, 8, 16, 14, 36, 27, 265, DateTimeKind.Utc).AddTicks(2109), new DateTime(2024, 3, 21, 5, 33, 53, 240, DateTimeKind.Local).AddTicks(2435) });

            migrationBuilder.UpdateData(
                table: "Book",
                keyColumn: "BookId",
                keyValue: 1073,
                columns: new[] { "CreatedDateTime", "PublicationDate" },
                values: new object[] { new DateTime(2024, 8, 16, 14, 36, 27, 265, DateTimeKind.Utc).AddTicks(2244), new DateTime(2023, 10, 4, 5, 27, 13, 98, DateTimeKind.Local).AddTicks(3506) });

            migrationBuilder.UpdateData(
                table: "Book",
                keyColumn: "BookId",
                keyValue: 1074,
                columns: new[] { "CreatedDateTime", "PublicationDate" },
                values: new object[] { new DateTime(2024, 8, 16, 14, 36, 27, 265, DateTimeKind.Utc).AddTicks(2343), new DateTime(2023, 11, 29, 10, 5, 59, 143, DateTimeKind.Local).AddTicks(2321) });

            migrationBuilder.UpdateData(
                table: "Book",
                keyColumn: "BookId",
                keyValue: 1075,
                columns: new[] { "CreatedDateTime", "PublicationDate" },
                values: new object[] { new DateTime(2024, 8, 16, 14, 36, 27, 265, DateTimeKind.Utc).AddTicks(2479), new DateTime(2024, 5, 7, 22, 15, 55, 972, DateTimeKind.Local).AddTicks(7793) });

            migrationBuilder.UpdateData(
                table: "Book",
                keyColumn: "BookId",
                keyValue: 1076,
                columns: new[] { "CreatedDateTime", "PublicationDate" },
                values: new object[] { new DateTime(2024, 8, 16, 14, 36, 27, 265, DateTimeKind.Utc).AddTicks(2588), new DateTime(2024, 8, 11, 3, 9, 33, 861, DateTimeKind.Local).AddTicks(8282) });

            migrationBuilder.UpdateData(
                table: "Book",
                keyColumn: "BookId",
                keyValue: 1077,
                columns: new[] { "CreatedDateTime", "PublicationDate" },
                values: new object[] { new DateTime(2024, 8, 16, 14, 36, 27, 265, DateTimeKind.Utc).AddTicks(2693), new DateTime(2024, 3, 17, 8, 16, 32, 843, DateTimeKind.Local).AddTicks(2948) });

            migrationBuilder.UpdateData(
                table: "Book",
                keyColumn: "BookId",
                keyValue: 1078,
                columns: new[] { "CreatedDateTime", "PublicationDate" },
                values: new object[] { new DateTime(2024, 8, 16, 14, 36, 27, 265, DateTimeKind.Utc).AddTicks(2812), new DateTime(2024, 1, 15, 6, 10, 29, 205, DateTimeKind.Local).AddTicks(7110) });

            migrationBuilder.UpdateData(
                table: "Book",
                keyColumn: "BookId",
                keyValue: 1079,
                columns: new[] { "CreatedDateTime", "PublicationDate" },
                values: new object[] { new DateTime(2024, 8, 16, 14, 36, 27, 265, DateTimeKind.Utc).AddTicks(2910), new DateTime(2023, 12, 14, 21, 16, 24, 719, DateTimeKind.Local).AddTicks(8157) });

            migrationBuilder.UpdateData(
                table: "Book",
                keyColumn: "BookId",
                keyValue: 1080,
                columns: new[] { "CreatedDateTime", "PublicationDate" },
                values: new object[] { new DateTime(2024, 8, 16, 14, 36, 27, 265, DateTimeKind.Utc).AddTicks(3062), new DateTime(2024, 7, 25, 22, 19, 35, 70, DateTimeKind.Local).AddTicks(7029) });

            migrationBuilder.UpdateData(
                table: "Book",
                keyColumn: "BookId",
                keyValue: 1081,
                columns: new[] { "CreatedDateTime", "PublicationDate" },
                values: new object[] { new DateTime(2024, 8, 16, 14, 36, 27, 265, DateTimeKind.Utc).AddTicks(3163), new DateTime(2024, 1, 25, 8, 55, 14, 383, DateTimeKind.Local).AddTicks(1344) });

            migrationBuilder.UpdateData(
                table: "Book",
                keyColumn: "BookId",
                keyValue: 1082,
                columns: new[] { "CreatedDateTime", "PublicationDate" },
                values: new object[] { new DateTime(2024, 8, 16, 14, 36, 27, 265, DateTimeKind.Utc).AddTicks(3605), new DateTime(2024, 2, 16, 4, 43, 56, 52, DateTimeKind.Local).AddTicks(9591) });

            migrationBuilder.UpdateData(
                table: "Book",
                keyColumn: "BookId",
                keyValue: 1083,
                columns: new[] { "CreatedDateTime", "PublicationDate" },
                values: new object[] { new DateTime(2024, 8, 16, 14, 36, 27, 265, DateTimeKind.Utc).AddTicks(3854), new DateTime(2024, 7, 22, 16, 43, 13, 552, DateTimeKind.Local).AddTicks(6284) });

            migrationBuilder.UpdateData(
                table: "Book",
                keyColumn: "BookId",
                keyValue: 1084,
                columns: new[] { "CreatedDateTime", "PublicationDate" },
                values: new object[] { new DateTime(2024, 8, 16, 14, 36, 27, 265, DateTimeKind.Utc).AddTicks(4391), new DateTime(2024, 3, 8, 21, 25, 22, 975, DateTimeKind.Local).AddTicks(3104) });

            migrationBuilder.UpdateData(
                table: "Book",
                keyColumn: "BookId",
                keyValue: 1085,
                columns: new[] { "CreatedDateTime", "PublicationDate" },
                values: new object[] { new DateTime(2024, 8, 16, 14, 36, 27, 265, DateTimeKind.Utc).AddTicks(4652), new DateTime(2023, 10, 21, 12, 42, 17, 346, DateTimeKind.Local).AddTicks(4470) });

            migrationBuilder.UpdateData(
                table: "Book",
                keyColumn: "BookId",
                keyValue: 1086,
                columns: new[] { "CreatedDateTime", "PublicationDate" },
                values: new object[] { new DateTime(2024, 8, 16, 14, 36, 27, 265, DateTimeKind.Utc).AddTicks(4930), new DateTime(2024, 4, 24, 10, 24, 5, 330, DateTimeKind.Local).AddTicks(8471) });

            migrationBuilder.UpdateData(
                table: "Book",
                keyColumn: "BookId",
                keyValue: 1087,
                columns: new[] { "CreatedDateTime", "PublicationDate" },
                values: new object[] { new DateTime(2024, 8, 16, 14, 36, 27, 265, DateTimeKind.Utc).AddTicks(5112), new DateTime(2024, 1, 31, 4, 59, 12, 432, DateTimeKind.Local).AddTicks(8518) });

            migrationBuilder.UpdateData(
                table: "Book",
                keyColumn: "BookId",
                keyValue: 1088,
                columns: new[] { "CreatedDateTime", "PublicationDate" },
                values: new object[] { new DateTime(2024, 8, 16, 14, 36, 27, 265, DateTimeKind.Utc).AddTicks(5363), new DateTime(2024, 6, 10, 22, 6, 55, 32, DateTimeKind.Local).AddTicks(4532) });

            migrationBuilder.UpdateData(
                table: "Book",
                keyColumn: "BookId",
                keyValue: 1089,
                columns: new[] { "CreatedDateTime", "PublicationDate" },
                values: new object[] { new DateTime(2024, 8, 16, 14, 36, 27, 265, DateTimeKind.Utc).AddTicks(5527), new DateTime(2024, 1, 29, 6, 55, 12, 658, DateTimeKind.Local).AddTicks(1069) });

            migrationBuilder.UpdateData(
                table: "Book",
                keyColumn: "BookId",
                keyValue: 1090,
                columns: new[] { "CreatedDateTime", "PublicationDate" },
                values: new object[] { new DateTime(2024, 8, 16, 14, 36, 27, 265, DateTimeKind.Utc).AddTicks(5754), new DateTime(2024, 8, 2, 6, 48, 45, 257, DateTimeKind.Local).AddTicks(2113) });

            migrationBuilder.UpdateData(
                table: "Book",
                keyColumn: "BookId",
                keyValue: 1091,
                columns: new[] { "CreatedDateTime", "PublicationDate" },
                values: new object[] { new DateTime(2024, 8, 16, 14, 36, 27, 265, DateTimeKind.Utc).AddTicks(5963), new DateTime(2023, 10, 20, 14, 12, 45, 833, DateTimeKind.Local).AddTicks(5214) });

            migrationBuilder.UpdateData(
                table: "Book",
                keyColumn: "BookId",
                keyValue: 1092,
                columns: new[] { "CreatedDateTime", "PublicationDate" },
                values: new object[] { new DateTime(2024, 8, 16, 14, 36, 27, 265, DateTimeKind.Utc).AddTicks(6132), new DateTime(2023, 12, 23, 16, 20, 21, 705, DateTimeKind.Local).AddTicks(9193) });

            migrationBuilder.UpdateData(
                table: "Book",
                keyColumn: "BookId",
                keyValue: 1093,
                columns: new[] { "CreatedDateTime", "PublicationDate" },
                values: new object[] { new DateTime(2024, 8, 16, 14, 36, 27, 265, DateTimeKind.Utc).AddTicks(6328), new DateTime(2024, 1, 5, 14, 52, 45, 595, DateTimeKind.Local).AddTicks(1158) });

            migrationBuilder.UpdateData(
                table: "Book",
                keyColumn: "BookId",
                keyValue: 1094,
                columns: new[] { "CreatedDateTime", "PublicationDate" },
                values: new object[] { new DateTime(2024, 8, 16, 14, 36, 27, 265, DateTimeKind.Utc).AddTicks(6504), new DateTime(2023, 9, 18, 17, 4, 10, 268, DateTimeKind.Local).AddTicks(4052) });

            migrationBuilder.UpdateData(
                table: "Book",
                keyColumn: "BookId",
                keyValue: 1095,
                columns: new[] { "CreatedDateTime", "PublicationDate" },
                values: new object[] { new DateTime(2024, 8, 16, 14, 36, 27, 265, DateTimeKind.Utc).AddTicks(6700), new DateTime(2024, 5, 20, 1, 25, 54, 129, DateTimeKind.Local).AddTicks(1285) });

            migrationBuilder.UpdateData(
                table: "Book",
                keyColumn: "BookId",
                keyValue: 1096,
                columns: new[] { "CreatedDateTime", "PublicationDate" },
                values: new object[] { new DateTime(2024, 8, 16, 14, 36, 27, 265, DateTimeKind.Utc).AddTicks(6852), new DateTime(2023, 11, 28, 11, 17, 8, 55, DateTimeKind.Local).AddTicks(2774) });

            migrationBuilder.UpdateData(
                table: "Book",
                keyColumn: "BookId",
                keyValue: 1097,
                columns: new[] { "CreatedDateTime", "PublicationDate" },
                values: new object[] { new DateTime(2024, 8, 16, 14, 36, 27, 265, DateTimeKind.Utc).AddTicks(7025), new DateTime(2024, 5, 31, 19, 1, 36, 756, DateTimeKind.Local).AddTicks(3269) });

            migrationBuilder.UpdateData(
                table: "Book",
                keyColumn: "BookId",
                keyValue: 1098,
                columns: new[] { "CreatedDateTime", "PublicationDate" },
                values: new object[] { new DateTime(2024, 8, 16, 14, 36, 27, 265, DateTimeKind.Utc).AddTicks(7175), new DateTime(2023, 11, 30, 3, 36, 30, 451, DateTimeKind.Local).AddTicks(5987) });

            migrationBuilder.UpdateData(
                table: "Book",
                keyColumn: "BookId",
                keyValue: 1099,
                columns: new[] { "CreatedDateTime", "PublicationDate" },
                values: new object[] { new DateTime(2024, 8, 16, 14, 36, 27, 265, DateTimeKind.Utc).AddTicks(7398), new DateTime(2024, 5, 29, 1, 1, 24, 262, DateTimeKind.Local).AddTicks(8211) });

            migrationBuilder.UpdateData(
                table: "Book",
                keyColumn: "BookId",
                keyValue: 1100,
                columns: new[] { "CreatedDateTime", "PublicationDate" },
                values: new object[] { new DateTime(2024, 8, 16, 14, 36, 27, 265, DateTimeKind.Utc).AddTicks(7569), new DateTime(2024, 5, 17, 17, 43, 17, 686, DateTimeKind.Local).AddTicks(7216) });

            migrationBuilder.UpdateData(
                table: "Book",
                keyColumn: "BookId",
                keyValue: 1101,
                columns: new[] { "CreatedDateTime", "PublicationDate" },
                values: new object[] { new DateTime(2024, 8, 16, 14, 36, 27, 265, DateTimeKind.Utc).AddTicks(7786), new DateTime(2024, 1, 18, 16, 28, 34, 192, DateTimeKind.Local).AddTicks(8884) });

            migrationBuilder.UpdateData(
                table: "Book",
                keyColumn: "BookId",
                keyValue: 1102,
                columns: new[] { "CreatedDateTime", "PublicationDate" },
                values: new object[] { new DateTime(2024, 8, 16, 14, 36, 27, 265, DateTimeKind.Utc).AddTicks(7940), new DateTime(2024, 2, 20, 17, 55, 24, 665, DateTimeKind.Local).AddTicks(6752) });

            migrationBuilder.UpdateData(
                table: "Book",
                keyColumn: "BookId",
                keyValue: 1103,
                columns: new[] { "CreatedDateTime", "PublicationDate" },
                values: new object[] { new DateTime(2024, 8, 16, 14, 36, 27, 265, DateTimeKind.Utc).AddTicks(8142), new DateTime(2024, 3, 9, 16, 52, 35, 57, DateTimeKind.Local).AddTicks(6523) });

            migrationBuilder.UpdateData(
                table: "Book",
                keyColumn: "BookId",
                keyValue: 1104,
                columns: new[] { "CreatedDateTime", "PublicationDate" },
                values: new object[] { new DateTime(2024, 8, 16, 14, 36, 27, 265, DateTimeKind.Utc).AddTicks(8320), new DateTime(2023, 12, 8, 22, 43, 29, 74, DateTimeKind.Local).AddTicks(4022) });

            migrationBuilder.UpdateData(
                table: "Book",
                keyColumn: "BookId",
                keyValue: 1105,
                columns: new[] { "CreatedDateTime", "PublicationDate" },
                values: new object[] { new DateTime(2024, 8, 16, 14, 36, 27, 265, DateTimeKind.Utc).AddTicks(8508), new DateTime(2024, 2, 10, 1, 6, 43, 4, DateTimeKind.Local).AddTicks(307) });

            migrationBuilder.UpdateData(
                table: "Book",
                keyColumn: "BookId",
                keyValue: 1106,
                columns: new[] { "CreatedDateTime", "PublicationDate" },
                values: new object[] { new DateTime(2024, 8, 16, 14, 36, 27, 265, DateTimeKind.Utc).AddTicks(8669), new DateTime(2024, 3, 10, 6, 12, 2, 149, DateTimeKind.Local).AddTicks(3933) });

            migrationBuilder.UpdateData(
                table: "Book",
                keyColumn: "BookId",
                keyValue: 1107,
                columns: new[] { "CreatedDateTime", "PublicationDate" },
                values: new object[] { new DateTime(2024, 8, 16, 14, 36, 27, 265, DateTimeKind.Utc).AddTicks(8858), new DateTime(2024, 7, 6, 10, 30, 57, 65, DateTimeKind.Local).AddTicks(1154) });

            migrationBuilder.UpdateData(
                table: "Book",
                keyColumn: "BookId",
                keyValue: 1108,
                columns: new[] { "CreatedDateTime", "PublicationDate" },
                values: new object[] { new DateTime(2024, 8, 16, 14, 36, 27, 265, DateTimeKind.Utc).AddTicks(9064), new DateTime(2024, 5, 13, 23, 57, 40, 815, DateTimeKind.Local).AddTicks(1655) });

            migrationBuilder.UpdateData(
                table: "Book",
                keyColumn: "BookId",
                keyValue: 1109,
                columns: new[] { "CreatedDateTime", "PublicationDate" },
                values: new object[] { new DateTime(2024, 8, 16, 14, 36, 27, 265, DateTimeKind.Utc).AddTicks(9226), new DateTime(2024, 5, 10, 6, 1, 9, 373, DateTimeKind.Local).AddTicks(2233) });

            migrationBuilder.UpdateData(
                table: "Book",
                keyColumn: "BookId",
                keyValue: 1110,
                columns: new[] { "CreatedDateTime", "PublicationDate" },
                values: new object[] { new DateTime(2024, 8, 16, 14, 36, 27, 265, DateTimeKind.Utc).AddTicks(9418), new DateTime(2023, 8, 22, 0, 4, 39, 473, DateTimeKind.Local).AddTicks(2379) });

            migrationBuilder.UpdateData(
                table: "Book",
                keyColumn: "BookId",
                keyValue: 1111,
                columns: new[] { "CreatedDateTime", "PublicationDate" },
                values: new object[] { new DateTime(2024, 8, 16, 14, 36, 27, 265, DateTimeKind.Utc).AddTicks(9557), new DateTime(2024, 7, 28, 22, 5, 9, 988, DateTimeKind.Local).AddTicks(1806) });

            migrationBuilder.UpdateData(
                table: "Book",
                keyColumn: "BookId",
                keyValue: 1112,
                columns: new[] { "CreatedDateTime", "PublicationDate" },
                values: new object[] { new DateTime(2024, 8, 16, 14, 36, 27, 265, DateTimeKind.Utc).AddTicks(9756), new DateTime(2024, 2, 14, 0, 13, 33, 945, DateTimeKind.Local).AddTicks(3705) });

            migrationBuilder.UpdateData(
                table: "Book",
                keyColumn: "BookId",
                keyValue: 1113,
                columns: new[] { "CreatedDateTime", "PublicationDate" },
                values: new object[] { new DateTime(2024, 8, 16, 14, 36, 27, 265, DateTimeKind.Utc).AddTicks(9923), new DateTime(2023, 8, 28, 18, 6, 47, 566, DateTimeKind.Local).AddTicks(528) });

            migrationBuilder.UpdateData(
                table: "Book",
                keyColumn: "BookId",
                keyValue: 1114,
                columns: new[] { "CreatedDateTime", "PublicationDate" },
                values: new object[] { new DateTime(2024, 8, 16, 14, 36, 27, 266, DateTimeKind.Utc).AddTicks(130), new DateTime(2023, 10, 26, 3, 19, 9, 533, DateTimeKind.Local).AddTicks(8943) });

            migrationBuilder.UpdateData(
                table: "Book",
                keyColumn: "BookId",
                keyValue: 1115,
                columns: new[] { "CreatedDateTime", "PublicationDate" },
                values: new object[] { new DateTime(2024, 8, 16, 14, 36, 27, 266, DateTimeKind.Utc).AddTicks(263), new DateTime(2023, 10, 1, 1, 46, 55, 438, DateTimeKind.Local).AddTicks(7190) });

            migrationBuilder.UpdateData(
                table: "Book",
                keyColumn: "BookId",
                keyValue: 1116,
                columns: new[] { "CreatedDateTime", "PublicationDate" },
                values: new object[] { new DateTime(2024, 8, 16, 14, 36, 27, 266, DateTimeKind.Utc).AddTicks(1038), new DateTime(2024, 1, 4, 0, 3, 35, 655, DateTimeKind.Local).AddTicks(4651) });

            migrationBuilder.UpdateData(
                table: "Book",
                keyColumn: "BookId",
                keyValue: 1117,
                columns: new[] { "CreatedDateTime", "PublicationDate" },
                values: new object[] { new DateTime(2024, 8, 16, 14, 36, 27, 266, DateTimeKind.Utc).AddTicks(1916), new DateTime(2024, 3, 5, 17, 53, 55, 59, DateTimeKind.Local).AddTicks(2416) });

            migrationBuilder.UpdateData(
                table: "Book",
                keyColumn: "BookId",
                keyValue: 1118,
                columns: new[] { "CreatedDateTime", "PublicationDate" },
                values: new object[] { new DateTime(2024, 8, 16, 14, 36, 27, 266, DateTimeKind.Utc).AddTicks(2170), new DateTime(2024, 2, 21, 18, 50, 15, 958, DateTimeKind.Local).AddTicks(5217) });

            migrationBuilder.UpdateData(
                table: "Book",
                keyColumn: "BookId",
                keyValue: 1119,
                columns: new[] { "CreatedDateTime", "PublicationDate" },
                values: new object[] { new DateTime(2024, 8, 16, 14, 36, 27, 266, DateTimeKind.Utc).AddTicks(2308), new DateTime(2024, 2, 24, 19, 46, 14, 40, DateTimeKind.Local).AddTicks(3849) });

            migrationBuilder.UpdateData(
                table: "Book",
                keyColumn: "BookId",
                keyValue: 1120,
                columns: new[] { "CreatedDateTime", "PublicationDate" },
                values: new object[] { new DateTime(2024, 8, 16, 14, 36, 27, 266, DateTimeKind.Utc).AddTicks(2465), new DateTime(2024, 1, 26, 14, 43, 44, 295, DateTimeKind.Local).AddTicks(2197) });

            migrationBuilder.UpdateData(
                table: "Book",
                keyColumn: "BookId",
                keyValue: 1121,
                columns: new[] { "CreatedDateTime", "PublicationDate" },
                values: new object[] { new DateTime(2024, 8, 16, 14, 36, 27, 266, DateTimeKind.Utc).AddTicks(2575), new DateTime(2024, 7, 11, 1, 14, 3, 761, DateTimeKind.Local).AddTicks(6530) });

            migrationBuilder.UpdateData(
                table: "Book",
                keyColumn: "BookId",
                keyValue: 1122,
                columns: new[] { "CreatedDateTime", "PublicationDate" },
                values: new object[] { new DateTime(2024, 8, 16, 14, 36, 27, 266, DateTimeKind.Utc).AddTicks(2730), new DateTime(2023, 12, 23, 10, 59, 40, 916, DateTimeKind.Local).AddTicks(2978) });

            migrationBuilder.UpdateData(
                table: "Book",
                keyColumn: "BookId",
                keyValue: 1123,
                columns: new[] { "CreatedDateTime", "PublicationDate" },
                values: new object[] { new DateTime(2024, 8, 16, 14, 36, 27, 266, DateTimeKind.Utc).AddTicks(2866), new DateTime(2023, 9, 13, 12, 18, 48, 15, DateTimeKind.Local).AddTicks(9325) });

            migrationBuilder.UpdateData(
                table: "Book",
                keyColumn: "BookId",
                keyValue: 1124,
                columns: new[] { "CreatedDateTime", "PublicationDate" },
                values: new object[] { new DateTime(2024, 8, 16, 14, 36, 27, 266, DateTimeKind.Utc).AddTicks(2987), new DateTime(2024, 5, 15, 17, 20, 49, 470, DateTimeKind.Local).AddTicks(3913) });

            migrationBuilder.UpdateData(
                table: "Book",
                keyColumn: "BookId",
                keyValue: 1125,
                columns: new[] { "CreatedDateTime", "PublicationDate" },
                values: new object[] { new DateTime(2024, 8, 16, 14, 36, 27, 266, DateTimeKind.Utc).AddTicks(3151), new DateTime(2024, 6, 15, 21, 45, 55, 115, DateTimeKind.Local).AddTicks(1777) });

            migrationBuilder.UpdateData(
                table: "Book",
                keyColumn: "BookId",
                keyValue: 1126,
                columns: new[] { "CreatedDateTime", "PublicationDate" },
                values: new object[] { new DateTime(2024, 8, 16, 14, 36, 27, 266, DateTimeKind.Utc).AddTicks(3271), new DateTime(2024, 7, 14, 1, 15, 0, 425, DateTimeKind.Local).AddTicks(1449) });

            migrationBuilder.UpdateData(
                table: "Book",
                keyColumn: "BookId",
                keyValue: 1127,
                columns: new[] { "CreatedDateTime", "PublicationDate" },
                values: new object[] { new DateTime(2024, 8, 16, 14, 36, 27, 266, DateTimeKind.Utc).AddTicks(3425), new DateTime(2024, 3, 28, 12, 35, 34, 452, DateTimeKind.Local).AddTicks(892) });

            migrationBuilder.UpdateData(
                table: "Book",
                keyColumn: "BookId",
                keyValue: 1128,
                columns: new[] { "CreatedDateTime", "PublicationDate" },
                values: new object[] { new DateTime(2024, 8, 16, 14, 36, 27, 266, DateTimeKind.Utc).AddTicks(3530), new DateTime(2023, 10, 5, 0, 58, 58, 306, DateTimeKind.Local).AddTicks(8317) });

            migrationBuilder.UpdateData(
                table: "Book",
                keyColumn: "BookId",
                keyValue: 1129,
                columns: new[] { "CreatedDateTime", "PublicationDate" },
                values: new object[] { new DateTime(2024, 8, 16, 14, 36, 27, 266, DateTimeKind.Utc).AddTicks(3677), new DateTime(2023, 10, 6, 23, 53, 54, 441, DateTimeKind.Local).AddTicks(1506) });

            migrationBuilder.UpdateData(
                table: "Book",
                keyColumn: "BookId",
                keyValue: 1130,
                columns: new[] { "CreatedDateTime", "PublicationDate" },
                values: new object[] { new DateTime(2024, 8, 16, 14, 36, 27, 266, DateTimeKind.Utc).AddTicks(3776), new DateTime(2024, 2, 5, 5, 50, 51, 124, DateTimeKind.Local).AddTicks(2443) });

            migrationBuilder.UpdateData(
                table: "Book",
                keyColumn: "BookId",
                keyValue: 1131,
                columns: new[] { "CreatedDateTime", "PublicationDate" },
                values: new object[] { new DateTime(2024, 8, 16, 14, 36, 27, 266, DateTimeKind.Utc).AddTicks(3911), new DateTime(2024, 1, 6, 10, 59, 33, 697, DateTimeKind.Local).AddTicks(7848) });

            migrationBuilder.UpdateData(
                table: "Book",
                keyColumn: "BookId",
                keyValue: 1132,
                columns: new[] { "CreatedDateTime", "PublicationDate" },
                values: new object[] { new DateTime(2024, 8, 16, 14, 36, 27, 266, DateTimeKind.Utc).AddTicks(4011), new DateTime(2023, 9, 28, 8, 6, 25, 875, DateTimeKind.Local).AddTicks(2411) });

            migrationBuilder.UpdateData(
                table: "Book",
                keyColumn: "BookId",
                keyValue: 1133,
                columns: new[] { "CreatedDateTime", "PublicationDate" },
                values: new object[] { new DateTime(2024, 8, 16, 14, 36, 27, 266, DateTimeKind.Utc).AddTicks(4158), new DateTime(2024, 3, 3, 3, 42, 58, 583, DateTimeKind.Local).AddTicks(9971) });

            migrationBuilder.UpdateData(
                table: "Book",
                keyColumn: "BookId",
                keyValue: 1134,
                columns: new[] { "CreatedDateTime", "PublicationDate" },
                values: new object[] { new DateTime(2024, 8, 16, 14, 36, 27, 266, DateTimeKind.Utc).AddTicks(4258), new DateTime(2024, 2, 6, 19, 27, 27, 653, DateTimeKind.Local).AddTicks(9298) });

            migrationBuilder.UpdateData(
                table: "Book",
                keyColumn: "BookId",
                keyValue: 1135,
                columns: new[] { "CreatedDateTime", "PublicationDate" },
                values: new object[] { new DateTime(2024, 8, 16, 14, 36, 27, 266, DateTimeKind.Utc).AddTicks(4402), new DateTime(2024, 2, 25, 2, 54, 38, 822, DateTimeKind.Local).AddTicks(6036) });

            migrationBuilder.UpdateData(
                table: "Book",
                keyColumn: "BookId",
                keyValue: 1136,
                columns: new[] { "CreatedDateTime", "PublicationDate" },
                values: new object[] { new DateTime(2024, 8, 16, 14, 36, 27, 266, DateTimeKind.Utc).AddTicks(4538), new DateTime(2024, 5, 31, 21, 24, 28, 856, DateTimeKind.Local).AddTicks(1541) });

            migrationBuilder.UpdateData(
                table: "Book",
                keyColumn: "BookId",
                keyValue: 1137,
                columns: new[] { "CreatedDateTime", "PublicationDate" },
                values: new object[] { new DateTime(2024, 8, 16, 14, 36, 27, 266, DateTimeKind.Utc).AddTicks(4722), new DateTime(2024, 1, 23, 4, 22, 25, 729, DateTimeKind.Local).AddTicks(6198) });

            migrationBuilder.UpdateData(
                table: "Book",
                keyColumn: "BookId",
                keyValue: 1138,
                columns: new[] { "CreatedDateTime", "PublicationDate" },
                values: new object[] { new DateTime(2024, 8, 16, 14, 36, 27, 266, DateTimeKind.Utc).AddTicks(4896), new DateTime(2024, 1, 23, 19, 5, 36, 337, DateTimeKind.Local).AddTicks(3528) });

            migrationBuilder.UpdateData(
                table: "Book",
                keyColumn: "BookId",
                keyValue: 1139,
                columns: new[] { "CreatedDateTime", "PublicationDate" },
                values: new object[] { new DateTime(2024, 8, 16, 14, 36, 27, 266, DateTimeKind.Utc).AddTicks(5099), new DateTime(2024, 1, 1, 14, 58, 55, 314, DateTimeKind.Local).AddTicks(1241) });

            migrationBuilder.UpdateData(
                table: "Book",
                keyColumn: "BookId",
                keyValue: 1140,
                columns: new[] { "CreatedDateTime", "PublicationDate" },
                values: new object[] { new DateTime(2024, 8, 16, 14, 36, 27, 266, DateTimeKind.Utc).AddTicks(5311), new DateTime(2024, 1, 29, 17, 46, 54, 558, DateTimeKind.Local).AddTicks(7745) });

            migrationBuilder.UpdateData(
                table: "Book",
                keyColumn: "BookId",
                keyValue: 1141,
                columns: new[] { "CreatedDateTime", "PublicationDate" },
                values: new object[] { new DateTime(2024, 8, 16, 14, 36, 27, 266, DateTimeKind.Utc).AddTicks(5473), new DateTime(2023, 8, 23, 16, 13, 31, 464, DateTimeKind.Local).AddTicks(1329) });

            migrationBuilder.UpdateData(
                table: "Book",
                keyColumn: "BookId",
                keyValue: 1142,
                columns: new[] { "CreatedDateTime", "PublicationDate" },
                values: new object[] { new DateTime(2024, 8, 16, 14, 36, 27, 266, DateTimeKind.Utc).AddTicks(5664), new DateTime(2024, 4, 13, 2, 41, 39, 166, DateTimeKind.Local).AddTicks(6095) });

            migrationBuilder.UpdateData(
                table: "Book",
                keyColumn: "BookId",
                keyValue: 1143,
                columns: new[] { "CreatedDateTime", "PublicationDate" },
                values: new object[] { new DateTime(2024, 8, 16, 14, 36, 27, 266, DateTimeKind.Utc).AddTicks(5813), new DateTime(2023, 12, 16, 20, 44, 5, 96, DateTimeKind.Local).AddTicks(3014) });

            migrationBuilder.UpdateData(
                table: "Book",
                keyColumn: "BookId",
                keyValue: 1144,
                columns: new[] { "CreatedDateTime", "PublicationDate" },
                values: new object[] { new DateTime(2024, 8, 16, 14, 36, 27, 266, DateTimeKind.Utc).AddTicks(6033), new DateTime(2024, 3, 27, 4, 1, 8, 69, DateTimeKind.Local).AddTicks(8915) });

            migrationBuilder.UpdateData(
                table: "Book",
                keyColumn: "BookId",
                keyValue: 1145,
                columns: new[] { "CreatedDateTime", "PublicationDate" },
                values: new object[] { new DateTime(2024, 8, 16, 14, 36, 27, 266, DateTimeKind.Utc).AddTicks(6194), new DateTime(2024, 6, 1, 18, 22, 37, 776, DateTimeKind.Local).AddTicks(5282) });

            migrationBuilder.UpdateData(
                table: "Book",
                keyColumn: "BookId",
                keyValue: 1146,
                columns: new[] { "CreatedDateTime", "PublicationDate" },
                values: new object[] { new DateTime(2024, 8, 16, 14, 36, 27, 266, DateTimeKind.Utc).AddTicks(6389), new DateTime(2023, 11, 9, 12, 37, 8, 903, DateTimeKind.Local).AddTicks(3754) });

            migrationBuilder.UpdateData(
                table: "Book",
                keyColumn: "BookId",
                keyValue: 1147,
                columns: new[] { "CreatedDateTime", "PublicationDate" },
                values: new object[] { new DateTime(2024, 8, 16, 14, 36, 27, 266, DateTimeKind.Utc).AddTicks(6538), new DateTime(2024, 4, 19, 18, 25, 8, 480, DateTimeKind.Local).AddTicks(1955) });

            migrationBuilder.UpdateData(
                table: "Book",
                keyColumn: "BookId",
                keyValue: 1148,
                columns: new[] { "CreatedDateTime", "PublicationDate" },
                values: new object[] { new DateTime(2024, 8, 16, 14, 36, 27, 266, DateTimeKind.Utc).AddTicks(6740), new DateTime(2024, 4, 1, 21, 11, 56, 149, DateTimeKind.Local).AddTicks(2896) });

            migrationBuilder.UpdateData(
                table: "Book",
                keyColumn: "BookId",
                keyValue: 1149,
                columns: new[] { "CreatedDateTime", "PublicationDate" },
                values: new object[] { new DateTime(2024, 8, 16, 14, 36, 27, 266, DateTimeKind.Utc).AddTicks(6900), new DateTime(2023, 12, 3, 4, 36, 1, 109, DateTimeKind.Local).AddTicks(2425) });

            migrationBuilder.UpdateData(
                table: "Book",
                keyColumn: "BookId",
                keyValue: 1150,
                columns: new[] { "CreatedDateTime", "PublicationDate" },
                values: new object[] { new DateTime(2024, 8, 16, 14, 36, 27, 266, DateTimeKind.Utc).AddTicks(7082), new DateTime(2024, 4, 23, 5, 14, 25, 733, DateTimeKind.Local).AddTicks(4112) });

            migrationBuilder.UpdateData(
                table: "Book",
                keyColumn: "BookId",
                keyValue: 1151,
                columns: new[] { "CreatedDateTime", "PublicationDate" },
                values: new object[] { new DateTime(2024, 8, 16, 14, 36, 27, 266, DateTimeKind.Utc).AddTicks(7238), new DateTime(2024, 4, 16, 21, 21, 51, 555, DateTimeKind.Local).AddTicks(474) });

            migrationBuilder.UpdateData(
                table: "Book",
                keyColumn: "BookId",
                keyValue: 1152,
                columns: new[] { "CreatedDateTime", "PublicationDate" },
                values: new object[] { new DateTime(2024, 8, 16, 14, 36, 27, 266, DateTimeKind.Utc).AddTicks(7454), new DateTime(2024, 1, 2, 3, 47, 10, 816, DateTimeKind.Local).AddTicks(9207) });

            migrationBuilder.UpdateData(
                table: "Book",
                keyColumn: "BookId",
                keyValue: 1153,
                columns: new[] { "CreatedDateTime", "PublicationDate" },
                values: new object[] { new DateTime(2024, 8, 16, 14, 36, 27, 266, DateTimeKind.Utc).AddTicks(7618), new DateTime(2024, 7, 7, 0, 59, 14, 597, DateTimeKind.Local).AddTicks(3195) });

            migrationBuilder.UpdateData(
                table: "Book",
                keyColumn: "BookId",
                keyValue: 1154,
                columns: new[] { "CreatedDateTime", "PublicationDate" },
                values: new object[] { new DateTime(2024, 8, 16, 14, 36, 27, 266, DateTimeKind.Utc).AddTicks(7826), new DateTime(2023, 9, 7, 6, 8, 40, 130, DateTimeKind.Local).AddTicks(8426) });

            migrationBuilder.UpdateData(
                table: "Book",
                keyColumn: "BookId",
                keyValue: 1155,
                columns: new[] { "CreatedDateTime", "PublicationDate" },
                values: new object[] { new DateTime(2024, 8, 16, 14, 36, 27, 266, DateTimeKind.Utc).AddTicks(7985), new DateTime(2024, 1, 29, 23, 0, 12, 426, DateTimeKind.Local).AddTicks(1931) });

            migrationBuilder.UpdateData(
                table: "Book",
                keyColumn: "BookId",
                keyValue: 1156,
                columns: new[] { "CreatedDateTime", "PublicationDate" },
                values: new object[] { new DateTime(2024, 8, 16, 14, 36, 27, 266, DateTimeKind.Utc).AddTicks(8169), new DateTime(2024, 6, 29, 15, 27, 11, 325, DateTimeKind.Local).AddTicks(7498) });

            migrationBuilder.UpdateData(
                table: "Book",
                keyColumn: "BookId",
                keyValue: 1157,
                columns: new[] { "CreatedDateTime", "PublicationDate" },
                values: new object[] { new DateTime(2024, 8, 16, 14, 36, 27, 266, DateTimeKind.Utc).AddTicks(8321), new DateTime(2024, 6, 22, 9, 37, 20, 115, DateTimeKind.Local).AddTicks(3352) });

            migrationBuilder.UpdateData(
                table: "Book",
                keyColumn: "BookId",
                keyValue: 1158,
                columns: new[] { "CreatedDateTime", "PublicationDate" },
                values: new object[] { new DateTime(2024, 8, 16, 14, 36, 27, 266, DateTimeKind.Utc).AddTicks(8510), new DateTime(2024, 8, 6, 20, 25, 1, 55, DateTimeKind.Local).AddTicks(2182) });

            migrationBuilder.UpdateData(
                table: "Book",
                keyColumn: "BookId",
                keyValue: 1159,
                columns: new[] { "CreatedDateTime", "PublicationDate" },
                values: new object[] { new DateTime(2024, 8, 16, 14, 36, 27, 266, DateTimeKind.Utc).AddTicks(8662), new DateTime(2024, 4, 8, 13, 15, 1, 133, DateTimeKind.Local).AddTicks(1262) });

            migrationBuilder.UpdateData(
                table: "Book",
                keyColumn: "BookId",
                keyValue: 1160,
                columns: new[] { "CreatedDateTime", "PublicationDate" },
                values: new object[] { new DateTime(2024, 8, 16, 14, 36, 27, 266, DateTimeKind.Utc).AddTicks(8859), new DateTime(2023, 11, 14, 20, 18, 53, 940, DateTimeKind.Local).AddTicks(3656) });

            migrationBuilder.UpdateData(
                table: "Book",
                keyColumn: "BookId",
                keyValue: 1161,
                columns: new[] { "CreatedDateTime", "PublicationDate" },
                values: new object[] { new DateTime(2024, 8, 16, 14, 36, 27, 266, DateTimeKind.Utc).AddTicks(9002), new DateTime(2023, 10, 6, 13, 45, 48, 805, DateTimeKind.Local).AddTicks(6859) });

            migrationBuilder.UpdateData(
                table: "Book",
                keyColumn: "BookId",
                keyValue: 1162,
                columns: new[] { "CreatedDateTime", "PublicationDate" },
                values: new object[] { new DateTime(2024, 8, 16, 14, 36, 27, 266, DateTimeKind.Utc).AddTicks(9528), new DateTime(2024, 4, 25, 21, 5, 37, 696, DateTimeKind.Local).AddTicks(8275) });

            migrationBuilder.UpdateData(
                table: "Book",
                keyColumn: "BookId",
                keyValue: 1163,
                columns: new[] { "CreatedDateTime", "PublicationDate" },
                values: new object[] { new DateTime(2024, 8, 16, 14, 36, 27, 266, DateTimeKind.Utc).AddTicks(9745), new DateTime(2024, 8, 2, 9, 47, 48, 209, DateTimeKind.Local).AddTicks(6345) });

            migrationBuilder.UpdateData(
                table: "Book",
                keyColumn: "BookId",
                keyValue: 1164,
                columns: new[] { "CreatedDateTime", "PublicationDate" },
                values: new object[] { new DateTime(2024, 8, 16, 14, 36, 27, 266, DateTimeKind.Utc).AddTicks(9902), new DateTime(2023, 9, 1, 20, 14, 1, 138, DateTimeKind.Local).AddTicks(326) });

            migrationBuilder.UpdateData(
                table: "Book",
                keyColumn: "BookId",
                keyValue: 1165,
                columns: new[] { "CreatedDateTime", "PublicationDate" },
                values: new object[] { new DateTime(2024, 8, 16, 14, 36, 27, 267, DateTimeKind.Utc).AddTicks(15), new DateTime(2024, 4, 7, 1, 45, 34, 782, DateTimeKind.Local).AddTicks(3954) });

            migrationBuilder.UpdateData(
                table: "Book",
                keyColumn: "BookId",
                keyValue: 1166,
                columns: new[] { "CreatedDateTime", "PublicationDate" },
                values: new object[] { new DateTime(2024, 8, 16, 14, 36, 27, 267, DateTimeKind.Utc).AddTicks(163), new DateTime(2023, 9, 13, 19, 13, 36, 323, DateTimeKind.Local).AddTicks(4417) });

            migrationBuilder.UpdateData(
                table: "Book",
                keyColumn: "BookId",
                keyValue: 1167,
                columns: new[] { "CreatedDateTime", "PublicationDate" },
                values: new object[] { new DateTime(2024, 8, 16, 14, 36, 27, 267, DateTimeKind.Utc).AddTicks(299), new DateTime(2024, 1, 11, 4, 9, 58, 168, DateTimeKind.Local).AddTicks(263) });

            migrationBuilder.UpdateData(
                table: "Book",
                keyColumn: "BookId",
                keyValue: 1168,
                columns: new[] { "CreatedDateTime", "PublicationDate" },
                values: new object[] { new DateTime(2024, 8, 16, 14, 36, 27, 267, DateTimeKind.Utc).AddTicks(446), new DateTime(2023, 11, 24, 17, 1, 37, 964, DateTimeKind.Local).AddTicks(1) });

            migrationBuilder.UpdateData(
                table: "Book",
                keyColumn: "BookId",
                keyValue: 1169,
                columns: new[] { "CreatedDateTime", "PublicationDate" },
                values: new object[] { new DateTime(2024, 8, 16, 14, 36, 27, 267, DateTimeKind.Utc).AddTicks(600), new DateTime(2024, 5, 12, 14, 17, 35, 762, DateTimeKind.Local).AddTicks(1543) });

            migrationBuilder.UpdateData(
                table: "Book",
                keyColumn: "BookId",
                keyValue: 1170,
                columns: new[] { "CreatedDateTime", "PublicationDate" },
                values: new object[] { new DateTime(2024, 8, 16, 14, 36, 27, 267, DateTimeKind.Utc).AddTicks(709), new DateTime(2024, 6, 6, 15, 11, 29, 628, DateTimeKind.Local).AddTicks(7128) });

            migrationBuilder.UpdateData(
                table: "Book",
                keyColumn: "BookId",
                keyValue: 1171,
                columns: new[] { "CreatedDateTime", "PublicationDate" },
                values: new object[] { new DateTime(2024, 8, 16, 14, 36, 27, 267, DateTimeKind.Utc).AddTicks(835), new DateTime(2023, 11, 16, 14, 4, 39, 725, DateTimeKind.Local).AddTicks(7511) });

            migrationBuilder.UpdateData(
                table: "Book",
                keyColumn: "BookId",
                keyValue: 1172,
                columns: new[] { "CreatedDateTime", "PublicationDate" },
                values: new object[] { new DateTime(2024, 8, 16, 14, 36, 27, 267, DateTimeKind.Utc).AddTicks(944), new DateTime(2023, 10, 4, 20, 27, 44, 214, DateTimeKind.Local).AddTicks(2995) });

            migrationBuilder.UpdateData(
                table: "Book",
                keyColumn: "BookId",
                keyValue: 1173,
                columns: new[] { "CreatedDateTime", "PublicationDate" },
                values: new object[] { new DateTime(2024, 8, 16, 14, 36, 27, 267, DateTimeKind.Utc).AddTicks(1072), new DateTime(2023, 11, 14, 19, 8, 24, 826, DateTimeKind.Local).AddTicks(5288) });

            migrationBuilder.UpdateData(
                table: "Book",
                keyColumn: "BookId",
                keyValue: 1174,
                columns: new[] { "CreatedDateTime", "PublicationDate" },
                values: new object[] { new DateTime(2024, 8, 16, 14, 36, 27, 267, DateTimeKind.Utc).AddTicks(1202), new DateTime(2024, 1, 15, 5, 33, 42, 720, DateTimeKind.Local).AddTicks(3016) });

            migrationBuilder.UpdateData(
                table: "Book",
                keyColumn: "BookId",
                keyValue: 1175,
                columns: new[] { "CreatedDateTime", "PublicationDate" },
                values: new object[] { new DateTime(2024, 8, 16, 14, 36, 27, 267, DateTimeKind.Utc).AddTicks(1341), new DateTime(2024, 6, 14, 9, 29, 37, 52, DateTimeKind.Local).AddTicks(2032) });

            migrationBuilder.UpdateData(
                table: "Book",
                keyColumn: "BookId",
                keyValue: 1176,
                columns: new[] { "CreatedDateTime", "PublicationDate" },
                values: new object[] { new DateTime(2024, 8, 16, 14, 36, 27, 267, DateTimeKind.Utc).AddTicks(1502), new DateTime(2023, 12, 26, 3, 36, 58, 134, DateTimeKind.Local).AddTicks(8711) });

            migrationBuilder.UpdateData(
                table: "Book",
                keyColumn: "BookId",
                keyValue: 1177,
                columns: new[] { "CreatedDateTime", "PublicationDate" },
                values: new object[] { new DateTime(2024, 8, 16, 14, 36, 27, 267, DateTimeKind.Utc).AddTicks(1722), new DateTime(2024, 3, 13, 19, 28, 30, 830, DateTimeKind.Local).AddTicks(7109) });

            migrationBuilder.UpdateData(
                table: "Book",
                keyColumn: "BookId",
                keyValue: 1178,
                columns: new[] { "CreatedDateTime", "PublicationDate" },
                values: new object[] { new DateTime(2024, 8, 16, 14, 36, 27, 267, DateTimeKind.Utc).AddTicks(2535), new DateTime(2024, 6, 19, 19, 52, 42, 357, DateTimeKind.Local).AddTicks(4092) });

            migrationBuilder.UpdateData(
                table: "Book",
                keyColumn: "BookId",
                keyValue: 1179,
                columns: new[] { "CreatedDateTime", "PublicationDate" },
                values: new object[] { new DateTime(2024, 8, 16, 14, 36, 27, 267, DateTimeKind.Utc).AddTicks(2995), new DateTime(2024, 3, 1, 4, 1, 1, 166, DateTimeKind.Local).AddTicks(1864) });

            migrationBuilder.UpdateData(
                table: "Book",
                keyColumn: "BookId",
                keyValue: 1180,
                columns: new[] { "CreatedDateTime", "PublicationDate" },
                values: new object[] { new DateTime(2024, 8, 16, 14, 36, 27, 267, DateTimeKind.Utc).AddTicks(3230), new DateTime(2024, 8, 5, 10, 20, 25, 530, DateTimeKind.Local).AddTicks(3531) });

            migrationBuilder.UpdateData(
                table: "Book",
                keyColumn: "BookId",
                keyValue: 1181,
                columns: new[] { "CreatedDateTime", "PublicationDate" },
                values: new object[] { new DateTime(2024, 8, 16, 14, 36, 27, 267, DateTimeKind.Utc).AddTicks(3737), new DateTime(2024, 1, 21, 2, 3, 44, 84, DateTimeKind.Local).AddTicks(4866) });

            migrationBuilder.UpdateData(
                table: "Book",
                keyColumn: "BookId",
                keyValue: 1182,
                columns: new[] { "CreatedDateTime", "PublicationDate" },
                values: new object[] { new DateTime(2024, 8, 16, 14, 36, 27, 267, DateTimeKind.Utc).AddTicks(3924), new DateTime(2024, 1, 7, 3, 47, 23, 859, DateTimeKind.Local).AddTicks(9059) });

            migrationBuilder.UpdateData(
                table: "Book",
                keyColumn: "BookId",
                keyValue: 1183,
                columns: new[] { "CreatedDateTime", "PublicationDate" },
                values: new object[] { new DateTime(2024, 8, 16, 14, 36, 27, 267, DateTimeKind.Utc).AddTicks(4116), new DateTime(2024, 3, 3, 11, 11, 12, 466, DateTimeKind.Local).AddTicks(6539) });

            migrationBuilder.UpdateData(
                table: "Book",
                keyColumn: "BookId",
                keyValue: 1184,
                columns: new[] { "CreatedDateTime", "PublicationDate" },
                values: new object[] { new DateTime(2024, 8, 16, 14, 36, 27, 267, DateTimeKind.Utc).AddTicks(4253), new DateTime(2024, 8, 16, 7, 56, 30, 889, DateTimeKind.Local).AddTicks(3171) });

            migrationBuilder.UpdateData(
                table: "Book",
                keyColumn: "BookId",
                keyValue: 1185,
                columns: new[] { "CreatedDateTime", "PublicationDate" },
                values: new object[] { new DateTime(2024, 8, 16, 14, 36, 27, 267, DateTimeKind.Utc).AddTicks(4488), new DateTime(2024, 3, 29, 11, 13, 7, 484, DateTimeKind.Local).AddTicks(4564) });

            migrationBuilder.UpdateData(
                table: "Book",
                keyColumn: "BookId",
                keyValue: 1186,
                columns: new[] { "CreatedDateTime", "PublicationDate" },
                values: new object[] { new DateTime(2024, 8, 16, 14, 36, 27, 267, DateTimeKind.Utc).AddTicks(4651), new DateTime(2024, 7, 19, 15, 18, 10, 624, DateTimeKind.Local).AddTicks(6064) });

            migrationBuilder.UpdateData(
                table: "Book",
                keyColumn: "BookId",
                keyValue: 1187,
                columns: new[] { "CreatedDateTime", "PublicationDate" },
                values: new object[] { new DateTime(2024, 8, 16, 14, 36, 27, 267, DateTimeKind.Utc).AddTicks(4835), new DateTime(2023, 8, 21, 4, 18, 55, 512, DateTimeKind.Local).AddTicks(7799) });

            migrationBuilder.UpdateData(
                table: "Book",
                keyColumn: "BookId",
                keyValue: 1188,
                columns: new[] { "CreatedDateTime", "PublicationDate" },
                values: new object[] { new DateTime(2024, 8, 16, 14, 36, 27, 267, DateTimeKind.Utc).AddTicks(4994), new DateTime(2024, 4, 6, 8, 15, 36, 135, DateTimeKind.Local).AddTicks(8010) });

            migrationBuilder.UpdateData(
                table: "Book",
                keyColumn: "BookId",
                keyValue: 1189,
                columns: new[] { "CreatedDateTime", "PublicationDate" },
                values: new object[] { new DateTime(2024, 8, 16, 14, 36, 27, 267, DateTimeKind.Utc).AddTicks(5186), new DateTime(2024, 7, 12, 17, 11, 43, 41, DateTimeKind.Local).AddTicks(3393) });

            migrationBuilder.UpdateData(
                table: "Book",
                keyColumn: "BookId",
                keyValue: 1190,
                columns: new[] { "CreatedDateTime", "PublicationDate" },
                values: new object[] { new DateTime(2024, 8, 16, 14, 36, 27, 267, DateTimeKind.Utc).AddTicks(5368), new DateTime(2024, 3, 29, 7, 59, 44, 721, DateTimeKind.Local).AddTicks(6399) });

            migrationBuilder.UpdateData(
                table: "Book",
                keyColumn: "BookId",
                keyValue: 1191,
                columns: new[] { "CreatedDateTime", "PublicationDate" },
                values: new object[] { new DateTime(2024, 8, 16, 14, 36, 27, 267, DateTimeKind.Utc).AddTicks(5490), new DateTime(2024, 6, 8, 21, 14, 6, 664, DateTimeKind.Local).AddTicks(403) });

            migrationBuilder.UpdateData(
                table: "Book",
                keyColumn: "BookId",
                keyValue: 1192,
                columns: new[] { "CreatedDateTime", "PublicationDate" },
                values: new object[] { new DateTime(2024, 8, 16, 14, 36, 27, 267, DateTimeKind.Utc).AddTicks(5630), new DateTime(2023, 8, 19, 15, 30, 34, 836, DateTimeKind.Local).AddTicks(6738) });

            migrationBuilder.UpdateData(
                table: "Book",
                keyColumn: "BookId",
                keyValue: 1193,
                columns: new[] { "CreatedDateTime", "PublicationDate" },
                values: new object[] { new DateTime(2024, 8, 16, 14, 36, 27, 267, DateTimeKind.Utc).AddTicks(5734), new DateTime(2024, 7, 12, 21, 59, 26, 529, DateTimeKind.Local).AddTicks(4189) });

            migrationBuilder.UpdateData(
                table: "Book",
                keyColumn: "BookId",
                keyValue: 1194,
                columns: new[] { "CreatedDateTime", "PublicationDate" },
                values: new object[] { new DateTime(2024, 8, 16, 14, 36, 27, 267, DateTimeKind.Utc).AddTicks(5884), new DateTime(2023, 8, 25, 21, 43, 25, 69, DateTimeKind.Local).AddTicks(241) });

            migrationBuilder.UpdateData(
                table: "Book",
                keyColumn: "BookId",
                keyValue: 1195,
                columns: new[] { "CreatedDateTime", "PublicationDate" },
                values: new object[] { new DateTime(2024, 8, 16, 14, 36, 27, 267, DateTimeKind.Utc).AddTicks(5994), new DateTime(2024, 2, 2, 18, 5, 47, 664, DateTimeKind.Local).AddTicks(4581) });

            migrationBuilder.UpdateData(
                table: "Book",
                keyColumn: "BookId",
                keyValue: 1196,
                columns: new[] { "CreatedDateTime", "PublicationDate" },
                values: new object[] { new DateTime(2024, 8, 16, 14, 36, 27, 267, DateTimeKind.Utc).AddTicks(6130), new DateTime(2023, 12, 5, 20, 17, 49, 211, DateTimeKind.Local).AddTicks(862) });

            migrationBuilder.UpdateData(
                table: "Book",
                keyColumn: "BookId",
                keyValue: 1197,
                columns: new[] { "CreatedDateTime", "PublicationDate" },
                values: new object[] { new DateTime(2024, 8, 16, 14, 36, 27, 267, DateTimeKind.Utc).AddTicks(6246), new DateTime(2024, 1, 6, 14, 14, 23, 2, DateTimeKind.Local).AddTicks(6720) });

            migrationBuilder.UpdateData(
                table: "Book",
                keyColumn: "BookId",
                keyValue: 1198,
                columns: new[] { "CreatedDateTime", "PublicationDate" },
                values: new object[] { new DateTime(2024, 8, 16, 14, 36, 27, 267, DateTimeKind.Utc).AddTicks(6375), new DateTime(2023, 12, 1, 3, 55, 31, 318, DateTimeKind.Local).AddTicks(98) });

            migrationBuilder.UpdateData(
                table: "Book",
                keyColumn: "BookId",
                keyValue: 1199,
                columns: new[] { "CreatedDateTime", "PublicationDate" },
                values: new object[] { new DateTime(2024, 8, 16, 14, 36, 27, 267, DateTimeKind.Utc).AddTicks(6475), new DateTime(2024, 2, 27, 8, 4, 47, 568, DateTimeKind.Local).AddTicks(9118) });

            migrationBuilder.UpdateData(
                table: "Book",
                keyColumn: "BookId",
                keyValue: 1200,
                columns: new[] { "CreatedDateTime", "PublicationDate" },
                values: new object[] { new DateTime(2024, 8, 16, 14, 36, 27, 267, DateTimeKind.Utc).AddTicks(6605), new DateTime(2024, 8, 8, 14, 0, 44, 472, DateTimeKind.Local).AddTicks(2427) });

            migrationBuilder.UpdateData(
                table: "Book",
                keyColumn: "BookId",
                keyValue: 1201,
                columns: new[] { "CreatedDateTime", "PublicationDate" },
                values: new object[] { new DateTime(2024, 8, 16, 14, 36, 27, 267, DateTimeKind.Utc).AddTicks(6711), new DateTime(2024, 6, 23, 3, 36, 8, 76, DateTimeKind.Local).AddTicks(2788) });

            migrationBuilder.UpdateData(
                table: "Book",
                keyColumn: "BookId",
                keyValue: 1202,
                columns: new[] { "CreatedDateTime", "PublicationDate" },
                values: new object[] { new DateTime(2024, 8, 16, 14, 36, 27, 267, DateTimeKind.Utc).AddTicks(6864), new DateTime(2024, 5, 21, 5, 11, 20, 498, DateTimeKind.Local).AddTicks(547) });

            migrationBuilder.UpdateData(
                table: "Book",
                keyColumn: "BookId",
                keyValue: 1203,
                columns: new[] { "CreatedDateTime", "PublicationDate" },
                values: new object[] { new DateTime(2024, 8, 16, 14, 36, 27, 267, DateTimeKind.Utc).AddTicks(6989), new DateTime(2024, 5, 12, 0, 39, 49, 867, DateTimeKind.Local).AddTicks(1733) });

            migrationBuilder.UpdateData(
                table: "Book",
                keyColumn: "BookId",
                keyValue: 1204,
                columns: new[] { "CreatedDateTime", "PublicationDate" },
                values: new object[] { new DateTime(2024, 8, 16, 14, 36, 27, 267, DateTimeKind.Utc).AddTicks(7151), new DateTime(2024, 3, 21, 19, 21, 27, 606, DateTimeKind.Local).AddTicks(6375) });

            migrationBuilder.UpdateData(
                table: "Book",
                keyColumn: "BookId",
                keyValue: 1205,
                columns: new[] { "CreatedDateTime", "PublicationDate" },
                values: new object[] { new DateTime(2024, 8, 16, 14, 36, 27, 267, DateTimeKind.Utc).AddTicks(7291), new DateTime(2024, 5, 6, 5, 34, 47, 869, DateTimeKind.Local).AddTicks(4711) });

            migrationBuilder.UpdateData(
                table: "Book",
                keyColumn: "BookId",
                keyValue: 1206,
                columns: new[] { "CreatedDateTime", "PublicationDate" },
                values: new object[] { new DateTime(2024, 8, 16, 14, 36, 27, 267, DateTimeKind.Utc).AddTicks(7511), new DateTime(2024, 5, 11, 4, 31, 57, 91, DateTimeKind.Local).AddTicks(6680) });

            migrationBuilder.UpdateData(
                table: "Book",
                keyColumn: "BookId",
                keyValue: 1207,
                columns: new[] { "CreatedDateTime", "PublicationDate" },
                values: new object[] { new DateTime(2024, 8, 16, 14, 36, 27, 267, DateTimeKind.Utc).AddTicks(7659), new DateTime(2023, 12, 17, 3, 1, 12, 933, DateTimeKind.Local).AddTicks(9671) });

            migrationBuilder.UpdateData(
                table: "Book",
                keyColumn: "BookId",
                keyValue: 1208,
                columns: new[] { "CreatedDateTime", "PublicationDate" },
                values: new object[] { new DateTime(2024, 8, 16, 14, 36, 27, 267, DateTimeKind.Utc).AddTicks(7843), new DateTime(2024, 3, 21, 1, 6, 9, 662, DateTimeKind.Local).AddTicks(8324) });

            migrationBuilder.UpdateData(
                table: "Book",
                keyColumn: "BookId",
                keyValue: 1209,
                columns: new[] { "CreatedDateTime", "PublicationDate" },
                values: new object[] { new DateTime(2024, 8, 16, 14, 36, 27, 267, DateTimeKind.Utc).AddTicks(7987), new DateTime(2024, 3, 8, 6, 25, 28, 352, DateTimeKind.Local).AddTicks(9453) });

            migrationBuilder.UpdateData(
                table: "Book",
                keyColumn: "BookId",
                keyValue: 1210,
                columns: new[] { "CreatedDateTime", "PublicationDate" },
                values: new object[] { new DateTime(2024, 8, 16, 14, 36, 27, 267, DateTimeKind.Utc).AddTicks(8154), new DateTime(2023, 8, 21, 9, 44, 13, 198, DateTimeKind.Local).AddTicks(4439) });

            migrationBuilder.UpdateData(
                table: "Book",
                keyColumn: "BookId",
                keyValue: 1211,
                columns: new[] { "CreatedDateTime", "PublicationDate" },
                values: new object[] { new DateTime(2024, 8, 16, 14, 36, 27, 267, DateTimeKind.Utc).AddTicks(8343), new DateTime(2024, 3, 27, 13, 29, 29, 396, DateTimeKind.Local).AddTicks(8531) });

            migrationBuilder.UpdateData(
                table: "Book",
                keyColumn: "BookId",
                keyValue: 1212,
                columns: new[] { "CreatedDateTime", "PublicationDate" },
                values: new object[] { new DateTime(2024, 8, 16, 14, 36, 27, 267, DateTimeKind.Utc).AddTicks(8499), new DateTime(2024, 6, 2, 12, 49, 33, 466, DateTimeKind.Local).AddTicks(5501) });

            migrationBuilder.UpdateData(
                table: "Book",
                keyColumn: "BookId",
                keyValue: 1213,
                columns: new[] { "CreatedDateTime", "PublicationDate" },
                values: new object[] { new DateTime(2024, 8, 16, 14, 36, 27, 267, DateTimeKind.Utc).AddTicks(8685), new DateTime(2023, 8, 16, 22, 0, 7, 38, DateTimeKind.Local).AddTicks(4054) });

            migrationBuilder.UpdateData(
                table: "Book",
                keyColumn: "BookId",
                keyValue: 1214,
                columns: new[] { "CreatedDateTime", "PublicationDate" },
                values: new object[] { new DateTime(2024, 8, 16, 14, 36, 27, 267, DateTimeKind.Utc).AddTicks(8836), new DateTime(2023, 10, 5, 15, 34, 31, 591, DateTimeKind.Local).AddTicks(5805) });

            migrationBuilder.UpdateData(
                table: "Book",
                keyColumn: "BookId",
                keyValue: 1215,
                columns: new[] { "CreatedDateTime", "PublicationDate" },
                values: new object[] { new DateTime(2024, 8, 16, 14, 36, 27, 267, DateTimeKind.Utc).AddTicks(9011), new DateTime(2023, 10, 21, 3, 8, 14, 925, DateTimeKind.Local).AddTicks(6530) });

            migrationBuilder.UpdateData(
                table: "Book",
                keyColumn: "BookId",
                keyValue: 1216,
                columns: new[] { "CreatedDateTime", "PublicationDate" },
                values: new object[] { new DateTime(2024, 8, 16, 14, 36, 27, 267, DateTimeKind.Utc).AddTicks(9144), new DateTime(2024, 7, 4, 3, 51, 31, 674, DateTimeKind.Local).AddTicks(9351) });

            migrationBuilder.UpdateData(
                table: "Book",
                keyColumn: "BookId",
                keyValue: 1217,
                columns: new[] { "CreatedDateTime", "PublicationDate" },
                values: new object[] { new DateTime(2024, 8, 16, 14, 36, 27, 267, DateTimeKind.Utc).AddTicks(9330), new DateTime(2023, 12, 8, 9, 12, 32, 471, DateTimeKind.Local).AddTicks(3504) });

            migrationBuilder.UpdateData(
                table: "Book",
                keyColumn: "BookId",
                keyValue: 1218,
                columns: new[] { "CreatedDateTime", "PublicationDate" },
                values: new object[] { new DateTime(2024, 8, 16, 14, 36, 27, 267, DateTimeKind.Utc).AddTicks(9453), new DateTime(2023, 10, 22, 5, 47, 58, 512, DateTimeKind.Local).AddTicks(5459) });

            migrationBuilder.UpdateData(
                table: "Book",
                keyColumn: "BookId",
                keyValue: 1219,
                columns: new[] { "CreatedDateTime", "PublicationDate" },
                values: new object[] { new DateTime(2024, 8, 16, 14, 36, 27, 267, DateTimeKind.Utc).AddTicks(9591), new DateTime(2024, 3, 14, 1, 28, 43, 577, DateTimeKind.Local).AddTicks(4896) });

            migrationBuilder.UpdateData(
                table: "Book",
                keyColumn: "BookId",
                keyValue: 1220,
                columns: new[] { "CreatedDateTime", "PublicationDate" },
                values: new object[] { new DateTime(2024, 8, 16, 14, 36, 27, 267, DateTimeKind.Utc).AddTicks(9718), new DateTime(2023, 12, 12, 20, 22, 59, 303, DateTimeKind.Local).AddTicks(1477) });

            migrationBuilder.UpdateData(
                table: "Book",
                keyColumn: "BookId",
                keyValue: 1221,
                columns: new[] { "CreatedDateTime", "PublicationDate" },
                values: new object[] { new DateTime(2024, 8, 16, 14, 36, 27, 267, DateTimeKind.Utc).AddTicks(9865), new DateTime(2023, 9, 13, 2, 6, 3, 483, DateTimeKind.Local).AddTicks(8949) });

            migrationBuilder.UpdateData(
                table: "Book",
                keyColumn: "BookId",
                keyValue: 1222,
                columns: new[] { "CreatedDateTime", "PublicationDate" },
                values: new object[] { new DateTime(2024, 8, 16, 14, 36, 27, 268, DateTimeKind.Utc).AddTicks(8), new DateTime(2024, 5, 9, 4, 25, 36, 623, DateTimeKind.Local).AddTicks(5704) });

            migrationBuilder.UpdateData(
                table: "Book",
                keyColumn: "BookId",
                keyValue: 1223,
                columns: new[] { "CreatedDateTime", "PublicationDate" },
                values: new object[] { new DateTime(2024, 8, 16, 14, 36, 27, 268, DateTimeKind.Utc).AddTicks(125), new DateTime(2023, 9, 21, 0, 20, 28, 511, DateTimeKind.Local).AddTicks(5585) });

            migrationBuilder.UpdateData(
                table: "Book",
                keyColumn: "BookId",
                keyValue: 1224,
                columns: new[] { "CreatedDateTime", "PublicationDate" },
                values: new object[] { new DateTime(2024, 8, 16, 14, 36, 27, 268, DateTimeKind.Utc).AddTicks(237), new DateTime(2023, 11, 20, 10, 50, 48, 946, DateTimeKind.Local).AddTicks(8825) });

            migrationBuilder.UpdateData(
                table: "Book",
                keyColumn: "BookId",
                keyValue: 1225,
                columns: new[] { "CreatedDateTime", "PublicationDate" },
                values: new object[] { new DateTime(2024, 8, 16, 14, 36, 27, 268, DateTimeKind.Utc).AddTicks(342), new DateTime(2024, 7, 9, 23, 57, 15, 570, DateTimeKind.Local).AddTicks(2320) });

            migrationBuilder.UpdateData(
                table: "Book",
                keyColumn: "BookId",
                keyValue: 1226,
                columns: new[] { "CreatedDateTime", "PublicationDate" },
                values: new object[] { new DateTime(2024, 8, 16, 14, 36, 27, 268, DateTimeKind.Utc).AddTicks(445), new DateTime(2024, 3, 16, 4, 34, 40, 924, DateTimeKind.Local).AddTicks(1054) });

            migrationBuilder.UpdateData(
                table: "Book",
                keyColumn: "BookId",
                keyValue: 1227,
                columns: new[] { "CreatedDateTime", "PublicationDate" },
                values: new object[] { new DateTime(2024, 8, 16, 14, 36, 27, 268, DateTimeKind.Utc).AddTicks(600), new DateTime(2024, 3, 13, 23, 48, 59, 778, DateTimeKind.Local).AddTicks(7866) });

            migrationBuilder.UpdateData(
                table: "Book",
                keyColumn: "BookId",
                keyValue: 1228,
                columns: new[] { "CreatedDateTime", "PublicationDate" },
                values: new object[] { new DateTime(2024, 8, 16, 14, 36, 27, 268, DateTimeKind.Utc).AddTicks(764), new DateTime(2023, 12, 30, 17, 32, 41, 268, DateTimeKind.Local).AddTicks(1420) });

            migrationBuilder.UpdateData(
                table: "Book",
                keyColumn: "BookId",
                keyValue: 1229,
                columns: new[] { "CreatedDateTime", "PublicationDate" },
                values: new object[] { new DateTime(2024, 8, 16, 14, 36, 27, 268, DateTimeKind.Utc).AddTicks(872), new DateTime(2023, 10, 8, 3, 34, 42, 29, DateTimeKind.Local).AddTicks(8859) });

            migrationBuilder.UpdateData(
                table: "Book",
                keyColumn: "BookId",
                keyValue: 1230,
                columns: new[] { "CreatedDateTime", "PublicationDate" },
                values: new object[] { new DateTime(2024, 8, 16, 14, 36, 27, 268, DateTimeKind.Utc).AddTicks(1010), new DateTime(2023, 9, 18, 4, 56, 42, 294, DateTimeKind.Local).AddTicks(4196) });

            migrationBuilder.UpdateData(
                table: "Book",
                keyColumn: "BookId",
                keyValue: 1231,
                columns: new[] { "CreatedDateTime", "PublicationDate" },
                values: new object[] { new DateTime(2024, 8, 16, 14, 36, 27, 268, DateTimeKind.Utc).AddTicks(1112), new DateTime(2024, 3, 22, 12, 28, 53, 865, DateTimeKind.Local).AddTicks(3277) });

            migrationBuilder.UpdateData(
                table: "Book",
                keyColumn: "BookId",
                keyValue: 1232,
                columns: new[] { "CreatedDateTime", "PublicationDate" },
                values: new object[] { new DateTime(2024, 8, 16, 14, 36, 27, 268, DateTimeKind.Utc).AddTicks(1252), new DateTime(2024, 4, 18, 19, 46, 38, 345, DateTimeKind.Local).AddTicks(5830) });

            migrationBuilder.UpdateData(
                table: "Book",
                keyColumn: "BookId",
                keyValue: 1233,
                columns: new[] { "CreatedDateTime", "PublicationDate" },
                values: new object[] { new DateTime(2024, 8, 16, 14, 36, 27, 268, DateTimeKind.Utc).AddTicks(1369), new DateTime(2024, 4, 4, 2, 36, 37, 872, DateTimeKind.Local).AddTicks(1676) });

            migrationBuilder.UpdateData(
                table: "Book",
                keyColumn: "BookId",
                keyValue: 1234,
                columns: new[] { "CreatedDateTime", "PublicationDate" },
                values: new object[] { new DateTime(2024, 8, 16, 14, 36, 27, 268, DateTimeKind.Utc).AddTicks(1508), new DateTime(2024, 7, 27, 22, 37, 17, 987, DateTimeKind.Local).AddTicks(1953) });

            migrationBuilder.UpdateData(
                table: "Book",
                keyColumn: "BookId",
                keyValue: 1235,
                columns: new[] { "CreatedDateTime", "PublicationDate" },
                values: new object[] { new DateTime(2024, 8, 16, 14, 36, 27, 268, DateTimeKind.Utc).AddTicks(1608), new DateTime(2023, 9, 17, 7, 33, 5, 812, DateTimeKind.Local).AddTicks(9727) });

            migrationBuilder.UpdateData(
                table: "Book",
                keyColumn: "BookId",
                keyValue: 1236,
                columns: new[] { "CreatedDateTime", "PublicationDate" },
                values: new object[] { new DateTime(2024, 8, 16, 14, 36, 27, 268, DateTimeKind.Utc).AddTicks(1742), new DateTime(2023, 10, 5, 14, 18, 20, 570, DateTimeKind.Local).AddTicks(4278) });

            migrationBuilder.UpdateData(
                table: "Book",
                keyColumn: "BookId",
                keyValue: 1237,
                columns: new[] { "CreatedDateTime", "PublicationDate" },
                values: new object[] { new DateTime(2024, 8, 16, 14, 36, 27, 268, DateTimeKind.Utc).AddTicks(1842), new DateTime(2024, 5, 28, 17, 10, 53, 530, DateTimeKind.Local).AddTicks(219) });

            migrationBuilder.UpdateData(
                table: "Book",
                keyColumn: "BookId",
                keyValue: 1238,
                columns: new[] { "CreatedDateTime", "PublicationDate" },
                values: new object[] { new DateTime(2024, 8, 16, 14, 36, 27, 268, DateTimeKind.Utc).AddTicks(1976), new DateTime(2024, 2, 8, 8, 54, 19, 545, DateTimeKind.Local).AddTicks(6558) });

            migrationBuilder.UpdateData(
                table: "Book",
                keyColumn: "BookId",
                keyValue: 1239,
                columns: new[] { "CreatedDateTime", "PublicationDate" },
                values: new object[] { new DateTime(2024, 8, 16, 14, 36, 27, 268, DateTimeKind.Utc).AddTicks(2075), new DateTime(2023, 10, 3, 15, 52, 42, 389, DateTimeKind.Local).AddTicks(9281) });

            migrationBuilder.UpdateData(
                table: "Book",
                keyColumn: "BookId",
                keyValue: 1240,
                columns: new[] { "CreatedDateTime", "PublicationDate" },
                values: new object[] { new DateTime(2024, 8, 16, 14, 36, 27, 268, DateTimeKind.Utc).AddTicks(2210), new DateTime(2024, 8, 14, 12, 58, 23, 194, DateTimeKind.Local).AddTicks(8452) });

            migrationBuilder.UpdateData(
                table: "Book",
                keyColumn: "BookId",
                keyValue: 1241,
                columns: new[] { "CreatedDateTime", "PublicationDate" },
                values: new object[] { new DateTime(2024, 8, 16, 14, 36, 27, 268, DateTimeKind.Utc).AddTicks(2324), new DateTime(2023, 10, 19, 12, 53, 26, 914, DateTimeKind.Local).AddTicks(5099) });

            migrationBuilder.UpdateData(
                table: "Book",
                keyColumn: "BookId",
                keyValue: 1242,
                columns: new[] { "CreatedDateTime", "PublicationDate" },
                values: new object[] { new DateTime(2024, 8, 16, 14, 36, 27, 268, DateTimeKind.Utc).AddTicks(2456), new DateTime(2024, 4, 26, 22, 23, 3, 58, DateTimeKind.Local).AddTicks(313) });

            migrationBuilder.UpdateData(
                table: "Book",
                keyColumn: "BookId",
                keyValue: 1243,
                columns: new[] { "CreatedDateTime", "PublicationDate" },
                values: new object[] { new DateTime(2024, 8, 16, 14, 36, 27, 268, DateTimeKind.Utc).AddTicks(2566), new DateTime(2024, 7, 19, 11, 59, 46, 685, DateTimeKind.Local).AddTicks(3694) });

            migrationBuilder.UpdateData(
                table: "Book",
                keyColumn: "BookId",
                keyValue: 1244,
                columns: new[] { "CreatedDateTime", "PublicationDate" },
                values: new object[] { new DateTime(2024, 8, 16, 14, 36, 27, 268, DateTimeKind.Utc).AddTicks(2703), new DateTime(2024, 5, 20, 15, 23, 50, 51, DateTimeKind.Local).AddTicks(6861) });

            migrationBuilder.UpdateData(
                table: "Book",
                keyColumn: "BookId",
                keyValue: 1245,
                columns: new[] { "CreatedDateTime", "PublicationDate" },
                values: new object[] { new DateTime(2024, 8, 16, 14, 36, 27, 268, DateTimeKind.Utc).AddTicks(2803), new DateTime(2024, 8, 7, 14, 8, 41, 774, DateTimeKind.Local).AddTicks(6007) });

            migrationBuilder.UpdateData(
                table: "Book",
                keyColumn: "BookId",
                keyValue: 1246,
                columns: new[] { "CreatedDateTime", "PublicationDate" },
                values: new object[] { new DateTime(2024, 8, 16, 14, 36, 27, 268, DateTimeKind.Utc).AddTicks(2928), new DateTime(2024, 1, 26, 1, 54, 50, 759, DateTimeKind.Local).AddTicks(1824) });

            migrationBuilder.UpdateData(
                table: "Book",
                keyColumn: "BookId",
                keyValue: 1247,
                columns: new[] { "CreatedDateTime", "PublicationDate" },
                values: new object[] { new DateTime(2024, 8, 16, 14, 36, 27, 268, DateTimeKind.Utc).AddTicks(3027), new DateTime(2024, 5, 7, 10, 44, 12, 110, DateTimeKind.Local).AddTicks(1705) });

            migrationBuilder.UpdateData(
                table: "Book",
                keyColumn: "BookId",
                keyValue: 1248,
                columns: new[] { "CreatedDateTime", "PublicationDate" },
                values: new object[] { new DateTime(2024, 8, 16, 14, 36, 27, 268, DateTimeKind.Utc).AddTicks(3167), new DateTime(2024, 5, 3, 18, 29, 6, 42, DateTimeKind.Local).AddTicks(3392) });

            migrationBuilder.UpdateData(
                table: "Book",
                keyColumn: "BookId",
                keyValue: 1249,
                columns: new[] { "CreatedDateTime", "PublicationDate" },
                values: new object[] { new DateTime(2024, 8, 16, 14, 36, 27, 268, DateTimeKind.Utc).AddTicks(3265), new DateTime(2023, 8, 18, 7, 31, 44, 967, DateTimeKind.Local).AddTicks(4694) });

            migrationBuilder.UpdateData(
                table: "Book",
                keyColumn: "BookId",
                keyValue: 1250,
                columns: new[] { "CreatedDateTime", "PublicationDate" },
                values: new object[] { new DateTime(2024, 8, 16, 14, 36, 27, 268, DateTimeKind.Utc).AddTicks(3397), new DateTime(2023, 12, 26, 4, 0, 25, 627, DateTimeKind.Local).AddTicks(341) });

            migrationBuilder.UpdateData(
                table: "Book",
                keyColumn: "BookId",
                keyValue: 1251,
                columns: new[] { "CreatedDateTime", "PublicationDate" },
                values: new object[] { new DateTime(2024, 8, 16, 14, 36, 27, 268, DateTimeKind.Utc).AddTicks(3506), new DateTime(2023, 9, 11, 1, 57, 5, 307, DateTimeKind.Local).AddTicks(6574) });

            migrationBuilder.UpdateData(
                table: "Book",
                keyColumn: "BookId",
                keyValue: 1252,
                columns: new[] { "CreatedDateTime", "PublicationDate" },
                values: new object[] { new DateTime(2024, 8, 16, 14, 36, 27, 268, DateTimeKind.Utc).AddTicks(3627), new DateTime(2023, 12, 9, 20, 38, 19, 429, DateTimeKind.Local).AddTicks(9863) });

            migrationBuilder.UpdateData(
                table: "Book",
                keyColumn: "BookId",
                keyValue: 1253,
                columns: new[] { "CreatedDateTime", "PublicationDate" },
                values: new object[] { new DateTime(2024, 8, 16, 14, 36, 27, 268, DateTimeKind.Utc).AddTicks(3729), new DateTime(2023, 10, 6, 12, 6, 40, 923, DateTimeKind.Local).AddTicks(3908) });

            migrationBuilder.UpdateData(
                table: "Book",
                keyColumn: "BookId",
                keyValue: 1254,
                columns: new[] { "CreatedDateTime", "PublicationDate" },
                values: new object[] { new DateTime(2024, 8, 16, 14, 36, 27, 268, DateTimeKind.Utc).AddTicks(3854), new DateTime(2024, 3, 10, 8, 31, 18, 318, DateTimeKind.Local).AddTicks(7755) });

            migrationBuilder.UpdateData(
                table: "Book",
                keyColumn: "BookId",
                keyValue: 1255,
                columns: new[] { "CreatedDateTime", "PublicationDate" },
                values: new object[] { new DateTime(2024, 8, 16, 14, 36, 27, 268, DateTimeKind.Utc).AddTicks(3987), new DateTime(2023, 10, 22, 21, 6, 42, 99, DateTimeKind.Local).AddTicks(1228) });

            migrationBuilder.UpdateData(
                table: "Book",
                keyColumn: "BookId",
                keyValue: 1256,
                columns: new[] { "CreatedDateTime", "PublicationDate" },
                values: new object[] { new DateTime(2024, 8, 16, 14, 36, 27, 268, DateTimeKind.Utc).AddTicks(4098), new DateTime(2024, 6, 20, 4, 49, 55, 747, DateTimeKind.Local).AddTicks(276) });

            migrationBuilder.UpdateData(
                table: "Book",
                keyColumn: "BookId",
                keyValue: 1257,
                columns: new[] { "CreatedDateTime", "PublicationDate" },
                values: new object[] { new DateTime(2024, 8, 16, 14, 36, 27, 268, DateTimeKind.Utc).AddTicks(4238), new DateTime(2023, 11, 13, 1, 28, 13, 175, DateTimeKind.Local).AddTicks(623) });

            migrationBuilder.UpdateData(
                table: "Book",
                keyColumn: "BookId",
                keyValue: 1258,
                columns: new[] { "CreatedDateTime", "PublicationDate" },
                values: new object[] { new DateTime(2024, 8, 16, 14, 36, 27, 268, DateTimeKind.Utc).AddTicks(4372), new DateTime(2024, 8, 6, 1, 15, 38, 637, DateTimeKind.Local).AddTicks(3460) });

            migrationBuilder.UpdateData(
                table: "Book",
                keyColumn: "BookId",
                keyValue: 1259,
                columns: new[] { "CreatedDateTime", "PublicationDate" },
                values: new object[] { new DateTime(2024, 8, 16, 14, 36, 27, 268, DateTimeKind.Utc).AddTicks(4512), new DateTime(2024, 1, 22, 17, 37, 1, 536, DateTimeKind.Local).AddTicks(5469) });

            migrationBuilder.UpdateData(
                table: "Book",
                keyColumn: "BookId",
                keyValue: 1260,
                columns: new[] { "CreatedDateTime", "PublicationDate" },
                values: new object[] { new DateTime(2024, 8, 16, 14, 36, 27, 268, DateTimeKind.Utc).AddTicks(4610), new DateTime(2024, 4, 30, 5, 46, 27, 204, DateTimeKind.Local).AddTicks(7248) });

            migrationBuilder.UpdateData(
                table: "Book",
                keyColumn: "BookId",
                keyValue: 1261,
                columns: new[] { "CreatedDateTime", "PublicationDate" },
                values: new object[] { new DateTime(2024, 8, 16, 14, 36, 27, 268, DateTimeKind.Utc).AddTicks(4741), new DateTime(2024, 2, 6, 22, 0, 51, 118, DateTimeKind.Local).AddTicks(1892) });

            migrationBuilder.UpdateData(
                table: "Book",
                keyColumn: "BookId",
                keyValue: 1262,
                columns: new[] { "CreatedDateTime", "PublicationDate" },
                values: new object[] { new DateTime(2024, 8, 16, 14, 36, 27, 268, DateTimeKind.Utc).AddTicks(4855), new DateTime(2024, 6, 15, 19, 23, 18, 862, DateTimeKind.Local).AddTicks(7302) });

            migrationBuilder.UpdateData(
                table: "Book",
                keyColumn: "BookId",
                keyValue: 1263,
                columns: new[] { "CreatedDateTime", "PublicationDate" },
                values: new object[] { new DateTime(2024, 8, 16, 14, 36, 27, 268, DateTimeKind.Utc).AddTicks(5003), new DateTime(2023, 9, 13, 22, 52, 24, 720, DateTimeKind.Local).AddTicks(1047) });

            migrationBuilder.UpdateData(
                table: "Book",
                keyColumn: "BookId",
                keyValue: 1264,
                columns: new[] { "CreatedDateTime", "PublicationDate" },
                values: new object[] { new DateTime(2024, 8, 16, 14, 36, 27, 268, DateTimeKind.Utc).AddTicks(5105), new DateTime(2024, 2, 29, 17, 21, 19, 41, DateTimeKind.Local).AddTicks(7012) });

            migrationBuilder.UpdateData(
                table: "Book",
                keyColumn: "BookId",
                keyValue: 1265,
                columns: new[] { "CreatedDateTime", "PublicationDate" },
                values: new object[] { new DateTime(2024, 8, 16, 14, 36, 27, 268, DateTimeKind.Utc).AddTicks(5238), new DateTime(2024, 8, 10, 1, 50, 41, 183, DateTimeKind.Local).AddTicks(9825) });

            migrationBuilder.UpdateData(
                table: "Book",
                keyColumn: "BookId",
                keyValue: 1266,
                columns: new[] { "CreatedDateTime", "PublicationDate" },
                values: new object[] { new DateTime(2024, 8, 16, 14, 36, 27, 268, DateTimeKind.Utc).AddTicks(5351), new DateTime(2024, 6, 2, 22, 59, 49, 24, DateTimeKind.Local).AddTicks(8372) });

            migrationBuilder.UpdateData(
                table: "Book",
                keyColumn: "BookId",
                keyValue: 1267,
                columns: new[] { "CreatedDateTime", "PublicationDate" },
                values: new object[] { new DateTime(2024, 8, 16, 14, 36, 27, 268, DateTimeKind.Utc).AddTicks(5533), new DateTime(2024, 8, 5, 6, 55, 47, 582, DateTimeKind.Local).AddTicks(9392) });

            migrationBuilder.UpdateData(
                table: "Book",
                keyColumn: "BookId",
                keyValue: 1268,
                columns: new[] { "CreatedDateTime", "PublicationDate" },
                values: new object[] { new DateTime(2024, 8, 16, 14, 36, 27, 268, DateTimeKind.Utc).AddTicks(5696), new DateTime(2024, 1, 12, 4, 56, 0, 160, DateTimeKind.Local).AddTicks(1028) });

            migrationBuilder.UpdateData(
                table: "Book",
                keyColumn: "BookId",
                keyValue: 1269,
                columns: new[] { "CreatedDateTime", "PublicationDate" },
                values: new object[] { new DateTime(2024, 8, 16, 14, 36, 27, 268, DateTimeKind.Utc).AddTicks(5909), new DateTime(2024, 2, 20, 20, 23, 8, 461, DateTimeKind.Local).AddTicks(5539) });

            migrationBuilder.UpdateData(
                table: "Book",
                keyColumn: "BookId",
                keyValue: 1270,
                columns: new[] { "CreatedDateTime", "PublicationDate" },
                values: new object[] { new DateTime(2024, 8, 16, 14, 36, 27, 268, DateTimeKind.Utc).AddTicks(6092), new DateTime(2024, 1, 2, 11, 19, 12, 265, DateTimeKind.Local).AddTicks(6570) });

            migrationBuilder.UpdateData(
                table: "Book",
                keyColumn: "BookId",
                keyValue: 1271,
                columns: new[] { "CreatedDateTime", "PublicationDate" },
                values: new object[] { new DateTime(2024, 8, 16, 14, 36, 27, 268, DateTimeKind.Utc).AddTicks(6283), new DateTime(2023, 10, 24, 12, 32, 5, 438, DateTimeKind.Local).AddTicks(9745) });

            migrationBuilder.UpdateData(
                table: "Book",
                keyColumn: "BookId",
                keyValue: 1272,
                columns: new[] { "CreatedDateTime", "PublicationDate" },
                values: new object[] { new DateTime(2024, 8, 16, 14, 36, 27, 268, DateTimeKind.Utc).AddTicks(6406), new DateTime(2023, 11, 1, 22, 16, 29, 311, DateTimeKind.Local).AddTicks(2588) });

            migrationBuilder.UpdateData(
                table: "Book",
                keyColumn: "BookId",
                keyValue: 1273,
                columns: new[] { "CreatedDateTime", "PublicationDate" },
                values: new object[] { new DateTime(2024, 8, 16, 14, 36, 27, 268, DateTimeKind.Utc).AddTicks(6546), new DateTime(2024, 1, 21, 2, 24, 27, 919, DateTimeKind.Local).AddTicks(4510) });

            migrationBuilder.UpdateData(
                table: "Book",
                keyColumn: "BookId",
                keyValue: 1274,
                columns: new[] { "CreatedDateTime", "PublicationDate" },
                values: new object[] { new DateTime(2024, 8, 16, 14, 36, 27, 268, DateTimeKind.Utc).AddTicks(6667), new DateTime(2023, 10, 11, 4, 1, 25, 692, DateTimeKind.Local).AddTicks(6186) });

            migrationBuilder.UpdateData(
                table: "Book",
                keyColumn: "BookId",
                keyValue: 1275,
                columns: new[] { "CreatedDateTime", "PublicationDate" },
                values: new object[] { new DateTime(2024, 8, 16, 14, 36, 27, 268, DateTimeKind.Utc).AddTicks(6811), new DateTime(2024, 7, 27, 17, 4, 31, 91, DateTimeKind.Local).AddTicks(5528) });

            migrationBuilder.UpdateData(
                table: "Book",
                keyColumn: "BookId",
                keyValue: 1276,
                columns: new[] { "CreatedDateTime", "PublicationDate" },
                values: new object[] { new DateTime(2024, 8, 16, 14, 36, 27, 268, DateTimeKind.Utc).AddTicks(6921), new DateTime(2024, 2, 7, 16, 5, 18, 865, DateTimeKind.Local).AddTicks(4504) });

            migrationBuilder.UpdateData(
                table: "Book",
                keyColumn: "BookId",
                keyValue: 1277,
                columns: new[] { "CreatedDateTime", "PublicationDate" },
                values: new object[] { new DateTime(2024, 8, 16, 14, 36, 27, 268, DateTimeKind.Utc).AddTicks(7074), new DateTime(2023, 12, 9, 7, 34, 48, 12, DateTimeKind.Local).AddTicks(3993) });

            migrationBuilder.UpdateData(
                table: "Book",
                keyColumn: "BookId",
                keyValue: 1278,
                columns: new[] { "CreatedDateTime", "PublicationDate" },
                values: new object[] { new DateTime(2024, 8, 16, 14, 36, 27, 268, DateTimeKind.Utc).AddTicks(7183), new DateTime(2024, 2, 3, 23, 37, 51, 68, DateTimeKind.Local).AddTicks(1622) });

            migrationBuilder.UpdateData(
                table: "Book",
                keyColumn: "BookId",
                keyValue: 1279,
                columns: new[] { "CreatedDateTime", "PublicationDate" },
                values: new object[] { new DateTime(2024, 8, 16, 14, 36, 27, 268, DateTimeKind.Utc).AddTicks(7315), new DateTime(2023, 10, 1, 18, 11, 59, 165, DateTimeKind.Local).AddTicks(7263) });

            migrationBuilder.UpdateData(
                table: "Book",
                keyColumn: "BookId",
                keyValue: 1280,
                columns: new[] { "CreatedDateTime", "PublicationDate" },
                values: new object[] { new DateTime(2024, 8, 16, 14, 36, 27, 268, DateTimeKind.Utc).AddTicks(7433), new DateTime(2023, 8, 24, 6, 40, 6, 906, DateTimeKind.Local).AddTicks(9591) });

            migrationBuilder.UpdateData(
                table: "Book",
                keyColumn: "BookId",
                keyValue: 1281,
                columns: new[] { "CreatedDateTime", "PublicationDate" },
                values: new object[] { new DateTime(2024, 8, 16, 14, 36, 27, 268, DateTimeKind.Utc).AddTicks(7581), new DateTime(2024, 5, 29, 14, 21, 19, 512, DateTimeKind.Local).AddTicks(3470) });

            migrationBuilder.UpdateData(
                table: "Book",
                keyColumn: "BookId",
                keyValue: 1282,
                columns: new[] { "CreatedDateTime", "PublicationDate" },
                values: new object[] { new DateTime(2024, 8, 16, 14, 36, 27, 268, DateTimeKind.Utc).AddTicks(7710), new DateTime(2024, 1, 30, 8, 30, 31, 394, DateTimeKind.Local).AddTicks(5317) });

            migrationBuilder.UpdateData(
                table: "Book",
                keyColumn: "BookId",
                keyValue: 1283,
                columns: new[] { "CreatedDateTime", "PublicationDate" },
                values: new object[] { new DateTime(2024, 8, 16, 14, 36, 27, 268, DateTimeKind.Utc).AddTicks(7828), new DateTime(2023, 11, 26, 2, 53, 16, 612, DateTimeKind.Local).AddTicks(2759) });

            migrationBuilder.UpdateData(
                table: "Book",
                keyColumn: "BookId",
                keyValue: 1284,
                columns: new[] { "CreatedDateTime", "PublicationDate" },
                values: new object[] { new DateTime(2024, 8, 16, 14, 36, 27, 268, DateTimeKind.Utc).AddTicks(7957), new DateTime(2023, 11, 1, 9, 30, 38, 308, DateTimeKind.Local).AddTicks(4886) });

            migrationBuilder.UpdateData(
                table: "Book",
                keyColumn: "BookId",
                keyValue: 1285,
                columns: new[] { "CreatedDateTime", "PublicationDate" },
                values: new object[] { new DateTime(2024, 8, 16, 14, 36, 27, 268, DateTimeKind.Utc).AddTicks(8076), new DateTime(2024, 4, 4, 15, 27, 51, 139, DateTimeKind.Local).AddTicks(5527) });

            migrationBuilder.UpdateData(
                table: "Book",
                keyColumn: "BookId",
                keyValue: 1286,
                columns: new[] { "CreatedDateTime", "PublicationDate" },
                values: new object[] { new DateTime(2024, 8, 16, 14, 36, 27, 268, DateTimeKind.Utc).AddTicks(8206), new DateTime(2024, 8, 14, 0, 48, 3, 50, DateTimeKind.Local).AddTicks(4908) });

            migrationBuilder.UpdateData(
                table: "Book",
                keyColumn: "BookId",
                keyValue: 1287,
                columns: new[] { "CreatedDateTime", "PublicationDate" },
                values: new object[] { new DateTime(2024, 8, 16, 14, 36, 27, 268, DateTimeKind.Utc).AddTicks(8362), new DateTime(2024, 4, 24, 1, 54, 2, 510, DateTimeKind.Local).AddTicks(6684) });

            migrationBuilder.UpdateData(
                table: "Book",
                keyColumn: "BookId",
                keyValue: 1288,
                columns: new[] { "CreatedDateTime", "PublicationDate" },
                values: new object[] { new DateTime(2024, 8, 16, 14, 36, 27, 268, DateTimeKind.Utc).AddTicks(8551), new DateTime(2023, 9, 8, 1, 37, 34, 806, DateTimeKind.Local).AddTicks(2447) });

            migrationBuilder.UpdateData(
                table: "Book",
                keyColumn: "BookId",
                keyValue: 1289,
                columns: new[] { "CreatedDateTime", "PublicationDate" },
                values: new object[] { new DateTime(2024, 8, 16, 14, 36, 27, 268, DateTimeKind.Utc).AddTicks(8715), new DateTime(2023, 8, 20, 5, 23, 48, 561, DateTimeKind.Local).AddTicks(7769) });

            migrationBuilder.UpdateData(
                table: "Book",
                keyColumn: "BookId",
                keyValue: 1290,
                columns: new[] { "CreatedDateTime", "PublicationDate" },
                values: new object[] { new DateTime(2024, 8, 16, 14, 36, 27, 268, DateTimeKind.Utc).AddTicks(8935), new DateTime(2023, 9, 11, 2, 21, 19, 257, DateTimeKind.Local).AddTicks(5893) });

            migrationBuilder.UpdateData(
                table: "Book",
                keyColumn: "BookId",
                keyValue: 1291,
                columns: new[] { "CreatedDateTime", "PublicationDate" },
                values: new object[] { new DateTime(2024, 8, 16, 14, 36, 27, 268, DateTimeKind.Utc).AddTicks(9094), new DateTime(2024, 5, 23, 14, 37, 4, 966, DateTimeKind.Local).AddTicks(1555) });

            migrationBuilder.UpdateData(
                table: "Book",
                keyColumn: "BookId",
                keyValue: 1292,
                columns: new[] { "CreatedDateTime", "PublicationDate" },
                values: new object[] { new DateTime(2024, 8, 16, 14, 36, 27, 268, DateTimeKind.Utc).AddTicks(9284), new DateTime(2024, 3, 6, 7, 19, 0, 821, DateTimeKind.Local).AddTicks(4635) });

            migrationBuilder.UpdateData(
                table: "Book",
                keyColumn: "BookId",
                keyValue: 1293,
                columns: new[] { "CreatedDateTime", "PublicationDate" },
                values: new object[] { new DateTime(2024, 8, 16, 14, 36, 27, 268, DateTimeKind.Utc).AddTicks(9454), new DateTime(2024, 7, 9, 4, 49, 27, 496, DateTimeKind.Local).AddTicks(8660) });

            migrationBuilder.UpdateData(
                table: "Book",
                keyColumn: "BookId",
                keyValue: 1294,
                columns: new[] { "CreatedDateTime", "PublicationDate" },
                values: new object[] { new DateTime(2024, 8, 16, 14, 36, 27, 268, DateTimeKind.Utc).AddTicks(9654), new DateTime(2023, 11, 14, 1, 17, 25, 796, DateTimeKind.Local).AddTicks(3367) });

            migrationBuilder.UpdateData(
                table: "Book",
                keyColumn: "BookId",
                keyValue: 1295,
                columns: new[] { "CreatedDateTime", "PublicationDate" },
                values: new object[] { new DateTime(2024, 8, 16, 14, 36, 27, 268, DateTimeKind.Utc).AddTicks(9819), new DateTime(2023, 11, 2, 5, 54, 44, 649, DateTimeKind.Local).AddTicks(2601) });

            migrationBuilder.UpdateData(
                table: "Book",
                keyColumn: "BookId",
                keyValue: 1296,
                columns: new[] { "CreatedDateTime", "PublicationDate" },
                values: new object[] { new DateTime(2024, 8, 16, 14, 36, 27, 269, DateTimeKind.Utc).AddTicks(2), new DateTime(2024, 6, 7, 23, 52, 32, 80, DateTimeKind.Local).AddTicks(2432) });

            migrationBuilder.UpdateData(
                table: "Book",
                keyColumn: "BookId",
                keyValue: 1297,
                columns: new[] { "CreatedDateTime", "PublicationDate" },
                values: new object[] { new DateTime(2024, 8, 16, 14, 36, 27, 269, DateTimeKind.Utc).AddTicks(157), new DateTime(2023, 10, 8, 19, 38, 34, 311, DateTimeKind.Local).AddTicks(4921) });

            migrationBuilder.UpdateData(
                table: "Book",
                keyColumn: "BookId",
                keyValue: 1298,
                columns: new[] { "CreatedDateTime", "PublicationDate" },
                values: new object[] { new DateTime(2024, 8, 16, 14, 36, 27, 269, DateTimeKind.Utc).AddTicks(400), new DateTime(2024, 4, 5, 18, 8, 7, 446, DateTimeKind.Local).AddTicks(3124) });

            migrationBuilder.UpdateData(
                table: "Book",
                keyColumn: "BookId",
                keyValue: 1299,
                columns: new[] { "CreatedDateTime", "PublicationDate" },
                values: new object[] { new DateTime(2024, 8, 16, 14, 36, 27, 269, DateTimeKind.Utc).AddTicks(555), new DateTime(2024, 3, 14, 8, 23, 10, 872, DateTimeKind.Local).AddTicks(3267) });

            migrationBuilder.UpdateData(
                table: "Book",
                keyColumn: "BookId",
                keyValue: 1300,
                columns: new[] { "CreatedDateTime", "PublicationDate" },
                values: new object[] { new DateTime(2024, 8, 16, 14, 36, 27, 269, DateTimeKind.Utc).AddTicks(740), new DateTime(2023, 10, 25, 9, 52, 39, 47, DateTimeKind.Local).AddTicks(892) });

            migrationBuilder.UpdateData(
                table: "Book",
                keyColumn: "BookId",
                keyValue: 1301,
                columns: new[] { "CreatedDateTime", "PublicationDate" },
                values: new object[] { new DateTime(2024, 8, 16, 14, 36, 27, 269, DateTimeKind.Utc).AddTicks(885), new DateTime(2024, 5, 9, 10, 14, 25, 762, DateTimeKind.Local).AddTicks(883) });

            migrationBuilder.UpdateData(
                table: "Book",
                keyColumn: "BookId",
                keyValue: 1302,
                columns: new[] { "CreatedDateTime", "PublicationDate" },
                values: new object[] { new DateTime(2024, 8, 16, 14, 36, 27, 269, DateTimeKind.Utc).AddTicks(1069), new DateTime(2024, 5, 31, 1, 7, 31, 98, DateTimeKind.Local).AddTicks(8776) });

            migrationBuilder.UpdateData(
                table: "Book",
                keyColumn: "BookId",
                keyValue: 1303,
                columns: new[] { "CreatedDateTime", "PublicationDate" },
                values: new object[] { new DateTime(2024, 8, 16, 14, 36, 27, 269, DateTimeKind.Utc).AddTicks(1219), new DateTime(2023, 10, 2, 13, 57, 40, 772, DateTimeKind.Local).AddTicks(728) });

            migrationBuilder.UpdateData(
                table: "Book",
                keyColumn: "BookId",
                keyValue: 1304,
                columns: new[] { "CreatedDateTime", "PublicationDate" },
                values: new object[] { new DateTime(2024, 8, 16, 14, 36, 27, 269, DateTimeKind.Utc).AddTicks(1413), new DateTime(2024, 4, 23, 15, 27, 26, 658, DateTimeKind.Local).AddTicks(8698) });

            migrationBuilder.UpdateData(
                table: "Book",
                keyColumn: "BookId",
                keyValue: 1305,
                columns: new[] { "CreatedDateTime", "PublicationDate" },
                values: new object[] { new DateTime(2024, 8, 16, 14, 36, 27, 269, DateTimeKind.Utc).AddTicks(1563), new DateTime(2024, 4, 11, 13, 30, 56, 735, DateTimeKind.Local).AddTicks(9035) });

            migrationBuilder.UpdateData(
                table: "Book",
                keyColumn: "BookId",
                keyValue: 1306,
                columns: new[] { "CreatedDateTime", "PublicationDate" },
                values: new object[] { new DateTime(2024, 8, 16, 14, 36, 27, 269, DateTimeKind.Utc).AddTicks(1732), new DateTime(2024, 6, 16, 7, 53, 49, 813, DateTimeKind.Local).AddTicks(1516) });

            migrationBuilder.UpdateData(
                table: "Book",
                keyColumn: "BookId",
                keyValue: 1307,
                columns: new[] { "CreatedDateTime", "PublicationDate" },
                values: new object[] { new DateTime(2024, 8, 16, 14, 36, 27, 269, DateTimeKind.Utc).AddTicks(1866), new DateTime(2024, 3, 12, 0, 16, 31, 966, DateTimeKind.Local).AddTicks(3284) });

            migrationBuilder.UpdateData(
                table: "Book",
                keyColumn: "BookId",
                keyValue: 1308,
                columns: new[] { "CreatedDateTime", "PublicationDate" },
                values: new object[] { new DateTime(2024, 8, 16, 14, 36, 27, 269, DateTimeKind.Utc).AddTicks(2067), new DateTime(2024, 3, 24, 22, 25, 8, 662, DateTimeKind.Local).AddTicks(596) });

            migrationBuilder.UpdateData(
                table: "Book",
                keyColumn: "BookId",
                keyValue: 1309,
                columns: new[] { "CreatedDateTime", "PublicationDate" },
                values: new object[] { new DateTime(2024, 8, 16, 14, 36, 27, 269, DateTimeKind.Utc).AddTicks(2258), new DateTime(2023, 9, 1, 1, 40, 0, 463, DateTimeKind.Local).AddTicks(8048) });

            migrationBuilder.UpdateData(
                table: "Book",
                keyColumn: "BookId",
                keyValue: 1310,
                columns: new[] { "CreatedDateTime", "PublicationDate" },
                values: new object[] { new DateTime(2024, 8, 16, 14, 36, 27, 269, DateTimeKind.Utc).AddTicks(2445), new DateTime(2024, 3, 17, 1, 18, 23, 598, DateTimeKind.Local).AddTicks(6744) });

            migrationBuilder.UpdateData(
                table: "Book",
                keyColumn: "BookId",
                keyValue: 1311,
                columns: new[] { "CreatedDateTime", "PublicationDate" },
                values: new object[] { new DateTime(2024, 8, 16, 14, 36, 27, 269, DateTimeKind.Utc).AddTicks(2594), new DateTime(2024, 1, 19, 2, 7, 50, 210, DateTimeKind.Local).AddTicks(1628) });

            migrationBuilder.UpdateData(
                table: "Book",
                keyColumn: "BookId",
                keyValue: 1312,
                columns: new[] { "CreatedDateTime", "PublicationDate" },
                values: new object[] { new DateTime(2024, 8, 16, 14, 36, 27, 269, DateTimeKind.Utc).AddTicks(2774), new DateTime(2024, 3, 13, 15, 34, 57, 62, DateTimeKind.Local).AddTicks(5613) });

            migrationBuilder.UpdateData(
                table: "Book",
                keyColumn: "BookId",
                keyValue: 1313,
                columns: new[] { "CreatedDateTime", "PublicationDate" },
                values: new object[] { new DateTime(2024, 8, 16, 14, 36, 27, 269, DateTimeKind.Utc).AddTicks(2965), new DateTime(2023, 9, 11, 6, 14, 4, 272, DateTimeKind.Local).AddTicks(6611) });

            migrationBuilder.UpdateData(
                table: "Book",
                keyColumn: "BookId",
                keyValue: 1314,
                columns: new[] { "CreatedDateTime", "PublicationDate" },
                values: new object[] { new DateTime(2024, 8, 16, 14, 36, 27, 269, DateTimeKind.Utc).AddTicks(3172), new DateTime(2024, 7, 30, 9, 21, 13, 296, DateTimeKind.Local).AddTicks(6694) });

            migrationBuilder.UpdateData(
                table: "Book",
                keyColumn: "BookId",
                keyValue: 1315,
                columns: new[] { "CreatedDateTime", "PublicationDate" },
                values: new object[] { new DateTime(2024, 8, 16, 14, 36, 27, 269, DateTimeKind.Utc).AddTicks(3349), new DateTime(2024, 4, 13, 20, 15, 23, 217, DateTimeKind.Local).AddTicks(674) });

            migrationBuilder.UpdateData(
                table: "Book",
                keyColumn: "BookId",
                keyValue: 1316,
                columns: new[] { "CreatedDateTime", "PublicationDate" },
                values: new object[] { new DateTime(2024, 8, 16, 14, 36, 27, 269, DateTimeKind.Utc).AddTicks(3554), new DateTime(2023, 12, 20, 11, 55, 54, 668, DateTimeKind.Local).AddTicks(2615) });

            migrationBuilder.UpdateData(
                table: "Book",
                keyColumn: "BookId",
                keyValue: 1317,
                columns: new[] { "CreatedDateTime", "PublicationDate" },
                values: new object[] { new DateTime(2024, 8, 16, 14, 36, 27, 269, DateTimeKind.Utc).AddTicks(3787), new DateTime(2024, 1, 28, 18, 54, 30, 633, DateTimeKind.Local).AddTicks(3275) });

            migrationBuilder.UpdateData(
                table: "Book",
                keyColumn: "BookId",
                keyValue: 1318,
                columns: new[] { "CreatedDateTime", "PublicationDate" },
                values: new object[] { new DateTime(2024, 8, 16, 14, 36, 27, 269, DateTimeKind.Utc).AddTicks(3954), new DateTime(2024, 3, 2, 3, 45, 32, 299, DateTimeKind.Local).AddTicks(6502) });

            migrationBuilder.UpdateData(
                table: "Book",
                keyColumn: "BookId",
                keyValue: 1319,
                columns: new[] { "CreatedDateTime", "PublicationDate" },
                values: new object[] { new DateTime(2024, 8, 16, 14, 36, 27, 269, DateTimeKind.Utc).AddTicks(4166), new DateTime(2023, 8, 27, 3, 24, 56, 502, DateTimeKind.Local).AddTicks(9491) });

            migrationBuilder.UpdateData(
                table: "Book",
                keyColumn: "BookId",
                keyValue: 1320,
                columns: new[] { "CreatedDateTime", "PublicationDate" },
                values: new object[] { new DateTime(2024, 8, 16, 14, 36, 27, 269, DateTimeKind.Utc).AddTicks(4327), new DateTime(2024, 4, 3, 23, 10, 45, 355, DateTimeKind.Local).AddTicks(7909) });

            migrationBuilder.UpdateData(
                table: "Book",
                keyColumn: "BookId",
                keyValue: 1321,
                columns: new[] { "CreatedDateTime", "PublicationDate" },
                values: new object[] { new DateTime(2024, 8, 16, 14, 36, 27, 269, DateTimeKind.Utc).AddTicks(4514), new DateTime(2024, 1, 24, 5, 21, 30, 50, DateTimeKind.Local).AddTicks(3279) });

            migrationBuilder.UpdateData(
                table: "Book",
                keyColumn: "BookId",
                keyValue: 1322,
                columns: new[] { "CreatedDateTime", "PublicationDate" },
                values: new object[] { new DateTime(2024, 8, 16, 14, 36, 27, 269, DateTimeKind.Utc).AddTicks(4662), new DateTime(2024, 2, 15, 17, 59, 8, 145, DateTimeKind.Local).AddTicks(2170) });

            migrationBuilder.UpdateData(
                table: "Book",
                keyColumn: "BookId",
                keyValue: 1323,
                columns: new[] { "CreatedDateTime", "PublicationDate" },
                values: new object[] { new DateTime(2024, 8, 16, 14, 36, 27, 269, DateTimeKind.Utc).AddTicks(4845), new DateTime(2024, 7, 8, 6, 12, 29, 821, DateTimeKind.Local).AddTicks(6576) });

            migrationBuilder.UpdateData(
                table: "Book",
                keyColumn: "BookId",
                keyValue: 1324,
                columns: new[] { "CreatedDateTime", "PublicationDate" },
                values: new object[] { new DateTime(2024, 8, 16, 14, 36, 27, 269, DateTimeKind.Utc).AddTicks(5014), new DateTime(2023, 10, 10, 16, 36, 45, 976, DateTimeKind.Local).AddTicks(1264) });

            migrationBuilder.UpdateData(
                table: "Book",
                keyColumn: "BookId",
                keyValue: 1325,
                columns: new[] { "CreatedDateTime", "PublicationDate" },
                values: new object[] { new DateTime(2024, 8, 16, 14, 36, 27, 269, DateTimeKind.Utc).AddTicks(5227), new DateTime(2024, 1, 18, 7, 27, 27, 131, DateTimeKind.Local).AddTicks(9252) });

            migrationBuilder.UpdateData(
                table: "Book",
                keyColumn: "BookId",
                keyValue: 1326,
                columns: new[] { "CreatedDateTime", "PublicationDate" },
                values: new object[] { new DateTime(2024, 8, 16, 14, 36, 27, 269, DateTimeKind.Utc).AddTicks(5396), new DateTime(2023, 11, 1, 4, 53, 51, 114, DateTimeKind.Local).AddTicks(3368) });

            migrationBuilder.UpdateData(
                table: "Book",
                keyColumn: "BookId",
                keyValue: 1327,
                columns: new[] { "CreatedDateTime", "PublicationDate" },
                values: new object[] { new DateTime(2024, 8, 16, 14, 36, 27, 269, DateTimeKind.Utc).AddTicks(5592), new DateTime(2024, 4, 24, 11, 0, 19, 190, DateTimeKind.Local).AddTicks(8322) });

            migrationBuilder.UpdateData(
                table: "Book",
                keyColumn: "BookId",
                keyValue: 1328,
                columns: new[] { "CreatedDateTime", "PublicationDate" },
                values: new object[] { new DateTime(2024, 8, 16, 14, 36, 27, 269, DateTimeKind.Utc).AddTicks(5739), new DateTime(2024, 1, 28, 2, 56, 38, 637, DateTimeKind.Local).AddTicks(4445) });

            migrationBuilder.UpdateData(
                table: "Book",
                keyColumn: "BookId",
                keyValue: 1329,
                columns: new[] { "CreatedDateTime", "PublicationDate" },
                values: new object[] { new DateTime(2024, 8, 16, 14, 36, 27, 269, DateTimeKind.Utc).AddTicks(5935), new DateTime(2024, 5, 11, 4, 32, 18, 828, DateTimeKind.Local).AddTicks(961) });

            migrationBuilder.UpdateData(
                table: "Book",
                keyColumn: "BookId",
                keyValue: 1330,
                columns: new[] { "CreatedDateTime", "PublicationDate" },
                values: new object[] { new DateTime(2024, 8, 16, 14, 36, 27, 269, DateTimeKind.Utc).AddTicks(6124), new DateTime(2024, 8, 7, 4, 37, 7, 710, DateTimeKind.Local).AddTicks(3945) });

            migrationBuilder.UpdateData(
                table: "Book",
                keyColumn: "BookId",
                keyValue: 1331,
                columns: new[] { "CreatedDateTime", "PublicationDate" },
                values: new object[] { new DateTime(2024, 8, 16, 14, 36, 27, 269, DateTimeKind.Utc).AddTicks(6306), new DateTime(2024, 2, 21, 11, 15, 27, 146, DateTimeKind.Local).AddTicks(9954) });

            migrationBuilder.UpdateData(
                table: "Book",
                keyColumn: "BookId",
                keyValue: 1332,
                columns: new[] { "CreatedDateTime", "PublicationDate" },
                values: new object[] { new DateTime(2024, 8, 16, 14, 36, 27, 269, DateTimeKind.Utc).AddTicks(6478), new DateTime(2024, 8, 11, 1, 33, 29, 121, DateTimeKind.Local).AddTicks(3882) });

            migrationBuilder.UpdateData(
                table: "Book",
                keyColumn: "BookId",
                keyValue: 1333,
                columns: new[] { "CreatedDateTime", "PublicationDate" },
                values: new object[] { new DateTime(2024, 8, 16, 14, 36, 27, 269, DateTimeKind.Utc).AddTicks(6662), new DateTime(2024, 6, 17, 17, 41, 9, 824, DateTimeKind.Local).AddTicks(5310) });

            migrationBuilder.UpdateData(
                table: "Book",
                keyColumn: "BookId",
                keyValue: 1334,
                columns: new[] { "CreatedDateTime", "PublicationDate" },
                values: new object[] { new DateTime(2024, 8, 16, 14, 36, 27, 269, DateTimeKind.Utc).AddTicks(6817), new DateTime(2024, 5, 21, 2, 34, 53, 89, DateTimeKind.Local).AddTicks(498) });

            migrationBuilder.UpdateData(
                table: "Book",
                keyColumn: "BookId",
                keyValue: 1335,
                columns: new[] { "CreatedDateTime", "PublicationDate" },
                values: new object[] { new DateTime(2024, 8, 16, 14, 36, 27, 269, DateTimeKind.Utc).AddTicks(6998), new DateTime(2024, 6, 13, 9, 57, 34, 809, DateTimeKind.Local).AddTicks(3797) });

            migrationBuilder.UpdateData(
                table: "Book",
                keyColumn: "BookId",
                keyValue: 1336,
                columns: new[] { "CreatedDateTime", "PublicationDate" },
                values: new object[] { new DateTime(2024, 8, 16, 14, 36, 27, 269, DateTimeKind.Utc).AddTicks(7162), new DateTime(2024, 3, 1, 15, 42, 53, 808, DateTimeKind.Local).AddTicks(7543) });

            migrationBuilder.UpdateData(
                table: "Book",
                keyColumn: "BookId",
                keyValue: 1337,
                columns: new[] { "CreatedDateTime", "PublicationDate" },
                values: new object[] { new DateTime(2024, 8, 16, 14, 36, 27, 269, DateTimeKind.Utc).AddTicks(7346), new DateTime(2023, 9, 2, 3, 36, 9, 142, DateTimeKind.Local).AddTicks(2250) });

            migrationBuilder.UpdateData(
                table: "Book",
                keyColumn: "BookId",
                keyValue: 1338,
                columns: new[] { "CreatedDateTime", "PublicationDate" },
                values: new object[] { new DateTime(2024, 8, 16, 14, 36, 27, 269, DateTimeKind.Utc).AddTicks(7485), new DateTime(2024, 8, 7, 4, 22, 58, 118, DateTimeKind.Local).AddTicks(371) });

            migrationBuilder.UpdateData(
                table: "Book",
                keyColumn: "BookId",
                keyValue: 1339,
                columns: new[] { "CreatedDateTime", "PublicationDate" },
                values: new object[] { new DateTime(2024, 8, 16, 14, 36, 27, 269, DateTimeKind.Utc).AddTicks(7677), new DateTime(2023, 9, 11, 4, 9, 3, 397, DateTimeKind.Local).AddTicks(4539) });

            migrationBuilder.UpdateData(
                table: "Book",
                keyColumn: "BookId",
                keyValue: 1340,
                columns: new[] { "CreatedDateTime", "PublicationDate" },
                values: new object[] { new DateTime(2024, 8, 16, 14, 36, 27, 269, DateTimeKind.Utc).AddTicks(7829), new DateTime(2024, 3, 19, 20, 27, 55, 452, DateTimeKind.Local).AddTicks(9426) });

            migrationBuilder.UpdateData(
                table: "Book",
                keyColumn: "BookId",
                keyValue: 1341,
                columns: new[] { "CreatedDateTime", "PublicationDate" },
                values: new object[] { new DateTime(2024, 8, 16, 14, 36, 27, 269, DateTimeKind.Utc).AddTicks(8005), new DateTime(2024, 7, 8, 5, 13, 16, 114, DateTimeKind.Local).AddTicks(5099) });

            migrationBuilder.UpdateData(
                table: "Book",
                keyColumn: "BookId",
                keyValue: 1342,
                columns: new[] { "CreatedDateTime", "PublicationDate" },
                values: new object[] { new DateTime(2024, 8, 16, 14, 36, 27, 269, DateTimeKind.Utc).AddTicks(8139), new DateTime(2024, 6, 4, 2, 32, 31, 74, DateTimeKind.Local).AddTicks(9018) });

            migrationBuilder.UpdateData(
                table: "Book",
                keyColumn: "BookId",
                keyValue: 1343,
                columns: new[] { "CreatedDateTime", "PublicationDate" },
                values: new object[] { new DateTime(2024, 8, 16, 14, 36, 27, 269, DateTimeKind.Utc).AddTicks(8283), new DateTime(2024, 5, 23, 7, 27, 31, 859, DateTimeKind.Local).AddTicks(5398) });

            migrationBuilder.UpdateData(
                table: "Book",
                keyColumn: "BookId",
                keyValue: 1344,
                columns: new[] { "CreatedDateTime", "PublicationDate" },
                values: new object[] { new DateTime(2024, 8, 16, 14, 36, 27, 269, DateTimeKind.Utc).AddTicks(8399), new DateTime(2023, 9, 3, 17, 53, 18, 178, DateTimeKind.Local).AddTicks(2673) });

            migrationBuilder.UpdateData(
                table: "Book",
                keyColumn: "BookId",
                keyValue: 1345,
                columns: new[] { "CreatedDateTime", "PublicationDate" },
                values: new object[] { new DateTime(2024, 8, 16, 14, 36, 27, 269, DateTimeKind.Utc).AddTicks(8538), new DateTime(2023, 12, 18, 14, 39, 19, 694, DateTimeKind.Local).AddTicks(7097) });

            migrationBuilder.UpdateData(
                table: "Book",
                keyColumn: "BookId",
                keyValue: 1346,
                columns: new[] { "CreatedDateTime", "PublicationDate" },
                values: new object[] { new DateTime(2024, 8, 16, 14, 36, 27, 269, DateTimeKind.Utc).AddTicks(8647), new DateTime(2023, 9, 6, 18, 9, 9, 979, DateTimeKind.Local).AddTicks(6469) });

            migrationBuilder.UpdateData(
                table: "Book",
                keyColumn: "BookId",
                keyValue: 1347,
                columns: new[] { "CreatedDateTime", "PublicationDate" },
                values: new object[] { new DateTime(2024, 8, 16, 14, 36, 27, 269, DateTimeKind.Utc).AddTicks(8778), new DateTime(2023, 10, 20, 16, 39, 53, 82, DateTimeKind.Local).AddTicks(6216) });

            migrationBuilder.UpdateData(
                table: "Book",
                keyColumn: "BookId",
                keyValue: 1348,
                columns: new[] { "CreatedDateTime", "PublicationDate" },
                values: new object[] { new DateTime(2024, 8, 16, 14, 36, 27, 269, DateTimeKind.Utc).AddTicks(8903), new DateTime(2024, 1, 4, 1, 30, 45, 771, DateTimeKind.Local).AddTicks(5588) });

            migrationBuilder.UpdateData(
                table: "Book",
                keyColumn: "BookId",
                keyValue: 1349,
                columns: new[] { "CreatedDateTime", "PublicationDate" },
                values: new object[] { new DateTime(2024, 8, 16, 14, 36, 27, 269, DateTimeKind.Utc).AddTicks(9055), new DateTime(2024, 4, 19, 23, 42, 11, 265, DateTimeKind.Local).AddTicks(2391) });

            migrationBuilder.UpdateData(
                table: "Book",
                keyColumn: "BookId",
                keyValue: 1350,
                columns: new[] { "CreatedDateTime", "PublicationDate" },
                values: new object[] { new DateTime(2024, 8, 16, 14, 36, 27, 269, DateTimeKind.Utc).AddTicks(9154), new DateTime(2023, 10, 7, 13, 32, 42, 760, DateTimeKind.Local).AddTicks(9910) });

            migrationBuilder.UpdateData(
                table: "Book",
                keyColumn: "BookId",
                keyValue: 1351,
                columns: new[] { "CreatedDateTime", "PublicationDate" },
                values: new object[] { new DateTime(2024, 8, 16, 14, 36, 27, 269, DateTimeKind.Utc).AddTicks(9297), new DateTime(2024, 1, 2, 8, 23, 7, 786, DateTimeKind.Local).AddTicks(9098) });

            migrationBuilder.UpdateData(
                table: "Book",
                keyColumn: "BookId",
                keyValue: 1352,
                columns: new[] { "CreatedDateTime", "PublicationDate" },
                values: new object[] { new DateTime(2024, 8, 16, 14, 36, 27, 269, DateTimeKind.Utc).AddTicks(9434), new DateTime(2023, 10, 31, 2, 26, 28, 727, DateTimeKind.Local).AddTicks(2444) });

            migrationBuilder.UpdateData(
                table: "Book",
                keyColumn: "BookId",
                keyValue: 1353,
                columns: new[] { "CreatedDateTime", "PublicationDate" },
                values: new object[] { new DateTime(2024, 8, 16, 14, 36, 27, 269, DateTimeKind.Utc).AddTicks(9540), new DateTime(2024, 1, 23, 6, 12, 38, 406, DateTimeKind.Local).AddTicks(4679) });

            migrationBuilder.UpdateData(
                table: "Book",
                keyColumn: "BookId",
                keyValue: 1354,
                columns: new[] { "CreatedDateTime", "PublicationDate" },
                values: new object[] { new DateTime(2024, 8, 16, 14, 36, 27, 269, DateTimeKind.Utc).AddTicks(9675), new DateTime(2024, 2, 9, 5, 5, 59, 137, DateTimeKind.Local).AddTicks(2007) });

            migrationBuilder.UpdateData(
                table: "Book",
                keyColumn: "BookId",
                keyValue: 1355,
                columns: new[] { "CreatedDateTime", "PublicationDate" },
                values: new object[] { new DateTime(2024, 8, 16, 14, 36, 27, 269, DateTimeKind.Utc).AddTicks(9773), new DateTime(2023, 10, 21, 19, 49, 52, 994, DateTimeKind.Local).AddTicks(5421) });

            migrationBuilder.UpdateData(
                table: "Book",
                keyColumn: "BookId",
                keyValue: 1356,
                columns: new[] { "CreatedDateTime", "PublicationDate" },
                values: new object[] { new DateTime(2024, 8, 16, 14, 36, 27, 269, DateTimeKind.Utc).AddTicks(9919), new DateTime(2024, 3, 24, 23, 50, 41, 28, DateTimeKind.Local).AddTicks(4835) });

            migrationBuilder.UpdateData(
                table: "Book",
                keyColumn: "BookId",
                keyValue: 1357,
                columns: new[] { "CreatedDateTime", "PublicationDate" },
                values: new object[] { new DateTime(2024, 8, 16, 14, 36, 27, 270, DateTimeKind.Utc).AddTicks(22), new DateTime(2023, 10, 5, 6, 4, 22, 493, DateTimeKind.Local).AddTicks(2931) });

            migrationBuilder.UpdateData(
                table: "Book",
                keyColumn: "BookId",
                keyValue: 1358,
                columns: new[] { "CreatedDateTime", "PublicationDate" },
                values: new object[] { new DateTime(2024, 8, 16, 14, 36, 27, 270, DateTimeKind.Utc).AddTicks(160), new DateTime(2023, 12, 31, 13, 35, 55, 530, DateTimeKind.Local).AddTicks(7936) });

            migrationBuilder.UpdateData(
                table: "Book",
                keyColumn: "BookId",
                keyValue: 1359,
                columns: new[] { "CreatedDateTime", "PublicationDate" },
                values: new object[] { new DateTime(2024, 8, 16, 14, 36, 27, 270, DateTimeKind.Utc).AddTicks(281), new DateTime(2023, 11, 20, 4, 54, 17, 642, DateTimeKind.Local).AddTicks(3398) });

            migrationBuilder.UpdateData(
                table: "Book",
                keyColumn: "BookId",
                keyValue: 1360,
                columns: new[] { "CreatedDateTime", "PublicationDate" },
                values: new object[] { new DateTime(2024, 8, 16, 14, 36, 27, 270, DateTimeKind.Utc).AddTicks(450), new DateTime(2023, 12, 14, 10, 49, 35, 634, DateTimeKind.Local).AddTicks(3960) });

            migrationBuilder.UpdateData(
                table: "Book",
                keyColumn: "BookId",
                keyValue: 1361,
                columns: new[] { "CreatedDateTime", "PublicationDate" },
                values: new object[] { new DateTime(2024, 8, 16, 14, 36, 27, 270, DateTimeKind.Utc).AddTicks(563), new DateTime(2024, 6, 13, 6, 20, 2, 573, DateTimeKind.Local).AddTicks(9457) });

            migrationBuilder.UpdateData(
                table: "Book",
                keyColumn: "BookId",
                keyValue: 1362,
                columns: new[] { "CreatedDateTime", "PublicationDate" },
                values: new object[] { new DateTime(2024, 8, 16, 14, 36, 27, 270, DateTimeKind.Utc).AddTicks(696), new DateTime(2024, 6, 15, 15, 50, 41, 827, DateTimeKind.Local).AddTicks(1638) });

            migrationBuilder.UpdateData(
                table: "Book",
                keyColumn: "BookId",
                keyValue: 1363,
                columns: new[] { "CreatedDateTime", "PublicationDate" },
                values: new object[] { new DateTime(2024, 8, 16, 14, 36, 27, 270, DateTimeKind.Utc).AddTicks(814), new DateTime(2024, 6, 11, 11, 11, 51, 434, DateTimeKind.Local).AddTicks(7945) });

            migrationBuilder.UpdateData(
                table: "Book",
                keyColumn: "BookId",
                keyValue: 1364,
                columns: new[] { "CreatedDateTime", "PublicationDate" },
                values: new object[] { new DateTime(2024, 8, 16, 14, 36, 27, 270, DateTimeKind.Utc).AddTicks(955), new DateTime(2023, 10, 9, 13, 31, 58, 389, DateTimeKind.Local).AddTicks(882) });

            migrationBuilder.UpdateData(
                table: "Book",
                keyColumn: "BookId",
                keyValue: 1365,
                columns: new[] { "CreatedDateTime", "PublicationDate" },
                values: new object[] { new DateTime(2024, 8, 16, 14, 36, 27, 270, DateTimeKind.Utc).AddTicks(1055), new DateTime(2024, 4, 5, 5, 50, 8, 623, DateTimeKind.Local).AddTicks(1952) });

            migrationBuilder.UpdateData(
                table: "Book",
                keyColumn: "BookId",
                keyValue: 1366,
                columns: new[] { "CreatedDateTime", "PublicationDate" },
                values: new object[] { new DateTime(2024, 8, 16, 14, 36, 27, 270, DateTimeKind.Utc).AddTicks(1206), new DateTime(2024, 6, 16, 9, 12, 24, 878, DateTimeKind.Local).AddTicks(6901) });

            migrationBuilder.UpdateData(
                table: "Book",
                keyColumn: "BookId",
                keyValue: 1367,
                columns: new[] { "CreatedDateTime", "PublicationDate" },
                values: new object[] { new DateTime(2024, 8, 16, 14, 36, 27, 270, DateTimeKind.Utc).AddTicks(1339), new DateTime(2024, 1, 19, 22, 23, 5, 865, DateTimeKind.Local).AddTicks(5363) });

            migrationBuilder.UpdateData(
                table: "Book",
                keyColumn: "BookId",
                keyValue: 1368,
                columns: new[] { "CreatedDateTime", "PublicationDate" },
                values: new object[] { new DateTime(2024, 8, 16, 14, 36, 27, 270, DateTimeKind.Utc).AddTicks(1442), new DateTime(2024, 7, 6, 1, 9, 45, 296, DateTimeKind.Local).AddTicks(1691) });

            migrationBuilder.UpdateData(
                table: "Book",
                keyColumn: "BookId",
                keyValue: 1369,
                columns: new[] { "CreatedDateTime", "PublicationDate" },
                values: new object[] { new DateTime(2024, 8, 16, 14, 36, 27, 270, DateTimeKind.Utc).AddTicks(1579), new DateTime(2024, 3, 16, 1, 22, 13, 383, DateTimeKind.Local).AddTicks(2924) });

            migrationBuilder.UpdateData(
                table: "Book",
                keyColumn: "BookId",
                keyValue: 1370,
                columns: new[] { "CreatedDateTime", "PublicationDate" },
                values: new object[] { new DateTime(2024, 8, 16, 14, 36, 27, 270, DateTimeKind.Utc).AddTicks(1694), new DateTime(2024, 5, 21, 16, 14, 10, 252, DateTimeKind.Local).AddTicks(7388) });

            migrationBuilder.UpdateData(
                table: "Book",
                keyColumn: "BookId",
                keyValue: 1371,
                columns: new[] { "CreatedDateTime", "PublicationDate" },
                values: new object[] { new DateTime(2024, 8, 16, 14, 36, 27, 270, DateTimeKind.Utc).AddTicks(1837), new DateTime(2024, 4, 18, 6, 26, 46, 237, DateTimeKind.Local).AddTicks(6277) });

            migrationBuilder.UpdateData(
                table: "Book",
                keyColumn: "BookId",
                keyValue: 1372,
                columns: new[] { "CreatedDateTime", "PublicationDate" },
                values: new object[] { new DateTime(2024, 8, 16, 14, 36, 27, 270, DateTimeKind.Utc).AddTicks(1996), new DateTime(2024, 1, 7, 18, 52, 17, 971, DateTimeKind.Local).AddTicks(1344) });

            migrationBuilder.UpdateData(
                table: "Book",
                keyColumn: "BookId",
                keyValue: 1373,
                columns: new[] { "CreatedDateTime", "PublicationDate" },
                values: new object[] { new DateTime(2024, 8, 16, 14, 36, 27, 270, DateTimeKind.Utc).AddTicks(2116), new DateTime(2023, 11, 28, 8, 56, 17, 518, DateTimeKind.Local).AddTicks(3076) });

            migrationBuilder.UpdateData(
                table: "Book",
                keyColumn: "BookId",
                keyValue: 1374,
                columns: new[] { "CreatedDateTime", "PublicationDate" },
                values: new object[] { new DateTime(2024, 8, 16, 14, 36, 27, 270, DateTimeKind.Utc).AddTicks(2271), new DateTime(2024, 4, 20, 0, 21, 54, 162, DateTimeKind.Local).AddTicks(2338) });

            migrationBuilder.UpdateData(
                table: "Book",
                keyColumn: "BookId",
                keyValue: 1375,
                columns: new[] { "CreatedDateTime", "PublicationDate" },
                values: new object[] { new DateTime(2024, 8, 16, 14, 36, 27, 270, DateTimeKind.Utc).AddTicks(2381), new DateTime(2023, 8, 26, 22, 12, 9, 132, DateTimeKind.Local).AddTicks(7741) });

            migrationBuilder.UpdateData(
                table: "Book",
                keyColumn: "BookId",
                keyValue: 1376,
                columns: new[] { "CreatedDateTime", "PublicationDate" },
                values: new object[] { new DateTime(2024, 8, 16, 14, 36, 27, 270, DateTimeKind.Utc).AddTicks(2515), new DateTime(2023, 10, 8, 13, 17, 59, 143, DateTimeKind.Local).AddTicks(6249) });

            migrationBuilder.UpdateData(
                table: "Book",
                keyColumn: "BookId",
                keyValue: 1377,
                columns: new[] { "CreatedDateTime", "PublicationDate" },
                values: new object[] { new DateTime(2024, 8, 16, 14, 36, 27, 270, DateTimeKind.Utc).AddTicks(2655), new DateTime(2023, 11, 12, 10, 28, 58, 840, DateTimeKind.Local).AddTicks(6793) });

            migrationBuilder.UpdateData(
                table: "Book",
                keyColumn: "BookId",
                keyValue: 1378,
                columns: new[] { "CreatedDateTime", "PublicationDate" },
                values: new object[] { new DateTime(2024, 8, 16, 14, 36, 27, 270, DateTimeKind.Utc).AddTicks(2755), new DateTime(2024, 1, 21, 13, 29, 16, 20, DateTimeKind.Local).AddTicks(7255) });

            migrationBuilder.UpdateData(
                table: "Book",
                keyColumn: "BookId",
                keyValue: 1379,
                columns: new[] { "CreatedDateTime", "PublicationDate" },
                values: new object[] { new DateTime(2024, 8, 16, 14, 36, 27, 270, DateTimeKind.Utc).AddTicks(2878), new DateTime(2024, 6, 9, 14, 28, 31, 418, DateTimeKind.Local).AddTicks(8782) });

            migrationBuilder.UpdateData(
                table: "Book",
                keyColumn: "BookId",
                keyValue: 1380,
                columns: new[] { "CreatedDateTime", "PublicationDate" },
                values: new object[] { new DateTime(2024, 8, 16, 14, 36, 27, 270, DateTimeKind.Utc).AddTicks(2998), new DateTime(2023, 10, 9, 23, 48, 36, 69, DateTimeKind.Local).AddTicks(1382) });

            migrationBuilder.UpdateData(
                table: "Book",
                keyColumn: "BookId",
                keyValue: 1381,
                columns: new[] { "CreatedDateTime", "PublicationDate" },
                values: new object[] { new DateTime(2024, 8, 16, 14, 36, 27, 270, DateTimeKind.Utc).AddTicks(3117), new DateTime(2023, 10, 7, 12, 19, 49, 59, DateTimeKind.Local).AddTicks(3357) });

            migrationBuilder.UpdateData(
                table: "Book",
                keyColumn: "BookId",
                keyValue: 1382,
                columns: new[] { "CreatedDateTime", "PublicationDate" },
                values: new object[] { new DateTime(2024, 8, 16, 14, 36, 27, 270, DateTimeKind.Utc).AddTicks(3228), new DateTime(2023, 12, 27, 10, 31, 20, 253, DateTimeKind.Local).AddTicks(4907) });

            migrationBuilder.UpdateData(
                table: "Book",
                keyColumn: "BookId",
                keyValue: 1383,
                columns: new[] { "CreatedDateTime", "PublicationDate" },
                values: new object[] { new DateTime(2024, 8, 16, 14, 36, 27, 270, DateTimeKind.Utc).AddTicks(3354), new DateTime(2023, 12, 18, 8, 57, 10, 747, DateTimeKind.Local).AddTicks(9921) });

            migrationBuilder.UpdateData(
                table: "Book",
                keyColumn: "BookId",
                keyValue: 1384,
                columns: new[] { "CreatedDateTime", "PublicationDate" },
                values: new object[] { new DateTime(2024, 8, 16, 14, 36, 27, 270, DateTimeKind.Utc).AddTicks(3461), new DateTime(2024, 1, 28, 19, 42, 55, 278, DateTimeKind.Local).AddTicks(7675) });

            migrationBuilder.UpdateData(
                table: "Book",
                keyColumn: "BookId",
                keyValue: 1385,
                columns: new[] { "CreatedDateTime", "PublicationDate" },
                values: new object[] { new DateTime(2024, 8, 16, 14, 36, 27, 270, DateTimeKind.Utc).AddTicks(3585), new DateTime(2024, 1, 12, 17, 28, 48, 263, DateTimeKind.Local).AddTicks(3177) });

            migrationBuilder.UpdateData(
                table: "Book",
                keyColumn: "BookId",
                keyValue: 1386,
                columns: new[] { "CreatedDateTime", "PublicationDate" },
                values: new object[] { new DateTime(2024, 8, 16, 14, 36, 27, 270, DateTimeKind.Utc).AddTicks(3675), new DateTime(2024, 8, 14, 16, 48, 46, 598, DateTimeKind.Local).AddTicks(1849) });

            migrationBuilder.UpdateData(
                table: "Book",
                keyColumn: "BookId",
                keyValue: 1387,
                columns: new[] { "CreatedDateTime", "PublicationDate" },
                values: new object[] { new DateTime(2024, 8, 16, 14, 36, 27, 270, DateTimeKind.Utc).AddTicks(3827), new DateTime(2023, 12, 19, 9, 43, 22, 59, DateTimeKind.Local).AddTicks(7028) });

            migrationBuilder.UpdateData(
                table: "Book",
                keyColumn: "BookId",
                keyValue: 1388,
                columns: new[] { "CreatedDateTime", "PublicationDate" },
                values: new object[] { new DateTime(2024, 8, 16, 14, 36, 27, 270, DateTimeKind.Utc).AddTicks(3920), new DateTime(2024, 6, 16, 19, 35, 49, 360, DateTimeKind.Local).AddTicks(7084) });

            migrationBuilder.UpdateData(
                table: "Book",
                keyColumn: "BookId",
                keyValue: 1389,
                columns: new[] { "CreatedDateTime", "PublicationDate" },
                values: new object[] { new DateTime(2024, 8, 16, 14, 36, 27, 270, DateTimeKind.Utc).AddTicks(4076), new DateTime(2024, 4, 12, 20, 44, 9, 154, DateTimeKind.Local).AddTicks(125) });

            migrationBuilder.UpdateData(
                table: "Book",
                keyColumn: "BookId",
                keyValue: 1390,
                columns: new[] { "CreatedDateTime", "PublicationDate" },
                values: new object[] { new DateTime(2024, 8, 16, 14, 36, 27, 270, DateTimeKind.Utc).AddTicks(4173), new DateTime(2023, 12, 1, 0, 24, 58, 315, DateTimeKind.Local).AddTicks(795) });

            migrationBuilder.UpdateData(
                table: "Book",
                keyColumn: "BookId",
                keyValue: 1391,
                columns: new[] { "CreatedDateTime", "PublicationDate" },
                values: new object[] { new DateTime(2024, 8, 16, 14, 36, 27, 270, DateTimeKind.Utc).AddTicks(4314), new DateTime(2024, 1, 24, 16, 30, 48, 669, DateTimeKind.Local).AddTicks(9523) });

            migrationBuilder.UpdateData(
                table: "Book",
                keyColumn: "BookId",
                keyValue: 1392,
                columns: new[] { "CreatedDateTime", "PublicationDate" },
                values: new object[] { new DateTime(2024, 8, 16, 14, 36, 27, 270, DateTimeKind.Utc).AddTicks(4417), new DateTime(2023, 11, 21, 23, 29, 51, 432, DateTimeKind.Local).AddTicks(4958) });

            migrationBuilder.UpdateData(
                table: "Book",
                keyColumn: "BookId",
                keyValue: 1393,
                columns: new[] { "CreatedDateTime", "PublicationDate" },
                values: new object[] { new DateTime(2024, 8, 16, 14, 36, 27, 270, DateTimeKind.Utc).AddTicks(4558), new DateTime(2024, 6, 19, 7, 54, 48, 259, DateTimeKind.Local).AddTicks(6210) });

            migrationBuilder.UpdateData(
                table: "Book",
                keyColumn: "BookId",
                keyValue: 1394,
                columns: new[] { "CreatedDateTime", "PublicationDate" },
                values: new object[] { new DateTime(2024, 8, 16, 14, 36, 27, 270, DateTimeKind.Utc).AddTicks(4702), new DateTime(2023, 11, 26, 19, 27, 20, 139, DateTimeKind.Local).AddTicks(3703) });

            migrationBuilder.UpdateData(
                table: "Book",
                keyColumn: "BookId",
                keyValue: 1395,
                columns: new[] { "CreatedDateTime", "PublicationDate" },
                values: new object[] { new DateTime(2024, 8, 16, 14, 36, 27, 270, DateTimeKind.Utc).AddTicks(4898), new DateTime(2024, 1, 23, 8, 2, 12, 176, DateTimeKind.Local).AddTicks(610) });

            migrationBuilder.UpdateData(
                table: "Book",
                keyColumn: "BookId",
                keyValue: 1396,
                columns: new[] { "CreatedDateTime", "PublicationDate" },
                values: new object[] { new DateTime(2024, 8, 16, 14, 36, 27, 270, DateTimeKind.Utc).AddTicks(5074), new DateTime(2023, 9, 6, 0, 23, 12, 773, DateTimeKind.Local).AddTicks(2770) });

            migrationBuilder.UpdateData(
                table: "Book",
                keyColumn: "BookId",
                keyValue: 1397,
                columns: new[] { "CreatedDateTime", "PublicationDate" },
                values: new object[] { new DateTime(2024, 8, 16, 14, 36, 27, 270, DateTimeKind.Utc).AddTicks(5237), new DateTime(2023, 10, 22, 22, 35, 48, 131, DateTimeKind.Local).AddTicks(3986) });

            migrationBuilder.UpdateData(
                table: "Book",
                keyColumn: "BookId",
                keyValue: 1398,
                columns: new[] { "CreatedDateTime", "PublicationDate" },
                values: new object[] { new DateTime(2024, 8, 16, 14, 36, 27, 270, DateTimeKind.Utc).AddTicks(5378), new DateTime(2024, 2, 20, 1, 40, 31, 517, DateTimeKind.Local).AddTicks(493) });

            migrationBuilder.UpdateData(
                table: "Book",
                keyColumn: "BookId",
                keyValue: 1399,
                columns: new[] { "CreatedDateTime", "PublicationDate" },
                values: new object[] { new DateTime(2024, 8, 16, 14, 36, 27, 270, DateTimeKind.Utc).AddTicks(5551), new DateTime(2024, 5, 5, 7, 50, 49, 998, DateTimeKind.Local).AddTicks(4926) });

            migrationBuilder.UpdateData(
                table: "Book",
                keyColumn: "BookId",
                keyValue: 1400,
                columns: new[] { "CreatedDateTime", "PublicationDate" },
                values: new object[] { new DateTime(2024, 8, 16, 14, 36, 27, 270, DateTimeKind.Utc).AddTicks(5740), new DateTime(2023, 9, 8, 3, 57, 11, 104, DateTimeKind.Local).AddTicks(3564) });

            migrationBuilder.UpdateData(
                table: "Book",
                keyColumn: "BookId",
                keyValue: 1401,
                columns: new[] { "CreatedDateTime", "PublicationDate" },
                values: new object[] { new DateTime(2024, 8, 16, 14, 36, 27, 270, DateTimeKind.Utc).AddTicks(5893), new DateTime(2024, 3, 21, 19, 18, 25, 943, DateTimeKind.Local).AddTicks(1472) });

            migrationBuilder.UpdateData(
                table: "Book",
                keyColumn: "BookId",
                keyValue: 1402,
                columns: new[] { "CreatedDateTime", "PublicationDate" },
                values: new object[] { new DateTime(2024, 8, 16, 14, 36, 27, 270, DateTimeKind.Utc).AddTicks(6091), new DateTime(2024, 7, 15, 8, 20, 22, 268, DateTimeKind.Local).AddTicks(9974) });

            migrationBuilder.UpdateData(
                table: "Book",
                keyColumn: "BookId",
                keyValue: 1403,
                columns: new[] { "CreatedDateTime", "PublicationDate" },
                values: new object[] { new DateTime(2024, 8, 16, 14, 36, 27, 270, DateTimeKind.Utc).AddTicks(6235), new DateTime(2024, 1, 14, 21, 35, 16, 669, DateTimeKind.Local).AddTicks(7272) });

            migrationBuilder.UpdateData(
                table: "Book",
                keyColumn: "BookId",
                keyValue: 1404,
                columns: new[] { "CreatedDateTime", "PublicationDate" },
                values: new object[] { new DateTime(2024, 8, 16, 14, 36, 27, 270, DateTimeKind.Utc).AddTicks(6434), new DateTime(2024, 1, 4, 21, 16, 36, 154, DateTimeKind.Local).AddTicks(5556) });

            migrationBuilder.UpdateData(
                table: "Book",
                keyColumn: "BookId",
                keyValue: 1405,
                columns: new[] { "CreatedDateTime", "PublicationDate" },
                values: new object[] { new DateTime(2024, 8, 16, 14, 36, 27, 270, DateTimeKind.Utc).AddTicks(6579), new DateTime(2024, 7, 3, 14, 53, 12, 39, DateTimeKind.Local).AddTicks(1036) });

            migrationBuilder.UpdateData(
                table: "Book",
                keyColumn: "BookId",
                keyValue: 1406,
                columns: new[] { "CreatedDateTime", "PublicationDate" },
                values: new object[] { new DateTime(2024, 8, 16, 14, 36, 27, 270, DateTimeKind.Utc).AddTicks(6748), new DateTime(2024, 3, 18, 12, 33, 28, 548, DateTimeKind.Local).AddTicks(7596) });

            migrationBuilder.UpdateData(
                table: "Book",
                keyColumn: "BookId",
                keyValue: 1407,
                columns: new[] { "CreatedDateTime", "PublicationDate" },
                values: new object[] { new DateTime(2024, 8, 16, 14, 36, 27, 270, DateTimeKind.Utc).AddTicks(6897), new DateTime(2024, 8, 12, 21, 25, 5, 422, DateTimeKind.Local).AddTicks(3737) });

            migrationBuilder.UpdateData(
                table: "Book",
                keyColumn: "BookId",
                keyValue: 1408,
                columns: new[] { "CreatedDateTime", "PublicationDate" },
                values: new object[] { new DateTime(2024, 8, 16, 14, 36, 27, 270, DateTimeKind.Utc).AddTicks(7094), new DateTime(2024, 1, 26, 20, 24, 32, 920, DateTimeKind.Local).AddTicks(2247) });

            migrationBuilder.UpdateData(
                table: "Book",
                keyColumn: "BookId",
                keyValue: 1409,
                columns: new[] { "CreatedDateTime", "PublicationDate" },
                values: new object[] { new DateTime(2024, 8, 16, 14, 36, 27, 270, DateTimeKind.Utc).AddTicks(7261), new DateTime(2024, 1, 25, 12, 57, 27, 535, DateTimeKind.Local).AddTicks(7802) });

            migrationBuilder.UpdateData(
                table: "Book",
                keyColumn: "BookId",
                keyValue: 1410,
                columns: new[] { "CreatedDateTime", "PublicationDate" },
                values: new object[] { new DateTime(2024, 8, 16, 14, 36, 27, 270, DateTimeKind.Utc).AddTicks(7454), new DateTime(2024, 2, 7, 0, 5, 10, 382, DateTimeKind.Local).AddTicks(3617) });

            migrationBuilder.UpdateData(
                table: "Book",
                keyColumn: "BookId",
                keyValue: 1411,
                columns: new[] { "CreatedDateTime", "PublicationDate" },
                values: new object[] { new DateTime(2024, 8, 16, 14, 36, 27, 270, DateTimeKind.Utc).AddTicks(7607), new DateTime(2024, 4, 20, 19, 43, 32, 495, DateTimeKind.Local).AddTicks(2002) });

            migrationBuilder.UpdateData(
                table: "Book",
                keyColumn: "BookId",
                keyValue: 1412,
                columns: new[] { "CreatedDateTime", "PublicationDate" },
                values: new object[] { new DateTime(2024, 8, 16, 14, 36, 27, 270, DateTimeKind.Utc).AddTicks(7800), new DateTime(2024, 7, 17, 11, 26, 5, 965, DateTimeKind.Local).AddTicks(3184) });

            migrationBuilder.UpdateData(
                table: "Book",
                keyColumn: "BookId",
                keyValue: 1413,
                columns: new[] { "CreatedDateTime", "PublicationDate" },
                values: new object[] { new DateTime(2024, 8, 16, 14, 36, 27, 270, DateTimeKind.Utc).AddTicks(7952), new DateTime(2024, 3, 17, 5, 28, 44, 685, DateTimeKind.Local).AddTicks(9312) });

            migrationBuilder.UpdateData(
                table: "Book",
                keyColumn: "BookId",
                keyValue: 1414,
                columns: new[] { "CreatedDateTime", "PublicationDate" },
                values: new object[] { new DateTime(2024, 8, 16, 14, 36, 27, 270, DateTimeKind.Utc).AddTicks(8145), new DateTime(2024, 1, 12, 3, 37, 24, 435, DateTimeKind.Local).AddTicks(1139) });

            migrationBuilder.UpdateData(
                table: "Book",
                keyColumn: "BookId",
                keyValue: 1415,
                columns: new[] { "CreatedDateTime", "PublicationDate" },
                values: new object[] { new DateTime(2024, 8, 16, 14, 36, 27, 270, DateTimeKind.Utc).AddTicks(8312), new DateTime(2024, 8, 8, 15, 29, 1, 750, DateTimeKind.Local).AddTicks(85) });

            migrationBuilder.UpdateData(
                table: "Book",
                keyColumn: "BookId",
                keyValue: 1416,
                columns: new[] { "CreatedDateTime", "PublicationDate" },
                values: new object[] { new DateTime(2024, 8, 16, 14, 36, 27, 270, DateTimeKind.Utc).AddTicks(8491), new DateTime(2024, 1, 7, 16, 0, 19, 625, DateTimeKind.Local).AddTicks(5781) });

            migrationBuilder.UpdateData(
                table: "Book",
                keyColumn: "BookId",
                keyValue: 1417,
                columns: new[] { "CreatedDateTime", "PublicationDate" },
                values: new object[] { new DateTime(2024, 8, 16, 14, 36, 27, 270, DateTimeKind.Utc).AddTicks(8659), new DateTime(2023, 11, 18, 9, 41, 1, 380, DateTimeKind.Local).AddTicks(4941) });

            migrationBuilder.UpdateData(
                table: "Book",
                keyColumn: "BookId",
                keyValue: 1418,
                columns: new[] { "CreatedDateTime", "PublicationDate" },
                values: new object[] { new DateTime(2024, 8, 16, 14, 36, 27, 270, DateTimeKind.Utc).AddTicks(8883), new DateTime(2024, 4, 18, 14, 34, 49, 613, DateTimeKind.Local).AddTicks(6075) });

            migrationBuilder.UpdateData(
                table: "Book",
                keyColumn: "BookId",
                keyValue: 1419,
                columns: new[] { "CreatedDateTime", "PublicationDate" },
                values: new object[] { new DateTime(2024, 8, 16, 14, 36, 27, 270, DateTimeKind.Utc).AddTicks(9033), new DateTime(2024, 5, 9, 22, 45, 54, 333, DateTimeKind.Local).AddTicks(8489) });

            migrationBuilder.UpdateData(
                table: "Book",
                keyColumn: "BookId",
                keyValue: 1420,
                columns: new[] { "CreatedDateTime", "PublicationDate" },
                values: new object[] { new DateTime(2024, 8, 16, 14, 36, 27, 270, DateTimeKind.Utc).AddTicks(9252), new DateTime(2023, 9, 4, 1, 13, 19, 174, DateTimeKind.Local).AddTicks(8553) });

            migrationBuilder.UpdateData(
                table: "Book",
                keyColumn: "BookId",
                keyValue: 1421,
                columns: new[] { "CreatedDateTime", "PublicationDate" },
                values: new object[] { new DateTime(2024, 8, 16, 14, 36, 27, 270, DateTimeKind.Utc).AddTicks(9464), new DateTime(2023, 9, 2, 1, 45, 38, 888, DateTimeKind.Local).AddTicks(265) });

            migrationBuilder.UpdateData(
                table: "Book",
                keyColumn: "BookId",
                keyValue: 1422,
                columns: new[] { "CreatedDateTime", "PublicationDate" },
                values: new object[] { new DateTime(2024, 8, 16, 14, 36, 27, 270, DateTimeKind.Utc).AddTicks(9603), new DateTime(2024, 7, 21, 20, 55, 13, 18, DateTimeKind.Local).AddTicks(7627) });

            migrationBuilder.UpdateData(
                table: "Book",
                keyColumn: "BookId",
                keyValue: 1423,
                columns: new[] { "CreatedDateTime", "PublicationDate" },
                values: new object[] { new DateTime(2024, 8, 16, 14, 36, 27, 270, DateTimeKind.Utc).AddTicks(9801), new DateTime(2024, 1, 11, 4, 30, 20, 491, DateTimeKind.Local).AddTicks(9603) });

            migrationBuilder.UpdateData(
                table: "Book",
                keyColumn: "BookId",
                keyValue: 1424,
                columns: new[] { "CreatedDateTime", "PublicationDate" },
                values: new object[] { new DateTime(2024, 8, 16, 14, 36, 27, 270, DateTimeKind.Utc).AddTicks(9948), new DateTime(2024, 2, 5, 4, 48, 37, 713, DateTimeKind.Local).AddTicks(5047) });

            migrationBuilder.UpdateData(
                table: "Book",
                keyColumn: "BookId",
                keyValue: 1425,
                columns: new[] { "CreatedDateTime", "PublicationDate" },
                values: new object[] { new DateTime(2024, 8, 16, 14, 36, 27, 271, DateTimeKind.Utc).AddTicks(151), new DateTime(2024, 4, 28, 1, 8, 38, 38, DateTimeKind.Local).AddTicks(1425) });

            migrationBuilder.UpdateData(
                table: "Book",
                keyColumn: "BookId",
                keyValue: 1426,
                columns: new[] { "CreatedDateTime", "PublicationDate" },
                values: new object[] { new DateTime(2024, 8, 16, 14, 36, 27, 271, DateTimeKind.Utc).AddTicks(309), new DateTime(2023, 12, 23, 14, 4, 28, 547, DateTimeKind.Local).AddTicks(8269) });

            migrationBuilder.UpdateData(
                table: "Book",
                keyColumn: "BookId",
                keyValue: 1427,
                columns: new[] { "CreatedDateTime", "PublicationDate" },
                values: new object[] { new DateTime(2024, 8, 16, 14, 36, 27, 271, DateTimeKind.Utc).AddTicks(488), new DateTime(2024, 7, 5, 20, 1, 59, 795, DateTimeKind.Local).AddTicks(2927) });

            migrationBuilder.UpdateData(
                table: "Book",
                keyColumn: "BookId",
                keyValue: 1428,
                columns: new[] { "CreatedDateTime", "PublicationDate" },
                values: new object[] { new DateTime(2024, 8, 16, 14, 36, 27, 271, DateTimeKind.Utc).AddTicks(643), new DateTime(2024, 3, 21, 11, 37, 56, 531, DateTimeKind.Local).AddTicks(8540) });

            migrationBuilder.UpdateData(
                table: "Book",
                keyColumn: "BookId",
                keyValue: 1429,
                columns: new[] { "CreatedDateTime", "PublicationDate" },
                values: new object[] { new DateTime(2024, 8, 16, 14, 36, 27, 271, DateTimeKind.Utc).AddTicks(776), new DateTime(2023, 9, 26, 18, 22, 59, 853, DateTimeKind.Local).AddTicks(6498) });

            migrationBuilder.UpdateData(
                table: "Book",
                keyColumn: "BookId",
                keyValue: 1430,
                columns: new[] { "CreatedDateTime", "PublicationDate" },
                values: new object[] { new DateTime(2024, 8, 16, 14, 36, 27, 271, DateTimeKind.Utc).AddTicks(961), new DateTime(2024, 7, 25, 17, 21, 3, 11, DateTimeKind.Local).AddTicks(4220) });

            migrationBuilder.UpdateData(
                table: "Book",
                keyColumn: "BookId",
                keyValue: 1431,
                columns: new[] { "CreatedDateTime", "PublicationDate" },
                values: new object[] { new DateTime(2024, 8, 16, 14, 36, 27, 271, DateTimeKind.Utc).AddTicks(1096), new DateTime(2024, 3, 22, 21, 5, 15, 927, DateTimeKind.Local).AddTicks(9349) });

            migrationBuilder.UpdateData(
                table: "Book",
                keyColumn: "BookId",
                keyValue: 1432,
                columns: new[] { "CreatedDateTime", "PublicationDate" },
                values: new object[] { new DateTime(2024, 8, 16, 14, 36, 27, 271, DateTimeKind.Utc).AddTicks(1269), new DateTime(2024, 5, 28, 13, 3, 7, 696, DateTimeKind.Local).AddTicks(3959) });

            migrationBuilder.UpdateData(
                table: "Book",
                keyColumn: "BookId",
                keyValue: 1433,
                columns: new[] { "CreatedDateTime", "PublicationDate" },
                values: new object[] { new DateTime(2024, 8, 16, 14, 36, 27, 271, DateTimeKind.Utc).AddTicks(1513), new DateTime(2024, 4, 30, 21, 3, 0, 91, DateTimeKind.Local).AddTicks(5395) });

            migrationBuilder.UpdateData(
                table: "Book",
                keyColumn: "BookId",
                keyValue: 1434,
                columns: new[] { "CreatedDateTime", "PublicationDate" },
                values: new object[] { new DateTime(2024, 8, 16, 14, 36, 27, 271, DateTimeKind.Utc).AddTicks(1702), new DateTime(2024, 4, 19, 20, 43, 14, 293, DateTimeKind.Local).AddTicks(9680) });

            migrationBuilder.UpdateData(
                table: "Book",
                keyColumn: "BookId",
                keyValue: 1435,
                columns: new[] { "CreatedDateTime", "PublicationDate" },
                values: new object[] { new DateTime(2024, 8, 16, 14, 36, 27, 271, DateTimeKind.Utc).AddTicks(1907), new DateTime(2024, 8, 3, 17, 54, 1, 581, DateTimeKind.Local).AddTicks(2348) });

            migrationBuilder.UpdateData(
                table: "Book",
                keyColumn: "BookId",
                keyValue: 1436,
                columns: new[] { "CreatedDateTime", "PublicationDate" },
                values: new object[] { new DateTime(2024, 8, 16, 14, 36, 27, 271, DateTimeKind.Utc).AddTicks(2067), new DateTime(2024, 1, 19, 0, 21, 15, 620, DateTimeKind.Local).AddTicks(8422) });

            migrationBuilder.UpdateData(
                table: "Book",
                keyColumn: "BookId",
                keyValue: 1437,
                columns: new[] { "CreatedDateTime", "PublicationDate" },
                values: new object[] { new DateTime(2024, 8, 16, 14, 36, 27, 271, DateTimeKind.Utc).AddTicks(2254), new DateTime(2023, 8, 26, 16, 20, 38, 47, DateTimeKind.Local).AddTicks(1866) });

            migrationBuilder.UpdateData(
                table: "Book",
                keyColumn: "BookId",
                keyValue: 1438,
                columns: new[] { "CreatedDateTime", "PublicationDate" },
                values: new object[] { new DateTime(2024, 8, 16, 14, 36, 27, 271, DateTimeKind.Utc).AddTicks(2411), new DateTime(2023, 11, 15, 21, 47, 19, 912, DateTimeKind.Local).AddTicks(2862) });

            migrationBuilder.UpdateData(
                table: "Book",
                keyColumn: "BookId",
                keyValue: 1439,
                columns: new[] { "CreatedDateTime", "PublicationDate" },
                values: new object[] { new DateTime(2024, 8, 16, 14, 36, 27, 271, DateTimeKind.Utc).AddTicks(2591), new DateTime(2024, 3, 24, 10, 51, 8, 176, DateTimeKind.Local).AddTicks(8538) });

            migrationBuilder.UpdateData(
                table: "Book",
                keyColumn: "BookId",
                keyValue: 1440,
                columns: new[] { "CreatedDateTime", "PublicationDate" },
                values: new object[] { new DateTime(2024, 8, 16, 14, 36, 27, 271, DateTimeKind.Utc).AddTicks(2749), new DateTime(2024, 3, 3, 17, 15, 53, 364, DateTimeKind.Local).AddTicks(7639) });

            migrationBuilder.UpdateData(
                table: "Book",
                keyColumn: "BookId",
                keyValue: 1441,
                columns: new[] { "CreatedDateTime", "PublicationDate" },
                values: new object[] { new DateTime(2024, 8, 16, 14, 36, 27, 271, DateTimeKind.Utc).AddTicks(2933), new DateTime(2023, 9, 27, 16, 11, 45, 254, DateTimeKind.Local).AddTicks(4069) });

            migrationBuilder.UpdateData(
                table: "Book",
                keyColumn: "BookId",
                keyValue: 1442,
                columns: new[] { "CreatedDateTime", "PublicationDate" },
                values: new object[] { new DateTime(2024, 8, 16, 14, 36, 27, 271, DateTimeKind.Utc).AddTicks(3071), new DateTime(2024, 3, 31, 5, 35, 25, 374, DateTimeKind.Local).AddTicks(1090) });

            migrationBuilder.UpdateData(
                table: "Book",
                keyColumn: "BookId",
                keyValue: 1443,
                columns: new[] { "CreatedDateTime", "PublicationDate" },
                values: new object[] { new DateTime(2024, 8, 16, 14, 36, 27, 271, DateTimeKind.Utc).AddTicks(3242), new DateTime(2024, 1, 16, 1, 52, 6, 819, DateTimeKind.Local).AddTicks(316) });

            migrationBuilder.UpdateData(
                table: "Book",
                keyColumn: "BookId",
                keyValue: 1444,
                columns: new[] { "CreatedDateTime", "PublicationDate" },
                values: new object[] { new DateTime(2024, 8, 16, 14, 36, 27, 271, DateTimeKind.Utc).AddTicks(3395), new DateTime(2023, 10, 14, 2, 43, 42, 287, DateTimeKind.Local).AddTicks(5164) });

            migrationBuilder.UpdateData(
                table: "Book",
                keyColumn: "BookId",
                keyValue: 1445,
                columns: new[] { "CreatedDateTime", "PublicationDate" },
                values: new object[] { new DateTime(2024, 8, 16, 14, 36, 27, 271, DateTimeKind.Utc).AddTicks(3585), new DateTime(2024, 3, 20, 15, 13, 9, 137, DateTimeKind.Local).AddTicks(3534) });

            migrationBuilder.UpdateData(
                table: "Book",
                keyColumn: "BookId",
                keyValue: 1446,
                columns: new[] { "CreatedDateTime", "PublicationDate" },
                values: new object[] { new DateTime(2024, 8, 16, 14, 36, 27, 271, DateTimeKind.Utc).AddTicks(3735), new DateTime(2024, 4, 30, 3, 56, 7, 760, DateTimeKind.Local).AddTicks(6203) });

            migrationBuilder.UpdateData(
                table: "Book",
                keyColumn: "BookId",
                keyValue: 1447,
                columns: new[] { "CreatedDateTime", "PublicationDate" },
                values: new object[] { new DateTime(2024, 8, 16, 14, 36, 27, 271, DateTimeKind.Utc).AddTicks(3899), new DateTime(2023, 10, 10, 3, 42, 30, 397, DateTimeKind.Local).AddTicks(132) });

            migrationBuilder.UpdateData(
                table: "Book",
                keyColumn: "BookId",
                keyValue: 1448,
                columns: new[] { "CreatedDateTime", "PublicationDate" },
                values: new object[] { new DateTime(2024, 8, 16, 14, 36, 27, 271, DateTimeKind.Utc).AddTicks(4045), new DateTime(2023, 10, 17, 13, 35, 37, 484, DateTimeKind.Local).AddTicks(6103) });

            migrationBuilder.UpdateData(
                table: "Book",
                keyColumn: "BookId",
                keyValue: 1449,
                columns: new[] { "CreatedDateTime", "PublicationDate" },
                values: new object[] { new DateTime(2024, 8, 16, 14, 36, 27, 271, DateTimeKind.Utc).AddTicks(4237), new DateTime(2024, 6, 28, 4, 7, 11, 124, DateTimeKind.Local).AddTicks(1595) });

            migrationBuilder.UpdateData(
                table: "Book",
                keyColumn: "BookId",
                keyValue: 1450,
                columns: new[] { "CreatedDateTime", "PublicationDate" },
                values: new object[] { new DateTime(2024, 8, 16, 14, 36, 27, 271, DateTimeKind.Utc).AddTicks(4377), new DateTime(2024, 4, 29, 11, 34, 27, 937, DateTimeKind.Local).AddTicks(9523) });

            migrationBuilder.UpdateData(
                table: "Book",
                keyColumn: "BookId",
                keyValue: 1451,
                columns: new[] { "CreatedDateTime", "PublicationDate" },
                values: new object[] { new DateTime(2024, 8, 16, 14, 36, 27, 271, DateTimeKind.Utc).AddTicks(4581), new DateTime(2024, 1, 31, 8, 38, 58, 483, DateTimeKind.Local).AddTicks(6267) });

            migrationBuilder.UpdateData(
                table: "Book",
                keyColumn: "BookId",
                keyValue: 1452,
                columns: new[] { "CreatedDateTime", "PublicationDate" },
                values: new object[] { new DateTime(2024, 8, 16, 14, 36, 27, 271, DateTimeKind.Utc).AddTicks(4717), new DateTime(2024, 5, 15, 11, 21, 19, 271, DateTimeKind.Local).AddTicks(110) });

            migrationBuilder.UpdateData(
                table: "Book",
                keyColumn: "BookId",
                keyValue: 1453,
                columns: new[] { "CreatedDateTime", "PublicationDate" },
                values: new object[] { new DateTime(2024, 8, 16, 14, 36, 27, 271, DateTimeKind.Utc).AddTicks(4929), new DateTime(2024, 5, 30, 8, 42, 48, 846, DateTimeKind.Local).AddTicks(4458) });

            migrationBuilder.UpdateData(
                table: "Book",
                keyColumn: "BookId",
                keyValue: 1454,
                columns: new[] { "CreatedDateTime", "PublicationDate" },
                values: new object[] { new DateTime(2024, 8, 16, 14, 36, 27, 271, DateTimeKind.Utc).AddTicks(5086), new DateTime(2024, 6, 19, 8, 33, 3, 247, DateTimeKind.Local).AddTicks(1466) });

            migrationBuilder.UpdateData(
                table: "Book",
                keyColumn: "BookId",
                keyValue: 1455,
                columns: new[] { "CreatedDateTime", "PublicationDate" },
                values: new object[] { new DateTime(2024, 8, 16, 14, 36, 27, 271, DateTimeKind.Utc).AddTicks(5280), new DateTime(2024, 7, 3, 6, 37, 4, 495, DateTimeKind.Local).AddTicks(9252) });

            migrationBuilder.UpdateData(
                table: "Book",
                keyColumn: "BookId",
                keyValue: 1456,
                columns: new[] { "CreatedDateTime", "PublicationDate" },
                values: new object[] { new DateTime(2024, 8, 16, 14, 36, 27, 271, DateTimeKind.Utc).AddTicks(5416), new DateTime(2023, 11, 9, 8, 49, 45, 170, DateTimeKind.Local).AddTicks(8123) });

            migrationBuilder.UpdateData(
                table: "Book",
                keyColumn: "BookId",
                keyValue: 1457,
                columns: new[] { "CreatedDateTime", "PublicationDate" },
                values: new object[] { new DateTime(2024, 8, 16, 14, 36, 27, 271, DateTimeKind.Utc).AddTicks(5591), new DateTime(2024, 8, 16, 9, 48, 43, 519, DateTimeKind.Local).AddTicks(3295) });

            migrationBuilder.UpdateData(
                table: "Book",
                keyColumn: "BookId",
                keyValue: 1458,
                columns: new[] { "CreatedDateTime", "PublicationDate" },
                values: new object[] { new DateTime(2024, 8, 16, 14, 36, 27, 271, DateTimeKind.Utc).AddTicks(5743), new DateTime(2024, 2, 23, 3, 37, 32, 274, DateTimeKind.Local).AddTicks(8191) });

            migrationBuilder.UpdateData(
                table: "Book",
                keyColumn: "BookId",
                keyValue: 1459,
                columns: new[] { "CreatedDateTime", "PublicationDate" },
                values: new object[] { new DateTime(2024, 8, 16, 14, 36, 27, 271, DateTimeKind.Utc).AddTicks(5926), new DateTime(2024, 8, 3, 18, 2, 29, 60, DateTimeKind.Local).AddTicks(5962) });

            migrationBuilder.UpdateData(
                table: "Book",
                keyColumn: "BookId",
                keyValue: 1460,
                columns: new[] { "CreatedDateTime", "PublicationDate" },
                values: new object[] { new DateTime(2024, 8, 16, 14, 36, 27, 271, DateTimeKind.Utc).AddTicks(6063), new DateTime(2023, 12, 12, 19, 58, 46, 741, DateTimeKind.Local).AddTicks(5783) });

            migrationBuilder.UpdateData(
                table: "Book",
                keyColumn: "BookId",
                keyValue: 1461,
                columns: new[] { "CreatedDateTime", "PublicationDate" },
                values: new object[] { new DateTime(2024, 8, 16, 14, 36, 27, 271, DateTimeKind.Utc).AddTicks(6235), new DateTime(2024, 6, 11, 9, 56, 20, 570, DateTimeKind.Local).AddTicks(8653) });

            migrationBuilder.UpdateData(
                table: "Book",
                keyColumn: "BookId",
                keyValue: 1462,
                columns: new[] { "CreatedDateTime", "PublicationDate" },
                values: new object[] { new DateTime(2024, 8, 16, 14, 36, 27, 271, DateTimeKind.Utc).AddTicks(6356), new DateTime(2023, 8, 17, 10, 8, 9, 520, DateTimeKind.Local).AddTicks(445) });

            migrationBuilder.UpdateData(
                table: "Book",
                keyColumn: "BookId",
                keyValue: 1463,
                columns: new[] { "CreatedDateTime", "PublicationDate" },
                values: new object[] { new DateTime(2024, 8, 16, 14, 36, 27, 271, DateTimeKind.Utc).AddTicks(6525), new DateTime(2023, 12, 22, 13, 50, 31, 953, DateTimeKind.Local).AddTicks(3869) });

            migrationBuilder.UpdateData(
                table: "Book",
                keyColumn: "BookId",
                keyValue: 1464,
                columns: new[] { "CreatedDateTime", "PublicationDate" },
                values: new object[] { new DateTime(2024, 8, 16, 14, 36, 27, 271, DateTimeKind.Utc).AddTicks(6654), new DateTime(2024, 7, 18, 16, 14, 50, 230, DateTimeKind.Local).AddTicks(6842) });

            migrationBuilder.UpdateData(
                table: "Book",
                keyColumn: "BookId",
                keyValue: 1465,
                columns: new[] { "CreatedDateTime", "PublicationDate" },
                values: new object[] { new DateTime(2024, 8, 16, 14, 36, 27, 271, DateTimeKind.Utc).AddTicks(6815), new DateTime(2023, 12, 27, 3, 44, 16, 208, DateTimeKind.Local).AddTicks(1949) });

            migrationBuilder.UpdateData(
                table: "Book",
                keyColumn: "BookId",
                keyValue: 1466,
                columns: new[] { "CreatedDateTime", "PublicationDate" },
                values: new object[] { new DateTime(2024, 8, 16, 14, 36, 27, 271, DateTimeKind.Utc).AddTicks(6931), new DateTime(2023, 11, 4, 2, 14, 9, 434, DateTimeKind.Local).AddTicks(5986) });

            migrationBuilder.UpdateData(
                table: "Book",
                keyColumn: "BookId",
                keyValue: 1467,
                columns: new[] { "CreatedDateTime", "PublicationDate" },
                values: new object[] { new DateTime(2024, 8, 16, 14, 36, 27, 271, DateTimeKind.Utc).AddTicks(7100), new DateTime(2024, 1, 28, 16, 59, 2, 678, DateTimeKind.Local).AddTicks(3003) });

            migrationBuilder.UpdateData(
                table: "Book",
                keyColumn: "BookId",
                keyValue: 1468,
                columns: new[] { "CreatedDateTime", "PublicationDate" },
                values: new object[] { new DateTime(2024, 8, 16, 14, 36, 27, 271, DateTimeKind.Utc).AddTicks(7270), new DateTime(2023, 12, 16, 9, 24, 47, 780, DateTimeKind.Local).AddTicks(4292) });

            migrationBuilder.UpdateData(
                table: "Book",
                keyColumn: "BookId",
                keyValue: 1469,
                columns: new[] { "CreatedDateTime", "PublicationDate" },
                values: new object[] { new DateTime(2024, 8, 16, 14, 36, 27, 271, DateTimeKind.Utc).AddTicks(7388), new DateTime(2024, 3, 9, 0, 33, 53, 976, DateTimeKind.Local).AddTicks(8605) });

            migrationBuilder.UpdateData(
                table: "Book",
                keyColumn: "BookId",
                keyValue: 1470,
                columns: new[] { "CreatedDateTime", "PublicationDate" },
                values: new object[] { new DateTime(2024, 8, 16, 14, 36, 27, 271, DateTimeKind.Utc).AddTicks(7509), new DateTime(2024, 7, 11, 5, 45, 12, 677, DateTimeKind.Local).AddTicks(996) });

            migrationBuilder.UpdateData(
                table: "Book",
                keyColumn: "BookId",
                keyValue: 1471,
                columns: new[] { "CreatedDateTime", "PublicationDate" },
                values: new object[] { new DateTime(2024, 8, 16, 14, 36, 27, 271, DateTimeKind.Utc).AddTicks(7667), new DateTime(2024, 4, 26, 14, 18, 3, 1, DateTimeKind.Local).AddTicks(8769) });

            migrationBuilder.UpdateData(
                table: "Book",
                keyColumn: "BookId",
                keyValue: 1472,
                columns: new[] { "CreatedDateTime", "PublicationDate" },
                values: new object[] { new DateTime(2024, 8, 16, 14, 36, 27, 271, DateTimeKind.Utc).AddTicks(7779), new DateTime(2023, 12, 4, 5, 25, 29, 760, DateTimeKind.Local).AddTicks(1050) });

            migrationBuilder.UpdateData(
                table: "Book",
                keyColumn: "BookId",
                keyValue: 1473,
                columns: new[] { "CreatedDateTime", "PublicationDate" },
                values: new object[] { new DateTime(2024, 8, 16, 14, 36, 27, 271, DateTimeKind.Utc).AddTicks(7921), new DateTime(2024, 4, 27, 2, 50, 14, 555, DateTimeKind.Local).AddTicks(780) });

            migrationBuilder.UpdateData(
                table: "Book",
                keyColumn: "BookId",
                keyValue: 1474,
                columns: new[] { "CreatedDateTime", "PublicationDate" },
                values: new object[] { new DateTime(2024, 8, 16, 14, 36, 27, 271, DateTimeKind.Utc).AddTicks(8058), new DateTime(2023, 9, 16, 8, 11, 31, 149, DateTimeKind.Local).AddTicks(9597) });

            migrationBuilder.UpdateData(
                table: "Book",
                keyColumn: "BookId",
                keyValue: 1475,
                columns: new[] { "CreatedDateTime", "PublicationDate" },
                values: new object[] { new DateTime(2024, 8, 16, 14, 36, 27, 271, DateTimeKind.Utc).AddTicks(8192), new DateTime(2023, 8, 23, 10, 11, 11, 584, DateTimeKind.Local).AddTicks(8970) });

            migrationBuilder.UpdateData(
                table: "Book",
                keyColumn: "BookId",
                keyValue: 1476,
                columns: new[] { "CreatedDateTime", "PublicationDate" },
                values: new object[] { new DateTime(2024, 8, 16, 14, 36, 27, 271, DateTimeKind.Utc).AddTicks(8315), new DateTime(2023, 11, 11, 3, 39, 10, 382, DateTimeKind.Local).AddTicks(2869) });

            migrationBuilder.UpdateData(
                table: "Book",
                keyColumn: "BookId",
                keyValue: 1477,
                columns: new[] { "CreatedDateTime", "PublicationDate" },
                values: new object[] { new DateTime(2024, 8, 16, 14, 36, 27, 271, DateTimeKind.Utc).AddTicks(8476), new DateTime(2024, 2, 20, 21, 37, 40, 311, DateTimeKind.Local).AddTicks(1620) });

            migrationBuilder.UpdateData(
                table: "Book",
                keyColumn: "BookId",
                keyValue: 1478,
                columns: new[] { "CreatedDateTime", "PublicationDate" },
                values: new object[] { new DateTime(2024, 8, 16, 14, 36, 27, 271, DateTimeKind.Utc).AddTicks(8596), new DateTime(2024, 5, 18, 1, 5, 35, 751, DateTimeKind.Local).AddTicks(6681) });

            migrationBuilder.UpdateData(
                table: "Book",
                keyColumn: "BookId",
                keyValue: 1479,
                columns: new[] { "CreatedDateTime", "PublicationDate" },
                values: new object[] { new DateTime(2024, 8, 16, 14, 36, 27, 271, DateTimeKind.Utc).AddTicks(8807), new DateTime(2023, 12, 3, 14, 39, 36, 363, DateTimeKind.Local).AddTicks(9991) });

            migrationBuilder.UpdateData(
                table: "Book",
                keyColumn: "BookId",
                keyValue: 1480,
                columns: new[] { "CreatedDateTime", "PublicationDate" },
                values: new object[] { new DateTime(2024, 8, 16, 14, 36, 27, 271, DateTimeKind.Utc).AddTicks(8943), new DateTime(2023, 12, 2, 1, 22, 15, 404, DateTimeKind.Local).AddTicks(4548) });

            migrationBuilder.UpdateData(
                table: "Book",
                keyColumn: "BookId",
                keyValue: 1481,
                columns: new[] { "CreatedDateTime", "PublicationDate" },
                values: new object[] { new DateTime(2024, 8, 16, 14, 36, 27, 271, DateTimeKind.Utc).AddTicks(9110), new DateTime(2024, 6, 14, 3, 13, 12, 468, DateTimeKind.Local).AddTicks(7850) });

            migrationBuilder.UpdateData(
                table: "Book",
                keyColumn: "BookId",
                keyValue: 1482,
                columns: new[] { "CreatedDateTime", "PublicationDate" },
                values: new object[] { new DateTime(2024, 8, 16, 14, 36, 27, 271, DateTimeKind.Utc).AddTicks(9239), new DateTime(2023, 12, 8, 4, 1, 25, 413, DateTimeKind.Local).AddTicks(2806) });

            migrationBuilder.UpdateData(
                table: "Book",
                keyColumn: "BookId",
                keyValue: 1483,
                columns: new[] { "CreatedDateTime", "PublicationDate" },
                values: new object[] { new DateTime(2024, 8, 16, 14, 36, 27, 271, DateTimeKind.Utc).AddTicks(9403), new DateTime(2024, 2, 16, 18, 31, 18, 731, DateTimeKind.Local).AddTicks(5058) });

            migrationBuilder.UpdateData(
                table: "Book",
                keyColumn: "BookId",
                keyValue: 1484,
                columns: new[] { "CreatedDateTime", "PublicationDate" },
                values: new object[] { new DateTime(2024, 8, 16, 14, 36, 27, 271, DateTimeKind.Utc).AddTicks(9563), new DateTime(2024, 1, 5, 23, 22, 47, 821, DateTimeKind.Local).AddTicks(2181) });

            migrationBuilder.UpdateData(
                table: "Book",
                keyColumn: "BookId",
                keyValue: 1485,
                columns: new[] { "CreatedDateTime", "PublicationDate" },
                values: new object[] { new DateTime(2024, 8, 16, 14, 36, 27, 271, DateTimeKind.Utc).AddTicks(9685), new DateTime(2023, 11, 25, 1, 1, 14, 969, DateTimeKind.Local).AddTicks(6381) });

            migrationBuilder.UpdateData(
                table: "Book",
                keyColumn: "BookId",
                keyValue: 1486,
                columns: new[] { "CreatedDateTime", "PublicationDate" },
                values: new object[] { new DateTime(2024, 8, 16, 14, 36, 27, 271, DateTimeKind.Utc).AddTicks(9801), new DateTime(2024, 4, 1, 13, 56, 2, 927, DateTimeKind.Local).AddTicks(4606) });

            migrationBuilder.UpdateData(
                table: "Book",
                keyColumn: "BookId",
                keyValue: 1487,
                columns: new[] { "CreatedDateTime", "PublicationDate" },
                values: new object[] { new DateTime(2024, 8, 16, 14, 36, 27, 271, DateTimeKind.Utc).AddTicks(9966), new DateTime(2024, 2, 26, 14, 51, 44, 576, DateTimeKind.Local).AddTicks(1802) });

            migrationBuilder.UpdateData(
                table: "Book",
                keyColumn: "BookId",
                keyValue: 1488,
                columns: new[] { "CreatedDateTime", "PublicationDate" },
                values: new object[] { new DateTime(2024, 8, 16, 14, 36, 27, 272, DateTimeKind.Utc).AddTicks(124), new DateTime(2023, 11, 10, 4, 38, 2, 585, DateTimeKind.Local).AddTicks(9228) });

            migrationBuilder.UpdateData(
                table: "Book",
                keyColumn: "BookId",
                keyValue: 1489,
                columns: new[] { "CreatedDateTime", "PublicationDate" },
                values: new object[] { new DateTime(2024, 8, 16, 14, 36, 27, 272, DateTimeKind.Utc).AddTicks(302), new DateTime(2024, 8, 2, 15, 2, 10, 917, DateTimeKind.Local).AddTicks(4556) });

            migrationBuilder.UpdateData(
                table: "Book",
                keyColumn: "BookId",
                keyValue: 1490,
                columns: new[] { "CreatedDateTime", "PublicationDate" },
                values: new object[] { new DateTime(2024, 8, 16, 14, 36, 27, 272, DateTimeKind.Utc).AddTicks(462), new DateTime(2024, 7, 12, 23, 24, 43, 761, DateTimeKind.Local).AddTicks(9043) });

            migrationBuilder.UpdateData(
                table: "Book",
                keyColumn: "BookId",
                keyValue: 1491,
                columns: new[] { "CreatedDateTime", "PublicationDate" },
                values: new object[] { new DateTime(2024, 8, 16, 14, 36, 27, 272, DateTimeKind.Utc).AddTicks(650), new DateTime(2024, 8, 12, 21, 25, 8, 295, DateTimeKind.Local).AddTicks(1823) });

            migrationBuilder.UpdateData(
                table: "Book",
                keyColumn: "BookId",
                keyValue: 1492,
                columns: new[] { "CreatedDateTime", "PublicationDate" },
                values: new object[] { new DateTime(2024, 8, 16, 14, 36, 27, 272, DateTimeKind.Utc).AddTicks(841), new DateTime(2023, 10, 30, 6, 5, 49, 73, DateTimeKind.Local).AddTicks(5040) });

            migrationBuilder.UpdateData(
                table: "Book",
                keyColumn: "BookId",
                keyValue: 1493,
                columns: new[] { "CreatedDateTime", "PublicationDate" },
                values: new object[] { new DateTime(2024, 8, 16, 14, 36, 27, 272, DateTimeKind.Utc).AddTicks(1008), new DateTime(2023, 12, 26, 11, 56, 49, 597, DateTimeKind.Local).AddTicks(2003) });

            migrationBuilder.UpdateData(
                table: "Book",
                keyColumn: "BookId",
                keyValue: 1494,
                columns: new[] { "CreatedDateTime", "PublicationDate" },
                values: new object[] { new DateTime(2024, 8, 16, 14, 36, 27, 272, DateTimeKind.Utc).AddTicks(1210), new DateTime(2024, 1, 28, 8, 9, 10, 269, DateTimeKind.Local).AddTicks(6082) });

            migrationBuilder.UpdateData(
                table: "Book",
                keyColumn: "BookId",
                keyValue: 1495,
                columns: new[] { "CreatedDateTime", "PublicationDate" },
                values: new object[] { new DateTime(2024, 8, 16, 14, 36, 27, 272, DateTimeKind.Utc).AddTicks(1359), new DateTime(2024, 1, 10, 4, 7, 0, 109, DateTimeKind.Local).AddTicks(4470) });

            migrationBuilder.UpdateData(
                table: "Book",
                keyColumn: "BookId",
                keyValue: 1496,
                columns: new[] { "CreatedDateTime", "PublicationDate" },
                values: new object[] { new DateTime(2024, 8, 16, 14, 36, 27, 272, DateTimeKind.Utc).AddTicks(1558), new DateTime(2024, 7, 17, 23, 8, 46, 567, DateTimeKind.Local).AddTicks(2421) });

            migrationBuilder.UpdateData(
                table: "Book",
                keyColumn: "BookId",
                keyValue: 1497,
                columns: new[] { "CreatedDateTime", "PublicationDate" },
                values: new object[] { new DateTime(2024, 8, 16, 14, 36, 27, 272, DateTimeKind.Utc).AddTicks(1714), new DateTime(2024, 5, 24, 12, 2, 55, 451, DateTimeKind.Local).AddTicks(4146) });

            migrationBuilder.UpdateData(
                table: "Book",
                keyColumn: "BookId",
                keyValue: 1498,
                columns: new[] { "CreatedDateTime", "PublicationDate" },
                values: new object[] { new DateTime(2024, 8, 16, 14, 36, 27, 272, DateTimeKind.Utc).AddTicks(1939), new DateTime(2024, 2, 14, 18, 37, 8, 963, DateTimeKind.Local).AddTicks(6173) });

            migrationBuilder.UpdateData(
                table: "Book",
                keyColumn: "BookId",
                keyValue: 1499,
                columns: new[] { "CreatedDateTime", "PublicationDate" },
                values: new object[] { new DateTime(2024, 8, 16, 14, 36, 27, 272, DateTimeKind.Utc).AddTicks(2085), new DateTime(2024, 6, 29, 9, 53, 47, 503, DateTimeKind.Local).AddTicks(8497) });

            migrationBuilder.UpdateData(
                table: "Book",
                keyColumn: "BookId",
                keyValue: 1500,
                columns: new[] { "CreatedDateTime", "PublicationDate" },
                values: new object[] { new DateTime(2024, 8, 16, 14, 36, 27, 272, DateTimeKind.Utc).AddTicks(2273), new DateTime(2024, 3, 12, 7, 50, 21, 544, DateTimeKind.Local).AddTicks(3130) });

            migrationBuilder.UpdateData(
                table: "Book",
                keyColumn: "BookId",
                keyValue: 1501,
                columns: new[] { "CreatedDateTime", "PublicationDate" },
                values: new object[] { new DateTime(2024, 8, 16, 14, 36, 27, 272, DateTimeKind.Utc).AddTicks(2425), new DateTime(2023, 9, 3, 5, 5, 50, 5, DateTimeKind.Local).AddTicks(3153) });

            migrationBuilder.UpdateData(
                table: "Book",
                keyColumn: "BookId",
                keyValue: 1502,
                columns: new[] { "CreatedDateTime", "PublicationDate" },
                values: new object[] { new DateTime(2024, 8, 16, 14, 36, 27, 272, DateTimeKind.Utc).AddTicks(2621), new DateTime(2023, 11, 1, 13, 36, 40, 894, DateTimeKind.Local).AddTicks(5341) });

            migrationBuilder.UpdateData(
                table: "Book",
                keyColumn: "BookId",
                keyValue: 1503,
                columns: new[] { "CreatedDateTime", "PublicationDate" },
                values: new object[] { new DateTime(2024, 8, 16, 14, 36, 27, 272, DateTimeKind.Utc).AddTicks(2768), new DateTime(2023, 9, 21, 9, 12, 58, 147, DateTimeKind.Local).AddTicks(2555) });

            migrationBuilder.UpdateData(
                table: "Book",
                keyColumn: "BookId",
                keyValue: 1504,
                columns: new[] { "CreatedDateTime", "PublicationDate" },
                values: new object[] { new DateTime(2024, 8, 16, 14, 36, 27, 272, DateTimeKind.Utc).AddTicks(2945), new DateTime(2023, 11, 28, 7, 42, 57, 842, DateTimeKind.Local).AddTicks(8635) });

            migrationBuilder.UpdateData(
                table: "Book",
                keyColumn: "BookId",
                keyValue: 1505,
                columns: new[] { "CreatedDateTime", "PublicationDate" },
                values: new object[] { new DateTime(2024, 8, 16, 14, 36, 27, 272, DateTimeKind.Utc).AddTicks(3088), new DateTime(2023, 12, 29, 1, 4, 58, 38, DateTimeKind.Local).AddTicks(2570) });

            migrationBuilder.UpdateData(
                table: "Book",
                keyColumn: "BookId",
                keyValue: 1506,
                columns: new[] { "CreatedDateTime", "PublicationDate" },
                values: new object[] { new DateTime(2024, 8, 16, 14, 36, 27, 272, DateTimeKind.Utc).AddTicks(3260), new DateTime(2024, 3, 18, 8, 22, 7, 944, DateTimeKind.Local).AddTicks(9380) });

            migrationBuilder.UpdateData(
                table: "Book",
                keyColumn: "BookId",
                keyValue: 1507,
                columns: new[] { "CreatedDateTime", "PublicationDate" },
                values: new object[] { new DateTime(2024, 8, 16, 14, 36, 27, 272, DateTimeKind.Utc).AddTicks(3435), new DateTime(2024, 2, 22, 17, 4, 45, 109, DateTimeKind.Local).AddTicks(6319) });

            migrationBuilder.UpdateData(
                table: "Book",
                keyColumn: "BookId",
                keyValue: 1508,
                columns: new[] { "CreatedDateTime", "PublicationDate" },
                values: new object[] { new DateTime(2024, 8, 16, 14, 36, 27, 272, DateTimeKind.Utc).AddTicks(3643), new DateTime(2023, 12, 21, 20, 58, 24, 99, DateTimeKind.Local).AddTicks(7567) });

            migrationBuilder.UpdateData(
                table: "Book",
                keyColumn: "BookId",
                keyValue: 1509,
                columns: new[] { "CreatedDateTime", "PublicationDate" },
                values: new object[] { new DateTime(2024, 8, 16, 14, 36, 27, 272, DateTimeKind.Utc).AddTicks(3784), new DateTime(2023, 9, 20, 21, 28, 35, 132, DateTimeKind.Local).AddTicks(1586) });

            migrationBuilder.UpdateData(
                table: "Book",
                keyColumn: "BookId",
                keyValue: 1510,
                columns: new[] { "CreatedDateTime", "PublicationDate" },
                values: new object[] { new DateTime(2024, 8, 16, 14, 36, 27, 272, DateTimeKind.Utc).AddTicks(3981), new DateTime(2023, 8, 26, 23, 4, 14, 998, DateTimeKind.Local).AddTicks(44) });

            migrationBuilder.UpdateData(
                table: "Book",
                keyColumn: "BookId",
                keyValue: 1511,
                columns: new[] { "CreatedDateTime", "PublicationDate" },
                values: new object[] { new DateTime(2024, 8, 16, 14, 36, 27, 272, DateTimeKind.Utc).AddTicks(4118), new DateTime(2024, 6, 3, 22, 0, 7, 642, DateTimeKind.Local).AddTicks(6671) });

            migrationBuilder.UpdateData(
                table: "Book",
                keyColumn: "BookId",
                keyValue: 1512,
                columns: new[] { "CreatedDateTime", "PublicationDate" },
                values: new object[] { new DateTime(2024, 8, 16, 14, 36, 27, 272, DateTimeKind.Utc).AddTicks(4303), new DateTime(2024, 5, 31, 0, 15, 4, 682, DateTimeKind.Local).AddTicks(5724) });

            migrationBuilder.UpdateData(
                table: "Book",
                keyColumn: "BookId",
                keyValue: 1513,
                columns: new[] { "CreatedDateTime", "PublicationDate" },
                values: new object[] { new DateTime(2024, 8, 16, 14, 36, 27, 272, DateTimeKind.Utc).AddTicks(4447), new DateTime(2023, 10, 14, 7, 31, 41, 709, DateTimeKind.Local).AddTicks(4511) });

            migrationBuilder.UpdateData(
                table: "Book",
                keyColumn: "BookId",
                keyValue: 1514,
                columns: new[] { "CreatedDateTime", "PublicationDate" },
                values: new object[] { new DateTime(2024, 8, 16, 14, 36, 27, 272, DateTimeKind.Utc).AddTicks(4655), new DateTime(2024, 3, 20, 9, 21, 7, 393, DateTimeKind.Local).AddTicks(7531) });

            migrationBuilder.UpdateData(
                table: "Book",
                keyColumn: "BookId",
                keyValue: 1515,
                columns: new[] { "CreatedDateTime", "PublicationDate" },
                values: new object[] { new DateTime(2024, 8, 16, 14, 36, 27, 272, DateTimeKind.Utc).AddTicks(4813), new DateTime(2023, 12, 6, 1, 16, 27, 995, DateTimeKind.Local).AddTicks(7833) });

            migrationBuilder.UpdateData(
                table: "Book",
                keyColumn: "BookId",
                keyValue: 1516,
                columns: new[] { "CreatedDateTime", "PublicationDate" },
                values: new object[] { new DateTime(2024, 8, 16, 14, 36, 27, 272, DateTimeKind.Utc).AddTicks(5000), new DateTime(2024, 4, 21, 18, 37, 15, 382, DateTimeKind.Local).AddTicks(4365) });

            migrationBuilder.UpdateData(
                table: "Book",
                keyColumn: "BookId",
                keyValue: 1517,
                columns: new[] { "CreatedDateTime", "PublicationDate" },
                values: new object[] { new DateTime(2024, 8, 16, 14, 36, 27, 272, DateTimeKind.Utc).AddTicks(5150), new DateTime(2024, 6, 14, 13, 42, 48, 500, DateTimeKind.Local).AddTicks(6023) });

            migrationBuilder.UpdateData(
                table: "Book",
                keyColumn: "BookId",
                keyValue: 1518,
                columns: new[] { "CreatedDateTime", "PublicationDate" },
                values: new object[] { new DateTime(2024, 8, 16, 14, 36, 27, 272, DateTimeKind.Utc).AddTicks(5336), new DateTime(2023, 11, 29, 12, 13, 21, 698, DateTimeKind.Local).AddTicks(5847) });

            migrationBuilder.UpdateData(
                table: "Book",
                keyColumn: "BookId",
                keyValue: 1519,
                columns: new[] { "CreatedDateTime", "PublicationDate" },
                values: new object[] { new DateTime(2024, 8, 16, 14, 36, 27, 272, DateTimeKind.Utc).AddTicks(5524), new DateTime(2023, 10, 16, 22, 14, 23, 951, DateTimeKind.Local).AddTicks(6179) });

            migrationBuilder.UpdateData(
                table: "Book",
                keyColumn: "BookId",
                keyValue: 1520,
                columns: new[] { "CreatedDateTime", "PublicationDate" },
                values: new object[] { new DateTime(2024, 8, 16, 14, 36, 27, 272, DateTimeKind.Utc).AddTicks(5672), new DateTime(2024, 1, 3, 23, 32, 56, 144, DateTimeKind.Local).AddTicks(5046) });

            migrationBuilder.UpdateData(
                table: "Book",
                keyColumn: "BookId",
                keyValue: 1521,
                columns: new[] { "CreatedDateTime", "PublicationDate" },
                values: new object[] { new DateTime(2024, 8, 16, 14, 36, 27, 272, DateTimeKind.Utc).AddTicks(5841), new DateTime(2024, 1, 17, 5, 27, 21, 25, DateTimeKind.Local).AddTicks(8900) });

            migrationBuilder.UpdateData(
                table: "Book",
                keyColumn: "BookId",
                keyValue: 1522,
                columns: new[] { "CreatedDateTime", "PublicationDate" },
                values: new object[] { new DateTime(2024, 8, 16, 14, 36, 27, 272, DateTimeKind.Utc).AddTicks(6005), new DateTime(2024, 6, 6, 23, 55, 58, 12, DateTimeKind.Local).AddTicks(5229) });

            migrationBuilder.UpdateData(
                table: "Book",
                keyColumn: "BookId",
                keyValue: 1523,
                columns: new[] { "CreatedDateTime", "PublicationDate" },
                values: new object[] { new DateTime(2024, 8, 16, 14, 36, 27, 272, DateTimeKind.Utc).AddTicks(6192), new DateTime(2024, 3, 27, 11, 42, 0, 503, DateTimeKind.Local).AddTicks(3630) });

            migrationBuilder.UpdateData(
                table: "Book",
                keyColumn: "BookId",
                keyValue: 1524,
                columns: new[] { "CreatedDateTime", "PublicationDate" },
                values: new object[] { new DateTime(2024, 8, 16, 14, 36, 27, 272, DateTimeKind.Utc).AddTicks(6367), new DateTime(2023, 10, 25, 2, 15, 5, 680, DateTimeKind.Local).AddTicks(1814) });

            migrationBuilder.UpdateData(
                table: "Book",
                keyColumn: "BookId",
                keyValue: 1525,
                columns: new[] { "CreatedDateTime", "PublicationDate" },
                values: new object[] { new DateTime(2024, 8, 16, 14, 36, 27, 272, DateTimeKind.Utc).AddTicks(6573), new DateTime(2024, 4, 25, 3, 17, 54, 841, DateTimeKind.Local).AddTicks(2873) });

            migrationBuilder.UpdateData(
                table: "Book",
                keyColumn: "BookId",
                keyValue: 1526,
                columns: new[] { "CreatedDateTime", "PublicationDate" },
                values: new object[] { new DateTime(2024, 8, 16, 14, 36, 27, 272, DateTimeKind.Utc).AddTicks(6755), new DateTime(2023, 12, 4, 15, 27, 37, 748, DateTimeKind.Local).AddTicks(2838) });

            migrationBuilder.UpdateData(
                table: "Book",
                keyColumn: "BookId",
                keyValue: 1527,
                columns: new[] { "CreatedDateTime", "PublicationDate" },
                values: new object[] { new DateTime(2024, 8, 16, 14, 36, 27, 272, DateTimeKind.Utc).AddTicks(6918), new DateTime(2024, 7, 29, 19, 10, 10, 46, DateTimeKind.Local).AddTicks(2714) });

            migrationBuilder.UpdateData(
                table: "Book",
                keyColumn: "BookId",
                keyValue: 1528,
                columns: new[] { "CreatedDateTime", "PublicationDate" },
                values: new object[] { new DateTime(2024, 8, 16, 14, 36, 27, 272, DateTimeKind.Utc).AddTicks(7086), new DateTime(2024, 6, 22, 8, 13, 3, 694, DateTimeKind.Local).AddTicks(765) });

            migrationBuilder.UpdateData(
                table: "Book",
                keyColumn: "BookId",
                keyValue: 1529,
                columns: new[] { "CreatedDateTime", "PublicationDate" },
                values: new object[] { new DateTime(2024, 8, 16, 14, 36, 27, 272, DateTimeKind.Utc).AddTicks(7244), new DateTime(2024, 6, 13, 3, 8, 40, 340, DateTimeKind.Local).AddTicks(5213) });

            migrationBuilder.UpdateData(
                table: "Book",
                keyColumn: "BookId",
                keyValue: 1530,
                columns: new[] { "CreatedDateTime", "PublicationDate" },
                values: new object[] { new DateTime(2024, 8, 16, 14, 36, 27, 272, DateTimeKind.Utc).AddTicks(7417), new DateTime(2023, 11, 7, 22, 39, 56, 983, DateTimeKind.Local).AddTicks(7684) });

            migrationBuilder.UpdateData(
                table: "Book",
                keyColumn: "BookId",
                keyValue: 1531,
                columns: new[] { "CreatedDateTime", "PublicationDate" },
                values: new object[] { new DateTime(2024, 8, 16, 14, 36, 27, 272, DateTimeKind.Utc).AddTicks(7588), new DateTime(2024, 7, 22, 14, 26, 7, 653, DateTimeKind.Local).AddTicks(3535) });

            migrationBuilder.UpdateData(
                table: "Book",
                keyColumn: "BookId",
                keyValue: 1532,
                columns: new[] { "CreatedDateTime", "PublicationDate" },
                values: new object[] { new DateTime(2024, 8, 16, 14, 36, 27, 272, DateTimeKind.Utc).AddTicks(7750), new DateTime(2023, 8, 21, 9, 23, 15, 498, DateTimeKind.Local).AddTicks(4570) });

            migrationBuilder.UpdateData(
                table: "Book",
                keyColumn: "BookId",
                keyValue: 1533,
                columns: new[] { "CreatedDateTime", "PublicationDate" },
                values: new object[] { new DateTime(2024, 8, 16, 14, 36, 27, 272, DateTimeKind.Utc).AddTicks(7905), new DateTime(2024, 1, 19, 21, 5, 9, 531, DateTimeKind.Local).AddTicks(2199) });

            migrationBuilder.UpdateData(
                table: "Book",
                keyColumn: "BookId",
                keyValue: 1534,
                columns: new[] { "CreatedDateTime", "PublicationDate" },
                values: new object[] { new DateTime(2024, 8, 16, 14, 36, 27, 272, DateTimeKind.Utc).AddTicks(8083), new DateTime(2024, 4, 28, 14, 48, 43, 222, DateTimeKind.Local).AddTicks(4327) });

            migrationBuilder.UpdateData(
                table: "Book",
                keyColumn: "BookId",
                keyValue: 1535,
                columns: new[] { "CreatedDateTime", "PublicationDate" },
                values: new object[] { new DateTime(2024, 8, 16, 14, 36, 27, 272, DateTimeKind.Utc).AddTicks(8233), new DateTime(2023, 8, 23, 9, 14, 8, 403, DateTimeKind.Local).AddTicks(7478) });

            migrationBuilder.UpdateData(
                table: "Book",
                keyColumn: "BookId",
                keyValue: 1536,
                columns: new[] { "CreatedDateTime", "PublicationDate" },
                values: new object[] { new DateTime(2024, 8, 16, 14, 36, 27, 272, DateTimeKind.Utc).AddTicks(8408), new DateTime(2024, 7, 5, 19, 27, 47, 763, DateTimeKind.Local).AddTicks(7951) });

            migrationBuilder.UpdateData(
                table: "Book",
                keyColumn: "BookId",
                keyValue: 1537,
                columns: new[] { "CreatedDateTime", "PublicationDate" },
                values: new object[] { new DateTime(2024, 8, 16, 14, 36, 27, 272, DateTimeKind.Utc).AddTicks(8551), new DateTime(2024, 4, 29, 8, 46, 43, 987, DateTimeKind.Local).AddTicks(9171) });

            migrationBuilder.UpdateData(
                table: "Book",
                keyColumn: "BookId",
                keyValue: 1538,
                columns: new[] { "CreatedDateTime", "PublicationDate" },
                values: new object[] { new DateTime(2024, 8, 16, 14, 36, 27, 272, DateTimeKind.Utc).AddTicks(8753), new DateTime(2024, 6, 10, 19, 55, 52, 24, DateTimeKind.Local).AddTicks(1404) });

            migrationBuilder.UpdateData(
                table: "Book",
                keyColumn: "BookId",
                keyValue: 1539,
                columns: new[] { "CreatedDateTime", "PublicationDate" },
                values: new object[] { new DateTime(2024, 8, 16, 14, 36, 27, 272, DateTimeKind.Utc).AddTicks(8955), new DateTime(2024, 8, 14, 20, 54, 48, 667, DateTimeKind.Local).AddTicks(9032) });

            migrationBuilder.UpdateData(
                table: "Book",
                keyColumn: "BookId",
                keyValue: 1540,
                columns: new[] { "CreatedDateTime", "PublicationDate" },
                values: new object[] { new DateTime(2024, 8, 16, 14, 36, 27, 272, DateTimeKind.Utc).AddTicks(9111), new DateTime(2023, 11, 17, 16, 17, 38, 743, DateTimeKind.Local).AddTicks(6685) });

            migrationBuilder.UpdateData(
                table: "Book",
                keyColumn: "BookId",
                keyValue: 1541,
                columns: new[] { "CreatedDateTime", "PublicationDate" },
                values: new object[] { new DateTime(2024, 8, 16, 14, 36, 27, 272, DateTimeKind.Utc).AddTicks(9293), new DateTime(2023, 10, 4, 21, 22, 52, 264, DateTimeKind.Local).AddTicks(9616) });

            migrationBuilder.UpdateData(
                table: "Book",
                keyColumn: "BookId",
                keyValue: 1542,
                columns: new[] { "CreatedDateTime", "PublicationDate" },
                values: new object[] { new DateTime(2024, 8, 16, 14, 36, 27, 272, DateTimeKind.Utc).AddTicks(9449), new DateTime(2023, 12, 17, 4, 54, 7, 384, DateTimeKind.Local).AddTicks(9601) });

            migrationBuilder.UpdateData(
                table: "Book",
                keyColumn: "BookId",
                keyValue: 1543,
                columns: new[] { "CreatedDateTime", "PublicationDate" },
                values: new object[] { new DateTime(2024, 8, 16, 14, 36, 27, 272, DateTimeKind.Utc).AddTicks(9630), new DateTime(2023, 12, 26, 5, 37, 22, 857, DateTimeKind.Local).AddTicks(5666) });

            migrationBuilder.UpdateData(
                table: "Book",
                keyColumn: "BookId",
                keyValue: 1544,
                columns: new[] { "CreatedDateTime", "PublicationDate" },
                values: new object[] { new DateTime(2024, 8, 16, 14, 36, 27, 272, DateTimeKind.Utc).AddTicks(9809), new DateTime(2024, 4, 28, 17, 55, 26, 781, DateTimeKind.Local).AddTicks(8810) });

            migrationBuilder.UpdateData(
                table: "Book",
                keyColumn: "BookId",
                keyValue: 1545,
                columns: new[] { "CreatedDateTime", "PublicationDate" },
                values: new object[] { new DateTime(2024, 8, 16, 14, 36, 27, 272, DateTimeKind.Utc).AddTicks(9988), new DateTime(2024, 7, 6, 18, 15, 5, 214, DateTimeKind.Local).AddTicks(84) });

            migrationBuilder.UpdateData(
                table: "Book",
                keyColumn: "BookId",
                keyValue: 1546,
                columns: new[] { "CreatedDateTime", "PublicationDate" },
                values: new object[] { new DateTime(2024, 8, 16, 14, 36, 27, 273, DateTimeKind.Utc).AddTicks(144), new DateTime(2023, 10, 20, 7, 39, 4, 118, DateTimeKind.Local).AddTicks(4841) });

            migrationBuilder.UpdateData(
                table: "Book",
                keyColumn: "BookId",
                keyValue: 1547,
                columns: new[] { "CreatedDateTime", "PublicationDate" },
                values: new object[] { new DateTime(2024, 8, 16, 14, 36, 27, 273, DateTimeKind.Utc).AddTicks(345), new DateTime(2024, 3, 18, 5, 21, 16, 513, DateTimeKind.Local).AddTicks(1273) });

            migrationBuilder.UpdateData(
                table: "Book",
                keyColumn: "BookId",
                keyValue: 1548,
                columns: new[] { "CreatedDateTime", "PublicationDate" },
                values: new object[] { new DateTime(2024, 8, 16, 14, 36, 27, 273, DateTimeKind.Utc).AddTicks(496), new DateTime(2024, 6, 2, 15, 56, 11, 744, DateTimeKind.Local).AddTicks(6363) });

            migrationBuilder.UpdateData(
                table: "Book",
                keyColumn: "BookId",
                keyValue: 1549,
                columns: new[] { "CreatedDateTime", "PublicationDate" },
                values: new object[] { new DateTime(2024, 8, 16, 14, 36, 27, 273, DateTimeKind.Utc).AddTicks(699), new DateTime(2024, 1, 2, 18, 12, 17, 484, DateTimeKind.Local).AddTicks(8736) });

            migrationBuilder.UpdateData(
                table: "Book",
                keyColumn: "BookId",
                keyValue: 1550,
                columns: new[] { "CreatedDateTime", "PublicationDate" },
                values: new object[] { new DateTime(2024, 8, 16, 14, 36, 27, 273, DateTimeKind.Utc).AddTicks(844), new DateTime(2023, 10, 28, 6, 38, 46, 484, DateTimeKind.Local).AddTicks(5001) });

            migrationBuilder.UpdateData(
                table: "Book",
                keyColumn: "BookId",
                keyValue: 1551,
                columns: new[] { "CreatedDateTime", "PublicationDate" },
                values: new object[] { new DateTime(2024, 8, 16, 14, 36, 27, 273, DateTimeKind.Utc).AddTicks(1022), new DateTime(2024, 3, 13, 10, 17, 13, 716, DateTimeKind.Local).AddTicks(3031) });

            migrationBuilder.UpdateData(
                table: "Book",
                keyColumn: "BookId",
                keyValue: 1552,
                columns: new[] { "CreatedDateTime", "PublicationDate" },
                values: new object[] { new DateTime(2024, 8, 16, 14, 36, 27, 273, DateTimeKind.Utc).AddTicks(1167), new DateTime(2023, 11, 3, 20, 32, 3, 433, DateTimeKind.Local).AddTicks(8917) });

            migrationBuilder.UpdateData(
                table: "Book",
                keyColumn: "BookId",
                keyValue: 1553,
                columns: new[] { "CreatedDateTime", "PublicationDate" },
                values: new object[] { new DateTime(2024, 8, 16, 14, 36, 27, 273, DateTimeKind.Utc).AddTicks(1377), new DateTime(2024, 7, 14, 14, 5, 16, 741, DateTimeKind.Local).AddTicks(1046) });

            migrationBuilder.UpdateData(
                table: "Book",
                keyColumn: "BookId",
                keyValue: 1554,
                columns: new[] { "CreatedDateTime", "PublicationDate" },
                values: new object[] { new DateTime(2024, 8, 16, 14, 36, 27, 273, DateTimeKind.Utc).AddTicks(1562), new DateTime(2024, 8, 4, 8, 51, 56, 682, DateTimeKind.Local).AddTicks(4448) });

            migrationBuilder.UpdateData(
                table: "Book",
                keyColumn: "BookId",
                keyValue: 1555,
                columns: new[] { "CreatedDateTime", "PublicationDate" },
                values: new object[] { new DateTime(2024, 8, 16, 14, 36, 27, 273, DateTimeKind.Utc).AddTicks(1840), new DateTime(2024, 5, 23, 19, 23, 4, 865, DateTimeKind.Local).AddTicks(7772) });

            migrationBuilder.UpdateData(
                table: "Book",
                keyColumn: "BookId",
                keyValue: 1556,
                columns: new[] { "CreatedDateTime", "PublicationDate" },
                values: new object[] { new DateTime(2024, 8, 16, 14, 36, 27, 273, DateTimeKind.Utc).AddTicks(2037), new DateTime(2024, 8, 10, 15, 49, 14, 761, DateTimeKind.Local).AddTicks(2956) });

            migrationBuilder.UpdateData(
                table: "Book",
                keyColumn: "BookId",
                keyValue: 1557,
                columns: new[] { "CreatedDateTime", "PublicationDate" },
                values: new object[] { new DateTime(2024, 8, 16, 14, 36, 27, 273, DateTimeKind.Utc).AddTicks(2259), new DateTime(2024, 7, 30, 13, 50, 45, 980, DateTimeKind.Local).AddTicks(5185) });

            migrationBuilder.UpdateData(
                table: "Book",
                keyColumn: "BookId",
                keyValue: 1558,
                columns: new[] { "CreatedDateTime", "PublicationDate" },
                values: new object[] { new DateTime(2024, 8, 16, 14, 36, 27, 273, DateTimeKind.Utc).AddTicks(2457), new DateTime(2024, 1, 6, 11, 56, 59, 313, DateTimeKind.Local).AddTicks(4817) });

            migrationBuilder.UpdateData(
                table: "Book",
                keyColumn: "BookId",
                keyValue: 1559,
                columns: new[] { "CreatedDateTime", "PublicationDate" },
                values: new object[] { new DateTime(2024, 8, 16, 14, 36, 27, 273, DateTimeKind.Utc).AddTicks(2676), new DateTime(2024, 2, 19, 19, 48, 41, 805, DateTimeKind.Local).AddTicks(6638) });

            migrationBuilder.UpdateData(
                table: "Book",
                keyColumn: "BookId",
                keyValue: 1560,
                columns: new[] { "CreatedDateTime", "PublicationDate" },
                values: new object[] { new DateTime(2024, 8, 16, 14, 36, 27, 273, DateTimeKind.Utc).AddTicks(2871), new DateTime(2024, 3, 2, 0, 3, 25, 248, DateTimeKind.Local).AddTicks(9668) });

            migrationBuilder.UpdateData(
                table: "Book",
                keyColumn: "BookId",
                keyValue: 1561,
                columns: new[] { "CreatedDateTime", "PublicationDate" },
                values: new object[] { new DateTime(2024, 8, 16, 14, 36, 27, 273, DateTimeKind.Utc).AddTicks(3083), new DateTime(2024, 5, 25, 23, 58, 19, 566, DateTimeKind.Local).AddTicks(3520) });

            migrationBuilder.UpdateData(
                table: "Book",
                keyColumn: "BookId",
                keyValue: 1562,
                columns: new[] { "CreatedDateTime", "PublicationDate" },
                values: new object[] { new DateTime(2024, 8, 16, 14, 36, 27, 273, DateTimeKind.Utc).AddTicks(3237), new DateTime(2023, 11, 4, 15, 18, 31, 965, DateTimeKind.Local).AddTicks(7772) });

            migrationBuilder.UpdateData(
                table: "Book",
                keyColumn: "BookId",
                keyValue: 1563,
                columns: new[] { "CreatedDateTime", "PublicationDate" },
                values: new object[] { new DateTime(2024, 8, 16, 14, 36, 27, 273, DateTimeKind.Utc).AddTicks(3448), new DateTime(2023, 10, 2, 7, 14, 1, 485, DateTimeKind.Local).AddTicks(3176) });

            migrationBuilder.UpdateData(
                table: "Book",
                keyColumn: "BookId",
                keyValue: 1564,
                columns: new[] { "CreatedDateTime", "PublicationDate" },
                values: new object[] { new DateTime(2024, 8, 16, 14, 36, 27, 273, DateTimeKind.Utc).AddTicks(3605), new DateTime(2024, 6, 25, 22, 12, 19, 720, DateTimeKind.Local).AddTicks(8374) });

            migrationBuilder.UpdateData(
                table: "Book",
                keyColumn: "BookId",
                keyValue: 1565,
                columns: new[] { "CreatedDateTime", "PublicationDate" },
                values: new object[] { new DateTime(2024, 8, 16, 14, 36, 27, 273, DateTimeKind.Utc).AddTicks(3809), new DateTime(2024, 7, 29, 5, 39, 17, 226, DateTimeKind.Local).AddTicks(2247) });

            migrationBuilder.UpdateData(
                table: "Book",
                keyColumn: "BookId",
                keyValue: 1566,
                columns: new[] { "CreatedDateTime", "PublicationDate" },
                values: new object[] { new DateTime(2024, 8, 16, 14, 36, 27, 273, DateTimeKind.Utc).AddTicks(4033), new DateTime(2023, 8, 21, 12, 43, 58, 446, DateTimeKind.Local).AddTicks(2028) });

            migrationBuilder.UpdateData(
                table: "Book",
                keyColumn: "BookId",
                keyValue: 1567,
                columns: new[] { "CreatedDateTime", "PublicationDate" },
                values: new object[] { new DateTime(2024, 8, 16, 14, 36, 27, 273, DateTimeKind.Utc).AddTicks(4209), new DateTime(2024, 5, 24, 13, 57, 31, 797, DateTimeKind.Local).AddTicks(7471) });

            migrationBuilder.UpdateData(
                table: "Book",
                keyColumn: "BookId",
                keyValue: 1568,
                columns: new[] { "CreatedDateTime", "PublicationDate" },
                values: new object[] { new DateTime(2024, 8, 16, 14, 36, 27, 273, DateTimeKind.Utc).AddTicks(4438), new DateTime(2023, 10, 5, 10, 10, 41, 586, DateTimeKind.Local).AddTicks(4072) });

            migrationBuilder.UpdateData(
                table: "Book",
                keyColumn: "BookId",
                keyValue: 1569,
                columns: new[] { "CreatedDateTime", "PublicationDate" },
                values: new object[] { new DateTime(2024, 8, 16, 14, 36, 27, 273, DateTimeKind.Utc).AddTicks(4614), new DateTime(2023, 10, 1, 9, 26, 14, 146, DateTimeKind.Local).AddTicks(8644) });

            migrationBuilder.UpdateData(
                table: "Book",
                keyColumn: "BookId",
                keyValue: 1570,
                columns: new[] { "CreatedDateTime", "PublicationDate" },
                values: new object[] { new DateTime(2024, 8, 16, 14, 36, 27, 273, DateTimeKind.Utc).AddTicks(4847), new DateTime(2024, 8, 14, 11, 16, 35, 561, DateTimeKind.Local).AddTicks(3003) });

            migrationBuilder.UpdateData(
                table: "Book",
                keyColumn: "BookId",
                keyValue: 1571,
                columns: new[] { "CreatedDateTime", "PublicationDate" },
                values: new object[] { new DateTime(2024, 8, 16, 14, 36, 27, 273, DateTimeKind.Utc).AddTicks(5000), new DateTime(2024, 6, 11, 14, 30, 42, 944, DateTimeKind.Local).AddTicks(548) });

            migrationBuilder.UpdateData(
                table: "Book",
                keyColumn: "BookId",
                keyValue: 1572,
                columns: new[] { "CreatedDateTime", "PublicationDate" },
                values: new object[] { new DateTime(2024, 8, 16, 14, 36, 27, 273, DateTimeKind.Utc).AddTicks(5191), new DateTime(2023, 8, 30, 7, 35, 5, 930, DateTimeKind.Local).AddTicks(6536) });

            migrationBuilder.UpdateData(
                table: "Book",
                keyColumn: "BookId",
                keyValue: 1573,
                columns: new[] { "CreatedDateTime", "PublicationDate" },
                values: new object[] { new DateTime(2024, 8, 16, 14, 36, 27, 273, DateTimeKind.Utc).AddTicks(5320), new DateTime(2023, 11, 27, 18, 8, 1, 171, DateTimeKind.Local).AddTicks(9448) });

            migrationBuilder.UpdateData(
                table: "Book",
                keyColumn: "BookId",
                keyValue: 1574,
                columns: new[] { "CreatedDateTime", "PublicationDate" },
                values: new object[] { new DateTime(2024, 8, 16, 14, 36, 27, 273, DateTimeKind.Utc).AddTicks(5522), new DateTime(2023, 8, 25, 5, 6, 6, 851, DateTimeKind.Local).AddTicks(3096) });

            migrationBuilder.UpdateData(
                table: "Book",
                keyColumn: "BookId",
                keyValue: 1575,
                columns: new[] { "CreatedDateTime", "PublicationDate" },
                values: new object[] { new DateTime(2024, 8, 16, 14, 36, 27, 273, DateTimeKind.Utc).AddTicks(5681), new DateTime(2024, 1, 9, 12, 51, 41, 250, DateTimeKind.Local).AddTicks(9862) });

            migrationBuilder.UpdateData(
                table: "Book",
                keyColumn: "BookId",
                keyValue: 1576,
                columns: new[] { "CreatedDateTime", "PublicationDate" },
                values: new object[] { new DateTime(2024, 8, 16, 14, 36, 27, 273, DateTimeKind.Utc).AddTicks(5928), new DateTime(2023, 11, 9, 9, 57, 59, 78, DateTimeKind.Local).AddTicks(9625) });

            migrationBuilder.UpdateData(
                table: "Book",
                keyColumn: "BookId",
                keyValue: 1577,
                columns: new[] { "CreatedDateTime", "PublicationDate" },
                values: new object[] { new DateTime(2024, 8, 16, 14, 36, 27, 273, DateTimeKind.Utc).AddTicks(6085), new DateTime(2023, 10, 3, 12, 43, 51, 756, DateTimeKind.Local).AddTicks(4847) });

            migrationBuilder.UpdateData(
                table: "Book",
                keyColumn: "BookId",
                keyValue: 1578,
                columns: new[] { "CreatedDateTime", "PublicationDate" },
                values: new object[] { new DateTime(2024, 8, 16, 14, 36, 27, 273, DateTimeKind.Utc).AddTicks(6279), new DateTime(2023, 12, 22, 5, 51, 3, 922, DateTimeKind.Local).AddTicks(3740) });

            migrationBuilder.UpdateData(
                table: "Book",
                keyColumn: "BookId",
                keyValue: 1579,
                columns: new[] { "CreatedDateTime", "PublicationDate" },
                values: new object[] { new DateTime(2024, 8, 16, 14, 36, 27, 273, DateTimeKind.Utc).AddTicks(6433), new DateTime(2024, 1, 5, 18, 5, 39, 739, DateTimeKind.Local).AddTicks(9921) });

            migrationBuilder.UpdateData(
                table: "Book",
                keyColumn: "BookId",
                keyValue: 1580,
                columns: new[] { "CreatedDateTime", "PublicationDate" },
                values: new object[] { new DateTime(2024, 8, 16, 14, 36, 27, 273, DateTimeKind.Utc).AddTicks(6623), new DateTime(2023, 10, 3, 2, 20, 27, 142, DateTimeKind.Local).AddTicks(2625) });

            migrationBuilder.UpdateData(
                table: "Book",
                keyColumn: "BookId",
                keyValue: 1581,
                columns: new[] { "CreatedDateTime", "PublicationDate" },
                values: new object[] { new DateTime(2024, 8, 16, 14, 36, 27, 273, DateTimeKind.Utc).AddTicks(6779), new DateTime(2024, 4, 21, 1, 5, 42, 8, DateTimeKind.Local).AddTicks(4901) });

            migrationBuilder.UpdateData(
                table: "Book",
                keyColumn: "BookId",
                keyValue: 1582,
                columns: new[] { "CreatedDateTime", "PublicationDate" },
                values: new object[] { new DateTime(2024, 8, 16, 14, 36, 27, 273, DateTimeKind.Utc).AddTicks(6970), new DateTime(2024, 7, 25, 20, 9, 2, 235, DateTimeKind.Local).AddTicks(6406) });

            migrationBuilder.UpdateData(
                table: "Book",
                keyColumn: "BookId",
                keyValue: 1583,
                columns: new[] { "CreatedDateTime", "PublicationDate" },
                values: new object[] { new DateTime(2024, 8, 16, 14, 36, 27, 273, DateTimeKind.Utc).AddTicks(7114), new DateTime(2024, 8, 12, 23, 9, 3, 353, DateTimeKind.Local).AddTicks(9038) });

            migrationBuilder.UpdateData(
                table: "Book",
                keyColumn: "BookId",
                keyValue: 1584,
                columns: new[] { "CreatedDateTime", "PublicationDate" },
                values: new object[] { new DateTime(2024, 8, 16, 14, 36, 27, 273, DateTimeKind.Utc).AddTicks(7299), new DateTime(2023, 8, 27, 21, 59, 50, 518, DateTimeKind.Local).AddTicks(8766) });

            migrationBuilder.UpdateData(
                table: "Book",
                keyColumn: "BookId",
                keyValue: 1585,
                columns: new[] { "CreatedDateTime", "PublicationDate" },
                values: new object[] { new DateTime(2024, 8, 16, 14, 36, 27, 273, DateTimeKind.Utc).AddTicks(7536), new DateTime(2024, 6, 18, 14, 38, 0, 410, DateTimeKind.Local).AddTicks(868) });

            migrationBuilder.UpdateData(
                table: "Book",
                keyColumn: "BookId",
                keyValue: 1586,
                columns: new[] { "CreatedDateTime", "PublicationDate" },
                values: new object[] { new DateTime(2024, 8, 16, 14, 36, 27, 273, DateTimeKind.Utc).AddTicks(7683), new DateTime(2023, 12, 3, 11, 4, 24, 580, DateTimeKind.Local).AddTicks(2786) });

            migrationBuilder.UpdateData(
                table: "Book",
                keyColumn: "BookId",
                keyValue: 1587,
                columns: new[] { "CreatedDateTime", "PublicationDate" },
                values: new object[] { new DateTime(2024, 8, 16, 14, 36, 27, 273, DateTimeKind.Utc).AddTicks(7887), new DateTime(2024, 3, 23, 18, 5, 41, 796, DateTimeKind.Local).AddTicks(3687) });

            migrationBuilder.UpdateData(
                table: "Book",
                keyColumn: "BookId",
                keyValue: 1588,
                columns: new[] { "CreatedDateTime", "PublicationDate" },
                values: new object[] { new DateTime(2024, 8, 16, 14, 36, 27, 273, DateTimeKind.Utc).AddTicks(8033), new DateTime(2023, 12, 19, 8, 24, 21, 67, DateTimeKind.Local).AddTicks(2387) });

            migrationBuilder.UpdateData(
                table: "Book",
                keyColumn: "BookId",
                keyValue: 1589,
                columns: new[] { "CreatedDateTime", "PublicationDate" },
                values: new object[] { new DateTime(2024, 8, 16, 14, 36, 27, 273, DateTimeKind.Utc).AddTicks(8212), new DateTime(2024, 3, 11, 13, 1, 4, 468, DateTimeKind.Local).AddTicks(1318) });

            migrationBuilder.UpdateData(
                table: "Book",
                keyColumn: "BookId",
                keyValue: 1590,
                columns: new[] { "CreatedDateTime", "PublicationDate" },
                values: new object[] { new DateTime(2024, 8, 16, 14, 36, 27, 273, DateTimeKind.Utc).AddTicks(8370), new DateTime(2024, 1, 1, 17, 3, 59, 363, DateTimeKind.Local).AddTicks(723) });

            migrationBuilder.UpdateData(
                table: "Book",
                keyColumn: "BookId",
                keyValue: 1591,
                columns: new[] { "CreatedDateTime", "PublicationDate" },
                values: new object[] { new DateTime(2024, 8, 16, 14, 36, 27, 273, DateTimeKind.Utc).AddTicks(8572), new DateTime(2024, 1, 16, 0, 50, 16, 186, DateTimeKind.Local).AddTicks(2884) });

            migrationBuilder.UpdateData(
                table: "Book",
                keyColumn: "BookId",
                keyValue: 1592,
                columns: new[] { "CreatedDateTime", "PublicationDate" },
                values: new object[] { new DateTime(2024, 8, 16, 14, 36, 27, 273, DateTimeKind.Utc).AddTicks(8725), new DateTime(2024, 8, 15, 6, 52, 41, 436, DateTimeKind.Local).AddTicks(7856) });

            migrationBuilder.UpdateData(
                table: "Book",
                keyColumn: "BookId",
                keyValue: 1593,
                columns: new[] { "CreatedDateTime", "PublicationDate" },
                values: new object[] { new DateTime(2024, 8, 16, 14, 36, 27, 273, DateTimeKind.Utc).AddTicks(8902), new DateTime(2023, 11, 3, 12, 55, 31, 954, DateTimeKind.Local).AddTicks(7355) });

            migrationBuilder.UpdateData(
                table: "Book",
                keyColumn: "BookId",
                keyValue: 1594,
                columns: new[] { "CreatedDateTime", "PublicationDate" },
                values: new object[] { new DateTime(2024, 8, 16, 14, 36, 27, 273, DateTimeKind.Utc).AddTicks(9058), new DateTime(2023, 12, 9, 3, 13, 48, 147, DateTimeKind.Local).AddTicks(1950) });

            migrationBuilder.UpdateData(
                table: "Book",
                keyColumn: "BookId",
                keyValue: 1595,
                columns: new[] { "CreatedDateTime", "PublicationDate" },
                values: new object[] { new DateTime(2024, 8, 16, 14, 36, 27, 273, DateTimeKind.Utc).AddTicks(9240), new DateTime(2023, 10, 16, 8, 40, 38, 212, DateTimeKind.Local).AddTicks(7306) });

            migrationBuilder.UpdateData(
                table: "Book",
                keyColumn: "BookId",
                keyValue: 1596,
                columns: new[] { "CreatedDateTime", "PublicationDate" },
                values: new object[] { new DateTime(2024, 8, 16, 14, 36, 27, 273, DateTimeKind.Utc).AddTicks(9389), new DateTime(2023, 12, 15, 8, 44, 46, 592, DateTimeKind.Local).AddTicks(929) });

            migrationBuilder.UpdateData(
                table: "Book",
                keyColumn: "BookId",
                keyValue: 1597,
                columns: new[] { "CreatedDateTime", "PublicationDate" },
                values: new object[] { new DateTime(2024, 8, 16, 14, 36, 27, 273, DateTimeKind.Utc).AddTicks(9610), new DateTime(2024, 2, 1, 16, 13, 40, 179, DateTimeKind.Local).AddTicks(446) });

            migrationBuilder.UpdateData(
                table: "Book",
                keyColumn: "BookId",
                keyValue: 1598,
                columns: new[] { "CreatedDateTime", "PublicationDate" },
                values: new object[] { new DateTime(2024, 8, 16, 14, 36, 27, 273, DateTimeKind.Utc).AddTicks(9772), new DateTime(2024, 5, 9, 20, 7, 13, 617, DateTimeKind.Local).AddTicks(5251) });

            migrationBuilder.UpdateData(
                table: "Book",
                keyColumn: "BookId",
                keyValue: 1599,
                columns: new[] { "CreatedDateTime", "PublicationDate" },
                values: new object[] { new DateTime(2024, 8, 16, 14, 36, 27, 273, DateTimeKind.Utc).AddTicks(9967), new DateTime(2024, 2, 24, 3, 58, 23, 243, DateTimeKind.Local).AddTicks(149) });

            migrationBuilder.UpdateData(
                table: "Book",
                keyColumn: "BookId",
                keyValue: 1600,
                columns: new[] { "CreatedDateTime", "PublicationDate" },
                values: new object[] { new DateTime(2024, 8, 16, 14, 36, 27, 274, DateTimeKind.Utc).AddTicks(123), new DateTime(2024, 3, 9, 7, 0, 53, 714, DateTimeKind.Local).AddTicks(8853) });

            migrationBuilder.UpdateData(
                table: "Book",
                keyColumn: "BookId",
                keyValue: 1601,
                columns: new[] { "CreatedDateTime", "PublicationDate" },
                values: new object[] { new DateTime(2024, 8, 16, 14, 36, 27, 274, DateTimeKind.Utc).AddTicks(327), new DateTime(2024, 6, 22, 0, 1, 55, 870, DateTimeKind.Local).AddTicks(6707) });

            migrationBuilder.UpdateData(
                table: "Book",
                keyColumn: "BookId",
                keyValue: 1602,
                columns: new[] { "CreatedDateTime", "PublicationDate" },
                values: new object[] { new DateTime(2024, 8, 16, 14, 36, 27, 274, DateTimeKind.Utc).AddTicks(478), new DateTime(2024, 1, 31, 5, 53, 57, 779, DateTimeKind.Local).AddTicks(7513) });

            migrationBuilder.UpdateData(
                table: "Book",
                keyColumn: "BookId",
                keyValue: 1603,
                columns: new[] { "CreatedDateTime", "PublicationDate" },
                values: new object[] { new DateTime(2024, 8, 16, 14, 36, 27, 274, DateTimeKind.Utc).AddTicks(681), new DateTime(2024, 8, 12, 8, 54, 2, 139, DateTimeKind.Local).AddTicks(1947) });

            migrationBuilder.UpdateData(
                table: "Book",
                keyColumn: "BookId",
                keyValue: 1604,
                columns: new[] { "CreatedDateTime", "PublicationDate" },
                values: new object[] { new DateTime(2024, 8, 16, 14, 36, 27, 274, DateTimeKind.Utc).AddTicks(848), new DateTime(2024, 3, 25, 14, 32, 28, 191, DateTimeKind.Local).AddTicks(8676) });

            migrationBuilder.UpdateData(
                table: "Book",
                keyColumn: "BookId",
                keyValue: 1605,
                columns: new[] { "CreatedDateTime", "PublicationDate" },
                values: new object[] { new DateTime(2024, 8, 16, 14, 36, 27, 274, DateTimeKind.Utc).AddTicks(1059), new DateTime(2024, 7, 31, 4, 59, 56, 722, DateTimeKind.Local).AddTicks(8306) });

            migrationBuilder.UpdateData(
                table: "Book",
                keyColumn: "BookId",
                keyValue: 1606,
                columns: new[] { "CreatedDateTime", "PublicationDate" },
                values: new object[] { new DateTime(2024, 8, 16, 14, 36, 27, 274, DateTimeKind.Utc).AddTicks(1216), new DateTime(2024, 5, 19, 15, 52, 43, 297, DateTimeKind.Local).AddTicks(1893) });

            migrationBuilder.UpdateData(
                table: "Book",
                keyColumn: "BookId",
                keyValue: 1607,
                columns: new[] { "CreatedDateTime", "PublicationDate" },
                values: new object[] { new DateTime(2024, 8, 16, 14, 36, 27, 274, DateTimeKind.Utc).AddTicks(1404), new DateTime(2023, 11, 21, 23, 12, 45, 287, DateTimeKind.Local).AddTicks(219) });

            migrationBuilder.UpdateData(
                table: "Book",
                keyColumn: "BookId",
                keyValue: 1608,
                columns: new[] { "CreatedDateTime", "PublicationDate" },
                values: new object[] { new DateTime(2024, 8, 16, 14, 36, 27, 274, DateTimeKind.Utc).AddTicks(1545), new DateTime(2023, 8, 16, 18, 6, 48, 677, DateTimeKind.Local).AddTicks(1666) });

            migrationBuilder.UpdateData(
                table: "Book",
                keyColumn: "BookId",
                keyValue: 1609,
                columns: new[] { "CreatedDateTime", "PublicationDate" },
                values: new object[] { new DateTime(2024, 8, 16, 14, 36, 27, 274, DateTimeKind.Utc).AddTicks(1757), new DateTime(2024, 3, 4, 3, 57, 6, 525, DateTimeKind.Local).AddTicks(3239) });

            migrationBuilder.UpdateData(
                table: "Book",
                keyColumn: "BookId",
                keyValue: 1610,
                columns: new[] { "CreatedDateTime", "PublicationDate" },
                values: new object[] { new DateTime(2024, 8, 16, 14, 36, 27, 274, DateTimeKind.Utc).AddTicks(1912), new DateTime(2023, 9, 4, 2, 28, 0, 154, DateTimeKind.Local).AddTicks(1782) });

            migrationBuilder.UpdateData(
                table: "Book",
                keyColumn: "BookId",
                keyValue: 1611,
                columns: new[] { "CreatedDateTime", "PublicationDate" },
                values: new object[] { new DateTime(2024, 8, 16, 14, 36, 27, 274, DateTimeKind.Utc).AddTicks(2100), new DateTime(2024, 8, 8, 20, 39, 24, 477, DateTimeKind.Local).AddTicks(4868) });

            migrationBuilder.UpdateData(
                table: "Book",
                keyColumn: "BookId",
                keyValue: 1612,
                columns: new[] { "CreatedDateTime", "PublicationDate" },
                values: new object[] { new DateTime(2024, 8, 16, 14, 36, 27, 274, DateTimeKind.Utc).AddTicks(2231), new DateTime(2023, 8, 29, 4, 54, 28, 66, DateTimeKind.Local).AddTicks(9559) });

            migrationBuilder.UpdateData(
                table: "Book",
                keyColumn: "BookId",
                keyValue: 1613,
                columns: new[] { "CreatedDateTime", "PublicationDate" },
                values: new object[] { new DateTime(2024, 8, 16, 14, 36, 27, 274, DateTimeKind.Utc).AddTicks(2392), new DateTime(2024, 1, 14, 8, 34, 19, 267, DateTimeKind.Local).AddTicks(6029) });

            migrationBuilder.UpdateData(
                table: "Book",
                keyColumn: "BookId",
                keyValue: 1614,
                columns: new[] { "CreatedDateTime", "PublicationDate" },
                values: new object[] { new DateTime(2024, 8, 16, 14, 36, 27, 274, DateTimeKind.Utc).AddTicks(2510), new DateTime(2024, 6, 30, 22, 40, 40, 949, DateTimeKind.Local).AddTicks(2301) });

            migrationBuilder.UpdateData(
                table: "Book",
                keyColumn: "BookId",
                keyValue: 1615,
                columns: new[] { "CreatedDateTime", "PublicationDate" },
                values: new object[] { new DateTime(2024, 8, 16, 14, 36, 27, 274, DateTimeKind.Utc).AddTicks(2664), new DateTime(2024, 2, 21, 0, 56, 51, 963, DateTimeKind.Local).AddTicks(6673) });

            migrationBuilder.UpdateData(
                table: "Book",
                keyColumn: "BookId",
                keyValue: 1616,
                columns: new[] { "CreatedDateTime", "PublicationDate" },
                values: new object[] { new DateTime(2024, 8, 16, 14, 36, 27, 274, DateTimeKind.Utc).AddTicks(2790), new DateTime(2024, 5, 17, 3, 30, 22, 455, DateTimeKind.Local).AddTicks(3521) });

            migrationBuilder.UpdateData(
                table: "Book",
                keyColumn: "BookId",
                keyValue: 1617,
                columns: new[] { "CreatedDateTime", "PublicationDate" },
                values: new object[] { new DateTime(2024, 8, 16, 14, 36, 27, 274, DateTimeKind.Utc).AddTicks(2963), new DateTime(2023, 11, 18, 2, 39, 21, 195, DateTimeKind.Local).AddTicks(11) });

            migrationBuilder.UpdateData(
                table: "Book",
                keyColumn: "BookId",
                keyValue: 1618,
                columns: new[] { "CreatedDateTime", "PublicationDate" },
                values: new object[] { new DateTime(2024, 8, 16, 14, 36, 27, 274, DateTimeKind.Utc).AddTicks(3087), new DateTime(2023, 11, 12, 12, 6, 5, 936, DateTimeKind.Local).AddTicks(6037) });

            migrationBuilder.UpdateData(
                table: "Book",
                keyColumn: "BookId",
                keyValue: 1619,
                columns: new[] { "CreatedDateTime", "PublicationDate" },
                values: new object[] { new DateTime(2024, 8, 16, 14, 36, 27, 274, DateTimeKind.Utc).AddTicks(3280), new DateTime(2024, 2, 25, 14, 46, 33, 206, DateTimeKind.Local).AddTicks(4287) });

            migrationBuilder.UpdateData(
                table: "Book",
                keyColumn: "BookId",
                keyValue: 1620,
                columns: new[] { "CreatedDateTime", "PublicationDate" },
                values: new object[] { new DateTime(2024, 8, 16, 14, 36, 27, 274, DateTimeKind.Utc).AddTicks(3431), new DateTime(2023, 10, 19, 15, 22, 49, 108, DateTimeKind.Local).AddTicks(3457) });

            migrationBuilder.UpdateData(
                table: "Book",
                keyColumn: "BookId",
                keyValue: 1621,
                columns: new[] { "CreatedDateTime", "PublicationDate" },
                values: new object[] { new DateTime(2024, 8, 16, 14, 36, 27, 274, DateTimeKind.Utc).AddTicks(3585), new DateTime(2024, 7, 19, 10, 47, 58, 576, DateTimeKind.Local).AddTicks(343) });

            migrationBuilder.UpdateData(
                table: "Book",
                keyColumn: "BookId",
                keyValue: 1622,
                columns: new[] { "CreatedDateTime", "PublicationDate" },
                values: new object[] { new DateTime(2024, 8, 16, 14, 36, 27, 274, DateTimeKind.Utc).AddTicks(3753), new DateTime(2023, 8, 23, 19, 37, 34, 860, DateTimeKind.Local).AddTicks(2333) });

            migrationBuilder.UpdateData(
                table: "Book",
                keyColumn: "BookId",
                keyValue: 1623,
                columns: new[] { "CreatedDateTime", "PublicationDate" },
                values: new object[] { new DateTime(2024, 8, 16, 14, 36, 27, 274, DateTimeKind.Utc).AddTicks(3880), new DateTime(2024, 6, 9, 14, 32, 11, 728, DateTimeKind.Local).AddTicks(6039) });

            migrationBuilder.UpdateData(
                table: "Book",
                keyColumn: "BookId",
                keyValue: 1624,
                columns: new[] { "CreatedDateTime", "PublicationDate" },
                values: new object[] { new DateTime(2024, 8, 16, 14, 36, 27, 274, DateTimeKind.Utc).AddTicks(4046), new DateTime(2024, 6, 8, 12, 11, 2, 672, DateTimeKind.Local).AddTicks(3618) });

            migrationBuilder.UpdateData(
                table: "Book",
                keyColumn: "BookId",
                keyValue: 1625,
                columns: new[] { "CreatedDateTime", "PublicationDate" },
                values: new object[] { new DateTime(2024, 8, 16, 14, 36, 27, 274, DateTimeKind.Utc).AddTicks(4196), new DateTime(2023, 12, 7, 10, 53, 32, 858, DateTimeKind.Local).AddTicks(470) });

            migrationBuilder.UpdateData(
                table: "Book",
                keyColumn: "BookId",
                keyValue: 1626,
                columns: new[] { "CreatedDateTime", "PublicationDate" },
                values: new object[] { new DateTime(2024, 8, 16, 14, 36, 27, 274, DateTimeKind.Utc).AddTicks(4353), new DateTime(2023, 10, 13, 6, 25, 53, 787, DateTimeKind.Local).AddTicks(2020) });

            migrationBuilder.UpdateData(
                table: "Book",
                keyColumn: "BookId",
                keyValue: 1627,
                columns: new[] { "CreatedDateTime", "PublicationDate" },
                values: new object[] { new DateTime(2024, 8, 16, 14, 36, 27, 274, DateTimeKind.Utc).AddTicks(4487), new DateTime(2024, 4, 25, 2, 6, 23, 293, DateTimeKind.Local).AddTicks(6331) });

            migrationBuilder.UpdateData(
                table: "Book",
                keyColumn: "BookId",
                keyValue: 1628,
                columns: new[] { "CreatedDateTime", "PublicationDate" },
                values: new object[] { new DateTime(2024, 8, 16, 14, 36, 27, 274, DateTimeKind.Utc).AddTicks(4645), new DateTime(2024, 5, 9, 19, 27, 52, 264, DateTimeKind.Local).AddTicks(4896) });

            migrationBuilder.UpdateData(
                table: "Book",
                keyColumn: "BookId",
                keyValue: 1629,
                columns: new[] { "CreatedDateTime", "PublicationDate" },
                values: new object[] { new DateTime(2024, 8, 16, 14, 36, 27, 274, DateTimeKind.Utc).AddTicks(4788), new DateTime(2024, 3, 3, 7, 22, 17, 851, DateTimeKind.Local).AddTicks(5337) });

            migrationBuilder.UpdateData(
                table: "Book",
                keyColumn: "BookId",
                keyValue: 1630,
                columns: new[] { "CreatedDateTime", "PublicationDate" },
                values: new object[] { new DateTime(2024, 8, 16, 14, 36, 27, 274, DateTimeKind.Utc).AddTicks(4948), new DateTime(2023, 9, 20, 4, 10, 23, 523, DateTimeKind.Local).AddTicks(7715) });

            migrationBuilder.UpdateData(
                table: "Book",
                keyColumn: "BookId",
                keyValue: 1631,
                columns: new[] { "CreatedDateTime", "PublicationDate" },
                values: new object[] { new DateTime(2024, 8, 16, 14, 36, 27, 274, DateTimeKind.Utc).AddTicks(5069), new DateTime(2024, 6, 5, 17, 8, 18, 563, DateTimeKind.Local).AddTicks(577) });

            migrationBuilder.UpdateData(
                table: "Book",
                keyColumn: "BookId",
                keyValue: 1632,
                columns: new[] { "CreatedDateTime", "PublicationDate" },
                values: new object[] { new DateTime(2024, 8, 16, 14, 36, 27, 274, DateTimeKind.Utc).AddTicks(5234), new DateTime(2023, 11, 23, 14, 30, 20, 597, DateTimeKind.Local).AddTicks(2147) });

            migrationBuilder.UpdateData(
                table: "Book",
                keyColumn: "BookId",
                keyValue: 1633,
                columns: new[] { "CreatedDateTime", "PublicationDate" },
                values: new object[] { new DateTime(2024, 8, 16, 14, 36, 27, 274, DateTimeKind.Utc).AddTicks(5359), new DateTime(2024, 7, 27, 12, 18, 7, 715, DateTimeKind.Local).AddTicks(1701) });

            migrationBuilder.UpdateData(
                table: "Book",
                keyColumn: "BookId",
                keyValue: 1634,
                columns: new[] { "CreatedDateTime", "PublicationDate" },
                values: new object[] { new DateTime(2024, 8, 16, 14, 36, 27, 274, DateTimeKind.Utc).AddTicks(5520), new DateTime(2023, 12, 31, 12, 49, 26, 602, DateTimeKind.Local).AddTicks(4765) });

            migrationBuilder.UpdateData(
                table: "Book",
                keyColumn: "BookId",
                keyValue: 1635,
                columns: new[] { "CreatedDateTime", "PublicationDate" },
                values: new object[] { new DateTime(2024, 8, 16, 14, 36, 27, 274, DateTimeKind.Utc).AddTicks(5676), new DateTime(2023, 10, 10, 16, 47, 3, 900, DateTimeKind.Local).AddTicks(1027) });

            migrationBuilder.UpdateData(
                table: "Book",
                keyColumn: "BookId",
                keyValue: 1636,
                columns: new[] { "CreatedDateTime", "PublicationDate" },
                values: new object[] { new DateTime(2024, 8, 16, 14, 36, 27, 274, DateTimeKind.Utc).AddTicks(5803), new DateTime(2024, 8, 16, 0, 59, 15, 999, DateTimeKind.Local).AddTicks(522) });

            migrationBuilder.UpdateData(
                table: "Book",
                keyColumn: "BookId",
                keyValue: 1637,
                columns: new[] { "CreatedDateTime", "PublicationDate" },
                values: new object[] { new DateTime(2024, 8, 16, 14, 36, 27, 274, DateTimeKind.Utc).AddTicks(5974), new DateTime(2023, 12, 27, 20, 5, 9, 693, DateTimeKind.Local).AddTicks(2457) });

            migrationBuilder.UpdateData(
                table: "Book",
                keyColumn: "BookId",
                keyValue: 1638,
                columns: new[] { "CreatedDateTime", "PublicationDate" },
                values: new object[] { new DateTime(2024, 8, 16, 14, 36, 27, 274, DateTimeKind.Utc).AddTicks(6132), new DateTime(2023, 8, 20, 23, 52, 46, 167, DateTimeKind.Local).AddTicks(2932) });

            migrationBuilder.UpdateData(
                table: "Book",
                keyColumn: "BookId",
                keyValue: 1639,
                columns: new[] { "CreatedDateTime", "PublicationDate" },
                values: new object[] { new DateTime(2024, 8, 16, 14, 36, 27, 274, DateTimeKind.Utc).AddTicks(6283), new DateTime(2024, 5, 22, 17, 30, 15, 143, DateTimeKind.Local).AddTicks(2003) });

            migrationBuilder.UpdateData(
                table: "Book",
                keyColumn: "BookId",
                keyValue: 1640,
                columns: new[] { "CreatedDateTime", "PublicationDate" },
                values: new object[] { new DateTime(2024, 8, 16, 14, 36, 27, 274, DateTimeKind.Utc).AddTicks(6401), new DateTime(2024, 1, 19, 23, 9, 38, 189, DateTimeKind.Local).AddTicks(7249) });

            migrationBuilder.UpdateData(
                table: "Book",
                keyColumn: "BookId",
                keyValue: 1641,
                columns: new[] { "CreatedDateTime", "PublicationDate" },
                values: new object[] { new DateTime(2024, 8, 16, 14, 36, 27, 274, DateTimeKind.Utc).AddTicks(6552), new DateTime(2023, 9, 25, 2, 35, 11, 34, DateTimeKind.Local).AddTicks(9779) });

            migrationBuilder.UpdateData(
                table: "Book",
                keyColumn: "BookId",
                keyValue: 1642,
                columns: new[] { "CreatedDateTime", "PublicationDate" },
                values: new object[] { new DateTime(2024, 8, 16, 14, 36, 27, 274, DateTimeKind.Utc).AddTicks(6661), new DateTime(2024, 5, 18, 10, 56, 56, 283, DateTimeKind.Local).AddTicks(8233) });

            migrationBuilder.UpdateData(
                table: "Book",
                keyColumn: "BookId",
                keyValue: 1643,
                columns: new[] { "CreatedDateTime", "PublicationDate" },
                values: new object[] { new DateTime(2024, 8, 16, 14, 36, 27, 274, DateTimeKind.Utc).AddTicks(6797), new DateTime(2024, 5, 18, 17, 44, 36, 849, DateTimeKind.Local).AddTicks(2982) });

            migrationBuilder.UpdateData(
                table: "Book",
                keyColumn: "BookId",
                keyValue: 1644,
                columns: new[] { "CreatedDateTime", "PublicationDate" },
                values: new object[] { new DateTime(2024, 8, 16, 14, 36, 27, 274, DateTimeKind.Utc).AddTicks(6910), new DateTime(2023, 11, 8, 14, 16, 24, 226, DateTimeKind.Local).AddTicks(4207) });

            migrationBuilder.UpdateData(
                table: "Book",
                keyColumn: "BookId",
                keyValue: 1645,
                columns: new[] { "CreatedDateTime", "PublicationDate" },
                values: new object[] { new DateTime(2024, 8, 16, 14, 36, 27, 274, DateTimeKind.Utc).AddTicks(7031), new DateTime(2024, 1, 27, 4, 51, 41, 267, DateTimeKind.Local).AddTicks(3299) });

            migrationBuilder.UpdateData(
                table: "Book",
                keyColumn: "BookId",
                keyValue: 1646,
                columns: new[] { "CreatedDateTime", "PublicationDate" },
                values: new object[] { new DateTime(2024, 8, 16, 14, 36, 27, 274, DateTimeKind.Utc).AddTicks(7166), new DateTime(2024, 2, 25, 7, 50, 54, 421, DateTimeKind.Local).AddTicks(6168) });

            migrationBuilder.UpdateData(
                table: "Book",
                keyColumn: "BookId",
                keyValue: 1647,
                columns: new[] { "CreatedDateTime", "PublicationDate" },
                values: new object[] { new DateTime(2024, 8, 16, 14, 36, 27, 274, DateTimeKind.Utc).AddTicks(7282), new DateTime(2024, 1, 9, 4, 51, 26, 9, DateTimeKind.Local).AddTicks(7472) });

            migrationBuilder.UpdateData(
                table: "Book",
                keyColumn: "BookId",
                keyValue: 1648,
                columns: new[] { "CreatedDateTime", "PublicationDate" },
                values: new object[] { new DateTime(2024, 8, 16, 14, 36, 27, 274, DateTimeKind.Utc).AddTicks(7427), new DateTime(2024, 7, 16, 18, 8, 53, 422, DateTimeKind.Local).AddTicks(700) });

            migrationBuilder.UpdateData(
                table: "Book",
                keyColumn: "BookId",
                keyValue: 1649,
                columns: new[] { "CreatedDateTime", "PublicationDate" },
                values: new object[] { new DateTime(2024, 8, 16, 14, 36, 27, 274, DateTimeKind.Utc).AddTicks(7532), new DateTime(2024, 1, 28, 8, 39, 39, 761, DateTimeKind.Local).AddTicks(6529) });

            migrationBuilder.UpdateData(
                table: "Book",
                keyColumn: "BookId",
                keyValue: 1650,
                columns: new[] { "CreatedDateTime", "PublicationDate" },
                values: new object[] { new DateTime(2024, 8, 16, 14, 36, 27, 274, DateTimeKind.Utc).AddTicks(7659), new DateTime(2024, 5, 17, 13, 50, 8, 354, DateTimeKind.Local).AddTicks(8152) });

            migrationBuilder.UpdateData(
                table: "Book",
                keyColumn: "BookId",
                keyValue: 1651,
                columns: new[] { "CreatedDateTime", "PublicationDate" },
                values: new object[] { new DateTime(2024, 8, 16, 14, 36, 27, 274, DateTimeKind.Utc).AddTicks(7755), new DateTime(2024, 5, 15, 21, 44, 5, 573, DateTimeKind.Local).AddTicks(2774) });

            migrationBuilder.UpdateData(
                table: "Book",
                keyColumn: "BookId",
                keyValue: 1652,
                columns: new[] { "CreatedDateTime", "PublicationDate" },
                values: new object[] { new DateTime(2024, 8, 16, 14, 36, 27, 274, DateTimeKind.Utc).AddTicks(7881), new DateTime(2024, 6, 30, 22, 27, 50, 432, DateTimeKind.Local).AddTicks(2759) });

            migrationBuilder.UpdateData(
                table: "Book",
                keyColumn: "BookId",
                keyValue: 1653,
                columns: new[] { "CreatedDateTime", "PublicationDate" },
                values: new object[] { new DateTime(2024, 8, 16, 14, 36, 27, 274, DateTimeKind.Utc).AddTicks(7979), new DateTime(2024, 2, 24, 5, 39, 26, 309, DateTimeKind.Local).AddTicks(603) });

            migrationBuilder.UpdateData(
                table: "Book",
                keyColumn: "BookId",
                keyValue: 1654,
                columns: new[] { "CreatedDateTime", "PublicationDate" },
                values: new object[] { new DateTime(2024, 8, 16, 14, 36, 27, 274, DateTimeKind.Utc).AddTicks(8111), new DateTime(2024, 2, 10, 22, 56, 54, 527, DateTimeKind.Local).AddTicks(2456) });

            migrationBuilder.UpdateData(
                table: "Book",
                keyColumn: "BookId",
                keyValue: 1655,
                columns: new[] { "CreatedDateTime", "PublicationDate" },
                values: new object[] { new DateTime(2024, 8, 16, 14, 36, 27, 274, DateTimeKind.Utc).AddTicks(8214), new DateTime(2024, 8, 14, 6, 22, 37, 800, DateTimeKind.Local).AddTicks(9630) });

            migrationBuilder.UpdateData(
                table: "Book",
                keyColumn: "BookId",
                keyValue: 1656,
                columns: new[] { "CreatedDateTime", "PublicationDate" },
                values: new object[] { new DateTime(2024, 8, 16, 14, 36, 27, 274, DateTimeKind.Utc).AddTicks(8345), new DateTime(2023, 9, 12, 11, 55, 54, 705, DateTimeKind.Local).AddTicks(9566) });

            migrationBuilder.UpdateData(
                table: "Book",
                keyColumn: "BookId",
                keyValue: 1657,
                columns: new[] { "CreatedDateTime", "PublicationDate" },
                values: new object[] { new DateTime(2024, 8, 16, 14, 36, 27, 274, DateTimeKind.Utc).AddTicks(8453), new DateTime(2024, 5, 10, 19, 40, 6, 990, DateTimeKind.Local).AddTicks(1149) });

            migrationBuilder.UpdateData(
                table: "Book",
                keyColumn: "BookId",
                keyValue: 1658,
                columns: new[] { "CreatedDateTime", "PublicationDate" },
                values: new object[] { new DateTime(2024, 8, 16, 14, 36, 27, 274, DateTimeKind.Utc).AddTicks(8587), new DateTime(2024, 1, 12, 6, 25, 11, 821, DateTimeKind.Local).AddTicks(6067) });

            migrationBuilder.UpdateData(
                table: "Book",
                keyColumn: "BookId",
                keyValue: 1659,
                columns: new[] { "CreatedDateTime", "PublicationDate" },
                values: new object[] { new DateTime(2024, 8, 16, 14, 36, 27, 274, DateTimeKind.Utc).AddTicks(8691), new DateTime(2024, 6, 28, 14, 36, 57, 392, DateTimeKind.Local).AddTicks(9138) });

            migrationBuilder.UpdateData(
                table: "Book",
                keyColumn: "BookId",
                keyValue: 1660,
                columns: new[] { "CreatedDateTime", "PublicationDate" },
                values: new object[] { new DateTime(2024, 8, 16, 14, 36, 27, 274, DateTimeKind.Utc).AddTicks(8806), new DateTime(2023, 9, 14, 13, 22, 15, 469, DateTimeKind.Local).AddTicks(1328) });

            migrationBuilder.UpdateData(
                table: "Book",
                keyColumn: "BookId",
                keyValue: 1661,
                columns: new[] { "CreatedDateTime", "PublicationDate" },
                values: new object[] { new DateTime(2024, 8, 16, 14, 36, 27, 274, DateTimeKind.Utc).AddTicks(8903), new DateTime(2024, 1, 3, 11, 41, 15, 804, DateTimeKind.Local).AddTicks(1228) });

            migrationBuilder.UpdateData(
                table: "Book",
                keyColumn: "BookId",
                keyValue: 1662,
                columns: new[] { "CreatedDateTime", "PublicationDate" },
                values: new object[] { new DateTime(2024, 8, 16, 14, 36, 27, 274, DateTimeKind.Utc).AddTicks(9032), new DateTime(2024, 7, 30, 14, 0, 46, 937, DateTimeKind.Local).AddTicks(5278) });

            migrationBuilder.UpdateData(
                table: "Book",
                keyColumn: "BookId",
                keyValue: 1663,
                columns: new[] { "CreatedDateTime", "PublicationDate" },
                values: new object[] { new DateTime(2024, 8, 16, 14, 36, 27, 274, DateTimeKind.Utc).AddTicks(9126), new DateTime(2024, 4, 5, 5, 56, 12, 490, DateTimeKind.Local).AddTicks(8428) });

            migrationBuilder.UpdateData(
                table: "Book",
                keyColumn: "BookId",
                keyValue: 1664,
                columns: new[] { "CreatedDateTime", "PublicationDate" },
                values: new object[] { new DateTime(2024, 8, 16, 14, 36, 27, 274, DateTimeKind.Utc).AddTicks(9255), new DateTime(2023, 8, 24, 18, 49, 43, 898, DateTimeKind.Local).AddTicks(1584) });

            migrationBuilder.UpdateData(
                table: "Book",
                keyColumn: "BookId",
                keyValue: 1665,
                columns: new[] { "CreatedDateTime", "PublicationDate" },
                values: new object[] { new DateTime(2024, 8, 16, 14, 36, 27, 274, DateTimeKind.Utc).AddTicks(9349), new DateTime(2023, 12, 24, 8, 57, 44, 562, DateTimeKind.Local).AddTicks(6719) });

            migrationBuilder.UpdateData(
                table: "Book",
                keyColumn: "BookId",
                keyValue: 1666,
                columns: new[] { "CreatedDateTime", "PublicationDate" },
                values: new object[] { new DateTime(2024, 8, 16, 14, 36, 27, 274, DateTimeKind.Utc).AddTicks(9496), new DateTime(2024, 5, 6, 3, 4, 57, 18, DateTimeKind.Local).AddTicks(7457) });

            migrationBuilder.UpdateData(
                table: "Book",
                keyColumn: "BookId",
                keyValue: 1667,
                columns: new[] { "CreatedDateTime", "PublicationDate" },
                values: new object[] { new DateTime(2024, 8, 16, 14, 36, 27, 274, DateTimeKind.Utc).AddTicks(9599), new DateTime(2023, 8, 24, 15, 1, 2, 101, DateTimeKind.Local).AddTicks(7665) });

            migrationBuilder.UpdateData(
                table: "Book",
                keyColumn: "BookId",
                keyValue: 1668,
                columns: new[] { "CreatedDateTime", "PublicationDate" },
                values: new object[] { new DateTime(2024, 8, 16, 14, 36, 27, 274, DateTimeKind.Utc).AddTicks(9727), new DateTime(2023, 11, 25, 3, 15, 43, 745, DateTimeKind.Local).AddTicks(2942) });

            migrationBuilder.UpdateData(
                table: "Book",
                keyColumn: "BookId",
                keyValue: 1669,
                columns: new[] { "CreatedDateTime", "PublicationDate" },
                values: new object[] { new DateTime(2024, 8, 16, 14, 36, 27, 274, DateTimeKind.Utc).AddTicks(9818), new DateTime(2024, 4, 27, 20, 16, 38, 68, DateTimeKind.Local).AddTicks(3290) });

            migrationBuilder.UpdateData(
                table: "Book",
                keyColumn: "BookId",
                keyValue: 1670,
                columns: new[] { "CreatedDateTime", "PublicationDate" },
                values: new object[] { new DateTime(2024, 8, 16, 14, 36, 27, 274, DateTimeKind.Utc).AddTicks(9943), new DateTime(2024, 4, 1, 11, 32, 12, 62, DateTimeKind.Local).AddTicks(6142) });

            migrationBuilder.UpdateData(
                table: "Book",
                keyColumn: "BookId",
                keyValue: 1671,
                columns: new[] { "CreatedDateTime", "PublicationDate" },
                values: new object[] { new DateTime(2024, 8, 16, 14, 36, 27, 275, DateTimeKind.Utc).AddTicks(40), new DateTime(2024, 5, 1, 10, 47, 39, 831, DateTimeKind.Local).AddTicks(6168) });

            migrationBuilder.UpdateData(
                table: "Book",
                keyColumn: "BookId",
                keyValue: 1672,
                columns: new[] { "CreatedDateTime", "PublicationDate" },
                values: new object[] { new DateTime(2024, 8, 16, 14, 36, 27, 275, DateTimeKind.Utc).AddTicks(174), new DateTime(2023, 8, 30, 22, 37, 16, 265, DateTimeKind.Local).AddTicks(4861) });

            migrationBuilder.UpdateData(
                table: "Book",
                keyColumn: "BookId",
                keyValue: 1673,
                columns: new[] { "CreatedDateTime", "PublicationDate" },
                values: new object[] { new DateTime(2024, 8, 16, 14, 36, 27, 275, DateTimeKind.Utc).AddTicks(279), new DateTime(2024, 8, 11, 12, 8, 55, 532, DateTimeKind.Local).AddTicks(4143) });

            migrationBuilder.UpdateData(
                table: "Book",
                keyColumn: "BookId",
                keyValue: 1674,
                columns: new[] { "CreatedDateTime", "PublicationDate" },
                values: new object[] { new DateTime(2024, 8, 16, 14, 36, 27, 275, DateTimeKind.Utc).AddTicks(407), new DateTime(2024, 4, 26, 18, 13, 15, 611, DateTimeKind.Local).AddTicks(7715) });

            migrationBuilder.UpdateData(
                table: "Book",
                keyColumn: "BookId",
                keyValue: 1675,
                columns: new[] { "CreatedDateTime", "PublicationDate" },
                values: new object[] { new DateTime(2024, 8, 16, 14, 36, 27, 275, DateTimeKind.Utc).AddTicks(501), new DateTime(2024, 3, 6, 22, 3, 51, 744, DateTimeKind.Local).AddTicks(2250) });

            migrationBuilder.UpdateData(
                table: "Book",
                keyColumn: "BookId",
                keyValue: 1676,
                columns: new[] { "CreatedDateTime", "PublicationDate" },
                values: new object[] { new DateTime(2024, 8, 16, 14, 36, 27, 275, DateTimeKind.Utc).AddTicks(618), new DateTime(2024, 4, 10, 15, 13, 48, 578, DateTimeKind.Local).AddTicks(147) });

            migrationBuilder.UpdateData(
                table: "Book",
                keyColumn: "BookId",
                keyValue: 1677,
                columns: new[] { "CreatedDateTime", "PublicationDate" },
                values: new object[] { new DateTime(2024, 8, 16, 14, 36, 27, 275, DateTimeKind.Utc).AddTicks(721), new DateTime(2024, 3, 20, 18, 15, 39, 248, DateTimeKind.Local).AddTicks(20) });

            migrationBuilder.UpdateData(
                table: "Book",
                keyColumn: "BookId",
                keyValue: 1678,
                columns: new[] { "CreatedDateTime", "PublicationDate" },
                values: new object[] { new DateTime(2024, 8, 16, 14, 36, 27, 275, DateTimeKind.Utc).AddTicks(853), new DateTime(2024, 1, 26, 5, 41, 53, 343, DateTimeKind.Local).AddTicks(1487) });

            migrationBuilder.UpdateData(
                table: "Book",
                keyColumn: "BookId",
                keyValue: 1679,
                columns: new[] { "CreatedDateTime", "PublicationDate" },
                values: new object[] { new DateTime(2024, 8, 16, 14, 36, 27, 275, DateTimeKind.Utc).AddTicks(964), new DateTime(2023, 11, 15, 12, 54, 28, 903, DateTimeKind.Local).AddTicks(5364) });

            migrationBuilder.UpdateData(
                table: "Book",
                keyColumn: "BookId",
                keyValue: 1680,
                columns: new[] { "CreatedDateTime", "PublicationDate" },
                values: new object[] { new DateTime(2024, 8, 16, 14, 36, 27, 275, DateTimeKind.Utc).AddTicks(1095), new DateTime(2023, 10, 14, 11, 30, 3, 907, DateTimeKind.Local).AddTicks(3195) });

            migrationBuilder.UpdateData(
                table: "Book",
                keyColumn: "BookId",
                keyValue: 1681,
                columns: new[] { "CreatedDateTime", "PublicationDate" },
                values: new object[] { new DateTime(2024, 8, 16, 14, 36, 27, 275, DateTimeKind.Utc).AddTicks(1195), new DateTime(2024, 6, 6, 2, 6, 5, 967, DateTimeKind.Local).AddTicks(6607) });

            migrationBuilder.UpdateData(
                table: "Book",
                keyColumn: "BookId",
                keyValue: 1682,
                columns: new[] { "CreatedDateTime", "PublicationDate" },
                values: new object[] { new DateTime(2024, 8, 16, 14, 36, 27, 275, DateTimeKind.Utc).AddTicks(1324), new DateTime(2023, 8, 25, 23, 10, 34, 923, DateTimeKind.Local).AddTicks(8810) });

            migrationBuilder.UpdateData(
                table: "Book",
                keyColumn: "BookId",
                keyValue: 1683,
                columns: new[] { "CreatedDateTime", "PublicationDate" },
                values: new object[] { new DateTime(2024, 8, 16, 14, 36, 27, 275, DateTimeKind.Utc).AddTicks(1417), new DateTime(2023, 11, 25, 5, 48, 36, 151, DateTimeKind.Local).AddTicks(9660) });

            migrationBuilder.UpdateData(
                table: "Book",
                keyColumn: "BookId",
                keyValue: 1684,
                columns: new[] { "CreatedDateTime", "PublicationDate" },
                values: new object[] { new DateTime(2024, 8, 16, 14, 36, 27, 275, DateTimeKind.Utc).AddTicks(1547), new DateTime(2024, 6, 3, 23, 26, 10, 433, DateTimeKind.Local).AddTicks(5753) });

            migrationBuilder.UpdateData(
                table: "Book",
                keyColumn: "BookId",
                keyValue: 1685,
                columns: new[] { "CreatedDateTime", "PublicationDate" },
                values: new object[] { new DateTime(2024, 8, 16, 14, 36, 27, 275, DateTimeKind.Utc).AddTicks(1645), new DateTime(2023, 12, 13, 20, 7, 16, 806, DateTimeKind.Local).AddTicks(562) });

            migrationBuilder.UpdateData(
                table: "Book",
                keyColumn: "BookId",
                keyValue: 1686,
                columns: new[] { "CreatedDateTime", "PublicationDate" },
                values: new object[] { new DateTime(2024, 8, 16, 14, 36, 27, 275, DateTimeKind.Utc).AddTicks(1774), new DateTime(2023, 11, 9, 19, 35, 21, 679, DateTimeKind.Local).AddTicks(8604) });

            migrationBuilder.UpdateData(
                table: "Book",
                keyColumn: "BookId",
                keyValue: 1687,
                columns: new[] { "CreatedDateTime", "PublicationDate" },
                values: new object[] { new DateTime(2024, 8, 16, 14, 36, 27, 275, DateTimeKind.Utc).AddTicks(1868), new DateTime(2023, 10, 2, 8, 14, 44, 106, DateTimeKind.Local).AddTicks(1485) });

            migrationBuilder.UpdateData(
                table: "Book",
                keyColumn: "BookId",
                keyValue: 1688,
                columns: new[] { "CreatedDateTime", "PublicationDate" },
                values: new object[] { new DateTime(2024, 8, 16, 14, 36, 27, 275, DateTimeKind.Utc).AddTicks(2012), new DateTime(2023, 12, 28, 1, 17, 5, 349, DateTimeKind.Local).AddTicks(4929) });

            migrationBuilder.UpdateData(
                table: "Book",
                keyColumn: "BookId",
                keyValue: 1689,
                columns: new[] { "CreatedDateTime", "PublicationDate" },
                values: new object[] { new DateTime(2024, 8, 16, 14, 36, 27, 275, DateTimeKind.Utc).AddTicks(2140), new DateTime(2023, 11, 20, 2, 2, 58, 912, DateTimeKind.Local).AddTicks(4401) });

            migrationBuilder.UpdateData(
                table: "Book",
                keyColumn: "BookId",
                keyValue: 1690,
                columns: new[] { "CreatedDateTime", "PublicationDate" },
                values: new object[] { new DateTime(2024, 8, 16, 14, 36, 27, 275, DateTimeKind.Utc).AddTicks(2239), new DateTime(2024, 7, 26, 6, 16, 11, 121, DateTimeKind.Local).AddTicks(7894) });

            migrationBuilder.UpdateData(
                table: "Book",
                keyColumn: "BookId",
                keyValue: 1691,
                columns: new[] { "CreatedDateTime", "PublicationDate" },
                values: new object[] { new DateTime(2024, 8, 16, 14, 36, 27, 275, DateTimeKind.Utc).AddTicks(2376), new DateTime(2024, 7, 27, 7, 9, 39, 422, DateTimeKind.Local).AddTicks(2828) });

            migrationBuilder.UpdateData(
                table: "Book",
                keyColumn: "BookId",
                keyValue: 1692,
                columns: new[] { "CreatedDateTime", "PublicationDate" },
                values: new object[] { new DateTime(2024, 8, 16, 14, 36, 27, 275, DateTimeKind.Utc).AddTicks(2475), new DateTime(2024, 6, 1, 21, 16, 28, 780, DateTimeKind.Local).AddTicks(1210) });

            migrationBuilder.UpdateData(
                table: "Book",
                keyColumn: "BookId",
                keyValue: 1693,
                columns: new[] { "CreatedDateTime", "PublicationDate" },
                values: new object[] { new DateTime(2024, 8, 16, 14, 36, 27, 275, DateTimeKind.Utc).AddTicks(2611), new DateTime(2023, 12, 7, 20, 50, 10, 895, DateTimeKind.Local).AddTicks(7497) });

            migrationBuilder.UpdateData(
                table: "Book",
                keyColumn: "BookId",
                keyValue: 1694,
                columns: new[] { "CreatedDateTime", "PublicationDate" },
                values: new object[] { new DateTime(2024, 8, 16, 14, 36, 27, 275, DateTimeKind.Utc).AddTicks(2710), new DateTime(2024, 4, 6, 17, 42, 6, 13, DateTimeKind.Local).AddTicks(2937) });

            migrationBuilder.UpdateData(
                table: "Book",
                keyColumn: "BookId",
                keyValue: 1695,
                columns: new[] { "CreatedDateTime", "PublicationDate" },
                values: new object[] { new DateTime(2024, 8, 16, 14, 36, 27, 275, DateTimeKind.Utc).AddTicks(2838), new DateTime(2024, 5, 30, 13, 18, 48, 335, DateTimeKind.Local).AddTicks(726) });

            migrationBuilder.UpdateData(
                table: "Book",
                keyColumn: "BookId",
                keyValue: 1696,
                columns: new[] { "CreatedDateTime", "PublicationDate" },
                values: new object[] { new DateTime(2024, 8, 16, 14, 36, 27, 275, DateTimeKind.Utc).AddTicks(2932), new DateTime(2024, 5, 12, 10, 0, 40, 576, DateTimeKind.Local).AddTicks(236) });

            migrationBuilder.UpdateData(
                table: "Book",
                keyColumn: "BookId",
                keyValue: 1697,
                columns: new[] { "CreatedDateTime", "PublicationDate" },
                values: new object[] { new DateTime(2024, 8, 16, 14, 36, 27, 275, DateTimeKind.Utc).AddTicks(3065), new DateTime(2023, 12, 7, 12, 44, 58, 25, DateTimeKind.Local).AddTicks(859) });

            migrationBuilder.UpdateData(
                table: "Book",
                keyColumn: "BookId",
                keyValue: 1698,
                columns: new[] { "CreatedDateTime", "PublicationDate" },
                values: new object[] { new DateTime(2024, 8, 16, 14, 36, 27, 275, DateTimeKind.Utc).AddTicks(3200), new DateTime(2024, 5, 18, 18, 52, 45, 808, DateTimeKind.Local).AddTicks(3288) });

            migrationBuilder.UpdateData(
                table: "Book",
                keyColumn: "BookId",
                keyValue: 1699,
                columns: new[] { "CreatedDateTime", "PublicationDate" },
                values: new object[] { new DateTime(2024, 8, 16, 14, 36, 27, 275, DateTimeKind.Utc).AddTicks(3295), new DateTime(2023, 12, 31, 2, 34, 14, 610, DateTimeKind.Local).AddTicks(868) });

            migrationBuilder.UpdateData(
                table: "Book",
                keyColumn: "BookId",
                keyValue: 1700,
                columns: new[] { "CreatedDateTime", "PublicationDate" },
                values: new object[] { new DateTime(2024, 8, 16, 14, 36, 27, 275, DateTimeKind.Utc).AddTicks(3427), new DateTime(2024, 3, 1, 6, 33, 46, 571, DateTimeKind.Local).AddTicks(4611) });

            migrationBuilder.UpdateData(
                table: "Book",
                keyColumn: "BookId",
                keyValue: 1701,
                columns: new[] { "CreatedDateTime", "PublicationDate" },
                values: new object[] { new DateTime(2024, 8, 16, 14, 36, 27, 275, DateTimeKind.Utc).AddTicks(3529), new DateTime(2023, 8, 18, 0, 50, 33, 569, DateTimeKind.Local).AddTicks(9845) });

            migrationBuilder.UpdateData(
                table: "Book",
                keyColumn: "BookId",
                keyValue: 1702,
                columns: new[] { "CreatedDateTime", "PublicationDate" },
                values: new object[] { new DateTime(2024, 8, 16, 14, 36, 27, 275, DateTimeKind.Utc).AddTicks(3651), new DateTime(2024, 2, 14, 2, 44, 19, 929, DateTimeKind.Local).AddTicks(5918) });

            migrationBuilder.UpdateData(
                table: "Book",
                keyColumn: "BookId",
                keyValue: 1703,
                columns: new[] { "CreatedDateTime", "PublicationDate" },
                values: new object[] { new DateTime(2024, 8, 16, 14, 36, 27, 275, DateTimeKind.Utc).AddTicks(3749), new DateTime(2024, 6, 10, 23, 42, 21, 30, DateTimeKind.Local).AddTicks(630) });

            migrationBuilder.UpdateData(
                table: "Book",
                keyColumn: "BookId",
                keyValue: 1704,
                columns: new[] { "CreatedDateTime", "PublicationDate" },
                values: new object[] { new DateTime(2024, 8, 16, 14, 36, 27, 275, DateTimeKind.Utc).AddTicks(3874), new DateTime(2023, 10, 7, 15, 35, 4, 829, DateTimeKind.Local).AddTicks(4763) });

            migrationBuilder.UpdateData(
                table: "Book",
                keyColumn: "BookId",
                keyValue: 1705,
                columns: new[] { "CreatedDateTime", "PublicationDate" },
                values: new object[] { new DateTime(2024, 8, 16, 14, 36, 27, 275, DateTimeKind.Utc).AddTicks(3988), new DateTime(2023, 11, 30, 16, 6, 23, 949, DateTimeKind.Local).AddTicks(7747) });

            migrationBuilder.UpdateData(
                table: "Book",
                keyColumn: "BookId",
                keyValue: 1706,
                columns: new[] { "CreatedDateTime", "PublicationDate" },
                values: new object[] { new DateTime(2024, 8, 16, 14, 36, 27, 275, DateTimeKind.Utc).AddTicks(4122), new DateTime(2024, 2, 18, 9, 53, 32, 368, DateTimeKind.Local).AddTicks(2023) });

            migrationBuilder.UpdateData(
                table: "Book",
                keyColumn: "BookId",
                keyValue: 1707,
                columns: new[] { "CreatedDateTime", "PublicationDate" },
                values: new object[] { new DateTime(2024, 8, 16, 14, 36, 27, 275, DateTimeKind.Utc).AddTicks(4223), new DateTime(2024, 4, 20, 6, 27, 11, 418, DateTimeKind.Local).AddTicks(5065) });

            migrationBuilder.UpdateData(
                table: "Book",
                keyColumn: "BookId",
                keyValue: 1708,
                columns: new[] { "CreatedDateTime", "PublicationDate" },
                values: new object[] { new DateTime(2024, 8, 16, 14, 36, 27, 275, DateTimeKind.Utc).AddTicks(4352), new DateTime(2024, 2, 5, 5, 6, 51, 986, DateTimeKind.Local).AddTicks(4781) });

            migrationBuilder.UpdateData(
                table: "Book",
                keyColumn: "BookId",
                keyValue: 1709,
                columns: new[] { "CreatedDateTime", "PublicationDate" },
                values: new object[] { new DateTime(2024, 8, 16, 14, 36, 27, 275, DateTimeKind.Utc).AddTicks(4454), new DateTime(2024, 2, 11, 15, 31, 8, 817, DateTimeKind.Local).AddTicks(4995) });

            migrationBuilder.UpdateData(
                table: "Book",
                keyColumn: "BookId",
                keyValue: 1710,
                columns: new[] { "CreatedDateTime", "PublicationDate" },
                values: new object[] { new DateTime(2024, 8, 16, 14, 36, 27, 275, DateTimeKind.Utc).AddTicks(4592), new DateTime(2024, 4, 20, 15, 7, 14, 461, DateTimeKind.Local).AddTicks(1370) });

            migrationBuilder.UpdateData(
                table: "Book",
                keyColumn: "BookId",
                keyValue: 1711,
                columns: new[] { "CreatedDateTime", "PublicationDate" },
                values: new object[] { new DateTime(2024, 8, 16, 14, 36, 27, 275, DateTimeKind.Utc).AddTicks(4707), new DateTime(2024, 6, 14, 3, 15, 37, 399, DateTimeKind.Local).AddTicks(156) });

            migrationBuilder.UpdateData(
                table: "Book",
                keyColumn: "BookId",
                keyValue: 1712,
                columns: new[] { "CreatedDateTime", "PublicationDate" },
                values: new object[] { new DateTime(2024, 8, 16, 14, 36, 27, 275, DateTimeKind.Utc).AddTicks(4803), new DateTime(2024, 5, 23, 12, 19, 9, 986, DateTimeKind.Local).AddTicks(5818) });

            migrationBuilder.UpdateData(
                table: "Book",
                keyColumn: "BookId",
                keyValue: 1713,
                columns: new[] { "CreatedDateTime", "PublicationDate" },
                values: new object[] { new DateTime(2024, 8, 16, 14, 36, 27, 275, DateTimeKind.Utc).AddTicks(4929), new DateTime(2024, 1, 14, 22, 57, 9, 956, DateTimeKind.Local).AddTicks(8110) });

            migrationBuilder.UpdateData(
                table: "Book",
                keyColumn: "BookId",
                keyValue: 1714,
                columns: new[] { "CreatedDateTime", "PublicationDate" },
                values: new object[] { new DateTime(2024, 8, 16, 14, 36, 27, 275, DateTimeKind.Utc).AddTicks(5025), new DateTime(2024, 6, 9, 5, 50, 36, 977, DateTimeKind.Local).AddTicks(7799) });

            migrationBuilder.UpdateData(
                table: "Book",
                keyColumn: "BookId",
                keyValue: 1715,
                columns: new[] { "CreatedDateTime", "PublicationDate" },
                values: new object[] { new DateTime(2024, 8, 16, 14, 36, 27, 275, DateTimeKind.Utc).AddTicks(5159), new DateTime(2024, 3, 28, 10, 2, 35, 693, DateTimeKind.Local).AddTicks(4233) });

            migrationBuilder.UpdateData(
                table: "Book",
                keyColumn: "BookId",
                keyValue: 1716,
                columns: new[] { "CreatedDateTime", "PublicationDate" },
                values: new object[] { new DateTime(2024, 8, 16, 14, 36, 27, 275, DateTimeKind.Utc).AddTicks(5276), new DateTime(2023, 8, 30, 21, 36, 56, 88, DateTimeKind.Local).AddTicks(4080) });

            migrationBuilder.UpdateData(
                table: "Book",
                keyColumn: "BookId",
                keyValue: 1717,
                columns: new[] { "CreatedDateTime", "PublicationDate" },
                values: new object[] { new DateTime(2024, 8, 16, 14, 36, 27, 275, DateTimeKind.Utc).AddTicks(5394), new DateTime(2023, 12, 2, 22, 11, 46, 718, DateTimeKind.Local).AddTicks(3188) });

            migrationBuilder.UpdateData(
                table: "Book",
                keyColumn: "BookId",
                keyValue: 1718,
                columns: new[] { "CreatedDateTime", "PublicationDate" },
                values: new object[] { new DateTime(2024, 8, 16, 14, 36, 27, 275, DateTimeKind.Utc).AddTicks(5499), new DateTime(2024, 4, 16, 16, 8, 36, 362, DateTimeKind.Local).AddTicks(2) });

            migrationBuilder.UpdateData(
                table: "Book",
                keyColumn: "BookId",
                keyValue: 1719,
                columns: new[] { "CreatedDateTime", "PublicationDate" },
                values: new object[] { new DateTime(2024, 8, 16, 14, 36, 27, 275, DateTimeKind.Utc).AddTicks(5615), new DateTime(2024, 4, 9, 15, 29, 6, 712, DateTimeKind.Local).AddTicks(3795) });

            migrationBuilder.UpdateData(
                table: "Book",
                keyColumn: "BookId",
                keyValue: 1720,
                columns: new[] { "CreatedDateTime", "PublicationDate" },
                values: new object[] { new DateTime(2024, 8, 16, 14, 36, 27, 275, DateTimeKind.Utc).AddTicks(5711), new DateTime(2024, 8, 9, 21, 26, 34, 765, DateTimeKind.Local).AddTicks(4488) });

            migrationBuilder.UpdateData(
                table: "Book",
                keyColumn: "BookId",
                keyValue: 1721,
                columns: new[] { "CreatedDateTime", "PublicationDate" },
                values: new object[] { new DateTime(2024, 8, 16, 14, 36, 27, 275, DateTimeKind.Utc).AddTicks(5835), new DateTime(2023, 9, 22, 1, 45, 19, 614, DateTimeKind.Local).AddTicks(7134) });

            migrationBuilder.UpdateData(
                table: "Book",
                keyColumn: "BookId",
                keyValue: 1722,
                columns: new[] { "CreatedDateTime", "PublicationDate" },
                values: new object[] { new DateTime(2024, 8, 16, 14, 36, 27, 275, DateTimeKind.Utc).AddTicks(5941), new DateTime(2024, 6, 11, 20, 15, 30, 750, DateTimeKind.Local).AddTicks(1757) });

            migrationBuilder.UpdateData(
                table: "Book",
                keyColumn: "BookId",
                keyValue: 1723,
                columns: new[] { "CreatedDateTime", "PublicationDate" },
                values: new object[] { new DateTime(2024, 8, 16, 14, 36, 27, 275, DateTimeKind.Utc).AddTicks(6069), new DateTime(2024, 3, 11, 4, 32, 28, 98, DateTimeKind.Local).AddTicks(7889) });

            migrationBuilder.UpdateData(
                table: "Book",
                keyColumn: "BookId",
                keyValue: 1724,
                columns: new[] { "CreatedDateTime", "PublicationDate" },
                values: new object[] { new DateTime(2024, 8, 16, 14, 36, 27, 275, DateTimeKind.Utc).AddTicks(6171), new DateTime(2023, 12, 3, 5, 41, 10, 457, DateTimeKind.Local).AddTicks(108) });

            migrationBuilder.UpdateData(
                table: "Book",
                keyColumn: "BookId",
                keyValue: 1725,
                columns: new[] { "CreatedDateTime", "PublicationDate" },
                values: new object[] { new DateTime(2024, 8, 16, 14, 36, 27, 275, DateTimeKind.Utc).AddTicks(6299), new DateTime(2024, 3, 7, 15, 46, 35, 770, DateTimeKind.Local).AddTicks(2469) });

            migrationBuilder.UpdateData(
                table: "Book",
                keyColumn: "BookId",
                keyValue: 1726,
                columns: new[] { "CreatedDateTime", "PublicationDate" },
                values: new object[] { new DateTime(2024, 8, 16, 14, 36, 27, 275, DateTimeKind.Utc).AddTicks(6398), new DateTime(2023, 9, 27, 16, 39, 56, 109, DateTimeKind.Local).AddTicks(2064) });

            migrationBuilder.UpdateData(
                table: "Book",
                keyColumn: "BookId",
                keyValue: 1727,
                columns: new[] { "CreatedDateTime", "PublicationDate" },
                values: new object[] { new DateTime(2024, 8, 16, 14, 36, 27, 275, DateTimeKind.Utc).AddTicks(6502), new DateTime(2023, 8, 18, 18, 59, 9, 100, DateTimeKind.Local).AddTicks(4051) });

            migrationBuilder.UpdateData(
                table: "Book",
                keyColumn: "BookId",
                keyValue: 1728,
                columns: new[] { "CreatedDateTime", "PublicationDate" },
                values: new object[] { new DateTime(2024, 8, 16, 14, 36, 27, 275, DateTimeKind.Utc).AddTicks(6604), new DateTime(2024, 5, 21, 7, 36, 49, 650, DateTimeKind.Local).AddTicks(7207) });

            migrationBuilder.UpdateData(
                table: "Book",
                keyColumn: "BookId",
                keyValue: 1729,
                columns: new[] { "CreatedDateTime", "PublicationDate" },
                values: new object[] { new DateTime(2024, 8, 16, 14, 36, 27, 275, DateTimeKind.Utc).AddTicks(6736), new DateTime(2023, 12, 18, 10, 16, 28, 639, DateTimeKind.Local).AddTicks(1725) });

            migrationBuilder.UpdateData(
                table: "Book",
                keyColumn: "BookId",
                keyValue: 1730,
                columns: new[] { "CreatedDateTime", "PublicationDate" },
                values: new object[] { new DateTime(2024, 8, 16, 14, 36, 27, 275, DateTimeKind.Utc).AddTicks(6834), new DateTime(2024, 4, 21, 14, 21, 52, 681, DateTimeKind.Local).AddTicks(342) });

            migrationBuilder.UpdateData(
                table: "Book",
                keyColumn: "BookId",
                keyValue: 1731,
                columns: new[] { "CreatedDateTime", "PublicationDate" },
                values: new object[] { new DateTime(2024, 8, 16, 14, 36, 27, 275, DateTimeKind.Utc).AddTicks(6964), new DateTime(2024, 4, 2, 5, 44, 56, 834, DateTimeKind.Local).AddTicks(3336) });

            migrationBuilder.UpdateData(
                table: "Book",
                keyColumn: "BookId",
                keyValue: 1732,
                columns: new[] { "CreatedDateTime", "PublicationDate" },
                values: new object[] { new DateTime(2024, 8, 16, 14, 36, 27, 275, DateTimeKind.Utc).AddTicks(7054), new DateTime(2024, 4, 2, 12, 17, 36, 798, DateTimeKind.Local).AddTicks(7839) });

            migrationBuilder.UpdateData(
                table: "Book",
                keyColumn: "BookId",
                keyValue: 1733,
                columns: new[] { "CreatedDateTime", "PublicationDate" },
                values: new object[] { new DateTime(2024, 8, 16, 14, 36, 27, 275, DateTimeKind.Utc).AddTicks(7201), new DateTime(2024, 2, 5, 23, 49, 21, 585, DateTimeKind.Local).AddTicks(2763) });

            migrationBuilder.UpdateData(
                table: "Book",
                keyColumn: "BookId",
                keyValue: 1734,
                columns: new[] { "CreatedDateTime", "PublicationDate" },
                values: new object[] { new DateTime(2024, 8, 16, 14, 36, 27, 275, DateTimeKind.Utc).AddTicks(7302), new DateTime(2024, 7, 9, 20, 29, 39, 187, DateTimeKind.Local).AddTicks(7937) });

            migrationBuilder.UpdateData(
                table: "Book",
                keyColumn: "BookId",
                keyValue: 1735,
                columns: new[] { "CreatedDateTime", "PublicationDate" },
                values: new object[] { new DateTime(2024, 8, 16, 14, 36, 27, 275, DateTimeKind.Utc).AddTicks(7430), new DateTime(2024, 3, 24, 11, 38, 14, 634, DateTimeKind.Local).AddTicks(3192) });

            migrationBuilder.UpdateData(
                table: "Book",
                keyColumn: "BookId",
                keyValue: 1736,
                columns: new[] { "CreatedDateTime", "PublicationDate" },
                values: new object[] { new DateTime(2024, 8, 16, 14, 36, 27, 275, DateTimeKind.Utc).AddTicks(7523), new DateTime(2024, 3, 27, 3, 23, 57, 884, DateTimeKind.Local).AddTicks(137) });

            migrationBuilder.UpdateData(
                table: "Book",
                keyColumn: "BookId",
                keyValue: 1737,
                columns: new[] { "CreatedDateTime", "PublicationDate" },
                values: new object[] { new DateTime(2024, 8, 16, 14, 36, 27, 275, DateTimeKind.Utc).AddTicks(7657), new DateTime(2024, 8, 14, 12, 22, 49, 664, DateTimeKind.Local).AddTicks(4124) });

            migrationBuilder.UpdateData(
                table: "Book",
                keyColumn: "BookId",
                keyValue: 1738,
                columns: new[] { "CreatedDateTime", "PublicationDate" },
                values: new object[] { new DateTime(2024, 8, 16, 14, 36, 27, 275, DateTimeKind.Utc).AddTicks(7753), new DateTime(2023, 10, 11, 19, 7, 41, 253, DateTimeKind.Local).AddTicks(9408) });

            migrationBuilder.UpdateData(
                table: "Book",
                keyColumn: "BookId",
                keyValue: 1739,
                columns: new[] { "CreatedDateTime", "PublicationDate" },
                values: new object[] { new DateTime(2024, 8, 16, 14, 36, 27, 275, DateTimeKind.Utc).AddTicks(7880), new DateTime(2023, 8, 19, 17, 8, 17, 586, DateTimeKind.Local).AddTicks(7879) });

            migrationBuilder.UpdateData(
                table: "Book",
                keyColumn: "BookId",
                keyValue: 1740,
                columns: new[] { "CreatedDateTime", "PublicationDate" },
                values: new object[] { new DateTime(2024, 8, 16, 14, 36, 27, 275, DateTimeKind.Utc).AddTicks(7971), new DateTime(2023, 11, 1, 4, 51, 38, 106, DateTimeKind.Local).AddTicks(7053) });

            migrationBuilder.UpdateData(
                table: "Book",
                keyColumn: "BookId",
                keyValue: 1741,
                columns: new[] { "CreatedDateTime", "PublicationDate" },
                values: new object[] { new DateTime(2024, 8, 16, 14, 36, 27, 275, DateTimeKind.Utc).AddTicks(8098), new DateTime(2023, 11, 17, 8, 36, 56, 185, DateTimeKind.Local).AddTicks(788) });

            migrationBuilder.UpdateData(
                table: "Book",
                keyColumn: "BookId",
                keyValue: 1742,
                columns: new[] { "CreatedDateTime", "PublicationDate" },
                values: new object[] { new DateTime(2024, 8, 16, 14, 36, 27, 275, DateTimeKind.Utc).AddTicks(8198), new DateTime(2023, 11, 19, 13, 2, 42, 429, DateTimeKind.Local).AddTicks(16) });

            migrationBuilder.UpdateData(
                table: "Book",
                keyColumn: "BookId",
                keyValue: 1743,
                columns: new[] { "CreatedDateTime", "PublicationDate" },
                values: new object[] { new DateTime(2024, 8, 16, 14, 36, 27, 275, DateTimeKind.Utc).AddTicks(8324), new DateTime(2023, 12, 31, 18, 41, 59, 610, DateTimeKind.Local).AddTicks(3336) });

            migrationBuilder.UpdateData(
                table: "Book",
                keyColumn: "BookId",
                keyValue: 1744,
                columns: new[] { "CreatedDateTime", "PublicationDate" },
                values: new object[] { new DateTime(2024, 8, 16, 14, 36, 27, 275, DateTimeKind.Utc).AddTicks(8413), new DateTime(2023, 11, 9, 21, 47, 42, 195, DateTimeKind.Local).AddTicks(5797) });

            migrationBuilder.UpdateData(
                table: "Book",
                keyColumn: "BookId",
                keyValue: 1745,
                columns: new[] { "CreatedDateTime", "PublicationDate" },
                values: new object[] { new DateTime(2024, 8, 16, 14, 36, 27, 275, DateTimeKind.Utc).AddTicks(8554), new DateTime(2024, 7, 14, 15, 15, 0, 724, DateTimeKind.Local).AddTicks(7449) });

            migrationBuilder.UpdateData(
                table: "Book",
                keyColumn: "BookId",
                keyValue: 1746,
                columns: new[] { "CreatedDateTime", "PublicationDate" },
                values: new object[] { new DateTime(2024, 8, 16, 14, 36, 27, 275, DateTimeKind.Utc).AddTicks(8650), new DateTime(2024, 6, 16, 9, 50, 44, 8, DateTimeKind.Local).AddTicks(7193) });

            migrationBuilder.UpdateData(
                table: "Book",
                keyColumn: "BookId",
                keyValue: 1747,
                columns: new[] { "CreatedDateTime", "PublicationDate" },
                values: new object[] { new DateTime(2024, 8, 16, 14, 36, 27, 275, DateTimeKind.Utc).AddTicks(8792), new DateTime(2023, 9, 24, 13, 45, 7, 979, DateTimeKind.Local).AddTicks(8472) });

            migrationBuilder.UpdateData(
                table: "Book",
                keyColumn: "BookId",
                keyValue: 1748,
                columns: new[] { "CreatedDateTime", "PublicationDate" },
                values: new object[] { new DateTime(2024, 8, 16, 14, 36, 27, 275, DateTimeKind.Utc).AddTicks(8894), new DateTime(2024, 7, 29, 20, 32, 18, 12, DateTimeKind.Local).AddTicks(8425) });

            migrationBuilder.UpdateData(
                table: "Book",
                keyColumn: "BookId",
                keyValue: 1749,
                columns: new[] { "CreatedDateTime", "PublicationDate" },
                values: new object[] { new DateTime(2024, 8, 16, 14, 36, 27, 275, DateTimeKind.Utc).AddTicks(9032), new DateTime(2024, 3, 16, 21, 51, 3, 707, DateTimeKind.Local).AddTicks(5604) });

            migrationBuilder.UpdateData(
                table: "Book",
                keyColumn: "BookId",
                keyValue: 1750,
                columns: new[] { "CreatedDateTime", "PublicationDate" },
                values: new object[] { new DateTime(2024, 8, 16, 14, 36, 27, 275, DateTimeKind.Utc).AddTicks(9166), new DateTime(2024, 2, 16, 8, 20, 56, 271, DateTimeKind.Local).AddTicks(7041) });

            migrationBuilder.UpdateData(
                table: "Book",
                keyColumn: "BookId",
                keyValue: 1751,
                columns: new[] { "CreatedDateTime", "PublicationDate" },
                values: new object[] { new DateTime(2024, 8, 16, 14, 36, 27, 275, DateTimeKind.Utc).AddTicks(9274), new DateTime(2024, 6, 22, 0, 55, 2, 875, DateTimeKind.Local).AddTicks(1906) });

            migrationBuilder.UpdateData(
                table: "Book",
                keyColumn: "BookId",
                keyValue: 1752,
                columns: new[] { "CreatedDateTime", "PublicationDate" },
                values: new object[] { new DateTime(2024, 8, 16, 14, 36, 27, 275, DateTimeKind.Utc).AddTicks(9388), new DateTime(2024, 2, 4, 13, 55, 49, 657, DateTimeKind.Local).AddTicks(141) });

            migrationBuilder.UpdateData(
                table: "Book",
                keyColumn: "BookId",
                keyValue: 1753,
                columns: new[] { "CreatedDateTime", "PublicationDate" },
                values: new object[] { new DateTime(2024, 8, 16, 14, 36, 27, 275, DateTimeKind.Utc).AddTicks(9489), new DateTime(2024, 6, 3, 4, 23, 1, 522, DateTimeKind.Local).AddTicks(8460) });

            migrationBuilder.UpdateData(
                table: "Book",
                keyColumn: "BookId",
                keyValue: 1754,
                columns: new[] { "CreatedDateTime", "PublicationDate" },
                values: new object[] { new DateTime(2024, 8, 16, 14, 36, 27, 275, DateTimeKind.Utc).AddTicks(9618), new DateTime(2024, 4, 30, 7, 50, 4, 919, DateTimeKind.Local).AddTicks(2461) });

            migrationBuilder.UpdateData(
                table: "Book",
                keyColumn: "BookId",
                keyValue: 1755,
                columns: new[] { "CreatedDateTime", "PublicationDate" },
                values: new object[] { new DateTime(2024, 8, 16, 14, 36, 27, 275, DateTimeKind.Utc).AddTicks(9712), new DateTime(2023, 12, 14, 12, 8, 27, 182, DateTimeKind.Local).AddTicks(5566) });

            migrationBuilder.UpdateData(
                table: "Book",
                keyColumn: "BookId",
                keyValue: 1756,
                columns: new[] { "CreatedDateTime", "PublicationDate" },
                values: new object[] { new DateTime(2024, 8, 16, 14, 36, 27, 275, DateTimeKind.Utc).AddTicks(9849), new DateTime(2024, 2, 16, 13, 26, 19, 806, DateTimeKind.Local).AddTicks(6711) });

            migrationBuilder.UpdateData(
                table: "Book",
                keyColumn: "BookId",
                keyValue: 1757,
                columns: new[] { "CreatedDateTime", "PublicationDate" },
                values: new object[] { new DateTime(2024, 8, 16, 14, 36, 27, 275, DateTimeKind.Utc).AddTicks(9949), new DateTime(2024, 1, 2, 21, 5, 53, 919, DateTimeKind.Local).AddTicks(4126) });

            migrationBuilder.UpdateData(
                table: "Book",
                keyColumn: "BookId",
                keyValue: 1758,
                columns: new[] { "CreatedDateTime", "PublicationDate" },
                values: new object[] { new DateTime(2024, 8, 16, 14, 36, 27, 276, DateTimeKind.Utc).AddTicks(59), new DateTime(2023, 11, 14, 3, 9, 9, 243, DateTimeKind.Local).AddTicks(6586) });

            migrationBuilder.UpdateData(
                table: "Book",
                keyColumn: "BookId",
                keyValue: 1759,
                columns: new[] { "CreatedDateTime", "PublicationDate" },
                values: new object[] { new DateTime(2024, 8, 16, 14, 36, 27, 276, DateTimeKind.Utc).AddTicks(142), new DateTime(2024, 4, 29, 13, 54, 36, 870, DateTimeKind.Local).AddTicks(2397) });

            migrationBuilder.UpdateData(
                table: "Book",
                keyColumn: "BookId",
                keyValue: 1760,
                columns: new[] { "CreatedDateTime", "PublicationDate" },
                values: new object[] { new DateTime(2024, 8, 16, 14, 36, 27, 276, DateTimeKind.Utc).AddTicks(257), new DateTime(2024, 1, 2, 17, 58, 49, 759, DateTimeKind.Local).AddTicks(4358) });

            migrationBuilder.UpdateData(
                table: "Book",
                keyColumn: "BookId",
                keyValue: 1761,
                columns: new[] { "CreatedDateTime", "PublicationDate" },
                values: new object[] { new DateTime(2024, 8, 16, 14, 36, 27, 276, DateTimeKind.Utc).AddTicks(349), new DateTime(2024, 6, 1, 16, 20, 49, 488, DateTimeKind.Local).AddTicks(1031) });

            migrationBuilder.UpdateData(
                table: "Book",
                keyColumn: "BookId",
                keyValue: 1762,
                columns: new[] { "CreatedDateTime", "PublicationDate" },
                values: new object[] { new DateTime(2024, 8, 16, 14, 36, 27, 276, DateTimeKind.Utc).AddTicks(488), new DateTime(2024, 6, 14, 19, 56, 12, 456, DateTimeKind.Local).AddTicks(7283) });

            migrationBuilder.UpdateData(
                table: "Book",
                keyColumn: "BookId",
                keyValue: 1763,
                columns: new[] { "CreatedDateTime", "PublicationDate" },
                values: new object[] { new DateTime(2024, 8, 16, 14, 36, 27, 276, DateTimeKind.Utc).AddTicks(584), new DateTime(2024, 6, 16, 0, 23, 17, 417, DateTimeKind.Local).AddTicks(2252) });

            migrationBuilder.UpdateData(
                table: "Book",
                keyColumn: "BookId",
                keyValue: 1764,
                columns: new[] { "CreatedDateTime", "PublicationDate" },
                values: new object[] { new DateTime(2024, 8, 16, 14, 36, 27, 276, DateTimeKind.Utc).AddTicks(749), new DateTime(2024, 3, 14, 5, 29, 45, 771, DateTimeKind.Local).AddTicks(5015) });

            migrationBuilder.UpdateData(
                table: "Book",
                keyColumn: "BookId",
                keyValue: 1765,
                columns: new[] { "CreatedDateTime", "PublicationDate" },
                values: new object[] { new DateTime(2024, 8, 16, 14, 36, 27, 276, DateTimeKind.Utc).AddTicks(885), new DateTime(2023, 9, 10, 12, 25, 13, 887, DateTimeKind.Local).AddTicks(8598) });

            migrationBuilder.UpdateData(
                table: "Book",
                keyColumn: "BookId",
                keyValue: 1766,
                columns: new[] { "CreatedDateTime", "PublicationDate" },
                values: new object[] { new DateTime(2024, 8, 16, 14, 36, 27, 276, DateTimeKind.Utc).AddTicks(1075), new DateTime(2024, 4, 28, 0, 33, 13, 311, DateTimeKind.Local).AddTicks(20) });

            migrationBuilder.UpdateData(
                table: "Book",
                keyColumn: "BookId",
                keyValue: 1767,
                columns: new[] { "CreatedDateTime", "PublicationDate" },
                values: new object[] { new DateTime(2024, 8, 16, 14, 36, 27, 276, DateTimeKind.Utc).AddTicks(1207), new DateTime(2024, 1, 13, 21, 13, 17, 442, DateTimeKind.Local).AddTicks(8238) });

            migrationBuilder.UpdateData(
                table: "Book",
                keyColumn: "BookId",
                keyValue: 1768,
                columns: new[] { "CreatedDateTime", "PublicationDate" },
                values: new object[] { new DateTime(2024, 8, 16, 14, 36, 27, 276, DateTimeKind.Utc).AddTicks(1388), new DateTime(2023, 10, 2, 19, 46, 47, 513, DateTimeKind.Local).AddTicks(2769) });

            migrationBuilder.UpdateData(
                table: "Book",
                keyColumn: "BookId",
                keyValue: 1769,
                columns: new[] { "CreatedDateTime", "PublicationDate" },
                values: new object[] { new DateTime(2024, 8, 16, 14, 36, 27, 276, DateTimeKind.Utc).AddTicks(1550), new DateTime(2024, 7, 15, 9, 37, 44, 802, DateTimeKind.Local).AddTicks(1692) });

            migrationBuilder.UpdateData(
                table: "Book",
                keyColumn: "BookId",
                keyValue: 1770,
                columns: new[] { "CreatedDateTime", "PublicationDate" },
                values: new object[] { new DateTime(2024, 8, 16, 14, 36, 27, 276, DateTimeKind.Utc).AddTicks(1679), new DateTime(2023, 8, 28, 13, 38, 49, 609, DateTimeKind.Local).AddTicks(5936) });

            migrationBuilder.UpdateData(
                table: "Book",
                keyColumn: "BookId",
                keyValue: 1771,
                columns: new[] { "CreatedDateTime", "PublicationDate" },
                values: new object[] { new DateTime(2024, 8, 16, 14, 36, 27, 276, DateTimeKind.Utc).AddTicks(1855), new DateTime(2024, 2, 23, 15, 23, 49, 518, DateTimeKind.Local).AddTicks(9941) });

            migrationBuilder.UpdateData(
                table: "Book",
                keyColumn: "BookId",
                keyValue: 1772,
                columns: new[] { "CreatedDateTime", "PublicationDate" },
                values: new object[] { new DateTime(2024, 8, 16, 14, 36, 27, 276, DateTimeKind.Utc).AddTicks(2059), new DateTime(2024, 1, 29, 20, 37, 49, 21, DateTimeKind.Local).AddTicks(4612) });

            migrationBuilder.UpdateData(
                table: "Book",
                keyColumn: "BookId",
                keyValue: 1773,
                columns: new[] { "CreatedDateTime", "PublicationDate" },
                values: new object[] { new DateTime(2024, 8, 16, 14, 36, 27, 276, DateTimeKind.Utc).AddTicks(2198), new DateTime(2024, 1, 4, 21, 11, 16, 826, DateTimeKind.Local).AddTicks(6793) });

            migrationBuilder.UpdateData(
                table: "Book",
                keyColumn: "BookId",
                keyValue: 1774,
                columns: new[] { "CreatedDateTime", "PublicationDate" },
                values: new object[] { new DateTime(2024, 8, 16, 14, 36, 27, 276, DateTimeKind.Utc).AddTicks(2337), new DateTime(2024, 8, 8, 8, 14, 36, 718, DateTimeKind.Local).AddTicks(2626) });

            migrationBuilder.UpdateData(
                table: "Book",
                keyColumn: "BookId",
                keyValue: 1775,
                columns: new[] { "CreatedDateTime", "PublicationDate" },
                values: new object[] { new DateTime(2024, 8, 16, 14, 36, 27, 276, DateTimeKind.Utc).AddTicks(2525), new DateTime(2024, 8, 13, 4, 50, 47, 565, DateTimeKind.Local).AddTicks(896) });

            migrationBuilder.UpdateData(
                table: "Book",
                keyColumn: "BookId",
                keyValue: 1776,
                columns: new[] { "CreatedDateTime", "PublicationDate" },
                values: new object[] { new DateTime(2024, 8, 16, 14, 36, 27, 276, DateTimeKind.Utc).AddTicks(2663), new DateTime(2024, 1, 6, 6, 52, 37, 127, DateTimeKind.Local).AddTicks(3134) });

            migrationBuilder.UpdateData(
                table: "Book",
                keyColumn: "BookId",
                keyValue: 1777,
                columns: new[] { "CreatedDateTime", "PublicationDate" },
                values: new object[] { new DateTime(2024, 8, 16, 14, 36, 27, 276, DateTimeKind.Utc).AddTicks(2829), new DateTime(2024, 4, 30, 12, 20, 24, 219, DateTimeKind.Local).AddTicks(8942) });

            migrationBuilder.UpdateData(
                table: "Book",
                keyColumn: "BookId",
                keyValue: 1778,
                columns: new[] { "CreatedDateTime", "PublicationDate" },
                values: new object[] { new DateTime(2024, 8, 16, 14, 36, 27, 276, DateTimeKind.Utc).AddTicks(2973), new DateTime(2023, 11, 27, 3, 58, 40, 144, DateTimeKind.Local).AddTicks(1528) });

            migrationBuilder.UpdateData(
                table: "Book",
                keyColumn: "BookId",
                keyValue: 1779,
                columns: new[] { "CreatedDateTime", "PublicationDate" },
                values: new object[] { new DateTime(2024, 8, 16, 14, 36, 27, 276, DateTimeKind.Utc).AddTicks(3070), new DateTime(2024, 6, 4, 7, 22, 17, 952, DateTimeKind.Local).AddTicks(9340) });

            migrationBuilder.UpdateData(
                table: "Book",
                keyColumn: "BookId",
                keyValue: 1780,
                columns: new[] { "CreatedDateTime", "PublicationDate" },
                values: new object[] { new DateTime(2024, 8, 16, 14, 36, 27, 276, DateTimeKind.Utc).AddTicks(3172), new DateTime(2024, 2, 22, 21, 21, 37, 465, DateTimeKind.Local).AddTicks(9778) });

            migrationBuilder.UpdateData(
                table: "Book",
                keyColumn: "BookId",
                keyValue: 1781,
                columns: new[] { "CreatedDateTime", "PublicationDate" },
                values: new object[] { new DateTime(2024, 8, 16, 14, 36, 27, 276, DateTimeKind.Utc).AddTicks(3307), new DateTime(2024, 3, 31, 13, 13, 38, 714, DateTimeKind.Local).AddTicks(1426) });

            migrationBuilder.UpdateData(
                table: "Book",
                keyColumn: "BookId",
                keyValue: 1782,
                columns: new[] { "CreatedDateTime", "PublicationDate" },
                values: new object[] { new DateTime(2024, 8, 16, 14, 36, 27, 276, DateTimeKind.Utc).AddTicks(3413), new DateTime(2024, 4, 21, 6, 39, 52, 164, DateTimeKind.Local).AddTicks(3242) });

            migrationBuilder.UpdateData(
                table: "Book",
                keyColumn: "BookId",
                keyValue: 1783,
                columns: new[] { "CreatedDateTime", "PublicationDate" },
                values: new object[] { new DateTime(2024, 8, 16, 14, 36, 27, 276, DateTimeKind.Utc).AddTicks(3544), new DateTime(2024, 5, 26, 5, 29, 48, 804, DateTimeKind.Local).AddTicks(1901) });

            migrationBuilder.UpdateData(
                table: "Book",
                keyColumn: "BookId",
                keyValue: 1784,
                columns: new[] { "CreatedDateTime", "PublicationDate" },
                values: new object[] { new DateTime(2024, 8, 16, 14, 36, 27, 276, DateTimeKind.Utc).AddTicks(3642), new DateTime(2023, 12, 15, 22, 32, 15, 833, DateTimeKind.Local).AddTicks(9837) });

            migrationBuilder.UpdateData(
                table: "Book",
                keyColumn: "BookId",
                keyValue: 1785,
                columns: new[] { "CreatedDateTime", "PublicationDate" },
                values: new object[] { new DateTime(2024, 8, 16, 14, 36, 27, 276, DateTimeKind.Utc).AddTicks(3762), new DateTime(2023, 12, 17, 3, 15, 44, 578, DateTimeKind.Local).AddTicks(8806) });

            migrationBuilder.UpdateData(
                table: "Book",
                keyColumn: "BookId",
                keyValue: 1786,
                columns: new[] { "CreatedDateTime", "PublicationDate" },
                values: new object[] { new DateTime(2024, 8, 16, 14, 36, 27, 276, DateTimeKind.Utc).AddTicks(3863), new DateTime(2023, 9, 14, 0, 32, 21, 278, DateTimeKind.Local).AddTicks(9342) });

            migrationBuilder.UpdateData(
                table: "Book",
                keyColumn: "BookId",
                keyValue: 1787,
                columns: new[] { "CreatedDateTime", "PublicationDate" },
                values: new object[] { new DateTime(2024, 8, 16, 14, 36, 27, 276, DateTimeKind.Utc).AddTicks(3990), new DateTime(2023, 9, 20, 2, 58, 51, 92, DateTimeKind.Local).AddTicks(7087) });

            migrationBuilder.UpdateData(
                table: "Book",
                keyColumn: "BookId",
                keyValue: 1788,
                columns: new[] { "CreatedDateTime", "PublicationDate" },
                values: new object[] { new DateTime(2024, 8, 16, 14, 36, 27, 276, DateTimeKind.Utc).AddTicks(4092), new DateTime(2024, 5, 19, 1, 11, 1, 132, DateTimeKind.Local).AddTicks(768) });

            migrationBuilder.UpdateData(
                table: "Book",
                keyColumn: "BookId",
                keyValue: 1789,
                columns: new[] { "CreatedDateTime", "PublicationDate" },
                values: new object[] { new DateTime(2024, 8, 16, 14, 36, 27, 276, DateTimeKind.Utc).AddTicks(4223), new DateTime(2023, 9, 27, 0, 23, 10, 926, DateTimeKind.Local).AddTicks(3295) });

            migrationBuilder.UpdateData(
                table: "Book",
                keyColumn: "BookId",
                keyValue: 1790,
                columns: new[] { "CreatedDateTime", "PublicationDate" },
                values: new object[] { new DateTime(2024, 8, 16, 14, 36, 27, 276, DateTimeKind.Utc).AddTicks(4316), new DateTime(2024, 5, 30, 17, 14, 26, 49, DateTimeKind.Local).AddTicks(5325) });

            migrationBuilder.UpdateData(
                table: "Book",
                keyColumn: "BookId",
                keyValue: 1791,
                columns: new[] { "CreatedDateTime", "PublicationDate" },
                values: new object[] { new DateTime(2024, 8, 16, 14, 36, 27, 276, DateTimeKind.Utc).AddTicks(4485), new DateTime(2024, 5, 19, 22, 55, 23, 906, DateTimeKind.Local).AddTicks(4416) });

            migrationBuilder.UpdateData(
                table: "Book",
                keyColumn: "BookId",
                keyValue: 1792,
                columns: new[] { "CreatedDateTime", "PublicationDate" },
                values: new object[] { new DateTime(2024, 8, 16, 14, 36, 27, 276, DateTimeKind.Utc).AddTicks(4602), new DateTime(2024, 1, 18, 19, 1, 23, 591, DateTimeKind.Local).AddTicks(3728) });

            migrationBuilder.UpdateData(
                table: "Book",
                keyColumn: "BookId",
                keyValue: 1793,
                columns: new[] { "CreatedDateTime", "PublicationDate" },
                values: new object[] { new DateTime(2024, 8, 16, 14, 36, 27, 276, DateTimeKind.Utc).AddTicks(4705), new DateTime(2024, 2, 25, 5, 27, 3, 202, DateTimeKind.Local).AddTicks(1105) });

            migrationBuilder.UpdateData(
                table: "Book",
                keyColumn: "BookId",
                keyValue: 1794,
                columns: new[] { "CreatedDateTime", "PublicationDate" },
                values: new object[] { new DateTime(2024, 8, 16, 14, 36, 27, 276, DateTimeKind.Utc).AddTicks(4844), new DateTime(2023, 10, 6, 2, 14, 53, 292, DateTimeKind.Local).AddTicks(8168) });

            migrationBuilder.UpdateData(
                table: "Book",
                keyColumn: "BookId",
                keyValue: 1795,
                columns: new[] { "CreatedDateTime", "PublicationDate" },
                values: new object[] { new DateTime(2024, 8, 16, 14, 36, 27, 276, DateTimeKind.Utc).AddTicks(4937), new DateTime(2024, 3, 6, 22, 22, 13, 391, DateTimeKind.Local).AddTicks(5965) });

            migrationBuilder.UpdateData(
                table: "Book",
                keyColumn: "BookId",
                keyValue: 1796,
                columns: new[] { "CreatedDateTime", "PublicationDate" },
                values: new object[] { new DateTime(2024, 8, 16, 14, 36, 27, 276, DateTimeKind.Utc).AddTicks(5071), new DateTime(2024, 6, 22, 17, 54, 54, 209, DateTimeKind.Local).AddTicks(7965) });

            migrationBuilder.UpdateData(
                table: "Book",
                keyColumn: "BookId",
                keyValue: 1797,
                columns: new[] { "CreatedDateTime", "PublicationDate" },
                values: new object[] { new DateTime(2024, 8, 16, 14, 36, 27, 276, DateTimeKind.Utc).AddTicks(5163), new DateTime(2024, 3, 25, 10, 1, 18, 165, DateTimeKind.Local).AddTicks(2158) });

            migrationBuilder.UpdateData(
                table: "Book",
                keyColumn: "BookId",
                keyValue: 1798,
                columns: new[] { "CreatedDateTime", "PublicationDate" },
                values: new object[] { new DateTime(2024, 8, 16, 14, 36, 27, 276, DateTimeKind.Utc).AddTicks(5318), new DateTime(2024, 4, 11, 14, 5, 10, 337, DateTimeKind.Local).AddTicks(4500) });

            migrationBuilder.UpdateData(
                table: "Book",
                keyColumn: "BookId",
                keyValue: 1799,
                columns: new[] { "CreatedDateTime", "PublicationDate" },
                values: new object[] { new DateTime(2024, 8, 16, 14, 36, 27, 276, DateTimeKind.Utc).AddTicks(5462), new DateTime(2024, 4, 29, 5, 54, 24, 43, DateTimeKind.Local).AddTicks(3395) });

            migrationBuilder.UpdateData(
                table: "Book",
                keyColumn: "BookId",
                keyValue: 1800,
                columns: new[] { "CreatedDateTime", "PublicationDate" },
                values: new object[] { new DateTime(2024, 8, 16, 14, 36, 27, 276, DateTimeKind.Utc).AddTicks(5631), new DateTime(2023, 11, 26, 4, 17, 6, 202, DateTimeKind.Local).AddTicks(9182) });

            migrationBuilder.UpdateData(
                table: "Book",
                keyColumn: "BookId",
                keyValue: 1801,
                columns: new[] { "CreatedDateTime", "PublicationDate" },
                values: new object[] { new DateTime(2024, 8, 16, 14, 36, 27, 276, DateTimeKind.Utc).AddTicks(5787), new DateTime(2024, 7, 10, 20, 27, 3, 296, DateTimeKind.Local).AddTicks(6328) });

            migrationBuilder.UpdateData(
                table: "Book",
                keyColumn: "BookId",
                keyValue: 1802,
                columns: new[] { "CreatedDateTime", "PublicationDate" },
                values: new object[] { new DateTime(2024, 8, 16, 14, 36, 27, 276, DateTimeKind.Utc).AddTicks(5951), new DateTime(2023, 12, 20, 4, 52, 29, 126, DateTimeKind.Local).AddTicks(8581) });

            migrationBuilder.UpdateData(
                table: "Book",
                keyColumn: "BookId",
                keyValue: 1803,
                columns: new[] { "CreatedDateTime", "PublicationDate" },
                values: new object[] { new DateTime(2024, 8, 16, 14, 36, 27, 276, DateTimeKind.Utc).AddTicks(6055), new DateTime(2024, 6, 7, 4, 19, 27, 746, DateTimeKind.Local).AddTicks(5896) });

            migrationBuilder.UpdateData(
                table: "Book",
                keyColumn: "BookId",
                keyValue: 1804,
                columns: new[] { "CreatedDateTime", "PublicationDate" },
                values: new object[] { new DateTime(2024, 8, 16, 14, 36, 27, 276, DateTimeKind.Utc).AddTicks(6187), new DateTime(2023, 8, 24, 12, 28, 21, 94, DateTimeKind.Local).AddTicks(3269) });

            migrationBuilder.UpdateData(
                table: "Book",
                keyColumn: "BookId",
                keyValue: 1805,
                columns: new[] { "CreatedDateTime", "PublicationDate" },
                values: new object[] { new DateTime(2024, 8, 16, 14, 36, 27, 276, DateTimeKind.Utc).AddTicks(6284), new DateTime(2024, 6, 28, 20, 44, 45, 285, DateTimeKind.Local).AddTicks(8516) });

            migrationBuilder.UpdateData(
                table: "Book",
                keyColumn: "BookId",
                keyValue: 1806,
                columns: new[] { "CreatedDateTime", "PublicationDate" },
                values: new object[] { new DateTime(2024, 8, 16, 14, 36, 27, 276, DateTimeKind.Utc).AddTicks(6425), new DateTime(2024, 4, 18, 4, 14, 51, 763, DateTimeKind.Local).AddTicks(4093) });

            migrationBuilder.UpdateData(
                table: "Book",
                keyColumn: "BookId",
                keyValue: 1807,
                columns: new[] { "CreatedDateTime", "PublicationDate" },
                values: new object[] { new DateTime(2024, 8, 16, 14, 36, 27, 276, DateTimeKind.Utc).AddTicks(6528), new DateTime(2024, 5, 14, 19, 58, 0, 562, DateTimeKind.Local).AddTicks(390) });

            migrationBuilder.UpdateData(
                table: "Book",
                keyColumn: "BookId",
                keyValue: 1808,
                columns: new[] { "CreatedDateTime", "PublicationDate" },
                values: new object[] { new DateTime(2024, 8, 16, 14, 36, 27, 276, DateTimeKind.Utc).AddTicks(6649), new DateTime(2023, 10, 2, 1, 34, 55, 341, DateTimeKind.Local).AddTicks(6496) });

            migrationBuilder.UpdateData(
                table: "Book",
                keyColumn: "BookId",
                keyValue: 1809,
                columns: new[] { "CreatedDateTime", "PublicationDate" },
                values: new object[] { new DateTime(2024, 8, 16, 14, 36, 27, 276, DateTimeKind.Utc).AddTicks(6743), new DateTime(2024, 2, 27, 2, 44, 2, 797, DateTimeKind.Local).AddTicks(1011) });

            migrationBuilder.UpdateData(
                table: "Book",
                keyColumn: "BookId",
                keyValue: 1810,
                columns: new[] { "CreatedDateTime", "PublicationDate" },
                values: new object[] { new DateTime(2024, 8, 16, 14, 36, 27, 276, DateTimeKind.Utc).AddTicks(6879), new DateTime(2024, 4, 4, 8, 38, 46, 794, DateTimeKind.Local).AddTicks(8519) });

            migrationBuilder.UpdateData(
                table: "Book",
                keyColumn: "BookId",
                keyValue: 1811,
                columns: new[] { "CreatedDateTime", "PublicationDate" },
                values: new object[] { new DateTime(2024, 8, 16, 14, 36, 27, 276, DateTimeKind.Utc).AddTicks(6980), new DateTime(2023, 11, 26, 19, 29, 21, 953, DateTimeKind.Local).AddTicks(5036) });

            migrationBuilder.UpdateData(
                table: "Book",
                keyColumn: "BookId",
                keyValue: 1812,
                columns: new[] { "CreatedDateTime", "PublicationDate" },
                values: new object[] { new DateTime(2024, 8, 16, 14, 36, 27, 276, DateTimeKind.Utc).AddTicks(7122), new DateTime(2024, 3, 20, 12, 7, 11, 452, DateTimeKind.Local).AddTicks(8253) });

            migrationBuilder.UpdateData(
                table: "Book",
                keyColumn: "BookId",
                keyValue: 1813,
                columns: new[] { "CreatedDateTime", "PublicationDate" },
                values: new object[] { new DateTime(2024, 8, 16, 14, 36, 27, 276, DateTimeKind.Utc).AddTicks(7245), new DateTime(2023, 12, 29, 15, 7, 35, 393, DateTimeKind.Local).AddTicks(882) });

            migrationBuilder.UpdateData(
                table: "Book",
                keyColumn: "BookId",
                keyValue: 1814,
                columns: new[] { "CreatedDateTime", "PublicationDate" },
                values: new object[] { new DateTime(2024, 8, 16, 14, 36, 27, 276, DateTimeKind.Utc).AddTicks(7356), new DateTime(2024, 2, 14, 18, 45, 23, 282, DateTimeKind.Local).AddTicks(6775) });

            migrationBuilder.UpdateData(
                table: "Book",
                keyColumn: "BookId",
                keyValue: 1815,
                columns: new[] { "CreatedDateTime", "PublicationDate" },
                values: new object[] { new DateTime(2024, 8, 16, 14, 36, 27, 276, DateTimeKind.Utc).AddTicks(7490), new DateTime(2023, 8, 23, 6, 27, 45, 990, DateTimeKind.Local).AddTicks(3544) });

            migrationBuilder.UpdateData(
                table: "Book",
                keyColumn: "BookId",
                keyValue: 1816,
                columns: new[] { "CreatedDateTime", "PublicationDate" },
                values: new object[] { new DateTime(2024, 8, 16, 14, 36, 27, 276, DateTimeKind.Utc).AddTicks(7604), new DateTime(2023, 8, 16, 17, 19, 50, 428, DateTimeKind.Local).AddTicks(7857) });

            migrationBuilder.UpdateData(
                table: "Book",
                keyColumn: "BookId",
                keyValue: 1817,
                columns: new[] { "CreatedDateTime", "PublicationDate" },
                values: new object[] { new DateTime(2024, 8, 16, 14, 36, 27, 276, DateTimeKind.Utc).AddTicks(7728), new DateTime(2024, 7, 12, 8, 27, 11, 977, DateTimeKind.Local).AddTicks(5833) });

            migrationBuilder.UpdateData(
                table: "Book",
                keyColumn: "BookId",
                keyValue: 1818,
                columns: new[] { "CreatedDateTime", "PublicationDate" },
                values: new object[] { new DateTime(2024, 8, 16, 14, 36, 27, 276, DateTimeKind.Utc).AddTicks(7835), new DateTime(2024, 6, 12, 20, 14, 43, 974, DateTimeKind.Local).AddTicks(280) });

            migrationBuilder.UpdateData(
                table: "Book",
                keyColumn: "BookId",
                keyValue: 1819,
                columns: new[] { "CreatedDateTime", "PublicationDate" },
                values: new object[] { new DateTime(2024, 8, 16, 14, 36, 27, 276, DateTimeKind.Utc).AddTicks(7953), new DateTime(2024, 4, 24, 13, 55, 56, 495, DateTimeKind.Local).AddTicks(1696) });

            migrationBuilder.UpdateData(
                table: "Book",
                keyColumn: "BookId",
                keyValue: 1820,
                columns: new[] { "CreatedDateTime", "PublicationDate" },
                values: new object[] { new DateTime(2024, 8, 16, 14, 36, 27, 276, DateTimeKind.Utc).AddTicks(8050), new DateTime(2023, 9, 22, 2, 46, 10, 112, DateTimeKind.Local).AddTicks(9757) });

            migrationBuilder.UpdateData(
                table: "Book",
                keyColumn: "BookId",
                keyValue: 1821,
                columns: new[] { "CreatedDateTime", "PublicationDate" },
                values: new object[] { new DateTime(2024, 8, 16, 14, 36, 27, 276, DateTimeKind.Utc).AddTicks(8178), new DateTime(2023, 9, 12, 19, 24, 42, 413, DateTimeKind.Local).AddTicks(6745) });

            migrationBuilder.UpdateData(
                table: "Book",
                keyColumn: "BookId",
                keyValue: 1822,
                columns: new[] { "CreatedDateTime", "PublicationDate" },
                values: new object[] { new DateTime(2024, 8, 16, 14, 36, 27, 276, DateTimeKind.Utc).AddTicks(8276), new DateTime(2024, 5, 3, 14, 57, 25, 809, DateTimeKind.Local).AddTicks(2921) });

            migrationBuilder.UpdateData(
                table: "Book",
                keyColumn: "BookId",
                keyValue: 1823,
                columns: new[] { "CreatedDateTime", "PublicationDate" },
                values: new object[] { new DateTime(2024, 8, 16, 14, 36, 27, 276, DateTimeKind.Utc).AddTicks(8390), new DateTime(2024, 5, 28, 18, 36, 14, 816, DateTimeKind.Local).AddTicks(1491) });

            migrationBuilder.UpdateData(
                table: "Book",
                keyColumn: "BookId",
                keyValue: 1824,
                columns: new[] { "CreatedDateTime", "PublicationDate" },
                values: new object[] { new DateTime(2024, 8, 16, 14, 36, 27, 276, DateTimeKind.Utc).AddTicks(8496), new DateTime(2024, 4, 13, 12, 3, 31, 32, DateTimeKind.Local).AddTicks(4346) });

            migrationBuilder.UpdateData(
                table: "Book",
                keyColumn: "BookId",
                keyValue: 1825,
                columns: new[] { "CreatedDateTime", "PublicationDate" },
                values: new object[] { new DateTime(2024, 8, 16, 14, 36, 27, 276, DateTimeKind.Utc).AddTicks(8617), new DateTime(2023, 11, 17, 17, 12, 11, 201, DateTimeKind.Local).AddTicks(3207) });

            migrationBuilder.UpdateData(
                table: "Book",
                keyColumn: "BookId",
                keyValue: 1826,
                columns: new[] { "CreatedDateTime", "PublicationDate" },
                values: new object[] { new DateTime(2024, 8, 16, 14, 36, 27, 276, DateTimeKind.Utc).AddTicks(8716), new DateTime(2023, 9, 28, 7, 31, 16, 850, DateTimeKind.Local).AddTicks(6798) });

            migrationBuilder.UpdateData(
                table: "Book",
                keyColumn: "BookId",
                keyValue: 1827,
                columns: new[] { "CreatedDateTime", "PublicationDate" },
                values: new object[] { new DateTime(2024, 8, 16, 14, 36, 27, 276, DateTimeKind.Utc).AddTicks(8854), new DateTime(2024, 3, 3, 19, 9, 35, 25, DateTimeKind.Local).AddTicks(5835) });

            migrationBuilder.UpdateData(
                table: "Book",
                keyColumn: "BookId",
                keyValue: 1828,
                columns: new[] { "CreatedDateTime", "PublicationDate" },
                values: new object[] { new DateTime(2024, 8, 16, 14, 36, 27, 276, DateTimeKind.Utc).AddTicks(8949), new DateTime(2024, 7, 2, 15, 1, 34, 203, DateTimeKind.Local).AddTicks(4267) });

            migrationBuilder.UpdateData(
                table: "Book",
                keyColumn: "BookId",
                keyValue: 1829,
                columns: new[] { "CreatedDateTime", "PublicationDate" },
                values: new object[] { new DateTime(2024, 8, 16, 14, 36, 27, 276, DateTimeKind.Utc).AddTicks(9075), new DateTime(2023, 10, 13, 13, 18, 7, 848, DateTimeKind.Local).AddTicks(6444) });

            migrationBuilder.UpdateData(
                table: "Book",
                keyColumn: "BookId",
                keyValue: 1830,
                columns: new[] { "CreatedDateTime", "PublicationDate" },
                values: new object[] { new DateTime(2024, 8, 16, 14, 36, 27, 276, DateTimeKind.Utc).AddTicks(9176), new DateTime(2024, 3, 19, 10, 19, 42, 137, DateTimeKind.Local).AddTicks(4188) });

            migrationBuilder.UpdateData(
                table: "Book",
                keyColumn: "BookId",
                keyValue: 1831,
                columns: new[] { "CreatedDateTime", "PublicationDate" },
                values: new object[] { new DateTime(2024, 8, 16, 14, 36, 27, 276, DateTimeKind.Utc).AddTicks(9306), new DateTime(2024, 8, 13, 0, 49, 9, 612, DateTimeKind.Local).AddTicks(519) });

            migrationBuilder.UpdateData(
                table: "Book",
                keyColumn: "BookId",
                keyValue: 1832,
                columns: new[] { "CreatedDateTime", "PublicationDate" },
                values: new object[] { new DateTime(2024, 8, 16, 14, 36, 27, 276, DateTimeKind.Utc).AddTicks(9447), new DateTime(2024, 5, 10, 23, 21, 16, 500, DateTimeKind.Local).AddTicks(2076) });

            migrationBuilder.UpdateData(
                table: "Book",
                keyColumn: "BookId",
                keyValue: 1833,
                columns: new[] { "CreatedDateTime", "PublicationDate" },
                values: new object[] { new DateTime(2024, 8, 16, 14, 36, 27, 276, DateTimeKind.Utc).AddTicks(9560), new DateTime(2023, 10, 22, 3, 30, 37, 536, DateTimeKind.Local).AddTicks(1970) });

            migrationBuilder.UpdateData(
                table: "Book",
                keyColumn: "BookId",
                keyValue: 1834,
                columns: new[] { "CreatedDateTime", "PublicationDate" },
                values: new object[] { new DateTime(2024, 8, 16, 14, 36, 27, 276, DateTimeKind.Utc).AddTicks(9683), new DateTime(2023, 12, 16, 21, 25, 55, 333, DateTimeKind.Local).AddTicks(2618) });

            migrationBuilder.UpdateData(
                table: "Book",
                keyColumn: "BookId",
                keyValue: 1835,
                columns: new[] { "CreatedDateTime", "PublicationDate" },
                values: new object[] { new DateTime(2024, 8, 16, 14, 36, 27, 276, DateTimeKind.Utc).AddTicks(9786), new DateTime(2024, 1, 7, 13, 4, 21, 660, DateTimeKind.Local).AddTicks(2393) });

            migrationBuilder.UpdateData(
                table: "Book",
                keyColumn: "BookId",
                keyValue: 1836,
                columns: new[] { "CreatedDateTime", "PublicationDate" },
                values: new object[] { new DateTime(2024, 8, 16, 14, 36, 27, 276, DateTimeKind.Utc).AddTicks(9907), new DateTime(2024, 4, 6, 20, 45, 24, 126, DateTimeKind.Local).AddTicks(5144) });

            migrationBuilder.UpdateData(
                table: "Book",
                keyColumn: "BookId",
                keyValue: 1837,
                columns: new[] { "CreatedDateTime", "PublicationDate" },
                values: new object[] { new DateTime(2024, 8, 16, 14, 36, 27, 277, DateTimeKind.Utc).AddTicks(10), new DateTime(2024, 7, 18, 6, 44, 37, 41, DateTimeKind.Local).AddTicks(9740) });

            migrationBuilder.UpdateData(
                table: "Book",
                keyColumn: "BookId",
                keyValue: 1838,
                columns: new[] { "CreatedDateTime", "PublicationDate" },
                values: new object[] { new DateTime(2024, 8, 16, 14, 36, 27, 277, DateTimeKind.Utc).AddTicks(139), new DateTime(2023, 12, 1, 16, 53, 8, 306, DateTimeKind.Local).AddTicks(6855) });

            migrationBuilder.UpdateData(
                table: "Book",
                keyColumn: "BookId",
                keyValue: 1839,
                columns: new[] { "CreatedDateTime", "PublicationDate" },
                values: new object[] { new DateTime(2024, 8, 16, 14, 36, 27, 277, DateTimeKind.Utc).AddTicks(236), new DateTime(2024, 4, 29, 12, 5, 46, 586, DateTimeKind.Local).AddTicks(890) });

            migrationBuilder.UpdateData(
                table: "Book",
                keyColumn: "BookId",
                keyValue: 1840,
                columns: new[] { "CreatedDateTime", "PublicationDate" },
                values: new object[] { new DateTime(2024, 8, 16, 14, 36, 27, 277, DateTimeKind.Utc).AddTicks(369), new DateTime(2024, 1, 9, 14, 59, 41, 42, DateTimeKind.Local).AddTicks(8434) });

            migrationBuilder.UpdateData(
                table: "Book",
                keyColumn: "BookId",
                keyValue: 1841,
                columns: new[] { "CreatedDateTime", "PublicationDate" },
                values: new object[] { new DateTime(2024, 8, 16, 14, 36, 27, 277, DateTimeKind.Utc).AddTicks(462), new DateTime(2024, 8, 10, 3, 33, 56, 64, DateTimeKind.Local).AddTicks(1605) });

            migrationBuilder.UpdateData(
                table: "Book",
                keyColumn: "BookId",
                keyValue: 1842,
                columns: new[] { "CreatedDateTime", "PublicationDate" },
                values: new object[] { new DateTime(2024, 8, 16, 14, 36, 27, 277, DateTimeKind.Utc).AddTicks(607), new DateTime(2024, 1, 27, 12, 16, 8, 160, DateTimeKind.Local).AddTicks(4223) });

            migrationBuilder.UpdateData(
                table: "Book",
                keyColumn: "BookId",
                keyValue: 1843,
                columns: new[] { "CreatedDateTime", "PublicationDate" },
                values: new object[] { new DateTime(2024, 8, 16, 14, 36, 27, 277, DateTimeKind.Utc).AddTicks(708), new DateTime(2023, 10, 7, 1, 9, 11, 298, DateTimeKind.Local).AddTicks(8140) });

            migrationBuilder.UpdateData(
                table: "Book",
                keyColumn: "BookId",
                keyValue: 1844,
                columns: new[] { "CreatedDateTime", "PublicationDate" },
                values: new object[] { new DateTime(2024, 8, 16, 14, 36, 27, 277, DateTimeKind.Utc).AddTicks(839), new DateTime(2024, 1, 17, 11, 8, 4, 776, DateTimeKind.Local).AddTicks(8376) });

            migrationBuilder.UpdateData(
                table: "Book",
                keyColumn: "BookId",
                keyValue: 1845,
                columns: new[] { "CreatedDateTime", "PublicationDate" },
                values: new object[] { new DateTime(2024, 8, 16, 14, 36, 27, 277, DateTimeKind.Utc).AddTicks(957), new DateTime(2023, 12, 4, 22, 37, 23, 951, DateTimeKind.Local).AddTicks(467) });

            migrationBuilder.UpdateData(
                table: "Book",
                keyColumn: "BookId",
                keyValue: 1846,
                columns: new[] { "CreatedDateTime", "PublicationDate" },
                values: new object[] { new DateTime(2024, 8, 16, 14, 36, 27, 277, DateTimeKind.Utc).AddTicks(1058), new DateTime(2024, 7, 12, 9, 36, 59, 816, DateTimeKind.Local).AddTicks(8801) });

            migrationBuilder.UpdateData(
                table: "Book",
                keyColumn: "BookId",
                keyValue: 1847,
                columns: new[] { "CreatedDateTime", "PublicationDate" },
                values: new object[] { new DateTime(2024, 8, 16, 14, 36, 27, 277, DateTimeKind.Utc).AddTicks(1183), new DateTime(2024, 5, 30, 13, 54, 44, 7, DateTimeKind.Local).AddTicks(512) });

            migrationBuilder.UpdateData(
                table: "Book",
                keyColumn: "BookId",
                keyValue: 1848,
                columns: new[] { "CreatedDateTime", "PublicationDate" },
                values: new object[] { new DateTime(2024, 8, 16, 14, 36, 27, 277, DateTimeKind.Utc).AddTicks(1287), new DateTime(2024, 2, 12, 7, 39, 0, 430, DateTimeKind.Local).AddTicks(5976) });

            migrationBuilder.UpdateData(
                table: "Book",
                keyColumn: "BookId",
                keyValue: 1849,
                columns: new[] { "CreatedDateTime", "PublicationDate" },
                values: new object[] { new DateTime(2024, 8, 16, 14, 36, 27, 277, DateTimeKind.Utc).AddTicks(1408), new DateTime(2023, 10, 16, 23, 38, 21, 166, DateTimeKind.Local).AddTicks(7819) });

            migrationBuilder.UpdateData(
                table: "Book",
                keyColumn: "BookId",
                keyValue: 1850,
                columns: new[] { "CreatedDateTime", "PublicationDate" },
                values: new object[] { new DateTime(2024, 8, 16, 14, 36, 27, 277, DateTimeKind.Utc).AddTicks(1501), new DateTime(2023, 12, 12, 0, 23, 47, 445, DateTimeKind.Local).AddTicks(2271) });

            migrationBuilder.UpdateData(
                table: "Book",
                keyColumn: "BookId",
                keyValue: 1851,
                columns: new[] { "CreatedDateTime", "PublicationDate" },
                values: new object[] { new DateTime(2024, 8, 16, 14, 36, 27, 277, DateTimeKind.Utc).AddTicks(1649), new DateTime(2023, 11, 28, 16, 15, 16, 114, DateTimeKind.Local).AddTicks(8144) });

            migrationBuilder.UpdateData(
                table: "Book",
                keyColumn: "BookId",
                keyValue: 1852,
                columns: new[] { "CreatedDateTime", "PublicationDate" },
                values: new object[] { new DateTime(2024, 8, 16, 14, 36, 27, 277, DateTimeKind.Utc).AddTicks(1743), new DateTime(2024, 5, 22, 21, 28, 28, 844, DateTimeKind.Local).AddTicks(4431) });

            migrationBuilder.UpdateData(
                table: "Book",
                keyColumn: "BookId",
                keyValue: 1853,
                columns: new[] { "CreatedDateTime", "PublicationDate" },
                values: new object[] { new DateTime(2024, 8, 16, 14, 36, 27, 277, DateTimeKind.Utc).AddTicks(1865), new DateTime(2023, 10, 1, 0, 41, 15, 69, DateTimeKind.Local).AddTicks(9963) });

            migrationBuilder.UpdateData(
                table: "Book",
                keyColumn: "BookId",
                keyValue: 1854,
                columns: new[] { "CreatedDateTime", "PublicationDate" },
                values: new object[] { new DateTime(2024, 8, 16, 14, 36, 27, 277, DateTimeKind.Utc).AddTicks(1957), new DateTime(2023, 10, 27, 8, 47, 36, 338, DateTimeKind.Local).AddTicks(931) });

            migrationBuilder.UpdateData(
                table: "Book",
                keyColumn: "BookId",
                keyValue: 1855,
                columns: new[] { "CreatedDateTime", "PublicationDate" },
                values: new object[] { new DateTime(2024, 8, 16, 14, 36, 27, 277, DateTimeKind.Utc).AddTicks(2084), new DateTime(2024, 7, 1, 1, 23, 22, 636, DateTimeKind.Local).AddTicks(8382) });

            migrationBuilder.UpdateData(
                table: "Book",
                keyColumn: "BookId",
                keyValue: 1856,
                columns: new[] { "CreatedDateTime", "PublicationDate" },
                values: new object[] { new DateTime(2024, 8, 16, 14, 36, 27, 277, DateTimeKind.Utc).AddTicks(2188), new DateTime(2023, 10, 30, 4, 10, 22, 387, DateTimeKind.Local).AddTicks(6588) });

            migrationBuilder.UpdateData(
                table: "Book",
                keyColumn: "BookId",
                keyValue: 1857,
                columns: new[] { "CreatedDateTime", "PublicationDate" },
                values: new object[] { new DateTime(2024, 8, 16, 14, 36, 27, 277, DateTimeKind.Utc).AddTicks(2325), new DateTime(2024, 5, 21, 23, 45, 4, 220, DateTimeKind.Local).AddTicks(4918) });

            migrationBuilder.UpdateData(
                table: "Book",
                keyColumn: "BookId",
                keyValue: 1858,
                columns: new[] { "CreatedDateTime", "PublicationDate" },
                values: new object[] { new DateTime(2024, 8, 16, 14, 36, 27, 277, DateTimeKind.Utc).AddTicks(2423), new DateTime(2023, 11, 18, 0, 57, 28, 670, DateTimeKind.Local).AddTicks(3288) });

            migrationBuilder.UpdateData(
                table: "Book",
                keyColumn: "BookId",
                keyValue: 1859,
                columns: new[] { "CreatedDateTime", "PublicationDate" },
                values: new object[] { new DateTime(2024, 8, 16, 14, 36, 27, 277, DateTimeKind.Utc).AddTicks(2564), new DateTime(2024, 5, 12, 3, 11, 1, 517, DateTimeKind.Local).AddTicks(8090) });

            migrationBuilder.UpdateData(
                table: "Book",
                keyColumn: "BookId",
                keyValue: 1860,
                columns: new[] { "CreatedDateTime", "PublicationDate" },
                values: new object[] { new DateTime(2024, 8, 16, 14, 36, 27, 277, DateTimeKind.Utc).AddTicks(2675), new DateTime(2024, 3, 5, 2, 15, 38, 332, DateTimeKind.Local).AddTicks(644) });

            migrationBuilder.UpdateData(
                table: "Book",
                keyColumn: "BookId",
                keyValue: 1861,
                columns: new[] { "CreatedDateTime", "PublicationDate" },
                values: new object[] { new DateTime(2024, 8, 16, 14, 36, 27, 277, DateTimeKind.Utc).AddTicks(2813), new DateTime(2023, 10, 10, 2, 33, 15, 33, DateTimeKind.Local).AddTicks(2852) });

            migrationBuilder.UpdateData(
                table: "Book",
                keyColumn: "BookId",
                keyValue: 1862,
                columns: new[] { "CreatedDateTime", "PublicationDate" },
                values: new object[] { new DateTime(2024, 8, 16, 14, 36, 27, 277, DateTimeKind.Utc).AddTicks(2927), new DateTime(2023, 9, 25, 15, 33, 17, 791, DateTimeKind.Local).AddTicks(5292) });

            migrationBuilder.UpdateData(
                table: "Book",
                keyColumn: "BookId",
                keyValue: 1863,
                columns: new[] { "CreatedDateTime", "PublicationDate" },
                values: new object[] { new DateTime(2024, 8, 16, 14, 36, 27, 277, DateTimeKind.Utc).AddTicks(3058), new DateTime(2024, 7, 29, 12, 32, 57, 358, DateTimeKind.Local).AddTicks(6533) });

            migrationBuilder.UpdateData(
                table: "Book",
                keyColumn: "BookId",
                keyValue: 1864,
                columns: new[] { "CreatedDateTime", "PublicationDate" },
                values: new object[] { new DateTime(2024, 8, 16, 14, 36, 27, 277, DateTimeKind.Utc).AddTicks(3153), new DateTime(2024, 7, 1, 7, 24, 53, 117, DateTimeKind.Local).AddTicks(9785) });

            migrationBuilder.UpdateData(
                table: "Book",
                keyColumn: "BookId",
                keyValue: 1865,
                columns: new[] { "CreatedDateTime", "PublicationDate" },
                values: new object[] { new DateTime(2024, 8, 16, 14, 36, 27, 277, DateTimeKind.Utc).AddTicks(3271), new DateTime(2024, 6, 19, 13, 35, 36, 504, DateTimeKind.Local).AddTicks(1679) });

            migrationBuilder.UpdateData(
                table: "Book",
                keyColumn: "BookId",
                keyValue: 1866,
                columns: new[] { "CreatedDateTime", "PublicationDate" },
                values: new object[] { new DateTime(2024, 8, 16, 14, 36, 27, 277, DateTimeKind.Utc).AddTicks(3360), new DateTime(2024, 6, 25, 5, 36, 48, 775, DateTimeKind.Local).AddTicks(1362) });

            migrationBuilder.UpdateData(
                table: "Book",
                keyColumn: "BookId",
                keyValue: 1867,
                columns: new[] { "CreatedDateTime", "PublicationDate" },
                values: new object[] { new DateTime(2024, 8, 16, 14, 36, 27, 277, DateTimeKind.Utc).AddTicks(3491), new DateTime(2024, 3, 27, 5, 59, 40, 266, DateTimeKind.Local).AddTicks(5605) });

            migrationBuilder.UpdateData(
                table: "Book",
                keyColumn: "BookId",
                keyValue: 1868,
                columns: new[] { "CreatedDateTime", "PublicationDate" },
                values: new object[] { new DateTime(2024, 8, 16, 14, 36, 27, 277, DateTimeKind.Utc).AddTicks(3583), new DateTime(2023, 8, 19, 23, 26, 2, 989, DateTimeKind.Local).AddTicks(1511) });

            migrationBuilder.UpdateData(
                table: "Book",
                keyColumn: "BookId",
                keyValue: 1869,
                columns: new[] { "CreatedDateTime", "PublicationDate" },
                values: new object[] { new DateTime(2024, 8, 16, 14, 36, 27, 277, DateTimeKind.Utc).AddTicks(3706), new DateTime(2023, 11, 5, 9, 14, 16, 923, DateTimeKind.Local).AddTicks(5524) });

            migrationBuilder.UpdateData(
                table: "Book",
                keyColumn: "BookId",
                keyValue: 1870,
                columns: new[] { "CreatedDateTime", "PublicationDate" },
                values: new object[] { new DateTime(2024, 8, 16, 14, 36, 27, 277, DateTimeKind.Utc).AddTicks(3818), new DateTime(2024, 3, 9, 10, 44, 46, 412, DateTimeKind.Local).AddTicks(3237) });

            migrationBuilder.UpdateData(
                table: "Book",
                keyColumn: "BookId",
                keyValue: 1871,
                columns: new[] { "CreatedDateTime", "PublicationDate" },
                values: new object[] { new DateTime(2024, 8, 16, 14, 36, 27, 277, DateTimeKind.Utc).AddTicks(3950), new DateTime(2024, 7, 20, 13, 4, 25, 439, DateTimeKind.Local).AddTicks(1501) });

            migrationBuilder.UpdateData(
                table: "Book",
                keyColumn: "BookId",
                keyValue: 1872,
                columns: new[] { "CreatedDateTime", "PublicationDate" },
                values: new object[] { new DateTime(2024, 8, 16, 14, 36, 27, 277, DateTimeKind.Utc).AddTicks(4065), new DateTime(2024, 4, 4, 8, 7, 25, 693, DateTimeKind.Local).AddTicks(8859) });

            migrationBuilder.UpdateData(
                table: "Book",
                keyColumn: "BookId",
                keyValue: 1873,
                columns: new[] { "CreatedDateTime", "PublicationDate" },
                values: new object[] { new DateTime(2024, 8, 16, 14, 36, 27, 277, DateTimeKind.Utc).AddTicks(4186), new DateTime(2023, 11, 21, 21, 34, 15, 368, DateTimeKind.Local).AddTicks(4566) });

            migrationBuilder.UpdateData(
                table: "Book",
                keyColumn: "BookId",
                keyValue: 1874,
                columns: new[] { "CreatedDateTime", "PublicationDate" },
                values: new object[] { new DateTime(2024, 8, 16, 14, 36, 27, 277, DateTimeKind.Utc).AddTicks(4280), new DateTime(2024, 7, 9, 17, 3, 4, 999, DateTimeKind.Local).AddTicks(1413) });

            migrationBuilder.UpdateData(
                table: "Book",
                keyColumn: "BookId",
                keyValue: 1875,
                columns: new[] { "CreatedDateTime", "PublicationDate" },
                values: new object[] { new DateTime(2024, 8, 16, 14, 36, 27, 277, DateTimeKind.Utc).AddTicks(4430), new DateTime(2024, 8, 15, 13, 55, 57, 255, DateTimeKind.Local).AddTicks(5400) });

            migrationBuilder.UpdateData(
                table: "Book",
                keyColumn: "BookId",
                keyValue: 1876,
                columns: new[] { "CreatedDateTime", "PublicationDate" },
                values: new object[] { new DateTime(2024, 8, 16, 14, 36, 27, 277, DateTimeKind.Utc).AddTicks(4531), new DateTime(2024, 5, 14, 4, 40, 35, 830, DateTimeKind.Local).AddTicks(8432) });

            migrationBuilder.UpdateData(
                table: "Book",
                keyColumn: "BookId",
                keyValue: 1877,
                columns: new[] { "CreatedDateTime", "PublicationDate" },
                values: new object[] { new DateTime(2024, 8, 16, 14, 36, 27, 277, DateTimeKind.Utc).AddTicks(4663), new DateTime(2023, 8, 17, 1, 40, 40, 802, DateTimeKind.Local).AddTicks(8990) });

            migrationBuilder.UpdateData(
                table: "Book",
                keyColumn: "BookId",
                keyValue: 1878,
                columns: new[] { "CreatedDateTime", "PublicationDate" },
                values: new object[] { new DateTime(2024, 8, 16, 14, 36, 27, 277, DateTimeKind.Utc).AddTicks(4762), new DateTime(2024, 4, 19, 19, 33, 18, 244, DateTimeKind.Local).AddTicks(5708) });

            migrationBuilder.UpdateData(
                table: "Book",
                keyColumn: "BookId",
                keyValue: 1879,
                columns: new[] { "CreatedDateTime", "PublicationDate" },
                values: new object[] { new DateTime(2024, 8, 16, 14, 36, 27, 277, DateTimeKind.Utc).AddTicks(4897), new DateTime(2024, 7, 15, 3, 44, 33, 201, DateTimeKind.Local).AddTicks(8404) });

            migrationBuilder.UpdateData(
                table: "Book",
                keyColumn: "BookId",
                keyValue: 1880,
                columns: new[] { "CreatedDateTime", "PublicationDate" },
                values: new object[] { new DateTime(2024, 8, 16, 14, 36, 27, 277, DateTimeKind.Utc).AddTicks(5026), new DateTime(2024, 1, 2, 19, 22, 18, 507, DateTimeKind.Local).AddTicks(4352) });

            migrationBuilder.UpdateData(
                table: "Book",
                keyColumn: "BookId",
                keyValue: 1881,
                columns: new[] { "CreatedDateTime", "PublicationDate" },
                values: new object[] { new DateTime(2024, 8, 16, 14, 36, 27, 277, DateTimeKind.Utc).AddTicks(5124), new DateTime(2024, 2, 21, 23, 56, 9, 58, DateTimeKind.Local).AddTicks(4463) });

            migrationBuilder.UpdateData(
                table: "Book",
                keyColumn: "BookId",
                keyValue: 1882,
                columns: new[] { "CreatedDateTime", "PublicationDate" },
                values: new object[] { new DateTime(2024, 8, 16, 14, 36, 27, 277, DateTimeKind.Utc).AddTicks(5232), new DateTime(2024, 1, 29, 11, 56, 21, 353, DateTimeKind.Local).AddTicks(7248) });

            migrationBuilder.UpdateData(
                table: "Book",
                keyColumn: "BookId",
                keyValue: 1883,
                columns: new[] { "CreatedDateTime", "PublicationDate" },
                values: new object[] { new DateTime(2024, 8, 16, 14, 36, 27, 277, DateTimeKind.Utc).AddTicks(5356), new DateTime(2024, 3, 25, 20, 34, 12, 105, DateTimeKind.Local).AddTicks(8388) });

            migrationBuilder.UpdateData(
                table: "Book",
                keyColumn: "BookId",
                keyValue: 1884,
                columns: new[] { "CreatedDateTime", "PublicationDate" },
                values: new object[] { new DateTime(2024, 8, 16, 14, 36, 27, 277, DateTimeKind.Utc).AddTicks(5448), new DateTime(2023, 8, 16, 13, 48, 34, 779, DateTimeKind.Local).AddTicks(3085) });

            migrationBuilder.UpdateData(
                table: "Book",
                keyColumn: "BookId",
                keyValue: 1885,
                columns: new[] { "CreatedDateTime", "PublicationDate" },
                values: new object[] { new DateTime(2024, 8, 16, 14, 36, 27, 277, DateTimeKind.Utc).AddTicks(5585), new DateTime(2023, 11, 19, 21, 28, 14, 573, DateTimeKind.Local).AddTicks(2905) });

            migrationBuilder.UpdateData(
                table: "Book",
                keyColumn: "BookId",
                keyValue: 1886,
                columns: new[] { "CreatedDateTime", "PublicationDate" },
                values: new object[] { new DateTime(2024, 8, 16, 14, 36, 27, 277, DateTimeKind.Utc).AddTicks(5693), new DateTime(2023, 11, 1, 17, 36, 0, 729, DateTimeKind.Local).AddTicks(9835) });

            migrationBuilder.UpdateData(
                table: "Book",
                keyColumn: "BookId",
                keyValue: 1887,
                columns: new[] { "CreatedDateTime", "PublicationDate" },
                values: new object[] { new DateTime(2024, 8, 16, 14, 36, 27, 277, DateTimeKind.Utc).AddTicks(5804), new DateTime(2023, 10, 24, 10, 22, 12, 583, DateTimeKind.Local).AddTicks(7334) });

            migrationBuilder.UpdateData(
                table: "Book",
                keyColumn: "BookId",
                keyValue: 1888,
                columns: new[] { "CreatedDateTime", "PublicationDate" },
                values: new object[] { new DateTime(2024, 8, 16, 14, 36, 27, 277, DateTimeKind.Utc).AddTicks(5950), new DateTime(2023, 11, 21, 8, 44, 54, 897, DateTimeKind.Local).AddTicks(9272) });

            migrationBuilder.UpdateData(
                table: "Book",
                keyColumn: "BookId",
                keyValue: 1889,
                columns: new[] { "CreatedDateTime", "PublicationDate" },
                values: new object[] { new DateTime(2024, 8, 16, 14, 36, 27, 277, DateTimeKind.Utc).AddTicks(6054), new DateTime(2023, 10, 15, 1, 49, 17, 31, DateTimeKind.Local).AddTicks(603) });

            migrationBuilder.UpdateData(
                table: "Book",
                keyColumn: "BookId",
                keyValue: 1890,
                columns: new[] { "CreatedDateTime", "PublicationDate" },
                values: new object[] { new DateTime(2024, 8, 16, 14, 36, 27, 277, DateTimeKind.Utc).AddTicks(6183), new DateTime(2024, 5, 3, 2, 20, 48, 435, DateTimeKind.Local).AddTicks(2953) });

            migrationBuilder.UpdateData(
                table: "Book",
                keyColumn: "BookId",
                keyValue: 1891,
                columns: new[] { "CreatedDateTime", "PublicationDate" },
                values: new object[] { new DateTime(2024, 8, 16, 14, 36, 27, 277, DateTimeKind.Utc).AddTicks(6276), new DateTime(2023, 9, 12, 4, 27, 16, 648, DateTimeKind.Local).AddTicks(1036) });

            migrationBuilder.UpdateData(
                table: "Book",
                keyColumn: "BookId",
                keyValue: 1892,
                columns: new[] { "CreatedDateTime", "PublicationDate" },
                values: new object[] { new DateTime(2024, 8, 16, 14, 36, 27, 277, DateTimeKind.Utc).AddTicks(6412), new DateTime(2023, 11, 29, 11, 27, 27, 522, DateTimeKind.Local).AddTicks(6089) });

            migrationBuilder.UpdateData(
                table: "Book",
                keyColumn: "BookId",
                keyValue: 1893,
                columns: new[] { "CreatedDateTime", "PublicationDate" },
                values: new object[] { new DateTime(2024, 8, 16, 14, 36, 27, 277, DateTimeKind.Utc).AddTicks(6521), new DateTime(2024, 7, 28, 7, 14, 30, 122, DateTimeKind.Local).AddTicks(4203) });

            migrationBuilder.UpdateData(
                table: "Book",
                keyColumn: "BookId",
                keyValue: 1894,
                columns: new[] { "CreatedDateTime", "PublicationDate" },
                values: new object[] { new DateTime(2024, 8, 16, 14, 36, 27, 277, DateTimeKind.Utc).AddTicks(6659), new DateTime(2023, 12, 23, 23, 27, 19, 694, DateTimeKind.Local).AddTicks(1695) });

            migrationBuilder.UpdateData(
                table: "Book",
                keyColumn: "BookId",
                keyValue: 1895,
                columns: new[] { "CreatedDateTime", "PublicationDate" },
                values: new object[] { new DateTime(2024, 8, 16, 14, 36, 27, 277, DateTimeKind.Utc).AddTicks(6751), new DateTime(2023, 9, 5, 5, 1, 47, 612, DateTimeKind.Local).AddTicks(4601) });

            migrationBuilder.UpdateData(
                table: "Book",
                keyColumn: "BookId",
                keyValue: 1896,
                columns: new[] { "CreatedDateTime", "PublicationDate" },
                values: new object[] { new DateTime(2024, 8, 16, 14, 36, 27, 277, DateTimeKind.Utc).AddTicks(6886), new DateTime(2023, 12, 7, 9, 1, 50, 599, DateTimeKind.Local).AddTicks(497) });

            migrationBuilder.UpdateData(
                table: "Book",
                keyColumn: "BookId",
                keyValue: 1897,
                columns: new[] { "CreatedDateTime", "PublicationDate" },
                values: new object[] { new DateTime(2024, 8, 16, 14, 36, 27, 277, DateTimeKind.Utc).AddTicks(6988), new DateTime(2024, 8, 9, 23, 10, 47, 686, DateTimeKind.Local).AddTicks(4701) });

            migrationBuilder.UpdateData(
                table: "Book",
                keyColumn: "BookId",
                keyValue: 1898,
                columns: new[] { "CreatedDateTime", "PublicationDate" },
                values: new object[] { new DateTime(2024, 8, 16, 14, 36, 27, 277, DateTimeKind.Utc).AddTicks(7116), new DateTime(2023, 10, 9, 17, 40, 4, 789, DateTimeKind.Local).AddTicks(8346) });

            migrationBuilder.UpdateData(
                table: "Book",
                keyColumn: "BookId",
                keyValue: 1899,
                columns: new[] { "CreatedDateTime", "PublicationDate" },
                values: new object[] { new DateTime(2024, 8, 16, 14, 36, 27, 277, DateTimeKind.Utc).AddTicks(7211), new DateTime(2024, 4, 25, 6, 17, 46, 390, DateTimeKind.Local).AddTicks(9587) });

            migrationBuilder.UpdateData(
                table: "Book",
                keyColumn: "BookId",
                keyValue: 1900,
                columns: new[] { "CreatedDateTime", "PublicationDate" },
                values: new object[] { new DateTime(2024, 8, 16, 14, 36, 27, 277, DateTimeKind.Utc).AddTicks(7337), new DateTime(2023, 11, 9, 1, 51, 32, 512, DateTimeKind.Local).AddTicks(1249) });

            migrationBuilder.UpdateData(
                table: "Book",
                keyColumn: "BookId",
                keyValue: 1901,
                columns: new[] { "CreatedDateTime", "PublicationDate" },
                values: new object[] { new DateTime(2024, 8, 16, 14, 36, 27, 277, DateTimeKind.Utc).AddTicks(7440), new DateTime(2024, 2, 17, 20, 58, 1, 631, DateTimeKind.Local).AddTicks(4691) });

            migrationBuilder.UpdateData(
                table: "Book",
                keyColumn: "BookId",
                keyValue: 1902,
                columns: new[] { "CreatedDateTime", "PublicationDate" },
                values: new object[] { new DateTime(2024, 8, 16, 14, 36, 27, 277, DateTimeKind.Utc).AddTicks(7581), new DateTime(2024, 7, 19, 4, 4, 36, 399, DateTimeKind.Local).AddTicks(2896) });

            migrationBuilder.UpdateData(
                table: "Book",
                keyColumn: "BookId",
                keyValue: 1903,
                columns: new[] { "CreatedDateTime", "PublicationDate" },
                values: new object[] { new DateTime(2024, 8, 16, 14, 36, 27, 277, DateTimeKind.Utc).AddTicks(7748), new DateTime(2024, 7, 2, 18, 46, 0, 148, DateTimeKind.Local).AddTicks(1775) });

            migrationBuilder.UpdateData(
                table: "Book",
                keyColumn: "BookId",
                keyValue: 1904,
                columns: new[] { "CreatedDateTime", "PublicationDate" },
                values: new object[] { new DateTime(2024, 8, 16, 14, 36, 27, 277, DateTimeKind.Utc).AddTicks(7950), new DateTime(2024, 2, 3, 9, 34, 26, 532, DateTimeKind.Local).AddTicks(1454) });

            migrationBuilder.UpdateData(
                table: "Book",
                keyColumn: "BookId",
                keyValue: 1905,
                columns: new[] { "CreatedDateTime", "PublicationDate" },
                values: new object[] { new DateTime(2024, 8, 16, 14, 36, 27, 277, DateTimeKind.Utc).AddTicks(8158), new DateTime(2024, 1, 17, 11, 4, 10, 806, DateTimeKind.Local).AddTicks(8461) });

            migrationBuilder.UpdateData(
                table: "Book",
                keyColumn: "BookId",
                keyValue: 1906,
                columns: new[] { "CreatedDateTime", "PublicationDate" },
                values: new object[] { new DateTime(2024, 8, 16, 14, 36, 27, 277, DateTimeKind.Utc).AddTicks(8310), new DateTime(2024, 7, 12, 21, 32, 30, 994, DateTimeKind.Local).AddTicks(5490) });

            migrationBuilder.UpdateData(
                table: "Book",
                keyColumn: "BookId",
                keyValue: 1907,
                columns: new[] { "CreatedDateTime", "PublicationDate" },
                values: new object[] { new DateTime(2024, 8, 16, 14, 36, 27, 277, DateTimeKind.Utc).AddTicks(8496), new DateTime(2023, 12, 21, 23, 29, 39, 280, DateTimeKind.Local).AddTicks(4036) });

            migrationBuilder.UpdateData(
                table: "Book",
                keyColumn: "BookId",
                keyValue: 1908,
                columns: new[] { "CreatedDateTime", "PublicationDate" },
                values: new object[] { new DateTime(2024, 8, 16, 14, 36, 27, 277, DateTimeKind.Utc).AddTicks(8638), new DateTime(2023, 11, 23, 17, 17, 37, 59, DateTimeKind.Local).AddTicks(8263) });

            migrationBuilder.UpdateData(
                table: "Book",
                keyColumn: "BookId",
                keyValue: 1909,
                columns: new[] { "CreatedDateTime", "PublicationDate" },
                values: new object[] { new DateTime(2024, 8, 16, 14, 36, 27, 277, DateTimeKind.Utc).AddTicks(8817), new DateTime(2023, 9, 8, 17, 44, 35, 535, DateTimeKind.Local).AddTicks(9537) });

            migrationBuilder.UpdateData(
                table: "Book",
                keyColumn: "BookId",
                keyValue: 1910,
                columns: new[] { "CreatedDateTime", "PublicationDate" },
                values: new object[] { new DateTime(2024, 8, 16, 14, 36, 27, 277, DateTimeKind.Utc).AddTicks(8949), new DateTime(2023, 12, 18, 4, 58, 3, 486, DateTimeKind.Local).AddTicks(1135) });

            migrationBuilder.UpdateData(
                table: "Book",
                keyColumn: "BookId",
                keyValue: 1911,
                columns: new[] { "CreatedDateTime", "PublicationDate" },
                values: new object[] { new DateTime(2024, 8, 16, 14, 36, 27, 277, DateTimeKind.Utc).AddTicks(9122), new DateTime(2024, 4, 27, 14, 6, 51, 390, DateTimeKind.Local).AddTicks(8672) });

            migrationBuilder.UpdateData(
                table: "Book",
                keyColumn: "BookId",
                keyValue: 1912,
                columns: new[] { "CreatedDateTime", "PublicationDate" },
                values: new object[] { new DateTime(2024, 8, 16, 14, 36, 27, 277, DateTimeKind.Utc).AddTicks(9261), new DateTime(2024, 8, 12, 2, 56, 50, 32, DateTimeKind.Local).AddTicks(6184) });

            migrationBuilder.UpdateData(
                table: "Book",
                keyColumn: "BookId",
                keyValue: 1913,
                columns: new[] { "CreatedDateTime", "PublicationDate" },
                values: new object[] { new DateTime(2024, 8, 16, 14, 36, 27, 277, DateTimeKind.Utc).AddTicks(9444), new DateTime(2023, 12, 3, 6, 57, 1, 307, DateTimeKind.Local).AddTicks(771) });

            migrationBuilder.UpdateData(
                table: "Book",
                keyColumn: "BookId",
                keyValue: 1914,
                columns: new[] { "CreatedDateTime", "PublicationDate" },
                values: new object[] { new DateTime(2024, 8, 16, 14, 36, 27, 277, DateTimeKind.Utc).AddTicks(9588), new DateTime(2024, 1, 24, 17, 42, 7, 415, DateTimeKind.Local).AddTicks(8932) });

            migrationBuilder.UpdateData(
                table: "Book",
                keyColumn: "BookId",
                keyValue: 1915,
                columns: new[] { "CreatedDateTime", "PublicationDate" },
                values: new object[] { new DateTime(2024, 8, 16, 14, 36, 27, 277, DateTimeKind.Utc).AddTicks(9757), new DateTime(2023, 10, 9, 17, 15, 3, 557, DateTimeKind.Local).AddTicks(6881) });

            migrationBuilder.UpdateData(
                table: "Book",
                keyColumn: "BookId",
                keyValue: 1916,
                columns: new[] { "CreatedDateTime", "PublicationDate" },
                values: new object[] { new DateTime(2024, 8, 16, 14, 36, 27, 277, DateTimeKind.Utc).AddTicks(9886), new DateTime(2023, 12, 14, 23, 34, 37, 433, DateTimeKind.Local).AddTicks(2199) });

            migrationBuilder.UpdateData(
                table: "Book",
                keyColumn: "BookId",
                keyValue: 1917,
                columns: new[] { "CreatedDateTime", "PublicationDate" },
                values: new object[] { new DateTime(2024, 8, 16, 14, 36, 27, 278, DateTimeKind.Utc).AddTicks(34), new DateTime(2024, 4, 16, 4, 57, 1, 462, DateTimeKind.Local).AddTicks(8989) });

            migrationBuilder.UpdateData(
                table: "Book",
                keyColumn: "BookId",
                keyValue: 1918,
                columns: new[] { "CreatedDateTime", "PublicationDate" },
                values: new object[] { new DateTime(2024, 8, 16, 14, 36, 27, 278, DateTimeKind.Utc).AddTicks(147), new DateTime(2024, 1, 18, 23, 17, 56, 934, DateTimeKind.Local).AddTicks(9169) });

            migrationBuilder.UpdateData(
                table: "Book",
                keyColumn: "BookId",
                keyValue: 1919,
                columns: new[] { "CreatedDateTime", "PublicationDate" },
                values: new object[] { new DateTime(2024, 8, 16, 14, 36, 27, 278, DateTimeKind.Utc).AddTicks(359), new DateTime(2023, 11, 2, 12, 11, 26, 357, DateTimeKind.Local).AddTicks(3379) });

            migrationBuilder.UpdateData(
                table: "Book",
                keyColumn: "BookId",
                keyValue: 1920,
                columns: new[] { "CreatedDateTime", "PublicationDate" },
                values: new object[] { new DateTime(2024, 8, 16, 14, 36, 27, 278, DateTimeKind.Utc).AddTicks(512), new DateTime(2023, 9, 22, 11, 36, 14, 171, DateTimeKind.Local).AddTicks(639) });

            migrationBuilder.UpdateData(
                table: "Book",
                keyColumn: "BookId",
                keyValue: 1921,
                columns: new[] { "CreatedDateTime", "PublicationDate" },
                values: new object[] { new DateTime(2024, 8, 16, 14, 36, 27, 278, DateTimeKind.Utc).AddTicks(682), new DateTime(2024, 6, 12, 23, 48, 54, 739, DateTimeKind.Local).AddTicks(1690) });

            migrationBuilder.UpdateData(
                table: "Book",
                keyColumn: "BookId",
                keyValue: 1922,
                columns: new[] { "CreatedDateTime", "PublicationDate" },
                values: new object[] { new DateTime(2024, 8, 16, 14, 36, 27, 278, DateTimeKind.Utc).AddTicks(791), new DateTime(2024, 3, 22, 10, 26, 6, 897, DateTimeKind.Local).AddTicks(241) });

            migrationBuilder.UpdateData(
                table: "Book",
                keyColumn: "BookId",
                keyValue: 1923,
                columns: new[] { "CreatedDateTime", "PublicationDate" },
                values: new object[] { new DateTime(2024, 8, 16, 14, 36, 27, 278, DateTimeKind.Utc).AddTicks(916), new DateTime(2023, 10, 4, 0, 4, 4, 272, DateTimeKind.Local).AddTicks(5023) });

            migrationBuilder.UpdateData(
                table: "Book",
                keyColumn: "BookId",
                keyValue: 1924,
                columns: new[] { "CreatedDateTime", "PublicationDate" },
                values: new object[] { new DateTime(2024, 8, 16, 14, 36, 27, 278, DateTimeKind.Utc).AddTicks(1035), new DateTime(2024, 8, 9, 20, 10, 47, 262, DateTimeKind.Local).AddTicks(8930) });

            migrationBuilder.UpdateData(
                table: "Book",
                keyColumn: "BookId",
                keyValue: 1925,
                columns: new[] { "CreatedDateTime", "PublicationDate" },
                values: new object[] { new DateTime(2024, 8, 16, 14, 36, 27, 278, DateTimeKind.Utc).AddTicks(1163), new DateTime(2024, 3, 16, 4, 4, 43, 266, DateTimeKind.Local).AddTicks(1933) });

            migrationBuilder.UpdateData(
                table: "Book",
                keyColumn: "BookId",
                keyValue: 1926,
                columns: new[] { "CreatedDateTime", "PublicationDate" },
                values: new object[] { new DateTime(2024, 8, 16, 14, 36, 27, 278, DateTimeKind.Utc).AddTicks(1283), new DateTime(2024, 6, 7, 16, 20, 31, 584, DateTimeKind.Local).AddTicks(9213) });

            migrationBuilder.UpdateData(
                table: "Book",
                keyColumn: "BookId",
                keyValue: 1927,
                columns: new[] { "CreatedDateTime", "PublicationDate" },
                values: new object[] { new DateTime(2024, 8, 16, 14, 36, 27, 278, DateTimeKind.Utc).AddTicks(1412), new DateTime(2024, 1, 16, 7, 45, 35, 759, DateTimeKind.Local).AddTicks(2211) });

            migrationBuilder.UpdateData(
                table: "Book",
                keyColumn: "BookId",
                keyValue: 1928,
                columns: new[] { "CreatedDateTime", "PublicationDate" },
                values: new object[] { new DateTime(2024, 8, 16, 14, 36, 27, 278, DateTimeKind.Utc).AddTicks(1601), new DateTime(2024, 4, 16, 20, 14, 38, 888, DateTimeKind.Local).AddTicks(2883) });

            migrationBuilder.UpdateData(
                table: "Book",
                keyColumn: "BookId",
                keyValue: 1929,
                columns: new[] { "CreatedDateTime", "PublicationDate" },
                values: new object[] { new DateTime(2024, 8, 16, 14, 36, 27, 278, DateTimeKind.Utc).AddTicks(1738), new DateTime(2023, 9, 9, 1, 8, 24, 185, DateTimeKind.Local).AddTicks(3081) });

            migrationBuilder.UpdateData(
                table: "Book",
                keyColumn: "BookId",
                keyValue: 1930,
                columns: new[] { "CreatedDateTime", "PublicationDate" },
                values: new object[] { new DateTime(2024, 8, 16, 14, 36, 27, 278, DateTimeKind.Utc).AddTicks(1886), new DateTime(2024, 3, 11, 18, 42, 4, 652, DateTimeKind.Local).AddTicks(4151) });

            migrationBuilder.UpdateData(
                table: "Book",
                keyColumn: "BookId",
                keyValue: 1931,
                columns: new[] { "CreatedDateTime", "PublicationDate" },
                values: new object[] { new DateTime(2024, 8, 16, 14, 36, 27, 278, DateTimeKind.Utc).AddTicks(1994), new DateTime(2024, 4, 21, 2, 21, 49, 14, DateTimeKind.Local).AddTicks(4282) });

            migrationBuilder.UpdateData(
                table: "Book",
                keyColumn: "BookId",
                keyValue: 1932,
                columns: new[] { "CreatedDateTime", "PublicationDate" },
                values: new object[] { new DateTime(2024, 8, 16, 14, 36, 27, 278, DateTimeKind.Utc).AddTicks(2116), new DateTime(2024, 4, 27, 2, 28, 56, 756, DateTimeKind.Local).AddTicks(4751) });

            migrationBuilder.UpdateData(
                table: "Book",
                keyColumn: "BookId",
                keyValue: 1933,
                columns: new[] { "CreatedDateTime", "PublicationDate" },
                values: new object[] { new DateTime(2024, 8, 16, 14, 36, 27, 278, DateTimeKind.Utc).AddTicks(2210), new DateTime(2024, 1, 14, 19, 46, 21, 32, DateTimeKind.Local).AddTicks(1387) });

            migrationBuilder.UpdateData(
                table: "Book",
                keyColumn: "BookId",
                keyValue: 1934,
                columns: new[] { "CreatedDateTime", "PublicationDate" },
                values: new object[] { new DateTime(2024, 8, 16, 14, 36, 27, 278, DateTimeKind.Utc).AddTicks(2350), new DateTime(2024, 3, 24, 15, 49, 29, 646, DateTimeKind.Local).AddTicks(6630) });

            migrationBuilder.UpdateData(
                table: "Book",
                keyColumn: "BookId",
                keyValue: 1935,
                columns: new[] { "CreatedDateTime", "PublicationDate" },
                values: new object[] { new DateTime(2024, 8, 16, 14, 36, 27, 278, DateTimeKind.Utc).AddTicks(2453), new DateTime(2024, 7, 27, 11, 19, 23, 447, DateTimeKind.Local).AddTicks(3482) });

            migrationBuilder.UpdateData(
                table: "Book",
                keyColumn: "BookId",
                keyValue: 1936,
                columns: new[] { "CreatedDateTime", "PublicationDate" },
                values: new object[] { new DateTime(2024, 8, 16, 14, 36, 27, 278, DateTimeKind.Utc).AddTicks(2608), new DateTime(2024, 7, 19, 11, 41, 32, 706, DateTimeKind.Local).AddTicks(6150) });

            migrationBuilder.UpdateData(
                table: "Book",
                keyColumn: "BookId",
                keyValue: 1937,
                columns: new[] { "CreatedDateTime", "PublicationDate" },
                values: new object[] { new DateTime(2024, 8, 16, 14, 36, 27, 278, DateTimeKind.Utc).AddTicks(2714), new DateTime(2023, 10, 11, 2, 59, 25, 304, DateTimeKind.Local).AddTicks(535) });

            migrationBuilder.UpdateData(
                table: "Book",
                keyColumn: "BookId",
                keyValue: 1938,
                columns: new[] { "CreatedDateTime", "PublicationDate" },
                values: new object[] { new DateTime(2024, 8, 16, 14, 36, 27, 278, DateTimeKind.Utc).AddTicks(2837), new DateTime(2024, 5, 10, 9, 5, 56, 865, DateTimeKind.Local).AddTicks(970) });

            migrationBuilder.UpdateData(
                table: "Book",
                keyColumn: "BookId",
                keyValue: 1939,
                columns: new[] { "CreatedDateTime", "PublicationDate" },
                values: new object[] { new DateTime(2024, 8, 16, 14, 36, 27, 278, DateTimeKind.Utc).AddTicks(2944), new DateTime(2024, 3, 28, 10, 19, 20, 434, DateTimeKind.Local).AddTicks(7509) });

            migrationBuilder.UpdateData(
                table: "Book",
                keyColumn: "BookId",
                keyValue: 1940,
                columns: new[] { "CreatedDateTime", "PublicationDate" },
                values: new object[] { new DateTime(2024, 8, 16, 14, 36, 27, 278, DateTimeKind.Utc).AddTicks(3092), new DateTime(2023, 11, 15, 7, 12, 8, 267, DateTimeKind.Local).AddTicks(6393) });

            migrationBuilder.UpdateData(
                table: "Book",
                keyColumn: "BookId",
                keyValue: 1941,
                columns: new[] { "CreatedDateTime", "PublicationDate" },
                values: new object[] { new DateTime(2024, 8, 16, 14, 36, 27, 278, DateTimeKind.Utc).AddTicks(3224), new DateTime(2024, 7, 6, 12, 50, 10, 505, DateTimeKind.Local).AddTicks(5134) });

            migrationBuilder.UpdateData(
                table: "Book",
                keyColumn: "BookId",
                keyValue: 1942,
                columns: new[] { "CreatedDateTime", "PublicationDate" },
                values: new object[] { new DateTime(2024, 8, 16, 14, 36, 27, 278, DateTimeKind.Utc).AddTicks(3415), new DateTime(2024, 3, 30, 1, 31, 51, 48, DateTimeKind.Local).AddTicks(1331) });

            migrationBuilder.UpdateData(
                table: "Book",
                keyColumn: "BookId",
                keyValue: 1943,
                columns: new[] { "CreatedDateTime", "PublicationDate" },
                values: new object[] { new DateTime(2024, 8, 16, 14, 36, 27, 278, DateTimeKind.Utc).AddTicks(3645), new DateTime(2023, 11, 26, 1, 46, 2, 795, DateTimeKind.Local).AddTicks(941) });

            migrationBuilder.UpdateData(
                table: "Book",
                keyColumn: "BookId",
                keyValue: 1944,
                columns: new[] { "CreatedDateTime", "PublicationDate" },
                values: new object[] { new DateTime(2024, 8, 16, 14, 36, 27, 278, DateTimeKind.Utc).AddTicks(3788), new DateTime(2023, 12, 23, 16, 48, 11, 659, DateTimeKind.Local).AddTicks(1765) });

            migrationBuilder.UpdateData(
                table: "Book",
                keyColumn: "BookId",
                keyValue: 1945,
                columns: new[] { "CreatedDateTime", "PublicationDate" },
                values: new object[] { new DateTime(2024, 8, 16, 14, 36, 27, 278, DateTimeKind.Utc).AddTicks(3995), new DateTime(2023, 10, 5, 13, 52, 2, 658, DateTimeKind.Local).AddTicks(7396) });

            migrationBuilder.UpdateData(
                table: "Book",
                keyColumn: "BookId",
                keyValue: 1946,
                columns: new[] { "CreatedDateTime", "PublicationDate" },
                values: new object[] { new DateTime(2024, 8, 16, 14, 36, 27, 278, DateTimeKind.Utc).AddTicks(4157), new DateTime(2024, 2, 1, 20, 16, 52, 320, DateTimeKind.Local).AddTicks(4086) });

            migrationBuilder.UpdateData(
                table: "Book",
                keyColumn: "BookId",
                keyValue: 1947,
                columns: new[] { "CreatedDateTime", "PublicationDate" },
                values: new object[] { new DateTime(2024, 8, 16, 14, 36, 27, 278, DateTimeKind.Utc).AddTicks(4324), new DateTime(2023, 12, 27, 23, 40, 50, 152, DateTimeKind.Local).AddTicks(9081) });

            migrationBuilder.UpdateData(
                table: "Book",
                keyColumn: "BookId",
                keyValue: 1948,
                columns: new[] { "CreatedDateTime", "PublicationDate" },
                values: new object[] { new DateTime(2024, 8, 16, 14, 36, 27, 278, DateTimeKind.Utc).AddTicks(4489), new DateTime(2024, 6, 28, 14, 2, 14, 440, DateTimeKind.Local).AddTicks(232) });

            migrationBuilder.UpdateData(
                table: "Book",
                keyColumn: "BookId",
                keyValue: 1949,
                columns: new[] { "CreatedDateTime", "PublicationDate" },
                values: new object[] { new DateTime(2024, 8, 16, 14, 36, 27, 278, DateTimeKind.Utc).AddTicks(4671), new DateTime(2024, 5, 2, 21, 21, 42, 664, DateTimeKind.Local).AddTicks(8014) });

            migrationBuilder.UpdateData(
                table: "Book",
                keyColumn: "BookId",
                keyValue: 1950,
                columns: new[] { "CreatedDateTime", "PublicationDate" },
                values: new object[] { new DateTime(2024, 8, 16, 14, 36, 27, 278, DateTimeKind.Utc).AddTicks(4825), new DateTime(2023, 11, 21, 10, 20, 7, 530, DateTimeKind.Local).AddTicks(7185) });

            migrationBuilder.UpdateData(
                table: "Book",
                keyColumn: "BookId",
                keyValue: 1951,
                columns: new[] { "CreatedDateTime", "PublicationDate" },
                values: new object[] { new DateTime(2024, 8, 16, 14, 36, 27, 278, DateTimeKind.Utc).AddTicks(5019), new DateTime(2023, 12, 18, 0, 23, 10, 59, DateTimeKind.Local).AddTicks(6987) });

            migrationBuilder.UpdateData(
                table: "Book",
                keyColumn: "BookId",
                keyValue: 1952,
                columns: new[] { "CreatedDateTime", "PublicationDate" },
                values: new object[] { new DateTime(2024, 8, 16, 14, 36, 27, 278, DateTimeKind.Utc).AddTicks(5156), new DateTime(2024, 7, 8, 11, 3, 51, 945, DateTimeKind.Local).AddTicks(6489) });

            migrationBuilder.UpdateData(
                table: "Book",
                keyColumn: "BookId",
                keyValue: 1953,
                columns: new[] { "CreatedDateTime", "PublicationDate" },
                values: new object[] { new DateTime(2024, 8, 16, 14, 36, 27, 278, DateTimeKind.Utc).AddTicks(5352), new DateTime(2024, 7, 28, 9, 45, 33, 636, DateTimeKind.Local).AddTicks(49) });

            migrationBuilder.UpdateData(
                table: "Book",
                keyColumn: "BookId",
                keyValue: 1954,
                columns: new[] { "CreatedDateTime", "PublicationDate" },
                values: new object[] { new DateTime(2024, 8, 16, 14, 36, 27, 278, DateTimeKind.Utc).AddTicks(5494), new DateTime(2024, 6, 13, 12, 53, 28, 298, DateTimeKind.Local).AddTicks(4688) });

            migrationBuilder.UpdateData(
                table: "Book",
                keyColumn: "BookId",
                keyValue: 1955,
                columns: new[] { "CreatedDateTime", "PublicationDate" },
                values: new object[] { new DateTime(2024, 8, 16, 14, 36, 27, 278, DateTimeKind.Utc).AddTicks(5686), new DateTime(2024, 2, 7, 19, 39, 29, 948, DateTimeKind.Local).AddTicks(4154) });

            migrationBuilder.UpdateData(
                table: "Book",
                keyColumn: "BookId",
                keyValue: 1956,
                columns: new[] { "CreatedDateTime", "PublicationDate" },
                values: new object[] { new DateTime(2024, 8, 16, 14, 36, 27, 278, DateTimeKind.Utc).AddTicks(5838), new DateTime(2024, 3, 30, 13, 22, 53, 738, DateTimeKind.Local).AddTicks(4134) });

            migrationBuilder.UpdateData(
                table: "Book",
                keyColumn: "BookId",
                keyValue: 1957,
                columns: new[] { "CreatedDateTime", "PublicationDate" },
                values: new object[] { new DateTime(2024, 8, 16, 14, 36, 27, 278, DateTimeKind.Utc).AddTicks(6014), new DateTime(2023, 10, 23, 18, 43, 12, 627, DateTimeKind.Local).AddTicks(6791) });

            migrationBuilder.UpdateData(
                table: "Book",
                keyColumn: "BookId",
                keyValue: 1958,
                columns: new[] { "CreatedDateTime", "PublicationDate" },
                values: new object[] { new DateTime(2024, 8, 16, 14, 36, 27, 278, DateTimeKind.Utc).AddTicks(6169), new DateTime(2023, 10, 29, 1, 9, 5, 594, DateTimeKind.Local).AddTicks(5031) });

            migrationBuilder.UpdateData(
                table: "Book",
                keyColumn: "BookId",
                keyValue: 1959,
                columns: new[] { "CreatedDateTime", "PublicationDate" },
                values: new object[] { new DateTime(2024, 8, 16, 14, 36, 27, 278, DateTimeKind.Utc).AddTicks(6373), new DateTime(2024, 4, 25, 22, 47, 51, 602, DateTimeKind.Local).AddTicks(5797) });

            migrationBuilder.UpdateData(
                table: "Book",
                keyColumn: "BookId",
                keyValue: 1960,
                columns: new[] { "CreatedDateTime", "PublicationDate" },
                values: new object[] { new DateTime(2024, 8, 16, 14, 36, 27, 278, DateTimeKind.Utc).AddTicks(6543), new DateTime(2024, 5, 9, 4, 44, 19, 764, DateTimeKind.Local).AddTicks(4095) });

            migrationBuilder.UpdateData(
                table: "Book",
                keyColumn: "BookId",
                keyValue: 1961,
                columns: new[] { "CreatedDateTime", "PublicationDate" },
                values: new object[] { new DateTime(2024, 8, 16, 14, 36, 27, 278, DateTimeKind.Utc).AddTicks(6733), new DateTime(2024, 6, 10, 18, 46, 18, 91, DateTimeKind.Local).AddTicks(6815) });

            migrationBuilder.UpdateData(
                table: "Book",
                keyColumn: "BookId",
                keyValue: 1962,
                columns: new[] { "CreatedDateTime", "PublicationDate" },
                values: new object[] { new DateTime(2024, 8, 16, 14, 36, 27, 278, DateTimeKind.Utc).AddTicks(6904), new DateTime(2023, 12, 29, 5, 55, 45, 348, DateTimeKind.Local).AddTicks(9223) });

            migrationBuilder.UpdateData(
                table: "Book",
                keyColumn: "BookId",
                keyValue: 1963,
                columns: new[] { "CreatedDateTime", "PublicationDate" },
                values: new object[] { new DateTime(2024, 8, 16, 14, 36, 27, 278, DateTimeKind.Utc).AddTicks(7045), new DateTime(2024, 7, 19, 3, 41, 37, 5, DateTimeKind.Local).AddTicks(1805) });

            migrationBuilder.UpdateData(
                table: "Book",
                keyColumn: "BookId",
                keyValue: 1964,
                columns: new[] { "CreatedDateTime", "PublicationDate" },
                values: new object[] { new DateTime(2024, 8, 16, 14, 36, 27, 278, DateTimeKind.Utc).AddTicks(7189), new DateTime(2023, 11, 14, 1, 10, 42, 302, DateTimeKind.Local).AddTicks(6697) });

            migrationBuilder.UpdateData(
                table: "Book",
                keyColumn: "BookId",
                keyValue: 1965,
                columns: new[] { "CreatedDateTime", "PublicationDate" },
                values: new object[] { new DateTime(2024, 8, 16, 14, 36, 27, 278, DateTimeKind.Utc).AddTicks(7385), new DateTime(2023, 10, 20, 8, 24, 24, 304, DateTimeKind.Local).AddTicks(5021) });

            migrationBuilder.UpdateData(
                table: "Book",
                keyColumn: "BookId",
                keyValue: 1966,
                columns: new[] { "CreatedDateTime", "PublicationDate" },
                values: new object[] { new DateTime(2024, 8, 16, 14, 36, 27, 278, DateTimeKind.Utc).AddTicks(7596), new DateTime(2024, 3, 27, 10, 5, 4, 64, DateTimeKind.Local).AddTicks(402) });

            migrationBuilder.UpdateData(
                table: "Book",
                keyColumn: "BookId",
                keyValue: 1967,
                columns: new[] { "CreatedDateTime", "PublicationDate" },
                values: new object[] { new DateTime(2024, 8, 16, 14, 36, 27, 278, DateTimeKind.Utc).AddTicks(7745), new DateTime(2024, 6, 19, 14, 19, 57, 401, DateTimeKind.Local).AddTicks(7544) });

            migrationBuilder.UpdateData(
                table: "Book",
                keyColumn: "BookId",
                keyValue: 1968,
                columns: new[] { "CreatedDateTime", "PublicationDate" },
                values: new object[] { new DateTime(2024, 8, 16, 14, 36, 27, 278, DateTimeKind.Utc).AddTicks(7937), new DateTime(2024, 2, 14, 20, 14, 31, 612, DateTimeKind.Local).AddTicks(374) });

            migrationBuilder.UpdateData(
                table: "Book",
                keyColumn: "BookId",
                keyValue: 1969,
                columns: new[] { "CreatedDateTime", "PublicationDate" },
                values: new object[] { new DateTime(2024, 8, 16, 14, 36, 27, 278, DateTimeKind.Utc).AddTicks(8106), new DateTime(2024, 3, 21, 2, 56, 21, 507, DateTimeKind.Local).AddTicks(8874) });

            migrationBuilder.UpdateData(
                table: "Book",
                keyColumn: "BookId",
                keyValue: 1970,
                columns: new[] { "CreatedDateTime", "PublicationDate" },
                values: new object[] { new DateTime(2024, 8, 16, 14, 36, 27, 278, DateTimeKind.Utc).AddTicks(8282), new DateTime(2024, 3, 6, 20, 10, 58, 671, DateTimeKind.Local).AddTicks(6414) });

            migrationBuilder.UpdateData(
                table: "Book",
                keyColumn: "BookId",
                keyValue: 1971,
                columns: new[] { "CreatedDateTime", "PublicationDate" },
                values: new object[] { new DateTime(2024, 8, 16, 14, 36, 27, 278, DateTimeKind.Utc).AddTicks(8402), new DateTime(2023, 12, 2, 22, 37, 15, 887, DateTimeKind.Local).AddTicks(9827) });

            migrationBuilder.UpdateData(
                table: "Book",
                keyColumn: "BookId",
                keyValue: 1972,
                columns: new[] { "CreatedDateTime", "PublicationDate" },
                values: new object[] { new DateTime(2024, 8, 16, 14, 36, 27, 278, DateTimeKind.Utc).AddTicks(8542), new DateTime(2023, 11, 21, 20, 19, 51, 18, DateTimeKind.Local).AddTicks(7291) });

            migrationBuilder.UpdateData(
                table: "Book",
                keyColumn: "BookId",
                keyValue: 1973,
                columns: new[] { "CreatedDateTime", "PublicationDate" },
                values: new object[] { new DateTime(2024, 8, 16, 14, 36, 27, 278, DateTimeKind.Utc).AddTicks(8649), new DateTime(2024, 2, 2, 16, 52, 57, 920, DateTimeKind.Local).AddTicks(639) });

            migrationBuilder.UpdateData(
                table: "Book",
                keyColumn: "BookId",
                keyValue: 1974,
                columns: new[] { "CreatedDateTime", "PublicationDate" },
                values: new object[] { new DateTime(2024, 8, 16, 14, 36, 27, 278, DateTimeKind.Utc).AddTicks(8791), new DateTime(2024, 6, 23, 21, 8, 20, 823, DateTimeKind.Local).AddTicks(4107) });

            migrationBuilder.UpdateData(
                table: "Book",
                keyColumn: "BookId",
                keyValue: 1975,
                columns: new[] { "CreatedDateTime", "PublicationDate" },
                values: new object[] { new DateTime(2024, 8, 16, 14, 36, 27, 278, DateTimeKind.Utc).AddTicks(8896), new DateTime(2024, 3, 12, 14, 28, 57, 190, DateTimeKind.Local).AddTicks(9713) });

            migrationBuilder.UpdateData(
                table: "Book",
                keyColumn: "BookId",
                keyValue: 1976,
                columns: new[] { "CreatedDateTime", "PublicationDate" },
                values: new object[] { new DateTime(2024, 8, 16, 14, 36, 27, 278, DateTimeKind.Utc).AddTicks(9034), new DateTime(2023, 10, 31, 19, 40, 7, 854, DateTimeKind.Local).AddTicks(5162) });

            migrationBuilder.UpdateData(
                table: "Book",
                keyColumn: "BookId",
                keyValue: 1977,
                columns: new[] { "CreatedDateTime", "PublicationDate" },
                values: new object[] { new DateTime(2024, 8, 16, 14, 36, 27, 278, DateTimeKind.Utc).AddTicks(9158), new DateTime(2024, 2, 19, 6, 46, 53, 765, DateTimeKind.Local).AddTicks(1724) });

            migrationBuilder.UpdateData(
                table: "Book",
                keyColumn: "BookId",
                keyValue: 1978,
                columns: new[] { "CreatedDateTime", "PublicationDate" },
                values: new object[] { new DateTime(2024, 8, 16, 14, 36, 27, 278, DateTimeKind.Utc).AddTicks(9259), new DateTime(2023, 10, 18, 0, 48, 53, 468, DateTimeKind.Local).AddTicks(3289) });

            migrationBuilder.UpdateData(
                table: "Book",
                keyColumn: "BookId",
                keyValue: 1979,
                columns: new[] { "CreatedDateTime", "PublicationDate" },
                values: new object[] { new DateTime(2024, 8, 16, 14, 36, 27, 278, DateTimeKind.Utc).AddTicks(9397), new DateTime(2024, 1, 23, 1, 40, 21, 930, DateTimeKind.Local).AddTicks(9691) });

            migrationBuilder.UpdateData(
                table: "Book",
                keyColumn: "BookId",
                keyValue: 1980,
                columns: new[] { "CreatedDateTime", "PublicationDate" },
                values: new object[] { new DateTime(2024, 8, 16, 14, 36, 27, 278, DateTimeKind.Utc).AddTicks(9500), new DateTime(2024, 7, 5, 14, 26, 52, 103, DateTimeKind.Local).AddTicks(4347) });

            migrationBuilder.UpdateData(
                table: "Book",
                keyColumn: "BookId",
                keyValue: 1981,
                columns: new[] { "CreatedDateTime", "PublicationDate" },
                values: new object[] { new DateTime(2024, 8, 16, 14, 36, 27, 278, DateTimeKind.Utc).AddTicks(9642), new DateTime(2024, 6, 2, 0, 24, 24, 924, DateTimeKind.Local).AddTicks(2459) });

            migrationBuilder.UpdateData(
                table: "Book",
                keyColumn: "BookId",
                keyValue: 1982,
                columns: new[] { "CreatedDateTime", "PublicationDate" },
                values: new object[] { new DateTime(2024, 8, 16, 14, 36, 27, 278, DateTimeKind.Utc).AddTicks(9741), new DateTime(2023, 10, 11, 23, 54, 17, 759, DateTimeKind.Local).AddTicks(6492) });

            migrationBuilder.UpdateData(
                table: "Book",
                keyColumn: "BookId",
                keyValue: 1983,
                columns: new[] { "CreatedDateTime", "PublicationDate" },
                values: new object[] { new DateTime(2024, 8, 16, 14, 36, 27, 278, DateTimeKind.Utc).AddTicks(9881), new DateTime(2023, 11, 14, 1, 30, 36, 968, DateTimeKind.Local).AddTicks(7547) });

            migrationBuilder.UpdateData(
                table: "Book",
                keyColumn: "BookId",
                keyValue: 1984,
                columns: new[] { "CreatedDateTime", "PublicationDate" },
                values: new object[] { new DateTime(2024, 8, 16, 14, 36, 27, 279, DateTimeKind.Utc).AddTicks(27), new DateTime(2023, 11, 16, 6, 47, 47, 506, DateTimeKind.Local).AddTicks(1460) });

            migrationBuilder.UpdateData(
                table: "Book",
                keyColumn: "BookId",
                keyValue: 1985,
                columns: new[] { "CreatedDateTime", "PublicationDate" },
                values: new object[] { new DateTime(2024, 8, 16, 14, 36, 27, 279, DateTimeKind.Utc).AddTicks(121), new DateTime(2024, 8, 4, 10, 50, 4, 857, DateTimeKind.Local).AddTicks(2079) });

            migrationBuilder.UpdateData(
                table: "Book",
                keyColumn: "BookId",
                keyValue: 1986,
                columns: new[] { "CreatedDateTime", "PublicationDate" },
                values: new object[] { new DateTime(2024, 8, 16, 14, 36, 27, 279, DateTimeKind.Utc).AddTicks(254), new DateTime(2024, 1, 24, 19, 57, 22, 117, DateTimeKind.Local).AddTicks(9070) });

            migrationBuilder.UpdateData(
                table: "Book",
                keyColumn: "BookId",
                keyValue: 1987,
                columns: new[] { "CreatedDateTime", "PublicationDate" },
                values: new object[] { new DateTime(2024, 8, 16, 14, 36, 27, 279, DateTimeKind.Utc).AddTicks(375), new DateTime(2024, 7, 11, 10, 27, 40, 638, DateTimeKind.Local).AddTicks(881) });

            migrationBuilder.UpdateData(
                table: "Book",
                keyColumn: "BookId",
                keyValue: 1988,
                columns: new[] { "CreatedDateTime", "PublicationDate" },
                values: new object[] { new DateTime(2024, 8, 16, 14, 36, 27, 279, DateTimeKind.Utc).AddTicks(484), new DateTime(2023, 9, 30, 12, 8, 8, 195, DateTimeKind.Local).AddTicks(6336) });

            migrationBuilder.UpdateData(
                table: "Book",
                keyColumn: "BookId",
                keyValue: 1989,
                columns: new[] { "CreatedDateTime", "PublicationDate" },
                values: new object[] { new DateTime(2024, 8, 16, 14, 36, 27, 279, DateTimeKind.Utc).AddTicks(615), new DateTime(2024, 3, 7, 6, 36, 22, 134, DateTimeKind.Local).AddTicks(2635) });

            migrationBuilder.UpdateData(
                table: "Book",
                keyColumn: "BookId",
                keyValue: 1990,
                columns: new[] { "CreatedDateTime", "PublicationDate" },
                values: new object[] { new DateTime(2024, 8, 16, 14, 36, 27, 279, DateTimeKind.Utc).AddTicks(712), new DateTime(2024, 1, 26, 22, 11, 8, 226, DateTimeKind.Local).AddTicks(6688) });

            migrationBuilder.UpdateData(
                table: "Book",
                keyColumn: "BookId",
                keyValue: 1991,
                columns: new[] { "CreatedDateTime", "PublicationDate" },
                values: new object[] { new DateTime(2024, 8, 16, 14, 36, 27, 279, DateTimeKind.Utc).AddTicks(844), new DateTime(2024, 6, 17, 22, 51, 9, 306, DateTimeKind.Local).AddTicks(7563) });

            migrationBuilder.UpdateData(
                table: "Book",
                keyColumn: "BookId",
                keyValue: 1992,
                columns: new[] { "CreatedDateTime", "PublicationDate" },
                values: new object[] { new DateTime(2024, 8, 16, 14, 36, 27, 279, DateTimeKind.Utc).AddTicks(942), new DateTime(2023, 11, 16, 2, 53, 8, 340, DateTimeKind.Local).AddTicks(8372) });

            migrationBuilder.UpdateData(
                table: "Book",
                keyColumn: "BookId",
                keyValue: 1993,
                columns: new[] { "CreatedDateTime", "PublicationDate" },
                values: new object[] { new DateTime(2024, 8, 16, 14, 36, 27, 279, DateTimeKind.Utc).AddTicks(1062), new DateTime(2023, 11, 20, 7, 42, 4, 636, DateTimeKind.Local).AddTicks(2824) });

            migrationBuilder.UpdateData(
                table: "Book",
                keyColumn: "BookId",
                keyValue: 1994,
                columns: new[] { "CreatedDateTime", "PublicationDate" },
                values: new object[] { new DateTime(2024, 8, 16, 14, 36, 27, 279, DateTimeKind.Utc).AddTicks(1173), new DateTime(2024, 3, 17, 12, 22, 43, 965, DateTimeKind.Local).AddTicks(6857) });

            migrationBuilder.UpdateData(
                table: "Book",
                keyColumn: "BookId",
                keyValue: 1995,
                columns: new[] { "CreatedDateTime", "PublicationDate" },
                values: new object[] { new DateTime(2024, 8, 16, 14, 36, 27, 279, DateTimeKind.Utc).AddTicks(1300), new DateTime(2023, 12, 14, 14, 3, 27, 282, DateTimeKind.Local).AddTicks(7483) });

            migrationBuilder.UpdateData(
                table: "Book",
                keyColumn: "BookId",
                keyValue: 1996,
                columns: new[] { "CreatedDateTime", "PublicationDate" },
                values: new object[] { new DateTime(2024, 8, 16, 14, 36, 27, 279, DateTimeKind.Utc).AddTicks(1401), new DateTime(2023, 10, 1, 9, 42, 51, 572, DateTimeKind.Local).AddTicks(5925) });

            migrationBuilder.UpdateData(
                table: "Book",
                keyColumn: "BookId",
                keyValue: 1997,
                columns: new[] { "CreatedDateTime", "PublicationDate" },
                values: new object[] { new DateTime(2024, 8, 16, 14, 36, 27, 279, DateTimeKind.Utc).AddTicks(1535), new DateTime(2024, 4, 19, 10, 17, 2, 938, DateTimeKind.Local).AddTicks(611) });

            migrationBuilder.UpdateData(
                table: "Book",
                keyColumn: "BookId",
                keyValue: 1998,
                columns: new[] { "CreatedDateTime", "PublicationDate" },
                values: new object[] { new DateTime(2024, 8, 16, 14, 36, 27, 279, DateTimeKind.Utc).AddTicks(1636), new DateTime(2024, 3, 12, 3, 43, 27, 32, DateTimeKind.Local).AddTicks(4411) });

            migrationBuilder.UpdateData(
                table: "Book",
                keyColumn: "BookId",
                keyValue: 1999,
                columns: new[] { "CreatedDateTime", "PublicationDate" },
                values: new object[] { new DateTime(2024, 8, 16, 14, 36, 27, 279, DateTimeKind.Utc).AddTicks(1760), new DateTime(2024, 6, 25, 12, 34, 50, 324, DateTimeKind.Local).AddTicks(2245) });

            migrationBuilder.UpdateData(
                table: "Book",
                keyColumn: "BookId",
                keyValue: 2000,
                columns: new[] { "CreatedDateTime", "PublicationDate" },
                values: new object[] { new DateTime(2024, 8, 16, 14, 36, 27, 279, DateTimeKind.Utc).AddTicks(1859), new DateTime(2023, 8, 28, 16, 19, 17, 753, DateTimeKind.Local).AddTicks(2674) });
        }
    }
}
