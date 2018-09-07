
using System;
using System.Collections.Generic;
using System.Text;

namespace CSharpStart.Fundamentos {
    class Interpolation {

        public static void Executar() {
            string name = "Notebook Asus ROG";
            var mark = "Asus";
            double price = 12900.99;

            Console.WriteLine("O " + name + " custa" + price);
            Console.WriteLine("O {0} da marca {1}, custa {2}.", name, mark, price);
            Console.WriteLine($"A marca {mark} é boa");
        }
    }
}
