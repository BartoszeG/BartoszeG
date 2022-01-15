using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace zadanie9
{
    class ProgramEnum
    {
        enum MyEnum
        {
            PKP,
            INTERCITY,
            EDUKACJA,
            NAUKOWA,
            INFORMATYCZNA,
            KLASYCZNA,
        }
        public static void solution()
        {
            int namesCount = Enum.GetNames(typeof(MyEnum)).Length;
            for (int i = 0; i < namesCount; i++)
            {
                Console.WriteLine($"Enum:{Enum.GetNames(typeof(MyEnum))[i]} Wartość: {i}");
            }
        }
    }
}