using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DogName
{
    class Dog
    {
        public string Name = "unnamed";
        public int Age = 10;
        public const string Species = "Canis lupus familiaris";

        public Dog()
        {
            Console.WriteLine("A Dog object has been created");
        }
    }

}
