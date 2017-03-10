using System;
using Gtk;
using System.Diagnostics;

namespace Ant
{
	class MainClass
	{
		public static void Main (string[] args)
		{
  			Application.Init();
//			MainWindow win = new MainWindow ();
//			win.Show ();

//			WriteFile testObj = new WriteFile("/home/andrew/testfile.csv");
//			testObj.writeDatetime ();
//			testObj.writeMessage ("test \"this\" message3");

            PromptManager testObj = new PromptManager("/home/andrew/Desktop/testfile.csv","10:57 PM");
			testObj.startTimer ();
            

			Application.Run();

		}
	}
}
