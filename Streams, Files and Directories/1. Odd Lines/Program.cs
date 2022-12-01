using System;
using System.IO;

namespace OddLines
{
    public class Startup
    {
        static void Main(string[] args)
        {

            string inputFilePath = @"..\..\..\Files\input.txt";
            string outputFilePath = @"..\..\..\Files\output.txt";

            ExtractOddLines(inputFilePath, outputFilePath);







            static void ExtractOddLines(string inputFilePath, string outputFilePath)
            {
                using (StreamReader reader = new StreamReader("../../../input.txt"))
                {
                    using (StreamWriter writer = new StreamWriter("../../../output.txt"))
                    {
                        int row = 0;
                        while (!reader.EndOfStream)
                        {
                            string line = reader.ReadLine();

                            if (row++ % 2 != 0)
                            {
                                writer.WriteLine(line);
                            }

                        }
                    }
                }
            }


        }

        
    }
}


