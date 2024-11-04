
double resultado1 = 10 + 8 + 12 / 3;
Console.WriteLine(resultado1);

double resultado2 = (10 + 8 + 12) / 3;
Console.WriteLine(resultado2);

double resultado3 = (2 + 8) * 2 / 4;
Console.WriteLine(resultado3);

// Operadores Logicos

// E Logico (&&)
bool a = true;
bool b = false;
Console.WriteLine(a && b);

// OR Logico || (OU)
bool a1 = true;
bool a2 = true;
Console.WriteLine(a1 || b2);

// NOT Logico !(NÃO)
bool a3 = true;
Console.WriteLine(!a3);

// XOR Logico ^ (OU Exclusivo)
bool a4 = true;
bool b4 = false;
Console.WriteLine(a4 ^ b4);

// Exemplo de Precedencia
bool a5 = true;
bool b5 = false;
bool c5 = false;
bool resultado = !a5 || (b5 && c5)
Console.WriteLine(resultado);