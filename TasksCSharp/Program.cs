using System;

namespace TasksCSharp
{
    class Program
    {
        static void Main(string[] args)
        {
            
        }
    }
}

class Tasks
{
    public int Task_2001()
    {
        string[] values = Console.ReadLine().Split(' ');
        int a = int.Parse(values[0]);
        int b = int.Parse(values[1]);
        Console.WriteLine(a + b);
        return a + b;
    }
    public int Task_2002()
    {
        int Count = 0, arrayLangth = int.Parse(Console.ReadLine());
        int[] ArrayOne = new int[arrayLangth];
        string[] values = Console.ReadLine().Split(' ');
        ArrayOne = Array.ConvertAll(values, int.Parse);

        for (int i = 0; i < ArrayOne.Length; i++)
        {
            Count += ArrayOne[i];
        }
        Console.WriteLine(Count);
        return Count;
    }

    public int Task_2003()
    {
        int Count = 0, arrayLangth = int.Parse(Console.ReadLine());
        int[] ArrayOne = new int[arrayLangth];
        string[] values = Console.ReadLine().Split(' ');
        ArrayOne = Array.ConvertAll(values, int.Parse);
        Count = ArrayOne[0];

        for (int i = 1; i < ArrayOne.Length; i++)
        {
            if (i % 2 == 0)
            {
                Count += ArrayOne[i];
            }
            else
            {
                Count -= ArrayOne[i];
            }
        }
        Console.WriteLine(Count);
        return Count;
    }

    public int Task_2004()
    {
        int Year = int.Parse(Console.ReadLine());
        if ((Year % 4 == 0 && Year % 100 != 0) || Year % 400 == 0)
        {
            Console.WriteLine(1);
            return 1;
        }
        else
        {
            Console.WriteLine(0);
            return 0;
        }
    }

    public int Task_2005()
    {
        int value = 0;
        int index = 1;
        int arrayLangth = int.Parse(Console.ReadLine());

        int[] ArrayOne = new int[arrayLangth];
        string[] values = Console.ReadLine().Split(' ');
        ArrayOne = Array.ConvertAll(values, int.Parse);
        value = ArrayOne[0];

        for (int i = 1; i < ArrayOne.Length; i++)
        {
            if (value > ArrayOne[i])
            {
                value = ArrayOne[i];
                index = i + 1;
            }
        }
        Console.WriteLine(index);
        return index;
    }

    public int[] Task_2006()
    {
        (int foot, int inch) ConvertCmToFeetAndInches(int n)
        {
            int inch = n / 3;

            if (n % 3 > 1)
            {
                inch += 1;
            }
            int foot = inch / 12;

            return (foot, inch % 12);
        }
        int length = int.Parse(Console.ReadLine());
        (int feet, int inch) = ConvertCmToFeetAndInches(length);
        int[] rez = [feet, inch];
        Console.WriteLine(feet + " " + inch);
        return rez;
    }

    public int Task_2007()
    {
        int number = int.Parse(Console.ReadLine());
        int Count = 0;

        while (number != 0)
        {
            if (number % 2 == 0)
            {
                number = number / 2;
                Count++;
            }
            else
            {
                break;
            }
        }
        Console.WriteLine(Count);
        return Count;
    }
}