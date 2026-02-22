using System;
class Program
{
    static void Main()
    {
        int[] arr = { 4, 2, 7, 4, 9 };
        Console.WriteLine("elements are:");
        for(int i = 0; i < arr.Length; i++) 
            Console.Write(arr[i]+" ");
        Console.WriteLine();
        Console.WriteLine("the last element is: "+arr[arr.Length - 1]);
         
    }
}
