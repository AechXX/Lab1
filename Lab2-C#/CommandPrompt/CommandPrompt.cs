using System;
using System.Collections.Generic;
using System.Text;

namespace CommandPrompt
{
    class CommandPrompt
    {
        int height;
        int columns;

        string[] screenText;

        // unknownType backgroundColor;
        // unknownType foregroundColor;

    public CommandPrompt(int height, int columns)
    {
    
        screenText = new string[height];



        Console.SetWindowSize(columns, height + 7);


        for (int i = 0; i < screenText.Length; i++)
        {
            screenText[i] = "";
        }
    }   // end of CommandPrompt constructor
    public void Display()
    {
        // set the foreground and background colors
        Console.Clear();             //  the Console object is available to us to control aspects of our terminal window. The Clear method will blank our window
                                     // The Clear method has blanked the screen and left the cursor at the top of the window.
                                     // We will now loop through the screenText array to put out text on the screen.
        for (int i = 0; i < screenText.Length; i++)
        {
            Console.WriteLine(screenText[i]);
        }
    }   // end of Display method

    public void SetScreenText(int lineNumber, string lineOfText)
    {
        screenText[lineNumber] = lineOfText;
    }   // end of SetScreenText method
    } // end of CommandPrompt class

}