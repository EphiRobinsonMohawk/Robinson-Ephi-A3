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
    Color cucumber = new Color(58, 176, 158);

    //Bar Variables
    float barHeight;
    float barSpeed = 4; //how fast the bar drops
    float barVelocity;
    //Fish Variables
    float fishHeight;
    float fishSpeed;
    bool goingDown = true;
    float switchTime;
    float switchInterval;
    float catchProgress;
    float catchDistance;
    bool hasWon = false;


    //Class variables
    Fish fish;
    CatchBar catchBar;
    CatchProgress catchProgression;

    public void Setup()
    {
        Window.SetTitle("Fantastic Fishing");
        Window.SetSize(400, 600);
        //Random spawn points for bar and fish
        barHeight = Random.Integer(40, 540);
        fishHeight = Random.Integer(100, 300);
        switchInterval = Random.Float(3, 5);
        fishSpeed = 70;

        //Making the fish and bar EXIST (not be null >:(  )
        fish = new Fish();
        catchBar = new CatchBar();
        catchProgression = new CatchProgress();
    }
    
    public void Update()
    {
        catchDistance = fishHeight - barHeight;
        Window.ClearBackground(oceanBlue);

        //Background bar for catching fish
        Draw.FillColor = Color.Blue;
        Draw.Rectangle(120, 0, 80, 600);

        //Accelerate over time
        barVelocity += Time.DeltaTime * barSpeed;

        //Update position based on velocity
        barHeight += barVelocity;

        //Detect at edge and kill velocity at edge
        bool isAtEdge = barHeight + 40 >= Window.Height;
        if (isAtEdge)
        {
            barVelocity = -0.2f;
        }

        //Make the bar go up when the player presses space
        if (Input.IsKeyboardKeyPressed(KeyboardInput.Space))
        {
            barVelocity = -2.0f;
        }

        //Make the fish move up and down
        if (goingDown == true)
        {
            fishHeight += Time.DeltaTime * (fishSpeed);
        }
        if (goingDown == false)
        {
            fishHeight -= Time.DeltaTime * (fishSpeed);
        }
        //check which the fish needs to switch directions
        switchTime += Time.DeltaTime;
        if (switchTime >= switchInterval && goingDown == false)
        {
            switchTime = 0;
            goingDown = true;
            switchInterval = Random.Float(1.5f, 4.5f);
        }

        if (switchTime >= switchInterval && goingDown == true)
        {
            switchTime = 0;
            goingDown = false;
            switchInterval = Random.Float(1.5f, 4.5f);
        }
        //switches the fish's direction if it hits the edges
        if (fishHeight <= 0)
        {
            goingDown = true;
        }

        if (fishHeight >= 550)
        {
            goingDown = false;
        }


        if (catchDistance <= 40 && catchDistance >= -40 && catchProgress <= 5.03f)
        {
            catchProgress += Time.DeltaTime;
        }

        if (catchProgress >= 5)
        {
            hasWon = true;
        }

        if (catchProgress > 0 && hasWon != true)
        {
            catchProgress -= Time.DeltaTime / 2;
        }


        //Drawing the key moving objects to screen
        catchBar.Render(barHeight);
        fish.Render(120, fishHeight);
        catchProgression.Render(260, 40, catchProgress);

        Text.Size = 16;
        Text.Draw("Catch Progress", 260, 24);

        if (hasWon == true)
        {
            Draw.FillColor = cucumber;
            Draw.Rectangle(0, 0, Window.Width, Window.Height);
            Text.Size = 30;
            Text.Draw("YOU WIN", 50, 50);
            Text.Size = 20;
            Text.Draw("YOU CAUGHT A BLUE BUCKO!", 50, 100);
        }
    }
    
   
}

