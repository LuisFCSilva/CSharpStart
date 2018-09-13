using System;
using System.Collections.Generic;
using System.Text;

namespace CSharpStart.Fundamentos {
    class OperatorUnary {

        public static void Executar() {
            var negativeValue = -3;
            var numberOne = 2;
            var numberTwo = 3;
            var boolean = true;

            Console.WriteLine(-negativeValue);
            Console.WriteLine(!boolean);

            numberOne++;
            Console.WriteLine(numberOne);

            --numberOne;
            Console.WriteLine(numberOne);

            Console.WriteLine(numberOne++ == --numberTwo);
        }
    }
}
