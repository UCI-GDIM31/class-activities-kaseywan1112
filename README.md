# in-class-activities
## Devlogs
### W1
Hello world!

### W2
Debug: forget one ";" from the coding we should uncomment. 

1. Because RGB color is a fractional numbers, we are both using letters and numbers. 
2. Because when we count our bounce times, we do whole number, so we are using int.
3. The error is actualy the change of the ball after every bounce. 

### W3
Bug fixed:
I have some issue when I launch my game, it keep telling me there is a bug, I found out on line 99, I put void, but we just need to call it, not use void for it.

Table question:
Table#9 
We can use int (parameters) on friendship level, for GetResponse(string) we need use return to check if the friendship level reach to the next level, if not the character will not tell their secret, but if so, the GetResponse will acitive and the character tells the secret.

1. Class is like a toolbox, and the component is like the tools in the box.
2. Becase the RGB color only increase not decrease. 


### W4
Table# 8 (1~10): Line 5 declares a member value in float type, which representing the distance moved by the object each unit time. Line 22 is calculation on component called translation in float type, which is the position calculated each frame by current position times _movespeed times time passed. Line 25 is calling method named translation, which might be updates on calculated position to the object each frame to simulate animation of translation. The translation method have 3 parameters and only the 3rd parameter is filled by translation component, so it might means the third parameter represents verticle translation.

1. For the collider activity, we decided to add Rigidbodies to the Cat and the SoccerBall so they could collide and bounce realistically. We set the Goal’s BoxCollider as a Trigger so the ball could detect when it enters the goal without being blocked.
2. I forgot to add freeze to the cat and the ball, so my cat and camrea rotate cause bugs, after add the freeze for X and Y, the game work just fine.


### W5
Question:
 I'm thinking about the animation of the character, what's the logic of changing idle, run and walk, I know it's about check speed of the characer, but in what code, can we make it easier?
I think we can use coding to check speed, and also we can just fixed our animation, make the character to move just in the right spot, igored the speed, but that will make debug painful.

1. I only used Targert in the class
2. I used Start() for this class, and we can use Update() if we want the deer keep moving with the cat.
3. I think method(s) are the behavior of a subject.

### W6
[Class resource guide](https://docs.google.com/document/d/1I9v9DLgH_h1Npt-SvcE6Rrcdn8rclMwmf5H-zmU4f14/edit?tab=t.0)



## Open-Source Assets
### W1
- Animals: https://assetstore.unity.com/packages/3d/characters/animals/animals-free-animated-low-poly-3d-models-260727 
- Low-poly environment: https://assetstore.unity.com/packages/3d/environments/landscapes/low-poly-simple-nature-pack-162153 