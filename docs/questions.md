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