// brings in fundamental classes like console, references data types and event handlers 
// the keyword using is a directive 
using System;


class Hello
{
    // static in C# means something that cannot be instantiated
    // the compiler can call the Main method without the Hello class object being created
    // same as java
    static void Main(){
        // Console is the standard I/O and error streams for console apps
        Console.WriteLine("Hello, World");
    }
}