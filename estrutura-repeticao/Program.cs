// Estrutura de repeticao (loop)

// Random numeroAleatorio = new Random();
// int numero = numeroAleatorio.Next(1, 101);
// int contador = 0;
// Console.WriteLine($"Numero Alvo: {contador}");
// while (contador <= numero)
// {
//     Console.WriteLine($"Contador: {contador}");
//     contador++;
// }
// Console.WriteLine($"Contador atingiu o numero alvo: {contador}");

// // Estrutura de Repeticao do-while

// int numero = 0;
// do
// {
//     Console.WriteLine($"Numero: {numero}");
//     numero++;
// } while (numero < 10);

// // EStrutura de repeticao For

// for (int i = 0; i < 10; i++)
// {
//     Console.WriteLine($"Valor de i: {i}");
// }

// // Estrutura de repeticao ForEach
// string[] nomes = {"Jean", "Rodrigo", "Vitor"};
// foreach (string nome in nomes)
// {
//     Console.WriteLine (nome);
// }

// Exercicios de estrutura de repeticao
// 1 crie um algoritimo que some todos os numeros pares de 1 a 100 e exiba o resultado no console.

// 2 crie um algoritimo que faca uma vcontagem regressiva de 10 a 1 e exiba "Decolar!" ao final.

// 3 crie um algoritimo que conte o numero de vogais (a, e, i, o, u)na palavra e exiba o resultado.

// 4 crie um algoritimo que solicite uma palavra ou frase do usuario, verifique se e um palindromo

// 5 crie um algoritimo onde o computador escolhe um numero aleatorio entre 1 e 100, e o usuario deve
// advinhar. apos cada tentativa, o prorama indica se o numero e maior ou menor.

//1

for (int i = 1; i <= 100; i++)
    {
    Console.WriteLine(i);
    }

//2
// for (int i = 10; i > 0; i--)
// {
//      Console.WriteLine($"Valor de i: {i}");
// }