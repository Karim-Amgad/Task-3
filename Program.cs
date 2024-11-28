using System;
using System.Globalization;
using System.Text;
namespace Task_3
{
    internal class Program
    {
        public static void Main(string[] args)
        {
            #region Problem-1

            //Console.WriteLine("Please enter the string");
            //String IntegerInput = Console.ReadLine();

            //int res1 = int.Parse(IntegerInput);
            //Console.WriteLine("The result is " + res1);

            //int res2 = Convert.ToInt32(IntegerInput);
            //Console.WriteLine("The result is " + res2);

            //bool z = int.TryParse(IntegerInput, out int res3);
            //Console.WriteLine("The result is " + res3);

            #endregion

            #region Question-1
            // intParse makes a format exception
            // Convert.ToInt32 will return zero
            #endregion

            #region Problem-2

            //Console.WriteLine("Please enter an integer");
            //String input =Console.ReadLine();
            //bool m = int.TryParse(input, out int result);
            //Console.WriteLine(m ? $"The integer is {result}" : "error");

            #endregion

            #region Question-2
            // because it tries first the input from the user. If it can be parsed, it parses it and returns the value
            // if it can't be parsed, it returns zero
            // in case of normal parse. If the input can't be parsed, it will make an exception in fface of customer and that isn't favored.
            // so we make a defensive code to solve this problem
            #endregion

            #region Problem-3

            //Object O1;
            //O1 = 33;
            //Console.WriteLine(O1.GetHashCode());
            //O1 = 76;
            //Console.WriteLine(O1.GetHashCode());
            //O1 = 'B';
            //Console.WriteLine(O1.GetHashCode());
            //O1 = 423.5335;
            //Console.WriteLine(O1.GetHashCode());
            //O1 = "KJNSBJKFDJD";
            //Console.WriteLine(O1.GetHashCode());
            //O1 = true;
            //Console.WriteLine(O1.GetHashCode());
            //O1 = false;
            //Console.WriteLine(O1.GetHashCode());
            //O1 = 1;
            //Console.WriteLine(O1.GetHashCode());
            //O1 = 0;
            //Console.WriteLine(O1.GetHashCode());

            // in case of int object, The HashCode is the same as the number.
            // in case of bool object, The HashCode if 0 for false, 1 for true.
            // any other type, it has another way to do so
            #endregion

            #region Question-3
            /*
             
             It's important for data restorage as it locates the item which increases the speed to reach it and to deal with it
             Also it helps to determine if the 2 items are equal or not if they point to the same address, they are equal
             Its value is never changed as long as it's used

            */
            #endregion

            #region Problem-4

            //Object m = "Ali";
            //Object n;
            //n = m;
            //m = "Alaa";
            //Console.WriteLine(n);

            // as from the result, we see that after the second object was assigned to the first one, any change will happen to first won't affect
            // the second.
            #endregion

            #region Question-4
            /*
             it shows if 2 variables are referring to the same location or not, not the same data content inside.
             the same data inside doesn't matter here. what matters is if they are pointing to the same location or not.
             it's has better performance than normal equality, as in this we check only the location not the whole content.
             it helps in garbage collection: if no object is refered, the GC can remove it, but as long as there is one or more refering to an object, it can't be removed
             
             */
            #endregion

            #region Problem-5

            //String T;
            //T = new String("Good Morning Class");
            //Console.WriteLine(T.GetHashCode());
            //Console.WriteLine(T);
            //T += ", Hi Willy";
            //Console.WriteLine(T.GetHashCode());
            //Console.WriteLine(T);

            #endregion

            #region Question-5
            // Because it's a fixed-volume internal array of characters taht can't be modified.
            // If anyone tries to edit it, it will create a new one and the previous one if it was'nt refered by any other string, it will bwe unreachable
            #endregion

            #region Problem-6

            //StringBuilder M1;
            //M1 = new StringBuilder("Good Morning Class ");
            //Console.WriteLine(M1);
            //Console.WriteLine(M1.GetHashCode());
            //M1.Append(",Hi Willy");
            //Console.WriteLine(M1);
            //Console.WriteLine(M1.GetHashCode());

            #endregion

            #region Question-6

            // As it mutable, we can edit any value in it without creating new strings that will fill the memory
            // It can hold whatever size of data you enter.
            // It helps us to get rid of concatination as we can edit the data inside it and show it at once in the end.

            #endregion

            #region Question-7

            /*
             It's prefered for many reasons:
             1- it helps us to get rid of concatination.
             2- its value can be altered which is opposite to String which would have created a new string and the first will turn into unreachable variable.
             3- if its capacity is full, it will use a resize factor and expand its capacity.
             4- The continous process of creating and garbage-collecting strings can lead to memory fragmentation, which is avoided here.
             5- The garbage collector overhead is less as we don't have an unreachable variable.
            */


            #endregion

            #region Problem-8

            //Console.WriteLine("Please enter the first number");
            //String Input1 = Console.ReadLine() ;
            //Console.WriteLine("Please enter the second number");
            //String Input2 = Console.ReadLine();


            //int Num1 = int.Parse(Input1);
            //int Num2 = int.Parse(Input2);

            //String Message = ("The sum is " + (Num1 + Num2));
            //Console.WriteLine(Message);

            //String Message1= String.Format("The sum is {0}",(Num1 + Num2));
            //Console.WriteLine(Message1);

            //String Message2 = $"The sum is {Num1 + Num2}";
            //Console.WriteLine(Message2);

            #endregion

            #region Question-8

            // The string interpolarity is the most used.
            // Because it has many advantahes like:
            // 1- It makes The code easier to read
            // 2- It gets rid of placeholders by putting the value of variable directly
            // 3- We don't need to use indexies here as we bring from any place in the class and no order is requored.
            // 4- It's the fastest performance among others


            #endregion

            #region Problem-9

            StringBuilder sb = new StringBuilder("Hi ");
            Console.WriteLine(sb);
            sb.Append("Everyone");
            Console.WriteLine(sb);
            sb.Replace("Everyone", "Everybody ");
            Console.WriteLine(sb);
            sb.Insert(3, "Good Morning, ");
            Console.WriteLine(sb);
            sb.Remove(3, 14);
            Console.WriteLine(sb);
            #endregion

            #region Question-9

            /*It is like a mutable String that can modify its volume to contain all the modifications that happen
             * It is internalyy like a LinkedList that can hold the existing value
             * We can delete from it, insert in it, replace somethings in it, add to it without creating any new objects
             * If it reached its maximum valye, it doubles it capacity dynamically to have more characters, which reduces need for reallocations
             *  operates in-place so it avoides creating new objects.
             *  
             */

            #endregion


        }
    }
}
