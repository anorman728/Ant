using System;
using Gtk;

namespace Ant
{
	class MainClass
	{
		public static void Main (string[] args)
		{
//			Application.Init ();
//			MainWindow win = new MainWindow ();
//			win.Show ();
//			Application.Run ();
			WriteFile testObj = new WriteFile("/home/andrew/testfile.csv");
			testObj.writeDatetime ();
			testObj.writeMessage ("test \"this\" message3");
		}
	}
}
