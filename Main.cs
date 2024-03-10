
using System;

public class TargetSistemas
{
    public static void Main(string[] args)
    {
        QuestaoUm();
        QuestaoDois();
        QuestaoTres();
        QuestaoQuatro();
        QuestaoCinco();
    }
    
    private static void QuestaoUm() 
    {
         Console.WriteLine("Primeira questão: O valor da variável SOMA seria 91.");
    }
    
    private static void QuestaoDois() 
    {
        int n=0;
        Console.WriteLine("Segunda questão");
        
        Console.WriteLine("Digite o número que deseja verificar se faz parte da sequência de Fibonacci: ");
        n = int.Parse(Console.ReadLine());
        
        bool res = numeroFibonacci(n);
        if(res) 
        {
            Console.WriteLine("O número está presente na sequência de Fibonacci.");
        } else 
        {
            Console.WriteLine("O número não está presente na sequência de Fibonacci.");
        }
        
    }
    
    private static void QuestaoTres() 
    {
        Console.WriteLine("Questão três:");
        Console.WriteLine("1. 9");
        Console.WriteLine("2. 128");
        Console.WriteLine("3. 49");
        Console.WriteLine("4. 100");
        Console.WriteLine("5. 13");
        Console.WriteLine("6. 200");
        
    }
    
    private static void QuestaoQuatro() 
    {
        Console.Write("Questão 4: ");
        Console.WriteLine("Ligando o primeiro interruptor e esperando alguns minutos. Após isso, desligar o primeiro interruptor e ligar o segundo. Agora, deve-se ir para qualquer sala. Caso a lâmpada esteja apagada, mas quente, é o primeiro interruptor. Caso a lâmpada esteja ligada, é o segundo interruptor. Caso a lâmpada esta apagada e fria, é o terceiro interruptor.");
    }
    
    private static void QuestaoCinco()
    {
        Console.WriteLine("Questão cinco:");
        Console.WriteLine("Digite o que você deseja inverter: ");
        string frase = Console.ReadLine();
        
        string fraseInvertida = InverterString(frase);
        Console.WriteLine(fraseInvertida);
    }
    
     private static bool testaQuadradoPerfeito(int n)
    {
        int sq = (int)Math.Sqrt(n);
        return (sq * sq == n);
    }
 

    private static bool numeroFibonacci(int n)
    {
        return testaQuadradoPerfeito(5 * n * n + 4) ||
               testaQuadradoPerfeito(5 * n * n - 4);
    }
    
    private static string InverterString(string frase) 
    {
        int tamanhoFrase = frase.Length;
        char[] caracteresInvertidos = new char[tamanhoFrase];
        
        for (int i = 0; i < tamanhoFrase; i++) 
        {
            caracteresInvertidos[tamanhoFrase -1 -i] = frase[i];
        }
        
        return new string(caracteresInvertidos);
    }
    
      
    
}