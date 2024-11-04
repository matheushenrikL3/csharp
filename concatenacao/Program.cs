// See https://aka.ms/new-console-template for more information
Console.WriteLine("Hello, World!");

// Concatenção
string nome = "erick";
string saudacao = "Ola," + nome + "! Bem-vindo.";
Console.WriteLine(saudacao);

// Iterpolcao de strings($)
string nome = "erick";
string saudacao = $"Ola, {nome}! Bem-vindo.";
Console.WriteLine(saudacao);

// Operador GetType()
int numero = 5;
Console.WriteLine(numero.GetType());

// Palavra-chave typeof
Console.WriteLine(typeof(int));

// Metodo parse
string valorTexto = "100";
Console.WriteLineparse("A variavel valorTexto e do tipo: " + valorTexto.GetType());

int numero = int.Parse(valorTexto);
Console.WriteLineparse(numero);
Console.WriteLineparse("A variavel numeroParse e do tipo: " + numero.GetType());