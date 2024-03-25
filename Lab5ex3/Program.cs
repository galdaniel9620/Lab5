//Scrieti un program care va numara toate aparitiile unui caracter intr-un sir
//de caractere. Atat caracterul cautat cat si sirul de caractere vor fi citite de la
//tastatura

Console.WriteLine("Enter the string:");
string inputString = Console.ReadLine();

Console.WriteLine("Enter the character to count:");
char targetChar = Console.ReadKey().KeyChar;
Console.WriteLine(); // New line for better formatting

int count = CountOccurrences(inputString, targetChar);
Console.WriteLine($"The character '{targetChar}' appears {count} times in the string.");

int CountOccurrences(string str, char target)
{
    int count = 0;
    foreach (char c in str)
    {
        if (c == target)
        {
            count++;
        }
    }
    return count;
}

