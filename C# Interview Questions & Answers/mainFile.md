



# Question: Explain the concept of Destructor in detail. Explain it with an example.
Answer:  A destructor is a member that works just the opposite of the constructor. Unlike constructors, destructors mainly delete the object. The destructor name must match exactly with the class name just like a constructor. A destructor block always starts with the tilde (~) symbol.

Syntax:

```
~class_name()
{
//code
}
```

### A destructor is called automatically:
- when the program finishes its execution.
- Whenever a scope of the program ends that defines a local variable.
- Whenever you call the delete operator from your program.

# Question: Define method overloading with example.
Answer: Method overloading allows programmers to use multiple methods but with the same name. Every defined method within a program can be differentiated on the basis of the number and the type of method arguments. It is a concept based on polymorphism.

### Method overloading can be achieved by the following:

- By changing the number of parameters in the given method
- By changing the order of parameters passed to a method
- By using different data types as the passed parameters

For example:
```
public class Methodoveloading    
  {    
    public int sum(int a, int b)  //two int type Parameters method  
    {    
        return a + b;    
            }    
    public int sum(int a, int b,int c)  //three int type Parameters with same method same as above  
    {   
        return a + b+c;    
    }    
    public float sum(float a, float b,float c,float d)  //four float type Parameters with same method same as above two method 
    {    
        return a + b+c+d;    
    
    }    
  }   
  ```



# Question: How can you check if a number is an Armstrong number or not with C#?
Answer:
```
using System;  
  public class ArmstrongDemo  
   {  
     public static void Main(string[] args)  
      {  
       int  n,b,sum=0,num;      
       Console.Write("Enter the Number= ");      
       n= int.Parse(Console.ReadLine());     
       num=n;      
       while(n>0)      
       {      
        b=n%10;      
        sum=sum+(b*b*b);      
        n=n/10;      
       }      
       if(num==sum)      
        Console.Write("Armstrong Number.");      
       else      
        Console.Write("Not Armstrong Number.");      
      }  
  }  
  ```
Output:

Enter the Number= 371
Armstrong Number.



# Question: What is a multicast delegate in C#?
Answer: A multicast delegate holds the references or addresses to more than one function at a single time. Whenever we invoke the multicast delegate, it will invoke all the other functions that are being referred by that multicast delegate. You should use the complete method signature the same as the delegate to call multiple methods. For example:
```
namespace MulticastDelegate
{
public class Rectangle
{
public void Area(double Width, double Height)
{
Console.WriteLine(@"Area is {0}", (Width * Height));
}
public void Perimeter(double Width, double Height)
{
Console.WriteLine(@"Perimeter is {0}", (2 * (Width + Height)));
}
static void Main(string[] args)
{
Rectangle rect = new Rectangle();
rect.Area(23.45, 67.89);
rect.Perimeter(23.45, 67.89);
Console.ReadKey();
}
}
}
```
Here, we created an instance of the Rectangle class and then called the two different methods. Now a single delegate will invoke these two methods Area and Perimeter. These defined methods are having the same signature as the defined delegates that hold the reference to these methods.

Creating multicast delegate:
```
namespace MulticastDelegateDemo
{
public delegate void RectangleDelete(double Width, double Height);
public class Rectangle
{
public void Area(double Width, double Height)
{
Console.WriteLine(@"Area is {0}", (Width * Height));
}
public void Perimeter(double Width, double Height)
{
Console.WriteLine(@"Perimeter is {0}", (2 * (Width + Height)));
}
static void Main(string[] args)
{
Rectangle rect = new Rectangle();
RectangleDelete rectDelegate = new RectangleDelete(rect.Area);
rectDelegate += rect.Perimeter;
rectDelegate(23.45, 67.89);
Console.WriteLine();
rectDelegate.Invoke(13.45, 76.89);
Console.WriteLine();
//Removing a method from delegate object
rectDelegate -= rect.Perimeter;
rectDelegate.Invoke(13.45, 76.89);
Console.ReadKey();
}
}
}
```

# Question: What are various types of comments in C#, explain with example?
Answer:  C# supports three types of comments-

```
1. Single line comment

Syntax:  //single line

2. Multiple line comment

Syntax: /* multiple lines

*/

3. XML comment

Syntax: /// set error
```

# Question: What are the constructors?
Answer: In C#, there is a special method that is invoked automatically at the time of object creation. It initializes the data members of a new object and has the same name as the class or the structure. There are two types of constructors:

Default constructor: it has no parameter to pass.
Parameterized constructor: it is invoked with parameters that are passed to the class during object creation.
Question: What are the different collection classes in C#?
Answer: Collection classes are classes that are mainly used for data storage and retrieval. These collection classes will serve many purposes like allocating dynamic memory during run time and you can even access the items of the collection using the index value that makes the search easier and faster. These collection classes belong to the object class.

There are many collection classes which are as follows:

Array list: it refers to the ordered collection of the objects that are indexed individually. You can use it as an alternative to the array. Using index you can easily add or remove the items off the list and it will resize itself automatically. It works well for dynamic memory allocation, adding or searching items in the list.

Hash table: if you want to access the item of the hash table then you can use the key-value to refer to the original assigned value to the variable. Each item in the hash table is stored as a key/value pair and the item is referenced with its key value.

Stack: it works on the concept of last-in and first-out collection of the objects. Whenever you add an item to the list it is called pushing and when you remove the item off the list it is called popping.

Sorted list: this collection class uses the combination of key and the index to access the item in a list.

Queue: this collection works on the concept of first-in and first-out collection of the object. Adding an item to the list is call enqueue and removing the item off the list is call deque.

BitArray: this collection class is used to represent the array in binary form (0 and 1). You can use this collection class when you do not know the number and the items can be accessed by using integer indexes that start from zero.

# Question: Explain file handling in C#.
Answer: Whenever you open a file for reading or writing it becomes a stream which is a sequence of bytes travelling from source to destination. The two commonly used streams are input and output. The included namespace is system.IO that includes many classes for file handling. The stream is an abstract class that is the parent class for the file handling process. The file is a static class with many static methods to handle file operation.

Below are the used classes:

The following table describes some commonly used classes in the System.IO namespace.

Class Name	Description
FileStream	This stream read from and write to any location within a file
BinaryReader	read primitive data types from a binary stream
DirectoryInfo	perform operations on directories
FileInfo	perform operations on files
BinaryWriter	write primitive data types in binary format
StreamReader	to read characters from a byte Stream
StreamWriter	write characters to a stream.
StringReader	read from a string buffer
StringWriter	write into a string buffer
Question: Define interface class in C#? Explain with an example.
Answer: An interface class is completely an abstract class that contains abstract methods and properties. By default, the members of the interface class are abstract and public with no fields defined. If you want to access the interface methods then the interface must be implemented by another class using ‘:’ symbol. If you want to define the body of the methods that can only be implemented in the implementing class.

For example:
```
// Interface
Interface IAnimal {
  void Sound(); // interface method (without body)
}
class Pig : IAnimal   // Pig class "implements" the IAnimal interface
{
  public void Sound()
  {  
Console.WriteLine("The pig says: wee wee"); // The body of Sound() is provided her
  }
}
class Program
{
  static void Main(string[] args)
  {
 Pig myPig = new Pig();  // Create a Pig object
    myPig.animalSound();
  }}
  ```

# Question: Explain the concept of thread in C#.
Answer: A thread can be defined as the execution flow of any program and defines a unique flow of control. You can manage these threads' execution time so that their execution does not overlap the execution of other threads and prevent deadlock or to maintain efficient usage of resources. Threads are lightweight programs that save the CPU consumption and increase the efficiency of the application. The thread cycle starts with the creation of the object of system.threading.thread class and ends when the thread terminates.

System.threading.thread class allows you to handle multiple threads and the first thread always runs in a process called the main thread. Whenever you run a program in C#, the main thread runs automatically.





# Question: C# program to remove an element from the queue.
Answer:
```
using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Application
{
 class DemoProgram
 {
  static void Main(string[] args)
  {
   Queue qs = new Queue();
   qs.Enqueue(1);
   qs.Enqueue(2);
   qs.Enqueue(3);
   foreach (Object ob in qs)
   {
    Console.WriteLine(ob);
   }
    Console.WriteLine(); Console.WriteLine();
    Console.WriteLine("Total number of elements in the Queue " + qs.Count);
    Console.WriteLine("Does the Queue contain " + qs.Contains(3));
    Console.ReadKey();
   }
 }
}
```

# Question: How to find if a number is a palindrome or not in C#.
Answer:

```
using System;  
  public class PalindromeNum  
   {  
     public static void Main(string[] args)  
      {  
          int n,r,num=0,Dem;    
          Console.Write("Enter the Number: ");   
          n = int.Parse(Console.ReadLine());  
          dem=n;      
          while(n>0)      
          {      
           r=n%10;      
           num=(num*10)+r;      
           n=n/10;      
          }      
          if(dem==num)      
           Console.Write("Number is Palindrome.");      
          else      
           Console.Write("Number is not Palindrome");     
    }  
  }  
  ```



# Question: Compare Virtual methods and Abstract methods.
Answer: Any Virtual method must have a default implementation, and it can be overridden in the derived class using the override keyword. On the contrary, an Abstract method doesn’t have an implementation, and it resides in the abstract class. The derived class must implement the abstract method. Though not necessary, we can use an override keyword here.



# Question: What are I/O classes in C#? Define some of the most commonly used ones.
Answer: The System.IO namespace in C# consists of several classes used for performing various file operations, such as creation, deletion, closing, and opening. Some of the most frequently used I/O classes in C# are:
```
File – Manipulates a file
Path – Performs operations related to some path information
StreamReader – Reads characters from a stream
StreamWriter – Writes characters to a stream
StringReader – Reads a string buffer
StringWriter – Writes a string buffer
Question: What do you understand by regular expressions in C#? Write a program that searches a string using regular expressions.
Answer: Regular expression is a template for matching a set of input. It can consist of constructs, character literals, and operators. Regex is used for string parsing, as well as replacing the character string. Following code searches a string “C#” against the set of inputs from the languages array using Regex:

static void Main(strong[] args)
{
string[] languages = {“C#”, “Python”, “Java”};
foreach(string s in languages)
{
if(System.Text.RegularExpressions.Regex.IsMatch(s,“C#”))
{
Console.WriteLine(“Match found”);
}
}
}
```

# Question: Explain Reflection in C#.
Answer: The ability of code to access the metadata of the assembly during runtime is called Reflection. A program reflects upon itself and uses the metadata to:

Inform the user, or
Modify the behaviour
The system contains all classes and methods that manage the information of all the loaded types and methods. Reflection namespace. Implementation of reflection is in 2 steps:

Get the type of the object, then
Use the type to identify members, such as properties and methods
Question: Name some of the most common places to look for a Deadlock in C#.
Answer: For recognizing deadlocks, one should look for threads that get stuck on one of the following:

.Result, .GetAwaiter().GetResult(), WaitAll(), and WaitAny() (When working with Tasks)
Dispatcher.Invoke() (When working in WPF)
Join() (When working with Threads)
lock statements (In all cases)
WaitOne() methods (When working with AutoResetEvent/EventWaitHandle/Mutex/Semaphore)
Question: Define Serialization and its various types in C#.
Answer: The process of converting some code into its binary format is known as Serialization in C#. Doing so allows the code to be stored easily and written to a disk or some other storage device. We use Serialization when there is a strict need for not losing the original form of the code. A class marked with the attribute [Serializable] gets converted to its binary form. A stream that contains the serialized object and the System.Runtime.Serialization namespace can have classes for serialization. Serialization in C# is of three types:

Binary Serialization – Faster and demands less space; it converts any code into its binary form. Serialize and restore public and non-public properties.
SOAP – It produces a complete SOAP compliant envelope that is usable by any system capable of understanding SOAP. The classes about this type of serialization reside in System.Runtime.Serialization.
XML Serialization – Serializes all the public properties to the XML document. In addition to being easy to read, the XML document manipulated in several formats. The classes in this type of serialization reside in System.sml.Serialization.
Note: Retrieving the C# code back from the binary form is known as Deserialization.

# Question: Give a brief explanation of Thread Pooling in C#.
Answer: A collection of threads, termed as a Thread Pool in C#. Such threads are for performing tasks without disturbing the execution of the primary thread. After a thread belonging to a thread pool completes execution, it returns to the thread pool. Classes that manage the thread in the thread pool, and its operations, are contained in the System.Threading.ThreadPool namespace.

# Question: Is it possible to use this keyword within a static method in C#?
Answer: A special type of reference variable, this keyword is implicitly defined with each non-static method and constructor as the first parameter of the type class, which defines it. Static methods don’t belong to a particular instance. Instead, they exist without creating an instance of the class and calls with the name of the class. Because this keyword returns a reference to the current instance of the class containing it, it can’t be used in a static method. Although we can’t use this keyword within a static method, we can use it in the function parameters of Extension Methods.

# Question: What can you tell us about the XSD file in C#?
Answer: XSD denotes XML Schema Definition. The XML file can have any attributes, elements, and tags if there is no XSD file associated with it. The XSD file gives a structure for the XML file, meaning that it determines what, and also the order of, the elements and properties that should be there in the XML file. Note: - During serialization of C# code, the classes are converted to XSD compliant format by the Xsd.exe tool.

# Question: What do you mean by Constructor Chaining in C#?
Answer: Constructor chaining in C# is a way of connecting two or more classes in a relationship as an inheritance. Every child class constructor is mapped to the parent class constructor implicitly by using the base keyword in constructor chaining.

# Question: Explain different states of a Thread in C#?
Answer: A thread in C# can have any of the following states:

```
Aborted – The thread is dead but not stopped
Running – The thread is executing
Stopped – The thread has stopped execution
Suspended – The thread has been suspended
Unstarted – The thread is created but has not started execution yet
WaitSleepJoin – The thread calls sleep, calls wait on another object, and calls join on some other thread
Question: Why do we use Async and Await in C#?
Answer: Processes belonging to asynchronous programming run independently of the main or other processes. In C#, using Async and Await keywords for creating asynchronous methods.
```



# Question: What is the Race condition in C#?
Answer: When two threads access the same resource and try to change it at the same time, we have a race condition. It is almost impossible to predict which thread succeeds in accessing the resource first. When two threads try to write a value to the same resource, the last value written is saved.



# Question: Give a detailed explanation of the differences between ref and out keywords.
Answer: In any C# function, there can be three types of parameters, namely in, out and ref. Although both out and ref are treated differently at the run time, they receive the same treatment during the compile time. It is not possible to pass properties as an out or ref parameter. Following are the differences between ref and out keywords:

Initializing the Argument or Parameter – While it is not compulsory to initialize an argument or parameter before passing to an out parameter, the same needs to be initialized before passing it to the ref parameter.
Initializing the Value of the Parameter – Using ref doesn’t necessitate for assigning or initializing the value of a parameter before returning to the calling method. When using out, however, it is mandatory to use a called method for assigning or initializing a value of a parameter before returning to the calling method.
Usefulness – When the called method requires modifying the passed parameter, passing a parameter value by Ref is useful. Declaring a parameter to an out method is appropriate when multiple values are required to be returned from a function or method.
Initializing a Parameter Value in Calling Method – It is a compulsion to initialize a parameter value within the calling method while using out. However, the same is optional while using the ref parameter.
Data Passing – Using out allows for passing data only in a unidirectional way. However, data can be passed in a bidirectional manner when using ref.

