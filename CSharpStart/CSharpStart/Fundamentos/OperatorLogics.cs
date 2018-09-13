using System;
using System.Collections.Generic;
using System.Text;

namespace CSharpStart.Fundamentos {
    class OperatorLogics {

        public static void Executar() {

            var executeJobOne = false;
            var executeJobTwo = false;

            var buyTv50 = executeJobOne && executeJobTwo;
            Console.WriteLine("Comprou a TV 50? {0}", buyTv50);

            var buyIceCream = executeJobOne || executeJobTwo;
            Console.WriteLine("Comprou o sorvete? {0}", buyIceCream);

            var buyTv32 = executeJobOne ^ executeJobTwo;
            Console.WriteLine("Comprou a TV 32? {0}", buyTv32);

            Console.WriteLine("Sem sorvete? :( {0}", !buyIceCream);

        }
    }
}
