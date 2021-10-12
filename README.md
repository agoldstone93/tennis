# Tech Test
## DfE Digital - Developer
​
The tech test is a programming exercise to evaluate the candidate technical skills and
approach to software development. The candidate is expected to produce a solution in code
that demonstrates they understand how to solve the problem using clear concise code with
corresponding tests.
​
### When completing the technical test please do:
* Keep it simple
* Include instructions on how to run the code
* Use any programming language to solve the problem
​
### Please don’t:
* Build a UI - the focus of the test is on the technical solution and not the interface
* Spend more than 2 hours - the important thing is that we understand your approach and way of thinking, it’s enough to demonstrate you could complete the task if you spent more time
* Feel the need to cover every edge case
* Write more than 200-300 lines of code! it’s possible to produce quite lean solutions
​
---
​
## Tennis Game Scoring Problem
You are building a tennis game scorer that will eventually be used on the Wimbledon
website to show live scores.
​
### Rules
1. A game is won by the first player to have won at least four points in total and at least
two points more than the opponent.
2. The running score of each game is described in a manner peculiar to tennis: scores
from zero to three points are described as "love", "fifteen", "thirty", and "forty"
respectively.
3. If at least three points have been scored by each player, and the scores are equal,
the score is "deuce".
4. If at least three points have been scored by each side and a player has one more
point than his opponent, the score of the game is "advantage" for the player in the
lead.
5. The serving player's score is always first, the receiving player's score is second.
​
### Interface
​
The interface to our tennis game looks like this (shown in Ruby):
server = "Player 1"
receiver = "Player 2"
game = Game.new(server, receiver)
game.point_to(server)
game.point_to(receiver)
score = game.score()
​
### Tasks
Your goal is to implement the Game class, so that it will calculate scores correctly for the test
data provided below.
It will be used as a library by other parts of the system, so it doesn't need to deal with input
or output, it will just be called using the interface shown above (or an equivalent in your
language of choice).
First think about the problem and plan. What would be your first step? How will you check
that you've implemented the Game class correctly?
Once you're happy with a plan, go ahead and implement and iterate as necessary.
​
### Test data
Server: J
Receiver: B
Points won: J,J,B,J
Score: Forty, fifteen
Points won: J,B,J,B,J,B,B
Score: Advantage, B
Points won: J,J,J,B,B,B,B,B
Score: Game, B  
