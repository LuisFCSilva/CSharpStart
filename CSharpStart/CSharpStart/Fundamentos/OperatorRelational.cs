using System;
using System.Collections.Generic;
using System.Text;

namespace CSharpStart.Fundamentos {
    class OperatorRelational {

        public static void Executar() {
            Console.Write("Digite sua nota: ");
            double.TryParse(Console.ReadLine(), out double note);
            double noteCut = 5.0;

            Console.WriteLine("Nota Invalida? {0}", note > 10.0);
            Console.WriteLine("Nota Invalida? {0}", note < 0.0);
            Console.WriteLine("Nota 10? {0}", note == 10.0);
            Console.WriteLine("Nota Abaixo esperado? {0}", note != 10.0);
            Console.WriteLine("Nota na média? {0}", note >= noteCut);
            Console.WriteLine("Em Recuperação? {0}", note >= 3.0 && note < noteCut);
            Console.WriteLine("Reprovado direto? {0}", note < 3.0);

        }
    }
}
