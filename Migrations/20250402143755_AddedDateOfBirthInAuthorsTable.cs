﻿using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace MigrationDemo.Migrations
{
    /// <inheritdoc />
    public partial class AddedDateOfBirthInAuthorsTable : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<DateOnly>(
                name: "DateOfBirth",
                table: "Authors",
                type: "date",
                nullable: true);
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "DateOfBirth",
                table: "Authors");
        }
    }
}
