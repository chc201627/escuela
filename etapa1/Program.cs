using System;
using System.Collections.Generic;
using CoreEscuela.Entidades;
using CoreEscuela.Util;
using static System.Console;

namespace CoreEscuela
{
    class Program
    {
        static void Main(string[] args)
        {
            var engine = new EscuelaEngine();
            engine.Inicializar();

            Printer.DibujarLinea();
            Printer.DibujarLinea(20);
            
            imprimirCursosEscuela(engine.Escuela);



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

      
    }
}

