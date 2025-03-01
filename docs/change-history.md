# Change History

## Commit 1
The first task is just to get all the tests green.
There does not appear to be much value in the test in GildedRoseTest.cs at the moment, but it is simple enough to fix.
However, it does raise one obvious question ... Is the name of an Item immutable or not?

## Commit 2
Added new LegendaryItem class to encapsulate the behaviour specific for a **Legendary Item**.
At this stage it is just a case of getting the simplest alternative implementation for a new item type to work, without breaking any existing tests.
The main question that arises from this change is ... Do all Legendary Items have a fixed Quality value of 80? 