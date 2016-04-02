using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BasicCaculator
{
    class Program
    {
        static void Main(string[] args)
        {
            // Introdução
            Console.WriteLine("Calcuradora Básica");
            Console.WriteLine("..................");
            Console.WriteLine(" ");
            Console.Write("Digite um número: ");
            double x = Convert.ToDouble(Console.ReadLine());
            Console.WriteLine(" ");
            Console.WriteLine("O que quer fazer?");
            Console.WriteLine(" ");
            Console.WriteLine("+ - adicionar");
            Console.WriteLine("- - subtrair");
            Console.WriteLine("x - multiplicar");
            Console.WriteLine("/ - dividir");
            Console.WriteLine(" ");
            string z = (Console.ReadLine());
            Console.Write("Digite o número y: ");
            double y = Convert.ToDouble(Console.ReadLine());
            switch (z)
            {
                case "+":
                    if (y == 0)
                    {
                        Console.WriteLine(" ");
                        Console.WriteLine("Vai dar em nada. Você continua com seus míseros R${0}", x);
                        Console.WriteLine(" ");
                    }
                    else
                    {
                        Console.WriteLine("---------------");
                        Console.WriteLine("SCORE: {0}", x);
                        Console.WriteLine("PERFECT BONUS: {0}", y);
                        Console.WriteLine("TOTAL: {0}", x + y);
                        Console.WriteLine("YOU WIN!");
                        Console.WriteLine("---------------");
                    }
                    break;
                case "-":
                    if (y == 0)
                    {
                        Console.WriteLine(" ");
                        Console.WriteLine("Esse cálculo é mais inútil que botão de Atualizar Software em Samsung");
                        Console.WriteLine(" ");
                    }
                    else
                    {
                        Console.WriteLine(" ");
                        Console.WriteLine("Está feliz em ter tomado dele R${0}? Você pensou na família dele?", y);
                        Console.WriteLine("Agora ele só tem R${0}", x - y);
                        Console.WriteLine(" ");
                    }
                    break;
                case "x":
                    if (y == 0)
                    {
                        Console.WriteLine(" ");
                        Console.WriteLine("Como assim você quer multiplicar por nada? Não terá nada!");
                        Console.WriteLine(" ");
                    }
                    else
                    {
                        Console.WriteLine(" ");
                        Console.WriteLine("O milagre da multiplicação deu {0}", x * y);
                        Console.WriteLine(" ");
                    }
                    break;
                case "/":
                    if (y == 0)
                    {
                        Console.WriteLine(" ");
                        Console.WriteLine("Se divide por 0, com quem divide?");
                        Console.WriteLine(" ");
                    }
                    else
                    {
                        Console.WriteLine(" ");
                        Console.WriteLine("A divisão resultou em {0}", x / y);
                        Console.WriteLine(" ");
                    }
                    break;
            } 
        }
    }
}
