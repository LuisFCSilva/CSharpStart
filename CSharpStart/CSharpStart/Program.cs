using System;
using System.Collections.Generic;
using CSharpStart.Fundamentos;


namespace CursoCSharp {
    class Program {
        static void Main(string[] args) {
            var central = new CentralDeExercicios(new Dictionary<string, Action>() {
                {"Primeiro Programa - Fundamentos", FirstProgram.Executar},
                {"Comentários - Fundamentos", Comentary.Executar },
                {"Variaveis e Constantes - Fundamentos", VariableAndConstants.Executar },
                {"Inferência - Fundamentos", Inference.Executar },
                {"Interpolação - Fundamentos", Interpolation.Executar },
                {"Notação Ponto - Fundamentos", NotationPoint.Executar },
                {"Lendo Dados - Fundamentos", ReadData.Executar },
                {"Formatando Numeros - Fundamentos", NumberFormat.Executar },
                {"Conversões - Fundamentos", Conversion.Executar },
                {"Operadores Aritmeticos - Fundamentos", Operator.Executar },
                {"Operadores Relacionais - Fundamentos", OperatorRelational.Executar },
            });

            central.SelecionarEExecutar();
        }
    }
}