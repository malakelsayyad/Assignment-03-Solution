namespace Demo
{
    //class NewData
    //{
    //    public int Sum;
    //    public int Mul;
    //}
    internal class Program
    {
        //static void PrintShape( string Pattern="^_^" , int count = 9) 
        //    {
        //        for (int i = 0; i < count; i++)
        //        {
        //            Console.WriteLine(Pattern);
        //        }
        //    }
        //static int SumNumbers(int X,int Y)
        //{
        //    //Hamada();
        //    return X + Y; 
        //}

        //static void Swap(ref int X, ref int Y)
        //{
        //    int Temp = X;
        //    X = Y; 
        //    Y = Temp;  
        //}

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

        //static int[] SumMul(int X,  int Y)
        //{
        //    int[] Result = { X + Y, X * Y };
        //    return Result;
        //}

        //static NewData SumMul(int X, int Y)
        //{
        //    NewData data = new NewData();
        //    data.Sum = X + Y;
        //    data.Mul = X * Y;
        //    return data;
        //}

        //static void SumMul(int X, int Y , out int Sum , out int Mul)
        //{
        //    Sum = X + Y;
        //    Mul = X * Y;
        //}

        //static int SumArray( params int[] Arr)
        //{
        //    int sum = 0;
        //    Arr = new int[] { 4, 5, 6 };
        //    for (int i = 0; i < Arr.Length; i++)
        //    {
        //        sum += Arr[i];
        //    }
        //    return sum;
        //}
        static void Main(string[] args)
        {
            #region 1D Array
            // 1D Array
            // int[] Numbers;
            // Declare for reference 'Pointer' from type (Array of ints)
            // Numbers : can refere to object from 'Array of ints'
            // Numbers : referes to null

            // 8 bytes at stack for the reference 'Numbers'
            // 0 bytes for heap

            // Numbers = new int [size]
            // Numbers = new int[5];
            // Console.WriteLine(Numbers[0]);
            // Console.WriteLine(Numbers[1]);
            // Numbers[0] = 12;
            // Numbers[1] = 6;
            // Numbers[2] = 7;
            // Numbers[3] = 90;
            // Numbers[4] = 8;
            // Numbers[5] = 12; // Excepetion : index out of range

            // Console.WriteLine(Numbers[0]);
            // Console.WriteLine(Numbers[1]);
            // Console.WriteLine(Numbers[2]);
            // Console.WriteLine(Numbers[3]);
            // Console.WriteLine(Numbers[4]);

            //for (int i = 0; i < Numbers.Length; i++)
            //{
            //    Console.WriteLine($"Enter numbers[{i}]");
            //    Numbers[i] = int.Parse(Console.ReadLine());
            //}
            //for (int i = 0; i < Numbers.Length; i++)
            //{
            //    Console.WriteLine($"{Numbers[i]}");          
            //}

            // Console.WriteLine(Numbers.Length); //Size of array : 5
            // Console.WriteLine(Numbers.Rank); // 1

            // Array is fixed size

            // int[] Numbers01= new int[9] { 1,2,3,4,5,0,0,0,0};
            // int[] Numbers02= new int[] { 1,2,3,4,5};
            // int[] Numbers03= { 1,2,3,4,5}; // new 
            #endregion

            #region 2D Array
            // 2D Array

            //int[,] Marks = new int[3, 4];
            // Marks[0,0] = 99;
            // Marks[0,1] = 98;
            // Marks[0,2] = 97;
            // Marks[0,3] = 88;

            // Marks[1, 0] = 99;
            // Marks[1, 1] = 98;
            // Marks[1, 2] = 97;
            // Marks[1, 3] = 88;

            // Console.WriteLine(Marks[0, 0]);
            // Console.WriteLine(Marks[0, 1]);
            // Console.WriteLine(Marks[0, 2]);
            // Console.WriteLine(Marks[0, 3]);

            // Console.WriteLine(Marks[1, 0]);
            // Console.WriteLine(Marks[1, 1]);
            // Console.WriteLine(Marks[1, 2]);
            // Console.WriteLine(Marks[1, 3]);

            // Console.WriteLine(Marks[2, 0]);
            // Console.WriteLine(Marks[2, 1]);
            // Console.WriteLine(Marks[2, 2]);
            // Console.WriteLine(Marks[2, 3]);

            // for (int i = 0; i < 3; i++)
            // {
            //    for (int j = 0; j < 4;  j++)
            //    {
            //        Console.Write($"{Marks[i,j]}");
            //    }
            // }
            // Console.WriteLine(Marks.Length);//12
            // Console.WriteLine(Marks.Rank);//12

            #endregion

            #region 2D Array-Jagged
            //int[][] Marks = new int [3][];
            //Marks[0] = new int[3];
            //Marks[1] = new int[2];
            //Marks[2] = new int[4];

            //for (int i = 0; i < 3; i++)
            //{
            //    for (int j = 0; j < Marks[i].Length; j++)
            //    {
            //        Console.Write($"{Marks[i][j]}");
            //        Marks[i][j] = int.Parse(Console.ReadLine());
            //    }

            //}
            //for (int i = 0; i < 3; i++)
            //{
            //    for (int j = 0; j < Marks[i].Length; j++)
            //    {

            //        Console.WriteLine(Marks[i][j]);
            //    }

            //} 
            #endregion

            #region Function Prototype and Calling
            // Functions
            // Function : block of code
            // Reuse  
            //  Dry : Dont repeat yourself
            // Function prototype 
            // 1. Signature
            // 1.1 name 
            // 1.2 Return type
            // 1.3 Parameters (inputs) 

            // 2.Body
            // PrintShape();

            // Function - Method
            // 1.2 Class Member Method : (Static Method)
            //  2.Object Member Method : (Non-Static Method)

            // Program P= new Program();
            // P.PrintShape();

            // PrintShape(5,"#_@"); // Passing by Order
            // PrintShape(Pattern:"#_@",count:8); // Passing by Name
            // PrintShape("$_*",2); // Passing by Name
            // PrintShape(); // Passing by Name

            // int Result=SumNumbers(1, 2);
            // Console.WriteLine(Result);
            // Console.WriteLine(SumNumbers(3,4));



            #endregion

            #region Stack Frame
            // SumNumbers(1, 2); 
            #endregion

            #region Passing parameter (value type) 
            // int A = 9, B = 4;
            // 1. Passing by value 
            // Console.WriteLine($"A:{A}");
            // Console.WriteLine($"A:{B}");

            // Console.WriteLine("---After swap---");

            // Swap(A, B);
            // Console.WriteLine($"A:{A}");
            // Console.WriteLine($"A:{B}");

            // 2. Passing by ref
            // Console.WriteLine($"A:{A}");
            // Console.WriteLine($"A:{B}");

            // Console.WriteLine("---After swap---");

            // Swap(ref A, ref B);
            // Console.WriteLine($"A:{A}");
            // Console.WriteLine($"A:{B}");


            #endregion

            #region Passing parameters (Reference Type) Ex01
            //int[] Numbers = { 1, 2, 3 };

            // 1.passing by value 
            // Console.WriteLine(SumArray(Numbers));
            // Console.WriteLine(Numbers[0]);

            // 2.passing by ref
            // Console.WriteLine(SumArray(ref Numbers));
            // Console.WriteLine(Numbers[0]);

            #endregion

            #region Passing parameters (Reference Type) Ex02
            //int[] Numbers = { 1, 2, 3 };

            // 1.passing by value 
            // Console.WriteLine(SumArray(Numbers)); // 15
            // Console.WriteLine(Numbers[0]); // 1

            // 2.passing by ref
            // Console.WriteLine(SumArray(ref Numbers)); //15
            // Console.WriteLine(Numbers[0]); //4
            #endregion

            #region Passing by Out
            // Passing by out

            // int A=3, B=4; 
            // int[] Result =SumMul(A, B);
            // Console.WriteLine(Result[0]);
            // Console.WriteLine(Result[1]);

            // int A = 3, B = 4;
            // NewData Result = SumMul(A, B);
            // Console.WriteLine(Result.Sum);
            // Console.WriteLine(Result.Mul);

            // Output parameter
            // Passing by out

            // int A = 4, B = 5  ;

            // SumMul(A,B,out int Sum, out _ );

            // Console.WriteLine(Sum);
            // Console.WriteLine(Mul);

            #endregion

            #region Params

            //int[] Numbers = { 1, 2, 3, 4, 5, 6, 7 };
            //Console.WriteLine(SumArray(Numbers));
            //Console.WriteLine(SumArray( 1,2,3,4,5,6,7,8,9,10,0,12));

            #endregion
        }
    }
}
