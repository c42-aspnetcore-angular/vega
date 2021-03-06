﻿using Microsoft.EntityFrameworkCore.Migrations;
using System;
using System.Collections.Generic;

namespace asp.netcoreangular.Migrations
{
    public partial class SeedDatabaseFeatures : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.Sql("INSERT INTO dbo.Features (Name) VALUES ('Feature 1')");
            migrationBuilder.Sql("INSERT INTO dbo.Features (Name) VALUES ('Feature 2')");
            migrationBuilder.Sql("INSERT INTO dbo.Features (Name) VALUES ('Feature 3')");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
           migrationBuilder.Sql("DELETE FROM dbo.Features WHERE Name IN ('Feature 1', 'Feature 2', 'Feature 3')");
        }
    }
}
