class Personal : Persona
{
    public string seccion { set; get; }
    public Personal(String Seccion,String Nombre, String apellidos, int numero, String estado) : base(Nombre, apellidos, numero, estado)
    { 
        this.seccion = Seccion;
    }
    public void imprimir()
    {
        Console.WriteLine("--------------------------------------------");
        Console.WriteLine("    Personal del trabajo");
        Console.WriteLine("");
        Console.WriteLine("Seccion Asignada: "+seccion);
        Console.WriteLine("");
        Console.WriteLine("Nombre: "+nombre+ " - Apellido: "+ apellido);
        Console.WriteLine("Numero de Identificacion: "+ numero_identificacion);
        Console.WriteLine("Estado Civil: "+ estado_civil);
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
                cambio_de_personal();
                break;
            case "2":
                cambiocivil();
                break;
            case "salir":
                Console.WriteLine("....");
                break;
        }
    }
    public void cambio_de_personal()
    {
        String translado_nuevo;
        Console.WriteLine("Ingrese el nuevo translado de seccion");
        translado_nuevo = Console.ReadLine();
        Console.WriteLine("seccion cambiado exitosamente");
        seccion = translado_nuevo;
    }
}