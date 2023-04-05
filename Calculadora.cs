using System;
using System.IO;

class Calculadora

{

    static void Main()

    {
        double num1, num2;

        int resul = 0;

        Console.WriteLine(" Digite um valor: ");
        num1 = double.Parse(Console.ReadLine());
        Console.WriteLine(" Digite outro valor: ");
        num2 = double.Parse(Console.ReadLine());

        Console.Clear();

        while (resul != 5)

        {
            Console.WriteLine(" Somar 1 ");
            Console.WriteLine(" Subtrair 2 ");
            Console.WriteLine(" Dividir 3 ");
            Console.WriteLine(" Multiplicar 4 ");
            Console.WriteLine(" Sair da Calculadora 5 ");

            resul = int.Parse(Console.ReadLine());

            if (resul == 1)

            {
                Console.WriteLine("Somar = {0}", num1 + num2);
            }

            if (resul == 2)

            {
                Console.WriteLine("Subtrair = {0}", num1 - num2);
            }

            if (resul == 3)

            {
                Console.WriteLine("Dividir = {0}", num1 / num2);
            }

            if (resul == 4)

            {
                Console.WriteLine("Multiplicar = {0}", num1 * num2);
            }

            Console.ReadLine();
            Console.Clear();

        }

    }

}