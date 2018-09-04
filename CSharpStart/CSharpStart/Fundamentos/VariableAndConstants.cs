using System;
using System.Collections.Generic;
using System.Text;

namespace CSharpStart.Fundamentos {
    class VariableAndConstants {

        public static void Executar() {
            //area da circunferencia

            double raio = 5.5;
            const double PI = 3.14;

            double area = PI * raio * raio;
            Console.WriteLine("Área é: " + area);

            //tipos internos (primitivos?)
            bool itsRain = true;
            Console.WriteLine("Está chovendo? " + itsRain);

            byte age = 26;
            Console.WriteLine("Idade: " + age);

            sbyte goals = sbyte.MinValue;
            Console.WriteLine("Min: " + goals);

            short band = 182;
            Console.WriteLine("Blink" + band);

            int year = 2018;
            Console.WriteLine("Ano que estamos: " + year);

            uint populationBrazilian = 207_600_00;
            Console.WriteLine("Populaçao: " + populationBrazilian);

            long maxLongNumber = long.MaxValue;
            Console.WriteLine("Max Long: " + maxLongNumber);

            ulong populationWorld = 7_600_000_000;
            Console.WriteLine("População Mundo: " + populationWorld);

            float priceComputer = 1299.00f;
            Console.WriteLine("Valor computador: " + priceComputer);

            double priceOfAppleEnterprise = 1_000_000_000_000.99;
            Console.WriteLine("Valor de Mercado Apple: " + priceComputer);

            decimal distanceBetweenStars = decimal.MaxValue;
            Console.WriteLine("Distancia entre uma estrela:" + distanceBetweenStars);

            char letter = 'A';
            Console.WriteLine("Media Aluno: " + letter);

            string text = "Welcome to C# Lessions";
            Console.WriteLine(text);


        }
    }
}
