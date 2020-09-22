﻿using System;
using System.IO;

namespace Sender
{
    public class Program
    {
        static void Main()
        {
            string path = Environment.CurrentDirectory+ @"\Sender_csv\Sender_Csv_File.csv";
            CsvFileReader.CheckAndReadCsvFile(path);
        }
        public static string FileLength()
        {

            if (File.ReadAllLines(Environment.CurrentDirectory + @"\Sender_csv\Sender_Csv_File.csv").Length > 0)
                return "0";
            else
                return "1";

        }
        public static bool PathOfFile()
        {
            string path = Environment.CurrentDirectory + @"\Sender_csv\Sender_Csv_File.csv";

            return File.Exists(path);
        }
    }
}
