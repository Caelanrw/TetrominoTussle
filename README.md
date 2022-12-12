# Tetromino Tussle
Welcome to Tetromino Tussle! This is a challenging, 2-player falling block game that is fun for all ages! Follow the instructions below to build Tetromino Tussle on your own computer.

# Installing The Game
## Clone the repository.
To clone this repository, simply enter the following in your terminal:

	git clone https://github.com/clnmcdowell/TetrisVs.git

## Install Unity Hub
If you already have the Unity Hub and Unity Editor installed, you can skip
this step. To download Unity, go to this link and download the latest version for your  operating system: https://unity.com/download.  Make sure you have Unity Editor version 2021.3.15f1 installed for this game.

## Build and Run Tetromino Tussle
Once you have installed the Unity Hub and Editor, select File in the top left corner of the Editor, and then select “Build and Run”. This should take  a few moments, and then you will see the Title Screen. Enjoy your game! If you have any trouble with the Unity Editor, check out the documentation here: https://docs.unity.com/.

# Playing Tetromino Tussle
## Start the game

## Begin building your boards

	PLAYER 1 Controls:
		W - Up
		S - Down
		A - Rotate
		D - Fast Drop

	PLAYER 2 Controls:
		˄ - Up
		˅ - Down
		> - Rotate
		< - Fast Drop

	esc - Pause
	
	**If you clear 3 or 4 columns at once, your blocks will shift towards your opponent’s side!

## First player to fill up their board loses!

## Complete 3 or 4 columns at a time to move all the blocks towards your opponent!

# Final Game Test Cases and Expected Results
Press the control button: Goes to the control screen
Press escape leaving the control screen: Goes to the main menu
Press start game: The game starts
Press W, S, up arrow, and down arrow: Tetrominoes move up and down
Press A and the right arrow: Tetrominoes rotate 90 degrees
Wait for both tetrominoes to reach the center: Tetrominoes will be placed and new tetrominoes will be spawned
Press D and the left arrow key:  Blocks will fast drop
Spawn multiple tetrominoes: Different random tetrominoes will be spawned
Try to move a tetromino out of bounds: Movement will be prevented
Try to move a tetromino up or down into a set block: Movement will be prevented
Try to rotate a tetromino while at the edge or next to a set block: Rotation that would move part of the tetromino out of bounds or into a set block will be prevented
Complete a column: That column clears and blocks to the side of cleared column move to fill the now empty column
Complete 3 rows with 1 tetromino: All set blocks move 1 space towards the opponent's side of the screen
Complete 4 rows with 1 tetromino: All set blocks move 2 spaces toward the opponent's side of the screen
Place many tetrominoes: The automatic drop will occur faster
Stack blocks to one end of the screen: Goes to victory screen for opponent’s side
Press the main menu button on the victory screen: Goes to the main
Play the game again and stack blocks to the other end of the screen: Goes to the other victory screen
Play the game again and press escape: The game pauses and a pause menu appears
Press escape or click the resume button: Game resumes
Return to the pause menu and press the main menu button: Goes to the main menu
Press the quit game button: The game window closes



Team Name: Team Tetris 
Team Members: Colin McDowell, Jack Crowley, Caelan Wong
