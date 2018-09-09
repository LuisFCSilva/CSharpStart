using System;
using System.Collections.Generic;
using System.Text;
using System.Globalization;

namespace CSharpStart.Fundamentos {
    class ReadData {

        public static void Executar() {
            Console.Write("Qual o seu nome? ");
            string name = Console.ReadLine();

            Console.Write("Qual a sua idade? ");
            int age = int.Parse(Console.ReadLine());

            Console.Write("Qual você ganha? ");
            double salary = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);

            Console.WriteLine($"{name}, {age}, R${salary}");

        }
    }
}
