using System;
using System.Collections.Generic;
using System.Text;

namespace CSharpStart.Fundamentos {
    class NotationPoint {

        public static void Executar() {
            var welcome = "Olá".Insert(3, " Mundo").Replace("Olá", "Bem-Vindo");

            Console.WriteLine(welcome);
            Console.WriteLine(welcome.Length);

            string length = null;

            Console.WriteLine(length?.Length);


        }
    }
}
