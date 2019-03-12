using System;

namespace Assignment1_S19
{
    class Program
    {
        public static void Main()
        {
            int a = 5, b = 25;
            printPrimeNumbers(a, b);

            int n1 = 5;
            double r1 = getSeriesResult(n1);
            Console.WriteLine("\nThe sum of the series is: " + r1);


            int n4 = 5;
            printTriangle(n4);

            int[] arr = new int[] { 1, 2, 3, 2, 2, 1, 3, 2 };
            computeFrequency(arr);

            // write your self-reflection here as a comment

            /* learning
            * learned how to integrate methods prototypes and make it compilable with a given program with a sample input
            * learned how to handle exceptions that can happen due changing from differnet types of variables to the otherss
            * learned type casting where i needed to chnage an integer to double for divion
            * learned that dividing integer on a double type that will return an integer
            * refreshed my memory on logical loops and logical thinking for development challenges which is different than purly developing APIs
              */

            /* Recommendations 
            * I would like to see more coding that is related to more data structures on top of these methods that way it would prepare students for using data strutures and basics of OOP in building effecient web applications and APIs
            */

            /* Time Taken  
            * 3 hours
            */

        }

        public static void printPrimeNumbers(int x, int y)
        {
            try
            {
                Console.WriteLine("Prime Numbers : ");

                // looping throught the given inputs limit and checking on every item between them including the given numbers for being prime
                for (int i = x; i <= y; i++)
                {
                    // calling a boolean function that checks if a number is prime
                    if (isPrime(i))
                    {
                        // if the number is prime print it to console
                        Console.Write("\t" + i);
                    }
                }
                Console.Write("\n");
            }
            catch
            {
                Console.WriteLine("Exception occured while computing printPrimeNumbers()");
            }
        }

        // boolean function to check if number is prime
        public static bool isPrime(int number)
        {
            // checking the base cases for being prime
            if (number <= 1) return false;
            if (number == 2) return true;
            if (number % 2 == 0) return false;

            // calculating the floor boundary of the number by calculating the square root of it and taking the lower boundary of that sqrt
            var boundary = (int)Math.Floor(Math.Sqrt(number));

            // looping between 3 ( the number after basic checks ) and the calculated boundary to check if number is prime by dividing the number over numbers in the loop
            for (int i = 3; i <= boundary; i += 2)
            {
                // check if there is no remaining in division which means number is not prime
                if (number % i == 0)
                {
                    return false;
                }
            }

            return true;
        }

        public static double getSeriesResult(int n)
        {
            try
            {
                // declaring needed varaibles for calculation
                double sum = 0.0;
                double equation;
                int i;

                // looping through given nunber of terms in series up to the given number
                for (i = 1; i <= n; i++)
                {
                    // calculating and casting the facorial of i divided by i+1
                    equation = (double)factorial(i) / (i + 1);

                    // checking if i is even ==> Odd terms are all positive whereas even terms are all negative
                    if (i % 2 == 0)
                    {
                        equation *= -1;
                    }

                    // adding series equation value to the overall sum
                    sum += equation;
                }

                // Round off the results to three decimal places. 
                return Math.Round(sum, 3);
            }
            catch
            {
                Console.WriteLine("Exception occured while computing getSeriesResult()");
                return 0;
            }

        }

        // function to calculate the facorial of a number and return that value
        public static int factorial(int x)
        {
            int res = 1;
            // looping and decreasing the number to be calculated in factorial
            while (x != 1)
            {
                res = res * x;
                x = x - 1;
            }

            // return the facorial of the number
            return res;
        }

        public static void printTriangle(int n)
        {
            try
            {
                // check if the given value is greater than 0 to print a minumum of 1 star *
                if (n > 0)
                {
                    // declaring needed variables
                    int i, j;

                    // loopnig till the given number to print needed start on each iteration
                    for (i = 0; i <= n; i++)
                    {
                        // nested loop to print empty space
                        for (j = 1; j <= n - i; j++)
                            Console.Write(" ");
                        // nested loop to print the stars
                        for (j = 1; j <= 2 * i - 1; j++)
                            Console.Write("*");

                        // \n is used to go to new line
                        Console.Write("\n");
                    }

                }
                else
                {
                    // printing off validation check if number is less than 1
                    Console.Write(" The number used cannot be less than 1");
                }
            }
            catch
            {
                Console.WriteLine("Exception occured while computing printTriangle()");
            }
        }

        public static void computeFrequency(int[] a)
        {
            try
            {
                // checking for array length to avoid calculations on empty array 
                if (a.Length > 0)
                {
                    Console.Write("\nNumber Frequency \n");

                    // creating an array to store frequencies of numbers in the given array
                    int[] frequency = new int[a.Length];

                    // initializing the frequency array with -1 value 
                    for (int i = 0; i < a.Length; i++)
                    {
                        frequency[i] = -1;
                    }

                    // main loop to go over items in the given array
                    for (int i = 0; i < a.Length; i++)
                    {
                        // assigning a minimm count of 1 to a given number in the array
                        int count = 1;

                        // comparing the number with the rest of the number in the array
                        for (int j = i + 1; j < a.Length; j++)
                        {
                            // checking if number equals other numbers in the array
                            if (a[i] == a[j])
                            {
                                // incresing the count of the number and clearing the frequency of that number making it 0  ==> so it's not displayed more than once
                                count++;
                                frequency[j] = 0;
                            }
                        }

                        // checking for numbers that has no 0 value in the frequency to display it once and assigning the count to that number
                        if (frequency[i] != 0)
                        {
                            frequency[i] = count;
                        }
                    }

                    // looping through the array and displaying the repeated numbers with it's count in the given format
                    for (int i = 0; i < a.Length; i++)
                    {
                        if (frequency[i] != 0)
                        {
                            Console.Write("{0}\t{1}\n", a[i], frequency[i]);
                        }
                    }
                }
                else
                {
                    // printing the validation check for user if given array was empty
                    Console.Write("The Array is empty");
                }
            }
            catch
            {
                Console.WriteLine("Exception occured while computing computeFrequency()");
            }
        }
    }
}
