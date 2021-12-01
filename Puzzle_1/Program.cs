using System;
using System.IO;

namespace Puzzle_1
{
    class Program
    {
        static void Main(string[] args)
        {
            string filepath = @"C:\Users\titas\RiderProjects\Advent_of_Code_2021\Puzzle_1\PUZ1_IN.txt";
            int numIncrease = 0;

            string[] allLines = File.ReadAllLines(filepath);

            numIncrease = NumIncreaseFromLastNumArr(allLines);

            Console.WriteLine("(1i sum) Num times increased: {0}, length of file {1}", numIncrease, allLines.Length);

            numIncrease = SumIncreaseFromLastSumArr(allLines);
            
            Console.WriteLine("(3i sum) Num times increased: {0}, length of file {1}", numIncrease, allLines.Length);
        }

        private static int NumIncreaseFromLastNumArr(string[] strArr)
        {
            int numIncrease = 0;
            
            for (int i = 1; i < strArr.Length; i++)
            {
                if (int.Parse(strArr[i]) > int.Parse(strArr[i - 1]))
                {
                    numIncrease += 1;
                }
            }
            return numIncrease;
        }

        private static int SumIncreaseFromLastSumArr(string[] strArr)
        {
            int numIncrease = 0;
            
            for (int i = 1; i < strArr.Length - 2; i++)
            {
                if (SumThreeIndexFromArr(i, strArr) > SumThreeIndexFromArr(i - 1, strArr))
                {
                    numIncrease += 1;
                }
            }

            return numIncrease;
        }

        private static int SumThreeIndexFromArr(int startingIndex, string[] arr)
        {
            return (int.Parse(arr[startingIndex]) + int.Parse(arr[startingIndex + 1]) + int.Parse(arr[startingIndex + 2]) );
        }
    }
}