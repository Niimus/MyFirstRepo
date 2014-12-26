using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApplication1
{
    class Car
    {
        public string petName;
        public int currSpeed;

        public void PrintState()
        {
            Console.WriteLine("{0} is going {1} MPH.",petName,currSpeed);
        }

        public void SpeedUp(int delta)
        {
            currSpeed += delta;
        }
    }
}
