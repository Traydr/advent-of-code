using System;

namespace Puzzle_1.Scripts
{
    public class Puz2
    {
        private static LocalUtils _localUtils = new LocalUtils();
        
        public static void RunPuzzle()
        {
            Part1();
            Part2();
        }

        private static void Part1()
        {
            string[] allLines = _localUtils.ReadAllLinesFromPuzzleInput(2);

            int horizontalPos = 0;
            int depth = 0;

            for (int i = 0; i < allLines.Length; i++)
            {
                string currentCommand = allLines[i];
                string command = currentCommand.Split(" ")[0];
                int value = int.Parse(currentCommand.Split(" ")[1]);

                switch (command)
                {
                    case "forward":
                        horizontalPos += value ;
                        break;
                    case "down":
                        depth += value;
                        break;
                    case "up":
                        depth -= value;
                        break;
                }
            }
            
            Console.WriteLine("The final horizontal position was: {0} \n The final depth was: {1} \n The multiplied total is: {2}", horizontalPos, depth, horizontalPos * depth);
        }

        private static void Part2()
        {
            string[] allLines = _localUtils.ReadAllLinesFromPuzzleInput(2);

            int horizontalPos = 0;
            int depth = 0;
            int aim = 0;

            for (int i = 0; i < allLines.Length; i++)
            {
                string currentCommand = allLines[i];
                string command = currentCommand.Split(" ")[0];
                int value = int.Parse(currentCommand.Split(" ")[1]);

                switch (command)
                {
                    case "forward":
                        horizontalPos += value;
                        depth += aim * value;
                        break;
                    case "down":
                        aim += value;
                        break;
                    case "up":
                        aim -= value;
                        break;
                }
            }
            
            Console.WriteLine("The final horizontal position was: {0} \n" +
                              "The final depth was: {1} \n" +
                              "The final aim was: {2} \n" +
                              "The multiplied total is: {3}", horizontalPos, depth, aim, horizontalPos * depth);
        }
    }
}