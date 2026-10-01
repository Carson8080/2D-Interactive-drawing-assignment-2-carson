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
        //creates true or false bool for the state of the each button
        bool button1 = false;
        bool button2 = false;
        bool button3 = false;
        bool buttonAll = false;

        /// <summary>
        ///     Setup runs once before the game loop begins.
        /// </summary>
        public void Setup()
        {
            // create window
            Window.SetTitle("Cool Buttons");
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
            Draw.Rectangle(120, 60, 160, 60);

            //Create button orange
            Draw.SetFillColor(255, 154, 0);
            Draw.Rectangle(120, 170, 160, 60);

            //Create button yellow
            Draw.SetFillColor(255, 255, 0);
            Draw.Rectangle(120, 280, 160, 60);

            //Create small button white
            Draw.SetFillColor(255, 255, 255);
            Draw.Rectangle(170, 360, 60, 20);

            //changes shade of red if cursor is over top button
            if ((Input.GetMouseX() > 120 && Input.GetMouseX() < 280) && (Input.GetMouseY() > 60 && Input.GetMouseY() < 120))
            {
                //Create button lighter red
                Draw.SetFillColor(255, 134, 134);
                Draw.Rectangle(120, 60, 160, 60);
            }

            //changes shade of orange if cursor is over middle button
            if ((Input.GetMouseX() > 120 && Input.GetMouseX() < 280) && (Input.GetMouseY() > 170 && Input.GetMouseY() < 230))
            {
                //Create button lighter orange
                Draw.SetFillColor(255, 215, 134);
                Draw.Rectangle(120, 170, 160, 60);
            }

            //changes shade of yellow if cursor is over bottom button
            if ((Input.GetMouseX() > 120 && Input.GetMouseX() < 280) && (Input.GetMouseY() > 280 && Input.GetMouseY() < 340))
            {
                //Create button lighter yellow
                Draw.SetFillColor(248, 255, 134);
                Draw.Rectangle(120, 280, 160, 60);
            }

            //changes shade to grey if cursor is over all button
            if ((Input.GetMouseX() > 170 && Input.GetMouseX() < 230) && (Input.GetMouseY() > 360 && Input.GetMouseY() < 380))
            {
                //Create button grey
                Draw.SetFillColor(183, 183, 183);
                Draw.Rectangle(170, 360, 60, 20);
            }


            //checks the state of the button bool and changes it to the opposite state if the top button is pressed
            if (Input.IsMouseButtonPressed(MouseButton.Left) && ((Input.GetMouseX() > 120 && Input.GetMouseX() < 280) && (Input.GetMouseY() > 60 && Input.GetMouseY() < 120)))
            {
                if (button1 == true)
                {
                    button1 = false;
                }
                else if (button1 == false)
                {
                    button1 = true;
                }

            }

            //checks the state of the button bool and changes it to the opposite state if the middle button is pressed
            if (Input.IsMouseButtonPressed(MouseButton.Left) && ((Input.GetMouseX() > 120 && Input.GetMouseX() < 280) && (Input.GetMouseY() > 170 && Input.GetMouseY() < 230)))
            {
                if (button2 == true)
                {
                    button2 = false;
                }
                else if (button2 == false)
                {
                    button2 = true;
                }

            }

            //checks the state of the button bool and changes it to the opposite state if the bottom button is pressed
            if (Input.IsMouseButtonPressed(MouseButton.Left) && ((Input.GetMouseX() > 120 && Input.GetMouseX() < 280) && (Input.GetMouseY() > 280 && Input.GetMouseY() < 340)))
            {
                if (button3 == true)
                {
                    button3 = false;
                }
                else if (button3 == false)
                {
                    button3 = true;
                }

            }

            //checks the state of the button bool and changes it to the opposite state if the all button is pressed
            if (Input.IsMouseButtonPressed(MouseButton.Left) && ((Input.GetMouseX() > 170 && Input.GetMouseX() < 230) && (Input.GetMouseY() > 360 && Input.GetMouseY() < 380)))
            {
                if (buttonAll == true)
                {
                    buttonAll = false;
                }
                else if (buttonAll == false)
                {
                    buttonAll = true;
                }

            }

            //Changes the colors of the screen and top button based on the state of the button1 boolean
            if (button1 == true)
            {
                //fill background white
                Window.ClearBackground(255);

                //Create button green
                Draw.SetFillColor(0, 255, 0);
                Draw.Rectangle(120, 60, 160, 60);


                //changes shade of green if cursor is over button
                if ((Input.GetMouseX() > 120 && Input.GetMouseX() < 280) && (Input.GetMouseY() > 60 && Input.GetMouseY() < 120))
                {
                    //Create button lighter green
                    Draw.SetFillColor(134, 255, 134);
                    Draw.Rectangle(120, 60, 160, 60);
                }
            }

            //Changes the colors of the screen and middle button based on the state of the button2 boolean
            if (button2 == true)
            {
                //fill background white
                Window.ClearBackground(255);

                //Create button blue
                Draw.SetFillColor(0, 0, 255);
                Draw.Rectangle(120, 170, 160, 60);


                //changes shade of green if cursor is over button
                if ((Input.GetMouseX() > 120 && Input.GetMouseX() < 280) && (Input.GetMouseY() > 170 && Input.GetMouseY() < 230))
                {
                    //Create button lighter blue
                    Draw.SetFillColor(125, 134, 255);
                    Draw.Rectangle(120, 170, 160, 60);
                }
            }

            //Changes the colors of the screen and bottom button based on the state of the button3 boolean
            if (button3 == true)
            {
                //fill background white
                Window.ClearBackground(255);

                //Create button purple
                Draw.SetFillColor(255, 0, 255);
                Draw.Rectangle(120, 280, 160, 60);


                //changes shade of green if cursor is over button
                if ((Input.GetMouseX() > 120 && Input.GetMouseX() < 280) && (Input.GetMouseY() > 280 && Input.GetMouseY() < 340))
                {
                    //Create button lighter purple
                    Draw.SetFillColor(255, 134, 255);
                    Draw.Rectangle(120, 280, 160, 60);
                }
            }

            //Changes the colors of the screen and all the buttons based on the state of the buttonAll boolean
            if (buttonAll == true)
            {
                //fill background white
                Window.ClearBackground(255);

                //Create button green
                Draw.SetFillColor(0, 255, 0);
                Draw.Rectangle(120, 60, 160, 60);

                //Create button blue
                Draw.SetFillColor(0, 0, 255);
                Draw.Rectangle(120, 170, 160, 60);

                //Create button purple
                Draw.SetFillColor(255, 0, 255);
                Draw.Rectangle(120, 280, 160, 60);

                //Create button black
                Draw.SetFillColor(0, 0, 0);
                Draw.Rectangle(170, 360, 60, 20);


                //changes shade of green if cursor is over button
                if ((Input.GetMouseX() > 170 && Input.GetMouseX() < 230) && (Input.GetMouseY() > 360 && Input.GetMouseY() < 380))
                {
                    //Create button grey
                    Draw.SetFillColor(183, 183, 183);
                    Draw.Rectangle(170, 360, 60, 20);
                }
            }

        }
    }

}