using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace Veterinary.Backend.Infrastructure.Persistence.Migrations
{
    /// <inheritdoc />
    public partial class OwnerAdded : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "owners",
                columns: table => new
                {
                    id = table.Column<Guid>(type: "VARCHAR", maxLength: 36, nullable: false),
                    date_added_to_system = table.Column<DateTime>(type: "DATETIME", nullable: false),
                    email_address = table.Column<string>(type: "VARCHAR", maxLength: 250, nullable: false),
                    name = table.Column<string>(type: "VARCHAR", maxLength: 250, nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_owners", x => x.id);
                });
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "owners");
        }
    }
}
