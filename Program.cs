using System;

namespace CoreEscuela
{

    class CoreEscuela
    {
        public string nombre;
        public string direccion;
        public int añoFundacion;

        public string ceo;

        public void Timbrar()
        {
            //Todo
            Console.Beep(2000,3000);
        }

    }
    class Program
    {
        static void Main(string[] args)
        {
            var  miEscuela = new CoreEscuela();
            miEscuela.nombre = "Platzi Academy";
            miEscuela.direccion = "Carrera 5 # 34-5";
            miEscuela.añoFundacion  = 2004;
            Console.WriteLine("TIMBRE");
            miEscuela.Timbrar();
            //Console.WriteLine("Hello World!");
        }
    }
}
