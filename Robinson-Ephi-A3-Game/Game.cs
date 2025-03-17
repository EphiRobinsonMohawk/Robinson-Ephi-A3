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
    // Colour variables
    Color oceanBlue = new Color(0, 157, 196);

    //Class variables
    Fish fish;
    CatchBar catchBar;
    //CatchProgress catchProgress;

    public void Setup()
    {
        Window.SetTitle("Fantastic Fishing");
        Window.SetSize(400, 600);

        fish = new Fish();
        catchBar = new CatchBar(); 
    }
    
    public void Update()
    {
        Window.ClearBackground(oceanBlue);
        //Background bar for catching fish
        Draw.FillColor = Color.Blue;
        Draw.Rectangle(120, 0, 80, 600);

        catchBar.Render(160);
        fish.Render(120, 300);
    }
    
   
}

