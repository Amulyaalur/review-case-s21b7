﻿using System;
namespace Sender
{
    public class Program
    {
        static void Main(string[] args)
        {
            string path = "D:/Review_Csv_File.csv";
            CsvFileReader.CheckAndReadCsvFile(path);
        }

         public static string fileLength()
        {

            if (File.ReadAllLines(@"D:/Review_Csv_File.csv").Length > 0)
                return "0";
            else
                return "1";

        }
        public static bool pathOfFile()
        {
            string path = @"D:/Review_Csv_File.csv";
            return File.Exists(path);
        }
    }
}