string nome = "Joana";
if(nome.Length > 5)
{

    Console.WriteLine("Verdadero");
} 
else 
{
    Console.WriteLine("Falso");
}

// -------------------------
object o = "3";
int j = 4;

if(o is int i) // Se valor do "o" é inteiro, então atribui a variável "i"
{
    Console.WriteLine(i * j);
}
else
{
    Console.WriteLine("Não é possível multiplicar");
}

//---------------------------

string sIdade = Console.ReadLine() ?? "0";

int idade = int.Parse(sIdade);

if ( idade < 16)
{
    Console.WriteLine("You are too young for most rights");
} 
else if (idade <= 17)
{
    Console.WriteLine("You can drive in some countries ");
}
else if (idade <= 20)
{
    Console.WriteLine("You can vote and drive");
}
else if (idade <= 34) 
{
    Console.WriteLine("You can drink");
}
else if (idade >= 35){
    Console.WriteLine("You can be president");
} 

// -------------------------
object entrada = 2.4f;

if(entrada is float f)
{
    int entradaInteiro =  (int) f;

    if (entradaInteiro > 0) 
    {
        Console.WriteLine("O número inteiro é positivo");
    }
    else 
    {
        Console.WriteLine("O número inteiro é negativo");
    }
} 
else 
{
    Console.WriteLine("A entrada não é um float");
}
// -------------------------
string op = Console.ReadLine() ?? "-1";

switch(op)
{
    case "a":
        Console.WriteLine("Opção A");
        break;
    case "b":
        Console.WriteLine("Opção B");
        break;
    default:
        Console.WriteLine("Opção inválida");
        break;
}