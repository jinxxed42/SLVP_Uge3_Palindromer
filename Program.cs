// See https://aka.ms/new-console-template for more information
Console.WriteLine("Please input a string: ");
String toCheck = Console.ReadLine();

Checker ch = new Checker();

if (int.TryParse(toCheck, out int toCheckInt))
{
    if (ch.check(toCheckInt)) 
    {
        Console.WriteLine("It's a palindrome.");
    }
    else
    {
        Console.WriteLine("It's not a palindrome.");
    }
}
else if(double.TryParse(toCheck, out double toCheckDouble)) 
{ 
    if (ch.check(toCheckDouble))
    {
        Console.WriteLine("It's a palindrome.");
    }
    else
    {
        Console.WriteLine("It's not a palindrome");
    }
}
else 
{ 
    if (ch.check(toCheck))
    {
    Console.WriteLine("It's a palindrome.");
    }
    else
    {
    Console.WriteLine("It's not a palindrome.");
    }
}


// ALL TESTS SUCCESSFUL
/**
Console.WriteLine();
Console.WriteLine("Test input - all must be true: ");
Console.Write("abba : ");
Console.WriteLine(ch.check("abba"));

Console.Write("12321 : ");
Console.WriteLine(ch.check(12321));

Console.Write("123.21 : ");
Console.WriteLine(ch.check(123.21));

Console.Write("Stack Cats : ");
Console.WriteLine(ch.check("Stack Cats"));

Console.Write("A man, a plan, a canal - Panama : ");
Console.WriteLine(ch.check("A man, a plan, a canal – Panama"));
**/


public class Checker
{
    public Boolean check(string s)
    {
        string[] ignoredChars = { " ", "_", "–", "—", "!", "\"", "#", "¤", "%", "&", "/", "(", ")", "=", "+", "`", "\\", ",", "." };

        string toCheckTrimmed = s;

        for (int i = 0; i < ignoredChars.Length; i++)
        {
            toCheckTrimmed = toCheckTrimmed.Replace(ignoredChars[i], "");
        }

        char[] strArray = toCheckTrimmed.ToCharArray();

        Array.Reverse(strArray);

        String reverseString = new string(strArray);

        toCheckTrimmed = toCheckTrimmed.ToLower();
        reverseString = reverseString.ToLower();
        
        if (toCheckTrimmed.Equals(reverseString))
        {
            return true;
        }
        else
        {
            return false;
        }
        
    }

    public Boolean check(int i)
    {
        return check(i.ToString());
    }

    public Boolean check(double d)
    {
        string s = d.ToString();
        s.Replace(",", "");
        s.Replace(".", "");
        return check(s);
    }
}