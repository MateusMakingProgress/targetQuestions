using Newtonsoft.Json;
using Questao3;
using System.Linq;

public class Program
{
    public static void Main(string[] args)
    {
        Console.WriteLine("Hello, Target!");
        Thread.Sleep(1000);

        Console.WriteLine("\n\n3) Dado um vetor que guarda o valor de faturamento diário de uma distribuidora, faça um programa, na linguagem que desejar, que calcule e retorne:\n" +
            "• O menor valor de faturamento ocorrido em um dia do mês;\n" +
            "• O maior valor de faturamento ocorrido em um dia do mês;\n" +
            "• Número de dias no mês em que o valor de faturamento diário foi superior à média mensal.\n" +
            "IMPORTANTE:\n" +
            "a) Usar o json ou xml disponível como fonte dos dados do faturamento mensal;\n" +
            "b) Podem existir dias sem faturamento, como nos finais de semana e feriados. Estes dias devem ser ignorados no cálculo da média;\n");
        Thread.Sleep(1000);

        string fileName = "../../../dados.json";

        string jsonString = File.ReadAllText(fileName);

        var faturamentos = JsonConvert.DeserializeObject<Faturamento[]>(jsonString);

        var menorValor = faturamentos.Select(c => c.valor).Where(x => x != 0).Min();
        var maiorValor = faturamentos.Select(c => c.valor).Where(x => x != 0).Max();
        var diasFaturas = faturamentos.Select(c => c.valor).Count();
        var valorTotal = faturamentos.Select(c => c.valor).Sum(x => x);

        var diaMenorValor = 0;
        var diaMaiorValor = 0;
        var valorMedio = valorTotal / diasFaturas;

        foreach (var item in faturamentos)
        {
            if (item.valor == menorValor)
            {
                diaMenorValor = item.dia;
            }
        }

        Console.WriteLine("O dia com menor faturamento foi " + diaMenorValor + " com o valor de: " + menorValor);

        Console.WriteLine("\nO dia com menor faturamento foi " + diaMaiorValor + " com o valor de: " + maiorValor);

        Console.WriteLine("\n O valor total de faturamento é de: " + valorTotal);

        Console.WriteLine("\n O valor médio de faturamento é de: " + valorMedio);

        foreach (var item in faturamentos)
        {
            if (item.valor > valorMedio)
            {
                Console.WriteLine("\n O faturamento do dia " + item.dia + " com o valor de " + item.valor + " está acima da média.");
            }
        }

        Console.ReadKey();
    }
}