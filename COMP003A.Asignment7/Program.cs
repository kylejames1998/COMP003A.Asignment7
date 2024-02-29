// Author: Kyle James
// Course: COMP003A 
// Purpose: Assignment 7 Code
namespace COMP003A.Asignment7
{
    internal class Program
    {
        static void Main(string[] args)
        {
            SectionSeparator("Array - CharacterCount Section");
            Console.WriteLine("Please enter a letter:");
            char userChar = Convert.ToChar(Console.ReadLine());
            Console.WriteLine("Please enter a word:");
            string userWord = (Console.ReadLine());
            int result = CharacterCount(userChar, userWord);
            Console.WriteLine($"There are {result} letter {userChar} in the word {userWord}");
            
            SectionSeparator("Array - IsPalindrome Section");
            Console.WriteLine("Please enter a word to check if it is a palindrome:");
            string userWord1 = (Console.ReadLine());
            bool palindrome = IsPalindrome(userWord1);
            Console.WriteLine($"Is the word {userWord1} palindrome: {palindrome}");

            SectionSeparator("List - Add Section");
            List<string> names = new List<string>();
            char userInput = default;
            do
            {
                Console.WriteLine("Please enter a name:");
                string name = Console.ReadLine();
                names.Add(name);

                Console.WriteLine("Press any key to add more or (e) to exit");
                userInput = Convert.ToChar(Console.ReadLine());
            } while (userInput != 'e');
        }

        /// <summary>
        /// Section separator method
        /// </summary>
        /// <param name="section">String input for section name</param>
        static void SectionSeparator(string section)
        {
            Console.WriteLine("".PadRight(60, '*') + $"\n\t{section} Section\n" + "".PadRight(60, '*'));
        }

        /// <summary>
        /// Counts how many times a character appears in a string
        /// </summary>
        /// <param name="characterInput">The character you want looked for</param>
        /// <param name="word">The string that you want to traverse</param>
        /// <returns>Returns the amount of times the specified character appears in the word</returns>
        static int CharacterCount(char characterInput, string word)
        {
            characterInput = char.ToLower(characterInput);
            word = word.ToLower();
            int count = 0;

            foreach (char c in word)
            {
                if (c == characterInput)
                {
                    count++;
                }
            }
            return count;
        }

        /// <summary>
        /// Traverses a string and checks for if the word is the same backwards and forwards
        /// </summary>
        /// <param name="word">Accepts a string parameter</param>
        /// <returns>Returns true if the word is the same, returns false if it's not</returns>
        static bool IsPalindrome(string word)
        {
            string lowercase = word.ToLower();
            string reversedWord = "";

            for (int i = lowercase.Length - 1; i >= 0; i--)
            {
                reversedWord += lowercase[i];
            }

            if (reversedWord == lowercase)
            {
                return true;
            } 
            else return false;
        }

        /// <summary>
        /// Traverses a list and prints each item in the console
        /// </summary>
        /// <param name="list">Accepts a list of strings</param>
        static void TraverseList(List<string> list)
        {
            foreach (string word in list)
            {
                Console.WriteLine(word);
            }
        }

        /// <summary>
        /// Traverses a list and prints each item in the console in reverse order
        /// </summary>
        /// <param name="list">Accepts a list of strings</param>
        static void TraverseListReverse(List<string> list)
        {
            for (int i = list.Count - 1; i >= 0; --i)
            {
                Console.WriteLine(list[i]);
            }
        }
    }
}
