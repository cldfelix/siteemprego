using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;
using System;
using System.Collections.Generic;

namespace SiteEmprego.Migrations
{
    public partial class Initial : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Usuario",
                columns: table => new
                {
                    IdUsuario = table.Column<long>(type: "bigint", nullable: false)
                        .Annotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn),
                    Cidade = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    CriadoEm = table.Column<DateTime>(type: "datetime2", nullable: false),
                    Email = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Estado = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Nome = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Password = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    UsuarioAtivo = table.Column<bool>(type: "bit", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Usuario", x => x.IdUsuario);
                });

            migrationBuilder.CreateTable(
                name: "Vaga",
                columns: table => new
                {
                    IdVaga = table.Column<long>(type: "bigint", nullable: false)
                        .Annotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn),
                    Cidade = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    CriadoEm = table.Column<DateTime>(type: "datetime2", nullable: false),
                    Descricao = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Estado = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Salario = table.Column<float>(type: "real", nullable: false),
                    Titulo = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    UsuarioIdUsuario = table.Column<long>(type: "bigint", nullable: true),
                    VagaAtiva = table.Column<bool>(type: "bit", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Vaga", x => x.IdVaga);
                    table.ForeignKey(
                        name: "FK_Vaga_Usuario_UsuarioIdUsuario",
                        column: x => x.UsuarioIdUsuario,
                        principalTable: "Usuario",
                        principalColumn: "IdUsuario",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateTable(
                name: "Candidatura",
                columns: table => new
                {
                    Idcandidatura = table.Column<long>(type: "bigint", nullable: false)
                        .Annotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn),
                    CandidaturaAtiva = table.Column<bool>(type: "bit", nullable: false),
                    CriadoEm = table.Column<DateTime>(type: "datetime2", nullable: false),
                    UsuarioIdUsuario = table.Column<long>(type: "bigint", nullable: true),
                    VagaIdVaga = table.Column<long>(type: "bigint", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Candidatura", x => x.Idcandidatura);
                    table.ForeignKey(
                        name: "FK_Candidatura_Usuario_UsuarioIdUsuario",
                        column: x => x.UsuarioIdUsuario,
                        principalTable: "Usuario",
                        principalColumn: "IdUsuario",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_Candidatura_Vaga_VagaIdVaga",
                        column: x => x.VagaIdVaga,
                        principalTable: "Vaga",
                        principalColumn: "IdVaga",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateIndex(
                name: "IX_Candidatura_UsuarioIdUsuario",
                table: "Candidatura",
                column: "UsuarioIdUsuario");

            migrationBuilder.CreateIndex(
                name: "IX_Candidatura_VagaIdVaga",
                table: "Candidatura",
                column: "VagaIdVaga");

            migrationBuilder.CreateIndex(
                name: "IX_Vaga_UsuarioIdUsuario",
                table: "Vaga",
                column: "UsuarioIdUsuario");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Candidatura");

            migrationBuilder.DropTable(
                name: "Vaga");

            migrationBuilder.DropTable(
                name: "Usuario");
        }
    }
}
