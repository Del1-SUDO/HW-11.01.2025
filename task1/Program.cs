using System;
using System.Collections.Generic;
class Program {
    static void Main() {
        int[] arr = new int[6];

        Console.WriteLine("Enter 6 numbers:");
        for (int i = 0; i < 6; i++) {
            arr[i] = int.Parse(Console.ReadLine());
        }

        SeparateNumbers(arr);
    }

    static void SeparateNumbers(int[] arr) {
        List<int> even = new List<int>();
        List<int> odd = new List<int>();

        foreach (int number in arr) {
            if (number % 2 == 0) { 
                even.Add(number);
            }
            else {
                odd.Add(number);
            }
        }

        Console.WriteLine("Четные: " + string.Join(", ", even));
        Console.WriteLine("Нечетные: " + string.Join(", ", odd));
    }
}