using Microsoft.EntityFrameworkCore.Migrations;
using System;
using System.Collections.Generic;

namespace asp.netcoreangular.Migrations
{
    public partial class SeedDatabase : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.Sql("INSERT INTO dbo.Makes (Name) VALUES ('Make1')");
            migrationBuilder.Sql("INSERT INTO dbo.Makes (Name) VALUES ('Make2')");
            migrationBuilder.Sql("INSERT INTO dbo.Makes (Name) VALUES ('Make3')");

            migrationBuilder.Sql("INSERT INTO dbo.Models (Name, MakeId) VALUES ('Make1-ModelA', (SELECT Id FROM dbo.Makes WHERE Name = 'Make1'))");
            migrationBuilder.Sql("INSERT INTO dbo.Models (Name, MakeId) VALUES ('Make1-ModelB', (SELECT Id FROM dbo.Makes WHERE Name = 'Make1'))");
            migrationBuilder.Sql("INSERT INTO dbo.Models (Name, MakeId) VALUES ('Make1-ModelC', (SELECT Id FROM dbo.Makes WHERE Name = 'Make1'))");

            migrationBuilder.Sql("INSERT INTO dbo.Models (Name, MakeId) VALUES ('Make2-ModelA', (SELECT Id FROM dbo.Makes WHERE Name = 'Make2'))");
            migrationBuilder.Sql("INSERT INTO dbo.Models (Name, MakeId) VALUES ('Make2-ModelB', (SELECT Id FROM dbo.Makes WHERE Name = 'Make2'))");
            migrationBuilder.Sql("INSERT INTO dbo.Models (Name, MakeId) VALUES ('Make2-ModelC', (SELECT Id FROM dbo.Makes WHERE Name = 'Make2'))");
        
            migrationBuilder.Sql("INSERT INTO dbo.Models (Name, MakeId) VALUES ('Make3-ModelA', (SELECT Id FROM dbo.Makes WHERE Name = 'Make3'))");
            migrationBuilder.Sql("INSERT INTO dbo.Models (Name, MakeId) VALUES ('Make3-ModelB', (SELECT Id FROM dbo.Makes WHERE Name = 'Make3'))");
            migrationBuilder.Sql("INSERT INTO dbo.Models (Name, MakeId) VALUES ('Make3-ModelC', (SELECT Id FROM dbo.Makes WHERE Name = 'Make3'))");        
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.Sql("DELETE FROM dbo.Makes WHERE Name IN ('Make1', 'Make2', 'Make3')");
        }
    }
}
