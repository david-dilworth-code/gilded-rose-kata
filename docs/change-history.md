# Change History

## Commit 1
The first task is just to get all the tests green.
There does not appear to be much value in the test in GildedRoseTest.cs at the moment, but it is simple enough to fix.
However, it does raise one obvious question ... Is the name of an Item immutable or not?

## Commit 2
Added new LegendaryItem class to encapsulate the behaviour specific for a **Legendary Item**.
At this stage it is just a case of getting the simplest alternative implementation for a new item type to work, without breaking any existing tests.
The main question that arises from this change is ... Do all Legendary Items have a fixed Quality value of 80?

## Commit 3
Added new NormalItem class to encapsulate the standard behaviour for those items that degrade normally over time.
Added the first extra covering unit tests to verify the mechanics of the calculations using the "verified" output for the expected results.

## Commit 4
Quick refactor in the main GildedRose class to make further usage of the IUpdateQuality interface less impactful.

## Commit 5
Added new ImprovingItem class to encapsulate the behaviour for items that improve in Quality over time.

## Commit 6
Added new TicketItem class to encapsulate the behaviour for Tickets (backstage passes). These items have a complex quality model.

## Commit 7
The current behaviour for "conjured items" appears to be the same as the NormalItem.
This minor refactor demonstrates this is true by converting the input data to use another instance of a NormalItem.
All of the complex logic in the GildedRose class can be removed at this point.
An important question is now raised ... What should happen going forwards with items that do not implement the IUpdateQuality interface?

## Commit 8
Finally the new requirement for "conjured items" can be developed.
Following the new pattern there is a new class called ConjuredItem to encapsulate the required behaviour.
This is the one and only time that the "verified" tests had to be changed, but that was expected because this is a new requirement.
One question at this stage is ...Do Conjured Items always degrade twice as fast as Normal items?
