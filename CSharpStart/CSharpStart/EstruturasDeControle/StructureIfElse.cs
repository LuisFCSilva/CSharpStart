using System;
using System.Collections.Generic;
using System.Text;

namespace CSharpStart.EstruturasDeControle {
    class StructureIfElse {

        public static void Executar() {
            double note = 7.0;

            if (note >= 7.0) {
                Console.WriteLine("Aprovado/Na Média.");
            } else {
                Console.WriteLine("De Recuperação");
            }
        }
    }
}
