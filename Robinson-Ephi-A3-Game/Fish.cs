using System;
using System.Numerics;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MohawkGame2D
{
    public class Fish
    {
        //
        Color lightBlue = new Color(170, 192, 216);
        Color darkBlue = new Color(95, 148, 179);
        Color eyeOrange = new Color(248, 190, 56);
        Color transparant = new Color(0, 0, 0, 0);



        public void Render(float x, float y)
        {
            Draw.LineColor = transparant;

            //Tail Fin
            Draw.FillColor = darkBlue;
            Draw.Triangle(x + 64, y + 26, x + 74, y + 16, x + 74, y + 38);

            //Nose
            Draw.FillColor = lightBlue;
            Draw.Triangle(x + 15, y + 25, x + 30, y + 13, x + 30, y + 37);

            //Butt
            Draw.FillColor = lightBlue;
            Draw.Triangle(x + 47, y + 12, x + 47, y + 38, x + 68, y + 26);

            //Body
            Draw.FillColor = lightBlue;
            Draw.Ellipse(x + 39, y + 25, 28, 30);

            //Front Fin
            Draw.FillColor = darkBlue;
            Draw.Triangle(x + 38, y + 32, x + 52, y + 40, x + 40, y + 42);

            //Eye Outer
            Draw.FillColor = eyeOrange;
            Draw.Circle(x + 25, y + 23, 3);

            //Eye Inner
            Draw.FillColor = Color.Black;
            Draw.Circle(x + 25, y + 23, 1);

            //Gills
            Draw.FillColor = darkBlue;
            Draw.Rectangle(x + 36, y + 28, 12, 1);
            Draw.Rectangle(x + 36, y + 26, 12, 1);
            Draw.Rectangle(x + 36, y + 24, 12, 1);
        }  //Function to render the fish to  the screen
    }
}
