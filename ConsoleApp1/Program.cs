using ConsoleApp1.enums;

namespace ConsoleApp1
{
         delegate int MathOperation (int x , int y );
    internal class Program
    {
        static void Main(string[] args)
        {

          int x = 10, y = 20;

            int Add(int x, int y)
                => x + y;

            int sub(int x, int y)
               => x - y;


            MathOperation operation = Add;
            Console.WriteLine(operation(x, y));
        }
    }
}

