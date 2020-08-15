# The Facade Design Pattern 


## Intent
- The idea is that if you don't want other code accessing the complex bits of a class or process, you hide those bits by covering them with a Facade.

- The Facade pattern is a simple structure laid over a more complex structure.

## The Problem

- To demonstrate how we use the Facade pattern, let's think about a restaurant.

- In most kitchens, the work area is divided into sections. For this post, we'll assume that our kitchen is divided into three areas: Hot Prep, where hot dishes like meats and pasta are made; Cold Prep, where cold dishes like salads and desserts are made; and the Bar, where drinks are prepared.

- If you are a patron at this restaurant and you sit down at a booth, do you care what part of your meal is made at what section of the restaurant? Of course not. There is a natural layer of abstraction in place: the server.


## The Solution

- A simple (or at least simpler) overlay on top of a group of more complex subsystems. 

## The Rundown
- Type: Structural

- Useful? 5/5 (Extremely)


### The Participants

- The Subsystems are any classes or objects which implement functionality but can be "wrapped" or "covered" by the Facade to simplify an interface.
- The Facade is the layer of abstraction above the Subsystems, and knows which Subsystem to delegate appropriate work to.

## Visuals




## CSharp Implementation
- The facade pattern is so general that it applies to almost every major application, especially those where refactoring or modifying pieces of applications are needed for various reasons.

## Code (CSharp)
![Facade](/Facade_Design_Pattern/Assets/Facade.png)


## Applicability
- Anytime you want to add a layer of abstraction above the Subsystems whilst also knowing which Subsystem to delegate appropriate work to.
- It basically saves you the headache of delegating. It does it for you.

## Good and Bad

- Good: Hiding complexity which cannot be refactored away | There is really no known drawbacks to Facade. 

- More Good: It provides a unified interface to a set of interfaces in a subsystem. However, it does not ab ovo prevent clients from using the subsystem interfaces directly. So you are not forced to make any unwanted compromises with it. It is a win-win situation.


## Summary

- The Facade pattern is a simple (or at least simpler) overlay on top of a group of more complex subsystems. The Facade knows which Subsystem to direct different kinds of work toward. And it is really, really common, so it's one of the patterns we should know thoroughly.



### Citations
![Matthew Jones - The Facade Design Pattern](https://www.exceptionnotfound.net/facade-pattern-in-csharp/)