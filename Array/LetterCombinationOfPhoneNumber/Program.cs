static class Program
{
    static void Main(string [] args)
    {
        int[] number = { 2, 3 };
        int n = number.Length;

        // Function call
        letterCombinations(number, n);
    }

    private static void letterCombinations(int[] number, int n)
    {
        // table[i] stores all characters that
        // corresponds to ith digit in phone
        String[] table
            = { "0",   "1",   "abc",  "def", "ghi",
                "jkl", "mno", "pqrs", "tuv", "wxyz" };

        List<String> list
            = LetterCombinationsUtil(number, n, table);

        // Print the contents of the list
        for (int i = 0; i < list.Count; i++)
        {
            Console.Write(list[i] + " ");
        }
    }

    private static List<string> LetterCombinationsUtil(int[] number, int n, string[] table)
    {
        // To store the generated letter combinations
        List<String> list = new List<String>();
        Queue<String> q = new Queue<String>();
        q.Enqueue("");

        while (q.Count != 0)
        {
            String s = q.Dequeue();
            // If complete word is generated
            // push it in the list
            if (s.Length == n)
                list.Add(s);
            else
            {
                String val = table[number[s.Length]];
                for (int i = 0; i < val.Length; i++)
                {
                    q.Enqueue(s + val[i]);
                }
            }
        }
        return list;
    }
}
//Time Complexity: