using System;
namespace Reverse_String

/*Task:
Return the number (count) of vowels in the given string.

We will consider a, e, i, o, and u as vowels for this Kata.

The input string will only consist of lower case letters and/or spaces.*/


{


    public static int GetVowelCount(string str)
    {
        int vowelCount = 0;
        string vowels = "aeiou";

        foreach (char letter in str)
        {
            if (vowels.IndexOf(letter) != -1)
                vowelCount++;
        }

        return vowelCount;
    }
    //Best Practice Or Lamda Expression would be 
    //return str.Count(i => "aeiou".Contains(i));

}
