internal class Program
{
    private static void Main(string[] args)
    {
        Empleados empleados = new Empleados("Bar de comida", 2022, "Ismael", "Prego", 1304598754, "Soltero");
        empleados.imprimir();
        Estudiantes estudiante = new Estudiantes("3A", "Leandro", "Flores", 1316438272, "Soltero");
        estudiante.imprimir();
        Personal personal = new Personal("Secretaria", "Leonor", "Lopez", 1318475121, "Casada");
        personal.imprimir();
        Profesores profesores = new Profesores("Base de datos", "Robert", "Moreira", 1305986423, "viudo");
        profesores.imprimir();
    }
}