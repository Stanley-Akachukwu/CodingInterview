

/// <summary>
/// 1.Write a c# function that gets the longest valid word in a sentence, and if two words are of the same length return the first word
///.e.g I $$love dogs#.   Will return love
/// </summary>
using System.Text.RegularExpressions;

static class Program
{
    static void Main(string [] args)
    {
        string input = "I $$love dogs#";
        string output = GetValidWord(input);
    }

    private static string GetValidWord(string input)
    {
        String[] words = input.Split(' ');                                        //1+n
        int length = 0;                                                           //1
        string validword = "";                                                    //1
        for (int i = 0; i < words.Length; i++)                                    //4+6n
        {
            if (length < words[i].Length)                                         //2n
            {
                length = words[i].Length;                                         //2n
                 validword = Regex.Replace(words[i], @"[^0-9a-zA-Z\._]", "");     //2n
            }
        }
       
        return validword;                                                          //1
    }
}
//Time Complexity:8+13n
//O(n)