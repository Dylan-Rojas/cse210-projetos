using System;
using System.Collections.Generic;
using System.IO;

class Entry
{
    public string Date { get; set; }
    public string PromptText { get; set; }
    public string EntryText { get; set; }

    public override string ToString()
    {
        return $"{Date} | {PromptText}\n{EntryText}";
    }
}

class Journal
{
    private List<Entry> _entries = new List<Entry>();

    public void AddEntry(Entry entry)
    {
        _entries.Add(entry);
    }

    public void DisplayAll()
    {
        foreach (Entry entry in _entries)
        {
            Console.WriteLine("----------------------------");
            Console.WriteLine(entry);
        }
    }

    public void SaveToFile(string fileName)
    {
        using (StreamWriter outputFile = new StreamWriter(fileName))
        {
            foreach (Entry entry in _entries)
            {
                outputFile.WriteLine(
                    $"{entry.Date}|{entry.PromptText}|{entry.EntryText}");
            }
        }
    }

    public void LoadFromFile(string fileName)
    {
        _entries.Clear();

        string[] lines = File.ReadAllLines(fileName);

        foreach (string line in lines)
        {
            string[] parts = line.Split('|');

            Entry entry = new Entry
            {
                Date = parts[0],
                PromptText = parts[1],
                EntryText = parts[2]
            };

            _entries.Add(entry);
        }
    }
}

class PromptGenerator
{
    private List<string> _prompts = new List<string>
    {
        "Quem foi a pessoa mais interessante com quem interagiu hoje?",
        "Qual foi a melhor parte do seu dia?",
        "Como viu a mão do Senhor em sua vida hoje?",
        "Qual foi a emoção mais forte que sentiu hoje?",
        "Se voce pudesse fazer uma coisa hoje, o que seria?",
        "Qual desafio conseguiu superar hoje?",
    };

    private Random _random = new Random();

    public string GetRandomPrompt()
    {
        int index = _random.Next(_prompts.Count);
        return _prompts[index];
    }
}

class Program
{
    static void Main(string[] args)
    {
        Journal journal = new Journal();
        PromptGenerator promptGenerator = new PromptGenerator();

        bool running = true;

        while (running)
        {
            Console.WriteLine();
            Console.WriteLine("Menu");
            Console.WriteLine("1. Escrever novo registro");
            Console.WriteLine("2. Exibir diário");
            Console.WriteLine("3. Salvar diário");
            Console.WriteLine("4. Carregar diário");
            Console.WriteLine("5. Sair");
            Console.Write("Escolha uma opção: ");

            string choice = Console.ReadLine();

            switch (choice)
            {
                case "1":
                    string prompt = promptGenerator.GetRandomPrompt();

                    Console.WriteLine();
                    Console.WriteLine($"Pergunta: {prompt}");
                    Console.Write("> ");

                    string answer = Console.ReadLine();

                    Entry newEntry = new Entry
                    {
                        Date = DateTime.Now.ToShortDateString(),
                        PromptText = prompt,
                        EntryText = answer
                    };

                    journal.AddEntry(newEntry);
                    break;

                case "2":
                    journal.DisplayAll();
                    break;

                case "3":
                    Console.Write("Nome do arquivo: ");
                    string saveFile = Console.ReadLine();
                    journal.SaveToFile(saveFile);
                    Console.WriteLine("Diário salvo com sucesso.");
                    break;

                case "4":
                    Console.Write("Nome do arquivo: ");
                    string loadFile = Console.ReadLine();

                    if (File.Exists(loadFile))
                    {
                        journal.LoadFromFile(loadFile);
                        Console.WriteLine("Diário carregado com sucesso.");
                    }
                    else
                    {
                        Console.WriteLine("Arquivo não encontrado.");
                    }
                    break;

                case "5":
                    running = false;
                    break;

                default:
                    Console.WriteLine("Opção inválida.");
                    break;
            }
        }
    }
}