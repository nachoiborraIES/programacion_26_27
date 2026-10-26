/* Programa que le pide al usuario la nota para una beca hasta que el número
 * sea un valor válido, después pide la nota de 10 alumnos, las imprime,
 * y finalmente comprueba si se supera el máximo de alumnos becados.*/
using System;

class Ejercicio
{
    static void Main()
    {
        int notaBeca, notaAlumno, alumno, contadorAlumnos = 0;
        
        do
        {
            Console.WriteLine("Dime la nota mínima para la beca (5-10):");
            notaBeca = Convert.ToInt32(Console.ReadLine());
        }
        
        while(notaBeca < 5 || notaBeca > 10);
        
        Console.WriteLine("Escribe las notas de los alumnos:");
        for (alumno = 1; alumno <= 10; alumno++)
        {
            Console.WriteLine("Nota del alumno " + alumno + ":");
            notaAlumno = Convert.ToInt32(Console.ReadLine());
            if (notaAlumno >= notaBeca)
            {
                Console.WriteLine("Alumno {0}: candidato a la beca", alumno);
                contadorAlumnos++;
            }
        }
        
        if (contadorAlumnos > 5)
        {
            Console.WriteLine("Cupo de becas superado");
        }
    }
}
