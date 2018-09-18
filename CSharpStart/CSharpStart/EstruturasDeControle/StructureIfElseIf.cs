using System;
using System.Collections.Generic;
using System.Text;

namespace CSharpStart.EstruturasDeControle {
    class StructureIfElseIf {

        public static void Executar() {
            Console.Write("Digite a nota do aluno: ");
            string entry = Console.ReadLine();
            Double.TryParse(entry, out double note);

            if (note >= 9.0) {
                Console.WriteLine("Aprovado. Parabéns!");
            } else if (note >= 7.0) {
                Console.WriteLine("Aprovado.");
            } else if (note >= 5.0) {
                Console.WriteLine("Recuperação.");
            } else {
                Console.WriteLine("Reprovado.");
            }
        }

    }
}
