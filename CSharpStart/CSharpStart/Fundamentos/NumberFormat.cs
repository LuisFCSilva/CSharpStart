using System;
using System.Globalization;

namespace CSharpStart.Fundamentos {
    class NumberFormat {

        public static void Executar() {

            double value = 15.785;
            Console.WriteLine(value.ToString("F1")); //arredonda pra cima
            Console.WriteLine(value.ToString("C")); //Currency - Moeda
            Console.WriteLine(value.ToString("P")); //Percentual + multiplica o valor por 100
            Console.WriteLine(value.ToString("#.##")); //Mascara    

            CultureInfo culture = new CultureInfo("pt-BR");
            Console.WriteLine(value.ToString("C3", culture));

            int integer = 1024;
            Console.WriteLine(integer.ToString("D10", culture));

        }
    }
}
