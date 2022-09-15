using System;
using Microsoft.EntityFrameworkCore.Migrations;
using Npgsql.EntityFrameworkCore.PostgreSQL.Metadata;

#nullable disable

namespace AfaOHS.Persistence.Migrations
{
    public partial class mig_1 : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "DangerLevels",
                columns: table => new
                {
                    DangerLevelId = table.Column<int>(type: "integer", nullable: false)
                        .Annotation("Npgsql:ValueGenerationStrategy", NpgsqlValueGenerationStrategy.IdentityByDefaultColumn),
                    DangerLevelValue = table.Column<string>(type: "text", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_DangerLevels", x => x.DangerLevelId);
                });

            migrationBuilder.CreateTable(
                name: "Educations",
                columns: table => new
                {
                    EducationId = table.Column<int>(type: "integer", nullable: false)
                        .Annotation("Npgsql:ValueGenerationStrategy", NpgsqlValueGenerationStrategy.IdentityByDefaultColumn),
                    EducationType = table.Column<string>(type: "text", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Educations", x => x.EducationId);
                });

            migrationBuilder.CreateTable(
                name: "Occupations",
                columns: table => new
                {
                    OccupationId = table.Column<int>(type: "integer", nullable: false)
                        .Annotation("Npgsql:ValueGenerationStrategy", NpgsqlValueGenerationStrategy.IdentityByDefaultColumn),
                    OccupationType = table.Column<string>(type: "text", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Occupations", x => x.OccupationId);
                });

            migrationBuilder.CreateTable(
                name: "UserRoles",
                columns: table => new
                {
                    UserRoleId = table.Column<int>(type: "integer", nullable: false)
                        .Annotation("Npgsql:ValueGenerationStrategy", NpgsqlValueGenerationStrategy.IdentityByDefaultColumn),
                    RoleType = table.Column<string>(type: "text", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_UserRoles", x => x.UserRoleId);
                });

            migrationBuilder.CreateTable(
                name: "NaceCodes",
                columns: table => new
                {
                    NaceCodeId = table.Column<int>(type: "integer", nullable: false)
                        .Annotation("Npgsql:ValueGenerationStrategy", NpgsqlValueGenerationStrategy.IdentityByDefaultColumn),
                    NACECode = table.Column<string>(type: "text", nullable: true),
                    Explanation = table.Column<string>(type: "text", nullable: true),
                    DangerLevelId = table.Column<int>(type: "integer", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_NaceCodes", x => x.NaceCodeId);
                    table.ForeignKey(
                        name: "FK_NaceCodes_DangerLevels_DangerLevelId",
                        column: x => x.DangerLevelId,
                        principalTable: "DangerLevels",
                        principalColumn: "DangerLevelId");
                });

            migrationBuilder.CreateTable(
                name: "SUTDatas",
                columns: table => new
                {
                    SUTDataId = table.Column<int>(type: "integer", nullable: false)
                        .Annotation("Npgsql:ValueGenerationStrategy", NpgsqlValueGenerationStrategy.IdentityByDefaultColumn),
                    EmployeeCount = table.Column<int>(type: "integer", nullable: false),
                    OSFee = table.Column<decimal>(type: "numeric", nullable: false),
                    OHFee = table.Column<decimal>(type: "numeric", nullable: false),
                    OHSFee = table.Column<decimal>(type: "numeric", nullable: false),
                    DangerLevelId = table.Column<int>(type: "integer", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_SUTDatas", x => x.SUTDataId);
                    table.ForeignKey(
                        name: "FK_SUTDatas_DangerLevels_DangerLevelId",
                        column: x => x.DangerLevelId,
                        principalTable: "DangerLevels",
                        principalColumn: "DangerLevelId");
                });

            migrationBuilder.CreateTable(
                name: "Employee",
                columns: table => new
                {
                    NationalID = table.Column<string>(type: "text", nullable: false),
                    Address = table.Column<string>(type: "text", nullable: true),
                    EducationId = table.Column<int>(type: "integer", nullable: true),
                    CreationDate = table.Column<DateTime>(type: "timestamp with time zone", nullable: false),
                    UpdateDate = table.Column<DateTime>(type: "timestamp with time zone", nullable: false),
                    IsDeleted = table.Column<bool>(type: "boolean", nullable: false),
                    NameSurname = table.Column<string>(type: "text", nullable: true),
                    MobilePhone = table.Column<string>(type: "text", nullable: true),
                    Email = table.Column<string>(type: "text", nullable: true),
                    OccupationId = table.Column<int>(type: "integer", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Employee", x => x.NationalID);
                    table.ForeignKey(
                        name: "FK_Employee_Educations_EducationId",
                        column: x => x.EducationId,
                        principalTable: "Educations",
                        principalColumn: "EducationId");
                    table.ForeignKey(
                        name: "FK_Employee_Occupations_OccupationId",
                        column: x => x.OccupationId,
                        principalTable: "Occupations",
                        principalColumn: "OccupationId");
                });

            migrationBuilder.CreateTable(
                name: "OHSEmployees",
                columns: table => new
                {
                    NationalID = table.Column<string>(type: "text", nullable: false),
                    CertificateNumber = table.Column<string>(type: "text", nullable: true),
                    IsActive = table.Column<bool>(type: "boolean", nullable: false),
                    UserRoleId = table.Column<int>(type: "integer", nullable: true),
                    Password = table.Column<string>(type: "text", nullable: true),
                    CreationDate = table.Column<DateTime>(type: "timestamp with time zone", nullable: false),
                    UpdateDate = table.Column<DateTime>(type: "timestamp with time zone", nullable: false),
                    IsDeleted = table.Column<bool>(type: "boolean", nullable: false),
                    NameSurname = table.Column<string>(type: "text", nullable: true),
                    MobilePhone = table.Column<string>(type: "text", nullable: true),
                    Email = table.Column<string>(type: "text", nullable: true),
                    OccupationId = table.Column<int>(type: "integer", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_OHSEmployees", x => x.NationalID);
                    table.ForeignKey(
                        name: "FK_OHSEmployees_Occupations_OccupationId",
                        column: x => x.OccupationId,
                        principalTable: "Occupations",
                        principalColumn: "OccupationId");
                    table.ForeignKey(
                        name: "FK_OHSEmployees_UserRoles_UserRoleId",
                        column: x => x.UserRoleId,
                        principalTable: "UserRoles",
                        principalColumn: "UserRoleId");
                });

            migrationBuilder.CreateTable(
                name: "Companies",
                columns: table => new
                {
                    CompanyID = table.Column<string>(type: "text", nullable: false),
                    Name = table.Column<string>(type: "text", nullable: true),
                    Address = table.Column<string>(type: "text", nullable: true),
                    Email = table.Column<string>(type: "text", nullable: true),
                    Phone = table.Column<string>(type: "text", nullable: true),
                    TaxOffice = table.Column<string>(type: "text", nullable: true),
                    TaxNumber = table.Column<string>(type: "text", nullable: true),
                    ContractDate = table.Column<DateTime>(type: "timestamp with time zone", nullable: false),
                    ContractNumber = table.Column<string>(type: "text", nullable: true),
                    NaceCodeId = table.Column<int>(type: "integer", nullable: true),
                    JobSecuritySpecialistNationalID = table.Column<string>(type: "text", nullable: true),
                    OccupationalPhysicanNationalID = table.Column<string>(type: "text", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Companies", x => x.CompanyID);
                    table.ForeignKey(
                        name: "FK_Companies_NaceCodes_NaceCodeId",
                        column: x => x.NaceCodeId,
                        principalTable: "NaceCodes",
                        principalColumn: "NaceCodeId");
                    table.ForeignKey(
                        name: "FK_Companies_OHSEmployees_JobSecuritySpecialistNationalID",
                        column: x => x.JobSecuritySpecialistNationalID,
                        principalTable: "OHSEmployees",
                        principalColumn: "NationalID");
                    table.ForeignKey(
                        name: "FK_Companies_OHSEmployees_OccupationalPhysicanNationalID",
                        column: x => x.OccupationalPhysicanNationalID,
                        principalTable: "OHSEmployees",
                        principalColumn: "NationalID");
                });

            migrationBuilder.CreateTable(
                name: "HealthObservations",
                columns: table => new
                {
                    HealthObservationId = table.Column<Guid>(type: "uuid", nullable: false),
                    WorkplacePhysicanNationalID = table.Column<string>(type: "text", nullable: true),
                    EmployeeNationalID = table.Column<string>(type: "text", nullable: true),
                    ObservationDate = table.Column<DateTime>(type: "timestamp with time zone", nullable: false),
                    NextObservationDate = table.Column<DateTime>(type: "timestamp with time zone", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_HealthObservations", x => x.HealthObservationId);
                    table.ForeignKey(
                        name: "FK_HealthObservations_Employee_EmployeeNationalID",
                        column: x => x.EmployeeNationalID,
                        principalTable: "Employee",
                        principalColumn: "NationalID");
                    table.ForeignKey(
                        name: "FK_HealthObservations_OHSEmployees_WorkplacePhysicanNationalID",
                        column: x => x.WorkplacePhysicanNationalID,
                        principalTable: "OHSEmployees",
                        principalColumn: "NationalID");
                });

            migrationBuilder.CreateTable(
                name: "Bills",
                columns: table => new
                {
                    BillId = table.Column<Guid>(type: "uuid", nullable: false),
                    CompanyID = table.Column<string>(type: "text", nullable: true),
                    BillDate = table.Column<DateTime>(type: "timestamp with time zone", nullable: false),
                    Reason = table.Column<string>(type: "text", nullable: true),
                    ReasonId = table.Column<Guid>(type: "uuid", nullable: false),
                    Explanation = table.Column<string>(type: "text", nullable: true),
                    BillSum = table.Column<decimal>(type: "numeric", nullable: false),
                    CreationDate = table.Column<DateTime>(type: "timestamp with time zone", nullable: false),
                    UpdateDate = table.Column<DateTime>(type: "timestamp with time zone", nullable: false),
                    IsDeleted = table.Column<bool>(type: "boolean", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Bills", x => x.BillId);
                    table.ForeignKey(
                        name: "FK_Bills_Companies_CompanyID",
                        column: x => x.CompanyID,
                        principalTable: "Companies",
                        principalColumn: "CompanyID");
                });

            migrationBuilder.CreateTable(
                name: "contactEmployees",
                columns: table => new
                {
                    NationalID = table.Column<string>(type: "text", nullable: false),
                    CompanyID = table.Column<string>(type: "text", nullable: true),
                    CreationDate = table.Column<DateTime>(type: "timestamp with time zone", nullable: false),
                    UpdateDate = table.Column<DateTime>(type: "timestamp with time zone", nullable: false),
                    IsDeleted = table.Column<bool>(type: "boolean", nullable: false),
                    NameSurname = table.Column<string>(type: "text", nullable: true),
                    MobilePhone = table.Column<string>(type: "text", nullable: true),
                    Email = table.Column<string>(type: "text", nullable: true),
                    OccupationId = table.Column<int>(type: "integer", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_contactEmployees", x => x.NationalID);
                    table.ForeignKey(
                        name: "FK_contactEmployees_Companies_CompanyID",
                        column: x => x.CompanyID,
                        principalTable: "Companies",
                        principalColumn: "CompanyID");
                    table.ForeignKey(
                        name: "FK_contactEmployees_Occupations_OccupationId",
                        column: x => x.OccupationId,
                        principalTable: "Occupations",
                        principalColumn: "OccupationId");
                });

            migrationBuilder.CreateTable(
                name: "EmployeeCompanies",
                columns: table => new
                {
                    EmployeeCompanyId = table.Column<int>(type: "integer", nullable: false)
                        .Annotation("Npgsql:ValueGenerationStrategy", NpgsqlValueGenerationStrategy.IdentityByDefaultColumn),
                    EmployeeNationalID = table.Column<string>(type: "text", nullable: true),
                    CompanyID = table.Column<string>(type: "text", nullable: true),
                    StartDate = table.Column<DateTime>(type: "timestamp with time zone", nullable: false),
                    QuitDate = table.Column<DateTime>(type: "timestamp with time zone", nullable: false),
                    OccupationId = table.Column<int>(type: "integer", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_EmployeeCompanies", x => x.EmployeeCompanyId);
                    table.ForeignKey(
                        name: "FK_EmployeeCompanies_Companies_CompanyID",
                        column: x => x.CompanyID,
                        principalTable: "Companies",
                        principalColumn: "CompanyID");
                    table.ForeignKey(
                        name: "FK_EmployeeCompanies_Employee_EmployeeNationalID",
                        column: x => x.EmployeeNationalID,
                        principalTable: "Employee",
                        principalColumn: "NationalID");
                    table.ForeignKey(
                        name: "FK_EmployeeCompanies_Occupations_OccupationId",
                        column: x => x.OccupationId,
                        principalTable: "Occupations",
                        principalColumn: "OccupationId");
                });

            migrationBuilder.CreateTable(
                name: "OccupationalSafetyEducations",
                columns: table => new
                {
                    OccupationalSafetyEducationID = table.Column<Guid>(type: "uuid", nullable: false),
                    InstructureNationalID = table.Column<string>(type: "text", nullable: true),
                    CompanyID = table.Column<string>(type: "text", nullable: true),
                    EducationDate = table.Column<DateTime>(type: "timestamp with time zone", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_OccupationalSafetyEducations", x => x.OccupationalSafetyEducationID);
                    table.ForeignKey(
                        name: "FK_OccupationalSafetyEducations_Companies_CompanyID",
                        column: x => x.CompanyID,
                        principalTable: "Companies",
                        principalColumn: "CompanyID");
                    table.ForeignKey(
                        name: "FK_OccupationalSafetyEducations_OHSEmployees_InstructureNation~",
                        column: x => x.InstructureNationalID,
                        principalTable: "OHSEmployees",
                        principalColumn: "NationalID");
                });

            migrationBuilder.CreateTable(
                name: "RiskAnalyses",
                columns: table => new
                {
                    RiskAnalysisId = table.Column<Guid>(type: "uuid", nullable: false),
                    CompanyID = table.Column<string>(type: "text", nullable: true),
                    AnalyzerNationalID = table.Column<string>(type: "text", nullable: true),
                    AnalysisDate = table.Column<DateTime>(type: "timestamp with time zone", nullable: false),
                    ExpirationDate = table.Column<DateTime>(type: "timestamp with time zone", nullable: false),
                    FixDate = table.Column<DateTime>(type: "timestamp with time zone", nullable: false),
                    Score = table.Column<int>(type: "integer", nullable: false),
                    IsFixed = table.Column<bool>(type: "boolean", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_RiskAnalyses", x => x.RiskAnalysisId);
                    table.ForeignKey(
                        name: "FK_RiskAnalyses_Companies_CompanyID",
                        column: x => x.CompanyID,
                        principalTable: "Companies",
                        principalColumn: "CompanyID");
                    table.ForeignKey(
                        name: "FK_RiskAnalyses_OHSEmployees_AnalyzerNationalID",
                        column: x => x.AnalyzerNationalID,
                        principalTable: "OHSEmployees",
                        principalColumn: "NationalID");
                });

            migrationBuilder.CreateTable(
                name: "EmployeeOSEs",
                columns: table => new
                {
                    EmployeeOSEId = table.Column<int>(type: "integer", nullable: false)
                        .Annotation("Npgsql:ValueGenerationStrategy", NpgsqlValueGenerationStrategy.IdentityByDefaultColumn),
                    EmployeeNationalID = table.Column<string>(type: "text", nullable: true),
                    OccupationalSafetyEducationID = table.Column<Guid>(type: "uuid", nullable: true),
                    PreTestScore = table.Column<int>(type: "integer", nullable: false),
                    TestScore = table.Column<int>(type: "integer", nullable: false),
                    NextEducationDate = table.Column<DateTime>(type: "timestamp with time zone", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_EmployeeOSEs", x => x.EmployeeOSEId);
                    table.ForeignKey(
                        name: "FK_EmployeeOSEs_Employee_EmployeeNationalID",
                        column: x => x.EmployeeNationalID,
                        principalTable: "Employee",
                        principalColumn: "NationalID");
                    table.ForeignKey(
                        name: "FK_EmployeeOSEs_OccupationalSafetyEducations_OccupationalSafet~",
                        column: x => x.OccupationalSafetyEducationID,
                        principalTable: "OccupationalSafetyEducations",
                        principalColumn: "OccupationalSafetyEducationID");
                });

            migrationBuilder.CreateIndex(
                name: "IX_Bills_CompanyID",
                table: "Bills",
                column: "CompanyID");

            migrationBuilder.CreateIndex(
                name: "IX_Companies_JobSecuritySpecialistNationalID",
                table: "Companies",
                column: "JobSecuritySpecialistNationalID");

            migrationBuilder.CreateIndex(
                name: "IX_Companies_NaceCodeId",
                table: "Companies",
                column: "NaceCodeId");

            migrationBuilder.CreateIndex(
                name: "IX_Companies_OccupationalPhysicanNationalID",
                table: "Companies",
                column: "OccupationalPhysicanNationalID");

            migrationBuilder.CreateIndex(
                name: "IX_contactEmployees_CompanyID",
                table: "contactEmployees",
                column: "CompanyID");

            migrationBuilder.CreateIndex(
                name: "IX_contactEmployees_OccupationId",
                table: "contactEmployees",
                column: "OccupationId");

            migrationBuilder.CreateIndex(
                name: "IX_Employee_EducationId",
                table: "Employee",
                column: "EducationId");

            migrationBuilder.CreateIndex(
                name: "IX_Employee_OccupationId",
                table: "Employee",
                column: "OccupationId");

            migrationBuilder.CreateIndex(
                name: "IX_EmployeeCompanies_CompanyID",
                table: "EmployeeCompanies",
                column: "CompanyID");

            migrationBuilder.CreateIndex(
                name: "IX_EmployeeCompanies_EmployeeNationalID",
                table: "EmployeeCompanies",
                column: "EmployeeNationalID");

            migrationBuilder.CreateIndex(
                name: "IX_EmployeeCompanies_OccupationId",
                table: "EmployeeCompanies",
                column: "OccupationId");

            migrationBuilder.CreateIndex(
                name: "IX_EmployeeOSEs_EmployeeNationalID",
                table: "EmployeeOSEs",
                column: "EmployeeNationalID");

            migrationBuilder.CreateIndex(
                name: "IX_EmployeeOSEs_OccupationalSafetyEducationID",
                table: "EmployeeOSEs",
                column: "OccupationalSafetyEducationID");

            migrationBuilder.CreateIndex(
                name: "IX_HealthObservations_EmployeeNationalID",
                table: "HealthObservations",
                column: "EmployeeNationalID");

            migrationBuilder.CreateIndex(
                name: "IX_HealthObservations_WorkplacePhysicanNationalID",
                table: "HealthObservations",
                column: "WorkplacePhysicanNationalID");

            migrationBuilder.CreateIndex(
                name: "IX_NaceCodes_DangerLevelId",
                table: "NaceCodes",
                column: "DangerLevelId");

            migrationBuilder.CreateIndex(
                name: "IX_OccupationalSafetyEducations_CompanyID",
                table: "OccupationalSafetyEducations",
                column: "CompanyID");

            migrationBuilder.CreateIndex(
                name: "IX_OccupationalSafetyEducations_InstructureNationalID",
                table: "OccupationalSafetyEducations",
                column: "InstructureNationalID");

            migrationBuilder.CreateIndex(
                name: "IX_OHSEmployees_OccupationId",
                table: "OHSEmployees",
                column: "OccupationId");

            migrationBuilder.CreateIndex(
                name: "IX_OHSEmployees_UserRoleId",
                table: "OHSEmployees",
                column: "UserRoleId");

            migrationBuilder.CreateIndex(
                name: "IX_RiskAnalyses_AnalyzerNationalID",
                table: "RiskAnalyses",
                column: "AnalyzerNationalID");

            migrationBuilder.CreateIndex(
                name: "IX_RiskAnalyses_CompanyID",
                table: "RiskAnalyses",
                column: "CompanyID");

            migrationBuilder.CreateIndex(
                name: "IX_SUTDatas_DangerLevelId",
                table: "SUTDatas",
                column: "DangerLevelId");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Bills");

            migrationBuilder.DropTable(
                name: "contactEmployees");

            migrationBuilder.DropTable(
                name: "EmployeeCompanies");

            migrationBuilder.DropTable(
                name: "EmployeeOSEs");

            migrationBuilder.DropTable(
                name: "HealthObservations");

            migrationBuilder.DropTable(
                name: "RiskAnalyses");

            migrationBuilder.DropTable(
                name: "SUTDatas");

            migrationBuilder.DropTable(
                name: "OccupationalSafetyEducations");

            migrationBuilder.DropTable(
                name: "Employee");

            migrationBuilder.DropTable(
                name: "Companies");

            migrationBuilder.DropTable(
                name: "Educations");

            migrationBuilder.DropTable(
                name: "NaceCodes");

            migrationBuilder.DropTable(
                name: "OHSEmployees");

            migrationBuilder.DropTable(
                name: "DangerLevels");

            migrationBuilder.DropTable(
                name: "Occupations");

            migrationBuilder.DropTable(
                name: "UserRoles");
        }
    }
}
