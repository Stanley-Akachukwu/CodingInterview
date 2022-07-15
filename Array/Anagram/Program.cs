using System.Collections;

static class Program
{
    static void Main(string [] args)
    {
        //var isAnagram = CheckAnagram();
        // create and initialize new ArrayList
        ArrayList str1 = new ArrayList();
        str1.Add('b');
        str1.Add('o');
        str1.Add('y');
        str1.Add('s');
        // create and initialize new ArrayList
        ArrayList str2 = new ArrayList();
        str2.Add('s');
        str2.Add('b');
        str2.Add('y');
        str2.Add('z');

        // Function call
        if (CheckAnagram(str1, str2))
        {
            Console.WriteLine("The two strings are"
                              + " anagram of each other");
        }
        else
        {
            Console.WriteLine("The two strings are not"
                              + " anagram of each other");
        }
    }
   
    public static bool CheckAnagram(ArrayList str1, ArrayList str2)
    {
        // Get lengths of both strings
        int n1 = str1.Count;                              //1+2n
        int n2 = str2.Count;                             //1+2n
        // If length of both strings is not
        // same, then they cannot be anagram
        if (n1 != n2)                                      //3
        {
            return false;                                  //1
        }
        // Sort both strings
        str1.Sort();                                       //2n
        str2.Sort();                                       //2n

        // Compare sorted strings
        for (int i = 0; i < n1; i++)                        //1+3(n+1)+3n
        {
            if (str1[i].ToString() != str2[i].ToString())                         //3n
            {
                return false;                               //1
            }
        }
        return true;                                        //1
    }
}

//Time Complexity:2(1+2n)+4+4n+4+6n+3n+2  = 10+16n
 // for Big Oh value:
 //drop the leading constants
 //drop all but the highest order terms

//O(n)