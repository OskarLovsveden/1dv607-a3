# A3 - 1DV607  

Assignment 3 in 1DV607

## Todo

[Coursepress - workshop 3](https://coursepress.lnu.se/kurs/objektorienterad-analys-och-design-med-uml/workshops-2/workshop-3-design-using-patterns/)

1. Remove the bad, hidden, dependency between the controller and view (new game, hit, stand).
2. Implemet the rule soft 17.
3. Design and implement a variable rule for who wins the game. Can be a variation of who wins if score is equal.
4. Refactor the code, getting a card from the deck, show the card and give it to a player is duplicated in a number of places.
try to find a good solution to this, (probably with GRASP)
5. Implement observerpattern
6. Update class diagram to reflect new changes

### Observer pattern

Use the observer pattern to tell the view to render when an action has been made (like stand, hit etc.)

Lecture about observer pattern:  
[Lecture L05 13:37](https://youtu.be/EJ6bNe4rSho?t=817)

### Grasp patterns

**Creator** - Where should the object be created

**Information** Expert - Who has the information of the operation

**Controller** - What class should handle system events  

**Low Coupling** - What design should we favour if we want low change impact and reuse? (Pick your battles here...)

**High Cohesion** - How to make classes easy to understand, focused and maintainable.  
Solution: Assign responsibilty so that a classis responsible for one thing only

**Indirection** - How can direct coupling between classes be avoided?  
Assign reponsibility to an intermediate class, to mediate between the others. Often a pure fabrication.

**Polymorphism** - What should you do if you have behavioyr that varies based on type?  
Solution: Assign responsibility to polymorphic operations and avoid extra states, type informaton and reflection

**Protected Variations** - How can we desion so that variation/change in pats of the system do not impact other parts.  
Solution: Identify the points of variation/instability, Encapsulate the points in an "interface". (Pick your battles)

**Pure Fabrication** - What if the domain or other patters offers no good solution??  
Solution: Make something up that offers the design you want. Then the software can do what we want.
