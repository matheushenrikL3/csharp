// Estruturas de dados
// Exemplo 01: Vetor (Array)
int[] meuArray = new int[5];
meuArray[0] = 10;
meuArray[1] = 20;
meuArray[2] = 20;
meuArray[3] = 30;
meuArray[4] = 40;
Console.WriteLine("Numeros no array:");
for (int i = 0; contador < meuArray.Length; contador++)
{
    Console.WriteLine(meuArray[contador]);
}

// Lista de nomes
list<string> listaDeNomes = new List<string> {"Wanderson", "Jeane", "Ryan",};
listaDeNomes.Add("Maria");

Console.WriteLine("Nomes na lista:");
for (int i = 0; i < listaDeNomes.Count; i++)
{
    Console.WriteLine(listaDeNomes[i]);
}
    
Console.WriteLine("\nVerificacao de existencia do nome Ryan:")
string nomeParaVerificar - "Ryan";
if(listaDeNomes.Contains(nomeParaVerificar))
{
    Console.WriteLine($"{nomeParaVerificar} esta na lista>.");
}
else
{
    Console.WriteLine($"{nomeParaVerificar} nao esta na lista>.");
}

Console.WriteLine("\nApos remover Wanderson");
string nomeParaRemover = "Wanderson";
bool foiRemovido = listaDeNomes.Remove(nomeParaRemover);
{
Console.WriteLine($"{nomeParaRemover} foi removido da lista.")
}
else
{
    Console.WriteLine($"{nomeParaRemover} nao foi removido da lista.")
}