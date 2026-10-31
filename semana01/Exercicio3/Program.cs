using System;

class Program
{
    static void Main(string[] args)
    {
        // Para as Partes 1 e 2, onde o usuário definiu o número...
        // Console.Write("Qual é o número mágico? ");
        // int numeroMagico = int.Parse(Console.ReadLine());
        
        // Para a Parte 3, onde usamos um número aleatório
        Random geradorRandomico = new Random();
        int numeroMagico = geradorRandomico.Next(1, 101);

        int palpite = -1;

        // Nós poderiamos usar um laço do-while aqui...
        while (palpite != numeroMagico)
        {
            Console.Write("Qual o seu palpite? ");
            palpite = int.Parse(Console.ReadLine());

            if (numeroMagico > palpite)
            {
                Console.WriteLine("Maior");
            }
            else if (numeroMagico < palpite)
            {
                Console.WriteLine("Menor");
            }
            else
            {
                Console.WriteLine("Você adivinhou!");
            }

        }                    
    }
}