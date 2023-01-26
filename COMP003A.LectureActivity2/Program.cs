/*
  * Author: Vanessa Garcia
  * Course: COMP-003A
  * Purpose: Lecture activity for variables, type system, Math, and Console properties
  * Reference: The C# Player's Guide (4e) by RB Whitaker
*/






using Microsoft.VisualBasic;
using static System.Formats.Asn1.AsnWriter;
using System.Diagnostics.Metrics;
using System.Runtime.Intrinsics.X86;

namespace COMP003A.LectureActivity2
{
    internal class Program
    {
        static void Main(string[] args)
        {



            /* working with variables */
              // the following code shows all three primary variable-related activities:
   string username; // declaring a variable (1 of 3)
              Console.WriteLine("What is your name?"); // request for user input
              username = Console.ReadLine(); // assigning a value to a variable (2 of 3)
             Console.WriteLine("Hi " + username); // retrieving its current value (3 of 3)
            
     // another example of the three primary variable related activities 
    (declaring, assigning, and retrieving)
       string favoriteColor;
               Console.WriteLine("What is your favorite color?");
               favoriteColor = Console.ReadLine();
               Console.WriteLine("Your favorite color is " + favoriteColor);
            

  /* working with variable integers */
 int score; // declare a new variable with a data type int
            31   // score = "Generic User"; // will fail to compile because you are assigning 
a string value to an integer variable
   // score = "0"; // will still fail to compile because the "0" is still 
assigned as a string -enclosed in the double quotes
   score = 0; // works
            34   score = 4; // you can also reassign values to the variable as long as they 
            are within scope and not constant
  score = 11;
               score = -1564;
            

  /* reading from a variable does not change it */
   int a;
               int b;
            
   a = 5;
               b = 2;
               Console.WriteLine("The current value of a: " + a);
               Console.WriteLine("The current value of b: " + b);
            
   b = a;
              a = -3;
               Console.WriteLine("The new value of a: " + a);
               Console.WriteLine("The new value of b: " + b);
            
   /* variables are case-sensitive */
   // the variables below are different despite having similar names
  string exampleVariable;
               string exampleVAriable;
               string exampleVARiable;
            
   Console.WriteLine("**************************************************");
               /*
                * types of variables and values matter in C#. they are not interchangeable.
                * there are eight integer types for storing integers of differing sizes and 
ranges: int, short, long, byte, sbyte, uint, ushort, and ulong.
                * the char type stores single characters.
               * the string type stores longer text.
                * there are three types for storing real numbers: float, double, and 
decimal.
                * the bool type stores truth values (true and false) used in logic.
                * these types are the building blocks of a much larger type system.
                * using var for a variable’s type tells the compiler to infer its type from 
the surrounding code, so you do not have to type it out. (But it still has 
a specific type.)
6                * the System.Convert class is a useful class to convert from one type to 
another.
70               */

   /* declaring and using variables with integer types */
   byte aSingleByte = 34;
               Console.WriteLine("aSingleByte: " + aSingleByte);
               aSingleByte = 17;
               Console.WriteLine("aSingleByte: " + aSingleByte);
            
   short aNumber = 5039;
              Console.WriteLine("aNumber: " + aNumber);
               aNumber = -4354;
               Console.WriteLine("aNumber: " + aNumber);
            
   long aVeryBigNumber = 395904282569;
              Console.WriteLine("aVeryBigNumber: " + aVeryBigNumber);
              aVeryBigNumber = 13;
              Console.WriteLine("aVeryBigNumber: " + aVeryBigNumber);
           
   int anInteger = 2147483647;
        
   /* declaring,using, and concatenating characters ans strings */
  char aLetter = 'A'; // character values are enclosed in single quotes
               string message = "Hello World!"; // string values are enclosed in double 
            quotes

   Console.WriteLine("Concatenation using + : " + aLetter + " " + message); // 
            use the plus(+) sign in between characters/ strings to concatenate
   Console.WriteLine($"Concatenation using string interpolation : {aLetter} 
{ message}
            "); // use string interpolation with a dollar-sign ($) before the 
opening double-quote and enclosing variables with curly braces
({ variableName})

  /* floating-point types */
   double number1 = 3.5623;
               float number2 = 3.5623f;
              decimal number3 = 3.5623m;
               Console.WriteLine($"Value of number1: {number1}");
               Console.WriteLine($"Value of number2: {number2}");
              Console.WriteLine($"Value of number3: {number3}");
          
  /* scientific notation */
  double avogadrosNumber = 6.022e23;
            107   Console.WriteLine($"Value of avogadrosNumber: {avogadrosNumber}");
            108
109   /* bool type */
110   bool itWorked = true;
            111   Console.WriteLine($"Value of itWorked: {itWorked}");
            112   itWorked = false;
            113   Console.WriteLine($"New value of itWorked: {itWorked}");
            114
115   /* convert */
116   string inputAgeString;
            117   int inputAge;
            118   int currentYear = 2023;
            119
120   Console.WriteLine($"Enter age in {currentYear}: ");
            121   inputAgeString = Console.ReadLine();
            122   inputAge = Convert.ToInt32(inputAgeString);
            123   Console.WriteLine($"Your age is {inputAge}");
            124
125   Console.WriteLine("**************************************************");
            126   /* 
127                * math operations 
128                * addition: +
129                * subtraction: -
130                * multiplication: *
131                * division: /
132                * modulo: % (remainder)
133                */
134   int addition = 2 + 3;
            135   int subtraction = 5 - 2;
            136   int multiplication = 22 * 2;
            137   int division = 21 / 7;
            138   int modulo = 77 % 5;
            139   Console.WriteLine($"Value of addition: {addition}");
            140   Console.WriteLine($"Value of subtraction: {subtraction}");
            141   Console.WriteLine($"Value of multiplication: {multiplication}");
            142   Console.WriteLine($"Value of division: {division}");
            143   Console.WriteLine($"Value of modulo: {modulo}");
            144
145   /* 
146                * arithmetic, compound expressions and order of operations 
147                * Multiplication and division are done first, left to right
148                * Addition and subtraction are done last, left to right
149                * Reference: https://csharpplayersguide.com/articles/operators-table
150                */
151
152   int arithmetic1; // declaring the variable arithmetic1.
            153   arithmetic1 = 9 - 2; // assigning a value to arithmetic1, using some math.
            154   Console.WriteLine($"Value of arithmetic1: {arithmetic1}");
            155   arithmetic1 = 3 + 3; // another assignment.
            156   Console.WriteLine($"New value of arithmetic1: {arithmetic1}");
            157   int arithmetic2 = 3 + 1; // declaring arithmetic2 and assigning a value to 
            arithmetic2 all at once.
158   Console.WriteLine($"Value of arithmetic2: {arithmetic2}");
            159   arithmetic2 = 1 + 2; // assigning a second value to arithmetic2.
            160   Console.WriteLine($"New value of arithmetic2: {arithmetic2}");
            161
162   // use multiple sets of parentheses to group operations
163   int result = ((2 + 1) * 8 - (3 * 2) * 2) / 4;
            164   Console.WriteLine($"Value of result: {result}");
            165
166   /* compound assignment operator */
167   int compoundAssignmentOperator = 0;
            168   compoundAssignmentOperator += 5; // The equivalent of 
            compoundAssignmentOperator = compoundAssignmentOperator + 5; (a is 5 after
this line runs.)
169   compoundAssignmentOperator -= 2; // The equivalent of 
            compoundAssignmentOperator = compoundAssignmentOperator – 2; (a is 3 after
this line runs.)
170   compoundAssignmentOperator *= 4; // The equivalent of 
            compoundAssignmentOperator = compoundAssignmentOperator * 4; (a is 12 after
this line runs.)
171   compoundAssignmentOperator /= 2; // The equivalent of 
            compoundAssignmentOperator = compoundAssignmentOperator / 2; (a is 6 after
this line runs.)
172   compoundAssignmentOperator %= 2; // The equivalent of 
            compoundAssignmentOperator = compoundAssignmentOperator % 2; (a is 0 after
this line runs.)







        }
    }
}