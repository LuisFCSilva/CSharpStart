using System;
using System.Collections.Generic;
using System.Text;

namespace CSharpStart.Fundamentos {
    class OperatorTernary {

        public static void Executar() {
            var note = 7.0;
            var result = note >= 7.0 ? "Aprovado" : "Reprovado";

            Console.WriteLine("Resultado: {0}", result);
        }
    }
}
