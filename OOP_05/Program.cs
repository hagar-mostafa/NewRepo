using System;
#nullable disable 
public class Program
{
 static void Main()
    {
        #region Theortical Question Q1
        /*
         Q1 Object Copying
 a) What happens when you assign one object variable to another object variable?
        Both variables point to the same object in memory — no new object is created.

 b) Does assigning one object to another create a new object? Explain.
        No , Only the reference (address) is copied, not the object itself.

 c) What is the difference between copying an object and copying its reference?
        Copying a reference : two variables, one object 
       Copying an object : two variables, two independent objects
         */
        #endregion

        #region Theortical Question Q2
        /*
       Q2 Shallow Copy vs Deep Copy
a) What is a Shallow Copy?
        copies the object, but reference type fields still point to the same nested objects. (not effective for deep copying)
b) What is a Deep Copy?
        copies the object and all nested objects recursively fully independent.

c) What happens to reference-type members when a Shallow Copy is created?
        reference-type members are shared between the original and the copy.

d) What happens to reference-type members when a Deep Copy is created?
        Deep copy: reference-type members are duplicated — each object has its own copy.

e) Give one situation where Deep Copy would be safer than Shallow Copy
        When you have a list/array inside an object (i mean u have a reference type)
         */
        #endregion

        #region Theortical Question Q3
        /*
     Q3 Static Members
a) What is a static field, and how is it different from an instance field?
        A static field belongs to the class, shared by all instances. An instance field belongs to each object separately.

b) What is a static method? Can a static method directly access instance members?
        A static method belongs to the class, not an object. It cannot directly access instance members (needs an object reference to do so).
c) What is a static constructor, and when is it executed?
d) What is a static class? Can you create an object from a static class?
         */
        #endregion

        #region Theortical Question Q4
        /*
    Q4 Extension Methods
a) What is an Extension Method?
        A method added to an existing class without modifying its source code or inheriting from it.

b) What keyword must be used in the first parameter of an extension method?
        this keyword — placed before the type in the first parameter.

c) Where must an extension method be declared?
        Inside a static class, in a static method

d) Can an extension method access private members of the class it extends?
        No. It can only access public members — it's not part of the original class.

         */
        #endregion



    }
}
