using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace BIManager.Migrations
{
    /// <inheritdoc />
    public partial class InitialCreate : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Consulta",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Nome = table.Column<string>(type: "NVARCHAR(80)", maxLength: 80, nullable: false),
                    ConsultaSQL = table.Column<string>(type: "NVARCHAR(MAX)", nullable: false),
                    CompativelComPeriodo = table.Column<bool>(type: "BIT", nullable: false, defaultValue: false),
                    ChaveEixoYDoGrafico = table.Column<string>(type: "NVARCHAR(80)", maxLength: 80, nullable: true),
                    ChaveEixoXDoGrafico = table.Column<string>(type: "NVARCHAR(80)", maxLength: 80, nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Consulta", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "Funcao",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Nome = table.Column<string>(type: "NVARCHAR(30)", maxLength: 30, nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Funcao", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "Usuario",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    NomeUsuario = table.Column<string>(type: "NVARCHAR(80)", maxLength: 80, nullable: false),
                    Email = table.Column<string>(type: "NVARCHAR(120)", maxLength: 120, nullable: false),
                    Senha = table.Column<string>(type: "NVARCHAR(30)", maxLength: 30, nullable: false),
                    FuncaoId = table.Column<int>(type: "int", nullable: true),
                    SenhaAleatoria = table.Column<bool>(type: "BIT", nullable: false),
                    CriadoEm = table.Column<DateTime>(type: "SMALLDATETIME", nullable: false, defaultValueSql: "GETUTCDATE()"),
                    AtualizadoEm = table.Column<DateTime>(type: "SMALLDATETIME", nullable: false, defaultValueSql: "GETUTCDATE()")
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Usuario", x => x.Id);
                    table.ForeignKey(
                        name: "FUNCAO_USUARIO",
                        column: x => x.FuncaoId,
                        principalTable: "Funcao",
                        principalColumn: "Id");
                });

            migrationBuilder.CreateTable(
                name: "BaseDeDados",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Nome = table.Column<string>(type: "NVARCHAR(80)", maxLength: 80, nullable: false),
                    UrlConexao = table.Column<string>(type: "NVARCHAR(255)", maxLength: 255, nullable: false),
                    UsuarioId = table.Column<int>(type: "int", nullable: true),
                    CriadoEm = table.Column<DateTime>(type: "SMALLDATETIME", nullable: true, defaultValueSql: "GETUTCDATE()"),
                    AtualizadoEm = table.Column<DateTime>(type: "SMALLDATETIME", nullable: true, defaultValueSql: "GETUTCDATE()")
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_BaseDeDados", x => x.Id);
                    table.ForeignKey(
                        name: "USUARIO_BASES_DE_DADOS",
                        column: x => x.UsuarioId,
                        principalTable: "Usuario",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "Consultas_BaseDeDados",
                columns: table => new
                {
                    BaseDeDadosId = table.Column<int>(type: "int", nullable: false),
                    ConsultaID = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Consultas_BaseDeDados", x => new { x.BaseDeDadosId, x.ConsultaID });
                    table.ForeignKey(
                        name: "BASEDEDADOS_CONSULTA",
                        column: x => x.BaseDeDadosId,
                        principalTable: "Consulta",
                        principalColumn: "Id");
                    table.ForeignKey(
                        name: "CONSULTA_BASEDEDADOS",
                        column: x => x.ConsultaID,
                        principalTable: "BaseDeDados",
                        principalColumn: "Id");
                });

            migrationBuilder.CreateIndex(
                name: "INDEX_BASEDEDADOS_URLCONEXAO",
                table: "BaseDeDados",
                column: "UrlConexao",
                unique: true);

            migrationBuilder.CreateIndex(
                name: "IX_BaseDeDados_UsuarioId",
                table: "BaseDeDados",
                column: "UsuarioId");

            migrationBuilder.CreateIndex(
                name: "IX_Consultas_BaseDeDados_ConsultaID",
                table: "Consultas_BaseDeDados",
                column: "ConsultaID");

            migrationBuilder.CreateIndex(
                name: "INDEX_FUNCAO_NOME",
                table: "Funcao",
                column: "Nome",
                unique: true);

            migrationBuilder.CreateIndex(
                name: "INDEX_USUARIO_EMAIL",
                table: "Usuario",
                column: "Email",
                unique: true);

            migrationBuilder.CreateIndex(
                name: "IX_Usuario_FuncaoId",
                table: "Usuario",
                column: "FuncaoId");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Consultas_BaseDeDados");

            migrationBuilder.DropTable(
                name: "Consulta");

            migrationBuilder.DropTable(
                name: "BaseDeDados");

            migrationBuilder.DropTable(
                name: "Usuario");

            migrationBuilder.DropTable(
                name: "Funcao");
        }
    }
}
