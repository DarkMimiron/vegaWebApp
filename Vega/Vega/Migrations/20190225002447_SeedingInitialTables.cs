using Microsoft.EntityFrameworkCore.Migrations;

namespace Vega.Migrations
{
    public partial class SeedingInitialTables : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder){
            migrationBuilder.Sql("INSERT INTO VegaDb.dbo.Brand (Name) VALUES ('Abarth')");
            migrationBuilder.Sql("INSERT INTO VegaDb.dbo.Brand (Name) VALUES ('Audi')");
            migrationBuilder.Sql("INSERT INTO VegaDb.dbo.Brand (Name) VALUES ('BMW')");
            migrationBuilder.Sql("INSERT INTO VegaDb.dbo.Brand (Name) VALUES ('Ford')");
            migrationBuilder.Sql("INSERT INTO VegaDb.dbo.Brand (Name) VALUES ('Honda')");
            migrationBuilder.Sql("INSERT INTO VegaDb.dbo.Brand (Name) VALUES ('Jeep')");
            migrationBuilder.Sql("INSERT INTO VegaDb.dbo.Brand (Name) VALUES ('Mazda')");
            migrationBuilder.Sql("INSERT INTO VegaDb.dbo.Brand (Name) VALUES ('Tesla')");
            
            migrationBuilder.Sql("INSERT INTO VegaDb.dbo.Model (Name, BrandId) VALUES ('Abarth 595', 1)");
            migrationBuilder.Sql("INSERT INTO VegaDb.dbo.Model (Name, BrandId) VALUES ('Abarth 124 Spider', 1)");
            migrationBuilder.Sql("INSERT INTO VegaDb.dbo.Model (Name, BrandId) VALUES ('Audi Q3', 2)");
            migrationBuilder.Sql("INSERT INTO VegaDb.dbo.Model (Name, BrandId) VALUES ('Audi Q8', 2)");
            migrationBuilder.Sql("INSERT INTO VegaDb.dbo.Model (Name, BrandId) VALUES ('Audi e-tron', 2)");
            migrationBuilder.Sql("INSERT INTO VegaDb.dbo.Model (Name, BrandId) VALUES ('BMW i3', 3)");
            migrationBuilder.Sql("INSERT INTO VegaDb.dbo.Model (Name, BrandId) VALUES ('BMW X7', 3)");
            migrationBuilder.Sql("INSERT INTO VegaDb.dbo.Model (Name, BrandId) VALUES ('Ford EcoSport', 4)");
            migrationBuilder.Sql("INSERT INTO VegaDb.dbo.Model (Name, BrandId) VALUES ('Ford Mustang', 4)");
            migrationBuilder.Sql("INSERT INTO VegaDb.dbo.Model (Name, BrandId) VALUES ('Ford Galaxy', 4)");
            migrationBuilder.Sql("INSERT INTO VegaDb.dbo.Model (Name, BrandId) VALUES ('Ford S-MAX', 4)");
            migrationBuilder.Sql("INSERT INTO VegaDb.dbo.Model (Name, BrandId) VALUES ('Ford Mondeo', 4)");
            migrationBuilder.Sql("INSERT INTO VegaDb.dbo.Model (Name, BrandId) VALUES ('Honda Civic', 5)");
            migrationBuilder.Sql("INSERT INTO VegaDb.dbo.Model (Name, BrandId) VALUES ('Honda NSX', 5)");
            migrationBuilder.Sql("INSERT INTO VegaDb.dbo.Model (Name, BrandId) VALUES ('Honda Jazz', 5)");
            migrationBuilder.Sql("INSERT INTO VegaDb.dbo.Model (Name, BrandId) VALUES ('Honda CR-V', 5)");
            migrationBuilder.Sql("INSERT INTO VegaDb.dbo.Model (Name, BrandId) VALUES ('Jeep Renegade', 6)");
            migrationBuilder.Sql("INSERT INTO VegaDb.dbo.Model (Name, BrandId) VALUES ('Jeep Compass', 6)");
            migrationBuilder.Sql("INSERT INTO VegaDb.dbo.Model (Name, BrandId) VALUES ('Jeep Cherokee', 6)");
            migrationBuilder.Sql("INSERT INTO VegaDb.dbo.Model (Name, BrandId) VALUES ('Jeep Grand Cherokee', 6)");
            migrationBuilder.Sql("INSERT INTO VegaDb.dbo.Model (Name, BrandId) VALUES ('Mazda2', 7)");
            migrationBuilder.Sql("INSERT INTO VegaDb.dbo.Model (Name, BrandId) VALUES ('Mazda3', 7)");
            migrationBuilder.Sql("INSERT INTO VegaDb.dbo.Model (Name, BrandId) VALUES ('Mazda MX-5', 7)");
            migrationBuilder.Sql("INSERT INTO VegaDb.dbo.Model (Name, BrandId) VALUES ('Mazda CX-3', 7)");
            migrationBuilder.Sql("INSERT INTO VegaDb.dbo.Model (Name, BrandId) VALUES ('Tesla Model S', 8)");
            migrationBuilder.Sql("INSERT INTO VegaDb.dbo.Model (Name, BrandId) VALUES ('Tesla Model 3', 8)");
            migrationBuilder.Sql("INSERT INTO VegaDb.dbo.Model (Name, BrandId) VALUES ('Tesla Model X', 8)");
            migrationBuilder.Sql("INSERT INTO VegaDb.dbo.Model (Name, BrandId) VALUES ('Tesla Model Y', 8)");
            migrationBuilder.Sql("INSERT INTO VegaDb.dbo.Model (Name, BrandId) VALUES ('Tesla Roadster', 8)");
            
            migrationBuilder.Sql("INSERT INTO VegaDb.dbo.Feature (Name) VALUES ('AEB Breaks')");
            migrationBuilder.Sql("INSERT INTO VegaDb.dbo.Feature (Name) VALUES ('Higher Speed Auto Emergency braking')");
            migrationBuilder.Sql("INSERT INTO VegaDb.dbo.Feature (Name) VALUES ('Electronic Stability Control')");
            migrationBuilder.Sql("INSERT INTO VegaDb.dbo.Feature (Name) VALUES ('Driver Attention Detection')");
            migrationBuilder.Sql("INSERT INTO VegaDb.dbo.Feature (Name) VALUES ('Thorax Airbags With Head')");
            migrationBuilder.Sql("INSERT INTO VegaDb.dbo.Feature (Name) VALUES ('Antilock Braking System')");
            migrationBuilder.Sql("INSERT INTO VegaDb.dbo.Feature (Name) VALUES ('Curtain Airbags')");
            migrationBuilder.Sql("INSERT INTO VegaDb.dbo.Feature (Name) VALUES ('Traction Control')");
            migrationBuilder.Sql("INSERT INTO VegaDb.dbo.Feature (Name) VALUES ('Fog Lamps')");
            migrationBuilder.Sql("INSERT INTO VegaDb.dbo.Feature (Name) VALUES ('Type Pressure Monitor')");
        }

        protected override void Down(MigrationBuilder migrationBuilder){
            migrationBuilder.Sql("DELETE FROM Model");
            
            migrationBuilder.Sql("DELETE FROM Brand");

            migrationBuilder.Sql("DELETE FROM Feature");
        }
    }
}
