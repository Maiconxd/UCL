using System;

class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine("Digite sua nota de T1:");
        float t1 = Convert.ToSingle(Console.ReadLine());

        Console.WriteLine("Digite sua nota de P1:");
        float p1 = Convert.ToSingle(Console.ReadLine());

        float n1 = t1 * 0.3f + p1 * 0.7f;

        Console.WriteLine("Digite sua nota de T2:");
        float t2 = Convert.ToSingle(Console.ReadLine());

        Console.WriteLine("Digite sua nota de P2:");
        float p2 = Convert.ToSingle(Console.ReadLine());

        float n2 = t2 * 0.3f + p2 * 0.7f;

        float nf = (n1 + n2) / 2;

        if (nf >= 7.0f)
        {
            Console.WriteLine("Aprovado");
        }
        else
        {
            Console.WriteLine("Reprovado");
        }
    }
}