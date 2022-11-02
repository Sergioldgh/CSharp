int cantidadDeNotasACargo = 0;
double promediodeNotas = 0;
double sumaDeNotas = 0;

Console.WriteLine("Ingresa la cantidad de notas a cargar: ");
cantidadDeNotasACargo = int.Parse(Console.ReadLine());

for (int i = 1; i<=cantidadDeNotasACargo; i++)
{
    Console.WriteLine("Ingrese una nota: ");
    double nota = double.Parse(Console.ReadLine());
    sumaDeNotas = sumaDeNotas + nota;
}

promediodeNotas = sumaDeNotas / cantidadDeNotasACargo;
Console.WriteLine("El promedio de las notas cargadas es de {0}", promediodeNotas);
