using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;

namespace Epam.Talalaykina.Task2_2
{
    public class WorkWithFile
    {
        private const string fileInName = "test.txt";
        private const string fileOutName = "Auto.txt";

        public List<double> Read()
        {
            List<double> circleData = new List<double>();
            
            using (StreamReader file = new StreamReader(fileInName))
            {
                string[] StrFromFile = file.ReadToEnd().Split(new[] {" ", "\n"}, StringSplitOptions.RemoveEmptyEntries)
                    .Select(item => item.Trim())
                    .Where(item => !string.IsNullOrEmpty(item)).ToArray();
                foreach (var s in StrFromFile)
                {
                    if (!double.TryParse(s, out var value))
                    {
                        throw new ArgumentException("ERROR in reading file");
                    }
                    else
                    {
                        circleData.Add(value);
                    }
                }
                
                return circleData;
                
            }
        }
        
        public void Save(double areaOfRing, double sumOfLength)
        {
            using (StreamWriter sw = new StreamWriter(fileOutName))
            {
                sw.WriteLine("Area of ring {0}", areaOfRing);
                sw.WriteLine("The sum of the lengths of the circles {0}", sumOfLength);
            }
        }
    }
}