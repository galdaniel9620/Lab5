//Un program care va normaliza un sir de caractere citit de la tastatura astfel incat fiecare cuvant din
//sir sa inceapa cu MAJUSCULA, restul literelor fiind transformate in litere mici.
//Exemplu:
//Input: Ana ARE mErE
//Rezultat: Ana Are Mere


Console.WriteLine("Enter the string:");
string inputString = Console.ReadLine();

string normalizedString = NormalizeString(inputString);

Console.WriteLine("Normalized string:");
Console.WriteLine(normalizedString);

string NormalizeString(string str)
{
    char[] charArray = str.ToLower().ToCharArray();
    bool capitalizeNext = true;

    for (int i = 0; i < charArray.Length; i++)
    {
        if (char.IsLetter(charArray[i]))
        {
            if (capitalizeNext)
            {
                charArray[i] = char.ToUpper(charArray[i]);
                capitalizeNext = false;
            }
            else
            {
                charArray[i] = char.ToLower(charArray[i]);
            }
        }
        else
        {
            capitalizeNext = true;
        }
    }

    return new string(charArray);
}