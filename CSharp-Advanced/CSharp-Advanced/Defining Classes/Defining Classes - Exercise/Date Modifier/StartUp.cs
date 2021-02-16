using System;

namespace DefiningClasses
{
    public class StartUp
    {
        static void Main(string[] args)
        {
            string first_input = Console.ReadLine();
            string second_input = Console.ReadLine();
            DateModifier firstDate = new DateModifier(first_input);
            DateModifier secondDate = new DateModifier(second_input);
            Console.WriteLine(DateModifier.Difference(first_input, second_input));
        }
    }
}
