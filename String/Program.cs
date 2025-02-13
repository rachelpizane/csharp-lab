string text = "Isso é um texto";

Console.WriteLine(text.Length); // 16
Console.WriteLine("Upper: " + text.ToUpper()); // ISSO É UM TEXTO
Console.WriteLine("Lower: " + text.ToLower()); // isso é um texto

Console.WriteLine("Replace: " + text.Replace("texto", "textinho")); // Isso é um textinho
Console.WriteLine("Substring: " + text.Substring(5)); // é um texto

Console.WriteLine("Split: " + text.Split(' ')[0]); // Isso

Console.WriteLine("StartsWith: " + text.StartsWith("Isso")); // True
Console.WriteLine("EndsWith: " + text.EndsWith("texto")); // True
Console.WriteLine("Contains: " + text.Contains("texto")); // True

string textoComeEspaco = "   Texto com espaços   ";
Console.WriteLine("Trim: " + textoComeEspaco.Trim()); // Texto com espaços

string texto1 = "Olá";
string texto2 = "Olá";

Console.WriteLine("Equals: " + texto1.Equals(texto2)); // True
Console.WriteLine("Equals (=): "  + (texto1 == texto2)); // True