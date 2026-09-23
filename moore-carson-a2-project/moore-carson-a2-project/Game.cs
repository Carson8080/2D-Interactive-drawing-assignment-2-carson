// Include the namespaces (code libraries) you need below.
using System;
using System.Drawing;
using System.Numerics;
using System.Security.Cryptography.X509Certificates;

// The namespace your code is in.
namespace MohawkGame2D
{
    /// <summary>
    ///     Your game code goes inside this class!
    /// </summary>
    public class Game
    {
        //creates true or false bool
        bool mouse = false;

        /// <summary>
        ///     Setup runs once before the game loop begins.
        /// </summary>
        public void Setup()
        {
            // create window
            Window.SetTitle("Cool button");
            Window.SetSize(400, 400);

        }

        /// <summary>
        ///     Update runs every frame.
        /// </summary>
        public void Update()
        {

            //fill background black
            Window.ClearBackground(0);

            //Create button red
            Draw.SetFillColor(255, 0, 0);
            Draw.Rectangle(120, 170, 160, 60);


            //changes shade of red if cursor is over button
            if ((Input.GetMouseX() > 120 && Input.GetMouseX() < 280) && (Input.GetMouseY() > 170 && Input.GetMouseY() < 230))
            {
                //Create button lighter red
                Draw.SetFillColor(255, 120, 120);
                Draw.Rectangle(120, 170, 160, 60);
            }



            if (Input.IsMouseButtonDown(MouseButton.Left) && (Input.GetMouseX() > 120 && Input.GetMouseX() < 280) && (Input.GetMouseY() > 170 && Input.GetMouseY() < 230))
            {
                mouse = true;

            }

            if (mouse == true)
            {
                //fill background white
                Window.ClearBackground(255);

                //Create button green
                Draw.SetFillColor(0, 255, 0);
                Draw.Rectangle(120, 170, 160, 60);

                //changes shade of green if cursor is over button
                if ((Input.GetMouseX() > 120 && Input.GetMouseX() < 280) && (Input.GetMouseY() > 170 && Input.GetMouseY() < 230))
                {
                    //Create button lighter green
                    Draw.SetFillColor(120, 255, 120);
                    Draw.Rectangle(120, 170, 160, 60);
                }
            }
            else if (mouse = false)
            {
                //fill background black
                Window.ClearBackground(0);

                //Create button red
                Draw.SetFillColor(255, 0, 0);
                Draw.Rectangle(120, 170, 160, 60);


            }


        }
    }

}