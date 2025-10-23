using System;

class Program
{
    static void Main()
    {
        string[] nomes = { "Maria", "João", "Ana", "Carlos", "Beatriz" };

        BubbleSortCrescente(nomes);

        Console.WriteLine("Ordem Crescente:");
        foreach (string nome in nomes)
        {
            Console.Write(nome + " ");
        }

        Console.WriteLine();
    }

    static void BubbleSortCrescente(string[] vetor)
    {
        int n = vetor.Length;
        string temp;

        for (int i = 0; i < n - 1; i++)
        {
            for (int j = 0; j < n - i - 1; j++)
            {
                // compareTo retorna >0 se vetor[j] > vetor[j+1]
                if (vetor[j].CompareTo(vetor[j + 1]) > 0)
                {
                    temp = vetor[j];
                    vetor[j] = vetor[j + 1];
                    vetor[j + 1] = temp;
                
            }
        }
    }
}
