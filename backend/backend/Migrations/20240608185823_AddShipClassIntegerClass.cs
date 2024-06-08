using Microsoft.EntityFrameworkCore.Migrations;
using Npgsql.EntityFrameworkCore.PostgreSQL.Metadata;

#nullable disable

namespace backend.Migrations
{
    /// <inheritdoc />
    public partial class AddShipClassIntegerClass : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "IntegerIceClass",
                columns: table => new
                {
                    Id = table.Column<int>(type: "integer", nullable: false)
                        .Annotation("Npgsql:ValueGenerationStrategy", NpgsqlValueGenerationStrategy.IdentityByDefaultColumn),
                    MinSpeed = table.Column<int>(type: "integer", nullable: false),
                    MaxSpeed = table.Column<int>(type: "integer", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_IntegerIceClass", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "ShipClassIntegerClass",
                columns: table => new
                {
                    Id = table.Column<int>(type: "integer", nullable: false)
                        .Annotation("Npgsql:ValueGenerationStrategy", NpgsqlValueGenerationStrategy.IdentityByDefaultColumn),
                    ShipClassId = table.Column<int>(type: "integer", nullable: false),
                    IntegerIceClassId = table.Column<int>(type: "integer", nullable: false),
                    Debuff = table.Column<bool>(type: "boolean", nullable: false),
                    IsCanMove = table.Column<bool>(type: "boolean", nullable: false),
                    DebuffValue = table.Column<double>(type: "double precision", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_ShipClassIntegerClass", x => x.Id);
                    table.ForeignKey(
                        name: "FK_ShipClassIntegerClass_IntegerIceClass_IntegerIceClassId",
                        column: x => x.IntegerIceClassId,
                        principalTable: "IntegerIceClass",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_ShipClassIntegerClass_ShipClass_ShipClassId",
                        column: x => x.ShipClassId,
                        principalTable: "ShipClass",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateIndex(
                name: "IX_ShipClassIntegerClass_IntegerIceClassId",
                table: "ShipClassIntegerClass",
                column: "IntegerIceClassId");

            migrationBuilder.CreateIndex(
                name: "IX_ShipClassIntegerClass_ShipClassId",
                table: "ShipClassIntegerClass",
                column: "ShipClassId");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "ShipClassIntegerClass");

            migrationBuilder.DropTable(
                name: "IntegerIceClass");
        }
    }
}
