using System;
using System.Collections.Generic;

class Program
{
    static void Main(string[] args)
    {
        // Criatividade para nota maxima
        // adicionei várias escrituras SUD 
        // e assim na escolha de uma aleatoriamente a cada execução.

        List<Scripture> scriptures = new List<Scripture>()
        {
            new Scripture(
                new Reference("1 Néfi", 3, 7),
                "Irei e cumprirei as ordens do Senhor porque sei que o Senhor nunca dá mandamento aos filhos dos homens sem antes preparar um caminho para que realizem o que ele lhes ordena."
            ),

            new Scripture(
                new Reference("Mosias", 2, 17),
                "Quando estais a serviço de vosso próximo estais somente a serviço de vosso Deus."
            ),

            new Scripture(
                new Reference("Alma", 37, 6),
                "Por meio de coisas pequenas e simples são realizadas grandes coisas."
            ),

            new Scripture(
                new Reference("Éter", 12, 27),
                "Se os homens vierem a mim mostrar lhes ei sua fraqueza e farei com que as coisas fracas se tornem fortes para eles."
            ),

            new Scripture(
                new Reference("Doutrina e Convênios", 4, 2),
                "Portanto ó vós que embarcais no serviço de Deus servi o de todo o coração poder mente e força."
            )
        };

        Random random = new Random();
        Scripture scripture = scriptures[random.Next(scriptures.Count)];

        while (!scripture.IsCompletelyHidden())
        {
            Console.Clear();

            Console.WriteLine(scripture.GetDisplayText());
            Console.WriteLine();

            Console.Write("Pressione Enter para continuar ou digite 'sair': ");
            string input = Console.ReadLine();

            if (input.ToLower() == "sair")
            {
                return;
            }

            scripture.HideRandomWords(3);
        }

        Console.Clear();
        Console.WriteLine(scripture.GetDisplayText());
        Console.WriteLine();
        Console.WriteLine("Parabéns! Todas as palavras foram ocultadas.");
    }
}