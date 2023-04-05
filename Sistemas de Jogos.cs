using System;

namespace Projeto_final
{
    class Program
    {

        static void Main(string[] args)
        {
            string linha;
            int numero1;
            int numero2;
            string nome1;
            string nome2;

            //----------------------------------------------

            Console.Write(" --------- FAÇA SEU LOGIN ABAIXO: --------- \n ");
            Console.ForegroundColor = ConsoleColor.Blue;
            Console.Write("\n");
            Console.Write("|  Introduza o número da turma do 1º Player: ");
            linha = Console.ReadLine();
            numero1 = Int32.Parse(linha);

            Console.Write("|  Introduza o nome do aluno 1º Player: ");
            nome1 = Console.ReadLine();
            Console.Write("\n");
            Console.ResetColor();
            Console.Write("\n");
            //--------------------------------------------

            Console.ForegroundColor = ConsoleColor.Red;
            Console.Write("|  Introduza o número da turma do 2º Player: ");
            linha = Console.ReadLine();
            numero2 = Int32.Parse(linha);

            Console.Write("|  Introduza o nome do 2º aluno: ");
            nome2 = Console.ReadLine();
            Console.Write("\n");

            //----------------------------------------------------------

            Console.ResetColor();
            Console.ForegroundColor = ConsoleColor.Blue;
            Console.WriteLine("|  1º Player: " + nome1 + numero1);
            Console.Write("\n");

            Console.ResetColor();
            Console.ForegroundColor = ConsoleColor.Red;
            Console.WriteLine("|  2º Player: " + nome2 + numero2);
            Console.Write("\n");
            Console.ResetColor();
            Console.Write("Digite ENTER para continuar ");
            Console.ReadKey();
            Console.Clear();


            //---------------------------------------------------------------

            
            Console.ResetColor();
            Console.ForegroundColor = ConsoleColor.Gray;
            Console.WriteLine(" ---- LISTA DE JOGOS ----  ");
            Console.ResetColor();
            Console.Write("\n");


            Console.ForegroundColor = ConsoleColor.Yellow;
            Console.WriteLine("1 = FIFA");
            Console.ResetColor();

            Console.ForegroundColor = ConsoleColor.Magenta;
            Console.WriteLine("2 = CALL OF DUTY");
            Console.ResetColor();

            Console.ForegroundColor = ConsoleColor.Cyan;
            Console.WriteLine("3 = STREET FIGHTER V");
            Console.ResetColor();

            Console.ForegroundColor = ConsoleColor.DarkGreen;
            Console.WriteLine("4 = GRAN TURISMO 7");
            Console.ResetColor();

            Console.ForegroundColor = ConsoleColor.DarkBlue;
            Console.WriteLine("5 = NBA 2K23");
            Console.ResetColor();
            Console.Write("\n");
            Console.WriteLine("=================================================");
           
            //--------------------------------------------------

            int njg;
            string jogo1;
            string jogo2;
            string jogo3;
            string jogo4;
            string jogo5;

            Console.ForegroundColor = ConsoleColor.Gray;
            Console.WriteLine("Digite o número correspondente ao jogo, para iniciá-lo: ");
            Console.Write("\n");
            njg = int.Parse(Console.ReadLine());
            Console.ResetColor();

            switch (njg)
            {
                case 1:
                    Console.ForegroundColor = ConsoleColor.Yellow;
                    jogo1 = "FIFA";
                    Console.WriteLine("Você selecionou o FIFA ");
                    Console.ResetColor();
                    Console.Write("\n");
                    Console.Write("Digite ENTER para continuar ");
                    Console.ReadKey();
                    Console.Write("\n");
                    Console.WriteLine("=================================================");
                    Console.ForegroundColor = ConsoleColor.Gray;
                    Console.WriteLine("Selecione o tempo que deseja jogar: ");
                    Console.WriteLine("15M  ");
                    Console.WriteLine("30M   ");
                    Console.WriteLine("1H  ");
                    Console.Write("\n");
                    int QUINZE1 = 15;
                    int resUser1 = int.Parse(Console.ReadLine());
                    if (QUINZE1 == resUser1)
                    {
                        Console.WriteLine("Você selecionou 15 minutos, aproveite seu tempo! ");
                    }

                    int TRINTA1 = 30;
                    if (TRINTA1 == resUser1)
                    {
                        Console.WriteLine("Você selecionou 30 minutos, aproveite seu tempo!");
                    }

                    int HORA1 = 1;
                    if (HORA1 == resUser1)
                    {
                        Console.WriteLine("Você selecionou 1h, aproveite seu tempo! ");
                    }

                    break;

                    //------------------------------------------------------------------------

                case 2:
                    Console.ForegroundColor = ConsoleColor.Magenta;
                    jogo2 = "CALL OF DUTY";
                    Console.WriteLine("Você selecionou o CALL OF DUTY ");
                    Console.ResetColor();
                    Console.Write("\n");
                    Console.Write("Digite ENTER para continuar ");
                    Console.ReadKey();
                    Console.Write("\n");
                    Console.WriteLine("=================================================");
                    Console.ForegroundColor = ConsoleColor.Gray;
                    Console.WriteLine("Selecione o tempo que deseja jogar: ");
                    Console.WriteLine("15M  ");
                    Console.WriteLine("30M   ");
                    Console.WriteLine("1H  ");
                    Console.Write("\n");

                    int QUINZE2 = 15;
                    int resUser2 = int.Parse(Console.ReadLine());
                    if (QUINZE2 == resUser2)
                    {
                        Console.WriteLine("Você selecionou 15 minutos, aproveite seu tempo! ");
                    }

                    int TRINTA2 = 30;
                    if (TRINTA2 == resUser2)
                    {
                        Console.WriteLine("Você selecionou 30 minutos, aproveite seu tempo! ");
                    }

                    int HORA2 = 1;
                    if (HORA2 == resUser2)
                    {
                        Console.WriteLine("Você selecionou 1h, aproveite seu tempo! ");
                    }
                    break;

                    //---------------------------------------------------------------

                case 3:
                    Console.ForegroundColor = ConsoleColor.Cyan;
                    jogo3 = "STREET FIGHTER V";
                    Console.WriteLine("Você selecionou o STREET FIGHTER V");
                    Console.ResetColor();
                    Console.Write("\n");
                    Console.Write("Digite ENTER para continuar ");
                    Console.ReadKey();
                    Console.Write("\n");
                    Console.WriteLine("=================================================");
                    Console.ForegroundColor = ConsoleColor.Gray;
                    Console.WriteLine("Selecione o tempo que deseja jogar: ");
                    Console.WriteLine("15M  ");
                    Console.WriteLine("30M   ");
                    Console.WriteLine("1H  ");
                    Console.Write("\n");

                    int QUINZE3 = 15;
                    int resUser3 = int.Parse(Console.ReadLine());
                    if (QUINZE3 == resUser3)
                    {
                        Console.WriteLine("Você selecionou 15 minutos, aproveite seu tempo! ");
                    }

                    int TRINTA3 = 30;
                    if (TRINTA3 == resUser3)
                    {
                        Console.WriteLine("Você selecionou 30 minutos, aproveite seu tempo! ");
                    }

                    int HORA3 = 1;
                    if (HORA3 == resUser3)
                    {
                        Console.WriteLine("Você selecionou 1h, aproveite seu tempo! ");
                    }
                    break;

                    //---------------------------------------------------------------------

                case 4:
                    Console.ForegroundColor = ConsoleColor.DarkGreen;
                    jogo4 = "GRAN TURISMO 7";
                    Console.WriteLine("Você selecionou o GRAN TURISMO 7");
                    Console.ResetColor();
                    Console.Write("\n");
                    Console.Write("Digite ENTER para continuar ");
                    Console.ReadKey();
                    Console.Write("\n");
                    Console.WriteLine("=================================================");
                    Console.ForegroundColor = ConsoleColor.Gray;
                    Console.WriteLine("Selecione o tempo que deseja jogar: ");
                    Console.WriteLine("15M  ");
                    Console.WriteLine("30M   ");
                    Console.WriteLine("1H  ");
                    Console.Write("\n");

                    int QUINZE4 = 15;
                    int resUser4 = int.Parse(Console.ReadLine());
                    if (QUINZE4 == resUser4)
                    {
                        Console.WriteLine("Você selecionou 15 minutos, aproveite seu tempo! ");
                    }

                    int TRINTA4 = 30;
                    if (TRINTA4 == resUser4)
                    {
                        Console.WriteLine("Você selecionou 30 minutos, aproveite seu tempo!");
                    }

                    int HORA4 = 1;
                    if (HORA4 == resUser4)
                    {
                        Console.WriteLine("Você selecionou 1h, aproveite seu tempo! ");
                    }
                    break;

                    //----------------------------------------------------------------------

                case 5:
                    Console.ForegroundColor = ConsoleColor.DarkBlue;
                    jogo5 = "NBA 2K23";
                    Console.WriteLine("Você selecionou o NBA 2K23");
                    Console.ResetColor();
                    Console.Write("\n");
                    Console.Write("Digite ENTER para continuar ");
                    Console.ReadKey();              
                    Console.Write("\n");
                    Console.WriteLine("=================================================");
                    Console.ForegroundColor = ConsoleColor.Gray;
                    Console.WriteLine("Selecione o tempo que deseja jogar: ");
                    Console.WriteLine("15M  ");
                    Console.WriteLine("30M   ");
                    Console.WriteLine("1H  ");
                    Console.Write("\n");
                    
                    int QUINZE5 = 15;
                    int resUser5 = int.Parse(Console.ReadLine());
                    if (QUINZE5 == resUser5)
                    {
                        Console.WriteLine("Você selecionou 15 minutos, aproveite seu tempo!");
                    }

                     int TRINTA5 = 30;
                     if (TRINTA5 == resUser5)
                    { 
                        Console.WriteLine("Você selecionou 30 minutos, aproveite seu tempo! ");

                    }

                    int HORA5 = 1;
                    if (HORA5 == resUser5)
                    {
                        Console.WriteLine("Você selecionou 1h, aproveite seu tempo! ");
                    }
                     break;
                    
                    
                    //--------------------------------------------------------------------------


            }
        }
    }
}
