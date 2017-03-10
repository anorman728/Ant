using System;
using System.Diagnostics;

namespace Ant
{
	public partial class PromptWindow : Gtk.Dialog
	{
        private WriteFile writeFileObj;

		public PromptWindow (WriteFile inputWriteFileObj)
		{
            this.writeFileObj = inputWriteFileObj;
			this.Build();
            System.Media.SystemSounds.Beep.Play();
		}

        /* Handle button clicks */
            protected void OnOK (object sender, EventArgs e)
            {
                this.HideAll();
                this.writeFileObj.writeMessage(this.message.Text);
				this.Destroy();
            }

            protected void OnCancel(object sender, EventArgs e)
            {
                this.HideAll();
                this.Destroy();
            }

        /* Handle keypresses */
            protected void keyRelease (object o, Gtk.KeyReleaseEventArgs args)
            {
                if (args.Event.HardwareKeycode == 36) 
                {
                    this.OnOK (o, args);
                }
            }

	}
}

