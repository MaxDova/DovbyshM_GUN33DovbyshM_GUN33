using System;

namespace DomashKa
{ 
class Program
{
    static void Main(string[] args)
    {



        if (int.TryParse(Console.ReadLine(), out int a))
        {
            // обработка
        }
        else
        {
            Console.WriteLine("Нит");
            return;
        }
        if (int.TryParse(Console.ReadLine(), out int b))
        {
            // обработка
        }
        else
        {
            Console.WriteLine("Нит");
            return;
        }


        var s = Console.ReadLine();
        var boolVar = true;
        if (s.Length == 0 || s.Length > 1)
        {
            Console.WriteLine("Wrong sign");
            return;
        }


        switch (s[0])
        {
            case '&':
                Console.WriteLine(("Result of {0} & {1} = {2}", a, b, a & b));
                Console.WriteLine(Convert.ToString(a & b, 10));
                Console.WriteLine(Convert.ToString(a & b, 2));
                Console.WriteLine(Convert.ToString(a & b, 16));
                break;
            case '|':
                Console.WriteLine("Result of {0} | {1} = {2}", a, b, a | b);
                Console.WriteLine(Convert.ToString(a | b, 10));
                Console.WriteLine(Convert.ToString(a | b, 2));
                Console.WriteLine(Convert.ToString(a | b, 16));
                break;
            case '^':
                Console.WriteLine("Result of {0} ^ {1} = {2}", a, b, a ^ b);
                Console.WriteLine(Convert.ToString(a ^ b, 10));
                Console.WriteLine(Convert.ToString(a ^ b, 2));
                Console.WriteLine(Convert.ToString(a ^ b, 16));
                break;
            default:
                Console.WriteLine("Wrong sign");
                break;
        }


    }


}
}