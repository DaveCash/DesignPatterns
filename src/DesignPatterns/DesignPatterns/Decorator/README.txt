The decorator pattern is used to ADD functionality to an object without modifying its implementation or inheritance.

This is done by having an abstract "decorator" class which implements the interface of the object in question. This abstract decorator takes as a parameter an object of the interface type, and stores it in a private field (the "decorated" object). Concrete decorators can then be created, which 
inherit the abstract decorator class. By overriding the abstract implementations of the abstract class, these concrete decorators can add functionality as needed. These concerete decorators can then be used to decorate the object implementing the interface. Since the decorators implement the same
interface, the decorators can be chained together.

In this project, we have an IShape interface, which has a few methods. We want to be able to add some simple logging and usage statistic recording functionality to implementations of IShape. Adding that functionality directly to the IShape implementations would add non-shape related concerns 
to those classes (single responsibility principle). ConsoleLoggingShapeDecorator and UsageRecordingShapeDecorator allow us to keep this new functionality separate from the IShape implementations.

Another benefit of decorators is avoiding inheritance. Implementing the same above behavior using inheritance would result in a class hierarchy explosion like:
IShape --> Square
                 --> ConsoleLoggingSquare
                 --> UsageRecordingSquare
                                           --> ConsoleLoggingUsageRecordingSquare
       --> Circle
                --> ConsoleLoggingCircle
                --> UsageRecordingCircle
                                           --> ConsoleLoggingUsageRecordingCircle

"As a rule of thumb, if your subclass only depends on the public interface of its parent, it’s a hint that you could use a decorator instead.""

Useful links
____________
https://refactoring.guru/design-patterns/decorator
https://dzone.com/articles/is-inheritance-dead#:~:text=The%20decorator%20pattern%20should%20be,is%20simple%20and%20scales%20linearly.