using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Epam.Talalaykina.Task2_1_
{
    class WorkWithFile
    {
        private const string FileIn = "input.txt";
        private const string FileOut = "output.txt";
        public User Read()
        {
            List<string> dataList = new List<string>();

            using (StreamReader reader = new StreamReader(FileIn))
            {
                User user;
                string[] fromFile = reader.ReadToEnd().Split(new[] { ' ', '\r', '\n', ';' },
                    StringSplitOptions.RemoveEmptyEntries)
                    .Select(item => item.Trim())
                    .Where(item => !string.IsNullOrEmpty(item)).ToArray();
                foreach (var t in fromFile)
                {
                    dataList.Add(t);
                }
                if (dataList.Count() == 5)
                {
                    user = new User(dataList[0], dataList[1], dataList[2], DateTime.Parse(dataList[3]), int.Parse(dataList[4]));
                }
                else
                {
                    user = new Employee(dataList[0], dataList[1], dataList[2], DateTime.Parse(dataList[3]), int.Parse(dataList[4]), int.Parse(dataList[5]), dataList[6]);
                }
                return user;
            }

        }
        public void Out(string s)
        {
            using (StreamWriter fileOut = new StreamWriter(FileOut))
            {
                fileOut.WriteLine(s);
            }
        }
    }
}
