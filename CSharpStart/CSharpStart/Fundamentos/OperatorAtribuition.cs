using System;
using System.Collections.Generic;
using System.Text;

namespace CSharpStart.Fundamentos {
    class OperatorAtribuition {

        public static void Executar() {
            var numOne = 3;
            numOne = 15;
            numOne += 10;
            numOne -= 2;
            numOne *= 3;
            numOne /= 4;

            Console.WriteLine(numOne);

            int a = 1;
            int b = a;

            a++;
            b--;
            ++a;

            Console.WriteLine(a + " " + b);
        }
    }
}
