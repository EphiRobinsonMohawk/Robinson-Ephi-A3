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
    // Normal variables
    Color oceanBlue = new Color(0, 157, 196);
    float barHeight;
    float fishHeight = 300; //where the fish initially spawns
    float barSpeed = 4; //how fast the bar drops
    float barVelocity;

    //Class variables
    Fish fish;
    CatchBar catchBar;
    //CatchProgress catchProgress;

    public void Setup()
    {
        Window.SetTitle("Fantastic Fishing");
        Window.SetSize(400, 600);
        barHeight = Random.Integer(40, 540);

        fish = new Fish();
        catchBar = new CatchBar(); 
    }
    
    public void Update()
    {
        Window.ClearBackground(oceanBlue);

        //Background bar for catching fish
        Draw.FillColor = Color.Blue;
        Draw.Rectangle(120, 0, 80, 600);

        //Accelerate over time
        barVelocity += Time.DeltaTime * barSpeed;

        //Update position based on velocity
        barHeight += barVelocity;

        //Detect at edge
        bool isAtEdge = barHeight + 40 >= Window.Height;
        if (isAtEdge)
        {
            barVelocity = -0.3f;
        }

        if ()


        //Drawing the key moving objects to screen
        catchBar.Render(barHeight);
        fish.Render(120, fishHeight);
    }
    
   
}

