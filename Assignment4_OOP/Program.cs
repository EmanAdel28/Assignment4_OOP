using System;
using System.Data;
using System.Net;
using System.Runtime.Intrinsics.X86;
using System.Threading.Channels;
using Assignment4_OOP.Q2;
using Assignment4_OOP.Q3;
//using static System.Net.Mime.MediaTypeNames;

namespace Assignment4_OOP
{
    internal class Program
    {
        static void Main(string[] args)
        {
            #region Part1
            #region Q1
            //Question 1:
            //What is the primary purpose of an interface in C#?
            //a) To provide a way to implement multiple inheritance
            //b) To define a blueprint for a class
            //c) To declare abstract methods and properties
            //d) To create instances of objects

            //Solution => b) To define a blueprint for a class
            #endregion

            #region Q2
            //Question 2:
            //Which of the following is NOT a valid access modifier for interface members in C#?
            //a) private
            //b) protected
            //c) internal
            //d) public


            //Solution => a) private  b) protected  c) internal
            #endregion

            #region Q3
            //Question 3:
            //Can an interface contain fields in C#?
            //a) Yes
            //b) No
            //c) Only if they are static
            //d)  Only if they are read only


            //Solution => b) No
            #endregion

            #region Q4
            //Question 4:
            //In C#, can an interface inherit from another interface?
            //a) No, interfaces cannot inherit from each other
            //b) Yes, interfaces can inherit from multiple interfaces
            //c) Yes, but only if they have the same methods
            //d) Only if the interfaces are in the same namespace


            //Solution => b) Yes, interfaces can inherit from multiple interfaces
            #endregion

            #region Q5
            //Question 5:
            //Which keyword is used to implement an interface in a class in C#?
            //a) inherit
            //b) use
            //c) extends
            //d) implements



            //Solution =>   i userd : to implement an interface in a class in c#  thats called =>  implementation 
            #endregion

            #region Q6
            //Question 6:
            //Can an interface contain static methods in C#?
            //a) Yes
            //b) No
            //c) Only if the interface is sealed
            //d) Only if the methods are private




            //Solution => a) Yes
            #endregion

            #region Q7
            //Question 7:
            //In C#, can an interface have explicit access modifiers for its members?
            //a) Yes, for all members
            //b) No, all members are implicitly public
            //c) Yes, but only for abstract members
            //d) Only if the interface is sealed



            //Solution => b) No, all members are implicitly public
            #endregion

            #region Q8
            //Question 8:
            //What is the purpose of an explicit interface implementation in C#?
            //a) To hide the interface members from outside access
            //b) To provide a clear separation between interface and class members
            //c) To allow multiple classes to implement the same interface
            //d) To speed up method resolution




            //Solution => b) To provide a clear separation between interface and class members


            #endregion


            #region Q9
            //Question 9:
            //In C#, can an interface have a constructor?
            //a) Yes, but it must be private
            //b) No, interfaces cannot have constructors
            //c) Yes, but only if the interface is sealed
            //d) Only if the constructor is static




            //Solution => d) Only if the constructor is static
            #endregion
            #endregion



        }
    }
}

