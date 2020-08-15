# The Facade Design Pattern 


## Intent
The idea is that if you don't want other code accessing the complex bits of a class or process, you hide those bits by covering them with a Facade.
The Facade pattern is a simple structure laid over a more complex structure.

## The Problem

To demonstrate how we use the Facade pattern, let's think about a restaurant.

In most kitchens, the work area is divided into sections. For this post, we'll assume that our kitchen is divided into three areas: Hot Prep, where hot dishes like meats and pasta are made; Cold Prep, where cold dishes like salads and desserts are made; and the Bar, where drinks are prepared.

If you are a patron at this restaurant and you sit down at a booth, do you care what part of your meal is made at what section of the restaurant? Of course not. There is a natural layer of abstraction in place: the server.


## The Solution

A simple (or at least simpler) overlay on top of a group of more complex subsystems. 

## The Rundown
Type: Structural
Useful? 5/5 (Extremely)
Good For: Hiding complexity which cannot be refactored away.

### The Participants

- The Subsystems are any classes or objects which implement functionality but can be "wrapped" or "covered" by the Facade to simplify an interface.
- The Facade is the layer of abstraction above the Subsystems, and knows which Subsystem to delegate appropriate work to.

## Visuals




## CSharp Implementation
The facade pattern is so general that it applies to almost every major application, especially those where refactoring or modifying pieces of applications are needed for various reasons.

## Code (CSharp)
![Facade](./Assets/Facade.png)


## Applicability


## Good and Bad
| Good | Bad |
Hiding complexity which cannot be refactored away | There is really no known drawbacks to Facade. It provides a unified interface to a set of interfaces in a subsystem. However, it does not ab ovo prevent clients from using the subsystem interfaces directly. So you are not forced to make any unwanted compromises with it. It is a win-win situation.


<br />


##Summary
The Facade pattern is a simple (or at least simpler) overlay on top of a group of more complex subsystems. The Facade knows which Subsystem to direct different kinds of work toward. And it is really, really common, so it's one of the patterns we should know thoroughly.

As always, I like to provide code with my tutorials, so the repository for this pattern is over on GitHub and contains all of the sample code used here.

Happy Coding!

(That's the end of the post. Yes, seriously. No I'm not writing another one right this second, you'll just have to wait until tomorrow. So there.)

### Citations
