using MyConsoleApp;

int a = 9;
int b = a;

Console.WriteLine(a);
Console.WriteLine(b);

bool notif = true;
bool emailNotif = notif; // Aqui ele armazena uma copia de notif no emailNotif.

emailNotif = false;

Console.WriteLine(emailNotif); //false
Console.WriteLine(notif); // true;

char letter = 'A';
char letterCopy = letter;

letterCopy = 'B';

Console.WriteLine(letterCopy);
Console.WriteLine(letter);

//--------------------------------------------------------------

OrderStatus todayStatus = OrderStatus.Processing;
OrderStatus copiedStatus = todayStatus;

Console.WriteLine(todayStatus);
Console.WriteLine(copiedStatus);

copiedStatus = OrderStatus.Shipped;

Console.WriteLine(todayStatus);
Console.WriteLine(copiedStatus);

//--------------------------------------------------------------

object obj1 = "Hello World";
object obj2 = obj1;

obj1 = "Olá Mundo!!";
Console.WriteLine(obj2);
Console.WriteLine(obj1);
Console.WriteLine(obj2 == obj1);

//--------------------------------------------------------------

int? x = null;
int y = x ?? 5;

Console.WriteLine(y); // 5

string? texto = null;

Console.WriteLine(texto);
//--------------------------------------------------------------

Console.WriteLine("Insira o seu nome: ");
string? name = Console.ReadLine();
Console.WriteLine(name);