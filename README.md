# Ant

This project is intended to help you keep track of what you're working on and how long you've been working on it.

It will prompt you on a schedule and ask "What are you working on right now?"  Then, it will add the result to a CSV file with a timestamp so you have a spreadsheet that can be opened in Excel/LibreOffice to see what you've worked on throughout the day.

I had previously attempted to do this using Gtk# to make it cross-platform, but that was not working out because it seems to be too buggy.  It now uses a traditional Windows Forms setup.

ATM, it's functional, but not yet complete.  Still need to add the ability to save settings, add an icon, and an "About" popup window.


----------------------------------

"Ant" is an acronym for "Andrew Norman's Timelogger."  On a schedule that you define, it will ask you "What are you working on right now?", then will take your response and store it in a CSV file with a timestamp, which can be opened in a spreadsheet program like Excel.  

For example, if you set it up to ask you once an hour on the hour, by the end of the day you will have an hourly record of what you were working on that day.

![Example01](/Readme\ pics/Example01.png?raw=true)

![Example02](/Readme\ pics/Example02.png?raw=true)

![Spreadsheet Example](/Readme\ pics/Spreadsheet\ Example.png?raw=true)
