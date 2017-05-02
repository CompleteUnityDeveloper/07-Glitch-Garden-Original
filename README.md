### Introduction To Glitch Garden ###

**LEARNING OBJECTIVES**

+ MAJOR: **2D Animation (frame, and rigged)**
+ Minor A: **Mobile** compatible, no keyboard use.
+ Minor B: **Components** to make code extendable.
+ Minor C: **Options Menu** scene & PlayerPrefs.

### Section 7 Game Design Document ###



### Your Glitch Garden Assets ###



### Section 7 Notes ###



### Making A Splash Screen ###

+ What is a splash screen
+ Why use a splash screen
+ Singleton-free music manager
+ Make you splash-screen
+ Add music, and make Start Menu auto-load
  
**Useful links**  
+ **Fonts**: [dafont.com](http://www.dafont.com/)
+ **Sound**: [Freesound.org](http://www.freesound.org/)

### Scaling & Aspect Ratios ###

+ We're building for “mobile first” here.
+ No use of keyboard, just tap & drag.
+ Mobile device aspect ratios.

**Useful Links**  
+ [Internet Archive - Handling resolutions and aspect ratio of common mobile devices for web, application and game development](http://web.archive.org/web/20160120225253/http://rusticode.com/2014/01/11/handling-resolutions-and-aspect-ratio-of-common-mobile-devices-for-web-application-and-game-development/)
+ [Unity Manual - Rect Transform](https://docs.unity3d.com/Manual/class-RectTransform.html)
+ [Unity Manual - Canvas Scaler](https://docs.unity3d.com/Manual/script-CanvasScaler.html)

### Alternative Music Manager ###

+ An alternative MusicManager.cs architecture
+ Customise your Win and Loose scenes.
+ Test it all looks and sounds good.

### Menus, Options & Music ###

+ Customise Win and Loose Scenes.
+ Add a new Options scene (blank for now).
+ Add two buttons: “Back”, “Defaults”.
+ Make Level_01 with “Win” and “Loose” buttons.
+ Test all the navigation and music works properly.

### Adding Fade Transitions ###

+ Adding a nice fade-in to the Start Scene.
+ Giving-up on spelling loose / lose / whatever.
+ Add background image to levels.
+ Check it all flows / scales nicely.

### Scaling Level Backgrounds ###

+ Canvas Scaler “Screen Match Mode”.
+ Use a “Raw Image” & grass texture.
+ Define play space, and quiet zones.
+ Setup our Level with prefabs.

### Introducing PlayerPrefs ###

A brief talking-head video where Ben Tristem introduces how to use PlayerPrefs
in Unity.

### Our PlayerPrefsManager.cs ###

+ What is PlayerPrefs, and why is it useful?
+ Limitations of PlayerPrefs
+ Why we're providing our own wrapper class.
+ Create PlayerPrefsManager.cs static wrapper.

### Our PlayerPrefsManager - part 2 ###

Ben recaps where we are, and continues building the PlayerPrefsManager.

### UI Sliders For Options ###

+ Introducing UI sliders.
+ Add volume and difficulty sliders.
+ Create OptionsController.cs.
+ Ensure sliders work.

### Sprite Sheet Animation ###

+ The sprite sheet (AKA sprite atlas).
+ Comparison to bone-based animation.
+ Importing & slicing sprite sheets.
+ Making your first animation.

### Ratio Math Primer ###

+ The fundamentals of ratio math(s). 
+ What screen aspect ratios mean.
+ How to convert between different aspects.

### World Space UI Canvas ###

+ Change to world space canvas for levels.
+ Adjust grass tiling (using UV Rect).
+ Add temporary “Core Game” panel.
+ Translate & scale the level canvas.
+ Adjust & prefab the camera.

### The Animation Controller ###

+ How animators, states & motion clips relate
+ Adding multiple animation states & clips.
+ Options for transitioning between them.
+ Again, only animate one character for now.

### Texture Size & Compression ###

+ Why my Lizard animation looked fuzzy.
+ What to do about it.
+ Max texture size for mobile devices.
+ A bit about MIP Mapping while we're here.

**Useful Links**  

+ [Mobile Max Texture Size](http://answers.unity3d.com/questions/563094/mobile-max-texture-size.html)
+ [TexturePacker - Create Sprite Sheets for your game!](https://www.codeandweb.com/texturepacker)
+ [ShoeBox](http://renderhjs.net/shoebox/)
+ [Glitch the Game](http://www.glitchthegame.com/public-domain-game-art/)

### Using Gimp To Slice Images ###

+ Introducing “bone based animation”.
+ Using Gimp on Mac or PC to slice images\*
+ How to import and set pivot points.


_* Same principles apply to any other image editor._

### 2D “Bone-Based” Animation ###

+ Animating Position, Rotation and Scale.
+ Challenge: create your bone animation(s).

### Animating Our Lizard ###

+ Different ways of animating objects
+ Different ways of moving transforms
+ Options for combining these.

### Animating Our Cactus ###

+ Animating the cactus from scratch
+ Re-capping the 5-step process.

### Finishing Our Defenders ###

+ Finishing the defender animations
+ How to make a sprite face the other way.

### Finishing Our Attackers ###

+ Finish our attackers
+ How to access our code on GitHub.

### Projectile Animation ###

+ Giving our projectiles rotation in the animator.
+ Giving them translation from the animator\*
+ Seeing the combined motion.

_\* We will change translation to script later._

**Useful Links**

+ [GameBucket.io](http://www.gamebucket.io/)

### Using Unity Remote ###

+ What's Unity Remote and why's it useful.
+ Unity Remote 4 on app stores (iOS and Android)
+ How to use it.
+ It's limitations.

**Useful Links**  

+ [Unity Manual - Remote 4](https://docs.unity3d.com/Manual/UnityRemote4.html)

### Review & Improvements ###

+ Read music volume on load, improve Win & Lose.
+ Catch 1st order error with **autoLoadLevelAfter().**
+ Alternative fade without coding (thank Ryan).
+ Save our scene of sprites & prefab everything.
+ Our current project state is attached.

### Moving Attackers From Script ###

+ Create an Attacker.cs component.
+ Why this component model is useful.
+ Tune our animation to avoid “moon walking”.

### Collision Matrix In Script ###

+ Using **OnTriggerEnter2D (Collider2D collider).**
+ Why we are using triggers not physics.
+ Why we won't use the collision matrix this time.
+ Adding appropriate colliders to all objects.

### Using Animation Events ###

+ The “what” and “why” of animation events.
+ What methods can be called, and what can't.
+ Modify Attacker.cs to accept speed events.
+ Get animation transitions working for all attackers.
+ Add “wishful” StrikeCurrentTarget() method.

### Components “vs” Inheritance ###

+ The different approaches to abstraction.
+ The benefits of a component model.
+ Get **StrikeCurrentTarget()** working.

### Using A Health Component ###

+ Why a separate component makes sense.
+ Create & attach **Health.cs** component.
+ Test destruction, and initial play tuning.

### Animating Defenders & Projectiles ###

+ Three approaches to 2D projectile animation.
+ Separate defenders from their projectiles.
+ Animate projectile using script **and** animator.
+ Fix-up defender animation states.

### Animator Firing Projectiles ###

+ Why fire by animation events.
+ Create **Shooter.cs** for shooting defenders.
+ Create **FireGun()** method in Shooter class.
+ Attach a gun gameObject to spawn projectiles.
+ Arrange for animator to fire projectiles.

### Separate Attack & Fire States ###

+ Why our Gnome fires too fast.
+ Possible solutions to this type of issue.
+ Why we choose to create a “fire” state.
+ Fine-tune projectile size & spawn position.

### Handling Projectile Damage ###

+ Make projectiles damage **Attacker** with **Health**.
+ Setup a play space, and start tuning.
+ Tweak damage and health levels.
+ We'll play tune again later.

### “Tower” Selector Buttons ###

+ Setting up buttons for defender (tower) selection.
+ Initially they just toggle sprite colour.
+ Setup **DefenderSelector.selectedDefender** static
+ Test that static is set at start, and on button press.

(Unique Video Reference: 33_GG_CUD)

### Creating When Needed ###

+ The problem with the Projectiles placeholder.
+ Useful blog article on best practices\*
+ A pattern for checking and creating.

**Useful Links**  
+ \* [Blog - Unity3D Best Practices](http://www.glenstevens.ca/unity3d-best-practices/)

### Spawn Defenders To Grid ###

+ Ensure existing defenders' colliders mask square.
+ Calculate the world-units position of a click.
+ Calculate the nearest play-space grid centre.
+ Spawn the currently selected defender there.

### Enemy Spawning & Flow ###

+ Place enemy spawners.
+ Decide how spawning is controlled.
+ A word about the Flow Channel\*
+ Write script(s) to control spawning.

**Useful Links**  

+ \* [Game Theory Applied: The Flow Channel](http://indiedevstories.com/2011/08/10/game-theory-applied-the-flow-channel/)

### Shooters Detect Attackers ###

+ Find a way of defenders detecting attackers.
+ Only shoot at attackers if ahead in lane.
+ Modify **Shooter.cs** to make this work.
+ Test that defender enter and leave “attack” state.

### Using Stars As Currency ###

+ Add a sun scoreboard to the game space.
+ Star Trophy animation calls script to add sun.
+ Write **StarDisplay.cs** class to update scoreboard.
+ Write **defender.AddStars(int amount)** method.
+ Wire these scripts together.

### Spending Star Currency ###

+ Assign a star cost to every defender.
+ Prevent placement until you can afford it.
+ Spend stars when defenders are placed.
+ Use an **enum**eration to pass meaning.
+ Rough play tuning to create a challenge.

### Handle Lose Condition ###

+ Remove lose test button.
+ Create a lose collider.
+ Setup lose triggering & transition.
+ Improve lose screen.

### UI Slider Level Timer ###

+ Create a UI slider to visually show level progress.
+ Make the slider to “count down” to level end.
+ When time runs out…
+ Show “You Survived” text, and play a sound.
+ Auto-load next level.

### Review & Tidy Up ###

+ Tidy **Spawner.cs > isTimeToSpawn()**
+ Adjust colliders so attackers hit defenders.
+ Fix the gravestone animation transitions.
+ Creates prefabs of our work.

### Play Testing & Tuning ###

+ Display the defender cost on buttons.
+ Tweak the spawn frequency of attackers.
+ Adjust the health of attackers & defenders.
+ Choose amount of damage for projectiles.
+ Play and make sure it's a challenge.

### Installing Android Studio ###

+ Downloading & installing Android Studio.
+ How to solve common issues.
+ Check Android Studio loads.

**Useful Links**  
+ [Android Studio](https://developer.android.com/studio/index.html)

### Building To Android ###

+ Setting up Build Settings for Android.
+ Deploying to Android device\*
+ Play testing on the device.

_\* You'll need a device connected with a USB cable._

### Build To iOS Simulator ###

+ Setup Build Settings in Unity.
+ Build to iOS simulator (Mac “needed”).
+ To build to physical device you “need” a dev kit.
+ Briefly play-test, and note improvements.
+ Share your creation with the world.

### User Testing Tweaks ###

+ Simplify by removing **SetStartVolume.cs**\*
+ Destroy tagged game objects on Win condition.
+ … this also solves the “You Win” issue.
+ Add a simple STOP button to game.

_\* Thanks to Marko for suggesting this._

### GG Unity 5 & Web GL Sharing (Optional) ###

+ Upgrade to Unity 5.
+ About Web GL builds.
+ Build for Web GL and share.

### DOWNLOAD Section 7 Unity Project ###



### Section 7 Wrap Up ###
