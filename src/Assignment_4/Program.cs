using System;

namespace Assignment4
{
    class Program
    {
        public void ShowValueType(int val)
        {
            val *= val;
            Console.WriteLine("Value inside the show value type function " + val);

        }
        public void ShowRef(ref int val)
        {
            val *= val;
            Console.WriteLine("Value inside the show ref function " + val);

        }

        public void ShowOut(out int val)
        {
            int square = 5;
            val = square;
            val *= val;
            Console.WriteLine("Value inside the show out function " + val);
        }

        static void Main(string[] args)
        {
            int val = 50;

            Program program = new Program();

            Console.WriteLine("Value before calling the function " + val);
            program.ShowValueType(val);
            Console.WriteLine("Value after calling the function " + val);

            Console.WriteLine("\nValue before calling the function " + val);
            program.ShowRef(ref val);
            Console.WriteLine("Value after calling the function " + val);

            int outVal;
            Console.WriteLine("\nValue before passing out variable " + val);
            program.ShowOut(out outVal);
            Console.WriteLine("Value after receiving the out variable " + outVal);
        }
    }
}
