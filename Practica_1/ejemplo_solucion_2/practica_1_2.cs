// Practica_1_2.cs
// Gestion de becas de estudio para un grupo de 10 alumnos segun su nota

using System;

class Practica_1_2
{
    static void Main()
    {
        int notaMinima;
        int notaAlumno;
        int candidatosBeca = 0;

        // Pedir y comprobar la nota minima requerida entre 5 y 10
        do
        {
            Console.Write("Dime la nota mínima para la beca (5-10): ");
            notaMinima = Convert.ToInt32(Console.ReadLine());
        }
        while (notaMinima < 5 || notaMinima > 10);

        // Bucle for para procesar a los 10 alumnos del 1 al 10
        for (int i = 1; i <= 10; i++)
        {
            Console.Write("Nota del alumno {0}: ", i);
            notaAlumno = Convert.ToInt32(Console.ReadLine());

            // Comprobar si el alumno califica para la beca
            if (notaAlumno >= notaMinima)
            {
                Console.WriteLine("Alumno {0}: Candidato a beca", i);
                candidatosBeca++;
            }
        }

        // Mensaje final si 6 o mas de la mitad resultaron candidatos 
        if (candidatosBeca >= 6)
        {
            Console.WriteLine("Cupo de becas superado");
        }
    }
}
