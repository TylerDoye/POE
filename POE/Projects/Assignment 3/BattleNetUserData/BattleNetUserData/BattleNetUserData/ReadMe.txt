this application is an attempt to create a user search engine that battlenet has not implemented, 
 the reason not much of the user data can be edited is because if this program was implimented it would be linked to the players account and therefor be dynamic
  and changing in realtime as the users play, it wasnt a mistake it was part of the design

USER TAB
++++++++++++++++++++++++++++++++++++++++++++++
from this program users can search for other users and it will show them all the data on them that is relevant to them
when the program starts the only usable items are the search bar and button,
after a user is searched all theyre data will be displayed in the textboxes for user and games they own

if a user doesnt have one of the games provided by battlenet they can redeem a game key by clicking the add game key button
once done a few items will appear at the bottem of the window allowing the user to type in a serial key.
if the serial key is not 13 characters long the program will not accept it and no game data will be loaded.
if the user enters a valid key(any 13 chracter key) the game they decide to add a game key to will be loaded with the default information

if the user clicks the show all users button a textbox will pop up that will sjow all the current users basic info, the buttons name will change to close report
once it is closed the buttons name will revert and the textbox will be cleared and hidden
 
DIABLO 3 TAB
-----------------------------------------------
if the user has searched a user that owns dialo 3 or has added a gamekey  for diablo 3 this tab will become active
the textfield will have all theyre relevant information about theyre diablo 3 account

if you click the remove key button a dialog box will popup asking if your sure, if yes it deletes your user entry for diablo and changes the user data to show you dont own diablo 3
the at the bottem of the diablo 3 tab there is a combobox that allows you to pick a class, and a button that will show only the players with the one chosen as theyre favourite

the button acts like the one on the main form and it fills the same textbox that is hidden until activated, it also changess the text on the button so as to open and close the textbox

STARCRAFT 2 TAB
================================================
if the user has searched a user that has a starcraft 2 key this tab will become active

this tab will fill up with all the relevant information
there is a remove key button that when clicke will ask the user if theyre sure they want to remove key,
if yes then it removes all the starcrsft data and  changes the userdata t oshow that they dont have a starcraft key
if no no changes will be made

there is a combobox where the user makes a selection on how they want the report to show depending on what they chooose.
they then have to select a number that will determine the minimum value eg(if wins is selected and 100 is in the textbox it will only show players with more that 100 wins)


TESTING
################################################
for testing purposes use the username DMoney
all acces will be granted so that testing add and remove key will be available and testing the reports will work never the less unless there is no game account fo the desired report