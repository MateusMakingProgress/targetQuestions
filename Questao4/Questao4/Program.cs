using System.Data.SqlTypes;

public class Program
{
    public static void Main(string[] args)
    {
        Console.WriteLine("Hello, Target!");
        Thread.Sleep(1000);

        Console.WriteLine("\n\n4) Dado o valor de faturamento mensal de uma distribuidora, detalhado por estado: \n" +
            "• SP – R$67.836,43 \n" +
            "• RJ – R$36.678,66 \n" +
            "• MG – R$29.229,88 \n" +
            "• ES – R$27.165,48 \n" +
            "• Outros – R$19.849,53 \n");
        Thread.Sleep(1000);

        double estadoSP = 67836.43;
        double estadoRJ = 36678.66;
        double estadoMG = 29229.88;
        double estadoES = 27165.48;
        double estadoOutros = 19849.53;

        var somaTotal = estadoSP + estadoRJ + estadoMG + estadoES + estadoOutros;

        estadoSP = (estadoSP * 100) / somaTotal;
        estadoRJ = (estadoRJ * 100) / somaTotal;
        estadoMG = (estadoMG * 100) / somaTotal;
        estadoES = (estadoES * 100) / somaTotal;
        estadoOutros = (estadoOutros * 100) / somaTotal;

        Console.WriteLine("O porcentual total do estado de São Paulo é de: " + estadoSP);
        Console.WriteLine("O porcentual total do estado de Rio de Janeiro é de: " + estadoRJ);
        Console.WriteLine("O porcentual total do estado de Minas Gerais é de: " + estadoMG);
        Console.WriteLine("O porcentual total do estado de Espirito Santo é de: " + estadoES);
        Console.WriteLine("O porcentual total dos outros estados é de: " + estadoOutros);

        Console.ReadKey();
    }
}