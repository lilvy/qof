Quick Open File for Visual Studio
=================================

Quick Open File for Visual Studio is a small extension that tries to simulate the feature known to Eclipse users as Open Resource. This extension gives Visual Studio an equivalently quick method for opening any solution file.

Although in Eclipse this feature is invoked by <b>Ctrl+Shift+R</b>, this extension is invoked by pressing the sequence <b>Ctrl+K, Ctrl+O</b> (because the former shortcut key is already taken in Visual Studio by default). The default shortcut key can be changed by the user of course. It indexes all files from the entire solution that are accessible via the Solution Explorer. When it finds the desired file it opens the file in the default editor assigned for that file type.

It searches for the given substring inside file names. You can also use wildcards (?, *) in the search. The list of matched file names is updated on the fly as you type. Opening the file is as easy as hitting Enter when you've found the desired file. Press Shift+Enter to open the selected file using other than the default editor. This will bring up the Open With dialog where you can choose the desired editor.

Usage
-----

After successful installation the extension will add a menu command: <b>Edit > Find and Replace > Quick Open File</b>. The command is also accessible via the predefined shortcut key sequence <b>Ctrl+K, Ctrl+O</b>. You can change the shortcut key preference any time via Tools > Customize... > Keyboard... The command's name is Edit.QuickOpenFile.

![Quick Open File menu shortcut](https://raw.github.com/martinky/qof/master/img/vsopen_menu_2010_fullres.png)

After pressing the shortcut key combo the Quick Open File tool window is displayed. Now just type few letters from the file name you wish to open. It will search the entire solution for files that contains the typed string. I.e. the it will not only search for file names that start with the given string but also file names that contain the string in the middle. You can also use wildcards for more complex search patterns: ? matches any character, * matches any substring. The matching behavior can be tweaked in the settings.

![Quick Open File tool window](https://raw.github.com/martinky/qof/master/img/vsopen_menu_2010_fullres.png)

The list of matched file names is updated as you type. Use <b>Up</b> and <b>Down</b> arrow keys to move within the list and press <b>Enter</b> to open the selected file. You can select multiple files by ticking the checkboxes (press <b>Space</b>) and open them at once.

Press <b>Shift+Enter</b> to open the selected file using other than the default editor. This will bring up the Open With dialog where you can choose the desired editor. The same can be done using the Open button or right clicking any file from the list and choosing either <b>Open</b> or <b>Open With</b>.

The latest version offers the possibility to tweak the search behavior and various other user settings. To invoke the settings dialog, click on the settings button in the tool window or go to Tools > Options... > Quick Open File. The settings should be self-explanatory.

![Quick Open File tool window](https://raw.github.com/martinky/qof/master/img/vsopen_settings_2010_fullres.png)

Installation
------------

Most convenient way to install Quick Open File is directly through Visual Studio's Extension Manager. Go to Tools > Extension Manager > Online Gallery and search for "quick open file for visual studio". This way you will be automatically notified when updates are released.

However, there are newer versions available, not yet uploaded to Visual Studio Gallery. Please, see below.

Downloads
---------

Depending on your Visual Studio version, download and install one of the following:

**Visual Studio 2012**
 - [1.3 next version preview, VS 2010 and 2012](https://github.com/downloads/martinky/qof/QuickOpenFileVS2012_1.3_alpha.vsix)

**Visual Studio 2010**
 - [1.2 current release, VS 2010 only](https://github.com/downloads/martinky/qof/QuickOpenFileVS2010_1.2.vsix)
 - [1.3 next version preview, VS 2010 only](https://github.com/downloads/martinky/qof/QuickOpenFileVS2010_1.3_RC3.vsix)
 
**Visual Studio 2008**
 - [1.1 older version, VS2008 only](https://github.com/downloads/martinky/qof/QuickOpenFileVS2008_1.1.msi)

All downloads are in the [download section](https://github.com/martinky/qof/downloads)

Links
-----

- [QoF for VS 2010 in MSDN Visual Studio Gallery](http://visualstudiogallery.msdn.microsoft.com/3eb2f230-2728-4d5f-b448-4c0b64154da7)
- [QoF for VS 2008 in MSDN Visual Studio Gallery](http://visualstudiogallery.msdn.microsoft.com/e4e906ee-2a2a-459b-85e8-df4b1c5666d1)
