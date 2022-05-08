using System;  
public class Program
{
    public static void Main(string[] args)
    {
        int n = 0;
        for (int i = 0; i < 1000; i++) 
        {
            // Verifica se o n é par E se o reverso de n é impar,
            // se essas condições forem verdadeiras, realiza a soma dos numeros. 
            if (i % 2 == 0 && reverse(i) % 2 != 0){
            // soma dos numeros.
                n = (i + reverse(i));
            // mostra na tela o resultado. 
                Console.WriteLine(" n {0} par: + reverso(n) impar: {1} = result: {2}", i, reverse(i), n);
            } 

        }
    }

    public static int reverted=0;

    // Metodo para inverter o numero!
    public static int reverse(int n)
    {
        int resultado = 0;
        while (n > 0) {
            resultado = 10 * resultado + n % 10;
            n /= 10;
        }
        return resultado;
    }
}