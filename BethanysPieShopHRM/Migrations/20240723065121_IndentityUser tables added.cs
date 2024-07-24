﻿using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace BethanysPieShopHRM.Migrations
{
    /// <inheritdoc />
    public partial class IndentityUsertablesadded : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AlterColumn<string>(
                name: "LastName",
                table: "Employees",
                type: "nvarchar(50)",
                maxLength: 50,
                nullable: false,
                oldClrType: typeof(string),
                oldType: "nvarchar(max)");

            migrationBuilder.AlterColumn<string>(
                name: "FirstName",
                table: "Employees",
                type: "nvarchar(50)",
                maxLength: 50,
                nullable: false,
                oldClrType: typeof(string),
                oldType: "nvarchar(max)");

            migrationBuilder.AlterColumn<string>(
                name: "Comment",
                table: "Employees",
                type: "nvarchar(1000)",
                maxLength: 1000,
                nullable: false,
                oldClrType: typeof(string),
                oldType: "nvarchar(max)");

            migrationBuilder.CreateTable(
                name: "AspNetRoles",
                columns: table => new
                {
                    Id = table.Column<string>(type: "nvarchar(450)", nullable: false),
                    Name = table.Column<string>(type: "nvarchar(256)", maxLength: 256, nullable: true),
                    NormalizedName = table.Column<string>(type: "nvarchar(256)", maxLength: 256, nullable: true),
                    ConcurrencyStamp = table.Column<string>(type: "nvarchar(max)", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_AspNetRoles", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "AspNetUsers",
                columns: table => new
                {
                    Id = table.Column<string>(type: "nvarchar(450)", nullable: false),
                    UserName = table.Column<string>(type: "nvarchar(256)", maxLength: 256, nullable: true),
                    NormalizedUserName = table.Column<string>(type: "nvarchar(256)", maxLength: 256, nullable: true),
                    Email = table.Column<string>(type: "nvarchar(256)", maxLength: 256, nullable: true),
                    NormalizedEmail = table.Column<string>(type: "nvarchar(256)", maxLength: 256, nullable: true),
                    EmailConfirmed = table.Column<bool>(type: "bit", nullable: false),
                    PasswordHash = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    SecurityStamp = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    ConcurrencyStamp = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    PhoneNumber = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    PhoneNumberConfirmed = table.Column<bool>(type: "bit", nullable: false),
                    TwoFactorEnabled = table.Column<bool>(type: "bit", nullable: false),
                    LockoutEnd = table.Column<DateTimeOffset>(type: "datetimeoffset", nullable: true),
                    LockoutEnabled = table.Column<bool>(type: "bit", nullable: false),
                    AccessFailedCount = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_AspNetUsers", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "AspNetRoleClaims",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    RoleId = table.Column<string>(type: "nvarchar(450)", nullable: false),
                    ClaimType = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    ClaimValue = table.Column<string>(type: "nvarchar(max)", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_AspNetRoleClaims", x => x.Id);
                    table.ForeignKey(
                        name: "FK_AspNetRoleClaims_AspNetRoles_RoleId",
                        column: x => x.RoleId,
                        principalTable: "AspNetRoles",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "AspNetUserClaims",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    UserId = table.Column<string>(type: "nvarchar(450)", nullable: false),
                    ClaimType = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    ClaimValue = table.Column<string>(type: "nvarchar(max)", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_AspNetUserClaims", x => x.Id);
                    table.ForeignKey(
                        name: "FK_AspNetUserClaims_AspNetUsers_UserId",
                        column: x => x.UserId,
                        principalTable: "AspNetUsers",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "AspNetUserLogins",
                columns: table => new
                {
                    LoginProvider = table.Column<string>(type: "nvarchar(450)", nullable: false),
                    ProviderKey = table.Column<string>(type: "nvarchar(450)", nullable: false),
                    ProviderDisplayName = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    UserId = table.Column<string>(type: "nvarchar(450)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_AspNetUserLogins", x => new { x.LoginProvider, x.ProviderKey });
                    table.ForeignKey(
                        name: "FK_AspNetUserLogins_AspNetUsers_UserId",
                        column: x => x.UserId,
                        principalTable: "AspNetUsers",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "AspNetUserRoles",
                columns: table => new
                {
                    UserId = table.Column<string>(type: "nvarchar(450)", nullable: false),
                    RoleId = table.Column<string>(type: "nvarchar(450)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_AspNetUserRoles", x => new { x.UserId, x.RoleId });
                    table.ForeignKey(
                        name: "FK_AspNetUserRoles_AspNetRoles_RoleId",
                        column: x => x.RoleId,
                        principalTable: "AspNetRoles",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_AspNetUserRoles_AspNetUsers_UserId",
                        column: x => x.UserId,
                        principalTable: "AspNetUsers",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "AspNetUserTokens",
                columns: table => new
                {
                    UserId = table.Column<string>(type: "nvarchar(450)", nullable: false),
                    LoginProvider = table.Column<string>(type: "nvarchar(450)", nullable: false),
                    Name = table.Column<string>(type: "nvarchar(450)", nullable: false),
                    Value = table.Column<string>(type: "nvarchar(max)", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_AspNetUserTokens", x => new { x.UserId, x.LoginProvider, x.Name });
                    table.ForeignKey(
                        name: "FK_AspNetUserTokens_AspNetUsers_UserId",
                        column: x => x.UserId,
                        principalTable: "AspNetUsers",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.UpdateData(
                table: "TimeRegistrations",
                keyColumn: "TimeRegistrationId",
                keyValue: 1,
                columns: new[] { "EndTime", "StartTime" },
                values: new object[] { new DateTime(2024, 2, 6, 15, 25, 16, 0, DateTimeKind.Unspecified), new DateTime(2024, 5, 5, 0, 30, 14, 0, DateTimeKind.Unspecified) });

            migrationBuilder.UpdateData(
                table: "TimeRegistrations",
                keyColumn: "TimeRegistrationId",
                keyValue: 2,
                columns: new[] { "EndTime", "StartTime" },
                values: new object[] { new DateTime(2024, 9, 28, 21, 53, 11, 0, DateTimeKind.Unspecified), new DateTime(2024, 1, 22, 23, 7, 47, 0, DateTimeKind.Unspecified) });

            migrationBuilder.UpdateData(
                table: "TimeRegistrations",
                keyColumn: "TimeRegistrationId",
                keyValue: 3,
                columns: new[] { "EndTime", "StartTime" },
                values: new object[] { new DateTime(2024, 12, 27, 19, 2, 4, 0, DateTimeKind.Unspecified), new DateTime(2024, 8, 7, 6, 41, 32, 0, DateTimeKind.Unspecified) });

            migrationBuilder.UpdateData(
                table: "TimeRegistrations",
                keyColumn: "TimeRegistrationId",
                keyValue: 4,
                columns: new[] { "EndTime", "StartTime" },
                values: new object[] { new DateTime(2024, 2, 26, 0, 33, 18, 0, DateTimeKind.Unspecified), new DateTime(2024, 9, 25, 3, 27, 33, 0, DateTimeKind.Unspecified) });

            migrationBuilder.UpdateData(
                table: "TimeRegistrations",
                keyColumn: "TimeRegistrationId",
                keyValue: 5,
                columns: new[] { "EndTime", "StartTime" },
                values: new object[] { new DateTime(2024, 9, 13, 23, 22, 2, 0, DateTimeKind.Unspecified), new DateTime(2024, 5, 19, 3, 14, 13, 0, DateTimeKind.Unspecified) });

            migrationBuilder.UpdateData(
                table: "TimeRegistrations",
                keyColumn: "TimeRegistrationId",
                keyValue: 6,
                columns: new[] { "EndTime", "StartTime" },
                values: new object[] { new DateTime(2024, 11, 21, 0, 30, 54, 0, DateTimeKind.Unspecified), new DateTime(2024, 2, 20, 19, 58, 20, 0, DateTimeKind.Unspecified) });

            migrationBuilder.UpdateData(
                table: "TimeRegistrations",
                keyColumn: "TimeRegistrationId",
                keyValue: 7,
                columns: new[] { "EndTime", "StartTime" },
                values: new object[] { new DateTime(2024, 8, 29, 16, 22, 13, 0, DateTimeKind.Unspecified), new DateTime(2024, 12, 4, 12, 3, 49, 0, DateTimeKind.Unspecified) });

            migrationBuilder.UpdateData(
                table: "TimeRegistrations",
                keyColumn: "TimeRegistrationId",
                keyValue: 8,
                columns: new[] { "EndTime", "StartTime" },
                values: new object[] { new DateTime(2024, 1, 11, 21, 16, 14, 0, DateTimeKind.Unspecified), new DateTime(2024, 10, 3, 15, 33, 20, 0, DateTimeKind.Unspecified) });

            migrationBuilder.UpdateData(
                table: "TimeRegistrations",
                keyColumn: "TimeRegistrationId",
                keyValue: 9,
                columns: new[] { "EndTime", "StartTime" },
                values: new object[] { new DateTime(2024, 3, 2, 15, 30, 58, 0, DateTimeKind.Unspecified), new DateTime(2024, 5, 20, 4, 21, 33, 0, DateTimeKind.Unspecified) });

            migrationBuilder.UpdateData(
                table: "TimeRegistrations",
                keyColumn: "TimeRegistrationId",
                keyValue: 10,
                columns: new[] { "EndTime", "StartTime" },
                values: new object[] { new DateTime(2024, 12, 1, 6, 20, 1, 0, DateTimeKind.Unspecified), new DateTime(2024, 12, 17, 9, 55, 41, 0, DateTimeKind.Unspecified) });

            migrationBuilder.UpdateData(
                table: "TimeRegistrations",
                keyColumn: "TimeRegistrationId",
                keyValue: 11,
                columns: new[] { "EndTime", "StartTime" },
                values: new object[] { new DateTime(2024, 4, 1, 15, 41, 40, 0, DateTimeKind.Unspecified), new DateTime(2024, 6, 17, 6, 55, 22, 0, DateTimeKind.Unspecified) });

            migrationBuilder.UpdateData(
                table: "TimeRegistrations",
                keyColumn: "TimeRegistrationId",
                keyValue: 12,
                columns: new[] { "EndTime", "StartTime" },
                values: new object[] { new DateTime(2024, 11, 23, 4, 50, 24, 0, DateTimeKind.Unspecified), new DateTime(2024, 6, 23, 17, 39, 11, 0, DateTimeKind.Unspecified) });

            migrationBuilder.UpdateData(
                table: "TimeRegistrations",
                keyColumn: "TimeRegistrationId",
                keyValue: 13,
                columns: new[] { "EndTime", "StartTime" },
                values: new object[] { new DateTime(2024, 5, 13, 16, 54, 14, 0, DateTimeKind.Unspecified), new DateTime(2024, 3, 21, 23, 50, 49, 0, DateTimeKind.Unspecified) });

            migrationBuilder.UpdateData(
                table: "TimeRegistrations",
                keyColumn: "TimeRegistrationId",
                keyValue: 14,
                columns: new[] { "EndTime", "StartTime" },
                values: new object[] { new DateTime(2024, 10, 22, 12, 43, 24, 0, DateTimeKind.Unspecified), new DateTime(2024, 11, 6, 7, 29, 48, 0, DateTimeKind.Unspecified) });

            migrationBuilder.UpdateData(
                table: "TimeRegistrations",
                keyColumn: "TimeRegistrationId",
                keyValue: 15,
                columns: new[] { "EndTime", "StartTime" },
                values: new object[] { new DateTime(2024, 2, 24, 21, 2, 49, 0, DateTimeKind.Unspecified), new DateTime(2024, 6, 12, 4, 51, 8, 0, DateTimeKind.Unspecified) });

            migrationBuilder.UpdateData(
                table: "TimeRegistrations",
                keyColumn: "TimeRegistrationId",
                keyValue: 16,
                columns: new[] { "EndTime", "StartTime" },
                values: new object[] { new DateTime(2024, 9, 21, 23, 42, 29, 0, DateTimeKind.Unspecified), new DateTime(2024, 1, 19, 10, 6, 43, 0, DateTimeKind.Unspecified) });

            migrationBuilder.UpdateData(
                table: "TimeRegistrations",
                keyColumn: "TimeRegistrationId",
                keyValue: 17,
                columns: new[] { "EndTime", "StartTime" },
                values: new object[] { new DateTime(2024, 5, 1, 8, 1, 1, 0, DateTimeKind.Unspecified), new DateTime(2024, 3, 22, 9, 19, 13, 0, DateTimeKind.Unspecified) });

            migrationBuilder.UpdateData(
                table: "TimeRegistrations",
                keyColumn: "TimeRegistrationId",
                keyValue: 18,
                columns: new[] { "EndTime", "StartTime" },
                values: new object[] { new DateTime(2024, 5, 31, 21, 3, 8, 0, DateTimeKind.Unspecified), new DateTime(2024, 5, 14, 9, 38, 12, 0, DateTimeKind.Unspecified) });

            migrationBuilder.UpdateData(
                table: "TimeRegistrations",
                keyColumn: "TimeRegistrationId",
                keyValue: 19,
                columns: new[] { "EndTime", "StartTime" },
                values: new object[] { new DateTime(2024, 3, 25, 9, 37, 1, 0, DateTimeKind.Unspecified), new DateTime(2024, 9, 26, 0, 16, 34, 0, DateTimeKind.Unspecified) });

            migrationBuilder.UpdateData(
                table: "TimeRegistrations",
                keyColumn: "TimeRegistrationId",
                keyValue: 20,
                columns: new[] { "EndTime", "StartTime" },
                values: new object[] { new DateTime(2024, 4, 18, 12, 59, 56, 0, DateTimeKind.Unspecified), new DateTime(2024, 9, 6, 3, 38, 42, 0, DateTimeKind.Unspecified) });

            migrationBuilder.UpdateData(
                table: "TimeRegistrations",
                keyColumn: "TimeRegistrationId",
                keyValue: 21,
                columns: new[] { "EndTime", "StartTime" },
                values: new object[] { new DateTime(2024, 12, 24, 18, 56, 11, 0, DateTimeKind.Unspecified), new DateTime(2024, 6, 10, 12, 9, 39, 0, DateTimeKind.Unspecified) });

            migrationBuilder.UpdateData(
                table: "TimeRegistrations",
                keyColumn: "TimeRegistrationId",
                keyValue: 22,
                columns: new[] { "EndTime", "StartTime" },
                values: new object[] { new DateTime(2024, 7, 30, 5, 28, 8, 0, DateTimeKind.Unspecified), new DateTime(2024, 7, 29, 13, 45, 32, 0, DateTimeKind.Unspecified) });

            migrationBuilder.UpdateData(
                table: "TimeRegistrations",
                keyColumn: "TimeRegistrationId",
                keyValue: 23,
                columns: new[] { "EndTime", "StartTime" },
                values: new object[] { new DateTime(2024, 8, 13, 23, 36, 15, 0, DateTimeKind.Unspecified), new DateTime(2024, 12, 20, 15, 39, 22, 0, DateTimeKind.Unspecified) });

            migrationBuilder.UpdateData(
                table: "TimeRegistrations",
                keyColumn: "TimeRegistrationId",
                keyValue: 24,
                columns: new[] { "EndTime", "StartTime" },
                values: new object[] { new DateTime(2024, 3, 15, 9, 46, 38, 0, DateTimeKind.Unspecified), new DateTime(2024, 4, 14, 23, 5, 56, 0, DateTimeKind.Unspecified) });

            migrationBuilder.UpdateData(
                table: "TimeRegistrations",
                keyColumn: "TimeRegistrationId",
                keyValue: 25,
                columns: new[] { "EndTime", "StartTime" },
                values: new object[] { new DateTime(2024, 4, 26, 11, 55, 58, 0, DateTimeKind.Unspecified), new DateTime(2024, 7, 25, 9, 36, 23, 0, DateTimeKind.Unspecified) });

            migrationBuilder.UpdateData(
                table: "TimeRegistrations",
                keyColumn: "TimeRegistrationId",
                keyValue: 26,
                columns: new[] { "EndTime", "StartTime" },
                values: new object[] { new DateTime(2024, 12, 14, 11, 39, 0, 0, DateTimeKind.Unspecified), new DateTime(2024, 6, 12, 10, 11, 32, 0, DateTimeKind.Unspecified) });

            migrationBuilder.UpdateData(
                table: "TimeRegistrations",
                keyColumn: "TimeRegistrationId",
                keyValue: 27,
                columns: new[] { "EndTime", "StartTime" },
                values: new object[] { new DateTime(2024, 9, 26, 23, 47, 34, 0, DateTimeKind.Unspecified), new DateTime(2024, 5, 6, 3, 47, 32, 0, DateTimeKind.Unspecified) });

            migrationBuilder.UpdateData(
                table: "TimeRegistrations",
                keyColumn: "TimeRegistrationId",
                keyValue: 28,
                columns: new[] { "EndTime", "StartTime" },
                values: new object[] { new DateTime(2024, 3, 7, 2, 17, 45, 0, DateTimeKind.Unspecified), new DateTime(2024, 4, 25, 7, 45, 13, 0, DateTimeKind.Unspecified) });

            migrationBuilder.UpdateData(
                table: "TimeRegistrations",
                keyColumn: "TimeRegistrationId",
                keyValue: 29,
                columns: new[] { "EndTime", "StartTime" },
                values: new object[] { new DateTime(2024, 12, 5, 4, 30, 1, 0, DateTimeKind.Unspecified), new DateTime(2024, 5, 29, 12, 33, 13, 0, DateTimeKind.Unspecified) });

            migrationBuilder.UpdateData(
                table: "TimeRegistrations",
                keyColumn: "TimeRegistrationId",
                keyValue: 30,
                columns: new[] { "EndTime", "StartTime" },
                values: new object[] { new DateTime(2024, 4, 18, 2, 28, 53, 0, DateTimeKind.Unspecified), new DateTime(2024, 1, 1, 8, 4, 59, 0, DateTimeKind.Unspecified) });

            migrationBuilder.UpdateData(
                table: "TimeRegistrations",
                keyColumn: "TimeRegistrationId",
                keyValue: 31,
                columns: new[] { "EndTime", "StartTime" },
                values: new object[] { new DateTime(2024, 5, 27, 4, 54, 16, 0, DateTimeKind.Unspecified), new DateTime(2024, 9, 15, 10, 57, 31, 0, DateTimeKind.Unspecified) });

            migrationBuilder.UpdateData(
                table: "TimeRegistrations",
                keyColumn: "TimeRegistrationId",
                keyValue: 32,
                columns: new[] { "EndTime", "StartTime" },
                values: new object[] { new DateTime(2024, 7, 7, 14, 20, 9, 0, DateTimeKind.Unspecified), new DateTime(2024, 10, 21, 13, 18, 40, 0, DateTimeKind.Unspecified) });

            migrationBuilder.UpdateData(
                table: "TimeRegistrations",
                keyColumn: "TimeRegistrationId",
                keyValue: 33,
                columns: new[] { "EndTime", "StartTime" },
                values: new object[] { new DateTime(2024, 10, 15, 19, 27, 19, 0, DateTimeKind.Unspecified), new DateTime(2024, 11, 12, 18, 44, 3, 0, DateTimeKind.Unspecified) });

            migrationBuilder.UpdateData(
                table: "TimeRegistrations",
                keyColumn: "TimeRegistrationId",
                keyValue: 34,
                columns: new[] { "EndTime", "StartTime" },
                values: new object[] { new DateTime(2024, 8, 14, 7, 11, 28, 0, DateTimeKind.Unspecified), new DateTime(2024, 10, 3, 6, 44, 17, 0, DateTimeKind.Unspecified) });

            migrationBuilder.UpdateData(
                table: "TimeRegistrations",
                keyColumn: "TimeRegistrationId",
                keyValue: 35,
                columns: new[] { "EndTime", "StartTime" },
                values: new object[] { new DateTime(2024, 7, 15, 14, 29, 33, 0, DateTimeKind.Unspecified), new DateTime(2024, 3, 30, 13, 24, 54, 0, DateTimeKind.Unspecified) });

            migrationBuilder.UpdateData(
                table: "TimeRegistrations",
                keyColumn: "TimeRegistrationId",
                keyValue: 36,
                columns: new[] { "EndTime", "StartTime" },
                values: new object[] { new DateTime(2024, 12, 22, 13, 12, 44, 0, DateTimeKind.Unspecified), new DateTime(2024, 5, 11, 6, 59, 11, 0, DateTimeKind.Unspecified) });

            migrationBuilder.UpdateData(
                table: "TimeRegistrations",
                keyColumn: "TimeRegistrationId",
                keyValue: 37,
                columns: new[] { "EndTime", "StartTime" },
                values: new object[] { new DateTime(2024, 11, 26, 11, 33, 45, 0, DateTimeKind.Unspecified), new DateTime(2024, 11, 23, 21, 8, 7, 0, DateTimeKind.Unspecified) });

            migrationBuilder.UpdateData(
                table: "TimeRegistrations",
                keyColumn: "TimeRegistrationId",
                keyValue: 38,
                columns: new[] { "EndTime", "StartTime" },
                values: new object[] { new DateTime(2024, 10, 23, 5, 42, 36, 0, DateTimeKind.Unspecified), new DateTime(2024, 8, 30, 5, 25, 24, 0, DateTimeKind.Unspecified) });

            migrationBuilder.UpdateData(
                table: "TimeRegistrations",
                keyColumn: "TimeRegistrationId",
                keyValue: 39,
                columns: new[] { "EndTime", "StartTime" },
                values: new object[] { new DateTime(2024, 12, 7, 6, 50, 15, 0, DateTimeKind.Unspecified), new DateTime(2024, 7, 8, 7, 55, 47, 0, DateTimeKind.Unspecified) });

            migrationBuilder.UpdateData(
                table: "TimeRegistrations",
                keyColumn: "TimeRegistrationId",
                keyValue: 40,
                columns: new[] { "EndTime", "StartTime" },
                values: new object[] { new DateTime(2024, 3, 23, 17, 22, 44, 0, DateTimeKind.Unspecified), new DateTime(2024, 11, 26, 0, 21, 24, 0, DateTimeKind.Unspecified) });

            migrationBuilder.UpdateData(
                table: "TimeRegistrations",
                keyColumn: "TimeRegistrationId",
                keyValue: 41,
                columns: new[] { "EndTime", "StartTime" },
                values: new object[] { new DateTime(2024, 8, 16, 3, 14, 34, 0, DateTimeKind.Unspecified), new DateTime(2024, 5, 8, 12, 59, 8, 0, DateTimeKind.Unspecified) });

            migrationBuilder.UpdateData(
                table: "TimeRegistrations",
                keyColumn: "TimeRegistrationId",
                keyValue: 42,
                columns: new[] { "EndTime", "StartTime" },
                values: new object[] { new DateTime(2024, 5, 8, 20, 23, 27, 0, DateTimeKind.Unspecified), new DateTime(2024, 4, 17, 11, 17, 58, 0, DateTimeKind.Unspecified) });

            migrationBuilder.UpdateData(
                table: "TimeRegistrations",
                keyColumn: "TimeRegistrationId",
                keyValue: 43,
                columns: new[] { "EndTime", "StartTime" },
                values: new object[] { new DateTime(2024, 10, 28, 23, 23, 25, 0, DateTimeKind.Unspecified), new DateTime(2024, 10, 10, 5, 49, 51, 0, DateTimeKind.Unspecified) });

            migrationBuilder.UpdateData(
                table: "TimeRegistrations",
                keyColumn: "TimeRegistrationId",
                keyValue: 44,
                columns: new[] { "EndTime", "StartTime" },
                values: new object[] { new DateTime(2024, 2, 6, 22, 15, 13, 0, DateTimeKind.Unspecified), new DateTime(2024, 9, 3, 20, 5, 56, 0, DateTimeKind.Unspecified) });

            migrationBuilder.UpdateData(
                table: "TimeRegistrations",
                keyColumn: "TimeRegistrationId",
                keyValue: 45,
                columns: new[] { "EndTime", "StartTime" },
                values: new object[] { new DateTime(2024, 2, 27, 18, 54, 40, 0, DateTimeKind.Unspecified), new DateTime(2024, 10, 31, 7, 2, 27, 0, DateTimeKind.Unspecified) });

            migrationBuilder.UpdateData(
                table: "TimeRegistrations",
                keyColumn: "TimeRegistrationId",
                keyValue: 46,
                columns: new[] { "EndTime", "StartTime" },
                values: new object[] { new DateTime(2024, 10, 31, 23, 32, 47, 0, DateTimeKind.Unspecified), new DateTime(2024, 2, 19, 23, 1, 17, 0, DateTimeKind.Unspecified) });

            migrationBuilder.UpdateData(
                table: "TimeRegistrations",
                keyColumn: "TimeRegistrationId",
                keyValue: 47,
                columns: new[] { "EndTime", "StartTime" },
                values: new object[] { new DateTime(2024, 2, 28, 4, 7, 11, 0, DateTimeKind.Unspecified), new DateTime(2024, 7, 12, 8, 57, 12, 0, DateTimeKind.Unspecified) });

            migrationBuilder.UpdateData(
                table: "TimeRegistrations",
                keyColumn: "TimeRegistrationId",
                keyValue: 48,
                columns: new[] { "EndTime", "StartTime" },
                values: new object[] { new DateTime(2024, 8, 10, 12, 31, 20, 0, DateTimeKind.Unspecified), new DateTime(2024, 4, 26, 10, 23, 17, 0, DateTimeKind.Unspecified) });

            migrationBuilder.UpdateData(
                table: "TimeRegistrations",
                keyColumn: "TimeRegistrationId",
                keyValue: 49,
                columns: new[] { "EndTime", "StartTime" },
                values: new object[] { new DateTime(2024, 11, 14, 7, 46, 7, 0, DateTimeKind.Unspecified), new DateTime(2024, 7, 8, 12, 25, 41, 0, DateTimeKind.Unspecified) });

            migrationBuilder.UpdateData(
                table: "TimeRegistrations",
                keyColumn: "TimeRegistrationId",
                keyValue: 50,
                columns: new[] { "EndTime", "StartTime" },
                values: new object[] { new DateTime(2024, 8, 18, 19, 21, 15, 0, DateTimeKind.Unspecified), new DateTime(2024, 10, 12, 14, 39, 14, 0, DateTimeKind.Unspecified) });

            migrationBuilder.UpdateData(
                table: "TimeRegistrations",
                keyColumn: "TimeRegistrationId",
                keyValue: 51,
                columns: new[] { "EndTime", "StartTime" },
                values: new object[] { new DateTime(2024, 7, 17, 21, 19, 43, 0, DateTimeKind.Unspecified), new DateTime(2024, 8, 15, 0, 42, 47, 0, DateTimeKind.Unspecified) });

            migrationBuilder.UpdateData(
                table: "TimeRegistrations",
                keyColumn: "TimeRegistrationId",
                keyValue: 52,
                columns: new[] { "EndTime", "StartTime" },
                values: new object[] { new DateTime(2024, 7, 28, 10, 21, 6, 0, DateTimeKind.Unspecified), new DateTime(2024, 3, 22, 9, 38, 0, 0, DateTimeKind.Unspecified) });

            migrationBuilder.UpdateData(
                table: "TimeRegistrations",
                keyColumn: "TimeRegistrationId",
                keyValue: 53,
                columns: new[] { "EndTime", "StartTime" },
                values: new object[] { new DateTime(2024, 7, 17, 0, 55, 30, 0, DateTimeKind.Unspecified), new DateTime(2024, 3, 11, 6, 8, 48, 0, DateTimeKind.Unspecified) });

            migrationBuilder.UpdateData(
                table: "TimeRegistrations",
                keyColumn: "TimeRegistrationId",
                keyValue: 54,
                columns: new[] { "EndTime", "StartTime" },
                values: new object[] { new DateTime(2024, 12, 11, 6, 42, 0, 0, DateTimeKind.Unspecified), new DateTime(2024, 7, 6, 20, 52, 0, 0, DateTimeKind.Unspecified) });

            migrationBuilder.UpdateData(
                table: "TimeRegistrations",
                keyColumn: "TimeRegistrationId",
                keyValue: 55,
                columns: new[] { "EndTime", "StartTime" },
                values: new object[] { new DateTime(2024, 4, 16, 8, 4, 44, 0, DateTimeKind.Unspecified), new DateTime(2024, 4, 6, 4, 51, 35, 0, DateTimeKind.Unspecified) });

            migrationBuilder.UpdateData(
                table: "TimeRegistrations",
                keyColumn: "TimeRegistrationId",
                keyValue: 56,
                columns: new[] { "EndTime", "StartTime" },
                values: new object[] { new DateTime(2024, 9, 6, 15, 54, 35, 0, DateTimeKind.Unspecified), new DateTime(2024, 5, 17, 0, 25, 9, 0, DateTimeKind.Unspecified) });

            migrationBuilder.UpdateData(
                table: "TimeRegistrations",
                keyColumn: "TimeRegistrationId",
                keyValue: 57,
                columns: new[] { "EndTime", "StartTime" },
                values: new object[] { new DateTime(2024, 9, 17, 18, 56, 27, 0, DateTimeKind.Unspecified), new DateTime(2024, 7, 6, 20, 46, 26, 0, DateTimeKind.Unspecified) });

            migrationBuilder.UpdateData(
                table: "TimeRegistrations",
                keyColumn: "TimeRegistrationId",
                keyValue: 58,
                columns: new[] { "EndTime", "StartTime" },
                values: new object[] { new DateTime(2024, 2, 28, 14, 37, 11, 0, DateTimeKind.Unspecified), new DateTime(2024, 2, 20, 9, 54, 17, 0, DateTimeKind.Unspecified) });

            migrationBuilder.UpdateData(
                table: "TimeRegistrations",
                keyColumn: "TimeRegistrationId",
                keyValue: 59,
                columns: new[] { "EndTime", "StartTime" },
                values: new object[] { new DateTime(2024, 4, 30, 14, 54, 29, 0, DateTimeKind.Unspecified), new DateTime(2024, 10, 5, 10, 7, 29, 0, DateTimeKind.Unspecified) });

            migrationBuilder.UpdateData(
                table: "TimeRegistrations",
                keyColumn: "TimeRegistrationId",
                keyValue: 60,
                columns: new[] { "EndTime", "StartTime" },
                values: new object[] { new DateTime(2024, 10, 15, 3, 22, 26, 0, DateTimeKind.Unspecified), new DateTime(2024, 8, 21, 18, 56, 10, 0, DateTimeKind.Unspecified) });

            migrationBuilder.UpdateData(
                table: "TimeRegistrations",
                keyColumn: "TimeRegistrationId",
                keyValue: 61,
                columns: new[] { "EndTime", "StartTime" },
                values: new object[] { new DateTime(2024, 5, 15, 15, 27, 56, 0, DateTimeKind.Unspecified), new DateTime(2024, 1, 15, 17, 24, 32, 0, DateTimeKind.Unspecified) });

            migrationBuilder.UpdateData(
                table: "TimeRegistrations",
                keyColumn: "TimeRegistrationId",
                keyValue: 62,
                columns: new[] { "EndTime", "StartTime" },
                values: new object[] { new DateTime(2024, 4, 28, 4, 16, 45, 0, DateTimeKind.Unspecified), new DateTime(2024, 10, 17, 23, 59, 46, 0, DateTimeKind.Unspecified) });

            migrationBuilder.UpdateData(
                table: "TimeRegistrations",
                keyColumn: "TimeRegistrationId",
                keyValue: 63,
                columns: new[] { "EndTime", "StartTime" },
                values: new object[] { new DateTime(2024, 7, 2, 15, 37, 16, 0, DateTimeKind.Unspecified), new DateTime(2024, 2, 3, 5, 38, 32, 0, DateTimeKind.Unspecified) });

            migrationBuilder.UpdateData(
                table: "TimeRegistrations",
                keyColumn: "TimeRegistrationId",
                keyValue: 64,
                columns: new[] { "EndTime", "StartTime" },
                values: new object[] { new DateTime(2024, 8, 28, 1, 8, 54, 0, DateTimeKind.Unspecified), new DateTime(2024, 1, 20, 2, 11, 31, 0, DateTimeKind.Unspecified) });

            migrationBuilder.UpdateData(
                table: "TimeRegistrations",
                keyColumn: "TimeRegistrationId",
                keyValue: 65,
                columns: new[] { "EndTime", "StartTime" },
                values: new object[] { new DateTime(2024, 3, 18, 18, 50, 6, 0, DateTimeKind.Unspecified), new DateTime(2024, 10, 20, 21, 53, 20, 0, DateTimeKind.Unspecified) });

            migrationBuilder.UpdateData(
                table: "TimeRegistrations",
                keyColumn: "TimeRegistrationId",
                keyValue: 66,
                columns: new[] { "EndTime", "StartTime" },
                values: new object[] { new DateTime(2024, 2, 13, 15, 27, 51, 0, DateTimeKind.Unspecified), new DateTime(2024, 11, 17, 2, 3, 34, 0, DateTimeKind.Unspecified) });

            migrationBuilder.UpdateData(
                table: "TimeRegistrations",
                keyColumn: "TimeRegistrationId",
                keyValue: 67,
                columns: new[] { "EndTime", "StartTime" },
                values: new object[] { new DateTime(2024, 9, 27, 7, 58, 31, 0, DateTimeKind.Unspecified), new DateTime(2024, 8, 7, 8, 11, 26, 0, DateTimeKind.Unspecified) });

            migrationBuilder.UpdateData(
                table: "TimeRegistrations",
                keyColumn: "TimeRegistrationId",
                keyValue: 68,
                columns: new[] { "EndTime", "StartTime" },
                values: new object[] { new DateTime(2024, 8, 29, 11, 14, 3, 0, DateTimeKind.Unspecified), new DateTime(2024, 3, 10, 12, 54, 15, 0, DateTimeKind.Unspecified) });

            migrationBuilder.UpdateData(
                table: "TimeRegistrations",
                keyColumn: "TimeRegistrationId",
                keyValue: 69,
                columns: new[] { "EndTime", "StartTime" },
                values: new object[] { new DateTime(2024, 12, 2, 9, 5, 33, 0, DateTimeKind.Unspecified), new DateTime(2024, 7, 30, 13, 38, 45, 0, DateTimeKind.Unspecified) });

            migrationBuilder.UpdateData(
                table: "TimeRegistrations",
                keyColumn: "TimeRegistrationId",
                keyValue: 70,
                columns: new[] { "EndTime", "StartTime" },
                values: new object[] { new DateTime(2024, 7, 14, 22, 16, 32, 0, DateTimeKind.Unspecified), new DateTime(2024, 8, 9, 1, 52, 40, 0, DateTimeKind.Unspecified) });

            migrationBuilder.UpdateData(
                table: "TimeRegistrations",
                keyColumn: "TimeRegistrationId",
                keyValue: 71,
                columns: new[] { "EndTime", "StartTime" },
                values: new object[] { new DateTime(2024, 4, 13, 1, 53, 41, 0, DateTimeKind.Unspecified), new DateTime(2024, 8, 27, 0, 0, 51, 0, DateTimeKind.Unspecified) });

            migrationBuilder.UpdateData(
                table: "TimeRegistrations",
                keyColumn: "TimeRegistrationId",
                keyValue: 72,
                columns: new[] { "EndTime", "StartTime" },
                values: new object[] { new DateTime(2024, 4, 2, 21, 36, 14, 0, DateTimeKind.Unspecified), new DateTime(2024, 3, 21, 8, 37, 5, 0, DateTimeKind.Unspecified) });

            migrationBuilder.UpdateData(
                table: "TimeRegistrations",
                keyColumn: "TimeRegistrationId",
                keyValue: 73,
                columns: new[] { "EndTime", "StartTime" },
                values: new object[] { new DateTime(2024, 8, 3, 10, 14, 41, 0, DateTimeKind.Unspecified), new DateTime(2024, 5, 11, 17, 6, 16, 0, DateTimeKind.Unspecified) });

            migrationBuilder.UpdateData(
                table: "TimeRegistrations",
                keyColumn: "TimeRegistrationId",
                keyValue: 74,
                columns: new[] { "EndTime", "StartTime" },
                values: new object[] { new DateTime(2024, 7, 6, 1, 25, 8, 0, DateTimeKind.Unspecified), new DateTime(2024, 1, 29, 5, 19, 25, 0, DateTimeKind.Unspecified) });

            migrationBuilder.UpdateData(
                table: "TimeRegistrations",
                keyColumn: "TimeRegistrationId",
                keyValue: 75,
                columns: new[] { "EndTime", "StartTime" },
                values: new object[] { new DateTime(2024, 8, 28, 6, 17, 43, 0, DateTimeKind.Unspecified), new DateTime(2024, 6, 15, 17, 54, 55, 0, DateTimeKind.Unspecified) });

            migrationBuilder.UpdateData(
                table: "TimeRegistrations",
                keyColumn: "TimeRegistrationId",
                keyValue: 76,
                columns: new[] { "EndTime", "StartTime" },
                values: new object[] { new DateTime(2024, 5, 14, 1, 10, 46, 0, DateTimeKind.Unspecified), new DateTime(2024, 8, 10, 4, 24, 31, 0, DateTimeKind.Unspecified) });

            migrationBuilder.UpdateData(
                table: "TimeRegistrations",
                keyColumn: "TimeRegistrationId",
                keyValue: 77,
                columns: new[] { "EndTime", "StartTime" },
                values: new object[] { new DateTime(2024, 8, 27, 20, 45, 32, 0, DateTimeKind.Unspecified), new DateTime(2024, 2, 4, 1, 56, 14, 0, DateTimeKind.Unspecified) });

            migrationBuilder.UpdateData(
                table: "TimeRegistrations",
                keyColumn: "TimeRegistrationId",
                keyValue: 78,
                columns: new[] { "EndTime", "StartTime" },
                values: new object[] { new DateTime(2024, 12, 14, 18, 20, 49, 0, DateTimeKind.Unspecified), new DateTime(2024, 10, 17, 13, 55, 46, 0, DateTimeKind.Unspecified) });

            migrationBuilder.UpdateData(
                table: "TimeRegistrations",
                keyColumn: "TimeRegistrationId",
                keyValue: 79,
                columns: new[] { "EndTime", "StartTime" },
                values: new object[] { new DateTime(2024, 8, 31, 7, 20, 58, 0, DateTimeKind.Unspecified), new DateTime(2024, 2, 10, 20, 3, 34, 0, DateTimeKind.Unspecified) });

            migrationBuilder.UpdateData(
                table: "TimeRegistrations",
                keyColumn: "TimeRegistrationId",
                keyValue: 80,
                columns: new[] { "EndTime", "StartTime" },
                values: new object[] { new DateTime(2024, 8, 28, 8, 59, 38, 0, DateTimeKind.Unspecified), new DateTime(2024, 2, 27, 10, 32, 4, 0, DateTimeKind.Unspecified) });

            migrationBuilder.UpdateData(
                table: "TimeRegistrations",
                keyColumn: "TimeRegistrationId",
                keyValue: 81,
                columns: new[] { "EndTime", "StartTime" },
                values: new object[] { new DateTime(2024, 10, 18, 3, 11, 52, 0, DateTimeKind.Unspecified), new DateTime(2024, 12, 29, 5, 17, 2, 0, DateTimeKind.Unspecified) });

            migrationBuilder.UpdateData(
                table: "TimeRegistrations",
                keyColumn: "TimeRegistrationId",
                keyValue: 82,
                columns: new[] { "EndTime", "StartTime" },
                values: new object[] { new DateTime(2024, 2, 14, 12, 17, 55, 0, DateTimeKind.Unspecified), new DateTime(2024, 10, 10, 5, 34, 37, 0, DateTimeKind.Unspecified) });

            migrationBuilder.UpdateData(
                table: "TimeRegistrations",
                keyColumn: "TimeRegistrationId",
                keyValue: 83,
                columns: new[] { "EndTime", "StartTime" },
                values: new object[] { new DateTime(2024, 9, 10, 1, 30, 25, 0, DateTimeKind.Unspecified), new DateTime(2024, 8, 25, 18, 7, 4, 0, DateTimeKind.Unspecified) });

            migrationBuilder.UpdateData(
                table: "TimeRegistrations",
                keyColumn: "TimeRegistrationId",
                keyValue: 84,
                columns: new[] { "EndTime", "StartTime" },
                values: new object[] { new DateTime(2024, 12, 30, 18, 16, 47, 0, DateTimeKind.Unspecified), new DateTime(2024, 6, 14, 17, 49, 23, 0, DateTimeKind.Unspecified) });

            migrationBuilder.UpdateData(
                table: "TimeRegistrations",
                keyColumn: "TimeRegistrationId",
                keyValue: 85,
                columns: new[] { "EndTime", "StartTime" },
                values: new object[] { new DateTime(2024, 12, 15, 11, 5, 48, 0, DateTimeKind.Unspecified), new DateTime(2024, 1, 31, 4, 40, 19, 0, DateTimeKind.Unspecified) });

            migrationBuilder.UpdateData(
                table: "TimeRegistrations",
                keyColumn: "TimeRegistrationId",
                keyValue: 86,
                columns: new[] { "EndTime", "StartTime" },
                values: new object[] { new DateTime(2024, 11, 25, 16, 7, 53, 0, DateTimeKind.Unspecified), new DateTime(2024, 11, 21, 13, 33, 50, 0, DateTimeKind.Unspecified) });

            migrationBuilder.UpdateData(
                table: "TimeRegistrations",
                keyColumn: "TimeRegistrationId",
                keyValue: 87,
                columns: new[] { "EndTime", "StartTime" },
                values: new object[] { new DateTime(2024, 2, 12, 20, 28, 13, 0, DateTimeKind.Unspecified), new DateTime(2024, 10, 20, 2, 7, 36, 0, DateTimeKind.Unspecified) });

            migrationBuilder.UpdateData(
                table: "TimeRegistrations",
                keyColumn: "TimeRegistrationId",
                keyValue: 88,
                columns: new[] { "EndTime", "StartTime" },
                values: new object[] { new DateTime(2024, 12, 25, 6, 49, 48, 0, DateTimeKind.Unspecified), new DateTime(2024, 11, 28, 20, 1, 39, 0, DateTimeKind.Unspecified) });

            migrationBuilder.UpdateData(
                table: "TimeRegistrations",
                keyColumn: "TimeRegistrationId",
                keyValue: 89,
                columns: new[] { "EndTime", "StartTime" },
                values: new object[] { new DateTime(2024, 3, 7, 7, 57, 37, 0, DateTimeKind.Unspecified), new DateTime(2024, 6, 1, 14, 52, 47, 0, DateTimeKind.Unspecified) });

            migrationBuilder.UpdateData(
                table: "TimeRegistrations",
                keyColumn: "TimeRegistrationId",
                keyValue: 90,
                columns: new[] { "EndTime", "StartTime" },
                values: new object[] { new DateTime(2024, 6, 26, 12, 33, 38, 0, DateTimeKind.Unspecified), new DateTime(2024, 12, 12, 7, 57, 5, 0, DateTimeKind.Unspecified) });

            migrationBuilder.UpdateData(
                table: "TimeRegistrations",
                keyColumn: "TimeRegistrationId",
                keyValue: 91,
                columns: new[] { "EndTime", "StartTime" },
                values: new object[] { new DateTime(2024, 12, 7, 3, 49, 7, 0, DateTimeKind.Unspecified), new DateTime(2024, 1, 30, 1, 53, 56, 0, DateTimeKind.Unspecified) });

            migrationBuilder.UpdateData(
                table: "TimeRegistrations",
                keyColumn: "TimeRegistrationId",
                keyValue: 92,
                columns: new[] { "EndTime", "StartTime" },
                values: new object[] { new DateTime(2024, 4, 15, 22, 40, 6, 0, DateTimeKind.Unspecified), new DateTime(2024, 1, 11, 16, 49, 38, 0, DateTimeKind.Unspecified) });

            migrationBuilder.UpdateData(
                table: "TimeRegistrations",
                keyColumn: "TimeRegistrationId",
                keyValue: 93,
                columns: new[] { "EndTime", "StartTime" },
                values: new object[] { new DateTime(2024, 9, 1, 6, 48, 57, 0, DateTimeKind.Unspecified), new DateTime(2024, 7, 23, 23, 14, 55, 0, DateTimeKind.Unspecified) });

            migrationBuilder.UpdateData(
                table: "TimeRegistrations",
                keyColumn: "TimeRegistrationId",
                keyValue: 94,
                columns: new[] { "EndTime", "StartTime" },
                values: new object[] { new DateTime(2024, 7, 14, 22, 49, 19, 0, DateTimeKind.Unspecified), new DateTime(2024, 9, 1, 1, 39, 17, 0, DateTimeKind.Unspecified) });

            migrationBuilder.UpdateData(
                table: "TimeRegistrations",
                keyColumn: "TimeRegistrationId",
                keyValue: 95,
                columns: new[] { "EndTime", "StartTime" },
                values: new object[] { new DateTime(2024, 2, 2, 6, 44, 42, 0, DateTimeKind.Unspecified), new DateTime(2024, 9, 26, 1, 4, 19, 0, DateTimeKind.Unspecified) });

            migrationBuilder.UpdateData(
                table: "TimeRegistrations",
                keyColumn: "TimeRegistrationId",
                keyValue: 96,
                columns: new[] { "EndTime", "StartTime" },
                values: new object[] { new DateTime(2024, 5, 16, 4, 22, 13, 0, DateTimeKind.Unspecified), new DateTime(2024, 3, 2, 3, 52, 39, 0, DateTimeKind.Unspecified) });

            migrationBuilder.UpdateData(
                table: "TimeRegistrations",
                keyColumn: "TimeRegistrationId",
                keyValue: 97,
                columns: new[] { "EndTime", "StartTime" },
                values: new object[] { new DateTime(2024, 1, 26, 21, 31, 54, 0, DateTimeKind.Unspecified), new DateTime(2024, 2, 8, 15, 48, 31, 0, DateTimeKind.Unspecified) });

            migrationBuilder.UpdateData(
                table: "TimeRegistrations",
                keyColumn: "TimeRegistrationId",
                keyValue: 98,
                columns: new[] { "EndTime", "StartTime" },
                values: new object[] { new DateTime(2024, 3, 13, 3, 42, 52, 0, DateTimeKind.Unspecified), new DateTime(2024, 6, 11, 18, 6, 20, 0, DateTimeKind.Unspecified) });

            migrationBuilder.UpdateData(
                table: "TimeRegistrations",
                keyColumn: "TimeRegistrationId",
                keyValue: 99,
                columns: new[] { "EndTime", "StartTime" },
                values: new object[] { new DateTime(2024, 12, 9, 11, 24, 42, 0, DateTimeKind.Unspecified), new DateTime(2024, 8, 4, 17, 20, 43, 0, DateTimeKind.Unspecified) });

            migrationBuilder.UpdateData(
                table: "TimeRegistrations",
                keyColumn: "TimeRegistrationId",
                keyValue: 100,
                columns: new[] { "EndTime", "StartTime" },
                values: new object[] { new DateTime(2024, 12, 22, 5, 16, 24, 0, DateTimeKind.Unspecified), new DateTime(2024, 10, 21, 6, 54, 22, 0, DateTimeKind.Unspecified) });

            migrationBuilder.UpdateData(
                table: "TimeRegistrations",
                keyColumn: "TimeRegistrationId",
                keyValue: 101,
                columns: new[] { "EndTime", "StartTime" },
                values: new object[] { new DateTime(2024, 10, 10, 23, 3, 1, 0, DateTimeKind.Unspecified), new DateTime(2024, 3, 17, 15, 57, 52, 0, DateTimeKind.Unspecified) });

            migrationBuilder.UpdateData(
                table: "TimeRegistrations",
                keyColumn: "TimeRegistrationId",
                keyValue: 102,
                columns: new[] { "EndTime", "StartTime" },
                values: new object[] { new DateTime(2024, 7, 10, 3, 33, 31, 0, DateTimeKind.Unspecified), new DateTime(2024, 9, 14, 19, 35, 3, 0, DateTimeKind.Unspecified) });

            migrationBuilder.UpdateData(
                table: "TimeRegistrations",
                keyColumn: "TimeRegistrationId",
                keyValue: 103,
                columns: new[] { "EndTime", "StartTime" },
                values: new object[] { new DateTime(2024, 10, 31, 18, 14, 58, 0, DateTimeKind.Unspecified), new DateTime(2024, 10, 16, 4, 19, 7, 0, DateTimeKind.Unspecified) });

            migrationBuilder.UpdateData(
                table: "TimeRegistrations",
                keyColumn: "TimeRegistrationId",
                keyValue: 104,
                columns: new[] { "EndTime", "StartTime" },
                values: new object[] { new DateTime(2024, 2, 10, 0, 24, 19, 0, DateTimeKind.Unspecified), new DateTime(2024, 12, 26, 14, 39, 1, 0, DateTimeKind.Unspecified) });

            migrationBuilder.UpdateData(
                table: "TimeRegistrations",
                keyColumn: "TimeRegistrationId",
                keyValue: 105,
                columns: new[] { "EndTime", "StartTime" },
                values: new object[] { new DateTime(2024, 9, 27, 8, 24, 1, 0, DateTimeKind.Unspecified), new DateTime(2024, 8, 6, 19, 53, 33, 0, DateTimeKind.Unspecified) });

            migrationBuilder.UpdateData(
                table: "TimeRegistrations",
                keyColumn: "TimeRegistrationId",
                keyValue: 106,
                columns: new[] { "EndTime", "StartTime" },
                values: new object[] { new DateTime(2024, 2, 8, 19, 24, 46, 0, DateTimeKind.Unspecified), new DateTime(2024, 3, 3, 4, 47, 43, 0, DateTimeKind.Unspecified) });

            migrationBuilder.UpdateData(
                table: "TimeRegistrations",
                keyColumn: "TimeRegistrationId",
                keyValue: 107,
                columns: new[] { "EndTime", "StartTime" },
                values: new object[] { new DateTime(2024, 6, 13, 11, 29, 17, 0, DateTimeKind.Unspecified), new DateTime(2024, 9, 7, 23, 43, 34, 0, DateTimeKind.Unspecified) });

            migrationBuilder.UpdateData(
                table: "TimeRegistrations",
                keyColumn: "TimeRegistrationId",
                keyValue: 108,
                columns: new[] { "EndTime", "StartTime" },
                values: new object[] { new DateTime(2024, 9, 29, 1, 27, 50, 0, DateTimeKind.Unspecified), new DateTime(2024, 2, 7, 13, 20, 14, 0, DateTimeKind.Unspecified) });

            migrationBuilder.UpdateData(
                table: "TimeRegistrations",
                keyColumn: "TimeRegistrationId",
                keyValue: 109,
                columns: new[] { "EndTime", "StartTime" },
                values: new object[] { new DateTime(2024, 12, 8, 9, 26, 58, 0, DateTimeKind.Unspecified), new DateTime(2024, 6, 29, 8, 30, 35, 0, DateTimeKind.Unspecified) });

            migrationBuilder.UpdateData(
                table: "TimeRegistrations",
                keyColumn: "TimeRegistrationId",
                keyValue: 110,
                columns: new[] { "EndTime", "StartTime" },
                values: new object[] { new DateTime(2024, 3, 7, 3, 36, 27, 0, DateTimeKind.Unspecified), new DateTime(2024, 2, 23, 2, 32, 33, 0, DateTimeKind.Unspecified) });

            migrationBuilder.UpdateData(
                table: "TimeRegistrations",
                keyColumn: "TimeRegistrationId",
                keyValue: 111,
                columns: new[] { "EndTime", "StartTime" },
                values: new object[] { new DateTime(2024, 3, 20, 13, 55, 48, 0, DateTimeKind.Unspecified), new DateTime(2024, 1, 13, 22, 34, 6, 0, DateTimeKind.Unspecified) });

            migrationBuilder.UpdateData(
                table: "TimeRegistrations",
                keyColumn: "TimeRegistrationId",
                keyValue: 112,
                columns: new[] { "EndTime", "StartTime" },
                values: new object[] { new DateTime(2024, 4, 16, 17, 36, 46, 0, DateTimeKind.Unspecified), new DateTime(2024, 1, 31, 9, 39, 56, 0, DateTimeKind.Unspecified) });

            migrationBuilder.UpdateData(
                table: "TimeRegistrations",
                keyColumn: "TimeRegistrationId",
                keyValue: 113,
                columns: new[] { "EndTime", "StartTime" },
                values: new object[] { new DateTime(2024, 9, 1, 16, 33, 17, 0, DateTimeKind.Unspecified), new DateTime(2024, 7, 22, 1, 58, 34, 0, DateTimeKind.Unspecified) });

            migrationBuilder.UpdateData(
                table: "TimeRegistrations",
                keyColumn: "TimeRegistrationId",
                keyValue: 114,
                columns: new[] { "EndTime", "StartTime" },
                values: new object[] { new DateTime(2024, 12, 24, 23, 11, 45, 0, DateTimeKind.Unspecified), new DateTime(2024, 4, 29, 19, 28, 16, 0, DateTimeKind.Unspecified) });

            migrationBuilder.UpdateData(
                table: "TimeRegistrations",
                keyColumn: "TimeRegistrationId",
                keyValue: 115,
                columns: new[] { "EndTime", "StartTime" },
                values: new object[] { new DateTime(2024, 6, 22, 0, 21, 30, 0, DateTimeKind.Unspecified), new DateTime(2024, 10, 15, 8, 29, 15, 0, DateTimeKind.Unspecified) });

            migrationBuilder.UpdateData(
                table: "TimeRegistrations",
                keyColumn: "TimeRegistrationId",
                keyValue: 116,
                columns: new[] { "EndTime", "StartTime" },
                values: new object[] { new DateTime(2024, 11, 4, 4, 52, 38, 0, DateTimeKind.Unspecified), new DateTime(2024, 12, 22, 3, 4, 30, 0, DateTimeKind.Unspecified) });

            migrationBuilder.UpdateData(
                table: "TimeRegistrations",
                keyColumn: "TimeRegistrationId",
                keyValue: 117,
                columns: new[] { "EndTime", "StartTime" },
                values: new object[] { new DateTime(2024, 11, 5, 20, 56, 53, 0, DateTimeKind.Unspecified), new DateTime(2024, 1, 10, 1, 29, 11, 0, DateTimeKind.Unspecified) });

            migrationBuilder.UpdateData(
                table: "TimeRegistrations",
                keyColumn: "TimeRegistrationId",
                keyValue: 118,
                columns: new[] { "EndTime", "StartTime" },
                values: new object[] { new DateTime(2024, 9, 20, 20, 13, 22, 0, DateTimeKind.Unspecified), new DateTime(2024, 11, 8, 21, 49, 29, 0, DateTimeKind.Unspecified) });

            migrationBuilder.UpdateData(
                table: "TimeRegistrations",
                keyColumn: "TimeRegistrationId",
                keyValue: 119,
                columns: new[] { "EndTime", "StartTime" },
                values: new object[] { new DateTime(2024, 10, 18, 23, 39, 24, 0, DateTimeKind.Unspecified), new DateTime(2024, 12, 17, 3, 41, 58, 0, DateTimeKind.Unspecified) });

            migrationBuilder.UpdateData(
                table: "TimeRegistrations",
                keyColumn: "TimeRegistrationId",
                keyValue: 120,
                columns: new[] { "EndTime", "StartTime" },
                values: new object[] { new DateTime(2024, 10, 5, 20, 21, 54, 0, DateTimeKind.Unspecified), new DateTime(2024, 2, 18, 20, 35, 43, 0, DateTimeKind.Unspecified) });

            migrationBuilder.UpdateData(
                table: "TimeRegistrations",
                keyColumn: "TimeRegistrationId",
                keyValue: 121,
                columns: new[] { "EndTime", "StartTime" },
                values: new object[] { new DateTime(2024, 4, 21, 23, 12, 56, 0, DateTimeKind.Unspecified), new DateTime(2024, 5, 10, 17, 45, 4, 0, DateTimeKind.Unspecified) });

            migrationBuilder.UpdateData(
                table: "TimeRegistrations",
                keyColumn: "TimeRegistrationId",
                keyValue: 122,
                columns: new[] { "EndTime", "StartTime" },
                values: new object[] { new DateTime(2024, 6, 17, 23, 1, 59, 0, DateTimeKind.Unspecified), new DateTime(2024, 2, 14, 13, 56, 39, 0, DateTimeKind.Unspecified) });

            migrationBuilder.UpdateData(
                table: "TimeRegistrations",
                keyColumn: "TimeRegistrationId",
                keyValue: 123,
                columns: new[] { "EndTime", "StartTime" },
                values: new object[] { new DateTime(2024, 10, 18, 13, 52, 21, 0, DateTimeKind.Unspecified), new DateTime(2024, 3, 28, 10, 54, 0, 0, DateTimeKind.Unspecified) });

            migrationBuilder.UpdateData(
                table: "TimeRegistrations",
                keyColumn: "TimeRegistrationId",
                keyValue: 124,
                columns: new[] { "EndTime", "StartTime" },
                values: new object[] { new DateTime(2024, 1, 21, 10, 13, 8, 0, DateTimeKind.Unspecified), new DateTime(2024, 1, 29, 2, 34, 1, 0, DateTimeKind.Unspecified) });

            migrationBuilder.UpdateData(
                table: "TimeRegistrations",
                keyColumn: "TimeRegistrationId",
                keyValue: 125,
                columns: new[] { "EndTime", "StartTime" },
                values: new object[] { new DateTime(2024, 4, 3, 5, 39, 14, 0, DateTimeKind.Unspecified), new DateTime(2024, 1, 22, 8, 36, 48, 0, DateTimeKind.Unspecified) });

            migrationBuilder.UpdateData(
                table: "TimeRegistrations",
                keyColumn: "TimeRegistrationId",
                keyValue: 126,
                columns: new[] { "EndTime", "StartTime" },
                values: new object[] { new DateTime(2024, 4, 29, 7, 34, 24, 0, DateTimeKind.Unspecified), new DateTime(2024, 11, 2, 11, 28, 7, 0, DateTimeKind.Unspecified) });

            migrationBuilder.UpdateData(
                table: "TimeRegistrations",
                keyColumn: "TimeRegistrationId",
                keyValue: 127,
                columns: new[] { "EndTime", "StartTime" },
                values: new object[] { new DateTime(2024, 8, 11, 17, 33, 7, 0, DateTimeKind.Unspecified), new DateTime(2024, 5, 28, 0, 54, 28, 0, DateTimeKind.Unspecified) });

            migrationBuilder.UpdateData(
                table: "TimeRegistrations",
                keyColumn: "TimeRegistrationId",
                keyValue: 128,
                columns: new[] { "EndTime", "StartTime" },
                values: new object[] { new DateTime(2024, 8, 21, 21, 52, 59, 0, DateTimeKind.Unspecified), new DateTime(2024, 9, 6, 0, 55, 6, 0, DateTimeKind.Unspecified) });

            migrationBuilder.UpdateData(
                table: "TimeRegistrations",
                keyColumn: "TimeRegistrationId",
                keyValue: 129,
                columns: new[] { "EndTime", "StartTime" },
                values: new object[] { new DateTime(2024, 3, 4, 22, 42, 30, 0, DateTimeKind.Unspecified), new DateTime(2024, 6, 29, 19, 4, 40, 0, DateTimeKind.Unspecified) });

            migrationBuilder.UpdateData(
                table: "TimeRegistrations",
                keyColumn: "TimeRegistrationId",
                keyValue: 130,
                columns: new[] { "EndTime", "StartTime" },
                values: new object[] { new DateTime(2024, 9, 8, 22, 0, 25, 0, DateTimeKind.Unspecified), new DateTime(2024, 3, 19, 1, 32, 49, 0, DateTimeKind.Unspecified) });

            migrationBuilder.UpdateData(
                table: "TimeRegistrations",
                keyColumn: "TimeRegistrationId",
                keyValue: 131,
                columns: new[] { "EndTime", "StartTime" },
                values: new object[] { new DateTime(2024, 4, 30, 1, 58, 59, 0, DateTimeKind.Unspecified), new DateTime(2024, 10, 15, 16, 31, 48, 0, DateTimeKind.Unspecified) });

            migrationBuilder.UpdateData(
                table: "TimeRegistrations",
                keyColumn: "TimeRegistrationId",
                keyValue: 132,
                columns: new[] { "EndTime", "StartTime" },
                values: new object[] { new DateTime(2024, 11, 26, 17, 14, 13, 0, DateTimeKind.Unspecified), new DateTime(2024, 2, 10, 10, 45, 59, 0, DateTimeKind.Unspecified) });

            migrationBuilder.UpdateData(
                table: "TimeRegistrations",
                keyColumn: "TimeRegistrationId",
                keyValue: 133,
                columns: new[] { "EndTime", "StartTime" },
                values: new object[] { new DateTime(2024, 10, 31, 21, 32, 33, 0, DateTimeKind.Unspecified), new DateTime(2024, 1, 28, 13, 17, 25, 0, DateTimeKind.Unspecified) });

            migrationBuilder.UpdateData(
                table: "TimeRegistrations",
                keyColumn: "TimeRegistrationId",
                keyValue: 134,
                columns: new[] { "EndTime", "StartTime" },
                values: new object[] { new DateTime(2024, 11, 10, 2, 16, 34, 0, DateTimeKind.Unspecified), new DateTime(2024, 5, 10, 21, 32, 8, 0, DateTimeKind.Unspecified) });

            migrationBuilder.UpdateData(
                table: "TimeRegistrations",
                keyColumn: "TimeRegistrationId",
                keyValue: 135,
                columns: new[] { "EndTime", "StartTime" },
                values: new object[] { new DateTime(2024, 2, 2, 7, 46, 10, 0, DateTimeKind.Unspecified), new DateTime(2024, 1, 5, 14, 46, 19, 0, DateTimeKind.Unspecified) });

            migrationBuilder.UpdateData(
                table: "TimeRegistrations",
                keyColumn: "TimeRegistrationId",
                keyValue: 136,
                columns: new[] { "EndTime", "StartTime" },
                values: new object[] { new DateTime(2024, 11, 30, 21, 8, 40, 0, DateTimeKind.Unspecified), new DateTime(2024, 1, 12, 18, 22, 21, 0, DateTimeKind.Unspecified) });

            migrationBuilder.UpdateData(
                table: "TimeRegistrations",
                keyColumn: "TimeRegistrationId",
                keyValue: 137,
                columns: new[] { "EndTime", "StartTime" },
                values: new object[] { new DateTime(2024, 11, 19, 11, 29, 34, 0, DateTimeKind.Unspecified), new DateTime(2024, 10, 8, 8, 5, 50, 0, DateTimeKind.Unspecified) });

            migrationBuilder.UpdateData(
                table: "TimeRegistrations",
                keyColumn: "TimeRegistrationId",
                keyValue: 138,
                columns: new[] { "EndTime", "StartTime" },
                values: new object[] { new DateTime(2024, 10, 4, 13, 40, 40, 0, DateTimeKind.Unspecified), new DateTime(2024, 5, 12, 22, 11, 1, 0, DateTimeKind.Unspecified) });

            migrationBuilder.UpdateData(
                table: "TimeRegistrations",
                keyColumn: "TimeRegistrationId",
                keyValue: 139,
                columns: new[] { "EndTime", "StartTime" },
                values: new object[] { new DateTime(2024, 6, 10, 7, 19, 21, 0, DateTimeKind.Unspecified), new DateTime(2024, 9, 30, 1, 47, 16, 0, DateTimeKind.Unspecified) });

            migrationBuilder.UpdateData(
                table: "TimeRegistrations",
                keyColumn: "TimeRegistrationId",
                keyValue: 140,
                columns: new[] { "EndTime", "StartTime" },
                values: new object[] { new DateTime(2024, 6, 17, 15, 42, 53, 0, DateTimeKind.Unspecified), new DateTime(2024, 5, 28, 12, 59, 49, 0, DateTimeKind.Unspecified) });

            migrationBuilder.UpdateData(
                table: "TimeRegistrations",
                keyColumn: "TimeRegistrationId",
                keyValue: 141,
                columns: new[] { "EndTime", "StartTime" },
                values: new object[] { new DateTime(2024, 4, 25, 19, 31, 16, 0, DateTimeKind.Unspecified), new DateTime(2024, 1, 9, 2, 2, 6, 0, DateTimeKind.Unspecified) });

            migrationBuilder.UpdateData(
                table: "TimeRegistrations",
                keyColumn: "TimeRegistrationId",
                keyValue: 142,
                columns: new[] { "EndTime", "StartTime" },
                values: new object[] { new DateTime(2024, 8, 5, 22, 35, 57, 0, DateTimeKind.Unspecified), new DateTime(2024, 1, 12, 3, 44, 32, 0, DateTimeKind.Unspecified) });

            migrationBuilder.UpdateData(
                table: "TimeRegistrations",
                keyColumn: "TimeRegistrationId",
                keyValue: 143,
                columns: new[] { "EndTime", "StartTime" },
                values: new object[] { new DateTime(2024, 6, 15, 6, 52, 20, 0, DateTimeKind.Unspecified), new DateTime(2024, 2, 23, 10, 18, 2, 0, DateTimeKind.Unspecified) });

            migrationBuilder.UpdateData(
                table: "TimeRegistrations",
                keyColumn: "TimeRegistrationId",
                keyValue: 144,
                columns: new[] { "EndTime", "StartTime" },
                values: new object[] { new DateTime(2024, 5, 5, 22, 48, 22, 0, DateTimeKind.Unspecified), new DateTime(2024, 5, 3, 20, 26, 11, 0, DateTimeKind.Unspecified) });

            migrationBuilder.UpdateData(
                table: "TimeRegistrations",
                keyColumn: "TimeRegistrationId",
                keyValue: 145,
                columns: new[] { "EndTime", "StartTime" },
                values: new object[] { new DateTime(2024, 1, 22, 15, 29, 57, 0, DateTimeKind.Unspecified), new DateTime(2024, 5, 26, 22, 9, 46, 0, DateTimeKind.Unspecified) });

            migrationBuilder.UpdateData(
                table: "TimeRegistrations",
                keyColumn: "TimeRegistrationId",
                keyValue: 146,
                columns: new[] { "EndTime", "StartTime" },
                values: new object[] { new DateTime(2024, 6, 15, 18, 18, 20, 0, DateTimeKind.Unspecified), new DateTime(2024, 1, 13, 6, 0, 38, 0, DateTimeKind.Unspecified) });

            migrationBuilder.UpdateData(
                table: "TimeRegistrations",
                keyColumn: "TimeRegistrationId",
                keyValue: 147,
                columns: new[] { "EndTime", "StartTime" },
                values: new object[] { new DateTime(2024, 8, 18, 16, 51, 44, 0, DateTimeKind.Unspecified), new DateTime(2024, 11, 17, 0, 45, 44, 0, DateTimeKind.Unspecified) });

            migrationBuilder.UpdateData(
                table: "TimeRegistrations",
                keyColumn: "TimeRegistrationId",
                keyValue: 148,
                columns: new[] { "EndTime", "StartTime" },
                values: new object[] { new DateTime(2024, 3, 13, 23, 24, 31, 0, DateTimeKind.Unspecified), new DateTime(2024, 3, 19, 20, 59, 1, 0, DateTimeKind.Unspecified) });

            migrationBuilder.UpdateData(
                table: "TimeRegistrations",
                keyColumn: "TimeRegistrationId",
                keyValue: 149,
                columns: new[] { "EndTime", "StartTime" },
                values: new object[] { new DateTime(2024, 12, 2, 4, 21, 21, 0, DateTimeKind.Unspecified), new DateTime(2024, 6, 10, 22, 25, 23, 0, DateTimeKind.Unspecified) });

            migrationBuilder.UpdateData(
                table: "TimeRegistrations",
                keyColumn: "TimeRegistrationId",
                keyValue: 150,
                columns: new[] { "EndTime", "StartTime" },
                values: new object[] { new DateTime(2024, 4, 3, 2, 0, 21, 0, DateTimeKind.Unspecified), new DateTime(2024, 9, 29, 21, 11, 11, 0, DateTimeKind.Unspecified) });

            migrationBuilder.UpdateData(
                table: "TimeRegistrations",
                keyColumn: "TimeRegistrationId",
                keyValue: 151,
                columns: new[] { "EndTime", "StartTime" },
                values: new object[] { new DateTime(2024, 10, 23, 4, 15, 13, 0, DateTimeKind.Unspecified), new DateTime(2024, 9, 29, 8, 36, 15, 0, DateTimeKind.Unspecified) });

            migrationBuilder.UpdateData(
                table: "TimeRegistrations",
                keyColumn: "TimeRegistrationId",
                keyValue: 152,
                columns: new[] { "EndTime", "StartTime" },
                values: new object[] { new DateTime(2024, 3, 31, 18, 23, 20, 0, DateTimeKind.Unspecified), new DateTime(2024, 12, 4, 2, 34, 43, 0, DateTimeKind.Unspecified) });

            migrationBuilder.UpdateData(
                table: "TimeRegistrations",
                keyColumn: "TimeRegistrationId",
                keyValue: 153,
                columns: new[] { "EndTime", "StartTime" },
                values: new object[] { new DateTime(2024, 3, 27, 21, 42, 8, 0, DateTimeKind.Unspecified), new DateTime(2024, 6, 2, 17, 8, 45, 0, DateTimeKind.Unspecified) });

            migrationBuilder.UpdateData(
                table: "TimeRegistrations",
                keyColumn: "TimeRegistrationId",
                keyValue: 154,
                columns: new[] { "EndTime", "StartTime" },
                values: new object[] { new DateTime(2024, 10, 17, 6, 3, 0, 0, DateTimeKind.Unspecified), new DateTime(2024, 5, 5, 21, 16, 11, 0, DateTimeKind.Unspecified) });

            migrationBuilder.UpdateData(
                table: "TimeRegistrations",
                keyColumn: "TimeRegistrationId",
                keyValue: 155,
                columns: new[] { "EndTime", "StartTime" },
                values: new object[] { new DateTime(2024, 12, 22, 11, 47, 27, 0, DateTimeKind.Unspecified), new DateTime(2024, 6, 18, 13, 16, 28, 0, DateTimeKind.Unspecified) });

            migrationBuilder.UpdateData(
                table: "TimeRegistrations",
                keyColumn: "TimeRegistrationId",
                keyValue: 156,
                columns: new[] { "EndTime", "StartTime" },
                values: new object[] { new DateTime(2024, 5, 5, 5, 31, 34, 0, DateTimeKind.Unspecified), new DateTime(2024, 7, 3, 12, 56, 15, 0, DateTimeKind.Unspecified) });

            migrationBuilder.UpdateData(
                table: "TimeRegistrations",
                keyColumn: "TimeRegistrationId",
                keyValue: 157,
                columns: new[] { "EndTime", "StartTime" },
                values: new object[] { new DateTime(2024, 8, 16, 15, 8, 40, 0, DateTimeKind.Unspecified), new DateTime(2024, 11, 10, 13, 13, 22, 0, DateTimeKind.Unspecified) });

            migrationBuilder.UpdateData(
                table: "TimeRegistrations",
                keyColumn: "TimeRegistrationId",
                keyValue: 158,
                columns: new[] { "EndTime", "StartTime" },
                values: new object[] { new DateTime(2024, 8, 19, 14, 22, 25, 0, DateTimeKind.Unspecified), new DateTime(2024, 7, 9, 13, 38, 56, 0, DateTimeKind.Unspecified) });

            migrationBuilder.UpdateData(
                table: "TimeRegistrations",
                keyColumn: "TimeRegistrationId",
                keyValue: 159,
                columns: new[] { "EndTime", "StartTime" },
                values: new object[] { new DateTime(2024, 5, 12, 2, 35, 24, 0, DateTimeKind.Unspecified), new DateTime(2024, 4, 30, 10, 33, 4, 0, DateTimeKind.Unspecified) });

            migrationBuilder.UpdateData(
                table: "TimeRegistrations",
                keyColumn: "TimeRegistrationId",
                keyValue: 160,
                columns: new[] { "EndTime", "StartTime" },
                values: new object[] { new DateTime(2024, 6, 20, 0, 42, 42, 0, DateTimeKind.Unspecified), new DateTime(2024, 2, 17, 5, 14, 50, 0, DateTimeKind.Unspecified) });

            migrationBuilder.UpdateData(
                table: "TimeRegistrations",
                keyColumn: "TimeRegistrationId",
                keyValue: 161,
                columns: new[] { "EndTime", "StartTime" },
                values: new object[] { new DateTime(2024, 5, 28, 8, 51, 17, 0, DateTimeKind.Unspecified), new DateTime(2024, 9, 15, 5, 44, 15, 0, DateTimeKind.Unspecified) });

            migrationBuilder.UpdateData(
                table: "TimeRegistrations",
                keyColumn: "TimeRegistrationId",
                keyValue: 162,
                columns: new[] { "EndTime", "StartTime" },
                values: new object[] { new DateTime(2024, 9, 12, 16, 13, 50, 0, DateTimeKind.Unspecified), new DateTime(2024, 3, 7, 13, 10, 26, 0, DateTimeKind.Unspecified) });

            migrationBuilder.UpdateData(
                table: "TimeRegistrations",
                keyColumn: "TimeRegistrationId",
                keyValue: 163,
                columns: new[] { "EndTime", "StartTime" },
                values: new object[] { new DateTime(2024, 6, 29, 18, 58, 59, 0, DateTimeKind.Unspecified), new DateTime(2024, 12, 24, 10, 26, 34, 0, DateTimeKind.Unspecified) });

            migrationBuilder.UpdateData(
                table: "TimeRegistrations",
                keyColumn: "TimeRegistrationId",
                keyValue: 164,
                columns: new[] { "EndTime", "StartTime" },
                values: new object[] { new DateTime(2024, 11, 24, 9, 13, 24, 0, DateTimeKind.Unspecified), new DateTime(2024, 8, 24, 23, 51, 45, 0, DateTimeKind.Unspecified) });

            migrationBuilder.UpdateData(
                table: "TimeRegistrations",
                keyColumn: "TimeRegistrationId",
                keyValue: 165,
                columns: new[] { "EndTime", "StartTime" },
                values: new object[] { new DateTime(2024, 11, 30, 14, 19, 27, 0, DateTimeKind.Unspecified), new DateTime(2024, 3, 5, 0, 30, 11, 0, DateTimeKind.Unspecified) });

            migrationBuilder.UpdateData(
                table: "TimeRegistrations",
                keyColumn: "TimeRegistrationId",
                keyValue: 166,
                columns: new[] { "EndTime", "StartTime" },
                values: new object[] { new DateTime(2024, 8, 24, 4, 41, 16, 0, DateTimeKind.Unspecified), new DateTime(2024, 12, 13, 6, 50, 6, 0, DateTimeKind.Unspecified) });

            migrationBuilder.UpdateData(
                table: "TimeRegistrations",
                keyColumn: "TimeRegistrationId",
                keyValue: 167,
                columns: new[] { "EndTime", "StartTime" },
                values: new object[] { new DateTime(2024, 8, 9, 16, 51, 36, 0, DateTimeKind.Unspecified), new DateTime(2024, 3, 27, 9, 23, 50, 0, DateTimeKind.Unspecified) });

            migrationBuilder.UpdateData(
                table: "TimeRegistrations",
                keyColumn: "TimeRegistrationId",
                keyValue: 168,
                columns: new[] { "EndTime", "StartTime" },
                values: new object[] { new DateTime(2024, 7, 22, 10, 39, 18, 0, DateTimeKind.Unspecified), new DateTime(2024, 11, 18, 1, 56, 54, 0, DateTimeKind.Unspecified) });

            migrationBuilder.UpdateData(
                table: "TimeRegistrations",
                keyColumn: "TimeRegistrationId",
                keyValue: 169,
                columns: new[] { "EndTime", "StartTime" },
                values: new object[] { new DateTime(2024, 5, 30, 5, 43, 45, 0, DateTimeKind.Unspecified), new DateTime(2024, 4, 3, 9, 50, 33, 0, DateTimeKind.Unspecified) });

            migrationBuilder.UpdateData(
                table: "TimeRegistrations",
                keyColumn: "TimeRegistrationId",
                keyValue: 170,
                columns: new[] { "EndTime", "StartTime" },
                values: new object[] { new DateTime(2024, 4, 22, 20, 8, 9, 0, DateTimeKind.Unspecified), new DateTime(2024, 4, 1, 2, 31, 8, 0, DateTimeKind.Unspecified) });

            migrationBuilder.UpdateData(
                table: "TimeRegistrations",
                keyColumn: "TimeRegistrationId",
                keyValue: 171,
                columns: new[] { "EndTime", "StartTime" },
                values: new object[] { new DateTime(2024, 5, 12, 8, 55, 7, 0, DateTimeKind.Unspecified), new DateTime(2024, 3, 30, 8, 50, 50, 0, DateTimeKind.Unspecified) });

            migrationBuilder.UpdateData(
                table: "TimeRegistrations",
                keyColumn: "TimeRegistrationId",
                keyValue: 172,
                columns: new[] { "EndTime", "StartTime" },
                values: new object[] { new DateTime(2024, 9, 16, 15, 34, 33, 0, DateTimeKind.Unspecified), new DateTime(2024, 12, 12, 3, 18, 41, 0, DateTimeKind.Unspecified) });

            migrationBuilder.UpdateData(
                table: "TimeRegistrations",
                keyColumn: "TimeRegistrationId",
                keyValue: 173,
                columns: new[] { "EndTime", "StartTime" },
                values: new object[] { new DateTime(2024, 12, 22, 13, 52, 38, 0, DateTimeKind.Unspecified), new DateTime(2024, 5, 26, 6, 29, 35, 0, DateTimeKind.Unspecified) });

            migrationBuilder.UpdateData(
                table: "TimeRegistrations",
                keyColumn: "TimeRegistrationId",
                keyValue: 174,
                columns: new[] { "EndTime", "StartTime" },
                values: new object[] { new DateTime(2024, 7, 1, 9, 44, 1, 0, DateTimeKind.Unspecified), new DateTime(2024, 2, 15, 4, 59, 27, 0, DateTimeKind.Unspecified) });

            migrationBuilder.UpdateData(
                table: "TimeRegistrations",
                keyColumn: "TimeRegistrationId",
                keyValue: 175,
                columns: new[] { "EndTime", "StartTime" },
                values: new object[] { new DateTime(2024, 7, 14, 19, 11, 11, 0, DateTimeKind.Unspecified), new DateTime(2024, 6, 9, 10, 32, 6, 0, DateTimeKind.Unspecified) });

            migrationBuilder.UpdateData(
                table: "TimeRegistrations",
                keyColumn: "TimeRegistrationId",
                keyValue: 176,
                columns: new[] { "EndTime", "StartTime" },
                values: new object[] { new DateTime(2024, 3, 30, 13, 32, 15, 0, DateTimeKind.Unspecified), new DateTime(2024, 6, 20, 4, 30, 21, 0, DateTimeKind.Unspecified) });

            migrationBuilder.UpdateData(
                table: "TimeRegistrations",
                keyColumn: "TimeRegistrationId",
                keyValue: 177,
                columns: new[] { "EndTime", "StartTime" },
                values: new object[] { new DateTime(2024, 6, 25, 7, 5, 4, 0, DateTimeKind.Unspecified), new DateTime(2024, 7, 15, 0, 44, 17, 0, DateTimeKind.Unspecified) });

            migrationBuilder.UpdateData(
                table: "TimeRegistrations",
                keyColumn: "TimeRegistrationId",
                keyValue: 178,
                columns: new[] { "EndTime", "StartTime" },
                values: new object[] { new DateTime(2024, 7, 24, 9, 20, 20, 0, DateTimeKind.Unspecified), new DateTime(2024, 12, 15, 0, 43, 4, 0, DateTimeKind.Unspecified) });

            migrationBuilder.UpdateData(
                table: "TimeRegistrations",
                keyColumn: "TimeRegistrationId",
                keyValue: 179,
                columns: new[] { "EndTime", "StartTime" },
                values: new object[] { new DateTime(2024, 6, 27, 13, 13, 21, 0, DateTimeKind.Unspecified), new DateTime(2024, 7, 24, 21, 26, 53, 0, DateTimeKind.Unspecified) });

            migrationBuilder.UpdateData(
                table: "TimeRegistrations",
                keyColumn: "TimeRegistrationId",
                keyValue: 180,
                columns: new[] { "EndTime", "StartTime" },
                values: new object[] { new DateTime(2024, 9, 25, 9, 32, 9, 0, DateTimeKind.Unspecified), new DateTime(2024, 9, 23, 15, 3, 17, 0, DateTimeKind.Unspecified) });

            migrationBuilder.UpdateData(
                table: "TimeRegistrations",
                keyColumn: "TimeRegistrationId",
                keyValue: 181,
                columns: new[] { "EndTime", "StartTime" },
                values: new object[] { new DateTime(2024, 4, 28, 17, 30, 6, 0, DateTimeKind.Unspecified), new DateTime(2024, 5, 9, 19, 58, 14, 0, DateTimeKind.Unspecified) });

            migrationBuilder.UpdateData(
                table: "TimeRegistrations",
                keyColumn: "TimeRegistrationId",
                keyValue: 182,
                columns: new[] { "EndTime", "StartTime" },
                values: new object[] { new DateTime(2024, 9, 17, 12, 22, 23, 0, DateTimeKind.Unspecified), new DateTime(2024, 11, 14, 21, 23, 18, 0, DateTimeKind.Unspecified) });

            migrationBuilder.UpdateData(
                table: "TimeRegistrations",
                keyColumn: "TimeRegistrationId",
                keyValue: 183,
                columns: new[] { "EndTime", "StartTime" },
                values: new object[] { new DateTime(2024, 10, 12, 6, 18, 40, 0, DateTimeKind.Unspecified), new DateTime(2024, 5, 14, 21, 37, 34, 0, DateTimeKind.Unspecified) });

            migrationBuilder.UpdateData(
                table: "TimeRegistrations",
                keyColumn: "TimeRegistrationId",
                keyValue: 184,
                columns: new[] { "EndTime", "StartTime" },
                values: new object[] { new DateTime(2024, 6, 4, 6, 50, 12, 0, DateTimeKind.Unspecified), new DateTime(2024, 1, 8, 7, 56, 54, 0, DateTimeKind.Unspecified) });

            migrationBuilder.UpdateData(
                table: "TimeRegistrations",
                keyColumn: "TimeRegistrationId",
                keyValue: 185,
                columns: new[] { "EndTime", "StartTime" },
                values: new object[] { new DateTime(2024, 8, 14, 15, 30, 18, 0, DateTimeKind.Unspecified), new DateTime(2024, 11, 8, 12, 55, 51, 0, DateTimeKind.Unspecified) });

            migrationBuilder.UpdateData(
                table: "TimeRegistrations",
                keyColumn: "TimeRegistrationId",
                keyValue: 186,
                columns: new[] { "EndTime", "StartTime" },
                values: new object[] { new DateTime(2024, 12, 5, 17, 15, 19, 0, DateTimeKind.Unspecified), new DateTime(2024, 12, 17, 6, 4, 23, 0, DateTimeKind.Unspecified) });

            migrationBuilder.UpdateData(
                table: "TimeRegistrations",
                keyColumn: "TimeRegistrationId",
                keyValue: 187,
                columns: new[] { "EndTime", "StartTime" },
                values: new object[] { new DateTime(2024, 3, 3, 6, 51, 2, 0, DateTimeKind.Unspecified), new DateTime(2024, 12, 24, 19, 53, 15, 0, DateTimeKind.Unspecified) });

            migrationBuilder.UpdateData(
                table: "TimeRegistrations",
                keyColumn: "TimeRegistrationId",
                keyValue: 188,
                columns: new[] { "EndTime", "StartTime" },
                values: new object[] { new DateTime(2024, 6, 29, 21, 27, 30, 0, DateTimeKind.Unspecified), new DateTime(2024, 9, 2, 20, 13, 38, 0, DateTimeKind.Unspecified) });

            migrationBuilder.UpdateData(
                table: "TimeRegistrations",
                keyColumn: "TimeRegistrationId",
                keyValue: 189,
                columns: new[] { "EndTime", "StartTime" },
                values: new object[] { new DateTime(2024, 7, 5, 23, 19, 34, 0, DateTimeKind.Unspecified), new DateTime(2024, 10, 19, 18, 15, 36, 0, DateTimeKind.Unspecified) });

            migrationBuilder.UpdateData(
                table: "TimeRegistrations",
                keyColumn: "TimeRegistrationId",
                keyValue: 190,
                columns: new[] { "EndTime", "StartTime" },
                values: new object[] { new DateTime(2024, 1, 22, 1, 45, 29, 0, DateTimeKind.Unspecified), new DateTime(2024, 6, 20, 10, 54, 22, 0, DateTimeKind.Unspecified) });

            migrationBuilder.UpdateData(
                table: "TimeRegistrations",
                keyColumn: "TimeRegistrationId",
                keyValue: 191,
                columns: new[] { "EndTime", "StartTime" },
                values: new object[] { new DateTime(2024, 5, 29, 23, 9, 0, 0, DateTimeKind.Unspecified), new DateTime(2024, 7, 15, 22, 54, 58, 0, DateTimeKind.Unspecified) });

            migrationBuilder.UpdateData(
                table: "TimeRegistrations",
                keyColumn: "TimeRegistrationId",
                keyValue: 192,
                columns: new[] { "EndTime", "StartTime" },
                values: new object[] { new DateTime(2024, 6, 3, 0, 27, 17, 0, DateTimeKind.Unspecified), new DateTime(2024, 1, 13, 11, 6, 6, 0, DateTimeKind.Unspecified) });

            migrationBuilder.UpdateData(
                table: "TimeRegistrations",
                keyColumn: "TimeRegistrationId",
                keyValue: 193,
                columns: new[] { "EndTime", "StartTime" },
                values: new object[] { new DateTime(2024, 2, 21, 4, 49, 18, 0, DateTimeKind.Unspecified), new DateTime(2024, 1, 4, 13, 0, 59, 0, DateTimeKind.Unspecified) });

            migrationBuilder.UpdateData(
                table: "TimeRegistrations",
                keyColumn: "TimeRegistrationId",
                keyValue: 194,
                columns: new[] { "EndTime", "StartTime" },
                values: new object[] { new DateTime(2024, 2, 23, 11, 50, 21, 0, DateTimeKind.Unspecified), new DateTime(2024, 1, 30, 11, 32, 25, 0, DateTimeKind.Unspecified) });

            migrationBuilder.UpdateData(
                table: "TimeRegistrations",
                keyColumn: "TimeRegistrationId",
                keyValue: 195,
                columns: new[] { "EndTime", "StartTime" },
                values: new object[] { new DateTime(2024, 3, 21, 0, 0, 57, 0, DateTimeKind.Unspecified), new DateTime(2024, 6, 11, 8, 31, 15, 0, DateTimeKind.Unspecified) });

            migrationBuilder.UpdateData(
                table: "TimeRegistrations",
                keyColumn: "TimeRegistrationId",
                keyValue: 196,
                columns: new[] { "EndTime", "StartTime" },
                values: new object[] { new DateTime(2024, 1, 11, 22, 26, 20, 0, DateTimeKind.Unspecified), new DateTime(2024, 7, 5, 7, 57, 41, 0, DateTimeKind.Unspecified) });

            migrationBuilder.UpdateData(
                table: "TimeRegistrations",
                keyColumn: "TimeRegistrationId",
                keyValue: 197,
                columns: new[] { "EndTime", "StartTime" },
                values: new object[] { new DateTime(2024, 1, 20, 5, 43, 41, 0, DateTimeKind.Unspecified), new DateTime(2024, 3, 6, 9, 24, 43, 0, DateTimeKind.Unspecified) });

            migrationBuilder.UpdateData(
                table: "TimeRegistrations",
                keyColumn: "TimeRegistrationId",
                keyValue: 198,
                columns: new[] { "EndTime", "StartTime" },
                values: new object[] { new DateTime(2024, 5, 8, 3, 19, 1, 0, DateTimeKind.Unspecified), new DateTime(2024, 9, 15, 11, 56, 11, 0, DateTimeKind.Unspecified) });

            migrationBuilder.UpdateData(
                table: "TimeRegistrations",
                keyColumn: "TimeRegistrationId",
                keyValue: 199,
                columns: new[] { "EndTime", "StartTime" },
                values: new object[] { new DateTime(2024, 9, 2, 0, 15, 42, 0, DateTimeKind.Unspecified), new DateTime(2024, 10, 8, 8, 51, 6, 0, DateTimeKind.Unspecified) });

            migrationBuilder.UpdateData(
                table: "TimeRegistrations",
                keyColumn: "TimeRegistrationId",
                keyValue: 200,
                columns: new[] { "EndTime", "StartTime" },
                values: new object[] { new DateTime(2024, 2, 26, 5, 41, 13, 0, DateTimeKind.Unspecified), new DateTime(2024, 3, 20, 14, 30, 43, 0, DateTimeKind.Unspecified) });

            migrationBuilder.UpdateData(
                table: "TimeRegistrations",
                keyColumn: "TimeRegistrationId",
                keyValue: 201,
                columns: new[] { "EndTime", "StartTime" },
                values: new object[] { new DateTime(2024, 12, 14, 4, 40, 2, 0, DateTimeKind.Unspecified), new DateTime(2024, 11, 16, 10, 37, 42, 0, DateTimeKind.Unspecified) });

            migrationBuilder.UpdateData(
                table: "TimeRegistrations",
                keyColumn: "TimeRegistrationId",
                keyValue: 202,
                columns: new[] { "EndTime", "StartTime" },
                values: new object[] { new DateTime(2024, 5, 7, 14, 6, 46, 0, DateTimeKind.Unspecified), new DateTime(2024, 7, 22, 5, 25, 55, 0, DateTimeKind.Unspecified) });

            migrationBuilder.UpdateData(
                table: "TimeRegistrations",
                keyColumn: "TimeRegistrationId",
                keyValue: 203,
                columns: new[] { "EndTime", "StartTime" },
                values: new object[] { new DateTime(2024, 4, 9, 2, 40, 46, 0, DateTimeKind.Unspecified), new DateTime(2024, 9, 12, 0, 40, 46, 0, DateTimeKind.Unspecified) });

            migrationBuilder.UpdateData(
                table: "TimeRegistrations",
                keyColumn: "TimeRegistrationId",
                keyValue: 204,
                columns: new[] { "EndTime", "StartTime" },
                values: new object[] { new DateTime(2024, 9, 14, 1, 32, 0, 0, DateTimeKind.Unspecified), new DateTime(2024, 7, 27, 11, 33, 6, 0, DateTimeKind.Unspecified) });

            migrationBuilder.UpdateData(
                table: "TimeRegistrations",
                keyColumn: "TimeRegistrationId",
                keyValue: 205,
                columns: new[] { "EndTime", "StartTime" },
                values: new object[] { new DateTime(2024, 2, 21, 11, 59, 3, 0, DateTimeKind.Unspecified), new DateTime(2024, 6, 28, 19, 25, 26, 0, DateTimeKind.Unspecified) });

            migrationBuilder.UpdateData(
                table: "TimeRegistrations",
                keyColumn: "TimeRegistrationId",
                keyValue: 206,
                columns: new[] { "EndTime", "StartTime" },
                values: new object[] { new DateTime(2024, 1, 7, 9, 15, 12, 0, DateTimeKind.Unspecified), new DateTime(2024, 12, 28, 3, 32, 24, 0, DateTimeKind.Unspecified) });

            migrationBuilder.UpdateData(
                table: "TimeRegistrations",
                keyColumn: "TimeRegistrationId",
                keyValue: 207,
                columns: new[] { "EndTime", "StartTime" },
                values: new object[] { new DateTime(2024, 9, 28, 0, 49, 54, 0, DateTimeKind.Unspecified), new DateTime(2024, 8, 8, 3, 48, 0, 0, DateTimeKind.Unspecified) });

            migrationBuilder.UpdateData(
                table: "TimeRegistrations",
                keyColumn: "TimeRegistrationId",
                keyValue: 208,
                columns: new[] { "EndTime", "StartTime" },
                values: new object[] { new DateTime(2024, 7, 28, 1, 24, 7, 0, DateTimeKind.Unspecified), new DateTime(2024, 4, 2, 23, 55, 3, 0, DateTimeKind.Unspecified) });

            migrationBuilder.UpdateData(
                table: "TimeRegistrations",
                keyColumn: "TimeRegistrationId",
                keyValue: 209,
                columns: new[] { "EndTime", "StartTime" },
                values: new object[] { new DateTime(2024, 9, 11, 3, 46, 42, 0, DateTimeKind.Unspecified), new DateTime(2024, 4, 12, 16, 21, 45, 0, DateTimeKind.Unspecified) });

            migrationBuilder.UpdateData(
                table: "TimeRegistrations",
                keyColumn: "TimeRegistrationId",
                keyValue: 210,
                columns: new[] { "EndTime", "StartTime" },
                values: new object[] { new DateTime(2024, 4, 17, 1, 4, 9, 0, DateTimeKind.Unspecified), new DateTime(2024, 2, 22, 23, 48, 57, 0, DateTimeKind.Unspecified) });

            migrationBuilder.UpdateData(
                table: "TimeRegistrations",
                keyColumn: "TimeRegistrationId",
                keyValue: 211,
                columns: new[] { "EndTime", "StartTime" },
                values: new object[] { new DateTime(2024, 1, 23, 2, 54, 20, 0, DateTimeKind.Unspecified), new DateTime(2024, 12, 10, 7, 36, 24, 0, DateTimeKind.Unspecified) });

            migrationBuilder.UpdateData(
                table: "TimeRegistrations",
                keyColumn: "TimeRegistrationId",
                keyValue: 212,
                columns: new[] { "EndTime", "StartTime" },
                values: new object[] { new DateTime(2024, 5, 22, 22, 23, 55, 0, DateTimeKind.Unspecified), new DateTime(2024, 1, 5, 13, 57, 8, 0, DateTimeKind.Unspecified) });

            migrationBuilder.UpdateData(
                table: "TimeRegistrations",
                keyColumn: "TimeRegistrationId",
                keyValue: 213,
                columns: new[] { "EndTime", "StartTime" },
                values: new object[] { new DateTime(2024, 11, 13, 21, 51, 3, 0, DateTimeKind.Unspecified), new DateTime(2024, 5, 14, 1, 15, 59, 0, DateTimeKind.Unspecified) });

            migrationBuilder.UpdateData(
                table: "TimeRegistrations",
                keyColumn: "TimeRegistrationId",
                keyValue: 214,
                columns: new[] { "EndTime", "StartTime" },
                values: new object[] { new DateTime(2024, 7, 19, 13, 19, 51, 0, DateTimeKind.Unspecified), new DateTime(2024, 6, 22, 5, 29, 52, 0, DateTimeKind.Unspecified) });

            migrationBuilder.UpdateData(
                table: "TimeRegistrations",
                keyColumn: "TimeRegistrationId",
                keyValue: 215,
                columns: new[] { "EndTime", "StartTime" },
                values: new object[] { new DateTime(2024, 12, 8, 20, 5, 11, 0, DateTimeKind.Unspecified), new DateTime(2024, 9, 6, 3, 35, 3, 0, DateTimeKind.Unspecified) });

            migrationBuilder.UpdateData(
                table: "TimeRegistrations",
                keyColumn: "TimeRegistrationId",
                keyValue: 216,
                columns: new[] { "EndTime", "StartTime" },
                values: new object[] { new DateTime(2024, 8, 15, 10, 2, 6, 0, DateTimeKind.Unspecified), new DateTime(2024, 3, 31, 19, 27, 39, 0, DateTimeKind.Unspecified) });

            migrationBuilder.UpdateData(
                table: "TimeRegistrations",
                keyColumn: "TimeRegistrationId",
                keyValue: 217,
                columns: new[] { "EndTime", "StartTime" },
                values: new object[] { new DateTime(2024, 9, 22, 3, 6, 40, 0, DateTimeKind.Unspecified), new DateTime(2024, 6, 2, 12, 29, 44, 0, DateTimeKind.Unspecified) });

            migrationBuilder.UpdateData(
                table: "TimeRegistrations",
                keyColumn: "TimeRegistrationId",
                keyValue: 218,
                columns: new[] { "EndTime", "StartTime" },
                values: new object[] { new DateTime(2024, 10, 12, 20, 50, 18, 0, DateTimeKind.Unspecified), new DateTime(2024, 12, 8, 7, 6, 31, 0, DateTimeKind.Unspecified) });

            migrationBuilder.UpdateData(
                table: "TimeRegistrations",
                keyColumn: "TimeRegistrationId",
                keyValue: 219,
                columns: new[] { "EndTime", "StartTime" },
                values: new object[] { new DateTime(2024, 4, 8, 23, 10, 11, 0, DateTimeKind.Unspecified), new DateTime(2024, 3, 11, 0, 11, 5, 0, DateTimeKind.Unspecified) });

            migrationBuilder.UpdateData(
                table: "TimeRegistrations",
                keyColumn: "TimeRegistrationId",
                keyValue: 220,
                columns: new[] { "EndTime", "StartTime" },
                values: new object[] { new DateTime(2024, 12, 20, 8, 26, 43, 0, DateTimeKind.Unspecified), new DateTime(2024, 10, 29, 22, 16, 3, 0, DateTimeKind.Unspecified) });

            migrationBuilder.UpdateData(
                table: "TimeRegistrations",
                keyColumn: "TimeRegistrationId",
                keyValue: 221,
                columns: new[] { "EndTime", "StartTime" },
                values: new object[] { new DateTime(2024, 1, 14, 3, 11, 56, 0, DateTimeKind.Unspecified), new DateTime(2024, 9, 17, 15, 48, 32, 0, DateTimeKind.Unspecified) });

            migrationBuilder.UpdateData(
                table: "TimeRegistrations",
                keyColumn: "TimeRegistrationId",
                keyValue: 222,
                columns: new[] { "EndTime", "StartTime" },
                values: new object[] { new DateTime(2024, 2, 18, 11, 19, 41, 0, DateTimeKind.Unspecified), new DateTime(2024, 12, 16, 15, 22, 30, 0, DateTimeKind.Unspecified) });

            migrationBuilder.UpdateData(
                table: "TimeRegistrations",
                keyColumn: "TimeRegistrationId",
                keyValue: 223,
                columns: new[] { "EndTime", "StartTime" },
                values: new object[] { new DateTime(2024, 7, 15, 15, 25, 51, 0, DateTimeKind.Unspecified), new DateTime(2024, 1, 26, 23, 3, 11, 0, DateTimeKind.Unspecified) });

            migrationBuilder.UpdateData(
                table: "TimeRegistrations",
                keyColumn: "TimeRegistrationId",
                keyValue: 224,
                columns: new[] { "EndTime", "StartTime" },
                values: new object[] { new DateTime(2024, 12, 28, 18, 48, 1, 0, DateTimeKind.Unspecified), new DateTime(2024, 6, 17, 16, 11, 49, 0, DateTimeKind.Unspecified) });

            migrationBuilder.UpdateData(
                table: "TimeRegistrations",
                keyColumn: "TimeRegistrationId",
                keyValue: 225,
                columns: new[] { "EndTime", "StartTime" },
                values: new object[] { new DateTime(2024, 5, 3, 9, 31, 10, 0, DateTimeKind.Unspecified), new DateTime(2024, 1, 16, 8, 6, 16, 0, DateTimeKind.Unspecified) });

            migrationBuilder.UpdateData(
                table: "TimeRegistrations",
                keyColumn: "TimeRegistrationId",
                keyValue: 226,
                columns: new[] { "EndTime", "StartTime" },
                values: new object[] { new DateTime(2024, 2, 3, 19, 45, 19, 0, DateTimeKind.Unspecified), new DateTime(2024, 5, 7, 13, 43, 38, 0, DateTimeKind.Unspecified) });

            migrationBuilder.UpdateData(
                table: "TimeRegistrations",
                keyColumn: "TimeRegistrationId",
                keyValue: 227,
                columns: new[] { "EndTime", "StartTime" },
                values: new object[] { new DateTime(2024, 3, 14, 11, 11, 39, 0, DateTimeKind.Unspecified), new DateTime(2024, 8, 11, 15, 35, 46, 0, DateTimeKind.Unspecified) });

            migrationBuilder.UpdateData(
                table: "TimeRegistrations",
                keyColumn: "TimeRegistrationId",
                keyValue: 228,
                columns: new[] { "EndTime", "StartTime" },
                values: new object[] { new DateTime(2024, 5, 12, 19, 0, 31, 0, DateTimeKind.Unspecified), new DateTime(2024, 10, 17, 15, 3, 16, 0, DateTimeKind.Unspecified) });

            migrationBuilder.UpdateData(
                table: "TimeRegistrations",
                keyColumn: "TimeRegistrationId",
                keyValue: 229,
                columns: new[] { "EndTime", "StartTime" },
                values: new object[] { new DateTime(2024, 10, 12, 19, 40, 59, 0, DateTimeKind.Unspecified), new DateTime(2024, 2, 2, 3, 2, 56, 0, DateTimeKind.Unspecified) });

            migrationBuilder.UpdateData(
                table: "TimeRegistrations",
                keyColumn: "TimeRegistrationId",
                keyValue: 230,
                columns: new[] { "EndTime", "StartTime" },
                values: new object[] { new DateTime(2024, 4, 13, 4, 11, 17, 0, DateTimeKind.Unspecified), new DateTime(2024, 10, 1, 9, 9, 54, 0, DateTimeKind.Unspecified) });

            migrationBuilder.UpdateData(
                table: "TimeRegistrations",
                keyColumn: "TimeRegistrationId",
                keyValue: 231,
                columns: new[] { "EndTime", "StartTime" },
                values: new object[] { new DateTime(2024, 7, 1, 10, 7, 41, 0, DateTimeKind.Unspecified), new DateTime(2024, 10, 2, 23, 22, 45, 0, DateTimeKind.Unspecified) });

            migrationBuilder.UpdateData(
                table: "TimeRegistrations",
                keyColumn: "TimeRegistrationId",
                keyValue: 232,
                columns: new[] { "EndTime", "StartTime" },
                values: new object[] { new DateTime(2024, 7, 13, 5, 18, 47, 0, DateTimeKind.Unspecified), new DateTime(2024, 9, 4, 16, 28, 34, 0, DateTimeKind.Unspecified) });

            migrationBuilder.UpdateData(
                table: "TimeRegistrations",
                keyColumn: "TimeRegistrationId",
                keyValue: 233,
                columns: new[] { "EndTime", "StartTime" },
                values: new object[] { new DateTime(2024, 8, 14, 9, 34, 13, 0, DateTimeKind.Unspecified), new DateTime(2024, 5, 26, 0, 46, 19, 0, DateTimeKind.Unspecified) });

            migrationBuilder.UpdateData(
                table: "TimeRegistrations",
                keyColumn: "TimeRegistrationId",
                keyValue: 234,
                columns: new[] { "EndTime", "StartTime" },
                values: new object[] { new DateTime(2024, 3, 6, 1, 38, 20, 0, DateTimeKind.Unspecified), new DateTime(2024, 10, 22, 1, 58, 41, 0, DateTimeKind.Unspecified) });

            migrationBuilder.UpdateData(
                table: "TimeRegistrations",
                keyColumn: "TimeRegistrationId",
                keyValue: 235,
                columns: new[] { "EndTime", "StartTime" },
                values: new object[] { new DateTime(2024, 4, 15, 17, 13, 53, 0, DateTimeKind.Unspecified), new DateTime(2024, 9, 5, 0, 4, 19, 0, DateTimeKind.Unspecified) });

            migrationBuilder.UpdateData(
                table: "TimeRegistrations",
                keyColumn: "TimeRegistrationId",
                keyValue: 236,
                columns: new[] { "EndTime", "StartTime" },
                values: new object[] { new DateTime(2024, 11, 10, 21, 27, 44, 0, DateTimeKind.Unspecified), new DateTime(2024, 10, 6, 15, 15, 39, 0, DateTimeKind.Unspecified) });

            migrationBuilder.UpdateData(
                table: "TimeRegistrations",
                keyColumn: "TimeRegistrationId",
                keyValue: 237,
                columns: new[] { "EndTime", "StartTime" },
                values: new object[] { new DateTime(2024, 2, 22, 7, 32, 34, 0, DateTimeKind.Unspecified), new DateTime(2024, 8, 28, 6, 35, 20, 0, DateTimeKind.Unspecified) });

            migrationBuilder.UpdateData(
                table: "TimeRegistrations",
                keyColumn: "TimeRegistrationId",
                keyValue: 238,
                columns: new[] { "EndTime", "StartTime" },
                values: new object[] { new DateTime(2024, 12, 24, 14, 20, 21, 0, DateTimeKind.Unspecified), new DateTime(2024, 2, 21, 12, 18, 57, 0, DateTimeKind.Unspecified) });

            migrationBuilder.UpdateData(
                table: "TimeRegistrations",
                keyColumn: "TimeRegistrationId",
                keyValue: 239,
                columns: new[] { "EndTime", "StartTime" },
                values: new object[] { new DateTime(2024, 3, 2, 7, 23, 30, 0, DateTimeKind.Unspecified), new DateTime(2024, 9, 20, 17, 39, 43, 0, DateTimeKind.Unspecified) });

            migrationBuilder.UpdateData(
                table: "TimeRegistrations",
                keyColumn: "TimeRegistrationId",
                keyValue: 240,
                columns: new[] { "EndTime", "StartTime" },
                values: new object[] { new DateTime(2024, 7, 10, 16, 42, 14, 0, DateTimeKind.Unspecified), new DateTime(2024, 11, 14, 8, 24, 21, 0, DateTimeKind.Unspecified) });

            migrationBuilder.UpdateData(
                table: "TimeRegistrations",
                keyColumn: "TimeRegistrationId",
                keyValue: 241,
                columns: new[] { "EndTime", "StartTime" },
                values: new object[] { new DateTime(2024, 10, 22, 19, 20, 44, 0, DateTimeKind.Unspecified), new DateTime(2024, 9, 21, 2, 25, 54, 0, DateTimeKind.Unspecified) });

            migrationBuilder.UpdateData(
                table: "TimeRegistrations",
                keyColumn: "TimeRegistrationId",
                keyValue: 242,
                columns: new[] { "EndTime", "StartTime" },
                values: new object[] { new DateTime(2024, 8, 20, 8, 19, 30, 0, DateTimeKind.Unspecified), new DateTime(2024, 9, 11, 19, 12, 52, 0, DateTimeKind.Unspecified) });

            migrationBuilder.UpdateData(
                table: "TimeRegistrations",
                keyColumn: "TimeRegistrationId",
                keyValue: 243,
                columns: new[] { "EndTime", "StartTime" },
                values: new object[] { new DateTime(2024, 4, 20, 19, 57, 1, 0, DateTimeKind.Unspecified), new DateTime(2024, 12, 15, 9, 51, 8, 0, DateTimeKind.Unspecified) });

            migrationBuilder.UpdateData(
                table: "TimeRegistrations",
                keyColumn: "TimeRegistrationId",
                keyValue: 244,
                columns: new[] { "EndTime", "StartTime" },
                values: new object[] { new DateTime(2024, 5, 16, 19, 32, 19, 0, DateTimeKind.Unspecified), new DateTime(2024, 1, 2, 0, 38, 26, 0, DateTimeKind.Unspecified) });

            migrationBuilder.UpdateData(
                table: "TimeRegistrations",
                keyColumn: "TimeRegistrationId",
                keyValue: 245,
                columns: new[] { "EndTime", "StartTime" },
                values: new object[] { new DateTime(2024, 8, 2, 6, 45, 49, 0, DateTimeKind.Unspecified), new DateTime(2024, 8, 2, 9, 35, 6, 0, DateTimeKind.Unspecified) });

            migrationBuilder.UpdateData(
                table: "TimeRegistrations",
                keyColumn: "TimeRegistrationId",
                keyValue: 246,
                columns: new[] { "EndTime", "StartTime" },
                values: new object[] { new DateTime(2024, 12, 2, 15, 58, 40, 0, DateTimeKind.Unspecified), new DateTime(2024, 3, 28, 9, 16, 53, 0, DateTimeKind.Unspecified) });

            migrationBuilder.UpdateData(
                table: "TimeRegistrations",
                keyColumn: "TimeRegistrationId",
                keyValue: 247,
                columns: new[] { "EndTime", "StartTime" },
                values: new object[] { new DateTime(2024, 11, 7, 6, 9, 6, 0, DateTimeKind.Unspecified), new DateTime(2024, 10, 17, 22, 34, 37, 0, DateTimeKind.Unspecified) });

            migrationBuilder.UpdateData(
                table: "TimeRegistrations",
                keyColumn: "TimeRegistrationId",
                keyValue: 248,
                columns: new[] { "EndTime", "StartTime" },
                values: new object[] { new DateTime(2024, 2, 12, 1, 13, 56, 0, DateTimeKind.Unspecified), new DateTime(2024, 10, 26, 20, 17, 23, 0, DateTimeKind.Unspecified) });

            migrationBuilder.UpdateData(
                table: "TimeRegistrations",
                keyColumn: "TimeRegistrationId",
                keyValue: 249,
                columns: new[] { "EndTime", "StartTime" },
                values: new object[] { new DateTime(2024, 9, 2, 23, 1, 31, 0, DateTimeKind.Unspecified), new DateTime(2024, 11, 22, 13, 49, 12, 0, DateTimeKind.Unspecified) });

            migrationBuilder.UpdateData(
                table: "TimeRegistrations",
                keyColumn: "TimeRegistrationId",
                keyValue: 250,
                columns: new[] { "EndTime", "StartTime" },
                values: new object[] { new DateTime(2024, 6, 20, 13, 52, 39, 0, DateTimeKind.Unspecified), new DateTime(2024, 5, 13, 4, 33, 14, 0, DateTimeKind.Unspecified) });

            migrationBuilder.UpdateData(
                table: "TimeRegistrations",
                keyColumn: "TimeRegistrationId",
                keyValue: 251,
                columns: new[] { "EndTime", "StartTime" },
                values: new object[] { new DateTime(2024, 2, 29, 21, 7, 31, 0, DateTimeKind.Unspecified), new DateTime(2024, 4, 7, 14, 8, 9, 0, DateTimeKind.Unspecified) });

            migrationBuilder.UpdateData(
                table: "TimeRegistrations",
                keyColumn: "TimeRegistrationId",
                keyValue: 252,
                columns: new[] { "EndTime", "StartTime" },
                values: new object[] { new DateTime(2024, 5, 21, 7, 22, 47, 0, DateTimeKind.Unspecified), new DateTime(2024, 12, 23, 15, 4, 0, 0, DateTimeKind.Unspecified) });

            migrationBuilder.UpdateData(
                table: "TimeRegistrations",
                keyColumn: "TimeRegistrationId",
                keyValue: 253,
                columns: new[] { "EndTime", "StartTime" },
                values: new object[] { new DateTime(2024, 8, 4, 7, 47, 34, 0, DateTimeKind.Unspecified), new DateTime(2024, 6, 3, 15, 11, 47, 0, DateTimeKind.Unspecified) });

            migrationBuilder.UpdateData(
                table: "TimeRegistrations",
                keyColumn: "TimeRegistrationId",
                keyValue: 254,
                columns: new[] { "EndTime", "StartTime" },
                values: new object[] { new DateTime(2024, 12, 12, 6, 59, 2, 0, DateTimeKind.Unspecified), new DateTime(2024, 7, 28, 7, 47, 57, 0, DateTimeKind.Unspecified) });

            migrationBuilder.UpdateData(
                table: "TimeRegistrations",
                keyColumn: "TimeRegistrationId",
                keyValue: 255,
                columns: new[] { "EndTime", "StartTime" },
                values: new object[] { new DateTime(2024, 4, 23, 14, 58, 48, 0, DateTimeKind.Unspecified), new DateTime(2024, 9, 18, 0, 10, 19, 0, DateTimeKind.Unspecified) });

            migrationBuilder.UpdateData(
                table: "TimeRegistrations",
                keyColumn: "TimeRegistrationId",
                keyValue: 256,
                columns: new[] { "EndTime", "StartTime" },
                values: new object[] { new DateTime(2024, 6, 20, 5, 9, 32, 0, DateTimeKind.Unspecified), new DateTime(2024, 9, 23, 17, 1, 1, 0, DateTimeKind.Unspecified) });

            migrationBuilder.UpdateData(
                table: "TimeRegistrations",
                keyColumn: "TimeRegistrationId",
                keyValue: 257,
                columns: new[] { "EndTime", "StartTime" },
                values: new object[] { new DateTime(2024, 4, 20, 4, 37, 32, 0, DateTimeKind.Unspecified), new DateTime(2024, 3, 3, 17, 59, 16, 0, DateTimeKind.Unspecified) });

            migrationBuilder.UpdateData(
                table: "TimeRegistrations",
                keyColumn: "TimeRegistrationId",
                keyValue: 258,
                columns: new[] { "EndTime", "StartTime" },
                values: new object[] { new DateTime(2024, 8, 5, 16, 4, 57, 0, DateTimeKind.Unspecified), new DateTime(2024, 11, 13, 13, 46, 9, 0, DateTimeKind.Unspecified) });

            migrationBuilder.UpdateData(
                table: "TimeRegistrations",
                keyColumn: "TimeRegistrationId",
                keyValue: 259,
                columns: new[] { "EndTime", "StartTime" },
                values: new object[] { new DateTime(2024, 11, 2, 1, 59, 2, 0, DateTimeKind.Unspecified), new DateTime(2024, 8, 27, 2, 33, 58, 0, DateTimeKind.Unspecified) });

            migrationBuilder.UpdateData(
                table: "TimeRegistrations",
                keyColumn: "TimeRegistrationId",
                keyValue: 260,
                columns: new[] { "EndTime", "StartTime" },
                values: new object[] { new DateTime(2024, 12, 29, 10, 53, 34, 0, DateTimeKind.Unspecified), new DateTime(2024, 7, 2, 1, 13, 0, 0, DateTimeKind.Unspecified) });

            migrationBuilder.UpdateData(
                table: "TimeRegistrations",
                keyColumn: "TimeRegistrationId",
                keyValue: 261,
                columns: new[] { "EndTime", "StartTime" },
                values: new object[] { new DateTime(2024, 5, 17, 12, 57, 5, 0, DateTimeKind.Unspecified), new DateTime(2024, 9, 30, 20, 31, 30, 0, DateTimeKind.Unspecified) });

            migrationBuilder.UpdateData(
                table: "TimeRegistrations",
                keyColumn: "TimeRegistrationId",
                keyValue: 262,
                columns: new[] { "EndTime", "StartTime" },
                values: new object[] { new DateTime(2024, 3, 1, 1, 2, 0, 0, DateTimeKind.Unspecified), new DateTime(2024, 11, 27, 7, 24, 33, 0, DateTimeKind.Unspecified) });

            migrationBuilder.UpdateData(
                table: "TimeRegistrations",
                keyColumn: "TimeRegistrationId",
                keyValue: 263,
                columns: new[] { "EndTime", "StartTime" },
                values: new object[] { new DateTime(2024, 1, 15, 1, 3, 50, 0, DateTimeKind.Unspecified), new DateTime(2024, 5, 27, 17, 55, 8, 0, DateTimeKind.Unspecified) });

            migrationBuilder.UpdateData(
                table: "TimeRegistrations",
                keyColumn: "TimeRegistrationId",
                keyValue: 264,
                columns: new[] { "EndTime", "StartTime" },
                values: new object[] { new DateTime(2024, 12, 23, 19, 27, 37, 0, DateTimeKind.Unspecified), new DateTime(2024, 12, 24, 5, 12, 17, 0, DateTimeKind.Unspecified) });

            migrationBuilder.UpdateData(
                table: "TimeRegistrations",
                keyColumn: "TimeRegistrationId",
                keyValue: 265,
                columns: new[] { "EndTime", "StartTime" },
                values: new object[] { new DateTime(2024, 7, 10, 5, 39, 42, 0, DateTimeKind.Unspecified), new DateTime(2024, 8, 30, 0, 19, 36, 0, DateTimeKind.Unspecified) });

            migrationBuilder.UpdateData(
                table: "TimeRegistrations",
                keyColumn: "TimeRegistrationId",
                keyValue: 266,
                columns: new[] { "EndTime", "StartTime" },
                values: new object[] { new DateTime(2024, 8, 31, 0, 47, 55, 0, DateTimeKind.Unspecified), new DateTime(2024, 12, 14, 5, 56, 23, 0, DateTimeKind.Unspecified) });

            migrationBuilder.UpdateData(
                table: "TimeRegistrations",
                keyColumn: "TimeRegistrationId",
                keyValue: 267,
                columns: new[] { "EndTime", "StartTime" },
                values: new object[] { new DateTime(2024, 9, 13, 12, 31, 48, 0, DateTimeKind.Unspecified), new DateTime(2024, 11, 4, 6, 5, 47, 0, DateTimeKind.Unspecified) });

            migrationBuilder.UpdateData(
                table: "TimeRegistrations",
                keyColumn: "TimeRegistrationId",
                keyValue: 268,
                columns: new[] { "EndTime", "StartTime" },
                values: new object[] { new DateTime(2024, 7, 23, 12, 27, 17, 0, DateTimeKind.Unspecified), new DateTime(2024, 5, 12, 13, 16, 38, 0, DateTimeKind.Unspecified) });

            migrationBuilder.UpdateData(
                table: "TimeRegistrations",
                keyColumn: "TimeRegistrationId",
                keyValue: 269,
                columns: new[] { "EndTime", "StartTime" },
                values: new object[] { new DateTime(2024, 5, 7, 16, 54, 43, 0, DateTimeKind.Unspecified), new DateTime(2024, 3, 11, 9, 15, 4, 0, DateTimeKind.Unspecified) });

            migrationBuilder.UpdateData(
                table: "TimeRegistrations",
                keyColumn: "TimeRegistrationId",
                keyValue: 270,
                columns: new[] { "EndTime", "StartTime" },
                values: new object[] { new DateTime(2024, 5, 9, 6, 51, 32, 0, DateTimeKind.Unspecified), new DateTime(2024, 5, 15, 5, 3, 23, 0, DateTimeKind.Unspecified) });

            migrationBuilder.UpdateData(
                table: "TimeRegistrations",
                keyColumn: "TimeRegistrationId",
                keyValue: 271,
                columns: new[] { "EndTime", "StartTime" },
                values: new object[] { new DateTime(2024, 4, 14, 4, 22, 23, 0, DateTimeKind.Unspecified), new DateTime(2024, 3, 10, 0, 59, 30, 0, DateTimeKind.Unspecified) });

            migrationBuilder.UpdateData(
                table: "TimeRegistrations",
                keyColumn: "TimeRegistrationId",
                keyValue: 272,
                columns: new[] { "EndTime", "StartTime" },
                values: new object[] { new DateTime(2024, 6, 28, 20, 14, 44, 0, DateTimeKind.Unspecified), new DateTime(2024, 7, 5, 4, 27, 52, 0, DateTimeKind.Unspecified) });

            migrationBuilder.UpdateData(
                table: "TimeRegistrations",
                keyColumn: "TimeRegistrationId",
                keyValue: 273,
                columns: new[] { "EndTime", "StartTime" },
                values: new object[] { new DateTime(2024, 2, 28, 2, 38, 51, 0, DateTimeKind.Unspecified), new DateTime(2024, 5, 11, 12, 23, 54, 0, DateTimeKind.Unspecified) });

            migrationBuilder.UpdateData(
                table: "TimeRegistrations",
                keyColumn: "TimeRegistrationId",
                keyValue: 274,
                columns: new[] { "EndTime", "StartTime" },
                values: new object[] { new DateTime(2024, 2, 28, 10, 5, 52, 0, DateTimeKind.Unspecified), new DateTime(2024, 8, 4, 19, 43, 44, 0, DateTimeKind.Unspecified) });

            migrationBuilder.UpdateData(
                table: "TimeRegistrations",
                keyColumn: "TimeRegistrationId",
                keyValue: 275,
                columns: new[] { "EndTime", "StartTime" },
                values: new object[] { new DateTime(2024, 10, 6, 22, 55, 35, 0, DateTimeKind.Unspecified), new DateTime(2024, 3, 25, 14, 21, 18, 0, DateTimeKind.Unspecified) });

            migrationBuilder.UpdateData(
                table: "TimeRegistrations",
                keyColumn: "TimeRegistrationId",
                keyValue: 276,
                columns: new[] { "EndTime", "StartTime" },
                values: new object[] { new DateTime(2024, 12, 6, 18, 42, 42, 0, DateTimeKind.Unspecified), new DateTime(2024, 11, 15, 11, 8, 52, 0, DateTimeKind.Unspecified) });

            migrationBuilder.UpdateData(
                table: "TimeRegistrations",
                keyColumn: "TimeRegistrationId",
                keyValue: 277,
                columns: new[] { "EndTime", "StartTime" },
                values: new object[] { new DateTime(2024, 8, 28, 8, 36, 40, 0, DateTimeKind.Unspecified), new DateTime(2024, 6, 2, 17, 30, 43, 0, DateTimeKind.Unspecified) });

            migrationBuilder.UpdateData(
                table: "TimeRegistrations",
                keyColumn: "TimeRegistrationId",
                keyValue: 278,
                columns: new[] { "EndTime", "StartTime" },
                values: new object[] { new DateTime(2024, 6, 8, 10, 29, 46, 0, DateTimeKind.Unspecified), new DateTime(2024, 5, 31, 15, 33, 52, 0, DateTimeKind.Unspecified) });

            migrationBuilder.UpdateData(
                table: "TimeRegistrations",
                keyColumn: "TimeRegistrationId",
                keyValue: 279,
                columns: new[] { "EndTime", "StartTime" },
                values: new object[] { new DateTime(2024, 10, 3, 8, 3, 30, 0, DateTimeKind.Unspecified), new DateTime(2024, 9, 16, 9, 2, 0, 0, DateTimeKind.Unspecified) });

            migrationBuilder.UpdateData(
                table: "TimeRegistrations",
                keyColumn: "TimeRegistrationId",
                keyValue: 280,
                columns: new[] { "EndTime", "StartTime" },
                values: new object[] { new DateTime(2024, 7, 1, 13, 12, 24, 0, DateTimeKind.Unspecified), new DateTime(2024, 6, 15, 10, 53, 16, 0, DateTimeKind.Unspecified) });

            migrationBuilder.UpdateData(
                table: "TimeRegistrations",
                keyColumn: "TimeRegistrationId",
                keyValue: 281,
                columns: new[] { "EndTime", "StartTime" },
                values: new object[] { new DateTime(2024, 12, 7, 18, 0, 18, 0, DateTimeKind.Unspecified), new DateTime(2024, 2, 3, 15, 6, 36, 0, DateTimeKind.Unspecified) });

            migrationBuilder.UpdateData(
                table: "TimeRegistrations",
                keyColumn: "TimeRegistrationId",
                keyValue: 282,
                columns: new[] { "EndTime", "StartTime" },
                values: new object[] { new DateTime(2024, 1, 16, 19, 34, 1, 0, DateTimeKind.Unspecified), new DateTime(2024, 3, 1, 2, 23, 10, 0, DateTimeKind.Unspecified) });

            migrationBuilder.UpdateData(
                table: "TimeRegistrations",
                keyColumn: "TimeRegistrationId",
                keyValue: 283,
                columns: new[] { "EndTime", "StartTime" },
                values: new object[] { new DateTime(2024, 3, 27, 19, 12, 42, 0, DateTimeKind.Unspecified), new DateTime(2024, 5, 4, 20, 54, 34, 0, DateTimeKind.Unspecified) });

            migrationBuilder.UpdateData(
                table: "TimeRegistrations",
                keyColumn: "TimeRegistrationId",
                keyValue: 284,
                columns: new[] { "EndTime", "StartTime" },
                values: new object[] { new DateTime(2024, 6, 17, 22, 27, 18, 0, DateTimeKind.Unspecified), new DateTime(2024, 10, 22, 0, 19, 41, 0, DateTimeKind.Unspecified) });

            migrationBuilder.UpdateData(
                table: "TimeRegistrations",
                keyColumn: "TimeRegistrationId",
                keyValue: 285,
                columns: new[] { "EndTime", "StartTime" },
                values: new object[] { new DateTime(2024, 1, 27, 1, 20, 1, 0, DateTimeKind.Unspecified), new DateTime(2024, 10, 30, 17, 51, 51, 0, DateTimeKind.Unspecified) });

            migrationBuilder.UpdateData(
                table: "TimeRegistrations",
                keyColumn: "TimeRegistrationId",
                keyValue: 286,
                columns: new[] { "EndTime", "StartTime" },
                values: new object[] { new DateTime(2024, 1, 27, 18, 48, 11, 0, DateTimeKind.Unspecified), new DateTime(2024, 3, 20, 2, 48, 24, 0, DateTimeKind.Unspecified) });

            migrationBuilder.UpdateData(
                table: "TimeRegistrations",
                keyColumn: "TimeRegistrationId",
                keyValue: 287,
                columns: new[] { "EndTime", "StartTime" },
                values: new object[] { new DateTime(2024, 4, 27, 21, 22, 29, 0, DateTimeKind.Unspecified), new DateTime(2024, 10, 1, 1, 59, 50, 0, DateTimeKind.Unspecified) });

            migrationBuilder.UpdateData(
                table: "TimeRegistrations",
                keyColumn: "TimeRegistrationId",
                keyValue: 288,
                columns: new[] { "EndTime", "StartTime" },
                values: new object[] { new DateTime(2024, 3, 14, 14, 21, 37, 0, DateTimeKind.Unspecified), new DateTime(2024, 12, 24, 3, 33, 0, 0, DateTimeKind.Unspecified) });

            migrationBuilder.UpdateData(
                table: "TimeRegistrations",
                keyColumn: "TimeRegistrationId",
                keyValue: 289,
                columns: new[] { "EndTime", "StartTime" },
                values: new object[] { new DateTime(2024, 1, 27, 0, 3, 31, 0, DateTimeKind.Unspecified), new DateTime(2024, 9, 23, 17, 12, 35, 0, DateTimeKind.Unspecified) });

            migrationBuilder.UpdateData(
                table: "TimeRegistrations",
                keyColumn: "TimeRegistrationId",
                keyValue: 290,
                columns: new[] { "EndTime", "StartTime" },
                values: new object[] { new DateTime(2024, 10, 29, 12, 55, 13, 0, DateTimeKind.Unspecified), new DateTime(2024, 4, 22, 4, 46, 47, 0, DateTimeKind.Unspecified) });

            migrationBuilder.UpdateData(
                table: "TimeRegistrations",
                keyColumn: "TimeRegistrationId",
                keyValue: 291,
                columns: new[] { "EndTime", "StartTime" },
                values: new object[] { new DateTime(2024, 4, 25, 4, 5, 47, 0, DateTimeKind.Unspecified), new DateTime(2024, 10, 14, 0, 59, 21, 0, DateTimeKind.Unspecified) });

            migrationBuilder.UpdateData(
                table: "TimeRegistrations",
                keyColumn: "TimeRegistrationId",
                keyValue: 292,
                columns: new[] { "EndTime", "StartTime" },
                values: new object[] { new DateTime(2024, 6, 26, 19, 27, 16, 0, DateTimeKind.Unspecified), new DateTime(2024, 8, 25, 23, 14, 8, 0, DateTimeKind.Unspecified) });

            migrationBuilder.UpdateData(
                table: "TimeRegistrations",
                keyColumn: "TimeRegistrationId",
                keyValue: 293,
                columns: new[] { "EndTime", "StartTime" },
                values: new object[] { new DateTime(2024, 3, 25, 19, 3, 26, 0, DateTimeKind.Unspecified), new DateTime(2024, 9, 14, 18, 45, 47, 0, DateTimeKind.Unspecified) });

            migrationBuilder.UpdateData(
                table: "TimeRegistrations",
                keyColumn: "TimeRegistrationId",
                keyValue: 294,
                columns: new[] { "EndTime", "StartTime" },
                values: new object[] { new DateTime(2024, 3, 25, 4, 10, 0, 0, DateTimeKind.Unspecified), new DateTime(2024, 4, 7, 2, 13, 30, 0, DateTimeKind.Unspecified) });

            migrationBuilder.UpdateData(
                table: "TimeRegistrations",
                keyColumn: "TimeRegistrationId",
                keyValue: 295,
                columns: new[] { "EndTime", "StartTime" },
                values: new object[] { new DateTime(2024, 10, 28, 12, 34, 41, 0, DateTimeKind.Unspecified), new DateTime(2024, 1, 2, 12, 51, 5, 0, DateTimeKind.Unspecified) });

            migrationBuilder.UpdateData(
                table: "TimeRegistrations",
                keyColumn: "TimeRegistrationId",
                keyValue: 296,
                columns: new[] { "EndTime", "StartTime" },
                values: new object[] { new DateTime(2024, 8, 7, 5, 13, 42, 0, DateTimeKind.Unspecified), new DateTime(2024, 10, 28, 9, 2, 5, 0, DateTimeKind.Unspecified) });

            migrationBuilder.UpdateData(
                table: "TimeRegistrations",
                keyColumn: "TimeRegistrationId",
                keyValue: 297,
                columns: new[] { "EndTime", "StartTime" },
                values: new object[] { new DateTime(2024, 3, 30, 19, 56, 55, 0, DateTimeKind.Unspecified), new DateTime(2024, 1, 9, 19, 7, 42, 0, DateTimeKind.Unspecified) });

            migrationBuilder.UpdateData(
                table: "TimeRegistrations",
                keyColumn: "TimeRegistrationId",
                keyValue: 298,
                columns: new[] { "EndTime", "StartTime" },
                values: new object[] { new DateTime(2024, 9, 17, 2, 30, 3, 0, DateTimeKind.Unspecified), new DateTime(2024, 2, 11, 1, 18, 59, 0, DateTimeKind.Unspecified) });

            migrationBuilder.UpdateData(
                table: "TimeRegistrations",
                keyColumn: "TimeRegistrationId",
                keyValue: 299,
                columns: new[] { "EndTime", "StartTime" },
                values: new object[] { new DateTime(2024, 6, 12, 0, 40, 21, 0, DateTimeKind.Unspecified), new DateTime(2024, 9, 4, 17, 32, 16, 0, DateTimeKind.Unspecified) });

            migrationBuilder.UpdateData(
                table: "TimeRegistrations",
                keyColumn: "TimeRegistrationId",
                keyValue: 300,
                columns: new[] { "EndTime", "StartTime" },
                values: new object[] { new DateTime(2024, 9, 18, 19, 35, 12, 0, DateTimeKind.Unspecified), new DateTime(2024, 6, 22, 3, 12, 17, 0, DateTimeKind.Unspecified) });

            migrationBuilder.UpdateData(
                table: "TimeRegistrations",
                keyColumn: "TimeRegistrationId",
                keyValue: 301,
                columns: new[] { "EndTime", "StartTime" },
                values: new object[] { new DateTime(2024, 3, 1, 8, 16, 40, 0, DateTimeKind.Unspecified), new DateTime(2024, 9, 16, 7, 32, 39, 0, DateTimeKind.Unspecified) });

            migrationBuilder.UpdateData(
                table: "TimeRegistrations",
                keyColumn: "TimeRegistrationId",
                keyValue: 302,
                columns: new[] { "EndTime", "StartTime" },
                values: new object[] { new DateTime(2024, 2, 19, 13, 8, 55, 0, DateTimeKind.Unspecified), new DateTime(2024, 6, 20, 19, 37, 19, 0, DateTimeKind.Unspecified) });

            migrationBuilder.UpdateData(
                table: "TimeRegistrations",
                keyColumn: "TimeRegistrationId",
                keyValue: 303,
                columns: new[] { "EndTime", "StartTime" },
                values: new object[] { new DateTime(2024, 11, 12, 23, 26, 54, 0, DateTimeKind.Unspecified), new DateTime(2024, 8, 29, 8, 10, 36, 0, DateTimeKind.Unspecified) });

            migrationBuilder.UpdateData(
                table: "TimeRegistrations",
                keyColumn: "TimeRegistrationId",
                keyValue: 304,
                columns: new[] { "EndTime", "StartTime" },
                values: new object[] { new DateTime(2024, 7, 16, 10, 55, 54, 0, DateTimeKind.Unspecified), new DateTime(2024, 10, 18, 18, 3, 59, 0, DateTimeKind.Unspecified) });

            migrationBuilder.UpdateData(
                table: "TimeRegistrations",
                keyColumn: "TimeRegistrationId",
                keyValue: 305,
                columns: new[] { "EndTime", "StartTime" },
                values: new object[] { new DateTime(2024, 8, 12, 8, 3, 21, 0, DateTimeKind.Unspecified), new DateTime(2024, 1, 9, 2, 4, 59, 0, DateTimeKind.Unspecified) });

            migrationBuilder.UpdateData(
                table: "TimeRegistrations",
                keyColumn: "TimeRegistrationId",
                keyValue: 306,
                columns: new[] { "EndTime", "StartTime" },
                values: new object[] { new DateTime(2024, 11, 23, 17, 42, 27, 0, DateTimeKind.Unspecified), new DateTime(2024, 11, 28, 15, 49, 4, 0, DateTimeKind.Unspecified) });

            migrationBuilder.UpdateData(
                table: "TimeRegistrations",
                keyColumn: "TimeRegistrationId",
                keyValue: 307,
                columns: new[] { "EndTime", "StartTime" },
                values: new object[] { new DateTime(2024, 7, 14, 14, 31, 55, 0, DateTimeKind.Unspecified), new DateTime(2024, 4, 25, 9, 52, 18, 0, DateTimeKind.Unspecified) });

            migrationBuilder.UpdateData(
                table: "TimeRegistrations",
                keyColumn: "TimeRegistrationId",
                keyValue: 308,
                columns: new[] { "EndTime", "StartTime" },
                values: new object[] { new DateTime(2024, 6, 11, 11, 14, 46, 0, DateTimeKind.Unspecified), new DateTime(2024, 11, 24, 13, 30, 46, 0, DateTimeKind.Unspecified) });

            migrationBuilder.UpdateData(
                table: "TimeRegistrations",
                keyColumn: "TimeRegistrationId",
                keyValue: 309,
                columns: new[] { "EndTime", "StartTime" },
                values: new object[] { new DateTime(2024, 7, 15, 5, 6, 49, 0, DateTimeKind.Unspecified), new DateTime(2024, 8, 8, 9, 1, 11, 0, DateTimeKind.Unspecified) });

            migrationBuilder.UpdateData(
                table: "TimeRegistrations",
                keyColumn: "TimeRegistrationId",
                keyValue: 310,
                columns: new[] { "EndTime", "StartTime" },
                values: new object[] { new DateTime(2024, 5, 7, 14, 25, 52, 0, DateTimeKind.Unspecified), new DateTime(2024, 9, 28, 3, 52, 1, 0, DateTimeKind.Unspecified) });

            migrationBuilder.UpdateData(
                table: "TimeRegistrations",
                keyColumn: "TimeRegistrationId",
                keyValue: 311,
                columns: new[] { "EndTime", "StartTime" },
                values: new object[] { new DateTime(2024, 4, 8, 5, 5, 16, 0, DateTimeKind.Unspecified), new DateTime(2024, 9, 24, 21, 2, 51, 0, DateTimeKind.Unspecified) });

            migrationBuilder.UpdateData(
                table: "TimeRegistrations",
                keyColumn: "TimeRegistrationId",
                keyValue: 312,
                columns: new[] { "EndTime", "StartTime" },
                values: new object[] { new DateTime(2024, 7, 22, 21, 36, 1, 0, DateTimeKind.Unspecified), new DateTime(2024, 7, 13, 18, 10, 5, 0, DateTimeKind.Unspecified) });

            migrationBuilder.UpdateData(
                table: "TimeRegistrations",
                keyColumn: "TimeRegistrationId",
                keyValue: 313,
                columns: new[] { "EndTime", "StartTime" },
                values: new object[] { new DateTime(2024, 3, 28, 0, 8, 28, 0, DateTimeKind.Unspecified), new DateTime(2024, 12, 7, 5, 9, 7, 0, DateTimeKind.Unspecified) });

            migrationBuilder.UpdateData(
                table: "TimeRegistrations",
                keyColumn: "TimeRegistrationId",
                keyValue: 314,
                columns: new[] { "EndTime", "StartTime" },
                values: new object[] { new DateTime(2024, 3, 11, 13, 6, 4, 0, DateTimeKind.Unspecified), new DateTime(2024, 7, 18, 18, 9, 59, 0, DateTimeKind.Unspecified) });

            migrationBuilder.UpdateData(
                table: "TimeRegistrations",
                keyColumn: "TimeRegistrationId",
                keyValue: 315,
                columns: new[] { "EndTime", "StartTime" },
                values: new object[] { new DateTime(2024, 7, 25, 12, 18, 10, 0, DateTimeKind.Unspecified), new DateTime(2024, 1, 4, 16, 34, 21, 0, DateTimeKind.Unspecified) });

            migrationBuilder.UpdateData(
                table: "TimeRegistrations",
                keyColumn: "TimeRegistrationId",
                keyValue: 316,
                columns: new[] { "EndTime", "StartTime" },
                values: new object[] { new DateTime(2024, 2, 12, 1, 32, 29, 0, DateTimeKind.Unspecified), new DateTime(2024, 9, 5, 22, 15, 13, 0, DateTimeKind.Unspecified) });

            migrationBuilder.UpdateData(
                table: "TimeRegistrations",
                keyColumn: "TimeRegistrationId",
                keyValue: 317,
                columns: new[] { "EndTime", "StartTime" },
                values: new object[] { new DateTime(2024, 6, 18, 3, 30, 30, 0, DateTimeKind.Unspecified), new DateTime(2024, 12, 30, 7, 19, 33, 0, DateTimeKind.Unspecified) });

            migrationBuilder.UpdateData(
                table: "TimeRegistrations",
                keyColumn: "TimeRegistrationId",
                keyValue: 318,
                columns: new[] { "EndTime", "StartTime" },
                values: new object[] { new DateTime(2024, 3, 31, 7, 37, 40, 0, DateTimeKind.Unspecified), new DateTime(2024, 10, 14, 8, 38, 54, 0, DateTimeKind.Unspecified) });

            migrationBuilder.UpdateData(
                table: "TimeRegistrations",
                keyColumn: "TimeRegistrationId",
                keyValue: 319,
                columns: new[] { "EndTime", "StartTime" },
                values: new object[] { new DateTime(2024, 11, 10, 11, 51, 2, 0, DateTimeKind.Unspecified), new DateTime(2024, 11, 22, 7, 29, 5, 0, DateTimeKind.Unspecified) });

            migrationBuilder.UpdateData(
                table: "TimeRegistrations",
                keyColumn: "TimeRegistrationId",
                keyValue: 320,
                columns: new[] { "EndTime", "StartTime" },
                values: new object[] { new DateTime(2024, 7, 29, 20, 4, 16, 0, DateTimeKind.Unspecified), new DateTime(2024, 3, 11, 7, 2, 16, 0, DateTimeKind.Unspecified) });

            migrationBuilder.UpdateData(
                table: "TimeRegistrations",
                keyColumn: "TimeRegistrationId",
                keyValue: 321,
                columns: new[] { "EndTime", "StartTime" },
                values: new object[] { new DateTime(2024, 4, 17, 21, 9, 54, 0, DateTimeKind.Unspecified), new DateTime(2024, 6, 7, 8, 38, 1, 0, DateTimeKind.Unspecified) });

            migrationBuilder.UpdateData(
                table: "TimeRegistrations",
                keyColumn: "TimeRegistrationId",
                keyValue: 322,
                columns: new[] { "EndTime", "StartTime" },
                values: new object[] { new DateTime(2024, 12, 22, 9, 32, 5, 0, DateTimeKind.Unspecified), new DateTime(2024, 6, 27, 5, 47, 41, 0, DateTimeKind.Unspecified) });

            migrationBuilder.UpdateData(
                table: "TimeRegistrations",
                keyColumn: "TimeRegistrationId",
                keyValue: 323,
                columns: new[] { "EndTime", "StartTime" },
                values: new object[] { new DateTime(2024, 7, 25, 0, 8, 0, 0, DateTimeKind.Unspecified), new DateTime(2024, 7, 12, 8, 45, 18, 0, DateTimeKind.Unspecified) });

            migrationBuilder.UpdateData(
                table: "TimeRegistrations",
                keyColumn: "TimeRegistrationId",
                keyValue: 324,
                columns: new[] { "EndTime", "StartTime" },
                values: new object[] { new DateTime(2024, 10, 16, 2, 3, 25, 0, DateTimeKind.Unspecified), new DateTime(2024, 10, 1, 15, 4, 43, 0, DateTimeKind.Unspecified) });

            migrationBuilder.UpdateData(
                table: "TimeRegistrations",
                keyColumn: "TimeRegistrationId",
                keyValue: 325,
                columns: new[] { "EndTime", "StartTime" },
                values: new object[] { new DateTime(2024, 1, 5, 9, 4, 0, 0, DateTimeKind.Unspecified), new DateTime(2024, 1, 20, 4, 1, 12, 0, DateTimeKind.Unspecified) });

            migrationBuilder.UpdateData(
                table: "TimeRegistrations",
                keyColumn: "TimeRegistrationId",
                keyValue: 326,
                columns: new[] { "EndTime", "StartTime" },
                values: new object[] { new DateTime(2024, 3, 26, 18, 2, 58, 0, DateTimeKind.Unspecified), new DateTime(2024, 3, 3, 2, 39, 2, 0, DateTimeKind.Unspecified) });

            migrationBuilder.UpdateData(
                table: "TimeRegistrations",
                keyColumn: "TimeRegistrationId",
                keyValue: 327,
                columns: new[] { "EndTime", "StartTime" },
                values: new object[] { new DateTime(2024, 7, 29, 5, 6, 46, 0, DateTimeKind.Unspecified), new DateTime(2024, 3, 27, 7, 37, 45, 0, DateTimeKind.Unspecified) });

            migrationBuilder.UpdateData(
                table: "TimeRegistrations",
                keyColumn: "TimeRegistrationId",
                keyValue: 328,
                columns: new[] { "EndTime", "StartTime" },
                values: new object[] { new DateTime(2024, 4, 22, 19, 57, 52, 0, DateTimeKind.Unspecified), new DateTime(2024, 8, 6, 12, 38, 41, 0, DateTimeKind.Unspecified) });

            migrationBuilder.UpdateData(
                table: "TimeRegistrations",
                keyColumn: "TimeRegistrationId",
                keyValue: 329,
                columns: new[] { "EndTime", "StartTime" },
                values: new object[] { new DateTime(2024, 9, 6, 14, 44, 55, 0, DateTimeKind.Unspecified), new DateTime(2024, 1, 9, 17, 48, 31, 0, DateTimeKind.Unspecified) });

            migrationBuilder.UpdateData(
                table: "TimeRegistrations",
                keyColumn: "TimeRegistrationId",
                keyValue: 330,
                columns: new[] { "EndTime", "StartTime" },
                values: new object[] { new DateTime(2024, 3, 16, 18, 12, 29, 0, DateTimeKind.Unspecified), new DateTime(2024, 1, 2, 14, 0, 25, 0, DateTimeKind.Unspecified) });

            migrationBuilder.UpdateData(
                table: "TimeRegistrations",
                keyColumn: "TimeRegistrationId",
                keyValue: 331,
                columns: new[] { "EndTime", "StartTime" },
                values: new object[] { new DateTime(2024, 1, 27, 8, 46, 33, 0, DateTimeKind.Unspecified), new DateTime(2024, 6, 17, 14, 4, 21, 0, DateTimeKind.Unspecified) });

            migrationBuilder.UpdateData(
                table: "TimeRegistrations",
                keyColumn: "TimeRegistrationId",
                keyValue: 332,
                columns: new[] { "EndTime", "StartTime" },
                values: new object[] { new DateTime(2024, 9, 14, 2, 14, 44, 0, DateTimeKind.Unspecified), new DateTime(2024, 7, 6, 20, 8, 51, 0, DateTimeKind.Unspecified) });

            migrationBuilder.UpdateData(
                table: "TimeRegistrations",
                keyColumn: "TimeRegistrationId",
                keyValue: 333,
                columns: new[] { "EndTime", "StartTime" },
                values: new object[] { new DateTime(2024, 2, 29, 21, 6, 19, 0, DateTimeKind.Unspecified), new DateTime(2024, 1, 17, 20, 24, 39, 0, DateTimeKind.Unspecified) });

            migrationBuilder.UpdateData(
                table: "TimeRegistrations",
                keyColumn: "TimeRegistrationId",
                keyValue: 334,
                columns: new[] { "EndTime", "StartTime" },
                values: new object[] { new DateTime(2024, 6, 15, 7, 48, 22, 0, DateTimeKind.Unspecified), new DateTime(2024, 11, 23, 23, 23, 24, 0, DateTimeKind.Unspecified) });

            migrationBuilder.UpdateData(
                table: "TimeRegistrations",
                keyColumn: "TimeRegistrationId",
                keyValue: 335,
                columns: new[] { "EndTime", "StartTime" },
                values: new object[] { new DateTime(2024, 8, 16, 19, 13, 48, 0, DateTimeKind.Unspecified), new DateTime(2024, 1, 22, 11, 39, 6, 0, DateTimeKind.Unspecified) });

            migrationBuilder.UpdateData(
                table: "TimeRegistrations",
                keyColumn: "TimeRegistrationId",
                keyValue: 336,
                columns: new[] { "EndTime", "StartTime" },
                values: new object[] { new DateTime(2024, 4, 29, 19, 39, 46, 0, DateTimeKind.Unspecified), new DateTime(2024, 4, 14, 16, 27, 13, 0, DateTimeKind.Unspecified) });

            migrationBuilder.UpdateData(
                table: "TimeRegistrations",
                keyColumn: "TimeRegistrationId",
                keyValue: 337,
                columns: new[] { "EndTime", "StartTime" },
                values: new object[] { new DateTime(2024, 1, 28, 3, 40, 14, 0, DateTimeKind.Unspecified), new DateTime(2024, 12, 28, 8, 3, 58, 0, DateTimeKind.Unspecified) });

            migrationBuilder.UpdateData(
                table: "TimeRegistrations",
                keyColumn: "TimeRegistrationId",
                keyValue: 338,
                columns: new[] { "EndTime", "StartTime" },
                values: new object[] { new DateTime(2024, 10, 19, 12, 9, 54, 0, DateTimeKind.Unspecified), new DateTime(2024, 9, 12, 16, 33, 36, 0, DateTimeKind.Unspecified) });

            migrationBuilder.UpdateData(
                table: "TimeRegistrations",
                keyColumn: "TimeRegistrationId",
                keyValue: 339,
                columns: new[] { "EndTime", "StartTime" },
                values: new object[] { new DateTime(2024, 2, 25, 20, 15, 21, 0, DateTimeKind.Unspecified), new DateTime(2024, 5, 23, 0, 42, 6, 0, DateTimeKind.Unspecified) });

            migrationBuilder.UpdateData(
                table: "TimeRegistrations",
                keyColumn: "TimeRegistrationId",
                keyValue: 340,
                columns: new[] { "EndTime", "StartTime" },
                values: new object[] { new DateTime(2024, 5, 25, 4, 38, 18, 0, DateTimeKind.Unspecified), new DateTime(2024, 2, 20, 14, 52, 16, 0, DateTimeKind.Unspecified) });

            migrationBuilder.UpdateData(
                table: "TimeRegistrations",
                keyColumn: "TimeRegistrationId",
                keyValue: 341,
                columns: new[] { "EndTime", "StartTime" },
                values: new object[] { new DateTime(2024, 2, 17, 21, 57, 26, 0, DateTimeKind.Unspecified), new DateTime(2024, 12, 25, 18, 33, 47, 0, DateTimeKind.Unspecified) });

            migrationBuilder.UpdateData(
                table: "TimeRegistrations",
                keyColumn: "TimeRegistrationId",
                keyValue: 342,
                columns: new[] { "EndTime", "StartTime" },
                values: new object[] { new DateTime(2024, 10, 25, 11, 11, 35, 0, DateTimeKind.Unspecified), new DateTime(2024, 9, 23, 21, 20, 18, 0, DateTimeKind.Unspecified) });

            migrationBuilder.UpdateData(
                table: "TimeRegistrations",
                keyColumn: "TimeRegistrationId",
                keyValue: 343,
                columns: new[] { "EndTime", "StartTime" },
                values: new object[] { new DateTime(2024, 3, 25, 20, 52, 9, 0, DateTimeKind.Unspecified), new DateTime(2024, 11, 21, 20, 30, 0, 0, DateTimeKind.Unspecified) });

            migrationBuilder.UpdateData(
                table: "TimeRegistrations",
                keyColumn: "TimeRegistrationId",
                keyValue: 344,
                columns: new[] { "EndTime", "StartTime" },
                values: new object[] { new DateTime(2024, 7, 5, 0, 48, 43, 0, DateTimeKind.Unspecified), new DateTime(2024, 6, 16, 19, 11, 30, 0, DateTimeKind.Unspecified) });

            migrationBuilder.UpdateData(
                table: "TimeRegistrations",
                keyColumn: "TimeRegistrationId",
                keyValue: 345,
                columns: new[] { "EndTime", "StartTime" },
                values: new object[] { new DateTime(2024, 8, 20, 18, 5, 25, 0, DateTimeKind.Unspecified), new DateTime(2024, 11, 2, 2, 40, 26, 0, DateTimeKind.Unspecified) });

            migrationBuilder.UpdateData(
                table: "TimeRegistrations",
                keyColumn: "TimeRegistrationId",
                keyValue: 346,
                columns: new[] { "EndTime", "StartTime" },
                values: new object[] { new DateTime(2024, 1, 26, 10, 17, 39, 0, DateTimeKind.Unspecified), new DateTime(2024, 11, 19, 14, 1, 17, 0, DateTimeKind.Unspecified) });

            migrationBuilder.UpdateData(
                table: "TimeRegistrations",
                keyColumn: "TimeRegistrationId",
                keyValue: 347,
                columns: new[] { "EndTime", "StartTime" },
                values: new object[] { new DateTime(2024, 3, 30, 16, 31, 20, 0, DateTimeKind.Unspecified), new DateTime(2024, 12, 9, 22, 0, 36, 0, DateTimeKind.Unspecified) });

            migrationBuilder.UpdateData(
                table: "TimeRegistrations",
                keyColumn: "TimeRegistrationId",
                keyValue: 348,
                columns: new[] { "EndTime", "StartTime" },
                values: new object[] { new DateTime(2024, 10, 17, 17, 3, 39, 0, DateTimeKind.Unspecified), new DateTime(2024, 2, 19, 20, 58, 19, 0, DateTimeKind.Unspecified) });

            migrationBuilder.UpdateData(
                table: "TimeRegistrations",
                keyColumn: "TimeRegistrationId",
                keyValue: 349,
                columns: new[] { "EndTime", "StartTime" },
                values: new object[] { new DateTime(2024, 7, 25, 3, 48, 9, 0, DateTimeKind.Unspecified), new DateTime(2024, 7, 5, 23, 7, 20, 0, DateTimeKind.Unspecified) });

            migrationBuilder.UpdateData(
                table: "TimeRegistrations",
                keyColumn: "TimeRegistrationId",
                keyValue: 350,
                columns: new[] { "EndTime", "StartTime" },
                values: new object[] { new DateTime(2024, 2, 1, 22, 33, 14, 0, DateTimeKind.Unspecified), new DateTime(2024, 11, 16, 16, 1, 42, 0, DateTimeKind.Unspecified) });

            migrationBuilder.UpdateData(
                table: "TimeRegistrations",
                keyColumn: "TimeRegistrationId",
                keyValue: 351,
                columns: new[] { "EndTime", "StartTime" },
                values: new object[] { new DateTime(2024, 12, 4, 10, 56, 51, 0, DateTimeKind.Unspecified), new DateTime(2024, 7, 31, 22, 31, 6, 0, DateTimeKind.Unspecified) });

            migrationBuilder.UpdateData(
                table: "TimeRegistrations",
                keyColumn: "TimeRegistrationId",
                keyValue: 352,
                columns: new[] { "EndTime", "StartTime" },
                values: new object[] { new DateTime(2024, 4, 15, 21, 48, 30, 0, DateTimeKind.Unspecified), new DateTime(2024, 5, 1, 22, 12, 15, 0, DateTimeKind.Unspecified) });

            migrationBuilder.UpdateData(
                table: "TimeRegistrations",
                keyColumn: "TimeRegistrationId",
                keyValue: 353,
                columns: new[] { "EndTime", "StartTime" },
                values: new object[] { new DateTime(2024, 10, 21, 5, 14, 26, 0, DateTimeKind.Unspecified), new DateTime(2024, 5, 12, 9, 8, 27, 0, DateTimeKind.Unspecified) });

            migrationBuilder.UpdateData(
                table: "TimeRegistrations",
                keyColumn: "TimeRegistrationId",
                keyValue: 354,
                columns: new[] { "EndTime", "StartTime" },
                values: new object[] { new DateTime(2024, 9, 25, 21, 36, 2, 0, DateTimeKind.Unspecified), new DateTime(2024, 1, 2, 11, 35, 15, 0, DateTimeKind.Unspecified) });

            migrationBuilder.UpdateData(
                table: "TimeRegistrations",
                keyColumn: "TimeRegistrationId",
                keyValue: 355,
                columns: new[] { "EndTime", "StartTime" },
                values: new object[] { new DateTime(2024, 9, 5, 11, 47, 11, 0, DateTimeKind.Unspecified), new DateTime(2024, 3, 1, 17, 0, 31, 0, DateTimeKind.Unspecified) });

            migrationBuilder.UpdateData(
                table: "TimeRegistrations",
                keyColumn: "TimeRegistrationId",
                keyValue: 356,
                columns: new[] { "EndTime", "StartTime" },
                values: new object[] { new DateTime(2024, 3, 31, 0, 29, 45, 0, DateTimeKind.Unspecified), new DateTime(2024, 3, 26, 10, 41, 13, 0, DateTimeKind.Unspecified) });

            migrationBuilder.UpdateData(
                table: "TimeRegistrations",
                keyColumn: "TimeRegistrationId",
                keyValue: 357,
                columns: new[] { "EndTime", "StartTime" },
                values: new object[] { new DateTime(2024, 3, 8, 5, 15, 35, 0, DateTimeKind.Unspecified), new DateTime(2024, 2, 3, 4, 57, 9, 0, DateTimeKind.Unspecified) });

            migrationBuilder.UpdateData(
                table: "TimeRegistrations",
                keyColumn: "TimeRegistrationId",
                keyValue: 358,
                columns: new[] { "EndTime", "StartTime" },
                values: new object[] { new DateTime(2024, 5, 31, 11, 28, 17, 0, DateTimeKind.Unspecified), new DateTime(2024, 9, 4, 21, 20, 36, 0, DateTimeKind.Unspecified) });

            migrationBuilder.UpdateData(
                table: "TimeRegistrations",
                keyColumn: "TimeRegistrationId",
                keyValue: 359,
                columns: new[] { "EndTime", "StartTime" },
                values: new object[] { new DateTime(2024, 11, 10, 19, 42, 51, 0, DateTimeKind.Unspecified), new DateTime(2024, 3, 19, 4, 55, 3, 0, DateTimeKind.Unspecified) });

            migrationBuilder.UpdateData(
                table: "TimeRegistrations",
                keyColumn: "TimeRegistrationId",
                keyValue: 360,
                columns: new[] { "EndTime", "StartTime" },
                values: new object[] { new DateTime(2024, 11, 7, 8, 32, 56, 0, DateTimeKind.Unspecified), new DateTime(2024, 7, 1, 11, 55, 56, 0, DateTimeKind.Unspecified) });

            migrationBuilder.UpdateData(
                table: "TimeRegistrations",
                keyColumn: "TimeRegistrationId",
                keyValue: 361,
                columns: new[] { "EndTime", "StartTime" },
                values: new object[] { new DateTime(2024, 3, 10, 0, 31, 14, 0, DateTimeKind.Unspecified), new DateTime(2024, 4, 23, 6, 58, 8, 0, DateTimeKind.Unspecified) });

            migrationBuilder.UpdateData(
                table: "TimeRegistrations",
                keyColumn: "TimeRegistrationId",
                keyValue: 362,
                columns: new[] { "EndTime", "StartTime" },
                values: new object[] { new DateTime(2024, 4, 10, 8, 12, 46, 0, DateTimeKind.Unspecified), new DateTime(2024, 6, 7, 13, 7, 14, 0, DateTimeKind.Unspecified) });

            migrationBuilder.UpdateData(
                table: "TimeRegistrations",
                keyColumn: "TimeRegistrationId",
                keyValue: 363,
                columns: new[] { "EndTime", "StartTime" },
                values: new object[] { new DateTime(2024, 3, 7, 2, 54, 25, 0, DateTimeKind.Unspecified), new DateTime(2024, 10, 23, 3, 42, 44, 0, DateTimeKind.Unspecified) });

            migrationBuilder.UpdateData(
                table: "TimeRegistrations",
                keyColumn: "TimeRegistrationId",
                keyValue: 364,
                columns: new[] { "EndTime", "StartTime" },
                values: new object[] { new DateTime(2024, 12, 11, 6, 38, 11, 0, DateTimeKind.Unspecified), new DateTime(2024, 7, 29, 9, 14, 51, 0, DateTimeKind.Unspecified) });

            migrationBuilder.UpdateData(
                table: "TimeRegistrations",
                keyColumn: "TimeRegistrationId",
                keyValue: 365,
                columns: new[] { "EndTime", "StartTime" },
                values: new object[] { new DateTime(2024, 12, 13, 10, 23, 3, 0, DateTimeKind.Unspecified), new DateTime(2024, 5, 24, 3, 38, 2, 0, DateTimeKind.Unspecified) });

            migrationBuilder.UpdateData(
                table: "TimeRegistrations",
                keyColumn: "TimeRegistrationId",
                keyValue: 366,
                columns: new[] { "EndTime", "StartTime" },
                values: new object[] { new DateTime(2024, 12, 23, 22, 3, 31, 0, DateTimeKind.Unspecified), new DateTime(2024, 8, 11, 2, 6, 7, 0, DateTimeKind.Unspecified) });

            migrationBuilder.UpdateData(
                table: "TimeRegistrations",
                keyColumn: "TimeRegistrationId",
                keyValue: 367,
                columns: new[] { "EndTime", "StartTime" },
                values: new object[] { new DateTime(2024, 12, 24, 0, 44, 4, 0, DateTimeKind.Unspecified), new DateTime(2024, 3, 2, 23, 41, 42, 0, DateTimeKind.Unspecified) });

            migrationBuilder.UpdateData(
                table: "TimeRegistrations",
                keyColumn: "TimeRegistrationId",
                keyValue: 368,
                columns: new[] { "EndTime", "StartTime" },
                values: new object[] { new DateTime(2024, 8, 11, 23, 55, 55, 0, DateTimeKind.Unspecified), new DateTime(2024, 12, 8, 8, 9, 32, 0, DateTimeKind.Unspecified) });

            migrationBuilder.UpdateData(
                table: "TimeRegistrations",
                keyColumn: "TimeRegistrationId",
                keyValue: 369,
                columns: new[] { "EndTime", "StartTime" },
                values: new object[] { new DateTime(2024, 11, 10, 9, 26, 27, 0, DateTimeKind.Unspecified), new DateTime(2024, 10, 4, 21, 9, 41, 0, DateTimeKind.Unspecified) });

            migrationBuilder.UpdateData(
                table: "TimeRegistrations",
                keyColumn: "TimeRegistrationId",
                keyValue: 370,
                columns: new[] { "EndTime", "StartTime" },
                values: new object[] { new DateTime(2024, 2, 13, 16, 57, 50, 0, DateTimeKind.Unspecified), new DateTime(2024, 10, 1, 14, 38, 47, 0, DateTimeKind.Unspecified) });

            migrationBuilder.UpdateData(
                table: "TimeRegistrations",
                keyColumn: "TimeRegistrationId",
                keyValue: 371,
                columns: new[] { "EndTime", "StartTime" },
                values: new object[] { new DateTime(2024, 2, 24, 20, 40, 48, 0, DateTimeKind.Unspecified), new DateTime(2024, 5, 14, 3, 36, 11, 0, DateTimeKind.Unspecified) });

            migrationBuilder.UpdateData(
                table: "TimeRegistrations",
                keyColumn: "TimeRegistrationId",
                keyValue: 372,
                columns: new[] { "EndTime", "StartTime" },
                values: new object[] { new DateTime(2024, 5, 19, 20, 3, 25, 0, DateTimeKind.Unspecified), new DateTime(2024, 9, 20, 3, 57, 28, 0, DateTimeKind.Unspecified) });

            migrationBuilder.UpdateData(
                table: "TimeRegistrations",
                keyColumn: "TimeRegistrationId",
                keyValue: 373,
                columns: new[] { "EndTime", "StartTime" },
                values: new object[] { new DateTime(2024, 1, 14, 5, 5, 51, 0, DateTimeKind.Unspecified), new DateTime(2024, 3, 13, 23, 4, 18, 0, DateTimeKind.Unspecified) });

            migrationBuilder.UpdateData(
                table: "TimeRegistrations",
                keyColumn: "TimeRegistrationId",
                keyValue: 374,
                columns: new[] { "EndTime", "StartTime" },
                values: new object[] { new DateTime(2024, 9, 4, 16, 15, 16, 0, DateTimeKind.Unspecified), new DateTime(2024, 7, 25, 23, 35, 8, 0, DateTimeKind.Unspecified) });

            migrationBuilder.UpdateData(
                table: "TimeRegistrations",
                keyColumn: "TimeRegistrationId",
                keyValue: 375,
                columns: new[] { "EndTime", "StartTime" },
                values: new object[] { new DateTime(2024, 10, 20, 19, 41, 51, 0, DateTimeKind.Unspecified), new DateTime(2024, 5, 18, 10, 9, 3, 0, DateTimeKind.Unspecified) });

            migrationBuilder.UpdateData(
                table: "TimeRegistrations",
                keyColumn: "TimeRegistrationId",
                keyValue: 376,
                columns: new[] { "EndTime", "StartTime" },
                values: new object[] { new DateTime(2024, 5, 17, 21, 50, 34, 0, DateTimeKind.Unspecified), new DateTime(2024, 1, 7, 4, 4, 55, 0, DateTimeKind.Unspecified) });

            migrationBuilder.UpdateData(
                table: "TimeRegistrations",
                keyColumn: "TimeRegistrationId",
                keyValue: 377,
                columns: new[] { "EndTime", "StartTime" },
                values: new object[] { new DateTime(2024, 1, 17, 12, 5, 30, 0, DateTimeKind.Unspecified), new DateTime(2024, 11, 4, 7, 50, 6, 0, DateTimeKind.Unspecified) });

            migrationBuilder.UpdateData(
                table: "TimeRegistrations",
                keyColumn: "TimeRegistrationId",
                keyValue: 378,
                columns: new[] { "EndTime", "StartTime" },
                values: new object[] { new DateTime(2024, 9, 26, 20, 58, 45, 0, DateTimeKind.Unspecified), new DateTime(2024, 8, 17, 2, 10, 55, 0, DateTimeKind.Unspecified) });

            migrationBuilder.UpdateData(
                table: "TimeRegistrations",
                keyColumn: "TimeRegistrationId",
                keyValue: 379,
                columns: new[] { "EndTime", "StartTime" },
                values: new object[] { new DateTime(2024, 6, 6, 15, 8, 44, 0, DateTimeKind.Unspecified), new DateTime(2024, 7, 18, 6, 23, 16, 0, DateTimeKind.Unspecified) });

            migrationBuilder.UpdateData(
                table: "TimeRegistrations",
                keyColumn: "TimeRegistrationId",
                keyValue: 380,
                columns: new[] { "EndTime", "StartTime" },
                values: new object[] { new DateTime(2024, 1, 10, 11, 53, 4, 0, DateTimeKind.Unspecified), new DateTime(2024, 2, 19, 4, 52, 30, 0, DateTimeKind.Unspecified) });

            migrationBuilder.UpdateData(
                table: "TimeRegistrations",
                keyColumn: "TimeRegistrationId",
                keyValue: 381,
                columns: new[] { "EndTime", "StartTime" },
                values: new object[] { new DateTime(2024, 3, 10, 5, 40, 46, 0, DateTimeKind.Unspecified), new DateTime(2024, 3, 17, 8, 46, 53, 0, DateTimeKind.Unspecified) });

            migrationBuilder.UpdateData(
                table: "TimeRegistrations",
                keyColumn: "TimeRegistrationId",
                keyValue: 382,
                columns: new[] { "EndTime", "StartTime" },
                values: new object[] { new DateTime(2024, 5, 12, 13, 6, 43, 0, DateTimeKind.Unspecified), new DateTime(2024, 2, 13, 16, 27, 27, 0, DateTimeKind.Unspecified) });

            migrationBuilder.UpdateData(
                table: "TimeRegistrations",
                keyColumn: "TimeRegistrationId",
                keyValue: 383,
                columns: new[] { "EndTime", "StartTime" },
                values: new object[] { new DateTime(2024, 1, 4, 12, 14, 59, 0, DateTimeKind.Unspecified), new DateTime(2024, 1, 26, 20, 3, 59, 0, DateTimeKind.Unspecified) });

            migrationBuilder.UpdateData(
                table: "TimeRegistrations",
                keyColumn: "TimeRegistrationId",
                keyValue: 384,
                columns: new[] { "EndTime", "StartTime" },
                values: new object[] { new DateTime(2024, 6, 23, 13, 48, 54, 0, DateTimeKind.Unspecified), new DateTime(2024, 6, 9, 5, 39, 31, 0, DateTimeKind.Unspecified) });

            migrationBuilder.UpdateData(
                table: "TimeRegistrations",
                keyColumn: "TimeRegistrationId",
                keyValue: 385,
                columns: new[] { "EndTime", "StartTime" },
                values: new object[] { new DateTime(2024, 11, 29, 4, 14, 42, 0, DateTimeKind.Unspecified), new DateTime(2024, 9, 17, 6, 38, 21, 0, DateTimeKind.Unspecified) });

            migrationBuilder.UpdateData(
                table: "TimeRegistrations",
                keyColumn: "TimeRegistrationId",
                keyValue: 386,
                columns: new[] { "EndTime", "StartTime" },
                values: new object[] { new DateTime(2024, 8, 25, 18, 43, 50, 0, DateTimeKind.Unspecified), new DateTime(2024, 12, 19, 8, 49, 5, 0, DateTimeKind.Unspecified) });

            migrationBuilder.UpdateData(
                table: "TimeRegistrations",
                keyColumn: "TimeRegistrationId",
                keyValue: 387,
                columns: new[] { "EndTime", "StartTime" },
                values: new object[] { new DateTime(2024, 7, 31, 11, 51, 3, 0, DateTimeKind.Unspecified), new DateTime(2024, 6, 30, 22, 51, 2, 0, DateTimeKind.Unspecified) });

            migrationBuilder.UpdateData(
                table: "TimeRegistrations",
                keyColumn: "TimeRegistrationId",
                keyValue: 388,
                columns: new[] { "EndTime", "StartTime" },
                values: new object[] { new DateTime(2024, 11, 16, 15, 41, 49, 0, DateTimeKind.Unspecified), new DateTime(2024, 2, 5, 2, 1, 2, 0, DateTimeKind.Unspecified) });

            migrationBuilder.UpdateData(
                table: "TimeRegistrations",
                keyColumn: "TimeRegistrationId",
                keyValue: 389,
                columns: new[] { "EndTime", "StartTime" },
                values: new object[] { new DateTime(2024, 10, 21, 3, 18, 50, 0, DateTimeKind.Unspecified), new DateTime(2024, 2, 21, 9, 28, 4, 0, DateTimeKind.Unspecified) });

            migrationBuilder.UpdateData(
                table: "TimeRegistrations",
                keyColumn: "TimeRegistrationId",
                keyValue: 390,
                columns: new[] { "EndTime", "StartTime" },
                values: new object[] { new DateTime(2024, 4, 1, 16, 11, 12, 0, DateTimeKind.Unspecified), new DateTime(2024, 7, 28, 0, 17, 24, 0, DateTimeKind.Unspecified) });

            migrationBuilder.UpdateData(
                table: "TimeRegistrations",
                keyColumn: "TimeRegistrationId",
                keyValue: 391,
                columns: new[] { "EndTime", "StartTime" },
                values: new object[] { new DateTime(2024, 9, 26, 21, 46, 38, 0, DateTimeKind.Unspecified), new DateTime(2024, 12, 27, 4, 32, 17, 0, DateTimeKind.Unspecified) });

            migrationBuilder.UpdateData(
                table: "TimeRegistrations",
                keyColumn: "TimeRegistrationId",
                keyValue: 392,
                columns: new[] { "EndTime", "StartTime" },
                values: new object[] { new DateTime(2024, 8, 7, 14, 41, 9, 0, DateTimeKind.Unspecified), new DateTime(2024, 6, 12, 12, 50, 59, 0, DateTimeKind.Unspecified) });

            migrationBuilder.UpdateData(
                table: "TimeRegistrations",
                keyColumn: "TimeRegistrationId",
                keyValue: 393,
                columns: new[] { "EndTime", "StartTime" },
                values: new object[] { new DateTime(2024, 4, 10, 5, 49, 24, 0, DateTimeKind.Unspecified), new DateTime(2024, 12, 16, 6, 56, 46, 0, DateTimeKind.Unspecified) });

            migrationBuilder.UpdateData(
                table: "TimeRegistrations",
                keyColumn: "TimeRegistrationId",
                keyValue: 394,
                columns: new[] { "EndTime", "StartTime" },
                values: new object[] { new DateTime(2024, 6, 14, 4, 57, 11, 0, DateTimeKind.Unspecified), new DateTime(2024, 4, 15, 4, 58, 2, 0, DateTimeKind.Unspecified) });

            migrationBuilder.UpdateData(
                table: "TimeRegistrations",
                keyColumn: "TimeRegistrationId",
                keyValue: 395,
                columns: new[] { "EndTime", "StartTime" },
                values: new object[] { new DateTime(2024, 7, 2, 7, 24, 29, 0, DateTimeKind.Unspecified), new DateTime(2024, 2, 9, 17, 41, 31, 0, DateTimeKind.Unspecified) });

            migrationBuilder.UpdateData(
                table: "TimeRegistrations",
                keyColumn: "TimeRegistrationId",
                keyValue: 396,
                columns: new[] { "EndTime", "StartTime" },
                values: new object[] { new DateTime(2024, 6, 20, 12, 23, 35, 0, DateTimeKind.Unspecified), new DateTime(2024, 10, 19, 20, 10, 54, 0, DateTimeKind.Unspecified) });

            migrationBuilder.UpdateData(
                table: "TimeRegistrations",
                keyColumn: "TimeRegistrationId",
                keyValue: 397,
                columns: new[] { "EndTime", "StartTime" },
                values: new object[] { new DateTime(2024, 4, 16, 14, 47, 53, 0, DateTimeKind.Unspecified), new DateTime(2024, 6, 8, 13, 14, 2, 0, DateTimeKind.Unspecified) });

            migrationBuilder.UpdateData(
                table: "TimeRegistrations",
                keyColumn: "TimeRegistrationId",
                keyValue: 398,
                columns: new[] { "EndTime", "StartTime" },
                values: new object[] { new DateTime(2024, 5, 27, 12, 48, 17, 0, DateTimeKind.Unspecified), new DateTime(2024, 1, 24, 20, 15, 43, 0, DateTimeKind.Unspecified) });

            migrationBuilder.UpdateData(
                table: "TimeRegistrations",
                keyColumn: "TimeRegistrationId",
                keyValue: 399,
                columns: new[] { "EndTime", "StartTime" },
                values: new object[] { new DateTime(2024, 6, 27, 23, 28, 25, 0, DateTimeKind.Unspecified), new DateTime(2024, 5, 16, 18, 32, 59, 0, DateTimeKind.Unspecified) });

            migrationBuilder.UpdateData(
                table: "TimeRegistrations",
                keyColumn: "TimeRegistrationId",
                keyValue: 400,
                columns: new[] { "EndTime", "StartTime" },
                values: new object[] { new DateTime(2024, 9, 29, 15, 40, 4, 0, DateTimeKind.Unspecified), new DateTime(2024, 1, 14, 16, 0, 28, 0, DateTimeKind.Unspecified) });

            migrationBuilder.UpdateData(
                table: "TimeRegistrations",
                keyColumn: "TimeRegistrationId",
                keyValue: 401,
                columns: new[] { "EndTime", "StartTime" },
                values: new object[] { new DateTime(2024, 1, 6, 14, 43, 43, 0, DateTimeKind.Unspecified), new DateTime(2024, 3, 6, 11, 47, 56, 0, DateTimeKind.Unspecified) });

            migrationBuilder.UpdateData(
                table: "TimeRegistrations",
                keyColumn: "TimeRegistrationId",
                keyValue: 402,
                columns: new[] { "EndTime", "StartTime" },
                values: new object[] { new DateTime(2024, 11, 23, 15, 43, 48, 0, DateTimeKind.Unspecified), new DateTime(2024, 8, 3, 19, 44, 28, 0, DateTimeKind.Unspecified) });

            migrationBuilder.UpdateData(
                table: "TimeRegistrations",
                keyColumn: "TimeRegistrationId",
                keyValue: 403,
                columns: new[] { "EndTime", "StartTime" },
                values: new object[] { new DateTime(2024, 1, 23, 0, 25, 57, 0, DateTimeKind.Unspecified), new DateTime(2024, 9, 14, 23, 41, 28, 0, DateTimeKind.Unspecified) });

            migrationBuilder.UpdateData(
                table: "TimeRegistrations",
                keyColumn: "TimeRegistrationId",
                keyValue: 404,
                columns: new[] { "EndTime", "StartTime" },
                values: new object[] { new DateTime(2024, 7, 9, 15, 19, 22, 0, DateTimeKind.Unspecified), new DateTime(2024, 2, 13, 8, 14, 31, 0, DateTimeKind.Unspecified) });

            migrationBuilder.UpdateData(
                table: "TimeRegistrations",
                keyColumn: "TimeRegistrationId",
                keyValue: 405,
                columns: new[] { "EndTime", "StartTime" },
                values: new object[] { new DateTime(2024, 2, 2, 18, 51, 41, 0, DateTimeKind.Unspecified), new DateTime(2024, 7, 31, 15, 0, 25, 0, DateTimeKind.Unspecified) });

            migrationBuilder.UpdateData(
                table: "TimeRegistrations",
                keyColumn: "TimeRegistrationId",
                keyValue: 406,
                columns: new[] { "EndTime", "StartTime" },
                values: new object[] { new DateTime(2024, 10, 23, 13, 5, 14, 0, DateTimeKind.Unspecified), new DateTime(2024, 12, 30, 23, 48, 10, 0, DateTimeKind.Unspecified) });

            migrationBuilder.UpdateData(
                table: "TimeRegistrations",
                keyColumn: "TimeRegistrationId",
                keyValue: 407,
                columns: new[] { "EndTime", "StartTime" },
                values: new object[] { new DateTime(2024, 9, 27, 5, 13, 30, 0, DateTimeKind.Unspecified), new DateTime(2024, 7, 8, 12, 43, 4, 0, DateTimeKind.Unspecified) });

            migrationBuilder.UpdateData(
                table: "TimeRegistrations",
                keyColumn: "TimeRegistrationId",
                keyValue: 408,
                columns: new[] { "EndTime", "StartTime" },
                values: new object[] { new DateTime(2024, 3, 25, 23, 54, 11, 0, DateTimeKind.Unspecified), new DateTime(2024, 3, 3, 22, 45, 59, 0, DateTimeKind.Unspecified) });

            migrationBuilder.UpdateData(
                table: "TimeRegistrations",
                keyColumn: "TimeRegistrationId",
                keyValue: 409,
                columns: new[] { "EndTime", "StartTime" },
                values: new object[] { new DateTime(2024, 5, 19, 21, 55, 53, 0, DateTimeKind.Unspecified), new DateTime(2024, 6, 5, 10, 56, 26, 0, DateTimeKind.Unspecified) });

            migrationBuilder.UpdateData(
                table: "TimeRegistrations",
                keyColumn: "TimeRegistrationId",
                keyValue: 410,
                columns: new[] { "EndTime", "StartTime" },
                values: new object[] { new DateTime(2024, 3, 14, 10, 34, 47, 0, DateTimeKind.Unspecified), new DateTime(2024, 7, 24, 8, 3, 30, 0, DateTimeKind.Unspecified) });

            migrationBuilder.UpdateData(
                table: "TimeRegistrations",
                keyColumn: "TimeRegistrationId",
                keyValue: 411,
                columns: new[] { "EndTime", "StartTime" },
                values: new object[] { new DateTime(2024, 2, 21, 5, 21, 24, 0, DateTimeKind.Unspecified), new DateTime(2024, 10, 29, 9, 50, 20, 0, DateTimeKind.Unspecified) });

            migrationBuilder.UpdateData(
                table: "TimeRegistrations",
                keyColumn: "TimeRegistrationId",
                keyValue: 412,
                columns: new[] { "EndTime", "StartTime" },
                values: new object[] { new DateTime(2024, 3, 4, 17, 33, 35, 0, DateTimeKind.Unspecified), new DateTime(2024, 6, 22, 20, 26, 30, 0, DateTimeKind.Unspecified) });

            migrationBuilder.UpdateData(
                table: "TimeRegistrations",
                keyColumn: "TimeRegistrationId",
                keyValue: 413,
                columns: new[] { "EndTime", "StartTime" },
                values: new object[] { new DateTime(2024, 7, 11, 23, 38, 6, 0, DateTimeKind.Unspecified), new DateTime(2024, 3, 18, 4, 4, 17, 0, DateTimeKind.Unspecified) });

            migrationBuilder.UpdateData(
                table: "TimeRegistrations",
                keyColumn: "TimeRegistrationId",
                keyValue: 414,
                columns: new[] { "EndTime", "StartTime" },
                values: new object[] { new DateTime(2024, 4, 1, 8, 29, 49, 0, DateTimeKind.Unspecified), new DateTime(2024, 9, 24, 22, 6, 38, 0, DateTimeKind.Unspecified) });

            migrationBuilder.UpdateData(
                table: "TimeRegistrations",
                keyColumn: "TimeRegistrationId",
                keyValue: 415,
                columns: new[] { "EndTime", "StartTime" },
                values: new object[] { new DateTime(2024, 7, 2, 16, 12, 37, 0, DateTimeKind.Unspecified), new DateTime(2024, 8, 30, 10, 10, 1, 0, DateTimeKind.Unspecified) });

            migrationBuilder.UpdateData(
                table: "TimeRegistrations",
                keyColumn: "TimeRegistrationId",
                keyValue: 416,
                columns: new[] { "EndTime", "StartTime" },
                values: new object[] { new DateTime(2024, 11, 24, 10, 59, 45, 0, DateTimeKind.Unspecified), new DateTime(2024, 9, 21, 15, 11, 16, 0, DateTimeKind.Unspecified) });

            migrationBuilder.UpdateData(
                table: "TimeRegistrations",
                keyColumn: "TimeRegistrationId",
                keyValue: 417,
                columns: new[] { "EndTime", "StartTime" },
                values: new object[] { new DateTime(2024, 2, 29, 18, 31, 49, 0, DateTimeKind.Unspecified), new DateTime(2024, 9, 15, 17, 37, 6, 0, DateTimeKind.Unspecified) });

            migrationBuilder.UpdateData(
                table: "TimeRegistrations",
                keyColumn: "TimeRegistrationId",
                keyValue: 418,
                columns: new[] { "EndTime", "StartTime" },
                values: new object[] { new DateTime(2024, 2, 22, 7, 45, 39, 0, DateTimeKind.Unspecified), new DateTime(2024, 8, 30, 6, 8, 26, 0, DateTimeKind.Unspecified) });

            migrationBuilder.UpdateData(
                table: "TimeRegistrations",
                keyColumn: "TimeRegistrationId",
                keyValue: 419,
                columns: new[] { "EndTime", "StartTime" },
                values: new object[] { new DateTime(2024, 5, 17, 23, 22, 38, 0, DateTimeKind.Unspecified), new DateTime(2024, 6, 4, 17, 53, 28, 0, DateTimeKind.Unspecified) });

            migrationBuilder.UpdateData(
                table: "TimeRegistrations",
                keyColumn: "TimeRegistrationId",
                keyValue: 420,
                columns: new[] { "EndTime", "StartTime" },
                values: new object[] { new DateTime(2024, 6, 14, 6, 6, 43, 0, DateTimeKind.Unspecified), new DateTime(2024, 8, 5, 6, 46, 22, 0, DateTimeKind.Unspecified) });

            migrationBuilder.UpdateData(
                table: "TimeRegistrations",
                keyColumn: "TimeRegistrationId",
                keyValue: 421,
                columns: new[] { "EndTime", "StartTime" },
                values: new object[] { new DateTime(2024, 7, 14, 11, 32, 39, 0, DateTimeKind.Unspecified), new DateTime(2024, 11, 19, 23, 45, 41, 0, DateTimeKind.Unspecified) });

            migrationBuilder.UpdateData(
                table: "TimeRegistrations",
                keyColumn: "TimeRegistrationId",
                keyValue: 422,
                columns: new[] { "EndTime", "StartTime" },
                values: new object[] { new DateTime(2024, 6, 29, 15, 41, 3, 0, DateTimeKind.Unspecified), new DateTime(2024, 1, 13, 14, 53, 7, 0, DateTimeKind.Unspecified) });

            migrationBuilder.UpdateData(
                table: "TimeRegistrations",
                keyColumn: "TimeRegistrationId",
                keyValue: 423,
                columns: new[] { "EndTime", "StartTime" },
                values: new object[] { new DateTime(2024, 2, 28, 17, 40, 37, 0, DateTimeKind.Unspecified), new DateTime(2024, 11, 9, 9, 1, 44, 0, DateTimeKind.Unspecified) });

            migrationBuilder.UpdateData(
                table: "TimeRegistrations",
                keyColumn: "TimeRegistrationId",
                keyValue: 424,
                columns: new[] { "EndTime", "StartTime" },
                values: new object[] { new DateTime(2024, 7, 22, 15, 23, 18, 0, DateTimeKind.Unspecified), new DateTime(2024, 7, 1, 18, 20, 57, 0, DateTimeKind.Unspecified) });

            migrationBuilder.UpdateData(
                table: "TimeRegistrations",
                keyColumn: "TimeRegistrationId",
                keyValue: 425,
                columns: new[] { "EndTime", "StartTime" },
                values: new object[] { new DateTime(2024, 8, 27, 21, 1, 52, 0, DateTimeKind.Unspecified), new DateTime(2024, 3, 9, 22, 37, 46, 0, DateTimeKind.Unspecified) });

            migrationBuilder.UpdateData(
                table: "TimeRegistrations",
                keyColumn: "TimeRegistrationId",
                keyValue: 426,
                columns: new[] { "EndTime", "StartTime" },
                values: new object[] { new DateTime(2024, 9, 8, 3, 21, 42, 0, DateTimeKind.Unspecified), new DateTime(2024, 4, 14, 8, 29, 16, 0, DateTimeKind.Unspecified) });

            migrationBuilder.UpdateData(
                table: "TimeRegistrations",
                keyColumn: "TimeRegistrationId",
                keyValue: 427,
                columns: new[] { "EndTime", "StartTime" },
                values: new object[] { new DateTime(2024, 3, 19, 14, 16, 26, 0, DateTimeKind.Unspecified), new DateTime(2024, 9, 8, 17, 47, 57, 0, DateTimeKind.Unspecified) });

            migrationBuilder.UpdateData(
                table: "TimeRegistrations",
                keyColumn: "TimeRegistrationId",
                keyValue: 428,
                columns: new[] { "EndTime", "StartTime" },
                values: new object[] { new DateTime(2024, 10, 13, 2, 11, 39, 0, DateTimeKind.Unspecified), new DateTime(2024, 4, 4, 16, 45, 38, 0, DateTimeKind.Unspecified) });

            migrationBuilder.UpdateData(
                table: "TimeRegistrations",
                keyColumn: "TimeRegistrationId",
                keyValue: 429,
                columns: new[] { "EndTime", "StartTime" },
                values: new object[] { new DateTime(2024, 3, 21, 12, 56, 33, 0, DateTimeKind.Unspecified), new DateTime(2024, 3, 24, 8, 5, 34, 0, DateTimeKind.Unspecified) });

            migrationBuilder.UpdateData(
                table: "TimeRegistrations",
                keyColumn: "TimeRegistrationId",
                keyValue: 430,
                columns: new[] { "EndTime", "StartTime" },
                values: new object[] { new DateTime(2024, 1, 31, 17, 45, 19, 0, DateTimeKind.Unspecified), new DateTime(2024, 6, 17, 9, 7, 1, 0, DateTimeKind.Unspecified) });

            migrationBuilder.UpdateData(
                table: "TimeRegistrations",
                keyColumn: "TimeRegistrationId",
                keyValue: 431,
                columns: new[] { "EndTime", "StartTime" },
                values: new object[] { new DateTime(2024, 7, 27, 19, 8, 18, 0, DateTimeKind.Unspecified), new DateTime(2024, 1, 8, 14, 37, 38, 0, DateTimeKind.Unspecified) });

            migrationBuilder.UpdateData(
                table: "TimeRegistrations",
                keyColumn: "TimeRegistrationId",
                keyValue: 432,
                columns: new[] { "EndTime", "StartTime" },
                values: new object[] { new DateTime(2024, 9, 19, 21, 29, 8, 0, DateTimeKind.Unspecified), new DateTime(2024, 4, 1, 18, 59, 35, 0, DateTimeKind.Unspecified) });

            migrationBuilder.UpdateData(
                table: "TimeRegistrations",
                keyColumn: "TimeRegistrationId",
                keyValue: 433,
                columns: new[] { "EndTime", "StartTime" },
                values: new object[] { new DateTime(2024, 2, 14, 12, 31, 51, 0, DateTimeKind.Unspecified), new DateTime(2024, 4, 12, 14, 37, 43, 0, DateTimeKind.Unspecified) });

            migrationBuilder.UpdateData(
                table: "TimeRegistrations",
                keyColumn: "TimeRegistrationId",
                keyValue: 434,
                columns: new[] { "EndTime", "StartTime" },
                values: new object[] { new DateTime(2024, 10, 23, 6, 52, 52, 0, DateTimeKind.Unspecified), new DateTime(2024, 7, 19, 23, 42, 45, 0, DateTimeKind.Unspecified) });

            migrationBuilder.UpdateData(
                table: "TimeRegistrations",
                keyColumn: "TimeRegistrationId",
                keyValue: 435,
                columns: new[] { "EndTime", "StartTime" },
                values: new object[] { new DateTime(2024, 6, 3, 15, 21, 22, 0, DateTimeKind.Unspecified), new DateTime(2024, 11, 4, 17, 19, 19, 0, DateTimeKind.Unspecified) });

            migrationBuilder.UpdateData(
                table: "TimeRegistrations",
                keyColumn: "TimeRegistrationId",
                keyValue: 436,
                columns: new[] { "EndTime", "StartTime" },
                values: new object[] { new DateTime(2024, 3, 29, 5, 36, 37, 0, DateTimeKind.Unspecified), new DateTime(2024, 9, 25, 7, 8, 56, 0, DateTimeKind.Unspecified) });

            migrationBuilder.UpdateData(
                table: "TimeRegistrations",
                keyColumn: "TimeRegistrationId",
                keyValue: 437,
                columns: new[] { "EndTime", "StartTime" },
                values: new object[] { new DateTime(2024, 11, 2, 14, 54, 44, 0, DateTimeKind.Unspecified), new DateTime(2024, 4, 2, 20, 27, 32, 0, DateTimeKind.Unspecified) });

            migrationBuilder.UpdateData(
                table: "TimeRegistrations",
                keyColumn: "TimeRegistrationId",
                keyValue: 438,
                columns: new[] { "EndTime", "StartTime" },
                values: new object[] { new DateTime(2024, 3, 2, 18, 27, 21, 0, DateTimeKind.Unspecified), new DateTime(2024, 2, 25, 20, 15, 35, 0, DateTimeKind.Unspecified) });

            migrationBuilder.UpdateData(
                table: "TimeRegistrations",
                keyColumn: "TimeRegistrationId",
                keyValue: 439,
                columns: new[] { "EndTime", "StartTime" },
                values: new object[] { new DateTime(2024, 6, 16, 23, 36, 58, 0, DateTimeKind.Unspecified), new DateTime(2024, 3, 15, 11, 51, 43, 0, DateTimeKind.Unspecified) });

            migrationBuilder.UpdateData(
                table: "TimeRegistrations",
                keyColumn: "TimeRegistrationId",
                keyValue: 440,
                columns: new[] { "EndTime", "StartTime" },
                values: new object[] { new DateTime(2024, 5, 8, 19, 33, 36, 0, DateTimeKind.Unspecified), new DateTime(2024, 3, 30, 12, 46, 6, 0, DateTimeKind.Unspecified) });

            migrationBuilder.UpdateData(
                table: "TimeRegistrations",
                keyColumn: "TimeRegistrationId",
                keyValue: 441,
                columns: new[] { "EndTime", "StartTime" },
                values: new object[] { new DateTime(2024, 11, 4, 6, 11, 16, 0, DateTimeKind.Unspecified), new DateTime(2024, 8, 17, 22, 25, 1, 0, DateTimeKind.Unspecified) });

            migrationBuilder.UpdateData(
                table: "TimeRegistrations",
                keyColumn: "TimeRegistrationId",
                keyValue: 442,
                columns: new[] { "EndTime", "StartTime" },
                values: new object[] { new DateTime(2024, 9, 10, 11, 47, 16, 0, DateTimeKind.Unspecified), new DateTime(2024, 5, 17, 20, 52, 36, 0, DateTimeKind.Unspecified) });

            migrationBuilder.UpdateData(
                table: "TimeRegistrations",
                keyColumn: "TimeRegistrationId",
                keyValue: 443,
                columns: new[] { "EndTime", "StartTime" },
                values: new object[] { new DateTime(2024, 3, 31, 20, 43, 5, 0, DateTimeKind.Unspecified), new DateTime(2024, 3, 19, 10, 58, 33, 0, DateTimeKind.Unspecified) });

            migrationBuilder.UpdateData(
                table: "TimeRegistrations",
                keyColumn: "TimeRegistrationId",
                keyValue: 444,
                columns: new[] { "EndTime", "StartTime" },
                values: new object[] { new DateTime(2024, 11, 29, 21, 0, 57, 0, DateTimeKind.Unspecified), new DateTime(2024, 9, 1, 2, 53, 54, 0, DateTimeKind.Unspecified) });

            migrationBuilder.UpdateData(
                table: "TimeRegistrations",
                keyColumn: "TimeRegistrationId",
                keyValue: 445,
                columns: new[] { "EndTime", "StartTime" },
                values: new object[] { new DateTime(2024, 5, 19, 20, 32, 7, 0, DateTimeKind.Unspecified), new DateTime(2024, 10, 10, 4, 57, 5, 0, DateTimeKind.Unspecified) });

            migrationBuilder.UpdateData(
                table: "TimeRegistrations",
                keyColumn: "TimeRegistrationId",
                keyValue: 446,
                columns: new[] { "EndTime", "StartTime" },
                values: new object[] { new DateTime(2024, 12, 28, 12, 51, 12, 0, DateTimeKind.Unspecified), new DateTime(2024, 3, 11, 13, 17, 10, 0, DateTimeKind.Unspecified) });

            migrationBuilder.UpdateData(
                table: "TimeRegistrations",
                keyColumn: "TimeRegistrationId",
                keyValue: 447,
                columns: new[] { "EndTime", "StartTime" },
                values: new object[] { new DateTime(2024, 1, 14, 17, 31, 38, 0, DateTimeKind.Unspecified), new DateTime(2024, 11, 12, 12, 58, 24, 0, DateTimeKind.Unspecified) });

            migrationBuilder.UpdateData(
                table: "TimeRegistrations",
                keyColumn: "TimeRegistrationId",
                keyValue: 448,
                columns: new[] { "EndTime", "StartTime" },
                values: new object[] { new DateTime(2024, 8, 14, 19, 26, 24, 0, DateTimeKind.Unspecified), new DateTime(2024, 1, 7, 4, 34, 14, 0, DateTimeKind.Unspecified) });

            migrationBuilder.UpdateData(
                table: "TimeRegistrations",
                keyColumn: "TimeRegistrationId",
                keyValue: 449,
                columns: new[] { "EndTime", "StartTime" },
                values: new object[] { new DateTime(2024, 5, 8, 17, 1, 7, 0, DateTimeKind.Unspecified), new DateTime(2024, 8, 30, 15, 44, 21, 0, DateTimeKind.Unspecified) });

            migrationBuilder.UpdateData(
                table: "TimeRegistrations",
                keyColumn: "TimeRegistrationId",
                keyValue: 450,
                columns: new[] { "EndTime", "StartTime" },
                values: new object[] { new DateTime(2024, 7, 23, 22, 28, 44, 0, DateTimeKind.Unspecified), new DateTime(2024, 12, 17, 16, 8, 23, 0, DateTimeKind.Unspecified) });

            migrationBuilder.UpdateData(
                table: "TimeRegistrations",
                keyColumn: "TimeRegistrationId",
                keyValue: 451,
                columns: new[] { "EndTime", "StartTime" },
                values: new object[] { new DateTime(2024, 6, 9, 2, 32, 38, 0, DateTimeKind.Unspecified), new DateTime(2024, 10, 7, 16, 28, 22, 0, DateTimeKind.Unspecified) });

            migrationBuilder.UpdateData(
                table: "TimeRegistrations",
                keyColumn: "TimeRegistrationId",
                keyValue: 452,
                columns: new[] { "EndTime", "StartTime" },
                values: new object[] { new DateTime(2024, 10, 17, 13, 30, 28, 0, DateTimeKind.Unspecified), new DateTime(2024, 6, 21, 8, 4, 54, 0, DateTimeKind.Unspecified) });

            migrationBuilder.UpdateData(
                table: "TimeRegistrations",
                keyColumn: "TimeRegistrationId",
                keyValue: 453,
                columns: new[] { "EndTime", "StartTime" },
                values: new object[] { new DateTime(2024, 2, 29, 8, 23, 43, 0, DateTimeKind.Unspecified), new DateTime(2024, 5, 10, 20, 47, 46, 0, DateTimeKind.Unspecified) });

            migrationBuilder.UpdateData(
                table: "TimeRegistrations",
                keyColumn: "TimeRegistrationId",
                keyValue: 454,
                columns: new[] { "EndTime", "StartTime" },
                values: new object[] { new DateTime(2024, 1, 21, 5, 36, 51, 0, DateTimeKind.Unspecified), new DateTime(2024, 9, 29, 6, 22, 57, 0, DateTimeKind.Unspecified) });

            migrationBuilder.UpdateData(
                table: "TimeRegistrations",
                keyColumn: "TimeRegistrationId",
                keyValue: 455,
                columns: new[] { "EndTime", "StartTime" },
                values: new object[] { new DateTime(2024, 2, 5, 7, 21, 59, 0, DateTimeKind.Unspecified), new DateTime(2024, 4, 12, 0, 38, 52, 0, DateTimeKind.Unspecified) });

            migrationBuilder.UpdateData(
                table: "TimeRegistrations",
                keyColumn: "TimeRegistrationId",
                keyValue: 456,
                columns: new[] { "EndTime", "StartTime" },
                values: new object[] { new DateTime(2024, 1, 2, 13, 54, 52, 0, DateTimeKind.Unspecified), new DateTime(2024, 8, 26, 17, 3, 34, 0, DateTimeKind.Unspecified) });

            migrationBuilder.UpdateData(
                table: "TimeRegistrations",
                keyColumn: "TimeRegistrationId",
                keyValue: 457,
                columns: new[] { "EndTime", "StartTime" },
                values: new object[] { new DateTime(2024, 3, 18, 2, 20, 20, 0, DateTimeKind.Unspecified), new DateTime(2024, 4, 29, 10, 46, 58, 0, DateTimeKind.Unspecified) });

            migrationBuilder.UpdateData(
                table: "TimeRegistrations",
                keyColumn: "TimeRegistrationId",
                keyValue: 458,
                columns: new[] { "EndTime", "StartTime" },
                values: new object[] { new DateTime(2024, 2, 27, 8, 31, 4, 0, DateTimeKind.Unspecified), new DateTime(2024, 9, 23, 4, 30, 14, 0, DateTimeKind.Unspecified) });

            migrationBuilder.UpdateData(
                table: "TimeRegistrations",
                keyColumn: "TimeRegistrationId",
                keyValue: 459,
                columns: new[] { "EndTime", "StartTime" },
                values: new object[] { new DateTime(2024, 2, 18, 14, 31, 55, 0, DateTimeKind.Unspecified), new DateTime(2024, 6, 16, 20, 40, 49, 0, DateTimeKind.Unspecified) });

            migrationBuilder.UpdateData(
                table: "TimeRegistrations",
                keyColumn: "TimeRegistrationId",
                keyValue: 460,
                columns: new[] { "EndTime", "StartTime" },
                values: new object[] { new DateTime(2024, 2, 16, 9, 2, 58, 0, DateTimeKind.Unspecified), new DateTime(2024, 12, 8, 18, 45, 58, 0, DateTimeKind.Unspecified) });

            migrationBuilder.UpdateData(
                table: "TimeRegistrations",
                keyColumn: "TimeRegistrationId",
                keyValue: 461,
                columns: new[] { "EndTime", "StartTime" },
                values: new object[] { new DateTime(2024, 6, 5, 6, 56, 9, 0, DateTimeKind.Unspecified), new DateTime(2024, 1, 13, 15, 44, 53, 0, DateTimeKind.Unspecified) });

            migrationBuilder.UpdateData(
                table: "TimeRegistrations",
                keyColumn: "TimeRegistrationId",
                keyValue: 462,
                columns: new[] { "EndTime", "StartTime" },
                values: new object[] { new DateTime(2024, 8, 20, 4, 43, 0, 0, DateTimeKind.Unspecified), new DateTime(2024, 3, 17, 14, 44, 55, 0, DateTimeKind.Unspecified) });

            migrationBuilder.UpdateData(
                table: "TimeRegistrations",
                keyColumn: "TimeRegistrationId",
                keyValue: 463,
                columns: new[] { "EndTime", "StartTime" },
                values: new object[] { new DateTime(2024, 10, 15, 19, 13, 34, 0, DateTimeKind.Unspecified), new DateTime(2024, 10, 19, 20, 1, 58, 0, DateTimeKind.Unspecified) });

            migrationBuilder.UpdateData(
                table: "TimeRegistrations",
                keyColumn: "TimeRegistrationId",
                keyValue: 464,
                columns: new[] { "EndTime", "StartTime" },
                values: new object[] { new DateTime(2024, 10, 23, 5, 9, 34, 0, DateTimeKind.Unspecified), new DateTime(2024, 5, 16, 11, 23, 39, 0, DateTimeKind.Unspecified) });

            migrationBuilder.UpdateData(
                table: "TimeRegistrations",
                keyColumn: "TimeRegistrationId",
                keyValue: 465,
                columns: new[] { "EndTime", "StartTime" },
                values: new object[] { new DateTime(2024, 6, 8, 8, 18, 56, 0, DateTimeKind.Unspecified), new DateTime(2024, 1, 15, 16, 55, 7, 0, DateTimeKind.Unspecified) });

            migrationBuilder.UpdateData(
                table: "TimeRegistrations",
                keyColumn: "TimeRegistrationId",
                keyValue: 466,
                columns: new[] { "EndTime", "StartTime" },
                values: new object[] { new DateTime(2024, 8, 19, 22, 35, 31, 0, DateTimeKind.Unspecified), new DateTime(2024, 6, 12, 2, 22, 18, 0, DateTimeKind.Unspecified) });

            migrationBuilder.UpdateData(
                table: "TimeRegistrations",
                keyColumn: "TimeRegistrationId",
                keyValue: 467,
                columns: new[] { "EndTime", "StartTime" },
                values: new object[] { new DateTime(2024, 5, 2, 12, 53, 12, 0, DateTimeKind.Unspecified), new DateTime(2024, 12, 22, 6, 59, 6, 0, DateTimeKind.Unspecified) });

            migrationBuilder.UpdateData(
                table: "TimeRegistrations",
                keyColumn: "TimeRegistrationId",
                keyValue: 468,
                columns: new[] { "EndTime", "StartTime" },
                values: new object[] { new DateTime(2024, 12, 21, 5, 18, 43, 0, DateTimeKind.Unspecified), new DateTime(2024, 5, 3, 13, 54, 20, 0, DateTimeKind.Unspecified) });

            migrationBuilder.UpdateData(
                table: "TimeRegistrations",
                keyColumn: "TimeRegistrationId",
                keyValue: 469,
                columns: new[] { "EndTime", "StartTime" },
                values: new object[] { new DateTime(2024, 10, 4, 5, 24, 33, 0, DateTimeKind.Unspecified), new DateTime(2024, 12, 10, 14, 25, 54, 0, DateTimeKind.Unspecified) });

            migrationBuilder.UpdateData(
                table: "TimeRegistrations",
                keyColumn: "TimeRegistrationId",
                keyValue: 470,
                columns: new[] { "EndTime", "StartTime" },
                values: new object[] { new DateTime(2024, 8, 30, 11, 59, 35, 0, DateTimeKind.Unspecified), new DateTime(2024, 6, 17, 22, 19, 20, 0, DateTimeKind.Unspecified) });

            migrationBuilder.UpdateData(
                table: "TimeRegistrations",
                keyColumn: "TimeRegistrationId",
                keyValue: 471,
                columns: new[] { "EndTime", "StartTime" },
                values: new object[] { new DateTime(2024, 2, 2, 6, 12, 39, 0, DateTimeKind.Unspecified), new DateTime(2024, 10, 23, 4, 21, 8, 0, DateTimeKind.Unspecified) });

            migrationBuilder.UpdateData(
                table: "TimeRegistrations",
                keyColumn: "TimeRegistrationId",
                keyValue: 472,
                columns: new[] { "EndTime", "StartTime" },
                values: new object[] { new DateTime(2024, 10, 2, 6, 30, 21, 0, DateTimeKind.Unspecified), new DateTime(2024, 7, 29, 20, 36, 51, 0, DateTimeKind.Unspecified) });

            migrationBuilder.UpdateData(
                table: "TimeRegistrations",
                keyColumn: "TimeRegistrationId",
                keyValue: 473,
                columns: new[] { "EndTime", "StartTime" },
                values: new object[] { new DateTime(2024, 2, 14, 14, 26, 29, 0, DateTimeKind.Unspecified), new DateTime(2024, 10, 30, 1, 3, 32, 0, DateTimeKind.Unspecified) });

            migrationBuilder.UpdateData(
                table: "TimeRegistrations",
                keyColumn: "TimeRegistrationId",
                keyValue: 474,
                columns: new[] { "EndTime", "StartTime" },
                values: new object[] { new DateTime(2024, 2, 15, 10, 51, 8, 0, DateTimeKind.Unspecified), new DateTime(2024, 1, 5, 6, 58, 23, 0, DateTimeKind.Unspecified) });

            migrationBuilder.UpdateData(
                table: "TimeRegistrations",
                keyColumn: "TimeRegistrationId",
                keyValue: 475,
                columns: new[] { "EndTime", "StartTime" },
                values: new object[] { new DateTime(2024, 1, 3, 19, 14, 16, 0, DateTimeKind.Unspecified), new DateTime(2024, 7, 4, 6, 1, 8, 0, DateTimeKind.Unspecified) });

            migrationBuilder.UpdateData(
                table: "TimeRegistrations",
                keyColumn: "TimeRegistrationId",
                keyValue: 476,
                columns: new[] { "EndTime", "StartTime" },
                values: new object[] { new DateTime(2024, 10, 22, 15, 56, 33, 0, DateTimeKind.Unspecified), new DateTime(2024, 11, 26, 9, 24, 43, 0, DateTimeKind.Unspecified) });

            migrationBuilder.UpdateData(
                table: "TimeRegistrations",
                keyColumn: "TimeRegistrationId",
                keyValue: 477,
                columns: new[] { "EndTime", "StartTime" },
                values: new object[] { new DateTime(2024, 2, 2, 19, 55, 58, 0, DateTimeKind.Unspecified), new DateTime(2024, 9, 16, 1, 17, 5, 0, DateTimeKind.Unspecified) });

            migrationBuilder.UpdateData(
                table: "TimeRegistrations",
                keyColumn: "TimeRegistrationId",
                keyValue: 478,
                columns: new[] { "EndTime", "StartTime" },
                values: new object[] { new DateTime(2024, 1, 23, 14, 19, 52, 0, DateTimeKind.Unspecified), new DateTime(2024, 11, 15, 12, 24, 44, 0, DateTimeKind.Unspecified) });

            migrationBuilder.UpdateData(
                table: "TimeRegistrations",
                keyColumn: "TimeRegistrationId",
                keyValue: 479,
                columns: new[] { "EndTime", "StartTime" },
                values: new object[] { new DateTime(2024, 2, 26, 10, 41, 35, 0, DateTimeKind.Unspecified), new DateTime(2024, 1, 13, 12, 15, 16, 0, DateTimeKind.Unspecified) });

            migrationBuilder.UpdateData(
                table: "TimeRegistrations",
                keyColumn: "TimeRegistrationId",
                keyValue: 480,
                columns: new[] { "EndTime", "StartTime" },
                values: new object[] { new DateTime(2024, 3, 11, 13, 40, 53, 0, DateTimeKind.Unspecified), new DateTime(2024, 3, 10, 17, 8, 54, 0, DateTimeKind.Unspecified) });

            migrationBuilder.UpdateData(
                table: "TimeRegistrations",
                keyColumn: "TimeRegistrationId",
                keyValue: 481,
                columns: new[] { "EndTime", "StartTime" },
                values: new object[] { new DateTime(2024, 8, 10, 23, 6, 44, 0, DateTimeKind.Unspecified), new DateTime(2024, 1, 8, 20, 40, 11, 0, DateTimeKind.Unspecified) });

            migrationBuilder.UpdateData(
                table: "TimeRegistrations",
                keyColumn: "TimeRegistrationId",
                keyValue: 482,
                columns: new[] { "EndTime", "StartTime" },
                values: new object[] { new DateTime(2024, 6, 5, 17, 58, 32, 0, DateTimeKind.Unspecified), new DateTime(2024, 7, 1, 19, 38, 32, 0, DateTimeKind.Unspecified) });

            migrationBuilder.UpdateData(
                table: "TimeRegistrations",
                keyColumn: "TimeRegistrationId",
                keyValue: 483,
                columns: new[] { "EndTime", "StartTime" },
                values: new object[] { new DateTime(2024, 7, 21, 3, 59, 13, 0, DateTimeKind.Unspecified), new DateTime(2024, 8, 27, 6, 10, 57, 0, DateTimeKind.Unspecified) });

            migrationBuilder.UpdateData(
                table: "TimeRegistrations",
                keyColumn: "TimeRegistrationId",
                keyValue: 484,
                columns: new[] { "EndTime", "StartTime" },
                values: new object[] { new DateTime(2024, 8, 10, 20, 55, 23, 0, DateTimeKind.Unspecified), new DateTime(2024, 4, 2, 20, 43, 38, 0, DateTimeKind.Unspecified) });

            migrationBuilder.UpdateData(
                table: "TimeRegistrations",
                keyColumn: "TimeRegistrationId",
                keyValue: 485,
                columns: new[] { "EndTime", "StartTime" },
                values: new object[] { new DateTime(2024, 11, 24, 8, 42, 45, 0, DateTimeKind.Unspecified), new DateTime(2024, 5, 19, 8, 38, 28, 0, DateTimeKind.Unspecified) });

            migrationBuilder.UpdateData(
                table: "TimeRegistrations",
                keyColumn: "TimeRegistrationId",
                keyValue: 486,
                columns: new[] { "EndTime", "StartTime" },
                values: new object[] { new DateTime(2024, 4, 20, 17, 9, 25, 0, DateTimeKind.Unspecified), new DateTime(2024, 8, 28, 23, 42, 6, 0, DateTimeKind.Unspecified) });

            migrationBuilder.UpdateData(
                table: "TimeRegistrations",
                keyColumn: "TimeRegistrationId",
                keyValue: 487,
                columns: new[] { "EndTime", "StartTime" },
                values: new object[] { new DateTime(2024, 10, 20, 18, 30, 9, 0, DateTimeKind.Unspecified), new DateTime(2024, 8, 27, 2, 34, 46, 0, DateTimeKind.Unspecified) });

            migrationBuilder.UpdateData(
                table: "TimeRegistrations",
                keyColumn: "TimeRegistrationId",
                keyValue: 488,
                columns: new[] { "EndTime", "StartTime" },
                values: new object[] { new DateTime(2024, 3, 15, 11, 51, 31, 0, DateTimeKind.Unspecified), new DateTime(2024, 6, 9, 17, 52, 50, 0, DateTimeKind.Unspecified) });

            migrationBuilder.UpdateData(
                table: "TimeRegistrations",
                keyColumn: "TimeRegistrationId",
                keyValue: 489,
                columns: new[] { "EndTime", "StartTime" },
                values: new object[] { new DateTime(2024, 5, 21, 9, 11, 35, 0, DateTimeKind.Unspecified), new DateTime(2024, 1, 27, 17, 12, 22, 0, DateTimeKind.Unspecified) });

            migrationBuilder.UpdateData(
                table: "TimeRegistrations",
                keyColumn: "TimeRegistrationId",
                keyValue: 490,
                columns: new[] { "EndTime", "StartTime" },
                values: new object[] { new DateTime(2024, 10, 26, 16, 54, 35, 0, DateTimeKind.Unspecified), new DateTime(2024, 12, 14, 8, 41, 16, 0, DateTimeKind.Unspecified) });

            migrationBuilder.UpdateData(
                table: "TimeRegistrations",
                keyColumn: "TimeRegistrationId",
                keyValue: 491,
                columns: new[] { "EndTime", "StartTime" },
                values: new object[] { new DateTime(2024, 11, 29, 6, 33, 12, 0, DateTimeKind.Unspecified), new DateTime(2024, 10, 1, 17, 37, 43, 0, DateTimeKind.Unspecified) });

            migrationBuilder.UpdateData(
                table: "TimeRegistrations",
                keyColumn: "TimeRegistrationId",
                keyValue: 492,
                columns: new[] { "EndTime", "StartTime" },
                values: new object[] { new DateTime(2024, 6, 9, 23, 1, 13, 0, DateTimeKind.Unspecified), new DateTime(2024, 1, 15, 4, 3, 36, 0, DateTimeKind.Unspecified) });

            migrationBuilder.UpdateData(
                table: "TimeRegistrations",
                keyColumn: "TimeRegistrationId",
                keyValue: 493,
                columns: new[] { "EndTime", "StartTime" },
                values: new object[] { new DateTime(2024, 8, 19, 8, 15, 24, 0, DateTimeKind.Unspecified), new DateTime(2024, 3, 22, 8, 25, 35, 0, DateTimeKind.Unspecified) });

            migrationBuilder.UpdateData(
                table: "TimeRegistrations",
                keyColumn: "TimeRegistrationId",
                keyValue: 494,
                columns: new[] { "EndTime", "StartTime" },
                values: new object[] { new DateTime(2024, 9, 26, 7, 9, 1, 0, DateTimeKind.Unspecified), new DateTime(2024, 9, 11, 22, 25, 36, 0, DateTimeKind.Unspecified) });

            migrationBuilder.UpdateData(
                table: "TimeRegistrations",
                keyColumn: "TimeRegistrationId",
                keyValue: 495,
                columns: new[] { "EndTime", "StartTime" },
                values: new object[] { new DateTime(2024, 3, 1, 13, 30, 13, 0, DateTimeKind.Unspecified), new DateTime(2024, 1, 16, 12, 10, 32, 0, DateTimeKind.Unspecified) });

            migrationBuilder.UpdateData(
                table: "TimeRegistrations",
                keyColumn: "TimeRegistrationId",
                keyValue: 496,
                columns: new[] { "EndTime", "StartTime" },
                values: new object[] { new DateTime(2024, 2, 5, 18, 37, 31, 0, DateTimeKind.Unspecified), new DateTime(2024, 12, 8, 14, 21, 31, 0, DateTimeKind.Unspecified) });

            migrationBuilder.UpdateData(
                table: "TimeRegistrations",
                keyColumn: "TimeRegistrationId",
                keyValue: 497,
                columns: new[] { "EndTime", "StartTime" },
                values: new object[] { new DateTime(2024, 2, 8, 23, 48, 46, 0, DateTimeKind.Unspecified), new DateTime(2024, 12, 9, 15, 15, 34, 0, DateTimeKind.Unspecified) });

            migrationBuilder.UpdateData(
                table: "TimeRegistrations",
                keyColumn: "TimeRegistrationId",
                keyValue: 498,
                columns: new[] { "EndTime", "StartTime" },
                values: new object[] { new DateTime(2024, 1, 2, 1, 25, 6, 0, DateTimeKind.Unspecified), new DateTime(2024, 12, 30, 14, 46, 48, 0, DateTimeKind.Unspecified) });

            migrationBuilder.UpdateData(
                table: "TimeRegistrations",
                keyColumn: "TimeRegistrationId",
                keyValue: 499,
                columns: new[] { "EndTime", "StartTime" },
                values: new object[] { new DateTime(2024, 1, 12, 19, 36, 3, 0, DateTimeKind.Unspecified), new DateTime(2024, 7, 28, 22, 6, 40, 0, DateTimeKind.Unspecified) });

            migrationBuilder.UpdateData(
                table: "TimeRegistrations",
                keyColumn: "TimeRegistrationId",
                keyValue: 500,
                columns: new[] { "EndTime", "StartTime" },
                values: new object[] { new DateTime(2024, 6, 30, 10, 42, 39, 0, DateTimeKind.Unspecified), new DateTime(2024, 8, 4, 17, 52, 53, 0, DateTimeKind.Unspecified) });

            migrationBuilder.UpdateData(
                table: "TimeRegistrations",
                keyColumn: "TimeRegistrationId",
                keyValue: 501,
                columns: new[] { "EndTime", "StartTime" },
                values: new object[] { new DateTime(2024, 8, 9, 10, 46, 56, 0, DateTimeKind.Unspecified), new DateTime(2024, 2, 5, 15, 29, 19, 0, DateTimeKind.Unspecified) });

            migrationBuilder.UpdateData(
                table: "TimeRegistrations",
                keyColumn: "TimeRegistrationId",
                keyValue: 502,
                columns: new[] { "EndTime", "StartTime" },
                values: new object[] { new DateTime(2024, 2, 9, 22, 37, 15, 0, DateTimeKind.Unspecified), new DateTime(2024, 10, 11, 3, 10, 47, 0, DateTimeKind.Unspecified) });

            migrationBuilder.UpdateData(
                table: "TimeRegistrations",
                keyColumn: "TimeRegistrationId",
                keyValue: 503,
                columns: new[] { "EndTime", "StartTime" },
                values: new object[] { new DateTime(2024, 8, 3, 8, 0, 29, 0, DateTimeKind.Unspecified), new DateTime(2024, 12, 20, 7, 15, 15, 0, DateTimeKind.Unspecified) });

            migrationBuilder.UpdateData(
                table: "TimeRegistrations",
                keyColumn: "TimeRegistrationId",
                keyValue: 504,
                columns: new[] { "EndTime", "StartTime" },
                values: new object[] { new DateTime(2024, 8, 26, 23, 0, 33, 0, DateTimeKind.Unspecified), new DateTime(2024, 6, 3, 12, 18, 9, 0, DateTimeKind.Unspecified) });

            migrationBuilder.UpdateData(
                table: "TimeRegistrations",
                keyColumn: "TimeRegistrationId",
                keyValue: 505,
                columns: new[] { "EndTime", "StartTime" },
                values: new object[] { new DateTime(2024, 5, 13, 19, 46, 38, 0, DateTimeKind.Unspecified), new DateTime(2024, 6, 22, 2, 38, 23, 0, DateTimeKind.Unspecified) });

            migrationBuilder.UpdateData(
                table: "TimeRegistrations",
                keyColumn: "TimeRegistrationId",
                keyValue: 506,
                columns: new[] { "EndTime", "StartTime" },
                values: new object[] { new DateTime(2024, 10, 31, 21, 12, 30, 0, DateTimeKind.Unspecified), new DateTime(2024, 2, 15, 9, 52, 48, 0, DateTimeKind.Unspecified) });

            migrationBuilder.UpdateData(
                table: "TimeRegistrations",
                keyColumn: "TimeRegistrationId",
                keyValue: 507,
                columns: new[] { "EndTime", "StartTime" },
                values: new object[] { new DateTime(2024, 3, 8, 21, 33, 17, 0, DateTimeKind.Unspecified), new DateTime(2024, 7, 12, 1, 19, 38, 0, DateTimeKind.Unspecified) });

            migrationBuilder.UpdateData(
                table: "TimeRegistrations",
                keyColumn: "TimeRegistrationId",
                keyValue: 508,
                columns: new[] { "EndTime", "StartTime" },
                values: new object[] { new DateTime(2024, 7, 3, 2, 51, 56, 0, DateTimeKind.Unspecified), new DateTime(2024, 10, 8, 16, 38, 8, 0, DateTimeKind.Unspecified) });

            migrationBuilder.UpdateData(
                table: "TimeRegistrations",
                keyColumn: "TimeRegistrationId",
                keyValue: 509,
                columns: new[] { "EndTime", "StartTime" },
                values: new object[] { new DateTime(2024, 5, 31, 8, 28, 25, 0, DateTimeKind.Unspecified), new DateTime(2024, 12, 11, 20, 8, 10, 0, DateTimeKind.Unspecified) });

            migrationBuilder.UpdateData(
                table: "TimeRegistrations",
                keyColumn: "TimeRegistrationId",
                keyValue: 510,
                columns: new[] { "EndTime", "StartTime" },
                values: new object[] { new DateTime(2024, 9, 23, 15, 34, 6, 0, DateTimeKind.Unspecified), new DateTime(2024, 4, 24, 20, 43, 33, 0, DateTimeKind.Unspecified) });

            migrationBuilder.UpdateData(
                table: "TimeRegistrations",
                keyColumn: "TimeRegistrationId",
                keyValue: 511,
                columns: new[] { "EndTime", "StartTime" },
                values: new object[] { new DateTime(2024, 5, 21, 16, 48, 18, 0, DateTimeKind.Unspecified), new DateTime(2024, 4, 17, 0, 21, 31, 0, DateTimeKind.Unspecified) });

            migrationBuilder.UpdateData(
                table: "TimeRegistrations",
                keyColumn: "TimeRegistrationId",
                keyValue: 512,
                columns: new[] { "EndTime", "StartTime" },
                values: new object[] { new DateTime(2024, 7, 18, 15, 17, 12, 0, DateTimeKind.Unspecified), new DateTime(2024, 5, 23, 17, 15, 2, 0, DateTimeKind.Unspecified) });

            migrationBuilder.UpdateData(
                table: "TimeRegistrations",
                keyColumn: "TimeRegistrationId",
                keyValue: 513,
                columns: new[] { "EndTime", "StartTime" },
                values: new object[] { new DateTime(2024, 8, 23, 8, 12, 29, 0, DateTimeKind.Unspecified), new DateTime(2024, 5, 20, 23, 7, 0, 0, DateTimeKind.Unspecified) });

            migrationBuilder.UpdateData(
                table: "TimeRegistrations",
                keyColumn: "TimeRegistrationId",
                keyValue: 514,
                columns: new[] { "EndTime", "StartTime" },
                values: new object[] { new DateTime(2024, 2, 7, 20, 0, 10, 0, DateTimeKind.Unspecified), new DateTime(2024, 2, 26, 6, 1, 33, 0, DateTimeKind.Unspecified) });

            migrationBuilder.UpdateData(
                table: "TimeRegistrations",
                keyColumn: "TimeRegistrationId",
                keyValue: 515,
                columns: new[] { "EndTime", "StartTime" },
                values: new object[] { new DateTime(2024, 10, 3, 0, 36, 34, 0, DateTimeKind.Unspecified), new DateTime(2024, 3, 26, 2, 51, 7, 0, DateTimeKind.Unspecified) });

            migrationBuilder.UpdateData(
                table: "TimeRegistrations",
                keyColumn: "TimeRegistrationId",
                keyValue: 516,
                columns: new[] { "EndTime", "StartTime" },
                values: new object[] { new DateTime(2024, 2, 6, 3, 25, 57, 0, DateTimeKind.Unspecified), new DateTime(2024, 11, 11, 22, 55, 25, 0, DateTimeKind.Unspecified) });

            migrationBuilder.UpdateData(
                table: "TimeRegistrations",
                keyColumn: "TimeRegistrationId",
                keyValue: 517,
                columns: new[] { "EndTime", "StartTime" },
                values: new object[] { new DateTime(2024, 8, 13, 0, 13, 49, 0, DateTimeKind.Unspecified), new DateTime(2024, 11, 19, 2, 15, 58, 0, DateTimeKind.Unspecified) });

            migrationBuilder.UpdateData(
                table: "TimeRegistrations",
                keyColumn: "TimeRegistrationId",
                keyValue: 518,
                columns: new[] { "EndTime", "StartTime" },
                values: new object[] { new DateTime(2024, 8, 23, 16, 19, 11, 0, DateTimeKind.Unspecified), new DateTime(2024, 11, 27, 22, 10, 51, 0, DateTimeKind.Unspecified) });

            migrationBuilder.UpdateData(
                table: "TimeRegistrations",
                keyColumn: "TimeRegistrationId",
                keyValue: 519,
                columns: new[] { "EndTime", "StartTime" },
                values: new object[] { new DateTime(2024, 11, 29, 16, 58, 5, 0, DateTimeKind.Unspecified), new DateTime(2024, 6, 15, 2, 34, 40, 0, DateTimeKind.Unspecified) });

            migrationBuilder.UpdateData(
                table: "TimeRegistrations",
                keyColumn: "TimeRegistrationId",
                keyValue: 520,
                columns: new[] { "EndTime", "StartTime" },
                values: new object[] { new DateTime(2024, 1, 22, 14, 45, 17, 0, DateTimeKind.Unspecified), new DateTime(2024, 12, 21, 12, 6, 54, 0, DateTimeKind.Unspecified) });

            migrationBuilder.UpdateData(
                table: "TimeRegistrations",
                keyColumn: "TimeRegistrationId",
                keyValue: 521,
                columns: new[] { "EndTime", "StartTime" },
                values: new object[] { new DateTime(2024, 10, 19, 3, 27, 15, 0, DateTimeKind.Unspecified), new DateTime(2024, 11, 4, 3, 23, 7, 0, DateTimeKind.Unspecified) });

            migrationBuilder.UpdateData(
                table: "TimeRegistrations",
                keyColumn: "TimeRegistrationId",
                keyValue: 522,
                columns: new[] { "EndTime", "StartTime" },
                values: new object[] { new DateTime(2024, 9, 21, 15, 59, 18, 0, DateTimeKind.Unspecified), new DateTime(2024, 9, 6, 20, 9, 11, 0, DateTimeKind.Unspecified) });

            migrationBuilder.UpdateData(
                table: "TimeRegistrations",
                keyColumn: "TimeRegistrationId",
                keyValue: 523,
                columns: new[] { "EndTime", "StartTime" },
                values: new object[] { new DateTime(2024, 7, 2, 10, 37, 37, 0, DateTimeKind.Unspecified), new DateTime(2024, 2, 13, 7, 6, 29, 0, DateTimeKind.Unspecified) });

            migrationBuilder.UpdateData(
                table: "TimeRegistrations",
                keyColumn: "TimeRegistrationId",
                keyValue: 524,
                columns: new[] { "EndTime", "StartTime" },
                values: new object[] { new DateTime(2024, 5, 6, 3, 42, 18, 0, DateTimeKind.Unspecified), new DateTime(2024, 5, 30, 22, 36, 56, 0, DateTimeKind.Unspecified) });

            migrationBuilder.UpdateData(
                table: "TimeRegistrations",
                keyColumn: "TimeRegistrationId",
                keyValue: 525,
                columns: new[] { "EndTime", "StartTime" },
                values: new object[] { new DateTime(2024, 7, 18, 1, 17, 58, 0, DateTimeKind.Unspecified), new DateTime(2024, 9, 8, 6, 5, 51, 0, DateTimeKind.Unspecified) });

            migrationBuilder.UpdateData(
                table: "TimeRegistrations",
                keyColumn: "TimeRegistrationId",
                keyValue: 526,
                columns: new[] { "EndTime", "StartTime" },
                values: new object[] { new DateTime(2024, 1, 11, 9, 30, 44, 0, DateTimeKind.Unspecified), new DateTime(2024, 2, 17, 10, 56, 32, 0, DateTimeKind.Unspecified) });

            migrationBuilder.UpdateData(
                table: "TimeRegistrations",
                keyColumn: "TimeRegistrationId",
                keyValue: 527,
                columns: new[] { "EndTime", "StartTime" },
                values: new object[] { new DateTime(2024, 6, 6, 8, 51, 36, 0, DateTimeKind.Unspecified), new DateTime(2024, 3, 24, 3, 22, 28, 0, DateTimeKind.Unspecified) });

            migrationBuilder.UpdateData(
                table: "TimeRegistrations",
                keyColumn: "TimeRegistrationId",
                keyValue: 528,
                columns: new[] { "EndTime", "StartTime" },
                values: new object[] { new DateTime(2024, 4, 28, 11, 49, 15, 0, DateTimeKind.Unspecified), new DateTime(2024, 7, 7, 15, 22, 49, 0, DateTimeKind.Unspecified) });

            migrationBuilder.UpdateData(
                table: "TimeRegistrations",
                keyColumn: "TimeRegistrationId",
                keyValue: 529,
                columns: new[] { "EndTime", "StartTime" },
                values: new object[] { new DateTime(2024, 1, 5, 5, 59, 35, 0, DateTimeKind.Unspecified), new DateTime(2024, 2, 6, 23, 10, 38, 0, DateTimeKind.Unspecified) });

            migrationBuilder.UpdateData(
                table: "TimeRegistrations",
                keyColumn: "TimeRegistrationId",
                keyValue: 530,
                columns: new[] { "EndTime", "StartTime" },
                values: new object[] { new DateTime(2024, 12, 18, 16, 54, 26, 0, DateTimeKind.Unspecified), new DateTime(2024, 5, 11, 15, 58, 27, 0, DateTimeKind.Unspecified) });

            migrationBuilder.UpdateData(
                table: "TimeRegistrations",
                keyColumn: "TimeRegistrationId",
                keyValue: 531,
                columns: new[] { "EndTime", "StartTime" },
                values: new object[] { new DateTime(2024, 1, 19, 3, 47, 39, 0, DateTimeKind.Unspecified), new DateTime(2024, 2, 27, 20, 34, 31, 0, DateTimeKind.Unspecified) });

            migrationBuilder.UpdateData(
                table: "TimeRegistrations",
                keyColumn: "TimeRegistrationId",
                keyValue: 532,
                columns: new[] { "EndTime", "StartTime" },
                values: new object[] { new DateTime(2024, 3, 19, 17, 18, 8, 0, DateTimeKind.Unspecified), new DateTime(2024, 6, 27, 1, 41, 3, 0, DateTimeKind.Unspecified) });

            migrationBuilder.UpdateData(
                table: "TimeRegistrations",
                keyColumn: "TimeRegistrationId",
                keyValue: 533,
                columns: new[] { "EndTime", "StartTime" },
                values: new object[] { new DateTime(2024, 2, 12, 22, 28, 38, 0, DateTimeKind.Unspecified), new DateTime(2024, 1, 8, 1, 42, 13, 0, DateTimeKind.Unspecified) });

            migrationBuilder.UpdateData(
                table: "TimeRegistrations",
                keyColumn: "TimeRegistrationId",
                keyValue: 534,
                columns: new[] { "EndTime", "StartTime" },
                values: new object[] { new DateTime(2024, 6, 21, 1, 40, 32, 0, DateTimeKind.Unspecified), new DateTime(2024, 7, 9, 0, 38, 39, 0, DateTimeKind.Unspecified) });

            migrationBuilder.UpdateData(
                table: "TimeRegistrations",
                keyColumn: "TimeRegistrationId",
                keyValue: 535,
                columns: new[] { "EndTime", "StartTime" },
                values: new object[] { new DateTime(2024, 4, 19, 11, 41, 42, 0, DateTimeKind.Unspecified), new DateTime(2024, 8, 17, 12, 32, 45, 0, DateTimeKind.Unspecified) });

            migrationBuilder.UpdateData(
                table: "TimeRegistrations",
                keyColumn: "TimeRegistrationId",
                keyValue: 536,
                columns: new[] { "EndTime", "StartTime" },
                values: new object[] { new DateTime(2024, 1, 9, 15, 33, 36, 0, DateTimeKind.Unspecified), new DateTime(2024, 4, 25, 9, 35, 46, 0, DateTimeKind.Unspecified) });

            migrationBuilder.UpdateData(
                table: "TimeRegistrations",
                keyColumn: "TimeRegistrationId",
                keyValue: 537,
                columns: new[] { "EndTime", "StartTime" },
                values: new object[] { new DateTime(2024, 1, 27, 14, 14, 16, 0, DateTimeKind.Unspecified), new DateTime(2024, 10, 1, 13, 30, 46, 0, DateTimeKind.Unspecified) });

            migrationBuilder.UpdateData(
                table: "TimeRegistrations",
                keyColumn: "TimeRegistrationId",
                keyValue: 538,
                columns: new[] { "EndTime", "StartTime" },
                values: new object[] { new DateTime(2024, 12, 21, 2, 22, 50, 0, DateTimeKind.Unspecified), new DateTime(2024, 7, 13, 18, 38, 48, 0, DateTimeKind.Unspecified) });

            migrationBuilder.UpdateData(
                table: "TimeRegistrations",
                keyColumn: "TimeRegistrationId",
                keyValue: 539,
                columns: new[] { "EndTime", "StartTime" },
                values: new object[] { new DateTime(2024, 1, 26, 18, 0, 36, 0, DateTimeKind.Unspecified), new DateTime(2024, 2, 26, 15, 5, 4, 0, DateTimeKind.Unspecified) });

            migrationBuilder.UpdateData(
                table: "TimeRegistrations",
                keyColumn: "TimeRegistrationId",
                keyValue: 540,
                columns: new[] { "EndTime", "StartTime" },
                values: new object[] { new DateTime(2024, 2, 4, 23, 6, 35, 0, DateTimeKind.Unspecified), new DateTime(2024, 12, 14, 0, 46, 2, 0, DateTimeKind.Unspecified) });

            migrationBuilder.UpdateData(
                table: "TimeRegistrations",
                keyColumn: "TimeRegistrationId",
                keyValue: 541,
                columns: new[] { "EndTime", "StartTime" },
                values: new object[] { new DateTime(2024, 8, 27, 7, 51, 34, 0, DateTimeKind.Unspecified), new DateTime(2024, 8, 28, 19, 37, 0, 0, DateTimeKind.Unspecified) });

            migrationBuilder.UpdateData(
                table: "TimeRegistrations",
                keyColumn: "TimeRegistrationId",
                keyValue: 542,
                columns: new[] { "EndTime", "StartTime" },
                values: new object[] { new DateTime(2024, 8, 23, 5, 24, 55, 0, DateTimeKind.Unspecified), new DateTime(2024, 9, 10, 11, 23, 17, 0, DateTimeKind.Unspecified) });

            migrationBuilder.UpdateData(
                table: "TimeRegistrations",
                keyColumn: "TimeRegistrationId",
                keyValue: 543,
                columns: new[] { "EndTime", "StartTime" },
                values: new object[] { new DateTime(2024, 11, 22, 10, 48, 45, 0, DateTimeKind.Unspecified), new DateTime(2024, 12, 24, 16, 45, 56, 0, DateTimeKind.Unspecified) });

            migrationBuilder.UpdateData(
                table: "TimeRegistrations",
                keyColumn: "TimeRegistrationId",
                keyValue: 544,
                columns: new[] { "EndTime", "StartTime" },
                values: new object[] { new DateTime(2024, 1, 25, 8, 4, 42, 0, DateTimeKind.Unspecified), new DateTime(2024, 10, 27, 12, 32, 26, 0, DateTimeKind.Unspecified) });

            migrationBuilder.UpdateData(
                table: "TimeRegistrations",
                keyColumn: "TimeRegistrationId",
                keyValue: 545,
                columns: new[] { "EndTime", "StartTime" },
                values: new object[] { new DateTime(2024, 10, 29, 8, 16, 8, 0, DateTimeKind.Unspecified), new DateTime(2024, 1, 18, 18, 49, 6, 0, DateTimeKind.Unspecified) });

            migrationBuilder.UpdateData(
                table: "TimeRegistrations",
                keyColumn: "TimeRegistrationId",
                keyValue: 546,
                columns: new[] { "EndTime", "StartTime" },
                values: new object[] { new DateTime(2024, 1, 24, 20, 40, 57, 0, DateTimeKind.Unspecified), new DateTime(2024, 10, 23, 13, 42, 7, 0, DateTimeKind.Unspecified) });

            migrationBuilder.UpdateData(
                table: "TimeRegistrations",
                keyColumn: "TimeRegistrationId",
                keyValue: 547,
                columns: new[] { "EndTime", "StartTime" },
                values: new object[] { new DateTime(2024, 11, 24, 23, 25, 42, 0, DateTimeKind.Unspecified), new DateTime(2024, 4, 15, 4, 50, 51, 0, DateTimeKind.Unspecified) });

            migrationBuilder.UpdateData(
                table: "TimeRegistrations",
                keyColumn: "TimeRegistrationId",
                keyValue: 548,
                columns: new[] { "EndTime", "StartTime" },
                values: new object[] { new DateTime(2024, 2, 25, 18, 55, 58, 0, DateTimeKind.Unspecified), new DateTime(2024, 6, 14, 14, 4, 27, 0, DateTimeKind.Unspecified) });

            migrationBuilder.UpdateData(
                table: "TimeRegistrations",
                keyColumn: "TimeRegistrationId",
                keyValue: 549,
                columns: new[] { "EndTime", "StartTime" },
                values: new object[] { new DateTime(2024, 2, 23, 13, 26, 59, 0, DateTimeKind.Unspecified), new DateTime(2024, 6, 3, 6, 2, 45, 0, DateTimeKind.Unspecified) });

            migrationBuilder.UpdateData(
                table: "TimeRegistrations",
                keyColumn: "TimeRegistrationId",
                keyValue: 550,
                columns: new[] { "EndTime", "StartTime" },
                values: new object[] { new DateTime(2024, 6, 23, 23, 45, 20, 0, DateTimeKind.Unspecified), new DateTime(2024, 4, 18, 2, 9, 56, 0, DateTimeKind.Unspecified) });

            migrationBuilder.UpdateData(
                table: "TimeRegistrations",
                keyColumn: "TimeRegistrationId",
                keyValue: 551,
                columns: new[] { "EndTime", "StartTime" },
                values: new object[] { new DateTime(2024, 7, 5, 3, 0, 15, 0, DateTimeKind.Unspecified), new DateTime(2024, 2, 9, 16, 52, 38, 0, DateTimeKind.Unspecified) });

            migrationBuilder.UpdateData(
                table: "TimeRegistrations",
                keyColumn: "TimeRegistrationId",
                keyValue: 552,
                columns: new[] { "EndTime", "StartTime" },
                values: new object[] { new DateTime(2024, 10, 16, 9, 39, 18, 0, DateTimeKind.Unspecified), new DateTime(2024, 3, 29, 17, 33, 39, 0, DateTimeKind.Unspecified) });

            migrationBuilder.UpdateData(
                table: "TimeRegistrations",
                keyColumn: "TimeRegistrationId",
                keyValue: 553,
                columns: new[] { "EndTime", "StartTime" },
                values: new object[] { new DateTime(2024, 11, 18, 15, 17, 19, 0, DateTimeKind.Unspecified), new DateTime(2024, 12, 27, 4, 27, 53, 0, DateTimeKind.Unspecified) });

            migrationBuilder.UpdateData(
                table: "TimeRegistrations",
                keyColumn: "TimeRegistrationId",
                keyValue: 554,
                columns: new[] { "EndTime", "StartTime" },
                values: new object[] { new DateTime(2024, 9, 10, 17, 33, 29, 0, DateTimeKind.Unspecified), new DateTime(2024, 4, 22, 1, 57, 15, 0, DateTimeKind.Unspecified) });

            migrationBuilder.UpdateData(
                table: "TimeRegistrations",
                keyColumn: "TimeRegistrationId",
                keyValue: 555,
                columns: new[] { "EndTime", "StartTime" },
                values: new object[] { new DateTime(2024, 5, 18, 0, 43, 51, 0, DateTimeKind.Unspecified), new DateTime(2024, 1, 11, 14, 33, 14, 0, DateTimeKind.Unspecified) });

            migrationBuilder.UpdateData(
                table: "TimeRegistrations",
                keyColumn: "TimeRegistrationId",
                keyValue: 556,
                columns: new[] { "EndTime", "StartTime" },
                values: new object[] { new DateTime(2024, 8, 11, 19, 58, 59, 0, DateTimeKind.Unspecified), new DateTime(2024, 9, 23, 1, 1, 52, 0, DateTimeKind.Unspecified) });

            migrationBuilder.UpdateData(
                table: "TimeRegistrations",
                keyColumn: "TimeRegistrationId",
                keyValue: 557,
                columns: new[] { "EndTime", "StartTime" },
                values: new object[] { new DateTime(2024, 8, 14, 1, 39, 48, 0, DateTimeKind.Unspecified), new DateTime(2024, 8, 17, 14, 40, 49, 0, DateTimeKind.Unspecified) });

            migrationBuilder.UpdateData(
                table: "TimeRegistrations",
                keyColumn: "TimeRegistrationId",
                keyValue: 558,
                columns: new[] { "EndTime", "StartTime" },
                values: new object[] { new DateTime(2024, 11, 27, 14, 39, 8, 0, DateTimeKind.Unspecified), new DateTime(2024, 7, 13, 4, 42, 38, 0, DateTimeKind.Unspecified) });

            migrationBuilder.UpdateData(
                table: "TimeRegistrations",
                keyColumn: "TimeRegistrationId",
                keyValue: 559,
                columns: new[] { "EndTime", "StartTime" },
                values: new object[] { new DateTime(2024, 5, 11, 1, 26, 30, 0, DateTimeKind.Unspecified), new DateTime(2024, 10, 7, 0, 56, 32, 0, DateTimeKind.Unspecified) });

            migrationBuilder.UpdateData(
                table: "TimeRegistrations",
                keyColumn: "TimeRegistrationId",
                keyValue: 560,
                columns: new[] { "EndTime", "StartTime" },
                values: new object[] { new DateTime(2024, 2, 28, 3, 30, 15, 0, DateTimeKind.Unspecified), new DateTime(2024, 9, 12, 3, 21, 42, 0, DateTimeKind.Unspecified) });

            migrationBuilder.UpdateData(
                table: "TimeRegistrations",
                keyColumn: "TimeRegistrationId",
                keyValue: 561,
                columns: new[] { "EndTime", "StartTime" },
                values: new object[] { new DateTime(2024, 4, 23, 5, 28, 11, 0, DateTimeKind.Unspecified), new DateTime(2024, 8, 28, 1, 2, 13, 0, DateTimeKind.Unspecified) });

            migrationBuilder.UpdateData(
                table: "TimeRegistrations",
                keyColumn: "TimeRegistrationId",
                keyValue: 562,
                columns: new[] { "EndTime", "StartTime" },
                values: new object[] { new DateTime(2024, 11, 2, 15, 44, 1, 0, DateTimeKind.Unspecified), new DateTime(2024, 11, 11, 8, 6, 45, 0, DateTimeKind.Unspecified) });

            migrationBuilder.UpdateData(
                table: "TimeRegistrations",
                keyColumn: "TimeRegistrationId",
                keyValue: 563,
                columns: new[] { "EndTime", "StartTime" },
                values: new object[] { new DateTime(2024, 4, 13, 5, 1, 15, 0, DateTimeKind.Unspecified), new DateTime(2024, 1, 17, 8, 15, 22, 0, DateTimeKind.Unspecified) });

            migrationBuilder.UpdateData(
                table: "TimeRegistrations",
                keyColumn: "TimeRegistrationId",
                keyValue: 564,
                columns: new[] { "EndTime", "StartTime" },
                values: new object[] { new DateTime(2024, 4, 14, 3, 35, 58, 0, DateTimeKind.Unspecified), new DateTime(2024, 6, 19, 1, 26, 22, 0, DateTimeKind.Unspecified) });

            migrationBuilder.UpdateData(
                table: "TimeRegistrations",
                keyColumn: "TimeRegistrationId",
                keyValue: 565,
                columns: new[] { "EndTime", "StartTime" },
                values: new object[] { new DateTime(2024, 10, 13, 15, 28, 12, 0, DateTimeKind.Unspecified), new DateTime(2024, 12, 28, 10, 19, 30, 0, DateTimeKind.Unspecified) });

            migrationBuilder.UpdateData(
                table: "TimeRegistrations",
                keyColumn: "TimeRegistrationId",
                keyValue: 566,
                columns: new[] { "EndTime", "StartTime" },
                values: new object[] { new DateTime(2024, 6, 18, 11, 24, 27, 0, DateTimeKind.Unspecified), new DateTime(2024, 8, 2, 16, 49, 5, 0, DateTimeKind.Unspecified) });

            migrationBuilder.UpdateData(
                table: "TimeRegistrations",
                keyColumn: "TimeRegistrationId",
                keyValue: 567,
                columns: new[] { "EndTime", "StartTime" },
                values: new object[] { new DateTime(2024, 4, 1, 3, 45, 51, 0, DateTimeKind.Unspecified), new DateTime(2024, 3, 11, 18, 36, 24, 0, DateTimeKind.Unspecified) });

            migrationBuilder.UpdateData(
                table: "TimeRegistrations",
                keyColumn: "TimeRegistrationId",
                keyValue: 568,
                columns: new[] { "EndTime", "StartTime" },
                values: new object[] { new DateTime(2024, 10, 21, 21, 29, 51, 0, DateTimeKind.Unspecified), new DateTime(2024, 7, 26, 19, 47, 22, 0, DateTimeKind.Unspecified) });

            migrationBuilder.UpdateData(
                table: "TimeRegistrations",
                keyColumn: "TimeRegistrationId",
                keyValue: 569,
                columns: new[] { "EndTime", "StartTime" },
                values: new object[] { new DateTime(2024, 12, 22, 12, 58, 33, 0, DateTimeKind.Unspecified), new DateTime(2024, 9, 7, 16, 15, 50, 0, DateTimeKind.Unspecified) });

            migrationBuilder.UpdateData(
                table: "TimeRegistrations",
                keyColumn: "TimeRegistrationId",
                keyValue: 570,
                columns: new[] { "EndTime", "StartTime" },
                values: new object[] { new DateTime(2024, 1, 19, 22, 55, 7, 0, DateTimeKind.Unspecified), new DateTime(2024, 4, 13, 18, 10, 3, 0, DateTimeKind.Unspecified) });

            migrationBuilder.UpdateData(
                table: "TimeRegistrations",
                keyColumn: "TimeRegistrationId",
                keyValue: 571,
                columns: new[] { "EndTime", "StartTime" },
                values: new object[] { new DateTime(2024, 7, 12, 21, 57, 26, 0, DateTimeKind.Unspecified), new DateTime(2024, 4, 30, 17, 58, 50, 0, DateTimeKind.Unspecified) });

            migrationBuilder.UpdateData(
                table: "TimeRegistrations",
                keyColumn: "TimeRegistrationId",
                keyValue: 572,
                columns: new[] { "EndTime", "StartTime" },
                values: new object[] { new DateTime(2024, 3, 31, 21, 25, 56, 0, DateTimeKind.Unspecified), new DateTime(2024, 11, 9, 23, 10, 21, 0, DateTimeKind.Unspecified) });

            migrationBuilder.UpdateData(
                table: "TimeRegistrations",
                keyColumn: "TimeRegistrationId",
                keyValue: 573,
                columns: new[] { "EndTime", "StartTime" },
                values: new object[] { new DateTime(2024, 5, 24, 12, 24, 54, 0, DateTimeKind.Unspecified), new DateTime(2024, 1, 9, 18, 19, 11, 0, DateTimeKind.Unspecified) });

            migrationBuilder.UpdateData(
                table: "TimeRegistrations",
                keyColumn: "TimeRegistrationId",
                keyValue: 574,
                columns: new[] { "EndTime", "StartTime" },
                values: new object[] { new DateTime(2024, 1, 23, 2, 27, 58, 0, DateTimeKind.Unspecified), new DateTime(2024, 12, 16, 12, 58, 46, 0, DateTimeKind.Unspecified) });

            migrationBuilder.UpdateData(
                table: "TimeRegistrations",
                keyColumn: "TimeRegistrationId",
                keyValue: 575,
                columns: new[] { "EndTime", "StartTime" },
                values: new object[] { new DateTime(2024, 8, 4, 3, 35, 15, 0, DateTimeKind.Unspecified), new DateTime(2024, 8, 17, 23, 0, 32, 0, DateTimeKind.Unspecified) });

            migrationBuilder.UpdateData(
                table: "TimeRegistrations",
                keyColumn: "TimeRegistrationId",
                keyValue: 576,
                columns: new[] { "EndTime", "StartTime" },
                values: new object[] { new DateTime(2024, 8, 31, 19, 53, 2, 0, DateTimeKind.Unspecified), new DateTime(2024, 5, 17, 10, 13, 39, 0, DateTimeKind.Unspecified) });

            migrationBuilder.UpdateData(
                table: "TimeRegistrations",
                keyColumn: "TimeRegistrationId",
                keyValue: 577,
                columns: new[] { "EndTime", "StartTime" },
                values: new object[] { new DateTime(2024, 2, 8, 2, 15, 8, 0, DateTimeKind.Unspecified), new DateTime(2024, 4, 16, 7, 38, 38, 0, DateTimeKind.Unspecified) });

            migrationBuilder.UpdateData(
                table: "TimeRegistrations",
                keyColumn: "TimeRegistrationId",
                keyValue: 578,
                columns: new[] { "EndTime", "StartTime" },
                values: new object[] { new DateTime(2024, 10, 24, 16, 47, 48, 0, DateTimeKind.Unspecified), new DateTime(2024, 5, 22, 3, 1, 21, 0, DateTimeKind.Unspecified) });

            migrationBuilder.UpdateData(
                table: "TimeRegistrations",
                keyColumn: "TimeRegistrationId",
                keyValue: 579,
                columns: new[] { "EndTime", "StartTime" },
                values: new object[] { new DateTime(2024, 3, 2, 23, 2, 7, 0, DateTimeKind.Unspecified), new DateTime(2024, 4, 11, 14, 11, 26, 0, DateTimeKind.Unspecified) });

            migrationBuilder.UpdateData(
                table: "TimeRegistrations",
                keyColumn: "TimeRegistrationId",
                keyValue: 580,
                columns: new[] { "EndTime", "StartTime" },
                values: new object[] { new DateTime(2024, 6, 13, 1, 55, 59, 0, DateTimeKind.Unspecified), new DateTime(2024, 7, 2, 17, 17, 21, 0, DateTimeKind.Unspecified) });

            migrationBuilder.UpdateData(
                table: "TimeRegistrations",
                keyColumn: "TimeRegistrationId",
                keyValue: 581,
                columns: new[] { "EndTime", "StartTime" },
                values: new object[] { new DateTime(2024, 11, 27, 3, 40, 25, 0, DateTimeKind.Unspecified), new DateTime(2024, 5, 29, 8, 25, 27, 0, DateTimeKind.Unspecified) });

            migrationBuilder.UpdateData(
                table: "TimeRegistrations",
                keyColumn: "TimeRegistrationId",
                keyValue: 582,
                columns: new[] { "EndTime", "StartTime" },
                values: new object[] { new DateTime(2024, 11, 16, 18, 30, 37, 0, DateTimeKind.Unspecified), new DateTime(2024, 5, 6, 21, 25, 55, 0, DateTimeKind.Unspecified) });

            migrationBuilder.UpdateData(
                table: "TimeRegistrations",
                keyColumn: "TimeRegistrationId",
                keyValue: 583,
                columns: new[] { "EndTime", "StartTime" },
                values: new object[] { new DateTime(2024, 7, 12, 20, 55, 9, 0, DateTimeKind.Unspecified), new DateTime(2024, 11, 8, 13, 56, 9, 0, DateTimeKind.Unspecified) });

            migrationBuilder.UpdateData(
                table: "TimeRegistrations",
                keyColumn: "TimeRegistrationId",
                keyValue: 584,
                columns: new[] { "EndTime", "StartTime" },
                values: new object[] { new DateTime(2024, 12, 23, 20, 42, 1, 0, DateTimeKind.Unspecified), new DateTime(2024, 8, 7, 5, 57, 21, 0, DateTimeKind.Unspecified) });

            migrationBuilder.UpdateData(
                table: "TimeRegistrations",
                keyColumn: "TimeRegistrationId",
                keyValue: 585,
                columns: new[] { "EndTime", "StartTime" },
                values: new object[] { new DateTime(2024, 10, 30, 19, 0, 22, 0, DateTimeKind.Unspecified), new DateTime(2024, 9, 10, 20, 53, 7, 0, DateTimeKind.Unspecified) });

            migrationBuilder.UpdateData(
                table: "TimeRegistrations",
                keyColumn: "TimeRegistrationId",
                keyValue: 586,
                columns: new[] { "EndTime", "StartTime" },
                values: new object[] { new DateTime(2024, 6, 24, 15, 33, 0, 0, DateTimeKind.Unspecified), new DateTime(2024, 3, 20, 6, 15, 15, 0, DateTimeKind.Unspecified) });

            migrationBuilder.UpdateData(
                table: "TimeRegistrations",
                keyColumn: "TimeRegistrationId",
                keyValue: 587,
                columns: new[] { "EndTime", "StartTime" },
                values: new object[] { new DateTime(2024, 9, 17, 19, 8, 42, 0, DateTimeKind.Unspecified), new DateTime(2024, 12, 14, 4, 24, 34, 0, DateTimeKind.Unspecified) });

            migrationBuilder.UpdateData(
                table: "TimeRegistrations",
                keyColumn: "TimeRegistrationId",
                keyValue: 588,
                columns: new[] { "EndTime", "StartTime" },
                values: new object[] { new DateTime(2024, 5, 4, 11, 46, 43, 0, DateTimeKind.Unspecified), new DateTime(2024, 3, 10, 1, 17, 30, 0, DateTimeKind.Unspecified) });

            migrationBuilder.UpdateData(
                table: "TimeRegistrations",
                keyColumn: "TimeRegistrationId",
                keyValue: 589,
                columns: new[] { "EndTime", "StartTime" },
                values: new object[] { new DateTime(2024, 6, 10, 7, 54, 16, 0, DateTimeKind.Unspecified), new DateTime(2024, 4, 8, 6, 28, 42, 0, DateTimeKind.Unspecified) });

            migrationBuilder.UpdateData(
                table: "TimeRegistrations",
                keyColumn: "TimeRegistrationId",
                keyValue: 590,
                columns: new[] { "EndTime", "StartTime" },
                values: new object[] { new DateTime(2024, 4, 10, 2, 45, 34, 0, DateTimeKind.Unspecified), new DateTime(2024, 1, 10, 9, 11, 21, 0, DateTimeKind.Unspecified) });

            migrationBuilder.UpdateData(
                table: "TimeRegistrations",
                keyColumn: "TimeRegistrationId",
                keyValue: 591,
                columns: new[] { "EndTime", "StartTime" },
                values: new object[] { new DateTime(2024, 11, 16, 6, 7, 16, 0, DateTimeKind.Unspecified), new DateTime(2024, 7, 25, 5, 12, 16, 0, DateTimeKind.Unspecified) });

            migrationBuilder.UpdateData(
                table: "TimeRegistrations",
                keyColumn: "TimeRegistrationId",
                keyValue: 592,
                columns: new[] { "EndTime", "StartTime" },
                values: new object[] { new DateTime(2024, 9, 21, 20, 17, 15, 0, DateTimeKind.Unspecified), new DateTime(2024, 12, 8, 7, 46, 28, 0, DateTimeKind.Unspecified) });

            migrationBuilder.UpdateData(
                table: "TimeRegistrations",
                keyColumn: "TimeRegistrationId",
                keyValue: 593,
                columns: new[] { "EndTime", "StartTime" },
                values: new object[] { new DateTime(2024, 12, 20, 1, 39, 31, 0, DateTimeKind.Unspecified), new DateTime(2024, 5, 13, 4, 0, 50, 0, DateTimeKind.Unspecified) });

            migrationBuilder.UpdateData(
                table: "TimeRegistrations",
                keyColumn: "TimeRegistrationId",
                keyValue: 594,
                columns: new[] { "EndTime", "StartTime" },
                values: new object[] { new DateTime(2024, 9, 10, 7, 15, 15, 0, DateTimeKind.Unspecified), new DateTime(2024, 8, 5, 0, 4, 19, 0, DateTimeKind.Unspecified) });

            migrationBuilder.UpdateData(
                table: "TimeRegistrations",
                keyColumn: "TimeRegistrationId",
                keyValue: 595,
                columns: new[] { "EndTime", "StartTime" },
                values: new object[] { new DateTime(2024, 5, 2, 15, 53, 56, 0, DateTimeKind.Unspecified), new DateTime(2024, 4, 1, 23, 55, 23, 0, DateTimeKind.Unspecified) });

            migrationBuilder.UpdateData(
                table: "TimeRegistrations",
                keyColumn: "TimeRegistrationId",
                keyValue: 596,
                columns: new[] { "EndTime", "StartTime" },
                values: new object[] { new DateTime(2024, 9, 16, 18, 14, 50, 0, DateTimeKind.Unspecified), new DateTime(2024, 3, 12, 10, 54, 26, 0, DateTimeKind.Unspecified) });

            migrationBuilder.UpdateData(
                table: "TimeRegistrations",
                keyColumn: "TimeRegistrationId",
                keyValue: 597,
                columns: new[] { "EndTime", "StartTime" },
                values: new object[] { new DateTime(2024, 3, 8, 8, 49, 33, 0, DateTimeKind.Unspecified), new DateTime(2024, 1, 20, 22, 6, 21, 0, DateTimeKind.Unspecified) });

            migrationBuilder.UpdateData(
                table: "TimeRegistrations",
                keyColumn: "TimeRegistrationId",
                keyValue: 598,
                columns: new[] { "EndTime", "StartTime" },
                values: new object[] { new DateTime(2024, 5, 22, 19, 27, 33, 0, DateTimeKind.Unspecified), new DateTime(2024, 7, 24, 11, 20, 16, 0, DateTimeKind.Unspecified) });

            migrationBuilder.UpdateData(
                table: "TimeRegistrations",
                keyColumn: "TimeRegistrationId",
                keyValue: 599,
                columns: new[] { "EndTime", "StartTime" },
                values: new object[] { new DateTime(2024, 7, 26, 21, 56, 28, 0, DateTimeKind.Unspecified), new DateTime(2024, 10, 13, 18, 39, 51, 0, DateTimeKind.Unspecified) });

            migrationBuilder.UpdateData(
                table: "TimeRegistrations",
                keyColumn: "TimeRegistrationId",
                keyValue: 600,
                columns: new[] { "EndTime", "StartTime" },
                values: new object[] { new DateTime(2024, 10, 14, 19, 48, 53, 0, DateTimeKind.Unspecified), new DateTime(2024, 3, 30, 16, 40, 9, 0, DateTimeKind.Unspecified) });

            migrationBuilder.UpdateData(
                table: "TimeRegistrations",
                keyColumn: "TimeRegistrationId",
                keyValue: 601,
                columns: new[] { "EndTime", "StartTime" },
                values: new object[] { new DateTime(2024, 7, 27, 12, 32, 40, 0, DateTimeKind.Unspecified), new DateTime(2024, 2, 25, 19, 33, 23, 0, DateTimeKind.Unspecified) });

            migrationBuilder.UpdateData(
                table: "TimeRegistrations",
                keyColumn: "TimeRegistrationId",
                keyValue: 602,
                columns: new[] { "EndTime", "StartTime" },
                values: new object[] { new DateTime(2024, 8, 13, 4, 34, 7, 0, DateTimeKind.Unspecified), new DateTime(2024, 9, 14, 13, 0, 39, 0, DateTimeKind.Unspecified) });

            migrationBuilder.UpdateData(
                table: "TimeRegistrations",
                keyColumn: "TimeRegistrationId",
                keyValue: 603,
                columns: new[] { "EndTime", "StartTime" },
                values: new object[] { new DateTime(2024, 2, 29, 8, 11, 49, 0, DateTimeKind.Unspecified), new DateTime(2024, 5, 7, 3, 50, 59, 0, DateTimeKind.Unspecified) });

            migrationBuilder.UpdateData(
                table: "TimeRegistrations",
                keyColumn: "TimeRegistrationId",
                keyValue: 604,
                columns: new[] { "EndTime", "StartTime" },
                values: new object[] { new DateTime(2024, 12, 8, 5, 22, 35, 0, DateTimeKind.Unspecified), new DateTime(2024, 7, 22, 18, 26, 17, 0, DateTimeKind.Unspecified) });

            migrationBuilder.UpdateData(
                table: "TimeRegistrations",
                keyColumn: "TimeRegistrationId",
                keyValue: 605,
                columns: new[] { "EndTime", "StartTime" },
                values: new object[] { new DateTime(2024, 8, 23, 7, 47, 8, 0, DateTimeKind.Unspecified), new DateTime(2024, 4, 27, 2, 12, 38, 0, DateTimeKind.Unspecified) });

            migrationBuilder.UpdateData(
                table: "TimeRegistrations",
                keyColumn: "TimeRegistrationId",
                keyValue: 606,
                columns: new[] { "EndTime", "StartTime" },
                values: new object[] { new DateTime(2024, 8, 28, 7, 13, 43, 0, DateTimeKind.Unspecified), new DateTime(2024, 4, 15, 22, 49, 23, 0, DateTimeKind.Unspecified) });

            migrationBuilder.UpdateData(
                table: "TimeRegistrations",
                keyColumn: "TimeRegistrationId",
                keyValue: 607,
                columns: new[] { "EndTime", "StartTime" },
                values: new object[] { new DateTime(2024, 6, 30, 20, 48, 29, 0, DateTimeKind.Unspecified), new DateTime(2024, 9, 16, 8, 26, 34, 0, DateTimeKind.Unspecified) });

            migrationBuilder.UpdateData(
                table: "TimeRegistrations",
                keyColumn: "TimeRegistrationId",
                keyValue: 608,
                columns: new[] { "EndTime", "StartTime" },
                values: new object[] { new DateTime(2024, 8, 7, 9, 48, 59, 0, DateTimeKind.Unspecified), new DateTime(2024, 6, 7, 4, 30, 3, 0, DateTimeKind.Unspecified) });

            migrationBuilder.UpdateData(
                table: "TimeRegistrations",
                keyColumn: "TimeRegistrationId",
                keyValue: 609,
                columns: new[] { "EndTime", "StartTime" },
                values: new object[] { new DateTime(2024, 8, 25, 16, 34, 14, 0, DateTimeKind.Unspecified), new DateTime(2024, 12, 12, 7, 17, 3, 0, DateTimeKind.Unspecified) });

            migrationBuilder.UpdateData(
                table: "TimeRegistrations",
                keyColumn: "TimeRegistrationId",
                keyValue: 610,
                columns: new[] { "EndTime", "StartTime" },
                values: new object[] { new DateTime(2024, 4, 17, 12, 10, 37, 0, DateTimeKind.Unspecified), new DateTime(2024, 6, 1, 20, 29, 21, 0, DateTimeKind.Unspecified) });

            migrationBuilder.UpdateData(
                table: "TimeRegistrations",
                keyColumn: "TimeRegistrationId",
                keyValue: 611,
                columns: new[] { "EndTime", "StartTime" },
                values: new object[] { new DateTime(2024, 6, 15, 14, 25, 21, 0, DateTimeKind.Unspecified), new DateTime(2024, 7, 25, 2, 48, 55, 0, DateTimeKind.Unspecified) });

            migrationBuilder.UpdateData(
                table: "TimeRegistrations",
                keyColumn: "TimeRegistrationId",
                keyValue: 612,
                columns: new[] { "EndTime", "StartTime" },
                values: new object[] { new DateTime(2024, 5, 11, 23, 12, 5, 0, DateTimeKind.Unspecified), new DateTime(2024, 12, 9, 21, 6, 36, 0, DateTimeKind.Unspecified) });

            migrationBuilder.UpdateData(
                table: "TimeRegistrations",
                keyColumn: "TimeRegistrationId",
                keyValue: 613,
                columns: new[] { "EndTime", "StartTime" },
                values: new object[] { new DateTime(2024, 6, 13, 13, 50, 39, 0, DateTimeKind.Unspecified), new DateTime(2024, 12, 14, 2, 22, 13, 0, DateTimeKind.Unspecified) });

            migrationBuilder.UpdateData(
                table: "TimeRegistrations",
                keyColumn: "TimeRegistrationId",
                keyValue: 614,
                columns: new[] { "EndTime", "StartTime" },
                values: new object[] { new DateTime(2024, 6, 12, 20, 38, 3, 0, DateTimeKind.Unspecified), new DateTime(2024, 6, 3, 11, 30, 1, 0, DateTimeKind.Unspecified) });

            migrationBuilder.UpdateData(
                table: "TimeRegistrations",
                keyColumn: "TimeRegistrationId",
                keyValue: 615,
                columns: new[] { "EndTime", "StartTime" },
                values: new object[] { new DateTime(2024, 12, 4, 20, 1, 59, 0, DateTimeKind.Unspecified), new DateTime(2024, 4, 26, 8, 37, 52, 0, DateTimeKind.Unspecified) });

            migrationBuilder.UpdateData(
                table: "TimeRegistrations",
                keyColumn: "TimeRegistrationId",
                keyValue: 616,
                columns: new[] { "EndTime", "StartTime" },
                values: new object[] { new DateTime(2024, 1, 27, 20, 45, 17, 0, DateTimeKind.Unspecified), new DateTime(2024, 4, 20, 1, 33, 14, 0, DateTimeKind.Unspecified) });

            migrationBuilder.UpdateData(
                table: "TimeRegistrations",
                keyColumn: "TimeRegistrationId",
                keyValue: 617,
                columns: new[] { "EndTime", "StartTime" },
                values: new object[] { new DateTime(2024, 2, 22, 3, 49, 53, 0, DateTimeKind.Unspecified), new DateTime(2024, 6, 4, 16, 30, 23, 0, DateTimeKind.Unspecified) });

            migrationBuilder.UpdateData(
                table: "TimeRegistrations",
                keyColumn: "TimeRegistrationId",
                keyValue: 618,
                columns: new[] { "EndTime", "StartTime" },
                values: new object[] { new DateTime(2024, 4, 12, 8, 14, 26, 0, DateTimeKind.Unspecified), new DateTime(2024, 1, 31, 8, 17, 50, 0, DateTimeKind.Unspecified) });

            migrationBuilder.UpdateData(
                table: "TimeRegistrations",
                keyColumn: "TimeRegistrationId",
                keyValue: 619,
                columns: new[] { "EndTime", "StartTime" },
                values: new object[] { new DateTime(2024, 5, 26, 4, 23, 44, 0, DateTimeKind.Unspecified), new DateTime(2024, 10, 14, 15, 53, 55, 0, DateTimeKind.Unspecified) });

            migrationBuilder.UpdateData(
                table: "TimeRegistrations",
                keyColumn: "TimeRegistrationId",
                keyValue: 620,
                columns: new[] { "EndTime", "StartTime" },
                values: new object[] { new DateTime(2024, 3, 17, 3, 36, 35, 0, DateTimeKind.Unspecified), new DateTime(2024, 10, 9, 8, 35, 34, 0, DateTimeKind.Unspecified) });

            migrationBuilder.UpdateData(
                table: "TimeRegistrations",
                keyColumn: "TimeRegistrationId",
                keyValue: 621,
                columns: new[] { "EndTime", "StartTime" },
                values: new object[] { new DateTime(2024, 2, 12, 0, 33, 49, 0, DateTimeKind.Unspecified), new DateTime(2024, 2, 3, 11, 52, 18, 0, DateTimeKind.Unspecified) });

            migrationBuilder.UpdateData(
                table: "TimeRegistrations",
                keyColumn: "TimeRegistrationId",
                keyValue: 622,
                columns: new[] { "EndTime", "StartTime" },
                values: new object[] { new DateTime(2024, 6, 5, 20, 3, 59, 0, DateTimeKind.Unspecified), new DateTime(2024, 1, 9, 11, 59, 25, 0, DateTimeKind.Unspecified) });

            migrationBuilder.UpdateData(
                table: "TimeRegistrations",
                keyColumn: "TimeRegistrationId",
                keyValue: 623,
                columns: new[] { "EndTime", "StartTime" },
                values: new object[] { new DateTime(2024, 6, 22, 16, 21, 40, 0, DateTimeKind.Unspecified), new DateTime(2024, 4, 13, 10, 23, 27, 0, DateTimeKind.Unspecified) });

            migrationBuilder.UpdateData(
                table: "TimeRegistrations",
                keyColumn: "TimeRegistrationId",
                keyValue: 624,
                columns: new[] { "EndTime", "StartTime" },
                values: new object[] { new DateTime(2024, 12, 9, 21, 40, 51, 0, DateTimeKind.Unspecified), new DateTime(2024, 8, 21, 14, 28, 44, 0, DateTimeKind.Unspecified) });

            migrationBuilder.UpdateData(
                table: "TimeRegistrations",
                keyColumn: "TimeRegistrationId",
                keyValue: 625,
                columns: new[] { "EndTime", "StartTime" },
                values: new object[] { new DateTime(2024, 5, 31, 14, 13, 33, 0, DateTimeKind.Unspecified), new DateTime(2024, 3, 26, 3, 17, 33, 0, DateTimeKind.Unspecified) });

            migrationBuilder.UpdateData(
                table: "TimeRegistrations",
                keyColumn: "TimeRegistrationId",
                keyValue: 626,
                columns: new[] { "EndTime", "StartTime" },
                values: new object[] { new DateTime(2024, 1, 7, 21, 37, 3, 0, DateTimeKind.Unspecified), new DateTime(2024, 7, 17, 16, 0, 51, 0, DateTimeKind.Unspecified) });

            migrationBuilder.UpdateData(
                table: "TimeRegistrations",
                keyColumn: "TimeRegistrationId",
                keyValue: 627,
                columns: new[] { "EndTime", "StartTime" },
                values: new object[] { new DateTime(2024, 6, 5, 17, 3, 34, 0, DateTimeKind.Unspecified), new DateTime(2024, 6, 20, 8, 59, 7, 0, DateTimeKind.Unspecified) });

            migrationBuilder.UpdateData(
                table: "TimeRegistrations",
                keyColumn: "TimeRegistrationId",
                keyValue: 628,
                columns: new[] { "EndTime", "StartTime" },
                values: new object[] { new DateTime(2024, 5, 17, 5, 15, 53, 0, DateTimeKind.Unspecified), new DateTime(2024, 10, 29, 17, 39, 1, 0, DateTimeKind.Unspecified) });

            migrationBuilder.UpdateData(
                table: "TimeRegistrations",
                keyColumn: "TimeRegistrationId",
                keyValue: 629,
                columns: new[] { "EndTime", "StartTime" },
                values: new object[] { new DateTime(2024, 1, 1, 17, 2, 34, 0, DateTimeKind.Unspecified), new DateTime(2024, 7, 25, 4, 18, 40, 0, DateTimeKind.Unspecified) });

            migrationBuilder.UpdateData(
                table: "TimeRegistrations",
                keyColumn: "TimeRegistrationId",
                keyValue: 630,
                columns: new[] { "EndTime", "StartTime" },
                values: new object[] { new DateTime(2024, 1, 10, 0, 43, 26, 0, DateTimeKind.Unspecified), new DateTime(2024, 3, 11, 20, 16, 47, 0, DateTimeKind.Unspecified) });

            migrationBuilder.UpdateData(
                table: "TimeRegistrations",
                keyColumn: "TimeRegistrationId",
                keyValue: 631,
                columns: new[] { "EndTime", "StartTime" },
                values: new object[] { new DateTime(2024, 8, 15, 6, 55, 13, 0, DateTimeKind.Unspecified), new DateTime(2024, 2, 2, 14, 20, 59, 0, DateTimeKind.Unspecified) });

            migrationBuilder.UpdateData(
                table: "TimeRegistrations",
                keyColumn: "TimeRegistrationId",
                keyValue: 632,
                columns: new[] { "EndTime", "StartTime" },
                values: new object[] { new DateTime(2024, 4, 17, 13, 28, 11, 0, DateTimeKind.Unspecified), new DateTime(2024, 9, 4, 21, 45, 45, 0, DateTimeKind.Unspecified) });

            migrationBuilder.UpdateData(
                table: "TimeRegistrations",
                keyColumn: "TimeRegistrationId",
                keyValue: 633,
                columns: new[] { "EndTime", "StartTime" },
                values: new object[] { new DateTime(2024, 8, 30, 3, 44, 47, 0, DateTimeKind.Unspecified), new DateTime(2024, 8, 13, 16, 51, 36, 0, DateTimeKind.Unspecified) });

            migrationBuilder.UpdateData(
                table: "TimeRegistrations",
                keyColumn: "TimeRegistrationId",
                keyValue: 634,
                columns: new[] { "EndTime", "StartTime" },
                values: new object[] { new DateTime(2024, 10, 1, 22, 46, 40, 0, DateTimeKind.Unspecified), new DateTime(2024, 7, 28, 4, 13, 21, 0, DateTimeKind.Unspecified) });

            migrationBuilder.UpdateData(
                table: "TimeRegistrations",
                keyColumn: "TimeRegistrationId",
                keyValue: 635,
                columns: new[] { "EndTime", "StartTime" },
                values: new object[] { new DateTime(2024, 4, 4, 14, 39, 17, 0, DateTimeKind.Unspecified), new DateTime(2024, 7, 1, 8, 2, 18, 0, DateTimeKind.Unspecified) });

            migrationBuilder.UpdateData(
                table: "TimeRegistrations",
                keyColumn: "TimeRegistrationId",
                keyValue: 636,
                columns: new[] { "EndTime", "StartTime" },
                values: new object[] { new DateTime(2024, 6, 23, 20, 15, 28, 0, DateTimeKind.Unspecified), new DateTime(2024, 3, 22, 15, 17, 53, 0, DateTimeKind.Unspecified) });

            migrationBuilder.UpdateData(
                table: "TimeRegistrations",
                keyColumn: "TimeRegistrationId",
                keyValue: 637,
                columns: new[] { "EndTime", "StartTime" },
                values: new object[] { new DateTime(2024, 4, 21, 18, 5, 36, 0, DateTimeKind.Unspecified), new DateTime(2024, 9, 29, 6, 50, 53, 0, DateTimeKind.Unspecified) });

            migrationBuilder.UpdateData(
                table: "TimeRegistrations",
                keyColumn: "TimeRegistrationId",
                keyValue: 638,
                columns: new[] { "EndTime", "StartTime" },
                values: new object[] { new DateTime(2024, 7, 17, 1, 43, 3, 0, DateTimeKind.Unspecified), new DateTime(2024, 3, 28, 8, 35, 27, 0, DateTimeKind.Unspecified) });

            migrationBuilder.UpdateData(
                table: "TimeRegistrations",
                keyColumn: "TimeRegistrationId",
                keyValue: 639,
                columns: new[] { "EndTime", "StartTime" },
                values: new object[] { new DateTime(2024, 4, 28, 20, 25, 10, 0, DateTimeKind.Unspecified), new DateTime(2024, 1, 23, 2, 55, 13, 0, DateTimeKind.Unspecified) });

            migrationBuilder.UpdateData(
                table: "TimeRegistrations",
                keyColumn: "TimeRegistrationId",
                keyValue: 640,
                columns: new[] { "EndTime", "StartTime" },
                values: new object[] { new DateTime(2024, 10, 8, 11, 40, 17, 0, DateTimeKind.Unspecified), new DateTime(2024, 2, 20, 12, 53, 12, 0, DateTimeKind.Unspecified) });

            migrationBuilder.UpdateData(
                table: "TimeRegistrations",
                keyColumn: "TimeRegistrationId",
                keyValue: 641,
                columns: new[] { "EndTime", "StartTime" },
                values: new object[] { new DateTime(2024, 11, 23, 18, 39, 15, 0, DateTimeKind.Unspecified), new DateTime(2024, 2, 9, 7, 59, 11, 0, DateTimeKind.Unspecified) });

            migrationBuilder.UpdateData(
                table: "TimeRegistrations",
                keyColumn: "TimeRegistrationId",
                keyValue: 642,
                columns: new[] { "EndTime", "StartTime" },
                values: new object[] { new DateTime(2024, 10, 23, 2, 38, 45, 0, DateTimeKind.Unspecified), new DateTime(2024, 3, 13, 16, 57, 22, 0, DateTimeKind.Unspecified) });

            migrationBuilder.UpdateData(
                table: "TimeRegistrations",
                keyColumn: "TimeRegistrationId",
                keyValue: 643,
                columns: new[] { "EndTime", "StartTime" },
                values: new object[] { new DateTime(2024, 7, 14, 4, 19, 6, 0, DateTimeKind.Unspecified), new DateTime(2024, 3, 14, 20, 21, 23, 0, DateTimeKind.Unspecified) });

            migrationBuilder.UpdateData(
                table: "TimeRegistrations",
                keyColumn: "TimeRegistrationId",
                keyValue: 644,
                columns: new[] { "EndTime", "StartTime" },
                values: new object[] { new DateTime(2024, 6, 16, 15, 11, 47, 0, DateTimeKind.Unspecified), new DateTime(2024, 6, 21, 23, 20, 5, 0, DateTimeKind.Unspecified) });

            migrationBuilder.UpdateData(
                table: "TimeRegistrations",
                keyColumn: "TimeRegistrationId",
                keyValue: 645,
                columns: new[] { "EndTime", "StartTime" },
                values: new object[] { new DateTime(2024, 11, 2, 0, 38, 5, 0, DateTimeKind.Unspecified), new DateTime(2024, 8, 8, 3, 51, 13, 0, DateTimeKind.Unspecified) });

            migrationBuilder.UpdateData(
                table: "TimeRegistrations",
                keyColumn: "TimeRegistrationId",
                keyValue: 646,
                columns: new[] { "EndTime", "StartTime" },
                values: new object[] { new DateTime(2024, 8, 7, 11, 37, 9, 0, DateTimeKind.Unspecified), new DateTime(2024, 4, 18, 23, 37, 4, 0, DateTimeKind.Unspecified) });

            migrationBuilder.UpdateData(
                table: "TimeRegistrations",
                keyColumn: "TimeRegistrationId",
                keyValue: 647,
                columns: new[] { "EndTime", "StartTime" },
                values: new object[] { new DateTime(2024, 10, 29, 21, 41, 33, 0, DateTimeKind.Unspecified), new DateTime(2024, 12, 17, 19, 35, 24, 0, DateTimeKind.Unspecified) });

            migrationBuilder.UpdateData(
                table: "TimeRegistrations",
                keyColumn: "TimeRegistrationId",
                keyValue: 648,
                columns: new[] { "EndTime", "StartTime" },
                values: new object[] { new DateTime(2024, 12, 27, 14, 29, 22, 0, DateTimeKind.Unspecified), new DateTime(2024, 8, 22, 22, 54, 29, 0, DateTimeKind.Unspecified) });

            migrationBuilder.UpdateData(
                table: "TimeRegistrations",
                keyColumn: "TimeRegistrationId",
                keyValue: 649,
                columns: new[] { "EndTime", "StartTime" },
                values: new object[] { new DateTime(2024, 4, 22, 2, 12, 53, 0, DateTimeKind.Unspecified), new DateTime(2024, 12, 9, 10, 58, 9, 0, DateTimeKind.Unspecified) });

            migrationBuilder.UpdateData(
                table: "TimeRegistrations",
                keyColumn: "TimeRegistrationId",
                keyValue: 650,
                columns: new[] { "EndTime", "StartTime" },
                values: new object[] { new DateTime(2024, 2, 19, 2, 0, 41, 0, DateTimeKind.Unspecified), new DateTime(2024, 8, 15, 20, 32, 15, 0, DateTimeKind.Unspecified) });

            migrationBuilder.UpdateData(
                table: "TimeRegistrations",
                keyColumn: "TimeRegistrationId",
                keyValue: 651,
                columns: new[] { "EndTime", "StartTime" },
                values: new object[] { new DateTime(2024, 10, 2, 2, 38, 52, 0, DateTimeKind.Unspecified), new DateTime(2024, 6, 25, 12, 6, 2, 0, DateTimeKind.Unspecified) });

            migrationBuilder.UpdateData(
                table: "TimeRegistrations",
                keyColumn: "TimeRegistrationId",
                keyValue: 652,
                columns: new[] { "EndTime", "StartTime" },
                values: new object[] { new DateTime(2024, 3, 10, 10, 58, 44, 0, DateTimeKind.Unspecified), new DateTime(2024, 7, 4, 1, 16, 2, 0, DateTimeKind.Unspecified) });

            migrationBuilder.UpdateData(
                table: "TimeRegistrations",
                keyColumn: "TimeRegistrationId",
                keyValue: 653,
                columns: new[] { "EndTime", "StartTime" },
                values: new object[] { new DateTime(2024, 9, 25, 15, 39, 49, 0, DateTimeKind.Unspecified), new DateTime(2024, 10, 18, 9, 45, 36, 0, DateTimeKind.Unspecified) });

            migrationBuilder.UpdateData(
                table: "TimeRegistrations",
                keyColumn: "TimeRegistrationId",
                keyValue: 654,
                columns: new[] { "EndTime", "StartTime" },
                values: new object[] { new DateTime(2024, 5, 13, 16, 30, 55, 0, DateTimeKind.Unspecified), new DateTime(2024, 6, 2, 5, 21, 32, 0, DateTimeKind.Unspecified) });

            migrationBuilder.UpdateData(
                table: "TimeRegistrations",
                keyColumn: "TimeRegistrationId",
                keyValue: 655,
                columns: new[] { "EndTime", "StartTime" },
                values: new object[] { new DateTime(2024, 2, 17, 19, 0, 26, 0, DateTimeKind.Unspecified), new DateTime(2024, 10, 25, 12, 42, 52, 0, DateTimeKind.Unspecified) });

            migrationBuilder.UpdateData(
                table: "TimeRegistrations",
                keyColumn: "TimeRegistrationId",
                keyValue: 656,
                columns: new[] { "EndTime", "StartTime" },
                values: new object[] { new DateTime(2024, 11, 14, 13, 33, 3, 0, DateTimeKind.Unspecified), new DateTime(2024, 1, 17, 8, 6, 18, 0, DateTimeKind.Unspecified) });

            migrationBuilder.UpdateData(
                table: "TimeRegistrations",
                keyColumn: "TimeRegistrationId",
                keyValue: 657,
                columns: new[] { "EndTime", "StartTime" },
                values: new object[] { new DateTime(2024, 9, 30, 19, 33, 9, 0, DateTimeKind.Unspecified), new DateTime(2024, 2, 11, 15, 5, 23, 0, DateTimeKind.Unspecified) });

            migrationBuilder.UpdateData(
                table: "TimeRegistrations",
                keyColumn: "TimeRegistrationId",
                keyValue: 658,
                columns: new[] { "EndTime", "StartTime" },
                values: new object[] { new DateTime(2024, 2, 3, 0, 42, 27, 0, DateTimeKind.Unspecified), new DateTime(2024, 6, 9, 5, 59, 11, 0, DateTimeKind.Unspecified) });

            migrationBuilder.UpdateData(
                table: "TimeRegistrations",
                keyColumn: "TimeRegistrationId",
                keyValue: 659,
                columns: new[] { "EndTime", "StartTime" },
                values: new object[] { new DateTime(2024, 6, 14, 5, 12, 16, 0, DateTimeKind.Unspecified), new DateTime(2024, 4, 18, 5, 3, 59, 0, DateTimeKind.Unspecified) });

            migrationBuilder.UpdateData(
                table: "TimeRegistrations",
                keyColumn: "TimeRegistrationId",
                keyValue: 660,
                columns: new[] { "EndTime", "StartTime" },
                values: new object[] { new DateTime(2024, 12, 9, 15, 31, 31, 0, DateTimeKind.Unspecified), new DateTime(2024, 7, 27, 12, 3, 38, 0, DateTimeKind.Unspecified) });

            migrationBuilder.UpdateData(
                table: "TimeRegistrations",
                keyColumn: "TimeRegistrationId",
                keyValue: 661,
                columns: new[] { "EndTime", "StartTime" },
                values: new object[] { new DateTime(2024, 11, 24, 20, 55, 34, 0, DateTimeKind.Unspecified), new DateTime(2024, 1, 16, 21, 26, 33, 0, DateTimeKind.Unspecified) });

            migrationBuilder.UpdateData(
                table: "TimeRegistrations",
                keyColumn: "TimeRegistrationId",
                keyValue: 662,
                columns: new[] { "EndTime", "StartTime" },
                values: new object[] { new DateTime(2024, 7, 25, 18, 4, 40, 0, DateTimeKind.Unspecified), new DateTime(2024, 5, 11, 18, 20, 14, 0, DateTimeKind.Unspecified) });

            migrationBuilder.UpdateData(
                table: "TimeRegistrations",
                keyColumn: "TimeRegistrationId",
                keyValue: 663,
                columns: new[] { "EndTime", "StartTime" },
                values: new object[] { new DateTime(2024, 10, 1, 23, 46, 54, 0, DateTimeKind.Unspecified), new DateTime(2024, 2, 3, 13, 11, 23, 0, DateTimeKind.Unspecified) });

            migrationBuilder.UpdateData(
                table: "TimeRegistrations",
                keyColumn: "TimeRegistrationId",
                keyValue: 664,
                columns: new[] { "EndTime", "StartTime" },
                values: new object[] { new DateTime(2024, 3, 1, 22, 57, 33, 0, DateTimeKind.Unspecified), new DateTime(2024, 11, 7, 9, 48, 50, 0, DateTimeKind.Unspecified) });

            migrationBuilder.UpdateData(
                table: "TimeRegistrations",
                keyColumn: "TimeRegistrationId",
                keyValue: 665,
                columns: new[] { "EndTime", "StartTime" },
                values: new object[] { new DateTime(2024, 1, 19, 4, 10, 37, 0, DateTimeKind.Unspecified), new DateTime(2024, 3, 7, 3, 28, 52, 0, DateTimeKind.Unspecified) });

            migrationBuilder.UpdateData(
                table: "TimeRegistrations",
                keyColumn: "TimeRegistrationId",
                keyValue: 666,
                columns: new[] { "EndTime", "StartTime" },
                values: new object[] { new DateTime(2024, 12, 17, 16, 54, 6, 0, DateTimeKind.Unspecified), new DateTime(2024, 4, 18, 6, 19, 6, 0, DateTimeKind.Unspecified) });

            migrationBuilder.UpdateData(
                table: "TimeRegistrations",
                keyColumn: "TimeRegistrationId",
                keyValue: 667,
                columns: new[] { "EndTime", "StartTime" },
                values: new object[] { new DateTime(2024, 1, 4, 4, 9, 25, 0, DateTimeKind.Unspecified), new DateTime(2024, 12, 22, 22, 6, 44, 0, DateTimeKind.Unspecified) });

            migrationBuilder.UpdateData(
                table: "TimeRegistrations",
                keyColumn: "TimeRegistrationId",
                keyValue: 668,
                columns: new[] { "EndTime", "StartTime" },
                values: new object[] { new DateTime(2024, 1, 23, 21, 18, 1, 0, DateTimeKind.Unspecified), new DateTime(2024, 1, 28, 23, 50, 56, 0, DateTimeKind.Unspecified) });

            migrationBuilder.UpdateData(
                table: "TimeRegistrations",
                keyColumn: "TimeRegistrationId",
                keyValue: 669,
                columns: new[] { "EndTime", "StartTime" },
                values: new object[] { new DateTime(2024, 11, 17, 23, 5, 54, 0, DateTimeKind.Unspecified), new DateTime(2024, 3, 13, 2, 19, 58, 0, DateTimeKind.Unspecified) });

            migrationBuilder.UpdateData(
                table: "TimeRegistrations",
                keyColumn: "TimeRegistrationId",
                keyValue: 670,
                columns: new[] { "EndTime", "StartTime" },
                values: new object[] { new DateTime(2024, 6, 10, 5, 48, 15, 0, DateTimeKind.Unspecified), new DateTime(2024, 3, 23, 7, 1, 7, 0, DateTimeKind.Unspecified) });

            migrationBuilder.UpdateData(
                table: "TimeRegistrations",
                keyColumn: "TimeRegistrationId",
                keyValue: 671,
                columns: new[] { "EndTime", "StartTime" },
                values: new object[] { new DateTime(2024, 1, 7, 0, 41, 43, 0, DateTimeKind.Unspecified), new DateTime(2024, 11, 30, 1, 5, 47, 0, DateTimeKind.Unspecified) });

            migrationBuilder.UpdateData(
                table: "TimeRegistrations",
                keyColumn: "TimeRegistrationId",
                keyValue: 672,
                columns: new[] { "EndTime", "StartTime" },
                values: new object[] { new DateTime(2024, 1, 14, 13, 3, 14, 0, DateTimeKind.Unspecified), new DateTime(2024, 8, 15, 3, 14, 0, 0, DateTimeKind.Unspecified) });

            migrationBuilder.UpdateData(
                table: "TimeRegistrations",
                keyColumn: "TimeRegistrationId",
                keyValue: 673,
                columns: new[] { "EndTime", "StartTime" },
                values: new object[] { new DateTime(2024, 12, 7, 20, 24, 16, 0, DateTimeKind.Unspecified), new DateTime(2024, 1, 3, 12, 57, 43, 0, DateTimeKind.Unspecified) });

            migrationBuilder.UpdateData(
                table: "TimeRegistrations",
                keyColumn: "TimeRegistrationId",
                keyValue: 674,
                columns: new[] { "EndTime", "StartTime" },
                values: new object[] { new DateTime(2024, 6, 16, 3, 17, 13, 0, DateTimeKind.Unspecified), new DateTime(2024, 2, 11, 11, 46, 34, 0, DateTimeKind.Unspecified) });

            migrationBuilder.UpdateData(
                table: "TimeRegistrations",
                keyColumn: "TimeRegistrationId",
                keyValue: 675,
                columns: new[] { "EndTime", "StartTime" },
                values: new object[] { new DateTime(2024, 3, 20, 6, 21, 31, 0, DateTimeKind.Unspecified), new DateTime(2024, 10, 2, 17, 40, 18, 0, DateTimeKind.Unspecified) });

            migrationBuilder.UpdateData(
                table: "TimeRegistrations",
                keyColumn: "TimeRegistrationId",
                keyValue: 676,
                columns: new[] { "EndTime", "StartTime" },
                values: new object[] { new DateTime(2024, 5, 11, 5, 1, 21, 0, DateTimeKind.Unspecified), new DateTime(2024, 7, 21, 19, 31, 35, 0, DateTimeKind.Unspecified) });

            migrationBuilder.UpdateData(
                table: "TimeRegistrations",
                keyColumn: "TimeRegistrationId",
                keyValue: 677,
                columns: new[] { "EndTime", "StartTime" },
                values: new object[] { new DateTime(2024, 1, 10, 18, 17, 44, 0, DateTimeKind.Unspecified), new DateTime(2024, 2, 12, 15, 22, 3, 0, DateTimeKind.Unspecified) });

            migrationBuilder.UpdateData(
                table: "TimeRegistrations",
                keyColumn: "TimeRegistrationId",
                keyValue: 678,
                columns: new[] { "EndTime", "StartTime" },
                values: new object[] { new DateTime(2024, 11, 16, 13, 56, 40, 0, DateTimeKind.Unspecified), new DateTime(2024, 11, 8, 3, 48, 19, 0, DateTimeKind.Unspecified) });

            migrationBuilder.UpdateData(
                table: "TimeRegistrations",
                keyColumn: "TimeRegistrationId",
                keyValue: 679,
                columns: new[] { "EndTime", "StartTime" },
                values: new object[] { new DateTime(2024, 6, 24, 20, 20, 55, 0, DateTimeKind.Unspecified), new DateTime(2024, 5, 30, 4, 1, 28, 0, DateTimeKind.Unspecified) });

            migrationBuilder.UpdateData(
                table: "TimeRegistrations",
                keyColumn: "TimeRegistrationId",
                keyValue: 680,
                columns: new[] { "EndTime", "StartTime" },
                values: new object[] { new DateTime(2024, 3, 7, 22, 54, 51, 0, DateTimeKind.Unspecified), new DateTime(2024, 3, 29, 19, 59, 6, 0, DateTimeKind.Unspecified) });

            migrationBuilder.UpdateData(
                table: "TimeRegistrations",
                keyColumn: "TimeRegistrationId",
                keyValue: 681,
                columns: new[] { "EndTime", "StartTime" },
                values: new object[] { new DateTime(2024, 10, 27, 21, 16, 42, 0, DateTimeKind.Unspecified), new DateTime(2024, 2, 2, 11, 30, 55, 0, DateTimeKind.Unspecified) });

            migrationBuilder.UpdateData(
                table: "TimeRegistrations",
                keyColumn: "TimeRegistrationId",
                keyValue: 682,
                columns: new[] { "EndTime", "StartTime" },
                values: new object[] { new DateTime(2024, 1, 14, 13, 0, 13, 0, DateTimeKind.Unspecified), new DateTime(2024, 4, 10, 14, 4, 31, 0, DateTimeKind.Unspecified) });

            migrationBuilder.UpdateData(
                table: "TimeRegistrations",
                keyColumn: "TimeRegistrationId",
                keyValue: 683,
                columns: new[] { "EndTime", "StartTime" },
                values: new object[] { new DateTime(2024, 6, 9, 13, 32, 9, 0, DateTimeKind.Unspecified), new DateTime(2024, 6, 27, 22, 45, 44, 0, DateTimeKind.Unspecified) });

            migrationBuilder.UpdateData(
                table: "TimeRegistrations",
                keyColumn: "TimeRegistrationId",
                keyValue: 684,
                columns: new[] { "EndTime", "StartTime" },
                values: new object[] { new DateTime(2024, 7, 8, 23, 52, 19, 0, DateTimeKind.Unspecified), new DateTime(2024, 7, 11, 0, 8, 13, 0, DateTimeKind.Unspecified) });

            migrationBuilder.UpdateData(
                table: "TimeRegistrations",
                keyColumn: "TimeRegistrationId",
                keyValue: 685,
                columns: new[] { "EndTime", "StartTime" },
                values: new object[] { new DateTime(2024, 5, 8, 15, 12, 44, 0, DateTimeKind.Unspecified), new DateTime(2024, 1, 25, 11, 53, 25, 0, DateTimeKind.Unspecified) });

            migrationBuilder.UpdateData(
                table: "TimeRegistrations",
                keyColumn: "TimeRegistrationId",
                keyValue: 686,
                columns: new[] { "EndTime", "StartTime" },
                values: new object[] { new DateTime(2024, 4, 6, 14, 27, 8, 0, DateTimeKind.Unspecified), new DateTime(2024, 12, 10, 21, 55, 3, 0, DateTimeKind.Unspecified) });

            migrationBuilder.UpdateData(
                table: "TimeRegistrations",
                keyColumn: "TimeRegistrationId",
                keyValue: 687,
                columns: new[] { "EndTime", "StartTime" },
                values: new object[] { new DateTime(2024, 11, 22, 12, 52, 57, 0, DateTimeKind.Unspecified), new DateTime(2024, 9, 21, 11, 59, 17, 0, DateTimeKind.Unspecified) });

            migrationBuilder.UpdateData(
                table: "TimeRegistrations",
                keyColumn: "TimeRegistrationId",
                keyValue: 688,
                columns: new[] { "EndTime", "StartTime" },
                values: new object[] { new DateTime(2024, 1, 22, 10, 32, 32, 0, DateTimeKind.Unspecified), new DateTime(2024, 6, 6, 11, 39, 21, 0, DateTimeKind.Unspecified) });

            migrationBuilder.UpdateData(
                table: "TimeRegistrations",
                keyColumn: "TimeRegistrationId",
                keyValue: 689,
                columns: new[] { "EndTime", "StartTime" },
                values: new object[] { new DateTime(2024, 5, 18, 15, 30, 3, 0, DateTimeKind.Unspecified), new DateTime(2024, 11, 16, 3, 27, 6, 0, DateTimeKind.Unspecified) });

            migrationBuilder.UpdateData(
                table: "TimeRegistrations",
                keyColumn: "TimeRegistrationId",
                keyValue: 690,
                columns: new[] { "EndTime", "StartTime" },
                values: new object[] { new DateTime(2024, 1, 22, 5, 57, 34, 0, DateTimeKind.Unspecified), new DateTime(2024, 7, 6, 13, 55, 31, 0, DateTimeKind.Unspecified) });

            migrationBuilder.UpdateData(
                table: "TimeRegistrations",
                keyColumn: "TimeRegistrationId",
                keyValue: 691,
                columns: new[] { "EndTime", "StartTime" },
                values: new object[] { new DateTime(2024, 11, 13, 17, 6, 17, 0, DateTimeKind.Unspecified), new DateTime(2024, 8, 10, 22, 57, 59, 0, DateTimeKind.Unspecified) });

            migrationBuilder.UpdateData(
                table: "TimeRegistrations",
                keyColumn: "TimeRegistrationId",
                keyValue: 692,
                columns: new[] { "EndTime", "StartTime" },
                values: new object[] { new DateTime(2024, 2, 4, 21, 27, 53, 0, DateTimeKind.Unspecified), new DateTime(2024, 9, 13, 14, 22, 26, 0, DateTimeKind.Unspecified) });

            migrationBuilder.UpdateData(
                table: "TimeRegistrations",
                keyColumn: "TimeRegistrationId",
                keyValue: 693,
                columns: new[] { "EndTime", "StartTime" },
                values: new object[] { new DateTime(2024, 2, 12, 23, 39, 44, 0, DateTimeKind.Unspecified), new DateTime(2024, 5, 30, 10, 54, 28, 0, DateTimeKind.Unspecified) });

            migrationBuilder.UpdateData(
                table: "TimeRegistrations",
                keyColumn: "TimeRegistrationId",
                keyValue: 694,
                columns: new[] { "EndTime", "StartTime" },
                values: new object[] { new DateTime(2024, 3, 13, 10, 9, 28, 0, DateTimeKind.Unspecified), new DateTime(2024, 4, 28, 18, 5, 24, 0, DateTimeKind.Unspecified) });

            migrationBuilder.UpdateData(
                table: "TimeRegistrations",
                keyColumn: "TimeRegistrationId",
                keyValue: 695,
                columns: new[] { "EndTime", "StartTime" },
                values: new object[] { new DateTime(2024, 7, 28, 19, 41, 5, 0, DateTimeKind.Unspecified), new DateTime(2024, 10, 8, 3, 8, 11, 0, DateTimeKind.Unspecified) });

            migrationBuilder.UpdateData(
                table: "TimeRegistrations",
                keyColumn: "TimeRegistrationId",
                keyValue: 696,
                columns: new[] { "EndTime", "StartTime" },
                values: new object[] { new DateTime(2024, 7, 9, 18, 5, 20, 0, DateTimeKind.Unspecified), new DateTime(2024, 12, 19, 12, 57, 25, 0, DateTimeKind.Unspecified) });

            migrationBuilder.UpdateData(
                table: "TimeRegistrations",
                keyColumn: "TimeRegistrationId",
                keyValue: 697,
                columns: new[] { "EndTime", "StartTime" },
                values: new object[] { new DateTime(2024, 7, 9, 19, 47, 52, 0, DateTimeKind.Unspecified), new DateTime(2024, 3, 29, 10, 59, 15, 0, DateTimeKind.Unspecified) });

            migrationBuilder.UpdateData(
                table: "TimeRegistrations",
                keyColumn: "TimeRegistrationId",
                keyValue: 698,
                columns: new[] { "EndTime", "StartTime" },
                values: new object[] { new DateTime(2024, 2, 5, 11, 50, 8, 0, DateTimeKind.Unspecified), new DateTime(2024, 9, 6, 23, 9, 56, 0, DateTimeKind.Unspecified) });

            migrationBuilder.UpdateData(
                table: "TimeRegistrations",
                keyColumn: "TimeRegistrationId",
                keyValue: 699,
                columns: new[] { "EndTime", "StartTime" },
                values: new object[] { new DateTime(2024, 7, 14, 16, 13, 39, 0, DateTimeKind.Unspecified), new DateTime(2024, 9, 23, 18, 41, 5, 0, DateTimeKind.Unspecified) });

            migrationBuilder.UpdateData(
                table: "TimeRegistrations",
                keyColumn: "TimeRegistrationId",
                keyValue: 700,
                columns: new[] { "EndTime", "StartTime" },
                values: new object[] { new DateTime(2024, 6, 21, 17, 34, 13, 0, DateTimeKind.Unspecified), new DateTime(2024, 12, 22, 9, 12, 22, 0, DateTimeKind.Unspecified) });

            migrationBuilder.UpdateData(
                table: "TimeRegistrations",
                keyColumn: "TimeRegistrationId",
                keyValue: 701,
                columns: new[] { "EndTime", "StartTime" },
                values: new object[] { new DateTime(2024, 5, 19, 17, 3, 21, 0, DateTimeKind.Unspecified), new DateTime(2024, 1, 21, 1, 59, 3, 0, DateTimeKind.Unspecified) });

            migrationBuilder.UpdateData(
                table: "TimeRegistrations",
                keyColumn: "TimeRegistrationId",
                keyValue: 702,
                columns: new[] { "EndTime", "StartTime" },
                values: new object[] { new DateTime(2024, 12, 16, 16, 57, 22, 0, DateTimeKind.Unspecified), new DateTime(2024, 6, 29, 6, 22, 1, 0, DateTimeKind.Unspecified) });

            migrationBuilder.UpdateData(
                table: "TimeRegistrations",
                keyColumn: "TimeRegistrationId",
                keyValue: 703,
                columns: new[] { "EndTime", "StartTime" },
                values: new object[] { new DateTime(2024, 4, 20, 11, 52, 37, 0, DateTimeKind.Unspecified), new DateTime(2024, 4, 27, 20, 56, 14, 0, DateTimeKind.Unspecified) });

            migrationBuilder.UpdateData(
                table: "TimeRegistrations",
                keyColumn: "TimeRegistrationId",
                keyValue: 704,
                columns: new[] { "EndTime", "StartTime" },
                values: new object[] { new DateTime(2024, 5, 13, 17, 5, 25, 0, DateTimeKind.Unspecified), new DateTime(2024, 5, 21, 17, 13, 31, 0, DateTimeKind.Unspecified) });

            migrationBuilder.UpdateData(
                table: "TimeRegistrations",
                keyColumn: "TimeRegistrationId",
                keyValue: 705,
                columns: new[] { "EndTime", "StartTime" },
                values: new object[] { new DateTime(2024, 12, 15, 5, 35, 13, 0, DateTimeKind.Unspecified), new DateTime(2024, 3, 6, 11, 27, 26, 0, DateTimeKind.Unspecified) });

            migrationBuilder.UpdateData(
                table: "TimeRegistrations",
                keyColumn: "TimeRegistrationId",
                keyValue: 706,
                columns: new[] { "EndTime", "StartTime" },
                values: new object[] { new DateTime(2024, 11, 21, 16, 5, 19, 0, DateTimeKind.Unspecified), new DateTime(2024, 2, 17, 23, 58, 34, 0, DateTimeKind.Unspecified) });

            migrationBuilder.UpdateData(
                table: "TimeRegistrations",
                keyColumn: "TimeRegistrationId",
                keyValue: 707,
                columns: new[] { "EndTime", "StartTime" },
                values: new object[] { new DateTime(2024, 10, 28, 3, 33, 47, 0, DateTimeKind.Unspecified), new DateTime(2024, 4, 20, 14, 37, 54, 0, DateTimeKind.Unspecified) });

            migrationBuilder.UpdateData(
                table: "TimeRegistrations",
                keyColumn: "TimeRegistrationId",
                keyValue: 708,
                columns: new[] { "EndTime", "StartTime" },
                values: new object[] { new DateTime(2024, 4, 14, 11, 23, 27, 0, DateTimeKind.Unspecified), new DateTime(2024, 6, 27, 22, 21, 50, 0, DateTimeKind.Unspecified) });

            migrationBuilder.UpdateData(
                table: "TimeRegistrations",
                keyColumn: "TimeRegistrationId",
                keyValue: 709,
                columns: new[] { "EndTime", "StartTime" },
                values: new object[] { new DateTime(2024, 11, 6, 8, 18, 37, 0, DateTimeKind.Unspecified), new DateTime(2024, 5, 24, 12, 59, 54, 0, DateTimeKind.Unspecified) });

            migrationBuilder.UpdateData(
                table: "TimeRegistrations",
                keyColumn: "TimeRegistrationId",
                keyValue: 710,
                columns: new[] { "EndTime", "StartTime" },
                values: new object[] { new DateTime(2024, 3, 9, 11, 30, 43, 0, DateTimeKind.Unspecified), new DateTime(2024, 10, 29, 5, 50, 6, 0, DateTimeKind.Unspecified) });

            migrationBuilder.UpdateData(
                table: "TimeRegistrations",
                keyColumn: "TimeRegistrationId",
                keyValue: 711,
                columns: new[] { "EndTime", "StartTime" },
                values: new object[] { new DateTime(2024, 9, 11, 11, 42, 36, 0, DateTimeKind.Unspecified), new DateTime(2024, 12, 20, 16, 5, 58, 0, DateTimeKind.Unspecified) });

            migrationBuilder.UpdateData(
                table: "TimeRegistrations",
                keyColumn: "TimeRegistrationId",
                keyValue: 712,
                columns: new[] { "EndTime", "StartTime" },
                values: new object[] { new DateTime(2024, 3, 29, 4, 29, 52, 0, DateTimeKind.Unspecified), new DateTime(2024, 10, 15, 11, 46, 59, 0, DateTimeKind.Unspecified) });

            migrationBuilder.UpdateData(
                table: "TimeRegistrations",
                keyColumn: "TimeRegistrationId",
                keyValue: 713,
                columns: new[] { "EndTime", "StartTime" },
                values: new object[] { new DateTime(2024, 1, 2, 15, 40, 48, 0, DateTimeKind.Unspecified), new DateTime(2024, 10, 5, 7, 16, 54, 0, DateTimeKind.Unspecified) });

            migrationBuilder.UpdateData(
                table: "TimeRegistrations",
                keyColumn: "TimeRegistrationId",
                keyValue: 714,
                columns: new[] { "EndTime", "StartTime" },
                values: new object[] { new DateTime(2024, 7, 20, 10, 34, 23, 0, DateTimeKind.Unspecified), new DateTime(2024, 5, 5, 15, 42, 26, 0, DateTimeKind.Unspecified) });

            migrationBuilder.UpdateData(
                table: "TimeRegistrations",
                keyColumn: "TimeRegistrationId",
                keyValue: 715,
                columns: new[] { "EndTime", "StartTime" },
                values: new object[] { new DateTime(2024, 7, 21, 3, 56, 36, 0, DateTimeKind.Unspecified), new DateTime(2024, 11, 26, 11, 15, 24, 0, DateTimeKind.Unspecified) });

            migrationBuilder.UpdateData(
                table: "TimeRegistrations",
                keyColumn: "TimeRegistrationId",
                keyValue: 716,
                columns: new[] { "EndTime", "StartTime" },
                values: new object[] { new DateTime(2024, 6, 3, 3, 0, 26, 0, DateTimeKind.Unspecified), new DateTime(2024, 10, 3, 16, 49, 27, 0, DateTimeKind.Unspecified) });

            migrationBuilder.UpdateData(
                table: "TimeRegistrations",
                keyColumn: "TimeRegistrationId",
                keyValue: 717,
                columns: new[] { "EndTime", "StartTime" },
                values: new object[] { new DateTime(2024, 12, 14, 19, 18, 9, 0, DateTimeKind.Unspecified), new DateTime(2024, 11, 24, 19, 34, 46, 0, DateTimeKind.Unspecified) });

            migrationBuilder.UpdateData(
                table: "TimeRegistrations",
                keyColumn: "TimeRegistrationId",
                keyValue: 718,
                columns: new[] { "EndTime", "StartTime" },
                values: new object[] { new DateTime(2024, 7, 25, 14, 16, 1, 0, DateTimeKind.Unspecified), new DateTime(2024, 10, 19, 4, 16, 26, 0, DateTimeKind.Unspecified) });

            migrationBuilder.UpdateData(
                table: "TimeRegistrations",
                keyColumn: "TimeRegistrationId",
                keyValue: 719,
                columns: new[] { "EndTime", "StartTime" },
                values: new object[] { new DateTime(2024, 10, 7, 6, 29, 38, 0, DateTimeKind.Unspecified), new DateTime(2024, 4, 12, 19, 5, 11, 0, DateTimeKind.Unspecified) });

            migrationBuilder.UpdateData(
                table: "TimeRegistrations",
                keyColumn: "TimeRegistrationId",
                keyValue: 720,
                columns: new[] { "EndTime", "StartTime" },
                values: new object[] { new DateTime(2024, 6, 16, 13, 13, 38, 0, DateTimeKind.Unspecified), new DateTime(2024, 9, 23, 3, 4, 49, 0, DateTimeKind.Unspecified) });

            migrationBuilder.UpdateData(
                table: "TimeRegistrations",
                keyColumn: "TimeRegistrationId",
                keyValue: 721,
                columns: new[] { "EndTime", "StartTime" },
                values: new object[] { new DateTime(2024, 12, 6, 0, 18, 15, 0, DateTimeKind.Unspecified), new DateTime(2024, 9, 6, 11, 37, 26, 0, DateTimeKind.Unspecified) });

            migrationBuilder.UpdateData(
                table: "TimeRegistrations",
                keyColumn: "TimeRegistrationId",
                keyValue: 722,
                columns: new[] { "EndTime", "StartTime" },
                values: new object[] { new DateTime(2024, 8, 15, 0, 7, 32, 0, DateTimeKind.Unspecified), new DateTime(2024, 10, 18, 8, 30, 30, 0, DateTimeKind.Unspecified) });

            migrationBuilder.UpdateData(
                table: "TimeRegistrations",
                keyColumn: "TimeRegistrationId",
                keyValue: 723,
                columns: new[] { "EndTime", "StartTime" },
                values: new object[] { new DateTime(2024, 11, 24, 8, 50, 38, 0, DateTimeKind.Unspecified), new DateTime(2024, 11, 20, 8, 16, 16, 0, DateTimeKind.Unspecified) });

            migrationBuilder.UpdateData(
                table: "TimeRegistrations",
                keyColumn: "TimeRegistrationId",
                keyValue: 724,
                columns: new[] { "EndTime", "StartTime" },
                values: new object[] { new DateTime(2024, 5, 22, 22, 31, 37, 0, DateTimeKind.Unspecified), new DateTime(2024, 1, 14, 4, 59, 27, 0, DateTimeKind.Unspecified) });

            migrationBuilder.UpdateData(
                table: "TimeRegistrations",
                keyColumn: "TimeRegistrationId",
                keyValue: 725,
                columns: new[] { "EndTime", "StartTime" },
                values: new object[] { new DateTime(2024, 8, 2, 11, 2, 10, 0, DateTimeKind.Unspecified), new DateTime(2024, 7, 10, 4, 13, 48, 0, DateTimeKind.Unspecified) });

            migrationBuilder.UpdateData(
                table: "TimeRegistrations",
                keyColumn: "TimeRegistrationId",
                keyValue: 726,
                columns: new[] { "EndTime", "StartTime" },
                values: new object[] { new DateTime(2024, 3, 16, 20, 5, 55, 0, DateTimeKind.Unspecified), new DateTime(2024, 2, 16, 5, 54, 25, 0, DateTimeKind.Unspecified) });

            migrationBuilder.UpdateData(
                table: "TimeRegistrations",
                keyColumn: "TimeRegistrationId",
                keyValue: 727,
                columns: new[] { "EndTime", "StartTime" },
                values: new object[] { new DateTime(2024, 7, 13, 1, 31, 12, 0, DateTimeKind.Unspecified), new DateTime(2024, 9, 19, 9, 25, 47, 0, DateTimeKind.Unspecified) });

            migrationBuilder.UpdateData(
                table: "TimeRegistrations",
                keyColumn: "TimeRegistrationId",
                keyValue: 728,
                columns: new[] { "EndTime", "StartTime" },
                values: new object[] { new DateTime(2024, 3, 15, 11, 3, 4, 0, DateTimeKind.Unspecified), new DateTime(2024, 1, 4, 17, 1, 24, 0, DateTimeKind.Unspecified) });

            migrationBuilder.UpdateData(
                table: "TimeRegistrations",
                keyColumn: "TimeRegistrationId",
                keyValue: 729,
                columns: new[] { "EndTime", "StartTime" },
                values: new object[] { new DateTime(2024, 2, 19, 6, 18, 4, 0, DateTimeKind.Unspecified), new DateTime(2024, 3, 11, 10, 36, 52, 0, DateTimeKind.Unspecified) });

            migrationBuilder.UpdateData(
                table: "TimeRegistrations",
                keyColumn: "TimeRegistrationId",
                keyValue: 730,
                columns: new[] { "EndTime", "StartTime" },
                values: new object[] { new DateTime(2024, 4, 12, 14, 43, 17, 0, DateTimeKind.Unspecified), new DateTime(2024, 6, 16, 12, 46, 36, 0, DateTimeKind.Unspecified) });

            migrationBuilder.UpdateData(
                table: "TimeRegistrations",
                keyColumn: "TimeRegistrationId",
                keyValue: 731,
                columns: new[] { "EndTime", "StartTime" },
                values: new object[] { new DateTime(2024, 4, 12, 17, 56, 48, 0, DateTimeKind.Unspecified), new DateTime(2024, 6, 8, 17, 23, 53, 0, DateTimeKind.Unspecified) });

            migrationBuilder.UpdateData(
                table: "TimeRegistrations",
                keyColumn: "TimeRegistrationId",
                keyValue: 732,
                columns: new[] { "EndTime", "StartTime" },
                values: new object[] { new DateTime(2024, 6, 10, 5, 29, 6, 0, DateTimeKind.Unspecified), new DateTime(2024, 3, 2, 23, 46, 39, 0, DateTimeKind.Unspecified) });

            migrationBuilder.UpdateData(
                table: "TimeRegistrations",
                keyColumn: "TimeRegistrationId",
                keyValue: 733,
                columns: new[] { "EndTime", "StartTime" },
                values: new object[] { new DateTime(2024, 5, 14, 7, 31, 37, 0, DateTimeKind.Unspecified), new DateTime(2024, 5, 17, 0, 12, 56, 0, DateTimeKind.Unspecified) });

            migrationBuilder.UpdateData(
                table: "TimeRegistrations",
                keyColumn: "TimeRegistrationId",
                keyValue: 734,
                columns: new[] { "EndTime", "StartTime" },
                values: new object[] { new DateTime(2024, 7, 20, 9, 5, 25, 0, DateTimeKind.Unspecified), new DateTime(2024, 6, 30, 15, 30, 6, 0, DateTimeKind.Unspecified) });

            migrationBuilder.UpdateData(
                table: "TimeRegistrations",
                keyColumn: "TimeRegistrationId",
                keyValue: 735,
                columns: new[] { "EndTime", "StartTime" },
                values: new object[] { new DateTime(2024, 6, 20, 7, 35, 21, 0, DateTimeKind.Unspecified), new DateTime(2024, 4, 25, 18, 10, 19, 0, DateTimeKind.Unspecified) });

            migrationBuilder.UpdateData(
                table: "TimeRegistrations",
                keyColumn: "TimeRegistrationId",
                keyValue: 736,
                columns: new[] { "EndTime", "StartTime" },
                values: new object[] { new DateTime(2024, 4, 20, 11, 24, 21, 0, DateTimeKind.Unspecified), new DateTime(2024, 1, 26, 12, 28, 14, 0, DateTimeKind.Unspecified) });

            migrationBuilder.UpdateData(
                table: "TimeRegistrations",
                keyColumn: "TimeRegistrationId",
                keyValue: 737,
                columns: new[] { "EndTime", "StartTime" },
                values: new object[] { new DateTime(2024, 7, 1, 6, 41, 32, 0, DateTimeKind.Unspecified), new DateTime(2024, 4, 18, 19, 51, 43, 0, DateTimeKind.Unspecified) });

            migrationBuilder.UpdateData(
                table: "TimeRegistrations",
                keyColumn: "TimeRegistrationId",
                keyValue: 738,
                columns: new[] { "EndTime", "StartTime" },
                values: new object[] { new DateTime(2024, 9, 1, 0, 13, 8, 0, DateTimeKind.Unspecified), new DateTime(2024, 2, 17, 4, 19, 45, 0, DateTimeKind.Unspecified) });

            migrationBuilder.UpdateData(
                table: "TimeRegistrations",
                keyColumn: "TimeRegistrationId",
                keyValue: 739,
                columns: new[] { "EndTime", "StartTime" },
                values: new object[] { new DateTime(2024, 12, 26, 15, 12, 32, 0, DateTimeKind.Unspecified), new DateTime(2024, 2, 22, 7, 49, 44, 0, DateTimeKind.Unspecified) });

            migrationBuilder.UpdateData(
                table: "TimeRegistrations",
                keyColumn: "TimeRegistrationId",
                keyValue: 740,
                columns: new[] { "EndTime", "StartTime" },
                values: new object[] { new DateTime(2024, 12, 25, 8, 52, 40, 0, DateTimeKind.Unspecified), new DateTime(2024, 6, 29, 21, 12, 35, 0, DateTimeKind.Unspecified) });

            migrationBuilder.UpdateData(
                table: "TimeRegistrations",
                keyColumn: "TimeRegistrationId",
                keyValue: 741,
                columns: new[] { "EndTime", "StartTime" },
                values: new object[] { new DateTime(2024, 10, 26, 9, 29, 5, 0, DateTimeKind.Unspecified), new DateTime(2024, 1, 17, 11, 41, 30, 0, DateTimeKind.Unspecified) });

            migrationBuilder.UpdateData(
                table: "TimeRegistrations",
                keyColumn: "TimeRegistrationId",
                keyValue: 742,
                columns: new[] { "EndTime", "StartTime" },
                values: new object[] { new DateTime(2024, 9, 17, 17, 18, 42, 0, DateTimeKind.Unspecified), new DateTime(2024, 10, 7, 14, 33, 6, 0, DateTimeKind.Unspecified) });

            migrationBuilder.UpdateData(
                table: "TimeRegistrations",
                keyColumn: "TimeRegistrationId",
                keyValue: 743,
                columns: new[] { "EndTime", "StartTime" },
                values: new object[] { new DateTime(2024, 4, 23, 10, 39, 33, 0, DateTimeKind.Unspecified), new DateTime(2024, 5, 4, 8, 29, 1, 0, DateTimeKind.Unspecified) });

            migrationBuilder.UpdateData(
                table: "TimeRegistrations",
                keyColumn: "TimeRegistrationId",
                keyValue: 744,
                columns: new[] { "EndTime", "StartTime" },
                values: new object[] { new DateTime(2024, 6, 6, 17, 0, 37, 0, DateTimeKind.Unspecified), new DateTime(2024, 2, 15, 5, 38, 43, 0, DateTimeKind.Unspecified) });

            migrationBuilder.UpdateData(
                table: "TimeRegistrations",
                keyColumn: "TimeRegistrationId",
                keyValue: 745,
                columns: new[] { "EndTime", "StartTime" },
                values: new object[] { new DateTime(2024, 9, 18, 3, 50, 0, 0, DateTimeKind.Unspecified), new DateTime(2024, 1, 10, 11, 0, 9, 0, DateTimeKind.Unspecified) });

            migrationBuilder.UpdateData(
                table: "TimeRegistrations",
                keyColumn: "TimeRegistrationId",
                keyValue: 746,
                columns: new[] { "EndTime", "StartTime" },
                values: new object[] { new DateTime(2024, 9, 18, 14, 54, 14, 0, DateTimeKind.Unspecified), new DateTime(2024, 9, 22, 10, 40, 20, 0, DateTimeKind.Unspecified) });

            migrationBuilder.UpdateData(
                table: "TimeRegistrations",
                keyColumn: "TimeRegistrationId",
                keyValue: 747,
                columns: new[] { "EndTime", "StartTime" },
                values: new object[] { new DateTime(2024, 8, 5, 19, 22, 45, 0, DateTimeKind.Unspecified), new DateTime(2024, 6, 30, 0, 50, 24, 0, DateTimeKind.Unspecified) });

            migrationBuilder.UpdateData(
                table: "TimeRegistrations",
                keyColumn: "TimeRegistrationId",
                keyValue: 748,
                columns: new[] { "EndTime", "StartTime" },
                values: new object[] { new DateTime(2024, 6, 2, 19, 55, 20, 0, DateTimeKind.Unspecified), new DateTime(2024, 5, 21, 19, 17, 26, 0, DateTimeKind.Unspecified) });

            migrationBuilder.UpdateData(
                table: "TimeRegistrations",
                keyColumn: "TimeRegistrationId",
                keyValue: 749,
                columns: new[] { "EndTime", "StartTime" },
                values: new object[] { new DateTime(2024, 8, 11, 3, 26, 50, 0, DateTimeKind.Unspecified), new DateTime(2024, 10, 20, 1, 37, 6, 0, DateTimeKind.Unspecified) });

            migrationBuilder.UpdateData(
                table: "TimeRegistrations",
                keyColumn: "TimeRegistrationId",
                keyValue: 750,
                columns: new[] { "EndTime", "StartTime" },
                values: new object[] { new DateTime(2024, 4, 4, 3, 4, 40, 0, DateTimeKind.Unspecified), new DateTime(2024, 12, 20, 11, 46, 51, 0, DateTimeKind.Unspecified) });

            migrationBuilder.UpdateData(
                table: "TimeRegistrations",
                keyColumn: "TimeRegistrationId",
                keyValue: 751,
                columns: new[] { "EndTime", "StartTime" },
                values: new object[] { new DateTime(2024, 8, 10, 4, 17, 7, 0, DateTimeKind.Unspecified), new DateTime(2024, 12, 1, 18, 4, 47, 0, DateTimeKind.Unspecified) });

            migrationBuilder.UpdateData(
                table: "TimeRegistrations",
                keyColumn: "TimeRegistrationId",
                keyValue: 752,
                columns: new[] { "EndTime", "StartTime" },
                values: new object[] { new DateTime(2024, 9, 10, 22, 0, 15, 0, DateTimeKind.Unspecified), new DateTime(2024, 12, 18, 7, 27, 10, 0, DateTimeKind.Unspecified) });

            migrationBuilder.UpdateData(
                table: "TimeRegistrations",
                keyColumn: "TimeRegistrationId",
                keyValue: 753,
                columns: new[] { "EndTime", "StartTime" },
                values: new object[] { new DateTime(2024, 10, 4, 22, 4, 2, 0, DateTimeKind.Unspecified), new DateTime(2024, 7, 4, 6, 5, 52, 0, DateTimeKind.Unspecified) });

            migrationBuilder.UpdateData(
                table: "TimeRegistrations",
                keyColumn: "TimeRegistrationId",
                keyValue: 754,
                columns: new[] { "EndTime", "StartTime" },
                values: new object[] { new DateTime(2024, 8, 29, 14, 40, 2, 0, DateTimeKind.Unspecified), new DateTime(2024, 3, 28, 10, 41, 0, 0, DateTimeKind.Unspecified) });

            migrationBuilder.UpdateData(
                table: "TimeRegistrations",
                keyColumn: "TimeRegistrationId",
                keyValue: 755,
                columns: new[] { "EndTime", "StartTime" },
                values: new object[] { new DateTime(2024, 9, 6, 2, 0, 31, 0, DateTimeKind.Unspecified), new DateTime(2024, 11, 25, 4, 30, 45, 0, DateTimeKind.Unspecified) });

            migrationBuilder.UpdateData(
                table: "TimeRegistrations",
                keyColumn: "TimeRegistrationId",
                keyValue: 756,
                columns: new[] { "EndTime", "StartTime" },
                values: new object[] { new DateTime(2024, 8, 24, 15, 36, 45, 0, DateTimeKind.Unspecified), new DateTime(2024, 2, 5, 15, 11, 23, 0, DateTimeKind.Unspecified) });

            migrationBuilder.UpdateData(
                table: "TimeRegistrations",
                keyColumn: "TimeRegistrationId",
                keyValue: 757,
                columns: new[] { "EndTime", "StartTime" },
                values: new object[] { new DateTime(2024, 3, 28, 20, 19, 53, 0, DateTimeKind.Unspecified), new DateTime(2024, 6, 17, 9, 26, 30, 0, DateTimeKind.Unspecified) });

            migrationBuilder.UpdateData(
                table: "TimeRegistrations",
                keyColumn: "TimeRegistrationId",
                keyValue: 758,
                columns: new[] { "EndTime", "StartTime" },
                values: new object[] { new DateTime(2024, 2, 4, 18, 23, 52, 0, DateTimeKind.Unspecified), new DateTime(2024, 5, 9, 9, 1, 2, 0, DateTimeKind.Unspecified) });

            migrationBuilder.UpdateData(
                table: "TimeRegistrations",
                keyColumn: "TimeRegistrationId",
                keyValue: 759,
                columns: new[] { "EndTime", "StartTime" },
                values: new object[] { new DateTime(2024, 12, 27, 16, 16, 40, 0, DateTimeKind.Unspecified), new DateTime(2024, 9, 20, 6, 26, 6, 0, DateTimeKind.Unspecified) });

            migrationBuilder.UpdateData(
                table: "TimeRegistrations",
                keyColumn: "TimeRegistrationId",
                keyValue: 760,
                columns: new[] { "EndTime", "StartTime" },
                values: new object[] { new DateTime(2024, 1, 12, 14, 32, 7, 0, DateTimeKind.Unspecified), new DateTime(2024, 8, 21, 9, 50, 44, 0, DateTimeKind.Unspecified) });

            migrationBuilder.UpdateData(
                table: "TimeRegistrations",
                keyColumn: "TimeRegistrationId",
                keyValue: 761,
                columns: new[] { "EndTime", "StartTime" },
                values: new object[] { new DateTime(2024, 8, 24, 23, 12, 24, 0, DateTimeKind.Unspecified), new DateTime(2024, 5, 30, 1, 49, 1, 0, DateTimeKind.Unspecified) });

            migrationBuilder.UpdateData(
                table: "TimeRegistrations",
                keyColumn: "TimeRegistrationId",
                keyValue: 762,
                columns: new[] { "EndTime", "StartTime" },
                values: new object[] { new DateTime(2024, 6, 12, 6, 52, 32, 0, DateTimeKind.Unspecified), new DateTime(2024, 4, 5, 18, 13, 49, 0, DateTimeKind.Unspecified) });

            migrationBuilder.UpdateData(
                table: "TimeRegistrations",
                keyColumn: "TimeRegistrationId",
                keyValue: 763,
                columns: new[] { "EndTime", "StartTime" },
                values: new object[] { new DateTime(2024, 9, 17, 21, 45, 47, 0, DateTimeKind.Unspecified), new DateTime(2024, 8, 2, 2, 15, 47, 0, DateTimeKind.Unspecified) });

            migrationBuilder.UpdateData(
                table: "TimeRegistrations",
                keyColumn: "TimeRegistrationId",
                keyValue: 764,
                columns: new[] { "EndTime", "StartTime" },
                values: new object[] { new DateTime(2024, 11, 8, 23, 48, 52, 0, DateTimeKind.Unspecified), new DateTime(2024, 7, 10, 2, 27, 49, 0, DateTimeKind.Unspecified) });

            migrationBuilder.UpdateData(
                table: "TimeRegistrations",
                keyColumn: "TimeRegistrationId",
                keyValue: 765,
                columns: new[] { "EndTime", "StartTime" },
                values: new object[] { new DateTime(2024, 5, 25, 15, 28, 21, 0, DateTimeKind.Unspecified), new DateTime(2024, 6, 14, 13, 43, 15, 0, DateTimeKind.Unspecified) });

            migrationBuilder.UpdateData(
                table: "TimeRegistrations",
                keyColumn: "TimeRegistrationId",
                keyValue: 766,
                columns: new[] { "EndTime", "StartTime" },
                values: new object[] { new DateTime(2024, 9, 5, 16, 7, 59, 0, DateTimeKind.Unspecified), new DateTime(2024, 11, 7, 4, 41, 26, 0, DateTimeKind.Unspecified) });

            migrationBuilder.UpdateData(
                table: "TimeRegistrations",
                keyColumn: "TimeRegistrationId",
                keyValue: 767,
                columns: new[] { "EndTime", "StartTime" },
                values: new object[] { new DateTime(2024, 10, 24, 5, 7, 32, 0, DateTimeKind.Unspecified), new DateTime(2024, 8, 4, 22, 41, 18, 0, DateTimeKind.Unspecified) });

            migrationBuilder.UpdateData(
                table: "TimeRegistrations",
                keyColumn: "TimeRegistrationId",
                keyValue: 768,
                columns: new[] { "EndTime", "StartTime" },
                values: new object[] { new DateTime(2024, 8, 18, 8, 44, 47, 0, DateTimeKind.Unspecified), new DateTime(2024, 4, 19, 6, 18, 31, 0, DateTimeKind.Unspecified) });

            migrationBuilder.UpdateData(
                table: "TimeRegistrations",
                keyColumn: "TimeRegistrationId",
                keyValue: 769,
                columns: new[] { "EndTime", "StartTime" },
                values: new object[] { new DateTime(2024, 2, 4, 18, 52, 22, 0, DateTimeKind.Unspecified), new DateTime(2024, 9, 7, 13, 26, 10, 0, DateTimeKind.Unspecified) });

            migrationBuilder.UpdateData(
                table: "TimeRegistrations",
                keyColumn: "TimeRegistrationId",
                keyValue: 770,
                columns: new[] { "EndTime", "StartTime" },
                values: new object[] { new DateTime(2024, 8, 16, 8, 33, 2, 0, DateTimeKind.Unspecified), new DateTime(2024, 8, 6, 13, 43, 20, 0, DateTimeKind.Unspecified) });

            migrationBuilder.UpdateData(
                table: "TimeRegistrations",
                keyColumn: "TimeRegistrationId",
                keyValue: 771,
                columns: new[] { "EndTime", "StartTime" },
                values: new object[] { new DateTime(2024, 10, 4, 6, 16, 22, 0, DateTimeKind.Unspecified), new DateTime(2024, 5, 5, 14, 16, 53, 0, DateTimeKind.Unspecified) });

            migrationBuilder.UpdateData(
                table: "TimeRegistrations",
                keyColumn: "TimeRegistrationId",
                keyValue: 772,
                columns: new[] { "EndTime", "StartTime" },
                values: new object[] { new DateTime(2024, 5, 16, 12, 51, 53, 0, DateTimeKind.Unspecified), new DateTime(2024, 4, 4, 8, 1, 36, 0, DateTimeKind.Unspecified) });

            migrationBuilder.UpdateData(
                table: "TimeRegistrations",
                keyColumn: "TimeRegistrationId",
                keyValue: 773,
                columns: new[] { "EndTime", "StartTime" },
                values: new object[] { new DateTime(2024, 10, 27, 12, 1, 3, 0, DateTimeKind.Unspecified), new DateTime(2024, 8, 27, 1, 20, 56, 0, DateTimeKind.Unspecified) });

            migrationBuilder.UpdateData(
                table: "TimeRegistrations",
                keyColumn: "TimeRegistrationId",
                keyValue: 774,
                columns: new[] { "EndTime", "StartTime" },
                values: new object[] { new DateTime(2024, 11, 15, 9, 6, 51, 0, DateTimeKind.Unspecified), new DateTime(2024, 3, 14, 21, 32, 5, 0, DateTimeKind.Unspecified) });

            migrationBuilder.UpdateData(
                table: "TimeRegistrations",
                keyColumn: "TimeRegistrationId",
                keyValue: 775,
                columns: new[] { "EndTime", "StartTime" },
                values: new object[] { new DateTime(2024, 9, 29, 11, 40, 50, 0, DateTimeKind.Unspecified), new DateTime(2024, 4, 5, 21, 50, 1, 0, DateTimeKind.Unspecified) });

            migrationBuilder.UpdateData(
                table: "TimeRegistrations",
                keyColumn: "TimeRegistrationId",
                keyValue: 776,
                columns: new[] { "EndTime", "StartTime" },
                values: new object[] { new DateTime(2024, 8, 5, 3, 1, 36, 0, DateTimeKind.Unspecified), new DateTime(2024, 11, 19, 19, 49, 6, 0, DateTimeKind.Unspecified) });

            migrationBuilder.UpdateData(
                table: "TimeRegistrations",
                keyColumn: "TimeRegistrationId",
                keyValue: 777,
                columns: new[] { "EndTime", "StartTime" },
                values: new object[] { new DateTime(2024, 7, 8, 13, 22, 47, 0, DateTimeKind.Unspecified), new DateTime(2024, 3, 28, 17, 17, 58, 0, DateTimeKind.Unspecified) });

            migrationBuilder.UpdateData(
                table: "TimeRegistrations",
                keyColumn: "TimeRegistrationId",
                keyValue: 778,
                columns: new[] { "EndTime", "StartTime" },
                values: new object[] { new DateTime(2024, 3, 7, 0, 56, 28, 0, DateTimeKind.Unspecified), new DateTime(2024, 5, 12, 21, 58, 21, 0, DateTimeKind.Unspecified) });

            migrationBuilder.UpdateData(
                table: "TimeRegistrations",
                keyColumn: "TimeRegistrationId",
                keyValue: 779,
                columns: new[] { "EndTime", "StartTime" },
                values: new object[] { new DateTime(2024, 2, 16, 9, 49, 49, 0, DateTimeKind.Unspecified), new DateTime(2024, 8, 27, 23, 33, 31, 0, DateTimeKind.Unspecified) });

            migrationBuilder.UpdateData(
                table: "TimeRegistrations",
                keyColumn: "TimeRegistrationId",
                keyValue: 780,
                columns: new[] { "EndTime", "StartTime" },
                values: new object[] { new DateTime(2024, 5, 26, 23, 27, 52, 0, DateTimeKind.Unspecified), new DateTime(2024, 11, 4, 12, 28, 0, 0, DateTimeKind.Unspecified) });

            migrationBuilder.UpdateData(
                table: "TimeRegistrations",
                keyColumn: "TimeRegistrationId",
                keyValue: 781,
                columns: new[] { "EndTime", "StartTime" },
                values: new object[] { new DateTime(2024, 8, 21, 22, 53, 25, 0, DateTimeKind.Unspecified), new DateTime(2024, 7, 30, 13, 46, 25, 0, DateTimeKind.Unspecified) });

            migrationBuilder.UpdateData(
                table: "TimeRegistrations",
                keyColumn: "TimeRegistrationId",
                keyValue: 782,
                columns: new[] { "EndTime", "StartTime" },
                values: new object[] { new DateTime(2024, 11, 14, 19, 27, 7, 0, DateTimeKind.Unspecified), new DateTime(2024, 8, 13, 5, 0, 17, 0, DateTimeKind.Unspecified) });

            migrationBuilder.UpdateData(
                table: "TimeRegistrations",
                keyColumn: "TimeRegistrationId",
                keyValue: 783,
                columns: new[] { "EndTime", "StartTime" },
                values: new object[] { new DateTime(2024, 6, 23, 16, 5, 2, 0, DateTimeKind.Unspecified), new DateTime(2024, 5, 13, 22, 32, 24, 0, DateTimeKind.Unspecified) });

            migrationBuilder.UpdateData(
                table: "TimeRegistrations",
                keyColumn: "TimeRegistrationId",
                keyValue: 784,
                columns: new[] { "EndTime", "StartTime" },
                values: new object[] { new DateTime(2024, 10, 4, 8, 19, 26, 0, DateTimeKind.Unspecified), new DateTime(2024, 9, 5, 16, 53, 14, 0, DateTimeKind.Unspecified) });

            migrationBuilder.UpdateData(
                table: "TimeRegistrations",
                keyColumn: "TimeRegistrationId",
                keyValue: 785,
                columns: new[] { "EndTime", "StartTime" },
                values: new object[] { new DateTime(2024, 8, 1, 17, 43, 38, 0, DateTimeKind.Unspecified), new DateTime(2024, 9, 22, 0, 43, 21, 0, DateTimeKind.Unspecified) });

            migrationBuilder.UpdateData(
                table: "TimeRegistrations",
                keyColumn: "TimeRegistrationId",
                keyValue: 786,
                columns: new[] { "EndTime", "StartTime" },
                values: new object[] { new DateTime(2024, 9, 5, 15, 10, 43, 0, DateTimeKind.Unspecified), new DateTime(2024, 5, 6, 17, 49, 20, 0, DateTimeKind.Unspecified) });

            migrationBuilder.UpdateData(
                table: "TimeRegistrations",
                keyColumn: "TimeRegistrationId",
                keyValue: 787,
                columns: new[] { "EndTime", "StartTime" },
                values: new object[] { new DateTime(2024, 4, 20, 17, 7, 11, 0, DateTimeKind.Unspecified), new DateTime(2024, 11, 11, 0, 38, 8, 0, DateTimeKind.Unspecified) });

            migrationBuilder.UpdateData(
                table: "TimeRegistrations",
                keyColumn: "TimeRegistrationId",
                keyValue: 788,
                columns: new[] { "EndTime", "StartTime" },
                values: new object[] { new DateTime(2024, 12, 12, 14, 20, 20, 0, DateTimeKind.Unspecified), new DateTime(2024, 5, 19, 10, 22, 23, 0, DateTimeKind.Unspecified) });

            migrationBuilder.UpdateData(
                table: "TimeRegistrations",
                keyColumn: "TimeRegistrationId",
                keyValue: 789,
                columns: new[] { "EndTime", "StartTime" },
                values: new object[] { new DateTime(2024, 2, 24, 19, 54, 4, 0, DateTimeKind.Unspecified), new DateTime(2024, 7, 1, 18, 48, 19, 0, DateTimeKind.Unspecified) });

            migrationBuilder.UpdateData(
                table: "TimeRegistrations",
                keyColumn: "TimeRegistrationId",
                keyValue: 790,
                columns: new[] { "EndTime", "StartTime" },
                values: new object[] { new DateTime(2024, 5, 23, 3, 10, 51, 0, DateTimeKind.Unspecified), new DateTime(2024, 11, 15, 2, 59, 25, 0, DateTimeKind.Unspecified) });

            migrationBuilder.UpdateData(
                table: "TimeRegistrations",
                keyColumn: "TimeRegistrationId",
                keyValue: 791,
                columns: new[] { "EndTime", "StartTime" },
                values: new object[] { new DateTime(2024, 4, 28, 3, 13, 16, 0, DateTimeKind.Unspecified), new DateTime(2024, 6, 10, 9, 4, 13, 0, DateTimeKind.Unspecified) });

            migrationBuilder.UpdateData(
                table: "TimeRegistrations",
                keyColumn: "TimeRegistrationId",
                keyValue: 792,
                columns: new[] { "EndTime", "StartTime" },
                values: new object[] { new DateTime(2024, 12, 26, 17, 19, 39, 0, DateTimeKind.Unspecified), new DateTime(2024, 1, 9, 14, 21, 18, 0, DateTimeKind.Unspecified) });

            migrationBuilder.UpdateData(
                table: "TimeRegistrations",
                keyColumn: "TimeRegistrationId",
                keyValue: 793,
                columns: new[] { "EndTime", "StartTime" },
                values: new object[] { new DateTime(2024, 10, 27, 0, 8, 49, 0, DateTimeKind.Unspecified), new DateTime(2024, 7, 24, 0, 44, 55, 0, DateTimeKind.Unspecified) });

            migrationBuilder.UpdateData(
                table: "TimeRegistrations",
                keyColumn: "TimeRegistrationId",
                keyValue: 794,
                columns: new[] { "EndTime", "StartTime" },
                values: new object[] { new DateTime(2024, 7, 3, 13, 51, 14, 0, DateTimeKind.Unspecified), new DateTime(2024, 6, 20, 11, 32, 41, 0, DateTimeKind.Unspecified) });

            migrationBuilder.UpdateData(
                table: "TimeRegistrations",
                keyColumn: "TimeRegistrationId",
                keyValue: 795,
                columns: new[] { "EndTime", "StartTime" },
                values: new object[] { new DateTime(2024, 5, 18, 9, 7, 21, 0, DateTimeKind.Unspecified), new DateTime(2024, 7, 23, 14, 46, 48, 0, DateTimeKind.Unspecified) });

            migrationBuilder.UpdateData(
                table: "TimeRegistrations",
                keyColumn: "TimeRegistrationId",
                keyValue: 796,
                columns: new[] { "EndTime", "StartTime" },
                values: new object[] { new DateTime(2024, 7, 23, 4, 10, 14, 0, DateTimeKind.Unspecified), new DateTime(2024, 10, 30, 6, 50, 59, 0, DateTimeKind.Unspecified) });

            migrationBuilder.UpdateData(
                table: "TimeRegistrations",
                keyColumn: "TimeRegistrationId",
                keyValue: 797,
                columns: new[] { "EndTime", "StartTime" },
                values: new object[] { new DateTime(2024, 8, 24, 4, 43, 22, 0, DateTimeKind.Unspecified), new DateTime(2024, 10, 19, 8, 39, 3, 0, DateTimeKind.Unspecified) });

            migrationBuilder.UpdateData(
                table: "TimeRegistrations",
                keyColumn: "TimeRegistrationId",
                keyValue: 798,
                columns: new[] { "EndTime", "StartTime" },
                values: new object[] { new DateTime(2024, 8, 26, 14, 12, 53, 0, DateTimeKind.Unspecified), new DateTime(2024, 4, 23, 10, 14, 16, 0, DateTimeKind.Unspecified) });

            migrationBuilder.UpdateData(
                table: "TimeRegistrations",
                keyColumn: "TimeRegistrationId",
                keyValue: 799,
                columns: new[] { "EndTime", "StartTime" },
                values: new object[] { new DateTime(2024, 3, 29, 15, 32, 9, 0, DateTimeKind.Unspecified), new DateTime(2024, 2, 22, 9, 12, 28, 0, DateTimeKind.Unspecified) });

            migrationBuilder.UpdateData(
                table: "TimeRegistrations",
                keyColumn: "TimeRegistrationId",
                keyValue: 800,
                columns: new[] { "EndTime", "StartTime" },
                values: new object[] { new DateTime(2024, 4, 6, 6, 3, 31, 0, DateTimeKind.Unspecified), new DateTime(2024, 10, 13, 14, 31, 18, 0, DateTimeKind.Unspecified) });

            migrationBuilder.UpdateData(
                table: "TimeRegistrations",
                keyColumn: "TimeRegistrationId",
                keyValue: 801,
                columns: new[] { "EndTime", "StartTime" },
                values: new object[] { new DateTime(2024, 12, 9, 22, 24, 56, 0, DateTimeKind.Unspecified), new DateTime(2024, 8, 25, 13, 44, 37, 0, DateTimeKind.Unspecified) });

            migrationBuilder.UpdateData(
                table: "TimeRegistrations",
                keyColumn: "TimeRegistrationId",
                keyValue: 802,
                columns: new[] { "EndTime", "StartTime" },
                values: new object[] { new DateTime(2024, 8, 20, 10, 14, 10, 0, DateTimeKind.Unspecified), new DateTime(2024, 2, 6, 10, 51, 4, 0, DateTimeKind.Unspecified) });

            migrationBuilder.UpdateData(
                table: "TimeRegistrations",
                keyColumn: "TimeRegistrationId",
                keyValue: 803,
                columns: new[] { "EndTime", "StartTime" },
                values: new object[] { new DateTime(2024, 6, 22, 11, 14, 23, 0, DateTimeKind.Unspecified), new DateTime(2024, 5, 3, 11, 39, 54, 0, DateTimeKind.Unspecified) });

            migrationBuilder.UpdateData(
                table: "TimeRegistrations",
                keyColumn: "TimeRegistrationId",
                keyValue: 804,
                columns: new[] { "EndTime", "StartTime" },
                values: new object[] { new DateTime(2024, 5, 14, 18, 39, 11, 0, DateTimeKind.Unspecified), new DateTime(2024, 12, 21, 18, 39, 23, 0, DateTimeKind.Unspecified) });

            migrationBuilder.UpdateData(
                table: "TimeRegistrations",
                keyColumn: "TimeRegistrationId",
                keyValue: 805,
                columns: new[] { "EndTime", "StartTime" },
                values: new object[] { new DateTime(2024, 5, 24, 3, 53, 19, 0, DateTimeKind.Unspecified), new DateTime(2024, 7, 17, 11, 46, 50, 0, DateTimeKind.Unspecified) });

            migrationBuilder.UpdateData(
                table: "TimeRegistrations",
                keyColumn: "TimeRegistrationId",
                keyValue: 806,
                columns: new[] { "EndTime", "StartTime" },
                values: new object[] { new DateTime(2024, 4, 22, 15, 49, 18, 0, DateTimeKind.Unspecified), new DateTime(2024, 10, 16, 9, 21, 45, 0, DateTimeKind.Unspecified) });

            migrationBuilder.UpdateData(
                table: "TimeRegistrations",
                keyColumn: "TimeRegistrationId",
                keyValue: 807,
                columns: new[] { "EndTime", "StartTime" },
                values: new object[] { new DateTime(2024, 3, 31, 12, 52, 2, 0, DateTimeKind.Unspecified), new DateTime(2024, 4, 27, 0, 27, 11, 0, DateTimeKind.Unspecified) });

            migrationBuilder.UpdateData(
                table: "TimeRegistrations",
                keyColumn: "TimeRegistrationId",
                keyValue: 808,
                columns: new[] { "EndTime", "StartTime" },
                values: new object[] { new DateTime(2024, 3, 21, 12, 51, 35, 0, DateTimeKind.Unspecified), new DateTime(2024, 12, 12, 22, 22, 3, 0, DateTimeKind.Unspecified) });

            migrationBuilder.UpdateData(
                table: "TimeRegistrations",
                keyColumn: "TimeRegistrationId",
                keyValue: 809,
                columns: new[] { "EndTime", "StartTime" },
                values: new object[] { new DateTime(2024, 10, 11, 0, 7, 0, 0, DateTimeKind.Unspecified), new DateTime(2024, 2, 6, 4, 25, 32, 0, DateTimeKind.Unspecified) });

            migrationBuilder.UpdateData(
                table: "TimeRegistrations",
                keyColumn: "TimeRegistrationId",
                keyValue: 810,
                columns: new[] { "EndTime", "StartTime" },
                values: new object[] { new DateTime(2024, 6, 4, 19, 29, 31, 0, DateTimeKind.Unspecified), new DateTime(2024, 4, 10, 22, 36, 5, 0, DateTimeKind.Unspecified) });

            migrationBuilder.UpdateData(
                table: "TimeRegistrations",
                keyColumn: "TimeRegistrationId",
                keyValue: 811,
                columns: new[] { "EndTime", "StartTime" },
                values: new object[] { new DateTime(2024, 7, 1, 14, 5, 22, 0, DateTimeKind.Unspecified), new DateTime(2024, 9, 20, 16, 38, 27, 0, DateTimeKind.Unspecified) });

            migrationBuilder.UpdateData(
                table: "TimeRegistrations",
                keyColumn: "TimeRegistrationId",
                keyValue: 812,
                columns: new[] { "EndTime", "StartTime" },
                values: new object[] { new DateTime(2024, 4, 8, 14, 34, 46, 0, DateTimeKind.Unspecified), new DateTime(2024, 3, 7, 11, 54, 8, 0, DateTimeKind.Unspecified) });

            migrationBuilder.UpdateData(
                table: "TimeRegistrations",
                keyColumn: "TimeRegistrationId",
                keyValue: 813,
                columns: new[] { "EndTime", "StartTime" },
                values: new object[] { new DateTime(2024, 8, 1, 0, 29, 22, 0, DateTimeKind.Unspecified), new DateTime(2024, 12, 11, 15, 56, 30, 0, DateTimeKind.Unspecified) });

            migrationBuilder.UpdateData(
                table: "TimeRegistrations",
                keyColumn: "TimeRegistrationId",
                keyValue: 814,
                columns: new[] { "EndTime", "StartTime" },
                values: new object[] { new DateTime(2024, 11, 23, 23, 9, 47, 0, DateTimeKind.Unspecified), new DateTime(2024, 4, 25, 2, 32, 43, 0, DateTimeKind.Unspecified) });

            migrationBuilder.UpdateData(
                table: "TimeRegistrations",
                keyColumn: "TimeRegistrationId",
                keyValue: 815,
                columns: new[] { "EndTime", "StartTime" },
                values: new object[] { new DateTime(2024, 5, 19, 5, 32, 52, 0, DateTimeKind.Unspecified), new DateTime(2024, 7, 18, 18, 50, 9, 0, DateTimeKind.Unspecified) });

            migrationBuilder.UpdateData(
                table: "TimeRegistrations",
                keyColumn: "TimeRegistrationId",
                keyValue: 816,
                columns: new[] { "EndTime", "StartTime" },
                values: new object[] { new DateTime(2024, 1, 25, 10, 5, 38, 0, DateTimeKind.Unspecified), new DateTime(2024, 9, 26, 1, 29, 33, 0, DateTimeKind.Unspecified) });

            migrationBuilder.UpdateData(
                table: "TimeRegistrations",
                keyColumn: "TimeRegistrationId",
                keyValue: 817,
                columns: new[] { "EndTime", "StartTime" },
                values: new object[] { new DateTime(2024, 12, 11, 23, 58, 58, 0, DateTimeKind.Unspecified), new DateTime(2024, 5, 16, 15, 36, 4, 0, DateTimeKind.Unspecified) });

            migrationBuilder.UpdateData(
                table: "TimeRegistrations",
                keyColumn: "TimeRegistrationId",
                keyValue: 818,
                columns: new[] { "EndTime", "StartTime" },
                values: new object[] { new DateTime(2024, 4, 15, 20, 41, 35, 0, DateTimeKind.Unspecified), new DateTime(2024, 11, 10, 1, 3, 27, 0, DateTimeKind.Unspecified) });

            migrationBuilder.UpdateData(
                table: "TimeRegistrations",
                keyColumn: "TimeRegistrationId",
                keyValue: 819,
                columns: new[] { "EndTime", "StartTime" },
                values: new object[] { new DateTime(2024, 10, 12, 3, 32, 28, 0, DateTimeKind.Unspecified), new DateTime(2024, 10, 22, 3, 28, 30, 0, DateTimeKind.Unspecified) });

            migrationBuilder.UpdateData(
                table: "TimeRegistrations",
                keyColumn: "TimeRegistrationId",
                keyValue: 820,
                columns: new[] { "EndTime", "StartTime" },
                values: new object[] { new DateTime(2024, 3, 27, 15, 43, 28, 0, DateTimeKind.Unspecified), new DateTime(2024, 2, 17, 12, 56, 18, 0, DateTimeKind.Unspecified) });

            migrationBuilder.UpdateData(
                table: "TimeRegistrations",
                keyColumn: "TimeRegistrationId",
                keyValue: 821,
                columns: new[] { "EndTime", "StartTime" },
                values: new object[] { new DateTime(2024, 4, 17, 1, 4, 37, 0, DateTimeKind.Unspecified), new DateTime(2024, 9, 15, 15, 29, 26, 0, DateTimeKind.Unspecified) });

            migrationBuilder.UpdateData(
                table: "TimeRegistrations",
                keyColumn: "TimeRegistrationId",
                keyValue: 822,
                columns: new[] { "EndTime", "StartTime" },
                values: new object[] { new DateTime(2024, 9, 24, 3, 58, 11, 0, DateTimeKind.Unspecified), new DateTime(2024, 7, 17, 2, 9, 4, 0, DateTimeKind.Unspecified) });

            migrationBuilder.UpdateData(
                table: "TimeRegistrations",
                keyColumn: "TimeRegistrationId",
                keyValue: 823,
                columns: new[] { "EndTime", "StartTime" },
                values: new object[] { new DateTime(2024, 11, 29, 5, 26, 41, 0, DateTimeKind.Unspecified), new DateTime(2024, 5, 30, 5, 50, 51, 0, DateTimeKind.Unspecified) });

            migrationBuilder.UpdateData(
                table: "TimeRegistrations",
                keyColumn: "TimeRegistrationId",
                keyValue: 824,
                columns: new[] { "EndTime", "StartTime" },
                values: new object[] { new DateTime(2024, 6, 9, 21, 4, 1, 0, DateTimeKind.Unspecified), new DateTime(2024, 5, 20, 1, 32, 54, 0, DateTimeKind.Unspecified) });

            migrationBuilder.UpdateData(
                table: "TimeRegistrations",
                keyColumn: "TimeRegistrationId",
                keyValue: 825,
                columns: new[] { "EndTime", "StartTime" },
                values: new object[] { new DateTime(2024, 10, 14, 19, 49, 57, 0, DateTimeKind.Unspecified), new DateTime(2024, 11, 26, 20, 57, 6, 0, DateTimeKind.Unspecified) });

            migrationBuilder.UpdateData(
                table: "TimeRegistrations",
                keyColumn: "TimeRegistrationId",
                keyValue: 826,
                columns: new[] { "EndTime", "StartTime" },
                values: new object[] { new DateTime(2024, 12, 14, 8, 58, 27, 0, DateTimeKind.Unspecified), new DateTime(2024, 10, 28, 23, 7, 55, 0, DateTimeKind.Unspecified) });

            migrationBuilder.UpdateData(
                table: "TimeRegistrations",
                keyColumn: "TimeRegistrationId",
                keyValue: 827,
                columns: new[] { "EndTime", "StartTime" },
                values: new object[] { new DateTime(2024, 8, 2, 19, 22, 4, 0, DateTimeKind.Unspecified), new DateTime(2024, 7, 17, 3, 33, 21, 0, DateTimeKind.Unspecified) });

            migrationBuilder.UpdateData(
                table: "TimeRegistrations",
                keyColumn: "TimeRegistrationId",
                keyValue: 828,
                columns: new[] { "EndTime", "StartTime" },
                values: new object[] { new DateTime(2024, 12, 4, 21, 56, 9, 0, DateTimeKind.Unspecified), new DateTime(2024, 10, 20, 14, 26, 38, 0, DateTimeKind.Unspecified) });

            migrationBuilder.UpdateData(
                table: "TimeRegistrations",
                keyColumn: "TimeRegistrationId",
                keyValue: 829,
                columns: new[] { "EndTime", "StartTime" },
                values: new object[] { new DateTime(2024, 2, 14, 1, 53, 38, 0, DateTimeKind.Unspecified), new DateTime(2024, 5, 21, 18, 33, 17, 0, DateTimeKind.Unspecified) });

            migrationBuilder.UpdateData(
                table: "TimeRegistrations",
                keyColumn: "TimeRegistrationId",
                keyValue: 830,
                columns: new[] { "EndTime", "StartTime" },
                values: new object[] { new DateTime(2024, 7, 7, 0, 52, 50, 0, DateTimeKind.Unspecified), new DateTime(2024, 8, 24, 16, 15, 51, 0, DateTimeKind.Unspecified) });

            migrationBuilder.UpdateData(
                table: "TimeRegistrations",
                keyColumn: "TimeRegistrationId",
                keyValue: 831,
                columns: new[] { "EndTime", "StartTime" },
                values: new object[] { new DateTime(2024, 12, 29, 19, 57, 8, 0, DateTimeKind.Unspecified), new DateTime(2024, 3, 2, 8, 29, 38, 0, DateTimeKind.Unspecified) });

            migrationBuilder.UpdateData(
                table: "TimeRegistrations",
                keyColumn: "TimeRegistrationId",
                keyValue: 832,
                columns: new[] { "EndTime", "StartTime" },
                values: new object[] { new DateTime(2024, 9, 7, 16, 39, 30, 0, DateTimeKind.Unspecified), new DateTime(2024, 8, 29, 3, 2, 40, 0, DateTimeKind.Unspecified) });

            migrationBuilder.UpdateData(
                table: "TimeRegistrations",
                keyColumn: "TimeRegistrationId",
                keyValue: 833,
                columns: new[] { "EndTime", "StartTime" },
                values: new object[] { new DateTime(2024, 4, 5, 13, 30, 7, 0, DateTimeKind.Unspecified), new DateTime(2024, 12, 24, 8, 56, 58, 0, DateTimeKind.Unspecified) });

            migrationBuilder.UpdateData(
                table: "TimeRegistrations",
                keyColumn: "TimeRegistrationId",
                keyValue: 834,
                columns: new[] { "EndTime", "StartTime" },
                values: new object[] { new DateTime(2024, 1, 15, 15, 58, 7, 0, DateTimeKind.Unspecified), new DateTime(2024, 4, 27, 2, 15, 16, 0, DateTimeKind.Unspecified) });

            migrationBuilder.UpdateData(
                table: "TimeRegistrations",
                keyColumn: "TimeRegistrationId",
                keyValue: 835,
                columns: new[] { "EndTime", "StartTime" },
                values: new object[] { new DateTime(2024, 8, 27, 5, 59, 48, 0, DateTimeKind.Unspecified), new DateTime(2024, 12, 24, 0, 59, 55, 0, DateTimeKind.Unspecified) });

            migrationBuilder.UpdateData(
                table: "TimeRegistrations",
                keyColumn: "TimeRegistrationId",
                keyValue: 836,
                columns: new[] { "EndTime", "StartTime" },
                values: new object[] { new DateTime(2024, 12, 14, 3, 41, 56, 0, DateTimeKind.Unspecified), new DateTime(2024, 9, 20, 6, 8, 6, 0, DateTimeKind.Unspecified) });

            migrationBuilder.UpdateData(
                table: "TimeRegistrations",
                keyColumn: "TimeRegistrationId",
                keyValue: 837,
                columns: new[] { "EndTime", "StartTime" },
                values: new object[] { new DateTime(2024, 7, 16, 18, 0, 50, 0, DateTimeKind.Unspecified), new DateTime(2024, 6, 15, 8, 55, 22, 0, DateTimeKind.Unspecified) });

            migrationBuilder.UpdateData(
                table: "TimeRegistrations",
                keyColumn: "TimeRegistrationId",
                keyValue: 838,
                columns: new[] { "EndTime", "StartTime" },
                values: new object[] { new DateTime(2024, 7, 7, 0, 21, 17, 0, DateTimeKind.Unspecified), new DateTime(2024, 9, 10, 1, 45, 57, 0, DateTimeKind.Unspecified) });

            migrationBuilder.UpdateData(
                table: "TimeRegistrations",
                keyColumn: "TimeRegistrationId",
                keyValue: 839,
                columns: new[] { "EndTime", "StartTime" },
                values: new object[] { new DateTime(2024, 6, 7, 19, 45, 12, 0, DateTimeKind.Unspecified), new DateTime(2024, 4, 27, 3, 34, 48, 0, DateTimeKind.Unspecified) });

            migrationBuilder.UpdateData(
                table: "TimeRegistrations",
                keyColumn: "TimeRegistrationId",
                keyValue: 840,
                columns: new[] { "EndTime", "StartTime" },
                values: new object[] { new DateTime(2024, 2, 17, 18, 54, 32, 0, DateTimeKind.Unspecified), new DateTime(2024, 2, 21, 8, 13, 49, 0, DateTimeKind.Unspecified) });

            migrationBuilder.UpdateData(
                table: "TimeRegistrations",
                keyColumn: "TimeRegistrationId",
                keyValue: 841,
                columns: new[] { "EndTime", "StartTime" },
                values: new object[] { new DateTime(2024, 4, 16, 0, 40, 3, 0, DateTimeKind.Unspecified), new DateTime(2024, 2, 14, 19, 42, 28, 0, DateTimeKind.Unspecified) });

            migrationBuilder.UpdateData(
                table: "TimeRegistrations",
                keyColumn: "TimeRegistrationId",
                keyValue: 842,
                columns: new[] { "EndTime", "StartTime" },
                values: new object[] { new DateTime(2024, 2, 19, 7, 4, 4, 0, DateTimeKind.Unspecified), new DateTime(2024, 7, 22, 23, 21, 17, 0, DateTimeKind.Unspecified) });

            migrationBuilder.UpdateData(
                table: "TimeRegistrations",
                keyColumn: "TimeRegistrationId",
                keyValue: 843,
                columns: new[] { "EndTime", "StartTime" },
                values: new object[] { new DateTime(2024, 7, 17, 18, 42, 0, 0, DateTimeKind.Unspecified), new DateTime(2024, 9, 14, 11, 38, 13, 0, DateTimeKind.Unspecified) });

            migrationBuilder.UpdateData(
                table: "TimeRegistrations",
                keyColumn: "TimeRegistrationId",
                keyValue: 844,
                columns: new[] { "EndTime", "StartTime" },
                values: new object[] { new DateTime(2024, 4, 6, 17, 11, 12, 0, DateTimeKind.Unspecified), new DateTime(2024, 11, 22, 1, 0, 45, 0, DateTimeKind.Unspecified) });

            migrationBuilder.UpdateData(
                table: "TimeRegistrations",
                keyColumn: "TimeRegistrationId",
                keyValue: 845,
                columns: new[] { "EndTime", "StartTime" },
                values: new object[] { new DateTime(2024, 8, 24, 0, 16, 45, 0, DateTimeKind.Unspecified), new DateTime(2024, 12, 7, 23, 14, 3, 0, DateTimeKind.Unspecified) });

            migrationBuilder.UpdateData(
                table: "TimeRegistrations",
                keyColumn: "TimeRegistrationId",
                keyValue: 846,
                columns: new[] { "EndTime", "StartTime" },
                values: new object[] { new DateTime(2024, 9, 5, 0, 59, 41, 0, DateTimeKind.Unspecified), new DateTime(2024, 6, 1, 5, 39, 17, 0, DateTimeKind.Unspecified) });

            migrationBuilder.UpdateData(
                table: "TimeRegistrations",
                keyColumn: "TimeRegistrationId",
                keyValue: 847,
                columns: new[] { "EndTime", "StartTime" },
                values: new object[] { new DateTime(2024, 12, 9, 19, 57, 12, 0, DateTimeKind.Unspecified), new DateTime(2024, 11, 1, 5, 40, 22, 0, DateTimeKind.Unspecified) });

            migrationBuilder.UpdateData(
                table: "TimeRegistrations",
                keyColumn: "TimeRegistrationId",
                keyValue: 848,
                columns: new[] { "EndTime", "StartTime" },
                values: new object[] { new DateTime(2024, 6, 19, 14, 22, 25, 0, DateTimeKind.Unspecified), new DateTime(2024, 9, 26, 17, 0, 26, 0, DateTimeKind.Unspecified) });

            migrationBuilder.UpdateData(
                table: "TimeRegistrations",
                keyColumn: "TimeRegistrationId",
                keyValue: 849,
                columns: new[] { "EndTime", "StartTime" },
                values: new object[] { new DateTime(2024, 12, 11, 11, 53, 17, 0, DateTimeKind.Unspecified), new DateTime(2024, 2, 2, 4, 51, 39, 0, DateTimeKind.Unspecified) });

            migrationBuilder.UpdateData(
                table: "TimeRegistrations",
                keyColumn: "TimeRegistrationId",
                keyValue: 850,
                columns: new[] { "EndTime", "StartTime" },
                values: new object[] { new DateTime(2024, 10, 14, 3, 38, 22, 0, DateTimeKind.Unspecified), new DateTime(2024, 12, 12, 14, 44, 19, 0, DateTimeKind.Unspecified) });

            migrationBuilder.UpdateData(
                table: "TimeRegistrations",
                keyColumn: "TimeRegistrationId",
                keyValue: 851,
                columns: new[] { "EndTime", "StartTime" },
                values: new object[] { new DateTime(2024, 4, 28, 6, 26, 40, 0, DateTimeKind.Unspecified), new DateTime(2024, 6, 21, 14, 23, 0, 0, DateTimeKind.Unspecified) });

            migrationBuilder.UpdateData(
                table: "TimeRegistrations",
                keyColumn: "TimeRegistrationId",
                keyValue: 852,
                columns: new[] { "EndTime", "StartTime" },
                values: new object[] { new DateTime(2024, 1, 11, 17, 42, 28, 0, DateTimeKind.Unspecified), new DateTime(2024, 10, 24, 7, 41, 55, 0, DateTimeKind.Unspecified) });

            migrationBuilder.UpdateData(
                table: "TimeRegistrations",
                keyColumn: "TimeRegistrationId",
                keyValue: 853,
                columns: new[] { "EndTime", "StartTime" },
                values: new object[] { new DateTime(2024, 12, 16, 11, 28, 59, 0, DateTimeKind.Unspecified), new DateTime(2024, 5, 6, 23, 50, 10, 0, DateTimeKind.Unspecified) });

            migrationBuilder.UpdateData(
                table: "TimeRegistrations",
                keyColumn: "TimeRegistrationId",
                keyValue: 854,
                columns: new[] { "EndTime", "StartTime" },
                values: new object[] { new DateTime(2024, 5, 18, 9, 28, 55, 0, DateTimeKind.Unspecified), new DateTime(2024, 7, 16, 4, 16, 1, 0, DateTimeKind.Unspecified) });

            migrationBuilder.UpdateData(
                table: "TimeRegistrations",
                keyColumn: "TimeRegistrationId",
                keyValue: 855,
                columns: new[] { "EndTime", "StartTime" },
                values: new object[] { new DateTime(2024, 1, 18, 1, 5, 10, 0, DateTimeKind.Unspecified), new DateTime(2024, 6, 24, 0, 3, 36, 0, DateTimeKind.Unspecified) });

            migrationBuilder.UpdateData(
                table: "TimeRegistrations",
                keyColumn: "TimeRegistrationId",
                keyValue: 856,
                columns: new[] { "EndTime", "StartTime" },
                values: new object[] { new DateTime(2024, 4, 19, 20, 50, 14, 0, DateTimeKind.Unspecified), new DateTime(2024, 10, 25, 4, 52, 29, 0, DateTimeKind.Unspecified) });

            migrationBuilder.UpdateData(
                table: "TimeRegistrations",
                keyColumn: "TimeRegistrationId",
                keyValue: 857,
                columns: new[] { "EndTime", "StartTime" },
                values: new object[] { new DateTime(2024, 1, 21, 20, 20, 20, 0, DateTimeKind.Unspecified), new DateTime(2024, 5, 18, 20, 0, 54, 0, DateTimeKind.Unspecified) });

            migrationBuilder.UpdateData(
                table: "TimeRegistrations",
                keyColumn: "TimeRegistrationId",
                keyValue: 858,
                columns: new[] { "EndTime", "StartTime" },
                values: new object[] { new DateTime(2024, 5, 26, 6, 16, 22, 0, DateTimeKind.Unspecified), new DateTime(2024, 2, 29, 8, 12, 31, 0, DateTimeKind.Unspecified) });

            migrationBuilder.UpdateData(
                table: "TimeRegistrations",
                keyColumn: "TimeRegistrationId",
                keyValue: 859,
                columns: new[] { "EndTime", "StartTime" },
                values: new object[] { new DateTime(2024, 11, 15, 15, 3, 48, 0, DateTimeKind.Unspecified), new DateTime(2024, 4, 26, 14, 43, 12, 0, DateTimeKind.Unspecified) });

            migrationBuilder.UpdateData(
                table: "TimeRegistrations",
                keyColumn: "TimeRegistrationId",
                keyValue: 860,
                columns: new[] { "EndTime", "StartTime" },
                values: new object[] { new DateTime(2024, 9, 2, 22, 31, 33, 0, DateTimeKind.Unspecified), new DateTime(2024, 1, 20, 19, 13, 4, 0, DateTimeKind.Unspecified) });

            migrationBuilder.UpdateData(
                table: "TimeRegistrations",
                keyColumn: "TimeRegistrationId",
                keyValue: 861,
                columns: new[] { "EndTime", "StartTime" },
                values: new object[] { new DateTime(2024, 1, 8, 19, 32, 24, 0, DateTimeKind.Unspecified), new DateTime(2024, 1, 14, 4, 52, 29, 0, DateTimeKind.Unspecified) });

            migrationBuilder.UpdateData(
                table: "TimeRegistrations",
                keyColumn: "TimeRegistrationId",
                keyValue: 862,
                columns: new[] { "EndTime", "StartTime" },
                values: new object[] { new DateTime(2024, 5, 31, 11, 19, 32, 0, DateTimeKind.Unspecified), new DateTime(2024, 9, 24, 16, 21, 2, 0, DateTimeKind.Unspecified) });

            migrationBuilder.UpdateData(
                table: "TimeRegistrations",
                keyColumn: "TimeRegistrationId",
                keyValue: 863,
                columns: new[] { "EndTime", "StartTime" },
                values: new object[] { new DateTime(2024, 11, 23, 7, 57, 45, 0, DateTimeKind.Unspecified), new DateTime(2024, 7, 5, 17, 27, 6, 0, DateTimeKind.Unspecified) });

            migrationBuilder.UpdateData(
                table: "TimeRegistrations",
                keyColumn: "TimeRegistrationId",
                keyValue: 864,
                columns: new[] { "EndTime", "StartTime" },
                values: new object[] { new DateTime(2024, 6, 21, 21, 31, 10, 0, DateTimeKind.Unspecified), new DateTime(2024, 2, 26, 1, 52, 11, 0, DateTimeKind.Unspecified) });

            migrationBuilder.UpdateData(
                table: "TimeRegistrations",
                keyColumn: "TimeRegistrationId",
                keyValue: 865,
                columns: new[] { "EndTime", "StartTime" },
                values: new object[] { new DateTime(2024, 1, 3, 13, 21, 23, 0, DateTimeKind.Unspecified), new DateTime(2024, 9, 28, 19, 28, 30, 0, DateTimeKind.Unspecified) });

            migrationBuilder.UpdateData(
                table: "TimeRegistrations",
                keyColumn: "TimeRegistrationId",
                keyValue: 866,
                columns: new[] { "EndTime", "StartTime" },
                values: new object[] { new DateTime(2024, 8, 29, 4, 6, 40, 0, DateTimeKind.Unspecified), new DateTime(2024, 12, 14, 20, 15, 4, 0, DateTimeKind.Unspecified) });

            migrationBuilder.UpdateData(
                table: "TimeRegistrations",
                keyColumn: "TimeRegistrationId",
                keyValue: 867,
                columns: new[] { "EndTime", "StartTime" },
                values: new object[] { new DateTime(2024, 3, 10, 22, 38, 4, 0, DateTimeKind.Unspecified), new DateTime(2024, 6, 17, 17, 19, 31, 0, DateTimeKind.Unspecified) });

            migrationBuilder.UpdateData(
                table: "TimeRegistrations",
                keyColumn: "TimeRegistrationId",
                keyValue: 868,
                columns: new[] { "EndTime", "StartTime" },
                values: new object[] { new DateTime(2024, 3, 7, 6, 18, 28, 0, DateTimeKind.Unspecified), new DateTime(2024, 1, 10, 22, 10, 9, 0, DateTimeKind.Unspecified) });

            migrationBuilder.UpdateData(
                table: "TimeRegistrations",
                keyColumn: "TimeRegistrationId",
                keyValue: 869,
                columns: new[] { "EndTime", "StartTime" },
                values: new object[] { new DateTime(2024, 11, 26, 8, 43, 25, 0, DateTimeKind.Unspecified), new DateTime(2024, 10, 15, 20, 16, 40, 0, DateTimeKind.Unspecified) });

            migrationBuilder.UpdateData(
                table: "TimeRegistrations",
                keyColumn: "TimeRegistrationId",
                keyValue: 870,
                columns: new[] { "EndTime", "StartTime" },
                values: new object[] { new DateTime(2024, 3, 4, 10, 35, 11, 0, DateTimeKind.Unspecified), new DateTime(2024, 3, 16, 16, 29, 58, 0, DateTimeKind.Unspecified) });

            migrationBuilder.UpdateData(
                table: "TimeRegistrations",
                keyColumn: "TimeRegistrationId",
                keyValue: 871,
                columns: new[] { "EndTime", "StartTime" },
                values: new object[] { new DateTime(2024, 5, 1, 5, 55, 39, 0, DateTimeKind.Unspecified), new DateTime(2024, 5, 29, 1, 36, 30, 0, DateTimeKind.Unspecified) });

            migrationBuilder.UpdateData(
                table: "TimeRegistrations",
                keyColumn: "TimeRegistrationId",
                keyValue: 872,
                columns: new[] { "EndTime", "StartTime" },
                values: new object[] { new DateTime(2024, 12, 20, 15, 20, 53, 0, DateTimeKind.Unspecified), new DateTime(2024, 2, 5, 1, 2, 48, 0, DateTimeKind.Unspecified) });

            migrationBuilder.UpdateData(
                table: "TimeRegistrations",
                keyColumn: "TimeRegistrationId",
                keyValue: 873,
                columns: new[] { "EndTime", "StartTime" },
                values: new object[] { new DateTime(2024, 4, 9, 12, 38, 28, 0, DateTimeKind.Unspecified), new DateTime(2024, 10, 6, 20, 39, 30, 0, DateTimeKind.Unspecified) });

            migrationBuilder.UpdateData(
                table: "TimeRegistrations",
                keyColumn: "TimeRegistrationId",
                keyValue: 874,
                columns: new[] { "EndTime", "StartTime" },
                values: new object[] { new DateTime(2024, 10, 4, 7, 18, 15, 0, DateTimeKind.Unspecified), new DateTime(2024, 6, 19, 18, 40, 31, 0, DateTimeKind.Unspecified) });

            migrationBuilder.UpdateData(
                table: "TimeRegistrations",
                keyColumn: "TimeRegistrationId",
                keyValue: 875,
                columns: new[] { "EndTime", "StartTime" },
                values: new object[] { new DateTime(2024, 11, 27, 21, 41, 6, 0, DateTimeKind.Unspecified), new DateTime(2024, 6, 18, 16, 23, 28, 0, DateTimeKind.Unspecified) });

            migrationBuilder.UpdateData(
                table: "TimeRegistrations",
                keyColumn: "TimeRegistrationId",
                keyValue: 876,
                columns: new[] { "EndTime", "StartTime" },
                values: new object[] { new DateTime(2024, 7, 19, 4, 44, 39, 0, DateTimeKind.Unspecified), new DateTime(2024, 4, 8, 7, 44, 45, 0, DateTimeKind.Unspecified) });

            migrationBuilder.UpdateData(
                table: "TimeRegistrations",
                keyColumn: "TimeRegistrationId",
                keyValue: 877,
                columns: new[] { "EndTime", "StartTime" },
                values: new object[] { new DateTime(2024, 5, 3, 7, 19, 12, 0, DateTimeKind.Unspecified), new DateTime(2024, 7, 19, 6, 28, 32, 0, DateTimeKind.Unspecified) });

            migrationBuilder.UpdateData(
                table: "TimeRegistrations",
                keyColumn: "TimeRegistrationId",
                keyValue: 878,
                columns: new[] { "EndTime", "StartTime" },
                values: new object[] { new DateTime(2024, 12, 30, 7, 25, 55, 0, DateTimeKind.Unspecified), new DateTime(2024, 8, 30, 9, 58, 40, 0, DateTimeKind.Unspecified) });

            migrationBuilder.UpdateData(
                table: "TimeRegistrations",
                keyColumn: "TimeRegistrationId",
                keyValue: 879,
                columns: new[] { "EndTime", "StartTime" },
                values: new object[] { new DateTime(2024, 1, 8, 9, 47, 10, 0, DateTimeKind.Unspecified), new DateTime(2024, 6, 19, 12, 5, 1, 0, DateTimeKind.Unspecified) });

            migrationBuilder.UpdateData(
                table: "TimeRegistrations",
                keyColumn: "TimeRegistrationId",
                keyValue: 880,
                columns: new[] { "EndTime", "StartTime" },
                values: new object[] { new DateTime(2024, 10, 19, 22, 25, 14, 0, DateTimeKind.Unspecified), new DateTime(2024, 1, 26, 1, 13, 12, 0, DateTimeKind.Unspecified) });

            migrationBuilder.UpdateData(
                table: "TimeRegistrations",
                keyColumn: "TimeRegistrationId",
                keyValue: 881,
                columns: new[] { "EndTime", "StartTime" },
                values: new object[] { new DateTime(2024, 11, 25, 21, 4, 25, 0, DateTimeKind.Unspecified), new DateTime(2024, 10, 8, 22, 4, 38, 0, DateTimeKind.Unspecified) });

            migrationBuilder.UpdateData(
                table: "TimeRegistrations",
                keyColumn: "TimeRegistrationId",
                keyValue: 882,
                columns: new[] { "EndTime", "StartTime" },
                values: new object[] { new DateTime(2024, 6, 10, 9, 18, 58, 0, DateTimeKind.Unspecified), new DateTime(2024, 2, 27, 3, 17, 53, 0, DateTimeKind.Unspecified) });

            migrationBuilder.UpdateData(
                table: "TimeRegistrations",
                keyColumn: "TimeRegistrationId",
                keyValue: 883,
                columns: new[] { "EndTime", "StartTime" },
                values: new object[] { new DateTime(2024, 8, 28, 20, 13, 20, 0, DateTimeKind.Unspecified), new DateTime(2024, 9, 16, 17, 45, 28, 0, DateTimeKind.Unspecified) });

            migrationBuilder.UpdateData(
                table: "TimeRegistrations",
                keyColumn: "TimeRegistrationId",
                keyValue: 884,
                columns: new[] { "EndTime", "StartTime" },
                values: new object[] { new DateTime(2024, 10, 14, 7, 28, 11, 0, DateTimeKind.Unspecified), new DateTime(2024, 4, 1, 1, 9, 31, 0, DateTimeKind.Unspecified) });

            migrationBuilder.UpdateData(
                table: "TimeRegistrations",
                keyColumn: "TimeRegistrationId",
                keyValue: 885,
                columns: new[] { "EndTime", "StartTime" },
                values: new object[] { new DateTime(2024, 10, 27, 1, 28, 51, 0, DateTimeKind.Unspecified), new DateTime(2024, 11, 13, 20, 2, 11, 0, DateTimeKind.Unspecified) });

            migrationBuilder.UpdateData(
                table: "TimeRegistrations",
                keyColumn: "TimeRegistrationId",
                keyValue: 886,
                columns: new[] { "EndTime", "StartTime" },
                values: new object[] { new DateTime(2024, 11, 4, 5, 59, 57, 0, DateTimeKind.Unspecified), new DateTime(2024, 7, 6, 15, 39, 13, 0, DateTimeKind.Unspecified) });

            migrationBuilder.UpdateData(
                table: "TimeRegistrations",
                keyColumn: "TimeRegistrationId",
                keyValue: 887,
                columns: new[] { "EndTime", "StartTime" },
                values: new object[] { new DateTime(2024, 11, 25, 4, 56, 4, 0, DateTimeKind.Unspecified), new DateTime(2024, 2, 5, 16, 19, 32, 0, DateTimeKind.Unspecified) });

            migrationBuilder.UpdateData(
                table: "TimeRegistrations",
                keyColumn: "TimeRegistrationId",
                keyValue: 888,
                columns: new[] { "EndTime", "StartTime" },
                values: new object[] { new DateTime(2024, 5, 25, 10, 24, 17, 0, DateTimeKind.Unspecified), new DateTime(2024, 10, 12, 11, 34, 31, 0, DateTimeKind.Unspecified) });

            migrationBuilder.UpdateData(
                table: "TimeRegistrations",
                keyColumn: "TimeRegistrationId",
                keyValue: 889,
                columns: new[] { "EndTime", "StartTime" },
                values: new object[] { new DateTime(2024, 11, 22, 21, 39, 39, 0, DateTimeKind.Unspecified), new DateTime(2024, 4, 8, 15, 26, 53, 0, DateTimeKind.Unspecified) });

            migrationBuilder.UpdateData(
                table: "TimeRegistrations",
                keyColumn: "TimeRegistrationId",
                keyValue: 890,
                columns: new[] { "EndTime", "StartTime" },
                values: new object[] { new DateTime(2024, 9, 13, 23, 9, 31, 0, DateTimeKind.Unspecified), new DateTime(2024, 4, 26, 9, 58, 27, 0, DateTimeKind.Unspecified) });

            migrationBuilder.UpdateData(
                table: "TimeRegistrations",
                keyColumn: "TimeRegistrationId",
                keyValue: 891,
                columns: new[] { "EndTime", "StartTime" },
                values: new object[] { new DateTime(2024, 12, 23, 17, 48, 0, 0, DateTimeKind.Unspecified), new DateTime(2024, 2, 1, 20, 7, 46, 0, DateTimeKind.Unspecified) });

            migrationBuilder.UpdateData(
                table: "TimeRegistrations",
                keyColumn: "TimeRegistrationId",
                keyValue: 892,
                columns: new[] { "EndTime", "StartTime" },
                values: new object[] { new DateTime(2024, 2, 3, 8, 6, 22, 0, DateTimeKind.Unspecified), new DateTime(2024, 12, 18, 10, 43, 24, 0, DateTimeKind.Unspecified) });

            migrationBuilder.UpdateData(
                table: "TimeRegistrations",
                keyColumn: "TimeRegistrationId",
                keyValue: 893,
                columns: new[] { "EndTime", "StartTime" },
                values: new object[] { new DateTime(2024, 3, 28, 22, 3, 10, 0, DateTimeKind.Unspecified), new DateTime(2024, 11, 25, 17, 0, 11, 0, DateTimeKind.Unspecified) });

            migrationBuilder.UpdateData(
                table: "TimeRegistrations",
                keyColumn: "TimeRegistrationId",
                keyValue: 894,
                columns: new[] { "EndTime", "StartTime" },
                values: new object[] { new DateTime(2024, 5, 31, 0, 23, 37, 0, DateTimeKind.Unspecified), new DateTime(2024, 4, 4, 2, 1, 24, 0, DateTimeKind.Unspecified) });

            migrationBuilder.UpdateData(
                table: "TimeRegistrations",
                keyColumn: "TimeRegistrationId",
                keyValue: 895,
                columns: new[] { "EndTime", "StartTime" },
                values: new object[] { new DateTime(2024, 8, 25, 1, 51, 50, 0, DateTimeKind.Unspecified), new DateTime(2024, 8, 17, 19, 15, 11, 0, DateTimeKind.Unspecified) });

            migrationBuilder.UpdateData(
                table: "TimeRegistrations",
                keyColumn: "TimeRegistrationId",
                keyValue: 896,
                columns: new[] { "EndTime", "StartTime" },
                values: new object[] { new DateTime(2024, 10, 17, 14, 43, 39, 0, DateTimeKind.Unspecified), new DateTime(2024, 10, 6, 23, 34, 32, 0, DateTimeKind.Unspecified) });

            migrationBuilder.UpdateData(
                table: "TimeRegistrations",
                keyColumn: "TimeRegistrationId",
                keyValue: 897,
                columns: new[] { "EndTime", "StartTime" },
                values: new object[] { new DateTime(2024, 12, 4, 15, 9, 53, 0, DateTimeKind.Unspecified), new DateTime(2024, 12, 7, 8, 58, 2, 0, DateTimeKind.Unspecified) });

            migrationBuilder.UpdateData(
                table: "TimeRegistrations",
                keyColumn: "TimeRegistrationId",
                keyValue: 898,
                columns: new[] { "EndTime", "StartTime" },
                values: new object[] { new DateTime(2024, 11, 16, 4, 39, 18, 0, DateTimeKind.Unspecified), new DateTime(2024, 6, 6, 8, 1, 8, 0, DateTimeKind.Unspecified) });

            migrationBuilder.UpdateData(
                table: "TimeRegistrations",
                keyColumn: "TimeRegistrationId",
                keyValue: 899,
                columns: new[] { "EndTime", "StartTime" },
                values: new object[] { new DateTime(2024, 6, 10, 8, 37, 25, 0, DateTimeKind.Unspecified), new DateTime(2024, 7, 10, 4, 48, 1, 0, DateTimeKind.Unspecified) });

            migrationBuilder.UpdateData(
                table: "TimeRegistrations",
                keyColumn: "TimeRegistrationId",
                keyValue: 900,
                columns: new[] { "EndTime", "StartTime" },
                values: new object[] { new DateTime(2024, 5, 29, 8, 35, 59, 0, DateTimeKind.Unspecified), new DateTime(2024, 1, 8, 13, 57, 48, 0, DateTimeKind.Unspecified) });

            migrationBuilder.UpdateData(
                table: "TimeRegistrations",
                keyColumn: "TimeRegistrationId",
                keyValue: 901,
                columns: new[] { "EndTime", "StartTime" },
                values: new object[] { new DateTime(2024, 9, 19, 17, 46, 56, 0, DateTimeKind.Unspecified), new DateTime(2024, 3, 31, 22, 51, 39, 0, DateTimeKind.Unspecified) });

            migrationBuilder.UpdateData(
                table: "TimeRegistrations",
                keyColumn: "TimeRegistrationId",
                keyValue: 902,
                columns: new[] { "EndTime", "StartTime" },
                values: new object[] { new DateTime(2024, 9, 24, 21, 1, 2, 0, DateTimeKind.Unspecified), new DateTime(2024, 11, 11, 8, 55, 46, 0, DateTimeKind.Unspecified) });

            migrationBuilder.UpdateData(
                table: "TimeRegistrations",
                keyColumn: "TimeRegistrationId",
                keyValue: 903,
                columns: new[] { "EndTime", "StartTime" },
                values: new object[] { new DateTime(2024, 7, 10, 14, 51, 5, 0, DateTimeKind.Unspecified), new DateTime(2024, 4, 20, 8, 38, 28, 0, DateTimeKind.Unspecified) });

            migrationBuilder.UpdateData(
                table: "TimeRegistrations",
                keyColumn: "TimeRegistrationId",
                keyValue: 904,
                columns: new[] { "EndTime", "StartTime" },
                values: new object[] { new DateTime(2024, 5, 3, 0, 23, 21, 0, DateTimeKind.Unspecified), new DateTime(2024, 4, 16, 12, 32, 44, 0, DateTimeKind.Unspecified) });

            migrationBuilder.UpdateData(
                table: "TimeRegistrations",
                keyColumn: "TimeRegistrationId",
                keyValue: 905,
                columns: new[] { "EndTime", "StartTime" },
                values: new object[] { new DateTime(2024, 8, 15, 19, 31, 38, 0, DateTimeKind.Unspecified), new DateTime(2024, 6, 14, 23, 56, 4, 0, DateTimeKind.Unspecified) });

            migrationBuilder.UpdateData(
                table: "TimeRegistrations",
                keyColumn: "TimeRegistrationId",
                keyValue: 906,
                columns: new[] { "EndTime", "StartTime" },
                values: new object[] { new DateTime(2024, 2, 20, 5, 17, 50, 0, DateTimeKind.Unspecified), new DateTime(2024, 1, 21, 2, 13, 35, 0, DateTimeKind.Unspecified) });

            migrationBuilder.UpdateData(
                table: "TimeRegistrations",
                keyColumn: "TimeRegistrationId",
                keyValue: 907,
                columns: new[] { "EndTime", "StartTime" },
                values: new object[] { new DateTime(2024, 12, 21, 14, 54, 57, 0, DateTimeKind.Unspecified), new DateTime(2024, 7, 14, 19, 23, 7, 0, DateTimeKind.Unspecified) });

            migrationBuilder.UpdateData(
                table: "TimeRegistrations",
                keyColumn: "TimeRegistrationId",
                keyValue: 908,
                columns: new[] { "EndTime", "StartTime" },
                values: new object[] { new DateTime(2024, 7, 31, 15, 49, 51, 0, DateTimeKind.Unspecified), new DateTime(2024, 8, 27, 5, 44, 36, 0, DateTimeKind.Unspecified) });

            migrationBuilder.UpdateData(
                table: "TimeRegistrations",
                keyColumn: "TimeRegistrationId",
                keyValue: 909,
                columns: new[] { "EndTime", "StartTime" },
                values: new object[] { new DateTime(2024, 11, 1, 19, 2, 3, 0, DateTimeKind.Unspecified), new DateTime(2024, 8, 7, 16, 38, 16, 0, DateTimeKind.Unspecified) });

            migrationBuilder.UpdateData(
                table: "TimeRegistrations",
                keyColumn: "TimeRegistrationId",
                keyValue: 910,
                columns: new[] { "EndTime", "StartTime" },
                values: new object[] { new DateTime(2024, 1, 28, 21, 44, 16, 0, DateTimeKind.Unspecified), new DateTime(2024, 11, 15, 20, 28, 18, 0, DateTimeKind.Unspecified) });

            migrationBuilder.UpdateData(
                table: "TimeRegistrations",
                keyColumn: "TimeRegistrationId",
                keyValue: 911,
                columns: new[] { "EndTime", "StartTime" },
                values: new object[] { new DateTime(2024, 6, 11, 10, 55, 58, 0, DateTimeKind.Unspecified), new DateTime(2024, 7, 29, 20, 32, 35, 0, DateTimeKind.Unspecified) });

            migrationBuilder.UpdateData(
                table: "TimeRegistrations",
                keyColumn: "TimeRegistrationId",
                keyValue: 912,
                columns: new[] { "EndTime", "StartTime" },
                values: new object[] { new DateTime(2024, 8, 1, 3, 26, 29, 0, DateTimeKind.Unspecified), new DateTime(2024, 1, 9, 15, 0, 47, 0, DateTimeKind.Unspecified) });

            migrationBuilder.UpdateData(
                table: "TimeRegistrations",
                keyColumn: "TimeRegistrationId",
                keyValue: 913,
                columns: new[] { "EndTime", "StartTime" },
                values: new object[] { new DateTime(2024, 12, 15, 20, 8, 40, 0, DateTimeKind.Unspecified), new DateTime(2024, 2, 29, 8, 12, 15, 0, DateTimeKind.Unspecified) });

            migrationBuilder.UpdateData(
                table: "TimeRegistrations",
                keyColumn: "TimeRegistrationId",
                keyValue: 914,
                columns: new[] { "EndTime", "StartTime" },
                values: new object[] { new DateTime(2024, 5, 24, 19, 15, 15, 0, DateTimeKind.Unspecified), new DateTime(2024, 12, 7, 12, 4, 48, 0, DateTimeKind.Unspecified) });

            migrationBuilder.UpdateData(
                table: "TimeRegistrations",
                keyColumn: "TimeRegistrationId",
                keyValue: 915,
                columns: new[] { "EndTime", "StartTime" },
                values: new object[] { new DateTime(2024, 4, 26, 5, 57, 26, 0, DateTimeKind.Unspecified), new DateTime(2024, 12, 21, 22, 37, 16, 0, DateTimeKind.Unspecified) });

            migrationBuilder.UpdateData(
                table: "TimeRegistrations",
                keyColumn: "TimeRegistrationId",
                keyValue: 916,
                columns: new[] { "EndTime", "StartTime" },
                values: new object[] { new DateTime(2024, 9, 2, 1, 24, 36, 0, DateTimeKind.Unspecified), new DateTime(2024, 6, 27, 1, 36, 59, 0, DateTimeKind.Unspecified) });

            migrationBuilder.UpdateData(
                table: "TimeRegistrations",
                keyColumn: "TimeRegistrationId",
                keyValue: 917,
                columns: new[] { "EndTime", "StartTime" },
                values: new object[] { new DateTime(2024, 1, 26, 14, 21, 33, 0, DateTimeKind.Unspecified), new DateTime(2024, 4, 14, 7, 26, 18, 0, DateTimeKind.Unspecified) });

            migrationBuilder.UpdateData(
                table: "TimeRegistrations",
                keyColumn: "TimeRegistrationId",
                keyValue: 918,
                columns: new[] { "EndTime", "StartTime" },
                values: new object[] { new DateTime(2024, 3, 17, 1, 54, 47, 0, DateTimeKind.Unspecified), new DateTime(2024, 9, 21, 23, 47, 54, 0, DateTimeKind.Unspecified) });

            migrationBuilder.UpdateData(
                table: "TimeRegistrations",
                keyColumn: "TimeRegistrationId",
                keyValue: 919,
                columns: new[] { "EndTime", "StartTime" },
                values: new object[] { new DateTime(2024, 6, 20, 1, 6, 38, 0, DateTimeKind.Unspecified), new DateTime(2024, 1, 10, 5, 12, 12, 0, DateTimeKind.Unspecified) });

            migrationBuilder.UpdateData(
                table: "TimeRegistrations",
                keyColumn: "TimeRegistrationId",
                keyValue: 920,
                columns: new[] { "EndTime", "StartTime" },
                values: new object[] { new DateTime(2024, 12, 25, 20, 27, 4, 0, DateTimeKind.Unspecified), new DateTime(2024, 9, 25, 16, 12, 38, 0, DateTimeKind.Unspecified) });

            migrationBuilder.UpdateData(
                table: "TimeRegistrations",
                keyColumn: "TimeRegistrationId",
                keyValue: 921,
                columns: new[] { "EndTime", "StartTime" },
                values: new object[] { new DateTime(2024, 8, 2, 14, 3, 55, 0, DateTimeKind.Unspecified), new DateTime(2024, 7, 17, 23, 12, 24, 0, DateTimeKind.Unspecified) });

            migrationBuilder.UpdateData(
                table: "TimeRegistrations",
                keyColumn: "TimeRegistrationId",
                keyValue: 922,
                columns: new[] { "EndTime", "StartTime" },
                values: new object[] { new DateTime(2024, 6, 18, 3, 44, 54, 0, DateTimeKind.Unspecified), new DateTime(2024, 11, 20, 21, 47, 10, 0, DateTimeKind.Unspecified) });

            migrationBuilder.UpdateData(
                table: "TimeRegistrations",
                keyColumn: "TimeRegistrationId",
                keyValue: 923,
                columns: new[] { "EndTime", "StartTime" },
                values: new object[] { new DateTime(2024, 4, 20, 14, 48, 52, 0, DateTimeKind.Unspecified), new DateTime(2024, 1, 4, 3, 28, 18, 0, DateTimeKind.Unspecified) });

            migrationBuilder.UpdateData(
                table: "TimeRegistrations",
                keyColumn: "TimeRegistrationId",
                keyValue: 924,
                columns: new[] { "EndTime", "StartTime" },
                values: new object[] { new DateTime(2024, 10, 31, 6, 46, 1, 0, DateTimeKind.Unspecified), new DateTime(2024, 9, 23, 7, 46, 52, 0, DateTimeKind.Unspecified) });

            migrationBuilder.UpdateData(
                table: "TimeRegistrations",
                keyColumn: "TimeRegistrationId",
                keyValue: 925,
                columns: new[] { "EndTime", "StartTime" },
                values: new object[] { new DateTime(2024, 3, 18, 12, 40, 37, 0, DateTimeKind.Unspecified), new DateTime(2024, 3, 13, 1, 34, 23, 0, DateTimeKind.Unspecified) });

            migrationBuilder.UpdateData(
                table: "TimeRegistrations",
                keyColumn: "TimeRegistrationId",
                keyValue: 926,
                columns: new[] { "EndTime", "StartTime" },
                values: new object[] { new DateTime(2024, 1, 20, 23, 10, 58, 0, DateTimeKind.Unspecified), new DateTime(2024, 6, 28, 14, 32, 33, 0, DateTimeKind.Unspecified) });

            migrationBuilder.UpdateData(
                table: "TimeRegistrations",
                keyColumn: "TimeRegistrationId",
                keyValue: 927,
                columns: new[] { "EndTime", "StartTime" },
                values: new object[] { new DateTime(2024, 7, 26, 15, 52, 12, 0, DateTimeKind.Unspecified), new DateTime(2024, 4, 7, 3, 44, 10, 0, DateTimeKind.Unspecified) });

            migrationBuilder.UpdateData(
                table: "TimeRegistrations",
                keyColumn: "TimeRegistrationId",
                keyValue: 928,
                columns: new[] { "EndTime", "StartTime" },
                values: new object[] { new DateTime(2024, 6, 1, 16, 6, 22, 0, DateTimeKind.Unspecified), new DateTime(2024, 7, 28, 14, 27, 1, 0, DateTimeKind.Unspecified) });

            migrationBuilder.UpdateData(
                table: "TimeRegistrations",
                keyColumn: "TimeRegistrationId",
                keyValue: 929,
                columns: new[] { "EndTime", "StartTime" },
                values: new object[] { new DateTime(2024, 6, 27, 8, 2, 32, 0, DateTimeKind.Unspecified), new DateTime(2024, 3, 27, 2, 14, 11, 0, DateTimeKind.Unspecified) });

            migrationBuilder.UpdateData(
                table: "TimeRegistrations",
                keyColumn: "TimeRegistrationId",
                keyValue: 930,
                columns: new[] { "EndTime", "StartTime" },
                values: new object[] { new DateTime(2024, 10, 6, 8, 55, 46, 0, DateTimeKind.Unspecified), new DateTime(2024, 8, 14, 10, 56, 17, 0, DateTimeKind.Unspecified) });

            migrationBuilder.UpdateData(
                table: "TimeRegistrations",
                keyColumn: "TimeRegistrationId",
                keyValue: 931,
                columns: new[] { "EndTime", "StartTime" },
                values: new object[] { new DateTime(2024, 3, 14, 13, 15, 46, 0, DateTimeKind.Unspecified), new DateTime(2024, 9, 4, 6, 17, 53, 0, DateTimeKind.Unspecified) });

            migrationBuilder.UpdateData(
                table: "TimeRegistrations",
                keyColumn: "TimeRegistrationId",
                keyValue: 932,
                columns: new[] { "EndTime", "StartTime" },
                values: new object[] { new DateTime(2024, 3, 10, 18, 33, 32, 0, DateTimeKind.Unspecified), new DateTime(2024, 8, 29, 10, 46, 22, 0, DateTimeKind.Unspecified) });

            migrationBuilder.UpdateData(
                table: "TimeRegistrations",
                keyColumn: "TimeRegistrationId",
                keyValue: 933,
                columns: new[] { "EndTime", "StartTime" },
                values: new object[] { new DateTime(2024, 6, 1, 3, 15, 8, 0, DateTimeKind.Unspecified), new DateTime(2024, 4, 3, 20, 27, 38, 0, DateTimeKind.Unspecified) });

            migrationBuilder.UpdateData(
                table: "TimeRegistrations",
                keyColumn: "TimeRegistrationId",
                keyValue: 934,
                columns: new[] { "EndTime", "StartTime" },
                values: new object[] { new DateTime(2024, 10, 27, 23, 47, 22, 0, DateTimeKind.Unspecified), new DateTime(2024, 3, 24, 16, 30, 52, 0, DateTimeKind.Unspecified) });

            migrationBuilder.UpdateData(
                table: "TimeRegistrations",
                keyColumn: "TimeRegistrationId",
                keyValue: 935,
                columns: new[] { "EndTime", "StartTime" },
                values: new object[] { new DateTime(2024, 1, 25, 5, 51, 52, 0, DateTimeKind.Unspecified), new DateTime(2024, 11, 4, 9, 54, 20, 0, DateTimeKind.Unspecified) });

            migrationBuilder.UpdateData(
                table: "TimeRegistrations",
                keyColumn: "TimeRegistrationId",
                keyValue: 936,
                columns: new[] { "EndTime", "StartTime" },
                values: new object[] { new DateTime(2024, 3, 25, 2, 48, 1, 0, DateTimeKind.Unspecified), new DateTime(2024, 6, 9, 11, 24, 37, 0, DateTimeKind.Unspecified) });

            migrationBuilder.UpdateData(
                table: "TimeRegistrations",
                keyColumn: "TimeRegistrationId",
                keyValue: 937,
                columns: new[] { "EndTime", "StartTime" },
                values: new object[] { new DateTime(2024, 12, 11, 14, 6, 23, 0, DateTimeKind.Unspecified), new DateTime(2024, 7, 3, 0, 53, 10, 0, DateTimeKind.Unspecified) });

            migrationBuilder.UpdateData(
                table: "TimeRegistrations",
                keyColumn: "TimeRegistrationId",
                keyValue: 938,
                columns: new[] { "EndTime", "StartTime" },
                values: new object[] { new DateTime(2024, 7, 30, 10, 54, 20, 0, DateTimeKind.Unspecified), new DateTime(2024, 3, 18, 0, 35, 31, 0, DateTimeKind.Unspecified) });

            migrationBuilder.UpdateData(
                table: "TimeRegistrations",
                keyColumn: "TimeRegistrationId",
                keyValue: 939,
                columns: new[] { "EndTime", "StartTime" },
                values: new object[] { new DateTime(2024, 8, 2, 6, 56, 26, 0, DateTimeKind.Unspecified), new DateTime(2024, 7, 14, 13, 28, 54, 0, DateTimeKind.Unspecified) });

            migrationBuilder.UpdateData(
                table: "TimeRegistrations",
                keyColumn: "TimeRegistrationId",
                keyValue: 940,
                columns: new[] { "EndTime", "StartTime" },
                values: new object[] { new DateTime(2024, 3, 14, 10, 42, 1, 0, DateTimeKind.Unspecified), new DateTime(2024, 2, 6, 5, 18, 54, 0, DateTimeKind.Unspecified) });

            migrationBuilder.UpdateData(
                table: "TimeRegistrations",
                keyColumn: "TimeRegistrationId",
                keyValue: 941,
                columns: new[] { "EndTime", "StartTime" },
                values: new object[] { new DateTime(2024, 6, 29, 4, 39, 24, 0, DateTimeKind.Unspecified), new DateTime(2024, 4, 2, 16, 3, 46, 0, DateTimeKind.Unspecified) });

            migrationBuilder.UpdateData(
                table: "TimeRegistrations",
                keyColumn: "TimeRegistrationId",
                keyValue: 942,
                columns: new[] { "EndTime", "StartTime" },
                values: new object[] { new DateTime(2024, 12, 16, 9, 8, 35, 0, DateTimeKind.Unspecified), new DateTime(2024, 3, 8, 19, 24, 35, 0, DateTimeKind.Unspecified) });

            migrationBuilder.UpdateData(
                table: "TimeRegistrations",
                keyColumn: "TimeRegistrationId",
                keyValue: 943,
                columns: new[] { "EndTime", "StartTime" },
                values: new object[] { new DateTime(2024, 6, 29, 7, 2, 48, 0, DateTimeKind.Unspecified), new DateTime(2024, 9, 16, 5, 37, 24, 0, DateTimeKind.Unspecified) });

            migrationBuilder.UpdateData(
                table: "TimeRegistrations",
                keyColumn: "TimeRegistrationId",
                keyValue: 944,
                columns: new[] { "EndTime", "StartTime" },
                values: new object[] { new DateTime(2024, 10, 29, 16, 48, 19, 0, DateTimeKind.Unspecified), new DateTime(2024, 8, 13, 22, 24, 11, 0, DateTimeKind.Unspecified) });

            migrationBuilder.UpdateData(
                table: "TimeRegistrations",
                keyColumn: "TimeRegistrationId",
                keyValue: 945,
                columns: new[] { "EndTime", "StartTime" },
                values: new object[] { new DateTime(2024, 10, 12, 4, 33, 58, 0, DateTimeKind.Unspecified), new DateTime(2024, 7, 5, 7, 14, 46, 0, DateTimeKind.Unspecified) });

            migrationBuilder.UpdateData(
                table: "TimeRegistrations",
                keyColumn: "TimeRegistrationId",
                keyValue: 946,
                columns: new[] { "EndTime", "StartTime" },
                values: new object[] { new DateTime(2024, 11, 14, 6, 17, 28, 0, DateTimeKind.Unspecified), new DateTime(2024, 7, 30, 21, 46, 51, 0, DateTimeKind.Unspecified) });

            migrationBuilder.UpdateData(
                table: "TimeRegistrations",
                keyColumn: "TimeRegistrationId",
                keyValue: 947,
                columns: new[] { "EndTime", "StartTime" },
                values: new object[] { new DateTime(2024, 5, 15, 9, 6, 20, 0, DateTimeKind.Unspecified), new DateTime(2024, 6, 18, 11, 57, 18, 0, DateTimeKind.Unspecified) });

            migrationBuilder.UpdateData(
                table: "TimeRegistrations",
                keyColumn: "TimeRegistrationId",
                keyValue: 948,
                columns: new[] { "EndTime", "StartTime" },
                values: new object[] { new DateTime(2024, 1, 11, 13, 57, 51, 0, DateTimeKind.Unspecified), new DateTime(2024, 4, 8, 17, 57, 49, 0, DateTimeKind.Unspecified) });

            migrationBuilder.UpdateData(
                table: "TimeRegistrations",
                keyColumn: "TimeRegistrationId",
                keyValue: 949,
                columns: new[] { "EndTime", "StartTime" },
                values: new object[] { new DateTime(2024, 3, 13, 9, 1, 48, 0, DateTimeKind.Unspecified), new DateTime(2024, 5, 11, 5, 32, 26, 0, DateTimeKind.Unspecified) });

            migrationBuilder.UpdateData(
                table: "TimeRegistrations",
                keyColumn: "TimeRegistrationId",
                keyValue: 950,
                columns: new[] { "EndTime", "StartTime" },
                values: new object[] { new DateTime(2024, 1, 11, 17, 29, 21, 0, DateTimeKind.Unspecified), new DateTime(2024, 1, 15, 9, 13, 31, 0, DateTimeKind.Unspecified) });

            migrationBuilder.UpdateData(
                table: "TimeRegistrations",
                keyColumn: "TimeRegistrationId",
                keyValue: 951,
                columns: new[] { "EndTime", "StartTime" },
                values: new object[] { new DateTime(2024, 12, 4, 11, 18, 55, 0, DateTimeKind.Unspecified), new DateTime(2024, 12, 13, 21, 19, 53, 0, DateTimeKind.Unspecified) });

            migrationBuilder.UpdateData(
                table: "TimeRegistrations",
                keyColumn: "TimeRegistrationId",
                keyValue: 952,
                columns: new[] { "EndTime", "StartTime" },
                values: new object[] { new DateTime(2024, 10, 23, 5, 45, 39, 0, DateTimeKind.Unspecified), new DateTime(2024, 3, 12, 0, 25, 0, 0, DateTimeKind.Unspecified) });

            migrationBuilder.UpdateData(
                table: "TimeRegistrations",
                keyColumn: "TimeRegistrationId",
                keyValue: 953,
                columns: new[] { "EndTime", "StartTime" },
                values: new object[] { new DateTime(2024, 1, 15, 19, 5, 45, 0, DateTimeKind.Unspecified), new DateTime(2024, 12, 27, 21, 11, 53, 0, DateTimeKind.Unspecified) });

            migrationBuilder.UpdateData(
                table: "TimeRegistrations",
                keyColumn: "TimeRegistrationId",
                keyValue: 954,
                columns: new[] { "EndTime", "StartTime" },
                values: new object[] { new DateTime(2024, 8, 6, 6, 25, 2, 0, DateTimeKind.Unspecified), new DateTime(2024, 2, 12, 17, 14, 12, 0, DateTimeKind.Unspecified) });

            migrationBuilder.UpdateData(
                table: "TimeRegistrations",
                keyColumn: "TimeRegistrationId",
                keyValue: 955,
                columns: new[] { "EndTime", "StartTime" },
                values: new object[] { new DateTime(2024, 1, 22, 16, 51, 23, 0, DateTimeKind.Unspecified), new DateTime(2024, 9, 1, 6, 37, 59, 0, DateTimeKind.Unspecified) });

            migrationBuilder.UpdateData(
                table: "TimeRegistrations",
                keyColumn: "TimeRegistrationId",
                keyValue: 956,
                columns: new[] { "EndTime", "StartTime" },
                values: new object[] { new DateTime(2024, 7, 13, 16, 15, 4, 0, DateTimeKind.Unspecified), new DateTime(2024, 9, 10, 11, 59, 1, 0, DateTimeKind.Unspecified) });

            migrationBuilder.UpdateData(
                table: "TimeRegistrations",
                keyColumn: "TimeRegistrationId",
                keyValue: 957,
                columns: new[] { "EndTime", "StartTime" },
                values: new object[] { new DateTime(2024, 5, 23, 13, 53, 40, 0, DateTimeKind.Unspecified), new DateTime(2024, 2, 1, 12, 0, 51, 0, DateTimeKind.Unspecified) });

            migrationBuilder.UpdateData(
                table: "TimeRegistrations",
                keyColumn: "TimeRegistrationId",
                keyValue: 958,
                columns: new[] { "EndTime", "StartTime" },
                values: new object[] { new DateTime(2024, 5, 22, 17, 45, 53, 0, DateTimeKind.Unspecified), new DateTime(2024, 4, 26, 5, 48, 14, 0, DateTimeKind.Unspecified) });

            migrationBuilder.UpdateData(
                table: "TimeRegistrations",
                keyColumn: "TimeRegistrationId",
                keyValue: 959,
                columns: new[] { "EndTime", "StartTime" },
                values: new object[] { new DateTime(2024, 10, 29, 4, 13, 44, 0, DateTimeKind.Unspecified), new DateTime(2024, 6, 25, 22, 8, 46, 0, DateTimeKind.Unspecified) });

            migrationBuilder.UpdateData(
                table: "TimeRegistrations",
                keyColumn: "TimeRegistrationId",
                keyValue: 960,
                columns: new[] { "EndTime", "StartTime" },
                values: new object[] { new DateTime(2024, 9, 18, 18, 20, 32, 0, DateTimeKind.Unspecified), new DateTime(2024, 4, 14, 16, 15, 10, 0, DateTimeKind.Unspecified) });

            migrationBuilder.UpdateData(
                table: "TimeRegistrations",
                keyColumn: "TimeRegistrationId",
                keyValue: 961,
                columns: new[] { "EndTime", "StartTime" },
                values: new object[] { new DateTime(2024, 9, 20, 21, 2, 47, 0, DateTimeKind.Unspecified), new DateTime(2024, 12, 19, 9, 34, 56, 0, DateTimeKind.Unspecified) });

            migrationBuilder.UpdateData(
                table: "TimeRegistrations",
                keyColumn: "TimeRegistrationId",
                keyValue: 962,
                columns: new[] { "EndTime", "StartTime" },
                values: new object[] { new DateTime(2024, 10, 20, 4, 33, 25, 0, DateTimeKind.Unspecified), new DateTime(2024, 4, 30, 9, 59, 17, 0, DateTimeKind.Unspecified) });

            migrationBuilder.UpdateData(
                table: "TimeRegistrations",
                keyColumn: "TimeRegistrationId",
                keyValue: 963,
                columns: new[] { "EndTime", "StartTime" },
                values: new object[] { new DateTime(2024, 1, 19, 13, 47, 37, 0, DateTimeKind.Unspecified), new DateTime(2024, 6, 4, 7, 26, 18, 0, DateTimeKind.Unspecified) });

            migrationBuilder.UpdateData(
                table: "TimeRegistrations",
                keyColumn: "TimeRegistrationId",
                keyValue: 964,
                columns: new[] { "EndTime", "StartTime" },
                values: new object[] { new DateTime(2024, 12, 18, 23, 54, 54, 0, DateTimeKind.Unspecified), new DateTime(2024, 7, 14, 20, 43, 5, 0, DateTimeKind.Unspecified) });

            migrationBuilder.UpdateData(
                table: "TimeRegistrations",
                keyColumn: "TimeRegistrationId",
                keyValue: 965,
                columns: new[] { "EndTime", "StartTime" },
                values: new object[] { new DateTime(2024, 2, 1, 23, 21, 32, 0, DateTimeKind.Unspecified), new DateTime(2024, 9, 6, 23, 48, 11, 0, DateTimeKind.Unspecified) });

            migrationBuilder.UpdateData(
                table: "TimeRegistrations",
                keyColumn: "TimeRegistrationId",
                keyValue: 966,
                columns: new[] { "EndTime", "StartTime" },
                values: new object[] { new DateTime(2024, 1, 21, 15, 14, 5, 0, DateTimeKind.Unspecified), new DateTime(2024, 9, 7, 7, 15, 20, 0, DateTimeKind.Unspecified) });

            migrationBuilder.UpdateData(
                table: "TimeRegistrations",
                keyColumn: "TimeRegistrationId",
                keyValue: 967,
                columns: new[] { "EndTime", "StartTime" },
                values: new object[] { new DateTime(2024, 4, 16, 0, 43, 35, 0, DateTimeKind.Unspecified), new DateTime(2024, 11, 27, 11, 24, 58, 0, DateTimeKind.Unspecified) });

            migrationBuilder.UpdateData(
                table: "TimeRegistrations",
                keyColumn: "TimeRegistrationId",
                keyValue: 968,
                columns: new[] { "EndTime", "StartTime" },
                values: new object[] { new DateTime(2024, 3, 25, 16, 43, 48, 0, DateTimeKind.Unspecified), new DateTime(2024, 12, 5, 5, 2, 49, 0, DateTimeKind.Unspecified) });

            migrationBuilder.UpdateData(
                table: "TimeRegistrations",
                keyColumn: "TimeRegistrationId",
                keyValue: 969,
                columns: new[] { "EndTime", "StartTime" },
                values: new object[] { new DateTime(2024, 9, 22, 6, 23, 56, 0, DateTimeKind.Unspecified), new DateTime(2024, 9, 20, 21, 55, 50, 0, DateTimeKind.Unspecified) });

            migrationBuilder.UpdateData(
                table: "TimeRegistrations",
                keyColumn: "TimeRegistrationId",
                keyValue: 970,
                columns: new[] { "EndTime", "StartTime" },
                values: new object[] { new DateTime(2024, 9, 7, 22, 36, 9, 0, DateTimeKind.Unspecified), new DateTime(2024, 11, 24, 7, 34, 45, 0, DateTimeKind.Unspecified) });

            migrationBuilder.UpdateData(
                table: "TimeRegistrations",
                keyColumn: "TimeRegistrationId",
                keyValue: 971,
                columns: new[] { "EndTime", "StartTime" },
                values: new object[] { new DateTime(2024, 2, 14, 2, 0, 20, 0, DateTimeKind.Unspecified), new DateTime(2024, 12, 19, 17, 10, 12, 0, DateTimeKind.Unspecified) });

            migrationBuilder.UpdateData(
                table: "TimeRegistrations",
                keyColumn: "TimeRegistrationId",
                keyValue: 972,
                columns: new[] { "EndTime", "StartTime" },
                values: new object[] { new DateTime(2024, 7, 27, 12, 44, 10, 0, DateTimeKind.Unspecified), new DateTime(2024, 2, 20, 12, 4, 14, 0, DateTimeKind.Unspecified) });

            migrationBuilder.UpdateData(
                table: "TimeRegistrations",
                keyColumn: "TimeRegistrationId",
                keyValue: 973,
                columns: new[] { "EndTime", "StartTime" },
                values: new object[] { new DateTime(2024, 11, 7, 14, 38, 54, 0, DateTimeKind.Unspecified), new DateTime(2024, 8, 11, 3, 1, 4, 0, DateTimeKind.Unspecified) });

            migrationBuilder.UpdateData(
                table: "TimeRegistrations",
                keyColumn: "TimeRegistrationId",
                keyValue: 974,
                columns: new[] { "EndTime", "StartTime" },
                values: new object[] { new DateTime(2024, 8, 21, 7, 21, 28, 0, DateTimeKind.Unspecified), new DateTime(2024, 8, 3, 16, 54, 5, 0, DateTimeKind.Unspecified) });

            migrationBuilder.UpdateData(
                table: "TimeRegistrations",
                keyColumn: "TimeRegistrationId",
                keyValue: 975,
                columns: new[] { "EndTime", "StartTime" },
                values: new object[] { new DateTime(2024, 7, 15, 6, 7, 40, 0, DateTimeKind.Unspecified), new DateTime(2024, 10, 29, 8, 14, 14, 0, DateTimeKind.Unspecified) });

            migrationBuilder.UpdateData(
                table: "TimeRegistrations",
                keyColumn: "TimeRegistrationId",
                keyValue: 976,
                columns: new[] { "EndTime", "StartTime" },
                values: new object[] { new DateTime(2024, 6, 2, 3, 29, 16, 0, DateTimeKind.Unspecified), new DateTime(2024, 11, 8, 15, 41, 42, 0, DateTimeKind.Unspecified) });

            migrationBuilder.UpdateData(
                table: "TimeRegistrations",
                keyColumn: "TimeRegistrationId",
                keyValue: 977,
                columns: new[] { "EndTime", "StartTime" },
                values: new object[] { new DateTime(2024, 7, 7, 20, 0, 45, 0, DateTimeKind.Unspecified), new DateTime(2024, 12, 28, 4, 59, 29, 0, DateTimeKind.Unspecified) });

            migrationBuilder.UpdateData(
                table: "TimeRegistrations",
                keyColumn: "TimeRegistrationId",
                keyValue: 978,
                columns: new[] { "EndTime", "StartTime" },
                values: new object[] { new DateTime(2024, 5, 31, 16, 17, 36, 0, DateTimeKind.Unspecified), new DateTime(2024, 8, 19, 1, 50, 52, 0, DateTimeKind.Unspecified) });

            migrationBuilder.UpdateData(
                table: "TimeRegistrations",
                keyColumn: "TimeRegistrationId",
                keyValue: 979,
                columns: new[] { "EndTime", "StartTime" },
                values: new object[] { new DateTime(2024, 1, 22, 12, 43, 41, 0, DateTimeKind.Unspecified), new DateTime(2024, 7, 31, 18, 34, 47, 0, DateTimeKind.Unspecified) });

            migrationBuilder.UpdateData(
                table: "TimeRegistrations",
                keyColumn: "TimeRegistrationId",
                keyValue: 980,
                columns: new[] { "EndTime", "StartTime" },
                values: new object[] { new DateTime(2024, 7, 1, 13, 11, 53, 0, DateTimeKind.Unspecified), new DateTime(2024, 2, 27, 3, 49, 15, 0, DateTimeKind.Unspecified) });

            migrationBuilder.UpdateData(
                table: "TimeRegistrations",
                keyColumn: "TimeRegistrationId",
                keyValue: 981,
                columns: new[] { "EndTime", "StartTime" },
                values: new object[] { new DateTime(2024, 12, 22, 14, 15, 50, 0, DateTimeKind.Unspecified), new DateTime(2024, 2, 7, 9, 47, 48, 0, DateTimeKind.Unspecified) });

            migrationBuilder.UpdateData(
                table: "TimeRegistrations",
                keyColumn: "TimeRegistrationId",
                keyValue: 982,
                columns: new[] { "EndTime", "StartTime" },
                values: new object[] { new DateTime(2024, 12, 19, 22, 27, 6, 0, DateTimeKind.Unspecified), new DateTime(2024, 8, 13, 4, 57, 52, 0, DateTimeKind.Unspecified) });

            migrationBuilder.UpdateData(
                table: "TimeRegistrations",
                keyColumn: "TimeRegistrationId",
                keyValue: 983,
                columns: new[] { "EndTime", "StartTime" },
                values: new object[] { new DateTime(2024, 1, 21, 6, 38, 44, 0, DateTimeKind.Unspecified), new DateTime(2024, 8, 23, 22, 32, 42, 0, DateTimeKind.Unspecified) });

            migrationBuilder.UpdateData(
                table: "TimeRegistrations",
                keyColumn: "TimeRegistrationId",
                keyValue: 984,
                columns: new[] { "EndTime", "StartTime" },
                values: new object[] { new DateTime(2024, 1, 19, 20, 56, 0, 0, DateTimeKind.Unspecified), new DateTime(2024, 1, 13, 7, 27, 5, 0, DateTimeKind.Unspecified) });

            migrationBuilder.UpdateData(
                table: "TimeRegistrations",
                keyColumn: "TimeRegistrationId",
                keyValue: 985,
                columns: new[] { "EndTime", "StartTime" },
                values: new object[] { new DateTime(2024, 6, 24, 23, 4, 17, 0, DateTimeKind.Unspecified), new DateTime(2024, 1, 6, 17, 40, 11, 0, DateTimeKind.Unspecified) });

            migrationBuilder.UpdateData(
                table: "TimeRegistrations",
                keyColumn: "TimeRegistrationId",
                keyValue: 986,
                columns: new[] { "EndTime", "StartTime" },
                values: new object[] { new DateTime(2024, 10, 14, 8, 21, 53, 0, DateTimeKind.Unspecified), new DateTime(2024, 1, 17, 5, 52, 5, 0, DateTimeKind.Unspecified) });

            migrationBuilder.UpdateData(
                table: "TimeRegistrations",
                keyColumn: "TimeRegistrationId",
                keyValue: 987,
                columns: new[] { "EndTime", "StartTime" },
                values: new object[] { new DateTime(2024, 10, 14, 3, 56, 30, 0, DateTimeKind.Unspecified), new DateTime(2024, 6, 21, 15, 44, 34, 0, DateTimeKind.Unspecified) });

            migrationBuilder.UpdateData(
                table: "TimeRegistrations",
                keyColumn: "TimeRegistrationId",
                keyValue: 988,
                columns: new[] { "EndTime", "StartTime" },
                values: new object[] { new DateTime(2024, 10, 1, 6, 57, 29, 0, DateTimeKind.Unspecified), new DateTime(2024, 2, 25, 5, 56, 21, 0, DateTimeKind.Unspecified) });

            migrationBuilder.UpdateData(
                table: "TimeRegistrations",
                keyColumn: "TimeRegistrationId",
                keyValue: 989,
                columns: new[] { "EndTime", "StartTime" },
                values: new object[] { new DateTime(2024, 4, 22, 3, 44, 6, 0, DateTimeKind.Unspecified), new DateTime(2024, 12, 10, 23, 34, 15, 0, DateTimeKind.Unspecified) });

            migrationBuilder.UpdateData(
                table: "TimeRegistrations",
                keyColumn: "TimeRegistrationId",
                keyValue: 990,
                columns: new[] { "EndTime", "StartTime" },
                values: new object[] { new DateTime(2024, 12, 6, 23, 55, 13, 0, DateTimeKind.Unspecified), new DateTime(2024, 1, 21, 23, 14, 51, 0, DateTimeKind.Unspecified) });

            migrationBuilder.UpdateData(
                table: "TimeRegistrations",
                keyColumn: "TimeRegistrationId",
                keyValue: 991,
                columns: new[] { "EndTime", "StartTime" },
                values: new object[] { new DateTime(2024, 6, 5, 13, 30, 35, 0, DateTimeKind.Unspecified), new DateTime(2024, 5, 4, 18, 37, 1, 0, DateTimeKind.Unspecified) });

            migrationBuilder.UpdateData(
                table: "TimeRegistrations",
                keyColumn: "TimeRegistrationId",
                keyValue: 992,
                columns: new[] { "EndTime", "StartTime" },
                values: new object[] { new DateTime(2024, 5, 1, 10, 14, 19, 0, DateTimeKind.Unspecified), new DateTime(2024, 6, 25, 20, 8, 31, 0, DateTimeKind.Unspecified) });

            migrationBuilder.UpdateData(
                table: "TimeRegistrations",
                keyColumn: "TimeRegistrationId",
                keyValue: 993,
                columns: new[] { "EndTime", "StartTime" },
                values: new object[] { new DateTime(2024, 12, 29, 14, 10, 32, 0, DateTimeKind.Unspecified), new DateTime(2024, 3, 6, 14, 8, 59, 0, DateTimeKind.Unspecified) });

            migrationBuilder.UpdateData(
                table: "TimeRegistrations",
                keyColumn: "TimeRegistrationId",
                keyValue: 994,
                columns: new[] { "EndTime", "StartTime" },
                values: new object[] { new DateTime(2024, 10, 17, 23, 20, 8, 0, DateTimeKind.Unspecified), new DateTime(2024, 7, 5, 19, 43, 35, 0, DateTimeKind.Unspecified) });

            migrationBuilder.UpdateData(
                table: "TimeRegistrations",
                keyColumn: "TimeRegistrationId",
                keyValue: 995,
                columns: new[] { "EndTime", "StartTime" },
                values: new object[] { new DateTime(2024, 11, 16, 9, 15, 3, 0, DateTimeKind.Unspecified), new DateTime(2024, 2, 4, 5, 44, 33, 0, DateTimeKind.Unspecified) });

            migrationBuilder.UpdateData(
                table: "TimeRegistrations",
                keyColumn: "TimeRegistrationId",
                keyValue: 996,
                columns: new[] { "EndTime", "StartTime" },
                values: new object[] { new DateTime(2024, 2, 23, 13, 11, 23, 0, DateTimeKind.Unspecified), new DateTime(2024, 2, 17, 16, 42, 9, 0, DateTimeKind.Unspecified) });

            migrationBuilder.UpdateData(
                table: "TimeRegistrations",
                keyColumn: "TimeRegistrationId",
                keyValue: 997,
                columns: new[] { "EndTime", "StartTime" },
                values: new object[] { new DateTime(2024, 8, 2, 16, 40, 21, 0, DateTimeKind.Unspecified), new DateTime(2024, 9, 5, 17, 33, 57, 0, DateTimeKind.Unspecified) });

            migrationBuilder.UpdateData(
                table: "TimeRegistrations",
                keyColumn: "TimeRegistrationId",
                keyValue: 998,
                columns: new[] { "EndTime", "StartTime" },
                values: new object[] { new DateTime(2024, 8, 24, 22, 22, 18, 0, DateTimeKind.Unspecified), new DateTime(2024, 8, 2, 17, 17, 40, 0, DateTimeKind.Unspecified) });

            migrationBuilder.UpdateData(
                table: "TimeRegistrations",
                keyColumn: "TimeRegistrationId",
                keyValue: 999,
                columns: new[] { "EndTime", "StartTime" },
                values: new object[] { new DateTime(2024, 5, 24, 5, 58, 27, 0, DateTimeKind.Unspecified), new DateTime(2024, 10, 11, 15, 6, 22, 0, DateTimeKind.Unspecified) });

            migrationBuilder.UpdateData(
                table: "TimeRegistrations",
                keyColumn: "TimeRegistrationId",
                keyValue: 1000,
                columns: new[] { "EndTime", "StartTime" },
                values: new object[] { new DateTime(2024, 4, 15, 5, 33, 46, 0, DateTimeKind.Unspecified), new DateTime(2024, 10, 30, 6, 0, 12, 0, DateTimeKind.Unspecified) });

            migrationBuilder.CreateIndex(
                name: "IX_AspNetRoleClaims_RoleId",
                table: "AspNetRoleClaims",
                column: "RoleId");

            migrationBuilder.CreateIndex(
                name: "RoleNameIndex",
                table: "AspNetRoles",
                column: "NormalizedName",
                unique: true,
                filter: "[NormalizedName] IS NOT NULL");

            migrationBuilder.CreateIndex(
                name: "IX_AspNetUserClaims_UserId",
                table: "AspNetUserClaims",
                column: "UserId");

            migrationBuilder.CreateIndex(
                name: "IX_AspNetUserLogins_UserId",
                table: "AspNetUserLogins",
                column: "UserId");

            migrationBuilder.CreateIndex(
                name: "IX_AspNetUserRoles_RoleId",
                table: "AspNetUserRoles",
                column: "RoleId");

            migrationBuilder.CreateIndex(
                name: "EmailIndex",
                table: "AspNetUsers",
                column: "NormalizedEmail");

            migrationBuilder.CreateIndex(
                name: "UserNameIndex",
                table: "AspNetUsers",
                column: "NormalizedUserName",
                unique: true,
                filter: "[NormalizedUserName] IS NOT NULL");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "AspNetRoleClaims");

            migrationBuilder.DropTable(
                name: "AspNetUserClaims");

            migrationBuilder.DropTable(
                name: "AspNetUserLogins");

            migrationBuilder.DropTable(
                name: "AspNetUserRoles");

            migrationBuilder.DropTable(
                name: "AspNetUserTokens");

            migrationBuilder.DropTable(
                name: "AspNetRoles");

            migrationBuilder.DropTable(
                name: "AspNetUsers");

            migrationBuilder.AlterColumn<string>(
                name: "LastName",
                table: "Employees",
                type: "nvarchar(max)",
                nullable: false,
                oldClrType: typeof(string),
                oldType: "nvarchar(50)",
                oldMaxLength: 50);

            migrationBuilder.AlterColumn<string>(
                name: "FirstName",
                table: "Employees",
                type: "nvarchar(max)",
                nullable: false,
                oldClrType: typeof(string),
                oldType: "nvarchar(50)",
                oldMaxLength: 50);

            migrationBuilder.AlterColumn<string>(
                name: "Comment",
                table: "Employees",
                type: "nvarchar(max)",
                nullable: false,
                oldClrType: typeof(string),
                oldType: "nvarchar(1000)",
                oldMaxLength: 1000);

            migrationBuilder.UpdateData(
                table: "TimeRegistrations",
                keyColumn: "TimeRegistrationId",
                keyValue: 1,
                columns: new[] { "EndTime", "StartTime" },
                values: new object[] { new DateTime(2024, 8, 23, 5, 11, 34, 0, DateTimeKind.Unspecified), new DateTime(2024, 10, 20, 2, 58, 23, 0, DateTimeKind.Unspecified) });

            migrationBuilder.UpdateData(
                table: "TimeRegistrations",
                keyColumn: "TimeRegistrationId",
                keyValue: 2,
                columns: new[] { "EndTime", "StartTime" },
                values: new object[] { new DateTime(2024, 10, 17, 14, 12, 52, 0, DateTimeKind.Unspecified), new DateTime(2024, 9, 29, 16, 48, 14, 0, DateTimeKind.Unspecified) });

            migrationBuilder.UpdateData(
                table: "TimeRegistrations",
                keyColumn: "TimeRegistrationId",
                keyValue: 3,
                columns: new[] { "EndTime", "StartTime" },
                values: new object[] { new DateTime(2024, 9, 27, 14, 10, 12, 0, DateTimeKind.Unspecified), new DateTime(2024, 5, 18, 4, 22, 34, 0, DateTimeKind.Unspecified) });

            migrationBuilder.UpdateData(
                table: "TimeRegistrations",
                keyColumn: "TimeRegistrationId",
                keyValue: 4,
                columns: new[] { "EndTime", "StartTime" },
                values: new object[] { new DateTime(2024, 10, 29, 7, 1, 36, 0, DateTimeKind.Unspecified), new DateTime(2024, 3, 6, 11, 35, 30, 0, DateTimeKind.Unspecified) });

            migrationBuilder.UpdateData(
                table: "TimeRegistrations",
                keyColumn: "TimeRegistrationId",
                keyValue: 5,
                columns: new[] { "EndTime", "StartTime" },
                values: new object[] { new DateTime(2024, 12, 2, 19, 28, 1, 0, DateTimeKind.Unspecified), new DateTime(2024, 7, 23, 0, 49, 41, 0, DateTimeKind.Unspecified) });

            migrationBuilder.UpdateData(
                table: "TimeRegistrations",
                keyColumn: "TimeRegistrationId",
                keyValue: 6,
                columns: new[] { "EndTime", "StartTime" },
                values: new object[] { new DateTime(2024, 6, 2, 16, 1, 34, 0, DateTimeKind.Unspecified), new DateTime(2024, 10, 7, 8, 24, 33, 0, DateTimeKind.Unspecified) });

            migrationBuilder.UpdateData(
                table: "TimeRegistrations",
                keyColumn: "TimeRegistrationId",
                keyValue: 7,
                columns: new[] { "EndTime", "StartTime" },
                values: new object[] { new DateTime(2024, 1, 1, 2, 51, 22, 0, DateTimeKind.Unspecified), new DateTime(2024, 5, 2, 16, 13, 41, 0, DateTimeKind.Unspecified) });

            migrationBuilder.UpdateData(
                table: "TimeRegistrations",
                keyColumn: "TimeRegistrationId",
                keyValue: 8,
                columns: new[] { "EndTime", "StartTime" },
                values: new object[] { new DateTime(2024, 7, 23, 20, 31, 53, 0, DateTimeKind.Unspecified), new DateTime(2024, 8, 7, 23, 29, 25, 0, DateTimeKind.Unspecified) });

            migrationBuilder.UpdateData(
                table: "TimeRegistrations",
                keyColumn: "TimeRegistrationId",
                keyValue: 9,
                columns: new[] { "EndTime", "StartTime" },
                values: new object[] { new DateTime(2024, 1, 27, 16, 28, 57, 0, DateTimeKind.Unspecified), new DateTime(2024, 8, 9, 20, 47, 21, 0, DateTimeKind.Unspecified) });

            migrationBuilder.UpdateData(
                table: "TimeRegistrations",
                keyColumn: "TimeRegistrationId",
                keyValue: 10,
                columns: new[] { "EndTime", "StartTime" },
                values: new object[] { new DateTime(2024, 3, 6, 18, 1, 12, 0, DateTimeKind.Unspecified), new DateTime(2024, 4, 21, 19, 9, 18, 0, DateTimeKind.Unspecified) });

            migrationBuilder.UpdateData(
                table: "TimeRegistrations",
                keyColumn: "TimeRegistrationId",
                keyValue: 11,
                columns: new[] { "EndTime", "StartTime" },
                values: new object[] { new DateTime(2024, 2, 25, 22, 46, 58, 0, DateTimeKind.Unspecified), new DateTime(2024, 12, 10, 11, 48, 28, 0, DateTimeKind.Unspecified) });

            migrationBuilder.UpdateData(
                table: "TimeRegistrations",
                keyColumn: "TimeRegistrationId",
                keyValue: 12,
                columns: new[] { "EndTime", "StartTime" },
                values: new object[] { new DateTime(2024, 2, 14, 14, 15, 13, 0, DateTimeKind.Unspecified), new DateTime(2024, 11, 9, 13, 22, 52, 0, DateTimeKind.Unspecified) });

            migrationBuilder.UpdateData(
                table: "TimeRegistrations",
                keyColumn: "TimeRegistrationId",
                keyValue: 13,
                columns: new[] { "EndTime", "StartTime" },
                values: new object[] { new DateTime(2024, 5, 29, 14, 21, 24, 0, DateTimeKind.Unspecified), new DateTime(2024, 3, 20, 3, 6, 14, 0, DateTimeKind.Unspecified) });

            migrationBuilder.UpdateData(
                table: "TimeRegistrations",
                keyColumn: "TimeRegistrationId",
                keyValue: 14,
                columns: new[] { "EndTime", "StartTime" },
                values: new object[] { new DateTime(2024, 11, 5, 15, 11, 30, 0, DateTimeKind.Unspecified), new DateTime(2024, 8, 18, 19, 56, 8, 0, DateTimeKind.Unspecified) });

            migrationBuilder.UpdateData(
                table: "TimeRegistrations",
                keyColumn: "TimeRegistrationId",
                keyValue: 15,
                columns: new[] { "EndTime", "StartTime" },
                values: new object[] { new DateTime(2024, 1, 15, 9, 9, 13, 0, DateTimeKind.Unspecified), new DateTime(2024, 6, 8, 7, 44, 12, 0, DateTimeKind.Unspecified) });

            migrationBuilder.UpdateData(
                table: "TimeRegistrations",
                keyColumn: "TimeRegistrationId",
                keyValue: 16,
                columns: new[] { "EndTime", "StartTime" },
                values: new object[] { new DateTime(2024, 1, 10, 23, 25, 54, 0, DateTimeKind.Unspecified), new DateTime(2024, 1, 29, 17, 3, 21, 0, DateTimeKind.Unspecified) });

            migrationBuilder.UpdateData(
                table: "TimeRegistrations",
                keyColumn: "TimeRegistrationId",
                keyValue: 17,
                columns: new[] { "EndTime", "StartTime" },
                values: new object[] { new DateTime(2024, 10, 17, 22, 33, 0, 0, DateTimeKind.Unspecified), new DateTime(2024, 2, 10, 10, 50, 1, 0, DateTimeKind.Unspecified) });

            migrationBuilder.UpdateData(
                table: "TimeRegistrations",
                keyColumn: "TimeRegistrationId",
                keyValue: 18,
                columns: new[] { "EndTime", "StartTime" },
                values: new object[] { new DateTime(2024, 8, 31, 6, 24, 53, 0, DateTimeKind.Unspecified), new DateTime(2024, 9, 8, 21, 39, 2, 0, DateTimeKind.Unspecified) });

            migrationBuilder.UpdateData(
                table: "TimeRegistrations",
                keyColumn: "TimeRegistrationId",
                keyValue: 19,
                columns: new[] { "EndTime", "StartTime" },
                values: new object[] { new DateTime(2024, 4, 16, 21, 5, 27, 0, DateTimeKind.Unspecified), new DateTime(2024, 11, 8, 8, 18, 52, 0, DateTimeKind.Unspecified) });

            migrationBuilder.UpdateData(
                table: "TimeRegistrations",
                keyColumn: "TimeRegistrationId",
                keyValue: 20,
                columns: new[] { "EndTime", "StartTime" },
                values: new object[] { new DateTime(2024, 11, 24, 5, 24, 8, 0, DateTimeKind.Unspecified), new DateTime(2024, 8, 29, 0, 50, 4, 0, DateTimeKind.Unspecified) });

            migrationBuilder.UpdateData(
                table: "TimeRegistrations",
                keyColumn: "TimeRegistrationId",
                keyValue: 21,
                columns: new[] { "EndTime", "StartTime" },
                values: new object[] { new DateTime(2024, 5, 14, 12, 20, 5, 0, DateTimeKind.Unspecified), new DateTime(2024, 8, 5, 12, 8, 8, 0, DateTimeKind.Unspecified) });

            migrationBuilder.UpdateData(
                table: "TimeRegistrations",
                keyColumn: "TimeRegistrationId",
                keyValue: 22,
                columns: new[] { "EndTime", "StartTime" },
                values: new object[] { new DateTime(2024, 11, 26, 10, 11, 33, 0, DateTimeKind.Unspecified), new DateTime(2024, 3, 9, 14, 59, 44, 0, DateTimeKind.Unspecified) });

            migrationBuilder.UpdateData(
                table: "TimeRegistrations",
                keyColumn: "TimeRegistrationId",
                keyValue: 23,
                columns: new[] { "EndTime", "StartTime" },
                values: new object[] { new DateTime(2024, 9, 3, 10, 42, 0, 0, DateTimeKind.Unspecified), new DateTime(2024, 11, 13, 0, 56, 42, 0, DateTimeKind.Unspecified) });

            migrationBuilder.UpdateData(
                table: "TimeRegistrations",
                keyColumn: "TimeRegistrationId",
                keyValue: 24,
                columns: new[] { "EndTime", "StartTime" },
                values: new object[] { new DateTime(2024, 12, 24, 18, 36, 13, 0, DateTimeKind.Unspecified), new DateTime(2024, 6, 6, 17, 44, 13, 0, DateTimeKind.Unspecified) });

            migrationBuilder.UpdateData(
                table: "TimeRegistrations",
                keyColumn: "TimeRegistrationId",
                keyValue: 25,
                columns: new[] { "EndTime", "StartTime" },
                values: new object[] { new DateTime(2024, 5, 4, 1, 6, 22, 0, DateTimeKind.Unspecified), new DateTime(2024, 1, 4, 12, 0, 9, 0, DateTimeKind.Unspecified) });

            migrationBuilder.UpdateData(
                table: "TimeRegistrations",
                keyColumn: "TimeRegistrationId",
                keyValue: 26,
                columns: new[] { "EndTime", "StartTime" },
                values: new object[] { new DateTime(2024, 9, 12, 20, 7, 2, 0, DateTimeKind.Unspecified), new DateTime(2024, 12, 22, 23, 34, 46, 0, DateTimeKind.Unspecified) });

            migrationBuilder.UpdateData(
                table: "TimeRegistrations",
                keyColumn: "TimeRegistrationId",
                keyValue: 27,
                columns: new[] { "EndTime", "StartTime" },
                values: new object[] { new DateTime(2024, 12, 19, 7, 50, 55, 0, DateTimeKind.Unspecified), new DateTime(2024, 6, 16, 6, 28, 10, 0, DateTimeKind.Unspecified) });

            migrationBuilder.UpdateData(
                table: "TimeRegistrations",
                keyColumn: "TimeRegistrationId",
                keyValue: 28,
                columns: new[] { "EndTime", "StartTime" },
                values: new object[] { new DateTime(2024, 11, 13, 8, 9, 54, 0, DateTimeKind.Unspecified), new DateTime(2024, 1, 8, 12, 56, 52, 0, DateTimeKind.Unspecified) });

            migrationBuilder.UpdateData(
                table: "TimeRegistrations",
                keyColumn: "TimeRegistrationId",
                keyValue: 29,
                columns: new[] { "EndTime", "StartTime" },
                values: new object[] { new DateTime(2024, 1, 8, 13, 17, 6, 0, DateTimeKind.Unspecified), new DateTime(2024, 7, 15, 15, 40, 31, 0, DateTimeKind.Unspecified) });

            migrationBuilder.UpdateData(
                table: "TimeRegistrations",
                keyColumn: "TimeRegistrationId",
                keyValue: 30,
                columns: new[] { "EndTime", "StartTime" },
                values: new object[] { new DateTime(2024, 10, 22, 23, 27, 45, 0, DateTimeKind.Unspecified), new DateTime(2024, 5, 7, 5, 12, 52, 0, DateTimeKind.Unspecified) });

            migrationBuilder.UpdateData(
                table: "TimeRegistrations",
                keyColumn: "TimeRegistrationId",
                keyValue: 31,
                columns: new[] { "EndTime", "StartTime" },
                values: new object[] { new DateTime(2024, 10, 8, 0, 11, 10, 0, DateTimeKind.Unspecified), new DateTime(2024, 3, 31, 5, 47, 22, 0, DateTimeKind.Unspecified) });

            migrationBuilder.UpdateData(
                table: "TimeRegistrations",
                keyColumn: "TimeRegistrationId",
                keyValue: 32,
                columns: new[] { "EndTime", "StartTime" },
                values: new object[] { new DateTime(2024, 8, 1, 0, 47, 29, 0, DateTimeKind.Unspecified), new DateTime(2024, 12, 5, 7, 3, 18, 0, DateTimeKind.Unspecified) });

            migrationBuilder.UpdateData(
                table: "TimeRegistrations",
                keyColumn: "TimeRegistrationId",
                keyValue: 33,
                columns: new[] { "EndTime", "StartTime" },
                values: new object[] { new DateTime(2024, 9, 17, 17, 35, 14, 0, DateTimeKind.Unspecified), new DateTime(2024, 11, 26, 16, 32, 41, 0, DateTimeKind.Unspecified) });

            migrationBuilder.UpdateData(
                table: "TimeRegistrations",
                keyColumn: "TimeRegistrationId",
                keyValue: 34,
                columns: new[] { "EndTime", "StartTime" },
                values: new object[] { new DateTime(2024, 2, 26, 9, 42, 47, 0, DateTimeKind.Unspecified), new DateTime(2024, 6, 15, 16, 38, 30, 0, DateTimeKind.Unspecified) });

            migrationBuilder.UpdateData(
                table: "TimeRegistrations",
                keyColumn: "TimeRegistrationId",
                keyValue: 35,
                columns: new[] { "EndTime", "StartTime" },
                values: new object[] { new DateTime(2024, 1, 12, 9, 5, 45, 0, DateTimeKind.Unspecified), new DateTime(2024, 6, 9, 5, 37, 26, 0, DateTimeKind.Unspecified) });

            migrationBuilder.UpdateData(
                table: "TimeRegistrations",
                keyColumn: "TimeRegistrationId",
                keyValue: 36,
                columns: new[] { "EndTime", "StartTime" },
                values: new object[] { new DateTime(2024, 9, 11, 16, 45, 7, 0, DateTimeKind.Unspecified), new DateTime(2024, 2, 10, 17, 8, 24, 0, DateTimeKind.Unspecified) });

            migrationBuilder.UpdateData(
                table: "TimeRegistrations",
                keyColumn: "TimeRegistrationId",
                keyValue: 37,
                columns: new[] { "EndTime", "StartTime" },
                values: new object[] { new DateTime(2024, 12, 2, 13, 28, 18, 0, DateTimeKind.Unspecified), new DateTime(2024, 7, 7, 7, 58, 1, 0, DateTimeKind.Unspecified) });

            migrationBuilder.UpdateData(
                table: "TimeRegistrations",
                keyColumn: "TimeRegistrationId",
                keyValue: 38,
                columns: new[] { "EndTime", "StartTime" },
                values: new object[] { new DateTime(2024, 6, 26, 4, 19, 12, 0, DateTimeKind.Unspecified), new DateTime(2024, 4, 4, 17, 25, 33, 0, DateTimeKind.Unspecified) });

            migrationBuilder.UpdateData(
                table: "TimeRegistrations",
                keyColumn: "TimeRegistrationId",
                keyValue: 39,
                columns: new[] { "EndTime", "StartTime" },
                values: new object[] { new DateTime(2024, 4, 15, 19, 15, 52, 0, DateTimeKind.Unspecified), new DateTime(2024, 8, 26, 8, 37, 5, 0, DateTimeKind.Unspecified) });

            migrationBuilder.UpdateData(
                table: "TimeRegistrations",
                keyColumn: "TimeRegistrationId",
                keyValue: 40,
                columns: new[] { "EndTime", "StartTime" },
                values: new object[] { new DateTime(2024, 7, 12, 8, 56, 3, 0, DateTimeKind.Unspecified), new DateTime(2024, 5, 26, 5, 41, 20, 0, DateTimeKind.Unspecified) });

            migrationBuilder.UpdateData(
                table: "TimeRegistrations",
                keyColumn: "TimeRegistrationId",
                keyValue: 41,
                columns: new[] { "EndTime", "StartTime" },
                values: new object[] { new DateTime(2024, 4, 5, 16, 32, 30, 0, DateTimeKind.Unspecified), new DateTime(2024, 7, 11, 6, 32, 52, 0, DateTimeKind.Unspecified) });

            migrationBuilder.UpdateData(
                table: "TimeRegistrations",
                keyColumn: "TimeRegistrationId",
                keyValue: 42,
                columns: new[] { "EndTime", "StartTime" },
                values: new object[] { new DateTime(2024, 5, 2, 16, 55, 47, 0, DateTimeKind.Unspecified), new DateTime(2024, 2, 17, 0, 39, 56, 0, DateTimeKind.Unspecified) });

            migrationBuilder.UpdateData(
                table: "TimeRegistrations",
                keyColumn: "TimeRegistrationId",
                keyValue: 43,
                columns: new[] { "EndTime", "StartTime" },
                values: new object[] { new DateTime(2024, 5, 16, 3, 19, 1, 0, DateTimeKind.Unspecified), new DateTime(2024, 5, 17, 9, 50, 20, 0, DateTimeKind.Unspecified) });

            migrationBuilder.UpdateData(
                table: "TimeRegistrations",
                keyColumn: "TimeRegistrationId",
                keyValue: 44,
                columns: new[] { "EndTime", "StartTime" },
                values: new object[] { new DateTime(2024, 7, 30, 1, 23, 21, 0, DateTimeKind.Unspecified), new DateTime(2024, 5, 3, 19, 5, 29, 0, DateTimeKind.Unspecified) });

            migrationBuilder.UpdateData(
                table: "TimeRegistrations",
                keyColumn: "TimeRegistrationId",
                keyValue: 45,
                columns: new[] { "EndTime", "StartTime" },
                values: new object[] { new DateTime(2024, 12, 28, 20, 16, 0, 0, DateTimeKind.Unspecified), new DateTime(2024, 8, 2, 13, 46, 38, 0, DateTimeKind.Unspecified) });

            migrationBuilder.UpdateData(
                table: "TimeRegistrations",
                keyColumn: "TimeRegistrationId",
                keyValue: 46,
                columns: new[] { "EndTime", "StartTime" },
                values: new object[] { new DateTime(2024, 10, 10, 0, 9, 13, 0, DateTimeKind.Unspecified), new DateTime(2024, 1, 24, 12, 19, 28, 0, DateTimeKind.Unspecified) });

            migrationBuilder.UpdateData(
                table: "TimeRegistrations",
                keyColumn: "TimeRegistrationId",
                keyValue: 47,
                columns: new[] { "EndTime", "StartTime" },
                values: new object[] { new DateTime(2024, 4, 9, 18, 51, 20, 0, DateTimeKind.Unspecified), new DateTime(2024, 3, 29, 4, 23, 26, 0, DateTimeKind.Unspecified) });

            migrationBuilder.UpdateData(
                table: "TimeRegistrations",
                keyColumn: "TimeRegistrationId",
                keyValue: 48,
                columns: new[] { "EndTime", "StartTime" },
                values: new object[] { new DateTime(2024, 10, 25, 5, 35, 53, 0, DateTimeKind.Unspecified), new DateTime(2024, 7, 16, 9, 56, 33, 0, DateTimeKind.Unspecified) });

            migrationBuilder.UpdateData(
                table: "TimeRegistrations",
                keyColumn: "TimeRegistrationId",
                keyValue: 49,
                columns: new[] { "EndTime", "StartTime" },
                values: new object[] { new DateTime(2024, 9, 18, 3, 46, 24, 0, DateTimeKind.Unspecified), new DateTime(2024, 7, 13, 14, 59, 19, 0, DateTimeKind.Unspecified) });

            migrationBuilder.UpdateData(
                table: "TimeRegistrations",
                keyColumn: "TimeRegistrationId",
                keyValue: 50,
                columns: new[] { "EndTime", "StartTime" },
                values: new object[] { new DateTime(2024, 5, 18, 20, 59, 45, 0, DateTimeKind.Unspecified), new DateTime(2024, 11, 19, 3, 2, 3, 0, DateTimeKind.Unspecified) });

            migrationBuilder.UpdateData(
                table: "TimeRegistrations",
                keyColumn: "TimeRegistrationId",
                keyValue: 51,
                columns: new[] { "EndTime", "StartTime" },
                values: new object[] { new DateTime(2024, 9, 15, 16, 48, 29, 0, DateTimeKind.Unspecified), new DateTime(2024, 11, 10, 19, 48, 2, 0, DateTimeKind.Unspecified) });

            migrationBuilder.UpdateData(
                table: "TimeRegistrations",
                keyColumn: "TimeRegistrationId",
                keyValue: 52,
                columns: new[] { "EndTime", "StartTime" },
                values: new object[] { new DateTime(2024, 10, 29, 22, 7, 7, 0, DateTimeKind.Unspecified), new DateTime(2024, 8, 18, 15, 4, 5, 0, DateTimeKind.Unspecified) });

            migrationBuilder.UpdateData(
                table: "TimeRegistrations",
                keyColumn: "TimeRegistrationId",
                keyValue: 53,
                columns: new[] { "EndTime", "StartTime" },
                values: new object[] { new DateTime(2024, 3, 7, 22, 19, 26, 0, DateTimeKind.Unspecified), new DateTime(2024, 10, 11, 14, 29, 21, 0, DateTimeKind.Unspecified) });

            migrationBuilder.UpdateData(
                table: "TimeRegistrations",
                keyColumn: "TimeRegistrationId",
                keyValue: 54,
                columns: new[] { "EndTime", "StartTime" },
                values: new object[] { new DateTime(2024, 11, 5, 6, 12, 24, 0, DateTimeKind.Unspecified), new DateTime(2024, 6, 15, 20, 50, 48, 0, DateTimeKind.Unspecified) });

            migrationBuilder.UpdateData(
                table: "TimeRegistrations",
                keyColumn: "TimeRegistrationId",
                keyValue: 55,
                columns: new[] { "EndTime", "StartTime" },
                values: new object[] { new DateTime(2024, 12, 19, 4, 2, 8, 0, DateTimeKind.Unspecified), new DateTime(2024, 11, 20, 22, 52, 37, 0, DateTimeKind.Unspecified) });

            migrationBuilder.UpdateData(
                table: "TimeRegistrations",
                keyColumn: "TimeRegistrationId",
                keyValue: 56,
                columns: new[] { "EndTime", "StartTime" },
                values: new object[] { new DateTime(2024, 7, 26, 7, 16, 49, 0, DateTimeKind.Unspecified), new DateTime(2024, 12, 24, 18, 23, 4, 0, DateTimeKind.Unspecified) });

            migrationBuilder.UpdateData(
                table: "TimeRegistrations",
                keyColumn: "TimeRegistrationId",
                keyValue: 57,
                columns: new[] { "EndTime", "StartTime" },
                values: new object[] { new DateTime(2024, 1, 2, 11, 1, 15, 0, DateTimeKind.Unspecified), new DateTime(2024, 6, 20, 7, 37, 58, 0, DateTimeKind.Unspecified) });

            migrationBuilder.UpdateData(
                table: "TimeRegistrations",
                keyColumn: "TimeRegistrationId",
                keyValue: 58,
                columns: new[] { "EndTime", "StartTime" },
                values: new object[] { new DateTime(2024, 2, 10, 14, 48, 23, 0, DateTimeKind.Unspecified), new DateTime(2024, 1, 24, 15, 57, 49, 0, DateTimeKind.Unspecified) });

            migrationBuilder.UpdateData(
                table: "TimeRegistrations",
                keyColumn: "TimeRegistrationId",
                keyValue: 59,
                columns: new[] { "EndTime", "StartTime" },
                values: new object[] { new DateTime(2024, 7, 1, 14, 22, 6, 0, DateTimeKind.Unspecified), new DateTime(2024, 10, 31, 3, 30, 35, 0, DateTimeKind.Unspecified) });

            migrationBuilder.UpdateData(
                table: "TimeRegistrations",
                keyColumn: "TimeRegistrationId",
                keyValue: 60,
                columns: new[] { "EndTime", "StartTime" },
                values: new object[] { new DateTime(2024, 2, 17, 0, 8, 1, 0, DateTimeKind.Unspecified), new DateTime(2024, 3, 8, 6, 50, 18, 0, DateTimeKind.Unspecified) });

            migrationBuilder.UpdateData(
                table: "TimeRegistrations",
                keyColumn: "TimeRegistrationId",
                keyValue: 61,
                columns: new[] { "EndTime", "StartTime" },
                values: new object[] { new DateTime(2024, 8, 26, 20, 18, 28, 0, DateTimeKind.Unspecified), new DateTime(2024, 3, 28, 23, 38, 58, 0, DateTimeKind.Unspecified) });

            migrationBuilder.UpdateData(
                table: "TimeRegistrations",
                keyColumn: "TimeRegistrationId",
                keyValue: 62,
                columns: new[] { "EndTime", "StartTime" },
                values: new object[] { new DateTime(2024, 6, 24, 12, 1, 34, 0, DateTimeKind.Unspecified), new DateTime(2024, 12, 6, 20, 10, 12, 0, DateTimeKind.Unspecified) });

            migrationBuilder.UpdateData(
                table: "TimeRegistrations",
                keyColumn: "TimeRegistrationId",
                keyValue: 63,
                columns: new[] { "EndTime", "StartTime" },
                values: new object[] { new DateTime(2024, 1, 18, 4, 29, 47, 0, DateTimeKind.Unspecified), new DateTime(2024, 11, 3, 22, 28, 15, 0, DateTimeKind.Unspecified) });

            migrationBuilder.UpdateData(
                table: "TimeRegistrations",
                keyColumn: "TimeRegistrationId",
                keyValue: 64,
                columns: new[] { "EndTime", "StartTime" },
                values: new object[] { new DateTime(2024, 3, 1, 23, 59, 56, 0, DateTimeKind.Unspecified), new DateTime(2024, 5, 27, 6, 17, 44, 0, DateTimeKind.Unspecified) });

            migrationBuilder.UpdateData(
                table: "TimeRegistrations",
                keyColumn: "TimeRegistrationId",
                keyValue: 65,
                columns: new[] { "EndTime", "StartTime" },
                values: new object[] { new DateTime(2024, 6, 10, 7, 29, 4, 0, DateTimeKind.Unspecified), new DateTime(2024, 4, 28, 17, 0, 27, 0, DateTimeKind.Unspecified) });

            migrationBuilder.UpdateData(
                table: "TimeRegistrations",
                keyColumn: "TimeRegistrationId",
                keyValue: 66,
                columns: new[] { "EndTime", "StartTime" },
                values: new object[] { new DateTime(2024, 12, 23, 10, 12, 15, 0, DateTimeKind.Unspecified), new DateTime(2024, 1, 28, 22, 28, 43, 0, DateTimeKind.Unspecified) });

            migrationBuilder.UpdateData(
                table: "TimeRegistrations",
                keyColumn: "TimeRegistrationId",
                keyValue: 67,
                columns: new[] { "EndTime", "StartTime" },
                values: new object[] { new DateTime(2024, 9, 27, 18, 4, 0, 0, DateTimeKind.Unspecified), new DateTime(2024, 12, 21, 5, 22, 53, 0, DateTimeKind.Unspecified) });

            migrationBuilder.UpdateData(
                table: "TimeRegistrations",
                keyColumn: "TimeRegistrationId",
                keyValue: 68,
                columns: new[] { "EndTime", "StartTime" },
                values: new object[] { new DateTime(2024, 12, 13, 2, 3, 7, 0, DateTimeKind.Unspecified), new DateTime(2024, 6, 9, 10, 32, 46, 0, DateTimeKind.Unspecified) });

            migrationBuilder.UpdateData(
                table: "TimeRegistrations",
                keyColumn: "TimeRegistrationId",
                keyValue: 69,
                columns: new[] { "EndTime", "StartTime" },
                values: new object[] { new DateTime(2024, 9, 7, 9, 50, 40, 0, DateTimeKind.Unspecified), new DateTime(2024, 12, 19, 5, 17, 11, 0, DateTimeKind.Unspecified) });

            migrationBuilder.UpdateData(
                table: "TimeRegistrations",
                keyColumn: "TimeRegistrationId",
                keyValue: 70,
                columns: new[] { "EndTime", "StartTime" },
                values: new object[] { new DateTime(2024, 7, 10, 7, 53, 47, 0, DateTimeKind.Unspecified), new DateTime(2024, 11, 16, 2, 28, 47, 0, DateTimeKind.Unspecified) });

            migrationBuilder.UpdateData(
                table: "TimeRegistrations",
                keyColumn: "TimeRegistrationId",
                keyValue: 71,
                columns: new[] { "EndTime", "StartTime" },
                values: new object[] { new DateTime(2024, 5, 26, 12, 59, 46, 0, DateTimeKind.Unspecified), new DateTime(2024, 3, 6, 9, 30, 3, 0, DateTimeKind.Unspecified) });

            migrationBuilder.UpdateData(
                table: "TimeRegistrations",
                keyColumn: "TimeRegistrationId",
                keyValue: 72,
                columns: new[] { "EndTime", "StartTime" },
                values: new object[] { new DateTime(2024, 9, 2, 23, 27, 22, 0, DateTimeKind.Unspecified), new DateTime(2024, 11, 3, 8, 15, 24, 0, DateTimeKind.Unspecified) });

            migrationBuilder.UpdateData(
                table: "TimeRegistrations",
                keyColumn: "TimeRegistrationId",
                keyValue: 73,
                columns: new[] { "EndTime", "StartTime" },
                values: new object[] { new DateTime(2024, 4, 3, 6, 30, 37, 0, DateTimeKind.Unspecified), new DateTime(2024, 6, 24, 1, 53, 40, 0, DateTimeKind.Unspecified) });

            migrationBuilder.UpdateData(
                table: "TimeRegistrations",
                keyColumn: "TimeRegistrationId",
                keyValue: 74,
                columns: new[] { "EndTime", "StartTime" },
                values: new object[] { new DateTime(2024, 8, 13, 20, 50, 7, 0, DateTimeKind.Unspecified), new DateTime(2024, 10, 31, 6, 49, 49, 0, DateTimeKind.Unspecified) });

            migrationBuilder.UpdateData(
                table: "TimeRegistrations",
                keyColumn: "TimeRegistrationId",
                keyValue: 75,
                columns: new[] { "EndTime", "StartTime" },
                values: new object[] { new DateTime(2024, 1, 5, 4, 38, 54, 0, DateTimeKind.Unspecified), new DateTime(2024, 10, 18, 21, 0, 42, 0, DateTimeKind.Unspecified) });

            migrationBuilder.UpdateData(
                table: "TimeRegistrations",
                keyColumn: "TimeRegistrationId",
                keyValue: 76,
                columns: new[] { "EndTime", "StartTime" },
                values: new object[] { new DateTime(2024, 6, 24, 1, 26, 20, 0, DateTimeKind.Unspecified), new DateTime(2024, 3, 3, 20, 51, 52, 0, DateTimeKind.Unspecified) });

            migrationBuilder.UpdateData(
                table: "TimeRegistrations",
                keyColumn: "TimeRegistrationId",
                keyValue: 77,
                columns: new[] { "EndTime", "StartTime" },
                values: new object[] { new DateTime(2024, 2, 1, 6, 14, 37, 0, DateTimeKind.Unspecified), new DateTime(2024, 1, 7, 5, 57, 35, 0, DateTimeKind.Unspecified) });

            migrationBuilder.UpdateData(
                table: "TimeRegistrations",
                keyColumn: "TimeRegistrationId",
                keyValue: 78,
                columns: new[] { "EndTime", "StartTime" },
                values: new object[] { new DateTime(2024, 4, 1, 3, 47, 49, 0, DateTimeKind.Unspecified), new DateTime(2024, 8, 22, 5, 15, 30, 0, DateTimeKind.Unspecified) });

            migrationBuilder.UpdateData(
                table: "TimeRegistrations",
                keyColumn: "TimeRegistrationId",
                keyValue: 79,
                columns: new[] { "EndTime", "StartTime" },
                values: new object[] { new DateTime(2024, 8, 27, 1, 58, 10, 0, DateTimeKind.Unspecified), new DateTime(2024, 10, 21, 1, 1, 7, 0, DateTimeKind.Unspecified) });

            migrationBuilder.UpdateData(
                table: "TimeRegistrations",
                keyColumn: "TimeRegistrationId",
                keyValue: 80,
                columns: new[] { "EndTime", "StartTime" },
                values: new object[] { new DateTime(2024, 4, 9, 20, 3, 34, 0, DateTimeKind.Unspecified), new DateTime(2024, 5, 27, 6, 0, 48, 0, DateTimeKind.Unspecified) });

            migrationBuilder.UpdateData(
                table: "TimeRegistrations",
                keyColumn: "TimeRegistrationId",
                keyValue: 81,
                columns: new[] { "EndTime", "StartTime" },
                values: new object[] { new DateTime(2024, 8, 21, 13, 52, 36, 0, DateTimeKind.Unspecified), new DateTime(2024, 11, 3, 9, 14, 1, 0, DateTimeKind.Unspecified) });

            migrationBuilder.UpdateData(
                table: "TimeRegistrations",
                keyColumn: "TimeRegistrationId",
                keyValue: 82,
                columns: new[] { "EndTime", "StartTime" },
                values: new object[] { new DateTime(2024, 11, 16, 22, 20, 4, 0, DateTimeKind.Unspecified), new DateTime(2024, 11, 17, 22, 44, 9, 0, DateTimeKind.Unspecified) });

            migrationBuilder.UpdateData(
                table: "TimeRegistrations",
                keyColumn: "TimeRegistrationId",
                keyValue: 83,
                columns: new[] { "EndTime", "StartTime" },
                values: new object[] { new DateTime(2024, 7, 2, 22, 3, 30, 0, DateTimeKind.Unspecified), new DateTime(2024, 10, 14, 17, 33, 33, 0, DateTimeKind.Unspecified) });

            migrationBuilder.UpdateData(
                table: "TimeRegistrations",
                keyColumn: "TimeRegistrationId",
                keyValue: 84,
                columns: new[] { "EndTime", "StartTime" },
                values: new object[] { new DateTime(2024, 7, 31, 15, 59, 34, 0, DateTimeKind.Unspecified), new DateTime(2024, 12, 24, 17, 12, 4, 0, DateTimeKind.Unspecified) });

            migrationBuilder.UpdateData(
                table: "TimeRegistrations",
                keyColumn: "TimeRegistrationId",
                keyValue: 85,
                columns: new[] { "EndTime", "StartTime" },
                values: new object[] { new DateTime(2024, 4, 28, 21, 33, 45, 0, DateTimeKind.Unspecified), new DateTime(2024, 3, 30, 8, 32, 14, 0, DateTimeKind.Unspecified) });

            migrationBuilder.UpdateData(
                table: "TimeRegistrations",
                keyColumn: "TimeRegistrationId",
                keyValue: 86,
                columns: new[] { "EndTime", "StartTime" },
                values: new object[] { new DateTime(2024, 3, 5, 17, 32, 18, 0, DateTimeKind.Unspecified), new DateTime(2024, 4, 28, 4, 5, 33, 0, DateTimeKind.Unspecified) });

            migrationBuilder.UpdateData(
                table: "TimeRegistrations",
                keyColumn: "TimeRegistrationId",
                keyValue: 87,
                columns: new[] { "EndTime", "StartTime" },
                values: new object[] { new DateTime(2024, 6, 22, 5, 12, 28, 0, DateTimeKind.Unspecified), new DateTime(2024, 2, 15, 0, 50, 3, 0, DateTimeKind.Unspecified) });

            migrationBuilder.UpdateData(
                table: "TimeRegistrations",
                keyColumn: "TimeRegistrationId",
                keyValue: 88,
                columns: new[] { "EndTime", "StartTime" },
                values: new object[] { new DateTime(2024, 10, 24, 15, 23, 16, 0, DateTimeKind.Unspecified), new DateTime(2024, 3, 28, 1, 5, 12, 0, DateTimeKind.Unspecified) });

            migrationBuilder.UpdateData(
                table: "TimeRegistrations",
                keyColumn: "TimeRegistrationId",
                keyValue: 89,
                columns: new[] { "EndTime", "StartTime" },
                values: new object[] { new DateTime(2024, 6, 8, 9, 52, 51, 0, DateTimeKind.Unspecified), new DateTime(2024, 8, 22, 22, 15, 57, 0, DateTimeKind.Unspecified) });

            migrationBuilder.UpdateData(
                table: "TimeRegistrations",
                keyColumn: "TimeRegistrationId",
                keyValue: 90,
                columns: new[] { "EndTime", "StartTime" },
                values: new object[] { new DateTime(2024, 1, 4, 0, 4, 12, 0, DateTimeKind.Unspecified), new DateTime(2024, 8, 19, 18, 1, 42, 0, DateTimeKind.Unspecified) });

            migrationBuilder.UpdateData(
                table: "TimeRegistrations",
                keyColumn: "TimeRegistrationId",
                keyValue: 91,
                columns: new[] { "EndTime", "StartTime" },
                values: new object[] { new DateTime(2024, 12, 30, 3, 56, 3, 0, DateTimeKind.Unspecified), new DateTime(2024, 3, 14, 13, 6, 11, 0, DateTimeKind.Unspecified) });

            migrationBuilder.UpdateData(
                table: "TimeRegistrations",
                keyColumn: "TimeRegistrationId",
                keyValue: 92,
                columns: new[] { "EndTime", "StartTime" },
                values: new object[] { new DateTime(2024, 1, 14, 1, 58, 0, 0, DateTimeKind.Unspecified), new DateTime(2024, 1, 3, 12, 17, 7, 0, DateTimeKind.Unspecified) });

            migrationBuilder.UpdateData(
                table: "TimeRegistrations",
                keyColumn: "TimeRegistrationId",
                keyValue: 93,
                columns: new[] { "EndTime", "StartTime" },
                values: new object[] { new DateTime(2024, 10, 27, 9, 54, 44, 0, DateTimeKind.Unspecified), new DateTime(2024, 10, 16, 23, 7, 39, 0, DateTimeKind.Unspecified) });

            migrationBuilder.UpdateData(
                table: "TimeRegistrations",
                keyColumn: "TimeRegistrationId",
                keyValue: 94,
                columns: new[] { "EndTime", "StartTime" },
                values: new object[] { new DateTime(2024, 7, 24, 1, 48, 25, 0, DateTimeKind.Unspecified), new DateTime(2024, 10, 5, 22, 3, 0, 0, DateTimeKind.Unspecified) });

            migrationBuilder.UpdateData(
                table: "TimeRegistrations",
                keyColumn: "TimeRegistrationId",
                keyValue: 95,
                columns: new[] { "EndTime", "StartTime" },
                values: new object[] { new DateTime(2024, 6, 17, 7, 10, 31, 0, DateTimeKind.Unspecified), new DateTime(2024, 9, 20, 20, 35, 38, 0, DateTimeKind.Unspecified) });

            migrationBuilder.UpdateData(
                table: "TimeRegistrations",
                keyColumn: "TimeRegistrationId",
                keyValue: 96,
                columns: new[] { "EndTime", "StartTime" },
                values: new object[] { new DateTime(2024, 9, 22, 7, 45, 41, 0, DateTimeKind.Unspecified), new DateTime(2024, 6, 30, 12, 30, 48, 0, DateTimeKind.Unspecified) });

            migrationBuilder.UpdateData(
                table: "TimeRegistrations",
                keyColumn: "TimeRegistrationId",
                keyValue: 97,
                columns: new[] { "EndTime", "StartTime" },
                values: new object[] { new DateTime(2024, 10, 10, 1, 12, 19, 0, DateTimeKind.Unspecified), new DateTime(2024, 4, 11, 10, 18, 41, 0, DateTimeKind.Unspecified) });

            migrationBuilder.UpdateData(
                table: "TimeRegistrations",
                keyColumn: "TimeRegistrationId",
                keyValue: 98,
                columns: new[] { "EndTime", "StartTime" },
                values: new object[] { new DateTime(2024, 3, 4, 4, 16, 11, 0, DateTimeKind.Unspecified), new DateTime(2024, 4, 9, 6, 48, 22, 0, DateTimeKind.Unspecified) });

            migrationBuilder.UpdateData(
                table: "TimeRegistrations",
                keyColumn: "TimeRegistrationId",
                keyValue: 99,
                columns: new[] { "EndTime", "StartTime" },
                values: new object[] { new DateTime(2024, 2, 2, 12, 6, 54, 0, DateTimeKind.Unspecified), new DateTime(2024, 2, 1, 3, 51, 50, 0, DateTimeKind.Unspecified) });

            migrationBuilder.UpdateData(
                table: "TimeRegistrations",
                keyColumn: "TimeRegistrationId",
                keyValue: 100,
                columns: new[] { "EndTime", "StartTime" },
                values: new object[] { new DateTime(2024, 6, 12, 22, 12, 44, 0, DateTimeKind.Unspecified), new DateTime(2024, 10, 5, 20, 56, 51, 0, DateTimeKind.Unspecified) });

            migrationBuilder.UpdateData(
                table: "TimeRegistrations",
                keyColumn: "TimeRegistrationId",
                keyValue: 101,
                columns: new[] { "EndTime", "StartTime" },
                values: new object[] { new DateTime(2024, 5, 2, 7, 41, 48, 0, DateTimeKind.Unspecified), new DateTime(2024, 5, 26, 13, 29, 31, 0, DateTimeKind.Unspecified) });

            migrationBuilder.UpdateData(
                table: "TimeRegistrations",
                keyColumn: "TimeRegistrationId",
                keyValue: 102,
                columns: new[] { "EndTime", "StartTime" },
                values: new object[] { new DateTime(2024, 12, 16, 7, 58, 12, 0, DateTimeKind.Unspecified), new DateTime(2024, 5, 12, 21, 28, 24, 0, DateTimeKind.Unspecified) });

            migrationBuilder.UpdateData(
                table: "TimeRegistrations",
                keyColumn: "TimeRegistrationId",
                keyValue: 103,
                columns: new[] { "EndTime", "StartTime" },
                values: new object[] { new DateTime(2024, 10, 25, 17, 12, 14, 0, DateTimeKind.Unspecified), new DateTime(2024, 12, 5, 18, 30, 4, 0, DateTimeKind.Unspecified) });

            migrationBuilder.UpdateData(
                table: "TimeRegistrations",
                keyColumn: "TimeRegistrationId",
                keyValue: 104,
                columns: new[] { "EndTime", "StartTime" },
                values: new object[] { new DateTime(2024, 8, 31, 20, 15, 2, 0, DateTimeKind.Unspecified), new DateTime(2024, 9, 2, 5, 11, 45, 0, DateTimeKind.Unspecified) });

            migrationBuilder.UpdateData(
                table: "TimeRegistrations",
                keyColumn: "TimeRegistrationId",
                keyValue: 105,
                columns: new[] { "EndTime", "StartTime" },
                values: new object[] { new DateTime(2024, 8, 8, 10, 47, 14, 0, DateTimeKind.Unspecified), new DateTime(2024, 1, 6, 23, 38, 30, 0, DateTimeKind.Unspecified) });

            migrationBuilder.UpdateData(
                table: "TimeRegistrations",
                keyColumn: "TimeRegistrationId",
                keyValue: 106,
                columns: new[] { "EndTime", "StartTime" },
                values: new object[] { new DateTime(2024, 2, 3, 10, 26, 32, 0, DateTimeKind.Unspecified), new DateTime(2024, 9, 14, 17, 58, 37, 0, DateTimeKind.Unspecified) });

            migrationBuilder.UpdateData(
                table: "TimeRegistrations",
                keyColumn: "TimeRegistrationId",
                keyValue: 107,
                columns: new[] { "EndTime", "StartTime" },
                values: new object[] { new DateTime(2024, 3, 26, 17, 44, 20, 0, DateTimeKind.Unspecified), new DateTime(2024, 1, 4, 22, 9, 47, 0, DateTimeKind.Unspecified) });

            migrationBuilder.UpdateData(
                table: "TimeRegistrations",
                keyColumn: "TimeRegistrationId",
                keyValue: 108,
                columns: new[] { "EndTime", "StartTime" },
                values: new object[] { new DateTime(2024, 8, 19, 12, 22, 10, 0, DateTimeKind.Unspecified), new DateTime(2024, 9, 14, 19, 58, 2, 0, DateTimeKind.Unspecified) });

            migrationBuilder.UpdateData(
                table: "TimeRegistrations",
                keyColumn: "TimeRegistrationId",
                keyValue: 109,
                columns: new[] { "EndTime", "StartTime" },
                values: new object[] { new DateTime(2024, 7, 2, 23, 21, 37, 0, DateTimeKind.Unspecified), new DateTime(2024, 12, 6, 11, 4, 5, 0, DateTimeKind.Unspecified) });

            migrationBuilder.UpdateData(
                table: "TimeRegistrations",
                keyColumn: "TimeRegistrationId",
                keyValue: 110,
                columns: new[] { "EndTime", "StartTime" },
                values: new object[] { new DateTime(2024, 4, 3, 18, 54, 1, 0, DateTimeKind.Unspecified), new DateTime(2024, 6, 18, 2, 55, 59, 0, DateTimeKind.Unspecified) });

            migrationBuilder.UpdateData(
                table: "TimeRegistrations",
                keyColumn: "TimeRegistrationId",
                keyValue: 111,
                columns: new[] { "EndTime", "StartTime" },
                values: new object[] { new DateTime(2024, 1, 19, 6, 4, 22, 0, DateTimeKind.Unspecified), new DateTime(2024, 2, 15, 11, 26, 47, 0, DateTimeKind.Unspecified) });

            migrationBuilder.UpdateData(
                table: "TimeRegistrations",
                keyColumn: "TimeRegistrationId",
                keyValue: 112,
                columns: new[] { "EndTime", "StartTime" },
                values: new object[] { new DateTime(2024, 3, 1, 16, 0, 5, 0, DateTimeKind.Unspecified), new DateTime(2024, 4, 27, 18, 3, 40, 0, DateTimeKind.Unspecified) });

            migrationBuilder.UpdateData(
                table: "TimeRegistrations",
                keyColumn: "TimeRegistrationId",
                keyValue: 113,
                columns: new[] { "EndTime", "StartTime" },
                values: new object[] { new DateTime(2024, 5, 30, 21, 46, 44, 0, DateTimeKind.Unspecified), new DateTime(2024, 5, 12, 7, 38, 49, 0, DateTimeKind.Unspecified) });

            migrationBuilder.UpdateData(
                table: "TimeRegistrations",
                keyColumn: "TimeRegistrationId",
                keyValue: 114,
                columns: new[] { "EndTime", "StartTime" },
                values: new object[] { new DateTime(2024, 12, 16, 11, 39, 0, 0, DateTimeKind.Unspecified), new DateTime(2024, 5, 25, 10, 0, 10, 0, DateTimeKind.Unspecified) });

            migrationBuilder.UpdateData(
                table: "TimeRegistrations",
                keyColumn: "TimeRegistrationId",
                keyValue: 115,
                columns: new[] { "EndTime", "StartTime" },
                values: new object[] { new DateTime(2024, 1, 24, 23, 24, 30, 0, DateTimeKind.Unspecified), new DateTime(2024, 8, 27, 18, 55, 4, 0, DateTimeKind.Unspecified) });

            migrationBuilder.UpdateData(
                table: "TimeRegistrations",
                keyColumn: "TimeRegistrationId",
                keyValue: 116,
                columns: new[] { "EndTime", "StartTime" },
                values: new object[] { new DateTime(2024, 3, 16, 11, 25, 18, 0, DateTimeKind.Unspecified), new DateTime(2024, 10, 9, 8, 30, 0, 0, DateTimeKind.Unspecified) });

            migrationBuilder.UpdateData(
                table: "TimeRegistrations",
                keyColumn: "TimeRegistrationId",
                keyValue: 117,
                columns: new[] { "EndTime", "StartTime" },
                values: new object[] { new DateTime(2024, 4, 8, 9, 16, 23, 0, DateTimeKind.Unspecified), new DateTime(2024, 10, 30, 4, 9, 15, 0, DateTimeKind.Unspecified) });

            migrationBuilder.UpdateData(
                table: "TimeRegistrations",
                keyColumn: "TimeRegistrationId",
                keyValue: 118,
                columns: new[] { "EndTime", "StartTime" },
                values: new object[] { new DateTime(2024, 2, 6, 19, 5, 33, 0, DateTimeKind.Unspecified), new DateTime(2024, 5, 20, 8, 46, 13, 0, DateTimeKind.Unspecified) });

            migrationBuilder.UpdateData(
                table: "TimeRegistrations",
                keyColumn: "TimeRegistrationId",
                keyValue: 119,
                columns: new[] { "EndTime", "StartTime" },
                values: new object[] { new DateTime(2024, 5, 7, 17, 52, 28, 0, DateTimeKind.Unspecified), new DateTime(2024, 1, 13, 2, 58, 0, 0, DateTimeKind.Unspecified) });

            migrationBuilder.UpdateData(
                table: "TimeRegistrations",
                keyColumn: "TimeRegistrationId",
                keyValue: 120,
                columns: new[] { "EndTime", "StartTime" },
                values: new object[] { new DateTime(2024, 11, 22, 7, 51, 52, 0, DateTimeKind.Unspecified), new DateTime(2024, 6, 23, 22, 7, 11, 0, DateTimeKind.Unspecified) });

            migrationBuilder.UpdateData(
                table: "TimeRegistrations",
                keyColumn: "TimeRegistrationId",
                keyValue: 121,
                columns: new[] { "EndTime", "StartTime" },
                values: new object[] { new DateTime(2024, 3, 3, 22, 32, 28, 0, DateTimeKind.Unspecified), new DateTime(2024, 6, 12, 21, 44, 25, 0, DateTimeKind.Unspecified) });

            migrationBuilder.UpdateData(
                table: "TimeRegistrations",
                keyColumn: "TimeRegistrationId",
                keyValue: 122,
                columns: new[] { "EndTime", "StartTime" },
                values: new object[] { new DateTime(2024, 10, 23, 3, 49, 54, 0, DateTimeKind.Unspecified), new DateTime(2024, 9, 27, 8, 58, 33, 0, DateTimeKind.Unspecified) });

            migrationBuilder.UpdateData(
                table: "TimeRegistrations",
                keyColumn: "TimeRegistrationId",
                keyValue: 123,
                columns: new[] { "EndTime", "StartTime" },
                values: new object[] { new DateTime(2024, 8, 30, 16, 54, 39, 0, DateTimeKind.Unspecified), new DateTime(2024, 4, 26, 20, 42, 59, 0, DateTimeKind.Unspecified) });

            migrationBuilder.UpdateData(
                table: "TimeRegistrations",
                keyColumn: "TimeRegistrationId",
                keyValue: 124,
                columns: new[] { "EndTime", "StartTime" },
                values: new object[] { new DateTime(2024, 7, 9, 5, 34, 38, 0, DateTimeKind.Unspecified), new DateTime(2024, 7, 19, 1, 39, 51, 0, DateTimeKind.Unspecified) });

            migrationBuilder.UpdateData(
                table: "TimeRegistrations",
                keyColumn: "TimeRegistrationId",
                keyValue: 125,
                columns: new[] { "EndTime", "StartTime" },
                values: new object[] { new DateTime(2024, 10, 2, 20, 24, 7, 0, DateTimeKind.Unspecified), new DateTime(2024, 11, 10, 13, 0, 35, 0, DateTimeKind.Unspecified) });

            migrationBuilder.UpdateData(
                table: "TimeRegistrations",
                keyColumn: "TimeRegistrationId",
                keyValue: 126,
                columns: new[] { "EndTime", "StartTime" },
                values: new object[] { new DateTime(2024, 7, 3, 19, 4, 37, 0, DateTimeKind.Unspecified), new DateTime(2024, 10, 23, 3, 6, 7, 0, DateTimeKind.Unspecified) });

            migrationBuilder.UpdateData(
                table: "TimeRegistrations",
                keyColumn: "TimeRegistrationId",
                keyValue: 127,
                columns: new[] { "EndTime", "StartTime" },
                values: new object[] { new DateTime(2024, 3, 31, 14, 12, 15, 0, DateTimeKind.Unspecified), new DateTime(2024, 11, 10, 20, 42, 8, 0, DateTimeKind.Unspecified) });

            migrationBuilder.UpdateData(
                table: "TimeRegistrations",
                keyColumn: "TimeRegistrationId",
                keyValue: 128,
                columns: new[] { "EndTime", "StartTime" },
                values: new object[] { new DateTime(2024, 7, 26, 11, 18, 32, 0, DateTimeKind.Unspecified), new DateTime(2024, 2, 15, 15, 30, 44, 0, DateTimeKind.Unspecified) });

            migrationBuilder.UpdateData(
                table: "TimeRegistrations",
                keyColumn: "TimeRegistrationId",
                keyValue: 129,
                columns: new[] { "EndTime", "StartTime" },
                values: new object[] { new DateTime(2024, 5, 5, 17, 18, 18, 0, DateTimeKind.Unspecified), new DateTime(2024, 1, 11, 2, 52, 14, 0, DateTimeKind.Unspecified) });

            migrationBuilder.UpdateData(
                table: "TimeRegistrations",
                keyColumn: "TimeRegistrationId",
                keyValue: 130,
                columns: new[] { "EndTime", "StartTime" },
                values: new object[] { new DateTime(2024, 4, 25, 19, 48, 11, 0, DateTimeKind.Unspecified), new DateTime(2024, 4, 16, 8, 13, 29, 0, DateTimeKind.Unspecified) });

            migrationBuilder.UpdateData(
                table: "TimeRegistrations",
                keyColumn: "TimeRegistrationId",
                keyValue: 131,
                columns: new[] { "EndTime", "StartTime" },
                values: new object[] { new DateTime(2024, 9, 6, 2, 2, 27, 0, DateTimeKind.Unspecified), new DateTime(2024, 12, 13, 5, 6, 33, 0, DateTimeKind.Unspecified) });

            migrationBuilder.UpdateData(
                table: "TimeRegistrations",
                keyColumn: "TimeRegistrationId",
                keyValue: 132,
                columns: new[] { "EndTime", "StartTime" },
                values: new object[] { new DateTime(2024, 5, 18, 7, 11, 54, 0, DateTimeKind.Unspecified), new DateTime(2024, 7, 22, 18, 11, 46, 0, DateTimeKind.Unspecified) });

            migrationBuilder.UpdateData(
                table: "TimeRegistrations",
                keyColumn: "TimeRegistrationId",
                keyValue: 133,
                columns: new[] { "EndTime", "StartTime" },
                values: new object[] { new DateTime(2024, 8, 15, 1, 33, 47, 0, DateTimeKind.Unspecified), new DateTime(2024, 8, 12, 7, 5, 52, 0, DateTimeKind.Unspecified) });

            migrationBuilder.UpdateData(
                table: "TimeRegistrations",
                keyColumn: "TimeRegistrationId",
                keyValue: 134,
                columns: new[] { "EndTime", "StartTime" },
                values: new object[] { new DateTime(2024, 10, 20, 11, 32, 28, 0, DateTimeKind.Unspecified), new DateTime(2024, 5, 3, 5, 46, 6, 0, DateTimeKind.Unspecified) });

            migrationBuilder.UpdateData(
                table: "TimeRegistrations",
                keyColumn: "TimeRegistrationId",
                keyValue: 135,
                columns: new[] { "EndTime", "StartTime" },
                values: new object[] { new DateTime(2024, 10, 13, 14, 27, 33, 0, DateTimeKind.Unspecified), new DateTime(2024, 7, 9, 12, 31, 47, 0, DateTimeKind.Unspecified) });

            migrationBuilder.UpdateData(
                table: "TimeRegistrations",
                keyColumn: "TimeRegistrationId",
                keyValue: 136,
                columns: new[] { "EndTime", "StartTime" },
                values: new object[] { new DateTime(2024, 1, 4, 14, 7, 23, 0, DateTimeKind.Unspecified), new DateTime(2024, 1, 27, 18, 31, 25, 0, DateTimeKind.Unspecified) });

            migrationBuilder.UpdateData(
                table: "TimeRegistrations",
                keyColumn: "TimeRegistrationId",
                keyValue: 137,
                columns: new[] { "EndTime", "StartTime" },
                values: new object[] { new DateTime(2024, 10, 23, 1, 56, 28, 0, DateTimeKind.Unspecified), new DateTime(2024, 3, 23, 11, 43, 44, 0, DateTimeKind.Unspecified) });

            migrationBuilder.UpdateData(
                table: "TimeRegistrations",
                keyColumn: "TimeRegistrationId",
                keyValue: 138,
                columns: new[] { "EndTime", "StartTime" },
                values: new object[] { new DateTime(2024, 10, 17, 14, 21, 23, 0, DateTimeKind.Unspecified), new DateTime(2024, 10, 13, 19, 15, 39, 0, DateTimeKind.Unspecified) });

            migrationBuilder.UpdateData(
                table: "TimeRegistrations",
                keyColumn: "TimeRegistrationId",
                keyValue: 139,
                columns: new[] { "EndTime", "StartTime" },
                values: new object[] { new DateTime(2024, 11, 28, 13, 54, 53, 0, DateTimeKind.Unspecified), new DateTime(2024, 8, 12, 1, 46, 20, 0, DateTimeKind.Unspecified) });

            migrationBuilder.UpdateData(
                table: "TimeRegistrations",
                keyColumn: "TimeRegistrationId",
                keyValue: 140,
                columns: new[] { "EndTime", "StartTime" },
                values: new object[] { new DateTime(2024, 9, 4, 22, 21, 26, 0, DateTimeKind.Unspecified), new DateTime(2024, 4, 17, 10, 32, 33, 0, DateTimeKind.Unspecified) });

            migrationBuilder.UpdateData(
                table: "TimeRegistrations",
                keyColumn: "TimeRegistrationId",
                keyValue: 141,
                columns: new[] { "EndTime", "StartTime" },
                values: new object[] { new DateTime(2024, 12, 20, 0, 30, 27, 0, DateTimeKind.Unspecified), new DateTime(2024, 6, 2, 20, 15, 15, 0, DateTimeKind.Unspecified) });

            migrationBuilder.UpdateData(
                table: "TimeRegistrations",
                keyColumn: "TimeRegistrationId",
                keyValue: 142,
                columns: new[] { "EndTime", "StartTime" },
                values: new object[] { new DateTime(2024, 2, 5, 10, 44, 58, 0, DateTimeKind.Unspecified), new DateTime(2024, 8, 11, 12, 25, 18, 0, DateTimeKind.Unspecified) });

            migrationBuilder.UpdateData(
                table: "TimeRegistrations",
                keyColumn: "TimeRegistrationId",
                keyValue: 143,
                columns: new[] { "EndTime", "StartTime" },
                values: new object[] { new DateTime(2024, 11, 19, 9, 8, 24, 0, DateTimeKind.Unspecified), new DateTime(2024, 7, 26, 15, 55, 34, 0, DateTimeKind.Unspecified) });

            migrationBuilder.UpdateData(
                table: "TimeRegistrations",
                keyColumn: "TimeRegistrationId",
                keyValue: 144,
                columns: new[] { "EndTime", "StartTime" },
                values: new object[] { new DateTime(2024, 3, 7, 9, 7, 45, 0, DateTimeKind.Unspecified), new DateTime(2024, 6, 26, 16, 43, 36, 0, DateTimeKind.Unspecified) });

            migrationBuilder.UpdateData(
                table: "TimeRegistrations",
                keyColumn: "TimeRegistrationId",
                keyValue: 145,
                columns: new[] { "EndTime", "StartTime" },
                values: new object[] { new DateTime(2024, 10, 27, 1, 14, 51, 0, DateTimeKind.Unspecified), new DateTime(2024, 9, 1, 10, 44, 42, 0, DateTimeKind.Unspecified) });

            migrationBuilder.UpdateData(
                table: "TimeRegistrations",
                keyColumn: "TimeRegistrationId",
                keyValue: 146,
                columns: new[] { "EndTime", "StartTime" },
                values: new object[] { new DateTime(2024, 11, 18, 6, 15, 23, 0, DateTimeKind.Unspecified), new DateTime(2024, 8, 12, 16, 36, 31, 0, DateTimeKind.Unspecified) });

            migrationBuilder.UpdateData(
                table: "TimeRegistrations",
                keyColumn: "TimeRegistrationId",
                keyValue: 147,
                columns: new[] { "EndTime", "StartTime" },
                values: new object[] { new DateTime(2024, 2, 7, 20, 21, 42, 0, DateTimeKind.Unspecified), new DateTime(2024, 2, 21, 14, 23, 43, 0, DateTimeKind.Unspecified) });

            migrationBuilder.UpdateData(
                table: "TimeRegistrations",
                keyColumn: "TimeRegistrationId",
                keyValue: 148,
                columns: new[] { "EndTime", "StartTime" },
                values: new object[] { new DateTime(2024, 9, 13, 13, 55, 8, 0, DateTimeKind.Unspecified), new DateTime(2024, 4, 13, 1, 7, 48, 0, DateTimeKind.Unspecified) });

            migrationBuilder.UpdateData(
                table: "TimeRegistrations",
                keyColumn: "TimeRegistrationId",
                keyValue: 149,
                columns: new[] { "EndTime", "StartTime" },
                values: new object[] { new DateTime(2024, 9, 15, 1, 16, 42, 0, DateTimeKind.Unspecified), new DateTime(2024, 2, 25, 22, 29, 54, 0, DateTimeKind.Unspecified) });

            migrationBuilder.UpdateData(
                table: "TimeRegistrations",
                keyColumn: "TimeRegistrationId",
                keyValue: 150,
                columns: new[] { "EndTime", "StartTime" },
                values: new object[] { new DateTime(2024, 7, 13, 22, 43, 51, 0, DateTimeKind.Unspecified), new DateTime(2024, 4, 18, 19, 57, 52, 0, DateTimeKind.Unspecified) });

            migrationBuilder.UpdateData(
                table: "TimeRegistrations",
                keyColumn: "TimeRegistrationId",
                keyValue: 151,
                columns: new[] { "EndTime", "StartTime" },
                values: new object[] { new DateTime(2024, 8, 7, 6, 13, 19, 0, DateTimeKind.Unspecified), new DateTime(2024, 5, 20, 12, 39, 20, 0, DateTimeKind.Unspecified) });

            migrationBuilder.UpdateData(
                table: "TimeRegistrations",
                keyColumn: "TimeRegistrationId",
                keyValue: 152,
                columns: new[] { "EndTime", "StartTime" },
                values: new object[] { new DateTime(2024, 12, 11, 9, 37, 48, 0, DateTimeKind.Unspecified), new DateTime(2024, 4, 2, 23, 27, 37, 0, DateTimeKind.Unspecified) });

            migrationBuilder.UpdateData(
                table: "TimeRegistrations",
                keyColumn: "TimeRegistrationId",
                keyValue: 153,
                columns: new[] { "EndTime", "StartTime" },
                values: new object[] { new DateTime(2024, 4, 29, 1, 8, 42, 0, DateTimeKind.Unspecified), new DateTime(2024, 5, 28, 6, 50, 0, 0, DateTimeKind.Unspecified) });

            migrationBuilder.UpdateData(
                table: "TimeRegistrations",
                keyColumn: "TimeRegistrationId",
                keyValue: 154,
                columns: new[] { "EndTime", "StartTime" },
                values: new object[] { new DateTime(2024, 10, 12, 1, 22, 43, 0, DateTimeKind.Unspecified), new DateTime(2024, 4, 9, 5, 40, 31, 0, DateTimeKind.Unspecified) });

            migrationBuilder.UpdateData(
                table: "TimeRegistrations",
                keyColumn: "TimeRegistrationId",
                keyValue: 155,
                columns: new[] { "EndTime", "StartTime" },
                values: new object[] { new DateTime(2024, 10, 16, 12, 55, 37, 0, DateTimeKind.Unspecified), new DateTime(2024, 9, 25, 0, 28, 16, 0, DateTimeKind.Unspecified) });

            migrationBuilder.UpdateData(
                table: "TimeRegistrations",
                keyColumn: "TimeRegistrationId",
                keyValue: 156,
                columns: new[] { "EndTime", "StartTime" },
                values: new object[] { new DateTime(2024, 8, 8, 17, 59, 2, 0, DateTimeKind.Unspecified), new DateTime(2024, 2, 11, 10, 5, 1, 0, DateTimeKind.Unspecified) });

            migrationBuilder.UpdateData(
                table: "TimeRegistrations",
                keyColumn: "TimeRegistrationId",
                keyValue: 157,
                columns: new[] { "EndTime", "StartTime" },
                values: new object[] { new DateTime(2024, 6, 11, 20, 19, 58, 0, DateTimeKind.Unspecified), new DateTime(2024, 9, 16, 17, 6, 42, 0, DateTimeKind.Unspecified) });

            migrationBuilder.UpdateData(
                table: "TimeRegistrations",
                keyColumn: "TimeRegistrationId",
                keyValue: 158,
                columns: new[] { "EndTime", "StartTime" },
                values: new object[] { new DateTime(2024, 7, 15, 3, 58, 9, 0, DateTimeKind.Unspecified), new DateTime(2024, 11, 25, 18, 34, 0, 0, DateTimeKind.Unspecified) });

            migrationBuilder.UpdateData(
                table: "TimeRegistrations",
                keyColumn: "TimeRegistrationId",
                keyValue: 159,
                columns: new[] { "EndTime", "StartTime" },
                values: new object[] { new DateTime(2024, 6, 28, 7, 45, 24, 0, DateTimeKind.Unspecified), new DateTime(2024, 4, 9, 2, 48, 28, 0, DateTimeKind.Unspecified) });

            migrationBuilder.UpdateData(
                table: "TimeRegistrations",
                keyColumn: "TimeRegistrationId",
                keyValue: 160,
                columns: new[] { "EndTime", "StartTime" },
                values: new object[] { new DateTime(2024, 3, 20, 7, 16, 34, 0, DateTimeKind.Unspecified), new DateTime(2024, 1, 12, 8, 23, 16, 0, DateTimeKind.Unspecified) });

            migrationBuilder.UpdateData(
                table: "TimeRegistrations",
                keyColumn: "TimeRegistrationId",
                keyValue: 161,
                columns: new[] { "EndTime", "StartTime" },
                values: new object[] { new DateTime(2024, 5, 16, 0, 59, 42, 0, DateTimeKind.Unspecified), new DateTime(2024, 1, 19, 23, 51, 43, 0, DateTimeKind.Unspecified) });

            migrationBuilder.UpdateData(
                table: "TimeRegistrations",
                keyColumn: "TimeRegistrationId",
                keyValue: 162,
                columns: new[] { "EndTime", "StartTime" },
                values: new object[] { new DateTime(2024, 11, 15, 12, 19, 12, 0, DateTimeKind.Unspecified), new DateTime(2024, 7, 9, 9, 3, 24, 0, DateTimeKind.Unspecified) });

            migrationBuilder.UpdateData(
                table: "TimeRegistrations",
                keyColumn: "TimeRegistrationId",
                keyValue: 163,
                columns: new[] { "EndTime", "StartTime" },
                values: new object[] { new DateTime(2024, 9, 12, 3, 43, 36, 0, DateTimeKind.Unspecified), new DateTime(2024, 11, 27, 15, 20, 28, 0, DateTimeKind.Unspecified) });

            migrationBuilder.UpdateData(
                table: "TimeRegistrations",
                keyColumn: "TimeRegistrationId",
                keyValue: 164,
                columns: new[] { "EndTime", "StartTime" },
                values: new object[] { new DateTime(2024, 3, 18, 8, 33, 27, 0, DateTimeKind.Unspecified), new DateTime(2024, 4, 13, 22, 51, 41, 0, DateTimeKind.Unspecified) });

            migrationBuilder.UpdateData(
                table: "TimeRegistrations",
                keyColumn: "TimeRegistrationId",
                keyValue: 165,
                columns: new[] { "EndTime", "StartTime" },
                values: new object[] { new DateTime(2024, 1, 14, 11, 53, 26, 0, DateTimeKind.Unspecified), new DateTime(2024, 4, 8, 13, 9, 18, 0, DateTimeKind.Unspecified) });

            migrationBuilder.UpdateData(
                table: "TimeRegistrations",
                keyColumn: "TimeRegistrationId",
                keyValue: 166,
                columns: new[] { "EndTime", "StartTime" },
                values: new object[] { new DateTime(2024, 7, 9, 14, 17, 26, 0, DateTimeKind.Unspecified), new DateTime(2024, 4, 8, 15, 41, 1, 0, DateTimeKind.Unspecified) });

            migrationBuilder.UpdateData(
                table: "TimeRegistrations",
                keyColumn: "TimeRegistrationId",
                keyValue: 167,
                columns: new[] { "EndTime", "StartTime" },
                values: new object[] { new DateTime(2024, 8, 19, 16, 38, 46, 0, DateTimeKind.Unspecified), new DateTime(2024, 1, 11, 15, 53, 41, 0, DateTimeKind.Unspecified) });

            migrationBuilder.UpdateData(
                table: "TimeRegistrations",
                keyColumn: "TimeRegistrationId",
                keyValue: 168,
                columns: new[] { "EndTime", "StartTime" },
                values: new object[] { new DateTime(2024, 9, 7, 6, 59, 17, 0, DateTimeKind.Unspecified), new DateTime(2024, 9, 15, 0, 1, 0, 0, DateTimeKind.Unspecified) });

            migrationBuilder.UpdateData(
                table: "TimeRegistrations",
                keyColumn: "TimeRegistrationId",
                keyValue: 169,
                columns: new[] { "EndTime", "StartTime" },
                values: new object[] { new DateTime(2024, 12, 4, 12, 45, 17, 0, DateTimeKind.Unspecified), new DateTime(2024, 1, 24, 21, 42, 35, 0, DateTimeKind.Unspecified) });

            migrationBuilder.UpdateData(
                table: "TimeRegistrations",
                keyColumn: "TimeRegistrationId",
                keyValue: 170,
                columns: new[] { "EndTime", "StartTime" },
                values: new object[] { new DateTime(2024, 5, 14, 22, 57, 58, 0, DateTimeKind.Unspecified), new DateTime(2024, 4, 9, 14, 36, 33, 0, DateTimeKind.Unspecified) });

            migrationBuilder.UpdateData(
                table: "TimeRegistrations",
                keyColumn: "TimeRegistrationId",
                keyValue: 171,
                columns: new[] { "EndTime", "StartTime" },
                values: new object[] { new DateTime(2024, 5, 13, 7, 58, 58, 0, DateTimeKind.Unspecified), new DateTime(2024, 10, 19, 1, 35, 20, 0, DateTimeKind.Unspecified) });

            migrationBuilder.UpdateData(
                table: "TimeRegistrations",
                keyColumn: "TimeRegistrationId",
                keyValue: 172,
                columns: new[] { "EndTime", "StartTime" },
                values: new object[] { new DateTime(2024, 11, 10, 21, 13, 15, 0, DateTimeKind.Unspecified), new DateTime(2024, 6, 25, 12, 15, 21, 0, DateTimeKind.Unspecified) });

            migrationBuilder.UpdateData(
                table: "TimeRegistrations",
                keyColumn: "TimeRegistrationId",
                keyValue: 173,
                columns: new[] { "EndTime", "StartTime" },
                values: new object[] { new DateTime(2024, 1, 31, 7, 52, 0, 0, DateTimeKind.Unspecified), new DateTime(2024, 7, 19, 2, 52, 4, 0, DateTimeKind.Unspecified) });

            migrationBuilder.UpdateData(
                table: "TimeRegistrations",
                keyColumn: "TimeRegistrationId",
                keyValue: 174,
                columns: new[] { "EndTime", "StartTime" },
                values: new object[] { new DateTime(2024, 7, 12, 7, 58, 34, 0, DateTimeKind.Unspecified), new DateTime(2024, 2, 26, 19, 26, 55, 0, DateTimeKind.Unspecified) });

            migrationBuilder.UpdateData(
                table: "TimeRegistrations",
                keyColumn: "TimeRegistrationId",
                keyValue: 175,
                columns: new[] { "EndTime", "StartTime" },
                values: new object[] { new DateTime(2024, 7, 19, 1, 5, 27, 0, DateTimeKind.Unspecified), new DateTime(2024, 11, 27, 9, 24, 3, 0, DateTimeKind.Unspecified) });

            migrationBuilder.UpdateData(
                table: "TimeRegistrations",
                keyColumn: "TimeRegistrationId",
                keyValue: 176,
                columns: new[] { "EndTime", "StartTime" },
                values: new object[] { new DateTime(2024, 5, 17, 13, 23, 52, 0, DateTimeKind.Unspecified), new DateTime(2024, 10, 5, 5, 39, 15, 0, DateTimeKind.Unspecified) });

            migrationBuilder.UpdateData(
                table: "TimeRegistrations",
                keyColumn: "TimeRegistrationId",
                keyValue: 177,
                columns: new[] { "EndTime", "StartTime" },
                values: new object[] { new DateTime(2024, 11, 28, 23, 55, 21, 0, DateTimeKind.Unspecified), new DateTime(2024, 7, 12, 22, 7, 54, 0, DateTimeKind.Unspecified) });

            migrationBuilder.UpdateData(
                table: "TimeRegistrations",
                keyColumn: "TimeRegistrationId",
                keyValue: 178,
                columns: new[] { "EndTime", "StartTime" },
                values: new object[] { new DateTime(2024, 6, 5, 21, 33, 41, 0, DateTimeKind.Unspecified), new DateTime(2024, 11, 17, 9, 12, 34, 0, DateTimeKind.Unspecified) });

            migrationBuilder.UpdateData(
                table: "TimeRegistrations",
                keyColumn: "TimeRegistrationId",
                keyValue: 179,
                columns: new[] { "EndTime", "StartTime" },
                values: new object[] { new DateTime(2024, 1, 18, 2, 58, 43, 0, DateTimeKind.Unspecified), new DateTime(2024, 6, 22, 11, 44, 1, 0, DateTimeKind.Unspecified) });

            migrationBuilder.UpdateData(
                table: "TimeRegistrations",
                keyColumn: "TimeRegistrationId",
                keyValue: 180,
                columns: new[] { "EndTime", "StartTime" },
                values: new object[] { new DateTime(2024, 12, 3, 16, 56, 19, 0, DateTimeKind.Unspecified), new DateTime(2024, 10, 13, 12, 57, 20, 0, DateTimeKind.Unspecified) });

            migrationBuilder.UpdateData(
                table: "TimeRegistrations",
                keyColumn: "TimeRegistrationId",
                keyValue: 181,
                columns: new[] { "EndTime", "StartTime" },
                values: new object[] { new DateTime(2024, 10, 11, 6, 14, 57, 0, DateTimeKind.Unspecified), new DateTime(2024, 12, 25, 10, 7, 23, 0, DateTimeKind.Unspecified) });

            migrationBuilder.UpdateData(
                table: "TimeRegistrations",
                keyColumn: "TimeRegistrationId",
                keyValue: 182,
                columns: new[] { "EndTime", "StartTime" },
                values: new object[] { new DateTime(2024, 7, 19, 7, 27, 18, 0, DateTimeKind.Unspecified), new DateTime(2024, 1, 2, 18, 26, 29, 0, DateTimeKind.Unspecified) });

            migrationBuilder.UpdateData(
                table: "TimeRegistrations",
                keyColumn: "TimeRegistrationId",
                keyValue: 183,
                columns: new[] { "EndTime", "StartTime" },
                values: new object[] { new DateTime(2024, 5, 12, 16, 40, 38, 0, DateTimeKind.Unspecified), new DateTime(2024, 8, 2, 8, 55, 32, 0, DateTimeKind.Unspecified) });

            migrationBuilder.UpdateData(
                table: "TimeRegistrations",
                keyColumn: "TimeRegistrationId",
                keyValue: 184,
                columns: new[] { "EndTime", "StartTime" },
                values: new object[] { new DateTime(2024, 5, 19, 22, 45, 19, 0, DateTimeKind.Unspecified), new DateTime(2024, 11, 12, 16, 24, 50, 0, DateTimeKind.Unspecified) });

            migrationBuilder.UpdateData(
                table: "TimeRegistrations",
                keyColumn: "TimeRegistrationId",
                keyValue: 185,
                columns: new[] { "EndTime", "StartTime" },
                values: new object[] { new DateTime(2024, 10, 2, 22, 19, 41, 0, DateTimeKind.Unspecified), new DateTime(2024, 7, 30, 6, 51, 5, 0, DateTimeKind.Unspecified) });

            migrationBuilder.UpdateData(
                table: "TimeRegistrations",
                keyColumn: "TimeRegistrationId",
                keyValue: 186,
                columns: new[] { "EndTime", "StartTime" },
                values: new object[] { new DateTime(2024, 11, 9, 6, 44, 48, 0, DateTimeKind.Unspecified), new DateTime(2024, 12, 7, 14, 29, 52, 0, DateTimeKind.Unspecified) });

            migrationBuilder.UpdateData(
                table: "TimeRegistrations",
                keyColumn: "TimeRegistrationId",
                keyValue: 187,
                columns: new[] { "EndTime", "StartTime" },
                values: new object[] { new DateTime(2024, 6, 10, 7, 46, 17, 0, DateTimeKind.Unspecified), new DateTime(2024, 5, 17, 0, 29, 4, 0, DateTimeKind.Unspecified) });

            migrationBuilder.UpdateData(
                table: "TimeRegistrations",
                keyColumn: "TimeRegistrationId",
                keyValue: 188,
                columns: new[] { "EndTime", "StartTime" },
                values: new object[] { new DateTime(2024, 2, 5, 18, 11, 17, 0, DateTimeKind.Unspecified), new DateTime(2024, 3, 12, 10, 8, 10, 0, DateTimeKind.Unspecified) });

            migrationBuilder.UpdateData(
                table: "TimeRegistrations",
                keyColumn: "TimeRegistrationId",
                keyValue: 189,
                columns: new[] { "EndTime", "StartTime" },
                values: new object[] { new DateTime(2024, 2, 10, 3, 44, 1, 0, DateTimeKind.Unspecified), new DateTime(2024, 5, 26, 14, 24, 32, 0, DateTimeKind.Unspecified) });

            migrationBuilder.UpdateData(
                table: "TimeRegistrations",
                keyColumn: "TimeRegistrationId",
                keyValue: 190,
                columns: new[] { "EndTime", "StartTime" },
                values: new object[] { new DateTime(2024, 8, 14, 14, 22, 24, 0, DateTimeKind.Unspecified), new DateTime(2024, 2, 2, 4, 41, 1, 0, DateTimeKind.Unspecified) });

            migrationBuilder.UpdateData(
                table: "TimeRegistrations",
                keyColumn: "TimeRegistrationId",
                keyValue: 191,
                columns: new[] { "EndTime", "StartTime" },
                values: new object[] { new DateTime(2024, 7, 20, 23, 26, 7, 0, DateTimeKind.Unspecified), new DateTime(2024, 4, 8, 10, 55, 49, 0, DateTimeKind.Unspecified) });

            migrationBuilder.UpdateData(
                table: "TimeRegistrations",
                keyColumn: "TimeRegistrationId",
                keyValue: 192,
                columns: new[] { "EndTime", "StartTime" },
                values: new object[] { new DateTime(2024, 11, 27, 8, 5, 19, 0, DateTimeKind.Unspecified), new DateTime(2024, 3, 9, 23, 35, 38, 0, DateTimeKind.Unspecified) });

            migrationBuilder.UpdateData(
                table: "TimeRegistrations",
                keyColumn: "TimeRegistrationId",
                keyValue: 193,
                columns: new[] { "EndTime", "StartTime" },
                values: new object[] { new DateTime(2024, 12, 18, 4, 57, 8, 0, DateTimeKind.Unspecified), new DateTime(2024, 11, 1, 1, 12, 58, 0, DateTimeKind.Unspecified) });

            migrationBuilder.UpdateData(
                table: "TimeRegistrations",
                keyColumn: "TimeRegistrationId",
                keyValue: 194,
                columns: new[] { "EndTime", "StartTime" },
                values: new object[] { new DateTime(2024, 1, 23, 8, 37, 17, 0, DateTimeKind.Unspecified), new DateTime(2024, 5, 15, 15, 52, 31, 0, DateTimeKind.Unspecified) });

            migrationBuilder.UpdateData(
                table: "TimeRegistrations",
                keyColumn: "TimeRegistrationId",
                keyValue: 195,
                columns: new[] { "EndTime", "StartTime" },
                values: new object[] { new DateTime(2024, 5, 7, 17, 56, 52, 0, DateTimeKind.Unspecified), new DateTime(2024, 2, 14, 0, 40, 22, 0, DateTimeKind.Unspecified) });

            migrationBuilder.UpdateData(
                table: "TimeRegistrations",
                keyColumn: "TimeRegistrationId",
                keyValue: 196,
                columns: new[] { "EndTime", "StartTime" },
                values: new object[] { new DateTime(2024, 1, 26, 15, 59, 43, 0, DateTimeKind.Unspecified), new DateTime(2024, 11, 26, 6, 52, 57, 0, DateTimeKind.Unspecified) });

            migrationBuilder.UpdateData(
                table: "TimeRegistrations",
                keyColumn: "TimeRegistrationId",
                keyValue: 197,
                columns: new[] { "EndTime", "StartTime" },
                values: new object[] { new DateTime(2024, 10, 13, 19, 12, 15, 0, DateTimeKind.Unspecified), new DateTime(2024, 12, 19, 18, 3, 21, 0, DateTimeKind.Unspecified) });

            migrationBuilder.UpdateData(
                table: "TimeRegistrations",
                keyColumn: "TimeRegistrationId",
                keyValue: 198,
                columns: new[] { "EndTime", "StartTime" },
                values: new object[] { new DateTime(2024, 12, 14, 0, 50, 23, 0, DateTimeKind.Unspecified), new DateTime(2024, 4, 3, 16, 5, 57, 0, DateTimeKind.Unspecified) });

            migrationBuilder.UpdateData(
                table: "TimeRegistrations",
                keyColumn: "TimeRegistrationId",
                keyValue: 199,
                columns: new[] { "EndTime", "StartTime" },
                values: new object[] { new DateTime(2024, 3, 1, 21, 19, 58, 0, DateTimeKind.Unspecified), new DateTime(2024, 8, 3, 22, 53, 51, 0, DateTimeKind.Unspecified) });

            migrationBuilder.UpdateData(
                table: "TimeRegistrations",
                keyColumn: "TimeRegistrationId",
                keyValue: 200,
                columns: new[] { "EndTime", "StartTime" },
                values: new object[] { new DateTime(2024, 4, 12, 5, 24, 26, 0, DateTimeKind.Unspecified), new DateTime(2024, 7, 13, 17, 27, 42, 0, DateTimeKind.Unspecified) });

            migrationBuilder.UpdateData(
                table: "TimeRegistrations",
                keyColumn: "TimeRegistrationId",
                keyValue: 201,
                columns: new[] { "EndTime", "StartTime" },
                values: new object[] { new DateTime(2024, 9, 1, 8, 53, 59, 0, DateTimeKind.Unspecified), new DateTime(2024, 6, 16, 23, 20, 21, 0, DateTimeKind.Unspecified) });

            migrationBuilder.UpdateData(
                table: "TimeRegistrations",
                keyColumn: "TimeRegistrationId",
                keyValue: 202,
                columns: new[] { "EndTime", "StartTime" },
                values: new object[] { new DateTime(2024, 7, 21, 3, 32, 21, 0, DateTimeKind.Unspecified), new DateTime(2024, 11, 21, 13, 35, 17, 0, DateTimeKind.Unspecified) });

            migrationBuilder.UpdateData(
                table: "TimeRegistrations",
                keyColumn: "TimeRegistrationId",
                keyValue: 203,
                columns: new[] { "EndTime", "StartTime" },
                values: new object[] { new DateTime(2024, 11, 27, 11, 1, 52, 0, DateTimeKind.Unspecified), new DateTime(2024, 4, 25, 5, 21, 54, 0, DateTimeKind.Unspecified) });

            migrationBuilder.UpdateData(
                table: "TimeRegistrations",
                keyColumn: "TimeRegistrationId",
                keyValue: 204,
                columns: new[] { "EndTime", "StartTime" },
                values: new object[] { new DateTime(2024, 10, 21, 2, 55, 53, 0, DateTimeKind.Unspecified), new DateTime(2024, 1, 23, 1, 29, 0, 0, DateTimeKind.Unspecified) });

            migrationBuilder.UpdateData(
                table: "TimeRegistrations",
                keyColumn: "TimeRegistrationId",
                keyValue: 205,
                columns: new[] { "EndTime", "StartTime" },
                values: new object[] { new DateTime(2024, 11, 22, 3, 11, 32, 0, DateTimeKind.Unspecified), new DateTime(2024, 2, 3, 19, 49, 4, 0, DateTimeKind.Unspecified) });

            migrationBuilder.UpdateData(
                table: "TimeRegistrations",
                keyColumn: "TimeRegistrationId",
                keyValue: 206,
                columns: new[] { "EndTime", "StartTime" },
                values: new object[] { new DateTime(2024, 8, 8, 18, 52, 8, 0, DateTimeKind.Unspecified), new DateTime(2024, 8, 15, 20, 50, 46, 0, DateTimeKind.Unspecified) });

            migrationBuilder.UpdateData(
                table: "TimeRegistrations",
                keyColumn: "TimeRegistrationId",
                keyValue: 207,
                columns: new[] { "EndTime", "StartTime" },
                values: new object[] { new DateTime(2024, 5, 22, 8, 7, 59, 0, DateTimeKind.Unspecified), new DateTime(2024, 6, 13, 6, 57, 14, 0, DateTimeKind.Unspecified) });

            migrationBuilder.UpdateData(
                table: "TimeRegistrations",
                keyColumn: "TimeRegistrationId",
                keyValue: 208,
                columns: new[] { "EndTime", "StartTime" },
                values: new object[] { new DateTime(2024, 12, 18, 11, 53, 54, 0, DateTimeKind.Unspecified), new DateTime(2024, 3, 23, 2, 46, 12, 0, DateTimeKind.Unspecified) });

            migrationBuilder.UpdateData(
                table: "TimeRegistrations",
                keyColumn: "TimeRegistrationId",
                keyValue: 209,
                columns: new[] { "EndTime", "StartTime" },
                values: new object[] { new DateTime(2024, 4, 16, 11, 1, 31, 0, DateTimeKind.Unspecified), new DateTime(2024, 3, 2, 17, 12, 11, 0, DateTimeKind.Unspecified) });

            migrationBuilder.UpdateData(
                table: "TimeRegistrations",
                keyColumn: "TimeRegistrationId",
                keyValue: 210,
                columns: new[] { "EndTime", "StartTime" },
                values: new object[] { new DateTime(2024, 9, 13, 3, 18, 21, 0, DateTimeKind.Unspecified), new DateTime(2024, 3, 15, 0, 13, 26, 0, DateTimeKind.Unspecified) });

            migrationBuilder.UpdateData(
                table: "TimeRegistrations",
                keyColumn: "TimeRegistrationId",
                keyValue: 211,
                columns: new[] { "EndTime", "StartTime" },
                values: new object[] { new DateTime(2024, 12, 4, 4, 47, 7, 0, DateTimeKind.Unspecified), new DateTime(2024, 1, 24, 8, 10, 22, 0, DateTimeKind.Unspecified) });

            migrationBuilder.UpdateData(
                table: "TimeRegistrations",
                keyColumn: "TimeRegistrationId",
                keyValue: 212,
                columns: new[] { "EndTime", "StartTime" },
                values: new object[] { new DateTime(2024, 10, 10, 19, 15, 10, 0, DateTimeKind.Unspecified), new DateTime(2024, 10, 15, 16, 40, 24, 0, DateTimeKind.Unspecified) });

            migrationBuilder.UpdateData(
                table: "TimeRegistrations",
                keyColumn: "TimeRegistrationId",
                keyValue: 213,
                columns: new[] { "EndTime", "StartTime" },
                values: new object[] { new DateTime(2024, 10, 29, 13, 56, 14, 0, DateTimeKind.Unspecified), new DateTime(2024, 10, 7, 18, 8, 46, 0, DateTimeKind.Unspecified) });

            migrationBuilder.UpdateData(
                table: "TimeRegistrations",
                keyColumn: "TimeRegistrationId",
                keyValue: 214,
                columns: new[] { "EndTime", "StartTime" },
                values: new object[] { new DateTime(2024, 4, 2, 15, 57, 58, 0, DateTimeKind.Unspecified), new DateTime(2024, 5, 31, 2, 0, 10, 0, DateTimeKind.Unspecified) });

            migrationBuilder.UpdateData(
                table: "TimeRegistrations",
                keyColumn: "TimeRegistrationId",
                keyValue: 215,
                columns: new[] { "EndTime", "StartTime" },
                values: new object[] { new DateTime(2024, 8, 2, 7, 35, 13, 0, DateTimeKind.Unspecified), new DateTime(2024, 1, 21, 17, 19, 8, 0, DateTimeKind.Unspecified) });

            migrationBuilder.UpdateData(
                table: "TimeRegistrations",
                keyColumn: "TimeRegistrationId",
                keyValue: 216,
                columns: new[] { "EndTime", "StartTime" },
                values: new object[] { new DateTime(2024, 10, 11, 12, 31, 15, 0, DateTimeKind.Unspecified), new DateTime(2024, 9, 12, 8, 23, 38, 0, DateTimeKind.Unspecified) });

            migrationBuilder.UpdateData(
                table: "TimeRegistrations",
                keyColumn: "TimeRegistrationId",
                keyValue: 217,
                columns: new[] { "EndTime", "StartTime" },
                values: new object[] { new DateTime(2024, 6, 3, 14, 1, 52, 0, DateTimeKind.Unspecified), new DateTime(2024, 8, 23, 23, 1, 13, 0, DateTimeKind.Unspecified) });

            migrationBuilder.UpdateData(
                table: "TimeRegistrations",
                keyColumn: "TimeRegistrationId",
                keyValue: 218,
                columns: new[] { "EndTime", "StartTime" },
                values: new object[] { new DateTime(2024, 10, 28, 18, 24, 55, 0, DateTimeKind.Unspecified), new DateTime(2024, 10, 8, 10, 19, 18, 0, DateTimeKind.Unspecified) });

            migrationBuilder.UpdateData(
                table: "TimeRegistrations",
                keyColumn: "TimeRegistrationId",
                keyValue: 219,
                columns: new[] { "EndTime", "StartTime" },
                values: new object[] { new DateTime(2024, 7, 23, 14, 23, 14, 0, DateTimeKind.Unspecified), new DateTime(2024, 1, 9, 11, 14, 29, 0, DateTimeKind.Unspecified) });

            migrationBuilder.UpdateData(
                table: "TimeRegistrations",
                keyColumn: "TimeRegistrationId",
                keyValue: 220,
                columns: new[] { "EndTime", "StartTime" },
                values: new object[] { new DateTime(2024, 11, 22, 22, 5, 34, 0, DateTimeKind.Unspecified), new DateTime(2024, 8, 3, 15, 29, 10, 0, DateTimeKind.Unspecified) });

            migrationBuilder.UpdateData(
                table: "TimeRegistrations",
                keyColumn: "TimeRegistrationId",
                keyValue: 221,
                columns: new[] { "EndTime", "StartTime" },
                values: new object[] { new DateTime(2024, 7, 26, 8, 3, 38, 0, DateTimeKind.Unspecified), new DateTime(2024, 1, 1, 6, 18, 13, 0, DateTimeKind.Unspecified) });

            migrationBuilder.UpdateData(
                table: "TimeRegistrations",
                keyColumn: "TimeRegistrationId",
                keyValue: 222,
                columns: new[] { "EndTime", "StartTime" },
                values: new object[] { new DateTime(2024, 3, 17, 2, 36, 59, 0, DateTimeKind.Unspecified), new DateTime(2024, 12, 3, 16, 34, 48, 0, DateTimeKind.Unspecified) });

            migrationBuilder.UpdateData(
                table: "TimeRegistrations",
                keyColumn: "TimeRegistrationId",
                keyValue: 223,
                columns: new[] { "EndTime", "StartTime" },
                values: new object[] { new DateTime(2024, 2, 5, 7, 3, 35, 0, DateTimeKind.Unspecified), new DateTime(2024, 7, 20, 10, 5, 44, 0, DateTimeKind.Unspecified) });

            migrationBuilder.UpdateData(
                table: "TimeRegistrations",
                keyColumn: "TimeRegistrationId",
                keyValue: 224,
                columns: new[] { "EndTime", "StartTime" },
                values: new object[] { new DateTime(2024, 1, 10, 16, 10, 44, 0, DateTimeKind.Unspecified), new DateTime(2024, 1, 11, 23, 47, 20, 0, DateTimeKind.Unspecified) });

            migrationBuilder.UpdateData(
                table: "TimeRegistrations",
                keyColumn: "TimeRegistrationId",
                keyValue: 225,
                columns: new[] { "EndTime", "StartTime" },
                values: new object[] { new DateTime(2024, 12, 23, 18, 20, 2, 0, DateTimeKind.Unspecified), new DateTime(2024, 9, 27, 9, 36, 17, 0, DateTimeKind.Unspecified) });

            migrationBuilder.UpdateData(
                table: "TimeRegistrations",
                keyColumn: "TimeRegistrationId",
                keyValue: 226,
                columns: new[] { "EndTime", "StartTime" },
                values: new object[] { new DateTime(2024, 9, 11, 4, 37, 48, 0, DateTimeKind.Unspecified), new DateTime(2024, 3, 1, 2, 39, 23, 0, DateTimeKind.Unspecified) });

            migrationBuilder.UpdateData(
                table: "TimeRegistrations",
                keyColumn: "TimeRegistrationId",
                keyValue: 227,
                columns: new[] { "EndTime", "StartTime" },
                values: new object[] { new DateTime(2024, 2, 24, 11, 44, 46, 0, DateTimeKind.Unspecified), new DateTime(2024, 10, 7, 6, 58, 39, 0, DateTimeKind.Unspecified) });

            migrationBuilder.UpdateData(
                table: "TimeRegistrations",
                keyColumn: "TimeRegistrationId",
                keyValue: 228,
                columns: new[] { "EndTime", "StartTime" },
                values: new object[] { new DateTime(2024, 4, 25, 16, 27, 11, 0, DateTimeKind.Unspecified), new DateTime(2024, 3, 6, 5, 6, 40, 0, DateTimeKind.Unspecified) });

            migrationBuilder.UpdateData(
                table: "TimeRegistrations",
                keyColumn: "TimeRegistrationId",
                keyValue: 229,
                columns: new[] { "EndTime", "StartTime" },
                values: new object[] { new DateTime(2024, 4, 11, 11, 25, 23, 0, DateTimeKind.Unspecified), new DateTime(2024, 12, 25, 7, 46, 8, 0, DateTimeKind.Unspecified) });

            migrationBuilder.UpdateData(
                table: "TimeRegistrations",
                keyColumn: "TimeRegistrationId",
                keyValue: 230,
                columns: new[] { "EndTime", "StartTime" },
                values: new object[] { new DateTime(2024, 3, 27, 9, 59, 36, 0, DateTimeKind.Unspecified), new DateTime(2024, 11, 29, 0, 3, 1, 0, DateTimeKind.Unspecified) });

            migrationBuilder.UpdateData(
                table: "TimeRegistrations",
                keyColumn: "TimeRegistrationId",
                keyValue: 231,
                columns: new[] { "EndTime", "StartTime" },
                values: new object[] { new DateTime(2024, 5, 12, 11, 48, 5, 0, DateTimeKind.Unspecified), new DateTime(2024, 7, 31, 12, 37, 33, 0, DateTimeKind.Unspecified) });

            migrationBuilder.UpdateData(
                table: "TimeRegistrations",
                keyColumn: "TimeRegistrationId",
                keyValue: 232,
                columns: new[] { "EndTime", "StartTime" },
                values: new object[] { new DateTime(2024, 10, 15, 5, 11, 32, 0, DateTimeKind.Unspecified), new DateTime(2024, 1, 29, 1, 25, 53, 0, DateTimeKind.Unspecified) });

            migrationBuilder.UpdateData(
                table: "TimeRegistrations",
                keyColumn: "TimeRegistrationId",
                keyValue: 233,
                columns: new[] { "EndTime", "StartTime" },
                values: new object[] { new DateTime(2024, 2, 1, 15, 42, 55, 0, DateTimeKind.Unspecified), new DateTime(2024, 8, 4, 7, 37, 53, 0, DateTimeKind.Unspecified) });

            migrationBuilder.UpdateData(
                table: "TimeRegistrations",
                keyColumn: "TimeRegistrationId",
                keyValue: 234,
                columns: new[] { "EndTime", "StartTime" },
                values: new object[] { new DateTime(2024, 7, 3, 6, 32, 39, 0, DateTimeKind.Unspecified), new DateTime(2024, 2, 4, 13, 15, 23, 0, DateTimeKind.Unspecified) });

            migrationBuilder.UpdateData(
                table: "TimeRegistrations",
                keyColumn: "TimeRegistrationId",
                keyValue: 235,
                columns: new[] { "EndTime", "StartTime" },
                values: new object[] { new DateTime(2024, 2, 15, 14, 6, 17, 0, DateTimeKind.Unspecified), new DateTime(2024, 11, 4, 4, 37, 38, 0, DateTimeKind.Unspecified) });

            migrationBuilder.UpdateData(
                table: "TimeRegistrations",
                keyColumn: "TimeRegistrationId",
                keyValue: 236,
                columns: new[] { "EndTime", "StartTime" },
                values: new object[] { new DateTime(2024, 11, 6, 1, 6, 41, 0, DateTimeKind.Unspecified), new DateTime(2024, 2, 27, 21, 42, 33, 0, DateTimeKind.Unspecified) });

            migrationBuilder.UpdateData(
                table: "TimeRegistrations",
                keyColumn: "TimeRegistrationId",
                keyValue: 237,
                columns: new[] { "EndTime", "StartTime" },
                values: new object[] { new DateTime(2024, 3, 19, 3, 46, 40, 0, DateTimeKind.Unspecified), new DateTime(2024, 12, 7, 6, 6, 32, 0, DateTimeKind.Unspecified) });

            migrationBuilder.UpdateData(
                table: "TimeRegistrations",
                keyColumn: "TimeRegistrationId",
                keyValue: 238,
                columns: new[] { "EndTime", "StartTime" },
                values: new object[] { new DateTime(2024, 2, 24, 16, 22, 2, 0, DateTimeKind.Unspecified), new DateTime(2024, 11, 26, 9, 56, 17, 0, DateTimeKind.Unspecified) });

            migrationBuilder.UpdateData(
                table: "TimeRegistrations",
                keyColumn: "TimeRegistrationId",
                keyValue: 239,
                columns: new[] { "EndTime", "StartTime" },
                values: new object[] { new DateTime(2024, 5, 24, 13, 44, 42, 0, DateTimeKind.Unspecified), new DateTime(2024, 9, 5, 16, 16, 33, 0, DateTimeKind.Unspecified) });

            migrationBuilder.UpdateData(
                table: "TimeRegistrations",
                keyColumn: "TimeRegistrationId",
                keyValue: 240,
                columns: new[] { "EndTime", "StartTime" },
                values: new object[] { new DateTime(2024, 10, 28, 0, 23, 58, 0, DateTimeKind.Unspecified), new DateTime(2024, 3, 20, 0, 8, 27, 0, DateTimeKind.Unspecified) });

            migrationBuilder.UpdateData(
                table: "TimeRegistrations",
                keyColumn: "TimeRegistrationId",
                keyValue: 241,
                columns: new[] { "EndTime", "StartTime" },
                values: new object[] { new DateTime(2024, 6, 27, 1, 12, 48, 0, DateTimeKind.Unspecified), new DateTime(2024, 1, 3, 16, 37, 58, 0, DateTimeKind.Unspecified) });

            migrationBuilder.UpdateData(
                table: "TimeRegistrations",
                keyColumn: "TimeRegistrationId",
                keyValue: 242,
                columns: new[] { "EndTime", "StartTime" },
                values: new object[] { new DateTime(2024, 10, 7, 16, 43, 49, 0, DateTimeKind.Unspecified), new DateTime(2024, 11, 5, 6, 24, 50, 0, DateTimeKind.Unspecified) });

            migrationBuilder.UpdateData(
                table: "TimeRegistrations",
                keyColumn: "TimeRegistrationId",
                keyValue: 243,
                columns: new[] { "EndTime", "StartTime" },
                values: new object[] { new DateTime(2024, 8, 21, 10, 49, 47, 0, DateTimeKind.Unspecified), new DateTime(2024, 11, 2, 5, 18, 59, 0, DateTimeKind.Unspecified) });

            migrationBuilder.UpdateData(
                table: "TimeRegistrations",
                keyColumn: "TimeRegistrationId",
                keyValue: 244,
                columns: new[] { "EndTime", "StartTime" },
                values: new object[] { new DateTime(2024, 2, 20, 0, 35, 54, 0, DateTimeKind.Unspecified), new DateTime(2024, 10, 8, 13, 31, 15, 0, DateTimeKind.Unspecified) });

            migrationBuilder.UpdateData(
                table: "TimeRegistrations",
                keyColumn: "TimeRegistrationId",
                keyValue: 245,
                columns: new[] { "EndTime", "StartTime" },
                values: new object[] { new DateTime(2024, 12, 26, 2, 41, 21, 0, DateTimeKind.Unspecified), new DateTime(2024, 1, 14, 0, 46, 46, 0, DateTimeKind.Unspecified) });

            migrationBuilder.UpdateData(
                table: "TimeRegistrations",
                keyColumn: "TimeRegistrationId",
                keyValue: 246,
                columns: new[] { "EndTime", "StartTime" },
                values: new object[] { new DateTime(2024, 4, 23, 1, 24, 56, 0, DateTimeKind.Unspecified), new DateTime(2024, 11, 28, 5, 37, 26, 0, DateTimeKind.Unspecified) });

            migrationBuilder.UpdateData(
                table: "TimeRegistrations",
                keyColumn: "TimeRegistrationId",
                keyValue: 247,
                columns: new[] { "EndTime", "StartTime" },
                values: new object[] { new DateTime(2024, 9, 22, 7, 53, 23, 0, DateTimeKind.Unspecified), new DateTime(2024, 9, 10, 22, 58, 18, 0, DateTimeKind.Unspecified) });

            migrationBuilder.UpdateData(
                table: "TimeRegistrations",
                keyColumn: "TimeRegistrationId",
                keyValue: 248,
                columns: new[] { "EndTime", "StartTime" },
                values: new object[] { new DateTime(2024, 9, 3, 20, 34, 10, 0, DateTimeKind.Unspecified), new DateTime(2024, 4, 24, 2, 57, 45, 0, DateTimeKind.Unspecified) });

            migrationBuilder.UpdateData(
                table: "TimeRegistrations",
                keyColumn: "TimeRegistrationId",
                keyValue: 249,
                columns: new[] { "EndTime", "StartTime" },
                values: new object[] { new DateTime(2024, 4, 19, 11, 28, 35, 0, DateTimeKind.Unspecified), new DateTime(2024, 2, 6, 11, 44, 36, 0, DateTimeKind.Unspecified) });

            migrationBuilder.UpdateData(
                table: "TimeRegistrations",
                keyColumn: "TimeRegistrationId",
                keyValue: 250,
                columns: new[] { "EndTime", "StartTime" },
                values: new object[] { new DateTime(2024, 12, 23, 6, 24, 5, 0, DateTimeKind.Unspecified), new DateTime(2024, 11, 23, 16, 35, 47, 0, DateTimeKind.Unspecified) });

            migrationBuilder.UpdateData(
                table: "TimeRegistrations",
                keyColumn: "TimeRegistrationId",
                keyValue: 251,
                columns: new[] { "EndTime", "StartTime" },
                values: new object[] { new DateTime(2024, 3, 26, 1, 54, 57, 0, DateTimeKind.Unspecified), new DateTime(2024, 12, 25, 13, 36, 34, 0, DateTimeKind.Unspecified) });

            migrationBuilder.UpdateData(
                table: "TimeRegistrations",
                keyColumn: "TimeRegistrationId",
                keyValue: 252,
                columns: new[] { "EndTime", "StartTime" },
                values: new object[] { new DateTime(2024, 8, 1, 4, 34, 20, 0, DateTimeKind.Unspecified), new DateTime(2024, 1, 31, 19, 16, 8, 0, DateTimeKind.Unspecified) });

            migrationBuilder.UpdateData(
                table: "TimeRegistrations",
                keyColumn: "TimeRegistrationId",
                keyValue: 253,
                columns: new[] { "EndTime", "StartTime" },
                values: new object[] { new DateTime(2024, 12, 23, 21, 12, 33, 0, DateTimeKind.Unspecified), new DateTime(2024, 5, 18, 11, 34, 55, 0, DateTimeKind.Unspecified) });

            migrationBuilder.UpdateData(
                table: "TimeRegistrations",
                keyColumn: "TimeRegistrationId",
                keyValue: 254,
                columns: new[] { "EndTime", "StartTime" },
                values: new object[] { new DateTime(2024, 6, 29, 0, 42, 15, 0, DateTimeKind.Unspecified), new DateTime(2024, 8, 18, 17, 30, 19, 0, DateTimeKind.Unspecified) });

            migrationBuilder.UpdateData(
                table: "TimeRegistrations",
                keyColumn: "TimeRegistrationId",
                keyValue: 255,
                columns: new[] { "EndTime", "StartTime" },
                values: new object[] { new DateTime(2024, 1, 16, 8, 18, 37, 0, DateTimeKind.Unspecified), new DateTime(2024, 6, 3, 5, 57, 33, 0, DateTimeKind.Unspecified) });

            migrationBuilder.UpdateData(
                table: "TimeRegistrations",
                keyColumn: "TimeRegistrationId",
                keyValue: 256,
                columns: new[] { "EndTime", "StartTime" },
                values: new object[] { new DateTime(2024, 10, 9, 16, 31, 27, 0, DateTimeKind.Unspecified), new DateTime(2024, 4, 16, 2, 51, 15, 0, DateTimeKind.Unspecified) });

            migrationBuilder.UpdateData(
                table: "TimeRegistrations",
                keyColumn: "TimeRegistrationId",
                keyValue: 257,
                columns: new[] { "EndTime", "StartTime" },
                values: new object[] { new DateTime(2024, 2, 26, 17, 17, 23, 0, DateTimeKind.Unspecified), new DateTime(2024, 2, 19, 17, 27, 2, 0, DateTimeKind.Unspecified) });

            migrationBuilder.UpdateData(
                table: "TimeRegistrations",
                keyColumn: "TimeRegistrationId",
                keyValue: 258,
                columns: new[] { "EndTime", "StartTime" },
                values: new object[] { new DateTime(2024, 4, 29, 21, 42, 19, 0, DateTimeKind.Unspecified), new DateTime(2024, 5, 1, 12, 57, 11, 0, DateTimeKind.Unspecified) });

            migrationBuilder.UpdateData(
                table: "TimeRegistrations",
                keyColumn: "TimeRegistrationId",
                keyValue: 259,
                columns: new[] { "EndTime", "StartTime" },
                values: new object[] { new DateTime(2024, 2, 15, 16, 48, 53, 0, DateTimeKind.Unspecified), new DateTime(2024, 11, 23, 21, 6, 8, 0, DateTimeKind.Unspecified) });

            migrationBuilder.UpdateData(
                table: "TimeRegistrations",
                keyColumn: "TimeRegistrationId",
                keyValue: 260,
                columns: new[] { "EndTime", "StartTime" },
                values: new object[] { new DateTime(2024, 10, 14, 12, 28, 44, 0, DateTimeKind.Unspecified), new DateTime(2024, 10, 31, 2, 27, 14, 0, DateTimeKind.Unspecified) });

            migrationBuilder.UpdateData(
                table: "TimeRegistrations",
                keyColumn: "TimeRegistrationId",
                keyValue: 261,
                columns: new[] { "EndTime", "StartTime" },
                values: new object[] { new DateTime(2024, 7, 13, 19, 45, 44, 0, DateTimeKind.Unspecified), new DateTime(2024, 5, 29, 21, 34, 47, 0, DateTimeKind.Unspecified) });

            migrationBuilder.UpdateData(
                table: "TimeRegistrations",
                keyColumn: "TimeRegistrationId",
                keyValue: 262,
                columns: new[] { "EndTime", "StartTime" },
                values: new object[] { new DateTime(2024, 12, 13, 2, 20, 31, 0, DateTimeKind.Unspecified), new DateTime(2024, 7, 6, 11, 23, 34, 0, DateTimeKind.Unspecified) });

            migrationBuilder.UpdateData(
                table: "TimeRegistrations",
                keyColumn: "TimeRegistrationId",
                keyValue: 263,
                columns: new[] { "EndTime", "StartTime" },
                values: new object[] { new DateTime(2024, 3, 25, 6, 35, 3, 0, DateTimeKind.Unspecified), new DateTime(2024, 2, 8, 21, 4, 37, 0, DateTimeKind.Unspecified) });

            migrationBuilder.UpdateData(
                table: "TimeRegistrations",
                keyColumn: "TimeRegistrationId",
                keyValue: 264,
                columns: new[] { "EndTime", "StartTime" },
                values: new object[] { new DateTime(2024, 4, 22, 22, 34, 56, 0, DateTimeKind.Unspecified), new DateTime(2024, 7, 22, 12, 33, 15, 0, DateTimeKind.Unspecified) });

            migrationBuilder.UpdateData(
                table: "TimeRegistrations",
                keyColumn: "TimeRegistrationId",
                keyValue: 265,
                columns: new[] { "EndTime", "StartTime" },
                values: new object[] { new DateTime(2024, 4, 28, 16, 24, 58, 0, DateTimeKind.Unspecified), new DateTime(2024, 1, 8, 23, 18, 52, 0, DateTimeKind.Unspecified) });

            migrationBuilder.UpdateData(
                table: "TimeRegistrations",
                keyColumn: "TimeRegistrationId",
                keyValue: 266,
                columns: new[] { "EndTime", "StartTime" },
                values: new object[] { new DateTime(2024, 5, 26, 20, 3, 25, 0, DateTimeKind.Unspecified), new DateTime(2024, 7, 22, 22, 56, 24, 0, DateTimeKind.Unspecified) });

            migrationBuilder.UpdateData(
                table: "TimeRegistrations",
                keyColumn: "TimeRegistrationId",
                keyValue: 267,
                columns: new[] { "EndTime", "StartTime" },
                values: new object[] { new DateTime(2024, 9, 28, 13, 44, 32, 0, DateTimeKind.Unspecified), new DateTime(2024, 1, 9, 9, 51, 11, 0, DateTimeKind.Unspecified) });

            migrationBuilder.UpdateData(
                table: "TimeRegistrations",
                keyColumn: "TimeRegistrationId",
                keyValue: 268,
                columns: new[] { "EndTime", "StartTime" },
                values: new object[] { new DateTime(2024, 3, 31, 7, 41, 26, 0, DateTimeKind.Unspecified), new DateTime(2024, 7, 19, 21, 32, 11, 0, DateTimeKind.Unspecified) });

            migrationBuilder.UpdateData(
                table: "TimeRegistrations",
                keyColumn: "TimeRegistrationId",
                keyValue: 269,
                columns: new[] { "EndTime", "StartTime" },
                values: new object[] { new DateTime(2024, 10, 22, 16, 11, 47, 0, DateTimeKind.Unspecified), new DateTime(2024, 8, 12, 1, 43, 12, 0, DateTimeKind.Unspecified) });

            migrationBuilder.UpdateData(
                table: "TimeRegistrations",
                keyColumn: "TimeRegistrationId",
                keyValue: 270,
                columns: new[] { "EndTime", "StartTime" },
                values: new object[] { new DateTime(2024, 10, 16, 0, 8, 7, 0, DateTimeKind.Unspecified), new DateTime(2024, 9, 12, 5, 56, 47, 0, DateTimeKind.Unspecified) });

            migrationBuilder.UpdateData(
                table: "TimeRegistrations",
                keyColumn: "TimeRegistrationId",
                keyValue: 271,
                columns: new[] { "EndTime", "StartTime" },
                values: new object[] { new DateTime(2024, 10, 3, 4, 44, 33, 0, DateTimeKind.Unspecified), new DateTime(2024, 1, 9, 20, 34, 27, 0, DateTimeKind.Unspecified) });

            migrationBuilder.UpdateData(
                table: "TimeRegistrations",
                keyColumn: "TimeRegistrationId",
                keyValue: 272,
                columns: new[] { "EndTime", "StartTime" },
                values: new object[] { new DateTime(2024, 6, 14, 9, 41, 18, 0, DateTimeKind.Unspecified), new DateTime(2024, 8, 7, 22, 6, 3, 0, DateTimeKind.Unspecified) });

            migrationBuilder.UpdateData(
                table: "TimeRegistrations",
                keyColumn: "TimeRegistrationId",
                keyValue: 273,
                columns: new[] { "EndTime", "StartTime" },
                values: new object[] { new DateTime(2024, 2, 28, 17, 9, 31, 0, DateTimeKind.Unspecified), new DateTime(2024, 7, 27, 23, 49, 50, 0, DateTimeKind.Unspecified) });

            migrationBuilder.UpdateData(
                table: "TimeRegistrations",
                keyColumn: "TimeRegistrationId",
                keyValue: 274,
                columns: new[] { "EndTime", "StartTime" },
                values: new object[] { new DateTime(2024, 3, 14, 22, 16, 50, 0, DateTimeKind.Unspecified), new DateTime(2024, 1, 23, 4, 4, 28, 0, DateTimeKind.Unspecified) });

            migrationBuilder.UpdateData(
                table: "TimeRegistrations",
                keyColumn: "TimeRegistrationId",
                keyValue: 275,
                columns: new[] { "EndTime", "StartTime" },
                values: new object[] { new DateTime(2024, 2, 15, 10, 58, 0, 0, DateTimeKind.Unspecified), new DateTime(2024, 8, 31, 3, 59, 9, 0, DateTimeKind.Unspecified) });

            migrationBuilder.UpdateData(
                table: "TimeRegistrations",
                keyColumn: "TimeRegistrationId",
                keyValue: 276,
                columns: new[] { "EndTime", "StartTime" },
                values: new object[] { new DateTime(2024, 8, 7, 13, 48, 45, 0, DateTimeKind.Unspecified), new DateTime(2024, 8, 12, 19, 51, 47, 0, DateTimeKind.Unspecified) });

            migrationBuilder.UpdateData(
                table: "TimeRegistrations",
                keyColumn: "TimeRegistrationId",
                keyValue: 277,
                columns: new[] { "EndTime", "StartTime" },
                values: new object[] { new DateTime(2024, 10, 6, 3, 28, 53, 0, DateTimeKind.Unspecified), new DateTime(2024, 4, 16, 14, 33, 16, 0, DateTimeKind.Unspecified) });

            migrationBuilder.UpdateData(
                table: "TimeRegistrations",
                keyColumn: "TimeRegistrationId",
                keyValue: 278,
                columns: new[] { "EndTime", "StartTime" },
                values: new object[] { new DateTime(2024, 6, 28, 21, 39, 11, 0, DateTimeKind.Unspecified), new DateTime(2024, 12, 9, 22, 36, 4, 0, DateTimeKind.Unspecified) });

            migrationBuilder.UpdateData(
                table: "TimeRegistrations",
                keyColumn: "TimeRegistrationId",
                keyValue: 279,
                columns: new[] { "EndTime", "StartTime" },
                values: new object[] { new DateTime(2024, 2, 9, 9, 54, 46, 0, DateTimeKind.Unspecified), new DateTime(2024, 6, 3, 5, 2, 11, 0, DateTimeKind.Unspecified) });

            migrationBuilder.UpdateData(
                table: "TimeRegistrations",
                keyColumn: "TimeRegistrationId",
                keyValue: 280,
                columns: new[] { "EndTime", "StartTime" },
                values: new object[] { new DateTime(2024, 9, 22, 16, 56, 32, 0, DateTimeKind.Unspecified), new DateTime(2024, 8, 25, 10, 28, 31, 0, DateTimeKind.Unspecified) });

            migrationBuilder.UpdateData(
                table: "TimeRegistrations",
                keyColumn: "TimeRegistrationId",
                keyValue: 281,
                columns: new[] { "EndTime", "StartTime" },
                values: new object[] { new DateTime(2024, 9, 20, 11, 5, 18, 0, DateTimeKind.Unspecified), new DateTime(2024, 10, 16, 10, 29, 56, 0, DateTimeKind.Unspecified) });

            migrationBuilder.UpdateData(
                table: "TimeRegistrations",
                keyColumn: "TimeRegistrationId",
                keyValue: 282,
                columns: new[] { "EndTime", "StartTime" },
                values: new object[] { new DateTime(2024, 1, 20, 19, 3, 7, 0, DateTimeKind.Unspecified), new DateTime(2024, 12, 11, 8, 2, 42, 0, DateTimeKind.Unspecified) });

            migrationBuilder.UpdateData(
                table: "TimeRegistrations",
                keyColumn: "TimeRegistrationId",
                keyValue: 283,
                columns: new[] { "EndTime", "StartTime" },
                values: new object[] { new DateTime(2024, 10, 28, 20, 3, 15, 0, DateTimeKind.Unspecified), new DateTime(2024, 3, 31, 2, 13, 9, 0, DateTimeKind.Unspecified) });

            migrationBuilder.UpdateData(
                table: "TimeRegistrations",
                keyColumn: "TimeRegistrationId",
                keyValue: 284,
                columns: new[] { "EndTime", "StartTime" },
                values: new object[] { new DateTime(2024, 9, 14, 4, 51, 21, 0, DateTimeKind.Unspecified), new DateTime(2024, 5, 21, 22, 3, 56, 0, DateTimeKind.Unspecified) });

            migrationBuilder.UpdateData(
                table: "TimeRegistrations",
                keyColumn: "TimeRegistrationId",
                keyValue: 285,
                columns: new[] { "EndTime", "StartTime" },
                values: new object[] { new DateTime(2024, 11, 29, 13, 17, 5, 0, DateTimeKind.Unspecified), new DateTime(2024, 11, 27, 5, 47, 25, 0, DateTimeKind.Unspecified) });

            migrationBuilder.UpdateData(
                table: "TimeRegistrations",
                keyColumn: "TimeRegistrationId",
                keyValue: 286,
                columns: new[] { "EndTime", "StartTime" },
                values: new object[] { new DateTime(2024, 3, 28, 6, 15, 58, 0, DateTimeKind.Unspecified), new DateTime(2024, 4, 9, 15, 56, 38, 0, DateTimeKind.Unspecified) });

            migrationBuilder.UpdateData(
                table: "TimeRegistrations",
                keyColumn: "TimeRegistrationId",
                keyValue: 287,
                columns: new[] { "EndTime", "StartTime" },
                values: new object[] { new DateTime(2024, 7, 2, 23, 53, 40, 0, DateTimeKind.Unspecified), new DateTime(2024, 1, 4, 1, 56, 45, 0, DateTimeKind.Unspecified) });

            migrationBuilder.UpdateData(
                table: "TimeRegistrations",
                keyColumn: "TimeRegistrationId",
                keyValue: 288,
                columns: new[] { "EndTime", "StartTime" },
                values: new object[] { new DateTime(2024, 10, 23, 11, 21, 54, 0, DateTimeKind.Unspecified), new DateTime(2024, 2, 9, 19, 22, 22, 0, DateTimeKind.Unspecified) });

            migrationBuilder.UpdateData(
                table: "TimeRegistrations",
                keyColumn: "TimeRegistrationId",
                keyValue: 289,
                columns: new[] { "EndTime", "StartTime" },
                values: new object[] { new DateTime(2024, 8, 8, 5, 12, 10, 0, DateTimeKind.Unspecified), new DateTime(2024, 5, 20, 16, 10, 22, 0, DateTimeKind.Unspecified) });

            migrationBuilder.UpdateData(
                table: "TimeRegistrations",
                keyColumn: "TimeRegistrationId",
                keyValue: 290,
                columns: new[] { "EndTime", "StartTime" },
                values: new object[] { new DateTime(2024, 5, 10, 9, 56, 51, 0, DateTimeKind.Unspecified), new DateTime(2024, 5, 12, 2, 48, 45, 0, DateTimeKind.Unspecified) });

            migrationBuilder.UpdateData(
                table: "TimeRegistrations",
                keyColumn: "TimeRegistrationId",
                keyValue: 291,
                columns: new[] { "EndTime", "StartTime" },
                values: new object[] { new DateTime(2024, 4, 9, 23, 1, 23, 0, DateTimeKind.Unspecified), new DateTime(2024, 1, 2, 10, 14, 19, 0, DateTimeKind.Unspecified) });

            migrationBuilder.UpdateData(
                table: "TimeRegistrations",
                keyColumn: "TimeRegistrationId",
                keyValue: 292,
                columns: new[] { "EndTime", "StartTime" },
                values: new object[] { new DateTime(2024, 3, 22, 6, 51, 52, 0, DateTimeKind.Unspecified), new DateTime(2024, 1, 17, 8, 3, 0, 0, DateTimeKind.Unspecified) });

            migrationBuilder.UpdateData(
                table: "TimeRegistrations",
                keyColumn: "TimeRegistrationId",
                keyValue: 293,
                columns: new[] { "EndTime", "StartTime" },
                values: new object[] { new DateTime(2024, 12, 27, 16, 49, 37, 0, DateTimeKind.Unspecified), new DateTime(2024, 1, 6, 16, 48, 12, 0, DateTimeKind.Unspecified) });

            migrationBuilder.UpdateData(
                table: "TimeRegistrations",
                keyColumn: "TimeRegistrationId",
                keyValue: 294,
                columns: new[] { "EndTime", "StartTime" },
                values: new object[] { new DateTime(2024, 8, 11, 4, 27, 52, 0, DateTimeKind.Unspecified), new DateTime(2024, 3, 26, 21, 32, 10, 0, DateTimeKind.Unspecified) });

            migrationBuilder.UpdateData(
                table: "TimeRegistrations",
                keyColumn: "TimeRegistrationId",
                keyValue: 295,
                columns: new[] { "EndTime", "StartTime" },
                values: new object[] { new DateTime(2024, 12, 6, 19, 51, 25, 0, DateTimeKind.Unspecified), new DateTime(2024, 6, 1, 3, 4, 4, 0, DateTimeKind.Unspecified) });

            migrationBuilder.UpdateData(
                table: "TimeRegistrations",
                keyColumn: "TimeRegistrationId",
                keyValue: 296,
                columns: new[] { "EndTime", "StartTime" },
                values: new object[] { new DateTime(2024, 1, 16, 10, 12, 38, 0, DateTimeKind.Unspecified), new DateTime(2024, 11, 21, 2, 14, 43, 0, DateTimeKind.Unspecified) });

            migrationBuilder.UpdateData(
                table: "TimeRegistrations",
                keyColumn: "TimeRegistrationId",
                keyValue: 297,
                columns: new[] { "EndTime", "StartTime" },
                values: new object[] { new DateTime(2024, 6, 18, 0, 29, 33, 0, DateTimeKind.Unspecified), new DateTime(2024, 10, 5, 5, 7, 38, 0, DateTimeKind.Unspecified) });

            migrationBuilder.UpdateData(
                table: "TimeRegistrations",
                keyColumn: "TimeRegistrationId",
                keyValue: 298,
                columns: new[] { "EndTime", "StartTime" },
                values: new object[] { new DateTime(2024, 2, 9, 13, 8, 6, 0, DateTimeKind.Unspecified), new DateTime(2024, 10, 3, 0, 27, 49, 0, DateTimeKind.Unspecified) });

            migrationBuilder.UpdateData(
                table: "TimeRegistrations",
                keyColumn: "TimeRegistrationId",
                keyValue: 299,
                columns: new[] { "EndTime", "StartTime" },
                values: new object[] { new DateTime(2024, 4, 6, 20, 39, 8, 0, DateTimeKind.Unspecified), new DateTime(2024, 9, 29, 13, 45, 56, 0, DateTimeKind.Unspecified) });

            migrationBuilder.UpdateData(
                table: "TimeRegistrations",
                keyColumn: "TimeRegistrationId",
                keyValue: 300,
                columns: new[] { "EndTime", "StartTime" },
                values: new object[] { new DateTime(2024, 3, 15, 23, 36, 28, 0, DateTimeKind.Unspecified), new DateTime(2024, 5, 13, 21, 28, 32, 0, DateTimeKind.Unspecified) });

            migrationBuilder.UpdateData(
                table: "TimeRegistrations",
                keyColumn: "TimeRegistrationId",
                keyValue: 301,
                columns: new[] { "EndTime", "StartTime" },
                values: new object[] { new DateTime(2024, 5, 8, 22, 2, 29, 0, DateTimeKind.Unspecified), new DateTime(2024, 3, 29, 13, 47, 5, 0, DateTimeKind.Unspecified) });

            migrationBuilder.UpdateData(
                table: "TimeRegistrations",
                keyColumn: "TimeRegistrationId",
                keyValue: 302,
                columns: new[] { "EndTime", "StartTime" },
                values: new object[] { new DateTime(2024, 4, 22, 12, 47, 46, 0, DateTimeKind.Unspecified), new DateTime(2024, 8, 3, 13, 57, 6, 0, DateTimeKind.Unspecified) });

            migrationBuilder.UpdateData(
                table: "TimeRegistrations",
                keyColumn: "TimeRegistrationId",
                keyValue: 303,
                columns: new[] { "EndTime", "StartTime" },
                values: new object[] { new DateTime(2024, 3, 5, 22, 30, 30, 0, DateTimeKind.Unspecified), new DateTime(2024, 8, 17, 0, 53, 31, 0, DateTimeKind.Unspecified) });

            migrationBuilder.UpdateData(
                table: "TimeRegistrations",
                keyColumn: "TimeRegistrationId",
                keyValue: 304,
                columns: new[] { "EndTime", "StartTime" },
                values: new object[] { new DateTime(2024, 10, 7, 16, 43, 46, 0, DateTimeKind.Unspecified), new DateTime(2024, 3, 2, 7, 4, 3, 0, DateTimeKind.Unspecified) });

            migrationBuilder.UpdateData(
                table: "TimeRegistrations",
                keyColumn: "TimeRegistrationId",
                keyValue: 305,
                columns: new[] { "EndTime", "StartTime" },
                values: new object[] { new DateTime(2024, 4, 6, 1, 29, 34, 0, DateTimeKind.Unspecified), new DateTime(2024, 2, 6, 8, 54, 17, 0, DateTimeKind.Unspecified) });

            migrationBuilder.UpdateData(
                table: "TimeRegistrations",
                keyColumn: "TimeRegistrationId",
                keyValue: 306,
                columns: new[] { "EndTime", "StartTime" },
                values: new object[] { new DateTime(2024, 10, 5, 5, 17, 1, 0, DateTimeKind.Unspecified), new DateTime(2024, 1, 9, 5, 24, 30, 0, DateTimeKind.Unspecified) });

            migrationBuilder.UpdateData(
                table: "TimeRegistrations",
                keyColumn: "TimeRegistrationId",
                keyValue: 307,
                columns: new[] { "EndTime", "StartTime" },
                values: new object[] { new DateTime(2024, 11, 29, 12, 4, 33, 0, DateTimeKind.Unspecified), new DateTime(2024, 11, 29, 14, 25, 57, 0, DateTimeKind.Unspecified) });

            migrationBuilder.UpdateData(
                table: "TimeRegistrations",
                keyColumn: "TimeRegistrationId",
                keyValue: 308,
                columns: new[] { "EndTime", "StartTime" },
                values: new object[] { new DateTime(2024, 11, 5, 20, 6, 16, 0, DateTimeKind.Unspecified), new DateTime(2024, 1, 27, 4, 28, 57, 0, DateTimeKind.Unspecified) });

            migrationBuilder.UpdateData(
                table: "TimeRegistrations",
                keyColumn: "TimeRegistrationId",
                keyValue: 309,
                columns: new[] { "EndTime", "StartTime" },
                values: new object[] { new DateTime(2024, 4, 16, 9, 46, 15, 0, DateTimeKind.Unspecified), new DateTime(2024, 12, 18, 11, 5, 27, 0, DateTimeKind.Unspecified) });

            migrationBuilder.UpdateData(
                table: "TimeRegistrations",
                keyColumn: "TimeRegistrationId",
                keyValue: 310,
                columns: new[] { "EndTime", "StartTime" },
                values: new object[] { new DateTime(2024, 1, 28, 19, 26, 1, 0, DateTimeKind.Unspecified), new DateTime(2024, 12, 17, 23, 28, 7, 0, DateTimeKind.Unspecified) });

            migrationBuilder.UpdateData(
                table: "TimeRegistrations",
                keyColumn: "TimeRegistrationId",
                keyValue: 311,
                columns: new[] { "EndTime", "StartTime" },
                values: new object[] { new DateTime(2024, 3, 4, 3, 27, 12, 0, DateTimeKind.Unspecified), new DateTime(2024, 2, 7, 17, 0, 37, 0, DateTimeKind.Unspecified) });

            migrationBuilder.UpdateData(
                table: "TimeRegistrations",
                keyColumn: "TimeRegistrationId",
                keyValue: 312,
                columns: new[] { "EndTime", "StartTime" },
                values: new object[] { new DateTime(2024, 10, 5, 19, 27, 53, 0, DateTimeKind.Unspecified), new DateTime(2024, 9, 28, 11, 16, 45, 0, DateTimeKind.Unspecified) });

            migrationBuilder.UpdateData(
                table: "TimeRegistrations",
                keyColumn: "TimeRegistrationId",
                keyValue: 313,
                columns: new[] { "EndTime", "StartTime" },
                values: new object[] { new DateTime(2024, 7, 21, 10, 14, 13, 0, DateTimeKind.Unspecified), new DateTime(2024, 12, 25, 2, 50, 6, 0, DateTimeKind.Unspecified) });

            migrationBuilder.UpdateData(
                table: "TimeRegistrations",
                keyColumn: "TimeRegistrationId",
                keyValue: 314,
                columns: new[] { "EndTime", "StartTime" },
                values: new object[] { new DateTime(2024, 11, 29, 20, 28, 14, 0, DateTimeKind.Unspecified), new DateTime(2024, 7, 13, 0, 35, 1, 0, DateTimeKind.Unspecified) });

            migrationBuilder.UpdateData(
                table: "TimeRegistrations",
                keyColumn: "TimeRegistrationId",
                keyValue: 315,
                columns: new[] { "EndTime", "StartTime" },
                values: new object[] { new DateTime(2024, 12, 3, 15, 4, 38, 0, DateTimeKind.Unspecified), new DateTime(2024, 3, 10, 8, 12, 33, 0, DateTimeKind.Unspecified) });

            migrationBuilder.UpdateData(
                table: "TimeRegistrations",
                keyColumn: "TimeRegistrationId",
                keyValue: 316,
                columns: new[] { "EndTime", "StartTime" },
                values: new object[] { new DateTime(2024, 3, 19, 17, 9, 11, 0, DateTimeKind.Unspecified), new DateTime(2024, 4, 9, 5, 50, 21, 0, DateTimeKind.Unspecified) });

            migrationBuilder.UpdateData(
                table: "TimeRegistrations",
                keyColumn: "TimeRegistrationId",
                keyValue: 317,
                columns: new[] { "EndTime", "StartTime" },
                values: new object[] { new DateTime(2024, 4, 6, 19, 50, 34, 0, DateTimeKind.Unspecified), new DateTime(2024, 7, 7, 7, 21, 59, 0, DateTimeKind.Unspecified) });

            migrationBuilder.UpdateData(
                table: "TimeRegistrations",
                keyColumn: "TimeRegistrationId",
                keyValue: 318,
                columns: new[] { "EndTime", "StartTime" },
                values: new object[] { new DateTime(2024, 9, 2, 14, 33, 53, 0, DateTimeKind.Unspecified), new DateTime(2024, 8, 17, 12, 30, 35, 0, DateTimeKind.Unspecified) });

            migrationBuilder.UpdateData(
                table: "TimeRegistrations",
                keyColumn: "TimeRegistrationId",
                keyValue: 319,
                columns: new[] { "EndTime", "StartTime" },
                values: new object[] { new DateTime(2024, 3, 11, 12, 14, 10, 0, DateTimeKind.Unspecified), new DateTime(2024, 6, 7, 18, 2, 20, 0, DateTimeKind.Unspecified) });

            migrationBuilder.UpdateData(
                table: "TimeRegistrations",
                keyColumn: "TimeRegistrationId",
                keyValue: 320,
                columns: new[] { "EndTime", "StartTime" },
                values: new object[] { new DateTime(2024, 7, 9, 5, 58, 54, 0, DateTimeKind.Unspecified), new DateTime(2024, 2, 8, 3, 11, 6, 0, DateTimeKind.Unspecified) });

            migrationBuilder.UpdateData(
                table: "TimeRegistrations",
                keyColumn: "TimeRegistrationId",
                keyValue: 321,
                columns: new[] { "EndTime", "StartTime" },
                values: new object[] { new DateTime(2024, 8, 16, 9, 27, 7, 0, DateTimeKind.Unspecified), new DateTime(2024, 6, 15, 23, 32, 57, 0, DateTimeKind.Unspecified) });

            migrationBuilder.UpdateData(
                table: "TimeRegistrations",
                keyColumn: "TimeRegistrationId",
                keyValue: 322,
                columns: new[] { "EndTime", "StartTime" },
                values: new object[] { new DateTime(2024, 6, 19, 11, 6, 20, 0, DateTimeKind.Unspecified), new DateTime(2024, 8, 15, 22, 8, 0, 0, DateTimeKind.Unspecified) });

            migrationBuilder.UpdateData(
                table: "TimeRegistrations",
                keyColumn: "TimeRegistrationId",
                keyValue: 323,
                columns: new[] { "EndTime", "StartTime" },
                values: new object[] { new DateTime(2024, 9, 3, 12, 49, 52, 0, DateTimeKind.Unspecified), new DateTime(2024, 6, 8, 1, 59, 2, 0, DateTimeKind.Unspecified) });

            migrationBuilder.UpdateData(
                table: "TimeRegistrations",
                keyColumn: "TimeRegistrationId",
                keyValue: 324,
                columns: new[] { "EndTime", "StartTime" },
                values: new object[] { new DateTime(2024, 12, 17, 14, 7, 4, 0, DateTimeKind.Unspecified), new DateTime(2024, 9, 11, 22, 25, 18, 0, DateTimeKind.Unspecified) });

            migrationBuilder.UpdateData(
                table: "TimeRegistrations",
                keyColumn: "TimeRegistrationId",
                keyValue: 325,
                columns: new[] { "EndTime", "StartTime" },
                values: new object[] { new DateTime(2024, 8, 15, 0, 0, 49, 0, DateTimeKind.Unspecified), new DateTime(2024, 9, 19, 5, 9, 13, 0, DateTimeKind.Unspecified) });

            migrationBuilder.UpdateData(
                table: "TimeRegistrations",
                keyColumn: "TimeRegistrationId",
                keyValue: 326,
                columns: new[] { "EndTime", "StartTime" },
                values: new object[] { new DateTime(2024, 12, 6, 0, 54, 8, 0, DateTimeKind.Unspecified), new DateTime(2024, 5, 10, 6, 39, 20, 0, DateTimeKind.Unspecified) });

            migrationBuilder.UpdateData(
                table: "TimeRegistrations",
                keyColumn: "TimeRegistrationId",
                keyValue: 327,
                columns: new[] { "EndTime", "StartTime" },
                values: new object[] { new DateTime(2024, 5, 31, 8, 2, 0, 0, DateTimeKind.Unspecified), new DateTime(2024, 3, 5, 8, 11, 30, 0, DateTimeKind.Unspecified) });

            migrationBuilder.UpdateData(
                table: "TimeRegistrations",
                keyColumn: "TimeRegistrationId",
                keyValue: 328,
                columns: new[] { "EndTime", "StartTime" },
                values: new object[] { new DateTime(2024, 9, 3, 1, 1, 52, 0, DateTimeKind.Unspecified), new DateTime(2024, 10, 21, 6, 2, 48, 0, DateTimeKind.Unspecified) });

            migrationBuilder.UpdateData(
                table: "TimeRegistrations",
                keyColumn: "TimeRegistrationId",
                keyValue: 329,
                columns: new[] { "EndTime", "StartTime" },
                values: new object[] { new DateTime(2024, 9, 9, 22, 46, 49, 0, DateTimeKind.Unspecified), new DateTime(2024, 3, 7, 22, 36, 41, 0, DateTimeKind.Unspecified) });

            migrationBuilder.UpdateData(
                table: "TimeRegistrations",
                keyColumn: "TimeRegistrationId",
                keyValue: 330,
                columns: new[] { "EndTime", "StartTime" },
                values: new object[] { new DateTime(2024, 3, 23, 0, 9, 12, 0, DateTimeKind.Unspecified), new DateTime(2024, 8, 11, 12, 49, 46, 0, DateTimeKind.Unspecified) });

            migrationBuilder.UpdateData(
                table: "TimeRegistrations",
                keyColumn: "TimeRegistrationId",
                keyValue: 331,
                columns: new[] { "EndTime", "StartTime" },
                values: new object[] { new DateTime(2024, 10, 8, 17, 47, 43, 0, DateTimeKind.Unspecified), new DateTime(2024, 11, 9, 15, 26, 39, 0, DateTimeKind.Unspecified) });

            migrationBuilder.UpdateData(
                table: "TimeRegistrations",
                keyColumn: "TimeRegistrationId",
                keyValue: 332,
                columns: new[] { "EndTime", "StartTime" },
                values: new object[] { new DateTime(2024, 10, 21, 19, 28, 2, 0, DateTimeKind.Unspecified), new DateTime(2024, 7, 12, 11, 30, 13, 0, DateTimeKind.Unspecified) });

            migrationBuilder.UpdateData(
                table: "TimeRegistrations",
                keyColumn: "TimeRegistrationId",
                keyValue: 333,
                columns: new[] { "EndTime", "StartTime" },
                values: new object[] { new DateTime(2024, 5, 17, 7, 5, 11, 0, DateTimeKind.Unspecified), new DateTime(2024, 6, 24, 1, 54, 32, 0, DateTimeKind.Unspecified) });

            migrationBuilder.UpdateData(
                table: "TimeRegistrations",
                keyColumn: "TimeRegistrationId",
                keyValue: 334,
                columns: new[] { "EndTime", "StartTime" },
                values: new object[] { new DateTime(2024, 3, 8, 0, 2, 14, 0, DateTimeKind.Unspecified), new DateTime(2024, 7, 31, 22, 37, 54, 0, DateTimeKind.Unspecified) });

            migrationBuilder.UpdateData(
                table: "TimeRegistrations",
                keyColumn: "TimeRegistrationId",
                keyValue: 335,
                columns: new[] { "EndTime", "StartTime" },
                values: new object[] { new DateTime(2024, 7, 20, 16, 27, 49, 0, DateTimeKind.Unspecified), new DateTime(2024, 8, 23, 23, 20, 23, 0, DateTimeKind.Unspecified) });

            migrationBuilder.UpdateData(
                table: "TimeRegistrations",
                keyColumn: "TimeRegistrationId",
                keyValue: 336,
                columns: new[] { "EndTime", "StartTime" },
                values: new object[] { new DateTime(2024, 7, 3, 5, 41, 59, 0, DateTimeKind.Unspecified), new DateTime(2024, 5, 2, 2, 9, 14, 0, DateTimeKind.Unspecified) });

            migrationBuilder.UpdateData(
                table: "TimeRegistrations",
                keyColumn: "TimeRegistrationId",
                keyValue: 337,
                columns: new[] { "EndTime", "StartTime" },
                values: new object[] { new DateTime(2024, 10, 12, 3, 38, 43, 0, DateTimeKind.Unspecified), new DateTime(2024, 11, 27, 7, 6, 10, 0, DateTimeKind.Unspecified) });

            migrationBuilder.UpdateData(
                table: "TimeRegistrations",
                keyColumn: "TimeRegistrationId",
                keyValue: 338,
                columns: new[] { "EndTime", "StartTime" },
                values: new object[] { new DateTime(2024, 11, 16, 22, 7, 9, 0, DateTimeKind.Unspecified), new DateTime(2024, 1, 7, 12, 30, 45, 0, DateTimeKind.Unspecified) });

            migrationBuilder.UpdateData(
                table: "TimeRegistrations",
                keyColumn: "TimeRegistrationId",
                keyValue: 339,
                columns: new[] { "EndTime", "StartTime" },
                values: new object[] { new DateTime(2024, 5, 24, 18, 21, 33, 0, DateTimeKind.Unspecified), new DateTime(2024, 7, 8, 17, 44, 21, 0, DateTimeKind.Unspecified) });

            migrationBuilder.UpdateData(
                table: "TimeRegistrations",
                keyColumn: "TimeRegistrationId",
                keyValue: 340,
                columns: new[] { "EndTime", "StartTime" },
                values: new object[] { new DateTime(2024, 2, 13, 20, 36, 47, 0, DateTimeKind.Unspecified), new DateTime(2024, 6, 19, 0, 42, 48, 0, DateTimeKind.Unspecified) });

            migrationBuilder.UpdateData(
                table: "TimeRegistrations",
                keyColumn: "TimeRegistrationId",
                keyValue: 341,
                columns: new[] { "EndTime", "StartTime" },
                values: new object[] { new DateTime(2024, 4, 8, 19, 4, 57, 0, DateTimeKind.Unspecified), new DateTime(2024, 3, 7, 21, 19, 59, 0, DateTimeKind.Unspecified) });

            migrationBuilder.UpdateData(
                table: "TimeRegistrations",
                keyColumn: "TimeRegistrationId",
                keyValue: 342,
                columns: new[] { "EndTime", "StartTime" },
                values: new object[] { new DateTime(2024, 12, 23, 18, 13, 52, 0, DateTimeKind.Unspecified), new DateTime(2024, 9, 14, 12, 38, 44, 0, DateTimeKind.Unspecified) });

            migrationBuilder.UpdateData(
                table: "TimeRegistrations",
                keyColumn: "TimeRegistrationId",
                keyValue: 343,
                columns: new[] { "EndTime", "StartTime" },
                values: new object[] { new DateTime(2024, 8, 10, 13, 51, 38, 0, DateTimeKind.Unspecified), new DateTime(2024, 1, 19, 12, 24, 30, 0, DateTimeKind.Unspecified) });

            migrationBuilder.UpdateData(
                table: "TimeRegistrations",
                keyColumn: "TimeRegistrationId",
                keyValue: 344,
                columns: new[] { "EndTime", "StartTime" },
                values: new object[] { new DateTime(2024, 7, 28, 2, 50, 43, 0, DateTimeKind.Unspecified), new DateTime(2024, 9, 2, 11, 40, 54, 0, DateTimeKind.Unspecified) });

            migrationBuilder.UpdateData(
                table: "TimeRegistrations",
                keyColumn: "TimeRegistrationId",
                keyValue: 345,
                columns: new[] { "EndTime", "StartTime" },
                values: new object[] { new DateTime(2024, 8, 18, 9, 10, 19, 0, DateTimeKind.Unspecified), new DateTime(2024, 1, 5, 5, 51, 12, 0, DateTimeKind.Unspecified) });

            migrationBuilder.UpdateData(
                table: "TimeRegistrations",
                keyColumn: "TimeRegistrationId",
                keyValue: 346,
                columns: new[] { "EndTime", "StartTime" },
                values: new object[] { new DateTime(2024, 12, 18, 4, 7, 14, 0, DateTimeKind.Unspecified), new DateTime(2024, 9, 28, 9, 33, 12, 0, DateTimeKind.Unspecified) });

            migrationBuilder.UpdateData(
                table: "TimeRegistrations",
                keyColumn: "TimeRegistrationId",
                keyValue: 347,
                columns: new[] { "EndTime", "StartTime" },
                values: new object[] { new DateTime(2024, 6, 18, 17, 42, 0, 0, DateTimeKind.Unspecified), new DateTime(2024, 6, 30, 0, 37, 24, 0, DateTimeKind.Unspecified) });

            migrationBuilder.UpdateData(
                table: "TimeRegistrations",
                keyColumn: "TimeRegistrationId",
                keyValue: 348,
                columns: new[] { "EndTime", "StartTime" },
                values: new object[] { new DateTime(2024, 10, 3, 17, 31, 15, 0, DateTimeKind.Unspecified), new DateTime(2024, 1, 30, 22, 48, 54, 0, DateTimeKind.Unspecified) });

            migrationBuilder.UpdateData(
                table: "TimeRegistrations",
                keyColumn: "TimeRegistrationId",
                keyValue: 349,
                columns: new[] { "EndTime", "StartTime" },
                values: new object[] { new DateTime(2024, 12, 10, 12, 47, 6, 0, DateTimeKind.Unspecified), new DateTime(2024, 1, 27, 0, 5, 57, 0, DateTimeKind.Unspecified) });

            migrationBuilder.UpdateData(
                table: "TimeRegistrations",
                keyColumn: "TimeRegistrationId",
                keyValue: 350,
                columns: new[] { "EndTime", "StartTime" },
                values: new object[] { new DateTime(2024, 7, 9, 16, 24, 52, 0, DateTimeKind.Unspecified), new DateTime(2024, 3, 10, 18, 21, 49, 0, DateTimeKind.Unspecified) });

            migrationBuilder.UpdateData(
                table: "TimeRegistrations",
                keyColumn: "TimeRegistrationId",
                keyValue: 351,
                columns: new[] { "EndTime", "StartTime" },
                values: new object[] { new DateTime(2024, 9, 21, 13, 6, 56, 0, DateTimeKind.Unspecified), new DateTime(2024, 3, 7, 17, 10, 10, 0, DateTimeKind.Unspecified) });

            migrationBuilder.UpdateData(
                table: "TimeRegistrations",
                keyColumn: "TimeRegistrationId",
                keyValue: 352,
                columns: new[] { "EndTime", "StartTime" },
                values: new object[] { new DateTime(2024, 8, 13, 1, 31, 26, 0, DateTimeKind.Unspecified), new DateTime(2024, 6, 13, 22, 38, 23, 0, DateTimeKind.Unspecified) });

            migrationBuilder.UpdateData(
                table: "TimeRegistrations",
                keyColumn: "TimeRegistrationId",
                keyValue: 353,
                columns: new[] { "EndTime", "StartTime" },
                values: new object[] { new DateTime(2024, 10, 12, 21, 48, 44, 0, DateTimeKind.Unspecified), new DateTime(2024, 9, 22, 7, 29, 48, 0, DateTimeKind.Unspecified) });

            migrationBuilder.UpdateData(
                table: "TimeRegistrations",
                keyColumn: "TimeRegistrationId",
                keyValue: 354,
                columns: new[] { "EndTime", "StartTime" },
                values: new object[] { new DateTime(2024, 4, 19, 17, 39, 38, 0, DateTimeKind.Unspecified), new DateTime(2024, 8, 4, 2, 31, 6, 0, DateTimeKind.Unspecified) });

            migrationBuilder.UpdateData(
                table: "TimeRegistrations",
                keyColumn: "TimeRegistrationId",
                keyValue: 355,
                columns: new[] { "EndTime", "StartTime" },
                values: new object[] { new DateTime(2024, 6, 7, 0, 0, 33, 0, DateTimeKind.Unspecified), new DateTime(2024, 2, 14, 13, 30, 4, 0, DateTimeKind.Unspecified) });

            migrationBuilder.UpdateData(
                table: "TimeRegistrations",
                keyColumn: "TimeRegistrationId",
                keyValue: 356,
                columns: new[] { "EndTime", "StartTime" },
                values: new object[] { new DateTime(2024, 5, 15, 10, 37, 10, 0, DateTimeKind.Unspecified), new DateTime(2024, 8, 22, 23, 24, 43, 0, DateTimeKind.Unspecified) });

            migrationBuilder.UpdateData(
                table: "TimeRegistrations",
                keyColumn: "TimeRegistrationId",
                keyValue: 357,
                columns: new[] { "EndTime", "StartTime" },
                values: new object[] { new DateTime(2024, 3, 14, 9, 1, 35, 0, DateTimeKind.Unspecified), new DateTime(2024, 7, 10, 23, 31, 30, 0, DateTimeKind.Unspecified) });

            migrationBuilder.UpdateData(
                table: "TimeRegistrations",
                keyColumn: "TimeRegistrationId",
                keyValue: 358,
                columns: new[] { "EndTime", "StartTime" },
                values: new object[] { new DateTime(2024, 11, 1, 16, 13, 14, 0, DateTimeKind.Unspecified), new DateTime(2024, 5, 8, 18, 58, 1, 0, DateTimeKind.Unspecified) });

            migrationBuilder.UpdateData(
                table: "TimeRegistrations",
                keyColumn: "TimeRegistrationId",
                keyValue: 359,
                columns: new[] { "EndTime", "StartTime" },
                values: new object[] { new DateTime(2024, 3, 20, 12, 55, 16, 0, DateTimeKind.Unspecified), new DateTime(2024, 5, 6, 17, 49, 44, 0, DateTimeKind.Unspecified) });

            migrationBuilder.UpdateData(
                table: "TimeRegistrations",
                keyColumn: "TimeRegistrationId",
                keyValue: 360,
                columns: new[] { "EndTime", "StartTime" },
                values: new object[] { new DateTime(2024, 12, 5, 20, 21, 15, 0, DateTimeKind.Unspecified), new DateTime(2024, 9, 18, 12, 53, 6, 0, DateTimeKind.Unspecified) });

            migrationBuilder.UpdateData(
                table: "TimeRegistrations",
                keyColumn: "TimeRegistrationId",
                keyValue: 361,
                columns: new[] { "EndTime", "StartTime" },
                values: new object[] { new DateTime(2024, 8, 24, 2, 26, 40, 0, DateTimeKind.Unspecified), new DateTime(2024, 9, 27, 8, 37, 51, 0, DateTimeKind.Unspecified) });

            migrationBuilder.UpdateData(
                table: "TimeRegistrations",
                keyColumn: "TimeRegistrationId",
                keyValue: 362,
                columns: new[] { "EndTime", "StartTime" },
                values: new object[] { new DateTime(2024, 6, 19, 8, 10, 58, 0, DateTimeKind.Unspecified), new DateTime(2024, 5, 29, 13, 42, 3, 0, DateTimeKind.Unspecified) });

            migrationBuilder.UpdateData(
                table: "TimeRegistrations",
                keyColumn: "TimeRegistrationId",
                keyValue: 363,
                columns: new[] { "EndTime", "StartTime" },
                values: new object[] { new DateTime(2024, 8, 21, 8, 33, 44, 0, DateTimeKind.Unspecified), new DateTime(2024, 4, 13, 12, 55, 22, 0, DateTimeKind.Unspecified) });

            migrationBuilder.UpdateData(
                table: "TimeRegistrations",
                keyColumn: "TimeRegistrationId",
                keyValue: 364,
                columns: new[] { "EndTime", "StartTime" },
                values: new object[] { new DateTime(2024, 4, 12, 3, 41, 12, 0, DateTimeKind.Unspecified), new DateTime(2024, 12, 3, 2, 36, 37, 0, DateTimeKind.Unspecified) });

            migrationBuilder.UpdateData(
                table: "TimeRegistrations",
                keyColumn: "TimeRegistrationId",
                keyValue: 365,
                columns: new[] { "EndTime", "StartTime" },
                values: new object[] { new DateTime(2024, 4, 2, 19, 36, 13, 0, DateTimeKind.Unspecified), new DateTime(2024, 6, 2, 20, 10, 53, 0, DateTimeKind.Unspecified) });

            migrationBuilder.UpdateData(
                table: "TimeRegistrations",
                keyColumn: "TimeRegistrationId",
                keyValue: 366,
                columns: new[] { "EndTime", "StartTime" },
                values: new object[] { new DateTime(2024, 2, 6, 20, 56, 22, 0, DateTimeKind.Unspecified), new DateTime(2024, 11, 10, 10, 28, 35, 0, DateTimeKind.Unspecified) });

            migrationBuilder.UpdateData(
                table: "TimeRegistrations",
                keyColumn: "TimeRegistrationId",
                keyValue: 367,
                columns: new[] { "EndTime", "StartTime" },
                values: new object[] { new DateTime(2024, 7, 1, 23, 29, 3, 0, DateTimeKind.Unspecified), new DateTime(2024, 4, 15, 13, 23, 4, 0, DateTimeKind.Unspecified) });

            migrationBuilder.UpdateData(
                table: "TimeRegistrations",
                keyColumn: "TimeRegistrationId",
                keyValue: 368,
                columns: new[] { "EndTime", "StartTime" },
                values: new object[] { new DateTime(2024, 7, 16, 2, 36, 4, 0, DateTimeKind.Unspecified), new DateTime(2024, 11, 25, 23, 32, 33, 0, DateTimeKind.Unspecified) });

            migrationBuilder.UpdateData(
                table: "TimeRegistrations",
                keyColumn: "TimeRegistrationId",
                keyValue: 369,
                columns: new[] { "EndTime", "StartTime" },
                values: new object[] { new DateTime(2024, 3, 8, 19, 59, 4, 0, DateTimeKind.Unspecified), new DateTime(2024, 6, 25, 12, 6, 29, 0, DateTimeKind.Unspecified) });

            migrationBuilder.UpdateData(
                table: "TimeRegistrations",
                keyColumn: "TimeRegistrationId",
                keyValue: 370,
                columns: new[] { "EndTime", "StartTime" },
                values: new object[] { new DateTime(2024, 8, 23, 2, 41, 20, 0, DateTimeKind.Unspecified), new DateTime(2024, 8, 23, 10, 8, 45, 0, DateTimeKind.Unspecified) });

            migrationBuilder.UpdateData(
                table: "TimeRegistrations",
                keyColumn: "TimeRegistrationId",
                keyValue: 371,
                columns: new[] { "EndTime", "StartTime" },
                values: new object[] { new DateTime(2024, 9, 18, 8, 4, 35, 0, DateTimeKind.Unspecified), new DateTime(2024, 7, 13, 7, 12, 31, 0, DateTimeKind.Unspecified) });

            migrationBuilder.UpdateData(
                table: "TimeRegistrations",
                keyColumn: "TimeRegistrationId",
                keyValue: 372,
                columns: new[] { "EndTime", "StartTime" },
                values: new object[] { new DateTime(2024, 11, 10, 10, 25, 30, 0, DateTimeKind.Unspecified), new DateTime(2024, 3, 30, 8, 3, 50, 0, DateTimeKind.Unspecified) });

            migrationBuilder.UpdateData(
                table: "TimeRegistrations",
                keyColumn: "TimeRegistrationId",
                keyValue: 373,
                columns: new[] { "EndTime", "StartTime" },
                values: new object[] { new DateTime(2024, 9, 20, 14, 46, 33, 0, DateTimeKind.Unspecified), new DateTime(2024, 4, 5, 14, 56, 0, 0, DateTimeKind.Unspecified) });

            migrationBuilder.UpdateData(
                table: "TimeRegistrations",
                keyColumn: "TimeRegistrationId",
                keyValue: 374,
                columns: new[] { "EndTime", "StartTime" },
                values: new object[] { new DateTime(2024, 5, 3, 18, 11, 7, 0, DateTimeKind.Unspecified), new DateTime(2024, 10, 23, 12, 26, 25, 0, DateTimeKind.Unspecified) });

            migrationBuilder.UpdateData(
                table: "TimeRegistrations",
                keyColumn: "TimeRegistrationId",
                keyValue: 375,
                columns: new[] { "EndTime", "StartTime" },
                values: new object[] { new DateTime(2024, 1, 25, 1, 3, 39, 0, DateTimeKind.Unspecified), new DateTime(2024, 10, 16, 5, 19, 58, 0, DateTimeKind.Unspecified) });

            migrationBuilder.UpdateData(
                table: "TimeRegistrations",
                keyColumn: "TimeRegistrationId",
                keyValue: 376,
                columns: new[] { "EndTime", "StartTime" },
                values: new object[] { new DateTime(2024, 9, 19, 4, 58, 27, 0, DateTimeKind.Unspecified), new DateTime(2024, 12, 30, 0, 39, 18, 0, DateTimeKind.Unspecified) });

            migrationBuilder.UpdateData(
                table: "TimeRegistrations",
                keyColumn: "TimeRegistrationId",
                keyValue: 377,
                columns: new[] { "EndTime", "StartTime" },
                values: new object[] { new DateTime(2024, 8, 7, 12, 5, 59, 0, DateTimeKind.Unspecified), new DateTime(2024, 7, 21, 22, 33, 32, 0, DateTimeKind.Unspecified) });

            migrationBuilder.UpdateData(
                table: "TimeRegistrations",
                keyColumn: "TimeRegistrationId",
                keyValue: 378,
                columns: new[] { "EndTime", "StartTime" },
                values: new object[] { new DateTime(2024, 4, 29, 17, 45, 9, 0, DateTimeKind.Unspecified), new DateTime(2024, 12, 29, 0, 35, 37, 0, DateTimeKind.Unspecified) });

            migrationBuilder.UpdateData(
                table: "TimeRegistrations",
                keyColumn: "TimeRegistrationId",
                keyValue: 379,
                columns: new[] { "EndTime", "StartTime" },
                values: new object[] { new DateTime(2024, 10, 21, 23, 17, 58, 0, DateTimeKind.Unspecified), new DateTime(2024, 4, 8, 2, 57, 15, 0, DateTimeKind.Unspecified) });

            migrationBuilder.UpdateData(
                table: "TimeRegistrations",
                keyColumn: "TimeRegistrationId",
                keyValue: 380,
                columns: new[] { "EndTime", "StartTime" },
                values: new object[] { new DateTime(2024, 5, 16, 5, 7, 43, 0, DateTimeKind.Unspecified), new DateTime(2024, 1, 18, 0, 39, 50, 0, DateTimeKind.Unspecified) });

            migrationBuilder.UpdateData(
                table: "TimeRegistrations",
                keyColumn: "TimeRegistrationId",
                keyValue: 381,
                columns: new[] { "EndTime", "StartTime" },
                values: new object[] { new DateTime(2024, 3, 8, 4, 33, 11, 0, DateTimeKind.Unspecified), new DateTime(2024, 1, 12, 8, 9, 4, 0, DateTimeKind.Unspecified) });

            migrationBuilder.UpdateData(
                table: "TimeRegistrations",
                keyColumn: "TimeRegistrationId",
                keyValue: 382,
                columns: new[] { "EndTime", "StartTime" },
                values: new object[] { new DateTime(2024, 6, 23, 3, 24, 6, 0, DateTimeKind.Unspecified), new DateTime(2024, 9, 11, 12, 8, 46, 0, DateTimeKind.Unspecified) });

            migrationBuilder.UpdateData(
                table: "TimeRegistrations",
                keyColumn: "TimeRegistrationId",
                keyValue: 383,
                columns: new[] { "EndTime", "StartTime" },
                values: new object[] { new DateTime(2024, 6, 4, 2, 23, 53, 0, DateTimeKind.Unspecified), new DateTime(2024, 5, 13, 14, 11, 27, 0, DateTimeKind.Unspecified) });

            migrationBuilder.UpdateData(
                table: "TimeRegistrations",
                keyColumn: "TimeRegistrationId",
                keyValue: 384,
                columns: new[] { "EndTime", "StartTime" },
                values: new object[] { new DateTime(2024, 12, 12, 7, 17, 36, 0, DateTimeKind.Unspecified), new DateTime(2024, 3, 4, 4, 55, 56, 0, DateTimeKind.Unspecified) });

            migrationBuilder.UpdateData(
                table: "TimeRegistrations",
                keyColumn: "TimeRegistrationId",
                keyValue: 385,
                columns: new[] { "EndTime", "StartTime" },
                values: new object[] { new DateTime(2024, 7, 27, 17, 48, 51, 0, DateTimeKind.Unspecified), new DateTime(2024, 6, 12, 20, 53, 20, 0, DateTimeKind.Unspecified) });

            migrationBuilder.UpdateData(
                table: "TimeRegistrations",
                keyColumn: "TimeRegistrationId",
                keyValue: 386,
                columns: new[] { "EndTime", "StartTime" },
                values: new object[] { new DateTime(2024, 3, 12, 23, 24, 33, 0, DateTimeKind.Unspecified), new DateTime(2024, 6, 5, 3, 23, 37, 0, DateTimeKind.Unspecified) });

            migrationBuilder.UpdateData(
                table: "TimeRegistrations",
                keyColumn: "TimeRegistrationId",
                keyValue: 387,
                columns: new[] { "EndTime", "StartTime" },
                values: new object[] { new DateTime(2024, 5, 19, 13, 13, 26, 0, DateTimeKind.Unspecified), new DateTime(2024, 4, 13, 8, 36, 26, 0, DateTimeKind.Unspecified) });

            migrationBuilder.UpdateData(
                table: "TimeRegistrations",
                keyColumn: "TimeRegistrationId",
                keyValue: 388,
                columns: new[] { "EndTime", "StartTime" },
                values: new object[] { new DateTime(2024, 10, 24, 22, 31, 3, 0, DateTimeKind.Unspecified), new DateTime(2024, 3, 27, 1, 0, 36, 0, DateTimeKind.Unspecified) });

            migrationBuilder.UpdateData(
                table: "TimeRegistrations",
                keyColumn: "TimeRegistrationId",
                keyValue: 389,
                columns: new[] { "EndTime", "StartTime" },
                values: new object[] { new DateTime(2024, 5, 5, 3, 48, 34, 0, DateTimeKind.Unspecified), new DateTime(2024, 3, 12, 18, 41, 28, 0, DateTimeKind.Unspecified) });

            migrationBuilder.UpdateData(
                table: "TimeRegistrations",
                keyColumn: "TimeRegistrationId",
                keyValue: 390,
                columns: new[] { "EndTime", "StartTime" },
                values: new object[] { new DateTime(2024, 9, 13, 12, 23, 47, 0, DateTimeKind.Unspecified), new DateTime(2024, 4, 15, 12, 6, 54, 0, DateTimeKind.Unspecified) });

            migrationBuilder.UpdateData(
                table: "TimeRegistrations",
                keyColumn: "TimeRegistrationId",
                keyValue: 391,
                columns: new[] { "EndTime", "StartTime" },
                values: new object[] { new DateTime(2024, 6, 7, 7, 42, 2, 0, DateTimeKind.Unspecified), new DateTime(2024, 5, 13, 16, 53, 47, 0, DateTimeKind.Unspecified) });

            migrationBuilder.UpdateData(
                table: "TimeRegistrations",
                keyColumn: "TimeRegistrationId",
                keyValue: 392,
                columns: new[] { "EndTime", "StartTime" },
                values: new object[] { new DateTime(2024, 6, 21, 5, 4, 2, 0, DateTimeKind.Unspecified), new DateTime(2024, 9, 27, 0, 44, 47, 0, DateTimeKind.Unspecified) });

            migrationBuilder.UpdateData(
                table: "TimeRegistrations",
                keyColumn: "TimeRegistrationId",
                keyValue: 393,
                columns: new[] { "EndTime", "StartTime" },
                values: new object[] { new DateTime(2024, 9, 27, 20, 35, 19, 0, DateTimeKind.Unspecified), new DateTime(2024, 4, 30, 5, 0, 21, 0, DateTimeKind.Unspecified) });

            migrationBuilder.UpdateData(
                table: "TimeRegistrations",
                keyColumn: "TimeRegistrationId",
                keyValue: 394,
                columns: new[] { "EndTime", "StartTime" },
                values: new object[] { new DateTime(2024, 8, 22, 20, 24, 39, 0, DateTimeKind.Unspecified), new DateTime(2024, 1, 9, 20, 17, 2, 0, DateTimeKind.Unspecified) });

            migrationBuilder.UpdateData(
                table: "TimeRegistrations",
                keyColumn: "TimeRegistrationId",
                keyValue: 395,
                columns: new[] { "EndTime", "StartTime" },
                values: new object[] { new DateTime(2024, 7, 5, 8, 25, 55, 0, DateTimeKind.Unspecified), new DateTime(2024, 11, 18, 19, 45, 20, 0, DateTimeKind.Unspecified) });

            migrationBuilder.UpdateData(
                table: "TimeRegistrations",
                keyColumn: "TimeRegistrationId",
                keyValue: 396,
                columns: new[] { "EndTime", "StartTime" },
                values: new object[] { new DateTime(2024, 7, 16, 19, 0, 19, 0, DateTimeKind.Unspecified), new DateTime(2024, 3, 27, 19, 58, 2, 0, DateTimeKind.Unspecified) });

            migrationBuilder.UpdateData(
                table: "TimeRegistrations",
                keyColumn: "TimeRegistrationId",
                keyValue: 397,
                columns: new[] { "EndTime", "StartTime" },
                values: new object[] { new DateTime(2024, 11, 13, 9, 13, 10, 0, DateTimeKind.Unspecified), new DateTime(2024, 11, 19, 1, 5, 7, 0, DateTimeKind.Unspecified) });

            migrationBuilder.UpdateData(
                table: "TimeRegistrations",
                keyColumn: "TimeRegistrationId",
                keyValue: 398,
                columns: new[] { "EndTime", "StartTime" },
                values: new object[] { new DateTime(2024, 6, 18, 20, 52, 39, 0, DateTimeKind.Unspecified), new DateTime(2024, 1, 25, 15, 32, 44, 0, DateTimeKind.Unspecified) });

            migrationBuilder.UpdateData(
                table: "TimeRegistrations",
                keyColumn: "TimeRegistrationId",
                keyValue: 399,
                columns: new[] { "EndTime", "StartTime" },
                values: new object[] { new DateTime(2024, 4, 13, 16, 21, 22, 0, DateTimeKind.Unspecified), new DateTime(2024, 7, 31, 12, 1, 10, 0, DateTimeKind.Unspecified) });

            migrationBuilder.UpdateData(
                table: "TimeRegistrations",
                keyColumn: "TimeRegistrationId",
                keyValue: 400,
                columns: new[] { "EndTime", "StartTime" },
                values: new object[] { new DateTime(2024, 12, 8, 7, 4, 4, 0, DateTimeKind.Unspecified), new DateTime(2024, 10, 27, 4, 52, 41, 0, DateTimeKind.Unspecified) });

            migrationBuilder.UpdateData(
                table: "TimeRegistrations",
                keyColumn: "TimeRegistrationId",
                keyValue: 401,
                columns: new[] { "EndTime", "StartTime" },
                values: new object[] { new DateTime(2024, 11, 6, 17, 10, 33, 0, DateTimeKind.Unspecified), new DateTime(2024, 11, 27, 8, 4, 59, 0, DateTimeKind.Unspecified) });

            migrationBuilder.UpdateData(
                table: "TimeRegistrations",
                keyColumn: "TimeRegistrationId",
                keyValue: 402,
                columns: new[] { "EndTime", "StartTime" },
                values: new object[] { new DateTime(2024, 5, 23, 0, 16, 44, 0, DateTimeKind.Unspecified), new DateTime(2024, 6, 4, 5, 0, 24, 0, DateTimeKind.Unspecified) });

            migrationBuilder.UpdateData(
                table: "TimeRegistrations",
                keyColumn: "TimeRegistrationId",
                keyValue: 403,
                columns: new[] { "EndTime", "StartTime" },
                values: new object[] { new DateTime(2024, 4, 9, 8, 10, 23, 0, DateTimeKind.Unspecified), new DateTime(2024, 4, 17, 16, 18, 29, 0, DateTimeKind.Unspecified) });

            migrationBuilder.UpdateData(
                table: "TimeRegistrations",
                keyColumn: "TimeRegistrationId",
                keyValue: 404,
                columns: new[] { "EndTime", "StartTime" },
                values: new object[] { new DateTime(2024, 9, 8, 3, 56, 17, 0, DateTimeKind.Unspecified), new DateTime(2024, 9, 27, 14, 47, 34, 0, DateTimeKind.Unspecified) });

            migrationBuilder.UpdateData(
                table: "TimeRegistrations",
                keyColumn: "TimeRegistrationId",
                keyValue: 405,
                columns: new[] { "EndTime", "StartTime" },
                values: new object[] { new DateTime(2024, 1, 20, 15, 46, 30, 0, DateTimeKind.Unspecified), new DateTime(2024, 1, 26, 4, 14, 31, 0, DateTimeKind.Unspecified) });

            migrationBuilder.UpdateData(
                table: "TimeRegistrations",
                keyColumn: "TimeRegistrationId",
                keyValue: 406,
                columns: new[] { "EndTime", "StartTime" },
                values: new object[] { new DateTime(2024, 10, 22, 21, 57, 13, 0, DateTimeKind.Unspecified), new DateTime(2024, 5, 15, 7, 53, 15, 0, DateTimeKind.Unspecified) });

            migrationBuilder.UpdateData(
                table: "TimeRegistrations",
                keyColumn: "TimeRegistrationId",
                keyValue: 407,
                columns: new[] { "EndTime", "StartTime" },
                values: new object[] { new DateTime(2024, 1, 30, 0, 58, 21, 0, DateTimeKind.Unspecified), new DateTime(2024, 1, 2, 7, 34, 32, 0, DateTimeKind.Unspecified) });

            migrationBuilder.UpdateData(
                table: "TimeRegistrations",
                keyColumn: "TimeRegistrationId",
                keyValue: 408,
                columns: new[] { "EndTime", "StartTime" },
                values: new object[] { new DateTime(2024, 7, 18, 5, 10, 42, 0, DateTimeKind.Unspecified), new DateTime(2024, 3, 26, 0, 43, 30, 0, DateTimeKind.Unspecified) });

            migrationBuilder.UpdateData(
                table: "TimeRegistrations",
                keyColumn: "TimeRegistrationId",
                keyValue: 409,
                columns: new[] { "EndTime", "StartTime" },
                values: new object[] { new DateTime(2024, 11, 30, 9, 56, 43, 0, DateTimeKind.Unspecified), new DateTime(2024, 1, 7, 2, 57, 41, 0, DateTimeKind.Unspecified) });

            migrationBuilder.UpdateData(
                table: "TimeRegistrations",
                keyColumn: "TimeRegistrationId",
                keyValue: 410,
                columns: new[] { "EndTime", "StartTime" },
                values: new object[] { new DateTime(2024, 1, 26, 22, 30, 13, 0, DateTimeKind.Unspecified), new DateTime(2024, 8, 12, 9, 35, 56, 0, DateTimeKind.Unspecified) });

            migrationBuilder.UpdateData(
                table: "TimeRegistrations",
                keyColumn: "TimeRegistrationId",
                keyValue: 411,
                columns: new[] { "EndTime", "StartTime" },
                values: new object[] { new DateTime(2024, 11, 17, 7, 45, 41, 0, DateTimeKind.Unspecified), new DateTime(2024, 10, 17, 22, 23, 34, 0, DateTimeKind.Unspecified) });

            migrationBuilder.UpdateData(
                table: "TimeRegistrations",
                keyColumn: "TimeRegistrationId",
                keyValue: 412,
                columns: new[] { "EndTime", "StartTime" },
                values: new object[] { new DateTime(2024, 1, 1, 16, 43, 45, 0, DateTimeKind.Unspecified), new DateTime(2024, 1, 2, 16, 1, 39, 0, DateTimeKind.Unspecified) });

            migrationBuilder.UpdateData(
                table: "TimeRegistrations",
                keyColumn: "TimeRegistrationId",
                keyValue: 413,
                columns: new[] { "EndTime", "StartTime" },
                values: new object[] { new DateTime(2024, 10, 19, 7, 11, 4, 0, DateTimeKind.Unspecified), new DateTime(2024, 12, 3, 23, 51, 52, 0, DateTimeKind.Unspecified) });

            migrationBuilder.UpdateData(
                table: "TimeRegistrations",
                keyColumn: "TimeRegistrationId",
                keyValue: 414,
                columns: new[] { "EndTime", "StartTime" },
                values: new object[] { new DateTime(2024, 8, 21, 14, 54, 34, 0, DateTimeKind.Unspecified), new DateTime(2024, 11, 10, 3, 25, 25, 0, DateTimeKind.Unspecified) });

            migrationBuilder.UpdateData(
                table: "TimeRegistrations",
                keyColumn: "TimeRegistrationId",
                keyValue: 415,
                columns: new[] { "EndTime", "StartTime" },
                values: new object[] { new DateTime(2024, 6, 28, 20, 6, 58, 0, DateTimeKind.Unspecified), new DateTime(2024, 1, 17, 8, 52, 10, 0, DateTimeKind.Unspecified) });

            migrationBuilder.UpdateData(
                table: "TimeRegistrations",
                keyColumn: "TimeRegistrationId",
                keyValue: 416,
                columns: new[] { "EndTime", "StartTime" },
                values: new object[] { new DateTime(2024, 11, 9, 11, 33, 4, 0, DateTimeKind.Unspecified), new DateTime(2024, 7, 15, 19, 35, 39, 0, DateTimeKind.Unspecified) });

            migrationBuilder.UpdateData(
                table: "TimeRegistrations",
                keyColumn: "TimeRegistrationId",
                keyValue: 417,
                columns: new[] { "EndTime", "StartTime" },
                values: new object[] { new DateTime(2024, 3, 27, 2, 43, 8, 0, DateTimeKind.Unspecified), new DateTime(2024, 1, 16, 21, 21, 25, 0, DateTimeKind.Unspecified) });

            migrationBuilder.UpdateData(
                table: "TimeRegistrations",
                keyColumn: "TimeRegistrationId",
                keyValue: 418,
                columns: new[] { "EndTime", "StartTime" },
                values: new object[] { new DateTime(2024, 9, 20, 16, 42, 25, 0, DateTimeKind.Unspecified), new DateTime(2024, 12, 22, 18, 0, 41, 0, DateTimeKind.Unspecified) });

            migrationBuilder.UpdateData(
                table: "TimeRegistrations",
                keyColumn: "TimeRegistrationId",
                keyValue: 419,
                columns: new[] { "EndTime", "StartTime" },
                values: new object[] { new DateTime(2024, 6, 28, 6, 33, 17, 0, DateTimeKind.Unspecified), new DateTime(2024, 9, 10, 10, 19, 42, 0, DateTimeKind.Unspecified) });

            migrationBuilder.UpdateData(
                table: "TimeRegistrations",
                keyColumn: "TimeRegistrationId",
                keyValue: 420,
                columns: new[] { "EndTime", "StartTime" },
                values: new object[] { new DateTime(2024, 1, 6, 2, 26, 38, 0, DateTimeKind.Unspecified), new DateTime(2024, 5, 23, 5, 38, 47, 0, DateTimeKind.Unspecified) });

            migrationBuilder.UpdateData(
                table: "TimeRegistrations",
                keyColumn: "TimeRegistrationId",
                keyValue: 421,
                columns: new[] { "EndTime", "StartTime" },
                values: new object[] { new DateTime(2024, 11, 9, 23, 56, 57, 0, DateTimeKind.Unspecified), new DateTime(2024, 10, 1, 6, 20, 0, 0, DateTimeKind.Unspecified) });

            migrationBuilder.UpdateData(
                table: "TimeRegistrations",
                keyColumn: "TimeRegistrationId",
                keyValue: 422,
                columns: new[] { "EndTime", "StartTime" },
                values: new object[] { new DateTime(2024, 9, 30, 12, 47, 13, 0, DateTimeKind.Unspecified), new DateTime(2024, 5, 10, 19, 37, 41, 0, DateTimeKind.Unspecified) });

            migrationBuilder.UpdateData(
                table: "TimeRegistrations",
                keyColumn: "TimeRegistrationId",
                keyValue: 423,
                columns: new[] { "EndTime", "StartTime" },
                values: new object[] { new DateTime(2024, 6, 13, 6, 11, 16, 0, DateTimeKind.Unspecified), new DateTime(2024, 5, 26, 10, 36, 42, 0, DateTimeKind.Unspecified) });

            migrationBuilder.UpdateData(
                table: "TimeRegistrations",
                keyColumn: "TimeRegistrationId",
                keyValue: 424,
                columns: new[] { "EndTime", "StartTime" },
                values: new object[] { new DateTime(2024, 12, 13, 18, 56, 39, 0, DateTimeKind.Unspecified), new DateTime(2024, 8, 10, 18, 17, 8, 0, DateTimeKind.Unspecified) });

            migrationBuilder.UpdateData(
                table: "TimeRegistrations",
                keyColumn: "TimeRegistrationId",
                keyValue: 425,
                columns: new[] { "EndTime", "StartTime" },
                values: new object[] { new DateTime(2024, 6, 10, 12, 23, 31, 0, DateTimeKind.Unspecified), new DateTime(2024, 7, 18, 22, 54, 18, 0, DateTimeKind.Unspecified) });

            migrationBuilder.UpdateData(
                table: "TimeRegistrations",
                keyColumn: "TimeRegistrationId",
                keyValue: 426,
                columns: new[] { "EndTime", "StartTime" },
                values: new object[] { new DateTime(2024, 1, 5, 17, 39, 18, 0, DateTimeKind.Unspecified), new DateTime(2024, 12, 5, 9, 5, 13, 0, DateTimeKind.Unspecified) });

            migrationBuilder.UpdateData(
                table: "TimeRegistrations",
                keyColumn: "TimeRegistrationId",
                keyValue: 427,
                columns: new[] { "EndTime", "StartTime" },
                values: new object[] { new DateTime(2024, 8, 5, 17, 27, 16, 0, DateTimeKind.Unspecified), new DateTime(2024, 4, 1, 4, 43, 17, 0, DateTimeKind.Unspecified) });

            migrationBuilder.UpdateData(
                table: "TimeRegistrations",
                keyColumn: "TimeRegistrationId",
                keyValue: 428,
                columns: new[] { "EndTime", "StartTime" },
                values: new object[] { new DateTime(2024, 1, 2, 4, 52, 43, 0, DateTimeKind.Unspecified), new DateTime(2024, 12, 5, 23, 16, 28, 0, DateTimeKind.Unspecified) });

            migrationBuilder.UpdateData(
                table: "TimeRegistrations",
                keyColumn: "TimeRegistrationId",
                keyValue: 429,
                columns: new[] { "EndTime", "StartTime" },
                values: new object[] { new DateTime(2024, 11, 21, 4, 39, 2, 0, DateTimeKind.Unspecified), new DateTime(2024, 6, 13, 19, 42, 0, 0, DateTimeKind.Unspecified) });

            migrationBuilder.UpdateData(
                table: "TimeRegistrations",
                keyColumn: "TimeRegistrationId",
                keyValue: 430,
                columns: new[] { "EndTime", "StartTime" },
                values: new object[] { new DateTime(2024, 10, 28, 8, 20, 0, 0, DateTimeKind.Unspecified), new DateTime(2024, 5, 3, 17, 10, 33, 0, DateTimeKind.Unspecified) });

            migrationBuilder.UpdateData(
                table: "TimeRegistrations",
                keyColumn: "TimeRegistrationId",
                keyValue: 431,
                columns: new[] { "EndTime", "StartTime" },
                values: new object[] { new DateTime(2024, 10, 28, 18, 50, 9, 0, DateTimeKind.Unspecified), new DateTime(2024, 1, 1, 15, 54, 19, 0, DateTimeKind.Unspecified) });

            migrationBuilder.UpdateData(
                table: "TimeRegistrations",
                keyColumn: "TimeRegistrationId",
                keyValue: 432,
                columns: new[] { "EndTime", "StartTime" },
                values: new object[] { new DateTime(2024, 3, 7, 11, 19, 11, 0, DateTimeKind.Unspecified), new DateTime(2024, 10, 21, 16, 37, 17, 0, DateTimeKind.Unspecified) });

            migrationBuilder.UpdateData(
                table: "TimeRegistrations",
                keyColumn: "TimeRegistrationId",
                keyValue: 433,
                columns: new[] { "EndTime", "StartTime" },
                values: new object[] { new DateTime(2024, 5, 24, 0, 24, 36, 0, DateTimeKind.Unspecified), new DateTime(2024, 2, 29, 0, 26, 54, 0, DateTimeKind.Unspecified) });

            migrationBuilder.UpdateData(
                table: "TimeRegistrations",
                keyColumn: "TimeRegistrationId",
                keyValue: 434,
                columns: new[] { "EndTime", "StartTime" },
                values: new object[] { new DateTime(2024, 12, 24, 16, 21, 2, 0, DateTimeKind.Unspecified), new DateTime(2024, 1, 28, 19, 35, 8, 0, DateTimeKind.Unspecified) });

            migrationBuilder.UpdateData(
                table: "TimeRegistrations",
                keyColumn: "TimeRegistrationId",
                keyValue: 435,
                columns: new[] { "EndTime", "StartTime" },
                values: new object[] { new DateTime(2024, 9, 21, 11, 8, 16, 0, DateTimeKind.Unspecified), new DateTime(2024, 4, 16, 4, 59, 21, 0, DateTimeKind.Unspecified) });

            migrationBuilder.UpdateData(
                table: "TimeRegistrations",
                keyColumn: "TimeRegistrationId",
                keyValue: 436,
                columns: new[] { "EndTime", "StartTime" },
                values: new object[] { new DateTime(2024, 3, 21, 20, 14, 27, 0, DateTimeKind.Unspecified), new DateTime(2024, 7, 11, 23, 21, 44, 0, DateTimeKind.Unspecified) });

            migrationBuilder.UpdateData(
                table: "TimeRegistrations",
                keyColumn: "TimeRegistrationId",
                keyValue: 437,
                columns: new[] { "EndTime", "StartTime" },
                values: new object[] { new DateTime(2024, 9, 15, 11, 39, 30, 0, DateTimeKind.Unspecified), new DateTime(2024, 11, 6, 11, 24, 39, 0, DateTimeKind.Unspecified) });

            migrationBuilder.UpdateData(
                table: "TimeRegistrations",
                keyColumn: "TimeRegistrationId",
                keyValue: 438,
                columns: new[] { "EndTime", "StartTime" },
                values: new object[] { new DateTime(2024, 2, 28, 4, 48, 2, 0, DateTimeKind.Unspecified), new DateTime(2024, 10, 30, 2, 37, 31, 0, DateTimeKind.Unspecified) });

            migrationBuilder.UpdateData(
                table: "TimeRegistrations",
                keyColumn: "TimeRegistrationId",
                keyValue: 439,
                columns: new[] { "EndTime", "StartTime" },
                values: new object[] { new DateTime(2024, 7, 1, 16, 9, 59, 0, DateTimeKind.Unspecified), new DateTime(2024, 12, 8, 14, 42, 57, 0, DateTimeKind.Unspecified) });

            migrationBuilder.UpdateData(
                table: "TimeRegistrations",
                keyColumn: "TimeRegistrationId",
                keyValue: 440,
                columns: new[] { "EndTime", "StartTime" },
                values: new object[] { new DateTime(2024, 5, 9, 5, 8, 12, 0, DateTimeKind.Unspecified), new DateTime(2024, 1, 25, 19, 53, 5, 0, DateTimeKind.Unspecified) });

            migrationBuilder.UpdateData(
                table: "TimeRegistrations",
                keyColumn: "TimeRegistrationId",
                keyValue: 441,
                columns: new[] { "EndTime", "StartTime" },
                values: new object[] { new DateTime(2024, 11, 12, 1, 53, 11, 0, DateTimeKind.Unspecified), new DateTime(2024, 8, 22, 8, 50, 21, 0, DateTimeKind.Unspecified) });

            migrationBuilder.UpdateData(
                table: "TimeRegistrations",
                keyColumn: "TimeRegistrationId",
                keyValue: 442,
                columns: new[] { "EndTime", "StartTime" },
                values: new object[] { new DateTime(2024, 9, 9, 14, 41, 28, 0, DateTimeKind.Unspecified), new DateTime(2024, 4, 4, 18, 4, 15, 0, DateTimeKind.Unspecified) });

            migrationBuilder.UpdateData(
                table: "TimeRegistrations",
                keyColumn: "TimeRegistrationId",
                keyValue: 443,
                columns: new[] { "EndTime", "StartTime" },
                values: new object[] { new DateTime(2024, 5, 30, 1, 48, 47, 0, DateTimeKind.Unspecified), new DateTime(2024, 7, 2, 0, 15, 28, 0, DateTimeKind.Unspecified) });

            migrationBuilder.UpdateData(
                table: "TimeRegistrations",
                keyColumn: "TimeRegistrationId",
                keyValue: 444,
                columns: new[] { "EndTime", "StartTime" },
                values: new object[] { new DateTime(2024, 7, 30, 17, 42, 38, 0, DateTimeKind.Unspecified), new DateTime(2024, 9, 27, 18, 1, 15, 0, DateTimeKind.Unspecified) });

            migrationBuilder.UpdateData(
                table: "TimeRegistrations",
                keyColumn: "TimeRegistrationId",
                keyValue: 445,
                columns: new[] { "EndTime", "StartTime" },
                values: new object[] { new DateTime(2024, 1, 27, 23, 21, 58, 0, DateTimeKind.Unspecified), new DateTime(2024, 10, 8, 16, 50, 28, 0, DateTimeKind.Unspecified) });

            migrationBuilder.UpdateData(
                table: "TimeRegistrations",
                keyColumn: "TimeRegistrationId",
                keyValue: 446,
                columns: new[] { "EndTime", "StartTime" },
                values: new object[] { new DateTime(2024, 12, 8, 22, 52, 38, 0, DateTimeKind.Unspecified), new DateTime(2024, 1, 15, 13, 16, 24, 0, DateTimeKind.Unspecified) });

            migrationBuilder.UpdateData(
                table: "TimeRegistrations",
                keyColumn: "TimeRegistrationId",
                keyValue: 447,
                columns: new[] { "EndTime", "StartTime" },
                values: new object[] { new DateTime(2024, 4, 12, 18, 4, 24, 0, DateTimeKind.Unspecified), new DateTime(2024, 3, 22, 1, 9, 20, 0, DateTimeKind.Unspecified) });

            migrationBuilder.UpdateData(
                table: "TimeRegistrations",
                keyColumn: "TimeRegistrationId",
                keyValue: 448,
                columns: new[] { "EndTime", "StartTime" },
                values: new object[] { new DateTime(2024, 6, 22, 10, 20, 23, 0, DateTimeKind.Unspecified), new DateTime(2024, 8, 17, 10, 35, 17, 0, DateTimeKind.Unspecified) });

            migrationBuilder.UpdateData(
                table: "TimeRegistrations",
                keyColumn: "TimeRegistrationId",
                keyValue: 449,
                columns: new[] { "EndTime", "StartTime" },
                values: new object[] { new DateTime(2024, 3, 5, 23, 4, 28, 0, DateTimeKind.Unspecified), new DateTime(2024, 9, 16, 21, 18, 23, 0, DateTimeKind.Unspecified) });

            migrationBuilder.UpdateData(
                table: "TimeRegistrations",
                keyColumn: "TimeRegistrationId",
                keyValue: 450,
                columns: new[] { "EndTime", "StartTime" },
                values: new object[] { new DateTime(2024, 4, 14, 15, 23, 50, 0, DateTimeKind.Unspecified), new DateTime(2024, 9, 6, 9, 48, 53, 0, DateTimeKind.Unspecified) });

            migrationBuilder.UpdateData(
                table: "TimeRegistrations",
                keyColumn: "TimeRegistrationId",
                keyValue: 451,
                columns: new[] { "EndTime", "StartTime" },
                values: new object[] { new DateTime(2024, 9, 19, 10, 3, 32, 0, DateTimeKind.Unspecified), new DateTime(2024, 4, 7, 6, 46, 17, 0, DateTimeKind.Unspecified) });

            migrationBuilder.UpdateData(
                table: "TimeRegistrations",
                keyColumn: "TimeRegistrationId",
                keyValue: 452,
                columns: new[] { "EndTime", "StartTime" },
                values: new object[] { new DateTime(2024, 8, 13, 6, 52, 14, 0, DateTimeKind.Unspecified), new DateTime(2024, 2, 4, 5, 32, 30, 0, DateTimeKind.Unspecified) });

            migrationBuilder.UpdateData(
                table: "TimeRegistrations",
                keyColumn: "TimeRegistrationId",
                keyValue: 453,
                columns: new[] { "EndTime", "StartTime" },
                values: new object[] { new DateTime(2024, 8, 12, 8, 53, 19, 0, DateTimeKind.Unspecified), new DateTime(2024, 3, 2, 3, 16, 2, 0, DateTimeKind.Unspecified) });

            migrationBuilder.UpdateData(
                table: "TimeRegistrations",
                keyColumn: "TimeRegistrationId",
                keyValue: 454,
                columns: new[] { "EndTime", "StartTime" },
                values: new object[] { new DateTime(2024, 11, 20, 6, 12, 5, 0, DateTimeKind.Unspecified), new DateTime(2024, 10, 15, 12, 38, 14, 0, DateTimeKind.Unspecified) });

            migrationBuilder.UpdateData(
                table: "TimeRegistrations",
                keyColumn: "TimeRegistrationId",
                keyValue: 455,
                columns: new[] { "EndTime", "StartTime" },
                values: new object[] { new DateTime(2024, 2, 20, 20, 22, 34, 0, DateTimeKind.Unspecified), new DateTime(2024, 1, 18, 18, 35, 25, 0, DateTimeKind.Unspecified) });

            migrationBuilder.UpdateData(
                table: "TimeRegistrations",
                keyColumn: "TimeRegistrationId",
                keyValue: 456,
                columns: new[] { "EndTime", "StartTime" },
                values: new object[] { new DateTime(2024, 6, 10, 7, 7, 49, 0, DateTimeKind.Unspecified), new DateTime(2024, 8, 6, 6, 28, 50, 0, DateTimeKind.Unspecified) });

            migrationBuilder.UpdateData(
                table: "TimeRegistrations",
                keyColumn: "TimeRegistrationId",
                keyValue: 457,
                columns: new[] { "EndTime", "StartTime" },
                values: new object[] { new DateTime(2024, 4, 26, 21, 30, 19, 0, DateTimeKind.Unspecified), new DateTime(2024, 2, 6, 14, 54, 9, 0, DateTimeKind.Unspecified) });

            migrationBuilder.UpdateData(
                table: "TimeRegistrations",
                keyColumn: "TimeRegistrationId",
                keyValue: 458,
                columns: new[] { "EndTime", "StartTime" },
                values: new object[] { new DateTime(2024, 1, 16, 8, 15, 19, 0, DateTimeKind.Unspecified), new DateTime(2024, 11, 13, 13, 5, 33, 0, DateTimeKind.Unspecified) });

            migrationBuilder.UpdateData(
                table: "TimeRegistrations",
                keyColumn: "TimeRegistrationId",
                keyValue: 459,
                columns: new[] { "EndTime", "StartTime" },
                values: new object[] { new DateTime(2024, 10, 14, 11, 35, 54, 0, DateTimeKind.Unspecified), new DateTime(2024, 8, 5, 9, 39, 5, 0, DateTimeKind.Unspecified) });

            migrationBuilder.UpdateData(
                table: "TimeRegistrations",
                keyColumn: "TimeRegistrationId",
                keyValue: 460,
                columns: new[] { "EndTime", "StartTime" },
                values: new object[] { new DateTime(2024, 6, 11, 14, 19, 42, 0, DateTimeKind.Unspecified), new DateTime(2024, 11, 20, 8, 50, 37, 0, DateTimeKind.Unspecified) });

            migrationBuilder.UpdateData(
                table: "TimeRegistrations",
                keyColumn: "TimeRegistrationId",
                keyValue: 461,
                columns: new[] { "EndTime", "StartTime" },
                values: new object[] { new DateTime(2024, 9, 23, 7, 53, 7, 0, DateTimeKind.Unspecified), new DateTime(2024, 1, 22, 12, 49, 0, 0, DateTimeKind.Unspecified) });

            migrationBuilder.UpdateData(
                table: "TimeRegistrations",
                keyColumn: "TimeRegistrationId",
                keyValue: 462,
                columns: new[] { "EndTime", "StartTime" },
                values: new object[] { new DateTime(2024, 1, 7, 23, 33, 55, 0, DateTimeKind.Unspecified), new DateTime(2024, 1, 10, 21, 11, 14, 0, DateTimeKind.Unspecified) });

            migrationBuilder.UpdateData(
                table: "TimeRegistrations",
                keyColumn: "TimeRegistrationId",
                keyValue: 463,
                columns: new[] { "EndTime", "StartTime" },
                values: new object[] { new DateTime(2024, 7, 26, 19, 23, 52, 0, DateTimeKind.Unspecified), new DateTime(2024, 11, 10, 14, 21, 2, 0, DateTimeKind.Unspecified) });

            migrationBuilder.UpdateData(
                table: "TimeRegistrations",
                keyColumn: "TimeRegistrationId",
                keyValue: 464,
                columns: new[] { "EndTime", "StartTime" },
                values: new object[] { new DateTime(2024, 12, 29, 13, 49, 25, 0, DateTimeKind.Unspecified), new DateTime(2024, 2, 28, 15, 2, 18, 0, DateTimeKind.Unspecified) });

            migrationBuilder.UpdateData(
                table: "TimeRegistrations",
                keyColumn: "TimeRegistrationId",
                keyValue: 465,
                columns: new[] { "EndTime", "StartTime" },
                values: new object[] { new DateTime(2024, 5, 17, 9, 13, 54, 0, DateTimeKind.Unspecified), new DateTime(2024, 6, 17, 2, 26, 40, 0, DateTimeKind.Unspecified) });

            migrationBuilder.UpdateData(
                table: "TimeRegistrations",
                keyColumn: "TimeRegistrationId",
                keyValue: 466,
                columns: new[] { "EndTime", "StartTime" },
                values: new object[] { new DateTime(2024, 7, 5, 4, 43, 29, 0, DateTimeKind.Unspecified), new DateTime(2024, 9, 25, 9, 42, 27, 0, DateTimeKind.Unspecified) });

            migrationBuilder.UpdateData(
                table: "TimeRegistrations",
                keyColumn: "TimeRegistrationId",
                keyValue: 467,
                columns: new[] { "EndTime", "StartTime" },
                values: new object[] { new DateTime(2024, 6, 14, 23, 17, 12, 0, DateTimeKind.Unspecified), new DateTime(2024, 8, 13, 4, 27, 49, 0, DateTimeKind.Unspecified) });

            migrationBuilder.UpdateData(
                table: "TimeRegistrations",
                keyColumn: "TimeRegistrationId",
                keyValue: 468,
                columns: new[] { "EndTime", "StartTime" },
                values: new object[] { new DateTime(2024, 8, 15, 19, 0, 27, 0, DateTimeKind.Unspecified), new DateTime(2024, 3, 3, 0, 39, 21, 0, DateTimeKind.Unspecified) });

            migrationBuilder.UpdateData(
                table: "TimeRegistrations",
                keyColumn: "TimeRegistrationId",
                keyValue: 469,
                columns: new[] { "EndTime", "StartTime" },
                values: new object[] { new DateTime(2024, 9, 22, 1, 15, 57, 0, DateTimeKind.Unspecified), new DateTime(2024, 8, 30, 14, 16, 28, 0, DateTimeKind.Unspecified) });

            migrationBuilder.UpdateData(
                table: "TimeRegistrations",
                keyColumn: "TimeRegistrationId",
                keyValue: 470,
                columns: new[] { "EndTime", "StartTime" },
                values: new object[] { new DateTime(2024, 10, 31, 18, 5, 6, 0, DateTimeKind.Unspecified), new DateTime(2024, 11, 8, 7, 17, 46, 0, DateTimeKind.Unspecified) });

            migrationBuilder.UpdateData(
                table: "TimeRegistrations",
                keyColumn: "TimeRegistrationId",
                keyValue: 471,
                columns: new[] { "EndTime", "StartTime" },
                values: new object[] { new DateTime(2024, 6, 16, 8, 55, 3, 0, DateTimeKind.Unspecified), new DateTime(2024, 7, 29, 15, 7, 16, 0, DateTimeKind.Unspecified) });

            migrationBuilder.UpdateData(
                table: "TimeRegistrations",
                keyColumn: "TimeRegistrationId",
                keyValue: 472,
                columns: new[] { "EndTime", "StartTime" },
                values: new object[] { new DateTime(2024, 7, 8, 7, 50, 53, 0, DateTimeKind.Unspecified), new DateTime(2024, 9, 5, 2, 52, 58, 0, DateTimeKind.Unspecified) });

            migrationBuilder.UpdateData(
                table: "TimeRegistrations",
                keyColumn: "TimeRegistrationId",
                keyValue: 473,
                columns: new[] { "EndTime", "StartTime" },
                values: new object[] { new DateTime(2024, 8, 2, 12, 58, 47, 0, DateTimeKind.Unspecified), new DateTime(2024, 11, 30, 4, 11, 30, 0, DateTimeKind.Unspecified) });

            migrationBuilder.UpdateData(
                table: "TimeRegistrations",
                keyColumn: "TimeRegistrationId",
                keyValue: 474,
                columns: new[] { "EndTime", "StartTime" },
                values: new object[] { new DateTime(2024, 6, 3, 1, 50, 49, 0, DateTimeKind.Unspecified), new DateTime(2024, 1, 22, 3, 25, 37, 0, DateTimeKind.Unspecified) });

            migrationBuilder.UpdateData(
                table: "TimeRegistrations",
                keyColumn: "TimeRegistrationId",
                keyValue: 475,
                columns: new[] { "EndTime", "StartTime" },
                values: new object[] { new DateTime(2024, 5, 23, 13, 38, 18, 0, DateTimeKind.Unspecified), new DateTime(2024, 2, 11, 19, 12, 17, 0, DateTimeKind.Unspecified) });

            migrationBuilder.UpdateData(
                table: "TimeRegistrations",
                keyColumn: "TimeRegistrationId",
                keyValue: 476,
                columns: new[] { "EndTime", "StartTime" },
                values: new object[] { new DateTime(2024, 8, 28, 1, 35, 52, 0, DateTimeKind.Unspecified), new DateTime(2024, 4, 27, 22, 58, 43, 0, DateTimeKind.Unspecified) });

            migrationBuilder.UpdateData(
                table: "TimeRegistrations",
                keyColumn: "TimeRegistrationId",
                keyValue: 477,
                columns: new[] { "EndTime", "StartTime" },
                values: new object[] { new DateTime(2024, 12, 9, 21, 35, 4, 0, DateTimeKind.Unspecified), new DateTime(2024, 9, 8, 16, 2, 25, 0, DateTimeKind.Unspecified) });

            migrationBuilder.UpdateData(
                table: "TimeRegistrations",
                keyColumn: "TimeRegistrationId",
                keyValue: 478,
                columns: new[] { "EndTime", "StartTime" },
                values: new object[] { new DateTime(2024, 7, 31, 11, 25, 49, 0, DateTimeKind.Unspecified), new DateTime(2024, 8, 27, 4, 3, 19, 0, DateTimeKind.Unspecified) });

            migrationBuilder.UpdateData(
                table: "TimeRegistrations",
                keyColumn: "TimeRegistrationId",
                keyValue: 479,
                columns: new[] { "EndTime", "StartTime" },
                values: new object[] { new DateTime(2024, 4, 2, 2, 46, 7, 0, DateTimeKind.Unspecified), new DateTime(2024, 9, 30, 23, 23, 27, 0, DateTimeKind.Unspecified) });

            migrationBuilder.UpdateData(
                table: "TimeRegistrations",
                keyColumn: "TimeRegistrationId",
                keyValue: 480,
                columns: new[] { "EndTime", "StartTime" },
                values: new object[] { new DateTime(2024, 9, 9, 13, 26, 34, 0, DateTimeKind.Unspecified), new DateTime(2024, 4, 22, 22, 15, 14, 0, DateTimeKind.Unspecified) });

            migrationBuilder.UpdateData(
                table: "TimeRegistrations",
                keyColumn: "TimeRegistrationId",
                keyValue: 481,
                columns: new[] { "EndTime", "StartTime" },
                values: new object[] { new DateTime(2024, 4, 22, 1, 22, 17, 0, DateTimeKind.Unspecified), new DateTime(2024, 7, 5, 5, 19, 4, 0, DateTimeKind.Unspecified) });

            migrationBuilder.UpdateData(
                table: "TimeRegistrations",
                keyColumn: "TimeRegistrationId",
                keyValue: 482,
                columns: new[] { "EndTime", "StartTime" },
                values: new object[] { new DateTime(2024, 9, 15, 7, 18, 58, 0, DateTimeKind.Unspecified), new DateTime(2024, 6, 15, 10, 55, 7, 0, DateTimeKind.Unspecified) });

            migrationBuilder.UpdateData(
                table: "TimeRegistrations",
                keyColumn: "TimeRegistrationId",
                keyValue: 483,
                columns: new[] { "EndTime", "StartTime" },
                values: new object[] { new DateTime(2024, 3, 13, 1, 2, 21, 0, DateTimeKind.Unspecified), new DateTime(2024, 7, 25, 3, 22, 46, 0, DateTimeKind.Unspecified) });

            migrationBuilder.UpdateData(
                table: "TimeRegistrations",
                keyColumn: "TimeRegistrationId",
                keyValue: 484,
                columns: new[] { "EndTime", "StartTime" },
                values: new object[] { new DateTime(2024, 10, 13, 22, 51, 54, 0, DateTimeKind.Unspecified), new DateTime(2024, 4, 27, 8, 10, 24, 0, DateTimeKind.Unspecified) });

            migrationBuilder.UpdateData(
                table: "TimeRegistrations",
                keyColumn: "TimeRegistrationId",
                keyValue: 485,
                columns: new[] { "EndTime", "StartTime" },
                values: new object[] { new DateTime(2024, 10, 13, 2, 51, 41, 0, DateTimeKind.Unspecified), new DateTime(2024, 8, 8, 0, 32, 23, 0, DateTimeKind.Unspecified) });

            migrationBuilder.UpdateData(
                table: "TimeRegistrations",
                keyColumn: "TimeRegistrationId",
                keyValue: 486,
                columns: new[] { "EndTime", "StartTime" },
                values: new object[] { new DateTime(2024, 2, 7, 10, 29, 37, 0, DateTimeKind.Unspecified), new DateTime(2024, 12, 25, 9, 13, 57, 0, DateTimeKind.Unspecified) });

            migrationBuilder.UpdateData(
                table: "TimeRegistrations",
                keyColumn: "TimeRegistrationId",
                keyValue: 487,
                columns: new[] { "EndTime", "StartTime" },
                values: new object[] { new DateTime(2024, 4, 19, 22, 47, 7, 0, DateTimeKind.Unspecified), new DateTime(2024, 7, 27, 18, 55, 22, 0, DateTimeKind.Unspecified) });

            migrationBuilder.UpdateData(
                table: "TimeRegistrations",
                keyColumn: "TimeRegistrationId",
                keyValue: 488,
                columns: new[] { "EndTime", "StartTime" },
                values: new object[] { new DateTime(2024, 9, 4, 0, 42, 26, 0, DateTimeKind.Unspecified), new DateTime(2024, 2, 12, 6, 4, 11, 0, DateTimeKind.Unspecified) });

            migrationBuilder.UpdateData(
                table: "TimeRegistrations",
                keyColumn: "TimeRegistrationId",
                keyValue: 489,
                columns: new[] { "EndTime", "StartTime" },
                values: new object[] { new DateTime(2024, 2, 19, 15, 44, 47, 0, DateTimeKind.Unspecified), new DateTime(2024, 2, 25, 7, 30, 57, 0, DateTimeKind.Unspecified) });

            migrationBuilder.UpdateData(
                table: "TimeRegistrations",
                keyColumn: "TimeRegistrationId",
                keyValue: 490,
                columns: new[] { "EndTime", "StartTime" },
                values: new object[] { new DateTime(2024, 11, 19, 5, 3, 59, 0, DateTimeKind.Unspecified), new DateTime(2024, 3, 29, 2, 59, 15, 0, DateTimeKind.Unspecified) });

            migrationBuilder.UpdateData(
                table: "TimeRegistrations",
                keyColumn: "TimeRegistrationId",
                keyValue: 491,
                columns: new[] { "EndTime", "StartTime" },
                values: new object[] { new DateTime(2024, 6, 29, 8, 29, 51, 0, DateTimeKind.Unspecified), new DateTime(2024, 7, 27, 8, 47, 43, 0, DateTimeKind.Unspecified) });

            migrationBuilder.UpdateData(
                table: "TimeRegistrations",
                keyColumn: "TimeRegistrationId",
                keyValue: 492,
                columns: new[] { "EndTime", "StartTime" },
                values: new object[] { new DateTime(2024, 7, 29, 19, 59, 8, 0, DateTimeKind.Unspecified), new DateTime(2024, 1, 27, 19, 39, 52, 0, DateTimeKind.Unspecified) });

            migrationBuilder.UpdateData(
                table: "TimeRegistrations",
                keyColumn: "TimeRegistrationId",
                keyValue: 493,
                columns: new[] { "EndTime", "StartTime" },
                values: new object[] { new DateTime(2024, 3, 8, 11, 15, 51, 0, DateTimeKind.Unspecified), new DateTime(2024, 7, 22, 11, 0, 28, 0, DateTimeKind.Unspecified) });

            migrationBuilder.UpdateData(
                table: "TimeRegistrations",
                keyColumn: "TimeRegistrationId",
                keyValue: 494,
                columns: new[] { "EndTime", "StartTime" },
                values: new object[] { new DateTime(2024, 10, 29, 7, 57, 26, 0, DateTimeKind.Unspecified), new DateTime(2024, 5, 13, 22, 36, 6, 0, DateTimeKind.Unspecified) });

            migrationBuilder.UpdateData(
                table: "TimeRegistrations",
                keyColumn: "TimeRegistrationId",
                keyValue: 495,
                columns: new[] { "EndTime", "StartTime" },
                values: new object[] { new DateTime(2024, 6, 30, 8, 4, 48, 0, DateTimeKind.Unspecified), new DateTime(2024, 4, 25, 6, 9, 9, 0, DateTimeKind.Unspecified) });

            migrationBuilder.UpdateData(
                table: "TimeRegistrations",
                keyColumn: "TimeRegistrationId",
                keyValue: 496,
                columns: new[] { "EndTime", "StartTime" },
                values: new object[] { new DateTime(2024, 8, 5, 17, 49, 37, 0, DateTimeKind.Unspecified), new DateTime(2024, 4, 22, 8, 20, 24, 0, DateTimeKind.Unspecified) });

            migrationBuilder.UpdateData(
                table: "TimeRegistrations",
                keyColumn: "TimeRegistrationId",
                keyValue: 497,
                columns: new[] { "EndTime", "StartTime" },
                values: new object[] { new DateTime(2024, 3, 23, 2, 20, 58, 0, DateTimeKind.Unspecified), new DateTime(2024, 3, 3, 3, 52, 20, 0, DateTimeKind.Unspecified) });

            migrationBuilder.UpdateData(
                table: "TimeRegistrations",
                keyColumn: "TimeRegistrationId",
                keyValue: 498,
                columns: new[] { "EndTime", "StartTime" },
                values: new object[] { new DateTime(2024, 4, 21, 17, 11, 14, 0, DateTimeKind.Unspecified), new DateTime(2024, 6, 9, 16, 28, 2, 0, DateTimeKind.Unspecified) });

            migrationBuilder.UpdateData(
                table: "TimeRegistrations",
                keyColumn: "TimeRegistrationId",
                keyValue: 499,
                columns: new[] { "EndTime", "StartTime" },
                values: new object[] { new DateTime(2024, 9, 26, 14, 45, 1, 0, DateTimeKind.Unspecified), new DateTime(2024, 6, 17, 6, 3, 55, 0, DateTimeKind.Unspecified) });

            migrationBuilder.UpdateData(
                table: "TimeRegistrations",
                keyColumn: "TimeRegistrationId",
                keyValue: 500,
                columns: new[] { "EndTime", "StartTime" },
                values: new object[] { new DateTime(2024, 2, 7, 14, 33, 16, 0, DateTimeKind.Unspecified), new DateTime(2024, 2, 10, 18, 46, 1, 0, DateTimeKind.Unspecified) });

            migrationBuilder.UpdateData(
                table: "TimeRegistrations",
                keyColumn: "TimeRegistrationId",
                keyValue: 501,
                columns: new[] { "EndTime", "StartTime" },
                values: new object[] { new DateTime(2024, 1, 2, 21, 26, 8, 0, DateTimeKind.Unspecified), new DateTime(2024, 2, 15, 16, 46, 4, 0, DateTimeKind.Unspecified) });

            migrationBuilder.UpdateData(
                table: "TimeRegistrations",
                keyColumn: "TimeRegistrationId",
                keyValue: 502,
                columns: new[] { "EndTime", "StartTime" },
                values: new object[] { new DateTime(2024, 1, 4, 17, 50, 31, 0, DateTimeKind.Unspecified), new DateTime(2024, 5, 13, 1, 19, 33, 0, DateTimeKind.Unspecified) });

            migrationBuilder.UpdateData(
                table: "TimeRegistrations",
                keyColumn: "TimeRegistrationId",
                keyValue: 503,
                columns: new[] { "EndTime", "StartTime" },
                values: new object[] { new DateTime(2024, 10, 29, 2, 24, 41, 0, DateTimeKind.Unspecified), new DateTime(2024, 3, 16, 21, 46, 20, 0, DateTimeKind.Unspecified) });

            migrationBuilder.UpdateData(
                table: "TimeRegistrations",
                keyColumn: "TimeRegistrationId",
                keyValue: 504,
                columns: new[] { "EndTime", "StartTime" },
                values: new object[] { new DateTime(2024, 4, 7, 18, 45, 35, 0, DateTimeKind.Unspecified), new DateTime(2024, 4, 29, 5, 54, 51, 0, DateTimeKind.Unspecified) });

            migrationBuilder.UpdateData(
                table: "TimeRegistrations",
                keyColumn: "TimeRegistrationId",
                keyValue: 505,
                columns: new[] { "EndTime", "StartTime" },
                values: new object[] { new DateTime(2024, 6, 10, 12, 26, 19, 0, DateTimeKind.Unspecified), new DateTime(2024, 3, 3, 19, 53, 37, 0, DateTimeKind.Unspecified) });

            migrationBuilder.UpdateData(
                table: "TimeRegistrations",
                keyColumn: "TimeRegistrationId",
                keyValue: 506,
                columns: new[] { "EndTime", "StartTime" },
                values: new object[] { new DateTime(2024, 7, 12, 1, 50, 3, 0, DateTimeKind.Unspecified), new DateTime(2024, 6, 13, 12, 26, 19, 0, DateTimeKind.Unspecified) });

            migrationBuilder.UpdateData(
                table: "TimeRegistrations",
                keyColumn: "TimeRegistrationId",
                keyValue: 507,
                columns: new[] { "EndTime", "StartTime" },
                values: new object[] { new DateTime(2024, 10, 27, 0, 24, 36, 0, DateTimeKind.Unspecified), new DateTime(2024, 2, 17, 12, 24, 26, 0, DateTimeKind.Unspecified) });

            migrationBuilder.UpdateData(
                table: "TimeRegistrations",
                keyColumn: "TimeRegistrationId",
                keyValue: 508,
                columns: new[] { "EndTime", "StartTime" },
                values: new object[] { new DateTime(2024, 8, 11, 3, 3, 20, 0, DateTimeKind.Unspecified), new DateTime(2024, 7, 15, 11, 11, 19, 0, DateTimeKind.Unspecified) });

            migrationBuilder.UpdateData(
                table: "TimeRegistrations",
                keyColumn: "TimeRegistrationId",
                keyValue: 509,
                columns: new[] { "EndTime", "StartTime" },
                values: new object[] { new DateTime(2024, 7, 15, 9, 9, 37, 0, DateTimeKind.Unspecified), new DateTime(2024, 5, 4, 16, 19, 31, 0, DateTimeKind.Unspecified) });

            migrationBuilder.UpdateData(
                table: "TimeRegistrations",
                keyColumn: "TimeRegistrationId",
                keyValue: 510,
                columns: new[] { "EndTime", "StartTime" },
                values: new object[] { new DateTime(2024, 7, 11, 13, 1, 19, 0, DateTimeKind.Unspecified), new DateTime(2024, 9, 4, 13, 47, 33, 0, DateTimeKind.Unspecified) });

            migrationBuilder.UpdateData(
                table: "TimeRegistrations",
                keyColumn: "TimeRegistrationId",
                keyValue: 511,
                columns: new[] { "EndTime", "StartTime" },
                values: new object[] { new DateTime(2024, 2, 4, 2, 59, 8, 0, DateTimeKind.Unspecified), new DateTime(2024, 12, 29, 19, 32, 16, 0, DateTimeKind.Unspecified) });

            migrationBuilder.UpdateData(
                table: "TimeRegistrations",
                keyColumn: "TimeRegistrationId",
                keyValue: 512,
                columns: new[] { "EndTime", "StartTime" },
                values: new object[] { new DateTime(2024, 5, 8, 10, 18, 38, 0, DateTimeKind.Unspecified), new DateTime(2024, 4, 11, 3, 32, 55, 0, DateTimeKind.Unspecified) });

            migrationBuilder.UpdateData(
                table: "TimeRegistrations",
                keyColumn: "TimeRegistrationId",
                keyValue: 513,
                columns: new[] { "EndTime", "StartTime" },
                values: new object[] { new DateTime(2024, 2, 6, 15, 48, 54, 0, DateTimeKind.Unspecified), new DateTime(2024, 4, 30, 20, 16, 14, 0, DateTimeKind.Unspecified) });

            migrationBuilder.UpdateData(
                table: "TimeRegistrations",
                keyColumn: "TimeRegistrationId",
                keyValue: 514,
                columns: new[] { "EndTime", "StartTime" },
                values: new object[] { new DateTime(2024, 8, 27, 15, 29, 39, 0, DateTimeKind.Unspecified), new DateTime(2024, 3, 14, 1, 50, 17, 0, DateTimeKind.Unspecified) });

            migrationBuilder.UpdateData(
                table: "TimeRegistrations",
                keyColumn: "TimeRegistrationId",
                keyValue: 515,
                columns: new[] { "EndTime", "StartTime" },
                values: new object[] { new DateTime(2024, 3, 21, 17, 37, 41, 0, DateTimeKind.Unspecified), new DateTime(2024, 12, 7, 2, 43, 0, 0, DateTimeKind.Unspecified) });

            migrationBuilder.UpdateData(
                table: "TimeRegistrations",
                keyColumn: "TimeRegistrationId",
                keyValue: 516,
                columns: new[] { "EndTime", "StartTime" },
                values: new object[] { new DateTime(2024, 8, 25, 9, 50, 18, 0, DateTimeKind.Unspecified), new DateTime(2024, 12, 18, 6, 52, 20, 0, DateTimeKind.Unspecified) });

            migrationBuilder.UpdateData(
                table: "TimeRegistrations",
                keyColumn: "TimeRegistrationId",
                keyValue: 517,
                columns: new[] { "EndTime", "StartTime" },
                values: new object[] { new DateTime(2024, 9, 18, 16, 25, 36, 0, DateTimeKind.Unspecified), new DateTime(2024, 11, 7, 10, 5, 56, 0, DateTimeKind.Unspecified) });

            migrationBuilder.UpdateData(
                table: "TimeRegistrations",
                keyColumn: "TimeRegistrationId",
                keyValue: 518,
                columns: new[] { "EndTime", "StartTime" },
                values: new object[] { new DateTime(2024, 8, 31, 4, 30, 32, 0, DateTimeKind.Unspecified), new DateTime(2024, 9, 10, 16, 32, 18, 0, DateTimeKind.Unspecified) });

            migrationBuilder.UpdateData(
                table: "TimeRegistrations",
                keyColumn: "TimeRegistrationId",
                keyValue: 519,
                columns: new[] { "EndTime", "StartTime" },
                values: new object[] { new DateTime(2024, 5, 26, 10, 47, 34, 0, DateTimeKind.Unspecified), new DateTime(2024, 11, 10, 11, 38, 51, 0, DateTimeKind.Unspecified) });

            migrationBuilder.UpdateData(
                table: "TimeRegistrations",
                keyColumn: "TimeRegistrationId",
                keyValue: 520,
                columns: new[] { "EndTime", "StartTime" },
                values: new object[] { new DateTime(2024, 11, 18, 21, 38, 36, 0, DateTimeKind.Unspecified), new DateTime(2024, 5, 11, 14, 10, 2, 0, DateTimeKind.Unspecified) });

            migrationBuilder.UpdateData(
                table: "TimeRegistrations",
                keyColumn: "TimeRegistrationId",
                keyValue: 521,
                columns: new[] { "EndTime", "StartTime" },
                values: new object[] { new DateTime(2024, 1, 16, 0, 37, 57, 0, DateTimeKind.Unspecified), new DateTime(2024, 3, 19, 6, 52, 18, 0, DateTimeKind.Unspecified) });

            migrationBuilder.UpdateData(
                table: "TimeRegistrations",
                keyColumn: "TimeRegistrationId",
                keyValue: 522,
                columns: new[] { "EndTime", "StartTime" },
                values: new object[] { new DateTime(2024, 3, 18, 4, 33, 33, 0, DateTimeKind.Unspecified), new DateTime(2024, 4, 28, 21, 12, 12, 0, DateTimeKind.Unspecified) });

            migrationBuilder.UpdateData(
                table: "TimeRegistrations",
                keyColumn: "TimeRegistrationId",
                keyValue: 523,
                columns: new[] { "EndTime", "StartTime" },
                values: new object[] { new DateTime(2024, 5, 24, 4, 25, 53, 0, DateTimeKind.Unspecified), new DateTime(2024, 10, 25, 8, 31, 25, 0, DateTimeKind.Unspecified) });

            migrationBuilder.UpdateData(
                table: "TimeRegistrations",
                keyColumn: "TimeRegistrationId",
                keyValue: 524,
                columns: new[] { "EndTime", "StartTime" },
                values: new object[] { new DateTime(2024, 9, 20, 2, 13, 56, 0, DateTimeKind.Unspecified), new DateTime(2024, 2, 7, 13, 37, 40, 0, DateTimeKind.Unspecified) });

            migrationBuilder.UpdateData(
                table: "TimeRegistrations",
                keyColumn: "TimeRegistrationId",
                keyValue: 525,
                columns: new[] { "EndTime", "StartTime" },
                values: new object[] { new DateTime(2024, 7, 7, 16, 9, 16, 0, DateTimeKind.Unspecified), new DateTime(2024, 2, 22, 7, 52, 34, 0, DateTimeKind.Unspecified) });

            migrationBuilder.UpdateData(
                table: "TimeRegistrations",
                keyColumn: "TimeRegistrationId",
                keyValue: 526,
                columns: new[] { "EndTime", "StartTime" },
                values: new object[] { new DateTime(2024, 4, 30, 19, 39, 59, 0, DateTimeKind.Unspecified), new DateTime(2024, 5, 4, 23, 57, 36, 0, DateTimeKind.Unspecified) });

            migrationBuilder.UpdateData(
                table: "TimeRegistrations",
                keyColumn: "TimeRegistrationId",
                keyValue: 527,
                columns: new[] { "EndTime", "StartTime" },
                values: new object[] { new DateTime(2024, 7, 19, 8, 7, 0, 0, DateTimeKind.Unspecified), new DateTime(2024, 7, 3, 2, 5, 45, 0, DateTimeKind.Unspecified) });

            migrationBuilder.UpdateData(
                table: "TimeRegistrations",
                keyColumn: "TimeRegistrationId",
                keyValue: 528,
                columns: new[] { "EndTime", "StartTime" },
                values: new object[] { new DateTime(2024, 11, 3, 4, 35, 50, 0, DateTimeKind.Unspecified), new DateTime(2024, 2, 18, 17, 40, 1, 0, DateTimeKind.Unspecified) });

            migrationBuilder.UpdateData(
                table: "TimeRegistrations",
                keyColumn: "TimeRegistrationId",
                keyValue: 529,
                columns: new[] { "EndTime", "StartTime" },
                values: new object[] { new DateTime(2024, 7, 7, 8, 59, 37, 0, DateTimeKind.Unspecified), new DateTime(2024, 4, 21, 5, 50, 40, 0, DateTimeKind.Unspecified) });

            migrationBuilder.UpdateData(
                table: "TimeRegistrations",
                keyColumn: "TimeRegistrationId",
                keyValue: 530,
                columns: new[] { "EndTime", "StartTime" },
                values: new object[] { new DateTime(2024, 7, 11, 9, 32, 17, 0, DateTimeKind.Unspecified), new DateTime(2024, 6, 6, 23, 34, 8, 0, DateTimeKind.Unspecified) });

            migrationBuilder.UpdateData(
                table: "TimeRegistrations",
                keyColumn: "TimeRegistrationId",
                keyValue: 531,
                columns: new[] { "EndTime", "StartTime" },
                values: new object[] { new DateTime(2024, 3, 12, 7, 12, 57, 0, DateTimeKind.Unspecified), new DateTime(2024, 5, 18, 5, 29, 17, 0, DateTimeKind.Unspecified) });

            migrationBuilder.UpdateData(
                table: "TimeRegistrations",
                keyColumn: "TimeRegistrationId",
                keyValue: 532,
                columns: new[] { "EndTime", "StartTime" },
                values: new object[] { new DateTime(2024, 7, 11, 21, 55, 13, 0, DateTimeKind.Unspecified), new DateTime(2024, 10, 23, 9, 35, 16, 0, DateTimeKind.Unspecified) });

            migrationBuilder.UpdateData(
                table: "TimeRegistrations",
                keyColumn: "TimeRegistrationId",
                keyValue: 533,
                columns: new[] { "EndTime", "StartTime" },
                values: new object[] { new DateTime(2024, 7, 21, 11, 16, 58, 0, DateTimeKind.Unspecified), new DateTime(2024, 12, 11, 21, 39, 43, 0, DateTimeKind.Unspecified) });

            migrationBuilder.UpdateData(
                table: "TimeRegistrations",
                keyColumn: "TimeRegistrationId",
                keyValue: 534,
                columns: new[] { "EndTime", "StartTime" },
                values: new object[] { new DateTime(2024, 9, 3, 4, 22, 31, 0, DateTimeKind.Unspecified), new DateTime(2024, 10, 13, 23, 4, 39, 0, DateTimeKind.Unspecified) });

            migrationBuilder.UpdateData(
                table: "TimeRegistrations",
                keyColumn: "TimeRegistrationId",
                keyValue: 535,
                columns: new[] { "EndTime", "StartTime" },
                values: new object[] { new DateTime(2024, 6, 27, 6, 41, 12, 0, DateTimeKind.Unspecified), new DateTime(2024, 1, 2, 21, 8, 44, 0, DateTimeKind.Unspecified) });

            migrationBuilder.UpdateData(
                table: "TimeRegistrations",
                keyColumn: "TimeRegistrationId",
                keyValue: 536,
                columns: new[] { "EndTime", "StartTime" },
                values: new object[] { new DateTime(2024, 2, 28, 19, 29, 32, 0, DateTimeKind.Unspecified), new DateTime(2024, 2, 25, 6, 53, 4, 0, DateTimeKind.Unspecified) });

            migrationBuilder.UpdateData(
                table: "TimeRegistrations",
                keyColumn: "TimeRegistrationId",
                keyValue: 537,
                columns: new[] { "EndTime", "StartTime" },
                values: new object[] { new DateTime(2024, 4, 12, 2, 51, 43, 0, DateTimeKind.Unspecified), new DateTime(2024, 11, 14, 9, 1, 46, 0, DateTimeKind.Unspecified) });

            migrationBuilder.UpdateData(
                table: "TimeRegistrations",
                keyColumn: "TimeRegistrationId",
                keyValue: 538,
                columns: new[] { "EndTime", "StartTime" },
                values: new object[] { new DateTime(2024, 12, 4, 14, 45, 29, 0, DateTimeKind.Unspecified), new DateTime(2024, 7, 21, 16, 20, 37, 0, DateTimeKind.Unspecified) });

            migrationBuilder.UpdateData(
                table: "TimeRegistrations",
                keyColumn: "TimeRegistrationId",
                keyValue: 539,
                columns: new[] { "EndTime", "StartTime" },
                values: new object[] { new DateTime(2024, 1, 17, 1, 36, 5, 0, DateTimeKind.Unspecified), new DateTime(2024, 8, 26, 1, 8, 27, 0, DateTimeKind.Unspecified) });

            migrationBuilder.UpdateData(
                table: "TimeRegistrations",
                keyColumn: "TimeRegistrationId",
                keyValue: 540,
                columns: new[] { "EndTime", "StartTime" },
                values: new object[] { new DateTime(2024, 12, 1, 3, 7, 51, 0, DateTimeKind.Unspecified), new DateTime(2024, 6, 4, 16, 54, 7, 0, DateTimeKind.Unspecified) });

            migrationBuilder.UpdateData(
                table: "TimeRegistrations",
                keyColumn: "TimeRegistrationId",
                keyValue: 541,
                columns: new[] { "EndTime", "StartTime" },
                values: new object[] { new DateTime(2024, 5, 18, 11, 19, 40, 0, DateTimeKind.Unspecified), new DateTime(2024, 10, 6, 16, 39, 15, 0, DateTimeKind.Unspecified) });

            migrationBuilder.UpdateData(
                table: "TimeRegistrations",
                keyColumn: "TimeRegistrationId",
                keyValue: 542,
                columns: new[] { "EndTime", "StartTime" },
                values: new object[] { new DateTime(2024, 7, 3, 4, 3, 11, 0, DateTimeKind.Unspecified), new DateTime(2024, 8, 10, 23, 43, 52, 0, DateTimeKind.Unspecified) });

            migrationBuilder.UpdateData(
                table: "TimeRegistrations",
                keyColumn: "TimeRegistrationId",
                keyValue: 543,
                columns: new[] { "EndTime", "StartTime" },
                values: new object[] { new DateTime(2024, 8, 2, 22, 19, 28, 0, DateTimeKind.Unspecified), new DateTime(2024, 9, 8, 20, 36, 28, 0, DateTimeKind.Unspecified) });

            migrationBuilder.UpdateData(
                table: "TimeRegistrations",
                keyColumn: "TimeRegistrationId",
                keyValue: 544,
                columns: new[] { "EndTime", "StartTime" },
                values: new object[] { new DateTime(2024, 5, 4, 21, 43, 54, 0, DateTimeKind.Unspecified), new DateTime(2024, 6, 19, 19, 2, 47, 0, DateTimeKind.Unspecified) });

            migrationBuilder.UpdateData(
                table: "TimeRegistrations",
                keyColumn: "TimeRegistrationId",
                keyValue: 545,
                columns: new[] { "EndTime", "StartTime" },
                values: new object[] { new DateTime(2024, 7, 14, 19, 28, 59, 0, DateTimeKind.Unspecified), new DateTime(2024, 9, 17, 21, 48, 34, 0, DateTimeKind.Unspecified) });

            migrationBuilder.UpdateData(
                table: "TimeRegistrations",
                keyColumn: "TimeRegistrationId",
                keyValue: 546,
                columns: new[] { "EndTime", "StartTime" },
                values: new object[] { new DateTime(2024, 12, 19, 9, 28, 15, 0, DateTimeKind.Unspecified), new DateTime(2024, 7, 5, 21, 27, 24, 0, DateTimeKind.Unspecified) });

            migrationBuilder.UpdateData(
                table: "TimeRegistrations",
                keyColumn: "TimeRegistrationId",
                keyValue: 547,
                columns: new[] { "EndTime", "StartTime" },
                values: new object[] { new DateTime(2024, 1, 1, 6, 30, 7, 0, DateTimeKind.Unspecified), new DateTime(2024, 12, 29, 4, 35, 30, 0, DateTimeKind.Unspecified) });

            migrationBuilder.UpdateData(
                table: "TimeRegistrations",
                keyColumn: "TimeRegistrationId",
                keyValue: 548,
                columns: new[] { "EndTime", "StartTime" },
                values: new object[] { new DateTime(2024, 8, 11, 21, 58, 52, 0, DateTimeKind.Unspecified), new DateTime(2024, 6, 25, 2, 12, 39, 0, DateTimeKind.Unspecified) });

            migrationBuilder.UpdateData(
                table: "TimeRegistrations",
                keyColumn: "TimeRegistrationId",
                keyValue: 549,
                columns: new[] { "EndTime", "StartTime" },
                values: new object[] { new DateTime(2024, 12, 15, 20, 52, 54, 0, DateTimeKind.Unspecified), new DateTime(2024, 2, 23, 22, 9, 32, 0, DateTimeKind.Unspecified) });

            migrationBuilder.UpdateData(
                table: "TimeRegistrations",
                keyColumn: "TimeRegistrationId",
                keyValue: 550,
                columns: new[] { "EndTime", "StartTime" },
                values: new object[] { new DateTime(2024, 1, 2, 4, 31, 27, 0, DateTimeKind.Unspecified), new DateTime(2024, 3, 6, 5, 45, 29, 0, DateTimeKind.Unspecified) });

            migrationBuilder.UpdateData(
                table: "TimeRegistrations",
                keyColumn: "TimeRegistrationId",
                keyValue: 551,
                columns: new[] { "EndTime", "StartTime" },
                values: new object[] { new DateTime(2024, 11, 5, 13, 4, 57, 0, DateTimeKind.Unspecified), new DateTime(2024, 8, 31, 4, 45, 21, 0, DateTimeKind.Unspecified) });

            migrationBuilder.UpdateData(
                table: "TimeRegistrations",
                keyColumn: "TimeRegistrationId",
                keyValue: 552,
                columns: new[] { "EndTime", "StartTime" },
                values: new object[] { new DateTime(2024, 5, 27, 13, 25, 49, 0, DateTimeKind.Unspecified), new DateTime(2024, 2, 17, 0, 38, 7, 0, DateTimeKind.Unspecified) });

            migrationBuilder.UpdateData(
                table: "TimeRegistrations",
                keyColumn: "TimeRegistrationId",
                keyValue: 553,
                columns: new[] { "EndTime", "StartTime" },
                values: new object[] { new DateTime(2024, 11, 18, 5, 9, 30, 0, DateTimeKind.Unspecified), new DateTime(2024, 1, 6, 0, 13, 8, 0, DateTimeKind.Unspecified) });

            migrationBuilder.UpdateData(
                table: "TimeRegistrations",
                keyColumn: "TimeRegistrationId",
                keyValue: 554,
                columns: new[] { "EndTime", "StartTime" },
                values: new object[] { new DateTime(2024, 12, 26, 12, 20, 21, 0, DateTimeKind.Unspecified), new DateTime(2024, 5, 14, 1, 0, 13, 0, DateTimeKind.Unspecified) });

            migrationBuilder.UpdateData(
                table: "TimeRegistrations",
                keyColumn: "TimeRegistrationId",
                keyValue: 555,
                columns: new[] { "EndTime", "StartTime" },
                values: new object[] { new DateTime(2024, 4, 2, 10, 9, 15, 0, DateTimeKind.Unspecified), new DateTime(2024, 4, 22, 10, 10, 18, 0, DateTimeKind.Unspecified) });

            migrationBuilder.UpdateData(
                table: "TimeRegistrations",
                keyColumn: "TimeRegistrationId",
                keyValue: 556,
                columns: new[] { "EndTime", "StartTime" },
                values: new object[] { new DateTime(2024, 2, 1, 23, 22, 38, 0, DateTimeKind.Unspecified), new DateTime(2024, 2, 8, 18, 1, 6, 0, DateTimeKind.Unspecified) });

            migrationBuilder.UpdateData(
                table: "TimeRegistrations",
                keyColumn: "TimeRegistrationId",
                keyValue: 557,
                columns: new[] { "EndTime", "StartTime" },
                values: new object[] { new DateTime(2024, 5, 11, 2, 59, 58, 0, DateTimeKind.Unspecified), new DateTime(2024, 3, 16, 14, 30, 18, 0, DateTimeKind.Unspecified) });

            migrationBuilder.UpdateData(
                table: "TimeRegistrations",
                keyColumn: "TimeRegistrationId",
                keyValue: 558,
                columns: new[] { "EndTime", "StartTime" },
                values: new object[] { new DateTime(2024, 12, 28, 13, 27, 41, 0, DateTimeKind.Unspecified), new DateTime(2024, 2, 1, 12, 43, 29, 0, DateTimeKind.Unspecified) });

            migrationBuilder.UpdateData(
                table: "TimeRegistrations",
                keyColumn: "TimeRegistrationId",
                keyValue: 559,
                columns: new[] { "EndTime", "StartTime" },
                values: new object[] { new DateTime(2024, 9, 8, 0, 14, 51, 0, DateTimeKind.Unspecified), new DateTime(2024, 12, 6, 7, 58, 36, 0, DateTimeKind.Unspecified) });

            migrationBuilder.UpdateData(
                table: "TimeRegistrations",
                keyColumn: "TimeRegistrationId",
                keyValue: 560,
                columns: new[] { "EndTime", "StartTime" },
                values: new object[] { new DateTime(2024, 5, 2, 10, 39, 58, 0, DateTimeKind.Unspecified), new DateTime(2024, 11, 16, 0, 9, 40, 0, DateTimeKind.Unspecified) });

            migrationBuilder.UpdateData(
                table: "TimeRegistrations",
                keyColumn: "TimeRegistrationId",
                keyValue: 561,
                columns: new[] { "EndTime", "StartTime" },
                values: new object[] { new DateTime(2024, 5, 1, 19, 35, 5, 0, DateTimeKind.Unspecified), new DateTime(2024, 11, 13, 12, 40, 10, 0, DateTimeKind.Unspecified) });

            migrationBuilder.UpdateData(
                table: "TimeRegistrations",
                keyColumn: "TimeRegistrationId",
                keyValue: 562,
                columns: new[] { "EndTime", "StartTime" },
                values: new object[] { new DateTime(2024, 3, 9, 21, 51, 56, 0, DateTimeKind.Unspecified), new DateTime(2024, 3, 2, 8, 28, 31, 0, DateTimeKind.Unspecified) });

            migrationBuilder.UpdateData(
                table: "TimeRegistrations",
                keyColumn: "TimeRegistrationId",
                keyValue: 563,
                columns: new[] { "EndTime", "StartTime" },
                values: new object[] { new DateTime(2024, 6, 27, 5, 3, 2, 0, DateTimeKind.Unspecified), new DateTime(2024, 11, 1, 11, 35, 18, 0, DateTimeKind.Unspecified) });

            migrationBuilder.UpdateData(
                table: "TimeRegistrations",
                keyColumn: "TimeRegistrationId",
                keyValue: 564,
                columns: new[] { "EndTime", "StartTime" },
                values: new object[] { new DateTime(2024, 5, 17, 12, 25, 14, 0, DateTimeKind.Unspecified), new DateTime(2024, 12, 14, 1, 3, 25, 0, DateTimeKind.Unspecified) });

            migrationBuilder.UpdateData(
                table: "TimeRegistrations",
                keyColumn: "TimeRegistrationId",
                keyValue: 565,
                columns: new[] { "EndTime", "StartTime" },
                values: new object[] { new DateTime(2024, 6, 5, 14, 35, 59, 0, DateTimeKind.Unspecified), new DateTime(2024, 12, 10, 12, 32, 23, 0, DateTimeKind.Unspecified) });

            migrationBuilder.UpdateData(
                table: "TimeRegistrations",
                keyColumn: "TimeRegistrationId",
                keyValue: 566,
                columns: new[] { "EndTime", "StartTime" },
                values: new object[] { new DateTime(2024, 5, 9, 12, 9, 9, 0, DateTimeKind.Unspecified), new DateTime(2024, 7, 23, 7, 33, 9, 0, DateTimeKind.Unspecified) });

            migrationBuilder.UpdateData(
                table: "TimeRegistrations",
                keyColumn: "TimeRegistrationId",
                keyValue: 567,
                columns: new[] { "EndTime", "StartTime" },
                values: new object[] { new DateTime(2024, 2, 5, 20, 3, 2, 0, DateTimeKind.Unspecified), new DateTime(2024, 4, 13, 3, 30, 3, 0, DateTimeKind.Unspecified) });

            migrationBuilder.UpdateData(
                table: "TimeRegistrations",
                keyColumn: "TimeRegistrationId",
                keyValue: 568,
                columns: new[] { "EndTime", "StartTime" },
                values: new object[] { new DateTime(2024, 9, 3, 11, 16, 0, 0, DateTimeKind.Unspecified), new DateTime(2024, 9, 12, 16, 23, 9, 0, DateTimeKind.Unspecified) });

            migrationBuilder.UpdateData(
                table: "TimeRegistrations",
                keyColumn: "TimeRegistrationId",
                keyValue: 569,
                columns: new[] { "EndTime", "StartTime" },
                values: new object[] { new DateTime(2024, 7, 3, 18, 34, 31, 0, DateTimeKind.Unspecified), new DateTime(2024, 2, 11, 14, 28, 58, 0, DateTimeKind.Unspecified) });

            migrationBuilder.UpdateData(
                table: "TimeRegistrations",
                keyColumn: "TimeRegistrationId",
                keyValue: 570,
                columns: new[] { "EndTime", "StartTime" },
                values: new object[] { new DateTime(2024, 11, 15, 12, 22, 17, 0, DateTimeKind.Unspecified), new DateTime(2024, 10, 18, 13, 13, 54, 0, DateTimeKind.Unspecified) });

            migrationBuilder.UpdateData(
                table: "TimeRegistrations",
                keyColumn: "TimeRegistrationId",
                keyValue: 571,
                columns: new[] { "EndTime", "StartTime" },
                values: new object[] { new DateTime(2024, 9, 28, 10, 38, 36, 0, DateTimeKind.Unspecified), new DateTime(2024, 12, 10, 0, 29, 59, 0, DateTimeKind.Unspecified) });

            migrationBuilder.UpdateData(
                table: "TimeRegistrations",
                keyColumn: "TimeRegistrationId",
                keyValue: 572,
                columns: new[] { "EndTime", "StartTime" },
                values: new object[] { new DateTime(2024, 1, 29, 17, 28, 17, 0, DateTimeKind.Unspecified), new DateTime(2024, 7, 4, 20, 45, 39, 0, DateTimeKind.Unspecified) });

            migrationBuilder.UpdateData(
                table: "TimeRegistrations",
                keyColumn: "TimeRegistrationId",
                keyValue: 573,
                columns: new[] { "EndTime", "StartTime" },
                values: new object[] { new DateTime(2024, 8, 8, 3, 19, 55, 0, DateTimeKind.Unspecified), new DateTime(2024, 3, 17, 0, 31, 16, 0, DateTimeKind.Unspecified) });

            migrationBuilder.UpdateData(
                table: "TimeRegistrations",
                keyColumn: "TimeRegistrationId",
                keyValue: 574,
                columns: new[] { "EndTime", "StartTime" },
                values: new object[] { new DateTime(2024, 5, 25, 21, 29, 51, 0, DateTimeKind.Unspecified), new DateTime(2024, 7, 4, 13, 54, 28, 0, DateTimeKind.Unspecified) });

            migrationBuilder.UpdateData(
                table: "TimeRegistrations",
                keyColumn: "TimeRegistrationId",
                keyValue: 575,
                columns: new[] { "EndTime", "StartTime" },
                values: new object[] { new DateTime(2024, 12, 21, 18, 25, 33, 0, DateTimeKind.Unspecified), new DateTime(2024, 1, 4, 2, 57, 53, 0, DateTimeKind.Unspecified) });

            migrationBuilder.UpdateData(
                table: "TimeRegistrations",
                keyColumn: "TimeRegistrationId",
                keyValue: 576,
                columns: new[] { "EndTime", "StartTime" },
                values: new object[] { new DateTime(2024, 6, 26, 9, 14, 42, 0, DateTimeKind.Unspecified), new DateTime(2024, 8, 7, 14, 31, 38, 0, DateTimeKind.Unspecified) });

            migrationBuilder.UpdateData(
                table: "TimeRegistrations",
                keyColumn: "TimeRegistrationId",
                keyValue: 577,
                columns: new[] { "EndTime", "StartTime" },
                values: new object[] { new DateTime(2024, 3, 13, 21, 40, 9, 0, DateTimeKind.Unspecified), new DateTime(2024, 6, 10, 2, 21, 37, 0, DateTimeKind.Unspecified) });

            migrationBuilder.UpdateData(
                table: "TimeRegistrations",
                keyColumn: "TimeRegistrationId",
                keyValue: 578,
                columns: new[] { "EndTime", "StartTime" },
                values: new object[] { new DateTime(2024, 7, 26, 15, 3, 50, 0, DateTimeKind.Unspecified), new DateTime(2024, 4, 5, 11, 22, 7, 0, DateTimeKind.Unspecified) });

            migrationBuilder.UpdateData(
                table: "TimeRegistrations",
                keyColumn: "TimeRegistrationId",
                keyValue: 579,
                columns: new[] { "EndTime", "StartTime" },
                values: new object[] { new DateTime(2024, 4, 29, 9, 48, 52, 0, DateTimeKind.Unspecified), new DateTime(2024, 12, 8, 0, 9, 38, 0, DateTimeKind.Unspecified) });

            migrationBuilder.UpdateData(
                table: "TimeRegistrations",
                keyColumn: "TimeRegistrationId",
                keyValue: 580,
                columns: new[] { "EndTime", "StartTime" },
                values: new object[] { new DateTime(2024, 7, 7, 5, 47, 41, 0, DateTimeKind.Unspecified), new DateTime(2024, 4, 14, 11, 44, 22, 0, DateTimeKind.Unspecified) });

            migrationBuilder.UpdateData(
                table: "TimeRegistrations",
                keyColumn: "TimeRegistrationId",
                keyValue: 581,
                columns: new[] { "EndTime", "StartTime" },
                values: new object[] { new DateTime(2024, 7, 19, 12, 37, 5, 0, DateTimeKind.Unspecified), new DateTime(2024, 8, 19, 5, 59, 16, 0, DateTimeKind.Unspecified) });

            migrationBuilder.UpdateData(
                table: "TimeRegistrations",
                keyColumn: "TimeRegistrationId",
                keyValue: 582,
                columns: new[] { "EndTime", "StartTime" },
                values: new object[] { new DateTime(2024, 3, 31, 6, 26, 38, 0, DateTimeKind.Unspecified), new DateTime(2024, 3, 10, 15, 18, 23, 0, DateTimeKind.Unspecified) });

            migrationBuilder.UpdateData(
                table: "TimeRegistrations",
                keyColumn: "TimeRegistrationId",
                keyValue: 583,
                columns: new[] { "EndTime", "StartTime" },
                values: new object[] { new DateTime(2024, 9, 1, 7, 21, 23, 0, DateTimeKind.Unspecified), new DateTime(2024, 6, 4, 21, 23, 52, 0, DateTimeKind.Unspecified) });

            migrationBuilder.UpdateData(
                table: "TimeRegistrations",
                keyColumn: "TimeRegistrationId",
                keyValue: 584,
                columns: new[] { "EndTime", "StartTime" },
                values: new object[] { new DateTime(2024, 8, 24, 8, 33, 28, 0, DateTimeKind.Unspecified), new DateTime(2024, 2, 25, 21, 47, 5, 0, DateTimeKind.Unspecified) });

            migrationBuilder.UpdateData(
                table: "TimeRegistrations",
                keyColumn: "TimeRegistrationId",
                keyValue: 585,
                columns: new[] { "EndTime", "StartTime" },
                values: new object[] { new DateTime(2024, 9, 7, 20, 34, 34, 0, DateTimeKind.Unspecified), new DateTime(2024, 8, 3, 16, 3, 0, 0, DateTimeKind.Unspecified) });

            migrationBuilder.UpdateData(
                table: "TimeRegistrations",
                keyColumn: "TimeRegistrationId",
                keyValue: 586,
                columns: new[] { "EndTime", "StartTime" },
                values: new object[] { new DateTime(2024, 2, 24, 1, 20, 3, 0, DateTimeKind.Unspecified), new DateTime(2024, 2, 24, 19, 38, 51, 0, DateTimeKind.Unspecified) });

            migrationBuilder.UpdateData(
                table: "TimeRegistrations",
                keyColumn: "TimeRegistrationId",
                keyValue: 587,
                columns: new[] { "EndTime", "StartTime" },
                values: new object[] { new DateTime(2024, 3, 20, 10, 38, 10, 0, DateTimeKind.Unspecified), new DateTime(2024, 12, 25, 21, 2, 31, 0, DateTimeKind.Unspecified) });

            migrationBuilder.UpdateData(
                table: "TimeRegistrations",
                keyColumn: "TimeRegistrationId",
                keyValue: 588,
                columns: new[] { "EndTime", "StartTime" },
                values: new object[] { new DateTime(2024, 5, 18, 10, 30, 52, 0, DateTimeKind.Unspecified), new DateTime(2024, 8, 6, 0, 41, 47, 0, DateTimeKind.Unspecified) });

            migrationBuilder.UpdateData(
                table: "TimeRegistrations",
                keyColumn: "TimeRegistrationId",
                keyValue: 589,
                columns: new[] { "EndTime", "StartTime" },
                values: new object[] { new DateTime(2024, 5, 3, 5, 53, 55, 0, DateTimeKind.Unspecified), new DateTime(2024, 1, 3, 12, 41, 16, 0, DateTimeKind.Unspecified) });

            migrationBuilder.UpdateData(
                table: "TimeRegistrations",
                keyColumn: "TimeRegistrationId",
                keyValue: 590,
                columns: new[] { "EndTime", "StartTime" },
                values: new object[] { new DateTime(2024, 6, 27, 13, 52, 12, 0, DateTimeKind.Unspecified), new DateTime(2024, 6, 4, 5, 4, 3, 0, DateTimeKind.Unspecified) });

            migrationBuilder.UpdateData(
                table: "TimeRegistrations",
                keyColumn: "TimeRegistrationId",
                keyValue: 591,
                columns: new[] { "EndTime", "StartTime" },
                values: new object[] { new DateTime(2024, 1, 2, 16, 30, 12, 0, DateTimeKind.Unspecified), new DateTime(2024, 7, 20, 21, 46, 2, 0, DateTimeKind.Unspecified) });

            migrationBuilder.UpdateData(
                table: "TimeRegistrations",
                keyColumn: "TimeRegistrationId",
                keyValue: 592,
                columns: new[] { "EndTime", "StartTime" },
                values: new object[] { new DateTime(2024, 9, 11, 23, 43, 53, 0, DateTimeKind.Unspecified), new DateTime(2024, 11, 18, 3, 51, 25, 0, DateTimeKind.Unspecified) });

            migrationBuilder.UpdateData(
                table: "TimeRegistrations",
                keyColumn: "TimeRegistrationId",
                keyValue: 593,
                columns: new[] { "EndTime", "StartTime" },
                values: new object[] { new DateTime(2024, 11, 28, 23, 58, 23, 0, DateTimeKind.Unspecified), new DateTime(2024, 9, 18, 4, 49, 38, 0, DateTimeKind.Unspecified) });

            migrationBuilder.UpdateData(
                table: "TimeRegistrations",
                keyColumn: "TimeRegistrationId",
                keyValue: 594,
                columns: new[] { "EndTime", "StartTime" },
                values: new object[] { new DateTime(2024, 3, 10, 16, 50, 36, 0, DateTimeKind.Unspecified), new DateTime(2024, 6, 14, 2, 18, 12, 0, DateTimeKind.Unspecified) });

            migrationBuilder.UpdateData(
                table: "TimeRegistrations",
                keyColumn: "TimeRegistrationId",
                keyValue: 595,
                columns: new[] { "EndTime", "StartTime" },
                values: new object[] { new DateTime(2024, 10, 17, 17, 57, 15, 0, DateTimeKind.Unspecified), new DateTime(2024, 2, 22, 10, 18, 21, 0, DateTimeKind.Unspecified) });

            migrationBuilder.UpdateData(
                table: "TimeRegistrations",
                keyColumn: "TimeRegistrationId",
                keyValue: 596,
                columns: new[] { "EndTime", "StartTime" },
                values: new object[] { new DateTime(2024, 6, 6, 7, 5, 34, 0, DateTimeKind.Unspecified), new DateTime(2024, 12, 29, 7, 31, 34, 0, DateTimeKind.Unspecified) });

            migrationBuilder.UpdateData(
                table: "TimeRegistrations",
                keyColumn: "TimeRegistrationId",
                keyValue: 597,
                columns: new[] { "EndTime", "StartTime" },
                values: new object[] { new DateTime(2024, 5, 13, 21, 27, 16, 0, DateTimeKind.Unspecified), new DateTime(2024, 10, 25, 13, 15, 56, 0, DateTimeKind.Unspecified) });

            migrationBuilder.UpdateData(
                table: "TimeRegistrations",
                keyColumn: "TimeRegistrationId",
                keyValue: 598,
                columns: new[] { "EndTime", "StartTime" },
                values: new object[] { new DateTime(2024, 4, 7, 7, 0, 54, 0, DateTimeKind.Unspecified), new DateTime(2024, 8, 5, 9, 4, 46, 0, DateTimeKind.Unspecified) });

            migrationBuilder.UpdateData(
                table: "TimeRegistrations",
                keyColumn: "TimeRegistrationId",
                keyValue: 599,
                columns: new[] { "EndTime", "StartTime" },
                values: new object[] { new DateTime(2024, 8, 31, 10, 46, 56, 0, DateTimeKind.Unspecified), new DateTime(2024, 3, 1, 11, 56, 49, 0, DateTimeKind.Unspecified) });

            migrationBuilder.UpdateData(
                table: "TimeRegistrations",
                keyColumn: "TimeRegistrationId",
                keyValue: 600,
                columns: new[] { "EndTime", "StartTime" },
                values: new object[] { new DateTime(2024, 7, 5, 16, 23, 47, 0, DateTimeKind.Unspecified), new DateTime(2024, 12, 13, 10, 46, 10, 0, DateTimeKind.Unspecified) });

            migrationBuilder.UpdateData(
                table: "TimeRegistrations",
                keyColumn: "TimeRegistrationId",
                keyValue: 601,
                columns: new[] { "EndTime", "StartTime" },
                values: new object[] { new DateTime(2024, 4, 14, 4, 57, 15, 0, DateTimeKind.Unspecified), new DateTime(2024, 9, 14, 9, 4, 57, 0, DateTimeKind.Unspecified) });

            migrationBuilder.UpdateData(
                table: "TimeRegistrations",
                keyColumn: "TimeRegistrationId",
                keyValue: 602,
                columns: new[] { "EndTime", "StartTime" },
                values: new object[] { new DateTime(2024, 12, 10, 2, 8, 50, 0, DateTimeKind.Unspecified), new DateTime(2024, 4, 7, 13, 12, 20, 0, DateTimeKind.Unspecified) });

            migrationBuilder.UpdateData(
                table: "TimeRegistrations",
                keyColumn: "TimeRegistrationId",
                keyValue: 603,
                columns: new[] { "EndTime", "StartTime" },
                values: new object[] { new DateTime(2024, 8, 8, 14, 55, 38, 0, DateTimeKind.Unspecified), new DateTime(2024, 8, 29, 14, 55, 34, 0, DateTimeKind.Unspecified) });

            migrationBuilder.UpdateData(
                table: "TimeRegistrations",
                keyColumn: "TimeRegistrationId",
                keyValue: 604,
                columns: new[] { "EndTime", "StartTime" },
                values: new object[] { new DateTime(2024, 7, 20, 0, 46, 57, 0, DateTimeKind.Unspecified), new DateTime(2024, 9, 9, 21, 33, 2, 0, DateTimeKind.Unspecified) });

            migrationBuilder.UpdateData(
                table: "TimeRegistrations",
                keyColumn: "TimeRegistrationId",
                keyValue: 605,
                columns: new[] { "EndTime", "StartTime" },
                values: new object[] { new DateTime(2024, 6, 16, 19, 9, 25, 0, DateTimeKind.Unspecified), new DateTime(2024, 4, 4, 2, 13, 44, 0, DateTimeKind.Unspecified) });

            migrationBuilder.UpdateData(
                table: "TimeRegistrations",
                keyColumn: "TimeRegistrationId",
                keyValue: 606,
                columns: new[] { "EndTime", "StartTime" },
                values: new object[] { new DateTime(2024, 12, 9, 23, 14, 17, 0, DateTimeKind.Unspecified), new DateTime(2024, 7, 30, 8, 34, 54, 0, DateTimeKind.Unspecified) });

            migrationBuilder.UpdateData(
                table: "TimeRegistrations",
                keyColumn: "TimeRegistrationId",
                keyValue: 607,
                columns: new[] { "EndTime", "StartTime" },
                values: new object[] { new DateTime(2024, 5, 10, 3, 56, 42, 0, DateTimeKind.Unspecified), new DateTime(2024, 11, 23, 16, 23, 14, 0, DateTimeKind.Unspecified) });

            migrationBuilder.UpdateData(
                table: "TimeRegistrations",
                keyColumn: "TimeRegistrationId",
                keyValue: 608,
                columns: new[] { "EndTime", "StartTime" },
                values: new object[] { new DateTime(2024, 6, 29, 6, 16, 33, 0, DateTimeKind.Unspecified), new DateTime(2024, 11, 6, 15, 33, 0, 0, DateTimeKind.Unspecified) });

            migrationBuilder.UpdateData(
                table: "TimeRegistrations",
                keyColumn: "TimeRegistrationId",
                keyValue: 609,
                columns: new[] { "EndTime", "StartTime" },
                values: new object[] { new DateTime(2024, 9, 19, 23, 12, 43, 0, DateTimeKind.Unspecified), new DateTime(2024, 10, 18, 15, 10, 53, 0, DateTimeKind.Unspecified) });

            migrationBuilder.UpdateData(
                table: "TimeRegistrations",
                keyColumn: "TimeRegistrationId",
                keyValue: 610,
                columns: new[] { "EndTime", "StartTime" },
                values: new object[] { new DateTime(2024, 11, 12, 1, 3, 44, 0, DateTimeKind.Unspecified), new DateTime(2024, 12, 25, 0, 35, 52, 0, DateTimeKind.Unspecified) });

            migrationBuilder.UpdateData(
                table: "TimeRegistrations",
                keyColumn: "TimeRegistrationId",
                keyValue: 611,
                columns: new[] { "EndTime", "StartTime" },
                values: new object[] { new DateTime(2024, 5, 12, 8, 36, 8, 0, DateTimeKind.Unspecified), new DateTime(2024, 7, 7, 2, 8, 3, 0, DateTimeKind.Unspecified) });

            migrationBuilder.UpdateData(
                table: "TimeRegistrations",
                keyColumn: "TimeRegistrationId",
                keyValue: 612,
                columns: new[] { "EndTime", "StartTime" },
                values: new object[] { new DateTime(2024, 8, 18, 16, 18, 10, 0, DateTimeKind.Unspecified), new DateTime(2024, 10, 20, 5, 19, 52, 0, DateTimeKind.Unspecified) });

            migrationBuilder.UpdateData(
                table: "TimeRegistrations",
                keyColumn: "TimeRegistrationId",
                keyValue: 613,
                columns: new[] { "EndTime", "StartTime" },
                values: new object[] { new DateTime(2024, 3, 1, 5, 25, 4, 0, DateTimeKind.Unspecified), new DateTime(2024, 7, 12, 20, 3, 35, 0, DateTimeKind.Unspecified) });

            migrationBuilder.UpdateData(
                table: "TimeRegistrations",
                keyColumn: "TimeRegistrationId",
                keyValue: 614,
                columns: new[] { "EndTime", "StartTime" },
                values: new object[] { new DateTime(2024, 8, 11, 21, 2, 4, 0, DateTimeKind.Unspecified), new DateTime(2024, 12, 16, 12, 26, 58, 0, DateTimeKind.Unspecified) });

            migrationBuilder.UpdateData(
                table: "TimeRegistrations",
                keyColumn: "TimeRegistrationId",
                keyValue: 615,
                columns: new[] { "EndTime", "StartTime" },
                values: new object[] { new DateTime(2024, 2, 29, 19, 38, 59, 0, DateTimeKind.Unspecified), new DateTime(2024, 6, 14, 3, 52, 24, 0, DateTimeKind.Unspecified) });

            migrationBuilder.UpdateData(
                table: "TimeRegistrations",
                keyColumn: "TimeRegistrationId",
                keyValue: 616,
                columns: new[] { "EndTime", "StartTime" },
                values: new object[] { new DateTime(2024, 10, 24, 21, 11, 4, 0, DateTimeKind.Unspecified), new DateTime(2024, 2, 22, 15, 2, 1, 0, DateTimeKind.Unspecified) });

            migrationBuilder.UpdateData(
                table: "TimeRegistrations",
                keyColumn: "TimeRegistrationId",
                keyValue: 617,
                columns: new[] { "EndTime", "StartTime" },
                values: new object[] { new DateTime(2024, 6, 22, 16, 27, 23, 0, DateTimeKind.Unspecified), new DateTime(2024, 8, 28, 16, 4, 37, 0, DateTimeKind.Unspecified) });

            migrationBuilder.UpdateData(
                table: "TimeRegistrations",
                keyColumn: "TimeRegistrationId",
                keyValue: 618,
                columns: new[] { "EndTime", "StartTime" },
                values: new object[] { new DateTime(2024, 2, 7, 21, 4, 14, 0, DateTimeKind.Unspecified), new DateTime(2024, 7, 16, 19, 39, 44, 0, DateTimeKind.Unspecified) });

            migrationBuilder.UpdateData(
                table: "TimeRegistrations",
                keyColumn: "TimeRegistrationId",
                keyValue: 619,
                columns: new[] { "EndTime", "StartTime" },
                values: new object[] { new DateTime(2024, 5, 7, 3, 33, 55, 0, DateTimeKind.Unspecified), new DateTime(2024, 7, 27, 22, 23, 56, 0, DateTimeKind.Unspecified) });

            migrationBuilder.UpdateData(
                table: "TimeRegistrations",
                keyColumn: "TimeRegistrationId",
                keyValue: 620,
                columns: new[] { "EndTime", "StartTime" },
                values: new object[] { new DateTime(2024, 7, 2, 9, 24, 44, 0, DateTimeKind.Unspecified), new DateTime(2024, 5, 25, 3, 33, 49, 0, DateTimeKind.Unspecified) });

            migrationBuilder.UpdateData(
                table: "TimeRegistrations",
                keyColumn: "TimeRegistrationId",
                keyValue: 621,
                columns: new[] { "EndTime", "StartTime" },
                values: new object[] { new DateTime(2024, 3, 13, 0, 58, 55, 0, DateTimeKind.Unspecified), new DateTime(2024, 12, 26, 0, 59, 24, 0, DateTimeKind.Unspecified) });

            migrationBuilder.UpdateData(
                table: "TimeRegistrations",
                keyColumn: "TimeRegistrationId",
                keyValue: 622,
                columns: new[] { "EndTime", "StartTime" },
                values: new object[] { new DateTime(2024, 7, 19, 6, 36, 25, 0, DateTimeKind.Unspecified), new DateTime(2024, 4, 15, 10, 37, 4, 0, DateTimeKind.Unspecified) });

            migrationBuilder.UpdateData(
                table: "TimeRegistrations",
                keyColumn: "TimeRegistrationId",
                keyValue: 623,
                columns: new[] { "EndTime", "StartTime" },
                values: new object[] { new DateTime(2024, 4, 26, 2, 36, 36, 0, DateTimeKind.Unspecified), new DateTime(2024, 7, 31, 7, 29, 53, 0, DateTimeKind.Unspecified) });

            migrationBuilder.UpdateData(
                table: "TimeRegistrations",
                keyColumn: "TimeRegistrationId",
                keyValue: 624,
                columns: new[] { "EndTime", "StartTime" },
                values: new object[] { new DateTime(2024, 6, 30, 13, 4, 19, 0, DateTimeKind.Unspecified), new DateTime(2024, 5, 25, 21, 25, 0, 0, DateTimeKind.Unspecified) });

            migrationBuilder.UpdateData(
                table: "TimeRegistrations",
                keyColumn: "TimeRegistrationId",
                keyValue: 625,
                columns: new[] { "EndTime", "StartTime" },
                values: new object[] { new DateTime(2024, 6, 9, 22, 32, 5, 0, DateTimeKind.Unspecified), new DateTime(2024, 4, 25, 23, 4, 56, 0, DateTimeKind.Unspecified) });

            migrationBuilder.UpdateData(
                table: "TimeRegistrations",
                keyColumn: "TimeRegistrationId",
                keyValue: 626,
                columns: new[] { "EndTime", "StartTime" },
                values: new object[] { new DateTime(2024, 1, 29, 4, 21, 4, 0, DateTimeKind.Unspecified), new DateTime(2024, 6, 8, 18, 31, 41, 0, DateTimeKind.Unspecified) });

            migrationBuilder.UpdateData(
                table: "TimeRegistrations",
                keyColumn: "TimeRegistrationId",
                keyValue: 627,
                columns: new[] { "EndTime", "StartTime" },
                values: new object[] { new DateTime(2024, 8, 11, 5, 52, 34, 0, DateTimeKind.Unspecified), new DateTime(2024, 7, 2, 0, 9, 53, 0, DateTimeKind.Unspecified) });

            migrationBuilder.UpdateData(
                table: "TimeRegistrations",
                keyColumn: "TimeRegistrationId",
                keyValue: 628,
                columns: new[] { "EndTime", "StartTime" },
                values: new object[] { new DateTime(2024, 3, 2, 12, 30, 2, 0, DateTimeKind.Unspecified), new DateTime(2024, 3, 22, 12, 15, 58, 0, DateTimeKind.Unspecified) });

            migrationBuilder.UpdateData(
                table: "TimeRegistrations",
                keyColumn: "TimeRegistrationId",
                keyValue: 629,
                columns: new[] { "EndTime", "StartTime" },
                values: new object[] { new DateTime(2024, 11, 5, 8, 19, 58, 0, DateTimeKind.Unspecified), new DateTime(2024, 8, 20, 15, 27, 56, 0, DateTimeKind.Unspecified) });

            migrationBuilder.UpdateData(
                table: "TimeRegistrations",
                keyColumn: "TimeRegistrationId",
                keyValue: 630,
                columns: new[] { "EndTime", "StartTime" },
                values: new object[] { new DateTime(2024, 4, 21, 5, 16, 53, 0, DateTimeKind.Unspecified), new DateTime(2024, 3, 26, 18, 24, 52, 0, DateTimeKind.Unspecified) });

            migrationBuilder.UpdateData(
                table: "TimeRegistrations",
                keyColumn: "TimeRegistrationId",
                keyValue: 631,
                columns: new[] { "EndTime", "StartTime" },
                values: new object[] { new DateTime(2024, 8, 3, 8, 26, 12, 0, DateTimeKind.Unspecified), new DateTime(2024, 9, 1, 5, 2, 50, 0, DateTimeKind.Unspecified) });

            migrationBuilder.UpdateData(
                table: "TimeRegistrations",
                keyColumn: "TimeRegistrationId",
                keyValue: 632,
                columns: new[] { "EndTime", "StartTime" },
                values: new object[] { new DateTime(2024, 1, 30, 15, 3, 37, 0, DateTimeKind.Unspecified), new DateTime(2024, 11, 15, 4, 8, 19, 0, DateTimeKind.Unspecified) });

            migrationBuilder.UpdateData(
                table: "TimeRegistrations",
                keyColumn: "TimeRegistrationId",
                keyValue: 633,
                columns: new[] { "EndTime", "StartTime" },
                values: new object[] { new DateTime(2024, 11, 1, 11, 17, 48, 0, DateTimeKind.Unspecified), new DateTime(2024, 7, 10, 15, 46, 22, 0, DateTimeKind.Unspecified) });

            migrationBuilder.UpdateData(
                table: "TimeRegistrations",
                keyColumn: "TimeRegistrationId",
                keyValue: 634,
                columns: new[] { "EndTime", "StartTime" },
                values: new object[] { new DateTime(2024, 4, 9, 1, 3, 22, 0, DateTimeKind.Unspecified), new DateTime(2024, 5, 20, 16, 4, 14, 0, DateTimeKind.Unspecified) });

            migrationBuilder.UpdateData(
                table: "TimeRegistrations",
                keyColumn: "TimeRegistrationId",
                keyValue: 635,
                columns: new[] { "EndTime", "StartTime" },
                values: new object[] { new DateTime(2024, 9, 5, 13, 37, 4, 0, DateTimeKind.Unspecified), new DateTime(2024, 1, 27, 19, 48, 34, 0, DateTimeKind.Unspecified) });

            migrationBuilder.UpdateData(
                table: "TimeRegistrations",
                keyColumn: "TimeRegistrationId",
                keyValue: 636,
                columns: new[] { "EndTime", "StartTime" },
                values: new object[] { new DateTime(2024, 7, 6, 22, 14, 8, 0, DateTimeKind.Unspecified), new DateTime(2024, 4, 17, 9, 6, 4, 0, DateTimeKind.Unspecified) });

            migrationBuilder.UpdateData(
                table: "TimeRegistrations",
                keyColumn: "TimeRegistrationId",
                keyValue: 637,
                columns: new[] { "EndTime", "StartTime" },
                values: new object[] { new DateTime(2024, 10, 8, 3, 44, 30, 0, DateTimeKind.Unspecified), new DateTime(2024, 6, 15, 1, 19, 37, 0, DateTimeKind.Unspecified) });

            migrationBuilder.UpdateData(
                table: "TimeRegistrations",
                keyColumn: "TimeRegistrationId",
                keyValue: 638,
                columns: new[] { "EndTime", "StartTime" },
                values: new object[] { new DateTime(2024, 11, 9, 16, 2, 1, 0, DateTimeKind.Unspecified), new DateTime(2024, 7, 23, 5, 25, 25, 0, DateTimeKind.Unspecified) });

            migrationBuilder.UpdateData(
                table: "TimeRegistrations",
                keyColumn: "TimeRegistrationId",
                keyValue: 639,
                columns: new[] { "EndTime", "StartTime" },
                values: new object[] { new DateTime(2024, 2, 23, 10, 47, 31, 0, DateTimeKind.Unspecified), new DateTime(2024, 3, 19, 21, 37, 43, 0, DateTimeKind.Unspecified) });

            migrationBuilder.UpdateData(
                table: "TimeRegistrations",
                keyColumn: "TimeRegistrationId",
                keyValue: 640,
                columns: new[] { "EndTime", "StartTime" },
                values: new object[] { new DateTime(2024, 10, 6, 21, 23, 25, 0, DateTimeKind.Unspecified), new DateTime(2024, 1, 22, 11, 49, 33, 0, DateTimeKind.Unspecified) });

            migrationBuilder.UpdateData(
                table: "TimeRegistrations",
                keyColumn: "TimeRegistrationId",
                keyValue: 641,
                columns: new[] { "EndTime", "StartTime" },
                values: new object[] { new DateTime(2024, 11, 21, 11, 45, 43, 0, DateTimeKind.Unspecified), new DateTime(2024, 10, 17, 21, 34, 41, 0, DateTimeKind.Unspecified) });

            migrationBuilder.UpdateData(
                table: "TimeRegistrations",
                keyColumn: "TimeRegistrationId",
                keyValue: 642,
                columns: new[] { "EndTime", "StartTime" },
                values: new object[] { new DateTime(2024, 8, 16, 0, 4, 32, 0, DateTimeKind.Unspecified), new DateTime(2024, 6, 1, 9, 18, 0, 0, DateTimeKind.Unspecified) });

            migrationBuilder.UpdateData(
                table: "TimeRegistrations",
                keyColumn: "TimeRegistrationId",
                keyValue: 643,
                columns: new[] { "EndTime", "StartTime" },
                values: new object[] { new DateTime(2024, 8, 27, 3, 55, 36, 0, DateTimeKind.Unspecified), new DateTime(2024, 11, 13, 21, 10, 23, 0, DateTimeKind.Unspecified) });

            migrationBuilder.UpdateData(
                table: "TimeRegistrations",
                keyColumn: "TimeRegistrationId",
                keyValue: 644,
                columns: new[] { "EndTime", "StartTime" },
                values: new object[] { new DateTime(2024, 2, 4, 9, 9, 21, 0, DateTimeKind.Unspecified), new DateTime(2024, 1, 13, 7, 51, 1, 0, DateTimeKind.Unspecified) });

            migrationBuilder.UpdateData(
                table: "TimeRegistrations",
                keyColumn: "TimeRegistrationId",
                keyValue: 645,
                columns: new[] { "EndTime", "StartTime" },
                values: new object[] { new DateTime(2024, 5, 29, 5, 26, 37, 0, DateTimeKind.Unspecified), new DateTime(2024, 1, 10, 22, 50, 39, 0, DateTimeKind.Unspecified) });

            migrationBuilder.UpdateData(
                table: "TimeRegistrations",
                keyColumn: "TimeRegistrationId",
                keyValue: 646,
                columns: new[] { "EndTime", "StartTime" },
                values: new object[] { new DateTime(2024, 9, 22, 5, 50, 59, 0, DateTimeKind.Unspecified), new DateTime(2024, 4, 10, 9, 6, 35, 0, DateTimeKind.Unspecified) });

            migrationBuilder.UpdateData(
                table: "TimeRegistrations",
                keyColumn: "TimeRegistrationId",
                keyValue: 647,
                columns: new[] { "EndTime", "StartTime" },
                values: new object[] { new DateTime(2024, 6, 15, 7, 42, 8, 0, DateTimeKind.Unspecified), new DateTime(2024, 6, 18, 2, 17, 37, 0, DateTimeKind.Unspecified) });

            migrationBuilder.UpdateData(
                table: "TimeRegistrations",
                keyColumn: "TimeRegistrationId",
                keyValue: 648,
                columns: new[] { "EndTime", "StartTime" },
                values: new object[] { new DateTime(2024, 5, 5, 10, 10, 21, 0, DateTimeKind.Unspecified), new DateTime(2024, 10, 7, 14, 10, 7, 0, DateTimeKind.Unspecified) });

            migrationBuilder.UpdateData(
                table: "TimeRegistrations",
                keyColumn: "TimeRegistrationId",
                keyValue: 649,
                columns: new[] { "EndTime", "StartTime" },
                values: new object[] { new DateTime(2024, 8, 12, 12, 37, 54, 0, DateTimeKind.Unspecified), new DateTime(2024, 7, 27, 22, 10, 25, 0, DateTimeKind.Unspecified) });

            migrationBuilder.UpdateData(
                table: "TimeRegistrations",
                keyColumn: "TimeRegistrationId",
                keyValue: 650,
                columns: new[] { "EndTime", "StartTime" },
                values: new object[] { new DateTime(2024, 5, 4, 11, 21, 10, 0, DateTimeKind.Unspecified), new DateTime(2024, 3, 3, 18, 48, 44, 0, DateTimeKind.Unspecified) });

            migrationBuilder.UpdateData(
                table: "TimeRegistrations",
                keyColumn: "TimeRegistrationId",
                keyValue: 651,
                columns: new[] { "EndTime", "StartTime" },
                values: new object[] { new DateTime(2024, 2, 16, 4, 35, 53, 0, DateTimeKind.Unspecified), new DateTime(2024, 6, 2, 7, 35, 0, 0, DateTimeKind.Unspecified) });

            migrationBuilder.UpdateData(
                table: "TimeRegistrations",
                keyColumn: "TimeRegistrationId",
                keyValue: 652,
                columns: new[] { "EndTime", "StartTime" },
                values: new object[] { new DateTime(2024, 1, 5, 7, 59, 28, 0, DateTimeKind.Unspecified), new DateTime(2024, 1, 15, 19, 6, 6, 0, DateTimeKind.Unspecified) });

            migrationBuilder.UpdateData(
                table: "TimeRegistrations",
                keyColumn: "TimeRegistrationId",
                keyValue: 653,
                columns: new[] { "EndTime", "StartTime" },
                values: new object[] { new DateTime(2024, 7, 26, 19, 17, 27, 0, DateTimeKind.Unspecified), new DateTime(2024, 6, 22, 9, 50, 23, 0, DateTimeKind.Unspecified) });

            migrationBuilder.UpdateData(
                table: "TimeRegistrations",
                keyColumn: "TimeRegistrationId",
                keyValue: 654,
                columns: new[] { "EndTime", "StartTime" },
                values: new object[] { new DateTime(2024, 12, 29, 15, 52, 9, 0, DateTimeKind.Unspecified), new DateTime(2024, 8, 13, 9, 20, 50, 0, DateTimeKind.Unspecified) });

            migrationBuilder.UpdateData(
                table: "TimeRegistrations",
                keyColumn: "TimeRegistrationId",
                keyValue: 655,
                columns: new[] { "EndTime", "StartTime" },
                values: new object[] { new DateTime(2024, 5, 15, 16, 8, 45, 0, DateTimeKind.Unspecified), new DateTime(2024, 5, 22, 13, 15, 53, 0, DateTimeKind.Unspecified) });

            migrationBuilder.UpdateData(
                table: "TimeRegistrations",
                keyColumn: "TimeRegistrationId",
                keyValue: 656,
                columns: new[] { "EndTime", "StartTime" },
                values: new object[] { new DateTime(2024, 9, 28, 6, 43, 46, 0, DateTimeKind.Unspecified), new DateTime(2024, 7, 3, 13, 23, 2, 0, DateTimeKind.Unspecified) });

            migrationBuilder.UpdateData(
                table: "TimeRegistrations",
                keyColumn: "TimeRegistrationId",
                keyValue: 657,
                columns: new[] { "EndTime", "StartTime" },
                values: new object[] { new DateTime(2024, 5, 15, 22, 58, 2, 0, DateTimeKind.Unspecified), new DateTime(2024, 9, 9, 4, 55, 59, 0, DateTimeKind.Unspecified) });

            migrationBuilder.UpdateData(
                table: "TimeRegistrations",
                keyColumn: "TimeRegistrationId",
                keyValue: 658,
                columns: new[] { "EndTime", "StartTime" },
                values: new object[] { new DateTime(2024, 10, 3, 6, 45, 1, 0, DateTimeKind.Unspecified), new DateTime(2024, 1, 29, 10, 20, 16, 0, DateTimeKind.Unspecified) });

            migrationBuilder.UpdateData(
                table: "TimeRegistrations",
                keyColumn: "TimeRegistrationId",
                keyValue: 659,
                columns: new[] { "EndTime", "StartTime" },
                values: new object[] { new DateTime(2024, 12, 12, 15, 22, 31, 0, DateTimeKind.Unspecified), new DateTime(2024, 9, 15, 14, 51, 6, 0, DateTimeKind.Unspecified) });

            migrationBuilder.UpdateData(
                table: "TimeRegistrations",
                keyColumn: "TimeRegistrationId",
                keyValue: 660,
                columns: new[] { "EndTime", "StartTime" },
                values: new object[] { new DateTime(2024, 2, 14, 7, 54, 31, 0, DateTimeKind.Unspecified), new DateTime(2024, 1, 10, 10, 51, 7, 0, DateTimeKind.Unspecified) });

            migrationBuilder.UpdateData(
                table: "TimeRegistrations",
                keyColumn: "TimeRegistrationId",
                keyValue: 661,
                columns: new[] { "EndTime", "StartTime" },
                values: new object[] { new DateTime(2024, 2, 8, 11, 24, 53, 0, DateTimeKind.Unspecified), new DateTime(2024, 8, 6, 16, 28, 20, 0, DateTimeKind.Unspecified) });

            migrationBuilder.UpdateData(
                table: "TimeRegistrations",
                keyColumn: "TimeRegistrationId",
                keyValue: 662,
                columns: new[] { "EndTime", "StartTime" },
                values: new object[] { new DateTime(2024, 6, 6, 23, 9, 15, 0, DateTimeKind.Unspecified), new DateTime(2024, 9, 30, 18, 48, 17, 0, DateTimeKind.Unspecified) });

            migrationBuilder.UpdateData(
                table: "TimeRegistrations",
                keyColumn: "TimeRegistrationId",
                keyValue: 663,
                columns: new[] { "EndTime", "StartTime" },
                values: new object[] { new DateTime(2024, 9, 21, 2, 56, 46, 0, DateTimeKind.Unspecified), new DateTime(2024, 7, 7, 19, 37, 49, 0, DateTimeKind.Unspecified) });

            migrationBuilder.UpdateData(
                table: "TimeRegistrations",
                keyColumn: "TimeRegistrationId",
                keyValue: 664,
                columns: new[] { "EndTime", "StartTime" },
                values: new object[] { new DateTime(2024, 5, 12, 4, 24, 45, 0, DateTimeKind.Unspecified), new DateTime(2024, 11, 22, 14, 40, 57, 0, DateTimeKind.Unspecified) });

            migrationBuilder.UpdateData(
                table: "TimeRegistrations",
                keyColumn: "TimeRegistrationId",
                keyValue: 665,
                columns: new[] { "EndTime", "StartTime" },
                values: new object[] { new DateTime(2024, 4, 14, 2, 43, 49, 0, DateTimeKind.Unspecified), new DateTime(2024, 12, 1, 0, 23, 43, 0, DateTimeKind.Unspecified) });

            migrationBuilder.UpdateData(
                table: "TimeRegistrations",
                keyColumn: "TimeRegistrationId",
                keyValue: 666,
                columns: new[] { "EndTime", "StartTime" },
                values: new object[] { new DateTime(2024, 9, 13, 8, 11, 10, 0, DateTimeKind.Unspecified), new DateTime(2024, 12, 29, 11, 27, 33, 0, DateTimeKind.Unspecified) });

            migrationBuilder.UpdateData(
                table: "TimeRegistrations",
                keyColumn: "TimeRegistrationId",
                keyValue: 667,
                columns: new[] { "EndTime", "StartTime" },
                values: new object[] { new DateTime(2024, 1, 29, 2, 15, 38, 0, DateTimeKind.Unspecified), new DateTime(2024, 12, 23, 22, 28, 19, 0, DateTimeKind.Unspecified) });

            migrationBuilder.UpdateData(
                table: "TimeRegistrations",
                keyColumn: "TimeRegistrationId",
                keyValue: 668,
                columns: new[] { "EndTime", "StartTime" },
                values: new object[] { new DateTime(2024, 7, 8, 8, 54, 23, 0, DateTimeKind.Unspecified), new DateTime(2024, 2, 9, 5, 56, 51, 0, DateTimeKind.Unspecified) });

            migrationBuilder.UpdateData(
                table: "TimeRegistrations",
                keyColumn: "TimeRegistrationId",
                keyValue: 669,
                columns: new[] { "EndTime", "StartTime" },
                values: new object[] { new DateTime(2024, 8, 2, 12, 49, 42, 0, DateTimeKind.Unspecified), new DateTime(2024, 3, 5, 19, 7, 30, 0, DateTimeKind.Unspecified) });

            migrationBuilder.UpdateData(
                table: "TimeRegistrations",
                keyColumn: "TimeRegistrationId",
                keyValue: 670,
                columns: new[] { "EndTime", "StartTime" },
                values: new object[] { new DateTime(2024, 5, 18, 5, 59, 44, 0, DateTimeKind.Unspecified), new DateTime(2024, 6, 6, 20, 24, 44, 0, DateTimeKind.Unspecified) });

            migrationBuilder.UpdateData(
                table: "TimeRegistrations",
                keyColumn: "TimeRegistrationId",
                keyValue: 671,
                columns: new[] { "EndTime", "StartTime" },
                values: new object[] { new DateTime(2024, 3, 10, 17, 35, 24, 0, DateTimeKind.Unspecified), new DateTime(2024, 3, 14, 10, 11, 42, 0, DateTimeKind.Unspecified) });

            migrationBuilder.UpdateData(
                table: "TimeRegistrations",
                keyColumn: "TimeRegistrationId",
                keyValue: 672,
                columns: new[] { "EndTime", "StartTime" },
                values: new object[] { new DateTime(2024, 12, 10, 2, 20, 28, 0, DateTimeKind.Unspecified), new DateTime(2024, 4, 10, 10, 4, 56, 0, DateTimeKind.Unspecified) });

            migrationBuilder.UpdateData(
                table: "TimeRegistrations",
                keyColumn: "TimeRegistrationId",
                keyValue: 673,
                columns: new[] { "EndTime", "StartTime" },
                values: new object[] { new DateTime(2024, 10, 12, 11, 30, 56, 0, DateTimeKind.Unspecified), new DateTime(2024, 2, 1, 19, 39, 41, 0, DateTimeKind.Unspecified) });

            migrationBuilder.UpdateData(
                table: "TimeRegistrations",
                keyColumn: "TimeRegistrationId",
                keyValue: 674,
                columns: new[] { "EndTime", "StartTime" },
                values: new object[] { new DateTime(2024, 9, 29, 10, 42, 10, 0, DateTimeKind.Unspecified), new DateTime(2024, 8, 3, 8, 24, 41, 0, DateTimeKind.Unspecified) });

            migrationBuilder.UpdateData(
                table: "TimeRegistrations",
                keyColumn: "TimeRegistrationId",
                keyValue: 675,
                columns: new[] { "EndTime", "StartTime" },
                values: new object[] { new DateTime(2024, 8, 9, 7, 51, 44, 0, DateTimeKind.Unspecified), new DateTime(2024, 3, 20, 19, 14, 23, 0, DateTimeKind.Unspecified) });

            migrationBuilder.UpdateData(
                table: "TimeRegistrations",
                keyColumn: "TimeRegistrationId",
                keyValue: 676,
                columns: new[] { "EndTime", "StartTime" },
                values: new object[] { new DateTime(2024, 3, 10, 8, 11, 28, 0, DateTimeKind.Unspecified), new DateTime(2024, 12, 23, 6, 57, 9, 0, DateTimeKind.Unspecified) });

            migrationBuilder.UpdateData(
                table: "TimeRegistrations",
                keyColumn: "TimeRegistrationId",
                keyValue: 677,
                columns: new[] { "EndTime", "StartTime" },
                values: new object[] { new DateTime(2024, 3, 26, 21, 11, 11, 0, DateTimeKind.Unspecified), new DateTime(2024, 3, 19, 6, 11, 34, 0, DateTimeKind.Unspecified) });

            migrationBuilder.UpdateData(
                table: "TimeRegistrations",
                keyColumn: "TimeRegistrationId",
                keyValue: 678,
                columns: new[] { "EndTime", "StartTime" },
                values: new object[] { new DateTime(2024, 8, 2, 16, 1, 34, 0, DateTimeKind.Unspecified), new DateTime(2024, 1, 26, 16, 23, 59, 0, DateTimeKind.Unspecified) });

            migrationBuilder.UpdateData(
                table: "TimeRegistrations",
                keyColumn: "TimeRegistrationId",
                keyValue: 679,
                columns: new[] { "EndTime", "StartTime" },
                values: new object[] { new DateTime(2024, 12, 7, 22, 56, 59, 0, DateTimeKind.Unspecified), new DateTime(2024, 8, 20, 5, 53, 45, 0, DateTimeKind.Unspecified) });

            migrationBuilder.UpdateData(
                table: "TimeRegistrations",
                keyColumn: "TimeRegistrationId",
                keyValue: 680,
                columns: new[] { "EndTime", "StartTime" },
                values: new object[] { new DateTime(2024, 3, 21, 14, 49, 52, 0, DateTimeKind.Unspecified), new DateTime(2024, 6, 18, 15, 51, 57, 0, DateTimeKind.Unspecified) });

            migrationBuilder.UpdateData(
                table: "TimeRegistrations",
                keyColumn: "TimeRegistrationId",
                keyValue: 681,
                columns: new[] { "EndTime", "StartTime" },
                values: new object[] { new DateTime(2024, 4, 20, 6, 5, 42, 0, DateTimeKind.Unspecified), new DateTime(2024, 3, 30, 10, 2, 24, 0, DateTimeKind.Unspecified) });

            migrationBuilder.UpdateData(
                table: "TimeRegistrations",
                keyColumn: "TimeRegistrationId",
                keyValue: 682,
                columns: new[] { "EndTime", "StartTime" },
                values: new object[] { new DateTime(2024, 5, 28, 8, 10, 22, 0, DateTimeKind.Unspecified), new DateTime(2024, 12, 7, 0, 41, 29, 0, DateTimeKind.Unspecified) });

            migrationBuilder.UpdateData(
                table: "TimeRegistrations",
                keyColumn: "TimeRegistrationId",
                keyValue: 683,
                columns: new[] { "EndTime", "StartTime" },
                values: new object[] { new DateTime(2024, 6, 5, 1, 32, 34, 0, DateTimeKind.Unspecified), new DateTime(2024, 2, 23, 17, 16, 3, 0, DateTimeKind.Unspecified) });

            migrationBuilder.UpdateData(
                table: "TimeRegistrations",
                keyColumn: "TimeRegistrationId",
                keyValue: 684,
                columns: new[] { "EndTime", "StartTime" },
                values: new object[] { new DateTime(2024, 4, 5, 6, 52, 49, 0, DateTimeKind.Unspecified), new DateTime(2024, 3, 21, 22, 55, 41, 0, DateTimeKind.Unspecified) });

            migrationBuilder.UpdateData(
                table: "TimeRegistrations",
                keyColumn: "TimeRegistrationId",
                keyValue: 685,
                columns: new[] { "EndTime", "StartTime" },
                values: new object[] { new DateTime(2024, 6, 2, 23, 58, 50, 0, DateTimeKind.Unspecified), new DateTime(2024, 4, 27, 7, 15, 45, 0, DateTimeKind.Unspecified) });

            migrationBuilder.UpdateData(
                table: "TimeRegistrations",
                keyColumn: "TimeRegistrationId",
                keyValue: 686,
                columns: new[] { "EndTime", "StartTime" },
                values: new object[] { new DateTime(2024, 8, 21, 7, 28, 22, 0, DateTimeKind.Unspecified), new DateTime(2024, 8, 1, 4, 57, 22, 0, DateTimeKind.Unspecified) });

            migrationBuilder.UpdateData(
                table: "TimeRegistrations",
                keyColumn: "TimeRegistrationId",
                keyValue: 687,
                columns: new[] { "EndTime", "StartTime" },
                values: new object[] { new DateTime(2024, 7, 26, 21, 41, 30, 0, DateTimeKind.Unspecified), new DateTime(2024, 3, 1, 3, 30, 14, 0, DateTimeKind.Unspecified) });

            migrationBuilder.UpdateData(
                table: "TimeRegistrations",
                keyColumn: "TimeRegistrationId",
                keyValue: 688,
                columns: new[] { "EndTime", "StartTime" },
                values: new object[] { new DateTime(2024, 9, 27, 9, 7, 39, 0, DateTimeKind.Unspecified), new DateTime(2024, 3, 18, 6, 29, 17, 0, DateTimeKind.Unspecified) });

            migrationBuilder.UpdateData(
                table: "TimeRegistrations",
                keyColumn: "TimeRegistrationId",
                keyValue: 689,
                columns: new[] { "EndTime", "StartTime" },
                values: new object[] { new DateTime(2024, 2, 10, 1, 1, 15, 0, DateTimeKind.Unspecified), new DateTime(2024, 12, 5, 2, 53, 21, 0, DateTimeKind.Unspecified) });

            migrationBuilder.UpdateData(
                table: "TimeRegistrations",
                keyColumn: "TimeRegistrationId",
                keyValue: 690,
                columns: new[] { "EndTime", "StartTime" },
                values: new object[] { new DateTime(2024, 5, 3, 5, 17, 30, 0, DateTimeKind.Unspecified), new DateTime(2024, 10, 3, 17, 10, 21, 0, DateTimeKind.Unspecified) });

            migrationBuilder.UpdateData(
                table: "TimeRegistrations",
                keyColumn: "TimeRegistrationId",
                keyValue: 691,
                columns: new[] { "EndTime", "StartTime" },
                values: new object[] { new DateTime(2024, 5, 22, 8, 47, 40, 0, DateTimeKind.Unspecified), new DateTime(2024, 3, 26, 12, 39, 14, 0, DateTimeKind.Unspecified) });

            migrationBuilder.UpdateData(
                table: "TimeRegistrations",
                keyColumn: "TimeRegistrationId",
                keyValue: 692,
                columns: new[] { "EndTime", "StartTime" },
                values: new object[] { new DateTime(2024, 7, 9, 8, 40, 23, 0, DateTimeKind.Unspecified), new DateTime(2024, 9, 14, 18, 56, 42, 0, DateTimeKind.Unspecified) });

            migrationBuilder.UpdateData(
                table: "TimeRegistrations",
                keyColumn: "TimeRegistrationId",
                keyValue: 693,
                columns: new[] { "EndTime", "StartTime" },
                values: new object[] { new DateTime(2024, 5, 10, 16, 49, 22, 0, DateTimeKind.Unspecified), new DateTime(2024, 6, 9, 22, 12, 28, 0, DateTimeKind.Unspecified) });

            migrationBuilder.UpdateData(
                table: "TimeRegistrations",
                keyColumn: "TimeRegistrationId",
                keyValue: 694,
                columns: new[] { "EndTime", "StartTime" },
                values: new object[] { new DateTime(2024, 8, 3, 16, 31, 15, 0, DateTimeKind.Unspecified), new DateTime(2024, 1, 6, 10, 34, 7, 0, DateTimeKind.Unspecified) });

            migrationBuilder.UpdateData(
                table: "TimeRegistrations",
                keyColumn: "TimeRegistrationId",
                keyValue: 695,
                columns: new[] { "EndTime", "StartTime" },
                values: new object[] { new DateTime(2024, 12, 4, 20, 24, 21, 0, DateTimeKind.Unspecified), new DateTime(2024, 11, 8, 16, 27, 4, 0, DateTimeKind.Unspecified) });

            migrationBuilder.UpdateData(
                table: "TimeRegistrations",
                keyColumn: "TimeRegistrationId",
                keyValue: 696,
                columns: new[] { "EndTime", "StartTime" },
                values: new object[] { new DateTime(2024, 9, 6, 3, 11, 7, 0, DateTimeKind.Unspecified), new DateTime(2024, 4, 20, 14, 9, 4, 0, DateTimeKind.Unspecified) });

            migrationBuilder.UpdateData(
                table: "TimeRegistrations",
                keyColumn: "TimeRegistrationId",
                keyValue: 697,
                columns: new[] { "EndTime", "StartTime" },
                values: new object[] { new DateTime(2024, 12, 4, 23, 8, 48, 0, DateTimeKind.Unspecified), new DateTime(2024, 4, 2, 5, 41, 9, 0, DateTimeKind.Unspecified) });

            migrationBuilder.UpdateData(
                table: "TimeRegistrations",
                keyColumn: "TimeRegistrationId",
                keyValue: 698,
                columns: new[] { "EndTime", "StartTime" },
                values: new object[] { new DateTime(2024, 8, 14, 14, 6, 34, 0, DateTimeKind.Unspecified), new DateTime(2024, 7, 28, 11, 59, 23, 0, DateTimeKind.Unspecified) });

            migrationBuilder.UpdateData(
                table: "TimeRegistrations",
                keyColumn: "TimeRegistrationId",
                keyValue: 699,
                columns: new[] { "EndTime", "StartTime" },
                values: new object[] { new DateTime(2024, 11, 7, 3, 55, 37, 0, DateTimeKind.Unspecified), new DateTime(2024, 1, 21, 17, 32, 38, 0, DateTimeKind.Unspecified) });

            migrationBuilder.UpdateData(
                table: "TimeRegistrations",
                keyColumn: "TimeRegistrationId",
                keyValue: 700,
                columns: new[] { "EndTime", "StartTime" },
                values: new object[] { new DateTime(2024, 12, 16, 3, 42, 40, 0, DateTimeKind.Unspecified), new DateTime(2024, 11, 1, 1, 1, 8, 0, DateTimeKind.Unspecified) });

            migrationBuilder.UpdateData(
                table: "TimeRegistrations",
                keyColumn: "TimeRegistrationId",
                keyValue: 701,
                columns: new[] { "EndTime", "StartTime" },
                values: new object[] { new DateTime(2024, 2, 9, 6, 36, 45, 0, DateTimeKind.Unspecified), new DateTime(2024, 3, 26, 22, 36, 48, 0, DateTimeKind.Unspecified) });

            migrationBuilder.UpdateData(
                table: "TimeRegistrations",
                keyColumn: "TimeRegistrationId",
                keyValue: 702,
                columns: new[] { "EndTime", "StartTime" },
                values: new object[] { new DateTime(2024, 1, 3, 17, 0, 17, 0, DateTimeKind.Unspecified), new DateTime(2024, 4, 14, 15, 0, 15, 0, DateTimeKind.Unspecified) });

            migrationBuilder.UpdateData(
                table: "TimeRegistrations",
                keyColumn: "TimeRegistrationId",
                keyValue: 703,
                columns: new[] { "EndTime", "StartTime" },
                values: new object[] { new DateTime(2024, 11, 11, 4, 52, 49, 0, DateTimeKind.Unspecified), new DateTime(2024, 1, 26, 18, 59, 39, 0, DateTimeKind.Unspecified) });

            migrationBuilder.UpdateData(
                table: "TimeRegistrations",
                keyColumn: "TimeRegistrationId",
                keyValue: 704,
                columns: new[] { "EndTime", "StartTime" },
                values: new object[] { new DateTime(2024, 11, 2, 0, 29, 18, 0, DateTimeKind.Unspecified), new DateTime(2024, 11, 4, 12, 6, 30, 0, DateTimeKind.Unspecified) });

            migrationBuilder.UpdateData(
                table: "TimeRegistrations",
                keyColumn: "TimeRegistrationId",
                keyValue: 705,
                columns: new[] { "EndTime", "StartTime" },
                values: new object[] { new DateTime(2024, 1, 1, 16, 58, 55, 0, DateTimeKind.Unspecified), new DateTime(2024, 10, 21, 7, 59, 40, 0, DateTimeKind.Unspecified) });

            migrationBuilder.UpdateData(
                table: "TimeRegistrations",
                keyColumn: "TimeRegistrationId",
                keyValue: 706,
                columns: new[] { "EndTime", "StartTime" },
                values: new object[] { new DateTime(2024, 8, 2, 18, 52, 2, 0, DateTimeKind.Unspecified), new DateTime(2024, 1, 28, 13, 52, 36, 0, DateTimeKind.Unspecified) });

            migrationBuilder.UpdateData(
                table: "TimeRegistrations",
                keyColumn: "TimeRegistrationId",
                keyValue: 707,
                columns: new[] { "EndTime", "StartTime" },
                values: new object[] { new DateTime(2024, 4, 14, 17, 44, 7, 0, DateTimeKind.Unspecified), new DateTime(2024, 6, 25, 4, 11, 47, 0, DateTimeKind.Unspecified) });

            migrationBuilder.UpdateData(
                table: "TimeRegistrations",
                keyColumn: "TimeRegistrationId",
                keyValue: 708,
                columns: new[] { "EndTime", "StartTime" },
                values: new object[] { new DateTime(2024, 4, 7, 16, 20, 37, 0, DateTimeKind.Unspecified), new DateTime(2024, 2, 12, 15, 44, 11, 0, DateTimeKind.Unspecified) });

            migrationBuilder.UpdateData(
                table: "TimeRegistrations",
                keyColumn: "TimeRegistrationId",
                keyValue: 709,
                columns: new[] { "EndTime", "StartTime" },
                values: new object[] { new DateTime(2024, 9, 8, 16, 50, 55, 0, DateTimeKind.Unspecified), new DateTime(2024, 5, 17, 4, 32, 52, 0, DateTimeKind.Unspecified) });

            migrationBuilder.UpdateData(
                table: "TimeRegistrations",
                keyColumn: "TimeRegistrationId",
                keyValue: 710,
                columns: new[] { "EndTime", "StartTime" },
                values: new object[] { new DateTime(2024, 4, 22, 7, 35, 59, 0, DateTimeKind.Unspecified), new DateTime(2024, 8, 28, 22, 47, 45, 0, DateTimeKind.Unspecified) });

            migrationBuilder.UpdateData(
                table: "TimeRegistrations",
                keyColumn: "TimeRegistrationId",
                keyValue: 711,
                columns: new[] { "EndTime", "StartTime" },
                values: new object[] { new DateTime(2024, 4, 12, 8, 42, 26, 0, DateTimeKind.Unspecified), new DateTime(2024, 3, 22, 1, 57, 15, 0, DateTimeKind.Unspecified) });

            migrationBuilder.UpdateData(
                table: "TimeRegistrations",
                keyColumn: "TimeRegistrationId",
                keyValue: 712,
                columns: new[] { "EndTime", "StartTime" },
                values: new object[] { new DateTime(2024, 2, 26, 21, 46, 7, 0, DateTimeKind.Unspecified), new DateTime(2024, 8, 1, 10, 18, 38, 0, DateTimeKind.Unspecified) });

            migrationBuilder.UpdateData(
                table: "TimeRegistrations",
                keyColumn: "TimeRegistrationId",
                keyValue: 713,
                columns: new[] { "EndTime", "StartTime" },
                values: new object[] { new DateTime(2024, 8, 29, 18, 40, 26, 0, DateTimeKind.Unspecified), new DateTime(2024, 9, 26, 17, 22, 27, 0, DateTimeKind.Unspecified) });

            migrationBuilder.UpdateData(
                table: "TimeRegistrations",
                keyColumn: "TimeRegistrationId",
                keyValue: 714,
                columns: new[] { "EndTime", "StartTime" },
                values: new object[] { new DateTime(2024, 5, 16, 4, 27, 10, 0, DateTimeKind.Unspecified), new DateTime(2024, 5, 4, 9, 8, 59, 0, DateTimeKind.Unspecified) });

            migrationBuilder.UpdateData(
                table: "TimeRegistrations",
                keyColumn: "TimeRegistrationId",
                keyValue: 715,
                columns: new[] { "EndTime", "StartTime" },
                values: new object[] { new DateTime(2024, 12, 17, 4, 55, 3, 0, DateTimeKind.Unspecified), new DateTime(2024, 11, 28, 16, 46, 32, 0, DateTimeKind.Unspecified) });

            migrationBuilder.UpdateData(
                table: "TimeRegistrations",
                keyColumn: "TimeRegistrationId",
                keyValue: 716,
                columns: new[] { "EndTime", "StartTime" },
                values: new object[] { new DateTime(2024, 4, 26, 4, 41, 46, 0, DateTimeKind.Unspecified), new DateTime(2024, 8, 7, 0, 24, 59, 0, DateTimeKind.Unspecified) });

            migrationBuilder.UpdateData(
                table: "TimeRegistrations",
                keyColumn: "TimeRegistrationId",
                keyValue: 717,
                columns: new[] { "EndTime", "StartTime" },
                values: new object[] { new DateTime(2024, 8, 8, 12, 18, 30, 0, DateTimeKind.Unspecified), new DateTime(2024, 8, 30, 20, 11, 5, 0, DateTimeKind.Unspecified) });

            migrationBuilder.UpdateData(
                table: "TimeRegistrations",
                keyColumn: "TimeRegistrationId",
                keyValue: 718,
                columns: new[] { "EndTime", "StartTime" },
                values: new object[] { new DateTime(2024, 2, 1, 4, 48, 11, 0, DateTimeKind.Unspecified), new DateTime(2024, 6, 11, 8, 30, 25, 0, DateTimeKind.Unspecified) });

            migrationBuilder.UpdateData(
                table: "TimeRegistrations",
                keyColumn: "TimeRegistrationId",
                keyValue: 719,
                columns: new[] { "EndTime", "StartTime" },
                values: new object[] { new DateTime(2024, 2, 18, 19, 31, 10, 0, DateTimeKind.Unspecified), new DateTime(2024, 5, 1, 21, 6, 41, 0, DateTimeKind.Unspecified) });

            migrationBuilder.UpdateData(
                table: "TimeRegistrations",
                keyColumn: "TimeRegistrationId",
                keyValue: 720,
                columns: new[] { "EndTime", "StartTime" },
                values: new object[] { new DateTime(2024, 11, 21, 23, 38, 40, 0, DateTimeKind.Unspecified), new DateTime(2024, 12, 4, 9, 41, 17, 0, DateTimeKind.Unspecified) });

            migrationBuilder.UpdateData(
                table: "TimeRegistrations",
                keyColumn: "TimeRegistrationId",
                keyValue: 721,
                columns: new[] { "EndTime", "StartTime" },
                values: new object[] { new DateTime(2024, 8, 2, 0, 46, 44, 0, DateTimeKind.Unspecified), new DateTime(2024, 12, 8, 2, 31, 12, 0, DateTimeKind.Unspecified) });

            migrationBuilder.UpdateData(
                table: "TimeRegistrations",
                keyColumn: "TimeRegistrationId",
                keyValue: 722,
                columns: new[] { "EndTime", "StartTime" },
                values: new object[] { new DateTime(2024, 4, 28, 16, 16, 59, 0, DateTimeKind.Unspecified), new DateTime(2024, 7, 31, 14, 28, 18, 0, DateTimeKind.Unspecified) });

            migrationBuilder.UpdateData(
                table: "TimeRegistrations",
                keyColumn: "TimeRegistrationId",
                keyValue: 723,
                columns: new[] { "EndTime", "StartTime" },
                values: new object[] { new DateTime(2024, 12, 20, 7, 48, 49, 0, DateTimeKind.Unspecified), new DateTime(2024, 2, 19, 5, 44, 23, 0, DateTimeKind.Unspecified) });

            migrationBuilder.UpdateData(
                table: "TimeRegistrations",
                keyColumn: "TimeRegistrationId",
                keyValue: 724,
                columns: new[] { "EndTime", "StartTime" },
                values: new object[] { new DateTime(2024, 9, 9, 19, 44, 57, 0, DateTimeKind.Unspecified), new DateTime(2024, 3, 10, 16, 37, 20, 0, DateTimeKind.Unspecified) });

            migrationBuilder.UpdateData(
                table: "TimeRegistrations",
                keyColumn: "TimeRegistrationId",
                keyValue: 725,
                columns: new[] { "EndTime", "StartTime" },
                values: new object[] { new DateTime(2024, 1, 26, 11, 20, 37, 0, DateTimeKind.Unspecified), new DateTime(2024, 5, 9, 17, 14, 26, 0, DateTimeKind.Unspecified) });

            migrationBuilder.UpdateData(
                table: "TimeRegistrations",
                keyColumn: "TimeRegistrationId",
                keyValue: 726,
                columns: new[] { "EndTime", "StartTime" },
                values: new object[] { new DateTime(2024, 4, 15, 0, 52, 44, 0, DateTimeKind.Unspecified), new DateTime(2024, 10, 24, 19, 58, 6, 0, DateTimeKind.Unspecified) });

            migrationBuilder.UpdateData(
                table: "TimeRegistrations",
                keyColumn: "TimeRegistrationId",
                keyValue: 727,
                columns: new[] { "EndTime", "StartTime" },
                values: new object[] { new DateTime(2024, 9, 1, 10, 42, 9, 0, DateTimeKind.Unspecified), new DateTime(2024, 4, 9, 13, 6, 31, 0, DateTimeKind.Unspecified) });

            migrationBuilder.UpdateData(
                table: "TimeRegistrations",
                keyColumn: "TimeRegistrationId",
                keyValue: 728,
                columns: new[] { "EndTime", "StartTime" },
                values: new object[] { new DateTime(2024, 10, 8, 16, 46, 5, 0, DateTimeKind.Unspecified), new DateTime(2024, 8, 9, 12, 29, 18, 0, DateTimeKind.Unspecified) });

            migrationBuilder.UpdateData(
                table: "TimeRegistrations",
                keyColumn: "TimeRegistrationId",
                keyValue: 729,
                columns: new[] { "EndTime", "StartTime" },
                values: new object[] { new DateTime(2024, 12, 17, 20, 54, 15, 0, DateTimeKind.Unspecified), new DateTime(2024, 9, 19, 7, 29, 32, 0, DateTimeKind.Unspecified) });

            migrationBuilder.UpdateData(
                table: "TimeRegistrations",
                keyColumn: "TimeRegistrationId",
                keyValue: 730,
                columns: new[] { "EndTime", "StartTime" },
                values: new object[] { new DateTime(2024, 10, 11, 12, 51, 34, 0, DateTimeKind.Unspecified), new DateTime(2024, 1, 2, 13, 58, 42, 0, DateTimeKind.Unspecified) });

            migrationBuilder.UpdateData(
                table: "TimeRegistrations",
                keyColumn: "TimeRegistrationId",
                keyValue: 731,
                columns: new[] { "EndTime", "StartTime" },
                values: new object[] { new DateTime(2024, 6, 7, 19, 35, 37, 0, DateTimeKind.Unspecified), new DateTime(2024, 7, 2, 3, 8, 44, 0, DateTimeKind.Unspecified) });

            migrationBuilder.UpdateData(
                table: "TimeRegistrations",
                keyColumn: "TimeRegistrationId",
                keyValue: 732,
                columns: new[] { "EndTime", "StartTime" },
                values: new object[] { new DateTime(2024, 11, 4, 11, 35, 23, 0, DateTimeKind.Unspecified), new DateTime(2024, 4, 11, 17, 57, 5, 0, DateTimeKind.Unspecified) });

            migrationBuilder.UpdateData(
                table: "TimeRegistrations",
                keyColumn: "TimeRegistrationId",
                keyValue: 733,
                columns: new[] { "EndTime", "StartTime" },
                values: new object[] { new DateTime(2024, 3, 4, 18, 47, 3, 0, DateTimeKind.Unspecified), new DateTime(2024, 4, 25, 3, 15, 15, 0, DateTimeKind.Unspecified) });

            migrationBuilder.UpdateData(
                table: "TimeRegistrations",
                keyColumn: "TimeRegistrationId",
                keyValue: 734,
                columns: new[] { "EndTime", "StartTime" },
                values: new object[] { new DateTime(2024, 10, 3, 7, 35, 47, 0, DateTimeKind.Unspecified), new DateTime(2024, 12, 21, 12, 34, 55, 0, DateTimeKind.Unspecified) });

            migrationBuilder.UpdateData(
                table: "TimeRegistrations",
                keyColumn: "TimeRegistrationId",
                keyValue: 735,
                columns: new[] { "EndTime", "StartTime" },
                values: new object[] { new DateTime(2024, 10, 14, 9, 53, 18, 0, DateTimeKind.Unspecified), new DateTime(2024, 9, 2, 2, 30, 30, 0, DateTimeKind.Unspecified) });

            migrationBuilder.UpdateData(
                table: "TimeRegistrations",
                keyColumn: "TimeRegistrationId",
                keyValue: 736,
                columns: new[] { "EndTime", "StartTime" },
                values: new object[] { new DateTime(2024, 2, 16, 17, 22, 51, 0, DateTimeKind.Unspecified), new DateTime(2024, 5, 7, 13, 20, 17, 0, DateTimeKind.Unspecified) });

            migrationBuilder.UpdateData(
                table: "TimeRegistrations",
                keyColumn: "TimeRegistrationId",
                keyValue: 737,
                columns: new[] { "EndTime", "StartTime" },
                values: new object[] { new DateTime(2024, 10, 31, 2, 28, 29, 0, DateTimeKind.Unspecified), new DateTime(2024, 1, 23, 8, 41, 35, 0, DateTimeKind.Unspecified) });

            migrationBuilder.UpdateData(
                table: "TimeRegistrations",
                keyColumn: "TimeRegistrationId",
                keyValue: 738,
                columns: new[] { "EndTime", "StartTime" },
                values: new object[] { new DateTime(2024, 2, 3, 16, 31, 23, 0, DateTimeKind.Unspecified), new DateTime(2024, 6, 28, 14, 57, 41, 0, DateTimeKind.Unspecified) });

            migrationBuilder.UpdateData(
                table: "TimeRegistrations",
                keyColumn: "TimeRegistrationId",
                keyValue: 739,
                columns: new[] { "EndTime", "StartTime" },
                values: new object[] { new DateTime(2024, 4, 11, 19, 22, 58, 0, DateTimeKind.Unspecified), new DateTime(2024, 2, 18, 13, 54, 9, 0, DateTimeKind.Unspecified) });

            migrationBuilder.UpdateData(
                table: "TimeRegistrations",
                keyColumn: "TimeRegistrationId",
                keyValue: 740,
                columns: new[] { "EndTime", "StartTime" },
                values: new object[] { new DateTime(2024, 4, 15, 12, 38, 17, 0, DateTimeKind.Unspecified), new DateTime(2024, 11, 22, 8, 7, 52, 0, DateTimeKind.Unspecified) });

            migrationBuilder.UpdateData(
                table: "TimeRegistrations",
                keyColumn: "TimeRegistrationId",
                keyValue: 741,
                columns: new[] { "EndTime", "StartTime" },
                values: new object[] { new DateTime(2024, 6, 24, 13, 30, 24, 0, DateTimeKind.Unspecified), new DateTime(2024, 8, 22, 22, 49, 47, 0, DateTimeKind.Unspecified) });

            migrationBuilder.UpdateData(
                table: "TimeRegistrations",
                keyColumn: "TimeRegistrationId",
                keyValue: 742,
                columns: new[] { "EndTime", "StartTime" },
                values: new object[] { new DateTime(2024, 4, 23, 17, 30, 24, 0, DateTimeKind.Unspecified), new DateTime(2024, 7, 7, 7, 46, 16, 0, DateTimeKind.Unspecified) });

            migrationBuilder.UpdateData(
                table: "TimeRegistrations",
                keyColumn: "TimeRegistrationId",
                keyValue: 743,
                columns: new[] { "EndTime", "StartTime" },
                values: new object[] { new DateTime(2024, 3, 23, 17, 15, 4, 0, DateTimeKind.Unspecified), new DateTime(2024, 11, 23, 4, 29, 3, 0, DateTimeKind.Unspecified) });

            migrationBuilder.UpdateData(
                table: "TimeRegistrations",
                keyColumn: "TimeRegistrationId",
                keyValue: 744,
                columns: new[] { "EndTime", "StartTime" },
                values: new object[] { new DateTime(2024, 5, 25, 5, 57, 26, 0, DateTimeKind.Unspecified), new DateTime(2024, 7, 9, 3, 26, 34, 0, DateTimeKind.Unspecified) });

            migrationBuilder.UpdateData(
                table: "TimeRegistrations",
                keyColumn: "TimeRegistrationId",
                keyValue: 745,
                columns: new[] { "EndTime", "StartTime" },
                values: new object[] { new DateTime(2024, 6, 12, 20, 44, 0, 0, DateTimeKind.Unspecified), new DateTime(2024, 10, 1, 12, 48, 32, 0, DateTimeKind.Unspecified) });

            migrationBuilder.UpdateData(
                table: "TimeRegistrations",
                keyColumn: "TimeRegistrationId",
                keyValue: 746,
                columns: new[] { "EndTime", "StartTime" },
                values: new object[] { new DateTime(2024, 1, 4, 14, 37, 38, 0, DateTimeKind.Unspecified), new DateTime(2024, 10, 8, 19, 57, 8, 0, DateTimeKind.Unspecified) });

            migrationBuilder.UpdateData(
                table: "TimeRegistrations",
                keyColumn: "TimeRegistrationId",
                keyValue: 747,
                columns: new[] { "EndTime", "StartTime" },
                values: new object[] { new DateTime(2024, 8, 23, 4, 1, 50, 0, DateTimeKind.Unspecified), new DateTime(2024, 9, 2, 22, 9, 49, 0, DateTimeKind.Unspecified) });

            migrationBuilder.UpdateData(
                table: "TimeRegistrations",
                keyColumn: "TimeRegistrationId",
                keyValue: 748,
                columns: new[] { "EndTime", "StartTime" },
                values: new object[] { new DateTime(2024, 1, 14, 5, 56, 50, 0, DateTimeKind.Unspecified), new DateTime(2024, 3, 30, 23, 21, 19, 0, DateTimeKind.Unspecified) });

            migrationBuilder.UpdateData(
                table: "TimeRegistrations",
                keyColumn: "TimeRegistrationId",
                keyValue: 749,
                columns: new[] { "EndTime", "StartTime" },
                values: new object[] { new DateTime(2024, 9, 13, 18, 14, 53, 0, DateTimeKind.Unspecified), new DateTime(2024, 9, 24, 13, 53, 53, 0, DateTimeKind.Unspecified) });

            migrationBuilder.UpdateData(
                table: "TimeRegistrations",
                keyColumn: "TimeRegistrationId",
                keyValue: 750,
                columns: new[] { "EndTime", "StartTime" },
                values: new object[] { new DateTime(2024, 11, 15, 20, 34, 5, 0, DateTimeKind.Unspecified), new DateTime(2024, 9, 20, 5, 16, 15, 0, DateTimeKind.Unspecified) });

            migrationBuilder.UpdateData(
                table: "TimeRegistrations",
                keyColumn: "TimeRegistrationId",
                keyValue: 751,
                columns: new[] { "EndTime", "StartTime" },
                values: new object[] { new DateTime(2024, 9, 9, 22, 1, 51, 0, DateTimeKind.Unspecified), new DateTime(2024, 12, 19, 0, 57, 9, 0, DateTimeKind.Unspecified) });

            migrationBuilder.UpdateData(
                table: "TimeRegistrations",
                keyColumn: "TimeRegistrationId",
                keyValue: 752,
                columns: new[] { "EndTime", "StartTime" },
                values: new object[] { new DateTime(2024, 9, 30, 18, 54, 3, 0, DateTimeKind.Unspecified), new DateTime(2024, 12, 23, 12, 40, 46, 0, DateTimeKind.Unspecified) });

            migrationBuilder.UpdateData(
                table: "TimeRegistrations",
                keyColumn: "TimeRegistrationId",
                keyValue: 753,
                columns: new[] { "EndTime", "StartTime" },
                values: new object[] { new DateTime(2024, 2, 14, 21, 4, 18, 0, DateTimeKind.Unspecified), new DateTime(2024, 6, 1, 10, 20, 46, 0, DateTimeKind.Unspecified) });

            migrationBuilder.UpdateData(
                table: "TimeRegistrations",
                keyColumn: "TimeRegistrationId",
                keyValue: 754,
                columns: new[] { "EndTime", "StartTime" },
                values: new object[] { new DateTime(2024, 12, 28, 9, 14, 50, 0, DateTimeKind.Unspecified), new DateTime(2024, 1, 26, 11, 29, 35, 0, DateTimeKind.Unspecified) });

            migrationBuilder.UpdateData(
                table: "TimeRegistrations",
                keyColumn: "TimeRegistrationId",
                keyValue: 755,
                columns: new[] { "EndTime", "StartTime" },
                values: new object[] { new DateTime(2024, 11, 29, 15, 29, 17, 0, DateTimeKind.Unspecified), new DateTime(2024, 8, 13, 11, 11, 32, 0, DateTimeKind.Unspecified) });

            migrationBuilder.UpdateData(
                table: "TimeRegistrations",
                keyColumn: "TimeRegistrationId",
                keyValue: 756,
                columns: new[] { "EndTime", "StartTime" },
                values: new object[] { new DateTime(2024, 10, 12, 22, 45, 7, 0, DateTimeKind.Unspecified), new DateTime(2024, 2, 20, 8, 0, 5, 0, DateTimeKind.Unspecified) });

            migrationBuilder.UpdateData(
                table: "TimeRegistrations",
                keyColumn: "TimeRegistrationId",
                keyValue: 757,
                columns: new[] { "EndTime", "StartTime" },
                values: new object[] { new DateTime(2024, 1, 25, 7, 5, 42, 0, DateTimeKind.Unspecified), new DateTime(2024, 8, 29, 1, 28, 43, 0, DateTimeKind.Unspecified) });

            migrationBuilder.UpdateData(
                table: "TimeRegistrations",
                keyColumn: "TimeRegistrationId",
                keyValue: 758,
                columns: new[] { "EndTime", "StartTime" },
                values: new object[] { new DateTime(2024, 9, 9, 4, 1, 53, 0, DateTimeKind.Unspecified), new DateTime(2024, 7, 2, 3, 32, 15, 0, DateTimeKind.Unspecified) });

            migrationBuilder.UpdateData(
                table: "TimeRegistrations",
                keyColumn: "TimeRegistrationId",
                keyValue: 759,
                columns: new[] { "EndTime", "StartTime" },
                values: new object[] { new DateTime(2024, 1, 6, 20, 29, 44, 0, DateTimeKind.Unspecified), new DateTime(2024, 2, 26, 8, 4, 9, 0, DateTimeKind.Unspecified) });

            migrationBuilder.UpdateData(
                table: "TimeRegistrations",
                keyColumn: "TimeRegistrationId",
                keyValue: 760,
                columns: new[] { "EndTime", "StartTime" },
                values: new object[] { new DateTime(2024, 8, 24, 18, 59, 29, 0, DateTimeKind.Unspecified), new DateTime(2024, 10, 22, 12, 17, 55, 0, DateTimeKind.Unspecified) });

            migrationBuilder.UpdateData(
                table: "TimeRegistrations",
                keyColumn: "TimeRegistrationId",
                keyValue: 761,
                columns: new[] { "EndTime", "StartTime" },
                values: new object[] { new DateTime(2024, 9, 13, 9, 2, 26, 0, DateTimeKind.Unspecified), new DateTime(2024, 5, 9, 1, 48, 56, 0, DateTimeKind.Unspecified) });

            migrationBuilder.UpdateData(
                table: "TimeRegistrations",
                keyColumn: "TimeRegistrationId",
                keyValue: 762,
                columns: new[] { "EndTime", "StartTime" },
                values: new object[] { new DateTime(2024, 2, 13, 8, 23, 32, 0, DateTimeKind.Unspecified), new DateTime(2024, 2, 18, 16, 57, 8, 0, DateTimeKind.Unspecified) });

            migrationBuilder.UpdateData(
                table: "TimeRegistrations",
                keyColumn: "TimeRegistrationId",
                keyValue: 763,
                columns: new[] { "EndTime", "StartTime" },
                values: new object[] { new DateTime(2024, 3, 1, 0, 40, 5, 0, DateTimeKind.Unspecified), new DateTime(2024, 2, 16, 10, 12, 9, 0, DateTimeKind.Unspecified) });

            migrationBuilder.UpdateData(
                table: "TimeRegistrations",
                keyColumn: "TimeRegistrationId",
                keyValue: 764,
                columns: new[] { "EndTime", "StartTime" },
                values: new object[] { new DateTime(2024, 2, 21, 11, 4, 9, 0, DateTimeKind.Unspecified), new DateTime(2024, 7, 8, 13, 8, 29, 0, DateTimeKind.Unspecified) });

            migrationBuilder.UpdateData(
                table: "TimeRegistrations",
                keyColumn: "TimeRegistrationId",
                keyValue: 765,
                columns: new[] { "EndTime", "StartTime" },
                values: new object[] { new DateTime(2024, 11, 29, 6, 38, 1, 0, DateTimeKind.Unspecified), new DateTime(2024, 8, 25, 21, 13, 36, 0, DateTimeKind.Unspecified) });

            migrationBuilder.UpdateData(
                table: "TimeRegistrations",
                keyColumn: "TimeRegistrationId",
                keyValue: 766,
                columns: new[] { "EndTime", "StartTime" },
                values: new object[] { new DateTime(2024, 2, 2, 15, 8, 12, 0, DateTimeKind.Unspecified), new DateTime(2024, 5, 22, 0, 13, 35, 0, DateTimeKind.Unspecified) });

            migrationBuilder.UpdateData(
                table: "TimeRegistrations",
                keyColumn: "TimeRegistrationId",
                keyValue: 767,
                columns: new[] { "EndTime", "StartTime" },
                values: new object[] { new DateTime(2024, 6, 16, 8, 53, 7, 0, DateTimeKind.Unspecified), new DateTime(2024, 9, 1, 22, 5, 43, 0, DateTimeKind.Unspecified) });

            migrationBuilder.UpdateData(
                table: "TimeRegistrations",
                keyColumn: "TimeRegistrationId",
                keyValue: 768,
                columns: new[] { "EndTime", "StartTime" },
                values: new object[] { new DateTime(2024, 7, 25, 7, 31, 33, 0, DateTimeKind.Unspecified), new DateTime(2024, 9, 8, 13, 56, 54, 0, DateTimeKind.Unspecified) });

            migrationBuilder.UpdateData(
                table: "TimeRegistrations",
                keyColumn: "TimeRegistrationId",
                keyValue: 769,
                columns: new[] { "EndTime", "StartTime" },
                values: new object[] { new DateTime(2024, 4, 11, 22, 21, 37, 0, DateTimeKind.Unspecified), new DateTime(2024, 11, 28, 15, 26, 5, 0, DateTimeKind.Unspecified) });

            migrationBuilder.UpdateData(
                table: "TimeRegistrations",
                keyColumn: "TimeRegistrationId",
                keyValue: 770,
                columns: new[] { "EndTime", "StartTime" },
                values: new object[] { new DateTime(2024, 4, 7, 23, 0, 36, 0, DateTimeKind.Unspecified), new DateTime(2024, 5, 12, 4, 57, 10, 0, DateTimeKind.Unspecified) });

            migrationBuilder.UpdateData(
                table: "TimeRegistrations",
                keyColumn: "TimeRegistrationId",
                keyValue: 771,
                columns: new[] { "EndTime", "StartTime" },
                values: new object[] { new DateTime(2024, 11, 11, 2, 9, 20, 0, DateTimeKind.Unspecified), new DateTime(2024, 11, 11, 19, 48, 51, 0, DateTimeKind.Unspecified) });

            migrationBuilder.UpdateData(
                table: "TimeRegistrations",
                keyColumn: "TimeRegistrationId",
                keyValue: 772,
                columns: new[] { "EndTime", "StartTime" },
                values: new object[] { new DateTime(2024, 2, 4, 22, 31, 48, 0, DateTimeKind.Unspecified), new DateTime(2024, 1, 22, 8, 30, 39, 0, DateTimeKind.Unspecified) });

            migrationBuilder.UpdateData(
                table: "TimeRegistrations",
                keyColumn: "TimeRegistrationId",
                keyValue: 773,
                columns: new[] { "EndTime", "StartTime" },
                values: new object[] { new DateTime(2024, 10, 2, 18, 41, 29, 0, DateTimeKind.Unspecified), new DateTime(2024, 7, 28, 6, 24, 41, 0, DateTimeKind.Unspecified) });

            migrationBuilder.UpdateData(
                table: "TimeRegistrations",
                keyColumn: "TimeRegistrationId",
                keyValue: 774,
                columns: new[] { "EndTime", "StartTime" },
                values: new object[] { new DateTime(2024, 5, 9, 19, 7, 45, 0, DateTimeKind.Unspecified), new DateTime(2024, 2, 20, 13, 3, 21, 0, DateTimeKind.Unspecified) });

            migrationBuilder.UpdateData(
                table: "TimeRegistrations",
                keyColumn: "TimeRegistrationId",
                keyValue: 775,
                columns: new[] { "EndTime", "StartTime" },
                values: new object[] { new DateTime(2024, 12, 21, 2, 32, 21, 0, DateTimeKind.Unspecified), new DateTime(2024, 6, 30, 18, 33, 4, 0, DateTimeKind.Unspecified) });

            migrationBuilder.UpdateData(
                table: "TimeRegistrations",
                keyColumn: "TimeRegistrationId",
                keyValue: 776,
                columns: new[] { "EndTime", "StartTime" },
                values: new object[] { new DateTime(2024, 3, 7, 2, 12, 16, 0, DateTimeKind.Unspecified), new DateTime(2024, 2, 12, 15, 57, 6, 0, DateTimeKind.Unspecified) });

            migrationBuilder.UpdateData(
                table: "TimeRegistrations",
                keyColumn: "TimeRegistrationId",
                keyValue: 777,
                columns: new[] { "EndTime", "StartTime" },
                values: new object[] { new DateTime(2024, 6, 4, 22, 22, 11, 0, DateTimeKind.Unspecified), new DateTime(2024, 1, 11, 18, 55, 56, 0, DateTimeKind.Unspecified) });

            migrationBuilder.UpdateData(
                table: "TimeRegistrations",
                keyColumn: "TimeRegistrationId",
                keyValue: 778,
                columns: new[] { "EndTime", "StartTime" },
                values: new object[] { new DateTime(2024, 2, 20, 1, 27, 49, 0, DateTimeKind.Unspecified), new DateTime(2024, 3, 18, 0, 9, 28, 0, DateTimeKind.Unspecified) });

            migrationBuilder.UpdateData(
                table: "TimeRegistrations",
                keyColumn: "TimeRegistrationId",
                keyValue: 779,
                columns: new[] { "EndTime", "StartTime" },
                values: new object[] { new DateTime(2024, 11, 19, 23, 35, 40, 0, DateTimeKind.Unspecified), new DateTime(2024, 6, 22, 5, 16, 10, 0, DateTimeKind.Unspecified) });

            migrationBuilder.UpdateData(
                table: "TimeRegistrations",
                keyColumn: "TimeRegistrationId",
                keyValue: 780,
                columns: new[] { "EndTime", "StartTime" },
                values: new object[] { new DateTime(2024, 9, 7, 1, 44, 35, 0, DateTimeKind.Unspecified), new DateTime(2024, 11, 23, 4, 12, 34, 0, DateTimeKind.Unspecified) });

            migrationBuilder.UpdateData(
                table: "TimeRegistrations",
                keyColumn: "TimeRegistrationId",
                keyValue: 781,
                columns: new[] { "EndTime", "StartTime" },
                values: new object[] { new DateTime(2024, 11, 1, 22, 13, 21, 0, DateTimeKind.Unspecified), new DateTime(2024, 7, 2, 22, 57, 27, 0, DateTimeKind.Unspecified) });

            migrationBuilder.UpdateData(
                table: "TimeRegistrations",
                keyColumn: "TimeRegistrationId",
                keyValue: 782,
                columns: new[] { "EndTime", "StartTime" },
                values: new object[] { new DateTime(2024, 1, 7, 18, 35, 26, 0, DateTimeKind.Unspecified), new DateTime(2024, 7, 23, 8, 30, 31, 0, DateTimeKind.Unspecified) });

            migrationBuilder.UpdateData(
                table: "TimeRegistrations",
                keyColumn: "TimeRegistrationId",
                keyValue: 783,
                columns: new[] { "EndTime", "StartTime" },
                values: new object[] { new DateTime(2024, 3, 18, 5, 0, 16, 0, DateTimeKind.Unspecified), new DateTime(2024, 1, 28, 0, 8, 53, 0, DateTimeKind.Unspecified) });

            migrationBuilder.UpdateData(
                table: "TimeRegistrations",
                keyColumn: "TimeRegistrationId",
                keyValue: 784,
                columns: new[] { "EndTime", "StartTime" },
                values: new object[] { new DateTime(2024, 2, 21, 15, 41, 43, 0, DateTimeKind.Unspecified), new DateTime(2024, 9, 24, 19, 22, 7, 0, DateTimeKind.Unspecified) });

            migrationBuilder.UpdateData(
                table: "TimeRegistrations",
                keyColumn: "TimeRegistrationId",
                keyValue: 785,
                columns: new[] { "EndTime", "StartTime" },
                values: new object[] { new DateTime(2024, 7, 26, 9, 4, 50, 0, DateTimeKind.Unspecified), new DateTime(2024, 5, 15, 10, 28, 2, 0, DateTimeKind.Unspecified) });

            migrationBuilder.UpdateData(
                table: "TimeRegistrations",
                keyColumn: "TimeRegistrationId",
                keyValue: 786,
                columns: new[] { "EndTime", "StartTime" },
                values: new object[] { new DateTime(2024, 4, 21, 6, 55, 10, 0, DateTimeKind.Unspecified), new DateTime(2024, 5, 9, 23, 36, 1, 0, DateTimeKind.Unspecified) });

            migrationBuilder.UpdateData(
                table: "TimeRegistrations",
                keyColumn: "TimeRegistrationId",
                keyValue: 787,
                columns: new[] { "EndTime", "StartTime" },
                values: new object[] { new DateTime(2024, 2, 21, 23, 24, 20, 0, DateTimeKind.Unspecified), new DateTime(2024, 7, 25, 3, 28, 29, 0, DateTimeKind.Unspecified) });

            migrationBuilder.UpdateData(
                table: "TimeRegistrations",
                keyColumn: "TimeRegistrationId",
                keyValue: 788,
                columns: new[] { "EndTime", "StartTime" },
                values: new object[] { new DateTime(2024, 3, 16, 15, 10, 16, 0, DateTimeKind.Unspecified), new DateTime(2024, 7, 18, 3, 25, 20, 0, DateTimeKind.Unspecified) });

            migrationBuilder.UpdateData(
                table: "TimeRegistrations",
                keyColumn: "TimeRegistrationId",
                keyValue: 789,
                columns: new[] { "EndTime", "StartTime" },
                values: new object[] { new DateTime(2024, 12, 28, 6, 43, 50, 0, DateTimeKind.Unspecified), new DateTime(2024, 8, 21, 8, 20, 59, 0, DateTimeKind.Unspecified) });

            migrationBuilder.UpdateData(
                table: "TimeRegistrations",
                keyColumn: "TimeRegistrationId",
                keyValue: 790,
                columns: new[] { "EndTime", "StartTime" },
                values: new object[] { new DateTime(2024, 5, 10, 17, 2, 43, 0, DateTimeKind.Unspecified), new DateTime(2024, 8, 25, 4, 49, 47, 0, DateTimeKind.Unspecified) });

            migrationBuilder.UpdateData(
                table: "TimeRegistrations",
                keyColumn: "TimeRegistrationId",
                keyValue: 791,
                columns: new[] { "EndTime", "StartTime" },
                values: new object[] { new DateTime(2024, 9, 24, 3, 12, 39, 0, DateTimeKind.Unspecified), new DateTime(2024, 10, 18, 18, 40, 9, 0, DateTimeKind.Unspecified) });

            migrationBuilder.UpdateData(
                table: "TimeRegistrations",
                keyColumn: "TimeRegistrationId",
                keyValue: 792,
                columns: new[] { "EndTime", "StartTime" },
                values: new object[] { new DateTime(2024, 9, 22, 22, 27, 22, 0, DateTimeKind.Unspecified), new DateTime(2024, 11, 8, 17, 16, 52, 0, DateTimeKind.Unspecified) });

            migrationBuilder.UpdateData(
                table: "TimeRegistrations",
                keyColumn: "TimeRegistrationId",
                keyValue: 793,
                columns: new[] { "EndTime", "StartTime" },
                values: new object[] { new DateTime(2024, 12, 25, 10, 36, 41, 0, DateTimeKind.Unspecified), new DateTime(2024, 9, 1, 18, 15, 52, 0, DateTimeKind.Unspecified) });

            migrationBuilder.UpdateData(
                table: "TimeRegistrations",
                keyColumn: "TimeRegistrationId",
                keyValue: 794,
                columns: new[] { "EndTime", "StartTime" },
                values: new object[] { new DateTime(2024, 7, 28, 14, 3, 46, 0, DateTimeKind.Unspecified), new DateTime(2024, 10, 10, 18, 2, 11, 0, DateTimeKind.Unspecified) });

            migrationBuilder.UpdateData(
                table: "TimeRegistrations",
                keyColumn: "TimeRegistrationId",
                keyValue: 795,
                columns: new[] { "EndTime", "StartTime" },
                values: new object[] { new DateTime(2024, 11, 20, 1, 16, 50, 0, DateTimeKind.Unspecified), new DateTime(2024, 11, 12, 23, 30, 24, 0, DateTimeKind.Unspecified) });

            migrationBuilder.UpdateData(
                table: "TimeRegistrations",
                keyColumn: "TimeRegistrationId",
                keyValue: 796,
                columns: new[] { "EndTime", "StartTime" },
                values: new object[] { new DateTime(2024, 7, 26, 5, 2, 48, 0, DateTimeKind.Unspecified), new DateTime(2024, 10, 31, 12, 42, 25, 0, DateTimeKind.Unspecified) });

            migrationBuilder.UpdateData(
                table: "TimeRegistrations",
                keyColumn: "TimeRegistrationId",
                keyValue: 797,
                columns: new[] { "EndTime", "StartTime" },
                values: new object[] { new DateTime(2024, 1, 30, 1, 29, 28, 0, DateTimeKind.Unspecified), new DateTime(2024, 7, 1, 3, 49, 40, 0, DateTimeKind.Unspecified) });

            migrationBuilder.UpdateData(
                table: "TimeRegistrations",
                keyColumn: "TimeRegistrationId",
                keyValue: 798,
                columns: new[] { "EndTime", "StartTime" },
                values: new object[] { new DateTime(2024, 7, 23, 9, 46, 35, 0, DateTimeKind.Unspecified), new DateTime(2024, 7, 20, 16, 37, 45, 0, DateTimeKind.Unspecified) });

            migrationBuilder.UpdateData(
                table: "TimeRegistrations",
                keyColumn: "TimeRegistrationId",
                keyValue: 799,
                columns: new[] { "EndTime", "StartTime" },
                values: new object[] { new DateTime(2024, 12, 11, 5, 31, 17, 0, DateTimeKind.Unspecified), new DateTime(2024, 1, 2, 16, 18, 4, 0, DateTimeKind.Unspecified) });

            migrationBuilder.UpdateData(
                table: "TimeRegistrations",
                keyColumn: "TimeRegistrationId",
                keyValue: 800,
                columns: new[] { "EndTime", "StartTime" },
                values: new object[] { new DateTime(2024, 7, 10, 19, 20, 45, 0, DateTimeKind.Unspecified), new DateTime(2024, 2, 15, 21, 40, 16, 0, DateTimeKind.Unspecified) });

            migrationBuilder.UpdateData(
                table: "TimeRegistrations",
                keyColumn: "TimeRegistrationId",
                keyValue: 801,
                columns: new[] { "EndTime", "StartTime" },
                values: new object[] { new DateTime(2024, 6, 19, 2, 32, 22, 0, DateTimeKind.Unspecified), new DateTime(2024, 6, 11, 9, 13, 31, 0, DateTimeKind.Unspecified) });

            migrationBuilder.UpdateData(
                table: "TimeRegistrations",
                keyColumn: "TimeRegistrationId",
                keyValue: 802,
                columns: new[] { "EndTime", "StartTime" },
                values: new object[] { new DateTime(2024, 2, 7, 21, 28, 23, 0, DateTimeKind.Unspecified), new DateTime(2024, 7, 1, 22, 23, 18, 0, DateTimeKind.Unspecified) });

            migrationBuilder.UpdateData(
                table: "TimeRegistrations",
                keyColumn: "TimeRegistrationId",
                keyValue: 803,
                columns: new[] { "EndTime", "StartTime" },
                values: new object[] { new DateTime(2024, 1, 2, 6, 16, 9, 0, DateTimeKind.Unspecified), new DateTime(2024, 12, 29, 5, 8, 46, 0, DateTimeKind.Unspecified) });

            migrationBuilder.UpdateData(
                table: "TimeRegistrations",
                keyColumn: "TimeRegistrationId",
                keyValue: 804,
                columns: new[] { "EndTime", "StartTime" },
                values: new object[] { new DateTime(2024, 7, 6, 3, 18, 10, 0, DateTimeKind.Unspecified), new DateTime(2024, 11, 4, 4, 29, 8, 0, DateTimeKind.Unspecified) });

            migrationBuilder.UpdateData(
                table: "TimeRegistrations",
                keyColumn: "TimeRegistrationId",
                keyValue: 805,
                columns: new[] { "EndTime", "StartTime" },
                values: new object[] { new DateTime(2024, 7, 17, 0, 9, 36, 0, DateTimeKind.Unspecified), new DateTime(2024, 2, 21, 11, 22, 40, 0, DateTimeKind.Unspecified) });

            migrationBuilder.UpdateData(
                table: "TimeRegistrations",
                keyColumn: "TimeRegistrationId",
                keyValue: 806,
                columns: new[] { "EndTime", "StartTime" },
                values: new object[] { new DateTime(2024, 1, 30, 4, 47, 42, 0, DateTimeKind.Unspecified), new DateTime(2024, 6, 12, 5, 45, 40, 0, DateTimeKind.Unspecified) });

            migrationBuilder.UpdateData(
                table: "TimeRegistrations",
                keyColumn: "TimeRegistrationId",
                keyValue: 807,
                columns: new[] { "EndTime", "StartTime" },
                values: new object[] { new DateTime(2024, 8, 28, 1, 58, 30, 0, DateTimeKind.Unspecified), new DateTime(2024, 10, 29, 22, 38, 8, 0, DateTimeKind.Unspecified) });

            migrationBuilder.UpdateData(
                table: "TimeRegistrations",
                keyColumn: "TimeRegistrationId",
                keyValue: 808,
                columns: new[] { "EndTime", "StartTime" },
                values: new object[] { new DateTime(2024, 12, 10, 14, 48, 47, 0, DateTimeKind.Unspecified), new DateTime(2024, 2, 14, 22, 53, 23, 0, DateTimeKind.Unspecified) });

            migrationBuilder.UpdateData(
                table: "TimeRegistrations",
                keyColumn: "TimeRegistrationId",
                keyValue: 809,
                columns: new[] { "EndTime", "StartTime" },
                values: new object[] { new DateTime(2024, 6, 21, 0, 2, 45, 0, DateTimeKind.Unspecified), new DateTime(2024, 11, 20, 4, 20, 54, 0, DateTimeKind.Unspecified) });

            migrationBuilder.UpdateData(
                table: "TimeRegistrations",
                keyColumn: "TimeRegistrationId",
                keyValue: 810,
                columns: new[] { "EndTime", "StartTime" },
                values: new object[] { new DateTime(2024, 3, 21, 17, 57, 23, 0, DateTimeKind.Unspecified), new DateTime(2024, 6, 14, 13, 40, 26, 0, DateTimeKind.Unspecified) });

            migrationBuilder.UpdateData(
                table: "TimeRegistrations",
                keyColumn: "TimeRegistrationId",
                keyValue: 811,
                columns: new[] { "EndTime", "StartTime" },
                values: new object[] { new DateTime(2024, 3, 31, 0, 50, 20, 0, DateTimeKind.Unspecified), new DateTime(2024, 4, 4, 11, 17, 11, 0, DateTimeKind.Unspecified) });

            migrationBuilder.UpdateData(
                table: "TimeRegistrations",
                keyColumn: "TimeRegistrationId",
                keyValue: 812,
                columns: new[] { "EndTime", "StartTime" },
                values: new object[] { new DateTime(2024, 3, 31, 5, 1, 34, 0, DateTimeKind.Unspecified), new DateTime(2024, 11, 10, 8, 51, 59, 0, DateTimeKind.Unspecified) });

            migrationBuilder.UpdateData(
                table: "TimeRegistrations",
                keyColumn: "TimeRegistrationId",
                keyValue: 813,
                columns: new[] { "EndTime", "StartTime" },
                values: new object[] { new DateTime(2024, 8, 15, 18, 17, 56, 0, DateTimeKind.Unspecified), new DateTime(2024, 12, 11, 12, 38, 41, 0, DateTimeKind.Unspecified) });

            migrationBuilder.UpdateData(
                table: "TimeRegistrations",
                keyColumn: "TimeRegistrationId",
                keyValue: 814,
                columns: new[] { "EndTime", "StartTime" },
                values: new object[] { new DateTime(2024, 11, 30, 22, 30, 2, 0, DateTimeKind.Unspecified), new DateTime(2024, 12, 20, 6, 1, 27, 0, DateTimeKind.Unspecified) });

            migrationBuilder.UpdateData(
                table: "TimeRegistrations",
                keyColumn: "TimeRegistrationId",
                keyValue: 815,
                columns: new[] { "EndTime", "StartTime" },
                values: new object[] { new DateTime(2024, 6, 18, 16, 4, 4, 0, DateTimeKind.Unspecified), new DateTime(2024, 10, 18, 9, 14, 32, 0, DateTimeKind.Unspecified) });

            migrationBuilder.UpdateData(
                table: "TimeRegistrations",
                keyColumn: "TimeRegistrationId",
                keyValue: 816,
                columns: new[] { "EndTime", "StartTime" },
                values: new object[] { new DateTime(2024, 3, 21, 4, 8, 40, 0, DateTimeKind.Unspecified), new DateTime(2024, 6, 15, 8, 25, 0, 0, DateTimeKind.Unspecified) });

            migrationBuilder.UpdateData(
                table: "TimeRegistrations",
                keyColumn: "TimeRegistrationId",
                keyValue: 817,
                columns: new[] { "EndTime", "StartTime" },
                values: new object[] { new DateTime(2024, 2, 7, 7, 16, 51, 0, DateTimeKind.Unspecified), new DateTime(2024, 10, 4, 12, 25, 10, 0, DateTimeKind.Unspecified) });

            migrationBuilder.UpdateData(
                table: "TimeRegistrations",
                keyColumn: "TimeRegistrationId",
                keyValue: 818,
                columns: new[] { "EndTime", "StartTime" },
                values: new object[] { new DateTime(2024, 10, 28, 7, 57, 39, 0, DateTimeKind.Unspecified), new DateTime(2024, 5, 23, 21, 9, 42, 0, DateTimeKind.Unspecified) });

            migrationBuilder.UpdateData(
                table: "TimeRegistrations",
                keyColumn: "TimeRegistrationId",
                keyValue: 819,
                columns: new[] { "EndTime", "StartTime" },
                values: new object[] { new DateTime(2024, 11, 25, 21, 43, 22, 0, DateTimeKind.Unspecified), new DateTime(2024, 9, 28, 18, 40, 30, 0, DateTimeKind.Unspecified) });

            migrationBuilder.UpdateData(
                table: "TimeRegistrations",
                keyColumn: "TimeRegistrationId",
                keyValue: 820,
                columns: new[] { "EndTime", "StartTime" },
                values: new object[] { new DateTime(2024, 3, 16, 23, 18, 53, 0, DateTimeKind.Unspecified), new DateTime(2024, 10, 26, 1, 4, 29, 0, DateTimeKind.Unspecified) });

            migrationBuilder.UpdateData(
                table: "TimeRegistrations",
                keyColumn: "TimeRegistrationId",
                keyValue: 821,
                columns: new[] { "EndTime", "StartTime" },
                values: new object[] { new DateTime(2024, 1, 18, 17, 47, 49, 0, DateTimeKind.Unspecified), new DateTime(2024, 7, 6, 18, 6, 2, 0, DateTimeKind.Unspecified) });

            migrationBuilder.UpdateData(
                table: "TimeRegistrations",
                keyColumn: "TimeRegistrationId",
                keyValue: 822,
                columns: new[] { "EndTime", "StartTime" },
                values: new object[] { new DateTime(2024, 3, 19, 9, 33, 13, 0, DateTimeKind.Unspecified), new DateTime(2024, 2, 28, 13, 32, 16, 0, DateTimeKind.Unspecified) });

            migrationBuilder.UpdateData(
                table: "TimeRegistrations",
                keyColumn: "TimeRegistrationId",
                keyValue: 823,
                columns: new[] { "EndTime", "StartTime" },
                values: new object[] { new DateTime(2024, 1, 3, 8, 39, 25, 0, DateTimeKind.Unspecified), new DateTime(2024, 12, 3, 13, 19, 26, 0, DateTimeKind.Unspecified) });

            migrationBuilder.UpdateData(
                table: "TimeRegistrations",
                keyColumn: "TimeRegistrationId",
                keyValue: 824,
                columns: new[] { "EndTime", "StartTime" },
                values: new object[] { new DateTime(2024, 12, 22, 19, 28, 48, 0, DateTimeKind.Unspecified), new DateTime(2024, 10, 11, 19, 35, 29, 0, DateTimeKind.Unspecified) });

            migrationBuilder.UpdateData(
                table: "TimeRegistrations",
                keyColumn: "TimeRegistrationId",
                keyValue: 825,
                columns: new[] { "EndTime", "StartTime" },
                values: new object[] { new DateTime(2024, 6, 21, 13, 1, 54, 0, DateTimeKind.Unspecified), new DateTime(2024, 5, 23, 9, 52, 30, 0, DateTimeKind.Unspecified) });

            migrationBuilder.UpdateData(
                table: "TimeRegistrations",
                keyColumn: "TimeRegistrationId",
                keyValue: 826,
                columns: new[] { "EndTime", "StartTime" },
                values: new object[] { new DateTime(2024, 9, 9, 1, 33, 52, 0, DateTimeKind.Unspecified), new DateTime(2024, 3, 12, 17, 9, 22, 0, DateTimeKind.Unspecified) });

            migrationBuilder.UpdateData(
                table: "TimeRegistrations",
                keyColumn: "TimeRegistrationId",
                keyValue: 827,
                columns: new[] { "EndTime", "StartTime" },
                values: new object[] { new DateTime(2024, 2, 11, 20, 34, 18, 0, DateTimeKind.Unspecified), new DateTime(2024, 5, 13, 3, 59, 17, 0, DateTimeKind.Unspecified) });

            migrationBuilder.UpdateData(
                table: "TimeRegistrations",
                keyColumn: "TimeRegistrationId",
                keyValue: 828,
                columns: new[] { "EndTime", "StartTime" },
                values: new object[] { new DateTime(2024, 4, 7, 20, 26, 30, 0, DateTimeKind.Unspecified), new DateTime(2024, 3, 15, 14, 45, 22, 0, DateTimeKind.Unspecified) });

            migrationBuilder.UpdateData(
                table: "TimeRegistrations",
                keyColumn: "TimeRegistrationId",
                keyValue: 829,
                columns: new[] { "EndTime", "StartTime" },
                values: new object[] { new DateTime(2024, 5, 3, 17, 9, 15, 0, DateTimeKind.Unspecified), new DateTime(2024, 6, 21, 12, 26, 23, 0, DateTimeKind.Unspecified) });

            migrationBuilder.UpdateData(
                table: "TimeRegistrations",
                keyColumn: "TimeRegistrationId",
                keyValue: 830,
                columns: new[] { "EndTime", "StartTime" },
                values: new object[] { new DateTime(2024, 2, 9, 20, 9, 56, 0, DateTimeKind.Unspecified), new DateTime(2024, 2, 9, 18, 20, 19, 0, DateTimeKind.Unspecified) });

            migrationBuilder.UpdateData(
                table: "TimeRegistrations",
                keyColumn: "TimeRegistrationId",
                keyValue: 831,
                columns: new[] { "EndTime", "StartTime" },
                values: new object[] { new DateTime(2024, 10, 1, 21, 0, 33, 0, DateTimeKind.Unspecified), new DateTime(2024, 11, 24, 13, 57, 58, 0, DateTimeKind.Unspecified) });

            migrationBuilder.UpdateData(
                table: "TimeRegistrations",
                keyColumn: "TimeRegistrationId",
                keyValue: 832,
                columns: new[] { "EndTime", "StartTime" },
                values: new object[] { new DateTime(2024, 2, 7, 14, 1, 8, 0, DateTimeKind.Unspecified), new DateTime(2024, 7, 15, 20, 12, 11, 0, DateTimeKind.Unspecified) });

            migrationBuilder.UpdateData(
                table: "TimeRegistrations",
                keyColumn: "TimeRegistrationId",
                keyValue: 833,
                columns: new[] { "EndTime", "StartTime" },
                values: new object[] { new DateTime(2024, 2, 21, 10, 47, 33, 0, DateTimeKind.Unspecified), new DateTime(2024, 8, 16, 23, 58, 4, 0, DateTimeKind.Unspecified) });

            migrationBuilder.UpdateData(
                table: "TimeRegistrations",
                keyColumn: "TimeRegistrationId",
                keyValue: 834,
                columns: new[] { "EndTime", "StartTime" },
                values: new object[] { new DateTime(2024, 3, 25, 6, 31, 6, 0, DateTimeKind.Unspecified), new DateTime(2024, 8, 12, 2, 59, 50, 0, DateTimeKind.Unspecified) });

            migrationBuilder.UpdateData(
                table: "TimeRegistrations",
                keyColumn: "TimeRegistrationId",
                keyValue: 835,
                columns: new[] { "EndTime", "StartTime" },
                values: new object[] { new DateTime(2024, 11, 29, 2, 39, 55, 0, DateTimeKind.Unspecified), new DateTime(2024, 9, 26, 11, 29, 23, 0, DateTimeKind.Unspecified) });

            migrationBuilder.UpdateData(
                table: "TimeRegistrations",
                keyColumn: "TimeRegistrationId",
                keyValue: 836,
                columns: new[] { "EndTime", "StartTime" },
                values: new object[] { new DateTime(2024, 10, 16, 0, 56, 50, 0, DateTimeKind.Unspecified), new DateTime(2024, 4, 8, 21, 53, 16, 0, DateTimeKind.Unspecified) });

            migrationBuilder.UpdateData(
                table: "TimeRegistrations",
                keyColumn: "TimeRegistrationId",
                keyValue: 837,
                columns: new[] { "EndTime", "StartTime" },
                values: new object[] { new DateTime(2024, 1, 26, 5, 15, 33, 0, DateTimeKind.Unspecified), new DateTime(2024, 12, 12, 2, 54, 16, 0, DateTimeKind.Unspecified) });

            migrationBuilder.UpdateData(
                table: "TimeRegistrations",
                keyColumn: "TimeRegistrationId",
                keyValue: 838,
                columns: new[] { "EndTime", "StartTime" },
                values: new object[] { new DateTime(2024, 11, 15, 18, 8, 28, 0, DateTimeKind.Unspecified), new DateTime(2024, 1, 11, 8, 20, 38, 0, DateTimeKind.Unspecified) });

            migrationBuilder.UpdateData(
                table: "TimeRegistrations",
                keyColumn: "TimeRegistrationId",
                keyValue: 839,
                columns: new[] { "EndTime", "StartTime" },
                values: new object[] { new DateTime(2024, 9, 8, 9, 54, 13, 0, DateTimeKind.Unspecified), new DateTime(2024, 2, 21, 0, 3, 9, 0, DateTimeKind.Unspecified) });

            migrationBuilder.UpdateData(
                table: "TimeRegistrations",
                keyColumn: "TimeRegistrationId",
                keyValue: 840,
                columns: new[] { "EndTime", "StartTime" },
                values: new object[] { new DateTime(2024, 11, 5, 18, 33, 14, 0, DateTimeKind.Unspecified), new DateTime(2024, 6, 15, 21, 52, 5, 0, DateTimeKind.Unspecified) });

            migrationBuilder.UpdateData(
                table: "TimeRegistrations",
                keyColumn: "TimeRegistrationId",
                keyValue: 841,
                columns: new[] { "EndTime", "StartTime" },
                values: new object[] { new DateTime(2024, 7, 15, 18, 36, 29, 0, DateTimeKind.Unspecified), new DateTime(2024, 4, 5, 18, 4, 43, 0, DateTimeKind.Unspecified) });

            migrationBuilder.UpdateData(
                table: "TimeRegistrations",
                keyColumn: "TimeRegistrationId",
                keyValue: 842,
                columns: new[] { "EndTime", "StartTime" },
                values: new object[] { new DateTime(2024, 10, 1, 0, 21, 42, 0, DateTimeKind.Unspecified), new DateTime(2024, 9, 12, 23, 8, 8, 0, DateTimeKind.Unspecified) });

            migrationBuilder.UpdateData(
                table: "TimeRegistrations",
                keyColumn: "TimeRegistrationId",
                keyValue: 843,
                columns: new[] { "EndTime", "StartTime" },
                values: new object[] { new DateTime(2024, 7, 6, 16, 3, 32, 0, DateTimeKind.Unspecified), new DateTime(2024, 3, 26, 11, 30, 34, 0, DateTimeKind.Unspecified) });

            migrationBuilder.UpdateData(
                table: "TimeRegistrations",
                keyColumn: "TimeRegistrationId",
                keyValue: 844,
                columns: new[] { "EndTime", "StartTime" },
                values: new object[] { new DateTime(2024, 4, 27, 8, 42, 31, 0, DateTimeKind.Unspecified), new DateTime(2024, 9, 29, 2, 51, 11, 0, DateTimeKind.Unspecified) });

            migrationBuilder.UpdateData(
                table: "TimeRegistrations",
                keyColumn: "TimeRegistrationId",
                keyValue: 845,
                columns: new[] { "EndTime", "StartTime" },
                values: new object[] { new DateTime(2024, 5, 6, 15, 13, 15, 0, DateTimeKind.Unspecified), new DateTime(2024, 2, 26, 0, 5, 30, 0, DateTimeKind.Unspecified) });

            migrationBuilder.UpdateData(
                table: "TimeRegistrations",
                keyColumn: "TimeRegistrationId",
                keyValue: 846,
                columns: new[] { "EndTime", "StartTime" },
                values: new object[] { new DateTime(2024, 9, 27, 18, 41, 4, 0, DateTimeKind.Unspecified), new DateTime(2024, 2, 21, 23, 14, 35, 0, DateTimeKind.Unspecified) });

            migrationBuilder.UpdateData(
                table: "TimeRegistrations",
                keyColumn: "TimeRegistrationId",
                keyValue: 847,
                columns: new[] { "EndTime", "StartTime" },
                values: new object[] { new DateTime(2024, 12, 20, 4, 3, 27, 0, DateTimeKind.Unspecified), new DateTime(2024, 2, 4, 21, 54, 10, 0, DateTimeKind.Unspecified) });

            migrationBuilder.UpdateData(
                table: "TimeRegistrations",
                keyColumn: "TimeRegistrationId",
                keyValue: 848,
                columns: new[] { "EndTime", "StartTime" },
                values: new object[] { new DateTime(2024, 3, 28, 21, 54, 19, 0, DateTimeKind.Unspecified), new DateTime(2024, 8, 22, 21, 12, 10, 0, DateTimeKind.Unspecified) });

            migrationBuilder.UpdateData(
                table: "TimeRegistrations",
                keyColumn: "TimeRegistrationId",
                keyValue: 849,
                columns: new[] { "EndTime", "StartTime" },
                values: new object[] { new DateTime(2024, 11, 12, 2, 54, 40, 0, DateTimeKind.Unspecified), new DateTime(2024, 1, 10, 3, 49, 41, 0, DateTimeKind.Unspecified) });

            migrationBuilder.UpdateData(
                table: "TimeRegistrations",
                keyColumn: "TimeRegistrationId",
                keyValue: 850,
                columns: new[] { "EndTime", "StartTime" },
                values: new object[] { new DateTime(2024, 8, 3, 21, 9, 50, 0, DateTimeKind.Unspecified), new DateTime(2024, 10, 16, 3, 26, 49, 0, DateTimeKind.Unspecified) });

            migrationBuilder.UpdateData(
                table: "TimeRegistrations",
                keyColumn: "TimeRegistrationId",
                keyValue: 851,
                columns: new[] { "EndTime", "StartTime" },
                values: new object[] { new DateTime(2024, 12, 16, 1, 10, 37, 0, DateTimeKind.Unspecified), new DateTime(2024, 11, 3, 1, 0, 38, 0, DateTimeKind.Unspecified) });

            migrationBuilder.UpdateData(
                table: "TimeRegistrations",
                keyColumn: "TimeRegistrationId",
                keyValue: 852,
                columns: new[] { "EndTime", "StartTime" },
                values: new object[] { new DateTime(2024, 5, 19, 17, 44, 50, 0, DateTimeKind.Unspecified), new DateTime(2024, 6, 17, 7, 41, 43, 0, DateTimeKind.Unspecified) });

            migrationBuilder.UpdateData(
                table: "TimeRegistrations",
                keyColumn: "TimeRegistrationId",
                keyValue: 853,
                columns: new[] { "EndTime", "StartTime" },
                values: new object[] { new DateTime(2024, 12, 9, 21, 39, 20, 0, DateTimeKind.Unspecified), new DateTime(2024, 12, 13, 13, 23, 36, 0, DateTimeKind.Unspecified) });

            migrationBuilder.UpdateData(
                table: "TimeRegistrations",
                keyColumn: "TimeRegistrationId",
                keyValue: 854,
                columns: new[] { "EndTime", "StartTime" },
                values: new object[] { new DateTime(2024, 4, 15, 7, 21, 10, 0, DateTimeKind.Unspecified), new DateTime(2024, 5, 24, 18, 42, 14, 0, DateTimeKind.Unspecified) });

            migrationBuilder.UpdateData(
                table: "TimeRegistrations",
                keyColumn: "TimeRegistrationId",
                keyValue: 855,
                columns: new[] { "EndTime", "StartTime" },
                values: new object[] { new DateTime(2024, 10, 19, 6, 10, 5, 0, DateTimeKind.Unspecified), new DateTime(2024, 1, 16, 13, 17, 7, 0, DateTimeKind.Unspecified) });

            migrationBuilder.UpdateData(
                table: "TimeRegistrations",
                keyColumn: "TimeRegistrationId",
                keyValue: 856,
                columns: new[] { "EndTime", "StartTime" },
                values: new object[] { new DateTime(2024, 6, 11, 11, 32, 22, 0, DateTimeKind.Unspecified), new DateTime(2024, 3, 27, 21, 23, 14, 0, DateTimeKind.Unspecified) });

            migrationBuilder.UpdateData(
                table: "TimeRegistrations",
                keyColumn: "TimeRegistrationId",
                keyValue: 857,
                columns: new[] { "EndTime", "StartTime" },
                values: new object[] { new DateTime(2024, 3, 16, 21, 22, 37, 0, DateTimeKind.Unspecified), new DateTime(2024, 3, 5, 22, 49, 40, 0, DateTimeKind.Unspecified) });

            migrationBuilder.UpdateData(
                table: "TimeRegistrations",
                keyColumn: "TimeRegistrationId",
                keyValue: 858,
                columns: new[] { "EndTime", "StartTime" },
                values: new object[] { new DateTime(2024, 4, 23, 17, 2, 20, 0, DateTimeKind.Unspecified), new DateTime(2024, 12, 24, 12, 23, 16, 0, DateTimeKind.Unspecified) });

            migrationBuilder.UpdateData(
                table: "TimeRegistrations",
                keyColumn: "TimeRegistrationId",
                keyValue: 859,
                columns: new[] { "EndTime", "StartTime" },
                values: new object[] { new DateTime(2024, 12, 23, 6, 24, 46, 0, DateTimeKind.Unspecified), new DateTime(2024, 5, 9, 16, 58, 5, 0, DateTimeKind.Unspecified) });

            migrationBuilder.UpdateData(
                table: "TimeRegistrations",
                keyColumn: "TimeRegistrationId",
                keyValue: 860,
                columns: new[] { "EndTime", "StartTime" },
                values: new object[] { new DateTime(2024, 11, 27, 2, 36, 40, 0, DateTimeKind.Unspecified), new DateTime(2024, 12, 15, 22, 57, 51, 0, DateTimeKind.Unspecified) });

            migrationBuilder.UpdateData(
                table: "TimeRegistrations",
                keyColumn: "TimeRegistrationId",
                keyValue: 861,
                columns: new[] { "EndTime", "StartTime" },
                values: new object[] { new DateTime(2024, 6, 7, 17, 50, 28, 0, DateTimeKind.Unspecified), new DateTime(2024, 7, 7, 20, 7, 10, 0, DateTimeKind.Unspecified) });

            migrationBuilder.UpdateData(
                table: "TimeRegistrations",
                keyColumn: "TimeRegistrationId",
                keyValue: 862,
                columns: new[] { "EndTime", "StartTime" },
                values: new object[] { new DateTime(2024, 7, 12, 3, 14, 35, 0, DateTimeKind.Unspecified), new DateTime(2024, 12, 30, 13, 52, 33, 0, DateTimeKind.Unspecified) });

            migrationBuilder.UpdateData(
                table: "TimeRegistrations",
                keyColumn: "TimeRegistrationId",
                keyValue: 863,
                columns: new[] { "EndTime", "StartTime" },
                values: new object[] { new DateTime(2024, 4, 6, 23, 51, 50, 0, DateTimeKind.Unspecified), new DateTime(2024, 11, 6, 17, 36, 56, 0, DateTimeKind.Unspecified) });

            migrationBuilder.UpdateData(
                table: "TimeRegistrations",
                keyColumn: "TimeRegistrationId",
                keyValue: 864,
                columns: new[] { "EndTime", "StartTime" },
                values: new object[] { new DateTime(2024, 11, 14, 19, 32, 32, 0, DateTimeKind.Unspecified), new DateTime(2024, 5, 26, 13, 5, 49, 0, DateTimeKind.Unspecified) });

            migrationBuilder.UpdateData(
                table: "TimeRegistrations",
                keyColumn: "TimeRegistrationId",
                keyValue: 865,
                columns: new[] { "EndTime", "StartTime" },
                values: new object[] { new DateTime(2024, 5, 26, 0, 52, 32, 0, DateTimeKind.Unspecified), new DateTime(2024, 4, 30, 12, 36, 0, 0, DateTimeKind.Unspecified) });

            migrationBuilder.UpdateData(
                table: "TimeRegistrations",
                keyColumn: "TimeRegistrationId",
                keyValue: 866,
                columns: new[] { "EndTime", "StartTime" },
                values: new object[] { new DateTime(2024, 6, 12, 9, 47, 52, 0, DateTimeKind.Unspecified), new DateTime(2024, 4, 7, 12, 59, 32, 0, DateTimeKind.Unspecified) });

            migrationBuilder.UpdateData(
                table: "TimeRegistrations",
                keyColumn: "TimeRegistrationId",
                keyValue: 867,
                columns: new[] { "EndTime", "StartTime" },
                values: new object[] { new DateTime(2024, 5, 30, 4, 2, 40, 0, DateTimeKind.Unspecified), new DateTime(2024, 9, 11, 19, 8, 5, 0, DateTimeKind.Unspecified) });

            migrationBuilder.UpdateData(
                table: "TimeRegistrations",
                keyColumn: "TimeRegistrationId",
                keyValue: 868,
                columns: new[] { "EndTime", "StartTime" },
                values: new object[] { new DateTime(2024, 8, 16, 9, 56, 36, 0, DateTimeKind.Unspecified), new DateTime(2024, 8, 11, 5, 11, 18, 0, DateTimeKind.Unspecified) });

            migrationBuilder.UpdateData(
                table: "TimeRegistrations",
                keyColumn: "TimeRegistrationId",
                keyValue: 869,
                columns: new[] { "EndTime", "StartTime" },
                values: new object[] { new DateTime(2024, 12, 1, 19, 31, 40, 0, DateTimeKind.Unspecified), new DateTime(2024, 8, 8, 11, 21, 34, 0, DateTimeKind.Unspecified) });

            migrationBuilder.UpdateData(
                table: "TimeRegistrations",
                keyColumn: "TimeRegistrationId",
                keyValue: 870,
                columns: new[] { "EndTime", "StartTime" },
                values: new object[] { new DateTime(2024, 8, 12, 18, 9, 17, 0, DateTimeKind.Unspecified), new DateTime(2024, 7, 16, 11, 32, 55, 0, DateTimeKind.Unspecified) });

            migrationBuilder.UpdateData(
                table: "TimeRegistrations",
                keyColumn: "TimeRegistrationId",
                keyValue: 871,
                columns: new[] { "EndTime", "StartTime" },
                values: new object[] { new DateTime(2024, 5, 18, 20, 44, 53, 0, DateTimeKind.Unspecified), new DateTime(2024, 2, 25, 14, 40, 19, 0, DateTimeKind.Unspecified) });

            migrationBuilder.UpdateData(
                table: "TimeRegistrations",
                keyColumn: "TimeRegistrationId",
                keyValue: 872,
                columns: new[] { "EndTime", "StartTime" },
                values: new object[] { new DateTime(2024, 12, 16, 23, 20, 48, 0, DateTimeKind.Unspecified), new DateTime(2024, 11, 8, 20, 18, 40, 0, DateTimeKind.Unspecified) });

            migrationBuilder.UpdateData(
                table: "TimeRegistrations",
                keyColumn: "TimeRegistrationId",
                keyValue: 873,
                columns: new[] { "EndTime", "StartTime" },
                values: new object[] { new DateTime(2024, 5, 20, 10, 59, 36, 0, DateTimeKind.Unspecified), new DateTime(2024, 9, 30, 23, 1, 44, 0, DateTimeKind.Unspecified) });

            migrationBuilder.UpdateData(
                table: "TimeRegistrations",
                keyColumn: "TimeRegistrationId",
                keyValue: 874,
                columns: new[] { "EndTime", "StartTime" },
                values: new object[] { new DateTime(2024, 7, 19, 4, 40, 0, 0, DateTimeKind.Unspecified), new DateTime(2024, 8, 9, 13, 52, 39, 0, DateTimeKind.Unspecified) });

            migrationBuilder.UpdateData(
                table: "TimeRegistrations",
                keyColumn: "TimeRegistrationId",
                keyValue: 875,
                columns: new[] { "EndTime", "StartTime" },
                values: new object[] { new DateTime(2024, 3, 3, 18, 2, 14, 0, DateTimeKind.Unspecified), new DateTime(2024, 4, 16, 19, 16, 43, 0, DateTimeKind.Unspecified) });

            migrationBuilder.UpdateData(
                table: "TimeRegistrations",
                keyColumn: "TimeRegistrationId",
                keyValue: 876,
                columns: new[] { "EndTime", "StartTime" },
                values: new object[] { new DateTime(2024, 3, 21, 16, 14, 58, 0, DateTimeKind.Unspecified), new DateTime(2024, 6, 13, 1, 32, 34, 0, DateTimeKind.Unspecified) });

            migrationBuilder.UpdateData(
                table: "TimeRegistrations",
                keyColumn: "TimeRegistrationId",
                keyValue: 877,
                columns: new[] { "EndTime", "StartTime" },
                values: new object[] { new DateTime(2024, 3, 16, 23, 50, 27, 0, DateTimeKind.Unspecified), new DateTime(2024, 11, 15, 9, 2, 17, 0, DateTimeKind.Unspecified) });

            migrationBuilder.UpdateData(
                table: "TimeRegistrations",
                keyColumn: "TimeRegistrationId",
                keyValue: 878,
                columns: new[] { "EndTime", "StartTime" },
                values: new object[] { new DateTime(2024, 5, 29, 18, 45, 23, 0, DateTimeKind.Unspecified), new DateTime(2024, 7, 9, 8, 53, 57, 0, DateTimeKind.Unspecified) });

            migrationBuilder.UpdateData(
                table: "TimeRegistrations",
                keyColumn: "TimeRegistrationId",
                keyValue: 879,
                columns: new[] { "EndTime", "StartTime" },
                values: new object[] { new DateTime(2024, 3, 30, 23, 3, 20, 0, DateTimeKind.Unspecified), new DateTime(2024, 2, 6, 5, 28, 51, 0, DateTimeKind.Unspecified) });

            migrationBuilder.UpdateData(
                table: "TimeRegistrations",
                keyColumn: "TimeRegistrationId",
                keyValue: 880,
                columns: new[] { "EndTime", "StartTime" },
                values: new object[] { new DateTime(2024, 8, 26, 4, 21, 8, 0, DateTimeKind.Unspecified), new DateTime(2024, 2, 20, 19, 1, 20, 0, DateTimeKind.Unspecified) });

            migrationBuilder.UpdateData(
                table: "TimeRegistrations",
                keyColumn: "TimeRegistrationId",
                keyValue: 881,
                columns: new[] { "EndTime", "StartTime" },
                values: new object[] { new DateTime(2024, 7, 9, 6, 3, 25, 0, DateTimeKind.Unspecified), new DateTime(2024, 1, 2, 1, 4, 1, 0, DateTimeKind.Unspecified) });

            migrationBuilder.UpdateData(
                table: "TimeRegistrations",
                keyColumn: "TimeRegistrationId",
                keyValue: 882,
                columns: new[] { "EndTime", "StartTime" },
                values: new object[] { new DateTime(2024, 11, 7, 14, 29, 58, 0, DateTimeKind.Unspecified), new DateTime(2024, 4, 24, 22, 44, 37, 0, DateTimeKind.Unspecified) });

            migrationBuilder.UpdateData(
                table: "TimeRegistrations",
                keyColumn: "TimeRegistrationId",
                keyValue: 883,
                columns: new[] { "EndTime", "StartTime" },
                values: new object[] { new DateTime(2024, 9, 17, 16, 46, 22, 0, DateTimeKind.Unspecified), new DateTime(2024, 7, 16, 9, 54, 41, 0, DateTimeKind.Unspecified) });

            migrationBuilder.UpdateData(
                table: "TimeRegistrations",
                keyColumn: "TimeRegistrationId",
                keyValue: 884,
                columns: new[] { "EndTime", "StartTime" },
                values: new object[] { new DateTime(2024, 11, 22, 21, 24, 38, 0, DateTimeKind.Unspecified), new DateTime(2024, 3, 5, 4, 23, 43, 0, DateTimeKind.Unspecified) });

            migrationBuilder.UpdateData(
                table: "TimeRegistrations",
                keyColumn: "TimeRegistrationId",
                keyValue: 885,
                columns: new[] { "EndTime", "StartTime" },
                values: new object[] { new DateTime(2024, 11, 30, 11, 22, 39, 0, DateTimeKind.Unspecified), new DateTime(2024, 3, 24, 8, 45, 6, 0, DateTimeKind.Unspecified) });

            migrationBuilder.UpdateData(
                table: "TimeRegistrations",
                keyColumn: "TimeRegistrationId",
                keyValue: 886,
                columns: new[] { "EndTime", "StartTime" },
                values: new object[] { new DateTime(2024, 8, 3, 21, 35, 58, 0, DateTimeKind.Unspecified), new DateTime(2024, 3, 17, 17, 17, 39, 0, DateTimeKind.Unspecified) });

            migrationBuilder.UpdateData(
                table: "TimeRegistrations",
                keyColumn: "TimeRegistrationId",
                keyValue: 887,
                columns: new[] { "EndTime", "StartTime" },
                values: new object[] { new DateTime(2024, 4, 15, 5, 12, 34, 0, DateTimeKind.Unspecified), new DateTime(2024, 11, 29, 22, 56, 54, 0, DateTimeKind.Unspecified) });

            migrationBuilder.UpdateData(
                table: "TimeRegistrations",
                keyColumn: "TimeRegistrationId",
                keyValue: 888,
                columns: new[] { "EndTime", "StartTime" },
                values: new object[] { new DateTime(2024, 12, 20, 5, 49, 3, 0, DateTimeKind.Unspecified), new DateTime(2024, 12, 19, 21, 46, 5, 0, DateTimeKind.Unspecified) });

            migrationBuilder.UpdateData(
                table: "TimeRegistrations",
                keyColumn: "TimeRegistrationId",
                keyValue: 889,
                columns: new[] { "EndTime", "StartTime" },
                values: new object[] { new DateTime(2024, 2, 26, 23, 14, 35, 0, DateTimeKind.Unspecified), new DateTime(2024, 12, 15, 23, 47, 53, 0, DateTimeKind.Unspecified) });

            migrationBuilder.UpdateData(
                table: "TimeRegistrations",
                keyColumn: "TimeRegistrationId",
                keyValue: 890,
                columns: new[] { "EndTime", "StartTime" },
                values: new object[] { new DateTime(2024, 4, 6, 18, 24, 46, 0, DateTimeKind.Unspecified), new DateTime(2024, 7, 21, 7, 55, 22, 0, DateTimeKind.Unspecified) });

            migrationBuilder.UpdateData(
                table: "TimeRegistrations",
                keyColumn: "TimeRegistrationId",
                keyValue: 891,
                columns: new[] { "EndTime", "StartTime" },
                values: new object[] { new DateTime(2024, 4, 17, 15, 44, 43, 0, DateTimeKind.Unspecified), new DateTime(2024, 11, 28, 13, 46, 44, 0, DateTimeKind.Unspecified) });

            migrationBuilder.UpdateData(
                table: "TimeRegistrations",
                keyColumn: "TimeRegistrationId",
                keyValue: 892,
                columns: new[] { "EndTime", "StartTime" },
                values: new object[] { new DateTime(2024, 6, 29, 19, 29, 30, 0, DateTimeKind.Unspecified), new DateTime(2024, 4, 30, 22, 30, 26, 0, DateTimeKind.Unspecified) });

            migrationBuilder.UpdateData(
                table: "TimeRegistrations",
                keyColumn: "TimeRegistrationId",
                keyValue: 893,
                columns: new[] { "EndTime", "StartTime" },
                values: new object[] { new DateTime(2024, 3, 22, 7, 18, 51, 0, DateTimeKind.Unspecified), new DateTime(2024, 6, 23, 19, 16, 7, 0, DateTimeKind.Unspecified) });

            migrationBuilder.UpdateData(
                table: "TimeRegistrations",
                keyColumn: "TimeRegistrationId",
                keyValue: 894,
                columns: new[] { "EndTime", "StartTime" },
                values: new object[] { new DateTime(2024, 7, 4, 20, 29, 31, 0, DateTimeKind.Unspecified), new DateTime(2024, 5, 21, 2, 40, 40, 0, DateTimeKind.Unspecified) });

            migrationBuilder.UpdateData(
                table: "TimeRegistrations",
                keyColumn: "TimeRegistrationId",
                keyValue: 895,
                columns: new[] { "EndTime", "StartTime" },
                values: new object[] { new DateTime(2024, 6, 18, 15, 11, 33, 0, DateTimeKind.Unspecified), new DateTime(2024, 7, 10, 9, 14, 42, 0, DateTimeKind.Unspecified) });

            migrationBuilder.UpdateData(
                table: "TimeRegistrations",
                keyColumn: "TimeRegistrationId",
                keyValue: 896,
                columns: new[] { "EndTime", "StartTime" },
                values: new object[] { new DateTime(2024, 7, 28, 23, 3, 13, 0, DateTimeKind.Unspecified), new DateTime(2024, 10, 1, 3, 23, 22, 0, DateTimeKind.Unspecified) });

            migrationBuilder.UpdateData(
                table: "TimeRegistrations",
                keyColumn: "TimeRegistrationId",
                keyValue: 897,
                columns: new[] { "EndTime", "StartTime" },
                values: new object[] { new DateTime(2024, 4, 9, 16, 45, 20, 0, DateTimeKind.Unspecified), new DateTime(2024, 10, 15, 13, 52, 31, 0, DateTimeKind.Unspecified) });

            migrationBuilder.UpdateData(
                table: "TimeRegistrations",
                keyColumn: "TimeRegistrationId",
                keyValue: 898,
                columns: new[] { "EndTime", "StartTime" },
                values: new object[] { new DateTime(2024, 2, 9, 0, 25, 25, 0, DateTimeKind.Unspecified), new DateTime(2024, 8, 18, 15, 57, 15, 0, DateTimeKind.Unspecified) });

            migrationBuilder.UpdateData(
                table: "TimeRegistrations",
                keyColumn: "TimeRegistrationId",
                keyValue: 899,
                columns: new[] { "EndTime", "StartTime" },
                values: new object[] { new DateTime(2024, 10, 8, 20, 49, 22, 0, DateTimeKind.Unspecified), new DateTime(2024, 3, 15, 15, 43, 38, 0, DateTimeKind.Unspecified) });

            migrationBuilder.UpdateData(
                table: "TimeRegistrations",
                keyColumn: "TimeRegistrationId",
                keyValue: 900,
                columns: new[] { "EndTime", "StartTime" },
                values: new object[] { new DateTime(2024, 3, 22, 5, 9, 20, 0, DateTimeKind.Unspecified), new DateTime(2024, 9, 27, 23, 42, 0, 0, DateTimeKind.Unspecified) });

            migrationBuilder.UpdateData(
                table: "TimeRegistrations",
                keyColumn: "TimeRegistrationId",
                keyValue: 901,
                columns: new[] { "EndTime", "StartTime" },
                values: new object[] { new DateTime(2024, 6, 30, 12, 8, 7, 0, DateTimeKind.Unspecified), new DateTime(2024, 2, 7, 15, 49, 46, 0, DateTimeKind.Unspecified) });

            migrationBuilder.UpdateData(
                table: "TimeRegistrations",
                keyColumn: "TimeRegistrationId",
                keyValue: 902,
                columns: new[] { "EndTime", "StartTime" },
                values: new object[] { new DateTime(2024, 6, 19, 23, 50, 26, 0, DateTimeKind.Unspecified), new DateTime(2024, 12, 12, 10, 24, 33, 0, DateTimeKind.Unspecified) });

            migrationBuilder.UpdateData(
                table: "TimeRegistrations",
                keyColumn: "TimeRegistrationId",
                keyValue: 903,
                columns: new[] { "EndTime", "StartTime" },
                values: new object[] { new DateTime(2024, 7, 19, 22, 8, 40, 0, DateTimeKind.Unspecified), new DateTime(2024, 2, 20, 13, 14, 15, 0, DateTimeKind.Unspecified) });

            migrationBuilder.UpdateData(
                table: "TimeRegistrations",
                keyColumn: "TimeRegistrationId",
                keyValue: 904,
                columns: new[] { "EndTime", "StartTime" },
                values: new object[] { new DateTime(2024, 9, 3, 14, 58, 18, 0, DateTimeKind.Unspecified), new DateTime(2024, 7, 8, 14, 0, 11, 0, DateTimeKind.Unspecified) });

            migrationBuilder.UpdateData(
                table: "TimeRegistrations",
                keyColumn: "TimeRegistrationId",
                keyValue: 905,
                columns: new[] { "EndTime", "StartTime" },
                values: new object[] { new DateTime(2024, 9, 25, 20, 49, 8, 0, DateTimeKind.Unspecified), new DateTime(2024, 11, 21, 6, 5, 42, 0, DateTimeKind.Unspecified) });

            migrationBuilder.UpdateData(
                table: "TimeRegistrations",
                keyColumn: "TimeRegistrationId",
                keyValue: 906,
                columns: new[] { "EndTime", "StartTime" },
                values: new object[] { new DateTime(2024, 12, 30, 22, 43, 0, 0, DateTimeKind.Unspecified), new DateTime(2024, 9, 18, 20, 26, 11, 0, DateTimeKind.Unspecified) });

            migrationBuilder.UpdateData(
                table: "TimeRegistrations",
                keyColumn: "TimeRegistrationId",
                keyValue: 907,
                columns: new[] { "EndTime", "StartTime" },
                values: new object[] { new DateTime(2024, 9, 27, 15, 38, 3, 0, DateTimeKind.Unspecified), new DateTime(2024, 10, 28, 12, 19, 32, 0, DateTimeKind.Unspecified) });

            migrationBuilder.UpdateData(
                table: "TimeRegistrations",
                keyColumn: "TimeRegistrationId",
                keyValue: 908,
                columns: new[] { "EndTime", "StartTime" },
                values: new object[] { new DateTime(2024, 11, 19, 15, 26, 18, 0, DateTimeKind.Unspecified), new DateTime(2024, 7, 2, 0, 55, 15, 0, DateTimeKind.Unspecified) });

            migrationBuilder.UpdateData(
                table: "TimeRegistrations",
                keyColumn: "TimeRegistrationId",
                keyValue: 909,
                columns: new[] { "EndTime", "StartTime" },
                values: new object[] { new DateTime(2024, 12, 27, 21, 25, 24, 0, DateTimeKind.Unspecified), new DateTime(2024, 4, 17, 7, 37, 58, 0, DateTimeKind.Unspecified) });

            migrationBuilder.UpdateData(
                table: "TimeRegistrations",
                keyColumn: "TimeRegistrationId",
                keyValue: 910,
                columns: new[] { "EndTime", "StartTime" },
                values: new object[] { new DateTime(2024, 1, 6, 20, 0, 3, 0, DateTimeKind.Unspecified), new DateTime(2024, 4, 18, 19, 0, 8, 0, DateTimeKind.Unspecified) });

            migrationBuilder.UpdateData(
                table: "TimeRegistrations",
                keyColumn: "TimeRegistrationId",
                keyValue: 911,
                columns: new[] { "EndTime", "StartTime" },
                values: new object[] { new DateTime(2024, 4, 20, 16, 48, 18, 0, DateTimeKind.Unspecified), new DateTime(2024, 4, 30, 8, 5, 43, 0, DateTimeKind.Unspecified) });

            migrationBuilder.UpdateData(
                table: "TimeRegistrations",
                keyColumn: "TimeRegistrationId",
                keyValue: 912,
                columns: new[] { "EndTime", "StartTime" },
                values: new object[] { new DateTime(2024, 5, 30, 2, 32, 2, 0, DateTimeKind.Unspecified), new DateTime(2024, 8, 10, 19, 43, 22, 0, DateTimeKind.Unspecified) });

            migrationBuilder.UpdateData(
                table: "TimeRegistrations",
                keyColumn: "TimeRegistrationId",
                keyValue: 913,
                columns: new[] { "EndTime", "StartTime" },
                values: new object[] { new DateTime(2024, 9, 17, 4, 12, 54, 0, DateTimeKind.Unspecified), new DateTime(2024, 8, 18, 1, 3, 24, 0, DateTimeKind.Unspecified) });

            migrationBuilder.UpdateData(
                table: "TimeRegistrations",
                keyColumn: "TimeRegistrationId",
                keyValue: 914,
                columns: new[] { "EndTime", "StartTime" },
                values: new object[] { new DateTime(2024, 12, 4, 13, 42, 0, 0, DateTimeKind.Unspecified), new DateTime(2024, 11, 10, 10, 25, 52, 0, DateTimeKind.Unspecified) });

            migrationBuilder.UpdateData(
                table: "TimeRegistrations",
                keyColumn: "TimeRegistrationId",
                keyValue: 915,
                columns: new[] { "EndTime", "StartTime" },
                values: new object[] { new DateTime(2024, 5, 13, 11, 45, 34, 0, DateTimeKind.Unspecified), new DateTime(2024, 1, 30, 2, 57, 44, 0, DateTimeKind.Unspecified) });

            migrationBuilder.UpdateData(
                table: "TimeRegistrations",
                keyColumn: "TimeRegistrationId",
                keyValue: 916,
                columns: new[] { "EndTime", "StartTime" },
                values: new object[] { new DateTime(2024, 10, 1, 12, 10, 33, 0, DateTimeKind.Unspecified), new DateTime(2024, 9, 15, 5, 23, 39, 0, DateTimeKind.Unspecified) });

            migrationBuilder.UpdateData(
                table: "TimeRegistrations",
                keyColumn: "TimeRegistrationId",
                keyValue: 917,
                columns: new[] { "EndTime", "StartTime" },
                values: new object[] { new DateTime(2024, 5, 3, 23, 15, 55, 0, DateTimeKind.Unspecified), new DateTime(2024, 1, 21, 12, 5, 31, 0, DateTimeKind.Unspecified) });

            migrationBuilder.UpdateData(
                table: "TimeRegistrations",
                keyColumn: "TimeRegistrationId",
                keyValue: 918,
                columns: new[] { "EndTime", "StartTime" },
                values: new object[] { new DateTime(2024, 11, 21, 15, 22, 36, 0, DateTimeKind.Unspecified), new DateTime(2024, 5, 5, 7, 57, 14, 0, DateTimeKind.Unspecified) });

            migrationBuilder.UpdateData(
                table: "TimeRegistrations",
                keyColumn: "TimeRegistrationId",
                keyValue: 919,
                columns: new[] { "EndTime", "StartTime" },
                values: new object[] { new DateTime(2024, 7, 30, 16, 20, 2, 0, DateTimeKind.Unspecified), new DateTime(2024, 5, 27, 6, 41, 47, 0, DateTimeKind.Unspecified) });

            migrationBuilder.UpdateData(
                table: "TimeRegistrations",
                keyColumn: "TimeRegistrationId",
                keyValue: 920,
                columns: new[] { "EndTime", "StartTime" },
                values: new object[] { new DateTime(2024, 7, 7, 1, 41, 28, 0, DateTimeKind.Unspecified), new DateTime(2024, 3, 13, 18, 53, 51, 0, DateTimeKind.Unspecified) });

            migrationBuilder.UpdateData(
                table: "TimeRegistrations",
                keyColumn: "TimeRegistrationId",
                keyValue: 921,
                columns: new[] { "EndTime", "StartTime" },
                values: new object[] { new DateTime(2024, 4, 15, 6, 52, 55, 0, DateTimeKind.Unspecified), new DateTime(2024, 9, 30, 21, 52, 27, 0, DateTimeKind.Unspecified) });

            migrationBuilder.UpdateData(
                table: "TimeRegistrations",
                keyColumn: "TimeRegistrationId",
                keyValue: 922,
                columns: new[] { "EndTime", "StartTime" },
                values: new object[] { new DateTime(2024, 3, 9, 17, 42, 52, 0, DateTimeKind.Unspecified), new DateTime(2024, 12, 22, 21, 33, 36, 0, DateTimeKind.Unspecified) });

            migrationBuilder.UpdateData(
                table: "TimeRegistrations",
                keyColumn: "TimeRegistrationId",
                keyValue: 923,
                columns: new[] { "EndTime", "StartTime" },
                values: new object[] { new DateTime(2024, 5, 23, 8, 28, 56, 0, DateTimeKind.Unspecified), new DateTime(2024, 6, 15, 9, 49, 13, 0, DateTimeKind.Unspecified) });

            migrationBuilder.UpdateData(
                table: "TimeRegistrations",
                keyColumn: "TimeRegistrationId",
                keyValue: 924,
                columns: new[] { "EndTime", "StartTime" },
                values: new object[] { new DateTime(2024, 2, 13, 8, 38, 7, 0, DateTimeKind.Unspecified), new DateTime(2024, 6, 30, 23, 28, 54, 0, DateTimeKind.Unspecified) });

            migrationBuilder.UpdateData(
                table: "TimeRegistrations",
                keyColumn: "TimeRegistrationId",
                keyValue: 925,
                columns: new[] { "EndTime", "StartTime" },
                values: new object[] { new DateTime(2024, 3, 22, 20, 20, 47, 0, DateTimeKind.Unspecified), new DateTime(2024, 5, 6, 2, 8, 49, 0, DateTimeKind.Unspecified) });

            migrationBuilder.UpdateData(
                table: "TimeRegistrations",
                keyColumn: "TimeRegistrationId",
                keyValue: 926,
                columns: new[] { "EndTime", "StartTime" },
                values: new object[] { new DateTime(2024, 10, 18, 1, 32, 33, 0, DateTimeKind.Unspecified), new DateTime(2024, 12, 30, 3, 30, 50, 0, DateTimeKind.Unspecified) });

            migrationBuilder.UpdateData(
                table: "TimeRegistrations",
                keyColumn: "TimeRegistrationId",
                keyValue: 927,
                columns: new[] { "EndTime", "StartTime" },
                values: new object[] { new DateTime(2024, 4, 1, 2, 26, 9, 0, DateTimeKind.Unspecified), new DateTime(2024, 7, 4, 19, 22, 46, 0, DateTimeKind.Unspecified) });

            migrationBuilder.UpdateData(
                table: "TimeRegistrations",
                keyColumn: "TimeRegistrationId",
                keyValue: 928,
                columns: new[] { "EndTime", "StartTime" },
                values: new object[] { new DateTime(2024, 4, 6, 20, 1, 59, 0, DateTimeKind.Unspecified), new DateTime(2024, 10, 10, 21, 9, 48, 0, DateTimeKind.Unspecified) });

            migrationBuilder.UpdateData(
                table: "TimeRegistrations",
                keyColumn: "TimeRegistrationId",
                keyValue: 929,
                columns: new[] { "EndTime", "StartTime" },
                values: new object[] { new DateTime(2024, 8, 31, 15, 33, 14, 0, DateTimeKind.Unspecified), new DateTime(2024, 5, 7, 15, 49, 33, 0, DateTimeKind.Unspecified) });

            migrationBuilder.UpdateData(
                table: "TimeRegistrations",
                keyColumn: "TimeRegistrationId",
                keyValue: 930,
                columns: new[] { "EndTime", "StartTime" },
                values: new object[] { new DateTime(2024, 12, 13, 1, 5, 54, 0, DateTimeKind.Unspecified), new DateTime(2024, 5, 31, 14, 50, 16, 0, DateTimeKind.Unspecified) });

            migrationBuilder.UpdateData(
                table: "TimeRegistrations",
                keyColumn: "TimeRegistrationId",
                keyValue: 931,
                columns: new[] { "EndTime", "StartTime" },
                values: new object[] { new DateTime(2024, 9, 27, 6, 55, 26, 0, DateTimeKind.Unspecified), new DateTime(2024, 11, 3, 7, 45, 3, 0, DateTimeKind.Unspecified) });

            migrationBuilder.UpdateData(
                table: "TimeRegistrations",
                keyColumn: "TimeRegistrationId",
                keyValue: 932,
                columns: new[] { "EndTime", "StartTime" },
                values: new object[] { new DateTime(2024, 1, 25, 6, 32, 5, 0, DateTimeKind.Unspecified), new DateTime(2024, 8, 18, 18, 50, 54, 0, DateTimeKind.Unspecified) });

            migrationBuilder.UpdateData(
                table: "TimeRegistrations",
                keyColumn: "TimeRegistrationId",
                keyValue: 933,
                columns: new[] { "EndTime", "StartTime" },
                values: new object[] { new DateTime(2024, 4, 6, 10, 31, 48, 0, DateTimeKind.Unspecified), new DateTime(2024, 9, 20, 20, 10, 59, 0, DateTimeKind.Unspecified) });

            migrationBuilder.UpdateData(
                table: "TimeRegistrations",
                keyColumn: "TimeRegistrationId",
                keyValue: 934,
                columns: new[] { "EndTime", "StartTime" },
                values: new object[] { new DateTime(2024, 11, 12, 16, 17, 36, 0, DateTimeKind.Unspecified), new DateTime(2024, 5, 8, 16, 57, 42, 0, DateTimeKind.Unspecified) });

            migrationBuilder.UpdateData(
                table: "TimeRegistrations",
                keyColumn: "TimeRegistrationId",
                keyValue: 935,
                columns: new[] { "EndTime", "StartTime" },
                values: new object[] { new DateTime(2024, 3, 22, 8, 19, 45, 0, DateTimeKind.Unspecified), new DateTime(2024, 6, 15, 3, 19, 50, 0, DateTimeKind.Unspecified) });

            migrationBuilder.UpdateData(
                table: "TimeRegistrations",
                keyColumn: "TimeRegistrationId",
                keyValue: 936,
                columns: new[] { "EndTime", "StartTime" },
                values: new object[] { new DateTime(2024, 11, 30, 13, 45, 55, 0, DateTimeKind.Unspecified), new DateTime(2024, 1, 14, 20, 40, 49, 0, DateTimeKind.Unspecified) });

            migrationBuilder.UpdateData(
                table: "TimeRegistrations",
                keyColumn: "TimeRegistrationId",
                keyValue: 937,
                columns: new[] { "EndTime", "StartTime" },
                values: new object[] { new DateTime(2024, 8, 6, 12, 33, 5, 0, DateTimeKind.Unspecified), new DateTime(2024, 8, 6, 15, 42, 51, 0, DateTimeKind.Unspecified) });

            migrationBuilder.UpdateData(
                table: "TimeRegistrations",
                keyColumn: "TimeRegistrationId",
                keyValue: 938,
                columns: new[] { "EndTime", "StartTime" },
                values: new object[] { new DateTime(2024, 9, 29, 0, 41, 59, 0, DateTimeKind.Unspecified), new DateTime(2024, 1, 29, 16, 5, 45, 0, DateTimeKind.Unspecified) });

            migrationBuilder.UpdateData(
                table: "TimeRegistrations",
                keyColumn: "TimeRegistrationId",
                keyValue: 939,
                columns: new[] { "EndTime", "StartTime" },
                values: new object[] { new DateTime(2024, 8, 16, 11, 22, 40, 0, DateTimeKind.Unspecified), new DateTime(2024, 10, 30, 13, 28, 58, 0, DateTimeKind.Unspecified) });

            migrationBuilder.UpdateData(
                table: "TimeRegistrations",
                keyColumn: "TimeRegistrationId",
                keyValue: 940,
                columns: new[] { "EndTime", "StartTime" },
                values: new object[] { new DateTime(2024, 4, 22, 2, 39, 46, 0, DateTimeKind.Unspecified), new DateTime(2024, 7, 27, 17, 33, 43, 0, DateTimeKind.Unspecified) });

            migrationBuilder.UpdateData(
                table: "TimeRegistrations",
                keyColumn: "TimeRegistrationId",
                keyValue: 941,
                columns: new[] { "EndTime", "StartTime" },
                values: new object[] { new DateTime(2024, 3, 29, 17, 42, 2, 0, DateTimeKind.Unspecified), new DateTime(2024, 4, 20, 23, 24, 1, 0, DateTimeKind.Unspecified) });

            migrationBuilder.UpdateData(
                table: "TimeRegistrations",
                keyColumn: "TimeRegistrationId",
                keyValue: 942,
                columns: new[] { "EndTime", "StartTime" },
                values: new object[] { new DateTime(2024, 5, 1, 11, 28, 46, 0, DateTimeKind.Unspecified), new DateTime(2024, 6, 3, 7, 2, 59, 0, DateTimeKind.Unspecified) });

            migrationBuilder.UpdateData(
                table: "TimeRegistrations",
                keyColumn: "TimeRegistrationId",
                keyValue: 943,
                columns: new[] { "EndTime", "StartTime" },
                values: new object[] { new DateTime(2024, 8, 10, 21, 29, 55, 0, DateTimeKind.Unspecified), new DateTime(2024, 5, 19, 12, 56, 16, 0, DateTimeKind.Unspecified) });

            migrationBuilder.UpdateData(
                table: "TimeRegistrations",
                keyColumn: "TimeRegistrationId",
                keyValue: 944,
                columns: new[] { "EndTime", "StartTime" },
                values: new object[] { new DateTime(2024, 1, 5, 6, 49, 49, 0, DateTimeKind.Unspecified), new DateTime(2024, 4, 24, 10, 25, 52, 0, DateTimeKind.Unspecified) });

            migrationBuilder.UpdateData(
                table: "TimeRegistrations",
                keyColumn: "TimeRegistrationId",
                keyValue: 945,
                columns: new[] { "EndTime", "StartTime" },
                values: new object[] { new DateTime(2024, 11, 6, 12, 54, 46, 0, DateTimeKind.Unspecified), new DateTime(2024, 5, 4, 23, 52, 56, 0, DateTimeKind.Unspecified) });

            migrationBuilder.UpdateData(
                table: "TimeRegistrations",
                keyColumn: "TimeRegistrationId",
                keyValue: 946,
                columns: new[] { "EndTime", "StartTime" },
                values: new object[] { new DateTime(2024, 4, 9, 11, 16, 5, 0, DateTimeKind.Unspecified), new DateTime(2024, 7, 5, 22, 34, 45, 0, DateTimeKind.Unspecified) });

            migrationBuilder.UpdateData(
                table: "TimeRegistrations",
                keyColumn: "TimeRegistrationId",
                keyValue: 947,
                columns: new[] { "EndTime", "StartTime" },
                values: new object[] { new DateTime(2024, 2, 7, 5, 31, 25, 0, DateTimeKind.Unspecified), new DateTime(2024, 10, 25, 1, 40, 28, 0, DateTimeKind.Unspecified) });

            migrationBuilder.UpdateData(
                table: "TimeRegistrations",
                keyColumn: "TimeRegistrationId",
                keyValue: 948,
                columns: new[] { "EndTime", "StartTime" },
                values: new object[] { new DateTime(2024, 8, 1, 2, 52, 50, 0, DateTimeKind.Unspecified), new DateTime(2024, 3, 21, 21, 40, 6, 0, DateTimeKind.Unspecified) });

            migrationBuilder.UpdateData(
                table: "TimeRegistrations",
                keyColumn: "TimeRegistrationId",
                keyValue: 949,
                columns: new[] { "EndTime", "StartTime" },
                values: new object[] { new DateTime(2024, 7, 29, 6, 34, 17, 0, DateTimeKind.Unspecified), new DateTime(2024, 8, 6, 2, 13, 25, 0, DateTimeKind.Unspecified) });

            migrationBuilder.UpdateData(
                table: "TimeRegistrations",
                keyColumn: "TimeRegistrationId",
                keyValue: 950,
                columns: new[] { "EndTime", "StartTime" },
                values: new object[] { new DateTime(2024, 3, 2, 4, 55, 3, 0, DateTimeKind.Unspecified), new DateTime(2024, 12, 15, 22, 30, 38, 0, DateTimeKind.Unspecified) });

            migrationBuilder.UpdateData(
                table: "TimeRegistrations",
                keyColumn: "TimeRegistrationId",
                keyValue: 951,
                columns: new[] { "EndTime", "StartTime" },
                values: new object[] { new DateTime(2024, 10, 7, 12, 43, 19, 0, DateTimeKind.Unspecified), new DateTime(2024, 6, 17, 18, 5, 26, 0, DateTimeKind.Unspecified) });

            migrationBuilder.UpdateData(
                table: "TimeRegistrations",
                keyColumn: "TimeRegistrationId",
                keyValue: 952,
                columns: new[] { "EndTime", "StartTime" },
                values: new object[] { new DateTime(2024, 8, 22, 21, 9, 25, 0, DateTimeKind.Unspecified), new DateTime(2024, 9, 7, 22, 45, 43, 0, DateTimeKind.Unspecified) });

            migrationBuilder.UpdateData(
                table: "TimeRegistrations",
                keyColumn: "TimeRegistrationId",
                keyValue: 953,
                columns: new[] { "EndTime", "StartTime" },
                values: new object[] { new DateTime(2024, 7, 25, 23, 14, 55, 0, DateTimeKind.Unspecified), new DateTime(2024, 8, 6, 22, 15, 3, 0, DateTimeKind.Unspecified) });

            migrationBuilder.UpdateData(
                table: "TimeRegistrations",
                keyColumn: "TimeRegistrationId",
                keyValue: 954,
                columns: new[] { "EndTime", "StartTime" },
                values: new object[] { new DateTime(2024, 1, 29, 7, 59, 57, 0, DateTimeKind.Unspecified), new DateTime(2024, 2, 15, 23, 19, 1, 0, DateTimeKind.Unspecified) });

            migrationBuilder.UpdateData(
                table: "TimeRegistrations",
                keyColumn: "TimeRegistrationId",
                keyValue: 955,
                columns: new[] { "EndTime", "StartTime" },
                values: new object[] { new DateTime(2024, 8, 31, 12, 1, 12, 0, DateTimeKind.Unspecified), new DateTime(2024, 4, 30, 7, 43, 53, 0, DateTimeKind.Unspecified) });

            migrationBuilder.UpdateData(
                table: "TimeRegistrations",
                keyColumn: "TimeRegistrationId",
                keyValue: 956,
                columns: new[] { "EndTime", "StartTime" },
                values: new object[] { new DateTime(2024, 5, 11, 12, 35, 15, 0, DateTimeKind.Unspecified), new DateTime(2024, 3, 24, 1, 50, 48, 0, DateTimeKind.Unspecified) });

            migrationBuilder.UpdateData(
                table: "TimeRegistrations",
                keyColumn: "TimeRegistrationId",
                keyValue: 957,
                columns: new[] { "EndTime", "StartTime" },
                values: new object[] { new DateTime(2024, 3, 21, 15, 13, 17, 0, DateTimeKind.Unspecified), new DateTime(2024, 11, 13, 8, 51, 42, 0, DateTimeKind.Unspecified) });

            migrationBuilder.UpdateData(
                table: "TimeRegistrations",
                keyColumn: "TimeRegistrationId",
                keyValue: 958,
                columns: new[] { "EndTime", "StartTime" },
                values: new object[] { new DateTime(2024, 1, 12, 2, 30, 1, 0, DateTimeKind.Unspecified), new DateTime(2024, 6, 9, 19, 22, 15, 0, DateTimeKind.Unspecified) });

            migrationBuilder.UpdateData(
                table: "TimeRegistrations",
                keyColumn: "TimeRegistrationId",
                keyValue: 959,
                columns: new[] { "EndTime", "StartTime" },
                values: new object[] { new DateTime(2024, 2, 13, 18, 17, 39, 0, DateTimeKind.Unspecified), new DateTime(2024, 9, 10, 7, 47, 29, 0, DateTimeKind.Unspecified) });

            migrationBuilder.UpdateData(
                table: "TimeRegistrations",
                keyColumn: "TimeRegistrationId",
                keyValue: 960,
                columns: new[] { "EndTime", "StartTime" },
                values: new object[] { new DateTime(2024, 10, 24, 11, 45, 35, 0, DateTimeKind.Unspecified), new DateTime(2024, 6, 9, 8, 40, 46, 0, DateTimeKind.Unspecified) });

            migrationBuilder.UpdateData(
                table: "TimeRegistrations",
                keyColumn: "TimeRegistrationId",
                keyValue: 961,
                columns: new[] { "EndTime", "StartTime" },
                values: new object[] { new DateTime(2024, 6, 2, 11, 26, 30, 0, DateTimeKind.Unspecified), new DateTime(2024, 12, 17, 7, 3, 3, 0, DateTimeKind.Unspecified) });

            migrationBuilder.UpdateData(
                table: "TimeRegistrations",
                keyColumn: "TimeRegistrationId",
                keyValue: 962,
                columns: new[] { "EndTime", "StartTime" },
                values: new object[] { new DateTime(2024, 5, 17, 14, 12, 49, 0, DateTimeKind.Unspecified), new DateTime(2024, 10, 31, 14, 52, 47, 0, DateTimeKind.Unspecified) });

            migrationBuilder.UpdateData(
                table: "TimeRegistrations",
                keyColumn: "TimeRegistrationId",
                keyValue: 963,
                columns: new[] { "EndTime", "StartTime" },
                values: new object[] { new DateTime(2024, 8, 16, 6, 25, 39, 0, DateTimeKind.Unspecified), new DateTime(2024, 2, 8, 1, 31, 15, 0, DateTimeKind.Unspecified) });

            migrationBuilder.UpdateData(
                table: "TimeRegistrations",
                keyColumn: "TimeRegistrationId",
                keyValue: 964,
                columns: new[] { "EndTime", "StartTime" },
                values: new object[] { new DateTime(2024, 4, 19, 12, 21, 7, 0, DateTimeKind.Unspecified), new DateTime(2024, 8, 28, 20, 38, 10, 0, DateTimeKind.Unspecified) });

            migrationBuilder.UpdateData(
                table: "TimeRegistrations",
                keyColumn: "TimeRegistrationId",
                keyValue: 965,
                columns: new[] { "EndTime", "StartTime" },
                values: new object[] { new DateTime(2024, 10, 27, 23, 37, 5, 0, DateTimeKind.Unspecified), new DateTime(2024, 9, 16, 0, 50, 37, 0, DateTimeKind.Unspecified) });

            migrationBuilder.UpdateData(
                table: "TimeRegistrations",
                keyColumn: "TimeRegistrationId",
                keyValue: 966,
                columns: new[] { "EndTime", "StartTime" },
                values: new object[] { new DateTime(2024, 4, 25, 7, 9, 17, 0, DateTimeKind.Unspecified), new DateTime(2024, 8, 22, 18, 19, 20, 0, DateTimeKind.Unspecified) });

            migrationBuilder.UpdateData(
                table: "TimeRegistrations",
                keyColumn: "TimeRegistrationId",
                keyValue: 967,
                columns: new[] { "EndTime", "StartTime" },
                values: new object[] { new DateTime(2024, 11, 6, 10, 51, 16, 0, DateTimeKind.Unspecified), new DateTime(2024, 4, 28, 9, 41, 11, 0, DateTimeKind.Unspecified) });

            migrationBuilder.UpdateData(
                table: "TimeRegistrations",
                keyColumn: "TimeRegistrationId",
                keyValue: 968,
                columns: new[] { "EndTime", "StartTime" },
                values: new object[] { new DateTime(2024, 1, 8, 10, 6, 45, 0, DateTimeKind.Unspecified), new DateTime(2024, 12, 23, 22, 10, 6, 0, DateTimeKind.Unspecified) });

            migrationBuilder.UpdateData(
                table: "TimeRegistrations",
                keyColumn: "TimeRegistrationId",
                keyValue: 969,
                columns: new[] { "EndTime", "StartTime" },
                values: new object[] { new DateTime(2024, 7, 11, 1, 58, 22, 0, DateTimeKind.Unspecified), new DateTime(2024, 8, 30, 3, 52, 57, 0, DateTimeKind.Unspecified) });

            migrationBuilder.UpdateData(
                table: "TimeRegistrations",
                keyColumn: "TimeRegistrationId",
                keyValue: 970,
                columns: new[] { "EndTime", "StartTime" },
                values: new object[] { new DateTime(2024, 9, 10, 16, 13, 48, 0, DateTimeKind.Unspecified), new DateTime(2024, 8, 6, 6, 22, 2, 0, DateTimeKind.Unspecified) });

            migrationBuilder.UpdateData(
                table: "TimeRegistrations",
                keyColumn: "TimeRegistrationId",
                keyValue: 971,
                columns: new[] { "EndTime", "StartTime" },
                values: new object[] { new DateTime(2024, 8, 29, 5, 5, 35, 0, DateTimeKind.Unspecified), new DateTime(2024, 11, 14, 22, 19, 8, 0, DateTimeKind.Unspecified) });

            migrationBuilder.UpdateData(
                table: "TimeRegistrations",
                keyColumn: "TimeRegistrationId",
                keyValue: 972,
                columns: new[] { "EndTime", "StartTime" },
                values: new object[] { new DateTime(2024, 10, 2, 1, 44, 35, 0, DateTimeKind.Unspecified), new DateTime(2024, 2, 2, 18, 31, 57, 0, DateTimeKind.Unspecified) });

            migrationBuilder.UpdateData(
                table: "TimeRegistrations",
                keyColumn: "TimeRegistrationId",
                keyValue: 973,
                columns: new[] { "EndTime", "StartTime" },
                values: new object[] { new DateTime(2024, 5, 17, 17, 29, 1, 0, DateTimeKind.Unspecified), new DateTime(2024, 11, 30, 8, 8, 46, 0, DateTimeKind.Unspecified) });

            migrationBuilder.UpdateData(
                table: "TimeRegistrations",
                keyColumn: "TimeRegistrationId",
                keyValue: 974,
                columns: new[] { "EndTime", "StartTime" },
                values: new object[] { new DateTime(2024, 1, 30, 11, 53, 16, 0, DateTimeKind.Unspecified), new DateTime(2024, 9, 3, 18, 55, 27, 0, DateTimeKind.Unspecified) });

            migrationBuilder.UpdateData(
                table: "TimeRegistrations",
                keyColumn: "TimeRegistrationId",
                keyValue: 975,
                columns: new[] { "EndTime", "StartTime" },
                values: new object[] { new DateTime(2024, 5, 29, 8, 14, 22, 0, DateTimeKind.Unspecified), new DateTime(2024, 7, 2, 5, 51, 34, 0, DateTimeKind.Unspecified) });

            migrationBuilder.UpdateData(
                table: "TimeRegistrations",
                keyColumn: "TimeRegistrationId",
                keyValue: 976,
                columns: new[] { "EndTime", "StartTime" },
                values: new object[] { new DateTime(2024, 6, 21, 8, 26, 46, 0, DateTimeKind.Unspecified), new DateTime(2024, 8, 11, 0, 9, 4, 0, DateTimeKind.Unspecified) });

            migrationBuilder.UpdateData(
                table: "TimeRegistrations",
                keyColumn: "TimeRegistrationId",
                keyValue: 977,
                columns: new[] { "EndTime", "StartTime" },
                values: new object[] { new DateTime(2024, 10, 15, 21, 46, 28, 0, DateTimeKind.Unspecified), new DateTime(2024, 4, 27, 8, 43, 3, 0, DateTimeKind.Unspecified) });

            migrationBuilder.UpdateData(
                table: "TimeRegistrations",
                keyColumn: "TimeRegistrationId",
                keyValue: 978,
                columns: new[] { "EndTime", "StartTime" },
                values: new object[] { new DateTime(2024, 4, 27, 8, 26, 13, 0, DateTimeKind.Unspecified), new DateTime(2024, 5, 4, 10, 45, 41, 0, DateTimeKind.Unspecified) });

            migrationBuilder.UpdateData(
                table: "TimeRegistrations",
                keyColumn: "TimeRegistrationId",
                keyValue: 979,
                columns: new[] { "EndTime", "StartTime" },
                values: new object[] { new DateTime(2024, 3, 15, 16, 23, 11, 0, DateTimeKind.Unspecified), new DateTime(2024, 10, 1, 6, 5, 15, 0, DateTimeKind.Unspecified) });

            migrationBuilder.UpdateData(
                table: "TimeRegistrations",
                keyColumn: "TimeRegistrationId",
                keyValue: 980,
                columns: new[] { "EndTime", "StartTime" },
                values: new object[] { new DateTime(2024, 1, 13, 11, 0, 6, 0, DateTimeKind.Unspecified), new DateTime(2024, 7, 16, 7, 7, 29, 0, DateTimeKind.Unspecified) });

            migrationBuilder.UpdateData(
                table: "TimeRegistrations",
                keyColumn: "TimeRegistrationId",
                keyValue: 981,
                columns: new[] { "EndTime", "StartTime" },
                values: new object[] { new DateTime(2024, 8, 9, 12, 23, 48, 0, DateTimeKind.Unspecified), new DateTime(2024, 6, 28, 19, 52, 39, 0, DateTimeKind.Unspecified) });

            migrationBuilder.UpdateData(
                table: "TimeRegistrations",
                keyColumn: "TimeRegistrationId",
                keyValue: 982,
                columns: new[] { "EndTime", "StartTime" },
                values: new object[] { new DateTime(2024, 10, 26, 2, 9, 35, 0, DateTimeKind.Unspecified), new DateTime(2024, 5, 25, 23, 33, 42, 0, DateTimeKind.Unspecified) });

            migrationBuilder.UpdateData(
                table: "TimeRegistrations",
                keyColumn: "TimeRegistrationId",
                keyValue: 983,
                columns: new[] { "EndTime", "StartTime" },
                values: new object[] { new DateTime(2024, 5, 18, 1, 13, 27, 0, DateTimeKind.Unspecified), new DateTime(2024, 3, 6, 12, 13, 25, 0, DateTimeKind.Unspecified) });

            migrationBuilder.UpdateData(
                table: "TimeRegistrations",
                keyColumn: "TimeRegistrationId",
                keyValue: 984,
                columns: new[] { "EndTime", "StartTime" },
                values: new object[] { new DateTime(2024, 12, 15, 22, 17, 50, 0, DateTimeKind.Unspecified), new DateTime(2024, 3, 10, 11, 8, 46, 0, DateTimeKind.Unspecified) });

            migrationBuilder.UpdateData(
                table: "TimeRegistrations",
                keyColumn: "TimeRegistrationId",
                keyValue: 985,
                columns: new[] { "EndTime", "StartTime" },
                values: new object[] { new DateTime(2024, 1, 26, 18, 28, 50, 0, DateTimeKind.Unspecified), new DateTime(2024, 10, 25, 5, 21, 12, 0, DateTimeKind.Unspecified) });

            migrationBuilder.UpdateData(
                table: "TimeRegistrations",
                keyColumn: "TimeRegistrationId",
                keyValue: 986,
                columns: new[] { "EndTime", "StartTime" },
                values: new object[] { new DateTime(2024, 4, 1, 22, 48, 52, 0, DateTimeKind.Unspecified), new DateTime(2024, 5, 20, 12, 32, 56, 0, DateTimeKind.Unspecified) });

            migrationBuilder.UpdateData(
                table: "TimeRegistrations",
                keyColumn: "TimeRegistrationId",
                keyValue: 987,
                columns: new[] { "EndTime", "StartTime" },
                values: new object[] { new DateTime(2024, 8, 22, 6, 45, 46, 0, DateTimeKind.Unspecified), new DateTime(2024, 7, 28, 12, 37, 7, 0, DateTimeKind.Unspecified) });

            migrationBuilder.UpdateData(
                table: "TimeRegistrations",
                keyColumn: "TimeRegistrationId",
                keyValue: 988,
                columns: new[] { "EndTime", "StartTime" },
                values: new object[] { new DateTime(2024, 4, 24, 8, 48, 29, 0, DateTimeKind.Unspecified), new DateTime(2024, 5, 14, 1, 49, 12, 0, DateTimeKind.Unspecified) });

            migrationBuilder.UpdateData(
                table: "TimeRegistrations",
                keyColumn: "TimeRegistrationId",
                keyValue: 989,
                columns: new[] { "EndTime", "StartTime" },
                values: new object[] { new DateTime(2024, 5, 26, 1, 58, 26, 0, DateTimeKind.Unspecified), new DateTime(2024, 8, 6, 20, 0, 9, 0, DateTimeKind.Unspecified) });

            migrationBuilder.UpdateData(
                table: "TimeRegistrations",
                keyColumn: "TimeRegistrationId",
                keyValue: 990,
                columns: new[] { "EndTime", "StartTime" },
                values: new object[] { new DateTime(2024, 4, 11, 16, 27, 2, 0, DateTimeKind.Unspecified), new DateTime(2024, 12, 1, 1, 27, 41, 0, DateTimeKind.Unspecified) });

            migrationBuilder.UpdateData(
                table: "TimeRegistrations",
                keyColumn: "TimeRegistrationId",
                keyValue: 991,
                columns: new[] { "EndTime", "StartTime" },
                values: new object[] { new DateTime(2024, 3, 25, 20, 2, 18, 0, DateTimeKind.Unspecified), new DateTime(2024, 3, 4, 4, 37, 55, 0, DateTimeKind.Unspecified) });

            migrationBuilder.UpdateData(
                table: "TimeRegistrations",
                keyColumn: "TimeRegistrationId",
                keyValue: 992,
                columns: new[] { "EndTime", "StartTime" },
                values: new object[] { new DateTime(2024, 1, 19, 13, 6, 7, 0, DateTimeKind.Unspecified), new DateTime(2024, 10, 19, 12, 25, 21, 0, DateTimeKind.Unspecified) });

            migrationBuilder.UpdateData(
                table: "TimeRegistrations",
                keyColumn: "TimeRegistrationId",
                keyValue: 993,
                columns: new[] { "EndTime", "StartTime" },
                values: new object[] { new DateTime(2024, 2, 2, 13, 31, 16, 0, DateTimeKind.Unspecified), new DateTime(2024, 8, 6, 23, 0, 29, 0, DateTimeKind.Unspecified) });

            migrationBuilder.UpdateData(
                table: "TimeRegistrations",
                keyColumn: "TimeRegistrationId",
                keyValue: 994,
                columns: new[] { "EndTime", "StartTime" },
                values: new object[] { new DateTime(2024, 7, 6, 18, 51, 25, 0, DateTimeKind.Unspecified), new DateTime(2024, 5, 2, 21, 51, 13, 0, DateTimeKind.Unspecified) });

            migrationBuilder.UpdateData(
                table: "TimeRegistrations",
                keyColumn: "TimeRegistrationId",
                keyValue: 995,
                columns: new[] { "EndTime", "StartTime" },
                values: new object[] { new DateTime(2024, 4, 26, 3, 33, 44, 0, DateTimeKind.Unspecified), new DateTime(2024, 5, 24, 14, 28, 25, 0, DateTimeKind.Unspecified) });

            migrationBuilder.UpdateData(
                table: "TimeRegistrations",
                keyColumn: "TimeRegistrationId",
                keyValue: 996,
                columns: new[] { "EndTime", "StartTime" },
                values: new object[] { new DateTime(2024, 12, 7, 22, 58, 3, 0, DateTimeKind.Unspecified), new DateTime(2024, 1, 14, 19, 17, 0, 0, DateTimeKind.Unspecified) });

            migrationBuilder.UpdateData(
                table: "TimeRegistrations",
                keyColumn: "TimeRegistrationId",
                keyValue: 997,
                columns: new[] { "EndTime", "StartTime" },
                values: new object[] { new DateTime(2024, 6, 26, 13, 6, 49, 0, DateTimeKind.Unspecified), new DateTime(2024, 1, 17, 19, 39, 52, 0, DateTimeKind.Unspecified) });

            migrationBuilder.UpdateData(
                table: "TimeRegistrations",
                keyColumn: "TimeRegistrationId",
                keyValue: 998,
                columns: new[] { "EndTime", "StartTime" },
                values: new object[] { new DateTime(2024, 4, 4, 18, 18, 42, 0, DateTimeKind.Unspecified), new DateTime(2024, 1, 29, 5, 23, 7, 0, DateTimeKind.Unspecified) });

            migrationBuilder.UpdateData(
                table: "TimeRegistrations",
                keyColumn: "TimeRegistrationId",
                keyValue: 999,
                columns: new[] { "EndTime", "StartTime" },
                values: new object[] { new DateTime(2024, 1, 20, 23, 18, 27, 0, DateTimeKind.Unspecified), new DateTime(2024, 11, 14, 21, 24, 37, 0, DateTimeKind.Unspecified) });

            migrationBuilder.UpdateData(
                table: "TimeRegistrations",
                keyColumn: "TimeRegistrationId",
                keyValue: 1000,
                columns: new[] { "EndTime", "StartTime" },
                values: new object[] { new DateTime(2024, 1, 25, 22, 48, 4, 0, DateTimeKind.Unspecified), new DateTime(2024, 5, 30, 13, 56, 13, 0, DateTimeKind.Unspecified) });
        }
    }
}
