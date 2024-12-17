using System.Diagnostics.CodeAnalysis;

namespace Assignment7._2._2
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string word = Console.ReadLine();

			char[] charArray = word.ToCharArray();
            char[] vowels = {'a', 'A', 'e', 'E', 'i', 'I', 'o', 'O', 'u', 'U' };
            int vowelCount = 0;
            int vowel1 = -1;
            int vowel2 = -1;

            for (int i = 0; i < charArray.Length; i++)
            {
                if (vowels.Contains(charArray[i]))
                {
                    vowelCount++;
                    if (vowel1 == -1)
                    {
                        vowel1 = i;
                    }
                    else if (vowel2 == -1)
                    {
                        vowel2 = i;
                    }
                    if (vowelCount > 2)
                    {
                        break;
                    }
                }
            }

            if (vowelCount == 0)
            {
				Console.WriteLine("The word doesn't contain any vowels.");
			}
            else if ( vowelCount == 1)
            {
                Console.WriteLine("The word only contains 1 vowel.");
			}
            else
            {
                char temp = charArray[vowel1];
                charArray[vowel1] = charArray[vowel2];
                charArray[vowel2] = temp;

                string newArray = new string(charArray);
				Console.WriteLine("Word after swapping the first two vowels: " + newArray);
			}
        }
    }
}
