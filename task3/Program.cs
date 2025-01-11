using System;
class Program{
    static void Main(){
        Console.Write("Enter the arrays size: ");
        int a = int.Parse(Console.ReadLine());
        int[] arr1 = new int[a];
        Console.WriteLine("Enter the elements: ");
        for (int i = 0; i < a; i++){
            arr1[i] = int.Parse(Console.ReadLine());
        }

        System.Console.Write("Enter position: ");
        int position = int.Parse(Console.ReadLine());

        ShiftArray(arr, position, a)
    }

    static void ShiftArray(int[] arr, int position, int a){
        int c = 1;
        for(int i=arr[a-c]; c<=position; c--){
            System.Console.WriteLine(arr[a-1]);
        }
    }
}