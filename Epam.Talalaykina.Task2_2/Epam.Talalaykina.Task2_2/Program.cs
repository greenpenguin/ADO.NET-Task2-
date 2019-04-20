using System.Collections.Generic;

namespace Epam.Talalaykina.Task2_2
{
    internal class Program
    {
        public static void Main(string[] args)
        {
            WorkWithFile workWithFile = new WorkWithFile();
            List<double> dataList = new List<double>();

            dataList = workWithFile.Read();

            Ring test = new Ring(dataList);
            double area = test.AreaOfRing();
            double sum = test.SumOfLengthsOfCircles();

            workWithFile.Save(area, sum);
        }
    }
}