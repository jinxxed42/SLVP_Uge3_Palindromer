// See https://aka.ms/new-console-template for more information
Console.WriteLine("Please input a string to check if it's a palindrome: ");
String toCheck = Console.ReadLine();

// Checking if anything has been input after removing blank spaces.
if (toCheck.Replace(" ", "") == "")
{
    Console.WriteLine("You need to input something! Terminating program.");
    return;
}

if (int.TryParse(toCheck, out int toCheckInt))
{
    if (Checker.check(toCheckInt)) 
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
    if (Checker.check(toCheckDouble))
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
    if (Checker.check(toCheck))
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
Console.WriteLine(Checker.check("abba"));

Console.Write("12321 : ");
Console.WriteLine(Checker.check(12321));

Console.Write("123.21 : ");
Console.WriteLine(Checker.check(123.21));

Console.Write("Stack Cats : ");
Console.WriteLine(Checker.check("Stack Cats"));

Console.Write("A man, a plan, a canal - Panama : ");
Console.WriteLine(Checker.check("A man, a plan, a canal – Panama"));
**/


public static class Checker
{
    public static Boolean check(string s)
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

    public static Boolean check(int i)
    {
        return check(i.ToString());
    }

    public static Boolean check(double d)
    {
        string s = d.ToString();
        s.Replace(",", "");
        s.Replace(".", "");
        return check(s);
    }
}