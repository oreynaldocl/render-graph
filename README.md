# Description
Solutions for graph problem. Getting alphabetical order text from this binary tree

```
       A
    B     C
   D     E F
```

# Node approach
Simple solution using `JS arrays` as queues. `shift` will get and remove the first element of array.
The solution could be reduced to just one while. In C# solution it was fixed just to one while.

[index.js](/node/index.js)

# C# approach
Creating classes and unit testing for solution.
It is a console solution. But I prefer to play with test.
You can see the exercise solution in Test files.

## Queue solution
Improved queue solution using same `working` queue. There is no problem to add left and right of each node while working on it. Because they are added at the end.

[QueuePrinter.cs](/GraphExcercise/GraphExcercise/printer/QueuePrinter.cs)

[QueuePrinterTest.cs](/GraphExcercise/TestGraphExcercise/QueuePrinterTest.cs)

## Queue solution
Children solution works too, but requires another iteration.
The working list is always replaced for next level of children.

[ChildrenPrinter.cs](GraphExcercise/GraphExcercise/printer/ChildrenPrinter.cs)

[ChildrenPrinterTest.cs](GraphExcercise/TestGraphExcercise/ChildrenPrinterTest.cs)
