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
            Console.WriteLine(escuela);
        }
    }
}
