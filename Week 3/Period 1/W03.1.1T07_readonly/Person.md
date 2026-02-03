# Overview
This exercise introduces the concept of `readonly` fields; fields that can only be assigned a value once.
It requires the programmer to look through the given `Bicycle` and `Person` classes and add `readonly` to the fields that will never change.

Only some fields in both classes were altered by me, the rest was provided as a template by CodeGrade.

I kinda disagree with the solution to this one. I had to mark the FrameNumber of the Bicycle and the Name of the Person as readonly,
but a person's name *technically* CAN change.
But CodeGrade disagrees, so I had to mark that as readonly as well, despite it telling me to use common sense. Great times.

# Code
For the `Bicycle` class, see Bicycle.cs in this directory.
```cs
class Person
{
    public readonly string Name;
    public int Age = 0;

    public Person(string name) => Name = name;

    public void GrowOlder() => Age++;
}
```
