using System;  
public class Program
{
    public static void Main(string[] args)
    {
        // Vetor com valeres a serem somados!
        int[] v = new int[3] {3, 4, 3};
        int soma = 0;
        int n = 10;

        // Perconrrendo o vetor
        for (int i = 0; i <v.Length; i++)
        {
            // Fazendo o calculo dos valores.
            soma += v[i];
            // Verificando se o calculo atingiu o valor determinado.
            if (soma <= n){
                // Exibindo na tela os valores somados, e a soma!
                    Console.WriteLine(" Vetor: {0} , soma: {1}",  v[i], soma);
            }
        }
    }
}