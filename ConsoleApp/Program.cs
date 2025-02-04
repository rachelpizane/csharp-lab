
double a = 1.5, b = 2,c = -3, d;

Console.WriteLine(a);
Console.WriteLine(b);

d = 5.6;

Console.WriteLine(d);

d = default;
Console.WriteLine(d); // Retorna zero.

double x = (-b + Math.Sqrt(b * b - 4 * c)) / (2 * a);

Console.WriteLine(x);

short n1 = -3;
int n2 = 4;
long n3 = 4L;

float f1 = 3.14f;
double f2 = 3.15673;

Console.WriteLine(f1);

bool isValid = true;
string statusMessage = "Valid: " + isValid;

Console.WriteLine(statusMessage); // Retorna Valid: True

string texto = "Hello";
texto = texto + " World";

Console.WriteLine(texto);


(int X, int Y) point = (10, 5);

Console.WriteLine($"X: {point.X}, Y: {point.Y}");

const int Fixo = 45;

Console.WriteLine(Fixo);

object obj1 = 35;
object obj2 = "oii";

Console.WriteLine(obj1.GetType());
Console.WriteLine(obj2.GetType());

int n = 3;
int m = n++;

Console.WriteLine(n); // 4
Console.WriteLine(m); // 3

int p = 3;
int q = ++p;

Console.WriteLine(p); // 4
Console.WriteLine(q); // 4

int aa = 4;
int bb = 2;

double resultado = aa / bb;

Console.WriteLine(true | false);

string max = (10 > 4) ? "sim" : "não"; // ternário

Console.WriteLine(max);