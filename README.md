
# CS464 Assignment 03 · Unity 3D Arena Game

- **Name:** Muhammad Abubakar
- **Roll No:** BSCS25109
- **Video (60–120 s):** Add your video link
- **Started from:** Lecture 07 Unity build, used as the foundation.
- **Controls:** W, A, S, D or Arrow Keys.
- **To win a level:**
  - Level 01: Collect 5 coins.
  - Level 02: Complete the Lecture 07 gameplay objectives.
  - Level 03: Collect 10 coins within 45 seconds.
  - Level 04: Survive for 45 seconds.
  - Level 05: Collect 5 coins to unlock the exit and reach it within 60 seconds.

## Levels

| Level | Screenshot | New idea | Combined with |
|---|---|---|---|
| Level01 | Add screenshot | Collect coins and manage health/lives | Player movement and hazards |
| Level02 | Add screenshot | Lecture 07 base build | Enemies, coins, power-ups and UI |
| Level03 | Add screenshot | Smart coin spawning using `Physics.CheckSphere` | Cross-walls, enemies and knockback |
| Level04 | Add screenshot | Enemy patrol and chase AI | Survival timer and instant-death hazards |
| Level05 | Add screenshot | Locked exit requiring 5 coins | Smart enemies, hazards and countdown timer |

## The Numbers

| Number | Value | Why this value |
|---|---|---|
| Patrol speed | [Actual value] | Keeps enemy movement balanced with the player. |
| Chase range | 6 units | Allows enemies to detect and chase nearby players. |
| Knockback | [Force and ForceMode] | Throws the player far enough to make the game challenging. |
| I-frames | [Actual value] | Gives the player time to recover after taking damage. |
| Power-up duration | [Actual value] | Provides a temporary boost without making it permanent. |

## Short Answers

**1. Why does a trigger need a Rigidbody on at least one of the two objects?**

Unity needs a Rigidbody on at least one object to detect trigger interactions. It allows events like `OnTriggerEnter()` to work.

**2. Which ForceMode do your knockback and your Part A force use, and why each?**

`ForceMode.Impulse` applies an instant push, making it suitable for knockback. `ForceMode.Force` applies force continuously over time.

**3. What does your code do when a second power-up is picked up while one is running?**

It depends on the code. The second pickup may reset the timer, extend the duration, or be ignored.

**4. Why can `==` fail as an arrival check, and when does it work?**

because floating-point positions may have tiny differences. It works when values are exactly equal. `Vector3.Distance()` with a small threshold is more reliable for checking arrival.
