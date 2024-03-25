//Scrieti un program care va afisa pozitia unui substring intr-un string, ambele siruri de caractere fiind citite de la tastatura

Console.WriteLine("Enter the main string:");
string text = Console.ReadLine();

Console.WriteLine("Enter the substring you want to search for:");
string subtext = Console.ReadLine();

int position = SearchSubstring(text, subtext);

if (position != -1)
{
    Console.WriteLine($"The substring \"{subtext}\" was found at position {position} in the main string.");
}
else
{
    Console.WriteLine($"The substring \"{subtext}\" was not found in the main string.");
}

int SearchSubstring(string text, string subtext)
{
    for (int i = 0; i <= text.Length - subtext.Length; i++)
    {
        bool found = true;
        for (int j = 0; j < subtext.Length; j++)
        {
            if (text[i + j] != subtext[j])
            {
                found = false;
                break;
            }
        }
        if (found)
        {
            return i;
        }
    }
    return -1;
}