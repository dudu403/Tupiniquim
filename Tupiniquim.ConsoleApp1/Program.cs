using System;

namespace Tupiniquim.ConsoleApp
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string[] pontoInicial = new string[3]; // 
            int posicaoX, posicaoY;
            char coordenadaAtual;
            char[] SeparaEspaco = { ' ', ',' }; // Usuario vai digitar tudo na mesma linha com espaço ou virgula 

            for (int i = 0; i < 2; i++)
            {
                Console.WriteLine("---- PROJETO ROBÔ TUPINIQUIM ----");
                Console.WriteLine("\n");
                Console.WriteLine("Informe a posição atual do robô (X,Y) e sua coordenada: N, S, L e O ");
       
                pontoInicial = Console.ReadLine().Split(SeparaEspaco, StringSplitOptions.RemoveEmptyEntries);

                posicaoX = Convert.ToInt32(pontoInicial[0]);
                posicaoY = Convert.ToInt32(pontoInicial[1]);

                coordenadaAtual = Convert.ToChar(pontoInicial[2].ToUpper());

                Console.WriteLine("Informe as coordenadas de pouso do robozinho: ");
                char[] vetorInstrucoes = Console.ReadLine().ToUpper().ToCharArray();

                 	
                // ToUpper retorna uma cópia dessa cadeia de caracteres convertida em maiúsculas ou minúsculas
                // com essa função não será necessário fazer vários if


                // for e switch que vai fazer o robo trocar de posicao atual para outra ex: N para O, S para L 
                for (int j = 0; j < vetorInstrucoes.Length; j++)
                {
                    char instrucao = vetorInstrucoes[j];
                    switch (instrucao)
                    {
                        case 'E':
                            switch (coordenadaAtual)
                            {
                                case 'N':
                                    coordenadaAtual = 'O';
                                    break;
                                case 'S':
                                    coordenadaAtual = 'L';
                                    break;
                                case 'L':
                                    coordenadaAtual = 'N';
                                    break;
                                case 'O':
                                    coordenadaAtual = 'S';
                                    break;
                            }
                            break;
                        case 'D':
                            switch (coordenadaAtual)
                            {
                                case 'N':
                                    coordenadaAtual = 'L';
                                    break;
                                case 'S':
                                    coordenadaAtual = 'O';
                                    break;
                                case 'L':
                                    coordenadaAtual = 'S';
                                    break;
                                case 'O':
                                    coordenadaAtual = 'N';
                                    break;
                            }
                            break;
                        case 'M':
                            switch (coordenadaAtual)
                            {
                                case 'N':
                                    posicaoY++;
                                    break;
                                case 'S':
                                    posicaoY--;
                                    break;
                                case 'L':
                                    posicaoX++;
                                    break;
                                case 'O':
                                    posicaoX--;
                                    break;

                                default:
                                    break;
                            }
                            break;
                    }

                }
                Console.WriteLine("{0} {1} {2}", posicaoX, posicaoY, coordenadaAtual);
            }
            Console.ReadKey();
        }
    }
}