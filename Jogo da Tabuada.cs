using System;
using System.IO;
class Tabuada
{
    public static void Main()
    {
        Console.WriteLine(" JOGUINHO DA TABUADA ");
        Console.WriteLine(" Lembrando que você tera 3 tentativas ");
        Console.WriteLine(" =====================================");

        int erros = 0;
        int acertos = 0;

        // Question 01
        Console.WriteLine(" 1) Quanto que é 8 * 4 ? ");
        int res1 = 32;
        int resUser = int.Parse(Console.ReadLine());
        if (res1 == resUser)
        {
            Console.WriteLine(" Você Acertou!");
            acertos++;
        }
        else
        {
            erros++;
            Console.WriteLine(" Você errou! ");

        }

        // Question 02
        int res2 = 42;
        Console.WriteLine(" 2) Quanto que é 6 * 7 ? ");
        int user = int.Parse(Console.ReadLine());
        if (res2 == user)
        {
            acertos++;
            Console.WriteLine(" Você acertou! ");
        }
        else
        {
            erros++;
            Console.WriteLine("Você errou!");
        }

        // Question 03
        int res3 = 56;
        Console.WriteLine(" 3) Quantos é 7 * 8 ? ");
        int numUser = int.Parse(Console.ReadLine());

        if (res3 == numUser)
        {
            acertos++;
            Console.WriteLine(" Você acertou! ");
        }
        else
        {
            erros++;
            Console.WriteLine(" Você errou! ");
        }

        if (erros == 3)
        {
            Console.WriteLine(" Game Over, Acabou suas tentativas ");
        }
        else
        {

            // Question 04
            int num4 = 48;
            Console.WriteLine(" 4) Quantos é 6 * 8 ? ");
            int numUser4 = int.Parse(Console.ReadLine());

            if (num4 == numUser4)
            {
                Console.WriteLine(" Você acertou! ");
                acertos++;
            }
            else
            {
                erros++;
            }

            if (erros == 3)
            {
                Console.WriteLine(" Você errou! ");
                Console.WriteLine(" Game Over, Acabou suas tentativas ");

            }
            else
            {
                // Question 5
                int num5 = 192;

                Console.WriteLine(" 5) Quantos é 16 * 12 ?");
                int numUser5 = int.Parse(Console.ReadLine());

                if (num5 == numUser5)
                {
                    acertos++;
                    Console.WriteLine(" Você acertou! ");
                }
                else
                {
                    erros++;
                }

                if (erros == 3)
                {
                    Console.WriteLine(" Game Over, Acabou suas tentativas ");
                }


            }

        }
    }
}

