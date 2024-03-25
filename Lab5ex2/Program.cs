//Scrieti un program care sa verifice daca un sir de caractere citit de la
//tastatura este sau nu palindrom.

Console.WriteLine("Enter a string:");
string input = Console.ReadLine();

if (IsPalindrome(input))
{
    Console.WriteLine("The input string is a palindrome.");
}
else
{
    Console.WriteLine("The input string is not a palindrome.");
}
    
 bool IsPalindrome(string str)
{
    int left = 0;
    int right = str.Length - 1;

    while (left < right)
    {
        if (str[left] != str[right])
        {
            return false;
        }
        left++;
        right--;
    }
    return true;
}