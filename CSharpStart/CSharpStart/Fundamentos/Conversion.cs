using System;
using System.Collections.Generic;
using System.Text;

namespace CSharpStart.Fundamentos {
    class Conversion {

        public static void Executar() {
            int intValue = 15;
            double crashed = intValue;
            Console.WriteLine(crashed);

            double note = 9.9;
            int noteTrunked = (int) note;
            Console.WriteLine("Nota Truncada: {0}", noteTrunked);

            Console.Write("Digite sua idade: ");
            string age = Console.ReadLine();
            int ageConverted = int.Parse(age);
            Console.WriteLine("Idade atual {0}", ageConverted);

            ageConverted = Convert.ToInt32(age);
            Console.WriteLine("Resultado: {0}", ageConverted);

            Console.Write("Digite um nuumero: ");
            int.TryParse(Console.ReadLine(), out int numeral);
            Console.WriteLine("Resultado: {0}", numeral);
        }
    }
}
