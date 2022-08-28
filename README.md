# CS 8395 Final Project - Pokémon Combat
Hao Fu: hao.fu@vanderbilt.edu

# Part 3: Final Deliverable Writeup
## Instruction
* Using **Unity Hub 3.1.2**, download **Unity 2018.3.11f1** with any version **Microsoft Visual Studio Community**, **Android Build Support** and **Vuforia Augmented Reality Support**
* Using `git clone https://github.com/Vanderbilt-AR-8395-2022-Spring/Hao_Fu.git` to download this project and unzip it
* Open the project with Unity Hub, waiting for all the components and scripts imported successfully
* Switch the Building Platform to Android, select all the two scenes: **StartScene** and **CombatScene**, plug in any Android device you have, then select `Build and Run`. (**Remember to change the Build System from "Gradle" to "Internal(deprecated)"!!**)
* Put the generated APK into your smartphone, download it, and run it!
* As for the Image Target, please only use [Pikachu](https://pokemon.fandom.com/wiki/Pikachu) and [Farfetch'd](https://pokemon.fandom.com/wiki/Farfetch%27d) since we only implement these two Pokémons, there are three main options:
1. Directly use real PTCG ([Pokémon Trading Card Game](https://en.wikipedia.org/wiki/Pok%C3%A9mon_Trading_Card_Game)) card;
2. Print ImageTarget1 and ImageTarget2 together or separate and use the printed paper;
3. Just use the portable device you have to show those two images.

## Writeup
### Goal
According to the initial proposal and milestone, the goal of this project is to deliver an interesting Augmented Reality game *Pokémon GO*, in which users can use PTCG ([Pokémon Trading Card Game](https://en.wikipedia.org/wiki/Pok%C3%A9mon_Trading_Card_Game)) card as the image target to show Pokémons in reality and let them fight with each other. Each user can select between unlimited "Attack" or limited "Heal" in their turn to keep their Pokémon alive to the end (requires choosing wisely). Once one of the two Pokémons loses all its blood, the game ends, showing the final winner and choices of either starting new combat or just leaving and returning to the start page.
***
### Design and Development

The game is developed under Unity 2018.3.11f1, and the reason why we use a lower version is listed as follows:
> In this lower version, the Vuforia is integrated with the official plug-in as "Vuforia Augmented Reality Support", thus it has a better interaction and adaptability;

> The Pokémon models we get are FBX files, and somehow we find it's hard to control them in the newer version since Vuforia changes the logic of the critical component "UnityEngine.Animator" (maybe also because the models we used are old and we can't find the open-source)

#### StartScene
_APP Name_: Set an Animator to the name "Pokémon Combat" to let it perform the random up and down movements.

_Start Button_: The button "Play" let users enter the combat scene.

_Quit Button_: Exit the application and return to the desktop of the device.

_Gotcha_: "Play on Awake" Audio Source

#### CombatScene
_GeneralPanel_: GameOverPanel shows after one combat, with a WinText, a ReplayButton, a MenuButton, and a QuitButton. PokemonTurnPanel and PokemonStartPanel together give out the information of the current combat round, preventing one Pokémon's multiple continuous operations.

_Player1 & Player2_: Each one has three components: Attack Button, Heal Button, and HealBarPanel;
> HealBarPanel is composed of Health Bar, Pokémon Icon, and Pokémon name, initialized after the success of two Pokémons target detection.

_GameManager_: Define all the needed variables, special effects, and special sounds of different actions from different Pokémons
***
### Novelty

This AR application strips the classic Pokémon combat from Pokémon Go and endows the entire battle process with great randomness, also adds a certain amount of interest while maintaining fairness. The biggest contribution is making different Pokémon models with different animations, different effects, and different sounds, which makes it easier for users to see the current action their Pokémons have. The whole battle logic is complete and the identification success rate is pretty good. All in all, it's a perfect complete Android application.
***
### Limitaion

Due to limited time and immature technology, there are still some limitations that remain to be solved in the future:
* The project only has two available Pokémon models for now, given ample time and materials, we can have more Pokémons in the combat.
* Single attack skill and attack effect for both Pokémon models, differences can be increased in the future.
* The current image target detection can't avoid a special situation when two users happen to detect the same Pokémon, then all the logic becomes useless and all the actions from either side have the same effects on two Pokémons at the same time.
***
### Reference

[1] Nguyen N. Developing a multiplayer AR game using AR Foundation and Unity[J]. 2020.

[2] Visual Effect Graph: https://docs.unity3d.com/Packages/com.unity.visualeffectgraph@4.10/manual/index.html.

[3] The Sound Resource: https://docs.unity3d.com/2018.3/Documentation/Manual/class-AudioSource.html.

[4] How to 3D Animate in Unity: https://gamedevacademy.org/unity-3d-animation-tutorial/.

[5] Recreating Pokemon Go's camera in Unity3D: https://youtu.be/a4ts4dZ_12I & https://youtu.be/E0FsX7HTlgI
***
### Image and Video

**Start Interface**: Application background, application name "Pokémon Combat", a "Play" button, a "Quit" button, and classic background music.
![image1](https://user-images.githubusercontent.com/37103427/165837772-bb133df9-c841-48b6-ab7c-521db20ba3ce.jpg)


**Combat Preparation**: Two Pokémons standing on their according to image targets, on each side above them are their icons, names, same initial health bar, and the Heal button shows a random but equal number for this particular combat. Then the start text tells the first "entered" Pokémon to have the first turn.
![image2](https://user-images.githubusercontent.com/37103427/165837687-c66c4776-2f73-46c8-812f-938f215f9abd.jpg)

**Combat Process**: When Attack Button is triggered, the attacking Pokémon performs unique animation, the attacked Pokémon has the being attacked effect; when Heal Button is triggered, the attacking Pokémon performs unique animation and has the healing effect on their own.
![image3](https://user-images.githubusercontent.com/37103427/165837796-04f6ca8f-2506-442a-9b7d-4ffc4b5d5e51.jpg)
![image4](https://user-images.githubusercontent.com/37103427/165837811-976cfb77-da0a-4656-899b-e02a4adbc9f3.jpg)



**Finish Interface**: The winning text tells the winner of this combat, and users can use the other three buttons to restart combat, return to the Start Interface, or just quit this game.
![image5](https://user-images.githubusercontent.com/37103427/165837825-2699c0a4-0b25-420c-be2b-745d47182e45.jpg)


**Final Demo Video**

[YouTube: Vanderbilt University CS8395 Final Project - Hao Fu](https://youtu.be/E9SJ2KzTlS8)

### Android APK and Video File

[Pokemon Combat.apk](https://vanderbilt.box.com/s/sqkpd6oppwg2c0ka5283vhe8yhx2rbjt)

[Vanderbilt University CS8395 Final Project - Hao Fu.mp4](https://vanderbilt.box.com/s/76bcoiffcjmd1q9dajdwwpkakl04kmeh)




Part 2: Milestone
===
Platform
---
**Unity 2018.3.11f1** (Stable version with stable Vuforia module),   
**Vuforia 8.0.10** (Vuforia Augmented Reality Support),   
**Android Build Support**  
**TextMesh Pro 1.3.0**  
**[Visual Effect Gragh](https://docs.unity3d.com/Packages/com.unity.visualeffectgraph@12.0/manual/index.html)**  
**Microsoft Visual Studio Community 2019**

Achievement
---
* Successfully use PTCG ([Pokémon Trading Card Game](https://en.wikipedia.org/wiki/Pok%C3%A9mon_Trading_Card_Game)) card as the image target to identify and show two Pokémons: [Pikachu](https://pokemon.fandom.com/wiki/Pikachu) and [Farfetch'd](https://pokemon.fandom.com/wiki/Farfetch%27d) as 3D models with animation and controller.  
> Model Resource: [The model's Resource](https://www.models-resource.com/3ds/pokemonxy/) and a friend majoring in developing software with Unity 3D  
* Finish the combat scene, showing the *Pokémon Icon*, *Pokémon Name*, *HealthBar*, *Attack Button*, and *Heal Button*, and everything's logic works well.  
* Different Pokémon can have some fire and explosion effect when attacking the opponent or healing itself, with the health bar dynamically showing the remaining blood. The value of attack and heal are all set randomly. When one of them loses all its blood, the game is over, showing the Gameover Panel with some winning text and three buttons: Replay, Quit, and Menu **(These buttons aren't yet all implemented)**   
![MILESTONE](https://github.com/Vanderbilt-AR-8395-2022-Spring/Hao_Fu/blob/main/MileStone/MILESTONE.png)  

Remaining Steps
---
* Tighter combat logic: only one operation (either Attack or Heal) is allowed at a turn for the Pokémon.  
* Target detection logic: avoid the situation when both sides are detected at the same time with the same image target (avoid beating itself).  
* Add an initial startup interface with Start Button and Quit Button.  
* Add background music for both StartScene and CombatScene, add Attack Sound and Heal Sound.  
> Sound Resource: [The Sounds Resource](https://www.sounds-resource.com/)
* Implement the buttons after the game is over.  

Milestone Video
---
[YouTube: Vanderbilt University CS8395 Final Project Milestone - Hao Fu](https://youtu.be/OR6DE5Od3BQ)


Part 1: Project Description
===
Basic Idea
---

Pokémon GO is a worldwide famous augmented reality mobile game. It uses mobile devices with GPS to locate, capture, train, and battle virtual creatures, called Pokémon, which appear as if they are in the player's real-world location. Based on my actual game experience, I decided to implement an easy version of it on Unity3D as my final project.
After some initial consideration, I want to focus on the “battle” of virtual creatures. What I have researched is that all the other user behaviors need much more complex things such as Location-Based Services, Random Events, and so on. While for a one-on-one battle of just two Pokémon, things can be a little easier.

Implementation
---
> For the development platform, I choose Unity3D + Vuforia + Android. However, I may need to choose an old version since for now I can only find some useful information about some functions online with Unity3D 2018, and I don’t know if there are any changes in the latest version.

> For the virtual AR model of Pokémon, I’m glad that I find someone who has done a similar app before and is willing to share me with the model. This can help me reduce much time and also make my product more professional, I will express special thanks in the final writeup.

> For the detail completion, since this is my first experience in finishing a large AR project, it’s hard to predict my work before I start. I still list a few functions below, and I will try my best to implement as many as possible:

* A simple start interface with two buttons: START and QUIT.

* A battle scene after pressing the START button, initialized with names, blood bar, avatar, and some operate buttons (ATTACK, and if possible, HEAL).

* Image target would be some Pokémon cards because they are easy to get. The battle would be one-on-one, but if I can get enough help from the AR model, I can have more characters.

* Two Pokémon will attack or heal in turn, if one side loses all its blood, then game over. After the game is over, have some more buttons such as “start a new battle” or “back to homepage”.

* CHALLENGE (will try my best): The AR model of Pokémon can move when attacking, and there are some special effects in the air, also, I can add some fight sounds.

* If everything above goes well, add more features to make the app more advanced.
