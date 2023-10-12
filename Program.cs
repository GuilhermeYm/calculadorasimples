using System;
using System.Text;
using System.Linq;
using System.Collections.Generic;

namespace Calculadora
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Olá, sejá bem-vindo(a) ao meu programa, no caso uma calculadora feita com C#");
            Console.WriteLine("Qual operação você deseja realizar");
            Console.WriteLine("1 - Adição");
            Console.WriteLine("2 - Subtração");
            Console.WriteLine("3 - Divisão");
            Console.WriteLine("4 - Mutiplicação");

            int operacao = int.Parse(Console.ReadLine());

            Console.WriteLine("Digite o primeiro número: ");
            int numberone = int.Parse(Console.ReadLine());

            Console.WriteLine("Digite o segunda número: ");
            int numbertwo = int.Parse(Console.ReadLine());

            int resultado = 0;

            switch (operacao)
            {
                case 1:
                    {
                        resultado = Adição(numberone, numbertwo); break;
                    }
                case 2:
                    {
                        resultado = Subtração(numberone, numbertwo);
                        break;
                    }
                case 3:
                    {
                        resultado = Divisão(numberone, numbertwo);
                        break;
                    }
                case 4:
                    {
                        resultado = Multiplicação(numberone, numbertwo);
                        break;
                    }
                default: 
                    Console.WriteLine("Não encontrei esse número nas opções");
                    break;
                    
            }
            Console.WriteLine("O resultado da operação é igual à: {0}", resultado);
        }
        public static int Adição(int numberone, int numbertwo)
        {
            int resultado = numberone + numbertwo;

            return resultado;
        }
        public static int Subtração(int numberone, int numbertwo)
        {
            int resultado = numberone - numbertwo;

            return resultado;
        }
        public static int Divisão(int numberone, int numbertwo)
        {
            int resultado = numberone / numbertwo;

            return resultado;
        }
        public static int Multiplicação(int numberone, int numbertwo)
        {
            int resultado = numberone * numbertwo;

            return resultado;
        }
    }
}
