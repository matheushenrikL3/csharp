// See https://aka.ms/new-console-template for more information
//Console.WriteLine("Hello, World!");

double nota1 = 8.0;
double nota2 = 8.0;
double nota3 = 6.8;
double media = (nota1 + nota2 + nota3) / 3; 
if (media >= 7)
{
    Console.WriteLine($"Média {media:F2}: Aprovado");
}
else
{
    Console.WriteLine($"Média {media:F2}: Recuperação");
}

double nota4 = 5;
double nota5 = 8;
double nota6 = 5;
double mediaNota = (nota4 + nota5 + nota6) / 3;
if (mediaNota >= 7)
{
    Console.WriteLine($"Média {mediaNota:F2}: Aprovado");
}
else if (mediaNota >= 5 && mediaNota < 7)
{
    Console.WriteLine($"Média {mediaNota:F2}: Recuperação");
}
else 
{
    Console.WriteLine($"Média {mediaNota:F2}: Reprovado");
}

Console.WriteLine("Digite uma vogal");
string? letra = Console.ReadLine();
if (letra == "a" || letra == "A")
{
    Console.WriteLine($"Você digitou uma vogal: {letra}");
}
else if (letra == "e" || letra == "E")
{
    Console.WriteLine($"Você digitou uma vogal: {letra}");
}
else if(letra == "i" || letra == "I")
{
    Console.WriteLine($"Você digitou uma vogal: {letra}");
}
else if(letra == "o" || letra == "O")
{
    Console.WriteLine($"Você digitou uma vogal: {letra}");
}
else if(letra == "u" || letra =="U")
{
    Console.WriteLine($"Você digitou uma vogal: {letra}");
}
else
{
    Console.WriteLine($"A letra {letra} não é uma vogal");
}

// Estrutura Condicional Switch Case 
É usado quando há várias possibilidades de valores 

string dia = "Sábado";

switch (dia)
{
    case "Sábado":
        Console.WriteLine("Sábadoooo galera");
        break;
    case "Domingo";
        Console.WriteLine("Domingao, hoje é dia de assistir a Temperatura Maxíma !");
        break;
    default:
        Console.WriteLine("Hoje é dia da semna, para de preguica, vai trabalhar !");
        break;
}

Console.WriteLine("Digite uma vogal:");
string? letra = Console.ReadLine();
string letraMinuscula = letra.ToLower();
string letraMinuscula = letra.ToUpper();
switch (letraMinuscula);
{
    case "a":
    case "e":
    case "i":
    case "o":
    case "u":
        Console.WriteLine($"A letra a 'a{letraMinuscula}' é uma vogal.");
        break;
    default:
        Console.WriteLine($"A letra a 'a{letraMinuscula}' é uma vogal.");
        break;
}
// Operador Ternário
int idade = 18
string mensagem = idade >= 18 ? "Maior de idade" : "Menor de idade";
Console.WriteLine(mensagem);
