using System;
using System.Diagnostics;
using System.Drawing;
using System.Numerics;
using static System.Runtime.InteropServices.JavaScript.JSType;

namespace Assignment_03
{
    internal class Program
    {
        // Passing by value
        //static void Swap( int X,  int Y)
        //{
        //    int Temp = X;
        //    X = Y;
        //    Y = Temp;
        //}

        // Passing by ref
        //static void SwapRef(ref int X, ref int Y)
        //{
        //    int Temp = X;
        //    X = Y;
        //    Y = Temp;
        //}

        // Passing by value
        //static int SumArray( int[] Arr)
        //{
        //    int sum = 0;
        //    Arr = new int[] { 4,5,6 };
        //    for (int i = 0; i <Arr.Length; i++)
        //    {
        //        sum += Arr[i];

        //    }
        //    return sum;
        //}

        // Passing by Ref
        //static int SumArray( ref int[] Arr)
        //{
        //    int sum = 0;
        //    Arr = new int[] { 4,5,6 };
        //    for (int i = 0; i <Arr.Length; i++)
        //    {
        //        sum += Arr[i];

        //    }
        //    return sum;
        //}

        #region Q3 function
        public static void SumSub(int X, int Y, out int Sum, out int Sub)
        {
            Sum = X + Y;
            Sub = X - Y;

        }

        #endregion

        #region Q4 function
        //public static int CalculateSumOfDigits(int num)
        //{
        //    int sum = 0;

        //    while (num > 0)
        //    {
        //        sum += num % 10;
        //        num /= 10;
        //    }

        //    return sum;
        //}
        #endregion

        #region Q5 function
        //public static bool IsPrime(int Num)
        //{

        //    for (int i = 2; i * i <= Num; i++)
        //    {
        //        if (Num % i == 0)
        //        {
        //            return false;
        //        }
        //    }

        //    return true;
        //}
        #endregion

        #region Q6 function
        //static void MinMax(int[] Arr, ref int Min, ref int Max)
        //{

        //    Min = Arr[0];
        //    Max = Arr[0];

        //    for (int i = 1; i < Arr.Length; i++)
        //    {
        //        if (Arr[i] < Min)
        //        {
        //            Min = Arr[i];
        //        }
        //        if (Arr[i] > Max)
        //        {
        //            Max = Arr[i];
        //        }
        //    }
        //}
        #endregion

        #region Q7 function
        //public static int CalcFactorial(int Num)
        //{
        //    int Result = 1; 
        //    for (int i = 2; i <= Num; i++)
        //    {
        //        Result *= i;
        //    }
        //    return Result;
        //}

        #endregion

        #region Q8 function

        //static string ChangeChar(string str, int position, char newChar)
        //{

        //    char[] chars = str.ToCharArray();
        //    chars[position] = newChar;
        //    return new string(chars);
        //}

        #endregion

        #region Q11 function

        //public static int[] MergeArrays(int[] array1, int[] array2)
        //{
        //    int Size= array1.Length;
        //    int[] mergedArray = new int[2 * Size];
        //    int i = 0, j = 0, k = 0;

        //    while (i < Size && j < Size)
        //    {
        //        if (array1[i] <= array2[j])
        //        {
        //            mergedArray[k++] = array1[i++];
        //        }
        //        else
        //        {
        //            mergedArray[k++] = array2[j++];
        //        }
        //    }


        //    while (i < Size)
        //    {
        //        mergedArray[k++] = array1[i++];
        //    }


        //    while (j < Size)
        //    {
        //        mergedArray[k++] = array2[j++];
        //    }

        //    return mergedArray;
        //}


        #endregion

        static void Main()
        {
            #region Q1

            // int X= 3, Y = 2;
            // 1.Passing by value
            // Console.WriteLine($"X:{X}");
            // Console.WriteLine($"A:{Y}");

            // Console.WriteLine("---After swap---");

            // Swap(X,Y);
            // Console.WriteLine($"X:{X}");
            // Console.WriteLine($"A:{Y}");

            // 2.Passing by ref
            // Console.WriteLine($"X:{X}");
            // Console.WriteLine($"A:{Y}");

            // Console.WriteLine("After swap by ref");

            // SwapRef(ref X, ref Y);
            // Console.WriteLine($"X:{X}");
            // Console.WriteLine($"A:{Y}");

            #endregion

            #region Q2
            //int[] Numbers = { 1, 2, 3 };

            // passing by value 
            // Console.WriteLine(SumArray(Numbers));
            // Console.WriteLine(Numbers[0]);

            // passing by ref
            // Console.WriteLine(SumArray(ref Numbers));
            // Console.WriteLine(Numbers[0]);


            #endregion

            #region Q3 test
            //SumSub(3, 5, out int Sum, out int Sub);
            //Console.WriteLine("Sum : " + Sum);
            //Console.WriteLine("Sub : " + Sub);
            #endregion

            #region Q4 test

            //Console.Write("Enter a positive number: ");
            //if (int.TryParse(Console.ReadLine(), out int Number ))
            //{
            //    int sumOfDigits = CalculateSumOfDigits(Number);

            //    Console.WriteLine($"The sum of the digits of the number {Number} is: {sumOfDigits}");
            //}
            //else 
            //{
            //    Console.WriteLine("Invalid input");
            //}

            #endregion

            #region Q5 test

            //Console.Write("Enter a positive number: ");
            //if (int.TryParse(Console.ReadLine(), out int Number))
            //{
            //    bool Result =IsPrime(Number);

            //    if (Result)
            //    {
            //        Console.WriteLine($"{Number} is a prime number.");
            //    }
            //    else
            //    {
            //        Console.WriteLine($"{Number} is not a prime number.");
            //    }

            //}
            //else
            //{
            //    Console.WriteLine("Invalid input");
            //}

            #endregion

            #region Q6 test
            //Console.WriteLine("Enter number of elements");
            //if (int.TryParse(Console.ReadLine(), out int Element))
            //{
            //    int[] Numbers = new int[Element];
            //    for (int i = 0; i < Numbers.Length; i++)
            //    {
            //       Console.Write($"Enter number {i + 1}: ");
            //       Numbers[i] = int.Parse(Console.ReadLine());
            //    }

            //    int Min = 0, Max = 0;


            //    MinMax(Numbers, ref Min, ref Max);

            //    Console.WriteLine($"Minimum value: {Min}");
            //    Console.WriteLine($"Maximum value: {Max}");
            //}
            //else
            //{
            //    Console.WriteLine("Invalid input");
            //}
            #endregion

            #region Q7 test
            //Console.Write("Enter a number: ");
            //if (int.TryParse(Console.ReadLine(), out int Number) && Number >= 0)
            //{
            //    int Factorial = CalcFactorial(Number);
            //    Console.WriteLine($"The factorial of {Number} is: {Factorial}");
            //}
            //else
            //{
            //    Console.WriteLine("Invalid input");
            //}
            #endregion

            #region Q8 test

            //Console.Write("Enter a string: ");
            //string Input = Console.ReadLine();

            //Console.Write("Enter the position to modify ");
            //if (int.TryParse(Console.ReadLine(), out int Position) && Position >= 0 && Position < Input.Length)
            //{
            //    Console.Write("Enter the new character: ");
            //    char NewChar = Console.ReadKey().KeyChar;
            //    Console.WriteLine();

            //    string ModifiedString = ChangeChar(Input, Position, NewChar);
            //    Console.WriteLine($"Modified string: {ModifiedString}");
            //}
            //else
            //{
            //    Console.WriteLine("Invalid position.");
            //}

            #endregion

            #region Q9
            //Console.Write("Enter the size of the matrix : ");
            //if (int.TryParse(Console.ReadLine(), out int Size) && Size > 0)
            //{
            //    Console.WriteLine("The identity matrix is : ");
            //    for (int i = 0; i < Size; i++)
            //    {
            //        for (int j = 0; j < Size; j++)
            //        {
            //            if (i == j)
            //            {
            //                Console.Write("1 ");
            //            }
            //            else
            //            {
            //                Console.Write("0 ");

            //            }
            //        }
            //        Console.WriteLine();

            //    }
            //}
            //else
            //{
            //    Console.WriteLine("Invalid input.");
            //}

            #endregion

            #region Q10
            //Console.Write("Enter the number of elements in the array: ");
            //if (int.TryParse(Console.ReadLine(), out int Size) && Size > 0)
            //{
            //    int[] Numbers = new int[Size]; 

            //    for (int i = 0; i < Size; i++)
            //    {
            //        Console.Write($"Enter number {i + 1}: ");
            //        Numbers[i] = int.Parse(Console.ReadLine());
            //    }

            //    int Sum = 0;
            //    for (int i = 0; i < Numbers.Length; i++)
            //    {
            //        Sum += Numbers[i];
            //    }

            //    Console.WriteLine("Sum is: " + Sum); 
            //}
            //else
            //{
            //    Console.WriteLine("Invalid input.");
            //}

            #endregion

            #region Q11
            //Console.WriteLine("Enter the size of the arrays (both arrays will have the same size): ");
            //if (int.TryParse(Console.ReadLine(), out int n) && n > 0)
            //{
            //    int[] array1 = new int[n];
            //    int[] array2 = new int[n];

            //    Console.WriteLine("Enter elements of the first  array in ascending: ");
            //    for (int i = 0; i < n; i++)
            //    {
            //        Console.Write($"Enter element {i + 1}: ");
            //        array1[i] = int.Parse(Console.ReadLine());
            //    }

            //    Console.WriteLine("Enter elements of the second array in ascending: ");
            //    for (int i = 0; i < n; i++)
            //    {
            //        Console.Write($"Enter element {i + 1}: ");
            //        array2[i] = int.Parse(Console.ReadLine());
            //    }

            //    int[] mergedArray = MergeArrays(array1, array2);

            //    Console.WriteLine("Merged array : ");
            //    foreach (int num in mergedArray)
            //    {
            //        Console.Write(num + " ");
            //    }
            //}
            //else
            //{
            //    Console.WriteLine("Invalid input.");
            //}
            #endregion

            #region Q12
            //Console.WriteLine("Enter the number of elements in the array:");
            //int Size = int.Parse(Console.ReadLine());

            //int[] arr = new int[Size];

            //Console.WriteLine("Enter the elements of the array:");
            //for (int i = 0; i < Size; i++)
            //{
            //    arr[i] = int.Parse(Console.ReadLine());
            //}

            //Console.WriteLine("Element frequencies:");


            //for (int i = 0; i < arr.Length; i++)
            //{

            //    bool alreadyCounted = false;
            //    for (int j = 0; j < i; j++)
            //    {
            //        if (arr[i] == arr[j])
            //        {
            //            alreadyCounted = true;
            //            break;
            //        }
            //    }

            //    if (!alreadyCounted)
            //    {
            //        int count = 1;

            //        for (int k = i + 1; k < arr.Length; k++)
            //        {
            //            if (arr[i] == arr[k])
            //            {
            //                count++;
            //            }
            //        }

            //        Console.WriteLine($"Element {arr[i]} occurs {count} times.");
            //    }

            //}
            #endregion

            #region Q13
            //Console.WriteLine("Enter number of elements:");

            //if (int.TryParse(Console.ReadLine(), out int Size) && Size > 0)
            //{
            //    int[] Numbers = new int[Size];

            //    Console.WriteLine($"Enter number 1:");
            //     Numbers[0] = int.Parse(Console.ReadLine());
            //    int Min = Numbers[0];
            //    int Max = Numbers[0];

            //    for (int i = 1; i < Numbers.Length; i++) 
            //    {
            //        Console.WriteLine($"Enter number {i + 1}:");
            //        Numbers[i] = int.Parse(Console.ReadLine());

            //        if (Numbers[i] < Min)
            //        {
            //            Min = Numbers[i]; 
            //        }
            //        if (Numbers[i] > Max)
            //        {
            //            Max = Numbers[i];  
            //        }
            //    }


            //    Console.WriteLine($"Min: {Min}");
            //    Console.WriteLine($"Max: {Max}");
            //}
            //else
            //{
            //    Console.WriteLine("Invalid input. Please enter a positive integer.");
            //}

            #endregion

            #region Q17

            //Console.WriteLine("Enter a list of space-separated words:");
            //string input = Console.ReadLine();

            //string[] words = input.Split(' ', StringSplitOptions.RemoveEmptyEntries);
            //Console.WriteLine("Reversed order of words:");
            //for (int i = words.Length - 1; i >= 0; i--)
            //{
            //    Console.Write(words[i] + (i > 0 ? " " : ""));
            //}

            #endregion

            #region Q18

            //Console.WriteLine("Enter the number of rows:");
            //int rows = int.Parse(Console.ReadLine());

            //Console.WriteLine("Enter the number of columns:");
            //int columns = int.Parse(Console.ReadLine());

            //int[,] arr1 = new int[rows, columns];
            //int[,] arr2 = new int[rows, columns];


            //Console.WriteLine("Enter elements for the first array:");
            //for (int i = 0; i < rows; i++)
            //{
            //    for (int j = 0; j < columns; j++)
            //    {
            //        Console.Write($"Element at [{i},{j}]: ");
            //        arr1[i, j] = int.Parse(Console.ReadLine());
            //    }
            //}

            //for (int i = 0; i < rows; i++)
            //{
            //    for (int j = 0; j < columns; j++)
            //    {
            //        arr2[i, j] = arr1[i, j];
            //    }
            //}


            //Console.WriteLine("Elements of the second array:");
            //for (int i = 0; i < rows; i++)
            //{
            //    for (int j = 0; j < columns; j++)
            //    {
            //        Console.Write(arr2[i, j] + " ");
            //    }
            //    Console.WriteLine();
            //}

            #endregion

            #region Q19

            //Console.WriteLine("Enter the size of the array : ");
            //if (int.TryParse(Console.ReadLine(),out int Size))
            //{
            //    int[] Numbers = new int[Size];
            //    for (int i = 0; i < Numbers.Length; i++)
            //    {
            //        Console.WriteLine($"enter number {i+1} : ");
            //        Numbers[i]=int.Parse(Console.ReadLine());
            //    }
            //    Console.WriteLine("The reversed array is");

            //    for (int i = Numbers.Length-1; i >=0;  i--)
            //    {   
            //        Console.WriteLine(Numbers[i]+" ");
            //    }
            //}
            //else
            //{
            //    Console.WriteLine("Invalid input");
            //}

            #endregion
        }
    }
}
