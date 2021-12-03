using System;

namespace Puzzle_1.Scripts
{
    public class Puz3
    {
        private static LocalUtils _localUtils = new LocalUtils();

        public static void RunPuzzle()
        {
            PartOne();
        }

        public static void PartOne()
        {
            string[] allLines = _localUtils.ReadAllLinesFromPuzzleInput(3);
            int binNumLen = allLines[0].Length;
            int[,] binBitAvg = new int[binNumLen, 2];
            string gammaRateBin = "";
            string epsilonRateBin = "";
            int gammaRate = 0;
            int epsilonRate = 0;

            for (int i = 0; i < allLines.Length; i++)
            {
                string tempBinNum = allLines[i];
                for (int x = 0; x < binNumLen; x++)
                {
                    if (tempBinNum[x] == '1')
                    {
                        if (binBitAvg[x, 0] == null)
                        {
                            binBitAvg[x, 0] = 1;
                        }
                        else
                        { 
                            binBitAvg[x, 0] += 1;
                        }
                    }
                    else
                    {
                        if (binBitAvg[x, 1] == null)
                        {
                            binBitAvg[x, 1] = 1;
                        }
                        else
                        {
                            binBitAvg[x, 1] += 1;
                        }
                    }
                }
            }

            for (int i = 0; i < binNumLen; i++)
            {
                if (binBitAvg[i, 0] > binBitAvg[i, 1])
                {
                    gammaRateBin += "1";
                    epsilonRateBin += "0";
                }
                else
                {
                    gammaRateBin += "0";
                    epsilonRateBin += "1";
                }
            }

            for (int i = binNumLen - 1; i > 0; i--)
            {
                
            }
            
            Console.WriteLine("BIN 1:{0}, \n BIN2:{1}", gammaRateBin, epsilonRateBin);
            // Answer: 2583164
        }
        
        public static void PartTwo()
        {
            
        }
    }
}