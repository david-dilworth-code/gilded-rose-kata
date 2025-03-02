# Questions

Q. Is the name of an **Item** immutable or not?

On first inspection the code seems to contain a number of "magic" strings that drive behaviour.
The provided `Item` class has a public property getter/setter, which could imply the `Name` property is in fact mutable.
However, the "verified" text file will only work if the strings remain unchanged.

Assumption: The name of an **Item** is actually an immutable string.


Q: Do all Legendary Items have a fixed Quality value of 80? 

The requirement specification is clear on the fact that Legendary Items do not need to be sold and do not change quality.
However, there is only one example given for the fixed quality value of "Sulfuras" and it is unclear whether this would apply to all Legendary Items or not.

Assumption: The inventory defined in the main program only contains "Sulfuras", so it is assumed that all Legendary Items have a fixed Quality value of 80.

Q: What should happen going forwards with items that do not implement the IUpdateQuality interface?
At this point the code has been refactored to a point where all the logic is now encapsulated in individual classes.
However the legacy "Item" class and the associated IList are still in the GildedRose class.
So whilst it is technically possible to create an Item and add it to the collection, all the existing code has been refactored to the new model.

Assumption: For the purpose of this kata there are no instances of the Item class remaining and it can be considered "Not A Problem".
(Note: In the real world this is very much a potential problem and it would require further analysis and discussion)