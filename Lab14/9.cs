using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab14
{
    class _9
    {
        public class Taxi
        {
            private static bool IsInitialized;
            public static int i = 5;

            private Taxi()
            {
                IsInitialized = true;
            }
        }

        class TestTaxi
        {
            static void Main()
            {
                Taxi t = new Taxi();
                Console.WriteLine(t.IsInitialized);
                i = Console.ReadLine();
            }
        }
    }
}
