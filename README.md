# DSTools
Desktop Support Tool for Windows 10.

I wear many hats in my current role. I created this desktop support tool to improve my workflow in regards to setting up new Windows 10 devices. I used tools I found here on Github and I have given acknowledgements for those tools in the application. The Desktop support tool currently does the following:

-Windows updates
-Uninstalls multiple pieces of software silently
-Display and update the Hostname
-Displays current Windows product key and allows you to activate a new key
-Displays make, Model, Device ID, Security ID, User Shell folders for Desktop and Documents
-Displays Onedrive for Business folder location and version
-Creates 2 folders in the OneDrive for Business folder named Desktop and Documents.
-Updates the user shell folders for Desktop and Documents to reflect the respective folders in the OneDrive for Business directory
-Copies a directory in the working directory labeled 'Company Links' and it's contents to the Default User's Desktop(for propagation down to all new user accounts) and also to the current users directory. 
-Downloads the BIOS firmware for the HP Folio 9470m to the working directory for installation(feature incomplete)
-Set's Chrome as the default web browser
-Displays all users in the current local group 'administrators' and adds or removes users from the group.

My tool is licensed using GNU v3 and all of the 3rd party software has its respective licensing.
