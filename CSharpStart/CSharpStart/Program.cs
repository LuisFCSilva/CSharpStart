using System;
using System.Collections.Generic;
using CSharpStart.Fundamentos;
using CSharpStart.EstruturasDeControle;


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
                {"Operadores Lógicos - Fundamentos", OperatorLogics.Executar },
                {"Operadores de Atribuição - Fundamentos", OperatorAtribuition.Executar },
                {"Operadores Unários - Fundamentos", OperatorUnary.Executar },
                {"Operadores Ternário - Fundamentos", OperatorTernary.Executar },

                { "Estrutura If - Estruturas de Controle", StructureIf.Executar },
                { "Estrutura If e Else - Estruturas de Controle", StructureIfElse.Executar },
                { "Estrutura If e Else IF - Estruturas de Controle", StructureIfElseIf.Executar },
            });

            central.SelecionarEExecutar();
        }
    }
}