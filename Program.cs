using System;
using System.Collections.Generic;
using System.Linq;

namespace VacunacionAlumnos
{
    class Program
    {
        static void Main(string[] args)
        {
            // Conjunto de todos los alumnos (500)
            HashSet<string> todos = new HashSet<string>();
            for (int i = 1; i <= 500; i++)
            {
                todos.Add("Alumno " + i);
            }

            // Conjuntos de alumnos vacunados
            HashSet<string> pfizer = new HashSet<string>();
            HashSet<string> astrazeneca = new HashSet<string>();

            // Agregar 75 alumnos a Pfizer
            for (int i = 1; i <= 75; i++)
            {
                pfizer.Add("Alumno " + i);
            }

            // Agregar 75 alumnos a AstraZeneca (25 se solapan con Pfizer)
            for (int i = 50; i < 125; i++)
            {
                astrazeneca.Add("Alumno " + i);
            }

            // ---------------------------
            // Operaciones de teoría de conjuntos
            // ---------------------------

            // No vacunados
            var noVacunados = todos.Except(pfizer.Union(astrazeneca));

            // Ambas dosis (Pfizer y AstraZeneca)
            var ambasDosis = pfizer.Intersect(astrazeneca);

            // Solo Pfizer
            var soloPfizer = pfizer.Except(astrazeneca);

            // Solo AstraZeneca
            var soloAstraZeneca = astrazeneca.Except(pfizer);

            // ---------------------------
            // Mostrar resultados
            // ---------------------------
            Console.WriteLine("=== Alumnos NO vacunados ===");
            foreach (var a in noVacunados)
                Console.WriteLine(a);

            Console.WriteLine("\n=== Alumnos con AMBAS dosis ===");
            foreach (var a in ambasDosis)
                Console.WriteLine(a);

            Console.WriteLine("\n=== Alumnos SOLO Pfizer ===");
            foreach (var a in soloPfizer)
                Console.WriteLine(a);

            Console.WriteLine("\n=== Alumnos SOLO AstraZeneca ===");
            foreach (var a in soloAstraZeneca)
                Console.WriteLine(a);

            Console.WriteLine("\n\nProceso finalizado.");
            Console.ReadKey();
        }
    }
}
