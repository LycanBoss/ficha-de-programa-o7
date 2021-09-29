using System;

namespace ficha_de_programação7
{
    class Program
    {
        static void Main(string[] args)
        {
            float numero1, numero2, numero3;
            Console.WriteLine("Qual a altura da escada medida em cm?");
            numero1 = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Qual é a altura dos degrais en cm?");
            numero2 = Convert.ToInt32(Console.ReadLine());
            numero3 = numero1 / numero2;
            Console.WriteLine("A pessoa deverá subir {0} degrais para subir a escada", numero3);
            Console.ReadLine();
        }
    }
}
