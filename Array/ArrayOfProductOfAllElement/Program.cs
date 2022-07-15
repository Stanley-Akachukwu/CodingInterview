using System.Collections;

static class Program
{
    static void Main(string [] args)
    {
        GetSubStringCount("ballllbaoooonnzzzzzzzzballoon", "balloon");
        int[] arr = { 1, 3, 4, 5 };
        Console.Write("Array before product: ");
        for (int i = 0; i < arr.Length; i++)
        {
            Console.Write(arr[i] + " ");
        }
        Console.WriteLine("");
        int[] prodArray = FindArrayOfProduct(arr);
        Console.Write("Array after product: ");
        for (int i = 0; i < arr.Length; i++)
        {
            Console.Write(prodArray[i] + " ");
        }

        return;
    }
    public static int GetSubStringCount(string s1, string s2)
    {
        Char[] db = s1.ToCharArray();
        Char[] query = s2.ToCharArray();
        ArrayList queue = new ArrayList(db);
        int count =0;

        while(queue.Count > query.Length)
        {
            for (int i = 0; i < query.Length-1; i++)
            {
                if (queue.Contains(query[i]))
                {
                    queue.Remove(query[i]);
                }
                else
                {
                    return count;
                }
            }
            count++;
        }
        return count;
    }
    private static int[] FindArrayOfProduct(int[] arr)
    {
        int n = arr.Length;                                                        //2
        int i, temp = 1;                                                           //2
        int[] product = new int[n];                                       //2

        // temp contains product of elements on left side excluding arr[i]
        for (i = 0; i < n; i++)                                                    //4+6n
        {
            product[i] = temp;                                                     //2n  
            temp *= arr[i];                                                        //4n
        }
        temp = 1;                                                                  //1

        // temp contains product of elements on right side excluding arr[i]
        for (i = n - 1; i >= 0; i--)                                               //5+6m
        {
            product[i] *= temp;                                                    //4m
            temp *= arr[i];                                                        //4m
        }
        return product;                                                            //2
    }
}

//Time Complexity:  17+12n+14m
// for Big Oh value:
//drop the leading constants
//drop all but the highest order terms

//O(n)+O(m)