
using System;

namespace NewProject
{
    public class Program
    {
        static void Main(string[] args)
        {
            AddFractions();
            AddFractions();
            AddFractions();
        }









































        public static void AddFractions()
        {
            Console.WriteLine("The program will add 2 fraction numbers");
            Console.WriteLine("Input an expression (e.g. 2/3+3/4+5/7) then enter: ");

            // Function
            int num1, dem1, num2, dem2;
            num1 = GetIntNumberFromKeyboard("Please input numerator of num1");
            dem1 = GetIntNumberFromKeyboard("Please input denominator 1");
            num2 = GetIntNumberFromKeyboard("Please input numerator 1");
            dem2 = GetIntNumberFromKeyboard("Please input denominator 2");

            int resNum, resDem;

            resNum = num1 * dem2 + num2 * dem1; //same
            resNum = CalculateNumeratorOfAdditionFraction(num1, dem2, num2, dem1); // same

            resDem = dem1 * dem2;


            Console.Write("Press any key to quit...");
            Console.ReadKey(true);
        }




        public static int CalculateNumeratorOfAdditionFraction(int a, int b, int c, int d)
        {
            int r;

            r = a * b + c * d; // how it work

            return r; // output
        }

        public static int GetIntNumberFromKeyboard(string comment) // input comment, output int
        {
            Console.WriteLine(comment);
            int number;
            number = int.Parse(Console.ReadLine());
            return number;
        }

















        public static RationalNumber InputRationalNumberExpression(string rationalString)
        {
            string[] addArray = rationalString.Split('+');
            RationalNumber rationalNumber = GetRationalNumber(addArray[0]);
            for (int i = 1; i < addArray.Length; i++)
            {
                rationalNumber = RationalNumber.Add(rationalNumber, GetRationalNumber(addArray[i]));
            }
            return rationalNumber;
        }
        public static RationalNumber GetRationalNumber(string rationalString)
        {
            RationalNumber rationalNumber = new RationalNumber();

            string[] stringArray = rationalString.Split('/');
            rationalNumber.Numerator = int.Parse(stringArray[0]);
            rationalNumber.Denominator = int.Parse(stringArray[1]);
            return rationalNumber;
        }
        public static RationalNumber InputRationalNumber(string comment)
        {
            RationalNumber rationalNumber = new RationalNumber();
            Console.Write(comment);

            string rationalString = Console.ReadLine();
            string[] stringArray = rationalString.Split('/');
            rationalNumber.Numerator = int.Parse(stringArray[0]);
            rationalNumber.Denominator = int.Parse(stringArray[1]);
            return rationalNumber;
        }
        public static RationalNumber InputRationalNumberSimple(string comment1, string comment2)
        {
            RationalNumber rationalNumber = new RationalNumber();
            Console.Write(comment1);
            rationalNumber.Numerator = int.Parse(Console.ReadLine());

            Console.Write(comment2);
            rationalNumber.Denominator = int.Parse(Console.ReadLine());
            return rationalNumber;
        }
    }
}
