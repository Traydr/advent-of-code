using System;

namespace Puzzle_1.Scripts
{
    public class Puz3
    {
        private static LocalUtils _localUtils = new LocalUtils();

        public static void RunPuzzle()
        {
            Console.WriteLine("\n Puzzle 3 Part 1");
            PartOne();
            Console.WriteLine("\n Puzzle 3 Part 2");
            PartTwo();
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

            gammaRate = Convert.ToInt32(gammaRateBin, 2);
            epsilonRate = Convert.ToInt32(epsilonRateBin, 2);

            Console.WriteLine("BIN 1:{0}, \n BIN2:{1}", gammaRateBin, epsilonRateBin);
            Console.WriteLine("Final Answer: {0}", gammaRate * epsilonRate);
            // Answer: 2583164
        }
        
        public static void PartTwo()
        {
            string[] allLines = _localUtils.ReadAllLinesFromPuzzleInput(3);
            int binNumLen = allLines[0].Length;
            int[,] binBitAvg = new int[binNumLen, 2];
            string oxGenRatingBin = "";
            string co2ScrubRatingBin = "";
            int oxGenRating = 0;
            int co2ScrubRating = 0;

            for (int i = 0; i < binNumLen; i++)
            {
                if (allLines[i].Length < oxGenRatingBin.Length && allLines[i].Length < oxGenRatingBin.Length)
                {
                    continue;
                }
                
                if (MostCommonBinInIndexArray(allLines, i, oxGenRatingBin, true))
                {
                    oxGenRatingBin += "1";
                }
                else
                {
                    oxGenRatingBin += "0";
                }
                
                if (MostCommonBinInIndexArray(allLines, i, co2ScrubRatingBin, false))
                {
                    co2ScrubRatingBin += "0";
                }
                else
                {
                    co2ScrubRatingBin += "1";
                }
            }

            oxGenRating = Convert.ToInt32(oxGenRatingBin, 2);
            co2ScrubRating = Convert.ToInt32(co2ScrubRatingBin, 2);

            Console.WriteLine(" -> BIN 1:{0}, \n -> BIN2:{1}", oxGenRatingBin, co2ScrubRatingBin);
            Console.WriteLine(" -> Final Answer: {0}", oxGenRating * co2ScrubRating);
            // Answer less than 3153975
        }

        private static bool MostCommonBinInIndexArray(string[] listOfBinNums, int index, string binSoFar, bool isOx)
        {
            int numOnes = 0;
            int numZeros = 0;

            for (int i = 0; i < listOfBinNums.Length; i++)
            {
                if (listOfBinNums[i][index] == '0' && IsInputPartOfString(binSoFar, listOfBinNums[i]))
                {
                    numZeros += 1;
                }
                else if (listOfBinNums[i][index] == '1' && IsInputPartOfString(binSoFar, listOfBinNums[i]))
                {
                    numOnes += 1;
                }
            }

            if (isOx)
            {
                return numOnes >= numZeros;
            }
            else
            {
                return numOnes > numZeros;
            }
        }

        private static bool IsInputPartOfString(string input, string compareTo)
        {
            string comparisionString = compareTo.Substring(0, input.Length);
            if (comparisionString == input)
            {
                Console.WriteLine("Input {0} | Compared to {1} | Output {2}", input, compareTo, comparisionString == input);
            }
            return comparisionString == input;
        }
    }
}