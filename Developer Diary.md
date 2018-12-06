![](https://imgur.com/93p55ur.png)

[Github](https://github.com/cian2009/UnityGame)

# Main features
* Basic movement (Walking side to side)
* Attacking (Punching ememies)
* 3 Levels with a boss at the end of each level
* Custom animations (attacking, walking)
* Sound effects
* Menu's for main menu, choosing levels, death and game done
* Player health
* Custom UI
* Touch controls

# October
## Oct 11, 2018
Start of project. Setup local and remote repo for project  

## Oct 12, 2018
Created level 1 scene to get core mechanics working.  
Added player movement and fixed issue with player moving after user input stopped (Sliding effect).  
Added collision detection to player so they stay on the ground.  

##  Oct 24, 2018
Added main menu scene. Setup main menu with popout level select. Level buttons setup and testing with level 1 scene.  
Created a game logo and set it in the main menu.  
Added player animation using animator function.  

##  Oct 25, 2018
Added design document to repo for viewing.  
All level buttons on main menu setup and linked to future levels.  
Did basic clutter removal, removing gameobjects and assets from earlier testing phase.  
Changed menu design to feature a bill board for the city aesthetic.  
Revamed player collision for future enemy collision.  
Added settings bubble to menu and have it popping out when you click settings.  

## October Review
A lot of ground work has been completed. The basics have been added with player movement a collision system and basic world objects.  
A solid foundation to build from. In the next weeks enenmies need to be added and a spawning system need to be put in place for enemies.  

# November
## Nov 8, 2018
Added trigger testing to enemies for player damage.  
Added player movement using arrow keys.  
Added trigger for enemy spawning.  
Remade sprites for higher resolution.  

## Nov 9, 2018
Created new sprite sheet for player that involves a new melee animation.  
Made enemy spawn a one time trigger.  
Level audio added and loops.  

## Nov 12, 2018
Added player punching animations.  
Changed camera to be a child object of player.  
Edited audio levels of level music.  
New animation system using scripts.  

## Nov 13, 2018
Player trigger only activates when punchin. Trigger only activates when punching.  
Added basic enemy character.  
Testing trigger with other enemy object.  
Added a health system to player.  

## Nov 14, 2018
Added enemy movement. Enemy now moves towards player from it's current posiiton.  

## Nov 22, 2018
New health system added.  
Added system for enemies to damage player health.  
Player health system up and running. Takes damage from enemies.  

## Nov 23, 2018
CHanged enemy speed to stop them running at the player too quickly.  
Tidied up files and removed assets that are no longer in use.  
Fixed bugs to do with player and the new health system.  
Changed player trigger sizes as they were a bit too large.  

## Nov 28, 2018
Got enemy spawner working and cloning enemies into the area.  

## Nov 29, 2018
Added a time delay to enemy spawner as all enemies spawned at once.  
Added second spawnpoint to make enemies come from left and right of screen.  

## Novemeber Review
A lot of work with enemies has been completed. Some things that need to get done ar:
* Bosses at end of level
* Pizza health increase
* Added more sounds
* More levels

It might seem like a lot of work but all the hard work has been completed. Now I just need to bulk up current scripts to add the ability to increase health such as reverting the enemy damage script and adding it to a pizza png object.  
More levles involves finishing current challanges anf moveing them to the new level.  

December I will add these features and bug test the game before submission.  

# December
## Dec 3, 2018
Tagged clonned enemies with different tag as the old way would cause issues with the player special ability later on.  
Changed player speed to make the game play a bit faster.  
Trigger now releases player when they have killed all enemeies in that section.  
Added sound for player punching.  
Testing second spawn point in level 1.  
Enemies now animate towards the player and punch in the direction of the player.  
Created boss enemy to level at end of the game.  
Added map switch on boss death (Later changed to a collider behind the boss for better transition between levels).  
Added death menu scene to inform the user they failed. Giving them the option to exit the application or go back to the main menu.  
Lots of tyding up (Moving assets, removing assets, renaming scripts....etc).  
Lots of bug fixed to do with new and old assets.  

## Dec 4, 2018
Small changes to enemies (Speed, health and collider).  
Added increase health function to player health script.  
Added pizza with sound effect and created sound effect function for audio souce. Pizza called function in player health when collided with to add health to player. The pizza is the nremoved from the scene when used up.  
Added touch controls to scene (Moving left, right punch and special).  
Added program settings (Added picture, logo and icon to program).  

## Dec 5, 2018
Changed UI elements (Icons and position).  
Special functionality added. Special button can only be clicked once as you get one try per level. Counter is instantiated once each level.  
Added timer to UI. Counter that dislays minutes, seconds and miliseconds spent on the level.  
Added score system to UI. Each enemy adds 10 points to score.  
Added level 2 and transition working.  

## Dec 6, 2018
Added static method for holding data between levels (Health, Score and specials remaining). All data is read by level 2 and 3 after each has been complete.  
