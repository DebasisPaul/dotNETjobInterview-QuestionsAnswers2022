- What is meant by object-oriented programming?
- How would you explain the four fundamental concepts of object-oriented programming? 
# Question 5: How can you describe object-oriented concepts in detail?
Answer:  C# is an object-oriented programming language that supports 4 OOP concepts.

Encapsulation: defines the binding together code and the data and keeps it safe from any manipulation done by other programs and classes. It is a container that prevents code and data from being accessed by another program that is defined outside the container.

Abstraction: this concept of object-oriented protects everything other than the relevant data about any created object in order to increase efficiency and security within the program.

Inheritance: Inheritance is applied in such a way where one object uses the properties of another object. 

Polymorphism: is a feature that allows one interface to act as a base class for other classes. This concept is often expressed as a "single interface but multiple actions". 

# Question: Explain the concept of boxing and unboxing of the value type and object type in C#.
Answer: 

Boxing- is a process of converting a value type to an object type where value type is placed on the stack memory, and the object type is placed in the heap memory. This conversion is an implicit conversion and you can directly assign any value to an object, and C# will handle the rest of the conversion on its own.
Example:

```
public void function()
{
Int a=111;
Object b=a; //implicit conversion
Console.WriteLine(b);
}
Unboxing- it is the reverse process of the boxing process. It is a conversion of the object type to the value type and the value of the boxed object type placed on the heap memory which will be transferred to the value type which is placed on the stack. This conversion of the unboxing process has to be done explicitly.

Example:

public void function()
{
Object b=111;
Int a=(int)b; //implicit conversion
Console.WriteLine(a);
}
```


- What is the difference between managed and unmanaged code?
11. What is Managed or Unmanaged Code? 

A code that is written to aimed to get the services of the managed runtime environment execution like CLR(Common Language Runtime) in .NET Framework is known as Managed Code. It is always implemented by the managed runtime environment instead of directly executed by the operating system. The managed runtime environment provides different types of services like garbage collection, type checking, exception handling, bounds checking, etc. to code automatically without the interference of the programmer. It also provides memory allocation, type safety, etc to the code. The application is written in the languages like Java, C#, VB.Net, etc. is always aimed at runtime environment services to manage the execution, and the code written in these types of languages is known as managed code.

A code that is directly executed by the operating system is known as Unmanaged code. It is always aimed at the processor architecture and depends upon computer architecture. When this code is compiled it always tends to get a specific architecture and always runs on that platform, in other words, whenever you want to execute the same code for the different architecture you have to recompile that code again according to that architecture. It always compiles to the native code that is specific to the architecture. To read more, refer to the article: Managed and Unmanaged code 

- What are the different types of classes in C#?
# Question 3: Describe the different C# classes in detail.
Answer:  There are 4 types of classes that we can use in C#:

Static Class: It is the type of class that cannot be instantiated, in other words, we cannot create an object of that class using the new keyword and the class members can be called directly using their class name.

Abstract Class: Abstract classes are declared using the abstract keyword. Objects cannot be created for abstract classes. If you want to use it then it must be inherited in a subclass. You can easily define abstract or non-abstract methods within an Abstract class. The methods inside the abstract class can either have an implementation or no implementation.

Partial Class: It is a type of class that allows dividing their properties, methods, and events into multiple source files, and at compile time these files are combined into a single class.

Sealed Class:  One cannot inherit a sealed class from another class and restricts the class properties. Any access modifiers cannot be applied to the sealed class. 


- What are the advantages of generics in C#?
- What are the disadvantages of generics in C#?

- What is meant by dependency injection in C#?

- What are boxing and unboxing in C#?
15. What is Boxing and Unboxing in C#?

Boxing and unboxing is an important concept in C#. C# Type System contains three data types: Value Types (int, char, etc), Reference Types (object), and Pointer Types. Basically, it converts a Value Type to a Reference Type, and vice versa. Boxing and Unboxing enable a unified view of the type system in which a value of any type can be treated as an object.

Boxing In C#

The process of Converting a Value Type (char, int, etc.) to a Reference Type(object) is called Boxing.
Boxing is an implicit conversion process in which object type (supertype) is used.
The Value type is always stored in Stack. The Referenced Type is stored in Heap.
Unboxing In C#

The process of converting the reference type into the value type is known as Unboxing.
It is an explicit conversion process.
To read more, refer to the article: C# – Boxing and Unboxing


- What is an object in C#?
-  What is a class in C#?
- What is meant by structure in C#?

# Question: What do you understand by Get and Set Accessor properties?
Answer: Made using properties, Get and Set are called accessors in C#. A property enables reading and writing to the value of a private field. Accessors are used for accessing such private fields. While we use the Get property for returning the value of a property, use the Set property for setting the value.


- What is C#? Write its features?
#  Question 1: What is C#? Write its features
Answer: C# is an object-oriented programming language that was developed by Microsoft in 2000. It is supported by different operating systems. C# is the primary language that is used to create .Net software applications. It allows us to create Windows UI apps, backend services, controls, libraries, android apps, and even blockchain applications. C# works on the concept of classes and objects just like Java.
### Some of the C# features are as follows:
- Follows structured approach
- Parameters passing is easy
- Code can be compiled on a different platform
- Open-source
- Object-oriented
- Flexible and scalable 


-  Explain what are classes and objects in C#?
# Question 2: Explain what are classes and objects in C#?
Answer: C# is an object-oriented language and classes are its foundation. A class generally depicts the structure of data, how data is stored and managed within a program. A class has its own properties, methods, and other objects that define the class.

Objects are the real-world entity having some characteristics and is created using the class instance. These classes define the type of the defined object.
For example, if we consider a program that covers the object related to the book. We call the class a Book which has two properties: name and the author. In real programming, Vedas is an object and an instance of the class Book.


- Explain different access modifiers in C#?
# Question 4: Explain different access modifiers in C#?
Answer: These are the keywords that help to define the accessibility of class, member, and data type in the program. These keywords are used to restrict the use of some data manipulation done by other classes. There are 4 types of access modifiers- public, private, protected, and internal. These modifiers define 6 other accessibility levels when working together- public, protected, internal, protected internal, private, and private protected.
### Below is the access chart of the modifiers.
-  PUBLIC	PROTECTED	INTERNAL	PROTECTED INTERNAL	PRIVATE	PRIVATE PROTECTED
- Complete program	Yes	No	No	No	No	No
- Derived types within the current assembly	Yes	Yes	No	Yes	No	Yes
- Using  class	Yes	Yes	Yes	Yes	Yes	Yes
- Current assembly	Yes	No	Yes	Yes	No	No
- Derived data types	Yes	Yes	No	Yes	No	No


- Explain how code gets compiled in C#?
# Question 6: Explain how code gets compiled in C#?
Answer: It takes 4 steps to get a code to get compiled in C#. Below are the steps:

- First, compile the source code in the managed code compatible with the C# compiler.
- Second, combine the above newly created code into assemblies.
- Third, load the CLR.
- Last, execute the assembly by CLR to generate the output.


- What is break and continue statements in C#, explain?
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


-  Why do we use Async and Await in C#?
https://www.softwaretestinghelp.com/c-sharp-interview-questions/

- What do you understand by regular expressions in C#? Write a program that searches a string using regular expressions.

-  Give a detailed explanation of Delegates in C#.
# Question: Give a detailed explanation of Delegates in C#.
Answer: Delegates are variables that hold references to methods. It is a function pointer or reference type. Both the Delegate and the method to which it refers can have the same signature. All Delegates derives from the
```
System.Delegate namespace.
Following example demonstrates declaring a delegate:

public delegate AddNumbers(int n);
After declaring a delegate, the object must be created of the delegate using the new keyword, such as:

AddNumbers an1 = new AddNumbers(number);
The Delegate offers a kind of encapsulation to the reference method, which gets internally called with the calling of the delegate. In the following example, we have a delegate myDel that takes an integer value as a parameter: public delegate int myDel(int number); public class Program { public int AddNumbers(int a) { Int Sum = a + 10; return Sum; } public void Start() { myDel DelgateExample = AddNumbers; } }
```

- What are Namespaces in C#?
# Question: What are Namespaces in C#?
Answer: Use of namespaces is for organizing large code projects. The most widely used namespace in C# is System. Namespaces are created using the namespace keyword. It is possible to use one namespace in another, known as Nested Namespaces.


-  How will you differentiate between a Class and a Struct?
# Question: How will you differentiate between a Class and a Struct?

Answer: Although both class and structure are user-defined data types, they are different in several fundamental ways. A class is a reference type and stores on the heap. Struct, on the other hand, is a value type and is, therefore, stored on the stack. While the structure doesn’t support inheritance and polymorphism, the class provides support for both. A class can be of an abstract type, but a structure can’t. All members of a class are private by default, while members of a struct are public by default. Another distinction between class and struct is based on memory management. The former supports garbage collection while the latter doesn’t.


# Question: What are the control statements that are used in C#?
Answer: You can control the flow of your set of instructions by using control statements and we majorly focus on if statements. There are a few types of if statements that we consider for making situations to control the flow of execution within a program.

### These are the 4 types of if statements:

-  If
- If-else
- Nested if
- If-else-if 

**These statements are commonly used within programs.**

**If statements checks for the user given condition to satisfy their programming condition. If it returns true then the set of instructions will be executed.**

Syntax:

```
If(any condition)
{
//code to be executed if the condition returns true
}

If-else statement checks for the given condition, if the condition turns out to be false then the flow will transfer to the else statement and it will execute the else instructions. In case, the if condition turns out to be true then the if instructions will get executed.

Syntax:

If(condition)
{
//code to be run if the condition is true
}
Else
{
//code to be run if the if-condition is false
}
Nested if statement checks for the condition, if the condition is true then it will check for the inner if statement and keeps going on for the last if statement. If any of the conditions are true then it will execute the particular if instructions and stops the if loop there.

Syntax:

If (condition to be checked)
{
//code
If(condition 2)
{
//code for if-statement 2
}
}
If else-if checks for the given condition, if the condition is not true then the control will go to the next else condition, if that condition is not true it will keep on checking for next else conditions. If any of the conditions did not pass then the last else instructions will get executed.

Syntax:

If(condition 1 to be checked)
{
//code for condition 1
}
Else (condition 2 to be checked)
{
//code for condition 2
}
Else
{
//code will run if no other condition is true
}
```

# Question: How you can define the exception handling in C#?
Answer: An exception is a raised problem that may occur during the execution of the program. Handling exceptions offers a simple way to pass the control within the program whenever an exception is raised. C# exceptions are handled by using 4 keywords and those are try, catch, finally, throw.

try: a raised exception finds a particular block of code to get handled. There is no limit on the number of catch blocks that you will use in your program to handle different types of exception raised.

catch: you can handle the raised exception within this catch block. You can mention the steps that you want to do to solve the error or you can ignore the error by suppressing it by the code.

Finally: irrespective of the error, if you still want some set of instructions to get displayed then you can use those statements within the finally block and it will display it on the screen.

throw: you can throw an exception using the throw statement. It will display the type of error you are getting.
Syntax:

```
try {
//exception handling starts with try block
} catch( ExceptionName ea1 ) {
   // errors are handled within the catch block
} catch( ExceptionName e2 ) {
   // more catch block
} catch( ExceptionName eN ) {
   // more catch block to handle multiple exception raised
} finally {
   // last block of the exception handling
} 
```

- Define interface class in C#? Explain with an example.
. What is meant by an Interface?
An interface is a class that does not have any implementation. Only the declarations of events, properties, and attributes are included.

- What do you mean by value types and reference types in C#?
# Question: What do you mean by value types and reference types in C#?
Answer:

Value type:

The memory allocated for the value type content or assigned value is stored on the stack. When we create any variable, space is allocated to that variable and then a value can be assigned to that variable. Also if we want to copy the value of that variable to another variable, its value gets copied and that creates two different variables.

Reference Type:

It holds the reference to the address of the object but not the object directly. Reference types represent the address of the variable and assigning a reference variable to another does not copy the data but it creates a second copy of the reference which represents the same location on the heap as the original value. Reference values are stored on the heap and when the reference variable is no longer required it gets marked for garbage collection.


- How you can implement nullable<> types in C#? explain with the syntax of Nullable type.
# Question: How you can implement nullable<> types in C#? explain with the syntax of Nullable type.
Answer: In C#, you cannot put a null value directly into any variable and the compiler does not support it. So, the revised version C# 2.0 provides you with a special feature that will assign a null value to a variable that is called as the Nullable type. You cannot make the nullable types to work with value types. Nullable value can only work with the reference types as it already has a null value. System.Nullable<T> structure creates the instance nullable type, where T defines the data type. This T contains a non-nullable value type that can be any data type you want.

Syntax

```
Nullable<data_type> variable_name=null;
OR

Datatype? variable_name=null;
There is no possibility that you can access the value of the nullable value type directly with assigning the value. For getting its original assigned value you have to use the method GetValueOrDefault(). If the value is null then it will provide zero as it is its default value.
```

- What is a different approach to the passing parameter in C#?
# Question: What is a different approach to the passing parameter in C#?
Answer:  Parameters can be passed in three different ways to any defined methods and they are defined below:

Value Parameters:  it will pass the actual value of the parameter to the formal parameter. In this case, any changes that are made into the formal parameter of the function will be having no effect on the actual value of the argument.

Reference Parameters: with this method, you can copy the argument that refers to the memory location into the formal parameter that means any changes made to the parameter affect the argument.

Output Parameters: This method returns more than one value to the method.


-  What are the control statements that are used in C#?
# Question: What do you mean by user control and custom control in C#?
Answer: User controls are very easy to create and are very much the same as the ASP control files. You cannot place a user control on the toolbox and cannot even drag-drop it. They have unique design and individual code behind these controls. Ascx is the file extension for user control. 

You can create custom code as the compiled code and can be added to the toolbox. You can include these controls to the web forms easily. Custom controls can be added to multiple applications efficiently. If you want to add a private custom control then you can copy it to dll and then to the bin directory of your web application and use its reference there.


- Describe the C# dispose of the method in detail.
# Question9: Describe the C# disposeof() the method in detail.
Answer: Disposeof the method: The disposeof() method releases the unused resources by an object of the class. The unused resources like files, data connections, etc. This method is declared in the interface called IDisposable which is implemented by the class by defining the interface IDisposable body. Dispose method is not called automatically, the programmer has to implement it manually for the efficient usage of the resources.

-  Explain in detail the finalize method in C#?
# Question: Explain in detail the finalize method in C#?
Answer: Finalize method- The finalize () method is defined in the object class which is used for cleanup activities. This method is generally called by the garbage collector whenever the reference of any object is not used for a long time. Garbage collector frees that managed resources automatically but if you want to free the unused resources like filehandle, data connection, etc., then you have to implement the finalize method manually.

# Question: What is an Indexer in C#, and how do you create one?
Answer: Also known as an indexed property, an indexer is a class property allowing accessing a member variable of some class using features of an array. Used for treating an object as an array, indexer allows using classes more intuitively. Although not an essential part of the object-oriented programming, indexers are a smart way of using arrays. As such, they are also called smart arrays. Defining an indexer enables creating classes that act like virtual arrays. Instances of such classes can be accessed using the [] array access operator. The general syntax for creating an indexer in C# is:
```
< modifier > <
return type > this[argument list] {
get {
// the get block code
}
set {
// the set block code
}
}
```

# Question: Define structure in C# with example.
Answer: A structure is a data type of a value type. A struct keyword is used when you are going to define a structure. A structure represents a record and this record can have many attributes that define the structure.  You can define a constructor but not destructor for the structure. You can implement one or more interfaces within the structure. You can specify a structure but not as abstract, virtual, or protected. If you do not use the new operator the fields of the structure remain unassigned and you cannot use the object till you initialize the fields.

-  What is Common Language Runtime (CLR)?
3. What is Common Language Runtime (CLR)?

CLR is the basic and Virtual Machine component of the .NET Framework. It is the run-time environment in the .NET Framework that runs the codes and helps in making the development process easier by providing various services such as remoting, thread management, type-safety, memory management, robustness, etc. Basically, it is responsible for managing the execution of .NET programs regardless of any .NET programming language. It also helps in the management of code, as code that targets the runtime is known as the Managed Code, and code that doesn’t target to runtime is known as Unmanaged code. To read more, refer to the article: Common Language Runtime.



- What is garbage collection in C#?
 What is garbage collection in C#?

Automatic memory management is made possible by Garbage Collection in .NET Framework. When a class object is created at runtime, certain memory space is allocated to it in the heap memory. However, after all the actions related to the object are completed in the program, the memory space allocated to it is a waste as it cannot be used. In this case, garbage collection is very useful as it automatically releases the memory space after it is no longer required. 

Garbage collection will always work on Managed Heap, and internally it has an Engine which is known as the Optimization Engine. Garbage Collection occurs if at least one of multiple conditions is satisfied. These conditions are given as follows:

If the system has low physical memory, then garbage collection is necessary.
If the memory allocated to various objects in the heap memory exceeds a pre-set threshold, then garbage collection occurs.
If the GC.Collect method is called, then garbage collection occurs. However, this method is only called under unusual situations as normally garbage collector runs automatically.
To read more, refer to the article: Garbage collection in C#.

- What is Jagged Arrays?
23. What is Jagged Arrays?

A jagged array is an array of arrays such that member arrays can be of different sizes. In other words, the length of each array index can differ. The elements of Jagged Array are reference types and initialized to null by default. Jagged Array can also be mixed with multidimensional arrays. Here, the number of rows will be fixed at the declaration time, but you can vary the number of columns. To read more, refer to the article: Jagged Array in C#


- What is Singleton design pattern in C#?
- How to implement a singleton design pattern in C#?
# Question: What is Singleton Design Patterns in C#? Explain their implementation using an example.
Answer: A singleton in C# is a class that allows the creation of only a single instance of itself and provides simple access to that sole instance. Because the second request of an instance with a different parameter can cause problems, singletons typically disallow any parameters to be specified. Following example demonstrates the implementation of Singleton Design Patterns in C#:

```
namespace Singleton {
class Program {
static void Main(string[] args) {
Calculate.Instance.ValueOne = 10.5;
Calculate.Instance.ValueTwo = 5.5;
Console.WriteLine("Addition : " + Calculate.Instance.Addition());
Console.WriteLine("Subtraction : " + Calculate.Instance.Subtraction());
Console.WriteLine("Multiplication : " + Calculate.Instance.Multiplication());
Console.WriteLine("Division : " + Calculate.Instance.Division());
Console.WriteLine("\n----------------------\n");
Calculate.Instance.ValueTwo = 10.5;
Console.WriteLine("Addition : " + Calculate.Instance.Addition());
Console.WriteLine("Subtraction : " + Calculate.Instance.Subtraction());
Console.WriteLine("Multiplication : " + Calculate.Instance.Multiplication());
Console.WriteLine("Division : " + Calculate.Instance.Division());
Console.ReadLine();
}
}
public sealed class Calculate {
private Calculate() {}
private static Calculate instance = null;
public static Calculate Instance {
get {
if (instance == null) {
instance = new Calculate();
}
return instance;
}
}
public double ValueOne {
get;
set;
}
public double ValueTwo {
get;
set;
}
public double Addition() {
return ValueOne + ValueTwo;
}
public double Subtraction() {
return ValueOne - ValueTwo;
}
public double Multiplication() {
return ValueOne * ValueTwo;
}
public double Division() {
return ValueOne / ValueTwo;
}
}
}
```

A Singleton Design Pattern ensures that a class has one and only one instance and provides a global point of access to the same. There are numerous ways of implementing the Singleton Design Patterns in C#. Following are the typical characteristics of a Singleton Pattern:

A public static means of getting the reference to the single instance created
A single constructor, private and parameter-less
A static variable holding a reference to the single instance created
The class is sealed


- What is the difference between Array and ArrayList?
https://www.geeksforgeeks.org/top-50-c-sharp-interview-questions-answers/

- Distinguish between System.String and System.Text.StringBuilder classes?
 What is the  System. String and System.Text.StringBuilder classes?

C# StringBuilder is similar to Java StringBuilder. A String object is immutable, i.e. a String cannot be changed once created. Every time when you use any of the methods of the System. String class, then you create a new string object in memory. For example, a string “GeeksForGeeks” occupies memory in the heap, now, changing the initial string “GeeksForGeeks” to “GFG” will create a new string object on the memory heap instead of modifying the initial string at the same memory location. In situations where you need to perform repeated modifications to a string, we need the StringBuilder class. To avoid string replacing, appending, removing, or inserting new strings in the initial string C# introduce StringBuilder concept. StringBuilder is a dynamic object. It doesn’t create a new object in the memory but dynamically expands the needed memory to accommodate the modified or new string. To read more, refer to the article: System.String and System.Text.StringBuilder in C#

- Illustrate the differences between the System.Array.CopyTo() and System.Array.Clone()?
25. What’s the difference between the System.Array.CopyTo() and System.Array.Clone() ?

The System.Array.CopyTo() technique makes a replica of the components into another existing array. It makes copies the components of one cluster to another existing array. The Clone() technique returns a new array object containing every one of the components in the first array. The Clone() makes a duplicate of an array as an object, consequently should be cast to the real exhibit type before it tends to be utilized to do definitely. The clone is of a similar type as the first Array.  

- What is the difference between public, static and void?
4. What is the difference between public, static, and void?
Public declared variables or methods are accessible anywhere in the application. Static declared variables or methods are globally accessible without creating an instance of the class. Static member are by default not globally accessible it depends upon the type of access modified used. The compiler stores the address of the method as the entry point and uses this information to begin execution before any objects are created. And Void is a type modifier that states that the method or variable does not return any value.

- What is the difference between method overloading and method overriding in C#?
35. What is the difference between method overriding and method overloading?
In method overriding, we change the method definition in the derived class that changes the method behavior. Method overloading is creating a method with the same name within the same class having different signatures.
