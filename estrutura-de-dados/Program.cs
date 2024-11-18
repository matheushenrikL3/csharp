// Estruturas de dados
// Exemplo 01: Vetor (Array)
// int[] meuArray = new int[5];
// meuArray[0] = 10;
// meuArray[1] = 20;
// meuArray[2] = 20;
// meuArray[3] = 30;
// meuArray[4] = 40;
// Console.WriteLine("Numeros no array:");
// for (int i = 0; contador < meuArray.Length; contador++)
// {
//     Console.WriteLine(meuArray[contador]);
// }

// // Lista de nomes
// list<string> listaDeNomes = new List<string> {"Wanderson", "Jeane", "Ryan",};
// listaDeNomes.Add("Maria");

// Console.WriteLine("Nomes na lista:");
// for (int i = 0; i < listaDeNomes.Count; i++)
// {
//     Console.WriteLine(listaDeNomes[i]);
// }

// Console.WriteLine("\nVerificacao de existencia do nome Ryan:")
// string nomeParaVerificar - "Ryan";
// if(listaDeNomes.Contains(nomeParaVerificar))
// {
//     Console.WriteLine($"{nomeParaVerificar} esta na lista>.");
// }
// else
// {
//     Console.WriteLine($"{nomeParaVerificar} nao esta na lista>.");
// }

// Console.WriteLine("\nApos remover Wanderson");
// string nomeParaRemover = "Wanderson";
// bool foiRemovido = listaDeNomes.Remove(nomeParaRemover);
// {
// Console.WriteLine($"{nomeParaRemover} foi removido da lista.")
// }
// else
// {
//     Console.WriteLine($"{nomeParaRemover} nao foi encontrado na lista.")
// }

// Console.WriteLine("\nNomea na lista apos a remoção: ");
// for (int 1 = 0; 1 < listaDeNomes.Count; i++)
// {
//     Console.WriteLine(listaDeNomes[i]);
// }

// Conjunto (Set) os elementos sao unicos, ou seja, nao permite inserir elementos repetidos no conjunto.

// HashSet<int> conjunto = new HashSet<int> {1,2,3};
// conjunto.Add(4);
// conjunto.Add(2);
// Console.WriteLine("\nElentos do Conjunto:");
// foreach (int elemento in conjunto)
// {
//     Console.WriteLine(elemento);
// }

// HashSet<string> frutas = new HashSet<string> {"maçã","Banana","Laranja"};
// frutas.Add("Uva");
// frutas.Add("maçã");

// Console.WriteLine("\nElementos do Conjunto:");
// foreach (string fruta in frutas);
// {
//     Console.WriteLine(fruta);
// }
// Console.WriteLine("\nVerificacao de existencia:");
// Console.WriteLine(frutas.Contains("Banana") ? "Banana esta no conjunto" : "Banana nao esta no conjuntos");

// frutas.Remove("Laranja");
// Console.WriteLine("\nApos remover Laranja:");
// foreach(string fruta in frutas)
// {
//     Console.WriteLine(fruta);
// }

// 1 
//int [] array = { 1, 2, 3, 4, 5 };
//int soma = 0
//foreach (int numero in numeros)
//{
//    soma += numero;
//}
// {
//     Console.WriteLine($"A soma dos elementos e );
// }

//3 
// List<int> numeros = new List<int> {1, 2, 2, 3, 4, 4, 5};
// HashSet<int> conjunto = new HashSet<int>(numeros);
// foreach (int elemento in conjunto)
// {
//     Console.WriteLine(elemento);
// }

//4
// HashSet<string> frutas = new HashSet<string> {"maçã","Banana","Laranja"};

// Console.WriteLine("\nElementos do Conjunto:");
// foreach (string fruta in frutas)
// {
//     Console.WriteLine(fruta);
// }
// Console.WriteLine("\nVerificacao de existencia:");
// Console.WriteLine(frutas.Contains("Banana") ? "Banana esta no conjunto" : "Banana nao esta no conjuntos");

//5
// List<int> numeros = new List<int>();
// numeros.Add (1);
// numeros.Add (2);
// numeros.Add (3);
// numeros.Add (4);
// numeros.Add (5);
// Console.WriteLine("\nElentos do Conjunto:");
// foreach (int elemento in numeros)
// {
//     Console.WriteLine(elemento);
// }