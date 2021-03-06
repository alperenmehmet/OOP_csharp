# OOP_csharp
Complete Object Oriented Programming Concept with CSharp
<hr>
<h2>Access Modifiers</h2><br>
There are four access modifier keywords and two combinations of access modifier keywords. These are ; private, public, protected, internal, internal protected, private protected.

1. Private ; member is accesible inside the type only. In C#, this member is default.
1. Public ; member is accessible everywhere.
1. Protected ; member is accessible inside the type and any type that inherits from the type.
1. Internal ; member is accessible inside the type and any type in the same assembly.
1. Internal Protected ; member is accessible inside the type, any type in the same assembly, and any type that inherits from the type.
1. Private Protected ; member is accessible inside the type or any type that inherits from the type and is in the same assembly.
<hr>
<h2>Encapsulation</h2><br>
Encapsulation is sometimes referred to as the first pillar or principle of object-oriented programming. Encapsulation means hiding unnecessary details from type consumers.
<hr>
<h2>Abstraction</h2><br>
Abstraction is related features in obeject oriented programming. Abstract classes are written to be based on other classes. So you cannot create an instance of an abstract class. The purpose of abstract class is to require the use of some properties in classes that inherit from them.
<hr>
<h2>Interface</h2><br>
In C#, an interface can be defined using the interface keyword. And it is considered good practice to start with the letter "I" at the beginning of an interface, as it makes it easier for yourself and others to remember that it is an interface and not a class. In interfaces all members has to be override. An interface can contain declarations of methods, properties, indexers, and events. However, it cannot contain fields, auto-implemented properties. If I create a property in interfaces, I have to implement all of the members in subclass. Interfaces can be implemented implicitly and explicitly. Implicit implementations are simpler. Explicit implementations are only necessary if a type must have multiple methods with the same name and signature.
<hr>
<h2>Inheritance</h2><br>
Inheritance is one of the fundamental attributes of object-oriented programming. It allows you to define a child class that reuses (inherits), extends, or modifies the behavior of a parent class. The class whose members are inherited is called the base class. The class that inherits the members of the base class is called the derived class.
<hr>
<h2>Polymorphism</h2><br>
Polymorphism is the method that allows a method to create different effects for different classes.
<hr>
<h3>Additional Information</h3>
In this project, I want to explain Object Oriented Programming concepts with C# Programming Language. I use console app and Visual Studio 2019. If you open the project you will see 6 project in the solution layer. Every project is independent. I hope will like this project. If you are having trouble using this project, please open a new issue and describe your problem. Liked the project? Just give it a star.
