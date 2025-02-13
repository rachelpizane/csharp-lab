int c = 10;
double d = c;

Console.WriteLine(d.ToString("F1"));

double e = 9.8;
int f = (int) e;
Console.WriteLine(f);

int r = int.Parse("15");
Console.WriteLine(r);

//---------------------------
string input = Console.ReadLine();
double amount = double.Parse(input);

double result = amount * 2;

Console.WriteLine($"O resultado é {result}");