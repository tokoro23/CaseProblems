// TK
// Date: 2/22/18
// Chapter 5 Case Problem 1
// Modified Ch2 case problem with the if-else from Ch4 and while loop from this chapter.

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
        while(conNum1 < 0 || conNum1 > 30)
        {
            Write("Invalid entry, please enter integer 0-30 inclusive: ");
            conNum1 = int.Parse(ReadLine());
        }

        Write("Thank you! Now enter this year's number of contestants: ");
        int conNum2 = int.Parse(ReadLine());
        while(conNum2 < 0 || conNum2 > 30)
        {
            Write("Invalid entry, please enter integer 0-30 inclusive: ");
            conNum2 = int.Parse(ReadLine());
        }

        int lastRev = conNum1 * 25;
        int thisRev = conNum2 * 25;

        WriteLine("\nCalculating...Done!");
        WriteLine("\nWith an entrance fee of $25..." +
            "\nLast Year's revenue was: ${0}" +
            "\nand this year's revenue estimate is: ${1}", lastRev, thisRev);
        string compMes;
        if (conNum2 > (2 * conNum1))
            compMes = "Compared to last year, the competition is over twice as large!";
        else if (conNum2 > conNum1)
            compMes = "The competition is bigger than ever!";
        else if (conNum2 < conNum1)
            compMes = "A tighter race this year! Come out and cast your vote!";
        else
            compMes = "The competition is the same as last year.";
        WriteLine(compMes);

        WriteLine("\nThank you for using the Greenville " +
            "Internal Revenue Estimator-Service");
        WriteLine("And remember...");
        WriteLine("**********************************");
        WriteLine("* The stars shine in Greenville! *");
        WriteLine("**********************************");
    }
}