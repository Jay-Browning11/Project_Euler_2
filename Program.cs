class program
{
    static void Main(string[] args)
    {
        //Find the sum of all even-valued numbers in the fibinacci sequence which do not exceed four million.

        long fib1 = 2;
        long fib2 = 1;
        long result = 0;
        long sum = 2; //Sum is initially set as 2, this is becasue the starting values wont be counted but 2 is an even number so it should be included.

        //loops while result is less than four million
        while (result < 4000000)
        {
            //if dividing by 2 equals 0 it is even
            if ((result % 2) == 0)
            {
                //adds the result value to the sum value and then assigns the total as the new sum value
                sum += result;
            }

            //fib1 and fib2 are added together and the total is assigned to result
            result = fib1 + fib2;
            //the current value of fib1 is set as fib2's value
            fib2 = fib1;
            //fib1 is given the result value
            fib1 = result;
        }

        Console.WriteLine("The answer to Project Euler 2 is..");
        Console.WriteLine(sum);
        Console.ReadKey();
    }
}
