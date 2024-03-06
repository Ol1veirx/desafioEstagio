//LIEDSON DANUBIO OLIVEIRA LEITE

//1° QUESTÃO

int INDICE = 13, SOMA = 0, K = 0;

while (K < INDICE)
{
    K += 1;

    SOMA += K;
}

Console.WriteLine(SOMA);


/*---------------------------------------------------------------------------*/

// 2° QUESTÃO

int number = Convert.ToInt32(Console.ReadLine());

PrintFibonacci(number);

if (ToCheckFibonacci(number))
{
    Console.WriteLine($"{number} pertence a sequencia de Fibonacci");
}
else
{
    Console.WriteLine($"{number} não pertence a sequencia de Fibonacci");
}

static void PrintFibonacci(int num)
{
    int a = 0;
    int b = 1;

    Console.WriteLine("Sequencia de Fibonacci: ");

    while (b <= num)
    {
        Console.WriteLine($"{a}");

        int temp = a + b;
        a = b;
        b = temp;
    }
}

static bool ToCheckFibonacci(int num)
{
    int a = 0;
    int b = 1;

    while (b <= num)
    {
        if (b == num)
        {
            return true;
        }

        int temp = a + b;
        a = b;
        b = temp;
    }

    return false;
}

/*---------------------------------------------------------------------------*/

// 3° QUESTÃO

/*
a) 1, 3, 5, 7, [9] - O proximo numero é a soma do anterior mais 2
b) 2, 4, 8, 16, 32, 64, [128] - O proximo numero é a multiplicação do anterior por 2
c) 0, 1, 4, 9, 16, 25, 36, [49] - Seria uma ordem onde o numro a ser somado começa por um e ele vai aumentando mais 2, ex: o primiro a ser somado seria 1, ou seja, 0 + 1 = 1. Depois seria 3 (sendo o anterior que é 1 mais 2), ficando 3 + 1(anterior) = 4(próximo) e assim sucessivamente.
d) 4, 16, 36, 64, [100] - 4(2^2), 16(4^2), 36(6^2), 64(8^2), 100(10^2)
e) 1, 1, 2, 3, 5, 8, [13] - Fibonacci
f) 2, 10, 12, 16, 17, 18, 19, [20] -  O proximo seria 20 já que está aumentando de 1 em 1 a partir do 16

 */

/*---------------------------------------------------------------------------*/

// 4° QUESTÃO

/*
 A gente precisaria deixa ligar o primeirio interruptor e deixar por alguns minutos
para que a lâmpada esquentasse um pouco. Logo em seguida apagariamos o primeiro e
acenderiamos o segundo. Depois disso iriamos na sala onde estão as lampadas e tocaria
nelas. A lampada que estiver acessa é conectada a o segundo interruptor. As outras duas
que estão apagadas nós tocariamos nelas e ao sentir que uma delas está quente isso quer
dizer que ela é controlada pelo primeiro interruptor e a que está apagada e fria é conectada
ao terceio.
 */

/*---------------------------------------------------------------------------*/

//5° QUESTAO

string? myString = Console.ReadLine();

string invertedString = ReverseTheString(myString);
Console.WriteLine($"string normal: {myString}");
Console.WriteLine($"string invertida: {invertedString}");

static string ReverseTheString(string str)
{
    char[] chars = str.ToCharArray();

    int init = 0;
    int end = str.Length - 1;

    while (init < end)
    {
        char temp = chars[init];
        chars[init] = chars[end];
        chars[end] = temp;

        init++;
        end--;
    }

    return new string(chars);
}