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
> Model Resource: [The models Resource](https://www.models-resource.com/3ds/pokemonxy/) and a friend majoring in developing software with Unity 3D  
* Finish the combat scene, showing the *Pokémon Icon*, *Pokémon Name*, *HealthBar*, *Attack Button*, and *Heal Button*, and everything's logic works well.  
* Different Pokémon can have some fire and explosion effect when attacking the opponent or healing itself, with the health bar dynamicly showing the remaining blood. The value of attack and heal are all set randomly. When one of them lose all its blood, the game is over, showing the Gameover Panal with some winning text and three buttons: Replay, Quit, and Menu **(These buttons aren't yet all implemented)**   
![MILESTONE](https://github.com/Vanderbilt-AR-8395-2022-Spring/Hao_Fu/blob/main/MILESTONE.png)  

Remaining Steps
---
* Tighter combat logic: only one operation (either Attack or Heal) is allowed at a turn for the Pokémon.  
* Target detection logic: avoid the situation when both sides are detected at the same time with a same image target (avoid beating itself).  
* Add an initial startup interface with Start Button and Quit Button.  
* Add background music for both StartScene and CombatScene, add Attack Sound and Heal Sound.  
> Sound Resource: [The Sounds Resource](https://www.sounds-resource.com/)
* Implement the buttons after the game is over.  

Milestone Video
---
[Vanderbilt University CS8395 Final Project Milestone - Hao Fu](https://youtu.be/OR6DE5Od3BQ)
