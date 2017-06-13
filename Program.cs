using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BallClasses
{
    
    class Program
    {
        
        static void Main(string[] args)
        {
            // Write some code in your Main method to create a few balls, throw them around a few times, 
            // pop a few, and try to throw them again, and print out the number of times that the balls have been thrown. (Popped balls shouldn't have changed.)

            Ball bigRed = new Ball(new Color(255, 0, 0), 5);
            Ball littlePurple = new Ball(new Color(255, 0, 255), 3 );

            bigRed.Throw();
            bigRed.Throw();
            bigRed.Throw();
            Console.WriteLine(bigRed.GetTimesThrown());

            bigRed.Throw();
            bigRed.Throw();
            Console.WriteLine(bigRed.GetTimesThrown());

            littlePurple.Throw();
            littlePurple.Throw();
            Console.WriteLine(littlePurple.GetTimesThrown());

            littlePurple.Pop();
            littlePurple.Throw();
            Console.WriteLine(littlePurple.GetTimesThrown());

            Console.ReadKey();






        }
    }
}
