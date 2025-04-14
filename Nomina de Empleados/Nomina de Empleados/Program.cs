const decimal salarioMinimo = 1500000;
const int horasMensuales = 160;
decimal valorHora = salarioMinimo / horasMensuales;
int cantidadHorasDomingo = 0;

Console.WriteLine("Ingrese su Nombre: ");
var nombre = Console.ReadLine();

int horasTrabajadas;


while (true)
{
    Console.WriteLine("Ingrese sus horas trabajadas: ");
    var leerHorasTrabajadas = Console.ReadLine();

    if (int.TryParse(leerHorasTrabajadas, out horasTrabajadas))
    {
        if (horasTrabajadas > 630)
        {
            Console.WriteLine(" No puede trabajar más de 630 horas al mes.");
            continue;
        }
        break;
    }
    else
    {
        Console.WriteLine(" Ingrese un número entero válido para las horas trabajadas.");
    }
}

string trabajoDomingo;
while (true)
{
    Console.WriteLine("¿Trabajó el Domingo? SI/NO");
    trabajoDomingo = Console.ReadLine().ToLower();

    if (trabajoDomingo == "si" || trabajoDomingo == "no")
    {
        break;
    }
    else
    {
        Console.WriteLine(" Respuesta no válida. Por favor escriba solo SI o NO.");
    }
}

if (trabajoDomingo == "si")
{
    while (true)
    {
        Console.WriteLine("Cantidad de horas trabajadas el domingo: ");
        var leerHorasDomingo = Console.ReadLine();

        if (int.TryParse(leerHorasDomingo, out cantidadHorasDomingo))
        {
            break;
        }
        else
        {
            Console.WriteLine(" Ingrese un número entero válido para las horas dominicales.");
        }
    }
}

var horasNormales = horasTrabajadas * valorHora;
Console.WriteLine($"TOTA HORAS NORMALES: {horasTrabajadas} X" + $" {valorHora:N0} =" + $" {horasNormales:N0}");

var valorHoraDominicales = cantidadHorasDomingo * valorHora * 2;
Console.WriteLine($"TOTAL HORAS DOMINICALES: {cantidadHorasDomingo} X" + $" {valorHora:N0} =" + $" {valorHoraDominicales:N0}");

var totalApagar = horasNormales + valorHoraDominicales;
Console.WriteLine($"TOTAL A PAGAR = {totalApagar:N0}");

