using System;

class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine("Bem-vindo ao TP 2 de C# de Samuel!");

        int x;

        do
        {
            Console.WriteLine("\nEscolha um exercício para rodar:");
            Console.Write("Digite a opção desejada: \n");

            Console.WriteLine("0 - Sair");
            for (int i = 1; i <= 12; i++)
            {
                Console.WriteLine($"{i} - Exercício {i}");
            }

            x = int.Parse(Console.ReadLine());

            switch (x)
            {
                case 0:
                    Console.WriteLine("Saindo...");
                    return; 
                case 1:
                    Console.WriteLine("=== Exercício 1 ===");
                    ex1();
                    continue; 
                case 2:
                    Console.WriteLine("=== Exercício 2 ===");
                    ex2();
                    continue;
                case 3:
                    Console.WriteLine("=== Exercício 3 ===");
                    ex3();
                    continue;
                case 4:
                    Console.WriteLine("=== Exercício 4 ===");
                    ex4();
                    continue;
                case 5:
                    Console.WriteLine("=== Exercício 5 ===");
                    ex5();
                    continue;
                case 6:
                    Console.WriteLine("=== Exercício 6 ===");
                    ex6();
                    continue;
                case 7:
                    Console.WriteLine("=== Exercício 7 ===");
                    ex7();
                    continue;
                case 8:
                    Console.WriteLine("=== Exercício 8 ===");
                    ex8();
                    continue;
                case 9:
                    Console.WriteLine("=== Exercício 9 ===");
                    ex9();
                    continue;
                case 10:
                    Console.WriteLine("=== Exercício 10 ===");
                    ex10();
                    continue;
                case 11:
                    Console.WriteLine("=== Exercício 11 ===");
                    ex11();
                    continue;
                case 12:
                    Console.WriteLine("=== Exercício 12 ===");
                    ex12();
                    continue;
                default:
                    Console.WriteLine("Valor inválido! Tente novamente.");
                    continue;
            }
        } while (x != 0);
    }

    static void ex1()
    {
        Console.Write("Digite sua data de nascimento (dd/mm/aaaa): ");
        DateTime nascimento = DateTime.Parse(Console.ReadLine());
        DateTime hoje = DateTime.Today;

        int anos = hoje.Year - nascimento.Year;
        if (hoje < nascimento.AddYears(anos)) anos--;

        int meses = hoje.Month - nascimento.Month;
        if (meses < 0) meses += 12;
        if (hoje.Day < nascimento.Day) meses--;

        int dias = hoje.Day - nascimento.Day;
        if (dias < 0) dias += DateTime.DaysInMonth(hoje.Year, hoje.Month);

        Console.WriteLine($"Idade: {anos} anos, {meses} meses e {dias} dias");
    }

    static void ex2()
    {
        Console.Write("Digite sua data de nascimento (dd/mm/aaaa): ");
        DateTime nascimento = DateTime.Parse(Console.ReadLine());
        DateTime hoje = DateTime.Today;

        DateTime proximoAniversario = new DateTime(hoje.Year, nascimento.Month, nascimento.Day);
        if (proximoAniversario < hoje) proximoAniversario = proximoAniversario.AddYears(1);

        int dias = (proximoAniversario - hoje).Days;
        Console.WriteLine($"Faltam {dias} dias para seu próximo aniversário");
    }

    static void ex3()
    {
        Console.Write("Digite a primeira data (dd/mm/aaaa): ");
        DateTime data1 = DateTime.Parse(Console.ReadLine());
        Console.Write("Digite a segunda data (dd/mm/aaaa): ");
        DateTime data2 = DateTime.Parse(Console.ReadLine());

        TimeSpan diferenca = (data2 > data1) ? data2 - data1 : data1 - data2;
        int anos = diferenca.Days / 365;
        int meses = (diferenca.Days % 365) / 30;
        int dias = diferenca.Days % 30;

        Console.WriteLine($"Diferença: {anos} anos, {meses} meses e {dias} dias");
    }

    static void ex4()
    {
        Console.Write("Nome: ");
        string nome = Console.ReadLine();
        Console.Write("Idade: ");
        int idade = int.Parse(Console.ReadLine());
        Console.Write("Telefone: ");
        string telefone = Console.ReadLine();
        Console.Write("E-mail: ");
        string email = Console.ReadLine();

        Console.WriteLine("\nDados Cadastrados:");
        Console.WriteLine($"Nome: {nome}");
        Console.WriteLine($"Idade: {idade}");
        Console.WriteLine($"Telefone: {telefone}");
        Console.WriteLine($"E-mail: {email}");
    }

    static void ex5()
    {
        Console.Write("Digite a temperatura em Celsius: ");
        double celsius = double.Parse(Console.ReadLine());
        
        double fahrenheit = celsius * 9 / 5 + 32;
        double kelvin = celsius + 273.15;

        Console.WriteLine($"Fahrenheit: {fahrenheit:F2}°F");
        Console.WriteLine($"Kelvin: {kelvin:F2}K");
    }

    static void ex6()
    {
        Console.Write("Digite seu peso (kg): ");
        string pesoInput = Console.ReadLine();
        double peso = double.Parse(pesoInput);

        Console.Write("Digite sua altura (Ex: 1,80): ");
        string alturaInput = Console.ReadLine();
        double altura = double.Parse(alturaInput);

        double imc = peso / (altura * altura);

        string classificacao;
        if (imc < 16)
            classificacao = "Magreza grave";
        else if (imc < 18.5)
            classificacao = "Abaixo do peso";
        else if (imc < 25)
            classificacao = "Peso normal";
        else if (imc < 30)
            classificacao = "Sobrepeso";
        else if (imc < 35)
            classificacao = "Obesidade Grau I";
        else if (imc < 40)
            classificacao = "Obesidade Grau II";
        else
            classificacao = "Obesidade Grau III";

        Console.WriteLine($"IMC: {imc:F2}");
        Console.WriteLine($"Classificação: {classificacao}");
    }

    static void ex7()
    {
        Console.Write("Digite um número: ");
        int numero = int.Parse(Console.ReadLine());
        
        Console.WriteLine(numero % 2 == 0 ? "Par" : "Ímpar");
    }

    static void ex8()
    {
        Console.Write("Digite a nota (0-10): ");
        double nota = double.Parse(Console.ReadLine());

        string classificacao = nota switch
        {
            < 5 => "Insuficiente",
            < 7 => "Regular",
            < 9 => "Bom",
            <= 10 => "Excelente",
            _ => "Nota inválida"
        };

        Console.WriteLine($"Classificação: {classificacao}");
    }

    static void ex9()
    {
        Console.Write("Digite o salário bruto mensal: ");
        double brutoMensal = double.Parse(Console.ReadLine());

        double inss;
        if (brutoMensal <= 1518.00)
            inss = brutoMensal * 0.075;
        else if (brutoMensal <= 2793.88)
            inss = (1518.00 * 0.075) + ((brutoMensal - 1518.00) * 0.09);
        else if (brutoMensal <= 4190.83)
            inss = (1518.00 * 0.075) + ((2793.88 - 1518.00) * 0.09) + ((brutoMensal - 2793.88) * 0.12);
        else if (brutoMensal <= 8157.41)
            inss = (1518.00 * 0.075) + ((2793.88 - 1518.00) * 0.09) + ((4190.83 - 2793.88) * 0.12) + ((brutoMensal - 4190.83) * 0.14);
        else
            inss = 851.63;

        double baseIRRF = brutoMensal - inss;

        double irrf;
        if (baseIRRF <= 2259.20)
            irrf = 0;
        else if (baseIRRF <= 2826.65)
            irrf = (baseIRRF * 0.075) - 169.44;
        else if (baseIRRF <= 3751.05)
            irrf = (baseIRRF * 0.15) - 381.44;
        else if (baseIRRF <= 4664.68)
            irrf = (baseIRRF * 0.225) - 662.77;
        else
            irrf = (baseIRRF * 0.275) - 896.00;

        irrf = Math.Max(0, irrf);
        double descontoTotal = inss + irrf;
        double liquidoMensal = brutoMensal - descontoTotal;

        Console.WriteLine($"Salário Bruto: R${brutoMensal:F2}");
        Console.WriteLine($"Desconto: R${descontoTotal:F2} (INSS: R${inss:F2}, IRRF: R${irrf:F2})");
        Console.WriteLine($"Salário Líquido: R${liquidoMensal:F2}");
    }

    static void ex10()
    {
        Console.Write("Digite um número: ");
        int numero = int.Parse(Console.ReadLine());

        for (int i = numero; i >= 0; i--)
        {
            Console.Write(i);
            if (i > 0) Console.Write(", ");
        }
        Console.WriteLine();
    }

    static void ex11()
    {
        Console.Write("Digite um número: ");
        int numero = int.Parse(Console.ReadLine());

        for (int i = 1; i <= 10; i++)
        {
            Console.WriteLine($"{numero} x {i} = {numero * i}");
        }
    }

    static void ex12()
    {
        Random random = new Random();
        int numeroSecreto = random.Next(1, 101);
        int palpite;
        int tentativas = 0;

        do
        {
            Console.Write("Digite seu palpite (1-100): ");
            palpite = int.Parse(Console.ReadLine());
            tentativas++;

            if (palpite < numeroSecreto)
                Console.WriteLine("Maior!");
            else if (palpite > numeroSecreto)
                Console.WriteLine("Menor!");
        } while (palpite != numeroSecreto);

        Console.WriteLine($"Parabéns! Você acertou em {tentativas} tentativas!");
    }
}