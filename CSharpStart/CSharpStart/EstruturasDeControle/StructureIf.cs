using System;
using System.Collections.Generic;
using System.Text;

namespace CSharpStart.EstruturasDeControle {
    class StructureIf {

        public static void Executar() {

            bool goodCompartament = false;
            string entry;

            Console.Write("Informe a nota do aluno: ");
            entry = Console.ReadLine();
            Double.TryParse(entry, out double note);

            Console.Write("Possui bom comportamento: ");
            entry = Console.ReadLine();

            //if (entry == "S" || entry == "s") {
            //    goodCompartament = true;
            //}

            // goodCompartament = entry == "S" || entry == "s";
            goodCompartament = entry.ToLower() == "s";

            if (note >= 9.9 && goodCompartament) {
                Console.WriteLine("Ok! Aprovado.");
            }

        }

    }
}
