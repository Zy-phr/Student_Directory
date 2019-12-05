using Microsoft.EntityFrameworkCore.Migrations;

namespace Student_Directory.Migrations
{
    public partial class InitialRun : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Majors",
                columns: table => new
                {
                    Major_Num = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Major_Id = table.Column<string>(nullable: false),
                    Major_Dept = table.Column<string>(nullable: false),
                    Major_Desc = table.Column<string>(nullable: true),
                    Major_Degree = table.Column<string>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Majors", x => x.Major_Num);
                });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Majors");
        }
    }
}
