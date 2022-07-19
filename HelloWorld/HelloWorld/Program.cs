using System;

namespace HelloWorld
{
    internal class Program
    {

        public int FindMax(int a, int b)
        {
            return a > b ? a : b;
        }
        static void Main(string[] args)
        {

            //simply printing Hello World!

            Console.WriteLine("Hello World!");
            /* Defining Variable
                 <data_type> <variable_list>;
             */
            int five = 5;
            double pi = 3.1415926;
            Console.WriteLine("int = {0} and double = {1}", five, pi);

            //Console.ReadLine() accepts the data in string format.
            Console.WriteLine("-----------------ReadLine-------------------------");
            int n;
            n = Convert.ToInt32(Console.ReadLine());

            /*There are two kinds of expressions in C# −

            lvalue − An expression that is an lvalue may appear as either the left-hand or right-hand side of an assignment.

            rvalue − An expression that is an rvalue may appear on the right- but not left-hand side of an assignment.

            Variables are lvalues and hence they may appear on the left-hand side of an assignment. Numeric literals are rvalues and hence they may not be assigned and can not appear on the left-hand side. Following is a valid C# statement −

            int g = 20;
            But following is not a valid statement and would generate compile-time error −

            10 = 20;

            */

            /*The constants are treated just like regular variables except that their values cannot be modified after their definition.
               Defining Constants
            const <data_type> <constant_name> = value;
            */

            const double e = 2.718281828459045;

            //Operators ~ means ones compliment
            Console.WriteLine("-----------------Ones Compliment-------------------------");
            int A = 0b111100;
            Console.WriteLine("A = {0}", A);
            A = ~A;
            Console.WriteLine("~A = {0}", A);

            //Conditional Logic
            //if ... else if ... else
            Console.WriteLine("-----------------Conditional logic-------------------------");
            Console.WriteLine("-----------------if else-------------------------");
            if (n == 0)
            {
                Console.WriteLine("Given number is 0");
            }
            else if (n > 0)
            {
                Console.WriteLine("Given number is Positive");
            }
            else
            {
                Console.WriteLine("Given number is Negative");
            }
            // Switch
            Console.WriteLine("-----------------Switch-------------------------");

            switch (n)
            {
                case 0:
                    Console.WriteLine("Given number is 0");
                    break;
                case > 0:
                    Console.WriteLine("Given number is Positive");
                    break;
                default:
                    Console.WriteLine("Given number is Negative");
                    break;
            }
            //variable = (condition) ? expressionTrue :  expressionFalse;
            Console.WriteLine("-----------------In line-------------------------");
            string dis;
            dis = (n % 2 == 0) ? "Even." : "0dd.";
            Console.WriteLine(dis);

            /*While Loop
              while(condition) {
                    statement(s);
              }
            */
            Console.WriteLine("-----------------Loop-------------------------");
            Console.WriteLine("-----------------While-------------------------");
            int itr = 5;
            while (itr > 0)
            {
                Console.WriteLine(itr);
                itr--;
            }
            /*For Loop
             for ( init; condition; increment ) {
                    statement(s);
             }
            */
            Console.WriteLine("-----------------for-------------------------");
            for (itr = 0; itr < 5; itr++)
            {
                Console.WriteLine(itr);
            }
            Console.WriteLine("-----------------Array-------------------------");
            // datatype[] arrayName = new datatype[length];
            int[] arr = new int[5];
            for (int i = 0; i < 5; i++)
            {
                arr[i] = i;
            }
            foreach (int j in arr)
            {
                Console.WriteLine(arr[j]);
            }
            Console.WriteLine("-----------------Method-------------------------");
            /*
              <Access Specifier> <Return Type> <Method Name>(Parameter List) {
                            Method Body
              }
            */
            int a = 5;
            int b = 10;
            //making instance of this class to access
            Program res = new Program();
            Console.WriteLine(res.FindMax(a, b));
            Console.WriteLine("-----------------String-------------------------");

            /*You can create string object using one of the following methods −

            By assigning a string literal to a String variable

            By using a String class constructor

            By using the string concatenation operator (+)

            By retrieving a property or calling a method that returns a string

            By calling a formatting method to convert a value or an object to its string representation.
            */
 
            string[] fullname = new string[2];
            fullname[0] = "Shahadat";
            fullname[1] = "Nirob";
            Console.WriteLine(fullname[0]+" " + fullname[1]);

            string name = new string(fullname[0]);
            Console.WriteLine(name);

        }
    }
}
