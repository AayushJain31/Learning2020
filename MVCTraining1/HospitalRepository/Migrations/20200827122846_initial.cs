using Microsoft.EntityFrameworkCore.Migrations;

namespace HospitalRepository.Migrations
{
    public partial class initial : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "tblPatient",
                columns: table => new
                {
                    Id = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    name = table.Column<string>(nullable: false),
                    address = table.Column<string>(nullable: true),
                    number = table.Column<string>(nullable: false),
                    email = table.Column<string>(nullable: false),
                    guid = table.Column<string>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_tblPatient", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "tblProblem",
                columns: table => new
                {
                    Id = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    problem = table.Column<string>(nullable: true),
                    PatientId = table.Column<int>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_tblProblem", x => x.Id);
                    table.ForeignKey(
                        name: "FK_tblProblem_tblPatient_PatientId",
                        column: x => x.PatientId,
                        principalTable: "tblPatient",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateTable(
                name: "tblTreatment",
                columns: table => new
                {
                    Id = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    treatmentName = table.Column<string>(nullable: true),
                    dose = table.Column<string>(nullable: true),
                    PatientProblemsId = table.Column<int>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_tblTreatment", x => x.Id);
                    table.ForeignKey(
                        name: "FK_tblTreatment_tblProblem_PatientProblemsId",
                        column: x => x.PatientProblemsId,
                        principalTable: "tblProblem",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateIndex(
                name: "IX_tblProblem_PatientId",
                table: "tblProblem",
                column: "PatientId");

            migrationBuilder.CreateIndex(
                name: "IX_tblTreatment_PatientProblemsId",
                table: "tblTreatment",
                column: "PatientProblemsId");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "tblTreatment");

            migrationBuilder.DropTable(
                name: "tblProblem");

            migrationBuilder.DropTable(
                name: "tblPatient");
        }
    }
}
