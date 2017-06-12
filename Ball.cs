using System;
using System.Collections.Generic;
using System.ComponentModel.Design;
using System.Dynamic;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;

namespace BallClasses
{
    class Ball
    {
        // The Ball class should have a size/radius as well as a color instance variable.  
        // You should use the Color type you just created.  Let's also add an instance variable that keeps track of the number of times it has been thrown.
        // Create any constructors you feel would be useful.
        // Create a Pop method, which changes the ball's size to 0.
        // Create a Throw method that adds 1 to the throw count, but only if the ball hasn't been popped (has a size of 0).
        // A method that returns the number of times the ball has been thrown.
        public int size;
        public string color;

        public static void Pop()
        {
            // Create a Pop method, which changes the ball's size to 0.
            Ball ball = new Ball();
            ball.size = 0;

        }

        public static void CreateBall()
        {
            Ball ball = new Ball();
            Console.WriteLine(ball.size);
        }

        public static void CountBalls()
        {
            Console.WriteLine("The total number of balls is 10");
        }

        public static void CreateRandomBall() // This is not complete yet
        {
            var rnd = new Random();
            Ball ball = new Ball();
            ball.size = 1;
            ball.color = "green";


            Console.WriteLine("\nCreating a random ball...\n");
            Console.WriteLine("Ball size is {0}, ball color is {1}\n", ball.size, ball.color);

            Menu.Intro();

            //ball.size = ;// Make this random
            //ball.color =; // Make this a random color
        }

        public static void CreateDefinedBall()
        {
            Console.WriteLine("What would you like to name your ball?");
            var ballName = Console.ReadLine();
            Ball ball = new Ball();
            Console.WriteLine("What size ball would you like to create?");
            ball.size = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("What color of ball would you like?");
            ball.color = Console.ReadLine();
            Console.WriteLine("\nYou have created a defined ball!, the color is {0} and the size is {1}\n", ball.color,ball.size);
            
            
            Menu.Intro();
        }

        public static void ListOfBalls()  // This is not complete yet
        {
            Console.WriteLine("\nThis is a list of balls.\n");
        }
        
    }
}
