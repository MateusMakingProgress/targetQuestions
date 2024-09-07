class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine("Hello, Target!");
        Thread.Sleep(3000);

        Console.WriteLine("\n\n1) Observe o trecho de código abaixo: int INDICE = 13, SOMA = 0, K = 0;\n" +
            "Enquanto K < INDICE faça { K = K + 1; SOMA = SOMA + K; }\n" +
            "Imprimir(SOMA);\n" +
            "Ao final do processamento, qual será o valor da variável SOMA?");
        Thread.Sleep(5000);
        Console.Clear();

        int indice = 13, soma = 0, k = 0;

        Console.WriteLine("Efetuando calculo proposto, aguarde um momento...");
        Thread.Sleep(3000);
        Console.Clear();

        Console.WriteLine("Valor de SOMA atual = " + soma);
        Console.WriteLine("Valor de K atual = " + k);
        Thread.Sleep(1000);
        Console.Clear();

        while (k < indice)
        {
            k ++;
            Console.WriteLine("Valor de K atual = " + k);
            Thread.Sleep(1000);
            Console.Clear();
            soma ++;
        }
        Console.WriteLine("Valor de K atual = " + k);

        Console.WriteLine("Valor de SOMA atual = " + soma);
        Thread.Sleep(5000);
    }
}
