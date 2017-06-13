using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BallClasses
{
    class Color
    {
        // On a computer, colors are typically represented with a red, green, blue and alpha(transparency) value, usually in the range of 0 to 255.
        // Add these as instance variables.
        // What type did you chose to represent these and why?
        // A constructor that takes a red, green, blue and alpha value.
        // Methods to get (retrieve) the red, green, blu, and alpha values from a color object, as well as set new values for each.
        // A method to get the grayscale value for the color, which is the average of the red, green, and blue values.

        private byte red;

        private byte green;

        private byte blue;

        private byte alpha;

        public Color(byte red, byte green, byte blue, byte alpha)
        {
            this.red = red;
            this.green = green;
            this.blue = blue;
            this.alpha = alpha;
        }

        public Color(byte red, byte green, byte blue)
        {
            this.red = red;
            this.green = green;
            this.blue = blue;
            this.alpha = 255;
        }

        public byte GetRed()
        {
            return red;
        }

        public byte GetGreen()
        {
            return green;
        }

        public void SetGreen(byte green)
        {
            this.green = green;
        }

        public byte GetBlue()
        {
            return blue;
        }

        public void SetBlue(byte blue)
        {
            this.blue = blue;
        }

        public byte GetAlpha()
        {
            return alpha;
        }

        public void SetAlpha(byte alpha)
        {
            this.alpha = alpha;
        }

        public byte GetGrayscale()
        {
            return (byte) ((red + green + blue) / 3);
        }
    }
}
