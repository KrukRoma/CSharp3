namespace CSharp3
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //1
            //    string originalString = "Hello, world!";
            //    string stringToInsert = " wonderful";
            //    int position = 6;

            //    if (position >= 0 && position <= originalString.Length)
            //    {
            //        string result = originalString.Insert(position, stringToInsert);
            //        Console.WriteLine("Result: " + result);
            //    }
            //    else
            //    {
            //        Console.WriteLine("Invalid position for inserting the string.");
            //    }

            //    //2
            //    Console.WriteLine("Enter a word:");
            //    string input = Console.ReadLine();

            //    if (IsPalindrome(input))
            //    {
            //        Console.WriteLine($"\"{input}\" is a palindrome.");
            //    }
            //    else
            //    {
            //        Console.WriteLine($"\"{input}\" is not a palindrome.");
            //    }
            //}

            //static bool IsPalindrome(string input)
            //{
            //    string cleanedInput = RemoveNonAlphanumeric(input).ToLower();

            //    int length = cleanedInput.Length;
            //    for (int i = 0; i < length / 2; i++)
            //    {
            //        if (cleanedInput[i] != cleanedInput[length - 1 - i])
            //        {
            //            return false;
            //        }
            //    }
            //    return true;
            //}

            //static string RemoveNonAlphanumeric(string input)
            //{
            //    char[] arr = input.ToCharArray();
            //    arr = Array.FindAll<char>(arr, (c => char.IsLetterOrDigit(c)));
            //    return new string(arr);
            //}

            //3
            string input = "Дано текст. Визначте відсоткове відношення малих і великих літер до загальної кількості символів в ньому.";

            (double lowerPercentage, double upperPercentage) = CalculateLetterPercentages(input);

            Console.WriteLine($"Percentage of lowercase letters: {lowerPercentage:F2}%");
            Console.WriteLine($"Percentage of uppercase letters: {upperPercentage:F2}%");
        }

        static (double, double) CalculateLetterPercentages(string input)
        {
            if (string.IsNullOrEmpty(input))
            {
                return (0, 0);
            }

            int totalChars = input.Length;
            int lowerCount = 0;
            int upperCount = 0;

            foreach (char c in input)
            {
                if (char.IsLower(c))
                {
                    lowerCount++;
                }
                else if (char.IsUpper(c))
                {
                    upperCount++;
                }
            }

            double lowerPercentage = (double)lowerCount / totalChars * 100;
            double upperPercentage = (double)upperCount / totalChars * 100;

            return (lowerPercentage, upperPercentage);
        }
    }
}
