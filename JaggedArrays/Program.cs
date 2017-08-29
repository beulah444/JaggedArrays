using System;
using System.Collections;
/* A jagged array is an array of arrays where each row of
an array is made up of an array.Each dimension of a jagged array is a onedimensional
array.We call it a “jagged” array because the number of elements
in each row may be different.A picture of a jagged array would not be square
or rectangular, but would have uneven or jagged edges.*/

class Program
    {
        static void Main()
        {
        int[] Jan = new int[31];
        int[] Feb = new int[29];
     
        int[][] sales = new int[][] {Jan, Feb};
        int month, day, total;
        double average = 0.0;
        sales[0][0] = 41;
        sales[0][1] = 30;
        sales[0][0] = 41;
        sales[0][1] = 30;
        sales[0][2] = 23;
        sales[0][3] = 34;
        sales[0][4] = 28;
        sales[0][5] = 35;
        sales[0][6] = 45;
        sales[1][0] = 35;
        sales[1][1] = 37;
        sales[1][2] = 32;
        sales[1][3] = 26;
        sales[1][4] = 45;
        sales[1][5] = 38;
        sales[1][6] = 42;
        for (month = 0; month <= 1; month++)
        {
            total = 0;
            for (day = 0; day <= 6; day++)
            {
                total += sales[month][day];
            }
            average = total / 7;
            Console.WriteLine("Average sales for month: " +
            month + ": " + average);
        }
        Console.ReadKey();
        }
    }

