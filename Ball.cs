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

        private Color color;

        private float radius;

        private int timesThrown;

        public Ball(Color color, float radius)
        {
            this.color = color;
            this.radius = radius;
            this.timesThrown = 0;
        }

        public void Pop()
        {
            radius = 0;
        }

        public void Throw()
        {
            if (radius > 0)
            {
                timesThrown++;
            }
        }

        public int GetTimesThrown()
        {
            return timesThrown;
        }


    }
}
