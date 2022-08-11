#  Question 1: What is C#? Write its features
Answer: C# is an object-oriented programming language that was developed by Microsoft in 2000. It is supported by different operating systems. C# is the primary language that is used to create .Net software applications. It allows us to create Windows UI apps, backend services, controls, libraries, android apps, and even blockchain applications. C# works on the concept of classes and objects just like Java.

### Some of the C# features are as follows:
- Follows structured approach
- Parameters passing is easy
- Code can be compiled on a different platform
- Open-source
- Object-oriented
- Flexible and scalable 

# Question 2: Explain what are classes and objects in C#?
Answer: C# is an object-oriented language and classes are its foundation. A class generally depicts the structure of data, how data is stored and managed within a program. A class has its own properties, methods, and other objects that define the class.

Objects are the real-world entity having some characteristics and is created using the class instance. These classes define the type of the defined object.
For example, if we consider a program that covers the object related to the book. We call the class a Book which has two properties: name and the author. In real programming, Vedas is an object and an instance of the class Book.

# Question 3: Describe the different C# classes in detail.
Answer:  There are 4 types of classes that we can use in C#:

Static Class: It is the type of class that cannot be instantiated, in other words, we cannot create an object of that class using the new keyword and the class members can be called directly using their class name.

Abstract Class: Abstract classes are declared using the abstract keyword. Objects cannot be created for abstract classes. If you want to use it then it must be inherited in a subclass. You can easily define abstract or non-abstract methods within an Abstract class. The methods inside the abstract class can either have an implementation or no implementation.

Partial Class: It is a type of class that allows dividing their properties, methods, and events into multiple source files, and at compile time these files are combined into a single class.

Sealed Class:  One cannot inherit a sealed class from another class and restricts the class properties. Any access modifiers cannot be applied to the sealed class. 


# Question 4: Explain different access modifiers in C#?
Answer: These are the keywords that help to define the accessibility of class, member, and data type in the program. These keywords are used to restrict the use of some data manipulation done by other classes. There are 4 types of access modifiers- public, private, protected, and internal. These modifiers define 6 other accessibility levels when working together- public, protected, internal, protected internal, private, and private protected.

### Below is the access chart of the modifiers.
  -  PUBLIC	PROTECTED	INTERNAL	PROTECTED INTERNAL	PRIVATE	PRIVATE PROTECTED
- Complete program	Yes	No	No	No	No	No
- Derived types within the current assembly	Yes	Yes	No	Yes	No	Yes
- Using  class	Yes	Yes	Yes	Yes	Yes	Yes
- Current assembly	Yes	No	Yes	Yes	No	No
- Derived data types	Yes	Yes	No	Yes	No	No


# Question 5: How can you describe object-oriented concepts in detail?
Answer:  C# is an object-oriented programming language that supports 4 OOP concepts.

Encapsulation: defines the binding together code and the data and keeps it safe from any manipulation done by other programs and classes. It is a container that prevents code and data from being accessed by another program that is defined outside the container.

Abstraction: this concept of object-oriented protects everything other than the relevant data about any created object in order to increase efficiency and security within the program.

Inheritance: Inheritance is applied in such a way where one object uses the properties of another object. 

Polymorphism: is a feature that allows one interface to act as a base class for other classes. This concept is often expressed as a "single interface but multiple actions". 


# Question 6: Explain how code gets compiled in C#?
Answer: It takes 4 steps to get a code to get compiled in C#. Below are the steps:

- First, compile the source code in the managed code compatible with the C# compiler.
- Second, combine the above newly created code into assemblies.
- Third, load the CLR.
- Last, execute the assembly by CLR to generate the output.

# Question 7: What is break and continue statements in C#, explain?
Answer:  Below is the differences:

## Break	
- You can use break statements in both switch and loop (for, while, and do-while ) statements.	
- The switch or loop statements terminate at the moment the break statement is executed and it ends abruptly from there.	
- The loop or switch exits immediately from the inner loop when the compiler encounters a break statement and comes out of the inner loop.	
### Continue
- You can use continue statements only in the loop (for, while, do) statements.
- You cannot make a continue statement terminate the loop, it carries on the loop to go to the next iteration level without executing the immediate next step.
- A continue that is placed inside a nested loop within a switch causes the next loop iteration.

# Question 8: How you can explain the use of ‘using’ statements in C# in detail.
Answer:  The using statement is used to control the usage of one or more resources that are being used within the program. The resources are continuously consumed and released. The main function of this statement is to manage unused resources and release them automatically. Once the object is created which is using the resource and when you are done you make sure that the object’s dispose method is called to release the resources used by that object, this is where using statements works well.


For example:

```
using (MyResource abc = new MyResource())
{
 abc.program();
}
Gets translated to,
MyResource abc= new MyResource();
try
{
 myRes.program();
}
finally
{
 // Check for a null resource.
 if (abc!= null)
     // Call the object's Dispose method.
     ((IDisposable)abc).Dispose();
}
```