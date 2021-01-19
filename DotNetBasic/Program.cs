using System;
using System.Collections.Generic;

namespace DotNetBasic
{

    public class MyClass
    {

        /*
         * Class variables − Class variables also known as static variables are declared with the static keyword in a class, -
         * but outside a method, constructor or a block. There would only be one copy of each class variable per class,
         * regardless of how many objects are created from it.
         */
        public static int _myStaticVariable;       //Class variable,  static variable  


        /*
         * Instance variables − Instance variables are declared in a class, but outside a method. When space is allocated for an -
         * object in the heap, a slot for each instance variable value is created. Instance variables hold values that must be 
         * referenced by more than one method, constructor or block, or essential parts of an object's state that must be present 
         * throughout the class.
         */
        public int _myInstanceVariable;            //Instance variable...


        public void MyMethod()
        {
            //int myLocalVariable;           // LocalVariable
            //myLocalVariable++;          //Compile Error: local variables cant use before initialize


            _myInstanceVariable++;         //Instance variable can use before initialize
            _myStaticVariable++;

            Console.WriteLine($"MyInstance variable = {_myInstanceVariable}");
            Console.WriteLine($"MyClass variable = {MyClass._myStaticVariable}");
        }
    }




    class Program
    {
        static void Main(string[] args)
        {

            //-----------------------------Arrays-------------------------------         
            //int[] myArray = new int[3];  //define array 

            /*
            var myArray = new double[3];   //define array
            myArray[0] = 20.7;
            myArray[1] = 45.8;
            myArray[2] = 33.2;
            */

            //var myArray = new double[] { 20.7, 45.8, 33.2 };   //array define & initialize

            /*
            var result = myArray[0];
            result += myArray[1];
            result += myArray[2];
            */


            /*
            var result = 0.0;
            foreach (var number in myArray)
            {
                result += number;
            }
            Console.WriteLine($" Sum : {result}");
            */
            //---------------------------------------------------------------------         



            //---------------------------------List------------------------------- 
            var gradeList = new List<double>();
            gradeList.Add(20.7);
            gradeList.Add(45.8);
            gradeList.Add(33.2);

            var result = 0.0;
            foreach (var number in gradeList)
            {
                result += number;
            }

            //var avgOfGrades= result/ gradeList.Count;    //avarage ... same both line
            result /= gradeList.Count;                     //avarage ... same both line

            //format number
            //result:N1  -------format number with 1 decimal point
            //result:N3  -------format number with 3 decimal point

            Console.WriteLine($"The average of grade is : {result:N2}");
            Console.ReadKey();
        }
    }




}
