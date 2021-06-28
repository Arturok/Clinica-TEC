using Microsoft.EntityFrameworkCore.Migrations;

namespace Health_Tec.Migrations
{
    public partial class DbSeed : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.Sql("insert into Estados (Nombre) values ('Sano')");
            migrationBuilder.Sql("insert into Estados (Nombre) values ('Contagiado')");
            migrationBuilder.Sql("insert into Estados (Nombre) values ('Recuperado')");

            migrationBuilder.Sql("insert into Clinicas (Id, Nombre, Provincia, Canton, Distrito, Otros, Telefono, Correo, SitioWeb, DiaInicio, DiaFinal, HoraInicio, HoraCierre) values ('C1', 'Clinica1', 'Provincia1', 'Canton1', 'Distrito1', 'Otros1', 88888888, 'correo1@c1.com', 'Sitio1', 'Lunes', 'Sábado', '7:00am', '4:00pm')");
            migrationBuilder.Sql("insert into Clinicas (Id, Nombre, Provincia, Canton, Distrito, Otros, Telefono, Correo, SitioWeb, DiaInicio, DiaFinal, HoraInicio, HoraCierre) values ('C2', 'Clinica2', 'Provincia2', 'Canton2', 'Distrito3', 'Otros2', 88888888, 'correo2@c2.com', 'Sitio2', 'Lunes', 'Sábado', '7:00am', '4:00pm')");
            migrationBuilder.Sql("insert into Clinicas (Id, Nombre, Provincia, Canton, Distrito, Otros, Telefono, Correo, SitioWeb, DiaInicio, DiaFinal, HoraInicio, HoraCierre) values ('C3', 'Clinica3', 'Provincia3', 'Canton3', 'Distrito3', 'Otros3', 88888888, 'correo3@c3.com', 'Sitio3', 'Lunes', 'Sábado', '7:00am', '4:00pm')");

            migrationBuilder.Sql("insert into Medicos (Id, Cedula, Nombre, Apellido1, Apellido2, Especialidad, Estado) values ('M1', 111111111, 'Nombre1', 'Apellido11', 'Apellido21', 'Especialidad1', 0)");
            migrationBuilder.Sql("insert into Medicos (Id, Cedula, Nombre, Apellido1, Apellido2, Especialidad, Estado) values ('M2', 222222222, 'Nombre2', 'Apellido12', 'Apellido22', 'Especialidad2', 1)");
            migrationBuilder.Sql("insert into Medicos (Id, Cedula, Nombre, Apellido1, Apellido2, Especialidad, Estado) values ('M3', 333333333, 'Nombre3', 'Apellido13', 'Apellido23', 'Especialidad3', 0)");

            migrationBuilder.Sql("insert into ClinicaMedico (ClinicasId, MedicosId) values ((select Id from Clinicas where Nombre = 'Clinica1'), (select Id from Medicos where Nombre = 'Nombre1'))");
            migrationBuilder.Sql("insert into ClinicaMedico (ClinicasId, MedicosId) values ((select Id from Clinicas where Nombre = 'Clinica2'), (select Id from Medicos where Nombre = 'Nombre2'))");
            migrationBuilder.Sql("insert into ClinicaMedico (ClinicasId, MedicosId) values ((select Id from Clinicas where Nombre = 'Clinica2'), (select Id from Medicos where Nombre = 'Nombre3'))");

            migrationBuilder.Sql("insert into Pacientes values ('111111111', 'NombreP1', 'Apellido1P1', 'Apellido2P1', 'Provincia1', 'Canton1', 'Distrito1', 'Otros1', 'Correo1', GETDATE(),'TipoSangre1', (select Id From Estados where Nombre='Sano'))");
            migrationBuilder.Sql("insert into Pacientes values ('333333333', 'NombreP2', 'Apellido1P2', 'Apellido2P2', 'Provincia2', 'Canton2', 'Distrito2', 'Otros2', 'Correo2', GETDATE(),'TipoSangre2', (select Id From Estados where Nombre='Contagiado'))");
            migrationBuilder.Sql("insert into Pacientes values ('CO1234567', 'NombreP3', 'Apellido1P3', 'Apellido2P3', 'Provincia3', 'Canton3', 'Distrito3', 'Otros3', 'Correo3', GETDATE(),'TipoSangre3', (select Id From Estados where Nombre='Recuperado'))");

            migrationBuilder.Sql("insert into MedicoPaciente values ('M1', '111111111')");
            migrationBuilder.Sql("insert into MedicoPaciente values ('M2', 'CO1234567')");
            migrationBuilder.Sql("insert into MedicoPaciente values ('M2', '333333333')");

            migrationBuilder.Sql("insert into ClinicaPaciente values ('C1', '111111111')");
            migrationBuilder.Sql("insert into ClinicaPaciente values ('C2', 'CO1234567')");
            migrationBuilder.Sql("insert into ClinicaPaciente values ('C2', '333333333')");

            



        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.Sql("delete from Estados where Nombre in ('Sano', 'Contagiado', 'Recuperado')");

        }
    }
}