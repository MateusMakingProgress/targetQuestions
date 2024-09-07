using System.Data.SqlTypes;
using System.Security.Cryptography.X509Certificates;

public class Program
{
    public static void Main(string[] args)
    {
        Console.WriteLine("Hello, Target!");
        Thread.Sleep(1000);

        Console.WriteLine("\n\n5) Escreva um programa que inverta os caracteres de um string. \n" +
            "IMPORTANTE: \n" +
            "a) Essa string pode ser informada através de qualquer entrada de sua preferência ou pode ser previamente definida no código; \n" +
            "b) Evite usar funções prontas, como, por exemplo, reverse; \n");

        Console.WriteLine("Insira texto que deve ser revertido: ");

        string textoReverter = Console.ReadLine();

        char[] caracteres = textoReverter.ToCharArray();

        for (int i = 0; i < textoReverter.Length / 2; i++)
        {
            char caracterRevertido = caracteres[i];
            caracteres[i] = caracteres[textoReverter.Length - i - 1];
            caracteres[textoReverter.Length - i - 1] = caracterRevertido;
        }

        textoReverter = new string(caracteres);

        Thread.Sleep(1000);

        Console.WriteLine("Agora o texto foi revertido e virou: " + textoReverter);

        Console.WriteLine("\n\n\n\n\n Já vou ser contratado? Espero que sim, quero aprender mais.");

        Console.ReadKey();
    }
}