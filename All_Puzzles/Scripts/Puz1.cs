using System;
using System.IO;

namespace Puzzle_1.Scripts
{
    public class Puz1
    {
        private static LocalUtils _localUtils = new LocalUtils();
        
        public static void RunPuzzle()
        {
            int numIncrease = 0;

            string[] allLines = _localUtils.ReadAllLinesFromPuzzleInput(1);

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