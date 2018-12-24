using System;
using CoreEscuela.Entidades;

namespace etapa1
{
    class Program
    {
        static void Main(string[] args)
        {
            var escuela = new Escuela("Platzi Academy", 2012,TiposEscuela.PresEscolar,
                        ciudad:"Bogota",pais:"Colombia"); 

            
            var arregloCursos = new Curso[3];
            
            arregloCursos[0] = new Curso(){
                Nombre = "101"

            }; 
            var curso2 = new Curso(){
                Nombre = "201"

            };
            arregloCursos[1]=curso2;

           arregloCursos[2] = new Curso(){
                             Nombre = "301"

                            };                
            Console.WriteLine(escuela);
            System.Console.WriteLine("===============");
            imprimiCursos(arregloCursos);
          
           
        }

        private static void imprimiCursos(Curso[] arregloCursos)
        {
            int contador=0;
            while (contador<arregloCursos.Length)
            {
                Console.WriteLine($"Nombre : {arregloCursos[contador].Nombre}, Id{arregloCursos[contador].UniqueId}");
                contador++;
            }
        }
    }
}
