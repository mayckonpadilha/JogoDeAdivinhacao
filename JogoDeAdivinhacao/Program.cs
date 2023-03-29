using System;

namespace JogoDeAdivinhacao
{
    class Program

    {
        static void Main(string[] args)
        {
            int nivelDificuldade = 1, totalDeTentativas = 0;
            double totalDePontos = 1000;

       
            
            Console.WriteLine("* Bem-vindo(a) ao Jogo da Adivinhação *");
            

            
            Console.WriteLine();
            Console.WriteLine("Escolha o nível de dificuldade: ");
            Console.WriteLine("(1) Fácil (2) Médio (3) Difícil");
            Console.Write("Escolha: ");
            nivelDificuldade = Convert.ToInt32(Console.ReadLine());

            switch (nivelDificuldade)
            {
                case 1:
                    totalDeTentativas = 15;
                    break;
                case 2:
                    totalDeTentativas = 10;
                    break;
                case 3:
                    totalDeTentativas = 5;
                    break;
            }

            
            Random random = new Random();
            int numeroSecreto = random.Next(1, 21);

            for (int quantidadeChutes = 1; quantidadeChutes <= totalDeTentativas; quantidadeChutes++)
            {
                Console.Clear();

                Console.WriteLine($"Tentativa {quantidadeChutes} de {totalDeTentativas}");

                
                Console.WriteLine();
                Console.WriteLine("Qual o seu chute? ");
                string chute = Console.ReadLine();

                int numeroChute = Convert.ToInt32(chute);

                bool acertou = numeroChute == numeroSecreto;
                bool menor = numeroChute < numeroSecreto;

              
                if (acertou)
                {
                    Console.WriteLine("Parabéns, você acertou!");
                    Console.WriteLine($"Você fez {totalDePontos} pontos!");
                    break;
                }
                else if (menor)
                    Console.WriteLine("Seu chute foi menor que o número secreto");
                else
                    Console.WriteLine("Seu chute foi maior que o número secreto");

                double pontosPerdidos = Math.Abs((numeroChute - numeroSecreto) / 2);

                totalDePontos = totalDePontos - pontosPerdidos;

                Console.WriteLine($"Você fez {totalDePontos} pontos!");

                if (quantidadeChutes <= totalDeTentativas)
                    Console.WriteLine("Que azar! Tente novamente!");

                Console.ReadLine();
            }

            Console.ReadLine();
        }
    }
}