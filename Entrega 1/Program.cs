
int Calificaciones;
string Nombreestudiante;
int Numerocalificaciones;
int promedio = 0;
int Sumacalif = 0;
float Promedio = 0;
string Calificacion;
int Contador = 0;
do
{
    Console.Write("ingrese el nombre del estudiante: ");
    Nombreestudiante = Console.ReadLine();
} while (string.IsNullOrEmpty(Nombreestudiante));

do
{
    Console.Write("Cuantas calificaciones tiene este estudiante ?: ");

} while (!int.TryParse(Console.ReadLine(), out Numerocalificaciones) || Numerocalificaciones < 1 || Numerocalificaciones > 5);

for (int i = 1; i <= Numerocalificaciones; i++)
{
    do
    {
        Console.Write("ingrese las calificaciones: ");

    } while (!int.TryParse(Console.ReadLine(), out Calificaciones) || Calificaciones < 1 || Calificaciones > 10);

Sumacalif += Calificaciones;
Contador++;
}

promedio += Sumacalif / Contador;


//En el primer if no se por que pero no me lo tomaba si no era un else if, asi que hice uno de mas.


if (Promedio >= 11 && promedio < 1)
{
    Calificacion = "imposible";
}


else if (promedio >= 9)
{
    Calificacion = "Exelente";
}
else if (promedio >= 7 && promedio < 9)
{
    Calificacion = "bueno";
}
else if (promedio >= 6 && promedio < 7)
{
    Calificacion = "Regular";
}
else
{
    Calificacion = "Reprobado";
}


Console.WriteLine($"el promedio del alumno {Nombreestudiante} es de {promedio} lo que da una calificacion {Calificacion}");



