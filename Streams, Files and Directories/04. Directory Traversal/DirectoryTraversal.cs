namespace DirectoryTraversal
{
    using System;
    using System.Collections.Generic;
    using System.IO;
    using System.Net.Sockets;
    using System.Text.RegularExpressions;

    public class DirectoryTraversal
    {
        static void Main()
        {
            string path = Console.ReadLine();
            string reportFileName = @"\report.txt";

            string reportContent = TraverseDirectory(path);
            Console.WriteLine(reportContent);

            WriteReportToDesktop(reportContent, reportFileName);
        }

        public static string TraverseDirectory(string inputFolderPath)
        {
            DirectoryInfo dir = new DirectoryInfo(inputFolderPath);

            FileInfo[] fileInfos = dir.GetFiles("*", SearchOption.AllDirectories);
            FileInfo[] infos = fileInfos;
            string output = string.Empty;
            Dictionary<string, Dictionary<string, long>> dict = new Dictionary<string, Dictionary<string, long>>();

            foreach (FileInfo file in infos) 
            {
                if (!dict.ContainsKey(file.Extension))
                {
                    dict.Add(file.Extension, new Dictionary<string, long>());
                }

                dict[file.Extension].Add(file.Name, file.Length); 
            }
            int count = 0;
            foreach (var extension in dict) 
            {
                if (count == 0)
                {
                    output += extension.Key;
                }
                else
                {
                    output += $"\n{extension.Key}";
                }

                foreach (var file in extension.Value)
                {
                    output += $"\n--{file.Key} - {file.Value}kb";
                }

                count++;
            }

           return output;
        }

        public static void WriteReportToDesktop(string textContent, string reportFileName)
        {
            string desktopPath = Environment.GetFolderPath(Environment.SpecialFolder.Desktop);
            using (StreamWriter w = new StreamWriter($"{desktopPath}{reportFileName}"))
            {
                w.Write(textContent);
            }
        }
    }
}
