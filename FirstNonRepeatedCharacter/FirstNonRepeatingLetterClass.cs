using System;

public class FirstNonRepeatingLetterClass
{
    public static string FirstNonRepeatingLetter(string s)
    {
        var compare = s.ToUpper();
        for (int i = 0; i < s.Length; i++)
        {
            var c = compare[i];

            // If the first and last instance of the character are the same,
            // it is the only instance of that letter or character.
            if (compare.IndexOf(c) == compare.LastIndexOf(c))
            {
                return s[i].ToString();
            }
        }

        return String.Empty;
    }
}