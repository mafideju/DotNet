using System;

namespace OOP
{
    class Calculator
    {
        public void Calculate()
        {
            Console.WriteLine("Digite o primeiro valor");
            double a = double.Parse(Console.ReadLine());

            Console.WriteLine("Insira a operação desejada");
            string op = Console.ReadLine();

            if(op != "+" && op != "-" && op != "*" && op != "x" && op != "/")
            {
                Console.WriteLine("Operação não Permitida");
            }
            else
            {
                Console.WriteLine("Digite o segundo valor");
                double b = double.Parse(Console.ReadLine());

                double result = 0.0;
                string nome = "";

                switch (op)
                {
                    case "+":
                        result = a + b;
                        nome = "soma";
                        break;
                    case "-":
                        result = a - b;
                        nome = "subtração";
                        break;
                    case "*":
                        result = a * b;
                        nome = "multiplicação";
                        break;
                    case "x":
                        result = a * b;
                        nome = "multiplicação";
                        break;
                    case "/":
                        result = a / b;
                        nome = "divisão";
                        break;
                    default:
                        break;
                }
                Console.WriteLine($"A {nome} entre {a} e {b} é igual a {result:N1}");
            }
        }
    }
}           