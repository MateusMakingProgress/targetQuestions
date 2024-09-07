class Program
{
    private static void Main(string[] args)
    {
        Console.WriteLine("Hello, Target!");
        Thread.Sleep(3000);

        Console.WriteLine("\n\n2) Dado a sequência de Fibonacci, onde se inicia por 0 e 1 e o próximo valor sempre será a soma dos 2 valores anteriores (exemplo: 0, 1, 1, 2, 3, 5, 8,\n" +
            "13, 21, 34...), escreva um programa na linguagem que desejar onde, informado um número, ele calcule a sequência de Fibonacci e retorne uma\n" +
            "mensagem avisando se o número informado pertence ou não a sequência.\n");
        Thread.Sleep(5000);
        Console.Clear();

        Console.WriteLine("Insira um valor para continuar:");
        Thread.Sleep(1000);
        int valorMax = int.Parse(Console.ReadLine());
        Console.Clear();

        int soma = 0, x = 1, y = 0;
        bool finabonacci = false;

        while (finabonacci == false)
        {
            Console.WriteLine("\n" + soma);
            Thread.Sleep(1000);
            soma = x + y;
            y = x;
            x = soma;

            if (soma == valorMax)
            {
               finabonacci = true;
                Console.WriteLine("\n" + soma);
                Thread.Sleep(1000);
            }
            else if (soma >= valorMax)
            {
                finabonacci = true;
                Console.WriteLine("\n" + soma);
                Thread.Sleep(1000);
            }

            else if (soma <= valorMax)
            {
                finabonacci = false;
            }
        }

        if (soma == valorMax)
        {
            Console.Clear();
            Console.WriteLine("\n\nNúmero informado " + valorMax + " pertence a sequência.\n\n");
            Console.WriteLine("Pressione qualquer tecla para continuar...");
            Console.ReadKey();
            Console.Clear();
        }
        else
        {
            Console.Clear();
            Console.WriteLine("\n\nNúmero informado " + valorMax + " não pertence a sequência.\n\n");
            Console.WriteLine("Pressione qualquer tecla para continuar...");
            Console.ReadKey();
            Console.Clear();
        }
    }
}