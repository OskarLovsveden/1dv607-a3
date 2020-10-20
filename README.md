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

**Grasp patterns:**
Creator - Where should the object be created
Information Expert - Who has the information of the operation
Controller - What class should handle system events
Low Coupling
High Cohesion
Indirection
Polymorphism
Protected Variations
Pure Fabrication
