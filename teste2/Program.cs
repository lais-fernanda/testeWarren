using System;  
public class Program
{
    public static void Main(string[] args)
    {
        // Vetor com tempo de chegada!
        int[] tempoChegada = new int[] {-2, -1, 0, 1, 2};

        for (int i = 0; i < 5; i++)
        {
            int x = 3;
            // verifica se tempo de chegada é menor ou igual a 0,
            // E se o numero de alunos é menor ou igual a 3
            // se essas condição forem verdadeiras retorna "Aula normal" 
            if(tempoChegada[0] <= 0 && x <=3)
            {
                Console.WriteLine("Aula normal!!: {0}, tempo: {1}", x, tempoChegada[0]);
            }
            else
            {
                Console.WriteLine("Aula cancelado!!: {0}, tempo: {1}", x, tempoChegada[0]);

            }
        }
    }
}
