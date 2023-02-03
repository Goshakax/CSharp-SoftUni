namespace EvenLines
{
    using System;
    using System.IO;
    using System.Linq;
    using System.Xml;

    public class EvenLines
    {
        static void Main()
        {
            string inputFilePath = @"..\..\..\text.txt";

            Console.WriteLine(ProcessLines(inputFilePath));
        }

        public static string ProcessLines(string inputFilePath)
        {
            using (StreamReader r = new StreamReader(inputFilePath))
            {
                string line = string.Empty;
                int lineNum = 0;
                string output = null;

                while ((line = r.ReadLine()) != null)
                {
                    if (lineNum % 2 == 0)
                    {
                         line.Reverse();

                        line = line.Replace(',', '@');
                        line = line.Replace('-', '@');
                        line = line.Replace('!', '@');
                        line = line.Replace('?', '@');
                        line = line.Replace('.', '@');

                        string[] reversedLine = line.Split(' ').Reverse().ToArray();

                        if (lineNum == 0)
                        {
                            output += $"{string.Join(' ', reversedLine)}";
                        }
                        else
                        {
                            output += $"\n{string.Join(' ', reversedLine)}";
                        }
                        
                    }
                    lineNum++;
                }

                return output;
            }

            
        }
    }
}
