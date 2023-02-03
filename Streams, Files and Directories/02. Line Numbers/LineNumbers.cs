namespace LineNumbers
{
    using System;
    using System.IO;

    public class LineNumbers
    {
        static void Main()
        {
            string inputFilePath = @"..\..\..\text.txt";
            string outputFilePath = @"..\..\..\output.txt";

            ProcessLines(inputFilePath, outputFilePath);
        }

        public static void ProcessLines(string inputFilePath, string outputFilePath)
        {
            using (StreamReader r = new StreamReader(inputFilePath))
            {
                using (StreamWriter w = new StreamWriter(outputFilePath))
                {
                    int lineNum = 1;
                    string line = "";

                    while ((line = r.ReadLine()) != null)
                    {
                        int letterCount = 0;
                        int othersCount = 0;

                        foreach (var item in line)
                        {
                            if (char.IsLetter(item))
                            {
                                letterCount++;
                            }
                            else if (item != ' ')
                            {
                                othersCount++;
                            }

                        }

                        w.WriteLine($"Line {lineNum}: {line} ({letterCount})({othersCount})");
                        lineNum++;
                        
                    }
                }
            }
        }
    }
}
