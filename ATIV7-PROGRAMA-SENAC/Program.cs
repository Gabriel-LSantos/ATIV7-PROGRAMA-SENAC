using System;

class Program
{
    static void Main()
    {
        string[] alunos = new string[5]; // Cria um array para armazenar os nomes dos alunos

        // Preenche o array com os nomes dos alunos
        for (int i = 0; i < alunos.Length; i++)
        {
            Console.WriteLine($"Digite o nome do aluno {i + 1}:");
            alunos[i] = Console.ReadLine();
        }

        // Exibe os nomes dos alunos usando o foreach
        Console.WriteLine("Nomes dos alunos:");
        foreach (string aluno in alunos)
        {
            Console.WriteLine(aluno);
        }
    }
}
