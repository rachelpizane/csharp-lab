int cont = 1;

while(cont <= 5)
{
    Console.WriteLine("Number: " + cont);
    cont++;

    if (cont == 3) continue;
    if (cont == 4) break;
}


// -----------------
int number;
do
{
    Console.Write("Escreva um número positivo: ");
    number = Convert.ToInt32(Console.ReadLine());

} 
while (number <= 0);

Console.WriteLine($"Número positivo: {number}");

Console.ReadLine();


// -------------------
char k;
do
{
    Console.WriteLine("Clique em 'x' para sair");
    k = Console.ReadKey().KeyChar;
}
while (k != 'x');

// -------------------
for (int i = 1; i <= 5; i++)
{
    Console.WriteLine($"Iteração: {i}");
}

// -------------------

string word = "Hello World";

foreach (char ch in word)
{
    Console.WriteLine($"Char: {ch}");
}