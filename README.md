# Game week 3: prefabs-triggers-master

In the game, the spaceship fights enemy spacecraft.
The goal is to shoot them and blow them up.
Each spaceship that explodes gives a point.

## Additions to the game from the given list:

- The player’s score is no longer displayed under the spaceship but instead in a fixed position on the screen, in the bottom-right corner, and it remains in that position even when the world size changes or when the screen rotates.

- The world is circular on the horizontal axis and closed on the vertical axis.
This means that when the player reaches the right edge of the world, they appear on the left side, and vice versa.

## Additional features I chose to add:

- I added a “survival time bonus” to the scoring system:
The player receives extra points just for staying alive. Every X seconds that the player survives, Y points are added.
This way, the player is rewarded not only for hitting enemies but also for avoiding danger and lasting as long as possible.
It creates motivation to “survive” longer and adds a sense of steady progression.

- I added an effect where, every few seconds — independently of anything else — the player receives a random shooting mode.
This changes how the player shoots and creates a feeling of a dynamic, ever-changing game.
It adds interest because the player must adapt to the new shooting mode during gameplay.
It introduces variety without breaking the game’s balance.

Link to itch.io - https://ateretaliya.itch.io/game-week-3-ateret
