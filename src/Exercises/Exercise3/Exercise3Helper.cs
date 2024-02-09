namespace Exercises.Exercise3
{
    public static class Exercise3Helper
    {
        public static void CreateString(string str1, string str2)
        {
            // print string
            Console.WriteLine(str1);
            Console.WriteLine(str2);
        }

        public static int StringLength(string str)
        {
            Console.WriteLine("string: " + str);

            // get length of str
            int length = str.Length;

            Console.WriteLine("Length: " + length);
            return length;
        }

        public static int CalculateThings(int num)
        {
            num += 9;
            Console.WriteLine(num);
            num -= 4;
            Console.WriteLine(num);
            num *= 2;
            Console.WriteLine(num);
            num /= 4;
            Console.WriteLine(num);
            num %= 3;
            Console.WriteLine(num);
            return num;
        }

        public static int AddNumber(int a, int b)
        {
            int sum = a + b;
            return sum;
        }

        public static int CalculateNumber(int num)
        {
            if (num % 2 == 0)
                return num + 10;
            else
                return num * 30;
        }

        public static string JoinStrings(string str1, string str2)
        {

            Console.WriteLine("string str1: " + str1);
            Console.WriteLine("string str2: " + str2);

            // join two strings
            string joinedString = string.Concat(str1, str2);

            Console.WriteLine("Joined string: " + joinedString);
            return joinedString;
        }

        public static bool CompareStrings(string str1, string str2)
        {
            // compare str1 and str2
            bool result1 = str1.Equals(str2);

            Console.WriteLine("string str1 and str2 are equal: " + result1);
            return result1;
        }

        public static string InterpolateString(string str1)
        {
            // string interpolation
            string message = $"Welcome to {str1}";

            Console.WriteLine(message);
            return message;
        }

        public static string[] ProcessLines(string[] lines)
        {
            for (var i = 0; i < lines.Length; i += 1)
            {
                //reemplazar
                var split = lines[i].Split(";");
                foreach (string item in split)
                {
                    bool isInt = int.TryParse(item, out int num);
                    if (isInt)
                    {
                        num = CalculateNumber(num);
                        lines[i] = lines[i].Replace(item, num.ToString());
                    }
                }
            }
            return lines;
        }
    }
}
