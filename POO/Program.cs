using DogName;
using System;

Console.WriteLine();
Console.WriteLine("Hello");
Console.WriteLine("{0:D},{1}°C.", DateTime.Today, 30);

/**************************************/

HelloFunct();
void HelloFunct()
{
    Console.WriteLine("Hello. Welcome");
}

/**************************************/

decimal d = CalculateTax(1000, "GB");
Console.WriteLine(d);
decimal CalculateTax(decimal amount, string twoLetterRegionCode)
{
    decimal rate = 0.0M;
    switch (twoLetterRegionCode)
    {
        case "CH": // Switzerland
            rate = 0.08M;
            break;
        case "DK": // Denmark
        case "NO": // Norway
            rate = 0.25M;
            break;
        case "GB": // United Kingdom
        case "FR": // France
            rate = 0.2M;
            break;
        case "HU": // Hungary
            rate = 0.27M;
            break;
        case "OR": // Oregon
        case "AK": // Alaska
        case "MT": // Montana
            rate = 0.0M;
            break;
        default: // most US states
            rate = 0.06M;
            break;
    }
    return amount * rate;
}

/**************************************/

Dog dog = new Dog();

/**************************************/
Dog sparky = new Dog();
Dog ricky = new Dog();

sparky.Name = "Sparky";
ricky.Name = "Ricky";

Console.WriteLine("Dog 1: " + sparky.Name);
Console.WriteLine("Dog 2: " + ricky.Name);

/**************************************/

DogCanine dogcanine = new DogCanine("Sparky");
Console.WriteLine($"Name: {dogcanine.Name}, Age: {dogcanine.Age}, Owner: {dogcanine.Owner}, Species: {DogCanine.Species}");

DogCanine dogcanine2 = new DogCanine("Ricky", "John");
Console.WriteLine($"Name: {dogcanine2.Name}, Age: {dogcanine2.Age}, Owner: {dogcanine2.Owner}, Species: {DogCanine.Species}");

dogcanine2.Name = "Max"; 

dogcanine.Age = 1;
Console.WriteLine($"Updated Age: {dogcanine.Age}");

dogcanine.Owner = "Ana";
Console.WriteLine($"New Owner of Sparky: {dogcanine.Owner}");

/**************************************/

dogcanine.EmitSound();
string categ = dogcanine.GetCategory();
Console.WriteLine(categ);
dogcanine.Eat();
dogcanine.Eat("bones");

Console.ReadLine();