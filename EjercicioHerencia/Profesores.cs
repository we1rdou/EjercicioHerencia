class Profesores : Persona
{
    public string departamento { set; get; }
    public Profesores(String depa,String Nombre, String apellidos, int numero, String estado) : base(Nombre, apellidos, numero, estado)
    {
        this.departamento = depa;
    }
    public void imprimir()
    {
        Console.WriteLine("--------------------------------------------");
        Console.WriteLine("    Personal de Profesores");
        Console.WriteLine("");
        Console.WriteLine("Departamento Asignada: " + departamento);
        Console.WriteLine(""); 
        Console.WriteLine("Nombre: " + nombre + " - Apellido: " + apellido);
        Console.WriteLine("Numero de Identificacion: " + numero_identificacion);
        Console.WriteLine("Estado Civil: " + estado_civil);
        Console.WriteLine("");
        opcioness();
        Console.WriteLine("");
        Console.WriteLine("--------------------------------------------");
    }
    public void opcioness()
    {
        String options;
        Console.WriteLine("Opciones alternas:");
        Console.WriteLine("Si desea cambiar el personal utilize Ingrese: 1");
        Console.WriteLine("Si desea cambiar el Estado Civil Ingrese: 2");
        Console.WriteLine("Si desea salir utilize: salir ");
        options = Console.ReadLine();
        cambio(options);
    }
    public void cambio(String cambios)
    {
        switch (cambios.ToString())
        {
            case "1":
                cambio_de_departamento();
                break;
            case "2":
                cambiocivil();
                break;
            case "salir":
                Console.WriteLine("....");
                break;
        }
    }
    public void cambio_de_departamento()
    {
        String departmento_nuevo;
        Console.WriteLine("Ingrese el nuevo departamento");
        departmento_nuevo = Console.ReadLine();
        Console.WriteLine("Departamento cambiado exitosamente");
        departamento = departmento_nuevo;
    }
}