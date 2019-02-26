using System;

namespace AllUniqueWB
{
    class Program
    {
        static void Main(string[] args)
        {
           SpecialCharacterChecker special = new SpecialCharacterChecker();
           Console.WriteLine(special.containsSpecialChar("wording!"));

        }
    }
}
