using System;
class Program
{ //Задание 1

    static void Main(string[] args)
    {
         List<int> arr1 = new List<int>() { 0, 1 };
    
    
        for (int i = 2; i < 8; i++)
        {
            arr1.Add(0);
            arr1[i] = arr1[i - 1] + arr1[i - 2];
        }
        foreach (int a in arr1)
        {
            Console.Write($"{a},");
        }
    





    // Задание 2
    string[] array2 = new string[] { "January", "February", "March", "April", "May", "June", "July", "August", "September", "October", "November", "December" };

        // Задание 3

        int[,] arr = new int[3, 3] {
        { 2, 3, 4 },
        { 2, 3, 4 },
        { 2, 3, 4 }
    };
        int power = 1;

        int r = arr.GetUpperBound(0) + 1;
        int c = arr.Length / r;
        for (int i = 0; i < r; i++)
        {
            for (int p = 0; p < c; p++)
            {
                arr[i, p] = (int)Math.Pow(arr[i, p], power);
            }
            power++;
        }
        for (int i = 0; i < r; i++)
        {
            for (int p = 0; p < c; p++)
            {
                Console.Write(arr[i, p]);
            }
            Console.WriteLine();
        }



        //Задание 4



        int j = 0;
        double[][] array3 = new double[3][];
        array3[0] = new double[5] { 1, 2, 3, 4, 5 };
        array3[1] = new double[2] { Math.E, Math.PI };
        array3[2] = new double[4] { Math.Log10(1), Math.Log10(10), Math.Log10(100), Math.Log10(1000) };

        for (; j < 5; j++)
        {
            array3[0][j] = j;
            Console.Write("{0}\t", array3[0][j]);
        }

        Console.WriteLine();
        for (j = 0; j < 2; j++)
        {
            array3[1][j] = j;
            Console.Write("{0}\t", array3[1][j]);
        }

        Console.WriteLine();
        for (j = 0; j < 4; j++)
        {
            array3[2][j] = j;
            Console.Write("{0}\t", array3[2][j]);
        }
        Console.ReadLine();

        // заданий 5 



        int[] array = { 1, 2, 3, 4, 5 };
        int[] array4 = { 7, 8, 9, 10, 11, 12, 13 };
        Array.Copy(array, array4, 3);

        foreach (var person in array4)
            Console.Write($"{person} ");


        // заданий 6
        string[] sample = { "", "" };
        Array.Resize(ref array, 17);
        foreach (var person in array)
            Console.WriteLine($"{person} ");


    }
}


