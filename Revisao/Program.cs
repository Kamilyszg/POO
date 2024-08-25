internal class Program
{
    private static void Main(string[] args)
    {
        /*Console.Write("Digite o ano de nascimento: ");
        int ano = Convert.ToInt32(Console.ReadLine());
        int idade = 2024 - ano;
        Console.WriteLine("Sua idade é: " + idade);

        //Condicional
        if (idade >= 18)
            System.Console.WriteLine("Maior de idade");
        else if (idade == 1)
            System.Console.WriteLine("É um bebê");
        else
            System.Console.WriteLine("Menor de idade");

        //Estrutura de repetição
        int contador = 1;
        while (contador <= 10)
        {
            System.Console.WriteLine("5 x " + contador + " = " + contador * 5);
            contador ++; // contador = contador + 1
        }

        for (int cont = 1; cont <= 10; cont ++)
            Console.WriteLine("5 x " + cont + " = " + cont * 5);

        int cont = 1;
        do
        {
            Console.WriteLine("7 x " + cont + " = " + cont * 7);
            cont += 1;
        } while (cont <= 10);

        //Estrutura de decisão de multipla escolha - ideal para int e char
        int opcao = 1;
        switch (opcao) 
        {
            case 1: System.Console.WriteLine("1 = Somar"); //condicao de igualdade se opcao == 1
                //lógica para somar
                break; // quando a condicao for verdadeira, execute e pare.
            
            case 2: System.Console.WriteLine("2 = Subtrair"); // se opcao == 2
                break;
            
            default: System.Console.WriteLine("Opção inválida"); //default == else
                break;
        }

        //Operador Ternário
        float media = 5;
        System.Console.WriteLine((media >= 6) ? "Aprovado" : "Reprovado");
        // Se a condição verdadeira "Aprovado" senão "Reprovado"*/

        //Estrutura de repetição específica para vetor
        int[] vet = new int[3];
        vet[0] = 12;
        vet[1] = 37;
        vet[2] = 61;
        foreach (int v in vet) //cria-se uma variavel que representa um valor do vetor do inicio ao fim
            System.Console.WriteLine(v);
            
        System.Console.WriteLine("Exemplo com for");
        for (int i = 0; i < vet.Length; i++)
        {
            System.Console.WriteLine(vet[i]);
        }
    }
}