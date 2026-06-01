
Empleado[] empleados = new Empleado[10];

void agregarEmpleado(int pos)
{
    Console.Write("Nombres: ");
    empleados[pos].nombre = Console.ReadLine();
    Console.Write("Apellidos: ");
    empleados[pos].apellido = Console.ReadLine();
    Console.Write("Cargo: ");
    empleados[pos].cargo = Console.ReadLine();
    Console.Write("Salario: ");
    empleados[pos].salario = double.Parse(Console.ReadLine());
    Console.ForegroundColor = ConsoleColor.Green;
    Console.WriteLine("Registro guardado satisfactoriamente ");
    Console.ReadKey();
    Console.ResetColor();
}
void mostrarDatos(int pos)
{
    Console.WriteLine("Mostrar registros");
    for (int i = 0; i < pos; i++)
    {
        Console.WriteLine($"Nombre: {empleados[i].nombre}\nApellidos:{empleados[i].apellido}\nCargo: {empleados[i].cargo}\nSalario: {empleados[i].salario}");
}
    Console.ReadKey();
}

    int menu()
{
    Console.ForegroundColor= ConsoleColor.Green;
    Console.WriteLine("1. Agregar \n2. Mostrar \n3. Guardar \n4. Salir \nDigite su opcion:  ");
    Console.ForegroundColor = ConsoleColor.Blue;
    int op = int.Parse(Console.ReadLine());
    Console.ResetColor();
    return op;
}
void guardarEmpleados(int pos)
{
    StreamWriter archivo = new StreamWriter("C:\\Programacion01-06-26\\empleados.csv");
    for (int i = 0; i < pos; i++)
    {
        archivo.WriteLine($"{empleados[i].nombre}; {empleados[i].apellido}; {empleados[i].cargo}; {empleados[i].salario}");
    }
    archivo.Close();
    Console.WriteLine("Registro guardados.");
    Console.ReadKey();
}

int main()
{
    int op = 0, i = 0;

    do
    {
        Console.WriteLine($"Registro: {i + 1}");
        op = menu();
        switch (op)
        {
            case 1:
                agregarEmpleado(i++);
                break;
            case 2:
                mostrarDatos(i);
                break;
            case 3:
                guardarEmpleados(i);
                break;

                default:
                Console.WriteLine("Opcion no valida...");
                break;
        }
    } while (op != 4);

    return 0;
}

main();
struct Empleado
{
    public string nombre ;
    public string apellido ;
    public string cargo ;
    public double salario ;
}