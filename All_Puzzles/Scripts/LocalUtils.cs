using System.IO;

namespace Puzzle_1.Scripts
{
    public class LocalUtils
    {
        private const string DirectoryPath = @"C:\Users\titas\RiderProjects\Advent_of_Code_2021\All_Puzzles\Inputs\";

        public string[] ReadAllLinesFromPuzzleInput(int pIndex)
        {
            // We will assume that all puzzle inputs will come in a standard name scheme
            string puzzleFileName = "PUZ" + pIndex + "_IN.txt";
            string absolutePath = DirectoryPath + puzzleFileName;
            string[] output = File.ReadAllLines(absolutePath);
            return output;
        }
    }
}