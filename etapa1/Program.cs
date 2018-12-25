using System;
using CoreEscuela.Entidades;
using static System.Console;

namespace etapa1
{
    class Program
    {
        static void Main(string[] args)
        {
            var escuela = new Escuela("Platzi Academy", 2012, TiposEscuela.PresEscolar,
                        ciudad: "Bogota", pais: "Colombia");


            escuela.Cursos = new Curso[] {
                new Curso(){Nombre = "101"},
                 new Curso(){Nombre = "201"},
                new Curso(){Nombre = "301"}
           };
           
            imprimirCursosEscuela(escuela);
        }

        private static void imprimirCursosEscuela(Escuela escuela)
        {
            WriteLine("================");
            WriteLine("Cursos de la Escuela");
            WriteLine("================");
            if (escuela?.Cursos != null)
                {

                    foreach (var curso in escuela.Cursos)
                    {
                        WriteLine($"Nombre : {curso.Nombre}, Id{curso.UniqueId}");
                    }
                
            }

        }

        private static void imprimirCursosWhile(Curso[] arregloCursos)
        {
            int contador = 0;
            while (contador < arregloCursos.Length)
            {
                WriteLine($"Nombre : {arregloCursos[contador].Nombre}, Id{arregloCursos[contador].UniqueId}");
                contador++;
            }
        }

        private static void imprimirCursosFor(Curso[] arregloCursos)
        {

            for (int i = 0; i < arregloCursos.Length; i++)
            {

                WriteLine($"Nombre : {arregloCursos[i].Nombre}, Id{arregloCursos[i].UniqueId}");

            }
        }

        private static void imprimirCursosForEach(Curso[] arregloCursos)
        {

            foreach (var curso in arregloCursos)
            {
                WriteLine($"Nombre : {curso.Nombre}, Id{curso.UniqueId}");
            }
        }
    }
}

