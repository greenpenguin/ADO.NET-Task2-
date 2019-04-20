using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Epam.Talalaykina.Task2_1_
{
    class Program
    {
        static void Main(string[] args)
        {
            WorkWithFile workWithFile = new WorkWithFile();
            User user = workWithFile.Read();
            workWithFile.Out(user.ToString());
        }
    }
}
