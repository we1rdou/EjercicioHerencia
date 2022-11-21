class Empleados : Persona
{
    public string numero_despacho { set; get; }
    public int anio { set; get; }
    public Empleados(String despacho,int Anio, String Nombre, String apellidos, int numero, String estado) : base(Nombre, apellidos, numero, estado)
    {
        this.numero_despacho = despacho;
        this.anio = Anio;
    }
    public void imprimir()
    {
        Console.WriteLine("--------------------------------------------");
        Console.WriteLine("    Empleados del trabajo");
        Console.WriteLine("");
        Console.WriteLine("Numero de Despacho: " + numero_despacho);
        Console.WriteLine("");
        Console.WriteLine("Año de incorporacion: " + anio);
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
        Console.WriteLine("Si desea cambiar el despacho utilize Ingrese: 1");
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
                cambio_espacho();
                break;
            case "2":
                cambiocivil();
                break;
            case "salir":
                Console.WriteLine("....");
                break;
        }
    }
    public void cambio_espacho()
    {
        String espacho_new;
        Console.WriteLine("Ingrese el nuevo espacho");
        espacho_new = Console.ReadLine();
        Console.WriteLine("espacho cambiado exitosamente");
        numero_despacho = espacho_new;
    }
}