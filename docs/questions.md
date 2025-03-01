# Questions

Q. Is the name of an **Item** immutable or not?

On first inspection the code seems to contain a number of "magic" strings that drive behaviour.
The provided `Item` class has a public property getter/setter, which could imply the `Name` property is in fact mutable.
However, the "verified" text file will only work if the strings remain unchanged.

Assumption: The name of an **Item** is actually an immutable string.