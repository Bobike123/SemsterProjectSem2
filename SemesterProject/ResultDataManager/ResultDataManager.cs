using System;
using System.IO;

namespace SemesterProject
{
    public class ResultDataManager
    {
        public static void AppendToCSV(string filePath, string[][] data)
        {
            using (StreamWriter writer = new StreamWriter(filePath, true))
            {
                foreach (string[] line in data)
                {
                    writer.WriteLine(string.Join(",", line));
                }
            }
        }

        public static void AppendDoubleJaggedArrayToCSV(string filePath, double[][] data)
        {
            using (StreamWriter writer = new StreamWriter(filePath, true))
            {
                foreach (double[] row in data)
                {
                    string[] stringRow = Array.ConvertAll(row, x => x.ToString());
                    writer.WriteLine(string.Join(",", stringRow));
                }
            }
        }
        public static void AppendIntArrayToCSV(string filePath, int[][] data)
        {
            using (StreamWriter writer = new StreamWriter(filePath, true))
            {
                foreach (int[] row in data)
                {
                    string[] stringRow = Array.ConvertAll(row, x => x.ToString());
                    writer.WriteLine(string.Join(",", stringRow));
                }
            }
        }
        public static void AppendDoubleArrayToCSV(string filePath, double[] data)
        {
            using (StreamWriter writer = new StreamWriter(filePath, true))
            {
                foreach (double row in data)
                {
                    string stringRow = row.ToString();
                    writer.WriteLine(string.Join(",", stringRow));
                }
            }
        }
    }
}