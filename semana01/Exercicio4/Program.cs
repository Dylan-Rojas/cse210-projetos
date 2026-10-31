using System;
using System.Collections.Generic;

class Program
{
    static void Main(string[] args)
    {
        List<int> numeros = new List<int>();
        
        
        int numeroUsuario = -1;
        while (numeroUsuario != 0)
        {
            Console.Write("Digite um número (0 para sair): ");
            
            string respostaUsuario = Console.ReadLine();
            numeroUsuario = int.Parse(respostaUsuario);
            
         
            if (numeroUsuario != 0)
            {
                numeros.Add(numeroUsuario);
            }
        }

       
        int soma = 0;
        foreach (int numero in numeros)
        {
            soma += numero;
        }

        Console.WriteLine($"A soma é: {soma}");

       
        float media = ((float)soma) / numeros.Count;
        Console.WriteLine($"A média é: {media}");

       
        
        int maior = numeros[0];

        foreach (int numero in numeros)
        {
            if (numero > maior)
            {
               
                maior = numero;
            }
        }

        Console.WriteLine($"O maior valor é: {maior}");
    }
}