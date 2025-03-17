// Include the namespaces (code libraries) you need below.
using System;
using System.Numerics;
using System.Runtime.CompilerServices;
using Microsoft.VisualBasic.FileIO;

// The namespace your code is in.
namespace MohawkGame2D;


public class Game
{
    // Place your variables here:
    Color oceanBlue = new Color(0, 157, 196);
    Color lightBlue = new Color(170, 192, 216);
    Color darkBlue = new Color(95, 148, 179);
    Color eyeOrange = new Color(248, 190, 56);
    Color transparant = new Color(0, 0, 0, 0);

    public void Setup()
    {
        Window.SetSize(400, 600);
        Window.SetTitle("Fantastic Fishing");
    }
    
    public void Update()
    {
        Window.ClearBackground(oceanBlue);
        //Background bar for catching fish
        Draw.FillColor = Color.Blue;
        Draw.Rectangle(120, 0, 80, 600);

        spawnFish(120, 200);

        spawnCatchBar(0, 0);
    }
    void spawnCatchBar(float x, float y)
    {
        Draw.FillColor = Color.Green;
        Draw.Rectangle(120, 300, 80, 40);

    }

    //Function to draw a fish
    void spawnFish(float x,float y)
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
    }
}

