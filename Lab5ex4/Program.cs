//Scrieti un program care va afisa caracterul cu numarul cel mai mare de aparitii dintr-un string citit
//de la tastatura, ignorand caseing-ul literelor.
//Exemplu:
//Input: Elena are mere
//Output: e apare de 5 ori

Console.WriteLine("Enter the string:");
string inputString = Console.ReadLine();

char mostCommonChar;
int maxCount;
CountMostCommonCharacter(inputString, out mostCommonChar, out maxCount);

Console.WriteLine($"The character '{mostCommonChar}' appears {maxCount} times in the string.");

 void CountMostCommonCharacter(string str, out char mostCommonChar, out int maxCount)
{
    int[] charCounts = new int[26];

    foreach (char c in str.ToLower()) 
    {
        if (char.IsLetter(c))
        {
            int index = c - 'a';
            charCounts[index]++;
        }
    }

    maxCount = 0;
    mostCommonChar = ' ';

    for (int i = 0; i < charCounts.Length; i++)
    {
        if (charCounts[i] > maxCount)
        {
            maxCount = charCounts[i];
            mostCommonChar = (char)('a' + i);
        }
    }
}