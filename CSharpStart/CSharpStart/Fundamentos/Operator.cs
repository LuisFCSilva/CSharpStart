using System;
using System.Collections.Generic;
using System.Text;

namespace CSharpStart.Fundamentos {
    class Operator {

        public static void Executar() {
            //Calculando preços, impostos e descontos
            var price = 1000;
            var impost = 355;
            var descount = 0.1;

            double total = price + impost;
            var totalWithDescount = total - (total * descount);
            Console.WriteLine("O preço final é: {0}", totalWithDescount);

            // IMC = Índice de Massa Corporal
            double height = 72.8;
            double width = 1.76;
            double imc = height / Math.Pow(width, 2);
            Console.WriteLine($"Seu IMC é {imc}");

            //Verificar Par ou Impar
            Console.Write("Informe um número: ");
            var value = Console.ReadLine();
            int.TryParse(value, out int number);

            if (number % 2 == 1) {
                Console.WriteLine("O numero {0} é impar!", number);
            } else {
                Console.WriteLine("O numero {0} é par!", number);
            }


        }
    }
}
