// Date: 1/18/18
// Chapter 2 Case Problem 1

using static System.Console;
class GreenvilleRevenue
{
    static void Main()
    {
        WriteLine("Welcome to the...");
        WriteLine("**************");
        WriteLine("* GREENVILLE *");
        WriteLine("**************");
        WriteLine("Internal Revenue Estimator-Service");
        Write("\nPlease enter last year's number of contestants: ");
        int conNum1 = int.Parse(ReadLine());
        Write("Thank you! Now enter this year's number of contestants: ");
        int conNum2 = int.Parse(ReadLine());
        int lastRev = conNum1 * 25;
        int thisRev = conNum2 * 25;
        WriteLine("\nCalculating...Done!");
        WriteLine("\nWith an entrance fee of $25..." +
            "\nLast Year's revenue was: ${0}" +
            "\nand this year's revenue estimate is: ${1}", lastRev, thisRev);
        WriteLine("\nThank you for using the Greenville " +
            "Internal Revenue Estimator-Service");
        WriteLine("And remember...");
        WriteLine("**********************************");
        WriteLine("* The stars shine in Greenville! *");
        WriteLine("**********************************");
    }
}