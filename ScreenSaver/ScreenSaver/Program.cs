using System;
using System.Collections.Generic;
using System.Windows.Forms;

namespace ScreenSaver
{
    static class Program
    {
        /* Main takes in command line arguments, which inform the program which mode it 
         * should run in.  There are three possible arguments, which may be passed in either 
         * upper or lower case:
         *      1. /p - preview mode
         *      2. /c - configuration mode 
         *      3. /s - show screensaver
         */
        [STAThread]
        static void Main(string[] args)
        {
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);

            if (args.Length > 0)
            {
                //sets firstArg to what was passed in through the command line
                string firstArg = args[0].ToLower().Trim();
                string secondArg = null;

                //if firstArg.Length > 2, then a second argument was also passed from the command line
                //this is a decimal number representing the handle to the parent's window
                //Example: /c:1234567
                if (firstArg.Length > 2)
                {
                    //sets the second argument to everything after the third index
                    //of the command line argument
                    secondArg = firstArg.Substring(3).Trim();
                    //resets firstArg to the first three characters of the command line argument
                    firstArg = firstArg.Substring(0, 2);
                }
                else if (args.Length > 1)
                {
                    secondArg = args[1];
                }
                //show screensaver mode
                if (firstArg == "/s")
                {
                    DisplayScreenSaver();
                    Application.Run();
                }
                //preview mode
                else if (firstArg == "/p")
                {
                    //displays an error message and terminates if the window handle 
                    //was not provided
                    if (secondArg == null)
                    {
                        MessageBox.Show("I'm sorry, the expected window handle was not received",
                            "ScreenSaver", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                        return;
                    }
                    //otherwise start the application using a constructor for ScreenSaverForm
                    //IntPtr is an integer whose size is platform specific.  
                    //It is used to wrap a pointer or a handle.
                    IntPtr previewHandle = new IntPtr(long.Parse(secondArg));
                    Application.Run(new ScreenSaverForm(previewHandle));

                }
                //configuration mode
                else if (firstArg == "/c")
                {
                    //launches SettingsForm
                    Application.Run(new SettingsForm());
                }
                //invalid argument
                //display error message
                else
                {
                    MessageBox.Show("Invalid argument: " + firstArg,
                        "ScreenSaver", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                }
            }

            //no arguments were passed in through the command line
            //treat like /s
            else
            {
                DisplayScreenSaver();
                Application.Run();
            }
        }

        static void DisplayScreenSaver()
        {
            //allows multi-screen display
            foreach (Screen screen in Screen.AllScreens)
            {
                ScreenSaverForm screensaver = new ScreenSaverForm(screen.Bounds);
                screensaver.Show();
            }
        }
    }
}