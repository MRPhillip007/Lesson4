using System.Linq;
using System.Text;

namespace Lesson4Homework
{
    class Homework
    {
        static void Main()
        {
            //Console.WriteLine(FindMax(34, 78));
            //Console.WriteLine(FindMax(987, 5555, 98576));
            //Console.WriteLine(FindMax(674568, 9723, 1, 9997));
            //Console.WriteLine(FindMin(-237846,-234, -9));
            //Console.WriteLine(FindMin(-237846, -1, -9865, -8));

            int sum;
            Console.WriteLine(TrySumIfOdd(1, 4, out sum));
            Console.WriteLine("Result: {0}", sum);

            Console.WriteLine();
            Console.WriteLine("<= Repeat method calling =>");
            Console.WriteLine(Repeat("Hello", 3));

        }
        static int FindMax(int num1, int num2)
        {
           return Math.Max(num1, num2);
        }

        static int FindMin(int num1, int num2)
        {
            return Math.Min(num1, num2);
        }

        // FindMax overloads.
        static int FindMax(int num1, int num2, int num3)
        {
            int maxValue = num1 > num2 ? num1 : num2;
            return maxValue > num3 ? maxValue : num3;
        }

        static int FindMax(int num1, int num2, int num3, int num4)
        {
            int max1 = num1 > num2 ? num1 : num2;
            int max2 = num3 > num4 ? num3 : num4;
            int result = max1 > max2 ? max1 : max2;

            return result;
        }

        // FindMin overloads.

        static int FindMin(int num1, int num2, int num3)
        {
            int minValue = num1 < num2 ? num1 : num2;
            return minValue < num3 ? minValue : num3;
        }

        static int FindMin(int num1, int num2, int num3, int num4)
        {
            int min1 = num1 < num2 ? num1 : num2;
            int min2 = num3 < num4 ? num3 : num4;
            int result = min1 < min2 ? min1 : min2;

            return result;
        }

        static bool TrySumIfOdd(int num1, int num2, out int result)
        {
            result = num1 + num2;
            bool isOdd = !(result % 2 == 0);
            return isOdd;
        }

        // Extra:
        static string Repeat(string str, int counter)
        {
            StringBuilder stringBuilder = new StringBuilder(str);
            for (int i = 1; i < counter; i++)
            {
                stringBuilder.Append(str);
            }
            return stringBuilder.ToString();
        }
    }
}
//checked
