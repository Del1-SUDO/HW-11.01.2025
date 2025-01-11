using System;

class Program {
    static void Main()
    {
        Console.Write("Enter the first array size: ");
        int a = int.Parse(Console.ReadLine());
        int[] arr1 = new int[a];
        Console.WriteLine("Enter the first array elements: ");
        for (int i = 0; i < a; i++){
            arr1[i] = int.Parse(Console.ReadLine());
        }

        Console.Write("Enter the second array size: ");
        int b = int.Parse(Console.ReadLine());
        int[] arr2 = new int[b];
        Console.WriteLine("Enter the second array elements: ");
        for (int i = 0; i < b; i++){
            arr2[i] = int.Parse(Console.ReadLine());
        }

        FindCommon(arr1, arr2, a, b);
    }

    static void FindCommon(int[] arr1, int[] arr2, int a, int b) {
        int[] result = new int[Math.Min(a, b)];
        int index = 0;

        for (int i = 0; i < a; i++) {
            for (int j = 0; j < b; j++) {
                if (arr1[i] == arr2[j]) {
                    bool alreadyAdded = false;
                    for (int k = 0; k < index; k++) {
                        if (result[k] == arr1[i]) {
                            alreadyAdded = true;
                            break;
                        }
                    }

                    if (!alreadyAdded) {
                        result[index++] = arr1[i];
                    }
                }
            }
        }

        Console.Write("[ ");
        for (int i = 0; i < index; i++) {
            Console.Write(result[i] + " ");
        }
        Console.WriteLine("]");
    }
}
