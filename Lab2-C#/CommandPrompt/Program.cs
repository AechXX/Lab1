using System;

namespace CommandPrompt
{
    class Program
    {
        static void Main(string[] args)
        {
            CommandPrompt myCommand = new CommandPrompt(5, 6);
            myCommand.SetScreenText(2, "This is line 2 text.");
            myCommand.SetScreenText(1, "This is line 1 text.");
            myCommand.SetScreenText(4, "At line 4.");
            myCommand.Display();
            Console.ReadLine();
        }
    }
}